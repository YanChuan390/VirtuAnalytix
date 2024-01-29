using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using AmazingAssets.CurvedWorld;
using Il2CppDummyDll;
using LDG.SoundReactor;
using Pico.Platform;
using Pico.Platform.Models;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.PostProcessing;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;
using Valve.VR;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000005")]
public class FPSShaderColorGradient : MonoBehaviour
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ShaderProperty;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int MaterialID;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Gradient Color;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float TimeMultiplier;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool canUpdate;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material matInstance;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int propertyID;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float startTime;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color oldColor;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x754A28", Offset = "0x754A28", VA = "0x754A28")]
	private void Start()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x754D0C", Offset = "0x754D0C", VA = "0x754D0C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x754D30", Offset = "0x754D30", VA = "0x754D30")]
	private void Update()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x754DB8", Offset = "0x754DB8", VA = "0x754DB8")]
	public FPSShaderColorGradient()
	{
	}
}
[Token(Token = "0x2000006")]
public class FPSShaderFloatCurves : MonoBehaviour
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ShaderProperty;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int MaterialID;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve FloatPropertyCurve;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float GraphTimeMultiplier;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float GraphScaleMultiplier;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool canUpdate;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material matInstance;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int propertyID;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float startTime;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x754E60", Offset = "0x754E60", VA = "0x754E60")]
	private void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x755124", Offset = "0x755124", VA = "0x755124")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x755148", Offset = "0x755148", VA = "0x755148")]
	private void Update()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x7551C0", Offset = "0x7551C0", VA = "0x7551C0")]
	public FPSShaderFloatCurves()
	{
	}
}
[Token(Token = "0x2000007")]
[AddComponentMenu("KriptoFX/Explosion_Bloom")]
[ImageEffectAllowedInSceneView]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Explosion_Bloom : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000008")]
	public struct Settings
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Tooltip("Filters out pixels under this level of brightness.")]
		public float threshold;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("Makes transition between under/over-threshold gradual.")]
		public float softKnee;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
		[SerializeField]
		[Range(1f, 7f)]
		public float radius;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		[Tooltip("Blend factor of the result image.")]
		public float intensity;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Tooltip("Controls filter quality and buffer resolution.")]
		public bool highQuality;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		[Tooltip("Reduces flashing noise with an additional filter.")]
		public bool antiFlicker;

		[Token(Token = "0x1700000F")]
		public float thresholdGamma
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x7560B8", Offset = "0x7560B8", VA = "0x7560B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x7560B0", Offset = "0x7560B0", VA = "0x7560B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public float thresholdLinear
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x755FF0", Offset = "0x755FF0", VA = "0x755FF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x7560C8", Offset = "0x7560C8", VA = "0x7560C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public static Settings defaultSettings
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x756098", Offset = "0x756098", VA = "0x756098")]
			get
			{
				return default(Settings);
			}
		}
	}

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Settings settings;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[HideInInspector]
	private Shader m_Shader;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material m_Material;

	[Token(Token = "0x4000021")]
	private const int kMaxIterations = 16;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RenderTexture[] m_blurBuffer1;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture[] m_blurBuffer2;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int m_Threshold;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int m_Curve;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int m_PrefilterOffs;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int m_SampleScale;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int m_Intensity;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int m_BaseTex;

	[Token(Token = "0x1700000C")]
	public Shader shader
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x755248", Offset = "0x755248", VA = "0x755248")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000D")]
	public Material material
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x7552E4", Offset = "0x7552E4", VA = "0x7552E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public static bool supportsDX11
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x7556AC", Offset = "0x7556AC", VA = "0x7556AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x755440", Offset = "0x755440", VA = "0x755440")]
	public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x755378", Offset = "0x755378", VA = "0x755378")]
	public static Material CheckShaderAndCreateMaterial(Shader s)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x7556D8", Offset = "0x7556D8", VA = "0x7556D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x7557F4", Offset = "0x7557F4", VA = "0x7557F4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x755830", Offset = "0x755830", VA = "0x755830")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x7558C4", Offset = "0x7558C4", VA = "0x7558C4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x756004", Offset = "0x756004", VA = "0x756004")]
	public Explosion_Bloom()
	{
	}
}
[Token(Token = "0x2000009")]
public class ExplosionDemoGUI : MonoBehaviour
{
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] Prefabs;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float reactivateTime;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Light Sun;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int currentNomber;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject currentInstance;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GUIStyle guiStyleHeader;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float sunIntensity;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float dpiScale;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x7560E4", Offset = "0x7560E4", VA = "0x7560E4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x7562D8", Offset = "0x7562D8", VA = "0x7562D8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x7565D0", Offset = "0x7565D0", VA = "0x7565D0")]
	private void ChangeCurrent(int delta)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x756784", Offset = "0x756784", VA = "0x756784")]
	public ExplosionDemoGUI()
	{
	}
}
[Token(Token = "0x200000A")]
public class ExplosionDemoReactivator : MonoBehaviour
{
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float TimeDelayToReactivate;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x756800", Offset = "0x756800", VA = "0x756800")]
	private void Start()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x756854", Offset = "0x756854", VA = "0x756854")]
	private void Reactivate()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x75691C", Offset = "0x75691C", VA = "0x75691C")]
	public ExplosionDemoReactivator()
	{
	}
}
[Token(Token = "0x200000B")]
public class ExplosionPlatformActivator : MonoBehaviour
{
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Effect;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float TimeDelay;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float DefaultRepeatTime;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float NearRepeatTime;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float currentTime;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float currentRepeatTime;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool canUpdate;

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x75692C", Offset = "0x75692C", VA = "0x75692C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x756984", Offset = "0x756984", VA = "0x756984")]
	private void Init()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x7569B0", Offset = "0x7569B0", VA = "0x7569B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x756A84", Offset = "0x756A84", VA = "0x756A84")]
	private void OnTriggerEnter(Collider coll)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x756A90", Offset = "0x756A90", VA = "0x756A90")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x756A9C", Offset = "0x756A9C", VA = "0x756A9C")]
	public ExplosionPlatformActivator()
	{
	}
}
[Token(Token = "0x200000C")]
public class ExplosionsFPS : MonoBehaviour
{
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly GUIStyle guiStyleHeader;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float timeleft;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float fps;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int frames;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x756AB0", Offset = "0x756AB0", VA = "0x756AB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x756B00", Offset = "0x756B00", VA = "0x756B00")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x756BF8", Offset = "0x756BF8", VA = "0x756BF8")]
	private void Update()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x756C4C", Offset = "0x756C4C", VA = "0x756C4C")]
	public ExplosionsFPS()
	{
	}
}
[Token(Token = "0x200000D")]
public class ExplosionsBillboard : MonoBehaviour
{
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera Camera;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool Active;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool AutoInitCamera;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject myContainer;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform t;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform camT;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform contT;

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x756CC0", Offset = "0x756CC0", VA = "0x756CC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x756EFC", Offset = "0x756EFC", VA = "0x756EFC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x757080", Offset = "0x757080", VA = "0x757080")]
	public ExplosionsBillboard()
	{
	}
}
[Token(Token = "0x200000E")]
public class ExplosionsDeactivateRendererByTime : MonoBehaviour
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float TimeDelay;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer rend;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x757090", Offset = "0x757090", VA = "0x757090")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x7570E8", Offset = "0x7570E8", VA = "0x7570E8")]
	private void DeactivateRenderer()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x757108", Offset = "0x757108", VA = "0x757108")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x757170", Offset = "0x757170", VA = "0x757170")]
	public ExplosionsDeactivateRendererByTime()
	{
	}
}
[Token(Token = "0x200000F")]
public class ExplosionsLightCurves : MonoBehaviour
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve LightCurve;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float GraphTimeMultiplier;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float GraphIntensityMultiplier;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool canUpdate;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float startTime;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Light lightSource;

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x757180", Offset = "0x757180", VA = "0x757180")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x757204", Offset = "0x757204", VA = "0x757204")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x757228", Offset = "0x757228", VA = "0x757228")]
	private void Update()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x75729C", Offset = "0x75729C", VA = "0x75729C")]
	public ExplosionsLightCurves()
	{
	}
}
[Token(Token = "0x2000010")]
[ExecuteInEditMode]
public class ExplosionsParticleSystemScaler : MonoBehaviour
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float particlesScale;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float oldScale;

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x7572E4", Offset = "0x7572E4", VA = "0x7572E4")]
	private void Start()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x7572F0", Offset = "0x7572F0", VA = "0x7572F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x7572F4", Offset = "0x7572F4", VA = "0x7572F4")]
	public ExplosionsParticleSystemScaler()
	{
	}
}
[Token(Token = "0x2000011")]
public class ExplosionsScaleCurves : MonoBehaviour
{
	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve ScaleCurveX;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve ScaleCurveY;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve ScaleCurveZ;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 GraphTimeMultiplier;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 GraphScaleMultiplier;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float startTime;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform t;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float evalX;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float evalY;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float evalZ;

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x757304", Offset = "0x757304", VA = "0x757304")]
	private void Awake()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x757328", Offset = "0x757328", VA = "0x757328")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x75734C", Offset = "0x75734C", VA = "0x75734C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x757410", Offset = "0x757410", VA = "0x757410")]
	public ExplosionsScaleCurves()
	{
	}
}
[Token(Token = "0x2000012")]
public class ExplosionsShaderColorGradient : MonoBehaviour
{
	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ShaderProperty;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int MaterialID;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Gradient Color;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float TimeMultiplier;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool canUpdate;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material matInstance;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int propertyID;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float startTime;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color oldColor;

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x757508", Offset = "0x757508", VA = "0x757508")]
	private void Start()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x75769C", Offset = "0x75769C", VA = "0x75769C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x7576C0", Offset = "0x7576C0", VA = "0x7576C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x757748", Offset = "0x757748", VA = "0x757748")]
	public ExplosionsShaderColorGradient()
	{
	}
}
[Token(Token = "0x2000013")]
public class ExplosionsShaderFloatCurves : MonoBehaviour
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ShaderProperty;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int MaterialID;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve FloatPropertyCurve;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float GraphTimeMultiplier;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float GraphScaleMultiplier;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool canUpdate;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material matInstance;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int propertyID;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float startTime;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x7577F0", Offset = "0x7577F0", VA = "0x7577F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x757964", Offset = "0x757964", VA = "0x757964")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x757988", Offset = "0x757988", VA = "0x757988")]
	private void Update()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x757A00", Offset = "0x757A00", VA = "0x757A00")]
	public ExplosionsShaderFloatCurves()
	{
	}
}
[Token(Token = "0x2000014")]
public class ExplosionsShaderQueue : MonoBehaviour
{
	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int AddQueue;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer rend;

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x757A88", Offset = "0x757A88", VA = "0x757A88")]
	private void Start()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x757B98", Offset = "0x757B98", VA = "0x757B98")]
	private void SetProjectorQueue()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x757C14", Offset = "0x757C14", VA = "0x757C14")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x757CA8", Offset = "0x757CA8", VA = "0x757CA8")]
	public ExplosionsShaderQueue()
	{
	}
}
[Token(Token = "0x2000015")]
internal class ExplosionsSpriteSheetAnimation : MonoBehaviour
{
	[Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class <UpdateCorutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ExplosionsSpriteSheetAnimation <>4__this;

		[Token(Token = "0x17000012")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x75866C", Offset = "0x75866C", VA = "0x75866C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x7586B4", Offset = "0x7586B4", VA = "0x7586B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x758130", Offset = "0x758130", VA = "0x758130")]
		[DebuggerHidden]
		public <UpdateCorutine>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x758508", Offset = "0x758508", VA = "0x758508", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x75850C", Offset = "0x75850C", VA = "0x75850C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x758674", Offset = "0x758674", VA = "0x758674", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int TilesX;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int TilesY;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float AnimationFPS;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool IsInterpolateFrames;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int StartFrameOffset;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool IsLoop;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float StartDelay;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationCurve FrameOverTime;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isInizialised;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int index;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int count;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int allCount;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float animationLifeTime;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool isVisible;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	private bool isCorutineStarted;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Renderer currentRenderer;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material instanceMaterial;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float currentInterpolatedTime;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float animationStartTime;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool animationStoped;

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x757CB8", Offset = "0x757CB8", VA = "0x757CB8")]
	private void Start()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x757D2C", Offset = "0x757D2C", VA = "0x757D2C")]
	private void InitDefaultVariables()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x757F80", Offset = "0x757F80", VA = "0x757F80")]
	private void Play()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x758084", Offset = "0x758084", VA = "0x758084")]
	private void PlayDelay()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x7580A4", Offset = "0x7580A4", VA = "0x7580A4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x7580D4", Offset = "0x7580D4", VA = "0x7580D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x758010", Offset = "0x758010", VA = "0x758010")]
	[IteratorStateMachine(typeof(<UpdateCorutine>d__26))]
	private IEnumerator UpdateCorutine()
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x758158", Offset = "0x758158", VA = "0x758158")]
	private void UpdateFrame()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x75827C", Offset = "0x75827C", VA = "0x75827C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x758410", Offset = "0x758410", VA = "0x758410")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x7584B0", Offset = "0x7584B0", VA = "0x7584B0")]
	public ExplosionsSpriteSheetAnimation()
	{
	}
}
[Token(Token = "0x2000017")]
public class FPS : MonoBehaviour
{
	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text fpsText;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int frameCount;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float timeSnapshot;

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x7586BC", Offset = "0x7586BC", VA = "0x7586BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x7586DC", Offset = "0x7586DC", VA = "0x7586DC")]
	private void UpdateFPS()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x7587C8", Offset = "0x7587C8", VA = "0x7587C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x7587CC", Offset = "0x7587CC", VA = "0x7587CC")]
	public FPS()
	{
	}
}
[Token(Token = "0x2000018")]
public class TargetFramerate : MonoBehaviour
{
	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int targetFramerate;

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x7587D4", Offset = "0x7587D4", VA = "0x7587D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x7587E0", Offset = "0x7587E0", VA = "0x7587E0")]
	public TargetFramerate()
	{
	}
}
[Token(Token = "0x2000019")]
public class PlayAudioSourceTimer : MonoBehaviour
{
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timer;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource audioSource;

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x7587F0", Offset = "0x7587F0", VA = "0x7587F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x758864", Offset = "0x758864", VA = "0x758864")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x758880", Offset = "0x758880", VA = "0x758880")]
	public void UnPause()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x75889C", Offset = "0x75889C", VA = "0x75889C")]
	public void Play()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x7588C0", Offset = "0x7588C0", VA = "0x7588C0")]
	public void Stop()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x7588DC", Offset = "0x7588DC", VA = "0x7588DC")]
	public void PlayDelayed(float delay)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x7588E0", Offset = "0x7588E0", VA = "0x7588E0")]
	public PlayAudioSourceTimer()
	{
	}
}
[Token(Token = "0x200001A")]
[ExecuteInEditMode]
public class LookAt : MonoBehaviour
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x7588F0", Offset = "0x7588F0", VA = "0x7588F0")]
	private void Start()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x758994", Offset = "0x758994", VA = "0x758994")]
	private void Update()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x758A20", Offset = "0x758A20", VA = "0x758A20")]
	public LookAt()
	{
	}
}
[Token(Token = "0x200001B")]
public class SpawnHandler : MonoBehaviour
{
	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject noteObject;

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x758A28", Offset = "0x758A28", VA = "0x758A28")]
	public void OnLevel(PropertyDriver driver)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x758B90", Offset = "0x758B90", VA = "0x758B90")]
	public SpawnHandler()
	{
	}
}
[Token(Token = "0x200001C")]
public class TranslateLocalMotion : MonoBehaviour
{
	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 direction;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float rate;

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x758B98", Offset = "0x758B98", VA = "0x758B98")]
	private void Start()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x758B9C", Offset = "0x758B9C", VA = "0x758B9C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x758C40", Offset = "0x758C40", VA = "0x758C40")]
	public TranslateLocalMotion()
	{
	}
}
[Token(Token = "0x200001D")]
public class SelfDestruct : MonoBehaviour
{
	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timer;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float counter;

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x758CA4", Offset = "0x758CA4", VA = "0x758CA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x758CAC", Offset = "0x758CAC", VA = "0x758CAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x758D50", Offset = "0x758D50", VA = "0x758D50")]
	public SelfDestruct()
	{
	}
}
[Token(Token = "0x200001E")]
public class EmissionHandler : MonoBehaviour
{
	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color emissionColor;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material material;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int emissionColorID;

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x758D60", Offset = "0x758D60", VA = "0x758D60")]
	private void Start()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x758E60", Offset = "0x758E60", VA = "0x758E60")]
	public void OnLevel(PropertyDriver driver)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x758F20", Offset = "0x758F20", VA = "0x758F20")]
	public EmissionHandler()
	{
	}
}
[Token(Token = "0x200001F")]
public class SceneCycler : MonoBehaviour
{
	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Scene[] scenes;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int sceneIndex;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int currentSceneIndex;

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x758F28", Offset = "0x758F28", VA = "0x758F28")]
	private void Start()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x758F2C", Offset = "0x758F2C", VA = "0x758F2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x7590E0", Offset = "0x7590E0", VA = "0x7590E0")]
	public SceneCycler()
	{
	}
}
[Token(Token = "0x2000020")]
public class Earthquake : MonoBehaviour
{
	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float radius;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector2 speed;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector2 sinCos;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 originalPos;

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x7590F0", Offset = "0x7590F0", VA = "0x7590F0")]
	private void Start()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x759164", Offset = "0x759164", VA = "0x759164")]
	private void Update()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x759244", Offset = "0x759244", VA = "0x759244")]
	public void OnLevel(PropertyDriver driver)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x759270", Offset = "0x759270", VA = "0x759270")]
	public Earthquake()
	{
	}
}
[Token(Token = "0x2000021")]
public class SimulationSpeed : MonoBehaviour
{
	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x759280", Offset = "0x759280", VA = "0x759280")]
	private void Start()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x7592D8", Offset = "0x7592D8", VA = "0x7592D8")]
	public void OnLevel(PropertyDriver driver)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x75938C", Offset = "0x75938C", VA = "0x75938C")]
	public SimulationSpeed()
	{
	}
}
[Token(Token = "0x2000022")]
public class FPSLightCurves : MonoBehaviour
{
	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve LightCurve;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float GraphTimeMultiplier;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float GraphIntensityMultiplier;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool canUpdate;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float startTime;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Light lightSource;

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x759394", Offset = "0x759394", VA = "0x759394")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x759418", Offset = "0x759418", VA = "0x759418")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x75943C", Offset = "0x75943C", VA = "0x75943C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x7594B0", Offset = "0x7594B0", VA = "0x7594B0")]
	public FPSLightCurves()
	{
	}
}
[Token(Token = "0x2000023")]
public class FPSRandomRotateAngle : MonoBehaviour
{
	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool RotateX;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool RotateY;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool RotateZ;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform t;

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x7594F8", Offset = "0x7594F8", VA = "0x7594F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x75951C", Offset = "0x75951C", VA = "0x75951C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x7595F0", Offset = "0x7595F0", VA = "0x7595F0")]
	public FPSRandomRotateAngle()
	{
	}
}
[Token(Token = "0x2000024")]
public class ExampleWheelController : MonoBehaviour
{
	[Token(Token = "0x2000025")]
	private static class Uniforms
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly int _MotionAmount;
	}

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float acceleration;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer motionVectorRenderer;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Rigidbody m_Rigidbody;

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x759600", Offset = "0x759600", VA = "0x759600")]
	private void Start()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x759674", Offset = "0x759674", VA = "0x759674")]
	private void Update()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x7597D0", Offset = "0x7597D0", VA = "0x7597D0")]
	public ExampleWheelController()
	{
	}
}
[Token(Token = "0x2000026")]
public class CameraScroll : MonoBehaviour
{
	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float acceleration;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lookSensitivity;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float yaw;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float pitch;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CameraScroll main;

	[Token(Token = "0x17000014")]
	public Vector3 velocity
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x759840", Offset = "0x759840", VA = "0x759840")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x75984C", Offset = "0x75984C", VA = "0x75984C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x759858", Offset = "0x759858", VA = "0x759858")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x7598B0", Offset = "0x7598B0", VA = "0x7598B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x759E40", Offset = "0x759E40", VA = "0x759E40")]
	public CameraScroll()
	{
	}
}
[Token(Token = "0x2000027")]
public class SkyboxSwitcher : MonoBehaviour
{
	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Material[] mats;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int current;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string message;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x759E5C", Offset = "0x759E5C", VA = "0x759E5C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x759FBC", Offset = "0x759FBC", VA = "0x759FBC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x75A060", Offset = "0x75A060", VA = "0x75A060")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x759EDC", Offset = "0x759EDC", VA = "0x759EDC")]
	private void Load(int i)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x75A2E4", Offset = "0x75A2E4", VA = "0x75A2E4")]
	public SkyboxSwitcher()
	{
	}
}
[Token(Token = "0x2000028")]
public class CargaInicialPC : MonoBehaviour
{
	[Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class <RelocolarPasadoUnTiempo>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CargaInicialPC <>4__this;

		[Token(Token = "0x17000015")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x75AD40", Offset = "0x75AD40", VA = "0x75AD40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x75AD88", Offset = "0x75AD88", VA = "0x75AD88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x75A9A8", Offset = "0x75A9A8", VA = "0x75A9A8")]
		[DebuggerHidden]
		public <RelocolarPasadoUnTiempo>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x75AC8C", Offset = "0x75AC8C", VA = "0x75AC8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x75AC90", Offset = "0x75AC90", VA = "0x75AC90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x75AD48", Offset = "0x75AD48", VA = "0x75AD48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class <EsperaCargarEscena>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CargaInicialPC <>4__this;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x75AE9C", Offset = "0x75AE9C", VA = "0x75AE9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x75AEE4", Offset = "0x75AEE4", VA = "0x75AEE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x75AC38", Offset = "0x75AC38", VA = "0x75AC38")]
		[DebuggerHidden]
		public <EsperaCargarEscena>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x75AD90", Offset = "0x75AD90", VA = "0x75AD90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x75AD94", Offset = "0x75AD94", VA = "0x75AD94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x75AEA4", Offset = "0x75AEA4", VA = "0x75AEA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int tablasCargadas;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool cargandoEscena;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PostProcessingProfile profileEfectos;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image loadingImage;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform posicionDeLaCabeza;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform player;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform cabeza;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int cantidadTablasACargar;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float fillDeseado;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float inicioCarga;

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x75A33C", Offset = "0x75A33C", VA = "0x75A33C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x75A934", Offset = "0x75A934", VA = "0x75A934")]
	[IteratorStateMachine(typeof(<RelocolarPasadoUnTiempo>d__9))]
	private IEnumerator RelocolarPasadoUnTiempo()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x75A9D0", Offset = "0x75A9D0", VA = "0x75A9D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x75ABC4", Offset = "0x75ABC4", VA = "0x75ABC4")]
	[IteratorStateMachine(typeof(<EsperaCargarEscena>d__13))]
	private IEnumerator EsperaCargarEscena()
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x75AC60", Offset = "0x75AC60", VA = "0x75AC60")]
	private void TablaEncontrada(object sender, string tabla)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x75A6D4", Offset = "0x75A6D4", VA = "0x75A6D4")]
	private void RollBackPuntos()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x75A7D8", Offset = "0x75A7D8", VA = "0x75A7D8")]
	public void RecolocarCabeza()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x75AC84", Offset = "0x75AC84", VA = "0x75AC84")]
	public CargaInicialPC()
	{
	}
}
[Token(Token = "0x200002B")]
public class cargainicialQuest : MonoBehaviour
{
	[Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class <EsperaCargarEscena>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x75B084", Offset = "0x75B084", VA = "0x75B084", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x75B0CC", Offset = "0x75B0CC", VA = "0x75B0CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x75AF4C", Offset = "0x75AF4C", VA = "0x75AF4C")]
		[DebuggerHidden]
		public <EsperaCargarEscena>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x75AF9C", Offset = "0x75AF9C", VA = "0x75AF9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x75AFA0", Offset = "0x75AFA0", VA = "0x75AFA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x75B08C", Offset = "0x75B08C", VA = "0x75B08C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x75AEEC", Offset = "0x75AEEC", VA = "0x75AEEC")]
	[IteratorStateMachine(typeof(<EsperaCargarEscena>d__0))]
	private IEnumerator EsperaCargarEscena()
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x75AF74", Offset = "0x75AF74", VA = "0x75AF74")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x75AF94", Offset = "0x75AF94", VA = "0x75AF94")]
	public cargainicialQuest()
	{
	}
}
[Token(Token = "0x200002D")]
public class ControlPirateoOculus : MonoBehaviour
{
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x75B0D4", Offset = "0x75B0D4", VA = "0x75B0D4")]
	public ControlPirateoOculus()
	{
	}
}
[Token(Token = "0x200002E")]
public class DetectorColisionesHaptic : MonoBehaviour
{
	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DetectorColisionesHaptic instance;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Collider m_collider;

	[Token(Token = "0x40000CD")]
	private const float intensidadInicial = 0.2f;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float ultimaVezQueVibre;

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x75B0DC", Offset = "0x75B0DC", VA = "0x75B0DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x75B134", Offset = "0x75B134", VA = "0x75B134")]
	public void VibracionDisparo(bool derecho)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x75B138", Offset = "0x75B138", VA = "0x75B138")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x75B13C", Offset = "0x75B13C", VA = "0x75B13C")]
	public DetectorColisionesHaptic()
	{
	}
}
[Token(Token = "0x200002F")]
public class InstanciadorPlayerSegunPlataforma : MonoBehaviour
{
	[Token(Token = "0x2000030")]
	public enum Plataforma
	{
		[Token(Token = "0x40000D5")]
		Steam,
		[Token(Token = "0x40000D6")]
		Oculus,
		[Token(Token = "0x40000D7")]
		Ps4,
		[Token(Token = "0x40000D8")]
		VivePort
	}

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Plataforma plataformaActual;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject playerSteam;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject playerPCGenerico;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject playerPs4;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject playerActual;

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x75B144", Offset = "0x75B144", VA = "0x75B144")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x75B518", Offset = "0x75B518", VA = "0x75B518")]
	public InstanciadorPlayerSegunPlataforma()
	{
	}
}
[Token(Token = "0x2000031")]
public class PoolBalasExplosiones : MonoBehaviour
{
	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject balaPrefab;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject impactoParedPrefab;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject impactoDronPrefab;

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x75B56C", Offset = "0x75B56C", VA = "0x75B56C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x75B570", Offset = "0x75B570", VA = "0x75B570")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x75B574", Offset = "0x75B574", VA = "0x75B574")]
	public PoolBalasExplosiones()
	{
	}
}
[Token(Token = "0x2000032")]
public class pruebaTrackers : MonoBehaviour
{
	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform cube;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public XRNode nodo;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<XRNodeState> nodeStates;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int indexTracker;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 aux;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x75B57C", Offset = "0x75B57C", VA = "0x75B57C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x75B580", Offset = "0x75B580", VA = "0x75B580")]
	private void ConseguirIndex()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x75B6A0", Offset = "0x75B6A0", VA = "0x75B6A0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x75B7BC", Offset = "0x75B7BC", VA = "0x75B7BC")]
	public pruebaTrackers()
	{
	}
}
[Token(Token = "0x2000033")]
public class recargarJuego : MonoBehaviour
{
	[Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class <cargarjuegoEnunRato>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x75B9AC", Offset = "0x75B9AC", VA = "0x75B9AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x75B9F4", Offset = "0x75B9F4", VA = "0x75B9F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x75B8A4", Offset = "0x75B8A4", VA = "0x75B8A4")]
		[DebuggerHidden]
		public <cargarjuegoEnunRato>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x75B8F4", Offset = "0x75B8F4", VA = "0x75B8F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x75B8F8", Offset = "0x75B8F8", VA = "0x75B8F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x75B9B4", Offset = "0x75B9B4", VA = "0x75B9B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x75B844", Offset = "0x75B844", VA = "0x75B844")]
	[IteratorStateMachine(typeof(<cargarjuegoEnunRato>d__0))]
	public IEnumerator cargarjuegoEnunRato()
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x75B8CC", Offset = "0x75B8CC", VA = "0x75B8CC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x75B8EC", Offset = "0x75B8EC", VA = "0x75B8EC")]
	public recargarJuego()
	{
	}
}
[Token(Token = "0x2000035")]
public class abrirPuertaSiMeAcerco : MonoBehaviour
{
	[Token(Token = "0x2000036")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x40000EE")]
		desconocido,
		[Token(Token = "0x40000EF")]
		cerca,
		[Token(Token = "0x40000F0")]
		lejos
	}

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool puertaAbierta;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject puertaIzquierda;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject puertaDerecha;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ultimoEstadoValidado;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioSource sndPuerta;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool primerCambio;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] dianasQueTengoQueRomperParaQueSeAbra;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material materialSeleccionado;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int ticksSinActualizar;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x75B9FC", Offset = "0x75B9FC", VA = "0x75B9FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x75BB08", Offset = "0x75BB08", VA = "0x75BB08")]
	private void RefrescarNivel()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x75BB78", Offset = "0x75BB78", VA = "0x75BB78")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x75BB7C", Offset = "0x75BB7C", VA = "0x75BB7C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x75BF60", Offset = "0x75BF60", VA = "0x75BF60")]
	public abrirPuertaSiMeAcerco()
	{
	}
}
[Token(Token = "0x2000037")]
public class actualizarLabelEstado : MonoBehaviour
{
	[Token(Token = "0x2000038")]
	public enum LabelEstado
	{
		[Token(Token = "0x40000F5")]
		score,
		[Token(Token = "0x40000F6")]
		porcentaje,
		[Token(Token = "0x40000F7")]
		tiempo
	}

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMesh textoDondeColocarElPorcentaje;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int ticksSinActualizar;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LabelEstado informacion;

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x75BF70", Offset = "0x75BF70", VA = "0x75BF70")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x75BFCC", Offset = "0x75BFCC", VA = "0x75BFCC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x75C0E8", Offset = "0x75C0E8", VA = "0x75C0E8")]
	public actualizarLabelEstado()
	{
	}
}
[Token(Token = "0x2000039")]
public class alargarContadorTiempo : MonoBehaviour
{
	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource audioSourceMusica;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x75C0F0", Offset = "0x75C0F0", VA = "0x75C0F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x75C148", Offset = "0x75C148", VA = "0x75C148")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x75C22C", Offset = "0x75C22C", VA = "0x75C22C")]
	public alargarContadorTiempo()
	{
	}
}
[Token(Token = "0x200003A")]
public class AnimadorColorBarras : MonoBehaviour
{
	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material colorBarras;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color[] coloresBarras;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float t;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Color colorInicial;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Color colorFinal;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int indexColor;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float velocidadCambio;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool cambiarEmission;

	[Token(Token = "0x4000101")]
	private const string emissionColor = "_EmissionColor";

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x75C234", Offset = "0x75C234", VA = "0x75C234")]
	private void Start()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x75C278", Offset = "0x75C278", VA = "0x75C278")]
	private void Update()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x75C3F4", Offset = "0x75C3F4", VA = "0x75C3F4")]
	public AnimadorColorBarras()
	{
	}
}
[Token(Token = "0x200003B")]
public class apagameSiEstoyLejos : MonoBehaviour
{
	[Token(Token = "0x200003C")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x4000108")]
		desconocido,
		[Token(Token = "0x4000109")]
		cerca,
		[Token(Token = "0x400010A")]
		lejos
	}

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int ticksSinActualizar;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int aQueDistanciaMeTengoQueEncender;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject apagaEsto;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject apagaEsto2;

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x75C404", Offset = "0x75C404", VA = "0x75C404")]
	private void Start()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x75C40C", Offset = "0x75C40C", VA = "0x75C40C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x75C5E4", Offset = "0x75C5E4", VA = "0x75C5E4")]
	public apagameSiEstoyLejos()
	{
	}
}
[Token(Token = "0x200003D")]
public class ApagarEncender : MonoBehaviour
{
	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshRenderer meshR;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int ticks;

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x75C5F4", Offset = "0x75C5F4", VA = "0x75C5F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x75C64C", Offset = "0x75C64C", VA = "0x75C64C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x75C6AC", Offset = "0x75C6AC", VA = "0x75C6AC")]
	public ApagarEncender()
	{
	}
}
[Token(Token = "0x200003E")]
public class ApagarEnStart : MonoBehaviour
{
	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x75C6B4", Offset = "0x75C6B4", VA = "0x75C6B4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x75C6D8", Offset = "0x75C6D8", VA = "0x75C6D8")]
	public ApagarEnStart()
	{
	}
}
[Token(Token = "0x200003F")]
public class apagarSegunPorcentaje : MonoBehaviour
{
	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int probabilidadDeEncendido;

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x75C6E0", Offset = "0x75C6E0", VA = "0x75C6E0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x75C730", Offset = "0x75C730", VA = "0x75C730")]
	public apagarSegunPorcentaje()
	{
	}
}
[Token(Token = "0x2000040")]
public class ApagarTimeSegunDistancia : MonoBehaviour
{
	[Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class <EfectoDesaparecer>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ApagarTimeSegunDistancia <>4__this;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool aparecer;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <t>5__2;

		[Token(Token = "0x1700001D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x75CCBC", Offset = "0x75CCBC", VA = "0x75CCBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x75CD04", Offset = "0x75CD04", VA = "0x75CD04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x75CAA4", Offset = "0x75CAA4", VA = "0x75CAA4")]
		[DebuggerHidden]
		public <EfectoDesaparecer>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x75CB70", Offset = "0x75CB70", VA = "0x75CB70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x75CB74", Offset = "0x75CB74", VA = "0x75CB74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x75CCC4", Offset = "0x75CCC4", VA = "0x75CCC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int ticksSinActualizar;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer miRender;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material m_Material;

	[Token(Token = "0x4000111")]
	private const string level = "_Level";

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool visible;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Coroutine efectoAparecer;

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x75C740", Offset = "0x75C740", VA = "0x75C740")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x75C830", Offset = "0x75C830", VA = "0x75C830")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x75CA1C", Offset = "0x75CA1C", VA = "0x75CA1C")]
	[IteratorStateMachine(typeof(<EfectoDesaparecer>d__8))]
	private IEnumerator EfectoDesaparecer(bool aparecer)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x75CACC", Offset = "0x75CACC", VA = "0x75CACC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x75CB68", Offset = "0x75CB68", VA = "0x75CB68")]
	public ApagarTimeSegunDistancia()
	{
	}
}
[Token(Token = "0x2000042")]
public class AutoRotate : MonoBehaviour
{
	[Token(Token = "0x2000043")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x4000123")]
		desconocido,
		[Token(Token = "0x4000124")]
		cerca,
		[Token(Token = "0x4000125")]
		lejos
	}

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int ticksSinActualizar;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve curvaAnimacionLevitacion;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 rotation;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool sinMovimiento;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool rotarAlRitmo;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 posAux;

	[Token(Token = "0x4000120")]
	private const float velocidadMovimiento = 2f;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float tMovimiento;

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x75CD0C", Offset = "0x75CD0C", VA = "0x75CD0C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x75CDE8", Offset = "0x75CDE8", VA = "0x75CDE8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x75D010", Offset = "0x75D010", VA = "0x75D010")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x75D038", Offset = "0x75D038", VA = "0x75D038")]
	public AutoRotate()
	{
	}
}
[Token(Token = "0x2000044")]
public class bala : MonoBehaviour
{
	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float velocidad;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject explosion;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject explosionDron;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool exploto;

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x75D040", Offset = "0x75D040", VA = "0x75D040")]
	private void Start()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x75D0B0", Offset = "0x75D0B0", VA = "0x75D0B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x75D178", Offset = "0x75D178", VA = "0x75D178")]
	private void Explotar(bool aDron, Vector3 posicionDron)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x75D298", Offset = "0x75D298", VA = "0x75D298")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x75D2C8", Offset = "0x75D2C8", VA = "0x75D2C8")]
	public bala()
	{
	}
}
[Token(Token = "0x2000045")]
public class BotonMenu : MonoBehaviour
{
	[Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class <ExplotarYRetornar>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BotonMenu <>4__this;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x75D640", Offset = "0x75D640", VA = "0x75D640", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x75D688", Offset = "0x75D688", VA = "0x75D688", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x75D4C0", Offset = "0x75D4C0", VA = "0x75D4C0")]
		[DebuggerHidden]
		public <ExplotarYRetornar>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x75D4F8", Offset = "0x75D4F8", VA = "0x75D4F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x75D4FC", Offset = "0x75D4FC", VA = "0x75D4FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x75D648", Offset = "0x75D648", VA = "0x75D648", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent accionBoton;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool manoDerechaMeDisparo;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool dosArmas;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject botonSinRomper;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject botonRoto;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject explosion;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float coldownBoton;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool botonBloqueado;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private WaitForSeconds esperaParaRestablecer;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private WaitForSeconds esperaParaDesaparecer;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool soyDestruible;

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x75D2D0", Offset = "0x75D2D0", VA = "0x75D2D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x75D344", Offset = "0x75D344", VA = "0x75D344")]
	private void Restaurar()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x75D3CC", Offset = "0x75D3CC", VA = "0x75D3CC")]
	public void DisparoEnBoton(bool meDisparoDerecha)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x75D44C", Offset = "0x75D44C", VA = "0x75D44C")]
	[IteratorStateMachine(typeof(<ExplotarYRetornar>d__14))]
	private IEnumerator ExplotarYRetornar()
	{
		return null;
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x75D4E8", Offset = "0x75D4E8", VA = "0x75D4E8")]
	public BotonMenu()
	{
	}
}
[Token(Token = "0x2000047")]
public class camaraTVrotacion : MonoBehaviour
{
	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform cabeza;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float rotacionExtra;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float disminucionMovimiento;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Quaternion aux;

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x75D690", Offset = "0x75D690", VA = "0x75D690")]
	private void Start()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x75D694", Offset = "0x75D694", VA = "0x75D694")]
	private void Update()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x75D88C", Offset = "0x75D88C", VA = "0x75D88C")]
	public camaraTVrotacion()
	{
	}
}
[Token(Token = "0x2000048")]
public class ColocarBonus : MonoBehaviour
{
	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] posicionesBonus;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform grupoEsferas;

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x75D8A0", Offset = "0x75D8A0", VA = "0x75D8A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x75DC94", Offset = "0x75DC94", VA = "0x75DC94")]
	public ColocarBonus()
	{
	}
}
[Token(Token = "0x2000049")]
public class ControladorBalaJugador : MonoBehaviour
{
	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform balaMesh;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TrailRenderer trail;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float t;

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x75DC9C", Offset = "0x75DC9C", VA = "0x75DC9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x75DD14", Offset = "0x75DD14", VA = "0x75DD14")]
	private void Update()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x75DEB0", Offset = "0x75DEB0", VA = "0x75DEB0")]
	public ControladorBalaJugador()
	{
	}
}
[Token(Token = "0x200004A")]
public class ControladorFootPrints : MonoBehaviour
{
	[Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class <CicloColocarFootPrints>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControladorFootPrints <>4__this;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x75E538", Offset = "0x75E538", VA = "0x75E538", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x75E580", Offset = "0x75E580", VA = "0x75E580", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x75E250", Offset = "0x75E250", VA = "0x75E250")]
		[DebuggerHidden]
		public <CicloColocarFootPrints>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x75E44C", Offset = "0x75E44C", VA = "0x75E44C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x75E450", Offset = "0x75E450", VA = "0x75E450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x75E540", Offset = "0x75E540", VA = "0x75E540", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject footPrintPrefab;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int cantidadFootPrints;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform[] poolFootPrtints;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform cabezaJugador;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private PlayerVR player;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool pongoDerecha;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int indexSiguienteEnElPool;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private WaitForSeconds esperaParaPoner;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x75DEB8", Offset = "0x75DEB8", VA = "0x75DEB8")]
	private void Start()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x75E1DC", Offset = "0x75E1DC", VA = "0x75E1DC")]
	[IteratorStateMachine(typeof(<CicloColocarFootPrints>d__9))]
	private IEnumerator CicloColocarFootPrints()
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x75E278", Offset = "0x75E278", VA = "0x75E278")]
	private void ColocarFootPrint()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x75E358", Offset = "0x75E358", VA = "0x75E358")]
	private void ApagarFootPrints()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x75E3D0", Offset = "0x75E3D0", VA = "0x75E3D0")]
	public ControladorFootPrints()
	{
	}
}
[Token(Token = "0x200004C")]
public class ControladorLaser : MonoBehaviour
{
	[Token(Token = "0x200004D")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x4000158")]
		desconocido,
		[Token(Token = "0x4000159")]
		cerca,
		[Token(Token = "0x400015A")]
		lejos
	}

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve curvaAnimacion;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float velocidadAnimacion;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool disparando;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform tLaser;

	[Token(Token = "0x4000150")]
	private const float xDerecha = 2f;

	[Token(Token = "0x4000151")]
	private const float xIzquierda = -2f;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float xInicial;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float xFinal;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Level levelAEvaluar;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int ticksSinActualizar;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x75E588", Offset = "0x75E588", VA = "0x75E588")]
	private void Start()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x75E698", Offset = "0x75E698", VA = "0x75E698")]
	private void Update()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x75E87C", Offset = "0x75E87C", VA = "0x75E87C")]
	public ControladorLaser()
	{
	}
}
[Token(Token = "0x200004E")]
public class ControladorMenu : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200004F")]
	public class BotonConDosEstados
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject botonApagado;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject botonEncendido;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool encendido;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x760498", Offset = "0x760498", VA = "0x760498")]
		public void CambiarEstadoActual(bool encender)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x7621CC", Offset = "0x7621CC", VA = "0x7621CC")]
		public BotonConDosEstados()
		{
		}
	}

	[Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class <EsperaPantallaNegraParaCerrar>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x762284", Offset = "0x762284", VA = "0x762284", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x7622CC", Offset = "0x7622CC", VA = "0x7622CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x760680", Offset = "0x760680", VA = "0x760680")]
		[DebuggerHidden]
		public <EsperaPantallaNegraParaCerrar>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x7621D4", Offset = "0x7621D4", VA = "0x7621D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x7621D8", Offset = "0x7621D8", VA = "0x7621D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x76228C", Offset = "0x76228C", VA = "0x76228C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class <LerpAbrirCerrarMensaje>d__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool abrir;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ControladorMenu <>4__this;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 <escalaInicio>5__2;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 <escalaFinal>5__3;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 <posInicio>5__4;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 <PosFinal>5__5;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float <t>5__6;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x7625E0", Offset = "0x7625E0", VA = "0x7625E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x762628", Offset = "0x762628", VA = "0x762628", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x761998", Offset = "0x761998", VA = "0x761998")]
		[DebuggerHidden]
		public <LerpAbrirCerrarMensaje>d__75(int <>1__state)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x7622D4", Offset = "0x7622D4", VA = "0x7622D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x7622D8", Offset = "0x7622D8", VA = "0x7622D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x7625E8", Offset = "0x7625E8", VA = "0x7625E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class <EsperaParaVerSiHayServicios>d__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControladorMenu <>4__this;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int nivel;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x7626BC", Offset = "0x7626BC", VA = "0x7626BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x762704", Offset = "0x762704", VA = "0x762704", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x761C94", Offset = "0x761C94", VA = "0x761C94")]
		[DebuggerHidden]
		public <EsperaParaVerSiHayServicios>d__88(int <>1__state)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x762630", Offset = "0x762630", VA = "0x762630", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x762634", Offset = "0x762634", VA = "0x762634", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x7626C4", Offset = "0x7626C4", VA = "0x7626C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class <mostrarCandado>d__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControladorMenu <>4__this;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x762874", Offset = "0x762874", VA = "0x762874", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x7628BC", Offset = "0x7628BC", VA = "0x7628BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x761F98", Offset = "0x761F98", VA = "0x761F98")]
		[DebuggerHidden]
		public <mostrarCandado>d__99(int <>1__state)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x76270C", Offset = "0x76270C", VA = "0x76270C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x762710", Offset = "0x762710", VA = "0x762710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x76287C", Offset = "0x76287C", VA = "0x76287C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class <EsperaParaRestaurarMenu>d__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControladorMenu <>4__this;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <t>5__2;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Color <colorPlane>5__3;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x762AF0", Offset = "0x762AF0", VA = "0x762AF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x762B38", Offset = "0x762B38", VA = "0x762B38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x761FC0", Offset = "0x761FC0", VA = "0x761FC0")]
		[DebuggerHidden]
		public <EsperaParaRestaurarMenu>d__101(int <>1__state)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x7628C4", Offset = "0x7628C4", VA = "0x7628C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x7628C8", Offset = "0x7628C8", VA = "0x7628C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x762AF8", Offset = "0x762AF8", VA = "0x762AF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class <AnimacionDesbloquearNivel>d__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControladorMenu <>4__this;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <t>5__2;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <posicionInical>5__3;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 <posicionFinal>5__4;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 <escalaInicial>5__5;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 <escalaFinal>5__6;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 <posicionInicalCandado>5__7;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 <posicionFinalCandado>5__8;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private MeshRenderer <rendererLock>5__9;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x7634E4", Offset = "0x7634E4", VA = "0x7634E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x76352C", Offset = "0x76352C", VA = "0x76352C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x7620F8", Offset = "0x7620F8", VA = "0x7620F8")]
		[DebuggerHidden]
		public <AnimacionDesbloquearNivel>d__106(int <>1__state)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x762B40", Offset = "0x762B40", VA = "0x762B40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x762B44", Offset = "0x762B44", VA = "0x762B44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x7634EC", Offset = "0x7634EC", VA = "0x7634EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Referencias")]
	private AudioSource sndDesbloquearCandado;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BotonConDosEstados botonUnArma;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public BotonConDosEstados botonDosArmas;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject botonAplicarCalidad;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public BotonConDosEstados botonMovimientoCabeza;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public BotonConDosEstados botonMovimientoMando;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public BotonConDosEstados botonRotacionCabeza;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMesh textoNivel;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMesh textoNivelMeta;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMesh textoNivelLeaderboard;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMesh textoIdioma;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMesh textoGraphics;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMesh textoGraphicsTV;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool modoDios;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AudioMixer masterMixer;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Transform sliderMusica;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Transform sliderFX;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform sliderSensibilidad;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject[] modelosMandos;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Material materialFoto;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Texture[] imagenesNiveles;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private AudioSource m_audioSource;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject menuSinRomper;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject menuRoto;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Rigidbody[] piezasMenuRoto;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform goPlane;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject nivelCompletado;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject nivelLock;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Material materialGoPlane;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Vector3[] posicionInicialpPezasMenuRoto;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private WaitForSeconds esperaParaRestaurarMenu;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[Space(5f)]
	[Header("Valores")]
	public bool boolMenuRoto;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public int porcentajeVolumenMusica;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public int porcentajeVolumenFX;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public int porcentajeSensibilidad;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public ManagerLeaderboard managerLeaderboard;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ControladorMenu instance;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public GameObject panelControl;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public GameObject panelManos;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public GameObject panelTutorial;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public GameObject PanelLastGame;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public GameObject PanelRecords;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public GameObject panelFoto;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public GameObject panelRecordTXT;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public GameObject BotonNivelAnterior;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public GameObject BotonNivelSiguiente;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public GameObject BotonNivelSiguienteTuto;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private bool panelMensajeAbierto;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public GameObject panelMensaje;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private Coroutine LerpAbrirMensajeCor;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private int ultimoNivelQuePediTabla;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private float ultimaVezQueCambieDeLeaderboard;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private int nivelMostradoEnLaTabla;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private Coroutine pedirLeaderboardPS4;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private WaitForSeconds espera005;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private WaitForSeconds espera02;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private Coroutine efectoCandado;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[Header("Animacion desbloquear nivel")]
	public GameObject candado;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public Transform imagenNivel;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public AnimationCurve AnimationCurveDesbloquearNivel;

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x75E884", Offset = "0x75E884", VA = "0x75E884")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x75E8DC", Offset = "0x75E8DC", VA = "0x75E8DC")]
	private void Start()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x75F930", Offset = "0x75F930", VA = "0x75F930")]
	private void Update()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x75F154", Offset = "0x75F154", VA = "0x75F154")]
	private void PonerEstadoInicialControl()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x7604F0", Offset = "0x7604F0", VA = "0x7604F0")]
	private void ConvertirA3dof()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x75F040", Offset = "0x75F040", VA = "0x75F040")]
	private void PonerEstadoInicialArmas()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x75F270", Offset = "0x75F270", VA = "0x75F270")]
	private void EncenderModelosDeMandoSegunPlataforma()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x760600", Offset = "0x760600", VA = "0x760600")]
	public void CerrarJuego()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x760620", Offset = "0x760620", VA = "0x760620")]
	[IteratorStateMachine(typeof(<EsperaPantallaNegraParaCerrar>d__56))]
	private IEnumerator EsperaPantallaNegraParaCerrar()
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x75F658", Offset = "0x75F658", VA = "0x75F658")]
	public void esconderOmostrarTutorial(bool esconderForzado = false)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x75FB64", Offset = "0x75FB64", VA = "0x75FB64")]
	public void Siguiente()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x75FDAC", Offset = "0x75FDAC", VA = "0x75FDAC")]
	public void Anterior()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x7606C4", Offset = "0x7606C4", VA = "0x7606C4")]
	public void CambiarVolumenMusica(bool subirVolumen)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x7607F4", Offset = "0x7607F4", VA = "0x7607F4")]
	public void CambiarVolumenFX(bool subirVolumen)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x7609DC", Offset = "0x7609DC", VA = "0x7609DC")]
	public void CambiarSensibilidadMovimiento(bool subirSensibilidad)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x760A80", Offset = "0x760A80", VA = "0x760A80")]
	public void CambiarEstadoArmas(BotonMenu botonArmas)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x760B68", Offset = "0x760B68", VA = "0x760B68")]
	public void CambiarEstadoControles(int control)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x760C60", Offset = "0x760C60", VA = "0x760C60")]
	public void Iniciar()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x761274", Offset = "0x761274", VA = "0x761274")]
	public void AjustarCalidadDelJuegoSegunCalidadActual()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x761360", Offset = "0x761360", VA = "0x761360")]
	public void CambiarCalidadGrafica()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x7613B8", Offset = "0x7613B8", VA = "0x7613B8")]
	public void CambiarCalidadTV()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x76153C", Offset = "0x76153C", VA = "0x76153C")]
	public void CambiarIdioma()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x75FFF0", Offset = "0x75FFF0", VA = "0x75FFF0")]
	public void CambiarLeaderboard(int siguiente)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x761858", Offset = "0x761858", VA = "0x761858")]
	public void AbrirPanelMensajes()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x761910", Offset = "0x761910", VA = "0x761910")]
	[IteratorStateMachine(typeof(<LerpAbrirCerrarMensaje>d__75))]
	private IEnumerator LerpAbrirCerrarMensaje(bool abrir)
	{
		return null;
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x7601D8", Offset = "0x7601D8", VA = "0x7601D8")]
	public void CerrarPanelMensaje()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x7619C0", Offset = "0x7619C0", VA = "0x7619C0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x761A4C", Offset = "0x761A4C", VA = "0x761A4C")]
	public void ponerFXaCero()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x761AA8", Offset = "0x761AA8", VA = "0x761AA8")]
	public void todoMuteadoYa()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x75EFB8", Offset = "0x75EFB8", VA = "0x75EFB8")]
	public void ponerFXyMusicaSegunPreferenciasDelJugador()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x7610A0", Offset = "0x7610A0", VA = "0x7610A0")]
	private void GrabarDatosPlayerPrefs()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x7602A8", Offset = "0x7602A8", VA = "0x7602A8")]
	private void PonerLeaderboardDeNivel(int nivel)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x761BA4", Offset = "0x761BA4", VA = "0x761BA4")]
	private void PonerLeaderboardAlFinalizarNivel()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x761C10", Offset = "0x761C10", VA = "0x761C10")]
	[IteratorStateMachine(typeof(<EsperaParaVerSiHayServicios>d__88))]
	private IEnumerator EsperaParaVerSiHayServicios(int nivel)
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x761CBC", Offset = "0x761CBC", VA = "0x761CBC")]
	private void RefrescarNivel()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x760160", Offset = "0x760160", VA = "0x760160")]
	private void ponerNivelTrucado(int nivel)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x75F2E8", Offset = "0x75F2E8", VA = "0x75F2E8")]
	private void ActualizarPanelNivelActual()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x76084C", Offset = "0x76084C", VA = "0x76084C")]
	private void SetVolumenFxSegunPorcentaje()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x76071C", Offset = "0x76071C", VA = "0x76071C")]
	private void SetVolumenMusicaSegunPorcentaje()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x75EFD0", Offset = "0x75EFD0", VA = "0x75EFD0")]
	private void SetSliderValue(Transform slider, int value)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x7606A8", Offset = "0x7606A8", VA = "0x7606A8")]
	private void ReproducirSonidoMenu()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x76102C", Offset = "0x76102C", VA = "0x76102C")]
	[IteratorStateMachine(typeof(<mostrarCandado>d__99))]
	private IEnumerator mostrarCandado()
	{
		return null;
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x761CE8", Offset = "0x761CE8", VA = "0x761CE8")]
	private void RestaurarMenu()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x761200", Offset = "0x761200", VA = "0x761200")]
	[IteratorStateMachine(typeof(<EsperaParaRestaurarMenu>d__101))]
	private IEnumerator EsperaParaRestaurarMenu()
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x761FE8", Offset = "0x761FE8", VA = "0x761FE8")]
	[ContextMenu("Boom")]
	public void IniciarAnimacionDesbloqueo()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x762084", Offset = "0x762084", VA = "0x762084")]
	[IteratorStateMachine(typeof(<AnimacionDesbloquearNivel>d__106))]
	private IEnumerator AnimacionDesbloquearNivel()
	{
		return null;
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x762120", Offset = "0x762120", VA = "0x762120")]
	public ControladorMenu()
	{
	}
}
[Token(Token = "0x2000056")]
public class ControladorPlayerPrefs
{
	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ControladorPlayerPrefs instance;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int playerPrefsSinSalvar;

	[Token(Token = "0x1700002F")]
	public static ControladorPlayerPrefs Instance
	{
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x76353C", Offset = "0x76353C", VA = "0x76353C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x763534", Offset = "0x763534", VA = "0x763534")]
	protected ControladorPlayerPrefs()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x7635CC", Offset = "0x7635CC", VA = "0x7635CC")]
	public void SetString(string id, string value)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x763694", Offset = "0x763694", VA = "0x763694")]
	public void SetInt(string id, int value)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x76375C", Offset = "0x76375C", VA = "0x76375C")]
	public void ComprobarPlayerPrefSinGuardar()
	{
	}
}
[Token(Token = "0x2000057")]
public class ControladorRobotCelebracion : MonoBehaviour
{
	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform tRobot;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform targetPosition;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Animator m_Animator;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int tipoCaminar;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int tipoCelebracion;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool activo;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool celebrando;

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x76380C", Offset = "0x76380C", VA = "0x76380C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x763890", Offset = "0x763890", VA = "0x763890")]
	private void Iniciar()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x7638EC", Offset = "0x7638EC", VA = "0x7638EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x763C64", Offset = "0x763C64", VA = "0x763C64")]
	public void Restaurar()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x763D6C", Offset = "0x763D6C", VA = "0x763D6C")]
	public ControladorRobotCelebracion()
	{
	}
}
[Token(Token = "0x2000058")]
public class ControladorSinDisco : MonoBehaviour
{
	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool puedoEmpezar;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float ultimaVezQueAumente;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float velocidadActual;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public float velocidadInicial;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform cabeza;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform posicionBase;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int ticksConTiempoLento;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float velocidadMano;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool movimientoExperimental;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float accionFlechasLaterales;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float accionFlechasVelocidad;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float movimientoHorizontal;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float movimientoVertical;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material colorParticulas;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color colorAux;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AnimationCurve curvaAnimacionParticulasVelocidad;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ParticleSystem particulasVelocidad;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ParticleSystem.MainModule moduloMainParticulasVelocidad;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private ParticleSystem.EmissionModule moduloEmisionParticulasVelocidad;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float lerpInicial;

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x763D74", Offset = "0x763D74", VA = "0x763D74")]
	private void Start()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x763E34", Offset = "0x763E34", VA = "0x763E34")]
	public void PonerVelocidadInicialSegunNivel(int nivelActual)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x763EF0", Offset = "0x763EF0", VA = "0x763EF0")]
	public void PonerPosicionBase()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x763F78", Offset = "0x763F78", VA = "0x763F78")]
	private void Update()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x764AA8", Offset = "0x764AA8", VA = "0x764AA8")]
	public ControladorSinDisco()
	{
	}
}
[Token(Token = "0x2000059")]
public class CopiarEscala : MonoBehaviour
{
	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform meCopioDeTi;

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x765AB0", Offset = "0x765AB0", VA = "0x765AB0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x765BA0", Offset = "0x765BA0", VA = "0x765BA0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x765C48", Offset = "0x765C48", VA = "0x765C48")]
	public CopiarEscala()
	{
	}
}
[Token(Token = "0x200005A")]
public class desplazarTextura : MonoBehaviour
{
	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer rend;

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x765C50", Offset = "0x765C50", VA = "0x765C50")]
	private void Start()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x765CA8", Offset = "0x765CA8", VA = "0x765CA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x765DD8", Offset = "0x765DD8", VA = "0x765DD8")]
	public desplazarTextura()
	{
	}
}
[Token(Token = "0x200005B")]
public class DisparadorTargets : MonoBehaviour
{
	[Token(Token = "0x200005C")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x40001F3")]
		desconocido,
		[Token(Token = "0x40001F4")]
		cerca,
		[Token(Token = "0x40001F5")]
		lejos
	}

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform target;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve curvaAnimacion;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float velocidadAnimacion;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool roto;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Level levelAEvaluar;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float t;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 posicionInicial;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int ticksForzadosSinBajar;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool estoyMuerto;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject efectoExplosion;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject dianaSinRomper;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject dianaRota;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform discoMedio;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform discoBordeCentro;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Rigidbody[] partesDiscoRoto;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3[] posicionesPartes;

	[Token(Token = "0x40001EC")]
	private const float velocidadGiro = 100f;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private WaitForSeconds esperaParaRestablecer;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Coroutine corrutinaRestaurar;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private AudioSource sonidoExplosion;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int ticksSinActualizar;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x765DE0", Offset = "0x765DE0", VA = "0x765DE0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x7660E8", Offset = "0x7660E8", VA = "0x7660E8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x7665C8", Offset = "0x7665C8", VA = "0x7665C8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x766670", Offset = "0x766670", VA = "0x766670")]
	private void RestablecerPorEventoMuerte()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x766360", Offset = "0x766360", VA = "0x766360")]
	private void UpdateAnimacionTarget()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x766220", Offset = "0x766220", VA = "0x766220")]
	private void UpdateMovimientoTarget()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x7668F8", Offset = "0x7668F8", VA = "0x7668F8")]
	public void Explotar(Vector3 direccionDisparo)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x766688", Offset = "0x766688", VA = "0x766688")]
	private void Restaurar()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x7669B8", Offset = "0x7669B8", VA = "0x7669B8")]
	public DisparadorTargets()
	{
	}
}
[Token(Token = "0x200005D")]
public class DisparaParaEmpezar : MonoBehaviour
{
	[Token(Token = "0x600019E")]
	[Address(RVA = "0x7669C0", Offset = "0x7669C0", VA = "0x7669C0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x766B34", Offset = "0x766B34", VA = "0x766B34")]
	public DisparaParaEmpezar()
	{
	}
}
[Token(Token = "0x200005E")]
public class encenderSegunCalidad : MonoBehaviour
{
	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ultra;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject alta;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject normal;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject baja;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject muyBaja;

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x766B3C", Offset = "0x766B3C", VA = "0x766B3C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x766B40", Offset = "0x766B40", VA = "0x766B40")]
	public void PonerMuzzleSegunCalidad()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x766BB4", Offset = "0x766BB4", VA = "0x766BB4")]
	public encenderSegunCalidad()
	{
	}
}
[Token(Token = "0x200005F")]
public class ControladorDisparoDron : MonoBehaviour
{
	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer m_renderer;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool explotado;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject explosion;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float velocidadDisparo;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rigidbody m_rigidbody;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TrailRenderer m_TrailRenderer;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioSource m_AudioSource;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 posInicial;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float tiempoEnElQueMeCrearon;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int ticks;

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x766BBC", Offset = "0x766BBC", VA = "0x766BBC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x766C6C", Offset = "0x766C6C", VA = "0x766C6C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x766DFC", Offset = "0x766DFC", VA = "0x766DFC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x766FE0", Offset = "0x766FE0", VA = "0x766FE0")]
	public ControladorDisparoDron()
	{
	}
}
[Token(Token = "0x2000060")]
public class ControladorDron : Enemigo
{
	[Token(Token = "0x2000061")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x4000226")]
		desconocido,
		[Token(Token = "0x4000227")]
		cerca,
		[Token(Token = "0x4000228")]
		lejos
	}

	[Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class <esperaParaComenzar>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControladorDron <>4__this;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform punto1;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform punto2;

		[Token(Token = "0x17000030")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x7687B8", Offset = "0x7687B8", VA = "0x7687B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x768800", Offset = "0x768800", VA = "0x768800", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x767614", Offset = "0x767614", VA = "0x767614")]
		[DebuggerHidden]
		public <esperaParaComenzar>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x7684A8", Offset = "0x7684A8", VA = "0x7684A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x7684AC", Offset = "0x7684AC", VA = "0x7684AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x7687C0", Offset = "0x7687C0", VA = "0x7687C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Movimiento Dron")]
	public Transform punto1;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform punto2;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool soyDeMenu;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform player;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float tMovimiento;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 posicionInicio;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 posicionFinal;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float velocidadMovimiento;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool unSoloPunto;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool puedoMoverme;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Space(2f)]
	[Header("Animacion Dron Mesh")]
	public Transform dronMesh;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform frontPart;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform backPart;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform eyePart;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AnimationCurve curvaAnimacion;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float velocidadAnimacionSubeyBaja;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float velocidadGiro;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float tAnimacion;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject disparoPrefab;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[Space(2f)]
	[Header("Destruccion Dron")]
	public GameObject dronDestruido;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject dronSinDestruir;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject efectoExplosion;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Rigidbody[] piezasDron;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Vector3[] posicionesPartes;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private WaitForSeconds esperaParaRestablecer;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Collider m_collider;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int ticksSinActualizar;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private AudioSource sonidoExplosion;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public int ticksSinDisparar;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public int cadaCuantoDisparo;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float distanciaParaDisparar;

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x766FE8", Offset = "0x766FE8", VA = "0x766FE8", Slot = "4")]
	public override void Explotar(Vector3 direccionDisparo)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x7673C8", Offset = "0x7673C8", VA = "0x7673C8", Slot = "5")]
	public override void Restaurar()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x767564", Offset = "0x767564", VA = "0x767564")]
	private void RestaurarDronPorEventoMuerte()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x767570", Offset = "0x767570", VA = "0x767570")]
	[IteratorStateMachine(typeof(<esperaParaComenzar>d__33))]
	private IEnumerator esperaParaComenzar(Transform punto1, Transform punto2)
	{
		return null;
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x76763C", Offset = "0x76763C", VA = "0x76763C")]
	public void ColocarDron(Transform punto1, Transform punto2)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x76765C", Offset = "0x76765C", VA = "0x76765C")]
	private void UpdateMovimientoDron()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x767760", Offset = "0x767760", VA = "0x767760")]
	private void UpdateAnimacionDron()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x7679A4", Offset = "0x7679A4", VA = "0x7679A4")]
	private void UpdateDisparo()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x767AB8", Offset = "0x767AB8", VA = "0x767AB8")]
	private void Disparar()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x767F30", Offset = "0x767F30", VA = "0x767F30")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x7680EC", Offset = "0x7680EC", VA = "0x7680EC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x76829C", Offset = "0x76829C", VA = "0x76829C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x768480", Offset = "0x768480", VA = "0x768480")]
	public ControladorDron()
	{
	}
}
[Token(Token = "0x2000063")]
public class ControladorGusano : MonoBehaviour
{
	[Token(Token = "0x2000064")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x4000245")]
		desconocido,
		[Token(Token = "0x4000246")]
		cerca,
		[Token(Token = "0x4000247")]
		lejos
	}

	[Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class <EfectoDesaparicion>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform parte;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 direccionDisparo;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 <escalaInicial>5__2;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <t>5__3;

		[Token(Token = "0x17000032")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x769D14", Offset = "0x769D14", VA = "0x769D14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x769D5C", Offset = "0x769D5C", VA = "0x769D5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x769730", Offset = "0x769730", VA = "0x769730")]
		[DebuggerHidden]
		public <EfectoDesaparicion>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x769944", Offset = "0x769944", VA = "0x769944", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x769948", Offset = "0x769948", VA = "0x769948", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x769D1C", Offset = "0x769D1C", VA = "0x769D1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] partes;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] disparos;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform disparosPadre;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int disparoAcutal;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float fuerzaDisparo;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float distanciaParaDisparar;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform puntoDisparo;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3[] escalaInicialPartes;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ParticleSystem particulasDisparo;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float coldDownRotacion;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float VelocidadLerpEscalaRotacion;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float velocidadMovimiento;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float distanciaEntreObjetos;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float maximaEscala;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform objetoQueSigo;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool muerto;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool escalaUniforme;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public int distanciaAlaQueTengoQueActivarme;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int ticksSinActualizar;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float momentoUltimoDisparo;

	[Token(Token = "0x4000243")]
	private const float coldownDisparo = 0.3f;

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x768808", Offset = "0x768808", VA = "0x768808")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x768984", Offset = "0x768984", VA = "0x768984")]
	private void Disparar()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x768B90", Offset = "0x768B90", VA = "0x768B90")]
	private void Update()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x7694E4", Offset = "0x7694E4", VA = "0x7694E4")]
	public void PerderParte(int indexParte, Vector3 direccionDisparo)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x769698", Offset = "0x769698", VA = "0x769698")]
	[IteratorStateMachine(typeof(<EfectoDesaparicion>d__27))]
	private IEnumerator EfectoDesaparicion(Transform parte, Vector3 direccionDisparo)
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x769758", Offset = "0x769758", VA = "0x769758")]
	private void Restablecer()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x76991C", Offset = "0x76991C", VA = "0x76991C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x769920", Offset = "0x769920", VA = "0x769920")]
	public ControladorGusano()
	{
	}
}
[Token(Token = "0x2000066")]
public class ControladorMina : Enemigo
{
	[Token(Token = "0x2000067")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x400026D")]
		desconocido,
		[Token(Token = "0x400026E")]
		cerca,
		[Token(Token = "0x400026F")]
		lejos
	}

	[Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class <EsfectoDisparoEnEscudo>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControladorMina <>4__this;

		[Token(Token = "0x17000034")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x76B0DC", Offset = "0x76B0DC", VA = "0x76B0DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x76B124", Offset = "0x76B124", VA = "0x76B124", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x76A518", Offset = "0x76A518", VA = "0x76A518")]
		[DebuggerHidden]
		public <EsfectoDisparoEnEscudo>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x76AE94", Offset = "0x76AE94", VA = "0x76AE94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x76AE98", Offset = "0x76AE98", VA = "0x76AE98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x76B0E4", Offset = "0x76B0E4", VA = "0x76B0E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float velocidadMovimiento;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float velocidadRotacion;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float distanciaActivacion;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space(5f)]
	public GameObject ojoFeliz;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject ojoEnfadado;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject luzBlanca;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject luzRoja;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject explosion;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject disparoPrefab;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform direccionDisparos1;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform direccionDisparos2;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject body;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Collider m_collider;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Animator m_Animator;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool conObjetivo;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform objetivo;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 posicionInicial;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int ticksSinActualizar;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private AudioSource sonidoImpactoEscudo;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float tEfectoEscudo;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float vidaEscudo;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Color colorBaseGrietas;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Material materialEscudo;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject escudo;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public AnimationCurve curvaAnimacionEscudo;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Coroutine corutineEfectoDisparoEnEscudo;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Vector3 vectorHaciaElJugador;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private RaycastHit hit;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private int ticks;

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x769D64", Offset = "0x769D64", VA = "0x769D64")]
	private void CambiarEstadoMina(bool conObjetivo)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x769E24", Offset = "0x769E24", VA = "0x769E24", Slot = "4")]
	public override void Explotar(Vector3 direccionDisparo)
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x76A320", Offset = "0x76A320", VA = "0x76A320", Slot = "5")]
	public override void Restaurar()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x76A2B8", Offset = "0x76A2B8", VA = "0x76A2B8")]
	private void RecibirDisparoEnEscudo()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x76A4A4", Offset = "0x76A4A4", VA = "0x76A4A4")]
	[IteratorStateMachine(typeof(<EsfectoDisparoEnEscudo>d__32))]
	private IEnumerator EsfectoDisparoEnEscudo()
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x76A540", Offset = "0x76A540", VA = "0x76A540")]
	private void RestaurarDronPorEventoMuerte()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x76A54C", Offset = "0x76A54C", VA = "0x76A54C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x76A564", Offset = "0x76A564", VA = "0x76A564")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x76A734", Offset = "0x76A734", VA = "0x76A734")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x76AE48", Offset = "0x76AE48", VA = "0x76AE48")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x76AE78", Offset = "0x76AE78", VA = "0x76AE78")]
	public ControladorMina()
	{
	}
}
[Token(Token = "0x2000069")]
public class ControladorMortero : Enemigo
{
	[Token(Token = "0x200006A")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x4000288")]
		desconocido,
		[Token(Token = "0x4000289")]
		cerca,
		[Token(Token = "0x400028A")]
		lejos
	}

	[Token(Token = "0x4000273")]
	private const float tiempoEntreDisparos = 1f;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject morteroSinRomper;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Rigidbody[] partesRotas;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform puntoDisparo;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject disparoPrefab;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject escudo;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject baseMortero;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform rotador;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform rotadorFalso;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject explosion;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private AudioSource sonidoExplosion;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Collider m_collider;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Transform target;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Animator m_Animator;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private WaitForSeconds esperaParaRestablecer;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float fuerzaDisparo;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float ultimaVezQueDispare;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int ticksSinActualizar;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 offsetDelTarget;

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x76B12C", Offset = "0x76B12C", VA = "0x76B12C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x76B29C", Offset = "0x76B29C", VA = "0x76B29C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x76B6AC", Offset = "0x76B6AC", VA = "0x76B6AC")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x76B6C4", Offset = "0x76B6C4", VA = "0x76B6C4")]
	public void Disparar()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x76B8A4", Offset = "0x76B8A4", VA = "0x76B8A4", Slot = "4")]
	public override void Explotar(Vector3 direccionDisparo)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x76B9C4", Offset = "0x76B9C4", VA = "0x76B9C4", Slot = "5")]
	public override void Restaurar()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x76BA84", Offset = "0x76BA84", VA = "0x76BA84")]
	public ControladorMortero()
	{
	}
}
[Token(Token = "0x200006B")]
public class ControladorOjoAsesino : MonoBehaviour
{
	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float velocidadGiroMinima;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float velocidadGiroMaxima;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform tOjo;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform tParticulas;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 aux;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve anim;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float t;

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x76BAFC", Offset = "0x76BAFC", VA = "0x76BAFC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x76BD64", Offset = "0x76BD64", VA = "0x76BD64")]
	public ControladorOjoAsesino()
	{
	}
}
[Token(Token = "0x200006C")]
public class ControladorTorreta : Enemigo
{
	[Token(Token = "0x200006D")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x40002BC")]
		desconocido,
		[Token(Token = "0x40002BD")]
		cerca,
		[Token(Token = "0x40002BE")]
		lejos
	}

	[Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class <CorutineDisparo>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControladorTorreta <>4__this;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x76D190", Offset = "0x76D190", VA = "0x76D190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x76D1D8", Offset = "0x76D1D8", VA = "0x76D1D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x76C85C", Offset = "0x76C85C", VA = "0x76C85C")]
		[DebuggerHidden]
		public <CorutineDisparo>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x76D048", Offset = "0x76D048", VA = "0x76D048", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x76D04C", Offset = "0x76D04C", VA = "0x76D04C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x76D198", Offset = "0x76D198", VA = "0x76D198", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class <RetardoParaDesactivarEscudo>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControladorTorreta <>4__this;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x76D250", Offset = "0x76D250", VA = "0x76D250", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x76D298", Offset = "0x76D298", VA = "0x76D298", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x76C9A8", Offset = "0x76C9A8", VA = "0x76C9A8")]
		[DebuggerHidden]
		public <RetardoParaDesactivarEscudo>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x76D1E0", Offset = "0x76D1E0", VA = "0x76D1E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x76D1E4", Offset = "0x76D1E4", VA = "0x76D1E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x76D258", Offset = "0x76D258", VA = "0x76D258", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class <EsfectoDisparoEnEscudo>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ControladorTorreta <>4__this;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x76D4E0", Offset = "0x76D4E0", VA = "0x76D4E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x76D528", Offset = "0x76D528", VA = "0x76D528", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x76D000", Offset = "0x76D000", VA = "0x76D000")]
		[DebuggerHidden]
		public <EsfectoDisparoEnEscudo>d__54(int <>1__state)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x76D2A0", Offset = "0x76D2A0", VA = "0x76D2A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x76D2A4", Offset = "0x76D2A4", VA = "0x76D2A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x76D4E8", Offset = "0x76D4E8", VA = "0x76D4E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000292")]
	private const float rotacionMaxima = 45f;

	[Token(Token = "0x4000293")]
	private const float rotacionMinima = -45f;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform rotadorFalso;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float velocidadGiro;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform ejeRotacion;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform puntoDisparo;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject disparoPrefab;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Animator m_Animator;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int disparosPorRafaga;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Rigidbody[] partesRotas;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject[] partesSinRomper;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject escudo;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject explosion;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Material materialEscudo;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float cadaCuantosGradosDisparo;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float gradosEnLosQueDisparo;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool puedoDisparar;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float rotacionInicial;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float rotacionFinal;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float t;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3 vectorAux;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool puedoMoverme;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
	private bool escondido;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Collider m_collider;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private AudioSource m_audioSource;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private AudioSource sonidoExplosion;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private AudioSource sonidoImpactoEscudo;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool primerTick;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private WaitForSeconds esperaParaRestablecer;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private WaitForSeconds esperaMientrasDisparo;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private WaitForSeconds esperaEntreRafagas;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject impactoNoletal;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private int ticksSinActualizar;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private WaitForSeconds esperaParaDesactivarEscudo;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Coroutine corutineEfectoDisparoEnEscudo;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public AnimationCurve curvaAnimacionEscudo;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private float tEfectoEscudo;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private float vidaEscudo;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Color colorBaseGrietas;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public ParticleSystem particulasEscudoRoto;

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x76BD6C", Offset = "0x76BD6C", VA = "0x76BD6C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x76BFD0", Offset = "0x76BFD0", VA = "0x76BFD0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x76C184", Offset = "0x76C184", VA = "0x76C184")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x76C7E8", Offset = "0x76C7E8", VA = "0x76C7E8")]
	[IteratorStateMachine(typeof(<CorutineDisparo>d__38))]
	private IEnumerator CorutineDisparo()
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x76C884", Offset = "0x76C884", VA = "0x76C884")]
	public void Iniciar()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x76C934", Offset = "0x76C934", VA = "0x76C934")]
	[IteratorStateMachine(typeof(<RetardoParaDesactivarEscudo>d__41))]
	private IEnumerator RetardoParaDesactivarEscudo()
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x76C9D0", Offset = "0x76C9D0", VA = "0x76C9D0")]
	private void Disparar()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x76CB34", Offset = "0x76CB34", VA = "0x76CB34")]
	public void PuedoMoverme(int puedo)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x76CB44", Offset = "0x76CB44", VA = "0x76CB44", Slot = "4")]
	public override void Explotar(Vector3 direccionDisparo)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x76CE08", Offset = "0x76CE08", VA = "0x76CE08", Slot = "5")]
	public override void Restaurar()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x76CF80", Offset = "0x76CF80", VA = "0x76CF80")]
	private void RestaurarDronPorEventoMuerte()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x76CD74", Offset = "0x76CD74", VA = "0x76CD74")]
	private void RecibirDisparoEnEscudo()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x76CF8C", Offset = "0x76CF8C", VA = "0x76CF8C")]
	[IteratorStateMachine(typeof(<EsfectoDisparoEnEscudo>d__54))]
	private IEnumerator EsfectoDisparoEnEscudo()
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x76D028", Offset = "0x76D028", VA = "0x76D028")]
	public ControladorTorreta()
	{
	}
}
[Token(Token = "0x2000071")]
public abstract class Enemigo : MonoBehaviour
{
	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool muerto;

	[Token(Token = "0x6000202")]
	public abstract void Explotar(Vector3 direccionDisparo);

	[Token(Token = "0x6000203")]
	public abstract void Restaurar();

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x7684A0", Offset = "0x7684A0", VA = "0x7684A0")]
	protected Enemigo()
	{
	}
}
[Token(Token = "0x2000072")]
public class AccionesJugador : MonoBehaviour
{
	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AccionesJugador instance;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float triggerDerecho;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float triggerIzquierdo;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 stickDerecho;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 stickIzquierdo;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool recolocar;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool pause;

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x76D530", Offset = "0x76D530", VA = "0x76D530")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x76D588", Offset = "0x76D588", VA = "0x76D588")]
	public AccionesJugador()
	{
	}
}
[Token(Token = "0x2000073")]
public class Debugs : MonoBehaviour
{
	[Token(Token = "0x40002D0")]
	public const bool logs = false;

	[Token(Token = "0x40002D1")]
	public const bool calidadBajaForzada = false;

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x76D590", Offset = "0x76D590", VA = "0x76D590")]
	public Debugs()
	{
	}
}
[Token(Token = "0x2000074")]
public abstract class PlayerGenerico : MonoBehaviour
{
	[Token(Token = "0x2000075")]
	public enum TipoVibracion
	{
		[Token(Token = "0x40002D5")]
		disparo,
		[Token(Token = "0x40002D6")]
		muerte,
		[Token(Token = "0x40002D7")]
		recalentado
	}

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform manoDerecha;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform manoIzquierda;

	[Token(Token = "0x6000208")]
	public abstract void Vibra(XRNode manoQueVibra, TipoVibracion tipoVibracion);

	[Token(Token = "0x6000209")]
	public abstract void PonerOffsetArmas();

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x76D598", Offset = "0x76D598", VA = "0x76D598")]
	protected PlayerGenerico()
	{
	}
}
[Token(Token = "0x2000076")]
public class PlayerVR : MonoBehaviour
{
	[Token(Token = "0x2000077")]
	public enum estadosDelJuego
	{
		[Token(Token = "0x4000325")]
		enMenu,
		[Token(Token = "0x4000326")]
		jugando,
		[Token(Token = "0x4000327")]
		muerto,
		[Token(Token = "0x4000328")]
		finDeNivel,
		[Token(Token = "0x4000329")]
		pausa
	}

	[Token(Token = "0x2000078")]
	public enum ControDelJuego
	{
		[Token(Token = "0x400032B")]
		cabezaPosicion,
		[Token(Token = "0x400032C")]
		teclasOMando,
		[Token(Token = "0x400032D")]
		cabezaInclinacion,
		[Token(Token = "0x400032E")]
		rudder3D
	}

	[Token(Token = "0x2000079")]
	public enum TipoVibracion
	{
		[Token(Token = "0x4000330")]
		disparo,
		[Token(Token = "0x4000331")]
		muerte,
		[Token(Token = "0x4000332")]
		recalentado
	}

	[Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class <Activar90fps>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x770524", Offset = "0x770524", VA = "0x770524", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x77056C", Offset = "0x77056C", VA = "0x77056C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x76D6B0", Offset = "0x76D6B0", VA = "0x76D6B0")]
		[DebuggerHidden]
		public <Activar90fps>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x7704C4", Offset = "0x7704C4", VA = "0x7704C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x7704C8", Offset = "0x7704C8", VA = "0x7704C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x77052C", Offset = "0x77052C", VA = "0x77052C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class <AnimacionFade>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool activarPantallaNegra;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PlayerVR <>4__this;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <t>5__2;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x7707B0", Offset = "0x7707B0", VA = "0x7707B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x7707F8", Offset = "0x7707F8", VA = "0x7707F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x76E9F4", Offset = "0x76E9F4", VA = "0x76E9F4")]
		[DebuggerHidden]
		public <AnimacionFade>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x770574", Offset = "0x770574", VA = "0x770574", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x770578", Offset = "0x770578", VA = "0x770578", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x7707B8", Offset = "0x7707B8", VA = "0x7707B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class <EfectoMorir>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerVR <>4__this;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <t>5__2;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <volumenInicial>5__3;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private VolumeParameter<float> <saturation>5__4;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x770D28", Offset = "0x770D28", VA = "0x770D28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x770D70", Offset = "0x770D70", VA = "0x770D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x76F664", Offset = "0x76F664", VA = "0x76F664")]
		[DebuggerHidden]
		public <EfectoMorir>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x770800", Offset = "0x770800", VA = "0x770800", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x770804", Offset = "0x770804", VA = "0x770804", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x770D30", Offset = "0x770D30", VA = "0x770D30", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class <VibracionParaImpulsos>d__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TipoVibracion tipo;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEngine.XR.InputDevice device;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PlayerVR <>4__this;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float potencia;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float duracion;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <t>5__2;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int <i>5__3;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaitForSecondsRealtime <esperaEntreVibraciones>5__4;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float <duracionDeCadaImpulso>5__5;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float <esperaEntreImpulsos>5__6;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int <cadaCuantosVibro>5__7;

		[Token(Token = "0x17000042")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x770F04", Offset = "0x770F04", VA = "0x770F04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x770F4C", Offset = "0x770F4C", VA = "0x770F4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x76FD54", Offset = "0x76FD54", VA = "0x76FD54")]
		[DebuggerHidden]
		public <VibracionParaImpulsos>d__95(int <>1__state)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x770D78", Offset = "0x770D78", VA = "0x770D78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x770D7C", Offset = "0x770D7C", VA = "0x770D7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x770F0C", Offset = "0x770F0C", VA = "0x770F0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class <CorutineFinDeNivel>d__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerVR <>4__this;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <nivelDesbloqueado>5__2;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <t>5__3;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <volumenInicial>5__4;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 <posicionInicial>5__5;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 <posicionFinal>5__6;

		[Token(Token = "0x17000044")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x7713B4", Offset = "0x7713B4", VA = "0x7713B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x7713FC", Offset = "0x7713FC", VA = "0x7713FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x76FDF0", Offset = "0x76FDF0", VA = "0x76FDF0")]
		[DebuggerHidden]
		public <CorutineFinDeNivel>d__99(int <>1__state)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x770F54", Offset = "0x770F54", VA = "0x770F54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x770F58", Offset = "0x770F58", VA = "0x770F58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x7713BC", Offset = "0x7713BC", VA = "0x7713BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int reiniciosHechosSinRecargarEscena;

	[Token(Token = "0x40002D9")]
	[Header("Debugs")]
	public const int cantidadMaximaNiveles = 30;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool inmortal;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool debugsActivos;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject inmortalFace;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool modoLab;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool sinMovimiento;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool sinVR;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(10f)]
	public Material[] skyboxesDelNivel;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material materialParedes;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material materialSuelo;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color[] colorPrincipalDelNivel;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Color[] colorReflejoDelNivel;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioSource viento;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform posicionDeseadaCabeza;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PlayerVR instance;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform cabeza;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform manoDerecha;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform manoIzquierda;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ManagerTramos managerTramos;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private ControladorSinDisco controladorMovimiento;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool rudderConectado;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Transform tDisco;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject particulasVelocidad;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Vector3 velocidadJugador;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public SpectrumFilter sp;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public int nivelActual;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public int siguienteNivelACompletar;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float tiempoPasadoEnSlowMotion;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public PlayerGenerico playerActual;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float segundosParaCheckPoint;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private AudioSource audioSourceVozGameOver;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public float pisandoFlechasLaterales;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public float pisandoFlechasVelocidad;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public int ticksSinPisarFlechasLaterales;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public int ticksSinPisarFlechasVelocidad;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float sensibilidadMovimiento;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public bool dosArmas;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public ControDelJuego controlDelJuego;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public int numBloquesSinPonerUnExclusivoDelNivel;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Transform[] barrasDeReferencia;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[HideInInspector]
	public UnityEvent eventoRestaurar;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public UnityEvent eventoPartidaFinalizada;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public int numeroDeTramosSeguidosSinTapar;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Material materialEfectoMuerte;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Material materialPiezaRota;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public string modeloHMD;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private LayerMask mascaraCamaraPause;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private LayerMask mascaraCamaraJugando;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Camera camaraPlayer;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public CanvasGroup fadeCanvas;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Camera camaraFade;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public estadosDelJuego estadoActual;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public TextMesh deviceTM;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public Vector3 velocidadManoDerecha;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private Vector3 posAnteriorManoDerecha;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public float velocidadExtraPorDisparo;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public GameObject fpsCounter;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public CurvedWorldController curvedWorldController;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public bool tramoVacioColocado;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public AudioSource audioSourceMusica;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public Volume profileEfectos;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public bool comodin;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	public int numBloquesColocadosSinCheckPoint;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public TramosInicialFinal tramoInicial;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private byte[] bufferDisparo;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private byte[] bufferMuerte;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private byte[] bufferRecalentamiento;

	[Token(Token = "0x400031C")]
	private const byte potenciaVibracionDisparoRecalientamiento = byte.MaxValue;

	[Token(Token = "0x400031D")]
	private const byte potenciaVibracionMuerte = 180;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private uint channel;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private Coroutine vibrando;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private Coroutine corFinDeNivel;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public bool puedoInterrumpirCelebracion;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	private float timeEscaleAnterior;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public GameObject textoPause;

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x76D5A0", Offset = "0x76D5A0", VA = "0x76D5A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x76D650", Offset = "0x76D650", VA = "0x76D650")]
	[IteratorStateMachine(typeof(<Activar90fps>d__56))]
	public IEnumerator Activar90fps()
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x76D6D8", Offset = "0x76D6D8", VA = "0x76D6D8")]
	private void DisplayRefreshRateChanged(float fromRefreshRate, float ToRefreshRate)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x76D7B4", Offset = "0x76D7B4", VA = "0x76D7B4")]
	private void Start()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x76DDE0", Offset = "0x76DDE0", VA = "0x76DDE0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x76DE80", Offset = "0x76DE80", VA = "0x76DE80")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x76E3A0", Offset = "0x76E3A0", VA = "0x76E3A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x76DD58", Offset = "0x76DD58", VA = "0x76DD58")]
	[IteratorStateMachine(typeof(<AnimacionFade>d__68))]
	public IEnumerator AnimacionFade(bool activarPantallaNegra)
	{
		return null;
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x766A4C", Offset = "0x766A4C", VA = "0x766A4C")]
	public void Empezar()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x76EB2C", Offset = "0x76EB2C", VA = "0x76EB2C")]
	private void RecolocarParticulasDisco()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x76ECFC", Offset = "0x76ECFC", VA = "0x76ECFC")]
	private void RecolocarCamara(bool rotar)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x76E9CC", Offset = "0x76E9CC", VA = "0x76E9CC")]
	public void RecolocarPlayer()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x76F08C", Offset = "0x76F08C", VA = "0x76F08C")]
	private void ReiniciarPartida(bool interrumpieronCelebracion = false)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x76F5F0", Offset = "0x76F5F0", VA = "0x76F5F0")]
	[IteratorStateMachine(typeof(<EfectoMorir>d__80))]
	private IEnumerator EfectoMorir()
	{
		return null;
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x76E29C", Offset = "0x76E29C", VA = "0x76E29C")]
	public void Morir()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x76F68C", Offset = "0x76F68C", VA = "0x76F68C")]
	public void CambiarEstadoDeArmas(bool dosArmas, bool derecha = true)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x76F8F0", Offset = "0x76F8F0", VA = "0x76F8F0")]
	public void personalizarSueloYParedSegunNivel()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x76EAA0", Offset = "0x76EAA0", VA = "0x76EAA0")]
	public void personalizarEscenarioSegunNivel()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x76DBD4", Offset = "0x76DBD4", VA = "0x76DBD4")]
	private void InicializarVibracion()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x76FA4C", Offset = "0x76FA4C", VA = "0x76FA4C")]
	public void Vibra(XRNode manoQueVibra, TipoVibracion tipoVibracion)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x76FCA8", Offset = "0x76FCA8", VA = "0x76FCA8")]
	[IteratorStateMachine(typeof(<VibracionParaImpulsos>d__95))]
	private IEnumerator VibracionParaImpulsos(float duracion, float potencia, UnityEngine.XR.InputDevice device, TipoVibracion tipo)
	{
		return null;
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x76E114", Offset = "0x76E114", VA = "0x76E114")]
	private void NivelCompletado()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x76FD7C", Offset = "0x76FD7C", VA = "0x76FD7C")]
	[IteratorStateMachine(typeof(<CorutineFinDeNivel>d__99))]
	private IEnumerator CorutineFinDeNivel()
	{
		return null;
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x76FE18", Offset = "0x76FE18", VA = "0x76FE18")]
	public void InterrumpirFinDeNivel()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x76FE48", Offset = "0x76FE48", VA = "0x76FE48")]
	private void FinDeCelebracion(float volumenInicial, bool animacionInterrumpida)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x76E89C", Offset = "0x76E89C", VA = "0x76E89C")]
	private void UpdatePause()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x770090", Offset = "0x770090", VA = "0x770090")]
	public void QuitarPistolas(bool quitar)
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x76FECC", Offset = "0x76FECC", VA = "0x76FECC")]
	public void ActivarDesactivarPause()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x77017C", Offset = "0x77017C", VA = "0x77017C")]
	private void BloquearJuegoEnUsusarioIncorrecto(bool incorrecto, string usuario)
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x7704A0", Offset = "0x7704A0", VA = "0x7704A0")]
	public PlayerVR()
	{
	}
}
[Token(Token = "0x200007F")]
public class MonedaMultiplicador : MonoBehaviour
{
	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMesh cantidadPuntos;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 vectorAux;

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x771404", Offset = "0x771404", VA = "0x771404")]
	private void Start()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x7714FC", Offset = "0x7714FC", VA = "0x7714FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x77158C", Offset = "0x77158C", VA = "0x77158C")]
	public MonedaMultiplicador()
	{
	}
}
[Token(Token = "0x2000080")]
public class interruptorDisparableParaPuerta : MonoBehaviour
{
	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool verde;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public sorteraPulsadorQueMeAbre quienEsMiPuertaSorteadora;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioSource miAudio;

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x771594", Offset = "0x771594", VA = "0x771594")]
	private void Start()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x771668", Offset = "0x771668", VA = "0x771668")]
	public void reproduceSonidoActivacion()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x771684", Offset = "0x771684", VA = "0x771684")]
	public interruptorDisparableParaPuerta()
	{
	}
}
[Token(Token = "0x2000081")]
public class LanguageManager
{
	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LanguageManager sharedinstance;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<string> idiomas;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, string> Idioma;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string idiomaActual;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityEvent eventoCambioIdioma;

	[Token(Token = "0x17000046")]
	public static LanguageManager instance
	{
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x77168C", Offset = "0x77168C", VA = "0x77168C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x771718", Offset = "0x771718", VA = "0x771718")]
	public LanguageManager()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x771F70", Offset = "0x771F70", VA = "0x771F70")]
	private void CargarIdioma(string idiomaActual)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x772320", Offset = "0x772320", VA = "0x772320")]
	public string DameTexto(string key)
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x772424", Offset = "0x772424", VA = "0x772424")]
	public void CambiarIdioma()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x771EC4", Offset = "0x771EC4", VA = "0x771EC4")]
	private bool ComprobarSiExisteIdioma(string idioma)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000082")]
public class lanzarCubosTrampa : MonoBehaviour
{
	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LayerMask mascaraPlayer;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer cable1;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer cable2;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MeshRenderer cable3;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject cubo1;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject cubo2;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource sondio;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material materialSeleccionado;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material materialApagado;

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x772510", Offset = "0x772510", VA = "0x772510")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x7726CC", Offset = "0x7726CC", VA = "0x7726CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x7728C0", Offset = "0x7728C0", VA = "0x7728C0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x772784", Offset = "0x772784", VA = "0x772784")]
	private void RefrescarNivel()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x7728C4", Offset = "0x7728C4", VA = "0x7728C4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x772B38", Offset = "0x772B38", VA = "0x772B38")]
	public lanzarCubosTrampa()
	{
	}
}
[Token(Token = "0x2000083")]
public abstract class LogrosRecords : MonoBehaviour
{
	[Token(Token = "0x2000084")]
	public struct Resultado
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string usuario;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int record;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int posicion;
	}

	[Token(Token = "0x2000085")]
	public enum OrdenTabla
	{
		[Token(Token = "0x4000370")]
		ascendente,
		[Token(Token = "0x4000371")]
		descendente,
		[Token(Token = "0x4000372")]
		ninguno
	}

	[Token(Token = "0x2000086")]
	public struct InfoTabla
	{
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string nombre;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public OrdenTabla orden;
	}

	[Token(Token = "0x2000087")]
	public delegate void IGSMTablaEncontradaEventHandler(object sender, string tabla);

	[Token(Token = "0x2000088")]
	public delegate void IGSMResultadosEventHandler(object sender, List<Resultado> resultados, bool dosListados, string tabla);

	[Token(Token = "0x2000089")]
	public delegate void IGSMResultadoSubidoEventHandler(object sender, int miMejorResultado, string tabla);

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static LogrosRecords instance;

	[Token(Token = "0x14000001")]
	public event IGSMResultadosEventHandler ResultadosObtenidos
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x772B98", Offset = "0x772B98", VA = "0x772B98")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x772C34", Offset = "0x772C34", VA = "0x772C34")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event IGSMTablaEncontradaEventHandler TablaEncontrada
	{
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x772CD0", Offset = "0x772CD0", VA = "0x772CD0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x772D6C", Offset = "0x772D6C", VA = "0x772D6C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event IGSMResultadoSubidoEventHandler RecordSubido
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x772E08", Offset = "0x772E08", VA = "0x772E08")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x772EA4", Offset = "0x772EA4", VA = "0x772EA4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x772B40", Offset = "0x772B40", VA = "0x772B40")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x772F40", Offset = "0x772F40", VA = "0x772F40", Slot = "4")]
	protected virtual void OnResultadosObtenidos(object sender, List<Resultado> resultados, bool dosListados, string tabla)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x772F64", Offset = "0x772F64", VA = "0x772F64", Slot = "5")]
	protected virtual void OnTablaEncontrada(object sender, string tabla)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x772F84", Offset = "0x772F84", VA = "0x772F84", Slot = "6")]
	protected virtual void OnRecordSubido(object sender, int miMejorResultado, string tabla)
	{
	}

	[Token(Token = "0x6000263")]
	public abstract void GuardarLogros();

	[Token(Token = "0x6000264")]
	public abstract void InicializarLogros();

	[Token(Token = "0x6000265")]
	public abstract void InicializarTablas(string[] tablas);

	[Token(Token = "0x6000266")]
	public abstract void InicializarTablas(List<InfoTabla> tablas);

	[Token(Token = "0x6000267")]
	public abstract void ObtenerResultadosAlrededorMioConTop(string tabla, int resultadosQueQuiero);

	[Token(Token = "0x6000268")]
	public abstract void SubirRecord(string tabla, int record);

	[Token(Token = "0x6000269")]
	public abstract void MarcarLogroCompletado(string idLogro);

	[Token(Token = "0x600026A")]
	public abstract string DameMiNombre();

	[Token(Token = "0x600026B")]
	public abstract void MostrarTienda();

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x772FA4", Offset = "0x772FA4", VA = "0x772FA4")]
	protected LogrosRecords()
	{
	}
}
[Token(Token = "0x200008A")]
public class IGSteamManager : LogrosRecords
{
	[Token(Token = "0x6000279")]
	[Address(RVA = "0x7734B4", Offset = "0x7734B4", VA = "0x7734B4", Slot = "14")]
	public override string DameMiNombre()
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x7734F4", Offset = "0x7734F4", VA = "0x7734F4", Slot = "7")]
	public override void GuardarLogros()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x773534", Offset = "0x773534", VA = "0x773534", Slot = "8")]
	public override void InicializarLogros()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x773574", Offset = "0x773574", VA = "0x773574", Slot = "9")]
	public override void InicializarTablas(string[] tablas)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x7735B4", Offset = "0x7735B4", VA = "0x7735B4", Slot = "10")]
	public override void InicializarTablas(List<InfoTabla> tablas)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x7735F4", Offset = "0x7735F4", VA = "0x7735F4", Slot = "13")]
	public override void MarcarLogroCompletado(string idLogro)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x773634", Offset = "0x773634", VA = "0x773634", Slot = "15")]
	public override void MostrarTienda()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x773674", Offset = "0x773674", VA = "0x773674", Slot = "11")]
	public override void ObtenerResultadosAlrededorMioConTop(string tabla, int resultadosQueQuiero)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x7736B4", Offset = "0x7736B4", VA = "0x7736B4", Slot = "12")]
	public override void SubirRecord(string tabla, int record)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x7736F4", Offset = "0x7736F4", VA = "0x7736F4")]
	public IGSteamManager()
	{
	}
}
[Token(Token = "0x200008B")]
public class ManagerLeaderboard : MonoBehaviour
{
	[Token(Token = "0x200008C")]
	public struct PlayerLeaderboard
	{
		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int posicion;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string nombre;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int score;
	}

	[Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class <Start>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ManagerLeaderboard <>4__this;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x775D94", Offset = "0x775D94", VA = "0x775D94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x775DDC", Offset = "0x775DDC", VA = "0x775DDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x773AEC", Offset = "0x773AEC", VA = "0x773AEC")]
		[DebuggerHidden]
		public <Start>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x775960", Offset = "0x775960", VA = "0x775960", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x775964", Offset = "0x775964", VA = "0x775964", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x775D9C", Offset = "0x775D9C", VA = "0x775D9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TablaLeaderboard leaderboardMenu;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool primeraTablaCargada;

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x7736FC", Offset = "0x7736FC", VA = "0x7736FC")]
	public void PonerTablaCargando()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x77389C", Offset = "0x77389C", VA = "0x77389C")]
	public void PonerTablaConectionError()
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x773900", Offset = "0x773900", VA = "0x773900")]
	public void CargarTabla(int level)
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x773A78", Offset = "0x773A78", VA = "0x773A78")]
	[IteratorStateMachine(typeof(<Start>d__5))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x773B14", Offset = "0x773B14", VA = "0x773B14")]
	private void OnRecordSubido(object sender, int miScoreRecibido, string tabla)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x773C2C", Offset = "0x773C2C", VA = "0x773C2C")]
	private bool ValidarListaResultados(List<LogrosRecords.Resultado> resultados)
	{
		return default(bool);
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x773E6C", Offset = "0x773E6C", VA = "0x773E6C")]
	private void OnResultadosObtenidos(object sender, List<LogrosRecords.Resultado> resultados, bool dosListas, string tabla)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x775958", Offset = "0x775958", VA = "0x775958")]
	public ManagerLeaderboard()
	{
	}
}
[Token(Token = "0x200008E")]
public class TablaLeaderboard : MonoBehaviour
{
	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] jugadores13primeros;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] jugadoresNo13primeros;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject loading;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject tablas;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject conectionError;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform seleccion;

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x775DE4", Offset = "0x775DE4", VA = "0x775DE4")]
	public TablaLeaderboard()
	{
	}
}
[Token(Token = "0x200008F")]
public class ManagerCalidad : MonoBehaviour
{
	[Token(Token = "0x2000090")]
	public enum Calidad
	{
		[Token(Token = "0x400038E")]
		muyBaja,
		[Token(Token = "0x400038F")]
		baja,
		[Token(Token = "0x4000390")]
		normal,
		[Token(Token = "0x4000391")]
		alta,
		[Token(Token = "0x4000392")]
		ultra
	}

	[Token(Token = "0x2000091")]
	public enum CalidadTV
	{
		[Token(Token = "0x4000394")]
		off,
		[Token(Token = "0x4000395")]
		on,
		[Token(Token = "0x4000396")]
		ultra
	}

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ManagerCalidad instance;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public encenderSegunCalidad muzzleDerecha;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public encenderSegunCalidad muzzleIzquierda;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject cameraTvOptimizada;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject cameraTvOff;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float multiplicadorDistanciaEnFuncionDeCalidad;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ReflectionProbe reflectionProbe;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Calidad calidad;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public CalidadTV calidadTV;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool forzarCambioDeCalidadAhora;

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x775DEC", Offset = "0x775DEC", VA = "0x775DEC")]
	public void AjustarCalidadDelJuegoSegunCalidadActual()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x775FF4", Offset = "0x775FF4", VA = "0x775FF4")]
	public void AjustarCalidadTVactual()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x775FF8", Offset = "0x775FF8", VA = "0x775FF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x77623C", Offset = "0x77623C", VA = "0x77623C")]
	public void ponerYGrabarEstaCalidadTV(CalidadTV nuevaCalidad)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x776240", Offset = "0x776240", VA = "0x776240")]
	public void ponerYGrabarEstaCalidad(Calidad nuevaCalidad)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x776244", Offset = "0x776244", VA = "0x776244")]
	private void Start()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x776248", Offset = "0x776248", VA = "0x776248")]
	private void Update()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x77625C", Offset = "0x77625C", VA = "0x77625C")]
	public ManagerCalidad()
	{
	}
}
[Token(Token = "0x2000092")]
public class ManagerSonidos : MonoBehaviour
{
	[Token(Token = "0x2000093")]
	public enum tiposSonido
	{
		[Token(Token = "0x40003AD")]
		explosion,
		[Token(Token = "0x40003AE")]
		puntos,
		[Token(Token = "0x40003AF")]
		muerte,
		[Token(Token = "0x40003B0")]
		disparoDron,
		[Token(Token = "0x40003B1")]
		nivelCompletado,
		[Token(Token = "0x40003B2")]
		escudoGolpeado,
		[Token(Token = "0x40003B3")]
		obstaculoGolpeado
	}

	[Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class <LerpVolumenIniciarMenu>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ManagerSonidos <>4__this;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <volumenMaximo>5__2;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x776674", Offset = "0x776674", VA = "0x776674", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x7766BC", Offset = "0x7766BC", VA = "0x7766BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x776344", Offset = "0x776344", VA = "0x776344")]
		[DebuggerHidden]
		public <LerpVolumenIniciarMenu>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x776410", Offset = "0x776410", VA = "0x776410", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x776414", Offset = "0x776414", VA = "0x776414", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x77667C", Offset = "0x77667C", VA = "0x77667C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class <LerpVolumenIniciarPartida>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ManagerSonidos <>4__this;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <volumenMaximo>5__2;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <indexMusicaActual>5__3;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x7769A4", Offset = "0x7769A4", VA = "0x7769A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x7769EC", Offset = "0x7769EC", VA = "0x7769EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x7763E0", Offset = "0x7763E0", VA = "0x7763E0")]
		[DebuggerHidden]
		public <LerpVolumenIniciarPartida>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x7766C4", Offset = "0x7766C4", VA = "0x7766C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x7766C8", Offset = "0x7766C8", VA = "0x7766C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x7769AC", Offset = "0x7769AC", VA = "0x7769AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ManagerSonidos instance;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip explosion;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip disparoDron;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip puntos;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioClip muerte;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioClip gameOver;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioClip escudoGolpeado;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioClip obstaculoGolpeado;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject audioPrefab;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioClip musicaMenu;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioClip[] musicas;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AudioSource audioSourceMusica;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float tiempoDeInicioDeLaMusica;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float tiempoQueDuraLaMusica;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float tiempoDelUltimoPuntoCogido;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int rachaPuntos;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float tVolumenMenu;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Coroutine corrutinaPonerMusica;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float tVolumenMusica;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int indexAudioSourceActual;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public int cantidadAudioSourcesPool;

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x776274", Offset = "0x776274", VA = "0x776274")]
	private void Awake()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x7762CC", Offset = "0x7762CC", VA = "0x7762CC")]
	private void Start()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x7762D0", Offset = "0x7762D0", VA = "0x7762D0")]
	[IteratorStateMachine(typeof(<LerpVolumenIniciarMenu>d__20))]
	private IEnumerator LerpVolumenIniciarMenu()
	{
		return null;
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x76F59C", Offset = "0x76F59C", VA = "0x76F59C")]
	public void PonMusicaMenu()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x77636C", Offset = "0x77636C", VA = "0x77636C")]
	[IteratorStateMachine(typeof(<LerpVolumenIniciarPartida>d__24))]
	private IEnumerator LerpVolumenIniciarPartida()
	{
		return null;
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x76EAD8", Offset = "0x76EAD8", VA = "0x76EAD8")]
	public void PonMusicaDeJuego()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x767180", Offset = "0x767180", VA = "0x767180")]
	public void SuenaAqui(Vector3 position, tiposSonido tipo)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x776408", Offset = "0x776408", VA = "0x776408")]
	public ManagerSonidos()
	{
	}
}
[Token(Token = "0x2000096")]
public class ManagerTramos : MonoBehaviour
{
	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform tramoInicialFinal;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform player;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Tramo tramoActual;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform tTramoActual;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Tramo tramoAnterior;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform tTramoAnterior;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Transform> tTramos;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int maximaCantidadTramos;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Tramo> tramos;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool tramoFinalPuesto;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float zMax;

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x7769F4", Offset = "0x7769F4", VA = "0x7769F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x76F1D8", Offset = "0x76F1D8", VA = "0x76F1D8")]
	public void ReiniciarTramos()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x76EA1C", Offset = "0x76EA1C", VA = "0x76EA1C")]
	public void InicializarTramos()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x776E1C", Offset = "0x776E1C", VA = "0x776E1C")]
	private void DimeTramoActual()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x776F4C", Offset = "0x776F4C", VA = "0x776F4C")]
	private void CambiarTramos()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x77748C", Offset = "0x77748C", VA = "0x77748C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x7775D4", Offset = "0x7775D4", VA = "0x7775D4")]
	public ManagerTramos()
	{
	}
}
[Token(Token = "0x2000097")]
public class Obstaculo : MonoBehaviour
{
	[Token(Token = "0x2000098")]
	public enum TipoTramo
	{
		[Token(Token = "0x40003D9")]
		Basico,
		[Token(Token = "0x40003DA")]
		Dianas,
		[Token(Token = "0x40003DB")]
		Martillos,
		[Token(Token = "0x40003DC")]
		GusanosBolasSimple,
		[Token(Token = "0x40003DD")]
		GusanosCuadrosSimple,
		[Token(Token = "0x40003DE")]
		GusanosBolasCabeza,
		[Token(Token = "0x40003DF")]
		GusanosCuadrosCabeza,
		[Token(Token = "0x40003E0")]
		FlechasVelocidad,
		[Token(Token = "0x40003E1")]
		FlechasLaterales,
		[Token(Token = "0x40003E2")]
		PuertasPulsaSuelo,
		[Token(Token = "0x40003E3")]
		PuertasPulsaTrampa,
		[Token(Token = "0x40003E4")]
		PuertasDianas,
		[Token(Token = "0x40003E5")]
		OjoGigante,
		[Token(Token = "0x40003E6")]
		Laser,
		[Token(Token = "0x40003E7")]
		SinGravedad
	}

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int dificultad;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool tengoDrones;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool tengoTorretas;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool enElEspacio;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	public bool techoObligatorio;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool paredObligatoria;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool sueloObligatorio;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool puedoTenerMorterosEnPared;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool tengoParedNormalDondeColocaraMorterosDerecha;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool tengoParedNormalDondeColocaraMorterosIzquierda;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] esferasBonusGO;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform[] posicionesDrones;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform[] posicionesTorretas;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool tapoLaVisionBastante;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public TipoTramo tipoTramo;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Tramo m_tramo;

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x7776C8", Offset = "0x7776C8", VA = "0x7776C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x7779C8", Offset = "0x7779C8", VA = "0x7779C8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x777D78", Offset = "0x777D78", VA = "0x777D78")]
	public void PonerEnemigosEnPosicion()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x778CA4", Offset = "0x778CA4", VA = "0x778CA4")]
	private void PonerTorretas()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x778F10", Offset = "0x778F10", VA = "0x778F10")]
	private void PonerTorretasPared()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x7780AC", Offset = "0x7780AC", VA = "0x7780AC")]
	private void PonerDrones()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x778460", Offset = "0x778460", VA = "0x778460")]
	private void PonerMorteros(bool enPared = false)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x778F18", Offset = "0x778F18", VA = "0x778F18")]
	private void PonerMinas()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x77915C", Offset = "0x77915C", VA = "0x77915C")]
	public Obstaculo()
	{
	}
}
[Token(Token = "0x2000099")]
public class ControladorObstaculos1 : MonoBehaviour
{
	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform cubo;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform piramide;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform cilindro;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform arco;

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x77916C", Offset = "0x77916C", VA = "0x77916C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x779750", Offset = "0x779750", VA = "0x779750")]
	public ControladorObstaculos1()
	{
	}
}
[Token(Token = "0x200009A")]
public class ControladorObstaculos2 : MonoBehaviour
{
	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve curvaAnimacion;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float velocidadAnimacion;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool disparando;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform cubo1;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform cubo2;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform cubo3;

	[Token(Token = "0x40003F2")]
	private const float xDerecha = 8.5f;

	[Token(Token = "0x40003F3")]
	private const float xIzquierda = -8.5f;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Level levelAEvaluar;

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x779758", Offset = "0x779758", VA = "0x779758")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x7797E0", Offset = "0x7797E0", VA = "0x7797E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x779A0C", Offset = "0x779A0C", VA = "0x779A0C")]
	public ControladorObstaculos2()
	{
	}
}
[Token(Token = "0x200009B")]
public class ControladorObstaculos27Fixed : MonoBehaviour
{
	[Token(Token = "0x200009C")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x40003FF")]
		desconocido,
		[Token(Token = "0x4000400")]
		cerca,
		[Token(Token = "0x4000401")]
		lejos
	}

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] fila;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float amplitud;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float frecuencia;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distancia;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int ticksSinActualizar;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float movimientoMinimo;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 posAux;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float t;

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x779A14", Offset = "0x779A14", VA = "0x779A14")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x779A1C", Offset = "0x779A1C", VA = "0x779A1C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x779C4C", Offset = "0x779C4C", VA = "0x779C4C")]
	public ControladorObstaculos27Fixed()
	{
	}
}
[Token(Token = "0x200009D")]
public class ControladorObstaculos3 : MonoBehaviour
{
	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve curvaAnimacion;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool disparando;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform cubo;

	[Token(Token = "0x4000405")]
	private const float xDerecha = 6.43f;

	[Token(Token = "0x4000406")]
	private const float xIzquierda = -6.43f;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Level[] levelsAEvaluar;

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x779C60", Offset = "0x779C60", VA = "0x779C60")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x779C64", Offset = "0x779C64", VA = "0x779C64")]
	private void Update()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x779C68", Offset = "0x779C68", VA = "0x779C68")]
	public ControladorObstaculos3()
	{
	}
}
[Token(Token = "0x200009E")]
public class ControladorObstaculos30 : MonoBehaviour
{
	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] esfera;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] posicionesOriginales;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Rigidbody[] esferaRb;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float velocidad;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool sinCambioEscala;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int ticksSinEmpujar;

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x779C70", Offset = "0x779C70", VA = "0x779C70")]
	private void ReiniciarTodo()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x779DCC", Offset = "0x779DCC", VA = "0x779DCC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x779DD0", Offset = "0x779DD0", VA = "0x779DD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x77A044", Offset = "0x77A044", VA = "0x77A044")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x77A220", Offset = "0x77A220", VA = "0x77A220")]
	public ControladorObstaculos30()
	{
	}
}
[Token(Token = "0x200009F")]
public class ControladorObstaculos8 : MonoBehaviour
{
	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] TAspas;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Level[] levelsAEvaluar;

	[Token(Token = "0x4000410")]
	private const float velocidadAlta = -80f;

	[Token(Token = "0x4000411")]
	private const float velocidadBaja = 80f;

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x77A228", Offset = "0x77A228", VA = "0x77A228")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x77A36C", Offset = "0x77A36C", VA = "0x77A36C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x77A4B4", Offset = "0x77A4B4", VA = "0x77A4B4")]
	public ControladorObstaculos8()
	{
	}
}
[Token(Token = "0x20000A0")]
public class ObstaculosConTarget : MonoBehaviour
{
	[Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class <esperaRandom>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObstaculosConTarget <>4__this;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int i;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x77A8DC", Offset = "0x77A8DC", VA = "0x77A8DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x77A924", Offset = "0x77A924", VA = "0x77A924", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x77A5CC", Offset = "0x77A5CC", VA = "0x77A5CC")]
		[DebuggerHidden]
		public <esperaRandom>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x77A79C", Offset = "0x77A79C", VA = "0x77A79C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x77A7A0", Offset = "0x77A7A0", VA = "0x77A7A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x77A8E4", Offset = "0x77A8E4", VA = "0x77A8E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] targets;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Animator> animators;

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x77A4BC", Offset = "0x77A4BC", VA = "0x77A4BC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x77A548", Offset = "0x77A548", VA = "0x77A548")]
	[IteratorStateMachine(typeof(<esperaRandom>d__3))]
	private IEnumerator esperaRandom(int i)
	{
		return null;
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x77A5F4", Offset = "0x77A5F4", VA = "0x77A5F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x77A714", Offset = "0x77A714", VA = "0x77A714")]
	public ObstaculosConTarget()
	{
	}
}
[Token(Token = "0x20000A2")]
public class PicoRecords : LogrosRecords
{
	[Token(Token = "0x20000A3")]
	private enum TipoOperacion
	{
		[Token(Token = "0x4000425")]
		obtenerResultados,
		[Token(Token = "0x4000426")]
		subirRecord
	}

	[Token(Token = "0x20000A4")]
	private struct Operacion
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TipoOperacion tipoOperacion;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string tablaSolicitada;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int numeroResultadosQueQuiero;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int record;
	}

	[Token(Token = "0x20000A5")]
	private enum TipoDatos
	{
		[Token(Token = "0x400042C")]
		top,
		[Token(Token = "0x400042D")]
		alrededorMio
	}

	[Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class <StartGame>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x77BEA4", Offset = "0x77BEA4", VA = "0x77BEA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x77BEEC", Offset = "0x77BEEC", VA = "0x77BEEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x77AA90", Offset = "0x77AA90", VA = "0x77AA90")]
		[DebuggerHidden]
		public <StartGame>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x77BDA4", Offset = "0x77BDA4", VA = "0x77BDA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x77BDA8", Offset = "0x77BDA8", VA = "0x77BDA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x77BEAC", Offset = "0x77BEAC", VA = "0x77BEAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class <SiguienteOperacionConPausa>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PicoRecords <>4__this;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x77BFA4", Offset = "0x77BFA4", VA = "0x77BFA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x77BFEC", Offset = "0x77BFEC", VA = "0x77BFEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x77B194", Offset = "0x77B194", VA = "0x77B194")]
		[DebuggerHidden]
		public <SiguienteOperacionConPausa>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x77BEF4", Offset = "0x77BEF4", VA = "0x77BEF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x77BEF8", Offset = "0x77BEF8", VA = "0x77BEF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x77BFAC", Offset = "0x77BFAC", VA = "0x77BFAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private TipoDatos tipoDatosActual;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool ejecutandoOperacion;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Operacion> operacionesPendientes;

	[Token(Token = "0x400041B")]
	private const int kFramesQueMeSalto = 30;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int framesQueLlevoSaltados;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int nResultadosQueQuiero;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string tablaSolicitada;

	[Token(Token = "0x400041F")]
	private const int kRangoResultados = 100;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<Resultado> resultadoActual;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string m_myID;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string m_myPicoID;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Resultado> resultadosTop;

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x77A92C", Offset = "0x77A92C", VA = "0x77A92C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x77AA30", Offset = "0x77AA30", VA = "0x77AA30")]
	[IteratorStateMachine(typeof(<StartGame>d__15))]
	private IEnumerator StartGame()
	{
		return null;
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x77AAB8", Offset = "0x77AAB8", VA = "0x77AAB8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x77AB80", Offset = "0x77AB80", VA = "0x77AB80")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x77AC6C", Offset = "0x77AC6C", VA = "0x77AC6C", Slot = "14")]
	public override string DameMiNombre()
	{
		return null;
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x77ADDC", Offset = "0x77ADDC", VA = "0x77ADDC", Slot = "7")]
	public override void GuardarLogros()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x77ADE0", Offset = "0x77ADE0", VA = "0x77ADE0", Slot = "10")]
	public override void InicializarTablas(List<InfoTabla> tablas)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x77ADE4", Offset = "0x77ADE4", VA = "0x77ADE4", Slot = "9")]
	public override void InicializarTablas(string[] tablas)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x77ADE8", Offset = "0x77ADE8", VA = "0x77ADE8", Slot = "8")]
	public override void InicializarLogros()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x77ADEC", Offset = "0x77ADEC", VA = "0x77ADEC", Slot = "13")]
	public override void MarcarLogroCompletado(string idLogro)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x77ADF0", Offset = "0x77ADF0", VA = "0x77ADF0", Slot = "11")]
	public override void ObtenerResultadosAlrededorMioConTop(string tabla, int resultadosQueQuiero)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x77AFC8", Offset = "0x77AFC8", VA = "0x77AFC8", Slot = "12")]
	public override void SubirRecord(string tabla, int record)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x77B190", Offset = "0x77B190", VA = "0x77B190", Slot = "15")]
	public override void MostrarTienda()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x77AB0C", Offset = "0x77AB0C", VA = "0x77AB0C")]
	[IteratorStateMachine(typeof(<SiguienteOperacionConPausa>d__27))]
	private IEnumerator SiguienteOperacionConPausa()
	{
		return null;
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x77B1BC", Offset = "0x77B1BC", VA = "0x77B1BC")]
	private void SiguienteOperacion()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x77B3E8", Offset = "0x77B3E8", VA = "0x77B3E8")]
	private void SubirRecordCallback(Message<bool> msg)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x77B430", Offset = "0x77B430", VA = "0x77B430")]
	private void ResultadosCallback(Message<LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x77BCB0", Offset = "0x77BCB0", VA = "0x77BCB0")]
	public PicoRecords()
	{
	}
}
[Token(Token = "0x20000A8")]
public class PisandoFlechas : MonoBehaviour
{
	[Token(Token = "0x20000A9")]
	public enum DireccionFlechas
	{
		[Token(Token = "0x4000436")]
		derecha,
		[Token(Token = "0x4000437")]
		izquierda,
		[Token(Token = "0x4000438")]
		adelante,
		[Token(Token = "0x4000439")]
		atras
	}

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LayerMask mascaraPlayer;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public DireccionFlechas direccionFlechas;

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x77BFF4", Offset = "0x77BFF4", VA = "0x77BFF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x77C04C", Offset = "0x77C04C", VA = "0x77C04C")]
	public void HazQueLasFlechasMirenAmiDireccion()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x77C178", Offset = "0x77C178", VA = "0x77C178")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x77C298", Offset = "0x77C298", VA = "0x77C298")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x77C3AC", Offset = "0x77C3AC", VA = "0x77C3AC")]
	public PisandoFlechas()
	{
	}
}
[Token(Token = "0x20000AA")]
public class ControladorPlayerPC : PlayerGenerico
{
	[Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class <VibracionParaImpulsos>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TipoVibracion tipo;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEngine.XR.InputDevice device;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ControladorPlayerPC <>4__this;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float potencia;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float duracion;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <t>5__2;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int <i>5__3;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaitForSecondsRealtime <esperaEntreVibraciones>5__4;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float <duracionDeCadaImpulso>5__5;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float <esperaEntreImpulsos>5__6;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int <cadaCuantosVibro>5__7;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x77D378", Offset = "0x77D378", VA = "0x77D378", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x77D3C0", Offset = "0x77D3C0", VA = "0x77D3C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x77C96C", Offset = "0x77C96C", VA = "0x77C96C")]
		[DebuggerHidden]
		public <VibracionParaImpulsos>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x77D1EC", Offset = "0x77D1EC", VA = "0x77D1EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x77D1F0", Offset = "0x77D1F0", VA = "0x77D1F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x77D380", Offset = "0x77D380", VA = "0x77D380", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private byte[] bufferDisparo;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private byte[] bufferMuerte;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private byte[] bufferRecalentamiento;

	[Token(Token = "0x400043D")]
	private const byte potenciaVibracionDisparoRecalientamiento = byte.MaxValue;

	[Token(Token = "0x400043E")]
	private const byte potenciaVibracionMuerte = 180;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private uint channel;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Coroutine vibrando;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool manoDerechaPerdida;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool manoIzquierdaPerdida;

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x77C3B4", Offset = "0x77C3B4", VA = "0x77C3B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x77C3C0", Offset = "0x77C3C0", VA = "0x77C3C0", Slot = "4")]
	public override void Vibra(XRNode manoQueVibra, TipoVibracion tipoVibracion)
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x77C8C0", Offset = "0x77C8C0", VA = "0x77C8C0")]
	[IteratorStateMachine(typeof(<VibracionParaImpulsos>d__9))]
	private IEnumerator VibracionParaImpulsos(float duracion, float potencia, UnityEngine.XR.InputDevice device, TipoVibracion tipo)
	{
		return null;
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x77C740", Offset = "0x77C740", VA = "0x77C740")]
	private void InicializarVibracion()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x77C994", Offset = "0x77C994", VA = "0x77C994", Slot = "5")]
	public override void PonerOffsetArmas()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x77CC84", Offset = "0x77CC84", VA = "0x77CC84")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x77CD48", Offset = "0x77CD48", VA = "0x77CD48")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x77CE08", Offset = "0x77CE08", VA = "0x77CE08")]
	private void InputTracking_trackingLost(XRNodeState obj)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x77CE5C", Offset = "0x77CE5C", VA = "0x77CE5C")]
	private void InputTracking_trackingAcquired(XRNodeState obj)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x77CEA8", Offset = "0x77CEA8", VA = "0x77CEA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x77D1E4", Offset = "0x77D1E4", VA = "0x77D1E4")]
	public ControladorPlayerPC()
	{
	}
}
[Token(Token = "0x20000AC")]
public class ControladorPlayerVIVE : PlayerGenerico
{
	[Token(Token = "0x6000310")]
	[Address(RVA = "0x77D3C8", Offset = "0x77D3C8", VA = "0x77D3C8", Slot = "5")]
	public override void PonerOffsetArmas()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x77D3CC", Offset = "0x77D3CC", VA = "0x77D3CC", Slot = "4")]
	public override void Vibra(XRNode manoQueVibra, TipoVibracion tipoVibracion)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x77D3D0", Offset = "0x77D3D0", VA = "0x77D3D0")]
	public ControladorPlayerVIVE()
	{
	}
}
[Token(Token = "0x20000AD")]
public class CambiarMaterialParaPS4 : MonoBehaviour
{
	[Token(Token = "0x20000AE")]
	public enum tipoParaCambiar
	{
		[Token(Token = "0x4000453")]
		trail,
		[Token(Token = "0x4000454")]
		renderer,
		[Token(Token = "0x4000455")]
		meshRenderer,
		[Token(Token = "0x4000456")]
		trailRenderer
	}

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public tipoParaCambiar tipo;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material materialPS4;

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x77D3D8", Offset = "0x77D3D8", VA = "0x77D3D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x77D3DC", Offset = "0x77D3DC", VA = "0x77D3DC")]
	public CambiarMaterialParaPS4()
	{
	}
}
[Token(Token = "0x20000AF")]
public class VRDeviceNames
{
	[Token(Token = "0x4000457")]
	public const string None = "None";

	[Token(Token = "0x4000458")]
	public const string Unknown = "Unknown";

	[Token(Token = "0x4000459")]
	public const string Oculus = "Oculus";

	[Token(Token = "0x400045A")]
	public const string PlayStationVR = "PlayStationVR";

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x77D3E4", Offset = "0x77D3E4", VA = "0x77D3E4")]
	public VRDeviceNames()
	{
	}
}
[Token(Token = "0x20000B0")]
public class VRManager : MonoBehaviour
{
	[Token(Token = "0x6000316")]
	[Address(RVA = "0x77D3EC", Offset = "0x77D3EC", VA = "0x77D3EC")]
	public VRManager()
	{
	}
}
[Token(Token = "0x20000B1")]
public class VRPostReprojection : MonoBehaviour
{
	[Token(Token = "0x6000317")]
	[Address(RVA = "0x77D3F4", Offset = "0x77D3F4", VA = "0x77D3F4")]
	public VRPostReprojection()
	{
	}
}
[Token(Token = "0x20000B2")]
public class pulsadorAbreLaPuerta : MonoBehaviour
{
	[Token(Token = "0x20000B3")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x400046F")]
		desconocido,
		[Token(Token = "0x4000470")]
		cerca,
		[Token(Token = "0x4000471")]
		lejos
	}

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LayerMask mascaraPlayer;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject puertaIzquierda;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject puertaDerecha;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MeshRenderer cable1;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MeshRenderer cable2;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private MeshRenderer cable3;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MeshRenderer cable4;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer cable5;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private MeshRenderer cable6;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private MeshRenderer cable7;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private MeshRenderer cruz;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool ultimoEstadoValidado;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private AudioSource sondio;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool primerCambio;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Material materialSeleccionado;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Material materialApagado;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool objetivoConsiguido;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int ticksSinActualizar;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x77D3FC", Offset = "0x77D3FC", VA = "0x77D3FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x77D828", Offset = "0x77D828", VA = "0x77D828")]
	private void Start()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x77D9E8", Offset = "0x77D9E8", VA = "0x77D9E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x77D8E0", Offset = "0x77D8E0", VA = "0x77D8E0")]
	private void RefrescarNivel()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x77D9EC", Offset = "0x77D9EC", VA = "0x77D9EC")]
	private void Update()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x77DD84", Offset = "0x77DD84", VA = "0x77DD84")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x77DE88", Offset = "0x77DE88", VA = "0x77DE88")]
	public pulsadorAbreLaPuerta()
	{
	}
}
[Token(Token = "0x20000B4")]
public class Puntos : MonoBehaviour
{
	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Puntos instance;

	[Token(Token = "0x4000473")]
	public const string nombreTablas = "2Leaderboard_Level_";

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Referencias")]
	public TextMesh puntosMaximosEnNivelActualTextMesh;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh puntosUltimaPartidaTextMesh;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMesh porcentajeMaximoEnNivelActualTextMesh;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMesh porcentajeCompletadoUltimaPartidaTextMesh;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMesh arcosBonusObtenidosTextMesh;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMesh esferaBonusObtenidasTextMesh;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh dronesDestruidosTextMesh;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMesh targetsDestridosTextMesh;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMesh tramosCompletadosTextMesh;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioClip[] vocesPuntos;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject efectoPuntosPrefab;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Header("Variables")]
	[Space(5f)]
	public int[] porcentajesMaximosPorNivel;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int[] puntosMaximosPorNivel;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int puntosActuales;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float arcosBonusObtenidos;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public int esferaBonusObtenidas;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public int dronesDestruidos;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int targetsDestridos;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public Vector3 posicionInicial;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float distanciaRecorrida;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float tramosCompletados;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool puedoContarTiempo;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public int porcentajeDeCancion;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public string strPorcentajeCancion;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public string strScore;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public string strSegundosRestantes;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private AudioSource miAudioSource;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int ultimaVozPuntos;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private int rachaBonus;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int ticksSinPuntuar;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private int ticksSinPiropos;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool avisoTiempoSonado;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public ManagerLeaderboard managerLeaderboard;

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x77DE98", Offset = "0x77DE98", VA = "0x77DE98")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x77DEF0", Offset = "0x77DEF0", VA = "0x77DEF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x77E118", Offset = "0x77E118", VA = "0x77E118")]
	private void Update()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x77E8E4", Offset = "0x77E8E4", VA = "0x77E8E4")]
	public void ReiniciarPuntos()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x77EDC8", Offset = "0x77EDC8", VA = "0x77EDC8")]
	public void InstanciarEfectoPuntos(Vector3 posicion, int puntos = 30)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x77DFA8", Offset = "0x77DFA8", VA = "0x77DFA8")]
	private void LeerPuntosPorcentajesNiveles()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x77ECB8", Offset = "0x77ECB8", VA = "0x77ECB8")]
	public void EscribirPuntosPorcentajeNivel(int nivel)
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x77F018", Offset = "0x77F018", VA = "0x77F018")]
	public void ActualizarTextosEnMenu(int nivel)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x77F158", Offset = "0x77F158", VA = "0x77F158")]
	public void PartidaFinalizada(int nivelActual, bool nivelCompletado)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x77F328", Offset = "0x77F328", VA = "0x77F328")]
	public Puntos()
	{
	}
}
[Token(Token = "0x20000B5")]
public class RestaurarRotura : MonoBehaviour
{
	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3[] posicionesIniciales;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform[] Ttrozos;

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x77F330", Offset = "0x77F330", VA = "0x77F330")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x77F588", Offset = "0x77F588", VA = "0x77F588")]
	public void Restaurar()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x77F728", Offset = "0x77F728", VA = "0x77F728")]
	public RestaurarRotura()
	{
	}
}
[Token(Token = "0x20000B6")]
public class RotacionEnCadena : MonoBehaviour
{
	[Token(Token = "0x20000B7")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x40004A9")]
		desconocido,
		[Token(Token = "0x40004AA")]
		cerca,
		[Token(Token = "0x40004AB")]
		lejos
	}

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] partes;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3[] escalaInicialPartes;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float coldDownRotacion;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float VelocidadLerpEscalaRotacion;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float velocidadMovimiento;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float distanciaEntreObjetos;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool puedoGirar;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float tGrioPrincipal;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float ultimaVezQueCambie;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Quaternion giroDestino;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float maximaEscala;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform objetoQueSigo;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool escalaUniforme;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool sinRotacion;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int distanciaAlaQueTengoQueActivarme;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int ticksSinActualizar;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x77F730", Offset = "0x77F730", VA = "0x77F730")]
	private void Start()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x77F818", Offset = "0x77F818", VA = "0x77F818")]
	private void Update()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x78004C", Offset = "0x78004C", VA = "0x78004C")]
	public RotacionEnCadena()
	{
	}
}
[Token(Token = "0x20000B8")]
public class rotarSegunMusica : MonoBehaviour
{
	[Token(Token = "0x20000B9")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x40004B0")]
		desconocido,
		[Token(Token = "0x40004B1")]
		cerca,
		[Token(Token = "0x40004B2")]
		lejos
	}

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int barra;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int ticksSinActualizar;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x780070", Offset = "0x780070", VA = "0x780070")]
	private void Start()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x780078", Offset = "0x780078", VA = "0x780078")]
	private void Update()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x780434", Offset = "0x780434", VA = "0x780434")]
	public rotarSegunMusica()
	{
	}
}
[Token(Token = "0x20000BA")]
public class sorteaQueInterruptorMeAbre : MonoBehaviour
{
	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject interruptorDerecha;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject interruptorCentro;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject interruptorIzquierda;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject cable6;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject cable7;

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x78043C", Offset = "0x78043C", VA = "0x78043C")]
	private void RefrescarNivel()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x7804E4", Offset = "0x7804E4", VA = "0x7804E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x7804E8", Offset = "0x7804E8", VA = "0x7804E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x7805A0", Offset = "0x7805A0", VA = "0x7805A0")]
	public sorteaQueInterruptorMeAbre()
	{
	}
}
[Token(Token = "0x20000BB")]
public class sortearDireccionDeFlechas : MonoBehaviour
{
	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<PisandoFlechas.DireccionFlechas> posiblesDirecciones;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] objetosFlecha;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private PisandoFlechas.DireccionFlechas direccionFlechaDelSorteo;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource snd;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool estadoActual;

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x7805A8", Offset = "0x7805A8", VA = "0x7805A8")]
	private void HazQueLasFlechasMirenAEstaDireccion(GameObject flechas, PisandoFlechas.DireccionFlechas direccion)
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x780654", Offset = "0x780654", VA = "0x780654")]
	private void Enable()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x780678", Offset = "0x780678", VA = "0x780678")]
	private void Start()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x780780", Offset = "0x780780", VA = "0x780780")]
	private void Update()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x780830", Offset = "0x780830", VA = "0x780830")]
	public sortearDireccionDeFlechas()
	{
	}
}
[Token(Token = "0x20000BC")]
public class sorteraPulsadorQueMeAbre : MonoBehaviour
{
	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] interruptoresIzq;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] interruptoresDer;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] cablesIzq;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] cablesDer;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material MaterialPulsadorRojo;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material MaterialPulsadorVerde;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material MaterialCableRojo;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material MaterialCableVerde;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public MeshRenderer cruzPuerta;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private interruptorDisparableParaPuerta[] interruptoresDisparableParaPuertaDer;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private interruptorDisparableParaPuerta[] interruptoresDisparableParaPuertaIzq;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private MeshRenderer[] materialesCablesDer;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private MeshRenderer[] materialesCablesIzq;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool primerCambio;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	public bool puertaAbierta;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject puertaIzquierda;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject puertaDerecha;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool ultimoEstadoValidado;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private AudioSource sndPuerta;

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x7808FC", Offset = "0x7808FC", VA = "0x7808FC")]
	private void PonerCablesDelColorQueToqueSegunInterruptoresEnEsteLado(MeshRenderer[] cables, interruptorDisparableParaPuerta[] interruptores)
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x780D94", Offset = "0x780D94", VA = "0x780D94")]
	public bool todoVerde()
	{
		return default(bool);
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x780E20", Offset = "0x780E20", VA = "0x780E20")]
	public void PonerCablesDelColorQueToqueSegunInterruptores()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x780E5C", Offset = "0x780E5C", VA = "0x780E5C")]
	public void cambiarMaterialPulsador(GameObject pulsador, bool verde)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x780F40", Offset = "0x780F40", VA = "0x780F40")]
	private void RefrescarNivel()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x7812E0", Offset = "0x7812E0", VA = "0x7812E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x7812E4", Offset = "0x7812E4", VA = "0x7812E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x781710", Offset = "0x781710", VA = "0x781710")]
	private void Start()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x7817C8", Offset = "0x7817C8", VA = "0x7817C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x781AF8", Offset = "0x781AF8", VA = "0x781AF8")]
	public sorteraPulsadorQueMeAbre()
	{
	}
}
[Token(Token = "0x20000BD")]
public class SubirSegunMusica : MonoBehaviour
{
	[Token(Token = "0x20000BE")]
	public enum SituacionDelJugador
	{
		[Token(Token = "0x40004D4")]
		desconocido,
		[Token(Token = "0x40004D5")]
		cerca,
		[Token(Token = "0x40004D6")]
		lejos
	}

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int ticksSinActualizar;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private SituacionDelJugador situacionDelJugador;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 posicionBase;

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x781B08", Offset = "0x781B08", VA = "0x781B08")]
	private void Start()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x781B3C", Offset = "0x781B3C", VA = "0x781B3C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x781B70", Offset = "0x781B70", VA = "0x781B70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x781CF4", Offset = "0x781CF4", VA = "0x781CF4")]
	public SubirSegunMusica()
	{
	}
}
[Token(Token = "0x20000BF")]
public class suma : MonoBehaviour
{
	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] objs;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject esferaPrefab;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject dianaPrefab;

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x781CFC", Offset = "0x781CFC", VA = "0x781CFC")]
	public suma()
	{
	}
}
[Token(Token = "0x20000C0")]
public class TraducirEsteTexto : MonoBehaviour
{
	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public string textoOriginal;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TextMesh texto;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int numCaracteresParaHAcerCambioDeLinea;

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x781D04", Offset = "0x781D04", VA = "0x781D04")]
	private void Start()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x781EBC", Offset = "0x781EBC", VA = "0x781EBC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x781F6C", Offset = "0x781F6C", VA = "0x781F6C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x78201C", Offset = "0x78201C", VA = "0x78201C")]
	private void TraducemeEsto()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x782064", Offset = "0x782064", VA = "0x782064")]
	public TraducirEsteTexto()
	{
	}
}
[Token(Token = "0x20000C1")]
public class Tramo : MonoBehaviour
{
	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ControladorDron[] drones;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] torretas;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] morteros;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] minas;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 posicionDron;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] obstaculosGO;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Obstaculo[] obstaculos;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject techoNormal;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject paredDerechaNormal;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject paredIzquierdaNormal;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject sueloNormal;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject techoVentana;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject paredDerechaVentana;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject paredIzquierdaVentana;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject sueloVentana;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject sueloVentanaAlternativo;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject esquinaSuperiorDercha;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject esquinaSuperiorIzquierda;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject esquinaInferiorDerecha;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject esquinaInferiorIzquierda;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject obstaculoCheckPoint;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private List<Obstaculo> modulosBasicos;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private List<Obstaculo> modulosDianas;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private List<Obstaculo> modulosMartillos;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private List<Obstaculo> modulosGusanosBolasSimple;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private List<Obstaculo> modulosGusanosCuadrosSimple;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private List<Obstaculo> modulosGusanosBolasCabeza;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private List<Obstaculo> modulosGusanosCuadrosCabeza;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<Obstaculo> modulosFlechasVelocidad;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private List<Obstaculo> modulosFlechasLaterales;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private List<Obstaculo> modulosPuertasPulsaSuelo;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private List<Obstaculo> modulosOjoGigante;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private List<Obstaculo> modulosLaser;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private List<Obstaculo> modulosSinGravedad;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private List<Obstaculo> modulosPuertasDiana;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public GameObject reverb;

	[Token(Token = "0x4000501")]
	private const int numeroDeNivelesConNovedadesReales = 15;

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x782074", Offset = "0x782074", VA = "0x782074")]
	public List<Obstaculo> obstaculosPermitidoPorElNivelActual(bool soloDeLosQueTapan)
	{
		return null;
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x782784", Offset = "0x782784", VA = "0x782784")]
	public bool esteNivelTieneModulosExclusivos(int nivel)
	{
		return default(bool);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x7826F4", Offset = "0x7826F4", VA = "0x7826F4")]
	public List<Obstaculo> dimeLosModulosExclusivosDeEsteNivel(int nivel)
	{
		return null;
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x78279C", Offset = "0x78279C", VA = "0x78279C")]
	public Obstaculo dameUnModuloExclusivoDelNivelActual()
	{
		return null;
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x78284C", Offset = "0x78284C", VA = "0x78284C")]
	public void eliminarTodosLosEnemigos()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x7829B8", Offset = "0x7829B8", VA = "0x7829B8")]
	public void ReiniciarTramo()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x782AF8", Offset = "0x782AF8", VA = "0x782AF8")]
	public void PonerModuloDeCheckPoint()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x782BB0", Offset = "0x782BB0", VA = "0x782BB0")]
	public void ColocarObstaculos()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x7831D0", Offset = "0x7831D0", VA = "0x7831D0")]
	public void calcularTramos()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x783768", Offset = "0x783768", VA = "0x783768")]
	public Tramo()
	{
	}
}
[Token(Token = "0x20000C2")]
public class TramosInicialFinal : MonoBehaviour
{
	[Token(Token = "0x20000C3")]
	public enum EstadosTramo
	{
		[Token(Token = "0x400050B")]
		inicial,
		[Token(Token = "0x400050C")]
		final
	}

	[Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class <EsperaParaReiniciarRobots>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TramosInicialFinal <>4__this;

		[Token(Token = "0x17000055")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x783B34", Offset = "0x783B34", VA = "0x783B34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x783B7C", Offset = "0x783B7C", VA = "0x783B7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x7838D0", Offset = "0x7838D0", VA = "0x7838D0")]
		[DebuggerHidden]
		public <EsperaParaReiniciarRobots>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x783A30", Offset = "0x783A30", VA = "0x783A30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x783A34", Offset = "0x783A34", VA = "0x783A34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x783B3C", Offset = "0x783B3C", VA = "0x783B3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject paredAtras;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject menu;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject robots;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject confeti;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject colliderNielCompletado;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ControladorRobotCelebracion[] controladoresRobots;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private WaitForSeconds espera;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Coroutine corEsperaReiniciarRobots;

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x783770", Offset = "0x783770", VA = "0x783770")]
	public void CambiarEstadoTramo(EstadosTramo estadoDestino)
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x783808", Offset = "0x783808", VA = "0x783808")]
	public void ReiniciarRobots()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x78385C", Offset = "0x78385C", VA = "0x78385C")]
	[IteratorStateMachine(typeof(<EsperaParaReiniciarRobots>d__11))]
	private IEnumerator EsperaParaReiniciarRobots()
	{
		return null;
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x7838F8", Offset = "0x7838F8", VA = "0x7838F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x783900", Offset = "0x783900", VA = "0x783900")]
	public void ReiniciarRobotsYa()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x7839B8", Offset = "0x7839B8", VA = "0x7839B8")]
	public TramosInicialFinal()
	{
	}
}
[Token(Token = "0x20000C5")]
public class ValoresDeMusicaParaObjetos : MonoBehaviour
{
	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ValoresDeMusicaParaObjetos instance;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Level m_level;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Level[] levelsBarras;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float nivelDeMusica;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float nivelDeMusicaLerp;

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x783B84", Offset = "0x783B84", VA = "0x783B84")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x783BDC", Offset = "0x783BDC", VA = "0x783BDC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x783C34", Offset = "0x783C34", VA = "0x783C34")]
	private void Update()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x783CA0", Offset = "0x783CA0", VA = "0x783CA0")]
	public ValoresDeMusicaParaObjetos()
	{
	}
}
[Token(Token = "0x20000C6")]
public class test90fps : MonoBehaviour
{
	[Token(Token = "0x6000369")]
	[Address(RVA = "0x783CA8", Offset = "0x783CA8", VA = "0x783CA8")]
	private void Start()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x783CAC", Offset = "0x783CAC", VA = "0x783CAC")]
	public test90fps()
	{
	}
}
namespace PA.ParticleField.Samples
{
	[Token(Token = "0x20000C7")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMesh texto;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float updateInterval;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float accum;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int frames;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float timeleft;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string frameString;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x783CB4", Offset = "0x783CB4", VA = "0x783CB4")]
		private void Start()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x783D18", Offset = "0x783D18", VA = "0x783D18")]
		private void Update()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x783DF0", Offset = "0x783DF0", VA = "0x783DF0")]
		public FPSCounter()
		{
		}
	}
}
namespace Evereal.SkyboxCapture
{
	[Token(Token = "0x20000C8")]
	public class AutoRotate : MonoBehaviour
	{
		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int angleSpeed;

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x783E00", Offset = "0x783E00", VA = "0x783E00")]
		private void Update()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x783EA4", Offset = "0x783EA4", VA = "0x783EA4")]
		public AutoRotate()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class HintUI : MonoBehaviour
	{
		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SkyboxCapture skyboxCapture;

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x783EB4", Offset = "0x783EB4", VA = "0x783EB4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x783FCC", Offset = "0x783FCC", VA = "0x783FCC")]
		public HintUI()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class DontDestroy : MonoBehaviour
	{
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x783FD4", Offset = "0x783FD4", VA = "0x783FD4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x784040", Offset = "0x784040", VA = "0x784040")]
		public DontDestroy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CB")]
	public enum ProjectionType
	{
		[Token(Token = "0x400051E")]
		Equirectangular,
		[Token(Token = "0x400051F")]
		Cubemap
	}
	[Serializable]
	[Token(Token = "0x20000CC")]
	public enum CubemapSizeType
	{
		[Token(Token = "0x4000521")]
		_512,
		[Token(Token = "0x4000522")]
		_1024,
		[Token(Token = "0x4000523")]
		_2048,
		[Token(Token = "0x4000524")]
		_4096
	}
	[Serializable]
	[Token(Token = "0x20000CD")]
	public enum CubemapLayoutType
	{
		[Token(Token = "0x4000526")]
		HorizontalCross,
		[Token(Token = "0x4000527")]
		SixSided,
		[Token(Token = "0x4000528")]
		Compact
	}
	[Serializable]
	[Token(Token = "0x20000CE")]
	public enum AntiAliasingType
	{
		[Token(Token = "0x400052A")]
		_1,
		[Token(Token = "0x400052B")]
		_2,
		[Token(Token = "0x400052C")]
		_4,
		[Token(Token = "0x400052D")]
		_8
	}
	[Serializable]
	[Token(Token = "0x20000CF")]
	public enum ImageFormatType
	{
		[Token(Token = "0x400052F")]
		PNG,
		[Token(Token = "0x4000530")]
		JPEG
	}
	[Serializable]
	[Token(Token = "0x20000D0")]
	public enum ImageSizeType
	{
		[Token(Token = "0x4000532")]
		_1440x720,
		[Token(Token = "0x4000533")]
		_2048x1024,
		[Token(Token = "0x4000534")]
		_4096x2048,
		[Token(Token = "0x4000535")]
		_8192x4096,
		[Token(Token = "0x4000536")]
		_12288x6144,
		[Token(Token = "0x4000537")]
		_16384x8192
	}
	[Token(Token = "0x20000D1")]
	public static class Utils
	{
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x784048", Offset = "0x784048", VA = "0x784048")]
		public static string GetTimeString()
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x7840C8", Offset = "0x7840C8", VA = "0x7840C8")]
		public static Material CreateMaterial(string sName, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x784188", Offset = "0x784188", VA = "0x784188")]
		public static Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x784358", Offset = "0x784358", VA = "0x784358")]
		public static Texture2D CreateTexture(int width, int height, Texture2D t2Create)
		{
			return null;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x784490", Offset = "0x784490", VA = "0x784490")]
		public static RenderTexture CreateRenderTexture(int width, int height, int depth, int antiAliasing, RenderTexture t2Create, bool create = true)
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x784640", Offset = "0x784640", VA = "0x784640")]
		public static string CreateFolder(string f2Create)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x78474C", Offset = "0x78474C", VA = "0x78474C")]
		public static void BrowseFolder(string folder)
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class Readme : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public class Section
		{
			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string heading;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string linkText;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x600037C")]
			[Address(RVA = "0x7848A0", Offset = "0x7848A0", VA = "0x7848A0")]
			public Section()
			{
			}
		}

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D icon;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float iconMaxWidth;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string title;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Section[] sections;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool loadedLayout;

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x784890", Offset = "0x784890", VA = "0x784890")]
		public Readme()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class SkyboxCapture : MonoBehaviour
	{
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public KeyCode captureKey;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public string saveFolder;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string saveFolderFullPath;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public ProjectionType projectionType;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		public CubemapSizeType cubemapSize;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public CubemapLayoutType cubemapLayout;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public ImageFormatType imageFormat;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public int jpgQuality;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		public ImageSizeType imageSize;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public AntiAliasingType antiAliasing;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public Material equirectMaterial;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public Material cubemapMaterial;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Camera captureCamera;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected bool includeCameraRotation;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private CubemapFace[] faces;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string imageSavePath;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private byte[] imageData;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected string LOG_FORMAT;

		[Token(Token = "0x17000057")]
		public int CubemapSize
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x7848A8", Offset = "0x7848A8", VA = "0x7848A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000058")]
		public int ImageWidth
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x7848D4", Offset = "0x7848D4", VA = "0x7848D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000059")]
		public int ImageHeight
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x78499C", Offset = "0x78499C", VA = "0x78499C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005A")]
		public int AntiAliasing
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x784A64", Offset = "0x784A64", VA = "0x784A64")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x784A90", Offset = "0x784A90", VA = "0x784A90")]
		public void StartCapture()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x78561C", Offset = "0x78561C", VA = "0x78561C")]
		private void WriteTextureImage(RenderTexture outputTexture)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x785510", Offset = "0x785510", VA = "0x785510")]
		private void WriteTexture2DImage(Texture2D texture2D)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x785750", Offset = "0x785750", VA = "0x785750")]
		private void WriteImageProcess()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x78588C", Offset = "0x78588C", VA = "0x78588C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x7858B8", Offset = "0x7858B8", VA = "0x7858B8")]
		public SkyboxCapture()
		{
		}
	}
}
namespace AmazingAssets.CurvedWorld
{
	[Token(Token = "0x20000D5")]
	[ExecuteInEditMode]
	public class CurvedWorldBoundingBox : MonoBehaviour
	{
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float scale;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float currentScale;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 boundingBoxSize;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Bounds originalBounds;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MeshFilter meshFilter;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<int, Bounds> boundsDictionary;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool visualizeInEditor;

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x7859D0", Offset = "0x7859D0", VA = "0x7859D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x7859DC", Offset = "0x7859DC", VA = "0x7859DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x785B6C", Offset = "0x785B6C", VA = "0x785B6C")]
		private void Start()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x785FE4", Offset = "0x785FE4", VA = "0x785FE4")]
		private void Update()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x786214", Offset = "0x786214", VA = "0x786214")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x786404", Offset = "0x786404", VA = "0x786404")]
		private void Reset()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x786424", Offset = "0x786424", VA = "0x786424")]
		public void RecalculateBounds()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x786734", Offset = "0x786734", VA = "0x786734")]
		public CurvedWorldBoundingBox()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[ExecuteAlways]
	[RequireComponent(typeof(Camera))]
	public class CurvedWorldCamera : MonoBehaviour
	{
		[Token(Token = "0x20000D7")]
		public enum MATRIX_TYPE
		{
			[Token(Token = "0x4000562")]
			Perspective,
			[Token(Token = "0x4000563")]
			Orthographic
		}

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MATRIX_TYPE matrixType;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(1f, 179f)]
		public float fieldOfView;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float size;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool nearClipPlaneSameAsCamera;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float nearClipPlane;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Camera activeCamera;

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x786744", Offset = "0x786744", VA = "0x786744")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x7867F4", Offset = "0x7867F4", VA = "0x7867F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x786878", Offset = "0x786878", VA = "0x786878")]
		private void Start()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x786928", Offset = "0x786928", VA = "0x786928")]
		private void Update()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x786C84", Offset = "0x786C84", VA = "0x786C84")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x786D3C", Offset = "0x786D3C", VA = "0x786D3C")]
		public CurvedWorldCamera()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public enum BEND_TYPE
	{
		[Token(Token = "0x4000565")]
		ClassicRunner_X_Positive,
		[Token(Token = "0x4000566")]
		ClassicRunner_X_Negative,
		[Token(Token = "0x4000567")]
		ClassicRunner_Z_Positive,
		[Token(Token = "0x4000568")]
		ClassicRunner_Z_Negative,
		[Token(Token = "0x4000569")]
		LittlePlanet_X,
		[Token(Token = "0x400056A")]
		LittlePlanet_Y,
		[Token(Token = "0x400056B")]
		LittlePlanet_Z,
		[Token(Token = "0x400056C")]
		CylindricalTower_X,
		[Token(Token = "0x400056D")]
		CylindricalTower_Z,
		[Token(Token = "0x400056E")]
		CylindricalRolloff_X,
		[Token(Token = "0x400056F")]
		CylindricalRolloff_Z,
		[Token(Token = "0x4000570")]
		SpiralHorizontal_X_Positive,
		[Token(Token = "0x4000571")]
		SpiralHorizontal_X_Negative,
		[Token(Token = "0x4000572")]
		SpiralHorizontal_Z_Positive,
		[Token(Token = "0x4000573")]
		SpiralHorizontal_Z_Negative,
		[Token(Token = "0x4000574")]
		SpiralHorizontalDouble_X,
		[Token(Token = "0x4000575")]
		SpiralHorizontalDouble_Z,
		[Token(Token = "0x4000576")]
		SpiralHorizontalRolloff_X,
		[Token(Token = "0x4000577")]
		SpiralHorizontalRolloff_Z,
		[Token(Token = "0x4000578")]
		SpiralVertical_X_Positive,
		[Token(Token = "0x4000579")]
		SpiralVertical_X_Negative,
		[Token(Token = "0x400057A")]
		SpiralVertical_Z_Positive,
		[Token(Token = "0x400057B")]
		SpiralVertical_Z_Negative,
		[Token(Token = "0x400057C")]
		SpiralVerticalDouble_X,
		[Token(Token = "0x400057D")]
		SpiralVerticalDouble_Z,
		[Token(Token = "0x400057E")]
		SpiralVerticalRolloff_X,
		[Token(Token = "0x400057F")]
		SpiralVerticalRolloff_Z,
		[Token(Token = "0x4000580")]
		TwistedSpiral_X_Positive,
		[Token(Token = "0x4000581")]
		TwistedSpiral_X_Negative,
		[Token(Token = "0x4000582")]
		TwistedSpiral_Z_Positive,
		[Token(Token = "0x4000583")]
		TwistedSpiral_Z_Negative
	}
	[Token(Token = "0x20000D9")]
	[ExecuteAlways]
	public class CurvedWorldController : MonoBehaviour
	{
		[Token(Token = "0x20000DA")]
		public enum AXIS_TYPE
		{
			[Token(Token = "0x40005A7")]
			Transform,
			[Token(Token = "0x40005A8")]
			Custom,
			[Token(Token = "0x40005A9")]
			CustomNormalized
		}

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BEND_TYPE bendType;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(1f, 32f)]
		public int bendID;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bendPivotPoint;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 bendPivotPointPosition;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform bendRotationCenter;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 bendRotationCenterPosition;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 bendRotationAxis;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AXIS_TYPE bendRotationAxisType;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform bendRotationCenter2;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector3 bendRotationCenter2Position;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float bendVerticalSize;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float bendVerticalOffset;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float bendHorizontalSize;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float bendHorizontalOffset;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float bendCurvatureSize;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float bendCurvatureOffset;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float bendAngle;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float bendAngle2;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float bendMinimumRadius;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float bendMinimumRadius2;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float bendRolloff;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool disableInEditor;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool manualUpdate;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private BEND_TYPE previousBentType;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int previousID;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int materialPropertyID_PivotPoint;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int materialPropertyID_RotationCenter;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int materialPropertyID_RotationCenter2;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int materialPropertyID_RotationAxis;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int materialPropertyID_BendSize;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int materialPropertyID_BendOffset;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int materialPropertyID_BendAngle;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int materialPropertyID_BendMinimumRadius;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int materialPropertyID_BendRolloff;

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x786D64", Offset = "0x786D64", VA = "0x786D64")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x786D94", Offset = "0x786D94", VA = "0x786D94")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x786DAC", Offset = "0x786DAC", VA = "0x786DAC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x786DEC", Offset = "0x786DEC", VA = "0x786DEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x7871F0", Offset = "0x7871F0", VA = "0x7871F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x7877C0", Offset = "0x7877C0", VA = "0x7877C0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x787200", Offset = "0x787200", VA = "0x787200")]
		private void UpdateShaderdata()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x787978", Offset = "0x787978", VA = "0x787978")]
		private void UpdateShaderDataDisabled()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x786D7C", Offset = "0x786D7C", VA = "0x786D7C")]
		public void DisableBend()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x786DCC", Offset = "0x786DCC", VA = "0x786DCC")]
		public void EnableBend()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x787BFC", Offset = "0x787BFC", VA = "0x787BFC")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x787910", Offset = "0x787910", VA = "0x787910")]
		private void CheckBendChanging()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x786DF0", Offset = "0x786DF0", VA = "0x786DF0")]
		private void GenerateShaderPropertyIDs()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x787C00", Offset = "0x787C00", VA = "0x787C00")]
		public Vector3 TransformPosition(Vector3 vertex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x787C88", Offset = "0x787C88", VA = "0x787C88")]
		public Quaternion TransformRotation(Vector3 vertex, Vector3 forwardVector, Vector3 rightVector)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x787F60", Offset = "0x787F60", VA = "0x787F60")]
		public void SetBendVerticalSize(float value)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x787F68", Offset = "0x787F68", VA = "0x787F68")]
		public void SetBendVerticalOffset(float value)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x787F70", Offset = "0x787F70", VA = "0x787F70")]
		public void SetBendHorizontalSize(float value)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x787F78", Offset = "0x787F78", VA = "0x787F78")]
		public void SetBendHorizontalOffset(float value)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x787F80", Offset = "0x787F80", VA = "0x787F80")]
		public void SetBendCurvatureSize(float value)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x787F88", Offset = "0x787F88", VA = "0x787F88")]
		public void SetBendCurvatureOffset(float value)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x787F90", Offset = "0x787F90", VA = "0x787F90")]
		public void SetBendAngle(float value)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x787F98", Offset = "0x787F98", VA = "0x787F98")]
		public void SetBendAngle2(float value)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x787FA0", Offset = "0x787FA0", VA = "0x787FA0")]
		public void SetBendMinimumRadius(float value)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x787FA8", Offset = "0x787FA8", VA = "0x787FA8")]
		public void SetBendMinimumRadius2(float value)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x787FB0", Offset = "0x787FB0", VA = "0x787FB0")]
		public void SetBendRolloff(float value)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x787FB8", Offset = "0x787FB8", VA = "0x787FB8")]
		public CurvedWorldController()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public static class CurvedWorldUtilities
	{
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x787FC8", Offset = "0x787FC8", VA = "0x787FC8")]
		public static Vector3 TransformPosition(Vector3 vertex, CurvedWorldController controller)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x788214", Offset = "0x788214", VA = "0x788214")]
		private static Vector3 TransformPosition(Vector3 vertex, BEND_TYPE bendType, Vector3 pivotPoint, Vector2 bendSize, Vector2 bendOffset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x7886FC", Offset = "0x7886FC", VA = "0x7886FC")]
		private static Vector3 TransformPosition(Vector3 vertex, BEND_TYPE bendType, Vector3 pivotPoint, float bendSize, float bendOffset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x788998", Offset = "0x788998", VA = "0x788998")]
		private static Vector3 TransformPosition(Vector3 vertex, BEND_TYPE bendType, Vector3 pivotPoint, Vector3 rotationCenter, float bendAngle, float bendMinimumRadius)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x789140", Offset = "0x789140", VA = "0x789140")]
		private static Vector3 TransformPosition(Vector3 vertex, BEND_TYPE bendType, Vector3 pivotPoint, Vector3 rotationCenter, Vector3 rotationCenter2, float bendAngle, float bendMinimumRadius, float bendAngle2, float bendMinimumRadius2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x789274", Offset = "0x789274", VA = "0x789274")]
		private static Vector3 TransformPosition(Vector3 vertex, BEND_TYPE bendType, Vector3 pivotPoint, Vector3 rotationCenter, float bendAngle, float bendMinimumRadius, float bendRolloff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x788354", Offset = "0x788354", VA = "0x788354")]
		private static Vector3 TransformPosition(Vector3 vertex, BEND_TYPE bendType, Vector3 pivotPoint, Vector3 rotationAxis, Vector3 bendSize, Vector3 bendOffset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x7893FC", Offset = "0x7893FC", VA = "0x7893FC")]
		private static float Smooth(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x7896F4", Offset = "0x7896F4", VA = "0x7896F4")]
		private static float SmoothTwistedPositive(float x, float scale)
		{
			return default(float);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x789830", Offset = "0x789830", VA = "0x789830")]
		private static float SmoothTwistedNegative(float x, float scale)
		{
			return default(float);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x7893E8", Offset = "0x7893E8", VA = "0x7893E8")]
		private static float Sign(float a)
		{
			return default(float);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x78985C", Offset = "0x78985C", VA = "0x78985C")]
		private static float Abs(float a)
		{
			return default(float);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x789720", Offset = "0x789720", VA = "0x789720")]
		private static void RotateVertex(ref Vector3 vertex, Vector3 pivot, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x78947C", Offset = "0x78947C", VA = "0x78947C")]
		private static void Spiral_H_Rotate_X_Positive(ref Vector3 vertex, Vector3 pivot, float absoluteValue, float smoothValue, float l, float angle)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x789424", Offset = "0x789424", VA = "0x789424")]
		private static void Spiral_H_Rotate_X_Negative(ref Vector3 vertex, Vector3 pivot, float absoluteValue, float smoothValue, float l, float angle)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x7894D4", Offset = "0x7894D4", VA = "0x7894D4")]
		private static void Spiral_H_Rotate_Z_Positive(ref Vector3 vertex, Vector3 pivot, float absoluteValue, float smoothValue, float l, float angle)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x78952C", Offset = "0x78952C", VA = "0x78952C")]
		private static void Spiral_H_Rotate_Z_Negative(ref Vector3 vertex, Vector3 pivot, float absoluteValue, float smoothValue, float l, float angle)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x7895E0", Offset = "0x7895E0", VA = "0x7895E0")]
		private static void Spiral_V_Rotate_X_Positive(ref Vector3 vertex, Vector3 pivot, float absoluteValue, float smoothValue, float l, float angle)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x789584", Offset = "0x789584", VA = "0x789584")]
		private static void Spiral_V_Rotate_X_Negative(ref Vector3 vertex, Vector3 pivot, float absoluteValue, float smoothValue, float l, float angle)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x78963C", Offset = "0x78963C", VA = "0x78963C")]
		private static void Spiral_V_Rotate_Z_Positive(ref Vector3 vertex, Vector3 pivot, float absoluteValue, float smoothValue, float l, float angle)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x789698", Offset = "0x789698", VA = "0x789698")]
		private static void Spiral_V_Rotate_Z_Negative(ref Vector3 vertex, Vector3 pivot, float absoluteValue, float smoothValue, float l, float angle)
		{
		}
	}
}
namespace AmazingAssets.CurvedWorld.Example
{
	[Token(Token = "0x20000DC")]
	public class Perspective2D_PlatformerCharacter : MonoBehaviour
	{
		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxSpeed;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_JumpForce;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_CrouchSpeed;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_AirControl;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask m_WhatIsGround;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_GroundCheck;

		[Token(Token = "0x40005B0")]
		private const float k_GroundedRadius = 0.2f;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_Grounded;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_CeilingCheck;

		[Token(Token = "0x40005B3")]
		private const float k_CeilingRadius = 0.01f;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator m_Anim;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody2D m_Rigidbody2D;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_FacingRight;

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x789874", Offset = "0x789874", VA = "0x789874")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x789980", Offset = "0x789980", VA = "0x789980")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x789B40", Offset = "0x789B40", VA = "0x789B40")]
		public void Move(float move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x789DAC", Offset = "0x789DAC", VA = "0x789DAC")]
		private void Flip()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x789E1C", Offset = "0x789E1C", VA = "0x789E1C")]
		public Perspective2D_PlatformerCharacter()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[RequireComponent(typeof(Perspective2D_PlatformerCharacter))]
	public class Perspective2D_PlatformerUserControl : MonoBehaviour
	{
		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Perspective2D_PlatformerCharacter m_Character;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Jump;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool uiButtonJump;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector2 touchPivot;

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x789E44", Offset = "0x789E44", VA = "0x789E44")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x789E9C", Offset = "0x789E9C", VA = "0x789E9C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x789F08", Offset = "0x789F08", VA = "0x789F08")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x78A108", Offset = "0x78A108", VA = "0x78A108")]
		public void UIJumpButtonOn()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x78A114", Offset = "0x78A114", VA = "0x78A114")]
		public Perspective2D_PlatformerUserControl()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class Perspective2D_Restarter : MonoBehaviour
	{
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x78A11C", Offset = "0x78A11C", VA = "0x78A11C")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x78A1B8", Offset = "0x78A1B8", VA = "0x78A1B8")]
		public Perspective2D_Restarter()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class AngleHeightBlend : MonoBehaviour
	{
		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvedWorldController curvedWorldController;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float angle1;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float angle2;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform pivotPoint1;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float initialHeight1;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform pivotPoint2;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float initialHeight2;

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x78A1C0", Offset = "0x78A1C0", VA = "0x78A1C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x78A208", Offset = "0x78A208", VA = "0x78A208")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x78A2D8", Offset = "0x78A2D8", VA = "0x78A2D8")]
		public void SetAngle1(float value)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x78A2E0", Offset = "0x78A2E0", VA = "0x78A2E0")]
		public void SetAngle2(float value)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x78A2E8", Offset = "0x78A2E8", VA = "0x78A2E8")]
		public AngleHeightBlend()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class CameraFollow : MonoBehaviour
	{
		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float smoothing;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 offset;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x78A2F0", Offset = "0x78A2F0", VA = "0x78A2F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x78A358", Offset = "0x78A358", VA = "0x78A358")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x78A450", Offset = "0x78A450", VA = "0x78A450")]
		public CameraFollow()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class CameraPan : MonoBehaviour
	{
		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float moveSpeed;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Key moveLeft;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Key moveRight;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Key moveUp;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Key moveDown;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x78A460", Offset = "0x78A460", VA = "0x78A460")]
		private void Update()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x78A644", Offset = "0x78A644", VA = "0x78A644")]
		public CameraPan()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class CarSpawner : MonoBehaviour
	{
		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] cars;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spawnRate;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float spawnRandomizer;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Space(10f)]
		public Vector3 positionRandomizer;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 rotation;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space(10f)]
		public Vector3 moveDirection;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector2 movingSpeed;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float deltaTime;

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x78A660", Offset = "0x78A660", VA = "0x78A660")]
		private void Start()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x78A664", Offset = "0x78A664", VA = "0x78A664")]
		private void Update()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x78A888", Offset = "0x78A888", VA = "0x78A888")]
		public CarSpawner()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class ChunkSpawner : MonoBehaviour
	{
		[Token(Token = "0x20000E4")]
		public enum AXIS
		{
			[Token(Token = "0x40005DB")]
			XPositive,
			[Token(Token = "0x40005DC")]
			XNegative,
			[Token(Token = "0x40005DD")]
			ZPositive,
			[Token(Token = "0x40005DE")]
			ZNegative
		}

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] chunks;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int initialSpawnCount;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float destoryZone;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Space(10f)]
		public AXIS axis;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Vector3 moveDirection;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float movingSpeed;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float chunkSize;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject lastChunk;

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x78A8BC", Offset = "0x78A8BC", VA = "0x78A8BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x78AB44", Offset = "0x78AB44", VA = "0x78AB44")]
		public void DestroyChunk(RunnerChunk thisChunk)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x78AC0C", Offset = "0x78AC0C", VA = "0x78AC0C")]
		public ChunkSpawner()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class DisableCurvedWorld : MonoBehaviour
	{
		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvedWorldController curvedWorldController;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Space(10f)]
		public float xMin;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float xMax;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Space(10f)]
		public float yMin;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float yMax;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Space(10f)]
		public float zMin;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float zMax;

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x78AC34", Offset = "0x78AC34", VA = "0x78AC34")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x78AD58", Offset = "0x78AD58", VA = "0x78AD58")]
		private void ToWorldSpace()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x78B10C", Offset = "0x78B10C", VA = "0x78B10C")]
		public DisableCurvedWorld()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public static class ExampleInput
	{
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x78B114", Offset = "0x78B114", VA = "0x78B114")]
		public static bool GetKeyDown(Key key)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x78A5DC", Offset = "0x78A5DC", VA = "0x78A5DC")]
		public static bool GetKey(Key key)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x78B17C", Offset = "0x78B17C", VA = "0x78B17C")]
		public static bool GetKeyUp(Key key)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E7")]
	public class GravityModifier : MonoBehaviour
	{
		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 gravity;

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x78B1E4", Offset = "0x78B1E4", VA = "0x78B1E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x78B1F4", Offset = "0x78B1F4", VA = "0x78B1F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x78B20C", Offset = "0x78B20C", VA = "0x78B20C")]
		public GravityModifier()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class ManualControllerUpdate : MonoBehaviour
	{
		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvedWorldController curvedWorldController;

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x78B224", Offset = "0x78B224", VA = "0x78B224")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x78B31C", Offset = "0x78B31C", VA = "0x78B31C")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x78B3A0", Offset = "0x78B3A0", VA = "0x78B3A0")]
		private void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x78B478", Offset = "0x78B478", VA = "0x78B478")]
		public ManualControllerUpdate()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class RunnerCar : MonoBehaviour
	{
		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 moveDirection;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float movingSpeed;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody rigidBody;

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x78B480", Offset = "0x78B480", VA = "0x78B480")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x78B4D8", Offset = "0x78B4D8", VA = "0x78B4D8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x78B628", Offset = "0x78B628", VA = "0x78B628")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x78B814", Offset = "0x78B814", VA = "0x78B814")]
		public RunnerCar()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class RunnerChunk : MonoBehaviour
	{
		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ChunkSpawner spawner;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x78B828", Offset = "0x78B828", VA = "0x78B828")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x78B898", Offset = "0x78B898", VA = "0x78B898")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x78B9A4", Offset = "0x78B9A4", VA = "0x78B9A4")]
		public RunnerChunk()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class RunnerPlayer : MonoBehaviour
	{
		[Token(Token = "0x20000EC")]
		public enum SIDE
		{
			[Token(Token = "0x40005F6")]
			Left,
			[Token(Token = "0x40005F7")]
			Right
		}

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 initialPosition;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 newPos;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SIDE side;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Key moveLeftKey;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Key moveRightKey;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animation animationComp;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationClip moveLeftAnimation;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationClip moveRightAnimation;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float translateOffset;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x78B9AC", Offset = "0x78B9AC", VA = "0x78B9AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x78BA60", Offset = "0x78BA60", VA = "0x78BA60")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x78BBD0", Offset = "0x78BBD0", VA = "0x78BBD0")]
		public RunnerPlayer()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class SwitchInput : MonoBehaviour
	{
		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject InputStandard;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject InputNew;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x78BBEC", Offset = "0x78BBEC", VA = "0x78BBEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x78BC5C", Offset = "0x78BC5C", VA = "0x78BC5C")]
		public SwitchInput()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class TeamCollision : MonoBehaviour
	{
		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int teamID;

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x78BC64", Offset = "0x78BC64", VA = "0x78BC64")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x78BF8C", Offset = "0x78BF8C", VA = "0x78BF8C")]
		public TeamCollision()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	[ExecuteAlways]
	public class TransformDynamicPosition : MonoBehaviour
	{
		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvedWorldController curvedWorldController;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform parent;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool recalculateRotation;

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x78BF94", Offset = "0x78BF94", VA = "0x78BF94")]
		private void Start()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x78C040", Offset = "0x78C040", VA = "0x78C040")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x78C230", Offset = "0x78C230", VA = "0x78C230")]
		public TransformDynamicPosition()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class TransformStaticPosition : MonoBehaviour
	{
		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvedWorldController curvedWorldController;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 originalPosition;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion originalRotation;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 forward;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 right;

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x78C238", Offset = "0x78C238", VA = "0x78C238")]
		private void Start()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x78C2C8", Offset = "0x78C2C8", VA = "0x78C2C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x78C3D8", Offset = "0x78C3D8", VA = "0x78C3D8")]
		public TransformStaticPosition()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class WalkingAround : MonoBehaviour
	{
		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 xMinMaxRange;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 zMinMaxRange;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private NavMeshAgent agent;

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x78C3E0", Offset = "0x78C3E0", VA = "0x78C3E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x78C438", Offset = "0x78C438", VA = "0x78C438")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x78C52C", Offset = "0x78C52C", VA = "0x78C52C")]
		public WalkingAround()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class ShellExplosion : MonoBehaviour
	{
		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask m_TankMask;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem m_ExplosionParticles;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource m_ExplosionAudio;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_MaxDamage;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m_ExplosionForce;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m_MaxLifeTime;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float m_ExplosionRadius;

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x78C534", Offset = "0x78C534", VA = "0x78C534")]
		private void Start()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x78C5B0", Offset = "0x78C5B0", VA = "0x78C5B0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x78C7E0", Offset = "0x78C7E0", VA = "0x78C7E0")]
		public ShellExplosion()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class TankMovement : MonoBehaviour
	{
		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int playerID;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m_Speed;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_TurnSpeed;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem[] m_particleSystems;

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x78C7F4", Offset = "0x78C7F4", VA = "0x78C7F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x78C84C", Offset = "0x78C84C", VA = "0x78C84C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x78C904", Offset = "0x78C904", VA = "0x78C904")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x78C978", Offset = "0x78C978", VA = "0x78C978")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x78C990", Offset = "0x78C990", VA = "0x78C990")]
		private void Move()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x78CA8C", Offset = "0x78CA8C", VA = "0x78CA8C")]
		private void Turn()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x78CBD0", Offset = "0x78CBD0", VA = "0x78CBD0")]
		private bool GetKey(Key key)
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x78CC38", Offset = "0x78CC38", VA = "0x78CC38")]
		public TankMovement()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class TankShooting : MonoBehaviour
	{
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TankMovement tankMovement;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rigidbody m_Shell;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform m_FireTransform;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Slider m_AimSlider;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioSource m_ShootingAudio;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip m_FireClip;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float m_MinLaunchForce;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float m_MaxLaunchForce;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float m_MaxChargeTime;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_CurrentLaunchForce;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_ChargeSpeed;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool m_Fired;

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x78CC54", Offset = "0x78CC54", VA = "0x78CC54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x78CC88", Offset = "0x78CC88", VA = "0x78CC88")]
		private void Start()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x78CCF8", Offset = "0x78CCF8", VA = "0x78CCF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x78CE00", Offset = "0x78CE00", VA = "0x78CE00")]
		private void Fire()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x78CF78", Offset = "0x78CF78", VA = "0x78CF78")]
		public TankShooting()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class UIDirectionControl : MonoBehaviour
	{
		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_UseRelativeRotation;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Quaternion m_RelativeRotation;

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x78CF94", Offset = "0x78CF94", VA = "0x78CF94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x78CFD0", Offset = "0x78CFD0", VA = "0x78CFD0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x78D00C", Offset = "0x78D00C", VA = "0x78D00C")]
		public UIDirectionControl()
		{
		}
	}
}
namespace UnityEngine.PostProcessing
{
	[Token(Token = "0x20000F6")]
	public sealed class GetSetAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string name;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool dirty;

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x78D01C", Offset = "0x78D01C", VA = "0x78D01C")]
		public GetSetAttribute(string name)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public sealed class MinAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly float min;

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x78D04C", Offset = "0x78D04C", VA = "0x78D04C")]
		public MinAttribute(float min)
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public sealed class TrackballAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string method;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x78D074", Offset = "0x78D074", VA = "0x78D074")]
		public TrackballAttribute(string method)
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public sealed class TrackballGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x78D0A4", Offset = "0x78D0A4", VA = "0x78D0A4")]
		public TrackballGroupAttribute()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public sealed class AmbientOcclusionComponent : PostProcessingComponentCommandBuffer<AmbientOcclusionModel>
	{
		[Token(Token = "0x20000FB")]
		private static class Uniforms
		{
			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _Intensity;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _Radius;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _FogParams;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _Downsample;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _SampleCount;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _OcclusionTexture1;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _OcclusionTexture2;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal static readonly int _OcclusionTexture;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal static readonly int _MainTex;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal static readonly int _TempRT;
		}

		[Token(Token = "0x20000FC")]
		private enum OcclusionSource
		{
			[Token(Token = "0x4000633")]
			DepthTexture,
			[Token(Token = "0x4000634")]
			DepthNormalsTexture,
			[Token(Token = "0x4000635")]
			GBuffer
		}

		[Token(Token = "0x4000625")]
		private const string k_BlitShaderString = "Hidden/Post FX/Blit";

		[Token(Token = "0x4000626")]
		private const string k_ShaderString = "Hidden/Post FX/Ambient Occlusion";

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly RenderTargetIdentifier[] m_MRT;

		[Token(Token = "0x1700005B")]
		private OcclusionSource occlusionSource
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x78D0AC", Offset = "0x78D0AC", VA = "0x78D0AC")]
			get
			{
				return default(OcclusionSource);
			}
		}

		[Token(Token = "0x1700005C")]
		private bool ambientOnlySupported
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x78D150", Offset = "0x78D150", VA = "0x78D150")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		public override bool active
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x78D1E0", Offset = "0x78D1E0", VA = "0x78D1E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x78D254", Offset = "0x78D254", VA = "0x78D254", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x78D28C", Offset = "0x78D28C", VA = "0x78D28C", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x78D2CC", Offset = "0x78D2CC", VA = "0x78D2CC", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return default(CameraEvent);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x78D324", Offset = "0x78D324", VA = "0x78D324", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x78DCE8", Offset = "0x78DCE8", VA = "0x78DCE8")]
		public AmbientOcclusionComponent()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public sealed class BloomComponent : PostProcessingComponentRenderTexture<BloomModel>
	{
		[Token(Token = "0x20000FE")]
		private static class Uniforms
		{
			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _AutoExposure;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _Threshold;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _Curve;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _PrefilterOffs;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _SampleScale;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _BaseTex;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _BloomTex;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal static readonly int _Bloom_Settings;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal static readonly int _Bloom_DirtTex;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal static readonly int _Bloom_DirtIntensity;
		}

		[Token(Token = "0x4000636")]
		private const int k_MaxPyramidBlurLevel = 16;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly RenderTexture[] m_BlurBuffer1;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly RenderTexture[] m_BlurBuffer2;

		[Token(Token = "0x1700005E")]
		public override bool active
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x78E020", Offset = "0x78E020", VA = "0x78E020", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x78E094", Offset = "0x78E094", VA = "0x78E094")]
		public void Prepare(RenderTexture source, Material uberMaterial, Texture autoExposure)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x78E9E8", Offset = "0x78E9E8", VA = "0x78E9E8")]
		public BloomComponent()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public sealed class BuiltinDebugViewsComponent : PostProcessingComponentCommandBuffer<BuiltinDebugViewsModel>
	{
		[Token(Token = "0x2000100")]
		private static class Uniforms
		{
			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _DepthScale;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _TempRT;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _Opacity;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _MainTex;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _TempRT2;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _Amplitude;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _Scale;
		}

		[Token(Token = "0x2000101")]
		private enum Pass
		{
			[Token(Token = "0x400064D")]
			Depth,
			[Token(Token = "0x400064E")]
			Normals,
			[Token(Token = "0x400064F")]
			MovecOpacity,
			[Token(Token = "0x4000650")]
			MovecImaging,
			[Token(Token = "0x4000651")]
			MovecArrows
		}

		[Token(Token = "0x2000102")]
		private class ArrowArray
		{
			[Token(Token = "0x17000060")]
			public Mesh mesh
			{
				[Token(Token = "0x6000435")]
				[Address(RVA = "0x78FE38", Offset = "0x78FE38", VA = "0x78FE38")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000436")]
				[Address(RVA = "0x78FE40", Offset = "0x78FE40", VA = "0x78FE40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000061")]
			public int columnCount
			{
				[Token(Token = "0x6000437")]
				[Address(RVA = "0x78FE48", Offset = "0x78FE48", VA = "0x78FE48")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000438")]
				[Address(RVA = "0x78FE50", Offset = "0x78FE50", VA = "0x78FE50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000062")]
			public int rowCount
			{
				[Token(Token = "0x6000439")]
				[Address(RVA = "0x78FE58", Offset = "0x78FE58", VA = "0x78FE58")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600043A")]
				[Address(RVA = "0x78FE60", Offset = "0x78FE60", VA = "0x78FE60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x78F7E8", Offset = "0x78F7E8", VA = "0x78F7E8")]
			public void BuildMesh(int columns, int rows)
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x78F7C0", Offset = "0x78F7C0", VA = "0x78F7C0")]
			public void Release()
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x78F7B8", Offset = "0x78F7B8", VA = "0x78F7B8")]
			public ArrowArray()
			{
			}
		}

		[Token(Token = "0x4000643")]
		private const string k_ShaderString = "Hidden/Post FX/Builtin Debug Views";

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ArrowArray m_Arrows;

		[Token(Token = "0x1700005F")]
		public override bool active
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x78EC98", Offset = "0x78EC98", VA = "0x78EC98", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x78ED24", Offset = "0x78ED24", VA = "0x78ED24", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x78ED8C", Offset = "0x78ED8C", VA = "0x78ED8C", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return default(CameraEvent);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x78EDE4", Offset = "0x78EDE4", VA = "0x78EDE4", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x78EE24", Offset = "0x78EE24", VA = "0x78EE24", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x78EF44", Offset = "0x78EF44", VA = "0x78EF44")]
		private void DepthPass(CommandBuffer cb)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x78F05C", Offset = "0x78F05C", VA = "0x78F05C")]
		private void DepthNormalsPass(CommandBuffer cb)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x78F120", Offset = "0x78F120", VA = "0x78F120")]
		private void MotionVectorsPass(CommandBuffer cb)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x78F6A8", Offset = "0x78F6A8", VA = "0x78F6A8")]
		private void PrepareArrows()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x78FC20", Offset = "0x78FC20", VA = "0x78FC20", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x78FC68", Offset = "0x78FC68", VA = "0x78FC68")]
		public BuiltinDebugViewsComponent()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public sealed class ChromaticAberrationComponent : PostProcessingComponentRenderTexture<ChromaticAberrationModel>
	{
		[Token(Token = "0x2000104")]
		private static class Uniforms
		{
			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _ChromaticAberration_Amount;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _ChromaticAberration_Spectrum;
		}

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Texture2D m_SpectrumLut;

		[Token(Token = "0x17000063")]
		public override bool active
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x78FE68", Offset = "0x78FE68", VA = "0x78FE68", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x78FEDC", Offset = "0x78FEDC", VA = "0x78FEDC", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x78FF04", Offset = "0x78FF04", VA = "0x78FF04", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x79018C", Offset = "0x79018C", VA = "0x79018C")]
		public ChromaticAberrationComponent()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public sealed class ColorGradingComponent : PostProcessingComponentRenderTexture<ColorGradingModel>
	{
		[Token(Token = "0x2000106")]
		private static class Uniforms
		{
			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _LutParams;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _NeutralTonemapperParams1;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _NeutralTonemapperParams2;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _HueShift;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _Saturation;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _Contrast;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _Balance;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal static readonly int _Lift;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal static readonly int _InvGamma;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal static readonly int _Gain;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal static readonly int _Slope;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal static readonly int _Power;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal static readonly int _Offset;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal static readonly int _ChannelMixerRed;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal static readonly int _ChannelMixerGreen;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal static readonly int _ChannelMixerBlue;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal static readonly int _Curves;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal static readonly int _LogLut;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal static readonly int _LogLut_Params;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal static readonly int _ExposureEV;
		}

		[Token(Token = "0x4000658")]
		private const int k_InternalLogLutSize = 32;

		[Token(Token = "0x4000659")]
		private const int k_CurvePrecision = 128;

		[Token(Token = "0x400065A")]
		private const float k_CurveStep = 1f / 128f;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Texture2D m_GradingCurves;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] m_pixels;

		[Token(Token = "0x17000064")]
		public override bool active
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x790270", Offset = "0x790270", VA = "0x790270", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x7902D8", Offset = "0x7902D8", VA = "0x7902D8")]
		private float StandardIlluminantY(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x790304", Offset = "0x790304", VA = "0x790304")]
		private Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x790394", Offset = "0x790394", VA = "0x790394")]
		private Vector3 CalculateColorBalance(float temperature, float tint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x790498", Offset = "0x790498", VA = "0x790498")]
		private static Color NormalizeColor(Color c)
		{
			return default(Color);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x790564", Offset = "0x790564", VA = "0x790564")]
		private static Vector3 ClampVector(Vector3 v, float min, float max)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x790598", Offset = "0x790598", VA = "0x790598")]
		public static Vector3 GetLiftValue(Color lift)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x79061C", Offset = "0x79061C", VA = "0x79061C")]
		public static Vector3 GetGammaValue(Color gamma)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x790700", Offset = "0x790700", VA = "0x790700")]
		public static Vector3 GetGainValue(Color gain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x7907B8", Offset = "0x7907B8", VA = "0x7907B8")]
		public static void CalculateLiftGammaGain(Color lift, Color gamma, Color gain, out Vector3 outLift, out Vector3 outGamma, out Vector3 outGain)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x790854", Offset = "0x790854", VA = "0x790854")]
		public static Vector3 GetSlopeValue(Color slope)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x7908F0", Offset = "0x7908F0", VA = "0x7908F0")]
		public static Vector3 GetPowerValue(Color power)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x7909A8", Offset = "0x7909A8", VA = "0x7909A8")]
		public static Vector3 GetOffsetValue(Color offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x790A3C", Offset = "0x790A3C", VA = "0x790A3C")]
		public static void CalculateSlopePowerOffset(Color slope, Color power, Color offset, out Vector3 outSlope, out Vector3 outPower, out Vector3 outOffset)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x790AD8", Offset = "0x790AD8", VA = "0x790AD8")]
		private TextureFormat GetCurveFormat()
		{
			return default(TextureFormat);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x790B00", Offset = "0x790B00", VA = "0x790B00")]
		private Texture2D GetCurveTexture()
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x790E34", Offset = "0x790E34", VA = "0x790E34")]
		private bool IsLogLutValid(RenderTexture lut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x790ED0", Offset = "0x790ED0", VA = "0x790ED0")]
		private RenderTextureFormat GetLutFormat()
		{
			return default(RenderTextureFormat);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x790EF4", Offset = "0x790EF4", VA = "0x790EF4")]
		private void GenerateLut()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x791690", Offset = "0x791690", VA = "0x791690", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x791870", Offset = "0x791870", VA = "0x791870")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x791990", Offset = "0x791990", VA = "0x791990", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x791A14", Offset = "0x791A14", VA = "0x791A14")]
		public ColorGradingComponent()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public sealed class DepthOfFieldComponent : PostProcessingComponentRenderTexture<DepthOfFieldModel>
	{
		[Token(Token = "0x2000108")]
		private static class Uniforms
		{
			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _DepthOfFieldTex;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _DepthOfFieldCoCTex;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _Distance;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _LensCoeff;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _MaxCoC;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _RcpMaxCoC;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _RcpAspect;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal static readonly int _MainTex;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal static readonly int _CoCTex;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal static readonly int _TaaParams;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal static readonly int _DepthOfFieldParams;
		}

		[Token(Token = "0x4000671")]
		private const string k_ShaderString = "Hidden/Post FX/Depth Of Field";

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RenderTexture m_CoCHistory;

		[Token(Token = "0x4000673")]
		private const float k_FilmHeight = 0.024f;

		[Token(Token = "0x17000065")]
		public override bool active
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x791E60", Offset = "0x791E60", VA = "0x791E60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x791EC8", Offset = "0x791EC8", VA = "0x791EC8", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x791ED0", Offset = "0x791ED0", VA = "0x791ED0")]
		private float CalculateFocalLength()
		{
			return default(float);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x791F6C", Offset = "0x791F6C", VA = "0x791F6C")]
		private float CalculateMaxCoCRadius(int screenHeight)
		{
			return default(float);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x791FE0", Offset = "0x791FE0", VA = "0x791FE0")]
		private bool CheckHistory(int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x7920B0", Offset = "0x7920B0", VA = "0x7920B0")]
		private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
		{
			return default(RenderTextureFormat);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x7920FC", Offset = "0x7920FC", VA = "0x7920FC")]
		public void Prepare(RenderTexture source, Material uberMaterial, bool antialiasCoC, Vector2 taaJitter, float taaBlending)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x79282C", Offset = "0x79282C", VA = "0x79282C", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x7928AC", Offset = "0x7928AC", VA = "0x7928AC")]
		public DepthOfFieldComponent()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public sealed class DitheringComponent : PostProcessingComponentRenderTexture<DitheringModel>
	{
		[Token(Token = "0x200010A")]
		private static class Uniforms
		{
			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _DitheringTex;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _DitheringCoords;
		}

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Texture2D[] noiseTextures;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int textureIndex;

		[Token(Token = "0x4000681")]
		private const int k_TextureCount = 64;

		[Token(Token = "0x17000066")]
		public override bool active
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x792B34", Offset = "0x792B34", VA = "0x792B34", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x792B9C", Offset = "0x792B9C", VA = "0x792B9C", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x792BA8", Offset = "0x792BA8", VA = "0x792BA8")]
		private void LoadNoiseTextures()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x792CD4", Offset = "0x792CD4", VA = "0x792CD4", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x792E74", Offset = "0x792E74", VA = "0x792E74")]
		public DitheringComponent()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public sealed class EyeAdaptationComponent : PostProcessingComponentRenderTexture<EyeAdaptationModel>
	{
		[Token(Token = "0x200010C")]
		private static class Uniforms
		{
			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _Params;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _Speed;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _ScaleOffsetRes;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _ExposureCompensation;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _AutoExposure;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _DebugWidth;
		}

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ComputeShader m_EyeCompute;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ComputeBuffer m_HistogramBuffer;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly RenderTexture[] m_AutoExposurePool;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_AutoExposurePingPing;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_CurrentAutoExposure;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_DebugHistogram;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint[] s_EmptyHistogramBuffer;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_FirstFrame;

		[Token(Token = "0x400068C")]
		private const int k_HistogramBins = 64;

		[Token(Token = "0x400068D")]
		private const int k_HistogramThreadX = 16;

		[Token(Token = "0x400068E")]
		private const int k_HistogramThreadY = 16;

		[Token(Token = "0x17000067")]
		public override bool active
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x792F58", Offset = "0x792F58", VA = "0x792F58", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x792FCC", Offset = "0x792FCC", VA = "0x792FCC")]
		public void ResetHistory()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x792FD8", Offset = "0x792FD8", VA = "0x792FD8", Slot = "6")]
		public override void OnEnable()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x792FE4", Offset = "0x792FE4", VA = "0x792FE4", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x7930E0", Offset = "0x7930E0", VA = "0x7930E0")]
		private Vector4 GetHistogramScaleOffsetRes()
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x7931A0", Offset = "0x7931A0", VA = "0x7931A0")]
		public Texture Prepare(RenderTexture source, Material uberMaterial)
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x793C34", Offset = "0x793C34", VA = "0x793C34")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x793D9C", Offset = "0x793D9C", VA = "0x793D9C")]
		public EyeAdaptationComponent()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public sealed class FogComponent : PostProcessingComponentCommandBuffer<FogModel>
	{
		[Token(Token = "0x200010E")]
		private static class Uniforms
		{
			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _FogColor;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _Density;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _Start;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _End;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _TempRT;
		}

		[Token(Token = "0x4000695")]
		private const string k_ShaderString = "Hidden/Post FX/Fog";

		[Token(Token = "0x17000068")]
		public override bool active
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x793F80", Offset = "0x793F80", VA = "0x793F80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x794008", Offset = "0x794008", VA = "0x794008", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x794048", Offset = "0x794048", VA = "0x794048", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x794050", Offset = "0x794050", VA = "0x794050", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return default(CameraEvent);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x794058", Offset = "0x794058", VA = "0x794058", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x7944CC", Offset = "0x7944CC", VA = "0x7944CC")]
		public FogComponent()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public sealed class FxaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
	{
		[Token(Token = "0x2000110")]
		private static class Uniforms
		{
			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _QualitySettings;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _ConsoleSettings;
		}

		[Token(Token = "0x17000069")]
		public override bool active
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x79463C", Offset = "0x79463C", VA = "0x79463C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x7946AC", Offset = "0x7946AC", VA = "0x7946AC")]
		public void Render(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x7948AC", Offset = "0x7948AC", VA = "0x7948AC")]
		public FxaaComponent()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public sealed class GrainComponent : PostProcessingComponentRenderTexture<GrainModel>
	{
		[Token(Token = "0x2000112")]
		private static class Uniforms
		{
			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _Grain_Params1;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _Grain_Params2;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _GrainTex;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _Phase;
		}

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RenderTexture m_GrainLookupRT;

		[Token(Token = "0x1700006A")]
		public override bool active
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x794990", Offset = "0x794990", VA = "0x794990", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x794A14", Offset = "0x794A14", VA = "0x794A14", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x794A3C", Offset = "0x794A3C", VA = "0x794A3C", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x794DDC", Offset = "0x794DDC", VA = "0x794DDC")]
		public GrainComponent()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public sealed class MotionBlurComponent : PostProcessingComponentCommandBuffer<MotionBlurModel>
	{
		[Token(Token = "0x2000114")]
		private static class Uniforms
		{
			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _VelocityScale;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _MaxBlurRadius;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _RcpMaxBlurRadius;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _VelocityTex;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _MainTex;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _Tile2RT;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _Tile4RT;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal static readonly int _Tile8RT;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal static readonly int _TileMaxOffs;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal static readonly int _TileMaxLoop;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal static readonly int _TileVRT;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal static readonly int _NeighborMaxTex;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal static readonly int _LoopCount;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal static readonly int _TempRT;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal static readonly int _History1LumaTex;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal static readonly int _History2LumaTex;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal static readonly int _History3LumaTex;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal static readonly int _History4LumaTex;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal static readonly int _History1ChromaTex;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal static readonly int _History2ChromaTex;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal static readonly int _History3ChromaTex;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal static readonly int _History4ChromaTex;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal static readonly int _History1Weight;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal static readonly int _History2Weight;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal static readonly int _History3Weight;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal static readonly int _History4Weight;
		}

		[Token(Token = "0x2000115")]
		private enum Pass
		{
			[Token(Token = "0x40006C0")]
			VelocitySetup,
			[Token(Token = "0x40006C1")]
			TileMax1,
			[Token(Token = "0x40006C2")]
			TileMax2,
			[Token(Token = "0x40006C3")]
			TileMaxV,
			[Token(Token = "0x40006C4")]
			NeighborMax,
			[Token(Token = "0x40006C5")]
			Reconstruction,
			[Token(Token = "0x40006C6")]
			FrameCompression,
			[Token(Token = "0x40006C7")]
			FrameBlendingChroma,
			[Token(Token = "0x40006C8")]
			FrameBlendingRaw
		}

		[Token(Token = "0x2000116")]
		public class ReconstructionFilter
		{
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private RenderTextureFormat m_VectorRTFormat;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private RenderTextureFormat m_PackedRTFormat;

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x794F94", Offset = "0x794F94", VA = "0x794F94")]
			public ReconstructionFilter()
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x796688", Offset = "0x796688", VA = "0x796688")]
			private void CheckTextureFormatSupport()
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x795100", Offset = "0x795100", VA = "0x795100")]
			public bool IsSupported()
			{
				return default(bool);
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x795840", Offset = "0x795840", VA = "0x795840")]
			public void ProcessImage(PostProcessingContext context, CommandBuffer cb, ref MotionBlurModel.Settings settings, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material)
			{
			}
		}

		[Token(Token = "0x2000117")]
		public class FrameBlendingFilter
		{
			[Token(Token = "0x2000118")]
			private struct Frame
			{
				[Token(Token = "0x40006CF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public RenderTexture lumaTexture;

				[Token(Token = "0x40006D0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public RenderTexture chromaTexture;

				[Token(Token = "0x40006D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private float m_Time;

				[Token(Token = "0x40006D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private RenderTargetIdentifier[] m_MRT;

				[Token(Token = "0x600049B")]
				[Address(RVA = "0x79742C", Offset = "0x79742C", VA = "0x79742C")]
				public float CalculateWeight(float strength, float currentTime)
				{
					return default(float);
				}

				[Token(Token = "0x600049C")]
				[Address(RVA = "0x796898", Offset = "0x796898", VA = "0x796898")]
				public void Release()
				{
				}

				[Token(Token = "0x600049D")]
				[Address(RVA = "0x796A88", Offset = "0x796A88", VA = "0x796A88")]
				public void MakeRecord(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material)
				{
				}

				[Token(Token = "0x600049E")]
				[Address(RVA = "0x796D74", Offset = "0x796D74", VA = "0x796D74")]
				public void MakeRecordRaw(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, RenderTextureFormat format)
				{
				}
			}

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool m_UseCompression;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private RenderTextureFormat m_RawTextureFormat;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Frame[] m_FrameList;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_LastFrameCount;

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x7966AC", Offset = "0x7966AC", VA = "0x7966AC")]
			public FrameBlendingFilter()
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x796824", Offset = "0x796824", VA = "0x796824")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x796968", Offset = "0x796968", VA = "0x796968")]
			public void PushFrame(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material)
			{
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x796EE4", Offset = "0x796EE4", VA = "0x796EE4")]
			public void BlendFrames(CommandBuffer cb, float strength, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x796724", Offset = "0x796724", VA = "0x796724")]
			private static bool CheckSupportCompression()
			{
				return default(bool);
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x796758", Offset = "0x796758", VA = "0x796758")]
			private static RenderTextureFormat GetPreferredRenderTextureFormat()
			{
				return default(RenderTextureFormat);
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x7973C8", Offset = "0x7973C8", VA = "0x7973C8")]
			private Frame GetFrameRelative(int offset)
			{
				return default(Frame);
			}
		}

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ReconstructionFilter m_ReconstructionFilter;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FrameBlendingFilter m_FrameBlendingFilter;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_FirstFrame;

		[Token(Token = "0x1700006B")]
		public ReconstructionFilter reconstructionFilter
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x794F20", Offset = "0x794F20", VA = "0x794F20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public FrameBlendingFilter frameBlendingFilter
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x794FCC", Offset = "0x794FCC", VA = "0x794FCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public override bool active
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x795044", Offset = "0x795044", VA = "0x795044", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x795108", Offset = "0x795108", VA = "0x795108", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x795148", Offset = "0x795148", VA = "0x795148")]
		public void ResetHistory()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x795174", Offset = "0x795174", VA = "0x795174", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x79517C", Offset = "0x79517C", VA = "0x79517C", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return default(CameraEvent);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x795184", Offset = "0x795184", VA = "0x795184", Slot = "6")]
		public override void OnEnable()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x795190", Offset = "0x795190", VA = "0x795190", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x796150", Offset = "0x796150", VA = "0x796150", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x796164", Offset = "0x796164", VA = "0x796164")]
		public MotionBlurComponent()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public sealed class ScreenSpaceReflectionComponent : PostProcessingComponentCommandBuffer<ScreenSpaceReflectionModel>
	{
		[Token(Token = "0x200011A")]
		private static class Uniforms
		{
			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _RayStepSize;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _AdditiveReflection;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _BilateralUpsampling;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _TreatBackfaceHitAsMiss;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _AllowBackwardsRays;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _TraceBehindObjects;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _MaxSteps;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal static readonly int _FullResolutionFiltering;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal static readonly int _HalfResolution;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal static readonly int _HighlightSuppression;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal static readonly int _PixelsPerMeterAtOneMeter;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal static readonly int _ScreenEdgeFading;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal static readonly int _ReflectionBlur;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal static readonly int _MaxRayTraceDistance;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal static readonly int _FadeDistance;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal static readonly int _LayerThickness;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal static readonly int _SSRMultiplier;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal static readonly int _FresnelFade;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal static readonly int _FresnelFadePower;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal static readonly int _ReflectionBufferSize;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal static readonly int _ScreenSize;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal static readonly int _InvScreenSize;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal static readonly int _ProjInfo;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal static readonly int _CameraClipInfo;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal static readonly int _ProjectToPixelMatrix;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal static readonly int _WorldToCameraMatrix;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal static readonly int _CameraToWorldMatrix;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			internal static readonly int _Axis;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal static readonly int _CurrentMipLevel;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			internal static readonly int _NormalAndRoughnessTexture;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal static readonly int _HitPointTexture;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			internal static readonly int _BlurTexture;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal static readonly int _FilteredReflections;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			internal static readonly int _FinalReflectionTexture;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			internal static readonly int _TempTexture;
		}

		[Token(Token = "0x200011B")]
		private enum PassIndex
		{
			[Token(Token = "0x40006FC")]
			RayTraceStep,
			[Token(Token = "0x40006FD")]
			CompositeFinal,
			[Token(Token = "0x40006FE")]
			Blur,
			[Token(Token = "0x40006FF")]
			CompositeSSR,
			[Token(Token = "0x4000700")]
			MinMipGeneration,
			[Token(Token = "0x4000701")]
			HitPointToReflections,
			[Token(Token = "0x4000702")]
			BilateralKeyPack,
			[Token(Token = "0x4000703")]
			BlitDepthAsCSZ,
			[Token(Token = "0x4000704")]
			PoissonBlur
		}

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool k_HighlightSuppression;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool k_TraceBehindObjects;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private bool k_TreatBackfaceHitAsMiss;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		private bool k_BilateralUpsample;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly int[] m_ReflectionTextures;

		[Token(Token = "0x1700006E")]
		public override bool active
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x79778C", Offset = "0x79778C", VA = "0x79778C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x797784", Offset = "0x797784", VA = "0x797784", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x79782C", Offset = "0x79782C", VA = "0x79782C", Slot = "6")]
		public override void OnEnable()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x797974", Offset = "0x797974", VA = "0x797974", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x7979B4", Offset = "0x7979B4", VA = "0x7979B4", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return default(CameraEvent);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x7979BC", Offset = "0x7979BC", VA = "0x7979BC", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x798C38", Offset = "0x798C38", VA = "0x798C38")]
		public ScreenSpaceReflectionComponent()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public sealed class TaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
	{
		[Token(Token = "0x200011D")]
		private static class Uniforms
		{
			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static int _Jitter;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static int _SharpenParameters;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static int _FinalBlendParameters;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static int _HistoryTex;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static int _MainTex;
		}

		[Token(Token = "0x4000705")]
		private const string k_ShaderString = "Hidden/Post FX/Temporal Anti-aliasing";

		[Token(Token = "0x4000706")]
		private const int k_SampleCount = 8;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly RenderBuffer[] m_MRT;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_SampleIndex;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_ResetHistory;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture m_HistoryTexture;

		[Token(Token = "0x1700006F")]
		public override bool active
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x799324", Offset = "0x799324", VA = "0x799324", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		public Vector2 jitterVector
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x7993BC", Offset = "0x7993BC", VA = "0x7993BC")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x7993C4", Offset = "0x7993C4", VA = "0x7993C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x7993B4", Offset = "0x7993B4", VA = "0x7993B4", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x7993CC", Offset = "0x7993CC", VA = "0x7993CC")]
		public void ResetHistory()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x7993D8", Offset = "0x7993D8", VA = "0x7993D8")]
		public void SetProjectionMatrix(Func<Vector2, Matrix4x4> jitteredFunc)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x799C94", Offset = "0x799C94", VA = "0x799C94")]
		public void Render(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x79A1D4", Offset = "0x79A1D4", VA = "0x79A1D4")]
		private float GetHaltonValue(int index, int radix)
		{
			return default(float);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x799670", Offset = "0x799670", VA = "0x799670")]
		private Vector2 GenerateRandomOffset()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x799704", Offset = "0x799704", VA = "0x799704")]
		private Matrix4x4 GetPerspectiveProjectionMatrix(Vector2 offset)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x799B38", Offset = "0x799B38", VA = "0x799B38")]
		private Matrix4x4 GetOrthographicProjectionMatrix(Vector2 offset)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x79A218", Offset = "0x79A218", VA = "0x79A218", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x79A2B4", Offset = "0x79A2B4", VA = "0x79A2B4")]
		public TaaComponent()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public sealed class UserLutComponent : PostProcessingComponentRenderTexture<UserLutModel>
	{
		[Token(Token = "0x200011F")]
		private static class Uniforms
		{
			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _UserLut;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _UserLut_Params;
		}

		[Token(Token = "0x17000071")]
		public override bool active
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x79A464", Offset = "0x79A464", VA = "0x79A464", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x79A570", Offset = "0x79A570", VA = "0x79A570", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x79A6B0", Offset = "0x79A6B0", VA = "0x79A6B0")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x79A7F4", Offset = "0x79A7F4", VA = "0x79A7F4")]
		public UserLutComponent()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public sealed class VignetteComponent : PostProcessingComponentRenderTexture<VignetteModel>
	{
		[Token(Token = "0x2000121")]
		private static class Uniforms
		{
			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _Vignette_Color;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _Vignette_Center;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _Vignette_Settings;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _Vignette_Mask;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _Vignette_Opacity;
		}

		[Token(Token = "0x17000072")]
		public override bool active
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x79A8D8", Offset = "0x79A8D8", VA = "0x79A8D8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x79A940", Offset = "0x79A940", VA = "0x79A940", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x79ABD4", Offset = "0x79ABD4", VA = "0x79ABD4")]
		public VignetteComponent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000122")]
	public class AmbientOcclusionModel : PostProcessingModel
	{
		[Token(Token = "0x2000123")]
		public enum SampleCount
		{
			[Token(Token = "0x400071A")]
			Lowest = 3,
			[Token(Token = "0x400071B")]
			Low = 6,
			[Token(Token = "0x400071C")]
			Medium = 10,
			[Token(Token = "0x400071D")]
			High = 16
		}

		[Serializable]
		[Token(Token = "0x2000124")]
		public struct Settings
		{
			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Degree of darkness produced by the effect.")]
			[Range(0f, 4f)]
			public float intensity;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Min(0.0001f)]
			[Tooltip("Radius of sample points, which affects extent of darkened areas.")]
			public float radius;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Number of sample points, which affects quality and performance.")]
			public SampleCount sampleCount;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Tooltip("Halves the resolution of the effect to increase performance at the cost of visual quality.")]
			public bool downsampling;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			[Tooltip("Forces compatibility with Forward rendered objects when working with the Deferred rendering path.")]
			public bool forceForwardCompatibility;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			[Tooltip("Enables the ambient-only mode in that the effect only affects ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering.")]
			public bool ambientOnly;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			[Tooltip("Toggles the use of a higher precision depth texture with the forward rendering path (may impact performances). Has no effect with the deferred rendering path.")]
			public bool highPrecision;

			[Token(Token = "0x17000074")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004C2")]
				[Address(RVA = "0x79AD70", Offset = "0x79AD70", VA = "0x79AD70")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000073")]
		public Settings settings
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x79AD44", Offset = "0x79AD44", VA = "0x79AD44")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x79AD54", Offset = "0x79AD54", VA = "0x79AD54")]
			set
			{
			}
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x79AD60", Offset = "0x79AD60", VA = "0x79AD60", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x79AD88", Offset = "0x79AD88", VA = "0x79AD88")]
		public AmbientOcclusionModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000125")]
	public class AntialiasingModel : PostProcessingModel
	{
		[Token(Token = "0x2000126")]
		public enum Method
		{
			[Token(Token = "0x4000727")]
			Fxaa,
			[Token(Token = "0x4000728")]
			Taa
		}

		[Token(Token = "0x2000127")]
		public enum FxaaPreset
		{
			[Token(Token = "0x400072A")]
			ExtremePerformance,
			[Token(Token = "0x400072B")]
			Performance,
			[Token(Token = "0x400072C")]
			Default,
			[Token(Token = "0x400072D")]
			Quality,
			[Token(Token = "0x400072E")]
			ExtremeQuality
		}

		[Serializable]
		[Token(Token = "0x2000128")]
		public struct FxaaQualitySettings
		{
			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
			[Range(0f, 1f)]
			public float subpixelAliasingRemovalAmount;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(0.063f, 0.333f)]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			public float edgeDetectionThreshold;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Range(0f, 0.0833f)]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			public float minimumRequiredLuminance;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static FxaaQualitySettings[] presets;
		}

		[Serializable]
		[Token(Token = "0x2000129")]
		public struct FxaaConsoleSettings
		{
			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
			[Range(0.33f, 0.5f)]
			public float subpixelSpreadAmount;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
			[Range(2f, 8f)]
			public float edgeSharpnessAmount;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			[Range(0.125f, 0.25f)]
			public float edgeDetectionThreshold;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[Range(0.04f, 0.06f)]
			public float minimumRequiredLuminance;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static FxaaConsoleSettings[] presets;
		}

		[Serializable]
		[Token(Token = "0x200012A")]
		public struct FxaaSettings
		{
			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FxaaPreset preset;

			[Token(Token = "0x17000076")]
			public static FxaaSettings defaultSettings
			{
				[Token(Token = "0x60004C9")]
				[Address(RVA = "0x79B018", Offset = "0x79B018", VA = "0x79B018")]
				get
				{
					return default(FxaaSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200012B")]
		public struct TaaSettings
		{
			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Range(0.1f, 1f)]
			[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable but blurrier output.")]
			public float jitterSpread;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Tooltip("Controls the amount of sharpening applied to the color buffer.")]
			[Range(0f, 3f)]
			public float sharpen;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
			[Range(0f, 0.99f)]
			public float stationaryBlending;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
			[Range(0f, 0.99f)]
			public float motionBlending;

			[Token(Token = "0x17000077")]
			public static TaaSettings defaultSettings
			{
				[Token(Token = "0x60004CA")]
				[Address(RVA = "0x79B020", Offset = "0x79B020", VA = "0x79B020")]
				get
				{
					return default(TaaSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200012C")]
		public struct Settings
		{
			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Method method;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public FxaaSettings fxaaSettings;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public TaaSettings taaSettings;

			[Token(Token = "0x17000078")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004CB")]
				[Address(RVA = "0x79ADE8", Offset = "0x79ADE8", VA = "0x79ADE8")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000075")]
		public Settings settings
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x79ADA4", Offset = "0x79ADA4", VA = "0x79ADA4")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x79ADB8", Offset = "0x79ADB8", VA = "0x79ADB8")]
			set
			{
			}
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x79ADCC", Offset = "0x79ADCC", VA = "0x79ADCC", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x79AE04", Offset = "0x79AE04", VA = "0x79AE04")]
		public AntialiasingModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012D")]
	public class BloomModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x200012E")]
		public struct BloomSettings
		{
			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Min(0f)]
			[Tooltip("Strength of the bloom filter.")]
			public float intensity;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Tooltip("Filters out pixels under this level of brightness.")]
			[Min(0f)]
			public float threshold;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Range(0f, 1f)]
			[Tooltip("Makes transition between under/over-threshold gradual (0 = hard threshold, 1 = soft threshold).")]
			public float softKnee;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Range(1f, 7f)]
			[Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
			public float radius;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Reduces flashing noise with an additional filter.")]
			public bool antiFlicker;

			[Token(Token = "0x1700007A")]
			public float thresholdLinear
			{
				[Token(Token = "0x60004D1")]
				[Address(RVA = "0x79B198", Offset = "0x79B198", VA = "0x79B198")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004D0")]
				[Address(RVA = "0x79B17C", Offset = "0x79B17C", VA = "0x79B17C")]
				set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			public static BloomSettings defaultSettings
			{
				[Token(Token = "0x60004D2")]
				[Address(RVA = "0x79B1A4", Offset = "0x79B1A4", VA = "0x79B1A4")]
				get
				{
					return default(BloomSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200012F")]
		public struct LensDirtSettings
		{
			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Dirtiness texture to add smudges or dust to the lens.")]
			public Texture texture;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Min(0f)]
			[Tooltip("Amount of lens dirtiness.")]
			public float intensity;

			[Token(Token = "0x1700007C")]
			public static LensDirtSettings defaultSettings
			{
				[Token(Token = "0x60004D3")]
				[Address(RVA = "0x79B1C0", Offset = "0x79B1C0", VA = "0x79B1C0")]
				get
				{
					return default(LensDirtSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000130")]
		public struct Settings
		{
			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BloomSettings bloom;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LensDirtSettings lensDirt;

			[Token(Token = "0x1700007D")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004D4")]
				[Address(RVA = "0x79B0BC", Offset = "0x79B0BC", VA = "0x79B0BC")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000079")]
		public Settings settings
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x79B040", Offset = "0x79B040", VA = "0x79B040")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x79B058", Offset = "0x79B058", VA = "0x79B058")]
			set
			{
			}
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x79B07C", Offset = "0x79B07C", VA = "0x79B07C", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x79B130", Offset = "0x79B130", VA = "0x79B130")]
		public BloomModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000131")]
	public class BuiltinDebugViewsModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x2000132")]
		public struct DepthSettings
		{
			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Range(0f, 1f)]
			[Tooltip("Scales the camera far plane before displaying the depth map.")]
			public float scale;

			[Token(Token = "0x17000080")]
			public static DepthSettings defaultSettings
			{
				[Token(Token = "0x60004DB")]
				[Address(RVA = "0x79B2C0", Offset = "0x79B2C0", VA = "0x79B2C0")]
				get
				{
					return default(DepthSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000133")]
		public struct MotionVectorsSettings
		{
			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Range(0f, 1f)]
			[Tooltip("Opacity of the source render.")]
			public float sourceOpacity;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Tooltip("Opacity of the per-pixel motion vector colors.")]
			[Range(0f, 1f)]
			public float motionImageOpacity;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Min(0f)]
			[Tooltip("Because motion vectors are mainly very small vectors, you can use this setting to make them more visible.")]
			public float motionImageAmplitude;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Range(0f, 1f)]
			[Tooltip("Opacity for the motion vector arrows.")]
			public float motionVectorsOpacity;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(8f, 64f)]
			[Tooltip("The arrow density on screen.")]
			public int motionVectorsResolution;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Min(0f)]
			[Tooltip("Tweaks the arrows length.")]
			public float motionVectorsAmplitude;

			[Token(Token = "0x17000081")]
			public static MotionVectorsSettings defaultSettings
			{
				[Token(Token = "0x60004DC")]
				[Address(RVA = "0x79B2C8", Offset = "0x79B2C8", VA = "0x79B2C8")]
				get
				{
					return default(MotionVectorsSettings);
				}
			}
		}

		[Token(Token = "0x2000134")]
		public enum Mode
		{
			[Token(Token = "0x4000753")]
			None,
			[Token(Token = "0x4000754")]
			Depth,
			[Token(Token = "0x4000755")]
			Normals,
			[Token(Token = "0x4000756")]
			MotionVectors,
			[Token(Token = "0x4000757")]
			AmbientOcclusion,
			[Token(Token = "0x4000758")]
			EyeAdaptation,
			[Token(Token = "0x4000759")]
			FocusPlane,
			[Token(Token = "0x400075A")]
			PreGradingLog,
			[Token(Token = "0x400075B")]
			LogLut,
			[Token(Token = "0x400075C")]
			UserLut
		}

		[Serializable]
		[Token(Token = "0x2000135")]
		public struct Settings
		{
			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Mode mode;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public DepthSettings depth;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MotionVectorsSettings motionVectors;

			[Token(Token = "0x17000082")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004DD")]
				[Address(RVA = "0x79B26C", Offset = "0x79B26C", VA = "0x79B26C")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x1700007E")]
		public Settings settings
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x79B1F0", Offset = "0x79B1F0", VA = "0x79B1F0")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x79B200", Offset = "0x79B200", VA = "0x79B200")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public bool willInterrupt
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x79B210", Offset = "0x79B210", VA = "0x79B210")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x79B244", Offset = "0x79B244", VA = "0x79B244", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x79B234", Offset = "0x79B234", VA = "0x79B234")]
		public bool IsModeActive(Mode mode)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x79B294", Offset = "0x79B294", VA = "0x79B294")]
		public BuiltinDebugViewsModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000136")]
	public class ChromaticAberrationModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x2000137")]
		public struct Settings
		{
			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Shift the hue of chromatic aberrations.")]
			public Texture2D spectralTexture;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Amount of tangential distortion.")]
			[Range(0f, 1f)]
			public float intensity;

			[Token(Token = "0x17000084")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004E2")]
				[Address(RVA = "0x79B34C", Offset = "0x79B34C", VA = "0x79B34C")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000083")]
		public Settings settings
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x79B2E4", Offset = "0x79B2E4", VA = "0x79B2E4")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x79B2F0", Offset = "0x79B2F0", VA = "0x79B2F0")]
			set
			{
			}
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x79B300", Offset = "0x79B300", VA = "0x79B300", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x79B380", Offset = "0x79B380", VA = "0x79B380")]
		public ChromaticAberrationModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000138")]
	public class ColorGradingModel : PostProcessingModel
	{
		[Token(Token = "0x2000139")]
		public enum Tonemapper
		{
			[Token(Token = "0x4000767")]
			None,
			[Token(Token = "0x4000768")]
			ACES,
			[Token(Token = "0x4000769")]
			Neutral
		}

		[Serializable]
		[Token(Token = "0x200013A")]
		public struct TonemappingSettings
		{
			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Tonemapping algorithm to use at the end of the color grading process. Use \"Neutral\" if you need a customizable tonemapper or \"Filmic\" to give a standard filmic look to your scenes.")]
			public Tonemapper tonemapper;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Range(1f, 20f)]
			public float neutralWhiteIn;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(1f, 19f)]
			public float neutralWhiteOut;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(1f, 10f)]
			public float neutralWhiteClip;

			[Token(Token = "0x17000088")]
			public static TonemappingSettings defaultSettings
			{
				[Token(Token = "0x60004EC")]
				[Address(RVA = "0x79B5C4", Offset = "0x79B5C4", VA = "0x79B5C4")]
				get
				{
					return default(TonemappingSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200013B")]
		public struct BasicSettings
		{
			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
			public float postExposure;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Tooltip("Sets the white balance to a custom color temperature.")]
			[Range(-100f, 100f)]
			public float temperature;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			[Range(-100f, 100f)]
			public float tint;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Range(-180f, 180f)]
			[Tooltip("Shift the hue of all colors.")]
			public float hueShift;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Pushes the intensity of all colors.")]
			[Range(0f, 2f)]
			public float saturation;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			[Range(0f, 2f)]
			public float contrast;

			[Token(Token = "0x17000089")]
			public static BasicSettings defaultSettings
			{
				[Token(Token = "0x60004ED")]
				[Address(RVA = "0x79B5EC", Offset = "0x79B5EC", VA = "0x79B5EC")]
				get
				{
					return default(BasicSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200013C")]
		public struct ChannelMixerSettings
		{
			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 red;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 green;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 blue;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[HideInInspector]
			public int currentEditingChannel;

			[Token(Token = "0x1700008A")]
			public static ChannelMixerSettings defaultSettings
			{
				[Token(Token = "0x60004EE")]
				[Address(RVA = "0x79B5FC", Offset = "0x79B5FC", VA = "0x79B5FC")]
				get
				{
					return default(ChannelMixerSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200013D")]
		public struct LogWheelsSettings
		{
			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Trackball("GetSlopeValue")]
			public Color slope;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Trackball("GetPowerValue")]
			public Color power;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Trackball("GetOffsetValue")]
			public Color offset;

			[Token(Token = "0x1700008B")]
			public static LogWheelsSettings defaultSettings
			{
				[Token(Token = "0x60004EF")]
				[Address(RVA = "0x79B614", Offset = "0x79B614", VA = "0x79B614")]
				get
				{
					return default(LogWheelsSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200013E")]
		public struct LinearWheelsSettings
		{
			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Trackball("GetLiftValue")]
			public Color lift;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Trackball("GetGammaValue")]
			public Color gamma;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Trackball("GetGainValue")]
			public Color gain;

			[Token(Token = "0x1700008C")]
			public static LinearWheelsSettings defaultSettings
			{
				[Token(Token = "0x60004F0")]
				[Address(RVA = "0x79B624", Offset = "0x79B624", VA = "0x79B624")]
				get
				{
					return default(LinearWheelsSettings);
				}
			}
		}

		[Token(Token = "0x200013F")]
		public enum ColorWheelMode
		{
			[Token(Token = "0x4000782")]
			Linear,
			[Token(Token = "0x4000783")]
			Log
		}

		[Serializable]
		[Token(Token = "0x2000140")]
		public struct ColorWheelsSettings
		{
			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ColorWheelMode mode;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[TrackballGroup]
			public LogWheelsSettings log;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[TrackballGroup]
			public LinearWheelsSettings linear;

			[Token(Token = "0x1700008D")]
			public static ColorWheelsSettings defaultSettings
			{
				[Token(Token = "0x60004F1")]
				[Address(RVA = "0x79B634", Offset = "0x79B634", VA = "0x79B634")]
				get
				{
					return default(ColorWheelsSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000141")]
		public struct CurvesSettings
		{
			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ColorGradingCurve master;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ColorGradingCurve red;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ColorGradingCurve green;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColorGradingCurve blue;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColorGradingCurve hueVShue;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColorGradingCurve hueVSsat;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ColorGradingCurve satVSsat;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ColorGradingCurve lumVSsat;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[HideInInspector]
			public int e_CurrentEditingCurve;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[HideInInspector]
			public bool e_CurveY;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
			[HideInInspector]
			public bool e_CurveR;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
			[HideInInspector]
			public bool e_CurveG;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
			[HideInInspector]
			public bool e_CurveB;

			[Token(Token = "0x1700008E")]
			public static CurvesSettings defaultSettings
			{
				[Token(Token = "0x60004F2")]
				[Address(RVA = "0x79B65C", Offset = "0x79B65C", VA = "0x79B65C")]
				get
				{
					return default(CurvesSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000142")]
		public struct Settings
		{
			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TonemappingSettings tonemapping;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public BasicSettings basic;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public ChannelMixerSettings channelMixer;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public ColorWheelsSettings colorWheels;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public CurvesSettings curves;

			[Token(Token = "0x1700008F")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004F3")]
				[Address(RVA = "0x79B498", Offset = "0x79B498", VA = "0x79B498")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000085")]
		public Settings settings
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x79B3D8", Offset = "0x79B3D8", VA = "0x79B3D8")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x79B3E8", Offset = "0x79B3E8", VA = "0x79B3E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public bool isDirty
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x79B41C", Offset = "0x79B41C", VA = "0x79B41C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x79B424", Offset = "0x79B424", VA = "0x79B424")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public RenderTexture bakedLut
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x79B430", Offset = "0x79B430", VA = "0x79B430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x79B438", Offset = "0x79B438", VA = "0x79B438")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x79B448", Offset = "0x79B448", VA = "0x79B448", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x79B56C", Offset = "0x79B56C", VA = "0x79B56C", Slot = "5")]
		public override void OnValidate()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x79B578", Offset = "0x79B578", VA = "0x79B578")]
		public ColorGradingModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000143")]
	public class DepthOfFieldModel : PostProcessingModel
	{
		[Token(Token = "0x2000144")]
		public enum KernelSize
		{
			[Token(Token = "0x400079B")]
			Small,
			[Token(Token = "0x400079C")]
			Medium,
			[Token(Token = "0x400079D")]
			Large,
			[Token(Token = "0x400079E")]
			VeryLarge
		}

		[Serializable]
		[Token(Token = "0x2000145")]
		public struct Settings
		{
			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Min(0.1f)]
			[Tooltip("Distance to the point of focus.")]
			public float focusDistance;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(0.05f, 32f)]
			[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
			public float aperture;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Range(1f, 300f)]
			[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
			public float focalLength;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Tooltip("Calculate the focal length automatically from the field-of-view value set on the camera. Using this setting isn't recommended.")]
			public bool useCameraFov;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects the performance (the larger the kernel is, the longer the GPU time is required).")]
			public KernelSize kernelSize;

			[Token(Token = "0x17000091")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004F8")]
				[Address(RVA = "0x79BDC4", Offset = "0x79BDC4", VA = "0x79BDC4")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000090")]
		public Settings settings
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x79BD70", Offset = "0x79BD70", VA = "0x79BD70")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x79BD84", Offset = "0x79BD84", VA = "0x79BD84")]
			set
			{
			}
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x79BD98", Offset = "0x79BD98", VA = "0x79BD98", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x79BDF0", Offset = "0x79BDF0", VA = "0x79BDF0")]
		public DepthOfFieldModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000146")]
	public class DitheringModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x2000147")]
		public struct Settings
		{
			[Token(Token = "0x17000093")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004FD")]
				[Address(RVA = "0x79BE38", Offset = "0x79BE38", VA = "0x79BE38")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000092")]
		public Settings settings
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x79BE20", Offset = "0x79BE20", VA = "0x79BE20")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x79BE28", Offset = "0x79BE28", VA = "0x79BE28")]
			set
			{
			}
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x79BE30", Offset = "0x79BE30", VA = "0x79BE30", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x79BE40", Offset = "0x79BE40", VA = "0x79BE40")]
		public DitheringModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000148")]
	public class EyeAdaptationModel : PostProcessingModel
	{
		[Token(Token = "0x2000149")]
		public enum EyeAdaptationType
		{
			[Token(Token = "0x40007A7")]
			Progressive,
			[Token(Token = "0x40007A8")]
			Fixed
		}

		[Serializable]
		[Token(Token = "0x200014A")]
		public struct Settings
		{
			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Filters the dark part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
			[Range(1f, 99f)]
			public float lowPercent;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(1f, 99f)]
			[Tooltip("Filters the bright part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
			public float highPercent;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Minimum average luminance to consider for auto exposure (in EV).")]
			public float minLuminance;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Tooltip("Maximum average luminance to consider for auto exposure (in EV).")]
			public float maxLuminance;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Min(0f)]
			[Tooltip("Exposure bias. Use this to offset the global exposure of the scene.")]
			public float keyValue;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Set this to true to let Unity handle the key value automatically based on average luminance.")]
			public bool dynamicKeyValue;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Use \"Progressive\" if you want the auto exposure to be animated. Use \"Fixed\" otherwise.")]
			public EyeAdaptationType adaptationType;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Adaptation speed from a dark to a light environment.")]
			[Min(0f)]
			public float speedUp;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Adaptation speed from a light to a dark environment.")]
			[Min(0f)]
			public float speedDown;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Range(-16f, -1f)]
			[Tooltip("Lower bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
			public int logMin;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Range(1f, 16f)]
			[Tooltip("Upper bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
			public int logMax;

			[Token(Token = "0x17000095")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000502")]
				[Address(RVA = "0x79BEC4", Offset = "0x79BEC4", VA = "0x79BEC4")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000094")]
		public Settings settings
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x79BE4C", Offset = "0x79BE4C", VA = "0x79BE4C")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x79BE64", Offset = "0x79BE64", VA = "0x79BE64")]
			set
			{
			}
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x79BE84", Offset = "0x79BE84", VA = "0x79BE84", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x79BF08", Offset = "0x79BF08", VA = "0x79BF08")]
		public EyeAdaptationModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200014B")]
	public class FogModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x200014C")]
		public struct Settings
		{
			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Should the fog affect the skybox?")]
			public bool excludeSkybox;

			[Token(Token = "0x17000097")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000507")]
				[Address(RVA = "0x79BF68", Offset = "0x79BF68", VA = "0x79BF68")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000096")]
		public Settings settings
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x79BF4C", Offset = "0x79BF4C", VA = "0x79BF4C")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x79BF54", Offset = "0x79BF54", VA = "0x79BF54")]
			set
			{
			}
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x79BF5C", Offset = "0x79BF5C", VA = "0x79BF5C", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x79BF70", Offset = "0x79BF70", VA = "0x79BF70")]
		public FogModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200014D")]
	public class GrainModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x200014E")]
		public struct Settings
		{
			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Enable the use of colored grain.")]
			public bool colored;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(0f, 1f)]
			[Tooltip("Grain strength. Higher means more visible grain.")]
			public float intensity;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Grain particle size.")]
			[Range(0.3f, 3f)]
			public float size;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Range(0f, 1f)]
			[Tooltip("Controls the noisiness response curve based on scene luminance. Lower values mean less noise in dark areas.")]
			public float luminanceContribution;

			[Token(Token = "0x17000099")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x600050C")]
				[Address(RVA = "0x79BFAC", Offset = "0x79BFAC", VA = "0x79BFAC")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000098")]
		public Settings settings
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x79BF80", Offset = "0x79BF80", VA = "0x79BF80")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x79BF90", Offset = "0x79BF90", VA = "0x79BF90")]
			set
			{
			}
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x79BF9C", Offset = "0x79BF9C", VA = "0x79BF9C", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x79BFC4", Offset = "0x79BFC4", VA = "0x79BFC4")]
		public GrainModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200014F")]
	public class MotionBlurModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x2000150")]
		public struct Settings
		{
			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Range(0f, 360f)]
			[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
			public float shutterAngle;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(4f, 32f)]
			[Tooltip("The amount of sample points, which affects quality and performances.")]
			public int sampleCount;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Range(0f, 1f)]
			[Tooltip("The strength of multiple frame blending. The opacity of preceding frames are determined from this coefficient and time differences.")]
			public float frameBlending;

			[Token(Token = "0x1700009B")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000511")]
				[Address(RVA = "0x79C008", Offset = "0x79C008", VA = "0x79C008")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x1700009A")]
		public Settings settings
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x79BFD8", Offset = "0x79BFD8", VA = "0x79BFD8")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x79BFE8", Offset = "0x79BFE8", VA = "0x79BFE8")]
			set
			{
			}
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x79BFF4", Offset = "0x79BFF4", VA = "0x79BFF4", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x79C018", Offset = "0x79C018", VA = "0x79C018")]
		public MotionBlurModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000151")]
	public class ScreenSpaceReflectionModel : PostProcessingModel
	{
		[Token(Token = "0x2000152")]
		public enum SSRResolution
		{
			[Token(Token = "0x40007C1")]
			High = 0,
			[Token(Token = "0x40007C2")]
			Low = 2
		}

		[Token(Token = "0x2000153")]
		public enum SSRReflectionBlendType
		{
			[Token(Token = "0x40007C4")]
			PhysicallyBased,
			[Token(Token = "0x40007C5")]
			Additive
		}

		[Serializable]
		[Token(Token = "0x2000154")]
		public struct IntensitySettings
		{
			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Range(0f, 2f)]
			[Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
			public float reflectionMultiplier;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(0f, 1000f)]
			[Tooltip("How far away from the maxDistance to begin fading SSR.")]
			public float fadeDistance;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Range(0f, 1f)]
			[Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
			public float fresnelFade;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Range(0.1f, 10f)]
			[Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
			public float fresnelFadePower;
		}

		[Serializable]
		[Token(Token = "0x2000155")]
		public struct ReflectionSettings
		{
			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("How the reflections are blended into the render.")]
			public SSRReflectionBlendType blendType;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Tooltip("Half resolution SSRR is much faster, but less accurate.")]
			public SSRResolution reflectionQuality;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Maximum reflection distance in world units.")]
			[Range(0.1f, 300f)]
			public float maxDistance;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Tooltip("Max raytracing length.")]
			[Range(16f, 1024f)]
			public int iterationCount;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(1f, 16f)]
			[Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
			public int stepSize;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
			[Range(0.01f, 10f)]
			public float widthModifier;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Blurriness of reflections.")]
			[Range(0.1f, 8f)]
			public float reflectionBlur;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Disable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave on for scenes with glossy vertical objects.")]
			public bool reflectBackfaces;
		}

		[Serializable]
		[Token(Token = "0x2000156")]
		public struct ScreenEdgeMask
		{
			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
			[Range(0f, 1f)]
			public float intensity;
		}

		[Serializable]
		[Token(Token = "0x2000157")]
		public struct Settings
		{
			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectionSettings reflection;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IntensitySettings intensity;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ScreenEdgeMask screenEdgeMask;

			[Token(Token = "0x1700009D")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000516")]
				[Address(RVA = "0x79C0C0", Offset = "0x79C0C0", VA = "0x79C0C0")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x1700009C")]
		public Settings settings
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x79C030", Offset = "0x79C030", VA = "0x79C030")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x79C050", Offset = "0x79C050", VA = "0x79C050")]
			set
			{
			}
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x79C070", Offset = "0x79C070", VA = "0x79C070", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x79C114", Offset = "0x79C114", VA = "0x79C114")]
		public ScreenSpaceReflectionModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000158")]
	public class UserLutModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x2000159")]
		public struct Settings
		{
			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture2D lut;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Range(0f, 1f)]
			[Tooltip("Blending factor.")]
			public float contribution;

			[Token(Token = "0x1700009F")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x600051B")]
				[Address(RVA = "0x79C1CC", Offset = "0x79C1CC", VA = "0x79C1CC")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x1700009E")]
		public Settings settings
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x79C168", Offset = "0x79C168", VA = "0x79C168")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x79C174", Offset = "0x79C174", VA = "0x79C174")]
			set
			{
			}
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x79C184", Offset = "0x79C184", VA = "0x79C184", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x79C1FC", Offset = "0x79C1FC", VA = "0x79C1FC")]
		public UserLutModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015A")]
	public class VignetteModel : PostProcessingModel
	{
		[Token(Token = "0x200015B")]
		public enum Mode
		{
			[Token(Token = "0x40007DB")]
			Classic,
			[Token(Token = "0x40007DC")]
			Masked
		}

		[Serializable]
		[Token(Token = "0x200015C")]
		public struct Settings
		{
			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
			public Mode mode;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[ColorUsage(false)]
			[Tooltip("Vignette color. Use the alpha channel for transparency.")]
			public Color color;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public Vector2 center;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			[Tooltip("Amount of vignetting on screen.")]
			public float intensity;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0.01f, 1f)]
			[Tooltip("Smoothness of the vignette borders.")]
			public float smoothness;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Range(0f, 1f)]
			[Tooltip("Lower values will make a square-ish vignette.")]
			public float roundness;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("A black and white mask to use as a vignette.")]
			public Texture mask;

			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Range(0f, 1f)]
			[Tooltip("Mask opacity.")]
			public float opacity;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
			public bool rounded;

			[Token(Token = "0x170000A1")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000520")]
				[Address(RVA = "0x79C338", Offset = "0x79C338", VA = "0x79C338")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x170000A0")]
		public Settings settings
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x79C250", Offset = "0x79C250", VA = "0x79C250")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x79C270", Offset = "0x79C270", VA = "0x79C270")]
			set
			{
			}
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x79C29C", Offset = "0x79C29C", VA = "0x79C29C", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x79C3B8", Offset = "0x79C3B8", VA = "0x79C3B8")]
		public VignetteModel()
		{
		}
	}
	[Token(Token = "0x200015D")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Effects/Post-Processing Behaviour", -1)]
	[ImageEffectAllowedInSceneView]
	public class PostProcessingBehaviour : MonoBehaviour
	{
		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PostProcessingProfile profile;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Func<Vector2, Matrix4x4> jitteredMatrixFunc;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>> m_CommandBuffers;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<PostProcessingComponentBase> m_Components;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<PostProcessingComponentBase, bool> m_ComponentStates;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MaterialFactory m_MaterialFactory;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTextureFactory m_RenderTextureFactory;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PostProcessingContext m_Context;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Camera m_Camera;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PostProcessingProfile m_PreviousProfile;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_RenderingInSceneView;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private BuiltinDebugViewsComponent m_DebugViews;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AmbientOcclusionComponent m_AmbientOcclusion;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ScreenSpaceReflectionComponent m_ScreenSpaceReflection;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FogComponent m_FogComponent;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private MotionBlurComponent m_MotionBlur;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TaaComponent m_Taa;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private EyeAdaptationComponent m_EyeAdaptation;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private DepthOfFieldComponent m_DepthOfField;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BloomComponent m_Bloom;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ChromaticAberrationComponent m_ChromaticAberration;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ColorGradingComponent m_ColorGrading;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private UserLutComponent m_UserLut;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private GrainComponent m_Grain;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private VignetteComponent m_Vignette;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private DitheringComponent m_Dithering;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private FxaaComponent m_Fxaa;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<PostProcessingComponentBase> m_ComponentsToEnable;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<PostProcessingComponentBase> m_ComponentsToDisable;

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x79C460", Offset = "0x79C460", VA = "0x79C460")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x79CE88", Offset = "0x79CE88", VA = "0x79CE88")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x79DA20", Offset = "0x79DA20", VA = "0x79DA20")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x79DB58", Offset = "0x79DB58", VA = "0x79DB58")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x79DC5C", Offset = "0x79DC5C", VA = "0x79DC5C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x79E4F4", Offset = "0x79E4F4", VA = "0x79E4F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x79E684", Offset = "0x79E684", VA = "0x79E684")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x79EA28", Offset = "0x79EA28", VA = "0x79EA28")]
		public void ResetTemporalEffects()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x79D5DC", Offset = "0x79D5DC", VA = "0x79D5DC")]
		private void CheckObservers()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x79D468", Offset = "0x79D468", VA = "0x79D468")]
		private void DisableComponents()
		{
		}

		[Token(Token = "0x600052B")]
		private CommandBuffer AddCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		private void RemoveCommandBuffer<T>() where T : PostProcessingModel
		{
		}

		[Token(Token = "0x600052D")]
		private CommandBuffer GetCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		private void TryExecuteCommandBuffer<T>(PostProcessingComponentCommandBuffer<T> component) where T : PostProcessingModel
		{
		}

		[Token(Token = "0x600052F")]
		private bool TryPrepareUberImageEffect<T>(PostProcessingComponentRenderTexture<T> component, Material material) where T : PostProcessingModel
		{
			return default(bool);
		}

		[Token(Token = "0x6000530")]
		private T AddComponent<T>(T component) where T : PostProcessingComponentBase
		{
			return null;
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x79EA68", Offset = "0x79EA68", VA = "0x79EA68")]
		public PostProcessingBehaviour()
		{
		}
	}
	[Token(Token = "0x200015E")]
	public abstract class PostProcessingComponentBase
	{
		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PostProcessingContext context;

		[Token(Token = "0x170000A2")]
		public abstract bool active
		{
			[Token(Token = "0x6000533")]
			get;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x79EB20", Offset = "0x79EB20", VA = "0x79EB20", Slot = "4")]
		public virtual DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x79EB28", Offset = "0x79EB28", VA = "0x79EB28", Slot = "6")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x79EB2C", Offset = "0x79EB2C", VA = "0x79EB2C", Slot = "7")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000536")]
		public abstract PostProcessingModel GetModel();

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x79EB30", Offset = "0x79EB30", VA = "0x79EB30")]
		protected PostProcessingComponentBase()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public abstract class PostProcessingComponent<T> : PostProcessingComponentBase where T : PostProcessingModel
	{
		[Token(Token = "0x170000A3")]
		public T model
		{
			[Token(Token = "0x6000538")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000539")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x600053A")]
		public virtual void Init(PostProcessingContext pcontext, T pmodel)
		{
		}

		[Token(Token = "0x600053B")]
		public override PostProcessingModel GetModel()
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		protected PostProcessingComponent()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public abstract class PostProcessingComponentCommandBuffer<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		[Token(Token = "0x600053D")]
		public abstract CameraEvent GetCameraEvent();

		[Token(Token = "0x600053E")]
		public abstract string GetName();

		[Token(Token = "0x600053F")]
		public abstract void PopulateCommandBuffer(CommandBuffer cb);

		[Token(Token = "0x6000540")]
		protected PostProcessingComponentCommandBuffer()
		{
		}
	}
	[Token(Token = "0x2000161")]
	public abstract class PostProcessingComponentRenderTexture<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		[Token(Token = "0x6000541")]
		public virtual void Prepare(Material material)
		{
		}

		[Token(Token = "0x6000542")]
		protected PostProcessingComponentRenderTexture()
		{
		}
	}
	[Token(Token = "0x2000162")]
	public class PostProcessingContext
	{
		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PostProcessingProfile profile;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera camera;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MaterialFactory materialFactory;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RenderTextureFactory renderTextureFactory;

		[Token(Token = "0x170000A4")]
		public bool interrupted
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x79EB38", Offset = "0x79EB38", VA = "0x79EB38")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x79EB40", Offset = "0x79EB40", VA = "0x79EB40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool isGBufferAvailable
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x797804", Offset = "0x797804", VA = "0x797804")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A6")]
		public bool isHdr
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x798C1C", Offset = "0x798C1C", VA = "0x798C1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A7")]
		public int width
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x7989E0", Offset = "0x7989E0", VA = "0x7989E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A8")]
		public int height
		{
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x7989FC", Offset = "0x7989FC", VA = "0x7989FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A9")]
		public Rect viewport
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x79A7D8", Offset = "0x79A7D8", VA = "0x79A7D8")]
			get
			{
				return default(Rect);
			}
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x79EB4C", Offset = "0x79EB4C", VA = "0x79EB4C")]
		public void Interrupt()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x79D414", Offset = "0x79D414", VA = "0x79D414")]
		public PostProcessingContext Reset()
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x79CE80", Offset = "0x79CE80", VA = "0x79CE80")]
		public PostProcessingContext()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000163")]
	public abstract class PostProcessingModel
	{
		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[GetSet("enabled")]
		[SerializeField]
		private bool m_Enabled;

		[Token(Token = "0x170000AA")]
		public bool enabled
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x79EB58", Offset = "0x79EB58", VA = "0x79EB58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x79EB60", Offset = "0x79EB60", VA = "0x79EB60")]
			set
			{
			}
		}

		[Token(Token = "0x600054F")]
		public abstract void Reset();

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x79EB7C", Offset = "0x79EB7C", VA = "0x79EB7C", Slot = "5")]
		public virtual void OnValidate()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x79AD9C", Offset = "0x79AD9C", VA = "0x79AD9C")]
		protected PostProcessingModel()
		{
		}
	}
	[Token(Token = "0x2000164")]
	public class PostProcessingProfile : ScriptableObject
	{
		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BuiltinDebugViewsModel debugViews;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FogModel fog;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AntialiasingModel antialiasing;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AmbientOcclusionModel ambientOcclusion;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ScreenSpaceReflectionModel screenSpaceReflection;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DepthOfFieldModel depthOfField;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MotionBlurModel motionBlur;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public EyeAdaptationModel eyeAdaptation;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BloomModel bloom;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ColorGradingModel colorGrading;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UserLutModel userLut;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ChromaticAberrationModel chromaticAberration;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GrainModel grain;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public VignetteModel vignette;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DitheringModel dithering;

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x79EB80", Offset = "0x79EB80", VA = "0x79EB80")]
		public PostProcessingProfile()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000165")]
	public sealed class ColorGradingCurve
	{
		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_Loop;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_ZeroValue;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Range;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AnimationCurve m_InternalLoopingCurve;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x79BCBC", Offset = "0x79BCBC", VA = "0x79BCBC")]
		public ColorGradingCurve(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x79F048", Offset = "0x79F048", VA = "0x79F048")]
		public void Cache()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x79F230", Offset = "0x79F230", VA = "0x79F230")]
		public float Evaluate(float t)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000166")]
	public static class GraphicsUtils
	{
		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Texture2D s_WhiteTexture;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Mesh s_Quad;

		[Token(Token = "0x170000AB")]
		public static bool isLinearColorSpace
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x79E40C", Offset = "0x79E40C", VA = "0x79E40C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AC")]
		public static bool supportsDX11
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x79F2AC", Offset = "0x79F2AC", VA = "0x79F2AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		public static Texture2D whiteTexture
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x79E2DC", Offset = "0x79E2DC", VA = "0x79E2DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public static Mesh quad
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x797514", Offset = "0x797514", VA = "0x797514")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x79A0D4", Offset = "0x79A0D4", VA = "0x79A0D4")]
		public static void Blit(Material material, int pass)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x79F2D8", Offset = "0x79F2D8", VA = "0x79F2D8")]
		public static void ClearAndBlit(Texture source, RenderTexture destination, Material material, int pass, bool clearColor = true, bool clearDepth = false)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x79F474", Offset = "0x79F474", VA = "0x79F474")]
		public static void Destroy(Object obj)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x79E9E0", Offset = "0x79E9E0", VA = "0x79E9E0")]
		public static void Dispose()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public sealed class MaterialFactory : IDisposable
	{
		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, Material> m_Materials;

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x79CD70", Offset = "0x79CD70", VA = "0x79CD70")]
		public MaterialFactory()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x798A18", Offset = "0x798A18", VA = "0x798A18")]
		public Material Get(string shaderName)
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x79E904", Offset = "0x79E904", VA = "0x79E904", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public sealed class RenderTextureFactory : IDisposable
	{
		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HashSet<RenderTexture> m_TemporaryRTs;

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x79CDF8", Offset = "0x79CDF8", VA = "0x79CDF8")]
		public RenderTextureFactory()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x79E1C4", Offset = "0x79E1C4", VA = "0x79E1C4")]
		public RenderTexture Get(RenderTexture baseRenderTexture)
		{
			return null;
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x79F4FC", Offset = "0x79F4FC", VA = "0x79F4FC")]
		public RenderTexture Get(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite rw = RenderTextureReadWrite.Default, FilterMode filterMode = FilterMode.Bilinear, TextureWrapMode wrapMode = TextureWrapMode.Clamp, string name = "FactoryTempTexture")
		{
			return null;
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x79F5E0", Offset = "0x79F5E0", VA = "0x79F5E0")]
		public void Release(RenderTexture rt)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x79E428", Offset = "0x79E428", VA = "0x79E428")]
		public void ReleaseAll()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x79E9DC", Offset = "0x79E9DC", VA = "0x79E9DC", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace Nokobot.Assets.Crossbow
{
	[Token(Token = "0x2000169")]
	public class CrossbowShoot : MonoBehaviour
	{
		[Token(Token = "0x200016A")]
		[CompilerGenerated]
		private sealed class <dejarDispararYa>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CrossbowShoot <>4__this;

			[Token(Token = "0x170000AF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000570")]
				[Address(RVA = "0x7A014C", Offset = "0x7A014C", VA = "0x7A014C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000572")]
				[Address(RVA = "0x7A0194", Offset = "0x7A0194", VA = "0x7A0194", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0x79F8B8", Offset = "0x79F8B8", VA = "0x79F8B8")]
			[DebuggerHidden]
			public <dejarDispararYa>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0x7A0040", Offset = "0x7A0040", VA = "0x7A0040", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x7A0044", Offset = "0x7A0044", VA = "0x7A0044", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0x7A0154", Offset = "0x7A0154", VA = "0x7A0154", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200016B")]
		[CompilerGenerated]
		private sealed class <Explotar>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CrossbowShoot <>4__this;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RaycastHit hit;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 <posicionImpacto>5__2;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private GameObject <balaInstance>5__3;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private float <t1>5__4;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private float <t>5__5;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Vector3 <miPosicionDisparo>5__6;

			[Token(Token = "0x170000B1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000576")]
				[Address(RVA = "0x7A12FC", Offset = "0x7A12FC", VA = "0x7A12FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000578")]
				[Address(RVA = "0x7A1344", Offset = "0x7A1344", VA = "0x7A1344", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x79F97C", Offset = "0x79F97C", VA = "0x79F97C")]
			[DebuggerHidden]
			public <Explotar>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x7A019C", Offset = "0x7A019C", VA = "0x7A019C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x7A01A0", Offset = "0x7A01A0", VA = "0x7A01A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0x7A1304", Offset = "0x7A1304", VA = "0x7A1304", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject balaPrefab;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject impactoParedPrefab;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool derecho;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform posicionDisparo;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gatilloModel;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject fire;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool primerGatillazo;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AudioSource sndRecalentar;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject humoPistola;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LayerMask layersIgnorados;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Animator m_Animator;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool puedoDisparar;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private WaitForSeconds espera1;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private WaitForSeconds espera2unaMano;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private WaitForSeconds espera2dosManos;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine corutineDejarDeDisparar;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GameObject explosionInstancia;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit hit;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool enfriandose;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int temperaturaMaxima;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float velocidadEnfriamiento;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float temperaturaActual;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Material materialTemperatura;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AnimationCurve animacionEnfriamiento;

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x79F71C", Offset = "0x79F71C", VA = "0x79F71C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x79F844", Offset = "0x79F844", VA = "0x79F844")]
		[IteratorStateMachine(typeof(<dejarDispararYa>d__17))]
		private IEnumerator dejarDispararYa()
		{
			return null;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x79F8E0", Offset = "0x79F8E0", VA = "0x79F8E0")]
		[IteratorStateMachine(typeof(<Explotar>d__19))]
		private IEnumerator Explotar(RaycastHit hit)
		{
			return null;
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x79F9A4", Offset = "0x79F9A4", VA = "0x79F9A4")]
		private void Disparar()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x79FBD0", Offset = "0x79FBD0", VA = "0x79FBD0")]
		private void Update()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x79FF54", Offset = "0x79FF54", VA = "0x79FF54")]
		public CrossbowShoot()
		{
		}
	}
}
namespace LIV.SDK.Unity
{
	[Token(Token = "0x200016C")]
	public static class Calibration
	{
		[Token(Token = "0x4000847")]
		private const string ConfigFileName = "externalcamera.cfg";

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float X;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static float Y;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static float Z;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float Yaw;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static float Pitch;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static float Roll;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static float FieldOfVision;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static float NearClip;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static float FarClip;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static float HMDOffset;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static float NearOffset;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly FileSystemWatcher ConfigWatcher;

		[Token(Token = "0x170000B3")]
		public static Vector3 PositionOffset
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x7A14FC", Offset = "0x7A14FC", VA = "0x7A14FC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B4")]
		public static Quaternion RotationOffset
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x7A1558", Offset = "0x7A1558", VA = "0x7A1558")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x14000004")]
		public static event EventHandler Changed
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x7A134C", Offset = "0x7A134C", VA = "0x7A134C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x7A1424", Offset = "0x7A1424", VA = "0x7A1424")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x7A15CC", Offset = "0x7A15CC", VA = "0x7A15CC")]
		static Calibration()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x7A1FE8", Offset = "0x7A1FE8", VA = "0x7A1FE8")]
		private static void Reset()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x7A184C", Offset = "0x7A184C", VA = "0x7A184C")]
		public static void Read()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x7A2054", Offset = "0x7A2054", VA = "0x7A2054")]
		private static bool TryParseInvariantFloat(string number, out float result)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200016E")]
	public static class Extensions
	{
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x7A2190", Offset = "0x7A2190", VA = "0x7A2190")]
		private static float _copysign(float sizeval, float signval)
		{
			return default(float);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x7A21B8", Offset = "0x7A21B8", VA = "0x7A21B8")]
		public static Quaternion GetRotation(this Matrix4x4 matrix)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x7A229C", Offset = "0x7A229C", VA = "0x7A229C")]
		public static Vector3 GetPosition(this Matrix4x4 matrix)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200016F")]
	[AddComponentMenu("LIV/ExternalCamera")]
	public class ExternalCamera : MonoBehaviour
	{
		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private TrackedDevicePose_t _trackedDevicePose;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TrackedDevicePose_t[] _devices;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TrackedDevicePose_t[] _gameDevices;

		[Token(Token = "0x170000B5")]
		public bool IsValid
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x7A22A8", Offset = "0x7A22A8", VA = "0x7A22A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B6")]
		public uint OpenVRTrackedDeviceId
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x7A22B8", Offset = "0x7A22B8", VA = "0x7A22B8")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x7A22C0", Offset = "0x7A22C0", VA = "0x7A22C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x7A22C8", Offset = "0x7A22C8", VA = "0x7A22C8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x7A2344", Offset = "0x7A2344", VA = "0x7A2344")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x7A2390", Offset = "0x7A2390", VA = "0x7A2390")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x7A2400", Offset = "0x7A2400", VA = "0x7A2400")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x7A2394", Offset = "0x7A2394", VA = "0x7A2394")]
		private void UpdateCamera()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x7A2404", Offset = "0x7A2404", VA = "0x7A2404")]
		private void UpdateOpenVRPose()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x7A2468", Offset = "0x7A2468", VA = "0x7A2468")]
		private void UpdateTransform(HmdMatrix34_t deviceToAbsolute)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x7A232C", Offset = "0x7A232C", VA = "0x7A232C")]
		private void UpdateOpenVRDevice()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x7A264C", Offset = "0x7A264C", VA = "0x7A264C")]
		private uint IdentifyExternalCameraDevice()
		{
			return default(uint);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x7A2C14", Offset = "0x7A2C14", VA = "0x7A2C14")]
		private static string GetStringTrackedDeviceProperty(uint device, ETrackedDeviceProperty property)
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x7A2D8C", Offset = "0x7A2D8C", VA = "0x7A2D8C")]
		public ExternalCamera()
		{
		}
	}
	[Token(Token = "0x2000171")]
	[AttributeUsage(AttributeTargets.Field, Inherited = true)]
	public class HelpAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string text;

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x7A3344", Offset = "0x7A3344", VA = "0x7A3344")]
		public HelpAttribute(string text)
		{
		}
	}
	[Token(Token = "0x2000172")]
	[AddComponentMenu("LIV/LIV")]
	public class LIV : MonoBehaviour
	{
		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If unpopulated, we'll use the parent transform.")]
		public Transform TrackedSpaceOrigin;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Space]
		public Camera HMDCamera;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Space]
		public bool DisableStandardAssets;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Space]
		public LayerMask SpectatorLayerMask;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool WasActive;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SharedTextureProtocol _sharedTextureProtocol;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ExternalCamera _externalCamera;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MixedRealityRender _mixedRealityRender;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _wasSteamVRExternalCameraActive;

		[Token(Token = "0x170000B7")]
		public Transform Origin
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x7A3374", Offset = "0x7A3374", VA = "0x7A3374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x7A3404", Offset = "0x7A3404", VA = "0x7A3404")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x7A3488", Offset = "0x7A3488", VA = "0x7A3488")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x7A3774", Offset = "0x7A3774", VA = "0x7A3774")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x7A394C", Offset = "0x7A394C", VA = "0x7A394C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x7A3990", Offset = "0x7A3990", VA = "0x7A3990")]
		private void OnCompositorActivated()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x7A37FC", Offset = "0x7A37FC", VA = "0x7A37FC")]
		private void OnCompositorDeactivated()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x7A3B04", Offset = "0x7A3B04", VA = "0x7A3B04")]
		private void CreateSharedTextureProtocol()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x7A3F94", Offset = "0x7A3F94", VA = "0x7A3F94")]
		private void DestroySharedTextureProtocol()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x7A3B6C", Offset = "0x7A3B6C", VA = "0x7A3B6C")]
		private void CreateExternalCamera()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x7A40EC", Offset = "0x7A40EC", VA = "0x7A40EC")]
		private void DestroyExternalCamera()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x7A3C40", Offset = "0x7A3C40", VA = "0x7A3C40")]
		private void CreateMixedRealityRender()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x7A4034", Offset = "0x7A4034", VA = "0x7A4034")]
		private void DestroyMixedRealityRender()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x7A4388", Offset = "0x7A4388", VA = "0x7A4388")]
		public LIV()
		{
		}
	}
	[Token(Token = "0x2000173")]
	[AddComponentMenu("LIV/MixedRealityRender")]
	public class MixedRealityRender : MonoBehaviour
	{
		[Token(Token = "0x2000174")]
		[CompilerGenerated]
		private sealed class <RenderLoop>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MixedRealityRender <>4__this;

			[Token(Token = "0x170000B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0x7A5580", Offset = "0x7A5580", VA = "0x7A5580", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0x7A55C8", Offset = "0x7A55C8", VA = "0x7A55C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x7A5444", Offset = "0x7A5444", VA = "0x7A5444")]
			[DebuggerHidden]
			public <RenderLoop>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x7A5474", Offset = "0x7A5474", VA = "0x7A5474", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x7A5478", Offset = "0x7A5478", VA = "0x7A5478", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x7A5588", Offset = "0x7A5588", VA = "0x7A5588", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _isSetup;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LIV _liv;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Camera _mrCamera;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _hmd;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject _clipQuad;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _clipMaterial;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _blitMaterial;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RenderTexture _compositeTexture;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RenderTexture _foregroundTexture;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RenderTexture _backgroundTexture;

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x7A41A4", Offset = "0x7A41A4", VA = "0x7A41A4")]
		public void Setup(LIV liv)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x7A43B0", Offset = "0x7A43B0", VA = "0x7A43B0")]
		private void CreateClipQuad()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x7A45B4", Offset = "0x7A45B4", VA = "0x7A45B4")]
		private void UpdateCamera()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x7A4750", Offset = "0x7A4750", VA = "0x7A4750")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x7A4A64", Offset = "0x7A4A64", VA = "0x7A4A64")]
		public float GetDistanceToHMD()
		{
			return default(float);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x7A4D64", Offset = "0x7A4D64", VA = "0x7A4D64")]
		private void OrientClipQuad()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x7A4F20", Offset = "0x7A4F20", VA = "0x7A4F20")]
		private void RenderNear()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x7A5250", Offset = "0x7A5250", VA = "0x7A5250")]
		private void RenderFar()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x7A529C", Offset = "0x7A529C", VA = "0x7A529C")]
		private void Composite()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x7A53B0", Offset = "0x7A53B0", VA = "0x7A53B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x7A53D0", Offset = "0x7A53D0", VA = "0x7A53D0")]
		[IteratorStateMachine(typeof(<RenderLoop>d__20))]
		private IEnumerator RenderLoop()
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x7A546C", Offset = "0x7A546C", VA = "0x7A546C")]
		public MixedRealityRender()
		{
		}
	}
	[Token(Token = "0x2000175")]
	[AddComponentMenu("LIV/SharedTextureProtocol")]
	public class SharedTextureProtocol : MonoBehaviour
	{
		[Token(Token = "0x2000176")]
		[CompilerGenerated]
		private sealed class <CallPluginAtEndOfFrames>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SharedTextureProtocol <>4__this;

			[Token(Token = "0x170000BD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005CE")]
				[Address(RVA = "0x7A59B8", Offset = "0x7A59B8", VA = "0x7A59B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005D0")]
				[Address(RVA = "0x7A5A00", Offset = "0x7A5A00", VA = "0x7A5A00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x7A5888", Offset = "0x7A5888", VA = "0x7A5888")]
			[DebuggerHidden]
			public <CallPluginAtEndOfFrames>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x7A58E8", Offset = "0x7A58E8", VA = "0x7A58E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x7A58EC", Offset = "0x7A58EC", VA = "0x7A58EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x7A59C0", Offset = "0x7A59C0", VA = "0x7A59C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public static bool IsActive
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x7A3484", Offset = "0x7A3484", VA = "0x7A3484")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BB")]
		public static int TextureWidth
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x7A4A5C", Offset = "0x7A4A5C", VA = "0x7A4A5C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BC")]
		public static int TextureHeight
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x7A4A60", Offset = "0x7A4A60", VA = "0x7A4A60")]
			get
			{
				return default(int);
			}
		}

		[PreserveSig]
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x7A55D0", Offset = "0x7A55D0", VA = "0x7A55D0")]
		private static extern IntPtr GetRenderEventFunc();

		[PreserveSig]
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x7A5638", Offset = "0x7A5638", VA = "0x7A5638")]
		private static extern bool GetIsCaptureActive();

		[PreserveSig]
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x7A56A8", Offset = "0x7A56A8", VA = "0x7A56A8")]
		private static extern int GetTextureWidth();

		[PreserveSig]
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x7A5710", Offset = "0x7A5710", VA = "0x7A5710")]
		private static extern int GetTextureHeight();

		[PreserveSig]
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x7A5778", Offset = "0x7A5778", VA = "0x7A5778")]
		private static extern void SetTexture(IntPtr texture);

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x7A537C", Offset = "0x7A537C", VA = "0x7A537C")]
		public static void SetOutputTexture(Texture texture)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x7A57F4", Offset = "0x7A57F4", VA = "0x7A57F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x7A5814", Offset = "0x7A5814", VA = "0x7A5814")]
		[IteratorStateMachine(typeof(<CallPluginAtEndOfFrames>d__13))]
		private IEnumerator CallPluginAtEndOfFrames()
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x7A58B0", Offset = "0x7A58B0", VA = "0x7A58B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x7A58E0", Offset = "0x7A58E0", VA = "0x7A58E0")]
		public SharedTextureProtocol()
		{
		}
	}
	[Token(Token = "0x2000177")]
	internal static class SteamVRCompatibility
	{
		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool IsAvailable;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Type SteamVRCamera;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Type SteamVRExternalCamera;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Type SteamVRFade;

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x7A5A08", Offset = "0x7A5A08", VA = "0x7A5A08")]
		static SteamVRCompatibility()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x7A5A58", Offset = "0x7A5A58", VA = "0x7A5A58")]
		private static bool FindSteamVRAsset()
		{
			return default(bool);
		}
	}
}
namespace Valve.VR
{
	[Token(Token = "0x2000178")]
	public struct IVRSystem
	{
		[Token(Token = "0x2000179")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight);

		[Token(Token = "0x200017A")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix44_t _GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ);

		[Token(Token = "0x200017B")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom);

		[Token(Token = "0x200017C")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates);

		[Token(Token = "0x200017D")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix34_t _GetEyeToHeadTransform(EVREye eEye);

		[Token(Token = "0x200017E")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter);

		[Token(Token = "0x200017F")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate int _GetD3D9AdapterIndex();

		[Token(Token = "0x2000180")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex);

		[Token(Token = "0x2000181")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetOutputDevice(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance);

		[Token(Token = "0x2000182")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsDisplayOnDesktop();

		[Token(Token = "0x2000183")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _SetDisplayVisibility(bool bIsVisibleOnDesktop);

		[Token(Token = "0x2000184")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, [In][Out] TrackedDevicePose_t[] pTrackedDevicePoseArray, uint unTrackedDevicePoseArrayCount);

		[Token(Token = "0x2000185")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ResetSeatedZeroPose();

		[Token(Token = "0x2000186")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix34_t _GetSeatedZeroPoseToStandingAbsoluteTrackingPose();

		[Token(Token = "0x2000187")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix34_t _GetRawZeroPoseToStandingAbsoluteTrackingPose();

		[Token(Token = "0x2000188")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, [In][Out] uint[] punTrackedDeviceIndexArray, uint unTrackedDeviceIndexArrayCount, uint unRelativeToTrackedDeviceIndex);

		[Token(Token = "0x2000189")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EDeviceActivityLevel _GetTrackedDeviceActivityLevel(uint unDeviceId);

		[Token(Token = "0x200018A")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform);

		[Token(Token = "0x200018B")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType);

		[Token(Token = "0x200018C")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedControllerRole _GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex);

		[Token(Token = "0x200018D")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedDeviceClass _GetTrackedDeviceClass(uint unDeviceIndex);

		[Token(Token = "0x200018E")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsTrackedDeviceConnected(uint unDeviceIndex);

		[Token(Token = "0x200018F")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[Token(Token = "0x2000190")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate float _GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[Token(Token = "0x2000191")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate int _GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[Token(Token = "0x2000192")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[Token(Token = "0x2000193")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdMatrix34_t _GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);

		[Token(Token = "0x2000194")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetArrayTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, uint propType, IntPtr pBuffer, uint unBufferSize, ref ETrackedPropertyError pError);

		[Token(Token = "0x2000195")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError);

		[Token(Token = "0x2000196")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetPropErrorNameFromEnum(ETrackedPropertyError error);

		[Token(Token = "0x2000197")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent);

		[Token(Token = "0x2000198")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose);

		[Token(Token = "0x2000199")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetEventTypeNameFromEnum(EVREventType eType);

		[Token(Token = "0x200019A")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HiddenAreaMesh_t _GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type);

		[Token(Token = "0x200019B")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize);

		[Token(Token = "0x200019C")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose);

		[Token(Token = "0x200019D")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, char usDurationMicroSec);

		[Token(Token = "0x200019E")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetButtonIdNameFromEnum(EVRButtonId eButtonId);

		[Token(Token = "0x200019F")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType);

		[Token(Token = "0x20001A0")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsInputAvailable();

		[Token(Token = "0x20001A1")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsSteamVRDrawingControllers();

		[Token(Token = "0x20001A2")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ShouldApplicationPause();

		[Token(Token = "0x20001A3")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ShouldApplicationReduceRenderingWork();

		[Token(Token = "0x20001A4")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _DriverDebugRequest(uint unDeviceIndex, string pchRequest, StringBuilder pchResponseBuffer, uint unResponseBufferSize);

		[Token(Token = "0x20001A5")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRFirmwareError _PerformFirmwareUpdate(uint unDeviceIndex);

		[Token(Token = "0x20001A6")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _AcknowledgeQuit_Exiting();

		[Token(Token = "0x20001A7")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _AcknowledgeQuit_UserPrompt();

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _GetRecommendedRenderTargetSize GetRecommendedRenderTargetSize;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _GetProjectionMatrix GetProjectionMatrix;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _GetProjectionRaw GetProjectionRaw;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _ComputeDistortion ComputeDistortion;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _GetEyeToHeadTransform GetEyeToHeadTransform;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _GetTimeSinceLastVsync GetTimeSinceLastVsync;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _GetD3D9AdapterIndex GetD3D9AdapterIndex;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _GetDXGIOutputInfo GetDXGIOutputInfo;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _GetOutputDevice GetOutputDevice;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _IsDisplayOnDesktop IsDisplayOnDesktop;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _SetDisplayVisibility SetDisplayVisibility;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _GetDeviceToAbsoluteTrackingPose GetDeviceToAbsoluteTrackingPose;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal _ResetSeatedZeroPose ResetSeatedZeroPose;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal _GetSeatedZeroPoseToStandingAbsoluteTrackingPose GetSeatedZeroPoseToStandingAbsoluteTrackingPose;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal _GetRawZeroPoseToStandingAbsoluteTrackingPose GetRawZeroPoseToStandingAbsoluteTrackingPose;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal _GetSortedTrackedDeviceIndicesOfClass GetSortedTrackedDeviceIndicesOfClass;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal _GetTrackedDeviceActivityLevel GetTrackedDeviceActivityLevel;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal _ApplyTransform ApplyTransform;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal _GetTrackedDeviceIndexForControllerRole GetTrackedDeviceIndexForControllerRole;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal _GetControllerRoleForTrackedDeviceIndex GetControllerRoleForTrackedDeviceIndex;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal _GetTrackedDeviceClass GetTrackedDeviceClass;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal _IsTrackedDeviceConnected IsTrackedDeviceConnected;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal _GetBoolTrackedDeviceProperty GetBoolTrackedDeviceProperty;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal _GetFloatTrackedDeviceProperty GetFloatTrackedDeviceProperty;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal _GetInt32TrackedDeviceProperty GetInt32TrackedDeviceProperty;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal _GetUint64TrackedDeviceProperty GetUint64TrackedDeviceProperty;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal _GetMatrix34TrackedDeviceProperty GetMatrix34TrackedDeviceProperty;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal _GetArrayTrackedDeviceProperty GetArrayTrackedDeviceProperty;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal _GetStringTrackedDeviceProperty GetStringTrackedDeviceProperty;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal _PollNextEvent PollNextEvent;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal _PollNextEventWithPose PollNextEventWithPose;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal _GetEventTypeNameFromEnum GetEventTypeNameFromEnum;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal _GetHiddenAreaMesh GetHiddenAreaMesh;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		internal _GetControllerState GetControllerState;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal _GetControllerStateWithPose GetControllerStateWithPose;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal _TriggerHapticPulse TriggerHapticPulse;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal _GetButtonIdNameFromEnum GetButtonIdNameFromEnum;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal _GetControllerAxisTypeNameFromEnum GetControllerAxisTypeNameFromEnum;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal _IsInputAvailable IsInputAvailable;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal _IsSteamVRDrawingControllers IsSteamVRDrawingControllers;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		internal _ShouldApplicationPause ShouldApplicationPause;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		internal _ShouldApplicationReduceRenderingWork ShouldApplicationReduceRenderingWork;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		internal _DriverDebugRequest DriverDebugRequest;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		internal _PerformFirmwareUpdate PerformFirmwareUpdate;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		internal _AcknowledgeQuit_Exiting AcknowledgeQuit_Exiting;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		internal _AcknowledgeQuit_UserPrompt AcknowledgeQuit_UserPrompt;
	}
	[Token(Token = "0x20001A8")]
	public struct IVRExtendedDisplay
	{
		[Token(Token = "0x20001A9")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight);

		[Token(Token = "0x20001AA")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight);

		[Token(Token = "0x20001AB")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex);

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _GetWindowBounds GetWindowBounds;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _GetEyeOutputViewport GetEyeOutputViewport;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _GetDXGIOutputInfo GetDXGIOutputInfo;
	}
	[Token(Token = "0x20001AC")]
	public struct IVRTrackedCamera
	{
		[Token(Token = "0x20001AD")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError);

		[Token(Token = "0x20001AE")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _HasCamera(uint nDeviceIndex, ref bool pHasCamera);

		[Token(Token = "0x20001AF")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize);

		[Token(Token = "0x20001B0")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetCameraIntrinsics(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter);

		[Token(Token = "0x20001B1")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetCameraProjection(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection);

		[Token(Token = "0x20001B2")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle);

		[Token(Token = "0x20001B3")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamingService(ulong hTrackedCamera);

		[Token(Token = "0x20001B4")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);

		[Token(Token = "0x20001B5")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight);

		[Token(Token = "0x20001B6")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);

		[Token(Token = "0x20001B7")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);

		[Token(Token = "0x20001B8")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId);

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _GetCameraErrorNameFromEnum GetCameraErrorNameFromEnum;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _HasCamera HasCamera;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _GetCameraFrameSize GetCameraFrameSize;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _GetCameraIntrinsics GetCameraIntrinsics;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _GetCameraProjection GetCameraProjection;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _AcquireVideoStreamingService AcquireVideoStreamingService;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _ReleaseVideoStreamingService ReleaseVideoStreamingService;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _GetVideoStreamFrameBuffer GetVideoStreamFrameBuffer;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _GetVideoStreamTextureSize GetVideoStreamTextureSize;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _GetVideoStreamTextureD3D11 GetVideoStreamTextureD3D11;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _GetVideoStreamTextureGL GetVideoStreamTextureGL;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _ReleaseVideoStreamTextureGL ReleaseVideoStreamTextureGL;
	}
	[Token(Token = "0x20001B9")]
	public struct IVRApplications
	{
		[Token(Token = "0x20001BA")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary);

		[Token(Token = "0x20001BB")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _RemoveApplicationManifest(string pchApplicationManifestFullPath);

		[Token(Token = "0x20001BC")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsApplicationInstalled(string pchAppKey);

		[Token(Token = "0x20001BD")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetApplicationCount();

		[Token(Token = "0x20001BE")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);

		[Token(Token = "0x20001BF")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _GetApplicationKeyByProcessId(uint unProcessId, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);

		[Token(Token = "0x20001C0")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _LaunchApplication(string pchAppKey);

		[Token(Token = "0x20001C1")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, [In][Out] AppOverrideKeys_t[] pKeys, uint unKeys);

		[Token(Token = "0x20001C2")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _LaunchApplicationFromMimeType(string pchMimeType, string pchArgs);

		[Token(Token = "0x20001C3")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _LaunchDashboardOverlay(string pchAppKey);

		[Token(Token = "0x20001C4")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _CancelApplicationLaunch(string pchAppKey);

		[Token(Token = "0x20001C5")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _IdentifyApplication(uint unProcessId, string pchAppKey);

		[Token(Token = "0x20001C6")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetApplicationProcessId(string pchAppKey);

		[Token(Token = "0x20001C7")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetApplicationsErrorNameFromEnum(EVRApplicationError error);

		[Token(Token = "0x20001C8")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError);

		[Token(Token = "0x20001C9")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);

		[Token(Token = "0x20001CA")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);

		[Token(Token = "0x20001CB")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch);

		[Token(Token = "0x20001CC")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetApplicationAutoLaunch(string pchAppKey);

		[Token(Token = "0x20001CD")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType);

		[Token(Token = "0x20001CE")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetDefaultApplicationForMimeType(string pchMimeType, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);

		[Token(Token = "0x20001CF")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetApplicationSupportedMimeTypes(string pchAppKey, StringBuilder pchMimeTypesBuffer, uint unMimeTypesBuffer);

		[Token(Token = "0x20001D0")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetApplicationsThatSupportMimeType(string pchMimeType, StringBuilder pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer);

		[Token(Token = "0x20001D1")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetApplicationLaunchArguments(uint unHandle, StringBuilder pchArgs, uint unArgs);

		[Token(Token = "0x20001D2")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _GetStartingApplication(StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);

		[Token(Token = "0x20001D3")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationTransitionState _GetTransitionState();

		[Token(Token = "0x20001D4")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _PerformApplicationPrelaunchCheck(string pchAppKey);

		[Token(Token = "0x20001D5")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state);

		[Token(Token = "0x20001D6")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsQuitUserPromptRequested();

		[Token(Token = "0x20001D7")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRApplicationError _LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory);

		[Token(Token = "0x20001D8")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetCurrentSceneProcessId();

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _AddApplicationManifest AddApplicationManifest;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _RemoveApplicationManifest RemoveApplicationManifest;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _IsApplicationInstalled IsApplicationInstalled;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _GetApplicationCount GetApplicationCount;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _GetApplicationKeyByIndex GetApplicationKeyByIndex;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _GetApplicationKeyByProcessId GetApplicationKeyByProcessId;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _LaunchApplication LaunchApplication;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _LaunchTemplateApplication LaunchTemplateApplication;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _LaunchApplicationFromMimeType LaunchApplicationFromMimeType;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _LaunchDashboardOverlay LaunchDashboardOverlay;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _CancelApplicationLaunch CancelApplicationLaunch;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _IdentifyApplication IdentifyApplication;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal _GetApplicationProcessId GetApplicationProcessId;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal _GetApplicationsErrorNameFromEnum GetApplicationsErrorNameFromEnum;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal _GetApplicationPropertyString GetApplicationPropertyString;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal _GetApplicationPropertyBool GetApplicationPropertyBool;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal _GetApplicationPropertyUint64 GetApplicationPropertyUint64;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal _SetApplicationAutoLaunch SetApplicationAutoLaunch;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal _GetApplicationAutoLaunch GetApplicationAutoLaunch;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal _SetDefaultApplicationForMimeType SetDefaultApplicationForMimeType;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal _GetDefaultApplicationForMimeType GetDefaultApplicationForMimeType;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal _GetApplicationSupportedMimeTypes GetApplicationSupportedMimeTypes;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal _GetApplicationsThatSupportMimeType GetApplicationsThatSupportMimeType;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal _GetApplicationLaunchArguments GetApplicationLaunchArguments;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal _GetStartingApplication GetStartingApplication;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal _GetTransitionState GetTransitionState;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal _PerformApplicationPrelaunchCheck PerformApplicationPrelaunchCheck;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal _GetApplicationsTransitionStateNameFromEnum GetApplicationsTransitionStateNameFromEnum;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal _IsQuitUserPromptRequested IsQuitUserPromptRequested;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal _LaunchInternalProcess LaunchInternalProcess;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal _GetCurrentSceneProcessId GetCurrentSceneProcessId;
	}
	[Token(Token = "0x20001D9")]
	public struct IVRChaperone
	{
		[Token(Token = "0x20001DA")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ChaperoneCalibrationState _GetCalibrationState();

		[Token(Token = "0x20001DB")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetPlayAreaSize(ref float pSizeX, ref float pSizeZ);

		[Token(Token = "0x20001DC")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetPlayAreaRect(ref HmdQuad_t rect);

		[Token(Token = "0x20001DD")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ReloadInfo();

		[Token(Token = "0x20001DE")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetSceneColor(HmdColor_t color);

		[Token(Token = "0x20001DF")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor);

		[Token(Token = "0x20001E0")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _AreBoundsVisible();

		[Token(Token = "0x20001E1")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ForceBoundsVisible(bool bForce);

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _GetCalibrationState GetCalibrationState;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _GetPlayAreaSize GetPlayAreaSize;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _GetPlayAreaRect GetPlayAreaRect;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _ReloadInfo ReloadInfo;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _SetSceneColor SetSceneColor;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _GetBoundsColor GetBoundsColor;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _AreBoundsVisible AreBoundsVisible;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _ForceBoundsVisible ForceBoundsVisible;
	}
	[Token(Token = "0x20001E2")]
	public struct IVRChaperoneSetup
	{
		[Token(Token = "0x20001E3")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _CommitWorkingCopy(EChaperoneConfigFile configFile);

		[Token(Token = "0x20001E4")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _RevertWorkingCopy();

		[Token(Token = "0x20001E5")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ);

		[Token(Token = "0x20001E6")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetWorkingPlayAreaRect(ref HmdQuad_t rect);

		[Token(Token = "0x20001E7")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetWorkingCollisionBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);

		[Token(Token = "0x20001E8")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetLiveCollisionBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);

		[Token(Token = "0x20001E9")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);

		[Token(Token = "0x20001EA")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose);

		[Token(Token = "0x20001EB")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingPlayAreaSize(float sizeX, float sizeZ);

		[Token(Token = "0x20001EC")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingCollisionBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount);

		[Token(Token = "0x20001ED")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose);

		[Token(Token = "0x20001EE")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose);

		[Token(Token = "0x20001EF")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ReloadFromDisk(EChaperoneConfigFile configFile);

		[Token(Token = "0x20001F0")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);

		[Token(Token = "0x20001F1")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetWorkingCollisionBoundsTagsInfo([In][Out] byte[] pTagsBuffer, uint unTagCount);

		[Token(Token = "0x20001F2")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetLiveCollisionBoundsTagsInfo([In][Out] byte[] pTagsBuffer, ref uint punTagCount);

		[Token(Token = "0x20001F3")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _SetWorkingPhysicalBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount);

		[Token(Token = "0x20001F4")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetLivePhysicalBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);

		[Token(Token = "0x20001F5")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength);

		[Token(Token = "0x20001F6")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ImportFromBufferToWorking(string pBuffer, uint nImportFlags);

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _CommitWorkingCopy CommitWorkingCopy;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _RevertWorkingCopy RevertWorkingCopy;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _GetWorkingPlayAreaSize GetWorkingPlayAreaSize;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _GetWorkingPlayAreaRect GetWorkingPlayAreaRect;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _GetWorkingCollisionBoundsInfo GetWorkingCollisionBoundsInfo;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _GetLiveCollisionBoundsInfo GetLiveCollisionBoundsInfo;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _GetWorkingSeatedZeroPoseToRawTrackingPose GetWorkingSeatedZeroPoseToRawTrackingPose;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _GetWorkingStandingZeroPoseToRawTrackingPose GetWorkingStandingZeroPoseToRawTrackingPose;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _SetWorkingPlayAreaSize SetWorkingPlayAreaSize;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _SetWorkingCollisionBoundsInfo SetWorkingCollisionBoundsInfo;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _SetWorkingSeatedZeroPoseToRawTrackingPose SetWorkingSeatedZeroPoseToRawTrackingPose;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _SetWorkingStandingZeroPoseToRawTrackingPose SetWorkingStandingZeroPoseToRawTrackingPose;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal _ReloadFromDisk ReloadFromDisk;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal _GetLiveSeatedZeroPoseToRawTrackingPose GetLiveSeatedZeroPoseToRawTrackingPose;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal _SetWorkingCollisionBoundsTagsInfo SetWorkingCollisionBoundsTagsInfo;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal _GetLiveCollisionBoundsTagsInfo GetLiveCollisionBoundsTagsInfo;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal _SetWorkingPhysicalBoundsInfo SetWorkingPhysicalBoundsInfo;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal _GetLivePhysicalBoundsInfo GetLivePhysicalBoundsInfo;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal _ExportLiveToBuffer ExportLiveToBuffer;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal _ImportFromBufferToWorking ImportFromBufferToWorking;
	}
	[Token(Token = "0x20001F7")]
	public struct IVRCompositor
	{
		[Token(Token = "0x20001F8")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetTrackingSpace(ETrackingUniverseOrigin eOrigin);

		[Token(Token = "0x20001F9")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackingUniverseOrigin _GetTrackingSpace();

		[Token(Token = "0x20001FA")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _WaitGetPoses([In][Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In][Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);

		[Token(Token = "0x20001FB")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _GetLastPoses([In][Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In][Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);

		[Token(Token = "0x20001FC")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose);

		[Token(Token = "0x20001FD")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags);

		[Token(Token = "0x20001FE")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ClearLastSubmittedFrame();

		[Token(Token = "0x20001FF")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _PostPresentHandoff();

		[Token(Token = "0x2000200")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo);

		[Token(Token = "0x2000201")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetFrameTimings(ref Compositor_FrameTiming pTiming, uint nFrames);

		[Token(Token = "0x2000202")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate float _GetFrameTimeRemaining();

		[Token(Token = "0x2000203")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes);

		[Token(Token = "0x2000204")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground);

		[Token(Token = "0x2000205")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate HmdColor_t _GetCurrentFadeColor(bool bBackground);

		[Token(Token = "0x2000206")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FadeGrid(float fSeconds, bool bFadeIn);

		[Token(Token = "0x2000207")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate float _GetCurrentGridAlpha();

		[Token(Token = "0x2000208")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _SetSkyboxOverride([In][Out] Texture_t[] pTextures, uint unTextureCount);

		[Token(Token = "0x2000209")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ClearSkyboxOverride();

		[Token(Token = "0x200020A")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CompositorBringToFront();

		[Token(Token = "0x200020B")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CompositorGoToBack();

		[Token(Token = "0x200020C")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CompositorQuit();

		[Token(Token = "0x200020D")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsFullscreen();

		[Token(Token = "0x200020E")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetCurrentSceneFocusProcess();

		[Token(Token = "0x200020F")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetLastFrameRenderer();

		[Token(Token = "0x2000210")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _CanRenderScene();

		[Token(Token = "0x2000211")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ShowMirrorWindow();

		[Token(Token = "0x2000212")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _HideMirrorWindow();

		[Token(Token = "0x2000213")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsMirrorWindowVisible();

		[Token(Token = "0x2000214")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CompositorDumpImages();

		[Token(Token = "0x2000215")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ShouldAppRenderWithLowResources();

		[Token(Token = "0x2000216")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ForceInterleavedReprojectionOn(bool bOverride);

		[Token(Token = "0x2000217")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ForceReconnectProcess();

		[Token(Token = "0x2000218")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SuspendRendering(bool bSuspend);

		[Token(Token = "0x2000219")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView);

		[Token(Token = "0x200021A")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView);

		[Token(Token = "0x200021B")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle);

		[Token(Token = "0x200021C")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle);

		[Token(Token = "0x200021D")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle);

		[Token(Token = "0x200021E")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle);

		[Token(Token = "0x200021F")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize);

		[Token(Token = "0x2000220")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize);

		[Token(Token = "0x2000221")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetExplicitTimingMode(EVRCompositorTimingMode eTimingMode);

		[Token(Token = "0x2000222")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRCompositorError _SubmitExplicitTimingData();

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _SetTrackingSpace SetTrackingSpace;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _GetTrackingSpace GetTrackingSpace;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _WaitGetPoses WaitGetPoses;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _GetLastPoses GetLastPoses;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _GetLastPoseForTrackedDeviceIndex GetLastPoseForTrackedDeviceIndex;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _Submit Submit;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _ClearLastSubmittedFrame ClearLastSubmittedFrame;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _PostPresentHandoff PostPresentHandoff;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _GetFrameTiming GetFrameTiming;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _GetFrameTimings GetFrameTimings;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _GetFrameTimeRemaining GetFrameTimeRemaining;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _GetCumulativeStats GetCumulativeStats;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal _FadeToColor FadeToColor;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal _GetCurrentFadeColor GetCurrentFadeColor;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal _FadeGrid FadeGrid;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal _GetCurrentGridAlpha GetCurrentGridAlpha;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal _SetSkyboxOverride SetSkyboxOverride;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal _ClearSkyboxOverride ClearSkyboxOverride;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal _CompositorBringToFront CompositorBringToFront;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal _CompositorGoToBack CompositorGoToBack;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal _CompositorQuit CompositorQuit;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal _IsFullscreen IsFullscreen;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal _GetCurrentSceneFocusProcess GetCurrentSceneFocusProcess;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal _GetLastFrameRenderer GetLastFrameRenderer;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal _CanRenderScene CanRenderScene;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal _ShowMirrorWindow ShowMirrorWindow;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal _HideMirrorWindow HideMirrorWindow;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal _IsMirrorWindowVisible IsMirrorWindowVisible;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal _CompositorDumpImages CompositorDumpImages;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal _ShouldAppRenderWithLowResources ShouldAppRenderWithLowResources;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal _ForceInterleavedReprojectionOn ForceInterleavedReprojectionOn;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal _ForceReconnectProcess ForceReconnectProcess;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal _SuspendRendering SuspendRendering;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal _GetMirrorTextureD3D11 GetMirrorTextureD3D11;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		internal _ReleaseMirrorTextureD3D11 ReleaseMirrorTextureD3D11;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal _GetMirrorTextureGL GetMirrorTextureGL;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal _ReleaseSharedGLTexture ReleaseSharedGLTexture;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal _LockGLSharedTextureForAccess LockGLSharedTextureForAccess;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal _UnlockGLSharedTextureForAccess UnlockGLSharedTextureForAccess;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal _GetVulkanInstanceExtensionsRequired GetVulkanInstanceExtensionsRequired;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal _GetVulkanDeviceExtensionsRequired GetVulkanDeviceExtensionsRequired;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		internal _SetExplicitTimingMode SetExplicitTimingMode;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		internal _SubmitExplicitTimingData SubmitExplicitTimingData;
	}
	[Token(Token = "0x2000223")]
	public struct IVROverlay
	{
		[Token(Token = "0x2000224")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle);

		[Token(Token = "0x2000225")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _CreateOverlay(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle);

		[Token(Token = "0x2000226")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _DestroyOverlay(ulong ulOverlayHandle);

		[Token(Token = "0x2000227")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetHighQualityOverlay(ulong ulOverlayHandle);

		[Token(Token = "0x2000228")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetHighQualityOverlay();

		[Token(Token = "0x2000229")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);

		[Token(Token = "0x200022A")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);

		[Token(Token = "0x200022B")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayName(ulong ulOverlayHandle, string pchName);

		[Token(Token = "0x200022C")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight);

		[Token(Token = "0x200022D")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetOverlayErrorNameFromEnum(EVROverlayError error);

		[Token(Token = "0x200022E")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID);

		[Token(Token = "0x200022F")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetOverlayRenderingPid(ulong ulOverlayHandle);

		[Token(Token = "0x2000230")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled);

		[Token(Token = "0x2000231")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled);

		[Token(Token = "0x2000232")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue);

		[Token(Token = "0x2000233")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue);

		[Token(Token = "0x2000234")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha);

		[Token(Token = "0x2000235")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha);

		[Token(Token = "0x2000236")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect);

		[Token(Token = "0x2000237")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect);

		[Token(Token = "0x2000238")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder);

		[Token(Token = "0x2000239")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder);

		[Token(Token = "0x200023A")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters);

		[Token(Token = "0x200023B")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters);

		[Token(Token = "0x200023C")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters);

		[Token(Token = "0x200023D")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters);

		[Token(Token = "0x200023E")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace);

		[Token(Token = "0x200023F")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace);

		[Token(Token = "0x2000240")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);

		[Token(Token = "0x2000241")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);

		[Token(Token = "0x2000242")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetOverlayRenderModel(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref HmdColor_t pColor, ref EVROverlayError pError);

		[Token(Token = "0x2000243")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayRenderModel(ulong ulOverlayHandle, string pchRenderModel, ref HmdColor_t pColor);

		[Token(Token = "0x2000244")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType);

		[Token(Token = "0x2000245")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);

		[Token(Token = "0x2000246")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);

		[Token(Token = "0x2000247")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);

		[Token(Token = "0x2000248")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);

		[Token(Token = "0x2000249")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName);

		[Token(Token = "0x200024A")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, StringBuilder pchComponentName, uint unComponentNameSize);

		[Token(Token = "0x200024B")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform);

		[Token(Token = "0x200024C")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform);

		[Token(Token = "0x200024D")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ShowOverlay(ulong ulOverlayHandle);

		[Token(Token = "0x200024E")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _HideOverlay(ulong ulOverlayHandle);

		[Token(Token = "0x200024F")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsOverlayVisible(ulong ulOverlayHandle);

		[Token(Token = "0x2000250")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform);

		[Token(Token = "0x2000251")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent);

		[Token(Token = "0x2000252")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod);

		[Token(Token = "0x2000253")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod);

		[Token(Token = "0x2000254")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);

		[Token(Token = "0x2000255")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);

		[Token(Token = "0x2000256")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults);

		[Token(Token = "0x2000257")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsHoverTargetOverlay(ulong ulOverlayHandle);

		[Token(Token = "0x2000258")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetGamepadFocusOverlay();

		[Token(Token = "0x2000259")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetGamepadFocusOverlay(ulong ulNewFocusOverlay);

		[Token(Token = "0x200025A")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayNeighbor(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo);

		[Token(Token = "0x200025B")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _MoveGamepadFocusToNeighbor(EOverlayDirection eDirection, ulong ulFrom);

		[Token(Token = "0x200025C")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayDualAnalogTransform(ulong ulOverlay, EDualAnalogWhich eWhich, IntPtr vCenter, float fRadius);

		[Token(Token = "0x200025D")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayDualAnalogTransform(ulong ulOverlay, EDualAnalogWhich eWhich, ref HmdVector2_t pvCenter, ref float pfRadius);

		[Token(Token = "0x200025E")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture);

		[Token(Token = "0x200025F")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ClearOverlayTexture(ulong ulOverlayHandle);

		[Token(Token = "0x2000260")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth);

		[Token(Token = "0x2000261")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath);

		[Token(Token = "0x2000262")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds);

		[Token(Token = "0x2000263")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle);

		[Token(Token = "0x2000264")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight);

		[Token(Token = "0x2000265")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle);

		[Token(Token = "0x2000266")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsDashboardVisible();

		[Token(Token = "0x2000267")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _IsActiveDashboardOverlay(ulong ulOverlayHandle);

		[Token(Token = "0x2000268")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId);

		[Token(Token = "0x2000269")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId);

		[Token(Token = "0x200026A")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ShowDashboard(string pchOverlayToShow);

		[Token(Token = "0x200026B")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetPrimaryDashboardDevice();

		[Token(Token = "0x200026C")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue);

		[Token(Token = "0x200026D")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue);

		[Token(Token = "0x200026E")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetKeyboardText(StringBuilder pchText, uint cchText);

		[Token(Token = "0x200026F")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _HideKeyboard();

		[Token(Token = "0x2000270")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform);

		[Token(Token = "0x2000271")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect);

		[Token(Token = "0x2000272")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize);

		[Token(Token = "0x2000273")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVROverlayError _GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags);

		[Token(Token = "0x2000274")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate VRMessageOverlayResponse _ShowMessageOverlay(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text);

		[Token(Token = "0x2000275")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _CloseMessageOverlay();

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _FindOverlay FindOverlay;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _CreateOverlay CreateOverlay;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _DestroyOverlay DestroyOverlay;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _SetHighQualityOverlay SetHighQualityOverlay;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _GetHighQualityOverlay GetHighQualityOverlay;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _GetOverlayKey GetOverlayKey;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _GetOverlayName GetOverlayName;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _SetOverlayName SetOverlayName;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _GetOverlayImageData GetOverlayImageData;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _GetOverlayErrorNameFromEnum GetOverlayErrorNameFromEnum;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _SetOverlayRenderingPid SetOverlayRenderingPid;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _GetOverlayRenderingPid GetOverlayRenderingPid;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal _SetOverlayFlag SetOverlayFlag;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal _GetOverlayFlag GetOverlayFlag;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal _SetOverlayColor SetOverlayColor;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal _GetOverlayColor GetOverlayColor;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal _SetOverlayAlpha SetOverlayAlpha;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal _GetOverlayAlpha GetOverlayAlpha;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal _SetOverlayTexelAspect SetOverlayTexelAspect;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal _GetOverlayTexelAspect GetOverlayTexelAspect;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal _SetOverlaySortOrder SetOverlaySortOrder;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal _GetOverlaySortOrder GetOverlaySortOrder;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal _SetOverlayWidthInMeters SetOverlayWidthInMeters;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal _GetOverlayWidthInMeters GetOverlayWidthInMeters;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal _SetOverlayAutoCurveDistanceRangeInMeters SetOverlayAutoCurveDistanceRangeInMeters;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal _GetOverlayAutoCurveDistanceRangeInMeters GetOverlayAutoCurveDistanceRangeInMeters;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal _SetOverlayTextureColorSpace SetOverlayTextureColorSpace;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal _GetOverlayTextureColorSpace GetOverlayTextureColorSpace;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal _SetOverlayTextureBounds SetOverlayTextureBounds;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal _GetOverlayTextureBounds GetOverlayTextureBounds;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal _GetOverlayRenderModel GetOverlayRenderModel;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal _SetOverlayRenderModel SetOverlayRenderModel;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal _GetOverlayTransformType GetOverlayTransformType;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal _SetOverlayTransformAbsolute SetOverlayTransformAbsolute;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		internal _GetOverlayTransformAbsolute GetOverlayTransformAbsolute;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal _SetOverlayTransformTrackedDeviceRelative SetOverlayTransformTrackedDeviceRelative;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal _GetOverlayTransformTrackedDeviceRelative GetOverlayTransformTrackedDeviceRelative;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal _SetOverlayTransformTrackedDeviceComponent SetOverlayTransformTrackedDeviceComponent;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal _GetOverlayTransformTrackedDeviceComponent GetOverlayTransformTrackedDeviceComponent;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal _GetOverlayTransformOverlayRelative GetOverlayTransformOverlayRelative;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal _SetOverlayTransformOverlayRelative SetOverlayTransformOverlayRelative;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		internal _ShowOverlay ShowOverlay;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		internal _HideOverlay HideOverlay;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		internal _IsOverlayVisible IsOverlayVisible;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		internal _GetTransformForOverlayCoordinates GetTransformForOverlayCoordinates;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		internal _PollNextOverlayEvent PollNextOverlayEvent;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		internal _GetOverlayInputMethod GetOverlayInputMethod;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		internal _SetOverlayInputMethod SetOverlayInputMethod;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		internal _GetOverlayMouseScale GetOverlayMouseScale;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		internal _SetOverlayMouseScale SetOverlayMouseScale;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		internal _ComputeOverlayIntersection ComputeOverlayIntersection;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		internal _IsHoverTargetOverlay IsHoverTargetOverlay;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		internal _GetGamepadFocusOverlay GetGamepadFocusOverlay;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		internal _SetGamepadFocusOverlay SetGamepadFocusOverlay;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		internal _SetOverlayNeighbor SetOverlayNeighbor;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		internal _MoveGamepadFocusToNeighbor MoveGamepadFocusToNeighbor;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		internal _SetOverlayDualAnalogTransform SetOverlayDualAnalogTransform;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		internal _GetOverlayDualAnalogTransform GetOverlayDualAnalogTransform;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		internal _SetOverlayTexture SetOverlayTexture;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		internal _ClearOverlayTexture ClearOverlayTexture;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		internal _SetOverlayRaw SetOverlayRaw;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		internal _SetOverlayFromFile SetOverlayFromFile;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		internal _GetOverlayTexture GetOverlayTexture;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		internal _ReleaseNativeOverlayHandle ReleaseNativeOverlayHandle;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		internal _GetOverlayTextureSize GetOverlayTextureSize;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		internal _CreateDashboardOverlay CreateDashboardOverlay;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		internal _IsDashboardVisible IsDashboardVisible;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		internal _IsActiveDashboardOverlay IsActiveDashboardOverlay;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		internal _SetDashboardOverlaySceneProcess SetDashboardOverlaySceneProcess;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		internal _GetDashboardOverlaySceneProcess GetDashboardOverlaySceneProcess;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		internal _ShowDashboard ShowDashboard;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		internal _GetPrimaryDashboardDevice GetPrimaryDashboardDevice;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		internal _ShowKeyboard ShowKeyboard;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		internal _ShowKeyboardForOverlay ShowKeyboardForOverlay;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		internal _GetKeyboardText GetKeyboardText;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		internal _HideKeyboard HideKeyboard;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		internal _SetKeyboardTransformAbsolute SetKeyboardTransformAbsolute;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		internal _SetKeyboardPositionForOverlay SetKeyboardPositionForOverlay;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		internal _SetOverlayIntersectionMask SetOverlayIntersectionMask;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		internal _GetOverlayFlags GetOverlayFlags;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		internal _ShowMessageOverlay ShowMessageOverlay;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		internal _CloseMessageOverlay CloseMessageOverlay;
	}
	[Token(Token = "0x2000276")]
	public struct IVRRenderModels
	{
		[Token(Token = "0x2000277")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRRenderModelError _LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel);

		[Token(Token = "0x2000278")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FreeRenderModel(IntPtr pRenderModel);

		[Token(Token = "0x2000279")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRRenderModelError _LoadTexture_Async(int textureId, ref IntPtr ppTexture);

		[Token(Token = "0x200027A")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FreeTexture(IntPtr pTexture);

		[Token(Token = "0x200027B")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRRenderModelError _LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D);

		[Token(Token = "0x200027C")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRRenderModelError _LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture);

		[Token(Token = "0x200027D")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _FreeTextureD3D11(IntPtr pD3D11Texture2D);

		[Token(Token = "0x200027E")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen);

		[Token(Token = "0x200027F")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetRenderModelCount();

		[Token(Token = "0x2000280")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetComponentCount(string pchRenderModelName);

		[Token(Token = "0x2000281")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen);

		[Token(Token = "0x2000282")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetComponentButtonMask(string pchRenderModelName, string pchComponentName);

		[Token(Token = "0x2000283")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen);

		[Token(Token = "0x2000284")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);

		[Token(Token = "0x2000285")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _RenderModelHasComponent(string pchRenderModelName, string pchComponentName);

		[Token(Token = "0x2000286")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetRenderModelThumbnailURL(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError);

		[Token(Token = "0x2000287")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetRenderModelOriginalPath(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError);

		[Token(Token = "0x2000288")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetRenderModelErrorNameFromEnum(EVRRenderModelError error);

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _LoadRenderModel_Async LoadRenderModel_Async;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _FreeRenderModel FreeRenderModel;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _LoadTexture_Async LoadTexture_Async;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _FreeTexture FreeTexture;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _LoadTextureD3D11_Async LoadTextureD3D11_Async;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _LoadIntoTextureD3D11_Async LoadIntoTextureD3D11_Async;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _FreeTextureD3D11 FreeTextureD3D11;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _GetRenderModelName GetRenderModelName;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _GetRenderModelCount GetRenderModelCount;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _GetComponentCount GetComponentCount;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _GetComponentName GetComponentName;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _GetComponentButtonMask GetComponentButtonMask;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal _GetComponentRenderModelName GetComponentRenderModelName;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal _GetComponentState GetComponentState;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal _RenderModelHasComponent RenderModelHasComponent;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal _GetRenderModelThumbnailURL GetRenderModelThumbnailURL;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal _GetRenderModelOriginalPath GetRenderModelOriginalPath;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal _GetRenderModelErrorNameFromEnum GetRenderModelErrorNameFromEnum;
	}
	[Token(Token = "0x2000289")]
	public struct IVRNotifications
	{
		[Token(Token = "0x200028A")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRNotificationError _CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId);

		[Token(Token = "0x200028B")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRNotificationError _RemoveNotification(uint notificationId);

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _CreateNotification CreateNotification;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _RemoveNotification RemoveNotification;
	}
	[Token(Token = "0x200028C")]
	public struct IVRSettings
	{
		[Token(Token = "0x200028D")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetSettingsErrorNameFromEnum(EVRSettingsError eError);

		[Token(Token = "0x200028E")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _Sync(bool bForce, ref EVRSettingsError peError);

		[Token(Token = "0x200028F")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError);

		[Token(Token = "0x2000290")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError);

		[Token(Token = "0x2000291")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError);

		[Token(Token = "0x2000292")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError);

		[Token(Token = "0x2000293")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetBool(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);

		[Token(Token = "0x2000294")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate int _GetInt32(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);

		[Token(Token = "0x2000295")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate float _GetFloat(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);

		[Token(Token = "0x2000296")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetString(string pchSection, string pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError);

		[Token(Token = "0x2000297")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _RemoveSection(string pchSection, ref EVRSettingsError peError);

		[Token(Token = "0x2000298")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _GetSettingsErrorNameFromEnum GetSettingsErrorNameFromEnum;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _Sync Sync;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _SetBool SetBool;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _SetInt32 SetInt32;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _SetFloat SetFloat;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _SetString SetString;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _GetBool GetBool;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal _GetInt32 GetInt32;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal _GetFloat GetFloat;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal _GetString GetString;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal _RemoveSection RemoveSection;

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal _RemoveKeyInSection RemoveKeyInSection;
	}
	[Token(Token = "0x2000299")]
	public struct IVRScreenshots
	{
		[Token(Token = "0x200029A")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRScreenshotError _RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename);

		[Token(Token = "0x200029B")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRScreenshotError _HookScreenshot([In][Out] EVRScreenshotType[] pSupportedTypes, int numTypes);

		[Token(Token = "0x200029C")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRScreenshotType _GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError);

		[Token(Token = "0x200029D")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError);

		[Token(Token = "0x200029E")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRScreenshotError _UpdateScreenshotProgress(uint screenshotHandle, float flProgress);

		[Token(Token = "0x200029F")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRScreenshotError _TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename);

		[Token(Token = "0x20002A0")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRScreenshotError _SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename);

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _RequestScreenshot RequestScreenshot;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _HookScreenshot HookScreenshot;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _GetScreenshotPropertyType GetScreenshotPropertyType;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal _GetScreenshotPropertyFilename GetScreenshotPropertyFilename;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal _UpdateScreenshotProgress UpdateScreenshotProgress;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal _TakeStereoScreenshot TakeStereoScreenshot;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal _SubmitScreenshot SubmitScreenshot;
	}
	[Token(Token = "0x20002A1")]
	public struct IVRResources
	{
		[Token(Token = "0x20002A2")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _LoadSharedResource(string pchResourceName, string pchBuffer, uint unBufferLen);

		[Token(Token = "0x20002A3")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetResourceFullPath(string pchResourceName, string pchResourceTypeDirectory, StringBuilder pchPathBuffer, uint unBufferLen);

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _LoadSharedResource LoadSharedResource;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _GetResourceFullPath GetResourceFullPath;
	}
	[Token(Token = "0x20002A4")]
	public struct IVRDriverManager
	{
		[Token(Token = "0x20002A5")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetDriverCount();

		[Token(Token = "0x20002A6")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetDriverName(uint nDriver, StringBuilder pchValue, uint unBufferSize);

		[Token(Token = "0x20002A7")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetDriverHandle(string pchDriverName);

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal _GetDriverCount GetDriverCount;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal _GetDriverName GetDriverName;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _GetDriverHandle GetDriverHandle;
	}
	[Token(Token = "0x20002A8")]
	public class CVRSystem
	{
		[Token(Token = "0x20002A9")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _PollNextEventPacked(ref VREvent_t_Packed pEvent, uint uncbVREvent);

		[StructLayout(2)]
		[Token(Token = "0x20002AA")]
		private struct PollNextEventUnion
		{
			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IVRSystem._PollNextEvent pPollNextEvent;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _PollNextEventPacked pPollNextEventPacked;
		}

		[Token(Token = "0x20002AB")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetControllerStatePacked(uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize);

		[StructLayout(2)]
		[Token(Token = "0x20002AC")]
		private struct GetControllerStateUnion
		{
			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IVRSystem._GetControllerState pGetControllerState;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _GetControllerStatePacked pGetControllerStatePacked;
		}

		[Token(Token = "0x20002AD")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetControllerStateWithPosePacked(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose);

		[StructLayout(2)]
		[Token(Token = "0x20002AE")]
		private struct GetControllerStateWithPoseUnion
		{
			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IVRSystem._GetControllerStateWithPose pGetControllerStateWithPose;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _GetControllerStateWithPosePacked pGetControllerStateWithPosePacked;
		}

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRSystem FnTable;

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x7C1824", Offset = "0x7C1824", VA = "0x7C1824")]
		internal CVRSystem(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x7C1944", Offset = "0x7C1944", VA = "0x7C1944")]
		public void GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight)
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x7C1970", Offset = "0x7C1970", VA = "0x7C1970")]
		public HmdMatrix44_t GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ)
		{
			return default(HmdMatrix44_t);
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x7C19B8", Offset = "0x7C19B8", VA = "0x7C19B8")]
		public void GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom)
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x7C19EC", Offset = "0x7C19EC", VA = "0x7C19EC")]
		public bool ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x7C1A10", Offset = "0x7C1A10", VA = "0x7C1A10")]
		public HmdMatrix34_t GetEyeToHeadTransform(EVREye eEye)
		{
			return default(HmdMatrix34_t);
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x7C1A58", Offset = "0x7C1A58", VA = "0x7C1A58")]
		public bool GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x7C1A84", Offset = "0x7C1A84", VA = "0x7C1A84")]
		public int GetD3D9AdapterIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x7C1AA8", Offset = "0x7C1AA8", VA = "0x7C1AA8")]
		public void GetDXGIOutputInfo(ref int pnAdapterIndex)
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x7C1AD0", Offset = "0x7C1AD0", VA = "0x7C1AD0")]
		public void GetOutputDevice(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance)
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x7C1AF8", Offset = "0x7C1AF8", VA = "0x7C1AF8")]
		public bool IsDisplayOnDesktop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x7C1B1C", Offset = "0x7C1B1C", VA = "0x7C1B1C")]
		public bool SetDisplayVisibility(bool bIsVisibleOnDesktop)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x7C1B44", Offset = "0x7C1B44", VA = "0x7C1B44")]
		public void GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, TrackedDevicePose_t[] pTrackedDevicePoseArray)
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x7C1B70", Offset = "0x7C1B70", VA = "0x7C1B70")]
		public void ResetSeatedZeroPose()
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x7C1B94", Offset = "0x7C1B94", VA = "0x7C1B94")]
		public HmdMatrix34_t GetSeatedZeroPoseToStandingAbsoluteTrackingPose()
		{
			return default(HmdMatrix34_t);
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x7C1BDC", Offset = "0x7C1BDC", VA = "0x7C1BDC")]
		public HmdMatrix34_t GetRawZeroPoseToStandingAbsoluteTrackingPose()
		{
			return default(HmdMatrix34_t);
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x7C1C24", Offset = "0x7C1C24", VA = "0x7C1C24")]
		public uint GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, uint[] punTrackedDeviceIndexArray, uint unRelativeToTrackedDeviceIndex)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x7C1C54", Offset = "0x7C1C54", VA = "0x7C1C54")]
		public EDeviceActivityLevel GetTrackedDeviceActivityLevel(uint unDeviceId)
		{
			return default(EDeviceActivityLevel);
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x7C1C78", Offset = "0x7C1C78", VA = "0x7C1C78")]
		public void ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform)
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x7C1C9C", Offset = "0x7C1C9C", VA = "0x7C1C9C")]
		public uint GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x7C1CC0", Offset = "0x7C1CC0", VA = "0x7C1CC0")]
		public ETrackedControllerRole GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex)
		{
			return default(ETrackedControllerRole);
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x7C1CE4", Offset = "0x7C1CE4", VA = "0x7C1CE4")]
		public ETrackedDeviceClass GetTrackedDeviceClass(uint unDeviceIndex)
		{
			return default(ETrackedDeviceClass);
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x7C1D08", Offset = "0x7C1D08", VA = "0x7C1D08")]
		public bool IsTrackedDeviceConnected(uint unDeviceIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x7C1D2C", Offset = "0x7C1D2C", VA = "0x7C1D2C")]
		public bool GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x7C1D50", Offset = "0x7C1D50", VA = "0x7C1D50")]
		public float GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return default(float);
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x7C1D74", Offset = "0x7C1D74", VA = "0x7C1D74")]
		public int GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return default(int);
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x7C1D98", Offset = "0x7C1D98", VA = "0x7C1D98")]
		public ulong GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x7C1DBC", Offset = "0x7C1DBC", VA = "0x7C1DBC")]
		public HmdMatrix34_t GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return default(HmdMatrix34_t);
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x7C1E04", Offset = "0x7C1E04", VA = "0x7C1E04")]
		public uint GetArrayTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, uint propType, IntPtr pBuffer, uint unBufferSize, ref ETrackedPropertyError pError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x7C1E28", Offset = "0x7C1E28", VA = "0x7C1E28")]
		public uint GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x7C1E4C", Offset = "0x7C1E4C", VA = "0x7C1E4C")]
		public string GetPropErrorNameFromEnum(ETrackedPropertyError error)
		{
			return null;
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x7C1ED0", Offset = "0x7C1ED0", VA = "0x7C1ED0")]
		public bool PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x7C2064", Offset = "0x7C2064", VA = "0x7C2064")]
		public bool PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x7C2088", Offset = "0x7C2088", VA = "0x7C2088")]
		public string GetEventTypeNameFromEnum(EVREventType eType)
		{
			return null;
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x7C210C", Offset = "0x7C210C", VA = "0x7C210C")]
		public HiddenAreaMesh_t GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type)
		{
			return default(HiddenAreaMesh_t);
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x7C2130", Offset = "0x7C2130", VA = "0x7C2130")]
		public bool GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x7C22F0", Offset = "0x7C22F0", VA = "0x7C22F0")]
		public bool GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x7C24D0", Offset = "0x7C24D0", VA = "0x7C24D0")]
		public void TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, char usDurationMicroSec)
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x7C24F4", Offset = "0x7C24F4", VA = "0x7C24F4")]
		public string GetButtonIdNameFromEnum(EVRButtonId eButtonId)
		{
			return null;
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x7C2578", Offset = "0x7C2578", VA = "0x7C2578")]
		public string GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType)
		{
			return null;
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x7C25FC", Offset = "0x7C25FC", VA = "0x7C25FC")]
		public bool IsInputAvailable()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x7C2620", Offset = "0x7C2620", VA = "0x7C2620")]
		public bool IsSteamVRDrawingControllers()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x7C2644", Offset = "0x7C2644", VA = "0x7C2644")]
		public bool ShouldApplicationPause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x7C2668", Offset = "0x7C2668", VA = "0x7C2668")]
		public bool ShouldApplicationReduceRenderingWork()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x7C268C", Offset = "0x7C268C", VA = "0x7C268C")]
		public uint DriverDebugRequest(uint unDeviceIndex, string pchRequest, StringBuilder pchResponseBuffer, uint unResponseBufferSize)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x7C26B0", Offset = "0x7C26B0", VA = "0x7C26B0")]
		public EVRFirmwareError PerformFirmwareUpdate(uint unDeviceIndex)
		{
			return default(EVRFirmwareError);
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x7C26D4", Offset = "0x7C26D4", VA = "0x7C26D4")]
		public void AcknowledgeQuit_Exiting()
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x7C26F8", Offset = "0x7C26F8", VA = "0x7C26F8")]
		public void AcknowledgeQuit_UserPrompt()
		{
		}
	}
	[Token(Token = "0x20002AF")]
	public class CVRExtendedDisplay
	{
		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRExtendedDisplay FnTable;

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x7C2CB4", Offset = "0x7C2CB4", VA = "0x7C2CB4")]
		internal CVRExtendedDisplay(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x7C2DD0", Offset = "0x7C2DD0", VA = "0x7C2DD0")]
		public void GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight)
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x7C2E04", Offset = "0x7C2E04", VA = "0x7C2E04")]
		public void GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight)
		{
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x7C2E38", Offset = "0x7C2E38", VA = "0x7C2E38")]
		public void GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex)
		{
		}
	}
	[Token(Token = "0x20002B0")]
	public class CVRTrackedCamera
	{
		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRTrackedCamera FnTable;

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x7C2E64", Offset = "0x7C2E64", VA = "0x7C2E64")]
		internal CVRTrackedCamera(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x7C2F84", Offset = "0x7C2F84", VA = "0x7C2F84")]
		public string GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError)
		{
			return null;
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x7C3008", Offset = "0x7C3008", VA = "0x7C3008")]
		public EVRTrackedCameraError HasCamera(uint nDeviceIndex, ref bool pHasCamera)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x7C3030", Offset = "0x7C3030", VA = "0x7C3030")]
		public EVRTrackedCameraError GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x7C3060", Offset = "0x7C3060", VA = "0x7C3060")]
		public EVRTrackedCameraError GetCameraIntrinsics(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x7C3084", Offset = "0x7C3084", VA = "0x7C3084")]
		public EVRTrackedCameraError GetCameraProjection(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x7C30A8", Offset = "0x7C30A8", VA = "0x7C30A8")]
		public EVRTrackedCameraError AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x7C30D0", Offset = "0x7C30D0", VA = "0x7C30D0")]
		public EVRTrackedCameraError ReleaseVideoStreamingService(ulong hTrackedCamera)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x7C30F4", Offset = "0x7C30F4", VA = "0x7C30F4")]
		public EVRTrackedCameraError GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x7C3118", Offset = "0x7C3118", VA = "0x7C3118")]
		public EVRTrackedCameraError GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x7C3144", Offset = "0x7C3144", VA = "0x7C3144")]
		public EVRTrackedCameraError GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x7C3168", Offset = "0x7C3168", VA = "0x7C3168")]
		public EVRTrackedCameraError GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize)
		{
			return default(EVRTrackedCameraError);
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x7C3190", Offset = "0x7C3190", VA = "0x7C3190")]
		public EVRTrackedCameraError ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId)
		{
			return default(EVRTrackedCameraError);
		}
	}
	[Token(Token = "0x20002B1")]
	public class CVRApplications
	{
		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRApplications FnTable;

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x7C41B4", Offset = "0x7C41B4", VA = "0x7C41B4")]
		internal CVRApplications(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x7C42D4", Offset = "0x7C42D4", VA = "0x7C42D4")]
		public EVRApplicationError AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x7C42FC", Offset = "0x7C42FC", VA = "0x7C42FC")]
		public EVRApplicationError RemoveApplicationManifest(string pchApplicationManifestFullPath)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x7C4320", Offset = "0x7C4320", VA = "0x7C4320")]
		public bool IsApplicationInstalled(string pchAppKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x7C4344", Offset = "0x7C4344", VA = "0x7C4344")]
		public uint GetApplicationCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x7C4368", Offset = "0x7C4368", VA = "0x7C4368")]
		public EVRApplicationError GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x7C438C", Offset = "0x7C438C", VA = "0x7C438C")]
		public EVRApplicationError GetApplicationKeyByProcessId(uint unProcessId, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x7C43B0", Offset = "0x7C43B0", VA = "0x7C43B0")]
		public EVRApplicationError LaunchApplication(string pchAppKey)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x7C43D4", Offset = "0x7C43D4", VA = "0x7C43D4")]
		public EVRApplicationError LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, AppOverrideKeys_t[] pKeys)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x7C4400", Offset = "0x7C4400", VA = "0x7C4400")]
		public EVRApplicationError LaunchApplicationFromMimeType(string pchMimeType, string pchArgs)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x7C4424", Offset = "0x7C4424", VA = "0x7C4424")]
		public EVRApplicationError LaunchDashboardOverlay(string pchAppKey)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x7C4448", Offset = "0x7C4448", VA = "0x7C4448")]
		public bool CancelApplicationLaunch(string pchAppKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x7C446C", Offset = "0x7C446C", VA = "0x7C446C")]
		public EVRApplicationError IdentifyApplication(uint unProcessId, string pchAppKey)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x7C4490", Offset = "0x7C4490", VA = "0x7C4490")]
		public uint GetApplicationProcessId(string pchAppKey)
		{
			return default(uint);
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x7C44B4", Offset = "0x7C44B4", VA = "0x7C44B4")]
		public string GetApplicationsErrorNameFromEnum(EVRApplicationError error)
		{
			return null;
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x7C4538", Offset = "0x7C4538", VA = "0x7C4538")]
		public uint GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x7C455C", Offset = "0x7C455C", VA = "0x7C455C")]
		public bool GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x7C4580", Offset = "0x7C4580", VA = "0x7C4580")]
		public ulong GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x7C45A4", Offset = "0x7C45A4", VA = "0x7C45A4")]
		public EVRApplicationError SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x7C45CC", Offset = "0x7C45CC", VA = "0x7C45CC")]
		public bool GetApplicationAutoLaunch(string pchAppKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x7C45F0", Offset = "0x7C45F0", VA = "0x7C45F0")]
		public EVRApplicationError SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x7C4614", Offset = "0x7C4614", VA = "0x7C4614")]
		public bool GetDefaultApplicationForMimeType(string pchMimeType, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x7C4638", Offset = "0x7C4638", VA = "0x7C4638")]
		public bool GetApplicationSupportedMimeTypes(string pchAppKey, StringBuilder pchMimeTypesBuffer, uint unMimeTypesBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x7C465C", Offset = "0x7C465C", VA = "0x7C465C")]
		public uint GetApplicationsThatSupportMimeType(string pchMimeType, StringBuilder pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer)
		{
			return default(uint);
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x7C4680", Offset = "0x7C4680", VA = "0x7C4680")]
		public uint GetApplicationLaunchArguments(uint unHandle, StringBuilder pchArgs, uint unArgs)
		{
			return default(uint);
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x7C46A4", Offset = "0x7C46A4", VA = "0x7C46A4")]
		public EVRApplicationError GetStartingApplication(StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x7C46C8", Offset = "0x7C46C8", VA = "0x7C46C8")]
		public EVRApplicationTransitionState GetTransitionState()
		{
			return default(EVRApplicationTransitionState);
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x7C46EC", Offset = "0x7C46EC", VA = "0x7C46EC")]
		public EVRApplicationError PerformApplicationPrelaunchCheck(string pchAppKey)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x7C4710", Offset = "0x7C4710", VA = "0x7C4710")]
		public string GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state)
		{
			return null;
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x7C4794", Offset = "0x7C4794", VA = "0x7C4794")]
		public bool IsQuitUserPromptRequested()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x7C47B8", Offset = "0x7C47B8", VA = "0x7C47B8")]
		public EVRApplicationError LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory)
		{
			return default(EVRApplicationError);
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x7C47DC", Offset = "0x7C47DC", VA = "0x7C47DC")]
		public uint GetCurrentSceneProcessId()
		{
			return default(uint);
		}
	}
	[Token(Token = "0x20002B2")]
	public class CVRChaperone
	{
		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRChaperone FnTable;

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x7C4800", Offset = "0x7C4800", VA = "0x7C4800")]
		internal CVRChaperone(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x7C4920", Offset = "0x7C4920", VA = "0x7C4920")]
		public ChaperoneCalibrationState GetCalibrationState()
		{
			return default(ChaperoneCalibrationState);
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x7C4944", Offset = "0x7C4944", VA = "0x7C4944")]
		public bool GetPlayAreaSize(ref float pSizeX, ref float pSizeZ)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x7C4970", Offset = "0x7C4970", VA = "0x7C4970")]
		public bool GetPlayAreaRect(ref HmdQuad_t rect)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x7C4994", Offset = "0x7C4994", VA = "0x7C4994")]
		public void ReloadInfo()
		{
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x7C49B8", Offset = "0x7C49B8", VA = "0x7C49B8")]
		public void SetSceneColor(HmdColor_t color)
		{
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x7C49DC", Offset = "0x7C49DC", VA = "0x7C49DC")]
		public void GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor)
		{
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x7C4A00", Offset = "0x7C4A00", VA = "0x7C4A00")]
		public bool AreBoundsVisible()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x7C4A24", Offset = "0x7C4A24", VA = "0x7C4A24")]
		public void ForceBoundsVisible(bool bForce)
		{
		}
	}
	[Token(Token = "0x20002B3")]
	public class CVRChaperoneSetup
	{
		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRChaperoneSetup FnTable;

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x7C4A4C", Offset = "0x7C4A4C", VA = "0x7C4A4C")]
		internal CVRChaperoneSetup(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x7C4B6C", Offset = "0x7C4B6C", VA = "0x7C4B6C")]
		public bool CommitWorkingCopy(EChaperoneConfigFile configFile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x7C4B90", Offset = "0x7C4B90", VA = "0x7C4B90")]
		public void RevertWorkingCopy()
		{
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x7C4BB4", Offset = "0x7C4BB4", VA = "0x7C4BB4")]
		public bool GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x7C4BE0", Offset = "0x7C4BE0", VA = "0x7C4BE0")]
		public bool GetWorkingPlayAreaRect(ref HmdQuad_t rect)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x7C4C04", Offset = "0x7C4C04", VA = "0x7C4C04")]
		public bool GetWorkingCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x7C4CB8", Offset = "0x7C4CB8", VA = "0x7C4CB8")]
		public bool GetLiveCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x7C4D6C", Offset = "0x7C4D6C", VA = "0x7C4D6C")]
		public bool GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x7C4D90", Offset = "0x7C4D90", VA = "0x7C4D90")]
		public bool GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x7C4DB4", Offset = "0x7C4DB4", VA = "0x7C4DB4")]
		public void SetWorkingPlayAreaSize(float sizeX, float sizeZ)
		{
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x7C4DD8", Offset = "0x7C4DD8", VA = "0x7C4DD8")]
		public void SetWorkingCollisionBoundsInfo(HmdQuad_t[] pQuadsBuffer)
		{
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x7C4E04", Offset = "0x7C4E04", VA = "0x7C4E04")]
		public void SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose)
		{
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x7C4E28", Offset = "0x7C4E28", VA = "0x7C4E28")]
		public void SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose)
		{
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x7C4E4C", Offset = "0x7C4E4C", VA = "0x7C4E4C")]
		public void ReloadFromDisk(EChaperoneConfigFile configFile)
		{
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x7C4E70", Offset = "0x7C4E70", VA = "0x7C4E70")]
		public bool GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x7C4E94", Offset = "0x7C4E94", VA = "0x7C4E94")]
		public void SetWorkingCollisionBoundsTagsInfo(byte[] pTagsBuffer)
		{
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x7C4EC0", Offset = "0x7C4EC0", VA = "0x7C4EC0")]
		public bool GetLiveCollisionBoundsTagsInfo(out byte[] pTagsBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x7C4F74", Offset = "0x7C4F74", VA = "0x7C4F74")]
		public bool SetWorkingPhysicalBoundsInfo(HmdQuad_t[] pQuadsBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x7C4FA0", Offset = "0x7C4FA0", VA = "0x7C4FA0")]
		public bool GetLivePhysicalBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x7C5054", Offset = "0x7C5054", VA = "0x7C5054")]
		public bool ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x7C507C", Offset = "0x7C507C", VA = "0x7C507C")]
		public bool ImportFromBufferToWorking(string pBuffer, uint nImportFlags)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20002B4")]
	public class CVRCompositor
	{
		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRCompositor FnTable;

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x7C50A0", Offset = "0x7C50A0", VA = "0x7C50A0")]
		internal CVRCompositor(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x7C51C0", Offset = "0x7C51C0", VA = "0x7C51C0")]
		public void SetTrackingSpace(ETrackingUniverseOrigin eOrigin)
		{
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x7C51E4", Offset = "0x7C51E4", VA = "0x7C51E4")]
		public ETrackingUniverseOrigin GetTrackingSpace()
		{
			return default(ETrackingUniverseOrigin);
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x7C5208", Offset = "0x7C5208", VA = "0x7C5208")]
		public EVRCompositorError WaitGetPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x7C5240", Offset = "0x7C5240", VA = "0x7C5240")]
		public EVRCompositorError GetLastPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x7C5278", Offset = "0x7C5278", VA = "0x7C5278")]
		public EVRCompositorError GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x7C529C", Offset = "0x7C529C", VA = "0x7C529C")]
		public EVRCompositorError Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x7C52C0", Offset = "0x7C52C0", VA = "0x7C52C0")]
		public void ClearLastSubmittedFrame()
		{
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x7C52E4", Offset = "0x7C52E4", VA = "0x7C52E4")]
		public void PostPresentHandoff()
		{
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x7C5308", Offset = "0x7C5308", VA = "0x7C5308")]
		public bool GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x7C532C", Offset = "0x7C532C", VA = "0x7C532C")]
		public uint GetFrameTimings(ref Compositor_FrameTiming pTiming, uint nFrames)
		{
			return default(uint);
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x7C5350", Offset = "0x7C5350", VA = "0x7C5350")]
		public float GetFrameTimeRemaining()
		{
			return default(float);
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x7C5374", Offset = "0x7C5374", VA = "0x7C5374")]
		public void GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes)
		{
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x7C5398", Offset = "0x7C5398", VA = "0x7C5398")]
		public void FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground)
		{
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x7C53C0", Offset = "0x7C53C0", VA = "0x7C53C0")]
		public HmdColor_t GetCurrentFadeColor(bool bBackground)
		{
			return default(HmdColor_t);
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x7C53E8", Offset = "0x7C53E8", VA = "0x7C53E8")]
		public void FadeGrid(float fSeconds, bool bFadeIn)
		{
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x7C5410", Offset = "0x7C5410", VA = "0x7C5410")]
		public float GetCurrentGridAlpha()
		{
			return default(float);
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x7C5434", Offset = "0x7C5434", VA = "0x7C5434")]
		public EVRCompositorError SetSkyboxOverride(Texture_t[] pTextures)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x7C5460", Offset = "0x7C5460", VA = "0x7C5460")]
		public void ClearSkyboxOverride()
		{
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x7C5484", Offset = "0x7C5484", VA = "0x7C5484")]
		public void CompositorBringToFront()
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x7C54A8", Offset = "0x7C54A8", VA = "0x7C54A8")]
		public void CompositorGoToBack()
		{
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x7C54CC", Offset = "0x7C54CC", VA = "0x7C54CC")]
		public void CompositorQuit()
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x7C54F0", Offset = "0x7C54F0", VA = "0x7C54F0")]
		public bool IsFullscreen()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x7C5514", Offset = "0x7C5514", VA = "0x7C5514")]
		public uint GetCurrentSceneFocusProcess()
		{
			return default(uint);
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x7C5538", Offset = "0x7C5538", VA = "0x7C5538")]
		public uint GetLastFrameRenderer()
		{
			return default(uint);
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x7C555C", Offset = "0x7C555C", VA = "0x7C555C")]
		public bool CanRenderScene()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x7C5580", Offset = "0x7C5580", VA = "0x7C5580")]
		public void ShowMirrorWindow()
		{
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x7C55A4", Offset = "0x7C55A4", VA = "0x7C55A4")]
		public void HideMirrorWindow()
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x7C55C8", Offset = "0x7C55C8", VA = "0x7C55C8")]
		public bool IsMirrorWindowVisible()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x7C55EC", Offset = "0x7C55EC", VA = "0x7C55EC")]
		public void CompositorDumpImages()
		{
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x7C5610", Offset = "0x7C5610", VA = "0x7C5610")]
		public bool ShouldAppRenderWithLowResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x7C5634", Offset = "0x7C5634", VA = "0x7C5634")]
		public void ForceInterleavedReprojectionOn(bool bOverride)
		{
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x7C565C", Offset = "0x7C565C", VA = "0x7C565C")]
		public void ForceReconnectProcess()
		{
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x7C5680", Offset = "0x7C5680", VA = "0x7C5680")]
		public void SuspendRendering(bool bSuspend)
		{
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x7C56A8", Offset = "0x7C56A8", VA = "0x7C56A8")]
		public EVRCompositorError GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x7C56CC", Offset = "0x7C56CC", VA = "0x7C56CC")]
		public void ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView)
		{
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x7C56F0", Offset = "0x7C56F0", VA = "0x7C56F0")]
		public EVRCompositorError GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle)
		{
			return default(EVRCompositorError);
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x7C5718", Offset = "0x7C5718", VA = "0x7C5718")]
		public bool ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x7C573C", Offset = "0x7C573C", VA = "0x7C573C")]
		public void LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle)
		{
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x7C5760", Offset = "0x7C5760", VA = "0x7C5760")]
		public void UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle)
		{
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x7C5784", Offset = "0x7C5784", VA = "0x7C5784")]
		public uint GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x7C57A8", Offset = "0x7C57A8", VA = "0x7C57A8")]
		public uint GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x7C57CC", Offset = "0x7C57CC", VA = "0x7C57CC")]
		public void SetExplicitTimingMode(EVRCompositorTimingMode eTimingMode)
		{
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x7C57F0", Offset = "0x7C57F0", VA = "0x7C57F0")]
		public EVRCompositorError SubmitExplicitTimingData()
		{
			return default(EVRCompositorError);
		}
	}
	[Token(Token = "0x20002B5")]
	public class CVROverlay
	{
		[Token(Token = "0x20002B6")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _PollNextOverlayEventPacked(ulong ulOverlayHandle, ref VREvent_t_Packed pEvent, uint uncbVREvent);

		[StructLayout(2)]
		[Token(Token = "0x20002B7")]
		private struct PollNextOverlayEventUnion
		{
			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IVROverlay._PollNextOverlayEvent pPollNextOverlayEvent;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _PollNextOverlayEventPacked pPollNextOverlayEventPacked;
		}

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVROverlay FnTable;

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x7C5814", Offset = "0x7C5814", VA = "0x7C5814")]
		internal CVROverlay(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x7C5934", Offset = "0x7C5934", VA = "0x7C5934")]
		public EVROverlayError FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x7C595C", Offset = "0x7C595C", VA = "0x7C595C")]
		public EVROverlayError CreateOverlay(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x7C5984", Offset = "0x7C5984", VA = "0x7C5984")]
		public EVROverlayError DestroyOverlay(ulong ulOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x7C59A8", Offset = "0x7C59A8", VA = "0x7C59A8")]
		public EVROverlayError SetHighQualityOverlay(ulong ulOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x7C59CC", Offset = "0x7C59CC", VA = "0x7C59CC")]
		public ulong GetHighQualityOverlay()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x7C59F0", Offset = "0x7C59F0", VA = "0x7C59F0")]
		public uint GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x7C5A14", Offset = "0x7C5A14", VA = "0x7C5A14")]
		public uint GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x7C5A38", Offset = "0x7C5A38", VA = "0x7C5A38")]
		public EVROverlayError SetOverlayName(ulong ulOverlayHandle, string pchName)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x7C5A5C", Offset = "0x7C5A5C", VA = "0x7C5A5C")]
		public EVROverlayError GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x7C5A88", Offset = "0x7C5A88", VA = "0x7C5A88")]
		public string GetOverlayErrorNameFromEnum(EVROverlayError error)
		{
			return null;
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x7C5B0C", Offset = "0x7C5B0C", VA = "0x7C5B0C")]
		public EVROverlayError SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x7C5B30", Offset = "0x7C5B30", VA = "0x7C5B30")]
		public uint GetOverlayRenderingPid(ulong ulOverlayHandle)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x7C5B54", Offset = "0x7C5B54", VA = "0x7C5B54")]
		public EVROverlayError SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x7C5B7C", Offset = "0x7C5B7C", VA = "0x7C5B7C")]
		public EVROverlayError GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x7C5BA4", Offset = "0x7C5BA4", VA = "0x7C5BA4")]
		public EVROverlayError SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x7C5BC8", Offset = "0x7C5BC8", VA = "0x7C5BC8")]
		public EVROverlayError GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x7C5BF8", Offset = "0x7C5BF8", VA = "0x7C5BF8")]
		public EVROverlayError SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x7C5C1C", Offset = "0x7C5C1C", VA = "0x7C5C1C")]
		public EVROverlayError GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x7C5C44", Offset = "0x7C5C44", VA = "0x7C5C44")]
		public EVROverlayError SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x7C5C68", Offset = "0x7C5C68", VA = "0x7C5C68")]
		public EVROverlayError GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x7C5C90", Offset = "0x7C5C90", VA = "0x7C5C90")]
		public EVROverlayError SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x7C5CB4", Offset = "0x7C5CB4", VA = "0x7C5CB4")]
		public EVROverlayError GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x7C5CDC", Offset = "0x7C5CDC", VA = "0x7C5CDC")]
		public EVROverlayError SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x7C5D00", Offset = "0x7C5D00", VA = "0x7C5D00")]
		public EVROverlayError GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x7C5D28", Offset = "0x7C5D28", VA = "0x7C5D28")]
		public EVROverlayError SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x7C5D4C", Offset = "0x7C5D4C", VA = "0x7C5D4C")]
		public EVROverlayError GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x7C5D78", Offset = "0x7C5D78", VA = "0x7C5D78")]
		public EVROverlayError SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x7C5D9C", Offset = "0x7C5D9C", VA = "0x7C5D9C")]
		public EVROverlayError GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x7C5DC0", Offset = "0x7C5DC0", VA = "0x7C5DC0")]
		public EVROverlayError SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x7C5DE4", Offset = "0x7C5DE4", VA = "0x7C5DE4")]
		public EVROverlayError GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x7C5E08", Offset = "0x7C5E08", VA = "0x7C5E08")]
		public uint GetOverlayRenderModel(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref HmdColor_t pColor, ref EVROverlayError pError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x7C5E2C", Offset = "0x7C5E2C", VA = "0x7C5E2C")]
		public EVROverlayError SetOverlayRenderModel(ulong ulOverlayHandle, string pchRenderModel, ref HmdColor_t pColor)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x7C5E50", Offset = "0x7C5E50", VA = "0x7C5E50")]
		public EVROverlayError GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x7C5E74", Offset = "0x7C5E74", VA = "0x7C5E74")]
		public EVROverlayError SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x7C5E98", Offset = "0x7C5E98", VA = "0x7C5E98")]
		public EVROverlayError GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x7C5EBC", Offset = "0x7C5EBC", VA = "0x7C5EBC")]
		public EVROverlayError SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x7C5EE0", Offset = "0x7C5EE0", VA = "0x7C5EE0")]
		public EVROverlayError GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x7C5F08", Offset = "0x7C5F08", VA = "0x7C5F08")]
		public EVROverlayError SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x7C5F2C", Offset = "0x7C5F2C", VA = "0x7C5F2C")]
		public EVROverlayError GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, StringBuilder pchComponentName, uint unComponentNameSize)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x7C5F54", Offset = "0x7C5F54", VA = "0x7C5F54")]
		public EVROverlayError GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x7C5F7C", Offset = "0x7C5F7C", VA = "0x7C5F7C")]
		public EVROverlayError SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x7C5FA0", Offset = "0x7C5FA0", VA = "0x7C5FA0")]
		public EVROverlayError ShowOverlay(ulong ulOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x7C5FC4", Offset = "0x7C5FC4", VA = "0x7C5FC4")]
		public EVROverlayError HideOverlay(ulong ulOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x7C5FE8", Offset = "0x7C5FE8", VA = "0x7C5FE8")]
		public bool IsOverlayVisible(ulong ulOverlayHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x7C600C", Offset = "0x7C600C", VA = "0x7C600C")]
		public EVROverlayError GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x7C6030", Offset = "0x7C6030", VA = "0x7C6030")]
		public bool PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x7C61FC", Offset = "0x7C61FC", VA = "0x7C61FC")]
		public EVROverlayError GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x7C6220", Offset = "0x7C6220", VA = "0x7C6220")]
		public EVROverlayError SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x7C6244", Offset = "0x7C6244", VA = "0x7C6244")]
		public EVROverlayError GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x7C6268", Offset = "0x7C6268", VA = "0x7C6268")]
		public EVROverlayError SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x7C628C", Offset = "0x7C628C", VA = "0x7C628C")]
		public bool ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x7C62B0", Offset = "0x7C62B0", VA = "0x7C62B0")]
		public bool IsHoverTargetOverlay(ulong ulOverlayHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x7C62D4", Offset = "0x7C62D4", VA = "0x7C62D4")]
		public ulong GetGamepadFocusOverlay()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x7C62F8", Offset = "0x7C62F8", VA = "0x7C62F8")]
		public EVROverlayError SetGamepadFocusOverlay(ulong ulNewFocusOverlay)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x7C631C", Offset = "0x7C631C", VA = "0x7C631C")]
		public EVROverlayError SetOverlayNeighbor(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x7C6340", Offset = "0x7C6340", VA = "0x7C6340")]
		public EVROverlayError MoveGamepadFocusToNeighbor(EOverlayDirection eDirection, ulong ulFrom)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x7C6364", Offset = "0x7C6364", VA = "0x7C6364")]
		public EVROverlayError SetOverlayDualAnalogTransform(ulong ulOverlay, EDualAnalogWhich eWhich, IntPtr vCenter, float fRadius)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x7C6388", Offset = "0x7C6388", VA = "0x7C6388")]
		public EVROverlayError GetOverlayDualAnalogTransform(ulong ulOverlay, EDualAnalogWhich eWhich, ref HmdVector2_t pvCenter, ref float pfRadius)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x7C63B0", Offset = "0x7C63B0", VA = "0x7C63B0")]
		public EVROverlayError SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x7C63D4", Offset = "0x7C63D4", VA = "0x7C63D4")]
		public EVROverlayError ClearOverlayTexture(ulong ulOverlayHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x7C63F8", Offset = "0x7C63F8", VA = "0x7C63F8")]
		public EVROverlayError SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x7C641C", Offset = "0x7C641C", VA = "0x7C641C")]
		public EVROverlayError SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x7C6440", Offset = "0x7C6440", VA = "0x7C6440")]
		public EVROverlayError GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x7C647C", Offset = "0x7C647C", VA = "0x7C647C")]
		public EVROverlayError ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x7C64A0", Offset = "0x7C64A0", VA = "0x7C64A0")]
		public EVROverlayError GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x7C64CC", Offset = "0x7C64CC", VA = "0x7C64CC")]
		public EVROverlayError CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x7C64F8", Offset = "0x7C64F8", VA = "0x7C64F8")]
		public bool IsDashboardVisible()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x7C651C", Offset = "0x7C651C", VA = "0x7C651C")]
		public bool IsActiveDashboardOverlay(ulong ulOverlayHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x7C6540", Offset = "0x7C6540", VA = "0x7C6540")]
		public EVROverlayError SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x7C6564", Offset = "0x7C6564", VA = "0x7C6564")]
		public EVROverlayError GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x7C658C", Offset = "0x7C658C", VA = "0x7C658C")]
		public void ShowDashboard(string pchOverlayToShow)
		{
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x7C65B0", Offset = "0x7C65B0", VA = "0x7C65B0")]
		public uint GetPrimaryDashboardDevice()
		{
			return default(uint);
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x7C65D4", Offset = "0x7C65D4", VA = "0x7C65D4")]
		public EVROverlayError ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x7C6600", Offset = "0x7C6600", VA = "0x7C6600")]
		public EVROverlayError ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x7C6630", Offset = "0x7C6630", VA = "0x7C6630")]
		public uint GetKeyboardText(StringBuilder pchText, uint cchText)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x7C6654", Offset = "0x7C6654", VA = "0x7C6654")]
		public void HideKeyboard()
		{
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x7C6678", Offset = "0x7C6678", VA = "0x7C6678")]
		public void SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform)
		{
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x7C669C", Offset = "0x7C669C", VA = "0x7C669C")]
		public void SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect)
		{
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x7C66C0", Offset = "0x7C66C0", VA = "0x7C66C0")]
		public EVROverlayError SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x7C66E4", Offset = "0x7C66E4", VA = "0x7C66E4")]
		public EVROverlayError GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags)
		{
			return default(EVROverlayError);
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x7C670C", Offset = "0x7C670C", VA = "0x7C670C")]
		public VRMessageOverlayResponse ShowMessageOverlay(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text)
		{
			return default(VRMessageOverlayResponse);
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x7C6730", Offset = "0x7C6730", VA = "0x7C6730")]
		public void CloseMessageOverlay()
		{
		}
	}
	[Token(Token = "0x20002B8")]
	public class CVRRenderModels
	{
		[Token(Token = "0x20002B9")]
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetComponentStatePacked(string pchRenderModelName, string pchComponentName, ref VRControllerState_t_Packed pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);

		[StructLayout(2)]
		[Token(Token = "0x20002BA")]
		private struct GetComponentStateUnion
		{
			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IVRRenderModels._GetComponentState pGetComponentState;

			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _GetComponentStatePacked pGetComponentStatePacked;
		}

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRRenderModels FnTable;

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x7C692C", Offset = "0x7C692C", VA = "0x7C692C")]
		internal CVRRenderModels(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x7C6A4C", Offset = "0x7C6A4C", VA = "0x7C6A4C")]
		public EVRRenderModelError LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel)
		{
			return default(EVRRenderModelError);
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x7C6A70", Offset = "0x7C6A70", VA = "0x7C6A70")]
		public void FreeRenderModel(IntPtr pRenderModel)
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x7C6A94", Offset = "0x7C6A94", VA = "0x7C6A94")]
		public EVRRenderModelError LoadTexture_Async(int textureId, ref IntPtr ppTexture)
		{
			return default(EVRRenderModelError);
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x7C6AB8", Offset = "0x7C6AB8", VA = "0x7C6AB8")]
		public void FreeTexture(IntPtr pTexture)
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x7C6ADC", Offset = "0x7C6ADC", VA = "0x7C6ADC")]
		public EVRRenderModelError LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D)
		{
			return default(EVRRenderModelError);
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x7C6B00", Offset = "0x7C6B00", VA = "0x7C6B00")]
		public EVRRenderModelError LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture)
		{
			return default(EVRRenderModelError);
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x7C6B24", Offset = "0x7C6B24", VA = "0x7C6B24")]
		public void FreeTextureD3D11(IntPtr pD3D11Texture2D)
		{
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x7C6B48", Offset = "0x7C6B48", VA = "0x7C6B48")]
		public uint GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x7C6B6C", Offset = "0x7C6B6C", VA = "0x7C6B6C")]
		public uint GetRenderModelCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x7C6B90", Offset = "0x7C6B90", VA = "0x7C6B90")]
		public uint GetComponentCount(string pchRenderModelName)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x7C6BB4", Offset = "0x7C6BB4", VA = "0x7C6BB4")]
		public uint GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x7C6BD8", Offset = "0x7C6BD8", VA = "0x7C6BD8")]
		public ulong GetComponentButtonMask(string pchRenderModelName, string pchComponentName)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x7C6BFC", Offset = "0x7C6BFC", VA = "0x7C6BFC")]
		public uint GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x7C6C20", Offset = "0x7C6C20", VA = "0x7C6C20")]
		public bool GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x7C6DF8", Offset = "0x7C6DF8", VA = "0x7C6DF8")]
		public bool RenderModelHasComponent(string pchRenderModelName, string pchComponentName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x7C6E1C", Offset = "0x7C6E1C", VA = "0x7C6E1C")]
		public uint GetRenderModelThumbnailURL(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x7C6E40", Offset = "0x7C6E40", VA = "0x7C6E40")]
		public uint GetRenderModelOriginalPath(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x7C6E64", Offset = "0x7C6E64", VA = "0x7C6E64")]
		public string GetRenderModelErrorNameFromEnum(EVRRenderModelError error)
		{
			return null;
		}
	}
	[Token(Token = "0x20002BB")]
	public class CVRNotifications
	{
		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRNotifications FnTable;

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x7C70E8", Offset = "0x7C70E8", VA = "0x7C70E8")]
		internal CVRNotifications(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x7C71FC", Offset = "0x7C71FC", VA = "0x7C71FC")]
		public EVRNotificationError CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId)
		{
			return default(EVRNotificationError);
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x7C7228", Offset = "0x7C7228", VA = "0x7C7228")]
		public EVRNotificationError RemoveNotification(uint notificationId)
		{
			return default(EVRNotificationError);
		}
	}
	[Token(Token = "0x20002BC")]
	public class CVRSettings
	{
		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRSettings FnTable;

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x7C724C", Offset = "0x7C724C", VA = "0x7C724C")]
		internal CVRSettings(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x7C736C", Offset = "0x7C736C", VA = "0x7C736C")]
		public string GetSettingsErrorNameFromEnum(EVRSettingsError eError)
		{
			return null;
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x7C73F0", Offset = "0x7C73F0", VA = "0x7C73F0")]
		public bool Sync(bool bForce, ref EVRSettingsError peError)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x7C7418", Offset = "0x7C7418", VA = "0x7C7418")]
		public void SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError)
		{
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x7C7440", Offset = "0x7C7440", VA = "0x7C7440")]
		public void SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError)
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x7C7464", Offset = "0x7C7464", VA = "0x7C7464")]
		public void SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError)
		{
		}

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x7C7488", Offset = "0x7C7488", VA = "0x7C7488")]
		public void SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError)
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x7C74AC", Offset = "0x7C74AC", VA = "0x7C74AC")]
		public bool GetBool(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x7C74D0", Offset = "0x7C74D0", VA = "0x7C74D0")]
		public int GetInt32(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
		{
			return default(int);
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x7C74F4", Offset = "0x7C74F4", VA = "0x7C74F4")]
		public float GetFloat(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
		{
			return default(float);
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x7C7518", Offset = "0x7C7518", VA = "0x7C7518")]
		public void GetString(string pchSection, string pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError)
		{
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x7C753C", Offset = "0x7C753C", VA = "0x7C753C")]
		public void RemoveSection(string pchSection, ref EVRSettingsError peError)
		{
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x7C7560", Offset = "0x7C7560", VA = "0x7C7560")]
		public void RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError)
		{
		}
	}
	[Token(Token = "0x20002BD")]
	public class CVRScreenshots
	{
		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRScreenshots FnTable;

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x7C7584", Offset = "0x7C7584", VA = "0x7C7584")]
		internal CVRScreenshots(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x7C76AC", Offset = "0x7C76AC", VA = "0x7C76AC")]
		public EVRScreenshotError RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename)
		{
			return default(EVRScreenshotError);
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x7C76D4", Offset = "0x7C76D4", VA = "0x7C76D4")]
		public EVRScreenshotError HookScreenshot(EVRScreenshotType[] pSupportedTypes)
		{
			return default(EVRScreenshotError);
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x7C7700", Offset = "0x7C7700", VA = "0x7C7700")]
		public EVRScreenshotType GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError)
		{
			return default(EVRScreenshotType);
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x7C7724", Offset = "0x7C7724", VA = "0x7C7724")]
		public uint GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x7C7748", Offset = "0x7C7748", VA = "0x7C7748")]
		public EVRScreenshotError UpdateScreenshotProgress(uint screenshotHandle, float flProgress)
		{
			return default(EVRScreenshotError);
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x7C776C", Offset = "0x7C776C", VA = "0x7C776C")]
		public EVRScreenshotError TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename)
		{
			return default(EVRScreenshotError);
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x7C7794", Offset = "0x7C7794", VA = "0x7C7794")]
		public EVRScreenshotError SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename)
		{
			return default(EVRScreenshotError);
		}
	}
	[Token(Token = "0x20002BE")]
	public class CVRResources
	{
		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRResources FnTable;

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x7C77B8", Offset = "0x7C77B8", VA = "0x7C77B8")]
		internal CVRResources(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x7C78CC", Offset = "0x7C78CC", VA = "0x7C78CC")]
		public uint LoadSharedResource(string pchResourceName, string pchBuffer, uint unBufferLen)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x7C78F0", Offset = "0x7C78F0", VA = "0x7C78F0")]
		public uint GetResourceFullPath(string pchResourceName, string pchResourceTypeDirectory, StringBuilder pchPathBuffer, uint unBufferLen)
		{
			return default(uint);
		}
	}
	[Token(Token = "0x20002BF")]
	public class CVRDriverManager
	{
		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IVRDriverManager FnTable;

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x7C7914", Offset = "0x7C7914", VA = "0x7C7914")]
		internal CVRDriverManager(IntPtr pInterface)
		{
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x7C7A30", Offset = "0x7C7A30", VA = "0x7C7A30")]
		public uint GetDriverCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x7C7A54", Offset = "0x7C7A54", VA = "0x7C7A54")]
		public uint GetDriverName(uint nDriver, StringBuilder pchValue, uint unBufferSize)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x7C7A78", Offset = "0x7C7A78", VA = "0x7C7A78")]
		public ulong GetDriverHandle(string pchDriverName)
		{
			return default(ulong);
		}
	}
	[Token(Token = "0x20002C0")]
	public class OpenVRInterop
	{
		[PreserveSig]
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x7C7A9C", Offset = "0x7C7A9C", VA = "0x7C7A9C")]
		internal static extern uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType);

		[PreserveSig]
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x7C7B20", Offset = "0x7C7B20", VA = "0x7C7B20")]
		internal static extern void ShutdownInternal();

		[PreserveSig]
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x7C7B84", Offset = "0x7C7B84", VA = "0x7C7B84")]
		internal static extern bool IsHmdPresent();

		[PreserveSig]
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x7C7BF4", Offset = "0x7C7BF4", VA = "0x7C7BF4")]
		internal static extern bool IsRuntimeInstalled();

		[PreserveSig]
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x7C7C64", Offset = "0x7C7C64", VA = "0x7C7C64")]
		internal static extern IntPtr GetStringForHmdError(EVRInitError error);

		[PreserveSig]
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x7C7CE0", Offset = "0x7C7CE0", VA = "0x7C7CE0")]
		internal static extern IntPtr GetGenericInterface([In] string pchInterfaceVersion, ref EVRInitError peError);

		[PreserveSig]
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x7C7D7C", Offset = "0x7C7D7C", VA = "0x7C7D7C")]
		internal static extern bool IsInterfaceVersionValid([In] string pchInterfaceVersion);

		[PreserveSig]
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x7C7E14", Offset = "0x7C7E14", VA = "0x7C7E14")]
		internal static extern uint GetInitToken();

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x7C7E7C", Offset = "0x7C7E7C", VA = "0x7C7E7C")]
		public OpenVRInterop()
		{
		}
	}
	[Token(Token = "0x20002C1")]
	public enum EVREye
	{
		[Token(Token = "0x40009BA")]
		Eye_Left,
		[Token(Token = "0x40009BB")]
		Eye_Right
	}
	[Token(Token = "0x20002C2")]
	public enum ETextureType
	{
		[Token(Token = "0x40009BD")]
		DirectX,
		[Token(Token = "0x40009BE")]
		OpenGL,
		[Token(Token = "0x40009BF")]
		Vulkan,
		[Token(Token = "0x40009C0")]
		IOSurface,
		[Token(Token = "0x40009C1")]
		DirectX12,
		[Token(Token = "0x40009C2")]
		DXGISharedHandle
	}
	[Token(Token = "0x20002C3")]
	public enum EColorSpace
	{
		[Token(Token = "0x40009C4")]
		Auto,
		[Token(Token = "0x40009C5")]
		Gamma,
		[Token(Token = "0x40009C6")]
		Linear
	}
	[Token(Token = "0x20002C4")]
	public enum ETrackingResult
	{
		[Token(Token = "0x40009C8")]
		Uninitialized = 1,
		[Token(Token = "0x40009C9")]
		Calibrating_InProgress = 100,
		[Token(Token = "0x40009CA")]
		Calibrating_OutOfRange = 101,
		[Token(Token = "0x40009CB")]
		Running_OK = 200,
		[Token(Token = "0x40009CC")]
		Running_OutOfRange = 201
	}
	[Token(Token = "0x20002C5")]
	public enum ETrackedDeviceClass
	{
		[Token(Token = "0x40009CE")]
		Invalid,
		[Token(Token = "0x40009CF")]
		HMD,
		[Token(Token = "0x40009D0")]
		Controller,
		[Token(Token = "0x40009D1")]
		GenericTracker,
		[Token(Token = "0x40009D2")]
		TrackingReference,
		[Token(Token = "0x40009D3")]
		DisplayRedirect
	}
	[Token(Token = "0x20002C6")]
	public enum ETrackedControllerRole
	{
		[Token(Token = "0x40009D5")]
		Invalid,
		[Token(Token = "0x40009D6")]
		LeftHand,
		[Token(Token = "0x40009D7")]
		RightHand,
		[Token(Token = "0x40009D8")]
		OptOut
	}
	[Token(Token = "0x20002C7")]
	public enum ETrackingUniverseOrigin
	{
		[Token(Token = "0x40009DA")]
		TrackingUniverseSeated,
		[Token(Token = "0x40009DB")]
		TrackingUniverseStanding,
		[Token(Token = "0x40009DC")]
		TrackingUniverseRawAndUncalibrated
	}
	[Token(Token = "0x20002C8")]
	public enum ETrackedDeviceProperty
	{
		[Token(Token = "0x40009DE")]
		Prop_Invalid = 0,
		[Token(Token = "0x40009DF")]
		Prop_TrackingSystemName_String = 1000,
		[Token(Token = "0x40009E0")]
		Prop_ModelNumber_String = 1001,
		[Token(Token = "0x40009E1")]
		Prop_SerialNumber_String = 1002,
		[Token(Token = "0x40009E2")]
		Prop_RenderModelName_String = 1003,
		[Token(Token = "0x40009E3")]
		Prop_WillDriftInYaw_Bool = 1004,
		[Token(Token = "0x40009E4")]
		Prop_ManufacturerName_String = 1005,
		[Token(Token = "0x40009E5")]
		Prop_TrackingFirmwareVersion_String = 1006,
		[Token(Token = "0x40009E6")]
		Prop_HardwareRevision_String = 1007,
		[Token(Token = "0x40009E7")]
		Prop_AllWirelessDongleDescriptions_String = 1008,
		[Token(Token = "0x40009E8")]
		Prop_ConnectedWirelessDongle_String = 1009,
		[Token(Token = "0x40009E9")]
		Prop_DeviceIsWireless_Bool = 1010,
		[Token(Token = "0x40009EA")]
		Prop_DeviceIsCharging_Bool = 1011,
		[Token(Token = "0x40009EB")]
		Prop_DeviceBatteryPercentage_Float = 1012,
		[Token(Token = "0x40009EC")]
		Prop_StatusDisplayTransform_Matrix34 = 1013,
		[Token(Token = "0x40009ED")]
		Prop_Firmware_UpdateAvailable_Bool = 1014,
		[Token(Token = "0x40009EE")]
		Prop_Firmware_ManualUpdate_Bool = 1015,
		[Token(Token = "0x40009EF")]
		Prop_Firmware_ManualUpdateURL_String = 1016,
		[Token(Token = "0x40009F0")]
		Prop_HardwareRevision_Uint64 = 1017,
		[Token(Token = "0x40009F1")]
		Prop_FirmwareVersion_Uint64 = 1018,
		[Token(Token = "0x40009F2")]
		Prop_FPGAVersion_Uint64 = 1019,
		[Token(Token = "0x40009F3")]
		Prop_VRCVersion_Uint64 = 1020,
		[Token(Token = "0x40009F4")]
		Prop_RadioVersion_Uint64 = 1021,
		[Token(Token = "0x40009F5")]
		Prop_DongleVersion_Uint64 = 1022,
		[Token(Token = "0x40009F6")]
		Prop_BlockServerShutdown_Bool = 1023,
		[Token(Token = "0x40009F7")]
		Prop_CanUnifyCoordinateSystemWithHmd_Bool = 1024,
		[Token(Token = "0x40009F8")]
		Prop_ContainsProximitySensor_Bool = 1025,
		[Token(Token = "0x40009F9")]
		Prop_DeviceProvidesBatteryStatus_Bool = 1026,
		[Token(Token = "0x40009FA")]
		Prop_DeviceCanPowerOff_Bool = 1027,
		[Token(Token = "0x40009FB")]
		Prop_Firmware_ProgrammingTarget_String = 1028,
		[Token(Token = "0x40009FC")]
		Prop_DeviceClass_Int32 = 1029,
		[Token(Token = "0x40009FD")]
		Prop_HasCamera_Bool = 1030,
		[Token(Token = "0x40009FE")]
		Prop_DriverVersion_String = 1031,
		[Token(Token = "0x40009FF")]
		Prop_Firmware_ForceUpdateRequired_Bool = 1032,
		[Token(Token = "0x4000A00")]
		Prop_ViveSystemButtonFixRequired_Bool = 1033,
		[Token(Token = "0x4000A01")]
		Prop_ParentDriver_Uint64 = 1034,
		[Token(Token = "0x4000A02")]
		Prop_ResourceRoot_String = 1035,
		[Token(Token = "0x4000A03")]
		Prop_RegisteredDeviceType_String = 1036,
		[Token(Token = "0x4000A04")]
		Prop_InputProfilePath_String = 1037,
		[Token(Token = "0x4000A05")]
		Prop_NeverTracked_Bool = 1038,
		[Token(Token = "0x4000A06")]
		Prop_ReportsTimeSinceVSync_Bool = 2000,
		[Token(Token = "0x4000A07")]
		Prop_SecondsFromVsyncToPhotons_Float = 2001,
		[Token(Token = "0x4000A08")]
		Prop_DisplayFrequency_Float = 2002,
		[Token(Token = "0x4000A09")]
		Prop_UserIpdMeters_Float = 2003,
		[Token(Token = "0x4000A0A")]
		Prop_CurrentUniverseId_Uint64 = 2004,
		[Token(Token = "0x4000A0B")]
		Prop_PreviousUniverseId_Uint64 = 2005,
		[Token(Token = "0x4000A0C")]
		Prop_DisplayFirmwareVersion_Uint64 = 2006,
		[Token(Token = "0x4000A0D")]
		Prop_IsOnDesktop_Bool = 2007,
		[Token(Token = "0x4000A0E")]
		Prop_DisplayMCType_Int32 = 2008,
		[Token(Token = "0x4000A0F")]
		Prop_DisplayMCOffset_Float = 2009,
		[Token(Token = "0x4000A10")]
		Prop_DisplayMCScale_Float = 2010,
		[Token(Token = "0x4000A11")]
		Prop_EdidVendorID_Int32 = 2011,
		[Token(Token = "0x4000A12")]
		Prop_DisplayMCImageLeft_String = 2012,
		[Token(Token = "0x4000A13")]
		Prop_DisplayMCImageRight_String = 2013,
		[Token(Token = "0x4000A14")]
		Prop_DisplayGCBlackClamp_Float = 2014,
		[Token(Token = "0x4000A15")]
		Prop_EdidProductID_Int32 = 2015,
		[Token(Token = "0x4000A16")]
		Prop_CameraToHeadTransform_Matrix34 = 2016,
		[Token(Token = "0x4000A17")]
		Prop_DisplayGCType_Int32 = 2017,
		[Token(Token = "0x4000A18")]
		Prop_DisplayGCOffset_Float = 2018,
		[Token(Token = "0x4000A19")]
		Prop_DisplayGCScale_Float = 2019,
		[Token(Token = "0x4000A1A")]
		Prop_DisplayGCPrescale_Float = 2020,
		[Token(Token = "0x4000A1B")]
		Prop_DisplayGCImage_String = 2021,
		[Token(Token = "0x4000A1C")]
		Prop_LensCenterLeftU_Float = 2022,
		[Token(Token = "0x4000A1D")]
		Prop_LensCenterLeftV_Float = 2023,
		[Token(Token = "0x4000A1E")]
		Prop_LensCenterRightU_Float = 2024,
		[Token(Token = "0x4000A1F")]
		Prop_LensCenterRightV_Float = 2025,
		[Token(Token = "0x4000A20")]
		Prop_UserHeadToEyeDepthMeters_Float = 2026,
		[Token(Token = "0x4000A21")]
		Prop_CameraFirmwareVersion_Uint64 = 2027,
		[Token(Token = "0x4000A22")]
		Prop_CameraFirmwareDescription_String = 2028,
		[Token(Token = "0x4000A23")]
		Prop_DisplayFPGAVersion_Uint64 = 2029,
		[Token(Token = "0x4000A24")]
		Prop_DisplayBootloaderVersion_Uint64 = 2030,
		[Token(Token = "0x4000A25")]
		Prop_DisplayHardwareVersion_Uint64 = 2031,
		[Token(Token = "0x4000A26")]
		Prop_AudioFirmwareVersion_Uint64 = 2032,
		[Token(Token = "0x4000A27")]
		Prop_CameraCompatibilityMode_Int32 = 2033,
		[Token(Token = "0x4000A28")]
		Prop_ScreenshotHorizontalFieldOfViewDegrees_Float = 2034,
		[Token(Token = "0x4000A29")]
		Prop_ScreenshotVerticalFieldOfViewDegrees_Float = 2035,
		[Token(Token = "0x4000A2A")]
		Prop_DisplaySuppressed_Bool = 2036,
		[Token(Token = "0x4000A2B")]
		Prop_DisplayAllowNightMode_Bool = 2037,
		[Token(Token = "0x4000A2C")]
		Prop_DisplayMCImageWidth_Int32 = 2038,
		[Token(Token = "0x4000A2D")]
		Prop_DisplayMCImageHeight_Int32 = 2039,
		[Token(Token = "0x4000A2E")]
		Prop_DisplayMCImageNumChannels_Int32 = 2040,
		[Token(Token = "0x4000A2F")]
		Prop_DisplayMCImageData_Binary = 2041,
		[Token(Token = "0x4000A30")]
		Prop_SecondsFromPhotonsToVblank_Float = 2042,
		[Token(Token = "0x4000A31")]
		Prop_DriverDirectModeSendsVsyncEvents_Bool = 2043,
		[Token(Token = "0x4000A32")]
		Prop_DisplayDebugMode_Bool = 2044,
		[Token(Token = "0x4000A33")]
		Prop_GraphicsAdapterLuid_Uint64 = 2045,
		[Token(Token = "0x4000A34")]
		Prop_DriverProvidedChaperonePath_String = 2048,
		[Token(Token = "0x4000A35")]
		Prop_ExpectedTrackingReferenceCount_Int32 = 2049,
		[Token(Token = "0x4000A36")]
		Prop_ExpectedControllerCount_Int32 = 2050,
		[Token(Token = "0x4000A37")]
		Prop_NamedIconPathControllerLeftDeviceOff_String = 2051,
		[Token(Token = "0x4000A38")]
		Prop_NamedIconPathControllerRightDeviceOff_String = 2052,
		[Token(Token = "0x4000A39")]
		Prop_NamedIconPathTrackingReferenceDeviceOff_String = 2053,
		[Token(Token = "0x4000A3A")]
		Prop_DoNotApplyPrediction_Bool = 2054,
		[Token(Token = "0x4000A3B")]
		Prop_CameraToHeadTransforms_Matrix34_Array = 2055,
		[Token(Token = "0x4000A3C")]
		Prop_DistortionMeshResolution_Int32 = 2056,
		[Token(Token = "0x4000A3D")]
		Prop_DriverIsDrawingControllers_Bool = 2057,
		[Token(Token = "0x4000A3E")]
		Prop_DriverRequestsApplicationPause_Bool = 2058,
		[Token(Token = "0x4000A3F")]
		Prop_DriverRequestsReducedRendering_Bool = 2059,
		[Token(Token = "0x4000A40")]
		Prop_MinimumIpdStepMeters_Float = 2060,
		[Token(Token = "0x4000A41")]
		Prop_AudioBridgeFirmwareVersion_Uint64 = 2061,
		[Token(Token = "0x4000A42")]
		Prop_ImageBridgeFirmwareVersion_Uint64 = 2062,
		[Token(Token = "0x4000A43")]
		Prop_AttachedDeviceId_String = 3000,
		[Token(Token = "0x4000A44")]
		Prop_SupportedButtons_Uint64 = 3001,
		[Token(Token = "0x4000A45")]
		Prop_Axis0Type_Int32 = 3002,
		[Token(Token = "0x4000A46")]
		Prop_Axis1Type_Int32 = 3003,
		[Token(Token = "0x4000A47")]
		Prop_Axis2Type_Int32 = 3004,
		[Token(Token = "0x4000A48")]
		Prop_Axis3Type_Int32 = 3005,
		[Token(Token = "0x4000A49")]
		Prop_Axis4Type_Int32 = 3006,
		[Token(Token = "0x4000A4A")]
		Prop_ControllerRoleHint_Int32 = 3007,
		[Token(Token = "0x4000A4B")]
		Prop_FieldOfViewLeftDegrees_Float = 4000,
		[Token(Token = "0x4000A4C")]
		Prop_FieldOfViewRightDegrees_Float = 4001,
		[Token(Token = "0x4000A4D")]
		Prop_FieldOfViewTopDegrees_Float = 4002,
		[Token(Token = "0x4000A4E")]
		Prop_FieldOfViewBottomDegrees_Float = 4003,
		[Token(Token = "0x4000A4F")]
		Prop_TrackingRangeMinimumMeters_Float = 4004,
		[Token(Token = "0x4000A50")]
		Prop_TrackingRangeMaximumMeters_Float = 4005,
		[Token(Token = "0x4000A51")]
		Prop_ModeLabel_String = 4006,
		[Token(Token = "0x4000A52")]
		Prop_IconPathName_String = 5000,
		[Token(Token = "0x4000A53")]
		Prop_NamedIconPathDeviceOff_String = 5001,
		[Token(Token = "0x4000A54")]
		Prop_NamedIconPathDeviceSearching_String = 5002,
		[Token(Token = "0x4000A55")]
		Prop_NamedIconPathDeviceSearchingAlert_String = 5003,
		[Token(Token = "0x4000A56")]
		Prop_NamedIconPathDeviceReady_String = 5004,
		[Token(Token = "0x4000A57")]
		Prop_NamedIconPathDeviceReadyAlert_String = 5005,
		[Token(Token = "0x4000A58")]
		Prop_NamedIconPathDeviceNotReady_String = 5006,
		[Token(Token = "0x4000A59")]
		Prop_NamedIconPathDeviceStandby_String = 5007,
		[Token(Token = "0x4000A5A")]
		Prop_NamedIconPathDeviceAlertLow_String = 5008,
		[Token(Token = "0x4000A5B")]
		Prop_DisplayHiddenArea_Binary_Start = 5100,
		[Token(Token = "0x4000A5C")]
		Prop_DisplayHiddenArea_Binary_End = 5150,
		[Token(Token = "0x4000A5D")]
		Prop_ParentContainer = 5151,
		[Token(Token = "0x4000A5E")]
		Prop_UserConfigPath_String = 6000,
		[Token(Token = "0x4000A5F")]
		Prop_InstallPath_String = 6001,
		[Token(Token = "0x4000A60")]
		Prop_HasDisplayComponent_Bool = 6002,
		[Token(Token = "0x4000A61")]
		Prop_HasControllerComponent_Bool = 6003,
		[Token(Token = "0x4000A62")]
		Prop_HasCameraComponent_Bool = 6004,
		[Token(Token = "0x4000A63")]
		Prop_HasDriverDirectModeComponent_Bool = 6005,
		[Token(Token = "0x4000A64")]
		Prop_HasVirtualDisplayComponent_Bool = 6006,
		[Token(Token = "0x4000A65")]
		Prop_ControllerType_String = 7000,
		[Token(Token = "0x4000A66")]
		Prop_LegacyInputProfile_String = 7001,
		[Token(Token = "0x4000A67")]
		Prop_VendorSpecific_Reserved_Start = 10000,
		[Token(Token = "0x4000A68")]
		Prop_VendorSpecific_Reserved_End = 10999,
		[Token(Token = "0x4000A69")]
		Prop_TrackedDeviceProperty_Max = 1000000
	}
	[Token(Token = "0x20002C9")]
	public enum ETrackedPropertyError
	{
		[Token(Token = "0x4000A6B")]
		TrackedProp_Success,
		[Token(Token = "0x4000A6C")]
		TrackedProp_WrongDataType,
		[Token(Token = "0x4000A6D")]
		TrackedProp_WrongDeviceClass,
		[Token(Token = "0x4000A6E")]
		TrackedProp_BufferTooSmall,
		[Token(Token = "0x4000A6F")]
		TrackedProp_UnknownProperty,
		[Token(Token = "0x4000A70")]
		TrackedProp_InvalidDevice,
		[Token(Token = "0x4000A71")]
		TrackedProp_CouldNotContactServer,
		[Token(Token = "0x4000A72")]
		TrackedProp_ValueNotProvidedByDevice,
		[Token(Token = "0x4000A73")]
		TrackedProp_StringExceedsMaximumLength,
		[Token(Token = "0x4000A74")]
		TrackedProp_NotYetAvailable,
		[Token(Token = "0x4000A75")]
		TrackedProp_PermissionDenied,
		[Token(Token = "0x4000A76")]
		TrackedProp_InvalidOperation,
		[Token(Token = "0x4000A77")]
		TrackedProp_CannotWriteToWildcards
	}
	[Token(Token = "0x20002CA")]
	public enum EVRSubmitFlags
	{
		[Token(Token = "0x4000A79")]
		Submit_Default = 0,
		[Token(Token = "0x4000A7A")]
		Submit_LensDistortionAlreadyApplied = 1,
		[Token(Token = "0x4000A7B")]
		Submit_GlRenderBuffer = 2,
		[Token(Token = "0x4000A7C")]
		Submit_Reserved = 4,
		[Token(Token = "0x4000A7D")]
		Submit_TextureWithPose = 8,
		[Token(Token = "0x4000A7E")]
		Submit_TextureWithDepth = 0x10
	}
	[Token(Token = "0x20002CB")]
	public enum EVRState
	{
		[Token(Token = "0x4000A80")]
		Undefined = -1,
		[Token(Token = "0x4000A81")]
		Off,
		[Token(Token = "0x4000A82")]
		Searching,
		[Token(Token = "0x4000A83")]
		Searching_Alert,
		[Token(Token = "0x4000A84")]
		Ready,
		[Token(Token = "0x4000A85")]
		Ready_Alert,
		[Token(Token = "0x4000A86")]
		NotReady,
		[Token(Token = "0x4000A87")]
		Standby,
		[Token(Token = "0x4000A88")]
		Ready_Alert_Low
	}
	[Token(Token = "0x20002CC")]
	public enum EVREventType
	{
		[Token(Token = "0x4000A8A")]
		VREvent_None = 0,
		[Token(Token = "0x4000A8B")]
		VREvent_TrackedDeviceActivated = 100,
		[Token(Token = "0x4000A8C")]
		VREvent_TrackedDeviceDeactivated = 101,
		[Token(Token = "0x4000A8D")]
		VREvent_TrackedDeviceUpdated = 102,
		[Token(Token = "0x4000A8E")]
		VREvent_TrackedDeviceUserInteractionStarted = 103,
		[Token(Token = "0x4000A8F")]
		VREvent_TrackedDeviceUserInteractionEnded = 104,
		[Token(Token = "0x4000A90")]
		VREvent_IpdChanged = 105,
		[Token(Token = "0x4000A91")]
		VREvent_EnterStandbyMode = 106,
		[Token(Token = "0x4000A92")]
		VREvent_LeaveStandbyMode = 107,
		[Token(Token = "0x4000A93")]
		VREvent_TrackedDeviceRoleChanged = 108,
		[Token(Token = "0x4000A94")]
		VREvent_WatchdogWakeUpRequested = 109,
		[Token(Token = "0x4000A95")]
		VREvent_LensDistortionChanged = 110,
		[Token(Token = "0x4000A96")]
		VREvent_PropertyChanged = 111,
		[Token(Token = "0x4000A97")]
		VREvent_WirelessDisconnect = 112,
		[Token(Token = "0x4000A98")]
		VREvent_WirelessReconnect = 113,
		[Token(Token = "0x4000A99")]
		VREvent_ButtonPress = 200,
		[Token(Token = "0x4000A9A")]
		VREvent_ButtonUnpress = 201,
		[Token(Token = "0x4000A9B")]
		VREvent_ButtonTouch = 202,
		[Token(Token = "0x4000A9C")]
		VREvent_ButtonUntouch = 203,
		[Token(Token = "0x4000A9D")]
		VREvent_DualAnalog_Press = 250,
		[Token(Token = "0x4000A9E")]
		VREvent_DualAnalog_Unpress = 251,
		[Token(Token = "0x4000A9F")]
		VREvent_DualAnalog_Touch = 252,
		[Token(Token = "0x4000AA0")]
		VREvent_DualAnalog_Untouch = 253,
		[Token(Token = "0x4000AA1")]
		VREvent_DualAnalog_Move = 254,
		[Token(Token = "0x4000AA2")]
		VREvent_DualAnalog_ModeSwitch1 = 255,
		[Token(Token = "0x4000AA3")]
		VREvent_DualAnalog_ModeSwitch2 = 256,
		[Token(Token = "0x4000AA4")]
		VREvent_DualAnalog_Cancel = 257,
		[Token(Token = "0x4000AA5")]
		VREvent_MouseMove = 300,
		[Token(Token = "0x4000AA6")]
		VREvent_MouseButtonDown = 301,
		[Token(Token = "0x4000AA7")]
		VREvent_MouseButtonUp = 302,
		[Token(Token = "0x4000AA8")]
		VREvent_FocusEnter = 303,
		[Token(Token = "0x4000AA9")]
		VREvent_FocusLeave = 304,
		[Token(Token = "0x4000AAA")]
		VREvent_Scroll = 305,
		[Token(Token = "0x4000AAB")]
		VREvent_TouchPadMove = 306,
		[Token(Token = "0x4000AAC")]
		VREvent_OverlayFocusChanged = 307,
		[Token(Token = "0x4000AAD")]
		VREvent_InputFocusCaptured = 400,
		[Token(Token = "0x4000AAE")]
		VREvent_InputFocusReleased = 401,
		[Token(Token = "0x4000AAF")]
		VREvent_SceneFocusLost = 402,
		[Token(Token = "0x4000AB0")]
		VREvent_SceneFocusGained = 403,
		[Token(Token = "0x4000AB1")]
		VREvent_SceneApplicationChanged = 404,
		[Token(Token = "0x4000AB2")]
		VREvent_SceneFocusChanged = 405,
		[Token(Token = "0x4000AB3")]
		VREvent_InputFocusChanged = 406,
		[Token(Token = "0x4000AB4")]
		VREvent_SceneApplicationSecondaryRenderingStarted = 407,
		[Token(Token = "0x4000AB5")]
		VREvent_SceneApplicationUsingWrongGraphicsAdapter = 408,
		[Token(Token = "0x4000AB6")]
		VREvent_HideRenderModels = 410,
		[Token(Token = "0x4000AB7")]
		VREvent_ShowRenderModels = 411,
		[Token(Token = "0x4000AB8")]
		VREvent_ConsoleOpened = 420,
		[Token(Token = "0x4000AB9")]
		VREvent_ConsoleClosed = 421,
		[Token(Token = "0x4000ABA")]
		VREvent_OverlayShown = 500,
		[Token(Token = "0x4000ABB")]
		VREvent_OverlayHidden = 501,
		[Token(Token = "0x4000ABC")]
		VREvent_DashboardActivated = 502,
		[Token(Token = "0x4000ABD")]
		VREvent_DashboardDeactivated = 503,
		[Token(Token = "0x4000ABE")]
		VREvent_DashboardThumbSelected = 504,
		[Token(Token = "0x4000ABF")]
		VREvent_DashboardRequested = 505,
		[Token(Token = "0x4000AC0")]
		VREvent_ResetDashboard = 506,
		[Token(Token = "0x4000AC1")]
		VREvent_RenderToast = 507,
		[Token(Token = "0x4000AC2")]
		VREvent_ImageLoaded = 508,
		[Token(Token = "0x4000AC3")]
		VREvent_ShowKeyboard = 509,
		[Token(Token = "0x4000AC4")]
		VREvent_HideKeyboard = 510,
		[Token(Token = "0x4000AC5")]
		VREvent_OverlayGamepadFocusGained = 511,
		[Token(Token = "0x4000AC6")]
		VREvent_OverlayGamepadFocusLost = 512,
		[Token(Token = "0x4000AC7")]
		VREvent_OverlaySharedTextureChanged = 513,
		[Token(Token = "0x4000AC8")]
		VREvent_ScreenshotTriggered = 516,
		[Token(Token = "0x4000AC9")]
		VREvent_ImageFailed = 517,
		[Token(Token = "0x4000ACA")]
		VREvent_DashboardOverlayCreated = 518,
		[Token(Token = "0x4000ACB")]
		VREvent_SwitchGamepadFocus = 519,
		[Token(Token = "0x4000ACC")]
		VREvent_RequestScreenshot = 520,
		[Token(Token = "0x4000ACD")]
		VREvent_ScreenshotTaken = 521,
		[Token(Token = "0x4000ACE")]
		VREvent_ScreenshotFailed = 522,
		[Token(Token = "0x4000ACF")]
		VREvent_SubmitScreenshotToDashboard = 523,
		[Token(Token = "0x4000AD0")]
		VREvent_ScreenshotProgressToDashboard = 524,
		[Token(Token = "0x4000AD1")]
		VREvent_PrimaryDashboardDeviceChanged = 525,
		[Token(Token = "0x4000AD2")]
		VREvent_RoomViewShown = 526,
		[Token(Token = "0x4000AD3")]
		VREvent_RoomViewHidden = 527,
		[Token(Token = "0x4000AD4")]
		VREvent_Notification_Shown = 600,
		[Token(Token = "0x4000AD5")]
		VREvent_Notification_Hidden = 601,
		[Token(Token = "0x4000AD6")]
		VREvent_Notification_BeginInteraction = 602,
		[Token(Token = "0x4000AD7")]
		VREvent_Notification_Destroyed = 603,
		[Token(Token = "0x4000AD8")]
		VREvent_Quit = 700,
		[Token(Token = "0x4000AD9")]
		VREvent_ProcessQuit = 701,
		[Token(Token = "0x4000ADA")]
		VREvent_QuitAborted_UserPrompt = 702,
		[Token(Token = "0x4000ADB")]
		VREvent_QuitAcknowledged = 703,
		[Token(Token = "0x4000ADC")]
		VREvent_DriverRequestedQuit = 704,
		[Token(Token = "0x4000ADD")]
		VREvent_ChaperoneDataHasChanged = 800,
		[Token(Token = "0x4000ADE")]
		VREvent_ChaperoneUniverseHasChanged = 801,
		[Token(Token = "0x4000ADF")]
		VREvent_ChaperoneTempDataHasChanged = 802,
		[Token(Token = "0x4000AE0")]
		VREvent_ChaperoneSettingsHaveChanged = 803,
		[Token(Token = "0x4000AE1")]
		VREvent_SeatedZeroPoseReset = 804,
		[Token(Token = "0x4000AE2")]
		VREvent_AudioSettingsHaveChanged = 820,
		[Token(Token = "0x4000AE3")]
		VREvent_BackgroundSettingHasChanged = 850,
		[Token(Token = "0x4000AE4")]
		VREvent_CameraSettingsHaveChanged = 851,
		[Token(Token = "0x4000AE5")]
		VREvent_ReprojectionSettingHasChanged = 852,
		[Token(Token = "0x4000AE6")]
		VREvent_ModelSkinSettingsHaveChanged = 853,
		[Token(Token = "0x4000AE7")]
		VREvent_EnvironmentSettingsHaveChanged = 854,
		[Token(Token = "0x4000AE8")]
		VREvent_PowerSettingsHaveChanged = 855,
		[Token(Token = "0x4000AE9")]
		VREvent_EnableHomeAppSettingsHaveChanged = 856,
		[Token(Token = "0x4000AEA")]
		VREvent_SteamVRSectionSettingChanged = 857,
		[Token(Token = "0x4000AEB")]
		VREvent_LighthouseSectionSettingChanged = 858,
		[Token(Token = "0x4000AEC")]
		VREvent_NullSectionSettingChanged = 859,
		[Token(Token = "0x4000AED")]
		VREvent_UserInterfaceSectionSettingChanged = 860,
		[Token(Token = "0x4000AEE")]
		VREvent_NotificationsSectionSettingChanged = 861,
		[Token(Token = "0x4000AEF")]
		VREvent_KeyboardSectionSettingChanged = 862,
		[Token(Token = "0x4000AF0")]
		VREvent_PerfSectionSettingChanged = 863,
		[Token(Token = "0x4000AF1")]
		VREvent_DashboardSectionSettingChanged = 864,
		[Token(Token = "0x4000AF2")]
		VREvent_WebInterfaceSectionSettingChanged = 865,
		[Token(Token = "0x4000AF3")]
		VREvent_StatusUpdate = 900,
		[Token(Token = "0x4000AF4")]
		VREvent_WebInterface_InstallDriverCompleted = 950,
		[Token(Token = "0x4000AF5")]
		VREvent_MCImageUpdated = 1000,
		[Token(Token = "0x4000AF6")]
		VREvent_FirmwareUpdateStarted = 1100,
		[Token(Token = "0x4000AF7")]
		VREvent_FirmwareUpdateFinished = 1101,
		[Token(Token = "0x4000AF8")]
		VREvent_KeyboardClosed = 1200,
		[Token(Token = "0x4000AF9")]
		VREvent_KeyboardCharInput = 1201,
		[Token(Token = "0x4000AFA")]
		VREvent_KeyboardDone = 1202,
		[Token(Token = "0x4000AFB")]
		VREvent_ApplicationTransitionStarted = 1300,
		[Token(Token = "0x4000AFC")]
		VREvent_ApplicationTransitionAborted = 1301,
		[Token(Token = "0x4000AFD")]
		VREvent_ApplicationTransitionNewAppStarted = 1302,
		[Token(Token = "0x4000AFE")]
		VREvent_ApplicationListUpdated = 1303,
		[Token(Token = "0x4000AFF")]
		VREvent_ApplicationMimeTypeLoad = 1304,
		[Token(Token = "0x4000B00")]
		VREvent_ApplicationTransitionNewAppLaunchComplete = 1305,
		[Token(Token = "0x4000B01")]
		VREvent_ProcessConnected = 1306,
		[Token(Token = "0x4000B02")]
		VREvent_ProcessDisconnected = 1307,
		[Token(Token = "0x4000B03")]
		VREvent_Compositor_MirrorWindowShown = 1400,
		[Token(Token = "0x4000B04")]
		VREvent_Compositor_MirrorWindowHidden = 1401,
		[Token(Token = "0x4000B05")]
		VREvent_Compositor_ChaperoneBoundsShown = 1410,
		[Token(Token = "0x4000B06")]
		VREvent_Compositor_ChaperoneBoundsHidden = 1411,
		[Token(Token = "0x4000B07")]
		VREvent_TrackedCamera_StartVideoStream = 1500,
		[Token(Token = "0x4000B08")]
		VREvent_TrackedCamera_StopVideoStream = 1501,
		[Token(Token = "0x4000B09")]
		VREvent_TrackedCamera_PauseVideoStream = 1502,
		[Token(Token = "0x4000B0A")]
		VREvent_TrackedCamera_ResumeVideoStream = 1503,
		[Token(Token = "0x4000B0B")]
		VREvent_TrackedCamera_EditingSurface = 1550,
		[Token(Token = "0x4000B0C")]
		VREvent_PerformanceTest_EnableCapture = 1600,
		[Token(Token = "0x4000B0D")]
		VREvent_PerformanceTest_DisableCapture = 1601,
		[Token(Token = "0x4000B0E")]
		VREvent_PerformanceTest_FidelityLevel = 1602,
		[Token(Token = "0x4000B0F")]
		VREvent_MessageOverlay_Closed = 1650,
		[Token(Token = "0x4000B10")]
		VREvent_MessageOverlayCloseRequested = 1651,
		[Token(Token = "0x4000B11")]
		VREvent_Input_HapticVibration = 1700,
		[Token(Token = "0x4000B12")]
		VREvent_VendorSpecific_Reserved_Start = 10000,
		[Token(Token = "0x4000B13")]
		VREvent_VendorSpecific_Reserved_End = 19999
	}
	[Token(Token = "0x20002CD")]
	public enum EDeviceActivityLevel
	{
		[Token(Token = "0x4000B15")]
		k_EDeviceActivityLevel_Unknown = -1,
		[Token(Token = "0x4000B16")]
		k_EDeviceActivityLevel_Idle,
		[Token(Token = "0x4000B17")]
		k_EDeviceActivityLevel_UserInteraction,
		[Token(Token = "0x4000B18")]
		k_EDeviceActivityLevel_UserInteraction_Timeout,
		[Token(Token = "0x4000B19")]
		k_EDeviceActivityLevel_Standby
	}
	[Token(Token = "0x20002CE")]
	public enum EVRButtonId
	{
		[Token(Token = "0x4000B1B")]
		k_EButton_System = 0,
		[Token(Token = "0x4000B1C")]
		k_EButton_ApplicationMenu = 1,
		[Token(Token = "0x4000B1D")]
		k_EButton_Grip = 2,
		[Token(Token = "0x4000B1E")]
		k_EButton_DPad_Left = 3,
		[Token(Token = "0x4000B1F")]
		k_EButton_DPad_Up = 4,
		[Token(Token = "0x4000B20")]
		k_EButton_DPad_Right = 5,
		[Token(Token = "0x4000B21")]
		k_EButton_DPad_Down = 6,
		[Token(Token = "0x4000B22")]
		k_EButton_A = 7,
		[Token(Token = "0x4000B23")]
		k_EButton_ProximitySensor = 31,
		[Token(Token = "0x4000B24")]
		k_EButton_Axis0 = 32,
		[Token(Token = "0x4000B25")]
		k_EButton_Axis1 = 33,
		[Token(Token = "0x4000B26")]
		k_EButton_Axis2 = 34,
		[Token(Token = "0x4000B27")]
		k_EButton_Axis3 = 35,
		[Token(Token = "0x4000B28")]
		k_EButton_Axis4 = 36,
		[Token(Token = "0x4000B29")]
		k_EButton_SteamVR_Touchpad = 32,
		[Token(Token = "0x4000B2A")]
		k_EButton_SteamVR_Trigger = 33,
		[Token(Token = "0x4000B2B")]
		k_EButton_Dashboard_Back = 2,
		[Token(Token = "0x4000B2C")]
		k_EButton_Max = 64
	}
	[Token(Token = "0x20002CF")]
	public enum EVRMouseButton
	{
		[Token(Token = "0x4000B2E")]
		Left = 1,
		[Token(Token = "0x4000B2F")]
		Right = 2,
		[Token(Token = "0x4000B30")]
		Middle = 4
	}
	[Token(Token = "0x20002D0")]
	public enum EDualAnalogWhich
	{
		[Token(Token = "0x4000B32")]
		k_EDualAnalog_Left,
		[Token(Token = "0x4000B33")]
		k_EDualAnalog_Right
	}
	[Token(Token = "0x20002D1")]
	public enum EVRInputError
	{
		[Token(Token = "0x4000B35")]
		None,
		[Token(Token = "0x4000B36")]
		NameNotFound,
		[Token(Token = "0x4000B37")]
		WrongType,
		[Token(Token = "0x4000B38")]
		InvalidHandle,
		[Token(Token = "0x4000B39")]
		InvalidParam,
		[Token(Token = "0x4000B3A")]
		NoSteam,
		[Token(Token = "0x4000B3B")]
		MaxCapacityReached,
		[Token(Token = "0x4000B3C")]
		IPCError,
		[Token(Token = "0x4000B3D")]
		NoActiveActionSet,
		[Token(Token = "0x4000B3E")]
		InvalidDevice
	}
	[Token(Token = "0x20002D2")]
	public enum EHiddenAreaMeshType
	{
		[Token(Token = "0x4000B40")]
		k_eHiddenAreaMesh_Standard,
		[Token(Token = "0x4000B41")]
		k_eHiddenAreaMesh_Inverse,
		[Token(Token = "0x4000B42")]
		k_eHiddenAreaMesh_LineLoop,
		[Token(Token = "0x4000B43")]
		k_eHiddenAreaMesh_Max
	}
	[Token(Token = "0x20002D3")]
	public enum EVRControllerAxisType
	{
		[Token(Token = "0x4000B45")]
		k_eControllerAxis_None,
		[Token(Token = "0x4000B46")]
		k_eControllerAxis_TrackPad,
		[Token(Token = "0x4000B47")]
		k_eControllerAxis_Joystick,
		[Token(Token = "0x4000B48")]
		k_eControllerAxis_Trigger
	}
	[Token(Token = "0x20002D4")]
	public enum EVRControllerEventOutputType
	{
		[Token(Token = "0x4000B4A")]
		ControllerEventOutput_OSEvents,
		[Token(Token = "0x4000B4B")]
		ControllerEventOutput_VREvents
	}
	[Token(Token = "0x20002D5")]
	public enum ECollisionBoundsStyle
	{
		[Token(Token = "0x4000B4D")]
		COLLISION_BOUNDS_STYLE_BEGINNER,
		[Token(Token = "0x4000B4E")]
		COLLISION_BOUNDS_STYLE_INTERMEDIATE,
		[Token(Token = "0x4000B4F")]
		COLLISION_BOUNDS_STYLE_SQUARES,
		[Token(Token = "0x4000B50")]
		COLLISION_BOUNDS_STYLE_ADVANCED,
		[Token(Token = "0x4000B51")]
		COLLISION_BOUNDS_STYLE_NONE,
		[Token(Token = "0x4000B52")]
		COLLISION_BOUNDS_STYLE_COUNT
	}
	[Token(Token = "0x20002D6")]
	public enum EVROverlayError
	{
		[Token(Token = "0x4000B54")]
		None = 0,
		[Token(Token = "0x4000B55")]
		UnknownOverlay = 10,
		[Token(Token = "0x4000B56")]
		InvalidHandle = 11,
		[Token(Token = "0x4000B57")]
		PermissionDenied = 12,
		[Token(Token = "0x4000B58")]
		OverlayLimitExceeded = 13,
		[Token(Token = "0x4000B59")]
		WrongVisibilityType = 14,
		[Token(Token = "0x4000B5A")]
		KeyTooLong = 15,
		[Token(Token = "0x4000B5B")]
		NameTooLong = 16,
		[Token(Token = "0x4000B5C")]
		KeyInUse = 17,
		[Token(Token = "0x4000B5D")]
		WrongTransformType = 18,
		[Token(Token = "0x4000B5E")]
		InvalidTrackedDevice = 19,
		[Token(Token = "0x4000B5F")]
		InvalidParameter = 20,
		[Token(Token = "0x4000B60")]
		ThumbnailCantBeDestroyed = 21,
		[Token(Token = "0x4000B61")]
		ArrayTooSmall = 22,
		[Token(Token = "0x4000B62")]
		RequestFailed = 23,
		[Token(Token = "0x4000B63")]
		InvalidTexture = 24,
		[Token(Token = "0x4000B64")]
		UnableToLoadFile = 25,
		[Token(Token = "0x4000B65")]
		KeyboardAlreadyInUse = 26,
		[Token(Token = "0x4000B66")]
		NoNeighbor = 27,
		[Token(Token = "0x4000B67")]
		TooManyMaskPrimitives = 29,
		[Token(Token = "0x4000B68")]
		BadMaskPrimitive = 30,
		[Token(Token = "0x4000B69")]
		TextureAlreadyLocked = 31,
		[Token(Token = "0x4000B6A")]
		TextureLockCapacityReached = 32,
		[Token(Token = "0x4000B6B")]
		TextureNotLocked = 33
	}
	[Token(Token = "0x20002D7")]
	public enum EVRApplicationType
	{
		[Token(Token = "0x4000B6D")]
		VRApplication_Other,
		[Token(Token = "0x4000B6E")]
		VRApplication_Scene,
		[Token(Token = "0x4000B6F")]
		VRApplication_Overlay,
		[Token(Token = "0x4000B70")]
		VRApplication_Background,
		[Token(Token = "0x4000B71")]
		VRApplication_Utility,
		[Token(Token = "0x4000B72")]
		VRApplication_VRMonitor,
		[Token(Token = "0x4000B73")]
		VRApplication_SteamWatchdog,
		[Token(Token = "0x4000B74")]
		VRApplication_Bootstrapper,
		[Token(Token = "0x4000B75")]
		VRApplication_Max
	}
	[Token(Token = "0x20002D8")]
	public enum EVRFirmwareError
	{
		[Token(Token = "0x4000B77")]
		None,
		[Token(Token = "0x4000B78")]
		Success,
		[Token(Token = "0x4000B79")]
		Fail
	}
	[Token(Token = "0x20002D9")]
	public enum EVRNotificationError
	{
		[Token(Token = "0x4000B7B")]
		OK = 0,
		[Token(Token = "0x4000B7C")]
		InvalidNotificationId = 100,
		[Token(Token = "0x4000B7D")]
		NotificationQueueFull = 101,
		[Token(Token = "0x4000B7E")]
		InvalidOverlayHandle = 102,
		[Token(Token = "0x4000B7F")]
		SystemWithUserValueAlreadyExists = 103
	}
	[Token(Token = "0x20002DA")]
	public enum EVRInitError
	{
		[Token(Token = "0x4000B81")]
		None = 0,
		[Token(Token = "0x4000B82")]
		Unknown = 1,
		[Token(Token = "0x4000B83")]
		Init_InstallationNotFound = 100,
		[Token(Token = "0x4000B84")]
		Init_InstallationCorrupt = 101,
		[Token(Token = "0x4000B85")]
		Init_VRClientDLLNotFound = 102,
		[Token(Token = "0x4000B86")]
		Init_FileNotFound = 103,
		[Token(Token = "0x4000B87")]
		Init_FactoryNotFound = 104,
		[Token(Token = "0x4000B88")]
		Init_InterfaceNotFound = 105,
		[Token(Token = "0x4000B89")]
		Init_InvalidInterface = 106,
		[Token(Token = "0x4000B8A")]
		Init_UserConfigDirectoryInvalid = 107,
		[Token(Token = "0x4000B8B")]
		Init_HmdNotFound = 108,
		[Token(Token = "0x4000B8C")]
		Init_NotInitialized = 109,
		[Token(Token = "0x4000B8D")]
		Init_PathRegistryNotFound = 110,
		[Token(Token = "0x4000B8E")]
		Init_NoConfigPath = 111,
		[Token(Token = "0x4000B8F")]
		Init_NoLogPath = 112,
		[Token(Token = "0x4000B90")]
		Init_PathRegistryNotWritable = 113,
		[Token(Token = "0x4000B91")]
		Init_AppInfoInitFailed = 114,
		[Token(Token = "0x4000B92")]
		Init_Retry = 115,
		[Token(Token = "0x4000B93")]
		Init_InitCanceledByUser = 116,
		[Token(Token = "0x4000B94")]
		Init_AnotherAppLaunching = 117,
		[Token(Token = "0x4000B95")]
		Init_SettingsInitFailed = 118,
		[Token(Token = "0x4000B96")]
		Init_ShuttingDown = 119,
		[Token(Token = "0x4000B97")]
		Init_TooManyObjects = 120,
		[Token(Token = "0x4000B98")]
		Init_NoServerForBackgroundApp = 121,
		[Token(Token = "0x4000B99")]
		Init_NotSupportedWithCompositor = 122,
		[Token(Token = "0x4000B9A")]
		Init_NotAvailableToUtilityApps = 123,
		[Token(Token = "0x4000B9B")]
		Init_Internal = 124,
		[Token(Token = "0x4000B9C")]
		Init_HmdDriverIdIsNone = 125,
		[Token(Token = "0x4000B9D")]
		Init_HmdNotFoundPresenceFailed = 126,
		[Token(Token = "0x4000B9E")]
		Init_VRMonitorNotFound = 127,
		[Token(Token = "0x4000B9F")]
		Init_VRMonitorStartupFailed = 128,
		[Token(Token = "0x4000BA0")]
		Init_LowPowerWatchdogNotSupported = 129,
		[Token(Token = "0x4000BA1")]
		Init_InvalidApplicationType = 130,
		[Token(Token = "0x4000BA2")]
		Init_NotAvailableToWatchdogApps = 131,
		[Token(Token = "0x4000BA3")]
		Init_WatchdogDisabledInSettings = 132,
		[Token(Token = "0x4000BA4")]
		Init_VRDashboardNotFound = 133,
		[Token(Token = "0x4000BA5")]
		Init_VRDashboardStartupFailed = 134,
		[Token(Token = "0x4000BA6")]
		Init_VRHomeNotFound = 135,
		[Token(Token = "0x4000BA7")]
		Init_VRHomeStartupFailed = 136,
		[Token(Token = "0x4000BA8")]
		Init_RebootingBusy = 137,
		[Token(Token = "0x4000BA9")]
		Init_FirmwareUpdateBusy = 138,
		[Token(Token = "0x4000BAA")]
		Init_FirmwareRecoveryBusy = 139,
		[Token(Token = "0x4000BAB")]
		Init_USBServiceBusy = 140,
		[Token(Token = "0x4000BAC")]
		Init_VRWebHelperStartupFailed = 141,
		[Token(Token = "0x4000BAD")]
		Driver_Failed = 200,
		[Token(Token = "0x4000BAE")]
		Driver_Unknown = 201,
		[Token(Token = "0x4000BAF")]
		Driver_HmdUnknown = 202,
		[Token(Token = "0x4000BB0")]
		Driver_NotLoaded = 203,
		[Token(Token = "0x4000BB1")]
		Driver_RuntimeOutOfDate = 204,
		[Token(Token = "0x4000BB2")]
		Driver_HmdInUse = 205,
		[Token(Token = "0x4000BB3")]
		Driver_NotCalibrated = 206,
		[Token(Token = "0x4000BB4")]
		Driver_CalibrationInvalid = 207,
		[Token(Token = "0x4000BB5")]
		Driver_HmdDisplayNotFound = 208,
		[Token(Token = "0x4000BB6")]
		Driver_TrackedDeviceInterfaceUnknown = 209,
		[Token(Token = "0x4000BB7")]
		Driver_HmdDriverIdOutOfBounds = 211,
		[Token(Token = "0x4000BB8")]
		Driver_HmdDisplayMirrored = 212,
		[Token(Token = "0x4000BB9")]
		IPC_ServerInitFailed = 300,
		[Token(Token = "0x4000BBA")]
		IPC_ConnectFailed = 301,
		[Token(Token = "0x4000BBB")]
		IPC_SharedStateInitFailed = 302,
		[Token(Token = "0x4000BBC")]
		IPC_CompositorInitFailed = 303,
		[Token(Token = "0x4000BBD")]
		IPC_MutexInitFailed = 304,
		[Token(Token = "0x4000BBE")]
		IPC_Failed = 305,
		[Token(Token = "0x4000BBF")]
		IPC_CompositorConnectFailed = 306,
		[Token(Token = "0x4000BC0")]
		IPC_CompositorInvalidConnectResponse = 307,
		[Token(Token = "0x4000BC1")]
		IPC_ConnectFailedAfterMultipleAttempts = 308,
		[Token(Token = "0x4000BC2")]
		Compositor_Failed = 400,
		[Token(Token = "0x4000BC3")]
		Compositor_D3D11HardwareRequired = 401,
		[Token(Token = "0x4000BC4")]
		Compositor_FirmwareRequiresUpdate = 402,
		[Token(Token = "0x4000BC5")]
		Compositor_OverlayInitFailed = 403,
		[Token(Token = "0x4000BC6")]
		Compositor_ScreenshotsInitFailed = 404,
		[Token(Token = "0x4000BC7")]
		Compositor_UnableToCreateDevice = 405,
		[Token(Token = "0x4000BC8")]
		VendorSpecific_UnableToConnectToOculusRuntime = 1000,
		[Token(Token = "0x4000BC9")]
		VendorSpecific_WindowsNotInDevMode = 1001,
		[Token(Token = "0x4000BCA")]
		VendorSpecific_HmdFound_CantOpenDevice = 1101,
		[Token(Token = "0x4000BCB")]
		VendorSpecific_HmdFound_UnableToRequestConfigStart = 1102,
		[Token(Token = "0x4000BCC")]
		VendorSpecific_HmdFound_NoStoredConfig = 1103,
		[Token(Token = "0x4000BCD")]
		VendorSpecific_HmdFound_ConfigTooBig = 1104,
		[Token(Token = "0x4000BCE")]
		VendorSpecific_HmdFound_ConfigTooSmall = 1105,
		[Token(Token = "0x4000BCF")]
		VendorSpecific_HmdFound_UnableToInitZLib = 1106,
		[Token(Token = "0x4000BD0")]
		VendorSpecific_HmdFound_CantReadFirmwareVersion = 1107,
		[Token(Token = "0x4000BD1")]
		VendorSpecific_HmdFound_UnableToSendUserDataStart = 1108,
		[Token(Token = "0x4000BD2")]
		VendorSpecific_HmdFound_UnableToGetUserDataStart = 1109,
		[Token(Token = "0x4000BD3")]
		VendorSpecific_HmdFound_UnableToGetUserDataNext = 1110,
		[Token(Token = "0x4000BD4")]
		VendorSpecific_HmdFound_UserDataAddressRange = 1111,
		[Token(Token = "0x4000BD5")]
		VendorSpecific_HmdFound_UserDataError = 1112,
		[Token(Token = "0x4000BD6")]
		VendorSpecific_HmdFound_ConfigFailedSanityCheck = 1113,
		[Token(Token = "0x4000BD7")]
		Steam_SteamInstallationNotFound = 2000
	}
	[Token(Token = "0x20002DB")]
	public enum EVRScreenshotType
	{
		[Token(Token = "0x4000BD9")]
		None,
		[Token(Token = "0x4000BDA")]
		Mono,
		[Token(Token = "0x4000BDB")]
		Stereo,
		[Token(Token = "0x4000BDC")]
		Cubemap,
		[Token(Token = "0x4000BDD")]
		MonoPanorama,
		[Token(Token = "0x4000BDE")]
		StereoPanorama
	}
	[Token(Token = "0x20002DC")]
	public enum EVRScreenshotPropertyFilenames
	{
		[Token(Token = "0x4000BE0")]
		Preview,
		[Token(Token = "0x4000BE1")]
		VR
	}
	[Token(Token = "0x20002DD")]
	public enum EVRTrackedCameraError
	{
		[Token(Token = "0x4000BE3")]
		None = 0,
		[Token(Token = "0x4000BE4")]
		OperationFailed = 100,
		[Token(Token = "0x4000BE5")]
		InvalidHandle = 101,
		[Token(Token = "0x4000BE6")]
		InvalidFrameHeaderVersion = 102,
		[Token(Token = "0x4000BE7")]
		OutOfHandles = 103,
		[Token(Token = "0x4000BE8")]
		IPCFailure = 104,
		[Token(Token = "0x4000BE9")]
		NotSupportedForThisDevice = 105,
		[Token(Token = "0x4000BEA")]
		SharedMemoryFailure = 106,
		[Token(Token = "0x4000BEB")]
		FrameBufferingFailure = 107,
		[Token(Token = "0x4000BEC")]
		StreamSetupFailure = 108,
		[Token(Token = "0x4000BED")]
		InvalidGLTextureId = 109,
		[Token(Token = "0x4000BEE")]
		InvalidSharedTextureHandle = 110,
		[Token(Token = "0x4000BEF")]
		FailedToGetGLTextureId = 111,
		[Token(Token = "0x4000BF0")]
		SharedTextureFailure = 112,
		[Token(Token = "0x4000BF1")]
		NoFrameAvailable = 113,
		[Token(Token = "0x4000BF2")]
		InvalidArgument = 114,
		[Token(Token = "0x4000BF3")]
		InvalidFrameBufferSize = 115
	}
	[Token(Token = "0x20002DE")]
	public enum EVRTrackedCameraFrameType
	{
		[Token(Token = "0x4000BF5")]
		Distorted,
		[Token(Token = "0x4000BF6")]
		Undistorted,
		[Token(Token = "0x4000BF7")]
		MaximumUndistorted,
		[Token(Token = "0x4000BF8")]
		MAX_CAMERA_FRAME_TYPES
	}
	[Token(Token = "0x20002DF")]
	public enum EVRApplicationError
	{
		[Token(Token = "0x4000BFA")]
		None = 0,
		[Token(Token = "0x4000BFB")]
		AppKeyAlreadyExists = 100,
		[Token(Token = "0x4000BFC")]
		NoManifest = 101,
		[Token(Token = "0x4000BFD")]
		NoApplication = 102,
		[Token(Token = "0x4000BFE")]
		InvalidIndex = 103,
		[Token(Token = "0x4000BFF")]
		UnknownApplication = 104,
		[Token(Token = "0x4000C00")]
		IPCFailed = 105,
		[Token(Token = "0x4000C01")]
		ApplicationAlreadyRunning = 106,
		[Token(Token = "0x4000C02")]
		InvalidManifest = 107,
		[Token(Token = "0x4000C03")]
		InvalidApplication = 108,
		[Token(Token = "0x4000C04")]
		LaunchFailed = 109,
		[Token(Token = "0x4000C05")]
		ApplicationAlreadyStarting = 110,
		[Token(Token = "0x4000C06")]
		LaunchInProgress = 111,
		[Token(Token = "0x4000C07")]
		OldApplicationQuitting = 112,
		[Token(Token = "0x4000C08")]
		TransitionAborted = 113,
		[Token(Token = "0x4000C09")]
		IsTemplate = 114,
		[Token(Token = "0x4000C0A")]
		SteamVRIsExiting = 115,
		[Token(Token = "0x4000C0B")]
		BufferTooSmall = 200,
		[Token(Token = "0x4000C0C")]
		PropertyNotSet = 201,
		[Token(Token = "0x4000C0D")]
		UnknownProperty = 202,
		[Token(Token = "0x4000C0E")]
		InvalidParameter = 203
	}
	[Token(Token = "0x20002E0")]
	public enum EVRApplicationProperty
	{
		[Token(Token = "0x4000C10")]
		Name_String = 0,
		[Token(Token = "0x4000C11")]
		LaunchType_String = 11,
		[Token(Token = "0x4000C12")]
		WorkingDirectory_String = 12,
		[Token(Token = "0x4000C13")]
		BinaryPath_String = 13,
		[Token(Token = "0x4000C14")]
		Arguments_String = 14,
		[Token(Token = "0x4000C15")]
		URL_String = 15,
		[Token(Token = "0x4000C16")]
		Description_String = 50,
		[Token(Token = "0x4000C17")]
		NewsURL_String = 51,
		[Token(Token = "0x4000C18")]
		ImagePath_String = 52,
		[Token(Token = "0x4000C19")]
		Source_String = 53,
		[Token(Token = "0x4000C1A")]
		ActionManifestURL_String = 54,
		[Token(Token = "0x4000C1B")]
		IsDashboardOverlay_Bool = 60,
		[Token(Token = "0x4000C1C")]
		IsTemplate_Bool = 61,
		[Token(Token = "0x4000C1D")]
		IsInstanced_Bool = 62,
		[Token(Token = "0x4000C1E")]
		IsInternal_Bool = 63,
		[Token(Token = "0x4000C1F")]
		WantsCompositorPauseInStandby_Bool = 64,
		[Token(Token = "0x4000C20")]
		LastLaunchTime_Uint64 = 70
	}
	[Token(Token = "0x20002E1")]
	public enum EVRApplicationTransitionState
	{
		[Token(Token = "0x4000C22")]
		VRApplicationTransition_None = 0,
		[Token(Token = "0x4000C23")]
		VRApplicationTransition_OldAppQuitSent = 10,
		[Token(Token = "0x4000C24")]
		VRApplicationTransition_WaitingForExternalLaunch = 11,
		[Token(Token = "0x4000C25")]
		VRApplicationTransition_NewAppLaunched = 20
	}
	[Token(Token = "0x20002E2")]
	public enum ChaperoneCalibrationState
	{
		[Token(Token = "0x4000C27")]
		OK = 1,
		[Token(Token = "0x4000C28")]
		Warning = 100,
		[Token(Token = "0x4000C29")]
		Warning_BaseStationMayHaveMoved = 101,
		[Token(Token = "0x4000C2A")]
		Warning_BaseStationRemoved = 102,
		[Token(Token = "0x4000C2B")]
		Warning_SeatedBoundsInvalid = 103,
		[Token(Token = "0x4000C2C")]
		Error = 200,
		[Token(Token = "0x4000C2D")]
		Error_BaseStationUninitialized = 201,
		[Token(Token = "0x4000C2E")]
		Error_BaseStationConflict = 202,
		[Token(Token = "0x4000C2F")]
		Error_PlayAreaInvalid = 203,
		[Token(Token = "0x4000C30")]
		Error_CollisionBoundsInvalid = 204
	}
	[Token(Token = "0x20002E3")]
	public enum EChaperoneConfigFile
	{
		[Token(Token = "0x4000C32")]
		Live = 1,
		[Token(Token = "0x4000C33")]
		Temp
	}
	[Token(Token = "0x20002E4")]
	public enum EChaperoneImportFlags
	{
		[Token(Token = "0x4000C35")]
		EChaperoneImport_BoundsOnly = 1
	}
	[Token(Token = "0x20002E5")]
	public enum EVRCompositorError
	{
		[Token(Token = "0x4000C37")]
		None = 0,
		[Token(Token = "0x4000C38")]
		RequestFailed = 1,
		[Token(Token = "0x4000C39")]
		IncompatibleVersion = 100,
		[Token(Token = "0x4000C3A")]
		DoNotHaveFocus = 101,
		[Token(Token = "0x4000C3B")]
		InvalidTexture = 102,
		[Token(Token = "0x4000C3C")]
		IsNotSceneApplication = 103,
		[Token(Token = "0x4000C3D")]
		TextureIsOnWrongDevice = 104,
		[Token(Token = "0x4000C3E")]
		TextureUsesUnsupportedFormat = 105,
		[Token(Token = "0x4000C3F")]
		SharedTexturesNotSupported = 106,
		[Token(Token = "0x4000C40")]
		IndexOutOfRange = 107,
		[Token(Token = "0x4000C41")]
		AlreadySubmitted = 108,
		[Token(Token = "0x4000C42")]
		InvalidBounds = 109
	}
	[Token(Token = "0x20002E6")]
	public enum EVRCompositorTimingMode
	{
		[Token(Token = "0x4000C44")]
		Implicit,
		[Token(Token = "0x4000C45")]
		Explicit_RuntimePerformsPostPresentHandoff,
		[Token(Token = "0x4000C46")]
		Explicit_ApplicationPerformsPostPresentHandoff
	}
	[Token(Token = "0x20002E7")]
	public enum VROverlayInputMethod
	{
		[Token(Token = "0x4000C48")]
		None,
		[Token(Token = "0x4000C49")]
		Mouse,
		[Token(Token = "0x4000C4A")]
		DualAnalog
	}
	[Token(Token = "0x20002E8")]
	public enum VROverlayTransformType
	{
		[Token(Token = "0x4000C4C")]
		VROverlayTransform_Absolute,
		[Token(Token = "0x4000C4D")]
		VROverlayTransform_TrackedDeviceRelative,
		[Token(Token = "0x4000C4E")]
		VROverlayTransform_SystemOverlay,
		[Token(Token = "0x4000C4F")]
		VROverlayTransform_TrackedComponent
	}
	[Token(Token = "0x20002E9")]
	public enum VROverlayFlags
	{
		[Token(Token = "0x4000C51")]
		None,
		[Token(Token = "0x4000C52")]
		Curved,
		[Token(Token = "0x4000C53")]
		RGSS4X,
		[Token(Token = "0x4000C54")]
		NoDashboardTab,
		[Token(Token = "0x4000C55")]
		AcceptsGamepadEvents,
		[Token(Token = "0x4000C56")]
		ShowGamepadFocus,
		[Token(Token = "0x4000C57")]
		SendVRScrollEvents,
		[Token(Token = "0x4000C58")]
		SendVRTouchpadEvents,
		[Token(Token = "0x4000C59")]
		ShowTouchPadScrollWheel,
		[Token(Token = "0x4000C5A")]
		TransferOwnershipToInternalProcess,
		[Token(Token = "0x4000C5B")]
		SideBySide_Parallel,
		[Token(Token = "0x4000C5C")]
		SideBySide_Crossed,
		[Token(Token = "0x4000C5D")]
		Panorama,
		[Token(Token = "0x4000C5E")]
		StereoPanorama,
		[Token(Token = "0x4000C5F")]
		SortWithNonSceneOverlays,
		[Token(Token = "0x4000C60")]
		VisibleInDashboard
	}
	[Token(Token = "0x20002EA")]
	public enum VRMessageOverlayResponse
	{
		[Token(Token = "0x4000C62")]
		ButtonPress_0,
		[Token(Token = "0x4000C63")]
		ButtonPress_1,
		[Token(Token = "0x4000C64")]
		ButtonPress_2,
		[Token(Token = "0x4000C65")]
		ButtonPress_3,
		[Token(Token = "0x4000C66")]
		CouldntFindSystemOverlay,
		[Token(Token = "0x4000C67")]
		CouldntFindOrCreateClientOverlay,
		[Token(Token = "0x4000C68")]
		ApplicationQuit
	}
	[Token(Token = "0x20002EB")]
	public enum EGamepadTextInputMode
	{
		[Token(Token = "0x4000C6A")]
		k_EGamepadTextInputModeNormal,
		[Token(Token = "0x4000C6B")]
		k_EGamepadTextInputModePassword,
		[Token(Token = "0x4000C6C")]
		k_EGamepadTextInputModeSubmit
	}
	[Token(Token = "0x20002EC")]
	public enum EGamepadTextInputLineMode
	{
		[Token(Token = "0x4000C6E")]
		k_EGamepadTextInputLineModeSingleLine,
		[Token(Token = "0x4000C6F")]
		k_EGamepadTextInputLineModeMultipleLines
	}
	[Token(Token = "0x20002ED")]
	public enum EOverlayDirection
	{
		[Token(Token = "0x4000C71")]
		Up,
		[Token(Token = "0x4000C72")]
		Down,
		[Token(Token = "0x4000C73")]
		Left,
		[Token(Token = "0x4000C74")]
		Right,
		[Token(Token = "0x4000C75")]
		Count
	}
	[Token(Token = "0x20002EE")]
	public enum EVROverlayIntersectionMaskPrimitiveType
	{
		[Token(Token = "0x4000C77")]
		OverlayIntersectionPrimitiveType_Rectangle,
		[Token(Token = "0x4000C78")]
		OverlayIntersectionPrimitiveType_Circle
	}
	[Token(Token = "0x20002EF")]
	public enum EVRRenderModelError
	{
		[Token(Token = "0x4000C7A")]
		None = 0,
		[Token(Token = "0x4000C7B")]
		Loading = 100,
		[Token(Token = "0x4000C7C")]
		NotSupported = 200,
		[Token(Token = "0x4000C7D")]
		InvalidArg = 300,
		[Token(Token = "0x4000C7E")]
		InvalidModel = 301,
		[Token(Token = "0x4000C7F")]
		NoShapes = 302,
		[Token(Token = "0x4000C80")]
		MultipleShapes = 303,
		[Token(Token = "0x4000C81")]
		TooManyVertices = 304,
		[Token(Token = "0x4000C82")]
		MultipleTextures = 305,
		[Token(Token = "0x4000C83")]
		BufferTooSmall = 306,
		[Token(Token = "0x4000C84")]
		NotEnoughNormals = 307,
		[Token(Token = "0x4000C85")]
		NotEnoughTexCoords = 308,
		[Token(Token = "0x4000C86")]
		InvalidTexture = 400
	}
	[Token(Token = "0x20002F0")]
	public enum EVRComponentProperty
	{
		[Token(Token = "0x4000C88")]
		IsStatic = 1,
		[Token(Token = "0x4000C89")]
		IsVisible = 2,
		[Token(Token = "0x4000C8A")]
		IsTouched = 4,
		[Token(Token = "0x4000C8B")]
		IsPressed = 8,
		[Token(Token = "0x4000C8C")]
		IsScrolled = 0x10
	}
	[Token(Token = "0x20002F1")]
	public enum EVRNotificationType
	{
		[Token(Token = "0x4000C8E")]
		Transient,
		[Token(Token = "0x4000C8F")]
		Persistent,
		[Token(Token = "0x4000C90")]
		Transient_SystemWithUserValue
	}
	[Token(Token = "0x20002F2")]
	public enum EVRNotificationStyle
	{
		[Token(Token = "0x4000C92")]
		None = 0,
		[Token(Token = "0x4000C93")]
		Application = 100,
		[Token(Token = "0x4000C94")]
		Contact_Disabled = 200,
		[Token(Token = "0x4000C95")]
		Contact_Enabled = 201,
		[Token(Token = "0x4000C96")]
		Contact_Active = 202
	}
	[Token(Token = "0x20002F3")]
	public enum EVRSettingsError
	{
		[Token(Token = "0x4000C98")]
		None,
		[Token(Token = "0x4000C99")]
		IPCFailed,
		[Token(Token = "0x4000C9A")]
		WriteFailed,
		[Token(Token = "0x4000C9B")]
		ReadFailed,
		[Token(Token = "0x4000C9C")]
		JsonParseFailed,
		[Token(Token = "0x4000C9D")]
		UnsetSettingHasNoDefault
	}
	[Token(Token = "0x20002F4")]
	public enum EVRScreenshotError
	{
		[Token(Token = "0x4000C9F")]
		None = 0,
		[Token(Token = "0x4000CA0")]
		RequestFailed = 1,
		[Token(Token = "0x4000CA1")]
		IncompatibleVersion = 100,
		[Token(Token = "0x4000CA2")]
		NotFound = 101,
		[Token(Token = "0x4000CA3")]
		BufferTooSmall = 102,
		[Token(Token = "0x4000CA4")]
		ScreenshotAlreadyInProgress = 108
	}
	[StructLayout(2)]
	[Token(Token = "0x20002F5")]
	public struct VREvent_Data_t
	{
		[Token(Token = "0x4000CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Reserved_t reserved;

		[Token(Token = "0x4000CA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Controller_t controller;

		[Token(Token = "0x4000CA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Mouse_t mouse;

		[Token(Token = "0x4000CA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Scroll_t scroll;

		[Token(Token = "0x4000CA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Process_t process;

		[Token(Token = "0x4000CAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Notification_t notification;

		[Token(Token = "0x4000CAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Overlay_t overlay;

		[Token(Token = "0x4000CAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Status_t status;

		[Token(Token = "0x4000CAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Ipd_t ipd;

		[Token(Token = "0x4000CAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Chaperone_t chaperone;

		[Token(Token = "0x4000CAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_PerformanceTest_t performanceTest;

		[Token(Token = "0x4000CB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_TouchPadMove_t touchPadMove;

		[Token(Token = "0x4000CB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_SeatedZeroPoseReset_t seatedZeroPoseReset;

		[Token(Token = "0x4000CB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Screenshot_t screenshot;

		[Token(Token = "0x4000CB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_ScreenshotProgress_t screenshotProgress;

		[Token(Token = "0x4000CB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_ApplicationLaunch_t applicationLaunch;

		[Token(Token = "0x4000CB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_EditingCameraSurface_t cameraSurface;

		[Token(Token = "0x4000CB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_MessageOverlay_t messageOverlay;

		[Token(Token = "0x4000CB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Property_t property;

		[Token(Token = "0x4000CB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_DualAnalog_t dualAnalog;

		[Token(Token = "0x4000CB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_HapticVibration_t hapticVibration;

		[Token(Token = "0x4000CBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VREvent_Keyboard_t keyboard;
	}
	[StructLayout(2)]
	[Token(Token = "0x20002F6")]
	public struct VROverlayIntersectionMaskPrimitive_Data_t
	{
		[Token(Token = "0x4000CBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntersectionMaskRectangle_t m_Rectangle;

		[Token(Token = "0x4000CBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntersectionMaskCircle_t m_Circle;
	}
	[Token(Token = "0x20002F7")]
	public struct HmdMatrix34_t
	{
		[Token(Token = "0x4000CBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m0;

		[Token(Token = "0x4000CBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m1;

		[Token(Token = "0x4000CBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m2;

		[Token(Token = "0x4000CC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m3;

		[Token(Token = "0x4000CC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m4;

		[Token(Token = "0x4000CC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m5;

		[Token(Token = "0x4000CC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m6;

		[Token(Token = "0x4000CC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m7;

		[Token(Token = "0x4000CC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m8;

		[Token(Token = "0x4000CC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m9;

		[Token(Token = "0x4000CC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m10;

		[Token(Token = "0x4000CC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m11;
	}
	[Token(Token = "0x20002F8")]
	public struct HmdMatrix44_t
	{
		[Token(Token = "0x4000CC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m0;

		[Token(Token = "0x4000CCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m1;

		[Token(Token = "0x4000CCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m2;

		[Token(Token = "0x4000CCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m3;

		[Token(Token = "0x4000CCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m4;

		[Token(Token = "0x4000CCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m5;

		[Token(Token = "0x4000CCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m6;

		[Token(Token = "0x4000CD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m7;

		[Token(Token = "0x4000CD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m8;

		[Token(Token = "0x4000CD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m9;

		[Token(Token = "0x4000CD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m10;

		[Token(Token = "0x4000CD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m11;

		[Token(Token = "0x4000CD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m12;

		[Token(Token = "0x4000CD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m13;

		[Token(Token = "0x4000CD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m14;

		[Token(Token = "0x4000CD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float m15;
	}
	[Token(Token = "0x20002F9")]
	public struct HmdVector3_t
	{
		[Token(Token = "0x4000CD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float v0;

		[Token(Token = "0x4000CDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float v1;

		[Token(Token = "0x4000CDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float v2;
	}
	[Token(Token = "0x20002FA")]
	public struct HmdVector4_t
	{
		[Token(Token = "0x4000CDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float v0;

		[Token(Token = "0x4000CDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float v1;

		[Token(Token = "0x4000CDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float v2;

		[Token(Token = "0x4000CDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float v3;
	}
	[Token(Token = "0x20002FB")]
	public struct HmdVector3d_t
	{
		[Token(Token = "0x4000CE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double v0;

		[Token(Token = "0x4000CE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double v1;

		[Token(Token = "0x4000CE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double v2;
	}
	[Token(Token = "0x20002FC")]
	public struct HmdVector2_t
	{
		[Token(Token = "0x4000CE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float v0;

		[Token(Token = "0x4000CE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float v1;
	}
	[Token(Token = "0x20002FD")]
	public struct HmdQuaternion_t
	{
		[Token(Token = "0x4000CE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double w;

		[Token(Token = "0x4000CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double x;

		[Token(Token = "0x4000CE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double y;

		[Token(Token = "0x4000CE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double z;
	}
	[Token(Token = "0x20002FE")]
	public struct HmdColor_t
	{
		[Token(Token = "0x4000CE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float r;

		[Token(Token = "0x4000CEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float g;

		[Token(Token = "0x4000CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float b;

		[Token(Token = "0x4000CEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float a;
	}
	[Token(Token = "0x20002FF")]
	public struct HmdQuad_t
	{
		[Token(Token = "0x4000CED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdVector3_t vCorners0;

		[Token(Token = "0x4000CEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public HmdVector3_t vCorners1;

		[Token(Token = "0x4000CEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HmdVector3_t vCorners2;

		[Token(Token = "0x4000CF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public HmdVector3_t vCorners3;
	}
	[Token(Token = "0x2000300")]
	public struct HmdRect2_t
	{
		[Token(Token = "0x4000CF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdVector2_t vTopLeft;

		[Token(Token = "0x4000CF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public HmdVector2_t vBottomRight;
	}
	[Token(Token = "0x2000301")]
	public struct DistortionCoordinates_t
	{
		[Token(Token = "0x4000CF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rfRed0;

		[Token(Token = "0x4000CF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float rfRed1;

		[Token(Token = "0x4000CF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float rfGreen0;

		[Token(Token = "0x4000CF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rfGreen1;

		[Token(Token = "0x4000CF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float rfBlue0;

		[Token(Token = "0x4000CF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float rfBlue1;
	}
	[Token(Token = "0x2000302")]
	public struct Texture_t
	{
		[Token(Token = "0x4000CF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x4000CFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ETextureType eType;

		[Token(Token = "0x4000CFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EColorSpace eColorSpace;
	}
	[Token(Token = "0x2000303")]
	public struct TrackedDevicePose_t
	{
		[Token(Token = "0x4000CFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdMatrix34_t mDeviceToAbsoluteTracking;

		[Token(Token = "0x4000CFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HmdVector3_t vVelocity;

		[Token(Token = "0x4000CFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public HmdVector3_t vAngularVelocity;

		[Token(Token = "0x4000CFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ETrackingResult eTrackingResult;

		[Token(Token = "0x4000D00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bPoseIsValid;

		[Token(Token = "0x4000D01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool bDeviceIsConnected;
	}
	[Token(Token = "0x2000304")]
	public struct VRTextureBounds_t
	{
		[Token(Token = "0x4000D02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float uMin;

		[Token(Token = "0x4000D03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float vMin;

		[Token(Token = "0x4000D04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float uMax;

		[Token(Token = "0x4000D05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float vMax;
	}
	[Token(Token = "0x2000305")]
	public struct VRTextureWithPose_t
	{
		[Token(Token = "0x4000D06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdMatrix34_t mDeviceToAbsoluteTracking;
	}
	[Token(Token = "0x2000306")]
	public struct VRTextureDepthInfo_t
	{
		[Token(Token = "0x4000D07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x4000D08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public HmdMatrix44_t mProjection;

		[Token(Token = "0x4000D09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public HmdVector2_t vRange;
	}
	[Token(Token = "0x2000307")]
	public struct VRTextureWithDepth_t
	{
		[Token(Token = "0x4000D0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VRTextureDepthInfo_t depth;
	}
	[Token(Token = "0x2000308")]
	public struct VRTextureWithPoseAndDepth_t
	{
		[Token(Token = "0x4000D0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VRTextureDepthInfo_t depth;
	}
	[Token(Token = "0x2000309")]
	public struct VRVulkanTextureData_t
	{
		[Token(Token = "0x4000D0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nImage;

		[Token(Token = "0x4000D0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr m_pDevice;

		[Token(Token = "0x4000D0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr m_pPhysicalDevice;

		[Token(Token = "0x4000D0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr m_pInstance;

		[Token(Token = "0x4000D10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr m_pQueue;

		[Token(Token = "0x4000D11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint m_nQueueFamilyIndex;

		[Token(Token = "0x4000D12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint m_nWidth;

		[Token(Token = "0x4000D13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint m_nHeight;

		[Token(Token = "0x4000D14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public uint m_nFormat;

		[Token(Token = "0x4000D15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_nSampleCount;
	}
	[Token(Token = "0x200030A")]
	public struct D3D12TextureData_t
	{
		[Token(Token = "0x4000D16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_pResource;

		[Token(Token = "0x4000D17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr m_pCommandQueue;

		[Token(Token = "0x4000D18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_nNodeMask;
	}
	[Token(Token = "0x200030B")]
	public struct VREvent_Controller_t
	{
		[Token(Token = "0x4000D19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint button;
	}
	[Token(Token = "0x200030C")]
	public struct VREvent_Mouse_t
	{
		[Token(Token = "0x4000D1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000D1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000D1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint button;
	}
	[Token(Token = "0x200030D")]
	public struct VREvent_Scroll_t
	{
		[Token(Token = "0x4000D1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float xdelta;

		[Token(Token = "0x4000D1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float ydelta;

		[Token(Token = "0x4000D1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint repeatCount;
	}
	[Token(Token = "0x200030E")]
	public struct VREvent_TouchPadMove_t
	{
		[Token(Token = "0x4000D20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool bFingerDown;

		[Token(Token = "0x4000D21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float flSecondsFingerDown;

		[Token(Token = "0x4000D22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float fValueXFirst;

		[Token(Token = "0x4000D23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float fValueYFirst;

		[Token(Token = "0x4000D24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float fValueXRaw;

		[Token(Token = "0x4000D25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float fValueYRaw;
	}
	[Token(Token = "0x200030F")]
	public struct VREvent_Notification_t
	{
		[Token(Token = "0x4000D26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong ulUserValue;

		[Token(Token = "0x4000D27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint notificationId;
	}
	[Token(Token = "0x2000310")]
	public struct VREvent_Process_t
	{
		[Token(Token = "0x4000D28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint pid;

		[Token(Token = "0x4000D29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint oldPid;

		[Token(Token = "0x4000D2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool bForced;
	}
	[Token(Token = "0x2000311")]
	public struct VREvent_Overlay_t
	{
		[Token(Token = "0x4000D2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong overlayHandle;
	}
	[Token(Token = "0x2000312")]
	public struct VREvent_Status_t
	{
		[Token(Token = "0x4000D2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint statusState;
	}
	[Token(Token = "0x2000313")]
	public struct VREvent_Keyboard_t
	{
		[Token(Token = "0x4000D2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte cNewInput0;

		[Token(Token = "0x4000D2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte cNewInput1;

		[Token(Token = "0x4000D2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte cNewInput2;

		[Token(Token = "0x4000D30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte cNewInput3;

		[Token(Token = "0x4000D31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte cNewInput4;

		[Token(Token = "0x4000D32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public byte cNewInput5;

		[Token(Token = "0x4000D33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public byte cNewInput6;

		[Token(Token = "0x4000D34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public byte cNewInput7;

		[Token(Token = "0x4000D35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong uUserValue;
	}
	[Token(Token = "0x2000314")]
	public struct VREvent_Ipd_t
	{
		[Token(Token = "0x4000D36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float ipdMeters;
	}
	[Token(Token = "0x2000315")]
	public struct VREvent_Chaperone_t
	{
		[Token(Token = "0x4000D37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nPreviousUniverse;

		[Token(Token = "0x4000D38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_nCurrentUniverse;
	}
	[Token(Token = "0x2000316")]
	public struct VREvent_Reserved_t
	{
		[Token(Token = "0x4000D39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong reserved0;

		[Token(Token = "0x4000D3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong reserved1;

		[Token(Token = "0x4000D3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong reserved2;

		[Token(Token = "0x4000D3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ulong reserved3;
	}
	[Token(Token = "0x2000317")]
	public struct VREvent_PerformanceTest_t
	{
		[Token(Token = "0x4000D3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nFidelityLevel;
	}
	[Token(Token = "0x2000318")]
	public struct VREvent_SeatedZeroPoseReset_t
	{
		[Token(Token = "0x4000D3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool bResetBySystemMenu;
	}
	[Token(Token = "0x2000319")]
	public struct VREvent_Screenshot_t
	{
		[Token(Token = "0x4000D3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint handle;

		[Token(Token = "0x4000D40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint type;
	}
	[Token(Token = "0x200031A")]
	public struct VREvent_ScreenshotProgress_t
	{
		[Token(Token = "0x4000D41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float progress;
	}
	[Token(Token = "0x200031B")]
	public struct VREvent_ApplicationLaunch_t
	{
		[Token(Token = "0x4000D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint pid;

		[Token(Token = "0x4000D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unArgsHandle;
	}
	[Token(Token = "0x200031C")]
	public struct VREvent_EditingCameraSurface_t
	{
		[Token(Token = "0x4000D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong overlayHandle;

		[Token(Token = "0x4000D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint nVisualMode;
	}
	[Token(Token = "0x200031D")]
	public struct VREvent_MessageOverlay_t
	{
		[Token(Token = "0x4000D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint unVRMessageOverlayResponse;
	}
	[Token(Token = "0x200031E")]
	public struct VREvent_Property_t
	{
		[Token(Token = "0x4000D47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong container;

		[Token(Token = "0x4000D48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ETrackedDeviceProperty prop;
	}
	[Token(Token = "0x200031F")]
	public struct VREvent_DualAnalog_t
	{
		[Token(Token = "0x4000D49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000D4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float transformedX;

		[Token(Token = "0x4000D4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float transformedY;

		[Token(Token = "0x4000D4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EDualAnalogWhich which;
	}
	[Token(Token = "0x2000320")]
	public struct VREvent_HapticVibration_t
	{
		[Token(Token = "0x4000D4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong containerHandle;

		[Token(Token = "0x4000D4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong componentHandle;

		[Token(Token = "0x4000D50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float fDurationSeconds;

		[Token(Token = "0x4000D51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float fFrequency;

		[Token(Token = "0x4000D52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float fAmplitude;
	}
	[Token(Token = "0x2000321")]
	public struct VREvent_t
	{
		[Token(Token = "0x4000D53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint eventType;

		[Token(Token = "0x4000D54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint trackedDeviceIndex;

		[Token(Token = "0x4000D55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float eventAgeSeconds;

		[Token(Token = "0x4000D56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public VREvent_Data_t data;
	}
	[Token(Token = "0x2000322")]
	public struct VREvent_t_Packed
	{
		[Token(Token = "0x4000D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint eventType;

		[Token(Token = "0x4000D58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint trackedDeviceIndex;

		[Token(Token = "0x4000D59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float eventAgeSeconds;

		[Token(Token = "0x4000D5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VREvent_Data_t data;

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x7C7E84", Offset = "0x7C7E84", VA = "0x7C7E84")]
		public VREvent_t_Packed(VREvent_t unpacked)
		{
		}

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x7C61DC", Offset = "0x7C61DC", VA = "0x7C61DC")]
		public void Unpack(ref VREvent_t unpacked)
		{
		}
	}
	[Token(Token = "0x2000323")]
	public struct HiddenAreaMesh_t
	{
		[Token(Token = "0x4000D5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr pVertexData;

		[Token(Token = "0x4000D5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unTriangleCount;
	}
	[Token(Token = "0x2000324")]
	public struct VRControllerAxis_t
	{
		[Token(Token = "0x4000D5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000D5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;
	}
	[Token(Token = "0x2000325")]
	public struct VRControllerState_t
	{
		[Token(Token = "0x4000D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint unPacketNum;

		[Token(Token = "0x4000D60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong ulButtonPressed;

		[Token(Token = "0x4000D61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong ulButtonTouched;

		[Token(Token = "0x4000D62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRControllerAxis_t rAxis0;

		[Token(Token = "0x4000D63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRControllerAxis_t rAxis1;

		[Token(Token = "0x4000D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VRControllerAxis_t rAxis2;

		[Token(Token = "0x4000D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VRControllerAxis_t rAxis3;

		[Token(Token = "0x4000D66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public VRControllerAxis_t rAxis4;
	}
	[Token(Token = "0x2000326")]
	public struct VRControllerState_t_Packed
	{
		[Token(Token = "0x4000D67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint unPacketNum;

		[Token(Token = "0x4000D68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ulong ulButtonPressed;

		[Token(Token = "0x4000D69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ulong ulButtonTouched;

		[Token(Token = "0x4000D6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public VRControllerAxis_t rAxis0;

		[Token(Token = "0x4000D6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public VRControllerAxis_t rAxis1;

		[Token(Token = "0x4000D6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public VRControllerAxis_t rAxis2;

		[Token(Token = "0x4000D6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public VRControllerAxis_t rAxis3;

		[Token(Token = "0x4000D6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public VRControllerAxis_t rAxis4;

		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x7C6D78", Offset = "0x7C6D78", VA = "0x7C6D78")]
		public VRControllerState_t_Packed(VRControllerState_t unpacked)
		{
		}

		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x7C6DBC", Offset = "0x7C6DBC", VA = "0x7C6DBC")]
		public void Unpack(ref VRControllerState_t unpacked)
		{
		}
	}
	[Token(Token = "0x2000327")]
	public struct Compositor_OverlaySettings
	{
		[Token(Token = "0x4000D6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint size;

		[Token(Token = "0x4000D70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool curved;

		[Token(Token = "0x4000D71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public bool antialias;

		[Token(Token = "0x4000D72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float scale;

		[Token(Token = "0x4000D73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float distance;

		[Token(Token = "0x4000D74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float alpha;

		[Token(Token = "0x4000D75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float uOffset;

		[Token(Token = "0x4000D76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float vOffset;

		[Token(Token = "0x4000D77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float uScale;

		[Token(Token = "0x4000D78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float vScale;

		[Token(Token = "0x4000D79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float gridDivs;

		[Token(Token = "0x4000D7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float gridWidth;

		[Token(Token = "0x4000D7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float gridScale;

		[Token(Token = "0x4000D7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HmdMatrix44_t transform;
	}
	[Token(Token = "0x2000328")]
	public struct CameraVideoStreamFrameHeader_t
	{
		[Token(Token = "0x4000D7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EVRTrackedCameraFrameType eFrameType;

		[Token(Token = "0x4000D7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint nWidth;

		[Token(Token = "0x4000D7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint nHeight;

		[Token(Token = "0x4000D80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint nBytesPerPixel;

		[Token(Token = "0x4000D81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint nFrameSequence;

		[Token(Token = "0x4000D82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TrackedDevicePose_t standingTrackedDevicePose;
	}
	[Token(Token = "0x2000329")]
	public struct DriverDirectMode_FrameTiming
	{
		[Token(Token = "0x4000D83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nSize;

		[Token(Token = "0x4000D84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_nNumFramePresents;

		[Token(Token = "0x4000D85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_nNumMisPresented;

		[Token(Token = "0x4000D86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nNumDroppedFrames;

		[Token(Token = "0x4000D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_nReprojectionFlags;
	}
	[Token(Token = "0x200032A")]
	public struct AppOverrideKeys_t
	{
		[Token(Token = "0x4000D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr pchKey;

		[Token(Token = "0x4000D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pchValue;
	}
	[Token(Token = "0x200032B")]
	public struct Compositor_FrameTiming
	{
		[Token(Token = "0x4000D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nSize;

		[Token(Token = "0x4000D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_nFrameIndex;

		[Token(Token = "0x4000D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_nNumFramePresents;

		[Token(Token = "0x4000D8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nNumMisPresented;

		[Token(Token = "0x4000D8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_nNumDroppedFrames;

		[Token(Token = "0x4000D8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_nReprojectionFlags;

		[Token(Token = "0x4000D90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double m_flSystemTimeInSeconds;

		[Token(Token = "0x4000D91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_flPreSubmitGpuMs;

		[Token(Token = "0x4000D92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m_flPostSubmitGpuMs;

		[Token(Token = "0x4000D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_flTotalRenderGpuMs;

		[Token(Token = "0x4000D94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_flCompositorRenderGpuMs;

		[Token(Token = "0x4000D95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_flCompositorRenderCpuMs;

		[Token(Token = "0x4000D96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m_flCompositorIdleCpuMs;

		[Token(Token = "0x4000D97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m_flClientFrameIntervalMs;

		[Token(Token = "0x4000D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float m_flPresentCallCpuMs;

		[Token(Token = "0x4000D99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float m_flWaitForPresentCpuMs;

		[Token(Token = "0x4000D9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float m_flSubmitFrameMs;

		[Token(Token = "0x4000D9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float m_flWaitGetPosesCalledMs;

		[Token(Token = "0x4000D9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float m_flNewPosesReadyMs;

		[Token(Token = "0x4000D9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float m_flNewFrameReadyMs;

		[Token(Token = "0x4000D9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float m_flCompositorUpdateStartMs;

		[Token(Token = "0x4000D9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float m_flCompositorUpdateEndMs;

		[Token(Token = "0x4000DA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float m_flCompositorRenderStartMs;

		[Token(Token = "0x4000DA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TrackedDevicePose_t m_HmdPose;
	}
	[Token(Token = "0x200032C")]
	public struct Compositor_CumulativeStats
	{
		[Token(Token = "0x4000DA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nPid;

		[Token(Token = "0x4000DA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_nNumFramePresents;

		[Token(Token = "0x4000DA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_nNumDroppedFrames;

		[Token(Token = "0x4000DA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nNumReprojectedFrames;

		[Token(Token = "0x4000DA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_nNumFramePresentsOnStartup;

		[Token(Token = "0x4000DA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_nNumDroppedFramesOnStartup;

		[Token(Token = "0x4000DA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_nNumReprojectedFramesOnStartup;

		[Token(Token = "0x4000DA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint m_nNumLoading;

		[Token(Token = "0x4000DAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint m_nNumFramePresentsLoading;

		[Token(Token = "0x4000DAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint m_nNumDroppedFramesLoading;

		[Token(Token = "0x4000DAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint m_nNumReprojectedFramesLoading;

		[Token(Token = "0x4000DAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint m_nNumTimedOut;

		[Token(Token = "0x4000DAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint m_nNumFramePresentsTimedOut;

		[Token(Token = "0x4000DAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public uint m_nNumDroppedFramesTimedOut;

		[Token(Token = "0x4000DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_nNumReprojectedFramesTimedOut;
	}
	[Token(Token = "0x200032D")]
	public struct VROverlayIntersectionParams_t
	{
		[Token(Token = "0x4000DB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdVector3_t vSource;

		[Token(Token = "0x4000DB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public HmdVector3_t vDirection;

		[Token(Token = "0x4000DB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ETrackingUniverseOrigin eOrigin;
	}
	[Token(Token = "0x200032E")]
	public struct VROverlayIntersectionResults_t
	{
		[Token(Token = "0x4000DB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdVector3_t vPoint;

		[Token(Token = "0x4000DB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public HmdVector3_t vNormal;

		[Token(Token = "0x4000DB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HmdVector2_t vUVs;

		[Token(Token = "0x4000DB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fDistance;
	}
	[Token(Token = "0x200032F")]
	public struct IntersectionMaskRectangle_t
	{
		[Token(Token = "0x4000DB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_flTopLeftX;

		[Token(Token = "0x4000DB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m_flTopLeftY;

		[Token(Token = "0x4000DBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m_flWidth;

		[Token(Token = "0x4000DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m_flHeight;
	}
	[Token(Token = "0x2000330")]
	public struct IntersectionMaskCircle_t
	{
		[Token(Token = "0x4000DBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_flCenterX;

		[Token(Token = "0x4000DBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m_flCenterY;

		[Token(Token = "0x4000DBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m_flRadius;
	}
	[Token(Token = "0x2000331")]
	public struct VROverlayIntersectionMaskPrimitive_t
	{
		[Token(Token = "0x4000DBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EVROverlayIntersectionMaskPrimitiveType m_nPrimitiveType;

		[Token(Token = "0x4000DC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public VROverlayIntersectionMaskPrimitive_Data_t m_Primitive;
	}
	[Token(Token = "0x2000332")]
	public struct RenderModel_ComponentState_t
	{
		[Token(Token = "0x4000DC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdMatrix34_t mTrackingToComponentRenderModel;

		[Token(Token = "0x4000DC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HmdMatrix34_t mTrackingToComponentLocal;

		[Token(Token = "0x4000DC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public uint uProperties;
	}
	[Token(Token = "0x2000333")]
	public struct RenderModel_Vertex_t
	{
		[Token(Token = "0x4000DC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HmdVector3_t vPosition;

		[Token(Token = "0x4000DC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public HmdVector3_t vNormal;

		[Token(Token = "0x4000DC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rfTextureCoord0;

		[Token(Token = "0x4000DC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rfTextureCoord1;
	}
	[Token(Token = "0x2000334")]
	public struct RenderModel_TextureMap_t
	{
		[Token(Token = "0x4000DC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public char unWidth;

		[Token(Token = "0x4000DC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public char unHeight;

		[Token(Token = "0x4000DCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr rubTextureMapData;
	}
	[Token(Token = "0x2000335")]
	public struct RenderModel_TextureMap_t_Packed
	{
		[Token(Token = "0x4000DCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public char unWidth;

		[Token(Token = "0x4000DCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public char unHeight;

		[Token(Token = "0x4000DCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public IntPtr rubTextureMapData;

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x7C7EBC", Offset = "0x7C7EBC", VA = "0x7C7EBC")]
		public RenderModel_TextureMap_t_Packed(RenderModel_TextureMap_t unpacked)
		{
		}

		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x7C7ED0", Offset = "0x7C7ED0", VA = "0x7C7ED0")]
		public void Unpack(ref RenderModel_TextureMap_t unpacked)
		{
		}
	}
	[Token(Token = "0x2000336")]
	public struct RenderModel_t
	{
		[Token(Token = "0x4000DCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr rVertexData;

		[Token(Token = "0x4000DCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unVertexCount;

		[Token(Token = "0x4000DD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr rIndexData;

		[Token(Token = "0x4000DD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint unTriangleCount;

		[Token(Token = "0x4000DD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int diffuseTextureId;
	}
	[Token(Token = "0x2000337")]
	public struct RenderModel_t_Packed
	{
		[Token(Token = "0x4000DD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr rVertexData;

		[Token(Token = "0x4000DD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unVertexCount;

		[Token(Token = "0x4000DD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public IntPtr rIndexData;

		[Token(Token = "0x4000DD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unTriangleCount;

		[Token(Token = "0x4000DD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int diffuseTextureId;

		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x7C7EEC", Offset = "0x7C7EEC", VA = "0x7C7EEC")]
		public RenderModel_t_Packed(RenderModel_t unpacked)
		{
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x7C7F18", Offset = "0x7C7F18", VA = "0x7C7F18")]
		public void Unpack(ref RenderModel_t unpacked)
		{
		}
	}
	[Token(Token = "0x2000338")]
	public struct RenderModel_ControllerMode_State_t
	{
		[Token(Token = "0x4000DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool bScrollWheelVisible;
	}
	[Token(Token = "0x2000339")]
	public struct NotificationBitmap_t
	{
		[Token(Token = "0x4000DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_pImageData;

		[Token(Token = "0x4000DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nWidth;

		[Token(Token = "0x4000DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nHeight;

		[Token(Token = "0x4000DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nBytesPerPixel;
	}
	[Token(Token = "0x200033A")]
	public struct COpenVRContext
	{
		[Token(Token = "0x4000DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_pVRSystem;

		[Token(Token = "0x4000DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr m_pVRChaperone;

		[Token(Token = "0x4000DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr m_pVRChaperoneSetup;

		[Token(Token = "0x4000DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr m_pVRCompositor;

		[Token(Token = "0x4000DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr m_pVROverlay;

		[Token(Token = "0x4000DE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr m_pVRResources;

		[Token(Token = "0x4000DE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr m_pVRRenderModels;

		[Token(Token = "0x4000DE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IntPtr m_pVRExtendedDisplay;

		[Token(Token = "0x4000DE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IntPtr m_pVRSettings;

		[Token(Token = "0x4000DE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IntPtr m_pVRApplications;

		[Token(Token = "0x4000DE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IntPtr m_pVRTrackedCamera;

		[Token(Token = "0x4000DE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr m_pVRScreenshots;

		[Token(Token = "0x4000DE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public IntPtr m_pVRDriverManager;
	}
	[Token(Token = "0x200033B")]
	public class OpenVR
	{
		[Token(Token = "0x200033C")]
		private class COpenVRContext
		{
			[Token(Token = "0x4000EAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private CVRSystem m_pVRSystem;

			[Token(Token = "0x4000EAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private CVRChaperone m_pVRChaperone;

			[Token(Token = "0x4000EAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private CVRChaperoneSetup m_pVRChaperoneSetup;

			[Token(Token = "0x4000EAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private CVRCompositor m_pVRCompositor;

			[Token(Token = "0x4000EB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private CVROverlay m_pVROverlay;

			[Token(Token = "0x4000EB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private CVRRenderModels m_pVRRenderModels;

			[Token(Token = "0x4000EB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private CVRExtendedDisplay m_pVRExtendedDisplay;

			[Token(Token = "0x4000EB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private CVRSettings m_pVRSettings;

			[Token(Token = "0x4000EB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private CVRApplications m_pVRApplications;

			[Token(Token = "0x4000EB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private CVRScreenshots m_pVRScreenshots;

			[Token(Token = "0x4000EB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private CVRTrackedCamera m_pVRTrackedCamera;

			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x7C80F8", Offset = "0x7C80F8", VA = "0x7C80F8")]
			public COpenVRContext()
			{
			}

			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x7C8C38", Offset = "0x7C8C38", VA = "0x7C8C38")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x7C8CFC", Offset = "0x7C8CFC", VA = "0x7C8CFC")]
			private void CheckClear()
			{
			}

			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x7C812C", Offset = "0x7C812C", VA = "0x7C812C")]
			public CVRSystem VRSystem()
			{
				return null;
			}

			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x7C8220", Offset = "0x7C8220", VA = "0x7C8220")]
			public CVRChaperone VRChaperone()
			{
				return null;
			}

			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x7C8310", Offset = "0x7C8310", VA = "0x7C8310")]
			public CVRChaperoneSetup VRChaperoneSetup()
			{
				return null;
			}

			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x7C8400", Offset = "0x7C8400", VA = "0x7C8400")]
			public CVRCompositor VRCompositor()
			{
				return null;
			}

			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0x7C84F0", Offset = "0x7C84F0", VA = "0x7C84F0")]
			public CVROverlay VROverlay()
			{
				return null;
			}

			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0x7C85E0", Offset = "0x7C85E0", VA = "0x7C85E0")]
			public CVRRenderModels VRRenderModels()
			{
				return null;
			}

			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0x7C86D0", Offset = "0x7C86D0", VA = "0x7C86D0")]
			public CVRExtendedDisplay VRExtendedDisplay()
			{
				return null;
			}

			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x7C87C4", Offset = "0x7C87C4", VA = "0x7C87C4")]
			public CVRSettings VRSettings()
			{
				return null;
			}

			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x7C88B4", Offset = "0x7C88B4", VA = "0x7C88B4")]
			public CVRApplications VRApplications()
			{
				return null;
			}

			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x7C89A4", Offset = "0x7C89A4", VA = "0x7C89A4")]
			public CVRScreenshots VRScreenshots()
			{
				return null;
			}

			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x7C8A94", Offset = "0x7C8A94", VA = "0x7C8A94")]
			public CVRTrackedCamera VRTrackedCamera()
			{
				return null;
			}
		}

		[Token(Token = "0x4000DEA")]
		public const uint k_nDriverNone = uint.MaxValue;

		[Token(Token = "0x4000DEB")]
		public const uint k_unMaxDriverDebugResponseSize = 32768u;

		[Token(Token = "0x4000DEC")]
		public const uint k_unTrackedDeviceIndex_Hmd = 0u;

		[Token(Token = "0x4000DED")]
		public const uint k_unMaxTrackedDeviceCount = 64u;

		[Token(Token = "0x4000DEE")]
		public const uint k_unTrackedDeviceIndexOther = 4294967294u;

		[Token(Token = "0x4000DEF")]
		public const uint k_unTrackedDeviceIndexInvalid = uint.MaxValue;

		[Token(Token = "0x4000DF0")]
		public const ulong k_ulInvalidPropertyContainer = 0uL;

		[Token(Token = "0x4000DF1")]
		public const uint k_unInvalidPropertyTag = 0u;

		[Token(Token = "0x4000DF2")]
		public const ulong k_ulInvalidDriverHandle = 0uL;

		[Token(Token = "0x4000DF3")]
		public const uint k_unFloatPropertyTag = 1u;

		[Token(Token = "0x4000DF4")]
		public const uint k_unInt32PropertyTag = 2u;

		[Token(Token = "0x4000DF5")]
		public const uint k_unUint64PropertyTag = 3u;

		[Token(Token = "0x4000DF6")]
		public const uint k_unBoolPropertyTag = 4u;

		[Token(Token = "0x4000DF7")]
		public const uint k_unStringPropertyTag = 5u;

		[Token(Token = "0x4000DF8")]
		public const uint k_unHmdMatrix34PropertyTag = 20u;

		[Token(Token = "0x4000DF9")]
		public const uint k_unHmdMatrix44PropertyTag = 21u;

		[Token(Token = "0x4000DFA")]
		public const uint k_unHmdVector3PropertyTag = 22u;

		[Token(Token = "0x4000DFB")]
		public const uint k_unHmdVector4PropertyTag = 23u;

		[Token(Token = "0x4000DFC")]
		public const uint k_unHiddenAreaPropertyTag = 30u;

		[Token(Token = "0x4000DFD")]
		public const uint k_unPathHandleInfoTag = 31u;

		[Token(Token = "0x4000DFE")]
		public const uint k_unActionPropertyTag = 32u;

		[Token(Token = "0x4000DFF")]
		public const uint k_unInputValuePropertyTag = 33u;

		[Token(Token = "0x4000E00")]
		public const uint k_unWildcardPropertyTag = 34u;

		[Token(Token = "0x4000E01")]
		public const uint k_unHapticVibrationPropertyTag = 35u;

		[Token(Token = "0x4000E02")]
		public const uint k_unOpenVRInternalReserved_Start = 1000u;

		[Token(Token = "0x4000E03")]
		public const uint k_unOpenVRInternalReserved_End = 10000u;

		[Token(Token = "0x4000E04")]
		public const uint k_unMaxPropertyStringSize = 32768u;

		[Token(Token = "0x4000E05")]
		public const uint k_unControllerStateAxisCount = 5u;

		[Token(Token = "0x4000E06")]
		public const ulong k_ulOverlayHandleInvalid = 0uL;

		[Token(Token = "0x4000E07")]
		public const uint k_unScreenshotHandleInvalid = 0u;

		[Token(Token = "0x4000E08")]
		public const string IVRSystem_Version = "IVRSystem_019";

		[Token(Token = "0x4000E09")]
		public const string IVRExtendedDisplay_Version = "IVRExtendedDisplay_001";

		[Token(Token = "0x4000E0A")]
		public const string IVRTrackedCamera_Version = "IVRTrackedCamera_003";

		[Token(Token = "0x4000E0B")]
		public const uint k_unMaxApplicationKeyLength = 128u;

		[Token(Token = "0x4000E0C")]
		public const string k_pch_MimeType_HomeApp = "vr/home";

		[Token(Token = "0x4000E0D")]
		public const string k_pch_MimeType_GameTheater = "vr/game_theater";

		[Token(Token = "0x4000E0E")]
		public const string IVRApplications_Version = "IVRApplications_006";

		[Token(Token = "0x4000E0F")]
		public const string IVRChaperone_Version = "IVRChaperone_003";

		[Token(Token = "0x4000E10")]
		public const string IVRChaperoneSetup_Version = "IVRChaperoneSetup_005";

		[Token(Token = "0x4000E11")]
		public const string IVRCompositor_Version = "IVRCompositor_022";

		[Token(Token = "0x4000E12")]
		public const uint k_unVROverlayMaxKeyLength = 128u;

		[Token(Token = "0x4000E13")]
		public const uint k_unVROverlayMaxNameLength = 128u;

		[Token(Token = "0x4000E14")]
		public const uint k_unMaxOverlayCount = 64u;

		[Token(Token = "0x4000E15")]
		public const uint k_unMaxOverlayIntersectionMaskPrimitivesCount = 32u;

		[Token(Token = "0x4000E16")]
		public const string IVROverlay_Version = "IVROverlay_018";

		[Token(Token = "0x4000E17")]
		public const string k_pch_Controller_Component_GDC2015 = "gdc2015";

		[Token(Token = "0x4000E18")]
		public const string k_pch_Controller_Component_Base = "base";

		[Token(Token = "0x4000E19")]
		public const string k_pch_Controller_Component_Tip = "tip";

		[Token(Token = "0x4000E1A")]
		public const string k_pch_Controller_Component_HandGrip = "handgrip";

		[Token(Token = "0x4000E1B")]
		public const string k_pch_Controller_Component_Status = "status";

		[Token(Token = "0x4000E1C")]
		public const string IVRRenderModels_Version = "IVRRenderModels_005";

		[Token(Token = "0x4000E1D")]
		public const uint k_unNotificationTextMaxSize = 256u;

		[Token(Token = "0x4000E1E")]
		public const string IVRNotifications_Version = "IVRNotifications_002";

		[Token(Token = "0x4000E1F")]
		public const uint k_unMaxSettingsKeyLength = 128u;

		[Token(Token = "0x4000E20")]
		public const string IVRSettings_Version = "IVRSettings_002";

		[Token(Token = "0x4000E21")]
		public const string k_pch_SteamVR_Section = "steamvr";

		[Token(Token = "0x4000E22")]
		public const string k_pch_SteamVR_RequireHmd_String = "requireHmd";

		[Token(Token = "0x4000E23")]
		public const string k_pch_SteamVR_ForcedDriverKey_String = "forcedDriver";

		[Token(Token = "0x4000E24")]
		public const string k_pch_SteamVR_ForcedHmdKey_String = "forcedHmd";

		[Token(Token = "0x4000E25")]
		public const string k_pch_SteamVR_DisplayDebug_Bool = "displayDebug";

		[Token(Token = "0x4000E26")]
		public const string k_pch_SteamVR_DebugProcessPipe_String = "debugProcessPipe";

		[Token(Token = "0x4000E27")]
		public const string k_pch_SteamVR_DisplayDebugX_Int32 = "displayDebugX";

		[Token(Token = "0x4000E28")]
		public const string k_pch_SteamVR_DisplayDebugY_Int32 = "displayDebugY";

		[Token(Token = "0x4000E29")]
		public const string k_pch_SteamVR_SendSystemButtonToAllApps_Bool = "sendSystemButtonToAllApps";

		[Token(Token = "0x4000E2A")]
		public const string k_pch_SteamVR_LogLevel_Int32 = "loglevel";

		[Token(Token = "0x4000E2B")]
		public const string k_pch_SteamVR_IPD_Float = "ipd";

		[Token(Token = "0x4000E2C")]
		public const string k_pch_SteamVR_Background_String = "background";

		[Token(Token = "0x4000E2D")]
		public const string k_pch_SteamVR_BackgroundUseDomeProjection_Bool = "backgroundUseDomeProjection";

		[Token(Token = "0x4000E2E")]
		public const string k_pch_SteamVR_BackgroundCameraHeight_Float = "backgroundCameraHeight";

		[Token(Token = "0x4000E2F")]
		public const string k_pch_SteamVR_BackgroundDomeRadius_Float = "backgroundDomeRadius";

		[Token(Token = "0x4000E30")]
		public const string k_pch_SteamVR_GridColor_String = "gridColor";

		[Token(Token = "0x4000E31")]
		public const string k_pch_SteamVR_PlayAreaColor_String = "playAreaColor";

		[Token(Token = "0x4000E32")]
		public const string k_pch_SteamVR_ShowStage_Bool = "showStage";

		[Token(Token = "0x4000E33")]
		public const string k_pch_SteamVR_ActivateMultipleDrivers_Bool = "activateMultipleDrivers";

		[Token(Token = "0x4000E34")]
		public const string k_pch_SteamVR_DirectMode_Bool = "directMode";

		[Token(Token = "0x4000E35")]
		public const string k_pch_SteamVR_DirectModeEdidVid_Int32 = "directModeEdidVid";

		[Token(Token = "0x4000E36")]
		public const string k_pch_SteamVR_DirectModeEdidPid_Int32 = "directModeEdidPid";

		[Token(Token = "0x4000E37")]
		public const string k_pch_SteamVR_UsingSpeakers_Bool = "usingSpeakers";

		[Token(Token = "0x4000E38")]
		public const string k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float = "speakersForwardYawOffsetDegrees";

		[Token(Token = "0x4000E39")]
		public const string k_pch_SteamVR_BaseStationPowerManagement_Bool = "basestationPowerManagement";

		[Token(Token = "0x4000E3A")]
		public const string k_pch_SteamVR_NeverKillProcesses_Bool = "neverKillProcesses";

		[Token(Token = "0x4000E3B")]
		public const string k_pch_SteamVR_SupersampleScale_Float = "supersampleScale";

		[Token(Token = "0x4000E3C")]
		public const string k_pch_SteamVR_AllowAsyncReprojection_Bool = "allowAsyncReprojection";

		[Token(Token = "0x4000E3D")]
		public const string k_pch_SteamVR_AllowReprojection_Bool = "allowInterleavedReprojection";

		[Token(Token = "0x4000E3E")]
		public const string k_pch_SteamVR_ForceReprojection_Bool = "forceReprojection";

		[Token(Token = "0x4000E3F")]
		public const string k_pch_SteamVR_ForceFadeOnBadTracking_Bool = "forceFadeOnBadTracking";

		[Token(Token = "0x4000E40")]
		public const string k_pch_SteamVR_DefaultMirrorView_Int32 = "defaultMirrorView";

		[Token(Token = "0x4000E41")]
		public const string k_pch_SteamVR_ShowMirrorView_Bool = "showMirrorView";

		[Token(Token = "0x4000E42")]
		public const string k_pch_SteamVR_MirrorViewGeometry_String = "mirrorViewGeometry";

		[Token(Token = "0x4000E43")]
		public const string k_pch_SteamVR_StartMonitorFromAppLaunch = "startMonitorFromAppLaunch";

		[Token(Token = "0x4000E44")]
		public const string k_pch_SteamVR_StartCompositorFromAppLaunch_Bool = "startCompositorFromAppLaunch";

		[Token(Token = "0x4000E45")]
		public const string k_pch_SteamVR_StartDashboardFromAppLaunch_Bool = "startDashboardFromAppLaunch";

		[Token(Token = "0x4000E46")]
		public const string k_pch_SteamVR_StartOverlayAppsFromDashboard_Bool = "startOverlayAppsFromDashboard";

		[Token(Token = "0x4000E47")]
		public const string k_pch_SteamVR_EnableHomeApp = "enableHomeApp";

		[Token(Token = "0x4000E48")]
		public const string k_pch_SteamVR_CycleBackgroundImageTimeSec_Int32 = "CycleBackgroundImageTimeSec";

		[Token(Token = "0x4000E49")]
		public const string k_pch_SteamVR_RetailDemo_Bool = "retailDemo";

		[Token(Token = "0x4000E4A")]
		public const string k_pch_SteamVR_IpdOffset_Float = "ipdOffset";

		[Token(Token = "0x4000E4B")]
		public const string k_pch_SteamVR_AllowSupersampleFiltering_Bool = "allowSupersampleFiltering";

		[Token(Token = "0x4000E4C")]
		public const string k_pch_SteamVR_EnableLinuxVulkanAsync_Bool = "enableLinuxVulkanAsync";

		[Token(Token = "0x4000E4D")]
		public const string k_pch_SteamVR_AllowDisplayLockedMode_Bool = "allowDisplayLockedMode";

		[Token(Token = "0x4000E4E")]
		public const string k_pch_SteamVR_HaveStartedTutorialForNativeChaperoneDriver_Bool = "haveStartedTutorialForNativeChaperoneDriver";

		[Token(Token = "0x4000E4F")]
		public const string k_pch_SteamVR_ForceWindows32bitVRMonitor = "forceWindows32BitVRMonitor";

		[Token(Token = "0x4000E50")]
		public const string k_pch_SteamVR_DebugInput = "debugInput";

		[Token(Token = "0x4000E51")]
		public const string k_pch_Lighthouse_Section = "driver_lighthouse";

		[Token(Token = "0x4000E52")]
		public const string k_pch_Lighthouse_DisableIMU_Bool = "disableimu";

		[Token(Token = "0x4000E53")]
		public const string k_pch_Lighthouse_DisableIMUExceptHMD_Bool = "disableimuexcepthmd";

		[Token(Token = "0x4000E54")]
		public const string k_pch_Lighthouse_UseDisambiguation_String = "usedisambiguation";

		[Token(Token = "0x4000E55")]
		public const string k_pch_Lighthouse_DisambiguationDebug_Int32 = "disambiguationdebug";

		[Token(Token = "0x4000E56")]
		public const string k_pch_Lighthouse_PrimaryBasestation_Int32 = "primarybasestation";

		[Token(Token = "0x4000E57")]
		public const string k_pch_Lighthouse_DBHistory_Bool = "dbhistory";

		[Token(Token = "0x4000E58")]
		public const string k_pch_Lighthouse_EnableBluetooth_Bool = "enableBluetooth";

		[Token(Token = "0x4000E59")]
		public const string k_pch_Lighthouse_PowerManagedBaseStations_String = "PowerManagedBaseStations";

		[Token(Token = "0x4000E5A")]
		public const string k_pch_Null_Section = "driver_null";

		[Token(Token = "0x4000E5B")]
		public const string k_pch_Null_SerialNumber_String = "serialNumber";

		[Token(Token = "0x4000E5C")]
		public const string k_pch_Null_ModelNumber_String = "modelNumber";

		[Token(Token = "0x4000E5D")]
		public const string k_pch_Null_WindowX_Int32 = "windowX";

		[Token(Token = "0x4000E5E")]
		public const string k_pch_Null_WindowY_Int32 = "windowY";

		[Token(Token = "0x4000E5F")]
		public const string k_pch_Null_WindowWidth_Int32 = "windowWidth";

		[Token(Token = "0x4000E60")]
		public const string k_pch_Null_WindowHeight_Int32 = "windowHeight";

		[Token(Token = "0x4000E61")]
		public const string k_pch_Null_RenderWidth_Int32 = "renderWidth";

		[Token(Token = "0x4000E62")]
		public const string k_pch_Null_RenderHeight_Int32 = "renderHeight";

		[Token(Token = "0x4000E63")]
		public const string k_pch_Null_SecondsFromVsyncToPhotons_Float = "secondsFromVsyncToPhotons";

		[Token(Token = "0x4000E64")]
		public const string k_pch_Null_DisplayFrequency_Float = "displayFrequency";

		[Token(Token = "0x4000E65")]
		public const string k_pch_UserInterface_Section = "userinterface";

		[Token(Token = "0x4000E66")]
		public const string k_pch_UserInterface_StatusAlwaysOnTop_Bool = "StatusAlwaysOnTop";

		[Token(Token = "0x4000E67")]
		public const string k_pch_UserInterface_MinimizeToTray_Bool = "MinimizeToTray";

		[Token(Token = "0x4000E68")]
		public const string k_pch_UserInterface_Screenshots_Bool = "screenshots";

		[Token(Token = "0x4000E69")]
		public const string k_pch_UserInterface_ScreenshotType_Int = "screenshotType";

		[Token(Token = "0x4000E6A")]
		public const string k_pch_Notifications_Section = "notifications";

		[Token(Token = "0x4000E6B")]
		public const string k_pch_Notifications_DoNotDisturb_Bool = "DoNotDisturb";

		[Token(Token = "0x4000E6C")]
		public const string k_pch_Keyboard_Section = "keyboard";

		[Token(Token = "0x4000E6D")]
		public const string k_pch_Keyboard_TutorialCompletions = "TutorialCompletions";

		[Token(Token = "0x4000E6E")]
		public const string k_pch_Keyboard_ScaleX = "ScaleX";

		[Token(Token = "0x4000E6F")]
		public const string k_pch_Keyboard_ScaleY = "ScaleY";

		[Token(Token = "0x4000E70")]
		public const string k_pch_Keyboard_OffsetLeftX = "OffsetLeftX";

		[Token(Token = "0x4000E71")]
		public const string k_pch_Keyboard_OffsetRightX = "OffsetRightX";

		[Token(Token = "0x4000E72")]
		public const string k_pch_Keyboard_OffsetY = "OffsetY";

		[Token(Token = "0x4000E73")]
		public const string k_pch_Keyboard_Smoothing = "Smoothing";

		[Token(Token = "0x4000E74")]
		public const string k_pch_Perf_Section = "perfcheck";

		[Token(Token = "0x4000E75")]
		public const string k_pch_Perf_HeuristicActive_Bool = "heuristicActive";

		[Token(Token = "0x4000E76")]
		public const string k_pch_Perf_NotifyInHMD_Bool = "warnInHMD";

		[Token(Token = "0x4000E77")]
		public const string k_pch_Perf_NotifyOnlyOnce_Bool = "warnOnlyOnce";

		[Token(Token = "0x4000E78")]
		public const string k_pch_Perf_AllowTimingStore_Bool = "allowTimingStore";

		[Token(Token = "0x4000E79")]
		public const string k_pch_Perf_SaveTimingsOnExit_Bool = "saveTimingsOnExit";

		[Token(Token = "0x4000E7A")]
		public const string k_pch_Perf_TestData_Float = "perfTestData";

		[Token(Token = "0x4000E7B")]
		public const string k_pch_Perf_LinuxGPUProfiling_Bool = "linuxGPUProfiling";

		[Token(Token = "0x4000E7C")]
		public const string k_pch_CollisionBounds_Section = "collisionBounds";

		[Token(Token = "0x4000E7D")]
		public const string k_pch_CollisionBounds_Style_Int32 = "CollisionBoundsStyle";

		[Token(Token = "0x4000E7E")]
		public const string k_pch_CollisionBounds_GroundPerimeterOn_Bool = "CollisionBoundsGroundPerimeterOn";

		[Token(Token = "0x4000E7F")]
		public const string k_pch_CollisionBounds_CenterMarkerOn_Bool = "CollisionBoundsCenterMarkerOn";

		[Token(Token = "0x4000E80")]
		public const string k_pch_CollisionBounds_PlaySpaceOn_Bool = "CollisionBoundsPlaySpaceOn";

		[Token(Token = "0x4000E81")]
		public const string k_pch_CollisionBounds_FadeDistance_Float = "CollisionBoundsFadeDistance";

		[Token(Token = "0x4000E82")]
		public const string k_pch_CollisionBounds_ColorGammaR_Int32 = "CollisionBoundsColorGammaR";

		[Token(Token = "0x4000E83")]
		public const string k_pch_CollisionBounds_ColorGammaG_Int32 = "CollisionBoundsColorGammaG";

		[Token(Token = "0x4000E84")]
		public const string k_pch_CollisionBounds_ColorGammaB_Int32 = "CollisionBoundsColorGammaB";

		[Token(Token = "0x4000E85")]
		public const string k_pch_CollisionBounds_ColorGammaA_Int32 = "CollisionBoundsColorGammaA";

		[Token(Token = "0x4000E86")]
		public const string k_pch_Camera_Section = "camera";

		[Token(Token = "0x4000E87")]
		public const string k_pch_Camera_EnableCamera_Bool = "enableCamera";

		[Token(Token = "0x4000E88")]
		public const string k_pch_Camera_EnableCameraInDashboard_Bool = "enableCameraInDashboard";

		[Token(Token = "0x4000E89")]
		public const string k_pch_Camera_EnableCameraForCollisionBounds_Bool = "enableCameraForCollisionBounds";

		[Token(Token = "0x4000E8A")]
		public const string k_pch_Camera_EnableCameraForRoomView_Bool = "enableCameraForRoomView";

		[Token(Token = "0x4000E8B")]
		public const string k_pch_Camera_BoundsColorGammaR_Int32 = "cameraBoundsColorGammaR";

		[Token(Token = "0x4000E8C")]
		public const string k_pch_Camera_BoundsColorGammaG_Int32 = "cameraBoundsColorGammaG";

		[Token(Token = "0x4000E8D")]
		public const string k_pch_Camera_BoundsColorGammaB_Int32 = "cameraBoundsColorGammaB";

		[Token(Token = "0x4000E8E")]
		public const string k_pch_Camera_BoundsColorGammaA_Int32 = "cameraBoundsColorGammaA";

		[Token(Token = "0x4000E8F")]
		public const string k_pch_Camera_BoundsStrength_Int32 = "cameraBoundsStrength";

		[Token(Token = "0x4000E90")]
		public const string k_pch_audio_Section = "audio";

		[Token(Token = "0x4000E91")]
		public const string k_pch_audio_OnPlaybackDevice_String = "onPlaybackDevice";

		[Token(Token = "0x4000E92")]
		public const string k_pch_audio_OnRecordDevice_String = "onRecordDevice";

		[Token(Token = "0x4000E93")]
		public const string k_pch_audio_OnPlaybackMirrorDevice_String = "onPlaybackMirrorDevice";

		[Token(Token = "0x4000E94")]
		public const string k_pch_audio_OffPlaybackDevice_String = "offPlaybackDevice";

		[Token(Token = "0x4000E95")]
		public const string k_pch_audio_OffRecordDevice_String = "offRecordDevice";

		[Token(Token = "0x4000E96")]
		public const string k_pch_audio_VIVEHDMIGain = "viveHDMIGain";

		[Token(Token = "0x4000E97")]
		public const string k_pch_Power_Section = "power";

		[Token(Token = "0x4000E98")]
		public const string k_pch_Power_PowerOffOnExit_Bool = "powerOffOnExit";

		[Token(Token = "0x4000E99")]
		public const string k_pch_Power_TurnOffScreensTimeout_Float = "turnOffScreensTimeout";

		[Token(Token = "0x4000E9A")]
		public const string k_pch_Power_TurnOffControllersTimeout_Float = "turnOffControllersTimeout";

		[Token(Token = "0x4000E9B")]
		public const string k_pch_Power_ReturnToWatchdogTimeout_Float = "returnToWatchdogTimeout";

		[Token(Token = "0x4000E9C")]
		public const string k_pch_Power_AutoLaunchSteamVROnButtonPress = "autoLaunchSteamVROnButtonPress";

		[Token(Token = "0x4000E9D")]
		public const string k_pch_Power_PauseCompositorOnStandby_Bool = "pauseCompositorOnStandby";

		[Token(Token = "0x4000E9E")]
		public const string k_pch_Dashboard_Section = "dashboard";

		[Token(Token = "0x4000E9F")]
		public const string k_pch_Dashboard_EnableDashboard_Bool = "enableDashboard";

		[Token(Token = "0x4000EA0")]
		public const string k_pch_Dashboard_ArcadeMode_Bool = "arcadeMode";

		[Token(Token = "0x4000EA1")]
		public const string k_pch_Dashboard_EnableWebUI = "webUI";

		[Token(Token = "0x4000EA2")]
		public const string k_pch_modelskin_Section = "modelskins";

		[Token(Token = "0x4000EA3")]
		public const string k_pch_Driver_Enable_Bool = "enable";

		[Token(Token = "0x4000EA4")]
		public const string k_pch_WebInterface_Section = "WebInterface";

		[Token(Token = "0x4000EA5")]
		public const string k_pch_WebInterface_WebPort_String = "WebPort";

		[Token(Token = "0x4000EA6")]
		public const string IVRScreenshots_Version = "IVRScreenshots_001";

		[Token(Token = "0x4000EA7")]
		public const string IVRResources_Version = "IVRResources_001";

		[Token(Token = "0x4000EA8")]
		public const string IVRDriverManager_Version = "IVRDriverManager_001";

		[Token(Token = "0x4000EAA")]
		private const string FnTable_Prefix = "FnTable:";

		[Token(Token = "0x4000EAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static COpenVRContext _OpenVRInternal_ModuleContext;

		[Token(Token = "0x170000BF")]
		private static uint VRToken
		{
			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0x7C7FC0", Offset = "0x7C7FC0", VA = "0x7C7FC0")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x7C8008", Offset = "0x7C8008", VA = "0x7C8008")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		private static COpenVRContext OpenVRInternal_ModuleContext
		{
			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x7C8054", Offset = "0x7C8054", VA = "0x7C8054")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public static CVRSystem System
		{
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x7C8114", Offset = "0x7C8114", VA = "0x7C8114")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public static CVRChaperone Chaperone
		{
			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x7C8208", Offset = "0x7C8208", VA = "0x7C8208")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public static CVRChaperoneSetup ChaperoneSetup
		{
			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x7C82F8", Offset = "0x7C82F8", VA = "0x7C82F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public static CVRCompositor Compositor
		{
			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x7C83E8", Offset = "0x7C83E8", VA = "0x7C83E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public static CVROverlay Overlay
		{
			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x7C84D8", Offset = "0x7C84D8", VA = "0x7C84D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public static CVRRenderModels RenderModels
		{
			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x7C85C8", Offset = "0x7C85C8", VA = "0x7C85C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public static CVRExtendedDisplay ExtendedDisplay
		{
			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0x7C86B8", Offset = "0x7C86B8", VA = "0x7C86B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		public static CVRSettings Settings
		{
			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0x7C87AC", Offset = "0x7C87AC", VA = "0x7C87AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		public static CVRApplications Applications
		{
			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0x7C889C", Offset = "0x7C889C", VA = "0x7C889C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		public static CVRScreenshots Screenshots
		{
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x7C898C", Offset = "0x7C898C", VA = "0x7C898C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		public static CVRTrackedCamera TrackedCamera
		{
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x7C8A7C", Offset = "0x7C8A7C", VA = "0x7C8A7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x7C7F3C", Offset = "0x7C7F3C", VA = "0x7C7F3C")]
		public static uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType)
		{
			return default(uint);
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x7C7F40", Offset = "0x7C7F40", VA = "0x7C7F40")]
		public static void ShutdownInternal()
		{
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x7C7F44", Offset = "0x7C7F44", VA = "0x7C7F44")]
		public static bool IsHmdPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x7C7F48", Offset = "0x7C7F48", VA = "0x7C7F48")]
		public static bool IsRuntimeInstalled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x7C7F4C", Offset = "0x7C7F4C", VA = "0x7C7F4C")]
		public static string GetStringForHmdError(EVRInitError error)
		{
			return null;
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x7C7FB4", Offset = "0x7C7FB4", VA = "0x7C7FB4")]
		public static IntPtr GetGenericInterface(string pchInterfaceVersion, ref EVRInitError peError)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x7C7FB8", Offset = "0x7C7FB8", VA = "0x7C7FB8")]
		public static bool IsInterfaceVersionValid(string pchInterfaceVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x7C7FBC", Offset = "0x7C7FBC", VA = "0x7C7FBC")]
		public static uint GetInitToken()
		{
			return default(uint);
		}

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x7C8B70", Offset = "0x7C8B70", VA = "0x7C8B70")]
		public static CVRSystem Init(ref EVRInitError peError, EVRApplicationType eApplicationType = EVRApplicationType.VRApplication_Scene)
		{
			return null;
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x7C8CF0", Offset = "0x7C8CF0", VA = "0x7C8CF0")]
		public static void Shutdown()
		{
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x7C8CF4", Offset = "0x7C8CF4", VA = "0x7C8CF4")]
		public OpenVR()
		{
		}
	}
}
namespace LDG
{
	[Token(Token = "0x200033D")]
	public enum BandOption
	{
		[Token(Token = "0x4000EB8")]
		FullRange,
		[Token(Token = "0x4000EB9")]
		StandardRanges,
		[Token(Token = "0x4000EBA")]
		OneOctave,
		[Token(Token = "0x4000EBB")]
		OneHalfOctave,
		[Token(Token = "0x4000EBC")]
		OneThirdOctave,
		[Token(Token = "0x4000EBD")]
		OneSixthOctave,
		[Token(Token = "0x4000EBE")]
		OneTwelvethOctave,
		[Token(Token = "0x4000EBF")]
		A440
	}
	[Token(Token = "0x200033E")]
	public struct Octaves
	{
		[Token(Token = "0x4000EC0")]
		public const float One = 2f;

		[Token(Token = "0x4000EC1")]
		public const float OneHalf = 1.41421f;

		[Token(Token = "0x4000EC2")]
		public const float OneThird = 1.2599f;

		[Token(Token = "0x4000EC3")]
		public const float OneSixth = 1.2246f;

		[Token(Token = "0x4000EC4")]
		public const float OneTwelveth = 1.05946f;

		[Token(Token = "0x4000EC5")]
		public const float OneTwentyFourth = 1.0293f;
	}
	[Token(Token = "0x200033F")]
	public enum FrequencyRangeOption
	{
		[Token(Token = "0x4000EC7")]
		Custom,
		[Token(Token = "0x4000EC8")]
		FullRange,
		[Token(Token = "0x4000EC9")]
		SubBass,
		[Token(Token = "0x4000ECA")]
		Bass,
		[Token(Token = "0x4000ECB")]
		LowMidrange,
		[Token(Token = "0x4000ECC")]
		Midrange,
		[Token(Token = "0x4000ECD")]
		HighMidrange,
		[Token(Token = "0x4000ECE")]
		Presence,
		[Token(Token = "0x4000ECF")]
		Brilliance
	}
	[Token(Token = "0x2000340")]
	public struct FrequencyRange
	{
		[Token(Token = "0x4000ED0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly float lower;

		[Token(Token = "0x4000ED1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public readonly float upper;

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x7C8D90", Offset = "0x7C8D90", VA = "0x7C8D90")]
		public FrequencyRange(float lower, float upper)
		{
		}
	}
	[Token(Token = "0x2000341")]
	public struct Frequency
	{
		[Token(Token = "0x4000ED2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float LowestAudibleFrequency;

		[Token(Token = "0x4000ED3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly float HighestAudibleFrequency;

		[Token(Token = "0x4000ED4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly float[][] FrequencyBands;

		[Token(Token = "0x4000ED5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static FrequencyRange[] frequencyRangePresets;

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x7C8D98", Offset = "0x7C8D98", VA = "0x7C8D98")]
		public static float TransformLinearFrequency(float linearizedFrequency, float repeat, bool alternate, bool reverse)
		{
			return default(float);
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x7C8E10", Offset = "0x7C8E10", VA = "0x7C8E10")]
		public static float RemapLinearFrequency(float linearFrequency, float lower, float upper)
		{
			return default(float);
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x7C8F3C", Offset = "0x7C8F3C", VA = "0x7C8F3C")]
		public static int GetBandCount(BandOption bandOption)
		{
			return default(int);
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x7C8FC0", Offset = "0x7C8FC0", VA = "0x7C8FC0")]
		public static void GetRangePreset(ref float lower, ref float upper, FrequencyRangeOption preset)
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x7C9058", Offset = "0x7C9058", VA = "0x7C9058")]
		public static float LinearToVelicityDecibel01(float linearMagnitude)
		{
			return default(float);
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x7C90B4", Offset = "0x7C90B4", VA = "0x7C90B4")]
		public static float LinearToDecibel(float linear)
		{
			return default(float);
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x7C90E4", Offset = "0x7C90E4", VA = "0x7C90E4")]
		public static float DecibelToLinear(float decibel)
		{
			return default(float);
		}

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x7C90F4", Offset = "0x7C90F4", VA = "0x7C90F4")]
		public static int FrequencyToSpectrumIndex(float frequency, int arrayLength, float sampleRate)
		{
			return default(int);
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x7C912C", Offset = "0x7C912C", VA = "0x7C912C")]
		public static float SpectrumIndexToFrequency(int index, int arrayLength, float sampleRate)
		{
			return default(float);
		}

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x7C914C", Offset = "0x7C914C", VA = "0x7C914C")]
		public static int FrequencyToArrayIndex(float frequency, float lower, float upper, int arrayLength)
		{
			return default(int);
		}

		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x7C9204", Offset = "0x7C9204", VA = "0x7C9204")]
		public static int FrequencyToArrayIndex(float frequency, int arrayLength)
		{
			return default(int);
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x7C92F8", Offset = "0x7C92F8", VA = "0x7C92F8")]
		public static float LinearizeFrequency(float frequency, float lower, float upper)
		{
			return default(float);
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x7C8EAC", Offset = "0x7C8EAC", VA = "0x7C8EAC")]
		public static float LinearizeFrequency(float frequency)
		{
			return default(float);
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x7C9344", Offset = "0x7C9344", VA = "0x7C9344")]
		public static float UnlinearizeFrequency(float linearizeFrequency)
		{
			return default(float);
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x7C93E0", Offset = "0x7C93E0", VA = "0x7C93E0")]
		public static float UnlinearizeFrequency(float linearizeFrequency, float lower, float upper)
		{
			return default(float);
		}

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x7C943C", Offset = "0x7C943C", VA = "0x7C943C")]
		public static float OctavesFromBand(float lower, float upper)
		{
			return default(float);
		}

		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x7C945C", Offset = "0x7C945C", VA = "0x7C945C")]
		public static float CenterFrequencyFromBand(float upper, float lower)
		{
			return default(float);
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x7C9468", Offset = "0x7C9468", VA = "0x7C9468")]
		public static float UpperOctave(float frequency, float octave)
		{
			return default(float);
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x7C9470", Offset = "0x7C9470", VA = "0x7C9470")]
		public static float LowerOctave(float frequency, float octave)
		{
			return default(float);
		}

		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x7C9478", Offset = "0x7C9478", VA = "0x7C9478")]
		public static float BandWidth(float frequency, float octave)
		{
			return default(float);
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x7C9488", Offset = "0x7C9488", VA = "0x7C9488")]
		public static float Velocity(float w, float f)
		{
			return default(float);
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x7C9490", Offset = "0x7C9490", VA = "0x7C9490")]
		public static float WaveLength(float v, float f)
		{
			return default(float);
		}

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x7C9498", Offset = "0x7C9498", VA = "0x7C9498")]
		public static float FrequencyToTime(float f)
		{
			return default(float);
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x7C94A4", Offset = "0x7C94A4", VA = "0x7C94A4")]
		public static float TimeToFrequency(float T)
		{
			return default(float);
		}

		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x7C94B0", Offset = "0x7C94B0", VA = "0x7C94B0")]
		public static float WaveToFrequency(float w, float v)
		{
			return default(float);
		}

		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x7C94B8", Offset = "0x7C94B8", VA = "0x7C94B8")]
		public static float FrequencyFromAngle(float w)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000342")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000ED7")]
		Linear,
		[Token(Token = "0x4000ED8")]
		Curve
	}
	[Token(Token = "0x2000343")]
	public static class Spline
	{
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x7C998C", Offset = "0x7C998C", VA = "0x7C998C")]
		public static float Tween(float normalizedIndex, float[] values, bool closed, InterpolationMode interpolationMode)
		{
			return default(float);
		}

		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x7C9C30", Offset = "0x7C9C30", VA = "0x7C9C30")]
		public static Vector3 Tween(float normalizedIndex, Vector3[] values, bool closed, InterpolationMode interpolationMode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x7C9FB0", Offset = "0x7C9FB0", VA = "0x7C9FB0")]
		public static Color Tween(float normalizedIndex, Color[] values, bool closed, InterpolationMode interpolationType)
		{
			return default(Color);
		}

		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x7C9BC8", Offset = "0x7C9BC8", VA = "0x7C9BC8")]
		private static float Cubic(float v0, float v1, float v2, float v3, float t)
		{
			return default(float);
		}
	}
}
namespace LDG.Drawing
{
	[Token(Token = "0x2000344")]
	public struct DrawGL
	{
		[Token(Token = "0x4000ED9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 vertexCache;

		[Token(Token = "0x4000EDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static Color colorCache;

		[Token(Token = "0x4000EDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static bool firstVertex;

		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x7CA29C", Offset = "0x7CA29C", VA = "0x7CA29C")]
		public static void Rect(Rect rect, bool fill, Color color)
		{
		}

		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x7CA474", Offset = "0x7CA474", VA = "0x7CA474")]
		public static void Line(Vector2 p1, Vector2 p2, Color color)
		{
		}

		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x7CA510", Offset = "0x7CA510", VA = "0x7CA510")]
		public static void Begin(int mode)
		{
		}

		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x7CA57C", Offset = "0x7CA57C", VA = "0x7CA57C")]
		public static void LineStrip(Vector3 vertex, Color color)
		{
		}

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x7CA6D4", Offset = "0x7CA6D4", VA = "0x7CA6D4")]
		public static void Curve(Vector3[] vertices, Color[] colors, int segments, bool closed, InterpolationMode mode)
		{
		}

		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x7CA798", Offset = "0x7CA798", VA = "0x7CA798")]
		public static void Line(Vector3[] vertices, Color[] colors, float width, int segments, bool closed, InterpolationMode mode)
		{
		}

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x7CAAE4", Offset = "0x7CAAE4", VA = "0x7CAAE4")]
		public static void Ring(Vector3[] vertices, Color[] primaryColors, Color[] secondaryColors, float radius, float width, int segments, bool anchored, float anchoredDiameter, InterpolationMode mode)
		{
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x7CAF98", Offset = "0x7CAF98", VA = "0x7CAF98")]
		public static void Graph(float[] values, float range, float width, float height, Color color, InterpolationMode mode)
		{
		}
	}
}
namespace LDG.SoundReactor
{
	[Token(Token = "0x2000345")]
	public enum LevelMode
	{
		[Token(Token = "0x4000EDD")]
		Custom,
		[Token(Token = "0x4000EDE")]
		Flat,
		[Token(Token = "0x4000EDF")]
		LinearAscending,
		[Token(Token = "0x4000EE0")]
		LinearDescending,
		[Token(Token = "0x4000EE1")]
		SquareAscending,
		[Token(Token = "0x4000EE2")]
		SquareDescending,
		[Token(Token = "0x4000EE3")]
		Mute,
		[Token(Token = "0x4000EE4")]
		Max
	}
	[Token(Token = "0x2000346")]
	public enum BandFilters
	{
		[Token(Token = "0x4000EE6")]
		FullRange,
		[Token(Token = "0x4000EE7")]
		SubBass,
		[Token(Token = "0x4000EE8")]
		Bass,
		[Token(Token = "0x4000EE9")]
		LowMid,
		[Token(Token = "0x4000EEA")]
		Mid,
		[Token(Token = "0x4000EEB")]
		UpperMid,
		[Token(Token = "0x4000EEC")]
		Presence,
		[Token(Token = "0x4000EED")]
		Brilliance
	}
	[Token(Token = "0x2000347")]
	[DisallowMultipleComponent]
	public class EQ : SerializeableObject
	{
		[Token(Token = "0x4000EEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] levels;

		[Token(Token = "0x4000EEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] bandFilters;

		[Token(Token = "0x4000EF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slope;

		[Token(Token = "0x4000EF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float offset;

		[Token(Token = "0x4000EF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float master;

		[Token(Token = "0x4000EF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BandFilters bandFilterOption;

		[Token(Token = "0x4000EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LevelMode levelShape;

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x7CB0D4", Offset = "0x7CB0D4", VA = "0x7CB0D4")]
		public float GetLevel(float linearizedFrequency, InterpolationMode interpolationMode)
		{
			return default(float);
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x7CB130", Offset = "0x7CB130", VA = "0x7CB130")]
		public EQ()
		{
		}
	}
	[Token(Token = "0x2000348")]
	[DisallowMultipleComponent]
	public class Level : SerializeableObject
	{
		[Token(Token = "0x4000EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _normalizedLevel;

		[Token(Token = "0x4000EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _levelBeat;

		[Token(Token = "0x4000EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _fallingLevel;

		[Token(Token = "0x4000EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _levelScalar;

		[Token(Token = "0x4000EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _beatScalar;

		[Token(Token = "0x4000EFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SpectrumFilter spectrumFilter;

		[Token(Token = "0x4000EFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float linearizedFrequency;

		[Token(Token = "0x4000EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool inheritable;

		[Token(Token = "0x4000EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool falling;

		[Token(Token = "0x4000EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float levelPrev;

		[Token(Token = "0x4000EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float levelValley;

		[Token(Token = "0x4000F00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float levelDir;

		[Token(Token = "0x170000CC")]
		public float normalizedLevel
		{
			[Token(Token = "0x6000C02")]
			[Address(RVA = "0x7CB20C", Offset = "0x7CB20C", VA = "0x7CB20C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000C03")]
			[Address(RVA = "0x7CB214", Offset = "0x7CB214", VA = "0x7CB214")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public float levelBeat
		{
			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x7CB21C", Offset = "0x7CB21C", VA = "0x7CB21C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CE")]
		public float fallingLevel
		{
			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x7CB224", Offset = "0x7CB224", VA = "0x7CB224")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CF")]
		public float levelScalar
		{
			[Token(Token = "0x6000C06")]
			[Address(RVA = "0x7CB230", Offset = "0x7CB230", VA = "0x7CB230")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D0")]
		public float beatScalar
		{
			[Token(Token = "0x6000C07")]
			[Address(RVA = "0x7CB238", Offset = "0x7CB238", VA = "0x7CB238")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x7CB240", Offset = "0x7CB240", VA = "0x7CB240")]
		public void Set(float linearizedFrequency, float normalizedLevel, float lowerFrequency, float upperFrequency, float repeat, bool alternate, bool reverse, bool flipLevel)
		{
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x7CB358", Offset = "0x7CB358", VA = "0x7CB358")]
		public float GetLevel()
		{
			return default(float);
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x7CB4E0", Offset = "0x7CB4E0", VA = "0x7CB4E0")]
		private bool InheritDependencies()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x7CB688", Offset = "0x7CB688", VA = "0x7CB688")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x7CB76C", Offset = "0x7CB76C", VA = "0x7CB76C")]
		public Level()
		{
		}
	}
	[Token(Token = "0x2000349")]
	public class PropertyDriver : SerializeableObject
	{
		[Token(Token = "0x4000F01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PropertyDriver sharedDriver;

		[Token(Token = "0x4000F02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level level;

		[Token(Token = "0x4000F03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 travel;

		[Token(Token = "0x4000F04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float clipping;

		[Token(Token = "0x4000F05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float strength;

		[Token(Token = "0x4000F06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool onBeat;

		[Token(Token = "0x4000F08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 scaledLevel;

		[Token(Token = "0x4000F09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool updateLevelVector;

		[Token(Token = "0x4000F0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool updateLevelScalar;

		[Token(Token = "0x170000D1")]
		public bool componentMissing
		{
			[Token(Token = "0x6000C0D")]
			[Address(RVA = "0x7CB784", Offset = "0x7CB784", VA = "0x7CB784")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C0E")]
			[Address(RVA = "0x7CB78C", Offset = "0x7CB78C", VA = "0x7CB78C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x7CB798", Offset = "0x7CB798", VA = "0x7CB798")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x7CB7A4", Offset = "0x7CB7A4", VA = "0x7CB7A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x7CB7E0", Offset = "0x7CB7E0", VA = "0x7CB7E0")]
		public Vector3 LevelVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x7CB8F8", Offset = "0x7CB8F8", VA = "0x7CB8F8")]
		public float LevelScalar()
		{
			return default(float);
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x7CBA58", Offset = "0x7CBA58", VA = "0x7CBA58", Slot = "4")]
		protected virtual bool InheritDependencies()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x7CBC34", Offset = "0x7CBC34", VA = "0x7CBC34", Slot = "5")]
		protected virtual void DoLevel()
		{
		}

		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x7CBC38", Offset = "0x7CBC38", VA = "0x7CBC38")]
		public PropertyDriver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200034A")]
	public enum ColorMode
	{
		[Token(Token = "0x4000F0C")]
		Magnitude,
		[Token(Token = "0x4000F0D")]
		Frequency
	}
	[Token(Token = "0x200034B")]
	public class ColorDriver : PropertyDriver
	{
		[Token(Token = "0x4000F0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material[] materials;

		[Token(Token = "0x4000F0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int colorID;

		[Token(Token = "0x4000F10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem ps;

		[Token(Token = "0x4000F11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private VertexElementColor vertexColor;

		[Token(Token = "0x4000F12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ColorMode colorMode;

		[Token(Token = "0x4000F13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool stationaryToggle;

		[Token(Token = "0x4000F14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Gradient mainColor;

		[Token(Token = "0x4000F15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Gradient restingColor;

		[Token(Token = "0x4000F16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int materialIndex;

		[Token(Token = "0x4000F17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool instaciateMaterial;

		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x7CBCA8", Offset = "0x7CBCA8", VA = "0x7CBCA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x7CBF1C", Offset = "0x7CBF1C", VA = "0x7CBF1C")]
		public ColorDriver()
		{
		}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x7CC04C", Offset = "0x7CC04C", VA = "0x7CC04C")]
		private void ColorsToGradient(Color[] colors)
		{
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x7CC17C", Offset = "0x7CC17C", VA = "0x7CC17C")]
		public void SetColorSpectrum()
		{
		}

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x7CBFC4", Offset = "0x7CBFC4", VA = "0x7CBFC4")]
		public void SetColorDefault()
		{
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x7CC268", Offset = "0x7CC268", VA = "0x7CC268", Slot = "5")]
		protected override void DoLevel()
		{
		}
	}
	[Token(Token = "0x200034C")]
	public class EventDriver : PropertyDriver
	{
		[Serializable]
		[Token(Token = "0x200034D")]
		public class OnLevel : UnityEvent<PropertyDriver>
		{
			[Token(Token = "0x6000C1E")]
			[Address(RVA = "0x7CC7BC", Offset = "0x7CC7BC", VA = "0x7CC7BC")]
			public OnLevel()
			{
			}
		}

		[Token(Token = "0x4000F18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OnLevel onLevel;

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x7CC75C", Offset = "0x7CC75C", VA = "0x7CC75C", Slot = "5")]
		protected override void DoLevel()
		{
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x7CC7B8", Offset = "0x7CC7B8", VA = "0x7CC7B8")]
		public EventDriver()
		{
		}
	}
	[Token(Token = "0x200034E")]
	public enum ForceType
	{
		[Token(Token = "0x4000F1A")]
		Force,
		[Token(Token = "0x4000F1B")]
		Torque,
		[Token(Token = "0x4000F1C")]
		RelativeForce,
		[Token(Token = "0x4000F1D")]
		RelativeTorque
	}
	[Token(Token = "0x200034F")]
	public class ForceDriver : PropertyDriver
	{
		[Token(Token = "0x4000F1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody rb;

		[Token(Token = "0x4000F1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ForceMode forceMode;

		[Token(Token = "0x4000F20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public ForceType forceType;

		[Token(Token = "0x4000F21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float maxAngularVelocity;

		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x7CC804", Offset = "0x7CC804", VA = "0x7CC804")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x7CC8F0", Offset = "0x7CC8F0", VA = "0x7CC8F0", Slot = "5")]
		protected override void DoLevel()
		{
		}

		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x7CCAE4", Offset = "0x7CCAE4", VA = "0x7CCAE4")]
		public ForceDriver()
		{
		}
	}
	[Token(Token = "0x2000350")]
	public class ParticleEmitterDriver : PropertyDriver
	{
		[Token(Token = "0x4000F22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ParticleSystem ps;

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x7CCAF0", Offset = "0x7CCAF0", VA = "0x7CCAF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x7CCBDC", Offset = "0x7CCBDC", VA = "0x7CCBDC", Slot = "5")]
		protected override void DoLevel()
		{
		}

		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x7CCD44", Offset = "0x7CCD44", VA = "0x7CCD44")]
		public ParticleEmitterDriver()
		{
		}
	}
	[Token(Token = "0x2000351")]
	[DisallowMultipleComponent]
	public class PositionDriver : PropertyDriver
	{
		[Token(Token = "0x4000F23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 localPosition;

		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x7CCD48", Offset = "0x7CCD48", VA = "0x7CCD48")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x7CCD78", Offset = "0x7CCD78", VA = "0x7CCD78", Slot = "5")]
		protected override void DoLevel()
		{
		}

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x7CCDD8", Offset = "0x7CCDD8", VA = "0x7CCDD8")]
		public PositionDriver()
		{
		}
	}
	[Token(Token = "0x2000352")]
	[DisallowMultipleComponent]
	public class RotateDriver : PropertyDriver
	{
		[Token(Token = "0x4000F24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Quaternion localRotation;

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x7CCDDC", Offset = "0x7CCDDC", VA = "0x7CCDDC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x7CCE0C", Offset = "0x7CCE0C", VA = "0x7CCE0C", Slot = "5")]
		protected override void DoLevel()
		{
		}

		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x7CCEEC", Offset = "0x7CCEEC", VA = "0x7CCEEC")]
		public RotateDriver()
		{
		}
	}
	[Token(Token = "0x2000353")]
	[DisallowMultipleComponent]
	public class ScaleDriver : PropertyDriver
	{
		[Token(Token = "0x4000F25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 localScale;

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x7CCEF0", Offset = "0x7CCEF0", VA = "0x7CCEF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x7CCF20", Offset = "0x7CCF20", VA = "0x7CCF20", Slot = "5")]
		protected override void DoLevel()
		{
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x7CCF80", Offset = "0x7CCF80", VA = "0x7CCF80")]
		public ScaleDriver()
		{
		}
	}
	[Token(Token = "0x2000354")]
	public enum AmplitudeMode
	{
		[Token(Token = "0x4000F27")]
		Linear,
		[Token(Token = "0x4000F28")]
		Decibel
	}
	[Token(Token = "0x2000355")]
	public class PeaksProfile : ScriptableObject
	{
		[Token(Token = "0x4000F29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FFTWindow fftWindow;

		[Token(Token = "0x4000F2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int fftSamples;

		[Token(Token = "0x4000F2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AmplitudeMode amplitudeMode;

		[Token(Token = "0x4000F2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float peak;

		[Token(Token = "0x4000F2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float[] peaks;

		[Token(Token = "0x4000F2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int hash;

		[Token(Token = "0x170000D2")]
		public bool isDirty
		{
			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x7CCF84", Offset = "0x7CCF84", VA = "0x7CCF84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x7CCFA8", Offset = "0x7CCFA8", VA = "0x7CCFA8")]
		public PeaksProfile()
		{
		}

		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x7CD08C", Offset = "0x7CD08C", VA = "0x7CD08C")]
		public void SetPeaks(float[] peaks, float peak)
		{
		}

		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x7CD17C", Offset = "0x7CD17C", VA = "0x7CD17C")]
		public void GetPeaks(float[] peaks, ref float peak)
		{
		}

		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x7CCFD0", Offset = "0x7CCFD0", VA = "0x7CCFD0")]
		public void ResetPeaks()
		{
		}

		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x7CD208", Offset = "0x7CD208", VA = "0x7CD208")]
		private int StringToHashCode(string s)
		{
			return default(int);
		}

		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x7CD26C", Offset = "0x7CD26C", VA = "0x7CD26C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000356")]
	public enum ShapeMode
	{
		[Token(Token = "0x4000F30")]
		Line,
		[Token(Token = "0x4000F31")]
		Circle,
		[Token(Token = "0x4000F32")]
		Rectangle,
		[Token(Token = "0x4000F33")]
		SegmentedLevels
	}
	[Token(Token = "0x2000357")]
	public enum VectorShapeMode
	{
		[Token(Token = "0x4000F35")]
		Line,
		[Token(Token = "0x4000F36")]
		Circle
	}
	[Token(Token = "0x2000358")]
	public enum SegmentMode
	{
		[Token(Token = "0x4000F38")]
		Object,
		[Token(Token = "0x4000F39")]
		Vector
	}
	[Token(Token = "0x2000359")]
	public enum SpacingMode
	{
		[Token(Token = "0x4000F3B")]
		Spaced,
		[Token(Token = "0x4000F3C")]
		Divided
	}
	[Token(Token = "0x200035A")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class SpectrumBuilder : SerializeableObject
	{
		[Token(Token = "0x4000F3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ShapeMode shape;

		[Token(Token = "0x4000F3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SegmentMode segmentMode;

		[Token(Token = "0x4000F3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int numColumns;

		[Token(Token = "0x4000F40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int numRows;

		[Token(Token = "0x4000F41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D texture;

		[Token(Token = "0x4000F42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool spacingFoldout;

		[Token(Token = "0x4000F43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public SpacingMode spacingMode;

		[Token(Token = "0x4000F44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool fit;

		[Token(Token = "0x4000F45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject levelInstance;

		[Token(Token = "0x4000F46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool shareDriver;

		[Token(Token = "0x4000F47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector2 layoutSize;

		[Token(Token = "0x4000F48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 levelSize;

		[Token(Token = "0x4000F49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector2 levelSpacing;

		[Token(Token = "0x4000F4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float travel;

		[Token(Token = "0x4000F4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool bandwidthFoldout;

		[Token(Token = "0x4000F4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public FrequencyRangeOption frequencyRangeOption;

		[Token(Token = "0x4000F4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float frequencyLower;

		[Token(Token = "0x4000F4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float frequencyUpper;

		[Token(Token = "0x4000F4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool transformFoldout;

		[Token(Token = "0x4000F50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float transformRepeat;

		[Token(Token = "0x4000F51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool transformAlternate;

		[Token(Token = "0x4000F52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public bool transformReverse;

		[Token(Token = "0x4000F53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		public bool transformFlipLevel;

		[Token(Token = "0x4000F54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public VectorShape vectorShape;

		[Token(Token = "0x4000F55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool vectorAnchored;

		[Token(Token = "0x4000F56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float vectorAnchoredDiameter;

		[Token(Token = "0x4000F57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool closeCurve;

		[Token(Token = "0x4000F58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public ColorDriver colorDriver;

		[Token(Token = "0x4000F59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Material vectorMaterial;

		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x7CD35C", Offset = "0x7CD35C", VA = "0x7CD35C")]
		public GameObject Instantiate(GameObject original, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x7CD508", Offset = "0x7CD508", VA = "0x7CD508")]
		private void SetLevelInfo(GameObject levelObject, GameObject sharedDriver, int arraySize, int index)
		{
		}

		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x7CD53C", Offset = "0x7CD53C", VA = "0x7CD53C")]
		private void SetLevelInfo(GameObject levelObject, GameObject sharedDriver, float linearizedFrequency, float normalizedLevel)
		{
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x7CD6A4", Offset = "0x7CD6A4", VA = "0x7CD6A4")]
		private void AttachSharedDriver(GameObject levelObject, GameObject sharedObject)
		{
		}

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x7CDAB4", Offset = "0x7CDAB4", VA = "0x7CDAB4")]
		private void DeleteLevels()
		{
		}

		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x7CDB74", Offset = "0x7CDB74", VA = "0x7CDB74")]
		private float CalcColumnSpacing()
		{
			return default(float);
		}

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x7CDBC8", Offset = "0x7CDBC8", VA = "0x7CDBC8")]
		private float CalcRowSpacing()
		{
			return default(float);
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x7CDC1C", Offset = "0x7CDC1C", VA = "0x7CDC1C")]
		public void BuildVectorLine()
		{
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x7CE654", Offset = "0x7CE654", VA = "0x7CE654")]
		public void BuildVectorCircle()
		{
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x7CE9A4", Offset = "0x7CE9A4", VA = "0x7CE9A4")]
		public void BuildObjectLine()
		{
		}

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x7CEB38", Offset = "0x7CEB38", VA = "0x7CEB38")]
		public void BuildObjectRectangle()
		{
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x7CEE28", Offset = "0x7CEE28", VA = "0x7CEE28")]
		public void BuildObjectSegmentedLevels()
		{
		}

		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x7CF01C", Offset = "0x7CF01C", VA = "0x7CF01C")]
		public void BuildObjectCircle()
		{
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x7CF298", Offset = "0x7CF298", VA = "0x7CF298")]
		public void Build()
		{
		}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x7CF3A0", Offset = "0x7CF3A0", VA = "0x7CF3A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x7CF3AC", Offset = "0x7CF3AC", VA = "0x7CF3AC")]
		private void OnRenderObject()
		{
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x7CF71C", Offset = "0x7CF71C", VA = "0x7CF71C")]
		public SpectrumBuilder()
		{
		}
	}
	[Token(Token = "0x200035B")]
	[DisallowMultipleComponent]
	public class SpectrumFilter : SerializeableObject
	{
		[Token(Token = "0x4000F5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpectrumSource spectrumSource;

		[Token(Token = "0x4000F5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EQ eq;

		[Token(Token = "0x4000F5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InterpolationMode interpolationMode;

		[Token(Token = "0x4000F5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float scale;

		[Token(Token = "0x4000F5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float fallSpeed;

		[Token(Token = "0x4000F5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float beatSensitivity;

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x7CB3DC", Offset = "0x7CB3DC", VA = "0x7CB3DC")]
		public float GetLevel(float linearizedFrequency)
		{
			return default(float);
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x7CF7DC", Offset = "0x7CF7DC", VA = "0x7CF7DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x7CF7E0", Offset = "0x7CF7E0", VA = "0x7CF7E0")]
		private bool InheritDependencies()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x7CFAA4", Offset = "0x7CFAA4", VA = "0x7CFAA4")]
		public SpectrumFilter()
		{
		}
	}
	[Token(Token = "0x200035C")]
	public enum NormalizeMode
	{
		[Token(Token = "0x4000F61")]
		Raw,
		[Token(Token = "0x4000F62")]
		PeakBand,
		[Token(Token = "0x4000F63")]
		Peak
	}
	[Token(Token = "0x200035D")]
	public enum AudioChannel
	{
		[Token(Token = "0x4000F65")]
		FrontLeft,
		[Token(Token = "0x4000F66")]
		FrontRight,
		[Token(Token = "0x4000F67")]
		FrontCenter,
		[Token(Token = "0x4000F68")]
		Subwoofer,
		[Token(Token = "0x4000F69")]
		RearLeft,
		[Token(Token = "0x4000F6A")]
		RearRight,
		[Token(Token = "0x4000F6B")]
		AlternativeRearLeft,
		[Token(Token = "0x4000F6C")]
		AlternativeRearRight
	}
	[Token(Token = "0x200035E")]
	[DisallowMultipleComponent]
	public class SpectrumSource : SerializeableObject
	{
		[Token(Token = "0x4000F6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _peakLevel;

		[Token(Token = "0x4000F6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _recordProfile;

		[Token(Token = "0x4000F6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource audioSource;

		[Token(Token = "0x4000F70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PeaksProfile peaksProfile;

		[Token(Token = "0x4000F71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int audioChannel;

		[Token(Token = "0x4000F72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BandOption bandOption;

		[Token(Token = "0x4000F73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public NormalizeMode normalizeMode;

		[Token(Token = "0x4000F74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float amplitudeScale;

		[Token(Token = "0x4000F75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] spectrumData;

		[Token(Token = "0x4000F76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] peaks;

		[Token(Token = "0x4000F77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] levels;

		[Token(Token = "0x170000D3")]
		public int channels
		{
			[Token(Token = "0x6000C4A")]
			[Address(RVA = "0x7CFAC4", Offset = "0x7CFAC4", VA = "0x7CFAC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D4")]
		public float peakLevel
		{
			[Token(Token = "0x6000C4B")]
			[Address(RVA = "0x7CFB54", Offset = "0x7CFB54", VA = "0x7CFB54")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D5")]
		public int bandCount
		{
			[Token(Token = "0x6000C4C")]
			[Address(RVA = "0x7CFB5C", Offset = "0x7CFB5C", VA = "0x7CFB5C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D6")]
		public bool recordProfile
		{
			[Token(Token = "0x6000C4D")]
			[Address(RVA = "0x7CFC28", Offset = "0x7CFC28", VA = "0x7CFC28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C4E")]
			[Address(RVA = "0x7CFC30", Offset = "0x7CFC30", VA = "0x7CFC30")]
			set
			{
			}
		}

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x7CF7CC", Offset = "0x7CF7CC", VA = "0x7CF7CC")]
		public float GetLevel(float linearizedFrequency, InterpolationMode interpolationMode)
		{
			return default(float);
		}

		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x7CFC3C", Offset = "0x7CFC3C", VA = "0x7CFC3C")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x7CFF10", Offset = "0x7CFF10", VA = "0x7CFF10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x7CFDF0", Offset = "0x7CFDF0", VA = "0x7CFDF0")]
		private void ResetPeaks()
		{
		}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x7CFCB8", Offset = "0x7CFCB8", VA = "0x7CFCB8")]
		private void UpdateBuffers()
		{
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x7CFF84", Offset = "0x7CFF84", VA = "0x7CFF84")]
		private void UpdateSpectrum()
		{
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x7D0408", Offset = "0x7D0408", VA = "0x7D0408")]
		public SpectrumSource()
		{
		}
	}
	[Token(Token = "0x200035F")]
	public class SerializeableObject : MonoBehaviour
	{
		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x7CB204", Offset = "0x7CB204", VA = "0x7CB204")]
		public SerializeableObject()
		{
		}
	}
	[Token(Token = "0x2000360")]
	public class VectorShape
	{
		[Token(Token = "0x4000F78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public VertexElement[] vertexElements;

		[Token(Token = "0x4000F79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3[] vertices;

		[Token(Token = "0x4000F7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3[] normals;

		[Token(Token = "0x4000F7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] mainColors;

		[Token(Token = "0x4000F7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] restingColors;

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x7CDE80", Offset = "0x7CDE80", VA = "0x7CDE80")]
		public VectorShape(ColorDriver sharedDriver, Transform transform, bool isLine)
		{
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x7D04C0", Offset = "0x7D04C0", VA = "0x7D04C0")]
		private bool UpdateVertexBuffer(float travel)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x7CF580", Offset = "0x7CF580", VA = "0x7CF580")]
		public void Draw(Transform transform, float layoutSize, float elementSize, float travel, bool isLine, bool anchored, float anchoredDiameter, Material material)
		{
		}
	}
	[Token(Token = "0x2000361")]
	public class VertexElement
	{
		[Token(Token = "0x4000F7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 vertex;

		[Token(Token = "0x4000F7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 normal;

		[Token(Token = "0x4000F7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color mainColor;

		[Token(Token = "0x4000F80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color restingColor;

		[Token(Token = "0x4000F81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Level level;

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x7D07F4", Offset = "0x7D07F4", VA = "0x7D07F4")]
		public VertexElement(Level level)
		{
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x7D042C", Offset = "0x7D042C", VA = "0x7D042C")]
		public VertexElement(Level level, Vector3 vertex, Vector3 normal, Color mainColor, Color restingColor)
		{
		}
	}
	[Token(Token = "0x2000362")]
	public class VertexElementColor : MonoBehaviour
	{
		[Token(Token = "0x4000F82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x4000F83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Color mainColor;

		[Token(Token = "0x4000F84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color restingColor;

		[Token(Token = "0x4000F85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public VectorShape vectorShape;

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x7D08B0", Offset = "0x7D08B0", VA = "0x7D08B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x7D0944", Offset = "0x7D0944", VA = "0x7D0944")]
		public VertexElementColor()
		{
		}
	}
}
