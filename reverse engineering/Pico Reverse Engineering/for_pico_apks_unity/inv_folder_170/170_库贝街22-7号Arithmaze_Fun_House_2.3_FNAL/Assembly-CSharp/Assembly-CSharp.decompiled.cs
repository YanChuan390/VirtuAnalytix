using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using AOT;
using BoundarySystem_Ext;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Framework;
using Framework.Utility;
using InfinityEngine.Attributes;
using InfinityEngine.DesignPatterns;
using InfinityEngine.Localization;
using InfinityEngine.Utils;
using LitJson;
using Models;
using Newtonsoft.Json;
using Proyecto26;
using Proyecto26.Common;
using Pvr_UnitySDKAPI;
using Pvr_UnitySDKAPI.Achievement;
using RSG;
using RSG.Exceptions;
using RSG.Promises;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Networking;
using UnityEngine.Profiling;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.UI;
using UnityEngine.XR;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Assembly-CSharp-Editor")]
[assembly: AssemblyVersion("0.0.0.0")]
public class MainScript : MonoBehaviour
{
	private readonly string basePath = "https://jsonplaceholder.typicode.com";

	private RequestHelper currentRequest;

	private void LogMessage(string title, string message)
	{
		UnityEngine.Debug.Log(message);
	}

	public void Get()
	{
		RestClient.DefaultRequestHeaders["Authorization"] = "Bearer ...";
		RequestHelper requestOptions = null;
		RestClient.GetArray<Post>(basePath + "/posts").Then(delegate(Post[] res)
		{
			LogMessage("Posts", JsonHelper.ArrayToJsonString(res, prettyPrint: true));
			return RestClient.GetArray<Todo>(basePath + "/todos");
		}).Then(delegate(Todo[] res)
		{
			LogMessage("Todos", JsonHelper.ArrayToJsonString(res, prettyPrint: true));
			return RestClient.GetArray<User>(basePath + "/users");
		})
			.Then(delegate(User[] res)
			{
				LogMessage("Users", JsonHelper.ArrayToJsonString(res, prettyPrint: true));
				requestOptions = new RequestHelper
				{
					Uri = basePath + "/photos",
					Headers = new Dictionary<string, string> { { "Authorization", "Other token..." } },
					EnableDebug = true
				};
				return RestClient.GetArray<Photo>(requestOptions);
			})
			.Then(delegate
			{
				LogMessage("Header", requestOptions.GetHeader("Authorization"));
				RestClient.CleanDefaultHeaders();
			})
			.Catch(delegate(Exception err)
			{
				LogMessage("Error", err.Message);
			});
	}

	public void Post()
	{
		currentRequest = new RequestHelper
		{
			Uri = basePath + "/posts",
			Body = new Post
			{
				title = "foo",
				body = "bar",
				userId = 1
			}
		};
		RestClient.Post<Post>(currentRequest).Then(delegate(Post res)
		{
			LogMessage("Success", JsonUtility.ToJson(res, prettyPrint: true));
		}).Catch(delegate(Exception err)
		{
			LogMessage("Error", err.Message);
		});
	}

	public void Put()
	{
		currentRequest = new RequestHelper
		{
			Uri = basePath + "/posts/1",
			Body = new Post
			{
				title = "foo",
				body = "bar",
				userId = 1
			},
			Retries = 5,
			RetrySecondsDelay = 1f,
			RetryCallback = delegate(RequestException err, int retries)
			{
				UnityEngine.Debug.Log($"Retry #{retries} Status {err.StatusCode}\nError: {err}");
			}
		};
		RestClient.Put(currentRequest, delegate(RequestException err, ResponseHelper res, Post body)
		{
			if (err != null)
			{
				LogMessage("Error", err.Message);
			}
			else
			{
				LogMessage("Success", JsonUtility.ToJson(body, prettyPrint: true));
			}
		});
	}

	public void Delete()
	{
		RestClient.Delete(basePath + "/posts/1", delegate(RequestException err, ResponseHelper res)
		{
			if (err != null)
			{
				LogMessage("Error", err.Message);
			}
			else
			{
				LogMessage("Success", "Status: " + res.StatusCode);
			}
		});
	}

	public void AbortRequest()
	{
		if (currentRequest != null)
		{
			currentRequest.Abort();
			currentRequest = null;
		}
	}

	public void DownloadFile()
	{
		string text = "https://raw.githubusercontent.com/IonDen/ion.sound/master/sounds/bell_ring.ogg";
		AudioType audioType = AudioType.OGGVORBIS;
		RestClient.Get(new RequestHelper
		{
			Uri = text,
			DownloadHandler = new DownloadHandlerAudioClip(text, audioType)
		}).Then(delegate(ResponseHelper res)
		{
			AudioSource component = GetComponent<AudioSource>();
			component.clip = ((DownloadHandlerAudioClip)res.Request.downloadHandler).audioClip;
			component.Play();
		}).Catch(delegate(Exception err)
		{
			LogMessage("Error", err.Message);
		});
	}
}
public class TCP2_Demo : MonoBehaviour
{
	public Material[] AffectedMaterials;

	public Texture2D[] RampTextures;

	public GUISkin GuiSkin;

	public Light DirLight;

	public GameObject Robot;

	public GameObject Ethan;

	private bool mUnityShader;

	private bool mShaderSpecular = true;

	private bool mShaderBump = true;

	private bool mShaderReflection;

	private bool mShaderRim = true;

	private bool mShaderRimOutline;

	private bool mShaderOutline = true;

	private float mRimMin = 0.5f;

	private float mRimMax = 1f;

	private bool mRampTextureFlag;

	private Texture2D mRampTexture;

	private float mRampSmoothing = 0.15f;

	private float mLightRotationX = 80f;

	private float mLightRotationY = 25f;

	private bool mViewRobot;

	private bool mRobotOutlineNormals = true;

	private TCP2_Demo_View DemoView;

	private void Awake()
	{
		DemoView = GetComponent<TCP2_Demo_View>();
		mRampTexture = RampTextures[0];
		UpdateShader();
	}

	private void OnDestroy()
	{
		RestoreRimColors();
		UpdateShader();
	}

	private void OnGUI()
	{
		GUI.skin = GuiSkin;
		GUILayout.BeginArea(new Rect(new Rect(Screen.width - 310, 20f, 290f, 30f)));
		GUILayout.BeginHorizontal();
		GUILayout.Label("Demo Character:");
		if (GUILayout.Button("Ethan", mViewRobot ? "Button" : "ButtonOn"))
		{
			mViewRobot = false;
			Robot.SetActive(value: false);
			Ethan.SetActive(value: true);
			DemoView.CharacterTransform = Ethan.transform;
		}
		if (GUILayout.Button("Robot Kyle", (!mViewRobot) ? "Button" : "ButtonOn"))
		{
			mViewRobot = true;
			Robot.SetActive(value: true);
			Ethan.SetActive(value: false);
			DemoView.CharacterTransform = Robot.transform;
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		GUILayout.BeginArea(new Rect(new Rect(Screen.width - 310, 55f, 290f, Screen.height - 40 - 90)));
		if (mViewRobot)
		{
			GUILayout.Label("Outline Normals");
			mRobotOutlineNormals = !GUILayout.Toggle(!mRobotOutlineNormals, "Regular Normals");
			mRobotOutlineNormals = GUILayout.Toggle(mRobotOutlineNormals, "TCP2's Encoded Smoothed Normals");
			GUILayout.Label("Toony Colors Pro 2 introduces an innovative way to fix broken outline caused by hard-edge shading.\nRead the documentation to learn more!", "SmallLabelShadow");
			GUI.Label(GUILayoutUtility.GetLastRect(), "Toony Colors Pro 2 introduces an innovative way to fix broken outline caused by hard-edge shading.\nRead the documentation to learn more!", "SmallLabel");
		}
		GUILayout.EndArea();
		GUILayout.BeginArea(new Rect(new Rect(Screen.width - 210, Screen.height - 60, 190f, 50f)));
		GUILayout.Label("Quality Settings:");
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("<", GUILayout.Width(26f)))
		{
			QualitySettings.DecreaseLevel(applyExpensiveChanges: true);
		}
		GUILayout.Label(QualitySettings.names[QualitySettings.GetQualityLevel()], "LabelCenter");
		if (GUILayout.Button(">", GUILayout.Width(26f)))
		{
			QualitySettings.IncreaseLevel(applyExpensiveChanges: true);
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
		GUILayout.BeginArea(new Rect(20f, 110f, Screen.width - 40, Screen.height - 40));
		mUnityShader = GUILayout.Toggle(mUnityShader, "View with Unity " + (mViewRobot ? "\"Diffuse Specular\"" : "\"Bumped Specular\""));
		GUILayout.Space(10f);
		GUI.enabled = !mUnityShader;
		GUILayout.Label("Toony Colors Pro 2 Settings");
		mShaderSpecular = GUILayout.Toggle(mShaderSpecular, "Specular");
		GUI.enabled = !mViewRobot;
		if (GUI.enabled)
		{
			mShaderBump = GUILayout.Toggle(mShaderBump, "Bump");
		}
		else
		{
			GUILayout.Toggle(false, "Bump");
		}
		GUI.enabled = !mUnityShader;
		mShaderReflection = GUILayout.Toggle(mShaderReflection, "Reflection");
		bool num = mShaderRim;
		mShaderRim = GUILayout.Toggle(mShaderRim, "Rim Lighting");
		bool num2 = num != mShaderRim;
		if (num2 && mShaderRim && mShaderRimOutline)
		{
			mShaderRimOutline = false;
		}
		if (num2 && mShaderRim)
		{
			RestoreRimColors();
		}
		bool num3 = mShaderRimOutline;
		mShaderRimOutline = GUILayout.Toggle(mShaderRimOutline, "Rim Outline");
		bool num4 = num3 != mShaderRimOutline;
		if (num4 && mShaderRimOutline && mShaderRim)
		{
			mShaderRim = false;
		}
		if (num4 && mShaderRimOutline)
		{
			RimOutlineColor();
		}
		GUI.enabled &= mShaderRim || mShaderRimOutline;
		GUILayout.BeginHorizontal();
		GUILayout.Label("Rim Min", GUILayout.Width(70f));
		mRimMin = GUILayout.HorizontalSlider(mRimMin, 0f, 1f, GUILayout.Width(130f));
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		GUILayout.Label("Rim Max", GUILayout.Width(70f));
		mRimMax = GUILayout.HorizontalSlider(mRimMax, 0f, 1f, GUILayout.Width(130f));
		GUILayout.EndHorizontal();
		GUI.enabled = !mUnityShader;
		mShaderOutline = GUILayout.Toggle(mShaderOutline, "Outline");
		GUILayout.Space(6f);
		GUILayout.Label("Ramp Settings");
		mRampTextureFlag = GUILayout.Toggle(mRampTextureFlag, "Textured Ramp");
		GUI.enabled &= mRampTextureFlag;
		GUILayout.BeginHorizontal();
		Rect rect = GUILayoutUtility.GetRect(200f, 20f, GUILayout.ExpandWidth(expand: false));
		rect.y += 4f;
		GUI.DrawTexture(rect, mRampTexture);
		if (GUILayout.Button("<", GUILayout.Width(26f)))
		{
			PrevRamp();
		}
		if (GUILayout.Button(">", GUILayout.Width(26f)))
		{
			NextRamp();
		}
		GUILayout.EndHorizontal();
		GUI.enabled = !mUnityShader;
		GUI.enabled &= !mRampTextureFlag;
		GUILayout.BeginHorizontal();
		GUILayout.Label("Smoothing", GUILayout.Width(85f));
		mRampSmoothing = GUILayout.HorizontalSlider(mRampSmoothing, 0.01f, 1f, GUILayout.Width(115f));
		GUILayout.EndHorizontal();
		if (GUI.changed)
		{
			if (mUnityShader)
			{
				UnityDiffuseShader();
			}
			else
			{
				UpdateShader();
			}
		}
		GUI.enabled = true;
		GUILayout.Space(10f);
		GUILayout.Label("Light Rotation");
		mLightRotationX = GUILayout.HorizontalSlider(mLightRotationX, 0f, 360f, GUILayout.Width(200f));
		mLightRotationY = GUILayout.HorizontalSlider(mLightRotationY, 0f, 360f, GUILayout.Width(200f));
		GUILayout.Space(4f);
		GUILayout.Label("Hold Left mouse button to rotate character", "SmallLabelShadow");
		rect = GUILayoutUtility.GetLastRect();
		GUI.Label(rect, "Hold Left mouse button to rotate character", "SmallLabel");
		GUILayout.Label("Hold Right/Middle mouse button to scroll", "SmallLabelShadow");
		rect = GUILayoutUtility.GetLastRect();
		GUI.Label(rect, "Hold Right/Middle mouse button to scroll", "SmallLabel");
		GUILayout.Label("Use mouse scroll wheel or up/down keys to zoom", "SmallLabelShadow");
		rect = GUILayoutUtility.GetLastRect();
		GUI.Label(rect, "Use mouse scroll wheel or up/down keys to zoom", "SmallLabel");
		if (GUI.changed)
		{
			Vector3 eulerAngles = DirLight.transform.eulerAngles;
			eulerAngles.y = mLightRotationX;
			eulerAngles.x = mLightRotationY;
			DirLight.transform.eulerAngles = eulerAngles;
		}
		GUILayout.EndArea();
	}

	private void UnityDiffuseShader()
	{
		Shader shader = Shader.Find("Bumped Specular");
		Shader shader2 = Shader.Find("Specular");
		Material[] affectedMaterials = AffectedMaterials;
		foreach (Material material in affectedMaterials)
		{
			if (material.name.Contains("Robot"))
			{
				material.shader = shader2;
			}
			else
			{
				material.shader = shader;
			}
		}
	}

	private void UpdateShader()
	{
		Material[] affectedMaterials = AffectedMaterials;
		foreach (Material material in affectedMaterials)
		{
			ToggleKeyword(material, mShaderSpecular, "TCP2_SPEC");
			if (!material.name.Contains("Robot"))
			{
				ToggleKeyword(material, mShaderBump, "TCP2_BUMP");
			}
			ToggleKeyword(material, mShaderReflection, "TCP2_REFLECTION_MASKED");
			ToggleKeyword(material, mShaderRim, "TCP2_RIM");
			ToggleKeyword(material, mShaderRimOutline, "TCP2_RIMO");
			ToggleKeyword(material, mShaderOutline, "OUTLINES");
			ToggleKeyword(material, mRampTextureFlag, "TCP2_RAMPTEXT");
			material.SetFloat("_RampSmooth", mRampSmoothing);
			material.SetTexture("_Ramp", mRampTexture);
			material.SetFloat("_RimMin", mRimMin);
			material.SetFloat("_RimMax", mRimMax);
			if (material.name.Contains("Robot"))
			{
				ToggleKeyword(material, mRobotOutlineNormals, "TCP2_TANGENT_AS_NORMALS");
			}
		}
		affectedMaterials = AffectedMaterials;
		foreach (Material material2 in affectedMaterials)
		{
			Shader shaderWithKeywords = TCP2_RuntimeUtils.GetShaderWithKeywords(material2);
			if (shaderWithKeywords == null)
			{
				string text = "";
				string[] shaderKeywords = material2.shaderKeywords;
				foreach (string text2 in shaderKeywords)
				{
					text = text + text2 + ",";
				}
				text = text.TrimEnd(',');
				UnityEngine.Debug.LogError("[TCP2 Demo] Can't find shader for keywords: \"" + text + "\" in material \"" + material2.name + "\"\nThe missing shaders probably need to be unpacked. See TCP2 Documentation!");
			}
			else
			{
				material2.shader = shaderWithKeywords;
			}
		}
	}

	private void RimOutlineColor()
	{
		Material[] affectedMaterials = AffectedMaterials;
		for (int i = 0; i < affectedMaterials.Length; i++)
		{
			affectedMaterials[i].SetColor("_RimColor", Color.black);
		}
	}

	private void RestoreRimColors()
	{
		Material[] affectedMaterials = AffectedMaterials;
		foreach (Material material in affectedMaterials)
		{
			if (material.name.Contains("Robot"))
			{
				material.SetColor("_RimColor", new Color(0.2f, 0.6f, 1f, 0.5f));
			}
			else
			{
				material.SetColor("_RimColor", new Color(1f, 1f, 1f, 0.25f));
			}
		}
	}

	private void ToggleKeyword(Material m, bool enabled, string keyword)
	{
		if (enabled)
		{
			m.EnableKeyword(keyword);
		}
		else
		{
			m.DisableKeyword(keyword);
		}
	}

	private void PrevRamp()
	{
		int value = Array.IndexOf(RampTextures, mRampTexture);
		value = Mathf.Clamp(value, 0, RampTextures.Length - 1);
		value--;
		if (value < 0)
		{
			value = RampTextures.Length - 1;
		}
		mRampTexture = RampTextures[value];
	}

	private void NextRamp()
	{
		int value = Array.IndexOf(RampTextures, mRampTexture);
		value = Mathf.Clamp(value, 0, RampTextures.Length - 1);
		value++;
		if (value >= RampTextures.Length)
		{
			value = 0;
		}
		mRampTexture = RampTextures[value];
	}
}
public class TCP2_Demo_PBS : MonoBehaviour
{
	[Serializable]
	public class SkyboxSetting
	{
		public Material SkyMaterial;

		public Color lightColor;

		public Vector3 DirLightEuler;
	}

	public Light DirLight;

	public GameObject PointLights;

	public MeshRenderer Robot;

	public GameObject Canvas;

	public SkyboxSetting[] SkySettings;

	public bool FlipLight = true;

	public Texture2D[] RampTextures;

	public Slider SmoothnessSlider;

	public Text SmoothnessValue;

	public Slider MetallicSlider;

	public Text MetallicValue;

	public Text BumpScaleValue;

	public Text ShaderText;

	public Text SkyboxValue;

	public Text RampValue;

	public Slider RampThresholdSlider;

	public Text RampThresholdValue;

	public Slider RampSmoothSlider;

	public Text RampSmoothValue;

	public Slider RampSmoothAddSlider;

	public Text RampSmoothAddValue;

	public RawImage RampImage;

	private int currentSky;

	private int currentRamp;

	private Material robotMaterial;

	private bool mUseOutline;

	private bool mRotatePointLights = true;

	public bool ShowPointLights
	{
		set
		{
			PointLights.SetActive(value);
		}
	}

	public bool ShowDirLight
	{
		set
		{
			DirLight.enabled = value;
		}
	}

	public bool RotatePointLights
	{
		get
		{
			return mRotatePointLights;
		}
		set
		{
			mRotatePointLights = value;
		}
	}

	public bool UseOutline
	{
		get
		{
			return mUseOutline;
		}
		set
		{
			mUseOutline = value;
			if (robotMaterial.shader.name.Contains("Toony"))
			{
				ShowTCP2Shader();
			}
		}
	}

	public bool UseRampTexture
	{
		set
		{
			robotMaterial.SetFloat("_TCP2_RAMPTEXT", value ? 1f : 0f);
			if (value)
			{
				robotMaterial.EnableKeyword("TCP2_RAMPTEXT");
			}
			else
			{
				robotMaterial.DisableKeyword("TCP2_RAMPTEXT");
			}
		}
	}

	public bool UseStylizedFresnel
	{
		set
		{
			robotMaterial.SetFloat("_TCP2_STYLIZED_FRESNEL", value ? 1f : 0f);
			if (value)
			{
				robotMaterial.EnableKeyword("TCP2_STYLIZED_FRESNEL");
			}
			else
			{
				robotMaterial.DisableKeyword("TCP2_STYLIZED_FRESNEL");
			}
		}
	}

	public bool UseStylizedSpecular
	{
		set
		{
			robotMaterial.SetFloat("_TCP2_SPEC_TOON", value ? 1f : 0f);
			if (value)
			{
				robotMaterial.EnableKeyword("TCP2_SPEC_TOON");
			}
			else
			{
				robotMaterial.DisableKeyword("TCP2_SPEC_TOON");
			}
		}
	}

	private void Awake()
	{
		robotMaterial = Robot.material;
		mUseOutline = robotMaterial.shader.name.Contains("Outline");
		MetallicSlider.value = robotMaterial.GetFloat("_Metallic");
		SmoothnessSlider.value = robotMaterial.GetFloat("_Glossiness");
		RampThresholdSlider.value = robotMaterial.GetFloat("_RampThreshold");
		RampSmoothSlider.value = robotMaterial.GetFloat("_RampSmooth");
		RampSmoothAddSlider.value = robotMaterial.GetFloat("_RampSmoothAdd");
		UpdateSky();
		UpdateRamp();
	}

	private void Update()
	{
		if (mRotatePointLights)
		{
			PointLights.transform.Rotate(Vector3.up * 20f * Time.deltaTime);
		}
		if (Input.GetKeyDown(KeyCode.H))
		{
			Canvas.SetActive(!Canvas.activeSelf);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			NextSky();
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			PrevSky();
		}
	}

	public void ToggleShader()
	{
		if (robotMaterial.shader.name.Contains("Toony"))
		{
			ShowUnityStandardShader();
			ShaderText.text = "View with TCP2 PBS shader";
		}
		else
		{
			ShowTCP2Shader();
			ShaderText.text = "View with Unity Standard shader";
		}
	}

	public void NextSky()
	{
		currentSky++;
		if (currentSky >= SkySettings.Length)
		{
			currentSky = 0;
		}
		UpdateSky();
	}

	public void PrevSky()
	{
		currentSky--;
		if (currentSky < 0)
		{
			currentSky = SkySettings.Length - 1;
		}
		UpdateSky();
	}

	public void NextRamp()
	{
		currentRamp++;
		if (currentRamp >= RampTextures.Length)
		{
			currentRamp = 0;
		}
		UpdateRamp();
	}

	public void PrevRamp()
	{
		currentRamp--;
		if (currentRamp < 0)
		{
			currentRamp = RampTextures.Length - 1;
		}
		UpdateRamp();
	}

	public void SetMetallic(float f)
	{
		robotMaterial.SetFloat("_Metallic", f);
		MetallicValue.text = f.ToString("0.00");
	}

	public void SetSmoothness(float f)
	{
		robotMaterial.SetFloat("_Glossiness", f);
		SmoothnessValue.text = f.ToString("0.00");
	}

	public void SetBumpScale(float f)
	{
		robotMaterial.SetFloat("_BumpScale", f);
		BumpScaleValue.text = f.ToString("0.00");
	}

	public void SetRampThreshold(float f)
	{
		robotMaterial.SetFloat("_RampThreshold", f);
		RampThresholdValue.text = f.ToString("0.00");
	}

	public void SetRampSmooth(float f)
	{
		robotMaterial.SetFloat("_RampSmooth", f);
		RampSmoothValue.text = f.ToString("0.00");
	}

	public void SetRampSmoothAdd(float f)
	{
		robotMaterial.SetFloat("_RampSmoothAdd", f);
		RampSmoothAddValue.text = f.ToString("0.00");
	}

	private void UpdateRamp()
	{
		robotMaterial.SetTexture("_Ramp", RampTextures[currentRamp]);
		RampValue.text = $"{currentRamp + 1}/{RampTextures.Length}";
		RampImage.texture = RampTextures[currentRamp];
	}

	private void UpdateSky()
	{
		SkyboxSetting skyboxSetting = SkySettings[currentSky];
		DirLight.transform.eulerAngles = skyboxSetting.DirLightEuler;
		if (FlipLight)
		{
			DirLight.transform.Rotate(Vector3.up, 180f, Space.Self);
		}
		DirLight.color = skyboxSetting.lightColor;
		RenderSettings.skybox = skyboxSetting.SkyMaterial;
		RenderSettings.customReflection = skyboxSetting.SkyMaterial.GetTexture("_Tex") as Cubemap;
		DynamicGI.UpdateEnvironment();
		SkyboxValue.text = $"{currentSky + 1}/{SkySettings.Length}";
	}

	private void ShowUnityStandardShader()
	{
		robotMaterial.shader = Shader.Find("Standard");
	}

	public void ShowTCP2Shader()
	{
		Shader shader = Shader.Find(mUseOutline ? "Hidden/Toony Colors Pro 2/Standard PBS Outline" : "Toony Colors Pro 2/Standard PBS");
		if (shader != null)
		{
			robotMaterial.shader = shader;
		}
	}

	private void ToggleKeyword(Material m, bool enabled, string keyword)
	{
		if (enabled)
		{
			m.EnableKeyword(keyword);
		}
		else
		{
			m.DisableKeyword(keyword);
		}
	}
}
public class TCP2_Demo_PBS_View : MonoBehaviour
{
	public Transform Pivot;

	[Header("Orbit")]
	public float OrbitStrg = 3f;

	public float OrbitClamp = 50f;

	[Header("Panning")]
	public float PanStrg = 0.1f;

	public float PanClamp = 2f;

	public float yMin;

	public float yMax;

	[Header("Zooming")]
	public float ZoomStrg = 40f;

	public float ZoomClamp = 30f;

	public float ZoomDistMin = 1f;

	public float ZoomDistMax = 2f;

	[Header("Misc")]
	public float Decceleration = 8f;

	public Rect ignoreMouseRect;

	private Vector3 mouseDelta;

	private Vector3 orbitAcceleration;

	private Vector3 panAcceleration;

	private Vector3 moveAcceleration;

	private float zoomAcceleration;

	private const float XMax = 60f;

	private const float XMin = 300f;

	private Vector3 mResetCamPos;

	private Vector3 mResetPivotPos;

	private Vector3 mResetCamRot;

	private Vector3 mResetPivotRot;

	private bool leftMouseHeld;

	private bool rightMouseHeld;

	private bool middleMouseHeld;

	private void Awake()
	{
		mResetCamPos = base.transform.position;
		mResetCamRot = base.transform.eulerAngles;
		mResetPivotPos = Pivot.position;
		mResetPivotRot = Pivot.eulerAngles;
	}

	private void OnEnable()
	{
		mouseDelta = Input.mousePosition;
	}

	private void Update()
	{
		mouseDelta = Input.mousePosition - mouseDelta;
		Rect rect = ignoreMouseRect;
		rect.x = (float)Screen.width - ignoreMouseRect.width;
		bool flag = rect.Contains(Input.mousePosition);
		if (Input.GetMouseButtonDown(0))
		{
			leftMouseHeld = !flag;
		}
		else if (Input.GetMouseButtonUp(0) || !Input.GetMouseButton(0))
		{
			leftMouseHeld = false;
		}
		if (Input.GetMouseButtonDown(1))
		{
			rightMouseHeld = !flag;
		}
		else if (Input.GetMouseButtonUp(1) || !Input.GetMouseButton(1))
		{
			rightMouseHeld = false;
		}
		if (Input.GetMouseButtonDown(2))
		{
			middleMouseHeld = !flag;
		}
		else if (Input.GetMouseButtonUp(2) || !Input.GetMouseButton(2))
		{
			middleMouseHeld = false;
		}
		if (leftMouseHeld)
		{
			orbitAcceleration.x += Mathf.Clamp(mouseDelta.x * OrbitStrg, 0f - OrbitClamp, OrbitClamp);
			orbitAcceleration.y += Mathf.Clamp((0f - mouseDelta.y) * OrbitStrg, 0f - OrbitClamp, OrbitClamp);
		}
		else if (middleMouseHeld || rightMouseHeld)
		{
			panAcceleration.y += Mathf.Clamp((0f - mouseDelta.y) * PanStrg, 0f - PanClamp, PanClamp);
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			ResetView();
		}
		Vector3 localEulerAngles = base.transform.localEulerAngles;
		if (localEulerAngles.x < 180f && localEulerAngles.x >= 60f && orbitAcceleration.y > 0f)
		{
			orbitAcceleration.y = 0f;
		}
		if (localEulerAngles.x > 180f && localEulerAngles.x <= 300f && orbitAcceleration.y < 0f)
		{
			orbitAcceleration.y = 0f;
		}
		base.transform.RotateAround(Pivot.position, base.transform.right, orbitAcceleration.y * Time.deltaTime);
		base.transform.RotateAround(Pivot.position, Vector3.up, orbitAcceleration.x * Time.deltaTime);
		Vector3 position = Pivot.transform.position;
		float y = position.y;
		position.y += panAcceleration.y * Time.deltaTime;
		position.y = Mathf.Clamp(position.y, yMin, yMax);
		y = position.y - y;
		Pivot.transform.position = position;
		position = base.transform.position;
		position.y += y;
		base.transform.position = position;
		float axis = Input.GetAxis("Mouse ScrollWheel");
		zoomAcceleration += axis * ZoomStrg;
		zoomAcceleration = Mathf.Clamp(zoomAcceleration, 0f - ZoomClamp, ZoomClamp);
		float num = Vector3.Distance(base.transform.position, Pivot.position);
		if ((num >= ZoomDistMin && zoomAcceleration > 0f) || (num <= ZoomDistMax && zoomAcceleration < 0f))
		{
			base.transform.Translate(Vector3.forward * zoomAcceleration * Time.deltaTime, Space.Self);
		}
		orbitAcceleration = Vector3.Lerp(orbitAcceleration, Vector3.zero, Decceleration * Time.deltaTime);
		panAcceleration = Vector3.Lerp(panAcceleration, Vector3.zero, Decceleration * Time.deltaTime);
		zoomAcceleration = Mathf.Lerp(zoomAcceleration, 0f, Decceleration * Time.deltaTime);
		moveAcceleration = Vector3.Lerp(moveAcceleration, Vector3.zero, Decceleration * Time.deltaTime);
		mouseDelta = Input.mousePosition;
	}

	public void ResetView()
	{
		moveAcceleration = Vector3.zero;
		orbitAcceleration = Vector3.zero;
		panAcceleration = Vector3.zero;
		zoomAcceleration = 0f;
		base.transform.position = mResetCamPos;
		base.transform.eulerAngles = mResetCamRot;
		Pivot.position = mResetPivotPos;
		Pivot.eulerAngles = mResetPivotRot;
	}
}
public class TCP2_Demo_View : MonoBehaviour
{
	[Header("Orbit")]
	public float OrbitStrg = 3f;

	public float OrbitClamp = 50f;

	[Header("Panning")]
	public float PanStrg = 0.1f;

	public float PanClamp = 2f;

	[Header("Zooming")]
	public float ZoomStrg = 40f;

	public float ZoomClamp = 30f;

	[Header("Misc")]
	public float Decceleration = 8f;

	public Transform CharacterTransform;

	private Vector3 mouseDelta;

	private Vector3 orbitAcceleration;

	private Vector3 panAcceleration;

	private Vector3 moveAcceleration;

	private float zoomAcceleration;

	private const float XMax = 60f;

	private const float XMin = 300f;

	private Vector3 mResetCamPos;

	private Vector3 mResetCamRot;

	private bool mMouseDown;

	private void Awake()
	{
		mResetCamPos = Camera.main.transform.position;
		mResetCamRot = Camera.main.transform.eulerAngles;
	}

	private void OnEnable()
	{
		mouseDelta = Input.mousePosition;
	}

	private void Update()
	{
		mouseDelta = Input.mousePosition - mouseDelta;
		if (!mMouseDown)
		{
			mMouseDown = ((Input.GetMouseButtonDown(0) && !new Rect(0f, 65f, 230f, 260f).Contains(Input.mousePosition)) ? true : false);
		}
		else
		{
			mMouseDown = !Input.GetMouseButtonUp(0);
		}
		if (mMouseDown)
		{
			orbitAcceleration.y -= Mathf.Clamp((0f - mouseDelta.x) * OrbitStrg, 0f - OrbitClamp, OrbitClamp);
		}
		else if (Input.GetMouseButton(2) || Input.GetMouseButton(1))
		{
			panAcceleration.y += Mathf.Clamp((0f - mouseDelta.y) * PanStrg, 0f - PanClamp, PanClamp);
		}
		orbitAcceleration.y += (Input.GetKey(KeyCode.LeftArrow) ? 15 : (Input.GetKey(KeyCode.RightArrow) ? (-15) : 0));
		zoomAcceleration += (Input.GetKey(KeyCode.UpArrow) ? 1 : (Input.GetKey(KeyCode.DownArrow) ? (-1) : 0));
		if (Input.GetKeyDown(KeyCode.R))
		{
			ResetView();
		}
		Vector3 localEulerAngles = Camera.main.transform.localEulerAngles;
		if (localEulerAngles.x < 180f && localEulerAngles.x >= 60f && orbitAcceleration.y > 0f)
		{
			orbitAcceleration.y = 0f;
		}
		if (localEulerAngles.x > 180f && localEulerAngles.x <= 300f && orbitAcceleration.y < 0f)
		{
			orbitAcceleration.y = 0f;
		}
		CharacterTransform.Rotate(-orbitAcceleration * Time.deltaTime, Space.World);
		Camera.main.transform.Translate(panAcceleration * Time.deltaTime, Space.World);
		float axis = Input.GetAxis("Mouse ScrollWheel");
		zoomAcceleration += axis * ZoomStrg;
		zoomAcceleration = Mathf.Clamp(zoomAcceleration, 0f - ZoomClamp, ZoomClamp);
		Camera.main.transform.Translate(Vector3.forward * zoomAcceleration * Time.deltaTime, Space.World);
		if (Camera.main.transform.position.y > 1.65f)
		{
			Vector3 position = Camera.main.transform.position;
			position.y = 1.65f;
			Camera.main.transform.position = position;
		}
		else if (Camera.main.transform.position.y < 0.3f)
		{
			Vector3 position2 = Camera.main.transform.position;
			position2.y = 0.3f;
			Camera.main.transform.position = position2;
		}
		if (Camera.main.transform.position.z < -1.8f)
		{
			Vector3 position3 = Camera.main.transform.position;
			position3.z = -1.8f;
			Camera.main.transform.position = position3;
		}
		else if (Camera.main.transform.position.z > -0.6f)
		{
			Vector3 position4 = Camera.main.transform.position;
			position4.z = -0.6f;
			Camera.main.transform.position = position4;
		}
		orbitAcceleration = Vector3.Lerp(orbitAcceleration, Vector3.zero, Decceleration * Time.deltaTime);
		panAcceleration = Vector3.Lerp(panAcceleration, Vector3.zero, Decceleration * Time.deltaTime);
		zoomAcceleration = Mathf.Lerp(zoomAcceleration, 0f, Decceleration * Time.deltaTime);
		moveAcceleration = Vector3.Lerp(moveAcceleration, Vector3.zero, Decceleration * Time.deltaTime);
		mouseDelta = Input.mousePosition;
	}

	public void ResetView()
	{
		Camera.main.transform.position = mResetCamPos;
		Camera.main.transform.eulerAngles = mResetCamRot;
	}
}
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class TCP2_CameraDepth : MonoBehaviour
{
	public bool RenderDepth = true;

	private void OnEnable()
	{
		SetCameraDepth();
	}

	private void OnValidate()
	{
		SetCameraDepth();
	}

	private void SetCameraDepth()
	{
		Camera component = GetComponent<Camera>();
		if (RenderDepth)
		{
			component.depthTextureMode |= DepthTextureMode.Depth;
		}
		else
		{
			component.depthTextureMode &= ~DepthTextureMode.Depth;
		}
	}
}
public class TCP2_GetPosOnWater : MonoBehaviour
{
	public Material WaterMaterial;

	[Tooltip("Height scale, for example if the water mesh is scaled along its Y axis")]
	public float heightScale = 1f;

	[Space]
	[Tooltip("Will make the object stick to the water plane")]
	public bool followWaterHeight = true;

	[Tooltip("Y Position offset")]
	public float heightOffset;

	[Space]
	[Tooltip("Will align the object to the wave normal based on its position")]
	public bool followWaterNormal;

	[Tooltip("Determine the object's up axis (when following wave normal)")]
	public Vector3 upAxis = new Vector3(0f, 1f, 0f);

	[Tooltip("Rotation of the object once it's been affected by the water normal")]
	public Vector3 postRotation = new Vector3(0f, 0f, 0f);

	[SerializeField]
	[HideInInspector]
	private bool isValid;

	[SerializeField]
	[HideInInspector]
	private int sineCount;

	private float[] sinePosOffsetsX = new float[8] { 1f, 2.2f, 2.7f, 3.4f, 1.4f, 1.8f, 4.2f, 3.6f };

	private float[] sinePosOffsetsZ = new float[8] { 0.6f, 1.3f, 3.1f, 2.4f, 1.1f, 2.8f, 1.7f, 4.3f };

	private float[] sinePhsOffsetsX = new float[8] { 1f, 1.3f, 0.7f, 1.75f, 0.2f, 2.6f, 0.7f, 3.1f };

	private float[] sinePhsOffsetsZ = new float[8] { 2.2f, 0.4f, 3.3f, 2.9f, 0.5f, 4.8f, 3.1f, 2.3f };

	private void LateUpdate()
	{
		if (followWaterHeight)
		{
			Vector3 positionOnWater = GetPositionOnWater(base.transform.position);
			positionOnWater.y += heightOffset;
			base.transform.position = positionOnWater;
		}
		if (followWaterNormal)
		{
			base.transform.rotation = Quaternion.FromToRotation(upAxis, GetNormalOnWater(base.transform.position));
			base.transform.Rotate(postRotation, Space.Self);
		}
	}

	public Vector3 GetPositionOnWater(Vector3 worldPosition)
	{
		if (!isValid)
		{
			UnityEngine.Debug.LogWarning("Invalid Water Material, returning the same worldPosition");
			return worldPosition;
		}
		float @float = WaterMaterial.GetFloat("_WaveFrequency");
		float num = WaterMaterial.GetFloat("_WaveHeight") * heightScale;
		float float2 = WaterMaterial.GetFloat("_WaveSpeed");
		float num2 = Time.time * float2;
		float num3 = worldPosition.x * @float;
		float num4 = worldPosition.z * @float;
		float num5 = 0f;
		float num6 = 0f;
		switch (sineCount)
		{
		case 1:
			num5 = Mathf.Sin(num3 + num2) * num;
			num6 = Mathf.Sin(num4 + num2) * num;
			break;
		case 2:
			num5 = (Mathf.Sin(sinePosOffsetsX[0] * num3 + sinePhsOffsetsX[0] * num2) + Mathf.Sin(sinePosOffsetsX[1] * num3 + sinePhsOffsetsX[1] * num2)) * num / 2f;
			num6 = (Mathf.Sin(sinePosOffsetsZ[0] * num4 + sinePhsOffsetsZ[0] * num2) + Mathf.Sin(sinePosOffsetsZ[1] * num4 + sinePhsOffsetsZ[1] * num2)) * num / 2f;
			break;
		case 4:
			num5 = (Mathf.Sin(sinePosOffsetsX[0] * num3 + sinePhsOffsetsX[0] * num2) + Mathf.Sin(sinePosOffsetsX[1] * num3 + sinePhsOffsetsX[1] * num2) + Mathf.Sin(sinePosOffsetsX[2] * num3 + sinePhsOffsetsX[2] * num2) + Mathf.Sin(sinePosOffsetsX[3] * num3 + sinePhsOffsetsX[3] * num2)) * num / 4f;
			num6 = (Mathf.Sin(sinePosOffsetsZ[0] * num4 + sinePhsOffsetsZ[0] * num2) + Mathf.Sin(sinePosOffsetsZ[1] * num4 + sinePhsOffsetsZ[1] * num2) + Mathf.Sin(sinePosOffsetsZ[2] * num4 + sinePhsOffsetsZ[2] * num2) + Mathf.Sin(sinePosOffsetsZ[3] * num4 + sinePhsOffsetsZ[3] * num2)) * num / 4f;
			break;
		case 8:
			num5 = (Mathf.Sin(sinePosOffsetsX[0] * num3 + sinePhsOffsetsX[0] * num2) + Mathf.Sin(sinePosOffsetsX[1] * num3 + sinePhsOffsetsX[1] * num2) + Mathf.Sin(sinePosOffsetsX[2] * num3 + sinePhsOffsetsX[2] * num2) + Mathf.Sin(sinePosOffsetsX[3] * num3 + sinePhsOffsetsX[3] * num2) + Mathf.Sin(sinePosOffsetsX[4] * num3 + sinePhsOffsetsX[4] * num2) + Mathf.Sin(sinePosOffsetsX[5] * num3 + sinePhsOffsetsX[5] * num2) + Mathf.Sin(sinePosOffsetsX[6] * num3 + sinePhsOffsetsX[6] * num2) + Mathf.Sin(sinePosOffsetsX[7] * num3 + sinePhsOffsetsX[7] * num2)) * num / 8f;
			num6 = (Mathf.Sin(sinePosOffsetsZ[0] * num4 + sinePhsOffsetsZ[0] * num2) + Mathf.Sin(sinePosOffsetsZ[1] * num4 + sinePhsOffsetsZ[1] * num2) + Mathf.Sin(sinePosOffsetsZ[2] * num4 + sinePhsOffsetsZ[2] * num2) + Mathf.Sin(sinePosOffsetsZ[3] * num4 + sinePhsOffsetsZ[3] * num2) + Mathf.Sin(sinePosOffsetsZ[4] * num4 + sinePhsOffsetsZ[4] * num2) + Mathf.Sin(sinePosOffsetsZ[5] * num4 + sinePhsOffsetsZ[5] * num2) + Mathf.Sin(sinePosOffsetsZ[6] * num4 + sinePhsOffsetsZ[6] * num2) + Mathf.Sin(sinePosOffsetsZ[7] * num4 + sinePhsOffsetsZ[7] * num2)) * num / 8f;
			break;
		}
		worldPosition.y = num5 + num6;
		return worldPosition;
	}

	public Vector3 GetNormalOnWater(Vector3 worldPosition)
	{
		if (!isValid)
		{
			UnityEngine.Debug.LogWarning("Invalid Water Material, returning the Vector3.up as the normal");
			return Vector3.up;
		}
		float @float = WaterMaterial.GetFloat("_WaveFrequency");
		float num = WaterMaterial.GetFloat("_WaveHeight") * heightScale;
		float float2 = WaterMaterial.GetFloat("_WaveSpeed");
		float num2 = Time.time * float2;
		float num3 = worldPosition.x * @float;
		float num4 = worldPosition.z * @float;
		float x = 0f;
		float z = 0f;
		switch (sineCount)
		{
		case 1:
			x = (0f - num) * Mathf.Cos(num3 + num2);
			z = (0f - num) * Mathf.Cos(num4 + num2);
			break;
		case 2:
			x = (0f - num) / 2f * (Mathf.Cos(sinePosOffsetsX[0] * num3 + sinePhsOffsetsX[0] * num2) * sinePosOffsetsX[0] + Mathf.Cos(sinePosOffsetsX[1] * num3 + sinePhsOffsetsX[1] * num2) * sinePosOffsetsX[1]);
			z = (0f - num) / 2f * (Mathf.Cos(sinePosOffsetsZ[0] * num4 + sinePhsOffsetsZ[0] * num2) * sinePosOffsetsZ[0] + Mathf.Cos(sinePosOffsetsZ[1] * num4 + sinePhsOffsetsZ[1] * num2) * sinePosOffsetsZ[1]);
			break;
		case 4:
			x = (0f - num) / 4f * (Mathf.Cos(sinePosOffsetsX[0] * num3 + sinePhsOffsetsX[0] * num2) * sinePosOffsetsX[0] + Mathf.Cos(sinePosOffsetsX[1] * num3 + sinePhsOffsetsX[1] * num2) * sinePosOffsetsX[1] + Mathf.Cos(sinePosOffsetsX[2] * num3 + sinePhsOffsetsX[2] * num2) * sinePosOffsetsX[2] + Mathf.Cos(sinePosOffsetsX[3] * num3 + sinePhsOffsetsX[3] * num2) * sinePosOffsetsX[3]);
			z = (0f - num) / 4f * (Mathf.Cos(sinePosOffsetsZ[0] * num4 + sinePhsOffsetsZ[0] * num2) * sinePosOffsetsZ[0] + Mathf.Cos(sinePosOffsetsZ[1] * num4 + sinePhsOffsetsZ[1] * num2) * sinePosOffsetsZ[1] + Mathf.Cos(sinePosOffsetsZ[2] * num4 + sinePhsOffsetsZ[2] * num2) * sinePosOffsetsZ[2] + Mathf.Cos(sinePosOffsetsZ[3] * num4 + sinePhsOffsetsZ[3] * num2) * sinePosOffsetsZ[3]);
			break;
		case 8:
			x = (0f - num) / 8f * (Mathf.Cos(sinePosOffsetsX[0] * num3 + sinePhsOffsetsX[0] * num2) * sinePosOffsetsX[0] + Mathf.Cos(sinePosOffsetsX[1] * num3 + sinePhsOffsetsX[1] * num2) * sinePosOffsetsX[1] + Mathf.Cos(sinePosOffsetsX[2] * num3 + sinePhsOffsetsX[2] * num2) * sinePosOffsetsX[2] + Mathf.Cos(sinePosOffsetsX[3] * num3 + sinePhsOffsetsX[3] * num2) * sinePosOffsetsX[3] + Mathf.Cos(sinePosOffsetsX[4] * num3 + sinePhsOffsetsX[4] * num2) * sinePosOffsetsX[4] + Mathf.Cos(sinePosOffsetsX[5] * num3 + sinePhsOffsetsX[5] * num2) * sinePosOffsetsX[5] + Mathf.Cos(sinePosOffsetsX[6] * num3 + sinePhsOffsetsX[6] * num2) * sinePosOffsetsX[6] + Mathf.Cos(sinePosOffsetsX[7] * num3 + sinePhsOffsetsX[7] * num2) * sinePosOffsetsX[7]);
			z = (0f - num) / 8f * (Mathf.Cos(sinePosOffsetsZ[0] * num4 + sinePhsOffsetsZ[0] * num2) * sinePosOffsetsZ[0] + Mathf.Cos(sinePosOffsetsZ[1] * num4 + sinePhsOffsetsZ[1] * num2) * sinePosOffsetsZ[1] + Mathf.Cos(sinePosOffsetsZ[2] * num4 + sinePhsOffsetsZ[2] * num2) * sinePosOffsetsZ[2] + Mathf.Cos(sinePosOffsetsZ[3] * num4 + sinePhsOffsetsZ[3] * num2) * sinePosOffsetsZ[3] + Mathf.Cos(sinePosOffsetsZ[4] * num4 + sinePhsOffsetsZ[4] * num2) * sinePosOffsetsZ[4] + Mathf.Cos(sinePosOffsetsZ[5] * num4 + sinePhsOffsetsZ[5] * num2) * sinePosOffsetsZ[5] + Mathf.Cos(sinePosOffsetsZ[6] * num4 + sinePhsOffsetsZ[6] * num2) * sinePosOffsetsZ[6] + Mathf.Cos(sinePosOffsetsZ[7] * num4 + sinePhsOffsetsZ[7] * num2) * sinePosOffsetsZ[7]);
			break;
		}
		return new Vector3(x, 1f, z).normalized;
	}
}
[ExecuteInEditMode]
public class TCP2_PlanarReflection : MonoBehaviour
{
	public bool m_DisablePixelLights;

	public int m_TextureSize = 1024;

	public float m_ClipPlaneOffset = 0.07f;

	public LayerMask m_ReflectLayers = -1;

	private Hashtable m_ReflectionCameras = new Hashtable();

	private RenderTexture m_ReflectionTexture;

	private int m_OldReflectionTextureSize;

	private static bool s_InsideRendering;

	public void OnWillRenderObject()
	{
		Renderer component = GetComponent<Renderer>();
		if (!base.enabled || !component || !component.sharedMaterial || !component.enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if (!current || s_InsideRendering)
		{
			return;
		}
		s_InsideRendering = true;
		CreateMirrorObjects(current, out var reflectionCamera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		int pixelLightCount = QualitySettings.pixelLightCount;
		if (m_DisablePixelLights)
		{
			QualitySettings.pixelLightCount = 0;
		}
		UpdateCameraModes(current, reflectionCamera);
		float w = 0f - Vector3.Dot(up, position) - m_ClipPlaneOffset;
		Vector4 plane = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 reflectionMat = Matrix4x4.zero;
		CalculateReflectionMatrix(ref reflectionMat, plane);
		Vector3 position2 = current.transform.position;
		Vector3 position3 = reflectionMat.MultiplyPoint(position2);
		reflectionCamera.worldToCameraMatrix = current.worldToCameraMatrix * reflectionMat;
		Vector4 clipPlane = CameraSpacePlane(reflectionCamera, position, up, 1f);
		Matrix4x4 projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
		reflectionCamera.projectionMatrix = projectionMatrix;
		reflectionCamera.cullingMask = -17 & m_ReflectLayers.value;
		reflectionCamera.targetTexture = m_ReflectionTexture;
		GL.invertCulling = true;
		reflectionCamera.transform.position = position3;
		Vector3 eulerAngles = current.transform.eulerAngles;
		reflectionCamera.transform.eulerAngles = new Vector3(0f, eulerAngles.y, eulerAngles.z);
		reflectionCamera.Render();
		reflectionCamera.transform.position = position2;
		GL.invertCulling = false;
		Material[] sharedMaterials = component.sharedMaterials;
		foreach (Material material in sharedMaterials)
		{
			if (material.HasProperty("_ReflectionTex"))
			{
				material.SetTexture("_ReflectionTex", m_ReflectionTexture);
			}
		}
		if (m_DisablePixelLights)
		{
			QualitySettings.pixelLightCount = pixelLightCount;
		}
		s_InsideRendering = false;
	}

	private void OnDisable()
	{
		if ((bool)m_ReflectionTexture)
		{
			UnityEngine.Object.DestroyImmediate(m_ReflectionTexture);
			m_ReflectionTexture = null;
		}
		foreach (DictionaryEntry reflectionCamera in m_ReflectionCameras)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)reflectionCamera.Value).gameObject);
		}
		m_ReflectionCameras.Clear();
	}

	private void UpdateCameraModes(Camera src, Camera dest)
	{
		if (dest == null)
		{
			return;
		}
		dest.clearFlags = src.clearFlags;
		dest.backgroundColor = src.backgroundColor;
		if (src.clearFlags == CameraClearFlags.Skybox)
		{
			Skybox skybox = src.GetComponent(typeof(Skybox)) as Skybox;
			Skybox skybox2 = dest.GetComponent(typeof(Skybox)) as Skybox;
			if (!skybox || !skybox.material)
			{
				skybox2.enabled = false;
			}
			else
			{
				skybox2.enabled = true;
				skybox2.material = skybox.material;
			}
		}
		dest.farClipPlane = src.farClipPlane;
		dest.nearClipPlane = src.nearClipPlane;
		dest.orthographic = src.orthographic;
		dest.fieldOfView = src.fieldOfView;
		dest.aspect = src.aspect;
		dest.orthographicSize = src.orthographicSize;
	}

	private void CreateMirrorObjects(Camera currentCamera, out Camera reflectionCamera)
	{
		reflectionCamera = null;
		if (!m_ReflectionTexture || m_OldReflectionTextureSize != m_TextureSize)
		{
			if ((bool)m_ReflectionTexture)
			{
				UnityEngine.Object.DestroyImmediate(m_ReflectionTexture);
			}
			m_ReflectionTexture = new RenderTexture(m_TextureSize, m_TextureSize, 16);
			m_ReflectionTexture.name = "__MirrorReflection" + GetInstanceID();
			m_ReflectionTexture.isPowerOfTwo = true;
			m_ReflectionTexture.hideFlags = HideFlags.DontSave;
			m_OldReflectionTextureSize = m_TextureSize;
		}
		reflectionCamera = m_ReflectionCameras[currentCamera] as Camera;
		if (!reflectionCamera)
		{
			GameObject gameObject = new GameObject("Mirror Refl Camera id" + GetInstanceID() + " for " + currentCamera.GetInstanceID(), typeof(Camera), typeof(Skybox));
			reflectionCamera = gameObject.GetComponent<Camera>();
			reflectionCamera.enabled = false;
			reflectionCamera.transform.position = base.transform.position;
			reflectionCamera.transform.rotation = base.transform.rotation;
			reflectionCamera.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = HideFlags.HideAndDontSave;
			m_ReflectionCameras[currentCamera] = reflectionCamera;
		}
	}

	private static float sgn(float a)
	{
		if (a > 0f)
		{
			return 1f;
		}
		if (a < 0f)
		{
			return -1f;
		}
		return 0f;
	}

	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		Vector3 point = pos + normal * m_ClipPlaneOffset;
		Matrix4x4 worldToCameraMatrix = cam.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(normal).normalized * sideSign;
		return new Vector4(rhs.x, rhs.y, rhs.z, 0f - Vector3.Dot(lhs, rhs));
	}

	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
		reflectionMat.m00 = 1f - 2f * plane[0] * plane[0];
		reflectionMat.m01 = -2f * plane[0] * plane[1];
		reflectionMat.m02 = -2f * plane[0] * plane[2];
		reflectionMat.m03 = -2f * plane[3] * plane[0];
		reflectionMat.m10 = -2f * plane[1] * plane[0];
		reflectionMat.m11 = 1f - 2f * plane[1] * plane[1];
		reflectionMat.m12 = -2f * plane[1] * plane[2];
		reflectionMat.m13 = -2f * plane[3] * plane[1];
		reflectionMat.m20 = -2f * plane[2] * plane[0];
		reflectionMat.m21 = -2f * plane[2] * plane[1];
		reflectionMat.m22 = 1f - 2f * plane[2] * plane[2];
		reflectionMat.m23 = -2f * plane[3] * plane[2];
		reflectionMat.m30 = 0f;
		reflectionMat.m31 = 0f;
		reflectionMat.m32 = 0f;
		reflectionMat.m33 = 1f;
	}
}
public static class TCP2_RuntimeUtils
{
	private const string BASE_SHADER_PATH = "Toony Colors Pro 2/";

	private const string VARIANT_SHADER_PATH = "Hidden/Toony Colors Pro 2/Variants/";

	private const string BASE_SHADER_NAME = "Desktop";

	private const string BASE_SHADER_NAME_MOB = "Mobile";

	private static List<string[]> ShaderVariants = new List<string[]>
	{
		new string[2] { "Specular", "TCP2_SPEC" },
		new string[3] { "Reflection", "TCP2_REFLECTION", "TCP2_REFLECTION_MASKED" },
		new string[2] { "Matcap", "TCP2_MC" },
		new string[2] { "Rim", "TCP2_RIM" },
		new string[2] { "RimOutline", "TCP2_RIMO" },
		new string[2] { "Outline", "OUTLINES" },
		new string[2] { "OutlineBlending", "OUTLINE_BLENDING" }
	};

	public static Shader GetShaderWithKeywords(Material material)
	{
		string text = ((material.shader != null && material.shader.name.ToLower().Contains("mobile")) ? "Mobile" : "Desktop");
		string text2 = text;
		foreach (string[] shaderVariant in ShaderVariants)
		{
			string[] shaderKeywords = material.shaderKeywords;
			foreach (string text3 in shaderKeywords)
			{
				for (int j = 1; j < shaderVariant.Length; j++)
				{
					if (text3 == shaderVariant[j])
					{
						text2 = text2 + " " + shaderVariant[0];
					}
				}
			}
		}
		text2 = text2.TrimEnd();
		string text4 = "Toony Colors Pro 2/";
		if (text2 != text)
		{
			text4 = "Hidden/Toony Colors Pro 2/Variants/";
		}
		return Shader.Find(text4 + text2);
	}
}
public class TCP2_ShaderUpdateUnityTime : MonoBehaviour
{
	private void LateUpdate()
	{
		Shader.SetGlobalFloat("unityTime", Time.time);
	}
}
public class Grabber : MonoBehaviour
{
	public float grabBegin = 0.55f;

	public float grabEnd = 0.35f;

	[SerializeField]
	protected bool m_parentHeldObject;

	[SerializeField]
	protected Transform m_gripTransform;

	[SerializeField]
	protected Collider[] m_grabVolumes;

	[SerializeField]
	public ControllerVariety hand;

	[SerializeField]
	protected Transform m_parentTransform;

	protected bool m_grabVolumeEnabled = true;

	protected Vector3 m_lastPos;

	protected Quaternion m_lastRot;

	protected Quaternion m_anchorOffsetRotation;

	protected Vector3 m_anchorOffsetPosition;

	protected float m_prevFlex;

	protected Grabbable m_grabbedObj;

	protected Vector3 m_grabbedObjectPosOff;

	protected Quaternion m_grabbedObjectRotOff;

	protected Dictionary<Grabbable, int> m_grabCandidates = new Dictionary<Grabbable, int>();

	protected bool operatingWithoutOVRCameraRig = true;

	public Grabbable grabbedObject => m_grabbedObj;

	public void ForceRelease(Grabbable grabbable)
	{
		if (m_grabbedObj != null && m_grabbedObj == grabbable)
		{
			GrabEnd();
		}
	}

	protected virtual void Awake()
	{
		m_anchorOffsetPosition = base.transform.localPosition;
		m_anchorOffsetRotation = base.transform.localRotation;
	}

	protected virtual void Start()
	{
		m_lastPos = base.transform.position;
		m_lastRot = base.transform.rotation;
		if (m_parentTransform == null)
		{
			if (base.gameObject.transform.parent != null)
			{
				m_parentTransform = base.gameObject.transform.parent.transform;
				return;
			}
			m_parentTransform = new GameObject().transform;
			m_parentTransform.position = Vector3.zero;
			m_parentTransform.rotation = Quaternion.identity;
		}
	}

	private void FixedUpdate()
	{
		if (operatingWithoutOVRCameraRig)
		{
			OnUpdatedAnchors();
		}
	}

	private void OnUpdatedAnchors()
	{
		Vector3 vector = m_parentTransform.TransformPoint(Controller.UPvr_GetControllerPOS((int)hand));
		Quaternion rot = m_parentTransform.rotation * Controller.UPvr_GetControllerQUA((int)hand).normalized;
		GetComponent<Rigidbody>().MovePosition(vector);
		GetComponent<Rigidbody>().MoveRotation(rot);
		if (!m_parentHeldObject)
		{
			MoveGrabbedObject(vector, rot);
		}
		m_lastPos = base.transform.position;
		m_lastRot = base.transform.rotation;
		float prevFlex = m_prevFlex;
		m_prevFlex = (float)Controller.UPvr_GetControllerTriggerValue((int)hand) / 255f;
		CheckForGrabOrRelease(prevFlex);
	}

	private void OnDestroy()
	{
		if (m_grabbedObj != null)
		{
			GrabEnd();
		}
	}

	private void OnTriggerEnter(Collider otherCollider)
	{
		Grabbable grabbable = otherCollider.GetComponent<Grabbable>() ?? otherCollider.GetComponentInParent<Grabbable>();
		if (!(grabbable == null))
		{
			int value = 0;
			m_grabCandidates.TryGetValue(grabbable, out value);
			m_grabCandidates[grabbable] = value + 1;
		}
	}

	private void OnTriggerExit(Collider otherCollider)
	{
		Grabbable grabbable = otherCollider.GetComponent<Grabbable>() ?? otherCollider.GetComponentInParent<Grabbable>();
		if (grabbable == null)
		{
			return;
		}
		int value = 0;
		if (m_grabCandidates.TryGetValue(grabbable, out value))
		{
			if (value > 1)
			{
				m_grabCandidates[grabbable] = value - 1;
			}
			else
			{
				m_grabCandidates.Remove(grabbable);
			}
		}
	}

	protected void CheckForGrabOrRelease(float prevFlex)
	{
		if (m_prevFlex >= grabBegin && prevFlex < grabBegin)
		{
			GrabBegin();
		}
		else if (m_prevFlex <= grabEnd && prevFlex > grabEnd)
		{
			GrabEnd();
		}
	}

	protected virtual void GrabBegin()
	{
		float num = float.MaxValue;
		Grabbable grabbable = null;
		Collider grabPoint = null;
		foreach (Grabbable key in m_grabCandidates.Keys)
		{
			if (key.isGrabbed && !key.allowOffhandGrab)
			{
				continue;
			}
			for (int i = 0; i < key.grabPoints.Length; i++)
			{
				Collider collider = key.grabPoints[i];
				if (!(collider == null))
				{
					Vector3 vector = collider.ClosestPointOnBounds(m_gripTransform.position);
					float sqrMagnitude = (m_gripTransform.position - vector).sqrMagnitude;
					if (sqrMagnitude < num)
					{
						num = sqrMagnitude;
						grabbable = key;
						grabPoint = collider;
					}
				}
			}
		}
		GrabVolumeEnable(enabled: false);
		if (!(grabbable != null))
		{
			return;
		}
		if (grabbable.isGrabbed)
		{
			grabbable.grabbedBy.OffhandGrabbed(grabbable);
		}
		m_grabbedObj = grabbable;
		m_grabbedObj.GrabBegin(this, grabPoint);
		m_lastPos = base.transform.position;
		m_lastRot = base.transform.rotation;
		if (m_grabbedObj.snapPosition)
		{
			m_grabbedObjectPosOff = m_gripTransform.localPosition;
			if ((bool)m_grabbedObj.snapOffset)
			{
				Vector3 position = m_grabbedObj.snapOffset.position;
				if (hand == ControllerVariety.Controller0)
				{
					position.x = 0f - position.x;
				}
				m_grabbedObjectPosOff += position;
			}
		}
		else
		{
			Vector3 vector2 = m_grabbedObj.transform.position - base.transform.position;
			vector2 = Quaternion.Inverse(base.transform.rotation) * vector2;
			m_grabbedObjectPosOff = vector2;
		}
		if (m_grabbedObj.snapOrientation)
		{
			m_grabbedObjectRotOff = m_gripTransform.localRotation;
			if ((bool)m_grabbedObj.snapOffset)
			{
				m_grabbedObjectRotOff = m_grabbedObj.snapOffset.rotation * m_grabbedObjectRotOff;
			}
		}
		else
		{
			Quaternion grabbedObjectRotOff = Quaternion.Inverse(base.transform.rotation) * m_grabbedObj.transform.rotation;
			m_grabbedObjectRotOff = grabbedObjectRotOff;
		}
		MoveGrabbedObject(m_lastPos, m_lastRot, forceTeleport: true);
		if (m_parentHeldObject)
		{
			m_grabbedObj.transform.parent = base.transform;
		}
	}

	protected virtual void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
	{
		if (!(m_grabbedObj == null))
		{
			Rigidbody grabbedRigidbody = m_grabbedObj.grabbedRigidbody;
			Vector3 position = pos + rot * m_grabbedObjectPosOff;
			Quaternion quaternion = rot * m_grabbedObjectRotOff;
			if (forceTeleport)
			{
				grabbedRigidbody.transform.position = position;
				grabbedRigidbody.transform.rotation = quaternion;
			}
			else
			{
				grabbedRigidbody.MovePosition(position);
				grabbedRigidbody.MoveRotation(quaternion);
			}
		}
	}

	protected void GrabEnd()
	{
		if (m_grabbedObj != null)
		{
			Vector3 vector = Controller.UPvr_GetVelocity((int)hand) / 1000f;
			UnityEngine.Debug.Log("linearVelocity:" + vector);
			vector.Set(vector.x, vector.y, 0f - vector.z);
			vector = m_parentTransform.TransformVector(vector);
			Vector3 vector2 = Controller.UPvr_GetAngularVelocity((int)hand) / 100f;
			UnityEngine.Debug.Log("angularVelocity:" + vector2);
			vector2.Set(vector2.x, 0f - vector2.y, 0f - vector2.z);
			vector2 = m_parentTransform.TransformVector(vector2);
			Vector3 vector3 = m_grabbedObj.grabbedTransform.TransformPoint(m_grabbedObj.grabbedRigidbody.centerOfMass) - Controller.UPvr_GetControllerPOS((int)hand);
			vector += Vector3.Cross(vector2, 1f * vector3);
			GrabbableRelease(vector, vector2);
		}
		GrabVolumeEnable(enabled: true);
	}

	protected void GrabbableRelease(Vector3 linearVelocity, Vector3 angularVelocity)
	{
		m_grabbedObj.GrabEnd(linearVelocity, angularVelocity);
		if (m_parentHeldObject)
		{
			m_grabbedObj.transform.parent = null;
		}
		m_grabbedObj = null;
	}

	protected virtual void GrabVolumeEnable(bool enabled)
	{
		if (m_grabVolumeEnabled != enabled)
		{
			m_grabVolumeEnabled = enabled;
			for (int i = 0; i < m_grabVolumes.Length; i++)
			{
				m_grabVolumes[i].enabled = m_grabVolumeEnabled;
			}
			if (!m_grabVolumeEnabled)
			{
				m_grabCandidates.Clear();
			}
		}
	}

	protected virtual void OffhandGrabbed(Grabbable grabbable)
	{
		if (m_grabbedObj == grabbable)
		{
			GrabbableRelease(Vector3.zero, Vector3.zero);
		}
	}
}
public class Interactor : MonoBehaviour
{
	[SerializeField]
	[Tooltip("The attach transform that is used as an attach point for interactables.")]
	private Transform m_AttachTransform;

	public float grabBegin = 0.55f;

	public float grabEnd = 0.35f;

	[SerializeField]
	protected Collider[] m_grabVolumes;

	[SerializeField]
	protected Transform m_gripTransform;

	[SerializeField]
	internal InputHandler.ControllerType m_controller;

	protected bool m_VolumeEnabled = true;

	protected float m_prevFlex;

	protected Interactable m_interactedObj;

	protected Interactable m_hoveredObj;

	protected Dictionary<Interactable, int> m_Candidates = new Dictionary<Interactable, int>();

	private Renderer render;

	public Transform attachTransform => m_AttachTransform;

	public Interactable interactedObject
	{
		get
		{
			return m_interactedObj;
		}
		set
		{
			m_interactedObj = value;
		}
	}

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
		render = GetInteractorRendering();
	}

	private void FixedUpdate()
	{
		float prevFlex = m_prevFlex;
		m_prevFlex = MonoSingleton<InputHandler>.Instance().GetHandTriggerValue(m_controller);
		CheckForGrabOrRelease(prevFlex);
		CheckForActivateOrDeactivate();
	}

	private void CheckForActivateOrDeactivate()
	{
		bool activateButtonDown = MonoSingleton<InputHandler>.Instance().GetActivateButtonDown(m_controller);
		bool activateButtonUp = MonoSingleton<InputHandler>.Instance().GetActivateButtonUp(m_controller);
		if (m_interactedObj != null)
		{
			if (activateButtonDown)
			{
				m_interactedObj.OnActivate(this);
			}
			if (activateButtonUp)
			{
				m_interactedObj.OnDeactivate(this);
			}
		}
	}

	private void OnDestroy()
	{
		if (m_interactedObj != null)
		{
			GrabEnd();
		}
	}

	private void OnTriggerEnter(Collider otherCollider)
	{
		UnityEngine.Debug.Log("OnTriggerEnter:" + otherCollider.name);
		Interactable component = otherCollider.GetComponent<Interactable>();
		if (component == null)
		{
			return;
		}
		UnityEngine.Debug.Log("Interactable:" + component.name);
		component.OnHoverEnter(this);
		int value = 0;
		m_Candidates.TryGetValue(component, out value);
		m_Candidates[component] = value + 1;
		Interactable closestInteractable = GetClosestInteractable();
		if (closestInteractable != null)
		{
			if (m_hoveredObj != null)
			{
				m_hoveredObj.Highlight(on: false);
			}
			m_hoveredObj = closestInteractable;
			m_hoveredObj.Highlight(on: true);
		}
	}

	private void OnTriggerExit(Collider otherCollider)
	{
		UnityEngine.Debug.Log("OnTriggerExit:" + otherCollider.name);
		Interactable component = otherCollider.GetComponent<Interactable>();
		if (component == null)
		{
			return;
		}
		if (m_hoveredObj == component)
		{
			m_hoveredObj = null;
		}
		UnityEngine.Debug.Log("Interactable:" + component.name);
		int value = 0;
		if (m_Candidates.TryGetValue(component, out value))
		{
			if (value > 1)
			{
				m_Candidates[component] = value - 1;
			}
			else
			{
				m_Candidates.Remove(component);
			}
			component.OnHoverExit(this);
		}
	}

	protected void CheckForGrabOrRelease(float prevFlex)
	{
		if (m_prevFlex >= grabBegin && prevFlex < grabBegin)
		{
			GrabBegin();
		}
		else if (m_prevFlex <= grabEnd && prevFlex > grabEnd)
		{
			GrabEnd();
		}
	}

	protected virtual void GrabBegin()
	{
		Interactable closestInteractable = GetClosestInteractable();
		GrabVolumeEnable(enabled: false);
		if (closestInteractable != null)
		{
			UnityEngine.Debug.Log("closestInteractable:" + closestInteractable.name);
			if (closestInteractable.isInteracted)
			{
				closestInteractable.interactedBy.Offhand(closestInteractable);
			}
			m_interactedObj = closestInteractable;
			m_interactedObj.GrabBegin(this);
			m_interactedObj.OnSelectEnter(this);
			if (render == null)
			{
				render = GetInteractorRendering();
			}
			UnityEngine.Debug.Log("grab begin render:" + render);
			if (render != null)
			{
				render.enabled = false;
			}
		}
	}

	private Renderer GetInteractorRendering()
	{
		MeshRenderer[] componentsInChildren = GetComponentsInChildren<MeshRenderer>();
		foreach (MeshRenderer meshRenderer in componentsInChildren)
		{
			if (meshRenderer.name.Contains("Neo"))
			{
				return meshRenderer;
			}
		}
		return null;
	}

	private Interactable GetClosestInteractable()
	{
		float num = float.MaxValue;
		Interactable result = null;
		foreach (Interactable key in m_Candidates.Keys)
		{
			for (int i = 0; i < key.interactablePoints.Length; i++)
			{
				Collider collider = key.interactablePoints[i];
				if (!(collider == null))
				{
					UnityEngine.Debug.Log("grabbableCollider:" + collider.name);
					Vector3 vector = collider.ClosestPointOnBounds(m_gripTransform.position);
					float sqrMagnitude = (m_gripTransform.position - vector).sqrMagnitude;
					UnityEngine.Debug.Log("grabbableMagSq:" + sqrMagnitude);
					if (sqrMagnitude < num)
					{
						num = sqrMagnitude;
						result = key;
					}
				}
			}
		}
		return result;
	}

	public void Offhand(Interactable interactable, bool rendered = true)
	{
		if (m_interactedObj == interactable)
		{
			m_interactedObj.OnSelectExit(this);
			Release();
			if (render == null)
			{
				render = GetComponentInChildren<Renderer>();
			}
			render.enabled = rendered;
		}
		GrabVolumeEnable(enabled: true);
	}

	private void Release()
	{
		m_interactedObj.GrabEnd();
		m_interactedObj = null;
	}

	protected void GrabEnd()
	{
		if (m_interactedObj != null)
		{
			m_interactedObj.OnSelectExit(this);
			Release();
			if (render == null)
			{
				render = GetComponentInChildren<Renderer>();
			}
			render.enabled = true;
		}
		GrabVolumeEnable(enabled: true);
	}

	protected virtual void GrabVolumeEnable(bool enabled)
	{
		if (m_VolumeEnabled != enabled)
		{
			m_VolumeEnabled = enabled;
			for (int i = 0; i < m_grabVolumes.Length; i++)
			{
				m_grabVolumes[i].enabled = m_VolumeEnabled;
			}
			if (!m_VolumeEnabled)
			{
				m_Candidates.Clear();
			}
		}
	}
}
public class ObjectHaptics : MonoBehaviour
{
	public ControllerVariety hand;

	private Interactor grabber;

	private bool isOn;

	private void Start()
	{
		grabber = GetComponent<Interactor>();
	}

	private void Update()
	{
		if (grabber.interactedObject != null)
		{
			Controller.UPvr_VibrateNeo2Controller(0.1f, (int)(1000f * Time.deltaTime), (int)hand);
			isOn = true;
		}
		if (isOn && grabber.interactedObject == null)
		{
			Controller.UPvr_VibrateNeo2Controller(0f, (int)(1000f * Time.deltaTime), (int)hand);
			isOn = false;
		}
	}
}
public class PicoInputHandler : InputHandler
{
	internal override Vector3 GetControllerVelocity(ControllerType hand)
	{
		Vector3 result = Controller.UPvr_GetVelocity((int)hand) / 1000f;
		result.z *= -1f;
		return result;
	}

	internal override bool IsMenuKeyDown()
	{
		bool num = Controller.UPvr_GetKey(0, Pvr_KeyCode.X);
		if (num)
		{
			Action action = onMenuKeyDown;
			if (action == null)
			{
				return num;
			}
			action();
		}
		return num;
	}

	internal override bool IsChangeLevelKeyDown()
	{
		return Controller.UPvr_GetKeyDown(0, Pvr_KeyCode.X);
	}

	internal override bool IsQuitKeyDown()
	{
		return Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.APP);
	}

	internal override Interactor GetInteractor(ControllerType hand)
	{
		if (hand.Equals(ControllerType.Left))
		{
			return GameObject.Find("PvrController0").GetComponent<Interactor>();
		}
		return GameObject.Find("PvrController1").GetComponent<Interactor>();
	}

	internal override float GetIndexTriggerValue(ControllerType hand)
	{
		return (float)Controller.UPvr_GetControllerTriggerValue((int)hand) / 255f;
	}

	internal override float GetHandTriggerValue(ControllerType hand)
	{
		return (float)Controller.UPvr_GetControllerTriggerValue((int)hand) / 255f;
	}

	internal override Vector2 GetThumbstickValue(ControllerType hand)
	{
		return Controller.UPvr_GetAxis2D((int)hand);
	}

	internal override void SetContollerVibration(float frequency, float amplitude, ControllerType hand)
	{
		Controller.UPvr_VibrateNeo2Controller(amplitude, 1000, (int)hand);
	}

	internal override bool GetAButtonDown(ControllerType hand)
	{
		return Controller.UPvr_GetKey(1, Pvr_KeyCode.A);
	}

	internal override bool GetActivateButtonDown(ControllerType m_controller)
	{
		return Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.A);
	}

	internal override bool GetActivateButtonUp(ControllerType m_controller)
	{
		return Controller.UPvr_GetKeyUp(1, Pvr_KeyCode.A);
	}

	internal override bool IsBackKeyDown()
	{
		return Controller.UPvr_GetKeyDown(0, Pvr_KeyCode.APP);
	}
}
public class AchievementSample : MonoBehaviour
{
	public Text dataOutput;

	public InputField getDefinitionsByNameInputField;

	public InputField getProgressByNameInputField;

	public InputField unLockInputField;

	public InputField addCountInputField;

	public InputField addFieldsInputField;

	private void Start()
	{
		AchievementCore.RegisterNetwork();
	}

	private void OnDestroy()
	{
		AchievementCore.UnRegisterNetwork();
	}

	private void OnApplicationPause(bool pause)
	{
		if (!pause)
		{
			printOutputLine("Achievement Init");
			achievementInit();
		}
	}

	private void Update()
	{
		Request.RunCallbacks();
	}

	public void AsyncInitialize()
	{
		dataOutput.text = "> ";
		printOutputLine("AsyncInitialize");
		achievementInit();
	}

	public void GetDefinitionsByName()
	{
		dataOutput.text = "> ";
		printOutputLine("GetDefinitionsByName");
		string text = getDefinitionsByNameInputField.text;
		if (text != "")
		{
			string[] achievementNames = text.Split(',');
			getAchievementDefinition(achievementNames);
			getDefinitionsByNameInputField.text = "";
		}
		else
		{
			printOutputLine("Invalid Command");
		}
	}

	public void GetProgressByName()
	{
		dataOutput.text = "> ";
		printOutputLine("GetProgressByName");
		string text = getProgressByNameInputField.text;
		if (text != "")
		{
			string[] achievementNames = text.Split(',');
			getAchievementProgress(achievementNames);
			getProgressByNameInputField.text = "";
		}
		else
		{
			printOutputLine("Invalid Command");
		}
	}

	public void GetAllDefinitions()
	{
		dataOutput.text = "> ";
		printOutputLine("GetAllDefinitions");
		getAchievementAllDefinition();
	}

	public void GetAllProgress()
	{
		dataOutput.text = "> ";
		printOutputLine("GetAllProgress");
		getAchievementAllProgress();
	}

	public void UnLock()
	{
		dataOutput.text = "> ";
		printOutputLine("UnLock");
		string text = unLockInputField.text;
		if (text != "")
		{
			unlockAchievement(text);
			unLockInputField.text = "";
		}
		else
		{
			printOutputLine("Invalid Command");
		}
	}

	public void AddCount()
	{
		dataOutput.text = "> ";
		printOutputLine("AddCount");
		string text = addCountInputField.text;
		if (text != "")
		{
			string[] array = text.Split(',');
			if (array.Length > 1)
			{
				try
				{
					Convert.ToInt64(array[1]);
				}
				catch (Exception)
				{
					printOutputLine("Invalid Command");
					throw;
				}
				addCountAchievement(array[0], array[1]);
				addCountInputField.text = "";
			}
			else
			{
				printOutputLine("Invalid Command");
			}
		}
		else
		{
			printOutputLine("Invalid Command");
		}
	}

	public void AddFields()
	{
		dataOutput.text = "> ";
		printOutputLine("AddFields");
		string text = addFieldsInputField.text;
		if (text != "")
		{
			string[] array = text.Split(',');
			if (array.Length > 1)
			{
				addFieldsAchievement(array[0], array[1]);
				addFieldsInputField.text = "";
			}
			else
			{
				printOutputLine("Invalid Command");
			}
		}
		else
		{
			printOutputLine("Invalid Command");
		}
	}

	private void achievementInit()
	{
		Achievements.Init().OnComplete(initAchievementCallback);
	}

	private void getAchievementAllDefinition()
	{
		Achievements.GetAllDefinitions().OnComplete(achievementAllDefinitionCallback);
	}

	private void getAchievementAllProgress()
	{
		Achievements.GetAllProgress().OnComplete(achievementAllProgressCallback);
	}

	private void addFieldsAchievement(string achievementName, string fields)
	{
		Achievements.AddFields(achievementName, fields).OnComplete(achievementFieldsCallback);
	}

	private void addCountAchievement(string achievementName, string count)
	{
		Achievements.AddCount(achievementName, Convert.ToInt64(count)).OnComplete(achievementCountCallback);
	}

	private void unlockAchievement(string achievementName)
	{
		Achievements.Unlock(achievementName).OnComplete(achievementUnlockCallback);
	}

	private void getAchievementProgress(string[] achievementNames)
	{
		Achievements.GetProgressByName(achievementNames).OnComplete(achievementProgressCallback);
	}

	private void getAchievementDefinition(string[] achievementNames)
	{
		Achievements.GetDefinitionsByName(achievementNames).OnComplete(achievementDefinitionCallback);
	}

	private void printOutputLine(string newLine)
	{
		dataOutput.text = "> " + newLine + Environment.NewLine + dataOutput.text;
	}

	private void achievementAllDefinitionCallback(Pvr_Message<Pvr_AchievementDefinitionList> msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Received achievement definitions success");
			Pvr_AchievementDefinitionList achievementDefinitions = msg.GetAchievementDefinitions();
			if (achievementDefinitions.HasNextPage)
			{
				Achievements.GetNextAchievementDefinitionListPage(achievementDefinitions).OnComplete(achievementAllDefinitionCallback);
			}
			{
				foreach (Pvr_AchievementDefinition item in achievementDefinitions)
				{
					printOutputLine("Bitfield Name: " + item.Name.ToString());
					switch (item.Type)
					{
					case AchievementType.Simple:
						printOutputLine("Achievement Type: Simple");
						break;
					case AchievementType.Bitfield:
						printOutputLine("Achievement Type: Bitfield");
						printOutputLine("Bitfield Length: " + item.BitfieldLength);
						printOutputLine("Target: " + item.Target);
						break;
					case AchievementType.Count:
						printOutputLine("Achievement Type: Count");
						printOutputLine("Target: " + item.Target);
						break;
					default:
						printOutputLine("Achievement Type: Unknown");
						break;
					}
					printOutputLine("Bitfield Title: " + item.Title.ToString());
					printOutputLine("Bitfield Description: " + item.Description.ToString());
					printOutputLine("Bitfield UnlockedDescription: " + item.UnlockedDescription.ToString());
					printOutputLine("Bitfield UnlockedIcon: " + item.UnlockedIcon.ToString());
					printOutputLine("Bitfield LockedIcon: " + item.LockedIcon.ToString());
					printOutputLine("Bitfield IsSecrect: " + item.IsSecrect);
				}
				return;
			}
		}
		printOutputLine("Received achievement definitions error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void achievementAllProgressCallback(Pvr_Message<Pvr_AchievementProgressList> msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Received achievement progress success");
			Pvr_AchievementProgressList achievementProgressList = msg.GetAchievementProgressList();
			if (achievementProgressList.HasNextPage)
			{
				Achievements.GetNextAchievementProgressListPage(achievementProgressList).OnComplete(achievementAllProgressCallback);
			}
			{
				foreach (Pvr_AchievementProgress item in achievementProgressList)
				{
					printOutputLine("Current Name: " + item.Name.ToString());
					if (item.IsUnlocked)
					{
						printOutputLine("Achievement Unlocked");
					}
					else
					{
						printOutputLine("Achievement Locked");
					}
					printOutputLine("Current Bitfield: " + item.Bitfield.ToString());
					printOutputLine("Current Count: " + item.Count);
					printOutputLine("Current UnlockTime: " + item.UnlockTime.ToString());
				}
				return;
			}
		}
		printOutputLine("Received achievement progress error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void achievementFieldsCallback(Pvr_Message msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Achievement fields added.");
			return;
		}
		printOutputLine("Received achievement fields add error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void achievementCountCallback(Pvr_Message msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Achievement count added.");
			return;
		}
		printOutputLine("Received achievement count add error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void achievementUnlockCallback(Pvr_Message msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Achievement unlocked");
			return;
		}
		printOutputLine("Received achievement unlock error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void achievementProgressCallback(Pvr_Message<Pvr_AchievementProgressList> msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Received achievement progress success");
			{
				foreach (Pvr_AchievementProgress achievementProgress in msg.GetAchievementProgressList())
				{
					if (achievementProgress.IsUnlocked)
					{
						printOutputLine("Achievement Unlocked");
					}
					else
					{
						printOutputLine("Achievement Locked");
					}
					printOutputLine("Current Bitfield: " + achievementProgress.Bitfield.ToString());
					printOutputLine("Current Count: " + achievementProgress.Count);
				}
				return;
			}
		}
		printOutputLine("Received achievement progress error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void achievementDefinitionCallback(Pvr_Message<Pvr_AchievementDefinitionList> msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Received achievement definitions success");
			{
				foreach (Pvr_AchievementDefinition achievementDefinition in msg.GetAchievementDefinitions())
				{
					switch (achievementDefinition.Type)
					{
					case AchievementType.Simple:
						printOutputLine("Achievement Type: Simple");
						break;
					case AchievementType.Bitfield:
						printOutputLine("Achievement Type: Bitfield");
						printOutputLine("Bitfield Length: " + achievementDefinition.BitfieldLength);
						printOutputLine("Target: " + achievementDefinition.Target);
						break;
					case AchievementType.Count:
						printOutputLine("Achievement Type: Count");
						printOutputLine("Target: " + achievementDefinition.Target);
						break;
					default:
						printOutputLine("Achievement Type: Unknown");
						break;
					}
				}
				return;
			}
		}
		printOutputLine("Received achievement definitions error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void initAchievementCallback(Pvr_Message msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Received init success");
			return;
		}
		printOutputLine("Received init error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void LoginCallback(string LoginInfo)
	{
		UnityEngine.Debug.Log("Received loginCallback:" + LoginInfo);
		printOutputLine("Received loginCallback: " + LoginInfo);
	}
}
public class Pvr_Controller : MonoBehaviour
{
	public enum UserHandNess
	{
		Right,
		Left
	}

	public enum GazeType
	{
		Never,
		DuringMotion,
		Always
	}

	public enum ControllerAxis
	{
		Controller,
		Wrist,
		Elbow,
		Shoulder
	}

	public GameObject controller0;

	public GameObject controller1;

	private static UserHandNess handness;

	public ControllerAxis Axis;

	public GazeType Gazetype;

	[Range(0f, 0.2f)]
	public float ElbowHeight;

	[Range(0f, 0.2f)]
	public float ElbowDepth;

	[Range(0f, 30f)]
	public float PointerTiltAngle = 15f;

	private float mouseX;

	private float mouseY;

	private float mouseZ;

	private Vector3[] inputDirection = new Vector3[2];

	public static Vector3 pointerPosition { get; set; }

	public static Quaternion pointerRotation { get; set; }

	public static Vector3 elbowPosition { get; set; }

	public static Quaternion elbowRotation { get; set; }

	public static Vector3 wristPosition { get; set; }

	public static Quaternion wristRotation { get; set; }

	public static Vector3 shoulderPosition { get; set; }

	public static Quaternion shoulderRotation { get; set; }

	private void Awake()
	{
		Pvr_ControllerManager.PvrServiceStartSuccessEvent += ServiceStartSuccess;
		Pvr_ControllerManager.SetControllerAbilityEvent += CheckControllerState;
		Pvr_ControllerManager.ChangeMainControllerCallBackEvent += MainControllerChanged;
		Pvr_ControllerManager.ChangeHandNessCallBackEvent += HandnessChanged;
	}

	private void Start()
	{
		handness = Controller.UPvr_GetHandNess();
		if (handness == (UserHandNess)(-1))
		{
			handness = UserHandNess.Right;
		}
	}

	private void OnDestroy()
	{
		Pvr_ControllerManager.PvrServiceStartSuccessEvent -= ServiceStartSuccess;
		Pvr_ControllerManager.SetControllerAbilityEvent -= CheckControllerState;
		Pvr_ControllerManager.ChangeMainControllerCallBackEvent -= MainControllerChanged;
		Pvr_ControllerManager.ChangeHandNessCallBackEvent -= HandnessChanged;
	}

	private void MainControllerChanged(string index)
	{
		RefreshHandness();
	}

	private void HandnessChanged(string index)
	{
		RefreshHandness();
	}

	private void ServiceStartSuccess()
	{
		RefreshHandness();
	}

	private void RefreshHandness()
	{
		handness = Controller.UPvr_GetHandNess();
		if (Controller.UPvr_GetMainHandNess() == 1)
		{
			ChangeHandNess();
		}
	}

	private void OnApplicationPause(bool pause)
	{
		if (!pause)
		{
			if (controller0 != null)
			{
				controller0.transform.localScale = Vector3.zero;
			}
			if (controller1 != null)
			{
				controller1.transform.localScale = Vector3.zero;
			}
		}
		Invoke("ShowController", 0.1f * Time.timeScale);
	}

	private void ShowController()
	{
		if (controller0 != null)
		{
			controller0.transform.localScale = Vector3.one;
		}
		if (controller1 != null)
		{
			controller1.transform.localScale = Vector3.one;
		}
	}

	private void CheckControllerState(string data)
	{
		bool num = Convert.ToBoolean(Convert.ToInt16(data.Substring(4, 1)));
		short num2 = Convert.ToInt16(data.Substring(0, 1));
		if (num && num2 == 1)
		{
			RefreshHandness();
		}
	}

	private void Update()
	{
		if (Pvr_UnitySDKManager.SDK.ControllerOnlyrot)
		{
			DoUpdateControler0();
			DoUpdateControler1();
			UpdateControlloerRay();
			return;
		}
		if (Controller.UPvr_GetPreferenceDevice() == 1)
		{
			DoUpdateControler0();
			DoUpdateControler1();
			UpdateControlloerRay();
			return;
		}
		if (controller0 != null)
		{
			controller0.transform.localRotation = Controller.UPvr_GetControllerQUA(0);
			controller0.transform.localPosition = Controller.UPvr_GetControllerPOS(0);
			UpdateControlloerRay(update0: true, update1: false);
		}
		if (controller1 != null)
		{
			controller1.transform.localRotation = Controller.UPvr_GetControllerQUA(1);
			controller1.transform.localPosition = Controller.UPvr_GetControllerPOS(1);
			UpdateControlloerRay(update0: false);
		}
	}

	public static void ChangeHandNess()
	{
		handness = ((handness == UserHandNess.Right) ? UserHandNess.Left : UserHandNess.Right);
	}

	private void DoUpdateControler0()
	{
		SetArmParaToSo((int)handness, (int)Gazetype, ElbowHeight, ElbowDepth, PointerTiltAngle);
		CalcArmModelfromSo(0);
		UpdateControllerDataSO(0);
	}

	private void DoUpdateControler1()
	{
		int hand = ((handness != UserHandNess.Left) ? 1 : 0);
		SetArmParaToSo(hand, (int)Gazetype, ElbowHeight, ElbowDepth, PointerTiltAngle);
		CalcArmModelfromSo(1);
		UpdateControllerDataSO(1);
	}

	private void UpdateControlloerRay(bool update0 = true, bool update1 = true)
	{
		if (Pvr_ControllerManager.Instance.LengthAdaptiveRay)
		{
			if (update0 && controller0 != null)
			{
				controller0.GetComponent<Pvr_ControllerModuleInit>().UpdateRay();
			}
			if (update1 && controller1 != null)
			{
				controller1.GetComponent<Pvr_ControllerModuleInit>().UpdateRay();
			}
		}
	}

	private Quaternion UpdateSimulatedFrameParams()
	{
		if (Input.GetKey(KeyCode.LeftShift))
		{
			mouseX += Input.GetAxis("Mouse X") * 5f;
			if (mouseX <= -180f)
			{
				mouseX += 360f;
			}
			else if (mouseX > 180f)
			{
				mouseX -= 360f;
			}
			mouseY -= Input.GetAxis("Mouse Y") * 2.4f;
			mouseY = Mathf.Clamp(mouseY, -80f, 80f);
		}
		else if (Input.GetKey(KeyCode.RightShift))
		{
			mouseZ += Input.GetAxis("Mouse X") * 5f;
			mouseZ = Mathf.Clamp(mouseZ, -80f, 80f);
		}
		return Quaternion.Euler(mouseY, mouseX, mouseZ);
	}

	private void SetArmParaToSo(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle)
	{
		Controller.UPvr_SetArmModelParameters(hand, gazeType, elbowHeight, elbowDepth, pointerTiltAngle);
	}

	private void CalcArmModelfromSo(int hand)
	{
		float[] array = new float[4];
		float[] array2 = new float[4];
		float[] array3 = new float[3];
		Quaternion quaternion = default(Quaternion);
		quaternion = Controller.UPvr_GetControllerQUA(hand);
		Vector3 vector = Controller.UPvr_GetAngularVelocity(hand);
		array2[0] = quaternion.x;
		array2[1] = quaternion.y;
		array2[2] = quaternion.z;
		array2[3] = quaternion.w;
		array3[0] = vector.x;
		array3[1] = vector.y;
		array3[2] = vector.z;
		if (Gazetype == GazeType.DuringMotion)
		{
			Vector3 b = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation * Vector3.forward;
			b.y = 0f;
			b.Normalize();
			float t = Mathf.Clamp((vector.magnitude - 0.2f) / 45f, 0f, 0.1f);
			inputDirection[hand] = Vector3.Slerp(inputDirection[hand], b, t);
			if (Controller.UPvr_GetKeyLongPressed(hand, Pvr_KeyCode.HOME))
			{
				inputDirection[hand] = default(Vector3);
			}
			Quaternion quaternion2 = Quaternion.FromToRotation(Vector3.forward, inputDirection[hand]);
			array[0] = quaternion2.x;
			array[1] = quaternion2.y;
			array[2] = quaternion2.z;
			array[3] = quaternion2.w;
		}
		else
		{
			array[0] = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation.x;
			array[1] = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation.y;
			array[2] = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation.z;
			array[3] = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation.w;
		}
		Controller.UPvr_CalcArmModelParameters(array, array2, array3);
	}

	public void UpdateControllerDataSO(int hand)
	{
		float[] array = new float[4];
		float[] array2 = new float[3];
		Vector3 vector;
		Quaternion localRotation;
		switch (Axis)
		{
		case ControllerAxis.Controller:
			Controller.UPvr_GetPointerPose(array, array2);
			pointerPosition = new Vector3(array2[0], array2[1], array2[2]);
			pointerRotation = new Quaternion(array[0], array[1], array[2], array[3]);
			vector = pointerPosition;
			localRotation = pointerRotation;
			break;
		case ControllerAxis.Wrist:
			Controller.UPvr_GetWristPose(array, array2);
			wristPosition = new Vector3(array2[0], array2[1], array2[2]);
			wristRotation = new Quaternion(array[0], array[1], array[2], array[3]);
			vector = wristPosition;
			localRotation = wristRotation;
			break;
		case ControllerAxis.Elbow:
			Controller.UPvr_GetElbowPose(array, array2);
			elbowPosition = new Vector3(array2[0], array2[1], array2[2]);
			elbowRotation = new Quaternion(array[0], array[1], array[2], array[3]);
			vector = elbowPosition;
			localRotation = elbowRotation;
			break;
		case ControllerAxis.Shoulder:
			Controller.UPvr_GetShoulderPose(array, array2);
			shoulderPosition = new Vector3(array2[0], array2[1], array2[2]);
			shoulderRotation = new Quaternion(array[0], array[1], array[2], array[3]);
			vector = shoulderPosition;
			localRotation = shoulderRotation;
			break;
		default:
			throw new Exception("Invalid FromJoint.");
		}
		if (hand == 0)
		{
			if (controller0 != null)
			{
				if (!Pvr_UnitySDKManager.SDK.HmdOnlyrot)
				{
					controller0.transform.localPosition = vector + Pvr_UnitySDKSensor.Instance.HeadPose.Position;
				}
				else if (Pvr_UnitySDKManager.SDK.TrackingOrigin == TrackingOrigin.FloorLevel)
				{
					controller0.transform.localPosition = vector + Pvr_UnitySDKSensor.Instance.HeadPose.Position;
				}
				else
				{
					controller0.transform.localPosition = vector;
				}
				controller0.transform.localRotation = localRotation;
			}
		}
		else if (controller1 != null)
		{
			if (!Pvr_UnitySDKManager.SDK.HmdOnlyrot)
			{
				controller1.transform.localPosition = vector + Pvr_UnitySDKSensor.Instance.HeadPose.Position;
			}
			else if (Pvr_UnitySDKManager.SDK.TrackingOrigin == TrackingOrigin.FloorLevel)
			{
				controller1.transform.localPosition = vector + Pvr_UnitySDKSensor.Instance.HeadPose.Position;
			}
			else
			{
				controller1.transform.localPosition = vector;
			}
			controller1.transform.localRotation = localRotation;
		}
	}
}
public class Pvr_ControllerDemo : MonoBehaviour
{
	public GameObject HeadSetController;

	public GameObject controller0;

	public GameObject controller1;

	public GameObject cube;

	private Ray ray;

	private GameObject currentController;

	private Transform lastHit;

	private Transform currentHit;

	[SerializeField]
	private Material normat;

	[SerializeField]
	private Material gazemat;

	[SerializeField]
	private Material clickmat;

	private bool noClick;

	private GameObject referenceObj;

	public float rayDefaultLength = 4f;

	private bool isHasController;

	private bool headcontrolmode;

	private RaycastHit hit;

	private GameObject rayLine;

	private GameObject dot;

	private Transform dragObj;

	private float disX;

	private float disY;

	private float disZ;

	private void Start()
	{
		ray = default(Ray);
		hit = default(RaycastHit);
		if (Pvr_UnitySDKManager.SDK.isHasController)
		{
			Pvr_ControllerManager.PvrServiceStartSuccessEvent += ServiceStartSuccess;
			Pvr_ControllerManager.SetControllerStateChangedEvent += ControllerStateListener;
			Pvr_ControllerManager.ControllerStatusChangeEvent += CheckControllerStateForGoblin;
			isHasController = true;
		}
		referenceObj = new GameObject("ReferenceObj");
	}

	private void OnDestroy()
	{
		if (isHasController)
		{
			Pvr_ControllerManager.PvrServiceStartSuccessEvent -= ServiceStartSuccess;
			Pvr_ControllerManager.SetControllerStateChangedEvent -= ControllerStateListener;
			Pvr_ControllerManager.ControllerStatusChangeEvent -= CheckControllerStateForGoblin;
		}
	}

	private void Update()
	{
		if (HeadSetController.activeSelf)
		{
			HeadSetController.transform.parent.localRotation = Quaternion.Euler(Pvr_UnitySDKSensor.Instance.HeadPose.Orientation.eulerAngles.x, Pvr_UnitySDKSensor.Instance.HeadPose.Orientation.eulerAngles.y, 0f);
			HeadSetController.transform.parent.localPosition = Pvr_UnitySDKSensor.Instance.HeadPose.Position;
			ray.direction = HeadSetController.transform.position - HeadSetController.transform.parent.parent.Find("Head").position;
			ray.origin = HeadSetController.transform.parent.parent.Find("Head").position;
			if (Physics.Raycast(ray, out hit))
			{
				if (HeadSetController.name == "SightPointer")
				{
					HeadSetController.transform.localScale = new Vector3(0.09f, 0.09f, 0.09f);
				}
				currentHit = hit.transform;
				if (currentHit != null && lastHit != null && currentHit != lastHit && (bool)lastHit.GetComponent<Pvr_UIGraphicRaycaster>() && lastHit.transform.gameObject.activeInHierarchy && lastHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled)
				{
					lastHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled = false;
				}
				if (currentHit != null && lastHit != null && currentHit == lastHit && (bool)currentHit.GetComponent<Pvr_UIGraphicRaycaster>() && !currentHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled)
				{
					currentHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled = true;
				}
				if (1 << hit.transform.gameObject.layer == LayerMask.GetMask("Water") && !noClick)
				{
					hit.transform.GetComponent<Renderer>().material = gazemat;
				}
				lastHit = hit.transform;
				if (Pvr_ControllerManager.Instance.LengthAdaptiveRay)
				{
					HeadSetController.transform.position = hit.point;
					HeadSetController.transform.position -= (hit.point - HeadSetController.transform.parent.parent.Find("Head").position).normalized * 0.02f;
					float num = 0.008f * hit.distance / 4f;
					Mathf.Clamp(num, 0.002f, 0.008f);
					HeadSetController.transform.localScale = new Vector3(num, num, 1f);
				}
			}
			else
			{
				if (HeadSetController.name == "SightPointer")
				{
					HeadSetController.transform.localScale = Vector3.zero;
				}
				if (lastHit != null && 1 << lastHit.transform.gameObject.layer == LayerMask.GetMask("Water"))
				{
					lastHit.transform.GetComponent<Renderer>().material = normat;
				}
				currentHit = null;
				noClick = false;
				if (Pvr_ControllerManager.Instance.LengthAdaptiveRay)
				{
					HeadSetController.transform.position = HeadSetController.transform.parent.parent.Find("Head").position + ray.direction.normalized * (0.5f + rayDefaultLength);
					HeadSetController.transform.localScale = new Vector3(0.008f, 0.008f, 1f);
				}
			}
			if ((Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetMouseButtonDown(0)) && lastHit != null && 1 << lastHit.transform.gameObject.layer == LayerMask.GetMask("Water") && currentHit != null)
			{
				lastHit.transform.GetComponent<Renderer>().material = clickmat;
				noClick = true;
			}
			return;
		}
		if (currentController != null)
		{
			ray.direction = currentController.transform.forward - currentController.transform.up * 0.25f;
			ray.origin = currentController.transform.Find("start").position;
			if (Physics.Raycast(ray, out hit))
			{
				currentHit = hit.transform;
				if (currentHit != null && lastHit != null && currentHit != lastHit && (bool)lastHit.GetComponent<Pvr_UIGraphicRaycaster>() && lastHit.transform.gameObject.activeInHierarchy && lastHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled)
				{
					lastHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled = false;
				}
				if (currentHit != null && lastHit != null && currentHit == lastHit && (bool)currentHit.GetComponent<Pvr_UIGraphicRaycaster>() && !currentHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled)
				{
					currentHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled = true;
				}
				if (1 << hit.transform.gameObject.layer == LayerMask.GetMask("Water"))
				{
					if (!noClick)
					{
						hit.transform.GetComponent<Renderer>().material = gazemat;
					}
					if (Controller.UPvr_GetKeyDown(0, Pvr_KeyCode.TOUCHPAD) || Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.TOUCHPAD) || Input.GetMouseButtonDown(0))
					{
						referenceObj.transform.position = hit.point;
						disX = hit.transform.position.x - referenceObj.transform.position.x;
						disY = hit.transform.position.y - referenceObj.transform.position.y;
						dragObj = hit.transform;
					}
					if ((Controller.UPvr_GetKey(0, Pvr_KeyCode.TOUCHPAD) || Controller.UPvr_GetKey(1, Pvr_KeyCode.TOUCHPAD) || Input.GetMouseButton(0)) && hit.transform == dragObj.transform)
					{
						referenceObj.transform.position = new Vector3(hit.point.x, hit.point.y, hit.transform.position.z);
						dragObj.position = new Vector3(referenceObj.transform.position.x + disX, referenceObj.transform.position.y + disY, hit.transform.position.z);
					}
				}
				lastHit = hit.transform;
				currentController.transform.Find("dot").position = hit.point;
				if (Pvr_ControllerManager.Instance.LengthAdaptiveRay)
				{
					float num2 = 0.178f * currentController.transform.Find("dot").localPosition.z / 3.3f;
					Mathf.Clamp(num2, 0.05f, 0.178f);
					currentController.transform.Find("dot").localScale = new Vector3(num2, num2, 1f);
				}
			}
			else
			{
				if (lastHit != null && 1 << lastHit.transform.gameObject.layer == LayerMask.GetMask("Water"))
				{
					lastHit.transform.GetComponent<Renderer>().material = normat;
				}
				currentHit = null;
				noClick = false;
				if (Pvr_ControllerManager.Instance.LengthAdaptiveRay)
				{
					currentController.transform.Find("dot").localScale = new Vector3(0.178f, 0.178f, 1f);
				}
			}
		}
		if ((Controller.UPvr_GetKeyDown(0, Pvr_KeyCode.TOUCHPAD) || Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.TOUCHPAD) || Input.GetMouseButtonDown(0)) && lastHit != null && 1 << lastHit.transform.gameObject.layer == LayerMask.GetMask("Water") && currentHit != null)
		{
			lastHit.transform.GetComponent<Renderer>().material = clickmat;
			noClick = true;
		}
	}

	private void ServiceStartSuccess()
	{
		if (Controller.UPvr_GetControllerState(0) == ControllerState.Connected || Controller.UPvr_GetControllerState(1) == ControllerState.Connected)
		{
			HeadSetController.SetActive(value: false);
		}
		else
		{
			HeadSetController.SetActive(value: true);
		}
		if (Controller.UPvr_GetMainHandNess() == 0)
		{
			currentController = controller0;
		}
		if (Controller.UPvr_GetMainHandNess() == 1)
		{
			currentController = controller1;
		}
	}

	private void ControllerStateListener(string data)
	{
		if (Controller.UPvr_GetControllerState(0) == ControllerState.Connected || Controller.UPvr_GetControllerState(1) == ControllerState.Connected)
		{
			HeadSetController.SetActive(value: false);
		}
		else
		{
			HeadSetController.SetActive(value: true);
		}
		if (Controller.UPvr_GetMainHandNess() == 0)
		{
			currentController = controller0;
		}
		if (Controller.UPvr_GetMainHandNess() == 1)
		{
			currentController = controller1;
		}
	}

	private void CheckControllerStateForGoblin(string state)
	{
		HeadSetController.SetActive(Convert.ToInt16(state) != 1);
	}

	public void SwitchControlMode()
	{
	}
}
public class Pvr_ControllerEventsExamples : MonoBehaviour
{
	private void Start()
	{
		if (!(GetComponent<Pvr_UIPointer>() == null))
		{
			GetComponent<Pvr_UIPointer>().UIPointerElementEnter += UIPointerElementEnter;
			GetComponent<Pvr_UIPointer>().UIPointerElementExit += UIPointerElementExit;
			GetComponent<Pvr_UIPointer>().UIPointerElementClick += UIPointerElementClick;
			GetComponent<Pvr_UIPointer>().UIPointerElementDragStart += UIPointerElementDragStart;
			GetComponent<Pvr_UIPointer>().UIPointerElementDragEnd += UIPointerElementDragEnd;
		}
	}

	private void UIPointerElementEnter(object sender, UIPointerEventArgs e)
	{
		PLOG.I("UI Pointer entered" + e.currentTarget.name);
	}

	private void UIPointerElementExit(object sender, UIPointerEventArgs e)
	{
		PLOG.I("UI Pointer exited" + e.currentTarget.name);
	}

	private void UIPointerElementClick(object sender, UIPointerEventArgs e)
	{
		PLOG.I("UI Pointer clicked" + e.currentTarget.name);
	}

	private void UIPointerElementDragStart(object sender, UIPointerEventArgs e)
	{
		PLOG.I("UI Pointer started dragging" + e.currentTarget.name);
	}

	private void UIPointerElementDragEnd(object sender, UIPointerEventArgs e)
	{
		PLOG.I("UI Pointer stopped dragging" + e.currentTarget.name);
	}
}
public class Pvr_ControllerInit : MonoBehaviour
{
	private ControllerVariety Variety;

	private bool isCustomModel;

	[SerializeField]
	private GameObject goblin;

	[SerializeField]
	private GameObject g2;

	[SerializeField]
	private GameObject neo2L;

	[SerializeField]
	private GameObject neo2R;

	[SerializeField]
	private GameObject neo3L;

	[SerializeField]
	private GameObject neo3R;

	[SerializeField]
	private Material standardMat;

	[SerializeField]
	private Material unlitMat;

	private int controllerType = -1;

	[HideInInspector]
	public bool loadModelSuccess;

	private int systemOrUnity;

	private JsonData curControllerData;

	private string modelName = "";

	private string texFormat = "";

	private string prePath = "";

	private string modelFilePath = "/system/media/PvrRes/controller/";

	private const string goblinTexbasePath = "Controller/controller1/controller1";

	private const string g2TexbasePath = "Controller/controller3/controller3";

	private const string neo2TexbasePath = "Controller/controller4/controller4";

	private const string neo3TexbasePath = "Controller/controller5/controller5";

	private void Awake()
	{
		Render.UPvr_GetIntConfig(15, ref systemOrUnity);
		Variety = base.transform.GetComponentInParent<Pvr_ControllerModuleInit>().Variety;
		isCustomModel = base.transform.GetComponentInParent<Pvr_ControllerModuleInit>().IsCustomModel;
		if (!isCustomModel)
		{
			Pvr_ControllerManager.PvrServiceStartSuccessEvent += ServiceStartSuccess;
			Pvr_ControllerManager.SetControllerAbilityEvent += CheckControllerStateOfAbility;
			Pvr_ControllerManager.ControllerStatusChangeEvent += CheckControllerStateForGoblin;
		}
	}

	private void OnDestroy()
	{
		Pvr_ControllerManager.PvrServiceStartSuccessEvent -= ServiceStartSuccess;
		Pvr_ControllerManager.SetControllerAbilityEvent -= CheckControllerStateOfAbility;
		Pvr_ControllerManager.ControllerStatusChangeEvent -= CheckControllerStateForGoblin;
	}

	private void OnApplicationPause(bool pause)
	{
		if (pause)
		{
			DestroyLocalController();
		}
	}

	private void ServiceStartSuccess()
	{
		int num = Controller.UPvr_GetDeviceType();
		if (controllerType != num && num != 0)
		{
			controllerType = num;
		}
		LoadResFromJson();
		if (Pvr_ControllerManager.controllerlink.neoserviceStarted)
		{
			if (Variety == ControllerVariety.Controller0)
			{
				if (Pvr_ControllerManager.controllerlink.controller0Connected)
				{
					StartCoroutine(RefreshController(0));
				}
				else
				{
					DestroyLocalController();
				}
			}
			if (Variety == ControllerVariety.Controller1)
			{
				if (Pvr_ControllerManager.controllerlink.controller1Connected)
				{
					StartCoroutine(RefreshController(1));
				}
				else
				{
					DestroyLocalController();
				}
			}
		}
		if (Pvr_ControllerManager.controllerlink.goblinserviceStarted && Variety == ControllerVariety.Controller0)
		{
			if (Pvr_ControllerManager.controllerlink.controller0Connected)
			{
				StartCoroutine(RefreshController(0));
			}
			else
			{
				DestroyLocalController();
			}
		}
	}

	private void LoadResFromJson()
	{
		string text = Pvr_UnitySDKAPI.System.UPvr_GetObjectOrArray("config.controller", 7);
		if (text != null)
		{
			JsonData jsonData = JsonMapper.ToObject(text);
			if (controllerType >= 0 && jsonData.Count >= controllerType)
			{
				curControllerData = jsonData[controllerType - 1];
				modelFilePath = (string)curControllerData["base_path"];
				modelName = (string)curControllerData["model_name"] + "_sys";
			}
		}
		else
		{
			PLOG.E("PvrLog LoadJsonFromSystem Error");
		}
	}

	private void CheckControllerStateForGoblin(string state)
	{
		int num = Controller.UPvr_GetDeviceType();
		if (Variety != 0)
		{
			return;
		}
		if (Convert.ToInt16(state) == 1)
		{
			if (controllerType != num)
			{
				DestroySysController();
				controllerType = num;
			}
			StartCoroutine(RefreshController(0));
		}
		else
		{
			DestroyLocalController();
		}
	}

	private void CheckControllerStateOfAbility(string data)
	{
		bool num = Convert.ToBoolean(Convert.ToInt16(data.Substring(4, 1)));
		short num2 = Convert.ToInt16(data.Substring(0, 1));
		int num3 = Controller.UPvr_GetDeviceType();
		if (num)
		{
			controllerType = num3;
			switch (num2)
			{
			case 0:
				if (Variety == ControllerVariety.Controller0)
				{
					StartCoroutine(RefreshController(0));
				}
				break;
			case 1:
				if (Variety == ControllerVariety.Controller1)
				{
					StartCoroutine(RefreshController(1));
				}
				break;
			}
			return;
		}
		switch (num2)
		{
		case 0:
			if (Variety == ControllerVariety.Controller0)
			{
				DestroyLocalController();
			}
			break;
		case 1:
			if (Variety == ControllerVariety.Controller1)
			{
				DestroyLocalController();
			}
			break;
		}
	}

	private void DestroyLocalController()
	{
		foreach (Transform item in base.transform)
		{
			UnityEngine.Object.Destroy(item.gameObject);
			loadModelSuccess = false;
		}
	}

	private void DestroySysController()
	{
		foreach (Transform item in base.transform)
		{
			if (item.name == modelName)
			{
				UnityEngine.Object.Destroy(item.gameObject);
				loadModelSuccess = false;
			}
		}
	}

	private IEnumerator RefreshController(int id)
	{
		yield return null;
		yield return null;
		if (Controller.UPvr_GetControllerState(id) != ControllerState.Connected)
		{
			yield break;
		}
		if (systemOrUnity == 0)
		{
			LoadControllerFromPrefab();
			if (!loadModelSuccess)
			{
				LoadControllerFromSystem(id);
			}
		}
		else
		{
			bool flag = false;
			foreach (Transform item in base.transform)
			{
				if (item.name == modelName)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				LoadControllerFromSystem(id);
				if (!loadModelSuccess)
				{
					LoadControllerFromPrefab();
				}
			}
			else
			{
				base.transform.Find(modelName).gameObject.SetActive(value: true);
			}
		}
		Pvr_ToolTips.RefreshTips();
		PLOG.I("PvrLog Controller Refresh Success");
	}

	private void LoadControllerFromPrefab()
	{
		switch (controllerType)
		{
		case 1:
		{
			Pvr_ControllerVisual pvr_ControllerVisual3 = UnityEngine.Object.Instantiate(goblin, base.transform, worldPositionStays: false).AddComponent<Pvr_ControllerVisual>();
			pvr_ControllerVisual3.currentDevice = ControllerDevice.Goblin;
			LoadTexture(pvr_ControllerVisual3, "Controller/controller1/controller1", fromRes: true);
			loadModelSuccess = true;
			break;
		}
		case 3:
		{
			Pvr_ControllerVisual pvr_ControllerVisual2 = UnityEngine.Object.Instantiate(g2, base.transform, worldPositionStays: false).AddComponent<Pvr_ControllerVisual>();
			pvr_ControllerVisual2.currentDevice = ControllerDevice.G2;
			LoadTexture(pvr_ControllerVisual2, "Controller/controller3/controller3", fromRes: true);
			loadModelSuccess = true;
			break;
		}
		case 4:
		{
			Pvr_ControllerVisual pvr_ControllerVisual4 = UnityEngine.Object.Instantiate((Variety == ControllerVariety.Controller0) ? neo2L : neo2R, base.transform, worldPositionStays: false).AddComponent<Pvr_ControllerVisual>();
			pvr_ControllerVisual4.currentDevice = ControllerDevice.Neo2;
			LoadTexture(pvr_ControllerVisual4, "Controller/controller4/controller4", fromRes: true);
			loadModelSuccess = true;
			break;
		}
		case 5:
		{
			Pvr_ControllerVisual pvr_ControllerVisual = UnityEngine.Object.Instantiate((Variety == ControllerVariety.Controller0) ? neo3L : neo3R, base.transform, worldPositionStays: false).AddComponent<Pvr_ControllerVisual>();
			pvr_ControllerVisual.currentDevice = ControllerDevice.Neo3;
			LoadTexture(pvr_ControllerVisual, "Controller/controller5/controller5", fromRes: true);
			loadModelSuccess = true;
			break;
		}
		default:
			loadModelSuccess = false;
			break;
		}
	}

	private void LoadControllerFromSystem(int id)
	{
		string text = controllerType.ToString() + id + ".obj";
		string text2 = modelFilePath + text;
		if (!File.Exists(text2))
		{
			PLOG.I("PvrLog Obj File does not exist==" + text2);
			return;
		}
		GameObject gameObject = new GameObject();
		gameObject.name = modelName;
		gameObject.AddComponent<MeshFilter>().mesh = Pvr_ObjImporter.Instance.ImportFile(text2);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.AddComponent<MeshRenderer>().material = (((int)curControllerData["material_type"] == 0) ? standardMat : unlitMat);
		loadModelSuccess = true;
		Pvr_ControllerVisual pvr_ControllerVisual = gameObject.AddComponent<Pvr_ControllerVisual>();
		switch (controllerType)
		{
		case 1:
			pvr_ControllerVisual.currentDevice = ControllerDevice.Goblin;
			break;
		case 3:
			pvr_ControllerVisual.currentDevice = ControllerDevice.G2;
			break;
		case 4:
			pvr_ControllerVisual.currentDevice = ControllerDevice.Neo2;
			break;
		case 5:
			pvr_ControllerVisual.currentDevice = ControllerDevice.Neo3;
			break;
		default:
			pvr_ControllerVisual.currentDevice = ControllerDevice.NewController;
			break;
		}
		pvr_ControllerVisual.variety = Variety;
		LoadTexture(pvr_ControllerVisual, controllerType.ToString() + id, fromRes: false);
		gameObject.transform.localRotation = Quaternion.Euler(new Vector3(0f, 180f, 0f));
		gameObject.transform.localScale = new Vector3(-0.01f, 0.01f, 0.01f);
	}

	private void LoadTexture(Pvr_ControllerVisual visual, string controllerName, bool fromRes)
	{
		if (fromRes)
		{
			texFormat = "";
			prePath = controllerName;
		}
		else
		{
			texFormat = "." + (string)curControllerData["tex_format"];
			prePath = modelFilePath + controllerName;
		}
		string filepath = prePath + "_idle" + texFormat;
		visual.m_idle = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_app" + texFormat;
		visual.m_app = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_home" + texFormat;
		visual.m_home = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_touch" + texFormat;
		visual.m_touchpad = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_volume_down" + texFormat;
		visual.m_volDn = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_volume_up" + texFormat;
		visual.m_volUp = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_trigger" + texFormat;
		visual.m_trigger = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_a" + texFormat;
		visual.m_a = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_b" + texFormat;
		visual.m_b = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_x" + texFormat;
		visual.m_x = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_y" + texFormat;
		visual.m_y = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_grip" + texFormat;
		visual.m_grip = LoadOneTexture(filepath, fromRes);
	}

	private Texture2D LoadOneTexture(string filepath, bool fromRes)
	{
		if (fromRes)
		{
			return Resources.Load<Texture2D>(filepath);
		}
		int width = (int)curControllerData["tex_width"];
		int height = (int)curControllerData["tex_height"];
		Texture2D texture2D = new Texture2D(width, height);
		texture2D.LoadImage(ReadPNG(filepath));
		return texture2D;
	}

	private byte[] ReadPNG(string path)
	{
		FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
		fileStream.Seek(0L, SeekOrigin.Begin);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, (int)fileStream.Length);
		fileStream.Close();
		fileStream.Dispose();
		fileStream = null;
		return array;
	}
}
public class Pvr_ControllerLink
{
	public AndroidJavaClass javaHummingbirdClass;

	public AndroidJavaClass javaPico2ReceiverClass;

	public AndroidJavaClass javaserviceClass;

	public AndroidJavaClass javavractivityclass;

	public AndroidJavaClass javaCVClass;

	public AndroidJavaObject activity;

	public string gameobjname = "";

	public bool picoDevice;

	public string hummingBirdMac;

	public int hummingBirdRSSI;

	public bool goblinserviceStarted;

	public bool neoserviceStarted;

	public bool controller0Connected;

	public bool controller1Connected;

	public int mainHandID;

	public Pvr_Controller.UserHandNess handness;

	public int controllerType;

	public ControllerHand Controller0;

	public ControllerHand Controller1;

	public int platFormType = -1;

	public int trackingmode = -1;

	public int systemProp = -1;

	public int enablehand6dofbyhead = -1;

	public bool switchHomeKey = true;

	private int iPhoneHMDModeEnabled;

	private float[] hbPoseData = new float[4];

	private float[] sensorData = new float[28];

	private int[] keyData = new int[134];

	private int[] neo3TouchValue = new int[15];

	private float[] fixedState = new float[7] { 0f, 0f, 0f, 1f, 0f, 0f, 0f };

	private float[] neoposeData = new float[7] { 0f, 0f, 0f, 1f, 0f, 0f, 0f };

	private int[] goblinKeyArray = new int[47];

	private int[] neoKeyArray = new int[67];

	private int[] neotriggerV = new int[9];

	private float[] velocity = new float[3];

	private float[] angularVelocity = new float[3];

	private float[] acceData = new float[3];

	public Pvr_ControllerLink(string name)
	{
		gameobjname = name;
		hummingBirdMac = "";
		hummingBirdRSSI = 0;
		UnityEngine.Debug.Log("PvrLog Controller GameObject:" + gameobjname);
		StartHummingBirdService();
		Controller0 = new ControllerHand();
		Controller0.Position = new Vector3(0f, Pvr_UnitySDKSensor.Instance.HeadPose.Position.y, 0f) + new Vector3(-0.1f, -0.3f, 0.3f);
		Controller1 = new ControllerHand();
		Controller1.Position = new Vector3(0f, Pvr_UnitySDKSensor.Instance.HeadPose.Position.y, 0f) + new Vector3(0.1f, -0.3f, 0.3f);
	}

	private void StartHummingBirdService()
	{
		try
		{
			AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			activity = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
			javaHummingbirdClass = new AndroidJavaClass("com.picovr.picovrlib.hummingbirdclient.HbClientActivity");
			javaCVClass = new AndroidJavaClass("com.picovr.picovrlib.cvcontrollerclient.ControllerClient");
			javavractivityclass = new AndroidJavaClass("com.psmart.vrlib.VrActivity");
			javaserviceClass = new AndroidJavaClass("com.picovr.picovrlib.hummingbirdclient.UnityClient");
			Pvr_UnitySDKAPI.System.Pvr_SetInitActivity(activity.GetRawObject(), javaHummingbirdClass.GetRawClass());
			Render.UPvr_GetIntConfig(4, ref platFormType);
			UnityEngine.Debug.Log("PvrLog platform" + platFormType);
			Render.UPvr_GetIntConfig(5, ref trackingmode);
			UnityEngine.Debug.Log("PvrLog trackingmode" + trackingmode);
			systemProp = GetSysproc();
			UnityEngine.Debug.Log("PvrLog systemProp" + systemProp);
			Render.UPvr_GetIntConfig(7, ref enablehand6dofbyhead);
			UnityEngine.Debug.Log("PvrLog enablehand6dofbyhead" + enablehand6dofbyhead);
			if (trackingmode == 0 || trackingmode == 1 || ((trackingmode == 3 || trackingmode == 5 || trackingmode == 6) && (systemProp == 1 || systemProp == 3)))
			{
				picoDevice = platFormType != 0;
				javaPico2ReceiverClass = new AndroidJavaClass("com.picovr.picovrlib.hummingbirdclient.HbClientReceiver");
				Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaPico2ReceiverClass, "startReceiver", activity, gameobjname);
				Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "setPlatformType", platFormType);
			}
			else
			{
				picoDevice = true;
				SetGameObjectToJar(gameobjname);
			}
			Render.UPvr_GetIntConfig(16, ref iPhoneHMDModeEnabled);
			if (iPhoneHMDModeEnabled == 1)
			{
				BindService();
			}
			else if (IsServiceExisted())
			{
				BindService();
			}
		}
		catch (AndroidJavaException ex)
		{
			PLOG.E("ConnectToAndriod--catch" + ex.Message);
		}
	}

	public bool IsServiceExisted()
	{
		bool result = false;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaserviceClass, "isServiceExisted", activity, trackingmode);
		UnityEngine.Debug.Log("PvrLog ServiceExisted ?" + result);
		return result;
	}

	public void SetGameObjectToJar(string name)
	{
		UnityEngine.Debug.Log("PvrLog SetGameObjectToJar " + name);
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setGameObjectCallback", name);
	}

	public void BindService()
	{
		UnityEngine.Debug.Log("PvrLog Bind Service");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaserviceClass, "bindService", activity, trackingmode);
	}

	public void UnBindService()
	{
		UnityEngine.Debug.Log("PvrLog UnBind Service");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaserviceClass, "unbindService", activity, trackingmode);
	}

	public void StopLark2Receiver()
	{
		UnityEngine.Debug.Log("PvrLog StopLark2Receiver");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaPico2ReceiverClass, "stopReceiver", activity);
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaPico2ReceiverClass, "stopOnBootReceiver", activity);
	}

	public void StartLark2Receiver()
	{
		UnityEngine.Debug.Log("PvrLog StartLark2Receiver");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaPico2ReceiverClass, "startReceiver", activity, gameobjname);
	}

	public void StopLark2Service()
	{
		UnityEngine.Debug.Log("PvrLog StopLark2Service");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaPico2ReceiverClass, "stopReceiver", activity);
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "unbindHbService", activity);
	}

	public void StartLark2Service()
	{
		UnityEngine.Debug.Log("PvrLog StartLark2Service");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaPico2ReceiverClass, "startReceiver", activity, gameobjname);
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "bindHbService", activity);
	}

	public int getHandness()
	{
		int result = -1;
		if (iPhoneHMDModeEnabled == 0)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javavractivityclass, "getPvrHandness", activity);
		}
		else
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getHbHandednessInSP");
		}
		PLOG.I("PvrLog GetHandness =" + result);
		return result;
	}

	public void setHandness(int hand)
	{
		PLOG.I("PvrLog SetHandness =" + hand);
		if (iPhoneHMDModeEnabled == 1)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "setHbHandednessInSP", hand);
		}
	}

	public void StartScan()
	{
		PLOG.I("PvrLog ScanHBController");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "scanHbDevice", true);
	}

	public void StopScan()
	{
		PLOG.I("PvrLog StopScanHBController");
		if (iPhoneHMDModeEnabled == 0)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "scanHbDevice", false);
		}
	}

	public int GetSysproc()
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaserviceClass, "getSysproc");
		PLOG.I("PvrLog GetSysproc" + result);
		return result;
	}

	public void ResetController(int num)
	{
		UnityEngine.Debug.Log("PvrLog ResetController" + num);
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "resetControllerSensorState", num);
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "resetHbSensorState");
		}
	}

	public void ConnectBLE()
	{
		UnityEngine.Debug.Log("PvrLog ConnectHBController" + hummingBirdMac);
		if (hummingBirdMac != "")
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "connectHbController", hummingBirdMac);
		}
	}

	public void DisConnectBLE()
	{
		UnityEngine.Debug.Log("PvrLog DisConnectHBController");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "disconnectHbController");
	}

	public bool StartUpgrade()
	{
		UnityEngine.Debug.Log("PvrLog StartUpgradeHBController");
		bool result = false;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "startUpgrade");
		return result;
	}

	public void setBinPath(string path, bool isasset)
	{
		UnityEngine.Debug.Log("PvrLog setBinPath" + path + isasset);
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "setBinPath", path, isasset);
	}

	public string GetBLEImageType()
	{
		string result = "";
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getBLEImageType");
		}
		UnityEngine.Debug.Log("PvrLog GetBLEImageType" + result);
		return result;
	}

	public long GetBLEVersion()
	{
		long result = 0L;
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getBLEVersion");
		}
		UnityEngine.Debug.Log("PvrLog GetBLEVersion" + result);
		return result;
	}

	public string GetFileImageType()
	{
		string result = "";
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getFileImageType");
		}
		UnityEngine.Debug.Log("PvrLog GetFileImageType" + result);
		return result;
	}

	public long GetFileVersion()
	{
		long result = 0L;
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getFileVersion");
		}
		UnityEngine.Debug.Log("PvrLog GetFileVersion" + result);
		return result;
	}

	public int GetControllerConnectionState(int num)
	{
		int result = -1;
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getControllerConnectionState", num);
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getHbConnectionState");
		}
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog GetControllerState:" + num + "state:" + result);
		}
		return result;
	}

	public void RebackToLauncher()
	{
		UnityEngine.Debug.Log("PvrLog RebackToLauncher");
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "startLauncher");
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "startLauncher");
		}
	}

	public void TurnUpVolume()
	{
		UnityEngine.Debug.Log("PvrLog TurnUpVolume");
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "turnUpVolume", activity);
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "turnUpVolume", activity);
		}
	}

	public void TurnDownVolume()
	{
		UnityEngine.Debug.Log("PvrLog TurnDownVolume");
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "turnDownVolume", activity);
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "turnDownVolume", activity);
		}
	}

	public float[] GetHBControllerPoseData()
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref hbPoseData, javaHummingbirdClass, "getHBSensorPose");
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog HBControllerData" + hbPoseData[0] + "," + hbPoseData[1] + "," + hbPoseData[2] + "," + hbPoseData[3]);
		}
		return hbPoseData;
	}

	public float[] GetControllerSensorData()
	{
		if (enablehand6dofbyhead == 1)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref sensorData, javaCVClass, "getControllerDataInfoBySharmem", Pvr_UnitySDKManager.SDK.headData);
		}
		else
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref sensorData, javaCVClass, "getControllerDataInfoBySharmem");
		}
		return sensorData;
	}

	public int[] GetControllerKeyData()
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref keyData, javaCVClass, "getDoubleControllerKeyEventUnityExtBySharmem");
		return keyData;
	}

	public int[] GetNeo3TouchData(int hand)
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref neo3TouchValue, javaCVClass, "getControllerTouchEvent", hand);
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog Neo3Touch hand:" + hand + "-" + neo3TouchValue[0] + neo3TouchValue[1] + neo3TouchValue[2] + neo3TouchValue[3] + neo3TouchValue[4] + "," + neo3TouchValue[5] + neo3TouchValue[6] + neo3TouchValue[7] + neo3TouchValue[8] + neo3TouchValue[9] + "," + neo3TouchValue[10] + neo3TouchValue[11] + neo3TouchValue[12] + neo3TouchValue[13] + neo3TouchValue[14]);
		}
		return neo3TouchValue;
	}

	public int GetNeo3GripValue(int hand)
	{
		int result = 0;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getControllerGripValue", hand);
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog Neo3GripValue:" + result);
		}
		return result;
	}

	public float[] GetControllerFixedSensorState(int hand)
	{
		if (trackingmode == 2 || trackingmode == 3)
		{
			return fixedState;
		}
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref fixedState, javaCVClass, "getControllerFixedSensorState", hand);
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog GetControllerFixedSensorState " + hand + "Rotation:" + fixedState[0] + "," + fixedState[1] + "," + fixedState[2] + "," + fixedState[3] + "Position:" + fixedState[4] + "," + fixedState[5] + "," + fixedState[6]);
		}
		return fixedState;
	}

	public float[] GetCvControllerPoseData(int hand)
	{
		if (enablehand6dofbyhead == 1)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref neoposeData, javaCVClass, "getControllerSensorState", hand, Pvr_UnitySDKManager.SDK.headData);
		}
		else
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref neoposeData, javaCVClass, "getControllerSensorState", hand);
		}
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog CVControllerData :" + neoposeData[0] + "," + neoposeData[1] + "," + neoposeData[2] + "," + neoposeData[3] + "," + neoposeData[4] + "," + neoposeData[5] + "," + neoposeData[6]);
		}
		return neoposeData;
	}

	public int[] GetHBControllerKeyData()
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref goblinKeyArray, javaHummingbirdClass, "getHBKeyEventUnityExt");
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog HBControllerKey" + goblinKeyArray[0] + goblinKeyArray[1] + goblinKeyArray[2] + goblinKeyArray[3] + goblinKeyArray[4] + "," + goblinKeyArray[5] + goblinKeyArray[6] + goblinKeyArray[7] + goblinKeyArray[8] + goblinKeyArray[9] + "," + goblinKeyArray[10] + goblinKeyArray[11] + goblinKeyArray[12] + goblinKeyArray[13] + goblinKeyArray[14] + "," + goblinKeyArray[15] + goblinKeyArray[16] + goblinKeyArray[17] + goblinKeyArray[18] + goblinKeyArray[19] + "," + goblinKeyArray[20] + goblinKeyArray[21] + goblinKeyArray[22] + goblinKeyArray[23] + goblinKeyArray[24] + "," + goblinKeyArray[25] + goblinKeyArray[26] + goblinKeyArray[27] + goblinKeyArray[28] + goblinKeyArray[29] + "," + goblinKeyArray[30] + goblinKeyArray[31] + goblinKeyArray[32] + goblinKeyArray[33] + goblinKeyArray[34] + "," + goblinKeyArray[35] + goblinKeyArray[36] + goblinKeyArray[37] + goblinKeyArray[38] + goblinKeyArray[39] + "," + goblinKeyArray[40] + goblinKeyArray[41] + goblinKeyArray[42] + goblinKeyArray[43] + goblinKeyArray[44] + "," + goblinKeyArray[45] + goblinKeyArray[46]);
		}
		return goblinKeyArray;
	}

	public int GetHBKeyValue()
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getTriggerKeyEvent");
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog GoblinControllerTriggerKey:" + result);
		}
		return result;
	}

	public int[] GetCvControllerKeyData(int hand)
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref neoKeyArray, javaCVClass, "getControllerKeyEventUnityExt", hand);
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog CVControllerKey hand:" + hand + "-" + neoKeyArray[0] + neoKeyArray[1] + neoKeyArray[2] + neoKeyArray[3] + neoKeyArray[4] + "," + neoKeyArray[5] + neoKeyArray[6] + neoKeyArray[7] + neoKeyArray[8] + neoKeyArray[9] + "," + neoKeyArray[10] + neoKeyArray[11] + neoKeyArray[12] + neoKeyArray[13] + neoKeyArray[14] + "," + neoKeyArray[15] + neoKeyArray[16] + neoKeyArray[17] + neoKeyArray[18] + neoKeyArray[19] + "," + neoKeyArray[20] + neoKeyArray[21] + neoKeyArray[22] + neoKeyArray[23] + neoKeyArray[24] + "," + neoKeyArray[25] + neoKeyArray[26] + neoKeyArray[27] + neoKeyArray[28] + neoKeyArray[29] + "," + neoKeyArray[30] + neoKeyArray[31] + neoKeyArray[32] + neoKeyArray[33] + neoKeyArray[34] + "," + neoKeyArray[35] + neoKeyArray[36] + neoKeyArray[37] + neoKeyArray[38] + neoKeyArray[39] + "," + neoKeyArray[40] + neoKeyArray[41] + neoKeyArray[42] + neoKeyArray[43] + neoKeyArray[44] + "," + neoKeyArray[45] + neoKeyArray[46] + neoKeyArray[47] + neoKeyArray[48] + neoKeyArray[49] + "," + neoKeyArray[50] + neoKeyArray[51] + neoKeyArray[52] + neoKeyArray[53] + neoKeyArray[54] + "," + neoKeyArray[55] + neoKeyArray[56] + neoKeyArray[57] + neoKeyArray[58] + neoKeyArray[59] + "," + neoKeyArray[60] + neoKeyArray[61] + neoKeyArray[62] + neoKeyArray[63] + neoKeyArray[64] + "," + neoKeyArray[65] + neoKeyArray[66]);
		}
		return neoKeyArray;
	}

	public int GetCVTriggerValue(int hand)
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref neotriggerV, javaCVClass, "getControllerKeyEvent", hand);
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog CVTriggerValue " + neotriggerV[7]);
		}
		return neotriggerV[7];
	}

	public void AutoConnectHbController(int scanTimeMs)
	{
		PLOG.I("PvrLog AutoConnectHbController" + scanTimeMs);
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "autoConnectHbController", scanTimeMs, gameobjname);
	}

	public void StartControllerThread(int headSensorState, int handSensorState)
	{
		if (BoundarySystem.UPvr_IsBoundaryEnable())
		{
			headSensorState = 1;
			handSensorState = 1;
		}
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "startControllerThread", headSensorState, handSensorState);
		UnityEngine.Debug.Log("PvrLog StartControllerThread" + headSensorState + handSensorState);
	}

	public void StopControllerThread(int headSensorState, int handSensorState)
	{
		if (BoundarySystem.UPvr_IsBoundaryEnable())
		{
			headSensorState = 1;
			handSensorState = 1;
		}
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "stopControllerThread", headSensorState, handSensorState);
		UnityEngine.Debug.Log("PvrLog StopControllerThread" + headSensorState + handSensorState);
	}

	public void SetUnityVersionToJar(string version)
	{
		if (trackingmode == 4 || trackingmode == 5 || trackingmode == 6)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setUnityVersion", version);
		}
		UnityEngine.Debug.Log("PvrLog SetUnityVersionToJar" + version);
	}

	public Vector3 GetVelocity(int num)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref velocity, javaCVClass, "getControllerLinearVelocity", num);
		}
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog Velocity" + velocity[0] + "," + velocity[1] + "," + velocity[2]);
		}
		return new Vector3(velocity[0], velocity[1], 0f - velocity[2]);
	}

	public Vector3 GetAngularVelocity(int num)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref angularVelocity, javaCVClass, "getControllerAngularVelocity", num);
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref angularVelocity, javaHummingbirdClass, "getHbAngularVelocity");
		}
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog Gyro:" + angularVelocity[0] + "," + angularVelocity[1] + "," + angularVelocity[2]);
		}
		return new Vector3(0f, 0f, 0f);
	}

	public Vector3 GetAcceleration(int num)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref acceData, javaCVClass, "getControllerAcceleration", num);
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref acceData, javaHummingbirdClass, "getHbAcceleration");
		}
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog Acce:" + acceData[0] + acceData[1] + acceData[2]);
		}
		return new Vector3(0f, 0f, 0f);
	}

	public string GetConnectedDeviceMac()
	{
		string result = "";
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getConnectedDeviceMac");
		}
		PLOG.I("PvrLog ConnectedDeviceMac:" + result);
		return result;
	}

	public void VibrateNeo2Controller(float strength, int time, int hand)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "vibrateCV2ControllerStrength", strength, time, hand);
		}
		PLOG.I("PvrLog VibrateNeo2Controller:" + strength + time + hand);
	}

	public int GetMainControllerIndex()
	{
		int result = 0;
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getMainControllerIndex");
		}
		PLOG.I("PvrLog GetMainControllerIndex:" + result);
		return result;
	}

	public void SetMainController(int index)
	{
		PLOG.I("PvrLog SetMainController:" + index);
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setMainController", index);
		}
	}

	public void ResetHeadSensorForController()
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "resetHeadSensorForController");
		}
		PLOG.I("PvrLog ResetHeadSensorForController:");
	}

	public void GetDeviceVersion(int deviceType)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "getDeviceVersion", deviceType);
		}
		PLOG.I("PvrLog GetDeviceVersion:" + deviceType);
	}

	public void GetControllerSnCode(int controllerSerialNum)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "getControllerSnCode", controllerSerialNum);
		}
		PLOG.I("PvrLog GetControllerSnCode:" + controllerSerialNum);
	}

	public void SetControllerUnbind(int controllerSerialNum)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setControllerUnbind", controllerSerialNum);
		}
		PLOG.I("PvrLog SetControllerUnbind:" + controllerSerialNum);
	}

	public void SetStationRestart()
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setStationRestart");
		}
		PLOG.I("PvrLog SetStationRestart");
	}

	public void StartStationOtaUpdate()
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "startStationOtaUpdate");
		}
		PLOG.I("PvrLog StartStationOtaUpdate");
	}

	public void StartControllerOtaUpdate(int mode, int controllerSerialNum)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "startControllerOtaUpdate", mode, controllerSerialNum);
		}
		PLOG.I("PvrLog StartControllerOtaUpdate" + mode + controllerSerialNum);
	}

	public void EnterPairMode(int controllerSerialNum)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "enterPairMode", controllerSerialNum);
		}
		PLOG.I("PvrLog EnterPairMode" + controllerSerialNum);
	}

	public void SetControllerShutdown(int controllerSerialNum)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setControllerShutdown", controllerSerialNum);
		}
		PLOG.I("PvrLog SetControllerShutdown" + controllerSerialNum);
	}

	public int GetStationPairState()
	{
		int result = -1;
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getStationPairState");
		}
		PLOG.I("PvrLog StationPairState" + result);
		return result;
	}

	public int GetStationOtaUpdateProgress()
	{
		int result = -1;
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getStationOtaUpdateProgress");
		}
		PLOG.I("PvrLog StationOtaUpdateProgress" + result);
		return result;
	}

	public int GetControllerOtaUpdateProgress()
	{
		int result = -1;
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getControllerOtaUpdateProgress");
		}
		PLOG.I("PvrLog ControllerOtaUpdateProgress" + result);
		return result;
	}

	public void GetControllerVersionAndSN(int controllerSerialNum)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "getControllerVersionAndSN", controllerSerialNum);
		}
		PLOG.I("PvrLog GetControllerVersionAndSN" + controllerSerialNum);
	}

	public void GetControllerUniqueID()
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "getControllerUniqueID");
		}
		PLOG.I("PvrLog GetControllerUniqueID");
	}

	public void InterruptStationPairMode()
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "interruptStationPairMode");
		}
		PLOG.I("PvrLog InterruptStationPairMode");
	}

	public int GetControllerAbility(int controllerSerialNum)
	{
		int result = -1;
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getControllerAbility", controllerSerialNum);
		}
		PLOG.I("PvrLog ControllerAbility:" + result);
		return result;
	}

	public void SwitchHomeKey(bool state)
	{
		PLOG.I("PvrLog SwitchHomeKey:" + state);
		switchHomeKey = state;
	}

	public void SetBootReconnect()
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "setBootReconnect");
		PLOG.I("PvrLog SetBootReconnect");
	}

	public int GetTemperature()
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getTemperature");
		PLOG.I("PvrLog Temperature:" + result);
		return result;
	}

	public int GetDeviceType()
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getDeviceType");
		PLOG.I("PvrLog DeviceType:" + result);
		return result;
	}

	public int GetControllerType()
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getControllerType");
		return result;
	}

	public string GetHummingBird2SN()
	{
		string result = "";
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getHummingBird2SN");
		PLOG.I("PvrLog HummingBird2SN:" + result);
		return result;
	}

	public string GetControllerVersion()
	{
		string result = "";
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getControllerVersion");
		PLOG.I("PvrLog ControllerVersion:" + result);
		return result;
	}

	public bool IsEnbleTrigger()
	{
		bool result = false;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "isEnbleTrigger");
		PLOG.I("PvrLog IsEnbleTrigger:" + result);
		return result;
	}

	public void StartCV2PairingMode(int devicetype)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "startCV2PairingMode", devicetype);
		}
		PLOG.I("PvrLog StartCV2PairingMode:" + devicetype);
	}

	public void StopCV2PairingMode(int devicetype)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "stopCV2PairingMode", devicetype);
		}
		PLOG.I("PvrLog StopCV2PairingMode:" + devicetype);
	}

	public int GetControllerBindingState(int id)
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getControllerBindingState", id);
		PLOG.I("PvrLog getControllerBindingState:" + result);
		return result;
	}

	public void setIsEnbleHomeKey(bool state)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setIsEnbleHomeKey", state);
		}
		PLOG.I("PvrLog setIsEnbleHomeKey:" + state);
	}

	public int getControllerSensorStatus(int id)
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getControllerSensorStatus", id);
		PLOG.I("PvrLog getControllerSensorStatus:" + result);
		return result;
	}
}
public class Pvr_ControllerManager : MonoBehaviour
{
	public delegate void PvrServiceStartSuccess();

	public delegate void PvrControllerStateChanged(string data);

	public delegate void ChangeMainControllerCallBack(string index);

	public delegate void ChangeHandNessCallBack(string index);

	public delegate void SetHbServiceBindState();

	public delegate void ControllerThreadStartedCallback();

	public delegate void SetControllerServiceBindState();

	public delegate void ControllerStatusChange(string isconnect);

	public delegate void SetControllerAbility(string data);

	public delegate void SetControllerStateChanged(string data);

	public delegate void SetHbControllerMac(string mac);

	public delegate void ControllerDeviceVersionCallback(string data);

	public delegate void ControllerSnCodeCallback(string data);

	public delegate void ControllerUnbindCallback(string status);

	public delegate void ControllerStationStatusCallback(string status);

	public delegate void ControllerStationBusyCallback(string status);

	public delegate void ControllerOtaStartCodeCallback(string data);

	public delegate void ControllerDeviceVersionAndSNCallback(string data);

	public delegate void ControllerUniqueIDCallback(string data);

	public delegate void ControllerCombinedKeyUnbindCallback(string data);

	private static Pvr_ControllerManager instance;

	public static Pvr_ControllerLink controllerlink;

	private float cTime = 1f;

	private bool stopConnect;

	public Text toast;

	private bool controllerServicestate;

	private float disConnectTime;

	public bool LengthAdaptiveRay;

	private float[] sensorData = new float[28];

	private int[] keyData = new int[134];

	private float[] g2SensorData = new float[4];

	private int[] g2KeyData = new int[47];

	private int keyOffset;

	private int rotControllerMode = 1;

	public static Pvr_ControllerManager Instance
	{
		get
		{
			if (instance == null)
			{
				instance = UnityEngine.Object.FindObjectOfType<Pvr_ControllerManager>();
			}
			if (instance == null)
			{
				GameObject obj = new GameObject("GameObject");
				instance = obj.AddComponent<Pvr_ControllerManager>();
				obj.transform.localPosition = Vector3.zero;
			}
			return instance;
		}
	}

	public static event PvrServiceStartSuccess PvrServiceStartSuccessEvent;

	public static event PvrControllerStateChanged PvrControllerStateChangedEvent;

	public static event ChangeMainControllerCallBack ChangeMainControllerCallBackEvent;

	public static event ChangeHandNessCallBack ChangeHandNessCallBackEvent;

	public static event SetHbServiceBindState SetHbServiceBindStateEvent;

	public static event ControllerThreadStartedCallback ControllerThreadStartedCallbackEvent;

	public static event SetControllerServiceBindState SetControllerServiceBindStateEvent;

	public static event ControllerStatusChange ControllerStatusChangeEvent;

	public static event SetControllerAbility SetControllerAbilityEvent;

	public static event SetControllerStateChanged SetControllerStateChangedEvent;

	public static event SetHbControllerMac SetHbControllerMacEvent;

	public static event ControllerDeviceVersionCallback ControllerDeviceVersionCallbackEvent;

	public static event ControllerSnCodeCallback ControllerSnCodeCallbackEvent;

	public static event ControllerUnbindCallback ControllerUnbindCallbackEvent;

	public static event ControllerStationStatusCallback ControllerStationStatusCallbackEvent;

	public static event ControllerStationBusyCallback ControllerStationBusyCallbackEvent;

	public static event ControllerOtaStartCodeCallback ControllerOtaStartCodeCallbackEvent;

	public static event ControllerDeviceVersionAndSNCallback ControllerDeviceVersionAndSNCallbackEvent;

	public static event ControllerUniqueIDCallback ControllerUniqueIDCallbackEvent;

	public static event ControllerCombinedKeyUnbindCallback ControllerCombinedKeyUnbindCallbackEvent;

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		if (instance != this)
		{
			PLOG.E("instance object should be a singleton.");
			return;
		}
		if (controllerlink == null)
		{
			controllerlink = new Pvr_ControllerLink(base.gameObject.name);
			return;
		}
		controllerlink.SetGameObjectToJar(base.gameObject.name);
		BindService();
	}

	private void Start()
	{
		if (controllerlink.trackingmode < 2)
		{
			Invoke("CheckControllerService", 10f);
		}
		Render.UPvr_GetIntConfig(23, ref rotControllerMode);
	}

	private void Update()
	{
		if (controllerlink.neoserviceStarted)
		{
			sensorData = controllerlink.GetControllerSensorData();
			keyData = controllerlink.GetControllerKeyData();
			if (controllerlink.controller0Connected)
			{
				if (Pvr_UnitySDKManager.SDK.ShowVideoSeethrough)
				{
					sensorData[2] = 0f - sensorData[2];
					sensorData[3] = 0f - sensorData[3];
					controllerlink.Controller0.Rotation.Set(sensorData[0], sensorData[1], sensorData[2], sensorData[3]);
					if (rotControllerMode == 0)
					{
						controllerlink.Controller0.Rotation *= Quaternion.Euler(34f, 0f, 0f);
					}
					controllerlink.Controller0.Position.Set(sensorData[4] / 1000f, sensorData[5] / 1000f, (0f - sensorData[6]) / 1000f);
				}
				else
				{
					controllerlink.Controller0.Rotation.Set(sensorData[7], sensorData[8], sensorData[9], sensorData[10]);
					if (rotControllerMode == 0)
					{
						controllerlink.Controller0.Rotation *= Quaternion.Euler(34f, 0f, 0f);
					}
					controllerlink.Controller0.Position.Set(sensorData[11] / 1000f, sensorData[12] / 1000f, (0f - sensorData[13]) / 1000f);
				}
				if (!controllerlink.Controller0.isShowBoundary)
				{
					if (controllerlink.getControllerSensorStatus(0) == 0)
					{
						Sensor.UPvr_SetReinPosition(sensorData[0], sensorData[1], sensorData[2], sensorData[3], sensorData[4], sensorData[5], sensorData[6], 0, valid: false, 0);
					}
					else
					{
						controllerlink.Controller0.isShowBoundary = true;
						Sensor.UPvr_SetReinPosition(sensorData[0], sensorData[1], sensorData[2], sensorData[3], sensorData[4], sensorData[5], sensorData[6], 0, valid: true, Convert.ToInt32(Convert.ToString(keyData[35]) + Convert.ToString(keyData[15]) + "00", 2));
					}
				}
				else
				{
					Sensor.UPvr_SetReinPosition(sensorData[0], sensorData[1], sensorData[2], sensorData[3], sensorData[4], sensorData[5], sensorData[6], 0, valid: true, Convert.ToInt32(Convert.ToString(keyData[35]) + Convert.ToString(keyData[15]) + "00", 2));
				}
				TransformData(controllerlink.Controller0, 0, keyData);
			}
			else
			{
				Sensor.UPvr_SetReinPosition(sensorData[0], sensorData[1], sensorData[2], sensorData[3], sensorData[4], sensorData[5], sensorData[6], 0, valid: false, 0);
			}
			if (controllerlink.controller1Connected)
			{
				if (Pvr_UnitySDKManager.SDK.ShowVideoSeethrough)
				{
					sensorData[16] = 0f - sensorData[16];
					sensorData[17] = 0f - sensorData[17];
					controllerlink.Controller1.Rotation.Set(sensorData[14], sensorData[15], sensorData[16], sensorData[17]);
					if (rotControllerMode == 0)
					{
						controllerlink.Controller1.Rotation *= Quaternion.Euler(34f, 0f, 0f);
					}
					controllerlink.Controller1.Position.Set(sensorData[18] / 1000f, sensorData[19] / 1000f, (0f - sensorData[20]) / 1000f);
				}
				else
				{
					controllerlink.Controller1.Rotation.Set(sensorData[21], sensorData[22], sensorData[23], sensorData[24]);
					if (rotControllerMode == 0)
					{
						controllerlink.Controller1.Rotation *= Quaternion.Euler(34f, 0f, 0f);
					}
					controllerlink.Controller1.Position.Set(sensorData[25] / 1000f, sensorData[26] / 1000f, (0f - sensorData[27]) / 1000f);
				}
				if (!controllerlink.Controller1.isShowBoundary)
				{
					if (controllerlink.getControllerSensorStatus(1) == 0)
					{
						Sensor.UPvr_SetReinPosition(sensorData[14], sensorData[15], sensorData[16], sensorData[17], sensorData[18], sensorData[19], sensorData[20], 1, valid: false, 0);
					}
					else
					{
						controllerlink.Controller1.isShowBoundary = true;
						Sensor.UPvr_SetReinPosition(sensorData[14], sensorData[15], sensorData[16], sensorData[17], sensorData[18], sensorData[19], sensorData[20], 1, valid: true, Convert.ToInt32(Convert.ToString(keyData[102]) + Convert.ToString(keyData[82]) + "00", 2));
					}
				}
				else
				{
					Sensor.UPvr_SetReinPosition(sensorData[14], sensorData[15], sensorData[16], sensorData[17], sensorData[18], sensorData[19], sensorData[20], 1, valid: true, Convert.ToInt32(Convert.ToString(keyData[102]) + Convert.ToString(keyData[82]) + "00", 2));
				}
				TransformData(controllerlink.Controller1, 1, keyData);
			}
			else
			{
				Sensor.UPvr_SetReinPosition(sensorData[14], sensorData[15], sensorData[16], sensorData[17], sensorData[18], sensorData[19], sensorData[20], 1, valid: false, 0);
			}
		}
		if (controllerlink.goblinserviceStarted && controllerlink.controller0Connected)
		{
			g2SensorData = controllerlink.GetHBControllerPoseData();
			controllerlink.Controller0.Rotation.Set(g2SensorData[0], g2SensorData[1], g2SensorData[2], g2SensorData[3]);
			g2KeyData = controllerlink.GetHBControllerKeyData();
			TransformData(controllerlink.Controller0, 0, g2KeyData);
		}
		SetSystemKey();
	}

	private void OnApplicationPause(bool pause)
	{
		int headSensorState = ((!Pvr_UnitySDKManager.SDK.HmdOnlyrot) ? 1 : 0);
		int handSensorState = ((!Pvr_UnitySDKManager.SDK.ControllerOnlyrot) ? 1 : 0);
		if (pause)
		{
			if (controllerlink.neoserviceStarted)
			{
				controllerlink.SetGameObjectToJar("");
				controllerlink.StopControllerThread(headSensorState, handSensorState);
			}
			if (controllerlink.goblinserviceStarted)
			{
				controllerlink.StopLark2Receiver();
			}
			return;
		}
		controllerlink.Controller0 = new ControllerHand();
		controllerlink.Controller1 = new ControllerHand();
		if (controllerlink.neoserviceStarted)
		{
			controllerlink.SetGameObjectToJar(base.gameObject.name);
			controllerlink.SetUnityVersionToJar("2.8.9.12");
			controllerlink.StartControllerThread(headSensorState, handSensorState);
		}
		if (controllerlink.goblinserviceStarted)
		{
			controllerlink.StartLark2Receiver();
			controllerlink.controller0Connected = GetControllerConnectionState(0) == 1;
			controllerlink.controllerType = controllerlink.GetControllerType();
			controllerlink.handness = (Pvr_Controller.UserHandNess)controllerlink.getHandness();
			if (Pvr_ControllerManager.PvrServiceStartSuccessEvent != null)
			{
				Pvr_ControllerManager.PvrServiceStartSuccessEvent();
			}
		}
	}

	private void OnDestroy()
	{
		controllerlink.UnBindService();
		Sensor.UPvr_SetReinPosition(0f, 0f, 0f, 1f, 0f, 0f, 0f, 0, valid: false, 0);
		Sensor.UPvr_SetReinPosition(0f, 0f, 0f, 1f, 0f, 0f, 0f, 1, valid: false, 0);
	}

	private void OnApplicationQuit()
	{
		int headSensorState = ((!Pvr_UnitySDKManager.SDK.HmdOnlyrot) ? 1 : 0);
		int handSensorState = ((!Pvr_UnitySDKManager.SDK.ControllerOnlyrot) ? 1 : 0);
		if (controllerlink.neoserviceStarted)
		{
			controllerlink.SetGameObjectToJar("");
			controllerlink.StopControllerThread(headSensorState, handSensorState);
		}
	}

	public void StopLark2Service()
	{
		if (controllerlink != null)
		{
			controllerlink.StopLark2Service();
		}
	}

	public Vector3 GetAngularVelocity(int num)
	{
		if (controllerlink != null)
		{
			return controllerlink.GetAngularVelocity(num);
		}
		return new Vector3(0f, 0f, 0f);
	}

	public Vector3 GetAcceleration(int num)
	{
		if (controllerlink != null)
		{
			return controllerlink.GetAcceleration(num);
		}
		return new Vector3(0f, 0f, 0f);
	}

	public void BindService()
	{
		if (controllerlink != null)
		{
			controllerlink.BindService();
		}
	}

	public void StartScan()
	{
		if (controllerlink != null)
		{
			controllerlink.StartScan();
		}
	}

	public void StopScan()
	{
		if (controllerlink != null)
		{
			controllerlink.StopScan();
		}
	}

	public void ResetController(int num)
	{
		if (controllerlink != null)
		{
			controllerlink.ResetController(num);
		}
	}

	public static int GetControllerConnectionState(int num)
	{
		return controllerlink.GetControllerConnectionState(num);
	}

	public void ConnectBLE()
	{
		if (controllerlink != null)
		{
			controllerlink.ConnectBLE();
		}
	}

	public void DisConnectBLE()
	{
		if (controllerlink != null)
		{
			controllerlink.DisConnectBLE();
		}
	}

	public void SetBinPath(string path, bool isAsset)
	{
		if (controllerlink != null)
		{
			controllerlink.setBinPath(path, isAsset);
		}
	}

	public void StartUpgrade()
	{
		if (controllerlink != null)
		{
			controllerlink.StartUpgrade();
		}
	}

	public static string GetBLEImageType()
	{
		return controllerlink.GetBLEImageType();
	}

	public static long GetBLEVersion()
	{
		return controllerlink.GetBLEVersion();
	}

	public static string GetFileImageType()
	{
		return controllerlink.GetFileImageType();
	}

	public static long GetFileVersion()
	{
		return controllerlink.GetFileVersion();
	}

	public static void AutoConnectHbController(int scans)
	{
		if (controllerlink != null)
		{
			controllerlink.AutoConnectHbController(scans);
		}
	}

	public static string GetConnectedDeviceMac()
	{
		string result = "";
		if (controllerlink != null)
		{
			result = controllerlink.GetConnectedDeviceMac();
		}
		return result;
	}

	public void setHbControllerMac(string mac)
	{
		PLOG.I("PvrLog HBMacRSSI" + mac);
		controllerlink.hummingBirdMac = mac.Substring(0, 17);
		controllerlink.hummingBirdRSSI = Convert.ToInt16(mac.Remove(0, 18));
		if (Pvr_ControllerManager.SetHbControllerMacEvent != null)
		{
			Pvr_ControllerManager.SetHbControllerMacEvent(mac.Substring(0, 17));
		}
	}

	public int GetControllerRSSI()
	{
		return controllerlink.hummingBirdRSSI;
	}

	public void setHbServiceBindState(string state)
	{
		PLOG.I("PvrLog HBBindCallBack" + state);
		controllerServicestate = true;
		if (Convert.ToInt16(state) == 0)
		{
			Invoke("BindService", 0.5f);
			controllerlink.goblinserviceStarted = false;
		}
		else if (Convert.ToInt16(state) == 1)
		{
			controllerlink.goblinserviceStarted = true;
			controllerlink.controller0Connected = GetControllerConnectionState(0) == 1;
			controllerlink.controllerType = controllerlink.GetControllerType();
			controllerlink.handness = (Pvr_Controller.UserHandNess)controllerlink.getHandness();
			if (Pvr_ControllerManager.SetHbServiceBindStateEvent != null)
			{
				Pvr_ControllerManager.SetHbServiceBindStateEvent();
			}
			if (Pvr_ControllerManager.PvrServiceStartSuccessEvent != null)
			{
				Pvr_ControllerManager.PvrServiceStartSuccessEvent();
			}
		}
	}

	public void setControllerServiceBindState(string state)
	{
		PLOG.I("PvrLog CVBindCallBack" + state);
		if (Convert.ToInt16(state) == 0)
		{
			Invoke("BindService", 0.5f);
			controllerlink.neoserviceStarted = false;
		}
		else if (Convert.ToInt16(state) == 1)
		{
			controllerlink.SetUnityVersionToJar("2.8.9.12");
			controllerlink.neoserviceStarted = true;
			int headSensorState = ((!Pvr_UnitySDKManager.SDK.HmdOnlyrot) ? 1 : 0);
			int handSensorState = ((!Pvr_UnitySDKManager.SDK.ControllerOnlyrot) ? 1 : 0);
			controllerlink.StartControllerThread(headSensorState, handSensorState);
			if (Pvr_ControllerManager.SetControllerServiceBindStateEvent != null)
			{
				Pvr_ControllerManager.SetControllerServiceBindStateEvent();
			}
		}
	}

	public void setHbControllerConnectState(string isconnect)
	{
		PLOG.I("PvrLog HBControllerConnect" + isconnect);
		controllerlink.controller0Connected = Convert.ToInt16(isconnect) == 1;
		if (!controllerlink.controller0Connected)
		{
			controllerlink.Controller0 = new ControllerHand();
		}
		else
		{
			ResetController(0);
			controllerlink.controllerType = controllerlink.GetControllerType();
			controllerlink.handness = (Pvr_Controller.UserHandNess)controllerlink.getHandness();
		}
		stopConnect = false;
		if (Pvr_ControllerManager.ControllerStatusChangeEvent != null)
		{
			Pvr_ControllerManager.ControllerStatusChangeEvent(isconnect);
		}
		if (Pvr_ControllerManager.PvrControllerStateChangedEvent != null)
		{
			Pvr_ControllerManager.PvrControllerStateChangedEvent(isconnect);
		}
	}

	public void setControllerStateChanged(string state)
	{
		PLOG.I("PvrLog CVControllerStateChanged" + state);
		int num = Convert.ToInt16(state.Substring(0, 1));
		if (num == 0)
		{
			controllerlink.controller0Connected = Convert.ToBoolean(Convert.ToInt16(state.Substring(2, 1)));
			if (!controllerlink.controller0Connected)
			{
				controllerlink.Controller0 = new ControllerHand();
				controllerlink.Controller0.Position = new Vector3(0f, Pvr_UnitySDKSensor.Instance.HeadPose.Position.y, 0f) + new Vector3(-0.1f, -0.3f, 0.3f);
			}
		}
		else
		{
			controllerlink.controller1Connected = Convert.ToBoolean(Convert.ToInt16(state.Substring(2, 1)));
			if (!controllerlink.controller1Connected)
			{
				controllerlink.Controller1 = new ControllerHand();
				controllerlink.Controller1.Position = new Vector3(0f, Pvr_UnitySDKSensor.Instance.HeadPose.Position.y, 0f) + new Vector3(0.1f, -0.3f, 0.3f);
			}
		}
		if (Convert.ToBoolean(Convert.ToInt16(state.Substring(2, 1))))
		{
			controllerlink.controllerType = controllerlink.GetControllerType();
			controllerlink.ResetController(num);
		}
		controllerlink.handness = (Pvr_Controller.UserHandNess)controllerlink.getHandness();
		controllerlink.mainHandID = controllerlink.GetMainControllerIndex();
		if (Pvr_ControllerManager.SetControllerStateChangedEvent != null)
		{
			Pvr_ControllerManager.SetControllerStateChangedEvent(state);
		}
		if (Pvr_ControllerManager.PvrControllerStateChangedEvent != null)
		{
			Pvr_ControllerManager.PvrControllerStateChangedEvent(state);
		}
	}

	public void setControllerAbility(string data)
	{
		PLOG.I("PvrLog setControllerAbility" + data);
		if (Pvr_ControllerManager.SetControllerAbilityEvent != null)
		{
			Pvr_ControllerManager.SetControllerAbilityEvent(data);
		}
	}

	public void controllerThreadStartedCallback()
	{
		PLOG.I("PvrLog ThreadStartSuccess");
		GetCVControllerState();
		if (Pvr_ControllerManager.ControllerThreadStartedCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerThreadStartedCallbackEvent();
		}
		if (Pvr_ControllerManager.PvrServiceStartSuccessEvent != null)
		{
			Pvr_ControllerManager.PvrServiceStartSuccessEvent();
		}
	}

	public void controllerDeviceVersionCallback(string data)
	{
		PLOG.I("PvrLog VersionCallBack" + data);
		if (Pvr_ControllerManager.ControllerDeviceVersionCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerDeviceVersionCallbackEvent(data);
		}
	}

	public void controllerSnCodeCallback(string data)
	{
		PLOG.I("PvrLog SNCodeCallBack" + data);
		if (Pvr_ControllerManager.ControllerSnCodeCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerSnCodeCallbackEvent(data);
		}
	}

	public void controllerUnbindCallback(string status)
	{
		PLOG.I("PvrLog ControllerUnBindCallBack" + status);
		if (Pvr_ControllerManager.ControllerUnbindCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerUnbindCallbackEvent(status);
		}
	}

	public void controllerStationStatusCallback(string status)
	{
		PLOG.I("PvrLog StationStatusCallBack" + status);
		if (Pvr_ControllerManager.ControllerStationStatusCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerStationStatusCallbackEvent(status);
		}
	}

	public void controllerStationBusyCallback(string status)
	{
		PLOG.I("PvrLog StationBusyCallBack" + status);
		if (Pvr_ControllerManager.ControllerStationBusyCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerStationBusyCallbackEvent(status);
		}
	}

	public void controllerOTAStartCodeCallback(string data)
	{
		PLOG.I("PvrLog OTAUpdateCallBack" + data);
		if (Pvr_ControllerManager.ControllerOtaStartCodeCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerOtaStartCodeCallbackEvent(data);
		}
	}

	public void controllerDeviceVersionAndSNCallback(string data)
	{
		PLOG.I("PvrLog DeviceVersionAndSNCallback" + data);
		if (Pvr_ControllerManager.ControllerDeviceVersionAndSNCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerDeviceVersionAndSNCallbackEvent(data);
		}
	}

	public void controllerUniqueIDCallback(string data)
	{
		PLOG.I("PvrLog controllerUniqueIDCallback" + data);
		if (Pvr_ControllerManager.ControllerUniqueIDCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerUniqueIDCallbackEvent(data);
		}
	}

	public void controllerCombinedKeyUnbindCallback(string controllerSerialNum)
	{
		if (Pvr_ControllerManager.ControllerCombinedKeyUnbindCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerCombinedKeyUnbindCallbackEvent(controllerSerialNum);
		}
	}

	public void setupdateFailed()
	{
	}

	public void setupdateSuccess()
	{
	}

	public void setupdateProgress(string progress)
	{
	}

	public void setHbAutoConnectState(string state)
	{
		PLOG.I("PvrLog HBAutoConnectState" + state);
		controllerServicestate = true;
		if (Convert.ToInt16(state) == 0 && GetControllerConnectionState(0) == 0)
		{
			ShowToast(2);
		}
		if (Convert.ToInt16(state) == 2)
		{
			ShowToast(3);
		}
	}

	public void callbackControllerServiceState(string state)
	{
		PLOG.I("PvrLog HBServiceState" + state);
		controllerServicestate = true;
		if (Convert.ToInt16(state) == 0)
		{
			ShowToast(0);
		}
		if (Convert.ToInt16(state) == 1)
		{
			BindService();
		}
		if (Convert.ToInt16(state) == 2)
		{
			ShowToast(1);
		}
	}

	public void changeMainControllerCallback(string index)
	{
		PLOG.I("PvrLog MainControllerCallBack" + index);
		controllerlink.mainHandID = Convert.ToInt16(index);
		if (Pvr_ControllerManager.ChangeMainControllerCallBackEvent != null)
		{
			Pvr_ControllerManager.ChangeMainControllerCallBackEvent(index);
		}
	}

	public void changeHandnessCallback(string index)
	{
		PLOG.I("PvrLog changeHandnessCallback" + index);
		controllerlink.handness = (Pvr_Controller.UserHandNess)Convert.ToInt16(index);
		if (Pvr_ControllerManager.ChangeHandNessCallBackEvent != null)
		{
			Pvr_ControllerManager.ChangeHandNessCallBackEvent(index);
		}
	}

	private void ShowToast(int type)
	{
		if (toast != null)
		{
			switch (type)
			{
			case 0:
				toast.text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("servicetip0");
				Invoke("HideToast", 5f);
				break;
			case 1:
				toast.text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("servicetip1");
				Invoke("HideToast", 5f);
				break;
			case 2:
				toast.text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("servicetip2");
				AutoConnectHbController(6000);
				Invoke("HideToast", 5f);
				break;
			case 3:
				toast.text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("servicetip3");
				AutoConnectHbController(6000);
				Invoke("HideToast", 5f);
				break;
			case 4:
				toast.text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("servicetip4");
				Invoke("HideToast", 10f);
				break;
			}
		}
	}

	private void HideToast()
	{
		if (toast != null)
		{
			toast.text = "";
		}
	}

	private void CheckControllerService()
	{
		if (!controllerServicestate)
		{
			ShowToast(4);
		}
	}

	private void GetCVControllerState()
	{
		int controllerConnectionState = GetControllerConnectionState(0);
		int controllerConnectionState2 = GetControllerConnectionState(1);
		PLOG.I("PvrLog CVconnect" + controllerConnectionState + controllerConnectionState2);
		if (controllerConnectionState == -1 && controllerConnectionState2 == -1)
		{
			Invoke("GetCVControllerState", 0.02f);
		}
		if (controllerConnectionState != -1 && controllerConnectionState2 != -1)
		{
			controllerlink.controller0Connected = controllerConnectionState == 1;
			controllerlink.controller1Connected = controllerConnectionState2 == 1;
			if (!controllerlink.controller0Connected && controllerlink.controller1Connected && controllerlink.GetMainControllerIndex() == 0)
			{
				Controller.UPvr_SetMainHandNess(1);
			}
			if (controllerlink.controller0Connected || controllerlink.controller1Connected)
			{
				controllerlink.controllerType = controllerlink.GetControllerType();
			}
			controllerlink.mainHandID = controllerlink.GetMainControllerIndex();
			controllerlink.handness = (Pvr_Controller.UserHandNess)controllerlink.getHandness();
		}
	}

	private void SetSystemKey()
	{
		if (controllerlink.switchHomeKey && (Controller.UPvr_GetKeyLongPressed(0, Pvr_KeyCode.HOME) || Controller.UPvr_GetKeyLongPressed(1, Pvr_KeyCode.HOME)))
		{
			if (Pvr_UnitySDKManager.SDK.HmdOnlyrot)
			{
				Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 0);
			}
			else if (controllerlink.trackingmode == 0 || controllerlink.trackingmode == 1)
			{
				Pvr_UnitySDKSensor.Instance.ResetUnitySDKSensor();
			}
			else
			{
				Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
			}
			if (Pvr_UnitySDKManager.SDK.ControllerOnlyrot || (controllerlink.controller0Connected && Controller.UPvr_GetControllerPOS(0).Equals(Vector3.zero)) || (controllerlink.controller1Connected && Controller.UPvr_GetControllerPOS(1).Equals(Vector3.zero)))
			{
				if (Controller.UPvr_GetKeyLongPressed(0, Pvr_KeyCode.HOME))
				{
					ResetController(0);
				}
				if (Controller.UPvr_GetKeyLongPressed(1, Pvr_KeyCode.HOME))
				{
					ResetController(1);
				}
			}
		}
		if (controllerlink.picoDevice)
		{
			if (controllerlink.switchHomeKey && (Controller.UPvr_GetKeyClick(0, Pvr_KeyCode.HOME) || (Controller.UPvr_GetKeyClick(1, Pvr_KeyCode.HOME) && !stopConnect)))
			{
				controllerlink.RebackToLauncher();
			}
			if (Controller.UPvr_GetKeyClick(0, Pvr_KeyCode.VOLUMEUP) || Controller.UPvr_GetKeyClick(1, Pvr_KeyCode.VOLUMEUP))
			{
				controllerlink.TurnUpVolume();
			}
			if (Controller.UPvr_GetKeyClick(0, Pvr_KeyCode.VOLUMEDOWN) || Controller.UPvr_GetKeyClick(1, Pvr_KeyCode.VOLUMEDOWN))
			{
				controllerlink.TurnDownVolume();
			}
			if (!Controller.UPvr_GetKey(0, Pvr_KeyCode.VOLUMEUP) && !Controller.UPvr_GetKey(0, Pvr_KeyCode.VOLUMEDOWN) && !Controller.UPvr_GetKey(1, Pvr_KeyCode.VOLUMEUP) && !Controller.UPvr_GetKey(1, Pvr_KeyCode.VOLUMEDOWN))
			{
				cTime = 1f;
			}
			if (Controller.UPvr_GetKey(0, Pvr_KeyCode.VOLUMEUP) || Controller.UPvr_GetKey(1, Pvr_KeyCode.VOLUMEUP))
			{
				cTime -= Time.deltaTime;
				if (cTime <= 0f)
				{
					cTime = 0.2f;
					controllerlink.TurnUpVolume();
				}
			}
			if (!Controller.UPvr_GetKey(0, Pvr_KeyCode.HOME) && !Controller.UPvr_GetKey(1, Pvr_KeyCode.HOME) && (Controller.UPvr_GetKey(0, Pvr_KeyCode.VOLUMEDOWN) || Controller.UPvr_GetKey(1, Pvr_KeyCode.VOLUMEDOWN)))
			{
				cTime -= Time.deltaTime;
				if (cTime <= 0f)
				{
					cTime = 0.2f;
					controllerlink.TurnDownVolume();
				}
			}
		}
		if (controllerlink.goblinserviceStarted && Controller.UPvr_GetKey(0, Pvr_KeyCode.HOME) && Controller.UPvr_GetKey(0, Pvr_KeyCode.VOLUMEDOWN) && !stopConnect)
		{
			disConnectTime += Time.deltaTime;
			if ((double)disConnectTime > 1.0)
			{
				DisConnectBLE();
				controllerlink.hummingBirdMac = "";
				stopConnect = true;
				disConnectTime = 0f;
			}
		}
	}

	private void TransformData(ControllerHand hand, int handId, int[] data)
	{
		keyOffset = ((handId == 1) ? 67 : 0);
		hand.TouchPadPosition.x = data[keyOffset];
		hand.TouchPadPosition.y = data[5 + keyOffset];
		TransSingleKey(hand.Home, 10 + keyOffset, data);
		TransSingleKey(hand.App, 15 + keyOffset, data);
		TransSingleKey(hand.Touch, 20 + keyOffset, data);
		TransSingleKey(hand.VolumeUp, 25 + keyOffset, data);
		TransSingleKey(hand.VolumeDown, 30 + keyOffset, data);
		TransSingleKey(hand.Trigger, 35 + keyOffset, data);
		if (controllerlink.goblinserviceStarted && !controllerlink.neoserviceStarted)
		{
			hand.TriggerNum = controllerlink.GetHBKeyValue();
		}
		if (!controllerlink.goblinserviceStarted && controllerlink.neoserviceStarted)
		{
			hand.TriggerNum = controllerlink.GetCVTriggerValue(handId);
		}
		hand.Battery = data[40 + keyOffset];
		if (data.Length == 47)
		{
			hand.SwipeDirection = (SwipeDirection)data[45];
			hand.TouchPadClick = (TouchPadClick)data[46];
		}
		else
		{
			switch (handId)
			{
			case 0:
				TransSingleKey(hand.X, 45 + keyOffset, data);
				TransSingleKey(hand.Y, 50 + keyOffset, data);
				TransSingleKey(hand.Left, 60 + keyOffset, data);
				break;
			case 1:
				TransSingleKey(hand.A, 45 + keyOffset, data);
				TransSingleKey(hand.B, 50 + keyOffset, data);
				TransSingleKey(hand.Right, 55 + keyOffset, data);
				break;
			}
			hand.SwipeDirection = (SwipeDirection)data[65 + keyOffset];
			hand.TouchPadClick = (TouchPadClick)data[66 + keyOffset];
		}
		hand.GripValue = controllerlink.GetNeo3GripValue(handId);
		TransformTouchData(hand, handId, controllerlink.GetNeo3TouchData(handId));
	}

	private void TransSingleKey(PvrControllerKey key, int beginIndex, int[] data)
	{
		key.State = Convert.ToBoolean(data[beginIndex]);
		key.PressedDown = Convert.ToBoolean(data[beginIndex + 1]);
		key.PressedUp = Convert.ToBoolean(data[beginIndex + 2]);
		key.LongPressed = Convert.ToBoolean(data[beginIndex + 3]);
		key.Click = Convert.ToBoolean(data[beginIndex + 4]);
	}

	private void TransformTouchData(ControllerHand hand, int handId, int[] data)
	{
		switch (handId)
		{
		case 0:
			TransSingleTouchValue(hand.X, 0, data);
			TransSingleTouchValue(hand.Y, 3, data);
			break;
		case 1:
			TransSingleTouchValue(hand.A, 0, data);
			TransSingleTouchValue(hand.B, 3, data);
			break;
		}
		TransSingleTouchValue(hand.Touch, 6, data);
		TransSingleTouchValue(hand.Trigger, 9, data);
		TransSingleTouchValue(hand.Thumbrest, 12, data);
	}

	private void TransSingleTouchValue(PvrControllerKey key, int beginIndex, int[] data)
	{
		key.Touch = Convert.ToBoolean(data[beginIndex]);
		key.TouchDown = Convert.ToBoolean(data[beginIndex + 1]);
		key.TouchUp = Convert.ToBoolean(data[beginIndex + 2]);
	}
}
public class Pvr_ControllerModuleInit : MonoBehaviour
{
	public ControllerVariety Variety;

	public bool IsCustomModel;

	[SerializeField]
	private GameObject dot;

	[SerializeField]
	private GameObject rayLine;

	[SerializeField]
	private GameObject controller;

	private bool moduleState = true;

	private void Awake()
	{
		Pvr_ControllerManager.PvrServiceStartSuccessEvent += ServiceStartSuccess;
		Pvr_ControllerManager.PvrControllerStateChangedEvent += ControllerStateChanged;
		Pvr_ControllerManager.ChangeMainControllerCallBackEvent += MainControllerIDChanged;
		if (Pvr_ControllerManager.Instance.LengthAdaptiveRay)
		{
			rayLine = base.transform.GetComponentInChildren<LineRenderer>(includeInactive: true).gameObject;
			rayLine.GetComponent<LineRenderer>().startWidth = 0.003f;
			rayLine.GetComponent<LineRenderer>().endWidth = 0.0015f;
		}
	}

	private void OnDestroy()
	{
		Pvr_ControllerManager.PvrServiceStartSuccessEvent -= ServiceStartSuccess;
		Pvr_ControllerManager.PvrControllerStateChangedEvent -= ControllerStateChanged;
		Pvr_ControllerManager.ChangeMainControllerCallBackEvent -= MainControllerIDChanged;
	}

	private void ServiceStartSuccess()
	{
		RefreshRay();
	}

	private void ControllerStateChanged(string data)
	{
		if (Pvr_ControllerManager.controllerlink.controller0Connected || Pvr_ControllerManager.controllerlink.controller1Connected)
		{
			moduleState = true;
			controller.transform.localScale = Vector3.one;
		}
		RefreshRay();
	}

	private void MainControllerIDChanged(string data)
	{
		RefreshRay();
	}

	private void RefreshRay()
	{
		if (Variety == ControllerVariety.Controller0)
		{
			StartCoroutine(ShowOrHideRay(0));
		}
		if (Variety == ControllerVariety.Controller1)
		{
			StartCoroutine(ShowOrHideRay(1));
		}
	}

	private IEnumerator ShowOrHideRay(int id)
	{
		yield return null;
		yield return null;
		if (moduleState)
		{
			bool active = Controller.UPvr_GetMainHandNess() == id && Controller.UPvr_GetControllerState(id) == ControllerState.Connected;
			dot.SetActive(active);
			rayLine.SetActive(active);
		}
	}

	public void ForceHideOrShow(bool state)
	{
		dot.SetActive(state);
		rayLine.SetActive(state);
		controller.transform.localScale = (state ? Vector3.one : Vector3.zero);
		moduleState = state;
	}

	public void UpdateRay()
	{
		if (!Pvr_ControllerManager.Instance.LengthAdaptiveRay)
		{
			return;
		}
		bool flag = false;
		flag = ((Pvr_ControllerManager.controllerlink.controller0Connected || Pvr_ControllerManager.controllerlink.controller1Connected) ? true : false);
		if (flag && rayLine != null && rayLine.gameObject.activeSelf)
		{
			if (Controller.UPvr_GetDeviceType() == 1)
			{
				rayLine.GetComponent<LineRenderer>().SetPosition(0, base.transform.TransformPoint(0f, 0f, 0.058f));
			}
			else
			{
				rayLine.GetComponent<LineRenderer>().SetPosition(0, base.transform.TransformPoint(0f, 0.009f, 0.055f));
			}
			rayLine.GetComponent<LineRenderer>().SetPosition(1, dot.transform.position);
		}
	}
}
public class Pvr_ControllerPower : MonoBehaviour
{
	[SerializeField]
	private Sprite power1;

	[SerializeField]
	private Sprite power2;

	[SerializeField]
	private Sprite power3;

	[SerializeField]
	private Sprite power4;

	[SerializeField]
	private Sprite power5;

	[HideInInspector]
	public ControllerVariety variety;

	[HideInInspector]
	public ControllerDevice currentDevice;

	private Image powerImage;

	private int powerValue;

	private float power;

	private void Start()
	{
		powerImage = base.transform.GetComponent<Image>();
		powerValue = -1;
		variety = base.transform.GetComponentInParent<Pvr_ControllerModuleInit>().Variety;
		currentDevice = base.transform.GetComponentInParent<Pvr_ControllerVisual>().currentDevice;
	}

	private void Update()
	{
		RefreshPower((variety != 0) ? 1 : 0);
	}

	private void RefreshPower(int hand)
	{
		if (powerValue != Controller.UPvr_GetControllerPower(hand))
		{
			switch (Controller.UPvr_GetControllerPower(hand))
			{
			case 1:
				powerImage.sprite = power1;
				powerImage.color = Color.red;
				break;
			case 2:
				powerImage.sprite = power2;
				powerImage.color = Color.white;
				break;
			case 3:
				powerImage.sprite = power3;
				powerImage.color = Color.white;
				break;
			case 4:
				powerImage.sprite = power4;
				powerImage.color = Color.white;
				break;
			case 5:
				powerImage.sprite = power5;
				powerImage.color = Color.white;
				break;
			default:
				powerImage.sprite = power1;
				powerImage.color = Color.white;
				break;
			}
			powerValue = Controller.UPvr_GetControllerPower(hand);
		}
	}
}
public class Pvr_ControllerVisual : MonoBehaviour
{
	public ControllerDevice currentDevice;

	public Texture2D m_idle;

	public Texture2D m_app;

	public Texture2D m_home;

	public Texture2D m_touchpad;

	public Texture2D m_volUp;

	public Texture2D m_volDn;

	public Texture2D m_trigger;

	public Texture2D m_a;

	public Texture2D m_b;

	public Texture2D m_x;

	public Texture2D m_y;

	public Texture2D m_grip;

	private Renderer controllerRenderMat;

	[HideInInspector]
	public ControllerVariety variety;

	private void Awake()
	{
		controllerRenderMat = GetComponent<Renderer>();
	}

	private void Start()
	{
		variety = base.transform.GetComponentInParent<Pvr_ControllerModuleInit>().Variety;
	}

	private void Update()
	{
		ChangeKeyEffects((variety != 0) ? 1 : 0);
	}

	private void ChangeKeyEffects(int hand)
	{
		if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.TOUCHPAD))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_touchpad);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.APP))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_app);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.HOME))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_home);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.VOLUMEUP))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_volUp);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.VOLUMEDOWN))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_volDn);
		}
		else if (Controller.UPvr_GetControllerTriggerValue(hand) > 0 || Controller.UPvr_GetKey(hand, Pvr_KeyCode.TRIGGER))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_trigger);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.X))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_x);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.Y))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_y);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.A))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_a);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.B))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_b);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.Left) || Controller.UPvr_GetKey(hand, Pvr_KeyCode.Right))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_grip);
		}
		else if (controllerRenderMat.material.GetTexture("_MainTex") != m_idle)
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_idle);
		}
	}
}
public class Pvr_ToolTips : MonoBehaviour
{
	public enum TipBtn
	{
		app,
		touchpad,
		home,
		volup,
		voldown,
		trigger,
		grip
	}

	private ControllerDevice currentDevice;

	private float tipsAlpha;

	public static Pvr_ToolTips tooltips;

	public void ChangeTipsText(TipBtn tip, string key)
	{
		switch (tip)
		{
		case TipBtn.app:
			base.transform.Find("apptip/btn/Text").GetComponent<Text>().text = key;
			break;
		case TipBtn.touchpad:
			base.transform.Find("touchtip/btn/Text").GetComponent<Text>().text = key;
			break;
		case TipBtn.home:
			base.transform.Find("hometip/btn/Text").GetComponent<Text>().text = key;
			break;
		case TipBtn.volup:
			base.transform.Find("volup/btn/Text").GetComponent<Text>().text = key;
			break;
		case TipBtn.voldown:
			base.transform.Find("voldown/btn/Text").GetComponent<Text>().text = key;
			break;
		case TipBtn.trigger:
			base.transform.Find("triggertip/btn/Text").GetComponent<Text>().text = key;
			break;
		case TipBtn.grip:
			base.transform.Find("grip/btn/Text").GetComponent<Text>().text = key;
			break;
		}
	}

	private void Awake()
	{
		tooltips = base.transform.GetComponent<Pvr_ToolTips>();
	}

	private void Update()
	{
		switch (currentDevice)
		{
		case ControllerDevice.Goblin:
		case ControllerDevice.G2:
			tipsAlpha = (330f - base.transform.parent.parent.parent.localRotation.eulerAngles.x) / 45f;
			if (base.transform.parent.parent.parent.localRotation.eulerAngles.x >= 270f && base.transform.parent.parent.parent.localRotation.eulerAngles.x <= 330f)
			{
				tipsAlpha = Mathf.Max(0f, tipsAlpha);
				tipsAlpha = ((tipsAlpha > 1f) ? 1f : tipsAlpha);
			}
			else
			{
				tipsAlpha = 0f;
			}
			GetComponent<CanvasGroup>().alpha = tipsAlpha;
			break;
		case ControllerDevice.Neo2:
		case ControllerDevice.Neo3:
			tipsAlpha = (330f - base.transform.parent.parent.parent.localRotation.eulerAngles.x) / 45f;
			if (base.transform.parent.parent.parent.localRotation.eulerAngles.x >= 270f && base.transform.parent.parent.parent.localRotation.eulerAngles.x <= 330f)
			{
				tipsAlpha = Mathf.Max(0f, tipsAlpha);
				tipsAlpha = ((tipsAlpha > 1f) ? 1f : tipsAlpha);
			}
			else
			{
				tipsAlpha = 0f;
			}
			GetComponent<CanvasGroup>().alpha = tipsAlpha;
			break;
		case ControllerDevice.Neo:
			break;
		}
	}

	private void LoadTextFromJson()
	{
		currentDevice = base.transform.GetComponentInParent<Pvr_ControllerVisual>().currentDevice;
		base.transform.Find("apptip/btn/Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("apptip");
		base.transform.Find("touchtip/btn/Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("touchtip");
		base.transform.Find("hometip/btn/Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("hometip");
		Transform transform = base.transform.Find("volup/btn/Text");
		if (transform != null)
		{
			transform.GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("voluptip");
		}
		Transform transform2 = base.transform.Find("voldown/btn/Text");
		if (transform2 != null)
		{
			transform2.GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("voldowntip");
		}
		Transform transform3 = base.transform.Find("triggertip/btn/Text");
		if (transform3 != null)
		{
			transform3.GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("triggertip");
		}
		Transform transform4 = base.transform.Find("grip/btn/Text");
		if (transform4 != null)
		{
			transform4.GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("griptip");
		}
	}

	public static void RefreshTips()
	{
		if (tooltips != null)
		{
			tooltips.LoadTextFromJson();
		}
	}
}
public class Pvr_TouchPadScroll : MonoBehaviour
{
	private ScrollRect scrollRect;

	private bool isHoving;

	private int mainHand;

	private SwipeDirection direction;

	private Vector2 currPos;

	private Vector2 tarPos;

	private float lerpSpeed = 10f;

	private Transform tranViewport;

	private float ignoreDis = 3f;

	private Vector2 lastTouchDownPos;

	private Vector2 lastTouchUpPos;

	private bool isTouching;

	private bool isClosed = true;

	private Vector2 vecOrigin = Vector2.zero;

	private Vector2 vecOriginNeo2 = new Vector2(128f, 128f);

	private void Awake()
	{
		scrollRect = base.gameObject.GetComponent<ScrollRect>();
		tranViewport = base.transform.Find("Viewport");
	}

	private void Update()
	{
		Process();
		UpdateTargetPos();
		UpdatePos();
	}

	private bool IsControllerConnect()
	{
		mainHand = Controller.UPvr_GetMainHandNess();
		if (mainHand == 0 && Pvr_ControllerManager.controllerlink.controller0Connected)
		{
			return true;
		}
		if (mainHand == 1 && Pvr_ControllerManager.controllerlink.controller1Connected)
		{
			return true;
		}
		return false;
	}

	private void UpdateTargetPos()
	{
		if (Controller.UPvr_GetKey(0, Pvr_KeyCode.TOUCHPAD) || Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.TOUCHPAD))
		{
			ResetParameter();
		}
		else if (isHoving)
		{
			if (Pvr_ControllerManager.controllerlink.GetControllerType() == 3)
			{
				ComputeTouchPos();
			}
			else
			{
				ComputeRockerPos();
			}
			if ((currPos - tarPos).sqrMagnitude <= 10f)
			{
				isClosed = true;
			}
		}
	}

	private void ComputeTouchPos()
	{
		mainHand = Controller.UPvr_GetMainHandNess();
		currPos = scrollRect.content.localPosition;
		Vector2 vector = vecOrigin;
		if (mainHand == 0 && Pvr_ControllerManager.controllerlink.controller0Connected)
		{
			vector = Controller.UPvr_GetTouchPadPosition(mainHand);
		}
		if (mainHand == 1 && Pvr_ControllerManager.controllerlink.controller1Connected)
		{
			vector = Controller.UPvr_GetTouchPadPosition(mainHand);
		}
		if ((vector - vecOrigin).sqrMagnitude >= 1f)
		{
			if (!isTouching)
			{
				lastTouchDownPos = vector;
				isTouching = true;
			}
			lastTouchUpPos.x = vector.x;
			if (Mathf.Abs(lastTouchUpPos.x - lastTouchDownPos.x) > ignoreDis)
			{
				Vector2 vector2 = new Vector2((lastTouchUpPos.x - lastTouchDownPos.x) * 10f, 0f);
				lastTouchDownPos.x = lastTouchUpPos.x;
				if (isClosed)
				{
					tarPos = currPos + vector2;
					isClosed = false;
				}
				else
				{
					tarPos += vector2;
				}
			}
		}
		else
		{
			lastTouchDownPos = vecOrigin;
			lastTouchUpPos = vecOrigin;
			isTouching = false;
			if ((double)scrollRect.horizontalScrollbar.value >= 0.999 || (double)scrollRect.horizontalScrollbar.value <= 0.0001)
			{
				isClosed = true;
			}
		}
	}

	private void ComputeRockerPos()
	{
		mainHand = Controller.UPvr_GetMainHandNess();
		currPos = scrollRect.content.localPosition;
		Vector2 vector = vecOriginNeo2;
		if (mainHand == 0 && Pvr_ControllerManager.controllerlink.controller0Connected)
		{
			vector = Controller.UPvr_GetTouchPadPosition(mainHand);
		}
		if (mainHand == 1 && Pvr_ControllerManager.controllerlink.controller1Connected)
		{
			vector = Controller.UPvr_GetTouchPadPosition(mainHand);
		}
		if (VerifyNeo2TouchValid(vector) && (vector - vecOriginNeo2).sqrMagnitude >= 1f)
		{
			if (!isTouching)
			{
				lastTouchDownPos = vector;
				isTouching = true;
			}
			lastTouchUpPos.x = vector.x;
			if (Mathf.Abs(lastTouchUpPos.x - lastTouchDownPos.x) > ignoreDis)
			{
				Vector2 vector2 = new Vector2((lastTouchUpPos.x - lastTouchDownPos.x) * 10f, 0f);
				lastTouchDownPos.x = lastTouchUpPos.x;
				if (isClosed)
				{
					tarPos = currPos + vector2;
					isClosed = false;
				}
				else
				{
					tarPos += vector2;
				}
			}
		}
		else
		{
			lastTouchDownPos = vecOriginNeo2;
			lastTouchUpPos = vecOriginNeo2;
			isTouching = false;
			if ((double)scrollRect.horizontalScrollbar.value >= 0.999 || (double)scrollRect.horizontalScrollbar.value <= 0.0001)
			{
				isClosed = true;
			}
		}
	}

	private bool VerifyNeo2TouchValid(Vector2 nowTouchPos)
	{
		if (nowTouchPos.x > vecOriginNeo2.x && nowTouchPos.x > lastTouchDownPos.x)
		{
			return true;
		}
		if (nowTouchPos.x < vecOriginNeo2.x && nowTouchPos.x < lastTouchDownPos.x)
		{
			return true;
		}
		return false;
	}

	private void UpdatePos()
	{
		if (Controller.UPvr_GetKey(0, Pvr_KeyCode.TOUCHPAD) || Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.TOUCHPAD))
		{
			ResetParameter();
		}
		else if (!isClosed && IsControllerConnect())
		{
			if ((double)scrollRect.horizontalScrollbar.value >= 0.9999 && tarPos.x <= currPos.x)
			{
				isClosed = true;
				return;
			}
			if ((double)scrollRect.horizontalScrollbar.value <= 0.0001 && tarPos.x >= currPos.x)
			{
				isClosed = true;
				return;
			}
			currPos.x = Mathf.Lerp(currPos.x, tarPos.x, lerpSpeed * Time.deltaTime);
			currPos.y = Mathf.Lerp(currPos.y, tarPos.y, lerpSpeed * Time.deltaTime);
			scrollRect.content.localPosition = currPos;
		}
	}

	private void ResetParameter()
	{
		currPos = scrollRect.content.localPosition;
		tarPos = scrollRect.content.localPosition;
		isClosed = true;
	}

	private void Process()
	{
		for (int i = 0; i < Pvr_InputModule.pointers.Count; i++)
		{
			Pvr_UIPointer pvr_UIPointer = Pvr_InputModule.pointers[i];
			if (pvr_UIPointer.gameObject.activeInHierarchy && pvr_UIPointer.enabled)
			{
				isHoving = IsHovering(pvr_UIPointer);
			}
		}
	}

	private bool IsHovering(Pvr_UIPointer pointer)
	{
		if (!IsControllerConnect())
		{
			return false;
		}
		foreach (GameObject item in pointer.pointerEventData.hovered)
		{
			if (FindTree(item.transform))
			{
				mainHand = Controller.UPvr_GetMainHandNess();
				if (mainHand == 0 && Pvr_ControllerManager.controllerlink.controller0Connected)
				{
					return true;
				}
				if (mainHand == 1 && Pvr_ControllerManager.controllerlink.controller1Connected)
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool FindTree(Transform tran)
	{
		if (tran == base.transform || tran == tranViewport)
		{
			return true;
		}
		if (tran.IsChildOf(tranViewport))
		{
			return true;
		}
		return false;
	}
}
public class Pvr_TouchVisual : MonoBehaviour
{
	[HideInInspector]
	public ControllerDevice currentDevice;

	[HideInInspector]
	public ControllerVariety variety;

	private MeshRenderer touchRenderer;

	private void Start()
	{
		variety = base.transform.GetComponentInParent<Pvr_ControllerModuleInit>().Variety;
		currentDevice = GetComponentInParent<Pvr_ControllerVisual>().currentDevice;
		touchRenderer = GetComponent<MeshRenderer>();
	}

	private void Update()
	{
		ChangeEffects((variety != 0) ? 1 : 0);
	}

	private void ChangeEffects(int hand)
	{
		ControllerDevice controllerDevice = currentDevice;
		if (controllerDevice == ControllerDevice.G2)
		{
			if (Controller.UPvr_IsTouching(0))
			{
				touchRenderer.enabled = true;
				base.transform.localPosition = new Vector3(1.3f - Controller.UPvr_GetTouchPadPosition(hand).x * 0.01f, 1.6f, -1.7f - Controller.UPvr_GetTouchPadPosition(hand).y * 0.01f);
			}
			else
			{
				touchRenderer.enabled = false;
			}
		}
	}
}
public class DemoController : MonoBehaviour
{
	public delegate void showLoadingEventHandler();

	private Callback callback;

	private GameObject msg;

	private Pvr_UnitySDKManager picoVrManager;

	private string currentOrderID;

	public GameObject loading;

	public GameObject BG;

	public GameObject InputPanel;

	public static showLoadingEventHandler showLoading;

	private void Awake()
	{
		UnityEngine.Debug.Log(loading.name);
		UnityEngine.Debug.Log(BG.name);
		showLoading = (showLoadingEventHandler)Delegate.Combine(showLoading, new showLoadingEventHandler(StopLoading));
		InputManager.doEnter = (InputManager.doEnterEventHandler)Delegate.Combine(InputManager.doEnter, new InputManager.doEnterEventHandler(DoPayByCode));
		currentOrderID = "";
	}

	private void Start()
	{
		msg = GameObject.Find("MassageInfo");
		InitDelegate();
		callback = new Callback();
		picoVrManager = GameObject.Find("Pvr_UnitySDK").GetComponent<Pvr_UnitySDKManager>();
		InputPanel.SetActive(value: false);
	}

	private void Update()
	{
		if (picoVrManager != null && (Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.Joystick1Button2)))
		{
			UnityEngine.Debug.Log("update");
			Pvr_UnitySDKSensor.Instance.ResetUnitySDKSensor();
		}
		if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Escape))
		{
			if (InputPanel.activeInHierarchy)
			{
				InputPanel.SetActive(value: false);
			}
			else
			{
				Application.Quit();
			}
		}
	}

	private void InitDelegate()
	{
		foreach (string item in new ArrayList { "Login", "GetUserAPI", "PayOne", "PayCode", "QueryOrder" })
		{
			GameObject btnObj = GameObject.Find(item);
			btnObj.GetComponent<Button>().onClick.AddListener(delegate
			{
				OnClick(btnObj);
			});
		}
	}

	private void OnClick(GameObject btnObj)
	{
		switch (btnObj.name)
		{
		case "Login":
			StartLoading();
			LoginSDK.Login();
			break;
		case "PayOne":
			CommonDic.getInstance().setParameters("subject", "game");
			CommonDic.getInstance().setParameters("body", "gamePay");
			CommonDic.getInstance().setParameters("order_id", getRamdomTestOrderID());
			CommonDic.getInstance().setParameters("total", "1");
			CommonDic.getInstance().setParameters("goods_tag", "game");
			CommonDic.getInstance().setParameters("notify_url", "www.picovr.com");
			CommonDic.getInstance().setParameters("pay_code", "");
			StartLoading();
			PicoPaymentSDK.Pay(CommonDic.getInstance().PayOrderString());
			break;
		case "PayCode":
			InputPanel.SetActive(value: true);
			break;
		case "QueryOrder":
			StartLoading();
			PicoPaymentSDK.QueryOrder(currentOrderID);
			break;
		case "GetUserAPI":
			StartLoading();
			LoginSDK.GetUserAPI();
			break;
		}
	}

	public string getRamdomTestOrderID()
	{
		currentOrderID = (UnityEngine.Random.value * 65535f).ToString();
		return currentOrderID;
	}

	private void StartLoading()
	{
		loading.SetActive(value: true);
		BG.SetActive(value: true);
	}

	public void StopLoading()
	{
		if ((bool)loading && (bool)BG)
		{
			loading.SetActive(value: false);
			BG.SetActive(value: false);
		}
		else
		{
			UnityEngine.Debug.LogError("用户自定义，非演示demo");
		}
	}

	public void DoPayByCode()
	{
		CommonDic.getInstance().setParameters("subject", "game");
		CommonDic.getInstance().setParameters("body", "gamePay");
		CommonDic.getInstance().setParameters("order_id", getRamdomTestOrderID());
		CommonDic.getInstance().setParameters("total", "0");
		CommonDic.getInstance().setParameters("goods_tag", "game");
		CommonDic.getInstance().setParameters("notify_url", "www.picovr.com");
		CommonDic.getInstance().setParameters("pay_code", GameObject.Find("CodeText").GetComponent<Text>().text);
		UnityEngine.Debug.Log("商品码支付" + GameObject.Find("CodeText").GetComponent<Text>().text);
		StartLoading();
		GameObject.Find("CodeText").GetComponent<Text>().text = "";
		InputPanel.SetActive(value: false);
		PicoPaymentSDK.Pay(CommonDic.getInstance().PayOrderString());
	}

	private bool VerifyLocalToken()
	{
		if (CommonDic.getInstance().access_token.Equals(""))
		{
			GameObject.Find("MassageInfo").GetComponent<Text>().text = "{code:exception,msg:请先登录}";
			currentOrderID = "";
			StopLoading();
			return false;
		}
		return true;
	}
}
public class LoadingRatation : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
		base.gameObject.transform.Rotate(new Vector3(0f, 0f, -4f));
	}
}
public class InputManager : MonoBehaviour
{
	public delegate void doEnterEventHandler();

	public static doEnterEventHandler doEnter;

	private StringBuilder sb = new StringBuilder();

	private ArrayList btnsName = new ArrayList();

	private GameObject enter;

	private void Awake()
	{
		InitKeyBoard();
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void InitKeyBoard()
	{
		btnsName.Add("1");
		btnsName.Add("2");
		btnsName.Add("3");
		btnsName.Add("4");
		btnsName.Add("5");
		btnsName.Add("6");
		btnsName.Add("7");
		btnsName.Add("8");
		btnsName.Add("9");
		btnsName.Add("0");
		btnsName.Add("Q");
		btnsName.Add("W");
		btnsName.Add("E");
		btnsName.Add("R");
		btnsName.Add("T");
		btnsName.Add("Y");
		btnsName.Add("U");
		btnsName.Add("I");
		btnsName.Add("O");
		btnsName.Add("P");
		btnsName.Add("A");
		btnsName.Add("S");
		btnsName.Add("D");
		btnsName.Add("F");
		btnsName.Add("G");
		btnsName.Add("H");
		btnsName.Add("J");
		btnsName.Add("K");
		btnsName.Add("L");
		btnsName.Add("Z");
		btnsName.Add("X");
		btnsName.Add("C");
		btnsName.Add("V");
		btnsName.Add("B");
		btnsName.Add("N");
		btnsName.Add("M");
		btnsName.Add("Clear");
		btnsName.Add("Capslock");
		btnsName.Add("Enter");
		foreach (string item in btnsName)
		{
			GameObject btnObj = GameObject.Find(item);
			btnObj.GetComponent<Button>().onClick.AddListener(delegate
			{
				OnClick(btnObj);
			});
		}
		enter = GameObject.Find("Enter");
		enter.SetActive(sb.Length > 0);
	}

	private void OnClick(GameObject btnObj)
	{
		if (btnObj.name.Equals("Capslock"))
		{
			if (GameObject.Find("Q").transform.GetChild(0).GetComponent<Text>().text.Equals("Q"))
			{
				DoCapslock(IsUpper: true);
			}
			else
			{
				DoCapslock(IsUpper: false);
			}
		}
		else if (btnObj.name.Equals("Clear"))
		{
			GameObject.Find("CodeText").GetComponent<Text>().text = "";
			ClearBuffer();
		}
		else if (btnObj.name.Equals("Enter"))
		{
			ClearBuffer();
			doEnter();
		}
		else
		{
			EnterChar(btnObj.transform.GetChild(0).GetComponent<Text>().text);
		}
	}

	private void EnterChar(string s)
	{
		sb.Append(s);
		GameObject.Find("CodeText").GetComponent<Text>().text = sb.ToString();
		enter.SetActive(sb.Length > 0);
	}

	private void DoCapslock(bool IsUpper)
	{
		if (IsUpper)
		{
			foreach (string item in btnsName)
			{
				Text component = GameObject.Find(item).transform.GetChild(0).GetComponent<Text>();
				component.text = component.text.ToLower();
			}
			return;
		}
		foreach (string item2 in btnsName)
		{
			Text component2 = GameObject.Find(item2).transform.GetChild(0).GetComponent<Text>();
			component2.text = component2.text.ToUpper();
		}
	}

	private void ClearBuffer()
	{
		sb.Remove(0, sb.Length);
		enter.SetActive(sb.Length > 0);
	}
}
public class Callback : MonoBehaviour
{
	private static string IS_SUCCESS = "isSuccess";

	private static string MSG = "msg";

	private static string CODE = "code";

	public void LoginCallback(string LoginInfo)
	{
		JsonData jsonData = JsonMapper.ToObject(LoginInfo);
		SetMassage(LoginInfo);
		DemoController.showLoading();
		if (jsonData[IS_SUCCESS] != null)
		{
			CommonDic.getInstance().isSuccess = jsonData[IS_SUCCESS].ToString();
		}
		if (jsonData[MSG] != null)
		{
			CommonDic.getInstance().loginMsg = jsonData[MSG].ToString();
		}
		UnityEngine.Debug.Log("调用login回调:" + LoginInfo);
	}

	public void QueryOrPayCallback(string queryOrPayInfo)
	{
		JsonData jsonData = JsonMapper.ToObject(queryOrPayInfo);
		if (jsonData[CODE] != null)
		{
			CommonDic.getInstance().code = jsonData["code"].ToString();
		}
		if (jsonData[MSG] != null)
		{
			CommonDic.getInstance().msg = jsonData["msg"].ToString();
		}
		if (jsonData != null)
		{
			CommonDic.getInstance().order_info = jsonData[1].ToString();
		}
		SetMassage(queryOrPayInfo);
		DemoController.showLoading();
		UnityEngine.Debug.Log("调用pay回调:" + queryOrPayInfo);
	}

	public void UserInfoCallback(string userInfo)
	{
		CommonDic.getInstance().user_info = userInfo;
		SetMassage(userInfo);
		DemoController.showLoading();
		UnityEngine.Debug.Log("调用userInfo回调:" + userInfo);
	}

	public void SetMassage(string massage)
	{
		if (!GetCurrentGameObject().Equals(null))
		{
			GetCurrentGameObject().GetComponent<Text>().text = massage;
		}
		else
		{
			UnityEngine.Debug.LogError("无接收该Message的控件");
		}
	}

	public GameObject GetCurrentGameObject()
	{
		return GameObject.Find("MassageInfo");
	}

	public void ActivityForResultCallback(string activity)
	{
		PicoPaymentSDK.jo.Call("authCallback", activity);
	}
}
public class CommonDic
{
	private static CommonDic dic;

	private static Dictionary<string, string> mydic;

	private string _app_ID;

	private string _app_Key;

	private string _user_token;

	private string _access_token = "";

	private string _open_id;

	private string _refresh_token;

	private string _expires_in;

	private string _user_info;

	private string _subject;

	private string _body;

	private string _order_id;

	private string _total;

	private string _goods_tag;

	private string _notify_url;

	private string _trade_type;

	private string _pay_code = "";

	private string _order_info;

	private string _code;

	private string _msg = "null";

	private string _merchant_ID;

	private string _payKey;

	private string _isSuucess;

	private string _loginMsg;

	public string subject
	{
		get
		{
			return _subject;
		}
		set
		{
			_subject = value;
		}
	}

	public string body
	{
		get
		{
			return _body;
		}
		set
		{
			_body = value;
		}
	}

	public string order_id
	{
		get
		{
			return _order_id;
		}
		set
		{
			_order_id = value;
		}
	}

	public string total
	{
		get
		{
			return _total;
		}
		set
		{
			_total = value;
		}
	}

	public string goods_tag
	{
		get
		{
			return _goods_tag;
		}
		set
		{
			_goods_tag = value;
		}
	}

	public string notify_url
	{
		get
		{
			return _notify_url;
		}
		set
		{
			_notify_url = value;
		}
	}

	public string pay_code
	{
		get
		{
			return _pay_code;
		}
		set
		{
			_pay_code = value;
		}
	}

	public string trade_type
	{
		get
		{
			return _trade_type;
		}
		set
		{
			_trade_type = value;
		}
	}

	public string user_token
	{
		get
		{
			return _user_token;
		}
		set
		{
			_user_token = value;
		}
	}

	public string access_token
	{
		get
		{
			return _access_token;
		}
		set
		{
			_access_token = value;
		}
	}

	public string open_id
	{
		get
		{
			return _open_id;
		}
		set
		{
			_open_id = value;
		}
	}

	public string refresh_token
	{
		get
		{
			return _refresh_token;
		}
		set
		{
			_refresh_token = value;
		}
	}

	public string expires_in
	{
		get
		{
			return _expires_in;
		}
		set
		{
			_expires_in = value;
		}
	}

	public string isSuccess
	{
		get
		{
			return _isSuucess;
		}
		set
		{
			_isSuucess = value;
		}
	}

	public string loginMsg
	{
		get
		{
			return _loginMsg;
		}
		set
		{
			_loginMsg = value;
		}
	}

	public string user_info
	{
		get
		{
			return _user_info;
		}
		set
		{
			_user_info = value;
		}
	}

	public string order_info
	{
		get
		{
			return _order_info;
		}
		set
		{
			_order_info = value;
		}
	}

	public string code
	{
		get
		{
			return _code;
		}
		set
		{
			_code = value;
		}
	}

	public string msg
	{
		get
		{
			return _msg;
		}
		set
		{
			_msg = value;
		}
	}

	public string app_ID
	{
		get
		{
			return _app_ID;
		}
		set
		{
			_app_ID = value;
		}
	}

	public string app_Key
	{
		get
		{
			return _app_Key;
		}
		set
		{
			_app_Key = value;
		}
	}

	public string merchant_ID
	{
		get
		{
			return _merchant_ID;
		}
		set
		{
			_merchant_ID = value;
		}
	}

	public string paykey
	{
		get
		{
			return _payKey;
		}
		set
		{
			_payKey = value;
		}
	}

	public static CommonDic getInstance()
	{
		if (dic == null)
		{
			dic = new CommonDic();
		}
		if (mydic == null)
		{
			mydic = new Dictionary<string, string>();
			InitDicData(mydic);
		}
		return dic;
	}

	public Dictionary<string, string> getDic()
	{
		return mydic;
	}

	public void setParameters(string name, string value)
	{
		if (name.Equals("subject"))
		{
			subject = value;
		}
		if (name.Equals("body"))
		{
			body = value;
		}
		if (name.Equals("order_id"))
		{
			order_id = value;
		}
		if (name.Equals("total"))
		{
			total = value;
		}
		if (name.Equals("goods_tag"))
		{
			goods_tag = value;
		}
		if (name.Equals("notify_url"))
		{
			notify_url = value;
		}
		if (name.Equals("trade_type"))
		{
			trade_type = value;
		}
		if (name.Equals("pay_code"))
		{
			pay_code = value;
		}
	}

	public string PayOrderString()
	{
		return JsonMapper.ToJson(getInstance());
	}

	public static void InitDicData(Dictionary<string, string> mydic)
	{
		mydic.Add("00000", "网络异常");
		mydic.Add("10000", "登录成功");
		mydic.Add("10001", "用户未登陆");
		mydic.Add("10002", "请输入正确金额");
		mydic.Add("10003", "登陆过期，请重新登陆");
		mydic.Add("11000", "商户验证成功");
		mydic.Add("11001", "商户验证失败");
		mydic.Add("11002", "用户验证参数错误或请求过期");
		mydic.Add("11003", "商户未验证");
		mydic.Add("12000", "支付成功");
		mydic.Add("12001", "支付失败");
		mydic.Add("12003", "P币不足");
		mydic.Add("12004", "余额可用");
		mydic.Add("13000", "生成订单");
		mydic.Add("13001", "获取数据失败");
		mydic.Add("13002", "生成订单失败");
		mydic.Add("14000", "查询订单成功");
		mydic.Add("14001", "订单不存在/有误");
		mydic.Add("14002", "用户取消支付操作");
		mydic.Add("15000", "未输入商品信息");
		mydic.Add("15001", "未输入预付ID");
		mydic.Add("15002", "请输入Pico支付订单号或商户订单号");
		mydic.Add("NOAUTH", "商户无此接口权限");
		mydic.Add("SYSTEMERROR", "系统错误");
		mydic.Add("APP_ID_NOT_EXIST", "APP_ID不存在");
		mydic.Add("MCHID_NOT_EXIST", "MCHID不存在");
		mydic.Add("APP_ID_MCHID_NOT_MATCH", "app_id和mch_id不匹配ID");
		mydic.Add("LACK_PARAMS", "缺少参数");
		mydic.Add("SIGNERROR", "签名错误");
		mydic.Add("NO_DATA", "没有查询到数据");
	}
}
public class LoginSDK
{
	public static void Login()
	{
		PicoPaymentSDK.Login();
	}

	public static void GetUserAPI()
	{
		PicoPaymentSDK.GetUserAPI();
	}
}
public class PicoPaymentSDK
{
	private static AndroidJavaObject _jo = new AndroidJavaObject("com.pico.loginpaysdk.UnityInterface");

	public static AndroidJavaObject jo
	{
		get
		{
			return _jo;
		}
		set
		{
			_jo = value;
		}
	}

	public static void Login()
	{
		AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		jo.Call("init", @static);
		jo.Call("authSSO");
	}

	public static void Pay(string payOrderJson)
	{
		AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		jo.Call("init", @static);
		jo.Call("pay", payOrderJson);
	}

	public static void QueryOrder(string orderId)
	{
		AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		jo.Call("init", @static);
		jo.Call("queryOrder", orderId);
	}

	public static void GetUserAPI()
	{
		AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		jo.Call("init", @static);
		jo.Call("getUserAPI");
	}
}
public class Pvr_ToBService : MonoBehaviour
{
	public Text deviceInfoText;

	private void Awake()
	{
		InitToBService();
	}

	private void Start()
	{
		BindToBService();
	}

	private void OnDestory()
	{
		UnBindToBService();
	}

	private void InitToBService()
	{
		ToBService.UPvr_InitToBService();
		ToBService.UPvr_SetUnityObjectName(base.name);
	}

	private void BindToBService()
	{
		ToBService.UPvr_BindToBService();
	}

	private void UnBindToBService()
	{
		ToBService.UPvr_UnBindToBService();
	}

	private void BoolCallback(string value)
	{
		if (ToBService.BoolCallback != null)
		{
			ToBService.BoolCallback(bool.Parse(value));
		}
		ToBService.BoolCallback = null;
	}

	private void IntCallback(string value)
	{
		if (ToBService.IntCallback != null)
		{
			ToBService.IntCallback(int.Parse(value));
		}
		ToBService.IntCallback = null;
	}

	private void LongCallback(string value)
	{
		if (ToBService.LongCallback != null)
		{
			ToBService.LongCallback(int.Parse(value));
		}
		ToBService.LongCallback = null;
	}

	public void StateGetDeviceInfo()
	{
		string text = ToBService.UPvr_StateGetDeviceInfo(PBS_SystemInfoEnum.PUI_VERSION);
		deviceInfoText.text = "PUI_VERSION:" + text;
	}

	public void ControlSetDeviceAction()
	{
		ToBService.UPvr_ControlSetDeviceAction(PBS_DeviceControlEnum.DEVICE_CONTROL_SHUTDOWN, ControlSetDeviceActionCallBack);
	}

	private void ControlSetDeviceActionCallBack(int value)
	{
		UnityEngine.Debug.Log("ControlSetDeviceActionCallBack : " + value);
	}

	public void AppManager()
	{
		ToBService.UPvr_ControlAPPManger(PBS_PackageControlEnum.PACKAGE_SILENCE_UNINSTALL, "com.pico.ipd.test", AppManagerCallBack);
	}

	private void AppManagerCallBack(int value)
	{
		UnityEngine.Debug.Log("AppManagerCallBack : " + value);
	}
}
public class PLOG : MonoBehaviour
{
	public static int logLevel;

	public static void getConfigTraceLevel()
	{
		Render.UPvr_GetIntConfig(6, ref logLevel);
	}

	public static void D(string msg)
	{
		if (logLevel > 2)
		{
			UnityEngine.Debug.Log(msg);
		}
	}

	public static void I(string msg)
	{
		if (logLevel > 1)
		{
			UnityEngine.Debug.Log(msg);
		}
	}

	public static void W(string msg)
	{
		if (logLevel > 0)
		{
			UnityEngine.Debug.LogWarning(msg);
		}
	}

	public static void E(string msg)
	{
		UnityEngine.Debug.LogError(msg);
	}
}
public class CPicoSDKSettingAsset : ScriptableObject
{
	public bool IgnoreSDKSetting;

	public bool DontshowBuildWaring;

	public bool AppIDChecked;
}
[Serializable]
public class Pvr_UnitySDKProjectSetting : ScriptableObject
{
	public RenderTextureAntiAliasing rtAntiAlising;

	public RenderTextureDepth rtBitDepth;

	public RenderTextureFormat rtFormat;

	public bool usedefaultRenderTexture;

	public Vector2 customRTSize;

	public bool usedefaultfps;

	public int customfps;

	public bool usesinglepass;

	public bool usecontentprotect;

	public static Pvr_UnitySDKProjectSetting GetProjectConfig()
	{
		return Resources.Load<Pvr_UnitySDKProjectSetting>("ProjectSetting");
	}
}
public sealed class Pvr_UnitySDKPlatformSetting : ScriptableObject
{
	public enum simulationType
	{
		Null,
		Invalid,
		Valid
	}

	[SerializeField]
	private bool entitlementchecksimulation;

	[SerializeField]
	private bool startTimeEntitlementCheck;

	[SerializeField]
	public string appID;

	public List<string> deviceSN = new List<string>();

	private static Pvr_UnitySDKPlatformSetting instance;

	public static bool Entitlementchecksimulation
	{
		get
		{
			return Instance.entitlementchecksimulation;
		}
		set
		{
			if (Instance.entitlementchecksimulation != value)
			{
				Instance.entitlementchecksimulation = value;
			}
		}
	}

	public static bool StartTimeEntitlementCheck
	{
		get
		{
			return Instance.startTimeEntitlementCheck;
		}
		set
		{
			if (Instance.startTimeEntitlementCheck != value)
			{
				Instance.startTimeEntitlementCheck = value;
			}
		}
	}

	public static Pvr_UnitySDKPlatformSetting Instance
	{
		get
		{
			if (instance == null)
			{
				instance = Resources.Load<Pvr_UnitySDKPlatformSetting>("PlatformSettings");
			}
			return instance;
		}
		set
		{
			instance = value;
		}
	}
}
public class Pvr_UnitySDKManager : MonoBehaviour
{
	public delegate void EntitlementCheckResult(int ReturnValue);

	public static PlatForm platform;

	private static Pvr_UnitySDKManager sdk;

	[HideInInspector]
	public float EyesAspect = 1f;

	[HideInInspector]
	public int posStatus;

	[HideInInspector]
	public bool ismirroring;

	[HideInInspector]
	public Vector3 resetBasePos;

	[HideInInspector]
	public int trackingmode = -1;

	[HideInInspector]
	public int systemprop = -1;

	[HideInInspector]
	public bool systemFPS;

	[HideInInspector]
	public float[] headData = new float[7];

	[SerializeField]
	private bool rotfoldout;

	[SerializeField]
	private bool hmdOnlyrot;

	[SerializeField]
	private bool controllerOnlyrot;

	[SerializeField]
	private TrackingOrigin trackingOrigin;

	public bool ResetTrackerOnLoad;

	[HideInInspector]
	public Vector3 leftEyeOffset;

	[HideInInspector]
	public Vector3 rightEyeOffset;

	[HideInInspector]
	public Rect leftEyeRect;

	[HideInInspector]
	public Rect rightEyeRect;

	[HideInInspector]
	public Matrix4x4 leftEyeView;

	[HideInInspector]
	public Matrix4x4 rightEyeView;

	[HideInInspector]
	public Pvr_UnitySDKEditor pvr_UnitySDKEditor;

	[SerializeField]
	private bool vrModeEnabled = true;

	[HideInInspector]
	public Material Eyematerial;

	[HideInInspector]
	public Material Middlematerial;

	[HideInInspector]
	public bool newPicovrTriggered;

	[SerializeField]
	private bool showFPS;

	[HideInInspector]
	public Vector3 neckOffset = new Vector3(0f, 0.075f, 0.0805f);

	[SerializeField]
	private bool pVRNeck = true;

	[HideInInspector]
	public bool UseCustomNeckPara;

	[HideInInspector]
	public bool onResume;

	[HideInInspector]
	public bool isEnterVRMode;

	public bool isHasController;

	public Pvr_UnitySDKConfigProfile pvr_UnitySDKConfig;

	private GameObject calltoast;

	private GameObject msgtoast;

	private GameObject lowhmdBatterytoast;

	private GameObject lowphoneBatterytoast;

	private GameObject LowPhoneHealthtoast;

	private GameObject LowcontrollerBatterytoast;

	private bool lowControllerpowerstate;

	private float controllerpowershowtime;

	private bool UseToast = true;

	private int iPhoneHMDModeEnabled;

	private GameObject G3LiteTips;

	[SerializeField]
	private bool monoscopic;

	private bool mIsAndroid7;

	public static Func<bool> eventEnterVRMode;

	[HideInInspector]
	public bool ShowVideoSeethrough;

	public int SystemDebugFFRLevel = -1;

	public int SystemFFRLevel = -1;

	public int AppCheckResult = 100;

	public Action longPressHomeKeyAction;

	public static Pvr_UnitySDKManager SDK
	{
		get
		{
			if (sdk == null)
			{
				sdk = UnityEngine.Object.FindObjectOfType<Pvr_UnitySDKManager>();
			}
			return sdk;
		}
	}

	public bool Rotfoldout
	{
		get
		{
			return rotfoldout;
		}
		set
		{
			if (value != rotfoldout)
			{
				rotfoldout = value;
			}
		}
	}

	public bool HmdOnlyrot
	{
		get
		{
			return hmdOnlyrot;
		}
		set
		{
			if (value != hmdOnlyrot)
			{
				hmdOnlyrot = value;
			}
		}
	}

	public bool ControllerOnlyrot
	{
		get
		{
			return controllerOnlyrot;
		}
		set
		{
			if (value != controllerOnlyrot)
			{
				controllerOnlyrot = value;
			}
		}
	}

	public TrackingOrigin TrackingOrigin
	{
		get
		{
			return trackingOrigin;
		}
		set
		{
			if (value != trackingOrigin)
			{
				trackingOrigin = value;
				Sensor.UPvr_SetTrackingOriginType(value);
			}
		}
	}

	[HideInInspector]
	public bool VRModeEnabled
	{
		get
		{
			return vrModeEnabled;
		}
		set
		{
			if (value != vrModeEnabled)
			{
				vrModeEnabled = value;
			}
		}
	}

	[HideInInspector]
	public bool picovrTriggered { get; set; }

	public bool ShowFPS
	{
		get
		{
			return showFPS;
		}
		set
		{
			if (value != showFPS)
			{
				showFPS = value;
			}
		}
	}

	public bool PVRNeck
	{
		get
		{
			return pVRNeck;
		}
		set
		{
			if (value != pVRNeck)
			{
				pVRNeck = value;
			}
		}
	}

	[HideInInspector]
	public bool Monoscopic
	{
		get
		{
			return monoscopic;
		}
		set
		{
			if (value != monoscopic)
			{
				monoscopic = value;
				Render.UPvr_SetMonoMode(monoscopic);
			}
		}
	}

	public static event EntitlementCheckResult EntitlementCheckResultEvent;

	public void ChangeDefaultCustomRtSize(int w, int h)
	{
		Pvr_UnitySDKProjectSetting.GetProjectConfig().customRTSize = new Vector2(w, h);
	}

	public Vector3 EyeOffset(Eye eye)
	{
		if (eye != 0)
		{
			return rightEyeOffset;
		}
		return leftEyeOffset;
	}

	public Rect EyeRect(Eye eye)
	{
		if (eye != 0)
		{
			return rightEyeRect;
		}
		return leftEyeRect;
	}

	private bool SDKManagerInit()
	{
		if (SDKManagerInitConfigProfile())
		{
			mIsAndroid7 = SystemInfo.operatingSystem.Contains("Android OS 7.");
			PLOG.I("Android 7 = " + mIsAndroid7);
			if (SDKManagerInitCoreAbility())
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private bool SDKManagerInitCoreAbility()
	{
		Sensor.UPvr_SetTrackingOriginType(trackingOrigin);
		Render.UPvr_SetMonoMode(monoscopic);
		if (Pvr_UnitySDKRender.Instance == null)
		{
			PLOG.I("pvr_UnitySDKRender init failed");
		}
		if (Pvr_UnitySDKSensor.Instance == null)
		{
			PLOG.I("pvr_UnitySDKSensor init failed");
		}
		Pvr_UnitySDKAPI.System.UPvr_StartHomeKeyReceiver(base.gameObject.name);
		return true;
	}

	public void smsReceivedCallback(string msg)
	{
		PLOG.I("PvrLog MSG" + msg);
		JsonData jsonData = JsonMapper.ToObject(msg);
		string text = "";
		if (msg.Contains("messageSender"))
		{
			text = (string)jsonData["messageSender"];
		}
		string text2 = "";
		if (msg.Contains("messageAdr"))
		{
			text2 = (string)jsonData["messageAdr"];
			if (text2.Substring(0, 3) == "+82")
			{
				text2 = "0" + text2.Remove(0, 3);
				text2 = TransformNumber(text2);
			}
			else if (text2.Substring(0, 1) != "+")
			{
				text2 = TransformNumber(text2);
			}
		}
		if (UseToast)
		{
			msgtoast.transform.Find("number").GetComponent<Text>().text = text2;
			msgtoast.transform.Find("name").GetComponent<Text>().text = text;
			if (text.Length == 0)
			{
				msgtoast.transform.Find("number").transform.localPosition = new Vector3(0f, 0f, 0f);
			}
			else
			{
				msgtoast.transform.Find("number").transform.localPosition = new Vector3(60f, 0f, 0f);
			}
			StartCoroutine(ToastManager(2, state: true, 0f));
			StartCoroutine(ToastManager(2, state: false, 5f));
		}
	}

	public void phoneStateCallback(string state)
	{
		PLOG.I("PvrLog phone" + state);
		JsonData jsonData = JsonMapper.ToObject(state);
		string text = "";
		if (state.Contains("phoneNumber"))
		{
			text = (string)jsonData["phoneNumber"];
			if (text.Substring(0, 3) == "+82")
			{
				text = "0" + text.Remove(0, 3);
				text = TransformNumber(text);
			}
			else if (text.Substring(0, 1) != "+")
			{
				text = TransformNumber(text);
			}
		}
		string text2 = "";
		if (state.Contains("contactName"))
		{
			text2 = (string)jsonData["contactName"];
		}
		if (UseToast)
		{
			calltoast.transform.Find("number").GetComponent<Text>().text = text;
			calltoast.transform.Find("name").GetComponent<Text>().text = text2;
			if (text2.Length == 0)
			{
				calltoast.transform.Find("number").transform.localPosition = new Vector3(0f, 0f, 0f);
			}
			else
			{
				calltoast.transform.Find("number").transform.localPosition = new Vector3(60f, 0f, 0f);
			}
			StartCoroutine(ToastManager(1, state: true, 0f));
			StartCoroutine(ToastManager(1, state: false, 5f));
		}
	}

	public void phoneBatteryStateCallback(string state)
	{
		PLOG.I("PvrLog phoneBatteryState" + state);
		JsonData jsonData = JsonMapper.ToObject(state);
		string value = "";
		if (state.Contains("phoneBatteryLevel"))
		{
			value = (string)jsonData["phoneBatteryLevel"];
		}
		string value2 = "";
		if (state.Contains("phoneBatteryHealth"))
		{
			value2 = (string)jsonData["phoneBatteryHealth"];
		}
		if (!UseToast)
		{
			return;
		}
		if (Convert.ToInt16(value) <= 5)
		{
			if (!lowhmdBatterytoast.activeSelf)
			{
				StartCoroutine(ToastManager(4, state: true, 0f));
				StartCoroutine(ToastManager(4, state: false, 3f));
			}
			else
			{
				StartCoroutine(ToastManager(4, state: true, 5f));
				StartCoroutine(ToastManager(4, state: false, 8f));
			}
		}
		if (Convert.ToInt16(value2) == 3)
		{
			StartCoroutine(ToastManager(5, state: true, 0f));
			StartCoroutine(ToastManager(5, state: false, 5f));
		}
	}

	public void hmdLowBatteryCallback(string level)
	{
		PLOG.I("PvrLog hmdLowBatteryCallback" + level);
		if (UseToast)
		{
			if (!lowphoneBatterytoast.activeSelf)
			{
				StartCoroutine(ToastManager(3, state: true, 0f));
				StartCoroutine(ToastManager(3, state: false, 3f));
			}
			else
			{
				StartCoroutine(ToastManager(3, state: true, 5f));
				StartCoroutine(ToastManager(3, state: false, 8f));
			}
		}
	}

	private string TransformNumber(string number)
	{
		if (number.Length == 11)
		{
			string text = number.Substring(0, 3);
			string text2 = number.Substring(3, 4);
			string text3 = number.Substring(7, 4);
			number = text + "-" + text2 + "-" + text3;
		}
		else if (number.Length == 10)
		{
			if (number.Substring(1, 1) == "1")
			{
				string text4 = number.Substring(0, 3);
				string text5 = number.Substring(3, 3);
				string text6 = number.Substring(6, 4);
				number = text4 + "-" + text5 + "-" + text6;
			}
			else
			{
				string text7 = number.Substring(0, 2);
				string text8 = number.Substring(2, 4);
				string text9 = number.Substring(6, 4);
				number = text7 + "-" + text8 + "-" + text9;
			}
		}
		else if (number.Length == 9)
		{
			if (number.Substring(1, 1) == "2")
			{
				string text10 = number.Substring(0, 2);
				string text11 = number.Substring(2, 3);
				string text12 = number.Substring(5, 4);
				number = text10 + "-" + text11 + "-" + text12;
			}
			else
			{
				number = "+82" + number.Remove(0, 1);
			}
		}
		return number;
	}

	public void onHmdOrientationReseted()
	{
	}

	private IEnumerator ToastManager(int type, bool state, float time)
	{
		yield return new WaitForSeconds(time);
		switch (type)
		{
		case 1:
			calltoast.SetActive(state);
			break;
		case 2:
			msgtoast.SetActive(state);
			break;
		case 3:
			lowhmdBatterytoast.SetActive(state);
			break;
		case 4:
			lowphoneBatterytoast.SetActive(state);
			break;
		case 5:
			LowPhoneHealthtoast.SetActive(state);
			break;
		case 6:
			LowcontrollerBatterytoast.SetActive(state);
			break;
		}
	}

	private void CheckControllerStateForG2(string state)
	{
		if (iPhoneHMDModeEnabled == 1 && Convert.ToBoolean(Convert.ToInt16(state)) && Controller.UPvr_GetControllerPower(0) == 0 && Pvr_ControllerManager.controllerlink.Controller0.Rotation.eulerAngles != Vector3.zero)
		{
			StartCoroutine(ToastManager(6, state: true, 0f));
			StartCoroutine(ToastManager(6, state: false, 3f));
		}
	}

	public void notificationCallback(string data)
	{
		JsonData jsonData = JsonMapper.ToObject(data);
		if (G3LiteTips == null)
		{
			G3LiteTips = UnityEngine.Object.Instantiate(Resources.Load("Prefabs/G3LiteTips") as GameObject, base.transform.Find("Head"), worldPositionStays: false);
		}
		JsonData jsonData2 = JsonMapper.ToObject(jsonData["str"].ToString());
		switch ((int)jsonData["type"])
		{
		case 0:
			SetProperty(0, jsonData2, "Sms");
			break;
		case 1:
			SetProperty(1, jsonData2, "Call");
			break;
		case 2:
			SetProperty(2, jsonData2, "Warnning");
			break;
		case 3:
			SetProperty(3, jsonData2, "Warnning");
			break;
		case 4:
			SetProperty(4, jsonData2, "Warnning");
			break;
		case 5:
		{
			Transform transform = G3LiteTips.transform.Find("Onlyimage");
			SetBaseProperty(transform, jsonData2["General"], "");
			SetImageProperty(transform, jsonData2["General"], "");
			transform.gameObject.SetActive(value: true);
			StartCoroutine(G3TipsManager(transform.gameObject, (int)jsonData2["General"]["time"]));
			break;
		}
		case -1:
			break;
		}
	}

	private Sprite LoadSprite(Vector2 size, string filepath)
	{
		int width = (int)size.x;
		int height = (int)size.y;
		Texture2D texture2D = new Texture2D(width, height);
		texture2D.LoadImage(ReadTex(filepath));
		return Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));
	}

	private byte[] ReadTex(string path)
	{
		if (path == "")
		{
			return new byte[0];
		}
		FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
		fileStream.Seek(0L, SeekOrigin.Begin);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, (int)fileStream.Length);
		fileStream.Close();
		fileStream.Dispose();
		fileStream = null;
		return array;
	}

	private void SetProperty(int type, JsonData data, string value)
	{
		Transform trans = G3LiteTips.transform.Find(value);
		SetBaseProperty(trans, data, "");
		SetImageProperty(trans, data, "");
		trans.gameObject.SetActive(value: true);
		StartCoroutine(G3TipsManager(trans.gameObject, (int)data["time"]));
		Transform transform = trans.transform.Find("icon");
		SetBaseProperty(transform, data, "icon_");
		SetImageProperty(transform, data, "icon_");
		Transform transform2 = trans.transform.Find("title");
		SetBaseProperty(transform2, data, "title_");
		SetTextProperty(transform2, data, "title_");
		if (type != 1)
		{
			Transform transform3 = trans.transform.Find("details");
			SetBaseProperty(transform3, data, "details_");
			SetTextProperty(transform3, data, "details_");
			Transform transform4 = trans.transform.Find("image1");
			SetBaseProperty(transform4, data, "image1_");
			SetImageProperty(transform4, data, "image1_");
		}
		if (type == 0 || type == 1)
		{
			Transform transform5 = trans.transform.Find("explain");
			SetBaseProperty(transform5, data, "explain_");
			SetTextProperty(transform5, data, "explain_");
			Transform transform6 = trans.transform.Find("source");
			SetBaseProperty(transform6, data, "source_");
			SetTextProperty(transform6, data, "source_");
		}
		if (type == 0)
		{
			Transform transform7 = trans.transform.Find("time");
			SetBaseProperty(transform7, data, "system_time_");
			SetTextProperty(transform7, data, "system_time_");
		}
		Transform transform8 = trans.transform.Find("Button");
		SetBaseProperty(transform8, data, "button_");
		SetImageProperty(transform8, data, "button_");
		transform8.GetComponent<Button>().onClick.AddListener(delegate
		{
			StartCoroutine(G3TipsManager(trans.gameObject, 0f));
		});
		Transform transform9 = transform8.transform.Find("Text");
		SetBaseProperty(transform9, data, "button_text_");
		SetTextProperty(transform9, data, "button_text_");
	}

	private void SetBaseProperty(Transform trans, JsonData data, string value)
	{
		string prop_name = value + "pos";
		string prop_name2 = value + "angles";
		string prop_name3 = value + "size";
		string prop_name4 = value + "scale";
		trans.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(JsonToFloat(data[prop_name][0]), JsonToFloat(data[prop_name][1]), JsonToFloat(data[prop_name][2]));
		trans.GetComponent<RectTransform>().eulerAngles = new Vector3(JsonToFloat(data[prop_name2][0]), JsonToFloat(data[prop_name2][1]), JsonToFloat(data[prop_name2][2]));
		trans.GetComponent<RectTransform>().sizeDelta = new Vector2(JsonToFloat(data[prop_name3][0]), JsonToFloat(data[prop_name3][1]));
		trans.GetComponent<RectTransform>().localScale = new Vector3(JsonToFloat(data[prop_name4][0]), JsonToFloat(data[prop_name4][1]), JsonToFloat(data[prop_name4][2]));
	}

	private void SetImageProperty(Transform image, JsonData data, string value)
	{
		string prop_name = value + "sprite";
		string prop_name2 = value + "color";
		string prop_name3 = value + "size";
		image.GetComponent<Image>().sprite = LoadSprite(new Vector2(JsonToFloat(data[prop_name3][0]), JsonToFloat(data[prop_name3][1])), (string)data[prop_name]);
		image.GetComponent<Image>().color = new Color(JsonToFloat(data[prop_name2][0]), JsonToFloat(data[prop_name2][1]), JsonToFloat(data[prop_name2][2]), JsonToFloat(data[prop_name2][3]));
	}

	private void SetTextProperty(Transform text, JsonData data, string value)
	{
		string prop_name = value + "color";
		string prop_name2 = value + "font_size";
		string prop_name3 = value + "font_style";
		string prop_name4 = value + "text";
		text.GetComponent<Text>().text = (string)data[prop_name4];
		text.GetComponent<Text>().color = new Color(JsonToFloat(data[prop_name][0]), JsonToFloat(data[prop_name][1]), JsonToFloat(data[prop_name][2]), JsonToFloat(data[prop_name][3]));
		text.GetComponent<Text>().fontSize = (int)data[prop_name2];
		text.GetComponent<Text>().fontStyle = (FontStyle)(int)data[prop_name3];
	}

	private IEnumerator G3TipsManager(GameObject tip, float time)
	{
		yield return new WaitForSeconds(time);
		tip.SetActive(value: false);
	}

	private float JsonToFloat(JsonData data)
	{
		return Convert.ToSingle((string)data);
	}

	private bool SDKManagerInitFPS()
	{
		Transform[] componentsInChildren = GetComponentsInChildren<Transform>(includeInactive: true);
		GameObject gameObject = null;
		Transform[] array = componentsInChildren;
		foreach (Transform transform in array)
		{
			if (transform.gameObject.name == "FPS")
			{
				gameObject = transform.gameObject;
			}
		}
		if (gameObject != null)
		{
			if (systemFPS)
			{
				gameObject.SetActive(value: true);
				return true;
			}
			int res = 0;
			Render.UPvr_GetIntConfig(10, ref res);
			if (Convert.ToBoolean(res))
			{
				gameObject.SetActive(value: true);
				return true;
			}
			if (ShowFPS)
			{
				gameObject.SetActive(value: true);
				return true;
			}
			return false;
		}
		return false;
	}

	private bool SDKManagerInitConfigProfile()
	{
		pvr_UnitySDKConfig = Pvr_UnitySDKConfigProfile.Default;
		return true;
	}

	private bool SDKManagerInitEditor()
	{
		if (pvr_UnitySDKEditor == null)
		{
			pvr_UnitySDKEditor = base.gameObject.AddComponent<Pvr_UnitySDKEditor>();
		}
		else
		{
			pvr_UnitySDKEditor = null;
			pvr_UnitySDKEditor = base.gameObject.AddComponent<Pvr_UnitySDKEditor>();
		}
		return true;
	}

	private bool SDKManagerInitPara()
	{
		return true;
	}

	public void SDKManagerLongHomeKey()
	{
		if (Pvr_UnitySDKSensor.Instance == null)
		{
			return;
		}
		if (isHasController)
		{
			if (Controller.UPvr_GetControllerState(0) == ControllerState.Connected || Controller.UPvr_GetControllerState(1) == ControllerState.Connected)
			{
				Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(0, 1);
			}
			else
			{
				Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
			}
		}
		else
		{
			Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
		}
	}

	private void setLongHomeKey()
	{
		if (sdk.HmdOnlyrot)
		{
			if (Pvr_UnitySDKSensor.Instance != null)
			{
				PLOG.I(Pvr_UnitySDKSensor.Instance.ResetUnitySDKSensor() ? "Long Home Key to Reset Sensor Success!" : "Long Home Key to Reset Sensor Failed!");
			}
			return;
		}
		if (trackingmode == 4 || trackingmode == 5 || trackingmode == 6)
		{
			Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
		}
		else
		{
			if (trackingmode == 2 || trackingmode == 3)
			{
				if (isHasController && (Controller.UPvr_GetControllerState(0) == ControllerState.Connected || Controller.UPvr_GetControllerState(1) == ControllerState.Connected))
				{
					Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(0, 1);
				}
				else
				{
					Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
				}
			}
			if (trackingmode == 0 || trackingmode == 1)
			{
				Pvr_UnitySDKSensor.Instance.ResetUnitySDKSensor();
			}
		}
		if (longPressHomeKeyAction != null)
		{
			longPressHomeKeyAction();
		}
	}

	public void verifyAPPCallback(string code)
	{
		UnityEngine.Debug.Log("PvrLog verifyAPPCallback" + code);
		AppCheckResult = Convert.ToInt32(code);
		if (Pvr_UnitySDKManager.EntitlementCheckResultEvent != null)
		{
			Pvr_UnitySDKManager.EntitlementCheckResultEvent(AppCheckResult);
		}
	}

	public void IpdRefreshCallBack(string ipd)
	{
		UnityEngine.Debug.Log("PvrLog IpdRefreshCallBack");
		Pvr_UnitySDKEye[] eyes = Pvr_UnitySDKEyeManager.Instance.Eyes;
		for (int i = 0; i < eyes.Length; i++)
		{
			eyes[i].RefreshCameraPosition(Convert.ToSingle(ipd));
		}
	}

	private void Awake()
	{
		UnityEngine.Debug.Log("DISFT Unity Version:" + Application.unityVersion);
		UnityEngine.Debug.Log("DISFT Customize NeckOffset:" + neckOffset);
		UnityEngine.Debug.Log("DISFT MSAA :" + Pvr_UnitySDKProjectSetting.GetProjectConfig().rtAntiAlising);
		if (GraphicsSettings.renderPipelineAsset != null)
		{
			UnityEngine.Debug.Log("DISFT LWRP = Enable");
		}
		UnityEngine.Debug.Log("DISFT Content Proctect :" + Pvr_UnitySDKProjectSetting.GetProjectConfig().usecontentprotect);
		int res = 0;
		LoadIsMirroringValue();
		if (!ismirroring)
		{
			Render.UPvr_GetIntConfig(18, ref res);
			if (res == 1)
			{
				UnityEngine.Debug.Log("DISFT ScreenOrientation.Portrait = Enable");
				Screen.orientation = ScreenOrientation.Portrait;
			}
		}
		else
		{
			Render.UPvr_GetIntConfig(19, ref res);
			Screen.orientation = ((res == 0) ? ScreenOrientation.Portrait : ScreenOrientation.LandscapeLeft);
		}
		new AndroidJavaClass("com.psmart.vrlib.VrActivity");
		new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		Pvr_ControllerManager pvr_ControllerManager = UnityEngine.Object.FindObjectOfType<Pvr_ControllerManager>();
		isHasController = pvr_ControllerManager != null;
		PLOG.getConfigTraceLevel();
		Render.UPvr_GetIntConfig(5, ref trackingmode);
		Application.targetFrameRate = 61;
		int res2 = 0;
		Render.UPvr_GetIntConfig(3, ref res2);
		if (res2 == 0)
		{
			SDK.HmdOnlyrot = true;
		}
		int res3 = -1;
		Render.UPvr_GetIntConfig(9, ref res3);
		float res4 = 0f;
		Render.UPvr_GetFloatConfig(6, ref res4);
		Application.targetFrameRate = ((res3 > 0) ? res3 : ((int)res4));
		if (!Pvr_UnitySDKProjectSetting.GetProjectConfig().usedefaultfps)
		{
			if ((float)Pvr_UnitySDKProjectSetting.GetProjectConfig().customfps <= res4)
			{
				Application.targetFrameRate = Pvr_UnitySDKProjectSetting.GetProjectConfig().customfps;
			}
			else
			{
				Application.targetFrameRate = (int)res4;
			}
		}
		UnityEngine.Debug.Log("DISFT Customize FPS :" + Application.targetFrameRate);
		if (!UseCustomNeckPara)
		{
			float res5 = 0f;
			float res6 = 0f;
			float res7 = 0f;
			int configsenum = 4;
			int configsenum2 = 5;
			Render.UPvr_GetFloatConfig(3, ref res5);
			Render.UPvr_GetFloatConfig(configsenum, ref res6);
			Render.UPvr_GetFloatConfig(configsenum2, ref res7);
			if (res5 != 0f || res6 != 0f || res7 != 0f)
			{
				neckOffset = new Vector3(res5, res6, res7);
			}
		}
		Render.UPvr_GetIntConfig(16, ref iPhoneHMDModeEnabled);
		Pvr_ControllerManager.ControllerStatusChangeEvent += CheckControllerStateForG2;
		InitUI();
		RefreshTextByLanguage();
	}

	private IEnumerator Start()
	{
		if (SDKManagerInit())
		{
			PLOG.I("SDK Init success.");
		}
		else
		{
			PLOG.E("SDK Init Failed.");
			Application.Quit();
		}
		if (Pvr_UnitySDKRender.Instance != null)
		{
			Pvr_UnitySDKRender.Instance.ReInit();
		}
		SDKManagerInitFPS();
		if (Pvr_UnitySDKPlatformSetting.StartTimeEntitlementCheck)
		{
			if (PlatformSettings.UPvr_IsCurrentDeviceValid() != Pvr_UnitySDKPlatformSetting.simulationType.Valid)
			{
				UnityEngine.Debug.Log("DISFT Entitlement Check Simulation DO NOT PASS");
				string appID = Pvr_UnitySDKPlatformSetting.Instance.appID;
				UnityEngine.Debug.Log("DISFT Start-time Entitlement Check Enable");
				PLOG.I("DISFT Start-time Entitlement Check APPID :" + appID);
				PlatformSettings.UPvr_AppEntitlementCheckExtra(appID);
			}
			else
			{
				UnityEngine.Debug.Log("DISFT Entitlement Check Simulation PASS");
			}
		}
		yield return StartCoroutine(InitRenderThreadRoutine());
	}

	private IEnumerator InitRenderThreadRoutine()
	{
		PLOG.I("InitRenderThreadRoutine begin");
		int i = 0;
		while (i < 2)
		{
			yield return null;
			int num = i + 1;
			i = num;
		}
		UnityEngine.Debug.Log("InitRenderThreadRoutine after a wait");
		if (Pvr_UnitySDKRender.Instance != null)
		{
			Pvr_UnitySDKRender.Instance.IssueRenderThread();
		}
		else
		{
			UnityEngine.Debug.Log("InitRenderThreadRoutine pvr_UnitySDKRender == null");
		}
		UnityEngine.Debug.Log("InitRenderThreadRoutine end");
	}

	private void Update()
	{
		if (isHasController && iPhoneHMDModeEnabled == 1 && Controller.UPvr_GetControllerPower(0) == 0 && Pvr_ControllerManager.controllerlink.controller0Connected && Pvr_ControllerManager.controllerlink.Controller0.Rotation.eulerAngles != Vector3.zero)
		{
			if (!lowControllerpowerstate)
			{
				StartCoroutine(ToastManager(6, state: true, 0f));
				StartCoroutine(ToastManager(6, state: false, 3f));
				lowControllerpowerstate = true;
			}
			controllerpowershowtime += Time.deltaTime;
			if (controllerpowershowtime >= 3600f)
			{
				lowControllerpowerstate = false;
				controllerpowershowtime = 0f;
			}
		}
		if (Input.touchCount == 1 && Input.touches[0].phase == TouchPhase.Began)
		{
			newPicovrTriggered = true;
		}
		if (Input.GetKeyDown(KeyCode.JoystickButton0))
		{
			newPicovrTriggered = true;
		}
		if (Pvr_UnitySDKSensor.Instance != null)
		{
			Pvr_UnitySDKSensor.Instance.SensorUpdate();
		}
		picovrTriggered = newPicovrTriggered;
		newPicovrTriggered = false;
	}

	private void OnDestroy()
	{
		if (sdk == this)
		{
			sdk = null;
		}
		RenderTexture.active = null;
		Resources.UnloadUnusedAssets();
		GC.Collect();
		Pvr_ControllerManager.ControllerStatusChangeEvent -= CheckControllerStateForG2;
	}

	private void OnEnable()
	{
		if (sdk == null)
		{
			sdk = this;
		}
		else if (sdk != this)
		{
			sdk = this;
		}
	}

	private void OnDisable()
	{
		StopAllCoroutines();
	}

	private void OnPause()
	{
		Pvr_UnitySDKAPI.System.UPvr_StopHomeKeyReceiver();
		LeaveVRMode();
		if (Pvr_UnitySDKSensor.Instance != null)
		{
			Pvr_UnitySDKSensor.Instance.StopUnitySDKSensor();
		}
	}

	private void OnApplicationPause(bool pause)
	{
		bool flag = pause;
		UnityEngine.Debug.Log("OnApplicationPause-------------------------" + (flag ? "true" : "false"));
		if (Pvr_UnitySDKAPI.System.UPvr_IsPicoActivity() && !Pvr_UnitySDKRender.Instance.isShellMode)
		{
			bool flag2 = Pvr_UnitySDKAPI.System.UPvr_GetMainActivityPauseStatus();
			UnityEngine.Debug.Log("OnApplicationPause-------------------------Activity Pause State:" + flag2);
			pause = flag2;
		}
		if (flag == pause)
		{
			if (pause)
			{
				onResume = false;
				OnPause();
			}
			else
			{
				onResume = true;
				GL.InvalidateState();
				StartCoroutine(OnResume());
			}
		}
		else if (pause)
		{
			UnityEngine.Debug.Log("OnApplicationPause-------------------------Activity pause Unity resume");
			GL.InvalidateState();
			StartCoroutine(OnResume());
			onResume = false;
			OnPause();
		}
		else
		{
			UnityEngine.Debug.Log("OnApplicationPause-------------------------Activity resume Unity pause");
			OnPause();
			onResume = true;
			GL.InvalidateState();
			StartCoroutine(OnResume());
		}
	}

	public void EnterVRMode()
	{
		Pvr_UnitySDKPluginEvent.Issue(RenderEventType.Resume);
		isEnterVRMode = true;
		if (eventEnterVRMode != null)
		{
			eventEnterVRMode();
		}
	}

	public void LeaveVRMode()
	{
		Pvr_UnitySDKPluginEvent.Issue(RenderEventType.Pause);
		isEnterVRMode = false;
	}

	public void SixDofForceQuit()
	{
		Application.Quit();
	}

	private void InitUI()
	{
		if (iPhoneHMDModeEnabled == 1)
		{
			Transform transform = UnityEngine.Object.Instantiate(Resources.Load("Prefabs/flamingo2Tips") as GameObject, base.transform.Find("Head"), worldPositionStays: false).transform;
			calltoast = transform.Find("Call").gameObject;
			msgtoast = transform.Find("Msg").gameObject;
			lowhmdBatterytoast = transform.Find("LowHmdBattery").gameObject;
			lowphoneBatterytoast = transform.Find("LowPhoneBattery").gameObject;
			LowPhoneHealthtoast = transform.Find("LowPhoneHealth").gameObject;
			LowcontrollerBatterytoast = transform.Find("LowControllerBattery").gameObject;
		}
	}

	private void RefreshTextByLanguage()
	{
		if (msgtoast != null)
		{
			msgtoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("msgtoast0");
			msgtoast.transform.Find("string").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("msgtoast1");
			calltoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("calltoast0");
			calltoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("calltoast1");
			lowhmdBatterytoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("lowhmdBatterytoast");
			lowphoneBatterytoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("lowphoneBatterytoast");
			LowPhoneHealthtoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("LowPhoneHealthtoast");
			LowcontrollerBatterytoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("LowcontrollerBatterytoast");
		}
	}

	private void LoadIsMirroringValue()
	{
		AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		AndroidJavaObject androidJavaObject = @static.Call<AndroidJavaObject>("getPackageManager", Array.Empty<object>());
		string text = @static.Call<string>("getPackageName", Array.Empty<object>());
		AndroidJavaObject androidJavaObject2 = androidJavaObject.Call<AndroidJavaObject>("getApplicationInfo", new object[2] { text, 128 }).Get<AndroidJavaObject>("metaData");
		ismirroring = Convert.ToBoolean(androidJavaObject2.Call<int>("getInt", new object[2] { "bypass_presentation", 0 }));
	}

	private IEnumerator OnResume()
	{
		int ability6dof = 0;
		Render.UPvr_GetIntConfig(3, ref ability6dof);
		RefreshTextByLanguage();
		if (Pvr_UnitySDKSensor.Instance != null)
		{
			Pvr_UnitySDKSensor.Instance.StartUnitySDKSensor();
			int res = -1;
			Render.UPvr_GetIntConfig(8, ref res);
			if (res != 1)
			{
				int res2 = -1;
				Render.UPvr_GetIntConfig(11, ref res2);
				if (res2 != 8)
				{
					Pvr_UnitySDKSensor.Instance.ResetUnitySDKSensor();
				}
			}
		}
		if (Pvr_UnitySDKAPI.System.UPvr_IsPicoActivity())
		{
			PLOG.I("onresume set monoPresentation success ?-------------" + Pvr_UnitySDKAPI.System.UPvr_SetMonoPresentation());
			PLOG.I("onresume presentation existed ?-------------" + Pvr_UnitySDKAPI.System.UPvr_IsPresentationExisted());
		}
		for (int j = 0; j < Pvr_UnitySDKEyeManager.Instance.Eyes.Length; j++)
		{
			Pvr_UnitySDKEyeManager.Instance.Eyes[j].RefreshCameraPosition(Pvr_UnitySDKAPI.System.UPvr_GetIPD());
		}
		int waitNum = 15;
		Render.UPvr_GetIntConfig(20, ref waitNum);
		int resetNum = 10;
		Render.UPvr_GetIntConfig(21, ref resetNum);
		for (int i = 0; i < waitNum; i++)
		{
			if (i == resetNum && ResetTrackerOnLoad && ability6dof == 1)
			{
				UnityEngine.Debug.Log("Reset Tracker OnLoad");
				Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
			}
			yield return null;
		}
		EnterVRMode();
		Pvr_UnitySDKAPI.System.UPvr_StartHomeKeyReceiver(base.gameObject.name);
		Pvr_UnitySDKEye.setLevel = false;
		if (longPressHomeKeyAction != null)
		{
			longPressHomeKeyAction();
		}
		if (Render.UPvr_GetIntSysProc("pvrsist.foveation.level", ref SystemDebugFFRLevel))
		{
			Render.SetFoveatedRenderingLevel((EFoveationLevel)SystemDebugFFRLevel);
			UnityEngine.Debug.Log("DISFT OnResume Get System Debug ffr level is : " + SystemDebugFFRLevel);
		}
		else
		{
			UnityEngine.Debug.Log("DISFT OnResume Get System Debug ffr level Error,ffr level is : " + SystemDebugFFRLevel);
		}
		if (SystemDebugFFRLevel == -1)
		{
			Render.UPvr_GetIntConfig(22, ref SystemFFRLevel);
			if (SystemFFRLevel != -1)
			{
				Render.SetFoveatedRenderingLevel((EFoveationLevel)SystemFFRLevel);
				UnityEngine.Debug.Log("DISFT OnResume Get System ffr level is : " + SystemFFRLevel);
			}
		}
	}
}
public class QuitGame : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
public class Pvr_UnityEyeMask : MonoBehaviour
{
	private class EyeMaskData
	{
		public Eye eyeSide;

		public Camera camera;

		public CommandBuffer cmdBuf;
	}

	private Shader eyeMaskShader;

	private Material eyeMaskMaterial;

	private Mesh eyeMaskMeshLeft;

	private Mesh eyeMaskMeshRight;

	private Mesh eyeMaskMeshBoth;

	private float zDir = -1f;

	private Color eyeMaskColor = Color.black;

	private List<EyeMaskData> cameraDataList = new List<EyeMaskData>();

	private void Awake()
	{
		UnityEngine.Debug.Log("DISFT EyeMask = Enable");
		if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGLES3 || SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGLES2)
		{
			zDir = -1f;
		}
		else if (SystemInfo.usesReversedZBuffer)
		{
			zDir = 1f;
		}
		else
		{
			zDir = 0f;
		}
	}

	private void OnEnable()
	{
		if (eyeMaskShader == null)
		{
			eyeMaskShader = Shader.Find("Pvr_UnitySDK/Pvr_EyeMask");
		}
		if (eyeMaskMaterial == null && eyeMaskShader != null)
		{
			eyeMaskMaterial = new Material(eyeMaskShader);
			eyeMaskMaterial.SetColor("_Color", eyeMaskColor);
		}
		if (eyeMaskMaterial == null)
		{
			base.enabled = false;
			UnityEngine.Debug.LogWarning("EyeMask materil is null or EyeMask shader not found!");
		}
		else
		{
			PrepareCameras();
			Camera.onPreRender = (Camera.CameraCallback)Delegate.Combine(Camera.onPreRender, new Camera.CameraCallback(OnCustomPreRender));
			CreateCommandBuffer();
		}
	}

	private void OnDisable()
	{
		Camera.onPreRender = (Camera.CameraCallback)Delegate.Remove(Camera.onPreRender, new Camera.CameraCallback(OnCustomPreRender));
		foreach (EyeMaskData cameraData in cameraDataList)
		{
			if (cameraData.camera != null && cameraData.cmdBuf != null)
			{
				RemoveCameraCommandBuffer(cameraData);
			}
		}
		CleanEyeMask();
	}

	private void CreateCommandBuffer()
	{
		if (VerifyCommadBuffer())
		{
			return;
		}
		if (eyeMaskMeshLeft == null || eyeMaskMeshRight == null)
		{
			eyeMaskMeshLeft = GetStencilMesh(Eye.LeftEye);
			eyeMaskMeshRight = GetStencilMesh(Eye.RightEye);
			if (eyeMaskMeshLeft == null || eyeMaskMeshRight == null)
			{
				UnityEngine.Debug.LogWarning("Stencil Mesh is not exist, disable EyeMask.");
				base.enabled = false;
				return;
			}
		}
		foreach (EyeMaskData cameraData in cameraDataList)
		{
			if (cameraData.eyeSide == Eye.LeftEye)
			{
				CommandBuffer commandBuffer = new CommandBuffer();
				commandBuffer.name = "EyeMaskLeft";
				commandBuffer.DrawMesh(eyeMaskMeshLeft, Matrix4x4.identity, eyeMaskMaterial, 0, 0);
				cameraData.cmdBuf = commandBuffer;
			}
			else if (cameraData.eyeSide == Eye.RightEye)
			{
				CommandBuffer commandBuffer2 = new CommandBuffer();
				commandBuffer2.name = "EyeMaskRight";
				commandBuffer2.DrawMesh(eyeMaskMeshRight, Matrix4x4.identity, eyeMaskMaterial, 0, 0);
				cameraData.cmdBuf = commandBuffer2;
			}
			else if (cameraData.eyeSide == Eye.BothEye)
			{
				if (eyeMaskMeshBoth == null)
				{
					eyeMaskMeshBoth = GetStencilMeshBoth(eyeMaskMeshLeft, eyeMaskMeshRight);
					float value = Mathf.Max(Mathf.Abs(eyeMaskMeshLeft.bounds.max.x), Mathf.Abs(eyeMaskMeshRight.bounds.min.x));
					eyeMaskMaterial.SetFloat("_MeshOffsetX", value);
				}
				CommandBuffer commandBuffer3 = new CommandBuffer();
				commandBuffer3.name = "EyeMaskBoth";
				commandBuffer3.DrawMesh(eyeMaskMeshBoth, Matrix4x4.identity, eyeMaskMaterial, 0, 1);
				cameraData.cmdBuf = commandBuffer3;
			}
		}
	}

	private void OnCustomPreRender(Camera cam)
	{
		if (!VerifyCommadBuffer())
		{
			UnityEngine.Debug.LogWarning("Verify CommandBuffer failed!");
			return;
		}
		foreach (EyeMaskData cameraData in cameraDataList)
		{
			if (!(cameraData.camera != cam))
			{
				RemoveCameraCommandBuffer(cameraData);
				AddCameraCommandBuffer(cameraData);
			}
		}
	}

	private Mesh GetStencilMesh(Eye eyeSide)
	{
		int vertexCount = 0;
		int triangleCount = 0;
		IntPtr vertexDataPtr = IntPtr.Zero;
		IntPtr indexDataPtr = IntPtr.Zero;
		Render.UPvr_GetStencilMesh((int)eyeSide, ref vertexCount, ref triangleCount, ref vertexDataPtr, ref indexDataPtr);
		if (vertexCount <= 0 || triangleCount <= 0 || vertexDataPtr == IntPtr.Zero || indexDataPtr == IntPtr.Zero)
		{
			return null;
		}
		Vector3[] array = new Vector3[vertexCount];
		int[] array2 = new int[triangleCount * 3];
		float[] array3 = new float[vertexCount * 3];
		int[] array4 = new int[triangleCount * 3];
		Marshal.Copy(vertexDataPtr, array3, 0, vertexCount * 3);
		Marshal.Copy(indexDataPtr, array4, 0, triangleCount * 3);
		for (int i = 0; i < vertexCount; i++)
		{
			array[i] = new Vector3(array3[3 * i], array3[3 * i + 1], zDir);
		}
		for (int j = 0; j < triangleCount; j++)
		{
			array2[3 * j] = array4[3 * j + 2];
			array2[3 * j + 1] = array4[3 * j + 1];
			array2[3 * j + 2] = array4[3 * j];
		}
		Mesh mesh = new Mesh();
		mesh.name = "EyeMaskMesh";
		mesh.vertices = array;
		mesh.SetIndices(array2, MeshTopology.Triangles, 0);
		return mesh;
	}

	private Mesh GetStencilMeshBoth(Mesh leftMesh, Mesh rightMesh)
	{
		float num = Mathf.Max(Mathf.Abs(leftMesh.bounds.max.x), Mathf.Abs(rightMesh.bounds.min.x));
		Mesh mesh = new Mesh();
		mesh.name = "EyeMaskBoth";
		CombineInstance combineInstance = default(CombineInstance);
		combineInstance.mesh = leftMesh;
		Matrix4x4 identity = Matrix4x4.identity;
		identity.SetTRS(Vector3.left * num, Quaternion.identity, Vector3.one);
		combineInstance.transform = identity;
		CombineInstance combineInstance2 = default(CombineInstance);
		combineInstance2.mesh = rightMesh;
		Matrix4x4 identity2 = Matrix4x4.identity;
		identity2.SetTRS(Vector3.right * num, Quaternion.identity, Vector3.one);
		combineInstance2.transform = identity2;
		CombineInstance[] combine = new CombineInstance[2] { combineInstance, combineInstance2 };
		mesh.CombineMeshes(combine);
		return mesh;
	}

	private bool VerifyCommadBuffer()
	{
		if (cameraDataList == null || cameraDataList.Count <= 0)
		{
			return false;
		}
		foreach (EyeMaskData cameraData in cameraDataList)
		{
			if (cameraData == null || cameraData.cmdBuf == null)
			{
				return false;
			}
		}
		return true;
	}

	private void PrepareCameras()
	{
		cameraDataList.Clear();
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass)
		{
			if (Pvr_UnitySDKEyeManager.Instance.BothEyeCamera == null)
			{
				UnityEngine.Debug.LogWarning("BothEye Camera is null!");
				return;
			}
			EyeMaskData eyeMaskData = new EyeMaskData();
			eyeMaskData.eyeSide = Eye.BothEye;
			eyeMaskData.camera = Pvr_UnitySDKEyeManager.Instance.BothEyeCamera;
			cameraDataList.Add(eyeMaskData);
		}
		else if (Pvr_UnitySDKEyeManager.Instance.LeftEyeCamera == null || Pvr_UnitySDKEyeManager.Instance.RightEyeCamera == null)
		{
			UnityEngine.Debug.LogWarning("LeftEye or RightEye Camera is null!");
		}
		else
		{
			EyeMaskData eyeMaskData2 = new EyeMaskData();
			eyeMaskData2.eyeSide = Eye.LeftEye;
			eyeMaskData2.camera = Pvr_UnitySDKEyeManager.Instance.LeftEyeCamera;
			eyeMaskData2.cmdBuf = null;
			cameraDataList.Add(eyeMaskData2);
			EyeMaskData eyeMaskData3 = new EyeMaskData();
			eyeMaskData3.eyeSide = Eye.RightEye;
			eyeMaskData3.camera = Pvr_UnitySDKEyeManager.Instance.RightEyeCamera;
			eyeMaskData3.cmdBuf = null;
			cameraDataList.Add(eyeMaskData3);
		}
	}

	private void AddCameraCommandBuffer(EyeMaskData data)
	{
		data.camera.AddCommandBuffer(CameraEvent.BeforeForwardOpaque, data.cmdBuf);
	}

	private void RemoveCameraCommandBuffer(EyeMaskData data)
	{
		data.camera.RemoveCommandBuffer(CameraEvent.BeforeForwardOpaque, data.cmdBuf);
	}

	private void CleanEyeMask()
	{
		cameraDataList.Clear();
		eyeMaskMeshLeft = null;
		eyeMaskMeshRight = null;
		eyeMaskMeshBoth = null;
		eyeMaskShader = null;
		eyeMaskMaterial = null;
	}
}
[RequireComponent(typeof(Camera))]
public class Pvr_UnitySDKEye : MonoBehaviour
{
	public static List<Pvr_UnitySDKEye> Instances = new List<Pvr_UnitySDKEye>();

	public Eye eyeSide;

	private int eyeCameraOriginCullingMask;

	private CameraClearFlags eyeCameraOriginClearFlag;

	private Color eyeCameraOriginBackgroundColor;

	private int lastBoundaryState;

	private Matrix4x4 realProj = Matrix4x4.identity;

	private const int bufferSize = 3;

	private int IDIndex;

	private RenderEventType eventType;

	private int previousId;

	public static bool setLevel = false;

	private Material mat_Vignette;

	public Camera eyecamera { get; private set; }

	private void Awake()
	{
		Instances.Add(this);
		eyecamera = GetComponent<Camera>();
	}

	private void Start()
	{
		Setup(eyeSide);
		SetupUpdate();
		if (eyecamera != null)
		{
			eyeCameraOriginCullingMask = eyecamera.cullingMask;
			eyeCameraOriginClearFlag = eyecamera.clearFlags;
			eyeCameraOriginBackgroundColor = eyecamera.backgroundColor;
		}
	}

	private void Update()
	{
		if (!(eyecamera != null) || !eyecamera.enabled)
		{
			return;
		}
		int num = BoundarySystem.UPvr_GetSeeThroughState();
		if (num == lastBoundaryState)
		{
			return;
		}
		switch (num)
		{
		case 2:
			eyeCameraOriginCullingMask = eyecamera.cullingMask;
			eyeCameraOriginClearFlag = eyecamera.clearFlags;
			eyeCameraOriginBackgroundColor = eyecamera.backgroundColor;
			eyecamera.cullingMask = 0;
			eyecamera.clearFlags = CameraClearFlags.Color;
			eyecamera.backgroundColor = Color.black;
			break;
		case 1:
			if (lastBoundaryState == 2)
			{
				if (eyecamera.cullingMask == 0)
				{
					eyecamera.cullingMask = eyeCameraOriginCullingMask;
				}
				if (eyecamera.clearFlags == CameraClearFlags.Color)
				{
					eyecamera.clearFlags = eyeCameraOriginClearFlag;
				}
				if (eyecamera.backgroundColor == Color.black)
				{
					eyecamera.backgroundColor = eyeCameraOriginBackgroundColor;
				}
			}
			break;
		default:
			if (lastBoundaryState == 2 || lastBoundaryState == 1)
			{
				if (eyecamera.cullingMask == 0)
				{
					eyecamera.cullingMask = eyeCameraOriginCullingMask;
				}
				if (eyecamera.clearFlags == CameraClearFlags.Color)
				{
					eyecamera.clearFlags = eyeCameraOriginClearFlag;
				}
				if (eyecamera.backgroundColor == Color.black)
				{
					eyecamera.backgroundColor = eyeCameraOriginBackgroundColor;
				}
			}
			break;
		}
		lastBoundaryState = num;
	}

	private void OnEnable()
	{
		if (GraphicsSettings.renderPipelineAsset != null)
		{
			RenderPipeline.beginCameraRendering += MyPreRender;
		}
	}

	private void OnDisable()
	{
		if (GraphicsSettings.renderPipelineAsset != null)
		{
			RenderPipeline.beginCameraRendering -= MyPreRender;
		}
	}

	private void OnDestroy()
	{
		Instances.Remove(this);
	}

	public void MyPreRender(Camera camera)
	{
		if (!(camera.gameObject != base.gameObject))
		{
			OnPreRender();
		}
	}

	public void MyPreRender(ScriptableRenderContext context, Camera camera)
	{
		if (!(camera.gameObject != base.gameObject))
		{
			OnPreRender();
		}
	}

	public void MyPostRender(ScriptableRenderContext context, Camera camera)
	{
		if (!(camera.gameObject != base.gameObject))
		{
			OnPostRender();
		}
	}

	private void OnPreRender()
	{
		if (!eyecamera.enabled)
		{
			return;
		}
		if (Pvr_UnitySDKRender.Instance.StereoRendering != null)
		{
			if (Pvr_UnitySDKRender.Instance.isSwitchSDK)
			{
				return;
			}
			Pvr_UnitySDKRender.Instance.StereoRendering.OnSDKPreRender();
		}
		SetFFRParameter();
		Pvr_UnitySDKPluginEvent.Issue(RenderEventType.BeginEye);
	}

	private void OnPostRender()
	{
		if (!eyecamera.enabled)
		{
			return;
		}
		Pvr_UnitySDKAPI.System.UPvr_UnityEventData(Pvr_UnitySDKAPI.System.UPvr_GetEyeBufferData(Pvr_UnitySDKRender.Instance.eyeTextureIds[IDIndex]));
		Pvr_UnitySDKPluginEvent.Issue(eventType);
		if (Pvr_UnitySDKRender.Instance.StereoRendering != null)
		{
			if (Pvr_UnitySDKRender.Instance.isSwitchSDK)
			{
				return;
			}
			Pvr_UnitySDKRender.Instance.StereoRendering.OnSDKPostRender();
		}
		Pvr_UnitySDKPluginEvent.Issue(RenderEventType.EndEye);
	}

	public void EyeRender()
	{
		SetupUpdate();
		if (Pvr_UnitySDKRender.Instance.eyeTextures[IDIndex] != null)
		{
			Pvr_UnitySDKRender.Instance.eyeTextures[IDIndex].DiscardContents();
			eyecamera.targetTexture = Pvr_UnitySDKRender.Instance.eyeTextures[IDIndex];
		}
	}

	private void Setup(Eye eyeSide)
	{
		eyecamera = GetComponent<Camera>();
		switch (eyeSide)
		{
		case Eye.LeftEye:
		case Eye.RightEye:
			base.transform.localPosition = Pvr_UnitySDKManager.SDK.EyeOffset(eyeSide);
			break;
		case Eye.BothEye:
			base.transform.localPosition = Vector3.zero;
			break;
		}
		eyecamera.aspect = Pvr_UnitySDKManager.SDK.EyesAspect;
		eyecamera.rect = new Rect(0f, 0f, 1f, 1f);
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.MultiPass)
		{
			eventType = ((eyeSide == Eye.LeftEye) ? RenderEventType.LeftEyeEndFrame : RenderEventType.RightEyeEndFrame);
		}
		else
		{
			eventType = RenderEventType.BothEyeEndFrame;
		}
	}

	private void SetupUpdate()
	{
		if (eyeSide == Eye.LeftEye || eyeSide == Eye.RightEye)
		{
			eyecamera.enabled = !Pvr_UnitySDKManager.SDK.Monoscopic && Pvr_UnitySDKRender.Instance.StereoRenderPath != StereoRenderingPathPico.SinglePass;
		}
		else if (eyeSide == Eye.BothEye)
		{
			eyecamera.enabled = Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass;
		}
		eyecamera.fieldOfView = Pvr_UnitySDKRender.Instance.EyeVFoV;
		eyecamera.aspect = Pvr_UnitySDKManager.SDK.EyesAspect;
		if (eyeSide == Eye.LeftEye || eyeSide == Eye.RightEye)
		{
			IDIndex = Pvr_UnitySDKRender.Instance.currEyeTextureIdx + (int)eyeSide * 3;
		}
		else if (eyeSide == Eye.BothEye)
		{
			IDIndex = Pvr_UnitySDKRender.Instance.currEyeTextureIdx;
			Pvr_UnitySDKRender.Instance.isSwitchSDK = Pvr_UnitySDKRender.Instance.lastEyeTextureIdx == Pvr_UnitySDKRender.Instance.currEyeTextureIdx;
			Pvr_UnitySDKRender.Instance.lastEyeTextureIdx = Pvr_UnitySDKRender.Instance.currEyeTextureIdx;
		}
	}

	public void RefreshCameraPosition(float ipd)
	{
		Pvr_UnitySDKManager.SDK.leftEyeOffset = new Vector3((0f - ipd) / 2f, 0f, 0f);
		Pvr_UnitySDKManager.SDK.rightEyeOffset = new Vector3(ipd / 2f, 0f, 0f);
		if (eyeSide == Eye.LeftEye || eyeSide == Eye.RightEye)
		{
			base.transform.localPosition = Pvr_UnitySDKManager.SDK.EyeOffset(eyeSide);
		}
		else if (eyeSide == Eye.BothEye)
		{
			eyecamera.stereoSeparation = ipd;
		}
	}

	private void DrawVignetteLine()
	{
		if (null == mat_Vignette)
		{
			mat_Vignette = new Material(Shader.Find("Diffuse"));
			if (null == mat_Vignette)
			{
				return;
			}
		}
		GL.PushMatrix();
		mat_Vignette.SetPass(0);
		GL.LoadOrtho();
		vignette();
		GL.PopMatrix();
	}

	private void vignette()
	{
		GL.Begin(7);
		GL.Color(Color.black);
		GL.Vertex3(0f, 1f, 0f);
		GL.Vertex3(1f, 1f, 0f);
		GL.Vertex3(1f, 0.995f, 0f);
		GL.Vertex3(0f, 0.995f, 0f);
		GL.Vertex3(0f, 0f, 0f);
		GL.Vertex3(0f, 0.005f, 0f);
		GL.Vertex3(1f, 0.005f, 0f);
		GL.Vertex3(1f, 0f, 0f);
		GL.Vertex(new Vector3(0f, 1f, 0f));
		GL.Vertex(new Vector3(0.005f, 1f, 0f));
		GL.Vertex(new Vector3(0.005f, 0f, 0f));
		GL.Vertex(new Vector3(0f, 0f, 0f));
		GL.Vertex(new Vector3(0.995f, 1f, 0f));
		GL.Vertex(new Vector3(1f, 1f, 0f));
		GL.Vertex(new Vector3(1f, 0f, 0f));
		GL.Vertex(new Vector3(0.995f, 0f, 0f));
		GL.End();
	}

	private void SetFFRParameter()
	{
		Vector3 vector = Vector3.zero;
		if (Pvr_UnitySDKManager.SDK.isEnterVRMode && Pvr_UnitySDKEyeManager.supportEyeTracking && Pvr_UnitySDKEyeManager.Instance.EyeTracking)
		{
			vector = Pvr_UnitySDKAPI.System.UPvr_getEyeTrackingPos();
		}
		int textureId = Pvr_UnitySDKRender.Instance.eyeTextureIds[IDIndex];
		Render.UPvr_SetFoveationResource(textureId, previousId, vector.x, vector.y);
		previousId = textureId;
	}
}
public class Pvr_UnitySDKEyeManager : MonoBehaviour
{
	private static Pvr_UnitySDKEyeManager instance;

	private Pvr_UnitySDKEye[] eyes;

	[HideInInspector]
	public Camera LeftEyeCamera;

	[HideInInspector]
	public Camera RightEyeCamera;

	[HideInInspector]
	public Camera MonoEyeCamera;

	[HideInInspector]
	public Camera BothEyeCamera;

	private int MonoEyeTextureID;

	private readonly int WaitSplashScreenFrames = 3;

	private int frameNum;

	[SerializeField]
	[HideInInspector]
	private bool foveatedRendering;

	[SerializeField]
	[HideInInspector]
	private EFoveationLevel foveationLevel;

	private int eyeTextureId;

	private RenderEventType eventType = RenderEventType.LeftEyeEndFrame;

	private Pvr_UnitySDKEyeOverlay compositeLayer;

	private int overlayLayerDepth = 1;

	private int underlayLayerDepth;

	private bool isHeadLocked;

	private int layerFlags;

	[HideInInspector]
	public bool EyeTracking;

	[HideInInspector]
	public Vector3 eyePoint;

	private EyeTrackingData eyePoseData;

	[HideInInspector]
	public static bool supportEyeTracking;

	[Tooltip("If true, specific color gradient when switching scenes.")]
	public bool screenFade;

	[Tooltip("Define the duration of screen fade.")]
	public float fadeTime = 5f;

	[Tooltip("Define the color of screen fade.")]
	public Color fadeColor = new Color(0f, 0f, 0f, 1f);

	public int renderQueue = 5000;

	private MeshRenderer fadeMeshRenderer;

	private MeshFilter fadeMeshFilter;

	private Material fadeMaterial;

	private float elapsedTime;

	private bool isFading;

	private float currentAlpha;

	private float nowFadeAlpha;

	public static Pvr_UnitySDKEyeManager Instance
	{
		get
		{
			if (instance == null)
			{
				PLOG.E("Pvr_UnitySDKEyeManager instance is not init yet...");
			}
			return instance;
		}
	}

	public Pvr_UnitySDKEye[] Eyes
	{
		get
		{
			if (eyes == null)
			{
				eyes = Pvr_UnitySDKEye.Instances.ToArray();
			}
			return eyes;
		}
	}

	[HideInInspector]
	public bool FoveatedRendering
	{
		get
		{
			return foveatedRendering;
		}
		set
		{
			if (value == foveatedRendering)
			{
				return;
			}
			foveatedRendering = value;
			if (Application.isPlaying)
			{
				Render.UPvr_EnableFoveation(enable: true);
				if (!foveatedRendering)
				{
					Render.SetFoveatedRenderingLevel((EFoveationLevel)(-1));
				}
			}
		}
	}

	[HideInInspector]
	public EFoveationLevel FoveationLevel
	{
		get
		{
			return foveationLevel;
		}
		set
		{
			if (value != foveationLevel)
			{
				foveationLevel = value;
			}
		}
	}

	private void SetCameraEnableEditor()
	{
		MonoEyeCamera.enabled = !Pvr_UnitySDKManager.SDK.VRModeEnabled || Pvr_UnitySDKManager.SDK.Monoscopic;
		for (int i = 0; i < Eyes.Length; i++)
		{
			if (Eyes[i].eyeSide == Eye.LeftEye || Eyes[i].eyeSide == Eye.RightEye)
			{
				Eyes[i].eyecamera.enabled = Pvr_UnitySDKManager.SDK.VRModeEnabled;
			}
			else if (Eyes[i].eyeSide == Eye.BothEye)
			{
				Eyes[i].eyecamera.enabled = false;
			}
		}
	}

	private void SetCamerasEnableByStereoRendering()
	{
		MonoEyeCamera.enabled = Pvr_UnitySDKManager.SDK.Monoscopic && Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.MultiPass;
	}

	private void SetupMonoCamera()
	{
		base.transform.localPosition = Vector3.zero;
		MonoEyeCamera.aspect = Pvr_UnitySDKManager.SDK.EyesAspect;
		MonoEyeCamera.rect = new Rect(0f, 0f, 1f, 1f);
	}

	private void SetupUpdate()
	{
		MonoEyeCamera.fieldOfView = Pvr_UnitySDKRender.Instance.EyeVFoV;
		MonoEyeCamera.aspect = Pvr_UnitySDKManager.SDK.EyesAspect;
		MonoEyeTextureID = Pvr_UnitySDKRender.Instance.currEyeTextureIdx;
	}

	private void MonoEyeRender()
	{
		SetupUpdate();
		if (Pvr_UnitySDKRender.Instance.eyeTextures[MonoEyeTextureID] != null)
		{
			Pvr_UnitySDKRender.Instance.eyeTextures[MonoEyeTextureID].DiscardContents();
			MonoEyeCamera.targetTexture = Pvr_UnitySDKRender.Instance.eyeTextures[MonoEyeTextureID];
		}
	}

	private void Awake()
	{
		if (MonoEyeCamera == null)
		{
			MonoEyeCamera = GetComponent<Camera>();
		}
		if (LeftEyeCamera == null)
		{
			LeftEyeCamera = base.gameObject.transform.Find("LeftEye").GetComponent<Camera>();
		}
		if (RightEyeCamera == null)
		{
			RightEyeCamera = base.gameObject.transform.Find("RightEye").GetComponent<Camera>();
		}
		if (BothEyeCamera == null)
		{
			BothEyeCamera = base.gameObject.transform.Find("BothEye").GetComponent<Camera>();
		}
		if (BothEyeCamera != null)
		{
			BothEyeCamera.transform.GetComponent<Pvr_UnitySDKEye>().eyeSide = Eye.BothEye;
		}
		CreateFadeMesh();
		SetCurrentAlpha(0f);
		Render.UPvr_EnableFoveation(enable: true);
		if (foveatedRendering)
		{
			Render.SetFoveatedRenderingLevel(foveationLevel);
		}
		else
		{
			Render.SetFoveatedRenderingLevel((EFoveationLevel)(-1));
		}
		Pvr_UnitySDKManager.eventEnterVRMode = (Func<bool>)Delegate.Combine(Pvr_UnitySDKManager.eventEnterVRMode, new Func<bool>(SetEyeTrackingMode));
	}

	private void OnEnable()
	{
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			instance = this;
		}
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass)
		{
			Pvr_UnitySDKRender.Instance.StereoRendering.InitEye(BothEyeCamera);
		}
		foreach (Pvr_UnitySDKEyeOverlay instance in Pvr_UnitySDKEyeOverlay.Instances)
		{
			instance.RefreshCamera();
			if (instance.overlayType == Pvr_UnitySDKEyeOverlay.OverlayType.Overlay)
			{
				if (instance.overlayShape == Pvr_UnitySDKEyeOverlay.OverlayShape.Cylinder)
				{
					UnityEngine.Debug.Log("DISFT Cylinder OverLay = Enable");
				}
				if (instance.overlayShape == Pvr_UnitySDKEyeOverlay.OverlayShape.Equirect)
				{
					UnityEngine.Debug.Log("DISFT 360 OverLay= Enable");
				}
				if (instance.overlayShape == Pvr_UnitySDKEyeOverlay.OverlayShape.Quad)
				{
					UnityEngine.Debug.Log("DISFT 2D OverLay= Enable");
				}
			}
			if (instance.overlayType == Pvr_UnitySDKEyeOverlay.OverlayType.Underlay)
			{
				UnityEngine.Debug.Log("DISFT UnderLay= Enable");
			}
		}
		GfxDeviceAdvanceFrameGLES();
		StartCoroutine("EndOfFrame");
		if (screenFade)
		{
			StartCoroutine(ScreenFade(1f, 0f));
		}
	}

	private void Start()
	{
		SetCamerasEnableByStereoRendering();
		SetupMonoCamera();
	}

	private void Update()
	{
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass)
		{
			for (int i = 0; i < Eyes.Length; i++)
			{
				if (Eyes[i].isActiveAndEnabled && Eyes[i].eyeSide == Eye.BothEye)
				{
					Eyes[i].EyeRender();
				}
			}
		}
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath != 0)
		{
			return;
		}
		if (!Pvr_UnitySDKManager.SDK.Monoscopic)
		{
			for (int j = 0; j < Eyes.Length; j++)
			{
				if (Eyes[j].isActiveAndEnabled && Eyes[j].eyeSide != Eye.BothEye)
				{
					Eyes[j].EyeRender();
				}
			}
		}
		else
		{
			MonoEyeRender();
		}
	}

	private void OnPause()
	{
		Pvr_UnitySDKManager.eventEnterVRMode = (Func<bool>)Delegate.Remove(Pvr_UnitySDKManager.eventEnterVRMode, new Func<bool>(SetEyeTrackingMode));
	}

	private void OnDisable()
	{
		StopAllCoroutines();
	}

	private void OnDestroy()
	{
		DestoryFadeMesh();
	}

	private void OnPostRender()
	{
		long data = Pvr_UnitySDKAPI.System.UPvr_GetEyeBufferData(Pvr_UnitySDKRender.Instance.eyeTextureIds[Pvr_UnitySDKRender.Instance.currEyeTextureIdx]);
		Pvr_UnitySDKAPI.System.UPvr_UnityEventData(data);
		Pvr_UnitySDKPluginEvent.Issue(RenderEventType.LeftEyeEndFrame);
		Pvr_UnitySDKAPI.System.UPvr_UnityEventData(data);
		Pvr_UnitySDKPluginEvent.Issue(RenderEventType.RightEyeEndFrame);
	}

	private IEnumerator EndOfFrame()
	{
		while (true)
		{
			yield return new WaitForEndOfFrame();
			if (!Pvr_UnitySDKManager.SDK.isEnterVRMode)
			{
				GL.Clear(clearDepth: false, clearColor: true, Color.black);
			}
			if (Pvr_UnitySDKRender.Instance.isFirstStartup && frameNum == WaitSplashScreenFrames)
			{
				Pvr_UnitySDKAPI.System.UPvr_RemovePlatformLogo();
				if (Pvr_UnitySDKManager.SDK.ResetTrackerOnLoad)
				{
					UnityEngine.Debug.Log("Reset Tracker OnLoad");
					Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
				}
				Pvr_UnitySDKAPI.System.UPvr_StartVRModel();
				Pvr_UnitySDKRender.Instance.isFirstStartup = false;
			}
			else if (Pvr_UnitySDKRender.Instance.isFirstStartup && frameNum < WaitSplashScreenFrames)
			{
				PLOG.I("frameNum:" + frameNum);
				frameNum++;
			}
			if (GraphicsSettings.renderPipelineAsset != null)
			{
				for (int i = 0; i < Eyes.Length; i++)
				{
					if (!Eyes[i].isActiveAndEnabled || !Eyes[i].eyecamera.enabled)
					{
						continue;
					}
					switch (Eyes[i].eyeSide)
					{
					case Eye.LeftEye:
						eyeTextureId = Pvr_UnitySDKRender.Instance.eyeTextureIds[Pvr_UnitySDKRender.Instance.currEyeTextureIdx];
						eventType = RenderEventType.LeftEyeEndFrame;
						break;
					case Eye.RightEye:
						if (!Pvr_UnitySDKManager.SDK.Monoscopic)
						{
							eyeTextureId = Pvr_UnitySDKRender.Instance.eyeTextureIds[Pvr_UnitySDKRender.Instance.currEyeTextureIdx + 3];
						}
						else
						{
							eyeTextureId = Pvr_UnitySDKRender.Instance.eyeTextureIds[Pvr_UnitySDKRender.Instance.currEyeTextureIdx];
						}
						eventType = RenderEventType.RightEyeEndFrame;
						break;
					case Eye.BothEye:
						eyeTextureId = Pvr_UnitySDKRender.Instance.eyeTextureIds[Pvr_UnitySDKRender.Instance.currEyeTextureIdx];
						eventType = RenderEventType.BothEyeEndFrame;
						break;
					}
					Pvr_UnitySDKAPI.System.UPvr_UnityEventData(Pvr_UnitySDKAPI.System.UPvr_GetEyeBufferData(eyeTextureId));
					Pvr_UnitySDKPluginEvent.Issue(eventType);
					Pvr_UnitySDKPluginEvent.Issue(RenderEventType.EndEye);
				}
			}
			int num = BoundarySystem.UPvr_GetSeeThroughState();
			if (Pvr_UnitySDKEyeOverlay.Instances.Count > 0 && num != 2)
			{
				overlayLayerDepth = 1;
				underlayLayerDepth = 0;
				Pvr_UnitySDKEyeOverlay.Instances.Sort();
				for (int j = 0; j < Pvr_UnitySDKEyeOverlay.Instances.Count; j++)
				{
					compositeLayer = Pvr_UnitySDKEyeOverlay.Instances[j];
					if (!compositeLayer.isActiveAndEnabled || (compositeLayer.layerTextures[0] == null && compositeLayer.layerTextures[1] == null && !compositeLayer.isExternalAndroidSurface) || (compositeLayer.layerTransform != null && !compositeLayer.layerTransform.gameObject.activeSelf))
					{
						continue;
					}
					layerFlags = 0;
					if (compositeLayer.overlayShape == Pvr_UnitySDKEyeOverlay.OverlayShape.Quad || compositeLayer.overlayShape == Pvr_UnitySDKEyeOverlay.OverlayShape.Cylinder)
					{
						if (compositeLayer.overlayType == Pvr_UnitySDKEyeOverlay.OverlayType.Overlay)
						{
							isHeadLocked = false;
							if (compositeLayer.layerTransform != null && compositeLayer.layerTransform.parent == base.transform)
							{
								isHeadLocked = true;
							}
							if (compositeLayer.isExternalAndroidSurface)
							{
								layerFlags |= 1;
								CreateExternalSurface(compositeLayer, overlayLayerDepth);
							}
							Render.UPvr_SetOverlayModelViewMatrix((int)compositeLayer.overlayType, (int)compositeLayer.overlayShape, compositeLayer.layerTextureIds[0], 0, overlayLayerDepth, isHeadLocked, layerFlags, compositeLayer.MVMatrixs[0], compositeLayer.ModelScales[0], compositeLayer.ModelRotations[0], compositeLayer.ModelTranslations[0], compositeLayer.CameraRotations[0], compositeLayer.CameraTranslations[0], compositeLayer.GetLayerColorScale(), compositeLayer.GetLayerColorOffset());
							Render.UPvr_SetOverlayModelViewMatrix((int)compositeLayer.overlayType, (int)compositeLayer.overlayShape, compositeLayer.layerTextureIds[1], 1, overlayLayerDepth, isHeadLocked, layerFlags, compositeLayer.MVMatrixs[1], compositeLayer.ModelScales[1], compositeLayer.ModelRotations[1], compositeLayer.ModelTranslations[1], compositeLayer.CameraRotations[1], compositeLayer.CameraTranslations[1], compositeLayer.GetLayerColorScale(), compositeLayer.GetLayerColorOffset());
							overlayLayerDepth++;
						}
						else if (compositeLayer.overlayType == Pvr_UnitySDKEyeOverlay.OverlayType.Underlay)
						{
							if (compositeLayer.isExternalAndroidSurface)
							{
								layerFlags |= 1;
								CreateExternalSurface(compositeLayer, underlayLayerDepth);
							}
							Render.UPvr_SetOverlayModelViewMatrix((int)compositeLayer.overlayType, (int)compositeLayer.overlayShape, compositeLayer.layerTextureIds[0], 0, underlayLayerDepth, isHeadLocked: false, layerFlags, compositeLayer.MVMatrixs[0], compositeLayer.ModelScales[0], compositeLayer.ModelRotations[0], compositeLayer.ModelTranslations[0], compositeLayer.CameraRotations[0], compositeLayer.CameraTranslations[0], compositeLayer.GetLayerColorScale(), compositeLayer.GetLayerColorOffset());
							Render.UPvr_SetOverlayModelViewMatrix((int)compositeLayer.overlayType, (int)compositeLayer.overlayShape, compositeLayer.layerTextureIds[1], 1, underlayLayerDepth, isHeadLocked: false, layerFlags, compositeLayer.MVMatrixs[1], compositeLayer.ModelScales[1], compositeLayer.ModelRotations[1], compositeLayer.ModelTranslations[1], compositeLayer.CameraRotations[1], compositeLayer.CameraTranslations[1], compositeLayer.GetLayerColorScale(), compositeLayer.GetLayerColorOffset());
							underlayLayerDepth++;
						}
					}
					else if (compositeLayer.overlayShape == Pvr_UnitySDKEyeOverlay.OverlayShape.Equirect)
					{
						if (compositeLayer.isExternalAndroidSurface)
						{
							layerFlags |= 1;
							CreateExternalSurface(compositeLayer, 0);
						}
						Render.UPvr_SetupLayerData(0, 0, compositeLayer.layerTextureIds[0], (int)compositeLayer.overlayShape, layerFlags, compositeLayer.GetLayerColorScale(), compositeLayer.GetLayerColorOffset());
						Render.UPvr_SetupLayerData(0, 1, compositeLayer.layerTextureIds[1], (int)compositeLayer.overlayShape, layerFlags, compositeLayer.GetLayerColorScale(), compositeLayer.GetLayerColorOffset());
					}
				}
			}
			Pvr_UnitySDKAPI.System.UPvr_UnityEventData(Pvr_UnitySDKAPI.System.UPvr_GetEyeBufferData(0));
			Pvr_UnitySDKPluginEvent.Issue(RenderEventType.TimeWarp);
			Pvr_UnitySDKRender.Instance.currEyeTextureIdx = Pvr_UnitySDKRender.Instance.nextEyeTextureIdx;
			Pvr_UnitySDKRender.Instance.nextEyeTextureIdx = (Pvr_UnitySDKRender.Instance.nextEyeTextureIdx + 1) % 3;
		}
	}

	private void CreateExternalSurface(Pvr_UnitySDKEyeOverlay overlayInstance, int layerDepth)
	{
		if (overlayInstance.externalAndroidSurfaceObject == IntPtr.Zero)
		{
			overlayInstance.externalAndroidSurfaceObject = Render.UPvr_CreateLayerAndroidSurface((int)overlayInstance.overlayType, layerDepth);
			UnityEngine.Debug.LogFormat("CreateExternalSurface: Overlay Type:{0}, LayerDepth:{1}, SurfaceObject:{2}", overlayInstance.overlayType, layerDepth, overlayInstance.externalAndroidSurfaceObject);
			if (overlayInstance.externalAndroidSurfaceObject != IntPtr.Zero && overlayInstance.externalAndroidSurfaceObjectCreated != null)
			{
				overlayInstance.externalAndroidSurfaceObjectCreated();
			}
		}
	}

	public bool SetEyeTrackingMode()
	{
		supportEyeTracking = (Pvr_UnitySDKAPI.System.UPvr_GetTrackingMode() & 4) != 0;
		bool result = false;
		if (EyeTracking && supportEyeTracking)
		{
			result = Pvr_UnitySDKAPI.System.UPvr_setTrackingMode(6);
		}
		UnityEngine.Debug.Log("SetEyeTrackingMode EyeTracking " + EyeTracking + " supportEyeTracking " + supportEyeTracking + " result " + result);
		return result;
	}

	public Vector3 GetEyeTrackingPos()
	{
		if (!Instance.EyeTracking)
		{
			return Vector3.zero;
		}
		bool flag = Pvr_UnitySDKAPI.System.UPvr_getEyeTrackingData(ref eyePoseData);
		if (!flag)
		{
			PLOG.E("UPvr_getEyeTrackingData failed " + flag);
			return Vector3.zero;
		}
		EyeDeviceInfo deviceInfo = GetDeviceInfo();
		Vector3 zero = Vector3.zero;
		zero.x = 0.5f * (deviceInfo.targetFrustumLeft.right - deviceInfo.targetFrustumLeft.left);
		zero.y = 0.5f * (deviceInfo.targetFrustumLeft.top - deviceInfo.targetFrustumLeft.bottom);
		zero.z = deviceInfo.targetFrustumLeft.near;
		Vector3 foveatedGazeDirection = eyePoseData.foveatedGazeDirection;
		float num = Vector3.Dot(foveatedGazeDirection, Vector3.forward);
		if (num > float.Epsilon)
		{
			eyePoint = foveatedGazeDirection * (zero.z / num);
			eyePoint.x /= zero.x;
			eyePoint.y /= zero.y;
		}
		return eyePoint;
	}

	private EyeDeviceInfo GetDeviceInfo()
	{
		float num = Mathf.Tan(Pvr_UnitySDKRender.Instance.EyeVFoV / 2f * ((float)Math.PI / 180f));
		float num2 = Mathf.Tan(Pvr_UnitySDKRender.Instance.EyeHFoV / 2f * ((float)Math.PI / 180f));
		EyeDeviceInfo result = default(EyeDeviceInfo);
		result.targetFrustumLeft.left = 0f - LeftEyeCamera.nearClipPlane * num2;
		result.targetFrustumLeft.right = LeftEyeCamera.nearClipPlane * num2;
		result.targetFrustumLeft.top = LeftEyeCamera.nearClipPlane * num;
		result.targetFrustumLeft.bottom = 0f - LeftEyeCamera.nearClipPlane * num;
		result.targetFrustumLeft.near = LeftEyeCamera.nearClipPlane;
		result.targetFrustumLeft.far = LeftEyeCamera.farClipPlane;
		result.targetFrustumRight.left = 0f - RightEyeCamera.nearClipPlane * num2;
		result.targetFrustumRight.right = RightEyeCamera.nearClipPlane * num2;
		result.targetFrustumRight.top = RightEyeCamera.nearClipPlane * num;
		result.targetFrustumRight.bottom = 0f - RightEyeCamera.nearClipPlane * num;
		result.targetFrustumRight.near = RightEyeCamera.nearClipPlane;
		result.targetFrustumRight.far = RightEyeCamera.farClipPlane;
		return result;
	}

	private void CreateFadeMesh()
	{
		fadeMaterial = new Material(Shader.Find("Pvr_UnitySDK/Fade"));
		fadeMeshFilter = base.gameObject.AddComponent<MeshFilter>();
		fadeMeshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		fadeMeshFilter.mesh = mesh;
		Vector3[] array = new Vector3[4];
		float num = 2f;
		float num2 = 2f;
		float z = 1f;
		array[0] = new Vector3(0f - num, 0f - num2, z);
		array[1] = new Vector3(num, 0f - num2, z);
		array[2] = new Vector3(0f - num, num2, z);
		array[3] = new Vector3(num, num2, z);
		mesh.vertices = array;
		mesh.triangles = new int[6] { 0, 2, 1, 2, 3, 1 };
		mesh.normals = new Vector3[4]
		{
			-Vector3.forward,
			-Vector3.forward,
			-Vector3.forward,
			-Vector3.forward
		};
		mesh.uv = new Vector2[4]
		{
			new Vector2(0f, 0f),
			new Vector2(1f, 0f),
			new Vector2(0f, 1f),
			new Vector2(1f, 1f)
		};
	}

	private void DestoryFadeMesh()
	{
		if (fadeMeshRenderer != null)
		{
			UnityEngine.Object.Destroy(fadeMeshRenderer);
		}
		if (fadeMaterial != null)
		{
			UnityEngine.Object.Destroy(fadeMaterial);
		}
		if (fadeMeshFilter != null)
		{
			UnityEngine.Object.Destroy(fadeMeshFilter);
		}
	}

	public void SetCurrentAlpha(float alpha)
	{
		currentAlpha = alpha;
		SetMaterialAlpha();
	}

	private IEnumerator ScreenFade(float startAlpha, float endAlpha)
	{
		float elapsedTime = 0f;
		while (elapsedTime < fadeTime)
		{
			elapsedTime += Time.deltaTime;
			nowFadeAlpha = Mathf.Lerp(startAlpha, endAlpha, Mathf.Clamp01(elapsedTime / fadeTime));
			SetMaterialAlpha();
			yield return new WaitForEndOfFrame();
		}
	}

	private void SetMaterialAlpha()
	{
		Color color = fadeColor;
		color.a = Mathf.Max(currentAlpha, nowFadeAlpha);
		isFading = color.a > 0f;
		if (fadeMaterial != null)
		{
			fadeMaterial.color = color;
			fadeMaterial.renderQueue = renderQueue;
			fadeMeshRenderer.material = fadeMaterial;
			fadeMeshRenderer.enabled = isFading;
		}
	}

	public bool GfxDeviceAdvanceFrameGLES()
	{
		return false;
	}
}
public class Pvr_UnitySDKEyeOverlay : MonoBehaviour, IComparable<Pvr_UnitySDKEyeOverlay>
{
	public delegate void ExternalAndroidSurfaceObjectCreated();

	public enum OverlayShape
	{
		Quad,
		Cylinder,
		Equirect
	}

	public enum OverlayType
	{
		Overlay,
		Underlay
	}

	public enum OverlayTexFilterMode
	{
		NotCare,
		Nearest,
		Linear,
		Nearest_Mipmap_Nearest,
		Linear_Mipmap_Nearest,
		Nearest_Mipmap_Linear,
		Linear_Mipmap_Linear
	}

	public static List<Pvr_UnitySDKEyeOverlay> Instances = new List<Pvr_UnitySDKEyeOverlay>();

	public int layerIndex;

	public OverlayType overlayType;

	public OverlayShape overlayShape;

	public Transform layerTransform;

	public Texture[] layerTextures = new Texture[2];

	public int[] layerTextureIds = new int[2];

	public Matrix4x4[] MVMatrixs = new Matrix4x4[2];

	public Vector3[] ModelScales = new Vector3[2];

	public Quaternion[] ModelRotations = new Quaternion[2];

	public Vector3[] ModelTranslations = new Vector3[2];

	public Quaternion[] CameraRotations = new Quaternion[2];

	public Vector3[] CameraTranslations = new Vector3[2];

	public Camera[] layerEyeCamera = new Camera[2];

	public bool overrideColorScaleAndOffset;

	public Vector4 colorScale = Vector4.one;

	public Vector4 colorOffset = Vector4.zero;

	private Vector4 overlayLayerColorScaleDefault = Vector4.one;

	private Vector4 overlayLayerColorOffsetDefault = Vector4.zero;

	public bool isExternalAndroidSurface;

	public IntPtr externalAndroidSurfaceObject = IntPtr.Zero;

	public ExternalAndroidSurfaceObjectCreated externalAndroidSurfaceObjectCreated;

	public int CompareTo(Pvr_UnitySDKEyeOverlay other)
	{
		return layerIndex.CompareTo(other.layerIndex);
	}

	private void Awake()
	{
		Instances.Add(this);
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass)
		{
			layerEyeCamera[0] = Pvr_UnitySDKEyeManager.Instance.BothEyeCamera;
			layerEyeCamera[1] = Pvr_UnitySDKEyeManager.Instance.BothEyeCamera;
		}
		else if (Pvr_UnitySDKManager.SDK.Monoscopic)
		{
			layerEyeCamera[0] = Pvr_UnitySDKEyeManager.Instance.MonoEyeCamera;
			layerEyeCamera[1] = Pvr_UnitySDKEyeManager.Instance.MonoEyeCamera;
		}
		else
		{
			layerEyeCamera[0] = Pvr_UnitySDKEyeManager.Instance.LeftEyeCamera;
			layerEyeCamera[1] = Pvr_UnitySDKEyeManager.Instance.RightEyeCamera;
		}
		layerTransform = GetComponent<Transform>();
		if (layerTransform != null)
		{
			MeshRenderer component = layerTransform.GetComponent<MeshRenderer>();
			if (component != null)
			{
				component.enabled = false;
			}
		}
		InitializeBuffer();
	}

	private void LateUpdate()
	{
		UpdateCoords();
	}

	private void OnDestroy()
	{
		Instances.Remove(this);
	}

	public void RefreshCamera()
	{
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass)
		{
			layerEyeCamera[0] = Pvr_UnitySDKEyeManager.Instance.BothEyeCamera;
			layerEyeCamera[1] = Pvr_UnitySDKEyeManager.Instance.BothEyeCamera;
		}
		else if (Pvr_UnitySDKManager.SDK.Monoscopic)
		{
			layerEyeCamera[0] = Pvr_UnitySDKEyeManager.Instance.MonoEyeCamera;
			layerEyeCamera[1] = Pvr_UnitySDKEyeManager.Instance.MonoEyeCamera;
		}
		else
		{
			layerEyeCamera[0] = Pvr_UnitySDKEyeManager.Instance.LeftEyeCamera;
			layerEyeCamera[1] = Pvr_UnitySDKEyeManager.Instance.RightEyeCamera;
		}
	}

	private void InitializeBuffer()
	{
		OverlayShape overlayShape = this.overlayShape;
		if ((uint)overlayShape > 2u)
		{
			return;
		}
		for (int i = 0; i < layerTextureIds.Length; i++)
		{
			if (layerTextures[i] != null)
			{
				layerTextureIds[i] = layerTextures[i].GetNativeTexturePtr().ToInt32();
			}
			else
			{
				UnityEngine.Debug.LogWarning($"{(Eye)i} Texture is null!");
			}
		}
	}

	private void UpdateCoords()
	{
		if (layerTransform == null || !layerTransform.gameObject.activeSelf || layerEyeCamera[0] == null || layerEyeCamera[1] == null)
		{
			return;
		}
		for (int i = 0; i < MVMatrixs.Length; i++)
		{
			if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass)
			{
				Matrix4x4[] stereoWorldToCameraMat = Pvr_UnitySDKSinglePass.GetStereoWorldToCameraMat();
				MVMatrixs[i] = stereoWorldToCameraMat[i] * layerTransform.localToWorldMatrix;
			}
			else
			{
				MVMatrixs[i] = layerEyeCamera[i].worldToCameraMatrix * layerTransform.localToWorldMatrix;
			}
			ModelScales[i] = layerTransform.localScale;
			ModelRotations[i] = layerTransform.rotation;
			ModelTranslations[i] = layerTransform.position;
			CameraRotations[i] = layerEyeCamera[i].transform.rotation;
			CameraTranslations[i] = layerEyeCamera[i].transform.position;
		}
	}

	public void SetTexture(Texture texture)
	{
		for (int i = 0; i < layerTextures.Length; i++)
		{
			layerTextures[i] = texture;
		}
		InitializeBuffer();
	}

	public void SetLayerColorScaleAndOffset(Vector4 scale, Vector4 offset)
	{
		colorScale = scale;
		colorOffset = offset;
	}

	public Vector4 GetLayerColorScale()
	{
		if (!overrideColorScaleAndOffset)
		{
			return overlayLayerColorScaleDefault;
		}
		return colorScale;
	}

	public Vector4 GetLayerColorOffset()
	{
		if (!overrideColorScaleAndOffset)
		{
			return overlayLayerColorOffsetDefault;
		}
		return colorOffset;
	}
}
public class Pvr_UnitySDKRender
{
	private static Pvr_UnitySDKRender instance;

	public AndroidJavaObject activity;

	public static AndroidJavaClass javaVrActivityClass;

	public static AndroidJavaClass javaSysActivityClass;

	public static AndroidJavaClass javaserviceClass;

	public static AndroidJavaClass javaVrActivityLongReceiver;

	public static AndroidJavaClass javaVrActivityClientClass;

	private bool canConnecttoActivity;

	private bool isInitrenderThread = true;

	private string model;

	private Vector2 prefinger1 = new Vector2(0f, 0f);

	private Vector2 prefinger2 = new Vector2(0f, 0f);

	public int eyeTextureCount = 6;

	public RenderTexture[] eyeTextures;

	public int[] eyeTextureIds;

	public int currEyeTextureIdx;

	public int nextEyeTextureIdx = 1;

	public int lastEyeTextureIdx;

	public bool isSwitchSDK;

	public int RenderviewNumber;

	public bool isFirstStartup = true;

	public bool isShellMode;

	private StereoRenderingPathPico stereoRenderPath;

	private float rtScaleFactor = 1f;

	private float eyeVFov = 90f;

	private float eyeHFov = 90f;

	public static Pvr_UnitySDKRender Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new Pvr_UnitySDKRender();
			}
			return instance;
		}
		set
		{
			instance = value;
		}
	}

	public StereoRenderingPathPico StereoRenderPath => stereoRenderPath;

	public SDKStereoRendering StereoRendering { get; private set; }

	public float RtScaleFactor
	{
		get
		{
			return rtScaleFactor;
		}
		set
		{
			if (value != rtScaleFactor)
			{
				rtScaleFactor = value;
				ReCreateEyeBuffer();
			}
		}
	}

	public float EyeVFoV
	{
		get
		{
			return eyeVFov;
		}
		set
		{
			if (value != eyeVFov)
			{
				eyeVFov = value;
			}
		}
	}

	public float EyeHFoV
	{
		get
		{
			return eyeHFov;
		}
		set
		{
			if (value != eyeHFov)
			{
				eyeHFov = value;
			}
		}
	}

	public Pvr_UnitySDKRender()
	{
		if (!canConnecttoActivity)
		{
			ConnectToAndriod();
			PLOG.I("PvrLog Init Render Ability Success!");
			isInitrenderThread = false;
		}
		Init();
	}

	public void ConnectToAndriod()
	{
		try
		{
			UnityEngine.Debug.Log("PvrLog SDK Version :  " + Pvr_UnitySDKAPI.System.UPvr_GetSDKVersion().ToString() + "  Unity Script Version :" + Pvr_UnitySDKAPI.System.UPvr_GetUnitySDKVersion().ToString());
			AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			activity = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
			javaVrActivityClass = new AndroidJavaClass("com.psmart.vrlib.VrActivity");
			javaserviceClass = new AndroidJavaClass("com.picovr.picovrlib.hummingbirdclient.UnityClient");
			javaVrActivityLongReceiver = new AndroidJavaClass("com.psmart.vrlib.HomeKeyReceiver");
			javaSysActivityClass = new AndroidJavaClass("com.psmart.aosoperation.SysActivity");
			javaVrActivityClientClass = new AndroidJavaClass("com.psmart.vrlib.PvrClient");
			Pvr_UnitySDKAPI.System.Pvr_SetInitActivity(activity.GetRawObject(), javaVrActivityClass.GetRawClass());
			model = javaVrActivityClass.CallStatic<string>("Pvr_GetBuildModel", Array.Empty<object>());
			double[] result = new double[5];
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaVrActivityClass, "getDPIParameters", activity);
			int res = -1;
			Render.UPvr_GetIntConfig(4, ref res);
			string result2 = "";
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result2, javaserviceClass, "getSysproc", "persist.pvr.debug.appfps");
			if (result2 != "")
			{
				Pvr_UnitySDKManager.SDK.systemFPS = Convert.ToBoolean(Convert.ToInt16(result2));
			}
			if (res == 0)
			{
				Render.UPvr_ChangeScreenParameters(model, (int)result[0], (int)result[1], result[2], result[3], result[4]);
				Screen.sleepTimeout = -1;
			}
			if (Pvr_UnitySDKAPI.System.UPvr_IsPicoActivity())
			{
				UnityEngine.Debug.Log("ConnectToAndriod set monoPresentation success ?-------------" + Pvr_UnitySDKAPI.System.UPvr_SetMonoPresentation());
				UnityEngine.Debug.Log("ConnectToAndriod presentation existed ?-------------" + Pvr_UnitySDKAPI.System.UPvr_IsPresentationExisted());
			}
			isShellMode = GetIsShellMode();
			UnityEngine.Debug.Log("ConnectToAndriod isShellMode ?-------------" + isShellMode);
		}
		catch (AndroidJavaException ex)
		{
			PLOG.E("ConnectToAndriod--catch" + ex.Message);
		}
		canConnecttoActivity = true;
	}

	public void Init()
	{
		if (InitRenderAbility())
		{
			UnityEngine.Debug.Log("PvrLog Init Render Ability Success!");
			isInitrenderThread = false;
		}
		else
		{
			UnityEngine.Debug.Log("PvrLog Init Render Ability Failed!");
		}
	}

	private bool InitRenderAbility()
	{
		if (UpdateRenderParaFrame() && CreateEyeBuffer())
		{
			float num = Pvr_UnitySDKAPI.System.UPvr_GetIPD();
			Pvr_UnitySDKManager.SDK.leftEyeOffset = new Vector3((0f - num) / 2f, 0f, 0f);
			Pvr_UnitySDKManager.SDK.rightEyeOffset = new Vector3(num / 2f, 0f, 0f);
			return true;
		}
		return false;
	}

	private bool UpdateRenderParaFrame()
	{
		EyeVFoV = GetEyeVFOV();
		EyeHFoV = GetEyeHFOV();
		Pvr_UnitySDKManager.SDK.EyesAspect = EyeHFoV / EyeVFoV;
		return true;
	}

	private bool CreateEyeBuffer()
	{
		Vector2 eyeBufferResolution = GetEyeBufferResolution();
		if (isFirstStartup)
		{
			InitSinglePass();
			Pvr_UnitySDKAPI.System.UPvr_SetSinglePassDepthBufferWidthHeight((int)eyeBufferResolution.x, (int)eyeBufferResolution.y);
		}
		eyeTextures = new RenderTexture[eyeTextureCount];
		eyeTextureIds = new int[eyeTextureCount];
		for (int i = 0; i < eyeTextureCount; i++)
		{
			if (null == eyeTextures[i])
			{
				try
				{
					ConfigureEyeBuffer(i, eyeBufferResolution);
				}
				catch (Exception ex)
				{
					PLOG.E("ConfigureEyeBuffer ERROR " + ex.Message);
					throw;
				}
			}
			if (!eyeTextures[i].IsCreated())
			{
				eyeTextures[i].Create();
				eyeTextureIds[i] = eyeTextures[i].GetNativeTexturePtr().ToInt32();
			}
			eyeTextureIds[i] = eyeTextures[i].GetNativeTexturePtr().ToInt32();
		}
		return true;
	}

	private void InitSinglePass()
	{
		bool flag = true;
		if (GraphicsSettings.renderPipelineAsset != null)
		{
			flag = false;
			if (!BoundarySystem.UPvr_EnableLWRP(enable: true))
			{
				UnityEngine.Debug.Log("UPvr_EnableLWRP return false");
			}
			Vector2 eyeBufferResolution = GetEyeBufferResolution();
			if (!BoundarySystem.UPvr_SetViewportSize((int)eyeBufferResolution.x, (int)eyeBufferResolution.y))
			{
				UnityEngine.Debug.Log("UPvr_SetViewportSize return false");
			}
		}
		if (Pvr_UnitySDKProjectSetting.GetProjectConfig().usesinglepass)
		{
			bool flag2 = false;
			if (flag)
			{
				flag2 = Pvr_UnitySDKAPI.System.UPvr_EnableSinglePass(enable: true);
			}
			if (flag2)
			{
				StereoRendering = new Pvr_UnitySDKSinglePass();
				stereoRenderPath = StereoRenderingPathPico.SinglePass;
				eyeTextureCount = 3;
			}
			UnityEngine.Debug.Log("EnableSinglePass supportSinglePass " + flag + " result " + flag2);
		}
	}

	public float GetEyeVFOV()
	{
		float res = 102f;
		try
		{
			Render.UPvr_GetFloatConfig(1, ref res);
			if (res <= 0f)
			{
				res = 102f;
			}
		}
		catch (Exception ex)
		{
			PLOG.E("GetEyeVFOV ERROR! " + ex.Message);
			throw;
		}
		return res;
	}

	public float GetEyeHFOV()
	{
		float res = 102f;
		try
		{
			Render.UPvr_GetFloatConfig(2, ref res);
			if (res <= 0f)
			{
				res = 102f;
			}
		}
		catch (Exception ex)
		{
			PLOG.E("GetEyeHFOV ERROR! " + ex.Message);
			throw;
		}
		return res;
	}

	private void ConfigureEyeBuffer(int eyeTextureIndex, Vector2 resolution)
	{
		int width = (int)resolution.x;
		int height = (int)resolution.y;
		eyeTextures[eyeTextureIndex] = new RenderTexture(width, height, (int)Pvr_UnitySDKProjectSetting.GetProjectConfig().rtBitDepth, Pvr_UnitySDKProjectSetting.GetProjectConfig().rtFormat);
		if (StereoRenderPath == StereoRenderingPathPico.MultiPass)
		{
			eyeTextures[eyeTextureIndex].anisoLevel = 0;
			eyeTextures[eyeTextureIndex].antiAliasing = Mathf.Max(QualitySettings.antiAliasing, (int)Pvr_UnitySDKProjectSetting.GetProjectConfig().rtAntiAlising);
			UnityEngine.Debug.Log("MultiPass ConfigureEyeBuffer eyeTextureIndex " + eyeTextureIndex);
		}
		else if (StereoRenderPath == StereoRenderingPathPico.SinglePass)
		{
			eyeTextures[eyeTextureIndex].useMipMap = false;
			eyeTextures[eyeTextureIndex].wrapMode = TextureWrapMode.Clamp;
			eyeTextures[eyeTextureIndex].filterMode = FilterMode.Bilinear;
			eyeTextures[eyeTextureIndex].anisoLevel = 1;
			eyeTextures[eyeTextureIndex].dimension = TextureDimension.Tex2DArray;
			eyeTextures[eyeTextureIndex].volumeDepth = 2;
			UnityEngine.Debug.Log("SinglePass ConfigureEyeBuffer eyeTextureIndex " + eyeTextureIndex);
		}
		eyeTextures[eyeTextureIndex].Create();
		if (eyeTextures[eyeTextureIndex].IsCreated())
		{
			eyeTextureIds[eyeTextureIndex] = eyeTextures[eyeTextureIndex].GetNativeTexturePtr().ToInt32();
			UnityEngine.Debug.Log("eyeTextureIndex : " + eyeTextureIndex);
		}
	}

	public bool ReCreateEyeBuffer()
	{
		if (!Pvr_UnitySDKProjectSetting.GetProjectConfig().usedefaultRenderTexture)
		{
			for (int i = 0; i < eyeTextureCount; i++)
			{
				if (eyeTextures[i] != null)
				{
					eyeTextures[i].Release();
				}
			}
			Array.Clear(eyeTextures, 0, eyeTextures.Length);
			return CreateEyeBuffer();
		}
		return false;
	}

	public void ReInit()
	{
		if (canConnecttoActivity && isInitrenderThread)
		{
			Init();
		}
	}

	public void IssueRenderThread()
	{
		if (canConnecttoActivity && !isInitrenderThread)
		{
			switch (QualitySettings.activeColorSpace)
			{
			case ColorSpace.Gamma:
				Render.UPvr_SetColorspaceType(0);
				break;
			case ColorSpace.Linear:
				Render.UPvr_SetColorspaceType(1);
				break;
			}
			Pvr_UnitySDKPluginEvent.Issue(RenderEventType.InitRenderThread);
			isInitrenderThread = true;
			if (StereoRendering != null)
			{
				StereoRendering.OnSDKRenderInited();
			}
			UnityEngine.Debug.Log("PvrLog IssueRenderThread end");
		}
		else
		{
			PLOG.I("PvrLog IssueRenderThread  canConnecttoActivity = " + canConnecttoActivity);
		}
	}

	private void AutoAdpatForPico1s()
	{
		Vector2 position = Input.touches[0].position;
		Vector2 position2 = Input.touches[1].position;
		if (Vector2.Distance(prefinger1, position) > 2f && Vector2.Distance(prefinger2, position2) > 2f)
		{
			float midH = (Input.touches[0].position.x + Input.touches[1].position.x) / (float)Screen.width - 1f;
			float midV = (Input.touches[0].position.y + Input.touches[1].position.y) / (float)Screen.height - 1f;
			Render.UPvr_SetRatio(midH, midV);
		}
		prefinger1 = position;
		prefinger2 = position2;
	}

	public Vector2 GetEyeBufferResolution()
	{
		int res = 1024;
		int res2 = 1024;
		if (Pvr_UnitySDKProjectSetting.GetProjectConfig().usedefaultRenderTexture)
		{
			try
			{
				Render.UPvr_GetIntConfig(0, ref res);
				Render.UPvr_GetIntConfig(1, ref res2);
			}
			catch (Exception ex)
			{
				PLOG.E("GetEyeBufferResolution ERROR! " + ex.Message);
				throw;
			}
		}
		else
		{
			res = (int)(Pvr_UnitySDKProjectSetting.GetProjectConfig().customRTSize.x * RtScaleFactor);
			res2 = (int)(Pvr_UnitySDKProjectSetting.GetProjectConfig().customRTSize.y * RtScaleFactor);
		}
		Vector2 vector = new Vector2(res, res2);
		UnityEngine.Debug.Log(string.Concat("DISFT Customize RenderTexture:", vector, ", scaleFactor: ", RtScaleFactor));
		return vector;
	}

	public bool GetUsePredictedMatrix()
	{
		return true;
	}

	public bool GetIsShellMode()
	{
		if (activity == null)
		{
			return false;
		}
		using (AndroidJavaObject androidJavaObject = activity.Call<AndroidJavaObject>("getPackageManager", Array.Empty<object>()).Call<AndroidJavaObject>("getApplicationInfo", new object[2]
		{
			activity.Call<string>("getPackageName", Array.Empty<object>()),
			128
		}))
		{
			AndroidJavaObject androidJavaObject2 = androidJavaObject.Get<AndroidJavaObject>("metaData");
			if (androidJavaObject2 != null)
			{
				if (androidJavaObject2.Call<int>("getInt", new object[1] { "shell_mode" }) == 1)
				{
					return true;
				}
				return false;
			}
		}
		return false;
	}
}
public class Pvr_UnitySDKSinglePass : SDKStereoRendering
{
	private static Camera bothCamera;

	private Matrix4x4[] unity_StereoMatrixP = new Matrix4x4[2];

	private Matrix4x4[] unity_StereoMatrixInvP = new Matrix4x4[2];

	private static Matrix4x4[] unity_StereoWorldToCamera = new Matrix4x4[2];

	private Matrix4x4[] unity_StereoCameraToWorld = new Matrix4x4[2];

	private Matrix4x4[] unity_StereoMatrixVP = new Matrix4x4[2];

	private Vector3[] eyesOffset = new Vector3[2];

	private static Matrix4x4[] eyesOffsetMatrix = new Matrix4x4[2];

	private CommandBuffer commandBufferBeforeForwardOpaque;

	private CommandBuffer commandBufferBeforeSkybox;

	private CommandBuffer commandBufferAfterSkybox;

	public override void InitEye(Camera eye)
	{
		bothCamera = eye;
		bothCamera.stereoSeparation = 0.0625f;
		bothCamera.stereoConvergence = 0f;
		bothCamera.allowHDR = false;
		bothCamera.allowDynamicResolution = false;
		SetEyesPosition();
		SetEyeProjection();
		Pvr_UnitySDKSensor.EyeFovChanged = (Action)Delegate.Combine(Pvr_UnitySDKSensor.EyeFovChanged, new Action(SetEyeProjection));
		UnityEngine.Debug.Log("SinglePass Init success! CameraName = " + eye.transform.name + " eye.eyeSide " + eye.GetComponent<Pvr_UnitySDKEye>().eyeSide);
	}

	public override void OnSDKRenderInited()
	{
		OnSDKRenderInited_SinglePass();
	}

	public override void OnSDKPreRender()
	{
		SinglePassPreRender();
	}

	public override void OnSDKPostRender()
	{
		SwitchKeywordAndDeviceView(enable: false);
	}

	public void OnSDKRenderInited_SinglePass()
	{
		Shader.SetGlobalVectorArray("unity_StereoScaleOffset", new Vector4[2]
		{
			new Vector4(1f, 1f, 0f, 0f),
			new Vector4(1f, 1f, 0.5f, 0f)
		});
		SetAntiAliasing();
		UnityEngine.Debug.Log("OnSDKRenderInited_SinglePass");
	}

	private void SetAntiAliasing()
	{
		int num = Mathf.Max(QualitySettings.antiAliasing, (int)Pvr_UnitySDKProjectSetting.GetProjectConfig().rtAntiAlising);
		Pvr_UnitySDKAPI.System.UPvr_SetAntiAliasing(num);
		UnityEngine.Debug.Log("SetAntiAliasing  antiAliasing = " + num);
	}

	public void SetEyesPosition()
	{
		float res = 0.0625f;
		int configsenum = 0;
		if (Render.UPvr_GetFloatConfig(configsenum, ref res) != 0)
		{
			PLOG.E("Cannot get ipd");
			res = 0.0625f;
		}
		bothCamera.stereoSeparation = res;
		Vector3 vector = new Vector3((0f - res) / 2f, 0f, 0f);
		Vector3 vector2 = new Vector3(res / 2f, 0f, 0f);
		Vector3 vector3 = (vector + vector2) / 2f;
		bothCamera.transform.localPosition = vector3;
		bothCamera.transform.localRotation = Quaternion.identity;
		Vector3 vector4 = vector - vector3;
		Vector3 vector5 = vector2 - vector3;
		eyesOffset[0] = vector4;
		eyesOffset[1] = vector5;
		eyesOffsetMatrix[0] = Matrix4x4.TRS(vector4, Quaternion.identity, Vector3.one);
		eyesOffsetMatrix[1] = Matrix4x4.TRS(vector5, Quaternion.identity, Vector3.one);
	}

	public void SetEyeProjection()
	{
		Matrix4x4 projection = GetProjection(bothCamera.nearClipPlane, bothCamera.farClipPlane);
		Matrix4x4 projection2 = GetProjection(bothCamera.nearClipPlane, bothCamera.farClipPlane);
		SetStereoProjectionMatrix(projection, projection2);
	}

	private static Matrix4x4 GetProjection(float near, float far)
	{
		if (near < 0.01f)
		{
			near = 0.01f;
		}
		if (far < 0.02f)
		{
			far = 0.02f;
		}
		_ = Matrix4x4.identity;
		return MakeProjection(near, far);
	}

	public static Matrix4x4 MakeProjection(float n, float f)
	{
		Vector2 eyeBufferResolution = Pvr_UnitySDKRender.Instance.GetEyeBufferResolution();
		float num = Mathf.Tan(Pvr_UnitySDKRender.Instance.EyeVFoV / 2f * ((float)Math.PI / 180f));
		float num2 = 1f / num;
		Matrix4x4 zero = Matrix4x4.zero;
		zero[0, 0] = num2 / (eyeBufferResolution.x / eyeBufferResolution.y);
		zero[1, 1] = num2;
		zero[2, 2] = (0f - (f + n)) / (f - n);
		zero[2, 3] = -2f * f * n / (f - n);
		zero[3, 2] = -1f;
		return zero;
	}

	public void SetStereoProjectionMatrix(Matrix4x4 left, Matrix4x4 right)
	{
		unity_StereoMatrixP[0] = left;
		unity_StereoMatrixInvP[0] = left.inverse;
		unity_StereoMatrixP[1] = right;
		unity_StereoMatrixInvP[1] = right.inverse;
	}

	private void SwitchKeywordAndDeviceView(bool enable)
	{
		if (enable)
		{
			Shader.EnableKeyword("STEREO_MULTIVIEW_ON");
			Shader.EnableKeyword("UNITY_SINGLE_PASS_STEREO");
			XRSettings.showDeviceView = false;
		}
		else
		{
			XRSettings.showDeviceView = true;
			Shader.DisableKeyword("UNITY_SINGLE_PASS_STEREO");
			Shader.DisableKeyword("STEREO_MULTIVIEW_ON");
		}
	}

	public static Matrix4x4[] GetStereoWorldToCameraMat()
	{
		Matrix4x4 worldToCameraMatrix = bothCamera.worldToCameraMatrix;
		unity_StereoWorldToCamera[0] = eyesOffsetMatrix[0].inverse * worldToCameraMatrix;
		unity_StereoWorldToCamera[1] = eyesOffsetMatrix[1].inverse * worldToCameraMatrix;
		return unity_StereoWorldToCamera;
	}

	public void SinglePassPreRender()
	{
		SwitchKeywordAndDeviceView(enable: true);
		Shader.SetGlobalMatrixArray("unity_StereoCameraProjection", unity_StereoMatrixP);
		Shader.SetGlobalMatrixArray("unity_StereoCameraInvProjection", unity_StereoMatrixInvP);
		Shader.SetGlobalMatrixArray("unity_StereoMatrixP", unity_StereoMatrixP);
		Matrix4x4 worldToCameraMatrix = bothCamera.worldToCameraMatrix;
		Matrix4x4 cameraToWorldMatrix = bothCamera.cameraToWorldMatrix;
		unity_StereoCameraToWorld[0] = cameraToWorldMatrix * eyesOffsetMatrix[0];
		unity_StereoCameraToWorld[1] = cameraToWorldMatrix * eyesOffsetMatrix[1];
		Shader.SetGlobalMatrixArray("unity_StereoCameraToWorld", unity_StereoCameraToWorld);
		unity_StereoWorldToCamera[0] = eyesOffsetMatrix[0].inverse * worldToCameraMatrix;
		unity_StereoWorldToCamera[1] = eyesOffsetMatrix[1].inverse * worldToCameraMatrix;
		Shader.SetGlobalMatrixArray("unity_StereoWorldToCamera", unity_StereoWorldToCamera);
		Vector4[] values = new Vector4[2]
		{
			bothCamera.transform.position + eyesOffset[0],
			bothCamera.transform.position + eyesOffset[1]
		};
		Shader.SetGlobalVectorArray("unity_StereoWorldSpaceCameraPos", values);
		Shader.SetGlobalMatrixArray("unity_StereoMatrixV", unity_StereoWorldToCamera);
		Shader.SetGlobalMatrixArray("unity_StereoMatrixInvV", unity_StereoCameraToWorld);
		unity_StereoMatrixVP[0] = unity_StereoMatrixP[0] * unity_StereoWorldToCamera[0];
		unity_StereoMatrixVP[1] = unity_StereoMatrixP[1] * unity_StereoWorldToCamera[1];
		Shader.SetGlobalMatrixArray("unity_StereoMatrixVP", unity_StereoMatrixVP);
		SetRenderTextureWithDepth();
		SetCommandBuffers();
	}

	private void SetCommandBuffers()
	{
		if (commandBufferBeforeForwardOpaque == null)
		{
			commandBufferBeforeForwardOpaque = new CommandBuffer();
			Pvr_UnitySDKPluginEvent.SetSinglePassBeforeForwardOpaque(commandBufferBeforeForwardOpaque);
			commandBufferBeforeForwardOpaque.ClearRenderTarget(clearDepth: true, clearColor: true, bothCamera.backgroundColor);
			commandBufferBeforeForwardOpaque.name = "SinglePassPrepare";
		}
		bothCamera.RemoveCommandBuffer(CameraEvent.BeforeForwardOpaque, commandBufferBeforeForwardOpaque);
		bothCamera.AddCommandBuffer(CameraEvent.BeforeForwardOpaque, commandBufferBeforeForwardOpaque);
		if (commandBufferAfterSkybox == null)
		{
			commandBufferAfterSkybox = new CommandBuffer();
		}
		bothCamera.RemoveCommandBuffer(CameraEvent.AfterSkybox, commandBufferAfterSkybox);
		commandBufferAfterSkybox.Clear();
		commandBufferAfterSkybox.SetGlobalMatrixArray("unity_StereoMatrixVP", unity_StereoMatrixVP);
		commandBufferAfterSkybox.name = "SinglePassAfterSkyBox";
		bothCamera.AddCommandBuffer(CameraEvent.AfterSkybox, commandBufferAfterSkybox);
		if (commandBufferBeforeSkybox == null)
		{
			commandBufferBeforeSkybox = new CommandBuffer();
		}
		Matrix4x4 transpose = (Matrix4x4.LookAt(Vector3.zero, bothCamera.transform.forward, bothCamera.transform.up) * Matrix4x4.Scale(new Vector3(1f, 1f, -1f))).transpose;
		Matrix4x4 matrix4x = unity_StereoMatrixP[0];
		Matrix4x4 matrix4x2 = unity_StereoMatrixP[1];
		matrix4x.m22 = -1f;
		matrix4x2.m22 = -1f;
		Matrix4x4[] values = new Matrix4x4[2]
		{
			matrix4x * transpose,
			matrix4x2 * transpose
		};
		bothCamera.RemoveCommandBuffer(CameraEvent.BeforeSkybox, commandBufferBeforeSkybox);
		commandBufferBeforeSkybox.Clear();
		commandBufferBeforeSkybox.SetGlobalMatrixArray("unity_StereoMatrixVP", values);
		commandBufferBeforeSkybox.name = "SinglePassAfterSkybox";
		bothCamera.AddCommandBuffer(CameraEvent.BeforeSkybox, commandBufferBeforeSkybox);
	}

	private void SetRenderTextureWithDepth()
	{
		Pvr_UnitySDKAPI.System.UPvr_SetCurrentRenderTexture((uint)Pvr_UnitySDKRender.Instance.eyeTextureIds[Pvr_UnitySDKRender.Instance.currEyeTextureIdx]);
	}
}
public abstract class SDKStereoRendering
{
	public abstract void InitEye(Camera eye);

	public abstract void OnSDKRenderInited();

	public abstract void OnSDKPreRender();

	public abstract void OnSDKPostRender();
}
public class HighlightAtGaze : MonoBehaviour
{
	public Color HighlightColor = Color.red;

	public float AnimationTime = 0.1f;

	private Renderer myRenderer;

	private Color originalColor;

	private Color targetColor;

	private EyeTrackingGazeRay gazeRay;

	private void Start()
	{
		myRenderer = GetComponent<Renderer>();
		originalColor = myRenderer.material.color;
		targetColor = originalColor;
	}

	private void Update()
	{
		Pvr_UnitySDKAPI.System.UPvr_getEyeTrackingGazeRay(ref gazeRay);
		if (Physics.Raycast(new Ray(gazeRay.Origin, gazeRay.Direction), out var hitInfo))
		{
			if (hitInfo.transform.name == base.transform.name)
			{
				if (targetColor != HighlightColor)
				{
					targetColor = HighlightColor;
				}
			}
			else if (targetColor != originalColor)
			{
				targetColor = originalColor;
			}
		}
		else if (targetColor != originalColor)
		{
			targetColor = originalColor;
		}
		myRenderer.material.color = Color.Lerp(myRenderer.material.color, targetColor, Time.deltaTime * (1f / AnimationTime));
	}
}
public class RayVisualizer : MonoBehaviour
{
	private LineRenderer _line;

	private EyeTrackingGazeRay gazeRay;

	private void Start()
	{
		_line = base.gameObject.GetComponent<LineRenderer>();
		_line.startWidth = 0.002f;
		_line.endWidth = 0.002f;
	}

	private void Update()
	{
		Matrix4x4 matrix = Pvr_UnitySDKSensor.Instance.HeadPose.Matrix;
		Pvr_UnitySDKAPI.System.UPvr_getEyeTrackingGazeRay(ref gazeRay);
		_line.SetPosition(0, matrix.MultiplyPoint(new Vector3(0f, -0.05f, 0.2f)));
		_line.SetPosition(1, gazeRay.Origin + gazeRay.Direction * 20f);
	}
}
public class GetSeeThroughImage : MonoBehaviour
{
	public RawImage viewImage_left;

	public RawImage viewImage_right;

	private int width;

	private int height;

	private RenderTexture cameraTex_left;

	private RenderTexture cameraTex_right;

	private bool cameraPreview;

	private void Start()
	{
		CreateTexture();
	}

	private void Update()
	{
		if (Input.GetKey(KeyCode.JoystickButton0))
		{
			DrawTexture();
		}
	}

	private void OnDestory()
	{
		if (cameraPreview)
		{
			cameraPreview = false;
			BoundarySystem.UPvr_StopCameraFrame();
		}
	}

	private void CreateTexture()
	{
		width = 600;
		height = 600;
		BoundarySystem.UPvr_BoundarySetCameraImageRect(width, height);
		cameraTex_left = new RenderTexture(width, height, 24, RenderTextureFormat.Default);
		cameraTex_right = new RenderTexture(width, height, 24, RenderTextureFormat.Default);
		cameraTex_left.Create();
		cameraTex_right.Create();
		viewImage_left.texture = cameraTex_left;
		viewImage_right.texture = cameraTex_right;
	}

	private void DrawTexture()
	{
		if (!cameraPreview)
		{
			cameraPreview = true;
			BoundarySystem.UPvr_StartCameraFrame();
		}
		BoundarySystem.UPvr_BoundaryGetSeeThroughData(0, cameraTex_left);
		BoundarySystem.UPvr_BoundaryGetSeeThroughData(1, cameraTex_right);
	}
}
public class OverlayExternalSurfaceDemo : MonoBehaviour
{
	public string movieName;

	public Pvr_UnitySDKEyeOverlay.OverlayType overlayType;

	public Pvr_UnitySDKEyeOverlay.OverlayShape overlayShape;

	private Pvr_UnitySDKEyeOverlay overlay;

	private const string TAG = "[ExternalSurface]>>>>>>";

	private void Awake()
	{
		overlay = GetComponent<Pvr_UnitySDKEyeOverlay>();
		if (overlay == null)
		{
			UnityEngine.Debug.LogError("[ExternalSurface]>>>>>>Overlay is null!");
			overlay = base.gameObject.AddComponent<Pvr_UnitySDKEyeOverlay>();
		}
		overlay.overlayType = overlayType;
		overlay.overlayShape = overlayShape;
		overlay.isExternalAndroidSurface = true;
	}

	private void Start()
	{
		if (!string.IsNullOrEmpty(movieName))
		{
			StartPlay(Application.streamingAssetsPath + "/" + movieName, null);
		}
	}

	private void StartPlay(string moviePath, string licenceUrl)
	{
		if (moviePath != string.Empty)
		{
			if (overlay.isExternalAndroidSurface)
			{
				Pvr_UnitySDKEyeOverlay.ExternalAndroidSurfaceObjectCreated externalAndroidSurfaceObjectCreated = delegate
				{
					UnityEngine.Debug.Log("[ExternalSurface]>>>>>>SurfaceObject created callback is Invoke().");
				};
				if (overlay.externalAndroidSurfaceObject == IntPtr.Zero)
				{
					UnityEngine.Debug.Log("[ExternalSurface]>>>>>>Register surfaceObject crreated callback");
					overlay.externalAndroidSurfaceObjectCreated = externalAndroidSurfaceObjectCreated;
				}
				else
				{
					UnityEngine.Debug.Log("[ExternalSurface]>>>>>>SurfaceObject is already created! Invoke callback");
					externalAndroidSurfaceObjectCreated();
				}
			}
		}
		else
		{
			UnityEngine.Debug.LogError("[ExternalSurface]>>>>>>Movie path is null!");
		}
	}
}
public class MoveCylinder : MonoBehaviour
{
	private Vector3 startingPosition;

	private Quaternion startingRotation;

	private void Start()
	{
		startingPosition = base.transform.localPosition;
		startingRotation = base.transform.rotation;
	}

	public void Reset()
	{
		base.transform.localPosition = startingPosition;
		base.transform.rotation = startingRotation;
	}
}
[RequireComponent(typeof(Collider))]
public class MoveSphere : MonoBehaviour
{
	private Vector3 startingPosition;

	private void Start()
	{
		startingPosition = base.transform.localPosition;
		SetGazedAt(gazedAt: false);
		base.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 120f);
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void SetGazedAt(bool gazedAt)
	{
		GetComponent<Renderer>().material.color = (gazedAt ? Color.yellow : Color.blue);
	}

	public void Reset()
	{
		base.transform.localPosition = startingPosition;
		SetGazedAt(gazedAt: false);
		base.gameObject.GetComponent<Rigidbody>().Sleep();
		base.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 120f);
	}

	public void TeleportRandomly()
	{
		Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
		onUnitSphere.y = Mathf.Clamp(onUnitSphere.y, 0.5f, 1f);
		float num = 2f * UnityEngine.Random.value + 1.5f;
		base.transform.localPosition = onUnitSphere * num;
	}
}
public class Resetbutton : MonoBehaviour
{
	public void DemoResetTracking()
	{
		if (Pvr_UnitySDKSensor.Instance != null)
		{
			Pvr_UnitySDKSensor.Instance.ResetUnitySDKSensor();
		}
	}
}
public class UserEntitlementCheck : MonoBehaviour
{
	private void OnEnable()
	{
		Pvr_UnitySDKManager.EntitlementCheckResultEvent += HandelEntitlementCheckResult;
	}

	private void OnDisable()
	{
		Pvr_UnitySDKManager.EntitlementCheckResultEvent -= HandelEntitlementCheckResult;
	}

	private void HandelEntitlementCheckResult(int resultCode)
	{
		UnityEngine.Debug.Log("The User Entitlement Check Result is :" + resultCode);
		switch (resultCode)
		{
		case 0:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: success");
			break;
		case -1:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: invalid params");
			break;
		case -2:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: service not exist");
			break;
		case -3:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: bind failed");
			break;
		case -4:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: exception");
			break;
		case -5:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: timeout");
			break;
		case 10:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: missing package name");
			break;
		case 11:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: missing appid");
			break;
		case 13:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: appid and package name not match");
			break;
		case 20:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: not login");
			break;
		case 21:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: not pay");
			break;
		case 31:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: invalid sn");
			break;
		default:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: unknown");
			break;
		}
	}
}
public class Pvr_UnitySDKHeadTrack : MonoBehaviour
{
	[Tooltip("If true, head tracking will affect the rotation of each Pvr_UnitySDK's cameras.")]
	public bool trackRotation = true;

	[Tooltip("If true, head tracking will affect the position of each Pvr_UnitySDK's cameras.")]
	public bool trackPosition = true;

	public Transform target;

	private bool updated;

	private bool dataClock;

	public Ray Gaze
	{
		get
		{
			UpdateHead();
			return new Ray(base.transform.position, base.transform.forward);
		}
	}

	private void Update()
	{
		updated = false;
		UpdateHead();
	}

	private void UpdateHead()
	{
		if (updated)
		{
			return;
		}
		updated = true;
		if (Pvr_UnitySDKManager.SDK == null)
		{
			return;
		}
		if (trackRotation)
		{
			Quaternion orientation = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation;
			if (target == null)
			{
				base.transform.localRotation = orientation;
			}
			else
			{
				base.transform.rotation = orientation * target.rotation;
			}
		}
		else
		{
			Quaternion orientation2 = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation;
			if (target == null)
			{
				base.transform.localRotation = Quaternion.identity;
			}
			else
			{
				base.transform.rotation = orientation2 * target.rotation;
			}
		}
		if (trackPosition)
		{
			Vector3 position = Pvr_UnitySDKSensor.Instance.HeadPose.Position;
			if (target == null)
			{
				base.transform.localPosition = position;
			}
			else
			{
				base.transform.position = target.position + target.rotation * position;
			}
		}
	}
}
public class Pvr_UnitySDKPose
{
	protected static readonly Matrix4x4 flipZ = Matrix4x4.Scale(new Vector3(1f, 1f, -1f));

	public Matrix4x4 RightHandedMatrix => flipZ * Matrix * flipZ;

	public Vector3 Position { get; protected set; }

	public Quaternion Orientation { get; protected set; }

	public Matrix4x4 Matrix { get; protected set; }

	public Pvr_UnitySDKPose(Matrix4x4 matrix)
	{
		Set(matrix);
	}

	public Pvr_UnitySDKPose(Vector3 position, Quaternion orientation)
	{
		Set(position, orientation);
	}

	public void Set(Vector3 position, Quaternion orientation)
	{
		Position = position;
		Orientation = orientation;
		Matrix = Matrix4x4.TRS(position, orientation, Vector3.one);
	}

	protected void Set(Matrix4x4 matrix)
	{
		Matrix = matrix;
		Position = matrix.GetColumn(3);
		Orientation = Quaternion.LookRotation(matrix.GetColumn(2), matrix.GetColumn(1));
	}

	private Quaternion NormalizeQuaternion(ref Quaternion q)
	{
		float num = 0f;
		for (int i = 0; i < 4; i++)
		{
			num += q[i] * q[i];
		}
		float num2 = 1f / Mathf.Sqrt(num);
		for (int j = 0; j < 4; j++)
		{
			q[j] *= num2;
		}
		return q;
	}
}
public class Pvr_UnitySDKSensor
{
	public delegate void Enter3DofModel();

	public delegate void Exit3DofModel();

	private static Pvr_UnitySDKSensor instance;

	private bool SensorStart;

	private bool SensorInit;

	private Quaternion UnityQuaternion = Quaternion.identity;

	private Vector3 UnityPosition = Vector3.zero;

	private Sensorindex sensorIndex;

	private bool dofClock;

	public static Action EyeFovChanged;

	public Pvr_UnitySDKPose HeadPose;

	private float vfov = 102f;

	private float hfov = 102f;

	private float w;

	private float x;

	private float y;

	private float z;

	private float px;

	private float py;

	private float pz;

	public static Pvr_UnitySDKSensor Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new Pvr_UnitySDKSensor();
			}
			return instance;
		}
		set
		{
			instance = value;
		}
	}

	public static event Enter3DofModel Enter3DofModelEvent;

	public static event Exit3DofModel Exit3DofModelEvent;

	public Pvr_UnitySDKSensor()
	{
		Init();
	}

	public void Init()
	{
		InitUnitySDK6DofSensor();
		SensorInit = InitUnitySDKSensor();
		SensorStart = StartUnitySDKSensor();
		HeadPose = new Pvr_UnitySDKPose(Vector3.zero, Quaternion.identity);
	}

	public void SensorUpdate()
	{
		if (GetUnitySDKSensorState())
		{
			HeadPose.Set(UnityPosition, UnityQuaternion);
		}
	}

	public bool InitUnitySDKSensor()
	{
		bool result = false;
		try
		{
			if (Sensor.UPvr_Init((int)sensorIndex) == 0)
			{
				result = true;
			}
		}
		catch (Exception ex)
		{
			PLOG.E("InitUnitySDKSensor ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	public bool InitUnitySDK6DofSensor()
	{
		bool result = false;
		try
		{
			int res = 0;
			Render.UPvr_GetIntConfig(3, ref res);
			if (res == 1)
			{
				if (Sensor.UPvr_Enable6DofModule(!Pvr_UnitySDKManager.SDK.HmdOnlyrot) == 0 && !Pvr_UnitySDKManager.SDK.HmdOnlyrot)
				{
					result = true;
					Pvr_UnitySDKManager.SDK.PVRNeck = false;
				}
			}
			else
			{
				UnityEngine.Debug.LogWarning("This platform does not support 6 Dof !");
			}
		}
		catch (Exception ex)
		{
			PLOG.E("InitUnity6DofSDKSensor ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	public bool StartUnitySDKSensor()
	{
		bool result = false;
		try
		{
			if (Sensor.UPvr_StartSensor((int)sensorIndex) == 0)
			{
				result = true;
			}
		}
		catch (Exception ex)
		{
			PLOG.E("StartUnitySDKSensor ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	public bool StopUnitySDKSensor()
	{
		bool result = false;
		try
		{
			if (Sensor.UPvr_StopSensor((int)sensorIndex) == 0)
			{
				result = true;
			}
		}
		catch (Exception ex)
		{
			PLOG.E("StopUnitySDKSensor ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	public bool ResetUnitySDKSensor()
	{
		bool result = false;
		try
		{
			if (Sensor.UPvr_ResetSensor((int)sensorIndex) == 0)
			{
				result = true;
				PLOG.E("ResetUnitySDKSensor OK! ");
			}
		}
		catch (Exception ex)
		{
			PLOG.E("ResetUnitySDKSensor ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	public bool OptionalResetUnitySDKSensor(int resetRot, int resetPos)
	{
		bool result = false;
		try
		{
			if (Sensor.UPvr_OptionalResetSensor((int)sensorIndex, resetRot, resetPos) == 0)
			{
				result = true;
				UnityEngine.Debug.Log("PvrLog OptionalResetUnitySDKSensor OK!" + resetRot + resetPos);
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError("OptionalResetUnitySDKSensor ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	public bool GetUnitySDKSensorState()
	{
		bool result = false;
		if (SensorInit && SensorStart)
		{
			try
			{
				int num = -1;
				if (Pvr_UnitySDKManager.SDK.ShowVideoSeethrough)
				{
					Pvr_BoundarySystem.Instance.CameraFramePtr = Pvr_BoundaryAPI.UPvr_GetCameraData_Ext();
					num = Pvr_BoundaryAPI.UPvr_GetMainSensorStateExt(ref x, ref y, ref z, ref w, ref px, ref py, ref pz, ref vfov, ref hfov, ref Pvr_UnitySDKRender.Instance.RenderviewNumber);
				}
				else
				{
					num = Sensor.UPvr_GetMainSensorState(ref x, ref y, ref z, ref w, ref px, ref py, ref pz, ref vfov, ref hfov, ref Pvr_UnitySDKRender.Instance.RenderviewNumber);
				}
				Pvr_UnitySDKManager.SDK.posStatus = Sensor.UPvr_Get6DofSensorQualityStatus();
				if (num == 0)
				{
					if (!Convert.ToBoolean(Pvr_UnitySDKManager.SDK.posStatus & 2))
					{
						if (!dofClock)
						{
							if (Pvr_UnitySDKSensor.Enter3DofModelEvent != null)
							{
								Pvr_UnitySDKSensor.Enter3DofModelEvent();
							}
							dofClock = true;
						}
					}
					else if (dofClock)
					{
						if (Pvr_UnitySDKSensor.Exit3DofModelEvent != null)
						{
							Pvr_UnitySDKSensor.Exit3DofModelEvent();
						}
						dofClock = false;
					}
					RefreshHeadData(x, y, z, w, px, py, pz);
					UnityQuaternion.Set(x, y, 0f - z, 0f - w);
					if (Pvr_UnitySDKRender.Instance.EyeVFoV != vfov)
					{
						Pvr_UnitySDKRender.Instance.EyeVFoV = vfov;
						if (EyeFovChanged != null)
						{
							EyeFovChanged();
						}
					}
					Pvr_UnitySDKRender.Instance.EyeHFoV = hfov;
					Pvr_UnitySDKManager.SDK.EyesAspect = hfov / vfov;
					result = true;
					if (Pvr_UnitySDKManager.SDK.HmdOnlyrot)
					{
						if (Pvr_UnitySDKManager.SDK.PVRNeck)
						{
							if (Pvr_UnitySDKManager.SDK.TrackingOrigin == TrackingOrigin.FloorLevel)
							{
								UnityPosition.Set(0f, py, 0f);
								UnityPosition += UnityQuaternion * Pvr_UnitySDKManager.SDK.neckOffset - Pvr_UnitySDKManager.SDK.neckOffset.y * Vector3.up;
							}
							else
							{
								UnityPosition = UnityQuaternion * Pvr_UnitySDKManager.SDK.neckOffset - Pvr_UnitySDKManager.SDK.neckOffset.y * Vector3.up;
							}
						}
					}
					else
					{
						UnityPosition.Set(px, py, 0f - pz);
					}
					if (PLOG.logLevel > 2)
					{
						PLOG.D("posStatus=" + Pvr_UnitySDKManager.SDK.posStatus);
						PLOG.D("PvrLog 6DoFHeadRotation:" + x + "," + y + "," + (0f - z) + "," + (0f - w) + ",Position:" + px + "," + py + "," + (0f - pz) + ",eulerAngles:" + UnityQuaternion.eulerAngles);
					}
				}
				if (num == -1)
				{
					PLOG.I("PvrLog Sensor update --- GetUnitySDKSensorState  -1 ");
				}
			}
			catch (Exception ex)
			{
				PLOG.E("GetUnitySDKSensorState ERROR! " + ex.Message);
				throw;
			}
		}
		return result;
	}

	public bool GetUnitySDKPSensorState()
	{
		bool result = false;
		try
		{
			if (Sensor.UPvr_ResetSensor((int)sensorIndex) == 0)
			{
				result = true;
			}
		}
		catch (Exception ex)
		{
			PLOG.E("GetUnitySDKPSensorState ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	private void RefreshHeadData(float x, float y, float z, float w, float px, float py, float pz)
	{
		Pvr_UnitySDKManager.SDK.headData[0] = x;
		Pvr_UnitySDKManager.SDK.headData[1] = y;
		Pvr_UnitySDKManager.SDK.headData[2] = z;
		Pvr_UnitySDKManager.SDK.headData[3] = w;
		Pvr_UnitySDKManager.SDK.headData[4] = px;
		Pvr_UnitySDKManager.SDK.headData[5] = py;
		Pvr_UnitySDKManager.SDK.headData[6] = pz;
	}
}
public class CLoadingAsset : ScriptableObject
{
	public int SplashScreenType;

	public List<Texture2D> splashImage = new List<Texture2D>();

	public Texture2D Inside_background;

	public bool UseSplashText;

	public string DefaultText;

	public string ChineseText;

	public string EnglishText;

	public string JapaneseText;

	public string KoreanText;

	public string FontSize;

	public Color FontColor;

	public string TextHeight;

	public bool UseCarousel;

	public int SplashTextAlignment;
}
[Serializable]
public class Pvr_UnitySDKConfigProfile
{
	public struct Lenses
	{
		public float separation;

		public float offset;

		public float distance;

		public int alignment;

		public const int AlignTop = -1;

		public const int AlignCenter = 0;

		public const int AlignBottom = 1;
	}

	public struct MaxFOV
	{
		public float upper;

		public float lower;

		public float inner;

		public float outer;
	}

	public struct Distortion
	{
		public float k1;

		public float k2;

		public float k3;

		public float k4;

		public float k5;

		public float k6;

		public float distort(float r)
		{
			return 0f;
		}

		public float distort(float r, float dist)
		{
			float num = r * dist * 1000f;
			return (k1 * Mathf.Pow(num, 5f) + k2 * Mathf.Pow(num, 4f) + k3 * Mathf.Pow(num, 3f) + k4 * Mathf.Pow(num, 2f) + k5 * num + k6) / 1000f / dist;
		}

		public float diatortInv(float radious)
		{
			return 0f;
		}
	}

	public struct Device
	{
		public Lenses devLenses;

		public MaxFOV devMaxFov;

		public Distortion devDistortion;

		public Distortion devDistortionInv;
	}

	public static readonly Device SimulateDevice = new Device
	{
		devLenses = 
		{
			separation = 0.062f,
			offset = 0f,
			distance = 0.0403196f,
			alignment = 0
		},
		devMaxFov = 
		{
			upper = 40f,
			lower = 40f,
			inner = 40f,
			outer = 40f
		},
		devDistortion = 
		{
			k1 = 2.333E-06f,
			k2 = -0.000126f,
			k3 = 0.002978f,
			k4 = -0.02615f,
			k5 = 1.089f,
			k6 = -0.0337f
		},
		devDistortionInv = 
		{
			k1 = 1.342E-08f,
			k2 = 1.665E-06f,
			k3 = -0.0002797f,
			k4 = 0.001166f,
			k5 = 0.9945f,
			k6 = 0.004805f
		}
	};

	public Device device;

	public static readonly Pvr_UnitySDKConfigProfile Default = new Pvr_UnitySDKConfigProfile
	{
		device = SimulateDevice
	};

	public Pvr_UnitySDKConfigProfile Clone()
	{
		return new Pvr_UnitySDKConfigProfile
		{
			device = device
		};
	}

	public static Pvr_UnitySDKConfigProfile GetPicoProfile()
	{
		return new Pvr_UnitySDKConfigProfile
		{
			device = SimulateDevice
		};
	}

	public float[] GetLeftEyeVisibleTanAngles(float width, float height)
	{
		float val = (float)Math.Tan((double)(0f - device.devMaxFov.outer) * Math.PI / 180.0);
		float val2 = (float)Math.Tan((double)device.devMaxFov.upper * Math.PI / 180.0);
		float val3 = (float)Math.Tan((double)device.devMaxFov.inner * Math.PI / 180.0);
		float val4 = (float)Math.Tan((double)(0f - device.devMaxFov.lower) * Math.PI / 180.0);
		float num = width / 4f;
		float num2 = height / 2f;
		float num3 = device.devLenses.separation / 2f - num;
		float num4 = 0f;
		float distance = device.devLenses.distance;
		float val5 = device.devDistortion.distort((num3 - num) / distance, device.devLenses.distance);
		float val6 = device.devDistortion.distort((num4 + num2) / distance, device.devLenses.distance);
		float val7 = device.devDistortion.distort((num3 + num) / distance, device.devLenses.distance);
		float val8 = device.devDistortion.distort((num4 - num) / distance, device.devLenses.distance);
		float num5 = Math.Max(val, val5);
		float num6 = Math.Min(val2, val6);
		float num7 = Math.Min(val3, val7);
		float num8 = Math.Max(val4, val8);
		return new float[4] { num5, num6, num7, num8 };
	}

	public float[] GetLeftEyeNoLensTanAngles(float width, float height)
	{
		float val = device.devDistortionInv.distort((float)Math.Tan((double)(0f - device.devMaxFov.outer) * Math.PI / 180.0), device.devLenses.distance);
		float val2 = device.devDistortionInv.distort((float)Math.Tan((double)device.devMaxFov.upper * Math.PI / 180.0), device.devLenses.distance);
		float val3 = device.devDistortionInv.distort((float)Math.Tan((double)device.devMaxFov.inner * Math.PI / 180.0), device.devLenses.distance);
		float val4 = device.devDistortionInv.distort((float)Math.Tan((double)(0f - device.devMaxFov.lower) * Math.PI / 180.0), device.devLenses.distance);
		float num = width / 4f;
		float num2 = height / 2f;
		float num3 = device.devLenses.separation / 2f - num;
		float num4 = 0f;
		float distance = device.devLenses.distance;
		float val5 = (num3 - num) / distance;
		float val6 = (num4 + num2) / distance;
		float val7 = (num3 + num) / distance;
		float val8 = (num4 - num) / distance;
		float num5 = Math.Min(val, val5);
		float num6 = Math.Min(val2, val6);
		float num7 = Math.Min(val3, val7);
		float num8 = Math.Max(val4, val8);
		return new float[4] { num5, num6, num7, num8 };
	}

	public Rect GetLeftEyeVisibleScreenRect(float[] undistortedFrustum, float width, float height)
	{
		float distance = device.devLenses.distance;
		float num = (width - device.devLenses.separation) / 2f;
		float num2 = height / 2f;
		float num3 = (undistortedFrustum[0] * distance + num) / width;
		float num4 = (undistortedFrustum[1] * distance + num2) / height;
		float num5 = (undistortedFrustum[2] * distance + num) / width;
		float num6 = (undistortedFrustum[3] * distance + num2) / height;
		return new Rect(num3, num6, num5 - num3, num4 - num6);
	}
}
[RequireComponent(typeof(Text))]
public class Pvr_UnitySDKFPS : MonoBehaviour
{
	public Text fpsText;

	private float updateInterval = 0.5f;

	private float accum;

	private int frames;

	private float timeLeft;

	private string strFps;

	private void Update()
	{
		if (fpsText != null)
		{
			ShowFps();
		}
	}

	private void ShowFps()
	{
		timeLeft -= Time.unscaledDeltaTime;
		accum += Time.unscaledDeltaTime;
		frames++;
		if ((double)timeLeft <= 0.0)
		{
			float num = (float)frames / accum;
			strFps = $"FPS: {num:f0}";
			fpsText.text = strFps;
			timeLeft += updateInterval;
			accum = 0f;
			frames = 0;
		}
	}
}
public class Pvr_GazeFuse : MonoBehaviour
{
	public GameObject gazeGameObject;

	private Image image;

	private void Start()
	{
		image = GetComponent<Image>();
	}

	private void Update()
	{
		if (gazeGameObject == null || Pvr_GazeInputModule.gazeGameObject == gazeGameObject)
		{
			FuseAmountChanged(Pvr_GazeInputModule.gazeFraction);
		}
	}

	private void FuseAmountChanged(float fuseAmount)
	{
		if (image != null)
		{
			image.fillAmount = fuseAmount;
		}
	}
}
public class Pvr_GazeInputModule : PointerInputModule
{
	public enum Mode
	{
		Click,
		Gaze
	}

	public Mode mode;

	[Header("Click Settings")]
	public string ClickInputName = "Submit";

	[Header("Gaze Settings")]
	public float GazeTimeInSeconds = 2f;

	public RaycastResult CurrentRaycast;

	private PointerEventData pointerEventData;

	private GameObject currentLookAtHandler;

	private float currentLookAtHandlerClickTime;

	public static float gazeFraction { get; private set; }

	public static GameObject gazeGameObject { get; private set; }

	public override void Process()
	{
		HandleLook();
		HandleSelection();
	}

	private void HandleLook()
	{
		if (pointerEventData == null)
		{
			pointerEventData = new PointerEventData(base.eventSystem);
		}
		pointerEventData.position = new Vector2(Screen.width / 2, Screen.height / 2);
		pointerEventData.delta = Vector2.zero;
		List<RaycastResult> list = new List<RaycastResult>();
		base.eventSystem.RaycastAll(pointerEventData, list);
		RaycastResult currentRaycast = (pointerEventData.pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(list));
		CurrentRaycast = currentRaycast;
		ProcessMove(pointerEventData);
	}

	private void HandleSelection()
	{
		gazeFraction = 0f;
		if (pointerEventData.pointerEnter != null)
		{
			GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(pointerEventData.pointerEnter);
			if (currentLookAtHandler != eventHandler)
			{
				gazeGameObject = (currentLookAtHandler = eventHandler);
				currentLookAtHandlerClickTime = Time.realtimeSinceStartup + GazeTimeInSeconds;
			}
			if (mode == Mode.Gaze && currentLookAtHandler != null)
			{
				gazeFraction = Mathf.Clamp01(1f - (currentLookAtHandlerClickTime - Time.realtimeSinceStartup) / GazeTimeInSeconds);
			}
			if ((currentLookAtHandler != null && mode == Mode.Gaze && Time.realtimeSinceStartup > currentLookAtHandlerClickTime) || (mode == Mode.Click && Input.GetButtonDown(ClickInputName)))
			{
				_ = EventSystem.current.currentSelectedGameObject != null;
				EventSystem.current.SetSelectedGameObject(currentLookAtHandler);
				gazeFraction = 0f;
				ExecuteEvents.ExecuteHierarchy(currentLookAtHandler, pointerEventData, ExecuteEvents.pointerClickHandler);
				currentLookAtHandlerClickTime = float.MaxValue;
				ExecuteEvents.ExecuteHierarchy(EventSystem.current.currentSelectedGameObject, pointerEventData, ExecuteEvents.deselectHandler);
			}
		}
		else
		{
			gazeGameObject = (currentLookAtHandler = null);
		}
	}
}
[RequireComponent(typeof(Pvr_GazeInputModule))]
public class Pvr_GazeInputModuleCrosshair : MonoBehaviour
{
	public static bool DisplayCrosshair = true;

	[Tooltip("Crosshair GameObject attached to your VR Camera")]
	public Transform Crosshair;

	private Pvr_GazeInputModule gazeInputModule;

	private Vector3 CrosshairOriginalScale;

	private float CrosshairOriginalDistance;

	private void Awake()
	{
		gazeInputModule = GetComponent<Pvr_GazeInputModule>();
	}

	private void Start()
	{
		CrosshairOriginalScale = Crosshair.localScale;
		CrosshairOriginalDistance = Crosshair.localPosition.z;
		Crosshair.gameObject.SetActive(value: false);
	}

	private void Update()
	{
		Crosshair.gameObject.SetActive(DisplayCrosshair);
		if (DisplayCrosshair)
		{
			float crossHairAtDistance = CrosshairOriginalDistance;
			if (gazeInputModule.CurrentRaycast.isValid)
			{
				crossHairAtDistance = gazeInputModule.CurrentRaycast.distance * 0.8f - 0.5f;
			}
			SetCrossHairAtDistance(crossHairAtDistance);
		}
	}

	private void SetCrossHairAtDistance(float dist)
	{
		Vector3 localPosition = Crosshair.localPosition;
		Crosshair.localPosition = new Vector3(localPosition.x, localPosition.y, dist);
		Crosshair.localScale = CrosshairOriginalScale * dist;
	}
}
public enum RenderEventType
{
	InitRenderThread = 1024,
	Pause,
	Resume,
	LeftEyeEndFrame,
	RightEyeEndFrame,
	TimeWarp,
	ResetVrModeParms,
	ShutdownRenderThread,
	BeginEye,
	EndEye,
	BoundaryRenderLeft,
	BoundaryRenderRight,
	BothEyeEndFrame,
	CameraFrameLeft,
	CameraFrameRight,
	StartCameraFrame,
	StopCameraFrame
}
public static class Pvr_UnitySDKPluginEvent
{
	private delegate void RenderEventDelegate(int eventId);

	private const uint IS_DATA_FLAG = 2147483648u;

	private const uint DATA_POS_MASK = 1073741824u;

	private const int DATA_POS_SHIFT = 30;

	private const uint EVENT_TYPE_MASK = 1056899072u;

	private const int EVENT_TYPE_SHIFT = 17;

	private const uint PAYLOAD_MASK = 65535u;

	private const int PAYLOAD_SHIFT = 16;

	private static RenderEventDelegate SetSinglePassBeforeForwardOpaqueHandle = SetSinglePassBeforeForwardOpaque;

	private static IntPtr SetSinglePassBeforeForwardOpaquePtr = Marshal.GetFunctionPointerForDelegate(SetSinglePassBeforeForwardOpaqueHandle);

	public static void Issue(RenderEventType eventType)
	{
		GL.IssuePluginEvent(Pvr_UnitySDKAPI.System.GetRenderEventFunc(), (int)eventType);
	}

	private static int EncodeType(int eventType)
	{
		return eventType & 0x7FFFFFFF;
	}

	private static int EncodeData(int eventId, int eventData, int pos)
	{
		return int.MinValue | ((pos << 30) & 0x40000000) | ((eventId << 17) & 0x3EFF0000) | ((eventData >>> pos * 16) & 0xFFFF);
	}

	private static int DecodeData(int eventData)
	{
		uint num = (uint)(eventData & 0x40000000) >> 30;
		return (eventData & 0xFFFF) << (int)(16 * num);
	}

	[MonoPInvokeCallback(typeof(RenderEventDelegate))]
	private static void SetSinglePassBeforeForwardOpaque(int eventId)
	{
		Pvr_UnitySDKAPI.System.UPvr_SinglePassBeforeForwardOpaque();
	}

	public static void SetSinglePassBeforeForwardOpaque(CommandBuffer cmd)
	{
		cmd.IssuePluginEvent(SetSinglePassBeforeForwardOpaquePtr, 0);
	}
}
public class Pvr_UnitySDKSightInputModule : BaseInputModule
{
	[Tooltip("Optional object to place at raycast intersections as a 3D cursor. Be sure it is on a layer that raycasts will ignore.")]
	public GameObject cursor;

	public int trigger;

	[HideInInspector]
	public float clickTime = 0.1f;

	[HideInInspector]
	public Vector2 hotspot = new Vector2(0.5f, 0.5f);

	private PointerEventData pointerData;

	public override bool ShouldActivateModule()
	{
		if (!base.ShouldActivateModule())
		{
			return false;
		}
		return Pvr_UnitySDKManager.SDK.VRModeEnabled;
	}

	public override void DeactivateModule()
	{
		base.DeactivateModule();
		if (pointerData != null)
		{
			HandlePendingClick();
			HandlePointerExitAndEnter(pointerData, null);
			pointerData = null;
		}
		base.eventSystem.SetSelectedGameObject(null, GetBaseEventData());
		if (cursor != null)
		{
			cursor.SetActive(value: false);
		}
	}

	public override bool IsPointerOverGameObject(int pointerId)
	{
		if (pointerData != null)
		{
			return pointerData.pointerEnter != null;
		}
		return false;
	}

	public override void Process()
	{
		CastRayFromGaze();
		UpdateCurrentObject();
		PlaceCursor();
		HandlePendingClick();
		HandleTrigger();
	}

	private void CastRayFromGaze()
	{
		if (pointerData == null)
		{
			pointerData = new PointerEventData(base.eventSystem);
		}
		pointerData.Reset();
		pointerData.position = new Vector2(hotspot.x * (float)Screen.width, hotspot.y * (float)Screen.height);
		base.eventSystem.RaycastAll(pointerData, m_RaycastResultCache);
		pointerData.pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(m_RaycastResultCache);
		m_RaycastResultCache.Clear();
	}

	private void UpdateCurrentObject()
	{
		GameObject gameObject = pointerData.pointerCurrentRaycast.gameObject;
		HandlePointerExitAndEnter(pointerData, gameObject);
		if (ExecuteEvents.GetEventHandler<ISelectHandler>(gameObject) == base.eventSystem.currentSelectedGameObject)
		{
			ExecuteEvents.Execute(base.eventSystem.currentSelectedGameObject, GetBaseEventData(), ExecuteEvents.updateSelectedHandler);
		}
		else
		{
			base.eventSystem.SetSelectedGameObject(null, pointerData);
		}
	}

	private void PlaceCursor()
	{
		if (!(cursor == null))
		{
			GameObject gameObject = pointerData.pointerCurrentRaycast.gameObject;
			cursor.SetActive(gameObject != null);
			if (cursor.activeInHierarchy)
			{
				Camera enterEventCamera = pointerData.enterEventCamera;
				float num = pointerData.pointerCurrentRaycast.distance + enterEventCamera.nearClipPlane - 0.1f;
				cursor.transform.position = enterEventCamera.transform.position + enterEventCamera.transform.forward * num;
			}
		}
	}

	private void HandlePendingClick()
	{
		if (pointerData.eligibleForClick && (Pvr_UnitySDKManager.SDK.picovrTriggered || !(Time.unscaledTime - pointerData.clickTime < clickTime)))
		{
			ExecuteEvents.Execute(pointerData.pointerPress, pointerData, ExecuteEvents.pointerUpHandler);
			ExecuteEvents.Execute(pointerData.pointerPress, pointerData, ExecuteEvents.pointerClickHandler);
			pointerData.pointerPress = null;
			pointerData.rawPointerPress = null;
			pointerData.eligibleForClick = false;
			pointerData.clickCount = 0;
		}
	}

	private void HandleTrigger()
	{
		if (Pvr_UnitySDKManager.SDK.picovrTriggered)
		{
			GameObject gameObject = pointerData.pointerCurrentRaycast.gameObject;
			if (!(gameObject == null) && !(ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject) == null))
			{
				pointerData.pointerPress = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				pointerData.pressPosition = pointerData.position;
				pointerData.pointerPressRaycast = pointerData.pointerCurrentRaycast;
				pointerData.pointerPress = ExecuteEvents.ExecuteHierarchy(gameObject, pointerData, ExecuteEvents.pointerDownHandler) ?? ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				pointerData.rawPointerPress = gameObject;
				pointerData.eligibleForClick = true;
				pointerData.clickCount = 1;
				pointerData.clickTime = Time.unscaledTime;
			}
		}
	}
}
public class Pvr_ObjImporter
{
	private static Pvr_ObjImporter _instance;

	private List<int> triangles;

	private List<Vector3> vertices;

	private List<Vector2> uv;

	private List<Vector3> normals;

	private List<PvrVector3Int> faceData;

	private List<int> intArray;

	private const int MIN_POW_10 = -16;

	private const int MAX_POW_10 = 16;

	private const int NUM_POWS_10 = 33;

	private static readonly float[] pow10 = GenerateLookupTable();

	public static Pvr_ObjImporter Instance => _instance ?? (_instance = new Pvr_ObjImporter());

	public Mesh ImportFile(string filePath)
	{
		triangles = new List<int>();
		vertices = new List<Vector3>();
		uv = new List<Vector2>();
		normals = new List<Vector3>();
		faceData = new List<PvrVector3Int>();
		intArray = new List<int>();
		LoadMeshData(filePath);
		Vector3[] array = new Vector3[faceData.Count];
		Vector2[] array2 = new Vector2[faceData.Count];
		Vector3[] array3 = new Vector3[faceData.Count];
		for (int i = 0; i < faceData.Count; i++)
		{
			array[i] = vertices[faceData[i].x - 1];
			if (faceData[i].y >= 1)
			{
				array2[i] = uv[faceData[i].y - 1];
			}
			if (faceData[i].z >= 1)
			{
				array3[i] = normals[faceData[i].z - 1];
			}
		}
		Mesh mesh = new Mesh();
		mesh.vertices = array;
		mesh.uv = array2;
		mesh.normals = array3;
		mesh.triangles = triangles.ToArray();
		mesh.RecalculateBounds();
		return mesh;
	}

	private void LoadMeshData(string fileName)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = File.ReadAllText(fileName);
		int num = 0;
		string text2 = null;
		int num2 = 0;
		StringBuilder sbInt = new StringBuilder();
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] != '\n')
			{
				continue;
			}
			stringBuilder.Remove(0, stringBuilder.Length);
			stringBuilder.Append(text, num + 1, i - num);
			num = i;
			if (stringBuilder[0] == 'o' && stringBuilder[1] == ' ')
			{
				sbInt.Remove(0, sbInt.Length);
				for (int j = 2; j < stringBuilder.Length; j++)
				{
					text2 += stringBuilder[j];
				}
			}
			else if (stringBuilder[0] == 'v' && stringBuilder[1] == ' ')
			{
				int start = 2;
				vertices.Add(new Vector3(GetFloat(stringBuilder, ref start, ref sbInt), GetFloat(stringBuilder, ref start, ref sbInt), GetFloat(stringBuilder, ref start, ref sbInt)));
			}
			else if (stringBuilder[0] == 'v' && stringBuilder[1] == 't' && stringBuilder[2] == ' ')
			{
				int start2 = 3;
				uv.Add(new Vector2(GetFloat(stringBuilder, ref start2, ref sbInt), GetFloat(stringBuilder, ref start2, ref sbInt)));
			}
			else if (stringBuilder[0] == 'v' && stringBuilder[1] == 'n' && stringBuilder[2] == ' ')
			{
				int start3 = 3;
				normals.Add(new Vector3(GetFloat(stringBuilder, ref start3, ref sbInt), GetFloat(stringBuilder, ref start3, ref sbInt), GetFloat(stringBuilder, ref start3, ref sbInt)));
			}
			else if (stringBuilder[0] == 'f' && stringBuilder[1] == ' ')
			{
				int start4 = 2;
				int num3 = 1;
				intArray.Clear();
				int num4 = 0;
				while (start4 < stringBuilder.Length && char.IsDigit(stringBuilder[start4]))
				{
					faceData.Add(new PvrVector3Int(GetInt(stringBuilder, ref start4, ref sbInt), GetInt(stringBuilder, ref start4, ref sbInt), GetInt(stringBuilder, ref start4, ref sbInt)));
					num3++;
					intArray.Add(num2);
					num2++;
				}
				num4 += num3;
				for (num3 = 1; num3 + 2 < num4; num3++)
				{
					triangles.Add(intArray[0]);
					triangles.Add(intArray[num3]);
					triangles.Add(intArray[num3 + 1]);
				}
			}
		}
	}

	private float GetFloat(StringBuilder sb, ref int start, ref StringBuilder sbFloat)
	{
		sbFloat.Remove(0, sbFloat.Length);
		while (start < sb.Length && (char.IsDigit(sb[start]) || sb[start] == '-' || sb[start] == '.'))
		{
			sbFloat.Append(sb[start]);
			start++;
		}
		start++;
		return ParseFloat(sbFloat);
	}

	private int GetInt(StringBuilder sb, ref int start, ref StringBuilder sbInt)
	{
		sbInt.Remove(0, sbInt.Length);
		while (start < sb.Length && char.IsDigit(sb[start]))
		{
			sbInt.Append(sb[start]);
			start++;
		}
		start++;
		return IntParseFast(sbInt);
	}

	private static float[] GenerateLookupTable()
	{
		float[] array = new float[320];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (float)(i / 33) * Mathf.Pow(10f, i % 33 + -16);
		}
		return array;
	}

	private float ParseFloat(StringBuilder value)
	{
		float num = 0f;
		bool flag = false;
		int length = value.Length;
		int num2 = value.Length;
		for (int num3 = length - 1; num3 >= 0; num3--)
		{
			if (value[num3] == '.')
			{
				num2 = num3;
				break;
			}
		}
		int num4 = 16 + num2;
		for (int i = 0; i < num2; i++)
		{
			if (i != num2 && value[i] != '-')
			{
				num += pow10[(value[i] - 48) * 33 + num4 - i - 1];
			}
			else if (value[i] == '-')
			{
				flag = true;
			}
		}
		for (int j = num2 + 1; j < length; j++)
		{
			if (j != num2)
			{
				num += pow10[(value[j] - 48) * 33 + num4 - j];
			}
		}
		if (flag)
		{
			num = 0f - num;
		}
		return num;
	}

	private int IntParseFast(StringBuilder value)
	{
		int num = 0;
		for (int i = 0; i < value.Length; i++)
		{
			num = 10 * num + (value[i] - 48);
		}
		return num;
	}
}
public sealed class PvrVector3Int
{
	public int x { get; set; }

	public int y { get; set; }

	public int z { get; set; }

	public PvrVector3Int()
	{
	}

	public PvrVector3Int(int x, int y, int z)
	{
		this.x = x;
		this.y = y;
		this.z = z;
	}
}
public class Pvr_EnumFlags : PropertyAttribute
{
}
public enum ConfirmBtn
{
	App = 1,
	TouchPad = 2,
	Trigger = 4
}
public class Pvr_InputModule : PointerInputModule
{
	public static List<Pvr_UIPointer> pointers = new List<Pvr_UIPointer>();

	[Pvr_EnumFlags]
	public ConfirmBtn confirmBtn = ConfirmBtn.TouchPad;

	private List<RaycastResult> rayCasts = new List<RaycastResult>();

	private RaycastResult rayCastResult;

	public virtual void Initialise()
	{
		pointers.Clear();
	}

	public static void AddPoint(Pvr_UIPointer point)
	{
		if (!pointers.Contains(point))
		{
			pointers.Add(point);
		}
	}

	public static void RemovePoint(Pvr_UIPointer point)
	{
		if (pointers.Contains(point))
		{
			pointers.Remove(point);
		}
	}

	public override void Process()
	{
		if (Pvr_UnitySDKManager.SDK.isHasController)
		{
			if ((confirmBtn & ConfirmBtn.App) == ConfirmBtn.App)
			{
				Pvr_UIPointer.AppBtnValue = Controller.UPvr_GetKey(Pvr_ControllerManager.controllerlink.mainHandID, Pvr_KeyCode.APP);
			}
			if ((confirmBtn & ConfirmBtn.TouchPad) == ConfirmBtn.TouchPad)
			{
				Pvr_UIPointer.TouchBtnValue = Controller.UPvr_GetKey(Pvr_ControllerManager.controllerlink.mainHandID, Pvr_KeyCode.TOUCHPAD);
			}
			if ((confirmBtn & ConfirmBtn.Trigger) == ConfirmBtn.Trigger)
			{
				Pvr_UIPointer.TriggerBtnValue = Controller.UPvr_GetKey(Pvr_ControllerManager.controllerlink.mainHandID, Pvr_KeyCode.TRIGGER);
			}
		}
		for (int i = 0; i < pointers.Count; i++)
		{
			Pvr_UIPointer pvr_UIPointer = pointers[i];
			if (pvr_UIPointer.gameObject.activeInHierarchy && pvr_UIPointer.enabled)
			{
				List<RaycastResult> results = new List<RaycastResult>();
				if (pvr_UIPointer.PointerActive())
				{
					results = CheckRaycasts(pvr_UIPointer);
				}
				Hover(pvr_UIPointer, results);
				Click(pvr_UIPointer, results);
				Drag(pvr_UIPointer, results);
			}
		}
	}

	protected virtual List<RaycastResult> CheckRaycasts(Pvr_UIPointer pointer)
	{
		rayCastResult.worldPosition = pointer.GetOriginPosition();
		rayCastResult.worldNormal = pointer.GetOriginForward();
		pointer.pointerEventData.pointerCurrentRaycast = rayCastResult;
		base.eventSystem.RaycastAll(pointer.pointerEventData, rayCasts);
		return rayCasts;
	}

	protected virtual bool CheckTransformTree(Transform target, Transform source)
	{
		if (target == null)
		{
			return false;
		}
		if (target.Equals(source))
		{
			return true;
		}
		return CheckTransformTree(target.transform.parent, source);
	}

	protected virtual bool NoValidCollision(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		if (results.Count != 0)
		{
			return !CheckTransformTree(results[0].gameObject.transform, pointer.pointerEventData.pointerEnter.transform);
		}
		return true;
	}

	protected virtual bool IsHovering(Pvr_UIPointer pointer)
	{
		foreach (GameObject item in pointer.pointerEventData.hovered)
		{
			if ((bool)pointer.pointerEventData.pointerEnter && (bool)item && CheckTransformTree(item.transform, pointer.pointerEventData.pointerEnter.transform))
			{
				return true;
			}
		}
		return false;
	}

	protected virtual bool ValidElement(GameObject obj)
	{
		Pvr_UICanvas componentInParent = obj.GetComponentInParent<Pvr_UICanvas>();
		if (!componentInParent || !componentInParent.enabled)
		{
			return false;
		}
		return true;
	}

	protected virtual void CheckPointerHoverClick(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		if (pointer.hoverDurationTimer > 0f)
		{
			pointer.hoverDurationTimer -= Time.deltaTime;
		}
		if (pointer.canClickOnHover && pointer.hoverDurationTimer <= 0f)
		{
			pointer.canClickOnHover = false;
			ClickOnDown(pointer, results, forceClick: true);
		}
	}

	protected virtual void Hover(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		if ((bool)pointer.pointerEventData.pointerEnter)
		{
			CheckPointerHoverClick(pointer, results);
			if (!ValidElement(pointer.pointerEventData.pointerEnter))
			{
				pointer.pointerEventData.pointerEnter = null;
				return;
			}
			if (NoValidCollision(pointer, results))
			{
				ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerEnter, pointer.pointerEventData, ExecuteEvents.pointerExitHandler);
				pointer.pointerEventData.hovered.Remove(pointer.pointerEventData.pointerEnter);
				pointer.pointerEventData.pointerEnter = null;
			}
			if (results.Count <= 0 || !(pointer.pointerEventData.pointerEnter != results[0].gameObject))
			{
				return;
			}
			{
				foreach (RaycastResult result in results)
				{
					if (!ValidElement(result.gameObject))
					{
						continue;
					}
					GameObject gameObject = ExecuteEvents.ExecuteHierarchy(result.gameObject, pointer.pointerEventData, ExecuteEvents.pointerEnterHandler);
					if (gameObject != null)
					{
						Selectable component = gameObject.GetComponent<Selectable>();
						if ((bool)component)
						{
							Navigation navigation = default(Navigation);
							navigation.mode = Navigation.Mode.None;
							component.navigation = navigation;
						}
						pointer.pointerEventData.hovered.Remove(pointer.pointerEventData.pointerEnter);
						pointer.OnUIPointerElementEnter(pointer.SetUIPointerEvent(result, gameObject, pointer.hoveringElement));
						pointer.hoveringElement = gameObject;
						pointer.pointerEventData.pointerCurrentRaycast = result;
						pointer.pointerEventData.pointerEnter = gameObject;
						pointer.pointerEventData.hovered.Add(pointer.pointerEventData.pointerEnter);
						break;
					}
					if (result.gameObject != pointer.hoveringElement)
					{
						pointer.OnUIPointerElementEnter(pointer.SetUIPointerEvent(result, result.gameObject, pointer.hoveringElement));
					}
					pointer.hoveringElement = result.gameObject;
				}
				return;
			}
		}
		foreach (RaycastResult result2 in results)
		{
			if (!ValidElement(result2.gameObject))
			{
				continue;
			}
			GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy(result2.gameObject, pointer.pointerEventData, ExecuteEvents.pointerEnterHandler);
			if (gameObject2 != null)
			{
				Selectable component2 = gameObject2.GetComponent<Selectable>();
				if ((bool)component2)
				{
					Navigation navigation2 = default(Navigation);
					navigation2.mode = Navigation.Mode.None;
					component2.navigation = navigation2;
				}
				pointer.OnUIPointerElementEnter(pointer.SetUIPointerEvent(result2, gameObject2, pointer.hoveringElement));
				pointer.hoveringElement = gameObject2;
				pointer.pointerEventData.pointerCurrentRaycast = result2;
				pointer.pointerEventData.pointerEnter = gameObject2;
				pointer.pointerEventData.hovered.Add(pointer.pointerEventData.pointerEnter);
				break;
			}
			if (result2.gameObject != pointer.hoveringElement)
			{
				pointer.OnUIPointerElementEnter(pointer.SetUIPointerEvent(result2, result2.gameObject, pointer.hoveringElement));
			}
			pointer.hoveringElement = result2.gameObject;
		}
		if ((bool)pointer.hoveringElement && results.Count == 0)
		{
			pointer.OnUIPointerElementExit(pointer.SetUIPointerEvent(default(RaycastResult), null, pointer.hoveringElement));
			pointer.hoveringElement = null;
		}
	}

	protected virtual void Click(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		switch (pointer.clickMethod)
		{
		case Pvr_UIPointer.ClickMethods.ClickOnButtonUp:
			ClickOnUp(pointer, results);
			break;
		case Pvr_UIPointer.ClickMethods.ClickOnButtonDown:
			ClickOnDown(pointer, results);
			break;
		}
	}

	protected virtual void ClickOnUp(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		pointer.pointerEventData.eligibleForClick = pointer.ValidClick(checkLastClick: false);
		if (!AttemptClick(pointer))
		{
			IsEligibleClick(pointer, results);
		}
	}

	protected virtual void ClickOnDown(Pvr_UIPointer pointer, List<RaycastResult> results, bool forceClick = false)
	{
		pointer.pointerEventData.eligibleForClick = forceClick || pointer.ValidClick(checkLastClick: true);
		if (IsEligibleClick(pointer, results))
		{
			pointer.pointerEventData.eligibleForClick = false;
			AttemptClick(pointer);
		}
	}

	protected virtual bool IsEligibleClick(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		if (pointer.pointerEventData.eligibleForClick)
		{
			foreach (RaycastResult result in results)
			{
				if (ValidElement(result.gameObject))
				{
					GameObject gameObject = ExecuteEvents.ExecuteHierarchy(result.gameObject, pointer.pointerEventData, ExecuteEvents.pointerDownHandler);
					if (gameObject != null)
					{
						pointer.pointerEventData.pressPosition = pointer.pointerEventData.position;
						pointer.pointerEventData.pointerPressRaycast = result;
						pointer.pointerEventData.pointerPress = gameObject;
						return true;
					}
				}
			}
		}
		return false;
	}

	protected virtual bool AttemptClick(Pvr_UIPointer pointer)
	{
		if ((bool)pointer.pointerEventData.pointerPress)
		{
			if (!ValidElement(pointer.pointerEventData.pointerPress))
			{
				pointer.pointerEventData.pointerPress = null;
				return true;
			}
			if (pointer.pointerEventData.eligibleForClick)
			{
				if (!IsHovering(pointer))
				{
					ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerPress, pointer.pointerEventData, ExecuteEvents.pointerUpHandler);
					pointer.pointerEventData.pointerPress = null;
				}
			}
			else
			{
				pointer.OnUIPointerElementClick(pointer.SetUIPointerEvent(pointer.pointerEventData.pointerPressRaycast, pointer.pointerEventData.pointerPress));
				ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerPress, pointer.pointerEventData, ExecuteEvents.pointerClickHandler);
				ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerPress, pointer.pointerEventData, ExecuteEvents.pointerUpHandler);
				pointer.pointerEventData.pointerPress = null;
			}
			return true;
		}
		return false;
	}

	protected virtual void Drag(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		pointer.pointerEventData.dragging = pointer.IsSelectionButtonPressed() && pointer.pointerEventData.delta != Vector2.zero;
		if ((bool)pointer.pointerEventData.pointerDrag)
		{
			if (!ValidElement(pointer.pointerEventData.pointerDrag))
			{
				pointer.pointerEventData.pointerDrag = null;
				return;
			}
			if (pointer.pointerEventData.dragging)
			{
				if (IsHovering(pointer))
				{
					ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerDrag, pointer.pointerEventData, ExecuteEvents.dragHandler);
				}
				return;
			}
			ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerDrag, pointer.pointerEventData, ExecuteEvents.dragHandler);
			ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerDrag, pointer.pointerEventData, ExecuteEvents.endDragHandler);
			foreach (RaycastResult result in results)
			{
				ExecuteEvents.ExecuteHierarchy(result.gameObject, pointer.pointerEventData, ExecuteEvents.dropHandler);
			}
			pointer.pointerEventData.pointerDrag = null;
		}
		else
		{
			if (!pointer.pointerEventData.dragging)
			{
				return;
			}
			foreach (RaycastResult result2 in results)
			{
				if (ValidElement(result2.gameObject))
				{
					ExecuteEvents.ExecuteHierarchy(result2.gameObject, pointer.pointerEventData, ExecuteEvents.initializePotentialDrag);
					ExecuteEvents.ExecuteHierarchy(result2.gameObject, pointer.pointerEventData, ExecuteEvents.beginDragHandler);
					GameObject gameObject = ExecuteEvents.ExecuteHierarchy(result2.gameObject, pointer.pointerEventData, ExecuteEvents.dragHandler);
					if (gameObject != null)
					{
						pointer.pointerEventData.pointerDrag = gameObject;
						break;
					}
				}
			}
		}
	}
}
public class Pvr_UICanvas : MonoBehaviour
{
	public bool clickOnPointerCollision;

	public float autoActivateWithinDistance;

	protected BoxCollider canvasBoxCollider;

	protected Rigidbody canvasRigidBody;

	protected Coroutine draggablePanelCreation;

	protected const string CANVAS_DRAGGABLE_PANEL = "UICANVAS_DRAGGABLE_PANEL";

	protected virtual void OnEnable()
	{
		SetupCanvas();
	}

	protected virtual void OnDisable()
	{
		RemoveCanvas();
	}

	protected virtual void OnDestroy()
	{
		RemoveCanvas();
	}

	protected virtual void SetupCanvas()
	{
		Canvas component = GetComponent<Canvas>();
		if ((bool)component && component.renderMode == RenderMode.WorldSpace)
		{
			RectTransform component2 = component.GetComponent<RectTransform>();
			Vector2 sizeDelta = component2.sizeDelta;
			GraphicRaycaster component3 = component.gameObject.GetComponent<GraphicRaycaster>();
			Pvr_UIGraphicRaycaster pvr_UIGraphicRaycaster = component.gameObject.GetComponent<Pvr_UIGraphicRaycaster>();
			if (!pvr_UIGraphicRaycaster)
			{
				pvr_UIGraphicRaycaster = component.gameObject.AddComponent<Pvr_UIGraphicRaycaster>();
			}
			if ((bool)component3 && component3.enabled)
			{
				pvr_UIGraphicRaycaster.ignoreReversedGraphics = component3.ignoreReversedGraphics;
				pvr_UIGraphicRaycaster.blockingObjects = component3.blockingObjects;
				component3.enabled = false;
			}
			if (!component.gameObject.GetComponent<BoxCollider>())
			{
				float z = 0.1f / component2.localScale.z;
				canvasBoxCollider = component.gameObject.AddComponent<BoxCollider>();
				canvasBoxCollider.size = new Vector3(sizeDelta.x, sizeDelta.y, z);
				canvasBoxCollider.isTrigger = true;
			}
			if (!component.gameObject.GetComponent<Rigidbody>())
			{
				canvasRigidBody = component.gameObject.AddComponent<Rigidbody>();
				canvasRigidBody.isKinematic = true;
			}
			draggablePanelCreation = StartCoroutine(CreateDraggablePanel(component, sizeDelta));
		}
	}

	protected virtual IEnumerator CreateDraggablePanel(Canvas canvas, Vector2 canvasSize)
	{
		if ((bool)canvas && !canvas.transform.Find("UICANVAS_DRAGGABLE_PANEL"))
		{
			yield return null;
			GameObject obj = new GameObject("UICANVAS_DRAGGABLE_PANEL", typeof(RectTransform));
			obj.AddComponent<LayoutElement>().ignoreLayout = true;
			obj.AddComponent<Image>().color = Color.clear;
			obj.AddComponent<EventTrigger>();
			obj.transform.SetParent(canvas.transform);
			obj.GetComponent<RectTransform>().sizeDelta = canvasSize;
			obj.transform.localPosition = Vector3.zero;
			obj.transform.localRotation = Quaternion.identity;
			obj.transform.localScale = Vector3.one;
			obj.transform.SetAsFirstSibling();
		}
	}

	protected virtual void RemoveCanvas()
	{
		Canvas component = GetComponent<Canvas>();
		if ((bool)component)
		{
			GraphicRaycaster component2 = component.gameObject.GetComponent<GraphicRaycaster>();
			Pvr_UIGraphicRaycaster component3 = component.gameObject.GetComponent<Pvr_UIGraphicRaycaster>();
			if ((bool)component3)
			{
				UnityEngine.Object.Destroy(component3);
			}
			if ((bool)component2 && !component2.enabled)
			{
				component2.enabled = true;
			}
			if ((bool)canvasBoxCollider)
			{
				UnityEngine.Object.Destroy(canvasBoxCollider);
			}
			if ((bool)canvasRigidBody)
			{
				UnityEngine.Object.Destroy(canvasRigidBody);
			}
			StopCoroutine(draggablePanelCreation);
			Transform transform = component.transform.Find("UICANVAS_DRAGGABLE_PANEL");
			if ((bool)transform)
			{
				UnityEngine.Object.Destroy(transform.gameObject);
			}
		}
	}
}
public struct UIDraggableItemEventArgs
{
	public GameObject target;
}
public delegate void UIDraggableItemEventHandler(object sender, UIDraggableItemEventArgs e);
public class Pvr_UIDraggableItem : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	public bool restrictToDropZone;

	public bool restrictToOriginalCanvas;

	public float moveOffset = 0.1f;

	[HideInInspector]
	public GameObject validDropZone;

	protected RectTransform dragTransform;

	protected Vector3 startPosition;

	protected Quaternion startRotation;

	protected GameObject startDropZone;

	protected Transform startParent;

	protected Canvas startCanvas;

	protected CanvasGroup canvasGroup;

	protected Pvr_InputModule currentInputmodule;

	public event UIDraggableItemEventHandler DraggableItemDropped;

	public event UIDraggableItemEventHandler DraggableItemReset;

	public virtual void OnDraggableItemDropped(UIDraggableItemEventArgs e)
	{
		if (this.DraggableItemDropped != null)
		{
			this.DraggableItemDropped(this, e);
		}
	}

	public virtual void OnDraggableItemReset(UIDraggableItemEventArgs e)
	{
		if (this.DraggableItemReset != null)
		{
			this.DraggableItemReset(this, e);
		}
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		startPosition = base.transform.position;
		startRotation = base.transform.rotation;
		startParent = base.transform.parent;
		startCanvas = GetComponentInParent<Canvas>();
		canvasGroup.blocksRaycasts = false;
		if (restrictToDropZone)
		{
			startDropZone = GetComponentInParent<Pvr_UIDropZone>().gameObject;
			validDropZone = startDropZone;
		}
		SetDragPosition(eventData);
		Pvr_UIPointer pointer = GetPointer();
		if (pointer != null)
		{
			pointer.OnUIPointerElementDragStart(pointer.SetUIPointerEvent(pointer.pointerEventData.pointerPressRaycast, base.gameObject));
		}
	}

	public void OnDrag(PointerEventData eventData)
	{
		SetDragPosition(eventData);
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		canvasGroup.blocksRaycasts = true;
		dragTransform = null;
		base.transform.position += base.transform.forward * moveOffset;
		bool flag = true;
		if (restrictToDropZone)
		{
			if (validDropZone != null && validDropZone != startDropZone)
			{
				base.transform.SetParent(validDropZone.transform);
			}
			else
			{
				ResetElement();
				flag = false;
			}
		}
		Canvas canvas = ((eventData.pointerEnter != null) ? eventData.pointerEnter.GetComponentInParent<Canvas>() : null);
		if (restrictToOriginalCanvas && canvas != null && canvas != startCanvas)
		{
			ResetElement();
			flag = false;
		}
		if (canvas == null)
		{
			ResetElement();
			flag = false;
		}
		if (flag)
		{
			Pvr_UIPointer pointer = GetPointer();
			if (pointer != null)
			{
				pointer.OnUIPointerElementDragEnd(pointer.SetUIPointerEvent(pointer.pointerEventData.pointerPressRaycast, base.gameObject));
			}
			OnDraggableItemDropped(SetEventPayload(validDropZone));
		}
		validDropZone = null;
		startParent = null;
		startCanvas = null;
	}

	protected virtual void OnEnable()
	{
		canvasGroup = GetComponent<CanvasGroup>();
		if (restrictToDropZone && GetComponentInParent<Pvr_UIDropZone>() == null)
		{
			base.enabled = false;
		}
		currentInputmodule = UnityEngine.Object.FindObjectOfType<Pvr_InputModule>();
	}

	protected virtual Pvr_UIPointer GetPointer()
	{
		foreach (Pvr_UIPointer pointer in Pvr_InputModule.pointers)
		{
			if (pointer.gameObject.activeInHierarchy && (bool)pointer)
			{
				return pointer;
			}
		}
		return null;
	}

	protected virtual void SetDragPosition(PointerEventData eventData)
	{
		if (eventData.pointerEnter != null && eventData.pointerEnter.transform as RectTransform != null)
		{
			dragTransform = eventData.pointerEnter.transform as RectTransform;
		}
		if (dragTransform != null && RectTransformUtility.ScreenPointToWorldPointInRectangle(dragTransform, eventData.position, eventData.pressEventCamera, out var worldPoint))
		{
			base.transform.position = worldPoint - base.transform.forward * moveOffset;
			base.transform.rotation = dragTransform.rotation;
		}
	}

	protected virtual void ResetElement()
	{
		base.transform.position = startPosition;
		base.transform.rotation = startRotation;
		base.transform.SetParent(startParent);
		OnDraggableItemReset(SetEventPayload(startParent.gameObject));
	}

	protected virtual UIDraggableItemEventArgs SetEventPayload(GameObject target)
	{
		UIDraggableItemEventArgs result = default(UIDraggableItemEventArgs);
		result.target = target;
		return result;
	}
}
public class Pvr_UIDropZone : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	protected Pvr_UIDraggableItem droppableItem;

	public void OnPointerEnter(PointerEventData eventData)
	{
		if ((bool)eventData.pointerDrag)
		{
			Pvr_UIDraggableItem component = eventData.pointerDrag.GetComponent<Pvr_UIDraggableItem>();
			if ((bool)component && component.restrictToDropZone)
			{
				component.validDropZone = base.gameObject;
				droppableItem = component;
			}
		}
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		if ((bool)droppableItem)
		{
			droppableItem.validDropZone = null;
		}
		droppableItem = null;
	}
}
public class Pvr_UIGraphicRaycaster : GraphicRaycaster
{
	protected Canvas currentCanvas;

	protected Vector2 lastKnownPosition;

	protected const float UI_CONTROL_OFFSET = 1E-05f;

	[NonSerialized]
	private static List<RaycastResult> s_RaycastResults = new List<RaycastResult>();

	protected virtual Canvas canvas
	{
		get
		{
			if (currentCanvas != null)
			{
				return currentCanvas;
			}
			currentCanvas = base.gameObject.GetComponent<Canvas>();
			return currentCanvas;
		}
	}

	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
		if (!(canvas == null))
		{
			Raycast(ray: new Ray(eventData.pointerCurrentRaycast.worldPosition, eventData.pointerCurrentRaycast.worldNormal), canvas: canvas, eventCamera: eventCamera, results: ref s_RaycastResults);
			SetNearestRaycast(ref eventData, ref resultAppendList, ref s_RaycastResults);
			s_RaycastResults.Clear();
		}
	}

	protected virtual void SetNearestRaycast(ref PointerEventData eventData, ref List<RaycastResult> resultAppendList, ref List<RaycastResult> raycastResults)
	{
		RaycastResult? raycastResult = null;
		for (int i = 0; i < raycastResults.Count; i++)
		{
			RaycastResult raycastResult2 = raycastResults[i];
			raycastResult2.index = resultAppendList.Count;
			if (!raycastResult.HasValue || raycastResult2.distance < raycastResult.Value.distance)
			{
				raycastResult = raycastResult2;
			}
			resultAppendList.Add(raycastResult2);
		}
		if (raycastResult.HasValue)
		{
			eventData.position = raycastResult.Value.screenPosition;
			eventData.delta = eventData.position - lastKnownPosition;
			lastKnownPosition = eventData.position;
			eventData.pointerCurrentRaycast = raycastResult.Value;
		}
	}

	protected virtual float GetHitDistance(Ray ray)
	{
		float result = float.MaxValue;
		if (canvas.renderMode != 0 && base.blockingObjects != 0)
		{
			float num = Vector3.Distance(ray.origin, canvas.transform.position);
			if (base.blockingObjects == BlockingObjects.ThreeD || base.blockingObjects == BlockingObjects.All)
			{
				Physics.Raycast(ray, out var hitInfo, num);
				if ((bool)hitInfo.collider)
				{
					result = hitInfo.distance;
				}
			}
			if (base.blockingObjects == BlockingObjects.TwoD || base.blockingObjects == BlockingObjects.All)
			{
				RaycastHit2D raycastHit2D = Physics2D.Raycast(ray.origin, ray.direction, num);
				if (raycastHit2D.collider != null)
				{
					result = raycastHit2D.fraction * num;
				}
			}
		}
		return result;
	}

	protected virtual void Raycast(Canvas canvas, Camera eventCamera, Ray ray, ref List<RaycastResult> results)
	{
		float hitDistance = GetHitDistance(ray);
		IList<Graphic> graphicsForCanvas = GraphicRegistry.GetGraphicsForCanvas(canvas);
		for (int i = 0; i < graphicsForCanvas.Count; i++)
		{
			Graphic graphic = graphicsForCanvas[i];
			if (graphic.depth == -1 || !graphic.raycastTarget)
			{
				continue;
			}
			Transform transform = graphic.transform;
			Vector3 forward = transform.forward;
			float num = Vector3.Dot(forward, transform.position - ray.origin) / Vector3.Dot(forward, ray.direction);
			if (!(num < 0f) && !(num - 1E-05f > hitDistance))
			{
				Vector3 point = ray.GetPoint(num);
				Vector2 vector = eventCamera.WorldToScreenPoint(point);
				if (RectTransformUtility.RectangleContainsScreenPoint(graphic.rectTransform, vector, eventCamera) && graphic.Raycast(vector, eventCamera))
				{
					RaycastResult raycastResult = default(RaycastResult);
					raycastResult.gameObject = graphic.gameObject;
					raycastResult.module = this;
					raycastResult.distance = num;
					raycastResult.screenPosition = vector;
					raycastResult.worldPosition = point;
					raycastResult.depth = graphic.depth;
					raycastResult.sortingLayer = canvas.sortingLayerID;
					raycastResult.sortingOrder = canvas.sortingOrder;
					RaycastResult item = raycastResult;
					results.Add(item);
				}
			}
		}
		results.Sort((RaycastResult g1, RaycastResult g2) => g2.depth.CompareTo(g1.depth));
	}
}
public struct UIPointerEventArgs
{
	public bool isActive;

	public GameObject currentTarget;

	public GameObject previousTarget;

	public RaycastResult raycastResult;
}
public delegate void UIPointerEventHandler(object sender, UIPointerEventArgs e);
public class Pvr_UIPointer : MonoBehaviour
{
	public enum ClickMethods
	{
		ClickOnButtonUp,
		ClickOnButtonDown
	}

	public ClickMethods clickMethod;

	[HideInInspector]
	public bool collisionClick;

	[HideInInspector]
	public bool pressToDrag;

	[HideInInspector]
	public GameObject autoActivatingCanvas;

	[HideInInspector]
	public PointerEventData pointerEventData;

	[HideInInspector]
	public GameObject hoveringElement;

	[HideInInspector]
	public float hoverDurationTimer;

	[HideInInspector]
	public bool canClickOnHover;

	public Transform pointerOriginTransform;

	protected bool pointerClicked;

	protected bool beamEnabledState;

	protected bool lastPointerPressState;

	protected bool lastPointerClickState;

	protected GameObject currentTarget;

	protected EventSystem cachedEventSystem;

	protected Pvr_InputModule cachedVRInputModule;

	protected Transform originalPointerOriginTransform;

	public static bool TouchBtnValue;

	public static bool AppBtnValue;

	public static bool TriggerBtnValue;

	public event UIPointerEventHandler UIPointerElementEnter;

	public event UIPointerEventHandler UIPointerElementExit;

	public event UIPointerEventHandler UIPointerElementClick;

	public event UIPointerEventHandler UIPointerElementDragStart;

	public event UIPointerEventHandler UIPointerElementDragEnd;

	public virtual bool PointerActive()
	{
		return true;
	}

	public virtual bool IsSelectionButtonPressed()
	{
		if (!Input.GetMouseButton(0) && !Input.GetKey(KeyCode.JoystickButton0) && !TouchBtnValue && !AppBtnValue)
		{
			return TriggerBtnValue;
		}
		return true;
	}

	public virtual Vector3 GetOriginPosition()
	{
		if (!pointerOriginTransform)
		{
			return base.transform.position;
		}
		return pointerOriginTransform.position;
	}

	public virtual Vector3 GetOriginForward()
	{
		if (!pointerOriginTransform)
		{
			return base.transform.forward;
		}
		return pointerOriginTransform.forward;
	}

	public virtual bool ValidClick(bool checkLastClick, bool lastClickState = false)
	{
		bool result = (collisionClick ? collisionClick : IsSelectionButtonPressed());
		if (!checkLastClick)
		{
			return result;
		}
		return result;
	}

	protected virtual void ResetHoverTimer()
	{
		hoverDurationTimer = 0f;
		canClickOnHover = false;
	}

	public virtual void OnUIPointerElementEnter(UIPointerEventArgs e)
	{
		if (e.currentTarget != currentTarget)
		{
			ResetHoverTimer();
		}
		currentTarget = e.currentTarget;
		if (this.UIPointerElementEnter != null)
		{
			this.UIPointerElementEnter(this, e);
		}
	}

	public virtual void OnUIPointerElementExit(UIPointerEventArgs e)
	{
		if (e.previousTarget == currentTarget)
		{
			ResetHoverTimer();
		}
		if (this.UIPointerElementExit != null)
		{
			this.UIPointerElementExit(this, e);
		}
	}

	public virtual void OnUIPointerElementClick(UIPointerEventArgs e)
	{
		if (e.currentTarget == currentTarget)
		{
			ResetHoverTimer();
		}
		if (this.UIPointerElementClick != null)
		{
			this.UIPointerElementClick(this, e);
		}
	}

	public virtual void OnUIPointerElementDragStart(UIPointerEventArgs e)
	{
		if (this.UIPointerElementDragStart != null)
		{
			this.UIPointerElementDragStart(this, e);
		}
	}

	public virtual void OnUIPointerElementDragEnd(UIPointerEventArgs e)
	{
		if (this.UIPointerElementDragEnd != null)
		{
			this.UIPointerElementDragEnd(this, e);
		}
	}

	public virtual UIPointerEventArgs SetUIPointerEvent(RaycastResult currentRaycastResult, GameObject currentTarget, GameObject lastTarget = null)
	{
		UIPointerEventArgs result = default(UIPointerEventArgs);
		result.isActive = PointerActive();
		result.currentTarget = currentTarget;
		result.previousTarget = lastTarget;
		result.raycastResult = currentRaycastResult;
		return result;
	}

	protected virtual void Awake()
	{
		originalPointerOriginTransform = pointerOriginTransform;
	}

	protected virtual void OnEnable()
	{
		pointerOriginTransform = originalPointerOriginTransform;
		ConfigureEventSystem();
		pointerClicked = false;
		lastPointerPressState = false;
		lastPointerClickState = false;
		beamEnabledState = false;
	}

	protected virtual void OnDisable()
	{
		Pvr_InputModule.RemovePoint(this);
	}

	protected virtual void ConfigureEventSystem()
	{
		if (!cachedEventSystem)
		{
			cachedEventSystem = UnityEngine.Object.FindObjectOfType<EventSystem>();
		}
		if (!cachedVRInputModule)
		{
			cachedVRInputModule = cachedEventSystem.GetComponent<Pvr_InputModule>();
		}
		if ((bool)cachedEventSystem && (bool)cachedVRInputModule && pointerEventData == null)
		{
			pointerEventData = new PointerEventData(cachedEventSystem);
		}
		Pvr_InputModule.AddPoint(this);
	}
}
[ExecuteInEditMode]
public class Pvr_UnitySDKEditor : MonoBehaviour
{
	private bool vrModeEnabled = true;

	private float mouseX;

	private float mouseY;

	private float mouseZ;

	private float neckModelScale;

	private bool autoUntiltHead;

	private static readonly Vector3 neckOffset = new Vector3(0f, 0.075f, 0.0805f);

	[HideInInspector]
	public Matrix4x4 headView;

	[HideInInspector]
	public Matrix4x4 leftEyeUndistortedProj;

	[HideInInspector]
	public Matrix4x4 rightEyeUndistortedProj;

	[HideInInspector]
	public Matrix4x4 leftEyeProj;

	[HideInInspector]
	public Matrix4x4 rightEyeProj;

	private const float TOUCH_TIME_LIMIT = 0.2f;

	private float touchStartTime;

	public Matrix4x4 UndistortedProjection(Eye eye)
	{
		if (eye != 0)
		{
			return rightEyeUndistortedProj;
		}
		return leftEyeUndistortedProj;
	}

	public Matrix4x4 Projection(Eye eye)
	{
		if (eye != 0)
		{
			return rightEyeProj;
		}
		return leftEyeProj;
	}

	private void Awake()
	{
		InitEyePara();
		InitEditorSensorPara();
	}

	private void Update()
	{
		SimulateInput();
		Pvr_UnitySDKManager.SDK.picovrTriggered = Pvr_UnitySDKManager.SDK.newPicovrTriggered;
		Pvr_UnitySDKManager.SDK.newPicovrTriggered = false;
	}

	public void InitEyePara()
	{
		ComputeEyesFromProfile();
		InitForEye(ref Pvr_UnitySDKManager.SDK.Eyematerial, ref Pvr_UnitySDKManager.SDK.Middlematerial);
		if (Pvr_UnitySDKRender.Instance == null)
		{
			PLOG.I("pvr_UnitySDKRender init failed");
		}
		if (Pvr_UnitySDKSensor.Instance == null)
		{
			PLOG.I("pvr_UnitySDKSensor init failed");
		}
		FovAdjust();
	}

	private void InitEditorSensorPara()
	{
		Pvr_UnitySDKManager.SDK.picovrTriggered = Pvr_UnitySDKManager.SDK.newPicovrTriggered;
		Pvr_UnitySDKManager.SDK.newPicovrTriggered = false;
	}

	public static Matrix4x4 MakeProjection(float l, float t, float r, float b, float n, float f)
	{
		Matrix4x4 zero = Matrix4x4.zero;
		zero[0, 0] = 2f * n / (r - l);
		zero[1, 1] = 2f * n / (t - b);
		zero[0, 2] = (r + l) / (r - l);
		zero[1, 2] = (t + b) / (t - b);
		zero[2, 2] = (n + f) / (n - f);
		zero[2, 3] = 2f * n * f / (n - f);
		zero[3, 2] = -1f;
		return zero;
	}

	public bool UpdateStatesensor()
	{
		UpdateSimulatedSensor();
		return true;
	}

	public void ComputeEyesFromProfile()
	{
		Vector2 vector = new Vector2(0.11f, 0.062f);
		Pvr_UnitySDKManager.SDK.leftEyeView = Matrix4x4.identity;
		Pvr_UnitySDKManager.SDK.leftEyeView[0, 3] = (0f - Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.device.devLenses.separation) / 2f;
		float[] leftEyeVisibleTanAngles = Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.GetLeftEyeVisibleTanAngles(vector.x, vector.y);
		leftEyeProj = MakeProjection(leftEyeVisibleTanAngles[0], leftEyeVisibleTanAngles[1], leftEyeVisibleTanAngles[2], leftEyeVisibleTanAngles[3], 1f, 1000f);
		leftEyeVisibleTanAngles = Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.GetLeftEyeNoLensTanAngles(vector.x, vector.y);
		leftEyeUndistortedProj = MakeProjection(leftEyeVisibleTanAngles[0], leftEyeVisibleTanAngles[1], leftEyeVisibleTanAngles[2], leftEyeVisibleTanAngles[3], 1f, 1000f);
		Pvr_UnitySDKManager.SDK.leftEyeRect = Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.GetLeftEyeVisibleScreenRect(leftEyeVisibleTanAngles, vector.x, vector.y);
		Pvr_UnitySDKManager.SDK.rightEyeView = Pvr_UnitySDKManager.SDK.leftEyeView;
		Pvr_UnitySDKManager.SDK.rightEyeView[0, 3] *= -1f;
		rightEyeProj = leftEyeProj;
		rightEyeProj[0, 2] *= -1f;
		rightEyeUndistortedProj = leftEyeUndistortedProj;
		rightEyeUndistortedProj[0, 2] *= -1f;
		Rect leftEyeRect = new Rect(0f, 0f, 0.5f, 1f);
		Rect rightEyeRect = new Rect(0.5f, 0f, 0.5f, 1f);
		Pvr_UnitySDKManager.SDK.leftEyeRect = leftEyeRect;
		Pvr_UnitySDKManager.SDK.rightEyeRect = rightEyeRect;
		Pvr_UnitySDKManager.SDK.leftEyeOffset = new Vector3((0f - Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.device.devLenses.separation) / 2f, 0f, 0f);
		Pvr_UnitySDKManager.SDK.rightEyeOffset = new Vector3(Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.device.devLenses.separation / 2f, 0f, 0f);
	}

	public bool ResetUnitySDKSensor()
	{
		mouseX = (mouseY = (mouseZ = 0f));
		return true;
	}

	private void SimulateInput()
	{
		if (Input.GetMouseButtonDown(0) && (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt)))
		{
			EnableVEmodel();
		}
		if (Input.GetMouseButtonDown(0))
		{
			touchStartTime = Time.time;
		}
		else if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - touchStartTime <= 0.2f)
			{
				Pvr_UnitySDKManager.SDK.newPicovrTriggered = true;
			}
			touchStartTime = 0f;
		}
		UpdateSimulatedSensor();
	}

	private void FovAdjust()
	{
		Pvr_UnitySDKRender.Instance.EyeVFoV = 2f * Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.device.devMaxFov.upper;
	}

	private Rect RectAdjust(Rect eyeRect)
	{
		Rect result = new Rect(0f, 0f, 0.5f, 1f);
		result.width *= 2f * eyeRect.width;
		result.x = eyeRect.x + 2f * result.x * eyeRect.width;
		result.height *= eyeRect.height;
		result.y = eyeRect.y + result.y * eyeRect.height;
		return result;
	}

	private void UpdateSimulatedSensor()
	{
		bool flag = false;
		if (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt))
		{
			mouseX += Input.GetAxis("Mouse X") * 5f;
			if (mouseX <= -180f)
			{
				mouseX += 360f;
			}
			else if (mouseX > 180f)
			{
				mouseX -= 360f;
			}
			mouseY -= Input.GetAxis("Mouse Y") * 2.4f;
			mouseY = Mathf.Clamp(mouseY, -91f, 91f);
		}
		else if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
		{
			flag = true;
			mouseZ += Input.GetAxis("Mouse X") * 5f;
			mouseZ = Mathf.Clamp(mouseZ, -91f, 91f);
		}
		if (!flag && autoUntiltHead)
		{
			mouseZ = Mathf.Lerp(mouseZ, 0f, Time.deltaTime / (Time.deltaTime + 0.1f));
		}
		Quaternion quaternion = Quaternion.Euler(mouseY, mouseX, mouseZ);
		Matrix4x4 matrix = Matrix4x4.TRS((quaternion * neckOffset - neckOffset.y * Vector3.up) * neckModelScale, quaternion, Vector3.one);
		Pvr_UnitySDKSensor.Instance.HeadPose = new Pvr_UnitySDKPose(matrix);
	}

	private void InitForEye(ref Material mat, ref Material mat1)
	{
		Shader shader = Shader.Find("Pvr_UnitySDK/Undistortion");
		Shader shader2 = Shader.Find("Pvr_UnitySDK/FillColor");
		if (shader == null || shader2 == null)
		{
			PLOG.E("Ths Shader Missing ！");
			return;
		}
		mat = new Material(shader);
		mat1 = new Material(shader2);
	}

	private void EnableVEmodel()
	{
		vrModeEnabled = !vrModeEnabled;
		Pvr_UnitySDKManager.SDK.VRModeEnabled = vrModeEnabled;
	}
}
public class Pvr_VolumePowerBrightness : MonoBehaviour
{
	private bool VolEnable;

	private bool BattEnable;

	public Text showResult;

	public Text setVolumnum;

	public Text setBrightnum;

	public string MusicPath;

	private void Awake()
	{
		InitBatteryVolClass();
		string startreceivre = base.gameObject.name;
		StartBatteryReceiver(startreceivre);
		StartAudioReceiver(startreceivre);
	}

	private void OnDisable()
	{
		if (VolEnable)
		{
			StopAudioReceiver();
		}
		if (BattEnable)
		{
			StopBatteryReceiver();
		}
	}

	public void GetMaxVolumeNumber()
	{
		int num = 0;
		num = VolumePowerBrightness.UPvr_GetMaxVolumeNumber();
		showResult.text = "Maximum volume: " + num;
	}

	public void GetCurrentVolumeNumber()
	{
		int num = 0;
		num = VolumePowerBrightness.UPvr_GetCurrentVolumeNumber();
		showResult.text = "Current volume：" + num;
	}

	public void VolumeUp()
	{
		if (!VolumePowerBrightness.UPvr_VolumeUp())
		{
			PLOG.E("VolumeUp Error");
		}
	}

	public void VolumeDown()
	{
		if (!VolumePowerBrightness.UPvr_VolumeDown())
		{
			PLOG.E("VolumeDown Error");
		}
	}

	public void SetVolumeNum()
	{
		int volume = new System.Random().Next(0, 15);
		setVolumnum.text = "Random number：" + volume;
		if (!VolumePowerBrightness.UPvr_SetVolumeNum(volume))
		{
			PLOG.E("SetVolumeNum Error");
		}
	}

	public void SetBrightness()
	{
		int brightness = new System.Random().Next(0, 255);
		setBrightnum.text = "Random number：" + brightness;
		if (!VolumePowerBrightness.UPvr_SetCommonBrightness(brightness))
		{
			PLOG.E("SetBrightness Error");
		}
	}

	public void GetCurrentBrightness()
	{
		int num = 0;
		num = VolumePowerBrightness.UPvr_GetCommonBrightness();
		showResult.text = "Current brightness：" + num;
	}

	public bool setAudio(string s)
	{
		PLOG.I(s.ToString());
		return true;
	}

	public bool setBattery(string s)
	{
		PLOG.I(s.ToString());
		return true;
	}

	private bool InitBatteryVolClass()
	{
		return VolumePowerBrightness.UPvr_InitBatteryVolClass();
	}

	private bool StartBatteryReceiver(string startreceivre)
	{
		BattEnable = VolumePowerBrightness.UPvr_StartBatteryReceiver(startreceivre);
		return BattEnable;
	}

	private bool StopBatteryReceiver()
	{
		return VolumePowerBrightness.UPvr_StopBatteryReceiver();
	}

	private bool StartAudioReceiver(string startreceivre)
	{
		VolEnable = VolumePowerBrightness.UPvr_StartAudioReceiver(startreceivre);
		return VolEnable;
	}

	private bool StopAudioReceiver()
	{
		return VolumePowerBrightness.UPvr_StopAudioReceiver();
	}
}
public class AxisCheck : MonoBehaviour
{
	public Container symbolContainer;

	private Container axisContainer;

	private List<Transform> objs;

	private void Awake()
	{
		axisContainer = GetComponent<Container>();
		Container container = axisContainer;
		container.onEnter = (Action<Collider>)Delegate.Combine(container.onEnter, new Action<Collider>(CheckNewObject));
	}

	private void Start()
	{
		objs = new List<Transform>();
	}

	private void CheckNewObject(Collider other)
	{
		if (symbolContainer.GetComponent<Container>().GetObjects().Count != 0)
		{
			string symbol = symbolContainer.GetComponent<Container>().GetObjects()[0].name;
			Transform obj = axisContainer.GetObjects()[axisContainer.GetObjects().Count - 1];
			SortByX();
			CheckOrder(obj, symbol);
		}
	}

	private void CheckOrder(Transform obj, string symbol)
	{
		int num = objs.IndexOf(obj);
		if (symbol.Equals(Symbol.LT.ToString()))
		{
			if (num != objs.Count - 1 && obj.GetComponent<Rigidbody>().mass > objs[num + 1].GetComponent<Rigidbody>().mass)
			{
				MonoSingleton<Instructions>.Instance().SetText("这个物体比右边的轻吗？再用天平比较一下吧，按从轻到重的顺序排序。");
				MonoSingleton<VoiceMgr>.Instance().PlayVoice("AxisLTRHint");
			}
			else if (num != 0 && obj.GetComponent<Rigidbody>().mass <= objs[num - 1].GetComponent<Rigidbody>().mass)
			{
				MonoSingleton<Instructions>.Instance().SetText("这个物体比左边的重吗？再用天平比较一下吧，按从轻到重的顺序排序。");
				MonoSingleton<VoiceMgr>.Instance().PlayVoice("AxisLTLHint");
			}
			else
			{
				MonoSingleton<Instructions>.Instance().SetText("所有物体在数轴上排好后，再按顺序把他们放到相应的位置吧。");
				MonoSingleton<VoiceMgr>.Instance().PlayVoice("AxisHint");
			}
		}
		if (symbol.Equals(Symbol.GT.ToString()))
		{
			if (num != objs.Count - 1 && obj.GetComponent<Rigidbody>().mass < objs[num + 1].GetComponent<Rigidbody>().mass)
			{
				MonoSingleton<Instructions>.Instance().SetText("这个物体比右边的重吗？再用天平比较一下吧，按从重到轻的顺序排序。");
				MonoSingleton<VoiceMgr>.Instance().PlayVoice("AxisGTRHint");
			}
			else if (num != 0 && obj.GetComponent<Rigidbody>().mass >= objs[num - 1].GetComponent<Rigidbody>().mass)
			{
				MonoSingleton<Instructions>.Instance().SetText("这个物体比左边的轻吗？再用天平比较一下吧，按从重到轻的顺序排序。");
				MonoSingleton<VoiceMgr>.Instance().PlayVoice("AxisGTLHint");
			}
			else
			{
				MonoSingleton<Instructions>.Instance().SetText("所有物体在数轴上排好后，再按顺序把他们放到相应的位置吧。");
				MonoSingleton<VoiceMgr>.Instance().PlayVoice("AxisHint");
			}
		}
	}

	private void SortByX()
	{
		objs.Clear();
		List<Transform> objects = axisContainer.GetObjects();
		for (int i = 0; i < objects.Count; i++)
		{
			objs.Add(objects[i]);
		}
		objs.Sort(delegate(Transform left, Transform right)
		{
			if (left.transform.position.x > right.transform.position.x)
			{
				return 1;
			}
			return (left.transform.position.x != right.transform.position.x) ? (-1) : 0;
		});
	}

	private void OnDestroy()
	{
		Container container = axisContainer;
		container.onEnter = (Action<Collider>)Delegate.Remove(container.onEnter, new Action<Collider>(CheckNewObject));
	}
}
public class BalanceContainer : Container
{
	protected override bool IsTriggered(Collider other)
	{
		if (!other.gameObject.tag.Equals("Crystal") && !other.gameObject.tag.Equals("Weight"))
		{
			return other.gameObject.layer.Equals(LayerMask.NameToLayer("InteractionObject"));
		}
		return true;
	}
}
public class BalancePointer : MonoBehaviour
{
	public BalanceController controller;

	public Container left;

	public Container right;

	private void Update()
	{
		UpdateRotation();
	}

	private void UpdatePointer()
	{
		Quaternion localRotation = controller.gameObject.transform.localRotation;
		UnityEngine.Debug.LogFormat("MyDebug: lever local rotation: {0}, {1}, {2}", localRotation.eulerAngles.x, localRotation.eulerAngles.y, localRotation.eulerAngles.z);
		Quaternion rotation = controller.gameObject.transform.rotation;
		UnityEngine.Debug.LogFormat("MyDebug: lever world rotation: {0}, {1}, {2}", rotation.eulerAngles.x, rotation.eulerAngles.y, rotation.eulerAngles.z);
		base.transform.localRotation = Quaternion.Euler(0f, 0f, Mathf.Clamp(localRotation.eulerAngles.z, -18f, 18f));
	}

	public void UpdateRotation()
	{
		float totalMass = left.GetTotalMass();
		float totalMass2 = right.GetTotalMass();
		if (Mathf.Abs(totalMass - totalMass2) < 0.0001f)
		{
			base.transform.localRotation = Quaternion.identity;
		}
		else
		{
			base.transform.localRotation = Quaternion.Euler(0f, 0f, Mathf.Clamp(500f * (totalMass2 - totalMass), -18f, 18f));
		}
	}

	internal void HandleColliderChange(Collider collider)
	{
		UnityEngine.Debug.Log("MyCollision: Handle collider change.");
		UpdateRotation();
	}

	private void OnEnable()
	{
		BalanceController balanceController = controller;
		balanceController.onCollisionEnter = (Action<Collider>)Delegate.Combine(balanceController.onCollisionEnter, new Action<Collider>(HandleCollisionEnter));
		BalanceController balanceController2 = controller;
		balanceController2.onCollisionExit = (Action<Collider>)Delegate.Combine(balanceController2.onCollisionExit, new Action<Collider>(HandleCollisionExit));
	}

	private void OnDisable()
	{
		BalanceController balanceController = controller;
		balanceController.onCollisionEnter = (Action<Collider>)Delegate.Remove(balanceController.onCollisionEnter, new Action<Collider>(HandleCollisionEnter));
		BalanceController balanceController2 = controller;
		balanceController2.onCollisionExit = (Action<Collider>)Delegate.Remove(balanceController2.onCollisionExit, new Action<Collider>(HandleCollisionExit));
	}

	private void HandleOnEnter(Transform obj)
	{
		if (obj.transform.position.x < base.transform.position.x)
		{
			left.GetObjects().Add(obj);
		}
		else
		{
			right.GetObjects().Add(obj);
		}
		RotatePointer();
	}

	private void HandleOnExit(Transform obj)
	{
		if (obj.transform.position.x < base.transform.position.x)
		{
			left.GetObjects().Remove(obj);
		}
		else
		{
			right.GetObjects().Remove(obj);
		}
		RotatePointer();
	}

	private void HandleCollisionEnter(Collider obj)
	{
		if (obj.transform.position.x < base.transform.position.x)
		{
			left.GetGroupCollision().OnTriggerEnter(obj);
		}
		else
		{
			right.GetGroupCollision().OnTriggerEnter(obj);
		}
	}

	private void HandleCollisionExit(Collider obj)
	{
		if (obj.transform.position.x < base.transform.position.x)
		{
			left.GetGroupCollision().OnTriggerExit(obj);
		}
		else
		{
			right.GetGroupCollision().OnTriggerExit(obj);
		}
	}

	private void RotatePointer()
	{
		if (Mathf.Abs(GetWeights(left) - GetWeights(right)) < 0.0001f)
		{
			base.transform.localRotation = Quaternion.identity;
		}
		else
		{
			base.transform.localRotation = Quaternion.Euler(0f, 0f, Mathf.Clamp(500f * (GetWeights(right) - GetWeights(left)), -18f, 18f));
		}
	}

	private float GetWeights(Container container)
	{
		float num = 0f;
		List<Transform> objects = container.GetObjects();
		UnityEngine.Debug.Log("GetWeights:" + objects.Count);
		foreach (Transform item in objects)
		{
			UnityEngine.Debug.Log("Item:" + item.name);
			if (item.GetComponent<Rigidbody>() != null)
			{
				num += item.GetComponent<Rigidbody>().mass;
			}
		}
		return num;
	}
}
public class ComparisonContainer : Container
{
	public ContainerType type;

	protected override bool IsTriggered(Collider other)
	{
		if ((!type.Equals(ContainerType.Object) || !other.gameObject.tag.Equals("Comparison")) && (!type.Equals(ContainerType.Symbol) || !other.gameObject.tag.Equals("Symbol")))
		{
			if (type.Equals(ContainerType.Axis))
			{
				return other.gameObject.tag.Equals("Comparison");
			}
			return false;
		}
		return true;
	}
}
[CreateAssetMenu(menuName = "CreateComparisonInfo")]
public class ComparisonInfo : ScriptableObject
{
	public int grade;

	public string instructionText;

	public string instructionClip;

	public string hintText;

	public string hintClip;

	public ComparisonType type;

	public Symbol symbol;

	public ComparisonObject[] objs;
}
[Serializable]
public enum Symbol
{
	GT,
	LT,
	EQ
}
[Serializable]
public enum ComparisonType
{
	SYMBOL,
	WEIGHT
}
[Serializable]
public class ComparisonObject
{
	public Transform prefab;

	public string name;

	public float weight;

	public Color color;

	public Vector3 spawnPoint;
}
public class ComparisonMgr : MonoBehaviour
{
	public ComparisonInfo[] comparisonInfos;

	public Container[] containers;

	public Container symbolContainer;

	public Transform numberAxis;

	private string symbol;

	private int size = -1;

	public TMP_Text hint;

	public Transform parent;

	private int currentGrade;

	private int currentLevel;

	private ComparisonType type;

	private GameObject currentTarget;

	private List<Transform> generatedObjs;

	private GameObject[] symbolObjs;

	private List<float> nums;

	private void Awake()
	{
		nums = new List<float>();
		generatedObjs = new List<Transform>();
		HintButton.onButtonDown = (Action)Delegate.Combine(HintButton.onButtonDown, new Action(DisplayHint));
	}

	private void OnDestroy()
	{
		nums.Clear();
		generatedObjs.Clear();
		HintButton.onButtonDown = (Action)Delegate.Remove(HintButton.onButtonDown, new Action(DisplayHint));
	}

	private void Start()
	{
		currentGrade = 0;
		symbolObjs = GameObject.FindGameObjectsWithTag("Symbol");
		currentLevel = GetCurrentLevel(currentGrade) - 1;
		NextLevel();
	}

	private int GetCurrentLevel(int currentGrade)
	{
		for (int i = 0; i < comparisonInfos.Length; i++)
		{
			if (currentGrade == comparisonInfos[i].grade)
			{
				return i;
			}
		}
		return 0;
	}

	private void Update()
	{
		if (currentLevel < comparisonInfos.Length && CheckResult() && !IsInvoking())
		{
			if (currentLevel == comparisonInfos.Length - 1)
			{
				MonoSingleton<Instructions>.Instance().SetText("恭喜你已经完成所有挑战，请按菜单键提出");
			}
			else
			{
				Invoke("NextLevel", 1f);
			}
		}
	}

	private bool CheckResult()
	{
		if (size < 2)
		{
			return false;
		}
		List<float> list = GetNums();
		if (type.Equals(ComparisonType.SYMBOL) && !GetSymbol())
		{
			return false;
		}
		return CheckEquation(list);
	}

	private bool GetSymbol()
	{
		if (symbolContainer.GetComponent<Container>().GetObjects().Count > 0)
		{
			symbol = symbolContainer.GetComponent<Container>().GetObjects()[0].name;
			return true;
		}
		return false;
	}

	private List<float> GetNums()
	{
		nums.Clear();
		for (int i = 0; i < size; i++)
		{
			nums.Add(-1f);
		}
		int j = 0;
		int num = 0;
		for (; j < containers.Length; j++)
		{
			if (num >= size)
			{
				break;
			}
			if (containers[j].GetObjects().Count > 0 && containers[j].GetObjects()[0].GetComponent<Rigidbody>() != null)
			{
				nums[num] = containers[j].GetObjects()[0].GetComponent<Rigidbody>().mass;
				num++;
			}
		}
		return nums;
	}

	private bool CheckEquation(List<float> nums)
	{
		if (symbol.Equals(Symbol.LT.ToString()))
		{
			for (int i = 0; i < size - 1; i++)
			{
				if (nums[i] >= nums[i + 1] || nums[i] <= 0f)
				{
					return false;
				}
			}
			return true;
		}
		if (symbol.Equals(Symbol.GT.ToString()))
		{
			for (int j = 0; j < size - 1; j++)
			{
				if (nums[j] <= nums[j + 1] || nums[j + 1] <= 0f)
				{
					return false;
				}
			}
			return true;
		}
		if (symbol.Equals(Symbol.EQ.ToString()))
		{
			for (int k = 0; k < size - 1; k++)
			{
				if (nums[k] != nums[k + 1] || nums[k] <= 0f)
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	private void NextLevel()
	{
		currentLevel++;
		Restore();
		ComparisonInfo comparisonInfo = comparisonInfos[currentLevel];
		hint.text = comparisonInfo.instructionText;
		string instructionClip = comparisonInfo.instructionClip;
		if (!string.IsNullOrEmpty(instructionClip))
		{
			MonoSingleton<VoiceMgr>.Instance().PlayVoice(instructionClip);
		}
		type = comparisonInfo.type;
		symbol = comparisonInfo.symbol.ToString();
		currentGrade = comparisonInfo.grade;
		ComparisonObject[] objs = comparisonInfo.objs;
		size = objs.Length;
		GenerateTargets(objs);
		if (type.Equals(ComparisonType.WEIGHT))
		{
			SetSymbolObject();
		}
		else if (type.Equals(ComparisonType.SYMBOL))
		{
			GenerateTargets(objs);
			SetGeneratedObjs();
		}
	}

	private void SetGeneratedObjs()
	{
		for (int i = 0; i < size; i++)
		{
			generatedObjs[i].position = containers[i].transform.position;
			Framework.Singleton<ObjectsUtil>.Instance.SetKinematic(generatedObjs[i].transform, needPhysics: false);
		}
	}

	private void Restore()
	{
		for (int i = 0; i < containers.Length; i++)
		{
			containers[i].Restore();
		}
		symbolContainer.Restore();
		for (int j = 0; j < symbolObjs.Length; j++)
		{
			symbolObjs[j].GetComponent<DropHandler>().RestoreTransform();
			Framework.Singleton<ObjectsUtil>.Instance.SetKinematic(symbolObjs[j].transform, needPhysics: true);
		}
		Framework.Singleton<ObjectsUtil>.Instance.Destroy(generatedObjs, 0f);
		generatedObjs.Clear();
		nums.Clear();
	}

	private void SetSymbolObject()
	{
		GameObject symbolObject = GetSymbolObject(symbol);
		if (!(symbolObject == null))
		{
			symbolObject.transform.position = symbolContainer.transform.position;
			Framework.Singleton<ObjectsUtil>.Instance.SetKinematic(symbolObject.transform, needPhysics: false);
		}
	}

	private GameObject GetSymbolObject(string symbol)
	{
		for (int i = 0; i < symbolObjs.Length; i++)
		{
			if (symbolObjs[i].name.Equals(symbol))
			{
				return symbolObjs[i];
			}
		}
		return null;
	}

	private void GenerateTargets(ComparisonObject[] objs)
	{
		for (int i = 0; i < size; i++)
		{
			ComparisonObject comparisonObject = objs[i];
			Transform transform = UnityEngine.Object.Instantiate(comparisonObject.prefab, comparisonObject.spawnPoint, Quaternion.identity, parent);
			transform.name = comparisonObject.name;
			transform.tag = "Comparison";
			transform.GetComponent<Renderer>().material.color = comparisonObject.color;
			transform.GetComponent<Rigidbody>().mass = comparisonObject.weight;
			generatedObjs.Add(transform);
		}
	}

	public void DisplayHint()
	{
		string hintText = comparisonInfos[currentLevel].hintText;
		if (!string.IsNullOrEmpty(hintText))
		{
			hint.text = hintText;
		}
		string hintClip = comparisonInfos[currentLevel].hintClip;
		if (!string.IsNullOrEmpty(hintClip))
		{
			MonoSingleton<VoiceMgr>.Instance().PlayVoice(hintClip);
		}
		if (currentGrade > 1)
		{
			numberAxis.GetComponent<Renderer>().enabled = true;
			numberAxis.GetComponent<Collider>().enabled = true;
		}
	}
}
public class BlocksButton : SNButton
{
	public string type;

	public static Action<string> onButtonDown;

	private void Update()
	{
		if (isTriggered() && onButtonDown != null)
		{
			onButtonDown(type);
		}
	}
}
public class BlocksMgr : MonoBehaviour
{
	public Transform spawnPoint;

	public Transform[] prefabs;

	private static ParticleSystem birth;

	private List<Transform> spawnObjs;

	private int limit;

	public void ClearAll()
	{
		foreach (Transform spawnObj in spawnObjs)
		{
			UnityEngine.Object.Destroy(spawnObj.gameObject);
		}
		spawnObjs.Clear();
	}

	private void Start()
	{
		spawnObjs = new List<Transform>();
		MonoSingleton<VoiceMgr>.Instance().PlayVoice("BlocksInst", 1f);
		MonoSingleton<Instructions>.Instance().Init(LanCode.BlocksIntro, null, null);
	}

	private void SpawnBlock(string type)
	{
		Transform frefab = GetFrefab(type);
		if (!(frefab == null))
		{
			if (limit == 0 || spawnObjs.Count < limit)
			{
				spawnObjs.Add(UnityEngine.Object.Instantiate(frefab, spawnPoint.position, Quaternion.identity, spawnPoint));
				birth.Play();
			}
			else
			{
				MonoSingleton<Instructions>.Instance().SetText("该积木已达到上限。想获得更多积木，请在答题关卡获得更高的等级");
				MonoSingleton<VoiceMgr>.Instance().PlayVoice("BlocksLimit");
			}
		}
	}

	public void AddSpawnObject(Transform transform)
	{
		spawnObjs.Add(transform);
	}

	private Transform GetFrefab(string type)
	{
		if (prefabs == null)
		{
			return null;
		}
		for (int i = 0; i < prefabs.Length; i++)
		{
			if (prefabs[i].name.Equals(type))
			{
				return prefabs[i];
			}
		}
		return null;
	}
}
public class ClearButton : SNButton
{
	public static Action onClear;

	private void Update()
	{
		if (isTriggered() && onClear != null)
		{
			onClear();
		}
	}
}
public class AccountMgr : MonoSingleton<AccountMgr>
{
	private Account currentAccount;

	private Performance currentPerformance;

	private UserProfile currentProfile;

	private Inventory currentInventory;

	private bool isSyncFromRemote;

	private void Start()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	public UserProfile GetUserProfile()
	{
		return currentProfile;
	}

	public ProfileData GetUserProfileData()
	{
		return currentProfile.data;
	}

	internal void SetUserProfile(UserProfile profile)
	{
		currentProfile = profile;
		isSyncFromRemote = false;
		int num = profile.data.userID;
		if (num == 0)
		{
			num = GetAcountID(currentProfile.device);
		}
		InitUser(num);
	}

	private int GetAcountID(Device device)
	{
		if (device == null)
		{
			return 0;
		}
		Dictionary<int, int> dictionary = device.accounts_info.FromJson<Dictionary<int, int>>();
		if (dictionary != null && dictionary.ContainsKey(currentProfile.index))
		{
			isSyncFromRemote = true;
			return dictionary[currentProfile.index];
		}
		return 0;
	}

	private void InitUser(int accountID)
	{
		if (accountID == 0)
		{
			CreateAccount(currentProfile);
		}
		else if (isSyncFromRemote)
		{
			DataSourceFactory.GetDataSource().GetAccountService().GetAccount(accountID, OnGetAccount);
		}
		else
		{
			DataSourceFactory.GetDataSource().GetAccountService().GetAccount(accountID, OnUpdateAccount);
		}
	}

	private void InitUserProfile()
	{
		if (currentAccount != null)
		{
			Dictionary<string, int> dictionary = currentAccount.info.FromJson<Dictionary<string, int>>();
			currentProfile.data.userID = currentAccount.account_id;
			currentProfile.data.guided = dictionary["guided"];
			currentProfile.Store();
		}
	}

	private void InitPerformance()
	{
		if (currentAccount != null)
		{
			if (currentAccount.performance_id != 0)
			{
				SyncCurrentPerformance(currentAccount.performance_id);
			}
			else
			{
				CreatePerformance(currentProfile);
			}
		}
	}

	private void InitInventory()
	{
		if (currentAccount != null)
		{
			if (currentAccount.inventory_id != 0)
			{
				SyncCurrentInventory(currentAccount.inventory_id);
			}
			else
			{
				CreateInventory(currentProfile);
			}
		}
	}

	private void CreateAccount(UserProfile profile)
	{
		Account account = new Account();
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		dictionary.Add("index", profile.index);
		dictionary.Add("guided", profile.data.guided);
		account.info = dictionary.ToJson();
		account.name = profile.device?.UUID + profile.index;
		account.created_time = DateTime.Now.ToString("u");
		DataSourceFactory.GetDataSource().GetAccountService().CreateAccount(account, OnCreateAccount);
	}

	private void CreatePerformance(UserProfile profile)
	{
		Performance performance = new Performance();
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		dictionary.Add("tangram", profile.data.tangramGrade);
		dictionary.Add("threeview", profile.data.threeviewGrade);
		dictionary.Add("creator", profile.data.creatorGrade);
		dictionary.Add("sudoku", currentProfile.data.sudokuGrade);
		dictionary.Add("substitution", currentProfile.data.substitutionGrade);
		dictionary.Add("cycle", currentProfile.data.cycleGrade);
		performance.grade = dictionary.ToJson();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		dictionary2.Add("tangram", profile.data.tangramLevel);
		dictionary2.Add("threeview", profile.data.threeviewLevel);
		dictionary2.Add("creator", profile.data.creatorLevel);
		dictionary2.Add("sudoku", currentProfile.data.sudokuLevel);
		dictionary2.Add("substitution", currentProfile.data.substitutionLevel);
		dictionary2.Add("cycle", currentProfile.data.cycleLevel);
		performance.level = dictionary2.ToJson();
		DataSourceFactory.GetDataSource().GetPerformanceService().CreatePerformance(performance, OnCreatePerformance);
	}

	private void CreateInventory(UserProfile profile)
	{
		Inventory inventory = new Inventory();
		inventory.toys_info = profile.data.toys.ToJson();
		inventory.rewards_info = profile.data.medals.ToJson();
		DataSourceFactory.GetDataSource().GetInventoryService().CreateInventory(inventory, OnCreateInventory);
	}

	private void UpdateDevice(UserProfile profile)
	{
		DataSourceFactory.GetDataSource().GetDeviceService().UpdateDevice(profile.device);
	}

	private void UpdateAccount(Account account)
	{
		DataSourceFactory.GetDataSource().GetAccountService().UpdateAccount(account);
	}

	internal void UpdateAccount()
	{
		currentProfile.Store();
		if (currentAccount != null)
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary.Add("index", currentProfile.index);
			dictionary.Add("guided", currentProfile.data.guided);
			currentAccount.info = dictionary.ToJson();
			UpdateAccount(currentAccount);
		}
	}

	internal void UpdateInventory()
	{
		currentProfile.Store();
		if (currentAccount != null && currentInventory != null)
		{
			currentInventory.toys_info = currentProfile.data.toys.ToJson();
			UnityEngine.Debug.Log("toys_info:" + currentInventory.toys_info);
			currentInventory.rewards_info = currentProfile.data.medals.ToJson();
			DataSourceFactory.GetDataSource().GetInventoryService().UpdateInventory(currentInventory);
		}
	}

	internal void UpdatePerformance()
	{
		currentProfile.Store();
		if (currentAccount != null && currentPerformance != null)
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary.Add("tangram", currentProfile.data.tangramGrade);
			dictionary.Add("threeview", currentProfile.data.threeviewGrade);
			dictionary.Add("creator", currentProfile.data.creatorGrade);
			dictionary.Add("sudoku", currentProfile.data.sudokuGrade);
			dictionary.Add("substitution", currentProfile.data.substitutionGrade);
			dictionary.Add("cycle", currentProfile.data.cycleGrade);
			currentPerformance.grade = dictionary.ToJson();
			Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
			dictionary2.Add("tangram", currentProfile.data.tangramLevel);
			dictionary2.Add("threeview", currentProfile.data.threeviewLevel);
			dictionary2.Add("creator", currentProfile.data.creatorLevel);
			dictionary2.Add("sudoku", currentProfile.data.sudokuLevel);
			dictionary2.Add("substitution", currentProfile.data.substitutionLevel);
			dictionary2.Add("cycle", currentProfile.data.cycleLevel);
			currentPerformance.level = dictionary2.ToJson();
			DataSourceFactory.GetDataSource().GetPerformanceService().UpdatePerformance(currentPerformance);
		}
	}

	private void SyncCurrentPerformance(int performanceID)
	{
		DataSourceFactory.GetDataSource().GetPerformanceService().GetPerformance(performanceID, OnGetPerformance);
	}

	private void SyncCurrentInventory(int inventoryID)
	{
		DataSourceFactory.GetDataSource().GetInventoryService().GetInventory(inventoryID, OnGetInventory);
	}

	private void OnGetAccount(Account account)
	{
		if (account != null)
		{
			currentAccount = account;
			InitUserProfile();
			InitPerformance();
			InitInventory();
			Framework.Singleton<MemoryMgr>.Instance.SyncAllMemories();
		}
	}

	private void OnUpdateAccount(Account account)
	{
		if (account != null)
		{
			currentAccount = account;
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary.Add("index", currentProfile.index);
			dictionary.Add("guided", currentProfile.data.guided);
			currentAccount.info = dictionary.ToJson();
			DataSourceFactory.GetDataSource().GetAccountService().UpdateAccount(currentAccount);
			UpdateAccess(currentAccount.account_id);
			if (currentAccount.performance_id != 0)
			{
				DataSourceFactory.GetDataSource().GetPerformanceService().GetPerformance(currentAccount.performance_id, OnUpdatePerformace);
			}
			else
			{
				CreatePerformance(currentProfile);
			}
			if (currentAccount.inventory_id != 0)
			{
				DataSourceFactory.GetDataSource().GetInventoryService().GetInventory(currentAccount.inventory_id, OnUpdateInventory);
			}
			else
			{
				CreateInventory(currentProfile);
			}
			Framework.Singleton<MemoryMgr>.Instance.SyncAllMemories();
		}
	}

	private void OnUpdateInventory(Inventory obj)
	{
		currentInventory = obj;
		currentInventory.toys_info = currentProfile.data.toys.ToJson();
		currentInventory.rewards_info = currentProfile.data.medals.ToJson();
		DataSourceFactory.GetDataSource().GetInventoryService().UpdateInventory(currentInventory);
	}

	private void OnUpdatePerformace(Performance obj)
	{
		currentPerformance = obj;
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		dictionary.Add("tangram", currentProfile.data.tangramGrade);
		dictionary.Add("threeview", currentProfile.data.threeviewGrade);
		dictionary.Add("creator", currentProfile.data.creatorGrade);
		dictionary.Add("sudoku", currentProfile.data.sudokuGrade);
		dictionary.Add("substitution", currentProfile.data.substitutionGrade);
		dictionary.Add("cycle", currentProfile.data.cycleGrade);
		currentPerformance.grade = dictionary.ToJson();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		dictionary2.Add("tangram", currentProfile.data.tangramLevel);
		dictionary2.Add("threeview", currentProfile.data.threeviewLevel);
		dictionary2.Add("creator", currentProfile.data.creatorLevel);
		dictionary2.Add("sudoku", currentProfile.data.sudokuLevel);
		dictionary2.Add("substitution", currentProfile.data.substitutionLevel);
		dictionary2.Add("cycle", currentProfile.data.cycleLevel);
		currentPerformance.level = dictionary2.ToJson();
		DataSourceFactory.GetDataSource().GetPerformanceService().UpdatePerformance(currentPerformance);
	}

	private void OnCreateAccount(Account obj)
	{
		if (obj != null && obj.account_id != 0)
		{
			currentAccount = obj;
			currentProfile.data.userID = obj.account_id;
			Dictionary<int, int> dictionary = currentProfile.device.accounts_info.FromJson<Dictionary<int, int>>();
			dictionary.Add(currentProfile.index, obj.account_id);
			currentProfile.device.accounts_info = dictionary.ToJson();
			currentProfile.Store();
			UpdateDevice(currentProfile);
			CreatePerformance(currentProfile);
			CreateInventory(currentProfile);
			CreateAccess(currentAccount.account_id);
			Framework.Singleton<MemoryMgr>.Instance.SyncAllMemories();
		}
	}

	private void CreateAccess(int account_id)
	{
		Access access = new Access(account_id, 1, "", "", DateTime.Now.ToString("u"));
		DataSourceFactory.GetDataSource().GetAccessService().CreateAccess(access, null);
	}

	private void UpdateAccess(int account_id)
	{
		DataSourceFactory.GetDataSource().GetAccessService().GetAccess(account_id, onGetAccess);
	}

	private void onGetAccess(Access obj)
	{
		if (obj == null)
		{
			CreateAccess(currentAccount.account_id);
			return;
		}
		Access access = new Access(obj.account_id, obj.count + 1, obj.avg_duration, obj.total_time, DateTime.Now.ToString("u"));
		DataSourceFactory.GetDataSource().GetAccessService().UpdateAccess(access);
	}

	private void OnCreateInventory(Inventory obj)
	{
		currentInventory = obj;
		currentAccount.inventory_id = obj.inventory_id;
		UpdateAccount(currentAccount);
	}

	private void OnCreatePerformance(Performance obj)
	{
		currentPerformance = obj;
		currentAccount.performance_id = obj.performance_id;
		UpdateAccount(currentAccount);
	}

	private void OnGetInventory(Inventory obj)
	{
		if (obj != null)
		{
			currentInventory = obj;
			currentProfile.data.toys = obj.toys_info.FromJson<List<Toy>>();
			currentProfile.data.medals = obj.rewards_info.FromJson<List<Medal>>();
			currentProfile.Store();
		}
	}

	private void OnGetPerformance(Performance obj)
	{
		if (obj != null)
		{
			currentPerformance = obj;
			Dictionary<string, int> dictionary = currentPerformance.grade.FromJson<Dictionary<string, int>>();
			Dictionary<string, int> dictionary2 = currentPerformance.level.FromJson<Dictionary<string, int>>();
			currentProfile.data.tangramGrade = dictionary["tangram"];
			currentProfile.data.threeviewGrade = dictionary["threeview"];
			currentProfile.data.creatorGrade = dictionary["creator"];
			currentProfile.data.sudokuGrade = dictionary["sudoku"];
			currentProfile.data.substitutionGrade = dictionary["substitution"];
			currentProfile.data.cycleGrade = dictionary["cycle"];
			currentProfile.data.tangramLevel = dictionary2["tangram"];
			currentProfile.data.threeviewLevel = dictionary2["threeview"];
			currentProfile.data.creatorLevel = dictionary2["creator"];
			currentProfile.data.sudokuLevel = dictionary2["sudoku"];
			currentProfile.data.substitutionLevel = dictionary2["substitution"];
			currentProfile.data.cycleLevel = dictionary2["cycle"];
			currentProfile.Store();
		}
	}
}
public abstract class AnswerChecker : MonoBehaviour
{
	public float confirmInterval = 0.6f;

	protected Choice choice;

	private float lastTime;

	public static Action<int, int> onUpgrade;

	private void Start()
	{
		lastTime = Time.time;
	}

	public void CheckAnswer(int index)
	{
		if (!(Time.time - lastTime < confirmInterval))
		{
			lastTime = Time.time;
			if (choice.GetRightIndex() == index)
			{
				AnswerRight();
			}
			else
			{
				AnswerWrong();
			}
		}
	}

	protected abstract void AnswerRight();

	protected abstract void AnswerWrong();
}
public class Blink : MonoBehaviour
{
	public float speed = 0.1f;

	private Material material;

	private bool isArrived;

	private bool isEnabled;

	private Color color = Color.white;

	private void Start()
	{
		material = GetComponent<Renderer>().sharedMaterial;
		material.SetColor("_Color", Color.white);
	}

	private void Update()
	{
		SwitchAlpha();
	}

	public void Enable(bool on)
	{
		material.SetColor("_Color", Color.white);
		isEnabled = on;
	}

	private void SwitchAlpha()
	{
		color = material.GetColor("_Color");
		if (!isArrived)
		{
			color.a += speed * Time.deltaTime;
			if ((double)color.a > 0.99)
			{
				isArrived = true;
			}
		}
		else
		{
			color.a -= speed * Time.deltaTime;
			if ((double)color.a < 0.3)
			{
				isArrived = false;
			}
		}
		material.SetColor("_Color", color);
	}
}
public class ActionButton : SNButton
{
	public Action onButtonDown;

	private void Update()
	{
		if (isTriggered() && onButtonDown != null)
		{
			onButtonDown();
		}
	}
}
public class AnswerButton : SNButton
{
	public int answerIndex = -1;

	public static Action<int> onButtonDown;

	private void Start()
	{
	}

	private void Update()
	{
		if (isTriggered() && onButtonDown != null)
		{
			onButtonDown(answerIndex);
		}
	}
}
public class HintButton : SNButton
{
	public static Action onButtonDown;

	private void Update()
	{
		if (isTriggered() && onButtonDown != null)
		{
			onButtonDown();
		}
	}
}
public class ResetButton : SNButton
{
	public static Action onButtonDown;

	private void Update()
	{
		if (isTriggered() && onButtonDown != null)
		{
			onButtonDown();
		}
	}
}
public class SNButton : MonoBehaviour
{
	public AudioSource buttonClick;

	private Color originalColor = new Color(0.5279903f, 0.9168222f, 105f / 106f);

	private Color highlightColor = new Color(0f, 0.7005146f, 1f);

	private int sensitivity = 5;

	private bool buttonDown;

	private bool triggered;

	private int duration;

	protected bool isGuiding;

	public void TriggerButton(Collider other, bool down)
	{
		if (other.gameObject.name.Contains("GrabVolumeSmall"))
		{
			SetButtonState(down);
		}
	}

	protected bool shouldIgnore()
	{
		if (!buttonDown)
		{
			duration = 0;
			triggered = false;
			return true;
		}
		if (duration++ <= sensitivity || triggered)
		{
			return true;
		}
		duration = 0;
		triggered = true;
		return false;
	}

	public void SetButtonState(bool down)
	{
		buttonDown = down;
		if (down)
		{
			GetComponent<Renderer>().sharedMaterial.SetColor("_EmisColor", highlightColor);
		}
		else
		{
			GetComponent<Renderer>().sharedMaterial.SetColor("_EmisColor", originalColor);
		}
	}

	protected void SwitchColor()
	{
		Material sharedMaterial = GetComponent<Renderer>().sharedMaterial;
		if (sharedMaterial.GetColor("_EmisColor").Equals(originalColor))
		{
			sharedMaterial.DOColor(highlightColor, "_EmisColor", 1f);
		}
		if (sharedMaterial.GetColor("_EmisColor").Equals(highlightColor))
		{
			sharedMaterial.DOColor(originalColor, "_EmisColor", 1f);
		}
	}

	public void SetGuideState(bool isGuiding)
	{
		this.isGuiding = isGuiding;
		if (!isGuiding)
		{
			GetComponent<Renderer>().sharedMaterial.SetColor("_EmisColor", originalColor);
		}
	}

	protected bool isTriggered()
	{
		if (shouldIgnore())
		{
			return false;
		}
		buttonClick.Play();
		return true;
	}

	protected virtual void OnDestroy()
	{
		if (GetComponent<Renderer>() != null)
		{
			GetComponent<Renderer>().sharedMaterial.SetColor("_EmisColor", originalColor);
		}
	}

	protected void OnTriggerEnter(Collider other)
	{
		TriggerButton(other, down: true);
	}

	protected void OnTriggerExit(Collider other)
	{
		TriggerButton(other, down: false);
	}
}
public abstract class Choice : MonoSingleton<Choice>
{
	public TMP_Text[] answers;

	private int currentLevel = -1;

	private int previousNumber;

	private int rightIndex = -1;

	private List<int> indexes = new List<int>();

	public void UpdateChoice()
	{
		if (currentLevel == GetLevel())
		{
			return;
		}
		indexes.Clear();
		int[] array = GenerateNumbers();
		for (int i = 0; i < array.Length; i++)
		{
			int num = UnityEngine.Random.Range(0, 3);
			while (indexes.Contains(num))
			{
				num = UnityEngine.Random.Range(0, 3);
			}
			indexes.Add(num);
			answers[num].text = array[i].ToString();
			if (i == 0)
			{
				rightIndex = num;
			}
		}
		currentLevel = GetLevel();
	}

	protected int GenerateRandom(int range)
	{
		int num;
		for (num = UnityEngine.Random.Range(-range, range + 1); num == 0; num = UnityEngine.Random.Range(-range, range + 1))
		{
		}
		return num;
	}

	internal abstract int GetLevel();

	internal abstract int[] GenerateNumbers();

	public int GetRightIndex()
	{
		return rightIndex;
	}
}
public class ColliderTrigger : MonoBehaviour
{
	public UnityEvent onEnter;

	public string[] names;

	private void OnTriggerEnter(Collider other)
	{
		for (int i = 0; i < names.Length; i++)
		{
			if (other.transform.name.Contains(names[i]))
			{
				onEnter?.Invoke();
				break;
			}
		}
	}
}
public class CollisionScript : MonoBehaviour
{
	private GroupCollision m_GroupCollision;

	public int RefCount { get; set; }

	public bool Inside { get; set; }

	public bool IsGrabbed { get; set; }

	public GroupCollision.Trigger TriggerType { get; set; }

	public GroupCollision GroupRoot
	{
		get
		{
			return m_GroupCollision;
		}
		set
		{
			m_GroupCollision = value;
		}
	}

	private void Awake()
	{
		m_GroupCollision = null;
		RefCount = 0;
	}

	private void Update()
	{
		if (RefCount == 0 && !Inside && m_GroupCollision != null)
		{
			RemoveSelf();
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (Valid(collision))
		{
			RefCount++;
		}
		else if (collision.collider.gameObject.tag.Equals("Tabletop") && m_GroupCollision != null)
		{
			RemoveSelf();
		}
		if (InGroup(collision))
		{
			Transform transform = base.gameObject.transform;
			Transform transform2 = collision.collider.gameObject.transform;
			if (m_GroupCollision == null && transform.position.y > transform2.position.y)
			{
				AddSelf(collision);
			}
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (Valid(collision))
		{
			RefCount--;
		}
		if (RefCount == 0 && !Inside && m_GroupCollision != null)
		{
			RemoveSelf();
		}
	}

	public void OnGrabSelectEnter(Interactor interactor)
	{
		IsGrabbed = true;
	}

	public void OnGrabSelectExit(Interactor interactor)
	{
		IsGrabbed = false;
	}

	private void AddSelf(Collision collision)
	{
		Collider component = base.gameObject.GetComponent<Collider>();
		CollisionScript component2 = collision.collider.GetComponent<CollisionScript>();
		if (component != null && !component2.IsGrabbed)
		{
			component2.m_GroupCollision.AddCollider(component, GroupCollision.Trigger.Member);
		}
	}

	private void RemoveSelf()
	{
		Collider component = base.gameObject.GetComponent<Collider>();
		if (component != null)
		{
			m_GroupCollision.RemoveCollider(component, GroupCollision.Trigger.Member);
		}
	}

	private bool InGroup(Collision collision)
	{
		CollisionScript component = collision.collider.GetComponent<CollisionScript>();
		if (component == null)
		{
			return false;
		}
		return component.m_GroupCollision != null;
	}

	private bool Valid(Collision collision)
	{
		return collision.collider.GetComponent<CollisionScript>() != null;
	}
}
public abstract class Container : MonoBehaviour
{
	protected List<Transform> objects;

	public Action<Collider> onEnter;

	public Action<Collider> onExit;

	public int index = -1;

	private GroupCollision m_GroupCollision;

	private void Awake()
	{
		objects = new List<Transform>();
		m_GroupCollision = new GroupCollision(this);
	}

	public GroupCollision GetGroupCollision()
	{
		return m_GroupCollision;
	}

	public float GetTotalMass()
	{
		float num = 0f;
		foreach (Transform allObject in m_GroupCollision.GetAllObjects())
		{
			Rigidbody component = allObject.GetComponent<Rigidbody>();
			num += ((component != null) ? component.mass : 0f);
		}
		return num;
	}

	public List<Transform> GetObjects()
	{
		return m_GroupCollision.GetAllObjects();
	}

	public void AddObjects(List<Transform> objs)
	{
		objects.AddRange(objs);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (IsTriggered(other) && !objects.Contains(other.gameObject.transform))
		{
			UnityEngine.Debug.Log("OnTriggerEnter:" + other.transform.name);
			objects.Add(other.gameObject.transform);
			UnityEngine.Debug.Log("objects:" + objects.Count);
			if (onEnter != null)
			{
				onEnter(other);
			}
		}
	}

	protected abstract bool IsTriggered(Collider other);

	private void OnTriggerExit(Collider other)
	{
		if (objects.Contains(other.gameObject.transform))
		{
			UnityEngine.Debug.Log("OnTriggerExit:" + other.transform.name);
			objects.Remove(other.gameObject.transform);
			UnityEngine.Debug.Log("objects:" + objects.Count);
			if (onExit != null)
			{
				onExit(other);
			}
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (IsTriggered(collision.collider) && !objects.Contains(collision.gameObject.transform))
		{
			UnityEngine.Debug.Log("OnCollisionEnter:" + collision.transform.name);
			objects.Add(collision.gameObject.transform);
			if (onEnter != null)
			{
				onEnter(collision.collider);
			}
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (objects.Contains(collision.gameObject.transform))
		{
			UnityEngine.Debug.Log("OnCollisionExit:" + collision.transform.name);
			objects.Remove(collision.gameObject.transform);
			if (onExit != null)
			{
				onExit(collision.collider);
			}
		}
	}

	public void Restore()
	{
		objects.Clear();
		m_GroupCollision.RemoveAllObjects();
	}

	public void ClearObjects()
	{
		for (int i = 0; i < objects.Count; i++)
		{
			UnityEngine.Object.Destroy(objects[i].gameObject);
		}
	}
}
[Serializable]
public enum ContainerType
{
	Object,
	Symbol,
	Axis
}
public class DropHandler : MonoBehaviour
{
	public bool reborn = true;

	public bool updateOnLoad;

	private static ParticleSystem birth;

	private static ParticleSystem disappear;

	private Vector3 originPos;

	private Quaternion originRot;

	private static AudioClip disappearSound;

	public Action onBirth;

	private void Awake()
	{
		if (birth == null)
		{
			GameObject gameObject = GameObject.Find("Light");
			if (gameObject != null)
			{
				birth = gameObject.GetComponent<ParticleSystem>();
			}
		}
		if (disappear == null)
		{
			GameObject gameObject2 = GameObject.Find("ZhaLie");
			if (gameObject2 != null)
			{
				disappear = gameObject2.GetComponent<ParticleSystem>();
			}
		}
		if (updateOnLoad)
		{
			ContentLoader.OnAnimationCompleted = (Action)Delegate.Combine(ContentLoader.OnAnimationCompleted, new Action(RecordOrigin));
		}
	}

	private void Start()
	{
		RecordOrigin();
		if (disappearSound == null)
		{
			disappearSound = Resources.Load<AudioClip>("disappear");
		}
	}

	public void RecordOrigin()
	{
		originPos = base.transform.position;
		originRot = base.transform.rotation;
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.layer == LayerMask.NameToLayer("Floor"))
		{
			Invoke("Reset", 0.5f);
		}
	}

	public void Reset()
	{
		if (disappear != null)
		{
			disappear.transform.position = base.transform.position;
			disappear.Play();
			MonoSingleton<SoundMgr>.Instance().PlaySound(disappearSound, base.transform.position);
		}
		if (reborn)
		{
			Invoke("Birth", 0.5f);
		}
		else
		{
			GetComponent<Renderer>().enabled = false;
		}
	}

	private void Birth()
	{
		base.transform.position = MonoSingleton<SpawnPoint>.Instance().GetSpawnPoint().transform.position;
		base.transform.rotation = originRot;
		GetComponent<ToyController>()?.RecordTransform(base.transform);
		if (birth != null)
		{
			birth.transform.position = base.transform.position;
			birth.Play();
			onBirth?.Invoke();
		}
	}

	public void RestoreTransform()
	{
		base.transform.position = originPos;
		base.transform.rotation = originRot;
	}

	private void OnDestroy()
	{
		if (updateOnLoad)
		{
			ContentLoader.OnAnimationCompleted = (Action)Delegate.Remove(ContentLoader.OnAnimationCompleted, new Action(RecordOrigin));
		}
	}
}
public class DynamicEffect : MonoBehaviour
{
	public float speed = 0.01f;

	private Material material;

	private bool isArrived;

	private bool isEnabled;

	private void Start()
	{
		material = GetComponent<Renderer>().sharedMaterial;
		material.SetFloat("_Cutoff", 1f);
	}

	private void Update()
	{
		if (isEnabled)
		{
			SwitchShininess();
		}
	}

	public void Enable(bool on)
	{
		material.SetFloat("_Cutoff", 1f);
		isEnabled = on;
	}

	private void SwitchShininess()
	{
		float @float = material.GetFloat("_Cutoff");
		if (!isArrived)
		{
			@float += speed * Time.deltaTime;
			if ((double)@float > 0.99)
			{
				isArrived = true;
			}
		}
		else
		{
			@float -= speed * Time.deltaTime;
			if ((double)@float < 0.02)
			{
				isArrived = false;
			}
		}
		material.SetFloat("_Cutoff", @float);
	}
}
internal class FileUtil
{
	internal static bool CreateFolder(string path)
	{
		try
		{
			if (!Directory.Exists(path) && Directory.CreateDirectory(path) == null)
			{
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError("create folder failure:" + ex.Message);
			return false;
		}
	}

	internal static void DeleteFile(string fileName)
	{
		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}
	}

	internal static List<string> FindFiles(string folder, string name)
	{
		List<string> list = new List<string>();
		foreach (string item in Directory.EnumerateFiles(folder))
		{
			if (item.Contains(name))
			{
				list.Add(item);
			}
		}
		return list;
	}
}
public class GameTimer : MonoBehaviour
{
	public float countDownTime;

	private float gameTime;

	private float timer;

	private Text leftTime;

	public static Action onTimeUp;

	private bool stopped;

	private void Start()
	{
		gameTime = countDownTime;
		leftTime = GetComponent<Text>();
	}

	private void Update()
	{
		if (stopped)
		{
			return;
		}
		int num = (int)(gameTime / 60f);
		float num2 = gameTime % 60f;
		if (num == 0 && num2 < 0f)
		{
			stopped = true;
			if (onTimeUp != null)
			{
				onTimeUp();
			}
		}
		timer += Time.deltaTime;
		if (timer >= 1f)
		{
			timer = 0f;
			gameTime -= 1f;
			leftTime.text = num + "：" + $"{num2:00}";
		}
	}
}
public class GroupCollision
{
	public enum Trigger
	{
		Container,
		Member,
		Unknown
	}

	public Action<Collider> onAddCollider;

	public Action<Collider> onRemoveCollider;

	private Container m_Container;

	private List<Transform> m_Objects;

	private List<Collider> colliders;

	public bool Enabled { get; set; }

	public GroupCollision(Container container)
	{
		if (container != null)
		{
			m_Container = container;
			Container container2 = m_Container;
			container2.onEnter = (Action<Collider>)Delegate.Combine(container2.onEnter, new Action<Collider>(OnTriggerEnter));
			Container container3 = m_Container;
			container3.onExit = (Action<Collider>)Delegate.Combine(container3.onExit, new Action<Collider>(OnTriggerExit));
		}
		m_Objects = new List<Transform>();
		colliders = new List<Collider>();
		Enabled = true;
	}

	public List<Transform> GetAllObjects()
	{
		return m_Objects;
	}

	public void RemoveAllObjects()
	{
		m_Objects.Clear();
		colliders.Clear();
	}

	public void AddCollider(Collider collider, Trigger trigger)
	{
		CollisionScript component = collider.GetComponent<CollisionScript>();
		if (component != null)
		{
			bool flag = false;
			lock (this)
			{
				if (component.GroupRoot == null)
				{
					m_Objects.Add(collider.transform);
					colliders.Add(collider);
					component.GroupRoot = this;
					component.TriggerType = trigger;
					flag = true;
				}
			}
			if (flag)
			{
				onAddCollider?.Invoke(collider);
			}
		}
		else
		{
			UnityEngine.Debug.LogWarning("MyCollision: Collider does not have CollisionScript component.");
		}
	}

	public void RemoveCollider(Collider collider, Trigger trigger)
	{
		CollisionScript component = collider.GetComponent<CollisionScript>();
		if (component != null)
		{
			bool flag = false;
			lock (this)
			{
				if (component.GroupRoot != null && component.TriggerType == trigger)
				{
					m_Objects.Remove(collider.transform);
					colliders.Remove(collider);
					component.GroupRoot = null;
					flag = true;
				}
			}
			if (flag)
			{
				onRemoveCollider?.Invoke(collider);
			}
		}
		else
		{
			UnityEngine.Debug.LogWarning("MyCollision: Collider does not have CollisionScript component.");
		}
	}

	internal void OnTriggerEnter(Collider collider)
	{
		if (Enabled)
		{
			CollisionScript component = collider.GetComponent<CollisionScript>();
			if (!(component == null))
			{
				component.Inside = true;
				AddCollider(collider, Trigger.Container);
			}
		}
	}

	internal void OnTriggerExit(Collider collider)
	{
		if (Enabled && colliders.Contains(collider))
		{
			CollisionScript component = collider.GetComponent<CollisionScript>();
			if (!(component == null))
			{
				component.Inside = false;
				RemoveCollider(collider, Trigger.Container);
			}
		}
	}
}
public class HintRender : MonoBehaviour
{
	public Transform target;

	public Transform startTransform;

	public Vector3 endOffset;

	public bool onFirst;

	private LineRenderer lr;

	private TMP_Text hint;

	private Canvas canvas;

	private Vector3[] positions;

	private Vector3 startPoint;

	private Vector3 endPoint;

	private Vector3 controlPoint;

	private void Awake()
	{
		lr = GetComponentInChildren<LineRenderer>();
		canvas = GetComponentInChildren<Canvas>();
		hint = GetComponentInChildren<TMP_Text>();
		controlPoint = default(Vector3);
		if (!onFirst)
		{
			TurnOff();
		}
	}

	private void Start()
	{
		if (onFirst)
		{
			Translate();
		}
	}

	private void Translate()
	{
		string text = hint.text;
		string valueOf = ISILocalization.GetValueOf(text);
		hint.text = (string.IsNullOrEmpty(valueOf) ? text : valueOf);
	}

	private void Update()
	{
		if (lr.enabled && !(startTransform == null))
		{
			startPoint = startTransform.position;
			endPoint = target.position + endOffset;
			controlPoint.Set(startPoint.x, startPoint.y, endPoint.z);
			positions = GetBeizerList(startPoint, controlPoint, endPoint, 20);
			lr.positionCount = positions.Length;
			lr.SetPositions(positions);
			base.transform.position = target.position + endOffset;
		}
	}

	private Vector3[] GetBeizerList(Vector3 startPoint, Vector3 controlPoint, Vector3 endPoint, int segmentNum)
	{
		Vector3[] array = new Vector3[segmentNum];
		for (int i = 1; i <= segmentNum; i++)
		{
			float t = (float)i / (float)segmentNum;
			Vector3 vector = CalculateCubicBezierPoint(t, startPoint, controlPoint, endPoint);
			array[i - 1] = vector;
		}
		return array;
	}

	private Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		float num = 1f - t;
		float num2 = t * t;
		return num * num * p0 + 2f * num * t * p1 + num2 * p2;
	}

	public void Display(string text)
	{
		lr.enabled = true;
		canvas.enabled = true;
		string valueOf = ISILocalization.GetValueOf(text);
		hint.text = (string.IsNullOrEmpty(valueOf) ? text : valueOf);
	}

	public void TurnOff()
	{
		if (lr.enabled)
		{
			lr.enabled = false;
			canvas.enabled = false;
		}
	}
}
public abstract class InputHandler : MonoSingleton<InputHandler>
{
	internal enum ControllerType
	{
		Left,
		Right
	}

	public Action onMenuKeyDown;

	internal abstract bool IsBackKeyDown();

	internal abstract bool IsQuitKeyDown();

	internal abstract bool IsMenuKeyDown();

	internal abstract bool IsChangeLevelKeyDown();

	internal abstract Vector3 GetControllerVelocity(ControllerType hand);

	internal abstract Interactor GetInteractor(ControllerType hand);

	internal abstract float GetIndexTriggerValue(ControllerType hand);

	internal abstract bool GetAButtonDown(ControllerType hand);

	internal abstract float GetHandTriggerValue(ControllerType hand);

	internal abstract Vector2 GetThumbstickValue(ControllerType hand);

	internal abstract void SetContollerVibration(float frequency, float amplitude, ControllerType hand);

	internal abstract bool GetActivateButtonDown(ControllerType m_controller);

	internal abstract bool GetActivateButtonUp(ControllerType m_controller);
}
public class Instructions : MonoSingleton<Instructions>
{
	public TMP_Text hint;

	public SpriteRenderer spriteRender;

	public TMP_Text progress;

	public SpriteRenderer[] threeViewSprites;

	public RectTransform explain;

	public TMP_Text GetText()
	{
		return hint;
	}

	public TMP_Text GetProgressText()
	{
		return progress;
	}

	public SpriteRenderer GetSpriteRenderer()
	{
		return spriteRender;
	}

	public SpriteRenderer[] GetThreeViewSprites()
	{
		return threeViewSprites;
	}

	public RectTransform GetExplain()
	{
		return explain;
	}

	public void ResetThreeViewSprites()
	{
		for (int i = 0; i < threeViewSprites.Length; i++)
		{
			threeViewSprites[i].sprite = null;
		}
	}

	internal void Init()
	{
		Init("", null, "");
	}

	public void Init(string hintText, Sprite hintSprite, string progressText)
	{
		SetText(hintText);
		spriteRender.sprite = hintSprite;
		progress.text = progressText;
		ResetThreeViewSprites();
		explain.gameObject.SetActive(value: false);
	}

	internal void Init(string hintText)
	{
		Init(hintText, null, "");
	}

	internal void SetText(string hintText)
	{
		hint.text = ISILocalization.GetValueOf(hintText);
	}
}
public class AxisDragInteractable : Interactable
{
	[Serializable]
	public class DragDistanceEvent : UnityEvent<float>
	{
	}

	[Serializable]
	public class DragStepEvent : UnityEvent<int>
	{
	}

	[Tooltip("The Rigidbody that will be moved. If null will try to grab one on that object or its children")]
	public Rigidbody MovingRigidbody;

	public Vector3 LocalAxis;

	public float AxisLength;

	[Tooltip("If 0, then this is a float [0,1] range slider, otherwise there is an integer slider")]
	public int Steps;

	public bool SnapOnlyOnRelease = true;

	public bool ReturnOnFree;

	public float ReturnSpeed;

	public AudioClip SnapAudioClip;

	public DragDistanceEvent OnDragDistance;

	public DragStepEvent OnDragStep;

	private Vector3 m_EndPoint;

	private Vector3 m_StartPoint;

	private Vector3 m_GrabbedOffset;

	private float m_CurrentDistance;

	private int m_CurrentStep;

	private Interactor m_GrabbingInteractor;

	private float m_StepLength;

	protected internal override void Start()
	{
		base.Start();
		LocalAxis.Normalize();
		if (AxisLength < 0f)
		{
			LocalAxis *= -1f;
			AxisLength *= -1f;
		}
		if (Steps == 0)
		{
			m_StepLength = 0f;
		}
		else
		{
			m_StepLength = AxisLength / (float)Steps;
		}
		m_StartPoint = base.transform.position;
		m_EndPoint = base.transform.position + base.transform.TransformDirection(LocalAxis) * AxisLength;
		if (MovingRigidbody == null)
		{
			MovingRigidbody = GetComponentInChildren<Rigidbody>();
		}
		m_CurrentStep = 0;
	}

	public override void ProcessInteractable()
	{
		if (base.isSelected)
		{
			Vector3 rhs = base.transform.TransformDirection(LocalAxis);
			float num = Vector3.Dot(m_GrabbingInteractor.transform.position - base.transform.position - m_GrabbedOffset, rhs);
			if (Steps != 0 && !SnapOnlyOnRelease)
			{
				num = (float)Mathf.RoundToInt(num / m_StepLength) * m_StepLength;
			}
			Vector3 vector = ((!(num > 0f)) ? Vector3.MoveTowards(base.transform.position, m_StartPoint, 0f - num) : Vector3.MoveTowards(base.transform.position, m_EndPoint, num));
			if (Steps > 0)
			{
				int num2 = Mathf.RoundToInt((vector - m_StartPoint).magnitude / m_StepLength);
				if (num2 != m_CurrentStep)
				{
					MonoSingleton<SoundMgr>.Instance().PlaySound(SnapAudioClip, base.transform.position);
					OnDragStep.Invoke(num2);
				}
				m_CurrentStep = num2;
			}
			OnDragDistance.Invoke((vector - m_StartPoint).magnitude);
			Vector3 vector2 = vector - base.transform.position;
			if (MovingRigidbody != null)
			{
				MovingRigidbody.MovePosition(MovingRigidbody.position + vector2);
			}
			else
			{
				base.transform.position = base.transform.position + vector2;
			}
		}
		else if (ReturnOnFree)
		{
			Vector3 vector3 = Vector3.MoveTowards(base.transform.position, m_StartPoint, ReturnSpeed * Time.deltaTime) - base.transform.position;
			if (MovingRigidbody != null)
			{
				MovingRigidbody.MovePosition(MovingRigidbody.position + vector3);
			}
			else
			{
				base.transform.position = base.transform.position + vector3;
			}
		}
	}

	protected internal override void OnSelectEnter(Interactor interactor)
	{
		base.OnSelectEnter(interactor);
		m_GrabbedOffset = interactor.transform.position - base.transform.position;
		m_GrabbingInteractor = interactor;
	}

	protected internal override void OnSelectExit(Interactor interactor)
	{
		base.OnSelectExit(interactor);
		if (SnapOnlyOnRelease && Steps != 0)
		{
			float magnitude = (base.transform.position - m_StartPoint).magnitude;
			int num = Mathf.RoundToInt(magnitude / m_StepLength);
			magnitude = (float)num * m_StepLength;
			base.transform.position = m_StartPoint + base.transform.TransformDirection(LocalAxis) * magnitude;
			if (num != m_CurrentStep)
			{
				MonoSingleton<SoundMgr>.Instance().PlaySound(SnapAudioClip, base.transform.position);
				OnDragStep.Invoke(num);
			}
		}
	}

	private void OnDrawGizmosSelected()
	{
		Vector3 vector = base.transform.position + base.transform.TransformDirection(LocalAxis.normalized) * AxisLength;
		Gizmos.DrawLine(base.transform.position, vector);
		Gizmos.DrawSphere(vector, 0.01f);
	}
}
public class ButtonInteractable : MonoBehaviour
{
	[Serializable]
	public class ButtonPressedEvent : UnityEvent
	{
	}

	[Serializable]
	public class ButtonReleasedEvent : UnityEvent
	{
	}

	public Vector3 Axis = new Vector3(0f, -1f, 0f);

	public float MaxDistance;

	public float ReturnSpeed = 10f;

	public AudioClip ButtonPressAudioClip;

	public AudioClip ButtonReleaseAudioClip;

	public ButtonPressedEvent OnButtonPressed;

	public ButtonReleasedEvent OnButtonReleased;

	private Vector3 m_StartPosition;

	private Rigidbody m_Rigidbody;

	private Collider m_Collider;

	private bool m_Pressed;

	public bool isDynamic = true;

	private bool isReady;

	private void Awake()
	{
		if (isDynamic)
		{
			ContentLoader.OnAnimationCompleted = (Action)Delegate.Combine(ContentLoader.OnAnimationCompleted, new Action(SetReady));
			ContentLoader.onContentChanged = (Action)Delegate.Combine(ContentLoader.onContentChanged, new Action(SetNonReady));
		}
		else
		{
			isReady = true;
		}
	}

	public void Enabled(bool isEnabled)
	{
		if (isEnabled)
		{
			SetReady();
		}
		else
		{
			SetNonReady();
		}
	}

	private void SetNonReady()
	{
		isReady = false;
	}

	private void SetReady()
	{
		m_StartPosition = base.transform.position;
		isReady = true;
	}

	private void Start()
	{
		m_Rigidbody = GetComponent<Rigidbody>();
		m_Collider = GetComponentInChildren<Collider>();
		m_StartPosition = base.transform.position;
	}

	private void FixedUpdate()
	{
		if (!isReady)
		{
			return;
		}
		Vector3 vector = base.transform.TransformDirection(Axis);
		_ = base.transform.position + vector * MaxDistance;
		float magnitude = (base.transform.position - m_StartPosition).magnitude;
		float num = 0f;
		if (m_Rigidbody.SweepTest(-vector, out var hitInfo, ReturnSpeed * Time.deltaTime + 0.005f))
		{
			if (hitInfo.collider.transform.name.Contains("Finger") || hitInfo.collider.transform.name.Contains("coll") || hitInfo.collider.transform.name.Contains("PvrController"))
			{
				num = ReturnSpeed * Time.deltaTime - hitInfo.distance;
			}
		}
		else
		{
			num -= ReturnSpeed * Time.deltaTime;
		}
		float num2 = Mathf.Clamp(magnitude + num, 0f, MaxDistance);
		m_Rigidbody.position = m_StartPosition + vector * num2;
		if (!m_Pressed && Mathf.Approximately(num2, MaxDistance))
		{
			m_Pressed = true;
			MonoSingleton<SoundMgr>.Instance().PlaySound(ButtonPressAudioClip, base.transform.position);
			OnButtonPressed.Invoke();
		}
		else if (m_Pressed && Mathf.Approximately(num2, 0f))
		{
			m_Pressed = false;
			MonoSingleton<SoundMgr>.Instance().PlaySound(ButtonReleaseAudioClip, base.transform.position);
			OnButtonReleased.Invoke();
		}
	}

	private void OnDestroy()
	{
		ContentLoader.OnAnimationCompleted = (Action)Delegate.Remove(ContentLoader.OnAnimationCompleted, new Action(SetReady));
		ContentLoader.onContentChanged = (Action)Delegate.Remove(ContentLoader.onContentChanged, new Action(SetNonReady));
	}
}
public class DialInteractable : Interactable
{
	public enum InteractionType
	{
		ControllerRotation,
		ControllerPull
	}

	[Serializable]
	public class DialTurnedAngleEvent : UnityEvent<float>
	{
	}

	[Serializable]
	public class DialTurnedStepEvent : UnityEvent<int>
	{
	}

	[Serializable]
	public class DialChangedEvent : UnityEvent<DialInteractable>
	{
	}

	public InteractionType DialType;

	public Rigidbody RotatingRigidbody;

	public Vector3 LocalRotationAxis;

	public Vector3 LocalAxisStart;

	public float RotationAngleMaximum;

	[Tooltip("If 0, this is a float dial going from 0 to 1, if not 0, that dial is int with that many steps")]
	public int Steps;

	public bool SnapOnRelease = true;

	public AudioClip SnapAudioClip;

	public DialTurnedAngleEvent OnDialAngleChanged;

	public DialTurnedStepEvent OnDialStepChanged;

	public DialChangedEvent OnDialChanged;

	private Interactor m_GrabbingInteractor;

	private Quaternion m_GrabbedRotation;

	private Vector3 m_StartingWorldAxis;

	private float m_CurrentAngle;

	private int m_CurrentStep;

	private float m_StepSize;

	private Transform m_SyncTransform;

	private Transform m_OriginalTransform;

	public float CurrentAngle => m_CurrentAngle;

	public int CurrentStep => m_CurrentStep;

	protected internal override void Start()
	{
		base.Start();
		LocalAxisStart.Normalize();
		LocalRotationAxis.Normalize();
		if (RotatingRigidbody == null)
		{
			RotatingRigidbody = GetComponentInChildren<Rigidbody>();
		}
		m_CurrentAngle = 0f;
		GameObject gameObject = new GameObject("Dial_Start_Copy");
		m_OriginalTransform = gameObject.transform;
		m_OriginalTransform.SetParent(base.transform.parent);
		m_OriginalTransform.localRotation = base.transform.localRotation;
		m_OriginalTransform.localPosition = base.transform.localPosition;
		if (Steps > 0)
		{
			m_StepSize = RotationAngleMaximum / (float)Steps;
		}
		else
		{
			m_StepSize = 0f;
		}
	}

	public override void ProcessInteractable()
	{
		if (!base.isSelected)
		{
			return;
		}
		m_StartingWorldAxis = m_OriginalTransform.TransformDirection(LocalAxisStart);
		Vector3 vector = m_SyncTransform.TransformDirection(LocalAxisStart);
		Vector3 axis = m_SyncTransform.TransformDirection(LocalRotationAxis);
		float num = 0f;
		Vector3 vector2 = vector;
		if (DialType == InteractionType.ControllerRotation)
		{
			vector2 = m_GrabbingInteractor.transform.rotation * Quaternion.Inverse(m_GrabbedRotation) * vector;
			num = Vector3.SignedAngle(m_StartingWorldAxis, vector2, axis);
			if (num < 0f)
			{
				num = 360f + num;
			}
		}
		else
		{
			Vector3 vector3 = m_GrabbingInteractor.transform.position - base.transform.position;
			vector3.Normalize();
			vector2 = vector3;
			num = Vector3.SignedAngle(m_StartingWorldAxis, vector2, axis);
			if (num < 0f)
			{
				num = 360f + num;
			}
		}
		if (num > RotationAngleMaximum)
		{
			float num2 = 360f - num;
			float num3 = num - RotationAngleMaximum;
			num = ((!(num2 < num3)) ? RotationAngleMaximum : 0f);
		}
		float num4 = num;
		if (!SnapOnRelease && Steps > 0)
		{
			int num5 = Mathf.RoundToInt(num / m_StepSize);
			num4 = (float)num5 * m_StepSize;
			if (!Mathf.Approximately(num4, m_CurrentAngle))
			{
				MonoSingleton<SoundMgr>.Instance().PlaySound(SnapAudioClip, base.transform.position);
				OnDialStepChanged.Invoke(num5);
				OnDialChanged.Invoke(this);
				m_CurrentStep = num5;
			}
		}
		vector2 = Quaternion.AngleAxis(num, axis) * m_StartingWorldAxis;
		num = Vector3.SignedAngle(vector, vector2, axis);
		Quaternion rotation = Quaternion.AngleAxis(num, axis) * m_SyncTransform.rotation;
		vector2 = Quaternion.AngleAxis(num4, axis) * m_StartingWorldAxis;
		m_CurrentAngle = num4;
		OnDialAngleChanged.Invoke(num4);
		OnDialChanged.Invoke(this);
		num4 = Vector3.SignedAngle(vector, vector2, axis);
		Quaternion quaternion = Quaternion.AngleAxis(num4, axis) * m_SyncTransform.rotation;
		if (RotatingRigidbody != null)
		{
			RotatingRigidbody.MoveRotation(quaternion);
		}
		else
		{
			base.transform.rotation = quaternion;
		}
		m_SyncTransform.transform.rotation = rotation;
		m_GrabbedRotation = m_GrabbingInteractor.transform.rotation;
	}

	protected internal override void OnSelectEnter(Interactor interactor)
	{
		m_GrabbedRotation = interactor.transform.rotation;
		m_GrabbingInteractor = interactor;
		GameObject gameObject = new GameObject("TEMP_DialSyncTransform");
		m_SyncTransform = gameObject.transform;
		if (RotatingRigidbody != null)
		{
			m_SyncTransform.rotation = RotatingRigidbody.transform.rotation;
			m_SyncTransform.position = RotatingRigidbody.position;
		}
		else
		{
			m_SyncTransform.rotation = base.transform.rotation;
			m_SyncTransform.position = base.transform.position;
		}
		base.OnSelectEnter(interactor);
	}

	protected internal override void OnSelectExit(Interactor interactor)
	{
		base.OnSelectExit(interactor);
		if (SnapOnRelease && Steps > 0)
		{
			Vector3 vector = base.transform.TransformDirection(LocalAxisStart);
			Vector3 axis = base.transform.TransformDirection(LocalRotationAxis);
			float num = Vector3.SignedAngle(m_StartingWorldAxis, vector, axis);
			if (num < 0f)
			{
				num = 360f + num;
			}
			int num2 = Mathf.RoundToInt(num / m_StepSize);
			num = (float)num2 * m_StepSize;
			if (num != m_CurrentAngle)
			{
				MonoSingleton<SoundMgr>.Instance().PlaySound(SnapAudioClip, base.transform.position);
				OnDialStepChanged.Invoke(num2);
				OnDialChanged.Invoke(this);
				m_CurrentStep = num2;
			}
			Vector3 to = Quaternion.AngleAxis(num, axis) * m_StartingWorldAxis;
			num = (m_CurrentAngle = Vector3.SignedAngle(vector, to, axis));
			if (RotatingRigidbody != null)
			{
				Quaternion rot = Quaternion.AngleAxis(num, axis) * RotatingRigidbody.rotation;
				RotatingRigidbody.MoveRotation(rot);
			}
			else
			{
				Quaternion rotation = Quaternion.AngleAxis(num, axis) * base.transform.rotation;
				base.transform.rotation = rotation;
			}
		}
		UnityEngine.Object.Destroy(m_SyncTransform.gameObject);
	}
}
public class Grabbable : MonoBehaviour
{
	[SerializeField]
	protected bool m_allowOffhandGrab = true;

	[SerializeField]
	protected bool m_snapPosition;

	[SerializeField]
	protected bool m_snapOrientation;

	[SerializeField]
	protected Transform m_snapOffset;

	[SerializeField]
	protected Collider[] m_grabPoints;

	protected bool m_grabbedKinematic;

	protected Collider m_grabbedCollider;

	protected Grabber m_grabbedBy;

	public bool allowOffhandGrab
	{
		get
		{
			return m_allowOffhandGrab;
		}
		set
		{
			allowOffhandGrab = value;
		}
	}

	public bool isGrabbed => m_grabbedBy != null;

	public bool snapPosition => m_snapPosition;

	public bool snapOrientation => m_snapOrientation;

	public Transform snapOffset => m_snapOffset;

	public Grabber grabbedBy => m_grabbedBy;

	public Transform grabbedTransform => m_grabbedCollider.transform;

	public Rigidbody grabbedRigidbody => m_grabbedCollider.attachedRigidbody;

	public Collider[] grabPoints => m_grabPoints;

	public virtual void GrabBegin(Grabber hand, Collider grabPoint)
	{
		m_grabbedBy = hand;
		m_grabbedCollider = grabPoint;
		base.gameObject.GetComponent<Rigidbody>().isKinematic = true;
	}

	public virtual void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
	{
		Rigidbody component = base.gameObject.GetComponent<Rigidbody>();
		component.isKinematic = m_grabbedKinematic;
		component.velocity = linearVelocity;
		component.angularVelocity = angularVelocity;
		m_grabbedBy = null;
		m_grabbedCollider = null;
	}

	private void Awake()
	{
		if (m_grabPoints.Length == 0)
		{
			Collider component = GetComponent<Collider>();
			if (component == null)
			{
				throw new ArgumentException("Grabbables cannot have zero grab points and no collider -- please add a grab point or collider.");
			}
			m_grabPoints = new Collider[1] { component };
		}
	}

	protected virtual void Start()
	{
		m_grabbedKinematic = GetComponent<Rigidbody>().isKinematic;
	}

	private void OnDestroy()
	{
		if (m_grabbedBy != null)
		{
			m_grabbedBy.ForceRelease(this);
		}
	}
}
public class GrabInteractable : Interactable
{
	private const float k_DefaultTighteningAmount = 0.5f;

	private const float k_DefaultSmoothingAmount = 5f;

	private const float k_VelocityPredictionFactor = 0.6f;

	private const float k_AngularVelocityDamping = 0.95f;

	private const int k_ThrowSmoothingFrameCount = 20;

	private const float k_DefaultAttachEaseInTime = 0.15f;

	private const float k_DefaultThrowSmoothingDuration = 0.25f;

	private const float k_DefaultThrowVelocityScale = 1.5f;

	private const float k_DefaultThrowAngularVelocityScale = 0.25f;

	[SerializeField]
	private Transform m_AttachTransform;

	[SerializeField]
	private float m_AttachEaseInTime = 0.15f;

	[SerializeField]
	private MovementType m_MovementType = MovementType.Kinematic;

	[SerializeField]
	private bool snapPosition;

	[SerializeField]
	private bool snapRotation;

	[SerializeField]
	private bool m_TrackPosition = true;

	[SerializeField]
	private bool m_SmoothPosition;

	[SerializeField]
	[Range(0f, 20f)]
	private float m_SmoothPositionAmount = 5f;

	[SerializeField]
	[Range(0f, 1f)]
	private float m_TightenPosition = 0.5f;

	[SerializeField]
	private bool m_TrackRotation = true;

	[SerializeField]
	private bool m_SmoothRotation;

	[SerializeField]
	[Range(0f, 20f)]
	private float m_SmoothRotationAmount = 5f;

	[SerializeField]
	[Range(0f, 1f)]
	private float m_TightenRotation = 0.5f;

	[SerializeField]
	private bool m_ThrowOnDetach = true;

	[SerializeField]
	private float m_ThrowSmoothingDuration = 0.25f;

	[SerializeField]
	[Tooltip("The curve to use to weight velocity smoothing (most recent frames to the right.")]
	private AnimationCurve m_ThrowSmoothingCurve = AnimationCurve.Linear(1f, 1f, 1f, 0f);

	[SerializeField]
	private float m_ThrowVelocityScale = 1.5f;

	[SerializeField]
	private float m_ThrowAngularVelocityScale = 0.25f;

	[SerializeField]
	private bool m_GravityOnDetach;

	[SerializeField]
	private bool m_RetainTransformParent = true;

	private bool m_WasKinematic;

	private bool m_UsedGravity;

	private Transform m_OriginalSceneParent;

	private Interactor m_SelectingInteractor;

	private Vector3 m_InteractorLocalPosition;

	private Quaternion m_InteractorLocalRotation;

	private Vector3 m_TargetWorldPosition;

	private Quaternion m_TargetWorldRotation;

	private float m_CurrentAttachEaseTime;

	private MovementType m_CurrentMovementType;

	private bool m_DetachInLateUpdate;

	private Vector3 m_DetachVelocity;

	private Vector3 m_DetachAngularVelocity;

	private int m_ThrowSmoothingCurrentFrame;

	private float[] m_ThrowSmoothingFrameTimes = new float[20];

	private Vector3[] m_ThrowSmoothingVelocityFrames = new Vector3[20];

	private Vector3[] m_ThrowSmoothingAngularVelocityFrames = new Vector3[20];

	private Rigidbody m_RigidBody;

	private Vector3 m_LastPosition;

	private Quaternion m_LastRotation;

	public Transform attachTransform
	{
		get
		{
			return m_AttachTransform;
		}
		set
		{
			m_AttachTransform = value;
		}
	}

	public float attachEaseInTime
	{
		get
		{
			return m_AttachEaseInTime;
		}
		set
		{
			m_AttachEaseInTime = value;
		}
	}

	public MovementType movementType
	{
		get
		{
			return m_MovementType;
		}
		set
		{
			m_MovementType = value;
		}
	}

	public bool trackPosition
	{
		get
		{
			return m_TrackPosition;
		}
		set
		{
			m_TrackPosition = value;
		}
	}

	public bool smoothPosition
	{
		get
		{
			return m_SmoothPosition;
		}
		set
		{
			m_SmoothPosition = value;
		}
	}

	public float smoothPositionAmount
	{
		get
		{
			return m_SmoothPositionAmount;
		}
		set
		{
			m_SmoothPositionAmount = value;
		}
	}

	public float tightenPosition
	{
		get
		{
			return m_TightenPosition;
		}
		set
		{
			m_TightenPosition = value;
		}
	}

	public bool trackRotation
	{
		get
		{
			return m_TrackRotation;
		}
		set
		{
			m_TrackRotation = value;
		}
	}

	public bool smoothRotation
	{
		get
		{
			return m_SmoothRotation;
		}
		set
		{
			m_SmoothRotation = value;
		}
	}

	public float smoothRotationAmount
	{
		get
		{
			return m_SmoothRotationAmount;
		}
		set
		{
			m_SmoothRotationAmount = value;
		}
	}

	public float tightenRotation
	{
		get
		{
			return m_TightenRotation;
		}
		set
		{
			m_TightenRotation = value;
		}
	}

	public bool throwOnDetach
	{
		get
		{
			return m_ThrowOnDetach;
		}
		set
		{
			m_ThrowOnDetach = value;
		}
	}

	public float throwSmoothingDuration
	{
		get
		{
			return m_ThrowSmoothingDuration;
		}
		set
		{
			m_ThrowSmoothingDuration = value;
		}
	}

	public float throwVelocityScale
	{
		get
		{
			return m_ThrowVelocityScale;
		}
		set
		{
			m_ThrowVelocityScale = value;
		}
	}

	public float throwAngularVelocityScale
	{
		get
		{
			return m_ThrowAngularVelocityScale;
		}
		set
		{
			m_ThrowAngularVelocityScale = value;
		}
	}

	public bool gravityOnDetach
	{
		get
		{
			return m_GravityOnDetach;
		}
		set
		{
			m_GravityOnDetach = value;
		}
	}

	public bool retainTransformParent
	{
		get
		{
			return m_RetainTransformParent;
		}
		set
		{
			m_RetainTransformParent = value;
		}
	}

	public Interactor selectingInteractor => m_SelectingInteractor;

	protected override void Awake()
	{
		base.Awake();
		m_CurrentMovementType = m_MovementType;
		if (m_RigidBody == null)
		{
			m_RigidBody = GetComponent<Rigidbody>();
		}
		if (m_RigidBody == null)
		{
			UnityEngine.Debug.LogWarning("Grab Interactable does not have a required RigidBody.", this);
		}
		m_WasKinematic = m_RigidBody.isKinematic;
		m_UsedGravity = m_RigidBody.useGravity;
	}

	private void Update()
	{
		if (base.isSelected)
		{
			UpdateTarget(Time.unscaledDeltaTime);
			SmoothVelocityUpdate();
			if (m_CurrentMovementType == MovementType.Instantaneous)
			{
				PerformInstantaneousUpdate(Time.unscaledDeltaTime);
			}
		}
	}

	private void LateUpdate()
	{
		if (m_DetachInLateUpdate)
		{
			if (!m_SelectingInteractor)
			{
				Detach();
			}
			m_DetachInLateUpdate = false;
		}
	}

	public override void ProcessInteractable()
	{
		if (base.isSelected)
		{
			if (m_CurrentMovementType == MovementType.Kinematic)
			{
				PerformKinematicUpdate(Time.unscaledDeltaTime);
			}
			else if (m_CurrentMovementType == MovementType.VelocityTracking)
			{
				PerformVelocityTrackingUpdate(Time.unscaledDeltaTime);
			}
		}
	}

	private Vector3 GetWorldAttachPosition(Interactor interactor)
	{
		if (interactor.attachTransform == null)
		{
			return m_RigidBody.worldCenterOfMass;
		}
		return interactor.attachTransform.position + interactor.attachTransform.rotation * m_InteractorLocalPosition;
	}

	private Quaternion GetWorldAttachRotation(Interactor interactor)
	{
		if (interactor.attachTransform == null)
		{
			return m_RigidBody.rotation;
		}
		UnityEngine.Debug.Log("interactor.attachTransform.rotation:" + interactor.attachTransform.rotation);
		UnityEngine.Debug.Log("m_InteractorLocalRotation:" + m_InteractorLocalRotation);
		return interactor.attachTransform.rotation * m_InteractorLocalRotation;
	}

	private void UpdateTarget(float timeDelta)
	{
		if (m_AttachEaseInTime > 0f && m_CurrentAttachEaseTime <= m_AttachEaseInTime)
		{
			float t = m_CurrentAttachEaseTime / m_AttachEaseInTime;
			m_TargetWorldPosition = Vector3.Lerp(m_TargetWorldPosition, GetWorldAttachPosition(m_SelectingInteractor), t);
			m_TargetWorldRotation = Quaternion.Slerp(m_TargetWorldRotation, GetWorldAttachRotation(m_SelectingInteractor), t);
			m_CurrentAttachEaseTime += Time.unscaledDeltaTime;
			return;
		}
		if (m_SmoothPosition)
		{
			m_TargetWorldPosition = Vector3.Lerp(m_TargetWorldPosition, GetWorldAttachPosition(m_SelectingInteractor), m_SmoothPositionAmount * timeDelta);
			m_TargetWorldPosition = Vector3.Lerp(m_TargetWorldPosition, GetWorldAttachPosition(m_SelectingInteractor), m_TightenPosition);
		}
		else
		{
			m_TargetWorldPosition = GetWorldAttachPosition(m_SelectingInteractor);
		}
		if (m_SmoothRotation)
		{
			m_TargetWorldRotation = Quaternion.Slerp(m_TargetWorldRotation, GetWorldAttachRotation(m_SelectingInteractor), m_SmoothRotationAmount * timeDelta);
			m_TargetWorldRotation = Quaternion.Slerp(m_TargetWorldRotation, GetWorldAttachRotation(m_SelectingInteractor), m_TightenRotation);
		}
		else
		{
			m_TargetWorldRotation = GetWorldAttachRotation(m_SelectingInteractor);
		}
	}

	private void PerformKinematicUpdate(float timeDelta)
	{
		if (trackPosition)
		{
			Vector3 vector = m_TargetWorldPosition - m_RigidBody.worldCenterOfMass;
			m_RigidBody.velocity = Vector3.zero;
			m_RigidBody.MovePosition(m_RigidBody.position + vector);
		}
		if (trackRotation)
		{
			m_RigidBody.angularVelocity = Vector3.zero;
			m_RigidBody.MoveRotation(m_TargetWorldRotation.normalized);
		}
	}

	private void PerformVelocityTrackingUpdate(float timeDelta)
	{
		if (trackPosition)
		{
			m_RigidBody.velocity *= 0.6f;
			Vector3 vector = (m_TargetWorldPosition - m_RigidBody.worldCenterOfMass) / timeDelta;
			if (!float.IsNaN(vector.x))
			{
				m_RigidBody.velocity += vector;
			}
		}
		if (!trackRotation)
		{
			return;
		}
		m_RigidBody.angularVelocity *= 0.6f;
		(m_TargetWorldRotation * Quaternion.Inverse(m_RigidBody.rotation)).ToAngleAxis(out var angle, out var axis);
		if (angle > 180f)
		{
			angle -= 360f;
		}
		if (Mathf.Abs(angle) > Mathf.Epsilon)
		{
			Vector3 vector2 = axis * angle * ((float)Math.PI / 180f) / timeDelta;
			if (!float.IsNaN(vector2.x))
			{
				m_RigidBody.angularVelocity += vector2 * 0.95f;
			}
		}
	}

	private void PerformInstantaneousUpdate(float timeDelta)
	{
		if (trackPosition)
		{
			base.transform.position = m_TargetWorldPosition;
		}
		if (trackRotation)
		{
			base.transform.rotation = m_TargetWorldRotation;
		}
	}

	private void Teleport(Transform teleportTransform)
	{
		if (trackPosition)
		{
			Vector3 translation = teleportTransform.position - m_RigidBody.worldCenterOfMass;
			m_RigidBody.velocity = Vector3.zero;
			base.transform.Translate(translation, Space.World);
		}
		if (trackRotation)
		{
			m_RigidBody.angularVelocity = Vector3.zero;
			m_RigidBody.transform.rotation = teleportTransform.rotation;
		}
	}

	private void Detach()
	{
		if (m_ThrowOnDetach)
		{
			m_RigidBody.velocity = m_DetachVelocity;
			m_RigidBody.angularVelocity = m_DetachAngularVelocity;
		}
	}

	private void UpdateInteractorLocalPose(Interactor interactor)
	{
		Transform transform = (m_AttachTransform ? m_AttachTransform : base.transform);
		Vector3 vector = (m_AttachTransform ? m_AttachTransform.position : m_RigidBody.worldCenterOfMass);
		Vector3 direction = m_RigidBody.worldCenterOfMass - vector;
		Vector3 interactorLocalPosition = transform.InverseTransformDirection(direction);
		Vector3 lossyScale = interactor.attachTransform.lossyScale;
		lossyScale = new Vector3(1f / lossyScale.x, 1f / lossyScale.y, 1f / lossyScale.z);
		interactorLocalPosition.Scale(lossyScale);
		m_InteractorLocalPosition = interactorLocalPosition;
		m_InteractorLocalRotation = Quaternion.Inverse(Quaternion.Inverse(m_RigidBody.rotation) * transform.rotation);
	}

	protected internal override void OnSelectEnter(Interactor interactor)
	{
		if ((bool)interactor)
		{
			base.OnSelectEnter(interactor);
			if (m_SelectingInteractor == null)
			{
				m_OriginalSceneParent = base.transform.parent;
				base.transform.parent = null;
			}
			m_SelectingInteractor = interactor;
			m_RigidBody.isKinematic = m_CurrentMovementType == MovementType.Kinematic;
			m_RigidBody.useGravity = false;
			m_RigidBody.drag = 0f;
			m_RigidBody.angularDrag = 0f;
			m_DetachVelocity = (m_DetachAngularVelocity = Vector3.zero);
			UpdateInteractorLocalPose(interactor);
			if (false)
			{
				Teleport(m_SelectingInteractor.attachTransform);
			}
			else if (m_AttachEaseInTime > 0f)
			{
				m_TargetWorldPosition = m_RigidBody.worldCenterOfMass;
				m_TargetWorldRotation = base.transform.rotation;
				m_CurrentAttachEaseTime = 0f;
			}
			SmoothVelocityStart();
		}
	}

	protected internal override void OnSelectExit(Interactor interactor)
	{
		base.OnSelectExit(interactor);
		if (m_RetainTransformParent)
		{
			base.transform.parent = m_OriginalSceneParent;
		}
		m_RigidBody.isKinematic = m_WasKinematic;
		m_RigidBody.useGravity = m_UsedGravity | m_GravityOnDetach;
		m_CurrentMovementType = m_MovementType;
		m_SelectingInteractor = null;
		m_DetachInLateUpdate = true;
		SmoothVelocityEnd();
	}

	private void SmoothVelocityStart()
	{
		if ((bool)m_SelectingInteractor)
		{
			m_LastPosition = m_SelectingInteractor.attachTransform.position;
			m_LastRotation = m_SelectingInteractor.attachTransform.rotation;
			Array.Clear(m_ThrowSmoothingFrameTimes, 0, m_ThrowSmoothingFrameTimes.Length);
			Array.Clear(m_ThrowSmoothingVelocityFrames, 0, m_ThrowSmoothingVelocityFrames.Length);
			Array.Clear(m_ThrowSmoothingAngularVelocityFrames, 0, m_ThrowSmoothingAngularVelocityFrames.Length);
			m_ThrowSmoothingCurrentFrame = 0;
		}
	}

	private void SmoothVelocityEnd()
	{
		if (m_ThrowOnDetach)
		{
			Vector3 smoothedVelocityValue = getSmoothedVelocityValue(m_ThrowSmoothingVelocityFrames);
			Vector3 smoothedVelocityValue2 = getSmoothedVelocityValue(m_ThrowSmoothingAngularVelocityFrames);
			m_DetachVelocity = smoothedVelocityValue * m_ThrowVelocityScale;
			m_DetachAngularVelocity = smoothedVelocityValue2 * m_ThrowAngularVelocityScale;
		}
	}

	private void SmoothVelocityUpdate()
	{
		if ((bool)m_SelectingInteractor)
		{
			m_ThrowSmoothingFrameTimes[m_ThrowSmoothingCurrentFrame] = Time.time;
			m_ThrowSmoothingVelocityFrames[m_ThrowSmoothingCurrentFrame] = (m_SelectingInteractor.attachTransform.position - m_LastPosition) / Time.deltaTime;
			Quaternion quaternion = m_SelectingInteractor.attachTransform.rotation * Quaternion.Inverse(m_LastRotation);
			m_ThrowSmoothingAngularVelocityFrames[m_ThrowSmoothingCurrentFrame] = new Vector3(Mathf.DeltaAngle(0f, quaternion.eulerAngles.x), Mathf.DeltaAngle(0f, quaternion.eulerAngles.y), Mathf.DeltaAngle(0f, quaternion.eulerAngles.z)) / Time.deltaTime * ((float)Math.PI / 180f);
			m_ThrowSmoothingCurrentFrame = (m_ThrowSmoothingCurrentFrame + 1) % 20;
			m_LastPosition = m_SelectingInteractor.attachTransform.position;
			m_LastRotation = m_SelectingInteractor.attachTransform.rotation;
		}
	}

	private Vector3 getSmoothedVelocityValue(Vector3[] velocityFrames)
	{
		Vector3 vector = default(Vector3);
		int i = 0;
		float num = 0f;
		for (; i < 20; i++)
		{
			int num2 = ((m_ThrowSmoothingCurrentFrame - i - 1) % 20 + 20) % 20;
			if (m_ThrowSmoothingFrameTimes[num2] == 0f)
			{
				break;
			}
			float num3 = (Time.time - m_ThrowSmoothingFrameTimes[num2]) / m_ThrowSmoothingDuration;
			float num4 = m_ThrowSmoothingCurve.Evaluate(Mathf.Clamp(1f - num3, 0f, 1f));
			vector += velocityFrames[num2] * num4;
			num += num4;
			if (Time.time - m_ThrowSmoothingFrameTimes[num2] > m_ThrowSmoothingDuration)
			{
				break;
			}
		}
		if (num > 0f)
		{
			return vector / num;
		}
		return Vector3.zero;
	}
}
public abstract class Interactable : MonoBehaviour
{
	public enum MovementType
	{
		VelocityTracking,
		Kinematic,
		Instantaneous
	}

	[Serializable]
	public class InteractorEvent : UnityEvent<Interactor>
	{
	}

	public InteractorEvent m_OnSelectEnter;

	public InteractorEvent m_OnSelectExit;

	public InteractorEvent m_OnHoverEnter;

	public InteractorEvent m_OnHoverExit;

	public InteractorEvent m_OnActivate;

	public InteractorEvent m_OnDeactivate;

	[SerializeField]
	protected Collider[] m_interactablePoints;

	protected Interactor m_interactedBy;

	protected bool m_Kinematic;

	protected Collider m_interactedCollider;

	private static AudioClip collisionSound;

	private Renderer[] renderes;

	private Color highlightColor = new Color(0.2f, 0.8f, 0.7f);

	private SoundMgr.PlayParameters soundPara;

	public Collider[] interactablePoints => m_interactablePoints;

	public Interactor interactedBy => m_interactedBy;

	public bool isHovered { get; private set; }

	public bool isSelected { get; private set; }

	public bool isInteracted => m_interactedBy != null;

	protected virtual void Awake()
	{
		if (m_interactablePoints.Length == 0)
		{
			Collider[] componentsInChildren = GetComponentsInChildren<Collider>();
			if (componentsInChildren == null || componentsInChildren.Length == 0)
			{
				throw new ArgumentException("Grabbables cannot have zero grab points and no collider -- please add a grab point or collider.");
			}
			m_interactablePoints = componentsInChildren;
		}
	}

	protected internal virtual void Start()
	{
		renderes = GetComponentsInChildren<Renderer>();
		Highlight(on: false);
		if (collisionSound == null)
		{
			collisionSound = Resources.Load<AudioClip>("hitobject");
		}
		soundPara = new SoundMgr.PlayParameters
		{
			Pitch = 1f,
			SourceID = 1000 + GetInstanceID(),
			Volume = 0.5f
		};
	}

	public void Highlight(bool on)
	{
		if (renderes == null)
		{
			return;
		}
		if (on)
		{
			Renderer[] array = renderes;
			for (int i = 0; i < array.Length; i++)
			{
				array[i]?.material?.SetColor("_EmissionColor", highlightColor);
			}
		}
		else
		{
			Renderer[] array = renderes;
			for (int i = 0; i < array.Length; i++)
			{
				array[i]?.material?.SetColor("_EmissionColor", Color.black);
			}
		}
	}

	private void FixedUpdate()
	{
		ProcessInteractable();
	}

	protected internal virtual void OnSelectEnter(Interactor interactor)
	{
		isSelected = true;
		MonoSingleton<InputHandler>.Instance().SetContollerVibration(0.05f, 0.1f, interactor.m_controller);
		Highlight(on: false);
		m_OnSelectEnter?.Invoke(interactor);
	}

	protected internal virtual void OnSelectExit(Interactor interactor)
	{
		isSelected = false;
		MonoSingleton<InputHandler>.Instance().SetContollerVibration(0f, 0f, interactor.m_controller);
		Highlight(on: false);
		m_OnSelectExit?.Invoke(interactor);
	}

	protected internal virtual void OnHoverEnter(Interactor interactor)
	{
		isHovered = true;
		m_OnHoverEnter?.Invoke(interactor);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (!(Time.timeSinceLevelLoad < 1f) && !collision.collider.gameObject.name.Contains("drawer"))
		{
			MonoSingleton<SoundMgr>.Instance().PlaySound(collisionSound, base.transform.position, 0f, soundPara);
		}
	}

	protected internal virtual void OnHoverExit(Interactor interactor)
	{
		isHovered = false;
		Highlight(on: false);
		m_OnHoverExit?.Invoke(interactor);
	}

	protected internal virtual void OnActivate(Interactor interactor)
	{
		m_OnActivate?.Invoke(interactor);
	}

	protected internal virtual void OnDeactivate(Interactor interactor)
	{
		m_OnDeactivate?.Invoke(interactor);
	}

	public virtual void ProcessInteractable()
	{
	}

	public virtual void GrabBegin(Interactor interactor)
	{
		m_interactedBy = interactor;
	}

	public virtual void GrabEnd()
	{
		m_interactedBy = null;
	}
}
public class OffsetGrabbable : GrabInteractable
{
	private class SavedTransform
	{
		public Vector3 OriginalPosition;

		public Quaternion OriginalRotation;
	}

	private Dictionary<Interactor, SavedTransform> m_SavedTransforms = new Dictionary<Interactor, SavedTransform>();

	private Rigidbody m_Rb;

	protected override void Awake()
	{
		base.Awake();
		m_Rb = GetComponent<Rigidbody>();
	}

	protected internal override void OnSelectEnter(Interactor interactor)
	{
		SavedTransform savedTransform = new SavedTransform();
		savedTransform.OriginalPosition = interactor.attachTransform.localPosition;
		savedTransform.OriginalRotation = interactor.attachTransform.localRotation;
		m_SavedTransforms[interactor] = savedTransform;
		bool flag = base.attachTransform != null;
		interactor.attachTransform.position = (flag ? base.attachTransform.position : m_Rb.worldCenterOfMass);
		interactor.attachTransform.rotation = (flag ? base.attachTransform.rotation : m_Rb.rotation);
		base.OnSelectEnter(interactor);
	}

	protected internal override void OnSelectExit(Interactor interactor)
	{
		SavedTransform value = null;
		if (m_SavedTransforms.TryGetValue(interactor, out value))
		{
			interactor.attachTransform.localPosition = value.OriginalPosition;
			interactor.attachTransform.localRotation = value.OriginalRotation;
			m_SavedTransforms.Remove(interactor);
		}
		base.OnSelectExit(interactor);
	}
}
public class RotationInteractable : Interactable
{
	public Rigidbody RotatingRigidbody;

	public Vector3 LocalRotationAxis;

	public Vector3 LocalAxisStart;

	public float RotationAngleMaximum;

	private Quaternion start;

	private float outAngle;

	private Vector3 lastHandProjected;

	private Interactor m_GrabbingInteractor;

	private Transform m_SyncTransform;

	private Transform m_OriginalTransform;

	private Vector3 m_StartingWorldAxis;

	private Vector3 worldPlaneNormal;

	protected internal override void Start()
	{
		base.Start();
		if (RotatingRigidbody == null)
		{
			RotatingRigidbody = GetComponentInChildren<Rigidbody>();
		}
		outAngle = 0f;
		start = RotatingRigidbody.rotation;
		if ((bool)RotatingRigidbody.transform.parent)
		{
			worldPlaneNormal = RotatingRigidbody.transform.parent.localToWorldMatrix.MultiplyVector(LocalRotationAxis).normalized;
		}
		GameObject gameObject = new GameObject("Rotation_Start_Copy");
		m_OriginalTransform = gameObject.transform;
		m_OriginalTransform.SetParent(base.transform.parent);
		m_OriginalTransform.localRotation = base.transform.localRotation;
		m_OriginalTransform.localPosition = base.transform.localPosition;
	}

	protected internal override void OnSelectEnter(Interactor interactor)
	{
		m_GrabbingInteractor = interactor;
		GameObject gameObject = new GameObject("TEMP_RotSyncTransform");
		m_SyncTransform = gameObject.transform;
		if (RotatingRigidbody != null)
		{
			m_SyncTransform.rotation = RotatingRigidbody.transform.rotation;
			m_SyncTransform.position = RotatingRigidbody.position;
		}
		else
		{
			m_SyncTransform.rotation = base.transform.rotation;
			m_SyncTransform.position = base.transform.position;
		}
		lastHandProjected = ComputeToTransformProjected(interactor.attachTransform);
		ComputeAngle(interactor);
		Quaternion quaternion = start * Quaternion.AngleAxis(outAngle, LocalRotationAxis);
		if (RotatingRigidbody != null)
		{
			RotatingRigidbody.MoveRotation(quaternion);
		}
		else
		{
			base.transform.rotation = quaternion;
		}
		base.OnSelectEnter(interactor);
	}

	private void ComputeAngle(Interactor interactor)
	{
		Vector3 vector = ComputeToTransformProjected(interactor.attachTransform);
		if (vector.Equals(lastHandProjected))
		{
			return;
		}
		float num = Vector3.Angle(lastHandProjected, vector);
		if (num > 0f)
		{
			Vector3 normalized = Vector3.Cross(lastHandProjected, vector).normalized;
			float num2 = Vector3.Dot(worldPlaneNormal, normalized);
			float num3 = num;
			if (num2 < 0f)
			{
				num3 = 0f - num3;
			}
			outAngle += num3;
			lastHandProjected = vector;
		}
	}

	protected internal override void OnSelectExit(Interactor interactor)
	{
		base.OnSelectExit(interactor);
		UnityEngine.Object.Destroy(m_SyncTransform.gameObject);
	}

	public override void ProcessInteractable()
	{
		if (base.isSelected)
		{
			ComputeAngle(m_GrabbingInteractor);
			Quaternion quaternion = start * Quaternion.AngleAxis(outAngle, LocalRotationAxis);
			if (RotatingRigidbody != null)
			{
				RotatingRigidbody.MoveRotation(quaternion);
			}
			else
			{
				base.transform.rotation = quaternion;
			}
		}
	}

	private Vector3 ComputeToTransformProjected(Transform xForm)
	{
		Vector3 normalized = (xForm.position - RotatingRigidbody.transform.position).normalized;
		Vector3 result = new Vector3(0f, 0f, 0f);
		if (normalized.sqrMagnitude > 0f)
		{
			return Vector3.ProjectOnPlane(normalized, worldPlaneNormal).normalized;
		}
		return result;
	}
}
internal class LanCode
{
	internal static string Welcome = "Welcome";

	internal static string ChooseProfile = "ChooseProfile";

	internal static string CreatorIntro = "CreatorIntro";

	internal static string ExploreCompleted = "ExploreCompleted";

	internal static string ExploreInstruction = "ExploreInstruction";

	internal static string SplitIntro = "SplitIntro";

	internal static string HiddenCubeHint = "HiddenCubeHint";

	internal static string HiddenCube = "HiddenCube";

	internal static string GuideIntro = "GuideIntro";

	internal static string CountIntro = "CountIntro";

	internal static string LoadIntro = "LoadIntro";

	internal static string ThreeViewIntro = "ThreeViewIntro";

	internal static string ThreeView = "ThreeView";

	internal static string LoadCubeMemory = "LoadCubeMemory";

	internal static string CubeIntro = "CubeIntro";

	internal static string LoadTangramMemory = "LoadTangramMemory";

	internal static string BlocksIntro = "BlocksIntro";

	internal static string AssessmentCompleted = "AssessmentCompleted";

	internal static string Tangram = "Tangram";

	internal static string ChooseAnswer = "ChooseAnswer";

	internal static string ContinuePlay = "ContinuePlay";

	internal static string LoadSuccess = "LoadSuccess";

	internal static string PlayIntro = "PlayIntro";

	internal static string CrystalIntro = "CrystalIntro";

	internal static string HouseWelcome = "HouseWelcome";

	internal static string LobbyIntro = "LobbyIntro";

	internal static string Openning = "Openning";

	internal static string CreateFailed = "CreateFailed";

	internal static string CreateSuccess = "CreateSuccess";

	internal static string CreateInprogress = "CreateInprogress";

	internal static string AnswerWrong = "AnswerWrong";

	internal static string AnswerRight = "AnswerRight";

	internal static string TakePicture = "TakePicture";

	internal static string AssessmentIntro = "AssessmentIntro";

	internal static string PoolTen = "PoolTen";

	internal static string SplitTen = "SplitTen";

	internal static string Symbol = "Symbol";

	internal static string MatchIntro = "MatchIntro";

	internal static string Cycle = "Cycle";

	internal static string Sudoku = "Sudoku";

	internal static string ChooseItems = "ChooseItems";

	internal static string AlreadyHaveItem = "AlreadyHaveItem";

	internal static string MedalNotEnough = "MedalNotEnough";

	internal static string Create = "Create";

	internal static string PrepareMaterials = "PrepareMaterials";

	internal static string CreateSuccessfully = "CreateSuccessfully";

	internal static string UnneededMaterial = "UnneededMaterial";

	internal static string MaterialNotEnough = "MaterialNotEnough";

	internal static string MaterialTooMuch = "MaterialTooMuch";

	internal static string Basic = "Basic";

	internal static string Junior = "Junior";

	internal static string Senior = "Senior";

	internal static string CameraHint = "CameraHint";

	internal static string SharePhotoHint = "SharePhotoHint";

	internal static string FruiterIntro = "FruiterIntro";

	internal static string CameraIntro = "CameraIntro";

	internal static string PhotoFuncIntro = "PhotoFuncIntro";

	internal static string PhotoIntro = "PhotoIntro";

	internal static string CreatorHint = "CreatorHint";

	internal static string CreatorFruit = "CreatorFruit";

	internal static string ChallengeIntro = "ChallengeIntro";

	internal static string DialInst = "DialInst";

	internal static string DragInst = "DragInst";

	internal static string GrabInst = "GrabInst";

	internal static string GrabComp = "GrabComp";

	internal static string PadIntro = "PadIntro";

	internal static string MedalIntro = "MedalIntro";

	internal static string MedalCompleted = "MedalCompleted";

	internal static string VendingIntro = "VendingIntro";

	internal static string VendingCompleted = "VendingCompleted";
}
public class LevelRecorder : Framework.Singleton<LevelRecorder>
{
	private bool open;

	public int Get(string key)
	{
		if (PlayerPrefs.HasKey(key) && open)
		{
			return PlayerPrefs.GetInt(key);
		}
		return 0;
	}

	public void Set(string key, int level)
	{
		PlayerPrefs.SetInt(key, level);
	}
}
[CreateAssetMenu(menuName = "CreateLocalizedAsset")]
internal class LocalizedAsset : ScriptableObject
{
	public List<LocalizedLang> languages;
}
[Serializable]
internal class LocalizedLang
{
	public string language;

	public List<AudioAsset> audios;
}
[Serializable]
internal class AudioAsset
{
	public string key;

	public AudioClip clip;
}
internal class SLocalization : MonoSingleton<SLocalization>
{
	public LocalizedAsset localizedAsset;

	public static string defaultLanguage = "English";

	private static LocalizedLang localizedLang;

	private void Start()
	{
		UnityEngine.Object.DontDestroyOnLoad(this);
		SetLanguage(defaultLanguage);
	}

	public static AudioClip GetAudio(string name)
	{
		foreach (AudioAsset audio in localizedLang.audios)
		{
			if (audio.key.Equals(name))
			{
				return audio.clip;
			}
		}
		return null;
	}

	public void SetLanguage(string language)
	{
		foreach (LocalizedLang language2 in localizedAsset.languages)
		{
			if (language2.language.Equals(language))
			{
				localizedLang = language2;
				break;
			}
		}
	}
}
public class Loom : MonoBehaviour
{
	public struct NoDelayedQueueItem
	{
		public Action<object> action;

		public object param;
	}

	public struct DelayedQueueItem
	{
		public float time;

		public Action<object> action;

		public object param;
	}

	public static int maxThreads = 8;

	private static int numThreads;

	private static Loom _current;

	private static bool initialized;

	private List<NoDelayedQueueItem> _actions = new List<NoDelayedQueueItem>();

	private List<NoDelayedQueueItem> _currentActions = new List<NoDelayedQueueItem>();

	private List<DelayedQueueItem> _delayed = new List<DelayedQueueItem>();

	private List<DelayedQueueItem> _currentDelayed = new List<DelayedQueueItem>();

	public static Loom Current
	{
		get
		{
			Initialize();
			return _current;
		}
	}

	private void Awake()
	{
		_current = this;
		initialized = true;
	}

	public static void Initialize()
	{
		if (!initialized && Application.isPlaying)
		{
			initialized = true;
			GameObject obj = new GameObject("Loom");
			_current = obj.AddComponent<Loom>();
			UnityEngine.Object.DontDestroyOnLoad(obj);
		}
	}

	public static void QueueOnMainThread(Action<object> taction, object tparam)
	{
		QueueOnMainThread(taction, tparam, 0f);
	}

	public static void QueueOnMainThread(Action<object> taction, object tparam, float time)
	{
		if (time != 0f)
		{
			lock (Current._delayed)
			{
				Current._delayed.Add(new DelayedQueueItem
				{
					time = Time.time + time,
					action = taction,
					param = tparam
				});
				return;
			}
		}
		lock (Current._actions)
		{
			Current._actions.Add(new NoDelayedQueueItem
			{
				action = taction,
				param = tparam
			});
		}
	}

	public static Thread RunAsync(Action a)
	{
		Initialize();
		while (numThreads >= maxThreads)
		{
			Thread.Sleep(100);
		}
		Interlocked.Increment(ref numThreads);
		ThreadPool.QueueUserWorkItem(RunAction, a);
		return null;
	}

	private static void RunAction(object action)
	{
		try
		{
			((Action)action)();
		}
		catch
		{
		}
		finally
		{
			Interlocked.Decrement(ref numThreads);
		}
	}

	private void OnDisable()
	{
		if (_current == this)
		{
			_current = null;
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
		if (_actions.Count > 0)
		{
			lock (_actions)
			{
				_currentActions.Clear();
				_currentActions.AddRange(_actions);
				_actions.Clear();
			}
			for (int i = 0; i < _currentActions.Count; i++)
			{
				_currentActions[i].action(_currentActions[i].param);
			}
		}
		if (_delayed.Count <= 0)
		{
			return;
		}
		lock (_delayed)
		{
			_currentDelayed.Clear();
			_currentDelayed.AddRange(_delayed.Where((DelayedQueueItem d) => d.time <= Time.time));
			for (int j = 0; j < _currentDelayed.Count; j++)
			{
				_delayed.Remove(_currentDelayed[j]);
			}
		}
		for (int k = 0; k < _currentDelayed.Count; k++)
		{
			_currentDelayed[k].action(_currentDelayed[k].param);
		}
	}
}
public class ObjectsUtil : Framework.Singleton<ObjectsUtil>
{
	private Material normalCube;

	public void Restore(bool needPhysics)
	{
		MonoSingleton<CubesMgr>.Instance().Reset();
		UnityEngine.Object[] cubeObjAll = MonoSingleton<CubesMgr>.Instance().GetCubeObjAll();
		for (int i = 0; i < cubeObjAll.Length; i++)
		{
			Transform transform = (Transform)cubeObjAll[i];
			RestoreRendering(transform, isRendering: true);
			SetKinematic(transform, needPhysics);
			if (needPhysics)
			{
				SetCollider(transform, needPhysics);
			}
			RestoreGuidingState(transform, isGuiding: false);
		}
	}

	private void RestoreGuidingState(Transform cubeTransform, bool isGuiding)
	{
		cubeTransform.GetComponent<CubeHandler>().SetGuideState(isGuiding);
	}

	public void RestoreRendering(Transform trans, bool isRendering)
	{
		if (isRendering)
		{
			if (normalCube == null)
			{
				normalCube = Resources.Load<Material>("NormalCube");
			}
			trans.GetComponent<Renderer>().material = normalCube;
			trans.GetComponent<Renderer>().enabled = true;
		}
		else
		{
			trans.GetComponent<Renderer>().enabled = false;
		}
	}

	public void SetKinematic(Transform trans, bool needPhysics)
	{
		if (trans != null)
		{
			trans.GetComponent<Rigidbody>().isKinematic = !needPhysics;
		}
	}

	public void SetKinematic(List<Transform> trans, bool needPhysics)
	{
		if (trans == null)
		{
			return;
		}
		foreach (Transform tran in trans)
		{
			tran.GetComponent<Rigidbody>().isKinematic = !needPhysics;
		}
	}

	public void SetKinematic(List<GameObject> objs, bool needPhysics)
	{
		if (objs == null)
		{
			return;
		}
		foreach (GameObject obj in objs)
		{
			obj.GetComponent<Rigidbody>().isKinematic = !needPhysics;
		}
	}

	public void SetCollider(List<Transform> trans, bool needPhysics)
	{
		if (trans == null)
		{
			return;
		}
		foreach (Transform tran in trans)
		{
			tran.GetComponent<Collider>().enabled = needPhysics;
		}
	}

	public void SetKinematic(UnityEngine.Object[] objs, bool needPhysics)
	{
		if (objs != null)
		{
			for (int i = 0; i < objs.Length; i++)
			{
				Transform trans = (Transform)objs[i];
				SetKinematic(trans, needPhysics);
			}
		}
	}

	public void SetCollider(UnityEngine.Object[] objs, bool needPhysics)
	{
		if (objs != null)
		{
			for (int i = 0; i < objs.Length; i++)
			{
				Transform trans = (Transform)objs[i];
				SetCollider(trans, needPhysics);
			}
		}
	}

	public void SetCollider(Transform trans, bool needPhysics)
	{
		if (trans != null)
		{
			trans.GetComponent<BoxCollider>().enabled = needPhysics;
		}
	}

	public List<Transform> SetObjectsInvisible(UnityEngine.Object[] objects)
	{
		List<Transform> list = new List<Transform>();
		for (int i = 0; i < objects.Length; i++)
		{
			Transform transform = (Transform)objects[i];
			RestoreRendering(transform, isRendering: false);
			list.Add(transform);
		}
		return list;
	}

	public List<Transform> SetObjectsInvisible(List<Transform> trans)
	{
		List<Transform> list = new List<Transform>();
		foreach (Transform tran in trans)
		{
			RestoreRendering(tran, isRendering: false);
			list.Add(tran);
		}
		return list;
	}

	public void Destroy(List<Transform> transforms, float delay)
	{
		if (transforms != null)
		{
			for (int i = 0; i < transforms.Count; i++)
			{
				UnityEngine.Object.Destroy(transforms[i].gameObject, delay);
			}
		}
	}
}
public class Outline : MonoBehaviour
{
	public bool highlight;

	private static float t;

	private Material material;

	private float intensity;

	public float maximum = 1f;

	public float minimum = 0.3f;

	public float speed = 1f;

	private void Start()
	{
		material = GetComponent<Renderer>().material;
		intensity = material.GetFloat("_Intensity");
	}

	private void Update()
	{
		if (highlight)
		{
			SwitchAlpha();
		}
	}

	private void SwitchAlpha()
	{
		float num = Mathf.Lerp(minimum, maximum, t);
		intensity = num;
		material.SetFloat("_Intensity", intensity);
		t += speed * Time.deltaTime;
		if (t > 1f)
		{
			float num2 = maximum;
			maximum = minimum;
			minimum = num2;
			t = 0f;
		}
	}

	public void HighLight()
	{
		highlight = true;
		t = 0f;
	}

	public void UndoHighlight()
	{
		intensity = 0f;
		material.SetFloat("_Intensity", intensity);
		highlight = false;
	}
}
public class SoundMgr : MonoSingleton<SoundMgr>
{
	public struct PlayParameters
	{
		public float Pitch;

		public float Volume;

		public int SourceID;

		public bool Loop;
	}

	public class PlayEvent
	{
		public float Time;
	}

	public AudioSource referenceSource;

	public int sourceCount;

	private Dictionary<int, PlayEvent> m_PlayEvents = new Dictionary<int, PlayEvent>();

	private List<int> m_PlayingSources = new List<int>();

	private AudioSource[] sourcePool;

	private int m_UsedSource;

	private List<int> IDToRemove = new List<int>();

	private void Start()
	{
		sourcePool = new AudioSource[sourceCount];
		for (int i = 0; i < sourceCount; i++)
		{
			sourcePool[i] = UnityEngine.Object.Instantiate(referenceSource, base.transform);
			sourcePool[i].gameObject.SetActive(value: false);
		}
	}

	private void Update()
	{
		IDToRemove.Clear();
		foreach (KeyValuePair<int, PlayEvent> playEvent in m_PlayEvents)
		{
			playEvent.Value.Time -= Time.deltaTime;
			if (playEvent.Value.Time <= 0f)
			{
				IDToRemove.Add(playEvent.Key);
			}
		}
		foreach (int item in IDToRemove)
		{
			m_PlayEvents.Remove(item);
		}
		int num;
		for (num = 0; num < m_PlayingSources.Count; num++)
		{
			int num2 = m_PlayingSources[num];
			if (!sourcePool[num2].isPlaying)
			{
				sourcePool[num2].gameObject.SetActive(value: false);
			}
			m_PlayingSources.RemoveAt(num);
			num--;
		}
	}

	public AudioSource GetNewSource()
	{
		return UnityEngine.Object.Instantiate(referenceSource);
	}

	public void PlaySound(AudioClip clip, Vector3 position, float delayedTime = 0f, float cooldownTime = 0.5f)
	{
		PlaySound(clip, position, delayedTime, new PlayParameters
		{
			Pitch = 1f,
			SourceID = 1000 + int.Parse(DateTime.Now.ToString("HHmmssfff")),
			Volume = 1f,
			Loop = false
		}, cooldownTime);
	}

	public void PlaySound(AudioClip clip, float cooldownTime = 0.5f)
	{
		if (clip != null)
		{
			AudioSource.PlayClipAtPoint(clip, base.transform.position);
		}
	}

	public void PauseSound(AudioClip clip)
	{
		if (clip == null)
		{
			return;
		}
		for (int i = 0; i < m_PlayingSources.Count; i++)
		{
			if (clip.name.Equals(sourcePool[i].clip.name))
			{
				sourcePool[i].Pause();
				break;
			}
		}
	}

	public void StopSound(AudioClip clip)
	{
		if (clip == null)
		{
			return;
		}
		for (int i = 0; i < m_PlayingSources.Count; i++)
		{
			if (clip.name.Equals(sourcePool[i].clip.name))
			{
				sourcePool[i].Stop();
			}
		}
	}

	public void PlaySound(AudioClip clip, Vector3 position, float delayedTime, PlayParameters parameters, float cooldownTime = 0.5f)
	{
		if (!(clip == null) && !m_PlayEvents.ContainsKey(parameters.SourceID))
		{
			AudioSource obj = sourcePool[m_UsedSource];
			m_PlayingSources.Add(m_UsedSource);
			m_UsedSource++;
			if (m_UsedSource >= sourcePool.Length)
			{
				m_UsedSource = 0;
			}
			obj.gameObject.SetActive(value: true);
			obj.transform.position = position;
			obj.clip = clip;
			obj.volume = parameters.Volume;
			obj.pitch = parameters.Pitch;
			obj.loop = parameters.Loop;
			m_PlayEvents.Add(parameters.SourceID, new PlayEvent
			{
				Time = cooldownTime
			});
			obj.PlayDelayed(delayedTime);
		}
	}
}
public class SpawnPoint : MonoSingleton<SpawnPoint>
{
	public Transform GetSpawnPoint()
	{
		return base.transform;
	}
}
public class Statistics : MonoSingleton<Statistics>
{
	private class Round
	{
		public long start_ts;

		public long end_ts;

		public int level;

		public bool isCorrect;
	}

	private List<Round> rounds = new List<Round>();

	private Round currentRound;

	private new void Awake()
	{
		Statistics statistics = UnityEngine.Object.FindObjectOfType<Statistics>();
		if (statistics != null && statistics != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void RoundStart(int level)
	{
		long timeStamp = GetTimeStamp();
		currentRound = new Round();
		currentRound.start_ts = timeStamp;
		currentRound.level = level;
		rounds.Add(currentRound);
	}

	public void RoundEnd(bool isCorrect)
	{
		long timeStamp = GetTimeStamp();
		if (currentRound != null)
		{
			currentRound.end_ts = timeStamp;
			currentRound.isCorrect = isCorrect;
		}
	}

	public int GetGrade()
	{
		int num = 0;
		int num2 = 3;
		double[] array = new double[3];
		int[] array2 = new int[3];
		foreach (Round round in rounds)
		{
			int num3 = round.level / num2;
			if (num3 > 2)
			{
				num3 = 2;
			}
			array2[num3]++;
			if (round.isCorrect)
			{
				array[num3] += 1.0;
			}
		}
		for (int i = 0; i < array.Length; i++)
		{
			if (array2[i] > 0)
			{
				array[i] /= array2[i];
			}
			UnityEngine.Debug.Log(">>> stage: " + i + ", correct rate: " + array[i]);
			if (array[i] > 0.9)
			{
				num = i + 1;
			}
		}
		UnityEngine.Debug.Log("score: " + num);
		return num;
	}

	private static long GetTimeStamp(bool useMilliSecond = false)
	{
		TimeSpan timeSpan = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
		return Convert.ToInt64(useMilliSecond ? timeSpan.TotalMilliseconds : timeSpan.TotalSeconds);
	}
}
public class VoiceMgr : MonoSingleton<VoiceMgr>
{
	public AudioSource reference;

	private List<AudioSource> voices;

	protected override void Awake()
	{
		base.Awake();
		voices = new List<AudioSource>();
		GetComponents(voices);
	}

	public AudioSource PlayVoice(string name, float time = 0f)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		AudioSource result = null;
		for (int i = 0; i < voices.Count; i++)
		{
			if (!(voices[i].clip == null))
			{
				if (name.Equals(voices[i].clip.name))
				{
					voices[i].PlayDelayed(time);
					result = voices[i];
				}
				else if (voices[i].isPlaying)
				{
					voices[i].Stop();
				}
			}
		}
		return result;
	}

	public void PlayVoice(AudioClip clip, float time = 0f)
	{
		if (!(clip == null) && PlayVoice(clip.name, time) == null)
		{
			AudioSource audioSource = UnityEngine.Object.Instantiate(reference, base.transform);
			audioSource.clip = clip;
			audioSource.PlayDelayed(time);
			voices.Add(audioSource);
		}
	}

	public AudioSource GetVoice(string name)
	{
		for (int i = 0; i < voices.Count; i++)
		{
			if (name.Equals(voices[i].clip.name))
			{
				return voices[i];
			}
		}
		return null;
	}

	public void Play(string name)
	{
		PlayVoice(SLocalization.GetAudio(name));
	}
}
public class CourseMgr : MonoBehaviour
{
	public GameObject[] courses;

	private int courseCode = -1;

	private void Start()
	{
		for (int i = 0; i < courses.Length; i++)
		{
			courses[i].SetActive(value: false);
		}
	}

	public void SetCourse(int course)
	{
		courseCode = course;
		int courseIndex = GetCourseIndex(course);
		for (int i = 0; i < courses.Length; i++)
		{
			if (i == courseIndex)
			{
				courses[i].SetActive(value: true);
				HouseMgr.SetContentLoader(courses[i].GetComponent<ContentLoader>());
			}
			else
			{
				courses[i].SetActive(value: false);
			}
		}
	}

	private int GetCourseIndex(int course)
	{
		return course;
	}

	public int GetCourse()
	{
		return courseCode;
	}
}
public class CountAnimation : CubeAnimation
{
	public AudioSource stepSound;

	private Material hiddenCubeMaterial;

	private Material originMaterial;

	private TMP_Text numberPrefab;

	private Vector3 offsetVector;

	private List<TMP_Text> numbers;

	private void Awake()
	{
		RegisterEvents();
	}

	protected override void Start()
	{
		base.Start();
		hiddenCubeMaterial = Resources.Load<Material>("HiddenCube");
		numberPrefab = Resources.Load<TMP_Text>("Number");
		offsetVector = new Vector3(0f, 0.05f, 0f);
		numbers = new List<TMP_Text>();
	}

	private IEnumerator Play(float time)
	{
		yield return new WaitForSeconds(time);
		int columnCount = MonoSingleton<CubesMgr>.Instance().GetColumnCount();
		for (int i = 0; i < columnCount; i++)
		{
			List<int> indexes = MonoSingleton<CubesMgr>.Instance().GetColumnIndex(i);
			foreach (int item in indexes)
			{
				Transform transform = (Transform)MonoSingleton<CubesMgr>.Instance().GetCubeObj(item);
				if (originMaterial == null)
				{
					originMaterial = transform.GetComponent<Renderer>().material;
				}
				transform.GetComponent<Renderer>().material = hiddenCubeMaterial;
			}
			Transform transform2 = (Transform)MonoSingleton<CubesMgr>.Instance().GetCubeObj(indexes[indexes.Count - 1]);
			TMP_Text tMP_Text = UnityEngine.Object.Instantiate(numberPrefab, transform2.position + offsetVector, Quaternion.identity, transform2);
			tMP_Text.text = indexes.Count.ToString();
			numbers.Add(tMP_Text);
			stepSound.Play();
			if (i == 0)
			{
				hint.text = indexes.Count.ToString();
			}
			else
			{
				TMP_Text tMP_Text2 = hint;
				tMP_Text2.text = tMP_Text2.text + " + " + indexes.Count;
			}
			yield return new WaitForSeconds(2f);
			foreach (int item2 in indexes)
			{
				((Transform)MonoSingleton<CubesMgr>.Instance().GetCubeObj(item2)).GetComponent<Renderer>().material = originMaterial;
			}
		}
		hint.text = hint.text + " = " + MonoSingleton<CubesMgr>.Instance().GetCubeCount();
		stepSound.Play();
		yield return new WaitForSeconds(3f);
		hint.text = "";
		DestoryNumbers();
		CompletePlay();
	}

	private void DestoryNumbers()
	{
		for (int i = 0; i < numbers.Count; i++)
		{
			UnityEngine.Object.Destroy(numbers[i]);
		}
		numbers.Clear();
	}

	private void OnDestroy()
	{
		UnRegisterEvents();
	}

	protected override void StartTasks()
	{
		Framework.Singleton<ObjectsUtil>.Instance.Restore(needPhysics: false);
		MonoSingleton<Instructions>.Instance().SetText(LanCode.CountIntro);
		AudioSource audioSource = MonoSingleton<VoiceMgr>.Instance().PlayVoice("countinst");
		StartCoroutine(Play(audioSource.clip.length));
	}

	protected override void StopTasks()
	{
		StopAllCoroutines();
		hint.text = "";
		DestoryNumbers();
	}
}
public abstract class CubeAnimation : MonoBehaviour
{
	protected TMP_Text hint;

	protected static bool inProgress;

	public static Action onReset;

	protected virtual void Start()
	{
		hint = MonoSingleton<Instructions>.Instance().GetText();
	}

	protected void RegisterEvents()
	{
		onReset = (Action)Delegate.Combine(onReset, new Action(StopPlay));
	}

	protected void UnRegisterEvents()
	{
		onReset = (Action)Delegate.Remove(onReset, new Action(StopPlay));
	}

	protected void StopPlay()
	{
		StopTasks();
		inProgress = false;
	}

	public void StartPlay()
	{
		if (!inProgress)
		{
			inProgress = true;
			StartTasks();
		}
	}

	protected void CompletePlay()
	{
		inProgress = false;
	}

	protected abstract void StartTasks();

	protected abstract void StopTasks();
}
public class CubeConfigFileHelper : MonoSingleton<CubeConfigFileHelper>
{
	private List<int[]> levels = new List<int[]>();

	private List<int> gridLens = new List<int>();

	public void InitLevels(string cfgfilepath)
	{
		StartCoroutine(InitLevelsFromFile(cfgfilepath));
	}

	private IEnumerator InitLevelsFromFile(string filepath)
	{
		UnityEngine.Debug.Log("Loading levels from file: " + filepath);
		using UnityWebRequest webRequest = UnityWebRequest.Get(filepath);
		yield return webRequest.SendWebRequest();
		if (webRequest.isNetworkError)
		{
			UnityEngine.Debug.Log("Config File Error: " + webRequest.error);
			yield break;
		}
		UnityEngine.Debug.Log("Config File Received: " + webRequest.downloadHandler.text);
		string[] lines = new List<string>(webRequest.downloadHandler.text.Split('\n')).ToArray();
		DoInitLevels(lines);
	}

	internal int[] GetLevel(int index)
	{
		if (levels.Count <= index)
		{
			return new int[0];
		}
		return levels[index];
	}

	private void DoInitLevels(string[] lines)
	{
		List<int[]> list = new List<int[]>();
		List<int> list2 = new List<int>();
		for (int i = 0; i < lines.Length; i++)
		{
			if (lines[i].Length == 0)
			{
				continue;
			}
			string[] array = lines[i].Trim().Split();
			if (array.Length == 0 || array.Length != 1)
			{
				continue;
			}
			i++;
			int num = int.Parse(array[0]);
			UnityEngine.Debug.Log(">>> grid size: " + num);
			int[] array2 = new int[num * num];
			int num2 = num - 1;
			while (num2 >= 0 && i < lines.Length)
			{
				string[] array3 = lines[i].Trim().Split();
				if (array3.Length != num)
				{
					UnityEngine.Debug.Log("ERROR: Invalid config file! Row size does not match grid size. (line index: " + i + ", grid size: " + num + ", row size: " + array3.Length + ")");
					return;
				}
				for (int j = 0; j < array3.Length; j++)
				{
					array2[num2 * num + j] = int.Parse(array3[j]);
				}
				num2--;
				i++;
			}
			i--;
			if (num2 >= 0)
			{
				UnityEngine.Debug.Log("ERROR: Invalid config file! Config file ends unexpected.");
				return;
			}
			list.Add(Reorder(array2, num));
			list2.Add(num);
		}
		levels = list;
		gridLens = list2;
	}

	private int[] Reorder(int[] cg, int gridSize)
	{
		int[] array = new int[cg.Length];
		int num = 0;
		for (int i = 0; i < gridSize; i++)
		{
			for (int j = 0; j < gridSize; j++)
			{
				array[num] = cg[i + j * 4];
				num++;
			}
		}
		return array;
	}
}
public class CubeGuidance : MonoSingleton<CubeGuidance>
{
	public Transform cubePrefab;

	public Transform cubeOrig;

	public float tolerance = 0.1f;

	public ParticleSystem successEffect;

	public Color guidedCubeColor;

	private bool guidanceState;

	private int index;

	private Material refCubeMaterial;

	private bool nextStep;

	private List<Transform> transforms;

	private List<Transform> generatedCubes;

	private Transform currentCube;

	private bool completed;

	public Action onCompleted;

	private void Start()
	{
		refCubeMaterial = Resources.Load<Material>("TransparentCube");
		generatedCubes = new List<Transform>();
		transforms = new List<Transform>();
	}

	private void Update()
	{
		if (guidanceState)
		{
			CheckNextStep();
			GenerateRefCubes();
		}
	}

	private void LoadGuidedCubes()
	{
		transforms.Clear();
		MonoSingleton<CubesMgr>.Instance().Reset();
		UnityEngine.Object[] cubeObjAll = MonoSingleton<CubesMgr>.Instance().GetCubeObjAll();
		List<int> cubeIndexByLayer = MonoSingleton<CubesMgr>.Instance().GetCubeIndexByLayer();
		for (int i = 0; i < cubeIndexByLayer.Count; i++)
		{
			int num = cubeIndexByLayer[i];
			Transform transform = (Transform)cubeObjAll[num];
			Framework.Singleton<ObjectsUtil>.Instance.RestoreRendering(transform, isRendering: false);
			Framework.Singleton<ObjectsUtil>.Instance.SetKinematic(transform, needPhysics: false);
			transforms.Add(transform);
		}
	}

	private void CheckNextStep()
	{
		if (index == 0)
		{
			LoadGuidedCubes();
			nextStep = true;
		}
		if (nextStep || !(Vector3.Distance(currentCube.position, transforms[index - 1].position) < tolerance) || currentCube.GetComponent<GrabInteractable>().isInteracted)
		{
			return;
		}
		currentCube.position = transforms[index - 1].position;
		currentCube.rotation = transforms[index - 1].rotation;
		if (index == transforms.Count)
		{
			if (!completed)
			{
				successEffect.Play();
				completed = true;
				if (onCompleted != null)
				{
					onCompleted();
				}
			}
			nextStep = false;
		}
		else
		{
			nextStep = true;
		}
	}

	private void GenerateRefCubes()
	{
		if (nextStep)
		{
			currentCube = UnityEngine.Object.Instantiate(cubePrefab, cubeOrig.position, Quaternion.identity, cubeOrig);
			currentCube.name = "RefCube" + index;
			generatedCubes.Add(currentCube);
			transforms[index].GetComponent<Renderer>().enabled = true;
			transforms[index].GetComponent<Renderer>().material = refCubeMaterial;
			transforms[index].GetComponent<Renderer>().sharedMaterial.color = guidedCubeColor;
			index++;
			nextStep = false;
		}
	}

	public void SetGuidanceState(bool guidanceState)
	{
		this.guidanceState = guidanceState;
		if (guidanceState)
		{
			nextStep = true;
		}
		else
		{
			index = 0;
			nextStep = false;
			DestroyGeneratedObjects(0f);
		}
		completed = false;
	}

	private void DestroyGeneratedObjects(float delay)
	{
		Framework.Singleton<ObjectsUtil>.Instance.Destroy(generatedCubes, delay);
		generatedCubes.Clear();
	}

	public bool GetGuidanceState()
	{
		return guidanceState;
	}
}
public class CubeHandler : MonoBehaviour
{
	public float distance;

	private float speed = 0.4f;

	private Color originColor;

	private Material originMaterial;

	private Material guidingMaterial;

	public Action<string> onEnter;

	public Action<string, GameObject> onCollision;

	private bool isGuiding;

	private bool isAlphaOne;

	private void Start()
	{
		originMaterial = GetComponent<Renderer>().sharedMaterial;
		if (originMaterial != null)
		{
			originColor = GetComponent<Renderer>().sharedMaterial.color;
		}
		guidingMaterial = Resources.Load<Material>("TransparentCube");
	}

	private void Update()
	{
		if (isGuiding)
		{
			SwitchAlpha();
		}
	}

	private void SwitchAlpha()
	{
		Color color = GetComponent<Renderer>().sharedMaterial.color;
		if (!isAlphaOne)
		{
			color.a += speed * Time.deltaTime;
			if ((double)color.a > 0.8)
			{
				speed = 0.02f;
			}
			if ((double)color.a > 0.99)
			{
				isAlphaOne = true;
				speed = 0.08f;
			}
		}
		else
		{
			color.a -= speed * Time.deltaTime;
			if ((double)color.a < 0.2)
			{
				speed = 0.02f;
			}
			if ((double)color.a < 0.1)
			{
				isAlphaOne = false;
				speed = 0.08f;
			}
		}
		GetComponent<Renderer>().sharedMaterial.color = color;
	}

	public void Restore(bool needPhysics)
	{
		GetComponent<Rigidbody>().isKinematic = !needPhysics;
	}

	public void Split(int step)
	{
		MoveY(distance / (float)step);
	}

	public void Combine(int step)
	{
		MoveY((0f - distance) / (float)step);
	}

	private void MoveY(float dist)
	{
		Vector3 position = base.transform.position;
		position += new Vector3(0f, dist, 0f);
		base.transform.DOMoveY(position.y, 0.2f);
	}

	public void Move(Vector3 endPos)
	{
		base.transform.DOMove(endPos, 0.2f);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (onEnter != null)
		{
			onEnter(other.gameObject.name);
		}
		if (onCollision != null)
		{
			onCollision(other.gameObject.name, base.gameObject);
		}
	}

	public void SetGuideState(bool isGuiding)
	{
		this.isGuiding = isGuiding;
		if (isGuiding)
		{
			GetComponent<Renderer>().sharedMaterial = guidingMaterial;
			GetComponent<Renderer>().sharedMaterial.color = originColor;
		}
		else
		{
			GetComponent<Renderer>().sharedMaterial = originMaterial;
		}
	}
}
public class CubesMgr : MonoSingleton<CubesMgr>
{
	public Transform prefab;

	public Transform cubeOrig;

	[SerializeField]
	private int level = 4;

	public int gradeLevels = 3;

	private int gridSize;

	private int totalGrids;

	private int totalCubes;

	private int totalColumns;

	private int[] columns;

	private int[] grids;

	private int[] residu;

	private UnityEngine.Object[] cubes;

	private Vector3Int[] positions;

	private Vector3[] originPositions;

	private Quaternion[] originRotations;

	private Dictionary<Vector3Int, int> cubeMap = new Dictionary<Vector3Int, int>();

	private int nLevels = 10;

	private bool isLevelLoaded;

	private List<int[]> levels = new List<int[]>();

	private List<int> gridLens = new List<int>();

	private string cfgfilepath = Application.streamingAssetsPath + "/CubeConfig.txt";

	protected override void Awake()
	{
		base.Awake();
		ContentLoader.OnAnimationCompleted = (Action)Delegate.Combine(ContentLoader.OnAnimationCompleted, new Action(RecordOrigins));
		InitLevels();
	}

	private void OnDisable()
	{
		ContentLoader.OnAnimationCompleted = (Action)Delegate.Remove(ContentLoader.OnAnimationCompleted, new Action(RecordOrigins));
	}

	private void RecordOrigins()
	{
		for (int i = 0; i < cubes.Length; i++)
		{
			originPositions[i] = ((Transform)cubes[i]).position;
			originRotations[i] = ((Transform)cubes[i]).rotation;
		}
	}

	private void Start()
	{
		LoadLevel(level);
	}

	private void Update()
	{
	}

	private void InitLevels()
	{
		InitLevelsDefault();
		StartCoroutine(InitLevelsFromFile(cfgfilepath));
	}

	private void InitLevelsDefault()
	{
		levels.Add(new int[16]
		{
			1, 0, 0, 0, 2, 1, 1, 0, 0, 0,
			0, 0, 0, 0, 0, 0
		});
		levels.Add(new int[16]
		{
			1, 1, 0, 0, 2, 1, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0
		});
		levels.Add(new int[16]
		{
			1, 0, 0, 0, 3, 1, 1, 0, 0, 0,
			0, 0, 0, 0, 0, 0
		});
		levels.Add(new int[16]
		{
			1, 0, 0, 0, 2, 2, 1, 0, 0, 0,
			0, 0, 0, 0, 0, 0
		});
		levels.Add(new int[16]
		{
			1, 0, 0, 0, 3, 2, 1, 0, 0, 0,
			0, 0, 0, 0, 0, 0
		});
		levels.Add(new int[16]
		{
			1, 0, 0, 0, 3, 2, 1, 0, 3, 2,
			1, 1, 0, 0, 0, 0
		});
		levels.Add(new int[16]
		{
			1, 0, 0, 0, 3, 2, 1, 0, 3, 2,
			1, 1, 1, 1, 1, 1
		});
		levels.Add(new int[16]
		{
			1, 0, 0, 0, 2, 3, 3, 2, 1, 2,
			2, 1, 1, 1, 1, 1
		});
		levels.Add(new int[16]
		{
			1, 1, 1, 1, 2, 3, 3, 2, 1, 2,
			2, 1, 1, 1, 1, 1
		});
		levels.Add(new int[16]
		{
			1, 2, 3, 1, 2, 3, 3, 2, 1, 2,
			2, 1, 2, 1, 2, 1
		});
		int[] collection = new int[10] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
		gridLens = new List<int>(collection);
	}

	public int GetLevel()
	{
		return level;
	}

	internal void SetLevel(int l)
	{
		level = l;
	}

	private IEnumerator InitLevelsFromFile(string filepath)
	{
		using UnityWebRequest webRequest = UnityWebRequest.Get(filepath);
		yield return webRequest.SendWebRequest();
		if (webRequest.isNetworkError)
		{
			UnityEngine.Debug.Log("Config File Error: " + webRequest.error);
			yield break;
		}
		string[] lines = new List<string>(webRequest.downloadHandler.text.Split('\n')).ToArray();
		DoInitLevels(lines);
	}

	private void DoInitLevels(string[] lines)
	{
		List<int[]> list = new List<int[]>();
		List<int> list2 = new List<int>();
		for (int i = 0; i < lines.Length; i++)
		{
			if (lines[i].Length == 0)
			{
				continue;
			}
			string[] array = lines[i].Trim().Split();
			if (array.Length == 0 || array.Length != 1)
			{
				continue;
			}
			i++;
			int num = int.Parse(array[0]);
			int[] array2 = new int[num * num];
			int num2 = num - 1;
			while (num2 >= 0 && i < lines.Length)
			{
				string[] array3 = lines[i].Trim().Split();
				if (array3.Length != num)
				{
					UnityEngine.Debug.Log("ERROR: Invalid config file! Row size does not match grid size. (line index: " + i + ", grid size: " + num + ", row size: " + array3.Length + ")");
					return;
				}
				for (int j = 0; j < array3.Length; j++)
				{
					array2[num2 * num + j] = int.Parse(array3[j]);
				}
				num2--;
				i++;
			}
			i--;
			if (num2 >= 0)
			{
				UnityEngine.Debug.Log("ERROR: Invalid config file! Config file ends unexpected.");
				return;
			}
			list.Add(array2);
			list2.Add(num);
		}
		levels = list;
		gridLens = list2;
		isLevelLoaded = true;
		nLevels = levels.Count;
	}

	private void GenerateCubeObjs()
	{
		int num = 0;
		DestroyCubeObjs();
		totalCubes = 0;
		for (int i = 0; i < totalGrids; i++)
		{
			totalCubes += grids[i];
		}
		cubes = new UnityEngine.Object[totalCubes];
		positions = new Vector3Int[totalCubes];
		originPositions = new Vector3[totalCubes];
		originRotations = new Quaternion[totalCubes];
		cubeMap.Clear();
		float num2 = 0.19934f;
		for (int j = 0; j < gridSize; j++)
		{
			for (int k = 0; k < gridSize; k++)
			{
				int num3 = grids[j + k * gridSize];
				for (int l = 0; l < num3; l++)
				{
					float x = cubeOrig.position.x + cubeOrig.lossyScale.x * num2 * (float)j;
					float y = cubeOrig.position.y + cubeOrig.lossyScale.y * num2 * (float)l;
					float z = cubeOrig.position.z + cubeOrig.lossyScale.z * num2 * (float)k;
					originPositions[num] = new Vector3(x, y, z);
					originRotations[num] = Quaternion.identity;
					Transform transform = UnityEngine.Object.Instantiate(prefab, new Vector3(x, y, z), Quaternion.identity, cubeOrig);
					transform.name = "cube" + num;
					cubes[num] = transform;
					positions[num] = new Vector3Int(j, k, l);
					cubeMap.Add(positions[num], num);
					num++;
				}
			}
		}
		cubeOrig.Rotate(new Vector3(0f, 45f, 0f));
		for (int m = 0; m < cubes.Length; m++)
		{
			originPositions[m] = ((Transform)cubes[m]).position;
			originRotations[m] = ((Transform)cubes[m]).rotation;
		}
	}

	public int GetCubeCount()
	{
		return totalCubes;
	}

	public int GetColumnCount()
	{
		return totalColumns;
	}

	public int GetLevelCount()
	{
		return nLevels;
	}

	public void LoadLevel(int n)
	{
		if (n < 0)
		{
			n = 0;
		}
		if (n > nLevels - 1)
		{
			n = nLevels - 1;
		}
		level = n;
		gridSize = gridLens[n];
		totalGrids = gridSize * gridSize;
		if (totalGrids != levels[n].Length)
		{
			UnityEngine.Debug.Log("ERROR: Invalid level length! (level: " + n + ", length: " + levels[n].Length + ", totalGrids: " + totalGrids + ")");
			return;
		}
		totalColumns = 0;
		columns = new int[totalGrids];
		grids = new int[totalGrids];
		residu = new int[totalGrids];
		for (int i = 0; i < totalGrids; i++)
		{
			grids[i] = levels[n][i];
			residu[i] = levels[n][i];
			if (grids[i] > 0)
			{
				columns[totalColumns] = i;
				totalColumns++;
			}
		}
		GenerateCubeObjs();
	}

	public List<int> GetColumnIndex(int indx)
	{
		List<int> list = new List<int>();
		if (indx < 0 || indx >= totalColumns)
		{
			return list;
		}
		int num = columns[indx];
		if (grids[num] <= 0)
		{
			UnityEngine.Debug.Log("ERROR: Inconsistant internal state! Try to get cube indices for empty column " + indx);
			return list;
		}
		int x = num % gridSize;
		int y = num / gridSize;
		for (int i = 0; i < grids[num]; i++)
		{
			Vector3Int vector3Int = new Vector3Int(x, y, i);
			if (cubeMap.ContainsKey(vector3Int))
			{
				list.Add(cubeMap[vector3Int]);
				continue;
			}
			UnityEngine.Debug.Log("ERROR: No existing cube at grid position: " + vector3Int);
			list.Clear();
			break;
		}
		return list;
	}

	public int GetMaxLayer()
	{
		int num = 0;
		for (int i = 0; i < totalGrids; i++)
		{
			if (grids[i] > num)
			{
				num = grids[i];
			}
		}
		return num;
	}

	public List<int> GetCubeIndexByLayer()
	{
		int maxLayer = GetMaxLayer();
		List<int> list = new List<int>();
		for (int i = 0; i < maxLayer; i++)
		{
			for (int num = gridSize - 1; num >= 0; num--)
			{
				for (int j = 0; j < gridSize; j++)
				{
					Vector3Int key = new Vector3Int(j, num, i);
					if (cubeMap.ContainsKey(key))
					{
						list.Add(cubeMap[key]);
					}
				}
			}
		}
		return list;
	}

	public void DestroyCubeObjs()
	{
		for (int i = 0; i < totalCubes; i++)
		{
			UnityEngine.Object.Destroy(((Transform)cubes[i]).gameObject);
		}
		totalCubes = 0;
	}

	public UnityEngine.Object GetCubeObj(int index)
	{
		if (index < 0 || index >= totalCubes)
		{
			return null;
		}
		return cubes[index];
	}

	public UnityEngine.Object[] GetCubeObjAll()
	{
		return cubes;
	}

	public Vector3Int GetCubePosition(int index)
	{
		if (index < 0 || index >= totalCubes)
		{
			return new Vector3Int(-1, -1, -1);
		}
		return positions[index];
	}

	public Vector3Int[] GetCubePositionAll()
	{
		return positions;
	}

	public Vector3 GetCubeOrigin(int index)
	{
		if (index < 0 || index >= totalCubes)
		{
			return new Vector3(0f, 0f, 0f);
		}
		return originPositions[index];
	}

	public Vector3[] GetCubeOriginAll()
	{
		return originPositions;
	}

	public List<int> GetHiddenCubesFrontView()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < totalCubes; i++)
		{
			Vector3Int vector3Int = positions[i];
			if (vector3Int.y != 0 && cubeMap.ContainsKey(new Vector3Int(vector3Int.x, vector3Int.y - 1, vector3Int.z)))
			{
				list.Add(i);
			}
		}
		return list;
	}

	public List<int> GetHiddenCubesSideView()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < totalCubes; i++)
		{
			Vector3Int vector3Int = positions[i];
			if (vector3Int.x != gridSize - 1 && cubeMap.ContainsKey(new Vector3Int(vector3Int.x + 1, vector3Int.y, vector3Int.z)))
			{
				list.Add(i);
			}
		}
		return list;
	}

	public List<int> GetHiddenCubesTopView()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < totalCubes; i++)
		{
			Vector3Int vector3Int = positions[i];
			if (cubeMap.ContainsKey(new Vector3Int(vector3Int.x, vector3Int.y, vector3Int.z + 1)))
			{
				list.Add(i);
			}
		}
		return list;
	}

	public List<int> GetHiddenCubes()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < totalCubes; i++)
		{
			Vector3Int vector3Int = positions[i];
			if (vector3Int.y != 0 && vector3Int.x != gridSize - 1 && cubeMap.ContainsKey(new Vector3Int(vector3Int.x, vector3Int.y - 1, vector3Int.z)) && cubeMap.ContainsKey(new Vector3Int(vector3Int.x + 1, vector3Int.y, vector3Int.z)) && cubeMap.ContainsKey(new Vector3Int(vector3Int.x, vector3Int.y, vector3Int.z + 1)))
			{
				list.Add(i);
			}
		}
		return list;
	}

	public void Challenge(int c)
	{
		level += c;
		if (level < 0)
		{
			level = 0;
		}
		if (level > nLevels - 1)
		{
			level = nLevels - 1;
		}
		LoadLevel(level);
	}

	public void Reset()
	{
		for (int i = 0; i < totalCubes; i++)
		{
			((Transform)cubes[i]).position = originPositions[i];
			((Transform)cubes[i]).rotation = originRotations[i];
		}
		for (int j = 0; j < totalGrids; j++)
		{
			residu[j] = grids[j];
		}
	}

	public List<int> Split()
	{
		List<int> list = new List<int>();
		int num = 0;
		for (int i = 0; i < totalGrids; i++)
		{
			if (num < residu[i])
			{
				num = residu[i];
			}
		}
		if (num > 1)
		{
			for (int j = 0; j < gridSize; j++)
			{
				for (int k = 0; k < gridSize; k++)
				{
					int num2 = j + k * gridSize;
					if (residu[num2] == num)
					{
						residu[num2]--;
						Vector3Int key = new Vector3Int(j, k, residu[num2]);
						if (cubeMap.ContainsKey(key))
						{
							list.Add(cubeMap[key]);
						}
					}
				}
			}
		}
		return list;
	}

	public List<int> Combine()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < gridSize; i++)
		{
			for (int j = 0; j < gridSize; j++)
			{
				int num = i + j * gridSize;
				if (residu[num] < grids[num])
				{
					Vector3Int key = new Vector3Int(i, j, residu[num]);
					list.Add(cubeMap[key]);
					residu[num]++;
				}
			}
		}
		return list;
	}
}
public class ExploreAnimation : CubeAnimation
{
	private int level;

	private void OnEnable()
	{
		RegisterEvents();
		CubeGuidance cubeGuidance = MonoSingleton<CubeGuidance>.Instance();
		cubeGuidance.onCompleted = (Action)Delegate.Combine(cubeGuidance.onCompleted, new Action(OnCompleted));
	}

	protected override void Start()
	{
		base.Start();
	}

	private void OnCompleted()
	{
		MonoSingleton<Instructions>.Instance().SetText(LanCode.ExploreCompleted);
		MonoSingleton<VoiceMgr>.Instance().PlayVoice("explorecompleted");
		CubeAnimation.inProgress = false;
		Invoke("ChangeLevel", 2f);
	}

	private void OnDisable()
	{
		UnRegisterEvents();
		CubeGuidance cubeGuidance = MonoSingleton<CubeGuidance>.Instance();
		cubeGuidance.onCompleted = (Action)Delegate.Remove(cubeGuidance.onCompleted, new Action(OnCompleted));
	}

	protected override void StartTasks()
	{
		Framework.Singleton<ObjectsUtil>.Instance.SetCollider(MonoSingleton<CubesMgr>.Instance().GetCubeObjAll(), needPhysics: false);
		MonoSingleton<Instructions>.Instance().SetText(LanCode.ExploreInstruction);
		MonoSingleton<VoiceMgr>.Instance().PlayVoice("exploreinst", 1f);
		if (!MonoSingleton<CubeGuidance>.Instance().GetGuidanceState())
		{
			MonoSingleton<CubeGuidance>.Instance().SetGuidanceState(guidanceState: true);
		}
	}

	protected override void StopTasks()
	{
		MonoSingleton<CubeGuidance>.Instance().SetGuidanceState(guidanceState: false);
	}

	private void ChangeLevel()
	{
		level++;
		MonoSingleton<CubesMgr>.Instance().SetLevel(level);
		MonoSingleton<CubesMgr>.Instance().LoadLevel(MonoSingleton<CubesMgr>.Instance().GetLevel());
	}
}
public class HiddenAnimation : CubeAnimation
{
	public float offsetY = 0.2f;

	public AudioSource stepSound;

	private Vector3 offsetVector;

	private Material hiddenCubeMaterial;

	private bool isPlayed;

	private void Awake()
	{
		RegisterEvents();
	}

	protected override void Start()
	{
		base.Start();
		offsetVector = new Vector3(0f, offsetY, 0f);
		hiddenCubeMaterial = Resources.Load<Material>("HiddenCube");
	}

	protected override void StartTasks()
	{
		Framework.Singleton<ObjectsUtil>.Instance.Restore(needPhysics: false);
		MonoSingleton<Instructions>.Instance().SetText(LanCode.HiddenCubeHint);
		StartCoroutine("Play");
	}

	protected override void StopTasks()
	{
		StopAllCoroutines();
	}

	private IEnumerator Play()
	{
		isPlayed = false;
		List<Transform> transforms = Framework.Singleton<ObjectsUtil>.Instance.SetObjectsInvisible(MonoSingleton<CubesMgr>.Instance().GetCubeObjAll());
		Vector3[] origins = MonoSingleton<CubesMgr>.Instance().GetCubeOriginAll();
		List<int> hiddenCubes = MonoSingleton<CubesMgr>.Instance().GetHiddenCubes();
		List<int> indexes = MonoSingleton<CubesMgr>.Instance().GetCubeIndexByLayer();
		for (int i = 0; i < indexes.Count; i++)
		{
			int num = indexes[i];
			transforms[num].position += offsetVector;
			transforms[num].GetComponent<Renderer>().enabled = true;
			stepSound.Play();
			CubeHandler component = transforms[num].GetComponent<CubeHandler>();
			component.Restore(needPhysics: false);
			component.Move(origins[num]);
			if (hiddenCubes.Contains(num))
			{
				transforms[num].GetComponent<Renderer>().material = hiddenCubeMaterial;
				MonoSingleton<Instructions>.Instance().SetText(LanCode.HiddenCube);
				if (!isPlayed)
				{
					AudioSource audioSource = MonoSingleton<VoiceMgr>.Instance().PlayVoice("hiddencube");
					yield return new WaitForSeconds(audioSource.clip.length);
				}
				isPlayed = true;
				MonoSingleton<Instructions>.Instance().SetText(LanCode.HiddenCubeHint);
			}
			yield return new WaitForSeconds(0.5f);
		}
		for (int j = 0; j < indexes.Count; j++)
		{
			int num2 = indexes[j];
			if (!hiddenCubes.Contains(num2))
			{
				transforms[num2].GetComponent<CubeHandler>().SetGuideState(isGuiding: true);
			}
		}
		CompletePlay();
	}

	private void OnDestroy()
	{
		UnRegisterEvents();
	}
}
public class LevelManagement : MonoBehaviour
{
	private void Start()
	{
		MonoSingleton<Instructions>.Instance().Init(LanCode.CubeIntro);
		MonoSingleton<VoiceMgr>.Instance()?.PlayVoice("exploreinstruction", 1f);
	}
}
public class ResetAction : MonoBehaviour
{
	private TMP_Text hint;

	private void Awake()
	{
		ContentLoader.onContentChanged = (Action)Delegate.Combine(ContentLoader.onContentChanged, new Action(Reset));
		CubeGuidance cubeGuidance = MonoSingleton<CubeGuidance>.Instance();
		cubeGuidance.onCompleted = (Action)Delegate.Combine(cubeGuidance.onCompleted, new Action(Reset));
	}

	private void OnDisable()
	{
		ContentLoader.onContentChanged = (Action)Delegate.Remove(ContentLoader.onContentChanged, new Action(Reset));
		CubeGuidance cubeGuidance = MonoSingleton<CubeGuidance>.Instance();
		cubeGuidance.onCompleted = (Action)Delegate.Remove(cubeGuidance.onCompleted, new Action(Reset));
	}

	public void Reset()
	{
		if (MonoSingleton<CubeGuidance>.Instance().GetGuidanceState())
		{
			MonoSingleton<CubeGuidance>.Instance().SetGuidanceState(guidanceState: false);
		}
		Framework.Singleton<ObjectsUtil>.Instance.Restore(needPhysics: true);
		if (CubeAnimation.onReset != null)
		{
			CubeAnimation.onReset();
		}
		MonoSingleton<Instructions>.Instance().SetText(LanCode.CubeIntro);
	}
}
public class SplitAnimation : CubeAnimation
{
	public AudioSource stepSound;

	private int step;

	private void Awake()
	{
		RegisterEvents();
	}

	protected override void Start()
	{
		base.Start();
	}

	private IEnumerator Play()
	{
		List<int> indexs = MonoSingleton<CubesMgr>.Instance().Split();
		while (indexs.Count != 0)
		{
			yield return new WaitForSeconds(0.5f);
			step++;
			foreach (int item in indexs)
			{
				((Transform)MonoSingleton<CubesMgr>.Instance().GetCubeObj(item)).GetComponent<CubeHandler>().Split(step);
			}
			stepSound.Play();
			indexs = MonoSingleton<CubesMgr>.Instance().Split();
		}
		step = 0;
		CompletePlay();
	}

	private void OnDestroy()
	{
		UnRegisterEvents();
	}

	protected override void StartTasks()
	{
		Framework.Singleton<ObjectsUtil>.Instance.Restore(needPhysics: false);
		MonoSingleton<Instructions>.Instance().SetText(LanCode.SplitIntro);
		MonoSingleton<VoiceMgr>.Instance().PlayVoice("splitinst");
		StartCoroutine("Play");
	}

	protected override void StopTasks()
	{
		StopAllCoroutines();
	}
}
[RequireComponent(typeof(Choice))]
public class CubeAnswerCheck : AnswerChecker
{
	private TMP_Text progress;

	public ParticleSystem successEffect;

	private int wrongCount;

	private const int scoreValue = 100;

	private int currentGrade;

	private void Awake()
	{
		choice = GetComponent<Choice>();
	}

	private void Start()
	{
		progress = MonoSingleton<Instructions>.Instance().GetProgressText();
		MonoSingleton<Instructions>.Instance().Init(LanCode.ChooseAnswer);
		progress.text = GetGradeText(currentGrade) + " " + (GetLevel() % MonoSingleton<CubesMgr>.Instance().gradeLevels + 1) + "/" + MonoSingleton<CubesMgr>.Instance().gradeLevels;
	}

	protected override void AnswerWrong()
	{
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.AnswerWrong);
	}

	protected override void AnswerRight()
	{
		if (GetLevel() == GetLevelCount() - 1)
		{
			MonoSingleton<Instructions>.Instance().SetText(LanCode.AssessmentCompleted);
			MonoSingleton<VoiceMgr>.Instance().PlayVoice("AssessmentCompleted");
			return;
		}
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.AnswerRight);
		StartCoroutine("TriggerSuccessEffect");
		ChallengeNewLevel(isCorrect: true);
		if (GetLevel() / MonoSingleton<CubesMgr>.Instance().gradeLevels > currentGrade)
		{
			AnswerChecker.onUpgrade?.Invoke(GetLevel() / MonoSingleton<CubesMgr>.Instance().gradeLevels, GetLevel() % MonoSingleton<CubesMgr>.Instance().gradeLevels);
		}
		currentGrade = GetLevel() / MonoSingleton<CubesMgr>.Instance().gradeLevels;
		progress.text = GetGradeText(currentGrade) + " " + (GetLevel() % MonoSingleton<CubesMgr>.Instance().gradeLevels + 1) + "/" + MonoSingleton<CubesMgr>.Instance().gradeLevels;
	}

	private void ChallengeNewLevel(bool isCorrect)
	{
		Challenge(isCorrect);
		Framework.Singleton<ObjectsUtil>.Instance.SetKinematic(MonoSingleton<CubesMgr>.Instance().GetCubeObjAll(), needPhysics: false);
	}

	private IEnumerator TriggerSuccessEffect()
	{
		successEffect.Play();
		yield return new WaitForSeconds(1f);
		successEffect.Stop();
	}

	private int GetLevel()
	{
		return MonoSingleton<CubesMgr>.Instance().GetLevel();
	}

	private void Challenge(bool isCorrect)
	{
		int c = (isCorrect ? 1 : (-1));
		MonoSingleton<CubesMgr>.Instance().Challenge(c);
	}

	private int GetLevelCount()
	{
		return MonoSingleton<CubesMgr>.Instance().GetLevelCount();
	}

	private string GetGradeText(int currentGrade)
	{
		return currentGrade switch
		{
			0 => "初级", 
			1 => "中级", 
			2 => "高级", 
			_ => "", 
		};
	}
}
public class CubeAssessmentMgr : MonoBehaviour
{
	private void Start()
	{
		MonoSingleton<VoiceMgr>.Instance().PlayVoice("assessmentinst", 1f);
	}
}
public class CubeChoice : Choice
{
	internal override int[] GenerateNumbers()
	{
		new System.Random();
		int[] array = new int[3];
		int cubeCount = MonoSingleton<CubesMgr>.Instance().GetCubeCount();
		int count = MonoSingleton<CubesMgr>.Instance().GetHiddenCubes().Count;
		array[0] = MonoSingleton<CubesMgr>.Instance().GetCubeCount();
		array[1] = ((count > 0) ? (cubeCount - count) : (cubeCount + GenerateRandom(2)));
		array[2] = cubeCount + GenerateRandom(2);
		while (array[2] == array[0] || array[2] == array[1])
		{
			array[2] = cubeCount + GenerateRandom(2);
		}
		return array;
	}

	internal override int GetLevel()
	{
		return MonoSingleton<CubesMgr>.Instance().GetLevel();
	}

	private void Start()
	{
	}

	private void Update()
	{
		UpdateChoice();
	}
}
public class ColorCycleMgr : CycleMgr
{
	protected override void InitLevelConfigs()
	{
		base.InitLevelConfigs();
		levelConfigs.Add(0, 5);
	}
}
public class CycleGameMgr : MonoBehaviour
{
	public static Action<int, int> onUpgrade;

	public GameObject[] answerItems;

	public AudioClip trainStartSound;

	public Transform train;

	public List<CycleInfo> levels;

	protected List<int> missedItems;

	protected CycleInfo currentInfo;

	protected Dictionary<int, int> levelConfigs;

	private int currentGrade;

	private int currentLevelOfGrade;

	protected virtual void Start()
	{
		MonoSingleton<Instructions>.Instance().Init(LanCode.Cycle);
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.Cycle);
		missedItems = new List<int>();
		currentGrade = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().cycleGrade;
		currentLevelOfGrade = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().cycleLevel;
		EnableGroups(currentGrade, delete: false);
		InitLevelConfigs();
		NextLevel();
	}

	private void EnableGroups(int grade, bool delete)
	{
		if (delete)
		{
			GameObject[] array = GameObject.FindGameObjectsWithTag("AnswerItem");
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					UnityEngine.Object.Destroy(array[i]);
				}
			}
		}
		if (grade == 0)
		{
			answerItems[0].SetActive(value: true);
			answerItems[1].SetActive(value: false);
		}
		else
		{
			answerItems[0].SetActive(value: false);
			answerItems[1].SetActive(value: true);
		}
	}

	protected virtual void InitLevelConfigs()
	{
		levelConfigs = new Dictionary<int, int>();
		levelConfigs.Add(0, 3);
		levelConfigs.Add(1, 3);
		levelConfigs.Add(2, 3);
	}

	private void OnEnable()
	{
		CycleItem.onItemAdded = (Action<int>)Delegate.Combine(CycleItem.onItemAdded, new Action<int>(ItemAdded));
	}

	private void OnDisable()
	{
		CycleItem.onItemAdded = (Action<int>)Delegate.Remove(CycleItem.onItemAdded, new Action<int>(ItemAdded));
	}

	protected virtual void NextLevel()
	{
		if (levelConfigs.Count == 0)
		{
			return;
		}
		if (currentLevelOfGrade == levelConfigs[currentGrade])
		{
			currentGrade++;
			currentLevelOfGrade = 0;
			EnableGroups(currentGrade, currentGrade == 1);
			if (!MonoSingleton<AccountMgr>.Instance().GetUserProfileData().cycleCompleted)
			{
				onUpgrade(currentGrade, currentLevelOfGrade);
			}
		}
		if (currentGrade == levelConfigs.Count)
		{
			currentGrade = 0;
			EnableGroups(currentGrade, delete: true);
			MonoSingleton<AccountMgr>.Instance().GetUserProfileData().cycleCompleted = true;
		}
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().cycleGrade = currentGrade;
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().cycleLevel = currentLevelOfGrade;
		currentInfo = levels[CaculateIndex()];
		SetTrainItems(currentInfo);
		currentLevelOfGrade++;
	}

	private void SetTrainItems(CycleInfo info)
	{
		int num = info.objs.Length;
		CycleItem[] componentsInChildren = train.GetComponentsInChildren<CycleItem>(includeInactive: true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (i < num && componentsInChildren[i].index == info.objs[i].index)
			{
				componentsInChildren[i].transform.parent.gameObject.SetActive(value: true);
				componentsInChildren[i].SetInfo(info.objs[i], info.type);
				if (!info.objs[i].visible)
				{
					missedItems.Add(info.objs[i].index);
				}
			}
			else
			{
				componentsInChildren[i].transform.parent.gameObject.SetActive(value: false);
			}
		}
	}

	public void ItemAdded(int index)
	{
		if (missedItems.Count > 0)
		{
			missedItems.RemoveAt(0);
		}
		if (missedItems.Count == 0)
		{
			MonoSingleton<SoundMgr>.Instance().PlaySound(trainStartSound);
			Invoke("NextLevel", 1f);
		}
	}

	private int CaculateIndex()
	{
		int num = 0;
		for (int i = 0; i < currentGrade; i++)
		{
			num += levelConfigs[i];
		}
		return num + currentLevelOfGrade;
	}
}
[CreateAssetMenu(menuName = "CreateCycleInfo")]
public class CycleInfo : ScriptableObject
{
	public int grade;

	public CycleType type;

	public CycleObject[] objs;
}
[Serializable]
public enum CycleType
{
	COLOR,
	PIC,
	NUM
}
[Serializable]
public class CycleObject
{
	public int index;

	public Color color;

	public Texture texture;

	public int number;

	public bool visible;
}
public class CycleItem : MonoBehaviour
{
	public static Action<int> onItemAdded;

	public int index;

	private Renderer[] renderers;

	private CycleObject cycleObject;

	private CycleType type;

	private TMP_Text text;

	private void Awake()
	{
		renderers = base.transform.GetComponentsInChildren<Renderer>();
		text = base.transform.GetComponentInChildren<TMP_Text>();
	}

	private void Update()
	{
	}

	internal void SetInfo(CycleObject cycleObject, CycleType type)
	{
		this.cycleObject = cycleObject;
		this.type = type;
		SetVisible(cycleObject.visible);
		if (type.Equals(CycleType.COLOR))
		{
			renderers[0].material.color = cycleObject.color;
			renderers[0].material.mainTexture = null;
			text.text = "";
		}
		if (type.Equals(CycleType.PIC))
		{
			if (cycleObject.texture != null)
			{
				renderers[0].material.mainTexture = cycleObject.texture;
			}
			renderers[0].material.color = Color.white;
			text.text = "";
		}
		if (type.Equals(CycleType.NUM))
		{
			renderers[0].material.color = Color.red;
			text.text = cycleObject.number.ToString();
		}
	}

	private void SetVisible(bool visible)
	{
		for (int i = 0; i < renderers.Length; i++)
		{
			renderers[i].enabled = visible;
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag.Equals("AnswerItem") && CheckAnswer(collision))
		{
			Interactable component = collision.gameObject.GetComponent<Interactable>();
			if (component != null)
			{
				component.interactedBy?.Offhand(component);
				UnityEngine.Object.Destroy(component.gameObject);
			}
			SetVisible(visible: true);
			onItemAdded?.Invoke(cycleObject.index);
		}
	}

	private bool CheckAnswer(Collision collision)
	{
		if (type.Equals(CycleType.COLOR) || type.Equals(CycleType.PIC))
		{
			CycleItem componentInChildren = collision.transform.GetComponentInChildren<CycleItem>();
			if (componentInChildren != null && cycleObject != null)
			{
				return componentInChildren.index == cycleObject.number;
			}
		}
		if (type.Equals(CycleType.NUM))
		{
			CycleItem componentInChildren2 = collision.transform.GetComponentInChildren<CycleItem>();
			if (componentInChildren2 != null && cycleObject != null)
			{
				return componentInChildren2.GetComponentInChildren<TMP_Text>().text.Equals(cycleObject.number.ToString());
			}
		}
		return false;
	}
}
public class CycleMgr : MonoSingleton<CycleMgr>
{
	public static Action<int, int> onUpgrade;

	public AudioClip trainStartSound;

	public Transform train;

	public List<CycleInfo> levels;

	protected List<int> missedItems;

	protected CycleInfo currentInfo;

	protected Dictionary<int, int> levelConfigs;

	private int currentGrade;

	private int currentLevelOfGrade;

	protected virtual void Start()
	{
		MonoSingleton<Instructions>.Instance().Init(LanCode.Cycle);
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.Cycle);
		missedItems = new List<int>();
		currentGrade = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().cycleGrade;
		currentLevelOfGrade = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().cycleLevel;
		InitLevelConfigs();
		NextLevel();
	}

	private void OnEnable()
	{
		CycleItem.onItemAdded = (Action<int>)Delegate.Combine(CycleItem.onItemAdded, new Action<int>(ItemAdded));
	}

	private void OnDisable()
	{
		CycleItem.onItemAdded = (Action<int>)Delegate.Remove(CycleItem.onItemAdded, new Action<int>(ItemAdded));
	}

	protected virtual void InitLevelConfigs()
	{
		levelConfigs = new Dictionary<int, int>();
	}

	protected virtual void NextLevel()
	{
		if (levelConfigs.Count == 0)
		{
			return;
		}
		if (currentLevelOfGrade == levelConfigs[currentGrade])
		{
			currentGrade++;
			currentLevelOfGrade = 0;
			if (!MonoSingleton<AccountMgr>.Instance().GetUserProfileData().cycleCompleted)
			{
				onUpgrade(currentGrade, currentLevelOfGrade);
			}
		}
		if (currentGrade == levelConfigs.Count)
		{
			currentGrade = 0;
			MonoSingleton<AccountMgr>.Instance().GetUserProfileData().cycleCompleted = true;
		}
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().cycleGrade = currentGrade;
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().cycleLevel = currentLevelOfGrade;
		currentInfo = levels[CaculateIndex()];
		SetTrainItems(currentInfo);
		currentLevelOfGrade++;
	}

	private void SetTrainItems(CycleInfo info)
	{
		int num = info.objs.Length;
		CycleItem[] componentsInChildren = train.GetComponentsInChildren<CycleItem>(includeInactive: true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (i < num && componentsInChildren[i].index == info.objs[i].index)
			{
				componentsInChildren[i].transform.parent.gameObject.SetActive(value: true);
				componentsInChildren[i].SetInfo(info.objs[i], info.type);
				if (!info.objs[i].visible)
				{
					missedItems.Add(info.objs[i].index);
				}
			}
			else
			{
				componentsInChildren[i].transform.parent.gameObject.SetActive(value: false);
			}
		}
	}

	public void ItemAdded(int index)
	{
		missedItems.RemoveAt(0);
		if (missedItems.Count == 0)
		{
			MonoSingleton<SoundMgr>.Instance().PlaySound(trainStartSound);
			Invoke("NextLevel", 1f);
		}
	}

	private int CaculateIndex()
	{
		int num = 0;
		for (int i = 0; i < currentGrade; i++)
		{
			num += levelConfigs[i];
		}
		return num + currentLevelOfGrade;
	}
}
public class NumCycleMgr : CycleMgr
{
	private List<int> numbers = new List<int>();

	private List<int> missedNumbers = new List<int>();

	protected override void NextLevel()
	{
		base.NextLevel();
		GenerateNumber();
		SetAnswerItems();
	}

	protected override void InitLevelConfigs()
	{
		base.InitLevelConfigs();
		levelConfigs.Add(0, 3);
		levelConfigs.Add(1, 4);
		levelConfigs.Add(2, 4);
	}

	private void SetAnswerItems()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("AnswerItem");
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				SetAnswerItem(array[i].transform);
			}
		}
	}

	private void GenerateNumber()
	{
		missedNumbers.Clear();
		missedNumbers.Add(currentInfo.objs[missedItems[0]].number);
		missedNumbers.Add(currentInfo.objs[missedItems[1]].number);
		if (missedItems.Count > 2)
		{
			missedNumbers.Add(currentInfo.objs[missedItems[2]].number);
		}
		else
		{
			missedNumbers.Add(UnityEngine.Random.Range(currentInfo.objs[missedItems[0]].number + 1, currentInfo.objs[missedItems[1]].number));
		}
		numbers.Clear();
		int num = UnityEngine.Random.Range(0, 3);
		numbers.Add(missedNumbers[num % 3]);
		numbers.Add(missedNumbers[(num + 1) % 3]);
		numbers.Add(missedNumbers[(num + 2) % 3]);
	}

	public void SetAnswerItem(Transform item)
	{
		int index = item.GetComponentInChildren<CycleItem>().index;
		item.GetComponentInChildren<TMP_Text>().text = numbers[index].ToString();
	}
}
public class PicCycleMgr : CycleMgr
{
	protected override void InitLevelConfigs()
	{
		base.InitLevelConfigs();
		levelConfigs.Add(0, 3);
		levelConfigs.Add(1, 3);
		levelConfigs.Add(2, 3);
	}
}
public class EditorSimulator : MonoBehaviour
{
	[Serializable]
	public class MouseEvent : UnityEvent
	{
	}

	public MouseEvent leftMouseDown;

	public MouseEvent rightMouseDown;

	private RaycastHit hit;

	public Transform spawnPoint;

	private void Start()
	{
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			leftMouseDown.Invoke();
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo, 1 << LayerMask.NameToLayer("Button")))
			{
				hitInfo.collider.gameObject.GetComponent<ButtonInteractable>()?.OnButtonPressed.Invoke();
			}
		}
		if (Input.GetMouseButtonDown(1))
		{
			rightMouseDown.Invoke();
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo2, 1 << LayerMask.NameToLayer("Button")))
			{
				hitInfo2.collider.gameObject.GetComponent<MenuButton>()?.onButtonDown.Invoke();
			}
		}
		if (Input.touchCount > 0)
		{
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.GetTouch(0).position), out var hitInfo3, LayerMask.NameToLayer("Button")))
			{
				hitInfo3.collider.gameObject.GetComponent<ButtonInteractable>()?.OnButtonPressed.Invoke();
			}
			if (Input.GetTouch(0).phase == TouchPhase.Moved)
			{
				float x = Input.GetTouch(0).deltaPosition.x;
				float y = Input.GetTouch(0).deltaPosition.y;
				Camera.main.transform.RotateAround(spawnPoint.position, Vector3.up, x * 0.1f);
				Camera.main.transform.RotateAround(spawnPoint.position, Vector3.right, y * 0.1f);
			}
		}
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
public class Fruit : MonoBehaviour
{
	public Transform top;

	public Transform bottom;

	public AudioClip hitSound;

	public Action triggerEnter;

	private Transform firstFruit;

	private Transform secondFruit;

	private string COLLIDER_NAME = "stick";

	private string OBJECT_TAG = "Answer";

	private float DISAPEAR_TIME = 2f;

	private void Start()
	{
		if (GetComponent<Rigidbody>() == null)
		{
			base.gameObject.AddComponent<Rigidbody>();
		}
		firstFruit = Initialize(top);
		secondFruit = Initialize(bottom);
	}

	private Transform Initialize(Transform part)
	{
		Transform transform = UnityEngine.Object.Instantiate(part, base.transform.position, Quaternion.identity, base.transform.parent);
		transform.localScale *= 1.5f;
		if (transform.GetComponent<Rigidbody>() == null)
		{
			transform.gameObject.AddComponent<Rigidbody>();
		}
		if (transform.GetComponent<BoxCollider>() == null)
		{
			transform.gameObject.AddComponent<BoxCollider>();
		}
		transform.GetComponent<Renderer>().enabled = false;
		return transform;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name.Equals(COLLIDER_NAME))
		{
			if (!base.transform.gameObject.tag.Equals(OBJECT_TAG))
			{
				MonoSingleton<ScoreMgr>.Instance().IncreaseScore(5, base.transform.position);
				PlayCutAnimation();
			}
			if (triggerEnter != null)
			{
				triggerEnter();
			}
		}
	}

	public void PlayCutAnimation()
	{
		MonoSingleton<SoundMgr>.Instance().PlaySound(hitSound, base.transform.position, 0f, new SoundMgr.PlayParameters
		{
			Pitch = 1f,
			SourceID = 1,
			Volume = 1f,
			Loop = false
		}, 0.1f);
		SetVisible(isVisible: true);
		firstFruit.position = base.transform.position;
		firstFruit.rotation = Quaternion.AngleAxis((float)(UnityEngine.Random.Range(50, 180) * 100) / 3.14f, Vector3.forward);
		secondFruit.transform.position = base.transform.position;
		secondFruit.rotation = Quaternion.AngleAxis((float)(UnityEngine.Random.Range(80, 150) * 100) / 3.14f, Vector3.forward);
		firstFruit.GetComponent<Rigidbody>().velocity = 2f * MonoSingleton<InputHandler>.Instance().GetControllerVelocity(InputHandler.ControllerType.Right);
		secondFruit.GetComponent<Rigidbody>().velocity = -2f * MonoSingleton<InputHandler>.Instance().GetControllerVelocity(InputHandler.ControllerType.Right);
		Invoke("SetInvisible", DISAPEAR_TIME);
	}

	private void SetInvisible()
	{
		SetVisible(isVisible: false);
	}

	private void SetVisible(bool isVisible)
	{
		GetComponent<Renderer>().enabled = !isVisible;
		firstFruit.GetComponent<Renderer>().enabled = isVisible;
		secondFruit.GetComponent<Renderer>().enabled = isVisible;
	}
}
[RequireComponent(typeof(Choice))]
public class FruitAnswerChecker : AnswerChecker
{
	private void Awake()
	{
		FruitButton.onButtonDown = (Action<int>)Delegate.Combine(FruitButton.onButtonDown, new Action<int>(base.CheckAnswer));
		choice = GetComponent<Choice>();
	}

	private void OnDestroy()
	{
		FruitButton.onButtonDown = (Action<int>)Delegate.Remove(FruitButton.onButtonDown, new Action<int>(base.CheckAnswer));
	}

	protected override void AnswerRight()
	{
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.AnswerRight);
		MonoSingleton<FruitGameMgr>.Instance().NextChallenge();
		StartCoroutine(MonoSingleton<FruitPool>.Instance().SpawnFruits());
	}

	protected override void AnswerWrong()
	{
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.AnswerWrong);
		MonoSingleton<FruitGameMgr>.Instance().NextChallenge();
	}
}
public class FruitButton : MonoBehaviour
{
	public int index = -1;

	private bool rot;

	private Vector3 randomRot;

	private Rigidbody mRigidbody;

	public static Action<int> onButtonDown;

	private void Awake()
	{
		mRigidbody = GetComponent<Rigidbody>();
		mRigidbody.useGravity = false;
		rot = true;
		Fruit component = GetComponent<Fruit>();
		component.triggerEnter = (Action)Delegate.Combine(component.triggerEnter, new Action(Selected));
	}

	private void Start()
	{
		mRigidbody.useGravity = false;
		mRigidbody.isKinematic = true;
		randomRot = new Vector3(0f, UnityEngine.Random.Range(1, 3), UnityEngine.Random.Range(-1, 1));
	}

	private void Selected()
	{
		if (onButtonDown != null)
		{
			onButtonDown(index);
		}
	}

	private void Update()
	{
		if (rot)
		{
			base.transform.Rotate(randomRot, Space.Self);
		}
	}

	private void OnDestroy()
	{
		Fruit component = GetComponent<Fruit>();
		component.triggerEnter = (Action)Delegate.Remove(component.triggerEnter, new Action(Selected));
	}
}
public class FruitChoice : Choice
{
	internal override int[] GenerateNumbers()
	{
		new System.Random();
		int[] array = new int[3];
		int num = (array[0] = Framework.Singleton<EquationGenerator>.Instance.GetRightAnswer());
		array[1] = num + GenerateRandom(3);
		while (array[1] < 0)
		{
			array[1] = num + GenerateRandom(3);
		}
		array[2] = num + GenerateRandom(5);
		while (array[2] == array[1] || array[2] < 0)
		{
			array[2] = num + GenerateRandom(5);
		}
		return array;
	}

	internal override int GetLevel()
	{
		return MonoSingleton<FruitGameMgr>.Instance().GetLevel();
	}

	private void Update()
	{
		UpdateChoice();
	}
}
public class FruitGameMgr : MonoSingleton<FruitGameMgr>
{
	public GameObject[] disabledObjectsWhenTimesup;

	public TMP_Text question;

	private int level;

	[SerializeField]
	private int grade;

	private void Start()
	{
		GameTimer.onTimeUp = (Action)Delegate.Combine(GameTimer.onTimeUp, new Action(EndGame));
		level = 0;
		grade = MonoSingleton<GradeMgr>.Instance().GetGrade();
		StartGame();
	}

	private void StartGame()
	{
		Framework.Singleton<EquationGenerator>.Instance.grade = grade;
		NextChallenge();
	}

	private void EndGame()
	{
		if (disabledObjectsWhenTimesup != null)
		{
			for (int i = 0; i < disabledObjectsWhenTimesup.Length; i++)
			{
				disabledObjectsWhenTimesup[i].SetActive(value: false);
			}
		}
	}

	public void NextChallenge()
	{
		level++;
		Framework.Singleton<EquationGenerator>.Instance.Mode = GetModeByGrade();
		Framework.Singleton<EquationGenerator>.Instance.GenerateNumbers();
		question.text = Framework.Singleton<EquationGenerator>.Instance.GetNumL() + Framework.Singleton<EquationGenerator>.Instance.GetSymbol() + Framework.Singleton<EquationGenerator>.Instance.GetNumR() + "=?";
	}

	private EquationGenerator.EquationMode GetModeByGrade()
	{
		if (grade < 2)
		{
			return (EquationGenerator.EquationMode)UnityEngine.Random.Range(0, 2);
		}
		return (EquationGenerator.EquationMode)UnityEngine.Random.Range(0, 4);
	}

	private void OnDisable()
	{
		GameTimer.onTimeUp = (Action)Delegate.Remove(GameTimer.onTimeUp, new Action(EndGame));
	}

	public int GetLevel()
	{
		return level;
	}

	private void Update()
	{
		if (MonoSingleton<InputHandler>.Instance().IsBackKeyDown() || Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadSceneAsync("house");
		}
	}
}
public class FruitPool : MonoSingleton<FruitPool>
{
	public Transform spawnPoint;

	public GameObject answerGroup;

	public int spawnCount = 3;

	public List<Transform> fruits;

	private List<Transform> pool;

	private Vector3 throwForce = Vector3.zero;

	private Vector3 randomPos = new Vector3(0f, 0f, 0f);

	private List<Transform> answerChildrens;

	private Renderer[] renders;

	private Collider[] colliders;

	private float speed = 1f;

	private void Start()
	{
		pool = new List<Transform>();
		for (int i = 0; i < fruits.Count; i++)
		{
			Transform transform = UnityEngine.Object.Instantiate(fruits[i], spawnPoint);
			transform.localScale *= 1.5f;
			transform.GetComponent<Renderer>().enabled = false;
			pool.Add(transform);
		}
		renders = answerGroup.GetComponentsInChildren<Renderer>();
		colliders = answerGroup.GetComponentsInChildren<Collider>();
	}

	public IEnumerator SpawnFruits()
	{
		SetEffective(v: false);
		for (int i = 0; i < spawnCount; i++)
		{
			Transform obj = pool[UnityEngine.Random.Range(0, fruits.Count)];
			randomPos.Set(UnityEngine.Random.Range(-0.4f, 0.4f), UnityEngine.Random.Range(0.5f, 1f), UnityEngine.Random.Range(-0.7f, -1f));
			obj.position = spawnPoint.position + randomPos;
			obj.rotation = Quaternion.AngleAxis((float)(UnityEngine.Random.Range(50, 180) * 100) / 3.14f, Vector3.forward);
			obj.GetComponent<Renderer>().enabled = true;
			obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
			throwForce.Set(0f, speed * UnityEngine.Random.Range(1f, 2f), speed * UnityEngine.Random.Range(1f, 2f));
			obj.GetComponent<Rigidbody>().AddForce(throwForce, ForceMode.Impulse);
			yield return new WaitForSeconds(UnityEngine.Random.Range(0.3f, 1f));
		}
		yield return new WaitForSeconds(1f);
		SetEffective(v: true);
	}

	private void SetEffective(bool v)
	{
		for (int i = 0; i < renders.Length; i++)
		{
			renders[i].enabled = v;
		}
		for (int j = 0; j < colliders.Length; j++)
		{
			colliders[j].enabled = v;
		}
	}
}
public class FruitSimulator : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo, LayerMask.NameToLayer("Fruit")))
		{
			hitInfo.collider.gameObject.GetComponent<Fruit>().triggerEnter();
		}
	}
}
public class RankUI : MonoBehaviour
{
	[HideInInspector]
	public int bestScore;

	public GameObject EndGameGO;

	public Text EndScore;

	public Text EndBestScore;

	private void Awake()
	{
		if (PlayerPrefs.HasKey("bestScore"))
		{
			UnityEngine.Debug.Log("HasKey bestScore");
			bestScore = PlayerPrefs.GetInt("bestScore");
		}
		else
		{
			bestScore = 0;
		}
		EndGameGO.SetActive(value: false);
		GameTimer.onTimeUp = (Action)Delegate.Combine(GameTimer.onTimeUp, new Action(EndGame));
	}

	private void Start()
	{
		BeginGame();
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
		PlayerPrefs.SetInt("bestScore", bestScore);
		GameTimer.onTimeUp = (Action)Delegate.Remove(GameTimer.onTimeUp, new Action(EndGame));
	}

	private void BeginGame()
	{
		EndGameGO.SetActive(value: false);
	}

	private void EndGame()
	{
		EndGameGO.SetActive(value: true);
		int score = MonoSingleton<ScoreMgr>.Instance().GetScore();
		EndScore.text = score.ToString();
		if (score > bestScore)
		{
			bestScore = score;
			PlayerPrefs.SetInt("bestScore", bestScore);
		}
		EndBestScore.text = bestScore.ToString();
	}

	public void OnPlayClick()
	{
		EndGameGO.SetActive(value: false);
	}
}
public class ScoreMgr : MonoSingleton<ScoreMgr>
{
	public Text score;

	public Transform scoreEffect;

	private int scoreNum;

	private void Start()
	{
		scoreNum = 0;
	}

	private void Update()
	{
		score.text = scoreNum.ToString();
	}

	public void IncreaseScore(int num, Vector3 position)
	{
		scoreNum += num;
		scoreEffect.position = position;
		scoreEffect.gameObject.SetActive(value: true);
		StopAllCoroutines();
		StartCoroutine(FireScoreEffect());
	}

	private IEnumerator FireScoreEffect()
	{
		float time = Time.time;
		Vector3 pos = scoreEffect.position;
		UnityEngine.Debug.Log("pos:" + pos.y);
		while ((double)(Time.time - time) < 0.3)
		{
			pos.y += Time.deltaTime;
			UnityEngine.Debug.Log("pos.y:" + pos.y);
			scoreEffect.position = pos;
			yield return null;
		}
		scoreEffect.gameObject.SetActive(value: false);
	}

	public int GetScore()
	{
		return scoreNum;
	}
}
public class GameMgr : MonoBehaviour
{
	public ContentLoader loader;

	private void Start()
	{
		HouseMgr.SetContentLoader(loader);
	}

	private void Update()
	{
		if (MonoSingleton<InputHandler>.Instance().IsBackKeyDown() || Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadSceneAsync("lobby");
		}
	}
}
[CreateAssetMenu(menuName = "CreateGuideInfo")]
public class GuideInfo : ScriptableObject
{
	public string hintText;

	public Sprite hintImage;

	public string guideType;

	public string guideName;

	public int number;

	public string targetName;

	public string introAudio;

	public string completeText;

	public string completeAudio;
}
public class GuideMgr : MonoBehaviour
{
	public GuideInfo[] guideInfos;

	private SpriteRenderer spriteRenderer;

	private TMP_Text hint;

	public AudioClip introVoice;

	private int index;

	private bool nextStep;

	private bool ignoreGuide;

	private GameObject currentTarget;

	private bool triggered;

	private void Start()
	{
		spriteRenderer = MonoSingleton<Instructions>.Instance().GetSpriteRenderer();
		MonoSingleton<Instructions>.Instance().Init();
		StartCoroutine("GuideIntro");
	}

	private IEnumerator GuideIntro()
	{
		yield return new WaitForSeconds(0.5f);
		MonoSingleton<Instructions>.Instance().SetText(LanCode.GuideIntro);
		introVoice = SLocalization.GetAudio(LanCode.GuideIntro);
		MonoSingleton<VoiceMgr>.Instance().PlayVoice(introVoice);
		yield return new WaitForSeconds(introVoice.length + 0.5f);
		index = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().guided;
		nextStep = true;
	}

	private void SetNextStep()
	{
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().guided = index;
		nextStep = true;
		MonoSingleton<AccountMgr>.Instance().UpdateAccount();
	}

	private void Update()
	{
		if (!ignoreGuide && nextStep && index < guideInfos.Length)
		{
			StartGuide();
		}
	}

	private void StartGuide()
	{
		GuideInfo guideInfo = guideInfos[index];
		MonoSingleton<Instructions>.Instance().SetText(guideInfo.hintText);
		spriteRenderer.sprite = guideInfo.hintImage;
		string guideType = guideInfo.guideType;
		currentTarget = GameObject.Find(guideInfo.targetName);
		MonoSingleton<VoiceMgr>.Instance().PlayVoice(SLocalization.GetAudio(guideInfo.introAudio));
		if (guideType.Equals("Drag"))
		{
			currentTarget.GetComponentInChildren<AxisDragInteractable>().OnDragDistance.AddListener(EndDragGuide);
		}
		if (guideType.Equals("Grab"))
		{
			Recycle componentInChildren = currentTarget.GetComponentInChildren<Recycle>();
			componentInChildren.onDisappear = (Action<int>)Delegate.Combine(componentInChildren.onDisappear, new Action<int>(EndGrabGuide));
		}
		if (guideType.Equals("Pad"))
		{
			InputHandler inputHandler = MonoSingleton<InputHandler>.Instance();
			inputHandler.onMenuKeyDown = (Action)Delegate.Combine(inputHandler.onMenuKeyDown, new Action(EndPadGuide));
		}
		if (guideType.Equals("Medal"))
		{
			Pad.onViewOn = (Action<Transform>)Delegate.Combine(Pad.onViewOn, new Action<Transform>(EndMedalGuide));
		}
		if (guideType.Equals("Vending"))
		{
			VendingMachine.vendingSucceed = (Action)Delegate.Combine(VendingMachine.vendingSucceed, new Action(EndVendingGuide));
		}
		nextStep = false;
	}

	private void EndMedalGuide(Transform view)
	{
		if (view.name.Equals("MedalView"))
		{
			MonoSingleton<VoiceMgr>.Instance().PlayVoice(guideInfos[index].completeAudio);
			MonoSingleton<Instructions>.Instance().SetText(guideInfos[index].completeText);
			Pad.onViewOn = (Action<Transform>)Delegate.Remove(Pad.onViewOn, new Action<Transform>(EndMedalGuide));
			float time = SLocalization.GetAudio(guideInfos[index].completeAudio).length + 0.5f;
			index++;
			Invoke("SetNextStep", time);
		}
	}

	private void EndVendingGuide()
	{
		MonoSingleton<VoiceMgr>.Instance().PlayVoice(guideInfos[index].completeAudio);
		MonoSingleton<Instructions>.Instance().SetText(guideInfos[index].completeText);
		VendingMachine.vendingSucceed = (Action)Delegate.Remove(VendingMachine.vendingSucceed, new Action(EndVendingGuide));
		index++;
		Invoke("SetNextStep", 10f);
	}

	private void EndPadGuide()
	{
		MonoSingleton<VoiceMgr>.Instance().PlayVoice(guideInfos[index].completeAudio);
		MonoSingleton<Instructions>.Instance().SetText(guideInfos[index].completeText);
		InputHandler inputHandler = MonoSingleton<InputHandler>.Instance();
		inputHandler.onMenuKeyDown = (Action)Delegate.Remove(inputHandler.onMenuKeyDown, new Action(EndPadGuide));
		index++;
		Invoke("SetNextStep", 1f);
	}

	private void EndDragGuide(float distance)
	{
		if (distance > 0f)
		{
			MonoSingleton<VoiceMgr>.Instance().PlayVoice(guideInfos[index].completeAudio);
			index++;
			Invoke("SetNextStep", 5f);
			currentTarget.GetComponentInChildren<AxisDragInteractable>().OnDragDistance.RemoveListener(EndDragGuide);
		}
	}

	private void EndGrabGuide(int count)
	{
		if (count >= guideInfos[index].number)
		{
			MonoSingleton<Instructions>.Instance().SetText(guideInfos[index].completeText);
			spriteRenderer.sprite = null;
			MonoSingleton<VoiceMgr>.Instance().PlayVoice(guideInfos[index].completeAudio);
			MonoSingleton<MedalMgr>.Instance().AddMedal(1, 0);
			Recycle componentInChildren = currentTarget.GetComponentInChildren<Recycle>();
			componentInChildren.onDisappear = (Action<int>)Delegate.Remove(componentInChildren.onDisappear, new Action<int>(EndGrabGuide));
			float time = SLocalization.GetAudio(guideInfos[index].completeAudio).length + 0.5f;
			index++;
			Invoke("SetNextStep", time);
		}
	}
}
public class Recycle : MonoBehaviour
{
	public TMP_Text countText;

	private ParticleSystem disappear;

	public AudioClip sound;

	private int count;

	public Action<int> onDisappear;

	private void Start()
	{
		if (disappear == null)
		{
			GameObject gameObject = GameObject.Find("ZhaLie");
			if (gameObject != null)
			{
				disappear = gameObject.GetComponent<ParticleSystem>();
			}
		}
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		GameObject gameObject = other.gameObject;
		if (gameObject.layer == LayerMask.NameToLayer("InteractionObject"))
		{
			if (disappear != null)
			{
				disappear.transform.position = gameObject.transform.position;
				disappear.Play();
			}
			MonoSingleton<SoundMgr>.Instance().PlaySound(sound, base.transform.position);
			GrabInteractable componentInChildren = gameObject.GetComponentInChildren<GrabInteractable>();
			componentInChildren.interactedBy?.Offhand(componentInChildren);
			UnityEngine.Object.Destroy(gameObject);
			count++;
			countText.text = count.ToString();
			onDisappear?.Invoke(count);
		}
	}

	private void PlayNumberSound(int count)
	{
		string keyCode = GetKeyCode(count);
		MonoSingleton<VoiceMgr>.Instance().PlayVoice(SLocalization.GetAudio(keyCode));
	}

	private string GetKeyCode(int count)
	{
		return count switch
		{
			1 => "one", 
			2 => "two", 
			3 => "three", 
			4 => "four", 
			5 => "five", 
			6 => "six", 
			7 => "seven", 
			8 => "eight", 
			9 => "nine", 
			10 => "ten", 
			_ => "", 
		};
	}
}
public class ContentLoader : MonoBehaviour
{
	public AudioClip liftSound;

	public DeskOperator deskOperator;

	public float confirmInterval = 1f;

	public string[] contentNames;

	private string currentContent;

	private int lastStep;

	private int currentStep;

	public static Action onContentChanged;

	public static Action OnAnimationCompleted;

	public float speed = 35f;

	private float triggerTime;

	private bool isExecuted;

	private void Start()
	{
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	public void Reset()
	{
		Load(currentStep);
	}

	public void LoadGuide()
	{
		StartCoroutine("LoadContent", "guide");
	}

	private void OnDestroy()
	{
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	private void Update()
	{
		if (Time.time - triggerTime > confirmInterval && !isExecuted)
		{
			DoLoad(currentStep);
			isExecuted = true;
		}
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		if (mode.Equals(LoadSceneMode.Additive))
		{
			DisplayContent();
		}
	}

	private void DisplayContent()
	{
		GameObject gameObject = GameObject.Find("Content");
		if (gameObject != null)
		{
			deskOperator?.OpenDesk(0.2f * speed * Time.deltaTime);
			gameObject.transform.DOLocalMoveY(0f, speed * Time.deltaTime).OnComplete(delegate
			{
				OnAnimationCompleted?.Invoke();
			});
		}
	}

	public void Load(int step)
	{
		triggerTime = Time.time;
		currentStep = step;
		isExecuted = false;
	}

	public void DoLoad(int step)
	{
		if (step == lastStep)
		{
			return;
		}
		lastStep = step;
		string contentName = GetContentName(step);
		if (string.IsNullOrEmpty(contentName))
		{
			MonoSingleton<Instructions>.Instance().Init(LanCode.ContinuePlay);
		}
		StopAllCoroutines();
		if (contentName != null)
		{
			if (onContentChanged != null)
			{
				onContentChanged();
			}
			StartCoroutine("LoadContent", contentName);
		}
	}

	private IEnumerator LoadContent(string name)
	{
		GameObject gameObject = GameObject.Find("Content");
		if (gameObject != null)
		{
			deskOperator.OpenDesk(speed * Time.deltaTime);
			MonoSingleton<SoundMgr>.Instance().PlaySound(liftSound, base.transform.position);
			gameObject.transform.DOLocalMoveY(-0.5f, speed * Time.deltaTime).OnComplete(CloseDesk);
		}
		yield return new WaitForSeconds(2f * speed * Time.deltaTime);
		MonoSingleton<SceneMgr>.Instance().LoadSceneAdditive(name);
	}

	private void CloseDesk()
	{
		deskOperator.CloseDesk(speed * Time.deltaTime);
	}

	private string GetContentName(int step)
	{
		return step switch
		{
			1 => contentNames[step - 1], 
			2 => contentNames[step - 1], 
			3 => contentNames[step - 1], 
			6 => contentNames[step - 2], 
			7 => contentNames[step - 2], 
			_ => "", 
		};
	}
}
public class DeskOperator : MonoBehaviour
{
	private Transform left;

	private Transform right;

	private void Start()
	{
		left = base.transform.Find("desk/move_left");
		right = base.transform.Find("desk/move_right");
	}

	public void CloseDesk(float time)
	{
		left.DOScaleX(1f, time);
		right.DOScaleX(1f, time);
	}

	public void OpenDesk(float time)
	{
		left.DOScaleX(0.1f, time);
		right.DOScaleX(0.1f, time);
	}
}
public class DialIndicator : MonoBehaviour
{
	public Transform[] indicators;

	public Material on;

	public Material off;

	public void ChangeIndicator(int step)
	{
		int indicatorIndex = GetIndicatorIndex(step);
		for (int i = 0; i < indicators.Length; i++)
		{
			if (i == indicatorIndex)
			{
				indicators[i].GetComponent<Renderer>().material = on;
			}
			else
			{
				indicators[i].GetComponent<Renderer>().material = off;
			}
		}
	}

	private int GetIndicatorIndex(int step)
	{
		return step switch
		{
			1 => 0, 
			2 => 1, 
			3 => 2, 
			5 => 3, 
			6 => 4, 
			7 => 5, 
			_ => -1, 
		};
	}
}
public class Drawer : MonoBehaviour
{
	public AudioClip drawerSound;

	private bool foward;

	private float lastDistance;

	private bool played;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnDragBegin()
	{
		MonoSingleton<SoundMgr>.Instance().PlaySound(drawerSound, base.transform.position);
	}

	public void OnDragEnd()
	{
		MonoSingleton<SoundMgr>.Instance().StopSound(drawerSound);
	}
}
public class GradeMgr : MonoSingleton<GradeMgr>
{
	public Image[] gradeMenus;

	public Sprite backgroundImage;

	public Sprite selectionImage;

	public GameObject classification;

	public GameObject[] gradeContents;

	private int grade;

	private int classCode;

	private void Start()
	{
		if (gradeMenus != null && gradeMenus.Length != 0)
		{
			gradeMenus[0].sprite = selectionImage;
			classification.SetActive(value: true);
		}
	}

	public int GetGrade()
	{
		return grade;
	}

	public void SetGrade(int grade)
	{
		this.grade = grade;
		for (int i = 0; i < gradeMenus.Length; i++)
		{
			if (i == grade)
			{
				gradeMenus[i].sprite = selectionImage;
			}
			else
			{
				gradeMenus[i].sprite = backgroundImage;
			}
		}
		classification.SetActive(value: true);
		for (int j = 0; j < gradeContents.Length; j++)
		{
			gradeContents[j].SetActive(value: false);
		}
	}

	public void SetClassification(int classCode)
	{
		this.classCode = classCode;
		classification.SetActive(value: false);
		for (int i = 0; i < gradeContents.Length; i++)
		{
			if (gradeContents[i].name.Contains(grade.ToString() + classCode))
			{
				gradeContents[i].SetActive(value: true);
			}
			else
			{
				gradeContents[i].SetActive(value: false);
			}
		}
	}
}
public class HouseMgr : MonoBehaviour
{
	private static ContentLoader m_Loader;

	private static int m_GuideIndex;

	private AudioClip m_OpenningAudio;

	private bool m_IsCourseChoosed;

	public static void SetContentLoader(ContentLoader contentLoader)
	{
		if (m_Loader != null)
		{
			m_Loader.gameObject.SetActive(value: false);
		}
		m_Loader = contentLoader;
		m_Loader.gameObject.SetActive(value: true);
		m_Loader.Reset();
	}

	private void Start()
	{
		MonoSingleton<Instructions>.Instance().Init(LanCode.HouseWelcome);
		m_OpenningAudio = SLocalization.GetAudio(LanCode.Openning);
		MonoSingleton<SoundMgr>.Instance().PlaySound(m_OpenningAudio, base.transform.position);
	}

	private void Update()
	{
		if (!m_IsCourseChoosed && m_Loader != null)
		{
			SetGuide();
			m_IsCourseChoosed = true;
		}
	}

	private void SetGuide()
	{
		m_GuideIndex = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().guided;
		if (m_GuideIndex < 4)
		{
			Invoke("LoadGuide", m_OpenningAudio.length);
		}
	}

	private void LoadGuide()
	{
		m_Loader?.LoadGuide();
	}
}
public class LobbyMgr : MonoBehaviour
{
	public bool releaseVersion;

	public Sprite HintSprite;

	private bool m_IsChosed;

	private string m_Serial;

	private string m_Model;

	private string m_SystemLanguage;

	private Device m_Device;

	private void Awake()
	{
		UnityEngine.Debug.unityLogger.logEnabled = !releaseVersion;
		AndroidJavaObject androidJavaObject = new AndroidJavaObject("android.os.Build");
		if (PlayerPrefs.HasKey("serial"))
		{
			m_Serial = PlayerPrefs.GetString("serial");
		}
		else
		{
			m_Serial = androidJavaObject.GetStatic<string>("SERIAL");
			if (m_Serial == null || m_Serial.Equals("unknown"))
			{
				byte[] value = Guid.NewGuid().ToByteArray();
				m_Serial = BitConverter.ToInt64(value, 0).ToString();
				UnityEngine.Debug.Log("serial:" + m_Serial);
			}
			PlayerPrefs.SetString("serial", m_Serial);
		}
		m_Model = androidJavaObject.GetStatic<string>("MODEL");
		AndroidJavaClass androidJavaClass = new AndroidJavaClass("java/util/Locale");
		AndroidJavaObject androidJavaObject2 = androidJavaClass.CallStatic<AndroidJavaObject>("getDefault", Array.Empty<object>());
		AndroidJavaObject @static = androidJavaClass.GetStatic<AndroidJavaObject>("US");
		if (androidJavaObject2 != null)
		{
			m_SystemLanguage = androidJavaObject2.Call<string>("getDisplayLanguage", new object[1] { @static });
		}
		if (m_SystemLanguage == null)
		{
			m_SystemLanguage = "English";
		}
		if (m_SystemLanguage.Equals("Chinese"))
		{
			ISILocalization.ChangeLanguage(Language.Chinese);
			SLocalization.defaultLanguage = "Chinese";
		}
		else
		{
			ISILocalization.ChangeLanguage(Language.English);
			SLocalization.defaultLanguage = "English";
		}
	}

	private void Start()
	{
		MonoSingleton<Instructions>.Instance().SetText(LanCode.Welcome);
		Invoke("Welcome", 2f);
		if (m_Serial == null)
		{
			m_Serial = "test";
		}
		if (m_Model == null)
		{
			m_Model = "unknown";
		}
		m_Device = new Device(0, m_Serial, m_Model, new Dictionary<int, int>().ToJson(), "", DateTime.Now.ToString("u"));
		DataSourceFactory.GetDataSource().GetDeviceService().GetDevice(m_Serial, onGetDevice);
	}

	private void Welcome()
	{
		AudioClip audio = SLocalization.GetAudio(LanCode.Welcome);
		MonoSingleton<SoundMgr>.Instance().PlaySound(audio, base.transform.position);
		Invoke("Guide", audio.length + 0.5f);
	}

	private void Guide()
	{
		MonoSingleton<Instructions>.Instance().SetText(LanCode.ChooseProfile);
		MonoSingleton<Instructions>.Instance().GetSpriteRenderer().sprite = HintSprite;
		MonoSingleton<SoundMgr>.Instance().PlaySound(SLocalization.GetAudio(LanCode.LobbyIntro), base.transform.position);
	}

	private void onGetDevice(Device[] obj)
	{
		if (obj == null || obj.Length == 0)
		{
			DataSourceFactory.GetDataSource().GetDeviceService().CreateDevice(m_Device, onCreateDevice);
		}
		else
		{
			m_Device = obj[0];
		}
	}

	private void onCreateDevice(Device obj)
	{
		if (obj != null && obj.dev_id != 0)
		{
			m_Device = obj;
		}
	}

	public void Choose(UserProfile profile)
	{
		if (!m_IsChosed)
		{
			m_IsChosed = true;
			profile.device = m_Device;
			MonoSingleton<AccountMgr>.Instance().SetUserProfile(profile);
			GetComponent<SceneFadeInOut>()?.EndScene();
			StartCoroutine(LoadScene());
		}
	}

	private IEnumerator LoadScene()
	{
		UnityEngine.AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("house");
		while (!asyncLoad.isDone)
		{
			yield return new WaitForSeconds(0.5f);
		}
	}
}
public class UserProfile : MonoBehaviour
{
	[HideInInspector]
	public Device device;

	public int index;

	[HideInInspector]
	public ProfileData data;

	private string key;

	private void Start()
	{
		if (index == -1)
		{
			for (int i = 3; i < 10000; i++)
			{
				if (!PlayerPrefs.HasKey("Profile" + i))
				{
					index = i;
					break;
				}
			}
		}
		key = "Profile" + index;
		if (PlayerPrefs.HasKey(key))
		{
			data = PlayerPrefs.GetString(key).FromJson<ProfileData>();
		}
		else
		{
			data = new ProfileData();
		}
	}

	internal void Store()
	{
		PlayerPrefs.SetString(key, data.ToJson());
	}
}
[Serializable]
public class ProfileData
{
	public int userID;

	public int tangramGrade;

	public int tangramLevel;

	public bool tangramCompleted;

	public int threeviewGrade;

	public int threeviewLevel;

	public bool threeviewCompleted;

	public int creatorGrade;

	public int creatorLevel;

	public bool creatorCompleted;

	public int sudokuGrade;

	public int sudokuLevel;

	public bool sudokuCompleted;

	public int substitutionGrade;

	public int substitutionLevel;

	public bool substitutionCompleted;

	public int cycleGrade;

	public int cycleLevel;

	public bool cycleCompleted;

	public int guided;

	public List<Toy> toys;

	public List<Medal> medals;

	public ProfileData()
	{
		toys = new List<Toy>();
		medals = new List<Medal>();
	}

	public bool Contains(string toyType)
	{
		for (int i = 0; i < toys.Count; i++)
		{
			if (toys[i].type.Contains(toyType))
			{
				return true;
			}
		}
		return false;
	}
}
public class AllumetteMgr : MonoBehaviour
{
	private void Start()
	{
		MonoSingleton<Instructions>.Instance().Init(LanCode.MatchIntro);
	}

	private void Update()
	{
	}
}
public class MatchComposite : MonoBehaviour
{
	public AudioClip magicSound;

	public Transform parentGO;

	public Transform matchGroupPrefab;

	private bool compositing;

	private ParticleSystem[] ps;

	private List<GameObject> parts;

	private Interactable interactable;

	private void Start()
	{
		ps = GetComponentsInChildren<ParticleSystem>();
		parts = new List<GameObject>();
		interactable = GetComponent<Interactable>();
	}

	private void Update()
	{
		if (interactable.isSelected && (MonoSingleton<InputHandler>.Instance().GetIndexTriggerValue(InputHandler.ControllerType.Left) > 0f || MonoSingleton<InputHandler>.Instance().GetIndexTriggerValue(InputHandler.ControllerType.Right) > 0f))
		{
			if (!compositing)
			{
				compositing = true;
				for (int i = 0; i < ps.Length; i++)
				{
					ps[i].Play();
				}
				MonoSingleton<SoundMgr>.Instance().PlaySound(magicSound, base.transform.position, 0f, new SoundMgr.PlayParameters
				{
					Pitch = 1f,
					SourceID = 1000 + int.Parse(DateTime.Now.ToString("HHmmssfff")),
					Volume = 1f,
					Loop = false
				}, 0f);
			}
			return;
		}
		MonoSingleton<SoundMgr>.Instance().StopSound(magicSound);
		if (compositing)
		{
			compositing = false;
			for (int j = 0; j < ps.Length; j++)
			{
				ps[j].Stop();
			}
			Composite();
		}
	}

	private void Composite()
	{
		if (parts.Count > 0)
		{
			Transform transform = UnityEngine.Object.Instantiate(matchGroupPrefab, parentGO);
			transform.localPosition = Vector3.zero;
			for (int i = 0; i < parts.Count; i++)
			{
				parts[i].transform.SetParent(transform, worldPositionStays: false);
				parts[i].transform.GetComponent<OffsetGrabbable>().enabled = false;
				parts[i].transform.GetComponent<Collider>().enabled = false;
			}
			transform.GetComponent<SphereCollider>().center = parts[0].transform.localPosition;
			UnityEngine.Debug.Log("matchGroup:" + transform.transform.position);
			parts.Clear();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (compositing && other.gameObject.tag.Equals("Match") && !parts.Contains(other.gameObject))
		{
			parts.Add(other.gameObject);
		}
	}
}
public class StickEnd : MonoBehaviour
{
	private Rigidbody rb;

	private void Start()
	{
		rb = GetComponentInParent<Rigidbody>();
	}

	private void OnTriggerEnter(Collider other)
	{
		UnityEngine.Debug.Log("StickEnd trigger enter");
		if (other.tag.Equals("StickStart") && other.GetComponentInParent<OffsetGrabbable>().isSelected)
		{
			other.GetComponent<StickPoint>().SetStick(isStick: true, base.transform.position - other.transform.position);
		}
	}

	public void SetStick(bool isStick, Vector3 position)
	{
		rb.centerOfMass = base.transform.position - base.transform.parent.position;
		rb.MovePosition(position);
	}
}
public class StickPoint : MonoBehaviour
{
	private bool isStick;

	private Vector3 stickPosition;

	private Rigidbody rb;

	private OffsetGrabbable grabbable;

	private void Start()
	{
		rb = GetComponentInParent<Rigidbody>();
		grabbable = GetComponentInParent<OffsetGrabbable>();
	}

	private void FixedUpdate()
	{
		if (!isStick)
		{
			return;
		}
		if ((double)Vector3.Distance(stickPosition, rb.position) <= 0.05 && grabbable.enabled && !grabbable.isSelected)
		{
			if ((double)Vector3.Distance(stickPosition, rb.position) < 0.0001)
			{
				isStick = false;
			}
			rb.MovePosition(stickPosition);
		}
		if ((double)Vector3.Distance(stickPosition, rb.position) > 0.05)
		{
			isStick = false;
		}
	}

	public void SetStick(bool isStick, Vector3 position)
	{
		this.isStick = isStick;
		if (isStick)
		{
			stickPosition = rb.position + position;
			rb.MovePosition(stickPosition);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag.Equals("StickPoint") && other.GetComponentInParent<OffsetGrabbable>().isSelected)
		{
			other.GetComponent<StickPoint>().SetStick(isStick: true, base.transform.position - other.transform.position);
		}
	}
}
public class Menu_Button : Button
{
	private float highlightZOffset = 2f;

	private Vector3 orgPostion;

	private Vector3 highlightPostion;

	protected override void Start()
	{
		base.Start();
		orgPostion = base.transform.localPosition;
		highlightPostion = orgPostion - new Vector3(0f, 0f, highlightZOffset);
	}

	public override void OnPointerEnter(PointerEventData eventData)
	{
		base.OnPointerEnter(eventData);
		base.transform.DOLocalMove(highlightPostion, 0.15f).SetUpdate(isIndependentUpdate: true);
	}

	public override void OnPointerExit(PointerEventData eventData)
	{
		base.OnPointerExit(eventData);
		base.transform.DOLocalMove(orgPostion, 0.15f).SetUpdate(isIndependentUpdate: true);
	}

	public override void OnPointerClick(PointerEventData eventData)
	{
		base.OnPointerClick(eventData);
		base.transform.localPosition = orgPostion;
	}
}
public class MySRP : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}
}
public class CaculateMgr : MonoBehaviour
{
	public EquationGenerator.EquationMode mode;

	private RectTransform answer;

	public Transform spawnPointL;

	public Transform spawnPointR;

	public Container[] containers;

	private int numL;

	private int numR;

	private int rightIndex;

	private int level;

	private List<Transform> LCubes;

	private List<Transform> RCubes;

	private List<Transform> objects;

	public Action onLoadLevel;

	private void Awake()
	{
		objects = new List<Transform>();
		level = 0;
	}

	private void Start()
	{
		answer = MonoSingleton<Instructions>.Instance().GetExplain();
		if (mode.Equals(EquationGenerator.EquationMode.Addition))
		{
			MonoSingleton<Instructions>.Instance().Init(LanCode.PoolTen);
			MonoSingleton<VoiceMgr>.Instance().PlayVoice(SLocalization.GetAudio(LanCode.PoolTen));
		}
		else if (mode.Equals(EquationGenerator.EquationMode.Subtraction))
		{
			MonoSingleton<Instructions>.Instance().Init(LanCode.SplitTen);
			MonoSingleton<VoiceMgr>.Instance().PlayVoice(SLocalization.GetAudio(LanCode.SplitTen));
		}
		NextChallenge();
	}

	public void CompleteTask()
	{
		MonoSingleton<Instructions>.Instance().SetText(LanCode.ChooseAnswer);
		MonoSingleton<VoiceMgr>.Instance().PlayVoice("answerinst");
		mode.Equals(EquationGenerator.EquationMode.Addition);
		DisplayHint();
	}

	public int GetLevelCount()
	{
		return 0;
	}

	private void DisplayHint()
	{
		answer.gameObject.SetActive(value: true);
		Transform transform = answer.Find("LeftNum");
		transform.GetComponent<TMP_Text>().SetText(Framework.Singleton<EquationGenerator>.Instance.GetNumL().ToString());
		transform.Find("split").gameObject.SetActive(value: false);
		Transform transform2 = answer.Find("RightNum");
		transform2.GetComponent<TMP_Text>().SetText(Framework.Singleton<EquationGenerator>.Instance.GetNumR().ToString());
		transform2.Find("split").gameObject.SetActive(value: false);
		answer.Find("Symbol").GetComponent<TMP_Text>().SetText(Framework.Singleton<EquationGenerator>.Instance.GetSymbol());
		if (mode.Equals(EquationGenerator.EquationMode.Addition))
		{
			Transform obj = ((numL >= numR) ? transform2 : transform);
			obj.Find("split").gameObject.SetActive(value: true);
			int num = ((numL >= numR) ? (10 - numL) : (numL + numR - 10));
			int num2 = ((numL >= numR) ? (numR + numL - 10) : (10 - numR));
			obj.Find("split/Left/Num").GetComponent<TMP_Text>().SetText(num.ToString());
			obj.Find("split/Right/Num").GetComponent<TMP_Text>().SetText(num2.ToString());
			obj.Find("split/Bottom")?.gameObject.SetActive(value: false);
		}
		else if (mode.Equals(EquationGenerator.EquationMode.Subtraction))
		{
			transform.Find("split").gameObject.SetActive(value: true);
			int num3 = Framework.Singleton<EquationGenerator>.Instance.GetNumL() - 10;
			int num4 = 10;
			transform.Find("split/Left/Num").GetComponent<TMP_Text>().SetText(num3.ToString());
			transform.Find("split/Right/Num").GetComponent<TMP_Text>().SetText(num4.ToString());
			transform.Find("split/Bottom")?.gameObject.SetActive(value: true);
			transform.Find("split/Bottom/Num").GetComponent<TMP_Text>().SetText((10 - Framework.Singleton<EquationGenerator>.Instance.GetNumR()).ToString());
		}
	}

	public int GetLevel()
	{
		return level;
	}

	private void GenerateCubes()
	{
		DestoryObjects();
		if (mode.Equals(EquationGenerator.EquationMode.Subtraction))
		{
			MonoSingleton<CubeGenerator>.Instance().GenerateTenModel(spawnPointL);
		}
		else
		{
			LCubes = MonoSingleton<CubeGenerator>.Instance().GenerateCubes(numL, spawnPointL);
			containers[0].AddObjects(LCubes);
		}
		RCubes = MonoSingleton<CubeGenerator>.Instance().GenerateCubes(numR, spawnPointR);
		containers[1].AddObjects(RCubes);
		if (mode.Equals(EquationGenerator.EquationMode.Addition))
		{
			if (numL < numR)
			{
				_ = RCubes;
			}
			else
			{
				_ = LCubes;
			}
		}
		else if (mode.Equals(EquationGenerator.EquationMode.Subtraction))
		{
			_ = RCubes;
		}
	}

	private void DestoryObjects()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("CountItem");
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				UnityEngine.Object.Destroy(array[i]);
			}
		}
		containers[0].Restore();
		containers[1].Restore();
		if (LCubes != null)
		{
			LCubes.Clear();
		}
		if (RCubes != null)
		{
			RCubes.Clear();
		}
	}

	public void NextChallenge()
	{
		Framework.Singleton<EquationGenerator>.Instance.Mode = mode;
		Framework.Singleton<EquationGenerator>.Instance.grade = 1;
		Framework.Singleton<EquationGenerator>.Instance.GenerateNumbers();
		if (mode.Equals(EquationGenerator.EquationMode.Addition))
		{
			numL = Framework.Singleton<EquationGenerator>.Instance.GetNumL();
			numR = Framework.Singleton<EquationGenerator>.Instance.GetNumR();
		}
		else if (mode.Equals(EquationGenerator.EquationMode.Subtraction))
		{
			numL = 10;
			numR = Framework.Singleton<EquationGenerator>.Instance.GetNumL() - 10;
		}
		GenerateCubes();
		MonoSingleton<Instructions>.Instance().GetProgressText().text = Framework.Singleton<EquationGenerator>.Instance.GetNumL() + Framework.Singleton<EquationGenerator>.Instance.GetSymbol() + Framework.Singleton<EquationGenerator>.Instance.GetNumR() + "=?";
		level++;
		answer.gameObject.SetActive(value: false);
		if (onLoadLevel != null)
		{
			onLoadLevel();
		}
	}
}
[RequireComponent(typeof(Container))]
public class ContainerCheck : MonoBehaviour
{
	public CaculateMgr mgr;

	public TMP_Text countText;

	public TMP_Text hint;

	private bool isCompleted;

	private List<Transform> objects;

	private int count;

	private Container container;

	private void Start()
	{
		LoadLevel();
		CaculateMgr caculateMgr = mgr;
		caculateMgr.onLoadLevel = (Action)Delegate.Combine(caculateMgr.onLoadLevel, new Action(LoadLevel));
		container = GetComponent<Container>();
		Container obj = container;
		obj.onEnter = (Action<Collider>)Delegate.Combine(obj.onEnter, new Action<Collider>(Check));
	}

	private void Check(Collider other)
	{
		if (!other.gameObject.name.Contains("GrabVolumeSmall"))
		{
			return;
		}
		if (Framework.Singleton<EquationGenerator>.Instance.Mode.Equals(EquationGenerator.EquationMode.Addition) && Framework.Singleton<EquationGenerator>.Instance.GetSmallerOne() != container.index)
		{
			hint.text = "请拿少一边的积木，拆小数补大数来凑十";
			MonoSingleton<VoiceMgr>.Instance().PlayVoice("SplitSmallOne");
		}
		if (Framework.Singleton<EquationGenerator>.Instance.Mode.Equals(EquationGenerator.EquationMode.Subtraction))
		{
			if (container.index != 0)
			{
				hint.text = "请从10个积木那边拿掉减去的积木";
				MonoSingleton<VoiceMgr>.Instance().PlayVoice("RemoveTen");
			}
			if (container.index == 0 && count == 10 - Framework.Singleton<EquationGenerator>.Instance.GetNumR())
			{
				hint.text = "已经拿掉了减去的积木，请按桌上的数字选择答案吧";
				MonoSingleton<VoiceMgr>.Instance().PlayVoice("subinst");
			}
		}
	}

	private void LoadLevel()
	{
		isCompleted = false;
	}

	private void Update()
	{
		objects = container.GetObjects();
		count = objects.Count;
		countText.text = count.ToString();
		if (Framework.Singleton<EquationGenerator>.Instance.Mode.Equals(EquationGenerator.EquationMode.Addition) && count == 10 && !isCompleted)
		{
			isCompleted = true;
			MonoSingleton<CubeGenerator>.Instance().GenerateTenModel(base.transform.parent);
			Interactable component = objects[9].GetComponent<Interactable>();
			component.interactedBy?.Offhand(component);
			container.ClearObjects();
			mgr.CompleteTask();
		}
	}

	private void OnDisable()
	{
		CaculateMgr caculateMgr = mgr;
		caculateMgr.onLoadLevel = (Action)Delegate.Remove(caculateMgr.onLoadLevel, new Action(LoadLevel));
		Container obj = container;
		obj.onEnter = (Action<Collider>)Delegate.Remove(obj.onEnter, new Action<Collider>(Check));
	}
}
public class CubeContainer : Container
{
	protected override bool IsTriggered(Collider other)
	{
		return other.gameObject.name.Equals("rod");
	}
}
public class CubeGenerator : MonoSingleton<CubeGenerator>
{
	public Transform cubePrefab;

	public Transform tenModel;

	private int numberInLine = 5;

	private float scale = 0.19934f;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void GenerateTenModel(Transform parent)
	{
		float x = parent.position.x + parent.lossyScale.x * scale * (float)(2 % numberInLine);
		float y = parent.position.y + parent.lossyScale.y * scale;
		float z = parent.position.z - parent.lossyScale.z * scale * (float)(2 / numberInLine);
		UnityEngine.Object.Instantiate(tenModel, new Vector3(x, y, z), Quaternion.identity, parent);
	}

	public List<Transform> GenerateCubes(int number, Transform parent)
	{
		List<Transform> list = new List<Transform>();
		if (number <= 0)
		{
			return list;
		}
		_ = number / numberInLine;
		for (int i = 0; i < number; i++)
		{
			float x = parent.position.x + parent.lossyScale.x * scale * (float)(i % numberInLine);
			float y = parent.position.y + parent.lossyScale.y * scale * 0.5f;
			float z = parent.position.z - parent.lossyScale.z * scale * (float)(i / numberInLine);
			Transform transform = UnityEngine.Object.Instantiate(cubePrefab, new Vector3(x, y, z), Quaternion.identity, parent);
			transform.name = "rod";
			list.Add(transform);
		}
		return list;
	}
}
public class CubeRecycle : MonoBehaviour
{
	public CaculateMgr mgr;

	public TMP_Text countText;

	public AudioClip sound;

	private ParticleSystem disappear;

	private int count;

	private bool isCompleted;

	private void Start()
	{
		if (disappear == null)
		{
			GameObject gameObject = GameObject.Find("ZhaLie");
			if (gameObject != null)
			{
				disappear = gameObject.GetComponent<ParticleSystem>();
			}
		}
		CaculateMgr caculateMgr = mgr;
		caculateMgr.onLoadLevel = (Action)Delegate.Combine(caculateMgr.onLoadLevel, new Action(LoadLevel));
	}

	private void LoadLevel()
	{
		isCompleted = false;
		count = 0;
	}

	private void Update()
	{
		countText.text = count.ToString();
		if (Framework.Singleton<EquationGenerator>.Instance.Mode.Equals(EquationGenerator.EquationMode.Subtraction) && count == Framework.Singleton<EquationGenerator>.Instance.GetNumR() && !isCompleted)
		{
			isCompleted = true;
			mgr.CompleteTask();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		GameObject gameObject = other.gameObject;
		if (!isCompleted && other.gameObject.name.Equals("rod"))
		{
			if (disappear != null)
			{
				disappear.transform.position = gameObject.transform.position;
				disappear.Play();
			}
			MonoSingleton<SoundMgr>.Instance().PlaySound(sound, base.transform.position);
			GrabInteractable componentInChildren = gameObject.GetComponentInChildren<GrabInteractable>();
			componentInChildren.interactedBy?.Offhand(componentInChildren);
			UnityEngine.Object.Destroy(gameObject);
			count++;
			countText.text = count.ToString();
		}
	}

	private void DestoryObjects(List<Transform> objects)
	{
		if (objects != null)
		{
			for (int i = 0; i < objects.Count; i++)
			{
				UnityEngine.Object.Destroy(objects[i].gameObject);
			}
			objects.Clear();
		}
	}

	private void OnDisable()
	{
		CaculateMgr caculateMgr = mgr;
		caculateMgr.onLoadLevel = (Action)Delegate.Remove(caculateMgr.onLoadLevel, new Action(LoadLevel));
	}
}
public class EquationGenerator : Framework.Singleton<EquationGenerator>
{
	public enum EquationMode
	{
		Addition,
		Subtraction,
		Multiplication,
		Division
	}

	public int grade;

	private int numL;

	private int numR;

	public EquationMode Mode { get; set; }

	public void GenerateNumbers()
	{
		if (Mode.Equals(EquationMode.Addition))
		{
			GenerateAdditionNumbers(grade, out numL, out numR);
		}
		else if (Mode.Equals(EquationMode.Subtraction))
		{
			GenerateSubtractionNumbers(grade, out numL, out numR);
		}
		else if (Mode.Equals(EquationMode.Multiplication))
		{
			GenerateMultiplicationNumbers(grade, out numL, out numR);
		}
		else if (Mode.Equals(EquationMode.Division))
		{
			GenerateDivisionNumbers(grade, out numL, out numR);
		}
	}

	private void GenerateDivisionNumbers(int grade, out int numL, out int numR)
	{
		numR = UnityEngine.Random.Range(1, 10);
		numL = UnityEngine.Random.Range(1, 10) * numR;
	}

	private void GenerateMultiplicationNumbers(int grade, out int numL, out int numR)
	{
		numL = UnityEngine.Random.Range(1, 10);
		numR = UnityEngine.Random.Range(1, 10);
	}

	private void GenerateSubtractionNumbers(int grade, out int numL, out int numR)
	{
		switch (grade)
		{
		case 0:
			numL = UnityEngine.Random.Range(1, 10);
			numR = UnityEngine.Random.Range(1, numL);
			break;
		case 1:
			numL = UnityEngine.Random.Range(11, 20);
			numR = UnityEngine.Random.Range(1, 10);
			while (numL - numR >= 10)
			{
				numL = UnityEngine.Random.Range(11, 20);
				numR = UnityEngine.Random.Range(1, 10);
			}
			break;
		default:
			numL = UnityEngine.Random.Range(10, 100);
			numR = UnityEngine.Random.Range(1, numL);
			break;
		}
	}

	private void GenerateAdditionNumbers(int grade, out int numL, out int numR)
	{
		switch (grade)
		{
		case 0:
			numL = UnityEngine.Random.Range(1, 10);
			numR = UnityEngine.Random.Range(1, 10);
			while (numL + numR > 10)
			{
				numL = UnityEngine.Random.Range(1, 10);
				numR = UnityEngine.Random.Range(1, 10);
			}
			break;
		case 1:
			numL = UnityEngine.Random.Range(1, 10);
			numR = UnityEngine.Random.Range(1, 10);
			while (numL + numR <= 10)
			{
				numL = UnityEngine.Random.Range(1, 10);
				numR = UnityEngine.Random.Range(1, 10);
			}
			break;
		default:
			numL = UnityEngine.Random.Range(10, 100);
			numR = UnityEngine.Random.Range(1, 100);
			while (numL + numR > 100)
			{
				numL = UnityEngine.Random.Range(10, 100);
				numR = UnityEngine.Random.Range(1, 100);
			}
			break;
		}
	}

	public int GetRightAnswer()
	{
		if (Mode.Equals(EquationMode.Addition))
		{
			return numL + numR;
		}
		if (Mode.Equals(EquationMode.Subtraction))
		{
			return numL - numR;
		}
		if (Mode.Equals(EquationMode.Multiplication))
		{
			return numL * numR;
		}
		if (Mode.Equals(EquationMode.Division))
		{
			return numL / numR;
		}
		return 0;
	}

	public int GetNumL()
	{
		return numL;
	}

	public int GetNumR()
	{
		return numR;
	}

	public string GetSymbol()
	{
		if (Mode.Equals(EquationMode.Addition))
		{
			return "+";
		}
		if (Mode.Equals(EquationMode.Subtraction))
		{
			return "-";
		}
		if (Mode.Equals(EquationMode.Multiplication))
		{
			return "×";
		}
		if (Mode.Equals(EquationMode.Division))
		{
			return "÷";
		}
		return "+";
	}

	public int GetSmallerOne()
	{
		if (numL >= numR)
		{
			return 1;
		}
		return 0;
	}
}
public class MagicBall : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name.Contains("rods"))
		{
			MonoSingleton<CubeGenerator>.Instance().GenerateCubes(10, other.transform.parent);
			UnityEngine.Object.Destroy(other.gameObject);
		}
	}
}
[RequireComponent(typeof(Choice))]
public class NumAnswerCheck : AnswerChecker
{
	public TMP_Text hint;

	public TMP_Text grade;

	public TMP_Text score;

	public ParticleSystem successEffect;

	private int wrongCount;

	private const int scoreValue = 100;

	private CaculateMgr mgr;

	private void Awake()
	{
		AnswerButton.onButtonDown = (Action<int>)Delegate.Combine(AnswerButton.onButtonDown, new Action<int>(base.CheckAnswer));
		choice = GetComponent<Choice>();
		mgr = GetComponent<CaculateMgr>();
	}

	private void OnDestroy()
	{
		AnswerButton.onButtonDown = (Action<int>)Delegate.Remove(AnswerButton.onButtonDown, new Action<int>(base.CheckAnswer));
	}

	protected override void AnswerWrong()
	{
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.AnswerWrong);
		int num = int.Parse(score.text) - 100 * (MonoSingleton<Statistics>.Instance().GetGrade() + 1);
		UnityEngine.Debug.Log("grade:" + MonoSingleton<Statistics>.Instance().GetGrade());
		score.text = ((num > 0) ? num : 0).ToString();
		wrongCount++;
		if (wrongCount < 4)
		{
			hint.text = "再试一次,或者按菜单键退出.";
			return;
		}
		wrongCount = 0;
		hint.text = "换一个问题试试吧";
		ChallengeNewLevel(isCorrect: false);
	}

	protected override void AnswerRight()
	{
		if (GetLevel() == GetLevelCount() - 1)
		{
			hint.text = "你真棒，完成所有挑战。请按菜单键退出，继续进行别的挑战吧";
			MonoSingleton<VoiceMgr>.Instance().PlayVoice("AssessmentCompleted");
			return;
		}
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.AnswerRight);
		UnityEngine.Debug.Log("grade:" + MonoSingleton<Statistics>.Instance().GetGrade());
		int num = int.Parse(score.text) + 100 * (MonoSingleton<Statistics>.Instance().GetGrade() + 1);
		score.text = num.ToString();
		hint.text = "很棒,回答正确!继续进行新的挑战吧.";
		StartCoroutine("TriggerSuccessEffect");
		ChallengeNewLevel(isCorrect: true);
	}

	private void ChallengeNewLevel(bool isCorrect)
	{
		MonoSingleton<Statistics>.Instance().RoundEnd(isCorrect);
		Challenge(isCorrect);
		MonoSingleton<Statistics>.Instance().RoundStart(GetLevel());
		grade.text = MonoSingleton<Statistics>.Instance().GetGrade().ToString();
	}

	private IEnumerator TriggerSuccessEffect()
	{
		successEffect.Play();
		yield return new WaitForSeconds(1f);
		successEffect.Stop();
	}

	private int GetLevel()
	{
		return mgr.GetLevel();
	}

	private void Challenge(bool isCorrect)
	{
		if (isCorrect)
		{
			mgr.NextChallenge();
		}
	}

	private int GetLevelCount()
	{
		return mgr.GetLevelCount();
	}
}
public class NumberChoice : Choice
{
	private CaculateMgr mgr;

	internal override int[] GenerateNumbers()
	{
		new System.Random();
		int[] array = new int[3];
		int num = (array[0] = Framework.Singleton<EquationGenerator>.Instance.GetRightAnswer());
		array[1] = num + GenerateRandom(3);
		while (array[1] < 0)
		{
			array[1] = num + GenerateRandom(3);
		}
		array[2] = num + GenerateRandom(5);
		while (array[2] == array[1] || array[2] < 0)
		{
			array[2] = num + GenerateRandom(5);
		}
		return array;
	}

	internal override int GetLevel()
	{
		return mgr.GetLevel();
	}

	private void Start()
	{
		mgr = GetComponent<CaculateMgr>();
	}

	private void Update()
	{
		UpdateChoice();
	}
}
public class HandCamera : MonoBehaviour
{
	private Camera handCamera;

	private void Start()
	{
		handCamera = GetComponent<Camera>();
	}

	public void TakeAPhoto()
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = handCamera.targetTexture;
		handCamera.Render();
		Texture2D image = MonoSingleton<TextureUtil>.Instance().CreateImageFromScreen(handCamera.targetTexture.width, handCamera.targetTexture.height);
		RenderTexture.active = active;
		Framework.Singleton<MemoryMgr>.Instance.MakeMemory(image, handCamera);
	}
}
internal class MediaMgr : Framework.Singleton<MediaMgr>
{
	public Action<byte[]> onMediaLoaded;

	public void LoadMediaFiles(string local_path, string remote_path, bool force_sync, Action<List<Texture>> callback)
	{
		string text = Application.persistentDataPath + "/" + local_path + "/";
		if (!Directory.Exists(text))
		{
			FileUtil.CreateFolder(text);
			DownloadMediaFiles(text, remote_path);
		}
		else if (force_sync)
		{
			DownloadMediaFiles(text, remote_path);
		}
	}

	private void DownloadMediaFiles(string local_path, string remote_path)
	{
		if (remote_path != null)
		{
			Directory.Exists(local_path);
		}
	}

	public void UploadMediaFile(string file_name, string remote_path, byte[] data, Action<Media> callback)
	{
		MediaRequest mediaRequest = new MediaRequest();
		mediaRequest.type_id = 0;
		mediaRequest.name = file_name;
		mediaRequest.path = remote_path;
		mediaRequest.data = data;
		DataSourceFactory.GetDataSource().GetMediaService().CreateMedia(mediaRequest, callback);
	}

	public void DownloadMediaFile(int media_id, string path)
	{
		DataSourceFactory.GetDataSource().GetMediaService().DownloadMedia(media_id, path, OnDownloadMedia);
	}

	private void OnDownloadMedia(object obj, string path)
	{
		if (obj != null)
		{
			byte[] data = ((ResponseHelper)obj).Data;
			File.WriteAllBytes(path, data);
			onMediaLoaded?.Invoke(data);
		}
	}
}
internal class MemoryLoader : Framework.Singleton<MemoryLoader>
{
	internal void LoadMemoryInfo(Memory memory)
	{
		if (memory.type_id == 1)
		{
			if (SceneManager.GetSceneByName("threeview").isLoaded)
			{
				int[] array = memory.info.FromJson<List<int>>().ToArray();
				if (array != null)
				{
					(GameObject.Find("ThreeViewMgr")?.GetComponent<GridsMgr>()).GenerateCubes(array);
				}
				MonoSingleton<Instructions>.Instance().Init(LanCode.LoadSuccess, null, "");
			}
			else
			{
				MonoSingleton<Instructions>.Instance().SetText(LanCode.LoadCubeMemory);
			}
		}
		else
		{
			if (memory.type_id != 2)
			{
				return;
			}
			if (SceneManager.GetSceneByName("tangram").isLoaded)
			{
				TangramMgr.TangramInfo tangramInfo = memory.info.FromJson<TangramMgr.TangramInfo>();
				if (tangramInfo != null)
				{
					(GameObject.Find("TangramMgr")?.GetComponent<TangramMgr>()).SetTangramInfo(tangramInfo);
				}
			}
			else
			{
				MonoSingleton<Instructions>.Instance().SetText(LanCode.LoadTangramMemory);
			}
		}
	}

	internal string GetMemoryInfo(int typeID, Camera handCamera)
	{
		if (typeID == 0)
		{
			return "{}";
		}
		GameObject gameObject = GameObject.FindGameObjectWithTag("Center");
		if (!IsInCamera(gameObject.transform.position, handCamera))
		{
			return "{}";
		}
		return typeID switch
		{
			1 => new List<int>(GameObject.Find("ThreeViewMgr").GetComponent<GridsMgr>().GetCurrentGrids()).ToJson(), 
			2 => GameObject.Find("TangramMgr").GetComponent<TangramMgr>().GetTangramInfo()
				.ToJson(), 
			_ => "{}", 
		};
	}

	private bool IsInCamera(Vector3 position, Camera handCamera)
	{
		Vector3 point = handCamera.WorldToViewportPoint(position);
		if (!new Rect(0f, 0f, 1f, 1f).Contains(point))
		{
			return false;
		}
		if (point.z < handCamera.nearClipPlane || point.z > handCamera.farClipPlane)
		{
			return false;
		}
		return true;
	}
}
internal class MemoryMgr : Framework.Singleton<MemoryMgr>
{
	internal void MakeMemory(Texture2D image, Camera handCamera)
	{
		string name = (image.name = DateTime.Now.ToString("yyyyMMddHHmmssfff"));
		int userID = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().userID;
		int memoryType = GetMemoryType();
		string memoryInfo = Framework.Singleton<MemoryLoader>.Instance.GetMemoryInfo(memoryType, handCamera);
		Memory memory = new Memory(userID, 0, memoryType, memoryInfo, DateTime.Now.ToString("u"));
		SaveMemoryToFile(memory, name);
		HandleMedia(image);
	}

	private void HandleMedia(Texture2D image)
	{
		if (!(image == null))
		{
			string folderName = MonoSingleton<AccountMgr>.Instance().GetUserProfile().index.ToString();
			string remote_path = MonoSingleton<AccountMgr>.Instance().GetUserProfile().data.userID.ToString();
			byte[] data = image.EncodeToPNG();
			MonoSingleton<PhotoMgr>.Instance().AddPhoto(image);
			MonoSingleton<TextureUtil>.Instance().SaveTextureToFile(data, folderName, image.name);
			Framework.Singleton<MediaMgr>.Instance.UploadMediaFile(image.name + ".png", remote_path, data, OnUploadMedia);
		}
	}

	private void OnUploadMedia(Media obj)
	{
		if (obj != null && obj.media_id != 0)
		{
			CreateMemory(obj);
		}
	}

	public void CreateMemory(Media media)
	{
		string name = media.data.Substring(0, media.data.LastIndexOf("."));
		Memory localMemory = GetLocalMemory(name);
		if (localMemory != null)
		{
			localMemory.media_id = media.media_id;
			if (localMemory.memo_id != 0)
			{
				DataSourceFactory.GetDataSource().GetMemoryService().UpdateMemory(localMemory);
			}
			else
			{
				DataSourceFactory.GetDataSource().GetMemoryService().CreateMemory(localMemory, name, OnCreateMemory);
			}
		}
	}

	private void OnCreateMemory(Memory memory, string name)
	{
		SaveMemoryToFile(memory, name);
	}

	private void SaveMemoryToFile(Memory memory, string name)
	{
		if (FileUtil.CreateFolder(Application.persistentDataPath + "/" + MonoSingleton<AccountMgr>.Instance().GetUserProfile().index))
		{
			File.WriteAllText(GetMemoryFullName(name), memory.ToJson());
		}
		else
		{
			UnityEngine.Debug.LogError("create folder failure");
		}
	}

	internal void GetSharedMemories()
	{
		DataSourceFactory.GetDataSource().GetMemoryService().GetSharedMemories(MonoSingleton<AccountMgr>.Instance().GetUserProfile().data.userID, OnGetSharedMemories);
	}

	internal void LoadMemory(Texture texture, int type)
	{
		Memory memory = ((type != 1) ? GetLocalMemory(texture.name) : GetSharedMemory(texture.name));
		if (memory != null)
		{
			Framework.Singleton<MemoryLoader>.Instance.LoadMemoryInfo(memory);
		}
	}

	private void OnGetSharedMemories(Memory[] memories)
	{
		if (memories == null)
		{
			return;
		}
		foreach (Memory memory in memories)
		{
			FileUtil.CreateFolder(GetSharedMemoryPath());
			string path = GetSharedMemoryPath() + memory.media_id + ".png";
			if (!File.Exists(path))
			{
				SaveSharedMemoryToFile(memory, memory.media_id.ToString());
				Framework.Singleton<MediaMgr>.Instance.DownloadMediaFile(memory.media_id, path);
			}
		}
	}

	private void SaveSharedMemoryToFile(Memory memory, string name)
	{
		FileUtil.CreateFolder(GetSharedMemoryPath());
		File.WriteAllText(GetSharedMemoryFullName(name), memory.ToJson());
	}

	private string GetSharedMemoryFullName(string name)
	{
		return GetSharedMemoryPath() + name + ".txt";
	}

	private Memory GetMemory(string name, bool shared)
	{
		string path = GetMemoryFullName(name);
		if (shared)
		{
			path = GetSharedMemoryFullName(name);
		}
		if (File.Exists(path))
		{
			return File.ReadAllText(path).FromJson<Memory>();
		}
		return null;
	}

	public Memory GetLocalMemory(string name)
	{
		return GetMemory(name, shared: false);
	}

	public Memory GetSharedMemory(string name)
	{
		return GetMemory(name, shared: true);
	}

	private string GetMemoryFullName(string name)
	{
		return GetLocalMemoryPath() + name + ".txt";
	}

	private static string GetLocalMemoryPath()
	{
		return Application.persistentDataPath + "/" + MonoSingleton<AccountMgr>.Instance().GetUserProfile().index + "/";
	}

	private string GetSharedMemoryPath()
	{
		return Application.persistentDataPath + "/sharing/";
	}

	internal void DeleteMemory(Texture texture)
	{
		MonoSingleton<PhotoMgr>.Instance().Delete(texture);
		Memory localMemory = GetLocalMemory(texture.name);
		if (localMemory != null && localMemory.memo_id != 0)
		{
			localMemory.deleted = 1;
			DataSourceFactory.GetDataSource().GetMemoryService().UpdateMemory(localMemory);
		}
		FileUtil.DeleteFile(GetMemoryFullName(texture.name));
	}

	internal void ShareMemory(Texture texture)
	{
		Memory localMemory = GetLocalMemory(texture.name);
		if (localMemory != null)
		{
			localMemory.shared = 1;
			File.WriteAllText(GetMemoryFullName(texture.name), localMemory.ToJson());
			SyncMemory(localMemory, texture.name);
		}
	}

	public void SyncAllMemories()
	{
		foreach (string item in FileUtil.FindFiles(GetLocalMemoryPath(), ".txt"))
		{
			Memory memory = File.ReadAllText(item).FromJson<Memory>();
			string name = item.Substring(item.LastIndexOf("/") + 1, item.LastIndexOf(".") - (item.LastIndexOf("/") + 1));
			SyncMemory(memory, name);
		}
	}

	private void SyncMemory(Memory memory, string name)
	{
		if (memory.account_id == 0)
		{
			memory.account_id = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().userID;
			if (memory.account_id == 0)
			{
				return;
			}
			SaveMemoryToFile(memory, name);
		}
		if (memory.media_id == 0)
		{
			byte[] array = File.ReadAllBytes(GetLocalMemoryPath() + name + ".png");
			if (array != null)
			{
				Framework.Singleton<MediaMgr>.Instance.UploadMediaFile(name + ".png", MonoSingleton<AccountMgr>.Instance().GetUserProfile().data.userID.ToString(), array, OnUploadMedia);
			}
		}
		else if (memory.memo_id == 0)
		{
			DataSourceFactory.GetDataSource().GetMemoryService().CreateMemory(memory, name, OnCreateMemory);
		}
		else
		{
			DataSourceFactory.GetDataSource().GetMemoryService().UpdateMemory(memory);
		}
	}

	private int GetMemoryType()
	{
		if (SceneManager.GetSceneByName("threeview").isLoaded)
		{
			return 1;
		}
		if (SceneManager.GetSceneByName("tangram").isLoaded)
		{
			return 2;
		}
		return 0;
	}
}
public class MenuButton : MonoBehaviour
{
	[Serializable]
	public class ButtonEvent : UnityEvent
	{
	}

	public float confirmInterval = 0.3f;

	public ButtonEvent onButtonDown;

	public AudioClip buttonSound;

	private float triggerTime;

	private void OnTriggerEnter(Collider other)
	{
		if ((other.transform.name.Contains("Finger") || other.transform.name.Contains("coll") || other.transform.name.Contains("PvrController")) && Time.time - triggerTime > confirmInterval)
		{
			triggerTime = Time.time;
			MonoSingleton<SoundMgr>.Instance().PlaySound(buttonSound, base.transform.position);
			onButtonDown?.Invoke();
		}
	}
}
public class MyPhotoDisplay : PhotoDisplay
{
	public GameObject loadButton;

	public override void Display()
	{
		List<Texture> photos = MonoSingleton<PhotoMgr>.Instance().GetPhotos();
		if (photos.Count == 0)
		{
			hint.text = ISILocalization.GetValueOf(LanCode.CameraHint);
			MonoSingleton<SoundMgr>.Instance().PlaySound(SLocalization.GetAudio(LanCode.CameraIntro), base.transform.position);
		}
		else
		{
			hint.text = "";
		}
		if (photos.Count == 1)
		{
			MonoSingleton<SoundMgr>.Instance().PlaySound(SLocalization.GetAudio(LanCode.PhotoFuncIntro), base.transform.position);
		}
		render.material.SetTexture("_MainTex", GetCurrent(photos));
		UpdateButtonStatus();
	}

	public void Next()
	{
		NextPhoto(MonoSingleton<PhotoMgr>.Instance().GetPhotos());
		UpdateButtonStatus();
	}

	public void Previous()
	{
		PreviousPhoto(MonoSingleton<PhotoMgr>.Instance().GetPhotos());
		UpdateButtonStatus();
	}

	private void UpdateButtonStatus()
	{
		Memory localMemory = Framework.Singleton<MemoryMgr>.Instance.GetLocalMemory(GetCurrent(MonoSingleton<PhotoMgr>.Instance().GetPhotos()).name);
		if (localMemory == null)
		{
			return;
		}
		try
		{
			if ((localMemory.type_id == 1 && localMemory.info.FromJson<List<int>>().ToArray() != null) || (localMemory.type_id == 2 && localMemory.info.FromJson<TangramMgr.TangramInfo>().positions.Length != 0))
			{
				loadButton.SetActive(value: true);
			}
			else
			{
				loadButton.SetActive(value: false);
			}
		}
		catch (Exception)
		{
			loadButton.SetActive(value: false);
		}
	}

	public void Delete()
	{
		List<Texture> photos = MonoSingleton<PhotoMgr>.Instance().GetPhotos();
		Framework.Singleton<MemoryMgr>.Instance.DeleteMemory(GetCurrent(photos));
		DeletePhoto(photos);
		if (photos.Count == 0)
		{
			hint.text = ISILocalization.GetValueOf(LanCode.CameraHint);
		}
	}

	public void Share()
	{
		List<Texture> photos = MonoSingleton<PhotoMgr>.Instance().GetPhotos();
		Framework.Singleton<MemoryMgr>.Instance.ShareMemory(GetCurrent(photos));
		MonoSingleton<SharedPhotoMgr>.Instance().LoadSharedPhotos();
	}

	public void Load()
	{
		List<Texture> photos = MonoSingleton<PhotoMgr>.Instance().GetPhotos();
		Framework.Singleton<MemoryMgr>.Instance.LoadMemory(GetCurrent(photos), 0);
	}

	protected override List<Texture> LoadMorePhoto()
	{
		return MonoSingleton<PhotoMgr>.Instance().LoadNextPage();
	}
}
public class Pad : MonoBehaviour
{
	public Transform[] views;

	private bool opened;

	public static Action<Transform> onViewOn;

	private void Start()
	{
		Close();
	}

	private void Update()
	{
		if (MonoSingleton<InputHandler>.Instance().IsMenuKeyDown() || Input.GetKeyDown(KeyCode.X))
		{
			if (!opened)
			{
				Open();
				opened = true;
			}
		}
		else if (opened)
		{
			Close();
			opened = false;
		}
	}

	public void Open()
	{
		for (int i = 0; i < views.Length; i++)
		{
			if (views[i].name.Contains("Home"))
			{
				views[i].gameObject.SetActive(value: true);
			}
			else
			{
				views[i].gameObject.SetActive(value: false);
			}
		}
	}

	public void Close()
	{
		for (int i = 0; i < views.Length; i++)
		{
			if (views[i].gameObject.activeSelf)
			{
				views[i].gameObject.SetActive(value: false);
			}
		}
	}

	public void TurnOn(Transform view)
	{
		for (int i = 0; i < views.Length; i++)
		{
			if (views[i] == view)
			{
				views[i].gameObject.SetActive(value: true);
			}
			else if (!views[i].name.Equals("HomeButton"))
			{
				views[i].gameObject.SetActive(value: false);
			}
		}
		onViewOn?.Invoke(view);
	}

	public void TurnOff(Transform view)
	{
		view.gameObject.SetActive(value: false);
	}
}
public abstract class PhotoDisplay : MonoBehaviour
{
	public Texture defaultPhoto;

	protected Renderer render;

	protected int index;

	public TMP_Text hint;

	private void Awake()
	{
		render = GetComponent<Renderer>();
	}

	private void Start()
	{
		index = 0;
	}

	public abstract void Display();

	protected Texture GetCurrent(List<Texture> photos)
	{
		if (photos.Count == 0)
		{
			return defaultPhoto;
		}
		return photos[index];
	}

	protected void NextPhoto(List<Texture> photos)
	{
		List<Texture> list = photos;
		index++;
		if (index >= photos.Count)
		{
			list = LoadMorePhoto();
			if (index >= list.Count)
			{
				index = photos.Count - 1;
			}
		}
		render.material.SetTexture("_MainTex", GetCurrent(list));
	}

	protected abstract List<Texture> LoadMorePhoto();

	protected void PreviousPhoto(List<Texture> photos)
	{
		index--;
		if (index < 0)
		{
			index = 0;
		}
		render.material.SetTexture("_MainTex", GetCurrent(photos));
	}

	protected void DeletePhoto(List<Texture> photos)
	{
		index--;
		if (index < 0)
		{
			index = 0;
		}
		render.material.SetTexture("_MainTex", GetCurrent(photos));
	}
}
public class PhotoMgr : MonoSingleton<PhotoMgr>
{
	private TextureLoader loader;

	private int totalNumOfTextures;

	private List<Texture> photos = new List<Texture>();

	private int page;

	private void Start()
	{
		string folder = MonoSingleton<AccountMgr>.Instance().GetUserProfile().index.ToString();
		loader = GetComponent<TextureLoader>();
		loader.Init(folder);
		LoadNextPage();
	}

	public void AddPhoto(Texture2D photo)
	{
		if (photos.Count == 0)
		{
			MonoSingleton<SoundMgr>.Instance().PlaySound(SLocalization.GetAudio(LanCode.PhotoIntro), base.transform.position);
		}
		photos.Add(photo);
	}

	public List<Texture> LoadNextPage()
	{
		List<Texture> texturePage = loader.GetTexturePage(page);
		if (texturePage != null)
		{
			photos.AddRange(texturePage);
			page++;
		}
		return photos;
	}

	public List<Texture> GetPhotos()
	{
		return photos;
	}

	internal void Delete(Texture photo)
	{
		photos.Remove(photo);
		MonoSingleton<TextureUtil>.Instance().DeleteTexture(photo, MonoSingleton<AccountMgr>.Instance().GetUserProfile().index.ToString());
	}
}
public class PrizeDisplay : MonoBehaviour
{
	public TMP_Text text;

	private void Start()
	{
	}

	private void Update()
	{
		text.text = MonoSingleton<MedalMgr>.Instance().Count.ToString();
	}
}
public class SharedPhotoDisplay : PhotoDisplay
{
	public GameObject loadButton;

	public void Next()
	{
		NextPhoto(MonoSingleton<SharedPhotoMgr>.Instance().GetPhotos());
		UpdateButtonStatus();
	}

	protected override List<Texture> LoadMorePhoto()
	{
		return MonoSingleton<SharedPhotoMgr>.Instance().LoadNextPage();
	}

	public void Previous()
	{
		PreviousPhoto(MonoSingleton<SharedPhotoMgr>.Instance().GetPhotos());
		UpdateButtonStatus();
	}

	public override void Display()
	{
		List<Texture> photos = MonoSingleton<SharedPhotoMgr>.Instance().GetPhotos();
		if (photos.Count == 0)
		{
			hint.text = ISILocalization.GetValueOf(LanCode.SharePhotoHint);
		}
		else
		{
			hint.text = "";
		}
		render.material.SetTexture("_MainTex", GetCurrent(photos));
		UpdateButtonStatus();
	}

	public void Load()
	{
		List<Texture> photos = MonoSingleton<SharedPhotoMgr>.Instance().GetPhotos();
		Framework.Singleton<MemoryMgr>.Instance.LoadMemory(GetCurrent(photos), 1);
	}

	private void UpdateButtonStatus()
	{
		Memory sharedMemory = Framework.Singleton<MemoryMgr>.Instance.GetSharedMemory(GetCurrent(MonoSingleton<SharedPhotoMgr>.Instance().GetPhotos()).name);
		if (sharedMemory == null)
		{
			return;
		}
		hint.text = "";
		try
		{
			if ((sharedMemory.type_id == 1 && sharedMemory.info.FromJson<List<int>>().ToArray() != null) || (sharedMemory.type_id == 2 && sharedMemory.info.FromJson<TangramMgr.TangramInfo>().positions.Length != 0))
			{
				loadButton.SetActive(value: true);
			}
			else
			{
				loadButton.SetActive(value: false);
			}
		}
		catch (Exception)
		{
			loadButton.SetActive(value: false);
		}
	}
}
public class SharedPhotoMgr : MonoSingleton<SharedPhotoMgr>
{
	private int totalNumOfTextures;

	private List<Texture> sharedPhotos = new List<Texture>();

	private TextureLoader loader;

	private int page;

	private bool loadFromWeb;

	protected override void Awake()
	{
		base.Awake();
		MediaMgr mediaMgr = Framework.Singleton<MediaMgr>.Instance;
		mediaMgr.onMediaLoaded = (Action<byte[]>)Delegate.Combine(mediaMgr.onMediaLoaded, new Action<byte[]>(OnMediaLoaded));
	}

	private void Start()
	{
		loader = GetComponent<TextureLoader>();
		loader.Init("sharing");
		LoadNextPage();
		GetComponent<SharedPhotoDisplay>().Display();
	}

	public List<Texture> LoadNextPage()
	{
		List<Texture> texturePage = loader.GetTexturePage(page);
		if (texturePage != null)
		{
			sharedPhotos.AddRange(texturePage);
			page++;
		}
		else if (!loadFromWeb)
		{
			LoadSharedPhotos();
			loadFromWeb = true;
		}
		return sharedPhotos;
	}

	private void onLoadCompleted()
	{
		LoadSharedPhotos();
	}

	private void OnMediaLoaded(byte[] data)
	{
		sharedPhotos.Add(MonoSingleton<TextureUtil>.Instance().CreateTextureFromData(data));
	}

	internal List<Texture> GetPhotos()
	{
		return sharedPhotos;
	}

	public void LoadSharedPhotos()
	{
		Framework.Singleton<MemoryMgr>.Instance.GetSharedMemories();
	}

	private void OnDestroy()
	{
		MediaMgr mediaMgr = Framework.Singleton<MediaMgr>.Instance;
		mediaMgr.onMediaLoaded = (Action<byte[]>)Delegate.Remove(mediaMgr.onMediaLoaded, new Action<byte[]>(OnMediaLoaded));
	}
}
public class TextureLoader : MonoBehaviour
{
	private class TexturePage
	{
		public bool loaded;

		public List<string> filenames = new List<string>();

		public List<Texture> textures;
	}

	public int kPageSize = 1;

	private static int kTextureWidth = 960;

	private static int kTextureHeight = 720;

	private List<string> _localTextureFilenames = new List<string>();

	private List<TexturePage> _texturePages = new List<TexturePage>();

	public int TotalNumOfTextures
	{
		get
		{
			return _localTextureFilenames.Count;
		}
		private set
		{
		}
	}

	public void Init(string folder)
	{
		_localTextureFilenames.Clear();
		string path = Application.persistentDataPath + "/" + folder + "/";
		if (Directory.Exists(path))
		{
			foreach (string item in Directory.EnumerateFiles(path))
			{
				if (item.Contains(".png"))
				{
					_localTextureFilenames.Add(item);
				}
			}
		}
		int count = _localTextureFilenames.Count;
		if (count <= 0)
		{
			return;
		}
		int capacity = (count + kPageSize - 1) / kPageSize;
		_texturePages = new List<TexturePage>(capacity);
		for (int i = 0; i < count; i++)
		{
			if (_texturePages.Count <= i / kPageSize)
			{
				_texturePages.Add(new TexturePage());
			}
			_texturePages[i / kPageSize].filenames.Add(_localTextureFilenames[i]);
		}
	}

	public List<Texture> GetTexturePage(int index)
	{
		if (index < 0 || index >= _texturePages.Count)
		{
			return null;
		}
		TexturePage texturePage = _texturePages[index];
		if (!texturePage.loaded)
		{
			texturePage.textures = new List<Texture>();
			foreach (string filename in texturePage.filenames)
			{
				LoadTextureFromFile(filename, texturePage.textures);
			}
			texturePage.loaded = true;
		}
		return texturePage.textures;
	}

	private void LoadTextureFromFile(string fileName, List<Texture> buffer)
	{
		byte[] array = File.ReadAllBytes(fileName);
		if (array != null)
		{
			Texture2D texture2D = new Texture2D(kTextureWidth, kTextureHeight, TextureFormat.ARGB32, mipChain: false);
			texture2D.LoadImage(array);
			texture2D.Apply();
			string text = fileName.Substring(fileName.LastIndexOf("/") + 1);
			text = text.Remove(text.LastIndexOf("."));
			texture2D.name = text;
			buffer.Add(texture2D);
		}
	}
}
public class TextureUtil : MonoSingleton<TextureUtil>
{
	private string path;

	private int width = 960;

	private int height = 720;

	protected override void Awake()
	{
		base.Awake();
		path = Application.persistentDataPath;
	}

	public void SaveTextureToFile(byte[] data, string folderName, string fileName)
	{
		if (FileUtil.CreateFolder(path + "/" + folderName + "/"))
		{
			File.WriteAllBytes(path + "/" + folderName + "/" + fileName + ".png", data);
		}
	}

	internal void DeleteTexture(Texture texture, string folder)
	{
		FileUtil.DeleteFile(path + "/" + folder + "/" + texture.name + ".png");
	}

	internal Texture2D CreateImageFromScreen(int width, int height)
	{
		this.width = width;
		this.height = height;
		Texture2D texture2D = new Texture2D(width, height);
		texture2D.ReadPixels(new Rect(0f, 0f, width, height), 0, 0);
		texture2D.Apply();
		return texture2D;
	}

	internal Texture2D CreateTextureFromData(byte[] data)
	{
		Texture2D texture2D = new Texture2D(width, height, TextureFormat.ARGB32, mipChain: false);
		texture2D.LoadImage(data);
		texture2D.Apply();
		return texture2D;
	}
}
public class AirplaneController : ToyController
{
	[Serializable]
	public class FlyEvent : UnityEvent
	{
	}

	public AudioClip triggerSound;

	public float maxAngle = 45f;

	public float maxVelocity = 2f;

	public float Force = 0.4f;

	public HintRender tips;

	private Vector3 m_EulerAngleVelocity;

	private Rigidbody m_Rigidbody;

	private float speed = 100f;

	private float velocity;

	private float lastFlyTime;

	public FlyEvent onPlaneFlying;

	private bool hasBattery;

	private bool active;

	private Transform placeholder;

	private void Awake()
	{
		placeholder = base.transform.Find("Airplane_highlight");
		placeholder.gameObject.SetActive(value: true);
	}

	private void Start()
	{
		m_Rigidbody = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		if (!hasBattery)
		{
			return;
		}
		if (!active)
		{
			m_Rigidbody.velocity = Vector3.zero;
			m_Rigidbody.angularVelocity = Vector3.zero;
			return;
		}
		if (InteractedNotMe(InputHandler.ControllerType.Left) || InteractedNotMe(InputHandler.ControllerType.Right))
		{
			active = false;
		}
		if (m_Rigidbody.isKinematic)
		{
			return;
		}
		if (m_Rigidbody.useGravity)
		{
			m_Rigidbody.useGravity = false;
			m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationZ;
		}
		Vector2 thumbstickValue = MonoSingleton<InputHandler>.Instance().GetThumbstickValue(InputHandler.ControllerType.Left);
		if (thumbstickValue == Vector2.zero)
		{
			thumbstickValue = MonoSingleton<InputHandler>.Instance().GetThumbstickValue(InputHandler.ControllerType.Right);
		}
		int num;
		if (!(MonoSingleton<InputHandler>.Instance().GetIndexTriggerValue(InputHandler.ControllerType.Right) > 0f))
		{
			num = ((MonoSingleton<InputHandler>.Instance().GetIndexTriggerValue(InputHandler.ControllerType.Left) > 0f) ? 1 : 0);
			if (num == 0)
			{
				MonoSingleton<SoundMgr>.Instance().StopSound(triggerSound);
				goto IL_0142;
			}
		}
		else
		{
			num = 1;
		}
		MonoSingleton<SoundMgr>.Instance().PlaySound(triggerSound, base.transform.position, 0f, new SoundMgr.PlayParameters
		{
			Pitch = 1f,
			SourceID = 7,
			Volume = 0.1f,
			Loop = false
		}, triggerSound.length - 0.2f);
		goto IL_0142;
		IL_0142:
		float force = ((num != 0) ? Force : (0f - Force));
		velocity = CaculateVelocity(force);
		m_EulerAngleVelocity.Set(thumbstickValue.y, thumbstickValue.x, 0f);
		Quaternion quaternion = CaculateDeltaRotation();
		base.transform.position = base.transform.position + velocity * base.transform.TransformDirection(Vector3.forward).normalized * Time.fixedDeltaTime;
		base.transform.rotation = base.transform.rotation * quaternion;
		if (velocity > 0f)
		{
			tips.TurnOff();
			lastFlyTime = Time.time;
			onPlaneFlying?.Invoke();
			return;
		}
		if (Time.time - lastFlyTime > 60f && lastFlyTime > 0f)
		{
			GetComponent<DropHandler>().Reset();
			lastFlyTime = 0f;
			active = false;
		}
		m_Rigidbody.velocity = Vector3.zero;
		m_Rigidbody.angularVelocity = Vector3.zero;
	}

	private bool InteractedNotMe(InputHandler.ControllerType hand)
	{
		if (MonoSingleton<InputHandler>.Instance().GetInteractor(hand).interactedObject != null)
		{
			return !MonoSingleton<InputHandler>.Instance().GetInteractor(hand).interactedObject.name.Equals(base.name);
		}
		return false;
	}

	private Quaternion CaculateDeltaRotation()
	{
		return Quaternion.Euler(speed * m_EulerAngleVelocity * Time.fixedDeltaTime);
	}

	private float CaculateVelocity(float force)
	{
		velocity += force * Time.fixedDeltaTime;
		velocity = Mathf.Clamp(velocity, 0f, maxVelocity);
		return velocity;
	}

	public float GetVelocity()
	{
		return velocity;
	}

	public void SetBattery()
	{
		hasBattery = true;
		placeholder.gameObject.SetActive(value: false);
		tips.onFirst = false;
		tips.TurnOff();
	}

	public void SetActive(bool isActive)
	{
		active = isActive;
	}

	public override void SetEnabled(bool enabled)
	{
		base.SetEnabled(enabled);
		if (enabled)
		{
			SetBattery();
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		m_Rigidbody.velocity = Vector3.zero;
		m_Rigidbody.angularVelocity = Vector3.zero;
		velocity = 0f;
	}
}
public class Airscrew : MonoBehaviour
{
	private AirplaneController controller;

	private void Start()
	{
		controller = GetComponentInParent<AirplaneController>();
	}

	private void FixedUpdate()
	{
		if (controller.GetVelocity() > 0f)
		{
			base.transform.Rotate(Vector3.forward, 2000f * Time.deltaTime);
		}
	}
}
public class BalanceController : MonoBehaviour
{
	private Rigidbody m_rigidbody;

	private Joint joint;

	private Vector3 originalPos;

	public Action<Transform> onEnter;

	public Action<Transform> onExit;

	public Action<Collider> onCollisionEnter;

	public Action<Collider> onCollisionExit;

	private void Start()
	{
		ContentLoader.OnAnimationCompleted = (Action)Delegate.Combine(ContentLoader.OnAnimationCompleted, new Action(SetPhysics));
		ContentLoader.onContentChanged = (Action)Delegate.Combine(ContentLoader.onContentChanged, new Action(SetKinematic));
		m_rigidbody = GetComponent<Rigidbody>();
		joint = GetComponent<Joint>();
		originalPos = base.transform.position;
	}

	private void SetKinematic()
	{
		joint.autoConfigureConnectedAnchor = false;
		m_rigidbody.isKinematic = true;
	}

	private void OnDestroy()
	{
		ContentLoader.OnAnimationCompleted = (Action)Delegate.Remove(ContentLoader.OnAnimationCompleted, new Action(SetPhysics));
		ContentLoader.onContentChanged = (Action)Delegate.Remove(ContentLoader.onContentChanged, new Action(SetKinematic));
	}

	private void SetPhysics()
	{
		joint.autoConfigureConnectedAnchor = true;
		m_rigidbody.isKinematic = false;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if ((collision.gameObject.tag.Equals("Crystal") || collision.gameObject.tag.Equals("Weight") || collision.gameObject.layer == LayerMask.NameToLayer("InteractionObject")) && !(collision.GetContact(0).normal.y > 0f))
		{
			UnityEngine.Debug.Log("OnCollisionEnter:" + collision.collider.name);
			onEnter?.Invoke(collision.transform);
			onCollisionEnter?.Invoke(collision.collider);
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		UnityEngine.Debug.Log(collision.gameObject.name);
		onExit?.Invoke(collision.transform);
		onCollisionExit?.Invoke(collision.collider);
	}
}
public class Battery : Equipment
{
	protected override bool IsTriggered(Collider other)
	{
		return other.transform.name.Contains("Battery");
	}

	protected override void Equip(Collider other)
	{
		GrabInteractable component = other.transform.GetComponent<GrabInteractable>();
		component.interactedBy.Offhand(component);
		ToyController.RemoveToy(other.name);
		UnityEngine.Object.Destroy(other.gameObject);
	}
}
public class BookHandler : MonoBehaviour
{
	public float interval = 0.1f;

	public float velocity = 1f;

	private Renderer render;

	private Vector2 offset;

	private int currentPage;

	private float triggeredTime;

	public Texture[] textures;

	private void Start()
	{
		triggeredTime = Time.time;
		render = GetComponent<Renderer>();
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!(Time.time - triggeredTime < interval))
		{
			triggeredTime = Time.time;
			UnityEngine.Debug.Log("RightController:" + MonoSingleton<InputHandler>.Instance().GetControllerVelocity(InputHandler.ControllerType.Right));
			UnityEngine.Debug.Log("LeftController:" + MonoSingleton<InputHandler>.Instance().GetControllerVelocity(InputHandler.ControllerType.Left));
			if (MonoSingleton<InputHandler>.Instance().GetControllerVelocity(InputHandler.ControllerType.Left).x > velocity || MonoSingleton<InputHandler>.Instance().GetControllerVelocity(InputHandler.ControllerType.Right).x > velocity)
			{
				TurningPage(-1);
			}
			if (MonoSingleton<InputHandler>.Instance().GetControllerVelocity(InputHandler.ControllerType.Left).x < 0f - velocity || MonoSingleton<InputHandler>.Instance().GetControllerVelocity(InputHandler.ControllerType.Right).x < 0f - velocity)
			{
				TurningPage(1);
			}
		}
	}

	private void TurningPage(short index)
	{
		if (currentPage + index >= 0 && currentPage + index < textures.Length)
		{
			currentPage += index;
			render.material.SetTexture("_MainTex", textures[currentPage]);
		}
	}
}
public class Bubbles : MonoBehaviour
{
	public AudioClip bubbles;

	private ParticleSystem ps;

	private void Start()
	{
		ps = GetComponent<ParticleSystem>();
	}

	public void Play()
	{
		MonoSingleton<SoundMgr>.Instance().PlaySound(bubbles, base.transform.position);
		ps?.Play();
	}
}
public class Cactus : MonoBehaviour
{
	public AudioClip sound;

	public void Play()
	{
		MonoSingleton<SoundMgr>.Instance().PlaySound(sound, base.transform.position, 0f, new SoundMgr.PlayParameters
		{
			Pitch = 1f,
			SourceID = GetInstanceID(),
			Volume = 1f,
			Loop = false
		}, 2f);
	}
}
public class CarController : ToyController
{
	public float speed = 1f;

	public Vector3 direction;

	private Rigidbody rb;

	private Vector3 velocity;

	private void Start()
	{
		DropHandler component = GetComponent<DropHandler>();
		component.onBirth = (Action)Delegate.Combine(component.onBirth, new Action(Reset));
		rb = GetComponent<Rigidbody>();
	}

	private void OnDestroy()
	{
		DropHandler component = GetComponent<DropHandler>();
		component.onBirth = (Action)Delegate.Remove(component.onBirth, new Action(Reset));
	}

	private void Reset()
	{
		velocity = Vector3.zero;
	}

	private void FixedUpdate()
	{
		if (!rb.isKinematic && velocity.magnitude > 0.1f)
		{
			base.transform.position += velocity * Time.fixedDeltaTime;
		}
	}

	public void SetForce(Interactor interactor)
	{
		Vector3 controllerVelocity = MonoSingleton<InputHandler>.Instance().GetControllerVelocity(interactor.m_controller);
		controllerVelocity.y = 0f;
		velocity = Vector3.Dot(base.transform.TransformDirection(direction).normalized, speed * controllerVelocity) * base.transform.TransformDirection(direction).normalized;
	}
}
public class ChinController : MonoBehaviour
{
	public AudioClip laughSound;

	public void Close()
	{
		if (base.transform.localEulerAngles.x <= 61f)
		{
			StopAllCoroutines();
			base.transform.DOLocalRotate(90f * Vector3.right, 0.1f);
			PlaySound();
		}
	}

	private void PlaySound()
	{
		MonoSingleton<SoundMgr>.Instance().PlaySound(laughSound);
		StartCoroutine("Open", laughSound.length + 0.1f);
	}

	private IEnumerator Open(float seconds)
	{
		yield return new WaitForSeconds(seconds);
		base.transform.DOLocalRotate(60f * Vector3.right, 0.5f);
	}
}
public class CreatorMgr : MonoBehaviour
{
	public GameObject balance;

	private RecipeMgr recipeMgr;

	private AudioClip introClip;

	private SpriteRenderer hintSprite;

	private void Awake()
	{
		MonoSingleton<Instructions>.Instance().Init(LanCode.CrystalIntro, null, "");
		recipeMgr = GetComponent<RecipeMgr>();
		hintSprite = MonoSingleton<Instructions>.Instance().GetSpriteRenderer();
		introClip = SLocalization.GetAudio(LanCode.CreatorIntro);
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.CreatorIntro);
	}

	private void Start()
	{
		Invoke("DisplayHint", introClip.length + 2f);
	}

	private void OnEnable()
	{
		RecipeMgr obj = recipeMgr;
		obj.onRecipeChanged = (Action)Delegate.Combine(obj.onRecipeChanged, new Action(HandleRecipeChanged));
	}

	private void OnDisable()
	{
		RecipeMgr obj = recipeMgr;
		obj.onRecipeChanged = (Action)Delegate.Remove(obj.onRecipeChanged, new Action(HandleRecipeChanged));
	}

	private void HandleRecipeChanged()
	{
		hintSprite.sprite = ISILocalization.GetSprite(recipeMgr.GetCurrentRecipe()?.sprite);
	}

	private void DisplayHint()
	{
		MonoSingleton<Instructions>.Instance().SetText(LanCode.CreatorIntro);
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.CreatorHint);
		HandleRecipeChanged();
	}
}
public class CrystalContainer : Container
{
	protected override bool IsTriggered(Collider other)
	{
		return other.gameObject.tag.Equals("Crystal");
	}
}
public class Dispear : MonoBehaviour
{
	private static ParticleSystem disappear;

	private static AudioClip disappearSound;

	private void Start()
	{
		if (disappear == null)
		{
			GameObject gameObject = GameObject.Find("ZhaLie");
			if (gameObject != null)
			{
				disappear = gameObject.GetComponent<ParticleSystem>();
			}
		}
		if (disappearSound == null)
		{
			disappearSound = Resources.Load<AudioClip>("disappear");
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (!collision.transform.name.Contains("Gun"))
		{
			Invoke("Reset", 0.5f);
		}
	}

	public void Reset()
	{
		if (disappear != null)
		{
			disappear.transform.position = base.transform.position;
			disappear.Play();
			MonoSingleton<SoundMgr>.Instance().PlaySound(disappearSound, base.transform.position);
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
[RequireComponent(typeof(Rigidbody))]
public class Eatable : MonoBehaviour
{
	public Transform leftPart;

	public AudioClip eatSound;

	public Action triggerEnter;

	private static ParticleSystem juicyEffect;

	private string COLLIDER_NAME = "Mouth";

	private float DISAPEAR_TIME = 2f;

	private Rigidbody mRigidbody;

	private void Start()
	{
		mRigidbody = GetComponent<Rigidbody>();
		if (mRigidbody == null)
		{
			mRigidbody = base.gameObject.AddComponent<Rigidbody>();
		}
		if (GetComponent<CollisionScript>() == null)
		{
			base.gameObject.AddComponent<CollisionScript>();
		}
		if (juicyEffect == null)
		{
			juicyEffect = GameObject.Find("Juicy")?.GetComponent<ParticleSystem>();
		}
	}

	private Transform Initialize(Transform part)
	{
		Transform transform = UnityEngine.Object.Instantiate(part, base.transform.position, Quaternion.identity, base.transform.parent);
		transform.localScale = base.transform.localScale;
		Vector3 position = transform.position;
		position.z += base.transform.lossyScale.z / 2f;
		transform.position = position;
		Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
		if (rigidbody == null)
		{
			rigidbody = transform.gameObject.AddComponent<Rigidbody>();
		}
		rigidbody.mass = mRigidbody.mass / 2f;
		if (transform.GetComponent<Collider>() == null)
		{
			transform.gameObject.AddComponent<BoxCollider>();
		}
		if (transform.GetComponent<Interactable>() == null)
		{
			transform.gameObject.AddComponent<OffsetGrabbable>();
		}
		if (transform.GetComponent<DropHandler>() == null)
		{
			transform.gameObject.AddComponent<DropHandler>();
		}
		return transform;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name.Equals(COLLIDER_NAME))
		{
			PlayEatAnimation();
			if (triggerEnter != null)
			{
				triggerEnter();
			}
		}
	}

	public void PlayEatAnimation()
	{
		Interactable component = base.transform.GetComponent<Interactable>();
		Interactor interactedBy = component.interactedBy;
		if (leftPart != null)
		{
			interactedBy?.Offhand(component, rendered: false);
			Interactable interactable = (interactedBy.interactedObject = Initialize(leftPart).GetComponent<Interactable>());
			interactable.GrabBegin(interactedBy);
			interactable.OnSelectEnter(interactedBy);
		}
		else
		{
			interactedBy?.Offhand(component);
		}
		MonoSingleton<SoundMgr>.Instance().PlaySound(eatSound, base.transform.position, 0f, new SoundMgr.PlayParameters
		{
			Pitch = 1f,
			SourceID = 1,
			Volume = 1f,
			Loop = false
		}, 0.1f);
		juicyEffect.transform.position = base.transform.position;
		juicyEffect.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
public abstract class Equipment : MonoBehaviour
{
	[Serializable]
	public class EquipEvent : UnityEvent
	{
	}

	public EquipEvent OnEquipped;

	public AudioClip success;

	private Outline outline;

	private void Start()
	{
		outline = GetComponent<Outline>();
		outline.highlight = true;
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		if (IsTriggered(other))
		{
			Equip(other);
			MonoSingleton<SoundMgr>.Instance().PlaySound(success, base.transform.position);
			outline.highlight = false;
			OnEquipped.Invoke();
		}
	}

	protected abstract bool IsTriggered(Collider other);

	protected abstract void Equip(Collider other);
}
public class Floating : MonoBehaviour
{
	public float range = 0.01f;

	public float speed = 1f;

	private static float t;

	private Vector3 pos;

	private float minimum;

	private float maximum;

	private void Start()
	{
		pos = base.transform.position;
		minimum = pos.y - range;
		maximum = pos.y + range;
	}

	private void Update()
	{
		float newY = Mathf.Lerp(minimum, maximum, t);
		pos.Set(pos.x, newY, pos.z);
		base.transform.position = pos;
		t += speed * Time.deltaTime;
		if (t > 1f)
		{
			float num = maximum;
			maximum = minimum;
			minimum = num;
			t = 0f;
		}
	}
}
public class FruitCreator : MonoBehaviour
{
	public static Action<int, int> onUpgrade;

	public static Action<int, int> onAnswerRight;

	public static Action<int, int> onAnswerWrong;

	public RecipeMgr recipeMgr;

	public AudioClip creatorSound;

	public AudioClip bonusSound;

	public Transform spawnPoint;

	public ParticleSystem builderPS;

	public UnityEvent onCreateStarted;

	public UnityEvent onCreateCompleted;

	private Container container;

	private List<Transform> objects = new List<Transform>();

	private bool inProgress;

	private float lastTime;

	private int currentGrade;

	private int currentLevel;

	private void Start()
	{
		RecipeMgr obj = recipeMgr;
		obj.onRecipeChanged = (Action)Delegate.Combine(obj.onRecipeChanged, new Action(HandleRecipeChanged));
		container = GetComponent<Container>();
		lastTime = Time.time;
		currentGrade = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().substitutionGrade;
		currentLevel = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().substitutionLevel;
		recipeMgr.NextRecipe(currentGrade, currentLevel);
	}

	private void OnDestroy()
	{
		RecipeMgr obj = recipeMgr;
		obj.onRecipeChanged = (Action)Delegate.Remove(obj.onRecipeChanged, new Action(HandleRecipeChanged));
	}

	private void HandleRecipeChanged()
	{
		inProgress = false;
	}

	private void Update()
	{
		if (!inProgress && container.GetObjects().Count > 0)
		{
			inProgress = true;
		}
	}

	public void Create()
	{
		if (!(Time.time - lastTime < creatorSound.length) && container.GetObjects().Count != 0)
		{
			lastTime = Time.time;
			onCreateStarted?.Invoke();
			MonoSingleton<SoundMgr>.Instance().PlaySound(creatorSound);
			builderPS?.Play();
			Invoke("Creating", creatorSound.length);
		}
	}

	private void Creating()
	{
		Recipe currentRecipe = recipeMgr.GetCurrentRecipe();
		if (CheckCondition(currentRecipe))
		{
			currentLevel++;
			CreateObject(currentRecipe);
			if (currentLevel == recipeMgr.levelSize)
			{
				currentGrade++;
				currentLevel = 0;
				if (!MonoSingleton<AccountMgr>.Instance().GetUserProfileData().creatorCompleted)
				{
					onUpgrade?.Invoke(currentRecipe.grade, 0);
				}
			}
			if (currentGrade == recipeMgr.gradeSize)
			{
				currentGrade = 0;
				MonoSingleton<AccountMgr>.Instance().GetUserProfileData().creatorCompleted = true;
			}
			MonoSingleton<AccountMgr>.Instance().GetUserProfileData().substitutionGrade = currentGrade;
			MonoSingleton<AccountMgr>.Instance().GetUserProfileData().substitutionLevel = currentLevel;
			MonoSingleton<AccountMgr>.Instance().UpdatePerformance();
			onAnswerRight?.Invoke(currentGrade, currentLevel);
		}
		else
		{
			onAnswerWrong?.Invoke(currentGrade, currentLevel);
		}
		Framework.Singleton<ObjectsUtil>.Instance.Destroy(container.GetObjects(), 0f);
		container.Restore();
		builderPS?.Stop();
		inProgress = false;
		onCreateCompleted?.Invoke();
	}

	private bool CheckCondition(Recipe recipe)
	{
		if (recipe == null)
		{
			return false;
		}
		RecipeItem[] items = recipe.items;
		for (int i = 0; i < items.Length; i++)
		{
			if (!CheckItem(items[i]))
			{
				return false;
			}
		}
		if (!CheckOther(items))
		{
			return false;
		}
		return true;
	}

	private bool CheckOther(RecipeItem[] items)
	{
		foreach (Transform @object in container.GetObjects())
		{
			if (!RecipeContains(@object.name, items))
			{
				return false;
			}
		}
		return true;
	}

	private bool RecipeContains(string name, RecipeItem[] items)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (name.Contains(items[i].objName))
			{
				return true;
			}
		}
		return false;
	}

	private bool CheckItem(RecipeItem recipeItem)
	{
		Unit unit = recipeItem.unit;
		if (unit.Equals(Unit.NUM))
		{
			return CheckNum(recipeItem);
		}
		if (unit.Equals(Unit.WEIGHT))
		{
			return CheckWeight(recipeItem);
		}
		return false;
	}

	private bool CheckWeight(RecipeItem recipeItem)
	{
		List<Transform> list = GetObjects(recipeItem.objName);
		float num = 0f;
		foreach (Transform item in list)
		{
			num += item.GetComponent<Rigidbody>().mass;
		}
		if ((double)Mathf.Abs(num - recipeItem.amount) < 0.0001)
		{
			return true;
		}
		return false;
	}

	private bool CheckNum(RecipeItem recipeItem)
	{
		if ((float)GetObjects(recipeItem.objName).Count == recipeItem.amount)
		{
			return true;
		}
		return false;
	}

	private List<Transform> GetObjects(string objName)
	{
		objects.Clear();
		foreach (Transform @object in container.GetObjects())
		{
			if (@object.name.Contains(objName))
			{
				objects.Add(@object);
			}
		}
		return objects;
	}

	private void CreateObject(Recipe recipe)
	{
		Transform product = recipe.product;
		if (!(product == null))
		{
			for (int i = 0; i < recipe.productAmount; i++)
			{
				UnityEngine.Object.Instantiate(product, spawnPoint.position, product.rotation, MonoSingleton<SpawnPoint>.Instance().GetSpawnPoint()).name += Guid.NewGuid().ToString();
			}
			MonoSingleton<SoundMgr>.Instance().PlaySound(bonusSound, base.transform.position);
		}
	}
}
public class Hologram : MonoBehaviour
{
	public GameObject hologram;

	private bool state;

	public void Switch()
	{
		state = !state;
		hologram.SetActive(state);
	}
}
public class InteractableButton : MonoBehaviour
{
	private bool pressed;

	public AudioClip pressedSound;

	public UnityEvent onButtonPressed;

	public UnityEvent onButtonReleased;

	private float lastTime;

	private void OnTriggerEnter(Collider other)
	{
		if (!(Time.time - lastTime < 0.3f))
		{
			lastTime = Time.time;
			MonoSingleton<SoundMgr>.Instance().PlaySound(pressedSound, base.transform.position);
			if (pressed)
			{
				base.transform.DOLocalMoveX(-0.08f, 0.3f);
				onButtonReleased?.Invoke();
				pressed = false;
			}
			else
			{
				base.transform.DOLocalMoveX(-0.04f, 0.3f);
				onButtonPressed?.Invoke();
				pressed = true;
			}
		}
	}
}
public class MagicCreator : MonoBehaviour
{
	public static Action<int, int> onUpgrade;

	public static Action<int, int> onAnswerRight;

	public static Action<int, int> onAnswerWrong;

	public RecipeMgr recipeMgr;

	public TMP_Text hint;

	public AudioClip creatorSound;

	public AudioClip inprogressVoice;

	public AudioClip bonusSound;

	public AudioClip failedVoice;

	public AudioClip successVoice;

	public DynamicEffect effect;

	public ParticleSystem builderPS;

	private Container container;

	private List<Transform> objects = new List<Transform>();

	private bool inProgress;

	private float lastTime;

	private int currentGrade;

	private int currentLevel;

	private bool isChinese;

	private void Start()
	{
		isChinese = ISILocalization.CurrentLanguage.Equals(Language.Chinese);
		RecipeMgr obj = recipeMgr;
		obj.onRecipeChanged = (Action)Delegate.Combine(obj.onRecipeChanged, new Action(HandleRecipeChanged));
		container = GetComponent<Container>();
		hint.text = ISILocalization.GetValueOf(LanCode.Create) + GetProductName();
		lastTime = Time.time;
		currentGrade = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().creatorGrade;
		currentLevel = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().creatorLevel;
		recipeMgr.NextRecipe(currentGrade, currentLevel);
	}

	private void OnDestroy()
	{
		RecipeMgr obj = recipeMgr;
		obj.onRecipeChanged = (Action)Delegate.Remove(obj.onRecipeChanged, new Action(HandleRecipeChanged));
	}

	private string GetProductName()
	{
		if (isChinese)
		{
			return recipeMgr.GetCurrentRecipe()?.nameText;
		}
		return recipeMgr.GetCurrentRecipe()?.productName;
	}

	private void HandleRecipeChanged()
	{
		hint.text = ISILocalization.GetValueOf(LanCode.Create) + GetProductName();
		inProgress = false;
	}

	private void Update()
	{
		if (!inProgress && container.GetObjects().Count > 0)
		{
			hint.text = ISILocalization.GetValueOf(LanCode.PrepareMaterials);
			MonoSingleton<VoiceMgr>.Instance().Play(LanCode.CreateInprogress);
			inProgress = true;
		}
	}

	public void Create()
	{
		if (!(Time.time - lastTime < creatorSound.length))
		{
			lastTime = Time.time;
			MonoSingleton<SoundMgr>.Instance().PlaySound(creatorSound);
			effect.Enable(on: true);
			builderPS?.Play();
			Invoke("Creating", creatorSound.length);
		}
	}

	private void Creating()
	{
		Recipe currentRecipe = recipeMgr.GetCurrentRecipe();
		if (CheckCondition(currentRecipe))
		{
			currentLevel++;
			CreateObject(currentRecipe);
			if (currentLevel == recipeMgr.levelSize)
			{
				currentGrade++;
				currentLevel = 0;
				if (!MonoSingleton<AccountMgr>.Instance().GetUserProfileData().creatorCompleted)
				{
					onUpgrade?.Invoke(currentRecipe.grade, 0);
				}
			}
			if (currentGrade == recipeMgr.gradeSize)
			{
				currentGrade = 0;
				MonoSingleton<AccountMgr>.Instance().GetUserProfileData().creatorCompleted = true;
			}
			MonoSingleton<AccountMgr>.Instance().GetUserProfileData().creatorGrade = currentGrade;
			MonoSingleton<AccountMgr>.Instance().GetUserProfileData().creatorLevel = currentLevel;
			MonoSingleton<AccountMgr>.Instance().UpdatePerformance();
			onAnswerRight?.Invoke(currentGrade, currentLevel);
		}
		else
		{
			onAnswerWrong?.Invoke(currentGrade, currentLevel);
		}
		Framework.Singleton<ObjectsUtil>.Instance.Destroy(container.GetObjects(), 0f);
		container.Restore();
		effect.Enable(on: false);
		builderPS?.Stop();
		inProgress = false;
	}

	private bool CheckCondition(Recipe recipe)
	{
		if (recipe == null)
		{
			return false;
		}
		RecipeItem[] items = recipe.items;
		for (int i = 0; i < items.Length; i++)
		{
			if (!CheckItem(items[i]))
			{
				return false;
			}
		}
		if (!CheckOther(items))
		{
			return false;
		}
		return true;
	}

	private bool CheckOther(RecipeItem[] items)
	{
		foreach (Transform @object in container.GetObjects())
		{
			if (!RecipeContains(@object.name, items))
			{
				hint.text = ISILocalization.GetValueOf(LanCode.UnneededMaterial);
				MonoSingleton<VoiceMgr>.Instance().Play(LanCode.CreateFailed);
				return false;
			}
		}
		return true;
	}

	private bool RecipeContains(string name, RecipeItem[] items)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (name.Contains(items[i].objName))
			{
				return true;
			}
		}
		return false;
	}

	private bool CheckItem(RecipeItem recipeItem)
	{
		Unit unit = recipeItem.unit;
		if (unit.Equals(Unit.NUM))
		{
			return CheckNum(recipeItem);
		}
		if (unit.Equals(Unit.WEIGHT))
		{
			return CheckWeight(recipeItem);
		}
		return false;
	}

	private bool CheckWeight(RecipeItem recipeItem)
	{
		List<Transform> list = GetObjects(recipeItem.objName);
		float num = 0f;
		foreach (Transform item in list)
		{
			num += item.GetComponent<Rigidbody>().mass;
		}
		if ((double)Mathf.Abs(num - recipeItem.amount) < 0.0001)
		{
			return true;
		}
		if (num < recipeItem.amount)
		{
			if (isChinese)
			{
				hint.text = "制作失败:" + recipeItem.nameText + "重量不足。";
			}
			else
			{
				hint.text = ISILocalization.GetValueOf(LanCode.MaterialNotEnough);
			}
		}
		if (num > recipeItem.amount)
		{
			if (isChinese)
			{
				hint.text = "制作失败:" + recipeItem.nameText + "重量超过。";
			}
			else
			{
				hint.text = ISILocalization.GetValueOf(LanCode.MaterialTooMuch);
			}
		}
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.CreateFailed);
		return false;
	}

	private bool CheckNum(RecipeItem recipeItem)
	{
		List<Transform> list = GetObjects(recipeItem.objName);
		if ((float)list.Count == recipeItem.amount)
		{
			return true;
		}
		if ((float)list.Count < recipeItem.amount)
		{
			if (isChinese)
			{
				hint.text = "制作失败:" + recipeItem.nameText + "数量不足。";
			}
			else
			{
				hint.text = ISILocalization.GetValueOf(LanCode.MaterialNotEnough);
			}
		}
		if ((float)list.Count > recipeItem.amount)
		{
			if (isChinese)
			{
				hint.text = "制作失败:" + recipeItem.nameText + "数量过多。";
			}
			else
			{
				hint.text = ISILocalization.GetValueOf(LanCode.MaterialTooMuch);
			}
		}
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.CreateFailed);
		return false;
	}

	private List<Transform> GetObjects(string objName)
	{
		objects.Clear();
		foreach (Transform @object in container.GetObjects())
		{
			if (@object.name.Contains(objName))
			{
				objects.Add(@object);
			}
		}
		return objects;
	}

	private void CreateObject(Recipe recipe)
	{
		Transform product = recipe.product;
		if (product == null)
		{
			return;
		}
		for (int i = 0; i < recipe.productAmount; i++)
		{
			Transform transform = UnityEngine.Object.Instantiate(product, base.transform.position, Quaternion.identity, MonoSingleton<SpawnPoint>.Instance().GetSpawnPoint());
			transform.name += Guid.NewGuid().ToString();
			if (!MonoSingleton<AccountMgr>.Instance().GetUserProfileData().Contains(recipe.productName))
			{
				MonoSingleton<AccountMgr>.Instance().GetUserProfileData().toys.Add(new Toy(transform.GetInstanceID(), transform.name, recipe.productName, transform.position, transform.rotation.eulerAngles, enabled: false));
				MonoSingleton<AccountMgr>.Instance().UpdateInventory();
			}
		}
		hint.text = ISILocalization.GetValueOf(LanCode.CreateSuccessfully) + GetProductName();
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.CreateSuccess);
		MonoSingleton<SoundMgr>.Instance().PlaySound(bonusSound, base.transform.position);
	}
}
public class MoneySpray : MonoBehaviour
{
	public Transform Money;

	public Transform startPoint;

	public AudioSource sound;

	private ParticleSystem ps;

	private void Start()
	{
		ps = GetComponent<ParticleSystem>();
	}

	public void Play()
	{
		if (!sound.isPlaying)
		{
			sound.Play();
		}
		SpawnMoney();
	}

	private void SpawnMoney()
	{
		Rigidbody component = UnityEngine.Object.Instantiate(Money, startPoint.position, startPoint.rotation, MonoSingleton<SpawnPoint>.Instance().GetSpawnPoint()).GetComponent<Rigidbody>();
		component.velocity = UnityEngine.Random.Range(50, 60) * base.transform.TransformDirection(Vector3.forward);
		component.angularVelocity = UnityEngine.Random.Range(5, 10) * base.transform.TransformDirection(Vector3.forward);
	}
}
public class MusicBoxController : ToyController
{
	[Serializable]
	public class WindUpEvent : UnityEvent
	{
	}

	public List<AudioClip> audioClips;

	public AudioClip dialSound;

	private static AudioSource bgm;

	public ParticleSystem snowFX;

	public HintRender tips;

	public WindUpEvent onWindup;

	private bool isWinded;

	private Transform placeholder;

	private Transform winding;

	private float remainingTime;

	private Rotating[] rotatings;

	private AudioSource music;

	private void Awake()
	{
		placeholder = base.transform.Find("MusicBox_3");
		winding = base.transform.Find("Winding");
		winding.gameObject.SetActive(value: false);
	}

	private void Start()
	{
		rotatings = GetComponentsInChildren<Rotating>();
		music = MonoSingleton<SoundMgr>.Instance().GetNewSource();
		music.clip = audioClips[0];
		music.loop = true;
		music.volume = 0.3f;
		if (bgm == null)
		{
			bgm = GameObject.Find("LevelMusic").GetComponent<AudioSource>();
		}
	}

	private void Update()
	{
		if (winding.gameObject.activeSelf)
		{
			Quaternion localRotation = winding.localRotation;
			localRotation.x = 0f;
			localRotation.z = 0f;
			winding.localRotation = localRotation;
		}
		if (remainingTime > 0f && isWinded)
		{
			if (!music.isPlaying)
			{
				music.transform.position = base.transform.position;
				music.Play();
				snowFX.Play();
				bgm.Stop();
			}
			for (int i = 0; i < rotatings.Length; i++)
			{
				rotatings[i].isRotating = true;
			}
			remainingTime -= Time.deltaTime;
		}
		else
		{
			for (int j = 0; j < rotatings.Length; j++)
			{
				rotatings[j].isRotating = false;
			}
			remainingTime = 0f;
			if (music.isPlaying)
			{
				music.Stop();
				snowFX.Stop();
				bgm.Play();
			}
		}
	}

	public void WindUp(float angle)
	{
		remainingTime += angle / 300f;
		remainingTime = Mathf.Clamp(remainingTime, 0f, music.clip.length);
		MonoSingleton<SoundMgr>.Instance().PlaySound(dialSound, base.transform.position, 0f, new SoundMgr.PlayParameters
		{
			Pitch = 1f,
			SourceID = 2,
			Volume = 1f,
			Loop = false
		}, 1f);
		onWindup?.Invoke();
	}

	public void SetWinding()
	{
		isWinded = true;
		placeholder.GetComponent<Collider>().enabled = false;
		placeholder.gameObject.SetActive(value: false);
		winding.gameObject.SetActive(value: true);
		tips.onFirst = false;
		tips.TurnOff();
		winding.GetComponent<DialInteractable>()?.OnDialAngleChanged.AddListener(WindUp);
	}

	public override void SetEnabled(bool enabled)
	{
		base.SetEnabled(enabled);
		if (enabled)
		{
			SetWinding();
		}
	}
}
public class ObjectActivator : ToyController
{
	public bool Toggle;

	public UnityEvent OnActivated;

	public UnityEvent OnDeactivated;

	private bool m_Activated;

	public void Activated()
	{
		if (Toggle)
		{
			if (m_Activated)
			{
				OnDeactivated.Invoke();
			}
			else
			{
				OnActivated.Invoke();
			}
			m_Activated = !m_Activated;
		}
		else
		{
			OnActivated.Invoke();
			m_Activated = true;
		}
	}

	public void Deactivated()
	{
		if (!Toggle)
		{
			OnDeactivated.Invoke();
			m_Activated = false;
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.X))
		{
			Activated();
		}
	}
}
public class PaperplaneController : ToyController
{
	public float speed = 1f;

	private Rigidbody rb;

	private Vector3 velocity;

	private void Start()
	{
		DropHandler component = GetComponent<DropHandler>();
		component.onBirth = (Action)Delegate.Combine(component.onBirth, new Action(Reset));
		rb = GetComponent<Rigidbody>();
	}

	private void OnDestroy()
	{
		DropHandler component = GetComponent<DropHandler>();
		component.onBirth = (Action)Delegate.Remove(component.onBirth, new Action(Reset));
	}

	private void Reset()
	{
		velocity = Vector3.zero;
	}

	private void FixedUpdate()
	{
		if (!rb.isKinematic && velocity.magnitude > 0f)
		{
			velocity.y -= 0.001f * Time.fixedDeltaTime;
			base.transform.position += velocity * Time.fixedDeltaTime;
		}
	}

	public void SetForce(Interactor interactor)
	{
		Vector3 controllerVelocity = MonoSingleton<InputHandler>.Instance().GetControllerVelocity(interactor.m_controller);
		velocity = Vector3.Dot(base.transform.TransformDirection(Vector3.left).normalized, speed * controllerVelocity) * base.transform.TransformDirection(Vector3.left).normalized;
	}
}
public class Radio : ToyController
{
	public AudioSource MusicSource;

	public AudioSource NoiseSource;

	public AudioClip[] MusicClips;

	private float m_TuningRatio;

	private float m_VolumeRatio;

	private float noiseVolume;

	private DialInteractable[] dials;

	private void Start()
	{
		noiseVolume = NoiseSource.volume;
		dials = GetComponentsInChildren<DialInteractable>();
		Tune();
	}

	private void Update()
	{
		if (dials != null && dials.Length != 0)
		{
			DialInteractable[] array = dials;
			foreach (DialInteractable obj in array)
			{
				Quaternion localRotation = obj.transform.localRotation;
				localRotation.x = 0f;
				localRotation.y = 0f;
				obj.transform.localRotation = localRotation;
			}
		}
	}

	public void VolumeChanged(DialInteractable dial)
	{
		float volumeRatio = dial.CurrentAngle / dial.RotationAngleMaximum;
		m_VolumeRatio = volumeRatio;
		Tune();
	}

	public void TuningChanged(DialInteractable dial)
	{
		if (dial.CurrentAngle < 1f)
		{
			MusicSource.Stop();
			NoiseSource.Stop();
		}
		else if (!MusicSource.isPlaying)
		{
			MusicSource.Play();
			NoiseSource.Play();
		}
		if (MusicClips.Length == 0)
		{
			return;
		}
		_ = dial.CurrentAngle / dial.RotationAngleMaximum;
		float num = dial.RotationAngleMaximum / (float)MusicClips.Length;
		float num2 = dial.CurrentAngle / num;
		int num3 = Mathf.RoundToInt(num2);
		float num4 = Mathf.Abs((float)num3 - num2) / 0.5f;
		if (num3 == 0)
		{
			num4 = 1f;
		}
		else
		{
			AudioClip audioClip = MusicClips[num3 - 1];
			if (audioClip != MusicSource.clip)
			{
				int timeSamples = MusicSource.timeSamples;
				MusicSource.clip = audioClip;
				MusicSource.timeSamples = timeSamples;
			}
		}
		m_TuningRatio = 1f - num4;
		Tune();
	}

	private void Tune()
	{
		MusicSource.volume = m_TuningRatio * m_VolumeRatio;
		NoiseSource.volume = noiseVolume * (1f - m_TuningRatio) * m_VolumeRatio;
	}
}
[CreateAssetMenu(menuName = "CreateRecipe")]
public class Recipe : ScriptableObject
{
	public RecipeItem[] items;

	public string productName;

	public string nameText;

	public int grade;

	public string sprite;

	public Transform product;

	public int productAmount;
}
[Serializable]
public class RecipeItem
{
	public string objName;

	public string nameText;

	public Unit unit;

	public float amount;
}
[Serializable]
public enum Unit
{
	NUM,
	WEIGHT
}
public class RecipeMgr : MonoBehaviour
{
	public int gradeSize = 3;

	public int levelSize = 3;

	public float confirmInterval = 0.6f;

	private string tips;

	public Recipe[] recipes;

	private Recipe current;

	public Action onRecipeChanged;

	private int currentIndex = -1;

	private float lastTime;

	private List<Recipe> recipesOfGrade;

	private void Awake()
	{
		GetRecipeOfGrade(MonoSingleton<GradeMgr>.Instance().GetGrade());
	}

	private void Start()
	{
		lastTime = Time.time;
		MagicCreator.onAnswerRight = (Action<int, int>)Delegate.Combine(MagicCreator.onAnswerRight, new Action<int, int>(NextRecipe));
		FruitCreator.onAnswerRight = (Action<int, int>)Delegate.Combine(FruitCreator.onAnswerRight, new Action<int, int>(NextRecipe));
	}

	private void OnDestroy()
	{
		MagicCreator.onAnswerRight = (Action<int, int>)Delegate.Remove(MagicCreator.onAnswerRight, new Action<int, int>(NextRecipe));
		FruitCreator.onAnswerRight = (Action<int, int>)Delegate.Remove(FruitCreator.onAnswerRight, new Action<int, int>(NextRecipe));
	}

	private int CaculateIndex(int currentGrade, int currentLevel, int levelSize)
	{
		int num = 0;
		for (int i = 0; i < currentGrade; i++)
		{
			num += levelSize;
		}
		return num + currentLevel;
	}

	private List<Recipe> GetRecipeOfGrade(int grade)
	{
		recipesOfGrade = new List<Recipe>();
		for (int i = 0; i < recipes.Length; i++)
		{
			if (recipes[i].grade >= grade)
			{
				recipesOfGrade.Add(recipes[i]);
			}
		}
		return recipesOfGrade;
	}

	public Recipe GetCurrentRecipe()
	{
		return current;
	}

	public string GetTips()
	{
		return tips;
	}

	public void NextRecipe(int grade, int level)
	{
		currentIndex = CaculateIndex(grade, level, levelSize);
		ChangeRecipe();
	}

	private void ChangeRecipe()
	{
		current = recipesOfGrade[currentIndex];
		onRecipeChanged?.Invoke();
	}

	public int GetCurrentIndex()
	{
		return currentIndex;
	}
}
public class Rotating : MonoBehaviour
{
	public bool isRotating;

	public Vector3 axis;

	public float speed;

	private void Start()
	{
	}

	private void Update()
	{
		if (isRotating)
		{
			base.transform.Rotate(speed * axis);
		}
	}
}
public class SnowBall : MonoBehaviour
{
	private Rigidbody rb;

	public ParticleSystem snowEffectPrefab;

	private AudioSource sound;

	private ParticleSystem snowEffect;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		sound = GetComponent<AudioSource>();
		snowEffect = UnityEngine.Object.Instantiate(snowEffectPrefab, base.transform.position, snowEffectPrefab.transform.rotation).GetComponent<ParticleSystem>();
	}

	private void Update()
	{
		if (rb.velocity.sqrMagnitude > 1f)
		{
			if (snowEffect.isStopped)
			{
				snowEffect.Play();
			}
			if (!sound.isPlaying)
			{
				sound.Play();
			}
		}
	}
}
public class Spawner : MonoBehaviour
{
	[Serializable]
	public class SpawnEvent : UnityEvent<Transform>
	{
	}

	public Transform prefab;

	public Transform spawnPoint;

	public Material material;

	public Vector3 Axis = Vector3.one;

	public float distance;

	public Vector3 scale = Vector3.one;

	public float weight;

	public string objectName;

	private Transform currentSpawn;

	public SpawnEvent OnObjectSpawned;

	private void OnEnable()
	{
		Invoke("SpawnObject", 0.1f);
	}

	private void Update()
	{
		if (!(currentSpawn == null) && Vector3.Distance(currentSpawn.position, base.transform.position) > distance)
		{
			SpawnObject();
		}
	}

	private void SpawnObject()
	{
		if (spawnPoint == null)
		{
			spawnPoint = MonoSingleton<SpawnPoint>.Instance().GetSpawnPoint();
		}
		currentSpawn = UnityEngine.Object.Instantiate(prefab, base.transform.position, base.transform.rotation, spawnPoint);
		currentSpawn.gameObject.SetActive(value: true);
		currentSpawn.transform.localScale = scale;
		currentSpawn.name = objectName;
		currentSpawn.GetComponentInChildren<Rigidbody>().mass = weight;
		if (material != null)
		{
			currentSpawn.GetComponentInChildren<Renderer>().material = material;
		}
		OnObjectSpawned?.Invoke(currentSpawn);
	}
}
public class ToyController : MonoBehaviour
{
	[HideInInspector]
	public bool isEnabled;

	public void RecordTransform(Transform obj)
	{
		List<Toy> toys = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().toys;
		for (int i = 0; i < toys.Count; i++)
		{
			if (toys[i].name.Equals(obj.name))
			{
				toys[i].pos = base.transform.position;
				toys[i].rot = base.transform.rotation.eulerAngles;
				MonoSingleton<AccountMgr>.Instance().GetUserProfileData().toys[i] = toys[i];
				break;
			}
		}
		MonoSingleton<AccountMgr>.Instance().UpdateInventory();
	}

	public virtual void SetEnabled(bool enabled)
	{
		isEnabled = enabled;
	}

	public void Enabled(Transform obj)
	{
		isEnabled = true;
		List<Toy> toys = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().toys;
		for (int i = 0; i < toys.Count; i++)
		{
			if (toys[i].name.Equals(obj.name))
			{
				toys[i].enabled = true;
				MonoSingleton<AccountMgr>.Instance().GetUserProfileData().toys[i] = toys[i];
				break;
			}
		}
		MonoSingleton<AccountMgr>.Instance().UpdateInventory();
	}

	public static void RemoveToy(string name)
	{
		List<Toy> toys = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().toys;
		for (int i = 0; i < toys.Count; i++)
		{
			if (toys[i].name.Equals(name))
			{
				MonoSingleton<AccountMgr>.Instance().GetUserProfileData().toys.Remove(toys[i]);
				MonoSingleton<AccountMgr>.Instance().UpdateInventory();
				break;
			}
		}
	}
}
public class Winding : Equipment
{
	protected override void Equip(Collider other)
	{
		GrabInteractable component = other.transform.GetComponent<GrabInteractable>();
		component.interactedBy?.Offhand(component);
		ToyController.RemoveToy(other.name);
		UnityEngine.Object.Destroy(other.gameObject);
	}

	protected override bool IsTriggered(Collider other)
	{
		return other.transform.name.Contains("Winding");
	}
}
public class MedalMgr : MonoSingleton<MedalMgr>
{
	public AudioClip getMedalSound;

	public ParticleSystem effect;

	private int count;

	public int Count => count;

	private void Start()
	{
		ThreeViewMgr.onUpgrade = (Action<int, int>)Delegate.Combine(ThreeViewMgr.onUpgrade, new Action<int, int>(AddMedal));
		MagicCreator.onUpgrade = (Action<int, int>)Delegate.Combine(MagicCreator.onUpgrade, new Action<int, int>(AddMedal));
		TangramMgr.onUpgrade = (Action<int, int>)Delegate.Combine(TangramMgr.onUpgrade, new Action<int, int>(AddMedal));
		AnswerChecker.onUpgrade = (Action<int, int>)Delegate.Combine(AnswerChecker.onUpgrade, new Action<int, int>(AddMedal));
		SudokuMgr.onUpgrade = (Action<int, int>)Delegate.Combine(SudokuMgr.onUpgrade, new Action<int, int>(AddMedal));
		FruitCreator.onUpgrade = (Action<int, int>)Delegate.Combine(FruitCreator.onUpgrade, new Action<int, int>(AddMedal));
		CycleGameMgr.onUpgrade = (Action<int, int>)Delegate.Combine(CycleGameMgr.onUpgrade, new Action<int, int>(AddMedal));
		List<Medal> medals = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().medals;
		if (medals != null && medals.Count > 0)
		{
			count = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().medals[0].count;
			return;
		}
		count = 0;
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().medals.Add(new Medal(0, count));
	}

	public void AddMedal(int grade, int level)
	{
		count++;
		if (MonoSingleton<AccountMgr>.Instance().GetUserProfileData().medals.Count == 0)
		{
			MonoSingleton<AccountMgr>.Instance().GetUserProfileData().medals.Add(new Medal(0, count));
		}
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().medals[0].count = count;
		MonoSingleton<AccountMgr>.Instance().UpdateInventory();
		MonoSingleton<SoundMgr>.Instance().PlaySound(getMedalSound, base.transform.position, 0f, new SoundMgr.PlayParameters
		{
			Pitch = 1f,
			SourceID = 3,
			Volume = 1f,
			Loop = false
		});
		effect?.Play();
	}

	public void RemoveMedal(int number)
	{
		count -= number;
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().medals[0].count = count;
		MonoSingleton<AccountMgr>.Instance().UpdateInventory();
	}

	private void OnDestroy()
	{
		ThreeViewMgr.onUpgrade = (Action<int, int>)Delegate.Remove(ThreeViewMgr.onUpgrade, new Action<int, int>(AddMedal));
		MagicCreator.onUpgrade = (Action<int, int>)Delegate.Remove(MagicCreator.onUpgrade, new Action<int, int>(AddMedal));
		TangramMgr.onUpgrade = (Action<int, int>)Delegate.Remove(TangramMgr.onUpgrade, new Action<int, int>(AddMedal));
		AnswerChecker.onUpgrade = (Action<int, int>)Delegate.Remove(AnswerChecker.onUpgrade, new Action<int, int>(AddMedal));
		SudokuMgr.onUpgrade = (Action<int, int>)Delegate.Remove(SudokuMgr.onUpgrade, new Action<int, int>(AddMedal));
		FruitCreator.onUpgrade = (Action<int, int>)Delegate.Remove(FruitCreator.onUpgrade, new Action<int, int>(AddMedal));
		CycleGameMgr.onUpgrade = (Action<int, int>)Delegate.Remove(CycleGameMgr.onUpgrade, new Action<int, int>(AddMedal));
	}
}
public class NFCZone : MonoBehaviour
{
	[Serializable]
	public class NFCEvent : UnityEvent
	{
	}

	public NFCEvent onNFCEnter;

	public AudioClip scanSound;

	public float confirmInterval = 0.5f;

	private float triggerTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		if (isTriggered(other))
		{
			triggerTime = Time.time;
			onNFCEnter?.Invoke();
			MonoSingleton<SoundMgr>.Instance().PlaySound(scanSound, base.transform.position);
		}
	}

	private bool isTriggered(Collider other)
	{
		if (Time.time - triggerTime > confirmInterval && other.transform.name.Contains("Medal"))
		{
			return true;
		}
		return false;
	}
}
public class ToyMgr : MonoBehaviour
{
	[Serializable]
	public class ToyType
	{
		public string type;

		public Transform prefab;
	}

	public List<Transform> toyRepos;

	public Transform parent;

	public List<ToyType> prefabs;

	private List<Toy> toys;

	private int repoIndex;

	private void Start()
	{
		toys = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().toys;
		UnityEngine.Debug.Log("toys:" + toys);
		repoIndex = 0;
		if (toys != null && toys.Count > 0)
		{
			for (int i = 0; i < toys.Count; i++)
			{
				StartCoroutine("SpawnToy", i);
			}
		}
	}

	private IEnumerator SpawnToy(int index)
	{
		yield return new WaitForSeconds((float)index * 0.5f);
		Toy toy = toys[index];
		Transform prefab = GetPrefab(toy.type);
		if (prefab != null)
		{
			Transform transform = toyRepos[repoIndex];
			Vector3 position = ((transform != null) ? transform.position : toy.pos);
			Transform obj = UnityEngine.Object.Instantiate(prefab, position, Quaternion.Euler(toy.rot), parent);
			obj.name = toy.name;
			obj.GetComponentInChildren<ToyController>()?.SetEnabled(toy.enabled);
			repoIndex++;
		}
	}

	private Transform GetPrefab(string type)
	{
		foreach (ToyType prefab in prefabs)
		{
			if (prefab.type.Equals(type))
			{
				return prefab.prefab;
			}
		}
		return null;
	}
}
public class VendingButton : MonoBehaviour
{
	public VendingItem item;

	private Renderer render;

	private Color highlightColor;

	private void Start()
	{
		render = GetComponent<Renderer>();
		highlightColor = new Color(0.2f, 0.8f, 0.7f);
		Highlight(on: false);
	}

	public void Highlight(bool on)
	{
		if (on)
		{
			render.material.SetColor("_EmissionColor", highlightColor);
		}
		else
		{
			render.material.SetColor("_EmissionColor", Color.black);
		}
	}
}
[CreateAssetMenu(menuName = "CreateVendingItem")]
public class VendingItem : ScriptableObject
{
	public int price;

	public Transform[] product;
}
public class VendingMachine : MonoBehaviour
{
	public TMP_Text display;

	public Transform spawnPoint;

	public AudioClip productSound;

	private VendingButton choosedButton;

	public static Action vendingSucceed;

	private void Start()
	{
		display.text = ISILocalization.GetValueOf(LanCode.ChooseItems);
	}

	public void Choose(VendingButton button)
	{
		StopAllCoroutines();
		if (choosedButton != null)
		{
			choosedButton.Highlight(on: false);
		}
		choosedButton = button;
		choosedButton.Highlight(on: true);
		if (ISILocalization.CurrentLanguage.Equals(Language.Chinese))
		{
			display.text = choosedButton.item.price + "个勋章";
		}
		else
		{
			display.text = choosedButton.item.price + ".00";
		}
		StartCoroutine("Reset");
	}

	public void Purchase()
	{
		StopAllCoroutines();
		if (choosedButton == null)
		{
			display.text = ISILocalization.GetValueOf(LanCode.ChooseItems);
			MonoSingleton<SoundMgr>.Instance().PlaySound(SLocalization.GetAudio(LanCode.VendingIntro), base.transform.position);
			return;
		}
		if (MonoSingleton<MedalMgr>.Instance().Count >= choosedButton.item.price)
		{
			MonoSingleton<SoundMgr>.Instance().PlaySound(productSound, base.transform.position);
			if (SpawnObject())
			{
				vendingSucceed?.Invoke();
				MonoSingleton<MedalMgr>.Instance().RemoveMedal(choosedButton.item.price);
				display.text = ISILocalization.GetValueOf(LanCode.ChooseItems);
			}
			else
			{
				display.text = ISILocalization.GetValueOf(LanCode.AlreadyHaveItem);
				MonoSingleton<SoundMgr>.Instance().PlaySound(SLocalization.GetAudio(LanCode.AlreadyHaveItem));
			}
			if (choosedButton != null)
			{
				choosedButton.Highlight(on: false);
				choosedButton = null;
			}
		}
		else
		{
			display.text = ISILocalization.GetValueOf(LanCode.MedalNotEnough);
			MonoSingleton<SoundMgr>.Instance().PlaySound(SLocalization.GetAudio(LanCode.MedalNotEnough), base.transform.position);
		}
		StartCoroutine("Reset");
	}

	private IEnumerator Reset()
	{
		yield return new WaitForSeconds(60f);
		display.text = ISILocalization.GetValueOf(LanCode.ChooseItems);
		if (choosedButton != null)
		{
			choosedButton.Highlight(on: false);
			choosedButton = null;
		}
	}

	private bool SpawnObject()
	{
		Transform[] product = choosedButton.item.product;
		Transform prefabs = GetPrefabs(product);
		if (prefabs == null)
		{
			return false;
		}
		Transform transform = UnityEngine.Object.Instantiate(prefabs, spawnPoint.position, Quaternion.identity, spawnPoint);
		transform.name += Guid.NewGuid().ToString();
		if (!MonoSingleton<AccountMgr>.Instance().GetUserProfileData().Contains(prefabs.name))
		{
			MonoSingleton<AccountMgr>.Instance().GetUserProfileData().toys.Add(new Toy(transform.GetInstanceID(), transform.name, prefabs.name, transform.transform.position, transform.transform.rotation.eulerAngles, enabled: false));
			MonoSingleton<AccountMgr>.Instance().UpdateInventory();
		}
		return true;
	}

	private Transform GetPrefabs(Transform[] choices)
	{
		int num = UnityEngine.Random.Range(0, choices.Length);
		Transform transform = choices[num];
		if (!MonoSingleton<AccountMgr>.Instance().GetUserProfileData().Contains(transform.name))
		{
			return transform;
		}
		transform = null;
		for (int i = 1; i < choices.Length; i++)
		{
			transform = choices[(num + i) % choices.Length];
			if (!MonoSingleton<AccountMgr>.Instance().GetUserProfileData().Contains(transform.name))
			{
				break;
			}
			transform = null;
		}
		return transform;
	}
}
public class ProfilingMgr
{
	[Serializable]
	public enum Mode
	{
		Standard,
		Light,
		Deep
	}

	private struct FrameData
	{
		public float elapsedNanoseconds;

		public int numCalls;
	}

	private struct Sample
	{
		public string name;

		public Recorder recorder;

		public List<FrameData> frameData;
	}

	private class Statistics
	{
		public float Min { get; private set; }

		public float Max { get; private set; }

		public float Median { get; private set; }

		public float Mean { get; private set; }

		public float InterquartileMean { get; private set; }

		public float StandardDeviation { get; private set; }

		public float StandardDeviationPcOfMedian { get; private set; }

		public float StandardDeviationPcOfMean { get; private set; }

		public float StandardDeviationPcOfInterquartileMean { get; private set; }

		public Statistics(float[] data)
		{
			float[] array = new float[data.Length];
			data.CopyTo(array, 0);
			Array.Sort(array);
			Min = array.First();
			Max = array.Last();
			int num = array.Length / 2;
			int num2 = (array.Length - 1) / 2;
			Median = (array[num] + array[num2]) / 2f;
			Mean = array.Average();
			InterquartileMean = array.Skip(array.Length / 4).Take(array.Length / 2).Average();
			StandardDeviation = Mathf.Sqrt(data.Select((float x) => Mathf.Pow(x - Median, 2f)).Sum() / (float)(array.Length - 1));
			StandardDeviationPcOfMedian = 100f * StandardDeviation / Median;
			StandardDeviationPcOfMean = 100f * StandardDeviation / Mean;
			StandardDeviationPcOfInterquartileMean = 100f * StandardDeviation / InterquartileMean;
		}
	}

	private static ProfilingMgr m_Instance;

	private bool m_Profiling;

	private Mode m_Mode;

	private List<float> m_FrameTimes;

	private const int k_NumFrames = 450;

	private Coroutine m_UpdateCoroutine;

	private int[] m_ValidFramerates = new int[4] { 90, 75, 60, 1 };

	private List<Sample> m_Samples = new List<Sample>();

	private List<string> ProfilingFunctions = new List<string>();

	public static ProfilingMgr Instance
	{
		get
		{
			if (m_Instance == null)
			{
				m_Instance = new ProfilingMgr();
				m_Instance.m_Profiling = false;
			}
			return m_Instance;
		}
	}

	public void AddProfilingFunction(string func)
	{
		ProfilingFunctions.Add(func);
	}

	public void StartProfiling(Mode mode)
	{
		m_Mode = mode;
		Mode mode2 = m_Mode;
		if (mode2 == Mode.Standard || mode2 == Mode.Deep)
		{
			string profilingFilename = GetProfilingFilename();
			UnityEngine.Debug.LogFormat("Writing Profile to {0}", profilingFilename);
			Profiler.logFile = profilingFilename;
			Profiler.enableBinaryLog = true;
			Profiler.enabled = true;
		}
		if (ProfilingFunctions != null)
		{
			m_Samples = new List<Sample>(ProfilingFunctions.Count);
			foreach (string profilingFunction in ProfilingFunctions)
			{
				Sample item = default(Sample);
				item.name = profilingFunction;
				item.recorder = Recorder.Get(profilingFunction);
				if (!item.recorder.isValid)
				{
					UnityEngine.Debug.LogWarningFormat("Profiling: Could not get recorder for {0} function.", profilingFunction);
				}
				else
				{
					item.recorder.enabled = true;
					item.frameData = new List<FrameData>(450);
					m_Samples.Add(item);
				}
			}
		}
		else
		{
			m_Samples = new List<Sample>();
		}
		m_FrameTimes = new List<float>(450);
		m_Profiling = true;
		m_UpdateCoroutine = MonoSingleton<SceneMgr>.Instance().StartCoroutine(Update());
	}

	public void StopProfiling()
	{
		UnityEngine.Debug.Log("Stopping Profiling.");
		Mode mode = m_Mode;
		if (mode == Mode.Standard || mode == Mode.Deep)
		{
			Profiler.enableBinaryLog = false;
			Profiler.enabled = false;
			Profiler.logFile = null;
		}
		foreach (Sample sample in m_Samples)
		{
			sample.recorder.enabled = false;
		}
		if (m_UpdateCoroutine != null)
		{
			MonoSingleton<SceneMgr>.Instance().StopCoroutine(m_UpdateCoroutine);
		}
		m_Profiling = false;
		OutputStats();
		m_Samples = new List<Sample>();
	}

	private string GetProfilingFilename()
	{
		string arg = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
		string path = $"Profile_{arg}.data";
		return System.IO.Path.Combine(Application.persistentDataPath, path);
	}

	private IEnumerator Update()
	{
		while (true)
		{
			m_FrameTimes.Add(Time.unscaledDeltaTime * 1000f);
			yield return null;
			foreach (Sample sample in m_Samples)
			{
				FrameData item = default(FrameData);
				item.elapsedNanoseconds = sample.recorder.elapsedNanoseconds;
				item.numCalls = sample.recorder.sampleBlockCount;
				sample.frameData.Add(item);
			}
		}
	}

	private void OutputStats()
	{
		UnityEngine.Debug.LogFormat("TBProfile: Number of frames recorded: {0}", m_FrameTimes.Count);
		if (m_FrameTimes.Count <= 0)
		{
			return;
		}
		Statistics stats = new Statistics(m_FrameTimes.ToArray());
		float[] array = m_ValidFramerates.Select((int x) => 1000f / (float)x + 0.5f).ToArray();
		int[] array2 = new int[m_ValidFramerates.Length];
		foreach (float frameTime in m_FrameTimes)
		{
			for (int i = 0; i < array2.Length; i++)
			{
				if (frameTime < array[i])
				{
					array2[i]++;
					break;
				}
			}
		}
		float percentScale = 100f / (float)m_FrameTimes.Count;
		float[] frameRatePercentages = array2.Select((int x) => (float)x * percentScale).ToArray();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("\nTBProfile: START");
		HumanReadableOutput(stringBuilder, stats, frameRatePercentages);
		stringBuilder.AppendLine("TBProfile: END");
		UnityEngine.Debug.Log(stringBuilder.ToString());
	}

	private void HumanReadableOutput(StringBuilder output, Statistics stats, float[] frameRatePercentages)
	{
		output.AppendFormat("TBProfile: Frames: {0}  Min: {1:F2}  Median: {2:F2}  Max:{3:F2}\n", m_FrameTimes.Count, stats.Min, stats.Median, stats.Max);
		IEnumerable<string> source = from i in Enumerable.Range(0, m_ValidFramerates.Length)
			select $"{m_ValidFramerates[i]}fps: {frameRatePercentages[i]:F1}%";
		output.Append("TBProfile: ");
		output.AppendLine(string.Join("  ", source.ToArray()));
		foreach (Sample sample in m_Samples)
		{
			float[] array = (from x in sample.frameData
				select x.elapsedNanoseconds / 1000000f into x
				where x > 0f
				select x).ToArray();
			if (array.Length != 0)
			{
				stats = new Statistics(array);
				output.AppendFormat("TBProfile: {0}: Frames: {1} Min: {2:F2}  Median: {3:F2}  Max:{4:F2}\n", sample.name, sample.frameData.Count, stats.Min, stats.Median, stats.Max);
			}
		}
	}
}
public class Quit : MonoBehaviour
{
	public Transform panel;

	private float t;

	private float t1;

	private void Start()
	{
		panel.gameObject.SetActive(value: false);
	}

	private void Update()
	{
		if (MonoSingleton<InputHandler>.Instance().IsQuitKeyDown())
		{
			t1 = Time.realtimeSinceStartup;
			panel.gameObject.SetActive(value: true);
			if (t1 - t < 0.5f)
			{
				Application.Quit();
			}
			t = t1;
		}
		if (panel.gameObject.activeSelf && Time.realtimeSinceStartup - t > 0.5f)
		{
			panel.gameObject.SetActive(value: false);
		}
	}
}
public class Rotation : MonoBehaviour
{
	public float step = 500f;

	public float maxSpeed = 3000f;

	private GameObject rotObj;

	private float speed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void IncreaseSpeed()
	{
		speed += step;
		if (speed > maxSpeed)
		{
			speed = maxSpeed;
		}
	}

	public void DecreaseSpeed()
	{
		speed = 0f;
		rotObj.transform.RotateAround(base.transform.position, Vector3.up, 180f);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.Equals("Match"))
		{
			rotObj = other.gameObject;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag.Equals("Match"))
		{
			rotObj = null;
		}
	}
}
public class SceneFadeInOut : MonoBehaviour
{
	public Image image;

	public float fadeSpeed = 1.5f;

	private bool sceneStarting = true;

	private void Update()
	{
		if (sceneStarting)
		{
			StartScene();
		}
	}

	private void FadeToClear()
	{
		image.color = Color.Lerp(image.color, Color.clear, fadeSpeed * Time.deltaTime);
	}

	private void FadeToBlack()
	{
		image.color = Color.Lerp(image.color, Color.black, fadeSpeed * Time.deltaTime);
	}

	private void StartScene()
	{
		FadeToClear();
		if (image.color.a <= 0.05f)
		{
			image.color = Color.clear;
			image.enabled = false;
			sceneStarting = false;
		}
	}

	public void EndScene()
	{
		image.enabled = true;
		FadeToBlack();
		_ = image.color.a;
		_ = 0.95f;
	}
}
public class SceneMgr : MonoSingleton<SceneMgr>
{
	private string currentScene;

	public void LoadSceneAdditive(string name)
	{
		if (!string.IsNullOrEmpty(currentScene))
		{
			try
			{
				SceneManager.UnloadSceneAsync(currentScene);
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError(ex.Message);
			}
		}
		if (!string.IsNullOrEmpty(name))
		{
			SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
		}
		currentScene = name;
	}

	public void LoadScene(string name)
	{
		StartCoroutine("DoLoadScene", name);
	}

	private IEnumerator DoLoadScene(string name)
	{
		UnityEngine.AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(name);
		while (!asyncLoad.isDone)
		{
			yield return new WaitForSeconds(0.5f);
		}
	}
}
internal abstract class AbstractNetwork
{
	public const string address = "https://81.70.45.74:8000/";
}
internal class ArrayUtil
{
}
public class CustomCertificateHandler : CertificateHandler
{
	private static readonly string PUB_KEY = "";

	protected override bool ValidateCertificate(byte[] certificateData)
	{
		return true;
	}
}
public static class DataSourceFactory
{
	public enum DataSourceType
	{
		Network,
		Database
	}

	private const DataSourceType DEFAULT_TYPE = DataSourceType.Network;

	private static IDataSourceService networkService = new NetworkService();

	public static IDataSourceService GetDataSource(DataSourceType type)
	{
		if (type.Equals(DataSourceType.Network))
		{
			return networkService;
		}
		return null;
	}

	public static IDataSourceService GetDataSource()
	{
		return GetDataSource(DataSourceType.Network);
	}
}
[Serializable]
public class DeviceResponse
{
	public Device[] results;
}
public interface IDataSourceService
{
	IAccountService GetAccountService();

	IPerformanceService GetPerformanceService();

	IInventoryService GetInventoryService();

	IDeviceService GetDeviceService();

	IMemoryService GetMemoryService();

	IMediaService GetMediaService();

	IAccessService GetAccessService();
}
public interface IDeviceService
{
	int CreateDevice(Device device, Action<Device> callback);

	void UpdateDevice(Device device);

	void GetDevice(string UUID, Action<Device[]> callback);

	void GetDevice(int deviceID, Action<Device> callback);
}
public interface IMemoryService
{
	int CreateMemory(Memory memory, string name, Action<Memory, string> callback);

	void UpdateMemory(Memory memory);

	void GetMemory(int mediaID, Action<Memory[]> callback);

	void GetMemories(int accountID, Action<Memory[]> callback);

	void GetSharedMemories(int accountID, Action<Memory[]> callback);
}
[Serializable]
public class Access
{
	public int account_id;

	public int count;

	public string avg_duration;

	public string total_time;

	public string last_updated;

	public Access(int account_id, int count, string avg_duration, string total_time, string last_updated)
	{
		this.account_id = account_id;
		this.count = count;
		this.avg_duration = avg_duration;
		this.total_time = total_time;
		this.last_updated = last_updated;
	}

	public override string ToString()
	{
		return JsonUtility.ToJson(this, prettyPrint: true);
	}
}
[Serializable]
public class Account
{
	public int account_id;

	public string name;

	public int age;

	public int gender;

	public int grade;

	public string info;

	public int media_id;

	public int performance_id;

	public int inventory_id;

	public string created_time;

	public override string ToString()
	{
		return JsonUtility.ToJson(this, prettyPrint: true);
	}
}
[Serializable]
public class Device
{
	public int dev_id;

	public string UUID;

	public string manufactor;

	public string accounts_info;

	public string extra;

	public string created_time;

	public Device(int dev_id, string UUID, string manufactor, string accounts_info, string extra, string created_time)
	{
		this.dev_id = dev_id;
		this.UUID = UUID;
		this.manufactor = manufactor;
		this.accounts_info = accounts_info;
		this.extra = extra;
		this.created_time = created_time;
	}

	public override string ToString()
	{
		return JsonUtility.ToJson(this, prettyPrint: true);
	}
}
[Serializable]
public class Inventory
{
	public int inventory_id;

	public string toys_info;

	public string rewards_info;

	public override string ToString()
	{
		return JsonUtility.ToJson(this, prettyPrint: true);
	}
}
[Serializable]
public class Medal
{
	public int type;

	public int count;

	public Medal(int type, int count)
	{
		this.type = type;
		this.count = count;
	}

	public override string ToString()
	{
		return JsonUtility.ToJson(this, prettyPrint: true);
	}
}
[Serializable]
public class Media
{
	public int media_id;

	public int type_id;

	public string path;

	public string data;

	public string created_time;

	public override string ToString()
	{
		return JsonUtility.ToJson(this, prettyPrint: true);
	}
}
[Serializable]
public class MediaRequest
{
	public int media_id;

	public int type_id;

	public string name;

	public string path;

	public byte[] data;

	public string created_time;

	public override string ToString()
	{
		return JsonUtility.ToJson(this, prettyPrint: true);
	}
}
[Serializable]
public class Memory
{
	public int memo_id;

	public int account_id;

	public string info;

	public string created_time;

	public int media_id;

	public int type_id;

	public int visited_count;

	public int shared;

	public int deleted;

	public Memory(int accountID, int mediaID, int typeID, string info, string createdTime)
	{
		account_id = accountID;
		media_id = mediaID;
		type_id = typeID;
		this.info = info;
		created_time = createdTime;
	}
}
[Serializable]
public class Performance
{
	public int performance_id;

	public int score;

	public string grade;

	public string level;

	public int ability_arithma;

	public int ability_logic;

	public int ability_space;

	public int ability_focus;

	public int ability_creative;

	public override string ToString()
	{
		return JsonUtility.ToJson(this, prettyPrint: true);
	}
}
[Serializable]
public class Toy
{
	public int id;

	public string name;

	public string type;

	public bool enabled;

	public Vector3 pos;

	public Vector3 rot;

	public Toy(int id, string name, string type, Vector3 pos, Vector3 rot, bool enabled)
	{
		this.id = id;
		this.name = name;
		this.type = type;
		this.pos = pos;
		this.rot = rot;
		this.enabled = enabled;
	}

	public override string ToString()
	{
		return JsonUtility.ToJson(this, prettyPrint: true);
	}
}
internal class NetworkService : IDataSourceService
{
	public IAccountService GetAccountService()
	{
		return new NetworkAccountService();
	}

	public IDeviceService GetDeviceService()
	{
		return new NetworkDeviceService();
	}

	public IInventoryService GetInventoryService()
	{
		return new NetworkInventoryService();
	}

	public IMemoryService GetMemoryService()
	{
		return new NetworkMemoryService();
	}

	public IPerformanceService GetPerformanceService()
	{
		return new NetworkPerformanceService();
	}

	public IMediaService GetMediaService()
	{
		return new NetworkMediaService();
	}

	public IAccessService GetAccessService()
	{
		return new NetworkAccessService();
	}
}
public interface IAccessService
{
	int CreateAccess(Access access, Action<Access> callback);

	void UpdateAccess(Access access);

	void GetAccess(int deviceID, Action<Access> callback);
}
public interface IAccountService
{
	int CreateAccount(Account account, Action<Account> callback);

	void UpdateAccount(Account account);

	void GetAccount(int accountID, Action<Account> callback);
}
public interface IInventoryService
{
	int CreateInventory(Inventory inventory, Action<Inventory> callback);

	void UpdateInventory(Inventory inventory);

	void GetInventory(int inventoryID, Action<Inventory> callback);
}
public interface IMediaService
{
	int CreateMedia(MediaRequest media, Action<Media> callback);

	void GetMedia(int mediaID, Action<Media> callback);

	void DownloadMedia(int mediaID, string path, Action<object, string> callback);
}
public interface IPerformanceService
{
	int CreatePerformance(Performance performance, Action<Performance> callback);

	void UpdatePerformance(Performance performance);

	void GetPerformance(int performanceID, Action<Performance> callback);
}
[Serializable]
internal class MemoryResponse
{
	public Memory[] results;
}
internal class NetworkAccessService : AbstractNetwork, IAccessService
{
	private CustomCertificateHandler certHandler = new CustomCertificateHandler();

	public int CreateAccess(Access access, Action<Access> callback)
	{
		RestClient.Post<Access>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//access/",
			Body = access,
			CertificateHandler = certHandler,
			EnableDebug = true
		}).Then(delegate(Access res)
		{
			callback(res);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.LogError(err.Message);
		});
		return 0;
	}

	public void GetAccess(int accountID, Action<Access> callback)
	{
		RestClient.Get<Access>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//access/" + accountID,
			CertificateHandler = certHandler
		}).Then(delegate(Access res)
		{
			callback(res);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.LogError(err.Message);
		});
	}

	public void UpdateAccess(Access access)
	{
		if (access != null)
		{
			RestClient.Put<Access>(new RequestHelper
			{
				Uri = "https://81.70.45.74:8000//access/" + access.account_id + "/",
				Body = access,
				CertificateHandler = certHandler,
				Retries = 5,
				RetrySecondsDelay = 1f,
				RetryCallback = delegate(RequestException err, int retries)
				{
					UnityEngine.Debug.Log($"Retry #{retries} Status {err.StatusCode}\nError: {err}");
				},
				EnableDebug = true
			}).Then(delegate(Access res)
			{
				UnityEngine.Debug.Log(res.ToJson());
			}).Catch(delegate(Exception err)
			{
				UnityEngine.Debug.LogError(err.Message);
			});
		}
	}
}
[Serializable]
internal class NetworkAccountService : AbstractNetwork, IAccountService
{
	private CustomCertificateHandler certHandler = new CustomCertificateHandler();

	public int CreateAccount(Account account, Action<Account> callback)
	{
		RestClient.Post<Account>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//accounts/",
			Body = account,
			CertificateHandler = certHandler,
			EnableDebug = true
		}).Then(delegate(Account res)
		{
			callback(res);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.LogError(err.Message);
		});
		return 0;
	}

	public void UpdateAccount(Account account)
	{
		if (account != null)
		{
			RestClient.Put<Account>(new RequestHelper
			{
				Uri = "https://81.70.45.74:8000//accounts/" + account.account_id + "/",
				Body = account,
				CertificateHandler = certHandler,
				Retries = 1,
				RetrySecondsDelay = 1f,
				RetryCallback = delegate(RequestException err, int retries)
				{
					UnityEngine.Debug.Log($"Retry #{retries} Status {err.StatusCode}\nError: {err}");
				},
				EnableDebug = true
			}).Then(delegate(Account res)
			{
				UnityEngine.Debug.Log(res.ToJson());
			}).Catch(delegate(Exception err)
			{
				UnityEngine.Debug.LogError(err.Message);
			});
		}
	}

	public void GetAccount(int accountID, Action<Account> callback)
	{
		RestClient.Get<Account>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//accounts/" + accountID,
			CertificateHandler = certHandler
		}).Then(delegate(Account res)
		{
			callback(res);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.Log(err.Message);
		});
	}
}
internal class NetworkDeviceService : AbstractNetwork, IDeviceService
{
	private CustomCertificateHandler certHandler = new CustomCertificateHandler();

	public int CreateDevice(Device device, Action<Device> callback)
	{
		RestClient.Post<Device>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//devices/",
			Body = device,
			CertificateHandler = certHandler,
			EnableDebug = true
		}).Then(delegate(Device res)
		{
			callback(res);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.LogError(err.Message);
		});
		return 0;
	}

	public void GetDevice(string UUID, Action<Device[]> callback)
	{
		RestClient.Get<DeviceResponse>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//devices/?UUID=" + UUID,
			CertificateHandler = certHandler
		}).Then(delegate(DeviceResponse res)
		{
			callback(res.results);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.Log(err.Message);
		});
	}

	public void GetDevice(int deviceID, Action<Device> callback)
	{
		RestClient.Get<Device>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//devices/" + deviceID,
			CertificateHandler = certHandler
		}).Then(delegate(Device res)
		{
			callback(res);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.LogError(err.Message);
		});
	}

	public void UpdateDevice(Device device)
	{
		if (device != null)
		{
			RestClient.Put<Device>(new RequestHelper
			{
				Uri = "https://81.70.45.74:8000//devices/" + device.dev_id + "/",
				Body = device,
				CertificateHandler = certHandler,
				Retries = 5,
				RetrySecondsDelay = 1f,
				RetryCallback = delegate(RequestException err, int retries)
				{
					UnityEngine.Debug.Log($"Retry #{retries} Status {err.StatusCode}\nError: {err}");
				},
				EnableDebug = true
			}).Then(delegate(Device res)
			{
				UnityEngine.Debug.Log(res.ToJson());
			}).Catch(delegate(Exception err)
			{
				UnityEngine.Debug.LogError(err.Message);
			});
		}
	}
}
[Serializable]
internal class NetworkInventoryService : AbstractNetwork, IInventoryService
{
	private CustomCertificateHandler certHandler = new CustomCertificateHandler();

	public int CreateInventory(Inventory inventory, Action<Inventory> callback)
	{
		RestClient.Post<Inventory>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//inventories/",
			Body = inventory,
			CertificateHandler = certHandler,
			EnableDebug = true
		}).Then(delegate(Inventory res)
		{
			callback(res);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.LogError(err.Message);
		});
		return 0;
	}

	public void UpdateInventory(Inventory inventory)
	{
		if (inventory != null)
		{
			RestClient.Put<Inventory>(new RequestHelper
			{
				Uri = "https://81.70.45.74:8000//inventories/" + inventory.inventory_id + "/",
				Body = inventory,
				CertificateHandler = certHandler,
				Retries = 1,
				RetrySecondsDelay = 1f,
				RetryCallback = delegate(RequestException err, int retries)
				{
					UnityEngine.Debug.Log($"Retry #{retries} Status {err.StatusCode}\nError: {err}");
				},
				EnableDebug = true
			}).Then(delegate(Inventory res)
			{
				UnityEngine.Debug.Log(res.ToJson());
			}).Catch(delegate(Exception err)
			{
				UnityEngine.Debug.LogError(err.Message);
			});
		}
	}

	public void GetInventory(int inventoryID, Action<Inventory> callback)
	{
		RestClient.Get<Inventory>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//inventories/" + inventoryID,
			CertificateHandler = certHandler
		}).Then(delegate(Inventory res)
		{
			callback(res);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.Log(err.Message);
		});
	}
}
[Serializable]
internal class NetworkMediaService : AbstractNetwork, IMediaService
{
	private CustomCertificateHandler certHandler = new CustomCertificateHandler();

	public int CreateMedia(MediaRequest media, Action<Media> callback)
	{
		List<IMultipartFormSection> list = new List<IMultipartFormSection>();
		list.Add(new MultipartFormDataSection("type_id", media.type_id.ToString()));
		list.Add(new MultipartFormDataSection("path", media.path));
		list.Add(new MultipartFormFileSection("upload", media.data, media.name, "image/png"));
		RestClient.Post(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//uploads/",
			FormSections = list,
			CertificateHandler = certHandler,
			EnableDebug = true,
			Timeout = 120
		}).Then(delegate(ResponseHelper res)
		{
			Media obj = JsonUtility.FromJson<Media>(Encoding.Default.GetString(res.Data));
			callback(obj);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.LogError(err.Message);
		});
		return 0;
	}

	public void GetMedia(int mediaID, Action<Media> callback)
	{
		RestClient.Get<Media>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//media/" + mediaID,
			CertificateHandler = certHandler
		}).Then(delegate(Media res)
		{
			callback(res);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.Log(err.Message);
		});
	}

	public void DownloadMedia(int mediaID, string path, Action<object, string> callback)
	{
		RestClient.Get(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//downloads/?media_id=" + mediaID,
			CertificateHandler = certHandler,
			Timeout = 120,
			Retries = 5,
			RetrySecondsDelay = 120f,
			RetryCallback = delegate(RequestException err, int retries)
			{
				UnityEngine.Debug.Log($"Retry #{retries} Status {err.StatusCode}\nError: {err}");
			}
		}).Then(delegate(ResponseHelper res)
		{
			callback(res, path);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.Log(err.Message);
		});
	}
}
internal class NetworkMemoryService : AbstractNetwork, IMemoryService
{
	private CustomCertificateHandler certHandler = new CustomCertificateHandler();

	public int CreateMemory(Memory memory, string name, Action<Memory, string> callback)
	{
		RestClient.Post<Memory>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//memories/",
			Body = memory,
			CertificateHandler = certHandler,
			Retries = 5,
			RetrySecondsDelay = 1f,
			EnableDebug = true
		}).Then(delegate(Memory res)
		{
			callback(res, name);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.LogError(err.Message);
		});
		return 0;
	}

	public void GetMemories(int accountID, Action<Memory[]> callback)
	{
		RestClient.Get<MemoryResponse>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//memories/?account_id=" + accountID,
			CertificateHandler = certHandler
		}).Then(delegate(MemoryResponse res)
		{
			callback(res.results);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.LogError(err.Message);
		});
	}

	public void GetMemory(int mediaID, Action<Memory[]> callback)
	{
		RestClient.Get<MemoryResponse>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//memories/?media_id=" + mediaID,
			CertificateHandler = certHandler
		}).Then(delegate(MemoryResponse res)
		{
			callback(res.results);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.LogError(err.Message);
		});
	}

	public void GetSharedMemories(int accountID, Action<Memory[]> callback)
	{
		RestClient.Get<MemoryResponse>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//memories/?shared=1&&deleted=0",
			CertificateHandler = certHandler
		}).Then(delegate(MemoryResponse res)
		{
			callback(res.results);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.LogError(err.Message);
		});
	}

	public void UpdateMemory(Memory memory)
	{
		if (memory != null)
		{
			RestClient.Put<Memory>(new RequestHelper
			{
				Uri = "https://81.70.45.74:8000//memories/" + memory.memo_id + "/",
				Body = memory,
				CertificateHandler = certHandler,
				Retries = 5,
				RetrySecondsDelay = 1f,
				RetryCallback = delegate(RequestException err, int retries)
				{
					UnityEngine.Debug.Log($"Retry #{retries} Status {err.StatusCode}\nError: {err}");
				},
				EnableDebug = true
			}).Then(delegate(Memory res)
			{
				UnityEngine.Debug.Log(res.ToJson());
			}).Catch(delegate(Exception err)
			{
				UnityEngine.Debug.LogError(err.Message);
			});
		}
	}
}
[Serializable]
internal class NetworkPerformanceService : AbstractNetwork, IPerformanceService
{
	private CustomCertificateHandler certHandler = new CustomCertificateHandler();

	public int CreatePerformance(Performance performance, Action<Performance> callback)
	{
		RestClient.Post<Performance>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//performances/",
			Body = performance,
			CertificateHandler = certHandler,
			EnableDebug = true
		}).Then(delegate(Performance res)
		{
			callback(res);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.LogError(err.Message);
		});
		return 0;
	}

	public void UpdatePerformance(Performance performance)
	{
		if (performance != null)
		{
			RestClient.Put<Performance>(new RequestHelper
			{
				Uri = "https://81.70.45.74:8000//performances/" + performance.performance_id + "/",
				Body = performance,
				CertificateHandler = certHandler,
				Retries = 1,
				RetrySecondsDelay = 1f,
				RetryCallback = delegate(RequestException err, int retries)
				{
					UnityEngine.Debug.Log($"Retry #{retries} Status {err.StatusCode}\nError: {err}");
				},
				EnableDebug = true
			}).Then(delegate(Performance res)
			{
				UnityEngine.Debug.Log(res.ToJson());
			}).Catch(delegate(Exception err)
			{
				UnityEngine.Debug.LogError(err.Message);
			});
		}
	}

	public void GetPerformance(int performanceID, Action<Performance> callback)
	{
		RestClient.Get<Performance>(new RequestHelper
		{
			Uri = "https://81.70.45.74:8000//performances/" + performanceID,
			CertificateHandler = certHandler
		}).Then(delegate(Performance res)
		{
			callback(res);
		}).Catch(delegate(Exception err)
		{
			UnityEngine.Debug.LogError(err.Message);
		});
	}
}
public class FruiterMgr : MonoBehaviour
{
	private RecipeMgr recipeMgr;

	private AudioClip introClip;

	private SpriteRenderer hintSprite;

	private void Awake()
	{
		MonoSingleton<Instructions>.Instance().Init(LanCode.FruiterIntro, null, "");
		recipeMgr = GetComponent<RecipeMgr>();
		hintSprite = MonoSingleton<Instructions>.Instance().GetSpriteRenderer();
	}

	private void Start()
	{
		introClip = SLocalization.GetAudio(LanCode.CreatorFruit);
		MonoSingleton<VoiceMgr>.Instance().PlayVoice(introClip);
	}

	private void OnEnable()
	{
		RecipeMgr obj = recipeMgr;
		obj.onRecipeChanged = (Action)Delegate.Combine(obj.onRecipeChanged, new Action(HandleRecipeChanged));
	}

	private void OnDisable()
	{
		RecipeMgr obj = recipeMgr;
		obj.onRecipeChanged = (Action)Delegate.Remove(obj.onRecipeChanged, new Action(HandleRecipeChanged));
	}

	private void HandleRecipeChanged()
	{
		hintSprite.sprite = ISILocalization.GetSprite(recipeMgr.GetCurrentRecipe()?.sprite);
	}
}
public class Lid : MonoBehaviour
{
	public UnityEvent onLidClose;

	public void LidMove(float angle)
	{
		if (angle == 50f)
		{
			onLidClose?.Invoke();
		}
	}

	public void Open()
	{
		base.transform.DOLocalRotate(140f * Vector3.left, 1f);
	}
}
public class Chest : MonoBehaviour
{
	public AudioClip openSound;

	public AudioClip medalSound;

	public List<Transform> toys;

	public Transform spawnPoint;

	public ParticleSystem ps;

	public ParticleSystem[] randomPS;

	private ParticleSystem currentPS;

	private List<int> spawnedIndexes;

	private void Start()
	{
		spawnedIndexes = new List<int>();
	}

	public void CloseChest()
	{
		base.transform.DOLocalRotate(Vector3.zero, 1f);
	}

	private void StopEffect()
	{
		currentPS.Stop();
	}

	public void OpenChest()
	{
		MonoSingleton<SoundMgr>.Instance().PlaySound(openSound);
		base.transform.DOLocalRotate(80f * Vector3.forward, 1f).OnComplete(PlayRandomEffect);
	}

	private void PlayRandomEffect()
	{
		float time = 2f;
		ps?.Play();
		int num = UnityEngine.Random.Range(0, 8);
		if (num < randomPS.Length)
		{
			currentPS = randomPS[num];
			currentPS?.Play();
			MonoSingleton<SoundMgr>.Instance().PlaySound(medalSound);
		}
		else if (spawnedIndexes.Count < toys.Count)
		{
			int count = spawnedIndexes.Count;
			Transform transform = UnityEngine.Object.Instantiate(toys[count], spawnPoint.position, toys[count].rotation, MonoSingleton<SpawnPoint>.Instance().GetSpawnPoint());
			if (!MonoSingleton<AccountMgr>.Instance().GetUserProfileData().Contains(toys[count].name))
			{
				MonoSingleton<AccountMgr>.Instance().GetUserProfileData().toys.Add(new Toy(transform.GetInstanceID(), transform.name, toys[count].name, transform.transform.position, transform.transform.rotation.eulerAngles, enabled: false));
				MonoSingleton<AccountMgr>.Instance().UpdateInventory();
			}
			spawnedIndexes.Add(count);
			time = 5f;
		}
		Invoke("CloseChest", time);
	}

	private void PlayEffect()
	{
		ps?.Play();
	}
}
public class Sudoku : MonoBehaviour
{
	private int m_GridSize;

	private int[] m_ValueData;

	public int gridSize => m_GridSize;

	public int[] valueData => m_ValueData;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void GenSimpleSudoku(int n)
	{
		if (n <= 0)
		{
			return;
		}
		m_GridSize = n;
		int num = n * n;
		m_ValueData = new int[num];
		int num2 = 1;
		for (int i = 0; i < m_GridSize; i++)
		{
			int num3 = num2;
			for (int j = 0; j < m_GridSize; j++)
			{
				m_ValueData[i * m_GridSize + j] = num3;
				num3++;
				if (num3 > m_GridSize)
				{
					num3 = 1;
				}
			}
			num2++;
		}
	}

	public void GenSimpleSudokuRand(int n)
	{
		System.Random random = new System.Random();
		GenSimpleSudoku(n);
		int mode = random.Next(2);
		int num = random.Next(m_GridSize);
		int num2 = random.Next(m_GridSize);
		if (num != num2)
		{
			SwapRowOrColumn(mode, num, num2);
		}
	}

	public void SwapRowOrColumn(int mode, int a, int b)
	{
		if (mode == 0)
		{
			SwapRow(a, b);
		}
		if (mode == 1)
		{
			SwapColumn(a, b);
		}
	}

	private void SwapRow(int a, int b)
	{
		for (int i = 0; i < m_GridSize; i++)
		{
			int num = a * m_GridSize;
			int num2 = b * m_GridSize;
			int num3 = m_ValueData[num + i];
			m_ValueData[num + i] = m_ValueData[num2 + i];
			m_ValueData[num2 + i] = num3;
		}
	}

	private void SwapColumn(int a, int b)
	{
		int num = 0;
		for (int i = 0; i < m_GridSize; i++)
		{
			int num2 = m_ValueData[a + num];
			m_ValueData[a + num] = m_ValueData[b + num];
			m_ValueData[b + num] = num2;
			num += m_GridSize;
		}
	}
}
[CreateAssetMenu(menuName = "CreateSudoku")]
public class SudokuInfo : ScriptableObject
{
	public int grade;

	public int size;

	public bool[] ItemVisible;

	public List<Texture> textures;
}
public class SudokuItem : MonoBehaviour
{
	public Texture defaultTexture;

	public Material outline;

	private List<Texture> symbols;

	public int code;

	private Renderer render;

	private bool isVisible;

	private Material item;

	private void Awake()
	{
		render = GetComponent<Renderer>();
		item = render.material;
	}

	public void Change()
	{
		if (!isVisible)
		{
			code++;
			int num = ((MonoSingleton<AccountMgr>.Instance().GetUserProfileData().sudokuGrade > 0) ? 4 : 3);
			if (code > num)
			{
				code = 1;
			}
			updateTexture();
		}
	}

	private Texture GetSymbolTexture(int code)
	{
		if (code == 0)
		{
			return defaultTexture;
		}
		return symbols[code - 1];
	}

	internal void SetItemInfo(int value, bool visible, List<Texture> textures)
	{
		Material[] materials = render.materials;
		isVisible = visible;
		if (isVisible)
		{
			code = value;
			materials[1] = null;
		}
		else
		{
			code = 0;
			materials[1] = outline;
		}
		render.materials = materials;
		symbols = textures;
		updateTexture();
	}

	private void updateTexture()
	{
		render.material.mainTexture = GetSymbolTexture(code);
	}
}
public class SudokuMgr : MonoBehaviour
{
	public static Action<int, int> onUpgrade;

	public SudokuInfo[] levels;

	public bool contentByGrade;

	public UnityEvent OnLevelEnd;

	public GameObject[] groups;

	private List<SudokuInfo> levelsOfGrade;

	private SudokuInfo currentInfo;

	private Sudoku sudoku;

	private SudokuItem[] items;

	private int[] values;

	private int currentGrade;

	private int currentLevel;

	private void Start()
	{
		sudoku = GetComponent<Sudoku>();
		currentGrade = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().sudokuGrade;
		currentLevel = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().sudokuLevel;
		EnableGroups(currentGrade);
		levelsOfGrade = new List<SudokuInfo>();
		levelsOfGrade = GetLevelsOfGrade(currentGrade);
		items = GetComponentsInChildren<SudokuItem>();
		NextLevel();
		MonoSingleton<Instructions>.Instance().Init(LanCode.Sudoku);
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.Sudoku);
	}

	private List<SudokuInfo> GetLevelsOfGrade(int grade)
	{
		levelsOfGrade.Clear();
		for (int i = 0; i < levels.Length; i++)
		{
			if (levels[i].grade == grade)
			{
				levelsOfGrade.Add(levels[i]);
			}
		}
		return levelsOfGrade;
	}

	private void EnableGroups(int grade)
	{
		if (grade == 0)
		{
			groups[0].SetActive(value: true);
			groups[1].SetActive(value: false);
		}
		else
		{
			groups[0].SetActive(value: false);
			groups[1].SetActive(value: true);
		}
	}

	private void NextLevel()
	{
		if (levelsOfGrade.Count == currentLevel)
		{
			currentGrade++;
			EnableGroups(currentGrade);
			items = GetComponentsInChildren<SudokuItem>();
			levelsOfGrade = GetLevelsOfGrade(currentGrade);
			if (!MonoSingleton<AccountMgr>.Instance().GetUserProfileData().sudokuCompleted)
			{
				onUpgrade?.Invoke(currentGrade, currentLevel - 1);
			}
			currentLevel = 0;
		}
		if (levelsOfGrade.Count == 0)
		{
			currentGrade = 0;
			levelsOfGrade = GetLevelsOfGrade(currentGrade);
			EnableGroups(currentGrade);
			items = GetComponentsInChildren<SudokuItem>();
			MonoSingleton<AccountMgr>.Instance().GetUserProfileData().sudokuCompleted = true;
		}
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().sudokuGrade = currentGrade;
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().sudokuLevel = currentLevel;
		MonoSingleton<AccountMgr>.Instance().UpdatePerformance();
		currentInfo = levelsOfGrade[currentLevel];
		SetSudokuItems(currentInfo);
		currentLevel++;
	}

	private void SetSudokuItems(SudokuInfo currentInfo)
	{
		int size = currentInfo.size;
		sudoku.GenSimpleSudokuRand(size);
		values = sudoku.valueData;
		bool[] itemVisible = currentInfo.ItemVisible;
		for (int i = 0; i < items.Length; i++)
		{
			items[i].SetItemInfo(values[i], itemVisible[i], currentInfo.textures);
		}
	}

	public void CheckAnswer()
	{
		bool flag = true;
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].code != values[i])
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			OnLevelEnd?.Invoke();
			if (levelsOfGrade.Count > 0)
			{
				Invoke("NextLevel", 2f);
			}
		}
	}
}
public class SymbolMgr : MonoBehaviour
{
	public TMP_Text leftNum;

	public TMP_Text rightNum;

	public Container symbolContainer;

	private string symbol;

	private List<int> nums;

	private int size = 2;

	private int level;

	private void Start()
	{
		MonoSingleton<Instructions>.Instance().Init(LanCode.Symbol);
		nums = new List<int>();
		NextLevel();
	}

	private void Update()
	{
		if (CheckResult() && !IsInvoking())
		{
			MonoSingleton<VoiceMgr>.Instance().PlayVoice(SLocalization.GetAudio(LanCode.AnswerRight));
			symbolContainer.ClearObjects();
			symbolContainer.Restore();
			Invoke("NextLevel", 0.2f);
		}
	}

	private bool CheckResult()
	{
		List<int> list = GetNums();
		if (!GetSymbol())
		{
			return false;
		}
		return CheckEquation(list);
	}

	private bool GetSymbol()
	{
		if (symbolContainer.GetComponent<Container>().GetObjects().Count > 0)
		{
			symbol = symbolContainer.GetComponent<Container>().GetObjects()[0].name;
			return true;
		}
		return false;
	}

	private List<int> GetNums()
	{
		nums.Clear();
		nums.Add(int.Parse(leftNum.text));
		nums.Add(int.Parse(rightNum.text));
		return nums;
	}

	private bool CheckEquation(List<int> nums)
	{
		if (symbol.Equals(Symbol.LT.ToString()))
		{
			for (int i = 0; i < size - 1; i++)
			{
				if (nums[i] >= nums[i + 1] || nums[i] <= 0)
				{
					return false;
				}
			}
			return true;
		}
		if (symbol.Equals(Symbol.GT.ToString()))
		{
			for (int j = 0; j < size - 1; j++)
			{
				if (nums[j] <= nums[j + 1] || nums[j + 1] <= 0)
				{
					return false;
				}
			}
			return true;
		}
		if (symbol.Equals(Symbol.EQ.ToString()))
		{
			for (int k = 0; k < size - 1; k++)
			{
				if (nums[k] != nums[k + 1] || nums[k] <= 0)
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	private void NextLevel()
	{
		level++;
		if (level == 10)
		{
			MonoSingleton<MedalMgr>.Instance().AddMedal(0, level);
		}
		leftNum.text = UnityEngine.Random.Range(1, 11).ToString();
		rightNum.text = UnityEngine.Random.Range(1, 11).ToString();
	}
}
public class NextLevelButton : SNButton
{
	public static Action onButtonDown;

	private void Update()
	{
		if (isTriggered() && onButtonDown != null)
		{
			onButtonDown();
		}
	}
}
public class Tangram : MonoSingleton<Tangram>
{
	public Dictionary<int, List<List<Vector3>>> answers = new Dictionary<int, List<List<Vector3>>>();

	private string cfg_file = Application.streamingAssetsPath + "/TangramFeatureConfig.txt";

	private float pi = (float)Math.PI;

	protected override void Awake()
	{
		base.Awake();
		Init();
	}

	private void Init()
	{
		StartCoroutine(ReadConfigFile(cfg_file));
	}

	private IEnumerator ReadConfigFile(string filepath)
	{
		using UnityWebRequest webRequest = UnityWebRequest.Get(filepath);
		yield return webRequest.SendWebRequest();
		if (webRequest.isNetworkError)
		{
			UnityEngine.Debug.Log("Config File Error: " + webRequest.error);
			yield break;
		}
		string[] lines = new List<string>(webRequest.downloadHandler.text.Split('\n')).ToArray();
		LoadFeatureVectors(lines);
	}

	private int LoadFeatureVectors(string[] lines)
	{
		for (int i = 0; i < lines.Length; i++)
		{
			if (lines[i].Length == 0)
			{
				continue;
			}
			string[] array = lines[i].Trim().Split();
			if (array.Length != 0 && array.Length == 22)
			{
				int key = int.Parse(array[0]);
				int num = 1;
				List<Vector3> list = new List<Vector3>();
				int num2 = 0;
				while (num2 < 7)
				{
					float x = float.Parse(array[num]);
					float y = float.Parse(array[num + 1]);
					float z = float.Parse(array[num + 2]);
					Vector3 item = new Vector3(x, y, z);
					list.Add(item);
					num2++;
					num += 3;
				}
				if (answers.ContainsKey(key))
				{
					answers[key].Add(list);
					continue;
				}
				List<List<Vector3>> value = new List<List<Vector3>> { list };
				answers.Add(key, value);
			}
		}
		return 0;
	}

	public List<Vector3> GetFeatureVector(Vector3[] positions, float[] rotations)
	{
		List<Vector3> list = new List<Vector3>();
		if (positions.Length != rotations.Length || rotations.Length != 7)
		{
			return list;
		}
		Vector3 to = positions[6] - positions[0];
		for (int i = 0; i < 7; i++)
		{
			float x = Vector3.Distance(positions[0], positions[i]);
			Vector3 vector = positions[i] - positions[0];
			float y = 0f;
			if (vector != Vector3.zero)
			{
				y = Vector3.Angle(vector, to);
			}
			Vector3 item = new Vector3(x, y, rotations[i]);
			list.Add(item);
		}
		return list;
	}

	public int CompareFeatureVector(List<Vector3> fv1, List<Vector3> fv2, Vector3 delta)
	{
		if (fv1.Count != fv2.Count)
		{
			return 1;
		}
		for (int i = 0; i < fv1.Count; i++)
		{
			Vector3 vector = fv1[i];
			Vector3 vector2 = fv2[i];
			if (Mathf.Abs(vector.x - vector2.x) > delta.x)
			{
				return 1;
			}
			if (Mathf.Abs(vector.y - vector2.y) > delta.y)
			{
				return 1;
			}
			if (Mathf.Abs(Mathf.Abs(vector.z) - Mathf.Abs(vector2.z)) > delta.z)
			{
				return 1;
			}
		}
		return 0;
	}

	public int MatchFeatureVector(List<Vector3> fv, List<List<Vector3>> fvList, Vector3 delta)
	{
		for (int i = 0; i < fvList.Count; i++)
		{
			if (CompareFeatureVector(fv, fvList[i], delta) == 0)
			{
				return 1;
			}
		}
		return 0;
	}
}
[CreateAssetMenu(menuName = "CreateTangram")]
public class TangramItem : ScriptableObject
{
	public int grade;

	public int levelOfGrade;

	public Sprite image;

	public Sprite hintImage;
}
public class TangramMgr : MonoBehaviour
{
	public class TangramInfo
	{
		public Vector3[] positions;

		public Vector3[] rotations;
	}

	public TangramItem[] items;

	public AudioClip rightSound;

	public AudioClip wrongSound;

	public static Action<int, int> onUpgrade;

	public static Action<int, int> onAnswerRight;

	public static Action<int, int> onAnswerWrong;

	public Transform[] parts;

	public Vector3 delta;

	private SpriteRenderer spriteRenderer;

	private int currentGrade;

	private int currentLevelOfGrade;

	private string cfgfilepath = Application.streamingAssetsPath + "/TangramConfig.txt";

	private Dictionary<int, Dictionary<int, string>> levels;

	private List<Vector3> feature;

	private bool isChallenge;

	private TangramItem currentItem;

	private bool levelFileLoaded;

	private void Awake()
	{
		spriteRenderer = MonoSingleton<Instructions>.Instance().GetSpriteRenderer();
		MonoSingleton<Instructions>.Instance().Init(LanCode.PlayIntro, null, "");
		AudioClip audio = SLocalization.GetAudio(LanCode.ChallengeIntro);
		MonoSingleton<VoiceMgr>.Instance().PlayVoice(audio);
		currentGrade = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().tangramGrade;
		currentLevelOfGrade = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().tangramLevel;
		Invoke("LoadHint", audio.length + 5f);
	}

	private void LoadHint()
	{
		if (!isChallenge)
		{
			MonoSingleton<Instructions>.Instance().SetText(LanCode.LoadIntro);
			MonoSingleton<VoiceMgr>.Instance().Play(LanCode.LoadIntro);
		}
	}

	private void Start()
	{
		isChallenge = false;
		levels = new Dictionary<int, Dictionary<int, string>>();
		StartCoroutine(InitLevelsFromFile(cfgfilepath));
	}

	private void Update()
	{
	}

	private List<Vector3> GetFeature(Transform[] parts)
	{
		Vector3[] positions = GetPositions(parts);
		float[] localRotations = GetLocalRotations(parts);
		return MonoSingleton<Tangram>.Instance().GetFeatureVector(positions, localRotations);
	}

	private Vector3[] GetPositions(Transform[] parts)
	{
		Vector3[] array = new Vector3[parts.Length];
		for (int i = 0; i < parts.Length; i++)
		{
			array[i] = parts[i].position;
		}
		return array;
	}

	private float[] GetLocalRotations(Transform[] parts)
	{
		float[] array = new float[parts.Length];
		for (int i = 0; i < parts.Length; i++)
		{
			array[i] = parts[i].localRotation.z;
		}
		return array;
	}

	private Vector3[] GetRotations(Transform[] parts)
	{
		Vector3[] array = new Vector3[parts.Length];
		for (int i = 0; i < parts.Length; i++)
		{
			array[i] = parts[i].rotation.eulerAngles;
		}
		return array;
	}

	public TangramInfo GetTangramInfo()
	{
		return new TangramInfo
		{
			positions = GetPositions(parts),
			rotations = GetRotations(parts)
		};
	}

	public void SetTangramInfo(TangramInfo info)
	{
		for (int i = 0; i < parts.Length; i++)
		{
			parts[i].position = info.positions[i];
			parts[i].eulerAngles = info.rotations[i];
		}
	}

	private void InitLevels()
	{
		MonoSingleton<Instructions>.Instance().SetText(LanCode.Tangram);
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.Tangram);
		int num = ((levels.Count > currentGrade) ? levels[currentGrade].Count : 3);
		MonoSingleton<Instructions>.Instance().GetProgressText().text = GetGradeText(currentGrade) + " " + (currentLevelOfGrade + 1) + "/" + num;
		LoadLevel();
	}

	private IEnumerator InitLevelsFromFile(string filepath)
	{
		UnityEngine.Debug.Log("Loading levels from file: " + filepath);
		using UnityWebRequest webRequest = UnityWebRequest.Get(filepath);
		yield return webRequest.SendWebRequest();
		if (webRequest.isNetworkError)
		{
			UnityEngine.Debug.Log("Config File Error: " + webRequest.error);
			yield break;
		}
		UnityEngine.Debug.Log("Config File Received: " + webRequest.downloadHandler.text);
		string[] lines = new List<string>(webRequest.downloadHandler.text.Split('\n')).ToArray();
		DoInitLevels(lines);
		levelFileLoaded = true;
	}

	private void DoInitLevels(string[] lines)
	{
		for (int i = 0; i < lines.Length; i++)
		{
			string text = lines[i].Trim();
			if (text.Length == 0)
			{
				continue;
			}
			if (text.Length == 1)
			{
				int num = 0;
				try
				{
					num = int.Parse(text);
				}
				catch (Exception)
				{
					UnityEngine.Debug.LogError("Parse tangram config file error");
					break;
				}
				levels.Add(num, new Dictionary<int, string>());
			}
			if (text.Length > 1)
			{
				Dictionary<int, string> dictionary = levels[levels.Count - 1];
				dictionary.Add(dictionary.Count, text);
			}
		}
	}

	public void SetNextLevel()
	{
		if (levels.Count == 0)
		{
			return;
		}
		currentLevelOfGrade++;
		if (currentLevelOfGrade == levels[currentGrade].Count)
		{
			currentGrade++;
			currentLevelOfGrade = 0;
			if (!MonoSingleton<AccountMgr>.Instance().GetUserProfileData().tangramCompleted)
			{
				onUpgrade?.Invoke(currentGrade, currentLevelOfGrade);
			}
		}
		if (currentGrade == levels.Count)
		{
			currentGrade = 0;
			MonoSingleton<AccountMgr>.Instance().GetUserProfileData().tangramCompleted = true;
		}
		MonoSingleton<Instructions>.Instance().GetProgressText().text = GetGradeText(currentGrade) + " " + (currentLevelOfGrade + 1) + "/" + levels[currentGrade].Count;
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().tangramGrade = currentGrade;
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().tangramLevel = currentLevelOfGrade;
		MonoSingleton<AccountMgr>.Instance().UpdatePerformance();
	}

	private string GetGradeText(int currentGrade)
	{
		return currentGrade switch
		{
			0 => ISILocalization.GetValueOf(LanCode.Basic), 
			1 => ISILocalization.GetValueOf(LanCode.Junior), 
			2 => ISILocalization.GetValueOf(LanCode.Senior), 
			_ => "", 
		};
	}

	public void OnButtonDown()
	{
		if (!isChallenge)
		{
			isChallenge = true;
			InitLevels();
			return;
		}
		if (CheckResult() != 0)
		{
			MonoSingleton<VoiceMgr>.Instance().Play(LanCode.AnswerWrong);
			MonoSingleton<SoundMgr>.Instance().PlaySound(wrongSound, parts[0].position);
			onAnswerWrong?.Invoke(currentGrade, currentLevelOfGrade);
			return;
		}
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.AnswerRight);
		MonoSingleton<SoundMgr>.Instance().PlaySound(rightSound, parts[0].position);
		onAnswerRight?.Invoke(currentGrade, currentLevelOfGrade);
		SetNextLevel();
		LoadLevel();
		if (currentGrade == 0 && currentLevelOfGrade == 1)
		{
			Invoke("TakePictureHint", SLocalization.GetAudio(LanCode.AnswerRight).length + 0.5f);
		}
	}

	private void TakePictureHint()
	{
		MonoSingleton<VoiceMgr>.Instance().Play(LanCode.TakePicture);
	}

	private void LoadLevel()
	{
		if (!levelFileLoaded)
		{
			Invoke("LoadLevel", 0.5f);
			return;
		}
		string text = levels[currentGrade][currentLevelOfGrade];
		if (text != null && text.Length != 0)
		{
			currentItem = GetTangramItem(text);
			if (currentItem != null)
			{
				spriteRenderer.sprite = currentItem.image;
			}
		}
	}

	private TangramItem GetTangramItem(string name)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].name.Equals(name))
			{
				return items[i];
			}
		}
		return null;
	}

	private int CheckResult()
	{
		List<List<Vector3>> fvList = ((MonoSingleton<Tangram>.Instance().answers.Count > CaculateIndex()) ? MonoSingleton<Tangram>.Instance().answers[CaculateIndex()] : new List<List<Vector3>>());
		if (MonoSingleton<Tangram>.Instance().MatchFeatureVector(GetFeature(parts), fvList, delta) == 1)
		{
			return 0;
		}
		return 1;
	}

	private int CaculateIndex()
	{
		int num = 0;
		for (int i = 0; i < currentGrade; i++)
		{
			num += levels[i].Count;
		}
		return num + currentLevelOfGrade;
	}

	public void DisplayHint()
	{
		if (currentItem == null)
		{
			LoadLevel();
			return;
		}
		Sprite hintImage = currentItem.hintImage;
		if (hintImage != null)
		{
			spriteRenderer.sprite = hintImage;
		}
	}

	private void OnDestroy()
	{
		NextLevelButton.onButtonDown = (Action)Delegate.Remove(NextLevelButton.onButtonDown, new Action(OnButtonDown));
		HintButton.onButtonDown = (Action)Delegate.Remove(HintButton.onButtonDown, new Action(DisplayHint));
	}
}
public class AbsorbController : MonoBehaviour
{
	[SerializeField]
	internal InputHandler.ControllerType controller;

	public Transform origin;

	public Transform prefab;

	private Transform hintObj;

	private Interactor grabber;

	private Vector3 hintObjPos;

	private Vector3 extents;

	private Interactable grabbable;

	private Material guidingMaterial;

	private GridsMgr gridsMgr;

	private void Start()
	{
		gridsMgr = GetComponent<GridsMgr>();
		grabber = MonoSingleton<InputHandler>.Instance().GetInteractor(controller);
		guidingMaterial = Resources.Load<Material>("TransparentCube");
		hintObj = UnityEngine.Object.Instantiate(prefab, origin.position, Quaternion.identity, origin);
		hintObj.GetComponent<Collider>().enabled = false;
		hintObj.GetComponent<Renderer>().material = guidingMaterial;
		hintObj.GetComponent<Renderer>().enabled = false;
		extents = 0.5f * hintObj.localScale;
	}

	private void Update()
	{
		Vector3[] gridCoords = gridsMgr.GetGridCoords();
		int[] currentGrids = gridsMgr.GetCurrentGrids();
		if (grabber.interactedObject != null && grabber.interactedObject.name.Contains("Cube"))
		{
			grabbable = grabber.interactedObject;
			grabbable.transform.parent = origin;
			UpdateGrid();
			DisplayHintCube(gridCoords, currentGrids);
		}
		else
		{
			AbsorbGrid(gridCoords, currentGrids);
		}
	}

	private void UpdateGrid()
	{
		gridsMgr.RemoveCube(grabbable.transform);
	}

	private void AbsorbGrid(Vector3[] gridCoords, int[] currentGrids)
	{
		if (!(grabbable == null))
		{
			grabbable.transform.parent = origin;
			int gridIndex = GetGridIndex(gridCoords);
			if (gridIndex >= 0 && grabbable.transform.localPosition.y - (float)(currentGrids[gridIndex] * 2) * extents.y < 2f * extents.y && grabbable.transform.localPosition.y - (float)(currentGrids[gridIndex] * 2) * extents.y > 0f - extents.y)
			{
				hintObjPos.Set((float)(gridIndex / 4 * 2) * extents.x, (float)(currentGrids[gridIndex] * 2) * extents.y, (float)(gridIndex % 4 * 2) * extents.z);
				grabbable.transform.localPosition = hintObjPos;
				grabbable.transform.localRotation = Quaternion.identity;
				grabbable.GetComponent<Rigidbody>().isKinematic = true;
				hintObj.GetComponent<Renderer>().enabled = false;
				gridsMgr.AddCube(gridIndex, grabbable);
				currentGrids[gridIndex]++;
				grabbable = null;
			}
		}
	}

	private void DisplayHintCube(Vector3[] gridCoords, int[] currentGrids)
	{
		int gridIndex = GetGridIndex(gridCoords);
		if (gridIndex < 0)
		{
			hintObj.GetComponent<Renderer>().enabled = false;
		}
		else if (grabbable.transform.localPosition.y - (float)(currentGrids[gridIndex] * 2) * extents.y < 2f * extents.y && grabbable.transform.localPosition.y - (float)(currentGrids[gridIndex] * 2) * extents.y > 0f - extents.y)
		{
			hintObjPos.Set((float)(gridIndex / 4 * 2) * extents.x, (float)(currentGrids[gridIndex] * 2) * extents.y, (float)(gridIndex % 4 * 2) * extents.z);
			hintObj.transform.localPosition = hintObjPos;
			hintObj.transform.localRotation = Quaternion.identity;
			hintObj.GetComponent<Renderer>().enabled = true;
		}
	}

	private int GetGridIndex(Vector3[] gridCoords)
	{
		for (int i = 0; i < gridCoords.Length; i++)
		{
			if (Math.Abs((float)(i / 4 * 2) * extents.x - grabbable.transform.localPosition.x) < extents.x && Math.Abs((float)(i % 4 * 2) * extents.z - grabbable.transform.localPosition.z) < extents.z)
			{
				return i;
			}
		}
		return -1;
	}
}
public class GridsMgr : MonoBehaviour
{
	public int gridSize = 4;

	public Transform origin;

	public Transform prefab;

	private int[] currentGrids;

	private Vector3[] gridCoords;

	private float scale = 0.2f;

	private Dictionary<int, List<Transform>> cubes;

	private void Awake()
	{
		ContentLoader.OnAnimationCompleted = (Action)Delegate.Combine(ContentLoader.OnAnimationCompleted, new Action(InitCoordinates));
		InitCoordinates();
	}

	public int[] GetCurrentGrids()
	{
		return currentGrids;
	}

	internal void SetCurrentGrids(int[] gridsInfo)
	{
		currentGrids = gridsInfo;
	}

	public Vector3[] GetGridCoords()
	{
		return gridCoords;
	}

	internal void GenerateCubes(int[] gridsInfo)
	{
		Clear();
		currentGrids = gridsInfo;
		int num = 0;
		for (int i = 0; i < gridSize; i++)
		{
			for (int j = 0; j < gridSize; j++)
			{
				int num2 = currentGrids[num];
				for (int k = 0; k < num2; k++)
				{
					Transform transform = UnityEngine.Object.Instantiate(prefab, origin, worldPositionStays: false);
					float x = transform.localScale.x * (float)i;
					float y = transform.localScale.y * (float)k;
					float z = transform.localScale.z * (float)j;
					Vector3 vector2 = (transform.localPosition = new Vector3(x, y, z));
					transform.localRotation = Quaternion.identity;
					transform.GetComponent<Rigidbody>().isKinematic = true;
					if (k == 0)
					{
						gridCoords[num] = vector2;
					}
					cubes[num].Add(transform);
				}
				num++;
			}
		}
	}

	private void OnDestroy()
	{
		ContentLoader.OnAnimationCompleted = (Action)Delegate.Remove(ContentLoader.OnAnimationCompleted, new Action(InitCoordinates));
	}

	private void Start()
	{
		currentGrids = new int[gridSize * gridSize];
		cubes = new Dictionary<int, List<Transform>>();
		for (int i = 0; i < gridSize * gridSize; i++)
		{
			cubes.Add(i, new List<Transform>());
		}
	}

	private void InitCoordinates()
	{
		gridCoords = new Vector3[gridSize * gridSize];
		int num = 0;
		for (int i = 0; i < gridSize; i++)
		{
			for (int j = 0; j < gridSize; j++)
			{
				int num2 = 1;
				for (int k = 0; k < num2; k++)
				{
					float x = scale * (float)i;
					float y = scale * (float)k;
					float z = scale * (float)j;
					gridCoords[num] = new Vector3(x, y, z);
					num++;
				}
			}
		}
	}

	internal void RemoveCube(Transform transform)
	{
		for (int i = 0; i < cubes.Count; i++)
		{
			if (cubes[i].Contains(transform))
			{
				cubes[i].Remove(transform);
				currentGrids[i]--;
			}
		}
	}

	public void AddCube(int index, Interactable grabbable)
	{
		if (cubes[index] == null)
		{
			cubes[index] = new List<Transform>();
		}
		cubes[index].Add(grabbable.transform);
	}

	public void Clear()
	{
		for (int i = 0; i < cubes.Count; i++)
		{
			Framework.Singleton<ObjectsUtil>.Instance.Destroy(cubes[i], 0f);
			cubes[i].Clear();
		}
		for (int j = 0; j < currentGrids.Length; j++)
		{
			currentGrids[j] = 0;
		}
	}

	public int[] GetCubeTopView(int n, int[] gridconf)
	{
		int num = n * n;
		int[] array = new int[num];
		if (num != gridconf.Length)
		{
			return array;
		}
		for (int i = 0; i < num; i++)
		{
			if (gridconf[i] > 0)
			{
				array[i] = 1;
			}
			else
			{
				array[i] = 0;
			}
		}
		return array;
	}

	public int[] GetCubeFrontView(int n, int[] gridconf)
	{
		int num = n * n;
		int[] array = new int[num];
		if (num != gridconf.Length)
		{
			return array;
		}
		int[] array2 = new int[n];
		for (int i = 0; i < num; i++)
		{
			if (gridconf[i] <= 0)
			{
				continue;
			}
			int num2 = i / n;
			if (gridconf[i] > array2[num2])
			{
				int num3 = gridconf[i];
				if (gridconf[i] > n)
				{
					UnityEngine.Debug.LogWarning("cube height exceeds grid dimension!: " + i + ", " + gridconf[i]);
					num3 = n;
				}
				for (int j = array2[num2]; j < num3; j++)
				{
					array[j * n + num2] = 1;
				}
				array2[num2] = gridconf[i];
			}
		}
		return array;
	}

	public int[] GetCubeSideView(int n, int[] gridconf)
	{
		int num = n * n;
		int[] array = new int[num];
		if (num != gridconf.Length)
		{
			return array;
		}
		int[] array2 = new int[n];
		for (int i = 0; i < num; i++)
		{
			if (gridconf[i] <= 0)
			{
				continue;
			}
			int num2 = i % n;
			if (gridconf[i] > array2[num2])
			{
				int num3 = gridconf[i];
				if (gridconf[i] > n)
				{
					UnityEngine.Debug.LogWarning("cube height exceeds grid dimension!: " + i + ", " + gridconf[i]);
					num3 = n;
				}
				for (int j = array2[num2]; j < num3; j++)
				{
					array[j * n + num2] = 1;
				}
				array2[num2] = gridconf[i];
			}
		}
		return array;
	}

	private int GetMaxLayerRaw(int[] gridconf)
	{
		int num = 0;
		for (int i = 0; i < gridconf.Length; i++)
		{
			if (gridconf[i] > num)
			{
				num = gridconf[i];
			}
		}
		return num;
	}
}
public class ThreeViewMgr : MonoBehaviour
{
	public Sprite rightHint;

	public Sprite wrongHint;

	public AudioClip answerright;

	public AudioClip answerwrong;

	public AudioClip rightSound;

	public AudioClip wrongSound;

	public Sprite[] sprites;

	private int index;

	private SpriteRenderer spriteRenderer;

	private GridsMgr gridsMgr;

	private Dictionary<int, int> levels;

	private int currentGrade;

	private int currentLevelOfGrade;

	private int errorCode;

	private SpriteRenderer[] resultHints;

	private bool isChallenge;

	public static Action<int, int> onUpgrade;

	public static Action<int, int> onAnswerRight;

	public static Action<int, int> onAnswerWrong;

	private float lastTime;

	private void Awake()
	{
		gridsMgr = GetComponent<GridsMgr>();
		InitLevelConfigs();
	}

	private void InitLevelConfigs()
	{
		levels = new Dictionary<int, int>();
		levels.Add(0, 3);
		levels.Add(1, 3);
		levels.Add(2, 3);
		string cfgfilepath = Application.streamingAssetsPath + "/ThreeViewConfig.txt";
		MonoSingleton<CubeConfigFileHelper>.Instance().InitLevels(cfgfilepath);
		currentGrade = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().threeviewGrade;
		currentLevelOfGrade = MonoSingleton<AccountMgr>.Instance().GetUserProfileData().threeviewLevel;
		index = CaculateIndex();
	}

	private void Start()
	{
		isChallenge = false;
		lastTime = Time.time;
		spriteRenderer = MonoSingleton<Instructions>.Instance().GetSpriteRenderer();
		resultHints = MonoSingleton<Instructions>.Instance().GetThreeViewSprites();
		MonoSingleton<Instructions>.Instance().Init(LanCode.PlayIntro, null, "");
		AudioClip audio = SLocalization.GetAudio(LanCode.ChallengeIntro);
		MonoSingleton<VoiceMgr>.Instance().PlayVoice(audio);
		Invoke("LoadHint", audio.length + 5f);
	}

	private void LoadHint()
	{
		if (!isChallenge)
		{
			MonoSingleton<Instructions>.Instance().SetText(LanCode.LoadIntro);
			MonoSingleton<VoiceMgr>.Instance().Play(LanCode.LoadIntro);
		}
	}

	private void InitLevel()
	{
		LoadLevel(index);
		if (index == 0)
		{
			MonoSingleton<Instructions>.Instance().SetText(LanCode.ThreeViewIntro);
			MonoSingleton<VoiceMgr>.Instance().Play(LanCode.ThreeViewIntro);
		}
		else
		{
			MonoSingleton<Instructions>.Instance().SetText(LanCode.ThreeView);
			MonoSingleton<VoiceMgr>.Instance().Play(LanCode.ThreeView);
		}
	}

	public void OnButtonDown()
	{
		if (!(Time.time - lastTime < 0.5f))
		{
			lastTime = Time.time;
			if (!isChallenge)
			{
				isChallenge = true;
				InitLevel();
				return;
			}
			if (!CheckResult(index))
			{
				MonoSingleton<VoiceMgr>.Instance().Play(LanCode.AnswerWrong);
				onAnswerWrong?.Invoke(currentGrade, currentLevelOfGrade);
				MonoSingleton<SoundMgr>.Instance().PlaySound(wrongSound, MonoSingleton<SpawnPoint>.Instance().GetSpawnPoint().position);
				return;
			}
			MonoSingleton<VoiceMgr>.Instance().Play(LanCode.AnswerRight);
			MonoSingleton<SoundMgr>.Instance().PlaySound(rightSound, MonoSingleton<SpawnPoint>.Instance().GetSpawnPoint().position);
			onAnswerRight?.Invoke(currentGrade, currentLevelOfGrade);
			SetNextLevel();
			index = CaculateIndex();
			gridsMgr.Clear();
			LoadLevel(index);
		}
	}

	public void Reset()
	{
		gridsMgr.Clear();
		LoadLevel(index);
	}

	private int CaculateIndex()
	{
		int num = 0;
		for (int i = 0; i < currentGrade; i++)
		{
			num += levels[i];
		}
		return num + currentLevelOfGrade;
	}

	private void SetNextLevel()
	{
		if (levels.Count == 0)
		{
			return;
		}
		currentLevelOfGrade++;
		if (currentLevelOfGrade == levels[currentGrade])
		{
			currentGrade++;
			currentLevelOfGrade = 0;
			if (!MonoSingleton<AccountMgr>.Instance().GetUserProfileData().threeviewCompleted)
			{
				onUpgrade?.Invoke(currentGrade, currentLevelOfGrade);
			}
		}
		if (currentGrade == levels.Count)
		{
			currentGrade = 0;
			MonoSingleton<AccountMgr>.Instance().GetUserProfileData().threeviewCompleted = true;
		}
		MonoSingleton<Instructions>.Instance().GetProgressText().text = GetGradeText(currentGrade) + " " + (currentLevelOfGrade + 1) + "/" + levels[currentGrade];
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().threeviewGrade = currentGrade;
		MonoSingleton<AccountMgr>.Instance().GetUserProfileData().threeviewLevel = currentLevelOfGrade;
		MonoSingleton<AccountMgr>.Instance().UpdatePerformance();
	}

	private string GetGradeText(int currentGrade)
	{
		return currentGrade switch
		{
			0 => ISILocalization.GetValueOf(LanCode.Basic), 
			1 => ISILocalization.GetValueOf(LanCode.Junior), 
			2 => ISILocalization.GetValueOf(LanCode.Senior), 
			_ => "", 
		};
	}

	private void LoadLevel(int level)
	{
		MonoSingleton<Instructions>.Instance().SetText(LanCode.ThreeView);
		MonoSingleton<Instructions>.Instance().GetProgressText().text = GetGradeText(currentGrade) + " " + (currentLevelOfGrade + 1) + "/" + levels[currentGrade];
		spriteRenderer.sprite = sprites[level];
		if (level == 0)
		{
			int[] gridsInfo = new int[16]
			{
				0, 0, 0, 0, 1, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0
			};
			gridsMgr.GenerateCubes(gridsInfo);
		}
	}

	private bool CheckResult(int level)
	{
		bool flag = true;
		errorCode = 0;
		int[] level2 = MonoSingleton<CubeConfigFileHelper>.Instance().GetLevel(level);
		int[] currentGrids = gridsMgr.GetCurrentGrids();
		if (level2.Length != currentGrids.Length)
		{
			errorCode = -1;
			return false;
		}
		for (int i = 0; i < currentGrids.Length; i++)
		{
			if (currentGrids[i] != level2[i])
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			DisplayThreeViewResult(level2, currentGrids);
		}
		return flag;
	}

	private void DisplayThreeViewResult(int[] expected, int[] actual)
	{
		int n = 4;
		resultHints[0].sprite = ((CompareIntArray(gridsMgr.GetCubeTopView(n, expected), gridsMgr.GetCubeTopView(n, actual)) == 0) ? rightHint : wrongHint);
		resultHints[1].sprite = ((CompareIntArray(gridsMgr.GetCubeFrontView(n, expected), gridsMgr.GetCubeFrontView(n, actual)) == 0) ? rightHint : wrongHint);
		resultHints[2].sprite = ((CompareIntArray(gridsMgr.GetCubeSideView(n, expected), gridsMgr.GetCubeSideView(n, actual)) == 0) ? rightHint : wrongHint);
		Invoke("ResetResultHints", answerwrong.length + 0.5f);
	}

	private void ResetResultHints()
	{
		MonoSingleton<Instructions>.Instance().ResetThreeViewSprites();
	}

	private int CompareIntArray(int[] a, int[] b)
	{
		if (a.Length != b.Length)
		{
			return 1;
		}
		for (int i = 0; i < a.Length; i++)
		{
			if (a[i] != b[i])
			{
				return 1;
			}
		}
		return 0;
	}
}
public class VendingController : MonoBehaviour
{
	public AudioClip sound;

	private ButtonInteractable[] buttons;

	private void Start()
	{
		buttons = GetComponentsInChildren<ButtonInteractable>();
		for (int i = 0; i < buttons.Length; i++)
		{
			buttons[i].Enabled(isEnabled: false);
		}
		for (int j = 0; j < buttons.Length; j++)
		{
			buttons[j].Enabled(isEnabled: true);
		}
	}

	public void OnDragBegin()
	{
		for (int i = 0; i < buttons.Length; i++)
		{
			buttons[i].Enabled(isEnabled: false);
		}
		MonoSingleton<SoundMgr>.Instance().PlaySound(sound, base.transform.position);
	}

	public void OnDragEnd()
	{
		for (int i = 0; i < buttons.Length; i++)
		{
			buttons[i].Enabled(isEnabled: true);
		}
		MonoSingleton<SoundMgr>.Instance().StopSound(sound);
	}
}
public class CFX_AutoRotate : MonoBehaviour
{
	public Vector3 rotation;

	public Space space = Space.Self;

	private void Update()
	{
		base.transform.Rotate(rotation * Time.deltaTime, space);
	}
}
[RequireComponent(typeof(Light))]
public class CFX_LightFlicker : MonoBehaviour
{
	public bool loop;

	public float smoothFactor = 1f;

	public float addIntensity = 1f;

	private float minIntensity;

	private float maxIntensity;

	private float baseIntensity;

	private void Awake()
	{
		baseIntensity = GetComponent<Light>().intensity;
	}

	private void OnEnable()
	{
		minIntensity = baseIntensity;
		maxIntensity = minIntensity + addIntensity;
	}

	private void Update()
	{
		GetComponent<Light>().intensity = Mathf.Lerp(minIntensity, maxIntensity, Mathf.PerlinNoise(Time.time * smoothFactor, 0f));
	}
}
[RequireComponent(typeof(Light))]
public class CFX_LightIntensityFade : MonoBehaviour
{
	public float duration = 1f;

	public float delay;

	public float finalIntensity;

	private float baseIntensity;

	public bool autodestruct;

	private float p_lifetime;

	private float p_delay;

	private void Start()
	{
		baseIntensity = GetComponent<Light>().intensity;
	}

	private void OnEnable()
	{
		p_lifetime = 0f;
		p_delay = delay;
		if (delay > 0f)
		{
			GetComponent<Light>().enabled = false;
		}
	}

	private void Update()
	{
		if (p_delay > 0f)
		{
			p_delay -= Time.deltaTime;
			if (p_delay <= 0f)
			{
				GetComponent<Light>().enabled = true;
			}
		}
		else if (p_lifetime / duration < 1f)
		{
			GetComponent<Light>().intensity = Mathf.Lerp(baseIntensity, finalIntensity, p_lifetime / duration);
			p_lifetime += Time.deltaTime;
		}
		else if (autodestruct)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
namespace Framework
{
	public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
	{
		private static T instance;

		public static T Instance()
		{
			return instance;
		}

		private static void SetInstance(T value)
		{
			instance = value;
		}

		protected virtual void Awake()
		{
			if (Instance() == null)
			{
				SetInstance((T)this);
			}
			else
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
	}
	public class Singleton<T> where T : class
	{
		private static T _instance;

		private static readonly object SyncObject = new object();

		public static T Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (SyncObject)
					{
						if (_instance == null)
						{
							_instance = (T)Activator.CreateInstance(typeof(T), nonPublic: true);
						}
					}
				}
				return _instance;
			}
		}
	}
}
namespace Framework.Utility
{
	public static class SerializeTool
	{
		public static byte[] BinarySerialize<T>(this T obj) where T : class
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			MemoryStream memoryStream = new MemoryStream();
			binaryFormatter.Serialize(memoryStream, obj);
			byte[] buffer = memoryStream.GetBuffer();
			memoryStream.Close();
			return buffer;
		}

		public static T BinaryDeserialize<T>(this byte[] bytes) where T : class
		{
			T result = null;
			if (bytes == null)
			{
				return result;
			}
			MemoryStream memoryStream = new MemoryStream(bytes);
			memoryStream.Position = 0L;
			result = new BinaryFormatter().Deserialize(memoryStream) as T;
			memoryStream.Close();
			return result;
		}

		public static bool SerializeXML(string path, object obj)
		{
			if (string.IsNullOrEmpty(path))
			{
				return false;
			}
			if (obj == null)
			{
				return false;
			}
			using FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
			new XmlSerializer(obj.GetType()).Serialize(stream, obj);
			return true;
		}

		public static object DeserializeXML<T>(string path)
		{
			if (string.IsNullOrEmpty(path))
			{
				return null;
			}
			using (FileStream stream = new FileInfo(path).OpenRead())
			{
				object obj = new XmlSerializer(typeof(T)).Deserialize(stream);
				if (obj != null)
				{
					return obj;
				}
			}
			return null;
		}

		public static string ToJson<T>(this T obj)
		{
			return JsonConvert.SerializeObject(obj);
		}

		public static T FromJson<T>(this string json)
		{
			return JsonConvert.DeserializeObject<T>(json);
		}

		public static byte[] StructToBytes(object a, int size)
		{
			byte[] array = new byte[size];
			IntPtr intPtr = Marshal.AllocHGlobal(size);
			Marshal.StructureToPtr(a, intPtr, fDeleteOld: false);
			Marshal.Copy(intPtr, array, 0, size);
			Marshal.FreeHGlobal(intPtr);
			return array;
		}

		public static byte[] StructToBytes<T>(T obj)
		{
			int num = Marshal.SizeOf(typeof(T));
			byte[] array = new byte[num];
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr(obj, intPtr, fDeleteOld: false);
			Marshal.Copy(intPtr, array, 0, num);
			Marshal.FreeHGlobal(intPtr);
			return array;
		}

		public static object BytesToStruct(byte[] bytes, Type type)
		{
			int num = Marshal.SizeOf(type);
			if (num > bytes.Length)
			{
				return null;
			}
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(bytes, 0, intPtr, num);
			object result = Marshal.PtrToStructure(intPtr, type);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public static T BytesToStruct<T>(byte[] bytes) where T : struct
		{
			Type typeFromHandle = typeof(T);
			int num = Marshal.SizeOf(typeFromHandle);
			if (num > bytes.Length)
			{
				return new T();
			}
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(bytes, 0, intPtr, num);
			object obj = Marshal.PtrToStructure(intPtr, typeFromHandle);
			Marshal.FreeHGlobal(intPtr);
			return (T)obj;
		}
	}
}
namespace HoloToolkit.Unity
{
	public enum PivotAxis
	{
		Free,
		Y
	}
	public class Billboard : MonoBehaviour
	{
		[Tooltip("Specifies the axis about which the object will rotate.")]
		public PivotAxis PivotAxis;

		[Tooltip("Specifies the target we will orient to. If no Target is specified the main camera will be used.")]
		private Transform TargetTransform;

		private void OnEnable()
		{
			if (TargetTransform == null)
			{
				TargetTransform = Camera.main.transform;
			}
			Update();
		}

		private void Update()
		{
			if (!(TargetTransform == null))
			{
				Vector3 vector = TargetTransform.position - base.transform.position;
				PivotAxis pivotAxis = PivotAxis;
				if (pivotAxis != 0 && pivotAxis == PivotAxis.Y)
				{
					vector.y = 0f;
				}
				if (!(vector.sqrMagnitude < 0.001f))
				{
					base.transform.rotation = Quaternion.LookRotation(-vector);
				}
			}
		}
	}
}
namespace BoundarySystem_Ext
{
	internal static class Pvr_BoundaryAPI
	{
		private const string LibFileName = "Pvr_UnitySDK";

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_StartSDKBoundary();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_ShutdownSDKBoundary();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetMainSensorStateExt(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr Pvr_GetCameraData_Ext();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_ResetVrModebyForce();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_ResumeBoundaryForSTS();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_PauseBoundaryForSTS();

		public static int UPvr_GetMainSensorStateExt(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber)
		{
			return Pvr_GetMainSensorStateExt(ref x, ref y, ref z, ref w, ref px, ref py, ref pz, ref vfov, ref hfov, ref viewNumber);
		}

		public static IntPtr UPvr_GetCameraData_Ext()
		{
			_ = IntPtr.Zero;
			return Pvr_GetCameraData_Ext();
		}

		public static bool UPvr_ResumeBoundaryForSTS()
		{
			return Pvr_ResumeBoundaryForSTS();
		}

		public static void UPvr_PauseBoundaryForSTS()
		{
			Pvr_PauseBoundaryForSTS();
		}

		public static IntPtr StructToIntPtr<T>(T info)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(info));
			Marshal.StructureToPtr(info, intPtr, fDeleteOld: true);
			return intPtr;
		}

		public static T IntPtrToStruct<T>(IntPtr info)
		{
			return (T)Marshal.PtrToStructure(info, typeof(T));
		}
	}
	internal static class Pvr_SafeAreaAlgoAPI
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SafeAreaCallback(IntPtr lineCollectionPtr, IntPtr safeAreaRectPtr);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SafeAreaCallbackShrink(IntPtr lineCollectionPtr, IntPtr safeAreaDetailRectPtr);

		public struct GSAPoint3i
		{
			public int x;

			public int y;

			public int z;
		}

		public struct GSALine
		{
			public IntPtr pointArray;

			public int pointCount;
		}

		public struct GSALineCollection
		{
			public IntPtr lineArray;

			public int lineCount;
		}

		public struct GSALegalData
		{
			public int overMaxRange;

			public int includeBigGrap;

			public int bigGapNum;

			public int centerOut;

			public int removeNarrow;

			public int overMaxRange_more;

			public int validShrinkArea;
		}

		public struct GSARect
		{
			public GSAPoint3i leftup;

			public GSAPoint3i leftdown;

			public GSAPoint3i rightup;

			public GSAPoint3i rightdown;

			public GSAPoint3i center;

			public uint width;

			public uint height;

			public int isLegal;

			public GSALegalData legalData;
		}

		private const string LibFileName = "SafetyArea";

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSAInit(int width, int height);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSAShutDown();

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSASetCallback(SafeAreaCallback cb);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSASetCallbackShrink(SafeAreaCallbackShrink cb);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSAUpDateData(IntPtr lineCollectionPtr);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSASetConfigFilePath(IntPtr configPath);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool GSAGetClosedAreaUpdateFlag();

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSALoadSafetyArea(IntPtr lineCollectionPtr);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern double GSABoundaryDetector(ref GSAPoint3i pointPtr);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSALoadSafetyArea2(IntPtr lineCollectionPtr, bool isPlayArea);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern double GSABoundaryDetector2(ref GSAPoint3i point, bool isPlayArea, ref GSAPoint3i closestPoint, ref GSAPoint3i normalDir);

		public static int Pvr_GSAInit(int width, int height)
		{
			return GSAInit(width, height);
		}

		public static int Pvr_GSASetCallback(SafeAreaCallback cb)
		{
			return GSASetCallback(cb);
		}

		public static int Pvr_GSASetCallbackShrink(SafeAreaCallbackShrink cb)
		{
			return GSASetCallbackShrink(cb);
		}

		public static int Pvr_GSAUpDateData(IntPtr lineCollectionPtr)
		{
			return GSAUpDateData(lineCollectionPtr);
		}

		public static bool Pvr_GSAGetClosedAreaUpdateFlag()
		{
			return GSAGetClosedAreaUpdateFlag();
		}

		public static int Pvr_GSASetConfigFilePath(string configPath)
		{
			int num = -1;
			IntPtr intPtr = Marshal.StringToHGlobalAnsi(configPath);
			num = GSASetConfigFilePath(intPtr);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		public static int Pvr_GSALoadSafetyArea(IntPtr lineCollectionPtr)
		{
			return GSALoadSafetyArea(lineCollectionPtr);
		}

		public static double Pvr_GSABoundaryDetector(ref GSAPoint3i point)
		{
			return GSABoundaryDetector(ref point);
		}

		public static int Pvr_GSAShutDown()
		{
			return GSAShutDown();
		}

		public static int Pvr_GSALoadSafetyArea2(IntPtr lineCollectionPtr, bool isPlayArea)
		{
			return GSALoadSafetyArea2(lineCollectionPtr, isPlayArea);
		}

		public static double Pvr_GSABoundaryDetector2(ref GSAPoint3i point, bool isPlayArea, ref GSAPoint3i closestPoint, ref GSAPoint3i normalDir)
		{
			return GSABoundaryDetector2(ref point, isPlayArea, ref closestPoint, ref normalDir);
		}
	}
	public class Pvr_BoundarySystem
	{
		private static Pvr_BoundarySystem instance;

		public const int CameraImageWidth = 1280;

		public const int CameraImageHeight = 400;

		public IntPtr CameraFramePtr = IntPtr.Zero;

		public static Pvr_BoundarySystem Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Pvr_BoundarySystem();
				}
				return instance;
			}
		}

		public void OpenBoundary()
		{
			Pvr_BoundaryAPI.Pvr_StartSDKBoundary();
		}

		public void CloseBoundary()
		{
			Pvr_BoundaryAPI.Pvr_ShutdownSDKBoundary();
		}

		public void Reset6Dof()
		{
			Pvr_BoundaryAPI.Pvr_ResetVrModebyForce();
		}

		public float[] GetControllerFixedPoseData(int hand)
		{
			float[] result = new float[7] { 0f, 0f, 0f, 1f, 0f, 0f, 0f };
			if (Pvr_ControllerManager.controllerlink != null)
			{
				Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, Pvr_ControllerManager.controllerlink.javaCVClass, "getControllerFixedSensorState", hand);
			}
			result[2] = 0f - result[2];
			result[3] = 0f - result[3];
			return result;
		}
	}
	public class Pvr_SafeAreaAlgoModule
	{
		public struct ExtraInfo
		{
			public bool overMaxRange;

			public bool includeBigGap;

			public int bigGapNum;

			public bool centerOut;

			public bool removeNarrow;

			public bool overMaxRange_more;

			public int validShrinkArea;
		}

		public struct BoundaryPlayerArea
		{
			public Vector3 lowerleft;

			public Vector3 upperleft;

			public Vector3 upperRight;

			public Vector3 lowerRight;

			public Vector3 center;

			public uint width;

			public uint height;

			public bool isLegal;

			public ExtraInfo extraInfo;
		}

		public delegate void BoundarySystemCallback(BoundaryPlayerArea playAreaInfo, List<Vector3> boundaryPoints, List<List<Vector3>> unusedLines);

		public delegate void BoundarySystemCallbackShrink(List<Vector3> rectPoints, List<Vector3> boundaryPoints, List<List<Vector3>> unusedLines);

		private static Pvr_SafeAreaAlgoModule instance;

		private BoundarySystemCallback boundarySystemCallback;

		private BoundarySystemCallbackShrink boundarySystemCallbackShrink;

		public static Pvr_SafeAreaAlgoModule Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Pvr_SafeAreaAlgoModule();
				}
				return instance;
			}
		}

		public void RegisterCallBack(BoundarySystemCallback callback)
		{
			boundarySystemCallback = callback;
		}

		public void RegisterCallBackShrink(BoundarySystemCallbackShrink callback)
		{
			boundarySystemCallbackShrink = callback;
		}

		public bool Start()
		{
			int num = Pvr_SafeAreaAlgoAPI.Pvr_GSASetCallback(_SafeAreaCallback);
			int num2 = Pvr_SafeAreaAlgoAPI.Pvr_GSASetCallbackShrink(_SafeAreaCallbackShrink);
			if (num != 0 || num2 != 0)
			{
				UnityEngine.Debug.LogError("BoundarySystem register callback failed!");
				return false;
			}
			if (Pvr_SafeAreaAlgoAPI.Pvr_GSAInit(300, 300) != 0)
			{
				UnityEngine.Debug.LogError("BoundarySystem init failed!");
				return false;
			}
			return true;
		}

		public bool CommitNewLineData(bool isFistLine, Vector3[] points)
		{
			Pvr_SafeAreaAlgoAPI.GSALineCollection info = default(Pvr_SafeAreaAlgoAPI.GSALineCollection);
			info.lineCount = 2;
			Pvr_SafeAreaAlgoAPI.GSALine[] array = new Pvr_SafeAreaAlgoAPI.GSALine[2];
			if (isFistLine)
			{
				array[0].pointArray = IntPtr.Zero;
				array[0].pointCount = 0;
			}
			else
			{
				Pvr_SafeAreaAlgoAPI.GSAPoint3i[] arr = new Pvr_SafeAreaAlgoAPI.GSAPoint3i[1]
				{
					new Pvr_SafeAreaAlgoAPI.GSAPoint3i
					{
						x = 0,
						y = 0,
						z = 0
					}
				};
				array[0].pointArray = Marshal.UnsafeAddrOfPinnedArrayElement(arr, 0);
				array[0].pointCount = 1;
			}
			Pvr_SafeAreaAlgoAPI.GSAPoint3i[] array2 = new Pvr_SafeAreaAlgoAPI.GSAPoint3i[points.Length];
			for (int i = 0; i < points.Length; i++)
			{
				Pvr_SafeAreaAlgoAPI.GSAPoint3i gSAPoint3i = default(Pvr_SafeAreaAlgoAPI.GSAPoint3i);
				gSAPoint3i.x = (int)(points[i].x * 1000f);
				gSAPoint3i.y = (int)(points[i].y * 1000f);
				gSAPoint3i.z = (int)(points[i].z * 1000f);
				array2[i] = gSAPoint3i;
			}
			array[1].pointArray = Marshal.UnsafeAddrOfPinnedArrayElement(array2, 0);
			array[1].pointCount = array2.Length;
			info.lineArray = Marshal.UnsafeAddrOfPinnedArrayElement(array, 0);
			IntPtr intPtr = Pvr_BoundaryAPI.StructToIntPtr(info);
			int num = Pvr_SafeAreaAlgoAPI.Pvr_GSAUpDateData(intPtr);
			Marshal.FreeHGlobal(intPtr);
			if (num != 0)
			{
				UnityEngine.Debug.LogError("BoundarySystem commit new line data failed!");
				return false;
			}
			return true;
		}

		public bool Shutdown()
		{
			if (Pvr_SafeAreaAlgoAPI.Pvr_GSAShutDown() != 0)
			{
				UnityEngine.Debug.LogError("BoundarySystem shutdown failed!");
				return false;
			}
			return true;
		}

		public double QueryDistanceOfPoint(Vector3 point)
		{
			Pvr_SafeAreaAlgoAPI.GSAPoint3i point2 = default(Pvr_SafeAreaAlgoAPI.GSAPoint3i);
			point2.x = (int)(point.x * 1000f);
			point2.y = (int)(point.y * 1000f);
			point2.z = (int)(point.z * 1000f);
			return Pvr_SafeAreaAlgoAPI.Pvr_GSABoundaryDetector(ref point2) / 1000.0;
		}

		public double QueryDistanceOfPoint(Vector3 point, bool isPlayArea, ref Vector3 closestPoint, ref Vector3 normalDir)
		{
			Pvr_SafeAreaAlgoAPI.GSAPoint3i point2 = default(Pvr_SafeAreaAlgoAPI.GSAPoint3i);
			point2.x = (int)(point.x * 1000f);
			point2.y = (int)(point.y * 1000f);
			point2.z = (int)(point.z * 1000f);
			Pvr_SafeAreaAlgoAPI.GSAPoint3i closestPoint2 = default(Pvr_SafeAreaAlgoAPI.GSAPoint3i);
			Pvr_SafeAreaAlgoAPI.GSAPoint3i normalDir2 = default(Pvr_SafeAreaAlgoAPI.GSAPoint3i);
			double num = Pvr_SafeAreaAlgoAPI.Pvr_GSABoundaryDetector2(ref point2, isPlayArea, ref closestPoint2, ref normalDir2);
			closestPoint.x = (float)closestPoint2.x / 1000f;
			closestPoint.y = (float)closestPoint2.y / 1000f;
			closestPoint.z = (float)closestPoint2.z / 1000f;
			normalDir.x = (float)normalDir2.x / 1000f;
			normalDir.y = (float)normalDir2.y / 1000f;
			normalDir.z = (float)normalDir2.z / 1000f;
			return num / 1000.0;
		}

		[MonoPInvokeCallback(typeof(Pvr_SafeAreaAlgoAPI.SafeAreaCallback))]
		private static void _SafeAreaCallback(IntPtr lineCollectionPtr, IntPtr safeAreaRectPtr)
		{
			if (lineCollectionPtr == IntPtr.Zero || safeAreaRectPtr == IntPtr.Zero)
			{
				UnityEngine.Debug.LogError("BoundarySystem callback is inValid!");
			}
			else
			{
				if (instance.boundarySystemCallback == null)
				{
					return;
				}
				List<Vector3> boundaryPoints = new List<Vector3>();
				List<List<Vector3>> list = new List<List<Vector3>>();
				int num = Marshal.SizeOf(typeof(Pvr_SafeAreaAlgoAPI.GSALine));
				int num2 = Marshal.SizeOf(typeof(Pvr_SafeAreaAlgoAPI.GSAPoint3i));
				Pvr_SafeAreaAlgoAPI.GSALineCollection gSALineCollection = Pvr_BoundaryAPI.IntPtrToStruct<Pvr_SafeAreaAlgoAPI.GSALineCollection>(lineCollectionPtr);
				for (int i = 0; i < gSALineCollection.lineCount; i++)
				{
					Pvr_SafeAreaAlgoAPI.GSALine gSALine = (Pvr_SafeAreaAlgoAPI.GSALine)Marshal.PtrToStructure(new IntPtr(gSALineCollection.lineArray.ToInt64() + num * i), typeof(Pvr_SafeAreaAlgoAPI.GSALine));
					List<Vector3> list2 = new List<Vector3>();
					for (int j = 0; j < gSALine.pointCount; j++)
					{
						Pvr_SafeAreaAlgoAPI.GSAPoint3i gSAPoint3i = (Pvr_SafeAreaAlgoAPI.GSAPoint3i)Marshal.PtrToStructure(new IntPtr(gSALine.pointArray.ToInt64() + num2 * j), typeof(Pvr_SafeAreaAlgoAPI.GSAPoint3i));
						list2.Add(new Vector3((float)gSAPoint3i.x / 1000f, (float)gSAPoint3i.y / 1000f, (float)gSAPoint3i.z / 1000f));
					}
					if (i == 0)
					{
						boundaryPoints = list2;
					}
					else
					{
						list.Add(list2);
					}
				}
				Pvr_SafeAreaAlgoAPI.GSARect gSARect = Pvr_BoundaryAPI.IntPtrToStruct<Pvr_SafeAreaAlgoAPI.GSARect>(safeAreaRectPtr);
				BoundaryPlayerArea playAreaInfo = default(BoundaryPlayerArea);
				playAreaInfo.lowerleft = new Vector3((float)gSARect.leftup.x / 1000f, (float)gSARect.leftup.y / 1000f, (float)gSARect.leftup.z / 1000f);
				playAreaInfo.upperleft = new Vector3((float)gSARect.leftdown.x / 1000f, (float)gSARect.leftdown.y / 1000f, (float)gSARect.leftdown.z / 1000f);
				playAreaInfo.upperRight = new Vector3((float)gSARect.rightdown.x / 1000f, (float)gSARect.rightdown.y / 1000f, (float)gSARect.rightdown.z / 1000f);
				playAreaInfo.lowerRight = new Vector3((float)gSARect.rightup.x / 1000f, (float)gSARect.rightup.y / 1000f, (float)gSARect.rightup.z / 1000f);
				playAreaInfo.center = new Vector3((float)gSARect.center.x / 1000f, (float)gSARect.center.y / 1000f, (float)gSARect.center.z / 1000f);
				playAreaInfo.width = gSARect.width;
				playAreaInfo.height = gSARect.height;
				playAreaInfo.isLegal = ((gSARect.isLegal != 0) ? true : false);
				playAreaInfo.extraInfo.overMaxRange = ((gSARect.legalData.overMaxRange != 0) ? true : false);
				playAreaInfo.extraInfo.includeBigGap = ((gSARect.legalData.includeBigGrap != 0) ? true : false);
				playAreaInfo.extraInfo.bigGapNum = gSARect.legalData.bigGapNum;
				playAreaInfo.extraInfo.centerOut = ((gSARect.legalData.centerOut != 0) ? true : false);
				playAreaInfo.extraInfo.removeNarrow = ((gSARect.legalData.removeNarrow != 0) ? true : false);
				playAreaInfo.extraInfo.overMaxRange_more = ((gSARect.legalData.overMaxRange_more != 0) ? true : false);
				playAreaInfo.extraInfo.validShrinkArea = gSARect.legalData.validShrinkArea;
				instance.boundarySystemCallback(playAreaInfo, boundaryPoints, list);
			}
		}

		[MonoPInvokeCallback(typeof(Pvr_SafeAreaAlgoAPI.SafeAreaCallbackShrink))]
		private static void _SafeAreaCallbackShrink(IntPtr lineCollectionPtr, IntPtr safeAreaDetailRectPtr)
		{
			if (lineCollectionPtr == IntPtr.Zero || safeAreaDetailRectPtr == IntPtr.Zero)
			{
				UnityEngine.Debug.LogError("BoundarySystem callback is inValid!");
			}
			else
			{
				if (instance.boundarySystemCallbackShrink == null)
				{
					return;
				}
				List<Vector3> boundaryPoints = new List<Vector3>();
				List<List<Vector3>> list = new List<List<Vector3>>();
				int num = Marshal.SizeOf(typeof(Pvr_SafeAreaAlgoAPI.GSALine));
				int num2 = Marshal.SizeOf(typeof(Pvr_SafeAreaAlgoAPI.GSAPoint3i));
				Pvr_SafeAreaAlgoAPI.GSALineCollection gSALineCollection = Pvr_BoundaryAPI.IntPtrToStruct<Pvr_SafeAreaAlgoAPI.GSALineCollection>(lineCollectionPtr);
				for (int i = 0; i < gSALineCollection.lineCount; i++)
				{
					Pvr_SafeAreaAlgoAPI.GSALine gSALine = (Pvr_SafeAreaAlgoAPI.GSALine)Marshal.PtrToStructure(new IntPtr(gSALineCollection.lineArray.ToInt64() + num * i), typeof(Pvr_SafeAreaAlgoAPI.GSALine));
					List<Vector3> list2 = new List<Vector3>();
					for (int j = 0; j < gSALine.pointCount; j++)
					{
						Pvr_SafeAreaAlgoAPI.GSAPoint3i gSAPoint3i = (Pvr_SafeAreaAlgoAPI.GSAPoint3i)Marshal.PtrToStructure(new IntPtr(gSALine.pointArray.ToInt64() + num2 * j), typeof(Pvr_SafeAreaAlgoAPI.GSAPoint3i));
						list2.Add(new Vector3((float)gSAPoint3i.x / 1000f, (float)gSAPoint3i.y / 1000f, (float)gSAPoint3i.z / 1000f));
					}
					if (i == 0)
					{
						boundaryPoints = list2;
					}
					else
					{
						list.Add(list2);
					}
				}
				List<Vector3> list3 = new List<Vector3>();
				Pvr_SafeAreaAlgoAPI.GSALineCollection gSALineCollection2 = Pvr_BoundaryAPI.IntPtrToStruct<Pvr_SafeAreaAlgoAPI.GSALineCollection>(safeAreaDetailRectPtr);
				for (int k = 0; k < gSALineCollection2.lineCount; k++)
				{
					Pvr_SafeAreaAlgoAPI.GSALine gSALine2 = (Pvr_SafeAreaAlgoAPI.GSALine)Marshal.PtrToStructure(new IntPtr(gSALineCollection2.lineArray.ToInt64() + num * k), typeof(Pvr_SafeAreaAlgoAPI.GSALine));
					for (int l = 0; l < gSALine2.pointCount; l++)
					{
						Pvr_SafeAreaAlgoAPI.GSAPoint3i gSAPoint3i2 = (Pvr_SafeAreaAlgoAPI.GSAPoint3i)Marshal.PtrToStructure(new IntPtr(gSALine2.pointArray.ToInt64() + num2 * l), typeof(Pvr_SafeAreaAlgoAPI.GSAPoint3i));
						list3.Add(new Vector3((float)gSAPoint3i2.x / 1000f, (float)gSAPoint3i2.y / 1000f, (float)gSAPoint3i2.z / 1000f));
					}
				}
				instance.boundarySystemCallbackShrink(list3, boundaryPoints, list);
			}
		}
	}
}
namespace Pvr_UnitySDKAPI
{
	public class PvrControllerKey
	{
		public bool State;

		public bool PressedDown;

		public bool PressedUp;

		public bool LongPressed;

		public bool Click;

		public bool Touch;

		public bool TouchDown;

		public bool TouchUp;

		public PvrControllerKey()
		{
			State = false;
			PressedDown = false;
			PressedUp = false;
			LongPressed = false;
			Click = false;
			Touch = false;
			TouchDown = false;
			TouchUp = false;
		}
	}
	public class ControllerHand
	{
		public PvrControllerKey App;

		public PvrControllerKey Touch;

		public PvrControllerKey Home;

		public PvrControllerKey VolumeDown;

		public PvrControllerKey VolumeUp;

		public PvrControllerKey Trigger;

		public PvrControllerKey X;

		public PvrControllerKey Y;

		public PvrControllerKey A;

		public PvrControllerKey B;

		public PvrControllerKey Left;

		public PvrControllerKey Right;

		public PvrControllerKey Thumbrest;

		public Vector2 TouchPadPosition;

		public int TriggerNum;

		public int GripValue;

		public Quaternion Rotation;

		public Vector3 Position;

		public int Battery;

		public ControllerState ConnectState;

		public SwipeDirection SwipeDirection;

		public TouchPadClick TouchPadClick;

		public bool isShowBoundary;

		public ControllerHand()
		{
			App = new PvrControllerKey();
			Touch = new PvrControllerKey();
			Home = new PvrControllerKey();
			VolumeDown = new PvrControllerKey();
			VolumeUp = new PvrControllerKey();
			Trigger = new PvrControllerKey();
			A = new PvrControllerKey();
			B = new PvrControllerKey();
			X = new PvrControllerKey();
			Y = new PvrControllerKey();
			Left = new PvrControllerKey();
			Right = new PvrControllerKey();
			Thumbrest = new PvrControllerKey();
			TouchPadPosition = default(Vector2);
			Rotation = default(Quaternion);
			Position = default(Vector3);
			Battery = 0;
			TriggerNum = 0;
			GripValue = 0;
			ConnectState = ControllerState.Error;
			SwipeDirection = SwipeDirection.No;
			TouchPadClick = TouchPadClick.No;
			isShowBoundary = false;
		}
	}
	public enum ControllerState
	{
		Error = -1,
		DisConnected,
		Connected
	}
	public enum Pvr_KeyCode
	{
		APP = 1,
		TOUCHPAD,
		HOME,
		VOLUMEUP,
		VOLUMEDOWN,
		TRIGGER,
		A,
		B,
		X,
		Y,
		Left,
		Right,
		Thumbrest
	}
	public enum SwipeDirection
	{
		No,
		SwipeUp,
		SwipeDown,
		SwipeLeft,
		SwipeRight
	}
	public enum TouchPadClick
	{
		No,
		ClickUp,
		ClickDown,
		ClickLeft,
		ClickRight
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Controller
	{
		public const string LibFileName = "Pvr_UnitySDK";

		public static Vector2 UPvr_GetTouchPadPosition(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition, 
				_ => new Vector2(0f, 0f), 
			};
		}

		public static float UPvr_GetAxis1D(int hand, Pvr_KeyCode key)
		{
			return hand switch
			{
				0 => key switch
				{
					Pvr_KeyCode.TRIGGER => (float)Pvr_ControllerManager.controllerlink.Controller0.TriggerNum / 255f, 
					Pvr_KeyCode.Left => (float)Pvr_ControllerManager.controllerlink.Controller0.GripValue / 255f, 
					_ => 0f, 
				}, 
				1 => key switch
				{
					Pvr_KeyCode.TRIGGER => (float)Pvr_ControllerManager.controllerlink.Controller1.TriggerNum / 255f, 
					Pvr_KeyCode.Right => (float)Pvr_ControllerManager.controllerlink.Controller1.GripValue / 255f, 
					_ => 0f, 
				}, 
				_ => 0f, 
			};
		}

		public static Vector2 UPvr_GetAxis2D(int hand)
		{
			switch (hand)
			{
			case 0:
				if (Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition != Vector2.zero)
				{
					return new Vector2(Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.x / 128f - 1f, Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.y / 128f - 1f);
				}
				return Vector2.zero;
			case 1:
				if (Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition != Vector2.zero)
				{
					return new Vector2(Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.x / 128f - 1f, Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.y / 128f - 1f);
				}
				return Vector2.zero;
			default:
				return Vector2.zero;
			}
		}

		public static ControllerState UPvr_GetControllerState(int hand)
		{
			return hand switch
			{
				0 => (ControllerState)Convert.ToInt16(Pvr_ControllerManager.controllerlink.controller0Connected), 
				1 => (ControllerState)Convert.ToInt16(Pvr_ControllerManager.controllerlink.controller1Connected), 
				_ => ControllerState.Error, 
			};
		}

		public static Quaternion UPvr_GetControllerQUA(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.Rotation, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.Rotation, 
				_ => new Quaternion(0f, 0f, 0f, 1f), 
			};
		}

		public static Vector3 UPvr_GetControllerPOS(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.Position, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.Position, 
				_ => new Vector3(0f, 0f, 0f), 
			};
		}

		public static int UPvr_GetControllerTriggerValue(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.TriggerNum, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.TriggerNum, 
				_ => 0, 
			};
		}

		public static int UPvr_GetControllerPower(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.Battery, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.Battery, 
				_ => 0, 
			};
		}

		public static SwipeDirection UPvr_GetSwipeDirection(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.SwipeDirection, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.SwipeDirection, 
				_ => SwipeDirection.No, 
			};
		}

		public static TouchPadClick UPvr_GetTouchPadClick(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.TouchPadClick, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.TouchPadClick, 
				_ => TouchPadClick.No, 
			};
		}

		public static bool UPvr_GetKey(int hand, Pvr_KeyCode key)
		{
			return hand switch
			{
				0 => key switch
				{
					Pvr_KeyCode.APP => Pvr_ControllerManager.controllerlink.Controller0.App.State, 
					Pvr_KeyCode.HOME => Pvr_ControllerManager.controllerlink.Controller0.Home.State, 
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller0.Touch.State, 
					Pvr_KeyCode.VOLUMEUP => Pvr_ControllerManager.controllerlink.Controller0.VolumeUp.State, 
					Pvr_KeyCode.VOLUMEDOWN => Pvr_ControllerManager.controllerlink.Controller0.VolumeDown.State, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller0.Trigger.State, 
					Pvr_KeyCode.X => Pvr_ControllerManager.controllerlink.Controller0.X.State, 
					Pvr_KeyCode.Y => Pvr_ControllerManager.controllerlink.Controller0.Y.State, 
					Pvr_KeyCode.Left => Pvr_ControllerManager.controllerlink.Controller0.Left.State, 
					_ => false, 
				}, 
				1 => key switch
				{
					Pvr_KeyCode.APP => Pvr_ControllerManager.controllerlink.Controller1.App.State, 
					Pvr_KeyCode.HOME => Pvr_ControllerManager.controllerlink.Controller1.Home.State, 
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller1.Touch.State, 
					Pvr_KeyCode.VOLUMEUP => Pvr_ControllerManager.controllerlink.Controller1.VolumeUp.State, 
					Pvr_KeyCode.VOLUMEDOWN => Pvr_ControllerManager.controllerlink.Controller1.VolumeDown.State, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller1.Trigger.State, 
					Pvr_KeyCode.A => Pvr_ControllerManager.controllerlink.Controller1.A.State, 
					Pvr_KeyCode.B => Pvr_ControllerManager.controllerlink.Controller1.B.State, 
					Pvr_KeyCode.Right => Pvr_ControllerManager.controllerlink.Controller1.Right.State, 
					_ => false, 
				}, 
				_ => false, 
			};
		}

		public static bool UPvr_GetKeyDown(int hand, Pvr_KeyCode key)
		{
			return hand switch
			{
				0 => key switch
				{
					Pvr_KeyCode.APP => Pvr_ControllerManager.controllerlink.Controller0.App.PressedDown, 
					Pvr_KeyCode.HOME => Pvr_ControllerManager.controllerlink.Controller0.Home.PressedDown, 
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller0.Touch.PressedDown, 
					Pvr_KeyCode.VOLUMEUP => Pvr_ControllerManager.controllerlink.Controller0.VolumeUp.PressedDown, 
					Pvr_KeyCode.VOLUMEDOWN => Pvr_ControllerManager.controllerlink.Controller0.VolumeDown.PressedDown, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller0.Trigger.PressedDown, 
					Pvr_KeyCode.X => Pvr_ControllerManager.controllerlink.Controller0.X.PressedDown, 
					Pvr_KeyCode.Y => Pvr_ControllerManager.controllerlink.Controller0.Y.PressedDown, 
					Pvr_KeyCode.Left => Pvr_ControllerManager.controllerlink.Controller0.Left.PressedDown, 
					_ => false, 
				}, 
				1 => key switch
				{
					Pvr_KeyCode.APP => Pvr_ControllerManager.controllerlink.Controller1.App.PressedDown, 
					Pvr_KeyCode.HOME => Pvr_ControllerManager.controllerlink.Controller1.Home.PressedDown, 
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller1.Touch.PressedDown, 
					Pvr_KeyCode.VOLUMEUP => Pvr_ControllerManager.controllerlink.Controller1.VolumeUp.PressedDown, 
					Pvr_KeyCode.VOLUMEDOWN => Pvr_ControllerManager.controllerlink.Controller1.VolumeDown.PressedDown, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller1.Trigger.PressedDown, 
					Pvr_KeyCode.A => Pvr_ControllerManager.controllerlink.Controller1.A.PressedDown, 
					Pvr_KeyCode.B => Pvr_ControllerManager.controllerlink.Controller1.B.PressedDown, 
					Pvr_KeyCode.Right => Pvr_ControllerManager.controllerlink.Controller1.Right.PressedDown, 
					_ => false, 
				}, 
				_ => false, 
			};
		}

		public static bool UPvr_GetKeyUp(int hand, Pvr_KeyCode key)
		{
			return hand switch
			{
				0 => key switch
				{
					Pvr_KeyCode.APP => Pvr_ControllerManager.controllerlink.Controller0.App.PressedUp, 
					Pvr_KeyCode.HOME => Pvr_ControllerManager.controllerlink.Controller0.Home.PressedUp, 
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller0.Touch.PressedUp, 
					Pvr_KeyCode.VOLUMEUP => Pvr_ControllerManager.controllerlink.Controller0.VolumeUp.PressedUp, 
					Pvr_KeyCode.VOLUMEDOWN => Pvr_ControllerManager.controllerlink.Controller0.VolumeDown.PressedUp, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller0.Trigger.PressedUp, 
					Pvr_KeyCode.X => Pvr_ControllerManager.controllerlink.Controller0.X.PressedUp, 
					Pvr_KeyCode.Y => Pvr_ControllerManager.controllerlink.Controller0.Y.PressedUp, 
					Pvr_KeyCode.Left => Pvr_ControllerManager.controllerlink.Controller0.Left.PressedUp, 
					_ => false, 
				}, 
				1 => key switch
				{
					Pvr_KeyCode.APP => Pvr_ControllerManager.controllerlink.Controller1.App.PressedUp, 
					Pvr_KeyCode.HOME => Pvr_ControllerManager.controllerlink.Controller1.Home.PressedUp, 
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller1.Touch.PressedUp, 
					Pvr_KeyCode.VOLUMEUP => Pvr_ControllerManager.controllerlink.Controller1.VolumeUp.PressedUp, 
					Pvr_KeyCode.VOLUMEDOWN => Pvr_ControllerManager.controllerlink.Controller1.VolumeDown.PressedUp, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller1.Trigger.PressedUp, 
					Pvr_KeyCode.A => Pvr_ControllerManager.controllerlink.Controller1.A.PressedUp, 
					Pvr_KeyCode.B => Pvr_ControllerManager.controllerlink.Controller1.B.PressedUp, 
					Pvr_KeyCode.Right => Pvr_ControllerManager.controllerlink.Controller1.Right.PressedUp, 
					_ => false, 
				}, 
				_ => false, 
			};
		}

		public static bool UPvr_GetTouch(int hand, Pvr_KeyCode key)
		{
			return hand switch
			{
				0 => key switch
				{
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller0.Touch.Touch, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller0.Trigger.Touch, 
					Pvr_KeyCode.X => Pvr_ControllerManager.controllerlink.Controller0.X.Touch, 
					Pvr_KeyCode.Y => Pvr_ControllerManager.controllerlink.Controller0.Y.Touch, 
					Pvr_KeyCode.Thumbrest => Pvr_ControllerManager.controllerlink.Controller0.Thumbrest.Touch, 
					_ => false, 
				}, 
				1 => key switch
				{
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller1.Touch.Touch, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller1.Trigger.Touch, 
					Pvr_KeyCode.A => Pvr_ControllerManager.controllerlink.Controller1.A.Touch, 
					Pvr_KeyCode.B => Pvr_ControllerManager.controllerlink.Controller1.B.Touch, 
					Pvr_KeyCode.Thumbrest => Pvr_ControllerManager.controllerlink.Controller1.Thumbrest.Touch, 
					_ => false, 
				}, 
				_ => false, 
			};
		}

		public static bool UPvr_GetTouchDown(int hand, Pvr_KeyCode key)
		{
			return hand switch
			{
				0 => key switch
				{
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller0.Touch.TouchDown, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller0.Trigger.TouchDown, 
					Pvr_KeyCode.X => Pvr_ControllerManager.controllerlink.Controller0.X.TouchDown, 
					Pvr_KeyCode.Y => Pvr_ControllerManager.controllerlink.Controller0.Y.TouchDown, 
					Pvr_KeyCode.Thumbrest => Pvr_ControllerManager.controllerlink.Controller0.Thumbrest.TouchDown, 
					_ => false, 
				}, 
				1 => key switch
				{
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller1.Touch.TouchDown, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller1.Trigger.TouchDown, 
					Pvr_KeyCode.A => Pvr_ControllerManager.controllerlink.Controller1.A.TouchDown, 
					Pvr_KeyCode.B => Pvr_ControllerManager.controllerlink.Controller1.B.TouchDown, 
					Pvr_KeyCode.Thumbrest => Pvr_ControllerManager.controllerlink.Controller1.Thumbrest.TouchDown, 
					_ => false, 
				}, 
				_ => false, 
			};
		}

		public static bool UPvr_GetTouchUp(int hand, Pvr_KeyCode key)
		{
			return hand switch
			{
				0 => key switch
				{
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller0.Touch.TouchUp, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller0.Trigger.TouchUp, 
					Pvr_KeyCode.X => Pvr_ControllerManager.controllerlink.Controller0.X.TouchUp, 
					Pvr_KeyCode.Y => Pvr_ControllerManager.controllerlink.Controller0.Y.TouchUp, 
					Pvr_KeyCode.Thumbrest => Pvr_ControllerManager.controllerlink.Controller0.Thumbrest.TouchUp, 
					_ => false, 
				}, 
				1 => key switch
				{
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller1.Touch.TouchUp, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller1.Trigger.TouchUp, 
					Pvr_KeyCode.A => Pvr_ControllerManager.controllerlink.Controller1.A.TouchUp, 
					Pvr_KeyCode.B => Pvr_ControllerManager.controllerlink.Controller1.B.TouchUp, 
					Pvr_KeyCode.Thumbrest => Pvr_ControllerManager.controllerlink.Controller1.Thumbrest.TouchUp, 
					_ => false, 
				}, 
				_ => false, 
			};
		}

		public static bool UPvr_GetKeyClick(int hand, Pvr_KeyCode key)
		{
			return hand switch
			{
				0 => key switch
				{
					Pvr_KeyCode.APP => Pvr_ControllerManager.controllerlink.Controller0.App.Click, 
					Pvr_KeyCode.HOME => Pvr_ControllerManager.controllerlink.Controller0.Home.Click, 
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller0.Touch.Click, 
					Pvr_KeyCode.VOLUMEUP => Pvr_ControllerManager.controllerlink.Controller0.VolumeUp.Click, 
					Pvr_KeyCode.VOLUMEDOWN => Pvr_ControllerManager.controllerlink.Controller0.VolumeDown.Click, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller0.Trigger.Click, 
					Pvr_KeyCode.X => Pvr_ControllerManager.controllerlink.Controller0.X.Click, 
					Pvr_KeyCode.Y => Pvr_ControllerManager.controllerlink.Controller0.Y.Click, 
					Pvr_KeyCode.Left => Pvr_ControllerManager.controllerlink.Controller0.Left.Click, 
					_ => false, 
				}, 
				1 => key switch
				{
					Pvr_KeyCode.APP => Pvr_ControllerManager.controllerlink.Controller1.App.Click, 
					Pvr_KeyCode.HOME => Pvr_ControllerManager.controllerlink.Controller1.Home.Click, 
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller1.Touch.Click, 
					Pvr_KeyCode.VOLUMEUP => Pvr_ControllerManager.controllerlink.Controller1.VolumeUp.Click, 
					Pvr_KeyCode.VOLUMEDOWN => Pvr_ControllerManager.controllerlink.Controller1.VolumeDown.Click, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller1.Trigger.Click, 
					Pvr_KeyCode.A => Pvr_ControllerManager.controllerlink.Controller1.A.Click, 
					Pvr_KeyCode.B => Pvr_ControllerManager.controllerlink.Controller1.B.Click, 
					Pvr_KeyCode.Right => Pvr_ControllerManager.controllerlink.Controller1.Right.Click, 
					_ => false, 
				}, 
				_ => false, 
			};
		}

		public static bool UPvr_GetKeyLongPressed(int hand, Pvr_KeyCode key)
		{
			return hand switch
			{
				0 => key switch
				{
					Pvr_KeyCode.APP => Pvr_ControllerManager.controllerlink.Controller0.App.LongPressed, 
					Pvr_KeyCode.HOME => Pvr_ControllerManager.controllerlink.Controller0.Home.LongPressed, 
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller0.Touch.LongPressed, 
					Pvr_KeyCode.VOLUMEUP => Pvr_ControllerManager.controllerlink.Controller0.VolumeUp.LongPressed, 
					Pvr_KeyCode.VOLUMEDOWN => Pvr_ControllerManager.controllerlink.Controller0.VolumeDown.LongPressed, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller0.Trigger.LongPressed, 
					Pvr_KeyCode.X => Pvr_ControllerManager.controllerlink.Controller0.X.LongPressed, 
					Pvr_KeyCode.Y => Pvr_ControllerManager.controllerlink.Controller0.Y.LongPressed, 
					Pvr_KeyCode.Left => Pvr_ControllerManager.controllerlink.Controller0.Left.LongPressed, 
					_ => false, 
				}, 
				1 => key switch
				{
					Pvr_KeyCode.APP => Pvr_ControllerManager.controllerlink.Controller1.App.LongPressed, 
					Pvr_KeyCode.HOME => Pvr_ControllerManager.controllerlink.Controller1.Home.LongPressed, 
					Pvr_KeyCode.TOUCHPAD => Pvr_ControllerManager.controllerlink.Controller1.Touch.LongPressed, 
					Pvr_KeyCode.VOLUMEUP => Pvr_ControllerManager.controllerlink.Controller1.VolumeUp.LongPressed, 
					Pvr_KeyCode.VOLUMEDOWN => Pvr_ControllerManager.controllerlink.Controller1.VolumeDown.LongPressed, 
					Pvr_KeyCode.TRIGGER => Pvr_ControllerManager.controllerlink.Controller1.Trigger.LongPressed, 
					Pvr_KeyCode.A => Pvr_ControllerManager.controllerlink.Controller1.A.LongPressed, 
					Pvr_KeyCode.B => Pvr_ControllerManager.controllerlink.Controller1.B.LongPressed, 
					Pvr_KeyCode.Right => Pvr_ControllerManager.controllerlink.Controller1.Right.LongPressed, 
					_ => false, 
				}, 
				_ => false, 
			};
		}

		public static bool UPvr_IsTouching(int hand)
		{
			switch (hand)
			{
			case 0:
				if (!(Math.Abs(Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.x) > 0f))
				{
					return Math.Abs(Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.y) > 0f;
				}
				return true;
			case 1:
				if (!(Math.Abs(Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.x) > 0f))
				{
					return Math.Abs(Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.y) > 0f;
				}
				return true;
			default:
				return false;
			}
		}

		public static void UPvr_SetHandNess(Pvr_Controller.UserHandNess hand)
		{
			if (Pvr_ControllerManager.controllerlink.getHandness() != (int)hand)
			{
				Pvr_ControllerManager.controllerlink.setHandness((int)hand);
			}
		}

		public static Pvr_Controller.UserHandNess UPvr_GetHandNess()
		{
			return Pvr_ControllerManager.controllerlink.handness;
		}

		public static int UPvr_GetPreferenceDevice()
		{
			int trackingmode = Pvr_ControllerManager.controllerlink.trackingmode;
			int systemProp = Pvr_ControllerManager.controllerlink.systemProp;
			if (trackingmode == 0 || trackingmode == 1 || ((trackingmode == 3 || trackingmode == 5 || trackingmode == 6) && (systemProp == 1 || systemProp == 3)))
			{
				return 1;
			}
			return 2;
		}

		public static bool UPvr_IsEnbleTrigger()
		{
			return Pvr_ControllerManager.controllerlink.IsEnbleTrigger();
		}

		public static int UPvr_GetDeviceType()
		{
			return Pvr_ControllerManager.controllerlink.controllerType;
		}

		public static int UPvr_GetMainHandNess()
		{
			return Pvr_ControllerManager.controllerlink.mainHandID;
		}

		public static void UPvr_SetMainHandNess(int hand)
		{
			Pvr_ControllerManager.controllerlink.SetMainController(hand);
		}

		public static int UPvr_GetControllerAbility(int hand)
		{
			return Pvr_ControllerManager.controllerlink.GetControllerAbility(hand);
		}

		public static void UPvr_VibrateNeo2Controller(float strength, int time, int hand)
		{
			Pvr_ControllerManager.controllerlink.VibrateNeo2Controller(strength, time, hand);
		}

		public static int UPvr_GetControllerBindingState(int hand)
		{
			return Pvr_ControllerManager.controllerlink.GetControllerBindingState(hand);
		}

		public static Vector3 UPvr_GetVelocity(int hand)
		{
			return Pvr_ControllerManager.controllerlink.GetVelocity(hand);
		}

		public static Vector3 UPvr_GetAngularVelocity(int hand)
		{
			return Pvr_ControllerManager.controllerlink.GetAngularVelocity(hand);
		}

		public static Vector3 UPvr_GetAcceleration(int hand)
		{
			return Pvr_ControllerManager.controllerlink.GetAcceleration(hand);
		}

		public static void UPvr_ScanController()
		{
			Pvr_ControllerManager.controllerlink.StartScan();
		}

		public static void UPvr_StopScanController()
		{
			Pvr_ControllerManager.controllerlink.StopScan();
		}

		public static void UPvr_ConnectController(string mac)
		{
			if (mac != "")
			{
				Pvr_ControllerManager.controllerlink.hummingBirdMac = mac;
			}
			Pvr_ControllerManager.controllerlink.ConnectBLE();
		}

		public static void UPvr_DisConnectController()
		{
			Pvr_ControllerManager.controllerlink.DisConnectBLE();
		}

		public static void UPvr_ResetController(int hand)
		{
			Pvr_ControllerManager.controllerlink.ResetController(hand);
		}

		public static string UPvr_GetControllerVersion()
		{
			return Pvr_ControllerManager.controllerlink.GetControllerVersion();
		}

		public static void UPvr_GetDeviceVersion(int deviceType)
		{
			Pvr_ControllerManager.controllerlink.GetDeviceVersion(deviceType);
		}

		public static void UPvr_GetControllerSnCode(int controllerSerialNum)
		{
			Pvr_ControllerManager.controllerlink.GetControllerSnCode(controllerSerialNum);
		}

		public static void UPvr_SetControllerUnbind(int controllerSerialNum)
		{
			Pvr_ControllerManager.controllerlink.SetControllerUnbind(controllerSerialNum);
		}

		public static void UPvr_SetStationRestart()
		{
			Pvr_ControllerManager.controllerlink.SetStationRestart();
		}

		public static void UPvr_StartStationOtaUpdate()
		{
			Pvr_ControllerManager.controllerlink.StartStationOtaUpdate();
		}

		public static void UPvr_StartControllerOtaUpdate(int mode, int controllerSerialNum)
		{
			Pvr_ControllerManager.controllerlink.StartControllerOtaUpdate(mode, controllerSerialNum);
		}

		public static void UPvr_EnterPairMode(int controllerSerialNum)
		{
			Pvr_ControllerManager.controllerlink.EnterPairMode(controllerSerialNum);
		}

		public static void UPvr_SetControllerShutdown(int controllerSerialNum)
		{
			Pvr_ControllerManager.controllerlink.SetControllerShutdown(controllerSerialNum);
		}

		public static int UPvr_GetStationPairState()
		{
			return Pvr_ControllerManager.controllerlink.GetStationPairState();
		}

		public static int UPvr_GetStationOtaUpdateProgress()
		{
			return Pvr_ControllerManager.controllerlink.GetStationOtaUpdateProgress();
		}

		public static int UPvr_GetControllerOtaUpdateProgress()
		{
			return Pvr_ControllerManager.controllerlink.GetControllerOtaUpdateProgress();
		}

		public static void UPvr_GetControllerVersionAndSN(int controllerSerialNum)
		{
			Pvr_ControllerManager.controllerlink.GetControllerVersionAndSN(controllerSerialNum);
		}

		public static void UPvr_GetControllerUniqueID()
		{
			Pvr_ControllerManager.controllerlink.GetControllerUniqueID();
		}

		public void UPvr_InterruptStationPairMode()
		{
			Pvr_ControllerManager.controllerlink.InterruptStationPairMode();
		}

		public void UPvr_StartCV2PairingMode(int deviceType)
		{
			Pvr_ControllerManager.controllerlink.StartCV2PairingMode(deviceType);
		}

		public void UPvr_StopCV2PairingMode(int deviceType)
		{
			Pvr_ControllerManager.controllerlink.StopCV2PairingMode(deviceType);
		}

		public static void UPvr_SetArmModelParameters(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle)
		{
			Pvr_SetArmModelParameters(hand, gazeType, elbowHeight, elbowDepth, pointerTiltAngle);
		}

		public static void UPvr_CalcArmModelParameters(float[] headOrientation, float[] controllerOrientation, float[] controllerPrimary)
		{
			Pvr_CalcArmModelParameters(headOrientation, controllerOrientation, controllerPrimary);
		}

		public static void UPvr_GetPointerPose(float[] rotation, float[] position)
		{
			Pvr_GetPointerPose(rotation, position);
		}

		public static void UPvr_GetElbowPose(float[] rotation, float[] position)
		{
			Pvr_GetElbowPose(rotation, position);
		}

		public static void UPvr_GetWristPose(float[] rotation, float[] position)
		{
			Pvr_GetWristPose(rotation, position);
		}

		public static void UPvr_GetShoulderPose(float[] rotation, float[] position)
		{
			Pvr_GetShoulderPose(rotation, position);
		}

		public static void UPvr_IsEnbleHomeKey(bool state)
		{
			Pvr_ControllerManager.controllerlink.setIsEnbleHomeKey(state);
		}

		public static void UPvr_SwitchHomeKey(bool state)
		{
			Pvr_ControllerManager.controllerlink.SwitchHomeKey(state);
		}

		public static int UPvr_GetControllerSensorStatus(int id)
		{
			return Pvr_ControllerManager.controllerlink.getControllerSensorStatus(id);
		}

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_CalcArmModelParameters(float[] headOrientation, float[] controllerOrientation, float[] gyro);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_GetPointerPose(float[] rotation, float[] position);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_GetElbowPose(float[] rotation, float[] position);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_GetWristPose(float[] rotation, float[] position);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_GetShoulderPose(float[] rotation, float[] position);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetArmModelParameters(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle);
	}
	public enum ControllerVariety
	{
		Controller0,
		Controller1
	}
	public enum ControllerDevice
	{
		Goblin,
		Neo,
		G2,
		Neo2,
		Neo3,
		NewController
	}
	public enum PBS_SystemInfoEnum
	{
		ELECTRIC_QUANTITY,
		PUI_VERSION,
		EQUIPMENT_MODEL,
		EQUIPMENT_SN,
		CUSTOMER_SN,
		INTERNAL_STORAGE_SPACE_OF_THE_DEVICE,
		DEVICE_BLUETOOTH_STATUS,
		BLUETOOTH_NAME_CONNECTED,
		BLUETOOTH_MAC_ADDRESS,
		DEVICE_WIFI_STATUS,
		WIFI_NAME_CONNECTED,
		WLAN_MAC_ADDRESS,
		DEVICE_IP
	}
	public enum PBS_DeviceControlEnum
	{
		DEVICE_CONTROL_REBOOT,
		DEVICE_CONTROL_SHUTDOWN
	}
	public enum PBS_PackageControlEnum
	{
		PACKAGE_SILENCE_INSTALL,
		PACKAGE_SILENCE_UNINSTALL
	}
	public enum PBS_SwitchEnum
	{
		S_ON,
		S_OFF
	}
	public enum PBS_HomeEventEnum
	{
		SINGLE_CLICK,
		DOUBLE_CLICK,
		LONG_PRESS
	}
	public enum PBS_HomeFunctionEnum
	{
		VALUE_HOME_GO_TO_SETTING,
		VALUE_HOME_BACK,
		VALUE_HOME_RECENTER,
		VALUE_HOME_OPEN_APP,
		VALUE_HOME_DISABLE,
		VALUE_HOME_GO_TO_HOME,
		VALUE_HOME_SEND_BROADCAST,
		VALUE_HOME_CLEAN_MEMORY
	}
	public enum PBS_ScreenOffDelayTimeEnum
	{
		THREE = 3,
		TEN = 10,
		THIRTY = 30,
		SIXTY = 60,
		THREE_HUNDRED = 300,
		SIX_HUNDRED = 600,
		NEVER = -1
	}
	public enum PBS_SleepDelayTimeEnum
	{
		FIFTEEN = 15,
		THIRTY = 30,
		SIXTY = 60,
		THREE_HUNDRED = 300,
		SIX_HUNDRED = 600,
		ONE_THOUSAND_AND_EIGHT_HUNDRED = 1800,
		NEVER = -1
	}
	public enum PBS_SystemFunctionSwitchEnum
	{
		SFS_USB,
		SFS_AUTOSLEEP,
		SFS_SCREENON_CHARGING,
		SFS_OTG_CHARGING,
		SFS_RETURN_MENU_IN_2DMODE,
		SFS_COMBINATION_KEY,
		SFS_CALIBRATION_WITH_POWER_ON,
		SFS_SYSTEM_UPDATE,
		SFS_CAST_SERVICE,
		SFS_EYE_PROTECTION,
		SFS_SECURITY_ZONE_PERMANENTLY,
		SFS_GLOBAL_CALIBRATION,
		SFS_Auto_Calibration,
		SFS_USB_BOOT
	}
	public enum PBS_USBConfigModeEnum
	{
		MTP,
		CHARGE
	}
	public struct ToBService
	{
		public static Action<bool> BoolCallback;

		public static Action<int> IntCallback;

		public static Action<long> LongCallback;

		private static AndroidJavaClass unityPlayer;

		private static AndroidJavaObject currentActivity;

		private static AndroidJavaObject tobHelper;

		private static AndroidJavaClass tobHelperClass;

		public static void UPvr_InitToBService()
		{
			tobHelperClass = new AndroidJavaClass("com.pvr.tobservice.ToBServiceHelper");
			tobHelper = tobHelperClass.CallStatic<AndroidJavaObject>("getInstance", Array.Empty<object>());
			unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
		}

		public static void UPvr_SetUnityObjectName(string obj)
		{
			System.UPvr_CallMethod(tobHelper, "setUnityObjectName", obj);
		}

		public static void UPvr_BindToBService()
		{
			System.UPvr_CallMethod(tobHelper, "bindTobService", currentActivity);
		}

		public static void UPvr_UnBindToBService()
		{
			System.UPvr_CallMethod(tobHelper, "unBindTobService", currentActivity);
		}

		private static AndroidJavaObject GetEnumType(Enum enumType)
		{
			return new AndroidJavaClass("com.pvr.tobservice.enums" + enumType.GetType().ToString().Replace("Pvr_UnitySDKAPI", "")).GetStatic<AndroidJavaObject>(enumType.ToString());
		}

		public static string UPvr_StateGetDeviceInfo(PBS_SystemInfoEnum type)
		{
			string result = "";
			System.UPvr_CallMethod(ref result, tobHelper, "pbsStateGetDeviceInfo", GetEnumType(type), 0);
			return result;
		}

		public static void UPvr_ControlSetDeviceAction(PBS_DeviceControlEnum deviceControl, Action<int> callback)
		{
			if (callback != null)
			{
				IntCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsControlSetDeviceAction", GetEnumType(deviceControl), null);
		}

		public static void UPvr_ControlAPPManger(PBS_PackageControlEnum packageControl, string path, Action<int> callback)
		{
			if (callback != null)
			{
				IntCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsControlAPPManger", GetEnumType(packageControl), path, 0, null);
		}

		public static void UPvr_ControlSetAutoConnectWIFI(string ssid, string pwd, Action<bool> callback)
		{
			if (callback != null)
			{
				BoolCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsControlSetAutoConnectWIFI", ssid, pwd, 0, null);
		}

		public static void UPvr_ControlClearAutoConnectWIFI(Action<bool> callback)
		{
			if (callback != null)
			{
				BoolCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsControlClearAutoConnectWIFI", null);
		}

		public static void UPvr_PropertySetHomeKey(PBS_HomeEventEnum eventEnum, PBS_HomeFunctionEnum function, Action<bool> callback)
		{
			if (callback != null)
			{
				BoolCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsPropertySetHomeKey", GetEnumType(eventEnum), GetEnumType(function), null);
		}

		public static void UPvr_PropertySetHomeKeyAll(PBS_HomeEventEnum eventEnum, PBS_HomeFunctionEnum function, int timesetup, string pkg, string className, Action<bool> callback)
		{
			if (callback != null)
			{
				BoolCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsPropertySetHomeKeyAll", GetEnumType(eventEnum), GetEnumType(function), timesetup, pkg, className, null);
		}

		public static void UPvr_PropertyDisablePowerKey(bool isSingleTap, bool enable, Action<int> callback)
		{
			if (callback != null)
			{
				IntCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsPropertyDisablePowerKey", isSingleTap, enable, null);
		}

		public static void UPvr_PropertySetScreenOffDelay(PBS_ScreenOffDelayTimeEnum timeEnum, Action<int> callback)
		{
			if (callback != null)
			{
				IntCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsPropertySetScreenOffDelay", GetEnumType(timeEnum), null);
		}

		public static void UPvr_PropertySetSleepDelay(PBS_SleepDelayTimeEnum timeEnum)
		{
			System.UPvr_CallMethod(tobHelper, "pbsPropertySetSleepDelay", GetEnumType(timeEnum));
		}

		public static void UPvr_SwitchSystemFunction(PBS_SystemFunctionSwitchEnum systemFunction, PBS_SwitchEnum switchEnum)
		{
			System.UPvr_CallMethod(tobHelper, "pbsSwitchSystemFunction", GetEnumType(systemFunction), GetEnumType(switchEnum), 0);
		}

		public static void UPvr_SwitchSetUsbConfigurationOption(PBS_USBConfigModeEnum uSBConfigModeEnum)
		{
			System.UPvr_CallMethod(tobHelper, "pbsSwitchSetUsbConfigurationOption", GetEnumType(uSBConfigModeEnum), 0);
		}

		public static void UPvr_ScreenOn()
		{
			System.UPvr_CallMethod(tobHelper, "pbsScreenOn");
		}

		public static void UPvr_ScreenOff()
		{
			System.UPvr_CallMethod(tobHelper, "pbsScreenOff");
		}

		public static void UPvr_AcquireWakeLock()
		{
			System.UPvr_CallMethod(tobHelper, "pbsAcquireWakeLock");
		}

		public static void UPvr_ReleaseWakeLock()
		{
			System.UPvr_CallMethod(tobHelper, "pbsReleaseWakeLock");
		}

		public static void UPvr_EnableEnterKey()
		{
			System.UPvr_CallMethod(tobHelper, "pbsEnableEnterKey");
		}

		public static void UPvr_DisableEnterKey()
		{
			System.UPvr_CallMethod(tobHelper, "pbsDisableEnterKey");
		}

		public static void UPvr_EnableVolumeKey()
		{
			System.UPvr_CallMethod(tobHelper, "pbsEnableVolumeKey");
		}

		public static void UPvr_DisableVolumeKey()
		{
			System.UPvr_CallMethod(tobHelper, "pbsDisableVolumeKey");
		}

		public static void UPvr_EnableBackKey()
		{
			System.UPvr_CallMethod(tobHelper, "pbsEnableBackKey");
		}

		public static void UPvr_DisableBackKey()
		{
			System.UPvr_CallMethod(tobHelper, "pbsDisableBackKey");
		}

		public static void UPvr_WriteConfigFileToDataLocal(string path, string content, Action<bool> callback)
		{
			if (callback != null)
			{
				BoolCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsWriteConfigFileToDataLocal", path, content, null);
		}

		public static void UPvr_ResetAllKeyToDefault(Action<bool> callback)
		{
			if (callback != null)
			{
				BoolCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsResetAllKeyToDefault", null);
		}
	}
	public enum GlobalIntConfigs
	{
		EYE_TEXTURE_RESOLUTION0,
		EYE_TEXTURE_RESOLUTION1,
		SEENSOR_COUNT,
		ABILITY6DOF,
		PLATFORM_TYPE,
		TRACKING_MODE,
		LOG_LEVEL,
		ENBLE_HAND6DOF_BY_HEAD,
		ENBLE_6DOF_GLOBAL_TRACKING,
		TARGET_FRAME_RATE,
		iShowFPS,
		SensorMode,
		LOGICFLOW,
		EYE_TEXTURE_RES_HIGH,
		EYE_TEXTURE_RES_NORMAL,
		iCtrlModelLoadingPri,
		iPhoneHMDModeEnabled,
		isEnableBoundary,
		Enable_Activity_Rotation,
		GetDisplay_Orientation,
		GetWaitFrameNum,
		GetResetFrameNum,
		EnableFFRBYSYS,
		RotControllerMode
	}
	public enum GlobalFloatConfigs
	{
		IPD,
		VFOV,
		HFOV,
		NECK_MODEL_X,
		NECK_MODEL_Y,
		NECK_MODEL_Z,
		DISPLAY_REFRESH_RATE
	}
	public enum RenderTextureAntiAliasing
	{
		X_1 = 1,
		X_2 = 2,
		X_4 = 4,
		X_8 = 8
	}
	public enum PlatForm
	{
		Android = 1,
		IOS,
		Win,
		Notsupport
	}
	public enum RenderTextureDepth
	{
		BD_0 = 0,
		BD_16 = 16,
		BD_24 = 24
	}
	public enum RenderTextureLevel
	{
		Normal,
		High
	}
	public enum Sensorindex
	{
		Default,
		FirstSensor,
		SecondSensor
	}
	public enum Eye
	{
		LeftEye,
		RightEye,
		BothEye
	}
	public enum ResUtilsType
	{
		TYPE_TEXTSIZE,
		TYPE_COLOR,
		TYPE_TEXT,
		TYPE_FONT,
		TYPE_VALUE,
		TYPE_DRAWABLE,
		TYPE_OBJECT,
		TYPR_OBJECTARRAY
	}
	public enum TrackingOrigin
	{
		EyeLevel,
		FloorLevel,
		StageLevel
	}
	public enum EFoveationLevel
	{
		Low,
		Med,
		High,
		Top_High
	}
	public enum StereoRenderingPathPico
	{
		MultiPass,
		SinglePass
	}
	public enum pvrEyePoseStatus
	{
		kGazePointValid = 1,
		kGazeVectorValid = 2,
		kEyeOpennessValid = 4,
		kEyePupilDilationValid = 8,
		kEyePositionGuideValid = 0x10
	}
	public enum TrackingMode
	{
		PVR_TRACKING_MODE_ROTATION = 1,
		PVR_TRACKING_MODE_POSITION = 2,
		PVR_TRACKING_MODE_EYE = 4
	}
	public struct EyeTrackingData
	{
		public int leftEyePoseStatus;

		public int rightEyePoseStatus;

		public int combinedEyePoseStatus;

		public Vector3 leftEyeGazePoint;

		public Vector3 rightEyeGazePoint;

		public Vector3 combinedEyeGazePoint;

		public Vector3 leftEyeGazeVector;

		public Vector3 rightEyeGazeVector;

		public Vector3 combinedEyeGazeVector;

		public float leftEyeOpenness;

		public float rightEyeOpenness;

		public float leftEyePupilDilation;

		public float rightEyePupilDilation;

		public Vector3 leftEyePositionGuide;

		public Vector3 rightEyePositionGuide;

		public Vector3 foveatedGazeDirection;

		public int foveatedGazeTrackingState;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] reserved;
	}
	public struct EyeTrackingGazeRay
	{
		public Vector3 Direction;

		public bool IsValid;

		public Vector3 Origin;
	}
	public struct EyeDeviceInfo
	{
		public ViewFrustum targetFrustumLeft;

		public ViewFrustum targetFrustumRight;
	}
	public struct ViewFrustum
	{
		public float left;

		public float right;

		public float top;

		public float bottom;

		public float near;

		public float far;
	}
	public struct EyeSetting
	{
		public Transform eyelocalPosition;

		public Rect eyeRect;

		public float eyeFov;

		public float eyeAspect;

		public Matrix4x4 eyeProjectionMatrix;

		public Shader eyeShader;
	}
	public struct Sensor
	{
		public const string LibFileName = "Pvr_UnitySDK";

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_Enable6DofModule(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_OptionalResetSensor(int index, int resetRot, int resetPos);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_Init(int index);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_StartSensor(int index);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_StopSensor(int index);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_ResetSensor(int index);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_ResetSensorAll(int index);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetSensorState(int index, ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetMainSensorState(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetPsensorState();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetHmdPSensorStatus();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetSensorGyroscope(int index, ref float x, ref float y, ref float z);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetSensorMagnet(int index, ref float x, ref float y, ref float z);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_Get6DofSensorQualityStatus();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_Get6DofSafePanelFlag();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetReinPosition(float x, float y, float z, float w, float px, float py, float pz, int hand, bool valid, int key);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_SetTrackingOriginType(TrackingOrigin trackingOriginType);

		public static bool UPvr_Pvr_Get6DofSafePanelFlag()
		{
			return Pvr_Get6DofSafePanelFlag();
		}

		public static int UPvr_Init(int index)
		{
			return Pvr_Init(index);
		}

		public static void UPvr_InitPsensor()
		{
			Pvr_InitPsensor();
		}

		public static int UPvr_GetPsensorState()
		{
			int res = -1;
			Render.UPvr_GetIntConfig(4, ref res);
			if (res == 1)
			{
				return Pvr_GetPsensorState();
			}
			int num = Pvr_GetAndroidPsensorState();
			if (num != 0 && num != -1)
			{
				num = 1;
			}
			return num;
		}

		public static int UPvr_GetPSensorStatus()
		{
			return Pvr_GetHmdPSensorStatus();
		}

		public static void UPvr_UnregisterPsensor()
		{
			Pvr_UnregisterPsensor();
		}

		public static int UPvr_StartSensor(int index)
		{
			return Pvr_StartSensor(index);
		}

		public static int UPvr_StopSensor(int index)
		{
			return Pvr_StopSensor(index);
		}

		public static int UPvr_ResetSensor(int index)
		{
			Pvr_UnitySDKManager.SDK.resetBasePos = default(Vector3);
			return Pvr_ResetSensor(index);
		}

		public static int UPvr_OptionalResetSensor(int index, int resetRot, int resetPos)
		{
			return Pvr_OptionalResetSensor(index, resetRot, resetPos);
		}

		public static int UPvr_GetSensorState(int index, ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz)
		{
			return Pvr_GetSensorState(index, ref x, ref y, ref z, ref w, ref px, ref py, ref pz);
		}

		public static int UPvr_GetMainSensorState(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber)
		{
			return Pvr_GetMainSensorState(ref x, ref y, ref z, ref w, ref px, ref py, ref pz, ref vfov, ref hfov, ref viewNumber);
		}

		public static int UPvr_GetSensorGyroscope(int index, ref float x, ref float y, ref float z)
		{
			return Pvr_GetSensorGyroscope(index, ref x, ref y, ref z);
		}

		public static int UPvr_GetSensorMagnet(int index, ref float x, ref float y, ref float z)
		{
			return Pvr_GetSensorMagnet(index, ref x, ref y, ref z);
		}

		public static int UPvr_Get6DofSensorQualityStatus()
		{
			return Pvr_Get6DofSensorQualityStatus();
		}

		public static int UPvr_Enable6DofModule(bool enable)
		{
			return Pvr_Enable6DofModule(enable);
		}

		public static void Pvr_InitPsensor()
		{
			try
			{
				System.UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaSysActivityClass, "initPsensor", Pvr_UnitySDKRender.Instance.activity);
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
		}

		public static bool Pvr_IsHead6dofReset()
		{
			int res = 0;
			Render.UPvr_GetIntConfig(17, ref res);
			if (res > 0)
			{
				return false;
			}
			bool result = false;
			try
			{
				System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaSysActivityClass, "isHead6dofReset", Pvr_UnitySDKRender.Instance.activity);
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
			return result;
		}

		public static int Pvr_GetAndroidPsensorState()
		{
			int result = -1;
			try
			{
				System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaSysActivityClass, "getPsensorState");
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
			return result;
		}

		public static void Pvr_UnregisterPsensor()
		{
			try
			{
				System.UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaSysActivityClass, "unregisterListener");
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
		}

		public static int UPvr_ResetSensorAll(int index)
		{
			return Pvr_ResetSensorAll(index);
		}

		public static void UPvr_SetReinPosition(float x, float y, float z, float w, float px, float py, float pz, int hand, bool valid, int key)
		{
			if (PLOG.logLevel > 2)
			{
				PLOG.D("PvrLog UPvr_SetReinPosition" + x + y + z + w + px + py + pz + hand + valid.ToString() + key);
			}
			Pvr_SetReinPosition(x, y, z, w, px, py, pz, hand, valid, key);
		}

		public static bool UPvr_SetTrackingOriginType(TrackingOrigin trackingOriginType)
		{
			return Pvr_SetTrackingOriginType(trackingOriginType);
		}
	}
	public struct Render
	{
		public const string LibFileName = "Pvr_UnitySDK";

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_ChangeScreenParameters(string model, int width, int height, double xppi, double yppi, double densityDpi);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_SetRatio(float midH, float midV);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_SetPupillaryPoint(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr Pvr_GetSupportHMDTypes();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetCurrentHMDType([MarshalAs(UnmanagedType.LPStr)] string type);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetIntConfig(int configsenum, ref int res);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetFloatConfig(int configsenum, ref float res);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetupLayerData(int layerIndex, int sideMask, int textureId, int textureType, int layerFlags, float[] colorScaleAndOffset);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetupLayerCoords(int layerIndex, int sideMask, float[] lowerLeft, float[] lowerRight, float[] upperLeft, float[] upperRight);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetOverlayModelViewMatrix(int overlayType, int overlayShape, int texId, int eyeSide, int layerIndex, bool isHeadLocked, int layerFlags, float[] mvMatrix, float[] modelS, float[] modelR, float[] modelT, float[] cameraR, float[] cameraT, float[] colorScaleAndOffset);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_EnableFoveation(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetFoveationParameters(int textureId, int previousId, float focalPointX, float focalPointY, float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetFoveationResource(int textureId, int previousId, float focalPointX, float focalPointY);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetFoveationParameters2(float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetFoveationLevel(EFoveationLevel level);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern EFoveationLevel Pvr_GetFoveationLevel();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_GetIntSysProc(string property, ref int res);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetColorspaceType(int colorspaceType);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetCastingColorspaceType(int colorspaceType);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr Pvr_CreateLayerAndroidSurface(int layerType, int layerIndex);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr Pvr_GetLayerAndroidSurface(int layerType, int layerIndex);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetMonoMode(bool openMono);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_GetStencilMesh(int eye, ref int vertexCount, ref int triangleCount, ref IntPtr vertexData, ref IntPtr indexData);

		public static void UPvr_ChangeScreenParameters(string model, int width, int height, double xppi, double yppi, double densityDpi)
		{
			Pvr_ChangeScreenParameters(model, width, height, xppi, yppi, densityDpi);
		}

		public static int UPvr_SetRatio(float midH, float midV)
		{
			return Pvr_SetRatio(midH, midV);
		}

		public static void UPvr_EnableFoveation(bool enable)
		{
			if (Pvr_UnitySDKManager.SDK.SystemFFRLevel != -1 || Pvr_UnitySDKManager.SDK.SystemDebugFFRLevel != -1)
			{
				enable = true;
			}
			Pvr_EnableFoveation(enable);
		}

		[Obsolete("This API will be removed in later versions")]
		public static void UPvr_SetFoveationParameters(int textureId, int previousId, float focalPointX, float focalPointY, float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum)
		{
			Pvr_SetFoveationParameters(textureId, previousId, focalPointX, focalPointY, foveationGainX, foveationGainY, foveationArea, foveationMinimum);
		}

		public static void UPvr_SetFoveationResource(int textureId, int previousId, float focalPointX, float focalPointY)
		{
			Pvr_SetFoveationResource(textureId, previousId, focalPointX, focalPointY);
		}

		public static void SetFoveatedRenderingLevel(EFoveationLevel level)
		{
			if (Pvr_UnitySDKManager.SDK.SystemDebugFFRLevel != -1)
			{
				Pvr_SetFoveationLevel((EFoveationLevel)Pvr_UnitySDKManager.SDK.SystemDebugFFRLevel);
			}
			else if (Pvr_UnitySDKManager.SDK.SystemFFRLevel != -1)
			{
				Pvr_SetFoveationLevel((EFoveationLevel)Pvr_UnitySDKManager.SDK.SystemFFRLevel);
			}
			else
			{
				Pvr_SetFoveationLevel(level);
			}
		}

		public static EFoveationLevel GetFoveatedRenderingLevel()
		{
			return Pvr_GetFoveationLevel();
		}

		public static void SetFoveatedRenderingParameters(Vector2 ffrGainValue, float ffrAreaValue, float ffrMinimumValue)
		{
			if (Pvr_UnitySDKManager.SDK.SystemDebugFFRLevel != -1)
			{
				Pvr_SetFoveationLevel((EFoveationLevel)Pvr_UnitySDKManager.SDK.SystemDebugFFRLevel);
			}
			else if (Pvr_UnitySDKManager.SDK.SystemFFRLevel != -1)
			{
				Pvr_SetFoveationLevel((EFoveationLevel)Pvr_UnitySDKManager.SDK.SystemFFRLevel);
			}
			else
			{
				Pvr_SetFoveationParameters2(ffrGainValue.x, ffrGainValue.y, ffrAreaValue, ffrMinimumValue);
			}
		}

		public static bool UPvr_GetIntSysProc(string property, ref int res)
		{
			return Pvr_GetIntSysProc(property, ref res);
		}

		public static int UPvr_GetIntConfig(int configsenum, ref int res)
		{
			return Pvr_GetIntConfig(configsenum, ref res);
		}

		public static int UPvr_GetFloatConfig(int configsenum, ref float res)
		{
			return Pvr_GetFloatConfig(configsenum, ref res);
		}

		public static string UPvr_GetSupportHMDTypes()
		{
			IntPtr intPtr = Pvr_GetSupportHMDTypes();
			if (intPtr != IntPtr.Zero)
			{
				return Marshal.PtrToStringAnsi(intPtr);
			}
			return null;
		}

		public static void UPvr_SetCurrentHMDType(string type)
		{
			Pvr_SetCurrentHMDType(type);
		}

		public static void UPvr_SetupLayerData(int layerIndex, int sideMask, int textureId, int textureType, int layerFlags, Vector4 colorScale, Vector4 colorOffset)
		{
			Pvr_SetupLayerData(layerIndex, sideMask, textureId, textureType, layerFlags, new float[8] { colorScale.x, colorScale.y, colorScale.z, colorScale.w, colorOffset.x, colorOffset.y, colorOffset.z, colorOffset.w });
		}

		public static void UPvr_SetupLayerCoords(int layerIndex, int sideMask, float[] lowerLeft, float[] lowerRight, float[] upperLeft, float[] upperRight)
		{
			Pvr_SetupLayerCoords(layerIndex, sideMask, lowerLeft, lowerRight, upperLeft, upperRight);
		}

		public static void UPvr_SetOverlayModelViewMatrix(int overlayType, int overlayShape, int texId, int eyeSide, int layerIndex, bool isHeadLocked, int layerFlags, Matrix4x4 mvMatrix, Vector3 modelS, Quaternion modelR, Vector3 modelT, Quaternion cameraR, Vector3 cameraT, Vector4 colorScale, Vector4 colorOffset)
		{
			Pvr_SetOverlayModelViewMatrix(overlayType, overlayShape, texId, eyeSide, layerIndex, isHeadLocked, layerFlags, new float[16]
			{
				mvMatrix.m00, mvMatrix.m01, mvMatrix.m02, mvMatrix.m03, mvMatrix.m10, mvMatrix.m11, mvMatrix.m12, mvMatrix.m13, mvMatrix.m20, mvMatrix.m21,
				mvMatrix.m22, mvMatrix.m23, mvMatrix.m30, mvMatrix.m31, mvMatrix.m32, mvMatrix.m33
			}, new float[3] { modelS.x, modelS.y, modelS.z }, new float[4] { modelR.x, modelR.y, modelR.z, modelR.w }, new float[3] { modelT.x, modelT.y, modelT.z }, new float[4] { cameraR.x, cameraR.y, cameraR.z, cameraR.w }, new float[3] { cameraT.x, cameraT.y, cameraT.z }, new float[8] { colorScale.x, colorScale.y, colorScale.z, colorScale.w, colorOffset.x, colorOffset.y, colorOffset.z, colorOffset.w });
		}

		public static void UPvr_SetColorspaceType(int colorspaceType)
		{
			Pvr_SetColorspaceType(colorspaceType);
		}

		public static void UPvr_SetCastingColorspaceType(int colorspaceType)
		{
			Pvr_SetCastingColorspaceType(colorspaceType);
		}

		public static IntPtr UPvr_CreateLayerAndroidSurface(int layerType, int layerIndex)
		{
			return Pvr_CreateLayerAndroidSurface(layerType, layerIndex);
		}

		public static IntPtr UPvr_GetLayerAndroidSurface(int layerType, int layerIndex)
		{
			return Pvr_GetLayerAndroidSurface(layerType, layerIndex);
		}

		public static void UPvr_SetMonoMode(bool openMono)
		{
			Pvr_SetMonoMode(openMono);
		}

		public static void UPvr_GetStencilMesh(int eye, ref int vertexCount, ref int triangleCount, ref IntPtr vertexDataPtr, ref IntPtr indexDataPtr)
		{
			Pvr_GetStencilMesh(eye, ref vertexCount, ref triangleCount, ref vertexDataPtr, ref indexDataPtr);
		}
	}
	public struct System
	{
		public const string LibFileName = "Pvr_UnitySDK";

		public const string UnitySDKVersion = "2.8.9.12";

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_SetInitActivity(IntPtr activity, IntPtr vrActivityClass);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr Pvr_GetSDKVersion();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pvr_GetHmdHardwareVersion();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr Pvr_GetHmdFirmwareVersion();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr Pvr_GetHmdSerialNumber();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern int PVR_GetHmdBatteryStatus();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern float PVR_GetHmdBatteryTemperature();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern int PVR_SetHmdAudioStatus(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_GetEyeTrackingData(ref int leftEyePoseStatus, ref int rightEyePoseStatus, ref int combinedEyePoseStatus, ref float leftEyeGazePointX, ref float leftEyeGazePointY, ref float leftEyeGazePointZ, ref float rightEyeGazePointX, ref float rightEyeGazePointY, ref float rightEyeGazePointZ, ref float combinedEyeGazePointX, ref float combinedEyeGazePointY, ref float combinedEyeGazePointZ, ref float leftEyeGazeVectorX, ref float leftEyeGazeVectorY, ref float leftEyeGazeVectorZ, ref float rightEyeGazeVectorX, ref float rightEyeGazeVectorY, ref float rightEyeGazeVectorZ, ref float combinedEyeGazeVectorX, ref float combinedEyeGazeVectorY, ref float combinedEyeGazeVectorZ, ref float leftEyeOpenness, ref float rightEyeOpenness, ref float leftEyePupilDilation, ref float rightEyePupilDilation, ref float leftEyePositionGuideX, ref float leftEyePositionGuideY, ref float leftEyePositionGuideZ, ref float rightEyePositionGuideX, ref float rightEyePositionGuideY, ref float rightEyePositionGuideZ, ref float foveatedGazeDirectionX, ref float foveatedGazeDirectionY, ref float foveatedGazeDirectionZ, ref int foveatedGazeTrackingState);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_SetTrackingMode(int trackingMode);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pvr_GetTrackingMode();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GetRenderEventFunc();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnityEventData(long data);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_EnableSinglePass(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_SetAntiAliasing(int antiAliasing);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_SinglePassBeforeForwardOpaque();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_SetCurrentRenderTexture(uint textureId);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_SetSinglePassDepthBufferWidthHeight(int width, int height);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern int PVR_setPerformanceLevels(int cpuLevel, int gpuLevel);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_SetIPD(float distance);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern float Pvr_GetIPD();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_SetTrackingIPDEnabled(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_GetTrackingIPDEnabled();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_GetEyeTrackingAutoIPD(ref float autoIPD);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern int PVR_GetHmdAudioStatus();

		public static bool UPvr_CallStaticMethod<T>(ref T result, AndroidJavaClass jclass, string name, params object[] args)
		{
			try
			{
				result = jclass.CallStatic<T>(name, args);
				return true;
			}
			catch (AndroidJavaException ex)
			{
				PLOG.E("Exception calling static method " + name + ": " + ex);
				return false;
			}
		}

		public static bool UPvr_CallStaticMethod(AndroidJavaObject jobj, string name, params object[] args)
		{
			try
			{
				jobj.CallStatic(name, args);
				return true;
			}
			catch (AndroidJavaException ex)
			{
				PLOG.E("CallStaticMethod  Exception calling activity method " + name + ": " + ex);
				return false;
			}
		}

		public static bool UPvr_CallMethod<T>(ref T result, AndroidJavaObject jobj, string name, params object[] args)
		{
			try
			{
				result = jobj.Call<T>(name, args);
				return true;
			}
			catch (AndroidJavaException ex)
			{
				PLOG.E("Exception calling activity method " + name + ": " + ex);
				return false;
			}
		}

		public static bool UPvr_CallMethod(AndroidJavaObject jobj, string name, params object[] args)
		{
			try
			{
				jobj.Call(name, args);
				return true;
			}
			catch (AndroidJavaException ex)
			{
				PLOG.E(" Exception calling activity method " + name + ": " + ex);
				return false;
			}
		}

		public static string UPvr_GetSDKVersion()
		{
			IntPtr intPtr = Pvr_GetSDKVersion();
			if (intPtr != IntPtr.Zero)
			{
				return Marshal.PtrToStringAnsi(intPtr);
			}
			return "";
		}

		public static string UPvr_GetUnitySDKVersion()
		{
			return "2.8.9.12";
		}

		public static string UPvr_GetDeviceMode()
		{
			return SystemInfo.deviceModel;
		}

		public static string UPvr_GetDeviceModel()
		{
			return SystemInfo.deviceModel;
		}

		public static string UPvr_GetDeviceSN()
		{
			string result = "UNKONWN";
			UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaSysActivityClass, "getDeviceSN");
			return result;
		}

		public static AndroidJavaObject UPvr_GetCurrentActivity()
		{
			return new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		}

		public static bool UPvr_SetMonoPresentation()
		{
			return UPvr_CallMethod(UPvr_GetCurrentActivity(), "Pvr_setMonoPresentation");
		}

		public static bool UPvr_IsPresentationExisted()
		{
			bool result = false;
			return UPvr_CallMethod(ref result, UPvr_GetCurrentActivity(), "Pvr_isPresentationExisted") && result;
		}

		public static bool UPvr_GetMainActivityPauseStatus()
		{
			bool result = false;
			return UPvr_CallMethod(ref result, UPvr_GetCurrentActivity(), "Pvr_getMainActivityPauseStatus") && result;
		}

		public static void UPvr_Sleep()
		{
			UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaSysActivityClass, "Pvr_Sleep");
		}

		public static bool UPvr_StartHomeKeyReceiver(string startreceivre)
		{
			try
			{
				if (Pvr_UnitySDKRender.Instance != null)
				{
					UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityLongReceiver, "Pvr_StartReceiver", Pvr_UnitySDKRender.Instance.activity, startreceivre);
					PLOG.I("Start home key Receiver");
					return true;
				}
			}
			catch (Exception ex)
			{
				PLOG.E("Start home key  Receiver  Error :" + ex.ToString());
				return false;
			}
			return true;
		}

		public static bool UPvr_StopHomeKeyReceiver()
		{
			try
			{
				if (Pvr_UnitySDKRender.Instance != null)
				{
					UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityLongReceiver, "Pvr_StopReceiver", Pvr_UnitySDKRender.Instance.activity);
					PLOG.I("Stop home key Receiver");
					return true;
				}
			}
			catch (Exception ex)
			{
				PLOG.E("Stop home key Receiver Error :" + ex.ToString());
				return false;
			}
			return true;
		}

		public static void UPvr_StartVRModel()
		{
			UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityClass, "startVRModel");
		}

		public static void UPvr_RemovePlatformLogo()
		{
			UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityClass, "removePlatformLogo");
		}

		public static void UPvr_ShowPlatformLogo()
		{
			UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityClass, "showPlatformLogo");
		}

		public static bool UPvr_IsPicoActivity()
		{
			bool result = false;
			return UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "isPicoActivity", UPvr_GetCurrentActivity()) && result;
		}

		public static void UPvr_StopVRModel()
		{
			UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityClass, "stopVRModel");
		}

		public static string UPvr_GetCountryCode()
		{
			string result = "";
			UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getCountryCode", UPvr_GetCurrentActivity());
			return result;
		}

		public static bool UPvr_SetIPD(float distance)
		{
			bool flag = false;
			flag = Pvr_SetIPD(distance);
			if (flag)
			{
				for (int i = 0; i < Pvr_UnitySDKEyeManager.Instance.Eyes.Length; i++)
				{
					Pvr_UnitySDKEyeManager.Instance.Eyes[i].RefreshCameraPosition(distance);
				}
			}
			return flag;
		}

		public static float UPvr_GetIPD()
		{
			float num = Pvr_GetIPD();
			UnityEngine.Debug.Log("DISFT IPD:" + num);
			return num;
		}

		public static bool UPvr_SetTrackingIPDEnabled(bool enable)
		{
			return Pvr_SetTrackingIPDEnabled(enable);
		}

		public static bool UPvr_GetTrackingIPDEnabled()
		{
			return Pvr_GetTrackingIPDEnabled();
		}

		public static bool UPvr_GetEyeTrackingAutoIPD(ref float autoipd)
		{
			return Pvr_GetEyeTrackingAutoIPD(ref autoipd);
		}

		public static void UPvr_UnityEventData(long data)
		{
			UnityEventData(data);
		}

		public static long UPvr_GetEyeBufferData(int id)
		{
			return ((long)Pvr_UnitySDKRender.Instance.RenderviewNumber << 32) | id;
		}

		public static bool UPvr_checkDevice(string packagename)
		{
			bool result = false;
			UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "checkDevice", packagename, UPvr_GetCurrentActivity());
			return result;
		}

		public static int UPvr_GetHmdHardwareVersion()
		{
			return Pvr_GetHmdHardwareVersion();
		}

		public static string UPvr_GetHmdFirmwareVersion()
		{
			IntPtr intPtr = Pvr_GetHmdFirmwareVersion();
			if (intPtr != IntPtr.Zero)
			{
				return Marshal.PtrToStringAnsi(intPtr);
			}
			return "";
		}

		public static string UPvr_GetHmdSerialNumber()
		{
			IntPtr intPtr = Pvr_GetHmdSerialNumber();
			if (intPtr != IntPtr.Zero)
			{
				return Marshal.PtrToStringAnsi(intPtr);
			}
			return "";
		}

		public static int UPvr_GetHmdBatteryStatus()
		{
			return PVR_GetHmdBatteryStatus();
		}

		public static float UPvr_GetHmdBatteryTemperature()
		{
			return PVR_GetHmdBatteryTemperature();
		}

		public static int UPvr_SetHmdAudioStatus(bool enable)
		{
			return PVR_SetHmdAudioStatus(enable);
		}

		public static int UPvr_GetTrackingMode()
		{
			return Pvr_GetTrackingMode();
		}

		public static bool UPvr_setTrackingMode(int trackingMode)
		{
			return Pvr_SetTrackingMode(trackingMode);
		}

		public static bool UPvr_getEyeTrackingData(ref EyeTrackingData trackingData)
		{
			if (!Pvr_UnitySDKEyeManager.supportEyeTracking)
			{
				PLOG.E("The device is not supported");
				return false;
			}
			if (!Pvr_UnitySDKEyeManager.Instance.EyeTracking)
			{
				PLOG.E("Please Enable \"Pvr_UnitySDK/Head/Pvr_UnitySDKEyeManager.cs/EyeTracking\"option first.");
				return false;
			}
			bool result = Pvr_GetEyeTrackingData(ref trackingData.leftEyePoseStatus, ref trackingData.rightEyePoseStatus, ref trackingData.combinedEyePoseStatus, ref trackingData.leftEyeGazePoint.x, ref trackingData.leftEyeGazePoint.y, ref trackingData.leftEyeGazePoint.z, ref trackingData.rightEyeGazePoint.x, ref trackingData.rightEyeGazePoint.y, ref trackingData.rightEyeGazePoint.z, ref trackingData.combinedEyeGazePoint.x, ref trackingData.combinedEyeGazePoint.y, ref trackingData.combinedEyeGazePoint.z, ref trackingData.leftEyeGazeVector.x, ref trackingData.leftEyeGazeVector.y, ref trackingData.leftEyeGazeVector.z, ref trackingData.rightEyeGazeVector.x, ref trackingData.rightEyeGazeVector.y, ref trackingData.rightEyeGazeVector.z, ref trackingData.combinedEyeGazeVector.x, ref trackingData.combinedEyeGazeVector.y, ref trackingData.combinedEyeGazeVector.z, ref trackingData.leftEyeOpenness, ref trackingData.rightEyeOpenness, ref trackingData.leftEyePupilDilation, ref trackingData.rightEyePupilDilation, ref trackingData.leftEyePositionGuide.x, ref trackingData.leftEyePositionGuide.y, ref trackingData.leftEyePositionGuide.z, ref trackingData.rightEyePositionGuide.x, ref trackingData.rightEyePositionGuide.y, ref trackingData.rightEyePositionGuide.z, ref trackingData.foveatedGazeDirection.x, ref trackingData.foveatedGazeDirection.y, ref trackingData.foveatedGazeDirection.z, ref trackingData.foveatedGazeTrackingState);
			trackingData.leftEyeGazeVector.z = 0f - trackingData.leftEyeGazeVector.z;
			trackingData.rightEyeGazeVector.z = 0f - trackingData.rightEyeGazeVector.z;
			trackingData.combinedEyeGazeVector.z = 0f - trackingData.combinedEyeGazeVector.z;
			trackingData.leftEyeGazePoint.z = 0f - trackingData.leftEyeGazePoint.z;
			trackingData.rightEyeGazePoint.z = 0f - trackingData.rightEyeGazePoint.z;
			trackingData.combinedEyeGazePoint.z = 0f - trackingData.combinedEyeGazePoint.z;
			trackingData.foveatedGazeDirection.z = 0f - trackingData.foveatedGazeDirection.z;
			return result;
		}

		public static bool UPvr_getEyeTrackingGazeRay(ref EyeTrackingGazeRay gazeRay)
		{
			if (!Pvr_UnitySDKEyeManager.supportEyeTracking)
			{
				PLOG.E("The device is not supported");
				return false;
			}
			if (!Pvr_UnitySDKEyeManager.Instance.EyeTracking)
			{
				PLOG.E("Please Enable \"Pvr_UnitySDK/Head/Pvr_UnitySDKEyeManager.cs/EyeTracking\"option first.");
				return false;
			}
			EyeTrackingData trackingData = default(EyeTrackingData);
			UPvr_getEyeTrackingData(ref trackingData);
			gazeRay.IsValid = ((uint)trackingData.combinedEyePoseStatus & (true ? 1u : 0u)) != 0 && (trackingData.combinedEyePoseStatus & 2) != 0;
			if (gazeRay.IsValid)
			{
				gazeRay.Direction = trackingData.combinedEyeGazeVector;
				gazeRay.Origin = trackingData.combinedEyeGazePoint;
				gazeRay.Origin = Pvr_UnitySDKSensor.Instance.HeadPose.Matrix.MultiplyPoint(gazeRay.Origin);
				gazeRay.Direction = Pvr_UnitySDKSensor.Instance.HeadPose.Matrix.MultiplyVector(gazeRay.Direction);
				return true;
			}
			return false;
		}

		public static bool UPvr_getEyeTrackingGazeRayWorld(ref EyeTrackingGazeRay gazeRay)
		{
			if (!Pvr_UnitySDKEyeManager.supportEyeTracking)
			{
				PLOG.E("The device is not supported");
				return false;
			}
			if (!Pvr_UnitySDKEyeManager.Instance.EyeTracking)
			{
				PLOG.E("Please Enable \"Pvr_UnitySDK/Head/Pvr_UnitySDKEyeManager.cs/EyeTracking\"option first.");
				return false;
			}
			Transform transform = Pvr_UnitySDKEyeManager.Instance.transform;
			Matrix4x4 matrix4x = Matrix4x4.TRS(transform.position, transform.rotation, Vector3.one);
			EyeTrackingData trackingData = default(EyeTrackingData);
			UPvr_getEyeTrackingData(ref trackingData);
			gazeRay.IsValid = ((uint)trackingData.combinedEyePoseStatus & (true ? 1u : 0u)) != 0 && (trackingData.combinedEyePoseStatus & 2) != 0;
			if (gazeRay.IsValid)
			{
				gazeRay.Direction = trackingData.combinedEyeGazeVector;
				gazeRay.Origin = trackingData.combinedEyeGazePoint;
				gazeRay.Origin = matrix4x.MultiplyPoint(gazeRay.Origin);
				gazeRay.Direction = matrix4x.MultiplyVector(gazeRay.Direction);
				return true;
			}
			return false;
		}

		public static Vector3 UPvr_getEyeTrackingPos()
		{
			if (!Pvr_UnitySDKEyeManager.supportEyeTracking)
			{
				PLOG.E("The device is not supported");
				return Vector3.zero;
			}
			if (!Pvr_UnitySDKEyeManager.Instance.EyeTracking)
			{
				PLOG.E("Please Enable \"Pvr_UnitySDK/Head/Pvr_UnitySDKEyeManager.cs/EyeTracking\"option first.");
				return Vector3.zero;
			}
			return Pvr_UnitySDKEyeManager.Instance.GetEyeTrackingPos();
		}

		public static int UPvr_GetPhoneScreenBrightness()
		{
			int result = 0;
			UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClientClass, "Pvr_GetScreen_Brightness", UPvr_GetCurrentActivity());
			return result;
		}

		public static void UPvr_SetPhoneScreenBrightness(int level)
		{
			UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityClientClass, "Pvr_setAPPScreen_Brightness", UPvr_GetCurrentActivity(), level);
		}

		public static bool UPvr_IsPicoDefaultActivity()
		{
			using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
			{
				using AndroidJavaObject androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
				if (androidJavaObject.Call<string>("getLocalClassName", Array.Empty<object>()) == "com.unity3d.player.UnityPlayerNativeActivityPico")
				{
					return true;
				}
			}
			return false;
		}

		public static bool UPvr_EnableSinglePass(bool enable)
		{
			return Pvr_EnableSinglePass(enable);
		}

		public static void UPvr_SetAntiAliasing(int antiAliasing)
		{
			Pvr_SetAntiAliasing(antiAliasing);
		}

		public static void UPvr_SinglePassBeforeForwardOpaque()
		{
			Pvr_SinglePassBeforeForwardOpaque();
		}

		public static void UPvr_SetCurrentRenderTexture(uint textureId)
		{
			Pvr_SetCurrentRenderTexture(textureId);
		}

		public static bool UPvr_SetSinglePassDepthBufferWidthHeight(int width, int height)
		{
			return Pvr_SetSinglePassDepthBufferWidthHeight(width, height);
		}

		public static int UPVR_setPerformanceLevels(int cpuLevel, int gpuLevel)
		{
			return PVR_setPerformanceLevels(cpuLevel, gpuLevel);
		}

		public static int UPvr_GetColorRes(string name)
		{
			int result = -1;
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getColorRes", name);
			}
			catch (Exception ex)
			{
				PLOG.E("GetColorResError :" + ex.ToString());
			}
			return result;
		}

		public static int UPvr_GetConfigInt(string name)
		{
			int result = -1;
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getConfigInt", name);
			}
			catch (Exception ex)
			{
				PLOG.E("GetConfigIntError :" + ex.ToString());
			}
			return result;
		}

		public static string UPvr_GetConfigString(string name)
		{
			string result = "";
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getConfigString", name);
			}
			catch (Exception ex)
			{
				PLOG.E("GetConfigStringError :" + ex.ToString());
			}
			return result;
		}

		public static string UPvr_GetDrawableLocation(string name)
		{
			string result = "";
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getDrawableLocation", name);
			}
			catch (Exception ex)
			{
				PLOG.E("GetDrawableLocationError :" + ex.ToString());
			}
			return result;
		}

		public static int UPvr_GetTextSize(string name)
		{
			int result = -1;
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getTextSize", name);
			}
			catch (Exception ex)
			{
				PLOG.E("GetTextSizeError :" + ex.ToString());
			}
			return result;
		}

		public static string UPvr_GetLangString(string name)
		{
			string result = "";
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getLangString", name);
			}
			catch (Exception ex)
			{
				PLOG.E("GetLangStringError :" + ex.ToString());
			}
			return result;
		}

		public static string UPvr_GetStringValue(string id, int type)
		{
			string result = "";
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getStringValue", id, type);
			}
			catch (Exception ex)
			{
				PLOG.E("GetStringValueError :" + ex.ToString());
			}
			return result;
		}

		public static int UPvr_GetIntValue(string id, int type)
		{
			int result = -1;
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getIntValue", id, type);
			}
			catch (Exception ex)
			{
				PLOG.E("GetIntValueError :" + ex.ToString());
			}
			return result;
		}

		public static float UPvr_GetFloatValue(string id)
		{
			float result = -1f;
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getFloatValue", id);
			}
			catch (Exception ex)
			{
				PLOG.E("GetFloatValueError :" + ex.ToString());
			}
			return result;
		}

		public static string UPvr_GetObjectOrArray(string id, int type)
		{
			string result = "";
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getObjectOrArray", id, type);
			}
			catch (Exception ex)
			{
				PLOG.E("GetObjectOrArrayError :" + ex.ToString());
			}
			return result;
		}

		public static int UPvr_GetCharSpace(string id)
		{
			int result = -1;
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getCharSpace", id);
			}
			catch (Exception ex)
			{
				PLOG.E("GetCharSpaceError :" + ex.ToString());
			}
			return result;
		}
	}
	public struct BoundarySystem
	{
		public enum BoundaryType
		{
			OuterBoundary,
			PlayArea
		}

		public struct BoundaryTestResult
		{
			public bool IsTriggering;

			public float ClosestDistance;

			public Vector3 ClosestPoint;

			public Vector3 ClosestPointNormal;
		}

		public enum BoundaryTrackingNode
		{
			HandLeft,
			HandRight,
			Head
		}

		public enum BoundaryTrackingState
		{
			PVR_NOREASON,
			PVRRELOCATION_IN_PROGRESS,
			PVRLOW_FEATURE_COUNT_ERROR,
			PVRLOW_LIGHT_ERROR,
			PVRBRIGHT_LIGHT_ERROR,
			PVRSTEREO_CAMERA_CALIBRATION_ERROR
		}

		public const string LibFileName = "Pvr_UnitySDK";

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern float Pvr_GetFloorHeight();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetSeeThroughState();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_BoundarySetSTBackground(bool value);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetTrackingState();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_GetFrameRateLimit();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_IsBoundaryEnable();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_BoundaryGetConfigured();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_BoundaryTestNode(int node, bool isPlayArea, ref bool isTriggering, ref float closestDistance, ref float px, ref float py, ref float pz, ref float nx, ref float ny, ref float nz);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_BoundaryTestPoint(float x, float y, float z, bool isPlayArea, ref bool isTriggering, ref float closestDistance, ref float px, ref float py, ref float pz, ref float nx, ref float ny, ref float nz);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_BoundaryGetGeometry(out IntPtr handle, bool isPlayArea);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_BoundaryGetDimensions(ref float x, ref float y, ref float z, bool isPlayArea);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_BoundaryGetEnabled();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_BoundarySetVisible(bool value);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_BoundaryGetVisible();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_EnableLWRP(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_SetViewportSize(int w, int h);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_BoundarySetSeeThroughVisible(bool value);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void PVR_SetCameraImageRect(int width, int height);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetGuardianSystemDisable(bool value);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetDialogState();

		public static float UPvr_GetFloorHeight()
		{
			return Pvr_GetFloorHeight();
		}

		public static int UPvr_GetSeeThroughState()
		{
			return Pvr_GetSeeThroughState();
		}

		public static void UPvr_EnableSeeThroughManual(bool enable)
		{
			Pvr_BoundarySetSTBackground(enable);
		}

		public static BoundaryTrackingState UPvr_GetTrackingState()
		{
			return (BoundaryTrackingState)Pvr_GetTrackingState();
		}

		public static bool UPvr_GetFrameRateLimit()
		{
			return Pvr_GetFrameRateLimit();
		}

		public static bool UPvr_IsBoundaryEnable()
		{
			return Pvr_IsBoundaryEnable();
		}

		public static bool UPvr_BoundaryGetConfigured()
		{
			return Pvr_BoundaryGetConfigured();
		}

		public static BoundaryTestResult UPvr_BoundaryTestNode(BoundaryTrackingNode node, BoundaryType boundaryType)
		{
			BoundaryTestResult result = default(BoundaryTestResult);
			bool num = Pvr_BoundaryTestNode((int)node, boundaryType == BoundaryType.PlayArea, ref result.IsTriggering, ref result.ClosestDistance, ref result.ClosestPoint.x, ref result.ClosestPoint.y, ref result.ClosestPoint.z, ref result.ClosestPointNormal.x, ref result.ClosestPointNormal.y, ref result.ClosestPointNormal.z);
			result.ClosestPoint.z = 0f - result.ClosestPoint.z;
			result.ClosestPointNormal.z = 0f - result.ClosestPointNormal.z;
			if (!num)
			{
				UnityEngine.Debug.LogError($"UPvr_BoundaryTestNode({node}, {boundaryType}) API call failed!");
			}
			return result;
		}

		public static BoundaryTestResult UPvr_BoundaryTestPoint(Vector3 point, BoundaryType boundaryType)
		{
			BoundaryTestResult result = default(BoundaryTestResult);
			if (!Pvr_BoundaryTestPoint(point.x, point.y, 0f - point.z, boundaryType == BoundaryType.PlayArea, ref result.IsTriggering, ref result.ClosestDistance, ref result.ClosestPoint.x, ref result.ClosestPoint.y, ref result.ClosestPoint.z, ref result.ClosestPointNormal.x, ref result.ClosestPointNormal.y, ref result.ClosestPointNormal.z))
			{
				UnityEngine.Debug.LogError($"UPvr_BoundaryTestPoint({point}, {boundaryType}) API call failed!");
			}
			return result;
		}

		public static Vector3[] UPvr_BoundaryGetGeometry(BoundaryType boundaryType)
		{
			IntPtr handle = IntPtr.Zero;
			int num = Pvr_BoundaryGetGeometry(out handle, boundaryType == BoundaryType.PlayArea);
			if (num <= 0)
			{
				UnityEngine.Debug.LogError("Boundary geometry point count is " + num);
				return null;
			}
			int num2 = num * 3;
			float[] array = new float[num2];
			Marshal.Copy(handle, array, 0, num2);
			Vector3[] array2 = new Vector3[num];
			for (int i = 0; i < num; i++)
			{
				array2[i] = new Vector3
				{
					x = array[3 * i],
					y = array[3 * i + 1],
					z = 0f - array[3 * i + 2]
				};
			}
			return array2;
		}

		public static Vector3 UPvr_BoundaryGetDimensions(BoundaryType boundaryType)
		{
			float x = 0f;
			float y = 0f;
			float z = 0f;
			Pvr_BoundaryGetDimensions(ref x, ref y, ref z, boundaryType == BoundaryType.PlayArea);
			return new Vector3(x, y, z);
		}

		public static bool UPvr_BoundaryGetEnabled()
		{
			return Pvr_BoundaryGetEnabled();
		}

		public static void UPvr_BoundarySetVisible(bool value)
		{
			Pvr_BoundarySetVisible(value);
		}

		public static bool UPvr_BoundaryGetVisible()
		{
			return Pvr_BoundaryGetVisible();
		}

		public static bool UPvr_EnableLWRP(bool enable)
		{
			return Pvr_EnableLWRP(enable);
		}

		public static bool UPvr_SetViewportSize(int width, int height)
		{
			return Pvr_SetViewportSize(width, height);
		}

		public static void UPvr_StartCameraFrame()
		{
			try
			{
				Pvr_UnitySDKPluginEvent.Issue(RenderEventType.StartCameraFrame);
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_StartCameraFrame :" + ex.ToString());
			}
		}

		public static void UPvr_StopCameraFrame()
		{
			try
			{
				Pvr_UnitySDKPluginEvent.Issue(RenderEventType.StopCameraFrame);
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_StopCameraFrame :" + ex.ToString());
			}
		}

		public static void UPvr_BoundaryGetSeeThroughData(int cameraIndex, RenderTexture renderTexture)
		{
			try
			{
				if (renderTexture.IsCreated())
				{
					System.UPvr_UnityEventData(renderTexture.GetNativeTexturePtr().ToInt32());
					switch (cameraIndex)
					{
					case 0:
						Pvr_UnitySDKPluginEvent.Issue(RenderEventType.CameraFrameLeft);
						break;
					case 1:
						Pvr_UnitySDKPluginEvent.Issue(RenderEventType.CameraFrameRight);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_BoundaryGetSeeThroughDataError :" + ex.ToString());
			}
		}

		public static void UPvr_BoundarySetCameraImageRect(int width, int height)
		{
			try
			{
				PVR_SetCameraImageRect(width, height);
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_BoundarySetCameraImageRectError :" + ex.ToString());
			}
		}

		public static void UPvr_BoundarySetSeeThroughVisible(bool value)
		{
			try
			{
				Pvr_BoundarySetSeeThroughVisible(value);
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_BoundarySetSeeThroughVisibleError :" + ex.ToString());
			}
		}

		public static void UPvr_SetGuardianSystemDisable(bool value)
		{
			try
			{
				Pvr_SetGuardianSystemDisable(value);
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_SetGuardianSystemDisableError :" + ex.ToString());
			}
		}

		public static int UPvr_GetDialogState()
		{
			int result = 0;
			try
			{
				result = Pvr_GetDialogState();
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_GetDialogStateError :" + ex.ToString());
			}
			return result;
		}
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct PlatformSettings
	{
		public static Pvr_UnitySDKPlatformSetting.simulationType UPvr_IsCurrentDeviceValid()
		{
			if (Pvr_UnitySDKPlatformSetting.Entitlementchecksimulation)
			{
				if (Pvr_UnitySDKPlatformSetting.Instance.deviceSN.Count <= 0)
				{
					UnityEngine.Debug.Log("DISFT Entitlement Check Simulation deviceSN is Null");
					return Pvr_UnitySDKPlatformSetting.simulationType.Null;
				}
				foreach (string item in Pvr_UnitySDKPlatformSetting.Instance.deviceSN)
				{
					if (System.UPvr_GetDeviceSN() == item)
					{
						return Pvr_UnitySDKPlatformSetting.simulationType.Valid;
					}
				}
				UnityEngine.Debug.Log("DISFT Entitlement Check Simulation deviceSN is Invalid");
				return Pvr_UnitySDKPlatformSetting.simulationType.Invalid;
			}
			UnityEngine.Debug.Log("DISFT Entitlement Check Simulation DO NOT Enable");
			return Pvr_UnitySDKPlatformSetting.simulationType.Invalid;
		}

		public static bool UPvr_AppEntitlementCheck(string appid)
		{
			bool result = false;
			try
			{
				System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "verifyAPP", System.UPvr_GetCurrentActivity(), appid, "");
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
			UnityEngine.Debug.Log("PvrLog UPvr_AppEntitlementCheck" + result);
			return result;
		}

		[Obsolete("This API will be removed in later versions")]
		public static bool UPvr_KeyEntitlementCheck(string publicKey)
		{
			bool result = false;
			try
			{
				System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "verifyAPP", System.UPvr_GetCurrentActivity(), "", publicKey);
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
			UnityEngine.Debug.Log("PvrLog UPvr_KeyEntitlementCheck" + result);
			return result;
		}

		public static int UPvr_AppEntitlementCheckExtra(string appid)
		{
			return 0;
		}

		public static int UPvr_KeyEntitlementCheckExtra(string publicKey)
		{
			int result = -1;
			try
			{
				System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "verifyAPPExt", System.UPvr_GetCurrentActivity(), "", publicKey);
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
			UnityEngine.Debug.Log("PvrLog UPvr_KeyEntitlementCheck" + result);
			return result;
		}

		public static int UPvr_GetHmdAudioStatus()
		{
			return System.PVR_GetHmdAudioStatus();
		}
	}
	public enum DeviceCommand
	{
		SET_PICO_NEO_HMD_BRIGHTNESS = 12,
		SET_PICO_NEO_HMD_SLEEPDELAY
	}
	public enum BrightnessLevel
	{
		VR_BRIGHTNESS_LEVEL_MIN = 1,
		VR_BRIGHTNESS_LEVEL_MAX = 100,
		VR_BRIGHTNESS_LEVEL_DOWN = 1000,
		VR_BRIGHTNESS_LEVEL_UP = 1001,
		VR_BRIGHTNESS_LEVEL_SCREEN_OFF = -100
	}
	public struct VolumePowerBrightness
	{
		public const string LibFileName = "Pvr_UnitySDK";

		public AndroidJavaObject activity;

		public static AndroidJavaClass javaSysActivityClass;

		private static AndroidJavaClass batteryjavaVrActivityClass;

		private static AndroidJavaClass volumejavaVrActivityClass;

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_SetInitActivity(IntPtr activity, IntPtr vrActivityClass);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_IsHmdExist();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetHmdScreenBrightness();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_SetHmdScreenBrightness(int brightness);

		public static bool UPvr_IsHmdExist()
		{
			return Pvr_IsHmdExist();
		}

		public static int UPvr_GetHmdScreenBrightness()
		{
			return Pvr_GetHmdScreenBrightness();
		}

		public static bool UPvr_SetHmdScreenBrightness(int brightness)
		{
			return Pvr_SetHmdScreenBrightness(brightness);
		}

		public static bool UPvr_SetCommonBrightness(int brightness)
		{
			bool flag = false;
			if (UPvr_IsHmdExist())
			{
				return UPvr_SetHmdScreenBrightness(brightness);
			}
			return UPvr_SetBrightness(brightness);
		}

		public static int UPvr_GetCommonBrightness()
		{
			int num = 0;
			if (UPvr_IsHmdExist())
			{
				return UPvr_GetHmdScreenBrightness();
			}
			return UPvr_GetCurrentBrightness();
		}

		public static int[] UPvr_GetScreenBrightnessLevel()
		{
			return Pvr_GetScreenBrightnessLevel();
		}

		public static void UPvr_SetScreenBrightnessLevel(int vrBrightness, int level)
		{
			Pvr_SetScreenBrightnessLevel(vrBrightness, level);
		}

		public static bool UPvr_SetDevicePropForUser(DeviceCommand deviceid, string number)
		{
			return setDevicePropForUser(deviceid, number);
		}

		public static string UPvr_GetDevicePropForUser(DeviceCommand deviceid)
		{
			return getDevicePropForUser(deviceid);
		}

		public static bool UPvr_InitBatteryClass()
		{
			try
			{
				if (javaSysActivityClass == null)
				{
					javaSysActivityClass = new AndroidJavaClass("com.psmart.aosoperation.SysActivity");
				}
				if (javaSysActivityClass != null && Pvr_UnitySDKRender.Instance.activity != null)
				{
					if (batteryjavaVrActivityClass == null)
					{
						batteryjavaVrActivityClass = new AndroidJavaClass("com.psmart.aosoperation.BatteryReceiver");
					}
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				PLOG.E("startReceiver Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_InitBatteryVolClass()
		{
			try
			{
				javaSysActivityClass = new AndroidJavaClass("com.psmart.aosoperation.SysActivity");
				if (javaSysActivityClass != null && Pvr_UnitySDKRender.Instance.activity != null)
				{
					batteryjavaVrActivityClass = new AndroidJavaClass("com.psmart.aosoperation.BatteryReceiver");
					volumejavaVrActivityClass = new AndroidJavaClass("com.psmart.aosoperation.AudioReceiver");
					System.UPvr_CallStaticMethod(javaSysActivityClass, "Pvr_InitAudioDevice", Pvr_UnitySDKRender.Instance.activity);
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				PLOG.E("startReceiver Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_StartBatteryReceiver(string startreceivre)
		{
			try
			{
				System.UPvr_CallStaticMethod(batteryjavaVrActivityClass, "Pvr_StartReceiver", Pvr_UnitySDKRender.Instance.activity, startreceivre);
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E("startReceiver Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_StopBatteryReceiver()
		{
			try
			{
				System.UPvr_CallStaticMethod(batteryjavaVrActivityClass, "Pvr_StopReceiver", Pvr_UnitySDKRender.Instance.activity);
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E("startReceiver Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_SetBrightness(int brightness)
		{
			try
			{
				System.UPvr_CallStaticMethod(javaSysActivityClass, "Pvr_SetScreen_Brightness", brightness, Pvr_UnitySDKRender.Instance.activity);
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
				return false;
			}
		}

		public static int UPvr_GetCurrentBrightness()
		{
			int result = 0;
			try
			{
				System.UPvr_CallStaticMethod(ref result, javaSysActivityClass, "Pvr_GetScreen_Brightness", Pvr_UnitySDKRender.Instance.activity);
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
			}
			return result;
		}

		public static int[] Pvr_GetScreenBrightnessLevel()
		{
			int[] result = new int[1];
			try
			{
				System.UPvr_CallStaticMethod(ref result, javaSysActivityClass, "getScreenBrightnessLevel");
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
			}
			return result;
		}

		public static void Pvr_SetScreenBrightnessLevel(int vrBrightness, int level)
		{
			try
			{
				System.UPvr_CallStaticMethod(javaSysActivityClass, "setScreenBrightnessLevel", vrBrightness, level);
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
			}
		}

		public static bool UPvr_StartAudioReceiver(string startreceivre)
		{
			try
			{
				System.UPvr_CallStaticMethod(volumejavaVrActivityClass, "Pvr_StartReceiver", Pvr_UnitySDKRender.Instance.activity, startreceivre);
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E("startReceiver Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_StopAudioReceiver()
		{
			try
			{
				System.UPvr_CallStaticMethod(volumejavaVrActivityClass, "Pvr_StopReceiver", Pvr_UnitySDKRender.Instance.activity);
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E("startReceiver Error :" + ex.ToString());
				return false;
			}
		}

		public static int UPvr_GetMaxVolumeNumber()
		{
			int result = 0;
			try
			{
				System.UPvr_CallStaticMethod(ref result, javaSysActivityClass, "Pvr_GetMaxAudionumber");
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
			}
			return result;
		}

		public static int UPvr_GetCurrentVolumeNumber()
		{
			int result = 0;
			try
			{
				System.UPvr_CallStaticMethod(ref result, javaSysActivityClass, "Pvr_GetAudionumber");
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
			}
			return result;
		}

		public static bool UPvr_VolumeUp()
		{
			try
			{
				System.UPvr_CallStaticMethod(javaSysActivityClass, "Pvr_UpAudio");
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_VolumeDown()
		{
			try
			{
				System.UPvr_CallStaticMethod(javaSysActivityClass, "Pvr_DownAudio");
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_SetVolumeNum(int volume)
		{
			try
			{
				System.UPvr_CallStaticMethod(javaSysActivityClass, "Pvr_ChangeAudio", volume);
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_SetAudio(string s)
		{
			return false;
		}

		public static bool UPvr_SetBattery(string s)
		{
			return false;
		}

		private static string getDevicePropForUser(DeviceCommand deviceid)
		{
			string result = "0";
			System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getDevicePropForUser", (int)deviceid);
			return result;
		}

		private static bool setDevicePropForUser(DeviceCommand deviceid, string number)
		{
			bool result = false;
			System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "setDevicePropForUser", (int)deviceid, number);
			return result;
		}
	}
}
namespace Pvr_UnitySDKAPI.Achievement
{
	public sealed class AchievementCore
	{
		private static bool IsPlatformInitialized = true;

		public static bool LogMessages = false;

		public static bool IsInitialized()
		{
			return IsPlatformInitialized;
		}

		public static void Initialize()
		{
		}

		public static void RegisterNetwork()
		{
			Pvr_AchievementAPI.RegisterNetwork();
		}

		public static void UnRegisterNetwork()
		{
			Pvr_AchievementAPI.UnRegisterNetwork();
		}
	}
	public static class Achievements
	{
		public static Pvr_Request<Pvr_AchievementUpdate> Init()
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementUpdate>(Pvr_AchievementAPI.Init());
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementUpdate> AddCount(string name, long count)
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementUpdate>(Pvr_AchievementAPI.pvr_Achievements_AddCount(name, count));
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementUpdate> AddFields(string name, string fields)
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementUpdate>(Pvr_AchievementAPI.pvr_Achievements_AddFields(name, fields));
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementDefinitionList> GetAllDefinitions()
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementDefinitionList>(Pvr_AchievementAPI.pvr_Achievements_GetAllDefinitions());
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementProgressList> GetAllProgress()
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementProgressList>(Pvr_AchievementAPI.pvr_Achievements_GetAllProgress());
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementDefinitionList> GetDefinitionsByName(string[] names)
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementDefinitionList>(Pvr_AchievementAPI.pvr_Achievements_GetDefinitionsByName(names, (names != null) ? names.Length : 0));
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementProgressList> GetProgressByName(string[] names)
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementProgressList>(Pvr_AchievementAPI.pvr_Achievements_GetProgressByName(names, (names != null) ? names.Length : 0));
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementUpdate> Unlock(string name)
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementUpdate>(Pvr_AchievementAPI.pvr_Achievements_Unlock(name));
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementDefinitionList> GetNextAchievementDefinitionListPage(Pvr_AchievementDefinitionList list)
		{
			if (!list.HasNextPage)
			{
				UnityEngine.Debug.LogWarning("Platform.GetNextAchievementDefinitionListPage: List has no next page");
				return null;
			}
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementDefinitionList>(Pvr_AchievementAPI.pvr_HTTP_GetWithMessageType(list.NextUrl, Pvr_Message.MessageType.Achievements_GetNextAchievementDefinitionArrayPage));
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementProgressList> GetNextAchievementProgressListPage(Pvr_AchievementProgressList list)
		{
			if (!list.HasNextPage)
			{
				UnityEngine.Debug.LogWarning("Platform.GetNextAchievementProgressListPage: List has no next page");
				return null;
			}
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementProgressList>(Pvr_AchievementAPI.pvr_HTTP_GetWithMessageType(list.NextUrl, Pvr_Message.MessageType.Achievements_GetNextAchievementProgressArrayPage));
			}
			return null;
		}
	}
	public enum AchievementType
	{
		[Description("UNKNOWN")]
		Unknown,
		[Description("SIMPLE")]
		Simple,
		[Description("BITFIELD")]
		Bitfield,
		[Description("COUNT")]
		Count
	}
	public class Pvr_AchievementAPI
	{
		private static AndroidJavaClass achievementAPI = new AndroidJavaClass("com.pico.achievenment.AchievementAPI");

		private static AndroidJavaClass definitionArrayHandle = new AndroidJavaClass("com.picovr.achievement.utils.pvrAchievementDefinitionArrayHandle");

		private static AndroidJavaClass definitionHandle = new AndroidJavaClass("com.picovr.achievement.utils.pvrAchievementDefinitionHandle");

		private static AndroidJavaClass progressArrayHandle = new AndroidJavaClass("com.picovr.achievement.utils.pvrAchievementProgressArrayHandle");

		private static AndroidJavaClass progressHandle = new AndroidJavaClass("com.picovr.achievement.utils.pvrAchievementProgressHandle");

		private static AndroidJavaClass updateHandle = new AndroidJavaClass("com.picovr.achievement.utils.pvrAchievementUpdateHandle");

		private static AndroidJavaObject errorHandle = new AndroidJavaObject("com.picovr.achievement.utils.pvrAchievementErrorHandle");

		private static AndroidJavaObject unityInterface = new AndroidJavaObject("com.pico.loginpaysdk.UnityInterface");

		private static string openId;

		private static string accessToken;

		private static string appId = Pvr_UnitySDKPlatformSetting.Instance.appID;

		internal static long Init()
		{
			AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
			unityInterface.Call("init", @static);
			unityInterface.Call("authSSO");
			AndroidJavaObject androidJavaObject = new AndroidJavaClass("com.pico.loginpaysdk.utils.PicoAccessTokenKeeper").CallStatic<AndroidJavaObject>("readAccessToken", new object[1] { @static });
			accessToken = androidJavaObject.Call<string>("getAccessToken", Array.Empty<object>());
			openId = androidJavaObject.Call<string>("getOpenId", Array.Empty<object>());
			return achievementAPI.CallStatic<long>("init", new object[3] { accessToken, openId, @static });
		}

		internal static void RegisterNetwork()
		{
			AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
			achievementAPI.CallStatic("registerNetwork", @static);
		}

		internal static void UnRegisterNetwork()
		{
			achievementAPI.CallStatic("unregisterNetwork");
		}

		internal static AndroidJavaObject PopMessage()
		{
			return achievementAPI.CallStatic<AndroidJavaObject>("pvr_PopMessage", Array.Empty<object>());
		}

		internal static string pvr_Error_GetMessage(AndroidJavaObject popMessage)
		{
			return errorHandle.CallStatic<string>("pvr_Error_GetMessage", new object[1] { popMessage });
		}

		internal static int pvr_Error_GetHttpCode(AndroidJavaObject popMessage)
		{
			return errorHandle.CallStatic<int>("pvr_Error_GetHttpCode", new object[1] { popMessage });
		}

		internal static int pvr_Error_GetCode(AndroidJavaObject popMessage)
		{
			return errorHandle.CallStatic<int>("pvr_Error_GetCode", new object[1] { popMessage });
		}

		internal static long pvr_Achievements_AddCount(string name, long count)
		{
			return achievementAPI.CallStatic<long>("pvr_Achievements_AddCount", new object[3] { name, count, accessToken });
		}

		internal static long pvr_Achievements_AddFields(string name, string fields)
		{
			return achievementAPI.CallStatic<long>("pvr_Achievements_AddFields", new object[3] { name, fields, accessToken });
		}

		internal static long pvr_Achievements_GetAllDefinitions()
		{
			AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
			return achievementAPI.CallStatic<long>("pvr_Achievements_GetAllDefinitions", new object[2] { appId, @static });
		}

		internal static long pvr_Achievements_GetAllProgress()
		{
			return achievementAPI.CallStatic<long>("pvr_Achievements_GetAllProgress", new object[1] { accessToken });
		}

		internal static long pvr_Achievements_GetDefinitionsByName(string[] names, int v)
		{
			AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
			return achievementAPI.CallStatic<long>("pvr_Achievements_GetDefinitionsByName", new object[2] { names, @static });
		}

		internal static long pvr_Achievements_GetProgressByName(string[] names, int v)
		{
			return achievementAPI.CallStatic<long>("pvr_Achievements_GetProgressByName", new object[2] { names, accessToken });
		}

		internal static long pvr_Achievements_Unlock(string name)
		{
			return achievementAPI.CallStatic<long>("pvr_Achievements_Unlock", new object[2] { name, accessToken });
		}

		internal static long pvr_HTTP_GetWithMessageType(string nextUrl, Pvr_Message.MessageType messageType)
		{
			long result = 0L;
			switch (messageType)
			{
			case Pvr_Message.MessageType.Achievements_GetNextAchievementDefinitionArrayPage:
			{
				AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
				result = achievementAPI.CallStatic<long>("pvr_Achievements_GetAllDefinitionsByUrl", new object[2] { nextUrl, @static });
				break;
			}
			case Pvr_Message.MessageType.Achievements_GetNextAchievementProgressArrayPage:
				result = achievementAPI.CallStatic<long>("pvr_Achievements_GetAllProgressByUrl", new object[1] { nextUrl });
				break;
			}
			return result;
		}

		internal static long pvr_Message_GetType(AndroidJavaObject popMessage)
		{
			return popMessage.Call<AndroidJavaObject>("getHandleType", Array.Empty<object>()).Call<long>("getIndex", Array.Empty<object>());
		}

		internal static bool pvr_Message_IsError(AndroidJavaObject popMessage)
		{
			return popMessage.Call<bool>("isMessage_IsError", Array.Empty<object>());
		}

		internal static long pvr_Message_GetRequestID(AndroidJavaObject popMessage)
		{
			return popMessage.Call<long>("getId", Array.Empty<object>());
		}

		internal static string pvr_Message_GetString(AndroidJavaObject popMessage)
		{
			return popMessage.Call<string>("getContent", Array.Empty<object>());
		}

		internal static bool pvr_AchievementUpdate_GetJustUnlocked(AndroidJavaObject popMessage)
		{
			return updateHandle.CallStatic<bool>("pvr_AchievementUpdate_GetJustUnlocked", new object[1] { popMessage });
		}

		internal static string pvr_AchievementUpdate_GetName(AndroidJavaObject popMessage)
		{
			return updateHandle.CallStatic<string>("pvr_AchievementUpdate_GetName", new object[1] { popMessage });
		}

		internal static int pvr_AchievementProgressArray_GetSize(AndroidJavaObject msg)
		{
			return progressArrayHandle.CallStatic<int>("pvr_AchievementProgressArray_GetSize", new object[1] { msg });
		}

		internal static AndroidJavaObject pvr_AchievementProgressArray_GetElement(AndroidJavaObject msg, int index)
		{
			return progressArrayHandle.CallStatic<AndroidJavaObject>("pvr_AchievementProgressArray_GetElement", new object[2] { msg, index });
		}

		internal static string pvr_AchievementProgressArray_GetNextUrl(AndroidJavaObject msg)
		{
			return progressArrayHandle.CallStatic<string>("pvr_AchievementProgressArray_GetNextUrl", new object[1] { msg });
		}

		internal static string pvr_AchievementProgress_GetBitfield(AndroidJavaObject msg)
		{
			return progressHandle.CallStatic<string>("pvr_AchievementProgress_GetBitfield", new object[1] { msg });
		}

		internal static long pvr_AchievementProgress_GetCount(AndroidJavaObject msg)
		{
			return progressHandle.CallStatic<long>("pvr_AchievementProgress_GetCount", new object[1] { msg });
		}

		internal static bool pvr_AchievementProgress_GetIsUnlocked(AndroidJavaObject msg)
		{
			return progressHandle.CallStatic<bool>("pvr_AchievementProgress_GetIsUnlocked", new object[1] { msg });
		}

		internal static string pvr_AchievementProgress_GetName(AndroidJavaObject msg)
		{
			return progressHandle.CallStatic<string>("pvr_AchievementProgress_GetName", new object[1] { msg });
		}

		internal static DateTime pvr_AchievementProgress_GetUnlockTime(AndroidJavaObject msg)
		{
			new DateTime(1970, 1, 1, 0, 0, 0, 0);
			return DateTimeFromNative(progressHandle.CallStatic<long>("pvr_AchievementProgress_GetUnlockTime", new object[1] { msg }));
		}

		internal static DateTime DateTimeFromNative(long seconds_since_the_one_true_epoch)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(seconds_since_the_one_true_epoch).ToLocalTime();
		}

		internal static int pvr_AchievementDefinitionArray_GetSize(AndroidJavaObject msg)
		{
			return definitionArrayHandle.CallStatic<int>("pvr_AchievementDefinitionArray_GetSize", new object[1] { msg });
		}

		internal static AndroidJavaObject pvr_AchievementDefinitionArray_GetElement(AndroidJavaObject msg, int index)
		{
			return definitionArrayHandle.CallStatic<AndroidJavaObject>("pvr_AchievementDefinitionArray_GetElement", new object[2] { msg, index });
		}

		internal static string pvr_AchievementDefinitionArray_GetNextUrl(AndroidJavaObject msg)
		{
			return definitionArrayHandle.CallStatic<string>("pvr_AchievementDefinitionArray_GetNextUrl", new object[1] { msg });
		}

		internal static AchievementType pvr_AchievementDefinition_GetType(AndroidJavaObject msg)
		{
			return (AchievementType)definitionHandle.CallStatic<AndroidJavaObject>("pvr_AchievementDefinition_GetType", new object[1] { msg }).Call<int>("getIndex", Array.Empty<object>());
		}

		internal static string pvr_AchievementDefinition_GetName(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<string>("pvr_AchievementDefinition_GetName", new object[1] { msg });
		}

		internal static int pvr_AchievementDefinition_GetBitfieldLength(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<int>("pvr_AchievementDefinition_GetBitfieldLength", new object[1] { msg });
		}

		internal static long pvr_AchievementDefinition_GetTarget(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<long>("pvr_AchievementDefinition_GetTarget", new object[1] { msg });
		}

		internal static string pvr_AchievementDefinition_GetTitle(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<string>("pvr_AchievementDefinition_GetTitle", new object[1] { msg });
		}

		internal static string pvr_AchievementDefinition_GetUnlockedDescription(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<string>("pvr_AchievementDefinition_GetUnlocked_description", new object[1] { msg });
		}

		internal static string pvr_AchievementDefinition_GetLockedIcon(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<string>("pvr_AchievementDefinition_GetLocked_image", new object[1] { msg });
		}

		internal static bool pvr_AchievementDefinition_GetIsSecrect(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<bool>("pvr_AchievementDefinition_GetIs_secret", new object[1] { msg });
		}

		internal static string pvr_AchievementDefinition_GetUnlockedIcon(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<string>("pvr_AchievementDefinition_GetUnlocked_image", new object[1] { msg });
		}

		internal static string pvr_AchievementDefinition_GetDescription(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<string>("pvr_AchievementDefinition_GetDescription", new object[1] { msg });
		}
	}
	public class Pvr_AchievementDefinition
	{
		public readonly AchievementType Type;

		public readonly string Name;

		public readonly int BitfieldLength;

		public readonly long Target;

		public readonly string Title;

		public readonly string Description;

		public readonly string UnlockedDescription;

		public readonly string UnlockedIcon;

		public readonly string LockedIcon;

		public readonly bool IsSecrect;

		public Pvr_AchievementDefinition(AndroidJavaObject msg)
		{
			Type = Pvr_AchievementAPI.pvr_AchievementDefinition_GetType(msg);
			Name = Pvr_AchievementAPI.pvr_AchievementDefinition_GetName(msg);
			BitfieldLength = Pvr_AchievementAPI.pvr_AchievementDefinition_GetBitfieldLength(msg);
			Target = Pvr_AchievementAPI.pvr_AchievementDefinition_GetTarget(msg);
			Title = Pvr_AchievementAPI.pvr_AchievementDefinition_GetTitle(msg);
			Description = Pvr_AchievementAPI.pvr_AchievementDefinition_GetDescription(msg);
			UnlockedDescription = Pvr_AchievementAPI.pvr_AchievementDefinition_GetUnlockedDescription(msg);
			UnlockedIcon = Pvr_AchievementAPI.pvr_AchievementDefinition_GetUnlockedIcon(msg);
			LockedIcon = Pvr_AchievementAPI.pvr_AchievementDefinition_GetLockedIcon(msg);
			IsSecrect = Pvr_AchievementAPI.pvr_AchievementDefinition_GetIsSecrect(msg);
		}
	}
	public class Pvr_AchievementDefinitionList : Pvr_DeserializableList<Pvr_AchievementDefinition>
	{
		public Pvr_AchievementDefinitionList(AndroidJavaObject msg)
		{
			int num = Pvr_AchievementAPI.pvr_AchievementDefinitionArray_GetSize(msg);
			data = new List<Pvr_AchievementDefinition>(num);
			for (int i = 0; i < num; i++)
			{
				data.Add(new Pvr_AchievementDefinition(Pvr_AchievementAPI.pvr_AchievementDefinitionArray_GetElement(msg, i)));
			}
			nextUrl = Pvr_AchievementAPI.pvr_AchievementDefinitionArray_GetNextUrl(msg);
		}
	}
	public class Pvr_AchievementProgress
	{
		public readonly string Bitfield;

		public readonly long Count;

		public readonly bool IsUnlocked;

		public readonly string Name;

		public readonly DateTime UnlockTime;

		public Pvr_AchievementProgress(AndroidJavaObject msg)
		{
			Bitfield = Pvr_AchievementAPI.pvr_AchievementProgress_GetBitfield(msg);
			Count = Pvr_AchievementAPI.pvr_AchievementProgress_GetCount(msg);
			IsUnlocked = Pvr_AchievementAPI.pvr_AchievementProgress_GetIsUnlocked(msg);
			Name = Pvr_AchievementAPI.pvr_AchievementProgress_GetName(msg);
			UnlockTime = Pvr_AchievementAPI.pvr_AchievementProgress_GetUnlockTime(msg);
		}
	}
	public class Pvr_AchievementProgressList : Pvr_DeserializableList<Pvr_AchievementProgress>
	{
		public Pvr_AchievementProgressList(AndroidJavaObject msg)
		{
			int num = Pvr_AchievementAPI.pvr_AchievementProgressArray_GetSize(msg);
			data = new List<Pvr_AchievementProgress>(num);
			for (int i = 0; i < num; i++)
			{
				data.Add(new Pvr_AchievementProgress(Pvr_AchievementAPI.pvr_AchievementProgressArray_GetElement(msg, i)));
			}
			nextUrl = Pvr_AchievementAPI.pvr_AchievementProgressArray_GetNextUrl(msg);
		}
	}
	public class Pvr_AchievementUpdate
	{
		public readonly bool JustUnlocked;

		public readonly string Name;

		public Pvr_AchievementUpdate(AndroidJavaObject msg)
		{
			JustUnlocked = Pvr_AchievementAPI.pvr_AchievementUpdate_GetJustUnlocked(msg);
			Name = Pvr_AchievementAPI.pvr_AchievementUpdate_GetName(msg);
		}
	}
	public class Pvr_DeserializableList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		protected List<T> data;

		protected string nextUrl;

		protected string previousUrl;

		public int Count => data.Count;

		bool ICollection<T>.IsReadOnly => ((ICollection<T>)data).IsReadOnly;

		public T this[int index]
		{
			get
			{
				return data[index];
			}
			set
			{
				data[index] = value;
			}
		}

		public bool HasNextPage => !string.IsNullOrEmpty(NextUrl);

		public bool HasPreviousPage => !string.IsNullOrEmpty(PreviousUrl);

		public string NextUrl => nextUrl;

		public string PreviousUrl => previousUrl;

		public int IndexOf(T obj)
		{
			return data.IndexOf(obj);
		}

		public void Add(T item)
		{
			data.Add(item);
		}

		public void Clear()
		{
			data.Clear();
		}

		public bool Contains(T item)
		{
			return data.Contains(item);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			data.CopyTo(array, arrayIndex);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return data.GetEnumerator();
		}

		public void Insert(int index, T item)
		{
			data.Insert(index, item);
		}

		public bool Remove(T item)
		{
			return data.Remove(item);
		}

		public void RemoveAt(int index)
		{
			data.RemoveAt(index);
		}

		private IEnumerator GetEnumerator1()
		{
			return GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator1();
		}
	}
	public static class Pvr_Callback
	{
		private class RequestCallback
		{
			private Pvr_Message.Callback messageCallback;

			public RequestCallback()
			{
			}

			public RequestCallback(Pvr_Message.Callback callback)
			{
				messageCallback = callback;
			}

			public virtual void HandleMessage(Pvr_Message msg)
			{
				if (messageCallback != null)
				{
					messageCallback(msg);
				}
			}
		}

		private sealed class RequestCallback<T> : RequestCallback
		{
			private Pvr_Message<T>.Callback callback;

			public RequestCallback(Pvr_Message<T>.Callback callback)
			{
				this.callback = callback;
			}

			public override void HandleMessage(Pvr_Message msg)
			{
				if (callback != null)
				{
					if (msg is Pvr_Message<T>)
					{
						callback((Pvr_Message<T>)msg);
					}
					else
					{
						UnityEngine.Debug.LogError("Unable to handle message: " + msg.GetType());
					}
				}
			}
		}

		private static Dictionary<long, Request> requestIDsToRequests = new Dictionary<long, Request>();

		private static Dictionary<Pvr_Message.MessageType, RequestCallback> notificationCallbacks = new Dictionary<Pvr_Message.MessageType, RequestCallback>();

		internal static void AddRequest(Request request)
		{
			if (request.RequestID <= 2)
			{
				long requestID = request.RequestID;
				if ((ulong)requestID <= 2uL)
				{
					switch (requestID)
					{
					case 0L:
						UnityEngine.Debug.LogError("An PARAM_INVALIDE error occurred. Request failed.");
						return;
					case 1L:
						UnityEngine.Debug.LogError("An NETWORK_INVALIDE error occurred. Request failed.");
						return;
					case 2L:
						UnityEngine.Debug.LogError("An NOT_INTIALIZE error occurred. Request failed.");
						return;
					}
				}
				UnityEngine.Debug.LogError("An unknown error occurred. Request failed.");
			}
			else
			{
				requestIDsToRequests[request.RequestID] = request;
			}
		}

		internal static void RunCallbacks()
		{
			while (true)
			{
				Pvr_Message pvr_Message = Pvr_Message.PopMessage();
				if (pvr_Message != null)
				{
					HandleMessage(pvr_Message);
					continue;
				}
				break;
			}
		}

		internal static void RunLimitedCallbacks(uint limit)
		{
			for (int i = 0; i < limit; i++)
			{
				Pvr_Message pvr_Message = Pvr_Message.PopMessage();
				if (pvr_Message != null)
				{
					HandleMessage(pvr_Message);
					continue;
				}
				break;
			}
		}

		internal static void OnApplicationQuit()
		{
			requestIDsToRequests.Clear();
			notificationCallbacks.Clear();
		}

		internal static void HandleMessage(Pvr_Message msg)
		{
			if (msg.RequestID != 0L && requestIDsToRequests.TryGetValue(msg.RequestID, out var value))
			{
				try
				{
					value.HandleMessage(msg);
					return;
				}
				finally
				{
					requestIDsToRequests.Remove(msg.RequestID);
				}
			}
			if (notificationCallbacks.TryGetValue(msg.Type, out var value2))
			{
				value2.HandleMessage(msg);
			}
		}
	}
	public class Pvr_CallbackRunner : MonoBehaviour
	{
		public bool IsPersistantBetweenSceneLoads = true;

		private void Awake()
		{
			if (UnityEngine.Object.FindObjectOfType<Pvr_CallbackRunner>() != this)
			{
				UnityEngine.Debug.LogWarning("You only need one instance of CallbackRunner");
			}
			if (IsPersistantBetweenSceneLoads)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			}
		}

		private void Update()
		{
			Request.RunCallbacks();
		}

		private void OnApplicationQuit()
		{
			Pvr_Callback.OnApplicationQuit();
		}
	}
	public abstract class Pvr_Message<T> : Pvr_Message
	{
		public new delegate void Callback(Pvr_Message<T> message);

		private T data;

		public T Data => data;

		public Pvr_Message(AndroidJavaObject msg)
			: base(msg)
		{
			if (!base.IsError)
			{
				data = GetDataFromMessage(msg);
			}
		}

		protected abstract T GetDataFromMessage(AndroidJavaObject msg);
	}
	public class Pvr_Message
	{
		public delegate void Callback(Pvr_Message message);

		public enum MessageType : uint
		{
			Unknown = 0u,
			Achievements_AddCount = 65495601u,
			Achievements_AddFields = 346693929u,
			Achievements_GetAllDefinitions = 64177549u,
			Achievements_GetAllProgress = 1335877149u,
			Achievements_GetDefinitionsByName = 1653670332u,
			Achievements_GetNextAchievementDefinitionArrayPage = 712888917u,
			Achievements_GetNextAchievementProgressArrayPage = 792913703u,
			Achievements_GetProgressByName = 354837425u,
			Achievements_Unlock = 1497156573u,
			Achievements_WriteAchievementProgress = 121027549u,
			Achievements_VerifyAccessToken = 53284924u
		}

		internal delegate Pvr_Message ExtraMessageTypesHandler(AndroidJavaObject messageHandle, MessageType message_type);

		private MessageType type;

		private long requestID;

		private Error error;

		public MessageType Type => type;

		public bool IsError => error != null;

		public long RequestID => requestID;

		internal static ExtraMessageTypesHandler HandleExtraMessageTypes { private get; set; }

		public Pvr_Message(AndroidJavaObject msg)
		{
			type = (MessageType)Pvr_AchievementAPI.pvr_Message_GetType(msg);
			bool num = Pvr_AchievementAPI.pvr_Message_IsError(msg);
			requestID = Pvr_AchievementAPI.pvr_Message_GetRequestID(msg);
			if (num)
			{
				error = new Error(Pvr_AchievementAPI.pvr_Error_GetCode(msg), Pvr_AchievementAPI.pvr_Error_GetMessage(msg), Pvr_AchievementAPI.pvr_Error_GetHttpCode(msg));
			}
			else if (AchievementCore.LogMessages)
			{
				string text = Pvr_AchievementAPI.pvr_Message_GetString(msg);
				if (text != null)
				{
					UnityEngine.Debug.Log(text);
				}
				else
				{
					UnityEngine.Debug.Log($"null message string {msg}");
				}
			}
		}

		public virtual Error GetError()
		{
			return error;
		}

		public virtual Pvr_AchievementDefinitionList GetAchievementDefinitions()
		{
			return null;
		}

		public virtual Pvr_AchievementProgressList GetAchievementProgressList()
		{
			return null;
		}

		public virtual Pvr_AchievementUpdate GetAchievementUpdate()
		{
			return null;
		}

		public virtual string GetString()
		{
			return null;
		}

		internal static Pvr_Message ParseMessageHandle(AndroidJavaObject messageHandle)
		{
			if (messageHandle == null)
			{
				return null;
			}
			Pvr_Message result = null;
			switch ((MessageType)Pvr_AchievementAPI.pvr_Message_GetType(messageHandle))
			{
			case MessageType.Achievements_GetAllDefinitions:
			case MessageType.Achievements_GetNextAchievementDefinitionArrayPage:
			case MessageType.Achievements_GetDefinitionsByName:
				result = new MessageWithAchievementDefinitions(messageHandle);
				break;
			case MessageType.Achievements_GetProgressByName:
			case MessageType.Achievements_GetNextAchievementProgressArrayPage:
			case MessageType.Achievements_GetAllProgress:
				result = new MessageWithAchievementProgressList(messageHandle);
				break;
			case MessageType.Achievements_VerifyAccessToken:
			case MessageType.Achievements_AddCount:
			case MessageType.Achievements_AddFields:
			case MessageType.Achievements_Unlock:
				result = new MessageWithAchievementUpdate(messageHandle);
				break;
			}
			return result;
		}

		public static Pvr_Message PopMessage()
		{
			return ParseMessageHandle(Pvr_AchievementAPI.PopMessage());
		}
	}
	public class MessageWithAchievementDefinitions : Pvr_Message<Pvr_AchievementDefinitionList>
	{
		public MessageWithAchievementDefinitions(AndroidJavaObject msg)
			: base(msg)
		{
		}

		public override Pvr_AchievementDefinitionList GetAchievementDefinitions()
		{
			return base.Data;
		}

		protected override Pvr_AchievementDefinitionList GetDataFromMessage(AndroidJavaObject msg)
		{
			return new Pvr_AchievementDefinitionList(msg);
		}
	}
	public class MessageWithAchievementProgressList : Pvr_Message<Pvr_AchievementProgressList>
	{
		public MessageWithAchievementProgressList(AndroidJavaObject msg)
			: base(msg)
		{
		}

		public override Pvr_AchievementProgressList GetAchievementProgressList()
		{
			return base.Data;
		}

		protected override Pvr_AchievementProgressList GetDataFromMessage(AndroidJavaObject msg)
		{
			return new Pvr_AchievementProgressList(msg);
		}
	}
	public class MessageWithAchievementUpdate : Pvr_Message<Pvr_AchievementUpdate>
	{
		public MessageWithAchievementUpdate(AndroidJavaObject msg)
			: base(msg)
		{
		}

		public override Pvr_AchievementUpdate GetAchievementUpdate()
		{
			return base.Data;
		}

		protected override Pvr_AchievementUpdate GetDataFromMessage(AndroidJavaObject msg)
		{
			return new Pvr_AchievementUpdate(msg);
		}
	}
	public class MessageWithString : Pvr_Message<string>
	{
		public MessageWithString(AndroidJavaObject msg)
			: base(msg)
		{
		}

		public override string GetString()
		{
			return base.Data;
		}

		protected override string GetDataFromMessage(AndroidJavaObject msg)
		{
			return Pvr_AchievementAPI.pvr_Message_GetString(msg);
		}
	}
	public class Error
	{
		public readonly int Code;

		public readonly int HttpCode;

		public readonly string Message;

		public Error(int code, string message, int httpCode)
		{
			Message = message;
			Code = code;
			HttpCode = httpCode;
		}
	}
	public sealed class Pvr_Request<T> : Request
	{
		private Pvr_Message<T>.Callback callback_;

		public Pvr_Request(long requestID)
			: base(requestID)
		{
		}

		public Pvr_Request<T> OnComplete(Pvr_Message<T>.Callback callback)
		{
			if (callback_ != null)
			{
				throw new UnityException("Attempted to attach multiple handlers to a Request.  This is not allowed.");
			}
			callback_ = callback;
			Pvr_Callback.AddRequest(this);
			return this;
		}

		public override void HandleMessage(Pvr_Message msg)
		{
			if (!(msg is Pvr_Message<T>))
			{
				UnityEngine.Debug.LogError("Unable to handle message: " + msg.GetType());
				return;
			}
			if (callback_ != null)
			{
				callback_((Pvr_Message<T>)msg);
				return;
			}
			throw new UnityException("Request with no handler.  This should never happen.");
		}
	}
	public class Request
	{
		private Pvr_Message.Callback callback_;

		public long RequestID { get; set; }

		public Request(long requestID)
		{
			RequestID = requestID;
		}

		public Request OnComplete(Pvr_Message.Callback callback)
		{
			callback_ = callback;
			Pvr_Callback.AddRequest(this);
			return this;
		}

		public virtual void HandleMessage(Pvr_Message msg)
		{
			if (callback_ != null)
			{
				callback_(msg);
				return;
			}
			throw new UnityException("Request with no handler.  This should never happen.");
		}

		public static void RunCallbacks(uint limit = 0u)
		{
			if (limit == 0)
			{
				Pvr_Callback.RunCallbacks();
			}
			else
			{
				Pvr_Callback.RunLimitedCallbacks(limit);
			}
		}
	}
}
namespace InfinityEngine
{
	[ExecuteInEditMode]
	public class BlendingEffect : MonoBehaviour
	{
		[Range(0f, 1f)]
		public float Amount = 0.5f;

		public float edgeSharpness = 1f;

		[Range(0f, 1f)]
		public float minBlending = 0.15f;

		[Range(0f, 1f)]
		public float maxBlending = 1f;

		public float seethroughness = 1f;

		public float distortion = 0.2f;

		public Texture2D mainTexture;

		public Texture2D normalTexture;

		public Shader shader;

		private Material material;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (mainTexture == null || normalTexture == null || shader == null)
			{
				material = null;
				return;
			}
			if (material == null)
			{
				material = new Material(shader);
				material.SetTexture("_BlendTex", mainTexture);
				material.SetTexture("_BumpMap", normalTexture);
			}
			if (!Application.isPlaying)
			{
				material.SetTexture("_BlendTex", mainTexture);
				material.SetTexture("_BumpMap", normalTexture);
				edgeSharpness = Mathf.Max(1f, edgeSharpness);
			}
			material.SetFloat("_BlendAmount", Mathf.Clamp01(Mathf.Clamp01(Amount) * (maxBlending - minBlending) + minBlending));
			material.SetFloat("_EdgeSharpness", edgeSharpness);
			material.SetFloat("_SeeThroughness", seethroughness);
			material.SetFloat("_Distortion", distortion);
			Graphics.Blit(source, destination, material);
		}
	}
	public class PlaySoundOnClick : MonoBehaviour
	{
		public AudioClip clip;

		private void Start()
		{
			GetComponent<Button>().onClick.AddListener(delegate
			{
				SoundManager.PlayEffect(clip);
			});
		}

		private void Update()
		{
		}
	}
}
namespace InfinityEngine.Utils
{
	public static class AssetReferences
	{
		private static Texture2D logo;

		private static Texture2D helpIconEnable;

		private static Texture2D helpIconDisable;

		private static Texture2D searchIcon;

		private static Texture2D minusIcon;

		private static Texture2D plusIcon;

		private static Texture2D saveIcon;

		private static Texture2D loadIcon;

		private static Texture2D editIcon;

		private static Texture2D fbICon;

		private static Texture2D twitterIcon;

		private static Texture2D docIcon;

		private static Texture2D rateIcon;

		private static Texture2D moreIcon;

		private static Texture2D supportIcon;

		private static Texture2D achievementIconEnable;

		private static Texture2D leaderboardIconEnable;

		private static Texture2D achievementIconDisable;

		private static Texture2D leaderboardIconDisable;

		private static Texture2D google_translate_icon;

		private static GUISkin infinityEditorSkin;

		private static Font fontAwesomeFont;

		public static Texture2D Logo => logo ?? (logo = Resources.Load<Texture2D>("Textures/logo"));

		public static Texture2D HelpIconEnable => helpIconEnable ?? (helpIconEnable = Resources.Load<Texture2D>("Textures/help_icon_enable"));

		public static Texture2D HelpIconDisable => helpIconDisable ?? (helpIconDisable = Resources.Load<Texture2D>("Textures/help_icon_disable"));

		public static Texture2D SearchIcon => searchIcon ?? (searchIcon = Resources.Load<Texture2D>("Textures/search_icon"));

		public static Texture2D MinusIcon => minusIcon ?? (minusIcon = Resources.Load<Texture2D>("Textures/minus_icon"));

		public static Texture2D PlusIcon => plusIcon ?? (plusIcon = Resources.Load<Texture2D>("Textures/plus_icon"));

		public static Texture2D SaveIcon => saveIcon ?? (saveIcon = Resources.Load<Texture2D>("Textures/save_icon"));

		public static Texture2D LoadIcon => loadIcon ?? (loadIcon = Resources.Load<Texture2D>("Textures/load_icon"));

		public static Texture2D EditIcon => editIcon ?? (editIcon = Resources.Load<Texture2D>("Textures/edit_icon"));

		public static Texture2D FbICon => fbICon ?? (fbICon = Resources.Load<Texture2D>("Textures/facebook_icon"));

		public static Texture2D TwitterIcon => twitterIcon ?? (twitterIcon = Resources.Load<Texture2D>("Textures/twitter_icon"));

		public static Texture2D DocIcon => docIcon ?? (docIcon = Resources.Load<Texture2D>("Textures/doc_icon"));

		public static Texture2D RateIcon => rateIcon ?? (rateIcon = Resources.Load<Texture2D>("Textures/rate_icon"));

		public static Texture2D MoreIcon => moreIcon ?? (moreIcon = Resources.Load<Texture2D>("Textures/more_games_icon"));

		public static Texture2D SupportIcon => supportIcon ?? (supportIcon = Resources.Load<Texture2D>("Textures/support_icon"));

		public static Texture2D AchievementIconEnable => achievementIconEnable ?? (achievementIconEnable = Resources.Load<Texture2D>("Textures/achievement_enable"));

		public static Texture2D LeaderboardIconEnable => leaderboardIconEnable ?? (leaderboardIconEnable = Resources.Load<Texture2D>("Textures/leaderboard_enable"));

		public static Texture2D AchievementIconDisable => achievementIconDisable ?? (achievementIconDisable = Resources.Load<Texture2D>("Textures/achievement_disable"));

		public static Texture2D LeaderboardIconDisable => leaderboardIconDisable ?? (leaderboardIconDisable = Resources.Load<Texture2D>("Textures/leaderboard_disable"));

		public static Texture2D GoogleTranslateIcon => google_translate_icon ?? (google_translate_icon = Resources.Load<Texture2D>("Textures/google_translate_icon"));

		public static GUISkin InfinityEditorSkin => infinityEditorSkin ?? (infinityEditorSkin = Resources.Load<GUISkin>("Skins/infinity-editor-skin"));

		public static GUIStyle AccordionHeader => InfinityEditorSkin.GetStyle("AccordionHeader");

		public static GUIStyle FontAwesome => InfinityEditorSkin.GetStyle("FontAwesome");

		public static Font FontAwesomeFont => fontAwesomeFont ?? (fontAwesomeFont = Resources.Load<Font>("Fonts/FontAwesome"));

		public static GUIStyle GetFontAwesomeStyle(GUIStyle copy)
		{
			return new GUIStyle(copy)
			{
				font = FontAwesomeFont
			};
		}
	}
}
namespace InfinityEngine.Localization
{
	[RequireComponent(typeof(Button))]
	public class Flag : MonoBehaviour
	{
		[SerializeField]
		private Language language;

		public bool loadNextLevel;

		private void Start()
		{
			GetComponent<Button>().onClick.AddListener(delegate
			{
				ISILocalization.ChangeLanguage(language);
				if (loadNextLevel)
				{
					ISILocalization.LoadNextLevel();
				}
			});
		}
	}
	[AddComponentMenu("InfinityEngine/Localization/ISI Localization")]
	public class ISILocalization : InfinityEngine.DesignPatterns.Singleton<ISILocalization>
	{
		private static ISILocalization InstanceReference;

		private const string ApplicationLanguagePreferenceKey = "___APPLICATION_LANGUAGE___";

		public const string DefaultLanguagePreferenceKey = "___DEFAULT_LANGUAGE_PREF___";

		public const string PrefabName = "ISILocalizationPrefab";

		public const string PrefabPath = "Assets/InfinityEngine/Gen/Resources/ISILocalizationPrefab.prefab";

		public const string LanguagePaths = "InfinityEngine/Gen/Xml/ISI Localization/{0}/strings.xml";

		internal LocalizedLanguage m_currentLanguage;

		internal Language m_defaultLanguage;

		internal bool m_isInitialized;

		public static Action onLanguageChanged;

		[SerializeField]
		internal Scene m_nextScene;

		[SerializeField]
		internal int m_loadSceneDelay = 3;

		[SerializeField]
		internal List<LocalizedLanguage> m_languages;

		[SerializeField]
		internal List<string> m_stringKeys;

		[SerializeField]
		internal List<string> m_audiosKeys;

		[SerializeField]
		internal List<string> m_spriteKeys;

		[SerializeField]
		[MinMaxRange(1f, "GetStringMaxRange")]
		internal MinMax m_stringKeysRange;

		[MinMaxRange(1f, "GetAudioMaxRange")]
		[SerializeField]
		internal MinMax m_spriteKeysRange;

		[MinMaxRange(1f, "GetSpriteMaxRange")]
		[SerializeField]
		internal MinMax m_audioKeysRange;

		private Language DefaultLanguage
		{
			get
			{
				string @string = PlayerPrefs.GetString("___DEFAULT_LANGUAGE_PREF___", Language.English.ToString());
				m_defaultLanguage = (Language)Enum.Parse(typeof(Language), @string);
				return m_defaultLanguage;
			}
		}

		public List<LocalizedLanguage> LocalizedLanguages
		{
			get
			{
				return m_languages ?? (m_languages = new List<LocalizedLanguage>());
			}
			set
			{
				m_languages = value;
			}
		}

		public List<string> StringKeys
		{
			get
			{
				return m_stringKeys ?? (m_stringKeys = new List<string>());
			}
			set
			{
				m_stringKeys = value;
			}
		}

		public List<string> AudioKeys
		{
			get
			{
				return m_audiosKeys ?? (m_audiosKeys = new List<string>());
			}
			set
			{
				m_audiosKeys = value;
			}
		}

		public List<string> SpriteKeys
		{
			get
			{
				return m_spriteKeys ?? (m_spriteKeys = new List<string>());
			}
			set
			{
				m_spriteKeys = value;
			}
		}

		public int LanguageCount => LocalizedLanguages.Count;

		public static bool IsInitialized => InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.m_isInitialized;

		public static Language CurrentLanguage
		{
			get
			{
				if (LoadIfNotInScene())
				{
					return InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.m_currentLanguage.Language;
				}
				return Language.English;
			}
		}

		public Dictionary<string, List<string>> Keys => new Dictionary<string, List<string>>
		{
			{ "strings", StringKeys },
			{ "audios", AudioKeys },
			{ "sprites", SpriteKeys }
		};

		private int GetStringMaxRange()
		{
			return Math.Max(0, StringKeys.Count);
		}

		private int GetAudioMaxRange()
		{
			return Math.Max(0, AudioKeys.Count);
		}

		private int GetSpriteMaxRange()
		{
			return Math.Max(0, SpriteKeys.Count);
		}

		public void AddLanguage(LocalizedLanguage language)
		{
			LocalizedLanguages.Add(language);
		}

		public void ReplaceLocalizedLanguage(LocalizedLanguage language)
		{
			bool exists = false;
			LocalizedLanguages.ForEach(delegate(LocalizedLanguage model)
			{
				if (model.Language == language.Language)
				{
					model.LocalizedStrings = language.LocalizedStrings;
					exists = true;
				}
			});
			if (!exists)
			{
				LocalizedLanguages.Add(language);
			}
		}

		public bool HasLanguage(Language language)
		{
			return LocalizedLanguages.Any((LocalizedLanguage token) => token.Language == language);
		}

		public void Validate()
		{
			foreach (LocalizedLanguage language in m_languages)
			{
				language.LocalizedAudio = language.LocalizedAudio.Where((AudioClipKV elem) => m_audiosKeys.Contains(elem.Key)).ToList();
				language.LocalizedStrings = language.LocalizedStrings.Where((StringKV elem) => m_stringKeys.Contains(elem.Key)).ToList();
				language.LocalizedSprites = language.LocalizedSprites.Where((SpriteKV elem) => m_spriteKeys.Contains(elem.Key)).ToList();
			}
		}

		public static string GetValueOf(string name)
		{
			if (LoadIfNotInScene())
			{
				return InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.m_currentLanguage.GetString(name);
			}
			InfinityEngine.Utils.Debugger.LogError("ISI Localization is not initialized !", InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.gameObject);
			return null;
		}

		public static string GetFormatedValueOf(string key, params object[] data)
		{
			LoadIfNotInScene();
			string valueOf = GetValueOf(key);
			if (string.IsNullOrEmpty(valueOf))
			{
				return null;
			}
			return string.Format(valueOf, data);
		}

		public static AudioClip GetAudio(string name)
		{
			if (LoadIfNotInScene())
			{
				return InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.m_currentLanguage.GetAudio(name);
			}
			InfinityEngine.Utils.Debugger.LogError("ISILocalization is not initialized !", InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.gameObject);
			return null;
		}

		public static Sprite GetSprite(string name)
		{
			if (LoadIfNotInScene())
			{
				return InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.m_currentLanguage.GetSprite(name);
			}
			InfinityEngine.Utils.Debugger.LogError("ISILocalization is not initialized !", InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.gameObject);
			return null;
		}

		public static bool ChangeLanguage(Language language)
		{
			if (InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.LocalizedLanguages == null && InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.LocalizedLanguages.Count == 0)
			{
				return false;
			}
			InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.m_currentLanguage = InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.LocalizedLanguages.Find((LocalizedLanguage model) => model.Language == language);
			if (InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.m_currentLanguage != null)
			{
				InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.m_isInitialized = true;
				PlayerPrefs.SetString("___APPLICATION_LANGUAGE___", language.ToString());
				LocalizedString.OnLanguageChanged();
				LocalizedSprite.OnLanguageChanged();
				if (onLanguageChanged != null)
				{
					onLanguageChanged();
				}
				return true;
			}
			return false;
		}

		public static void LoadNextLevel()
		{
			if (InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.m_nextScene == null)
			{
				InfinityEngine.Utils.Debugger.LogError("There is no specifed scene to load", InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance);
			}
			else
			{
				Infinity.LoadLevelAfterDelay(InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.m_nextScene.SceneName, InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.m_loadSceneDelay);
			}
		}

		public static bool LoadIfNotInScene()
		{
			if (InstanceReference == null)
			{
				InstanceReference = UnityEngine.Object.FindObjectOfType<ISILocalization>();
			}
			if (InstanceReference == null)
			{
				GameObject gameObject = Resources.Load<GameObject>("ISILocalizationPrefab");
				if (gameObject == null)
				{
					InfinityEngine.Utils.Debugger.LogError("There is not ISILocalization prefab in resources folders ! ", InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.gameObject);
					return false;
				}
				UnityEngine.Object.Instantiate(gameObject);
				InstanceReference = InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance;
				if (InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.LocalizedLanguages == null || InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.LocalizedLanguages.Count == 0)
				{
					InfinityEngine.Utils.Debugger.LogError("ISILocalization is not Setup ! ", InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.gameObject);
					return false;
				}
				if (ChangeLanguage(InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.DefaultLanguage))
				{
					return true;
				}
				InfinityEngine.Utils.Debugger.LogError($"{InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.m_defaultLanguage} language is not register in ISILocalization !", InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.gameObject);
				return false;
			}
			if (InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.m_currentLanguage == null)
			{
				ChangeLanguage(InfinityEngine.DesignPatterns.Singleton<ISILocalization>.Instance.DefaultLanguage);
				return true;
			}
			return true;
		}
	}
	public struct ISIString
	{
		public string key { get; private set; }

		public ISIString(string key)
		{
			this.key = key;
		}

		public string Format(params object[] arg)
		{
			return ISILocalization.GetFormatedValueOf(key, arg);
		}

		public static implicit operator string(ISIString self)
		{
			return ISILocalization.GetValueOf(self.key);
		}
	}
	[Serializable]
	public enum Language
	{
		English,
		French,
		Spanish,
		Italian,
		German,
		Korean,
		Chinese,
		Japanese,
		Russian,
		Portuguese,
		Polish,
		Bengali,
		Bosnian,
		Catalan,
		Czech,
		Welsh,
		Danish,
		Finnish,
		Hindi,
		Croatian,
		Hungarian,
		Indonesian,
		Dutch,
		Slovak,
		Albanian,
		Serbian,
		Swedish,
		Swahili,
		Tamil,
		Thai,
		Turkish,
		Vietnamese
	}
	public static class LanguageExtensions
	{
		public static Locale ToLocale(this Language language)
		{
			return Locale.WithName(language.ToString());
		}

		public static string Code(this Language language)
		{
			return language.ToLocale().LanguageCode;
		}
	}
	[Serializable]
	public class Locale
	{
		public static Locale Bengali = new Locale("Bengali", "bn", "");

		public static Locale Bosnian = new Locale("Bosnian", "bs", "");

		public static Locale Catalan = new Locale("Catalan", "ca", "");

		public static Locale Czech = new Locale("Czech", "cs", "");

		public static Locale Welsh = new Locale("Welsh", "cy", "");

		public static Locale Danish = new Locale("Danish", "da", "");

		public static Locale German = new Locale("German", "de", "");

		public static Locale English = new Locale("English", "en", "");

		public static Locale Spanish = new Locale("Spanish", "es", "");

		public static Locale Finnish = new Locale("Finnish", "fi", "");

		public static Locale French = new Locale("French", "fr", "");

		public static Locale Hindi = new Locale("Hindi", "hi", "");

		public static Locale Croatian = new Locale("Croatian", "hr", "");

		public static Locale Hungarian = new Locale("Hungarian", "hu", "");

		public static Locale Indonesian = new Locale("Indonesian", "in", "");

		public static Locale Italian = new Locale("Italian", "it", "");

		public static Locale Japanese = new Locale("Japanese", "ja", "");

		public static Locale Korean = new Locale("Korean", "ko", "");

		public static Locale Dutch = new Locale("Dutch", "nl", "");

		public static Locale Polish = new Locale("Polish", "pl", "");

		public static Locale Portuguese = new Locale("Portuguese", "pt", "");

		public static Locale Russian = new Locale("Russian", "ru", "");

		public static Locale Slovak = new Locale("Slovak", "sk", "");

		public static Locale Albanian = new Locale("Albanian", "sq", "");

		public static Locale Serbian = new Locale("Serbian", "sr", "");

		public static Locale Swedish = new Locale("Swedish", "sv", "");

		public static Locale Swahili = new Locale("Swahili", "sw", "");

		public static Locale Tamil = new Locale("Tamil", "ta", "");

		public static Locale Thai = new Locale("Thai", "th", "");

		public static Locale Turkish = new Locale("Turkish", "tr", "");

		public static Locale Vietnamese = new Locale("Vietnamese", "vi", "");

		public static Locale Chinese = new Locale("Chinese", "zh", "");

		public string Name { get; set; }

		public string LanguageCode { get; set; }

		public string Country { get; set; }

		public static Locale[] AllLocales
		{
			get
			{
				Type type = typeof(Locale);
				return (from field in type.GetFields()
					where field.FieldType == type
					select (Locale)field.GetValue(null)).ToArray();
			}
		}

		public string Informations => Name + " : " + LanguageCode + " : " + Country;

		public Locale(string name, string language, string country)
		{
			Name = name;
			LanguageCode = language;
			Country = country;
		}

		public static Locale WithName(string name)
		{
			return AllLocales.FirstOrDefault((Locale elem) => elem.Name == name);
		}

		public override string ToString()
		{
			return Name;
		}
	}
	[AddComponentMenu("InfinityEngine/Localization/Localized Audio")]
	public class LocalizedAudio : MonoBehaviour
	{
		[Popup("BatteryHint, BubbleGunHint, Cube, GrabEndHint, GrabStartHint, GuideboxHint, MusicboxHint, Pyramid, WindingHint, CCuboid, SemiCylinder, AirplaneHint", PopupValueTypes.String, true)]
		[SerializeField]
		private string key;

		private AudioClip clip;

		public void Play()
		{
			if (key == null)
			{
				InfinityEngine.Utils.Debugger.LogError("This audio key is null", base.gameObject);
				return;
			}
			clip = ISILocalization.GetAudio(key);
			if (clip == null)
			{
				InfinityEngine.Utils.Debugger.LogError("There is not localized audio with the  key" + key, base.gameObject);
			}
			else
			{
				AudioSource.PlayClipAtPoint(clip, Vector3.zero);
			}
		}
	}
	[Serializable]
	public class LocalizedLanguage
	{
		private int translationStep;

		public bool isExpanded;

		public bool isBeingAutoTranslated;

		public float translationProgress;

		[SerializeField]
		private Texture2D m_flag;

		[SerializeField]
		private Language m_language;

		[SerializeField]
		private List<StringKV> m_localizedStrings;

		[SerializeField]
		private List<AudioClipKV> m_localizedAudio;

		[SerializeField]
		private List<SpriteKV> m_localizedSprites;

		[SerializeField]
		private string m_languageName;

		[SerializeField]
		private string m_languageCode;

		public Language Language
		{
			get
			{
				return m_language;
			}
			set
			{
				m_flag = Resources.Load<Texture2D>($"Flags/{value}_FLAG".ToLower());
				m_language = value;
			}
		}

		public string LanguageName
		{
			get
			{
				if (string.IsNullOrEmpty(m_languageName))
				{
					m_languageName = Language.ToString();
				}
				return m_languageName;
			}
		}

		public string LanguageCode
		{
			get
			{
				if (m_languageCode == null)
				{
					m_languageCode = Language.Code();
				}
				return m_languageCode;
			}
		}

		public Texture2D Flag => m_flag;

		public List<StringKV> LocalizedStrings
		{
			get
			{
				return m_localizedStrings;
			}
			set
			{
				m_localizedStrings = value;
			}
		}

		public List<AudioClipKV> LocalizedAudio
		{
			get
			{
				return m_localizedAudio;
			}
			set
			{
				m_localizedAudio = value;
			}
		}

		public List<SpriteKV> LocalizedSprites
		{
			get
			{
				return m_localizedSprites;
			}
			set
			{
				m_localizedSprites = value;
			}
		}

		public LocalizedLanguage()
			: this(new List<StringKV>())
		{
		}

		public LocalizedLanguage(List<StringKV> strings)
		{
			m_localizedStrings = strings;
			m_localizedAudio = new List<AudioClipKV>();
			m_localizedSprites = new List<SpriteKV>();
		}

		public void SetString(string key, string value)
		{
			StringKV stringKV = m_localizedStrings.Find((StringKV e) => e.Key == key);
			if (stringKV == null)
			{
				m_localizedStrings.Add(new StringKV(key, value));
			}
			else
			{
				stringKV.Value = value;
			}
		}

		public string GetString(string key)
		{
			return LocalizedStrings.Find((StringKV e) => e.Key == key)?.Value;
		}

		public void SetAudio(string key, AudioClip value)
		{
			AudioClipKV audioClipKV = m_localizedAudio.Find((AudioClipKV e) => e.Key == key);
			if (audioClipKV == null)
			{
				m_localizedAudio.Add(new AudioClipKV(key, value));
			}
			else
			{
				audioClipKV.Value = value;
			}
		}

		public AudioClip GetAudio(string key)
		{
			return m_localizedAudio.Find((AudioClipKV e) => e.Key == key)?.Value;
		}

		public void SetSprite(string key, Sprite value)
		{
			SpriteKV spriteKV = m_localizedSprites.Find((SpriteKV e) => e.Key == key);
			if (spriteKV == null)
			{
				m_localizedSprites.Add(new SpriteKV(key, value));
			}
			else
			{
				spriteKV.Value = value;
			}
		}

		public Sprite GetSprite(string key)
		{
			return m_localizedSprites.Find((SpriteKV e) => e.Key == key)?.Value;
		}

		public override string ToString()
		{
			return m_language.ToString();
		}

		public void UpdateTranslationProgress(int totalSteps)
		{
			translationStep++;
			translationProgress = (float)translationStep / (float)totalSteps;
			if (translationStep >= totalSteps)
			{
				isBeingAutoTranslated = false;
				translationProgress = 0f;
				translationProgress = 0f;
			}
		}
	}
	[AddComponentMenu("InfinityEngine/Localization/Localized Sprite")]
	public class LocalizedSprite : MonoBehaviour
	{
		public enum SpriteComponentType
		{
			Image,
			SpriteRenderer
		}

		[SerializeField]
		private SpriteComponentType type;

		[Popup("Cactus, CandyCane, ChristmasBall, MusicWinding, PlaneBattery, Present, Star, TeddyBear, Vespa, S02, S03, S04, S10, S11, S12, S20, S21, S22", PopupValueTypes.String, true)]
		[SerializeField]
		private string key;

		private Image image;

		private SpriteRenderer spriteRenderer;

		private static List<LocalizedSprite> LocalizedSprites;

		private void Start()
		{
			if (type == SpriteComponentType.Image)
			{
				image = GetComponent<Image>();
				if (image == null)
				{
					InfinityEngine.Utils.Debugger.LogError("There is no Image component attached to this GameObject", base.gameObject);
					return;
				}
			}
			else
			{
				spriteRenderer = GetComponent<SpriteRenderer>();
				if (spriteRenderer == null)
				{
					InfinityEngine.Utils.Debugger.LogError("There is no SpriteRenderer component attached to this GameObject", base.gameObject);
					return;
				}
			}
			if (ISILocalization.LoadIfNotInScene())
			{
				Infinity.When(() => ISILocalization.IsInitialized, _OnLanguageChanged);
			}
			if (LocalizedSprites == null)
			{
				LocalizedSprites = new List<LocalizedSprite>();
			}
			if (!LocalizedSprites.Contains(this))
			{
				LocalizedSprites.Add(this);
			}
		}

		private void _OnLanguageChanged()
		{
			if (type == SpriteComponentType.Image)
			{
				image.sprite = ISILocalization.GetSprite(key.Trim());
			}
			else if (type == SpriteComponentType.SpriteRenderer)
			{
				spriteRenderer.sprite = ISILocalization.GetSprite(key.Trim());
			}
		}

		public static void OnLanguageChanged()
		{
			if (LocalizedSprites != null)
			{
				LocalizedSprites.ForEach(delegate(LocalizedSprite arg)
				{
					arg._OnLanguageChanged();
				});
			}
		}
	}
	[AddComponentMenu("InfinityEngine/Localization/Localized String")]
	public class LocalizedString : MonoBehaviour
	{
		private enum TextComponentType
		{
			Text,
			TextMesh,
			TextMeshPro,
			TextMeshProUGUI
		}

		[SerializeField]
		private TextComponentType type;

		[Popup("Welcome, ChooseProfile, CreatorIntro, ExploreCompleted, ExploreInstruction, SplitIntro, HiddenCube, HiddenCubeHint, GuideIntro, CountIntro, LoadIntro, ThreeViewIntro, ThreeView, LoadCubeMemory, CubeIntro, LoadTangramMemory, BlocksIntro, AssessmentCompleted, Tangram, ChooseAnswer, ContinuePlay, LoadSuccess, PlayIntro, CrystalIntro, GrabHint, GrabComplete, DialHint, PadHint, MedalHint, MedalComplete, VendingHint, VendingComplete, BubbleGunHint, BatteryHint, MusicboxHint, WindingHint, GuideboxHint, GrabStartHint, GrabEndHint, AirplaneHint, PoolTen, SplitTen, HouseWelcome, Symbol, MatchIntro, Cycle, Sudoku, ChooseItems, AlreadyHaveItem, MedalNotEnough, ExchangeHint, Create, PrepareMaterials, UnneededMaterial, CreateSuccessfully, MaterialNotEnough, MaterialTooMuch, Front, Left, Right, Back, Reset, Go, Clue, Junior, Basic, Senior, CameraHint, SharePhotoHint, MagicLab, TangramGame, Magicbox, Train, Fruits, Cubes, FruiterIntro, FlareGunHint, ProjectorHint", PopupValueTypes.String, true)]
		[SerializeField]
		private string key;

		private Text label;

		private TextMesh textMesh;

		private TMP_Text textMeshPro;

		private TextMeshProUGUI textMeshProUGUI;

		private static List<LocalizedString> LocalizedStrings;

		private void Start()
		{
			FindComponent();
			if (ISILocalization.LoadIfNotInScene())
			{
				Infinity.When(() => ISILocalization.IsInitialized, _OnLanguageChanged);
			}
			if (LocalizedStrings == null)
			{
				LocalizedStrings = new List<LocalizedString>();
			}
			if (!LocalizedStrings.Contains(this))
			{
				LocalizedStrings.Add(this);
			}
		}

		private void FindComponent()
		{
			object obj = null;
			switch (type)
			{
			case TextComponentType.Text:
				obj = (label = GetComponent<Text>());
				break;
			case TextComponentType.TextMesh:
				obj = (textMesh = GetComponent<TextMesh>());
				break;
			case TextComponentType.TextMeshPro:
				obj = (textMeshPro = GetComponent<TMP_Text>());
				break;
			case TextComponentType.TextMeshProUGUI:
				obj = (textMeshProUGUI = GetComponent<TextMeshProUGUI>());
				break;
			}
			if (obj == null)
			{
				InfinityEngine.Utils.Debugger.LogError($"There is no {type} component attached to this GameObject", this);
			}
		}

		private void _OnLanguageChanged()
		{
			if (label != null)
			{
				label.text = ISILocalization.GetValueOf(key);
			}
			if (textMesh != null)
			{
				textMesh.text = ISILocalization.GetValueOf(key);
			}
			if (textMeshPro != null)
			{
				textMeshPro.text = ISILocalization.GetValueOf(key.Trim());
			}
			if (textMeshProUGUI != null)
			{
				textMeshProUGUI.text = ISILocalization.GetValueOf(key);
			}
		}

		public static void OnLanguageChanged()
		{
			if (LocalizedStrings != null)
			{
				LocalizedStrings.ForEach(delegate(LocalizedString arg)
				{
					arg._OnLanguageChanged();
				});
			}
		}
	}
	public static class R3
	{
		public static class strings
		{
			public const string Names = "Welcome, ChooseProfile, CreatorIntro, ExploreCompleted, ExploreInstruction, SplitIntro, HiddenCube, HiddenCubeHint, GuideIntro, CountIntro, LoadIntro, ThreeViewIntro, ThreeView, LoadCubeMemory, CubeIntro, LoadTangramMemory, BlocksIntro, AssessmentCompleted, Tangram, ChooseAnswer, ContinuePlay, LoadSuccess, PlayIntro, CrystalIntro, GrabHint, GrabComplete, DialHint, PadHint, MedalHint, MedalComplete, VendingHint, VendingComplete, BubbleGunHint, BatteryHint, MusicboxHint, WindingHint, GuideboxHint, GrabStartHint, GrabEndHint, AirplaneHint, PoolTen, SplitTen, HouseWelcome, Symbol, MatchIntro, Cycle, Sudoku, ChooseItems, AlreadyHaveItem, MedalNotEnough, ExchangeHint, Create, PrepareMaterials, UnneededMaterial, CreateSuccessfully, MaterialNotEnough, MaterialTooMuch, Front, Left, Right, Back, Reset, Go, Clue, Junior, Basic, Senior, CameraHint, SharePhotoHint, MagicLab, TangramGame, Magicbox, Train, Fruits, Cubes, FruiterIntro, FlareGunHint, ProjectorHint";

			public static ISIString Welcome = new ISIString("Welcome");

			public static ISIString ChooseProfile = new ISIString("ChooseProfile");

			public static ISIString CreatorIntro = new ISIString("CreatorIntro");

			public static ISIString ExploreCompleted = new ISIString("ExploreCompleted");

			public static ISIString ExploreInstruction = new ISIString("ExploreInstruction");

			public static ISIString SplitIntro = new ISIString("SplitIntro");

			public static ISIString HiddenCube = new ISIString("HiddenCube");

			public static ISIString HiddenCubeHint = new ISIString("HiddenCubeHint");

			public static ISIString GuideIntro = new ISIString("GuideIntro");

			public static ISIString CountIntro = new ISIString("CountIntro");

			public static ISIString LoadIntro = new ISIString("LoadIntro");

			public static ISIString ThreeViewIntro = new ISIString("ThreeViewIntro");

			public static ISIString ThreeView = new ISIString("ThreeView");

			public static ISIString LoadCubeMemory = new ISIString("LoadCubeMemory");

			public static ISIString CubeIntro = new ISIString("CubeIntro");

			public static ISIString LoadTangramMemory = new ISIString("LoadTangramMemory");

			public static ISIString BlocksIntro = new ISIString("BlocksIntro");

			public static ISIString AssessmentCompleted = new ISIString("AssessmentCompleted");

			public static ISIString Tangram = new ISIString("Tangram");

			public static ISIString ChooseAnswer = new ISIString("ChooseAnswer");

			public static ISIString ContinuePlay = new ISIString("ContinuePlay");

			public static ISIString LoadSuccess = new ISIString("LoadSuccess");

			public static ISIString PlayIntro = new ISIString("PlayIntro");

			public static ISIString CrystalIntro = new ISIString("CrystalIntro");

			public static ISIString GrabHint = new ISIString("GrabHint");

			public static ISIString GrabComplete = new ISIString("GrabComplete");

			public static ISIString DialHint = new ISIString("DialHint");

			public static ISIString PadHint = new ISIString("PadHint");

			public static ISIString MedalHint = new ISIString("MedalHint");

			public static ISIString MedalComplete = new ISIString("MedalComplete");

			public static ISIString VendingHint = new ISIString("VendingHint");

			public static ISIString VendingComplete = new ISIString("VendingComplete");

			public static ISIString BubbleGunHint = new ISIString("BubbleGunHint");

			public static ISIString BatteryHint = new ISIString("BatteryHint");

			public static ISIString MusicboxHint = new ISIString("MusicboxHint");

			public static ISIString WindingHint = new ISIString("WindingHint");

			public static ISIString GuideboxHint = new ISIString("GuideboxHint");

			public static ISIString GrabStartHint = new ISIString("GrabStartHint");

			public static ISIString GrabEndHint = new ISIString("GrabEndHint");

			public static ISIString AirplaneHint = new ISIString("AirplaneHint");

			public static ISIString PoolTen = new ISIString("PoolTen");

			public static ISIString SplitTen = new ISIString("SplitTen");

			public static ISIString HouseWelcome = new ISIString("HouseWelcome");

			public static ISIString Symbol = new ISIString("Symbol");

			public static ISIString MatchIntro = new ISIString("MatchIntro");

			public static ISIString Cycle = new ISIString("Cycle");

			public static ISIString Sudoku = new ISIString("Sudoku");

			public static ISIString ChooseItems = new ISIString("ChooseItems");

			public static ISIString AlreadyHaveItem = new ISIString("AlreadyHaveItem");

			public static ISIString MedalNotEnough = new ISIString("MedalNotEnough");

			public static ISIString ExchangeHint = new ISIString("ExchangeHint");

			public static ISIString Create = new ISIString("Create");

			public static ISIString PrepareMaterials = new ISIString("PrepareMaterials");

			public static ISIString UnneededMaterial = new ISIString("UnneededMaterial");

			public static ISIString CreateSuccessfully = new ISIString("CreateSuccessfully");

			public static ISIString MaterialNotEnough = new ISIString("MaterialNotEnough");

			public static ISIString MaterialTooMuch = new ISIString("MaterialTooMuch");

			public static ISIString Front = new ISIString("Front");

			public static ISIString Left = new ISIString("Left");

			public static ISIString Right = new ISIString("Right");

			public static ISIString Back = new ISIString("Back");

			public static ISIString Reset = new ISIString("Reset");

			public static ISIString Go = new ISIString("Go");

			public static ISIString Clue = new ISIString("Clue");

			public static ISIString Junior = new ISIString("Junior");

			public static ISIString Basic = new ISIString("Basic");

			public static ISIString Senior = new ISIString("Senior");

			public static ISIString CameraHint = new ISIString("CameraHint");

			public static ISIString SharePhotoHint = new ISIString("SharePhotoHint");

			public static ISIString MagicLab = new ISIString("MagicLab");

			public static ISIString TangramGame = new ISIString("TangramGame");

			public static ISIString Magicbox = new ISIString("Magicbox");

			public static ISIString Train = new ISIString("Train");

			public static ISIString Fruits = new ISIString("Fruits");

			public static ISIString Cubes = new ISIString("Cubes");

			public static ISIString FruiterIntro = new ISIString("FruiterIntro");

			public static ISIString FlareGunHint = new ISIString("FlareGunHint");

			public static ISIString ProjectorHint = new ISIString("ProjectorHint");
		}

		public static class audios
		{
			public const string Names = "BatteryHint, BubbleGunHint, Cube, GrabEndHint, GrabStartHint, GuideboxHint, MusicboxHint, Pyramid, WindingHint, CCuboid, SemiCylinder, AirplaneHint";

			public static AudioClip BatteryHint => ISILocalization.GetAudio("BatteryHint");

			public static AudioClip BubbleGunHint => ISILocalization.GetAudio("BubbleGunHint");

			public static AudioClip Cube => ISILocalization.GetAudio("Cube");

			public static AudioClip GrabEndHint => ISILocalization.GetAudio("GrabEndHint");

			public static AudioClip GrabStartHint => ISILocalization.GetAudio("GrabStartHint");

			public static AudioClip GuideboxHint => ISILocalization.GetAudio("GuideboxHint");

			public static AudioClip MusicboxHint => ISILocalization.GetAudio("MusicboxHint");

			public static AudioClip Pyramid => ISILocalization.GetAudio("Pyramid");

			public static AudioClip WindingHint => ISILocalization.GetAudio("WindingHint");

			public static AudioClip CCuboid => ISILocalization.GetAudio("CCuboid");

			public static AudioClip SemiCylinder => ISILocalization.GetAudio("SemiCylinder");

			public static AudioClip AirplaneHint => ISILocalization.GetAudio("AirplaneHint");
		}

		public static class sprites
		{
			public const string Names = "Cactus, CandyCane, ChristmasBall, MusicWinding, PlaneBattery, Present, Star, TeddyBear, Vespa, S02, S03, S04, S10, S11, S12, S20, S21, S22";

			public static Sprite Cactus => ISILocalization.GetSprite("Cactus");

			public static Sprite CandyCane => ISILocalization.GetSprite("CandyCane");

			public static Sprite ChristmasBall => ISILocalization.GetSprite("ChristmasBall");

			public static Sprite MusicWinding => ISILocalization.GetSprite("MusicWinding");

			public static Sprite PlaneBattery => ISILocalization.GetSprite("PlaneBattery");

			public static Sprite Present => ISILocalization.GetSprite("Present");

			public static Sprite Star => ISILocalization.GetSprite("Star");

			public static Sprite TeddyBear => ISILocalization.GetSprite("TeddyBear");

			public static Sprite Vespa => ISILocalization.GetSprite("Vespa");

			public static Sprite S02 => ISILocalization.GetSprite("S02");

			public static Sprite S03 => ISILocalization.GetSprite("S03");

			public static Sprite S04 => ISILocalization.GetSprite("S04");

			public static Sprite S10 => ISILocalization.GetSprite("S10");

			public static Sprite S11 => ISILocalization.GetSprite("S11");

			public static Sprite S12 => ISILocalization.GetSprite("S12");

			public static Sprite S20 => ISILocalization.GetSprite("S20");

			public static Sprite S21 => ISILocalization.GetSprite("S21");

			public static Sprite S22 => ISILocalization.GetSprite("S22");
		}
	}
}
namespace RSG
{
	public interface IPromise<PromisedT>
	{
		int Id { get; }

		IPromise<PromisedT> WithName(string name);

		void Done(Action<PromisedT> onResolved, Action<Exception> onRejected);

		void Done(Action<PromisedT> onResolved);

		void Done();

		IPromise Catch(Action<Exception> onRejected);

		IPromise<PromisedT> Catch(Func<Exception, PromisedT> onRejected);

		IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, IPromise<ConvertedT>> onResolved);

		IPromise Then(Func<PromisedT, IPromise> onResolved);

		IPromise Then(Action<PromisedT> onResolved);

		IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, IPromise<ConvertedT>> onResolved, Func<Exception, IPromise<ConvertedT>> onRejected);

		IPromise Then(Func<PromisedT, IPromise> onResolved, Action<Exception> onRejected);

		IPromise Then(Action<PromisedT> onResolved, Action<Exception> onRejected);

		IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, IPromise<ConvertedT>> onResolved, Func<Exception, IPromise<ConvertedT>> onRejected, Action<float> onProgress);

		IPromise Then(Func<PromisedT, IPromise> onResolved, Action<Exception> onRejected, Action<float> onProgress);

		IPromise Then(Action<PromisedT> onResolved, Action<Exception> onRejected, Action<float> onProgress);

		IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, ConvertedT> transform);

		IPromise<IEnumerable<ConvertedT>> ThenAll<ConvertedT>(Func<PromisedT, IEnumerable<IPromise<ConvertedT>>> chain);

		IPromise ThenAll(Func<PromisedT, IEnumerable<IPromise>> chain);

		IPromise<ConvertedT> ThenRace<ConvertedT>(Func<PromisedT, IEnumerable<IPromise<ConvertedT>>> chain);

		IPromise ThenRace(Func<PromisedT, IEnumerable<IPromise>> chain);

		IPromise<PromisedT> Finally(Action onComplete);

		IPromise ContinueWith(Func<IPromise> onResolved);

		IPromise<ConvertedT> ContinueWith<ConvertedT>(Func<IPromise<ConvertedT>> onComplete);

		IPromise<PromisedT> Progress(Action<float> onProgress);
	}
	public interface IRejectable
	{
		void Reject(Exception ex);
	}
	public interface IPendingPromise<PromisedT> : IRejectable
	{
		int Id { get; }

		void Resolve(PromisedT value);

		void ReportProgress(float progress);
	}
	public enum PromiseState
	{
		Pending,
		Rejected,
		Resolved
	}
	public class Promise<PromisedT> : IPromise<PromisedT>, IPendingPromise<PromisedT>, IRejectable, IPromiseInfo
	{
		private Exception rejectionException;

		private PromisedT resolveValue;

		private List<RejectHandler> rejectHandlers;

		private List<ProgressHandler> progressHandlers;

		private List<Action<PromisedT>> resolveCallbacks;

		private List<IRejectable> resolveRejectables;

		private readonly int id;

		public int Id => id;

		public string Name { get; private set; }

		public PromiseState CurState { get; private set; }

		public Promise()
		{
			CurState = PromiseState.Pending;
			id = Promise.NextId();
			if (Promise.EnablePromiseTracking)
			{
				Promise.PendingPromises.Add(this);
			}
		}

		public Promise(Action<Action<PromisedT>, Action<Exception>> resolver)
		{
			CurState = PromiseState.Pending;
			id = Promise.NextId();
			if (Promise.EnablePromiseTracking)
			{
				Promise.PendingPromises.Add(this);
			}
			try
			{
				resolver(Resolve, Reject);
			}
			catch (Exception ex)
			{
				Reject(ex);
			}
		}

		private void AddRejectHandler(Action<Exception> onRejected, IRejectable rejectable)
		{
			if (rejectHandlers == null)
			{
				rejectHandlers = new List<RejectHandler>();
			}
			rejectHandlers.Add(new RejectHandler
			{
				callback = onRejected,
				rejectable = rejectable
			});
		}

		private void AddResolveHandler(Action<PromisedT> onResolved, IRejectable rejectable)
		{
			if (resolveCallbacks == null)
			{
				resolveCallbacks = new List<Action<PromisedT>>();
			}
			if (resolveRejectables == null)
			{
				resolveRejectables = new List<IRejectable>();
			}
			resolveCallbacks.Add(onResolved);
			resolveRejectables.Add(rejectable);
		}

		private void AddProgressHandler(Action<float> onProgress, IRejectable rejectable)
		{
			if (progressHandlers == null)
			{
				progressHandlers = new List<ProgressHandler>();
			}
			progressHandlers.Add(new ProgressHandler
			{
				callback = onProgress,
				rejectable = rejectable
			});
		}

		private void InvokeHandler<T>(Action<T> callback, IRejectable rejectable, T value)
		{
			try
			{
				callback(value);
			}
			catch (Exception ex)
			{
				rejectable.Reject(ex);
			}
		}

		private void ClearHandlers()
		{
			rejectHandlers = null;
			resolveCallbacks = null;
			resolveRejectables = null;
			progressHandlers = null;
		}

		private void InvokeRejectHandlers(Exception ex)
		{
			if (rejectHandlers != null)
			{
				rejectHandlers.Each(delegate(RejectHandler handler)
				{
					InvokeHandler(handler.callback, handler.rejectable, ex);
				});
			}
			ClearHandlers();
		}

		private void InvokeResolveHandlers(PromisedT value)
		{
			if (resolveCallbacks != null)
			{
				int i = 0;
				for (int count = resolveCallbacks.Count; i < count; i++)
				{
					InvokeHandler(resolveCallbacks[i], resolveRejectables[i], value);
				}
			}
			ClearHandlers();
		}

		private void InvokeProgressHandlers(float progress)
		{
			if (progressHandlers != null)
			{
				progressHandlers.Each(delegate(ProgressHandler handler)
				{
					InvokeHandler(handler.callback, handler.rejectable, progress);
				});
			}
		}

		public void Reject(Exception ex)
		{
			if (CurState != 0)
			{
				throw new PromiseStateException(string.Concat("Attempt to reject a promise that is already in state: ", CurState, ", a promise can only be rejected when it is still in state: ", PromiseState.Pending));
			}
			rejectionException = ex;
			CurState = PromiseState.Rejected;
			if (Promise.EnablePromiseTracking)
			{
				Promise.PendingPromises.Remove(this);
			}
			InvokeRejectHandlers(ex);
		}

		public void Resolve(PromisedT value)
		{
			if (CurState != 0)
			{
				throw new PromiseStateException(string.Concat("Attempt to resolve a promise that is already in state: ", CurState, ", a promise can only be resolved when it is still in state: ", PromiseState.Pending));
			}
			resolveValue = value;
			CurState = PromiseState.Resolved;
			if (Promise.EnablePromiseTracking)
			{
				Promise.PendingPromises.Remove(this);
			}
			InvokeResolveHandlers(value);
		}

		public void ReportProgress(float progress)
		{
			if (CurState != 0)
			{
				throw new PromiseStateException(string.Concat("Attempt to report progress on a promise that is already in state: ", CurState, ", a promise can only report progress when it is still in state: ", PromiseState.Pending));
			}
			InvokeProgressHandlers(progress);
		}

		public void Done(Action<PromisedT> onResolved, Action<Exception> onRejected)
		{
			Then(onResolved, onRejected).Catch(delegate(Exception ex)
			{
				Promise.PropagateUnhandledException(this, ex);
			});
		}

		public void Done(Action<PromisedT> onResolved)
		{
			Then(onResolved).Catch(delegate(Exception ex)
			{
				Promise.PropagateUnhandledException(this, ex);
			});
		}

		public void Done()
		{
			Catch(delegate(Exception ex)
			{
				Promise.PropagateUnhandledException(this, ex);
			});
		}

		public IPromise<PromisedT> WithName(string name)
		{
			Name = name;
			return this;
		}

		public IPromise Catch(Action<Exception> onRejected)
		{
			Promise resultPromise = new Promise();
			resultPromise.WithName(Name);
			Action<PromisedT> resolveHandler = delegate
			{
				resultPromise.Resolve();
			};
			Action<Exception> rejectHandler = delegate(Exception ex)
			{
				try
				{
					onRejected(ex);
					resultPromise.Resolve();
				}
				catch (Exception ex2)
				{
					resultPromise.Reject(ex2);
				}
			};
			ActionHandlers(resultPromise, resolveHandler, rejectHandler);
			ProgressHandlers(resultPromise, delegate(float v)
			{
				resultPromise.ReportProgress(v);
			});
			return resultPromise;
		}

		public IPromise<PromisedT> Catch(Func<Exception, PromisedT> onRejected)
		{
			Promise<PromisedT> resultPromise = new Promise<PromisedT>();
			resultPromise.WithName(Name);
			Action<PromisedT> resolveHandler = delegate(PromisedT v)
			{
				resultPromise.Resolve(v);
			};
			Action<Exception> rejectHandler = delegate(Exception ex)
			{
				try
				{
					resultPromise.Resolve(onRejected(ex));
				}
				catch (Exception ex2)
				{
					resultPromise.Reject(ex2);
				}
			};
			ActionHandlers(resultPromise, resolveHandler, rejectHandler);
			ProgressHandlers(resultPromise, delegate(float v)
			{
				resultPromise.ReportProgress(v);
			});
			return resultPromise;
		}

		public IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, IPromise<ConvertedT>> onResolved)
		{
			return Then(onResolved, null, null);
		}

		public IPromise Then(Func<PromisedT, IPromise> onResolved)
		{
			return Then(onResolved, null, null);
		}

		public IPromise Then(Action<PromisedT> onResolved)
		{
			return Then(onResolved, null, null);
		}

		public IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, IPromise<ConvertedT>> onResolved, Func<Exception, IPromise<ConvertedT>> onRejected)
		{
			return Then(onResolved, onRejected, null);
		}

		public IPromise Then(Func<PromisedT, IPromise> onResolved, Action<Exception> onRejected)
		{
			return Then(onResolved, onRejected, null);
		}

		public IPromise Then(Action<PromisedT> onResolved, Action<Exception> onRejected)
		{
			return Then(onResolved, onRejected, null);
		}

		public IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, IPromise<ConvertedT>> onResolved, Func<Exception, IPromise<ConvertedT>> onRejected, Action<float> onProgress)
		{
			Promise<ConvertedT> resultPromise = new Promise<ConvertedT>();
			resultPromise.WithName(Name);
			Action<PromisedT> resolveHandler = delegate(PromisedT v)
			{
				onResolved(v).Progress(delegate(float progress)
				{
					resultPromise.ReportProgress(progress);
				}).Then(delegate(ConvertedT chainedValue)
				{
					resultPromise.Resolve(chainedValue);
				}, delegate(Exception ex)
				{
					resultPromise.Reject(ex);
				});
			};
			Action<Exception> rejectHandler = delegate(Exception ex)
			{
				if (onRejected == null)
				{
					resultPromise.Reject(ex);
					return;
				}
				try
				{
					onRejected(ex).Then(delegate(ConvertedT chainedValue)
					{
						resultPromise.Resolve(chainedValue);
					}, delegate(Exception callbackEx)
					{
						resultPromise.Reject(callbackEx);
					});
				}
				catch (Exception ex2)
				{
					resultPromise.Reject(ex2);
				}
			};
			ActionHandlers(resultPromise, resolveHandler, rejectHandler);
			if (onProgress != null)
			{
				ProgressHandlers(this, onProgress);
			}
			return resultPromise;
		}

		public IPromise Then(Func<PromisedT, IPromise> onResolved, Action<Exception> onRejected, Action<float> onProgress)
		{
			Promise resultPromise = new Promise();
			resultPromise.WithName(Name);
			Action<PromisedT> resolveHandler = delegate(PromisedT v)
			{
				if (onResolved != null)
				{
					onResolved(v).Progress(delegate(float progress)
					{
						resultPromise.ReportProgress(progress);
					}).Then(delegate
					{
						resultPromise.Resolve();
					}, delegate(Exception ex)
					{
						resultPromise.Reject(ex);
					});
				}
				else
				{
					resultPromise.Resolve();
				}
			};
			Action<Exception> rejectHandler = delegate(Exception ex)
			{
				if (onRejected != null)
				{
					onRejected(ex);
				}
				resultPromise.Reject(ex);
			};
			ActionHandlers(resultPromise, resolveHandler, rejectHandler);
			if (onProgress != null)
			{
				ProgressHandlers(this, onProgress);
			}
			return resultPromise;
		}

		public IPromise Then(Action<PromisedT> onResolved, Action<Exception> onRejected, Action<float> onProgress)
		{
			Promise resultPromise = new Promise();
			resultPromise.WithName(Name);
			Action<PromisedT> resolveHandler = delegate(PromisedT v)
			{
				if (onResolved != null)
				{
					onResolved(v);
				}
				resultPromise.Resolve();
			};
			Action<Exception> rejectHandler = delegate(Exception ex)
			{
				if (onRejected != null)
				{
					onRejected(ex);
				}
				resultPromise.Reject(ex);
			};
			ActionHandlers(resultPromise, resolveHandler, rejectHandler);
			if (onProgress != null)
			{
				ProgressHandlers(this, onProgress);
			}
			return resultPromise;
		}

		public IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, ConvertedT> transform)
		{
			return Then((PromisedT value) => Promise<ConvertedT>.Resolved(transform(value)));
		}

		private void ActionHandlers(IRejectable resultPromise, Action<PromisedT> resolveHandler, Action<Exception> rejectHandler)
		{
			if (CurState == PromiseState.Resolved)
			{
				InvokeHandler(resolveHandler, resultPromise, resolveValue);
				return;
			}
			if (CurState == PromiseState.Rejected)
			{
				InvokeHandler(rejectHandler, resultPromise, rejectionException);
				return;
			}
			AddResolveHandler(resolveHandler, resultPromise);
			AddRejectHandler(rejectHandler, resultPromise);
		}

		private void ProgressHandlers(IRejectable resultPromise, Action<float> progressHandler)
		{
			if (CurState == PromiseState.Pending)
			{
				AddProgressHandler(progressHandler, resultPromise);
			}
		}

		public IPromise<IEnumerable<ConvertedT>> ThenAll<ConvertedT>(Func<PromisedT, IEnumerable<IPromise<ConvertedT>>> chain)
		{
			return Then((PromisedT value) => Promise<ConvertedT>.All(chain(value)));
		}

		public IPromise ThenAll(Func<PromisedT, IEnumerable<IPromise>> chain)
		{
			return Then((PromisedT value) => Promise.All(chain(value)));
		}

		public static IPromise<IEnumerable<PromisedT>> All(params IPromise<PromisedT>[] promises)
		{
			return All((IEnumerable<IPromise<PromisedT>>)promises);
		}

		public static IPromise<IEnumerable<PromisedT>> All(IEnumerable<IPromise<PromisedT>> promises)
		{
			IPromise<PromisedT>[] array = promises.ToArray();
			if (array.Length == 0)
			{
				return Promise<IEnumerable<PromisedT>>.Resolved(Enumerable.Empty<PromisedT>());
			}
			int remainingCount = array.Length;
			PromisedT[] results = new PromisedT[remainingCount];
			float[] progress = new float[remainingCount];
			Promise<IEnumerable<PromisedT>> resultPromise = new Promise<IEnumerable<PromisedT>>();
			resultPromise.WithName("All");
			array.Each(delegate(IPromise<PromisedT> promise, int index)
			{
				promise.Progress(delegate(float v)
				{
					progress[index] = v;
					if (resultPromise.CurState == PromiseState.Pending)
					{
						resultPromise.ReportProgress(progress.Average());
					}
				}).Then(delegate(PromisedT result)
				{
					progress[index] = 1f;
					results[index] = result;
					int num = remainingCount - 1;
					remainingCount = num;
					if (remainingCount <= 0 && resultPromise.CurState == PromiseState.Pending)
					{
						resultPromise.Resolve(results);
					}
				}).Catch(delegate(Exception ex)
				{
					if (resultPromise.CurState == PromiseState.Pending)
					{
						resultPromise.Reject(ex);
					}
				})
					.Done();
			});
			return resultPromise;
		}

		public IPromise<ConvertedT> ThenRace<ConvertedT>(Func<PromisedT, IEnumerable<IPromise<ConvertedT>>> chain)
		{
			return Then((PromisedT value) => Promise<ConvertedT>.Race(chain(value)));
		}

		public IPromise ThenRace(Func<PromisedT, IEnumerable<IPromise>> chain)
		{
			return Then((PromisedT value) => Promise.Race(chain(value)));
		}

		public static IPromise<PromisedT> Race(params IPromise<PromisedT>[] promises)
		{
			return Race((IEnumerable<IPromise<PromisedT>>)promises);
		}

		public static IPromise<PromisedT> Race(IEnumerable<IPromise<PromisedT>> promises)
		{
			IPromise<PromisedT>[] array = promises.ToArray();
			if (array.Length == 0)
			{
				throw new InvalidOperationException("At least 1 input promise must be provided for Race");
			}
			Promise<PromisedT> resultPromise = new Promise<PromisedT>();
			resultPromise.WithName("Race");
			float[] progress = new float[array.Length];
			array.Each(delegate(IPromise<PromisedT> promise, int index)
			{
				promise.Progress(delegate(float v)
				{
					if (resultPromise.CurState == PromiseState.Pending)
					{
						progress[index] = v;
						resultPromise.ReportProgress(progress.Max());
					}
				}).Then(delegate(PromisedT result)
				{
					if (resultPromise.CurState == PromiseState.Pending)
					{
						resultPromise.Resolve(result);
					}
				}).Catch(delegate(Exception ex)
				{
					if (resultPromise.CurState == PromiseState.Pending)
					{
						resultPromise.Reject(ex);
					}
				})
					.Done();
			});
			return resultPromise;
		}

		public static IPromise<PromisedT> Resolved(PromisedT promisedValue)
		{
			Promise<PromisedT> promise = new Promise<PromisedT>();
			promise.Resolve(promisedValue);
			return promise;
		}

		public static IPromise<PromisedT> Rejected(Exception ex)
		{
			Promise<PromisedT> promise = new Promise<PromisedT>();
			promise.Reject(ex);
			return promise;
		}

		public IPromise<PromisedT> Finally(Action onComplete)
		{
			Promise<PromisedT> promise = new Promise<PromisedT>();
			promise.WithName(Name);
			Then(delegate(PromisedT x)
			{
				promise.Resolve(x);
			});
			Catch(delegate(Exception e)
			{
				try
				{
					onComplete();
					promise.Reject(e);
				}
				catch (Exception ex)
				{
					promise.Reject(ex);
				}
			});
			return promise.Then(delegate(PromisedT v)
			{
				onComplete();
				return v;
			});
		}

		public IPromise ContinueWith(Func<IPromise> onComplete)
		{
			Promise promise = new Promise();
			promise.WithName(Name);
			Then(delegate
			{
				promise.Resolve();
			});
			Catch(delegate
			{
				promise.Resolve();
			});
			return promise.Then(onComplete);
		}

		public IPromise<ConvertedT> ContinueWith<ConvertedT>(Func<IPromise<ConvertedT>> onComplete)
		{
			Promise promise = new Promise();
			promise.WithName(Name);
			Then(delegate
			{
				promise.Resolve();
			});
			Catch(delegate
			{
				promise.Resolve();
			});
			return promise.Then(onComplete);
		}

		public IPromise<PromisedT> Progress(Action<float> onProgress)
		{
			if (onProgress != null)
			{
				ProgressHandlers(this, onProgress);
			}
			return this;
		}
	}
	public interface IPromise
	{
		int Id { get; }

		IPromise WithName(string name);

		void Done(Action onResolved, Action<Exception> onRejected);

		void Done(Action onResolved);

		void Done();

		IPromise Catch(Action<Exception> onRejected);

		IPromise<ConvertedT> Then<ConvertedT>(Func<IPromise<ConvertedT>> onResolved);

		IPromise Then(Func<IPromise> onResolved);

		IPromise Then(Action onResolved);

		IPromise<ConvertedT> Then<ConvertedT>(Func<IPromise<ConvertedT>> onResolved, Func<Exception, IPromise<ConvertedT>> onRejected);

		IPromise Then(Func<IPromise> onResolved, Action<Exception> onRejected);

		IPromise Then(Action onResolved, Action<Exception> onRejected);

		IPromise<ConvertedT> Then<ConvertedT>(Func<IPromise<ConvertedT>> onResolved, Func<Exception, IPromise<ConvertedT>> onRejected, Action<float> onProgress);

		IPromise Then(Func<IPromise> onResolved, Action<Exception> onRejected, Action<float> onProgress);

		IPromise Then(Action onResolved, Action<Exception> onRejected, Action<float> onProgress);

		IPromise ThenAll(Func<IEnumerable<IPromise>> chain);

		IPromise<IEnumerable<ConvertedT>> ThenAll<ConvertedT>(Func<IEnumerable<IPromise<ConvertedT>>> chain);

		IPromise ThenSequence(Func<IEnumerable<Func<IPromise>>> chain);

		IPromise ThenRace(Func<IEnumerable<IPromise>> chain);

		IPromise<ConvertedT> ThenRace<ConvertedT>(Func<IEnumerable<IPromise<ConvertedT>>> chain);

		IPromise Finally(Action onComplete);

		IPromise ContinueWith(Func<IPromise> onResolved);

		IPromise<ConvertedT> ContinueWith<ConvertedT>(Func<IPromise<ConvertedT>> onComplete);

		IPromise Progress(Action<float> onProgress);
	}
	public interface IPendingPromise : IRejectable
	{
		int Id { get; }

		void Resolve();

		void ReportProgress(float progress);
	}
	public interface IPromiseInfo
	{
		int Id { get; }

		string Name { get; }
	}
	public class ExceptionEventArgs : EventArgs
	{
		public Exception Exception { get; private set; }

		internal ExceptionEventArgs(Exception exception)
		{
			Exception = exception;
		}
	}
	public struct RejectHandler
	{
		public Action<Exception> callback;

		public IRejectable rejectable;
	}
	public struct ProgressHandler
	{
		public Action<float> callback;

		public IRejectable rejectable;
	}
	public class Promise : IPromise, IPendingPromise, IRejectable, IPromiseInfo
	{
		public struct ResolveHandler
		{
			public Action callback;

			public IRejectable rejectable;
		}

		public static bool EnablePromiseTracking = false;

		private static EventHandler<ExceptionEventArgs> unhandlerException;

		private static int nextPromiseId;

		internal static readonly HashSet<IPromiseInfo> PendingPromises = new HashSet<IPromiseInfo>();

		private Exception rejectionException;

		private List<RejectHandler> rejectHandlers;

		private List<ResolveHandler> resolveHandlers;

		private List<ProgressHandler> progressHandlers;

		private readonly int id;

		public int Id => id;

		public string Name { get; private set; }

		public PromiseState CurState { get; private set; }

		public static event EventHandler<ExceptionEventArgs> UnhandledException
		{
			add
			{
				unhandlerException = (EventHandler<ExceptionEventArgs>)Delegate.Combine(unhandlerException, value);
			}
			remove
			{
				unhandlerException = (EventHandler<ExceptionEventArgs>)Delegate.Remove(unhandlerException, value);
			}
		}

		public static IEnumerable<IPromiseInfo> GetPendingPromises()
		{
			return PendingPromises;
		}

		public Promise()
		{
			CurState = PromiseState.Pending;
			id = NextId();
			if (EnablePromiseTracking)
			{
				PendingPromises.Add(this);
			}
		}

		public Promise(Action<Action, Action<Exception>> resolver)
		{
			CurState = PromiseState.Pending;
			id = NextId();
			if (EnablePromiseTracking)
			{
				PendingPromises.Add(this);
			}
			try
			{
				resolver(Resolve, Reject);
			}
			catch (Exception ex)
			{
				Reject(ex);
			}
		}

		internal static int NextId()
		{
			return ++nextPromiseId;
		}

		private void AddRejectHandler(Action<Exception> onRejected, IRejectable rejectable)
		{
			if (rejectHandlers == null)
			{
				rejectHandlers = new List<RejectHandler>();
			}
			rejectHandlers.Add(new RejectHandler
			{
				callback = onRejected,
				rejectable = rejectable
			});
		}

		private void AddResolveHandler(Action onResolved, IRejectable rejectable)
		{
			if (resolveHandlers == null)
			{
				resolveHandlers = new List<ResolveHandler>();
			}
			resolveHandlers.Add(new ResolveHandler
			{
				callback = onResolved,
				rejectable = rejectable
			});
		}

		private void AddProgressHandler(Action<float> onProgress, IRejectable rejectable)
		{
			if (progressHandlers == null)
			{
				progressHandlers = new List<ProgressHandler>();
			}
			progressHandlers.Add(new ProgressHandler
			{
				callback = onProgress,
				rejectable = rejectable
			});
		}

		private void InvokeRejectHandler(Action<Exception> callback, IRejectable rejectable, Exception value)
		{
			try
			{
				callback(value);
			}
			catch (Exception ex)
			{
				rejectable.Reject(ex);
			}
		}

		private void InvokeResolveHandler(Action callback, IRejectable rejectable)
		{
			try
			{
				callback();
			}
			catch (Exception ex)
			{
				rejectable.Reject(ex);
			}
		}

		private void InvokeProgressHandler(Action<float> callback, IRejectable rejectable, float progress)
		{
			try
			{
				callback(progress);
			}
			catch (Exception ex)
			{
				rejectable.Reject(ex);
			}
		}

		private void ClearHandlers()
		{
			rejectHandlers = null;
			resolveHandlers = null;
			progressHandlers = null;
		}

		private void InvokeRejectHandlers(Exception ex)
		{
			if (rejectHandlers != null)
			{
				rejectHandlers.Each(delegate(RejectHandler handler)
				{
					InvokeRejectHandler(handler.callback, handler.rejectable, ex);
				});
			}
			ClearHandlers();
		}

		private void InvokeResolveHandlers()
		{
			if (resolveHandlers != null)
			{
				resolveHandlers.Each(delegate(ResolveHandler handler)
				{
					InvokeResolveHandler(handler.callback, handler.rejectable);
				});
			}
			ClearHandlers();
		}

		private void InvokeProgressHandlers(float progress)
		{
			if (progressHandlers != null)
			{
				progressHandlers.Each(delegate(ProgressHandler handler)
				{
					InvokeProgressHandler(handler.callback, handler.rejectable, progress);
				});
			}
		}

		public void Reject(Exception ex)
		{
			if (CurState != 0)
			{
				throw new PromiseStateException(string.Concat("Attempt to reject a promise that is already in state: ", CurState, ", a promise can only be rejected when it is still in state: ", PromiseState.Pending));
			}
			rejectionException = ex;
			CurState = PromiseState.Rejected;
			if (EnablePromiseTracking)
			{
				PendingPromises.Remove(this);
			}
			InvokeRejectHandlers(ex);
		}

		public void Resolve()
		{
			if (CurState != 0)
			{
				throw new PromiseStateException(string.Concat("Attempt to resolve a promise that is already in state: ", CurState, ", a promise can only be resolved when it is still in state: ", PromiseState.Pending));
			}
			CurState = PromiseState.Resolved;
			if (EnablePromiseTracking)
			{
				PendingPromises.Remove(this);
			}
			InvokeResolveHandlers();
		}

		public void ReportProgress(float progress)
		{
			if (CurState != 0)
			{
				throw new PromiseStateException(string.Concat("Attempt to report progress on a promise that is already in state: ", CurState, ", a promise can only report progress when it is still in state: ", PromiseState.Pending));
			}
			InvokeProgressHandlers(progress);
		}

		public void Done(Action onResolved, Action<Exception> onRejected)
		{
			Then(onResolved, onRejected).Catch(delegate(Exception ex)
			{
				PropagateUnhandledException(this, ex);
			});
		}

		public void Done(Action onResolved)
		{
			Then(onResolved).Catch(delegate(Exception ex)
			{
				PropagateUnhandledException(this, ex);
			});
		}

		public void Done()
		{
			Catch(delegate(Exception ex)
			{
				PropagateUnhandledException(this, ex);
			});
		}

		public IPromise WithName(string name)
		{
			Name = name;
			return this;
		}

		public IPromise Catch(Action<Exception> onRejected)
		{
			Promise resultPromise = new Promise();
			resultPromise.WithName(Name);
			Action resolveHandler = delegate
			{
				resultPromise.Resolve();
			};
			Action<Exception> rejectHandler = delegate(Exception ex)
			{
				try
				{
					onRejected(ex);
					resultPromise.Resolve();
				}
				catch (Exception ex2)
				{
					resultPromise.Reject(ex2);
				}
			};
			ActionHandlers(resultPromise, resolveHandler, rejectHandler);
			ProgressHandlers(resultPromise, delegate(float v)
			{
				resultPromise.ReportProgress(v);
			});
			return resultPromise;
		}

		public IPromise<ConvertedT> Then<ConvertedT>(Func<IPromise<ConvertedT>> onResolved)
		{
			return Then(onResolved, null, null);
		}

		public IPromise Then(Func<IPromise> onResolved)
		{
			return Then(onResolved, null, null);
		}

		public IPromise Then(Action onResolved)
		{
			return Then(onResolved, null, null);
		}

		public IPromise<ConvertedT> Then<ConvertedT>(Func<IPromise<ConvertedT>> onResolved, Func<Exception, IPromise<ConvertedT>> onRejected)
		{
			return Then(onResolved, onRejected, null);
		}

		public IPromise Then(Func<IPromise> onResolved, Action<Exception> onRejected)
		{
			return Then(onResolved, onRejected, null);
		}

		public IPromise Then(Action onResolved, Action<Exception> onRejected)
		{
			return Then(onResolved, onRejected, null);
		}

		public IPromise<ConvertedT> Then<ConvertedT>(Func<IPromise<ConvertedT>> onResolved, Func<Exception, IPromise<ConvertedT>> onRejected, Action<float> onProgress)
		{
			Promise<ConvertedT> resultPromise = new Promise<ConvertedT>();
			resultPromise.WithName(Name);
			Action resolveHandler = delegate
			{
				onResolved().Progress(delegate(float progress)
				{
					resultPromise.ReportProgress(progress);
				}).Then(delegate(ConvertedT chainedValue)
				{
					resultPromise.Resolve(chainedValue);
				}, delegate(Exception ex)
				{
					resultPromise.Reject(ex);
				});
			};
			Action<Exception> rejectHandler = delegate(Exception ex)
			{
				if (onRejected == null)
				{
					resultPromise.Reject(ex);
					return;
				}
				try
				{
					onRejected(ex).Then(delegate(ConvertedT chainedValue)
					{
						resultPromise.Resolve(chainedValue);
					}, delegate(Exception callbackEx)
					{
						resultPromise.Reject(callbackEx);
					});
				}
				catch (Exception ex2)
				{
					resultPromise.Reject(ex2);
				}
			};
			ActionHandlers(resultPromise, resolveHandler, rejectHandler);
			if (onProgress != null)
			{
				ProgressHandlers(this, onProgress);
			}
			return resultPromise;
		}

		public IPromise Then(Func<IPromise> onResolved, Action<Exception> onRejected, Action<float> onProgress)
		{
			Promise resultPromise = new Promise();
			resultPromise.WithName(Name);
			Action resolveHandler = delegate
			{
				if (onResolved != null)
				{
					onResolved().Progress(delegate(float progress)
					{
						resultPromise.ReportProgress(progress);
					}).Then(delegate
					{
						resultPromise.Resolve();
					}, delegate(Exception ex)
					{
						resultPromise.Reject(ex);
					});
				}
				else
				{
					resultPromise.Resolve();
				}
			};
			Action<Exception> rejectHandler = delegate(Exception ex)
			{
				if (onRejected != null)
				{
					onRejected(ex);
				}
				resultPromise.Reject(ex);
			};
			ActionHandlers(resultPromise, resolveHandler, rejectHandler);
			if (onProgress != null)
			{
				ProgressHandlers(this, onProgress);
			}
			return resultPromise;
		}

		public IPromise Then(Action onResolved, Action<Exception> onRejected, Action<float> onProgress)
		{
			Promise resultPromise = new Promise();
			resultPromise.WithName(Name);
			Action resolveHandler = delegate
			{
				if (onResolved != null)
				{
					onResolved();
				}
				resultPromise.Resolve();
			};
			Action<Exception> rejectHandler = delegate(Exception ex)
			{
				if (onRejected != null)
				{
					onRejected(ex);
					resultPromise.Resolve();
				}
				else
				{
					resultPromise.Reject(ex);
				}
			};
			ActionHandlers(resultPromise, resolveHandler, rejectHandler);
			if (onProgress != null)
			{
				ProgressHandlers(this, onProgress);
			}
			return resultPromise;
		}

		private void ActionHandlers(IRejectable resultPromise, Action resolveHandler, Action<Exception> rejectHandler)
		{
			if (CurState == PromiseState.Resolved)
			{
				InvokeResolveHandler(resolveHandler, resultPromise);
				return;
			}
			if (CurState == PromiseState.Rejected)
			{
				InvokeRejectHandler(rejectHandler, resultPromise, rejectionException);
				return;
			}
			AddResolveHandler(resolveHandler, resultPromise);
			AddRejectHandler(rejectHandler, resultPromise);
		}

		private void ProgressHandlers(IRejectable resultPromise, Action<float> progressHandler)
		{
			if (CurState == PromiseState.Pending)
			{
				AddProgressHandler(progressHandler, resultPromise);
			}
		}

		public IPromise ThenAll(Func<IEnumerable<IPromise>> chain)
		{
			return Then(() => All(chain()));
		}

		public IPromise<IEnumerable<ConvertedT>> ThenAll<ConvertedT>(Func<IEnumerable<IPromise<ConvertedT>>> chain)
		{
			return Then(() => Promise<ConvertedT>.All(chain()));
		}

		public static IPromise All(params IPromise[] promises)
		{
			return All((IEnumerable<IPromise>)promises);
		}

		public static IPromise All(IEnumerable<IPromise> promises)
		{
			IPromise[] array = promises.ToArray();
			if (array.Length == 0)
			{
				return Resolved();
			}
			int remainingCount = array.Length;
			Promise resultPromise = new Promise();
			resultPromise.WithName("All");
			float[] progress = new float[remainingCount];
			array.Each(delegate(IPromise promise, int index)
			{
				promise.Progress(delegate(float v)
				{
					progress[index] = v;
					if (resultPromise.CurState == PromiseState.Pending)
					{
						resultPromise.ReportProgress(progress.Average());
					}
				}).Then(delegate
				{
					progress[index] = 1f;
					int num = remainingCount - 1;
					remainingCount = num;
					if (remainingCount <= 0 && resultPromise.CurState == PromiseState.Pending)
					{
						resultPromise.Resolve();
					}
				}).Catch(delegate(Exception ex)
				{
					if (resultPromise.CurState == PromiseState.Pending)
					{
						resultPromise.Reject(ex);
					}
				})
					.Done();
			});
			return resultPromise;
		}

		public IPromise ThenSequence(Func<IEnumerable<Func<IPromise>>> chain)
		{
			return Then(() => Sequence(chain()));
		}

		public static IPromise Sequence(params Func<IPromise>[] fns)
		{
			return Sequence((IEnumerable<Func<IPromise>>)fns);
		}

		public static IPromise Sequence(IEnumerable<Func<IPromise>> fns)
		{
			Promise promise = new Promise();
			int count = 0;
			fns.Aggregate(Resolved(), delegate(IPromise prevPromise, Func<IPromise> fn)
			{
				int itemSequence = count;
				int num = count + 1;
				count = num;
				return prevPromise.Then(delegate
				{
					float num3 = 1f / (float)count;
					promise.ReportProgress(num3 * (float)itemSequence);
					return fn();
				}).Progress(delegate(float v)
				{
					float num2 = 1f / (float)count;
					promise.ReportProgress(num2 * (v + (float)itemSequence));
				});
			}).Then(delegate
			{
				promise.Resolve();
			}).Catch(promise.Reject);
			return promise;
		}

		public IPromise ThenRace(Func<IEnumerable<IPromise>> chain)
		{
			return Then(() => Race(chain()));
		}

		public IPromise<ConvertedT> ThenRace<ConvertedT>(Func<IEnumerable<IPromise<ConvertedT>>> chain)
		{
			return Then(() => Promise<ConvertedT>.Race(chain()));
		}

		public static IPromise Race(params IPromise[] promises)
		{
			return Race((IEnumerable<IPromise>)promises);
		}

		public static IPromise Race(IEnumerable<IPromise> promises)
		{
			IPromise[] array = promises.ToArray();
			if (array.Length == 0)
			{
				throw new InvalidOperationException("At least 1 input promise must be provided for Race");
			}
			Promise resultPromise = new Promise();
			resultPromise.WithName("Race");
			float[] progress = new float[array.Length];
			array.Each(delegate(IPromise promise, int index)
			{
				promise.Progress(delegate(float v)
				{
					progress[index] = v;
					resultPromise.ReportProgress(progress.Max());
				}).Catch(delegate(Exception ex)
				{
					if (resultPromise.CurState == PromiseState.Pending)
					{
						resultPromise.Reject(ex);
					}
				}).Then(delegate
				{
					if (resultPromise.CurState == PromiseState.Pending)
					{
						resultPromise.Resolve();
					}
				})
					.Done();
			});
			return resultPromise;
		}

		public static IPromise Resolved()
		{
			Promise promise = new Promise();
			promise.Resolve();
			return promise;
		}

		public static IPromise Rejected(Exception ex)
		{
			Promise promise = new Promise();
			promise.Reject(ex);
			return promise;
		}

		public IPromise Finally(Action onComplete)
		{
			Promise promise = new Promise();
			promise.WithName(Name);
			Then(delegate
			{
				promise.Resolve();
			});
			Catch(delegate(Exception e)
			{
				try
				{
					onComplete();
					promise.Reject(e);
				}
				catch (Exception ex)
				{
					promise.Reject(ex);
				}
			});
			return promise.Then(onComplete);
		}

		public IPromise ContinueWith(Func<IPromise> onComplete)
		{
			Promise promise = new Promise();
			promise.WithName(Name);
			Then(delegate
			{
				promise.Resolve();
			});
			Catch(delegate
			{
				promise.Resolve();
			});
			return promise.Then(onComplete);
		}

		public IPromise<ConvertedT> ContinueWith<ConvertedT>(Func<IPromise<ConvertedT>> onComplete)
		{
			Promise promise = new Promise();
			promise.WithName(Name);
			Then(delegate
			{
				promise.Resolve();
			});
			Catch(delegate
			{
				promise.Resolve();
			});
			return promise.Then(onComplete);
		}

		public IPromise Progress(Action<float> onProgress)
		{
			if (onProgress != null)
			{
				ProgressHandlers(this, onProgress);
			}
			return this;
		}

		internal static void PropagateUnhandledException(object sender, Exception ex)
		{
			if (unhandlerException != null)
			{
				unhandlerException(sender, new ExceptionEventArgs(ex));
			}
		}
	}
	public static class PromiseHelpers
	{
		public static IPromise<Tuple<T1, T2>> All<T1, T2>(IPromise<T1> p1, IPromise<T2> p2)
		{
			T1 val2 = default(T1);
			T2 val3 = default(T2);
			int numUnresolved = 2;
			bool alreadyRejected = false;
			Promise<Tuple<T1, T2>> promise = new Promise<Tuple<T1, T2>>();
			p1.Then(delegate(T1 val)
			{
				val2 = val;
				numUnresolved--;
				if (numUnresolved <= 0)
				{
					promise.Resolve(Tuple.Create(val2, val3));
				}
			}).Catch(delegate(Exception e)
			{
				if (!alreadyRejected)
				{
					promise.Reject(e);
				}
				alreadyRejected = true;
			}).Done();
			p2.Then(delegate(T2 val)
			{
				val3 = val;
				numUnresolved--;
				if (numUnresolved <= 0)
				{
					promise.Resolve(Tuple.Create(val2, val3));
				}
			}).Catch(delegate(Exception e)
			{
				if (!alreadyRejected)
				{
					promise.Reject(e);
				}
				alreadyRejected = true;
			}).Done();
			return promise;
		}

		public static IPromise<Tuple<T1, T2, T3>> All<T1, T2, T3>(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3)
		{
			return All(All(p1, p2), p3).Then((Tuple<Tuple<T1, T2>, T3> vals) => Tuple.Create(vals.Item1.Item1, vals.Item1.Item2, vals.Item2));
		}

		public static IPromise<Tuple<T1, T2, T3, T4>> All<T1, T2, T3, T4>(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3, IPromise<T4> p4)
		{
			return All(All(p1, p2), All(p3, p4)).Then((Tuple<Tuple<T1, T2>, Tuple<T3, T4>> vals) => Tuple.Create(vals.Item1.Item1, vals.Item1.Item2, vals.Item2.Item1, vals.Item2.Item2));
		}
	}
	public class PromiseCancelledException : Exception
	{
		public PromiseCancelledException()
		{
		}

		public PromiseCancelledException(string message)
			: base(message)
		{
		}
	}
	internal class PredicateWait
	{
		public Func<TimeData, bool> predicate;

		public float timeStarted;

		public IPendingPromise pendingPromise;

		public TimeData timeData;

		public int frameStarted;
	}
	public struct TimeData
	{
		public float elapsedTime;

		public float deltaTime;

		public int elapsedUpdates;
	}
	public interface IPromiseTimer
	{
		IPromise WaitFor(float seconds);

		IPromise WaitUntil(Func<TimeData, bool> predicate);

		IPromise WaitWhile(Func<TimeData, bool> predicate);

		void Update(float deltaTime);

		bool Cancel(IPromise promise);
	}
	public class PromiseTimer : IPromiseTimer
	{
		private float curTime;

		private int curFrame;

		private readonly LinkedList<PredicateWait> waiting = new LinkedList<PredicateWait>();

		public IPromise WaitFor(float seconds)
		{
			return WaitUntil((TimeData t) => t.elapsedTime >= seconds);
		}

		public IPromise WaitWhile(Func<TimeData, bool> predicate)
		{
			return WaitUntil((TimeData t) => !predicate(t));
		}

		public IPromise WaitUntil(Func<TimeData, bool> predicate)
		{
			Promise promise = new Promise();
			PredicateWait value = new PredicateWait
			{
				timeStarted = curTime,
				pendingPromise = promise,
				timeData = default(TimeData),
				predicate = predicate,
				frameStarted = curFrame
			};
			waiting.AddLast(value);
			return promise;
		}

		public bool Cancel(IPromise promise)
		{
			LinkedListNode<PredicateWait> linkedListNode = FindInWaiting(promise);
			if (linkedListNode == null)
			{
				return false;
			}
			linkedListNode.Value.pendingPromise.Reject(new PromiseCancelledException("Promise was cancelled by user."));
			waiting.Remove(linkedListNode);
			return true;
		}

		private LinkedListNode<PredicateWait> FindInWaiting(IPromise promise)
		{
			for (LinkedListNode<PredicateWait> linkedListNode = waiting.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
			{
				if (linkedListNode.Value.pendingPromise.Id.Equals(promise.Id))
				{
					return linkedListNode;
				}
			}
			return null;
		}

		public void Update(float deltaTime)
		{
			curTime += deltaTime;
			curFrame++;
			LinkedListNode<PredicateWait> linkedListNode = waiting.First;
			while (linkedListNode != null)
			{
				PredicateWait value = linkedListNode.Value;
				float num = curTime - value.timeStarted;
				value.timeData.deltaTime = num - value.timeData.elapsedTime;
				value.timeData.elapsedTime = num;
				int elapsedUpdates = curFrame - value.frameStarted;
				value.timeData.elapsedUpdates = elapsedUpdates;
				bool flag;
				try
				{
					flag = value.predicate(value.timeData);
				}
				catch (Exception ex)
				{
					value.pendingPromise.Reject(ex);
					linkedListNode = RemoveNode(linkedListNode);
					continue;
				}
				if (flag)
				{
					value.pendingPromise.Resolve();
					linkedListNode = RemoveNode(linkedListNode);
				}
				else
				{
					linkedListNode = linkedListNode.Next;
				}
			}
		}

		private LinkedListNode<PredicateWait> RemoveNode(LinkedListNode<PredicateWait> node)
		{
			LinkedListNode<PredicateWait> node2 = node;
			node = node.Next;
			waiting.Remove(node2);
			return node;
		}
	}
	public class Tuple
	{
		public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
		{
			return new Tuple<T1, T2>(item1, item2);
		}

		public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
		{
			return new Tuple<T1, T2, T3>(item1, item2, item3);
		}

		public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
		}
	}
	public class Tuple<T1, T2>
	{
		public T1 Item1 { get; private set; }

		public T2 Item2 { get; private set; }

		internal Tuple(T1 item1, T2 item2)
		{
			Item1 = item1;
			Item2 = item2;
		}
	}
	public class Tuple<T1, T2, T3>
	{
		public T1 Item1 { get; private set; }

		public T2 Item2 { get; private set; }

		public T3 Item3 { get; private set; }

		internal Tuple(T1 item1, T2 item2, T3 item3)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
		}
	}
	public class Tuple<T1, T2, T3, T4>
	{
		public T1 Item1 { get; private set; }

		public T2 Item2 { get; private set; }

		public T3 Item3 { get; private set; }

		public T4 Item4 { get; private set; }

		internal Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
		}
	}
}
namespace RSG.Exceptions
{
	public class PromiseException : Exception
	{
		public PromiseException()
		{
		}

		public PromiseException(string message)
			: base(message)
		{
		}

		public PromiseException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
	public class PromiseStateException : PromiseException
	{
		public PromiseStateException()
		{
		}

		public PromiseStateException(string message)
			: base(message)
		{
		}

		public PromiseStateException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}
namespace RSG.Promises
{
	public static class EnumerableExt
	{
		public static void Each<T>(this IEnumerable<T> source, Action<T> fn)
		{
			foreach (T item in source)
			{
				fn(item);
			}
		}

		public static void Each<T>(this IEnumerable<T> source, Action<T, int> fn)
		{
			int num = 0;
			foreach (T item in source)
			{
				fn(item, num);
				num++;
			}
		}

		public static IEnumerable<T> FromItems<T>(params T[] items)
		{
			for (int i = 0; i < items.Length; i++)
			{
				yield return items[i];
			}
		}
	}
}
namespace Proyecto26
{
	public static class HttpBase
	{
		public static IEnumerator CreateRequestAndRetry(RequestHelper options, Action<RequestException, ResponseHelper> callback)
		{
			int retries = 0;
			do
			{
				using UnityWebRequest request = CreateRequest(options);
				yield return request.SendWebRequestWithOptions(options);
				ResponseHelper responseHelper = request.CreateWebResponse();
				if (request.IsValidRequest(options))
				{
					DebugLog(options.EnableDebug, $"Url: {options.Uri}\nMethod: {options.Method}\nStatus: {request.responseCode}\nResponse: {responseHelper.Text}", isError: false);
					callback(null, responseHelper);
					break;
				}
				if (!options.IsAborted && retries < options.Retries)
				{
					yield return new WaitForSeconds(options.RetrySecondsDelay);
					retries++;
					if (options.RetryCallback != null)
					{
						options.RetryCallback(CreateException(request), retries);
					}
					DebugLog(options.EnableDebug, $"Retry Request\nUrl: {options.Uri}\nMethod: {options.Method}", isError: false);
					continue;
				}
				RequestException ex = CreateException(request);
				DebugLog(options.EnableDebug, ex, isError: true);
				callback(ex, responseHelper);
				break;
			}
			while (retries <= options.Retries);
		}

		private static UnityWebRequest CreateRequest(RequestHelper options)
		{
			if (options.FormData != null && options.Method == "POST")
			{
				return UnityWebRequest.Post(options.Uri, options.FormData);
			}
			return new UnityWebRequest(options.Uri, options.Method);
		}

		private static RequestException CreateException(UnityWebRequest request)
		{
			return new RequestException(request.error, request.isHttpError, request.isNetworkError, request.responseCode, request.downloadHandler.text);
		}

		private static void DebugLog(bool debugEnabled, object message, bool isError)
		{
			if (debugEnabled)
			{
				if (isError)
				{
					UnityEngine.Debug.LogError(message);
				}
				else
				{
					UnityEngine.Debug.Log(message);
				}
			}
		}

		public static IEnumerator DefaultUnityWebRequest(RequestHelper options, Action<RequestException, ResponseHelper> callback)
		{
			return CreateRequestAndRetry(options, callback);
		}

		public static IEnumerator DefaultUnityWebRequest<TResponse>(RequestHelper options, Action<RequestException, ResponseHelper, TResponse> callback)
		{
			return CreateRequestAndRetry(options, delegate(RequestException err, ResponseHelper res)
			{
				TResponse arg = default(TResponse);
				if (err == null && !string.IsNullOrEmpty(res.Text))
				{
					try
					{
						arg = JsonUtility.FromJson<TResponse>(res.Text);
					}
					catch (Exception ex)
					{
						DebugLog(options.EnableDebug, $"Invalid JSON format\nError: {ex.Message}", isError: true);
					}
				}
				callback(err, res, arg);
			});
		}

		public static IEnumerator DefaultUnityWebRequest<TResponse>(RequestHelper options, Action<RequestException, ResponseHelper, TResponse[]> callback)
		{
			return CreateRequestAndRetry(options, delegate(RequestException err, ResponseHelper res)
			{
				TResponse[] arg = null;
				if (err == null && !string.IsNullOrEmpty(res.Text))
				{
					try
					{
						arg = JsonHelper.ArrayFromJson<TResponse>(res.Text);
					}
					catch (Exception ex)
					{
						DebugLog(options.EnableDebug, $"Invalid JSON format\nError: {ex.Message}", isError: true);
					}
				}
				callback(err, res, arg);
			});
		}
	}
	public static class JsonHelper
	{
		[Serializable]
		private class Wrapper<T>
		{
			public T[] Items;
		}

		public static T[] ArrayFromJson<T>(string json)
		{
			return JsonUtility.FromJson<Wrapper<T>>("{ \"Items\": " + json + "}").Items;
		}

		public static T[] FromJsonString<T>(string json)
		{
			return JsonUtility.FromJson<Wrapper<T>>(json).Items;
		}

		public static string ArrayToJsonString<T>(T[] array)
		{
			return JsonUtility.ToJson(new Wrapper<T>
			{
				Items = array
			});
		}

		public static string ArrayToJsonString<T>(T[] array, bool prettyPrint)
		{
			return JsonUtility.ToJson(new Wrapper<T>
			{
				Items = array
			}, prettyPrint);
		}
	}
	public class RequestException : Exception
	{
		private bool _isHttpError;

		private bool _isNetworkError;

		private long _statusCode;

		private string _serverMessage;

		private string _response;

		public bool IsHttpError
		{
			get
			{
				return _isHttpError;
			}
			private set
			{
				_isHttpError = value;
			}
		}

		public bool IsNetworkError
		{
			get
			{
				return _isNetworkError;
			}
			private set
			{
				_isNetworkError = value;
			}
		}

		public long StatusCode
		{
			get
			{
				return _statusCode;
			}
			private set
			{
				_statusCode = value;
			}
		}

		public string ServerMessage
		{
			get
			{
				return _serverMessage;
			}
			set
			{
				_serverMessage = value;
			}
		}

		public string Response
		{
			get
			{
				return _response;
			}
			set
			{
				_response = value;
			}
		}

		public RequestException()
		{
		}

		public RequestException(string message)
			: base(message)
		{
		}

		public RequestException(string format, params object[] args)
			: base(string.Format(format, args))
		{
		}

		public RequestException(string message, bool isHttpError, bool isNetworkError, long statusCode, string response)
			: base(message)
		{
			_isHttpError = isHttpError;
			_isNetworkError = isNetworkError;
			_statusCode = statusCode;
			_response = response;
		}
	}
	public class RequestHelper
	{
		private string _uri;

		private string _method;

		private object _body;

		private string _bodyString;

		private byte[] _bodyRaw;

		private int? _timeout;

		private string _contentType;

		private int _retries;

		private float _retrySecondsDelay;

		private Action<RequestException, int> _retryCallback;

		private bool _enableDebug;

		private bool? _chunkedTransfer;

		private bool? _useHttpContinue = true;

		private int? _redirectLimit;

		private bool _ignoreHttpException;

		private WWWForm _formData;

		private Dictionary<string, string> _simpleForm;

		private List<IMultipartFormSection> _formSections;

		private CertificateHandler _certificateHandler;

		private UploadHandler _uploadHandler;

		private DownloadHandler _downloadHandler;

		private Dictionary<string, string> _headers;

		private bool _isAborted;

		private bool _defaultContentType = true;

		public string Uri
		{
			get
			{
				return _uri;
			}
			set
			{
				_uri = value;
			}
		}

		public string Method
		{
			get
			{
				return _method;
			}
			set
			{
				_method = value;
			}
		}

		public object Body
		{
			get
			{
				return _body;
			}
			set
			{
				_body = value;
			}
		}

		public string BodyString
		{
			get
			{
				return _bodyString;
			}
			set
			{
				_bodyString = value;
			}
		}

		public byte[] BodyRaw
		{
			get
			{
				return _bodyRaw;
			}
			set
			{
				_bodyRaw = value;
			}
		}

		public int? Timeout
		{
			get
			{
				return _timeout;
			}
			set
			{
				_timeout = value;
			}
		}

		public string ContentType
		{
			get
			{
				return _contentType;
			}
			set
			{
				_contentType = value;
			}
		}

		public int Retries
		{
			get
			{
				return _retries;
			}
			set
			{
				_retries = value;
			}
		}

		public float RetrySecondsDelay
		{
			get
			{
				return _retrySecondsDelay;
			}
			set
			{
				_retrySecondsDelay = value;
			}
		}

		public Action<RequestException, int> RetryCallback
		{
			get
			{
				return _retryCallback;
			}
			set
			{
				_retryCallback = value;
			}
		}

		public bool EnableDebug
		{
			get
			{
				return _enableDebug;
			}
			set
			{
				_enableDebug = value;
			}
		}

		public bool? ChunkedTransfer
		{
			get
			{
				return _chunkedTransfer;
			}
			set
			{
				_chunkedTransfer = value;
			}
		}

		public bool? UseHttpContinue
		{
			get
			{
				return _useHttpContinue;
			}
			set
			{
				_useHttpContinue = value;
			}
		}

		public int? RedirectLimit
		{
			get
			{
				return _redirectLimit;
			}
			set
			{
				_redirectLimit = value;
			}
		}

		public bool IgnoreHttpException
		{
			get
			{
				return _ignoreHttpException;
			}
			set
			{
				_ignoreHttpException = value;
			}
		}

		public WWWForm FormData
		{
			get
			{
				return _formData;
			}
			set
			{
				_formData = value;
			}
		}

		public Dictionary<string, string> SimpleForm
		{
			get
			{
				return _simpleForm;
			}
			set
			{
				_simpleForm = value;
			}
		}

		public List<IMultipartFormSection> FormSections
		{
			get
			{
				return _formSections;
			}
			set
			{
				_formSections = value;
			}
		}

		public CertificateHandler CertificateHandler
		{
			get
			{
				return _certificateHandler;
			}
			set
			{
				_certificateHandler = value;
			}
		}

		public UploadHandler UploadHandler
		{
			get
			{
				return _uploadHandler;
			}
			set
			{
				_uploadHandler = value;
			}
		}

		public DownloadHandler DownloadHandler
		{
			get
			{
				return _downloadHandler;
			}
			set
			{
				_downloadHandler = value;
			}
		}

		public Dictionary<string, string> Headers
		{
			get
			{
				if (_headers == null)
				{
					_headers = new Dictionary<string, string>();
				}
				return _headers;
			}
			set
			{
				_headers = value;
			}
		}

		public UnityWebRequest Request { private get; set; }

		public float UploadProgress
		{
			get
			{
				float result = 0f;
				if (Request != null)
				{
					result = Request.uploadProgress;
				}
				return result;
			}
		}

		public ulong UploadedBytes
		{
			get
			{
				ulong result = 0uL;
				if (Request != null)
				{
					result = Request.uploadedBytes;
				}
				return result;
			}
		}

		public float DownloadProgress
		{
			get
			{
				float result = 0f;
				if (Request != null)
				{
					result = Request.downloadProgress;
				}
				return result;
			}
		}

		public ulong DownloadedBytes
		{
			get
			{
				ulong result = 0uL;
				if (Request != null)
				{
					result = Request.downloadedBytes;
				}
				return result;
			}
		}

		public bool IsAborted
		{
			get
			{
				return _isAborted;
			}
			set
			{
				_isAborted = value;
			}
		}

		public bool DefaultContentType
		{
			get
			{
				return _defaultContentType;
			}
			set
			{
				_defaultContentType = value;
			}
		}

		public string GetHeader(string name)
		{
			if (Request != null)
			{
				return Request.GetRequestHeader(name);
			}
			Headers.TryGetValue(name, out var value);
			return value;
		}

		public void Abort()
		{
			if (Request != null && !IsAborted)
			{
				try
				{
					IsAborted = true;
					Request.Abort();
				}
				finally
				{
					Request = null;
				}
			}
		}
	}
	[Serializable]
	public class ResponseHelper
	{
		public UnityWebRequest Request { get; private set; }

		public long StatusCode => Request.responseCode;

		public byte[] Data
		{
			get
			{
				try
				{
					return Request.downloadHandler.data;
				}
				catch (Exception)
				{
					return null;
				}
			}
		}

		public string Text
		{
			get
			{
				try
				{
					return Request.downloadHandler.text;
				}
				catch (Exception)
				{
					return string.Empty;
				}
			}
		}

		public string Error => Request.error;

		public Dictionary<string, string> Headers => Request.GetResponseHeaders();

		public ResponseHelper(UnityWebRequest request)
		{
			Request = request;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this, prettyPrint: true);
		}
	}
	public static class StaticCoroutine
	{
		private class CoroutineHolder : MonoBehaviour
		{
		}

		private static CoroutineHolder _runner;

		private static CoroutineHolder runner
		{
			get
			{
				if (_runner == null)
				{
					_runner = new GameObject("Static Coroutine RestClient").AddComponent<CoroutineHolder>();
					UnityEngine.Object.DontDestroyOnLoad(_runner);
				}
				return _runner;
			}
		}

		public static Coroutine StartCoroutine(IEnumerator coroutine)
		{
			return runner.StartCoroutine(coroutine);
		}
	}
	public static class RestClient
	{
		private static Dictionary<string, string> _defaultRequestHeaders;

		public static Dictionary<string, string> DefaultRequestHeaders
		{
			get
			{
				if (_defaultRequestHeaders == null)
				{
					_defaultRequestHeaders = new Dictionary<string, string>();
				}
				return _defaultRequestHeaders;
			}
			set
			{
				_defaultRequestHeaders = value;
			}
		}

		public static void CleanDefaultHeaders()
		{
			DefaultRequestHeaders.Clear();
		}

		public static void Request(RequestHelper options, Action<RequestException, ResponseHelper> callback)
		{
			StaticCoroutine.StartCoroutine(HttpBase.DefaultUnityWebRequest(options, callback));
		}

		public static void Request<T>(RequestHelper options, Action<RequestException, ResponseHelper, T> callback)
		{
			StaticCoroutine.StartCoroutine(HttpBase.DefaultUnityWebRequest(options, callback));
		}

		public static void Get(string url, Action<RequestException, ResponseHelper> callback)
		{
			Get(new RequestHelper
			{
				Uri = url
			}, callback);
		}

		public static void Get(RequestHelper options, Action<RequestException, ResponseHelper> callback)
		{
			options.Method = "GET";
			Request(options, callback);
		}

		public static void Get<T>(string url, Action<RequestException, ResponseHelper, T> callback)
		{
			Get(new RequestHelper
			{
				Uri = url
			}, callback);
		}

		public static void Get<T>(RequestHelper options, Action<RequestException, ResponseHelper, T> callback)
		{
			options.Method = "GET";
			Request(options, callback);
		}

		public static void GetArray<T>(string url, Action<RequestException, ResponseHelper, T[]> callback)
		{
			GetArray(new RequestHelper
			{
				Uri = url
			}, callback);
		}

		public static void GetArray<T>(RequestHelper options, Action<RequestException, ResponseHelper, T[]> callback)
		{
			options.Method = "GET";
			StaticCoroutine.StartCoroutine(HttpBase.DefaultUnityWebRequest(options, callback));
		}

		public static void Post(string url, object body, Action<RequestException, ResponseHelper> callback)
		{
			Post(new RequestHelper
			{
				Uri = url,
				Body = body
			}, callback);
		}

		public static void Post(string url, string bodyString, Action<RequestException, ResponseHelper> callback)
		{
			Post(new RequestHelper
			{
				Uri = url,
				BodyString = bodyString
			}, callback);
		}

		public static void Post(RequestHelper options, Action<RequestException, ResponseHelper> callback)
		{
			options.Method = "POST";
			Request(options, callback);
		}

		public static void Post<T>(string url, object body, Action<RequestException, ResponseHelper, T> callback)
		{
			Post(new RequestHelper
			{
				Uri = url,
				Body = body
			}, callback);
		}

		public static void Post<T>(string url, string bodyString, Action<RequestException, ResponseHelper, T> callback)
		{
			Post(new RequestHelper
			{
				Uri = url,
				BodyString = bodyString
			}, callback);
		}

		public static void Post<T>(RequestHelper options, Action<RequestException, ResponseHelper, T> callback)
		{
			options.Method = "POST";
			Request(options, callback);
		}

		public static void Put(string url, object body, Action<RequestException, ResponseHelper> callback)
		{
			Put(new RequestHelper
			{
				Uri = url,
				Body = body
			}, callback);
		}

		public static void Put(string url, string bodyString, Action<RequestException, ResponseHelper> callback)
		{
			Put(new RequestHelper
			{
				Uri = url,
				BodyString = bodyString
			}, callback);
		}

		public static void Put(RequestHelper options, Action<RequestException, ResponseHelper> callback)
		{
			options.Method = "PUT";
			Request(options, callback);
		}

		public static void Put<T>(string url, object body, Action<RequestException, ResponseHelper, T> callback)
		{
			Put(new RequestHelper
			{
				Uri = url,
				Body = body
			}, callback);
		}

		public static void Put<T>(string url, string bodyString, Action<RequestException, ResponseHelper, T> callback)
		{
			Put(new RequestHelper
			{
				Uri = url,
				BodyString = bodyString
			}, callback);
		}

		public static void Put<T>(RequestHelper options, Action<RequestException, ResponseHelper, T> callback)
		{
			options.Method = "PUT";
			Request(options, callback);
		}

		public static void Delete(string url, Action<RequestException, ResponseHelper> callback)
		{
			Delete(new RequestHelper
			{
				Uri = url
			}, callback);
		}

		public static void Delete(RequestHelper options, Action<RequestException, ResponseHelper> callback)
		{
			options.Method = "DELETE";
			Request(options, callback);
		}

		public static void Head(string url, Action<RequestException, ResponseHelper> callback)
		{
			Head(new RequestHelper
			{
				Uri = url
			}, callback);
		}

		public static void Head(RequestHelper options, Action<RequestException, ResponseHelper> callback)
		{
			options.Method = "HEAD";
			Request(options, callback);
		}

		public static IPromise<ResponseHelper> Request(RequestHelper options)
		{
			Promise<ResponseHelper> promise = new Promise<ResponseHelper>();
			Request(options, promise.Promisify<ResponseHelper>);
			return promise;
		}

		public static IPromise<T> Request<T>(RequestHelper options)
		{
			Promise<T> promise = new Promise<T>();
			Request<T>(options, promise.Promisify);
			return promise;
		}

		public static IPromise<ResponseHelper> Get(string url)
		{
			return Get(new RequestHelper
			{
				Uri = url
			});
		}

		public static IPromise<ResponseHelper> Get(RequestHelper options)
		{
			Promise<ResponseHelper> promise = new Promise<ResponseHelper>();
			Get(options, promise.Promisify<ResponseHelper>);
			return promise;
		}

		public static IPromise<T> Get<T>(string url)
		{
			return Get<T>(new RequestHelper
			{
				Uri = url
			});
		}

		public static IPromise<T> Get<T>(RequestHelper options)
		{
			Promise<T> promise = new Promise<T>();
			Get<T>(options, promise.Promisify);
			return promise;
		}

		public static IPromise<T[]> GetArray<T>(string url)
		{
			return GetArray<T>(new RequestHelper
			{
				Uri = url
			});
		}

		public static IPromise<T[]> GetArray<T>(RequestHelper options)
		{
			Promise<T[]> promise = new Promise<T[]>();
			GetArray<T>(options, promise.Promisify);
			return promise;
		}

		public static IPromise<ResponseHelper> Post(string url, object body)
		{
			return Post(new RequestHelper
			{
				Uri = url,
				Body = body
			});
		}

		public static IPromise<ResponseHelper> Post(string url, string bodyString)
		{
			return Post(new RequestHelper
			{
				Uri = url,
				BodyString = bodyString
			});
		}

		public static IPromise<ResponseHelper> Post(RequestHelper options)
		{
			Promise<ResponseHelper> promise = new Promise<ResponseHelper>();
			Post(options, promise.Promisify<ResponseHelper>);
			return promise;
		}

		public static IPromise<T> Post<T>(string url, object body)
		{
			return Post<T>(new RequestHelper
			{
				Uri = url,
				Body = body
			});
		}

		public static IPromise<T> Post<T>(string url, string bodyString)
		{
			return Post<T>(new RequestHelper
			{
				Uri = url,
				BodyString = bodyString
			});
		}

		public static IPromise<T> Post<T>(RequestHelper options)
		{
			Promise<T> promise = new Promise<T>();
			Post<T>(options, promise.Promisify);
			return promise;
		}

		public static IPromise<ResponseHelper> Put(string url, object body)
		{
			return Put(new RequestHelper
			{
				Uri = url,
				Body = body
			});
		}

		public static IPromise<ResponseHelper> Put(string url, string bodyString)
		{
			return Put(new RequestHelper
			{
				Uri = url,
				BodyString = bodyString
			});
		}

		public static IPromise<ResponseHelper> Put(RequestHelper options)
		{
			Promise<ResponseHelper> promise = new Promise<ResponseHelper>();
			Put(options, promise.Promisify<ResponseHelper>);
			return promise;
		}

		public static IPromise<T> Put<T>(string url, object body)
		{
			return Put<T>(new RequestHelper
			{
				Uri = url,
				Body = body
			});
		}

		public static IPromise<T> Put<T>(string url, string bodyString)
		{
			return Put<T>(new RequestHelper
			{
				Uri = url,
				BodyString = bodyString
			});
		}

		public static IPromise<T> Put<T>(RequestHelper options)
		{
			Promise<T> promise = new Promise<T>();
			Put<T>(options, promise.Promisify);
			return promise;
		}

		public static IPromise<ResponseHelper> Delete(string url)
		{
			return Delete(new RequestHelper
			{
				Uri = url
			});
		}

		public static IPromise<ResponseHelper> Delete(RequestHelper options)
		{
			Promise<ResponseHelper> promise = new Promise<ResponseHelper>();
			Delete(options, promise.Promisify<ResponseHelper>);
			return promise;
		}

		public static IPromise<ResponseHelper> Head(string url)
		{
			return Delete(new RequestHelper
			{
				Uri = url
			});
		}

		public static IPromise<ResponseHelper> Head(RequestHelper options)
		{
			Promise<ResponseHelper> promise = new Promise<ResponseHelper>();
			Head(options, promise.Promisify<ResponseHelper>);
			return promise;
		}

		private static void Promisify<T>(this Promise<T> promise, RequestException error, T response)
		{
			if (error != null)
			{
				promise.Reject(error);
			}
			else
			{
				promise.Resolve(response);
			}
		}

		private static void Promisify<T>(this Promise<T> promise, RequestException error, ResponseHelper response, T body)
		{
			if (error != null && response != null)
			{
				error.ServerMessage = response.Error ?? error.Message;
			}
			promise.Promisify(error, body);
		}
	}
}
namespace Proyecto26.Common
{
	public static class Common
	{
		private const string CONTENT_TYPE_HEADER = "Content-Type";

		private const string DEFAULT_CONTENT_TYPE = "application/json";

		private static string GetFormSectionsContentType(out byte[] bodyRaw, RequestHelper options)
		{
			byte[] array = UnityWebRequest.GenerateBoundary();
			byte[] array2 = UnityWebRequest.SerializeFormSections(options.FormSections, array);
			byte[] bytes = Encoding.UTF8.GetBytes("\r\n--" + Encoding.UTF8.GetString(array) + "--");
			bodyRaw = new byte[array2.Length + bytes.Length];
			Buffer.BlockCopy(array2, 0, bodyRaw, 0, array2.Length);
			Buffer.BlockCopy(bytes, 0, bodyRaw, array2.Length, bytes.Length);
			return "multipart/form-data; boundary=" + Encoding.UTF8.GetString(array);
		}

		private static void ConfigureWebRequestWithOptions(UnityWebRequest request, byte[] bodyRaw, string contentType, RequestHelper options)
		{
			if (options.CertificateHandler != null)
			{
				request.certificateHandler = options.CertificateHandler;
			}
			if (options.UploadHandler != null)
			{
				request.uploadHandler = options.UploadHandler;
			}
			if (bodyRaw != null)
			{
				request.uploadHandler = new UploadHandlerRaw(bodyRaw);
				request.uploadHandler.contentType = contentType;
			}
			if (options.DownloadHandler != null)
			{
				request.downloadHandler = options.DownloadHandler;
			}
			else
			{
				request.downloadHandler = new DownloadHandlerBuffer();
			}
			if (!string.IsNullOrEmpty(contentType))
			{
				request.SetRequestHeader("Content-Type", contentType);
			}
			foreach (KeyValuePair<string, string> defaultRequestHeader in RestClient.DefaultRequestHeaders)
			{
				request.SetRequestHeader(defaultRequestHeader.Key, defaultRequestHeader.Value);
			}
			foreach (KeyValuePair<string, string> header in options.Headers)
			{
				request.SetRequestHeader(header.Key, header.Value);
			}
			if (options.Timeout.HasValue)
			{
				request.timeout = options.Timeout.Value;
			}
			if (options.ChunkedTransfer.HasValue)
			{
				request.chunkedTransfer = options.ChunkedTransfer.Value;
			}
			if (options.UseHttpContinue.HasValue)
			{
				request.useHttpContinue = options.UseHttpContinue.Value;
			}
			if (options.RedirectLimit.HasValue)
			{
				request.redirectLimit = options.RedirectLimit.Value;
			}
			options.Request = request;
		}

		public static IEnumerator SendWebRequestWithOptions(this UnityWebRequest request, RequestHelper options)
		{
			byte[] bodyRaw = options.BodyRaw;
			string value = string.Empty;
			if (!options.Headers.TryGetValue("Content-Type", out value) && options.DefaultContentType)
			{
				value = "application/json";
			}
			if (options.Body != null || !string.IsNullOrEmpty(options.BodyString))
			{
				string text = options.BodyString;
				if (options.Body != null)
				{
					text = JsonUtility.ToJson(options.Body);
				}
				bodyRaw = Encoding.UTF8.GetBytes(text.ToCharArray());
			}
			else if (options.SimpleForm != null && options.SimpleForm.Count > 0)
			{
				bodyRaw = UnityWebRequest.SerializeSimpleForm(options.SimpleForm);
				value = "application/x-www-form-urlencoded";
			}
			else if (options.FormSections != null && options.FormSections.Count > 0)
			{
				value = GetFormSectionsContentType(out bodyRaw, options);
			}
			else if (options.FormData != null)
			{
				value = string.Empty;
			}
			if (!string.IsNullOrEmpty(options.ContentType))
			{
				value = options.ContentType;
			}
			ConfigureWebRequestWithOptions(request, bodyRaw, value, options);
			yield return request.SendWebRequest();
		}
	}
	public static class Extensions
	{
		public static ResponseHelper CreateWebResponse(this UnityWebRequest request)
		{
			return new ResponseHelper(request);
		}

		public static bool IsValidRequest(this UnityWebRequest request, RequestHelper options)
		{
			if (request.isDone && !request.isNetworkError)
			{
				if (request.isHttpError)
				{
					return options.IgnoreHttpException;
				}
				return true;
			}
			return false;
		}
	}
}
namespace Models
{
	[Serializable]
	public class Photo
	{
		public int albumId;

		public int id;

		public string title;

		public string url;

		public string thumbnailUrl;

		public override string ToString()
		{
			return JsonUtility.ToJson(this, prettyPrint: true);
		}
	}
	[Serializable]
	public class Post
	{
		public int id;

		public int userId;

		public string title;

		public string body;

		public override string ToString()
		{
			return JsonUtility.ToJson(this, prettyPrint: true);
		}
	}
	[Serializable]
	public class Todo
	{
		public int id;

		public int userId;

		public string title;

		public bool completed;

		public override string ToString()
		{
			return JsonUtility.ToJson(this, prettyPrint: true);
		}
	}
	[Serializable]
	public class User
	{
		public int id;

		public string name;

		public string username;

		public string email;

		public string phone;

		public string website;

		public override string ToString()
		{
			return JsonUtility.ToJson(this, prettyPrint: true);
		}
	}
}
namespace DG.Tweening
{
	public static class DOTweenModulePhysics
	{
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.To(() => target.position, target.MovePosition, endValue, duration);
			tweenerCore.SetOptions(snapping).SetTarget(target);
			return tweenerCore;
		}

		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.To(() => target.position, target.MovePosition, new Vector3(endValue, 0f, 0f), duration);
			tweenerCore.SetOptions(AxisConstraint.X, snapping).SetTarget(target);
			return tweenerCore;
		}

		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.To(() => target.position, target.MovePosition, new Vector3(0f, endValue, 0f), duration);
			tweenerCore.SetOptions(AxisConstraint.Y, snapping).SetTarget(target);
			return tweenerCore;
		}

		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = DOTween.To(() => target.position, target.MovePosition, new Vector3(0f, 0f, endValue), duration);
			tweenerCore.SetOptions(AxisConstraint.Z, snapping).SetTarget(target);
			return tweenerCore;
		}

		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = DOTween.To(() => target.rotation, target.MoveRotation, endValue, duration);
			tweenerCore.SetTarget(target);
			tweenerCore.plugOptions.rotateMode = mode;
			return tweenerCore;
		}

		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, Vector3? up = null)
		{
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = DOTween.To(() => target.rotation, target.MoveRotation, towards, duration).SetTarget(target).SetSpecialStartupMode(SpecialStartupMode.SetLookAt);
			tweenerCore.plugOptions.axisConstraint = axisConstraint;
			tweenerCore.plugOptions.up = ((!up.HasValue) ? Vector3.up : up.Value);
			return tweenerCore;
		}

		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			if (numJumps < 1)
			{
				numJumps = 1;
			}
			float startPosY = 0f;
			float offsetY = -1f;
			bool offsetYSet = false;
			Sequence s = DOTween.Sequence();
			Tween yTween = DOTween.To(() => target.position, target.MovePosition, new Vector3(0f, jumpPower, 0f), duration / (float)(numJumps * 2)).SetOptions(AxisConstraint.Y, snapping).SetEase(Ease.OutQuad)
				.SetRelative()
				.SetLoops(numJumps * 2, LoopType.Yoyo)
				.OnStart(delegate
				{
					startPosY = target.position.y;
				});
			s.Append(DOTween.To(() => target.position, target.MovePosition, new Vector3(endValue.x, 0f, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetEase(Ease.Linear)).Join(DOTween.To(() => target.position, target.MovePosition, new Vector3(0f, 0f, endValue.z), duration).SetOptions(AxisConstraint.Z, snapping).SetEase(Ease.Linear)).Join(yTween)
				.SetTarget(target)
				.SetEase(DOTween.defaultEaseType);
			yTween.OnUpdate(delegate
			{
				if (!offsetYSet)
				{
					offsetYSet = true;
					offsetY = (s.isRelative ? endValue.y : (endValue.y - startPosY));
				}
				Vector3 position = target.position;
				position.y += DOVirtual.EasedValue(0f, offsetY, yTween.ElapsedPercentage(), Ease.OutQuad);
				target.MovePosition(position);
			});
			return s;
		}

		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			if (resolution < 1)
			{
				resolution = 1;
			}
			TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), () => target.position, target.MovePosition, new DG.Tweening.Plugins.Core.PathCore.Path(pathType, path, resolution, gizmoColor), duration).SetTarget(target).SetUpdate(UpdateType.Fixed);
			tweenerCore.plugOptions.isRigidbody = true;
			tweenerCore.plugOptions.mode = pathMode;
			return tweenerCore;
		}

		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			if (resolution < 1)
			{
				resolution = 1;
			}
			Transform trans = target.transform;
			TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), () => trans.localPosition, delegate(Vector3 x)
			{
				target.MovePosition((trans.parent == null) ? x : trans.parent.TransformPoint(x));
			}, new DG.Tweening.Plugins.Core.PathCore.Path(pathType, path, resolution, gizmoColor), duration).SetTarget(target).SetUpdate(UpdateType.Fixed);
			tweenerCore.plugOptions.isRigidbody = true;
			tweenerCore.plugOptions.mode = pathMode;
			tweenerCore.plugOptions.useLocalPosition = true;
			return tweenerCore;
		}

		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), () => target.position, target.MovePosition, path, duration).SetTarget(target);
			tweenerCore.plugOptions.isRigidbody = true;
			tweenerCore.plugOptions.mode = pathMode;
			return tweenerCore;
		}

		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			Transform trans = target.transform;
			TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), () => trans.localPosition, delegate(Vector3 x)
			{
				target.MovePosition((trans.parent == null) ? x : trans.parent.TransformPoint(x));
			}, path, duration).SetTarget(target);
			tweenerCore.plugOptions.isRigidbody = true;
			tweenerCore.plugOptions.mode = pathMode;
			tweenerCore.plugOptions.useLocalPosition = true;
			return tweenerCore;
		}
	}
	public static class DOTweenModuleUnityVersion
	{
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			Sequence sequence = DOTween.Sequence();
			GradientColorKey[] colorKeys = gradient.colorKeys;
			int num = colorKeys.Length;
			for (int i = 0; i < num; i++)
			{
				GradientColorKey gradientColorKey = colorKeys[i];
				if (i == 0 && gradientColorKey.time <= 0f)
				{
					target.color = gradientColorKey.color;
					continue;
				}
				float duration2 = ((i == num - 1) ? (duration - sequence.Duration(includeLoops: false)) : (duration * ((i == 0) ? gradientColorKey.time : (gradientColorKey.time - colorKeys[i - 1].time))));
				sequence.Append(target.DOColor(gradientColorKey.color, duration2).SetEase(Ease.Linear));
			}
			sequence.SetTarget(target);
			return sequence;
		}

		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			Sequence sequence = DOTween.Sequence();
			GradientColorKey[] colorKeys = gradient.colorKeys;
			int num = colorKeys.Length;
			for (int i = 0; i < num; i++)
			{
				GradientColorKey gradientColorKey = colorKeys[i];
				if (i == 0 && gradientColorKey.time <= 0f)
				{
					target.SetColor(property, gradientColorKey.color);
					continue;
				}
				float duration2 = ((i == num - 1) ? (duration - sequence.Duration(includeLoops: false)) : (duration * ((i == 0) ? gradientColorKey.time : (gradientColorKey.time - colorKeys[i - 1].time))));
				sequence.Append(target.DOColor(gradientColorKey.color, property, duration2).SetEase(Ease.Linear));
			}
			sequence.SetTarget(target);
			return sequence;
		}

		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			if (!t.active)
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return new DOTweenCYInstruction.WaitForCompletion(t);
		}

		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			if (!t.active)
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return new DOTweenCYInstruction.WaitForRewind(t);
		}

		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			if (!t.active)
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return new DOTweenCYInstruction.WaitForKill(t);
		}

		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			if (!t.active)
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return new DOTweenCYInstruction.WaitForElapsedLoops(t, elapsedLoops);
		}

		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			if (!t.active)
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return new DOTweenCYInstruction.WaitForPosition(t, position);
		}

		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			if (!t.active)
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogInvalidTween(t);
				}
				return null;
			}
			return new DOTweenCYInstruction.WaitForStart(t);
		}

		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			if (!target.HasProperty(propertyID))
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogMissingMaterialProperty(propertyID);
				}
				return null;
			}
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.GetTextureOffset(propertyID), delegate(Vector2 x)
			{
				target.SetTextureOffset(propertyID, x);
			}, endValue, duration);
			tweenerCore.SetTarget(target);
			return tweenerCore;
		}

		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			if (!target.HasProperty(propertyID))
			{
				if (DG.Tweening.Core.Debugger.logPriority > 0)
				{
					DG.Tweening.Core.Debugger.LogMissingMaterialProperty(propertyID);
				}
				return null;
			}
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(() => target.GetTextureScale(propertyID), delegate(Vector2 x)
			{
				target.SetTextureScale(propertyID, x);
			}, endValue, duration);
			tweenerCore.SetTarget(target);
			return tweenerCore;
		}
	}
	public static class DOTweenCYInstruction
	{
		public class WaitForCompletion : CustomYieldInstruction
		{
			private readonly Tween t;

			public override bool keepWaiting
			{
				get
				{
					if (t.active)
					{
						return !t.IsComplete();
					}
					return false;
				}
			}

			public WaitForCompletion(Tween tween)
			{
				t = tween;
			}
		}

		public class WaitForRewind : CustomYieldInstruction
		{
			private readonly Tween t;

			public override bool keepWaiting
			{
				get
				{
					if (t.active)
					{
						if (t.playedOnce)
						{
							return t.position * (float)(t.CompletedLoops() + 1) > 0f;
						}
						return true;
					}
					return false;
				}
			}

			public WaitForRewind(Tween tween)
			{
				t = tween;
			}
		}

		public class WaitForKill : CustomYieldInstruction
		{
			private readonly Tween t;

			public override bool keepWaiting => t.active;

			public WaitForKill(Tween tween)
			{
				t = tween;
			}
		}

		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			private readonly Tween t;

			private readonly int elapsedLoops;

			public override bool keepWaiting
			{
				get
				{
					if (t.active)
					{
						return t.CompletedLoops() < elapsedLoops;
					}
					return false;
				}
			}

			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
				t = tween;
				this.elapsedLoops = elapsedLoops;
			}
		}

		public class WaitForPosition : CustomYieldInstruction
		{
			private readonly Tween t;

			private readonly float position;

			public override bool keepWaiting
			{
				get
				{
					if (t.active)
					{
						return t.position * (float)(t.CompletedLoops() + 1) < position;
					}
					return false;
				}
			}

			public WaitForPosition(Tween tween, float position)
			{
				t = tween;
				this.position = position;
			}
		}

		public class WaitForStart : CustomYieldInstruction
		{
			private readonly Tween t;

			public override bool keepWaiting
			{
				get
				{
					if (t.active)
					{
						return !t.playedOnce;
					}
					return false;
				}
			}

			public WaitForStart(Tween tween)
			{
				t = tween;
			}
		}
	}
	public static class DOTweenModuleUtils
	{
		public static class Physics
		{
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
				if (options.isRigidbody)
				{
					((Rigidbody)t.target).rotation = newRot;
				}
				else
				{
					trans.rotation = newRot;
				}
			}

			public static bool HasRigidbody2D(UnityEngine.Component target)
			{
				return false;
			}

			[Preserve]
			public static bool HasRigidbody(UnityEngine.Component target)
			{
				return target.GetComponent<Rigidbody>() != null;
			}

			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				Rigidbody rigidbody = (tweenRigidbody ? target.GetComponent<Rigidbody>() : null);
				if (tweenRigidbody && rigidbody != null)
				{
					return isLocal ? rigidbody.DOLocalPath(path, duration, pathMode) : rigidbody.DOPath(path, duration, pathMode);
				}
				return isLocal ? target.transform.DOLocalPath(path, duration, pathMode) : target.transform.DOPath(path, duration, pathMode);
			}
		}

		private static bool _initialized;

		[Preserve]
		public static void Init()
		{
			if (!_initialized)
			{
				_initialized = true;
				DOTweenExternalCommand.SetOrientationOnPath += Physics.SetOrientationOnPath;
			}
		}

		[Preserve]
		private static void Preserver()
		{
			AppDomain.CurrentDomain.GetAssemblies();
			typeof(MonoBehaviour).GetMethod("Stub");
		}
	}
}
