using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using BestHTTP;
using BestHTTP.Cookies;
using CurvedUI;
using DG.Tweening;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Oculus.Interaction;
using Oculus.Interaction.Input;
using Oculus.Interaction.UnityCanvas;
using RenderHeads.Media.AVProVideo;
using RenderHeads.Media.AVProVideo.Demos.UI;
using TMPro;
using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAA84", Offset = "0x8FAA84")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x136048C", Offset = "0x136048C", VA = "0x136048C")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAABC", Offset = "0x8FAABC")]
	internal sealed class IsReadOnlyAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x13658BC", Offset = "0x13658BC", VA = "0x13658BC")]
		public IsReadOnlyAttribute()
		{
		}
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8FAAF4", Offset = "0x8FAAF4")]
[ExecuteInEditMode]
[ImageEffectAllowedInSceneView]
public class Pixelize : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Shader _screenAndMaskShader;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material _screenAndMaskMaterial;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RenderTexture _temporaryRenderTexture;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Shader _combineLayersShader;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material _combineLayersMaterial;

	[Token(Token = "0x17000001")]
	private Shader ScreenAndMaskShader
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x136A37C", Offset = "0x136A37C", VA = "0x136A37C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	private Material ScreenAndMaskMaterial
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x136A41C", Offset = "0x136A41C", VA = "0x136A41C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	private RenderTexture TemporaryRenderTarget
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x136A4E4", Offset = "0x136A4E4", VA = "0x136A4E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	private Shader CombineLayersShader
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x136A658", Offset = "0x136A658", VA = "0x136A658")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	private Material CombineLayersMaterial
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x136A6F8", Offset = "0x136A6F8", VA = "0x136A6F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x136A7C0", Offset = "0x136A7C0", VA = "0x136A7C0")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x136A564", Offset = "0x136A564", VA = "0x136A564")]
	private void CreateTemporaryRenderTarget()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x136A890", Offset = "0x136A890", VA = "0x136A890")]
	private void CheckTemporaryRenderTarget()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x136A914", Offset = "0x136A914", VA = "0x136A914")]
	private void ReleaseTemporaryRenderTarget()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x136A948", Offset = "0x136A948", VA = "0x136A948")]
	public Pixelize()
	{
	}
}
[Token(Token = "0x2000005")]
[ExecuteInEditMode]
public class VolumetricSphere : MonoBehaviour
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FB1FC", Offset = "0x8FB1FC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FB1FC", Offset = "0x8FB1FC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8FB1FC", Offset = "0x8FB1FC")]
	public float radius;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FB278", Offset = "0x8FB278")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8FB278", Offset = "0x8FB278")]
	public float density;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FB2CC", Offset = "0x8FB2CC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8FB2CC", Offset = "0x8FB2CC")]
	public float exponent;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8FB324", Offset = "0x8FB324")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FB324", Offset = "0x8FB324")]
	public int maxPixelizationLevel;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FB378", Offset = "0x8FB378")]
	public bool enableLayersInterpolation;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FB3B0", Offset = "0x8FB3B0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FB3B0", Offset = "0x8FB3B0")]
	public bool debugSphere;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x146B9C0", Offset = "0x146B9C0", VA = "0x146B9C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x146BB24", Offset = "0x146BB24", VA = "0x146BB24")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x146BB74", Offset = "0x146BB74", VA = "0x146BB74")]
	public VolumetricSphere()
	{
	}
}
[Token(Token = "0x2000006")]
[ExecuteInEditMode]
public class PlaneClip : MonoBehaviour
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material PlaneClipMat;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform m_transform;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int m_planePropertyId;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x136A950", Offset = "0x136A950", VA = "0x136A950")]
	private void Start()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x136A9B4", Offset = "0x136A9B4", VA = "0x136A9B4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x136AAB0", Offset = "0x136AAB0", VA = "0x136AAB0")]
	public PlaneClip()
	{
	}
}
[Token(Token = "0x2000007")]
public class SimpleGPUInstancingExample : MonoBehaviour
{
	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform Prefab;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material InstancedMaterial;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x150DF68", Offset = "0x150DF68", VA = "0x150DF68")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x150E1C0", Offset = "0x150E1C0", VA = "0x150E1C0")]
	public SimpleGPUInstancingExample()
	{
	}
}
[Token(Token = "0x2000008")]
public class SimpleMoveExample : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 m_previous;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 m_target;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 m_originalPosition;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 BoundingVolume;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float Speed;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x150E1C8", Offset = "0x150E1C8", VA = "0x150E1C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x150E244", Offset = "0x150E244", VA = "0x150E244")]
	private void Update()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x150E410", Offset = "0x150E410", VA = "0x150E410")]
	public SimpleMoveExample()
	{
	}
}
[Token(Token = "0x2000009")]
public class Smear : MonoBehaviour
{
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Queue<Vector3> m_recentPositions;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int FramesBufferSize;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer Renderer;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material m_instancedMaterial;

	[Token(Token = "0x17000006")]
	private Material InstancedMaterial
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x150E934", Offset = "0x150E934", VA = "0x150E934")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x150E93C", Offset = "0x150E93C", VA = "0x150E93C")]
		set
		{
		}
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x150E944", Offset = "0x150E944", VA = "0x150E944")]
	private void Start()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x150E978", Offset = "0x150E978", VA = "0x150E978")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x150EAA8", Offset = "0x150EAA8", VA = "0x150EAA8")]
	public Smear()
	{
	}
}
[Token(Token = "0x200000A")]
[ExecuteInEditMode]
public class PostProcessExample : MonoBehaviour
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material PostProcessMat;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x136C55C", Offset = "0x136C55C", VA = "0x136C55C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x136C60C", Offset = "0x136C60C", VA = "0x136C60C")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x136C68C", Offset = "0x136C68C", VA = "0x136C68C")]
	public PostProcessExample()
	{
	}
}
[Token(Token = "0x200000B")]
[ExecuteInEditMode]
public class SpriteMaskController : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SpriteRenderer m_spriteRenderer;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector4 m_uvs;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x150F650", Offset = "0x150F650", VA = "0x150F650")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x150F6FC", Offset = "0x150F6FC", VA = "0x150F6FC")]
	public SpriteMaskController()
	{
	}
}
[Token(Token = "0x200000C")]
public class CUI_MoveAlong : MonoBehaviour
{
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1551D64", Offset = "0x1551D64", VA = "0x1551D64")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1551D68", Offset = "0x1551D68", VA = "0x1551D68")]
	private void Update()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1551F90", Offset = "0x1551F90", VA = "0x1551F90")]
	public CUI_MoveAlong()
	{
	}
}
[Token(Token = "0x200000D")]
public class CUI_MoveHeartbeat : MonoBehaviour
{
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool wrapAroundParent;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform rectie;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform parentRectie;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1551F98", Offset = "0x1551F98", VA = "0x1551F98")]
	private void Start()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x155204C", Offset = "0x155204C", VA = "0x155204C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1552170", Offset = "0x1552170", VA = "0x1552170")]
	public CUI_MoveHeartbeat()
	{
	}
}
[Token(Token = "0x200000E")]
public class CUI_ShowParentCoordinates : MonoBehaviour
{
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1552A98", Offset = "0x1552A98", VA = "0x1552A98")]
	private void Start()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1552B6C", Offset = "0x1552B6C", VA = "0x1552B6C")]
	private void Update()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1552B70", Offset = "0x1552B70", VA = "0x1552B70")]
	public CUI_ShowParentCoordinates()
	{
	}
}
[Token(Token = "0x200000F")]
public class CUI_rotation_anim : MonoBehaviour
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 Rotation;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1553938", Offset = "0x1553938", VA = "0x1553938")]
	private void Start()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x155393C", Offset = "0x155393C", VA = "0x155393C")]
	private void Update()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1553B24", Offset = "0x1553B24", VA = "0x1553B24")]
	public CUI_rotation_anim()
	{
	}
}
[Token(Token = "0x2000010")]
public class CUI_touchpad : MonoBehaviour
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform container;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform dot;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1553B2C", Offset = "0x1553B2C", VA = "0x1553B2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1553B9C", Offset = "0x1553B9C", VA = "0x1553B9C")]
	private void MoveDotOnTouchpadAxisChanged(object o, ViveInputArgs args)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1553C5C", Offset = "0x1553C5C", VA = "0x1553C5C")]
	public CUI_touchpad()
	{
	}
}
[Token(Token = "0x2000011")]
[ExecuteInEditMode]
public class CurvedUIInputModule : BaseInputModule
{
	[Token(Token = "0x2000012")]
	public enum CUIControlMethod
	{
		[Token(Token = "0x4000043")]
		MOUSE = 0,
		[Token(Token = "0x4000044")]
		GAZE = 1,
		[Token(Token = "0x4000045")]
		WORLD_MOUSE = 2,
		[Token(Token = "0x4000046")]
		CUSTOM_RAY = 3,
		[Token(Token = "0x4000047")]
		STEAMVR_LEGACY = 4,
		[Token(Token = "0x4000048")]
		OCULUSVR = 5,
		[Token(Token = "0x4000049")]
		STEAMVR_2 = 8,
		[Token(Token = "0x400004A")]
		UNITY_XR = 9
	}

	[Token(Token = "0x2000013")]
	public enum Hand
	{
		[Token(Token = "0x400004C")]
		Both,
		[Token(Token = "0x400004D")]
		Right,
		[Token(Token = "0x400004E")]
		Left
	}

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private CUIControlMethod controlMethod;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string submitButtonName;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Camera mainEventCamera;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private LayerMask raycastLayerMask;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private bool gazeUseTimedClick;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float gazeClickTimer;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float gazeClickTimerDelay;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image gazeTimedClickProgressImage;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float worldSpaceMouseSensitivity;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private Hand usedHand;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Transform pointerTransformOverride;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool disableOtherInputModulesOnStart;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static CurvedUIInputModule instance;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject currentDragging;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject currentPointedAt;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject m_rightController;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GameObject m_leftController;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float gazeTimerProgress;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private Ray customControllerRay;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float dragThreshold;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool pressedDown;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	private bool pressedLastFrame;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Vector2 lastEventDataPosition;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private PointerInputModule.MouseButtonEventData storedData;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Vector3 lastMouseOnScreenPos;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private Vector2 worldSpaceMouseInCanvasSpace;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private Vector2 lastWorldSpaceMouseOnCanvas;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private Vector2 worldSpaceMouseOnCanvasDelta;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private XRBaseController rightXRController;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[SerializeField]
	private XRBaseController leftXRController;

	[Token(Token = "0x17000007")]
	public static CurvedUIInputModule Instance
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1552DA0", Offset = "0x1552DA0", VA = "0x1552DA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1558600", Offset = "0x1558600", VA = "0x1558600")]
		private set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public static bool CanInstanceBeAccessed
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1558668", Offset = "0x1558668", VA = "0x1558668")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	public static CUIControlMethod ControlMethod
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1551460", Offset = "0x1551460", VA = "0x1551460")]
		get
		{
			return default(CUIControlMethod);
		}
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1558704", Offset = "0x1558704", VA = "0x1558704")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public LayerMask RaycastLayerMask
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x155879C", Offset = "0x155879C", VA = "0x155879C")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x15587A4", Offset = "0x15587A4", VA = "0x15587A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public Hand UsedHand
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x15587AC", Offset = "0x15587AC", VA = "0x15587AC")]
		get
		{
			return default(Hand);
		}
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x15587B4", Offset = "0x15587B4", VA = "0x15587B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public Transform ControllerTransform
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1555AF4", Offset = "0x1555AF4", VA = "0x1555AF4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000D")]
	public Vector3 ControllerPointingDirection
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1555C14", Offset = "0x1555C14", VA = "0x1555C14")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700000E")]
	public Vector3 ControllerPointingOrigin
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x155882C", Offset = "0x155882C", VA = "0x155882C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700000F")]
	public Transform PointerTransformOverride
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x15587BC", Offset = "0x15587BC", VA = "0x15587BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1555BA0", Offset = "0x1555BA0", VA = "0x1555BA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public GameObject CurrentPointedAt
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x155884C", Offset = "0x155884C", VA = "0x155884C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000011")]
	public Camera EventCamera
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1558854", Offset = "0x1558854", VA = "0x1558854")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1556844", Offset = "0x1556844", VA = "0x1556844")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public static Vector2 MousePosition
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x15508B4", Offset = "0x15508B4", VA = "0x15508B4")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000013")]
	public static bool LeftMouseButton
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1551C80", Offset = "0x1551C80", VA = "0x1551C80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public static Ray CustomControllerRay
	{
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1558AD8", Offset = "0x1558AD8", VA = "0x1558AD8")]
		get
		{
			return default(Ray);
		}
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x155198C", Offset = "0x155198C", VA = "0x155198C")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public static bool CustomControllerButtonState
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1558B50", Offset = "0x1558B50", VA = "0x1558B50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1551CE0", Offset = "0x1551CE0", VA = "0x1551CE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8FFE5C", Offset = "0x8FFE5C")]
	public static bool CustomControllerButtonDown
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1558BB8", Offset = "0x1558BB8", VA = "0x1558BB8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1558C10", Offset = "0x1558C10", VA = "0x1558C10")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public Vector2 WorldSpaceMouseInCanvasSpace
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1558C70", Offset = "0x1558C70", VA = "0x1558C70")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1552EB0", Offset = "0x1552EB0", VA = "0x1552EB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public Vector2 WorldSpaceMouseInCanvasSpaceDelta
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1558C78", Offset = "0x1558C78", VA = "0x1558C78")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000019")]
	public float WorldSpaceMouseSensitivity
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1558C8C", Offset = "0x1558C8C", VA = "0x1558C8C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1558C94", Offset = "0x1558C94", VA = "0x1558C94")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public bool GazeUseTimedClick
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1558C9C", Offset = "0x1558C9C", VA = "0x1558C9C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1558CA4", Offset = "0x1558CA4", VA = "0x1558CA4")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public float GazeClickTimer
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1558CB0", Offset = "0x1558CB0", VA = "0x1558CB0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1558CB8", Offset = "0x1558CB8", VA = "0x1558CB8")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public float GazeClickTimerDelay
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1558CE4", Offset = "0x1558CE4", VA = "0x1558CE4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1558CEC", Offset = "0x1558CEC", VA = "0x1558CEC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public float GazeTimerProgress
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1558D18", Offset = "0x1558D18", VA = "0x1558D18")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700001E")]
	public Image GazeTimedClickProgressImage
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1558D20", Offset = "0x1558D20", VA = "0x1558D20")]
		get
		{
			return null;
		}
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1558D28", Offset = "0x1558D28", VA = "0x1558D28")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public XRBaseController RightXRController
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1558D30", Offset = "0x1558D30", VA = "0x1558D30")]
		get
		{
			return null;
		}
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1558D38", Offset = "0x1558D38", VA = "0x1558D38")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public XRBaseController LeftXRController
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1558D40", Offset = "0x1558D40", VA = "0x1558D40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1558D48", Offset = "0x1558D48", VA = "0x1558D48")]
		set
		{
		}
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x15566A4", Offset = "0x15566A4", VA = "0x15566A4", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1556AB4", Offset = "0x1556AB4", VA = "0x1556AB4", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1556AF0", Offset = "0x1556AF0", VA = "0x1556AF0", Slot = "26")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x15568F0", Offset = "0x15568F0", VA = "0x15568F0")]
	private void SetupUnityXrControllers()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1556D28", Offset = "0x1556D28", VA = "0x1556D28", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1556EAC", Offset = "0x1556EAC", VA = "0x1556EAC")]
	public PointerInputModule.MouseButtonEventData GetEventData()
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1557134", Offset = "0x1557134", VA = "0x1557134")]
	private void ProcessMove(PointerEventData eventData, GameObject currentRaycastTarget)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1557754", Offset = "0x1557754", VA = "0x1557754")]
	private void ProcessButton(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1557E4C", Offset = "0x1557E4C", VA = "0x1557E4C")]
	private void ProcessDrag(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x155814C", Offset = "0x155814C", VA = "0x155814C")]
	private static void ProcessScroll(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1558278", Offset = "0x1558278", VA = "0x1558278")]
	private void ProcessUnityXrController()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x15583E4", Offset = "0x15583E4", VA = "0x15583E4", Slot = "27")]
	protected virtual void ProcessMouseController()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1558530", Offset = "0x1558530", VA = "0x1558530", Slot = "28")]
	protected virtual void ProcessCustomRayController()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1558534", Offset = "0x1558534", VA = "0x1558534", Slot = "29")]
	protected virtual void ProcessGaze()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1555924", Offset = "0x1555924", VA = "0x1555924")]
	public void GetXrControllerButtonState(ref bool pressed, Hand checkHand)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x15583B8", Offset = "0x15583B8", VA = "0x15583B8")]
	private PointerEventData.FramePressState CustomRayFramePressedState()
	{
		return default(PointerEventData.FramePressState);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x15585F4", Offset = "0x15585F4", VA = "0x15585F4", Slot = "30")]
	protected virtual void ProcessViveControllers()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x15585F8", Offset = "0x15585F8", VA = "0x15585F8", Slot = "31")]
	protected virtual void ProcessOculusVRController()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x15585FC", Offset = "0x15585FC", VA = "0x15585FC")]
	private void ProcessSteamVR2Controllers()
	{
	}

	[Token(Token = "0x6000044")]
	private static T EnableInputModule<T>() where T : BaseInputModule
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x155885C", Offset = "0x155885C", VA = "0x155885C")]
	public Ray GetEventRay([System.Runtime.InteropServices.Optional] Camera eventCam)
	{
		return default(Ray);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1558D50", Offset = "0x1558D50", VA = "0x1558D50")]
	public CurvedUIInputModule()
	{
	}
}
[Token(Token = "0x2000014")]
public class ColorLoopAnimation : MonoBehaviour
{
	[Token(Token = "0x2000015")]
	protected enum State
	{
		[Token(Token = "0x4000058")]
		IDLE,
		[Token(Token = "0x4000059")]
		FADE
	}

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float FadeTime;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float IdleTime;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color[] colors;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer render;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private State state;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float stateStartTime;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float stateEndTime;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int colorIndex;

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1554E98", Offset = "0x1554E98", VA = "0x1554E98")]
	private void Start()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x15550AC", Offset = "0x15550AC", VA = "0x15550AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1554F14", Offset = "0x1554F14", VA = "0x1554F14")]
	private void ChangeColor(float dstPercent)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x15550E4", Offset = "0x15550E4", VA = "0x15550E4")]
	private void OnIdleUpdate()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x15551D8", Offset = "0x15551D8", VA = "0x15551D8")]
	private int GetNextColorIdx()
	{
		return default(int);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1555130", Offset = "0x1555130", VA = "0x1555130")]
	private void OnFadeUpdate()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1555204", Offset = "0x1555204", VA = "0x1555204")]
	public ColorLoopAnimation()
	{
	}
}
[Token(Token = "0x2000016")]
public class TexLoopAnimation : MonoBehaviour
{
	[Token(Token = "0x2000017")]
	protected enum State
	{
		[Token(Token = "0x4000063")]
		IDLE,
		[Token(Token = "0x4000064")]
		FADE
	}

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float FadeTime;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float IdleTime;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture[] textures;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer render;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private State state;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float stateStartTime;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float stateEndTime;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int currentTexIndex;

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x151B40C", Offset = "0x151B40C", VA = "0x151B40C")]
	private void Start()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x151B740", Offset = "0x151B740", VA = "0x151B740")]
	private void Update()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x151B48C", Offset = "0x151B48C", VA = "0x151B48C")]
	private void ChangeTexture()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x151B628", Offset = "0x151B628", VA = "0x151B628")]
	private void ChangeTextureLerp(float t)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x151B778", Offset = "0x151B778", VA = "0x151B778")]
	private void OnIdleUpdate()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x151B874", Offset = "0x151B874", VA = "0x151B874")]
	private int GetNextTextureIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x151B7C4", Offset = "0x151B7C4", VA = "0x151B7C4")]
	private void OnFadeUpdate()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x151B8A0", Offset = "0x151B8A0", VA = "0x151B8A0")]
	public TexLoopAnimation()
	{
	}
}
[Token(Token = "0x2000018")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8FABC4", Offset = "0x8FABC4")]
public class EnableCameraDepthInForward : MonoBehaviour
{
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1360494", Offset = "0x1360494", VA = "0x1360494")]
	private void Start()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1360498", Offset = "0x1360498", VA = "0x1360498")]
	private void Set()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1360520", Offset = "0x1360520", VA = "0x1360520")]
	public EnableCameraDepthInForward()
	{
	}
}
[Token(Token = "0x2000019")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8FAC24", Offset = "0x8FAC24")]
public class SoftNormalsToVertexColor : MonoBehaviour
{
	[Token(Token = "0x200001A")]
	public enum Method
	{
		[Token(Token = "0x4000069")]
		Simple,
		[Token(Token = "0x400006A")]
		AngularDeviation
	}

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Method method;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool generateOnAwake;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool generateNow;

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x150EB20", Offset = "0x150EB20", VA = "0x150EB20")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x150ED44", Offset = "0x150ED44", VA = "0x150ED44")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x150EB34", Offset = "0x150EB34", VA = "0x150EB34")]
	private void TryGenerate()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x150ED54", Offset = "0x150ED54", VA = "0x150ED54")]
	private void Generate(Mesh m)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x150F640", Offset = "0x150F640", VA = "0x150F640")]
	public SoftNormalsToVertexColor()
	{
	}
}
[Token(Token = "0x200001B")]
public class TDDemoScript : MonoBehaviour
{
	[Token(Token = "0x400006B")]
	private const int top = 100;

	[Token(Token = "0x400006C")]
	private const int left = 80;

	[Token(Token = "0x400006D")]
	private const int height = 60;

	[Token(Token = "0x400006E")]
	private const int spacing = 20;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly int width;

	[Token(Token = "0x4000070")]
	private const int step = 80;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string tdid;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string oaid;

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x150F70C", Offset = "0x150F70C", VA = "0x150F70C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1514750", Offset = "0x1514750", VA = "0x1514750")]
	private void Start()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1514CC0", Offset = "0x1514CC0", VA = "0x1514CC0")]
	private void Update()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1514CEC", Offset = "0x1514CEC", VA = "0x1514CEC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1514EE4", Offset = "0x1514EE4", VA = "0x1514EE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1514F58", Offset = "0x1514F58", VA = "0x1514F58")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1514FCC", Offset = "0x1514FCC", VA = "0x1514FCC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1515040", Offset = "0x1515040", VA = "0x1515040")]
	public TDDemoScript()
	{
	}
}
[Token(Token = "0x200001C")]
public enum TalkingDataProfileType
{
	[Token(Token = "0x4000074")]
	ANONYMOUS = 0,
	[Token(Token = "0x4000075")]
	REGISTERED = 1,
	[Token(Token = "0x4000076")]
	SINA_WEIBO = 2,
	[Token(Token = "0x4000077")]
	QQ = 3,
	[Token(Token = "0x4000078")]
	QQ_WEIBO = 4,
	[Token(Token = "0x4000079")]
	ND91 = 5,
	[Token(Token = "0x400007A")]
	WEIXIN = 6,
	[Token(Token = "0x400007B")]
	TYPE1 = 11,
	[Token(Token = "0x400007C")]
	TYPE2 = 12,
	[Token(Token = "0x400007D")]
	TYPE3 = 13,
	[Token(Token = "0x400007E")]
	TYPE4 = 14,
	[Token(Token = "0x400007F")]
	TYPE5 = 15,
	[Token(Token = "0x4000080")]
	TYPE6 = 16,
	[Token(Token = "0x4000081")]
	TYPE7 = 17,
	[Token(Token = "0x4000082")]
	TYPE8 = 18,
	[Token(Token = "0x4000083")]
	TYPE9 = 19,
	[Token(Token = "0x4000084")]
	TYPE10 = 20
}
[Token(Token = "0x200001D")]
public enum TalkingDataGender
{
	[Token(Token = "0x4000086")]
	UNKNOWN,
	[Token(Token = "0x4000087")]
	MALE,
	[Token(Token = "0x4000088")]
	FEMALE
}
[Token(Token = "0x200001E")]
public class TalkingDataProfile
{
	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AndroidJavaObject javaObj;

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1511364", Offset = "0x1511364", VA = "0x1511364")]
	public static TalkingDataProfile CreateProfile()
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x151150C", Offset = "0x151150C", VA = "0x151150C")]
	public TalkingDataProfile SetName(string name)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1511614", Offset = "0x1511614", VA = "0x1511614")]
	public TalkingDataProfile SetType(TalkingDataProfileType type)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1511840", Offset = "0x1511840", VA = "0x1511840")]
	public TalkingDataProfile SetGender(TalkingDataGender gender)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1511A6C", Offset = "0x1511A6C", VA = "0x1511A6C")]
	public TalkingDataProfile SetAge(int age)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1511BA4", Offset = "0x1511BA4", VA = "0x1511BA4")]
	public TalkingDataProfile SetProperty1(object property)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1511CC4", Offset = "0x1511CC4", VA = "0x1511CC4")]
	public TalkingDataProfile SetProperty2(object property)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1511DE4", Offset = "0x1511DE4", VA = "0x1511DE4")]
	public TalkingDataProfile SetProperty3(object property)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1511F04", Offset = "0x1511F04", VA = "0x1511F04")]
	public TalkingDataProfile SetProperty4(object property)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1512024", Offset = "0x1512024", VA = "0x1512024")]
	public TalkingDataProfile SetProperty5(object property)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1512144", Offset = "0x1512144", VA = "0x1512144")]
	public TalkingDataProfile SetProperty6(object property)
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1512264", Offset = "0x1512264", VA = "0x1512264")]
	public TalkingDataProfile SetProperty7(object property)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1512384", Offset = "0x1512384", VA = "0x1512384")]
	public TalkingDataProfile SetProperty8(object property)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x15124A4", Offset = "0x15124A4", VA = "0x15124A4")]
	public TalkingDataProfile SetProperty9(object property)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x15125C4", Offset = "0x15125C4", VA = "0x15125C4")]
	public TalkingDataProfile SetProperty10(object property)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x151A4A0", Offset = "0x151A4A0", VA = "0x151A4A0")]
	private AndroidJavaObject AndroidJavaObjectFromObject(object parameter)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x151A498", Offset = "0x151A498", VA = "0x151A498")]
	public TalkingDataProfile()
	{
	}
}
[Token(Token = "0x200001F")]
public static class TalkingDataSDK
{
	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string TALKINGDATA_CLASS;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static AndroidJavaClass talkingdataClass;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static AndroidJavaClass unityPlayerClass;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static string deviceId;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string oaid;

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x151A944", Offset = "0x151A944", VA = "0x151A944")]
	private static AndroidJavaObject GetCurrentActivity()
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1514878", Offset = "0x1514878", VA = "0x1514878")]
	public static void Init(string appId, string channelId, string custom)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x151AA68", Offset = "0x151AA68", VA = "0x151AA68")]
	public static void OnResume()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1514D90", Offset = "0x1514D90", VA = "0x1514D90")]
	public static void OnPause()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1514850", Offset = "0x1514850", VA = "0x1514850")]
	public static void BackgroundSessionEnabled()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1510AF4", Offset = "0x1510AF4", VA = "0x1510AF4")]
	public static string GetDeviceId()
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1510D04", Offset = "0x1510D04", VA = "0x1510D04")]
	public static string GetOAID()
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x151ABBC", Offset = "0x151ABBC", VA = "0x151ABBC")]
	public static void SetVerboseLogDisable()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x151AD90", Offset = "0x151AD90", VA = "0x151AD90")]
	public static void SetLocation(double latitude, double longitude)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1510F14", Offset = "0x1510F14", VA = "0x1510F14")]
	public static void OnPageBegin(string pageName)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1511094", Offset = "0x1511094", VA = "0x1511094")]
	public static void OnPageEnd(string pageName)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1511214", Offset = "0x1511214", VA = "0x1511214")]
	public static void OnReceiveDeepLink(string url)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x15126E4", Offset = "0x15126E4", VA = "0x15126E4")]
	public static void OnRegister(string profileId, TalkingDataProfile profile, string invitationCode)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x15128A0", Offset = "0x15128A0", VA = "0x15128A0")]
	public static void OnLogin(string profileId, TalkingDataProfile profile)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1512A24", Offset = "0x1512A24", VA = "0x1512A24")]
	public static void OnProfileUpdate(TalkingDataProfile profile)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1512B7C", Offset = "0x1512B7C", VA = "0x1512B7C")]
	public static void OnCreateCard(string profileId, string method, string content)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1512D30", Offset = "0x1512D30", VA = "0x1512D30")]
	public static void OnFavorite(string category, string content)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1512EAC", Offset = "0x1512EAC", VA = "0x1512EAC")]
	public static void OnShare(string profileId, string content)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1513028", Offset = "0x1513028", VA = "0x1513028")]
	public static void OnPunch(string profileId, string punchId)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x151355C", Offset = "0x151355C", VA = "0x151355C")]
	public static void OnSearch(TalkingDataSearch search)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x15136B4", Offset = "0x15136B4", VA = "0x15136B4")]
	public static void OnPay(string profileId, string orderId, int amount, string currencyType, string paymentType, string itemId, int itemCount)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1513954", Offset = "0x1513954", VA = "0x1513954")]
	public static void OnCreateRole(string name)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1513AA4", Offset = "0x1513AA4", VA = "0x1513AA4")]
	public static void OnLevelPass(string profileId, string levelId)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1513C20", Offset = "0x1513C20", VA = "0x1513C20")]
	public static void OnGuideFinished(string profileId, string content)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1513D9C", Offset = "0x1513D9C", VA = "0x1513D9C")]
	public static void OnAchievementUnlock(string profileId, string achievementId)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1513F18", Offset = "0x1513F18", VA = "0x1513F18")]
	public static void OnEvent(string eventId, Dictionary<string, object> parameters)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x151ADB8", Offset = "0x151ADB8", VA = "0x151ADB8")]
	public static void SetGlobalKV(string key, object val)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x151B0CC", Offset = "0x151B0CC", VA = "0x151B0CC")]
	public static void RemoveGlobalKV(string key)
	{
	}
}
[Token(Token = "0x2000020")]
public class TalkingDataSearch
{
	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AndroidJavaObject javaObj;

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x15131A4", Offset = "0x15131A4", VA = "0x15131A4")]
	public static TalkingDataSearch CreateSearch()
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x151334C", Offset = "0x151334C", VA = "0x151334C")]
	public TalkingDataSearch SetCategory(string category)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1513454", Offset = "0x1513454", VA = "0x1513454")]
	public TalkingDataSearch SetContent(string content)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x151B294", Offset = "0x151B294", VA = "0x151B294")]
	public TalkingDataSearch()
	{
	}
}
[Token(Token = "0x2000021")]
public class ChatController : MonoBehaviour
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_InputField ChatInputField;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text ChatDisplayOutput;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Scrollbar ChatScrollbar;

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x15548DC", Offset = "0x15548DC", VA = "0x15548DC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x15549A0", Offset = "0x15549A0", VA = "0x15549A0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1554A64", Offset = "0x1554A64", VA = "0x1554A64")]
	private void AddToChatOutput(string newText)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1554E90", Offset = "0x1554E90", VA = "0x1554E90")]
	public ChatController()
	{
	}
}
[Token(Token = "0x2000022")]
public class DropdownSample : MonoBehaviour
{
	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI text;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TMP_Dropdown dropdownWithoutPlaceholder;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Dropdown dropdownWithPlaceholder;

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1360378", Offset = "0x1360378", VA = "0x1360378")]
	public void OnButtonClick()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1360484", Offset = "0x1360484", VA = "0x1360484")]
	public DropdownSample()
	{
	}
}
[Token(Token = "0x2000023")]
public class EnvMapAnimator : MonoBehaviour
{
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAC84", Offset = "0x8FAC84")]
	private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnvMapAnimator <>4__this;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Matrix4x4 <matrix>5__2;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1A92FD4", Offset = "0x1A92FD4", VA = "0x1A92FD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x1A9301C", Offset = "0x1A9301C", VA = "0x1A9301C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1A92DF8", Offset = "0x1A92DF8", VA = "0x1A92DF8")]
		[DebuggerHidden]
		public <Start>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1A92E24", Offset = "0x1A92E24", VA = "0x1A92E24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1A92E28", Offset = "0x1A92E28", VA = "0x1A92E28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1A92FDC", Offset = "0x1A92FDC", VA = "0x1A92FDC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 RotationSpeeds;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TMP_Text m_textMeshPro;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material m_material;

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1360528", Offset = "0x1360528", VA = "0x1360528")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1360598", Offset = "0x1360598", VA = "0x1360598")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FE45C", Offset = "0x8FE45C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1360604", Offset = "0x1360604", VA = "0x1360604")]
	public EnvMapAnimator()
	{
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000025")]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1515084", Offset = "0x1515084", VA = "0x1515084", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x15150FC", Offset = "0x15150FC", VA = "0x15150FC")]
		public TMP_DigitValidator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class TMP_PhoneNumberValidator : TMP_InputValidator
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1515968", Offset = "0x1515968", VA = "0x1515968", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1515D70", Offset = "0x1515D70", VA = "0x1515D70")]
		public TMP_PhoneNumberValidator()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Serializable]
		[Token(Token = "0x2000028")]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1A96498", Offset = "0x1A96498", VA = "0x1A96498")]
			public CharacterSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000029")]
		public class SpriteSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x1A9657C", Offset = "0x1A9657C", VA = "0x1A9657C")]
			public SpriteSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200002A")]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x1A965C8", Offset = "0x1A965C8", VA = "0x1A965C8")]
			public WordSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200002B")]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x1A964E4", Offset = "0x1A964E4", VA = "0x1A964E4")]
			public LineSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200002C")]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1A96530", Offset = "0x1A96530", VA = "0x1A96530")]
			public LinkSelectionEvent()
			{
			}
		}

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterSelectionEvent m_OnCharacterSelection;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpriteSelectionEvent m_OnSpriteSelection;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WordSelectionEvent m_OnWordSelection;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LineSelectionEvent m_OnLineSelection;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LinkSelectionEvent m_OnLinkSelection;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Camera;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas m_Canvas;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_selectedLink;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_lastCharIndex;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_lastWordIndex;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_lastLineIndex;

		[Token(Token = "0x17000023")]
		public CharacterSelectionEvent onCharacterSelection
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x1516ECC", Offset = "0x1516ECC", VA = "0x1516ECC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x1516ED4", Offset = "0x1516ED4", VA = "0x1516ED4")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public SpriteSelectionEvent onSpriteSelection
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x1516EDC", Offset = "0x1516EDC", VA = "0x1516EDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x1516EE4", Offset = "0x1516EE4", VA = "0x1516EE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public WordSelectionEvent onWordSelection
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x1516EEC", Offset = "0x1516EEC", VA = "0x1516EEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x1516EF4", Offset = "0x1516EF4", VA = "0x1516EF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public LineSelectionEvent onLineSelection
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x1516EFC", Offset = "0x1516EFC", VA = "0x1516EFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x1516F04", Offset = "0x1516F04", VA = "0x1516F04")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public LinkSelectionEvent onLinkSelection
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x1516F0C", Offset = "0x1516F0C", VA = "0x1516F0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x1516F14", Offset = "0x1516F14", VA = "0x1516F14")]
			set
			{
			}
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1516F1C", Offset = "0x1516F1C", VA = "0x1516F1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x15170B0", Offset = "0x15170B0", VA = "0x15170B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x15177FC", Offset = "0x15177FC", VA = "0x15177FC", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1517800", Offset = "0x1517800", VA = "0x1517800", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1517568", Offset = "0x1517568", VA = "0x1517568")]
		private void SendOnCharacterSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x15175E0", Offset = "0x15175E0", VA = "0x15175E0")]
		private void SendOnSpriteSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1517658", Offset = "0x1517658", VA = "0x1517658")]
		private void SendOnWordSelection(string word, int charIndex, int length)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x15176E4", Offset = "0x15176E4", VA = "0x15176E4")]
		private void SendOnLineSelection(string line, int charIndex, int length)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1517770", Offset = "0x1517770", VA = "0x1517770")]
		private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1517804", Offset = "0x1517804", VA = "0x1517804")]
		public TMP_TextEventHandler()
		{
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x200002D")]
	public class Benchmark01 : MonoBehaviour
	{
		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAC94", Offset = "0x8FAC94")]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01 <>4__this;

			[Token(Token = "0x40000B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x17000028")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000F5")]
				[Address(RVA = "0x1A9210C", Offset = "0x1A9210C", VA = "0x1A9210C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000029")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F7")]
				[Address(RVA = "0x1A92154", Offset = "0x1A92154", VA = "0x1A92154", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x1A91B64", Offset = "0x1A91B64", VA = "0x1A91B64")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x1A91B90", Offset = "0x1A91B90", VA = "0x1A91B90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1A91B94", Offset = "0x1A91B94", VA = "0x1A91B94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1A92114", Offset = "0x1A92114", VA = "0x1A92114", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Font TextMeshFont;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextContainer m_textContainer;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMesh m_textMesh;

		[Token(Token = "0x40000AF")]
		private const string label01 = "The <#0050FF>count is: </color>{0}";

		[Token(Token = "0x40000B0")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x154F738", Offset = "0x154F738", VA = "0x154F738")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FE50C", Offset = "0x8FE50C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x154F7A4", Offset = "0x154F7A4", VA = "0x154F7A4")]
		public Benchmark01()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class Benchmark01_UGUI : MonoBehaviour
	{
		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FACA4", Offset = "0x8FACA4")]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01_UGUI <>4__this;

			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700002A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000FD")]
				[Address(RVA = "0x1A92600", Offset = "0x1A92600", VA = "0x1A92600", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000FF")]
				[Address(RVA = "0x1A92648", Offset = "0x1A92648", VA = "0x1A92648", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1A9215C", Offset = "0x1A9215C", VA = "0x1A9215C")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1A92188", Offset = "0x1A92188", VA = "0x1A92188", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x1A9218C", Offset = "0x1A9218C", VA = "0x1A9218C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x1A92608", Offset = "0x1A92608", VA = "0x1A92608", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Canvas canvas;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Font TextMeshFont;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI m_textMeshPro;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text m_textMesh;

		[Token(Token = "0x40000BD")]
		private const string label01 = "The <#0050FF>count is: </color>";

		[Token(Token = "0x40000BE")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x154F7AC", Offset = "0x154F7AC", VA = "0x154F7AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FE5BC", Offset = "0x8FE5BC")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x154F818", Offset = "0x154F818", VA = "0x154F818")]
		public Benchmark01_UGUI()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class Benchmark02 : MonoBehaviour
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x154F820", Offset = "0x154F820", VA = "0x154F820")]
		private void Start()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x154FE40", Offset = "0x154FE40", VA = "0x154FE40")]
		public Benchmark02()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class Benchmark03 : MonoBehaviour
	{
		[Token(Token = "0x2000033")]
		public enum BenchmarkType
		{
			[Token(Token = "0x40000CD")]
			TMP_SDF_MOBILE,
			[Token(Token = "0x40000CE")]
			TMP_SDF__MOBILE_SSD,
			[Token(Token = "0x40000CF")]
			TMP_SDF,
			[Token(Token = "0x40000D0")]
			TMP_BITMAP_MOBILE,
			[Token(Token = "0x40000D1")]
			TEXTMESH_BITMAP
		}

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int NumberOfSamples;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BenchmarkType Benchmark;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font SourceFont;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x154FE50", Offset = "0x154FE50", VA = "0x154FE50")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x154FE54", Offset = "0x154FE54", VA = "0x154FE54")]
		private void Start()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1550310", Offset = "0x1550310", VA = "0x1550310")]
		public Benchmark03()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class Benchmark04 : MonoBehaviour
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int MinPointSize;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int MaxPointSize;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Steps;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform m_Transform;

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1550320", Offset = "0x1550320", VA = "0x1550320")]
		private void Start()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1550634", Offset = "0x1550634", VA = "0x1550634")]
		public Benchmark04()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x2000036")]
		public enum CameraModes
		{
			[Token(Token = "0x40000F1")]
			Follow,
			[Token(Token = "0x40000F2")]
			Isometric,
			[Token(Token = "0x40000F3")]
			Free
		}

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform cameraTransform;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform dummyTarget;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform CameraTarget;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FollowDistance;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float MaxFollowDistance;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float MinFollowDistance;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float ElevationAngle;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MaxElevationAngle;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MinElevationAngle;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OrbitalAngle;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public CameraModes CameraMode;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool MovementSmoothing;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool RotationSmoothing;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool previousSmoothing;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float MovementSmoothingValue;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float RotationSmoothingValue;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float MoveSensitivity;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 currentVelocity;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 desiredPosition;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float mouseX;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float mouseY;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 moveVector;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float mouseWheel;

		[Token(Token = "0x40000EE")]
		private const string event_SmoothingValue = "Slider - Smoothing Value";

		[Token(Token = "0x40000EF")]
		private const string event_FollowDistance = "Slider - Camera Zoom";

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1553C64", Offset = "0x1553C64", VA = "0x1553C64")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1553CE8", Offset = "0x1553CE8", VA = "0x1553CE8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1553DB4", Offset = "0x1553DB4", VA = "0x1553DB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x15540CC", Offset = "0x15540CC", VA = "0x15540CC")]
		private void GetPlayerInput()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1554878", Offset = "0x1554878", VA = "0x1554878")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class ObjectSpin : MonoBehaviour
	{
		[Token(Token = "0x2000038")]
		public enum MotionType
		{
			[Token(Token = "0x40000FF")]
			Rotation,
			[Token(Token = "0x4000100")]
			BackAndForth,
			[Token(Token = "0x4000101")]
			Translation
		}

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float SpinSpeed;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int RotationRange;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_transform;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_time;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_prevPOS;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_initial_Rotation;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_initial_Position;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Color32 m_lightColor;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int frames;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MotionType Motion;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x136A0C4", Offset = "0x136A0C4", VA = "0x136A0C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x136A1E4", Offset = "0x136A1E4", VA = "0x136A1E4")]
		private void Update()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x136A320", Offset = "0x136A320", VA = "0x136A320")]
		public ObjectSpin()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class ShaderPropAnimator : MonoBehaviour
	{
		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FACB4", Offset = "0x8FACB4")]
		private sealed class <AnimateProperties>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShaderPropAnimator <>4__this;

			[Token(Token = "0x1700002C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000116")]
				[Address(RVA = "0x1A95B7C", Offset = "0x1A95B7C", VA = "0x1A95B7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000118")]
				[Address(RVA = "0x1A95BC4", Offset = "0x1A95BC4", VA = "0x1A95BC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1A959EC", Offset = "0x1A959EC", VA = "0x1A959EC")]
			[DebuggerHidden]
			public <AnimateProperties>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1A95A18", Offset = "0x1A95A18", VA = "0x1A95A18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1A95A1C", Offset = "0x1A95A1C", VA = "0x1A95A1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x1A95B84", Offset = "0x1A95B84", VA = "0x1A95B84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer m_Renderer;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve GlowCurve;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_frame;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x150DE60", Offset = "0x150DE60", VA = "0x150DE60")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x150DEC8", Offset = "0x150DEC8", VA = "0x150DEC8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x150DEF4", Offset = "0x150DEF4", VA = "0x150DEF4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FE66C", Offset = "0x8FE66C")]
		private IEnumerator AnimateProperties()
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x150DF60", Offset = "0x150DF60", VA = "0x150DF60")]
		public ShaderPropAnimator()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class SimpleScript : MonoBehaviour
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x400010A")]
		private const string label = "The <#0050FF>count is: </color>{0:2}";

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_frame;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x150E424", Offset = "0x150E424", VA = "0x150E424")]
		private void Start()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x150E4DC", Offset = "0x150E4DC", VA = "0x150E4DC")]
		private void Update()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x150E574", Offset = "0x150E574", VA = "0x150E574")]
		public SimpleScript()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class SkewTextExample : MonoBehaviour
	{
		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FACC4", Offset = "0x8FACC4")]
		private sealed class <WarpText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkewTextExample <>4__this;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <old_ShearValue>5__3;

			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__4;

			[Token(Token = "0x1700002E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000124")]
				[Address(RVA = "0x1A96448", Offset = "0x1A96448", VA = "0x1A96448", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000126")]
				[Address(RVA = "0x1A96490", Offset = "0x1A96490", VA = "0x1A96490", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000121")]
			[Address(RVA = "0x1A95BCC", Offset = "0x1A95BCC", VA = "0x1A95BCC")]
			[DebuggerHidden]
			public <WarpText>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x1A95BF8", Offset = "0x1A95BF8", VA = "0x1A95BF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000123")]
			[Address(RVA = "0x1A95BFC", Offset = "0x1A95BFC", VA = "0x1A95BFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x1A96450", Offset = "0x1A96450", VA = "0x1A96450", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float CurveScale;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ShearAmount;

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x150E57C", Offset = "0x150E57C", VA = "0x150E57C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x150E5E0", Offset = "0x150E5E0", VA = "0x150E5E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x150E678", Offset = "0x150E678", VA = "0x150E678")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x150E60C", Offset = "0x150E60C", VA = "0x150E60C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FE71C", Offset = "0x8FE71C")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x150E6FC", Offset = "0x150E6FC", VA = "0x150E6FC")]
		public SkewTextExample()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		[Token(Token = "0x200003F")]
		public enum objectType
		{
			[Token(Token = "0x400011C")]
			TextMeshPro,
			[Token(Token = "0x400011D")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public objectType ObjectType;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isStatic;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_text;

		[Token(Token = "0x4000119")]
		private const string k_label = "The count is <#0080ff>{0}</color>";

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int count;

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1515104", Offset = "0x1515104", VA = "0x1515104")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x151531C", Offset = "0x151531C", VA = "0x151531C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x15153B4", Offset = "0x15153B4", VA = "0x15153B4")]
		public TMP_ExampleScript_01()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x2000041")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000129")]
			TopLeft,
			[Token(Token = "0x400012A")]
			BottomLeft,
			[Token(Token = "0x400012B")]
			TopRight,
			[Token(Token = "0x400012C")]
			BottomRight
		}

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x4000123")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_camera;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x15153BC", Offset = "0x15153BC", VA = "0x15153BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x15157C4", Offset = "0x15157C4", VA = "0x15157C4")]
		private void Start()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x15157F0", Offset = "0x15157F0", VA = "0x15157F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x15155BC", Offset = "0x15155BC", VA = "0x15155BC")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1515950", Offset = "0x1515950", VA = "0x1515950")]
		public TMP_FrameRateCounter()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class TMP_TextEventCheck : MonoBehaviour
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_TextEventHandler TextEventHandler;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1515D78", Offset = "0x1515D78", VA = "0x1515D78")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x151607C", Offset = "0x151607C", VA = "0x151607C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1516358", Offset = "0x1516358", VA = "0x1516358")]
		private void OnCharacterSelection(char c, int index)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1516550", Offset = "0x1516550", VA = "0x1516550")]
		private void OnSpriteSelection(char c, int index)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1516748", Offset = "0x1516748", VA = "0x1516748")]
		private void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x15169A8", Offset = "0x15169A8", VA = "0x15169A8")]
		private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1516C08", Offset = "0x1516C08", VA = "0x1516C08")]
		private void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1516EC4", Offset = "0x1516EC4", VA = "0x1516EC4")]
		public TMP_TextEventCheck()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class TMP_TextInfoDebugTool : MonoBehaviour
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1517920", Offset = "0x1517920", VA = "0x1517920")]
		public TMP_TextInfoDebugTool()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_isHoveringObject;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_selectedLink;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_lastCharIndex;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_lastWordIndex;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1517928", Offset = "0x1517928", VA = "0x1517928")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x15179B8", Offset = "0x15179B8", VA = "0x15179B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x15180D8", Offset = "0x15180D8", VA = "0x15180D8", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x151815C", Offset = "0x151815C", VA = "0x151815C", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x15181DC", Offset = "0x15181DC", VA = "0x15181DC")]
		public TMP_TextSelector_A()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform TextPopup_Prefab_01;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform m_TextPopup_RectTransform;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI m_TextPopup_TMPComponent;

		[Token(Token = "0x4000138")]
		private const string k_LinkText = "You have selected link <#ffff00>";

		[Token(Token = "0x4000139")]
		private const string k_WordText = "Word Index: <#ffff00>";

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Canvas m_Canvas;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_Camera;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isHoveringObject;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_selectedWord;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_selectedLink;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_lastIndex;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Matrix4x4 m_matrix;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TMP_MeshInfo[] m_cachedMeshInfoVertexData;

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x15181F4", Offset = "0x15181F4", VA = "0x15181F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1518380", Offset = "0x1518380", VA = "0x1518380")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1518470", Offset = "0x1518470", VA = "0x1518470")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1518560", Offset = "0x1518560", VA = "0x1518560")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1518600", Offset = "0x1518600", VA = "0x1518600")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1519AF8", Offset = "0x1519AF8", VA = "0x1519AF8", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1519B04", Offset = "0x1519B04", VA = "0x1519B04", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1519B0C", Offset = "0x1519B0C", VA = "0x1519B0C", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1519B10", Offset = "0x1519B10", VA = "0x1519B10", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1519268", Offset = "0x1519268", VA = "0x1519268")]
		private void RestoreCachedVertexAttributes(int index)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1519B14", Offset = "0x1519B14", VA = "0x1519B14")]
		public TMP_TextSelector_B()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x2000047")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x400014D")]
			TopLeft,
			[Token(Token = "0x400014E")]
			BottomLeft,
			[Token(Token = "0x400014F")]
			TopRight,
			[Token(Token = "0x4000150")]
			BottomRight
		}

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x4000148")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform m_frameCounter_transform;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1519B2C", Offset = "0x1519B2C", VA = "0x1519B2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1519F70", Offset = "0x1519F70", VA = "0x1519F70")]
		private void Start()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1519F9C", Offset = "0x1519F9C", VA = "0x1519F9C")]
		private void Update()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1519D2C", Offset = "0x1519D2C", VA = "0x1519D2C")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x151A0FC", Offset = "0x151A0FC", VA = "0x151A0FC")]
		public TMP_UiFrameRateCounter()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		[Token(Token = "0x2000049")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000158")]
			TopLeft,
			[Token(Token = "0x4000159")]
			BottomLeft,
			[Token(Token = "0x400015A")]
			TopRight,
			[Token(Token = "0x400015B")]
			BottomRight
		}

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000152")]
		private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextContainer m_textContainer;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera m_camera;

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x151A114", Offset = "0x151A114", VA = "0x151A114")]
		private void Awake()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x151A360", Offset = "0x151A360", VA = "0x151A360")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x151A488", Offset = "0x151A488", VA = "0x151A488")]
		public TMPro_InstructionOverlay()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class TeleType : MonoBehaviour
	{
		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FACD4", Offset = "0x8FACD4")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TeleType <>4__this;

			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalVisibleCharacters>5__2;

			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <counter>5__3;

			[Token(Token = "0x17000030")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000156")]
				[Address(RVA = "0x1A96874", Offset = "0x1A96874", VA = "0x1A96874", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000031")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000158")]
				[Address(RVA = "0x1A968BC", Offset = "0x1A968BC", VA = "0x1A968BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1A96614", Offset = "0x1A96614", VA = "0x1A96614")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1A96640", Offset = "0x1A96640", VA = "0x1A96640", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1A96644", Offset = "0x1A96644", VA = "0x1A96644", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1A9687C", Offset = "0x1A9687C", VA = "0x1A9687C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string label01;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string label02;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_textMeshPro;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x151B29C", Offset = "0x151B29C", VA = "0x151B29C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x151B330", Offset = "0x151B330", VA = "0x151B330")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FE7CC", Offset = "0x8FE7CC")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x151B39C", Offset = "0x151B39C", VA = "0x151B39C")]
		public TeleType()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class TextConsoleSimulator : MonoBehaviour
	{
		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FACE4", Offset = "0x8FACE4")]
		private sealed class <RevealCharacters>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TextConsoleSimulator <>4__this;

			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int <visibleCount>5__4;

			[Token(Token = "0x17000032")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000164")]
				[Address(RVA = "0x1A96A58", Offset = "0x1A96A58", VA = "0x1A96A58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000033")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000166")]
				[Address(RVA = "0x1A96AA0", Offset = "0x1A96AA0", VA = "0x1A96AA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1A968C4", Offset = "0x1A968C4", VA = "0x1A968C4")]
			[DebuggerHidden]
			public <RevealCharacters>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1A968F0", Offset = "0x1A968F0", VA = "0x1A968F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000163")]
			[Address(RVA = "0x1A968F4", Offset = "0x1A968F4", VA = "0x1A968F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000165")]
			[Address(RVA = "0x1A96A60", Offset = "0x1A96A60", VA = "0x1A96A60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FACF4", Offset = "0x8FACF4")]
		private sealed class <RevealWords>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalWordCount>5__2;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <counter>5__4;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <visibleCount>5__5;

			[Token(Token = "0x17000034")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600016A")]
				[Address(RVA = "0x1A96CC0", Offset = "0x1A96CC0", VA = "0x1A96CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000035")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600016C")]
				[Address(RVA = "0x1A96D08", Offset = "0x1A96D08", VA = "0x1A96D08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000167")]
			[Address(RVA = "0x1A96AA8", Offset = "0x1A96AA8", VA = "0x1A96AA8")]
			[DebuggerHidden]
			public <RevealWords>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1A96AD4", Offset = "0x1A96AD4", VA = "0x1A96AD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000169")]
			[Address(RVA = "0x1A96AD8", Offset = "0x1A96AD8", VA = "0x1A96AD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600016B")]
			[Address(RVA = "0x1A96CC8", Offset = "0x1A96CC8", VA = "0x1A96CC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool hasTextChanged;

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x151B8B4", Offset = "0x151B8B4", VA = "0x151B8B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x151B918", Offset = "0x151B918", VA = "0x151B918")]
		private void Start()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x151B9C0", Offset = "0x151B9C0", VA = "0x151B9C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x151BAB0", Offset = "0x151BAB0", VA = "0x151BAB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x151BBA0", Offset = "0x151BBA0", VA = "0x151BBA0")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x151B948", Offset = "0x151B948", VA = "0x151B948")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FE87C", Offset = "0x8FE87C")]
		private IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x151BBAC", Offset = "0x151BBAC", VA = "0x151BBAC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FE8DC", Offset = "0x8FE8DC")]
		private IEnumerator RevealWords(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x151BC18", Offset = "0x151BC18", VA = "0x151BC18")]
		public TextConsoleSimulator()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class TextMeshProFloatingText : MonoBehaviour
	{
		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAD04", Offset = "0x8FAD04")]
		private sealed class <DisplayTextMeshProFloatingText>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x17000036")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000176")]
				[Address(RVA = "0x1A97658", Offset = "0x1A97658", VA = "0x1A97658", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000037")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000178")]
				[Address(RVA = "0x1A976A0", Offset = "0x1A976A0", VA = "0x1A976A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000173")]
			[Address(RVA = "0x1A971D0", Offset = "0x1A971D0", VA = "0x1A971D0")]
			[DebuggerHidden]
			public <DisplayTextMeshProFloatingText>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000174")]
			[Address(RVA = "0x1A971FC", Offset = "0x1A971FC", VA = "0x1A971FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1A97200", Offset = "0x1A97200", VA = "0x1A97200", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1A97660", Offset = "0x1A97660", VA = "0x1A97660", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAD14", Offset = "0x8FAD14")]
		private sealed class <DisplayTextMeshFloatingText>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600017C")]
				[Address(RVA = "0x1A97180", Offset = "0x1A97180", VA = "0x1A97180", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600017E")]
				[Address(RVA = "0x1A971C8", Offset = "0x1A971C8", VA = "0x1A971C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1A96D10", Offset = "0x1A96D10", VA = "0x1A96D10")]
			[DebuggerHidden]
			public <DisplayTextMeshFloatingText>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1A96D3C", Offset = "0x1A96D3C", VA = "0x1A96D3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600017B")]
			[Address(RVA = "0x1A96D40", Offset = "0x1A96D40", VA = "0x1A96D40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600017D")]
			[Address(RVA = "0x1A97188", Offset = "0x1A97188", VA = "0x1A97188", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Font TheFont;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject m_floatingText;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMesh m_textMesh;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_transform;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_floatingText_Transform;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform m_cameraTransform;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 lastPOS;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion lastRotation;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int SpawnType;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static WaitForEndOfFrame k_WaitForEndOfFrame;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static WaitForSeconds[] k_WaitForSecondsRandom;

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x151BC20", Offset = "0x151BC20", VA = "0x151BC20")]
		private void Awake()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x151BCE8", Offset = "0x151BCE8", VA = "0x151BCE8")]
		private void Start()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x151C0C0", Offset = "0x151C0C0", VA = "0x151C0C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FE9DC", Offset = "0x8FE9DC")]
		public IEnumerator DisplayTextMeshProFloatingText()
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x151C12C", Offset = "0x151C12C", VA = "0x151C12C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FEA3C", Offset = "0x8FEA3C")]
		public IEnumerator DisplayTextMeshFloatingText()
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x151C198", Offset = "0x151C198", VA = "0x151C198")]
		public TextMeshProFloatingText()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class TextMeshSpawner : MonoBehaviour
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font TheFont;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x151C7FC", Offset = "0x151C7FC", VA = "0x151C7FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x151C800", Offset = "0x151C800", VA = "0x151C800")]
		private void Start()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x151CB20", Offset = "0x151CB20", VA = "0x151CB20")]
		public TextMeshSpawner()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class VertexColorCycler : MonoBehaviour
	{
		[Token(Token = "0x2000054")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAD24", Offset = "0x8FAD24")]
		private sealed class <AnimateVertexColors>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexColorCycler <>4__this;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <currentCharacter>5__3;

			[Token(Token = "0x1700003A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000189")]
				[Address(RVA = "0x1A98B00", Offset = "0x1A98B00", VA = "0x1A98B00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600018B")]
				[Address(RVA = "0x1A98B48", Offset = "0x1A98B48", VA = "0x1A98B48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1A98818", Offset = "0x1A98818", VA = "0x1A98818")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1A98844", Offset = "0x1A98844", VA = "0x1A98844", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1A98848", Offset = "0x1A98848", VA = "0x1A98848", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600018A")]
			[Address(RVA = "0x1A98B08", Offset = "0x1A98B08", VA = "0x1A98B08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1467B94", Offset = "0x1467B94", VA = "0x1467B94")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1467BE8", Offset = "0x1467BE8", VA = "0x1467BE8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1467C14", Offset = "0x1467C14", VA = "0x1467C14")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FEB3C", Offset = "0x8FEB3C")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1467C80", Offset = "0x1467C80", VA = "0x1467C80")]
		public VertexColorCycler()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class VertexJitter : MonoBehaviour
	{
		[Token(Token = "0x2000056")]
		private struct VertexAnim
		{
			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float angleRange;

			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float angle;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float speed;
		}

		[Token(Token = "0x2000057")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAD34", Offset = "0x8FAD34")]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexJitter <>4__this;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <loopCount>5__3;

			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private VertexAnim[] <vertexAnim>5__4;

			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TMP_MeshInfo[] <cachedMeshInfo>5__5;

			[Token(Token = "0x1700003C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000196")]
				[Address(RVA = "0x1A993B8", Offset = "0x1A993B8", VA = "0x1A993B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000198")]
				[Address(RVA = "0x1A99400", Offset = "0x1A99400", VA = "0x1A99400", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000193")]
			[Address(RVA = "0x1A98B50", Offset = "0x1A98B50", VA = "0x1A98B50")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000194")]
			[Address(RVA = "0x1A98B7C", Offset = "0x1A98B7C", VA = "0x1A98B7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000195")]
			[Address(RVA = "0x1A98B80", Offset = "0x1A98B80", VA = "0x1A98B80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1A993C0", Offset = "0x1A993C0", VA = "0x1A993C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1467C88", Offset = "0x1467C88", VA = "0x1467C88")]
		private void Awake()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1467CDC", Offset = "0x1467CDC", VA = "0x1467CDC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1467DCC", Offset = "0x1467DCC", VA = "0x1467DCC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1467EBC", Offset = "0x1467EBC", VA = "0x1467EBC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1467F54", Offset = "0x1467F54", VA = "0x1467F54")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1467EE8", Offset = "0x1467EE8", VA = "0x1467EE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FEBEC", Offset = "0x8FEBEC")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1467FDC", Offset = "0x1467FDC", VA = "0x1467FDC")]
		public VertexJitter()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class VertexShakeA : MonoBehaviour
	{
		[Token(Token = "0x2000059")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAD44", Offset = "0x8FAD44")]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeA <>4__this;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x1700003E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001A3")]
				[Address(RVA = "0x1A99E08", Offset = "0x1A99E08", VA = "0x1A99E08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001A5")]
				[Address(RVA = "0x1A99E50", Offset = "0x1A99E50", VA = "0x1A99E50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x1A99408", Offset = "0x1A99408", VA = "0x1A99408")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x1A99434", Offset = "0x1A99434", VA = "0x1A99434", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1A99438", Offset = "0x1A99438", VA = "0x1A99438", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x1A99E10", Offset = "0x1A99E10", VA = "0x1A99E10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ScaleMultiplier;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RotationMultiplier;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1467FF4", Offset = "0x1467FF4", VA = "0x1467FF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1468048", Offset = "0x1468048", VA = "0x1468048")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1468138", Offset = "0x1468138", VA = "0x1468138")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1468228", Offset = "0x1468228", VA = "0x1468228")]
		private void Start()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x14682C0", Offset = "0x14682C0", VA = "0x14682C0")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1468254", Offset = "0x1468254", VA = "0x1468254")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FEC9C", Offset = "0x8FEC9C")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1468338", Offset = "0x1468338", VA = "0x1468338")]
		public VertexShakeA()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class VertexShakeB : MonoBehaviour
	{
		[Token(Token = "0x200005B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAD54", Offset = "0x8FAD54")]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeB <>4__this;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x17000040")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001B0")]
				[Address(RVA = "0x1A9ACEC", Offset = "0x1A9ACEC", VA = "0x1A9ACEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000041")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001B2")]
				[Address(RVA = "0x1A9AD34", Offset = "0x1A9AD34", VA = "0x1A9AD34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x1A99E58", Offset = "0x1A99E58", VA = "0x1A99E58")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x1A99E84", Offset = "0x1A99E84", VA = "0x1A99E84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x1A99E88", Offset = "0x1A99E88", VA = "0x1A99E88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x1A9ACF4", Offset = "0x1A9ACF4", VA = "0x1A9ACF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1468348", Offset = "0x1468348", VA = "0x1468348")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x146839C", Offset = "0x146839C", VA = "0x146839C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x146848C", Offset = "0x146848C", VA = "0x146848C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x146857C", Offset = "0x146857C", VA = "0x146857C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1468614", Offset = "0x1468614", VA = "0x1468614")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x14685A8", Offset = "0x14685A8", VA = "0x14685A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FED4C", Offset = "0x8FED4C")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x146868C", Offset = "0x146868C", VA = "0x146868C")]
		public VertexShakeB()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class VertexZoom : MonoBehaviour
	{
		[Token(Token = "0x200005D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAD64", Offset = "0x8FAD64")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<float> modifiedCharScale;

			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Comparison<int> <>9__0;

			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x1A9AD3C", Offset = "0x1A9AD3C", VA = "0x1A9AD3C")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x1A9AD44", Offset = "0x1A9AD44", VA = "0x1A9AD44")]
			internal int <AnimateVertexColors>b__0(int a, int b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200005E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAD74", Offset = "0x8FAD74")]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexZoom <>4__this;

			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass10_0 <>8__1;

			[Token(Token = "0x40001CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40001CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;

			[Token(Token = "0x40001D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<int> <scaleSortingOrder>5__4;

			[Token(Token = "0x17000042")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001BF")]
				[Address(RVA = "0x1A9B978", Offset = "0x1A9B978", VA = "0x1A9B978", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000043")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001C1")]
				[Address(RVA = "0x1A9B9C0", Offset = "0x1A9B9C0", VA = "0x1A9B9C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x1A9AE04", Offset = "0x1A9AE04", VA = "0x1A9AE04")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x1A9AE30", Offset = "0x1A9AE30", VA = "0x1A9AE30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x1A9AE34", Offset = "0x1A9AE34", VA = "0x1A9AE34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x1A9B980", Offset = "0x1A9B980", VA = "0x1A9B980", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x14686A4", Offset = "0x14686A4", VA = "0x14686A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x14686F8", Offset = "0x14686F8", VA = "0x14686F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x14687E8", Offset = "0x14687E8", VA = "0x14687E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x14688D8", Offset = "0x14688D8", VA = "0x14688D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1468970", Offset = "0x1468970", VA = "0x1468970")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1468904", Offset = "0x1468904", VA = "0x1468904")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FEDFC", Offset = "0x8FEDFC")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x14689F8", Offset = "0x14689F8", VA = "0x14689F8")]
		public VertexZoom()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class WarpTextExample : MonoBehaviour
	{
		[Token(Token = "0x2000060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAD84", Offset = "0x8FAD84")]
		private sealed class <WarpText>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WarpTextExample <>4__this;

			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x40001DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__3;

			[Token(Token = "0x17000044")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x1A9C3A8", Offset = "0x1A9C3A8", VA = "0x1A9C3A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000045")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0x1A9C3F0", Offset = "0x1A9C3F0", VA = "0x1A9C3F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x1A9BBC4", Offset = "0x1A9BBC4", VA = "0x1A9BBC4")]
			[DebuggerHidden]
			public <WarpText>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x1A9BBF0", Offset = "0x1A9BBF0", VA = "0x1A9BBF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x1A9BBF4", Offset = "0x1A9BBF4", VA = "0x1A9BBF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x1A9C3B0", Offset = "0x1A9C3B0", VA = "0x1A9C3B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float AngleMultiplier;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float SpeedMultiplier;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CurveScale;

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x146BBA0", Offset = "0x146BBA0", VA = "0x146BBA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x146BC04", Offset = "0x146BC04", VA = "0x146BC04")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x146BC9C", Offset = "0x146BC9C", VA = "0x146BC9C")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x146BC30", Offset = "0x146BC30", VA = "0x146BC30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FEEAC", Offset = "0x8FEEAC")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x146BD20", Offset = "0x146BD20", VA = "0x146BD20")]
		public WarpTextExample()
		{
		}
	}
}
namespace MetaSee
{
	[Token(Token = "0x2000061")]
	public class EventDispatcher
	{
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<AudioEffect> OnButtonAudioEffect;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<int> OnBatteryValueChanged;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<int> OnVolumeValueChanged;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action OnBackButtonClicked;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action OnRecenterScreen;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Action<bool> OnNetReachabilityChanged;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action<eUIType, bool> OnUIPanelVisibleChanged;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Action OnNetworkTimeReady;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Action<string> OnUserLogined;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Action OnLoginSessionRefreshed;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Action OnLoginSessionExpired;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Action OnBackToLoginPage;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Action<VideoScheduleInfo> OnDistributionCodeVerified;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Action<PlayVideoParams> OnBeforeVideoPlaying;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Action OnAfterVideoPlaying;

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x136060C", Offset = "0x136060C", VA = "0x136060C")]
		public EventDispatcher()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public enum LogLevel
	{
		[Token(Token = "0x40001EB")]
		Debug,
		[Token(Token = "0x40001EC")]
		Info,
		[Token(Token = "0x40001ED")]
		Warn,
		[Token(Token = "0x40001EE")]
		Error
	}
	[Token(Token = "0x2000063")]
	public class LogHelper : SingletonMono<LogHelper>
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static StreamWriter s_StreamWriter;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FB570", Offset = "0x8FB570")]
		private LogLevel <MinLevel>k__BackingField;

		[Token(Token = "0x17000046")]
		public LogLevel MinLevel
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x13658C4", Offset = "0x13658C4", VA = "0x13658C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FEF5C", Offset = "0x8FEF5C")]
			get
			{
				return default(LogLevel);
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x13658CC", Offset = "0x13658CC", VA = "0x13658CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FEF6C", Offset = "0x8FEF6C")]
			set
			{
			}
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x13658D4", Offset = "0x13658D4", VA = "0x13658D4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1365AF0", Offset = "0x1365AF0", VA = "0x1365AF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1365C4C", Offset = "0x1365C4C", VA = "0x1365C4C")]
		public void LogDebug(string msg, params object[] args)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1365C40", Offset = "0x1365C40", VA = "0x1365C40")]
		public void LogInfo(string msg, params object[] args)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1365EFC", Offset = "0x1365EFC", VA = "0x1365EFC")]
		public void LogWarn(string msg, params object[] args)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1365F08", Offset = "0x1365F08", VA = "0x1365F08")]
		public void LogError(string msg, params object[] args)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1365C58", Offset = "0x1365C58", VA = "0x1365C58")]
		protected void Log(string msg, LogLevel level, params object[] args)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1365F14", Offset = "0x1365F14", VA = "0x1365F14")]
		private string Format(LogLevel level, string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x136622C", Offset = "0x136622C", VA = "0x136622C")]
		public LogHelper()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public static class MetaDefine
	{
		[Token(Token = "0x40001F1")]
		public const float Epsilon = 0.0001f;

		[Token(Token = "0x40001F2")]
		public const float ScreenMaskValue = 0.95f;

		[Token(Token = "0x40001F3")]
		public const string KeyPlayerUid = "KEY-PLAYER-UID";

		[Token(Token = "0x40001F4")]
		public const string KeyPlayerPhone = "KEY-PLAYER-PHONE";

		[Token(Token = "0x40001F5")]
		public const string KeyReportDevice = "KEY-REPORT-DEVICE";

		[Token(Token = "0x40001F6")]
		public const string KeyBindDevice = "KEY-BIND-DEVICE";

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DateTime UnixEpoch;
	}
	[Token(Token = "0x2000065")]
	public enum eVideoType
	{
		[Token(Token = "0x40001F9")]
		UNKNOWN,
		[Token(Token = "0x40001FA")]
		FLAT_2D,
		[Token(Token = "0x40001FB")]
		FLAT_3D_TB,
		[Token(Token = "0x40001FC")]
		FLAT_3D_LR,
		[Token(Token = "0x40001FD")]
		EQR_180_2D,
		[Token(Token = "0x40001FE")]
		EQR_180_TB,
		[Token(Token = "0x40001FF")]
		EQR_180_LR,
		[Token(Token = "0x4000200")]
		EQR_360_2D,
		[Token(Token = "0x4000201")]
		EQR_360_TB,
		[Token(Token = "0x4000202")]
		EQR_360_LR
	}
	[Token(Token = "0x2000066")]
	public enum eAudioType
	{
		[Token(Token = "0x4000204")]
		NONE,
		[Token(Token = "0x4000205")]
		STEREO,
		[Token(Token = "0x4000206")]
		FOA_4,
		[Token(Token = "0x4000207")]
		TBE_8_2,
		[Token(Token = "0x4000208")]
		TBE_8_0,
		[Token(Token = "0x4000209")]
		TBD
	}
	[Token(Token = "0x2000067")]
	public enum eTrackType
	{
		[Token(Token = "0x400020B")]
		UNKNOWN,
		[Token(Token = "0x400020C")]
		VIDEO,
		[Token(Token = "0x400020D")]
		AUDIO
	}
	[Token(Token = "0x2000068")]
	public enum eCacheType
	{
		[Token(Token = "0x400020F")]
		NONE,
		[Token(Token = "0x4000210")]
		TEMP,
		[Token(Token = "0x4000211")]
		PERSISTENT
	}
	[Token(Token = "0x2000069")]
	public sealed class TrackInfo
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public eTrackType TrackType;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Id;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string FileName;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsDefault;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public eCacheType CacheType;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint Bitrate;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int Width;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int Height;

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x151CCB4", Offset = "0x151CCB4", VA = "0x151CCB4")]
		public TrackInfo()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public sealed class PlayVideoParams
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint VideoScheduleId;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string VideoUrl;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint VideoSize;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string FileName;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint VideoType;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public uint AudioType;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint StreamType;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TrackInfo[] Tracks;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TrackInfo SelectedTrack;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x136AAB8", Offset = "0x136AAB8", VA = "0x136AAB8")]
		public PlayVideoParams()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public sealed class AppVerInfo
	{
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB580", Offset = "0x8FB580")]
		public string VersionName;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB5B8", Offset = "0x8FB5B8")]
		public int VersionCode;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB5F0", Offset = "0x8FB5F0")]
		public string Platform;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB628", Offset = "0x8FB628")]
		public string ReleaseDate;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB660", Offset = "0x8FB660")]
		public string ReleaseNote;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB698", Offset = "0x8FB698")]
		public string DownloadUrl;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB6D0", Offset = "0x8FB6D0")]
		public int ApkSize;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB708", Offset = "0x8FB708")]
		public int Channel;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB740", Offset = "0x8FB740")]
		public int IsForceUpdate;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x154EE74", Offset = "0x154EE74", VA = "0x154EE74")]
		public AppVerInfo()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public sealed class DeviceInfo
	{
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB778", Offset = "0x8FB778")]
		public string Uuid;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB7B0", Offset = "0x8FB7B0")]
		public string Vendor;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB7E8", Offset = "0x8FB7E8")]
		public string Model;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB820", Offset = "0x8FB820")]
		public string Product;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB858", Offset = "0x8FB858")]
		public string OsVer;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB890", Offset = "0x8FB890")]
		public string SysVer;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB8C8", Offset = "0x8FB8C8")]
		public string Serial;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB900", Offset = "0x8FB900")]
		public string Internal;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB938", Offset = "0x8FB938")]
		public string External;

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1360370", Offset = "0x1360370", VA = "0x1360370")]
		public DeviceInfo()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public sealed class SystemParameter
	{
		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB970", Offset = "0x8FB970")]
		public string KeyName;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB9A8", Offset = "0x8FB9A8")]
		public uint ValueType;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FB9E0", Offset = "0x8FB9E0")]
		public int IntValue;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBA18", Offset = "0x8FBA18")]
		public string StrValue;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x150F704", Offset = "0x150F704", VA = "0x150F704")]
		public SystemParameter()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public sealed class UserInfo
	{
		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBA50", Offset = "0x8FBA50")]
		public uint Uid;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBA88", Offset = "0x8FBA88")]
		public string Mobile;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBAC0", Offset = "0x8FBAC0")]
		public string Nickname;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBAF8", Offset = "0x8FBAF8")]
		public uint Balance;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBB30", Offset = "0x8FBB30")]
		public uint IsNew;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1467B8C", Offset = "0x1467B8C", VA = "0x1467B8C")]
		public UserInfo()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public sealed class VideoTicketInfo
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBB68", Offset = "0x8FBB68")]
		public uint VideoTicketId;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBBA0", Offset = "0x8FBBA0")]
		public uint Status;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBBD8", Offset = "0x8FBBD8")]
		public uint OriginType;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBC10", Offset = "0x8FBC10")]
		public uint TimerType;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBC48", Offset = "0x8FBC48")]
		public uint Duration;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBC80", Offset = "0x8FBC80")]
		public string DistributionCode;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBCB8", Offset = "0x8FBCB8")]
		public string ActivationTime;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBCF0", Offset = "0x8FBCF0")]
		public string ExpirationTime;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x146B0F4", Offset = "0x146B0F4", VA = "0x146B0F4")]
		public VideoTicketInfo()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public sealed class CommodityInfo
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBD28", Offset = "0x8FBD28")]
		public uint CommodityId;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBD60", Offset = "0x8FBD60")]
		public string Name;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBD98", Offset = "0x8FBD98")]
		public string Desc;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBDD0", Offset = "0x8FBDD0")]
		public string Tags;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBE08", Offset = "0x8FBE08")]
		public uint BasePrice;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBE40", Offset = "0x8FBE40")]
		public uint DiscountPrice;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBE78", Offset = "0x8FBE78")]
		public uint SaleType;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBEB0", Offset = "0x8FBEB0")]
		public uint SaleCount;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBEE8", Offset = "0x8FBEE8")]
		public string RetailerName;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBF20", Offset = "0x8FBF20")]
		public string LinkApp;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBF58", Offset = "0x8FBF58")]
		public string LinkPath;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1555218", Offset = "0x1555218", VA = "0x1555218")]
		public CommodityInfo()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public sealed class PerformanceInfo
	{
		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBF90", Offset = "0x8FBF90")]
		public uint Id;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FBFC8", Offset = "0x8FBFC8")]
		public string Name;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC000", Offset = "0x8FC000")]
		public string Desc;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC038", Offset = "0x8FC038")]
		public string Tags;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC070", Offset = "0x8FC070")]
		public string StartTime;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC0A8", Offset = "0x8FC0A8")]
		public string EndTime;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC0E0", Offset = "0x8FC0E0")]
		public string TryoutUrl;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC118", Offset = "0x8FC118")]
		public uint IsFree;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC150", Offset = "0x8FC150")]
		public uint IsDownloadable;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC188", Offset = "0x8FC188")]
		public uint VideoSize;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC1C0", Offset = "0x8FC1C0")]
		public string FileName;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC1F8", Offset = "0x8FC1F8")]
		public string VideoUrl;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC230", Offset = "0x8FC230")]
		public uint VideoScheduleId;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC268", Offset = "0x8FC268")]
		public uint VideoScheduleType;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC2A0", Offset = "0x8FC2A0")]
		public uint VideoType;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC2D8", Offset = "0x8FC2D8")]
		public uint AudioType;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC310", Offset = "0x8FC310")]
		public uint StreamType;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC348", Offset = "0x8FC348")]
		public string Resolution;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC380", Offset = "0x8FC380")]
		public uint Duration;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC3B8", Offset = "0x8FC3B8")]
		public uint Bitrate;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC3F0", Offset = "0x8FC3F0")]
		public string Tracks;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC428", Offset = "0x8FC428")]
		public CommodityInfo[] Commodities;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC460", Offset = "0x8FC460")]
		public VideoTicketInfo[] VideoTickets;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[JsonIgnore]
		public TrackInfo[] TrackInfos;

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x136A374", Offset = "0x136A374", VA = "0x136A374")]
		public PerformanceInfo()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public sealed class VideoScheduleInfo
	{
		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC4A8", Offset = "0x8FC4A8")]
		public uint PerformanceId;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC4E0", Offset = "0x8FC4E0")]
		public string PerformanceName;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC518", Offset = "0x8FC518")]
		public string PerformanceDesc;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC550", Offset = "0x8FC550")]
		public string CommodityName;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC588", Offset = "0x8FC588")]
		public string CommodityDesc;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC5C0", Offset = "0x8FC5C0")]
		public string RetailerName;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC5F8", Offset = "0x8FC5F8")]
		public uint Price;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC630", Offset = "0x8FC630")]
		public uint VideoScheduleId;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC668", Offset = "0x8FC668")]
		public uint VideoScheduleType;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC6A0", Offset = "0x8FC6A0")]
		public uint VideoScheduleStatus;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC6D8", Offset = "0x8FC6D8")]
		public string StartTime;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC710", Offset = "0x8FC710")]
		public string EndTime;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC748", Offset = "0x8FC748")]
		public uint TimerType;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC780", Offset = "0x8FC780")]
		public uint Duration;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC7B8", Offset = "0x8FC7B8")]
		public string DistributionCode;

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x146B0EC", Offset = "0x146B0EC", VA = "0x146B0EC")]
		public VideoScheduleInfo()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public sealed class OrderInfo
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC7F0", Offset = "0x8FC7F0")]
		public VideoScheduleInfo ScheduleInfo;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC828", Offset = "0x8FC828")]
		public uint OrderOriginType;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC860", Offset = "0x8FC860")]
		public uint TicketStatus;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC898", Offset = "0x8FC898")]
		public string OrderCreateTime;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC8D0", Offset = "0x8FC8D0")]
		public string ActivationTime;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC908", Offset = "0x8FC908")]
		public string ExpirationTime;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC940", Offset = "0x8FC940")]
		public string FirstUseTime;

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x136A36C", Offset = "0x136A36C", VA = "0x136A36C")]
		public OrderInfo()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public sealed class VideoReqResult
	{
		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC978", Offset = "0x8FC978")]
		public uint VideoScheduleId;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC9B0", Offset = "0x8FC9B0")]
		public uint VideoTicketId;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FC9E8", Offset = "0x8FC9E8")]
		public string VideoUrl;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCA20", Offset = "0x8FCA20")]
		public uint VideoSize;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCA58", Offset = "0x8FCA58")]
		public string FileName;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCA90", Offset = "0x8FCA90")]
		public uint VideoType;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCAC8", Offset = "0x8FCAC8")]
		public uint AudioType;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCB00", Offset = "0x8FCB00")]
		public uint StreamType;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCB38", Offset = "0x8FCB38")]
		public string Resolution;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCB70", Offset = "0x8FCB70")]
		public uint Duration;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCBA8", Offset = "0x8FCBA8")]
		public uint Bitrate;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCBE0", Offset = "0x8FCBE0")]
		public string Tracks;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCC18", Offset = "0x8FCC18")]
		public uint IsTicketNew;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x146B0E4", Offset = "0x146B0E4", VA = "0x146B0E4")]
		public VideoReqResult()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
	{
		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static T s_Instance;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FCC50", Offset = "0x8FCC50")]
		private bool <Started>k__BackingField;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool _started;

		[Token(Token = "0x17000047")]
		public static T Instance
		{
			[Token(Token = "0x60001E6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public bool Started
		{
			[Token(Token = "0x60001E7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FEF7C", Offset = "0x8FEF7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FEF8C", Offset = "0x8FEF8C")]
			private set
			{
			}
		}

		[Token(Token = "0x60001E9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001EA")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60001EB")]
		public SingletonMono()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[DisallowMultipleComponent]
	public class AndroidManager : SingletonMono<AndroidManager>
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FCC60", Offset = "0x8FCC60")]
		private AndroidJavaObject <Context>k__BackingField;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FCC70", Offset = "0x8FCC70")]
		private string <SdCardRootPath>k__BackingField;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FCC80", Offset = "0x8FCC80")]
		private bool <HasWritePermission>k__BackingField;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FCC90", Offset = "0x8FCC90")]
		private AndroidJavaObject <DeviceHelperJavaObj>k__BackingField;

		[Token(Token = "0x17000049")]
		public AndroidJavaObject Context
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x154D6A4", Offset = "0x154D6A4", VA = "0x154D6A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FEF9C", Offset = "0x8FEF9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x154D6AC", Offset = "0x154D6AC", VA = "0x154D6AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FEFAC", Offset = "0x8FEFAC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public string SdCardRootPath
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x154D6B4", Offset = "0x154D6B4", VA = "0x154D6B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FEFBC", Offset = "0x8FEFBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x154D6BC", Offset = "0x154D6BC", VA = "0x154D6BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FEFCC", Offset = "0x8FEFCC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool HasWritePermission
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x154D6C4", Offset = "0x154D6C4", VA = "0x154D6C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FEFDC", Offset = "0x8FEFDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x154D6CC", Offset = "0x154D6CC", VA = "0x154D6CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FEFEC", Offset = "0x8FEFEC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public AndroidJavaObject DeviceHelperJavaObj
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x154D6D8", Offset = "0x154D6D8", VA = "0x154D6D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FEFFC", Offset = "0x8FEFFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x154D6E0", Offset = "0x154D6E0", VA = "0x154D6E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF00C", Offset = "0x8FF00C")]
			private set
			{
			}
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x154D6E8", Offset = "0x154D6E8", VA = "0x154D6E8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x154DECC", Offset = "0x154DECC", VA = "0x154DECC")]
		public void RequestPermission(string permission)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x154E85C", Offset = "0x154E85C", VA = "0x154E85C")]
		public bool InstallApk(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x154E034", Offset = "0x154E034", VA = "0x154E034")]
		public DeviceInfo GetDeviceInfo()
		{
			return null;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x154E96C", Offset = "0x154E96C", VA = "0x154E96C")]
		internal void OnPermissionDeniedAndDontAskAgain(string permissionName)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x154EAB4", Offset = "0x154EAB4", VA = "0x154EAB4")]
		internal void OnPermissionGranted(string permissionName)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x154EC00", Offset = "0x154EC00", VA = "0x154EC00")]
		internal void OnPermissionDenied(string permissionName)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x154DE10", Offset = "0x154DE10", VA = "0x154DE10")]
		protected void DoTalkingDataInit()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x154ED48", Offset = "0x154ED48", VA = "0x154ED48")]
		protected void OnApplicationFocus(bool focus)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x154EDCC", Offset = "0x154EDCC", VA = "0x154EDCC", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x154EE28", Offset = "0x154EE28", VA = "0x154EE28")]
		public AndroidManager()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public enum AudioEffect
	{
		[Token(Token = "0x4000295")]
		Hover,
		[Token(Token = "0x4000296")]
		Click
	}
	[Token(Token = "0x2000078")]
	[DisallowMultipleComponent]
	public class AudioManager : SingletonMono<AudioManager>
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _hoverAudio;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _clickAudio;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _bgm;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioSource BgmAudioSource;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioSource EvtAudioSource;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x154F470", Offset = "0x154F470", VA = "0x154F470", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x154F4E8", Offset = "0x154F4E8", VA = "0x154F4E8")]
		public void PlayBackgroundMusic()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x154F5C8", Offset = "0x154F5C8", VA = "0x154F5C8")]
		public void StopBackgroundMusic()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x154F294", Offset = "0x154F294", VA = "0x154F294")]
		public void PlayEffectAudio(AudioEffect type)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x154F1F0", Offset = "0x154F1F0", VA = "0x154F1F0")]
		public void PlayEffectAudio(AudioClip clip)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x154F658", Offset = "0x154F658", VA = "0x154F658")]
		public AudioManager()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[DisallowMultipleComponent]
	public class MainManager : SingletonMono<MainManager>
	{
		[Serializable]
		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FADC4", Offset = "0x8FADC4")]
		private sealed class <>c
		{
			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<Exception> <>9__11_0;

			[Token(Token = "0x6000217")]
			[Address(RVA = "0x1A93324", Offset = "0x1A93324", VA = "0x1A93324")]
			public <>c()
			{
			}

			[Token(Token = "0x6000218")]
			[Address(RVA = "0x1A9332C", Offset = "0x1A9332C", VA = "0x1A9332C")]
			internal void <Awake>b__11_0(Exception ex)
			{
			}
		}

		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FADD4", Offset = "0x8FADD4")]
		private sealed class <LoadingProcedure>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MainManager <>4__this;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform <transParent>5__2;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Transform <sceneRoot>5__3;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GameObject <logoGo>5__4;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Animator <animator>5__5;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UIAppLoading <loadingPanel>5__6;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private ResourceRequest <request>5__7;

			[Token(Token = "0x1700004F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600021C")]
				[Address(RVA = "0x1A9488C", Offset = "0x1A9488C", VA = "0x1A9488C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000050")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600021E")]
				[Address(RVA = "0x1A948D4", Offset = "0x1A948D4", VA = "0x1A948D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0x1A93774", Offset = "0x1A93774", VA = "0x1A93774")]
			[DebuggerHidden]
			public <LoadingProcedure>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0x1A937A0", Offset = "0x1A937A0", VA = "0x1A937A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0x1A937A4", Offset = "0x1A937A4", VA = "0x1A937A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0x1A94894", Offset = "0x1A94894", VA = "0x1A94894", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FADE4", Offset = "0x8FADE4")]
		private sealed class <CoroutineQuerySystemParams>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MainManager <>4__this;

			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private System.Random <random>5__2;

			[Token(Token = "0x17000051")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000222")]
				[Address(RVA = "0x1A93724", Offset = "0x1A93724", VA = "0x1A93724", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000052")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000224")]
				[Address(RVA = "0x1A9376C", Offset = "0x1A9376C", VA = "0x1A9376C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600021F")]
			[Address(RVA = "0x1A93524", Offset = "0x1A93524", VA = "0x1A93524")]
			[DebuggerHidden]
			public <CoroutineQuerySystemParams>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x1A93550", Offset = "0x1A93550", VA = "0x1A93550", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x1A93554", Offset = "0x1A93554", VA = "0x1A93554", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x1A9372C", Offset = "0x1A9372C", VA = "0x1A9372C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FCCD0", Offset = "0x8FCCD0")]
		private bool <IsDebug>k__BackingField;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FCCE0", Offset = "0x8FCCE0")]
		private GameObject <EnvironmentGo>k__BackingField;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Coroutine _querySysKvCoroutine;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string[] _sysKvKeys;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, SystemParameter> _dicSysKv;

		[Token(Token = "0x1700004D")]
		public bool IsDebug
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x1366278", Offset = "0x1366278", VA = "0x1366278")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF01C", Offset = "0x8FF01C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x1366280", Offset = "0x1366280", VA = "0x1366280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF02C", Offset = "0x8FF02C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public GameObject EnvironmentGo
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x136628C", Offset = "0x136628C", VA = "0x136628C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF03C", Offset = "0x8FF03C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x1366294", Offset = "0x1366294", VA = "0x1366294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF04C", Offset = "0x8FF04C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x136629C", Offset = "0x136629C", VA = "0x136629C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1366474", Offset = "0x1366474", VA = "0x1366474", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x13664EC", Offset = "0x13664EC", VA = "0x13664EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x13665CC", Offset = "0x13665CC", VA = "0x13665CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x13666AC", Offset = "0x13666AC", VA = "0x13666AC", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1366718", Offset = "0x1366718", VA = "0x1366718")]
		public string GetSysKvStrValue(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x13667C8", Offset = "0x13667C8", VA = "0x13667C8")]
		public int GetSysKvIntValue(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1366878", Offset = "0x1366878", VA = "0x1366878")]
		public static GameObject CreateGameObject(GameObject prefab, Transform parent, [System.Runtime.InteropServices.Optional] string goName)
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1366408", Offset = "0x1366408", VA = "0x1366408")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FF05C", Offset = "0x8FF05C")]
		protected IEnumerator LoadingProcedure()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x136692C", Offset = "0x136692C", VA = "0x136692C")]
		private void OnOnNetworkTimeReady()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1366960", Offset = "0x1366960", VA = "0x1366960")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FF0BC", Offset = "0x8FF0BC")]
		protected IEnumerator CoroutineQuerySystemParams()
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x13669CC", Offset = "0x13669CC", VA = "0x13669CC")]
		protected void OnQuerySysKvFinished(eNetErr code, ResponseData resData, string rawData)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1366E34", Offset = "0x1366E34", VA = "0x1366E34")]
		public MainManager()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class ResponseData
	{
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCCF0", Offset = "0x8FCCF0")]
		public int Code;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCD28", Offset = "0x8FCD28")]
		public string Msg;

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x136C694", Offset = "0x136C694", VA = "0x136C694")]
		public ResponseData()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class ResponseData<T>
	{
		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCD60", Offset = "0x8FCD60")]
		public int Code;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCD98", Offset = "0x8FCD98")]
		public string Msg;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8FCDD0", Offset = "0x8FCDD0")]
		public T Data;

		[Token(Token = "0x6000226")]
		public ResponseData()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public enum eNetErr
	{
		[Token(Token = "0x40002B6")]
		Ok,
		[Token(Token = "0x40002B7")]
		Unreachable,
		[Token(Token = "0x40002B8")]
		NetError,
		[Token(Token = "0x40002B9")]
		TimedOut,
		[Token(Token = "0x40002BA")]
		NullRes,
		[Token(Token = "0x40002BB")]
		NullResData,
		[Token(Token = "0x40002BC")]
		Failed
	}
	[Token(Token = "0x2000080")]
	public enum eSvcErr
	{
		[Token(Token = "0x40002BE")]
		Ok = 0,
		[Token(Token = "0x40002BF")]
		Unknown = -1,
		[Token(Token = "0x40002C0")]
		SignCheckFailed = 1000,
		[Token(Token = "0x40002C1")]
		ParamsInvalid = 1001,
		[Token(Token = "0x40002C2")]
		RetryLater = 1002,
		[Token(Token = "0x40002C3")]
		SmsPhoneInvalid = 2000,
		[Token(Token = "0x40002C4")]
		SmsReachDayLimit = 2002,
		[Token(Token = "0x40002C5")]
		SmsUserRefused = 2003,
		[Token(Token = "0x40002C6")]
		LoginCodeWrong = 2004,
		[Token(Token = "0x40002C7")]
		LoginCodeExpired = 2005,
		[Token(Token = "0x40002C8")]
		WXMobileRequired = 2006,
		[Token(Token = "0x40002C9")]
		WXMobileMismatch = 2007,
		[Token(Token = "0x40002CA")]
		DistributionCodeInvalid = 2020,
		[Token(Token = "0x40002CB")]
		DistributionCodeAlreadyVerified = 2021,
		[Token(Token = "0x40002CC")]
		CodeVideoScheduleIsOff = 2022,
		[Token(Token = "0x40002CD")]
		CodeNoValidVideoTicket = 2023,
		[Token(Token = "0x40002CE")]
		DeviceParmaInvalid = 2010,
		[Token(Token = "0x40002CF")]
		LoginRequired = 2100
	}
	[Token(Token = "0x2000081")]
	public delegate void NetworkCallback(eNetErr netErr, ResponseData resData, string rawData);
	[Token(Token = "0x2000082")]
	[DisallowMultipleComponent]
	public class NetworkManager : SingletonMono<NetworkManager>
	{
		[Token(Token = "0x2000083")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAE04", Offset = "0x8FAE04")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string apiUrl;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NetworkCallback callback;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NetworkManager <>4__this;

			[Token(Token = "0x6000244")]
			[Address(RVA = "0x1A948DC", Offset = "0x1A948DC", VA = "0x1A948DC")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000245")]
			[Address(RVA = "0x1A948E4", Offset = "0x1A948E4", VA = "0x1A948E4")]
			internal void <GetRequest>b__0(HTTPRequest req, HTTPResponse res)
			{
			}
		}

		[Token(Token = "0x2000084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAE14", Offset = "0x8FAE14")]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string apiUrl;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NetworkCallback callback;

			[Token(Token = "0x6000246")]
			[Address(RVA = "0x1A950F8", Offset = "0x1A950F8", VA = "0x1A950F8")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x6000247")]
			[Address(RVA = "0x1A95100", Offset = "0x1A95100", VA = "0x1A95100")]
			internal void <PostRequest>b__0(HTTPRequest req, HTTPResponse res)
			{
			}
		}

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string GateSvrUrl;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string MainSvrUrl;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string AccessKey;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string SecretKey;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string SessionName;

		[Token(Token = "0x40002D5")]
		private const int HttpReqTimeout = 2;

		[Token(Token = "0x40002D6")]
		private const string ApiAppVersion = "/gate/api/v1/app/version/";

		[Token(Token = "0x40002D7")]
		private const string ApiSysParams = "/portal/api/v1/system/params";

		[Token(Token = "0x40002D8")]
		private const string ApiSmsCodeReq = "/portal/api/v1/user/smsCode";

		[Token(Token = "0x40002D9")]
		private const string ApiLoginReq = "/portal/api/v1/user/login";

		[Token(Token = "0x40002DA")]
		private const string ApiLogoutReq = "/portal/api/v1/user/logout";

		[Token(Token = "0x40002DB")]
		private const string ApiRefreshSession = "/portal/api/v1/user/session/refresh";

		[Token(Token = "0x40002DC")]
		private const string ApiReportDevice = "/portal/api/v1/user/report/device";

		[Token(Token = "0x40002DD")]
		private const string ApiBindDevice = "/portal/api/v1/user/device/bind";

		[Token(Token = "0x40002DE")]
		private const string ApiQueryPerformance = "/portal/api/v1/user/performance/query";

		[Token(Token = "0x40002DF")]
		private const string ApiVeriyDistributionCode = "/portal/api/v1/user/code/verify";

		[Token(Token = "0x40002E0")]
		private const string ApiQueryOrders = "/portal/api/v1/user/order/list";

		[Token(Token = "0x40002E1")]
		private const string ApiVideoRequest = "/portal/api/v1/user/video/request";

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DateTime _cltTimeSnapshot;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TimeSpan _svrTimeSnapshot;

		[Token(Token = "0x17000053")]
		public DateTime SvrTime
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x1369574", Offset = "0x1369574", VA = "0x1369574")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000054")]
		public long SvrTimestamp
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x1369648", Offset = "0x1369648", VA = "0x1369648")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000055")]
		public bool IsUserLogined
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x1369700", Offset = "0x1369700", VA = "0x1369700")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x13674AC", Offset = "0x13674AC", VA = "0x13674AC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1368278", Offset = "0x1368278", VA = "0x1368278")]
		public void QueryAppVersion(string platName, NetworkCallback callback)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x13684E0", Offset = "0x13684E0", VA = "0x13684E0")]
		public void QuerySystemParams(string keys, NetworkCallback callback)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1368DAC", Offset = "0x1368DAC", VA = "0x1368DAC")]
		public void RequstSmsCode(string phone, NetworkCallback callback)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1368EB0", Offset = "0x1368EB0", VA = "0x1368EB0")]
		public void PhoneLogin(string phone, string smscode, NetworkCallback callback)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1368FE8", Offset = "0x1368FE8", VA = "0x1368FE8")]
		public void Logout(NetworkCallback callback)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1369068", Offset = "0x1369068", VA = "0x1369068")]
		public void RefreshSession(NetworkCallback callback)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x13690E8", Offset = "0x13690E8", VA = "0x13690E8")]
		public void ReportDevice(string deviceInfo, NetworkCallback callback)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1369158", Offset = "0x1369158", VA = "0x1369158")]
		public void BindDevice(string deviceInfo, NetworkCallback callback)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x13691C8", Offset = "0x13691C8", VA = "0x13691C8")]
		public void QueryPerformance(uint id, NetworkCallback callback)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x13692DC", Offset = "0x13692DC", VA = "0x13692DC")]
		public void VeriyDistributionCode(string code, NetworkCallback callback)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x13693E0", Offset = "0x13693E0", VA = "0x13693E0")]
		public void QueryOrders(NetworkCallback callback)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1369460", Offset = "0x1369460", VA = "0x1369460")]
		public void VideoRequest(uint id, NetworkCallback callback)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1369840", Offset = "0x1369840", VA = "0x1369840")]
		public void OnUserLogout(HTTPResponse response)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x13682F0", Offset = "0x13682F0", VA = "0x13682F0")]
		private void GetRequest(string svrUrl, string apiUrl, NetworkCallback callback)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x13685E4", Offset = "0x13685E4", VA = "0x13685E4")]
		private void PostRequest(string svrUrl, string apiUrl, Dictionary<string, string> dataParams, string body, bool useCookie, NetworkCallback callback)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x136971C", Offset = "0x136971C", VA = "0x136971C")]
		private Cookie GetCookie()
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1369844", Offset = "0x1369844", VA = "0x1369844")]
		private string CalcSignature(SortedDictionary<string, string> allParams)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1369C08", Offset = "0x1369C08", VA = "0x1369C08")]
		private void SetServerTime(string utcTime)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1369CE0", Offset = "0x1369CE0", VA = "0x1369CE0")]
		public void ShowCommonNetError(eNetErr code, [System.Runtime.InteropServices.Optional] Action onOk)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1369F9C", Offset = "0x1369F9C", VA = "0x1369F9C")]
		public NetworkManager()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x136A098", Offset = "0x136A098", VA = "0x136A098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF1BC", Offset = "0x8FF1BC")]
		private bool <GetCookie>b__42_0(Cookie c)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000085")]
	[DisallowMultipleComponent]
	public class PlayerManager : SingletonMono<PlayerManager>
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FCE08", Offset = "0x8FCE08")]
		private uint <Uid>k__BackingField;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FCE18", Offset = "0x8FCE18")]
		private string <Phone>k__BackingField;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _hasDeviceReport;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool _hasDeviceBind;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _deviceUUID;

		[Token(Token = "0x17000056")]
		public uint Uid
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x136AAC0", Offset = "0x136AAC0", VA = "0x136AAC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF1CC", Offset = "0x8FF1CC")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x136AAC8", Offset = "0x136AAC8", VA = "0x136AAC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF1DC", Offset = "0x8FF1DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public string Phone
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x136AAD0", Offset = "0x136AAD0", VA = "0x136AAD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF1EC", Offset = "0x8FF1EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x136AAD8", Offset = "0x136AAD8", VA = "0x136AAD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF1FC", Offset = "0x8FF1FC")]
			private set
			{
			}
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x136AAE0", Offset = "0x136AAE0", VA = "0x136AAE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x136AC7C", Offset = "0x136AC7C", VA = "0x136AC7C", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x136ACF4", Offset = "0x136ACF4", VA = "0x136ACF4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x136AECC", Offset = "0x136AECC", VA = "0x136AECC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x136B0A4", Offset = "0x136B0A4", VA = "0x136B0A4")]
		public void SetPrefsString(string key, string value)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x136B0C8", Offset = "0x136B0C8", VA = "0x136B0C8")]
		public void SetPrefsInt(string key, int value)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x136AB34", Offset = "0x136AB34", VA = "0x136AB34")]
		private void LoadUserInfo()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x136B0EC", Offset = "0x136B0EC", VA = "0x136B0EC")]
		private void OnUserLogined(string rawData)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x136B920", Offset = "0x136B920", VA = "0x136B920")]
		private void OnLoginSessionRefreshed()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x136BC5C", Offset = "0x136BC5C", VA = "0x136BC5C")]
		private void OnOnNetworkTimeReady()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x136BCE0", Offset = "0x136BCE0", VA = "0x136BCE0")]
		private void ReportDevice()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x136B76C", Offset = "0x136B76C", VA = "0x136B76C")]
		private void BindDevice()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x136BEC8", Offset = "0x136BEC8", VA = "0x136BEC8")]
		protected void OnReportDeviceFinished(eNetErr code, ResponseData resData, string _)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x136C1C0", Offset = "0x136C1C0", VA = "0x136C1C0")]
		protected void OnBindDeviceFinished(eNetErr code, ResponseData resData, string _)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x136C4F4", Offset = "0x136C4F4", VA = "0x136C4F4")]
		public PlayerManager()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[DisallowMultipleComponent]
	public class SDKManager : SingletonMono<SDKManager>
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FCE28", Offset = "0x8FCE28")]
		private Transform <HeadTransform>k__BackingField;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _appId;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _appSecret;

		[Token(Token = "0x17000058")]
		public Transform HeadTransform
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x150D470", Offset = "0x150D470", VA = "0x150D470")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF20C", Offset = "0x8FF20C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x150D478", Offset = "0x150D478", VA = "0x150D478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF21C", Offset = "0x8FF21C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public string PlatformName
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x150D480", Offset = "0x150D480", VA = "0x150D480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public string AppId
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x150D4C4", Offset = "0x150D4C4", VA = "0x150D4C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public string AppSecret
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x150D4CC", Offset = "0x150D4CC", VA = "0x150D4CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x150D4D4", Offset = "0x150D4D4", VA = "0x150D4D4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x150DDA4", Offset = "0x150DDA4", VA = "0x150DDA4")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x150DDF8", Offset = "0x150DDF8", VA = "0x150DDF8")]
		public SDKManager()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[DisallowMultipleComponent]
	public class UIManager : SingletonMono<UIManager>
	{
		[Token(Token = "0x2000088")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAE54", Offset = "0x8FAE54")]
		private sealed class <InitProcedure>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIManager <>4__this;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform <uiLayerRoot>5__2;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Transform <uiCurveLayerBottom>5__3;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Transform <uiCurveLayerTop>5__4;

			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <request>5__5;

			[Token(Token = "0x1700005D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600027A")]
				[Address(RVA = "0x1A97FA4", Offset = "0x1A97FA4", VA = "0x1A97FA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600027C")]
				[Address(RVA = "0x1A97FEC", Offset = "0x1A97FEC", VA = "0x1A97FEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0x1A978C0", Offset = "0x1A978C0", VA = "0x1A978C0")]
			[DebuggerHidden]
			public <InitProcedure>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000278")]
			[Address(RVA = "0x1A978EC", Offset = "0x1A978EC", VA = "0x1A978EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0x1A978F0", Offset = "0x1A978F0", VA = "0x1A978F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0x1A97FAC", Offset = "0x1A97FAC", VA = "0x1A97FAC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FCE38", Offset = "0x8FCE38")]
		private Transform <PlaneUIRoot>k__BackingField;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<eUIType, UIBasePanel> _uiDictionary;

		[Token(Token = "0x1700005C")]
		public Transform PlaneUIRoot
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x145BDD0", Offset = "0x145BDD0", VA = "0x145BDD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF22C", Offset = "0x8FF22C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x145BDD8", Offset = "0x145BDD8", VA = "0x145BDD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF23C", Offset = "0x8FF23C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x145BDE0", Offset = "0x145BDE0", VA = "0x145BDE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x145BE70", Offset = "0x145BE70", VA = "0x145BE70", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x145BEF0", Offset = "0x145BEF0", VA = "0x145BEF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x145C228", Offset = "0x145C228", VA = "0x145C228")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x145C554", Offset = "0x145C554", VA = "0x145C554", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x145C5C8", Offset = "0x145C5C8", VA = "0x145C5C8")]
		public void RegisterUIPanel(UIBasePanel panel)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x145C6D8", Offset = "0x145C6D8", VA = "0x145C6D8")]
		public void UnRegisterUIPanel(UIBasePanel panel)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x145C7E4", Offset = "0x145C7E4", VA = "0x145C7E4")]
		public bool IsPanelShow(eUIType type)
		{
			return default(bool);
		}

		[Token(Token = "0x600026D")]
		public T GetPanel<T>(eUIType type) where T : UIBasePanel
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		public T GetPanel<T>() where T : UIBasePanel
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x145C890", Offset = "0x145C890", VA = "0x145C890")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FF24C", Offset = "0x8FF24C")]
		public IEnumerator InitProcedure()
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x145C8FC", Offset = "0x145C8FC", VA = "0x145C8FC")]
		public void ShowHomePage()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x145C98C", Offset = "0x145C98C", VA = "0x145C98C")]
		private void OnBackBtnClicked(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x145CA8C", Offset = "0x145CA8C", VA = "0x145CA8C")]
		protected void OnLoginSessionExpired()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x145CC34", Offset = "0x145CC34", VA = "0x145CC34")]
		protected void OnBeforeVideoPlaying(PlayVideoParams _)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x145CE4C", Offset = "0x145CE4C", VA = "0x145CE4C")]
		protected void OnAfterVideoPlaying()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x145D004", Offset = "0x145D004", VA = "0x145D004")]
		public UIManager()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x145D050", Offset = "0x145D050", VA = "0x145D050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF2AC", Offset = "0x8FF2AC")]
		private void <OnLoginSessionExpired>b__18_0()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[DisallowMultipleComponent]
	public class VideoManager : SingletonMono<VideoManager>
	{
		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAE74", Offset = "0x8FAE74")]
		private sealed class <InitProcedure>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VideoManager <>4__this;

			[Token(Token = "0x1700005F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600028F")]
				[Address(RVA = "0x1A9BB74", Offset = "0x1A9BB74", VA = "0x1A9BB74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000060")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000291")]
				[Address(RVA = "0x1A9BBBC", Offset = "0x1A9BBBC", VA = "0x1A9BBBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600028C")]
			[Address(RVA = "0x1A9B9C8", Offset = "0x1A9B9C8", VA = "0x1A9B9C8")]
			[DebuggerHidden]
			public <InitProcedure>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0x1A9B9F4", Offset = "0x1A9B9F4", VA = "0x1A9B9F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0x1A9B9F8", Offset = "0x1A9B9F8", VA = "0x1A9B9F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x1A9BB7C", Offset = "0x1A9BB7C", VA = "0x1A9BB7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _sphereVideoPrefab;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MediaPlayer _mediaPlayer;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject _videoBackground;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject _videoPlayerRoot;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _videoSphereMat;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Controller[] _controllers;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PlayVideoParams _currentVideoParams;

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1468A10", Offset = "0x1468A10", VA = "0x1468A10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1468A5C", Offset = "0x1468A5C", VA = "0x1468A5C", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1468B28", Offset = "0x1468B28", VA = "0x1468B28")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1468D28", Offset = "0x1468D28", VA = "0x1468D28")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1468F28", Offset = "0x1468F28", VA = "0x1468F28", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1469458", Offset = "0x1469458", VA = "0x1469458")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FF30C", Offset = "0x8FF30C")]
		public IEnumerator InitProcedure()
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x14612A4", Offset = "0x14612A4", VA = "0x14612A4")]
		public void StopVideo()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x14694C4", Offset = "0x14694C4", VA = "0x14694C4")]
		protected void LateUpdate()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x14695C8", Offset = "0x14695C8", VA = "0x14695C8")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1469770", Offset = "0x1469770", VA = "0x1469770")]
		protected void OnBeforeVideoPlaying(PlayVideoParams videoParams)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x146A658", Offset = "0x146A658", VA = "0x146A658")]
		protected void OnBackToLoginPage()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x146A65C", Offset = "0x146A65C", VA = "0x146A65C")]
		protected void OnUIPanelVisibleChanged(eUIType uiType, bool visible)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1469234", Offset = "0x1469234", VA = "0x1469234")]
		protected bool ShouldMediaBeCached()
		{
			return default(bool);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x146A894", Offset = "0x146A894", VA = "0x146A894")]
		protected void OnMediaPlayerEvent(MediaPlayer mp, MediaPlayerEvent.EventType eventType, ErrorCode code)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x146B098", Offset = "0x146B098", VA = "0x146B098")]
		public VideoManager()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class UIAppLoading : UIBasePanel
	{
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Slider Slider;

		[Token(Token = "0x17000061")]
		public override eUIType PanelType
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x151CCBC", Offset = "0x151CCBC", VA = "0x151CCBC", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x151CCC4", Offset = "0x151CCC4", VA = "0x151CCC4", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x151CD98", Offset = "0x151CD98", VA = "0x151CD98", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x151CE7C", Offset = "0x151CE7C", VA = "0x151CE7C")]
		public UIAppLoading()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class UIAppUpdate : UIBasePanel
	{
		[Token(Token = "0x200008D")]
		private enum ePanelMode
		{
			[Token(Token = "0x4000313")]
			UI_PANEL_ALERT,
			[Token(Token = "0x4000314")]
			UI_PANEL_DOWNLOAD,
			[Token(Token = "0x4000315")]
			UI_PANEL_HINT_PICO1,
			[Token(Token = "0x4000316")]
			UI_PANEL_HINT_PICO2,
			[Token(Token = "0x4000317")]
			UI_PANEL_HINT_IQIYI_1
		}

		[Serializable]
		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAE84", Offset = "0x8FAE84")]
		private sealed class <>c
		{
			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static UnityAction <>9__18_0;

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x1A97708", Offset = "0x1A97708", VA = "0x1A97708")]
			public <>c()
			{
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1A97710", Offset = "0x1A97710", VA = "0x1A97710")]
			internal void <Init>b__18_0()
			{
			}
		}

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AppVerInfo _latestAppVersionInfo;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _savedApkFilePath;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _panelUpdateAlert;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _panelDownloadApk;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _panelHintPico1;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform _panelHintPico2;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _panelHintiQiyi1;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Text _releaseNoteTxt;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Button _downloadBtn;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Slider _downloadProgress;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _rotatingLogo;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string _apkCacheFolder;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ResumableDownloader _downloader;

		[Token(Token = "0x17000062")]
		public override eUIType PanelType
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x151CE8C", Offset = "0x151CE8C", VA = "0x151CE8C", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x151CE94", Offset = "0x151CE94", VA = "0x151CE94", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x151CEC0", Offset = "0x151CEC0", VA = "0x151CEC0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x151D07C", Offset = "0x151D07C", VA = "0x151D07C", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x151D7D4", Offset = "0x151D7D4", VA = "0x151D7D4")]
		private void ShowUIPanel(ePanelMode mode)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x151DB80", Offset = "0x151DB80", VA = "0x151DB80")]
		public void Enter()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x151DCE0", Offset = "0x151DCE0", VA = "0x151DCE0")]
		protected void Leave()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x151DD98", Offset = "0x151DD98", VA = "0x151DD98", Slot = "11")]
		public override void Show()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x151DED8", Offset = "0x151DED8", VA = "0x151DED8", Slot = "12")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x151DB84", Offset = "0x151DB84", VA = "0x151DB84")]
		protected void QueryVersion()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x151E014", Offset = "0x151E014", VA = "0x151E014")]
		protected void QueryVersionLater()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x151E098", Offset = "0x151E098", VA = "0x151E098")]
		protected void OnUpdateBtnClicked()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x151E83C", Offset = "0x151E83C", VA = "0x151E83C")]
		protected void OnApkDownloadSucceed()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x151EAE8", Offset = "0x151EAE8", VA = "0x151EAE8")]
		protected void DoInstallApk()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x151EC54", Offset = "0x151EC54", VA = "0x151EC54")]
		protected void OnApkDownloadFailed(string msg)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x151EDDC", Offset = "0x151EDDC", VA = "0x151EDDC")]
		protected void OnApkDownloadProgress(long downloaded, long contentLength)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x151EE10", Offset = "0x151EE10", VA = "0x151EE10")]
		protected void OnHttpRequestFinished(eNetErr code, ResponseData resData, string rawData)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x151F6AC", Offset = "0x151F6AC", VA = "0x151F6AC")]
		protected void DeleteCachedApks()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x151FAF0", Offset = "0x151FAF0", VA = "0x151FAF0")]
		public UIAppUpdate()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x151FAF8", Offset = "0x151FAF8", VA = "0x151FAF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF3BC", Offset = "0x8FF3BC")]
		private void <DoInstallApk>b__28_0()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x151FB7C", Offset = "0x151FB7C", VA = "0x151FB7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF3CC", Offset = "0x8FF3CC")]
		private void <OnApkDownloadFailed>b__29_0()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public enum eUIType
	{
		[Token(Token = "0x400031B")]
		UI_TYPE_NONE,
		[Token(Token = "0x400031C")]
		UI_APP_LOADING,
		[Token(Token = "0x400031D")]
		UI_SCREEN_MASK,
		[Token(Token = "0x400031E")]
		UI_APP_UPDATE,
		[Token(Token = "0x400031F")]
		UI_SMS_LOGIN,
		[Token(Token = "0x4000320")]
		UI_HOME_PAGE,
		[Token(Token = "0x4000321")]
		UI_STATUS_BAR,
		[Token(Token = "0x4000322")]
		UI_ORDER_PAGE,
		[Token(Token = "0x4000323")]
		UI_DETAIL_PAGE,
		[Token(Token = "0x4000324")]
		UI_VIDEO_PLAY,
		[Token(Token = "0x4000325")]
		UI_VIDEO_BUFFERING,
		[Token(Token = "0x4000326")]
		UI_DETAIL_FLOATING,
		[Token(Token = "0x4000327")]
		UI_CODE_CHECK,
		[Token(Token = "0x4000328")]
		UI_BUY_FLOATING,
		[Token(Token = "0x4000329")]
		UI_MESSAGE_BOX,
		[Token(Token = "0x400032A")]
		UI_TYPE_MAX
	}
	[Token(Token = "0x2000090")]
	public abstract class UIBasePanel : MonoBehaviour
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FCE48", Offset = "0x8FCE48")]
		private bool <IsShow>k__BackingField;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool _started;

		[Token(Token = "0x17000063")]
		public abstract eUIType PanelType
		{
			[Token(Token = "0x60002AE")]
			get;
		}

		[Token(Token = "0x17000064")]
		public bool IsShow
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x151FC00", Offset = "0x151FC00", VA = "0x151FC00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF3DC", Offset = "0x8FF3DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x151FC08", Offset = "0x151FC08", VA = "0x151FC08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF3EC", Offset = "0x8FF3EC")]
			protected set
			{
			}
		}

		[Token(Token = "0x60002B1")]
		protected abstract void Init();

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x151CCF0", Offset = "0x151CCF0", VA = "0x151CCF0", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x151CF60", Offset = "0x151CF60", VA = "0x151CF60", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x151FC14", Offset = "0x151FC14", VA = "0x151FC14", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x151FC94", Offset = "0x151FC94", VA = "0x151FC94", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x151FC98", Offset = "0x151FC98", VA = "0x151FC98", Slot = "10")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x151DE14", Offset = "0x151DE14", VA = "0x151DE14", Slot = "11")]
		public virtual void Show()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x151DF54", Offset = "0x151DF54", VA = "0x151DF54", Slot = "12")]
		public virtual void Hide()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x151FC9C", Offset = "0x151FC9C", VA = "0x151FC9C", Slot = "13")]
		public virtual bool OnBackBtnClicked()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x151CE84", Offset = "0x151CE84", VA = "0x151CE84")]
		protected UIBasePanel()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class UIBuyFloating : UIBasePanel
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _fadeBackgroud;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Button _3rdSmsBtn;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _pointerCount;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DG.Tweening.Tween _fadeInTween;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DG.Tweening.Tween _fadeOutTween;

		[Token(Token = "0x17000065")]
		public override eUIType PanelType
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x151FCA4", Offset = "0x151FCA4", VA = "0x151FCA4", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x151FCAC", Offset = "0x151FCAC", VA = "0x151FCAC", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x151FCD8", Offset = "0x151FCD8", VA = "0x151FCD8", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x15200F0", Offset = "0x15200F0", VA = "0x15200F0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1520234", Offset = "0x1520234", VA = "0x1520234", Slot = "11")]
		public override void Show()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1520354", Offset = "0x1520354", VA = "0x1520354")]
		protected void OnPointerEnterBackgroud(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x15204D4", Offset = "0x15204D4", VA = "0x15204D4")]
		protected void OnPointerExitBackgroud(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1520370", Offset = "0x1520370", VA = "0x1520370")]
		public void FadeIn()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1520674", Offset = "0x1520674", VA = "0x1520674")]
		public void FadeOut()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x15207B4", Offset = "0x15207B4", VA = "0x15207B4", Slot = "12")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x15208A0", Offset = "0x15208A0", VA = "0x15208A0", Slot = "13")]
		public override bool OnBackBtnClicked()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x15208D0", Offset = "0x15208D0", VA = "0x15208D0")]
		protected void OnUIPanelVisibleChanged(eUIType uiType, bool visible)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x15208F4", Offset = "0x15208F4", VA = "0x15208F4")]
		public UIBuyFloating()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x15208FC", Offset = "0x15208FC", VA = "0x15208FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF3FC", Offset = "0x8FF3FC")]
		private void <FadeIn>b__14_0()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class UICodeCheck : UIBasePanel
	{
		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAE94", Offset = "0x8FAE94")]
		private sealed class <ShowErrorMsgCo>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float secs;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UICodeCheck <>4__this;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002DA")]
				[Address(RVA = "0x1A97844", Offset = "0x1A97844", VA = "0x1A97844", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002DC")]
				[Address(RVA = "0x1A9788C", Offset = "0x1A9788C", VA = "0x1A9788C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x1A97718", Offset = "0x1A97718", VA = "0x1A97718")]
			[DebuggerHidden]
			public <ShowErrorMsgCo>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x1A97744", Offset = "0x1A97744", VA = "0x1A97744", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x1A97748", Offset = "0x1A97748", VA = "0x1A97748", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x1A9784C", Offset = "0x1A9784C", VA = "0x1A9784C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _maxDigitCount;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text _purchasePromptMsgText;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text _performanceInfoText;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Text _errorPromptMsgText;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InputField _codeInput;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _toCheckBtn;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Button _checkedBtn;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Coroutine _coroutineErrorMsg;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float prevUpdateTime;

		[Token(Token = "0x17000066")]
		public override eUIType PanelType
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1520904", Offset = "0x1520904", VA = "0x1520904", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x152090C", Offset = "0x152090C", VA = "0x152090C", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1520938", Offset = "0x1520938", VA = "0x1520938", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1520D10", Offset = "0x1520D10", VA = "0x1520D10", Slot = "11")]
		public override void Show()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1520ECC", Offset = "0x1520ECC", VA = "0x1520ECC", Slot = "12")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1520F60", Offset = "0x1520F60", VA = "0x1520F60", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1520FE4", Offset = "0x1520FE4", VA = "0x1520FE4", Slot = "13")]
		public override bool OnBackBtnClicked()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1521014", Offset = "0x1521014", VA = "0x1521014")]
		public void OnKeyDown(string key)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1521074", Offset = "0x1521074", VA = "0x1521074")]
		public void OnDelDown()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x15210D0", Offset = "0x15210D0", VA = "0x15210D0")]
		protected void ShowPromptMsg(string msg, float secs = 2f)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1521178", Offset = "0x1521178", VA = "0x1521178")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FF40C", Offset = "0x8FF40C")]
		private IEnumerator ShowErrorMsgCo(float secs)
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x15211F4", Offset = "0x15211F4", VA = "0x15211F4")]
		protected void OnCheckBtnClicked()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x15213AC", Offset = "0x15213AC", VA = "0x15213AC")]
		protected void OnVeriyDistributionCodeFinished(eNetErr code, ResponseData resData, string rawData)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1521BBC", Offset = "0x1521BBC", VA = "0x1521BBC")]
		public UICodeCheck()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class UIDetailFloating : UIBasePanel
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _fadeBackgroud;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PerformanceInfo _performanceInfo;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Button _shareButton;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _downloadButton;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Button _favoriteButton;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Button _playButton;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Button _tryoutButton;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Text _countDownLabelTxt;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Text _countDownTimeTxt;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Text _countDownOverTxt;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _pointerCount;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DG.Tweening.Tween _fadeInTween;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private DG.Tweening.Tween _fadeOutTween;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float prevUpdateTime;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float _prevClickTime;

		[Token(Token = "0x17000069")]
		public override eUIType PanelType
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x1521BC4", Offset = "0x1521BC4", VA = "0x1521BC4", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1521BCC", Offset = "0x1521BCC", VA = "0x1521BCC", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1521BF8", Offset = "0x1521BF8", VA = "0x1521BF8", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1522310", Offset = "0x1522310", VA = "0x1522310", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1522454", Offset = "0x1522454", VA = "0x1522454")]
		public void SetPerformaceInfo(PerformanceInfo info)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x152245C", Offset = "0x152245C", VA = "0x152245C")]
		protected void OnPointerEnterBackgroud(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x15225DC", Offset = "0x15225DC", VA = "0x15225DC")]
		protected void OnPointerExitBackgroud(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1522478", Offset = "0x1522478", VA = "0x1522478")]
		public void FadeIn()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x152277C", Offset = "0x152277C", VA = "0x152277C")]
		public void FadeOut()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x15228BC", Offset = "0x15228BC", VA = "0x15228BC", Slot = "11")]
		public override void Show()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1522F3C", Offset = "0x1522F3C", VA = "0x1522F3C", Slot = "12")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1523028", Offset = "0x1523028", VA = "0x1523028", Slot = "13")]
		public override bool OnBackBtnClicked()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1523058", Offset = "0x1523058", VA = "0x1523058")]
		protected void OnUIPanelVisibleChanged(eUIType uiType, bool visible)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x152307C", Offset = "0x152307C", VA = "0x152307C")]
		protected void Update()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1522940", Offset = "0x1522940", VA = "0x1522940")]
		protected void UpdateUI()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x15230D0", Offset = "0x15230D0", VA = "0x15230D0")]
		protected void OnPlayBtnClicked()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x15235CC", Offset = "0x15235CC", VA = "0x15235CC")]
		protected void OnDownloadBtnClicked()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x15235D0", Offset = "0x15235D0", VA = "0x15235D0")]
		protected void OnTryoutBtnClicked()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x152381C", Offset = "0x152381C", VA = "0x152381C")]
		protected void OnVideoRequestFinished(eNetErr code, ResponseData resData, string rawData)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1524150", Offset = "0x1524150", VA = "0x1524150")]
		public UIDetailFloating()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1524158", Offset = "0x1524158", VA = "0x1524158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF4BC", Offset = "0x8FF4BC")]
		private void <FadeIn>b__22_0()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class UIDetailPage : UIBasePanel
	{
		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAEA4", Offset = "0x8FAEA4")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Toggle toggle;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIDetailPage <>4__this;

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x1A97894", Offset = "0x1A97894", VA = "0x1A97894")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x1A9789C", Offset = "0x1A9789C", VA = "0x1A9789C")]
			internal void <Init>b__0(bool <p0>)
			{
			}
		}

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _3dPosterMeshList;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PerformanceInfo _performanceInfo;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Text _performanceNameTxt;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Text _performanceDescTxt;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text _commodityNameTxt;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Text _commodityPriceTxt;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Text _startTimeTxt;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Text _endTimeTxt;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Text _promptTxt;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Text _3rdCodePromptTxt;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Button _codeToCheckBtn;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Button _codeCheckedBtn;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Button _purchaseBtn;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Color _noramlTimeColor;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Color _noramlPromptColor;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Color _noraml3rdCodePromptColor;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Color _expiredTimeColor;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Toggle[] _bitrateBtns;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ToggleGroup _toggleGroup;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected Dictionary<string, Toggle> _tagDictionary;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float prevUpdateTime;

		[Token(Token = "0x1700006A")]
		public override eUIType PanelType
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x1457D44", Offset = "0x1457D44", VA = "0x1457D44", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1457D4C", Offset = "0x1457D4C", VA = "0x1457D4C", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1457D7C", Offset = "0x1457D7C", VA = "0x1457D7C", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1458A64", Offset = "0x1458A64", VA = "0x1458A64", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1458C3C", Offset = "0x1458C3C", VA = "0x1458C3C", Slot = "11")]
		public override void Show()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1458DF8", Offset = "0x1458DF8", VA = "0x1458DF8", Slot = "12")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1458F08", Offset = "0x1458F08", VA = "0x1458F08")]
		private void OnPointerEnter(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1458FAC", Offset = "0x1458FAC", VA = "0x1458FAC")]
		public void SetPerformaceInfo(PerformanceInfo info)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x14599E4", Offset = "0x14599E4", VA = "0x14599E4")]
		public int GetSelectedTrackId()
		{
			return default(int);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1459AA4", Offset = "0x1459AA4", VA = "0x1459AA4")]
		protected void Update()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1459AF8", Offset = "0x1459AF8", VA = "0x1459AF8")]
		protected void UpdateTimeRelatedUI()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1458FB4", Offset = "0x1458FB4", VA = "0x1458FB4")]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1459E78", Offset = "0x1459E78", VA = "0x1459E78", Slot = "13")]
		public override bool OnBackBtnClicked()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1459EA8", Offset = "0x1459EA8", VA = "0x1459EA8")]
		protected void OnCodeCheckBtnClicked()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x145A0C0", Offset = "0x145A0C0", VA = "0x145A0C0")]
		protected void OnPurchaseBtnClicked()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x145A2D4", Offset = "0x145A2D4", VA = "0x145A2D4")]
		protected void OnDistributionCodeVerified(VideoScheduleInfo resultInfo)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x145A3F8", Offset = "0x145A3F8", VA = "0x145A3F8")]
		protected void OnQueryPerformanceFinished(eNetErr code, ResponseData resData, string rawData)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x145A6C0", Offset = "0x145A6C0", VA = "0x145A6C0")]
		protected void OnBitrateBtnValueChanged(Toggle btn)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x145A750", Offset = "0x145A750", VA = "0x145A750")]
		public UIDetailPage()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class UIHomePage : UIBasePanel
	{
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text[] _unavailableTxts;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _prevClickTime;

		[Token(Token = "0x1700006B")]
		public override eUIType PanelType
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x145A7C8", Offset = "0x145A7C8", VA = "0x145A7C8", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x145A7D0", Offset = "0x145A7D0", VA = "0x145A7D0", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x145A800", Offset = "0x145A800", VA = "0x145A800", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x145AB98", Offset = "0x145AB98", VA = "0x145AB98")]
		protected void OnPosterClicked(uint performaceId)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x145ACB8", Offset = "0x145ACB8", VA = "0x145ACB8")]
		protected void OnUIPanelVisibleChanged(eUIType uiType, bool visible)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x145AD8C", Offset = "0x145AD8C", VA = "0x145AD8C")]
		protected void OnQueryPerformanceFinished(eNetErr code, ResponseData resData, string rawData)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x145B42C", Offset = "0x145B42C", VA = "0x145B42C")]
		protected void OnOrderBtnClicked()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x145B544", Offset = "0x145B544", VA = "0x145B544")]
		protected void OnQueryOrdersFinished(eNetErr code, ResponseData resData, string rawData)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x145BA7C", Offset = "0x145BA7C", VA = "0x145BA7C", Slot = "11")]
		public override void Show()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x145BBE8", Offset = "0x145BBE8", VA = "0x145BBE8", Slot = "12")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x145BC6C", Offset = "0x145BC6C", VA = "0x145BC6C", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x145BDB8", Offset = "0x145BDB8", VA = "0x145BDB8")]
		public UIHomePage()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x145BDC0", Offset = "0x145BDC0", VA = "0x145BDC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF4CC", Offset = "0x8FF4CC")]
		private void <Init>b__4_0()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x145BDC8", Offset = "0x145BDC8", VA = "0x145BDC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF4DC", Offset = "0x8FF4DC")]
		private void <Init>b__4_1()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public enum MsgBoxBtnType
	{
		[Token(Token = "0x400036A")]
		Yes,
		[Token(Token = "0x400036B")]
		YesNo
	}
	[Token(Token = "0x2000099")]
	public class UIMessageBox : UIBasePanel
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static UIMessageBox s_Instance;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Text _titleTxt;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Text _msgTxt;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Button _yes1Btn;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Button _yes2Btn;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Button _no2Btn;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Action _yesCallback;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Action _noCallback;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MsgBoxBtnType _currentMsgBoxType;

		[Token(Token = "0x1700006C")]
		public static UIMessageBox Instance
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x145D210", Offset = "0x145D210", VA = "0x145D210")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public override eUIType PanelType
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x145D25C", Offset = "0x145D25C", VA = "0x145D25C", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x145D264", Offset = "0x145D264", VA = "0x145D264", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x145D2CC", Offset = "0x145D2CC", VA = "0x145D2CC", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x145D328", Offset = "0x145D328", VA = "0x145D328", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x145B2EC", Offset = "0x145B2EC", VA = "0x145B2EC")]
		public void Show(MsgBoxBtnType t, string title, string msg, Action onOk, [System.Runtime.InteropServices.Optional] Action onNo)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x145D6A8", Offset = "0x145D6A8", VA = "0x145D6A8")]
		protected void OnYesBtnClicked()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x145D6E8", Offset = "0x145D6E8", VA = "0x145D6E8")]
		protected void OnNoBtnClicked()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x145D728", Offset = "0x145D728", VA = "0x145D728", Slot = "13")]
		public override bool OnBackBtnClicked()
		{
			return default(bool);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x145CC08", Offset = "0x145CC08", VA = "0x145CC08")]
		public void ForceClose()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x145D788", Offset = "0x145D788", VA = "0x145D788")]
		public UIMessageBox()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class UIOrderPage : UIBasePanel
	{
		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected OrderInfo[] _orderInfoList;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected int _currentPageIndex;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		protected int _currentOrderIndex;

		[Token(Token = "0x4000378")]
		protected const int _orderCountPerPage = 5;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Toggle[] _pageToggle;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Toggle[] _orderToggle;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected GameObject[] _placeHodler3DMesh;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected GameObject[] _valid3DMesh;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected GameObject[] _selected3DMesh;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected Transform _orderInfoRoot;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected Text _placeHoderText;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected Text _placeHoder2Text;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected Text _performanceNameTxt;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected Text _performanceDescTxt;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected Text _commodityNameTxt;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected Text _commodityPriceTxt;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected Text _startTimeTxt;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected Text _endTimeTxt;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected Text _orderOriginTxt;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected Text _ticketStatusTxt;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected Text _orderCreateTimeTxt;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		protected Text _ticketExpirationTimeTxt;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected Text _promptTxt;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text[] _unavailableTxts;

		[Token(Token = "0x1700006E")]
		public override eUIType PanelType
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x145D790", Offset = "0x145D790", VA = "0x145D790", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x145D798", Offset = "0x145D798", VA = "0x145D798", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x145D7C8", Offset = "0x145D7C8", VA = "0x145D7C8", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x145DA54", Offset = "0x145DA54", VA = "0x145DA54", Slot = "13")]
		public override bool OnBackBtnClicked()
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x145B988", Offset = "0x145B988", VA = "0x145B988")]
		public void SetOrderInfoList(OrderInfo[] resInfo)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x145DB64", Offset = "0x145DB64", VA = "0x145DB64", Slot = "11")]
		public override void Show()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x145E750", Offset = "0x145E750", VA = "0x145E750", Slot = "12")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x145E7D4", Offset = "0x145E7D4", VA = "0x145E7D4", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x145DD3C", Offset = "0x145DD3C", VA = "0x145DD3C")]
		protected void UpdateUI()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x145E860", Offset = "0x145E860", VA = "0x145E860")]
		protected void OnPageBtnClicked(bool isOn)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x145E940", Offset = "0x145E940", VA = "0x145E940")]
		protected void OnOrderBtnClicked(bool isOn)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x145E964", Offset = "0x145E964", VA = "0x145E964")]
		protected void UpdateSelectedOrderIdx()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x145DB00", Offset = "0x145DB00", VA = "0x145DB00")]
		protected int GetSelectedOrderItemIdx()
		{
			return default(int);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x145E9CC", Offset = "0x145E9CC", VA = "0x145E9CC")]
		public UIOrderPage()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class UIPlayPanel : UIBasePanel
	{
		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button[] _unavailableBtns;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MediaPlayer _mediaPlayer;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Text _currTimeTxt;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Text _totalTimeTxt;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text _tipTimeTxt;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Slider _timelineSlider;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Button _playButton;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Button _pauseButton;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Button _unmuteButton;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Button _muteButton;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Button _settingButton;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Button _hideButton;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Button _quitButton;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CanvasMesh _canvasMesh;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private HorizontalSegmentsPrimitive _segmentsBuffered;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _isHoveringOverTimeline;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RayInteractor _currentHoverRay;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool _wasPlayingBeforeTimelineDrag;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private XRITController[] _controllers;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Dictionary<Handedness, RayInteractor> _rayInteractorMaps;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 _muteBtnSrcPos;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _showTime;

		[Token(Token = "0x1700006F")]
		public override eUIType PanelType
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x145E9DC", Offset = "0x145E9DC", VA = "0x145E9DC", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x145E9E4", Offset = "0x145E9E4", VA = "0x145E9E4", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x145EA14", Offset = "0x145EA14", VA = "0x145EA14", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x145F668", Offset = "0x145F668", VA = "0x145F668", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x145F7B4", Offset = "0x145F7B4", VA = "0x145F7B4")]
		protected void OnBeforeVideoPlaying(PlayVideoParams videoParams)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x145F9F0", Offset = "0x145F9F0", VA = "0x145F9F0")]
		public void DoBeforeVideoStop()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x145FAF8", Offset = "0x145FAF8", VA = "0x145FAF8", Slot = "13")]
		public override bool OnBackBtnClicked()
		{
			return default(bool);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x145FB28", Offset = "0x145FB28", VA = "0x145FB28", Slot = "11")]
		public override void Show()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1460968", Offset = "0x1460968", VA = "0x1460968", Slot = "12")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1460A18", Offset = "0x1460A18", VA = "0x1460A18")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1460C14", Offset = "0x1460C14", VA = "0x1460C14")]
		protected void OnPlayBtnClicked()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1460E20", Offset = "0x1460E20", VA = "0x1460E20")]
		protected void OnPauseBtnClicked()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1460FE4", Offset = "0x1460FE4", VA = "0x1460FE4")]
		protected void OnMuteBtnClicked()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1461104", Offset = "0x1461104", VA = "0x1461104")]
		protected void OnUnmuteBtnClicked()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1461224", Offset = "0x1461224", VA = "0x1461224")]
		protected void OnQuitBtnClicked()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1461880", Offset = "0x1461880", VA = "0x1461880")]
		protected void OnMediaPlayerEvent(MediaPlayer mp, MediaPlayerEvent.EventType eventType, ErrorCode code)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x14618B8", Offset = "0x14618B8", VA = "0x14618B8")]
		protected void OnEventMetaDataReady()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x14619E0", Offset = "0x14619E0", VA = "0x14619E0")]
		protected void OnEventStarted()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x14619E4", Offset = "0x14619E4", VA = "0x14619E4")]
		protected void OnEventFinishedPlaying()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1461A70", Offset = "0x1461A70", VA = "0x1461A70")]
		protected void OnEventStartedBuffering()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1461A74", Offset = "0x1461A74", VA = "0x1461A74")]
		protected void OnEventFinishedBuffering()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1461A78", Offset = "0x1461A78", VA = "0x1461A78")]
		protected void OnEventStalled()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1461B20", Offset = "0x1461B20", VA = "0x1461B20")]
		protected void OnEventUnstalled()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x145FD6C", Offset = "0x145FD6C", VA = "0x145FD6C")]
		protected void UpdateUI()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1461BC8", Offset = "0x1461BC8", VA = "0x1461BC8")]
		private TimeRange GetTimelineRange()
		{
			return default(TimeRange);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x145F28C", Offset = "0x145F28C", VA = "0x145F28C")]
		private void CreateTimelineEvents()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1461DE4", Offset = "0x1461DE4", VA = "0x1461DE4")]
		public void OnTimeSliderBeginDrag(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1461FD0", Offset = "0x1461FD0", VA = "0x1461FD0")]
		public void OnTimeSliderDrag(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x14621DC", Offset = "0x14621DC", VA = "0x14621DC")]
		public void OnTimeSliderEndDrag(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1462324", Offset = "0x1462324", VA = "0x1462324")]
		public void OnTimelineBeginHover(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x14624C8", Offset = "0x14624C8", VA = "0x14624C8")]
		public void OnTimelineEndHover(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x14625FC", Offset = "0x14625FC", VA = "0x14625FC")]
		public UIPlayPanel()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class UIScreenMask : UIBasePanel
	{
		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAEB4", Offset = "0x8FAEB4")]
		private sealed class <TurnOff>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIScreenMask <>4__this;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x17000071")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600035E")]
				[Address(RVA = "0x1A980F0", Offset = "0x1A980F0", VA = "0x1A980F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000360")]
				[Address(RVA = "0x1A98138", Offset = "0x1A98138", VA = "0x1A98138", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0x1A97FF4", Offset = "0x1A97FF4", VA = "0x1A97FF4")]
			[DebuggerHidden]
			public <TurnOff>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x1A98020", Offset = "0x1A98020", VA = "0x1A98020", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0x1A98024", Offset = "0x1A98024", VA = "0x1A98024", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600035F")]
			[Address(RVA = "0x1A980F8", Offset = "0x1A980F8", VA = "0x1A980F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAEC4", Offset = "0x8FAEC4")]
		private sealed class <TurnOn>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIScreenMask <>4__this;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x17000073")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000364")]
				[Address(RVA = "0x1A9823C", Offset = "0x1A9823C", VA = "0x1A9823C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000366")]
				[Address(RVA = "0x1A98284", Offset = "0x1A98284", VA = "0x1A98284", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000361")]
			[Address(RVA = "0x1A98140", Offset = "0x1A98140", VA = "0x1A98140")]
			[DebuggerHidden]
			public <TurnOn>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1A9816C", Offset = "0x1A9816C", VA = "0x1A9816C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000363")]
			[Address(RVA = "0x1A98170", Offset = "0x1A98170", VA = "0x1A98170", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0x1A98244", Offset = "0x1A98244", VA = "0x1A98244", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAED4", Offset = "0x8FAED4")]
		private sealed class <TweenAlpha>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIScreenMask <>4__this;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float toAlpha;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float duration;

			[Token(Token = "0x17000075")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600036A")]
				[Address(RVA = "0x1A983AC", Offset = "0x1A983AC", VA = "0x1A983AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000076")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600036C")]
				[Address(RVA = "0x1A983F4", Offset = "0x1A983F4", VA = "0x1A983F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1A9828C", Offset = "0x1A9828C", VA = "0x1A9828C")]
			[DebuggerHidden]
			public <TweenAlpha>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000368")]
			[Address(RVA = "0x1A982B8", Offset = "0x1A982B8", VA = "0x1A982B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000369")]
			[Address(RVA = "0x1A982BC", Offset = "0x1A982BC", VA = "0x1A982BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x1A983B4", Offset = "0x1A983B4", VA = "0x1A983B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Tweener _tweener;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Image _image;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<eUIType> _uiPannelList;

		[Token(Token = "0x17000070")]
		public override eUIType PanelType
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x1462674", Offset = "0x1462674", VA = "0x1462674", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x146267C", Offset = "0x146267C", VA = "0x146267C", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x14626AC", Offset = "0x14626AC", VA = "0x14626AC", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1462750", Offset = "0x1462750", VA = "0x1462750", Slot = "9")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x14628C0", Offset = "0x14628C0", VA = "0x14628C0", Slot = "10")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1462A30", Offset = "0x1462A30", VA = "0x1462A30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FF4EC", Offset = "0x8FF4EC")]
		public IEnumerator TurnOff(float duration)
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1462AAC", Offset = "0x1462AAC", VA = "0x1462AAC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FF54C", Offset = "0x8FF54C")]
		public IEnumerator TurnOn(float duration)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1462B28", Offset = "0x1462B28", VA = "0x1462B28")]
		public void TurnOn(eUIType type)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1462C30", Offset = "0x1462C30", VA = "0x1462C30")]
		public void TurnOff(eUIType type)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1462D30", Offset = "0x1462D30", VA = "0x1462D30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FF5AC", Offset = "0x8FF5AC")]
		private IEnumerator TweenAlpha(float toAlpha, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1462DB0", Offset = "0x1462DB0", VA = "0x1462DB0")]
		private void OnUserLogined(string _)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1462DE0", Offset = "0x1462DE0", VA = "0x1462DE0")]
		private void OnLoginSessionRefreshed()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1462E10", Offset = "0x1462E10", VA = "0x1462E10")]
		public UIScreenMask()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class UISmsLogin : UIBasePanel
	{
		[Token(Token = "0x20000A1")]
		private enum InputMode
		{
			[Token(Token = "0x40003CE")]
			None,
			[Token(Token = "0x40003CF")]
			Phone,
			[Token(Token = "0x40003D0")]
			SmsCode
		}

		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAEE4", Offset = "0x8FAEE4")]
		private sealed class <ShowErrorMsgCo>d__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UISmsLogin <>4__this;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string msg;

			[Token(Token = "0x17000078")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600038F")]
				[Address(RVA = "0x1A987C8", Offset = "0x1A987C8", VA = "0x1A987C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000391")]
				[Address(RVA = "0x1A98810", Offset = "0x1A98810", VA = "0x1A98810", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x1A98644", Offset = "0x1A98644", VA = "0x1A98644")]
			[DebuggerHidden]
			public <ShowErrorMsgCo>d__48(int <>1__state)
			{
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x1A98670", Offset = "0x1A98670", VA = "0x1A98670", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600038E")]
			[Address(RVA = "0x1A98674", Offset = "0x1A98674", VA = "0x1A98674", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000390")]
			[Address(RVA = "0x1A987D0", Offset = "0x1A987D0", VA = "0x1A987D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAEF4", Offset = "0x8FAEF4")]
		private sealed class <ResendCountDownCo>d__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UISmsLogin <>4__this;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Text <txt>5__2;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <i>5__3;

			[Token(Token = "0x1700007A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000395")]
				[Address(RVA = "0x1A985F4", Offset = "0x1A985F4", VA = "0x1A985F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000397")]
				[Address(RVA = "0x1A9863C", Offset = "0x1A9863C", VA = "0x1A9863C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000392")]
			[Address(RVA = "0x1A983FC", Offset = "0x1A983FC", VA = "0x1A983FC")]
			[DebuggerHidden]
			public <ResendCountDownCo>d__49(int <>1__state)
			{
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0x1A98428", Offset = "0x1A98428", VA = "0x1A98428", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000394")]
			[Address(RVA = "0x1A9842C", Offset = "0x1A9842C", VA = "0x1A9842C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000396")]
			[Address(RVA = "0x1A985FC", Offset = "0x1A985FC", VA = "0x1A985FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color _inputNormalColor;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Color _inputFocusColor;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button[] _keyboardNumBtns;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _keyboardDelBtn;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _keyboardOkBtn;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _loginPanel;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform _keyboardPanel;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _userAgreePanel;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _privacyAgreePanel;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _phoneNumInputFocusImg;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image _smsCodeInputFocusImg;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Text _phoneNumInputText;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Text _phoneNumPlaceholderText;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Text _smsCodeInputText;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Text _smsCodePlaceholderText;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Text _promptMsgText;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Button _smsCodeReqBtn;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ScrollRect _userAgreeScrollRect;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ScrollRect _privacyAgreeScrollRect;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private InputMode _inputMode;

		[Token(Token = "0x40003C7")]
		private const int MaxPhoneNumLen = 11;

		[Token(Token = "0x40003C8")]
		private const int MaxSmsCodeLen = 6;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Coroutine _coroutineErrorMsg;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Coroutine _coroutineResendSms;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isSmsRequestSending;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _isLoginRequestSending;

		[Token(Token = "0x17000077")]
		public override eUIType PanelType
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x1462E88", Offset = "0x1462E88", VA = "0x1462E88", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1462E90", Offset = "0x1462E90", VA = "0x1462E90", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1462EC0", Offset = "0x1462EC0", VA = "0x1462EC0", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x145D16C", Offset = "0x145D16C", VA = "0x145D16C")]
		public void Enter()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1463D88", Offset = "0x1463D88", VA = "0x1463D88")]
		protected void Leave()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x14640CC", Offset = "0x14640CC", VA = "0x14640CC", Slot = "11")]
		public override void Show()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x14642A0", Offset = "0x14642A0", VA = "0x14642A0", Slot = "12")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1464324", Offset = "0x1464324", VA = "0x1464324", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x14643B0", Offset = "0x14643B0", VA = "0x14643B0")]
		public void OnPhoneNumInputSelect()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1464470", Offset = "0x1464470", VA = "0x1464470")]
		public void OnSmsCodeInputSelect()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1464530", Offset = "0x1464530", VA = "0x1464530")]
		public void HideKeyboardPanel()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x14645B0", Offset = "0x14645B0", VA = "0x14645B0")]
		public void OnKeyboardNumBtnClicked(string num)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x146475C", Offset = "0x146475C", VA = "0x146475C")]
		public void OnKeyboardDelBtnClicked()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1464950", Offset = "0x1464950", VA = "0x1464950")]
		public void OnKeyboardOkBtnClicked()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1464954", Offset = "0x1464954", VA = "0x1464954")]
		public void OnUserAgreeBtnClicked()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1464A70", Offset = "0x1464A70", VA = "0x1464A70")]
		public void OnPrivacyAgreeBtnClicked()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1464B8C", Offset = "0x1464B8C", VA = "0x1464B8C")]
		public void OnSmsCodeRequestBtnClicked()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1464DDC", Offset = "0x1464DDC", VA = "0x1464DDC")]
		public void OnLoginRequestBtnClicked()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1465084", Offset = "0x1465084", VA = "0x1465084")]
		public void OnCloseAgreementBtnClicked()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1463FF0", Offset = "0x1463FF0", VA = "0x1463FF0")]
		protected void ShowPromptMsg(string msg, bool isError = true)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1465128", Offset = "0x1465128", VA = "0x1465128")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FF6FC", Offset = "0x8FF6FC")]
		private IEnumerator ShowErrorMsgCo(string msg)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x14651A0", Offset = "0x14651A0", VA = "0x14651A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FF75C", Offset = "0x8FF75C")]
		private IEnumerator ResendCountDownCo()
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x146520C", Offset = "0x146520C", VA = "0x146520C")]
		protected void RefreshLoginTokenLater()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x14638F0", Offset = "0x14638F0", VA = "0x14638F0")]
		protected void RefreshLoginSession()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1465290", Offset = "0x1465290", VA = "0x1465290")]
		protected void OnSmsCodeRequestFinished(eNetErr code, ResponseData resData, string rawData)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x146572C", Offset = "0x146572C", VA = "0x146572C")]
		protected void OnPhoneLoginRequestFinished(eNetErr code, ResponseData resData, string rawData)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1465A28", Offset = "0x1465A28", VA = "0x1465A28")]
		protected void OnRefreshSessionRequestFinished(eNetErr code, ResponseData resData, string rawData)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1465640", Offset = "0x1465640", VA = "0x1465640")]
		protected bool HandleCommonHttpError(eNetErr netErr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1463A1C", Offset = "0x1463A1C", VA = "0x1463A1C")]
		protected void ShowLoginPanel()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1465CE4", Offset = "0x1465CE4", VA = "0x1465CE4", Slot = "13")]
		public override bool OnBackBtnClicked()
		{
			return default(bool);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1465D8C", Offset = "0x1465D8C", VA = "0x1465D8C")]
		public UISmsLogin()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class UIStatusBar : UIBasePanel
	{
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Button _backBtn;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Button _searchBtn;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Button _personalBtn;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Button _homeBtn;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _settingsBtn;

		[Token(Token = "0x1700007C")]
		public override eUIType PanelType
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x1465D94", Offset = "0x1465D94", VA = "0x1465D94", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1465D9C", Offset = "0x1465D9C", VA = "0x1465D9C", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1465DCC", Offset = "0x1465DCC", VA = "0x1465DCC", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x146600C", Offset = "0x146600C", VA = "0x146600C")]
		protected void OnStatusBarBackBtnClicked()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1466178", Offset = "0x1466178", VA = "0x1466178", Slot = "11")]
		public override void Show()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x14662C0", Offset = "0x14662C0", VA = "0x14662C0")]
		public UIStatusBar()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class UISysInfoPanel : MonoBehaviour
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color[] BatteryColor;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sprite[] WifiIconList;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sprite[] BatteryIconList;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Text _systemTimeTxt;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Image _wifiIconImage;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text _userAccountTxt;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _hmdImage;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Text _hmdTxt;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _hmdBatteryImage;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Text _hmdBatteryTxt;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _leftCtrlImage;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Text _leftCtrlTxt;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _leftCtrlBatteryImage;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image _leftCtrlBatteryBgImage;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Text _leftCtrlBatteryTxt;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _rightCtrlImage;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Text _rightCtrlTxt;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Image _rightCtrlBatteryImage;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Image _rightCtrlBatteryBgImage;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Text _rightCtrlBatteryTxt;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Controller _leftController;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Controller _rightController;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float prevUpdateTime;

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x14662C8", Offset = "0x14662C8", VA = "0x14662C8")]
		protected void Awake()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x14669A0", Offset = "0x14669A0", VA = "0x14669A0")]
		protected void Start()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x146783C", Offset = "0x146783C", VA = "0x146783C")]
		protected void Update()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1466B04", Offset = "0x1466B04", VA = "0x1466B04")]
		protected void UpdateUI()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x14667B4", Offset = "0x14667B4", VA = "0x14667B4")]
		protected void UpdateBatteryInfo(Image img, Text txt, int batteryLevel, bool isCharging)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1467884", Offset = "0x1467884", VA = "0x1467884")]
		public UISysInfoPanel()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class UIVideoBuffering : UIBasePanel
	{
		[Token(Token = "0x1700007D")]
		public override eUIType PanelType
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x146788C", Offset = "0x146788C", VA = "0x146788C", Slot = "4")]
			get
			{
				return default(eUIType);
			}
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1467894", Offset = "0x1467894", VA = "0x1467894", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x14678C4", Offset = "0x14678C4", VA = "0x14678C4", Slot = "5")]
		protected override void Init()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x14679E8", Offset = "0x14679E8", VA = "0x14679E8", Slot = "13")]
		public override bool OnBackBtnClicked()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x14679F0", Offset = "0x14679F0", VA = "0x14679F0", Slot = "11")]
		public override void Show()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1467A74", Offset = "0x1467A74", VA = "0x1467A74", Slot = "12")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1467AF8", Offset = "0x1467AF8", VA = "0x1467AF8", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1467B84", Offset = "0x1467B84", VA = "0x1467B84")]
		public UIVideoBuffering()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8FAF04", Offset = "0x8FAF04")]
	public class AudioEffector : MonoBehaviour
	{
		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool EnableHove;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool EnableClick;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip CustomHoverAudio;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip CustomClickAudio;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private EventTrigger _eventTrigger;

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x154EE7C", Offset = "0x154EE7C", VA = "0x154EE7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x154F0E8", Offset = "0x154F0E8", VA = "0x154F0E8")]
		private void OnPointerEnter(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x154F354", Offset = "0x154F354", VA = "0x154F354")]
		private void OnPointerExit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x154F358", Offset = "0x154F358", VA = "0x154F358")]
		private void OnPointerClick(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x154F460", Offset = "0x154F460", VA = "0x154F460")]
		public AudioEffector()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class AutoRotate : MonoBehaviour
	{
		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float xSpeed;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float ySpeed;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float zSpeed;

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x154F6A4", Offset = "0x154F6A4", VA = "0x154F6A4")]
		protected void Update()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x154F730", Offset = "0x154F730", VA = "0x154F730")]
		public AutoRotate()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Text _text;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _appVersion;

		[Token(Token = "0x4000400")]
		private const float _counterInterval = 1f;

		[Token(Token = "0x4000401")]
		private const float _tweenInterval = 0.2f;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _prevTime;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _frameCount;

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1360614", Offset = "0x1360614", VA = "0x1360614")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x13606B0", Offset = "0x13606B0", VA = "0x13606B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1360A40", Offset = "0x1360A40", VA = "0x1360A40")]
		private float GetTargetFps()
		{
			return default(float);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1360AA8", Offset = "0x1360AA8", VA = "0x1360AA8")]
		public FPSCounter()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public static class HelperScript
	{
		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FAF84", Offset = "0x8FAF84")]
		private sealed class <RunThrowingIterator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator coroutine;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<Exception> onExpCallback;

			[Token(Token = "0x1700007E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003C5")]
				[Address(RVA = "0x1A93274", Offset = "0x1A93274", VA = "0x1A93274", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003C7")]
				[Address(RVA = "0x1A932BC", Offset = "0x1A932BC", VA = "0x1A932BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x1A93024", Offset = "0x1A93024", VA = "0x1A93024")]
			[DebuggerHidden]
			public <RunThrowingIterator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x1A93050", Offset = "0x1A93050", VA = "0x1A93050", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x1A93054", Offset = "0x1A93054", VA = "0x1A93054", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x1A9327C", Offset = "0x1A9327C", VA = "0x1A9327C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<char, string> DicChars;

		[Token(Token = "0x60003B7")]
		public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1363EA8", Offset = "0x1363EA8", VA = "0x1363EA8")]
		public static Coroutine StartCoroutineEx(this MonoBehaviour monoBehaviour, IEnumerator coroutine, Action<Exception> onExceptionCallback)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1363F34", Offset = "0x1363F34", VA = "0x1363F34")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FF87C", Offset = "0x8FF87C")]
		public static IEnumerator RunThrowingIterator(IEnumerator coroutine, Action<Exception> onExpCallback)
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1363FAC", Offset = "0x1363FAC", VA = "0x1363FAC")]
		public static string ComputeMd5Hash(string msg)
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x136422C", Offset = "0x136422C", VA = "0x136422C")]
		public static void BeginStart(this MonoBehaviour monoBehaviour, ref bool started, [System.Runtime.InteropServices.Optional] Action baseStart)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x136429C", Offset = "0x136429C", VA = "0x136429C")]
		public static void EndStart(this MonoBehaviour monoBehaviour, ref bool started)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x13642CC", Offset = "0x13642CC", VA = "0x13642CC")]
		public static int GetVersionCode()
		{
			return default(int);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x136458C", Offset = "0x136458C", VA = "0x136458C")]
		public static string NormalizePhoneNumber(string phone)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x13646C8", Offset = "0x13646C8", VA = "0x13646C8")]
		public static string MaskPhoneNumber(string phone)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1364784", Offset = "0x1364784", VA = "0x1364784")]
		public static TrackInfo[] GetTrackInfoArray(string tracks)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8FAF94", Offset = "0x8FAF94")]
	[DisallowMultipleComponent]
	public class Highlighter : MonoBehaviour
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject HoverGo;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private EventTrigger _eventTrigger;

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1364CC8", Offset = "0x1364CC8", VA = "0x1364CC8")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1364FA8", Offset = "0x1364FA8", VA = "0x1364FA8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x136503C", Offset = "0x136503C", VA = "0x136503C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x13650D0", Offset = "0x13650D0", VA = "0x13650D0")]
		private void OnPointerEnter(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1365164", Offset = "0x1365164", VA = "0x1365164")]
		private void OnPointerExit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x13651F8", Offset = "0x13651F8", VA = "0x13651F8")]
		private void OnPointerClick(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x136528C", Offset = "0x136528C", VA = "0x136528C")]
		public Highlighter()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class ResumableDownloader
	{
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected string _downloadUrl;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected string _savedFilePath;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected string _tempSavedFilePath;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected long _downloadLength;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private FileStream _localFileStream;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private long _downloadStartedAt;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected HTTPRequest _request;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _isInited;

		[Token(Token = "0x14000001")]
		public event Action EventDownloadSucceed
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x136C69C", Offset = "0x136C69C", VA = "0x136C69C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF94C", Offset = "0x8FF94C")]
			add
			{
			}
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x136C73C", Offset = "0x136C73C", VA = "0x136C73C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF95C", Offset = "0x8FF95C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action EventDownloadCancelled
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x136C7DC", Offset = "0x136C7DC", VA = "0x136C7DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF96C", Offset = "0x8FF96C")]
			add
			{
			}
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x136C87C", Offset = "0x136C87C", VA = "0x136C87C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF97C", Offset = "0x8FF97C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<string> EventDownloadFailed
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x136C91C", Offset = "0x136C91C", VA = "0x136C91C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF98C", Offset = "0x8FF98C")]
			add
			{
			}
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x136C9BC", Offset = "0x136C9BC", VA = "0x136C9BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF99C", Offset = "0x8FF99C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<long, long> EventDownloadProgress
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x136CA5C", Offset = "0x136CA5C", VA = "0x136CA5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF9AC", Offset = "0x8FF9AC")]
			add
			{
			}
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x136CAFC", Offset = "0x136CAFC", VA = "0x136CAFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF9BC", Offset = "0x8FF9BC")]
			remove
			{
			}
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x136CB9C", Offset = "0x136CB9C", VA = "0x136CB9C")]
		public bool Init(string url, string filePath, long downloadLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x136CFC4", Offset = "0x136CFC4", VA = "0x136CFC4")]
		public bool IsDownloading()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x136CFFC", Offset = "0x136CFFC", VA = "0x136CFFC")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x136D0CC", Offset = "0x136D0CC", VA = "0x136D0CC", Slot = "4")]
		public virtual void StartDownloading()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x136D62C", Offset = "0x136D62C", VA = "0x136D62C")]
		public void Cancel()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x136D680", Offset = "0x136D680", VA = "0x136D680", Slot = "5")]
		protected virtual void SetupRequest()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x136D944", Offset = "0x136D944", VA = "0x136D944")]
		private void OnHeadersReceived(HTTPRequest req, HTTPResponse resp, Dictionary<string, List<string>> newHeaders)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x136DC88", Offset = "0x136DC88", VA = "0x136DC88", Slot = "6")]
		protected virtual void OnDownloadProgress(HTTPRequest originalRequest, long downloaded, long downloadLength)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x136DD00", Offset = "0x136DD00", VA = "0x136DD00", Slot = "7")]
		protected virtual bool OnDataDownloaded(HTTPRequest request, HTTPResponse response, byte[] dataFragment, int dataFragmentLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x136DE9C", Offset = "0x136DE9C", VA = "0x136DE9C", Slot = "8")]
		protected virtual void OnRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x136D1AC", Offset = "0x136D1AC", VA = "0x136D1AC")]
		protected void OnDownloadCompleted()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x136E780", Offset = "0x136E780", VA = "0x136E780")]
		public ResumableDownloader()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8FB004", Offset = "0x8FB004")]
	public class ThumbstickScroll : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InputActionProperty _leftThumbstick2DAxisAction;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InputActionProperty _rightThumbstick2DAxisAction;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int isPointerIn;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ScrollRect _scrollRect;

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x151CB30", Offset = "0x151CB30", VA = "0x151CB30")]
		protected void Awake()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x151CB84", Offset = "0x151CB84", VA = "0x151CB84")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x151CB8C", Offset = "0x151CB8C", VA = "0x151CB8C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x151CB9C", Offset = "0x151CB9C", VA = "0x151CB9C", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x151CBAC", Offset = "0x151CBAC", VA = "0x151CBAC")]
		protected void Update()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x151CCA4", Offset = "0x151CCA4", VA = "0x151CCA4")]
		public ThumbstickScroll()
		{
		}
	}
}
namespace Oculus.Interaction.UnityCanvas
{
	[Token(Token = "0x20000AF")]
	public class XRITCanvasMeshRenderer : CanvasMeshRenderer
	{
		[Token(Token = "0x20000B0")]
		public new static class Properties
		{
			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly string CanvasRenderTexture;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly string CanvasMesh;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly string EnableSuperSampling;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static readonly string EmulateWhileInEditor;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly string DoUnderlayAntiAliasing;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static readonly string RuntimeOffset;
		}

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected CanvasMesh _canvasMesh;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FD0A8", Offset = "0x8FD0A8")]
		protected Vector3 _runtimeOffset;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FD0F4", Offset = "0x8FD0F4")]
		protected bool _enableSuperSampling;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FD140", Offset = "0x8FD140")]
		private bool _doUnderlayAntiAliasing;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FD18C", Offset = "0x8FD18C")]
		private bool _emulateWhileInEditor;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FD1D8", Offset = "0x8FD1D8")]
		[SerializeField]
		private int _compositorLayerDepth;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected PXR_OverLay _overlay;

		[Token(Token = "0x17000080")]
		private RenderingMode RenderingMode
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x146CCE8", Offset = "0x146CCE8", VA = "0x146CCE8")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000081")]
		public bool ShouldUseOVROverlay
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x146CCF0", Offset = "0x146CCF0", VA = "0x146CCF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x146CD80", Offset = "0x146CD80", VA = "0x146CD80", Slot = "4")]
		protected override string GetShaderName()
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x146CE3C", Offset = "0x146CE3C", VA = "0x146CE3C", Slot = "6")]
		protected override float GetAlphaCutoutThreshold()
		{
			return default(float);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x146CEAC", Offset = "0x146CEAC", VA = "0x146CEAC", Slot = "7")]
		protected override void HandleUpdateRenderTexture(Texture texture)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x146CD44", Offset = "0x146CD44", VA = "0x146CD44")]
		private bool UseEditorEmulation()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x146D1F4", Offset = "0x146D1F4", VA = "0x146D1F4")]
		private bool GetOverlayParameters(out PXR_OverLay.OverlayShape shape, out Vector3 position, out Vector3 scale)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x146D450", Offset = "0x146D450", VA = "0x146D450")]
		protected void Awake()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x146D454", Offset = "0x146D454", VA = "0x146D454", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x146CEDC", Offset = "0x146CEDC", VA = "0x146CEDC")]
		protected void UpdateOverlay(Texture texture)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x146D4F4", Offset = "0x146D4F4", VA = "0x146D4F4")]
		protected GameObject CreateChildObject(string name)
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x146D610", Offset = "0x146D610", VA = "0x146D610")]
		public void InjectAllOVRCanvasMeshRenderer(CanvasRenderTexture canvasRenderTexture, MeshRenderer meshRenderer, CanvasMesh canvasMesh)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x146D63C", Offset = "0x146D63C", VA = "0x146D63C")]
		public void InjectCanvasMesh(CanvasMesh canvasMesh)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x146D644", Offset = "0x146D644", VA = "0x146D644")]
		public void InjectOptionalRenderingMode(RenderingMode ovrRenderingMode)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x146D64C", Offset = "0x146D64C", VA = "0x146D64C")]
		public void InjectOptionalDoUnderlayAntiAliasing(bool doUnderlayAntiAliasing)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x146D658", Offset = "0x146D658", VA = "0x146D658")]
		public void InjectOptionalEnableSuperSampling(bool enableSuperSampling)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x146D664", Offset = "0x146D664", VA = "0x146D664")]
		public XRITCanvasMeshRenderer()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x146D6DC", Offset = "0x146D6DC", VA = "0x146D6DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF9CC", Offset = "0x8FF9CC")]
		private void <Start>b__17_0()
		{
		}
	}
}
namespace Oculus.Interaction.Input
{
	[Token(Token = "0x20000B1")]
	internal struct XRPointerPoseSelector
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Pose[] QUEST1_POINTERS;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Pose[] QUEST2_POINTERS;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Pose[] NEO3_POINTERS;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly Pose[] PICO4_POINTERS;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly Pose[] QIYU3_POINTERS;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly Pose[] QIYU_DREAM_POINTERS;

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1A91040", Offset = "0x1A91040", VA = "0x1A91040")]
		public static Pose GetPose(ControllerModelType controllerType, Handedness handedness)
		{
			return default(Pose);
		}
	}
	[Token(Token = "0x20000B2")]
	public class FromXRITControllerDataSource : DataSource<ControllerDataAsset>
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FD224", Offset = "0x8FD224")]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x8FD224", Offset = "0x8FD224")]
		private MonoBehaviour _cameraRigRef;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FD2E4", Offset = "0x8FD2E4")]
		private IXRITCameraRigRef <CameraRigRef>k__BackingField;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FD2F4", Offset = "0x8FD2F4")]
		[SerializeField]
		private ControllerModelType _controllerSimulation;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Handedness _handedness;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x8FD350", Offset = "0x8FD350")]
		private MonoBehaviour _trackingToWorldTransformer;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ITrackingToWorldTransformer TrackingToWorldTransformer;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x8FD3EC", Offset = "0x8FD3EC")]
		private MonoBehaviour _hmdData;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private IDataSource<HmdDataAsset> HmdData;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly ControllerDataAsset _controllerDataAsset;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private IXRITController _xritController;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ControllerDataSourceConfig _config;

		[Token(Token = "0x17000082")]
		public IXRITCameraRigRef CameraRigRef
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x1360FC0", Offset = "0x1360FC0", VA = "0x1360FC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF9DC", Offset = "0x8FF9DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x1360FC8", Offset = "0x1360FC8", VA = "0x1360FC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF9EC", Offset = "0x8FF9EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		private ControllerDataSourceConfig Config
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x13614B0", Offset = "0x13614B0", VA = "0x13614B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		protected override ControllerDataAsset DataAsset
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x1362330", Offset = "0x1362330", VA = "0x1362330", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1360FD0", Offset = "0x1360FD0", VA = "0x1360FD0")]
		protected void Awake()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x13610C8", Offset = "0x13610C8", VA = "0x13610C8", Slot = "10")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1361240", Offset = "0x1361240", VA = "0x1361240", Slot = "11")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1361378", Offset = "0x1361378", VA = "0x1361378", Slot = "12")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x13614A0", Offset = "0x13614A0", VA = "0x13614A0")]
		private void HandleInputDataDirtied()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1361070", Offset = "0x1361070", VA = "0x1361070")]
		private void UpdateConfig()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1361528", Offset = "0x1361528", VA = "0x1361528", Slot = "17")]
		protected override void UpdateData()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1362184", Offset = "0x1362184", VA = "0x1362184")]
		private ControllerModelType GetControllerType()
		{
			return default(ControllerModelType);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1362338", Offset = "0x1362338", VA = "0x1362338")]
		public FromXRITControllerDataSource()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x13623B0", Offset = "0x13623B0", VA = "0x13623B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FF9FC", Offset = "0x8FF9FC")]
		private void <Start>b__15_0()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class FromXRITControllerHandDataSource : DataSource<HandDataAsset>
	{
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private List<Transform> _jointTransforms;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve _pinchCurve;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 _rootOffset;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Vector3 _rootAngleOffset;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FD4F0", Offset = "0x8FD4F0")]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x8FD4F0", Offset = "0x8FD4F0")]
		[SerializeField]
		private MonoBehaviour _cameraRigRef;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private IXRITCameraRigRef CameraRigRef;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FD5B8", Offset = "0x8FD5B8")]
		[SerializeField]
		private Handedness _handedness;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x8FD604", Offset = "0x8FD604")]
		private MonoBehaviour _trackingToWorldTransformer;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ITrackingToWorldTransformer TrackingToWorldTransformer;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x8FD6A0", Offset = "0x8FD6A0")]
		private MonoBehaviour _hmdData;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private IDataSource<HmdDataAsset> HmdData;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly HandDataAsset _handDataAsset;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private IXRITController _xritController;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private HandDataSourceConfig _config;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Pose _poseOffset;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FD73C", Offset = "0x8FD73C")]
		private static readonly Quaternion <WristFixupRotation>k__BackingField;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private HandSkeleton _skeleton;

		[Token(Token = "0x17000085")]
		public List<Transform> JointTransforms
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x13623FC", Offset = "0x13623FC", VA = "0x13623FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public static Quaternion WristFixupRotation
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x1362404", Offset = "0x1362404", VA = "0x1362404")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFA0C", Offset = "0x8FFA0C")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000087")]
		protected override HandDataAsset DataAsset
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x136246C", Offset = "0x136246C", VA = "0x136246C", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		private HandDataSourceConfig Config
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x1362B80", Offset = "0x1362B80", VA = "0x1362B80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1362474", Offset = "0x1362474", VA = "0x1362474")]
		protected void Awake()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1362590", Offset = "0x1362590", VA = "0x1362590", Slot = "10")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1362910", Offset = "0x1362910", VA = "0x1362910", Slot = "11")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1362A48", Offset = "0x1362A48", VA = "0x1362A48", Slot = "12")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1362B70", Offset = "0x1362B70", VA = "0x1362B70")]
		private void HandleInputDataDirtied()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x13627D8", Offset = "0x13627D8", VA = "0x13627D8")]
		private void UpdateSkeleton()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1362524", Offset = "0x1362524", VA = "0x1362524")]
		private void UpdateConfig()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1362BF8", Offset = "0x1362BF8", VA = "0x1362BF8", Slot = "17")]
		protected override void UpdateData()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x13634B0", Offset = "0x13634B0", VA = "0x13634B0")]
		public FromXRITControllerHandDataSource()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1363604", Offset = "0x1363604", VA = "0x1363604")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFA1C", Offset = "0x8FFA1C")]
		private void <Start>b__24_0()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class FromXRITHmdDataSource : DataSource<HmdDataAsset>
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FD74C", Offset = "0x8FD74C")]
		[SerializeField]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x8FD74C", Offset = "0x8FD74C")]
		private MonoBehaviour _cameraRigRef;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FD80C", Offset = "0x8FD80C")]
		private IXRITCameraRigRef <CameraRigRef>k__BackingField;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x8FD81C", Offset = "0x8FD81C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FD81C", Offset = "0x8FD81C")]
		[SerializeField]
		private MonoBehaviour _trackingToWorldTransformer;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ITrackingToWorldTransformer TrackingToWorldTransformer;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private HmdDataAsset _hmdDataAsset;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private HmdDataSourceConfig _config;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<XRDisplaySubsystem> s_displaySubsystems;

		[Token(Token = "0x17000089")]
		public IXRITCameraRigRef CameraRigRef
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1363650", Offset = "0x1363650", VA = "0x1363650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFA2C", Offset = "0x8FFA2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1363658", Offset = "0x1363658", VA = "0x1363658")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFA3C", Offset = "0x8FFA3C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		private HmdDataSourceConfig Config
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x13639E8", Offset = "0x13639E8", VA = "0x13639E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		protected override HmdDataAsset DataAsset
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1363DDC", Offset = "0x1363DDC", VA = "0x1363DDC", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1363660", Offset = "0x1363660", VA = "0x1363660")]
		protected void Awake()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x13636D8", Offset = "0x13636D8", VA = "0x13636D8", Slot = "10")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1363778", Offset = "0x1363778", VA = "0x1363778", Slot = "11")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x13638B0", Offset = "0x13638B0", VA = "0x13638B0", Slot = "12")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x13639D8", Offset = "0x13639D8", VA = "0x13639D8")]
		private void HandleInputDataDirtied()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1363A60", Offset = "0x1363A60", VA = "0x1363A60")]
		public static bool IsHmdPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1363BAC", Offset = "0x1363BAC", VA = "0x1363BAC", Slot = "17")]
		protected override void UpdateData()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1363DE4", Offset = "0x1363DE4", VA = "0x1363DE4")]
		public FromXRITHmdDataSource()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1363E5C", Offset = "0x1363E5C", VA = "0x1363E5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFA4C", Offset = "0x8FFA4C")]
		private void <Start>b__10_0()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class XRITAnimatedHand : MonoBehaviour
	{
		[Token(Token = "0x20000B6")]
		public enum AllowThumbUp
		{
			[Token(Token = "0x4000464")]
			Always,
			[Token(Token = "0x4000465")]
			GripRequired,
			[Token(Token = "0x4000466")]
			TriggerAndGripRequired
		}

		[Token(Token = "0x4000452")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x4000453")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x4000454")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x4000455")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x8FD8E4", Offset = "0x8FD8E4")]
		[SerializeField]
		private MonoBehaviour _XRITController;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FD988", Offset = "0x8FD988")]
		private IXRITController <XRITController>k__BackingField;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _animator;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AllowThumbUp _allowThumbUp;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _animLayerIndexThumb;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _animLayerIndexPoint;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _animParamIndexFlex;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _isPointing;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool _isGivingThumbsUp;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _pointBlend;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _thumbsUpBlend;

		[Token(Token = "0x4000461")]
		private const float TRIGGER_MAX = 0.95f;

		[Token(Token = "0x4000462")]
		private const float Epsilon = 0.05f;

		[Token(Token = "0x1700008C")]
		public IXRITController XRITController
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x146BF60", Offset = "0x146BF60", VA = "0x146BF60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFA5C", Offset = "0x8FFA5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x146BF68", Offset = "0x146BF68", VA = "0x146BF68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFA6C", Offset = "0x8FFA6C")]
			private set
			{
			}
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x146BF70", Offset = "0x146BF70", VA = "0x146BF70")]
		protected void Awake()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x146BFC4", Offset = "0x146BFC4", VA = "0x146BFC4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x146C078", Offset = "0x146C078", VA = "0x146C078", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x146C118", Offset = "0x146C118", VA = "0x146C118")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x146C688", Offset = "0x146C688", VA = "0x146C688")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x146C6DC", Offset = "0x146C6DC", VA = "0x146C6DC")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x146C898", Offset = "0x146C898", VA = "0x146C898")]
		public XRITAnimatedHand()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public interface IXRITCameraRigRef
	{
		[Token(Token = "0x1700008D")]
		Transform CenterEyeCamera
		{
			[Token(Token = "0x6000431")]
			get;
		}

		[Token(Token = "0x1700008E")]
		IXRITController LeftController
		{
			[Token(Token = "0x6000432")]
			get;
		}

		[Token(Token = "0x1700008F")]
		IXRITController RightController
		{
			[Token(Token = "0x6000433")]
			get;
		}

		[Token(Token = "0x14000005")]
		event Action WhenInputDataDirtied;
	}
	[Token(Token = "0x20000B8")]
	public class XRITCameraRigRef : MonoBehaviour, IXRITCameraRigRef
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FB064", Offset = "0x8FB064")]
		private sealed class <>c
		{
			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__22_0;

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1A9C458", Offset = "0x1A9C458", VA = "0x1A9C458")]
			public <>c()
			{
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1A9C460", Offset = "0x1A9C460", VA = "0x1A9C460")]
			internal void <.ctor>b__22_0()
			{
			}
		}

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FD9B8", Offset = "0x8FD9B8")]
		[SerializeField]
		private Transform _centerEyeAnchor;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x8FDA04", Offset = "0x8FDA04")]
		private MonoBehaviour _leftXRITController;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x8FDAA0", Offset = "0x8FDAA0")]
		[SerializeField]
		private MonoBehaviour _rightXRITController;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FDB44", Offset = "0x8FDB44")]
		private IXRITController <LeftController>k__BackingField;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FDB54", Offset = "0x8FDB54")]
		private IXRITController <RightController>k__BackingField;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool _started;

		[Token(Token = "0x17000090")]
		public IXRITController LeftController
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x146C8AC", Offset = "0x146C8AC", VA = "0x146C8AC", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFA9C", Offset = "0x8FFA9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x146C8B4", Offset = "0x146C8B4", VA = "0x146C8B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFAAC", Offset = "0x8FFAAC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public IXRITController RightController
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x146C8BC", Offset = "0x146C8BC", VA = "0x146C8BC", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFABC", Offset = "0x8FFABC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x146C8C4", Offset = "0x146C8C4", VA = "0x146C8C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFACC", Offset = "0x8FFACC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public Transform CenterEyeCamera
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x146C8CC", Offset = "0x146C8CC", VA = "0x146C8CC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000006")]
		public event Action WhenInputDataDirtied
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x146C8D4", Offset = "0x146C8D4", VA = "0x146C8D4", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFADC", Offset = "0x8FFADC")]
			add
			{
			}
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x146C974", Offset = "0x146C974", VA = "0x146C974", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFAEC", Offset = "0x8FFAEC")]
			remove
			{
			}
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x146CA14", Offset = "0x146CA14", VA = "0x146CA14")]
		protected void Awake()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x146CA78", Offset = "0x146CA78", VA = "0x146CA78", Slot = "9")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x146CAB4", Offset = "0x146CAB4", VA = "0x146CAB4", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x146CB44", Offset = "0x146CB44", VA = "0x146CB44", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x146CBD4", Offset = "0x146CBD4", VA = "0x146CBD4")]
		protected void OnBeforeRender()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x146CBF0", Offset = "0x146CBF0", VA = "0x146CBF0")]
		public XRITCameraRigRef()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public interface IXRITController
	{
		[Token(Token = "0x17000093")]
		Transform Transform
		{
			[Token(Token = "0x6000446")]
			get;
		}

		[Token(Token = "0x17000094")]
		InputAction IsTrackedAction
		{
			[Token(Token = "0x6000447")]
			get;
		}

		[Token(Token = "0x17000095")]
		InputAction PrimaryButtonAction
		{
			[Token(Token = "0x6000448")]
			get;
		}

		[Token(Token = "0x17000096")]
		InputAction PrimaryTouchAction
		{
			[Token(Token = "0x6000449")]
			get;
		}

		[Token(Token = "0x17000097")]
		InputAction SecondaryButtonAction
		{
			[Token(Token = "0x600044A")]
			get;
		}

		[Token(Token = "0x17000098")]
		InputAction SecondaryTouchAction
		{
			[Token(Token = "0x600044B")]
			get;
		}

		[Token(Token = "0x17000099")]
		InputAction GripButtonAction
		{
			[Token(Token = "0x600044C")]
			get;
		}

		[Token(Token = "0x1700009A")]
		InputAction TriggerButtonAction
		{
			[Token(Token = "0x600044D")]
			get;
		}

		[Token(Token = "0x1700009B")]
		InputAction TriggerTouchAction
		{
			[Token(Token = "0x600044E")]
			get;
		}

		[Token(Token = "0x1700009C")]
		InputAction MenuButtonAction
		{
			[Token(Token = "0x600044F")]
			get;
		}

		[Token(Token = "0x1700009D")]
		InputAction ThumbstickButtonAction
		{
			[Token(Token = "0x6000450")]
			get;
		}

		[Token(Token = "0x1700009E")]
		InputAction ThumbstickTouchAction
		{
			[Token(Token = "0x6000451")]
			get;
		}

		[Token(Token = "0x1700009F")]
		InputAction Thumbstick2DAxisAction
		{
			[Token(Token = "0x6000452")]
			get;
		}

		[Token(Token = "0x170000A0")]
		InputAction Trigger1DAxisAction
		{
			[Token(Token = "0x6000453")]
			get;
		}

		[Token(Token = "0x170000A1")]
		InputAction Grip1DAxisAction
		{
			[Token(Token = "0x6000454")]
			get;
		}
	}
	[Token(Token = "0x20000BB")]
	public class XRITController : MonoBehaviour, IXRITController
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Handedness _handedness;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FDB84", Offset = "0x8FDB84")]
		[SerializeField]
		private InputActionProperty _isTrackedAction;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InputActionProperty _primaryButtonAction;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InputActionProperty _primaryTouchAction;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private InputActionProperty _secondaryButtonAction;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private InputActionProperty _secondaryTouchAction;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private InputActionProperty _gripButtonAction;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private InputActionProperty _triggerButtonAction;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private InputActionProperty _triggerTouchAction;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private InputActionProperty _menuButtonAction;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private InputActionProperty _thumbstickButtonAction;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private InputActionProperty _thumbstickTouchAction;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private InputActionProperty _thumbstick2DAxisAction;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private InputActionProperty _trigger1DAxisAction;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private InputActionProperty _grip1DAxisAction;

		[Token(Token = "0x170000A2")]
		public Handedness Handedness
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x146D6E4", Offset = "0x146D6E4", VA = "0x146D6E4")]
			get
			{
				return default(Handedness);
			}
		}

		[Token(Token = "0x170000A3")]
		public Transform Transform
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x146D6EC", Offset = "0x146D6EC", VA = "0x146D6EC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public InputAction IsTrackedAction
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x146D6F4", Offset = "0x146D6F4", VA = "0x146D6F4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public InputAction PrimaryButtonAction
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1460BFC", Offset = "0x1460BFC", VA = "0x1460BFC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public InputAction PrimaryTouchAction
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x146D700", Offset = "0x146D700", VA = "0x146D700", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public InputAction SecondaryButtonAction
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x145C21C", Offset = "0x145C21C", VA = "0x145C21C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public InputAction SecondaryTouchAction
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x146D70C", Offset = "0x146D70C", VA = "0x146D70C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		public InputAction GripButtonAction
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x146D718", Offset = "0x146D718", VA = "0x146D718", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		public InputAction TriggerButtonAction
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x1460C08", Offset = "0x1460C08", VA = "0x1460C08", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public InputAction TriggerTouchAction
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x146D724", Offset = "0x146D724", VA = "0x146D724", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		public InputAction MenuButtonAction
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x146D730", Offset = "0x146D730", VA = "0x146D730", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		public InputAction ThumbstickButtonAction
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x146D73C", Offset = "0x146D73C", VA = "0x146D73C", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public InputAction ThumbstickTouchAction
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x146D748", Offset = "0x146D748", VA = "0x146D748", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		public InputAction Thumbstick2DAxisAction
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x146D754", Offset = "0x146D754", VA = "0x146D754", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		public InputAction Trigger1DAxisAction
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x146D760", Offset = "0x146D760", VA = "0x146D760", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		public InputAction Grip1DAxisAction
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x146D76C", Offset = "0x146D76C", VA = "0x146D76C", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x146D778", Offset = "0x146D778", VA = "0x146D778")]
		public XRITController()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class XRITTrackingToWorldTransformer : MonoBehaviour, ITrackingToWorldTransformer
	{
		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x8FDCA0", Offset = "0x8FDCA0")]
		private MonoBehaviour _cameraRigRef;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FDD3C", Offset = "0x8FDD3C")]
		private IXRITCameraRigRef <CameraRigRef>k__BackingField;

		[Token(Token = "0x170000B2")]
		public IXRITCameraRigRef CameraRigRef
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x1A90E0C", Offset = "0x1A90E0C", VA = "0x1A90E0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFAFC", Offset = "0x8FFAFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x1A90E14", Offset = "0x1A90E14", VA = "0x1A90E14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFB0C", Offset = "0x8FFB0C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public Transform Transform
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x1A90E1C", Offset = "0x1A90E1C", VA = "0x1A90E1C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		public Quaternion WorldToTrackingWristJointFixup
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x1A90F9C", Offset = "0x1A90F9C", VA = "0x1A90F9C", Slot = "7")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1A90E38", Offset = "0x1A90E38", VA = "0x1A90E38", Slot = "5")]
		public Pose ToWorldPose(Pose pose)
		{
			return default(Pose);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1A90EC8", Offset = "0x1A90EC8", VA = "0x1A90EC8")]
		public Pose ToTrackingPose(in Pose worldPose)
		{
			return default(Pose);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1A90FA4", Offset = "0x1A90FA4", VA = "0x1A90FA4", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1A90FF8", Offset = "0x1A90FF8", VA = "0x1A90FF8", Slot = "9")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1A90FFC", Offset = "0x1A90FFC", VA = "0x1A90FFC")]
		public XRITTrackingToWorldTransformer()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1A91004", Offset = "0x1A91004", VA = "0x1A91004", Slot = "6")]
		private Pose Oculus.Interaction.Input.ITrackingToWorldTransformer.ToTrackingPose(in Pose worldPose)
		{
			return default(Pose);
		}
	}
}
namespace Oculus.Interaction.Input.Visuals
{
	[Token(Token = "0x20000BD")]
	public class XRITControllerVisual : MonoBehaviour
	{
		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Controller _controller;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FDD5C", Offset = "0x8FDD5C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FDD5C", Offset = "0x8FDD5C")]
		private GameObject _pxrControllerModelPrefab;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FDDCC", Offset = "0x8FDDCC")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FDDCC", Offset = "0x8FDDCC")]
		private GameObject _ovrControllerPrefab;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FDE3C", Offset = "0x8FDE3C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FDE3C", Offset = "0x8FDE3C")]
		private GameObject _qiyu3HandlePrefab;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FDEAC", Offset = "0x8FDEAC")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FDEAC", Offset = "0x8FDEAC")]
		private GameObject _qiyuDreamHandlePrefab;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _currentControllerModel;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ControllerModelType _currentControllerType;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FDF1C", Offset = "0x8FDF1C")]
		private bool <ForceOffVisibility>k__BackingField;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool _started;

		[Token(Token = "0x170000B5")]
		public bool ForceOffVisibility
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x146D780", Offset = "0x146D780", VA = "0x146D780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFB1C", Offset = "0x8FFB1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x146D788", Offset = "0x146D788", VA = "0x146D788")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FFB2C", Offset = "0x8FFB2C")]
			set
			{
			}
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x146D794", Offset = "0x146D794", VA = "0x146D794", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x146D798", Offset = "0x146D798", VA = "0x146D798", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x146D7D4", Offset = "0x146D7D4", VA = "0x146D7D4", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x146D880", Offset = "0x146D880", VA = "0x146D880", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x146D970", Offset = "0x146D970", VA = "0x146D970")]
		private void HandleUpdated()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x146DB9C", Offset = "0x146DB9C", VA = "0x146DB9C")]
		private void InstantiateControllerModel()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x146E11C", Offset = "0x146E11C", VA = "0x146E11C")]
		public XRITControllerVisual()
		{
		}
	}
}
namespace CurvedUI
{
	[Token(Token = "0x20000BE")]
	public class CUI_AnimateCurvedFillOnStart : MonoBehaviour
	{
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1550650", Offset = "0x1550650", VA = "0x1550650")]
		private void Update()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x15507E0", Offset = "0x15507E0", VA = "0x15507E0")]
		public CUI_AnimateCurvedFillOnStart()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class CUI_CameraController : MonoBehaviour
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform CameraObject;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float rotationMargin;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool runInEditorOnly;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CUI_CameraController Instance;

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x15507E8", Offset = "0x15507E8", VA = "0x15507E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1550838", Offset = "0x1550838", VA = "0x1550838")]
		public CUI_CameraController()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class CUI_CameraRotationOnButtonHeld : MonoBehaviour
	{
		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float Sensitivity;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector2 _oldMousePos;

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1550850", Offset = "0x1550850", VA = "0x1550850")]
		private void Start()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x155093C", Offset = "0x155093C", VA = "0x155093C")]
		public CUI_CameraRotationOnButtonHeld()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class CUI_ChangeColor : MonoBehaviour
	{
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x155094C", Offset = "0x155094C", VA = "0x155094C")]
		public void ChangeColorToBlue()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x15509C4", Offset = "0x15509C4", VA = "0x15509C4")]
		public void ChangeColorToCyan()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1550A3C", Offset = "0x1550A3C", VA = "0x1550A3C")]
		public void ChangeColorToWhite()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1550AB4", Offset = "0x1550AB4", VA = "0x1550AB4")]
		public CUI_ChangeColor()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class CUI_ChangeValueOnHold : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool pressed;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool selected;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image bg;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color SelectedColor;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color NormalColor;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup IntroCG;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup MenuCG;

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1550ABC", Offset = "0x1550ABC", VA = "0x1550ABC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1550B3C", Offset = "0x1550B3C", VA = "0x1550B3C")]
		private void ChangeVal()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1550CA0", Offset = "0x1550CA0", VA = "0x1550CA0", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1550D30", Offset = "0x1550D30", VA = "0x1550D30", Slot = "5")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1550DBC", Offset = "0x1550DBC", VA = "0x1550DBC")]
		public CUI_ChangeValueOnHold()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class CUI_DragBetweenCanvases : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 dragPoint;

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1550DC4", Offset = "0x1550DC4", VA = "0x1550DC4", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x15510A8", Offset = "0x15510A8", VA = "0x15510A8", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1551524", Offset = "0x1551524", VA = "0x1551524", Slot = "5")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1550EE4", Offset = "0x1550EE4", VA = "0x1550EE4")]
		private void RaycastPosition(out Vector2 newPos)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1551598", Offset = "0x1551598", VA = "0x1551598")]
		public CUI_DragBetweenCanvases()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class CUI_GunController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FB074", Offset = "0x8FB074")]
		private sealed class <>c
		{
			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__2_0;

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x1A926B0", Offset = "0x1A926B0", VA = "0x1A926B0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x1A926B8", Offset = "0x1A926B8", VA = "0x1A926B8")]
			internal bool <Update>b__2_0(GameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUISettings ControlledCanvas;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform LaserBeamTransform;

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x15515A0", Offset = "0x15515A0", VA = "0x15515A0")]
		private void Update()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1551AB0", Offset = "0x1551AB0", VA = "0x1551AB0")]
		public CUI_GunController()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class CUI_GunMovement : MonoBehaviour
	{
		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUISettings mySettings;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform pivot;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float sensitivity;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector2 lastMouse;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1551AB8", Offset = "0x1551AB8", VA = "0x1551AB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1551B1C", Offset = "0x1551B1C", VA = "0x1551B1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1551D50", Offset = "0x1551D50", VA = "0x1551D50")]
		public CUI_GunMovement()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class CUI_OrientOnCurvedSpace : MonoBehaviour
	{
		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvedUISettings mySettings;

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1552180", Offset = "0x1552180", VA = "0x1552180")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x15521D4", Offset = "0x15521D4", VA = "0x15521D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1552374", Offset = "0x1552374", VA = "0x1552374")]
		public CUI_OrientOnCurvedSpace()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class CUI_PerlinNoisePosition : MonoBehaviour
	{
		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float samplingSpeed;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 Range;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform rectie;

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x155237C", Offset = "0x155237C", VA = "0x155237C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x15523EC", Offset = "0x15523EC", VA = "0x15523EC")]
		private void Update()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x15524E0", Offset = "0x15524E0", VA = "0x15524E0")]
		public CUI_PerlinNoisePosition()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class CUI_PerlinNoiseRotation : MonoBehaviour
	{
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float samplingSpeed;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxrotation;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform rectie;

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x15524F0", Offset = "0x15524F0", VA = "0x15524F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1552560", Offset = "0x1552560", VA = "0x1552560")]
		private void Update()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x15525E4", Offset = "0x15525E4", VA = "0x15525E4")]
		public CUI_PerlinNoiseRotation()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class CUI_PickImageFromSet : MonoBehaviour
	{
		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CUI_PickImageFromSet picked;

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x15525F8", Offset = "0x15525F8", VA = "0x15525F8")]
		public void PickThis()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x15527E8", Offset = "0x15527E8", VA = "0x15527E8")]
		public CUI_PickImageFromSet()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class CUI_RaycastToCanvas : MonoBehaviour
	{
		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x15527F4", Offset = "0x15527F4", VA = "0x15527F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1552848", Offset = "0x1552848", VA = "0x1552848")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1552908", Offset = "0x1552908", VA = "0x1552908")]
		public CUI_RaycastToCanvas()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class CUI_RiseChildrenOverTime : MonoBehaviour
	{
		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float current;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Speed;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float RiseBy;

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1552910", Offset = "0x1552910", VA = "0x1552910")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1552914", Offset = "0x1552914", VA = "0x1552914")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1552A84", Offset = "0x1552A84", VA = "0x1552A84")]
		public CUI_RiseChildrenOverTime()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class CUI_TMPChecker : MonoBehaviour
	{
		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject testMsg;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject enabledMsg;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject disabledMsg;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1552B78", Offset = "0x1552B78", VA = "0x1552B78")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1552BF4", Offset = "0x1552BF4", VA = "0x1552BF4")]
		public CUI_TMPChecker()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class CUI_ViveButtonState : MonoBehaviour
	{
		[Token(Token = "0x20000CF")]
		private enum ViveButton
		{
			[Token(Token = "0x40004B3")]
			Trigger,
			[Token(Token = "0x40004B4")]
			TouchpadTouch,
			[Token(Token = "0x40004B5")]
			TouchpadPress,
			[Token(Token = "0x40004B6")]
			Grip,
			[Token(Token = "0x40004B7")]
			Menu
		}

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color ActiveColor;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color InActiveColor;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ViveButton ShowStateFor;

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1552BFC", Offset = "0x1552BFC", VA = "0x1552BFC")]
		public CUI_ViveButtonState()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class CUI_ViveHapticPulse : MonoBehaviour
	{
		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float PulseStrength;

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1552C40", Offset = "0x1552C40", VA = "0x1552C40")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1552C4C", Offset = "0x1552C4C", VA = "0x1552C4C")]
		public void SetPulseStrength(float newStr)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1552C7C", Offset = "0x1552C7C", VA = "0x1552C7C")]
		public void TriggerPulse()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1552C80", Offset = "0x1552C80", VA = "0x1552C80")]
		public CUI_ViveHapticPulse()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class CUI_WorldSpaceCursorFollow : MonoBehaviour
	{
		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1552C88", Offset = "0x1552C88", VA = "0x1552C88")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1552EBC", Offset = "0x1552EBC", VA = "0x1552EBC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1552F4C", Offset = "0x1552F4C", VA = "0x1552F4C")]
		public CUI_WorldSpaceCursorFollow()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class CUI_WorldSpaceMouseMultipleCanvases : MonoBehaviour
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CurvedUISettings> ControlledCanvases;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform WorldSpaceMouse;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CurvedUISettings MouseCanvas;

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1552F54", Offset = "0x1552F54", VA = "0x1552F54")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1553258", Offset = "0x1553258", VA = "0x1553258")]
		public CUI_WorldSpaceMouseMultipleCanvases()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class CUI_draggable : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 savedVector;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isDragged;

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1553260", Offset = "0x1553260", VA = "0x1553260", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x155354C", Offset = "0x155354C", VA = "0x155354C", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1553550", Offset = "0x1553550", VA = "0x1553550", Slot = "5")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x15535D0", Offset = "0x15535D0", VA = "0x15535D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1553388", Offset = "0x1553388", VA = "0x1553388")]
		private void RaycastPosition(out Vector2 newPos)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x15536CC", Offset = "0x15536CC", VA = "0x15536CC")]
		public CUI_draggable()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class CUI_inventory_paralax : MonoBehaviour
	{
		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform front;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform back;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 initFG;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 initBG;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float change;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x15536D4", Offset = "0x15536D4", VA = "0x15536D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1553724", Offset = "0x1553724", VA = "0x1553724")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1553928", Offset = "0x1553928", VA = "0x1553928")]
		public CUI_inventory_paralax()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class CurvedUIEventSystem : EventSystem
	{
		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CurvedUIEventSystem instance;

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1555220", Offset = "0x1555220", VA = "0x1555220", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x155527C", Offset = "0x155527C", VA = "0x155527C")]
		public CurvedUIEventSystem()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public static class CurvedUIExtensionMethods
	{
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x15552E0", Offset = "0x15552E0", VA = "0x15552E0")]
		public static bool AlmostEqual(this Vector3 a, Vector3 b, double accuracy = 0.01)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x15524C4", Offset = "0x15524C4", VA = "0x15524C4")]
		public static float Remap(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1555310", Offset = "0x1555310", VA = "0x1555310")]
		public static float RemapAndClamp(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1555340", Offset = "0x1555340", VA = "0x1555340")]
		public static float Remap(this int value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1555360", Offset = "0x1555360", VA = "0x1555360")]
		public static double Remap(this double value, double from1, double to1, double from2, double to2)
		{
			return default(double);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1555338", Offset = "0x1555338", VA = "0x1555338")]
		public static float Clamp(this float value, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x155537C", Offset = "0x155537C", VA = "0x155537C")]
		public static float Clamp(this int value, int min, int max)
		{
			return default(float);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1555398", Offset = "0x1555398", VA = "0x1555398")]
		public static int Abs(this int value)
		{
			return default(int);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x15553A0", Offset = "0x15553A0", VA = "0x15553A0")]
		public static float Abs(this float value)
		{
			return default(float);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x15553A8", Offset = "0x15553A8", VA = "0x15553A8")]
		public static int ToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x15553B0", Offset = "0x15553B0", VA = "0x15553B0")]
		public static int FloorToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x15553B8", Offset = "0x15553B8", VA = "0x15553B8")]
		public static int CeilToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1551AA0", Offset = "0x1551AA0", VA = "0x1551AA0")]
		public static Vector3 ModifyX(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1551AA8", Offset = "0x1551AA8", VA = "0x1551AA8")]
		public static Vector3 ModifyY(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1551A98", Offset = "0x1551A98", VA = "0x1551A98")]
		public static Vector3 ModifyZ(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x15553C0", Offset = "0x15553C0", VA = "0x15553C0")]
		public static Vector2 ModifyVectorX(this Vector2 trans, float newVal)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x15553C8", Offset = "0x15553C8", VA = "0x15553C8")]
		public static Vector2 ModifyVectorY(this Vector2 trans, float newVal)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x15514C8", Offset = "0x15514C8", VA = "0x15514C8")]
		public static void ResetTransform(this Transform trans)
		{
		}

		[Token(Token = "0x60004D0")]
		public static T AddComponentIfMissing<T>(this GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		public static T AddComponentIfMissing<T>(this Component go) where T : Component
		{
			return null;
		}
	}
	[Token(Token = "0x20000D7")]
	public class CurvedUIHandSwitcher : MonoBehaviour
	{
		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject LaserBeam;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FE0CC", Offset = "0x8FE0CC")]
		[SerializeField]
		private bool autoSwitchHands;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FE118", Offset = "0x8FE118")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8FE118", Offset = "0x8FE118")]
		[SerializeField]
		private Transform leftHandOverride;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FE188", Offset = "0x8FE188")]
		private Transform rightHandOverride;

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x15553D0", Offset = "0x15553D0", VA = "0x15553D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1555704", Offset = "0x1555704", VA = "0x1555704")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1555440", Offset = "0x1555440", VA = "0x1555440")]
		private void SwitchHandTo(CurvedUIInputModule.Hand newHand)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1555C34", Offset = "0x1555C34", VA = "0x1555C34")]
		public CurvedUIHandSwitcher()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class CurvedUIInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FB094", Offset = "0x8FB094")]
		private sealed class <CaretBlinker>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUIInputFieldCaret <>4__this;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004E8")]
				[Address(RVA = "0x1A928CC", Offset = "0x1A928CC", VA = "0x1A928CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004EA")]
				[Address(RVA = "0x1A92914", Offset = "0x1A92914", VA = "0x1A92914", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x1A92788", Offset = "0x1A92788", VA = "0x1A92788")]
			[DebuggerHidden]
			public <CaretBlinker>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x1A927B4", Offset = "0x1A927B4", VA = "0x1A927B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x1A927B8", Offset = "0x1A927B8", VA = "0x1A927B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x1A928D4", Offset = "0x1A928D4", VA = "0x1A928D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private InputField myField;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int lastCharDist;

		[Token(Token = "0x170000B6")]
		public Color CaretColor
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x155662C", Offset = "0x155662C", VA = "0x155662C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x1556638", Offset = "0x1556638", VA = "0x1556638")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public Color SelectionColor
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x1556644", Offset = "0x1556644", VA = "0x1556644")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x1556650", Offset = "0x1556650", VA = "0x1556650")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x155665C", Offset = "0x155665C", VA = "0x155665C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x1556678", Offset = "0x1556678", VA = "0x1556678")]
			set
			{
			}
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1555C44", Offset = "0x1555C44", VA = "0x1555C44")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1555C98", Offset = "0x1555C98", VA = "0x1555C98")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1555F70", Offset = "0x1555F70", VA = "0x1555F70", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x15563B4", Offset = "0x15563B4", VA = "0x15563B4", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1556348", Offset = "0x1556348", VA = "0x1556348")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FFC7C", Offset = "0x8FFC7C")]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x155602C", Offset = "0x155602C", VA = "0x155602C")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1555CA8", Offset = "0x1555CA8", VA = "0x1555CA8")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x15563EC", Offset = "0x15563EC", VA = "0x15563EC")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1556694", Offset = "0x1556694", VA = "0x1556694")]
		public CurvedUIInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class CurvedUILaserBeam : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FB0A4", Offset = "0x8FB0A4")]
		private sealed class <>c
		{
			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__3_0;

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x1A9297C", Offset = "0x1A9297C", VA = "0x1A9297C")]
			public <>c()
			{
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x1A92984", Offset = "0x1A92984", VA = "0x1A92984")]
			internal bool <Update>b__3_0(GameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform LaserBeamTransform;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform LaserBeamDot;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool hideWhenNotAimingAtCanvas;

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1558E58", Offset = "0x1558E58", VA = "0x1558E58")]
		protected void Update()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1559290", Offset = "0x1559290", VA = "0x1559290")]
		public CurvedUILaserBeam()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class CurvedUIPhysicsRaycaster : BaseRaycaster
	{
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected int sortOrder;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private RaycastHit hitInfo;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RaycastResult result;

		[Token(Token = "0x170000BB")]
		public int CompoundEventMask
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x15595A8", Offset = "0x15595A8", VA = "0x15595A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BC")]
		public override Camera eventCamera
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x15596AC", Offset = "0x15596AC", VA = "0x15596AC", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public virtual int Depth
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x155977C", Offset = "0x155977C", VA = "0x155977C", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BE")]
		public override int sortOrderPriority
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1559850", Offset = "0x1559850", VA = "0x1559850", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1559298", Offset = "0x1559298", VA = "0x1559298")]
		protected CurvedUIPhysicsRaycaster()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x15592A8", Offset = "0x15592A8", VA = "0x15592A8", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class CurvedUIPointerEventData : PointerEventData
	{
		[Token(Token = "0x20000DE")]
		public enum ControllerType
		{
			[Token(Token = "0x40004DE")]
			NONE = -1,
			[Token(Token = "0x40004DF")]
			VIVE
		}

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public GameObject Controller;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Vector2 TouchPadAxis;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1559858", Offset = "0x1559858", VA = "0x1559858")]
		public CurvedUIPointerEventData(EventSystem eventSystem)
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class CurvedUIRaycaster : GraphicRaycaster
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FB0B4", Offset = "0x8FB0B4")]
		private sealed class <>c
		{
			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__21_0;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Comparison<Graphic> <>9__32_0;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<Graphic> <>9__55_0;

			[Token(Token = "0x600051E")]
			[Address(RVA = "0x1A92AE0", Offset = "0x1A92AE0", VA = "0x1A92AE0")]
			public <>c()
			{
			}

			[Token(Token = "0x600051F")]
			[Address(RVA = "0x1A92AE8", Offset = "0x1A92AE8", VA = "0x1A92AE8")]
			internal bool <Update>b__21_0(GameObject obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000520")]
			[Address(RVA = "0x1A92BB4", Offset = "0x1A92BB4", VA = "0x1A92BB4")]
			internal int <FlatRaycastAndSort>b__32_0(Graphic g1, Graphic g2)
			{
				return default(int);
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0x1A92C0C", Offset = "0x1A92C0C", VA = "0x1A92C0C")]
			internal int <GetObjectsHitByRay>b__55_0(Graphic g1, Graphic g2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool showDebug;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool overrideEventData;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas myCanvas;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 cyllinderMidPoint;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<GameObject> objectsUnderPointer;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 lastCanvasPos;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject colliderContainer;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PointerEventData lastFrameEventData;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private PointerEventData curEventData;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PointerEventData eventDataToUse;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Ray cachedRay;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Graphic gph;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<GameObject> selectablesUnderGaze;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<GameObject> selectablesUnderGazeLastFrame;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float objectsUnderGazeLastChangeTime;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool gazeClickExecuted;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		private bool pointingAtCanvas;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		private bool pointingAtCanvasLastFrame;

		[NonSerialized]
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<Graphic> m_RaycastResults;

		[NonSerialized]
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Graphic> s_SortedGraphics;

		[Token(Token = "0x170000BF")]
		private Image GazeProgressImage
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x155A744", Offset = "0x155A744", VA = "0x155A744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x1560984", Offset = "0x1560984", VA = "0x1560984")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1559894", Offset = "0x1559894", VA = "0x1559894", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1559988", Offset = "0x1559988", VA = "0x1559988", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x155A180", Offset = "0x155A180", VA = "0x155A180", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x155A580", Offset = "0x155A580", VA = "0x155A580")]
		private void ProcessGazeTimedClick()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x155A554", Offset = "0x155A554", VA = "0x155A554")]
		private void ResetGazeTimedClick()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x155AD40", Offset = "0x155AD40", VA = "0x155AD40", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x155BFD8", Offset = "0x155BFD8", VA = "0x155BFD8", Slot = "23")]
		public virtual bool RaycastToCyllinderCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x155C6E8", Offset = "0x155C6E8", VA = "0x155C6E8", Slot = "24")]
		public virtual bool RaycastToCyllinderVerticalCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x155CCF0", Offset = "0x155CCF0", VA = "0x155CCF0", Slot = "25")]
		public virtual bool RaycastToRingCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x155D204", Offset = "0x155D204", VA = "0x155D204", Slot = "26")]
		public virtual bool RaycastToSphereCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x155BA34", Offset = "0x155BA34", VA = "0x155BA34")]
		private void FlatRaycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x155DB10", Offset = "0x155DB10", VA = "0x155DB10")]
		private static void FlatRaycastAndSort(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1559C1C", Offset = "0x1559C1C", VA = "0x1559C1C")]
		protected void CreateCollider()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x155F5E0", Offset = "0x155F5E0", VA = "0x155F5E0")]
		private void SetupMeshColliderUsingMesh(Mesh meshie)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x155E060", Offset = "0x155E060", VA = "0x155E060")]
		private GameObject CreateConvexCyllinderCollider(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x155EC34", Offset = "0x155EC34", VA = "0x155EC34")]
		private Mesh CreateCyllinderColliderMesh(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x155F698", Offset = "0x155F698", VA = "0x155F698")]
		private Mesh CreateSphereColliderMesh()
		{
			return null;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x155FFE4", Offset = "0x155FFE4", VA = "0x155FFE4")]
		private bool IsInLayerMask(int layer, LayerMask layermask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x155C5DC", Offset = "0x155C5DC", VA = "0x155C5DC")]
		private LayerMask GetRaycastLayerMask()
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x155C644", Offset = "0x155C644", VA = "0x155C644")]
		private float AngleSigned(Vector3 v1, Vector3 v2, Vector3 n)
		{
			return default(float);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x156003C", Offset = "0x156003C", VA = "0x156003C")]
		private bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x156008C", Offset = "0x156008C", VA = "0x156008C", Slot = "27")]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x155B48C", Offset = "0x155B48C", VA = "0x155B48C")]
		protected void UpdateSelectedObjects(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x15600A4", Offset = "0x15600A4", VA = "0x15600A4")]
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x15606AC", Offset = "0x15606AC", VA = "0x15606AC")]
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1560850", Offset = "0x1560850", VA = "0x1560850")]
		private bool GetScreenSpacePointByRay(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1559A14", Offset = "0x1559A14", VA = "0x1559A14")]
		private bool CheckEventCamera()
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x156098C", Offset = "0x156098C", VA = "0x156098C")]
		public void RebuildCollider()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1551A1C", Offset = "0x1551A1C", VA = "0x1551A1C")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x15609CC", Offset = "0x15609CC", VA = "0x15609CC")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 screenPos, [System.Runtime.InteropServices.Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1560AB4", Offset = "0x1560AB4", VA = "0x1560AB4")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x155A7AC", Offset = "0x155A7AC", VA = "0x155A7AC")]
		public void Click()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x155FCB8", Offset = "0x155FCB8", VA = "0x155FCB8")]
		private void ModifyQuad(List<Vector3> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1560FA0", Offset = "0x1560FA0", VA = "0x1560FA0")]
		private Vector3 TesselateQuad(List<Vector3> quad, float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1561154", Offset = "0x1561154", VA = "0x1561154")]
		public CurvedUIRaycaster()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8FB0C4", Offset = "0x8FB0C4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8FB0C4", Offset = "0x8FB0C4")]
	public class CurvedUISettings : MonoBehaviour
	{
		[Token(Token = "0x20000E2")]
		public enum CurvedUIShape
		{
			[Token(Token = "0x400050B")]
			CYLINDER,
			[Token(Token = "0x400050C")]
			RING,
			[Token(Token = "0x400050D")]
			SPHERE,
			[Token(Token = "0x400050E")]
			CYLINDER_VERTICAL
		}

		[Token(Token = "0x40004F9")]
		public const string Version = "3.3";

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUIShape shape;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float quality;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool interactable;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool blocksRaycasts;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool forceUseBoxCollider;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int angle;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool preserveAspect;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int vertAngle;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float ringFill;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int ringExternalDiamater;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool ringFlipVertical;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int baseCircleSegments;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 savedRectSize;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float savedRadius;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas myCanvas;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform m_rectTransform;

		[Token(Token = "0x170000C1")]
		private RectTransform RectTransform
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x13589F4", Offset = "0x13589F4", VA = "0x13589F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public int BaseCircleSegments
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x135A2F4", Offset = "0x135A2F4", VA = "0x135A2F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C3")]
		public int Angle
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x135A2FC", Offset = "0x135A2FC", VA = "0x135A2FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x135A304", Offset = "0x135A304", VA = "0x135A304")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public float Quality
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x135A318", Offset = "0x135A318", VA = "0x135A318")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x135A320", Offset = "0x135A320", VA = "0x135A320")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public CurvedUIShape Shape
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x135A33C", Offset = "0x135A33C", VA = "0x135A33C")]
			get
			{
				return default(CurvedUIShape);
			}
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x135A344", Offset = "0x135A344", VA = "0x135A344")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public int VerticalAngle
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x135A364", Offset = "0x135A364", VA = "0x135A364")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x135A36C", Offset = "0x135A36C", VA = "0x135A36C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public float RingFill
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x135A38C", Offset = "0x135A38C", VA = "0x135A38C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x135A394", Offset = "0x135A394", VA = "0x135A394")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public float SavedRadius
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x1359520", Offset = "0x1359520", VA = "0x1359520")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C9")]
		public int RingExternalDiameter
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x135A3B0", Offset = "0x135A3B0", VA = "0x135A3B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x135A3B8", Offset = "0x135A3B8", VA = "0x135A3B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public bool RingFlipVertical
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x135A3D8", Offset = "0x135A3D8", VA = "0x135A3D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x135A3E0", Offset = "0x135A3E0", VA = "0x135A3E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public bool PreserveAspect
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x135A40C", Offset = "0x135A40C", VA = "0x135A40C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x135A414", Offset = "0x135A414", VA = "0x135A414")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public bool Interactable
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x135A440", Offset = "0x135A440", VA = "0x135A440")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x135A448", Offset = "0x135A448", VA = "0x135A448")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public bool ForceUseBoxCollider
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x135A454", Offset = "0x135A454", VA = "0x135A454")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x135A45C", Offset = "0x135A45C", VA = "0x135A45C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public bool BlocksRaycasts
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x135A468", Offset = "0x135A468", VA = "0x135A468")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x135A470", Offset = "0x135A470", VA = "0x135A470")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8FFE94", Offset = "0x8FFE94")]
		public bool RaycastMyLayerOnly
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x135A564", Offset = "0x135A564", VA = "0x135A564")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x135A56C", Offset = "0x135A56C", VA = "0x135A56C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x135A628", Offset = "0x135A628", VA = "0x135A628")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D1")]
		public CurvedUIInputModule.CUIControlMethod ControlMethod
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x135A804", Offset = "0x135A804", VA = "0x135A804")]
			get
			{
				return default(CurvedUIInputModule.CUIControlMethod);
			}
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x135A860", Offset = "0x135A860", VA = "0x135A860")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public bool GazeUseTimedClick
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x135AC6C", Offset = "0x135AC6C", VA = "0x135AC6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x135ACD8", Offset = "0x135ACD8", VA = "0x135ACD8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public float GazeClickTimer
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x135AD4C", Offset = "0x135AD4C", VA = "0x135AD4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x135ADB8", Offset = "0x135ADB8", VA = "0x135ADB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public float GazeClickTimerDelay
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x135AE34", Offset = "0x135AE34", VA = "0x135AE34")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x135AEA0", Offset = "0x135AEA0", VA = "0x135AEA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public float GazeTimerProgress
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x135AF1C", Offset = "0x135AF1C", VA = "0x135AF1C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1358968", Offset = "0x1358968", VA = "0x1358968")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1358AA8", Offset = "0x1358AA8", VA = "0x1358AA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1358F8C", Offset = "0x1358F8C", VA = "0x1358F8C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1359038", Offset = "0x1359038", VA = "0x1359038")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x13590E4", Offset = "0x13590E4", VA = "0x13590E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1359210", Offset = "0x1359210", VA = "0x1359210")]
		private void SetUIAngle(int newAngle)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1359438", Offset = "0x1359438", VA = "0x1359438")]
		private Vector3 CanvasToCyllinder(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1359550", Offset = "0x1359550", VA = "0x1359550")]
		private Vector3 CanvasToCyllinderVertical(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1359638", Offset = "0x1359638", VA = "0x1359638")]
		private Vector3 CanvasToRing(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1359728", Offset = "0x1359728", VA = "0x1359728")]
		private Vector3 CanvasToSphere(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x13598C4", Offset = "0x13598C4", VA = "0x13598C4")]
		public void AddEffectToChildren()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1359C84", Offset = "0x1359C84", VA = "0x1359C84")]
		public Vector3 VertexPositionToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1359CBC", Offset = "0x1359CBC", VA = "0x1359CBC")]
		public Vector3 CanvasToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1359D7C", Offset = "0x1359D7C", VA = "0x1359D7C")]
		public Vector3 CanvasToCurvedCanvasNormal(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1359F60", Offset = "0x1359F60", VA = "0x1359F60")]
		public bool RaycastToCanvasSpace(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1358E54", Offset = "0x1358E54", VA = "0x1358E54")]
		public float GetCyllinderRadiusInCanvasSpace()
		{
			return default(float);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x135A0E8", Offset = "0x135A0E8", VA = "0x135A0E8")]
		public Vector2 GetTesslationSize(bool modifiedByQuality = true)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x135A254", Offset = "0x135A254", VA = "0x135A254")]
		private float GetSegmentsByAngle(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x135A570", Offset = "0x135A570", VA = "0x135A570")]
		public void SetAllChildrenDirty(bool recalculateCurveOnly = false)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x135A73C", Offset = "0x135A73C", VA = "0x135A73C")]
		public void Click()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x135A8C4", Offset = "0x135A8C4", VA = "0x135A8C4")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x135A9CC", Offset = "0x135A9CC", VA = "0x135A9CC")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 pos, [System.Runtime.InteropServices.Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x135AB38", Offset = "0x135AB38", VA = "0x135AB38")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x135AF88", Offset = "0x135AF88", VA = "0x135AF88")]
		public CurvedUISettings()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class CurvedUIVertexEffect : BaseMeshEffect
	{
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8FE2D4", Offset = "0x8FE2D4")]
		public bool DoNotTesselate;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Canvas myCanvas;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Graphic myGraphic;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text myText;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI myTMP;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUITMPSubmesh myTMPSubMesh;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_tesselationRequired;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool curvingRequired;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool TransformMisaligned;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Matrix4x4 CanvasToWorld;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Matrix4x4 CanvasToLocal;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Matrix4x4 MyToWorld;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Matrix4x4 MyToLocal;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private List<UIVertex> m_tesselatedVerts;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<UIVertex> m_curvedVerts;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private List<UIVertex> m_vertsInQuads;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private UIVertex m_ret;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private UIVertex[] m_quad;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private float[] m_weights;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		[HideInInspector]
		private Vector3 savedPos;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		[SerializeField]
		[HideInInspector]
		private Vector3 savedUp;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[HideInInspector]
		[SerializeField]
		private Vector2 savedRectSize;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[HideInInspector]
		[SerializeField]
		private Color savedColor;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		[SerializeField]
		[HideInInspector]
		private Vector4 savedTextUV0;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		[SerializeField]
		[HideInInspector]
		private float savedFill;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private Vector4 _uv0;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private Vector4 _uv1;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private Vector3 _pos;

		[Token(Token = "0x170000D6")]
		private bool tesselationRequired
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x135D664", Offset = "0x135D664", VA = "0x135D664")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x135D66C", Offset = "0x135D66C", VA = "0x135D66C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public bool TesselationRequired
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x136024C", Offset = "0x136024C", VA = "0x136024C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x1360240", Offset = "0x1360240", VA = "0x1360240")]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public bool CurvingRequired
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x1360254", Offset = "0x1360254", VA = "0x1360254")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x136025C", Offset = "0x136025C", VA = "0x136025C")]
			set
			{
			}
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x135D678", Offset = "0x135D678", VA = "0x135D678", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x135D744", Offset = "0x135D744", VA = "0x135D744", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x135DA30", Offset = "0x135DA30", VA = "0x135DA30", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x135E02C", Offset = "0x135E02C", VA = "0x135E02C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x135E1E4", Offset = "0x135E1E4", VA = "0x135E1E4")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x135E1F0", Offset = "0x135E1F0", VA = "0x135E1F0")]
		private void FontTextureRebuiltCallback(Font fontie)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x135E290", Offset = "0x135E290", VA = "0x135E290")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x135E7F0", Offset = "0x135E7F0", VA = "0x135E7F0", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x135BF50", Offset = "0x135BF50", VA = "0x135BF50")]
		public void ModifyTMPMesh(ref List<UIVertex> vertexList)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x135EED0", Offset = "0x135EED0", VA = "0x135EED0")]
		private bool ShouldModify()
		{
			return default(bool);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x135EFD0", Offset = "0x135EFD0", VA = "0x135EFD0")]
		private void CheckTextFontMaterial()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x135D920", Offset = "0x135D920", VA = "0x135D920")]
		public CurvedUISettings FindParentSettings(bool forceNew = false)
		{
			return null;
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x135F444", Offset = "0x135F444", VA = "0x135F444")]
		private UIVertex CurveVertex(UIVertex input, float cylinder_angle, float radius, Vector2 canvasSize)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x135F274", Offset = "0x135F274", VA = "0x135F274")]
		private void TesselateGeometry(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x135FA04", Offset = "0x135FA04", VA = "0x135FA04")]
		private void ModifyQuad(List<UIVertex> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x135F76C", Offset = "0x135F76C", VA = "0x135F76C")]
		private void TrisToQuads(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x135FEDC", Offset = "0x135FEDC", VA = "0x135FEDC")]
		private UIVertex TesselateQuad(float x, float y)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x135942C", Offset = "0x135942C", VA = "0x135942C")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1360268", Offset = "0x1360268", VA = "0x1360268")]
		public CurvedUIVertexEffect()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class CurvedUIViveController : MonoBehaviour
	{
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1360368", Offset = "0x1360368", VA = "0x1360368")]
		public CurvedUIViveController()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public struct ViveInputArgs
	{
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint controllerIndex;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float buttonPressure;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 touchpadAxis;
	}
	[Token(Token = "0x20000E6")]
	public delegate void ViveInputEvent(object sender, ViveInputArgs e);
	[Token(Token = "0x20000E7")]
	public delegate void ViveEvent(object sender);
	[Token(Token = "0x20000E8")]
	[ExecuteInEditMode]
	public class CurvedUITMP : MonoBehaviour
	{
		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshProUGUI tmpText;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UIVertex> m_UIVerts;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UIVertex m_tempVertex;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private CurvedUITMPSubmesh m_tempSubMsh;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector2 savedSize;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 savedUp;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector3 savedPos;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 savedLocalScale;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 savedGlobalScale;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<CurvedUITMPSubmesh> subMeshes;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public bool Dirty;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool curvingRequired;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool tesselationRequired;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF3")]
		private bool quitting;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3[] vertices;

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x135AFCC", Offset = "0x135AFCC", VA = "0x135AFCC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x135B064", Offset = "0x135B064", VA = "0x135B064")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x135B384", Offset = "0x135B384", VA = "0x135B384")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x135B520", Offset = "0x135B520", VA = "0x135B520")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x135B52C", Offset = "0x135B52C", VA = "0x135B52C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x135BD04", Offset = "0x135BD04", VA = "0x135BD04")]
		private void CreateUIVertexList(Mesh mesh)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x135C8B0", Offset = "0x135C8B0", VA = "0x135C8B0")]
		private void GetUIVertexFromMesh(ref UIVertex vert, int i)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x135C264", Offset = "0x135C264", VA = "0x135C264")]
		private void FillMeshWithUIVertexList(Mesh mesh, List<UIVertex> list)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x135B238", Offset = "0x135B238", VA = "0x135B238")]
		private void FindTMP()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x135C3D8", Offset = "0x135C3D8", VA = "0x135C3D8")]
		private void FindSubmeshes()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x135BA30", Offset = "0x135BA30", VA = "0x135BA30")]
		private bool ShouldTesselate()
		{
			return default(bool);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x135C900", Offset = "0x135C900", VA = "0x135C900")]
		private void TMPTextChangedCallback(object obj)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x135C91C", Offset = "0x135C91C", VA = "0x135C91C")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x135C928", Offset = "0x135C928", VA = "0x135C928")]
		public CurvedUITMP()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	[ExecuteInEditMode]
	public class CurvedUITMPInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8FB168", Offset = "0x8FB168")]
		private sealed class <CaretBlinker>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUITMPInputFieldCaret <>4__this;

			[Token(Token = "0x170000DC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005A2")]
				[Address(RVA = "0x1A92DA8", Offset = "0x1A92DA8", VA = "0x1A92DA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0x1A92DF0", Offset = "0x1A92DF0", VA = "0x1A92DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x1A92C64", Offset = "0x1A92C64", VA = "0x1A92C64")]
			[DebuggerHidden]
			public <CaretBlinker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x1A92C90", Offset = "0x1A92C90", VA = "0x1A92C90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x1A92C94", Offset = "0x1A92C94", VA = "0x1A92C94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1A92DB0", Offset = "0x1A92DB0", VA = "0x1A92DB0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_InputField myField;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x170000D9")]
		public Color CaretColor
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x135D5EC", Offset = "0x135D5EC", VA = "0x135D5EC")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x135D5F8", Offset = "0x135D5F8", VA = "0x135D5F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public Color SelectionColor
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x135D604", Offset = "0x135D604", VA = "0x135D604")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x135D610", Offset = "0x135D610", VA = "0x135D610")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x135D61C", Offset = "0x135D61C", VA = "0x135D61C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x135D638", Offset = "0x135D638", VA = "0x135D638")]
			set
			{
			}
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x135C9E0", Offset = "0x135C9E0", VA = "0x135C9E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x135CE18", Offset = "0x135CE18", VA = "0x135CE18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x135D0D0", Offset = "0x135D0D0", VA = "0x135D0D0", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x135D534", Offset = "0x135D534", VA = "0x135D534", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x135D4C8", Offset = "0x135D4C8", VA = "0x135D4C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8FFD2C", Offset = "0x8FFD2C")]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x135D18C", Offset = "0x135D18C", VA = "0x135D18C")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x135CE28", Offset = "0x135CE28", VA = "0x135CE28")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x135D56C", Offset = "0x135D56C", VA = "0x135D56C")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x135CA84", Offset = "0x135CA84", VA = "0x135CA84")]
		private void CheckAndConvertMask()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x135D654", Offset = "0x135D654", VA = "0x135D654")]
		public CurvedUITMPInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	[ExecuteInEditMode]
	public class CurvedUITMPSubmesh : MonoBehaviour
	{
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VertexHelper vh;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh straightMesh;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mesh curvedMesh;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TMP_SubMeshUI TMPsub;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI TMPtext;

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x135C504", Offset = "0x135C504", VA = "0x135C504")]
		public void UpdateSubmesh(bool tesselate, bool curve)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x135D65C", Offset = "0x135D65C", VA = "0x135D65C")]
		public CurvedUITMPSubmesh()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x8FB188", Offset = "0x8FB188")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x8FB188", Offset = "0x8FB188")]
	public class OptionalDependencyAttribute : Attribute
	{
		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string dependentClass;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string define;

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x136A334", Offset = "0x136A334", VA = "0x136A334")]
		public OptionalDependencyAttribute(string dependentClass, string define)
		{
		}
	}
}
namespace TFHC_Shader_Samples
{
	[Token(Token = "0x20000ED")]
	public class highlightAnimated : MonoBehaviour
	{
		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Material mat;

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1A91A74", Offset = "0x1A91A74", VA = "0x1A91A74")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1A91AD8", Offset = "0x1A91AD8", VA = "0x1A91AD8")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1A91B54", Offset = "0x1A91B54", VA = "0x1A91B54")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1A91AE0", Offset = "0x1A91AE0", VA = "0x1A91AE0")]
		private void switchhighlighted(bool highlighted)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1A91B5C", Offset = "0x1A91B5C", VA = "0x1A91B5C")]
		public highlightAnimated()
		{
		}
	}
}
namespace TFHC_ForceShield_Shader_Sample
{
	[Token(Token = "0x20000EE")]
	public class ForceShieldDestroyBall : MonoBehaviour
	{
		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float lifetime;

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1360AB0", Offset = "0x1360AB0", VA = "0x1360AB0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1360B38", Offset = "0x1360B38", VA = "0x1360B38")]
		public ForceShieldDestroyBall()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class ForceShieldImpactDetection : MonoBehaviour
	{
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float hitTime;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material mat;

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1360B48", Offset = "0x1360B48", VA = "0x1360B48")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1360BAC", Offset = "0x1360BAC", VA = "0x1360BAC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1360C4C", Offset = "0x1360C4C", VA = "0x1360C4C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1360DC4", Offset = "0x1360DC4", VA = "0x1360DC4")]
		public ForceShieldImpactDetection()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class ForceShieldShootBall : MonoBehaviour
	{
		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody bullet;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform origshoot;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float distance;

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1360DCC", Offset = "0x1360DCC", VA = "0x1360DCC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1360FAC", Offset = "0x1360FAC", VA = "0x1360FAC")]
		public ForceShieldShootBall()
		{
		}
	}
}
namespace RenderHeads.Media.AVProVideo.Demos.UI
{
	[Token(Token = "0x20000F1")]
	[ExecuteInEditMode]
	public class HorizontalSegmentsPrimitive : Graphic
	{
		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float[] _segments;

		[Token(Token = "0x170000DE")]
		public float[] Segments
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x1365294", Offset = "0x1365294", VA = "0x1365294")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x136529C", Offset = "0x136529C", VA = "0x136529C")]
			set
			{
			}
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x13652A0", Offset = "0x13652A0", VA = "0x13652A0")]
		private void SetSegments(float[] segments)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1365328", Offset = "0x1365328", VA = "0x1365328", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1365834", Offset = "0x1365834", VA = "0x1365834")]
		public HorizontalSegmentsPrimitive()
		{
		}
	}
}
