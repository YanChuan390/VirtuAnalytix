using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ExitGames.Client.Photon;
using HoloToolkit.Unity;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Lean.Localization;
using Newtonsoft.Json.Linq;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Examples;
using UnityEngine.XR.Interaction.Toolkit.UI;
using fvworks.elysium;
using fvworks.elysium.AI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[CreateAssetMenu(fileName = "HousePartsList", menuName = "ScriptableObjects/LowpolyStyle/HousePartsList", order = 1)]
public class HousePartsList : ScriptableObject
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("House1")]
	public GameObject House1_Exteriour;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject House1_Exteriour_Only;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject House1_Interour;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("House 2")]
	[Space(30f)]
	public GameObject House2_Exteriour;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject House2_Exteriour_Only;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject House2_Interour;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Header("House 3")]
	[Space(30f)]
	public GameObject House3_Exteriour;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject House3_Exteriour_Only;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject House3_Interour;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Space(30f)]
	[Header("L-Shape House Roofs")]
	public GameObject House1_Roof_Wood;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject House1_Roof_Red;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject House1_Roof_Blue;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject House1_Roof_Grey;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject House1_Roof_Planks_Wood;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject House1_Roof_Planks_Red;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject House1_Roof_Planks_Blue;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject House1_Roof_Planks_Grey;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[Header("Top Window Roofs")]
	public GameObject Small_Roof_Top_Wood;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject Small_Roof_Top_Red;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject Small_Roof_Top_Blue;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject Small_Roof_Top_Grey;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[Header("Top Window")]
	public GameObject TopWindow;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[Header("Doors")]
	public GameObject Door;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[Header("Chimney")]
	public GameObject Chimney;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[Header("Pergolas")]
	public GameObject PergolaLarge;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject PergolaSmall;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject PergolaMini;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[Header("Ivy")]
	public GameObject IvyBottom;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public GameObject Ivy;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[Header("Facade")]
	public GameObject House1_Cornerstones;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public GameObject House1_WoodUnderRoof;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x84841C", Offset = "0x84841C", VA = "0x84841C")]
	public HousePartsList()
	{
	}
}
[Token(Token = "0x2000003")]
[DisallowMultipleComponent]
[RequireComponent(typeof(Light))]
public class FlickerLight : MonoBehaviour
{
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0.1f, 1f)]
	[Tooltip("This is the minimal intensity that will be possible for this light.")]
	public float MinIntensity;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("This is the maximum intensity that will be possible for this light.")]
	[Range(1.1f, 3f)]
	public float MaxIntensity;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0.05f, 0.5f)]
	[Tooltip("Influence how fast the light will change.")]
	public float Speed;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Light _light;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float _time;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float _targetIntensity;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float _previousIntensity;

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x848424", Offset = "0x848424", VA = "0x848424")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x848474", Offset = "0x848474", VA = "0x848474")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x848598", Offset = "0x848598", VA = "0x848598")]
	public FlickerLight()
	{
	}
}
[Token(Token = "0x2000004")]
public class RotateWindmill : MonoBehaviour
{
	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Whether the windmill will rotate when WindStrength is greater than 0.")]
	public bool Active;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Tooltip("Randomizes start rotation, so that multiple windmills look more natural.")]
	public bool RandomStartRotation;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 1f)]
	[Tooltip("Wind strength. Highter strength will make the arms rotate faster.")]
	public float WindStrength;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x8485B8", Offset = "0x8485B8", VA = "0x8485B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x848610", Offset = "0x848610", VA = "0x848610")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x848680", Offset = "0x848680", VA = "0x848680")]
	public RotateWindmill()
	{
	}
}
[Token(Token = "0x2000005")]
[RequireComponent(typeof(MeshRenderer))]
public class UVOffset : MonoBehaviour
{
	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float scrollSpeed;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool scrollY;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer renderer;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x848698", Offset = "0x848698", VA = "0x848698")]
	private void Start()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x8486E8", Offset = "0x8486E8", VA = "0x8486E8")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x848778", Offset = "0x848778", VA = "0x848778")]
	public UVOffset()
	{
	}
}
[Token(Token = "0x2000006")]
[RequireComponent(typeof(Camera))]
public class EnableCameraDepthInForward : MonoBehaviour
{
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x848790", Offset = "0x848790", VA = "0x848790")]
	private void Start()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x848794", Offset = "0x848794", VA = "0x848794")]
	private void Set()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x848818", Offset = "0x848818", VA = "0x848818")]
	public EnableCameraDepthInForward()
	{
	}
}
[Token(Token = "0x2000007")]
[ExecuteInEditMode]
public class WaterReflection : MonoBehaviour
{
	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_DisablePixelLights;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int m_TextureSize;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_ClipPlaneOffset;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LayerMask m_ReflectLayers;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private System.Collections.Hashtable m_ReflectionCameras;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture m_ReflectionTexture;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_OldReflectionTextureSize;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool s_InsideRendering;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x848820", Offset = "0x848820", VA = "0x848820")]
	public void OnWillRenderObject()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x849C1C", Offset = "0x849C1C", VA = "0x849C1C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x8495B8", Offset = "0x8495B8", VA = "0x8495B8")]
	private void UpdateCameraModes(Camera src, Camera dest)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x8490D4", Offset = "0x8490D4", VA = "0x8490D4")]
	private void CreateMirrorObjects(Camera currentCamera, out Camera reflectionCamera)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x849FDC", Offset = "0x849FDC", VA = "0x849FDC")]
	private static float sgn(float a)
	{
		return default(float);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x84991C", Offset = "0x84991C", VA = "0x84991C")]
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x849ACC", Offset = "0x849ACC", VA = "0x849ACC")]
	private static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x849888", Offset = "0x849888", VA = "0x849888")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x849FFC", Offset = "0x849FFC", VA = "0x849FFC")]
	public WaterReflection()
	{
	}
}
[Token(Token = "0x2000008")]
public class WorldCategory : MonoBehaviour
{
	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image[] categories;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite highlightImage;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Sprite normalImage;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x84A08C", Offset = "0x84A08C", VA = "0x84A08C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x84A0DC", Offset = "0x84A0DC", VA = "0x84A0DC")]
	private void HighlightDefault()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x84A0E4", Offset = "0x84A0E4", VA = "0x84A0E4")]
	public void SelectCategory(int index)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x84A23C", Offset = "0x84A23C", VA = "0x84A23C")]
	public WorldCategory()
	{
	}
}
[Token(Token = "0x2000009")]
public class Seed : MonoBehaviour
{
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject m_PlantObj;

	[Token(Token = "0x17000001")]
	public GameObject PlantObj
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x84A244", Offset = "0x84A244", VA = "0x84A244")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x84A24C", Offset = "0x84A24C", VA = "0x84A24C")]
	private void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x84A250", Offset = "0x84A250", VA = "0x84A250")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x84A254", Offset = "0x84A254", VA = "0x84A254")]
	public Seed()
	{
	}
}
[Token(Token = "0x200000A")]
public class SFXPlayer : MonoBehaviour
{
	[Token(Token = "0x200000B")]
	public struct PlayParameters
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Pitch;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Volume;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int SourceID;
	}

	[Token(Token = "0x200000C")]
	public class PlayEvent
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Time;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x84AE68", Offset = "0x84AE68", VA = "0x84AE68")]
		public PlayEvent()
		{
		}
	}

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SFXPlayer s_Instance;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource SFXReferenceSource;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int SFXSourceCount;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, PlayEvent> m_PlayEvents;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<int> m_PlayingSources;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioSource[] m_SFXSourcePool;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_UsedSource;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float volumeCoeff;

	[Token(Token = "0x17000002")]
	public static SFXPlayer Instance
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x84A25C", Offset = "0x84A25C", VA = "0x84A25C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x84A2A4", Offset = "0x84A2A4", VA = "0x84A2A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x84A474", Offset = "0x84A474", VA = "0x84A474")]
	private void Start()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x84A4F0", Offset = "0x84A4F0", VA = "0x84A4F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x84A950", Offset = "0x84A950", VA = "0x84A950")]
	internal void UpdateCoeff(float volume)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x84A958", Offset = "0x84A958", VA = "0x84A958")]
	public AudioSource GetNewSource()
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x84A9C8", Offset = "0x84A9C8", VA = "0x84A9C8")]
	public void PlaySFX(AudioClip clip, Vector3 position, float volume = 0.3f)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x84AAB8", Offset = "0x84AAB8", VA = "0x84AAB8")]
	public void PlaySFX(AudioClip clip, Vector3 position, PlayParameters parameters, float cooldownTime = 0.5f, bool isClosedCaptioned = false)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x84AE70", Offset = "0x84AE70", VA = "0x84AE70")]
	public SFXPlayer()
	{
	}
}
[Token(Token = "0x200000D")]
public class BuildPiece : MonoBehaviour
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject indication;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer render;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x84AF38", Offset = "0x84AF38", VA = "0x84AF38")]
	private void Start()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x84AF3C", Offset = "0x84AF3C", VA = "0x84AF3C")]
	private void Update()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x84AF40", Offset = "0x84AF40", VA = "0x84AF40")]
	public void OnGrab()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x84B048", Offset = "0x84B048", VA = "0x84B048")]
	public void OnRelease()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x84B04C", Offset = "0x84B04C", VA = "0x84B04C")]
	public BuildPiece()
	{
	}
}
[Token(Token = "0x200000E")]
public class HandPrefab : MonoBehaviour
{
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator Animator;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x84B054", Offset = "0x84B054", VA = "0x84B054")]
	public HandPrefab()
	{
	}
}
[Token(Token = "0x200000F")]
public class PullMeasurer : XRBaseInteractable
{
	[Token(Token = "0x2000010")]
	public class PullEvent : UnityEvent<Vector3, float>
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x84B7E0", Offset = "0x84B7E0", VA = "0x84B7E0")]
		public PullEvent()
		{
		}
	}

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public PullEvent Pulled;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Transform start;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Transform end;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private float pullAmount;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private XRBaseInteractor pullingInteractor;

	[Token(Token = "0x17000003")]
	public float PullAmount
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x84B05C", Offset = "0x84B05C", VA = "0x84B05C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x84B064", Offset = "0x84B064", VA = "0x84B064", Slot = "66")]
	protected override void OnSelectEntered(SelectEnterEventArgs args)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x84B19C", Offset = "0x84B19C", VA = "0x84B19C", Slot = "68")]
	protected override void OnSelectExited(SelectExitEventArgs args)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x84B2E0", Offset = "0x84B2E0", VA = "0x84B2E0", Slot = "58")]
	public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x84B32C", Offset = "0x84B32C", VA = "0x84B32C")]
	private void CheckForPull()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x84B380", Offset = "0x84B380", VA = "0x84B380")]
	private float CalculatePull(Vector3 pullPosition)
	{
		return default(float);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x84B554", Offset = "0x84B554", VA = "0x84B554")]
	private Vector3 CalculatePosition(float amount)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x84B240", Offset = "0x84B240", VA = "0x84B240")]
	private void SetPullValues(Vector3 newPullPosition, float newPullAmount)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x84B5E0", Offset = "0x84B5E0", VA = "0x84B5E0", Slot = "87")]
	public override bool IsSelectableBy(XRBaseInteractor interactor)
	{
		return default(bool);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x84B60C", Offset = "0x84B60C", VA = "0x84B60C")]
	private bool IsDirectInteractor(XRBaseInteractor interactor)
	{
		return default(bool);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x84B684", Offset = "0x84B684", VA = "0x84B684")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x84B77C", Offset = "0x84B77C", VA = "0x84B77C")]
	public PullMeasurer()
	{
	}
}
[Token(Token = "0x2000011")]
[RequireComponent(typeof(LineRenderer))]
[ExecuteInEditMode]
public class StringRenderer : MonoBehaviour
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	public Gradient pullColor;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("References")]
	public PullMeasurer pullMeaserer;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("Render Positions")]
	public Transform start;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform middle;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform end;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x84B828", Offset = "0x84B828", VA = "0x84B828")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x84B878", Offset = "0x84B878", VA = "0x84B878")]
	private void Update()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x84B984", Offset = "0x84B984", VA = "0x84B984")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x84BA80", Offset = "0x84BA80", VA = "0x84BA80")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x84B8AC", Offset = "0x84B8AC", VA = "0x84B8AC")]
	private void UpdatePositions()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x84BB7C", Offset = "0x84BB7C", VA = "0x84BB7C")]
	private void UpdateColor(Vector3 pullPosition, float pullAmount)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x84BBEC", Offset = "0x84BBEC", VA = "0x84BBEC")]
	public StringRenderer()
	{
	}
}
[Token(Token = "0x2000012")]
public class Contract : MonoBehaviour
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isTriggered;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip sound;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject handprint;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string menuName;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x84BBF4", Offset = "0x84BBF4", VA = "0x84BBF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x84BBF8", Offset = "0x84BBF8", VA = "0x84BBF8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x84BBFC", Offset = "0x84BBFC", VA = "0x84BBFC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x84BD20", Offset = "0x84BD20", VA = "0x84BD20")]
	private void Return()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x84BD7C", Offset = "0x84BD7C", VA = "0x84BD7C")]
	public Contract()
	{
	}
}
[Token(Token = "0x2000013")]
public class WaterAnimation : MonoBehaviour
{
	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float startValue;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float endValue;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 localPostion;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x84BDCC", Offset = "0x84BDCC", VA = "0x84BDCC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x84BDFC", Offset = "0x84BDFC", VA = "0x84BDFC")]
	public void UpdateHeight(float amount)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x84BE3C", Offset = "0x84BE3C", VA = "0x84BE3C")]
	public WaterAnimation()
	{
	}
}
[Token(Token = "0x2000014")]
[AddComponentMenu("XR/Action Based Controller Manager")]
[DefaultExecutionOrder(10)]
public class ActionBasedControllerManager : MonoBehaviour
{
	[Token(Token = "0x2000015")]
	public enum StateId
	{
		[Token(Token = "0x4000073")]
		None,
		[Token(Token = "0x4000074")]
		Select,
		[Token(Token = "0x4000075")]
		Teleport,
		[Token(Token = "0x4000076")]
		Interact
	}

	[Serializable]
	[Token(Token = "0x2000016")]
	public class StateEnterEvent : UnityEvent<StateId>
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x84DF7C", Offset = "0x84DF7C", VA = "0x84DF7C")]
		public StateEnterEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000017")]
	public class StateUpdateEvent : UnityEvent
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x84DFC4", Offset = "0x84DFC4", VA = "0x84DFC4")]
		public StateUpdateEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000018")]
	public class StateExitEvent : UnityEvent<StateId>
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x84DFCC", Offset = "0x84DFCC", VA = "0x84DFCC")]
		public StateExitEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000019")]
	public class ControllerState
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Tooltip("Sets the controller state to be active. For the default states, setting this value to true will automatically update their StateUpdateEvent.")]
		private bool m_Enabled;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		[HideInInspector]
		private StateId m_Id;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StateEnterEvent m_OnEnter;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StateUpdateEvent m_OnUpdate;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StateExitEvent m_OnExit;

		[Token(Token = "0x17000010")]
		public bool enabled
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x84E014", Offset = "0x84E014", VA = "0x84E014")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x84E01C", Offset = "0x84E01C", VA = "0x84E01C")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public StateId id
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x84E028", Offset = "0x84E028", VA = "0x84E028")]
			get
			{
				return default(StateId);
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x84E030", Offset = "0x84E030", VA = "0x84E030")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public StateEnterEvent onEnter
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x84E038", Offset = "0x84E038", VA = "0x84E038")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x84E040", Offset = "0x84E040", VA = "0x84E040")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public StateUpdateEvent onUpdate
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x84E048", Offset = "0x84E048", VA = "0x84E048")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x84E050", Offset = "0x84E050", VA = "0x84E050")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public StateExitEvent onExit
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x84E058", Offset = "0x84E058", VA = "0x84E058")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x84E060", Offset = "0x84E060", VA = "0x84E060")]
			set
			{
			}
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x84DEA8", Offset = "0x84DEA8", VA = "0x84DEA8")]
		public ControllerState(StateId defaultId = StateId.None)
		{
		}
	}

	[Token(Token = "0x400005A")]
	public const int kControllerManagerUpdateOrder = 10;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("m_BaseControllerGO")]
	[Tooltip("The base controller GameObject, used for changing default settings on its components during state transitions.")]
	[Header("Controller GameObjects")]
	[Space]
	private GameObject m_BaseControllerGameObject;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("m_RayControllerGO")]
	[Tooltip("The base controller GameObject, used for changing default settings on its components during state transitions.")]
	private GameObject m_RayControllerGameObject;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The teleport controller GameObject, used for changing default settings on its components during state transitions.")]
	[FormerlySerializedAs("m_TeleportControllerGO")]
	[SerializeField]
	private GameObject m_TeleportControllerGameObject;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("Controller Actions")]
	[Space]
	[Tooltip("The reference to the action of activating the teleport mode for this controller.")]
	[SerializeField]
	private InputActionReference m_TeleportModeActivate;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Tooltip("The reference to the action of canceling the teleport mode for this controller.")]
	private InputActionReference m_TeleportModeCancel;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Tooltip("The reference to the action of turning the XR rig with this controller.")]
	private InputActionReference m_Turn;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("The reference to the action of moving the XR rig with this controller.")]
	[SerializeField]
	private InputActionReference m_Move;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("m_TranslateObject")]
	[SerializeField]
	[Tooltip("The reference to the action of translating the selected object of this controller.")]
	private InputActionReference m_TranslateAnchor;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	[FormerlySerializedAs("m_RotateObject")]
	[Tooltip("The reference to the action of rotating the selected object of this controller.")]
	private InputActionReference m_RotateAnchor;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Space]
	[Header("Default States")]
	[SerializeField]
	[Tooltip("The default Select state and events for the controller.")]
	private ControllerState m_SelectState;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Tooltip("The default Teleport state and events for the controller.")]
	private ControllerState m_TeleportState;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Tooltip("The default Interact state and events for the controller.")]
	private ControllerState m_InteractState;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly List<ControllerState> m_DefaultStates;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private XRBaseController m_BaseController;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private XRBaseInteractor m_BaseInteractor;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private XRInteractorLineVisual m_BaseLineVisual;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private XRBaseController m_RayController;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private XRBaseInteractor m_RayInteractor;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private XRInteractorLineVisual m_RayLineVisual;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private XRBaseController m_TeleportController;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private XRBaseInteractor m_TeleportInteractor;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private XRInteractorLineVisual m_TeleportLineVisual;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isDirectInteract;

	[Token(Token = "0x17000004")]
	public GameObject baseControllerGameObject
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x84BE50", Offset = "0x84BE50", VA = "0x84BE50")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x84BE58", Offset = "0x84BE58", VA = "0x84BE58")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public GameObject rayControllerGameObject
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x84BE60", Offset = "0x84BE60", VA = "0x84BE60")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x84BE68", Offset = "0x84BE68", VA = "0x84BE68")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public GameObject teleportControllerGameObject
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x84BE70", Offset = "0x84BE70", VA = "0x84BE70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x84BE78", Offset = "0x84BE78", VA = "0x84BE78")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public InputActionReference teleportModeActivate
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x84BE80", Offset = "0x84BE80", VA = "0x84BE80")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x84BE88", Offset = "0x84BE88", VA = "0x84BE88")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public InputActionReference teleportModeCancel
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x84BE90", Offset = "0x84BE90", VA = "0x84BE90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x84BE98", Offset = "0x84BE98", VA = "0x84BE98")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public InputActionReference turn
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x84BEA0", Offset = "0x84BEA0", VA = "0x84BEA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x84BEA8", Offset = "0x84BEA8", VA = "0x84BEA8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public InputActionReference move
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x84BEB0", Offset = "0x84BEB0", VA = "0x84BEB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x84BEB8", Offset = "0x84BEB8", VA = "0x84BEB8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public InputActionReference translateAnchor
	{
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x84BEC0", Offset = "0x84BEC0", VA = "0x84BEC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x84BEC8", Offset = "0x84BEC8", VA = "0x84BEC8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public InputActionReference rotateAnchor
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x84BED0", Offset = "0x84BED0", VA = "0x84BED0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x84BED8", Offset = "0x84BED8", VA = "0x84BED8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public ControllerState selectState
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x84BEE0", Offset = "0x84BEE0", VA = "0x84BEE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public ControllerState teleportState
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x84BEE8", Offset = "0x84BEE8", VA = "0x84BEE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000F")]
	public ControllerState interactState
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x84BEF0", Offset = "0x84BEF0", VA = "0x84BEF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x84BEF8", Offset = "0x84BEF8", VA = "0x84BEF8")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x84CB40", Offset = "0x84CB40", VA = "0x84CB40")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x84CEAC", Offset = "0x84CEAC", VA = "0x84CEAC")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x84D0AC", Offset = "0x84D0AC", VA = "0x84D0AC")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x84D00C", Offset = "0x84D00C", VA = "0x84D00C")]
	private void TransitionState(ControllerState fromState, ControllerState toState)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x84C27C", Offset = "0x84C27C", VA = "0x84C27C")]
	private void FindBaseControllerComponents()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x84C83C", Offset = "0x84C83C", VA = "0x84C83C")]
	private void FindRayControllerComponents()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x84C580", Offset = "0x84C580", VA = "0x84C580")]
	private void FindTeleportControllerComponents()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x84D208", Offset = "0x84D208", VA = "0x84D208")]
	private void SetBaseController(bool enable)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x84D364", Offset = "0x84D364", VA = "0x84D364")]
	private void SetRayController(bool enable)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x84D504", Offset = "0x84D504", VA = "0x84D504")]
	private void SetTeleportController(bool enable)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x84D618", Offset = "0x84D618", VA = "0x84D618")]
	private void OnEnterSelectState(StateId previousStateId)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x84D704", Offset = "0x84D704", VA = "0x84D704")]
	private void OnExitSelectState(StateId nextStateId)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x84D730", Offset = "0x84D730", VA = "0x84D730")]
	private void OnEnterTeleportState(StateId previousStateId)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x84D738", Offset = "0x84D738", VA = "0x84D738")]
	private void OnExitTeleportState(StateId nextStateId)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x84D740", Offset = "0x84D740", VA = "0x84D740")]
	private void OnEnterInteractState(StateId previousStateId)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x84D7D4", Offset = "0x84D7D4", VA = "0x84D7D4")]
	private void OnExitInteractState(StateId nextStateId)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x84D7F8", Offset = "0x84D7F8", VA = "0x84D7F8")]
	private void OnUpdateSelectState()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x84DA3C", Offset = "0x84DA3C", VA = "0x84DA3C")]
	private void OnUpdateTeleportState()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x84DBB0", Offset = "0x84DBB0", VA = "0x84DBB0")]
	private void OnUpdateInteractState()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x84D69C", Offset = "0x84D69C", VA = "0x84D69C")]
	private static void EnableAction(InputActionReference actionReference)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x84D6D0", Offset = "0x84D6D0", VA = "0x84D6D0")]
	private static void DisableAction(InputActionReference actionReference)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x84D9B8", Offset = "0x84D9B8", VA = "0x84D9B8")]
	private static InputAction GetInputAction(InputActionReference actionReference)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x84DD64", Offset = "0x84DD64", VA = "0x84DD64")]
	public void SetAnchor(bool enable)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x84DDC4", Offset = "0x84DDC4", VA = "0x84DDC4")]
	public ActionBasedControllerManager()
	{
	}
}
[Token(Token = "0x200001A")]
public class AxisDragInteractable : XRBaseInteractable
{
	[Serializable]
	[Token(Token = "0x200001B")]
	public class DragDistanceEvent : UnityEvent<float>
	{
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x84F0CC", Offset = "0x84F0CC", VA = "0x84F0CC")]
		public DragDistanceEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200001C")]
	public class DragStepEvent : UnityEvent<int>
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x84F114", Offset = "0x84F114", VA = "0x84F114")]
		public DragStepEvent()
		{
		}
	}

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[Tooltip("The Rigidbody that will be moved. If null will try to grab one on that object or its children")]
	public Rigidbody MovingRigidbody;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Vector3 LocalAxis;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	public float AxisLength;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[Tooltip("If 0, then this is a float [0,1] range slider, otherwise there is an integer slider")]
	public int Steps;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public bool SnapOnlyOnRelease;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x155")]
	public bool ReturnOnFree;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public float ReturnSpeed;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public AudioClip SnapAudioClip;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public DragDistanceEvent OnDragDistance;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public DragStepEvent OnDragStep;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Vector3 m_EndPoint;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private Vector3 m_StartPoint;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Vector3 m_GrabbedOffset;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private float m_CurrentDistance;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private int m_CurrentStep;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private XRBaseInteractor m_GrabbingInteractor;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private float m_StepLength;

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x84E068", Offset = "0x84E068", VA = "0x84E068")]
	private void Start()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x84E2A4", Offset = "0x84E2A4", VA = "0x84E2A4", Slot = "58")]
	public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x84EB68", Offset = "0x84EB68", VA = "0x84EB68", Slot = "76")]
	protected override void OnSelectEntered(XRBaseInteractor interactor)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x84EBFC", Offset = "0x84EBFC", VA = "0x84EBFC", Slot = "78")]
	protected override void OnSelectExited(XRBaseInteractor interactor)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x84EF1C", Offset = "0x84EF1C", VA = "0x84EF1C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x84F0BC", Offset = "0x84F0BC", VA = "0x84F0BC")]
	public AxisDragInteractable()
	{
	}
}
[Token(Token = "0x200001D")]
public class ButtonInteractable : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200001E")]
	public class ButtonPressedEvent : UnityEvent
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x84F658", Offset = "0x84F658", VA = "0x84F658")]
		public ButtonPressedEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200001F")]
	public class ButtonReleasedEvent : UnityEvent
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x84F660", Offset = "0x84F660", VA = "0x84F660")]
		public ButtonReleasedEvent()
		{
		}
	}

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 Axis;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float MaxDistance;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float ReturnSpeed;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioClip ButtonPressAudioClip;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioClip ButtonReleaseAudioClip;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ButtonPressedEvent OnButtonPressed;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonReleasedEvent OnButtonReleased;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 m_StartPosition;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Rigidbody m_Rigidbody;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Collider m_Collider;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool m_Pressed;

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x84F15C", Offset = "0x84F15C", VA = "0x84F15C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x84F1FC", Offset = "0x84F1FC", VA = "0x84F1FC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x84F638", Offset = "0x84F638", VA = "0x84F638")]
	public ButtonInteractable()
	{
	}
}
[Token(Token = "0x2000020")]
public class DialInteractable : XRBaseInteractable
{
	[Token(Token = "0x2000021")]
	public enum InteractionType
	{
		[Token(Token = "0x40000AC")]
		ControllerRotation,
		[Token(Token = "0x40000AD")]
		ControllerPull
	}

	[Serializable]
	[Token(Token = "0x2000022")]
	public class DialTurnedAngleEvent : UnityEvent<float>
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x850FC8", Offset = "0x850FC8", VA = "0x850FC8")]
		public DialTurnedAngleEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000023")]
	public class DialTurnedStepEvent : UnityEvent<int>
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x851010", Offset = "0x851010", VA = "0x851010")]
		public DialTurnedStepEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000024")]
	public class DialChangedEvent : UnityEvent<DialInteractable>
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x851058", Offset = "0x851058", VA = "0x851058")]
		public DialChangedEvent()
		{
		}
	}

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public InteractionType DialType;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Rigidbody RotatingRigidbody;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Vector3 LocalRotationAxis;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public Vector3 LocalAxisStart;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public float RotationAngleMaximum;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	[Tooltip("If 0, this is a float dial going from 0 to 1, if not 0, that dial is int with that many steps")]
	public int Steps;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public bool SnapOnRelease;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public AudioClip SnapAudioClip;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public DialTurnedAngleEvent OnDialAngleChanged;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public DialTurnedStepEvent OnDialStepChanged;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public DialChangedEvent OnDialChanged;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private XRBaseInteractor m_GrabbingInteractor;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Quaternion m_GrabbedRotation;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Vector3 m_StartingWorldAxis;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private float m_CurrentAngle;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private int m_CurrentStep;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private float m_StepSize;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private Transform m_SyncTransform;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private Transform m_OriginalTransform;

	[Token(Token = "0x17000015")]
	public float CurrentAngle
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x84F668", Offset = "0x84F668", VA = "0x84F668")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000016")]
	public int CurrentStep
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x84F670", Offset = "0x84F670", VA = "0x84F670")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x84F678", Offset = "0x84F678", VA = "0x84F678")]
	private void Start()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x84F998", Offset = "0x84F998", VA = "0x84F998", Slot = "58")]
	public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x85062C", Offset = "0x85062C", VA = "0x85062C", Slot = "66")]
	protected override void OnSelectEntered(SelectEnterEventArgs args)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x8507E4", Offset = "0x8507E4", VA = "0x8507E4", Slot = "68")]
	protected override void OnSelectExited(SelectExitEventArgs args)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x850F2C", Offset = "0x850F2C", VA = "0x850F2C", Slot = "87")]
	public override bool IsSelectableBy(XRBaseInteractor interactor)
	{
		return default(bool);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x850FB8", Offset = "0x850FB8", VA = "0x850FB8")]
	public DialInteractable()
	{
	}
}
[Token(Token = "0x2000025")]
public class XRGrabbable : XRGrabInteractable
{
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x8510A0", Offset = "0x8510A0", VA = "0x8510A0")]
	public XRGrabbable()
	{
	}
}
[Token(Token = "0x2000026")]
public class XROffsetGrabbable : XRGrabInteractable
{
	[Token(Token = "0x2000027")]
	private class SavedTransform
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 OriginalPosition;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion OriginalRotation;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x851338", Offset = "0x851338", VA = "0x851338")]
		public SavedTransform()
		{
		}
	}

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private Dictionary<XRBaseInteractor, SavedTransform> m_SavedTransforms;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private Rigidbody m_Rb;

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x8510F8", Offset = "0x8510F8", VA = "0x8510F8", Slot = "47")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x851154", Offset = "0x851154", VA = "0x851154", Slot = "66")]
	protected override void OnSelectEntered(SelectEnterEventArgs args)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x851340", Offset = "0x851340", VA = "0x851340", Slot = "68")]
	protected override void OnSelectExited(SelectExitEventArgs args)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x851484", Offset = "0x851484", VA = "0x851484")]
	public XROffsetGrabbable()
	{
	}
}
[Token(Token = "0x2000028")]
[RequireComponent(typeof(PhotonView))]
public class CubeLerp : MonoBehaviourPunCallbacks, IPunObservable
{
	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 latestCorrectPos;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 onUpdatePos;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float fraction;

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x851524", Offset = "0x851524", VA = "0x851524")]
	public void Start()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x851574", Offset = "0x851574", VA = "0x851574", Slot = "54")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x851710", Offset = "0x851710", VA = "0x851710")]
	public void Update()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x8517C0", Offset = "0x8517C0", VA = "0x8517C0")]
	public CubeLerp()
	{
	}
}
namespace UnityEngine.XR.Interaction.Toolkit.Examples
{
	[Token(Token = "0x2000029")]
	public class LocomotionSchemeManager : MonoBehaviour
	{
		[Token(Token = "0x200002A")]
		public enum MoveScheme
		{
			[Token(Token = "0x40000C5")]
			Noncontinuous,
			[Token(Token = "0x40000C6")]
			Continuous
		}

		[Token(Token = "0x200002B")]
		public enum TurnStyle
		{
			[Token(Token = "0x40000C8")]
			Snap,
			[Token(Token = "0x40000C9")]
			Continuous
		}

		[Token(Token = "0x200002C")]
		public enum MoveForwardSource
		{
			[Token(Token = "0x40000CB")]
			Head,
			[Token(Token = "0x40000CC")]
			LeftHand,
			[Token(Token = "0x40000CD")]
			RightHand
		}

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Controls which movement control scheme to use.")]
		private MoveScheme m_MoveScheme;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("Controls which turn style of locomotion to use.")]
		private TurnStyle m_TurnStyle;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Controls which orientation the forward direction of continuous movement is relative to.")]
		private MoveForwardSource m_MoveForwardSource;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Input action assets associated with locomotion to affect when the active movement control scheme is set. Can use this list by itself or together with the Action Maps list to set control scheme masks by Asset or Map.")]
		private List<InputActionAsset> m_ActionAssets;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Input action maps associated with locomotion to affect when the active movement control scheme is set. Can use this list together with the Action Assets list to set control scheme masks by Map instead of the whole Asset.")]
		private List<string> m_ActionMaps;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Input actions associated with locomotion to affect when the active movement control scheme is set. Can use this list to select exactly the actions to affect instead of setting control scheme masks by Asset or Map.")]
		private List<InputActionReference> m_Actions;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Name of an input control scheme that defines the grouping of bindings that should remain enabled when applying any movement control scheme. Control schemes are created and named in the Input Actions window. The other movement control schemes are applied additively to this scheme. Can be an empty string, which means only bindings that match the specified movement control scheme will be enabled.")]
		private string m_BaseControlScheme;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Name of an input control scheme that defines the grouping of bindings that should remain enabled when applying the noncontinuous movement control scheme. Control schemes are created and named in the Input Actions window. Can be an empty string, which means only bindings that match the base control scheme will be enabled.")]
		[SerializeField]
		private string m_NoncontinuousControlScheme;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Name of an input control scheme that defines the grouping of bindings that should remain enabled when applying the continuous movement control scheme. Control schemes are created and named in the Input Actions window. Can be an empty string, which means only bindings that match the base control scheme will be enabled.")]
		[SerializeField]
		private string m_ContinuousControlScheme;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("Stores the locomotion provider for continuous movement.")]
		private ContinuousMoveProviderBase m_ContinuousMoveProvider;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Stores the locomotion provider for continuous turning.")]
		[SerializeField]
		private ContinuousTurnProviderBase m_ContinuousTurnProvider;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Stores the locomotion provider for snap turning.")]
		[SerializeField]
		private SnapTurnProviderBase m_SnapTurnProvider;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Tooltip("Stores the \"Head\" Transform used with continuous movement when inputs should be relative to head orientation (usually the main camera).")]
		private Transform m_HeadForwardSource;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Stores the \"Left Hand\" Transform used with continuous movement when inputs should be relative to the left hand's orientation.")]
		[SerializeField]
		private Transform m_LeftHandForwardSource;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Tooltip("Stores the \"Right Hand\" Transform used with continuous movement when inputs should be relative to the right hand's orientation.")]
		private Transform m_RightHandForwardSource;

		[Token(Token = "0x17000017")]
		public MoveScheme moveScheme
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x8517C8", Offset = "0x8517C8", VA = "0x8517C8")]
			get
			{
				return default(MoveScheme);
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x8517D0", Offset = "0x8517D0", VA = "0x8517D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public TurnStyle turnStyle
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x851960", Offset = "0x851960", VA = "0x851960")]
			get
			{
				return default(TurnStyle);
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x851968", Offset = "0x851968", VA = "0x851968")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public MoveForwardSource moveForwardSource
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x851B7C", Offset = "0x851B7C", VA = "0x851B7C")]
			get
			{
				return default(MoveForwardSource);
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x851B84", Offset = "0x851B84", VA = "0x851B84")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public List<InputActionAsset> actionAssets
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x851D9C", Offset = "0x851D9C", VA = "0x851D9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x851DA4", Offset = "0x851DA4", VA = "0x851DA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public List<string> actionMaps
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x851DAC", Offset = "0x851DAC", VA = "0x851DAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x851DB4", Offset = "0x851DB4", VA = "0x851DB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public List<InputActionReference> actions
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x851DBC", Offset = "0x851DBC", VA = "0x851DBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x851DC4", Offset = "0x851DC4", VA = "0x851DC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public string baseControlScheme
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x851DCC", Offset = "0x851DCC", VA = "0x851DCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x851DD4", Offset = "0x851DD4", VA = "0x851DD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public string noncontinuousControlScheme
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x851DDC", Offset = "0x851DDC", VA = "0x851DDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x851DE4", Offset = "0x851DE4", VA = "0x851DE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public string continuousControlScheme
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x851DEC", Offset = "0x851DEC", VA = "0x851DEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x851DF4", Offset = "0x851DF4", VA = "0x851DF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public ContinuousMoveProviderBase continuousMoveProvider
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x851DFC", Offset = "0x851DFC", VA = "0x851DFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x851E04", Offset = "0x851E04", VA = "0x851E04")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public ContinuousTurnProviderBase continuousTurnProvider
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x851E0C", Offset = "0x851E0C", VA = "0x851E0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x851E14", Offset = "0x851E14", VA = "0x851E14")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public SnapTurnProviderBase snapTurnProvider
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x851E1C", Offset = "0x851E1C", VA = "0x851E1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x851E24", Offset = "0x851E24", VA = "0x851E24")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Transform headForwardSource
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x851E2C", Offset = "0x851E2C", VA = "0x851E2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x851E34", Offset = "0x851E34", VA = "0x851E34")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Transform leftHandForwardSource
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x851E3C", Offset = "0x851E3C", VA = "0x851E3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x851E44", Offset = "0x851E44", VA = "0x851E44")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Transform rightHandForwardSource
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x851E4C", Offset = "0x851E4C", VA = "0x851E4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x851E54", Offset = "0x851E54", VA = "0x851E54")]
			set
			{
			}
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x851E5C", Offset = "0x851E5C", VA = "0x851E5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x851EF0", Offset = "0x851EF0", VA = "0x851EF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x8517F4", Offset = "0x8517F4", VA = "0x8517F4")]
		private void SetMoveScheme(MoveScheme scheme)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x85198C", Offset = "0x85198C", VA = "0x85198C")]
		private void SetTurnStyle(TurnStyle style)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x851BA8", Offset = "0x851BA8", VA = "0x851BA8")]
		private void SetMoveForwardSource(MoveForwardSource forwardSource)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x851F44", Offset = "0x851F44", VA = "0x851F44")]
		private void SetBindingMasks(string controlSchemeName)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x851EF4", Offset = "0x851EF4", VA = "0x851EF4")]
		private void ClearBindingMasks()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x852664", Offset = "0x852664", VA = "0x852664")]
		private InputControlScheme? FindControlScheme(string controlSchemeName, InputActionReference action)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x852A5C", Offset = "0x852A5C", VA = "0x852A5C")]
		private InputControlScheme? FindControlScheme(string controlSchemeName, InputActionAsset asset)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x85281C", Offset = "0x85281C", VA = "0x85281C")]
		private static InputBinding? GetBindingMask(InputControlScheme? baseInputControlScheme, InputControlScheme? inputControlScheme)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x852C30", Offset = "0x852C30", VA = "0x852C30")]
		public LocomotionSchemeManager()
		{
		}
	}
}
namespace HoloToolkit.Unity
{
	[Token(Token = "0x200002D")]
	public enum PivotAxis
	{
		[Token(Token = "0x40000CF")]
		Free,
		[Token(Token = "0x40000D0")]
		Y
	}
	[Token(Token = "0x200002E")]
	public class Billboard : MonoBehaviour
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Specifies the axis about which the object will rotate.")]
		public PivotAxis PivotAxis;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Specifies the target we will orient to. If no Target is specified the main camera will be used.")]
		private Transform TargetTransform;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x852C38", Offset = "0x852C38", VA = "0x852C38")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x852CF4", Offset = "0x852CF4", VA = "0x852CF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x852E28", Offset = "0x852E28", VA = "0x852E28")]
		public Billboard()
		{
		}
	}
}
namespace PolyPerfect
{
	[Token(Token = "0x200002F")]
	public class Common_PlaySound : MonoBehaviour
	{
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClip animalSound;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip walking;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip eating;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip running;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioClip attacking;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioClip death;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioClip sleeping;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AudioSource audioSource;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x852E30", Offset = "0x852E30", VA = "0x852E30")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x852E80", Offset = "0x852E80", VA = "0x852E80")]
		private void AnimalSound()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x852EF8", Offset = "0x852EF8", VA = "0x852EF8")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x852F60", Offset = "0x852F60", VA = "0x852F60")]
		private void Walking()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x852FD8", Offset = "0x852FD8", VA = "0x852FD8")]
		private void Eating()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x853050", Offset = "0x853050", VA = "0x853050")]
		private void Running()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x8530C8", Offset = "0x8530C8", VA = "0x8530C8")]
		private void Attacking()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x853140", Offset = "0x853140", VA = "0x853140")]
		private void Death()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x8531B8", Offset = "0x8531B8", VA = "0x8531B8")]
		private void Sleeping()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x853230", Offset = "0x853230", VA = "0x853230")]
		public Common_PlaySound()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class AnimalPlaySound : Common_PlaySound
	{
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x853238", Offset = "0x853238", VA = "0x853238")]
		public AnimalPlaySound()
		{
		}
	}
}
namespace Photon.Realtime.Demo
{
	[Token(Token = "0x2000031")]
	public class ConnectAndJoinRandomLb : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks, ILobbyCallbacks
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppSettings appSettings;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LoadBalancingClient lbc;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ConnectionHandler ch;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text StateUiText;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x853240", Offset = "0x853240", VA = "0x853240")]
		public void Start()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x8533A0", Offset = "0x8533A0", VA = "0x8533A0")]
		public void Update()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x8534D4", Offset = "0x8534D4", VA = "0x8534D4", Slot = "4")]
		public void OnConnected()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x8534D8", Offset = "0x8534D8", VA = "0x8534D8", Slot = "5")]
		public void OnConnectedToMaster()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x85355C", Offset = "0x85355C", VA = "0x85355C", Slot = "6")]
		public void OnDisconnected(DisconnectCause cause)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x853648", Offset = "0x853648", VA = "0x853648", Slot = "8")]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x85364C", Offset = "0x85364C", VA = "0x85364C", Slot = "9")]
		public void OnCustomAuthenticationFailed(string debugMessage)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x853650", Offset = "0x853650", VA = "0x853650", Slot = "7")]
		public void OnRegionListReceived(RegionHandler regionHandler)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x85372C", Offset = "0x85372C", VA = "0x85372C", Slot = "19")]
		public void OnRoomListUpdate(List<RoomInfo> roomList)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x853730", Offset = "0x853730", VA = "0x853730", Slot = "20")]
		public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x853734", Offset = "0x853734", VA = "0x853734", Slot = "17")]
		public void OnJoinedLobby()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x853738", Offset = "0x853738", VA = "0x853738", Slot = "18")]
		public void OnLeftLobby()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x85373C", Offset = "0x85373C", VA = "0x85373C", Slot = "10")]
		public void OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x853740", Offset = "0x853740", VA = "0x853740", Slot = "11")]
		public void OnCreatedRoom()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x853744", Offset = "0x853744", VA = "0x853744", Slot = "12")]
		public void OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x853748", Offset = "0x853748", VA = "0x853748", Slot = "13")]
		public void OnJoinedRoom()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x8537B0", Offset = "0x8537B0", VA = "0x8537B0", Slot = "14")]
		public void OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x8537B4", Offset = "0x8537B4", VA = "0x8537B4", Slot = "15")]
		public void OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x853868", Offset = "0x853868", VA = "0x853868", Slot = "16")]
		public void OnLeftRoom()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x85386C", Offset = "0x85386C", VA = "0x85386C")]
		private void OnRegionPingCompleted(RegionHandler regionHandler)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x853990", Offset = "0x853990", VA = "0x853990")]
		public ConnectAndJoinRandomLb()
		{
		}
	}
}
namespace Photon.Chat.Demo
{
	[Token(Token = "0x2000032")]
	public static class AppSettingsExtensions
	{
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x8539F8", Offset = "0x8539F8", VA = "0x8539F8")]
		public static ChatAppSettings GetChatSettings(this AppSettings appSettings)
		{
			return null;
		}
	}
	[Token(Token = "0x2000033")]
	public class ChannelSelector : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Channel;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x853AC4", Offset = "0x853AC4", VA = "0x853AC4")]
		public void SetChannel(string channel)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x853B38", Offset = "0x853B38", VA = "0x853B38", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x853E38", Offset = "0x853E38", VA = "0x853E38")]
		public ChannelSelector()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[ExecuteInEditMode]
	public class ChatAppIdCheckerUI : MonoBehaviour
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text Description;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x853E40", Offset = "0x853E40", VA = "0x853E40")]
		public void Update()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x853F70", Offset = "0x853F70", VA = "0x853F70")]
		public ChatAppIdCheckerUI()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class ChatGui : MonoBehaviour, IChatClientListener
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] ChannelsToJoinOnConnect;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] FriendsList;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int HistoryLengthToFetch;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string selectedChannelName;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChatClient chatClient;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected internal ChatAppSettings chatAppSettings;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject missingAppIdErrorPanel;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject ConnectingLabel;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public RectTransform ChatPanel;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject UserIdFormPanel;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InputField InputFieldChat;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Text CurrentChannelText;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Toggle ChannelToggleToInstantiate;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GameObject FriendListUiItemtoInstantiate;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly Dictionary<string, Toggle> channelToggles;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly Dictionary<string, FriendItem> friendListItemLUT;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool ShowState;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public GameObject Title;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Text StateText;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Text UserIdText;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string HelpText;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public int TestLength;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private byte[] testBytes;

		[Token(Token = "0x17000026")]
		public string UserName
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x853F78", Offset = "0x853F78", VA = "0x853F78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x853F80", Offset = "0x853F80", VA = "0x853F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x853F88", Offset = "0x853F88", VA = "0x853F88")]
		public void Start()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x854228", Offset = "0x854228", VA = "0x854228")]
		public void Connect()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x854398", Offset = "0x854398", VA = "0x854398")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x8543B0", Offset = "0x8543B0", VA = "0x8543B0")]
		public void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x8543C8", Offset = "0x8543C8", VA = "0x8543C8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x854498", Offset = "0x854498", VA = "0x854498")]
		public void OnEnterSend()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x854F70", Offset = "0x854F70", VA = "0x854F70")]
		public void OnClickSend()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x85452C", Offset = "0x85452C", VA = "0x85452C")]
		private void SendChatMessage(string inputLine)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x855020", Offset = "0x855020", VA = "0x855020")]
		public void PostHelpToCurrentChannel()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x8550C4", Offset = "0x8550C4", VA = "0x8550C4", Slot = "4")]
		public void DebugReturn(DebugLevel level, string message)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x85516C", Offset = "0x85516C", VA = "0x85516C", Slot = "6")]
		public void OnConnected()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x8554A8", Offset = "0x8554A8", VA = "0x8554A8", Slot = "5")]
		public void OnDisconnected()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x8554C8", Offset = "0x8554C8", VA = "0x8554C8", Slot = "7")]
		public void OnChatStateChange(ChatState state)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x85555C", Offset = "0x85555C", VA = "0x85555C", Slot = "10")]
		public void OnSubscribed(string[] channels, bool[] results)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x8558AC", Offset = "0x8558AC", VA = "0x8558AC")]
		public void OnSubscribed(string channel, string[] users, Dictionary<object, object> properties)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x8556F0", Offset = "0x8556F0", VA = "0x8556F0")]
		private void InstantiateChannelButton(string channelName)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x855350", Offset = "0x855350", VA = "0x855350")]
		private void InstantiateFriendButton(string friendId)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x855A70", Offset = "0x855A70", VA = "0x855A70", Slot = "11")]
		public void OnUnsubscribed(string[] channels)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x855EB4", Offset = "0x855EB4", VA = "0x855EB4", Slot = "8")]
		public void OnGetMessages(string channelName, string[] senders, object[] messages)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x855EF4", Offset = "0x855EF4", VA = "0x855EF4", Slot = "9")]
		public void OnPrivateMessage(string sender, object message, string channelName)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x856008", Offset = "0x856008", VA = "0x856008", Slot = "12")]
		public void OnStatusUpdate(string user, int status, bool gotMessage, object message)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x856348", Offset = "0x856348", VA = "0x856348", Slot = "13")]
		public void OnUserSubscribed(string channel, string user)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x85644C", Offset = "0x85644C", VA = "0x85644C", Slot = "14")]
		public void OnUserUnsubscribed(string channel, string user)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x856550", Offset = "0x856550", VA = "0x856550")]
		public void OnChannelPropertiesChanged(string channel, string userId, Dictionary<object, object> properties)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x8566B4", Offset = "0x8566B4", VA = "0x8566B4")]
		public void OnUserPropertiesChanged(string channel, string targetUserId, string senderUserId, Dictionary<object, object> properties)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x85684C", Offset = "0x85684C", VA = "0x85684C")]
		public void OnErrorInfo(string channel, string error, object data)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x85697C", Offset = "0x85697C", VA = "0x85697C")]
		public void AddMessageToSelectedChannel(string msg)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x853BB0", Offset = "0x853BB0", VA = "0x853BB0")]
		public void ShowChannel(string channelName)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x856A68", Offset = "0x856A68", VA = "0x856A68")]
		public void OpenDashboard()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x856AAC", Offset = "0x856AAC", VA = "0x856AAC")]
		public ChatGui()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class FriendItem : MonoBehaviour
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text NameLabel;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text StatusLabel;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text Health;

		[Token(Token = "0x17000027")]
		[HideInInspector]
		public string FriendId
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x856C00", Offset = "0x856C00", VA = "0x856C00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x855A4C", Offset = "0x855A4C", VA = "0x855A4C")]
			set
			{
			}
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x856C24", Offset = "0x856C24", VA = "0x856C24")]
		public void Awake()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x8561C8", Offset = "0x8561C8", VA = "0x8561C8")]
		public void OnFriendStatusUpdate(int status, bool gotMessage, object message)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x856C88", Offset = "0x856C88", VA = "0x856C88")]
		public FriendItem()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class IgnoreUiRaycastWhenInactive : MonoBehaviour, ICanvasRaycastFilter
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x856C90", Offset = "0x856C90", VA = "0x856C90", Slot = "4")]
		public bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x856CB0", Offset = "0x856CB0", VA = "0x856CB0")]
		public IgnoreUiRaycastWhenInactive()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[RequireComponent(typeof(ChatGui))]
	public class NamePickGui : MonoBehaviour
	{
		[Token(Token = "0x40000FC")]
		private const string UserNamePlayerPref = "NamePickUserName";

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ChatGui chatNewComponent;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputField idInput;

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x856CB8", Offset = "0x856CB8", VA = "0x856CB8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x856D78", Offset = "0x856D78", VA = "0x856D78")]
		public void EndEditOnEnter()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x856DB4", Offset = "0x856DB4", VA = "0x856DB4")]
		public void StartChat()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x856E80", Offset = "0x856E80", VA = "0x856E80")]
		public NamePickGui()
		{
		}
	}
}
namespace Photon.Chat.UtilityScripts
{
	[Token(Token = "0x2000039")]
	public class EventSystemSpawner : MonoBehaviour
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x856E88", Offset = "0x856E88", VA = "0x856E88")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x856F90", Offset = "0x856F90", VA = "0x856F90")]
		public EventSystemSpawner()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class OnStartDelete : MonoBehaviour
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x856F98", Offset = "0x856F98", VA = "0x856F98")]
		private void Start()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x857004", Offset = "0x857004", VA = "0x857004")]
		public OnStartDelete()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[RequireComponent(typeof(Text))]
	public class TextButtonTransition : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Text _text;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Selectable Selectable;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color NormalColor;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color HoverColor;

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x85700C", Offset = "0x85700C", VA = "0x85700C")]
		public void Awake()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x85705C", Offset = "0x85705C", VA = "0x85705C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x85708C", Offset = "0x85708C", VA = "0x85708C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x8570BC", Offset = "0x8570BC", VA = "0x8570BC", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x85716C", Offset = "0x85716C", VA = "0x85716C", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x85721C", Offset = "0x85721C", VA = "0x85721C")]
		public TextButtonTransition()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[RequireComponent(typeof(Text))]
	public class TextToggleIsOnTransition : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle toggle;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text _text;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color NormalOnColor;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color NormalOffColor;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color HoverOnColor;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color HoverOffColor;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isHover;

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x857238", Offset = "0x857238", VA = "0x857238")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x85737C", Offset = "0x85737C", VA = "0x85737C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x857318", Offset = "0x857318", VA = "0x857318")]
		public void OnValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x857424", Offset = "0x857424", VA = "0x857424", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x857498", Offset = "0x857498", VA = "0x857498", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x857508", Offset = "0x857508", VA = "0x857508")]
		public TextToggleIsOnTransition()
		{
		}
	}
}
namespace StylizedWaterShader
{
	[Token(Token = "0x200003D")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class EnableDepthBuffer : MonoBehaviour
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera cam;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x85752C", Offset = "0x85752C", VA = "0x85752C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x8575B4", Offset = "0x8575B4", VA = "0x8575B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x857698", Offset = "0x857698", VA = "0x857698")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x85771C", Offset = "0x85771C", VA = "0x85771C")]
		public EnableDepthBuffer()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[HelpURL("http://staggart.xyz/unity/stylized-water-shader/documentation/")]
	[RequireComponent(typeof(MeshRenderer))]
	[ExecuteInEditMode]
	public class StylizedWater : MonoBehaviour
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] shaderNames;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int shaderIndex;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Shader DesktopShader;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Shader MobileAdvancedShader;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(2000f, 4000f)]
		public int renderQueue;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool enableVertexColors;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		public bool enableDepthTex;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool isUnlit;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool enableGradient;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Gradient colorGradient;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[ColorUsage(true, true)]
		public Color waterShallowColor;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 100f)]
		public float depth;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[ColorUsage(true, true)]
		public Color waterColor;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[ColorUsage(true, true)]
		public Color fresnelColor;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float fresnel;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[ColorUsage(true, true)]
		public Color rimColor;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Range(-0.5f, 0.5f)]
		public float waveTint;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[Range(0f, 1f)]
		public float transparency;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Range(0.01f, 1f)]
		public float glossiness;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[Range(0f, 1f)]
		public float metallicness;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Range(0f, 3f)]
		public float edgeFade;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string[] tilingMethodNames;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float worldSpaceTiling;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Range(0f, 0.2f)]
		public float refractionAmount;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool enableNormalMap;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 1f)]
		public float normalStrength;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool enableMacroNormals;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Range(250f, 3000f)]
		public float macroNormalsDistance;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Range(0f, 50f)]
		public float normalTiling;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int intersectionSolver;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string[] intersectionSolverNames;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(0f, 30f)]
		public float rimSize;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Range(0.1f, 30f)]
		public float rimFalloff;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float rimTiling;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[Range(0f, 1f)]
		public float rimDistortion;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public bool enableVCIntersection;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public int foamSolver;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public string[] foamSolverNames;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Range(-1f, 1f)]
		public float foamOpacity;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public float foamTiling;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Range(0f, 1f)]
		public float foamSize;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[Range(0f, 3f)]
		public float foamDistortion;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Range(0f, 1f)]
		public float foamSpeed;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[Range(0f, 1f)]
		public float waveFoam;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[Range(0f, 1f)]
		public float reflectionStrength;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[Range(0.01f, 10f)]
		public float reflectionFresnel;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public bool showReflection;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[Range(0f, 0.2f)]
		public float reflectionRefraction;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Range(0.01f, 10f)]
		public float waveSpeed;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[Range(0f, 1f)]
		public float waveStrength;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Range(-1f, 1f)]
		public Vector4 waveDirectionXZ;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool enableSecondaryWaves;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public Texture2D customIntersection;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public Texture2D customNormal;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public Texture2D customHeightmap;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public string[] intersectionStyleNames;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public int intersectionStyle;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public string[] waveStyleNames;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public int waveStyle;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public string[] waveHeightmapNames;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public int waveHeightmapStyle;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public float waveSize;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public bool useCustomIntersection;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x191")]
		public bool useCustomNormals;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x192")]
		public bool useCustomHeightmap;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public Texture2D normals;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public Texture2D shadermap;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public Texture2D colorGradientTex;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public bool useCompression;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool EnableReflections;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Camera reflectionCamera;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Camera refractCamera;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useReflection;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useRefractionCam;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool enableReflectionBlur;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		[Range(1f, 15f)]
		public float reflectionBlurLength;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[Range(1f, 4f)]
		public int reflectionBlurPasses;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private StylizedWaterBlur reflectionBlurRenderer;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public string[] refractionSolverNames;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public int refractionSolver;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public string[] resolutionNames;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public int reflectionRes;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		public int refractRes;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public int reflectionTextureSize;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		public int refractTextureSize;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		[Range(0f, 10f)]
		public float clipPlaneOffset;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		public LayerMask reflectLayers;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public LayerMask refractLayers;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private Dictionary<Camera, StylizedWaterBlur> m_BlurRenderers;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Dictionary<Camera, Camera> m_RefractCameras;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private RenderTexture m_RefractTexture;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		private int m_OldRefractTextureSize;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private bool s_InsideRendering;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		public int lightingMethod;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public string[] lightingMethodNames;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		public bool enableShadows;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private StylizedWaterShadowCaster shadowRenderer;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		public Light shadowCaster;

		[NonSerialized]
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private MeshRenderer meshRenderer;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public Material material;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		public bool isMobileAdvanced;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x281")]
		public bool isMobilePlatform;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public string shaderName;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		public bool isWaterLayer;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x291")]
		public bool hasShaderParams;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x292")]
		public bool hasMaterial;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x293")]
		public bool usingSinglePassRendering;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		public bool hideMeshRenderer;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x857724", Offset = "0x857724", VA = "0x857724")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x857838", Offset = "0x857838", VA = "0x857838")]
		public void Init()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x8577B0", Offset = "0x8577B0", VA = "0x8577B0")]
		public void GetProperties()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x85783C", Offset = "0x85783C", VA = "0x85783C")]
		private void GetShaderProperties()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x85826C", Offset = "0x85826C", VA = "0x85826C")]
		private void GetShaderType()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x858270", Offset = "0x858270", VA = "0x858270")]
		private void SetShaderType()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x8577B4", Offset = "0x8577B4", VA = "0x8577B4")]
		public void SetProperties()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x8584F4", Offset = "0x8584F4", VA = "0x8584F4")]
		private void SetShaderProperties()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x8591D8", Offset = "0x8591D8", VA = "0x8591D8")]
		public void DisableReflectionCam()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x858FDC", Offset = "0x858FDC", VA = "0x858FDC")]
		public void DisableRefractionCam()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x858274", Offset = "0x858274", VA = "0x858274")]
		private void EnableShadowRendering()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x85833C", Offset = "0x85833C", VA = "0x85833C")]
		private void DisableShadowRendering()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x859440", Offset = "0x859440", VA = "0x859440")]
		public void SetVegetationStudioWaterLevel()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x859444", Offset = "0x859444", VA = "0x859444")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x85AA24", Offset = "0x85AA24", VA = "0x85AA24")]
		public void CreateReflectionTexture()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x85AB50", Offset = "0x85AB50", VA = "0x85AB50")]
		public void CreateRefractionTexture()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x859B30", Offset = "0x859B30", VA = "0x859B30")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractCamera)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x85ACE0", Offset = "0x85ACE0", VA = "0x85ACE0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x85AD7C", Offset = "0x85AD7C", VA = "0x85AD7C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x85AD80", Offset = "0x85AD80", VA = "0x85AD80")]
		public StylizedWater()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class StylizedWaterBlur : MonoBehaviour
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float length;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int passes;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Shader m_BlurRenderShader;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material m_BlurRenderMat;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CommandBuffer cmd;

		[Token(Token = "0x17000028")]
		private static Shader BlurRenderShader
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x85AEE0", Offset = "0x85AEE0", VA = "0x85AEE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private static Material BlurRenderMat
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x85AF98", Offset = "0x85AF98", VA = "0x85AF98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x85B080", Offset = "0x85B080", VA = "0x85B080")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x85B10C", Offset = "0x85B10C", VA = "0x85B10C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x85A5FC", Offset = "0x85A5FC", VA = "0x85A5FC")]
		public void Render()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x85B1A8", Offset = "0x85B1A8", VA = "0x85B1A8")]
		public StylizedWaterBlur()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[RequireComponent(typeof(Light))]
	[ExecuteInEditMode]
	public class StylizedWaterShadowCaster : MonoBehaviour
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CommandBuffer cmd;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Light dirLight;

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x85B1BC", Offset = "0x85B1BC", VA = "0x85B1BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x85B368", Offset = "0x85B368", VA = "0x85B368")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x85B3E8", Offset = "0x85B3E8", VA = "0x85B3E8")]
		public StylizedWaterShadowCaster()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public static class StylizedWaterUtilities
	{
		[Token(Token = "0x2000042")]
		public static class CameraUtils
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x85A454", Offset = "0x85A454", VA = "0x85A454")]
			public static Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign, float clipPlaneOffset)
			{
				return default(Vector4);
			}

			[Token(Token = "0x600015C")]
			[Address(RVA = "0x85A3C0", Offset = "0x85A3C0", VA = "0x85A3C0")]
			public static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
			{
			}

			[Token(Token = "0x600015D")]
			[Address(RVA = "0x85A238", Offset = "0x85A238", VA = "0x85A238")]
			public static void CopyCameraSettings(Camera src, Camera dest)
			{
			}
		}

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DEBUG;

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x85B3F0", Offset = "0x85B3F0", VA = "0x85B3F0")]
		public static string[] ComposeDropdown(Texture2D[] resource, string replaceFilter)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x85B610", Offset = "0x85B610", VA = "0x85B610")]
		public static bool IsApproximatelyEqual(float a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x85B628", Offset = "0x85B628", VA = "0x85B628")]
		public static bool HasVertexColors(Mesh mesh)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000043")]
	public class OrbitCamera : MonoBehaviour
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Stylized Water Demo")]
		[Space]
		public Transform pivot;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Space]
		public bool enableMouse;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float idleRotationSpeed;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform cam;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float cameraRotSide;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float cameraRotUp;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float cameraRotSideCur;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float cameraRotUpCur;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float distance;

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x85B7C0", Offset = "0x85B7C0", VA = "0x85B7C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x85B874", Offset = "0x85B874", VA = "0x85B874")]
		private void Update()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x85BC48", Offset = "0x85BC48", VA = "0x85BC48")]
		public OrbitCamera()
		{
		}
	}
}
namespace LPS
{
	[Token(Token = "0x2000044")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[SelectionBase]
	public class LPS_ConfigureHouse : MonoBehaviour
	{
		[Token(Token = "0x2000045")]
		public enum HouseType
		{
			[Token(Token = "0x40001B0")]
			House1,
			[Token(Token = "0x40001B1")]
			House2,
			[Token(Token = "0x40001B2")]
			House3
		}

		[Token(Token = "0x2000046")]
		public enum HouseMode
		{
			[Token(Token = "0x40001B4")]
			WithInteriour,
			[Token(Token = "0x40001B5")]
			ExteriourOnly
		}

		[Token(Token = "0x2000047")]
		public enum HouseRoofColor
		{
			[Token(Token = "0x40001B7")]
			Wood,
			[Token(Token = "0x40001B8")]
			Red,
			[Token(Token = "0x40001B9")]
			Blue,
			[Token(Token = "0x40001BA")]
			Grey
		}

		[Token(Token = "0x2000048")]
		public enum HouseRoofType
		{
			[Token(Token = "0x40001BC")]
			Tiles,
			[Token(Token = "0x40001BD")]
			Planks
		}

		[Token(Token = "0x2000049")]
		public enum ChimneyType
		{
			[Token(Token = "0x40001BF")]
			None,
			[Token(Token = "0x40001C0")]
			Left,
			[Token(Token = "0x40001C1")]
			Right,
			[Token(Token = "0x40001C2")]
			Both
		}

		[Token(Token = "0x200004A")]
		public enum CornerstoneType
		{
			[Token(Token = "0x40001C4")]
			None,
			[Token(Token = "0x40001C5")]
			Bottom,
			[Token(Token = "0x40001C6")]
			BottomAndTop
		}

		[Token(Token = "0x200004B")]
		public enum TopWindowType
		{
			[Token(Token = "0x40001C8")]
			None,
			[Token(Token = "0x40001C9")]
			Left,
			[Token(Token = "0x40001CA")]
			Right,
			[Token(Token = "0x40001CB")]
			Both
		}

		[Token(Token = "0x200004C")]
		public enum PergolaType
		{
			[Token(Token = "0x40001CD")]
			None,
			[Token(Token = "0x40001CE")]
			Mini,
			[Token(Token = "0x40001CF")]
			Small,
			[Token(Token = "0x40001D0")]
			Large
		}

		[Token(Token = "0x200004D")]
		public enum IvyType
		{
			[Token(Token = "0x40001D2")]
			None,
			[Token(Token = "0x40001D3")]
			Left,
			[Token(Token = "0x40001D4")]
			Right,
			[Token(Token = "0x40001D5")]
			Both
		}

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HousePartPosition ChimneyPosition_Right_House1;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly HousePartPosition ChimneyPosition_Left_House1;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly HousePartPosition TopWindowPosition_Right_House1;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static readonly HousePartPosition TopWindowPosition_Left_House1;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static readonly HousePartPosition SmallRoofTop_Right_House1;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public static readonly HousePartPosition SmallRoofTop_Left_House1;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static readonly HousePartPosition PergolaMini_PosRight;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public static readonly HousePartPosition PergolaMini_PosLeft;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static readonly HousePartPosition PergolaSmall_PosRight;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public static readonly HousePartPosition PergolaSmall_PosLeft;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public static readonly HousePartPosition PergolaLarge_PosRight;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public static readonly HousePartPosition PergolaLarge_PosLeft;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public static readonly HousePartPosition Door_Entrance_PosRight;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public static readonly HousePartPosition Door_Entrance_PosLeft;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public static readonly HousePartPosition Door_Interior_PosBottom;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		public static readonly HousePartPosition Door_Interior_PosTop;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		public static readonly HousePartPosition Cornerstones_PosTop;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
		public static readonly HousePartPosition Ivy_PosRight;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public static readonly HousePartPosition Ivy_PosLeft;

		[Token(Token = "0x40001A0")]
		public const float House_2_3_HeightReduction = -2.0183f;

		[Token(Token = "0x40001A1")]
		public const string CUSTOM_OBJECTS_CONTAINER_NAME = "CustomObjectContainer";

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Connection")]
		public HousePartsList HousePartsList;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("House Settings")]
		public HouseType BuildingType;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public HouseMode Mode;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Roof")]
		public HouseRoofColor RoofColor;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public HouseRoofType RoofType;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Decoration")]
		public bool UseWoodDecorationRoof;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public ChimneyType Chimney;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool ChimneySmoking;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public CornerstoneType CornerStones;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TopWindowType TopWindow;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public PergolaType PergolaLeft;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PergolaType PergolaRight;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public IvyType Ivy;

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x85BC64", Offset = "0x85BC64", VA = "0x85BC64")]
		public void RemoveAllChildren()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x85BD70", Offset = "0x85BD70", VA = "0x85BD70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x85BDE0", Offset = "0x85BDE0", VA = "0x85BDE0")]
		public LPS_ConfigureHouse()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public struct HousePartPosition
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Position;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 Euler;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Scale;

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x85C0A0", Offset = "0x85C0A0", VA = "0x85C0A0")]
		public HousePartPosition(Vector3 pos, Vector3 euler)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x85C0C0", Offset = "0x85C0C0", VA = "0x85C0C0")]
		public HousePartPosition(Vector3 pos)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x85C044", Offset = "0x85C044", VA = "0x85C044")]
		public HousePartPosition(float x, float y, float z)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x85C064", Offset = "0x85C064", VA = "0x85C064")]
		public HousePartPosition(float x, float y, float z, float eulerX, float eulerY, float eulerZ)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x85C084", Offset = "0x85C084", VA = "0x85C084")]
		public HousePartPosition(float x, float y, float z, float eulerX, float eulerY, float eulerZ, float sX, float sY, float sZ)
		{
		}
	}
}
namespace fvworks.demo
{
	[Token(Token = "0x200004F")]
	public class ClickToMove : MonoBehaviour
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float yOffset;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material marker;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject m_Tile;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GridTerrian m_GridTerrian;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material m_TileMaterial;

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x85C0E0", Offset = "0x85C0E0", VA = "0x85C0E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x85C1A8", Offset = "0x85C1A8", VA = "0x85C1A8")]
		private void Start()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x85C234", Offset = "0x85C234", VA = "0x85C234")]
		private void Update()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x85C52C", Offset = "0x85C52C", VA = "0x85C52C")]
		private void ChangeTileColor(Color color)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x85C6C4", Offset = "0x85C6C4", VA = "0x85C6C4")]
		private GameObject RaycastObject(Vector2 screenPos)
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x85C768", Offset = "0x85C768", VA = "0x85C768")]
		public ClickToMove()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class RPGCamera : MonoBehaviour
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Target;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumDistance;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float MinimumDistance;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ScrollModifier;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float TurnModifier;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_CameraTransform;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_LookAtPoint;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_LocalForwardVector;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_Distance;

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x85C778", Offset = "0x85C778", VA = "0x85C778")]
		private void Start()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x85C83C", Offset = "0x85C83C", VA = "0x85C83C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x85C864", Offset = "0x85C864", VA = "0x85C864")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x85C8E0", Offset = "0x85C8E0", VA = "0x85C8E0")]
		private void UpdateZoom()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x85C924", Offset = "0x85C924", VA = "0x85C924")]
		private void UpdatePosition()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x85C9D8", Offset = "0x85C9D8", VA = "0x85C9D8")]
		private void UpdateRotation()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x85CB94", Offset = "0x85CB94", VA = "0x85CB94")]
		public RPGCamera()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[RequireComponent(typeof(CharacterController))]
	public class RPGMovement : MonoBehaviour
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float ForwardSpeed;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float BackwardSpeed;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StrafeSpeed;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RotateSpeed;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_LastPosition;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_AnimatorSpeed;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_CurrentMovement;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_CurrentTurnSpeed;

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x85CB9C", Offset = "0x85CB9C", VA = "0x85CB9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x85CC18", Offset = "0x85CC18", VA = "0x85CC18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x85D090", Offset = "0x85D090", VA = "0x85D090")]
		private void UpdateAnimation()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x85CC60", Offset = "0x85CC60", VA = "0x85CC60")]
		private void ResetSpeedValues()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x85D018", Offset = "0x85D018", VA = "0x85D018")]
		private void ApplyGravityToCharacterController()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x85CFC8", Offset = "0x85CFC8", VA = "0x85CFC8")]
		private void MoveCharacterController()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x85CDEC", Offset = "0x85CDEC", VA = "0x85CDEC")]
		private void UpdateForwardMovement()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x85CE8C", Offset = "0x85CE8C", VA = "0x85CE8C")]
		private void UpdateBackwardMovement()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x85CF30", Offset = "0x85CF30", VA = "0x85CF30")]
		private void UpdateStrafeMovement()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x85CCB8", Offset = "0x85CCB8", VA = "0x85CCB8")]
		private void UpdateRotateMovement()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x85D3C0", Offset = "0x85D3C0", VA = "0x85D3C0")]
		public RPGMovement()
		{
		}
	}
}
namespace fvworks.elysium
{
	[Token(Token = "0x2000052")]
	public class PicoMgr : MonoBehaviour
	{
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("Recenter")]
		private InputActionReference m_Recenter;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x85D3C8", Offset = "0x85D3C8", VA = "0x85D3C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x85D4E4", Offset = "0x85D4E4", VA = "0x85D4E4")]
		private void OnRecenterPerformed(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x85D460", Offset = "0x85D460", VA = "0x85D460")]
		private InputAction GetInputAction(InputActionReference actionReference)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x85D588", Offset = "0x85D588", VA = "0x85D588")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x85D620", Offset = "0x85D620", VA = "0x85D620")]
		public PicoMgr()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class SceneMgr : MonoBehaviour
	{
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("Open Main Menu")]
		private InputActionReference m_OpenMainMenu;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mainmenu;

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x85D628", Offset = "0x85D628", VA = "0x85D628")]
		private void Start()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x85D744", Offset = "0x85D744", VA = "0x85D744")]
		private void OnOpenMainMenu(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x85D6C0", Offset = "0x85D6C0", VA = "0x85D6C0")]
		private InputAction GetInputAction(InputActionReference actionReference)
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x85D7E0", Offset = "0x85D7E0", VA = "0x85D7E0")]
		public SceneMgr()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class WorldItem : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000055")]
		public class OnWorldSelectedEvent : UnityEvent<WorldInfo>
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x85D884", Offset = "0x85D884", VA = "0x85D884")]
			public OnWorldSelectedEvent()
			{
			}
		}

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_Text worldName;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WorldInfo info;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OnWorldSelectedEvent onWorldSelectedEvent;

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x85D7E8", Offset = "0x85D7E8", VA = "0x85D7E8")]
		private void Start()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x85D7EC", Offset = "0x85D7EC", VA = "0x85D7EC")]
		private void Update()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x85D7F0", Offset = "0x85D7F0", VA = "0x85D7F0")]
		internal void SetWorldInfo(WorldInfo worldInfo)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x85D820", Offset = "0x85D820", VA = "0x85D820")]
		public void OnSelected()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x85D87C", Offset = "0x85D87C", VA = "0x85D87C")]
		public WorldItem()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class WorldListDisplayer : MonoBehaviour
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int page;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Launcher launcher;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<WorldInfo> worldList;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WorldItem[] worldItems;

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x85D8CC", Offset = "0x85D8CC", VA = "0x85D8CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x85D934", Offset = "0x85D934", VA = "0x85D934")]
		private void Start()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x85DA74", Offset = "0x85DA74", VA = "0x85DA74")]
		public void AddPage(int number)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x85D938", Offset = "0x85D938", VA = "0x85D938")]
		public void RefreshWorldList()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x85DA88", Offset = "0x85DA88", VA = "0x85DA88")]
		public void SetCurrentWorld(WorldInfo world)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x85DAA4", Offset = "0x85DAA4", VA = "0x85DAA4")]
		public WorldListDisplayer()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class AIBrain : MonoBehaviour
	{
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<fvworks.elysium.AI.Action> m_AvailableActions;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Goal> m_AvailableGoals;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private fvworks.elysium.AI.Action m_Fallback;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_MinPlanInterval;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GoalPriorityCheckInterval;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Queue<fvworks.elysium.AI.Action> m_ActionQueue;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Planner m_Planner;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Goal m_CurrentGoal;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_LastPlanTime;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_LastGoalPriorityCheckTime;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private StateData m_WorldState;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AISettings m_Settings;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private NavMeshAgent m_NavMeshAgent;

		[Token(Token = "0x1700002A")]
		public StateData WorldState
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x85DAAC", Offset = "0x85DAAC", VA = "0x85DAAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public AISettings Settings
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x85DAB4", Offset = "0x85DAB4", VA = "0x85DAB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public NavMeshAgent Agent
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x85DABC", Offset = "0x85DABC", VA = "0x85DABC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x85DAC4", Offset = "0x85DAC4", VA = "0x85DAC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x85DCA8", Offset = "0x85DCA8", VA = "0x85DCA8")]
		private void Start()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x85E0C0", Offset = "0x85E0C0", VA = "0x85E0C0")]
		private void Update()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x85E608", Offset = "0x85E608", VA = "0x85E608")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x85DEDC", Offset = "0x85DEDC", VA = "0x85DEDC")]
		private void Init()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x85E520", Offset = "0x85E520", VA = "0x85E520")]
		private void Replan()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x85E348", Offset = "0x85E348", VA = "0x85E348")]
		private bool IsReplanNeeded()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x85EA80", Offset = "0x85EA80", VA = "0x85EA80")]
		private void Fallback()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x85EBD8", Offset = "0x85EBD8", VA = "0x85EBD8")]
		public NavMeshAgent GetAgent()
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x85EC20", Offset = "0x85EC20", VA = "0x85EC20")]
		public AIBrain()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class AIGroups : MonoBehaviour
	{
		[Token(Token = "0x2000059")]
		public enum SpawnMode
		{
			[Token(Token = "0x4000218")]
			AtNight,
			[Token(Token = "0x4000219")]
			AtDaytime,
			[Token(Token = "0x400021A")]
			AllDay
		}

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color m_GroupColor;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Space]
		private bool m_EnableSpawning;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool m_MakeAgentsChildren;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] m_Prefabs;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Space]
		[SerializeField]
		private float m_GroupRadius;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int m_MaxCount;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Space]
		private SpawnMode m_SpawnMode;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_SpawnInterval;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_MaxSpawnDistance;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool m_IsFirstTime;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_LastUpdateTime;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Vector3> m_SpawnPoints;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<EntityEventHandler> m_AliveAgents;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform m_Player;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject mainCamera;

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x85EC28", Offset = "0x85EC28", VA = "0x85EC28")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x85EC2C", Offset = "0x85EC2C", VA = "0x85EC2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x85F290", Offset = "0x85F290", VA = "0x85F290")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x85EE64", Offset = "0x85EE64", VA = "0x85EE64")]
		private void TrySpawn()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x85F3F0", Offset = "0x85F3F0", VA = "0x85F3F0")]
		private void On_AgentDeath(GameObject go)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x85F4CC", Offset = "0x85F4CC", VA = "0x85F4CC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x85F554", Offset = "0x85F554", VA = "0x85F554")]
		public AIGroups()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class AISettings : MonoBehaviour
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EntityMovement m_Movement;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EntityDetection m_Detection;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private EntityDetection m_TargetDetection;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private EntityVitals m_Vitals;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_IsHarmless;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private EntityAnimation m_Animation;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AIBrain m_Brain;

		[Token(Token = "0x1700002D")]
		public bool IsHarmless
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x85F63C", Offset = "0x85F63C", VA = "0x85F63C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x85F644", Offset = "0x85F644", VA = "0x85F644")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public EntityMovement Movement
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x85F650", Offset = "0x85F650", VA = "0x85F650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public EntityDetection Detection
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x85F658", Offset = "0x85F658", VA = "0x85F658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public EntityDetection TargetDetection
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x85F660", Offset = "0x85F660", VA = "0x85F660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public EntityAnimation Animation
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x85F668", Offset = "0x85F668", VA = "0x85F668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public EntityVitals Vitals
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x85F670", Offset = "0x85F670", VA = "0x85F670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x85F678", Offset = "0x85F678", VA = "0x85F678")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x85F7BC", Offset = "0x85F7BC", VA = "0x85F7BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x85F7C0", Offset = "0x85F7C0", VA = "0x85F7C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x85FE34", Offset = "0x85FE34", VA = "0x85FE34")]
		public AISettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class EntityAnimation
	{
		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AIBrain m_Brain;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator m_Animator;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x85F75C", Offset = "0x85F75C", VA = "0x85F75C")]
		public void Initialize(AIBrain brain)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x85FE3C", Offset = "0x85FE3C", VA = "0x85FE3C")]
		public bool ParameterExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x85FEF4", Offset = "0x85FEF4", VA = "0x85FEF4")]
		public void SetTrigger(string name)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x85FF38", Offset = "0x85FF38", VA = "0x85FF38")]
		public void ToggleBool(string name, bool value)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x85FF84", Offset = "0x85FF84", VA = "0x85FF84")]
		public bool IsBoolToggled(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x85F754", Offset = "0x85F754", VA = "0x85F754")]
		public EntityAnimation()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class EntityDetection
	{
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_ForPlayer;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float m_TargetSearchDelay;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_Eyes;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 360f)]
		private int m_ViewAngle;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int m_ViewRadius;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask m_SpotMask;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private LayerMask m_ObstacleMask;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GameObject> m_VisibleTargets;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<GameObject> m_StillInRangeTargets;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<GameObject> m_FireTargetsInRange;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform m_Transform;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_LastTargetFindTime;

		[Token(Token = "0x17000033")]
		public GameObject LastChasedTarget
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x85FFCC", Offset = "0x85FFCC", VA = "0x85FFCC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x85FFD4", Offset = "0x85FFD4", VA = "0x85FFD4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x85FFDC", Offset = "0x85FFDC", VA = "0x85FFDC")]
		public void Initialize(Transform transform)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x85FB04", Offset = "0x85FB04", VA = "0x85FB04")]
		public void Update(AIBrain brain)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x860E4C", Offset = "0x860E4C", VA = "0x860E4C")]
		public bool HasTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x860F98", Offset = "0x860F98", VA = "0x860F98")]
		public bool HasFireTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x860FE8", Offset = "0x860FE8", VA = "0x860FE8")]
		public bool HasVisibleTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x860F18", Offset = "0x860F18", VA = "0x860F18")]
		public Transform GetRandomTarget()
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x860474", Offset = "0x860474", VA = "0x860474")]
		private void GetTargetsStillInRange()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x8606E8", Offset = "0x8606E8", VA = "0x8606E8")]
		private void GetFireTargetsInRange()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x85FFE4", Offset = "0x85FFE4", VA = "0x85FFE4")]
		private List<GameObject> GetVisibleTargets()
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x861038", Offset = "0x861038", VA = "0x861038")]
		private Collider[] GetCollidersInRange()
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x86109C", Offset = "0x86109C", VA = "0x86109C")]
		public EntityDetection()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public enum AIMovementState
	{
		[Token(Token = "0x4000232")]
		Idle,
		[Token(Token = "0x4000233")]
		Walk,
		[Token(Token = "0x4000234")]
		Jump,
		[Token(Token = "0x4000235")]
		Running
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class EntityMovement
	{
		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_FlySpeed;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_GroundOffset;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 m_HeightJitterRange;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_CurrentDestination;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private AIMovementState m_MovementState;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AIBrain m_Brain;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NavMeshAgent m_Agent;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsFlying;

		[Token(Token = "0x17000034")]
		public NavMeshAgent Agent
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x86116C", Offset = "0x86116C", VA = "0x86116C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x85F748", Offset = "0x85F748", VA = "0x85F748")]
		public void Initialize(AIBrain brain)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x85F824", Offset = "0x85F824", VA = "0x85F824")]
		public void Update(Transform transform)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x8611F0", Offset = "0x8611F0", VA = "0x8611F0")]
		public void Idle()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x861498", Offset = "0x861498", VA = "0x861498")]
		public void FlyTo(Vector3 position)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x8614AC", Offset = "0x8614AC", VA = "0x8614AC")]
		public NavMeshPath MoveTo(Vector3 position, bool isUrgent = false)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x861760", Offset = "0x861760", VA = "0x861760")]
		public void RotateTowards(Transform trans, Vector3 target, float rotationSpeed)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x8618FC", Offset = "0x8618FC", VA = "0x8618FC")]
		public bool IsReachedDestination()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x861BBC", Offset = "0x861BBC", VA = "0x861BBC")]
		private Vector3 AdjustToSurface(Vector3 position)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x861D64", Offset = "0x861D64", VA = "0x861D64")]
		public EntityMovement()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class EntityVitals
	{
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float m_HungryRegenerateTime;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool m_IsHungry;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		private bool m_IsThirsty;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		private bool m_IsToxic;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_LastTimeFed;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastTimeDrink;

		[Token(Token = "0x17000035")]
		public bool IsHungry
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x861D6C", Offset = "0x861D6C", VA = "0x861D6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x861D74", Offset = "0x861D74", VA = "0x861D74")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public bool IsThirsty
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x861D80", Offset = "0x861D80", VA = "0x861D80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x861D88", Offset = "0x861D88", VA = "0x861D88")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool IsToxic
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x861D94", Offset = "0x861D94", VA = "0x861D94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x861D9C", Offset = "0x861D9C", VA = "0x861D9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public float LastTimeFed
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x861DA8", Offset = "0x861DA8", VA = "0x861DA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x861DB0", Offset = "0x861DB0", VA = "0x861DB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public float LastTimeDrink
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x861DB8", Offset = "0x861DB8", VA = "0x861DB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x861DC0", Offset = "0x861DC0", VA = "0x861DC0")]
			set
			{
			}
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x85FD5C", Offset = "0x85FD5C", VA = "0x85FD5C")]
		public void Update(AIBrain brain)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x861DC8", Offset = "0x861DC8", VA = "0x861DC8")]
		public EntityVitals()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class Genius : MonoBehaviour
	{
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Genius Instance;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float Interval;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int UserMessageLimit;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int UserMessageInterval;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int UserFindFoodHintInterval;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int UserFindWaterHintInterval;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int UserHealingHintInterval;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float MakeRaftHintInterval;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float MakeBuildingHintInterval;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool showSleepTip;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float nextUpdateTime;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameDate lastUserMessageTime;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private FrontUIPresenter frontUIAgent;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastFindFoodHintTime;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float lastFindWaterHintTime;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float lastHealingHintTime;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float lastRaftHintTime;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float lastBuildingHintTime;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<string, int> userMessageCountMap;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<string> oneTimeMessage;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool isRaftAvailable;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool isBuildingStarted;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		private bool isPlantingStarted;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string plantingKey;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string buildingKey;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string raftKey;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x861DD0", Offset = "0x861DD0", VA = "0x861DD0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x861E1C", Offset = "0x861E1C", VA = "0x861E1C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x862268", Offset = "0x862268", VA = "0x862268")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x862AF0", Offset = "0x862AF0", VA = "0x862AF0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x862D28", Offset = "0x862D28", VA = "0x862D28")]
		public void ProcessUserMessage(string messageCode)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x862868", Offset = "0x862868", VA = "0x862868")]
		public void ProcessOneTimeMessage(string msgCode, float destroyTime = 5f)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x862F0C", Offset = "0x862F0C", VA = "0x862F0C")]
		public void OnUpdatePlayerFindFood()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x8630C0", Offset = "0x8630C0", VA = "0x8630C0")]
		public void OnUpdatePlayerFindWater()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x8631BC", Offset = "0x8631BC", VA = "0x8631BC")]
		public void OnUpdatePlayerHeal()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x863278", Offset = "0x863278", VA = "0x863278")]
		public void OnInteractionMessage(InteractionEventData message)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x862E9C", Offset = "0x862E9C", VA = "0x862E9C")]
		private bool ShouldShowUserMessage()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x862A48", Offset = "0x862A48", VA = "0x862A48")]
		private bool ShouldShowRaftHint()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x8629A0", Offset = "0x8629A0", VA = "0x8629A0")]
		private bool ShouldShowBuildingHint()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x8627C4", Offset = "0x8627C4", VA = "0x8627C4")]
		private bool ShouldShowPlantingHint()
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x8625B4", Offset = "0x8625B4", VA = "0x8625B4")]
		private void UpdateResources()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x8633E0", Offset = "0x8633E0", VA = "0x8633E0")]
		private void HandleLevelUp()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x8633F4", Offset = "0x8633F4", VA = "0x8633F4")]
		private void HandleDayAdded()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x863408", Offset = "0x863408", VA = "0x863408")]
		private void HandleNightFall()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x863464", Offset = "0x863464", VA = "0x863464")]
		private void HandleWeatherChanged(WeatherState weather)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x863518", Offset = "0x863518", VA = "0x863518")]
		public Genius()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class IntentionTestScript : MonoBehaviour
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_IntentDetectionInterval;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_NextIntentDetectionTime;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_LastEngageProbility;

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x863548", Offset = "0x863548", VA = "0x863548")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x863554", Offset = "0x863554", VA = "0x863554")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x8637B0", Offset = "0x8637B0", VA = "0x8637B0")]
		public IntentionTestScript()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class IntentPerception : MonoBehaviour
	{
		[Token(Token = "0x4000263")]
		private const float m_Epsilon = 1E-06f;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static IntentPerception Instance;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MotionRationalIndex;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_GazeRationalIndex;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MaxSpeedScalar;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_MotionUpdateInterval;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_GazeReward;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_GazeThreshold;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_CutoffDistance;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_MinDistanceThreshold;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_MaxDistanceThreshold;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_EngageSpeedThreshold;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_EngageProbilityThreshold;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_LastPosition;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_LastUpdateTime;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_NextPositionUpdateTime;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform m_Player;

		[Token(Token = "0x1700003A")]
		public float EngageProbilityThreshold
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x8637C0", Offset = "0x8637C0", VA = "0x8637C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x8637C8", Offset = "0x8637C8", VA = "0x8637C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x863814", Offset = "0x863814", VA = "0x863814")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x8638A4", Offset = "0x8638A4", VA = "0x8638A4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x863658", Offset = "0x863658", VA = "0x863658")]
		public float EstimateEngageProbility(Transform target, float lastProbility)
		{
			return default(float);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x863904", Offset = "0x863904", VA = "0x863904")]
		public float EstimateEngageProbilityForMotion(Transform target)
		{
			return default(float);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x863B28", Offset = "0x863B28", VA = "0x863B28")]
		public float EstimateEngageProbilityForGaze(Transform target)
		{
			return default(float);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x863CD4", Offset = "0x863CD4", VA = "0x863CD4")]
		public IntentPerception()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class Planner
	{
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x85E79C", Offset = "0x85E79C", VA = "0x85E79C")]
		public bool Plan(List<Goal> goals, List<fvworks.elysium.AI.Action> actions, AIBrain brain, out Queue<fvworks.elysium.AI.Action> actionQueue, out Goal selected)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x863D0C", Offset = "0x863D0C", VA = "0x863D0C")]
		private void FindActionsMatchState(StateData goalState, List<fvworks.elysium.AI.Action> actions, List<fvworks.elysium.AI.Action> matched)
		{
		}

		[Token(Token = "0x6000200")]
		private void CopyList<T>(List<T> to, List<T> from)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x85DED4", Offset = "0x85DED4", VA = "0x85DED4")]
		public Planner()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class ConstStrings
	{
		[Token(Token = "0x4000274")]
		public const string IS_HUNGRY = "Is Hungry";

		[Token(Token = "0x4000275")]
		public const string IS_THIRSTY = "Is Thirsty";

		[Token(Token = "0x4000276")]
		public const string IS_HEALTHY = "Is Healthy";

		[Token(Token = "0x4000277")]
		public const string IS_TARGET_IN_SIGHT = "Is Target In Sight";

		[Token(Token = "0x4000278")]
		public const string CAN_ATTACK_TARGET = "Can Attack Target";

		[Token(Token = "0x4000279")]
		public const string IS_TARGET_DESTROYED = "Is Target Destroyed";

		[Token(Token = "0x400027A")]
		public const string IS_PLAYER_IN_SIGHT = "Is Player In Sight";

		[Token(Token = "0x400027B")]
		public const string CAN_ATTACK_PLAYER = "Can Attack Player";

		[Token(Token = "0x400027C")]
		public const string IS_PLAYER_DEAD = "Is Player Dead";

		[Token(Token = "0x400027D")]
		public const string IS_PLAYER_RESCUED = "Is Player Rescued";

		[Token(Token = "0x400027E")]
		public const string ANIMATOR_PARAM_WALK = "isWalking";

		[Token(Token = "0x400027F")]
		public const string ANIMATOR_PARAM_RUN = "isRunning";

		[Token(Token = "0x4000280")]
		public const string ANIMATOR_PARAM_ATTACK = "isAttacking";

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x864194", Offset = "0x864194", VA = "0x864194")]
		public ConstStrings()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class StateData
	{
		[Token(Token = "0x1700003B")]
		public Dictionary<string, object> m_Dictionary
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x86419C", Offset = "0x86419C", VA = "0x86419C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x8641A4", Offset = "0x8641A4", VA = "0x8641A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x85DBC0", Offset = "0x85DBC0", VA = "0x85DBC0")]
		public StateData()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x8641AC", Offset = "0x8641AC", VA = "0x8641AC")]
		public StateData(Dictionary<string, object> conditions)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x85DC40", Offset = "0x85DC40", VA = "0x85DC40")]
		public void Add(string key, object value)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x8641D4", Offset = "0x8641D4", VA = "0x8641D4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x864224", Offset = "0x864224", VA = "0x864224")]
		public static void OverrideValue(KeyValuePair<string, object> value, StateData data)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x860E9C", Offset = "0x860E9C", VA = "0x860E9C")]
		public static void OverrideValue(string key, object value, StateData data)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x8642A8", Offset = "0x8642A8", VA = "0x8642A8")]
		public static void OverrideValues(StateData overrider, StateData data)
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class DataSource : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000067")]
		public struct InteractionEventsContainer
		{
			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<InteractionEvenRecord> data;
		}

		[Serializable]
		[Token(Token = "0x2000068")]
		public struct InteractionEvenRecord
		{
			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int id;

			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string name;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string type;

			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string interactor;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int count;

			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public GameDate timestamp;

			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameDate start_at;

			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public GameDate end_at;
		}

		[Serializable]
		[Token(Token = "0x2000069")]
		public struct ExtraInfo
		{
			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string version;

			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public UserMetrics.UserMetricsJsonObj metrics;
		}

		[StructLayout(3)]
		[Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct <CreateRemoteEventRecord>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DataSource <>4__this;

			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x6000215")]
			[Address(RVA = "0x864F0C", Offset = "0x864F0C", VA = "0x864F0C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000216")]
			[Address(RVA = "0x8654D8", Offset = "0x8654D8", VA = "0x8654D8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static DataSource Instance;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_RecordUpdateInterval;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InteractionEventsContainer m_Interactions;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<PrefabName, InteractionEvenRecord> m_InteractionMap;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_LastUpdateTime;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ExtraInfo m_ExtraInfo;

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x864444", Offset = "0x864444", VA = "0x864444")]
		private void Awake()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x8645C8", Offset = "0x8645C8", VA = "0x8645C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x8646A0", Offset = "0x8646A0", VA = "0x8646A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x8646A4", Offset = "0x8646A4", VA = "0x8646A4")]
		public void OnInteractionMessage(InteractionEventData message)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x86460C", Offset = "0x86460C", VA = "0x86460C")]
		[AsyncStateMachine(typeof(<CreateRemoteEventRecord>d__13))]
		private void CreateRemoteEventRecord()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x864AA0", Offset = "0x864AA0", VA = "0x864AA0")]
		private void OnCreateEventRecord(WebRequest.Reply reply)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x864B6C", Offset = "0x864B6C", VA = "0x864B6C")]
		private string GetInterationEventsInJson()
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x864E2C", Offset = "0x864E2C", VA = "0x864E2C")]
		private string GetExtraInfoStr()
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x864EFC", Offset = "0x864EFC", VA = "0x864EFC")]
		public DataSource()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class App : MonoSingleton<App>
	{
		[Token(Token = "0x200006C")]
		public enum AppState
		{
			[Token(Token = "0x40002C8")]
			Error,
			[Token(Token = "0x40002C9")]
			FirstRunIntro,
			[Token(Token = "0x40002CA")]
			Intro,
			[Token(Token = "0x40002CB")]
			Standard,
			[Token(Token = "0x40002CC")]
			InitLoading,
			[Token(Token = "0x40002CD")]
			Loading,
			[Token(Token = "0x40002CE")]
			Saving,
			[Token(Token = "0x40002CF")]
			Uploading,
			[Token(Token = "0x40002D0")]
			AutoProfiling
		}

		[Token(Token = "0x200006D")]
		public enum Difficulty
		{
			[Token(Token = "0x40002D2")]
			Leisure,
			[Token(Token = "0x40002D3")]
			Normal,
			[Token(Token = "0x40002D4")]
			Challenge,
			[Token(Token = "0x40002D5")]
			Tutorial,
			[Token(Token = "0x40002D6")]
			Creative
		}

		[Token(Token = "0x200006E")]
		public enum AnimalMode
		{
			[Token(Token = "0x40002D8")]
			Normal,
			[Token(Token = "0x40002D9")]
			Passive,
			[Token(Token = "0x40002DA")]
			Removed
		}

		[Serializable]
		[Token(Token = "0x200006F")]
		public class AccountInfo
		{
			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int totalAccess;

			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string lastLogin;

			[Token(Token = "0x6000250")]
			[Address(RVA = "0x866904", Offset = "0x866904", VA = "0x866904")]
			public AccountInfo()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000070")]
		public class SystemSettings
		{
			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isLocomotionOn;

			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Difficulty mode;

			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int walkMode;

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int runMode;

			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool isAttackingOn;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int animalMode;

			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float vfxVolume;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int raftMode;

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x8665C8", Offset = "0x8665C8", VA = "0x8665C8")]
			public SystemSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000071")]
		public class SystemSettingsChangedEvent : UnityEvent<SystemSettings>
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x8668BC", Offset = "0x8668BC", VA = "0x8668BC")]
			public SystemSettingsChangedEvent()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct <SendLogMessageToServer>d__130 : IAsyncStateMachine
		{
			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LogType type;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public App <>4__this;

			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string msg;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x6000253")]
			[Address(RVA = "0x86690C", Offset = "0x86690C", VA = "0x86690C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000254")]
			[Address(RVA = "0x866CA4", Offset = "0x866CA4", VA = "0x866CA4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct <CheckRemoteAccount>d__131 : IAsyncStateMachine
		{
			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public App <>4__this;

			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x6000255")]
			[Address(RVA = "0x866CB0", Offset = "0x866CB0", VA = "0x866CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000256")]
			[Address(RVA = "0x867334", Offset = "0x867334", VA = "0x867334", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemSettingsChangedEvent onSystemSettingChanged;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnvironmentDB environmentDatabase;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PrefabDatabase prefabDatabase;

		[Token(Token = "0x400029A")]
		public const string kPlayerPrefHasPlayedBefore = "Has played before";

		[Token(Token = "0x400029B")]
		public const string kPlayerPrefAccountId = "RemoteAccountId";

		[Token(Token = "0x400029C")]
		public const string kSystemSettings = "SystemSettings";

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool releaseVersion;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool fullVersion;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int maxExceptionsToLog;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public string kVersion;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_NumExceptionsLogged;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private AppState m_CurrentAppState;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AppState m_DesiredAppState;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TutorialMgr m_TutorialMgr;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UserMetrics m_UserMetrics;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AccountModel m_AccountModel;

		[Token(Token = "0x40002A7")]
		private const string PREFKEY_WORLD_PREFIX = "WorldObjects_";

		[Token(Token = "0x40002A8")]
		private const string PREFKEY_WORLD_SNAPSHOT_NAME = "World_Snapshot_Name";

		[Token(Token = "0x40002A9")]
		private const string PREFKEY_WORLD_SYSTEM_SETTINGS = "SystemSettings";

		[Token(Token = "0x40002AA")]
		private const string PREFKEY_WORLD_SUBKEY_COLLECTABLE = "Collectable";

		[Token(Token = "0x40002AB")]
		private const string PREFKEY_WORLD_SUBKEY_LIFECYCLE = "LifeCycle";

		[Token(Token = "0x40002AC")]
		private const string PREFKEY_WORLD_SUBKEY_MATERIAL = "Material";

		[Token(Token = "0x40002AD")]
		private const string PREFKEY_WORLD_BUILDINGS = "World_Buildings";

		[Token(Token = "0x40002AE")]
		private const string PREFKEY_WORLD_CHESTBOXES = "World_ChestBoxes";

		[Token(Token = "0x40002AF")]
		private const string PREFKEY_WORLD_STORAGEBOXES = "World_StorageBoxes";

		[Token(Token = "0x40002B0")]
		private const string PREFKEY_USER_METRICS = "UserMetrics";

		[Token(Token = "0x40002B1")]
		private const string PREFKEY_USER_PROFILE = "Profile";

		[Token(Token = "0x40002B2")]
		private const string PREFKEY_TIME_OF_DAY = "TimeOfDay";

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool isLocomotionOn;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[HideInInspector]
		public int walkMode;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public int runMode;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[HideInInspector]
		public int raftMode;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public bool isAttackingOn;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[HideInInspector]
		public int animalMode;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public bool animalRemoved;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[HideInInspector]
		public float vfxVolume;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public bool teleportState;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		[HideInInspector]
		public bool isSleeping;

		[Token(Token = "0x1700003C")]
		public static Config Config
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x8654E4", Offset = "0x8654E4", VA = "0x8654E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public static AppState CurrentState
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x865548", Offset = "0x865548", VA = "0x865548")]
			get
			{
				return default(AppState);
			}
		}

		[Token(Token = "0x1700003E")]
		public bool IsContinued
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x865848", Offset = "0x865848", VA = "0x865848")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x865850", Offset = "0x865850", VA = "0x865850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public bool IsSceneLoaded
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x86585C", Offset = "0x86585C", VA = "0x86585C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x865864", Offset = "0x865864", VA = "0x865864")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public bool IsMultiplay
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x865870", Offset = "0x865870", VA = "0x865870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x865878", Offset = "0x865878", VA = "0x865878")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public DateTime SessionStartTime
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x865884", Offset = "0x865884", VA = "0x865884")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x86588C", Offset = "0x86588C", VA = "0x86588C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public bool HasPlayedBefore
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x865894", Offset = "0x865894", VA = "0x865894")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x86589C", Offset = "0x86589C", VA = "0x86589C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public TutorialMgr Tutorial
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x8658A8", Offset = "0x8658A8", VA = "0x8658A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public UserMetrics PlayerMetrics
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x8658B0", Offset = "0x8658B0", VA = "0x8658B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public float NormalizedTime
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x8658B8", Offset = "0x8658B8", VA = "0x8658B8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x8658C0", Offset = "0x8658C0", VA = "0x8658C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public Difficulty Mode
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x8658C8", Offset = "0x8658C8", VA = "0x8658C8")]
			[CompilerGenerated]
			get
			{
				return default(Difficulty);
			}
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x8658D0", Offset = "0x8658D0", VA = "0x8658D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public int SavingSlotIndex
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x8658D8", Offset = "0x8658D8", VA = "0x8658D8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x8658E0", Offset = "0x8658E0", VA = "0x8658E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public int AccountID
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x8654C0", Offset = "0x8654C0", VA = "0x8654C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000049")]
		public int SessionID
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x8658E8", Offset = "0x8658E8", VA = "0x8658E8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x8658F0", Offset = "0x8658F0", VA = "0x8658F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public static string Suffix
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x8658F8", Offset = "0x8658F8", VA = "0x8658F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public static string CollectablePrefKey
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x8659C4", Offset = "0x8659C4", VA = "0x8659C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public static string LifeCyclePrefKey
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x865A14", Offset = "0x865A14", VA = "0x865A14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public static string MaterialPrefKey
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x865A64", Offset = "0x865A64", VA = "0x865A64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public static string SystemSettingsPrefKey
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x865AB4", Offset = "0x865AB4", VA = "0x865AB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public static string BuildingPrefKey
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x865B04", Offset = "0x865B04", VA = "0x865B04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public static string ChestBoxPrefKey
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x865B54", Offset = "0x865B54", VA = "0x865B54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public static string StorageBoxPrefKey
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x865BA4", Offset = "0x865BA4", VA = "0x865BA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public static string UserMetricsPrefKey
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x865BF4", Offset = "0x865BF4", VA = "0x865BF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public static string UserProfilePrefKey
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x865C44", Offset = "0x865C44", VA = "0x865C44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public static string TimeOfDayPrefKey
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x865C94", Offset = "0x865C94", VA = "0x865C94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public bool IsSavingAvailable
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x865D68", Offset = "0x865D68", VA = "0x865D68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<AppState, AppState> StateChanged
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x8656E8", Offset = "0x8656E8", VA = "0x8656E8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x865798", Offset = "0x865798", VA = "0x865798")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x86561C", Offset = "0x86561C", VA = "0x86561C")]
		public void EnableAnimals(bool value)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x865CE4", Offset = "0x865CE4", VA = "0x865CE4")]
		public static string SnapshotNamePrefKey(int index)
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x865D7C", Offset = "0x865D7C", VA = "0x865D7C")]
		public string GetSnapshotName(int index)
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x865DB4", Offset = "0x865DB4", VA = "0x865DB4")]
		public void SaveSnapshotName(int index, string name)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x865DD4", Offset = "0x865DD4", VA = "0x865DD4")]
		public double GetSessionDuration()
		{
			return default(double);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x865E54", Offset = "0x865E54", VA = "0x865E54")]
		public PrefabName GetPrefabName(string tag)
		{
			return default(PrefabName);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x865E70", Offset = "0x865E70", VA = "0x865E70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x866078", Offset = "0x866078", VA = "0x866078")]
		private void Start()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x8661D0", Offset = "0x8661D0", VA = "0x8661D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x8661FC", Offset = "0x8661FC", VA = "0x8661FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x86627C", Offset = "0x86627C", VA = "0x86627C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x8662FC", Offset = "0x8662FC", VA = "0x8662FC")]
		private void LogCallback(string condition, string stackTrace, LogType type)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x8661AC", Offset = "0x8661AC", VA = "0x8661AC")]
		private void SwitchState()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x866328", Offset = "0x866328", VA = "0x866328")]
		[AsyncStateMachine(typeof(<SendLogMessageToServer>d__130))]
		private void SendLogMessageToServer(LogType type, string msg)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x866118", Offset = "0x866118", VA = "0x866118")]
		[AsyncStateMachine(typeof(<CheckRemoteAccount>d__131))]
		private void CheckRemoteAccount()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x8663D0", Offset = "0x8663D0", VA = "0x8663D0")]
		private void HandleAccountModel(WebRequest.Reply reply)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x866510", Offset = "0x866510", VA = "0x866510")]
		private void OnCreateLogRecord(WebRequest.Reply reply)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x866514", Offset = "0x866514", VA = "0x866514")]
		public void SaveSystemSettings()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x8665D0", Offset = "0x8665D0", VA = "0x8665D0")]
		public void LoadSystemSettings()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x8667E0", Offset = "0x8667E0", VA = "0x8667E0")]
		public App()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class BeltMgr : MonoBehaviour
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRDirectInteractor leftInteractor;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRRayInteractor leftRayInteractor;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public XRDirectInteractor rightInteractor;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public XRRayInteractor rightRayInteractor;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<XRBaseInteractable, InputAction> interactions;

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x867340", Offset = "0x867340", VA = "0x867340")]
		private void Start()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x8673B4", Offset = "0x8673B4", VA = "0x8673B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x8673B8", Offset = "0x8673B8", VA = "0x8673B8")]
		public bool HasItem(XRBaseInteractable item)
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x867464", Offset = "0x867464", VA = "0x867464")]
		public void RegisterItem(XRBaseInteractable item, InputAction action)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x8674CC", Offset = "0x8674CC", VA = "0x8674CC")]
		public XRBaseInteractable GetItem(InputAction action)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x867638", Offset = "0x867638", VA = "0x867638")]
		public void UnregisterItem(XRBaseInteractable interactable)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x867690", Offset = "0x867690", VA = "0x867690")]
		public BeltMgr()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class BeltSlot : MonoBehaviour
	{
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image itemImage;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip beltSound;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BeltMgr beltMgr;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private XRBaseInteractor interactor;

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x867698", Offset = "0x867698", VA = "0x867698")]
		private void Start()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x8676EC", Offset = "0x8676EC", VA = "0x8676EC")]
		private void Init()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x867850", Offset = "0x867850", VA = "0x867850")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x867F54", Offset = "0x867F54", VA = "0x867F54")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x86860C", Offset = "0x86860C", VA = "0x86860C")]
		private void Take(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x868BA4", Offset = "0x868BA4", VA = "0x868BA4")]
		private void Store(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x869118", Offset = "0x869118", VA = "0x869118")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x869010", Offset = "0x869010", VA = "0x869010")]
		private void UnRegister(InputAction action)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x868E3C", Offset = "0x868E3C", VA = "0x868E3C")]
		public bool StoreItem(PrefabName itemName, int durability)
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x8677CC", Offset = "0x8677CC", VA = "0x8677CC")]
		private StorableItemInfo GetItemInfo(PrefabName itemName)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x868A00", Offset = "0x868A00", VA = "0x868A00")]
		public void RemoveItem()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x86952C", Offset = "0x86952C", VA = "0x86952C")]
		public BeltSlot()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class AlphaPulse
	{
		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_IsLerping;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool m_PulsingAtMax;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float m_PulseMin;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_PulseMax;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LerpDuration;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_StartTime;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Color m_ToPulse;

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x869534", Offset = "0x869534", VA = "0x869534")]
		public AlphaPulse(Color tP, float min, float max)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x869588", Offset = "0x869588", VA = "0x869588")]
		public void StartPulse(float lerpDuration)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x8695F0", Offset = "0x8695F0", VA = "0x8695F0")]
		public float UpdatePulse()
		{
			return default(float);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x869674", Offset = "0x869674", VA = "0x869674")]
		private void StopPulse()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class Attachment : MonoBehaviour
	{
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x869680", Offset = "0x869680", VA = "0x869680")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x8698FC", Offset = "0x8698FC", VA = "0x8698FC")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x8699E0", Offset = "0x8699E0", VA = "0x8699E0")]
		public Attachment()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class BuildingHelpers : MonoBehaviour
	{
		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayerMask m_BuildingPieceMask;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private LayerMask m_FreePlacementMask;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayerMask m_RayPlacementMask;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LayerMask m_CollisionTestMask;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_BuildRange;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Header("Preview Pulsing Effect")]
		[SerializeField]
		private bool m_UsePulseEffect;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[SerializeField]
		private bool m_PulseWhenSnapped;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_PulseEffectDuration;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_PulseMin;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_PulseMax;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BuildingPiece m_CurrentPreviewPiece;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject m_CurrentPreview;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Socket m_LastValidSocket;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_HasSocket;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_PlacementAllowed;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Color m_PreviewColor;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_RotationOffset;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform m_Transform;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AlphaPulse m_Pulse;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string[] collisionLayers;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private LineRenderer buildingRay;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 previousPreviewPosition;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private XRBaseInteractor baseInteractor;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GameObject m_CurrentPrefab;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float raycastPreviewRange;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject sphere;

		[Token(Token = "0x17000056")]
		public BuildingPiece CurrentPreviewPiece
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x8699E8", Offset = "0x8699E8", VA = "0x8699E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public bool HasSocket
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x8699F0", Offset = "0x8699F0", VA = "0x8699F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x8699F8", Offset = "0x8699F8", VA = "0x8699F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public bool PlacementAllowed
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x869A04", Offset = "0x869A04", VA = "0x869A04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		public Color PreviewColor
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x869A0C", Offset = "0x869A0C", VA = "0x869A0C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x869A18", Offset = "0x869A18", VA = "0x869A18")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public float RotationOffset
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x869A24", Offset = "0x869A24", VA = "0x869A24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x869A2C", Offset = "0x869A2C", VA = "0x869A2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public GameObject CurrentPrefab
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x869A34", Offset = "0x869A34", VA = "0x869A34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x869A3C", Offset = "0x869A3C", VA = "0x869A3C")]
		private void Start()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x869B48", Offset = "0x869B48", VA = "0x869B48")]
		private void Update()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x86A120", Offset = "0x86A120", VA = "0x86A120")]
		public void SetCurrentInteractor(XRBaseInteractor interactor)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x86A128", Offset = "0x86A128", VA = "0x86A128")]
		public void UpdatePreview(BuildingPiece buildingPiece)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x86A534", Offset = "0x86A534", VA = "0x86A534")]
		private void ShowBuildingIndicator(Vector3 from, Vector3 to)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x869AC0", Offset = "0x869AC0", VA = "0x869AC0")]
		private void HideBuildingIndicator()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x86A660", Offset = "0x86A660", VA = "0x86A660")]
		private void ResetDefaultPreview()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x869EF0", Offset = "0x869EF0", VA = "0x869EF0")]
		public void ManagePreview()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x86AE98", Offset = "0x86AE98", VA = "0x86AE98")]
		public bool HandlePlace(BuildingPiece piece, bool continuous)
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x86BC2C", Offset = "0x86BC2C", VA = "0x86BC2C")]
		private void ClearHandPiece()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x86A70C", Offset = "0x86A70C", VA = "0x86A70C")]
		private void ManageCollision()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x86C1C8", Offset = "0x86C1C8", VA = "0x86C1C8")]
		private void UpdatePreviewColor()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x86AE4C", Offset = "0x86AE4C", VA = "0x86AE4C")]
		private void ApplyPulse()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x869BE4", Offset = "0x869BE4", VA = "0x869BE4")]
		public void LookForSnaps()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x86C3FC", Offset = "0x86C3FC", VA = "0x86C3FC")]
		private void HandleSnapPreview(Collider[] buildingPieces)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x86A3C8", Offset = "0x86A3C8", VA = "0x86A3C8")]
		public void SpawnPreview(GameObject prefab)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x86B044", Offset = "0x86B044", VA = "0x86B044")]
		public void PlacePiece()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x86DA80", Offset = "0x86DA80", VA = "0x86DA80")]
		private bool IntersectsSocket(Ray ray, Socket socket)
		{
			return default(bool);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x86A324", Offset = "0x86A324", VA = "0x86A324")]
		public void ClearPreview()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x869B84", Offset = "0x869B84", VA = "0x869B84")]
		public bool PreviewExists()
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x86DB4C", Offset = "0x86DB4C", VA = "0x86DB4C")]
		public BuildingHelpers()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class BuildingHolder : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200007A")]
		public struct BuildingInfo
		{
			[Serializable]
			[Token(Token = "0x200007B")]
			public struct PieceInfo
			{
				[Token(Token = "0x4000325")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int pieceName;

				[Token(Token = "0x4000326")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public Vector3 position;

				[Token(Token = "0x4000327")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Quaternion rotation;

				[Token(Token = "0x4000328")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public List<SocketInfo> sockets;

				[Token(Token = "0x4000329")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string UID;

				[Token(Token = "0x400032A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string lastAttached;
			}

			[Serializable]
			[Token(Token = "0x200007C")]
			public struct SocketInfo
			{
				[Token(Token = "0x400032B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string socketName;

				[Token(Token = "0x400032C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public List<int> occupiedSpaces;

				[Token(Token = "0x400032D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public List<OccupierInfo> occupiers;
			}

			[Serializable]
			[Token(Token = "0x200007D")]
			public struct OccupierInfo
			{
				[Token(Token = "0x400032E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int occupiedSpace;

				[Token(Token = "0x400032F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string occupierUID;
			}

			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isRaftBoat;

			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<PieceInfo> pieces;
		}

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsRaftBoat;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<BuildingPiece> m_Pieces;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Camera mainCamera;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hidden;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float cullingDistance;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] boundaryPoints;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 center;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float radius;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, BuildingPiece> m_PieceDict;

		[Token(Token = "0x1700005C")]
		public List<BuildingPiece> Pieces
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x86DB84", Offset = "0x86DB84", VA = "0x86DB84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x86DB8C", Offset = "0x86DB8C", VA = "0x86DB8C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x86DB90", Offset = "0x86DB90", VA = "0x86DB90")]
		public bool HasCollider(Collider col)
		{
			return default(bool);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x86D1F8", Offset = "0x86D1F8", VA = "0x86D1F8")]
		public void AddPiece(BuildingPiece piece)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x86DC38", Offset = "0x86DC38", VA = "0x86DC38")]
		public BuildingPiece GetPieceByUid(string uid)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x86DCCC", Offset = "0x86DCCC", VA = "0x86DCCC")]
		private void CaculateBoundary(BuildingPiece piece)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x86E2B0", Offset = "0x86E2B0", VA = "0x86E2B0")]
		public string Serialize()
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x86ECAC", Offset = "0x86ECAC", VA = "0x86ECAC")]
		private void OnPieceDeath(GameObject go)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x86F114", Offset = "0x86F114", VA = "0x86F114")]
		private float GetDistance(Vector3 camPos)
		{
			return default(float);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x86F1A8", Offset = "0x86F1A8", VA = "0x86F1A8")]
		private void EnablePieces(bool enable)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x86F270", Offset = "0x86F270", VA = "0x86F270")]
		public BuildingHolder()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public enum BuildingSpace
	{
		[Token(Token = "0x4000331")]
		None = 0,
		[Token(Token = "0x4000332")]
		Foundation = 1,
		[Token(Token = "0x4000333")]
		Pillar = 2,
		[Token(Token = "0x4000334")]
		Wall = 5,
		[Token(Token = "0x4000335")]
		Floor = 10,
		[Token(Token = "0x4000336")]
		Roof = 15,
		[Token(Token = "0x4000337")]
		OuterStairs = 20,
		[Token(Token = "0x4000338")]
		InnerStairs = 25,
		[Token(Token = "0x4000339")]
		Door = 30,
		[Token(Token = "0x400033A")]
		Window = 35
	}
	[Token(Token = "0x200007F")]
	public enum PieceState
	{
		[Token(Token = "0x400033C")]
		Preview,
		[Token(Token = "0x400033D")]
		Placed
	}
	[Token(Token = "0x2000080")]
	public class BuildingPiece : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000081")]
		public class PlacedEvent : UnityEvent
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x871478", Offset = "0x871478", VA = "0x871478")]
			public PlacedEvent()
			{
			}
		}

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlacedEvent OnPlaced;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string enabledLayer;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int experienceValue;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private PrefabName m_PieceName;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector3 m_RotationAxis;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Header("Setup")]
		[SerializeField]
		private bool m_ShowBounds;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Bounds m_Bounds;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Tooltip("If left empty, it will automatically get populated with the first MeshFilter found.")]
		private MeshFilter m_MainMesh;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Renderer> m_IgnoredRenderers;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<Collider> m_IgnoredColliders;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Placing")]
		[SerializeField]
		private BuildingSpace m_NeededSpace;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BuildingSpace[] m_SpacesToOccupy;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool m_RequiresSockets;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float m_OutOfGroundHeight;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool m_AllowUnderTerrainMovement;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		[Header("Stability")]
		[SerializeField]
		private bool m_CheckStability;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[Space]
		[SerializeField]
		private LayerMask m_StabilityCheckMask;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private bool m_ShowStabilityBox;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Bounds[] m_StabilityBoxes;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Header("Terrain Protection")]
		[SerializeField]
		private bool m_EnableTP;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		[SerializeField]
		private bool m_ShowTP;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private Bounds m_TPBox;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Header("Sound And Effects")]
		[SerializeField]
		private AudioClip buildSound;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject m_PlacementFX;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Header("Preview")]
		[SerializeField]
		private Material m_PreviewMat;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Dictionary<Renderer, Material[]> m_InitialMaterials;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Socket[] m_Sockets;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private PieceState m_State;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<Collider> m_Colliders;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private List<Renderer> m_Renderers;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<BuildingPiece> m_AttachedOnPieces;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool m_Initialized;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private XRBaseInteractable m_Interactable;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float remoteControllDistance;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private bool isPlacing;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private string uid;

		[Token(Token = "0x1700005D")]
		public PieceState State
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x86F338", Offset = "0x86F338", VA = "0x86F338")]
			get
			{
				return default(PieceState);
			}
		}

		[Token(Token = "0x1700005E")]
		public BuildingHolder Building
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x86F340", Offset = "0x86F340", VA = "0x86F340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x86F348", Offset = "0x86F348", VA = "0x86F348")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public BuildingPiece AttachedOn
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x86F350", Offset = "0x86F350", VA = "0x86F350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x86F358", Offset = "0x86F358", VA = "0x86F358")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public PrefabName Name
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x86F360", Offset = "0x86F360", VA = "0x86F360")]
			get
			{
				return default(PrefabName);
			}
		}

		[Token(Token = "0x17000061")]
		public Vector3 RotationAxis
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x86F368", Offset = "0x86F368", VA = "0x86F368")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000062")]
		public BuildingSpace NeededSpace
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x86F374", Offset = "0x86F374", VA = "0x86F374")]
			get
			{
				return default(BuildingSpace);
			}
		}

		[Token(Token = "0x17000063")]
		public BuildingSpace[] SpacesToOccupy
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x86F37C", Offset = "0x86F37C", VA = "0x86F37C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public float OutOfGroundHeight
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x86F384", Offset = "0x86F384", VA = "0x86F384")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000065")]
		public bool AllowUnderTerrainMovement
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x86F38C", Offset = "0x86F38C", VA = "0x86F38C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		public bool RequiresSockets
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x86F394", Offset = "0x86F394", VA = "0x86F394")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		public GameObject PlacementFX
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x86F39C", Offset = "0x86F39C", VA = "0x86F39C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public Bounds Bounds
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x86BCD4", Offset = "0x86BCD4", VA = "0x86BCD4")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000069")]
		public List<Renderer> Renderers
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x86F3A4", Offset = "0x86F3A4", VA = "0x86F3A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public MeshFilter MainMesh
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x86F3AC", Offset = "0x86F3AC", VA = "0x86F3AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public Socket[] Sockets
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x86F3B4", Offset = "0x86F3B4", VA = "0x86F3B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public bool TerrainProtection
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x86F3BC", Offset = "0x86F3BC", VA = "0x86F3BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public string Uid
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x86F3C4", Offset = "0x86F3C4", VA = "0x86F3C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x86F3CC", Offset = "0x86F3CC", VA = "0x86F3CC")]
			set
			{
			}
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x86F3D4", Offset = "0x86F3D4", VA = "0x86F3D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x86F7D4", Offset = "0x86F7D4", VA = "0x86F7D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x86F8D4", Offset = "0x86F8D4", VA = "0x86F8D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x86FC3C", Offset = "0x86FC3C", VA = "0x86FC3C")]
		public void SetPlaced()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x86C9B8", Offset = "0x86C9B8", VA = "0x86C9B8")]
		public void SetState(PieceState state)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x86F92C", Offset = "0x86F92C", VA = "0x86F92C")]
		private void On_SocketDeath(GameObject dead)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x870354", Offset = "0x870354", VA = "0x870354")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x87022C", Offset = "0x87022C", VA = "0x87022C")]
		private void SetMaterials(Material material)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x8700BC", Offset = "0x8700BC", VA = "0x8700BC")]
		private void SetMaterials(Dictionary<Renderer, Material[]> materials)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x86BE74", Offset = "0x86BE74", VA = "0x86BE74")]
		public bool IsOnTerrain()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x86BD94", Offset = "0x86BD94", VA = "0x86BD94")]
		public bool HasCollider(Collider col)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x86D3CC", Offset = "0x86D3CC", VA = "0x86D3CC")]
		public bool HasSupport(out Collider[] colliders)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x870358", Offset = "0x870358", VA = "0x870358")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x8708DC", Offset = "0x8708DC", VA = "0x8708DC")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x870A9C", Offset = "0x870A9C", VA = "0x870A9C")]
		private void OnSelectExited(SelectExitEventArgs arg0)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x86D124", Offset = "0x86D124", VA = "0x86D124")]
		public void AddAttachedOn(BuildingPiece piece)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x86A1E8", Offset = "0x86A1E8", VA = "0x86A1E8")]
		public void PutObjectBack()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x86D084", Offset = "0x86D084", VA = "0x86D084")]
		public void EnableRendering(bool enabled)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x870C30", Offset = "0x870C30", VA = "0x870C30")]
		private void OnSelectEntered(SelectEnterEventArgs arg0)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x870D6C", Offset = "0x870D6C", VA = "0x870D6C")]
		private void OnActivated(ActivateEventArgs arg0)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x8710BC", Offset = "0x8710BC", VA = "0x8710BC")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x8711E0", Offset = "0x8711E0", VA = "0x8711E0")]
		public BuildingPiece()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class Roof : MonoBehaviour
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x871480", Offset = "0x871480", VA = "0x871480")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x871580", Offset = "0x871580", VA = "0x871580")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x871680", Offset = "0x871680", VA = "0x871680")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x871784", Offset = "0x871784", VA = "0x871784")]
		public Roof()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class Socket : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000084")]
		public class PieceOffset
		{
			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private BuildingPiece m_Piece;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Vector3 m_PositionOffset;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[SerializeField]
			private Vector3 m_RotationOffset;

			[Token(Token = "0x17000073")]
			public BuildingPiece Piece
			{
				[Token(Token = "0x60002DD")]
				[Address(RVA = "0x872F14", Offset = "0x872F14", VA = "0x872F14")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002DE")]
				[Address(RVA = "0x872F1C", Offset = "0x872F1C", VA = "0x872F1C")]
				set
				{
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 PositionOffset
			{
				[Token(Token = "0x60002DF")]
				[Address(RVA = "0x872F24", Offset = "0x872F24", VA = "0x872F24")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60002E0")]
				[Address(RVA = "0x872F30", Offset = "0x872F30", VA = "0x872F30")]
				set
				{
				}
			}

			[Token(Token = "0x17000075")]
			public Quaternion RotationOffset
			{
				[Token(Token = "0x60002E1")]
				[Address(RVA = "0x872F3C", Offset = "0x872F3C", VA = "0x872F3C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 RotationOffsetEuler
			{
				[Token(Token = "0x60002E2")]
				[Address(RVA = "0x872F60", Offset = "0x872F60", VA = "0x872F60")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60002E3")]
				[Address(RVA = "0x872F6C", Offset = "0x872F6C", VA = "0x872F6C")]
				set
				{
				}
			}

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x872F78", Offset = "0x872F78", VA = "0x872F78")]
			public PieceOffset GetMemberwiseClone()
			{
				return null;
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x872FF8", Offset = "0x872FF8", VA = "0x872FF8")]
			public PieceOffset()
			{
			}
		}

		[Token(Token = "0x2000085")]
		public class SpaceOccupier
		{
			[Token(Token = "0x17000077")]
			public BuildingSpace OccupiedSpace
			{
				[Token(Token = "0x60002E6")]
				[Address(RVA = "0x873058", Offset = "0x873058", VA = "0x873058")]
				[CompilerGenerated]
				get
				{
					return default(BuildingSpace);
				}
				[Token(Token = "0x60002E7")]
				[Address(RVA = "0x873060", Offset = "0x873060", VA = "0x873060")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public string OccupierID
			{
				[Token(Token = "0x60002E8")]
				[Address(RVA = "0x873068", Offset = "0x873068", VA = "0x873068")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60002E9")]
				[Address(RVA = "0x873070", Offset = "0x873070", VA = "0x873070")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x873078", Offset = "0x873078", VA = "0x873078")]
			public SpaceOccupier(BuildingSpace occupiedSpace, string occupierUID)
			{
			}
		}

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<PieceOffset> m_PieceOffsets;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Radius;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BuildingPiece m_Piece;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<BuildingSpace> m_OccupiedSpaces;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<SpaceOccupier> m_Occupiers;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<SpaceOccupier> temp_Occupiers;

		[Token(Token = "0x1700006E")]
		public List<BuildingSpace> OccupiedSpaces
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x87178C", Offset = "0x87178C", VA = "0x87178C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public BuildingPiece Piece
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x871794", Offset = "0x871794", VA = "0x871794")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public List<PieceOffset> PieceOffsets
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x87179C", Offset = "0x87179C", VA = "0x87179C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x8717A4", Offset = "0x8717A4", VA = "0x8717A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public float Radius
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x8717AC", Offset = "0x8717AC", VA = "0x8717AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x8717B4", Offset = "0x8717B4", VA = "0x8717B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public List<SpaceOccupier> Occupiers
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x8717BC", Offset = "0x8717BC", VA = "0x8717BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x8717C4", Offset = "0x8717C4", VA = "0x8717C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x86EEF0", Offset = "0x86EEF0", VA = "0x86EEF0")]
		public void OnPieceDeath(BuildingPiece piece)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x86C858", Offset = "0x86C858", VA = "0x86C858")]
		public bool GetPieceOffsetByName(PrefabName name, out PieceOffset offset)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x871868", Offset = "0x871868", VA = "0x871868")]
		public bool HasSpace(LayerMask mask, BuildingPiece placedPiece)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x8719D0", Offset = "0x8719D0", VA = "0x8719D0")]
		public void OccupySpaces(BuildingSpace[] spacesToOccupy, string pieceUID)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x871A44", Offset = "0x871A44", VA = "0x871A44")]
		public void OccupySpace(BuildingSpace spaceToOccupy, string pieceUID)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x86D6D4", Offset = "0x86D6D4", VA = "0x86D6D4")]
		public void OccupyNeighbours(LayerMask freePlacementMask, LayerMask buildingMask, BuildingPiece placedPiece)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x86C1EC", Offset = "0x86C1EC", VA = "0x86C1EC")]
		public bool SupportsPiece(BuildingPiece piece)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x871BD0", Offset = "0x871BD0", VA = "0x871BD0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x871DD8", Offset = "0x871DD8", VA = "0x871DD8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x871E28", Offset = "0x871E28", VA = "0x871E28")]
		public Socket()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class Bullet : MonoBehaviour
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int damage;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody rb;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TrailRenderer trail;

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x8730A8", Offset = "0x8730A8", VA = "0x8730A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x8730AC", Offset = "0x8730AC", VA = "0x8730AC")]
		public void SetLaunch(float power)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x87311C", Offset = "0x87311C", VA = "0x87311C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x873244", Offset = "0x873244", VA = "0x873244")]
		public Bullet()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public enum CollectableItemType
	{
		[Token(Token = "0x4000373")]
		Plant,
		[Token(Token = "0x4000374")]
		Puzzle,
		[Token(Token = "0x4000375")]
		Reward,
		[Token(Token = "0x4000376")]
		None
	}
	[Token(Token = "0x2000088")]
	public class CollectableInfo
	{
		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CollectableItemType m_Type;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private PrefabName m_Name;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform m_Prefab;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DateTime m_CreationTime;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_Position;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion m_Rotation;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_Scale;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isCollected;

		[Token(Token = "0x17000079")]
		public CollectableItemType Type
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x873254", Offset = "0x873254", VA = "0x873254")]
			get
			{
				return default(CollectableItemType);
			}
		}

		[Token(Token = "0x1700007A")]
		public PrefabName Name
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x87325C", Offset = "0x87325C", VA = "0x87325C")]
			get
			{
				return default(PrefabName);
			}
		}

		[Token(Token = "0x1700007B")]
		public Transform Prefab
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x873264", Offset = "0x873264", VA = "0x873264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x87326C", Offset = "0x87326C", VA = "0x87326C")]
		public CollectableInfo(CollectableItemType type, PrefabName name, Transform obj, Transform tr)
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class PuzzleInfo
	{
		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<CollectableInfo> m_Fragments;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int TotalNumOfFragments;

		[Token(Token = "0x1700007C")]
		public int NumOfFragments
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x873344", Offset = "0x873344", VA = "0x873344")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007D")]
		public List<CollectableInfo> AllFragments
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x873434", Offset = "0x873434", VA = "0x873434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x87338C", Offset = "0x87338C", VA = "0x87338C")]
		public void AddFragment(CollectableInfo collectable)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x87343C", Offset = "0x87343C", VA = "0x87343C")]
		public PuzzleInfo()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class CollectableDatabase
	{
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<CollectableObjectInfo> m_Collectables;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<CollectableItemType, List<CollectableObjectInfo>> m_CollectableTypeMap;

		[Token(Token = "0x1700007E")]
		public List<CollectableObjectInfo> Collectables
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x8734B8", Offset = "0x8734B8", VA = "0x8734B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public Dictionary<CollectableItemType, List<CollectableObjectInfo>> CollectableMap
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x8734C0", Offset = "0x8734C0", VA = "0x8734C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x8734C8", Offset = "0x8734C8", VA = "0x8734C8")]
		public void Add(CollectableObjectInfo info)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x8736B0", Offset = "0x8736B0", VA = "0x8736B0")]
		public List<CollectableObjectInfo> GetCollectables(CollectableItemType type)
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x873708", Offset = "0x873708", VA = "0x873708")]
		public List<CollectableObjectInfo> GetCollectablesByName(PrefabName name)
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x873A58", Offset = "0x873A58", VA = "0x873A58")]
		public CollectableDatabase()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class CollectableManager : MonoBehaviour
	{
		[Token(Token = "0x4000384")]
		public const string DEFAULT_SPAWN_POINT_TAG = "SpawnPoint";

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_MinSpawnInterval;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_BatchMode;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int m_BatchSize;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_IndexRover;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_NextSpawnTime;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject[] m_DefaultSpawnPoints;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<CollectableObjectInfo> m_CollectableObjs;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<CollectableItemType, List<CollectableObjectInfo>>.Enumerator m_CollectableMapEnumerator;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<PrefabName, List<GameObject>> m_SpawnedObjs;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<string, PuzzleInfo> m_PuzzleModels;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Dictionary<PrefabName, int> m_MinSpawnAmountOverride;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DateTime m_SpawnTime;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float m_SuccessRatio;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int m_TotalSpawned;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int m_NumOfTypeSpawned;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int m_TotalTried;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CollectableManager m_Instance;

		[Token(Token = "0x17000080")]
		public bool Enabled
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x873B18", Offset = "0x873B18", VA = "0x873B18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x873B20", Offset = "0x873B20", VA = "0x873B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		private Dictionary<PrefabName, List<GameObject>> m_SpawnPointMap
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x873B2C", Offset = "0x873B2C", VA = "0x873B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		private Dictionary<CollectableItemType, List<CollectableObjectInfo>> m_CollectableMap
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x873B78", Offset = "0x873B78", VA = "0x873B78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public Dictionary<PrefabName, List<GameObject>> SpawnedObjects
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x873BD0", Offset = "0x873BD0", VA = "0x873BD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public static CollectableManager Instance
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x873C50", Offset = "0x873C50", VA = "0x873C50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x873C98", Offset = "0x873C98", VA = "0x873C98")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x873CE4", Offset = "0x873CE4", VA = "0x873CE4")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x873E4C", Offset = "0x873E4C", VA = "0x873E4C")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x873E94", Offset = "0x873E94", VA = "0x873E94")]
		private void Spawn()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x873E98", Offset = "0x873E98", VA = "0x873E98")]
		private void SpawnBatch()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x8743CC", Offset = "0x8743CC", VA = "0x8743CC")]
		private GameObject FindAvailableSpawnPointRandomly(CollectableObjectInfo objToSpawn)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x874558", Offset = "0x874558", VA = "0x874558")]
		private bool IsSpawnPointOccupied(GameObject spawnPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x8742DC", Offset = "0x8742DC", VA = "0x8742DC")]
		private bool GetCollectableToSpawn(out CollectableObjectInfo collectable, out GameObject spawnPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x8745E4", Offset = "0x8745E4", VA = "0x8745E4")]
		private CollectableObjectInfo GetCollectableObject()
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x874898", Offset = "0x874898", VA = "0x874898")]
		public void AddSpawnedObject(PrefabName name, GameObject obj)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x874A24", Offset = "0x874A24", VA = "0x874A24")]
		public void Reset()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x874B98", Offset = "0x874B98", VA = "0x874B98")]
		public CollectableManager()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[CreateAssetMenu(fileName = "CollectableObjectsConfig", menuName = "ScriptableObjects/CollectableObjectsConfig", order = 1)]
	public class CollectableObjectsConfig : ScriptableObject
	{
		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CollectableObjectInfo[] config;

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x874C60", Offset = "0x874C60", VA = "0x874C60")]
		public CollectableObjectsConfig()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008D")]
	public class CollectableObjectInfo
	{
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CollectableItemType type;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public PrefabName name;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string tag;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int maxNumber;

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x874C68", Offset = "0x874C68", VA = "0x874C68")]
		public CollectableObjectInfo()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class AssetManagement : MonoBehaviour
	{
		[Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class <DestoryGameObject>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AssetManagement <>4__this;

			[Token(Token = "0x17000086")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600031B")]
				[Address(RVA = "0x874F7C", Offset = "0x874F7C", VA = "0x874F7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600031D")]
				[Address(RVA = "0x874FC4", Offset = "0x874FC4", VA = "0x874FC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x874E4C", Offset = "0x874E4C", VA = "0x874E4C")]
			[DebuggerHidden]
			public <DestoryGameObject>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x874E84", Offset = "0x874E84", VA = "0x874E84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x874E88", Offset = "0x874E88", VA = "0x874E88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x874F84", Offset = "0x874F84", VA = "0x874F84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float destroyTime;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool enableAutoDestroy;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool isTriggered;

		[Token(Token = "0x17000085")]
		public bool EnableAutoDestroy
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x874C70", Offset = "0x874C70", VA = "0x874C70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x874C78", Offset = "0x874C78", VA = "0x874C78")]
			set
			{
			}
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x874C84", Offset = "0x874C84", VA = "0x874C84")]
		public void CancelDestroy()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x874CD4", Offset = "0x874CD4", VA = "0x874CD4")]
		private void TriggerDestory()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x874D34", Offset = "0x874D34", VA = "0x874D34")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x874DE4", Offset = "0x874DE4", VA = "0x874DE4")]
		[IteratorStateMachine(typeof(<DestoryGameObject>d__9))]
		private IEnumerator DestoryGameObject()
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x874E74", Offset = "0x874E74", VA = "0x874E74")]
		public AssetManagement()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class BeizerLineRender : MonoBehaviour
	{
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3[] positions;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 startPoint;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 endPoint;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 controlPoint;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform target;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform startTransform;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 endOffset;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private LineRenderer lr;

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x874FCC", Offset = "0x874FCC", VA = "0x874FCC")]
		private void Start()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x874FD8", Offset = "0x874FD8", VA = "0x874FD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x87517C", Offset = "0x87517C", VA = "0x87517C")]
		private Vector3[] GetBeizerList(Vector3 startPoint, Vector3 controlPoint, Vector3 endPoint, int segmentNum)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x875290", Offset = "0x875290", VA = "0x875290")]
		private Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x8752F0", Offset = "0x8752F0", VA = "0x8752F0")]
		public void Init(Transform target, Transform startTransform, Vector3 endOffset, LineRenderer lr)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x875304", Offset = "0x875304", VA = "0x875304")]
		public BeizerLineRender()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class CameraMgr : MonoBehaviour
	{
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera mainCamera;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CameraMgr m_Instance;

		[Token(Token = "0x17000088")]
		public static CameraMgr Instance
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x87530C", Offset = "0x87530C", VA = "0x87530C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x875354", Offset = "0x875354", VA = "0x875354")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x8753AC", Offset = "0x8753AC", VA = "0x8753AC")]
		public Camera GetMainCamera()
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x875458", Offset = "0x875458", VA = "0x875458")]
		public CameraMgr()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class CanvasCamera : MonoBehaviour
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Canvas canvas;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x875460", Offset = "0x875460", VA = "0x875460")]
		private void Start()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x875598", Offset = "0x875598", VA = "0x875598")]
		public CanvasCamera()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class CanvasController : MonoBehaviour
	{
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject canvas;

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x8755A0", Offset = "0x8755A0", VA = "0x8755A0")]
		public void HandlePlayerIn(Collider other)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x875768", Offset = "0x875768", VA = "0x875768")]
		public void HandlePlayerOut(Collider other)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x875930", Offset = "0x875930", VA = "0x875930")]
		public CanvasController()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class ColliderEvent : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000095")]
		public class onTriggerEnterEvent : UnityEvent<Collider>
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x875AC0", Offset = "0x875AC0", VA = "0x875AC0")]
			public onTriggerEnterEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000096")]
		public class onCollisionEnterEvent : UnityEvent<Collision>
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x875B08", Offset = "0x875B08", VA = "0x875B08")]
			public onCollisionEnterEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000097")]
		public class onTriggerExitEvent : UnityEvent<Collider>
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x875B50", Offset = "0x875B50", VA = "0x875B50")]
			public onTriggerExitEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000098")]
		public class onCollisionExitEvent : UnityEvent<Collision>
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x875B98", Offset = "0x875B98", VA = "0x875B98")]
			public onCollisionExitEvent()
			{
			}
		}

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public onTriggerEnterEvent tiggerEntered;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public onCollisionEnterEvent collisionEntered;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public onTriggerExitEvent tiggerExited;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public onCollisionExitEvent collisionExited;

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x875938", Offset = "0x875938", VA = "0x875938")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x875998", Offset = "0x875998", VA = "0x875998")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x8759F8", Offset = "0x8759F8", VA = "0x8759F8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x875A58", Offset = "0x875A58", VA = "0x875A58")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x875AB8", Offset = "0x875AB8", VA = "0x875AB8")]
		public ColliderEvent()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class CutomButton : Selectable, IPointerClickHandler, IEventSystemHandler
	{
		[Serializable]
		[Token(Token = "0x200009A")]
		public class PointerClickEvent : UnityEvent
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x875C4C", Offset = "0x875C4C", VA = "0x875C4C")]
			public PointerClickEvent()
			{
			}
		}

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public PointerClickEvent pointerClicked;

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x875BE0", Offset = "0x875BE0", VA = "0x875BE0", Slot = "39")]
		private void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x875BF4", Offset = "0x875BF4", VA = "0x875BF4")]
		public CutomButton()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class Highlight : MonoBehaviour
	{
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private XRBaseInteractable m_Interactable;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Renderer[] m_Renderers;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collectable m_Collectable;

		[Token(Token = "0x40003B6")]
		private const float lineWidth = 0.018f;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Held;

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x875C54", Offset = "0x875C54", VA = "0x875C54")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x875EB8", Offset = "0x875EB8", VA = "0x875EB8")]
		private void SetOutLineWidth(Renderer[] renderers, float value)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x875F98", Offset = "0x875F98", VA = "0x875F98")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x876174", Offset = "0x876174", VA = "0x876174", Slot = "4")]
		protected virtual void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x8763F4", Offset = "0x8763F4", VA = "0x8763F4", Slot = "5")]
		protected virtual void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x876468", Offset = "0x876468", VA = "0x876468", Slot = "6")]
		protected virtual void OnLastHoverExited(HoverExitEventArgs args)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x8765CC", Offset = "0x8765CC", VA = "0x8765CC", Slot = "7")]
		protected virtual void OnFirstHoverEntered(HoverEnterEventArgs args)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x8766DC", Offset = "0x8766DC", VA = "0x8766DC")]
		public Highlight()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class HintRender : MonoBehaviour
	{
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform startTransform;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 endOffset;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool onFirst;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private LineRenderer lr;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TMP_Text hint;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas canvas;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Billboard billboard;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BeizerLineRender beizerLine;

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x8766E4", Offset = "0x8766E4", VA = "0x8766E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x8767F4", Offset = "0x8767F4", VA = "0x8767F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x876804", Offset = "0x876804", VA = "0x876804")]
		private void Translate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x8768B8", Offset = "0x8768B8", VA = "0x8768B8")]
		public void Display(string text)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x8762A4", Offset = "0x8762A4", VA = "0x8762A4")]
		public void TurnOff()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x876AEC", Offset = "0x876AEC", VA = "0x876AEC")]
		public HintRender()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class IntrusionBlocker : MonoBehaviour
	{
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Player;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool IsFadeEnabled;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] LayersForDetection;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int fadeState;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float fadeDuration;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float fadeTimer;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float backupCap;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 previousHeadPos;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 playerPos;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isOutside;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float maxOffset;

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x876AF4", Offset = "0x876AF4", VA = "0x876AF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x876AF8", Offset = "0x876AF8", VA = "0x876AF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x876E00", Offset = "0x876E00", VA = "0x876E00")]
		private void Fade(bool fadeIn = true)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x876C80", Offset = "0x876C80", VA = "0x876C80")]
		private bool DetectHit(Vector3 pos)
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x876E68", Offset = "0x876E68", VA = "0x876E68")]
		public IntrusionBlocker()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class ItemPool : MonoBehaviour
	{
		[Token(Token = "0x200009F")]
		public struct ItemDescription
		{
			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int ID;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool InUse;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform Obj;
		}

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PrefabName m_PrefabName;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int m_Capactiy;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_RefCount;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_Initialized;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_Orig;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<int, ItemDescription> m_ItemDict;

		[Token(Token = "0x17000089")]
		public PrefabName ItemName
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x876EE4", Offset = "0x876EE4", VA = "0x876EE4")]
			get
			{
				return default(PrefabName);
			}
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x876EEC", Offset = "0x876EEC", VA = "0x876EEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x87724C", Offset = "0x87724C", VA = "0x87724C")]
		public bool InstantiateItem(Vector3 position, Quaternion rotation, Transform parent, out GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x877684", Offset = "0x877684", VA = "0x877684")]
		public bool DestroyItem(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x876F64", Offset = "0x876F64", VA = "0x876F64")]
		private void Init()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x877958", Offset = "0x877958", VA = "0x877958")]
		public ItemPool()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class ItemPoolManager : MonoBehaviour
	{
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> m_ListOfPools;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ItemPoolManager Instance;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, ItemPool> m_ObjectPoolMap;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<PrefabName, ItemPool> m_ItemPoolDict;

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x877970", Offset = "0x877970", VA = "0x877970")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x877C24", Offset = "0x877C24", VA = "0x877C24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x877C28", Offset = "0x877C28", VA = "0x877C28")]
		private void Update()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x877C2C", Offset = "0x877C2C", VA = "0x877C2C")]
		public bool SpawnPrefab(PrefabName name, out GameObject spawned, Vector3 position, Quaternion rotation, [Optional] Transform parent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x87802C", Offset = "0x87802C", VA = "0x87802C")]
		public void RecyclePrefab(GameObject recyled)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x877A54", Offset = "0x877A54", VA = "0x877A54")]
		private void PopulateItemPools()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x8781D4", Offset = "0x8781D4", VA = "0x8781D4")]
		public ItemPoolManager()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class Layers
	{
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string COLLECTABLE;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string CLIMBABLE;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string WATER;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string PLANTINGAREA;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string PLAYER;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string TELEPORT;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string DESTROYABLE;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string BUILDING;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string MOUTH;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string RAFT;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string CHARACTER;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string GRABBALE;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string SEABED;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string BAGANCHOR;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string POCKET_ANCHOR;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string UNDER_SEA;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string TERRAIN;

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x8781DC", Offset = "0x8781DC", VA = "0x8781DC")]
		public Layers()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class LightCulling : MonoBehaviour
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Light m_light;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera mainCamera;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lightCullingDistanceSqr;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float showCullingDistanceSqr;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool enableLight;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool enableShadow;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x87846C", Offset = "0x87846C", VA = "0x87846C")]
		private void Start()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x878580", Offset = "0x878580", VA = "0x878580")]
		private void Update()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x878558", Offset = "0x878558", VA = "0x878558")]
		private void EnableShadow(bool enable)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x87874C", Offset = "0x87874C", VA = "0x87874C")]
		private void EnableLight(bool value)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x87876C", Offset = "0x87876C", VA = "0x87876C")]
		public LightCulling()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public enum ComponentName
	{
		[Token(Token = "0x40003F1")]
		None,
		[Token(Token = "0x40003F2")]
		Env_Beach_02,
		[Token(Token = "0x40003F3")]
		Env_Beach_03,
		[Token(Token = "0x40003F4")]
		Env_PalmTree_01,
		[Token(Token = "0x40003F5")]
		Env_Tree_Large_01,
		[Token(Token = "0x40003F6")]
		Env_Rock_01,
		[Token(Token = "0x40003F7")]
		Env_Bamboo,
		[Token(Token = "0x40003F8")]
		Env_Plant_01
	}
	[Token(Token = "0x20000A4")]
	public enum PrefabName
	{
		[Token(Token = "0x40003FA")]
		Empty,
		[Token(Token = "0x40003FB")]
		TomatoPlant,
		[Token(Token = "0x40003FC")]
		AppleTree,
		[Token(Token = "0x40003FD")]
		Giganotosaurus_Head,
		[Token(Token = "0x40003FE")]
		Giganotosaurus_Upper,
		[Token(Token = "0x40003FF")]
		Giganotosaurus_Lower,
		[Token(Token = "0x4000400")]
		Giganotosaurus_Tail,
		[Token(Token = "0x4000401")]
		Rock,
		[Token(Token = "0x4000402")]
		Wood,
		[Token(Token = "0x4000403")]
		Knife,
		[Token(Token = "0x4000404")]
		Coconut,
		[Token(Token = "0x4000405")]
		Mushroom,
		[Token(Token = "0x4000406")]
		Axe,
		[Token(Token = "0x4000407")]
		PalmLeaf,
		[Token(Token = "0x4000408")]
		Bamboo,
		[Token(Token = "0x4000409")]
		BambooPole,
		[Token(Token = "0x400040A")]
		SharpRock,
		[Token(Token = "0x400040B")]
		Fish,
		[Token(Token = "0x400040C")]
		CampFire,
		[Token(Token = "0x400040D")]
		ToastedFish,
		[Token(Token = "0x400040E")]
		Vine,
		[Token(Token = "0x400040F")]
		Rope,
		[Token(Token = "0x4000410")]
		Tent,
		[Token(Token = "0x4000411")]
		Apple,
		[Token(Token = "0x4000412")]
		Bow,
		[Token(Token = "0x4000413")]
		BambooPipe,
		[Token(Token = "0x4000414")]
		Tomato,
		[Token(Token = "0x4000415")]
		CoconutPalm,
		[Token(Token = "0x4000416")]
		Torch,
		[Token(Token = "0x4000417")]
		Carrot,
		[Token(Token = "0x4000418")]
		FlintStone,
		[Token(Token = "0x4000419")]
		RawMeat,
		[Token(Token = "0x400041A")]
		CookedMeat,
		[Token(Token = "0x400041B")]
		Rehmannia,
		[Token(Token = "0x400041C")]
		Echinacea,
		[Token(Token = "0x400041D")]
		Agave,
		[Token(Token = "0x400041E")]
		Shanty,
		[Token(Token = "0x400041F")]
		CocoShell,
		[Token(Token = "0x4000420")]
		AgaveSoup,
		[Token(Token = "0x4000421")]
		RehmanniaSoup,
		[Token(Token = "0x4000422")]
		EchinaceaSoup,
		[Token(Token = "0x4000423")]
		ToxicMushroom,
		[Token(Token = "0x4000424")]
		Shovel,
		[Token(Token = "0x4000425")]
		Pickaxe,
		[Token(Token = "0x4000426")]
		Crystal,
		[Token(Token = "0x4000427")]
		Cloth,
		[Token(Token = "0x4000428")]
		Fence,
		[Token(Token = "0x4000429")]
		FenceLong,
		[Token(Token = "0x400042A")]
		Hammer,
		[Token(Token = "0x400042B")]
		WaterFilter,
		[Token(Token = "0x400042C")]
		Chest,
		[Token(Token = "0x400042D")]
		WoodWall,
		[Token(Token = "0x400042E")]
		WoodFloor,
		[Token(Token = "0x400042F")]
		WoodFoundation,
		[Token(Token = "0x4000430")]
		WoodStair,
		[Token(Token = "0x4000431")]
		WindowWall,
		[Token(Token = "0x4000432")]
		DoorWall,
		[Token(Token = "0x4000433")]
		Roof,
		[Token(Token = "0x4000434")]
		RawCrabMeat,
		[Token(Token = "0x4000435")]
		CookedCrabMeat,
		[Token(Token = "0x4000436")]
		BlueSpar,
		[Token(Token = "0x4000437")]
		RedSpar,
		[Token(Token = "0x4000438")]
		BlueLamp,
		[Token(Token = "0x4000439")]
		RedLamp,
		[Token(Token = "0x400043A")]
		Bottle,
		[Token(Token = "0x400043B")]
		BlueSparStone,
		[Token(Token = "0x400043C")]
		RedSparStone,
		[Token(Token = "0x400043D")]
		Box,
		[Token(Token = "0x400043E")]
		PlasticBox,
		[Token(Token = "0x400043F")]
		CookingPot,
		[Token(Token = "0x4000440")]
		Egg,
		[Token(Token = "0x4000441")]
		MeatBall,
		[Token(Token = "0x4000442")]
		DarkCooking,
		[Token(Token = "0x4000443")]
		Kebab,
		[Token(Token = "0x4000444")]
		VegetableSoup,
		[Token(Token = "0x4000445")]
		FishFillet,
		[Token(Token = "0x4000446")]
		SeafoodSoup,
		[Token(Token = "0x4000447")]
		Cocofood,
		[Token(Token = "0x4000448")]
		RedGlowMushroom,
		[Token(Token = "0x4000449")]
		GreenGlowMushroom,
		[Token(Token = "0x400044A")]
		PurpleGlowMushroom,
		[Token(Token = "0x400044B")]
		RedSpotMushroom,
		[Token(Token = "0x400044C")]
		BlueSpotMushroom,
		[Token(Token = "0x400044D")]
		PlantingFoundation,
		[Token(Token = "0x400044E")]
		Mud,
		[Token(Token = "0x400044F")]
		Mound,
		[Token(Token = "0x4000450")]
		BambooRaft,
		[Token(Token = "0x4000451")]
		Paddle,
		[Token(Token = "0x4000452")]
		Atractylodes,
		[Token(Token = "0x4000453")]
		AtractylodesSoup,
		[Token(Token = "0x4000454")]
		StarFish,
		[Token(Token = "0x4000455")]
		CuttableStone,
		[Token(Token = "0x4000456")]
		Trunk,
		[Token(Token = "0x4000457")]
		Banana,
		[Token(Token = "0x4000458")]
		Iron,
		[Token(Token = "0x4000459")]
		Saltpeter,
		[Token(Token = "0x400045A")]
		Sulfur,
		[Token(Token = "0x400045B")]
		IronMine,
		[Token(Token = "0x400045C")]
		SulfurMine,
		[Token(Token = "0x400045D")]
		SaltpeterMine,
		[Token(Token = "0x400045E")]
		Pumpkin,
		[Token(Token = "0x400045F")]
		Corn,
		[Token(Token = "0x4000460")]
		Beetroot,
		[Token(Token = "0x4000461")]
		Cabbage,
		[Token(Token = "0x4000462")]
		PumpkinPlant,
		[Token(Token = "0x4000463")]
		CornPlant,
		[Token(Token = "0x4000464")]
		CabbagePlant,
		[Token(Token = "0x4000465")]
		BeetrootPlant,
		[Token(Token = "0x4000466")]
		Shell,
		[Token(Token = "0x4000467")]
		SeaSnail,
		[Token(Token = "0x4000468")]
		Clock,
		[Token(Token = "0x4000469")]
		Can,
		[Token(Token = "0x400046A")]
		Gold,
		[Token(Token = "0x400046B")]
		AnimalSkin,
		[Token(Token = "0x400046C")]
		AnimalTeeth,
		[Token(Token = "0x400046D")]
		RaftFoundation,
		[Token(Token = "0x400046E")]
		RaftClothSail,
		[Token(Token = "0x400046F")]
		RaftCanopy,
		[Token(Token = "0x4000470")]
		RaftRudder,
		[Token(Token = "0x4000471")]
		Pillar,
		[Token(Token = "0x4000472")]
		HalfWall,
		[Token(Token = "0x4000473")]
		TriangleFloor,
		[Token(Token = "0x4000474")]
		SlopedWallRight,
		[Token(Token = "0x4000475")]
		SlopedRoof,
		[Token(Token = "0x4000476")]
		SlopedWallLeft,
		[Token(Token = "0x4000477")]
		WoodenRailing,
		[Token(Token = "0x4000478")]
		WoodenBed,
		[Token(Token = "0x4000479")]
		WoodenDoor,
		[Token(Token = "0x400047A")]
		InnerLantern,
		[Token(Token = "0x400047B")]
		WoodenShelf,
		[Token(Token = "0x400047C")]
		WoodenStool,
		[Token(Token = "0x400047D")]
		StorageBox,
		[Token(Token = "0x400047E")]
		WoodenTable,
		[Token(Token = "0x400047F")]
		Flowerpot,
		[Token(Token = "0x4000480")]
		SurvivalDaysPanel,
		[Token(Token = "0x4000481")]
		WoodenLadder,
		[Token(Token = "0x4000482")]
		Gun,
		[Token(Token = "0x4000483")]
		PalmTree,
		[Token(Token = "0x4000484")]
		Chest1,
		[Token(Token = "0x4000485")]
		Notebook,
		[Token(Token = "0x4000486")]
		Charcoal,
		[Token(Token = "0x4000487")]
		GunPowder,
		[Token(Token = "0x4000488")]
		TriangleFoundation,
		[Token(Token = "0x4000489")]
		BambooTree1,
		[Token(Token = "0x400048A")]
		BambooTree2,
		[Token(Token = "0x400048B")]
		TreeVine1,
		[Token(Token = "0x400048C")]
		TreeVine2,
		[Token(Token = "0x400048D")]
		FiredTrunk,
		[Token(Token = "0x400048E")]
		PlantingFoundationSmall,
		[Token(Token = "0x400048F")]
		Trunk2,
		[Token(Token = "0x4000490")]
		Trunk3,
		[Token(Token = "0x4000491")]
		BambooRoot1,
		[Token(Token = "0x4000492")]
		BambooRoot2,
		[Token(Token = "0x4000493")]
		PalmTreeRoot,
		[Token(Token = "0x4000494")]
		HightTree3,
		[Token(Token = "0x4000495")]
		HightTree3Root,
		[Token(Token = "0x4000496")]
		PalmTree01,
		[Token(Token = "0x4000497")]
		PalmTree01Root,
		[Token(Token = "0x4000498")]
		PalmTree04,
		[Token(Token = "0x4000499")]
		PalmTree04Root,
		[Token(Token = "0x400049A")]
		PalmTree02,
		[Token(Token = "0x400049B")]
		PalmTree02Root,
		[Token(Token = "0x400049C")]
		PalmTree03,
		[Token(Token = "0x400049D")]
		PalmTree03Root,
		[Token(Token = "0x400049E")]
		Tree01,
		[Token(Token = "0x400049F")]
		Tree01Root,
		[Token(Token = "0x40004A0")]
		StoryBook,
		[Token(Token = "0x40004A1")]
		StoneFoundation,
		[Token(Token = "0x40004A2")]
		StoneWall,
		[Token(Token = "0x40004A3")]
		StoneDoorWall,
		[Token(Token = "0x40004A4")]
		StoneWindowWall,
		[Token(Token = "0x40004A5")]
		StonePillar,
		[Token(Token = "0x40004A6")]
		GlassWall,
		[Token(Token = "0x40004A7")]
		GlassDoorWall,
		[Token(Token = "0x40004A8")]
		GlassWindowWall,
		[Token(Token = "0x40004A9")]
		StoneSlopedRoof,
		[Token(Token = "0x40004AA")]
		StoneSlopedWallLeft,
		[Token(Token = "0x40004AB")]
		StoneSlopedWallRight,
		[Token(Token = "0x40004AC")]
		StoneFloor,
		[Token(Token = "0x40004AD")]
		StoneTriangleFloor,
		[Token(Token = "0x40004AE")]
		StoneStair,
		[Token(Token = "0x40004AF")]
		StoneTriangleFoundation,
		[Token(Token = "0x40004B0")]
		GlassSlopedWallLeft,
		[Token(Token = "0x40004B1")]
		GlassSlopedWallRight,
		[Token(Token = "0x40004B2")]
		Arrow,
		[Token(Token = "0x40004B3")]
		WinningPoint,
		[Token(Token = "0x40004B4")]
		PreparePoint,
		[Token(Token = "0x40004B5")]
		StoneFlowerPot,
		[Token(Token = "0x40004B6")]
		FlowerBlue,
		[Token(Token = "0x40004B7")]
		FlowerBlueSeed,
		[Token(Token = "0x40004B8")]
		CurtainBlue,
		[Token(Token = "0x40004B9")]
		CarpetRound,
		[Token(Token = "0x40004BA")]
		FlowerPot,
		[Token(Token = "0x40004BB")]
		CarpetSquare,
		[Token(Token = "0x40004BC")]
		FlowerRed,
		[Token(Token = "0x40004BD")]
		FlowerRedSeed,
		[Token(Token = "0x40004BE")]
		CurtainRed,
		[Token(Token = "0x40004BF")]
		OutsideLight,
		[Token(Token = "0x40004C0")]
		TeaTable,
		[Token(Token = "0x40004C1")]
		Ledge,
		[Token(Token = "0x40004C2")]
		GlassFloor
	}
	[Token(Token = "0x20000A5")]
	public class Tags
	{
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string SEED;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string CUTTER;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string POLE;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string STABBER;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string FIRE;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string ROCK;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string SPARK;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string FINGER;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string SHOVEL;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string HAMMER;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string WATERFILTER;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string EATABLE;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string RAFT;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string BULLET;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string PLANTINGAREA;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string ANIMAL;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string FUEL;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string TELEPORT_AREA;

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x878780", Offset = "0x878780", VA = "0x878780")]
		public Tags()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public enum VrHardwareType
	{
		[Token(Token = "0x40004D6")]
		Unknown,
		[Token(Token = "0x40004D7")]
		Quest,
		[Token(Token = "0x40004D8")]
		Rift,
		[Token(Token = "0x40004D9")]
		Vive
	}
	[Token(Token = "0x20000A7")]
	public class Config : Singleton<Config>
	{
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private VrHardwareType m_VrHardware;

		[Token(Token = "0x1700008A")]
		public VrHardwareType VrHardware
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x878A34", Offset = "0x878A34", VA = "0x878A34")]
			get
			{
				return default(VrHardwareType);
			}
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x878A48", Offset = "0x878A48", VA = "0x878A48")]
		public Config()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class ContentGenerator : MonoBehaviour
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CreationRuleHelper m_RuleHelper;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GenericRecipe m_Recipe;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ContentGenerator m_Instance;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string[] keywords;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_TerrainLayer;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private EnvironmentDB m_EnvironmentDB;

		[Token(Token = "0x1700008B")]
		public static ContentGenerator Instance
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x878AB4", Offset = "0x878AB4", VA = "0x878AB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x878AFC", Offset = "0x878AFC", VA = "0x878AFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x878C24", Offset = "0x878C24", VA = "0x878C24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x879210", Offset = "0x879210", VA = "0x879210")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x8791B4", Offset = "0x8791B4", VA = "0x8791B4")]
		public void Build(Rule rule)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x879214", Offset = "0x879214", VA = "0x879214")]
		private void CreatePrefab(Rule rule)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x879594", Offset = "0x879594", VA = "0x879594")]
		private void CreateTerrain(Rule rule)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x879920", Offset = "0x879920", VA = "0x879920")]
		private void CreateBiome(Rule rule)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x879CA0", Offset = "0x879CA0", VA = "0x879CA0")]
		private List<Vector3> GetValidPositionsFromRule(Rule rule)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x87A174", Offset = "0x87A174", VA = "0x87A174")]
		private List<Vector3> GetRandomPositionsAroundPoint(Vector3 origin, int pointAmount, int maxRadius, float minDistance = 3f)
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x87A4D8", Offset = "0x87A4D8", VA = "0x87A4D8")]
		private bool ValidatePositionWithMasks(List<TerrainMask> masks, Vector3 position)
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x87A3D4", Offset = "0x87A3D4", VA = "0x87A3D4")]
		private bool ProjectToTerrain(Vector3 position, out Vector3 projected)
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x87A68C", Offset = "0x87A68C", VA = "0x87A68C")]
		private bool CustomComparison(TerrainMaskOp op, float value1, float value2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x87A6D8", Offset = "0x87A6D8", VA = "0x87A6D8")]
		public ContentGenerator()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class CreationRuleHelper : MonoBehaviour
	{
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, ItemCategory> itemCategoryMap;

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x87A7C8", Offset = "0x87A7C8", VA = "0x87A7C8")]
		public Rule RuleFromString(EnvironmentDB env, string msg)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x879044", Offset = "0x879044", VA = "0x879044")]
		public List<Rule> RulesFromText(EnvironmentDB env, string txt)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x87ABD4", Offset = "0x87ABD4", VA = "0x87ABD4")]
		private ItemCategory GetCategory(string text)
		{
			return default(ItemCategory);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x87ACFC", Offset = "0x87ACFC", VA = "0x87ACFC")]
		public CreationRuleHelper()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[CreateAssetMenu(fileName = "GenericRecipe", menuName = "ScriptableObjects/Creation/Recipe", order = 1)]
	public class GenericRecipe : ScriptableObject
	{
		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Rule> rules;

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x87AE14", Offset = "0x87AE14", VA = "0x87AE14")]
		public GenericRecipe()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public enum ItemCategory
	{
		[Token(Token = "0x40004E4")]
		Default,
		[Token(Token = "0x40004E5")]
		Terrain,
		[Token(Token = "0x40004E6")]
		Storable
	}
	[Token(Token = "0x20000AC")]
	public enum RelativePosition
	{
		[Token(Token = "0x40004E8")]
		None,
		[Token(Token = "0x40004E9")]
		Front,
		[Token(Token = "0x40004EA")]
		Back,
		[Token(Token = "0x40004EB")]
		Left,
		[Token(Token = "0x40004EC")]
		Right
	}
	[Token(Token = "0x20000AD")]
	public enum TerrainMaskType
	{
		[Token(Token = "0x40004EE")]
		None,
		[Token(Token = "0x40004EF")]
		Height,
		[Token(Token = "0x40004F0")]
		Slope
	}
	[Token(Token = "0x20000AE")]
	public enum TerrainMaskOp
	{
		[Token(Token = "0x40004F2")]
		EQ,
		[Token(Token = "0x40004F3")]
		GT,
		[Token(Token = "0x40004F4")]
		LT
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class ItemProperty : ScriptableObject
	{
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x87AE1C", Offset = "0x87AE1C", VA = "0x87AE1C")]
		public ItemProperty()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class MetaComponent
	{
		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ItemCategory category;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public PrefabName prefabName;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ComponentName componentName;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<ItemProperty> properties;

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x879208", Offset = "0x879208", VA = "0x879208")]
		public MetaComponent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class TerrainMask
	{
		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TerrainMaskType type;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TerrainMaskOp op;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float value;

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x87AE24", Offset = "0x87AE24", VA = "0x87AE24")]
		public TerrainMask()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class Rule
	{
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MetaComponent m_Component;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_IsRandom;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_Quantity;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 m_Origin;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public RelativePosition m_RelativePos;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Quaternion m_Rotation;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<TerrainMask> m_Masks;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x879200", Offset = "0x879200", VA = "0x879200")]
		public Rule()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class CutPolyDemoScript : MonoBehaviour
	{
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x87AE2C", Offset = "0x87AE2C", VA = "0x87AE2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x87AE30", Offset = "0x87AE30", VA = "0x87AE30")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x87B0D4", Offset = "0x87B0D4", VA = "0x87B0D4")]
		public CutPolyDemoScript()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class DeathHandler : MonoBehaviour
	{
		[Token(Token = "0x20000B5")]
		[CompilerGenerated]
		private sealed class <ShowMenu>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x1700008C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000385")]
				[Address(RVA = "0x87B4E0", Offset = "0x87B4E0", VA = "0x87B4E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000387")]
				[Address(RVA = "0x87B528", Offset = "0x87B528", VA = "0x87B528", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000382")]
			[Address(RVA = "0x87B3D4", Offset = "0x87B3D4", VA = "0x87B3D4")]
			[DebuggerHidden]
			public <ShowMenu>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x87B404", Offset = "0x87B404", VA = "0x87B404", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000384")]
			[Address(RVA = "0x87B408", Offset = "0x87B408", VA = "0x87B408", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000386")]
			[Address(RVA = "0x87B4E8", Offset = "0x87B4E8", VA = "0x87B4E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip deathSound;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_ObjectsToDisable;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Behaviour[] m_BehavioursToDisable;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool isDying;

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x87B0DC", Offset = "0x87B0DC", VA = "0x87B0DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x87B1C0", Offset = "0x87B1C0", VA = "0x87B1C0")]
		private void OnDeath()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x87B374", Offset = "0x87B374", VA = "0x87B374")]
		[IteratorStateMachine(typeof(<ShowMenu>d__6))]
		private IEnumerator ShowMenu()
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x87B3FC", Offset = "0x87B3FC", VA = "0x87B3FC")]
		public DeathHandler()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public enum LifeCycleState
	{
		[Token(Token = "0x400050A")]
		Init,
		[Token(Token = "0x400050B")]
		Newborn,
		[Token(Token = "0x400050C")]
		Youth,
		[Token(Token = "0x400050D")]
		Adult,
		[Token(Token = "0x400050E")]
		Deceased
	}
	[Token(Token = "0x20000B7")]
	public struct LifeCycleEventInfo
	{
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LifeCycleState m_FromState;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public LifeCycleState m_ToState;
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class LifeCycleStateChangeEvent : UnityEvent<LifeCycleEventInfo>
	{
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x87B530", Offset = "0x87B530", VA = "0x87B530")]
		public LifeCycleStateChangeEvent()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public abstract class LifeCycleBase : MonoBehaviour
	{
		[Token(Token = "0x20000BA")]
		[CompilerGenerated]
		private sealed class <Init>d__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LifeCycleBase <>4__this;

			[Token(Token = "0x17000094")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003A6")]
				[Address(RVA = "0x87C598", Offset = "0x87C598", VA = "0x87C598", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003A8")]
				[Address(RVA = "0x87C5E0", Offset = "0x87C5E0", VA = "0x87C5E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x87B744", Offset = "0x87B744", VA = "0x87B744")]
			[DebuggerHidden]
			public <Init>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x87C480", Offset = "0x87C480", VA = "0x87C480", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x87C484", Offset = "0x87C484", VA = "0x87C484", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x87C5A0", Offset = "0x87C5A0", VA = "0x87C5A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000BB")]
		[CompilerGenerated]
		private sealed class <SwitchToLater>d__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LifeCycleBase <>4__this;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LifeCycleState cycleState;

			[Token(Token = "0x17000096")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003AC")]
				[Address(RVA = "0x87C644", Offset = "0x87C644", VA = "0x87C644", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003AE")]
				[Address(RVA = "0x87C68C", Offset = "0x87C68C", VA = "0x87C68C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x87BDB8", Offset = "0x87BDB8", VA = "0x87BDB8")]
			[DebuggerHidden]
			public <SwitchToLater>d__48(int <>1__state)
			{
			}

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x87C5E8", Offset = "0x87C5E8", VA = "0x87C5E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x87C5EC", Offset = "0x87C5EC", VA = "0x87C5EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x87C64C", Offset = "0x87C64C", VA = "0x87C64C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private LifeCycleState m_CurrentState;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private LifeCycleState m_DesiredState;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_NewbornPrefab;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_BirthScale;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_NewbornLifeSpan;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_YouthPrefab;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_YouthScale;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_YouthLifeSpan;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject m_AdultPrefab;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_AdultScale;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject m_DeceasedPrefab;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float m_LifeSpan;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject m_DefaultPrefab;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool m_IsSpawnEnabled;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_TimeLeftToSpawn;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float m_DefaultSpawnInterval;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image progressBar;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GameObject m_CurrentObject;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float m_ElapsedTime;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public PrefabName itemName;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public LifeCycleStateChangeEvent m_StateChangedEvent;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private FruitHolder[] fruitHolders;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		public PrefabName FoundationName;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private PlantingFoundation plantFoundation;

		[Token(Token = "0x1700008E")]
		public LifeCycleState CurrentState
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x87B578", Offset = "0x87B578", VA = "0x87B578")]
			get
			{
				return default(LifeCycleState);
			}
		}

		[Token(Token = "0x1700008F")]
		public float ElapsedTime
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x87B580", Offset = "0x87B580", VA = "0x87B580")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x87B588", Offset = "0x87B588", VA = "0x87B588")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public float TimeLeftToSpawn
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x87B590", Offset = "0x87B590", VA = "0x87B590")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x87B598", Offset = "0x87B598", VA = "0x87B598")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public bool IsTracked
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x87B5A0", Offset = "0x87B5A0", VA = "0x87B5A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x87B5A8", Offset = "0x87B5A8", VA = "0x87B5A8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public GameObject CurrentObject
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x87B5B4", Offset = "0x87B5B4", VA = "0x87B5B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x87B5BC", Offset = "0x87B5BC", VA = "0x87B5BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public GameObject AdultPrefab
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x87B5C4", Offset = "0x87B5C4", VA = "0x87B5C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x87B5CC", Offset = "0x87B5CC", VA = "0x87B5CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x87B634", Offset = "0x87B634", VA = "0x87B634")]
		private void Start()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x87B6DC", Offset = "0x87B6DC", VA = "0x87B6DC")]
		[IteratorStateMachine(typeof(<Init>d__43))]
		private IEnumerator Init()
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x87B76C", Offset = "0x87B76C", VA = "0x87B76C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x87BCA4", Offset = "0x87BCA4", VA = "0x87BCA4")]
		private void SwitchTo(LifeCycleState cycleState)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x87BCAC", Offset = "0x87BCAC", VA = "0x87BCAC")]
		public void SetStateTo(LifeCycleState cycleState)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x87BCB4", Offset = "0x87BCB4", VA = "0x87BCB4")]
		public void RestoreStateTo(LifeCycleState cycleState)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x87BD40", Offset = "0x87BD40", VA = "0x87BD40")]
		[IteratorStateMachine(typeof(<SwitchToLater>d__48))]
		private IEnumerator SwitchToLater(LifeCycleState cycleState)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x87BDE0", Offset = "0x87BDE0", VA = "0x87BDE0")]
		public void SetPlantFoundation(PlantingFoundation foundation)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x87BE70", Offset = "0x87BE70", VA = "0x87BE70")]
		public void RemovePlantFoundation()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x87B81C", Offset = "0x87B81C", VA = "0x87B81C")]
		protected void SwitchState()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x87BEEC", Offset = "0x87BEEC", VA = "0x87BEEC")]
		private void SpawnObject(GameObject prefab)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x87C0A8", Offset = "0x87C0A8", VA = "0x87C0A8", Slot = "4")]
		protected virtual void DoSpawn()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x87C108", Offset = "0x87C108", VA = "0x87C108", Slot = "5")]
		protected virtual void UpdateLifeCycle()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x87C3EC", Offset = "0x87C3EC", VA = "0x87C3EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x87C458", Offset = "0x87C458", VA = "0x87C458")]
		protected LifeCycleBase()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class Plant : LifeCycleBase
	{
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool CanRefreshLifeSpan;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float MaxRefreshLifeSpan;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool isAutoBorn;

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x87C694", Offset = "0x87C694", VA = "0x87C694")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x87C6AC", Offset = "0x87C6AC", VA = "0x87C6AC")]
		public void SwitchToNewborn(GameObject obj)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x87C6BC", Offset = "0x87C6BC", VA = "0x87C6BC")]
		public void SwitchToDecrease()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x87C6C8", Offset = "0x87C6C8", VA = "0x87C6C8")]
		public void RefreshLifeSpan()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x87C700", Offset = "0x87C700", VA = "0x87C700", Slot = "5")]
		protected override void UpdateLifeCycle()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x87C704", Offset = "0x87C704", VA = "0x87C704")]
		public Plant()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class EffectsMgr : MonoBehaviour
	{
		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GameObject> dayEffects;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GameObject> nightEffects;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static EffectsMgr Instance;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x87C734", Offset = "0x87C734", VA = "0x87C734")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x87C780", Offset = "0x87C780", VA = "0x87C780")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x87C998", Offset = "0x87C998", VA = "0x87C998")]
		private void RefreshEffects(WeatherState weather)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x87C958", Offset = "0x87C958", VA = "0x87C958")]
		private void RefreshDayNightEffects(TimeOfDay state)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x87CB48", Offset = "0x87CB48", VA = "0x87CB48")]
		private void TurnNightEffects(bool on)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x87C9C4", Offset = "0x87C9C4", VA = "0x87C9C4")]
		private void TurnDayEffects(bool on)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x87CCCC", Offset = "0x87CCCC", VA = "0x87CCCC")]
		public void AddDayEffect(GameObject effect)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x87CDF8", Offset = "0x87CDF8", VA = "0x87CDF8")]
		public EffectsMgr()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class EyeEffects : MonoBehaviour
	{
		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float alpha;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool enable;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Renderer render;

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x87CE00", Offset = "0x87CE00", VA = "0x87CE00")]
		private void Start()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x87CF90", Offset = "0x87CF90", VA = "0x87CF90")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x87D0C8", Offset = "0x87D0C8", VA = "0x87D0C8")]
		private void DisplayBloodScreen(float delta)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x87D0E8", Offset = "0x87D0E8", VA = "0x87D0E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x87D19C", Offset = "0x87D19C", VA = "0x87D19C")]
		public EyeEffects()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class FadeInOut : MonoBehaviour
	{
		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static FadeInOut Instance;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_IsFadeIn;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool m_IsFadeOut;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_FadingSpeed;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image image;

		[Token(Token = "0x17000098")]
		public bool IsFadeIn
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x87D1A4", Offset = "0x87D1A4", VA = "0x87D1A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x87D1AC", Offset = "0x87D1AC", VA = "0x87D1AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool IsFadeOut
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x87D1B8", Offset = "0x87D1B8", VA = "0x87D1B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x87D1C0", Offset = "0x87D1C0", VA = "0x87D1C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public float FadingSpeed
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x87D1CC", Offset = "0x87D1CC", VA = "0x87D1CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x87D1D4", Offset = "0x87D1D4", VA = "0x87D1D4")]
			set
			{
			}
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x87D1DC", Offset = "0x87D1DC", VA = "0x87D1DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x87D230", Offset = "0x87D230", VA = "0x87D230")]
		private void Start()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x87D314", Offset = "0x87D314", VA = "0x87D314")]
		private void SetFadeOut()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x87D320", Offset = "0x87D320", VA = "0x87D320")]
		private void Update()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x87D354", Offset = "0x87D354", VA = "0x87D354")]
		private void FadeIn()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x87D478", Offset = "0x87D478", VA = "0x87D478")]
		private void FadeOut()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x87D594", Offset = "0x87D594", VA = "0x87D594")]
		public FadeInOut()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class Mask : MonoBehaviour
	{
		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material maskMaterial;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float alpha;

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x87D59C", Offset = "0x87D59C", VA = "0x87D59C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x87D5A8", Offset = "0x87D5A8", VA = "0x87D5A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x87D608", Offset = "0x87D608", VA = "0x87D608")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x87D704", Offset = "0x87D704", VA = "0x87D704")]
		public Mask()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class WaterController : MonoBehaviour
	{
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Water;

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x87D70C", Offset = "0x87D70C", VA = "0x87D70C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x87D7C0", Offset = "0x87D7C0", VA = "0x87D7C0")]
		public static void TurnOnDepth(bool value)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x87D850", Offset = "0x87D850", VA = "0x87D850")]
		public static void SetValue(string name, float value)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x87D8C8", Offset = "0x87D8C8", VA = "0x87D8C8")]
		public WaterController()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class ElysiumRayInteractor : XRRayInteractor
	{
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private XRInteractorLineVisual lineVisual;

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x87D8D0", Offset = "0x87D8D0", VA = "0x87D8D0", Slot = "46")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x87D92C", Offset = "0x87D92C", VA = "0x87D92C")]
		public void RemoteControll(float distance)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x87DA70", Offset = "0x87DA70", VA = "0x87DA70")]
		public void UpdateRayLine(HoverEnterEventArgs args)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x87DC40", Offset = "0x87DC40", VA = "0x87DC40")]
		public void UpdateRayLine(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x87DE10", Offset = "0x87DE10", VA = "0x87DE10")]
		public void EnableRayLine()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x87DEAC", Offset = "0x87DEAC", VA = "0x87DEAC")]
		public ElysiumRayInteractor()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C3")]
	public class ComponentEntry
	{
		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ComponentName indexName;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ComponentData data;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x87DF04", Offset = "0x87DF04", VA = "0x87DF04")]
		public ComponentEntry()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C4")]
	public class ComponentData
	{
		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string displayName;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform prefab;

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x87DF0C", Offset = "0x87DF0C", VA = "0x87DF0C")]
		public ComponentData()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	[CreateAssetMenu(fileName = "EnvironmentDB", menuName = "ScriptableObjects/EnvironmentDB", order = 1)]
	public class EnvironmentDB : ScriptableObject
	{
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<ComponentEntry> components;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, ComponentName> nameMap;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<ComponentName, ComponentData> componentMap;

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x87DF14", Offset = "0x87DF14", VA = "0x87DF14")]
		public void Init()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x87AC68", Offset = "0x87AC68", VA = "0x87AC68")]
		public ComponentName GetComponentName(string text)
		{
			return default(ComponentName);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x87A0DC", Offset = "0x87A0DC", VA = "0x87A0DC")]
		public Transform GetTransform(ComponentName name)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x87E094", Offset = "0x87E094", VA = "0x87E094")]
		public EnvironmentDB()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class Activity
	{
		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TryerDelegate m_TryStart;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TryerDelegate m_TryStop;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Action m_OnStart;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private System.Action m_OnStop;

		[Token(Token = "0x1700009B")]
		public bool Active
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x87E09C", Offset = "0x87E09C", VA = "0x87E09C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x87E0A4", Offset = "0x87E0A4", VA = "0x87E0A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x87E0B0", Offset = "0x87E0B0", VA = "0x87E0B0")]
		public void AddStartTryer(TryerDelegate tryer)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x87E130", Offset = "0x87E130", VA = "0x87E130")]
		public void RemoveStartTryer(TryerDelegate tryer)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x87E1B0", Offset = "0x87E1B0", VA = "0x87E1B0")]
		public void AddStopTryer(TryerDelegate tryer)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x87E230", Offset = "0x87E230", VA = "0x87E230")]
		public void RemoveStopTryer(TryerDelegate tryer)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x87E2B0", Offset = "0x87E2B0", VA = "0x87E2B0")]
		public void AddStartListener(System.Action listener)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x87E330", Offset = "0x87E330", VA = "0x87E330")]
		public void AddStopListener(System.Action listener)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x87E3B0", Offset = "0x87E3B0", VA = "0x87E3B0")]
		public void ForceStart()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x87E3DC", Offset = "0x87E3DC", VA = "0x87E3DC")]
		public bool TryStart()
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x87E5D8", Offset = "0x87E5D8", VA = "0x87E5D8")]
		public bool TryStop()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x87E7CC", Offset = "0x87E7CC", VA = "0x87E7CC")]
		public void ForceStop()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x87E498", Offset = "0x87E498", VA = "0x87E498")]
		private bool IsApprovedToStart()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x87E68C", Offset = "0x87E68C", VA = "0x87E68C")]
		private bool IsApprovedToStop()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x87E7F4", Offset = "0x87E7F4", VA = "0x87E7F4")]
		public Activity()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class AIEventHandler : EntityEventHandler
	{
		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Value<bool> IsHungry;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Value<float> LastFedTime;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Activity Patrol;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Activity Chase;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Activity Attach;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Activity RunAway;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x87E7FC", Offset = "0x87E7FC", VA = "0x87E7FC")]
		public AIEventHandler()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public delegate bool TryerDelegate();
	[Token(Token = "0x20000C9")]
	public class Attempt
	{
		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TryerDelegate m_Tryer;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.Action m_Listeners;

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x87EC00", Offset = "0x87EC00", VA = "0x87EC00")]
		public void SetTryer(TryerDelegate tryer)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x87EC08", Offset = "0x87EC08", VA = "0x87EC08")]
		public void AddListener(System.Action listener)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x87EC88", Offset = "0x87EC88", VA = "0x87EC88")]
		public void RemoveListener(System.Action listener)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x87ED08", Offset = "0x87ED08", VA = "0x87ED08")]
		public bool Try()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x87ED58", Offset = "0x87ED58", VA = "0x87ED58")]
		public Attempt()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class Attempt<T>
	{
		[Token(Token = "0x20000CB")]
		public delegate bool GenericTryerDelegate(T arg);

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GenericTryerDelegate m_Tryer;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T> m_Listeners;

		[Token(Token = "0x60003FC")]
		public void SetTryer(GenericTryerDelegate tryer)
		{
		}

		[Token(Token = "0x60003FD")]
		public void AddListener(Action<T> listener)
		{
		}

		[Token(Token = "0x60003FE")]
		public void RemoveListener(Action<T> listener)
		{
		}

		[Token(Token = "0x60003FF")]
		public bool Try(T arg)
		{
			return default(bool);
		}

		[Token(Token = "0x6000400")]
		public Attempt()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class EntityEventHandler : MonoBehaviour
	{
		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Value<float> Health;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Attempt<HealthEventData> ChangeHealth;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Value<Vector3> Velocity;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AIMessage<GameObject> Death;

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x87E944", Offset = "0x87E944", VA = "0x87E944")]
		public EntityEventHandler()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class HealthEventData
	{
		[Token(Token = "0x1700009C")]
		public float Delta
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x87ED60", Offset = "0x87ED60", VA = "0x87ED60")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x87ED68", Offset = "0x87ED68", VA = "0x87ED68")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public EntityEventHandler Damager
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x87ED70", Offset = "0x87ED70", VA = "0x87ED70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x87ED78", Offset = "0x87ED78", VA = "0x87ED78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public Vector3 HitPoint
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x87ED80", Offset = "0x87ED80", VA = "0x87ED80")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x87ED8C", Offset = "0x87ED8C", VA = "0x87ED8C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public Vector3 HitDirection
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x87ED98", Offset = "0x87ED98", VA = "0x87ED98")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x87EDA4", Offset = "0x87EDA4", VA = "0x87EDA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public float HitImpulse
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x87EDB0", Offset = "0x87EDB0", VA = "0x87EDB0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x87EDB8", Offset = "0x87EDB8", VA = "0x87EDB8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x87EDC0", Offset = "0x87EDC0", VA = "0x87EDC0")]
		public HealthEventData(float delta, [Optional] EntityEventHandler damager, [Optional] Vector3 hitPoint, [Optional] Vector3 hitDirection, float hitImpulse = 0f)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class InteractionEventData
	{
		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int ObjId;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ObjName;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PrefabName ObjType;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string interactor;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string msgType;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameDate Timestamp;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public GameDate StartTime;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameDate EndTime;

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x87EE3C", Offset = "0x87EE3C", VA = "0x87EE3C")]
		public InteractionEventData()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class InteractionEventHandler : MonoBehaviour
	{
		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string EVENT_TYPE_NAME_INTERACTION;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string EVENT_TYPE_NAME_CLIMBING;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string EVENT_TYPE_NAME_SYNTHESIS;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string EVENT_TYPE_NAME_WATERING;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string EVENT_TYPE_NAME_FISHING;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string EVENT_TYPE_NAME_HUNTING;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string EVENT_TYPE_NAME_BAKING;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string EVENT_TYPE_NAME_PLANTING;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string EVENT_TYPE_NAME_EATING;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string EVENT_TYPE_NAME_SAVING;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string EVENT_TYPE_NAME_SLEEP;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AIMessage<InteractionEventData> interaction_;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private XRBaseInteractable m_Interactable;

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x87EE44", Offset = "0x87EE44", VA = "0x87EE44")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x87EEB8", Offset = "0x87EEB8", VA = "0x87EEB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x87EFD8", Offset = "0x87EFD8", VA = "0x87EFD8")]
		private void OnSelectEntered(SelectEnterEventArgs arg0)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x87F048", Offset = "0x87F048", VA = "0x87F048")]
		private InteractionEventData GetMessageData(string interactor, string type)
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x87F230", Offset = "0x87F230", VA = "0x87F230")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x87F320", Offset = "0x87F320", VA = "0x87F320")]
		private void Start()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x87F324", Offset = "0x87F324", VA = "0x87F324")]
		public void RecordSleepEvent(string interactor)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x87F39C", Offset = "0x87F39C", VA = "0x87F39C")]
		public void RecordSaveEvent(string interactor)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x87F414", Offset = "0x87F414", VA = "0x87F414")]
		public void RecordInteractionEvent(string interactor)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x87F48C", Offset = "0x87F48C", VA = "0x87F48C")]
		public void RecordClimbEvent(string interactor)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x87F504", Offset = "0x87F504", VA = "0x87F504")]
		public void RecordSynthesisEvent(string interactor)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x87F57C", Offset = "0x87F57C", VA = "0x87F57C")]
		public void RecordWateringEvent(string interactor)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x87F5F4", Offset = "0x87F5F4", VA = "0x87F5F4")]
		public void RecordFishingEvent(string interactor)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x87F66C", Offset = "0x87F66C", VA = "0x87F66C")]
		public void RecordHuntingEvent(string interactor)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x87F6E4", Offset = "0x87F6E4", VA = "0x87F6E4")]
		public void RecordBakingEvent(string interactor)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x87F75C", Offset = "0x87F75C", VA = "0x87F75C")]
		public void RecordPlantingEvent(string interactor)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x87F7D4", Offset = "0x87F7D4", VA = "0x87F7D4")]
		public void RecordEatingEvent(string interactor)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x87F19C", Offset = "0x87F19C", VA = "0x87F19C")]
		public void SendMessage(InteractionEventData message)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x87F84C", Offset = "0x87F84C", VA = "0x87F84C")]
		public InteractionEventHandler()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class AIMessage
	{
		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private System.Action m_Listeners;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x87FA04", Offset = "0x87FA04", VA = "0x87FA04")]
		public void AddListener(System.Action listener)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x87FA84", Offset = "0x87FA84", VA = "0x87FA84")]
		public void RemoveListener(System.Action listener)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x87FB04", Offset = "0x87FB04", VA = "0x87FB04")]
		public void Send()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x87FB20", Offset = "0x87FB20", VA = "0x87FB20")]
		public AIMessage()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class AIMessage<T>
	{
		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T> m_Listeners;

		[Token(Token = "0x600042A")]
		public void AddListener(Action<T> listener)
		{
		}

		[Token(Token = "0x600042B")]
		public void RemoveListener(Action<T> listener)
		{
		}

		[Token(Token = "0x600042C")]
		public void Send(T msg)
		{
		}

		[Token(Token = "0x600042D")]
		public AIMessage()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class Value<T>
	{
		[Token(Token = "0x20000D3")]
		public delegate T Filter(T lastValue, T newValue);

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private System.Action m_Set;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Filter m_Filter;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T m_CurrentValue;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T m_LastValue;

		[Token(Token = "0x600042E")]
		public Value(T initialValue)
		{
		}

		[Token(Token = "0x600042F")]
		public bool Is(T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000430")]
		public void AddChangeListener(System.Action callback)
		{
		}

		[Token(Token = "0x6000431")]
		public void RemoveChangeListener(System.Action callback)
		{
		}

		[Token(Token = "0x6000432")]
		public void SetFilter(Filter filter)
		{
		}

		[Token(Token = "0x6000433")]
		public T Get()
		{
			return (T)null;
		}

		[Token(Token = "0x6000434")]
		public T GetLastValue()
		{
			return (T)null;
		}

		[Token(Token = "0x6000435")]
		public void Set(T value)
		{
		}

		[Token(Token = "0x6000436")]
		public void SetAndForceUpdate(T value)
		{
		}

		[Token(Token = "0x6000437")]
		public void SetAndDontUpdate(T value)
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class FilePrefabSet : IPrefabSet
	{
		[Token(Token = "0x20000D5")]
		private class DiskPrefabFileInfo : IPrefabFileInfo
		{
			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string m_DisplayName;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string m_FullPath;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private string m_AssetId;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private DateTime m_CreationTime;

			[Token(Token = "0x170000A2")]
			public PrefabFileType InfoType
			{
				[Token(Token = "0x6000440")]
				[Address(RVA = "0x87FBB8", Offset = "0x87FBB8", VA = "0x87FBB8", Slot = "4")]
				get
				{
					return default(PrefabFileType);
				}
			}

			[Token(Token = "0x170000A3")]
			public string DisplayName
			{
				[Token(Token = "0x6000441")]
				[Address(RVA = "0x87FBC0", Offset = "0x87FBC0", VA = "0x87FBC0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			public string FullPath
			{
				[Token(Token = "0x6000442")]
				[Address(RVA = "0x87FBC8", Offset = "0x87FBC8", VA = "0x87FBC8", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A5")]
			public bool Valid
			{
				[Token(Token = "0x6000443")]
				[Address(RVA = "0x87FBD0", Offset = "0x87FBD0", VA = "0x87FBD0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A6")]
			public bool Available
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x87FBE0", Offset = "0x87FBE0", VA = "0x87FBE0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A7")]
			public string AssetId
			{
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x87FBE8", Offset = "0x87FBE8", VA = "0x87FBE8", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000446")]
			[Address(RVA = "0x87FBF0", Offset = "0x87FBF0", VA = "0x87FBF0")]
			public void DiskPrefabFileIno(string fullpath)
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x87FC6C", Offset = "0x87FC6C", VA = "0x87FC6C", Slot = "10")]
			public Stream GetReadStream(string subfileName)
			{
				return null;
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x87FD9C", Offset = "0x87FD9C", VA = "0x87FD9C")]
			public DiskPrefabFileInfo()
			{
			}
		}

		[Token(Token = "0x20000D6")]
		private class FilePrefab : IPrefabItem, IComparable<FilePrefab>
		{
			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private IPrefabFileInfo m_FileInfo;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Texture2D m_Icon;

			[Token(Token = "0x170000A8")]
			public IPrefabFileInfo FileInfo
			{
				[Token(Token = "0x6000449")]
				[Address(RVA = "0x87FDA4", Offset = "0x87FDA4", VA = "0x87FDA4", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			public Texture2D Icon
			{
				[Token(Token = "0x600044A")]
				[Address(RVA = "0x87FDAC", Offset = "0x87FDAC", VA = "0x87FDAC", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x87FDB4", Offset = "0x87FDB4", VA = "0x87FDB4", Slot = "6")]
			public int CompareTo(FilePrefab other)
			{
				return default(int);
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x8800C8", Offset = "0x8800C8", VA = "0x8800C8")]
			public FilePrefab()
			{
			}
		}

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PrefabSetType m_Type;

		[Token(Token = "0x170000A1")]
		public PrefabSetType Type
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x87FB28", Offset = "0x87FB28", VA = "0x87FB28", Slot = "4")]
			get
			{
				return default(PrefabSetType);
			}
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x87FB30", Offset = "0x87FB30", VA = "0x87FB30", Slot = "5")]
		public void Init()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x87FB70", Offset = "0x87FB70", VA = "0x87FB70", Slot = "6")]
		public void Update()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x87FBB0", Offset = "0x87FBB0", VA = "0x87FBB0")]
		public FilePrefabSet()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class GameMgr : MonoBehaviour
	{
		[Token(Token = "0x20000D8")]
		[CompilerGenerated]
		private sealed class <StartLoading>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string scene;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameMgr <>4__this;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <displayProgress>5__2;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <toProgress>5__3;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AsyncOperation <op>5__4;

			[Token(Token = "0x170000AA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600045C")]
				[Address(RVA = "0x880968", Offset = "0x880968", VA = "0x880968", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x8809B0", Offset = "0x8809B0", VA = "0x8809B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x8805C4", Offset = "0x8805C4", VA = "0x8805C4")]
			[DebuggerHidden]
			public <StartLoading>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x880798", Offset = "0x880798", VA = "0x880798", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x88079C", Offset = "0x88079C", VA = "0x88079C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x880970", Offset = "0x880970", VA = "0x880970", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000D9")]
		[CompilerGenerated]
		private struct <CreateSession>d__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameMgr <>4__this;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x8809B8", Offset = "0x8809B8", VA = "0x8809B8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x880E8C", Offset = "0x880E8C", VA = "0x880E8C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject menuEnv;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject menuCanvas;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject progressCanvas;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Image progressBar;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TMP_Text progressText;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public bool IsSceneLoaded;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static GameMgr Instance;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string sceneName;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string tutorialName;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private XROrigin xrOrigin;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_IsTutorial;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Camera mainCamera;

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x8800D0", Offset = "0x8800D0", VA = "0x8800D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x88012C", Offset = "0x88012C", VA = "0x88012C")]
		private void Start()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x880178", Offset = "0x880178", VA = "0x880178")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x8801CC", Offset = "0x8801CC", VA = "0x8801CC")]
		public void ContinueGame()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x8803C4", Offset = "0x8803C4", VA = "0x8803C4")]
		public void NewGame(int difficulty)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x8804CC", Offset = "0x8804CC", VA = "0x8804CC")]
		public void NewTutorial()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x8805BC", Offset = "0x8805BC", VA = "0x8805BC")]
		public void QuitGame()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x880350", Offset = "0x880350", VA = "0x880350")]
		[IteratorStateMachine(typeof(<StartLoading>d__19))]
		private IEnumerator StartLoading(string scene)
		{
			return null;
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x8805EC", Offset = "0x8805EC", VA = "0x8805EC")]
		private void SetLoadingPercentage(int displayProgress)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x8802BC", Offset = "0x8802BC", VA = "0x8802BC")]
		[AsyncStateMachine(typeof(<CreateSession>d__21))]
		private void CreateSession()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x880698", Offset = "0x880698", VA = "0x880698")]
		private void OnCreateOverviewRecord(WebRequest.Reply reply)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x880748", Offset = "0x880748", VA = "0x880748")]
		public GameMgr()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class AmbienceController : MonoBehaviour
	{
		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AmbienceController s_Instance;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Setup")]
		[SerializeField]
		private AudioSource m_DayAudioSrc;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource m_NightAudioSrc;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Ambience Volume")]
		[SerializeField]
		private AnimationCurve m_DayVolCurve;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_DayVolFactor;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve m_NightVolCurve;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_NightVolFactor;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioSource[] otherEnvSounds;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] originVolume;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float coeff;

		[Token(Token = "0x170000AC")]
		public static AmbienceController Instance
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x880E98", Offset = "0x880E98", VA = "0x880E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x880EE0", Offset = "0x880EE0", VA = "0x880EE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x880FBC", Offset = "0x880FBC", VA = "0x880FBC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x881038", Offset = "0x881038", VA = "0x881038")]
		private void Update()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x881134", Offset = "0x881134", VA = "0x881134")]
		public void UpdateAmbienceVolume(float volume)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x8811C4", Offset = "0x8811C4", VA = "0x8811C4")]
		public AmbienceController()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[CreateAssetMenu(fileName = "AnimalSpawnConfig", menuName = "ScriptableObjects/AnimalSpawnConfig", order = 1)]
	public class AnimalSpawnConfig : ScriptableObject
	{
		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Tag;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SpawnInterval;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int MaxCount;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] Prefabs;

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x8811DC", Offset = "0x8811DC", VA = "0x8811DC")]
		public AnimalSpawnConfig()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class AnimalSpawner : MonoBehaviour
	{
		[Token(Token = "0x40005A9")]
		public const string SPAWN_POINT_TAG = "Spawn Point";

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimalSpawnConfig m_AnimalConfig;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_ActiveLevel;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_RemoveAnimalWhenKilled;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject[] m_Prefabs;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject[] m_SpawnPoints;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_LastSpawnPoint;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string m_SpawnPointTag;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_SpawnInterval;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_MaxCount;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Enabled;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool m_IsFirtTime;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_NextSpawnTime;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<GameObject> m_AliveAnimals;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x8811E4", Offset = "0x8811E4", VA = "0x8811E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x881320", Offset = "0x881320", VA = "0x881320")]
		private void Update()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x881470", Offset = "0x881470", VA = "0x881470")]
		private void Spawn()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x8818C4", Offset = "0x8818C4", VA = "0x8818C4")]
		public void RemoveAnimal(GameObject go)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x881974", Offset = "0x881974", VA = "0x881974")]
		public AnimalSpawner()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class Arrow : XRGrabInteractable
	{
		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		[Header("Settings")]
		public float speed;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		[Header("Hit")]
		public int damage;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		public Transform tip;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public LayerMask layerMask;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private Collider collider;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		private bool launched;

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x881984", Offset = "0x881984", VA = "0x881984", Slot = "47")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x881A0C", Offset = "0x881A0C", VA = "0x881A0C", Slot = "65")]
		protected override void OnSelectEntering(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x881AB8", Offset = "0x881AB8", VA = "0x881AB8")]
		private void Clear()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x881B58", Offset = "0x881B58", VA = "0x881B58", Slot = "68")]
		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x881C04", Offset = "0x881C04", VA = "0x881C04")]
		private void Launch(Notch notch)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x881AD8", Offset = "0x881AD8", VA = "0x881AD8")]
		private void SetLaunch(bool value)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x881C70", Offset = "0x881C70", VA = "0x881C70")]
		private void UpdateLastPosition()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x881CA0", Offset = "0x881CA0", VA = "0x881CA0")]
		private void ApplyForce(PullMeasurer pullMeasurer)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x881CF8", Offset = "0x881CF8", VA = "0x881CF8", Slot = "58")]
		public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x881EB0", Offset = "0x881EB0", VA = "0x881EB0")]
		private void SetDirection()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x881D60", Offset = "0x881D60", VA = "0x881D60")]
		private bool CheckForCollision()
		{
			return default(bool);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x881B10", Offset = "0x881B10", VA = "0x881B10")]
		private void TogglePhysics(bool value)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x881F18", Offset = "0x881F18", VA = "0x881F18")]
		private void ChildArrow(RaycastHit hit)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x881FC8", Offset = "0x881FC8", VA = "0x881FC8")]
		private void CheckForHittable(RaycastHit hit)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x8820F8", Offset = "0x8820F8", VA = "0x8820F8")]
		public Arrow()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class Attacker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DF")]
		public class AttackEvent : UnityEvent
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x88293C", Offset = "0x88293C", VA = "0x88293C")]
			public AttackEvent()
			{
			}
		}

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AttackEvent onAttack;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int damage;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LineRenderer rayIndicator;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rayDemolishingRange;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BuildItem currentBuildItem;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PrefabName attackerName;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private XRGrabbable grabbable;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private XRBaseInteractor interactor;

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x8821AC", Offset = "0x8821AC", VA = "0x8821AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x882274", Offset = "0x882274", VA = "0x882274")]
		private void Update()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x882734", Offset = "0x882734", VA = "0x882734")]
		public int Attack()
		{
			return default(int);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x882520", Offset = "0x882520", VA = "0x882520")]
		private void ShowRayIndicator(Vector3 from, Vector3 to)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x88268C", Offset = "0x88268C", VA = "0x88268C")]
		private void HideRayIndicator()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x882758", Offset = "0x882758", VA = "0x882758")]
		public void OnTriggerPerformed()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x88292C", Offset = "0x88292C", VA = "0x88292C")]
		public Attacker()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class BagController : MonoBehaviour
	{
		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip bagSound;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The reference to Open Bag.")]
		[SerializeField]
		private InputActionReference m_OpenBag;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isOpened;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject bag;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject bagContent;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform bagFrontAnchor;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform bagBackAnchor;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform playerAnchor;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Collider bagCollider;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Collider colliderInBackpack;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<string> itemIds;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x882944", Offset = "0x882944", VA = "0x882944")]
		private void Start()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x882CA0", Offset = "0x882CA0", VA = "0x882CA0")]
		private void OnOpenBagPerformed(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x882CB8", Offset = "0x882CB8", VA = "0x882CB8")]
		public void CloseBag()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x882AB0", Offset = "0x882AB0", VA = "0x882AB0")]
		public void EnableBag(bool active)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x882D74", Offset = "0x882D74", VA = "0x882D74")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x882A2C", Offset = "0x882A2C", VA = "0x882A2C")]
		private InputAction GetInputAction(InputActionReference actionReference)
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x882E0C", Offset = "0x882E0C", VA = "0x882E0C")]
		public void DisplayContent()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x882E58", Offset = "0x882E58", VA = "0x882E58")]
		public void OnReleased(Transform bag)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x883114", Offset = "0x883114", VA = "0x883114")]
		private void AdjustPose(Transform bag)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x883148", Offset = "0x883148", VA = "0x883148")]
		public void HandleObjectIn(Collider other)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x8835A0", Offset = "0x8835A0", VA = "0x8835A0")]
		public BagController()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class Bakable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E2")]
		public class DamageEvent : UnityEvent<int>
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x883870", Offset = "0x883870", VA = "0x883870")]
			public DamageEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E3")]
		public class InFireEvent : UnityEvent
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x8838B8", Offset = "0x8838B8", VA = "0x8838B8")]
			public InFireEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public class OutFireEvent : UnityEvent
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x8838C0", Offset = "0x8838C0", VA = "0x8838C0")]
			public OutFireEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public class InteractionEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x8838C8", Offset = "0x8838C8", VA = "0x8838C8")]
			public InteractionEvent()
			{
			}
		}

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int experienceValue;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int damage;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ConsumeCycle;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_ElapsedTime;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DamageEvent onDamage;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InFireEvent InBaking;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public OutFireEvent OutBaking;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent onInteraction;

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x8835A8", Offset = "0x8835A8", VA = "0x8835A8")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x8836BC", Offset = "0x8836BC", VA = "0x8836BC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x8837AC", Offset = "0x8837AC", VA = "0x8837AC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x883854", Offset = "0x883854", VA = "0x883854")]
		public Bakable()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class BambooPole : MonoBehaviour
	{
		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<GameObject> stabbedObjects;

		[Token(Token = "0x170000AD")]
		public List<GameObject> StabbedObjects
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x883910", Offset = "0x883910", VA = "0x883910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x883918", Offset = "0x883918", VA = "0x883918")]
		private void Start()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x88398C", Offset = "0x88398C", VA = "0x88398C")]
		public void AddStabbedObject(GameObject obj)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x883A98", Offset = "0x883A98", VA = "0x883A98")]
		public BambooPole()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class AnchorTranslator : MonoBehaviour
	{
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private XRBaseInteractable grabbable;

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x883AA0", Offset = "0x883AA0", VA = "0x883AA0")]
		private void Start()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x883AF0", Offset = "0x883AF0", VA = "0x883AF0")]
		public void TranslateAnchor(float directionAmount)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x883BB4", Offset = "0x883BB4", VA = "0x883BB4")]
		public AnchorTranslator()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class BackpackController : ItemStorer
	{
		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static BackpackController Instance;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Sprite focused;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Sprite normal;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Image image;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bounds m_Bounds;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<int> onStoreItem;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<int> onTakeItem;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<XRBaseInteractable, InputAction> interactions;

		[Token(Token = "0x170000AE")]
		public Bounds Bounds
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x883BBC", Offset = "0x883BBC", VA = "0x883BBC")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x883C7C", Offset = "0x883C7C", VA = "0x883C7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x883DE0", Offset = "0x883DE0", VA = "0x883DE0")]
		internal void SetFocus(bool focused, IUIInteractor interactor)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x884108", Offset = "0x884108", VA = "0x884108")]
		private void UnregisterAction(XRBaseInteractor interactor)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x883E84", Offset = "0x883E84", VA = "0x883E84")]
		private void RegisterAction(XRBaseInteractor interactor)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x88443C", Offset = "0x88443C", VA = "0x88443C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x884728", Offset = "0x884728", VA = "0x884728")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x88478C", Offset = "0x88478C", VA = "0x88478C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x884440", Offset = "0x884440", VA = "0x884440")]
		private void Init()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x884940", Offset = "0x884940", VA = "0x884940")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x884CF4", Offset = "0x884CF4", VA = "0x884CF4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x8841DC", Offset = "0x8841DC", VA = "0x8841DC")]
		private void UnRegister(InputAction action)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x8850D4", Offset = "0x8850D4", VA = "0x8850D4")]
		private void Store(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x8854A0", Offset = "0x8854A0", VA = "0x8854A0", Slot = "4")]
		public override bool StoreItem(PrefabName itemName, int durability)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x8857C4", Offset = "0x8857C4", VA = "0x8857C4")]
		public bool RemoveItem(PrefabName itemName, bool isNew = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x885A38", Offset = "0x885A38", VA = "0x885A38", Slot = "5")]
		public override bool RemoveItem(StoredItem item)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x885C90", Offset = "0x885C90", VA = "0x885C90")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x885EA8", Offset = "0x885EA8", VA = "0x885EA8")]
		public BackpackController()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class BackpackItem : StoredItem
	{
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x885EB0", Offset = "0x885EB0", VA = "0x885EB0", Slot = "5")]
		protected override void UpdateData(ItemStorer controller, PrefabName itemName)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x885FB8", Offset = "0x885FB8", VA = "0x885FB8")]
		public BackpackItem()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class BackpackItemButton : Selectable
	{
		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public StoredItem storedItem;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x885FC0", Offset = "0x885FC0", VA = "0x885FC0", Slot = "34")]
		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x88612C", Offset = "0x88612C", VA = "0x88612C", Slot = "35")]
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x886254", Offset = "0x886254", VA = "0x886254")]
		public BackpackItemButton()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class BookController : MonoBehaviour
	{
		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The reference to Open Book.")]
		[FormerlySerializedAs("Open Book")]
		[SerializeField]
		private InputActionReference m_OpenBook;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The reference to Open Menu.")]
		[FormerlySerializedAs("Open Menu")]
		[SerializeField]
		private InputActionReference m_OpenMenu;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isOpened;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject book;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject menu;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject save;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static System.Action openBook;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform anchor;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform pocketAnchor;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject bookContent;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioClip openBookSound;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Collider bookCollider;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Collider colliderInPocket;

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x8862AC", Offset = "0x8862AC", VA = "0x8862AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x886BF0", Offset = "0x886BF0", VA = "0x886BF0")]
		private void OnOpenMenuPerformed(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x886440", Offset = "0x886440", VA = "0x886440")]
		public void EnableBook(bool active)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x886850", Offset = "0x886850", VA = "0x886850")]
		public void EnableMenu(bool active)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x886C28", Offset = "0x886C28", VA = "0x886C28")]
		public void OpenSaveCanvas()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x886CF0", Offset = "0x886CF0", VA = "0x886CF0")]
		public void BackMenu()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x886D28", Offset = "0x886D28", VA = "0x886D28")]
		private void OnOpenBookPerformed(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x886DAC", Offset = "0x886DAC", VA = "0x886DAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x8863BC", Offset = "0x8863BC", VA = "0x8863BC")]
		private InputAction GetInputAction(InputActionReference actionReference)
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x886EA4", Offset = "0x886EA4", VA = "0x886EA4")]
		public void AdjustPose(Transform book)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x886ED8", Offset = "0x886ED8", VA = "0x886ED8")]
		public void OnReleased(Transform book)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x88715C", Offset = "0x88715C", VA = "0x88715C")]
		public void DisplayContent()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x887220", Offset = "0x887220", VA = "0x887220")]
		public void CloseBook()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x8872DC", Offset = "0x8872DC", VA = "0x8872DC")]
		public BookController()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class BookMenu : MonoBehaviour
	{
		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject mainMenu;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject lastMenu;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] menus;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<string> onMenuOpened;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x8872E4", Offset = "0x8872E4", VA = "0x8872E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x8874B8", Offset = "0x8874B8", VA = "0x8874B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x887360", Offset = "0x887360", VA = "0x887360")]
		public void ShowMenu(GameObject menu)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x88751C", Offset = "0x88751C", VA = "0x88751C")]
		public BookMenu()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class ItemDetails : MonoBehaviour
	{
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Button recipeButton;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image recipeImage;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SynthesisRecipeSetting recipe;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TMP_Text itemName;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TMP_Text levelNum;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Image statusImage;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Image icon;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TMP_Text description;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Button synthesisButton;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public RecipeItem[] items;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TMP_Text message;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color inactiveColor;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<PrefabName> itemClicked;

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x887524", Offset = "0x887524", VA = "0x887524")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x8876E0", Offset = "0x8876E0", VA = "0x8876E0")]
		public void UpdateRecipe(SynthesisRecipeSetting recipe)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x887AB8", Offset = "0x887AB8", VA = "0x887AB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x887BB8", Offset = "0x887BB8", VA = "0x887BB8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x88765C", Offset = "0x88765C", VA = "0x88765C")]
		private StorableItemInfo GetItemInfo(PrefabName itemName)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x887CB8", Offset = "0x887CB8", VA = "0x887CB8")]
		private void RefreshTotalNum(int type, int durability)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x88817C", Offset = "0x88817C", VA = "0x88817C")]
		private void DisableAll(RecipeItem[] items)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x8881EC", Offset = "0x8881EC", VA = "0x8881EC")]
		public void OnItemClicked()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x887D74", Offset = "0x887D74", VA = "0x887D74")]
		private void UpdateIngredientsInfo()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x888594", Offset = "0x888594", VA = "0x888594")]
		public ItemDetails()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class RecipeCategory : MonoBehaviour
	{
		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SynthesisRecipeType category;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ItemDetails[] items;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SynthesisManager synthesisManager;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int currentCategory;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x8885A8", Offset = "0x8885A8", VA = "0x8885A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x888808", Offset = "0x888808", VA = "0x888808")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x888A68", Offset = "0x888A68", VA = "0x888A68")]
		private void UpdateRecipeStatus(int prefabName)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x888C9C", Offset = "0x888C9C", VA = "0x888C9C")]
		private void UpdateStatus(int prefabName, int durability)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x888CA0", Offset = "0x888CA0", VA = "0x888CA0")]
		private void DisableAll()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x888D10", Offset = "0x888D10", VA = "0x888D10")]
		public void ChangeCategory(int category)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x888A6C", Offset = "0x888A6C", VA = "0x888A6C")]
		public void UpdateItems()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x888ECC", Offset = "0x888ECC", VA = "0x888ECC")]
		public RecipeCategory()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class RecipeItem : MonoBehaviour
	{
		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_Text itemName;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_Text totalNum;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_Text needNum;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Image icon;

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x888320", Offset = "0x888320", VA = "0x888320")]
		public void SetItemInfo(IngredientInfo ingredient)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x888ED4", Offset = "0x888ED4", VA = "0x888ED4")]
		private StorableItemInfo GetItemInfo(PrefabName itemName)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x888F58", Offset = "0x888F58", VA = "0x888F58")]
		public RecipeItem()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class SubCategoryController : MonoBehaviour
	{
		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform frontImage;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Button[] categories;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Button previousButton;

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x888F60", Offset = "0x888F60", VA = "0x888F60")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x889040", Offset = "0x889040", VA = "0x889040")]
		public void HighlightCategory(Transform button)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x8890FC", Offset = "0x8890FC", VA = "0x8890FC")]
		internal void Reset()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x889180", Offset = "0x889180", VA = "0x889180")]
		public SubCategoryController()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class TabController : MonoBehaviour
	{
		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform buttonParent;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform frontImage;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Button[] categories;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SubCategoryController subCategory;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Button previousButton;

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x889188", Offset = "0x889188", VA = "0x889188")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x889268", Offset = "0x889268", VA = "0x889268")]
		public void HighlightCategory(Transform button)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x889364", Offset = "0x889364", VA = "0x889364")]
		public TabController()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class Bow : XRGrabInteractable
	{
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private Notch notch;

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x88936C", Offset = "0x88936C", VA = "0x88936C", Slot = "47")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x8893C8", Offset = "0x8893C8", VA = "0x8893C8", Slot = "48")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x8894E4", Offset = "0x8894E4", VA = "0x8894E4", Slot = "49")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x889600", Offset = "0x889600", VA = "0x889600")]
		public Bow()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class BuildItem : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F4")]
		public class AttackEvent : UnityEvent<int>
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x88A148", Offset = "0x88A148", VA = "0x88A148")]
			public AttackEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F5")]
		public class BuildEvent : UnityEvent
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x88A190", Offset = "0x88A190", VA = "0x88A190")]
			public BuildEvent()
			{
			}
		}

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AttackEvent onAttacked;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BuildEvent onBuild;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int experienceValue;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip attackSound;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Image icon;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool IsGrabbable;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool demolishable;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 placedPos;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion placedRotation;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool isFixed;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool isReady;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float lastTime;

		[Token(Token = "0x170000AF")]
		private Rigidbody rb
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x889658", Offset = "0x889658", VA = "0x889658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		private XRGrabInteractable interactable
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x8896A0", Offset = "0x8896A0", VA = "0x8896A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x8896E8", Offset = "0x8896E8", VA = "0x8896E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x8896EC", Offset = "0x8896EC", VA = "0x8896EC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x889ACC", Offset = "0x889ACC", VA = "0x889ACC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x889EA8", Offset = "0x889EA8", VA = "0x889EA8")]
		public void SetFixed()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x889FC0", Offset = "0x889FC0", VA = "0x889FC0")]
		public bool ReturnToLastPos()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x88A0BC", Offset = "0x88A0BC", VA = "0x88A0BC")]
		public void SetDelayedReady(float sec)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x88A124", Offset = "0x88A124", VA = "0x88A124")]
		public void SetReady()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x882820", Offset = "0x882820", VA = "0x882820")]
		public void TakeDamage(int damage)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x88A130", Offset = "0x88A130", VA = "0x88A130")]
		public BuildItem()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class CavePortal : MonoBehaviour
	{
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x88A198", Offset = "0x88A198", VA = "0x88A198")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x88A24C", Offset = "0x88A24C", VA = "0x88A24C")]
		public CavePortal()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class Chest : MonoBehaviour
	{
		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Collider locker;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject content;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip prizeSound;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 rotateAxis;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[HideInInspector]
		public bool isOpen;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChestController controller;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 startPos;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x88A254", Offset = "0x88A254", VA = "0x88A254")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x88A274", Offset = "0x88A274", VA = "0x88A274")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x88A374", Offset = "0x88A374", VA = "0x88A374")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x88A278", Offset = "0x88A278", VA = "0x88A278")]
		public void OpenChest()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x88A488", Offset = "0x88A488", VA = "0x88A488")]
		private void DisplayContent()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x88A564", Offset = "0x88A564", VA = "0x88A564")]
		public Chest()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class ChestController : ItemStorer
	{
		[Serializable]
		[Token(Token = "0x20000F9")]
		public class ChestData
		{
			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isOpen;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 position;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotation;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BagItemInfo[] Items;

			[Token(Token = "0x600050B")]
			[Address(RVA = "0x88A6A8", Offset = "0x88A6A8", VA = "0x88A6A8")]
			public ChestData(int len = 12)
			{
			}
		}

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BoxContainerType type;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<int> onStoreItem;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public PrefabName[] initialDatas;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_IsRegistered;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string m_PlayerPrefKey;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ChestData m_Data;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<string> itemIds;

		[Token(Token = "0x170000B1")]
		public bool IsRegistered
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x88A5C4", Offset = "0x88A5C4", VA = "0x88A5C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x88A5CC", Offset = "0x88A5CC", VA = "0x88A5CC")]
			set
			{
			}
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x88A5D8", Offset = "0x88A5D8", VA = "0x88A5D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x88A710", Offset = "0x88A710", VA = "0x88A710")]
		private void Start()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x88A92C", Offset = "0x88A92C", VA = "0x88A92C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x88A98C", Offset = "0x88A98C", VA = "0x88A98C")]
		public void HandleObjectIn(Collider other)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x88B0F0", Offset = "0x88B0F0", VA = "0x88B0F0", Slot = "4")]
		public override bool StoreItem(PrefabName itemName, int durability)
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x88B34C", Offset = "0x88B34C", VA = "0x88B34C", Slot = "5")]
		public override bool RemoveItem(StoredItem item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x88B53C", Offset = "0x88B53C", VA = "0x88B53C")]
		public string Serialize()
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x88B6B4", Offset = "0x88B6B4", VA = "0x88B6B4")]
		public bool Deserialize(string jstr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x88A4B8", Offset = "0x88A4B8", VA = "0x88A4B8")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x88A810", Offset = "0x88A810", VA = "0x88A810")]
		private void Init()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x88B854", Offset = "0x88B854", VA = "0x88B854")]
		private ChestData GenerateInitialData()
		{
			return null;
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x88B27C", Offset = "0x88B27C", VA = "0x88B27C")]
		private new int GetStorableIndex(PrefabName itemName, int durability)
		{
			return default(int);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x88B950", Offset = "0x88B950", VA = "0x88B950")]
		public ChestController()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class ChestItem : StoredItem
	{
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x88B9E0", Offset = "0x88B9E0", VA = "0x88B9E0", Slot = "5")]
		protected override void UpdateData(ItemStorer controller, PrefabName itemName)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x88BA80", Offset = "0x88BA80", VA = "0x88BA80")]
		public ChestItem()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class ClimbController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FC")]
		public class InteractionEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x88C33C", Offset = "0x88C33C", VA = "0x88C33C")]
			public InteractionEvent()
			{
			}
		}

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip ouch;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 originPos;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private XRDirectInteractor currentInteractor;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isClimbing;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool isStartClimbing;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 currentPos;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 hitPoint;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float releaseTime;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isReleased;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float offset_;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float accelerate_;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float offsetRef_;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float distanceRef_;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float threshold_;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionEvent onInteraction;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CharacterController character;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ActionBasedContinuousMoveProvider continuousMove;

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x88BA88", Offset = "0x88BA88", VA = "0x88BA88")]
		private void Start()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x88BB04", Offset = "0x88BB04", VA = "0x88BB04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x88BD20", Offset = "0x88BD20", VA = "0x88BD20")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x88BBF4", Offset = "0x88BBF4", VA = "0x88BBF4")]
		private void FallDown()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x88BFFC", Offset = "0x88BFFC", VA = "0x88BFFC")]
		public void Climb(XRDirectInteractor interactor)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x88BE24", Offset = "0x88BE24", VA = "0x88BE24")]
		private void UpdateHeight()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x88C270", Offset = "0x88C270", VA = "0x88C270")]
		public void Release(XRDirectInteractor interactor)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x88C1E4", Offset = "0x88C1E4", VA = "0x88C1E4")]
		private void EnableTips(bool enabled, XRDirectInteractor interactor)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x88C318", Offset = "0x88C318", VA = "0x88C318")]
		public void StopClimbing()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x88C320", Offset = "0x88C320", VA = "0x88C320")]
		public bool IsStartClimbing()
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x88C328", Offset = "0x88C328", VA = "0x88C328")]
		public ClimbController()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class ClimbDown : MonoBehaviour
	{
		[Token(Token = "0x20000FE")]
		[CompilerGenerated]
		private sealed class <Grab>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ClimbDown <>4__this;

			[Token(Token = "0x170000B2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000523")]
				[Address(RVA = "0x88C678", Offset = "0x88C678", VA = "0x88C678", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000525")]
				[Address(RVA = "0x88C6C0", Offset = "0x88C6C0", VA = "0x88C6C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000520")]
			[Address(RVA = "0x88C5C8", Offset = "0x88C5C8", VA = "0x88C5C8")]
			[DebuggerHidden]
			public <Grab>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0x88C604", Offset = "0x88C604", VA = "0x88C604", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000522")]
			[Address(RVA = "0x88C608", Offset = "0x88C608", VA = "0x88C608", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0x88C680", Offset = "0x88C680", VA = "0x88C680", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRBaseInteractable interactable;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform startPoint;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private XRBaseInteractor interactor;

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x88C384", Offset = "0x88C384", VA = "0x88C384")]
		private void Start()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x88C388", Offset = "0x88C388", VA = "0x88C388")]
		private void Update()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x88C38C", Offset = "0x88C38C", VA = "0x88C38C")]
		public void StartClimbDown(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x88C560", Offset = "0x88C560", VA = "0x88C560")]
		[IteratorStateMachine(typeof(<Grab>d__6))]
		private IEnumerator Grab()
		{
			return null;
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x88C5F0", Offset = "0x88C5F0", VA = "0x88C5F0")]
		public void TurnOnWaterDepth(bool value)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x88C5FC", Offset = "0x88C5FC", VA = "0x88C5FC")]
		public ClimbDown()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class Collectable : MonoBehaviour
	{
		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool alreadyAttached;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public GameObject holder;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PrefabName itemName;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public string UID;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_SpawnPointIndex;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ObjectSpawner m_Spawner;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsTracked;

		[Token(Token = "0x170000B4")]
		public string SpawnerName
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x88C6C8", Offset = "0x88C6C8", VA = "0x88C6C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		public int SpawnPointIndex
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x88C76C", Offset = "0x88C76C", VA = "0x88C76C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B6")]
		public bool IsTracked
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x88C774", Offset = "0x88C774", VA = "0x88C774")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x88C77C", Offset = "0x88C77C", VA = "0x88C77C")]
			set
			{
			}
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x88C788", Offset = "0x88C788", VA = "0x88C788")]
		private void Start()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x88C7D0", Offset = "0x88C7D0", VA = "0x88C7D0")]
		public void SetItemName(string item)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x88C8D0", Offset = "0x88C8D0", VA = "0x88C8D0")]
		public void AttachTo(ObjectSpawner spawner, int index)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x88C8DC", Offset = "0x88C8DC", VA = "0x88C8DC")]
		public void Detach()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x88CB18", Offset = "0x88CB18", VA = "0x88CB18")]
		public Collectable()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class Consumable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000101")]
		public class ConsumedEvent : UnityEvent<int>
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x88D25C", Offset = "0x88D25C", VA = "0x88D25C")]
			public ConsumedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000102")]
		public class ConsumedCompletelyEvent : UnityEvent
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x88D2A4", Offset = "0x88D2A4", VA = "0x88D2A4")]
			public ConsumedCompletelyEvent()
			{
			}
		}

		[Token(Token = "0x2000103")]
		public delegate void AllConsumedCallback(GameObject obj);

		[Serializable]
		[Token(Token = "0x2000104")]
		public struct Fall
		{
			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform prefab;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float possibility;
		}

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int durability;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool removedAfterConsumed;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform spawnPoint;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform transitionPrefab;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Fall[] fallPrefab;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform fallPoint;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int energyConsumed;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool isConsumable;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ConsumedEvent onConsumed;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ConsumedCompletelyEvent onConsumedCompletely;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AllConsumedCallback onAllConsumed;

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x88CB28", Offset = "0x88CB28", VA = "0x88CB28")]
		public void Consume(int damage)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x88D22C", Offset = "0x88D22C", VA = "0x88D22C")]
		public void Add(int value)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x88CCA8", Offset = "0x88CCA8", VA = "0x88CCA8")]
		private void Convert()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x88D248", Offset = "0x88D248", VA = "0x88D248")]
		public Consumable()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class CookingPot : MonoBehaviour
	{
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform lid;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem spray;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem smoke;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip spraySound;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float animationTime;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Image contentProgress;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Image cookingProgress;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform spawnPoint;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip productSound;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioClip cookingSound;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UnityEvent onCookingMaterialsReady;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UnityEvent onCookingStart;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UnityEvent onCookingEnd;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float initialAngle;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<PrefabName> objectsIn;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool isFireOn;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool isLidClosed;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool isCooking;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_ElapsedTime;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float step;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioSource audioSource;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool closeFailed;

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x88D3C0", Offset = "0x88D3C0", VA = "0x88D3C0")]
		public void SetFireOn(bool value)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x88D3F8", Offset = "0x88D3F8", VA = "0x88D3F8")]
		private void Start()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x88D4F4", Offset = "0x88D4F4", VA = "0x88D4F4")]
		private void Update()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x88D5C0", Offset = "0x88D5C0", VA = "0x88D5C0")]
		public void LidMove(float angle)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x88D7D8", Offset = "0x88D7D8", VA = "0x88D7D8")]
		private void StartCooking()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x88D864", Offset = "0x88D864", VA = "0x88D864")]
		private void EndCooking()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x88D928", Offset = "0x88D928", VA = "0x88D928")]
		private void SpawnProduct(List<PrefabName> objectsIn)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x88D750", Offset = "0x88D750", VA = "0x88D750")]
		public void Open(float angle)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x88DE0C", Offset = "0x88DE0C", VA = "0x88DE0C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x88E0E0", Offset = "0x88E0E0", VA = "0x88E0E0")]
		public CookingPot()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class CookingRecipeMgr
	{
		[Token(Token = "0x2000107")]
		private enum IngredientType
		{
			[Token(Token = "0x4000679")]
			None,
			[Token(Token = "0x400067A")]
			Meat,
			[Token(Token = "0x400067B")]
			Fish,
			[Token(Token = "0x400067C")]
			Egg,
			[Token(Token = "0x400067D")]
			Fruit,
			[Token(Token = "0x400067E")]
			Vegetable
		}

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PrefabName[] fishes;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static PrefabName[] meat;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static PrefabName[] fruits;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static PrefabName[] vegetables;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static PrefabName[] eggs;

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x88DB90", Offset = "0x88DB90", VA = "0x88DB90")]
		public static PrefabName GetProduct(List<PrefabName> objectsIn)
		{
			return default(PrefabName);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x88E1EC", Offset = "0x88E1EC", VA = "0x88E1EC")]
		private static int GetNumberOf(List<IngredientType> ingredients, IngredientType type)
		{
			return default(int);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x88E0F8", Offset = "0x88E0F8", VA = "0x88E0F8")]
		private static IngredientType GetIngredientType(PrefabName prefabName)
		{
			return default(IngredientType);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x88E4A4", Offset = "0x88E4A4", VA = "0x88E4A4")]
		private static bool IsVegetable(PrefabName prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x88E420", Offset = "0x88E420", VA = "0x88E420")]
		private static bool IsFish(PrefabName prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x88E39C", Offset = "0x88E39C", VA = "0x88E39C")]
		private static bool IsFruit(PrefabName prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x88E318", Offset = "0x88E318", VA = "0x88E318")]
		private static bool IsEgg(PrefabName prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x88E294", Offset = "0x88E294", VA = "0x88E294")]
		private static bool IsMeat(PrefabName prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x88E528", Offset = "0x88E528", VA = "0x88E528")]
		public CookingRecipeMgr()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class Cuttable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public class CutEvent : UnityEvent<Vector3>
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x88ECC8", Offset = "0x88ECC8", VA = "0x88ECC8")]
			public CutEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010A")]
		public class DamageEvent : UnityEvent<int>
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x88ED10", Offset = "0x88ED10", VA = "0x88ED10")]
			public DamageEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010B")]
		public class InteractionEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x88ED58", Offset = "0x88ED58", VA = "0x88ED58")]
			public InteractionEvent()
			{
			}
		}

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int experienceValue;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip CutSound;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] particleSystems;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string cutterTag;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string[] otherCutterTags;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CutEvent onCut;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DamageEvent onDamage;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionEvent onInteraction;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastTime;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool isEnable;

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x88E6AC", Offset = "0x88E6AC", VA = "0x88E6AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x88E6B8", Offset = "0x88E6B8", VA = "0x88E6B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x88E6C0", Offset = "0x88E6C0", VA = "0x88E6C0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x88EBD0", Offset = "0x88EBD0", VA = "0x88EBD0")]
		private bool MeetOtherTags(string tag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x88EC58", Offset = "0x88EC58", VA = "0x88EC58")]
		public Cuttable()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class DeadPlant : MonoBehaviour
	{
		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip digSound;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PrefabName transition;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform spawnPoint;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] otherToolTag;

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x88EDA0", Offset = "0x88EDA0", VA = "0x88EDA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x88EDA4", Offset = "0x88EDA4", VA = "0x88EDA4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x88EDA8", Offset = "0x88EDA8", VA = "0x88EDA8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x88F1B0", Offset = "0x88F1B0", VA = "0x88F1B0")]
		private void RemoveOccupiedTerrian()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x88F128", Offset = "0x88F128", VA = "0x88F128")]
		private bool MeetOtherTags(string tag)
		{
			return default(bool);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x88F2B8", Offset = "0x88F2B8", VA = "0x88F2B8")]
		public DeadPlant()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class Door : MonoBehaviour
	{
		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip openSound;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip closeSound;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isOpen;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float lastTime;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion placedAngle;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BuildingPiece piece;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion wallRotation;

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x88F2C0", Offset = "0x88F2C0", VA = "0x88F2C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x88F3B4", Offset = "0x88F3B4", VA = "0x88F3B4")]
		public void OnPlaced()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x88F49C", Offset = "0x88F49C", VA = "0x88F49C")]
		public void Interact()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x88F960", Offset = "0x88F960", VA = "0x88F960")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x88FA08", Offset = "0x88FA08", VA = "0x88FA08")]
		public Door()
		{
		}
	}
	[Token(Token = "0x200010E")]
	[CreateAssetMenu(fileName = "EasterEggConfig", menuName = "ScriptableObjects/EasterEgg", order = 1)]
	public class EasterEggConfig : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200010F")]
		public struct EggItem
		{
			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PrefabName item;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float Probability;
		}

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EggItem[] Items;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_IsActive;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private EasterEggs m_Agent;

		[Token(Token = "0x170000B7")]
		public bool IsActive
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x88FA10", Offset = "0x88FA10", VA = "0x88FA10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x88FA18", Offset = "0x88FA18", VA = "0x88FA18")]
			set
			{
			}
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x88FA24", Offset = "0x88FA24", VA = "0x88FA24", Slot = "4")]
		public virtual void OnStart(EasterEggs agent)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x88FA2C", Offset = "0x88FA2C", VA = "0x88FA2C", Slot = "5")]
		public virtual void OnUpdate(EasterEggs agent)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x88FA30", Offset = "0x88FA30", VA = "0x88FA30", Slot = "6")]
		public virtual void OnCompletion(EasterEggs agent)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x88FA34", Offset = "0x88FA34", VA = "0x88FA34", Slot = "7")]
		public virtual void Spawn()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x88FC80", Offset = "0x88FC80", VA = "0x88FC80")]
		private StorableItemInfo GetItemInfo(PrefabName itemName)
		{
			return null;
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x88FD04", Offset = "0x88FD04", VA = "0x88FD04")]
		public EasterEggConfig()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class EasterEggConfigOverride : MonoBehaviour
	{
		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EasterEggConfig config;

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x88FD14", Offset = "0x88FD14", VA = "0x88FD14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x88FD18", Offset = "0x88FD18", VA = "0x88FD18")]
		private void Update()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x88FD1C", Offset = "0x88FD1C", VA = "0x88FD1C")]
		public EasterEggConfigOverride()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class EasterEggs : MonoBehaviour
	{
		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsRandom;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<EasterEggConfig> m_Configs;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_CurrentConfigIndex;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private EasterEggConfig m_CurrentConfig;

		[Token(Token = "0x170000B8")]
		public int CurrentConfigIndex
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x88FD24", Offset = "0x88FD24", VA = "0x88FD24")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x88FD2C", Offset = "0x88FD2C", VA = "0x88FD2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x88FEB8", Offset = "0x88FEB8", VA = "0x88FEB8")]
		private void Update()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x88FF44", Offset = "0x88FF44", VA = "0x88FF44")]
		public void SetCurrentConfig(int index)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x8900E8", Offset = "0x8900E8", VA = "0x8900E8")]
		public void OverrideCurrentConfig(EasterEggConfig config)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x890180", Offset = "0x890180", VA = "0x890180")]
		public void Burst()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x890278", Offset = "0x890278", VA = "0x890278")]
		public EasterEggs()
		{
		}
	}
	[Token(Token = "0x2000112")]
	[RequireComponent(typeof(Rigidbody))]
	public class Eatable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000113")]
		public class EatEvent : UnityEvent
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x8908C8", Offset = "0x8908C8", VA = "0x8908C8")]
			public EatEvent()
			{
			}
		}

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool canEat;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int experienceValue;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftPart;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip eatSound;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public System.Action afterEating;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EatEvent onEat;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ParticleSystem juicyEffect;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string COLLIDER_NAME;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float DISAPEAR_TIME;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody mRigidbody;

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x890288", Offset = "0x890288", VA = "0x890288")]
		private void Start()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x8903E0", Offset = "0x8903E0", VA = "0x8903E0")]
		private Transform Initialize(Transform part)
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x8904EC", Offset = "0x8904EC", VA = "0x8904EC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x89056C", Offset = "0x89056C", VA = "0x89056C")]
		public void PlayEatAnimation()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x890860", Offset = "0x890860", VA = "0x890860")]
		public Eatable()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[RequireComponent(typeof(Consumable))]
	public class EntityBehaviour : MonoBehaviour
	{
		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject wornImage;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool isAutoDecreaseHealth;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool IsShowWornStatus;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float DecreaseHealthInterval;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int DecreaseHealthAmount;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_IsWorn;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_NextDecreaseTime;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Consumable m_ConsumableAgent;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int wornThreshold;

		[Token(Token = "0x170000B9")]
		public bool IsAutoDecreaseHealth
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x8908D0", Offset = "0x8908D0", VA = "0x8908D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x8908D8", Offset = "0x8908D8", VA = "0x8908D8")]
			set
			{
			}
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x8908E4", Offset = "0x8908E4", VA = "0x8908E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x890934", Offset = "0x890934", VA = "0x890934")]
		private void Start()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x890960", Offset = "0x890960", VA = "0x890960")]
		private void Update()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x8909FC", Offset = "0x8909FC", VA = "0x8909FC")]
		private void ShowWornStatus(bool isWorn)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x890A60", Offset = "0x890A60", VA = "0x890A60")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x890B50", Offset = "0x890B50", VA = "0x890B50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x890C40", Offset = "0x890C40", VA = "0x890C40")]
		public void Damage(int amount)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x8909B4", Offset = "0x8909B4", VA = "0x8909B4")]
		private void AutoDecreaseHealth()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x890CD4", Offset = "0x890CD4", VA = "0x890CD4")]
		private void On_Damage(int amount)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x890D2C", Offset = "0x890D2C", VA = "0x890D2C")]
		public EntityBehaviour()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class Fire : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000116")]
		public class FuelEvent : UnityEvent<int>
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x891884", Offset = "0x891884", VA = "0x891884")]
			public FuelEvent()
			{
			}
		}

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int experienceValue;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int fireCount;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int count;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject fire;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip fuelSound;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParticleSystem fuelPaticle;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool state;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float lastTime;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent onFireStart;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent onFireEnd;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FuelEvent onAddFuel;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float initialVolume;

		[Token(Token = "0x170000BA")]
		public bool IsOn
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x890D3C", Offset = "0x890D3C", VA = "0x890D3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x890D44", Offset = "0x890D44", VA = "0x890D44")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x890DF0", Offset = "0x890DF0", VA = "0x890DF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x890FB4", Offset = "0x890FB4", VA = "0x890FB4")]
		private void ChangeVolume(float volume)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x891050", Offset = "0x891050", VA = "0x891050")]
		public void TurnOn(bool on)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x8911C4", Offset = "0x8911C4", VA = "0x8911C4")]
		private void OnWeatherChanged(WeatherState weather)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x89125C", Offset = "0x89125C", VA = "0x89125C")]
		private void OnRaining()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x8914C0", Offset = "0x8914C0", VA = "0x8914C0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x891784", Offset = "0x891784", VA = "0x891784")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x891870", Offset = "0x891870", VA = "0x891870")]
		public Fire()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class Fish : Stabbable
	{
		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject rawFish;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static System.Action onStabbedTrigger;

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x8918CC", Offset = "0x8918CC", VA = "0x8918CC", Slot = "4")]
		public override void HandleStabbed(bool stabbed)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x891B2C", Offset = "0x891B2C", VA = "0x891B2C")]
		public Fish()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class Flint : MonoBehaviour
	{
		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParticleSystem spark;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip sound;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Collider flintTrigger;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x891B34", Offset = "0x891B34", VA = "0x891B34")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x891CD0", Offset = "0x891CD0", VA = "0x891CD0")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x891D84", Offset = "0x891D84", VA = "0x891D84")]
		public Flint()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class FloatingObj : MonoBehaviour
	{
		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 offset;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 range;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float frequency;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool isFloating;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool isSelected;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float tick;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float amplitude;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 originPosition;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody rb;

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x891D8C", Offset = "0x891D8C", VA = "0x891D8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x891E00", Offset = "0x891E00", VA = "0x891E00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x891E3C", Offset = "0x891E3C", VA = "0x891E3C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x891F54", Offset = "0x891F54", VA = "0x891F54")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x8920B8", Offset = "0x8920B8", VA = "0x8920B8")]
		public void OnSelected()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x892188", Offset = "0x892188", VA = "0x892188")]
		public void OnDrop()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x8920C4", Offset = "0x8920C4", VA = "0x8920C4")]
		private void OutOfWater()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x892190", Offset = "0x892190", VA = "0x892190")]
		public FloatingObj()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class FootSteps : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011B")]
		public class OnPlayerMoveEvent : UnityEvent
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x892590", Offset = "0x892590", VA = "0x892590")]
			public OnPlayerMoveEvent()
			{
			}
		}

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip footstep_water;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip footstep_dirt;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] layers;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_WalkStepSqr;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_LastPosition;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public OnPlayerMoveEvent onPlayerMove;

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x8921F0", Offset = "0x8921F0", VA = "0x8921F0")]
		public void PlayFootStepSound()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x8924B8", Offset = "0x8924B8", VA = "0x8924B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x8924E8", Offset = "0x8924E8", VA = "0x8924E8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x892580", Offset = "0x892580", VA = "0x892580")]
		public FootSteps()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class Fragment : MonoBehaviour
	{
		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PrefabName parentName;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<PrefabName> neighbors;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<PrefabName> parts;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sqrDistanceThreshold;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float quaternionThreshold;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AudioClip successSound;

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x892598", Offset = "0x892598", VA = "0x892598")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x892658", Offset = "0x892658", VA = "0x892658")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x892684", Offset = "0x892684", VA = "0x892684")]
		private void Assemble(Collider other)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x892A58", Offset = "0x892A58", VA = "0x892A58")]
		private void StoreFragment()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x892984", Offset = "0x892984", VA = "0x892984")]
		private bool isNeighbor(List<PrefabName> parts)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x892A98", Offset = "0x892A98", VA = "0x892A98")]
		public Fragment()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class FrontUIPresenter : MonoBehaviour
	{
		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform frontUIPrefab;

		[Token(Token = "0x40006DA")]
		private const float selfDestroyTime = 5f;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip hintSound;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip warningSound;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static FrontUIPresenter Instance;

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x892AAC", Offset = "0x892AAC", VA = "0x892AAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x892AF8", Offset = "0x892AF8", VA = "0x892AF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x893298", Offset = "0x893298", VA = "0x893298")]
		public void ShowUserMessage(string messageCode, float destroyTime = 5f)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x893880", Offset = "0x893880", VA = "0x893880")]
		public void ShowUserMessage(string messageCode)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x893888", Offset = "0x893888", VA = "0x893888")]
		public void ShowWarningMessge(string messageCode)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x893C1C", Offset = "0x893C1C", VA = "0x893C1C")]
		public void ShowDay()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x893EA8", Offset = "0x893EA8", VA = "0x893EA8")]
		public void ShowLevelUp()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x894158", Offset = "0x894158", VA = "0x894158")]
		public void ShowSaveSprite()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x894420", Offset = "0x894420", VA = "0x894420")]
		private void ShowFoodHintMessage()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x8944A0", Offset = "0x8944A0", VA = "0x8944A0")]
		private void ShowWaterHintMessage()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x894520", Offset = "0x894520", VA = "0x894520")]
		private void ShowOutOfEnergyMessage()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x894568", Offset = "0x894568", VA = "0x894568")]
		private void ShowOutOfWaterMessage()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x8945B0", Offset = "0x8945B0", VA = "0x8945B0")]
		private void ShowOutOfFoodMessage()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x8945F8", Offset = "0x8945F8", VA = "0x8945F8")]
		private void ShowDyingMessage()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x894640", Offset = "0x894640", VA = "0x894640")]
		private void ShowHungryMessage()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x894688", Offset = "0x894688", VA = "0x894688")]
		private void ShowTiredMessage()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x8946D0", Offset = "0x8946D0", VA = "0x8946D0")]
		private void ShowThirstyMessage()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x894718", Offset = "0x894718", VA = "0x894718")]
		private void ShowRecoverToxicMessage()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x893634", Offset = "0x893634", VA = "0x893634")]
		private void ClearUIRoot()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x894760", Offset = "0x894760", VA = "0x894760")]
		private void ShowRecoverSickMessage()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x8947A8", Offset = "0x8947A8", VA = "0x8947A8")]
		private void ShowToxicMessage()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x8947F0", Offset = "0x8947F0", VA = "0x8947F0")]
		private void ShowSickMessage()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x894838", Offset = "0x894838", VA = "0x894838")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x894ED0", Offset = "0x894ED0", VA = "0x894ED0")]
		public FrontUIPresenter()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class Fruit : MonoBehaviour
	{
		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int experienceValue;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip sound;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody rb;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private XRBaseInteractable interactable;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public System.Action onCurrentFruitDown;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static System.Action onFruitDown;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isRegisterd;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Collectable collectable;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SerializationScript serializeHelper;

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x894ED8", Offset = "0x894ED8", VA = "0x894ED8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x8950A8", Offset = "0x8950A8", VA = "0x8950A8")]
		private void OnSelectedExited(SelectExitEventArgs arg0)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x8950C4", Offset = "0x8950C4", VA = "0x8950C4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x89535C", Offset = "0x89535C", VA = "0x89535C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x8953D8", Offset = "0x8953D8", VA = "0x8953D8")]
		private void RegisterToTrack()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x8954E8", Offset = "0x8954E8", VA = "0x8954E8")]
		public Fruit()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class FruitHolder : MonoBehaviour
	{
		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject fruitPrefab;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject fruit;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x8954F8", Offset = "0x8954F8", VA = "0x8954F8")]
		public void SpawnFruit()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x895780", Offset = "0x895780", VA = "0x895780")]
		private void OnFruitDown()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x895870", Offset = "0x895870", VA = "0x895870")]
		public FruitHolder()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class GrownPlant : MonoBehaviour
	{
		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Plant PlantAgent;

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x895878", Offset = "0x895878", VA = "0x895878")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x8958C8", Offset = "0x8958C8", VA = "0x8958C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x8958CC", Offset = "0x8958CC", VA = "0x8958CC")]
		public void RefreshLifeSpan()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x895950", Offset = "0x895950", VA = "0x895950")]
		public GrownPlant()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class GuideBook : MonoBehaviour
	{
		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Button leftButton;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Button rightButton;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] pages;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int currentIndex;

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x895958", Offset = "0x895958", VA = "0x895958")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x89598C", Offset = "0x89598C", VA = "0x89598C")]
		private void UpdatePage(int currentIndex)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x8959F8", Offset = "0x8959F8", VA = "0x8959F8")]
		public void NextPage()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x895ACC", Offset = "0x895ACC", VA = "0x895ACC")]
		public void PreviousPage()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x895B8C", Offset = "0x895B8C", VA = "0x895B8C")]
		public GuideBook()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class Gun : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000123")]
		public class FireEvent : UnityEvent<int>
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x896214", Offset = "0x896214", VA = "0x896214")]
			public FireEvent()
			{
			}
		}

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bulletPrefab;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bulletSpawnPoint;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float power;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int damage;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip fireClip;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip addPowderClip;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ParticleSystem ps;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TMP_Text count;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float lastTime;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int bulletCount;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FireEvent onBulletFired;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Consumable consumable;

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x895B94", Offset = "0x895B94", VA = "0x895B94")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x895BE4", Offset = "0x895BE4", VA = "0x895BE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x895D1C", Offset = "0x895D1C", VA = "0x895D1C")]
		public void Fire()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x896070", Offset = "0x896070", VA = "0x896070")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x89620C", Offset = "0x89620C", VA = "0x89620C")]
		public Gun()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class HintPoint : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000125")]
		public class onHitHintPointEvent : UnityEvent<Collider>
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x896338", Offset = "0x896338", VA = "0x896338")]
			public onHitHintPointEvent()
			{
			}
		}

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public onHitHintPointEvent onHitHintPoint;

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x89625C", Offset = "0x89625C", VA = "0x89625C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x896330", Offset = "0x896330", VA = "0x896330")]
		public HintPoint()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public interface IHittable
	{
		[Token(Token = "0x60005DA")]
		void Hit(int damage);
	}
	[Token(Token = "0x2000127")]
	public class IslandMgr : MonoBehaviour
	{
		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string IslandName;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Transform Spawners;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public List<ChestController> chestControllers;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<PrefabName, ObjectSpawner> m_ObjSpawnerMap;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<PrefabName, List<GameObject>> m_SpawnPointMap;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<SerializationScript> m_CollectableObjTracked;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<GameObject> m_LiveObjTracked;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<BuildingHolder> m_Buildings;

		[Token(Token = "0x170000BB")]
		public Dictionary<PrefabName, List<GameObject>> SpawnPointMap
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x896380", Offset = "0x896380", VA = "0x896380")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public List<SerializationScript> ListOfCollectablesTracked
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x8967FC", Offset = "0x8967FC", VA = "0x8967FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public List<GameObject> ListOfLiveObjectsTracked
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x896804", Offset = "0x896804", VA = "0x896804")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public string CollectablePrefKey
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x89680C", Offset = "0x89680C", VA = "0x89680C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public string LifeCyclePrefKey
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x896868", Offset = "0x896868", VA = "0x896868")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public string BuildingPrefKey
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x8968C4", Offset = "0x8968C4", VA = "0x8968C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public string ChestBoxPrefKey
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x896920", Offset = "0x896920", VA = "0x896920")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x89697C", Offset = "0x89697C", VA = "0x89697C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x896B00", Offset = "0x896B00", VA = "0x896B00")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x896DAC", Offset = "0x896DAC", VA = "0x896DAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x896DB0", Offset = "0x896DB0", VA = "0x896DB0")]
		public void RegisterToTrack(GameObject go)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x89714C", Offset = "0x89714C", VA = "0x89714C")]
		public void UnregisterToTrack(GameObject go)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x896BD8", Offset = "0x896BD8", VA = "0x896BD8")]
		public void InitSpawners()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x8972BC", Offset = "0x8972BC", VA = "0x8972BC")]
		public void EnableSpawners()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x897624", Offset = "0x897624", VA = "0x897624")]
		public void SaveSpawners()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x897844", Offset = "0x897844", VA = "0x897844")]
		public void RegisterBuilding(GameObject building)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x8979C0", Offset = "0x8979C0", VA = "0x8979C0")]
		public void TakeSnapshot()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x896D7C", Offset = "0x896D7C", VA = "0x896D7C")]
		public void Restore()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x899E58", Offset = "0x899E58", VA = "0x899E58")]
		public ObjectSpawner GetObjectSpawner(PrefabName name)
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x8979F0", Offset = "0x8979F0", VA = "0x8979F0")]
		private void SaveCollectables()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x897FEC", Offset = "0x897FEC", VA = "0x897FEC")]
		private void LoadCollectables()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x897B18", Offset = "0x897B18", VA = "0x897B18")]
		private void SaveLifeCycleObjects()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x898918", Offset = "0x898918", VA = "0x898918")]
		private void LoadLifeCycleObjects()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x897C14", Offset = "0x897C14", VA = "0x897C14")]
		private void SaveBuildings()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x899024", Offset = "0x899024", VA = "0x899024")]
		private void LoadBuidings()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x897E64", Offset = "0x897E64", VA = "0x897E64")]
		private void SaveChestBoxes()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x899B1C", Offset = "0x899B1C", VA = "0x899B1C")]
		private void LoadChestBoxes()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x8963E4", Offset = "0x8963E4", VA = "0x8963E4")]
		private void PopulateSpawnPointMap()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x899EEC", Offset = "0x899EEC", VA = "0x899EEC")]
		private string CollectableJsonString()
		{
			return null;
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x89A668", Offset = "0x89A668", VA = "0x89A668")]
		private string LifeCycleJsonString()
		{
			return null;
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x89ABD4", Offset = "0x89ABD4", VA = "0x89ABD4")]
		public IslandMgr()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class ItemSnapshot : StoredItem
	{
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x89AC50", Offset = "0x89AC50", VA = "0x89AC50", Slot = "4")]
		protected override void Init()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x89AE54", Offset = "0x89AE54", VA = "0x89AE54")]
		private void OnRecipeClicked(PrefabName item)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x89AEF4", Offset = "0x89AEF4", VA = "0x89AEF4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x89AE44", Offset = "0x89AE44", VA = "0x89AE44")]
		private void Clear()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x89B0BC", Offset = "0x89B0BC", VA = "0x89B0BC", Slot = "5")]
		protected override void UpdateData(ItemStorer controller, PrefabName itemName)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x89B20C", Offset = "0x89B20C", VA = "0x89B20C")]
		private void UpdateSnapshot(int type, int durability)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x89B21C", Offset = "0x89B21C", VA = "0x89B21C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x89B22C", Offset = "0x89B22C", VA = "0x89B22C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x89B23C", Offset = "0x89B23C", VA = "0x89B23C")]
		public ItemSnapshot()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public abstract class ItemStorer : MonoBehaviour
	{
		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRDirectInteractor leftInteractor;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRRayInteractor leftRayInteractor;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public XRDirectInteractor rightInteractor;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public XRRayInteractor rightRayInteractor;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip bagSound;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int maxCount;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected StoredItem[] items;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PrefabName[] recycles;

		[Token(Token = "0x6000606")]
		public abstract bool StoreItem(PrefabName itemName, int durability);

		[Token(Token = "0x6000607")]
		public abstract bool RemoveItem(StoredItem item);

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x89B244", Offset = "0x89B244", VA = "0x89B244")]
		protected int GetStorableIndex(PrefabName itemName, int durability)
		{
			return default(int);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x89B408", Offset = "0x89B408", VA = "0x89B408")]
		public bool CanRecycle(PrefabName itemName)
		{
			return default(bool);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x88B954", Offset = "0x88B954", VA = "0x88B954")]
		protected ItemStorer()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class LidHandle : MonoBehaviour
	{
		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material previewMaterial;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color previewColor;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AlphaPulse m_Pulse;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Renderer render;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material originalMaterial;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isReady;

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x89B46C", Offset = "0x89B46C", VA = "0x89B46C")]
		private void Start()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x89B538", Offset = "0x89B538", VA = "0x89B538")]
		private void Update()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x89B574", Offset = "0x89B574", VA = "0x89B574")]
		private void ApplyPulse()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x89B5B0", Offset = "0x89B5B0", VA = "0x89B5B0")]
		public void SetReady(bool value)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x89B5F0", Offset = "0x89B5F0", VA = "0x89B5F0")]
		public LidHandle()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class LivingRoomPortal : MonoBehaviour
	{
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x89B5F8", Offset = "0x89B5F8", VA = "0x89B5F8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x89B6AC", Offset = "0x89B6AC", VA = "0x89B6AC")]
		public LivingRoomPortal()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class DigHole : MonoBehaviour
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int consume;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float resetTime;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cover;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bottom;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int digCount;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform prizePrefab;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ParticleSystem dust;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ParticleSystem sparkle;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip prizeSound;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip digSound;

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x89B6B4", Offset = "0x89B6B4", VA = "0x89B6B4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x89B71C", Offset = "0x89B71C", VA = "0x89B71C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x89B740", Offset = "0x89B740", VA = "0x89B740")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x89BAFC", Offset = "0x89BAFC", VA = "0x89BAFC")]
		public DigHole()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class DigHolesMgr : MonoBehaviour
	{
		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int numLimit;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float InitSpawnInterval;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Factor;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DigHole[] digControllers;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<DigHole> digPlacesSpawned;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_SpawnInterval;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_ElapsedTime;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<DigHole> onDigHoleRemoved;

		[Token(Token = "0x170000C2")]
		public int NumSpawnPoints
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x89BB10", Offset = "0x89BB10", VA = "0x89BB10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x89BB2C", Offset = "0x89BB2C", VA = "0x89BB2C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x89BC2C", Offset = "0x89BC2C", VA = "0x89BC2C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x89BD2C", Offset = "0x89BD2C", VA = "0x89BD2C")]
		private void RemoveDigHole(DigHole obj)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x89BD8C", Offset = "0x89BD8C", VA = "0x89BD8C")]
		protected void Start()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x89BE38", Offset = "0x89BE38", VA = "0x89BE38")]
		private void Update()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x89BE7C", Offset = "0x89BE7C", VA = "0x89BE7C")]
		private void Spawn()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x89BFB8", Offset = "0x89BFB8", VA = "0x89BFB8")]
		private float ExpBackoffInterval()
		{
			return default(float);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x89C01C", Offset = "0x89C01C", VA = "0x89C01C")]
		public DigHolesMgr()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class GodView : MonoBehaviour
	{
		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("Switch God View")]
		private InputActionReference m_GodViewSwitcher;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform XRCamera;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float hight;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 scale;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isGodView;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 originPos;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion originRot;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 originScale;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 pos;

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x89C038", Offset = "0x89C038", VA = "0x89C038")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x89C1B8", Offset = "0x89C1B8", VA = "0x89C1B8")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x89C250", Offset = "0x89C250", VA = "0x89C250")]
		private void OnSwitchView(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x89C134", Offset = "0x89C134", VA = "0x89C134")]
		private InputAction GetInputAction(InputActionReference actionReference)
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x89C37C", Offset = "0x89C37C", VA = "0x89C37C")]
		public GodView()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class Transfering : MonoBehaviour
	{
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PrefabName itemName;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HintRender tip;

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x89C384", Offset = "0x89C384", VA = "0x89C384")]
		private void Start()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x89C3D4", Offset = "0x89C3D4", VA = "0x89C3D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x89C3D8", Offset = "0x89C3D8", VA = "0x89C3D8")]
		public void Transfer()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x89C3DC", Offset = "0x89C3DC", VA = "0x89C3DC")]
		public Transfering()
		{
		}
	}
	[Token(Token = "0x2000131")]
	[RequireComponent(typeof(PullMeasurer))]
	public class Notch : XRSocketInteractor
	{
		[Serializable]
		[Token(Token = "0x2000132")]
		public class ReleaseArrowEvent : UnityEvent
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x89CD7C", Offset = "0x89CD7C", VA = "0x89CD7C")]
			public ReleaseArrowEvent()
			{
			}
		}

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[Range(0f, 1f)]
		public float releaseThreshold;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public int damage;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public GameObject arrowPrefab;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioClip releaseSound;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public ReleaseArrowEvent onReleaseArrow;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Arrow arrow;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Consumable consumable;

		[Token(Token = "0x170000C3")]
		public PullMeasurer PullMeasurer
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x89C3E4", Offset = "0x89C3E4", VA = "0x89C3E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x89C3EC", Offset = "0x89C3EC", VA = "0x89C3EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public bool IsReady
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x89C3F4", Offset = "0x89C3F4", VA = "0x89C3F4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x89C3FC", Offset = "0x89C3FC", VA = "0x89C3FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public override XRBaseInteractable.MovementType? selectedInteractableMovementTypeOverride
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x89CCBC", Offset = "0x89CCBC", VA = "0x89CCBC", Slot = "54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public override bool requireSelectExclusive
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x89CD10", Offset = "0x89CD10", VA = "0x89CD10", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x89C408", Offset = "0x89C408", VA = "0x89C408", Slot = "43")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x89C490", Offset = "0x89C490", VA = "0x89C490", Slot = "44")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x89C5C0", Offset = "0x89C5C0", VA = "0x89C5C0", Slot = "45")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x89C6F0", Offset = "0x89C6F0", VA = "0x89C6F0")]
		public void ReleaseArrow(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x89C93C", Offset = "0x89C93C", VA = "0x89C93C")]
		private void PrepareArrow()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x89CB28", Offset = "0x89CB28", VA = "0x89CB28")]
		public void MoveAttach(Vector3 pullPosition, float pullAmount)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x89CB44", Offset = "0x89CB44", VA = "0x89CB44")]
		public void SetReady(BaseInteractionEventArgs args)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x89C9FC", Offset = "0x89C9FC", VA = "0x89C9FC")]
		private Arrow CreateArrow(Transform orientation)
		{
			return null;
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x89CBEC", Offset = "0x89CBEC", VA = "0x89CBEC", Slot = "79")]
		public override bool CanSelect(XRBaseInteractable interactable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x89CC44", Offset = "0x89CC44", VA = "0x89CC44")]
		private bool IsArrow(XRBaseInteractable interactable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x89CD18", Offset = "0x89CD18", VA = "0x89CD18")]
		public Notch()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class Notebook : MonoBehaviour
	{
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform topPart;

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x89CD84", Offset = "0x89CD84", VA = "0x89CD84")]
		private void Start()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x89CD88", Offset = "0x89CD88", VA = "0x89CD88")]
		public void Open()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x89CDFC", Offset = "0x89CDFC", VA = "0x89CDFC")]
		public void Close()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x89CE6C", Offset = "0x89CE6C", VA = "0x89CE6C")]
		public Notebook()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class NoticeBoard : MonoBehaviour
	{
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Image[] notices;

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x89CE74", Offset = "0x89CE74", VA = "0x89CE74")]
		private void Start()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x89D08C", Offset = "0x89D08C", VA = "0x89D08C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x89D138", Offset = "0x89D138", VA = "0x89D138")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x89CFD8", Offset = "0x89CFD8", VA = "0x89CFD8")]
		private void EnableNotices(Image[] notices, bool value)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x89D1E4", Offset = "0x89D1E4", VA = "0x89D1E4")]
		public NoticeBoard()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[CreateAssetMenu(fileName = "ObjectSpawnConfig", menuName = "ScriptableObjects/ObjectSpawnConfig", order = 1)]
	public class ObjectSpawnConfig : ScriptableObject
	{
		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Tag;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SpawnInterval;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int MaxCount;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PrefabName[] Prefabs;

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x89D1EC", Offset = "0x89D1EC", VA = "0x89D1EC")]
		public ObjectSpawnConfig()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class SpawnPointInfo
	{
		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool Occupied;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform SpawnPoint;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject AttachedObject;

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x89D1F4", Offset = "0x89D1F4", VA = "0x89D1F4")]
		public SpawnPointInfo()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class ObjectSpawner : MonoBehaviour
	{
		[Token(Token = "0x2000138")]
		[CompilerGenerated]
		private sealed class <DelayedSpawn>d__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ObjectSpawner <>4__this;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <count>5__2;

			[Token(Token = "0x170000CC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600065E")]
				[Address(RVA = "0x89EF94", Offset = "0x89EF94", VA = "0x89EF94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000660")]
				[Address(RVA = "0x89EFDC", Offset = "0x89EFDC", VA = "0x89EFDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x89E9AC", Offset = "0x89E9AC", VA = "0x89E9AC")]
			[DebuggerHidden]
			public <DelayedSpawn>d__36(int <>1__state)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x89EA60", Offset = "0x89EA60", VA = "0x89EA60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x89EA64", Offset = "0x89EA64", VA = "0x89EA64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x89EF9C", Offset = "0x89EF9C", VA = "0x89EF9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ObjectSpawnConfig m_Config;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_ActiveLevel;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TimeOfDay m_TimeOfDay;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_LimitToSpawn;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_MaxCount;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_NumSpawnedObj;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_NumExistingObj;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_Enabled;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool m_IsFirstTime;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool m_Initialized;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SpawnInterval;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameDate m_LastSpawnTime;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PrefabName[] m_Prefabs;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<SpawnPointInfo> m_SpawnPoints;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IslandMgr m_IslandMgr;

		[Token(Token = "0x170000C7")]
		private string PlayerPrefKey
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x89D1FC", Offset = "0x89D1FC", VA = "0x89D1FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		private string LastSpawnTimeKey
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x89D368", Offset = "0x89D368", VA = "0x89D368")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		public string Name
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x89D4D4", Offset = "0x89D4D4", VA = "0x89D4D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x89D4F4", Offset = "0x89D4F4", VA = "0x89D4F4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public PrefabName PrefabType
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x89728C", Offset = "0x89728C", VA = "0x89728C")]
			get
			{
				return default(PrefabName);
			}
		}

		[Token(Token = "0x170000CB")]
		public int Count
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x89D4F8", Offset = "0x89D4F8", VA = "0x89D4F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x8973D0", Offset = "0x8973D0", VA = "0x8973D0")]
		public void SetEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x897734", Offset = "0x897734", VA = "0x897734")]
		public void Save()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x89A418", Offset = "0x89A418", VA = "0x89A418")]
		public void AttachTo(GameObject go, int index)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x88C964", Offset = "0x88C964", VA = "0x88C964")]
		public void Detach(Collectable collectable)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x89DCE4", Offset = "0x89DCE4", VA = "0x89DCE4")]
		public void Consume(int amount)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x89DCF8", Offset = "0x89DCF8", VA = "0x89DCF8")]
		public void SpawnOnce()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x89DF28", Offset = "0x89DF28", VA = "0x89DF28")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x89DF78", Offset = "0x89DF78", VA = "0x89DF78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x89E004", Offset = "0x89E004", VA = "0x89E004")]
		private void Update()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x89D500", Offset = "0x89D500", VA = "0x89D500")]
		private void Init()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x89E944", Offset = "0x89E944", VA = "0x89E944")]
		[IteratorStateMachine(typeof(<DelayedSpawn>d__36))]
		private IEnumerator DelayedSpawn()
		{
			return null;
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x89E11C", Offset = "0x89E11C", VA = "0x89E11C")]
		private void Spawn()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x89E7C4", Offset = "0x89E7C4", VA = "0x89E7C4")]
		private List<GameObject> FindGameObjectsInChildWithTag(string tag)
		{
			return null;
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x89D8D0", Offset = "0x89D8D0", VA = "0x89D8D0")]
		private void Register(GameObject go, int index)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x89DE54", Offset = "0x89DE54", VA = "0x89DE54")]
		private int FindRandomAvailableSpawnPoint()
		{
			return default(int);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x89E9D4", Offset = "0x89E9D4", VA = "0x89E9D4")]
		public ObjectSpawner()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class Paddle : MonoBehaviour
	{
		[Token(Token = "0x200013A")]
		public enum StrokeState
		{
			[Token(Token = "0x4000770")]
			Ready,
			[Token(Token = "0x4000771")]
			Enter,
			[Token(Token = "0x4000772")]
			Init,
			[Token(Token = "0x4000773")]
			Middle
		}

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip waterSound;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem ripplePrefab;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_ForwardForce;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_RotateForce;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_StrokeDistanceThreshold;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_MaxStrokeDuration;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_SmoothForceSpeed;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_IsBackwards;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_IsRightSide;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		private bool m_IsRowing;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_RaftForwardForce;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_RaftRotateForce;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_RaftForwardVelocity;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_RaftRotateVelocity;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CurrentRaftForwardForce;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_CurrentRaftRotateForce;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_EntryTime;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 m_PreviousTipPosition;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private StrokeState m_CurrentStroke;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Collider boxCollider;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RaftController m_RaftController;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private XRBaseInteractable interactable;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ParticleSystem ripple;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 spawnOffset;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 spawnRotation;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float smoothTime;

		[Token(Token = "0x170000CE")]
		public RaftController Raft
		{
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x89EFE4", Offset = "0x89EFE4", VA = "0x89EFE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x89EFEC", Offset = "0x89EFEC", VA = "0x89EFEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x89F1F4", Offset = "0x89F1F4", VA = "0x89F1F4")]
		private RaftController FindCurrentRaft()
		{
			return null;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x89F2CC", Offset = "0x89F2CC", VA = "0x89F2CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x89F46C", Offset = "0x89F46C", VA = "0x89F46C")]
		private void SetupRaft(RaftController obj)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x89F474", Offset = "0x89F474", VA = "0x89F474")]
		private void RemoveRaft(RaftController obj)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x89F47C", Offset = "0x89F47C", VA = "0x89F47C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x89F480", Offset = "0x89F480", VA = "0x89F480")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x89F534", Offset = "0x89F534", VA = "0x89F534")]
		private void UpdateStrokeState()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x89F604", Offset = "0x89F604", VA = "0x89F604")]
		private void UpdateRaftMovement()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x89FC88", Offset = "0x89FC88", VA = "0x89FC88")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x8A002C", Offset = "0x8A002C", VA = "0x8A002C")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x8A01BC", Offset = "0x8A01BC", VA = "0x8A01BC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x89FAB4", Offset = "0x89FAB4", VA = "0x89FAB4")]
		private Vector3 PaddleTip()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x89FE2C", Offset = "0x89FE2C", VA = "0x89FE2C")]
		private void ShowRippleEffect(Collider collider)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x89FB6C", Offset = "0x89FB6C", VA = "0x89FB6C")]
		private void ProcessStrokeData()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x8A02E8", Offset = "0x8A02E8", VA = "0x8A02E8")]
		public Paddle()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class PalmTree : MonoBehaviour
	{
		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Cuttable cuttable;

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x8A0308", Offset = "0x8A0308", VA = "0x8A0308")]
		private void Start()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x8A0328", Offset = "0x8A0328", VA = "0x8A0328")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x8A03DC", Offset = "0x8A03DC", VA = "0x8A03DC")]
		public PalmTree()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class PlacementHelper : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200013D")]
		public class PlacedEvent : UnityEvent
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x8A2880", Offset = "0x8A2880", VA = "0x8A2880")]
			public PlacedEvent()
			{
			}
		}

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material previewMaterial;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip buildSound;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int experienceValue;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Bounds m_Bounds;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_centerOffset;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string placedOnTag;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LayerMask m_CollisionTestMask;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string LayerEnabled;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector3 placeDirection;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool isEnabled;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Renderer[] renders;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Canvas[] canvas;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Renderer[] previewRenders;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private XRBaseInteractable m_Interactable;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string[] layers;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GameObject previewObject;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool canPlaced;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int originLayer;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<Collider> m_Colliders;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Color valid;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Color invalid;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 placedPos;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Quaternion placedRotation;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public PlacedEvent onPlaced;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float remoteControllDistance;

		[Token(Token = "0x170000CF")]
		public Bounds Bounds
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x8A03E4", Offset = "0x8A03E4", VA = "0x8A03E4")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x8A04A4", Offset = "0x8A04A4", VA = "0x8A04A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x8A0564", Offset = "0x8A0564", VA = "0x8A0564")]
		public void SetEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x8A076C", Offset = "0x8A076C", VA = "0x8A076C")]
		private void DisableColliders(Collider[] colliders)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x8A0824", Offset = "0x8A0824", VA = "0x8A0824")]
		private void SetEnableColliders(Collider[] colliders, bool enabled)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x89A404", Offset = "0x89A404", VA = "0x89A404")]
		public void NotifyPlaced()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x8A0774", Offset = "0x8A0774", VA = "0x8A0774")]
		private void EnableRenders(bool enabled)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x8A088C", Offset = "0x8A088C", VA = "0x8A088C")]
		private void Update()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x8A0D98", Offset = "0x8A0D98", VA = "0x8A0D98")]
		private bool IsAllowed(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x8A0ED4", Offset = "0x8A0ED4", VA = "0x8A0ED4")]
		private bool IsAllowedOnType(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x8A0DF4", Offset = "0x8A0DF4", VA = "0x8A0DF4")]
		private bool HasCollider(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x8A0F34", Offset = "0x8A0F34", VA = "0x8A0F34")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x8A1058", Offset = "0x8A1058", VA = "0x8A1058")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x8A115C", Offset = "0x8A115C", VA = "0x8A115C", Slot = "4")]
		protected virtual void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x8A1294", Offset = "0x8A1294", VA = "0x8A1294", Slot = "5")]
		protected virtual void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x8A156C", Offset = "0x8A156C", VA = "0x8A156C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x8A1784", Offset = "0x8A1784", VA = "0x8A1784")]
		public PlacementHelper()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class PlantArea : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200013F")]
		public class PlantEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x8A38C0", Offset = "0x8A38C0", VA = "0x8A38C0")]
			public PlantEvent()
			{
			}
		}

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject m_ReticlePrefab;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject soilPrefab;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject wateringHint;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Plant plant;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Renderer adultRenderer;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private XRBaseInteractable interactable;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject m_ReticleInstance;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_ReticleActive;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool isRegistered;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public PlantEvent onPlanted;

		[Token(Token = "0x170000D0")]
		public bool reticleActive
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x8A2888", Offset = "0x8A2888", VA = "0x8A2888")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x8A2890", Offset = "0x8A2890", VA = "0x8A2890")]
			set
			{
			}
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x8A2930", Offset = "0x8A2930", VA = "0x8A2930")]
		private void Awake()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x8A2A88", Offset = "0x8A2A88", VA = "0x8A2A88")]
		private void Start()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x8A2AA8", Offset = "0x8A2AA8", VA = "0x8A2AA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x8A29E8", Offset = "0x8A29E8", VA = "0x8A29E8")]
		private void SetupReticlePrefab()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x8A2B38", Offset = "0x8A2B38", VA = "0x8A2B38")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x8A2D00", Offset = "0x8A2D00", VA = "0x8A2D00")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x8A364C", Offset = "0x8A364C", VA = "0x8A364C")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x8A2DC8", Offset = "0x8A2DC8", VA = "0x8A2DC8")]
		private void DoPlanting(Collider other)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x8A38B8", Offset = "0x8A38B8", VA = "0x8A38B8")]
		public PlantArea()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class PlantingArea : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000141")]
		public class PlayerEnteredEvent : UnityEvent
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x8A3BA0", Offset = "0x8A3BA0", VA = "0x8A3BA0")]
			public PlayerEnteredEvent()
			{
			}
		}

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GridTerrian grids;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Renderer render;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HintRender hint;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject butterflyPrefab;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject butterflyEffect;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PlayerEnteredEvent OnPlayerEntered;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int plantedNum;

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x8A3908", Offset = "0x8A3908", VA = "0x8A3908")]
		private void Start()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x8A3A0C", Offset = "0x8A3A0C", VA = "0x8A3A0C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x8A3AE4", Offset = "0x8A3AE4", VA = "0x8A3AE4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x8A3B94", Offset = "0x8A3B94", VA = "0x8A3B94")]
		internal void SetPlanted(bool planted)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x8A3B98", Offset = "0x8A3B98", VA = "0x8A3B98")]
		public PlantingArea()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class PlantingFoundation : MonoBehaviour
	{
		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PrefabName itemName;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<PrefabName> notSupported;

		[Token(Token = "0x170000D1")]
		public PrefabName TypeName
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x8A3BA8", Offset = "0x8A3BA8", VA = "0x8A3BA8")]
			get
			{
				return default(PrefabName);
			}
		}

		[Token(Token = "0x170000D2")]
		public bool IsOccupied
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x8A3BB0", Offset = "0x8A3BB0", VA = "0x8A3BB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x8A3BB8", Offset = "0x8A3BB8", VA = "0x8A3BB8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x8A3BC4", Offset = "0x8A3BC4", VA = "0x8A3BC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x8A3794", Offset = "0x8A3794", VA = "0x8A3794")]
		internal bool CanPlace(Transform seed)
		{
			return default(bool);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x8A3BCC", Offset = "0x8A3BCC", VA = "0x8A3BCC")]
		public PlantingFoundation()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class PlantRegenerator : MonoBehaviour
	{
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool IsAutoRegenerate;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform originalTransform;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int AutoRegenerateInterval;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool isGenerated;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameDate regenerateStartTime;

		[Token(Token = "0x170000D3")]
		public GameDate RegenerationStart
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x8A3BDC", Offset = "0x8A3BDC", VA = "0x8A3BDC")]
			get
			{
				return default(GameDate);
			}
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x8A3BEC", Offset = "0x8A3BEC", VA = "0x8A3BEC")]
			set
			{
			}
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x8A3BF8", Offset = "0x8A3BF8", VA = "0x8A3BF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x8A3C78", Offset = "0x8A3C78", VA = "0x8A3C78")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x8A3E7C", Offset = "0x8A3E7C", VA = "0x8A3E7C")]
		public PlantRegenerator()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class Player : MonoBehaviour
	{
		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip vitalDecreased;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionSchemeManager lsMgr;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public XRRayInteractor leftTeleportInteractor;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public XRRayInteractor rightTeleportInteractor;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Camera mainCamera;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip whereAmI;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float originalMoveSpeed;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float originalTeleportVelocity;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool isHigh;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool isUnderWater;

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x8A3E94", Offset = "0x8A3E94", VA = "0x8A3E94")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x8A3FB8", Offset = "0x8A3FB8", VA = "0x8A3FB8")]
		protected void Update()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x8A4230", Offset = "0x8A4230", VA = "0x8A4230")]
		private void OnTiredRecoverd()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x8A4274", Offset = "0x8A4274", VA = "0x8A4274")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x8A454C", Offset = "0x8A454C", VA = "0x8A454C")]
		public void OnVitalDecreased(int damage)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x8A46CC", Offset = "0x8A46CC", VA = "0x8A46CC")]
		private void Revive()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x8A4758", Offset = "0x8A4758", VA = "0x8A4758")]
		private void WakeUp()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x8A47D8", Offset = "0x8A47D8", VA = "0x8A47D8")]
		private void ShowShipHint()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x8A489C", Offset = "0x8A489C", VA = "0x8A489C")]
		private void ShowObjective()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x8A4930", Offset = "0x8A4930", VA = "0x8A4930")]
		private void CheckSurvivalBook()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x8A49A4", Offset = "0x8A49A4", VA = "0x8A49A4")]
		public Player()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class Potion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000146")]
		public class PotionPouredEvent : UnityEvent<float>
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x8A5298", Offset = "0x8A5298", VA = "0x8A5298")]
			public PotionPouredEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000147")]
		public class PotionPouringPausedEvent : UnityEvent
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x8A52E0", Offset = "0x8A52E0", VA = "0x8A52E0")]
			public PotionPouringPausedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000148")]
		public class PotionPouringEndedEvent : UnityEvent
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x8A52E8", Offset = "0x8A52E8", VA = "0x8A52E8")]
			public PotionPouringEndedEvent()
			{
			}
		}

		[Token(Token = "0x2000149")]
		[CompilerGenerated]
		private sealed class <ReceivePotion>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PotionReceiver receiver;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Potion <>4__this;

			[Token(Token = "0x170000D4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006BC")]
				[Address(RVA = "0x8A55E4", Offset = "0x8A55E4", VA = "0x8A55E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006BE")]
				[Address(RVA = "0x8A562C", Offset = "0x8A562C", VA = "0x8A562C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x8A517C", Offset = "0x8A517C", VA = "0x8A517C")]
			[DebuggerHidden]
			public <ReceivePotion>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x8A52F0", Offset = "0x8A52F0", VA = "0x8A52F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x8A52F4", Offset = "0x8A52F4", VA = "0x8A52F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x8A55EC", Offset = "0x8A55EC", VA = "0x8A55EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform cover;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string PotionType;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fillAmount;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ParticleSystem particleSystemLiquid;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PotionPouredEvent OnPotionPoured;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PotionPouringPausedEvent OnPotionPouringPaused;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PotionPouringEndedEvent OnPotionPouringEnded;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip PouringClip;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public System.Action afterDrinking;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string[] layers;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody m_CoverRb;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool isCovered;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_StartingFillAmount;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool isDrinkingInvoked;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<PotionReceiver> receivers;

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x8A49AC", Offset = "0x8A49AC", VA = "0x8A49AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x8A4BA8", Offset = "0x8A4BA8", VA = "0x8A4BA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x8A4C1C", Offset = "0x8A4C1C", VA = "0x8A4C1C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x8A5094", Offset = "0x8A5094", VA = "0x8A5094")]
		public void Reset()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x8A5108", Offset = "0x8A5108", VA = "0x8A5108")]
		[IteratorStateMachine(typeof(<ReceivePotion>d__23))]
		private IEnumerator ReceivePotion(PotionReceiver receiver)
		{
			return null;
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x8A51A4", Offset = "0x8A51A4", VA = "0x8A51A4")]
		public void UnCover(Vector3 vel)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x8A523C", Offset = "0x8A523C", VA = "0x8A523C")]
		public Potion()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class PotionReceiver : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014B")]
		public class PotionPouredEvent : UnityEvent<string>
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x8A5658", Offset = "0x8A5658", VA = "0x8A5658")]
			public PotionPouredEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014C")]
		public class WrongPotionPouredEvent : UnityEvent<string>
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x8A56A0", Offset = "0x8A56A0", VA = "0x8A56A0")]
			public WrongPotionPouredEvent()
			{
			}
		}

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip receiverSound;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int experienceValue;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool correctPoured;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool isEnabled;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<string> AcceptedPotionType;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PotionPouredEvent OnPotionPoured;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public WrongPotionPouredEvent OnWrongPotionPoured;

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x8A5634", Offset = "0x8A5634", VA = "0x8A5634")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x8A5640", Offset = "0x8A5640", VA = "0x8A5640")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x8A53A0", Offset = "0x8A53A0", VA = "0x8A53A0")]
		public void ReceivePotion(string PotionType)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x8A5648", Offset = "0x8A5648", VA = "0x8A5648")]
		public PotionReceiver()
		{
		}
	}
	[Token(Token = "0x200014D")]
	[RequireComponent(typeof(Consumable))]
	public class ProgressBar : MonoBehaviour
	{
		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool decrease;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image bar;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_Text number;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Consumable consumable;

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x8A56E8", Offset = "0x8A56E8", VA = "0x8A56E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x8A5778", Offset = "0x8A5778", VA = "0x8A5778")]
		public void UpdateProgress()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x8A5748", Offset = "0x8A5748", VA = "0x8A5748")]
		public void SetBarActive(bool active)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x8A5860", Offset = "0x8A5860", VA = "0x8A5860")]
		public ProgressBar()
		{
		}
	}
	[Token(Token = "0x200014E")]
	[RequireComponent(typeof(Rigidbody))]
	public class RaftController : MonoBehaviour
	{
		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HintRender hintRenderer;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isPlayerOn;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool shouldMonitorStatus;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastOnWaterPosition;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform mainCamera;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<RaftController> onPlayerEnter;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<RaftController> onPlayerExit;

		[Token(Token = "0x170000D6")]
		public bool IsPlayerOn
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x8A5868", Offset = "0x8A5868", VA = "0x8A5868")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x8A5870", Offset = "0x8A5870", VA = "0x8A5870")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public Vector3 LastOnWaterPosition
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x8A587C", Offset = "0x8A587C", VA = "0x8A587C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x8A5888", Offset = "0x8A5888", VA = "0x8A5888")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x8A5EA4", Offset = "0x8A5EA4", VA = "0x8A5EA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x8A5F14", Offset = "0x8A5F14", VA = "0x8A5F14")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x8A60C0", Offset = "0x8A60C0", VA = "0x8A60C0")]
		private void AttachToRaft(Collectable collectable)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x8A6360", Offset = "0x8A6360", VA = "0x8A6360")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x8A6400", Offset = "0x8A6400", VA = "0x8A6400")]
		private void DetachFromRaft(Collectable collectable)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x8A6680", Offset = "0x8A6680", VA = "0x8A6680")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x8A6828", Offset = "0x8A6828", VA = "0x8A6828")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x8A5B6C", Offset = "0x8A5B6C", VA = "0x8A5B6C")]
		private void UpdatePlayerStatus(Transform player)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x8A598C", Offset = "0x8A598C", VA = "0x8A598C")]
		private bool IsOnWater(Vector3 position)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x8A69BC", Offset = "0x8A69BC", VA = "0x8A69BC")]
		public void MoveTo(Vector3 position)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x8A6A34", Offset = "0x8A6A34", VA = "0x8A6A34")]
		public void RotateTowards(Vector3 target, float smooth)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x8A6C24", Offset = "0x8A6C24", VA = "0x8A6C24")]
		public RaftController()
		{
		}
	}
	[Token(Token = "0x200014F")]
	public class RaftFoundation : MonoBehaviour
	{
		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TransportController controller;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x8A6C2C", Offset = "0x8A6C2C", VA = "0x8A6C2C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x8A6DAC", Offset = "0x8A6DAC", VA = "0x8A6DAC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x8A6F28", Offset = "0x8A6F28", VA = "0x8A6F28")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x8A72B4", Offset = "0x8A72B4", VA = "0x8A72B4")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x8A7058", Offset = "0x8A7058", VA = "0x8A7058")]
		private void AttachToRaft(Collectable collectable)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x8A73D0", Offset = "0x8A73D0", VA = "0x8A73D0")]
		private void DetachFromRaft(Collectable collectable)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x8A760C", Offset = "0x8A760C", VA = "0x8A760C")]
		public RaftFoundation()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class RaftRudder : MonoBehaviour
	{
		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BuildingPiece piece;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BuildingPiece sail;

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x8A7614", Offset = "0x8A7614", VA = "0x8A7614")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x8A7618", Offset = "0x8A7618", VA = "0x8A7618")]
		public void RotateSailCloth()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x8A7A08", Offset = "0x8A7A08", VA = "0x8A7A08")]
		public RaftRudder()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class RawMaterial : MonoBehaviour
	{
		[Token(Token = "0x2000152")]
		public enum ElementType
		{
			[Token(Token = "0x40007DD")]
			Unknown,
			[Token(Token = "0x40007DE")]
			Metal,
			[Token(Token = "0x40007DF")]
			Wood,
			[Token(Token = "0x40007E0")]
			Water,
			[Token(Token = "0x40007E1")]
			Fire,
			[Token(Token = "0x40007E2")]
			Rock,
			[Token(Token = "0x40007E3")]
			Herb
		}

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ElementType elmentType;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_Amount;

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x8A7A10", Offset = "0x8A7A10", VA = "0x8A7A10")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x8A7A14", Offset = "0x8A7A14", VA = "0x8A7A14")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x8A7A18", Offset = "0x8A7A18", VA = "0x8A7A18")]
		public void Consume(float value)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x8A7A30", Offset = "0x8A7A30", VA = "0x8A7A30")]
		public RawMaterial()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class RewardController : MonoBehaviour
	{
		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_TotalAmount;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_MaxAllocateInterval;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MinQueryInterval;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_AttemptWeight;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_MaxAttempts;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static RewardController Instance;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_NextAllocateTime;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_NumOfAllocated;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_NumOfRequests;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_LastRequestTime;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_LastPosition;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_FirstTime;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool m_ForcedToAllocate;

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x8A7A38", Offset = "0x8A7A38", VA = "0x8A7A38")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x8A7A84", Offset = "0x8A7A84", VA = "0x8A7A84")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x8A7B10", Offset = "0x8A7B10", VA = "0x8A7B10")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x8A7A88", Offset = "0x8A7A88", VA = "0x8A7A88")]
		public void Init()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x8A7B50", Offset = "0x8A7B50", VA = "0x8A7B50")]
		public bool QueryForPermission(Vector3 position)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x8A7CF0", Offset = "0x8A7CF0", VA = "0x8A7CF0")]
		private void UpdateState(Vector3 position)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x8A7D34", Offset = "0x8A7D34", VA = "0x8A7D34")]
		public RewardController()
		{
		}
	}
	[Token(Token = "0x2000154")]
	public class SailController : MonoBehaviour
	{
		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clothSound;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource seaSound;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject endUI;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform anchor;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isDown;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float lastTime;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRot;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TransportController controller;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform rudder;

		[Token(Token = "0x170000D8")]
		public bool IsPowerOn
		{
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x8A7D50", Offset = "0x8A7D50", VA = "0x8A7D50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x8A7D58", Offset = "0x8A7D58", VA = "0x8A7D58")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x8A7F28", Offset = "0x8A7F28", VA = "0x8A7F28")]
		private void ChangeVolume(float vfxVolume)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x8A8004", Offset = "0x8A8004", VA = "0x8A8004")]
		public void ToggleSail()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x8A791C", Offset = "0x8A791C", VA = "0x8A791C")]
		public void RotateSail(Transform raftRudder)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x8A85F8", Offset = "0x8A85F8", VA = "0x8A85F8")]
		public Vector3 GetDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x8A8620", Offset = "0x8A8620", VA = "0x8A8620")]
		public void KeepStill()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x8A86C4", Offset = "0x8A86C4", VA = "0x8A86C4")]
		public SailController()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public class SaveMenu : MonoBehaviour
	{
		[Token(Token = "0x2000156")]
		[CompilerGenerated]
		private sealed class <Init>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SaveMenu <>4__this;

			[Token(Token = "0x170000D9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000700")]
				[Address(RVA = "0x8A8F14", Offset = "0x8A8F14", VA = "0x8A8F14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000702")]
				[Address(RVA = "0x8A8F5C", Offset = "0x8A8F5C", VA = "0x8A8F5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x8A8964", Offset = "0x8A8964", VA = "0x8A8964")]
			[DebuggerHidden]
			public <Init>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x8A8D84", Offset = "0x8A8D84", VA = "0x8A8D84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x8A8D88", Offset = "0x8A8D88", VA = "0x8A8D88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x8A8F1C", Offset = "0x8A8F1C", VA = "0x8A8F1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool load;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameMgr gameMgr;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_Text[] slots;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int currentSlotIndex;

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x8A86CC", Offset = "0x8A86CC", VA = "0x8A86CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x8A88B0", Offset = "0x8A88B0", VA = "0x8A88B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x8A88FC", Offset = "0x8A88FC", VA = "0x8A88FC")]
		[IteratorStateMachine(typeof(<Init>d__6))]
		private IEnumerator Init()
		{
			return null;
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x8A898C", Offset = "0x8A898C", VA = "0x8A898C")]
		public void SetCurrentSlot(int index)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x8A8994", Offset = "0x8A8994", VA = "0x8A8994")]
		public void Save()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x8A8CF4", Offset = "0x8A8CF4", VA = "0x8A8CF4")]
		public void Load()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x8A8D7C", Offset = "0x8A8D7C", VA = "0x8A8D7C")]
		public SaveMenu()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public class SceneAnimatorController : MonoBehaviour
	{
		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x8A8F64", Offset = "0x8A8F64", VA = "0x8A8F64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x8A8FB4", Offset = "0x8A8FB4", VA = "0x8A8FB4")]
		public void SetAnimatorString(string value)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x8A90B4", Offset = "0x8A90B4", VA = "0x8A90B4")]
		public SceneAnimatorController()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class SeaBedScript : MonoBehaviour
	{
		[Token(Token = "0x2000159")]
		private struct FallenItemInfo
		{
			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform itemTransform;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float timestamp;
		}

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float recoverLatency;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] recoverPoints;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<FallenItemInfo> fallenItems;

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x8A90BC", Offset = "0x8A90BC", VA = "0x8A90BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x8A9130", Offset = "0x8A9130", VA = "0x8A9130")]
		private void Update()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x8A9320", Offset = "0x8A9320", VA = "0x8A9320")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x8A9200", Offset = "0x8A9200", VA = "0x8A9200")]
		private void Recover(Transform item)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x8A93E8", Offset = "0x8A93E8", VA = "0x8A93E8")]
		public SeaBedScript()
		{
		}
	}
	[Token(Token = "0x200015A")]
	public class ShakeObject : MonoBehaviour
	{
		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float MovementShakeStrength;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float RotationShakeStrength;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 m_StartPosition;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion m_StartRotation;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Shaking;

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x8A93F8", Offset = "0x8A93F8", VA = "0x8A93F8")]
		private void Start()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x8A93FC", Offset = "0x8A93FC", VA = "0x8A93FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x8A9554", Offset = "0x8A9554", VA = "0x8A9554")]
		public void StartShaking()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x8A95AC", Offset = "0x8A95AC", VA = "0x8A95AC")]
		public void StopShaking()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x8A9600", Offset = "0x8A9600", VA = "0x8A9600")]
		public ShakeObject()
		{
		}
	}
	[Token(Token = "0x200015B")]
	public class Stabbable : MonoBehaviour
	{
		[Token(Token = "0x200015C")]
		public delegate void StabbedCallback(GameObject obj);

		[Serializable]
		[Token(Token = "0x200015D")]
		public class InteractionEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x8A9BE8", Offset = "0x8A9BE8", VA = "0x8A9BE8")]
			public InteractionEvent()
			{
			}
		}

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int experienceValue;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rigidbody rb;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip stabSound;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isStabbed;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform stabber;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public StabbedCallback onStabbed;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionEvent onInteraction;

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x8A9614", Offset = "0x8A9614", VA = "0x8A9614", Slot = "4")]
		public virtual void HandleStabbed(bool stabbed)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x8A96D8", Offset = "0x8A96D8", VA = "0x8A96D8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x8A9840", Offset = "0x8A9840", VA = "0x8A9840")]
		private void OnStabbed(Collider other)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x8A9A30", Offset = "0x8A9A30", VA = "0x8A9A30")]
		private void SetStabbed(bool stabbed)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x8A9AC4", Offset = "0x8A9AC4", VA = "0x8A9AC4")]
		public Stabbable()
		{
		}
	}
	[Token(Token = "0x200015E")]
	[CreateAssetMenu(fileName = "ItemInfo", menuName = "ScriptableObjects/StorableItemInfo", order = 1)]
	public class StorableItemInfo : ScriptableObject
	{
		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material display;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform prefab;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string displayName;

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x8A9C30", Offset = "0x8A9C30", VA = "0x8A9C30")]
		public StorableItemInfo()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public abstract class StoredItem : MonoBehaviour
	{
		[Token(Token = "0x2000160")]
		[CompilerGenerated]
		private sealed class <TurnOffTip>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public XRBaseInteractable interactable;

			[Token(Token = "0x170000DB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600072F")]
				[Address(RVA = "0x8AB25C", Offset = "0x8AB25C", VA = "0x8AB25C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000731")]
				[Address(RVA = "0x8AB2A4", Offset = "0x8AB2A4", VA = "0x8AB2A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x8AAA98", Offset = "0x8AAA98", VA = "0x8AAA98")]
			[DebuggerHidden]
			public <TurnOffTip>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x8AB0CC", Offset = "0x8AB0CC", VA = "0x8AB0CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x8AB0D0", Offset = "0x8AB0D0", VA = "0x8AB0D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x8AB264", Offset = "0x8AB264", VA = "0x8AB264", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image image;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_Text text;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image durabilityBar;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject recycleHint;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected PrefabName itemName;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int durability;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isRecycleActivated;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float lastActivateTime;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ItemStorer controller;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Focused;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_LeftOrRight;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private XRDirectInteractor m_DirectInteractor;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private XRRayInteractor m_RayInteractor;

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x8A9C38", Offset = "0x8A9C38", VA = "0x8A9C38")]
		private void Awake()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x8A9C94", Offset = "0x8A9C94", VA = "0x8A9C94")]
		private void Start()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x8A9F14", Offset = "0x8A9F14", VA = "0x8A9F14", Slot = "4")]
		protected virtual void Init()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x8A9FA0", Offset = "0x8A9FA0", VA = "0x8A9FA0")]
		private void Update()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x8A9FF4", Offset = "0x8A9FF4", VA = "0x8A9FF4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x8A9FF8", Offset = "0x8A9FF8", VA = "0x8A9FF8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x8AA00C", Offset = "0x8AA00C", VA = "0x8AA00C")]
		public void SetFocus(bool focused, IUIInteractor interactor)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x8AA07C", Offset = "0x8AA07C", VA = "0x8AA07C")]
		private void ShowFocusInfo()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x8AA114", Offset = "0x8AA114", VA = "0x8AA114")]
		private void Recycle(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x8AA3CC", Offset = "0x8AA3CC", VA = "0x8AA3CC")]
		private void Take(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x8AAA30", Offset = "0x8AAA30", VA = "0x8AAA30")]
		[IteratorStateMachine(typeof(<TurnOffTip>d__23))]
		private IEnumerator TurnOffTip(XRBaseInteractable interactable)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		protected abstract void UpdateData(ItemStorer controller, PrefabName itemName);

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x8AAAC0", Offset = "0x8AAAC0", VA = "0x8AAAC0")]
		public void Load(BagItemInfo bagItemInfo)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x8AADC8", Offset = "0x8AADC8", VA = "0x8AADC8")]
		public void Store(PrefabName itemName, int count, int durability)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x8AAF70", Offset = "0x8AAF70", VA = "0x8AAF70")]
		public void Remove(PrefabName itemName, int count)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x8AAD44", Offset = "0x8AAD44", VA = "0x8AAD44")]
		private StorableItemInfo GetItemInfo(PrefabName itemName)
		{
			return null;
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x8AB0BC", Offset = "0x8AB0BC", VA = "0x8AB0BC")]
		protected StoredItem()
		{
		}
	}
	[Token(Token = "0x2000161")]
	public class Supply : MonoBehaviour
	{
		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float energy;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float water;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float vital;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float food;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool makeToxic;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool recoverSick;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool recoverToxic;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Eatable eatComponent;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Potion drinkComponent;

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x8AB2AC", Offset = "0x8AB2AC", VA = "0x8AB2AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x8AB490", Offset = "0x8AB490", VA = "0x8AB490")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x8AB62C", Offset = "0x8AB62C", VA = "0x8AB62C")]
		private void UpdateUserMetrics()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x8AB738", Offset = "0x8AB738", VA = "0x8AB738")]
		public Supply()
		{
		}
	}
	[Token(Token = "0x2000162")]
	public class SynthesisManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000163")]
		public class InteractionEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x8AC16C", Offset = "0x8AC16C", VA = "0x8AC16C")]
			public InteractionEvent()
			{
			}
		}

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SynthesisManager Instance;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int experienceUnit;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip synthesisSound;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SynthesisRecipeCategory[] synthesisRecipeBook;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SynthesisRecipeSetting dynamicRecipe;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<SynthesisRecipeType, List<SynthesisRecipeSetting>> m_RecipeCategories;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static SynthesisRecipeSetting selectedRecipe;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<int, int> onMakeStuffCompleted;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TMP_Text Message;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionEvent onInteraction;

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x8AB740", Offset = "0x8AB740", VA = "0x8AB740")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x8AB89C", Offset = "0x8AB89C", VA = "0x8AB89C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x8AB9F4", Offset = "0x8AB9F4", VA = "0x8AB9F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x8ABA88", Offset = "0x8ABA88", VA = "0x8ABA88")]
		public void TryMakeStuff()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x8AC054", Offset = "0x8AC054", VA = "0x8AC054")]
		public List<SynthesisRecipeSetting> GetRecipes(SynthesisRecipeType category)
		{
			return null;
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x8ABF8C", Offset = "0x8ABF8C", VA = "0x8ABF8C")]
		private bool AddBagItem(PrefabName title, int durability)
		{
			return default(bool);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x8ABEF8", Offset = "0x8ABEF8", VA = "0x8ABEF8")]
		private void RemoveBagItem(PrefabName title, int amount)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x8AB790", Offset = "0x8AB790", VA = "0x8AB790")]
		private void InitRecipes()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x8AB918", Offset = "0x8AB918", VA = "0x8AB918")]
		public void AddRecipe(SynthesisRecipeType type, SynthesisRecipeSetting recipe)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x8ABA00", Offset = "0x8ABA00", VA = "0x8ABA00")]
		public void RemoveRecipe(SynthesisRecipeType type, SynthesisRecipeSetting recipe)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x8AC0E8", Offset = "0x8AC0E8", VA = "0x8AC0E8")]
		public SynthesisManager()
		{
		}
	}
	[Token(Token = "0x2000164")]
	[CreateAssetMenu(fileName = "SynthesisRecipeCategory", menuName = "ScriptableObjects/SynthesisRecipeCategory", order = 2)]
	public class SynthesisRecipeCategory : ScriptableObject
	{
		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SynthesisRecipeType category;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SynthesisRecipeSetting[] recipes;

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x8AC1B4", Offset = "0x8AC1B4", VA = "0x8AC1B4")]
		public SynthesisRecipeCategory()
		{
		}
	}
	[Token(Token = "0x2000165")]
	public enum SynthesisRecipeType
	{
		[Token(Token = "0x400083D")]
		Weapons,
		[Token(Token = "0x400083E")]
		Tools,
		[Token(Token = "0x400083F")]
		Fire,
		[Token(Token = "0x4000840")]
		Camping,
		[Token(Token = "0x4000841")]
		Consumables,
		[Token(Token = "0x4000842")]
		Planting,
		[Token(Token = "0x4000843")]
		Ship,
		[Token(Token = "0x4000844")]
		Foundation,
		[Token(Token = "0x4000845")]
		Floor,
		[Token(Token = "0x4000846")]
		Wall,
		[Token(Token = "0x4000847")]
		Roof,
		[Token(Token = "0x4000848")]
		Stairs,
		[Token(Token = "0x4000849")]
		Window,
		[Token(Token = "0x400084A")]
		DoorWay,
		[Token(Token = "0x400084B")]
		Furniture,
		[Token(Token = "0x400084C")]
		Decoration
	}
	[Token(Token = "0x2000166")]
	[CreateAssetMenu(fileName = "SynthesisRecipeSetting", menuName = "ScriptableObjects/SynthesisRecipeSetting", order = 1)]
	public class SynthesisRecipeSetting : ScriptableObject
	{
		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PrefabName title;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material icon;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string description;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int level;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int durability;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool notInDemo;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IngredientInfo[] ingredients;

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x8AC1BC", Offset = "0x8AC1BC", VA = "0x8AC1BC")]
		public SynthesisRecipeSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000167")]
	public class IngredientInfo
	{
		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PrefabName type;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int amount;

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x8AC1C4", Offset = "0x8AC1C4", VA = "0x8AC1C4")]
		public IngredientInfo()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class SystemMenu : MonoBehaviour
	{
		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject mainMenu;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject lastMenu;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] menus;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Sprite buttonNormal;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Sprite buttonHighlight;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x8AC1CC", Offset = "0x8AC1CC", VA = "0x8AC1CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x8AC3B8", Offset = "0x8AC3B8", VA = "0x8AC3B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x8AC248", Offset = "0x8AC248", VA = "0x8AC248")]
		public void ShowMenu(GameObject menu)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x8AC41C", Offset = "0x8AC41C", VA = "0x8AC41C")]
		public SystemMenu()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class Target : MonoBehaviour, IHittable
	{
		[Serializable]
		[Token(Token = "0x200016A")]
		public class DamageEvent : UnityEvent<int>
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x8AC574", Offset = "0x8AC574", VA = "0x8AC574")]
			public DamageEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016B")]
		public class InteractionEvent : UnityEvent<string>
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x8AC5BC", Offset = "0x8AC5BC", VA = "0x8AC5BC")]
			public InteractionEvent()
			{
			}
		}

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int experienceValue;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float forceAmount;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DamageEvent onDamage;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionEvent onInteraction;

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x8AC424", Offset = "0x8AC424", VA = "0x8AC424", Slot = "4")]
		public void Hit(int damage)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x8AC560", Offset = "0x8AC560", VA = "0x8AC560")]
		public Target()
		{
		}
	}
	[Token(Token = "0x200016C")]
	public class AppleTask : ATask
	{
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x8AC604", Offset = "0x8AC604", VA = "0x8AC604")]
		public AppleTask()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x8AC718", Offset = "0x8AC718", VA = "0x8AC718")]
		private void FruitDown()
		{
		}
	}
	[Token(Token = "0x200016D")]
	public class ATask
	{
		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int experienceValue;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected bool isCompleted;

		[Token(Token = "0x170000DD")]
		public bool IsCompleted
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x8AC848", Offset = "0x8AC848", VA = "0x8AC848")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x8AC850", Offset = "0x8AC850", VA = "0x8AC850")]
			set
			{
			}
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x8AC85C", Offset = "0x8AC85C", VA = "0x8AC85C")]
		public bool IsTaskCompleted()
		{
			return default(bool);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x8AC708", Offset = "0x8AC708", VA = "0x8AC708")]
		public ATask()
		{
		}
	}
	[Token(Token = "0x200016E")]
	internal class BackpackTask : ATask
	{
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x8AC864", Offset = "0x8AC864", VA = "0x8AC864")]
		public BackpackTask()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x8AC978", Offset = "0x8AC978", VA = "0x8AC978")]
		private void CheckStoreItem(int prefabName)
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class BamboolPipeTask : ATask
	{
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x8ACAC4", Offset = "0x8ACAC4", VA = "0x8ACAC4")]
		public BamboolPipeTask()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x8ACBD8", Offset = "0x8ACBD8", VA = "0x8ACBD8")]
		private void CheckBambooPipeMade(int type, int durability)
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class BamboolPoleTask : ATask
	{
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x8ACD24", Offset = "0x8ACD24", VA = "0x8ACD24")]
		public BamboolPoleTask()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x8ACE38", Offset = "0x8ACE38", VA = "0x8ACE38")]
		private void CheckBambooPoleMade(int type, int durability)
		{
		}
	}
	[Token(Token = "0x2000171")]
	public class CocoTask : ATask
	{
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x8ACF84", Offset = "0x8ACF84", VA = "0x8ACF84")]
		public CocoTask()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x8AD07C", Offset = "0x8AD07C", VA = "0x8AD07C")]
		private void CheckDrink()
		{
		}
	}
	[Token(Token = "0x2000172")]
	internal class CraftMenuTask : ATask
	{
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x8AD1A0", Offset = "0x8AD1A0", VA = "0x8AD1A0")]
		public CraftMenuTask()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x8AD2B4", Offset = "0x8AD2B4", VA = "0x8AD2B4")]
		private void CheckSynthesisBookOpen(string menuName)
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class FishTask : ATask
	{
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x8AD424", Offset = "0x8AD424", VA = "0x8AD424")]
		public FishTask()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x8AD528", Offset = "0x8AD528", VA = "0x8AD528")]
		private void OnStabbed()
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class KnifeTask : ATask
	{
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x8AD658", Offset = "0x8AD658", VA = "0x8AD658")]
		public KnifeTask()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x8AD76C", Offset = "0x8AD76C", VA = "0x8AD76C")]
		private void CheckKnifeMade(int type, int durability)
		{
		}
	}
	[Token(Token = "0x2000175")]
	[CreateAssetMenu(fileName = "MissionInfo", menuName = "ScriptableObjects/Mission")]
	public class Mission : ScriptableObject
	{
		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string missionName;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<TaskInfo> tasks;

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x8AD8B8", Offset = "0x8AD8B8", VA = "0x8AD8B8")]
		public Mission()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000176")]
	public class TaskInfo
	{
		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string hintText;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string taskType;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isCompleted;

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x8AD8C0", Offset = "0x8AD8C0", VA = "0x8AD8C0")]
		public TaskInfo()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class PlantingTask : ATask
	{
		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static System.Action planted;

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x8AD8C8", Offset = "0x8AD8C8", VA = "0x8AD8C8")]
		public PlantingTask()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x8AD9CC", Offset = "0x8AD9CC", VA = "0x8AD9CC")]
		private void OnPlantCompleted()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class SleepTask : ATask
	{
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x8ADAFC", Offset = "0x8ADAFC", VA = "0x8ADAFC")]
		public SleepTask()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x8ADC00", Offset = "0x8ADC00", VA = "0x8ADC00")]
		private void CheckSleep()
		{
		}
	}
	[Token(Token = "0x2000179")]
	public class SurvivalBookTask : ATask
	{
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x8ADD30", Offset = "0x8ADD30", VA = "0x8ADD30")]
		public SurvivalBookTask()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x8ADE34", Offset = "0x8ADE34", VA = "0x8ADE34")]
		private void CheckSurvivalBook()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class TaskManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017B")]
		public struct MissionJsonObj
		{
			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int MissionIndex;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<bool> StatusOfTasks;
		}

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip completedSound;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_Text missionName;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Mission[] missions;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TaskPanel[] panels;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject exit;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform anchor;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int index;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<ATask> currentTasks;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<ATask> onTaskCompleted;

		[Token(Token = "0x4000870")]
		public const string PREFKEY_MISSION_AND_TASK = "MissionAndTask";

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static TaskManager Instance;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Initialized;

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x8ADF64", Offset = "0x8ADF64", VA = "0x8ADF64")]
		private void Awake()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x8ADFB4", Offset = "0x8ADFB4", VA = "0x8ADFB4")]
		public void Save()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x8AE28C", Offset = "0x8AE28C", VA = "0x8AE28C")]
		public void Load()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x8AEB4C", Offset = "0x8AEB4C", VA = "0x8AEB4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x8AEC4C", Offset = "0x8AEC4C", VA = "0x8AEC4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x8AED4C", Offset = "0x8AED4C", VA = "0x8AED4C")]
		private void OnTaskCompleted(ATask task)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x8AE824", Offset = "0x8AE824", VA = "0x8AE824")]
		private void UpdatePanel(ATask task)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x8AF2C8", Offset = "0x8AF2C8", VA = "0x8AF2C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x8AE624", Offset = "0x8AE624", VA = "0x8AE624")]
		private void SetupMission(Mission mission)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x8AF370", Offset = "0x8AF370", VA = "0x8AF370")]
		private void Initialize(TaskInfo task)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x8AEA00", Offset = "0x8AEA00", VA = "0x8AEA00")]
		private bool CheckMissionCompleted()
		{
			return default(bool);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x8AFF08", Offset = "0x8AFF08", VA = "0x8AFF08")]
		public TaskManager()
		{
		}
	}
	[Token(Token = "0x200017C")]
	public class TaskPanel : MonoBehaviour
	{
		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle toggle;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_Text text;

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x8AF224", Offset = "0x8AF224", VA = "0x8AF224")]
		public void UpdateTaskPanel(TaskInfo info)
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x8AFF10", Offset = "0x8AFF10", VA = "0x8AFF10")]
		public TaskPanel()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class TentTask : ATask
	{
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x8AFCF0", Offset = "0x8AFCF0", VA = "0x8AFCF0")]
		public TentTask()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x8AFF18", Offset = "0x8AFF18", VA = "0x8AFF18")]
		private void CheckShantyMade(int type, int durability)
		{
		}
	}
	[Token(Token = "0x200017E")]
	public class VitalSignTask : ATask
	{
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x8AFE04", Offset = "0x8AFE04", VA = "0x8AFE04")]
		public VitalSignTask()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x8B0064", Offset = "0x8B0064", VA = "0x8B0064")]
		private void CheckWatch()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public class Tent : MonoBehaviour
	{
		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int experienceValue;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float recoverCoeff;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool allowedSleepAllTime;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Selectable sleepButton;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isSleepTime;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static System.Action onSleepClicked;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float lastTime;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Renderer render;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isSleeping;

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x8B0194", Offset = "0x8B0194", VA = "0x8B0194")]
		public void TryToSleep()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x8B0358", Offset = "0x8B0358", VA = "0x8B0358")]
		private void Start()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x8B03FC", Offset = "0x8B03FC", VA = "0x8B03FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x8B0528", Offset = "0x8B0528", VA = "0x8B0528")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x8B0628", Offset = "0x8B0628", VA = "0x8B0628")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x8B072C", Offset = "0x8B072C", VA = "0x8B072C")]
		private void Wake()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x8B09FC", Offset = "0x8B09FC", VA = "0x8B09FC")]
		public void SetStable()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x8B0A4C", Offset = "0x8B0A4C", VA = "0x8B0A4C")]
		private void SetKinematic()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x8B0AA8", Offset = "0x8B0AA8", VA = "0x8B0AA8")]
		public void Pack()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x8B0BF8", Offset = "0x8B0BF8", VA = "0x8B0BF8")]
		public Tent()
		{
		}
	}
	[Token(Token = "0x2000180")]
	public class TimeConsumer : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000181")]
		public class ConsumeEvent : UnityEvent<int>
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0x8B0CC4", Offset = "0x8B0CC4", VA = "0x8B0CC4")]
			public ConsumeEvent()
			{
			}
		}

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int experienceValue;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int damage;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ConsumeCycle;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool enableFirst;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_ElapsedTime;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool isEnabled;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ConsumeEvent onConsume;

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x8B0C0C", Offset = "0x8B0C0C", VA = "0x8B0C0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x8B0C20", Offset = "0x8B0C20", VA = "0x8B0C20")]
		private void Update()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x8B0CA8", Offset = "0x8B0CA8", VA = "0x8B0CA8")]
		public TimeConsumer()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public enum TimeOfDay
	{
		[Token(Token = "0x4000888")]
		Dawn,
		[Token(Token = "0x4000889")]
		Day,
		[Token(Token = "0x400088A")]
		NightFall,
		[Token(Token = "0x400088B")]
		Night,
		[Token(Token = "0x400088C")]
		Midnight
	}
	[Serializable]
	[Token(Token = "0x2000183")]
	public struct GameDate
	{
		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Day;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int Hour;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int Minute;
	}
	[Token(Token = "0x2000184")]
	public class TimeController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000185")]
		public struct TimeJsonObj
		{
			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float NormalizedTime;

			[Token(Token = "0x40008B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int CurrentDay;

			[Token(Token = "0x40008BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int CurrentHour;

			[Token(Token = "0x40008BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int CurrentMin;
		}

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TimeController Instance;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TimeOfDay State;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public System.Action onDayAdded;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public System.Action onNightFall;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<TimeOfDay> onStateChanged;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Setup")]
		[SerializeField]
		private Light m_Sun;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Light m_Moon;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("General")]
		[SerializeField]
		private bool m_StopTime;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool m_IsFogOn;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private int m_currentDay;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private int m_CurrentMin;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Range(0f, 24f)]
		[Tooltip("The current hour (00:00 AM to 12:00 PM to 24:00 PM)")]
		private int m_CurrentHour;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("How many seconds are in a day.")]
		[SerializeField]
		private int m_DayDuration;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Tooltip("On which axis should the moon and sun rotate?")]
		private Vector3 m_RotationAxis;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Fog")]
		[SerializeField]
		private FogMode m_FogMode;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Fog intensity variation over the whole day & night cycle.")]
		[SerializeField]
		private AnimationCurve m_FogIntensity;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Tooltip("Fog color variation over the whole day & night cycle.")]
		private Gradient m_FogColor;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Sun")]
		[SerializeField]
		[Tooltip("Sun intensity variation over the whole day & night cycle.")]
		private AnimationCurve m_SunIntensity;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Tooltip("Sun color variation over the whole day & night cycle.")]
		private Gradient m_SunColor;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Tooltip("Sun rotation variation over the whole day & night cycle.")]
		private AnimationCurve m_SunRotation;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Tooltip("Moon intensity variation over the whole day & night cycle.")]
		[Header("Moon")]
		[SerializeField]
		private AnimationCurve m_MoonIntensity;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Tooltip("Moon color variation over the whole day & night cycle.")]
		[SerializeField]
		private Gradient m_MoonColor;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Header("Skybox")]
		[SerializeField]
		private Material m_Skybox;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AnimationCurve m_SkyboxBlend;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject waterEffects;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private ParticleSystem[] particles;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private AnimationCurve m_WaterBlend;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TimeOfDay m_InternalState;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Transform m_SunTransform;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Transform m_MoonTransform;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float m_NormalizedTime;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float m_TimeIncrement;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Color waterPSColor;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool countDay;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int m_InitialHour;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Color color0;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Color color1;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Color color2;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Color fresnel;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Camera mainCamera;

		[Token(Token = "0x170000DE")]
		public float NormalizedTime
		{
			[Token(Token = "0x6000789")]
			[Address(RVA = "0x8B0D0C", Offset = "0x8B0D0C", VA = "0x8B0D0C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600078A")]
			[Address(RVA = "0x8B0944", Offset = "0x8B0944", VA = "0x8B0944")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public int CurrentHour
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x8B0D14", Offset = "0x8B0D14", VA = "0x8B0D14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E0")]
		public int CurrentDay
		{
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x8B0D1C", Offset = "0x8B0D1C", VA = "0x8B0D1C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x8B0D24", Offset = "0x8B0D24", VA = "0x8B0D24")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public int CurrentMin
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x8B0D2C", Offset = "0x8B0D2C", VA = "0x8B0D2C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E2")]
		public int HourPastInitial
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x8A8CD8", Offset = "0x8A8CD8", VA = "0x8A8CD8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x8B0D34", Offset = "0x8B0D34", VA = "0x8B0D34")]
		protected void Awake()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x8B0F70", Offset = "0x8B0F70", VA = "0x8B0F70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x8B0FD0", Offset = "0x8B0FD0", VA = "0x8B0FD0")]
		private bool IsInRangeLimitsExcluded(float f, float low, float high)
		{
			return default(bool);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x8B0FE8", Offset = "0x8B0FE8", VA = "0x8B0FE8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x8B1788", Offset = "0x8B1788", VA = "0x8B1788")]
		private void SetUnderWaterFog()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x8B1718", Offset = "0x8B1718", VA = "0x8B1718")]
		private void CaculateDay()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x8B0EB0", Offset = "0x8B0EB0", VA = "0x8B0EB0")]
		private TimeOfDay GetTimeOfDay(float normalizedTime)
		{
			return default(TimeOfDay);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x8B0F44", Offset = "0x8B0F44", VA = "0x8B0F44")]
		private void AccommodateEditorChanges()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x8B17DC", Offset = "0x8B17DC", VA = "0x8B17DC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x8B1824", Offset = "0x8B1824", VA = "0x8B1824")]
		public void SaveLocal()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x8B18B0", Offset = "0x8B18B0", VA = "0x8B18B0")]
		public void LoadLocal()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x8A3E50", Offset = "0x8A3E50", VA = "0x8A3E50")]
		public int GetDuration(GameDate date)
		{
			return default(int);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x8A3C64", Offset = "0x8A3C64", VA = "0x8A3C64")]
		public GameDate GetNow()
		{
			return default(GameDate);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x8B1930", Offset = "0x8B1930", VA = "0x8B1930")]
		public TimeController()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class TimeDisplayer : MonoBehaviour
	{
		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_Text text;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private StringBuilder builder;

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x8B19DC", Offset = "0x8B19DC", VA = "0x8B19DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x8B1A64", Offset = "0x8B1A64", VA = "0x8B1A64")]
		private string GetTimeString()
		{
			return null;
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x8B1C70", Offset = "0x8B1C70", VA = "0x8B1C70")]
		private void Update()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x8B1CA0", Offset = "0x8B1CA0", VA = "0x8B1CA0")]
		public TimeDisplayer()
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class ToolsSwitcher : MonoBehaviour
	{
		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("Switch Tools")]
		[SerializeField]
		[Tooltip("The reference to switch tools of hand.")]
		private InputActionReference m_ToolSwitchSwitch;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int toolsCount;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int pressedCount;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ActionBasedController controller;

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x8B1CA8", Offset = "0x8B1CA8", VA = "0x8B1CA8")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x8B1DC4", Offset = "0x8B1DC4", VA = "0x8B1DC4")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x8B1E5C", Offset = "0x8B1E5C", VA = "0x8B1E5C")]
		private void OnSwitchToolPerformed(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x8B1EDC", Offset = "0x8B1EDC", VA = "0x8B1EDC")]
		private void DisableAll()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x8B1F64", Offset = "0x8B1F64", VA = "0x8B1F64")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x8B1FD4", Offset = "0x8B1FD4", VA = "0x8B1FD4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x8B1D40", Offset = "0x8B1D40", VA = "0x8B1D40")]
		private InputAction GetInputAction(InputActionReference actionReference)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x8B1FD8", Offset = "0x8B1FD8", VA = "0x8B1FD8")]
		public ToolsSwitcher()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class TransportController : MonoBehaviour
	{
		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isPlayerOn;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool isBuildingDone;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float speed;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float torque;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float torqueThresold;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isInitialized;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform mainCamera;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 startWorldAxis;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BuildingHolder ship;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DialInteractable rudderDial;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<SailController> sails;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<PrefabName> requiredPieces;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<PrefabName, List<BuildingPiece>> collectedPieces;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 orig;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 direction;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool powerOn;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool inWater;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		private bool nearLand;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string[] layers;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool hint;

		[Token(Token = "0x170000E3")]
		public bool IsReady
		{
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x8B1FE0", Offset = "0x8B1FE0", VA = "0x8B1FE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x8B1FE8", Offset = "0x8B1FE8", VA = "0x8B1FE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x8B22A8", Offset = "0x8B22A8", VA = "0x8B22A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x8B254C", Offset = "0x8B254C", VA = "0x8B254C")]
		private bool ApartFromLand()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x8A83CC", Offset = "0x8A83CC", VA = "0x8A83CC")]
		public void SetSail()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x8A84C8", Offset = "0x8A84C8", VA = "0x8A84C8")]
		public void CaculateDirection()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x8B1FEC", Offset = "0x8B1FEC", VA = "0x8B1FEC")]
		public void Init()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x8B2BF4", Offset = "0x8B2BF4", VA = "0x8B2BF4")]
		public void AddPiece(BuildingPiece piece)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x8B2ED8", Offset = "0x8B2ED8", VA = "0x8B2ED8")]
		public bool CheckBuildingCompleted()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x8B22F8", Offset = "0x8B22F8", VA = "0x8B22F8")]
		private void CheckPlayerOnStatus(Transform player)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x8B27FC", Offset = "0x8B27FC", VA = "0x8B27FC")]
		private void ProcessUserInputs()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x8B30C0", Offset = "0x8B30C0", VA = "0x8B30C0")]
		private void RotateTowards(float rotationSpeed)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x8B3368", Offset = "0x8B3368", VA = "0x8B3368")]
		private void Rudder_OnDialAngleChanged(float angle)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x8B36BC", Offset = "0x8B36BC", VA = "0x8B36BC")]
		public void Remove(BuildingPiece piece)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x8B2AA0", Offset = "0x8B2AA0", VA = "0x8B2AA0")]
		private bool IsOnWater(Vector3 position)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x8B3934", Offset = "0x8B3934", VA = "0x8B3934")]
		public void TestOnWater()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x8A6D34", Offset = "0x8A6D34", VA = "0x8A6D34")]
		public void CollideWithLand()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x8A6EB4", Offset = "0x8A6EB4", VA = "0x8A6EB4")]
		public void LeaveLand()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x8B3A38", Offset = "0x8B3A38", VA = "0x8B3A38")]
		public TransportController()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class UserInfoDisplayer : MonoBehaviour
	{
		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_Text userName;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_Text level;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_Text experience;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TMP_Text levelExp;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Image expImage;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TMP_Text number;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject toxic;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject sick;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TMP_Text mode;

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x8B3B98", Offset = "0x8B3B98", VA = "0x8B3B98")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x8B3EC4", Offset = "0x8B3EC4", VA = "0x8B3EC4")]
		public UserInfoDisplayer()
		{
		}
	}
	[Token(Token = "0x200018A")]
	public class UserMessage : MonoBehaviour
	{
		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool enable;

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x8B3ECC", Offset = "0x8B3ECC", VA = "0x8B3ECC")]
		public void ShowMessage(string messageCode)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x8B3F38", Offset = "0x8B3F38", VA = "0x8B3F38")]
		public void ShowFirstDayHint(string messageCode)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x8B3FCC", Offset = "0x8B3FCC", VA = "0x8B3FCC")]
		public UserMessage()
		{
		}
	}
	[Token(Token = "0x200018B")]
	[RequireComponent(typeof(Consumable))]
	public class VitalBar : MonoBehaviour
	{
		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image bar;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float initialValue;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Consumable consumable;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Canvas barCanvas;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Billboard billboard;

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x8B3FDC", Offset = "0x8B3FDC", VA = "0x8B3FDC")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x8B4210", Offset = "0x8B4210", VA = "0x8B4210")]
		private void UpdateBar(int value)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x8B42DC", Offset = "0x8B42DC", VA = "0x8B42DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x8B43CC", Offset = "0x8B43CC", VA = "0x8B43CC")]
		public VitalBar()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class WaterContainer : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200018D")]
		public class UsedEvent : UnityEvent
		{
			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x8B4A38", Offset = "0x8B4A38", VA = "0x8B4A38")]
			public UsedEvent()
			{
			}
		}

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int experienceValue;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Animator animator;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem bubble;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip sound;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isEmpty;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Potion potion;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UsedEvent onUsed;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float triggeredTime;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool isFull;

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x8B43D4", Offset = "0x8B43D4", VA = "0x8B43D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x8B4500", Offset = "0x8B4500", VA = "0x8B4500")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x8B4678", Offset = "0x8B4678", VA = "0x8B4678")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x8B47B4", Offset = "0x8B47B4", VA = "0x8B47B4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x8B48D0", Offset = "0x8B48D0", VA = "0x8B48D0")]
		public void OnPoured(float ratio)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x8B4968", Offset = "0x8B4968", VA = "0x8B4968")]
		public void OnPouringPaused()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x8B49C0", Offset = "0x8B49C0", VA = "0x8B49C0")]
		public void OnPouringEnded()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x8B4A20", Offset = "0x8B4A20", VA = "0x8B4A20")]
		public WaterContainer()
		{
		}
	}
	[Token(Token = "0x200018E")]
	public class WaterFilterContainer : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200018F")]
		public class UsedEvent : UnityEvent
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x8B535C", Offset = "0x8B535C", VA = "0x8B535C")]
			public UsedEvent()
			{
			}
		}

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cycleTime;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip containerIn;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int experienceValue;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Animator animator;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isEmpty;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Potion drinkable;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform anchorPoint;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UsedEvent onUsed;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float triggeredTime;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool isFull;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rb;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image progressImage;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TMP_Text progressText;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private StoredValue storedRatio;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float initialValue;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool isFirstTime;

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x8B4A40", Offset = "0x8B4A40", VA = "0x8B4A40")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x8B4B0C", Offset = "0x8B4B0C", VA = "0x8B4B0C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x8B4DE4", Offset = "0x8B4DE4", VA = "0x8B4DE4")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x8B5068", Offset = "0x8B5068", VA = "0x8B5068")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x8B516C", Offset = "0x8B516C", VA = "0x8B516C")]
		public void ResetPosition()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x8B51E8", Offset = "0x8B51E8", VA = "0x8B51E8")]
		public void OnPoured(float ratio)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x8B5280", Offset = "0x8B5280", VA = "0x8B5280")]
		public void OnPouringPaused()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x8B52D8", Offset = "0x8B52D8", VA = "0x8B52D8")]
		public void OnPouringEnded()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x8B5338", Offset = "0x8B5338", VA = "0x8B5338")]
		public WaterFilterContainer()
		{
		}
	}
	[Token(Token = "0x2000190")]
	public enum WeatherState
	{
		[Token(Token = "0x4000900")]
		Sunny,
		[Token(Token = "0x4000901")]
		Rainy,
		[Token(Token = "0x4000902")]
		Windy
	}
	[Token(Token = "0x2000191")]
	public class WeatherController : MonoBehaviour
	{
		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static WeatherState state;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject rain;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip thunder;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Camera mainCamera;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float rainPossibility;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int rainInterval;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int lastRainDay;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int lastRainTime;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WeatherState lastState;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<WeatherState> onWeatherChanged;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static System.Action onRaining;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool isChanging;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float rainHeight;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 rainPos;

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x8B5364", Offset = "0x8B5364", VA = "0x8B5364")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x8B53AC", Offset = "0x8B53AC", VA = "0x8B53AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x8B5630", Offset = "0x8B5630", VA = "0x8B5630")]
		private void RandomWeather()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x8B579C", Offset = "0x8B579C", VA = "0x8B579C")]
		private void PlayAnimation(WeatherState state)
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x8B595C", Offset = "0x8B595C", VA = "0x8B595C")]
		private void SetSick()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x8B59EC", Offset = "0x8B59EC", VA = "0x8B59EC")]
		private void StartRain()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x8B5A0C", Offset = "0x8B5A0C", VA = "0x8B5A0C")]
		private void StopRain()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x8B5930", Offset = "0x8B5930", VA = "0x8B5930")]
		private void StopAll()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x8B56E0", Offset = "0x8B56E0", VA = "0x8B56E0")]
		private WeatherState GetWeatherState()
		{
			return default(WeatherState);
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x8B5A38", Offset = "0x8B5A38", VA = "0x8B5A38")]
		private int GetRainTimeInterval()
		{
			return default(int);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x8B5AA8", Offset = "0x8B5AA8", VA = "0x8B5AA8")]
		public WeatherController()
		{
		}
	}
	[Token(Token = "0x2000192")]
	public class GridTerrian : MonoBehaviour
	{
		[Token(Token = "0x2000193")]
		public class GridArea
		{
			[Token(Token = "0x2000194")]
			public enum GridType
			{
				[Token(Token = "0x400091B")]
				Default,
				[Token(Token = "0x400091C")]
				Earth,
				[Token(Token = "0x400091D")]
				Stone
			}

			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private List<int> m_Grids;

			[Token(Token = "0x170000E4")]
			public GridType Type
			{
				[Token(Token = "0x60007F9")]
				[Address(RVA = "0x8B71F4", Offset = "0x8B71F4", VA = "0x8B71F4")]
				[CompilerGenerated]
				get
				{
					return default(GridType);
				}
				[Token(Token = "0x60007FA")]
				[Address(RVA = "0x8B71FC", Offset = "0x8B71FC", VA = "0x8B71FC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000E5")]
			public List<int> Grids
			{
				[Token(Token = "0x60007FB")]
				[Address(RVA = "0x8B7204", Offset = "0x8B7204", VA = "0x8B7204")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E6")]
			public int NumOfGrids
			{
				[Token(Token = "0x60007FC")]
				[Address(RVA = "0x8B604C", Offset = "0x8B604C", VA = "0x8B604C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x8B5E70", Offset = "0x8B5E70", VA = "0x8B5E70")]
			public GridArea(GridType type = GridType.Default)
			{
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x8B60B0", Offset = "0x8B60B0", VA = "0x8B60B0")]
			public bool AddGrid(int grid)
			{
				return default(bool);
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x8B720C", Offset = "0x8B720C", VA = "0x8B720C")]
			public bool Contains(int grid)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rect m_RectArea;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_GridWidth;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_RowStride;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_ColStride;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_TotalNumGrids;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<int> m_OccupiedGrids;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<GridArea> m_Patches;

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x8B5AC4", Offset = "0x8B5AC4", VA = "0x8B5AC4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x8B5B7C", Offset = "0x8B5B7C", VA = "0x8B5B7C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x8A396C", Offset = "0x8A396C", VA = "0x8A396C")]
		public void Init(Bounds bounds)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x8B5B80", Offset = "0x8B5B80", VA = "0x8B5B80")]
		public void Init(Rect area)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x8B5C10", Offset = "0x8B5C10", VA = "0x8B5C10")]
		public int GetGridIndex(Vector3 point)
		{
			return default(int);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x8B5C18", Offset = "0x8B5C18", VA = "0x8B5C18")]
		public int GetGridIndex(Vector2 point)
		{
			return default(int);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x8B5CBC", Offset = "0x8B5CBC", VA = "0x8B5CBC")]
		public Rect GetGridRect(int grid)
		{
			return default(Rect);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x8B5D54", Offset = "0x8B5D54", VA = "0x8B5D54")]
		public GridArea CalcPatch(Vector3 origin, GridArea.GridType type)
		{
			return null;
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x8B5F00", Offset = "0x8B5F00", VA = "0x8B5F00")]
		private void AddPatch(int grid, GridArea patch)
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x8B618C", Offset = "0x8B618C", VA = "0x8B618C")]
		public GridArea CalcPatch(Rect rect, GridArea.GridType type)
		{
			return null;
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x8B684C", Offset = "0x8B684C", VA = "0x8B684C")]
		public bool TryPlaceRect(Rect rect)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x8B6ED4", Offset = "0x8B6ED4", VA = "0x8B6ED4")]
		public bool TryPlaceObject(Bounds bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x8B6F78", Offset = "0x8B6F78", VA = "0x8B6F78")]
		public void MarkRectOccupied(Rect rect)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x8B6F98", Offset = "0x8B6F98", VA = "0x8B6F98")]
		public void UnmarkRectOccupied(Rect rect)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x8B716C", Offset = "0x8B716C", VA = "0x8B716C")]
		public bool IsRectOccupied(Rect rect)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x8B718C", Offset = "0x8B718C", VA = "0x8B718C")]
		public bool IsGridOccupied(int grid)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x8B6094", Offset = "0x8B6094", VA = "0x8B6094")]
		private bool ValidateGrid(int grid)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x8B6AC4", Offset = "0x8B6AC4", VA = "0x8B6AC4")]
		private bool IsAreaOccupied(GridArea area)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x8B6C90", Offset = "0x8B6C90", VA = "0x8B6C90")]
		private void MarkAreaOccupied(GridArea area)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x8B6FB8", Offset = "0x8B6FB8", VA = "0x8B6FB8")]
		private void UnmarkAreaOccupied(GridArea area)
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x8B71E4", Offset = "0x8B71E4", VA = "0x8B71E4")]
		public GridTerrian()
		{
		}
	}
	[Token(Token = "0x2000195")]
	public class ElysiumContinuousMoveProvider : ActionBasedContinuousMoveProvider
	{
		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Transform[] recoverPoints;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string[] allowedLayers;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 originalPos;

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x8B7264", Offset = "0x8B7264", VA = "0x8B7264")]
		private void Start()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x8B7294", Offset = "0x8B7294", VA = "0x8B7294", Slot = "6")]
		protected override Vector3 ComputeDesiredMove(Vector2 input)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x8B73CC", Offset = "0x8B73CC", VA = "0x8B73CC")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x8B7474", Offset = "0x8B7474", VA = "0x8B7474")]
		private void ResetPosition()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x8B7618", Offset = "0x8B7618", VA = "0x8B7618")]
		public ElysiumContinuousMoveProvider()
		{
		}
	}
	[Token(Token = "0x2000196")]
	public class SteeringWheel : XRBaseInteractable
	{
		[Serializable]
		[Token(Token = "0x2000197")]
		public class RotationChangedEvent : UnityEvent<float>
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x8B7CB8", Offset = "0x8B7CB8", VA = "0x8B7CB8")]
			public RotationChangedEvent()
			{
			}
		}

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Transform wheelTransform;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public RotationChangedEvent OnWheelRotated;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float currentAngle;

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x8B7620", Offset = "0x8B7620", VA = "0x8B7620", Slot = "66")]
		protected override void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x8B7854", Offset = "0x8B7854", VA = "0x8B7854", Slot = "68")]
		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x8B7878", Offset = "0x8B7878", VA = "0x8B7878", Slot = "58")]
		public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x8B78C4", Offset = "0x8B78C4", VA = "0x8B78C4")]
		private void RotateWheel()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x8B7644", Offset = "0x8B7644", VA = "0x8B7644")]
		private float FindWheelAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x8B797C", Offset = "0x8B797C", VA = "0x8B797C")]
		private Vector3 FindLocalPoint(Vector3 position)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x8B7A7C", Offset = "0x8B7A7C", VA = "0x8B7A7C")]
		private float ConvertToAngle(Vector3 direction)
		{
			return default(float);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x8B7C5C", Offset = "0x8B7C5C", VA = "0x8B7C5C")]
		private float FindRotationSensitivity()
		{
			return default(float);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x8B7CB0", Offset = "0x8B7CB0", VA = "0x8B7CB0")]
		public SteeringWheel()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public class TwoHandsRotatable : XRBaseInteractable
	{
		[Serializable]
		[Token(Token = "0x2000199")]
		public class RotationChangedEvent : UnityEvent<TwoHandsRotatable>
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x8B9A50", Offset = "0x8B9A50", VA = "0x8B9A50")]
			public RotationChangedEvent()
			{
			}
		}

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public Rigidbody RotatingRigidbody;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Vector3 LocalRotationAxis;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public Vector3 LocalAxisStart;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public RotationChangedEvent OnRotationChanged;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 m_StartingWorldAxis;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Transform m_OriginalTransform;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Transform m_SyncTransform;

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x8B7D00", Offset = "0x8B7D00", VA = "0x8B7D00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x8B7FF4", Offset = "0x8B7FF4", VA = "0x8B7FF4", Slot = "66")]
		protected override void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x8B7FFC", Offset = "0x8B7FFC", VA = "0x8B7FFC", Slot = "68")]
		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x8B8004", Offset = "0x8B8004", VA = "0x8B8004", Slot = "58")]
		public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x8B8A48", Offset = "0x8B8A48", VA = "0x8B8A48")]
		public TwoHandsRotatable()
		{
		}
	}
	[Token(Token = "0x200019A")]
	public class Liquid : MonoBehaviour
	{
		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float MaxWobble;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float WobbleSpeed;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float RecoveryRate;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float initialValue;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Renderer rend;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 prevPos;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 prevRot;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float wobbleAmountToAddX;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float wobbleAmountToAddZ;

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x8B9A98", Offset = "0x8B9A98", VA = "0x8B9A98")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x8B9AE8", Offset = "0x8B9AE8", VA = "0x8B9AE8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x8B9D80", Offset = "0x8B9D80", VA = "0x8B9D80")]
		public void SetFillAmount(float fillRatio)
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x8B9DFC", Offset = "0x8B9DFC", VA = "0x8B9DFC")]
		public Liquid()
		{
		}
	}
	[Token(Token = "0x200019B")]
	public class LocalizedDropdown : MonoBehaviour, ILocalizationHandler
	{
		[Serializable]
		[Token(Token = "0x200019C")]
		public class Option
		{
			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[LeanTranslationName]
			public string StringTranslationName;

			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[LeanTranslationName]
			public string SpriteTranslationName;

			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("If StringTranslationName couldn't be found, this text will be used")]
			public string FallbackText;

			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If SpriteTranslationName couldn't be found, this sprite will be used")]
			public Sprite FallbackSprite;

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x8BA5F8", Offset = "0x8BA5F8", VA = "0x8BA5F8")]
			public Option()
			{
			}
		}

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Option> options;

		[NonSerialized]
		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<LeanToken> tokens;

		[Token(Token = "0x170000E7")]
		public List<Option> Options
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x8B9E10", Offset = "0x8B9E10", VA = "0x8B9E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x8B9E90", Offset = "0x8B9E90", VA = "0x8B9E90", Slot = "5")]
		public void Register(LeanToken token)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x8B9F80", Offset = "0x8B9F80", VA = "0x8B9F80", Slot = "6")]
		public void Unregister(LeanToken token)
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x8B9FE0", Offset = "0x8B9FE0", VA = "0x8B9FE0", Slot = "7")]
		public void UnregisterAll()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x8BA15C", Offset = "0x8BA15C", VA = "0x8BA15C", Slot = "4")]
		[ContextMenu("Update Localization")]
		public void UpdateLocalization()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x8BA4B0", Offset = "0x8BA4B0", VA = "0x8BA4B0", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x8BA550", Offset = "0x8BA550", VA = "0x8BA550", Slot = "9")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x8BA5F0", Offset = "0x8BA5F0", VA = "0x8BA5F0")]
		public LocalizedDropdown()
		{
		}
	}
	[Token(Token = "0x200019D")]
	public class LocalizedString : LeanLocalizedBehaviour
	{
		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If PhraseName couldn't be found, this text will be used")]
		public string FallbackText;

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x8BA600", Offset = "0x8BA600", VA = "0x8BA600", Slot = "8")]
		public override void UpdateTranslation(LeanTranslation translation)
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x8BA750", Offset = "0x8BA750", VA = "0x8BA750", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x8BA7C8", Offset = "0x8BA7C8", VA = "0x8BA7C8")]
		public LocalizedString()
		{
		}
	}
	[Token(Token = "0x200019E")]
	public class Menu : MonoBehaviour
	{
		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string mainMenuName;

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x8BA7D0", Offset = "0x8BA7D0", VA = "0x8BA7D0")]
		public void MainMenu()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x8BA85C", Offset = "0x8BA85C", VA = "0x8BA85C")]
		public Menu()
		{
		}
	}
	[Token(Token = "0x200019F")]
	public class ModelAssembleScript : MonoBehaviour
	{
		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ModelAssembleScript m_Instance;

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x8BA8AC", Offset = "0x8BA8AC", VA = "0x8BA8AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x8BA8F8", Offset = "0x8BA8F8", VA = "0x8BA8F8")]
		private void Fusion(ModelFragmentSet fragmentset, ModelFragmentSet other)
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x8BAC2C", Offset = "0x8BAC2C", VA = "0x8BAC2C")]
		public ModelAssembleScript()
		{
		}
	}
	[Token(Token = "0x20001A0")]
	public class ModelFragment : MonoBehaviour
	{
		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ModelFragmentSet m_FragmentSet;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int Index;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[] Neighbors;

		[Token(Token = "0x170000E8")]
		public ModelFragmentSet FragmentSet
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x8BAC34", Offset = "0x8BAC34", VA = "0x8BAC34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x8BACD8", Offset = "0x8BACD8", VA = "0x8BACD8")]
		public ModelFragment()
		{
		}
	}
	[Token(Token = "0x20001A1")]
	public class ModelFragmentSet : MonoBehaviour
	{
		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<int, ModelFragment> m_Fragments;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AudioClip successSound;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public ModelInfo Info;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float sqrDistanceThreshold;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float quaternionThreshold;

		[Token(Token = "0x170000E9")]
		public bool IsCompleted
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x8BA93C", Offset = "0x8BA93C", VA = "0x8BA93C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EA")]
		public int NumFragments
		{
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x8BADD0", Offset = "0x8BADD0", VA = "0x8BADD0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000EB")]
		public int MinIndex
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0x8BAF40", Offset = "0x8BAF40", VA = "0x8BAF40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000EC")]
		public Dictionary<int, ModelFragment> Fragments
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0x8BAE24", Offset = "0x8BAE24", VA = "0x8BAE24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x8BACE0", Offset = "0x8BACE0", VA = "0x8BACE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x8BB0DC", Offset = "0x8BB0DC", VA = "0x8BB0DC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x8BA968", Offset = "0x8BA968", VA = "0x8BA968")]
		public void Join(ModelFragmentSet other)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x8BB5A0", Offset = "0x8BB5A0", VA = "0x8BB5A0")]
		private void AddFragment(ModelFragment fragment)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x8BB4DC", Offset = "0x8BB4DC", VA = "0x8BB4DC")]
		private bool ContainsNeighborFragment(ModelFragment other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x8BB6E0", Offset = "0x8BB6E0", VA = "0x8BB6E0")]
		public ModelFragmentSet()
		{
		}
	}
	[Token(Token = "0x20001A2")]
	public class ModelInfo : MonoBehaviour
	{
		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ModelName;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int TotalNumFragments;

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x8BB6F4", Offset = "0x8BB6F4", VA = "0x8BB6F4")]
		public ModelInfo()
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public class CameraWork : MonoBehaviour
	{
		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The distance in the local x-z plane to the target")]
		public float distance;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The height we want the camera to be above the target")]
		public float height;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Smooth time lag for the height of the camera.")]
		public float heightSmoothLag;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Allow the camera to be offseted vertically from the target, for example giving more view of the sceneray and less ground.")]
		public Vector3 centerOffset;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Set this as false if a component of a prefab being instanciated by Photon Network, and manually call OnStartFollowing() when and if needed.")]
		public bool followOnStart;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform cameraTransform;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isFollowing;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float heightVelocity;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float targetHeight;

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x8BB6FC", Offset = "0x8BB6FC", VA = "0x8BB6FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x8BB7FC", Offset = "0x8BB7FC", VA = "0x8BB7FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x8BB70C", Offset = "0x8BB70C", VA = "0x8BB70C")]
		public void OnStartFollowing()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x8BB88C", Offset = "0x8BB88C", VA = "0x8BB88C")]
		private void Apply()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x8BBAC8", Offset = "0x8BBAC8", VA = "0x8BBAC8")]
		private void Cut()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x8BBAF8", Offset = "0x8BBAF8", VA = "0x8BBAF8")]
		private void SetUpRotation(Vector3 centerPos)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x8BBC78", Offset = "0x8BBC78", VA = "0x8BBC78")]
		public CameraWork()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	public class GameController : MonoBehaviourPunCallbacks, IInRoomCallbacks, IOnEventCallback
	{
		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static GameController Instance;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The prefab to use for representing the player")]
		public GameObject playerPrefab;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftPivot;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightPivot;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform leftHandPrefab;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightHandPrefab;

		[Token(Token = "0x4000956")]
		public const byte CustomLeftHandInsantiationEventCode = 1;

		[Token(Token = "0x4000957")]
		public const byte CustomRightHandInsantiationEventCode = 2;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject instance;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private XROrigin xrRig;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isLeftHandSpawned;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isRightHandSpawned;

		[Token(Token = "0x170000ED")]
		public XROrigin XrRig
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x8BBCFC", Offset = "0x8BBCFC", VA = "0x8BBCFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x8BBDA0", Offset = "0x8BBDA0", VA = "0x8BBDA0")]
		private new void OnEnable()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x8BBDF8", Offset = "0x8BBDF8", VA = "0x8BBDF8")]
		private new void OnDisable()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x8BBE50", Offset = "0x8BBE50", VA = "0x8BBE50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x8BC2B0", Offset = "0x8BC2B0", VA = "0x8BC2B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x8BC408", Offset = "0x8BC408", VA = "0x8BC408")]
		public void OnPhotonPlayerConnected(Player other)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x8BC55C", Offset = "0x8BC55C", VA = "0x8BC55C")]
		public void OnPhotonPlayerDisconnected(Player other)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x8BC6B0", Offset = "0x8BC6B0", VA = "0x8BC6B0", Slot = "31")]
		public override void OnLeftRoom()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x8BC718", Offset = "0x8BC718", VA = "0x8BC718")]
		public void LeaveRoom()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x8BC76C", Offset = "0x8BC76C", VA = "0x8BC76C")]
		public void QuitApplication()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x8BC774", Offset = "0x8BC774", VA = "0x8BC774")]
		private void LoadArena()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x8BC2B4", Offset = "0x8BC2B4", VA = "0x8BC2B4")]
		private void Spawn()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x8BC8C0", Offset = "0x8BC8C0", VA = "0x8BC8C0")]
		private void SpawnHand(Transform handModel, byte eventCode)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x8BCB98", Offset = "0x8BCB98", VA = "0x8BCB98", Slot = "54")]
		private void Photon.Realtime.IOnEventCallback.OnEvent(EventData photonEvent)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x8BD00C", Offset = "0x8BD00C", VA = "0x8BD00C")]
		public GameController()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public class GameModel : MonoBehaviour
	{
		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static GameModel Instance;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BasicGameState m_ActiveGameState;

		[Token(Token = "0x170000EE")]
		public BasicGameState ActiveGameState
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x8BD014", Offset = "0x8BD014", VA = "0x8BD014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x8BD01C", Offset = "0x8BD01C", VA = "0x8BD01C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x8BD068", Offset = "0x8BD068", VA = "0x8BD068")]
		private void Start()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x8BD06C", Offset = "0x8BD06C", VA = "0x8BD06C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x8BD084", Offset = "0x8BD084", VA = "0x8BD084")]
		public void ChangeStateTo(BasicGameState state)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x8BD0CC", Offset = "0x8BD0CC", VA = "0x8BD0CC")]
		public GameModel()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	public class Launcher : MonoBehaviourPunCallbacks, IConnectionCallbacks, ILobbyCallbacks
	{
		[Token(Token = "0x20001A7")]
		[CompilerGenerated]
		private sealed class <StartLoading>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string scene;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Launcher <>4__this;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <displayProgress>5__2;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <toProgress>5__3;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AsyncOperation <op>5__4;

			[Token(Token = "0x170000EF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000871")]
				[Address(RVA = "0x8BE64C", Offset = "0x8BE64C", VA = "0x8BE64C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000873")]
				[Address(RVA = "0x8BE694", Offset = "0x8BE694", VA = "0x8BE694", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600086E")]
			[Address(RVA = "0x8BE2D8", Offset = "0x8BE2D8", VA = "0x8BE2D8")]
			[DebuggerHidden]
			public <StartLoading>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x600086F")]
			[Address(RVA = "0x8BE4A0", Offset = "0x8BE4A0", VA = "0x8BE4A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x8BE4A4", Offset = "0x8BE4A4", VA = "0x8BE4A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x8BE654", Offset = "0x8BE654", VA = "0x8BE654", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001A8")]
		[CompilerGenerated]
		private struct <UpdateRemoteWorldList>d__32 : IAsyncStateMachine
		{
			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Launcher <>4__this;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<RemoteDataService.ListOfRecords<OverviewModel>> <>u__1;

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x8BE69C", Offset = "0x8BE69C", VA = "0x8BE69C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x8BEAD8", Offset = "0x8BEAD8", VA = "0x8BEAD8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001A9")]
		[CompilerGenerated]
		private struct <CreateSession>d__33 : IAsyncStateMachine
		{
			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isPublic;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Launcher <>4__this;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x8BEAE4", Offset = "0x8BEAE4", VA = "0x8BEAE4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x8BEF30", Offset = "0x8BEF30", VA = "0x8BEF30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The maximum number of players per room")]
		public byte maxPlayersPerRoom;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string sceneNameForSingle;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string sceneNameForMulti;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isConnecting;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string roomName;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _gameVersion;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WorldInfo m_CurrentWorld;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, RoomInfo> cachedWorldList;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, WorldInfo> remoteWorldList;

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x8BD0D4", Offset = "0x8BD0D4", VA = "0x8BD0D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x8BD254", Offset = "0x8BD254", VA = "0x8BD254")]
		private void Start()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x8BD2E8", Offset = "0x8BD2E8", VA = "0x8BD2E8")]
		public void Play()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x8BD498", Offset = "0x8BD498", VA = "0x8BD498")]
		public void Multiplay()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x8BD5DC", Offset = "0x8BD5DC", VA = "0x8BD5DC")]
		public void SetCurrentWorld(WorldInfo world)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x8BD5E4", Offset = "0x8BD5E4", VA = "0x8BD5E4")]
		public void LoadWorld()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x8BD5F4", Offset = "0x8BD5F4", VA = "0x8BD5F4")]
		public void LoadWorld(WorldInfo world)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x8BD74C", Offset = "0x8BD74C", VA = "0x8BD74C")]
		public void LoadWorld1()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x8BD85C", Offset = "0x8BD85C", VA = "0x8BD85C")]
		public void LoadWorld2()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x8BD96C", Offset = "0x8BD96C", VA = "0x8BD96C")]
		public void LoadWorld3()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x8BD25C", Offset = "0x8BD25C", VA = "0x8BD25C")]
		public void Connect()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x8BDA7C", Offset = "0x8BDA7C", VA = "0x8BDA7C")]
		public void RefreshWorldDisplay()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x8BDA80", Offset = "0x8BDA80", VA = "0x8BDA80")]
		public List<WorldInfo> GetRemoteWorldList()
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x8BDCAC", Offset = "0x8BDCAC", VA = "0x8BDCAC", Slot = "45")]
		public override void OnConnectedToMaster()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x8BDED8", Offset = "0x8BDED8", VA = "0x8BDED8", Slot = "34")]
		public override void OnJoinRoomFailed(short code, string msg)
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x8BDFEC", Offset = "0x8BDFEC", VA = "0x8BDFEC", Slot = "38")]
		public override void OnDisconnected(DisconnectCause cause)
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x8BE094", Offset = "0x8BE094", VA = "0x8BE094", Slot = "41")]
		public override void OnJoinedRoom()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x8BE1E4", Offset = "0x8BE1E4", VA = "0x8BE1E4", Slot = "40")]
		public override void OnRoomListUpdate(List<RoomInfo> roomList)
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x8BD5D8", Offset = "0x8BD5D8", VA = "0x8BD5D8")]
		private void LogFeedback(string message)
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x8BD424", Offset = "0x8BD424", VA = "0x8BD424")]
		[IteratorStateMachine(typeof(<StartLoading>d__28))]
		private IEnumerator StartLoading(string scene)
		{
			return null;
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x8BE300", Offset = "0x8BE300", VA = "0x8BE300")]
		private void SetLoadingPercentage(int displayProgress)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x8BE1E8", Offset = "0x8BE1E8", VA = "0x8BE1E8")]
		private void UpdateOnlineWorldList(List<RoomInfo> roomList)
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x8BD258", Offset = "0x8BD258", VA = "0x8BD258")]
		private void ShowWorldMenu(bool enabled = true)
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x8BD1C0", Offset = "0x8BD1C0", VA = "0x8BD1C0")]
		[AsyncStateMachine(typeof(<UpdateRemoteWorldList>d__32))]
		private void UpdateRemoteWorldList()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x8BD384", Offset = "0x8BD384", VA = "0x8BD384")]
		[AsyncStateMachine(typeof(<CreateSession>d__33))]
		private void CreateSession(bool isPublic = false)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x8BE304", Offset = "0x8BE304", VA = "0x8BE304")]
		private void OnCreateOverviewRecord(WebRequest.Reply reply)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x8BE3B4", Offset = "0x8BE3B4", VA = "0x8BE3B4")]
		public Launcher()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	public class LoaderAnime : MonoBehaviour
	{
		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Angular Speed in degrees per seconds")]
		public float speed;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Radius os the loader")]
		public float radius;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject particles;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 _offset;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _transform;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _particleTransform;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isAnimating;

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x8BEF3C", Offset = "0x8BEF3C", VA = "0x8BEF3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x8BEFB8", Offset = "0x8BEFB8", VA = "0x8BEFB8")]
		private void Update()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x8BF15C", Offset = "0x8BF15C", VA = "0x8BF15C")]
		public void StartLoaderAnimation()
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x8BF194", Offset = "0x8BF194", VA = "0x8BF194")]
		public void StopLoaderAnimation()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x8BF1B4", Offset = "0x8BF1B4", VA = "0x8BF1B4")]
		public LoaderAnime()
		{
		}
	}
	[Token(Token = "0x20001AB")]
	public class PlayerAnimatorManager : MonoBehaviourPunCallbacks
	{
		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DirectionDampTime;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator animator;

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x8BF1C8", Offset = "0x8BF1C8", VA = "0x8BF1C8")]
		private void Start()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x8BF218", Offset = "0x8BF218", VA = "0x8BF218")]
		private void Update()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x8BF448", Offset = "0x8BF448", VA = "0x8BF448")]
		public PlayerAnimatorManager()
		{
		}
	}
	[Token(Token = "0x20001AC")]
	public class PlayerManager : MonoBehaviourPunCallbacks, IPunObservable
	{
		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Player's UI GameObject Prefab")]
		public GameObject PlayerUiPrefab;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Beams GameObject to control")]
		public GameObject Beams;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The current Health of our player")]
		public float Health;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Tooltip("The local player instance. Use this to know if the local player is represented in the Scene")]
		public static GameObject LocalPlayerInstance;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The reference to trigger of hand.")]
		public InputActionReference TriggerSwitch;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool IsFiring;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityEngine.XR.InputDevice headSet;

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x8BF458", Offset = "0x8BF458", VA = "0x8BF458")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x8BF660", Offset = "0x8BF660", VA = "0x8BF660")]
		public void Start()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x8BF894", Offset = "0x8BF894", VA = "0x8BF894")]
		public new void OnDisable()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x8BF938", Offset = "0x8BF938", VA = "0x8BF938")]
		public void Update()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x8BFBFC", Offset = "0x8BFBFC", VA = "0x8BFBFC")]
		private Vector3 GetPlayerPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x8BFD9C", Offset = "0x8BFD9C", VA = "0x8BFD9C")]
		private Quaternion GetPlayerRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x8BFF38", Offset = "0x8BFF38", VA = "0x8BFF38")]
		public void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x8BFFD0", Offset = "0x8BFFD0", VA = "0x8BFFD0")]
		public void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x8C007C", Offset = "0x8C007C", VA = "0x8C007C")]
		private void CalledOnLevelWasLoaded(int level)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x8C01D4", Offset = "0x8C01D4", VA = "0x8C01D4")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode loadingMode)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x8BFE80", Offset = "0x8BFE80", VA = "0x8BFE80")]
		private void ProcessInputs()
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x8C0204", Offset = "0x8C0204", VA = "0x8C0204", Slot = "54")]
		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x8C032C", Offset = "0x8C032C", VA = "0x8C032C")]
		public PlayerManager()
		{
		}
	}
	[Token(Token = "0x20001AD")]
	[RequireComponent(typeof(InputField))]
	public class PlayerNameInputField : MonoBehaviour
	{
		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string playerNamePrefKey;

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x8C033C", Offset = "0x8C033C", VA = "0x8C033C")]
		private void Start()
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x8C0490", Offset = "0x8C0490", VA = "0x8C0490")]
		public void SetPlayerName(string value)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x8C0558", Offset = "0x8C0558", VA = "0x8C0558")]
		public PlayerNameInputField()
		{
		}
	}
	[Token(Token = "0x20001AE")]
	public class PlayerUI : MonoBehaviour
	{
		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Pixel offset from the player target")]
		public Vector3 ScreenOffset;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("UI Text to display Player's Name")]
		public Text PlayerNameText;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("UI Slider to display Player's Health")]
		public Slider PlayerHealthSlider;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlayerManager _target;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _characterControllerHeight;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform _targetTransform;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Renderer _targetRenderer;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 _targetPosition;

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x8C05C0", Offset = "0x8C05C0", VA = "0x8C05C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x8C0670", Offset = "0x8C0670", VA = "0x8C0670")]
		private void Update()
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x8C0768", Offset = "0x8C0768", VA = "0x8C0768")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x8C08AC", Offset = "0x8C08AC", VA = "0x8C08AC")]
		public void SetTarget(PlayerManager target)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x8C0A98", Offset = "0x8C0A98", VA = "0x8C0A98")]
		public PlayerUI()
		{
		}
	}
	[Token(Token = "0x20001AF")]
	public abstract class BasicGameState
	{
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x8C0AB0", Offset = "0x8C0AB0", VA = "0x8C0AB0", Slot = "4")]
		public virtual void Init()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x8C0B54", Offset = "0x8C0B54", VA = "0x8C0B54", Slot = "5")]
		public virtual void Execute()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x8C0B58", Offset = "0x8C0B58", VA = "0x8C0B58", Slot = "6")]
		public virtual void Finish()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x8C0B5C", Offset = "0x8C0B5C", VA = "0x8C0B5C")]
		protected BasicGameState()
		{
		}
	}
	[Token(Token = "0x20001B0")]
	public class WorldInfo
	{
		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Id;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsActive;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Multiplay;

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x8BEAD0", Offset = "0x8BEAD0", VA = "0x8BEAD0")]
		public WorldInfo()
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public class AgentScript : MonoBehaviour
	{
		[Token(Token = "0x20001B2")]
		public enum ActionStatus
		{
			[Token(Token = "0x400099D")]
			Idle,
			[Token(Token = "0x400099E")]
			Follow,
			[Token(Token = "0x400099F")]
			Dialog,
			[Token(Token = "0x40009A0")]
			Work
		}

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform prefabTransform;

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform targetTransform;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float distanceThreshold;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DialogData dialogData;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ActionStatus actionStatus;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InterfaceMgr ui;

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x8C0B64", Offset = "0x8C0B64", VA = "0x8C0B64")]
		private void Awake()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x8C0BF0", Offset = "0x8C0BF0", VA = "0x8C0BF0")]
		private void Update()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x8C0BF4", Offset = "0x8C0BF4", VA = "0x8C0BF4")]
		private void UpdateStatus()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x8C0C10", Offset = "0x8C0C10", VA = "0x8C0C10")]
		private void HandleInputs()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x8C0D50", Offset = "0x8C0D50", VA = "0x8C0D50")]
		private void MoveToTarget()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x8C0F54", Offset = "0x8C0F54", VA = "0x8C0F54")]
		private void RotateTowards(Transform source, Transform target, float rotationSpeed)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x8C0EB8", Offset = "0x8C0EB8", VA = "0x8C0EB8")]
		private void ToggleAnimationBool(string parameter, bool value)
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x8C0F04", Offset = "0x8C0F04", VA = "0x8C0F04")]
		private void GetAnimationBool(string parameter, out bool value)
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x8C1104", Offset = "0x8C1104", VA = "0x8C1104")]
		private bool IsParameterExisted(string parameter)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x8C120C", Offset = "0x8C120C", VA = "0x8C120C")]
		public AgentScript()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	public class DialogController : MonoBehaviour
	{
		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inDialog;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AgentScript agent;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InterfaceMgr ui;

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x8C121C", Offset = "0x8C121C", VA = "0x8C121C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x8C1298", Offset = "0x8C1298", VA = "0x8C1298")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x8C1340", Offset = "0x8C1340", VA = "0x8C1340")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x8C13A8", Offset = "0x8C13A8", VA = "0x8C13A8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x8C140C", Offset = "0x8C140C", VA = "0x8C140C")]
		public DialogController()
		{
		}
	}
	[Token(Token = "0x20001B4")]
	[CreateAssetMenu(fileName = "DialogData", menuName = "ScriptableObjects/NPC/DialogData")]
	public class DialogData : ScriptableObject
	{
		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] DialogText;

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x8C1414", Offset = "0x8C1414", VA = "0x8C1414")]
		public DialogData()
		{
		}
	}
	[Token(Token = "0x20001B5")]
	public class InterfaceMgr : MonoBehaviour
	{
		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static InterfaceMgr Instace;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AgentScript agent;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_Animated animatedText;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CanvasGroup canvasGroup;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int currentDialogIndex;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool hasNextDialog;

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x8C141C", Offset = "0x8C141C", VA = "0x8C141C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x8C1468", Offset = "0x8C1468", VA = "0x8C1468")]
		private void Update()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x8C146C", Offset = "0x8C146C", VA = "0x8C146C")]
		public void NextDialog()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x8C1328", Offset = "0x8C1328", VA = "0x8C1328")]
		public void ShowMessage(string text)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x8C16E8", Offset = "0x8C16E8", VA = "0x8C16E8")]
		public InterfaceMgr()
		{
		}
	}
	[Token(Token = "0x20001B6")]
	public enum Emotion
	{
		[Token(Token = "0x40009AC")]
		happy,
		[Token(Token = "0x40009AD")]
		sad,
		[Token(Token = "0x40009AE")]
		suprised,
		[Token(Token = "0x40009AF")]
		angry
	}
	[Serializable]
	[Token(Token = "0x20001B7")]
	public class EmotionEvent : UnityEvent<Emotion>
	{
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x8C16F0", Offset = "0x8C16F0", VA = "0x8C16F0")]
		public EmotionEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B8")]
	public class ActionEvent : UnityEvent<string>
	{
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x8C1738", Offset = "0x8C1738", VA = "0x8C1738")]
		public ActionEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001B9")]
	public class TextRevealEvent : UnityEvent<char>
	{
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x8C1780", Offset = "0x8C1780", VA = "0x8C1780")]
		public TextRevealEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001BA")]
	public class DialogueEvent : UnityEvent
	{
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x8C17C8", Offset = "0x8C17C8", VA = "0x8C17C8")]
		public DialogueEvent()
		{
		}
	}
	[Token(Token = "0x20001BB")]
	public class TMP_Animated : TextMeshProUGUI
	{
		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x798")]
		[SerializeField]
		private float speed;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A0")]
		public EmotionEvent onEmotionChange;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A8")]
		public ActionEvent onAction;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B0")]
		public TextRevealEvent onTextReveal;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B8")]
		public DialogueEvent onDialogueFinish;

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x8C14B0", Offset = "0x8C14B0", VA = "0x8C14B0")]
		public void ReadText(string newText)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x8C191C", Offset = "0x8C191C", VA = "0x8C191C")]
		public TMP_Animated()
		{
		}
	}
	[Token(Token = "0x20001BE")]
	public static class ExtensionMethods
	{
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x8C1F74", Offset = "0x8C1F74", VA = "0x8C1F74")]
		public static string EncodeBase64(this string value)
		{
			return null;
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x8C1FF8", Offset = "0x8C1FF8", VA = "0x8C1FF8")]
		public static string DecodeBase64(this string value)
		{
			return null;
		}
	}
	[Token(Token = "0x20001BF")]
	public class OAuth2Identity : MonoBehaviour
	{
		[Token(Token = "0x20001C0")]
		public class UserInfo
		{
			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string id;

			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string email;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Texture2D icon;

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x8C27B0", Offset = "0x8C27B0", VA = "0x8C27B0")]
			public UserInfo()
			{
			}
		}

		[Token(Token = "0x20001C1")]
		public class LoginForm
		{
			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string username;

			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string password;

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x8C2804", Offset = "0x8C2804", VA = "0x8C2804")]
			public LoginForm()
			{
			}
		}

		[Token(Token = "0x20001C2")]
		public class OAuth2CredentialRequest
		{
			[StructLayout(3)]
			[Token(Token = "0x20001C3")]
			[CompilerGenerated]
			private struct <AuthorizeAsync>d__4 : IAsyncStateMachine
			{
				[Token(Token = "0x40009CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				[Token(Token = "0x40009CE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncTaskMethodBuilder<bool> <>t__builder;

				[Token(Token = "0x40009CF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public OAuth2CredentialRequest <>4__this;

				[Token(Token = "0x40009D0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private TaskAwaiter<WebRequest.Reply> <>u__1;

				[Token(Token = "0x60008D4")]
				[Address(RVA = "0x8C2964", Offset = "0x8C2964", VA = "0x8C2964", Slot = "4")]
				private void MoveNext()
				{
				}

				[Token(Token = "0x60008D5")]
				[Address(RVA = "0x8C2E50", Offset = "0x8C2E50", VA = "0x8C2E50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static string kApiUrl;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string m_Id;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string m_Secret;

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x8C246C", Offset = "0x8C246C", VA = "0x8C246C")]
			public OAuth2CredentialRequest(string id, string secret)
			{
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x8C280C", Offset = "0x8C280C", VA = "0x8C280C")]
			[AsyncStateMachine(typeof(<AuthorizeAsync>d__4))]
			public Task<bool> AuthorizeAsync()
			{
				return null;
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private struct <InitializeAsync>d__21 : IAsyncStateMachine
		{
			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OAuth2Identity <>4__this;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<UserInfo> <>u__2;

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x8C2EA8", Offset = "0x8C2EA8", VA = "0x8C2EA8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x8C31F0", Offset = "0x8C31F0", VA = "0x8C31F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001C5")]
		[CompilerGenerated]
		private struct <LoginAsync>d__22 : IAsyncStateMachine
		{
			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OAuth2Identity <>4__this;

			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<UserInfo> <>u__2;

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x8C31FC", Offset = "0x8C31FC", VA = "0x8C31FC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x8C3544", Offset = "0x8C3544", VA = "0x8C3544", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001C6")]
		[CompilerGenerated]
		private struct <GetUserInfoAsync>d__23 : IAsyncStateMachine
		{
			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<UserInfo> <>t__builder;

			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OAuth2Identity <>4__this;

			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<AccountModel> <>u__1;

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x8C3550", Offset = "0x8C3550", VA = "0x8C3550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x8C37E0", Offset = "0x8C37E0", VA = "0x8C37E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_AuthorizationServerUrl;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_TokenServerUrl;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UserInfo m_User;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_ClientId;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_ClientSecret;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string m_AccessToken;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OAuth2CredentialRequest m_CredentialRequest;

		[Token(Token = "0x170000F3")]
		public bool Loggedin
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x8C2210", Offset = "0x8C2210", VA = "0x8C2210")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F4")]
		public UserInfo Profile
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x8C2228", Offset = "0x8C2228", VA = "0x8C2228")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x8C22CC", Offset = "0x8C22CC", VA = "0x8C22CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public string AccessToken
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x8C234C", Offset = "0x8C234C", VA = "0x8C234C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public static event Action<OAuth2Identity> ProfileUpdated
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x8C2078", Offset = "0x8C2078", VA = "0x8C2078")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x8C2144", Offset = "0x8C2144", VA = "0x8C2144")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x8C23F0", Offset = "0x8C23F0", VA = "0x8C23F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x8C2498", Offset = "0x8C2498", VA = "0x8C2498")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__21))]
		public Task InitializeAsync()
		{
			return null;
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x8C2564", Offset = "0x8C2564", VA = "0x8C2564")]
		[AsyncStateMachine(typeof(<LoginAsync>d__22))]
		public void LoginAsync()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x8C25F4", Offset = "0x8C25F4", VA = "0x8C25F4")]
		[AsyncStateMachine(typeof(<GetUserInfoAsync>d__23))]
		private Task<UserInfo> GetUserInfoAsync()
		{
			return null;
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x8C26E4", Offset = "0x8C26E4", VA = "0x8C26E4")]
		public OAuth2Identity()
		{
		}
	}
	[Token(Token = "0x20001C7")]
	public class PolyCutter
	{
		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Plane m_CuttingPlane;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool[] m_Sides;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mesh m_ObjMesh;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<int>[] m_LeftIndiceSet;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Vector3>[] m_LeftPointSet;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Vector2>[] m_LeftUvSet;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Vector3>[] m_LeftNormalSet;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<int>[] m_RightIndiceSet;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Vector3>[] m_RightPointSet;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Vector2>[] m_RightUvSet;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<Vector3>[] m_RightNormalSet;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<Vector3> m_CreatedVertices;

		[Token(Token = "0x170000F6")]
		public Plane CuttingPlane
		{
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x8C3838", Offset = "0x8C3838", VA = "0x8C3838")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x8C3844", Offset = "0x8C3844", VA = "0x8C3844")]
			set
			{
			}
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x8C3850", Offset = "0x8C3850", VA = "0x8C3850")]
		public PolyCutter(Plane plane)
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x8C3E60", Offset = "0x8C3E60", VA = "0x8C3E60")]
		public void Cut(GameObject obj, out GameObject remain)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x8C5760", Offset = "0x8C5760", VA = "0x8C5760")]
		private void CutTriangle(int submesh, int[] triangle)
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x8C6CE8", Offset = "0x8C6CE8", VA = "0x8C6CE8")]
		private void AddNewTriangle(bool leftside, int submesh, Vector3 facing, Vector3[] triangle, Vector2[] uvs, Vector3[] normals)
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x8C67A4", Offset = "0x8C67A4", VA = "0x8C67A4")]
		private void MakeCaps()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x8C7988", Offset = "0x8C7988", VA = "0x8C7988")]
		private void FillCap(List<Vector3> vertices)
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x8C55A0", Offset = "0x8C55A0", VA = "0x8C55A0")]
		private void ResetInternalData()
		{
		}
	}
	[Token(Token = "0x20001C8")]
	public enum PrefabSetType
	{
		[Token(Token = "0x40009EC")]
		User
	}
	[Token(Token = "0x20001C9")]
	public enum PrefabFileType
	{
		[Token(Token = "0x40009EE")]
		Disk,
		[Token(Token = "0x40009EF")]
		Cloud,
		[Token(Token = "0x40009F0")]
		None
	}
	[Token(Token = "0x20001CA")]
	public interface IPrefabFileInfo
	{
		[Token(Token = "0x170000F7")]
		PrefabFileType InfoType
		{
			[Token(Token = "0x60008E5")]
			get;
		}

		[Token(Token = "0x170000F8")]
		string DisplayName
		{
			[Token(Token = "0x60008E6")]
			get;
		}

		[Token(Token = "0x170000F9")]
		bool Valid
		{
			[Token(Token = "0x60008E7")]
			get;
		}

		[Token(Token = "0x170000FA")]
		bool Available
		{
			[Token(Token = "0x60008E8")]
			get;
		}

		[Token(Token = "0x170000FB")]
		string FullPath
		{
			[Token(Token = "0x60008E9")]
			get;
		}

		[Token(Token = "0x170000FC")]
		string AssetId
		{
			[Token(Token = "0x60008EA")]
			get;
		}

		[Token(Token = "0x60008EB")]
		Stream GetReadStream(string subfileName);
	}
	[Token(Token = "0x20001CB")]
	public interface IPrefabItem
	{
		[Token(Token = "0x170000FD")]
		IPrefabFileInfo FileInfo
		{
			[Token(Token = "0x60008EC")]
			get;
		}

		[Token(Token = "0x170000FE")]
		Texture2D Icon
		{
			[Token(Token = "0x60008ED")]
			get;
		}
	}
	[Token(Token = "0x20001CC")]
	public interface IPrefabSet
	{
		[Token(Token = "0x170000FF")]
		PrefabSetType Type
		{
			[Token(Token = "0x60008EE")]
			get;
		}

		[Token(Token = "0x60008EF")]
		void Init();

		[Token(Token = "0x60008F0")]
		void Update();
	}
	[Token(Token = "0x20001CD")]
	public class PrefabCatalog : MonoBehaviour
	{
		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static PrefabCatalog m_Instance;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IPrefabSet[] m_Sets;

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x8C8528", Offset = "0x8C8528", VA = "0x8C8528")]
		public IPrefabSet GetPrefabSet(PrefabSetType type)
		{
			return null;
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x8C8558", Offset = "0x8C8558", VA = "0x8C8558")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x8C863C", Offset = "0x8C863C", VA = "0x8C863C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x8C8724", Offset = "0x8C8724", VA = "0x8C8724")]
		private void Update()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x8C880C", Offset = "0x8C880C", VA = "0x8C880C")]
		public PrefabCatalog()
		{
		}
	}
	[Token(Token = "0x20001CE")]
	[CreateAssetMenu(fileName = "ObjectDatabase", menuName = "ScriptableObjects/ObjectDatabase", order = 1)]
	public class PrefabDatabase : ScriptableObject
	{
		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Entry> items;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, PrefabName> nameMap;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<PrefabName, StorableItemInfo> prefabMap;

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x8C8814", Offset = "0x8C8814", VA = "0x8C8814")]
		public void BuildMap()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x8C89EC", Offset = "0x8C89EC", VA = "0x8C89EC")]
		public PrefabName GetPrefabName(string txt)
		{
			return default(PrefabName);
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x8C8A80", Offset = "0x8C8A80", VA = "0x8C8A80")]
		public StorableItemInfo GetItem(PrefabName itemName)
		{
			return null;
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x8C8BF8", Offset = "0x8C8BF8", VA = "0x8C8BF8")]
		public PrefabDatabase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001CF")]
	public class Entry
	{
		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PrefabName name;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StorableItemInfo item;

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x8C8C00", Offset = "0x8C8C00", VA = "0x8C8C00")]
		public Entry()
		{
		}
	}
	[Token(Token = "0x20001D0")]
	public class PrefabNameComparer : IEqualityComparer<PrefabName>
	{
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x8C8C08", Offset = "0x8C8C08", VA = "0x8C8C08", Slot = "4")]
		public bool Equals(PrefabName x, PrefabName y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x8C8C14", Offset = "0x8C8C14", VA = "0x8C8C14", Slot = "5")]
		public int GetHashCode(PrefabName x)
		{
			return default(int);
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x8C89E4", Offset = "0x8C89E4", VA = "0x8C89E4")]
		public PrefabNameComparer()
		{
		}
	}
	[Token(Token = "0x20001D1")]
	public struct CustomEventCode
	{
		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static byte ManualInstantiation;
	}
	[Token(Token = "0x20001D2")]
	public class PrefabManager : MonoBehaviour, IOnEventCallback
	{
		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static PrefabManager Instance;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PrefabDatabase m_PrefabDatabase;

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x8C8C68", Offset = "0x8C8C68", VA = "0x8C8C68")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x8C8D0C", Offset = "0x8C8D0C", VA = "0x8C8D0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x8C8D10", Offset = "0x8C8D10", VA = "0x8C8D10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x8C8D14", Offset = "0x8C8D14", VA = "0x8C8D14")]
		public bool Create(PrefabName prefabName, Vector3 position, Quaternion rotation, Transform parent, out GameObject newObj, bool networked = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x8C91C8", Offset = "0x8C91C8", VA = "0x8C91C8", Slot = "4")]
		public void OnEvent(EventData photonEvent)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x8C9494", Offset = "0x8C9494", VA = "0x8C9494")]
		public PrefabManager()
		{
		}
	}
	[Token(Token = "0x20001D3")]
	[RequireComponent(typeof(Collectable))]
	public class SerializationScript : MonoBehaviour
	{
		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PrefabName itemName;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool IsAutoRegister;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ObjectSpawner m_Spawner;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Consumable m_Consumable;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlantingFoundation m_PlantBed;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private EasterEggs m_EasterEgg;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Collectable m_Collectable;

		[Token(Token = "0x17000100")]
		public IslandMgr Island
		{
			[Token(Token = "0x6000905")]
			[Address(RVA = "0x8C949C", Offset = "0x8C949C", VA = "0x8C949C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000906")]
			[Address(RVA = "0x8C94A4", Offset = "0x8C94A4", VA = "0x8C94A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public bool IsAttached
		{
			[Token(Token = "0x6000907")]
			[Address(RVA = "0x8C94AC", Offset = "0x8C94AC", VA = "0x8C94AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000102")]
		public string SpawnerName
		{
			[Token(Token = "0x6000908")]
			[Address(RVA = "0x8C950C", Offset = "0x8C950C", VA = "0x8C950C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000103")]
		public int SpawnPointIndex
		{
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x8C95B0", Offset = "0x8C95B0", VA = "0x8C95B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000104")]
		public bool IsTracked
		{
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x8C9630", Offset = "0x8C9630", VA = "0x8C9630")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x8C96B8", Offset = "0x8C96B8", VA = "0x8C96B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public int BoxConfigIndex
		{
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x8C9740", Offset = "0x8C9740", VA = "0x8C9740")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000106")]
		public int Durability
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x8C97C0", Offset = "0x8C97C0", VA = "0x8C97C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000107")]
		public bool IsOccupied
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x8C9840", Offset = "0x8C9840", VA = "0x8C9840")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x8C98C8", Offset = "0x8C98C8", VA = "0x8C98C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x8C9970", Offset = "0x8C9970", VA = "0x8C9970")]
		private void Start()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x8C9AB8", Offset = "0x8C9AB8", VA = "0x8C9AB8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x8C9BB4", Offset = "0x8C9BB4", VA = "0x8C9BB4")]
		public SerializationScript()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001D4")]
	public struct WorldData
	{
		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ProfileData Profile;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WorldJsonObj Objects;
	}
	[Serializable]
	[Token(Token = "0x20001D5")]
	public struct SceneData
	{
		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Id;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool IsMultiplay;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool IsValid;
	}
	[Serializable]
	[Token(Token = "0x20001D6")]
	public struct StatusData
	{
		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Duration;
	}
	[Serializable]
	[Token(Token = "0x20001D7")]
	public class SessionData
	{
		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Id;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WorldData MyWorld;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SceneData MyScene;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public StatusData MyStatus;

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x8C9BC4", Offset = "0x8C9BC4", VA = "0x8C9BC4")]
		public SessionData()
		{
		}
	}
	[Token(Token = "0x20001D8")]
	public class SessionSaveLoader : MonoBehaviour
	{
		[StructLayout(3)]
		[Token(Token = "0x20001D9")]
		[CompilerGenerated]
		private struct <Save>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000A11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000A12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SessionSaveLoader <>4__this;

			[Token(Token = "0x4000A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <sceneInfo>5__2;

			[Token(Token = "0x4000A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string <itemInfo>5__3;

			[Token(Token = "0x4000A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private string <statusInfo>5__4;

			[Token(Token = "0x4000A17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<SessionModel> <>u__1;

			[Token(Token = "0x4000A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private TaskAwaiter<bool> <>u__2;

			[Token(Token = "0x6000925")]
			[Address(RVA = "0x8CA138", Offset = "0x8CA138", VA = "0x8CA138", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x8CAB10", Offset = "0x8CAB10", VA = "0x8CAB10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001DA")]
		[CompilerGenerated]
		private struct <Load>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000A1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string id;

			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SessionSaveLoader <>4__this;

			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool useLocal;

			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			private bool <isLoaded>5__2;

			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<SessionModel> <>u__1;

			[Token(Token = "0x6000927")]
			[Address(RVA = "0x8CAB1C", Offset = "0x8CAB1C", VA = "0x8CAB1C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x8CB048", Offset = "0x8CB048", VA = "0x8CB048", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001DB")]
		[CompilerGenerated]
		private struct <CreateSessionRecord>d__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SessionSaveLoader <>4__this;

			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x8CB054", Offset = "0x8CB054", VA = "0x8CB054", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x8CB480", Offset = "0x8CB480", VA = "0x8CB480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string KeyPrefix;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static SessionSaveLoader Instance;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SessionData m_SessionData;

		[Token(Token = "0x17000108")]
		public string SessionID
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x8C9BCC", Offset = "0x8C9BCC", VA = "0x8C9BCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x8C9BE8", Offset = "0x8C9BE8", VA = "0x8C9BE8")]
			set
			{
			}
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x8C9C04", Offset = "0x8C9C04", VA = "0x8C9C04")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x8C9C94", Offset = "0x8C9C94", VA = "0x8C9C94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x8C9C98", Offset = "0x8C9C98", VA = "0x8C9C98")]
		private void Update()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x8C9C9C", Offset = "0x8C9C9C", VA = "0x8C9C9C")]
		private void OnApplicationFocus(bool focus)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x8C9CA8", Offset = "0x8C9CA8", VA = "0x8C9CA8")]
		[AsyncStateMachine(typeof(<Save>d__10))]
		public void Save()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x8BC208", Offset = "0x8BC208", VA = "0x8BC208")]
		[AsyncStateMachine(typeof(<Load>d__11))]
		public void Load(string id, bool useLocal = false)
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x8C9D40", Offset = "0x8C9D40", VA = "0x8C9D40")]
		private void PopulateWorld()
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x8C9EA8", Offset = "0x8C9EA8", VA = "0x8C9EA8")]
		private void ApplyData()
		{
		}

		[Token(Token = "0x600091E")]
		private T Get<T>(string subkey)
		{
			return (T)null;
		}

		[Token(Token = "0x600091F")]
		private void Set<T>(string subkey, T value)
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x8C9FB8", Offset = "0x8C9FB8", VA = "0x8C9FB8")]
		private void OnCreateOverviewRecord(WebRequest.Reply reply)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x8CA0CC", Offset = "0x8CA0CC", VA = "0x8CA0CC")]
		private void OnCreateSessionRecord(WebRequest.Reply reply)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x8CA038", Offset = "0x8CA038", VA = "0x8CA038")]
		[AsyncStateMachine(typeof(<CreateSessionRecord>d__18))]
		private void CreateSessionRecord()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x8CA0D0", Offset = "0x8CA0D0", VA = "0x8CA0D0")]
		public SessionSaveLoader()
		{
		}
	}
	[Token(Token = "0x20001DC")]
	public class Singleton<T> where T : class
	{
		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T m_instance;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object m_Lock;

		[Token(Token = "0x17000109")]
		public static T Instance
		{
			[Token(Token = "0x600092B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600092C")]
		public Singleton()
		{
		}
	}
	[Token(Token = "0x20001DD")]
	public abstract class MonoSingleton<T> : MonoBehaviour where T : Component
	{
		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T m_Instance;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool m_IsQuit;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object m_Lock;

		[Token(Token = "0x1700010A")]
		public static T Instance
		{
			[Token(Token = "0x600092E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600092F")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000930")]
		protected MonoSingleton()
		{
		}
	}
	[Token(Token = "0x20001DE")]
	public class StableObject : MonoBehaviour
	{
		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rb;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private XRBaseInteractable interactable;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isKinematicOnGround;

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x8CB48C", Offset = "0x8CB48C", VA = "0x8CB48C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x8CB508", Offset = "0x8CB508", VA = "0x8CB508")]
		public void SetStable()
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x8CB5A4", Offset = "0x8CB5A4", VA = "0x8CB5A4")]
		public void CancelStable()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x8CB5D0", Offset = "0x8CB5D0", VA = "0x8CB5D0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x8CB6A0", Offset = "0x8CB6A0", VA = "0x8CB6A0")]
		public void SetKinematic()
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x8CB6C0", Offset = "0x8CB6C0", VA = "0x8CB6C0")]
		public StableObject()
		{
		}
	}
	[Token(Token = "0x20001DF")]
	public class StoredValue : MonoBehaviour
	{
		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float value;

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x8CB6C8", Offset = "0x8CB6C8", VA = "0x8CB6C8")]
		public StoredValue()
		{
		}
	}
	[Token(Token = "0x20001E0")]
	public class SystemSetting : MonoBehaviour
	{
		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LocomotionSchemeManager lsMgr;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_Dropdown continuousMove;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_Dropdown walkMode;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TMP_Dropdown runMode;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TMP_Dropdown animalMode;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Slider volumeController;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TMP_Dropdown raftMode;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TMP_Text sessionID;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("The reference to toggle run and walk.")]
		private InputActionReference m_toggleWalkRun;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool isRunning;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float runningSpeed;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float walkSpeed;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float moveSpeed;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float raftSpeed;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] walkSpeedValues;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] runSpeedValues;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] raftSpeedValues;

		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float backgroundVolume;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<float> onVolumeChange;

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x8CB6D0", Offset = "0x8CB6D0", VA = "0x8CB6D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x8CBCF0", Offset = "0x8CBCF0", VA = "0x8CBCF0")]
		private void ChangeRaftMode(int value)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x8CBDD8", Offset = "0x8CBDD8", VA = "0x8CBDD8")]
		private void ChangeVolume(float volume)
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x8CBF2C", Offset = "0x8CBF2C", VA = "0x8CBF2C")]
		private void ChangeAnimalMode(int value)
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x8CC0EC", Offset = "0x8CC0EC", VA = "0x8CC0EC")]
		private void ChangeRunMode(int value)
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x8CC254", Offset = "0x8CC254", VA = "0x8CC254")]
		private void ChangeWalkMode(int value)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x8CC3D8", Offset = "0x8CC3D8", VA = "0x8CC3D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x8CC48C", Offset = "0x8CC48C", VA = "0x8CC48C")]
		private void OnToggleWalkRun(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x8CC5DC", Offset = "0x8CC5DC", VA = "0x8CC5DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x8CC97C", Offset = "0x8CC97C", VA = "0x8CC97C")]
		private void App_OnSystemSettingChanged(App.SystemSettings settings)
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x8CCB1C", Offset = "0x8CCB1C", VA = "0x8CCB1C")]
		private void ToggleContinuousMove(int value)
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x8CBC6C", Offset = "0x8CBC6C", VA = "0x8CBC6C")]
		private InputAction GetInputAction(InputActionReference actionReference)
		{
			return null;
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x8CCC30", Offset = "0x8CCC30", VA = "0x8CCC30")]
		public SystemSetting()
		{
		}
	}
	[Token(Token = "0x20001E1")]
	public class TeleportionFader : MonoBehaviour
	{
		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LocomotionProvider locomotionProvider;

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x8CCD78", Offset = "0x8CCD78", VA = "0x8CCD78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x8CCE58", Offset = "0x8CCE58", VA = "0x8CCE58")]
		private void FadeOut(LocomotionSystem obj)
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x8CCF30", Offset = "0x8CCF30", VA = "0x8CCF30")]
		private void FadeIn(LocomotionSystem obj)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x8CCF90", Offset = "0x8CCF90", VA = "0x8CCF90")]
		private void DoFadeIn()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x8CD068", Offset = "0x8CD068", VA = "0x8CD068")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x8CD148", Offset = "0x8CD148", VA = "0x8CD148")]
		public TeleportionFader()
		{
		}
	}
	[Token(Token = "0x20001E2")]
	public enum TutorialState
	{
		[Token(Token = "0x4000A42")]
		Init,
		[Token(Token = "0x4000A43")]
		Started,
		[Token(Token = "0x4000A44")]
		WaitForInput,
		[Token(Token = "0x4000A45")]
		ShowIntro
	}
	[Token(Token = "0x20001E3")]
	public class TutorialMgr : MonoBehaviour
	{
		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TutorialMgr m_Instance;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TutorialState m_State;

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x8CD150", Offset = "0x8CD150", VA = "0x8CD150")]
		private void Awake()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x8CD1A0", Offset = "0x8CD1A0", VA = "0x8CD1A0")]
		private void Update()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x8CD1A4", Offset = "0x8CD1A4", VA = "0x8CD1A4")]
		public TutorialMgr()
		{
		}
	}
	[Token(Token = "0x20001E4")]
	public class RingProcess : MonoBehaviour
	{
		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UserMetrics.MetricType type;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Image image;

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x8CD1AC", Offset = "0x8CD1AC", VA = "0x8CD1AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x8CD1FC", Offset = "0x8CD1FC", VA = "0x8CD1FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x8CD368", Offset = "0x8CD368", VA = "0x8CD368")]
		public RingProcess()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001E5")]
	public class ProfileData
	{
		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int userID;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool valid;

		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BagItemInfo[] bagItems;

		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BagItemInfo[] beltItems;

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x8CD370", Offset = "0x8CD370", VA = "0x8CD370")]
		public ProfileData()
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x8CD3E4", Offset = "0x8CD3E4", VA = "0x8CD3E4")]
		public void Reset()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001E6")]
	public struct BagItemInfo
	{
		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int type;

		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int number;

		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int durability;
	}
	[Token(Token = "0x20001E7")]
	public class UserData : Singleton<UserData>
	{
		[Token(Token = "0x20001E8")]
		public class UserInfo
		{
			[Token(Token = "0x1700010D")]
			public string Id
			{
				[Token(Token = "0x600095F")]
				[Address(RVA = "0x8CD880", Offset = "0x8CD880", VA = "0x8CD880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000960")]
				[Address(RVA = "0x8CD888", Offset = "0x8CD888", VA = "0x8CD888")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x1700010E")]
			public string DisplayName
			{
				[Token(Token = "0x6000961")]
				[Address(RVA = "0x8CD890", Offset = "0x8CD890", VA = "0x8CD890")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000962")]
				[Address(RVA = "0x8CD898", Offset = "0x8CD898", VA = "0x8CD898")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0x8CD574", Offset = "0x8CD574", VA = "0x8CD574")]
			public UserInfo()
			{
			}
		}

		[Token(Token = "0x4000A51")]
		private const string PLAYER_PREF_KEY_PREFIX = "UserData_";

		[Token(Token = "0x4000A52")]
		private const string kDefaultId = "<noexist>";

		[Token(Token = "0x4000A53")]
		private const string kDefaultName = "<Unknown>";

		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UserInfo m_UserInfo;

		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ProfileData data;

		[Token(Token = "0x1700010B")]
		public UserInfo Info
		{
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x8CD480", Offset = "0x8CD480", VA = "0x8CD480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010C")]
		public string KeyPrefix
		{
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x8CD488", Offset = "0x8CD488", VA = "0x8CD488")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x8CD500", Offset = "0x8CD500", VA = "0x8CD500")]
		public void Init(string id = "<noexist>", string name = "<Unknown>")
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x8CD57C", Offset = "0x8CD57C", VA = "0x8CD57C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x8CD594", Offset = "0x8CD594", VA = "0x8CD594")]
		public void Load()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x8CD68C", Offset = "0x8CD68C", VA = "0x8CD68C")]
		private void CopyData(ProfileData destination, ProfileData source)
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x8CD784", Offset = "0x8CD784", VA = "0x8CD784")]
		public void Store()
		{
		}

		[Token(Token = "0x600095C")]
		public T Get<T>(string subkey)
		{
			return (T)null;
		}

		[Token(Token = "0x600095D")]
		public void Set<T>(string subkey, T value)
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x8CD7DC", Offset = "0x8CD7DC", VA = "0x8CD7DC")]
		public UserData()
		{
		}
	}
	[Token(Token = "0x20001E9")]
	public class UserPerformance : MonoBehaviour
	{
		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int UpgradeUnit;

		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Value<int> Experience;

		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Value<int> Level;

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x8CD8A0", Offset = "0x8CD8A0", VA = "0x8CD8A0")]
		public UserPerformance()
		{
		}
	}
	[Token(Token = "0x20001EA")]
	public class UserMetrics : MonoBehaviour
	{
		[Token(Token = "0x20001EB")]
		public enum MetricType
		{
			[Token(Token = "0x4000AAC")]
			Vital,
			[Token(Token = "0x4000AAD")]
			Water,
			[Token(Token = "0x4000AAE")]
			Food,
			[Token(Token = "0x4000AAF")]
			Energy
		}

		[Serializable]
		[Token(Token = "0x20001EC")]
		public struct UserMetricsJsonObj
		{
			[Token(Token = "0x4000AB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float TotalElapsedTime;

			[Token(Token = "0x4000AB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float Vital;

			[Token(Token = "0x4000AB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float EnergyLevel;

			[Token(Token = "0x4000AB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float WaterLevel;

			[Token(Token = "0x4000AB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float FoodLevel;

			[Token(Token = "0x4000AB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool IsSick;

			[Token(Token = "0x4000AB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			public bool IsToxic;

			[Token(Token = "0x4000AB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 Position;

			[Token(Token = "0x4000AB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public PerformanceJsonObj Performance;
		}

		[Serializable]
		[Token(Token = "0x20001ED")]
		public struct PerformanceJsonObj
		{
			[Token(Token = "0x4000AB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Experience;

			[Token(Token = "0x4000ABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int Level;
		}

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static UserMetrics Instance;

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_TotalElapsedTime;

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_SavingMetricsInterval;

		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoSavingEnabled;

		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int[] m_ExperienceRequiredToUpgrade;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AIBrain m_Brain;

		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_NextSavingMetricsTime;

		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float EnergyConsumeCycle;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float WaterConsumeCycle;

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float FoodConsumeCycle;

		[Token(Token = "0x4000A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float VitalConsumeCycle;

		[Token(Token = "0x4000A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float SickPossibilityValue;

		[Token(Token = "0x4000A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip alarmSound;

		[Token(Token = "0x4000A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip sickSound;

		[Token(Token = "0x4000A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioSource dyingSound;

		[Token(Token = "0x4000A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioSource tiredSound;

		[Token(Token = "0x4000A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioClip toxicSound;

		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public System.Action OnDeath;

		[Token(Token = "0x4000A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public System.Action onLevelChanged;

		[Token(Token = "0x4000A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public System.Action onSick;

		[Token(Token = "0x4000A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public System.Action onToxic;

		[Token(Token = "0x4000A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public System.Action onRecoverSick;

		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public System.Action onRecoverToxic;

		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public System.Action onThirsty;

		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public System.Action onHungry;

		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public System.Action onTired;

		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public System.Action onTiredRecoverd;

		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public System.Action onDying;

		[Token(Token = "0x4000A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public System.Action onFoodMiddle;

		[Token(Token = "0x4000A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public System.Action onWaterMiddle;

		[Token(Token = "0x4000A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float warningInterval;

		[Token(Token = "0x4000A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int warningThreshold;

		[Token(Token = "0x4000A7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int hintThreshold;

		[Token(Token = "0x4000A7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool isHungry;

		[Token(Token = "0x4000A7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		private bool isThirsty;

		[Token(Token = "0x4000A7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
		private bool isTired;

		[Token(Token = "0x4000A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEF")]
		private bool isDying;

		[Token(Token = "0x4000A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool isFoodMiddle;

		[Token(Token = "0x4000A81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool isWaterMiddle;

		[Token(Token = "0x4000A82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float sickPossibility;

		[Token(Token = "0x4000A83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float m_EnergyLevel;

		[Token(Token = "0x4000A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private float m_WaterLevel;

		[Token(Token = "0x4000A85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float m_Vital;

		[Token(Token = "0x4000A86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float m_FoodLevel;

		[Token(Token = "0x4000A87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UserPerformance m_Performance;

		[Token(Token = "0x4000A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int m_NextUpgradeUnit;

		[Token(Token = "0x4000A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private int m_MaxLevel;

		[Token(Token = "0x4000A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float m_ElapsedTimeEnergy;

		[Token(Token = "0x4000A8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float m_EnergyUnit;

		[Token(Token = "0x4000A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float m_ElapsedTimeWater;

		[Token(Token = "0x4000A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float m_WaterUnit;

		[Token(Token = "0x4000A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float m_ElapsedTimeFood;

		[Token(Token = "0x4000A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float m_FoodUnit;

		[Token(Token = "0x4000A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float m_ElapsedTimeVital;

		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float m_VitalUnit;

		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float m_sickUnit;

		[Token(Token = "0x4000A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private float m_ElapsedTimeSick;

		[Token(Token = "0x4000A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private float m_ElapsedTimeToxic;

		[Token(Token = "0x4000A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private float m_LastTimeHungry;

		[Token(Token = "0x4000A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float m_LastTimeThirsty;

		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private float m_LastTimeTired;

		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private int m_LatchedExperience;

		[Token(Token = "0x4000A99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private int m_LatchedLevel;

		[Token(Token = "0x4000A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 m_LatchedPosition;

		[Token(Token = "0x4000A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public System.Action onWaterAdded;

		[Token(Token = "0x4000A9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public System.Action onEnergyAdded;

		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public System.Action onFoodAdded;

		[Token(Token = "0x4000A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public Action<float> onVitalChanged;

		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public System.Action onOutOfWater;

		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public System.Action onOutOfEnergy;

		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public System.Action onOutOfFood;

		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private bool isOutOfWater;

		[Token(Token = "0x4000AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A1")]
		private bool isOutOfFood;

		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A2")]
		private bool isOutOfEnergy;

		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A3")]
		private bool m_IsSick;

		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private bool m_IsToxic;

		[Token(Token = "0x4000AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private float cameraYOffset;

		[Token(Token = "0x4000AA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Transform mainCamera;

		[Token(Token = "0x4000AA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Transform xrRigTransform;

		[Token(Token = "0x4000AAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3 lastPos;

		[Token(Token = "0x1700010F")]
		public bool IsHungry
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x8CD950", Offset = "0x8CD950", VA = "0x8CD950")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000110")]
		public bool IsThirsty
		{
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x8CD958", Offset = "0x8CD958", VA = "0x8CD958")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000111")]
		public int Level
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x8CD960", Offset = "0x8CD960", VA = "0x8CD960")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000112")]
		public bool IsAlive
		{
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x8CDB58", Offset = "0x8CDB58", VA = "0x8CDB58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000113")]
		public UserPerformance Performance
		{
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x8CDA04", Offset = "0x8CDA04", VA = "0x8CDA04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		public int NextUpgradeUnit
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x8CDB68", Offset = "0x8CDB68", VA = "0x8CDB68")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000115")]
		public float SickPossibility
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x8CDB70", Offset = "0x8CDB70", VA = "0x8CDB70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x8CDB78", Offset = "0x8CDB78", VA = "0x8CDB78")]
			set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public bool IsSick
		{
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x8CDB80", Offset = "0x8CDB80", VA = "0x8CDB80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x8CDB88", Offset = "0x8CDB88", VA = "0x8CDB88")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public bool IsToxic
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x8CDB94", Offset = "0x8CDB94", VA = "0x8CDB94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x8CDB9C", Offset = "0x8CDB9C", VA = "0x8CDB9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public bool IsDying
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x8CDBA8", Offset = "0x8CDBA8", VA = "0x8CDBA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000119")]
		public bool IsTired
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x8CC240", Offset = "0x8CC240", VA = "0x8CC240")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011A")]
		public bool IsOutOfWater
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x8CDBB0", Offset = "0x8CDBB0", VA = "0x8CDBB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		public bool IsOutOfFood
		{
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x8CDBB8", Offset = "0x8CDBB8", VA = "0x8CDBB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x8CDBC0", Offset = "0x8CDBC0", VA = "0x8CDBC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x8CE014", Offset = "0x8CE014", VA = "0x8CE014")]
		private float GetDifficultyCoefficient()
		{
			return default(float);
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x8CE098", Offset = "0x8CE098", VA = "0x8CE098")]
		private void Start()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x8CE138", Offset = "0x8CE138", VA = "0x8CE138")]
		private void OnChanged_Level()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x8CE41C", Offset = "0x8CE41C", VA = "0x8CE41C")]
		public void AddExperience(int value)
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x8CE4A8", Offset = "0x8CE4A8", VA = "0x8CE4A8")]
		private void OnChanged_Experience()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x8CE1B4", Offset = "0x8CE1B4", VA = "0x8CE1B4")]
		private void UpdateLevelUpUnit(int level)
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x8CE55C", Offset = "0x8CE55C", VA = "0x8CE55C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x8CE574", Offset = "0x8CE574", VA = "0x8CE574")]
		public void LoadLocal()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x8CE70C", Offset = "0x8CE70C", VA = "0x8CE70C")]
		public void SaveLocal()
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x8CE89C", Offset = "0x8CE89C", VA = "0x8CE89C")]
		public UserMetricsJsonObj GetUserMetrics()
		{
			return default(UserMetricsJsonObj);
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x8CE920", Offset = "0x8CE920", VA = "0x8CE920")]
		private void Update()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x8CEF58", Offset = "0x8CEF58", VA = "0x8CEF58")]
		private void UpdateEnergyLevel(float delta)
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x8CF294", Offset = "0x8CF294", VA = "0x8CF294")]
		public void UpdateVital(float delta)
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x8CF05C", Offset = "0x8CF05C", VA = "0x8CF05C")]
		private void UpdateWaterLevel(float delta)
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x8CF178", Offset = "0x8CF178", VA = "0x8CF178")]
		private void UpdateFoodLevel(float delta)
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x8CF5A0", Offset = "0x8CF5A0", VA = "0x8CF5A0")]
		public bool IsSheltered()
		{
			return default(bool);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x8CF728", Offset = "0x8CF728", VA = "0x8CF728")]
		public void SetSick()
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x8CF80C", Offset = "0x8CF80C", VA = "0x8CF80C")]
		public void SetToxic()
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x8CF920", Offset = "0x8CF920", VA = "0x8CF920")]
		public void RecoverSick()
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x8CF958", Offset = "0x8CF958", VA = "0x8CF958")]
		internal void RecoverToxic()
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x8CFA08", Offset = "0x8CFA08", VA = "0x8CFA08")]
		private bool IgnoreMetricChange()
		{
			return default(bool);
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x8CF4C4", Offset = "0x8CF4C4", VA = "0x8CF4C4")]
		private void Die()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x8CFAAC", Offset = "0x8CFAAC", VA = "0x8CFAAC")]
		public void UpdateMetrics(float energy, float food, float water, float vital)
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x8CF374", Offset = "0x8CF374", VA = "0x8CF374")]
		private void Notice()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x8CF4E0", Offset = "0x8CF4E0", VA = "0x8CF4E0")]
		private void VitalAlarm()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x8CF404", Offset = "0x8CF404", VA = "0x8CF404")]
		private void TiredSound()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x8CD31C", Offset = "0x8CD31C", VA = "0x8CD31C")]
		public float GetMetrics(MetricType type)
		{
			return default(float);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x8CFB40", Offset = "0x8CFB40", VA = "0x8CFB40")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x8CFC4C", Offset = "0x8CFC4C", VA = "0x8CFC4C")]
		public UserMetrics()
		{
		}
	}
	[Token(Token = "0x20001EE")]
	public class VersionText : MonoBehaviour
	{
		[Token(Token = "0x4000ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_Text text;

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x8D0CA4", Offset = "0x8D0CA4", VA = "0x8D0CA4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x8D0DB4", Offset = "0x8D0DB4", VA = "0x8D0DB4")]
		public VersionText()
		{
		}
	}
	[Token(Token = "0x20001EF")]
	public class Watch : MonoBehaviour
	{
		[Token(Token = "0x4000ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject UserCanvas;

		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject TimeCanvas;

		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isTimeCanvas;

		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static System.Action switchWatch;

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x8D0DBC", Offset = "0x8D0DBC", VA = "0x8D0DBC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x8D0DFC", Offset = "0x8D0DFC", VA = "0x8D0DFC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x8D0F1C", Offset = "0x8D0F1C", VA = "0x8D0F1C")]
		public Watch()
		{
		}
	}
	[Token(Token = "0x20001F0")]
	public class WaterEffect : MonoBehaviour
	{
		[Token(Token = "0x4000AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material InWaterMaterial;

		[Token(Token = "0x4000AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material originMaterial;

		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Renderer render;

		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AudioClip splashSound;

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x8D0F24", Offset = "0x8D0F24", VA = "0x8D0F24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x8D104C", Offset = "0x8D104C", VA = "0x8D104C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x8D14F4", Offset = "0x8D14F4", VA = "0x8D14F4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x8D15E4", Offset = "0x8D15E4", VA = "0x8D15E4")]
		public WaterEffect()
		{
		}
	}
	[Token(Token = "0x20001F1")]
	public class CustomCertificateHandler : CertificateHandler
	{
		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string m_PubKey;

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x8D15EC", Offset = "0x8D15EC", VA = "0x8D15EC")]
		public CustomCertificateHandler()
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x8D15F4", Offset = "0x8D15F4", VA = "0x8D15F4", Slot = "5")]
		protected override bool ValidateCertificate(byte[] certificateData)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x20001F2")]
	[UsedImplicitly]
	public class AbstractModel
	{
		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int uid;

		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x8D165C", Offset = "0x8D165C", VA = "0x8D165C")]
		public AbstractModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001F3")]
	[UsedImplicitly]
	public class AccountModel : AbstractModel
	{
		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int account_id;

		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int performance_id;

		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string info;

		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string created_time;

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x8D1664", Offset = "0x8D1664", VA = "0x8D1664")]
		public AccountModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001F4")]
	[UsedImplicitly]
	public class SessionModel : AbstractModel
	{
		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int session_id;

		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string scene_info;

		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string item_info;

		[Token(Token = "0x4000ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string status;

		[Token(Token = "0x4000ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string created_time;

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x8D166C", Offset = "0x8D166C", VA = "0x8D166C")]
		public SessionModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001F5")]
	[UsedImplicitly]
	public class OverviewModel : AbstractModel
	{
		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int session_id;

		[Token(Token = "0x4000AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string session_name;

		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool is_public;

		[Token(Token = "0x4000AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int owner_id;

		[Token(Token = "0x4000AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string info;

		[Token(Token = "0x4000AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string created_time;

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x8D1674", Offset = "0x8D1674", VA = "0x8D1674")]
		public OverviewModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001F6")]
	[UsedImplicitly]
	public class EventModel
	{
		[Token(Token = "0x4000AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int session_id;

		[Token(Token = "0x4000AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int account_id;

		[Token(Token = "0x4000AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string interaction;

		[Token(Token = "0x4000AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string gameplay;

		[Token(Token = "0x4000ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string extra;

		[Token(Token = "0x4000ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string last_updated;

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x8D167C", Offset = "0x8D167C", VA = "0x8D167C")]
		public EventModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001F7")]
	[UsedImplicitly]
	public class LogModel
	{
		[Token(Token = "0x4000ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int session_id;

		[Token(Token = "0x4000ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string log_type;

		[Token(Token = "0x4000ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string message;

		[Token(Token = "0x4000ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string created_time;

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x8D1684", Offset = "0x8D1684", VA = "0x8D1684")]
		public LogModel()
		{
		}
	}
	[Token(Token = "0x20001F8")]
	public class RemoteDataService
	{
		[Token(Token = "0x20001F9")]
		public enum DataType
		{
			[Token(Token = "0x4000AE4")]
			Unknown,
			[Token(Token = "0x4000AE5")]
			Login,
			[Token(Token = "0x4000AE6")]
			Account,
			[Token(Token = "0x4000AE7")]
			Session,
			[Token(Token = "0x4000AE8")]
			Overview,
			[Token(Token = "0x4000AE9")]
			Event,
			[Token(Token = "0x4000AEA")]
			Log
		}

		[Serializable]
		[Token(Token = "0x20001FA")]
		public class ListOfRecords<T>
		{
			[Token(Token = "0x4000AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int count;

			[Token(Token = "0x4000AEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<T> results;

			[Token(Token = "0x60009B0")]
			public ListOfRecords()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001FB")]
		[CompilerGenerated]
		private struct <GetAccountAsync>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4000AED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000AEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AccountModel> <>t__builder;

			[Token(Token = "0x4000AEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RemoteDataService <>4__this;

			[Token(Token = "0x4000AF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string id;

			[Token(Token = "0x4000AF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<AccountModel> <>u__1;

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x8D1C0C", Offset = "0x8D1C0C", VA = "0x8D1C0C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x8D1E00", Offset = "0x8D1E00", VA = "0x8D1E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001FC")]
		[CompilerGenerated]
		private struct <CreateAccountAsync>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4000AF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000AF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Token(Token = "0x4000AF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RemoteDataService <>4__this;

			[Token(Token = "0x4000AF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AccountModel account;

			[Token(Token = "0x4000AF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<WebRequest.Reply> callback;

			[Token(Token = "0x4000AF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x8D1E58", Offset = "0x8D1E58", VA = "0x8D1E58", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x8D204C", Offset = "0x8D204C", VA = "0x8D204C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001FD")]
		[CompilerGenerated]
		private struct <UpdateAccountAsync>d__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4000AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000AF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Token(Token = "0x4000AFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AccountModel account;

			[Token(Token = "0x4000AFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RemoteDataService <>4__this;

			[Token(Token = "0x4000AFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<WebRequest.Reply> callback;

			[Token(Token = "0x4000AFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x8D20A4", Offset = "0x8D20A4", VA = "0x8D20A4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x8D22AC", Offset = "0x8D22AC", VA = "0x8D22AC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001FE")]
		[CompilerGenerated]
		private struct <GetAsync>d__10<T> : IAsyncStateMachine
		{
			[Token(Token = "0x4000AFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000AFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Token(Token = "0x4000B00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RemoteDataService <>4__this;

			[Token(Token = "0x4000B01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string id;

			[Token(Token = "0x4000B02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<WebRequest.Reply> <>u__1;

			[Token(Token = "0x60009B7")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009B8")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001FF")]
		[CompilerGenerated]
		private struct <GetAllAsync>d__11<T> : IAsyncStateMachine
		{
			[Token(Token = "0x4000B03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<ListOfRecords<T>> <>t__builder;

			[Token(Token = "0x4000B05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RemoteDataService <>4__this;

			[Token(Token = "0x4000B06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<WebRequest.Reply> <>u__1;

			[Token(Token = "0x60009B9")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009BA")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000200")]
		[CompilerGenerated]
		private struct <CreateAsync>d__12<T> : IAsyncStateMachine
		{
			[Token(Token = "0x4000B07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Token(Token = "0x4000B09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RemoteDataService <>4__this;

			[Token(Token = "0x4000B0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T record;

			[Token(Token = "0x4000B0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<WebRequest.Reply> callback;

			[Token(Token = "0x4000B0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<WebRequest.Reply> <>u__1;

			[Token(Token = "0x60009BB")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009BC")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000201")]
		[CompilerGenerated]
		private struct <UpdateAsync>d__13<T> : IAsyncStateMachine
		{
			[Token(Token = "0x4000B0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Token(Token = "0x4000B0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RemoteDataService <>4__this;

			[Token(Token = "0x4000B10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int uid;

			[Token(Token = "0x4000B11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T record;

			[Token(Token = "0x4000B12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<WebRequest.Reply> callback;

			[Token(Token = "0x4000B13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<WebRequest.Reply> <>u__1;

			[Token(Token = "0x60009BD")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009BE")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string kApiHostIp;

		[Token(Token = "0x4000AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string kPort;

		[Token(Token = "0x4000AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<DataType, string> m_AssetUris;

		[Token(Token = "0x1700011C")]
		public static string kApiHost
		{
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x8D168C", Offset = "0x8D168C", VA = "0x8D168C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x8D1700", Offset = "0x8D1700", VA = "0x8D1700")]
		[AsyncStateMachine(typeof(<GetAccountAsync>d__7))]
		public Task<AccountModel> GetAccountAsync(string id)
		{
			return null;
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x8D17FC", Offset = "0x8D17FC", VA = "0x8D17FC")]
		[AsyncStateMachine(typeof(<CreateAccountAsync>d__8))]
		public Task<bool> CreateAccountAsync(AccountModel account, Action<WebRequest.Reply> callback)
		{
			return null;
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x8D1908", Offset = "0x8D1908", VA = "0x8D1908")]
		[AsyncStateMachine(typeof(<UpdateAccountAsync>d__9))]
		public Task<bool> UpdateAccountAsync(AccountModel account, Action<WebRequest.Reply> callback)
		{
			return null;
		}

		[Token(Token = "0x60009A9")]
		[AsyncStateMachine(typeof(<GetAsync>d__10<>))]
		public Task<T> GetAsync<T>(string id)
		{
			return null;
		}

		[Token(Token = "0x60009AA")]
		[AsyncStateMachine(typeof(<GetAllAsync>d__11<>))]
		public Task<ListOfRecords<T>> GetAllAsync<T>()
		{
			return null;
		}

		[Token(Token = "0x60009AB")]
		[AsyncStateMachine(typeof(<CreateAsync>d__12<>))]
		public Task<bool> CreateAsync<T>(T record, Action<WebRequest.Reply> callback)
		{
			return null;
		}

		[Token(Token = "0x60009AC")]
		[AsyncStateMachine(typeof(<UpdateAsync>d__13<>))]
		public Task<bool> UpdateAsync<T>(int uid, T record, Action<WebRequest.Reply> callback)
		{
			return null;
		}

		[Token(Token = "0x60009AD")]
		private DataType GetDataType<T>()
		{
			return default(DataType);
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x8D1A14", Offset = "0x8D1A14", VA = "0x8D1A14")]
		public RemoteDataService()
		{
		}
	}
	[Token(Token = "0x2000202")]
	public class WebServiceException : Exception
	{
		[Token(Token = "0x1700011D")]
		public string UserFriendly
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x8D2304", Offset = "0x8D2304", VA = "0x8D2304")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x8D230C", Offset = "0x8D230C", VA = "0x8D230C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x8D2314", Offset = "0x8D2314", VA = "0x8D2314")]
		public WebServiceException(string usf, [Optional] Exception inner)
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x8D238C", Offset = "0x8D238C", VA = "0x8D238C")]
		public WebServiceException(string usf, string details, [Optional] Exception inner)
		{
		}
	}
	[Token(Token = "0x2000203")]
	public class WebRequest
	{
		[Token(Token = "0x2000204")]
		public struct Reply
		{
			[Token(Token = "0x4000B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private byte[] data;

			[Token(Token = "0x1700011F")]
			public byte[] Raw
			{
				[Token(Token = "0x60009CB")]
				[Address(RVA = "0x8D285C", Offset = "0x8D285C", VA = "0x8D285C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000120")]
			public string Text
			{
				[Token(Token = "0x60009CC")]
				[Address(RVA = "0x8D2864", Offset = "0x8D2864", VA = "0x8D2864")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000121")]
			public JObject JsonObj
			{
				[Token(Token = "0x60009CD")]
				[Address(RVA = "0x8D28A8", Offset = "0x8D28A8", VA = "0x8D28A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x8D28D0", Offset = "0x8D28D0", VA = "0x8D28D0")]
			public Reply(byte[] data)
			{
			}

			[Token(Token = "0x60009CF")]
			public T Deserialize<T>()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x2000205")]
		public enum ResponseStatus
		{
			[Token(Token = "0x4000B1D")]
			Success,
			[Token(Token = "0x4000B1E")]
			AuthError,
			[Token(Token = "0x4000B1F")]
			TransientServerError,
			[Token(Token = "0x4000B20")]
			UknownError
		}

		[StructLayout(3)]
		[Token(Token = "0x2000207")]
		[CompilerGenerated]
		private struct <SendAsync>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000B23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000B24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<Reply> <>t__builder;

			[Token(Token = "0x4000B25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WebRequest <>4__this;

			[Token(Token = "0x4000B26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Func<UploadHandler> payloadCreator;

			[Token(Token = "0x4000B27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string contentType;

			[Token(Token = "0x4000B28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <retries>5__2;

			[Token(Token = "0x4000B29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int <retryIndex>5__3;

			[Token(Token = "0x4000B2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__4;

			[Token(Token = "0x4000B2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private object <>u__1;

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x8D2950", Offset = "0x8D2950", VA = "0x8D2950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x8D3248", Offset = "0x8D3248", VA = "0x8D3248", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000B15")]
		private const int kNumRetries = 3;

		[Token(Token = "0x4000B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Uri;

		[Token(Token = "0x4000B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Method;

		[Token(Token = "0x4000B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[] m_Result;

		[Token(Token = "0x4000B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_Done;

		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CertificateHandler m_CustomCertHandler;

		[Token(Token = "0x1700011E")]
		public bool Done
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x8D2440", Offset = "0x8D2440", VA = "0x8D2440")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x8D2448", Offset = "0x8D2448", VA = "0x8D2448")]
		public static Task<Reply> GetAsync(string uri)
		{
			return null;
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x8D24C8", Offset = "0x8D24C8", VA = "0x8D24C8")]
		public WebRequest(string uri, string method = "GET")
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x8D25A4", Offset = "0x8D25A4", VA = "0x8D25A4")]
		public Task<Reply> SendAsync()
		{
			return null;
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x8D26C0", Offset = "0x8D26C0", VA = "0x8D26C0")]
		public Task<Reply> SendAsync(string jsonstr)
		{
			return null;
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x8D25B0", Offset = "0x8D25B0", VA = "0x8D25B0")]
		[AsyncStateMachine(typeof(<SendAsync>d__14))]
		public Task<Reply> SendAsync(Func<UploadHandler> payloadCreator, string contentType)
		{
			return null;
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x8D2814", Offset = "0x8D2814", VA = "0x8D2814")]
		private ResponseStatus ParseResponseCode(long code)
		{
			return default(ResponseStatus);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x8D284C", Offset = "0x8D284C", VA = "0x8D284C")]
		private static float BackoffSeconds(int retries)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000208")]
	public enum InteractableType
	{
		[Token(Token = "0x4000B2D")]
		Unknown,
		[Token(Token = "0x4000B2E")]
		Collectable,
		[Token(Token = "0x4000B2F")]
		LifeCycle,
		[Token(Token = "0x4000B30")]
		RawMaterial,
		[Token(Token = "0x4000B31")]
		Synthesis
	}
	[Token(Token = "0x2000209")]
	public enum BoxContainerType
	{
		[Token(Token = "0x4000B33")]
		Chest,
		[Token(Token = "0x4000B34")]
		Storage
	}
	[Serializable]
	[Token(Token = "0x200020A")]
	public struct CollectableJsonObj
	{
		[Token(Token = "0x4000B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int PrefabId;

		[Token(Token = "0x4000B36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string SpawnerName;

		[Token(Token = "0x4000B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int SpawnPointIndex;

		[Token(Token = "0x4000B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int BoxConfigIndex;

		[Token(Token = "0x4000B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsKinect;

		[Token(Token = "0x4000B3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 Position;

		[Token(Token = "0x4000B3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Quaternion Rotation;

		[Token(Token = "0x4000B3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 Scale;

		[Token(Token = "0x4000B3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int Durability;

		[Token(Token = "0x4000B3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool IsOccupied;

		[Token(Token = "0x4000B3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool IsRegenStartValid;

		[Token(Token = "0x4000B40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public GameDate RegenStartTime;

		[Token(Token = "0x4000B41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float StoredValue;
	}
	[Serializable]
	[Token(Token = "0x200020B")]
	public struct ListOfCollectable
	{
		[Token(Token = "0x4000B42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<CollectableJsonObj> items;
	}
	[Serializable]
	[Token(Token = "0x200020C")]
	public struct LifeCycleJsonObj
	{
		[Token(Token = "0x4000B43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int name;

		[Token(Token = "0x4000B44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int foundation;

		[Token(Token = "0x4000B45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int state;

		[Token(Token = "0x4000B46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string SpawnerName;

		[Token(Token = "0x4000B47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnPointIndex;

		[Token(Token = "0x4000B48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x4000B49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 CurrentObjPosition;

		[Token(Token = "0x4000B4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000B4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float elapsedTime;

		[Token(Token = "0x4000B4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float timeLeftToSpawn;
	}
	[Serializable]
	[Token(Token = "0x200020D")]
	public struct ListOfLifeCycle
	{
		[Token(Token = "0x4000B4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<LifeCycleJsonObj> items;
	}
	[Serializable]
	[Token(Token = "0x200020E")]
	public struct MaterialJsonObj
	{
		[Token(Token = "0x4000B4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int name;

		[Token(Token = "0x4000B4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int amount;
	}
	[Serializable]
	[Token(Token = "0x200020F")]
	public struct ListOfMaterial
	{
		[Token(Token = "0x4000B50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<MaterialJsonObj> items;
	}
	[Serializable]
	[Token(Token = "0x2000210")]
	public struct WorldJsonObj
	{
		[Token(Token = "0x4000B51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<CollectableJsonObj> collectables;

		[Token(Token = "0x4000B52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public List<LifeCycleJsonObj> lives;

		[Token(Token = "0x4000B53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<MaterialJsonObj> materials;
	}
	[Serializable]
	[Token(Token = "0x2000211")]
	public struct ListOfBuildings
	{
		[Token(Token = "0x4000B54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<string> buildingsInfo;
	}
	[Serializable]
	[Token(Token = "0x2000212")]
	public struct ListOfChestBoxes
	{
		[Token(Token = "0x4000B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<string> chestBoxesInfo;
	}
	[Serializable]
	[Token(Token = "0x2000213")]
	public struct SystemSettings
	{
		[Token(Token = "0x4000B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool isLocomotionOn;
	}
	[Token(Token = "0x2000214")]
	public class World : MonoBehaviour
	{
		[Token(Token = "0x4000B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Transform Spawners;

		[Token(Token = "0x4000B58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public List<ChestController> chestBoxes;

		[Token(Token = "0x4000B59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public List<ChestController> storageBoxes;

		[Token(Token = "0x4000B5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CollectableObjectsConfig collectableConfig;

		[Token(Token = "0x4000B5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<PrefabName, ObjectSpawner> m_ObjSpawnerMap;

		[Token(Token = "0x4000B5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<PrefabName, List<GameObject>> m_SpawnPointMap;

		[Token(Token = "0x4000B5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<SerializationScript> m_CollectableObjTracked;

		[Token(Token = "0x4000B5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CollectableDatabase m_CollectableDb;

		[Token(Token = "0x4000B5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<GameObject> m_LiveObjTracked;

		[Token(Token = "0x4000B60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<PrefabName, int> m_BasicMaterials;

		[Token(Token = "0x4000B61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static World m_Instance;

		[Token(Token = "0x4000B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<BuildingHolder> m_Buildings;

		[Token(Token = "0x4000B63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<IslandMgr> m_Islands;

		[Token(Token = "0x17000122")]
		public static World Instance
		{
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x8D32A0", Offset = "0x8D32A0", VA = "0x8D32A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000123")]
		public Dictionary<PrefabName, List<GameObject>> SpawnPointMap
		{
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x8D32E8", Offset = "0x8D32E8", VA = "0x8D32E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000124")]
		public CollectableDatabase CollectableDb
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x8D372C", Offset = "0x8D372C", VA = "0x8D372C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000125")]
		public List<SerializationScript> ListOfCollectablesTracked
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x8D380C", Offset = "0x8D380C", VA = "0x8D380C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000126")]
		public List<GameObject> ListOfLiveObjectsTracked
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x8D3814", Offset = "0x8D3814", VA = "0x8D3814")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x8D381C", Offset = "0x8D381C", VA = "0x8D381C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x8D3A6C", Offset = "0x8D3A6C", VA = "0x8D3A6C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x8D3E88", Offset = "0x8D3E88", VA = "0x8D3E88")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x8D3EFC", Offset = "0x8D3EFC", VA = "0x8D3EFC")]
		public void RegisterIsland(IslandMgr island)
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x8D4008", Offset = "0x8D4008", VA = "0x8D4008")]
		public void RegisterBoxContainer(BoxContainerType type, ChestController controller)
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x8D411C", Offset = "0x8D411C", VA = "0x8D411C")]
		public void RegisterToTrack(GameObject go)
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x8D459C", Offset = "0x8D459C", VA = "0x8D459C")]
		public void UnregisterBoxContainer(BoxContainerType type, ChestController controller)
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x8D465C", Offset = "0x8D465C", VA = "0x8D465C")]
		public void UnregisterToTrack(GameObject go)
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x8D3B14", Offset = "0x8D3B14", VA = "0x8D3B14")]
		public void InitSpawners()
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x8D47C0", Offset = "0x8D47C0", VA = "0x8D47C0")]
		public void EnableSpawners()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x8D48F0", Offset = "0x8D48F0", VA = "0x8D48F0")]
		public void SaveSpawners()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x8D4A1C", Offset = "0x8D4A1C", VA = "0x8D4A1C")]
		public WorldJsonObj GetWorldObjects()
		{
			return default(WorldJsonObj);
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x8D54F8", Offset = "0x8D54F8", VA = "0x8D54F8")]
		public void RegisterBuilding(GameObject building)
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x8D5674", Offset = "0x8D5674", VA = "0x8D5674")]
		public void LoadWorldObjects(WorldJsonObj objects)
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x8D6020", Offset = "0x8D6020", VA = "0x8D6020")]
		public void TakeSnapshot()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x8D3D80", Offset = "0x8D3D80", VA = "0x8D3D80")]
		public void Restore()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x8D8EB0", Offset = "0x8D8EB0", VA = "0x8D8EB0")]
		public bool IsAffordable(SynthesisRecipeSetting recipe)
		{
			return default(bool);
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x8D8FA4", Offset = "0x8D8FA4", VA = "0x8D8FA4")]
		public bool Consume(PrefabName type, int amount)
		{
			return default(bool);
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x8D5F30", Offset = "0x8D5F30", VA = "0x8D5F30")]
		public void Collect(PrefabName type, int amount)
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x8D9284", Offset = "0x8D9284", VA = "0x8D9284")]
		public int GetAmount(PrefabName type)
		{
			return default(int);
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x8D9318", Offset = "0x8D9318", VA = "0x8D9318")]
		public int GetCollectableAmount(PrefabName prefabName)
		{
			return default(int);
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x8D9500", Offset = "0x8D9500", VA = "0x8D9500")]
		public ObjectSpawner GetObjectSpawner(PrefabName name)
		{
			return null;
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x8D629C", Offset = "0x8D629C", VA = "0x8D629C")]
		private void SaveCollectables()
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x8D6914", Offset = "0x8D6914", VA = "0x8D6914")]
		private void LoadCollectables()
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x8D6390", Offset = "0x8D6390", VA = "0x8D6390")]
		private void SaveLifeCycleObjects()
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x8D85CC", Offset = "0x8D85CC", VA = "0x8D85CC")]
		private void LoadLifeCycleObjects()
		{
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x8DA164", Offset = "0x8DA164", VA = "0x8DA164")]
		private void AttachToPlantFoundation(LifeCycleBase lcb)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x8D6484", Offset = "0x8D6484", VA = "0x8D6484")]
		private void SaveMaterials()
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x8D73B8", Offset = "0x8D73B8", VA = "0x8D73B8")]
		private void LoadMaterials()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x8D6578", Offset = "0x8D6578", VA = "0x8D6578")]
		private void SaveBuildings()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x8D75E0", Offset = "0x8D75E0", VA = "0x8D75E0")]
		private void LoadBuidings()
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x8DA600", Offset = "0x8DA600", VA = "0x8DA600")]
		private void SaveBoxContainersByType(BoxContainerType type)
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x8D690C", Offset = "0x8D690C", VA = "0x8D690C")]
		private void SaveStorageBoxes()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x8D6904", Offset = "0x8D6904", VA = "0x8D6904")]
		private void SaveChestBoxes()
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x8DA91C", Offset = "0x8DA91C", VA = "0x8DA91C")]
		private void LoadBoxContainersByType(BoxContainerType type)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x8D8EA8", Offset = "0x8D8EA8", VA = "0x8D8EA8")]
		private void LoadStorageBoxes()
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x8D8EA0", Offset = "0x8D8EA0", VA = "0x8D8EA0")]
		private void LoadChestBoxes()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x8D37A0", Offset = "0x8D37A0", VA = "0x8D37A0")]
		private void InitCollectables()
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x8D334C", Offset = "0x8D334C", VA = "0x8D334C")]
		private void PopulateSpawnPointMap()
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x8D9594", Offset = "0x8D9594", VA = "0x8D9594")]
		private string CollectableJsonString()
		{
			return null;
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x8D9BD0", Offset = "0x8D9BD0", VA = "0x8D9BD0")]
		private string LifeCycleJsonString()
		{
			return null;
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x8DA3D4", Offset = "0x8DA3D4", VA = "0x8DA3D4")]
		private string MaterialJsonString()
		{
			return null;
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x8DAD9C", Offset = "0x8DAD9C", VA = "0x8DAD9C")]
		public World()
		{
		}
	}
	[Token(Token = "0x2000216")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	public class SkyController : MonoBehaviour
	{
		[Token(Token = "0x4000B66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SkyController Instance;

		[Token(Token = "0x4000B67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Sky colors")]
		public bool overrideSkyColors;

		[Token(Token = "0x4000B68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[GradientUsage(true)]
		public Gradient topColor;

		[Token(Token = "0x4000B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[GradientUsage(true)]
		public Gradient middleColor;

		[Token(Token = "0x4000B6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[GradientUsage(true)]
		public Gradient bottomColor;

		[Token(Token = "0x4000B6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Sun color")]
		public bool overrideSunColor;

		[Token(Token = "0x4000B6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[GradientUsage(true)]
		public Gradient sunColor;

		[Token(Token = "0x4000B6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Sun light color")]
		public bool overrideLightColor;

		[Token(Token = "0x4000B6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Gradient lightColor;

		[Token(Token = "0x4000B6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Ambient sky color")]
		public bool overrideAmbientSkyColor;

		[Token(Token = "0x4000B70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[GradientUsage(true)]
		public Gradient ambientSkyColor;

		[Token(Token = "0x4000B71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Clouds color")]
		public bool overrideCloudsColor;

		[Token(Token = "0x4000B72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[GradientUsage(true)]
		public Gradient cloudsColor;

		[Token(Token = "0x4000B73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Header("Debug scrub")]
		public bool useSrub;

		[Token(Token = "0x4000B74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float scrub;

		[Token(Token = "0x4000B75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Light sun;

		[Token(Token = "0x4000B76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float cloudIntensity;

		[Token(Token = "0x4000B77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float cloudThickness;

		[Token(Token = "0x4000B78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material skyMaterial;

		[Token(Token = "0x17000127")]
		public Light Sun
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x8DAE18", Offset = "0x8DAE18", VA = "0x8DAE18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000128")]
		public Material SkyMaterial
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x8DAEAC", Offset = "0x8DAEAC", VA = "0x8DAEAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x8DAF28", Offset = "0x8DAF28", VA = "0x8DAF28")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x8DB204", Offset = "0x8DB204", VA = "0x8DB204")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x8DB250", Offset = "0x8DB250", VA = "0x8DB250")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x8DB254", Offset = "0x8DB254", VA = "0x8DB254")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x8DB3E4", Offset = "0x8DB3E4", VA = "0x8DB3E4")]
		public void AdjustClouds(float intensity, float thickness)
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x8DB480", Offset = "0x8DB480", VA = "0x8DB480")]
		public void AdjustTopColor(Color color)
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x8DB508", Offset = "0x8DB508", VA = "0x8DB508")]
		public void ResetClouds()
		{
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x8DAF3C", Offset = "0x8DAF3C", VA = "0x8DAF3C")]
		public void UpdateGradients(float pos)
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x8DB594", Offset = "0x8DB594", VA = "0x8DB594")]
		public SkyController()
		{
		}
	}
}
namespace fvworks.elysium.AI
{
	[Serializable]
	[Token(Token = "0x2000217")]
	public class Action : ScriptableObject
	{
		[Token(Token = "0x4000B79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int m_Priority;

		[Token(Token = "0x4000B7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected bool m_IsInterruptable;

		[Token(Token = "0x4000B7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool m_IsActive;

		[Token(Token = "0x4000B7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private StateData m_Preconditions;

		[Token(Token = "0x4000B7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private StateData m_Effects;

		[Token(Token = "0x17000129")]
		public bool IsActive
		{
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x8DB59C", Offset = "0x8DB59C", VA = "0x8DB59C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x8DB5A4", Offset = "0x8DB5A4", VA = "0x8DB5A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public int Priority
		{
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x8DB5B0", Offset = "0x8DB5B0", VA = "0x8DB5B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700012B")]
		public bool IsInterruptable
		{
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x8DB5B8", Offset = "0x8DB5B8", VA = "0x8DB5B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012C")]
		public StateData Preconditions
		{
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x8DB5C0", Offset = "0x8DB5C0", VA = "0x8DB5C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012D")]
		public StateData Effects
		{
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x8DB5C8", Offset = "0x8DB5C8", VA = "0x8DB5C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x8DB5D0", Offset = "0x8DB5D0", VA = "0x8DB5D0", Slot = "4")]
		public virtual void OnStart(AIBrain agent)
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x8DB5D4", Offset = "0x8DB5D4", VA = "0x8DB5D4", Slot = "5")]
		public virtual void OnUpdate(AIBrain agent)
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x8DB5D8", Offset = "0x8DB5D8", VA = "0x8DB5D8", Slot = "6")]
		public virtual void OnCompletion(AIBrain agent)
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x8DB5DC", Offset = "0x8DB5DC", VA = "0x8DB5DC", Slot = "7")]
		public virtual bool CanActivate(AIBrain agent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x8DB5E4", Offset = "0x8DB5E4", VA = "0x8DB5E4", Slot = "8")]
		public virtual bool StillValid(AIBrain agent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x8DB5EC", Offset = "0x8DB5EC", VA = "0x8DB5EC", Slot = "9")]
		public virtual void Activate(AIBrain agent)
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x8DB5F0", Offset = "0x8DB5F0", VA = "0x8DB5F0", Slot = "10")]
		public virtual void OnDeactivation(AIBrain agent)
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x8DB5F4", Offset = "0x8DB5F4", VA = "0x8DB5F4", Slot = "11")]
		public virtual bool IsDone(AIBrain agent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x8DB5FC", Offset = "0x8DB5FC", VA = "0x8DB5FC", Slot = "12")]
		public virtual void ResetValues()
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x8DB600", Offset = "0x8DB600", VA = "0x8DB600")]
		public Action()
		{
		}
	}
	[Token(Token = "0x2000218")]
	[CreateAssetMenu(fileName = "Attack", menuName = "ScriptableObjects/Attack", order = 1)]
	public class Attack : Action
	{
		[Token(Token = "0x4000B7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_MinAttackDistance;

		[Token(Token = "0x4000B7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_AttackInterval;

		[Token(Token = "0x4000B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_DamageUnit;

		[Token(Token = "0x4000B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public AudioClip m_DamageSound;

		[Token(Token = "0x4000B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_NextTimeToAttack;

		[Token(Token = "0x4000B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool m_HasKilledPlayer;

		[Token(Token = "0x4000B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject m_Target;

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x8DB684", Offset = "0x8DB684", VA = "0x8DB684", Slot = "4")]
		public override void OnStart(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x8DB760", Offset = "0x8DB760", VA = "0x8DB760", Slot = "7")]
		public override bool CanActivate(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x8DB82C", Offset = "0x8DB82C", VA = "0x8DB82C", Slot = "9")]
		public override void Activate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x8DB858", Offset = "0x8DB858", VA = "0x8DB858", Slot = "5")]
		public override void OnUpdate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x8DBB8C", Offset = "0x8DBB8C", VA = "0x8DBB8C", Slot = "8")]
		public override bool StillValid(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x8DBD0C", Offset = "0x8DBD0C", VA = "0x8DBD0C", Slot = "11")]
		public override bool IsDone(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x8DBD40", Offset = "0x8DBD40", VA = "0x8DBD40", Slot = "10")]
		public override void OnDeactivation(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x8DBDA4", Offset = "0x8DBDA4", VA = "0x8DBDA4", Slot = "6")]
		public override void OnCompletion(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x8DB9DC", Offset = "0x8DB9DC", VA = "0x8DB9DC")]
		private void RotateTowards(Transform me, Transform target, float rotationSpeed)
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x8DBE08", Offset = "0x8DBE08", VA = "0x8DBE08")]
		public Attack()
		{
		}
	}
	[Token(Token = "0x2000219")]
	[CreateAssetMenu(fileName = "Chase", menuName = "ScriptableObjects/Chase", order = 1)]
	public class Chase : Action
	{
		[Token(Token = "0x4000B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip attackBGM;

		[Token(Token = "0x4000B86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Target;

		[Token(Token = "0x4000B87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudioSource audioSource;

		[Token(Token = "0x4000B88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isAudioOn;

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x8DBE20", Offset = "0x8DBE20", VA = "0x8DBE20", Slot = "4")]
		public override void OnStart(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x8DBF7C", Offset = "0x8DBF7C", VA = "0x8DBF7C", Slot = "7")]
		public override bool CanActivate(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x8DC088", Offset = "0x8DC088", VA = "0x8DC088", Slot = "9")]
		public override void Activate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x8DC14C", Offset = "0x8DC14C", VA = "0x8DC14C", Slot = "5")]
		public override void OnUpdate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x8DC3C0", Offset = "0x8DC3C0", VA = "0x8DC3C0", Slot = "8")]
		public override bool StillValid(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x8DC414", Offset = "0x8DC414", VA = "0x8DC414", Slot = "11")]
		public override bool IsDone(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x8DC534", Offset = "0x8DC534", VA = "0x8DC534", Slot = "10")]
		public override void OnDeactivation(AIBrain agent)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x8DC560", Offset = "0x8DC560", VA = "0x8DC560", Slot = "6")]
		public override void OnCompletion(AIBrain agent)
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x8DC58C", Offset = "0x8DC58C", VA = "0x8DC58C", Slot = "12")]
		public override void ResetValues()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x8DC210", Offset = "0x8DC210", VA = "0x8DC210")]
		private void RotateTowards(Transform trans, Transform target, float rotationSpeed)
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x8DC0FC", Offset = "0x8DC0FC", VA = "0x8DC0FC")]
		private void ToggleSound(bool turnon)
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x8DC594", Offset = "0x8DC594", VA = "0x8DC594")]
		public Chase()
		{
		}
	}
	[Token(Token = "0x200021A")]
	[CreateAssetMenu(fileName = "ChaseTarget", menuName = "ScriptableObjects/ChaseTarget", order = 1)]
	public class ChaseTarget : Action
	{
		[Token(Token = "0x4000B89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_Target;

		[Token(Token = "0x4000B8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_MaxDuration;

		[Token(Token = "0x4000B8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_BackoffDistance;

		[Token(Token = "0x4000B8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ActivationTime;

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x8DC598", Offset = "0x8DC598", VA = "0x8DC598", Slot = "4")]
		public override void OnStart(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x8DC670", Offset = "0x8DC670", VA = "0x8DC670", Slot = "7")]
		public override bool CanActivate(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x8DC6F8", Offset = "0x8DC6F8", VA = "0x8DC6F8", Slot = "9")]
		public override void Activate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x8DC754", Offset = "0x8DC754", VA = "0x8DC754", Slot = "5")]
		public override void OnUpdate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x8DCAC4", Offset = "0x8DCAC4", VA = "0x8DCAC4", Slot = "8")]
		public override bool StillValid(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x8DCCB0", Offset = "0x8DCCB0", VA = "0x8DCCB0", Slot = "11")]
		public override bool IsDone(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x8DCEE4", Offset = "0x8DCEE4", VA = "0x8DCEE4", Slot = "12")]
		public override void ResetValues()
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x8DC914", Offset = "0x8DC914", VA = "0x8DC914")]
		private void RotateTowards(Transform trans, Transform target, float rotationSpeed)
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x8DCEEC", Offset = "0x8DCEEC", VA = "0x8DCEEC")]
		public ChaseTarget()
		{
		}
	}
	[Token(Token = "0x200021B")]
	[CreateAssetMenu(fileName = "Destroy", menuName = "ScriptableObjects/Destroy", order = 1)]
	public class Destroy : Action
	{
		[Token(Token = "0x4000B8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_MinAttackDistance;

		[Token(Token = "0x4000B8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_AttackInterval;

		[Token(Token = "0x4000B8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_AttackDuration;

		[Token(Token = "0x4000B90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_DamageUnit;

		[Token(Token = "0x4000B91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public AudioClip m_DamageSound;

		[Token(Token = "0x4000B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_NextTimeToAttack;

		[Token(Token = "0x4000B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_TimeToStop;

		[Token(Token = "0x4000B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_HasDestroyedTarget;

		[Token(Token = "0x4000B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject m_Target;

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x8DCEFC", Offset = "0x8DCEFC", VA = "0x8DCEFC", Slot = "4")]
		public override void OnStart(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x8DCFD8", Offset = "0x8DCFD8", VA = "0x8DCFD8", Slot = "7")]
		public override bool CanActivate(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x8DD000", Offset = "0x8DD000", VA = "0x8DD000", Slot = "9")]
		public override void Activate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x8DD09C", Offset = "0x8DD09C", VA = "0x8DD09C", Slot = "5")]
		public override void OnUpdate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x8DD404", Offset = "0x8DD404", VA = "0x8DD404", Slot = "8")]
		public override bool StillValid(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x8DD530", Offset = "0x8DD530", VA = "0x8DD530", Slot = "11")]
		public override bool IsDone(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x8DD580", Offset = "0x8DD580", VA = "0x8DD580", Slot = "10")]
		public override void OnDeactivation(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x8DD254", Offset = "0x8DD254", VA = "0x8DD254")]
		private void RotateTowards(Transform me, Transform target, float rotationSpeed)
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x8DD5E4", Offset = "0x8DD5E4", VA = "0x8DD5E4")]
		public Destroy()
		{
		}
	}
	[Token(Token = "0x200021C")]
	[CreateAssetMenu(fileName = "FindFood", menuName = "ScriptableObjects/FindFood", order = 1)]
	public class FindFood : PointBasedAction
	{
		[Token(Token = "0x4000B96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 m_WaitTime;

		[Token(Token = "0x4000B97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_NextMoveTime;

		[Token(Token = "0x4000B98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_NextTimeout;

		[Token(Token = "0x4000B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_MaxDuration;

		[Token(Token = "0x4000B9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool m_Waiting;

		[Token(Token = "0x4000B9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject m_FoodTarget;

		[Token(Token = "0x4000B9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AIBrain m_Brain;

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x8DD5FC", Offset = "0x8DD5FC", VA = "0x8DD5FC", Slot = "4")]
		public override void OnStart(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x8DD6E8", Offset = "0x8DD6E8", VA = "0x8DD6E8", Slot = "7")]
		public override bool CanActivate(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x8DD710", Offset = "0x8DD710", VA = "0x8DD710", Slot = "9")]
		public override void Activate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x8DD7D8", Offset = "0x8DD7D8", VA = "0x8DD7D8", Slot = "8")]
		public override bool StillValid(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x8DD800", Offset = "0x8DD800", VA = "0x8DD800", Slot = "5")]
		public override void OnUpdate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x8DDB84", Offset = "0x8DDB84", VA = "0x8DDB84", Slot = "10")]
		public override void OnDeactivation(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x8DDBE8", Offset = "0x8DDBE8", VA = "0x8DDBE8", Slot = "11")]
		public override bool IsDone(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x8DDC18", Offset = "0x8DDC18", VA = "0x8DDC18")]
		public FindFood()
		{
		}
	}
	[Token(Token = "0x200021D")]
	[CreateAssetMenu(fileName = "Flee", menuName = "ScriptableObjects/Flee", order = 1)]
	public class Flee : Action
	{
		[Token(Token = "0x4000B9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_MinFleeDistance;

		[Token(Token = "0x4000B9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_MaxDuration;

		[Token(Token = "0x4000B9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_TimeToStop;

		[Token(Token = "0x4000BA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_FleePosition;

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x8DDC28", Offset = "0x8DDC28", VA = "0x8DDC28", Slot = "4")]
		public override void OnStart(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x8DDCF0", Offset = "0x8DDCF0", VA = "0x8DDCF0", Slot = "7")]
		public override bool CanActivate(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x8DDE18", Offset = "0x8DDE18", VA = "0x8DDE18", Slot = "9")]
		public override void Activate(AIBrain agent)
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x8DDE3C", Offset = "0x8DDE3C", VA = "0x8DDE3C", Slot = "5")]
		public override void OnUpdate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x8DE094", Offset = "0x8DE094", VA = "0x8DE094", Slot = "8")]
		public override bool StillValid(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x8DE0BC", Offset = "0x8DE0BC", VA = "0x8DE0BC", Slot = "11")]
		public override bool IsDone(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x8DE11C", Offset = "0x8DE11C", VA = "0x8DE11C")]
		public Flee()
		{
		}
	}
	[Token(Token = "0x200021E")]
	[CreateAssetMenu(fileName = "Idle", menuName = "ScriptableObjects/Player/Idle", order = 1)]
	public class Idle : Action
	{
		[Token(Token = "0x4000BA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AIBrain m_Brain;

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x8DE12C", Offset = "0x8DE12C", VA = "0x8DE12C", Slot = "4")]
		public override void OnStart(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x8DE134", Offset = "0x8DE134", VA = "0x8DE134", Slot = "7")]
		public override bool CanActivate(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x8DE13C", Offset = "0x8DE13C", VA = "0x8DE13C", Slot = "9")]
		public override void Activate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x8DE140", Offset = "0x8DE140", VA = "0x8DE140", Slot = "8")]
		public override bool StillValid(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x8DE148", Offset = "0x8DE148", VA = "0x8DE148", Slot = "5")]
		public override void OnUpdate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x8DE14C", Offset = "0x8DE14C", VA = "0x8DE14C", Slot = "10")]
		public override void OnDeactivation(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x8DE150", Offset = "0x8DE150", VA = "0x8DE150", Slot = "11")]
		public override bool IsDone(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x8DE158", Offset = "0x8DE158", VA = "0x8DE158")]
		public Idle()
		{
		}
	}
	[Token(Token = "0x200021F")]
	[CreateAssetMenu(fileName = "Patrol", menuName = "ScriptableObjects/Patrol", order = 1)]
	public class Patrol : PointBasedAction
	{
		[Token(Token = "0x4000BA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 m_WaitTime;

		[Token(Token = "0x4000BA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_InSky;

		[Token(Token = "0x4000BA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_NextMoveTime;

		[Token(Token = "0x4000BA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_NextTimeout;

		[Token(Token = "0x4000BA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float m_MaxDuration;

		[Token(Token = "0x4000BA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_Waiting;

		[Token(Token = "0x4000BA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AIBrain m_Brain;

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x8DE15C", Offset = "0x8DE15C", VA = "0x8DE15C", Slot = "4")]
		public override void OnStart(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x8DE18C", Offset = "0x8DE18C", VA = "0x8DE18C", Slot = "9")]
		public override void Activate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x8DE224", Offset = "0x8DE224", VA = "0x8DE224", Slot = "5")]
		public override void OnUpdate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x8DE3CC", Offset = "0x8DE3CC", VA = "0x8DE3CC", Slot = "10")]
		public override void OnDeactivation(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x8DE404", Offset = "0x8DE404", VA = "0x8DE404", Slot = "11")]
		public override bool IsDone(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x8DE40C", Offset = "0x8DE40C", VA = "0x8DE40C")]
		public Patrol()
		{
		}
	}
	[Token(Token = "0x2000220")]
	[CreateAssetMenu(fileName = "PlayerFindFood", menuName = "ScriptableObjects/Player/FindFood", order = 1)]
	public class PlayerFindFood : Action
	{
		[Token(Token = "0x4000BA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AIBrain m_Brain;

		[Token(Token = "0x4000BAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FrontUIPresenter frontUI;

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x8DE418", Offset = "0x8DE418", VA = "0x8DE418", Slot = "4")]
		public override void OnStart(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x8DE4D8", Offset = "0x8DE4D8", VA = "0x8DE4D8", Slot = "7")]
		public override bool CanActivate(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x8DE52C", Offset = "0x8DE52C", VA = "0x8DE52C", Slot = "9")]
		public override void Activate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x8DE530", Offset = "0x8DE530", VA = "0x8DE530", Slot = "8")]
		public override bool StillValid(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x8DE584", Offset = "0x8DE584", VA = "0x8DE584", Slot = "5")]
		public override void OnUpdate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x8DE5D8", Offset = "0x8DE5D8", VA = "0x8DE5D8", Slot = "10")]
		public override void OnDeactivation(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x8DE5DC", Offset = "0x8DE5DC", VA = "0x8DE5DC", Slot = "11")]
		public override bool IsDone(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x8DE638", Offset = "0x8DE638", VA = "0x8DE638")]
		public PlayerFindFood()
		{
		}
	}
	[Token(Token = "0x2000221")]
	[CreateAssetMenu(fileName = "PlayerFindWater", menuName = "ScriptableObjects/Player/FindWater", order = 1)]
	public class PlayerFindWater : Action
	{
		[Token(Token = "0x4000BAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AIBrain m_Brain;

		[Token(Token = "0x4000BAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FrontUIPresenter frontUI;

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x8DE63C", Offset = "0x8DE63C", VA = "0x8DE63C", Slot = "4")]
		public override void OnStart(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x8DE6FC", Offset = "0x8DE6FC", VA = "0x8DE6FC", Slot = "7")]
		public override bool CanActivate(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x8DE750", Offset = "0x8DE750", VA = "0x8DE750", Slot = "9")]
		public override void Activate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x8DE754", Offset = "0x8DE754", VA = "0x8DE754", Slot = "8")]
		public override bool StillValid(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x8DE7A8", Offset = "0x8DE7A8", VA = "0x8DE7A8", Slot = "5")]
		public override void OnUpdate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x8DE7FC", Offset = "0x8DE7FC", VA = "0x8DE7FC", Slot = "10")]
		public override void OnDeactivation(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x8DE800", Offset = "0x8DE800", VA = "0x8DE800", Slot = "11")]
		public override bool IsDone(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x8DE85C", Offset = "0x8DE85C", VA = "0x8DE85C")]
		public PlayerFindWater()
		{
		}
	}
	[Token(Token = "0x2000222")]
	[CreateAssetMenu(fileName = "PlayerHeal", menuName = "ScriptableObjects/Player/Heal", order = 1)]
	public class PlayerHeal : Action
	{
		[Token(Token = "0x4000BAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AIBrain m_Brain;

		[Token(Token = "0x4000BAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FrontUIPresenter frontUI;

		[Token(Token = "0x1700012E")]
		public bool InTrouble
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x8DE860", Offset = "0x8DE860", VA = "0x8DE860")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x8DE8CC", Offset = "0x8DE8CC", VA = "0x8DE8CC", Slot = "4")]
		public override void OnStart(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x8DE990", Offset = "0x8DE990", VA = "0x8DE990", Slot = "7")]
		public override bool CanActivate(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x8DE994", Offset = "0x8DE994", VA = "0x8DE994", Slot = "9")]
		public override void Activate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x8DE998", Offset = "0x8DE998", VA = "0x8DE998", Slot = "8")]
		public override bool StillValid(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x8DE99C", Offset = "0x8DE99C", VA = "0x8DE99C", Slot = "5")]
		public override void OnUpdate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x8DE9F8", Offset = "0x8DE9F8", VA = "0x8DE9F8", Slot = "10")]
		public override void OnDeactivation(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x8DE9FC", Offset = "0x8DE9FC", VA = "0x8DE9FC", Slot = "11")]
		public override bool IsDone(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x8DEA14", Offset = "0x8DEA14", VA = "0x8DEA14")]
		public PlayerHeal()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000223")]
	public class PointBasedAction : Action
	{
		[Token(Token = "0x4000BAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<Vector3> m_PointPositions;

		[Token(Token = "0x4000BB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected bool m_IsUrgent;

		[Token(Token = "0x4000BB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int m_PointAmount;

		[Token(Token = "0x4000BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int m_PointMaxRadius;

		[Token(Token = "0x4000BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected int m_CurrentIndex;

		[Token(Token = "0x1700012F")]
		public List<Vector3> PointPositions
		{
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x8DEA18", Offset = "0x8DEA18", VA = "0x8DEA18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x8DD6AC", Offset = "0x8DD6AC", VA = "0x8DD6AC", Slot = "4")]
		public override void OnStart(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x8DEC7C", Offset = "0x8DEC7C", VA = "0x8DEC7C", Slot = "7")]
		public override bool CanActivate(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x8DECCC", Offset = "0x8DECCC", VA = "0x8DECCC", Slot = "9")]
		public override void Activate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x8DED50", Offset = "0x8DED50", VA = "0x8DED50", Slot = "5")]
		public override void OnUpdate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x8DEDCC", Offset = "0x8DEDCC", VA = "0x8DEDCC", Slot = "11")]
		public override bool IsDone(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x8DEA20", Offset = "0x8DEA20", VA = "0x8DEA20")]
		private List<Vector3> GetRandomPositionsAroundTransform(Transform transform, int pointAmount, int maxRadius, float minDistance = 3f)
		{
			return null;
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x8DDB14", Offset = "0x8DDB14", VA = "0x8DDB14")]
		public void ChangePatrolPoint()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x8DDC24", Offset = "0x8DDC24", VA = "0x8DDC24")]
		public PointBasedAction()
		{
		}
	}
	[Token(Token = "0x2000224")]
	[CreateAssetMenu(fileName = "Runaway", menuName = "ScriptableObjects/Runaway", order = 1)]
	public class Runaway : Action
	{
		[Token(Token = "0x4000BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_MinFleeDistance;

		[Token(Token = "0x4000BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_MaxDuration;

		[Token(Token = "0x4000BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_TimeToStop;

		[Token(Token = "0x4000BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_FleePosition;

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x8DEDF4", Offset = "0x8DEDF4", VA = "0x8DEDF4", Slot = "4")]
		public override void OnStart(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x8DEEBC", Offset = "0x8DEEBC", VA = "0x8DEEBC", Slot = "7")]
		public override bool CanActivate(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x8DEFE4", Offset = "0x8DEFE4", VA = "0x8DEFE4", Slot = "9")]
		public override void Activate(AIBrain agent)
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x8DF008", Offset = "0x8DF008", VA = "0x8DF008", Slot = "5")]
		public override void OnUpdate(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x8DF260", Offset = "0x8DF260", VA = "0x8DF260", Slot = "8")]
		public override bool StillValid(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x8DF288", Offset = "0x8DF288", VA = "0x8DF288", Slot = "11")]
		public override bool IsDone(AIBrain brain)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x8DF2E8", Offset = "0x8DF2E8", VA = "0x8DF2E8")]
		public Runaway()
		{
		}
	}
	[Token(Token = "0x2000225")]
	[CreateAssetMenu(fileName = "AvoidPlayer", menuName = "ScriptableObjects/AvoidPlayer", order = 1)]
	public class AvoidPlayer : Goal
	{
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x8DF2F8", Offset = "0x8DF2F8", VA = "0x8DF2F8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x8DF384", Offset = "0x8DF384", VA = "0x8DF384", Slot = "6")]
		public override void RecalculatePriority(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x8DF3CC", Offset = "0x8DF3CC", VA = "0x8DF3CC")]
		public AvoidPlayer()
		{
		}
	}
	[Token(Token = "0x2000226")]
	[CreateAssetMenu(fileName = "AvoidTarget", menuName = "ScriptableObjects/AvoidTarget", order = 1)]
	public class AvoidTarget : Goal
	{
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x8DF438", Offset = "0x8DF438", VA = "0x8DF438", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x8DF4C4", Offset = "0x8DF4C4", VA = "0x8DF4C4", Slot = "6")]
		public override void RecalculatePriority(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x8DF50C", Offset = "0x8DF50C", VA = "0x8DF50C")]
		public AvoidTarget()
		{
		}
	}
	[Token(Token = "0x2000227")]
	[CreateAssetMenu(fileName = "DestroyTarget", menuName = "ScriptableObjects/DestroyTarget", order = 1)]
	public class DestroyTarget : Goal
	{
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x8DF510", Offset = "0x8DF510", VA = "0x8DF510", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x8DF5A0", Offset = "0x8DF5A0", VA = "0x8DF5A0", Slot = "6")]
		public override void RecalculatePriority(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x8DF5E8", Offset = "0x8DF5E8", VA = "0x8DF5E8")]
		public DestroyTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000228")]
	public class Goal : ScriptableObject, IComparable<Goal>
	{
		[Token(Token = "0x4000BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected float m_Priority;

		[Token(Token = "0x4000BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected Vector2 m_PriorityRange;

		[Token(Token = "0x4000BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private StateData m_GoalState;

		[Token(Token = "0x17000130")]
		public float Priority
		{
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x8DF5EC", Offset = "0x8DF5EC", VA = "0x8DF5EC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000131")]
		public StateData GoalState
		{
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x8DF5F4", Offset = "0x8DF5F4", VA = "0x8DF5F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x8DF5FC", Offset = "0x8DF5FC", VA = "0x8DF5FC", Slot = "5")]
		public virtual void OnStart()
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x8DF600", Offset = "0x8DF600", VA = "0x8DF600", Slot = "6")]
		public virtual void RecalculatePriority(AIBrain brain)
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x8DF604", Offset = "0x8DF604", VA = "0x8DF604", Slot = "4")]
		public int CompareTo(Goal goal)
		{
			return default(int);
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x8DF3D0", Offset = "0x8DF3D0", VA = "0x8DF3D0")]
		public Goal()
		{
		}
	}
	[Token(Token = "0x2000229")]
	[CreateAssetMenu(fileName = "KillPlayer", menuName = "ScriptableObjects/KillPlayer", order = 1)]
	public class KillPlayer : Goal
	{
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x8DF69C", Offset = "0x8DF69C", VA = "0x8DF69C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x8DF734", Offset = "0x8DF734", VA = "0x8DF734", Slot = "6")]
		public override void RecalculatePriority(AIBrain brain)
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x8DF77C", Offset = "0x8DF77C", VA = "0x8DF77C")]
		public KillPlayer()
		{
		}
	}
	[Token(Token = "0x200022A")]
	[CreateAssetMenu(fileName = "SatisfyHealthy", menuName = "ScriptableObjects/SatisfyHealthy", order = 1)]
	public class SatisfyHealthy : Goal
	{
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x8DF780", Offset = "0x8DF780", VA = "0x8DF780", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x8DF810", Offset = "0x8DF810", VA = "0x8DF810", Slot = "6")]
		public override void RecalculatePriority(AIBrain brain)
		{
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x8DF850", Offset = "0x8DF850", VA = "0x8DF850")]
		public SatisfyHealthy()
		{
		}
	}
	[Token(Token = "0x200022B")]
	[CreateAssetMenu(fileName = "SatisfyHunger", menuName = "ScriptableObjects/SatisfyHunger", order = 1)]
	public class SatisfyHunger : Goal
	{
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x8DF854", Offset = "0x8DF854", VA = "0x8DF854", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x8DF8E0", Offset = "0x8DF8E0", VA = "0x8DF8E0", Slot = "6")]
		public override void RecalculatePriority(AIBrain brain)
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x8DF920", Offset = "0x8DF920", VA = "0x8DF920")]
		public SatisfyHunger()
		{
		}
	}
	[Token(Token = "0x200022C")]
	[CreateAssetMenu(fileName = "SatisfyThirsty", menuName = "ScriptableObjects/SatisfyThirsty", order = 1)]
	public class SatisfyThirsty : Goal
	{
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x8DF924", Offset = "0x8DF924", VA = "0x8DF924", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x8DF9B0", Offset = "0x8DF9B0", VA = "0x8DF9B0", Slot = "6")]
		public override void RecalculatePriority(AIBrain brain)
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x8DF9F0", Offset = "0x8DF9F0", VA = "0x8DF9F0")]
		public SatisfyThirsty()
		{
		}
	}
}
