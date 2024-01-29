using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;
using UnityEngine;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class DecalDestroyer : MonoBehaviour
{
	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ED5EC", Offset = "0x7ED5EC")]
	private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DecalDestroyer <>4__this;

		[Token(Token = "0x17000004")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x92AB54", Offset = "0x92AB54", VA = "0x92AB54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x92ABBC", Offset = "0x92ABBC", VA = "0x92ABBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x92AA28", Offset = "0x92AA28", VA = "0x92AA28")]
		[DebuggerHidden]
		public <Start>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x92AA64", Offset = "0x92AA64", VA = "0x92AA64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x92AA68", Offset = "0x92AA68", VA = "0x92AA68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x92AB5C", Offset = "0x92AB5C", VA = "0x92AB5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float lifeTime;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x92A9B8", Offset = "0x92A9B8", VA = "0x92A9B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7ED9B8", Offset = "0x7ED9B8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x92AA54", Offset = "0x92AA54", VA = "0x92AA54")]
	public DecalDestroyer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000003")]
public class ParticleExamples
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string title;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x7ED714", Offset = "0x7ED714")]
	public string description;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isWeaponEffect;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject particleSystemGO;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 particlePosition;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 particleRotation;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x92ABC4", Offset = "0x92ABC4", VA = "0x92ABC4")]
	public ParticleExamples()
	{
	}
}
[Token(Token = "0x2000004")]
public class ParticleMenu : MonoBehaviour
{
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleExamples[] particleSystems;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject gunGameObject;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int currentIndex;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject currentGO;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform spawnLocation;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text title;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text description;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text navigationDetails;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x92ABCC", Offset = "0x92ABCC", VA = "0x92ABCC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x92ABF4", Offset = "0x92ABF4", VA = "0x92ABF4")]
	public void Navigate(int i)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x92AFAC", Offset = "0x92AFAC", VA = "0x92AFAC")]
	public ParticleMenu()
	{
	}
}
[Token(Token = "0x2000005")]
[ExecuteInEditMode]
public class WaterAnim : MonoBehaviour
{
	[Token(Token = "0x4000010")]
	private const float fourPi = (float)Math.PI * 4f;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float waveScale;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector4 waveSpeed;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float sinInput;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xDF7574", Offset = "0xDF7574", VA = "0xDF7574")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xDF7768", Offset = "0xDF7768", VA = "0xDF7768")]
	public WaterAnim()
	{
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000006")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EC298", Offset = "0x7EC298")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xDF30EC", Offset = "0xDF30EC", VA = "0xDF30EC")]
		public void Awake()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xDF3110", Offset = "0xDF3110", VA = "0xDF3110")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xDF3170", Offset = "0xDF3170", VA = "0xDF3170")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xDF31D0", Offset = "0xDF31D0", VA = "0xDF31D0")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EC30C", Offset = "0x7EC30C")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0xDF31D8", Offset = "0xDF31D8", VA = "0xDF31D8")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class MeshContainer
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xDF31E0", Offset = "0xDF31E0", VA = "0xDF31E0")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xDF3234", Offset = "0xDF3234", VA = "0xDF3234")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000009")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EC380", Offset = "0x7EC380")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xDF3278", Offset = "0xDF3278", VA = "0xDF3278")]
		public void Start()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xDF3368", Offset = "0xDF3368", VA = "0xDF3368")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xDF3670", Offset = "0xDF3670", VA = "0xDF3670")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xDF3724", Offset = "0xDF3724", VA = "0xDF3724")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xDF382C", Offset = "0xDF382C", VA = "0xDF382C")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xDF40F4", Offset = "0xDF40F4", VA = "0xDF40F4")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xDF4154", Offset = "0xDF4154", VA = "0xDF4154")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xDF424C", Offset = "0xDF424C", VA = "0xDF424C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xDF42AC", Offset = "0xDF42AC", VA = "0xDF42AC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xDF3994", Offset = "0xDF3994", VA = "0xDF3994")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xDF430C", Offset = "0xDF430C", VA = "0xDF430C")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xDF480C", Offset = "0xDF480C", VA = "0xDF480C")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xDF4370", Offset = "0xDF4370", VA = "0xDF4370")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xDF4A44", Offset = "0xDF4A44", VA = "0xDF4A44")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xDF4628", Offset = "0xDF4628", VA = "0xDF4628")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xDF4A64", Offset = "0xDF4A64", VA = "0xDF4A64")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EC3F4", Offset = "0x7EC3F4")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xDF4AD8", Offset = "0xDF4AD8", VA = "0xDF4AD8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xDF4BC4", Offset = "0xDF4BC4", VA = "0xDF4BC4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xDF4DEC", Offset = "0xDF4DEC", VA = "0xDF4DEC")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000166")]
		public enum WaterMode
		{
			[Token(Token = "0x40006E4")]
			Simple,
			[Token(Token = "0x40006E5")]
			Reflective,
			[Token(Token = "0x40006E6")]
			Refractive
		}

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xDF4DF4", Offset = "0xDF4DF4", VA = "0xDF4DF4")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xDF6998", Offset = "0xDF6998", VA = "0xDF6998")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xDF6C84", Offset = "0xDF6C84", VA = "0xDF6C84")]
		private void Update()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xDF62B4", Offset = "0xDF62B4", VA = "0xDF62B4")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xDF58AC", Offset = "0xDF58AC", VA = "0xDF58AC")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xDF5898", Offset = "0xDF5898", VA = "0xDF5898")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xDF5750", Offset = "0xDF5750", VA = "0xDF5750")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xDF67B4", Offset = "0xDF67B4", VA = "0xDF67B4")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xDF6510", Offset = "0xDF6510", VA = "0xDF6510")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xDF6F10", Offset = "0xDF6F10", VA = "0xDF6F10")]
		public Water()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public enum WaterQuality
	{
		[Token(Token = "0x4000031")]
		High = 2,
		[Token(Token = "0x4000032")]
		Medium = 1,
		[Token(Token = "0x4000033")]
		Low = 0
	}
	[Token(Token = "0x200000D")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xDF6FEC", Offset = "0xDF6FEC", VA = "0xDF6FEC")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xDF716C", Offset = "0xDF716C", VA = "0xDF716C")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xDF7220", Offset = "0xDF7220", VA = "0xDF7220")]
		public void Update()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xDF72A4", Offset = "0xDF72A4", VA = "0xDF72A4")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xDF72BC", Offset = "0xDF72BC", VA = "0xDF72BC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xDF72C0", Offset = "0xDF72C0", VA = "0xDF72C0")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xDF7464", Offset = "0xDF7464", VA = "0xDF7464")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xDF756C", Offset = "0xDF756C", VA = "0xDF756C")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x200000F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EC498", Offset = "0x7EC498")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EC498", Offset = "0x7EC498")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x2000167")]
		public enum BlurType
		{
			[Token(Token = "0x40006E8")]
			DiscBlur,
			[Token(Token = "0x40006E9")]
			DX11
		}

		[Token(Token = "0x2000168")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x40006EB")]
			Low,
			[Token(Token = "0x40006EC")]
			Medium,
			[Token(Token = "0x40006ED")]
			High
		}

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xDEE920", Offset = "0xDEE920", VA = "0xDEE920", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xDEEFE0", Offset = "0xDEEFE0", VA = "0xDEEFE0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xDEF058", Offset = "0xDEF058", VA = "0xDEF058")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xDEF160", Offset = "0xDEF160", VA = "0xDEF160")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xDEEE1C", Offset = "0xDEEE1C", VA = "0xDEEE1C")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xDEF1A4", Offset = "0xDEF1A4", VA = "0xDEF1A4")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xDEF300", Offset = "0xDEF300", VA = "0xDEF300")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xDEF620", Offset = "0xDEF620", VA = "0xDEF620")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xDF0C78", Offset = "0xDF0C78", VA = "0xDF0C78")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EC530", Offset = "0x7EC530")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EC530", Offset = "0x7EC530")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000001")]
		protected Material material
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xDF1A74", Offset = "0xDF1A74", VA = "0xDF1A74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xDF19D0", Offset = "0xDF19D0", VA = "0xDF19D0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xDF1B38", Offset = "0xDF1B38", VA = "0xDF1B38", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xDF1BE8", Offset = "0xDF1BE8", VA = "0xDF1BE8")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EC5B8", Offset = "0x7EC5B8")]
	public class ImageEffects
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0xDF1BF0", Offset = "0xDF1BF0", VA = "0xDF1BF0")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xDF1E6C", Offset = "0xDF1E6C", VA = "0xDF1E6C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7EDA1C", Offset = "0x7EDA1C")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xDF1EE4", Offset = "0xDF1EE4", VA = "0xDF1EE4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7EDA54", Offset = "0x7EDA54")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xDF1F64", Offset = "0xDF1F64", VA = "0xDF1F64")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EC5F0", Offset = "0x7EC5F0")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xDEEAA0", Offset = "0xDEEAA0", VA = "0xDEEAA0")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xDF1F98", Offset = "0xDF1F98", VA = "0xDF1F98")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xDF2174", Offset = "0xDF2174", VA = "0xDF2174")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xDF2180", Offset = "0xDF2180", VA = "0xDF2180")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xDF2184", Offset = "0xDF2184", VA = "0xDF2184")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xDF2234", Offset = "0xDF2234", VA = "0xDF2234")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xDF223C", Offset = "0xDF223C", VA = "0xDF223C", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xDF22EC", Offset = "0xDF22EC", VA = "0xDF22EC")]
		protected void Start()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xDEE9A4", Offset = "0xDEE9A4", VA = "0xDEE9A4")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xDF22F8", Offset = "0xDF22F8", VA = "0xDF22F8")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xDF2354", Offset = "0xDF2354", VA = "0xDF2354")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xDEEF38", Offset = "0xDEEF38", VA = "0xDEEF38")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xDF235C", Offset = "0xDF235C", VA = "0xDF235C")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xDF1F6C", Offset = "0xDF1F6C", VA = "0xDF1F6C")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xDF255C", Offset = "0xDF255C", VA = "0xDF255C")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xDF0CCC", Offset = "0xDF0CCC", VA = "0xDF0CCC")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EC664", Offset = "0x7EC664")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0xDF28D8", Offset = "0xDF28D8", VA = "0xDF28D8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xDF2944", Offset = "0xDF2944", VA = "0xDF2944")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xDF2BC0", Offset = "0xDF2BC0", VA = "0xDF2BC0")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xDF2F38", Offset = "0xDF2F38", VA = "0xDF2F38")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xDF30E4", Offset = "0xDF30E4", VA = "0xDF30E4")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EC6D8", Offset = "0x7EC6D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EC6D8", Offset = "0x7EC6D8")]
	internal class GlobalFog : PostEffectsBase
	{
		[Serializable]
		[Token(Token = "0x2000169")]
		public class AdvancedFog
		{
			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED8D0", Offset = "0x7ED8D0")]
			public bool UseScattering;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float Turbidity;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float WorldScale;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float Rayleigh;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED908", Offset = "0x7ED908")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED908", Offset = "0x7ED908")]
			public float ScatteringSize;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED960", Offset = "0x7ED960")]
			public float ScatteringIntensity;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float Bias;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float contrast;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float luminance;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lumaAmount;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[HideInInspector]
			public float Falloff;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[HideInInspector]
			public float BoostColor;

			[Token(Token = "0x600089E")]
			[Address(RVA = "0xDF199C", Offset = "0xDF199C", VA = "0xDF199C")]
			public AdvancedFog()
			{
			}
		}

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED724", Offset = "0x7ED724")]
		public bool distanceFog;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED75C", Offset = "0x7ED75C")]
		public bool useRadialDistance;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED794", Offset = "0x7ED794")]
		public bool heightFog;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED7CC", Offset = "0x7ED7CC")]
		public float height;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED804", Offset = "0x7ED804")]
		public float heightDensity;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED820", Offset = "0x7ED820")]
		public float startDistance;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED858", Offset = "0x7ED858")]
		public bool AffectSkyBox;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public AdvancedFog Advanced;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader fogShader;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material fogMaterial;

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xDF0D48", Offset = "0xDF0D48", VA = "0xDF0D48", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xDF0DA0", Offset = "0xDF0DA0", VA = "0xDF0DA0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xDF180C", Offset = "0xDF180C", VA = "0xDF180C")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xDF197C", Offset = "0xDF197C", VA = "0xDF197C")]
		public GlobalFog()
		{
		}
	}
}
namespace Steamworks
{
	[Token(Token = "0x2000015")]
	public static class CallbackDispatcher
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x92C51C", Offset = "0x92C51C", VA = "0x92C51C")]
		public static void ExceptionHandler(Exception e)
		{
		}
	}
	[Token(Token = "0x2000016")]
	public sealed class Callback<T>
	{
		[Token(Token = "0x200016A")]
		public delegate void DispatchDelegate(T param);

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBaseVTable VTable;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr m_pVTable;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBase m_CCallbackBase;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GCHandle m_pCCallbackBase;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_bGameServer;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int m_size;

		[Token(Token = "0x14000001")]
		private event DispatchDelegate m_Func
		{
			[Token(Token = "0x6000060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EDA8C", Offset = "0x7EDA8C")]
			add
			{
			}
			[Token(Token = "0x6000061")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EDA9C", Offset = "0x7EDA9C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000062")]
		public static Callback<T> Create(DispatchDelegate func)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		public static Callback<T> CreateGameServer(DispatchDelegate func)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		public Callback(DispatchDelegate func, bool bGameServer = false)
		{
		}

		[Token(Token = "0x6000065")]
		~Callback()
		{
		}

		[Token(Token = "0x6000066")]
		public void Register(DispatchDelegate func)
		{
		}

		[Token(Token = "0x6000067")]
		public void Unregister()
		{
		}

		[Token(Token = "0x6000068")]
		public void SetGameserverFlag()
		{
		}

		[Token(Token = "0x6000069")]
		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
		}

		[Token(Token = "0x600006A")]
		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
		}

		[Token(Token = "0x600006B")]
		private int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			return default(int);
		}

		[Token(Token = "0x600006C")]
		private void BuildCCallbackBase()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public sealed class CallResult<T>
	{
		[Token(Token = "0x200016B")]
		public delegate void APIDispatchDelegate(T param, bool bIOFailure);

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBaseVTable VTable;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr m_pVTable;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBase m_CCallbackBase;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GCHandle m_pCCallbackBase;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SteamAPICall_t m_hAPICall;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int m_size;

		[Token(Token = "0x17000002")]
		public SteamAPICall_t Handle
		{
			[Token(Token = "0x600006F")]
			get
			{
				return default(SteamAPICall_t);
			}
		}

		[Token(Token = "0x14000002")]
		private event APIDispatchDelegate m_Func
		{
			[Token(Token = "0x600006D")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EDAAC", Offset = "0x7EDAAC")]
			add
			{
			}
			[Token(Token = "0x600006E")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EDABC", Offset = "0x7EDABC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000070")]
		public static CallResult<T> Create([Optional] APIDispatchDelegate func)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		public CallResult([Optional] APIDispatchDelegate func)
		{
		}

		[Token(Token = "0x6000072")]
		~CallResult()
		{
		}

		[Token(Token = "0x6000073")]
		public void Set(SteamAPICall_t hAPICall, [Optional] APIDispatchDelegate func)
		{
		}

		[Token(Token = "0x6000074")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6000076")]
		public void SetGameserverFlag()
		{
		}

		[Token(Token = "0x6000077")]
		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
		}

		[Token(Token = "0x6000078")]
		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
		}

		[Token(Token = "0x6000079")]
		private int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			return default(int);
		}

		[Token(Token = "0x600007A")]
		private void BuildCCallbackBase()
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000018")]
	internal class CCallbackBase
	{
		[Token(Token = "0x4000070")]
		public const byte k_ECallbackFlagsRegistered = 1;

		[Token(Token = "0x4000071")]
		public const byte k_ECallbackFlagsGameServer = 2;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr m_vfptr;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte m_nCallbackFlags;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_iCallback;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x92B25C", Offset = "0x92B25C", VA = "0x92B25C")]
		public CCallbackBase()
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000019")]
	internal class CCallbackBaseVTable
	{
		[Token(Token = "0x200016C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED5FC", Offset = "0x7ED5FC")]
		public delegate void RunCBDel(IntPtr thisptr, IntPtr pvParam);

		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED610", Offset = "0x7ED610")]
		public delegate void RunCRDel(IntPtr thisptr, IntPtr pvParam, bool bIOFailure, ulong hSteamAPICall);

		[Token(Token = "0x200016E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED624", Offset = "0x7ED624")]
		public delegate int GetCallbackSizeBytesDel(IntPtr thisptr);

		[Token(Token = "0x4000075")]
		private const CallingConvention cc = CallingConvention.Cdecl;

		[NonSerialized]
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RunCBDel m_RunCallback;

		[NonSerialized]
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RunCRDel m_RunCallResult;

		[NonSerialized]
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GetCallbackSizeBytesDel m_GetCallbackSizeBytes;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x92B264", Offset = "0x92B264", VA = "0x92B264")]
		public CCallbackBaseVTable()
		{
		}
	}
	[Token(Token = "0x200001A")]
	internal class CallbackIdentities
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x92C5A4", Offset = "0x92C5A4", VA = "0x92C5A4")]
		public static int GetCallbackIdentity(Type callbackStruct)
		{
			return default(int);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x92C6E4", Offset = "0x92C6E4", VA = "0x92C6E4")]
		public CallbackIdentities()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x7EC770", Offset = "0x7EC770")]
	internal class CallbackIdentityAttribute : Attribute
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ED8C0", Offset = "0x7ED8C0")]
		private int <Identity>k__BackingField;

		[Token(Token = "0x17000003")]
		public int Identity
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x92C6EC", Offset = "0x92C6EC", VA = "0x92C6EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EDACC", Offset = "0x7EDACC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x92C6F4", Offset = "0x92C6F4", VA = "0x92C6F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EDADC", Offset = "0x7EDADC")]
			set
			{
			}
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x92C6FC", Offset = "0x92C6FC", VA = "0x92C6FC")]
		public CallbackIdentityAttribute(int callbackNum)
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ISteamMatchmakingServerListResponse
	{
		[Token(Token = "0x200016F")]
		public delegate void ServerResponded(HServerListRequest hRequest, int iServer);

		[Token(Token = "0x2000170")]
		public delegate void ServerFailedToRespond(HServerListRequest hRequest, int iServer);

		[Token(Token = "0x2000171")]
		public delegate void RefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response);

		[Token(Token = "0x2000172")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED638", Offset = "0x7ED638")]
		private delegate void InternalServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		[Token(Token = "0x2000173")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED64C", Offset = "0x7ED64C")]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		[Token(Token = "0x2000174")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED660", Offset = "0x7ED660")]
		private delegate void InternalRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response);

		[StructLayout(0)]
		[Token(Token = "0x2000175")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;

			[NonSerialized]
			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InternalRefreshComplete m_VTRefreshComplete;

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x9320AC", Offset = "0x9320AC", VA = "0x9320AC")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private VTable m_VTable;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ServerResponded m_ServerResponded;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ServerFailedToRespond m_ServerFailedToRespond;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RefreshComplete m_RefreshComplete;

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x931E94", Offset = "0x931E94", VA = "0x931E94")]
		public ISteamMatchmakingServerListResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond, RefreshComplete onRefreshComplete)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x9320E4", Offset = "0x9320E4", VA = "0x9320E4", Slot = "1")]
		~ISteamMatchmakingServerListResponse()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x9321DC", Offset = "0x9321DC", VA = "0x9321DC")]
		private void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x932480", Offset = "0x932480", VA = "0x932480")]
		private void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x932724", Offset = "0x932724", VA = "0x932724")]
		private void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x9329C8", Offset = "0x9329C8", VA = "0x9329C8")]
		public static explicit operator IntPtr(ISteamMatchmakingServerListResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200001D")]
	public class ISteamMatchmakingPingResponse
	{
		[Token(Token = "0x2000176")]
		public delegate void ServerResponded(gameserveritem_t server);

		[Token(Token = "0x2000177")]
		public delegate void ServerFailedToRespond();

		[Token(Token = "0x2000178")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED674", Offset = "0x7ED674")]
		private delegate void InternalServerResponded(IntPtr thisptr, gameserveritem_t server);

		[Token(Token = "0x2000179")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED688", Offset = "0x7ED688")]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr);

		[StructLayout(0)]
		[Token(Token = "0x200017A")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x92E294", Offset = "0x92E294", VA = "0x92E294")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private VTable m_VTable;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ServerResponded m_ServerResponded;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ServerFailedToRespond m_ServerFailedToRespond;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x92E0B4", Offset = "0x92E0B4", VA = "0x92E0B4")]
		public ISteamMatchmakingPingResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x92E2BC", Offset = "0x92E2BC", VA = "0x92E2BC", Slot = "1")]
		~ISteamMatchmakingPingResponse()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x92E3B4", Offset = "0x92E3B4", VA = "0x92E3B4")]
		private void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x92E764", Offset = "0x92E764", VA = "0x92E764")]
		private void InternalOnServerFailedToRespond(IntPtr thisptr)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x92E988", Offset = "0x92E988", VA = "0x92E988")]
		public static explicit operator IntPtr(ISteamMatchmakingPingResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200001E")]
	public class ISteamMatchmakingPlayersResponse
	{
		[Token(Token = "0x200017B")]
		public delegate void AddPlayerToList(string pchName, int nScore, float flTimePlayed);

		[Token(Token = "0x200017C")]
		public delegate void PlayersFailedToRespond();

		[Token(Token = "0x200017D")]
		public delegate void PlayersRefreshComplete();

		[Token(Token = "0x200017E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED69C", Offset = "0x7ED69C")]
		public delegate void InternalAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed);

		[Token(Token = "0x200017F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED6B0", Offset = "0x7ED6B0")]
		public delegate void InternalPlayersFailedToRespond(IntPtr thisptr);

		[Token(Token = "0x2000180")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED6C4", Offset = "0x7ED6C4")]
		public delegate void InternalPlayersRefreshComplete(IntPtr thisptr);

		[StructLayout(0)]
		[Token(Token = "0x2000181")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalAddPlayerToList m_VTAddPlayerToList;

			[NonSerialized]
			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InternalPlayersFailedToRespond m_VTPlayersFailedToRespond;

			[NonSerialized]
			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InternalPlayersRefreshComplete m_VTPlayersRefreshComplete;

			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x92F254", Offset = "0x92F254", VA = "0x92F254")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private VTable m_VTable;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AddPlayerToList m_AddPlayerToList;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PlayersFailedToRespond m_PlayersFailedToRespond;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlayersRefreshComplete m_PlayersRefreshComplete;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x92F03C", Offset = "0x92F03C", VA = "0x92F03C")]
		public ISteamMatchmakingPlayersResponse(AddPlayerToList onAddPlayerToList, PlayersFailedToRespond onPlayersFailedToRespond, PlayersRefreshComplete onPlayersRefreshComplete)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x92F28C", Offset = "0x92F28C", VA = "0x92F28C", Slot = "1")]
		~ISteamMatchmakingPlayersResponse()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x92F384", Offset = "0x92F384", VA = "0x92F384")]
		private void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x92F938", Offset = "0x92F938", VA = "0x92F938")]
		private void InternalOnPlayersFailedToRespond(IntPtr thisptr)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x92FB5C", Offset = "0x92FB5C", VA = "0x92FB5C")]
		private void InternalOnPlayersRefreshComplete(IntPtr thisptr)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x92FD80", Offset = "0x92FD80", VA = "0x92FD80")]
		public static explicit operator IntPtr(ISteamMatchmakingPlayersResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200001F")]
	public class ISteamMatchmakingRulesResponse
	{
		[Token(Token = "0x2000182")]
		public delegate void RulesResponded(string pchRule, string pchValue);

		[Token(Token = "0x2000183")]
		public delegate void RulesFailedToRespond();

		[Token(Token = "0x2000184")]
		public delegate void RulesRefreshComplete();

		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED6D8", Offset = "0x7ED6D8")]
		public delegate void InternalRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue);

		[Token(Token = "0x2000186")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED6EC", Offset = "0x7ED6EC")]
		public delegate void InternalRulesFailedToRespond(IntPtr thisptr);

		[Token(Token = "0x2000187")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED700", Offset = "0x7ED700")]
		public delegate void InternalRulesRefreshComplete(IntPtr thisptr);

		[StructLayout(0)]
		[Token(Token = "0x2000188")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalRulesResponded m_VTRulesResponded;

			[NonSerialized]
			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InternalRulesFailedToRespond m_VTRulesFailedToRespond;

			[NonSerialized]
			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InternalRulesRefreshComplete m_VTRulesRefreshComplete;

			[Token(Token = "0x600090E")]
			[Address(RVA = "0x930AAC", Offset = "0x930AAC", VA = "0x930AAC")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private VTable m_VTable;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RulesResponded m_RulesResponded;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RulesFailedToRespond m_RulesFailedToRespond;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RulesRefreshComplete m_RulesRefreshComplete;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x930894", Offset = "0x930894", VA = "0x930894")]
		public ISteamMatchmakingRulesResponse(RulesResponded onRulesResponded, RulesFailedToRespond onRulesFailedToRespond, RulesRefreshComplete onRulesRefreshComplete)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x930AE4", Offset = "0x930AE4", VA = "0x930AE4", Slot = "1")]
		~ISteamMatchmakingRulesResponse()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x930BDC", Offset = "0x930BDC", VA = "0x930BDC")]
		private void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x931014", Offset = "0x931014", VA = "0x931014")]
		private void InternalOnRulesFailedToRespond(IntPtr thisptr)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x931238", Offset = "0x931238", VA = "0x931238")]
		private void InternalOnRulesRefreshComplete(IntPtr thisptr)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x93145C", Offset = "0x93145C", VA = "0x93145C")]
		public static explicit operator IntPtr(ISteamMatchmakingRulesResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x2000020")]
	public class InteropHelp
	{
		[Token(Token = "0x2000189")]
		public class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid
		{
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x92CEA4", Offset = "0x92CEA4", VA = "0x92CEA4")]
			public UTF8StringHandle(string str)
			{
			}

			[Token(Token = "0x6000910")]
			[Address(RVA = "0x933E60", Offset = "0x933E60", VA = "0x933E60", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200018A")]
		public class SteamParamStringArray
		{
			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private IntPtr[] m_Strings;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private IntPtr m_ptrStrings;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private IntPtr m_pSteamParamStringArray;

			[Token(Token = "0x6000911")]
			[Address(RVA = "0x9337D8", Offset = "0x9337D8", VA = "0x9337D8")]
			public SteamParamStringArray(IList<string> strings)
			{
			}

			[Token(Token = "0x6000912")]
			[Address(RVA = "0x933C90", Offset = "0x933C90", VA = "0x933C90", Slot = "1")]
			~SteamParamStringArray()
			{
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x933E48", Offset = "0x933E48", VA = "0x933E48")]
			public static implicit operator IntPtr(SteamParamStringArray that)
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x92CE38", Offset = "0x92CE38", VA = "0x92CE38")]
		public static void TestIfPlatformSupported()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x933680", Offset = "0x933680", VA = "0x933680")]
		public static void TestIfAvailableClient()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x933728", Offset = "0x933728", VA = "0x933728")]
		public static void TestIfAvailableGameServer()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x92F3D0", Offset = "0x92F3D0", VA = "0x92F3D0")]
		public static string PtrToStringUTF8(IntPtr nativeUtf8)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x9337D0", Offset = "0x9337D0", VA = "0x9337D0")]
		public InteropHelp()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class MMKVPMarshaller
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr m_pNativeArray;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pArrayEntries;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x933EE8", Offset = "0x933EE8", VA = "0x933EE8")]
		public MMKVPMarshaller(MatchMakingKeyValuePair_t[] filters)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x934104", Offset = "0x934104", VA = "0x934104", Slot = "1")]
		~MMKVPMarshaller()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x934220", Offset = "0x934220", VA = "0x934220")]
		public static implicit operator IntPtr(MMKVPMarshaller that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x2000022")]
	public class DllCheck
	{
		[PreserveSig]
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x92CABC", Offset = "0x92CABC", VA = "0x92CABC")]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		[PreserveSig]
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x92CB54", Offset = "0x92CB54", VA = "0x92CB54")]
		private static extern int GetModuleFileName(IntPtr hModule, StringBuilder strFullPath, int nSize);

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x92CC14", Offset = "0x92CC14", VA = "0x92CC14")]
		public static bool Test()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x92CC1C", Offset = "0x92CC1C", VA = "0x92CC1C")]
		private static bool CheckSteamAPIDLL()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x92CC24", Offset = "0x92CC24", VA = "0x92CC24")]
		public DllCheck()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class Packsize
	{
		[Token(Token = "0x200018B")]
		private struct ValvePackingSentinel_t
		{
			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private uint m_u32;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private ulong m_u64;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ushort m_u16;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private double m_d;
		}

		[Token(Token = "0x4000093")]
		public const int value = 8;

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xD47CAC", Offset = "0xD47CAC", VA = "0xD47CAC")]
		public static bool Test()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000024")]
	public static class Version
	{
		[Token(Token = "0x4000094")]
		public const string SteamworksNETVersion = "7.0.0";

		[Token(Token = "0x4000095")]
		public const string SteamworksSDKVersion = "1.34";

		[Token(Token = "0x4000096")]
		public const string SteamAPIDLLVersion = "02.89.45.04";

		[Token(Token = "0x4000097")]
		public const int SteamAPIDLLSize = 186560;

		[Token(Token = "0x4000098")]
		public const int SteamAPI64DLLSize = 206760;
	}
	[Token(Token = "0x2000025")]
	public static class SteamAPI
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xD484A8", Offset = "0xD484A8", VA = "0xD484A8")]
		public static bool RestartAppIfNecessary(AppId_t unOwnAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xD484D4", Offset = "0xD484D4", VA = "0xD484D4")]
		public static bool InitSafe()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xD484F0", Offset = "0xD484F0", VA = "0xD484F0")]
		public static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xD4850C", Offset = "0xD4850C", VA = "0xD4850C")]
		public static void Shutdown()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xD48528", Offset = "0xD48528", VA = "0xD48528")]
		public static void RunCallbacks()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xD48544", Offset = "0xD48544", VA = "0xD48544")]
		public static bool IsSteamRunning()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xD48560", Offset = "0xD48560", VA = "0xD48560")]
		public static HSteamUser GetHSteamUserCurrent()
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xD4858C", Offset = "0xD4858C", VA = "0xD4858C")]
		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xD485B8", Offset = "0xD485B8", VA = "0xD485B8")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}
	}
	[Token(Token = "0x2000026")]
	public static class GameServer
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x92CE04", Offset = "0x92CE04", VA = "0x92CE04")]
		public static bool InitSafe(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x92D0CC", Offset = "0x92D0CC", VA = "0x92D0CC")]
		public static bool Init(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x92D100", Offset = "0x92D100", VA = "0x92D100")]
		public static void Shutdown()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x92D17C", Offset = "0x92D17C", VA = "0x92D17C")]
		public static void RunCallbacks()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x92D1F8", Offset = "0x92D1F8", VA = "0x92D1F8")]
		public static bool BSecure()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x92D280", Offset = "0x92D280", VA = "0x92D280")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x92D328", Offset = "0x92D328", VA = "0x92D328")]
		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x92D3B0", Offset = "0x92D3B0", VA = "0x92D3B0")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}
	}
	[Token(Token = "0x2000027")]
	public static class SteamEncryptedAppTicket
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xD4BC90", Offset = "0xD4BC90", VA = "0xD4BC90")]
		public static bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xD4BCF4", Offset = "0xD4BCF4", VA = "0xD4BCF4")]
		public static bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xD4BD38", Offset = "0xD4BD38", VA = "0xD4BD38")]
		public static uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(uint);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xD4BD6C", Offset = "0xD4BD6C", VA = "0xD4BD6C")]
		public static void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xD4BDB0", Offset = "0xD4BDB0", VA = "0xD4BDB0")]
		public static uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(uint);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xD4BDE4", Offset = "0xD4BDE4", VA = "0xD4BDE4")]
		public static bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xD4BE28", Offset = "0xD4BE28", VA = "0xD4BE28")]
		public static bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xD4BE5C", Offset = "0xD4BE5C", VA = "0xD4BE5C")]
		public static byte[] GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData)
		{
			return null;
		}
	}
	[Token(Token = "0x2000028")]
	internal static class NativeMethods
	{
		[Token(Token = "0x4000099")]
		internal const string NativeLibraryName = "CSteamworks";

		[PreserveSig]
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x934408", Offset = "0x934408", VA = "0x934408")]
		public static extern void SteamAPI_Shutdown();

		[PreserveSig]
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x934478", Offset = "0x934478", VA = "0x934478")]
		public static extern bool SteamAPI_IsSteamRunning();

		[PreserveSig]
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x9344F4", Offset = "0x9344F4", VA = "0x9344F4")]
		public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID);

		[PreserveSig]
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x93457C", Offset = "0x93457C", VA = "0x93457C")]
		public static extern void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID);

		[PreserveSig]
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x934614", Offset = "0x934614", VA = "0x934614")]
		public static extern void SteamAPI_SetMiniDumpComment(InteropHelp.UTF8StringHandle pchMsg);

		[PreserveSig]
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x9336B4", Offset = "0x9336B4", VA = "0x9336B4")]
		public static extern IntPtr SteamClient();

		[PreserveSig]
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x9346D4", Offset = "0x9346D4", VA = "0x9346D4")]
		public static extern bool SteamAPI_InitSafe();

		[PreserveSig]
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x934750", Offset = "0x934750", VA = "0x934750")]
		public static extern void SteamAPI_RunCallbacks();

		[PreserveSig]
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x9347C0", Offset = "0x9347C0", VA = "0x9347C0")]
		public static extern void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback);

		[PreserveSig]
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x934850", Offset = "0x934850", VA = "0x934850")]
		public static extern void SteamAPI_UnregisterCallback(IntPtr pCallback);

		[PreserveSig]
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x9348D0", Offset = "0x9348D0", VA = "0x9348D0")]
		public static extern void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall);

		[PreserveSig]
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x934960", Offset = "0x934960", VA = "0x934960")]
		public static extern void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall);

		[PreserveSig]
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x9349F0", Offset = "0x9349F0", VA = "0x9349F0")]
		public static extern void Steam_RunCallbacks(HSteamPipe hSteamPipe, bool bGameServerCallbacks);

		[PreserveSig]
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x934A80", Offset = "0x934A80", VA = "0x934A80")]
		public static extern void Steam_RegisterInterfaceFuncs(IntPtr hModule);

		[PreserveSig]
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x934B00", Offset = "0x934B00", VA = "0x934B00")]
		public static extern int Steam_GetHSteamUserCurrent();

		[PreserveSig]
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x934B74", Offset = "0x934B74", VA = "0x934B74")]
		public static extern int SteamAPI_GetSteamInstallPath();

		[PreserveSig]
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x934BE8", Offset = "0x934BE8", VA = "0x934BE8")]
		public static extern int SteamAPI_GetHSteamPipe();

		[PreserveSig]
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x934C5C", Offset = "0x934C5C", VA = "0x934C5C")]
		public static extern void SteamAPI_SetTryCatchCallbacks(bool bTryCatchCallbacks);

		[PreserveSig]
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x934CDC", Offset = "0x934CDC", VA = "0x934CDC")]
		public static extern int SteamAPI_GetHSteamUser();

		[PreserveSig]
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x934D50", Offset = "0x934D50", VA = "0x934D50")]
		public static extern void SteamAPI_UseBreakpadCrashHandler(InteropHelp.UTF8StringHandle pchVersion, InteropHelp.UTF8StringHandle pchDate, InteropHelp.UTF8StringHandle pchTime, bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback);

		[PreserveSig]
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x934ED4", Offset = "0x934ED4", VA = "0x934ED4")]
		public static extern IntPtr SteamUser();

		[PreserveSig]
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x934F48", Offset = "0x934F48", VA = "0x934F48")]
		public static extern IntPtr SteamFriends();

		[PreserveSig]
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x934FBC", Offset = "0x934FBC", VA = "0x934FBC")]
		public static extern IntPtr SteamUtils();

		[PreserveSig]
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x935030", Offset = "0x935030", VA = "0x935030")]
		public static extern IntPtr SteamMatchmaking();

		[PreserveSig]
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x9350A4", Offset = "0x9350A4", VA = "0x9350A4")]
		public static extern IntPtr SteamUserStats();

		[PreserveSig]
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x935118", Offset = "0x935118", VA = "0x935118")]
		public static extern IntPtr SteamApps();

		[PreserveSig]
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x93518C", Offset = "0x93518C", VA = "0x93518C")]
		public static extern IntPtr SteamNetworking();

		[PreserveSig]
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x935200", Offset = "0x935200", VA = "0x935200")]
		public static extern IntPtr SteamMatchmakingServers();

		[PreserveSig]
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x935274", Offset = "0x935274", VA = "0x935274")]
		public static extern IntPtr SteamRemoteStorage();

		[PreserveSig]
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x9352E8", Offset = "0x9352E8", VA = "0x9352E8")]
		public static extern IntPtr SteamScreenshots();

		[PreserveSig]
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x93535C", Offset = "0x93535C", VA = "0x93535C")]
		public static extern IntPtr SteamHTTP();

		[PreserveSig]
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x9353D0", Offset = "0x9353D0", VA = "0x9353D0")]
		public static extern IntPtr SteamUnifiedMessages();

		[PreserveSig]
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x935444", Offset = "0x935444", VA = "0x935444")]
		public static extern IntPtr SteamController();

		[PreserveSig]
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x9354B8", Offset = "0x9354B8", VA = "0x9354B8")]
		public static extern IntPtr SteamUGC();

		[PreserveSig]
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x93552C", Offset = "0x93552C", VA = "0x93552C")]
		public static extern IntPtr SteamAppList();

		[PreserveSig]
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x9355A0", Offset = "0x9355A0", VA = "0x9355A0")]
		public static extern IntPtr SteamMusic();

		[PreserveSig]
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x935614", Offset = "0x935614", VA = "0x935614")]
		public static extern IntPtr SteamMusicRemote();

		[PreserveSig]
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x935688", Offset = "0x935688", VA = "0x935688")]
		public static extern IntPtr SteamHTMLSurface();

		[PreserveSig]
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x9356FC", Offset = "0x9356FC", VA = "0x9356FC")]
		public static extern IntPtr SteamInventory();

		[PreserveSig]
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x935770", Offset = "0x935770", VA = "0x935770")]
		public static extern IntPtr SteamVideo();

		[PreserveSig]
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x92CFC0", Offset = "0x92CFC0", VA = "0x92CFC0")]
		public static extern bool SteamGameServer_InitSafe(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString);

		[PreserveSig]
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x92D10C", Offset = "0x92D10C", VA = "0x92D10C")]
		public static extern void SteamGameServer_Shutdown();

		[PreserveSig]
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x92D188", Offset = "0x92D188", VA = "0x92D188")]
		public static extern void SteamGameServer_RunCallbacks();

		[PreserveSig]
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x92D204", Offset = "0x92D204", VA = "0x92D204")]
		public static extern bool SteamGameServer_BSecure();

		[PreserveSig]
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x92D2B4", Offset = "0x92D2B4", VA = "0x92D2B4")]
		public static extern ulong SteamGameServer_GetSteamID();

		[PreserveSig]
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x92D334", Offset = "0x92D334", VA = "0x92D334")]
		public static extern int SteamGameServer_GetHSteamPipe();

		[PreserveSig]
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x92D3BC", Offset = "0x92D3BC", VA = "0x92D3BC")]
		public static extern int SteamGameServer_GetHSteamUser();

		[PreserveSig]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x93375C", Offset = "0x93375C", VA = "0x93375C")]
		public static extern IntPtr SteamClientGameServer();

		[PreserveSig]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x9357E4", Offset = "0x9357E4", VA = "0x9357E4")]
		public static extern IntPtr SteamGameServer();

		[PreserveSig]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x935858", Offset = "0x935858", VA = "0x935858")]
		public static extern IntPtr SteamGameServerUtils();

		[PreserveSig]
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x9358CC", Offset = "0x9358CC", VA = "0x9358CC")]
		public static extern IntPtr SteamGameServerNetworking();

		[PreserveSig]
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x935940", Offset = "0x935940", VA = "0x935940")]
		public static extern IntPtr SteamGameServerStats();

		[PreserveSig]
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x9359B4", Offset = "0x9359B4", VA = "0x9359B4")]
		public static extern IntPtr SteamGameServerHTTP();

		[PreserveSig]
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x935A28", Offset = "0x935A28", VA = "0x935A28")]
		public static extern IntPtr SteamGameServerInventory();

		[PreserveSig]
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x935A9C", Offset = "0x935A9C", VA = "0x935A9C")]
		public static extern IntPtr SteamGameServerUGC();

		[PreserveSig]
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x935B10", Offset = "0x935B10", VA = "0x935B10")]
		public static extern bool BDecryptTicket([In][Out] byte[] rgubTicketEncrypted, uint cubTicketEncrypted, [In][Out] byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey);

		[PreserveSig]
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x935BF0", Offset = "0x935BF0", VA = "0x935BF0")]
		public static extern bool BIsTicketForApp([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x935C98", Offset = "0x935C98", VA = "0x935C98")]
		public static extern uint GetTicketIssueTime([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x935D30", Offset = "0x935D30", VA = "0x935D30")]
		public static extern void GetTicketSteamID([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID);

		[PreserveSig]
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x935DD0", Offset = "0x935DD0", VA = "0x935DD0")]
		public static extern uint GetTicketAppID([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x935E68", Offset = "0x935E68", VA = "0x935E68")]
		public static extern bool BUserOwnsAppInTicket([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x935F10", Offset = "0x935F10", VA = "0x935F10")]
		public static extern bool BUserIsVacBanned([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x935FB0", Offset = "0x935FB0", VA = "0x935FB0")]
		public static extern IntPtr GetUserVariableData([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData);

		[PreserveSig]
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x936050", Offset = "0x936050", VA = "0x936050")]
		public static extern uint ISteamAppList_GetNumInstalledApps();

		[PreserveSig]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x9360C4", Offset = "0x9360C4", VA = "0x9360C4")]
		public static extern uint ISteamAppList_GetInstalledApps([In][Out] AppId_t[] pvecAppID, uint unMaxAppIDs);

		[PreserveSig]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x93615C", Offset = "0x93615C", VA = "0x93615C")]
		public static extern int ISteamAppList_GetAppName(AppId_t nAppID, IntPtr pchName, int cchNameMax);

		[PreserveSig]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x9361F4", Offset = "0x9361F4", VA = "0x9361F4")]
		public static extern int ISteamAppList_GetAppInstallDir(AppId_t nAppID, IntPtr pchDirectory, int cchNameMax);

		[PreserveSig]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x93628C", Offset = "0x93628C", VA = "0x93628C")]
		public static extern int ISteamAppList_GetAppBuildId(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x93630C", Offset = "0x93630C", VA = "0x93630C")]
		public static extern bool ISteamApps_BIsSubscribed();

		[PreserveSig]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x936388", Offset = "0x936388", VA = "0x936388")]
		public static extern bool ISteamApps_BIsLowViolence();

		[PreserveSig]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x936404", Offset = "0x936404", VA = "0x936404")]
		public static extern bool ISteamApps_BIsCybercafe();

		[PreserveSig]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x936480", Offset = "0x936480", VA = "0x936480")]
		public static extern bool ISteamApps_BIsVACBanned();

		[PreserveSig]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x9364FC", Offset = "0x9364FC", VA = "0x9364FC")]
		public static extern IntPtr ISteamApps_GetCurrentGameLanguage();

		[PreserveSig]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x936570", Offset = "0x936570", VA = "0x936570")]
		public static extern IntPtr ISteamApps_GetAvailableGameLanguages();

		[PreserveSig]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x9365E4", Offset = "0x9365E4", VA = "0x9365E4")]
		public static extern bool ISteamApps_BIsSubscribedApp(AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x93666C", Offset = "0x93666C", VA = "0x93666C")]
		public static extern bool ISteamApps_BIsDlcInstalled(AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x9366F4", Offset = "0x9366F4", VA = "0x9366F4")]
		public static extern uint ISteamApps_GetEarliestPurchaseUnixTime(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x936774", Offset = "0x936774", VA = "0x936774")]
		public static extern bool ISteamApps_BIsSubscribedFromFreeWeekend();

		[PreserveSig]
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x9367F0", Offset = "0x9367F0", VA = "0x9367F0")]
		public static extern int ISteamApps_GetDLCCount();

		[PreserveSig]
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x936864", Offset = "0x936864", VA = "0x936864")]
		public static extern bool ISteamApps_BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x936930", Offset = "0x936930", VA = "0x936930")]
		public static extern void ISteamApps_InstallDLC(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x9369B0", Offset = "0x9369B0", VA = "0x9369B0")]
		public static extern void ISteamApps_UninstallDLC(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x936A30", Offset = "0x936A30", VA = "0x936A30")]
		public static extern void ISteamApps_RequestAppProofOfPurchaseKey(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x936AB0", Offset = "0x936AB0", VA = "0x936AB0")]
		public static extern bool ISteamApps_GetCurrentBetaName(IntPtr pchName, int cchNameBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x936B48", Offset = "0x936B48", VA = "0x936B48")]
		public static extern bool ISteamApps_MarkContentCorrupt(bool bMissingFilesOnly);

		[PreserveSig]
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x936BD0", Offset = "0x936BD0", VA = "0x936BD0")]
		public static extern uint ISteamApps_GetInstalledDepots(AppId_t appID, [In][Out] DepotId_t[] pvecDepots, uint cMaxDepots);

		[PreserveSig]
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x936C70", Offset = "0x936C70", VA = "0x936C70")]
		public static extern uint ISteamApps_GetAppInstallDir(AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x936D08", Offset = "0x936D08", VA = "0x936D08")]
		public static extern bool ISteamApps_BIsAppInstalled(AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x936D90", Offset = "0x936D90", VA = "0x936D90")]
		public static extern ulong ISteamApps_GetAppOwner();

		[PreserveSig]
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x936E04", Offset = "0x936E04", VA = "0x936E04")]
		public static extern IntPtr ISteamApps_GetLaunchQueryParam(InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x936ECC", Offset = "0x936ECC", VA = "0x936ECC")]
		public static extern bool ISteamApps_GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x936F6C", Offset = "0x936F6C", VA = "0x936F6C")]
		public static extern int ISteamApps_GetAppBuildId();

		[PreserveSig]
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x936FE0", Offset = "0x936FE0", VA = "0x936FE0")]
		public static extern int ISteamClient_CreateSteamPipe();

		[PreserveSig]
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x937054", Offset = "0x937054", VA = "0x937054")]
		public static extern bool ISteamClient_BReleaseSteamPipe(HSteamPipe hSteamPipe);

		[PreserveSig]
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x9370DC", Offset = "0x9370DC", VA = "0x9370DC")]
		public static extern int ISteamClient_ConnectToGlobalUser(HSteamPipe hSteamPipe);

		[PreserveSig]
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x93715C", Offset = "0x93715C", VA = "0x93715C")]
		public static extern int ISteamClient_CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType);

		[PreserveSig]
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x9371EC", Offset = "0x9371EC", VA = "0x9371EC")]
		public static extern void ISteamClient_ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser);

		[PreserveSig]
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x93727C", Offset = "0x93727C", VA = "0x93727C")]
		public static extern IntPtr ISteamClient_GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x93735C", Offset = "0x93735C", VA = "0x93735C")]
		public static extern IntPtr ISteamClient_GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x93743C", Offset = "0x93743C", VA = "0x93743C")]
		public static extern void ISteamClient_SetLocalIPBinding(uint unIP, ushort usPort);

		[PreserveSig]
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x9374CC", Offset = "0x9374CC", VA = "0x9374CC")]
		public static extern IntPtr ISteamClient_GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x9375AC", Offset = "0x9375AC", VA = "0x9375AC")]
		public static extern IntPtr ISteamClient_GetISteamUtils(HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x937684", Offset = "0x937684", VA = "0x937684")]
		public static extern IntPtr ISteamClient_GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x937764", Offset = "0x937764", VA = "0x937764")]
		public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x937844", Offset = "0x937844", VA = "0x937844")]
		public static extern IntPtr ISteamClient_GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x937924", Offset = "0x937924", VA = "0x937924")]
		public static extern IntPtr ISteamClient_GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x937A04", Offset = "0x937A04", VA = "0x937A04")]
		public static extern IntPtr ISteamClient_GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x937AE4", Offset = "0x937AE4", VA = "0x937AE4")]
		public static extern IntPtr ISteamClient_GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x937BC4", Offset = "0x937BC4", VA = "0x937BC4")]
		public static extern IntPtr ISteamClient_GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x937CA4", Offset = "0x937CA4", VA = "0x937CA4")]
		public static extern IntPtr ISteamClient_GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x937D84", Offset = "0x937D84", VA = "0x937D84")]
		public static extern IntPtr ISteamClient_GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x937E64", Offset = "0x937E64", VA = "0x937E64")]
		public static extern void ISteamClient_RunFrame();

		[PreserveSig]
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x937ED4", Offset = "0x937ED4", VA = "0x937ED4")]
		public static extern uint ISteamClient_GetIPCCallCount();

		[PreserveSig]
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x937F48", Offset = "0x937F48", VA = "0x937F48")]
		public static extern void ISteamClient_SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x937FCC", Offset = "0x937FCC", VA = "0x937FCC")]
		public static extern bool ISteamClient_BShutdownIfAllPipesClosed();

		[PreserveSig]
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x938048", Offset = "0x938048", VA = "0x938048")]
		public static extern IntPtr ISteamClient_GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x938128", Offset = "0x938128", VA = "0x938128")]
		public static extern IntPtr ISteamClient_GetISteamUnifiedMessages(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x938208", Offset = "0x938208", VA = "0x938208")]
		public static extern IntPtr ISteamClient_GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x9382E8", Offset = "0x9382E8", VA = "0x9382E8")]
		public static extern IntPtr ISteamClient_GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x9383C8", Offset = "0x9383C8", VA = "0x9383C8")]
		public static extern IntPtr ISteamClient_GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x9384A8", Offset = "0x9384A8", VA = "0x9384A8")]
		public static extern IntPtr ISteamClient_GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x938588", Offset = "0x938588", VA = "0x938588")]
		public static extern IntPtr ISteamClient_GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x938668", Offset = "0x938668", VA = "0x938668")]
		public static extern IntPtr ISteamClient_GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x938748", Offset = "0x938748", VA = "0x938748")]
		public static extern void ISteamClient_Set_SteamAPI_CPostAPIResultInProcess(SteamAPI_PostAPIResultInProcess_t func);

		[PreserveSig]
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x9387CC", Offset = "0x9387CC", VA = "0x9387CC")]
		public static extern void ISteamClient_Remove_SteamAPI_CPostAPIResultInProcess(SteamAPI_PostAPIResultInProcess_t func);

		[PreserveSig]
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x938850", Offset = "0x938850", VA = "0x938850")]
		public static extern void ISteamClient_Set_SteamAPI_CCheckCallbackRegisteredInProcess(SteamAPI_CheckCallbackRegistered_t func);

		[PreserveSig]
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x9388D4", Offset = "0x9388D4", VA = "0x9388D4")]
		public static extern IntPtr ISteamClient_GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x9389B4", Offset = "0x9389B4", VA = "0x9389B4")]
		public static extern IntPtr ISteamClient_GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x938A94", Offset = "0x938A94", VA = "0x938A94")]
		public static extern bool ISteamController_Init(InteropHelp.UTF8StringHandle pchAbsolutePathToControllerConfigVDF);

		[PreserveSig]
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x938B60", Offset = "0x938B60", VA = "0x938B60")]
		public static extern bool ISteamController_Shutdown();

		[PreserveSig]
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x938BDC", Offset = "0x938BDC", VA = "0x938BDC")]
		public static extern void ISteamController_RunFrame();

		[PreserveSig]
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x938C4C", Offset = "0x938C4C", VA = "0x938C4C")]
		public static extern bool ISteamController_GetControllerState(uint unControllerIndex, out SteamControllerState_t pState);

		[PreserveSig]
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x938CE4", Offset = "0x938CE4", VA = "0x938CE4")]
		public static extern void ISteamController_TriggerHapticPulse(uint unControllerIndex, ESteamControllerPad eTargetPad, ushort usDurationMicroSec);

		[PreserveSig]
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x938D7C", Offset = "0x938D7C", VA = "0x938D7C")]
		public static extern void ISteamController_SetOverrideMode(InteropHelp.UTF8StringHandle pchMode);

		[PreserveSig]
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x938E3C", Offset = "0x938E3C", VA = "0x938E3C")]
		public static extern IntPtr ISteamFriends_GetPersonaName();

		[PreserveSig]
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x938EB0", Offset = "0x938EB0", VA = "0x938EB0")]
		public static extern ulong ISteamFriends_SetPersonaName(InteropHelp.UTF8StringHandle pchPersonaName);

		[PreserveSig]
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x938F78", Offset = "0x938F78", VA = "0x938F78")]
		public static extern EPersonaState ISteamFriends_GetPersonaState();

		[PreserveSig]
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x938FEC", Offset = "0x938FEC", VA = "0x938FEC")]
		public static extern int ISteamFriends_GetFriendCount(EFriendFlags iFriendFlags);

		[PreserveSig]
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x93906C", Offset = "0x93906C", VA = "0x93906C")]
		public static extern ulong ISteamFriends_GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags);

		[PreserveSig]
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x9390FC", Offset = "0x9390FC", VA = "0x9390FC")]
		public static extern EFriendRelationship ISteamFriends_GetFriendRelationship(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x93917C", Offset = "0x93917C", VA = "0x93917C")]
		public static extern EPersonaState ISteamFriends_GetFriendPersonaState(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x9391FC", Offset = "0x9391FC", VA = "0x9391FC")]
		public static extern IntPtr ISteamFriends_GetFriendPersonaName(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x93927C", Offset = "0x93927C", VA = "0x93927C")]
		public static extern bool ISteamFriends_GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo);

		[PreserveSig]
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x939314", Offset = "0x939314", VA = "0x939314")]
		public static extern IntPtr ISteamFriends_GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName);

		[PreserveSig]
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x9393A4", Offset = "0x9393A4", VA = "0x9393A4")]
		public static extern int ISteamFriends_GetFriendSteamLevel(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x939424", Offset = "0x939424", VA = "0x939424")]
		public static extern IntPtr ISteamFriends_GetPlayerNickname(CSteamID steamIDPlayer);

		[PreserveSig]
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x9394A4", Offset = "0x9394A4", VA = "0x9394A4")]
		public static extern int ISteamFriends_GetFriendsGroupCount();

		[PreserveSig]
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x939518", Offset = "0x939518", VA = "0x939518")]
		public static extern short ISteamFriends_GetFriendsGroupIDByIndex(int iFG);

		[PreserveSig]
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x939598", Offset = "0x939598", VA = "0x939598")]
		public static extern IntPtr ISteamFriends_GetFriendsGroupName(FriendsGroupID_t friendsGroupID);

		[PreserveSig]
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x939618", Offset = "0x939618", VA = "0x939618")]
		public static extern int ISteamFriends_GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID);

		[PreserveSig]
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x939698", Offset = "0x939698", VA = "0x939698")]
		public static extern void ISteamFriends_GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, [In][Out] CSteamID[] pOutSteamIDMembers, int nMembersCount);

		[PreserveSig]
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x939738", Offset = "0x939738", VA = "0x939738")]
		public static extern bool ISteamFriends_HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags);

		[PreserveSig]
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x9397D0", Offset = "0x9397D0", VA = "0x9397D0")]
		public static extern int ISteamFriends_GetClanCount();

		[PreserveSig]
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x939844", Offset = "0x939844", VA = "0x939844")]
		public static extern ulong ISteamFriends_GetClanByIndex(int iClan);

		[PreserveSig]
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x9398C4", Offset = "0x9398C4", VA = "0x9398C4")]
		public static extern IntPtr ISteamFriends_GetClanName(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x939944", Offset = "0x939944", VA = "0x939944")]
		public static extern IntPtr ISteamFriends_GetClanTag(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x9399C4", Offset = "0x9399C4", VA = "0x9399C4")]
		public static extern bool ISteamFriends_GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting);

		[PreserveSig]
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x939A74", Offset = "0x939A74", VA = "0x939A74")]
		public static extern ulong ISteamFriends_DownloadClanActivityCounts([In][Out] CSteamID[] psteamIDClans, int cClansToRequest);

		[PreserveSig]
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x939B0C", Offset = "0x939B0C", VA = "0x939B0C")]
		public static extern int ISteamFriends_GetFriendCountFromSource(CSteamID steamIDSource);

		[PreserveSig]
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x939B8C", Offset = "0x939B8C", VA = "0x939B8C")]
		public static extern ulong ISteamFriends_GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend);

		[PreserveSig]
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x939C1C", Offset = "0x939C1C", VA = "0x939C1C")]
		public static extern bool ISteamFriends_IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource);

		[PreserveSig]
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x939CB4", Offset = "0x939CB4", VA = "0x939CB4")]
		public static extern void ISteamFriends_SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking);

		[PreserveSig]
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x939D44", Offset = "0x939D44", VA = "0x939D44")]
		public static extern void ISteamFriends_ActivateGameOverlay(InteropHelp.UTF8StringHandle pchDialog);

		[PreserveSig]
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x939E04", Offset = "0x939E04", VA = "0x939E04")]
		public static extern void ISteamFriends_ActivateGameOverlayToUser(InteropHelp.UTF8StringHandle pchDialog, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x939ED4", Offset = "0x939ED4", VA = "0x939ED4")]
		public static extern void ISteamFriends_ActivateGameOverlayToWebPage(InteropHelp.UTF8StringHandle pchURL);

		[PreserveSig]
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x939F94", Offset = "0x939F94", VA = "0x939F94")]
		public static extern void ISteamFriends_ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag);

		[PreserveSig]
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x93A024", Offset = "0x93A024", VA = "0x93A024")]
		public static extern void ISteamFriends_SetPlayedWith(CSteamID steamIDUserPlayedWith);

		[PreserveSig]
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x93A0A4", Offset = "0x93A0A4", VA = "0x93A0A4")]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x93A124", Offset = "0x93A124", VA = "0x93A124")]
		public static extern int ISteamFriends_GetSmallFriendAvatar(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x93A1A4", Offset = "0x93A1A4", VA = "0x93A1A4")]
		public static extern int ISteamFriends_GetMediumFriendAvatar(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x93A224", Offset = "0x93A224", VA = "0x93A224")]
		public static extern int ISteamFriends_GetLargeFriendAvatar(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x93A2A4", Offset = "0x93A2A4", VA = "0x93A2A4")]
		public static extern bool ISteamFriends_RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly);

		[PreserveSig]
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x93A33C", Offset = "0x93A33C", VA = "0x93A33C")]
		public static extern ulong ISteamFriends_RequestClanOfficerList(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x93A3BC", Offset = "0x93A3BC", VA = "0x93A3BC")]
		public static extern ulong ISteamFriends_GetClanOwner(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x93A43C", Offset = "0x93A43C", VA = "0x93A43C")]
		public static extern int ISteamFriends_GetClanOfficerCount(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x93A4BC", Offset = "0x93A4BC", VA = "0x93A4BC")]
		public static extern ulong ISteamFriends_GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer);

		[PreserveSig]
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x93A54C", Offset = "0x93A54C", VA = "0x93A54C")]
		public static extern uint ISteamFriends_GetUserRestrictions();

		[PreserveSig]
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x93A5C0", Offset = "0x93A5C0", VA = "0x93A5C0")]
		public static extern bool ISteamFriends_SetRichPresence(InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x93A6D8", Offset = "0x93A6D8", VA = "0x93A6D8")]
		public static extern void ISteamFriends_ClearRichPresence();

		[PreserveSig]
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x93A748", Offset = "0x93A748", VA = "0x93A748")]
		public static extern IntPtr ISteamFriends_GetFriendRichPresence(CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x93A820", Offset = "0x93A820", VA = "0x93A820")]
		public static extern int ISteamFriends_GetFriendRichPresenceKeyCount(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x93A8A0", Offset = "0x93A8A0", VA = "0x93A8A0")]
		public static extern IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey);

		[PreserveSig]
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x93A930", Offset = "0x93A930", VA = "0x93A930")]
		public static extern void ISteamFriends_RequestFriendRichPresence(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x93A9B0", Offset = "0x93A9B0", VA = "0x93A9B0")]
		public static extern bool ISteamFriends_InviteUserToGame(CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchConnectString);

		[PreserveSig]
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x93AA8C", Offset = "0x93AA8C", VA = "0x93AA8C")]
		public static extern int ISteamFriends_GetCoplayFriendCount();

		[PreserveSig]
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x93AB00", Offset = "0x93AB00", VA = "0x93AB00")]
		public static extern ulong ISteamFriends_GetCoplayFriend(int iCoplayFriend);

		[PreserveSig]
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x93AB80", Offset = "0x93AB80", VA = "0x93AB80")]
		public static extern int ISteamFriends_GetFriendCoplayTime(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x93AC00", Offset = "0x93AC00", VA = "0x93AC00")]
		public static extern uint ISteamFriends_GetFriendCoplayGame(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x93AC80", Offset = "0x93AC80", VA = "0x93AC80")]
		public static extern ulong ISteamFriends_JoinClanChatRoom(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x93AD00", Offset = "0x93AD00", VA = "0x93AD00")]
		public static extern bool ISteamFriends_LeaveClanChatRoom(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x93AD88", Offset = "0x93AD88", VA = "0x93AD88")]
		public static extern int ISteamFriends_GetClanChatMemberCount(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x93AE08", Offset = "0x93AE08", VA = "0x93AE08")]
		public static extern ulong ISteamFriends_GetChatMemberByIndex(CSteamID steamIDClan, int iUser);

		[PreserveSig]
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x93AE98", Offset = "0x93AE98", VA = "0x93AE98")]
		public static extern bool ISteamFriends_SendClanChatMessage(CSteamID steamIDClanChat, InteropHelp.UTF8StringHandle pchText);

		[PreserveSig]
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x93AF74", Offset = "0x93AF74", VA = "0x93AF74")]
		public static extern int ISteamFriends_GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter);

		[PreserveSig]
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x93B034", Offset = "0x93B034", VA = "0x93B034")]
		public static extern bool ISteamFriends_IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x93B0CC", Offset = "0x93B0CC", VA = "0x93B0CC")]
		public static extern bool ISteamFriends_IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat);

		[PreserveSig]
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x93B154", Offset = "0x93B154", VA = "0x93B154")]
		public static extern bool ISteamFriends_OpenClanChatWindowInSteam(CSteamID steamIDClanChat);

		[PreserveSig]
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x93B1DC", Offset = "0x93B1DC", VA = "0x93B1DC")]
		public static extern bool ISteamFriends_CloseClanChatWindowInSteam(CSteamID steamIDClanChat);

		[PreserveSig]
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x93B264", Offset = "0x93B264", VA = "0x93B264")]
		public static extern bool ISteamFriends_SetListenForFriendsMessages(bool bInterceptEnabled);

		[PreserveSig]
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x93B2EC", Offset = "0x93B2EC", VA = "0x93B2EC")]
		public static extern bool ISteamFriends_ReplyToFriendMessage(CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchMsgToSend);

		[PreserveSig]
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x93B3C8", Offset = "0x93B3C8", VA = "0x93B3C8")]
		public static extern int ISteamFriends_GetFriendMessage(CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType);

		[PreserveSig]
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x93B478", Offset = "0x93B478", VA = "0x93B478")]
		public static extern ulong ISteamFriends_GetFollowerCount(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x93B4F8", Offset = "0x93B4F8", VA = "0x93B4F8")]
		public static extern ulong ISteamFriends_IsFollowing(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x93B578", Offset = "0x93B578", VA = "0x93B578")]
		public static extern ulong ISteamFriends_EnumerateFollowingList(uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x93B5F8", Offset = "0x93B5F8", VA = "0x93B5F8")]
		public static extern bool ISteamGameServer_InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, InteropHelp.UTF8StringHandle pchVersionString);

		[PreserveSig]
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x93B704", Offset = "0x93B704", VA = "0x93B704")]
		public static extern void ISteamGameServer_SetProduct(InteropHelp.UTF8StringHandle pszProduct);

		[PreserveSig]
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x93B7C4", Offset = "0x93B7C4", VA = "0x93B7C4")]
		public static extern void ISteamGameServer_SetGameDescription(InteropHelp.UTF8StringHandle pszGameDescription);

		[PreserveSig]
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x93B884", Offset = "0x93B884", VA = "0x93B884")]
		public static extern void ISteamGameServer_SetModDir(InteropHelp.UTF8StringHandle pszModDir);

		[PreserveSig]
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x93B944", Offset = "0x93B944", VA = "0x93B944")]
		public static extern void ISteamGameServer_SetDedicatedServer(bool bDedicated);

		[PreserveSig]
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x93B9C4", Offset = "0x93B9C4", VA = "0x93B9C4")]
		public static extern void ISteamGameServer_LogOn(InteropHelp.UTF8StringHandle pszToken);

		[PreserveSig]
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x93BA84", Offset = "0x93BA84", VA = "0x93BA84")]
		public static extern void ISteamGameServer_LogOnAnonymous();

		[PreserveSig]
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x93BAF4", Offset = "0x93BAF4", VA = "0x93BAF4")]
		public static extern void ISteamGameServer_LogOff();

		[PreserveSig]
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x93BB64", Offset = "0x93BB64", VA = "0x93BB64")]
		public static extern bool ISteamGameServer_BLoggedOn();

		[PreserveSig]
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x93BBE0", Offset = "0x93BBE0", VA = "0x93BBE0")]
		public static extern bool ISteamGameServer_BSecure();

		[PreserveSig]
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x93BC5C", Offset = "0x93BC5C", VA = "0x93BC5C")]
		public static extern ulong ISteamGameServer_GetSteamID();

		[PreserveSig]
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x93BCD0", Offset = "0x93BCD0", VA = "0x93BCD0")]
		public static extern bool ISteamGameServer_WasRestartRequested();

		[PreserveSig]
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x93BD4C", Offset = "0x93BD4C", VA = "0x93BD4C")]
		public static extern void ISteamGameServer_SetMaxPlayerCount(int cPlayersMax);

		[PreserveSig]
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x93BDCC", Offset = "0x93BDCC", VA = "0x93BDCC")]
		public static extern void ISteamGameServer_SetBotPlayerCount(int cBotplayers);

		[PreserveSig]
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x93BE4C", Offset = "0x93BE4C", VA = "0x93BE4C")]
		public static extern void ISteamGameServer_SetServerName(InteropHelp.UTF8StringHandle pszServerName);

		[PreserveSig]
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x93BF0C", Offset = "0x93BF0C", VA = "0x93BF0C")]
		public static extern void ISteamGameServer_SetMapName(InteropHelp.UTF8StringHandle pszMapName);

		[PreserveSig]
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x93BFCC", Offset = "0x93BFCC", VA = "0x93BFCC")]
		public static extern void ISteamGameServer_SetPasswordProtected(bool bPasswordProtected);

		[PreserveSig]
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x93C04C", Offset = "0x93C04C", VA = "0x93C04C")]
		public static extern void ISteamGameServer_SetSpectatorPort(ushort unSpectatorPort);

		[PreserveSig]
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x93C0CC", Offset = "0x93C0CC", VA = "0x93C0CC")]
		public static extern void ISteamGameServer_SetSpectatorServerName(InteropHelp.UTF8StringHandle pszSpectatorServerName);

		[PreserveSig]
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x93C18C", Offset = "0x93C18C", VA = "0x93C18C")]
		public static extern void ISteamGameServer_ClearAllKeyValues();

		[PreserveSig]
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x93C1FC", Offset = "0x93C1FC", VA = "0x93C1FC")]
		public static extern void ISteamGameServer_SetKeyValue(InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[PreserveSig]
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x93C308", Offset = "0x93C308", VA = "0x93C308")]
		public static extern void ISteamGameServer_SetGameTags(InteropHelp.UTF8StringHandle pchGameTags);

		[PreserveSig]
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x93C3C8", Offset = "0x93C3C8", VA = "0x93C3C8")]
		public static extern void ISteamGameServer_SetGameData(InteropHelp.UTF8StringHandle pchGameData);

		[PreserveSig]
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x93C488", Offset = "0x93C488", VA = "0x93C488")]
		public static extern void ISteamGameServer_SetRegion(InteropHelp.UTF8StringHandle pszRegion);

		[PreserveSig]
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x93C548", Offset = "0x93C548", VA = "0x93C548")]
		public static extern bool ISteamGameServer_SendUserConnectAndAuthenticate(uint unIPClient, [In][Out] byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser);

		[PreserveSig]
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x93C600", Offset = "0x93C600", VA = "0x93C600")]
		public static extern ulong ISteamGameServer_CreateUnauthenticatedUserConnection();

		[PreserveSig]
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x93C674", Offset = "0x93C674", VA = "0x93C674")]
		public static extern void ISteamGameServer_SendUserDisconnect(CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x93C6F4", Offset = "0x93C6F4", VA = "0x93C6F4")]
		public static extern bool ISteamGameServer_BUpdateUserData(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchPlayerName, uint uScore);

		[PreserveSig]
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x93C7D8", Offset = "0x93C7D8", VA = "0x93C7D8")]
		public static extern uint ISteamGameServer_GetAuthSessionTicket([In][Out] byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x93C878", Offset = "0x93C878", VA = "0x93C878")]
		public static extern EBeginAuthSessionResult ISteamGameServer_BeginAuthSession([In][Out] byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x93C918", Offset = "0x93C918", VA = "0x93C918")]
		public static extern void ISteamGameServer_EndAuthSession(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x93C998", Offset = "0x93C998", VA = "0x93C998")]
		public static extern void ISteamGameServer_CancelAuthTicket(HAuthTicket hAuthTicket);

		[PreserveSig]
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x93CA18", Offset = "0x93CA18", VA = "0x93CA18")]
		public static extern EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(CSteamID steamID, AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x93CAA8", Offset = "0x93CAA8", VA = "0x93CAA8")]
		public static extern bool ISteamGameServer_RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup);

		[PreserveSig]
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x93CB40", Offset = "0x93CB40", VA = "0x93CB40")]
		public static extern void ISteamGameServer_GetGameplayStats();

		[PreserveSig]
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x93CBB0", Offset = "0x93CBB0", VA = "0x93CBB0")]
		public static extern ulong ISteamGameServer_GetServerReputation();

		[PreserveSig]
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x93CC24", Offset = "0x93CC24", VA = "0x93CC24")]
		public static extern uint ISteamGameServer_GetPublicIP();

		[PreserveSig]
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x93CC98", Offset = "0x93CC98", VA = "0x93CC98")]
		public static extern bool ISteamGameServer_HandleIncomingPacket([In][Out] byte[] pData, int cbData, uint srcIP, ushort srcPort);

		[PreserveSig]
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x93CD50", Offset = "0x93CD50", VA = "0x93CD50")]
		public static extern int ISteamGameServer_GetNextOutgoingPacket([In][Out] byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort);

		[PreserveSig]
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x93CE00", Offset = "0x93CE00", VA = "0x93CE00")]
		public static extern void ISteamGameServer_EnableHeartbeats(bool bActive);

		[PreserveSig]
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x93CE80", Offset = "0x93CE80", VA = "0x93CE80")]
		public static extern void ISteamGameServer_SetHeartbeatInterval(int iHeartbeatInterval);

		[PreserveSig]
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x93CF00", Offset = "0x93CF00", VA = "0x93CF00")]
		public static extern void ISteamGameServer_ForceHeartbeat();

		[PreserveSig]
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x93CF70", Offset = "0x93CF70", VA = "0x93CF70")]
		public static extern ulong ISteamGameServer_AssociateWithClan(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x93CFF0", Offset = "0x93CFF0", VA = "0x93CFF0")]
		public static extern ulong ISteamGameServer_ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer);

		[PreserveSig]
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x93D070", Offset = "0x93D070", VA = "0x93D070")]
		public static extern ulong ISteamGameServerStats_RequestUserStats(CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x93D0F0", Offset = "0x93D0F0", VA = "0x93D0F0")]
		public static extern bool ISteamGameServerStats_GetUserStat(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x93D1D4", Offset = "0x93D1D4", VA = "0x93D1D4")]
		public static extern bool ISteamGameServerStats_GetUserStat_(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x93D2B8", Offset = "0x93D2B8", VA = "0x93D2B8")]
		public static extern bool ISteamGameServerStats_GetUserAchievement(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x93D3B0", Offset = "0x93D3B0", VA = "0x93D3B0")]
		public static extern bool ISteamGameServerStats_SetUserStat(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, int nData);

		[PreserveSig]
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x93D494", Offset = "0x93D494", VA = "0x93D494")]
		public static extern bool ISteamGameServerStats_SetUserStat_(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float fData);

		[PreserveSig]
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x93D580", Offset = "0x93D580", VA = "0x93D580")]
		public static extern bool ISteamGameServerStats_UpdateUserAvgRateStat(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		[PreserveSig]
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x93D674", Offset = "0x93D674", VA = "0x93D674")]
		public static extern bool ISteamGameServerStats_SetUserAchievement(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x93D750", Offset = "0x93D750", VA = "0x93D750")]
		public static extern bool ISteamGameServerStats_ClearUserAchievement(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x93D82C", Offset = "0x93D82C", VA = "0x93D82C")]
		public static extern ulong ISteamGameServerStats_StoreUserStats(CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x93D8AC", Offset = "0x93D8AC", VA = "0x93D8AC")]
		public static extern bool ISteamHTMLSurface_Init();

		[PreserveSig]
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x93D928", Offset = "0x93D928", VA = "0x93D928")]
		public static extern bool ISteamHTMLSurface_Shutdown();

		[PreserveSig]
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x93D9A4", Offset = "0x93D9A4", VA = "0x93D9A4")]
		public static extern ulong ISteamHTMLSurface_CreateBrowser(InteropHelp.UTF8StringHandle pchUserAgent, InteropHelp.UTF8StringHandle pchUserCSS);

		[PreserveSig]
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x93DAB8", Offset = "0x93DAB8", VA = "0x93DAB8")]
		public static extern void ISteamHTMLSurface_RemoveBrowser(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x93DB38", Offset = "0x93DB38", VA = "0x93DB38")]
		public static extern void ISteamHTMLSurface_LoadURL(HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchURL, InteropHelp.UTF8StringHandle pchPostData);

		[PreserveSig]
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x93DC54", Offset = "0x93DC54", VA = "0x93DC54")]
		public static extern void ISteamHTMLSurface_SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight);

		[PreserveSig]
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x93DCEC", Offset = "0x93DCEC", VA = "0x93DCEC")]
		public static extern void ISteamHTMLSurface_StopLoad(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x93DD6C", Offset = "0x93DD6C", VA = "0x93DD6C")]
		public static extern void ISteamHTMLSurface_Reload(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x93DDEC", Offset = "0x93DDEC", VA = "0x93DDEC")]
		public static extern void ISteamHTMLSurface_GoBack(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x93DE6C", Offset = "0x93DE6C", VA = "0x93DE6C")]
		public static extern void ISteamHTMLSurface_GoForward(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x93DEEC", Offset = "0x93DEEC", VA = "0x93DEEC")]
		public static extern void ISteamHTMLSurface_AddHeader(HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x93E008", Offset = "0x93E008", VA = "0x93E008")]
		public static extern void ISteamHTMLSurface_ExecuteJavascript(HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchScript);

		[PreserveSig]
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x93E0D8", Offset = "0x93E0D8", VA = "0x93E0D8")]
		public static extern void ISteamHTMLSurface_MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x93E168", Offset = "0x93E168", VA = "0x93E168")]
		public static extern void ISteamHTMLSurface_MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x93E1F8", Offset = "0x93E1F8", VA = "0x93E1F8")]
		public static extern void ISteamHTMLSurface_MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x93E288", Offset = "0x93E288", VA = "0x93E288")]
		public static extern void ISteamHTMLSurface_MouseMove(HHTMLBrowser unBrowserHandle, int x, int y);

		[PreserveSig]
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x93E320", Offset = "0x93E320", VA = "0x93E320")]
		public static extern void ISteamHTMLSurface_MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta);

		[PreserveSig]
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x93E3B0", Offset = "0x93E3B0", VA = "0x93E3B0")]
		public static extern void ISteamHTMLSurface_KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x93E448", Offset = "0x93E448", VA = "0x93E448")]
		public static extern void ISteamHTMLSurface_KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x93E4E0", Offset = "0x93E4E0", VA = "0x93E4E0")]
		public static extern void ISteamHTMLSurface_KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x93E578", Offset = "0x93E578", VA = "0x93E578")]
		public static extern void ISteamHTMLSurface_SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[PreserveSig]
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x93E608", Offset = "0x93E608", VA = "0x93E608")]
		public static extern void ISteamHTMLSurface_SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[PreserveSig]
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x93E698", Offset = "0x93E698", VA = "0x93E698")]
		public static extern void ISteamHTMLSurface_SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus);

		[PreserveSig]
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x93E728", Offset = "0x93E728", VA = "0x93E728")]
		public static extern void ISteamHTMLSurface_ViewSource(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x93E7A8", Offset = "0x93E7A8", VA = "0x93E7A8")]
		public static extern void ISteamHTMLSurface_CopyToClipboard(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x93E828", Offset = "0x93E828", VA = "0x93E828")]
		public static extern void ISteamHTMLSurface_PasteFromClipboard(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x93E8A8", Offset = "0x93E8A8", VA = "0x93E8A8")]
		public static extern void ISteamHTMLSurface_Find(HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchSearchStr, bool bCurrentlyInFind, bool bReverse);

		[PreserveSig]
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x93E998", Offset = "0x93E998", VA = "0x93E998")]
		public static extern void ISteamHTMLSurface_StopFind(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x93EA18", Offset = "0x93EA18", VA = "0x93EA18")]
		public static extern void ISteamHTMLSurface_GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y);

		[PreserveSig]
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x93EAB0", Offset = "0x93EAB0", VA = "0x93EAB0")]
		public static extern void ISteamHTMLSurface_SetCookie(InteropHelp.UTF8StringHandle pchHostname, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue, InteropHelp.UTF8StringHandle pchPath, uint nExpires, bool bSecure, bool bHTTPOnly);

		[PreserveSig]
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x93EC80", Offset = "0x93EC80", VA = "0x93EC80")]
		public static extern void ISteamHTMLSurface_SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);

		[PreserveSig]
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x93ED28", Offset = "0x93ED28", VA = "0x93ED28")]
		public static extern void ISteamHTMLSurface_SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode);

		[PreserveSig]
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x93EDB8", Offset = "0x93EDB8", VA = "0x93EDB8")]
		public static extern void ISteamHTMLSurface_AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed);

		[PreserveSig]
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x93EE48", Offset = "0x93EE48", VA = "0x93EE48")]
		public static extern void ISteamHTMLSurface_JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult);

		[PreserveSig]
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x93EED8", Offset = "0x93EED8", VA = "0x93EED8")]
		public static extern void ISteamHTMLSurface_FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles);

		[PreserveSig]
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x93EF68", Offset = "0x93EF68", VA = "0x93EF68")]
		public static extern uint ISteamHTTP_CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL);

		[PreserveSig]
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x93F040", Offset = "0x93F040", VA = "0x93F040")]
		public static extern bool ISteamHTTP_SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue);

		[PreserveSig]
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x93F0D8", Offset = "0x93F0D8", VA = "0x93F0D8")]
		public static extern bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		[PreserveSig]
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x93F170", Offset = "0x93F170", VA = "0x93F170")]
		public static extern bool ISteamHTTP_SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue);

		[PreserveSig]
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x93F298", Offset = "0x93F298", VA = "0x93F298")]
		public static extern bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue);

		[PreserveSig]
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x93F3C0", Offset = "0x93F3C0", VA = "0x93F3C0")]
		public static extern bool ISteamHTTP_SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x93F458", Offset = "0x93F458", VA = "0x93F458")]
		public static extern bool ISteamHTTP_SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x93F4F0", Offset = "0x93F4F0", VA = "0x93F4F0")]
		public static extern bool ISteamHTTP_DeferHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x93F578", Offset = "0x93F578", VA = "0x93F578")]
		public static extern bool ISteamHTTP_PrioritizeHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x93F600", Offset = "0x93F600", VA = "0x93F600")]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize);

		[PreserveSig]
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x93F6E4", Offset = "0x93F6E4", VA = "0x93F6E4")]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, [In][Out] byte[] pHeaderValueBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x93F7E0", Offset = "0x93F7E0", VA = "0x93F7E0")]
		public static extern bool ISteamHTTP_GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize);

		[PreserveSig]
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x93F878", Offset = "0x93F878", VA = "0x93F878")]
		public static extern bool ISteamHTTP_GetHTTPResponseBodyData(HTTPRequestHandle hRequest, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x93F920", Offset = "0x93F920", VA = "0x93F920")]
		public static extern bool ISteamHTTP_GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x93F9D8", Offset = "0x93F9D8", VA = "0x93F9D8")]
		public static extern bool ISteamHTTP_ReleaseHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x93FA60", Offset = "0x93FA60", VA = "0x93FA60")]
		public static extern bool ISteamHTTP_GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut);

		[PreserveSig]
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x93FAF8", Offset = "0x93FAF8", VA = "0x93FAF8")]
		public static extern bool ISteamHTTP_SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, [In][Out] byte[] pubBody, uint unBodyLen);

		[PreserveSig]
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x93FBF4", Offset = "0x93FBF4", VA = "0x93FBF4")]
		public static extern uint ISteamHTTP_CreateCookieContainer(bool bAllowResponsesToModify);

		[PreserveSig]
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x93FC74", Offset = "0x93FC74", VA = "0x93FC74")]
		public static extern bool ISteamHTTP_ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x93FCFC", Offset = "0x93FCFC", VA = "0x93FCFC")]
		public static extern bool ISteamHTTP_SetCookie(HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie);

		[PreserveSig]
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x93FE70", Offset = "0x93FE70", VA = "0x93FE70")]
		public static extern bool ISteamHTTP_SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x93FF08", Offset = "0x93FF08", VA = "0x93FF08")]
		public static extern bool ISteamHTTP_SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo);

		[PreserveSig]
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x93FFE4", Offset = "0x93FFE4", VA = "0x93FFE4")]
		public static extern bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate);

		[PreserveSig]
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x94007C", Offset = "0x94007C", VA = "0x94007C")]
		public static extern bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds);

		[PreserveSig]
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x940114", Offset = "0x940114", VA = "0x940114")]
		public static extern bool ISteamHTTP_GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		[PreserveSig]
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x9401C0", Offset = "0x9401C0", VA = "0x9401C0")]
		public static extern EResult ISteamInventory_GetResultStatus(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x940240", Offset = "0x940240", VA = "0x940240")]
		public static extern bool ISteamInventory_GetResultItems(SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		[PreserveSig]
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x9402E8", Offset = "0x9402E8", VA = "0x9402E8")]
		public static extern uint ISteamInventory_GetResultTimestamp(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x940368", Offset = "0x940368", VA = "0x940368")]
		public static extern bool ISteamInventory_CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		[PreserveSig]
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x940400", Offset = "0x940400", VA = "0x940400")]
		public static extern void ISteamInventory_DestroyResult(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x940480", Offset = "0x940480", VA = "0x940480")]
		public static extern bool ISteamInventory_GetAllItems(out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x940508", Offset = "0x940508", VA = "0x940508")]
		public static extern bool ISteamInventory_GetItemsByID(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		[PreserveSig]
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x9405B0", Offset = "0x9405B0", VA = "0x9405B0")]
		public static extern bool ISteamInventory_SerializeResult(SteamInventoryResult_t resultHandle, [In][Out] byte[] pOutBuffer, out uint punOutBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x940658", Offset = "0x940658", VA = "0x940658")]
		public static extern bool ISteamInventory_DeserializeResult(out SteamInventoryResult_t pOutResultHandle, [In][Out] byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE);

		[PreserveSig]
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x940710", Offset = "0x940710", VA = "0x940710")]
		public static extern bool ISteamInventory_GenerateItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x9407D0", Offset = "0x9407D0", VA = "0x9407D0")]
		public static extern bool ISteamInventory_GrantPromoItems(out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x940858", Offset = "0x940858", VA = "0x940858")]
		public static extern bool ISteamInventory_AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		[PreserveSig]
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x9408F0", Offset = "0x9408F0", VA = "0x9408F0")]
		public static extern bool ISteamInventory_AddPromoItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x940998", Offset = "0x940998", VA = "0x940998")]
		public static extern bool ISteamInventory_ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		[PreserveSig]
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x940A38", Offset = "0x940A38", VA = "0x940A38")]
		public static extern bool ISteamInventory_ExchangeItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayGenerate, [In][Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In][Out] SteamItemInstanceID_t[] pArrayDestroy, [In][Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		[PreserveSig]
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x940B28", Offset = "0x940B28", VA = "0x940B28")]
		public static extern bool ISteamInventory_TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		[PreserveSig]
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x940BD8", Offset = "0x940BD8", VA = "0x940BD8")]
		public static extern void ISteamInventory_SendItemDropHeartbeat();

		[PreserveSig]
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x940C48", Offset = "0x940C48", VA = "0x940C48")]
		public static extern bool ISteamInventory_TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		[PreserveSig]
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x940CE0", Offset = "0x940CE0", VA = "0x940CE0")]
		public static extern bool ISteamInventory_TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In][Out] SteamItemInstanceID_t[] pArrayGive, [In][Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In][Out] SteamItemInstanceID_t[] pArrayGet, [In][Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		[PreserveSig]
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x940DE0", Offset = "0x940DE0", VA = "0x940DE0")]
		public static extern bool ISteamInventory_LoadItemDefinitions();

		[PreserveSig]
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x940E5C", Offset = "0x940E5C", VA = "0x940E5C")]
		public static extern bool ISteamInventory_GetItemDefinitionIDs([In][Out] SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize);

		[PreserveSig]
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x940EFC", Offset = "0x940EFC", VA = "0x940EFC")]
		public static extern bool ISteamInventory_GetItemDefinitionProperty(SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x940FF0", Offset = "0x940FF0", VA = "0x940FF0")]
		public static extern int ISteamMatchmaking_GetFavoriteGameCount();

		[PreserveSig]
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x941064", Offset = "0x941064", VA = "0x941064")]
		public static extern bool ISteamMatchmaking_GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer);

		[PreserveSig]
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x941134", Offset = "0x941134", VA = "0x941134")]
		public static extern int ISteamMatchmaking_AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer);

		[PreserveSig]
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x9411F4", Offset = "0x9411F4", VA = "0x9411F4")]
		public static extern bool ISteamMatchmaking_RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);

		[PreserveSig]
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x9412AC", Offset = "0x9412AC", VA = "0x9412AC")]
		public static extern ulong ISteamMatchmaking_RequestLobbyList();

		[PreserveSig]
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x941320", Offset = "0x941320", VA = "0x941320")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListStringFilter(InteropHelp.UTF8StringHandle pchKeyToMatch, InteropHelp.UTF8StringHandle pchValueToMatch, ELobbyComparison eComparisonType);

		[PreserveSig]
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x94143C", Offset = "0x94143C", VA = "0x94143C")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType);

		[PreserveSig]
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x941514", Offset = "0x941514", VA = "0x941514")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToBeCloseTo);

		[PreserveSig]
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x9415E4", Offset = "0x9415E4", VA = "0x9415E4")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable);

		[PreserveSig]
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x941664", Offset = "0x941664", VA = "0x941664")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter);

		[PreserveSig]
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x9416E4", Offset = "0x9416E4", VA = "0x9416E4")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(int cMaxResults);

		[PreserveSig]
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x941764", Offset = "0x941764", VA = "0x941764")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x9417E4", Offset = "0x9417E4", VA = "0x9417E4")]
		public static extern ulong ISteamMatchmaking_GetLobbyByIndex(int iLobby);

		[PreserveSig]
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x941864", Offset = "0x941864", VA = "0x941864")]
		public static extern ulong ISteamMatchmaking_CreateLobby(ELobbyType eLobbyType, int cMaxMembers);

		[PreserveSig]
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x9418F4", Offset = "0x9418F4", VA = "0x9418F4")]
		public static extern ulong ISteamMatchmaking_JoinLobby(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x941974", Offset = "0x941974", VA = "0x941974")]
		public static extern void ISteamMatchmaking_LeaveLobby(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x9419F4", Offset = "0x9419F4", VA = "0x9419F4")]
		public static extern bool ISteamMatchmaking_InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee);

		[PreserveSig]
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x941A8C", Offset = "0x941A8C", VA = "0x941A8C")]
		public static extern int ISteamMatchmaking_GetNumLobbyMembers(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x941B0C", Offset = "0x941B0C", VA = "0x941B0C")]
		public static extern ulong ISteamMatchmaking_GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember);

		[PreserveSig]
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x941B9C", Offset = "0x941B9C", VA = "0x941B9C")]
		public static extern IntPtr ISteamMatchmaking_GetLobbyData(CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x941C74", Offset = "0x941C74", VA = "0x941C74")]
		public static extern bool ISteamMatchmaking_SetLobbyData(CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x941D9C", Offset = "0x941D9C", VA = "0x941D9C")]
		public static extern int ISteamMatchmaking_GetLobbyDataCount(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x941E1C", Offset = "0x941E1C", VA = "0x941E1C")]
		public static extern bool ISteamMatchmaking_GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize);

		[PreserveSig]
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x941EE4", Offset = "0x941EE4", VA = "0x941EE4")]
		public static extern bool ISteamMatchmaking_DeleteLobbyData(CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x941FC0", Offset = "0x941FC0", VA = "0x941FC0")]
		public static extern IntPtr ISteamMatchmaking_GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x9420A0", Offset = "0x9420A0", VA = "0x9420A0")]
		public static extern void ISteamMatchmaking_SetLobbyMemberData(CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x9421BC", Offset = "0x9421BC", VA = "0x9421BC")]
		public static extern bool ISteamMatchmaking_SendLobbyChatMsg(CSteamID steamIDLobby, [In][Out] byte[] pvMsgBody, int cubMsgBody);

		[PreserveSig]
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x942264", Offset = "0x942264", VA = "0x942264")]
		public static extern int ISteamMatchmaking_GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, [In][Out] byte[] pvData, int cubData, out EChatEntryType peChatEntryType);

		[PreserveSig]
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x94232C", Offset = "0x94232C", VA = "0x94232C")]
		public static extern bool ISteamMatchmaking_RequestLobbyData(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x9423B4", Offset = "0x9423B4", VA = "0x9423B4")]
		public static extern void ISteamMatchmaking_SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer);

		[PreserveSig]
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x94245C", Offset = "0x94245C", VA = "0x94245C")]
		public static extern bool ISteamMatchmaking_GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer);

		[PreserveSig]
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x94250C", Offset = "0x94250C", VA = "0x94250C")]
		public static extern bool ISteamMatchmaking_SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers);

		[PreserveSig]
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x9425A4", Offset = "0x9425A4", VA = "0x9425A4")]
		public static extern int ISteamMatchmaking_GetLobbyMemberLimit(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x942624", Offset = "0x942624", VA = "0x942624")]
		public static extern bool ISteamMatchmaking_SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType);

		[PreserveSig]
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x9426BC", Offset = "0x9426BC", VA = "0x9426BC")]
		public static extern bool ISteamMatchmaking_SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable);

		[PreserveSig]
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x942754", Offset = "0x942754", VA = "0x942754")]
		public static extern ulong ISteamMatchmaking_GetLobbyOwner(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x9427D4", Offset = "0x9427D4", VA = "0x9427D4")]
		public static extern bool ISteamMatchmaking_SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner);

		[PreserveSig]
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x94286C", Offset = "0x94286C", VA = "0x94286C")]
		public static extern bool ISteamMatchmaking_SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent);

		[PreserveSig]
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x942904", Offset = "0x942904", VA = "0x942904")]
		public static extern IntPtr ISteamMatchmakingServers_RequestInternetServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x9429AC", Offset = "0x9429AC", VA = "0x9429AC")]
		public static extern IntPtr ISteamMatchmakingServers_RequestLANServerList(AppId_t iApp, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x942A3C", Offset = "0x942A3C", VA = "0x942A3C")]
		public static extern IntPtr ISteamMatchmakingServers_RequestFriendsServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x942AE4", Offset = "0x942AE4", VA = "0x942AE4")]
		public static extern IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x942B8C", Offset = "0x942B8C", VA = "0x942B8C")]
		public static extern IntPtr ISteamMatchmakingServers_RequestHistoryServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x942C34", Offset = "0x942C34", VA = "0x942C34")]
		public static extern IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x942CDC", Offset = "0x942CDC", VA = "0x942CDC")]
		public static extern void ISteamMatchmakingServers_ReleaseRequest(HServerListRequest hServerListRequest);

		[PreserveSig]
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x942D5C", Offset = "0x942D5C", VA = "0x942D5C")]
		public static extern IntPtr ISteamMatchmakingServers_GetServerDetails(HServerListRequest hRequest, int iServer);

		[PreserveSig]
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x942DEC", Offset = "0x942DEC", VA = "0x942DEC")]
		public static extern void ISteamMatchmakingServers_CancelQuery(HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x942E6C", Offset = "0x942E6C", VA = "0x942E6C")]
		public static extern void ISteamMatchmakingServers_RefreshQuery(HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x942EEC", Offset = "0x942EEC", VA = "0x942EEC")]
		public static extern bool ISteamMatchmakingServers_IsRefreshing(HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x942F74", Offset = "0x942F74", VA = "0x942F74")]
		public static extern int ISteamMatchmakingServers_GetServerCount(HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x942FF4", Offset = "0x942FF4", VA = "0x942FF4")]
		public static extern void ISteamMatchmakingServers_RefreshServer(HServerListRequest hRequest, int iServer);

		[PreserveSig]
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x943084", Offset = "0x943084", VA = "0x943084")]
		public static extern int ISteamMatchmakingServers_PingServer(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x94311C", Offset = "0x94311C", VA = "0x94311C")]
		public static extern int ISteamMatchmakingServers_PlayerDetails(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x9431B4", Offset = "0x9431B4", VA = "0x9431B4")]
		public static extern int ISteamMatchmakingServers_ServerRules(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x94324C", Offset = "0x94324C", VA = "0x94324C")]
		public static extern void ISteamMatchmakingServers_CancelServerQuery(HServerQuery hServerQuery);

		[PreserveSig]
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x9432CC", Offset = "0x9432CC", VA = "0x9432CC")]
		public static extern bool ISteamMusic_BIsEnabled();

		[PreserveSig]
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x943348", Offset = "0x943348", VA = "0x943348")]
		public static extern bool ISteamMusic_BIsPlaying();

		[PreserveSig]
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x9433C4", Offset = "0x9433C4", VA = "0x9433C4")]
		public static extern AudioPlayback_Status ISteamMusic_GetPlaybackStatus();

		[PreserveSig]
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x943438", Offset = "0x943438", VA = "0x943438")]
		public static extern void ISteamMusic_Play();

		[PreserveSig]
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x9434A8", Offset = "0x9434A8", VA = "0x9434A8")]
		public static extern void ISteamMusic_Pause();

		[PreserveSig]
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x943518", Offset = "0x943518", VA = "0x943518")]
		public static extern void ISteamMusic_PlayPrevious();

		[PreserveSig]
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x943588", Offset = "0x943588", VA = "0x943588")]
		public static extern void ISteamMusic_PlayNext();

		[PreserveSig]
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x9435F8", Offset = "0x9435F8", VA = "0x9435F8")]
		public static extern void ISteamMusic_SetVolume(float flVolume);

		[PreserveSig]
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x94367C", Offset = "0x94367C", VA = "0x94367C")]
		public static extern float ISteamMusic_GetVolume();

		[PreserveSig]
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x9436EC", Offset = "0x9436EC", VA = "0x9436EC")]
		public static extern bool ISteamMusicRemote_RegisterSteamMusicRemote(InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x9437B8", Offset = "0x9437B8", VA = "0x9437B8")]
		public static extern bool ISteamMusicRemote_DeregisterSteamMusicRemote();

		[PreserveSig]
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x943834", Offset = "0x943834", VA = "0x943834")]
		public static extern bool ISteamMusicRemote_BIsCurrentMusicRemote();

		[PreserveSig]
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x9438B0", Offset = "0x9438B0", VA = "0x9438B0")]
		public static extern bool ISteamMusicRemote_BActivationSuccess(bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x943938", Offset = "0x943938", VA = "0x943938")]
		public static extern bool ISteamMusicRemote_SetDisplayName(InteropHelp.UTF8StringHandle pchDisplayName);

		[PreserveSig]
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x943A04", Offset = "0x943A04", VA = "0x943A04")]
		public static extern bool ISteamMusicRemote_SetPNGIcon_64x64([In][Out] byte[] pvBuffer, uint cbBufferLength);

		[PreserveSig]
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x943AA4", Offset = "0x943AA4", VA = "0x943AA4")]
		public static extern bool ISteamMusicRemote_EnablePlayPrevious(bool bValue);

		[PreserveSig]
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x943B2C", Offset = "0x943B2C", VA = "0x943B2C")]
		public static extern bool ISteamMusicRemote_EnablePlayNext(bool bValue);

		[PreserveSig]
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x943BB4", Offset = "0x943BB4", VA = "0x943BB4")]
		public static extern bool ISteamMusicRemote_EnableShuffled(bool bValue);

		[PreserveSig]
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x943C3C", Offset = "0x943C3C", VA = "0x943C3C")]
		public static extern bool ISteamMusicRemote_EnableLooped(bool bValue);

		[PreserveSig]
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x943CC4", Offset = "0x943CC4", VA = "0x943CC4")]
		public static extern bool ISteamMusicRemote_EnableQueue(bool bValue);

		[PreserveSig]
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x943D4C", Offset = "0x943D4C", VA = "0x943D4C")]
		public static extern bool ISteamMusicRemote_EnablePlaylists(bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x943DD4", Offset = "0x943DD4", VA = "0x943DD4")]
		public static extern bool ISteamMusicRemote_UpdatePlaybackStatus(AudioPlayback_Status nStatus);

		[PreserveSig]
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x943E5C", Offset = "0x943E5C", VA = "0x943E5C")]
		public static extern bool ISteamMusicRemote_UpdateShuffled(bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x943EE4", Offset = "0x943EE4", VA = "0x943EE4")]
		public static extern bool ISteamMusicRemote_UpdateLooped(bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x943F6C", Offset = "0x943F6C", VA = "0x943F6C")]
		public static extern bool ISteamMusicRemote_UpdateVolume(float flValue);

		[PreserveSig]
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x943FFC", Offset = "0x943FFC", VA = "0x943FFC")]
		public static extern bool ISteamMusicRemote_CurrentEntryWillChange();

		[PreserveSig]
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x944078", Offset = "0x944078", VA = "0x944078")]
		public static extern bool ISteamMusicRemote_CurrentEntryIsAvailable(bool bAvailable);

		[PreserveSig]
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x944100", Offset = "0x944100", VA = "0x944100")]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryText(InteropHelp.UTF8StringHandle pchText);

		[PreserveSig]
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x9441CC", Offset = "0x9441CC", VA = "0x9441CC")]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(int nValue);

		[PreserveSig]
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x944254", Offset = "0x944254", VA = "0x944254")]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryCoverArt([In][Out] byte[] pvBuffer, uint cbBufferLength);

		[PreserveSig]
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x9442F4", Offset = "0x9442F4", VA = "0x9442F4")]
		public static extern bool ISteamMusicRemote_CurrentEntryDidChange();

		[PreserveSig]
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x944370", Offset = "0x944370", VA = "0x944370")]
		public static extern bool ISteamMusicRemote_QueueWillChange();

		[PreserveSig]
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x9443EC", Offset = "0x9443EC", VA = "0x9443EC")]
		public static extern bool ISteamMusicRemote_ResetQueueEntries();

		[PreserveSig]
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x944468", Offset = "0x944468", VA = "0x944468")]
		public static extern bool ISteamMusicRemote_SetQueueEntry(int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		[PreserveSig]
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x94454C", Offset = "0x94454C", VA = "0x94454C")]
		public static extern bool ISteamMusicRemote_SetCurrentQueueEntry(int nID);

		[PreserveSig]
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x9445D4", Offset = "0x9445D4", VA = "0x9445D4")]
		public static extern bool ISteamMusicRemote_QueueDidChange();

		[PreserveSig]
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x944650", Offset = "0x944650", VA = "0x944650")]
		public static extern bool ISteamMusicRemote_PlaylistWillChange();

		[PreserveSig]
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x9446CC", Offset = "0x9446CC", VA = "0x9446CC")]
		public static extern bool ISteamMusicRemote_ResetPlaylistEntries();

		[PreserveSig]
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x944748", Offset = "0x944748", VA = "0x944748")]
		public static extern bool ISteamMusicRemote_SetPlaylistEntry(int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		[PreserveSig]
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x94482C", Offset = "0x94482C", VA = "0x94482C")]
		public static extern bool ISteamMusicRemote_SetCurrentPlaylistEntry(int nID);

		[PreserveSig]
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x9448B4", Offset = "0x9448B4", VA = "0x9448B4")]
		public static extern bool ISteamMusicRemote_PlaylistDidChange();

		[PreserveSig]
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x944930", Offset = "0x944930", VA = "0x944930")]
		public static extern bool ISteamNetworking_SendP2PPacket(CSteamID steamIDRemote, [In][Out] byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		[PreserveSig]
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x9449F0", Offset = "0x9449F0", VA = "0x9449F0")]
		public static extern bool ISteamNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel);

		[PreserveSig]
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x944A88", Offset = "0x944A88", VA = "0x944A88")]
		public static extern bool ISteamNetworking_ReadP2PPacket([In][Out] byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x944B48", Offset = "0x944B48", VA = "0x944B48")]
		public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x944BD0", Offset = "0x944BD0", VA = "0x944BD0")]
		public static extern bool ISteamNetworking_CloseP2PSessionWithUser(CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x944C58", Offset = "0x944C58", VA = "0x944C58")]
		public static extern bool ISteamNetworking_CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x944CF0", Offset = "0x944CF0", VA = "0x944CF0")]
		public static extern bool ISteamNetworking_GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		[PreserveSig]
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x944D88", Offset = "0x944D88", VA = "0x944D88")]
		public static extern bool ISteamNetworking_AllowP2PPacketRelay(bool bAllow);

		[PreserveSig]
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x944E10", Offset = "0x944E10", VA = "0x944E10")]
		public static extern uint ISteamNetworking_CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x944EB8", Offset = "0x944EB8", VA = "0x944EB8")]
		public static extern uint ISteamNetworking_CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x944F60", Offset = "0x944F60", VA = "0x944F60")]
		public static extern uint ISteamNetworking_CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec);

		[PreserveSig]
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x944FF8", Offset = "0x944FF8", VA = "0x944FF8")]
		public static extern bool ISteamNetworking_DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x945090", Offset = "0x945090", VA = "0x945090")]
		public static extern bool ISteamNetworking_DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x945128", Offset = "0x945128", VA = "0x945128")]
		public static extern bool ISteamNetworking_SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, bool bReliable);

		[PreserveSig]
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x9451D8", Offset = "0x9451D8", VA = "0x9451D8")]
		public static extern bool ISteamNetworking_IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x945270", Offset = "0x945270", VA = "0x945270")]
		public static extern bool ISteamNetworking_RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x945320", Offset = "0x945320", VA = "0x945320")]
		public static extern bool ISteamNetworking_IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x9453C0", Offset = "0x9453C0", VA = "0x9453C0")]
		public static extern bool ISteamNetworking_RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x945478", Offset = "0x945478", VA = "0x945478")]
		public static extern bool ISteamNetworking_GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote);

		[PreserveSig]
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x945530", Offset = "0x945530", VA = "0x945530")]
		public static extern bool ISteamNetworking_GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort);

		[PreserveSig]
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x9455D0", Offset = "0x9455D0", VA = "0x9455D0")]
		public static extern ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x945650", Offset = "0x945650", VA = "0x945650")]
		public static extern int ISteamNetworking_GetMaxPacketSize(SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x9456D0", Offset = "0x9456D0", VA = "0x9456D0")]
		public static extern bool ISteamRemoteStorage_FileWrite(InteropHelp.UTF8StringHandle pchFile, [In][Out] byte[] pvData, int cubData);

		[PreserveSig]
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x9457BC", Offset = "0x9457BC", VA = "0x9457BC")]
		public static extern int ISteamRemoteStorage_FileRead(InteropHelp.UTF8StringHandle pchFile, [In][Out] byte[] pvData, int cubDataToRead);

		[PreserveSig]
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x9458A4", Offset = "0x9458A4", VA = "0x9458A4")]
		public static extern bool ISteamRemoteStorage_FileForget(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x945970", Offset = "0x945970", VA = "0x945970")]
		public static extern bool ISteamRemoteStorage_FileDelete(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x945A3C", Offset = "0x945A3C", VA = "0x945A3C")]
		public static extern ulong ISteamRemoteStorage_FileShare(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x945B04", Offset = "0x945B04", VA = "0x945B04")]
		public static extern bool ISteamRemoteStorage_SetSyncPlatforms(InteropHelp.UTF8StringHandle pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);

		[PreserveSig]
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x945BE0", Offset = "0x945BE0", VA = "0x945BE0")]
		public static extern ulong ISteamRemoteStorage_FileWriteStreamOpen(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x945CA8", Offset = "0x945CA8", VA = "0x945CA8")]
		public static extern bool ISteamRemoteStorage_FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, [In][Out] byte[] pvData, int cubData);

		[PreserveSig]
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x945D50", Offset = "0x945D50", VA = "0x945D50")]
		public static extern bool ISteamRemoteStorage_FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle);

		[PreserveSig]
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x945DD8", Offset = "0x945DD8", VA = "0x945DD8")]
		public static extern bool ISteamRemoteStorage_FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle);

		[PreserveSig]
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x945E60", Offset = "0x945E60", VA = "0x945E60")]
		public static extern bool ISteamRemoteStorage_FileExists(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x945F2C", Offset = "0x945F2C", VA = "0x945F2C")]
		public static extern bool ISteamRemoteStorage_FilePersisted(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x945FF8", Offset = "0x945FF8", VA = "0x945FF8")]
		public static extern int ISteamRemoteStorage_GetFileSize(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x9460C0", Offset = "0x9460C0", VA = "0x9460C0")]
		public static extern long ISteamRemoteStorage_GetFileTimestamp(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x946188", Offset = "0x946188", VA = "0x946188")]
		public static extern ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x946250", Offset = "0x946250", VA = "0x946250")]
		public static extern int ISteamRemoteStorage_GetFileCount();

		[PreserveSig]
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x9462C4", Offset = "0x9462C4", VA = "0x9462C4")]
		public static extern IntPtr ISteamRemoteStorage_GetFileNameAndSize(int iFile, out int pnFileSizeInBytes);

		[PreserveSig]
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x946354", Offset = "0x946354", VA = "0x946354")]
		public static extern bool ISteamRemoteStorage_GetQuota(out int pnTotalBytes, out int puAvailableBytes);

		[PreserveSig]
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x9463EC", Offset = "0x9463EC", VA = "0x9463EC")]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForAccount();

		[PreserveSig]
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x946468", Offset = "0x946468", VA = "0x946468")]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForApp();

		[PreserveSig]
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x9464E4", Offset = "0x9464E4", VA = "0x9464E4")]
		public static extern void ISteamRemoteStorage_SetCloudEnabledForApp(bool bEnabled);

		[PreserveSig]
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x946564", Offset = "0x946564", VA = "0x946564")]
		public static extern ulong ISteamRemoteStorage_UGCDownload(UGCHandle_t hContent, uint unPriority);

		[PreserveSig]
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x9465F4", Offset = "0x9465F4", VA = "0x9465F4")]
		public static extern bool ISteamRemoteStorage_GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected);

		[PreserveSig]
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x946694", Offset = "0x946694", VA = "0x946694")]
		public static extern bool ISteamRemoteStorage_GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner);

		[PreserveSig]
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x94674C", Offset = "0x94674C", VA = "0x94674C")]
		public static extern int ISteamRemoteStorage_UGCRead(UGCHandle_t hContent, [In][Out] byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction);

		[PreserveSig]
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x946804", Offset = "0x946804", VA = "0x946804")]
		public static extern int ISteamRemoteStorage_GetCachedUGCCount();

		[PreserveSig]
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x946878", Offset = "0x946878", VA = "0x946878")]
		public static extern ulong ISteamRemoteStorage_GetCachedUGCHandle(int iCachedContent);

		[PreserveSig]
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x9468F8", Offset = "0x9468F8", VA = "0x9468F8")]
		public static extern ulong ISteamRemoteStorage_PublishWorkshopFile(InteropHelp.UTF8StringHandle pchFile, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType);

		[PreserveSig]
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x946AD8", Offset = "0x946AD8", VA = "0x946AD8")]
		public static extern ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x946B58", Offset = "0x946B58", VA = "0x946B58")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x946C34", Offset = "0x946C34", VA = "0x946C34")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchPreviewFile);

		[PreserveSig]
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x946D10", Offset = "0x946D10", VA = "0x946D10")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchTitle);

		[PreserveSig]
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x946DEC", Offset = "0x946DEC", VA = "0x946DEC")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchDescription);

		[PreserveSig]
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x946EC8", Offset = "0x946EC8", VA = "0x946EC8")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility);

		[PreserveSig]
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x946F60", Offset = "0x946F60", VA = "0x946F60")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x946FF8", Offset = "0x946FF8", VA = "0x946FF8")]
		public static extern ulong ISteamRemoteStorage_CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle);

		[PreserveSig]
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x947078", Offset = "0x947078", VA = "0x947078")]
		public static extern ulong ISteamRemoteStorage_GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld);

		[PreserveSig]
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x947108", Offset = "0x947108", VA = "0x947108")]
		public static extern ulong ISteamRemoteStorage_DeletePublishedFile(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x947188", Offset = "0x947188", VA = "0x947188")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x947208", Offset = "0x947208", VA = "0x947208")]
		public static extern ulong ISteamRemoteStorage_SubscribePublishedFile(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x947288", Offset = "0x947288", VA = "0x947288")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x947308", Offset = "0x947308", VA = "0x947308")]
		public static extern ulong ISteamRemoteStorage_UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x947388", Offset = "0x947388", VA = "0x947388")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchChangeDescription);

		[PreserveSig]
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x947464", Offset = "0x947464", VA = "0x947464")]
		public static extern ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x9474E4", Offset = "0x9474E4", VA = "0x9474E4")]
		public static extern ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp);

		[PreserveSig]
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x947574", Offset = "0x947574", VA = "0x947574")]
		public static extern ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x9475F4", Offset = "0x9475F4", VA = "0x9475F4")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags);

		[PreserveSig]
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x94769C", Offset = "0x94769C", VA = "0x94769C")]
		public static extern ulong ISteamRemoteStorage_PublishVideo(EWorkshopVideoProvider eVideoProvider, InteropHelp.UTF8StringHandle pchVideoAccount, InteropHelp.UTF8StringHandle pchVideoIdentifier, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x9478CC", Offset = "0x9478CC", VA = "0x9478CC")]
		public static extern ulong ISteamRemoteStorage_SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction);

		[PreserveSig]
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x94795C", Offset = "0x94795C", VA = "0x94795C")]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x9479EC", Offset = "0x9479EC", VA = "0x9479EC")]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags);

		[PreserveSig]
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x947AAC", Offset = "0x947AAC", VA = "0x947AAC")]
		public static extern ulong ISteamRemoteStorage_UGCDownloadToLocation(UGCHandle_t hContent, InteropHelp.UTF8StringHandle pchLocation, uint unPriority);

		[PreserveSig]
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x947B8C", Offset = "0x947B8C", VA = "0x947B8C")]
		public static extern uint ISteamScreenshots_WriteScreenshot([In][Out] byte[] pubRGB, uint cubRGB, int nWidth, int nHeight);

		[PreserveSig]
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x947C3C", Offset = "0x947C3C", VA = "0x947C3C")]
		public static extern uint ISteamScreenshots_AddScreenshotToLibrary(InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchThumbnailFilename, int nWidth, int nHeight);

		[PreserveSig]
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x947D68", Offset = "0x947D68", VA = "0x947D68")]
		public static extern void ISteamScreenshots_TriggerScreenshot();

		[PreserveSig]
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x947DD8", Offset = "0x947DD8", VA = "0x947DD8")]
		public static extern void ISteamScreenshots_HookScreenshots(bool bHook);

		[PreserveSig]
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x947E58", Offset = "0x947E58", VA = "0x947E58")]
		public static extern bool ISteamScreenshots_SetLocation(ScreenshotHandle hScreenshot, InteropHelp.UTF8StringHandle pchLocation);

		[PreserveSig]
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x947F34", Offset = "0x947F34", VA = "0x947F34")]
		public static extern bool ISteamScreenshots_TagUser(ScreenshotHandle hScreenshot, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x947FCC", Offset = "0x947FCC", VA = "0x947FCC")]
		public static extern bool ISteamScreenshots_TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x948064", Offset = "0x948064", VA = "0x948064")]
		public static extern ulong ISteamUGC_CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x94812C", Offset = "0x94812C", VA = "0x94812C")]
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x9481DC", Offset = "0x9481DC", VA = "0x9481DC")]
		public static extern ulong ISteamUGC_CreateQueryUGCDetailsRequest([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x948274", Offset = "0x948274", VA = "0x948274")]
		public static extern ulong ISteamUGC_SendQueryUGCRequest(UGCQueryHandle_t handle);

		[PreserveSig]
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x9482F4", Offset = "0x9482F4", VA = "0x9482F4")]
		public static extern bool ISteamUGC_GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails);

		[PreserveSig]
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x9483EC", Offset = "0x9483EC", VA = "0x9483EC")]
		public static extern bool ISteamUGC_GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize);

		[PreserveSig]
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x94849C", Offset = "0x94849C", VA = "0x94849C")]
		public static extern bool ISteamUGC_GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize);

		[PreserveSig]
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x94854C", Offset = "0x94854C", VA = "0x94854C")]
		public static extern bool ISteamUGC_GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[PreserveSig]
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x948604", Offset = "0x948604", VA = "0x948604")]
		public static extern bool ISteamUGC_GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out uint pStatValue);

		[PreserveSig]
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x9486B4", Offset = "0x9486B4", VA = "0x9486B4")]
		public static extern uint ISteamUGC_GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index);

		[PreserveSig]
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x948744", Offset = "0x948744", VA = "0x948744")]
		public static extern bool ISteamUGC_GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, out bool pbIsImage);

		[PreserveSig]
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x948820", Offset = "0x948820", VA = "0x948820")]
		public static extern uint ISteamUGC_GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index);

		[PreserveSig]
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x9488B0", Offset = "0x9488B0", VA = "0x9488B0")]
		public static extern bool ISteamUGC_GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize);

		[PreserveSig]
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x948980", Offset = "0x948980", VA = "0x948980")]
		public static extern bool ISteamUGC_ReleaseQueryUGCRequest(UGCQueryHandle_t handle);

		[PreserveSig]
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x948A08", Offset = "0x948A08", VA = "0x948A08")]
		public static extern bool ISteamUGC_AddRequiredTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[PreserveSig]
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x948AE4", Offset = "0x948AE4", VA = "0x948AE4")]
		public static extern bool ISteamUGC_AddExcludedTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[PreserveSig]
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x948BC0", Offset = "0x948BC0", VA = "0x948BC0")]
		public static extern bool ISteamUGC_SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags);

		[PreserveSig]
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x948C58", Offset = "0x948C58", VA = "0x948C58")]
		public static extern bool ISteamUGC_SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription);

		[PreserveSig]
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x948CF0", Offset = "0x948CF0", VA = "0x948CF0")]
		public static extern bool ISteamUGC_SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata);

		[PreserveSig]
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x948D88", Offset = "0x948D88", VA = "0x948D88")]
		public static extern bool ISteamUGC_SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren);

		[PreserveSig]
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x948E20", Offset = "0x948E20", VA = "0x948E20")]
		public static extern bool ISteamUGC_SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews);

		[PreserveSig]
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x948EB8", Offset = "0x948EB8", VA = "0x948EB8")]
		public static extern bool ISteamUGC_SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly);

		[PreserveSig]
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x948F50", Offset = "0x948F50", VA = "0x948F50")]
		public static extern bool ISteamUGC_SetLanguage(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[PreserveSig]
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x94902C", Offset = "0x94902C", VA = "0x94902C")]
		public static extern bool ISteamUGC_SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		[PreserveSig]
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x9490C4", Offset = "0x9490C4", VA = "0x9490C4")]
		public static extern bool ISteamUGC_SetCloudFileNameFilter(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName);

		[PreserveSig]
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x9491A0", Offset = "0x9491A0", VA = "0x9491A0")]
		public static extern bool ISteamUGC_SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag);

		[PreserveSig]
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x949238", Offset = "0x949238", VA = "0x949238")]
		public static extern bool ISteamUGC_SetSearchText(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText);

		[PreserveSig]
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x949314", Offset = "0x949314", VA = "0x949314")]
		public static extern bool ISteamUGC_SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays);

		[PreserveSig]
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x9493AC", Offset = "0x9493AC", VA = "0x9493AC")]
		public static extern bool ISteamUGC_AddRequiredKeyValueTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[PreserveSig]
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x9494D4", Offset = "0x9494D4", VA = "0x9494D4")]
		public static extern ulong ISteamUGC_RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds);

		[PreserveSig]
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x949564", Offset = "0x949564", VA = "0x949564")]
		public static extern ulong ISteamUGC_CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType);

		[PreserveSig]
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x9495F4", Offset = "0x9495F4", VA = "0x9495F4")]
		public static extern ulong ISteamUGC_StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x949684", Offset = "0x949684", VA = "0x949684")]
		public static extern bool ISteamUGC_SetItemTitle(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle);

		[PreserveSig]
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x949760", Offset = "0x949760", VA = "0x949760")]
		public static extern bool ISteamUGC_SetItemDescription(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription);

		[PreserveSig]
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x94983C", Offset = "0x94983C", VA = "0x94983C")]
		public static extern bool ISteamUGC_SetItemUpdateLanguage(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[PreserveSig]
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x949918", Offset = "0x949918", VA = "0x949918")]
		public static extern bool ISteamUGC_SetItemMetadata(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData);

		[PreserveSig]
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x9499F4", Offset = "0x9499F4", VA = "0x9499F4")]
		public static extern bool ISteamUGC_SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

		[PreserveSig]
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x949A8C", Offset = "0x949A8C", VA = "0x949A8C")]
		public static extern bool ISteamUGC_SetItemTags(UGCUpdateHandle_t updateHandle, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x949B24", Offset = "0x949B24", VA = "0x949B24")]
		public static extern bool ISteamUGC_SetItemContent(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder);

		[PreserveSig]
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x949C00", Offset = "0x949C00", VA = "0x949C00")]
		public static extern bool ISteamUGC_SetItemPreview(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile);

		[PreserveSig]
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x949CDC", Offset = "0x949CDC", VA = "0x949CDC")]
		public static extern bool ISteamUGC_RemoveItemKeyValueTags(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x949DB8", Offset = "0x949DB8", VA = "0x949DB8")]
		public static extern bool ISteamUGC_AddItemKeyValueTag(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x949EE0", Offset = "0x949EE0", VA = "0x949EE0")]
		public static extern ulong ISteamUGC_SubmitItemUpdate(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote);

		[PreserveSig]
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x949FB8", Offset = "0x949FB8", VA = "0x949FB8")]
		public static extern EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x94A050", Offset = "0x94A050", VA = "0x94A050")]
		public static extern ulong ISteamUGC_SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp);

		[PreserveSig]
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x94A0E0", Offset = "0x94A0E0", VA = "0x94A0E0")]
		public static extern ulong ISteamUGC_GetUserItemVote(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x94A160", Offset = "0x94A160", VA = "0x94A160")]
		public static extern ulong ISteamUGC_AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x94A1F0", Offset = "0x94A1F0", VA = "0x94A1F0")]
		public static extern ulong ISteamUGC_RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x94A280", Offset = "0x94A280", VA = "0x94A280")]
		public static extern ulong ISteamUGC_SubscribeItem(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x94A300", Offset = "0x94A300", VA = "0x94A300")]
		public static extern ulong ISteamUGC_UnsubscribeItem(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x94A380", Offset = "0x94A380", VA = "0x94A380")]
		public static extern uint ISteamUGC_GetNumSubscribedItems();

		[PreserveSig]
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x94A3F4", Offset = "0x94A3F4", VA = "0x94A3F4")]
		public static extern uint ISteamUGC_GetSubscribedItems([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[PreserveSig]
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x94A48C", Offset = "0x94A48C", VA = "0x94A48C")]
		public static extern uint ISteamUGC_GetItemState(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x94A50C", Offset = "0x94A50C", VA = "0x94A50C")]
		public static extern bool ISteamUGC_GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp);

		[PreserveSig]
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x94A5C4", Offset = "0x94A5C4", VA = "0x94A5C4")]
		public static extern bool ISteamUGC_GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x94A664", Offset = "0x94A664", VA = "0x94A664")]
		public static extern bool ISteamUGC_DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority);

		[PreserveSig]
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x94A6FC", Offset = "0x94A6FC", VA = "0x94A6FC")]
		public static extern ulong ISteamUnifiedMessages_SendMethod(InteropHelp.UTF8StringHandle pchServiceMethod, [In][Out] byte[] pRequestBuffer, uint unRequestBufferSize, ulong unContext);

		[PreserveSig]
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x94A7F4", Offset = "0x94A7F4", VA = "0x94A7F4")]
		public static extern bool ISteamUnifiedMessages_GetMethodResponseInfo(ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult);

		[PreserveSig]
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x94A894", Offset = "0x94A894", VA = "0x94A894")]
		public static extern bool ISteamUnifiedMessages_GetMethodResponseData(ClientUnifiedMessageHandle hHandle, [In][Out] byte[] pResponseBuffer, uint unResponseBufferSize, bool bAutoRelease);

		[PreserveSig]
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x94A94C", Offset = "0x94A94C", VA = "0x94A94C")]
		public static extern bool ISteamUnifiedMessages_ReleaseMethod(ClientUnifiedMessageHandle hHandle);

		[PreserveSig]
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x94A9D4", Offset = "0x94A9D4", VA = "0x94A9D4")]
		public static extern bool ISteamUnifiedMessages_SendNotification(InteropHelp.UTF8StringHandle pchServiceNotification, [In][Out] byte[] pNotificationBuffer, uint unNotificationBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x94AAC0", Offset = "0x94AAC0", VA = "0x94AAC0")]
		public static extern int ISteamUser_GetHSteamUser();

		[PreserveSig]
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x94AB34", Offset = "0x94AB34", VA = "0x94AB34")]
		public static extern bool ISteamUser_BLoggedOn();

		[PreserveSig]
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x94ABB0", Offset = "0x94ABB0", VA = "0x94ABB0")]
		public static extern ulong ISteamUser_GetSteamID();

		[PreserveSig]
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x94AC24", Offset = "0x94AC24", VA = "0x94AC24")]
		public static extern int ISteamUser_InitiateGameConnection([In][Out] byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure);

		[PreserveSig]
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x94ACEC", Offset = "0x94ACEC", VA = "0x94ACEC")]
		public static extern void ISteamUser_TerminateGameConnection(uint unIPServer, ushort usPortServer);

		[PreserveSig]
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x94AD7C", Offset = "0x94AD7C", VA = "0x94AD7C")]
		public static extern void ISteamUser_TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, InteropHelp.UTF8StringHandle pchExtraInfo);

		[PreserveSig]
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x94AE54", Offset = "0x94AE54", VA = "0x94AE54")]
		public static extern bool ISteamUser_GetUserDataFolder(IntPtr pchBuffer, int cubBuffer);

		[PreserveSig]
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x94AEEC", Offset = "0x94AEEC", VA = "0x94AEEC")]
		public static extern void ISteamUser_StartVoiceRecording();

		[PreserveSig]
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x94AF5C", Offset = "0x94AF5C", VA = "0x94AF5C")]
		public static extern void ISteamUser_StopVoiceRecording();

		[PreserveSig]
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x94AFCC", Offset = "0x94AFCC", VA = "0x94AFCC")]
		public static extern EVoiceResult ISteamUser_GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed, uint nUncompressedVoiceDesiredSampleRate);

		[PreserveSig]
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x94B064", Offset = "0x94B064", VA = "0x94B064")]
		public static extern EVoiceResult ISteamUser_GetVoice(bool bWantCompressed, [In][Out] byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed, [In][Out] byte[] pUncompressedDestBuffer, uint cbUncompressedDestBufferSize, out uint nUncompressBytesWritten, uint nUncompressedVoiceDesiredSampleRate);

		[PreserveSig]
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x94B154", Offset = "0x94B154", VA = "0x94B154")]
		public static extern EVoiceResult ISteamUser_DecompressVoice([In][Out] byte[] pCompressed, uint cbCompressed, [In][Out] byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate);

		[PreserveSig]
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x94B224", Offset = "0x94B224", VA = "0x94B224")]
		public static extern uint ISteamUser_GetVoiceOptimalSampleRate();

		[PreserveSig]
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x94B298", Offset = "0x94B298", VA = "0x94B298")]
		public static extern uint ISteamUser_GetAuthSessionTicket([In][Out] byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x94B338", Offset = "0x94B338", VA = "0x94B338")]
		public static extern EBeginAuthSessionResult ISteamUser_BeginAuthSession([In][Out] byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x94B3D8", Offset = "0x94B3D8", VA = "0x94B3D8")]
		public static extern void ISteamUser_EndAuthSession(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x94B458", Offset = "0x94B458", VA = "0x94B458")]
		public static extern void ISteamUser_CancelAuthTicket(HAuthTicket hAuthTicket);

		[PreserveSig]
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x94B4D8", Offset = "0x94B4D8", VA = "0x94B4D8")]
		public static extern EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(CSteamID steamID, AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x94B568", Offset = "0x94B568", VA = "0x94B568")]
		public static extern bool ISteamUser_BIsBehindNAT();

		[PreserveSig]
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x94B5E4", Offset = "0x94B5E4", VA = "0x94B5E4")]
		public static extern void ISteamUser_AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer);

		[PreserveSig]
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x94B67C", Offset = "0x94B67C", VA = "0x94B67C")]
		public static extern ulong ISteamUser_RequestEncryptedAppTicket([In][Out] byte[] pDataToInclude, int cbDataToInclude);

		[PreserveSig]
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x94B714", Offset = "0x94B714", VA = "0x94B714")]
		public static extern bool ISteamUser_GetEncryptedAppTicket([In][Out] byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x94B7BC", Offset = "0x94B7BC", VA = "0x94B7BC")]
		public static extern int ISteamUser_GetGameBadgeLevel(int nSeries, bool bFoil);

		[PreserveSig]
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x94B84C", Offset = "0x94B84C", VA = "0x94B84C")]
		public static extern int ISteamUser_GetPlayerSteamLevel();

		[PreserveSig]
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x94B8C0", Offset = "0x94B8C0", VA = "0x94B8C0")]
		public static extern ulong ISteamUser_RequestStoreAuthURL(InteropHelp.UTF8StringHandle pchRedirectURL);

		[PreserveSig]
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x94B988", Offset = "0x94B988", VA = "0x94B988")]
		public static extern bool ISteamUserStats_RequestCurrentStats();

		[PreserveSig]
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x94BA04", Offset = "0x94BA04", VA = "0x94BA04")]
		public static extern bool ISteamUserStats_GetStat(InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x94BAE0", Offset = "0x94BAE0", VA = "0x94BAE0")]
		public static extern bool ISteamUserStats_GetStat_(InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x94BBBC", Offset = "0x94BBBC", VA = "0x94BBBC")]
		public static extern bool ISteamUserStats_SetStat(InteropHelp.UTF8StringHandle pchName, int nData);

		[PreserveSig]
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x94BC98", Offset = "0x94BC98", VA = "0x94BC98")]
		public static extern bool ISteamUserStats_SetStat_(InteropHelp.UTF8StringHandle pchName, float fData);

		[PreserveSig]
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x94BD74", Offset = "0x94BD74", VA = "0x94BD74")]
		public static extern bool ISteamUserStats_UpdateAvgRateStat(InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		[PreserveSig]
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x94BE58", Offset = "0x94BE58", VA = "0x94BE58")]
		public static extern bool ISteamUserStats_GetAchievement(InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x94BF48", Offset = "0x94BF48", VA = "0x94BF48")]
		public static extern bool ISteamUserStats_SetAchievement(InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x94C014", Offset = "0x94C014", VA = "0x94C014")]
		public static extern bool ISteamUserStats_ClearAchievement(InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x94C0E0", Offset = "0x94C0E0", VA = "0x94C0E0")]
		public static extern bool ISteamUserStats_GetAchievementAndUnlockTime(InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		[PreserveSig]
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x94C1D8", Offset = "0x94C1D8", VA = "0x94C1D8")]
		public static extern bool ISteamUserStats_StoreStats();

		[PreserveSig]
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x94C254", Offset = "0x94C254", VA = "0x94C254")]
		public static extern int ISteamUserStats_GetAchievementIcon(InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x94C31C", Offset = "0x94C31C", VA = "0x94C31C")]
		public static extern IntPtr ISteamUserStats_GetAchievementDisplayAttribute(InteropHelp.UTF8StringHandle pchName, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x94C430", Offset = "0x94C430", VA = "0x94C430")]
		public static extern bool ISteamUserStats_IndicateAchievementProgress(InteropHelp.UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress);

		[PreserveSig]
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x94C514", Offset = "0x94C514", VA = "0x94C514")]
		public static extern uint ISteamUserStats_GetNumAchievements();

		[PreserveSig]
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x94C588", Offset = "0x94C588", VA = "0x94C588")]
		public static extern IntPtr ISteamUserStats_GetAchievementName(uint iAchievement);

		[PreserveSig]
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x94C608", Offset = "0x94C608", VA = "0x94C608")]
		public static extern ulong ISteamUserStats_RequestUserStats(CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x94C688", Offset = "0x94C688", VA = "0x94C688")]
		public static extern bool ISteamUserStats_GetUserStat(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x94C76C", Offset = "0x94C76C", VA = "0x94C76C")]
		public static extern bool ISteamUserStats_GetUserStat_(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x94C850", Offset = "0x94C850", VA = "0x94C850")]
		public static extern bool ISteamUserStats_GetUserAchievement(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x94C948", Offset = "0x94C948", VA = "0x94C948")]
		public static extern bool ISteamUserStats_GetUserAchievementAndUnlockTime(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		[PreserveSig]
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x94CA50", Offset = "0x94CA50", VA = "0x94CA50")]
		public static extern bool ISteamUserStats_ResetAllStats(bool bAchievementsToo);

		[PreserveSig]
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x94CAD8", Offset = "0x94CAD8", VA = "0x94CAD8")]
		public static extern ulong ISteamUserStats_FindOrCreateLeaderboard(InteropHelp.UTF8StringHandle pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType);

		[PreserveSig]
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x94CBB8", Offset = "0x94CBB8", VA = "0x94CBB8")]
		public static extern ulong ISteamUserStats_FindLeaderboard(InteropHelp.UTF8StringHandle pchLeaderboardName);

		[PreserveSig]
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x94CC80", Offset = "0x94CC80", VA = "0x94CC80")]
		public static extern IntPtr ISteamUserStats_GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x94CD00", Offset = "0x94CD00", VA = "0x94CD00")]
		public static extern int ISteamUserStats_GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x94CD80", Offset = "0x94CD80", VA = "0x94CD80")]
		public static extern ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x94CE00", Offset = "0x94CE00", VA = "0x94CE00")]
		public static extern ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x94CE80", Offset = "0x94CE80", VA = "0x94CE80")]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

		[PreserveSig]
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x94CF28", Offset = "0x94CF28", VA = "0x94CF28")]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, [In][Out] CSteamID[] prgUsers, int cUsers);

		[PreserveSig]
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x94CFC8", Offset = "0x94CFC8", VA = "0x94CFC8")]
		public static extern bool ISteamUserStats_GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, [In][Out] int[] pDetails, int cDetailsMax);

		[PreserveSig]
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x94D088", Offset = "0x94D088", VA = "0x94D088")]
		public static extern ulong ISteamUserStats_UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In][Out] int[] pScoreDetails, int cScoreDetailsCount);

		[PreserveSig]
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x94D140", Offset = "0x94D140", VA = "0x94D140")]
		public static extern ulong ISteamUserStats_AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC);

		[PreserveSig]
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x94D1D0", Offset = "0x94D1D0", VA = "0x94D1D0")]
		public static extern ulong ISteamUserStats_GetNumberOfCurrentPlayers();

		[PreserveSig]
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x94D244", Offset = "0x94D244", VA = "0x94D244")]
		public static extern ulong ISteamUserStats_RequestGlobalAchievementPercentages();

		[PreserveSig]
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x94D2B8", Offset = "0x94D2B8", VA = "0x94D2B8")]
		public static extern int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x94D374", Offset = "0x94D374", VA = "0x94D374")]
		public static extern int ISteamUserStats_GetNextMostAchievedAchievementInfo(int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x94D438", Offset = "0x94D438", VA = "0x94D438")]
		public static extern bool ISteamUserStats_GetAchievementAchievedPercent(InteropHelp.UTF8StringHandle pchName, out float pflPercent);

		[PreserveSig]
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x94D514", Offset = "0x94D514", VA = "0x94D514")]
		public static extern ulong ISteamUserStats_RequestGlobalStats(int nHistoryDays);

		[PreserveSig]
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x94D594", Offset = "0x94D594", VA = "0x94D594")]
		public static extern bool ISteamUserStats_GetGlobalStat(InteropHelp.UTF8StringHandle pchStatName, out long pData);

		[PreserveSig]
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x94D670", Offset = "0x94D670", VA = "0x94D670")]
		public static extern bool ISteamUserStats_GetGlobalStat_(InteropHelp.UTF8StringHandle pchStatName, out double pData);

		[PreserveSig]
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x94D74C", Offset = "0x94D74C", VA = "0x94D74C")]
		public static extern int ISteamUserStats_GetGlobalStatHistory(InteropHelp.UTF8StringHandle pchStatName, [In][Out] long[] pData, uint cubData);

		[PreserveSig]
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x94D834", Offset = "0x94D834", VA = "0x94D834")]
		public static extern int ISteamUserStats_GetGlobalStatHistory_(InteropHelp.UTF8StringHandle pchStatName, [In][Out] double[] pData, uint cubData);

		[PreserveSig]
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x94D91C", Offset = "0x94D91C", VA = "0x94D91C")]
		public static extern uint ISteamUtils_GetSecondsSinceAppActive();

		[PreserveSig]
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x94D990", Offset = "0x94D990", VA = "0x94D990")]
		public static extern uint ISteamUtils_GetSecondsSinceComputerActive();

		[PreserveSig]
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x94DA04", Offset = "0x94DA04", VA = "0x94DA04")]
		public static extern EUniverse ISteamUtils_GetConnectedUniverse();

		[PreserveSig]
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x94DA78", Offset = "0x94DA78", VA = "0x94DA78")]
		public static extern uint ISteamUtils_GetServerRealTime();

		[PreserveSig]
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x94DAEC", Offset = "0x94DAEC", VA = "0x94DAEC")]
		public static extern IntPtr ISteamUtils_GetIPCountry();

		[PreserveSig]
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x94DB60", Offset = "0x94DB60", VA = "0x94DB60")]
		public static extern bool ISteamUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight);

		[PreserveSig]
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x94DC00", Offset = "0x94DC00", VA = "0x94DC00")]
		public static extern bool ISteamUtils_GetImageRGBA(int iImage, [In][Out] byte[] pubDest, int nDestBufferSize);

		[PreserveSig]
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x94DCA8", Offset = "0x94DCA8", VA = "0x94DCA8")]
		public static extern bool ISteamUtils_GetCSERIPPort(out uint unIP, out ushort usPort);

		[PreserveSig]
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x94DD40", Offset = "0x94DD40", VA = "0x94DD40")]
		public static extern byte ISteamUtils_GetCurrentBatteryPower();

		[PreserveSig]
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x94DDB4", Offset = "0x94DDB4", VA = "0x94DDB4")]
		public static extern uint ISteamUtils_GetAppID();

		[PreserveSig]
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x94DE28", Offset = "0x94DE28", VA = "0x94DE28")]
		public static extern void ISteamUtils_SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition);

		[PreserveSig]
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x94DEA8", Offset = "0x94DEA8", VA = "0x94DEA8")]
		public static extern bool ISteamUtils_IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x94DF54", Offset = "0x94DF54", VA = "0x94DF54")]
		public static extern ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(SteamAPICall_t hSteamAPICall);

		[PreserveSig]
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x94DFD4", Offset = "0x94DFD4", VA = "0x94DFD4")]
		public static extern bool ISteamUtils_GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x94E0A0", Offset = "0x94E0A0", VA = "0x94E0A0")]
		public static extern void ISteamUtils_RunFrame();

		[PreserveSig]
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x94E110", Offset = "0x94E110", VA = "0x94E110")]
		public static extern uint ISteamUtils_GetIPCCallCount();

		[PreserveSig]
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x94E184", Offset = "0x94E184", VA = "0x94E184")]
		public static extern void ISteamUtils_SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x94E208", Offset = "0x94E208", VA = "0x94E208")]
		public static extern bool ISteamUtils_IsOverlayEnabled();

		[PreserveSig]
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x94E284", Offset = "0x94E284", VA = "0x94E284")]
		public static extern bool ISteamUtils_BOverlayNeedsPresent();

		[PreserveSig]
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x94E300", Offset = "0x94E300", VA = "0x94E300")]
		public static extern ulong ISteamUtils_CheckFileSignature(InteropHelp.UTF8StringHandle szFileName);

		[PreserveSig]
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x94E3C8", Offset = "0x94E3C8", VA = "0x94E3C8")]
		public static extern bool ISteamUtils_ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText);

		[PreserveSig]
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x94E508", Offset = "0x94E508", VA = "0x94E508")]
		public static extern uint ISteamUtils_GetEnteredGamepadTextLength();

		[PreserveSig]
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x94E57C", Offset = "0x94E57C", VA = "0x94E57C")]
		public static extern bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr pchText, uint cchText);

		[PreserveSig]
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x94E614", Offset = "0x94E614", VA = "0x94E614")]
		public static extern IntPtr ISteamUtils_GetSteamUILanguage();

		[PreserveSig]
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x94E688", Offset = "0x94E688", VA = "0x94E688")]
		public static extern bool ISteamUtils_IsSteamRunningInVR();

		[PreserveSig]
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x94E704", Offset = "0x94E704", VA = "0x94E704")]
		public static extern void ISteamUtils_SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset);

		[PreserveSig]
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x94E794", Offset = "0x94E794", VA = "0x94E794")]
		public static extern void ISteamVideo_GetVideoURL(AppId_t unVideoAppID);

		[PreserveSig]
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x94E814", Offset = "0x94E814", VA = "0x94E814")]
		public static extern bool ISteamVideo_IsBroadcasting(out int pnNumViewers);

		[PreserveSig]
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x94E89C", Offset = "0x94E89C", VA = "0x94E89C")]
		public static extern uint ISteamGameServerHTTP_CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL);

		[PreserveSig]
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x94E974", Offset = "0x94E974", VA = "0x94E974")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue);

		[PreserveSig]
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x94EA0C", Offset = "0x94EA0C", VA = "0x94EA0C")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		[PreserveSig]
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x94EAA4", Offset = "0x94EAA4", VA = "0x94EAA4")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue);

		[PreserveSig]
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x94EBCC", Offset = "0x94EBCC", VA = "0x94EBCC")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue);

		[PreserveSig]
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x94ECF4", Offset = "0x94ECF4", VA = "0x94ECF4")]
		public static extern bool ISteamGameServerHTTP_SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x94ED8C", Offset = "0x94ED8C", VA = "0x94ED8C")]
		public static extern bool ISteamGameServerHTTP_SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x94EE24", Offset = "0x94EE24", VA = "0x94EE24")]
		public static extern bool ISteamGameServerHTTP_DeferHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x94EEAC", Offset = "0x94EEAC", VA = "0x94EEAC")]
		public static extern bool ISteamGameServerHTTP_PrioritizeHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x94EF34", Offset = "0x94EF34", VA = "0x94EF34")]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize);

		[PreserveSig]
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x94F018", Offset = "0x94F018", VA = "0x94F018")]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, [In][Out] byte[] pHeaderValueBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x94F114", Offset = "0x94F114", VA = "0x94F114")]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize);

		[PreserveSig]
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x94F1AC", Offset = "0x94F1AC", VA = "0x94F1AC")]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseBodyData(HTTPRequestHandle hRequest, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x94F254", Offset = "0x94F254", VA = "0x94F254")]
		public static extern bool ISteamGameServerHTTP_GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x94F30C", Offset = "0x94F30C", VA = "0x94F30C")]
		public static extern bool ISteamGameServerHTTP_ReleaseHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x94F394", Offset = "0x94F394", VA = "0x94F394")]
		public static extern bool ISteamGameServerHTTP_GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut);

		[PreserveSig]
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x94F42C", Offset = "0x94F42C", VA = "0x94F42C")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, [In][Out] byte[] pubBody, uint unBodyLen);

		[PreserveSig]
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x94F528", Offset = "0x94F528", VA = "0x94F528")]
		public static extern uint ISteamGameServerHTTP_CreateCookieContainer(bool bAllowResponsesToModify);

		[PreserveSig]
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x94F5A8", Offset = "0x94F5A8", VA = "0x94F5A8")]
		public static extern bool ISteamGameServerHTTP_ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x94F630", Offset = "0x94F630", VA = "0x94F630")]
		public static extern bool ISteamGameServerHTTP_SetCookie(HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie);

		[PreserveSig]
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x94F7A4", Offset = "0x94F7A4", VA = "0x94F7A4")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x94F83C", Offset = "0x94F83C", VA = "0x94F83C")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo);

		[PreserveSig]
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x94F918", Offset = "0x94F918", VA = "0x94F918")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate);

		[PreserveSig]
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x94F9B0", Offset = "0x94F9B0", VA = "0x94F9B0")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds);

		[PreserveSig]
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x94FA48", Offset = "0x94FA48", VA = "0x94FA48")]
		public static extern bool ISteamGameServerHTTP_GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		[PreserveSig]
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x94FAF4", Offset = "0x94FAF4", VA = "0x94FAF4")]
		public static extern EResult ISteamGameServerInventory_GetResultStatus(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x94FB74", Offset = "0x94FB74", VA = "0x94FB74")]
		public static extern bool ISteamGameServerInventory_GetResultItems(SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		[PreserveSig]
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x94FC1C", Offset = "0x94FC1C", VA = "0x94FC1C")]
		public static extern uint ISteamGameServerInventory_GetResultTimestamp(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x94FC9C", Offset = "0x94FC9C", VA = "0x94FC9C")]
		public static extern bool ISteamGameServerInventory_CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		[PreserveSig]
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x94FD34", Offset = "0x94FD34", VA = "0x94FD34")]
		public static extern void ISteamGameServerInventory_DestroyResult(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x94FDB4", Offset = "0x94FDB4", VA = "0x94FDB4")]
		public static extern bool ISteamGameServerInventory_GetAllItems(out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x94FE3C", Offset = "0x94FE3C", VA = "0x94FE3C")]
		public static extern bool ISteamGameServerInventory_GetItemsByID(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		[PreserveSig]
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x94FEE4", Offset = "0x94FEE4", VA = "0x94FEE4")]
		public static extern bool ISteamGameServerInventory_SerializeResult(SteamInventoryResult_t resultHandle, [In][Out] byte[] pOutBuffer, out uint punOutBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x94FF8C", Offset = "0x94FF8C", VA = "0x94FF8C")]
		public static extern bool ISteamGameServerInventory_DeserializeResult(out SteamInventoryResult_t pOutResultHandle, [In][Out] byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE);

		[PreserveSig]
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x950044", Offset = "0x950044", VA = "0x950044")]
		public static extern bool ISteamGameServerInventory_GenerateItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x950104", Offset = "0x950104", VA = "0x950104")]
		public static extern bool ISteamGameServerInventory_GrantPromoItems(out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x95018C", Offset = "0x95018C", VA = "0x95018C")]
		public static extern bool ISteamGameServerInventory_AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		[PreserveSig]
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x950224", Offset = "0x950224", VA = "0x950224")]
		public static extern bool ISteamGameServerInventory_AddPromoItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x9502CC", Offset = "0x9502CC", VA = "0x9502CC")]
		public static extern bool ISteamGameServerInventory_ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		[PreserveSig]
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x95036C", Offset = "0x95036C", VA = "0x95036C")]
		public static extern bool ISteamGameServerInventory_ExchangeItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayGenerate, [In][Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In][Out] SteamItemInstanceID_t[] pArrayDestroy, [In][Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		[PreserveSig]
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x95045C", Offset = "0x95045C", VA = "0x95045C")]
		public static extern bool ISteamGameServerInventory_TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		[PreserveSig]
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x95050C", Offset = "0x95050C", VA = "0x95050C")]
		public static extern void ISteamGameServerInventory_SendItemDropHeartbeat();

		[PreserveSig]
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x95057C", Offset = "0x95057C", VA = "0x95057C")]
		public static extern bool ISteamGameServerInventory_TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		[PreserveSig]
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x950614", Offset = "0x950614", VA = "0x950614")]
		public static extern bool ISteamGameServerInventory_TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In][Out] SteamItemInstanceID_t[] pArrayGive, [In][Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In][Out] SteamItemInstanceID_t[] pArrayGet, [In][Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		[PreserveSig]
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x950714", Offset = "0x950714", VA = "0x950714")]
		public static extern bool ISteamGameServerInventory_LoadItemDefinitions();

		[PreserveSig]
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x950790", Offset = "0x950790", VA = "0x950790")]
		public static extern bool ISteamGameServerInventory_GetItemDefinitionIDs([In][Out] SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize);

		[PreserveSig]
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x950830", Offset = "0x950830", VA = "0x950830")]
		public static extern bool ISteamGameServerInventory_GetItemDefinitionProperty(SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x950924", Offset = "0x950924", VA = "0x950924")]
		public static extern bool ISteamGameServerNetworking_SendP2PPacket(CSteamID steamIDRemote, [In][Out] byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		[PreserveSig]
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x9509E4", Offset = "0x9509E4", VA = "0x9509E4")]
		public static extern bool ISteamGameServerNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel);

		[PreserveSig]
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x950A7C", Offset = "0x950A7C", VA = "0x950A7C")]
		public static extern bool ISteamGameServerNetworking_ReadP2PPacket([In][Out] byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x950B3C", Offset = "0x950B3C", VA = "0x950B3C")]
		public static extern bool ISteamGameServerNetworking_AcceptP2PSessionWithUser(CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x950BC4", Offset = "0x950BC4", VA = "0x950BC4")]
		public static extern bool ISteamGameServerNetworking_CloseP2PSessionWithUser(CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x950C4C", Offset = "0x950C4C", VA = "0x950C4C")]
		public static extern bool ISteamGameServerNetworking_CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x950CE4", Offset = "0x950CE4", VA = "0x950CE4")]
		public static extern bool ISteamGameServerNetworking_GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		[PreserveSig]
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x950D7C", Offset = "0x950D7C", VA = "0x950D7C")]
		public static extern bool ISteamGameServerNetworking_AllowP2PPacketRelay(bool bAllow);

		[PreserveSig]
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x950E04", Offset = "0x950E04", VA = "0x950E04")]
		public static extern uint ISteamGameServerNetworking_CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x950EAC", Offset = "0x950EAC", VA = "0x950EAC")]
		public static extern uint ISteamGameServerNetworking_CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x950F54", Offset = "0x950F54", VA = "0x950F54")]
		public static extern uint ISteamGameServerNetworking_CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec);

		[PreserveSig]
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x950FEC", Offset = "0x950FEC", VA = "0x950FEC")]
		public static extern bool ISteamGameServerNetworking_DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x951084", Offset = "0x951084", VA = "0x951084")]
		public static extern bool ISteamGameServerNetworking_DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x95111C", Offset = "0x95111C", VA = "0x95111C")]
		public static extern bool ISteamGameServerNetworking_SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, bool bReliable);

		[PreserveSig]
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x9511CC", Offset = "0x9511CC", VA = "0x9511CC")]
		public static extern bool ISteamGameServerNetworking_IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x951264", Offset = "0x951264", VA = "0x951264")]
		public static extern bool ISteamGameServerNetworking_RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x951314", Offset = "0x951314", VA = "0x951314")]
		public static extern bool ISteamGameServerNetworking_IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x9513B4", Offset = "0x9513B4", VA = "0x9513B4")]
		public static extern bool ISteamGameServerNetworking_RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x95146C", Offset = "0x95146C", VA = "0x95146C")]
		public static extern bool ISteamGameServerNetworking_GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote);

		[PreserveSig]
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x951524", Offset = "0x951524", VA = "0x951524")]
		public static extern bool ISteamGameServerNetworking_GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort);

		[PreserveSig]
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x9515C4", Offset = "0x9515C4", VA = "0x9515C4")]
		public static extern ESNetSocketConnectionType ISteamGameServerNetworking_GetSocketConnectionType(SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x951644", Offset = "0x951644", VA = "0x951644")]
		public static extern int ISteamGameServerNetworking_GetMaxPacketSize(SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x9516C4", Offset = "0x9516C4", VA = "0x9516C4")]
		public static extern ulong ISteamGameServerUGC_CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x95178C", Offset = "0x95178C", VA = "0x95178C")]
		public static extern ulong ISteamGameServerUGC_CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x95183C", Offset = "0x95183C", VA = "0x95183C")]
		public static extern ulong ISteamGameServerUGC_CreateQueryUGCDetailsRequest([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x9518D4", Offset = "0x9518D4", VA = "0x9518D4")]
		public static extern ulong ISteamGameServerUGC_SendQueryUGCRequest(UGCQueryHandle_t handle);

		[PreserveSig]
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x951954", Offset = "0x951954", VA = "0x951954")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails);

		[PreserveSig]
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x951A4C", Offset = "0x951A4C", VA = "0x951A4C")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize);

		[PreserveSig]
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x951AFC", Offset = "0x951AFC", VA = "0x951AFC")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize);

		[PreserveSig]
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x951BAC", Offset = "0x951BAC", VA = "0x951BAC")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[PreserveSig]
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x951C64", Offset = "0x951C64", VA = "0x951C64")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out uint pStatValue);

		[PreserveSig]
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x951D14", Offset = "0x951D14", VA = "0x951D14")]
		public static extern uint ISteamGameServerUGC_GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index);

		[PreserveSig]
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x951DA4", Offset = "0x951DA4", VA = "0x951DA4")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, out bool pbIsImage);

		[PreserveSig]
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x951E80", Offset = "0x951E80", VA = "0x951E80")]
		public static extern uint ISteamGameServerUGC_GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index);

		[PreserveSig]
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x951F10", Offset = "0x951F10", VA = "0x951F10")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize);

		[PreserveSig]
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x951FE0", Offset = "0x951FE0", VA = "0x951FE0")]
		public static extern bool ISteamGameServerUGC_ReleaseQueryUGCRequest(UGCQueryHandle_t handle);

		[PreserveSig]
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x952068", Offset = "0x952068", VA = "0x952068")]
		public static extern bool ISteamGameServerUGC_AddRequiredTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[PreserveSig]
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x952144", Offset = "0x952144", VA = "0x952144")]
		public static extern bool ISteamGameServerUGC_AddExcludedTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[PreserveSig]
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x952220", Offset = "0x952220", VA = "0x952220")]
		public static extern bool ISteamGameServerUGC_SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags);

		[PreserveSig]
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x9522B8", Offset = "0x9522B8", VA = "0x9522B8")]
		public static extern bool ISteamGameServerUGC_SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription);

		[PreserveSig]
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x952350", Offset = "0x952350", VA = "0x952350")]
		public static extern bool ISteamGameServerUGC_SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata);

		[PreserveSig]
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x9523E8", Offset = "0x9523E8", VA = "0x9523E8")]
		public static extern bool ISteamGameServerUGC_SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren);

		[PreserveSig]
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x952480", Offset = "0x952480", VA = "0x952480")]
		public static extern bool ISteamGameServerUGC_SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews);

		[PreserveSig]
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x952518", Offset = "0x952518", VA = "0x952518")]
		public static extern bool ISteamGameServerUGC_SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly);

		[PreserveSig]
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x9525B0", Offset = "0x9525B0", VA = "0x9525B0")]
		public static extern bool ISteamGameServerUGC_SetLanguage(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[PreserveSig]
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x95268C", Offset = "0x95268C", VA = "0x95268C")]
		public static extern bool ISteamGameServerUGC_SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		[PreserveSig]
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x952724", Offset = "0x952724", VA = "0x952724")]
		public static extern bool ISteamGameServerUGC_SetCloudFileNameFilter(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName);

		[PreserveSig]
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x952800", Offset = "0x952800", VA = "0x952800")]
		public static extern bool ISteamGameServerUGC_SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag);

		[PreserveSig]
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x952898", Offset = "0x952898", VA = "0x952898")]
		public static extern bool ISteamGameServerUGC_SetSearchText(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText);

		[PreserveSig]
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x952974", Offset = "0x952974", VA = "0x952974")]
		public static extern bool ISteamGameServerUGC_SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays);

		[PreserveSig]
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x952A0C", Offset = "0x952A0C", VA = "0x952A0C")]
		public static extern bool ISteamGameServerUGC_AddRequiredKeyValueTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[PreserveSig]
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x952B34", Offset = "0x952B34", VA = "0x952B34")]
		public static extern ulong ISteamGameServerUGC_RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds);

		[PreserveSig]
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x952BC4", Offset = "0x952BC4", VA = "0x952BC4")]
		public static extern ulong ISteamGameServerUGC_CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType);

		[PreserveSig]
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x952C54", Offset = "0x952C54", VA = "0x952C54")]
		public static extern ulong ISteamGameServerUGC_StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x952CE4", Offset = "0x952CE4", VA = "0x952CE4")]
		public static extern bool ISteamGameServerUGC_SetItemTitle(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle);

		[PreserveSig]
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x952DC0", Offset = "0x952DC0", VA = "0x952DC0")]
		public static extern bool ISteamGameServerUGC_SetItemDescription(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription);

		[PreserveSig]
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x952E9C", Offset = "0x952E9C", VA = "0x952E9C")]
		public static extern bool ISteamGameServerUGC_SetItemUpdateLanguage(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[PreserveSig]
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x952F78", Offset = "0x952F78", VA = "0x952F78")]
		public static extern bool ISteamGameServerUGC_SetItemMetadata(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData);

		[PreserveSig]
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x953054", Offset = "0x953054", VA = "0x953054")]
		public static extern bool ISteamGameServerUGC_SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

		[PreserveSig]
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x9530EC", Offset = "0x9530EC", VA = "0x9530EC")]
		public static extern bool ISteamGameServerUGC_SetItemTags(UGCUpdateHandle_t updateHandle, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x953184", Offset = "0x953184", VA = "0x953184")]
		public static extern bool ISteamGameServerUGC_SetItemContent(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder);

		[PreserveSig]
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x953260", Offset = "0x953260", VA = "0x953260")]
		public static extern bool ISteamGameServerUGC_SetItemPreview(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile);

		[PreserveSig]
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x95333C", Offset = "0x95333C", VA = "0x95333C")]
		public static extern bool ISteamGameServerUGC_RemoveItemKeyValueTags(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x953418", Offset = "0x953418", VA = "0x953418")]
		public static extern bool ISteamGameServerUGC_AddItemKeyValueTag(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x953540", Offset = "0x953540", VA = "0x953540")]
		public static extern ulong ISteamGameServerUGC_SubmitItemUpdate(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote);

		[PreserveSig]
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x953618", Offset = "0x953618", VA = "0x953618")]
		public static extern EItemUpdateStatus ISteamGameServerUGC_GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x9536B0", Offset = "0x9536B0", VA = "0x9536B0")]
		public static extern ulong ISteamGameServerUGC_SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp);

		[PreserveSig]
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x953740", Offset = "0x953740", VA = "0x953740")]
		public static extern ulong ISteamGameServerUGC_GetUserItemVote(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x9537C0", Offset = "0x9537C0", VA = "0x9537C0")]
		public static extern ulong ISteamGameServerUGC_AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x953850", Offset = "0x953850", VA = "0x953850")]
		public static extern ulong ISteamGameServerUGC_RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x9538E0", Offset = "0x9538E0", VA = "0x9538E0")]
		public static extern ulong ISteamGameServerUGC_SubscribeItem(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x953960", Offset = "0x953960", VA = "0x953960")]
		public static extern ulong ISteamGameServerUGC_UnsubscribeItem(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x9539E0", Offset = "0x9539E0", VA = "0x9539E0")]
		public static extern uint ISteamGameServerUGC_GetNumSubscribedItems();

		[PreserveSig]
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x953A54", Offset = "0x953A54", VA = "0x953A54")]
		public static extern uint ISteamGameServerUGC_GetSubscribedItems([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[PreserveSig]
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x953AEC", Offset = "0x953AEC", VA = "0x953AEC")]
		public static extern uint ISteamGameServerUGC_GetItemState(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x953B6C", Offset = "0x953B6C", VA = "0x953B6C")]
		public static extern bool ISteamGameServerUGC_GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp);

		[PreserveSig]
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x953C24", Offset = "0x953C24", VA = "0x953C24")]
		public static extern bool ISteamGameServerUGC_GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x953CC4", Offset = "0x953CC4", VA = "0x953CC4")]
		public static extern bool ISteamGameServerUGC_DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority);

		[PreserveSig]
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x953D5C", Offset = "0x953D5C", VA = "0x953D5C")]
		public static extern uint ISteamGameServerUtils_GetSecondsSinceAppActive();

		[PreserveSig]
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x953DD0", Offset = "0x953DD0", VA = "0x953DD0")]
		public static extern uint ISteamGameServerUtils_GetSecondsSinceComputerActive();

		[PreserveSig]
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x953E44", Offset = "0x953E44", VA = "0x953E44")]
		public static extern EUniverse ISteamGameServerUtils_GetConnectedUniverse();

		[PreserveSig]
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x953EB8", Offset = "0x953EB8", VA = "0x953EB8")]
		public static extern uint ISteamGameServerUtils_GetServerRealTime();

		[PreserveSig]
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x953F2C", Offset = "0x953F2C", VA = "0x953F2C")]
		public static extern IntPtr ISteamGameServerUtils_GetIPCountry();

		[PreserveSig]
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x953FA0", Offset = "0x953FA0", VA = "0x953FA0")]
		public static extern bool ISteamGameServerUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight);

		[PreserveSig]
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x954040", Offset = "0x954040", VA = "0x954040")]
		public static extern bool ISteamGameServerUtils_GetImageRGBA(int iImage, [In][Out] byte[] pubDest, int nDestBufferSize);

		[PreserveSig]
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x9540E8", Offset = "0x9540E8", VA = "0x9540E8")]
		public static extern bool ISteamGameServerUtils_GetCSERIPPort(out uint unIP, out ushort usPort);

		[PreserveSig]
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x954180", Offset = "0x954180", VA = "0x954180")]
		public static extern byte ISteamGameServerUtils_GetCurrentBatteryPower();

		[PreserveSig]
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x9541F4", Offset = "0x9541F4", VA = "0x9541F4")]
		public static extern uint ISteamGameServerUtils_GetAppID();

		[PreserveSig]
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x954268", Offset = "0x954268", VA = "0x954268")]
		public static extern void ISteamGameServerUtils_SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition);

		[PreserveSig]
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x9542E8", Offset = "0x9542E8", VA = "0x9542E8")]
		public static extern bool ISteamGameServerUtils_IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x954394", Offset = "0x954394", VA = "0x954394")]
		public static extern ESteamAPICallFailure ISteamGameServerUtils_GetAPICallFailureReason(SteamAPICall_t hSteamAPICall);

		[PreserveSig]
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x954414", Offset = "0x954414", VA = "0x954414")]
		public static extern bool ISteamGameServerUtils_GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x9544E0", Offset = "0x9544E0", VA = "0x9544E0")]
		public static extern void ISteamGameServerUtils_RunFrame();

		[PreserveSig]
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x954550", Offset = "0x954550", VA = "0x954550")]
		public static extern uint ISteamGameServerUtils_GetIPCCallCount();

		[PreserveSig]
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x9545C4", Offset = "0x9545C4", VA = "0x9545C4")]
		public static extern void ISteamGameServerUtils_SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x954648", Offset = "0x954648", VA = "0x954648")]
		public static extern bool ISteamGameServerUtils_IsOverlayEnabled();

		[PreserveSig]
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x9546C4", Offset = "0x9546C4", VA = "0x9546C4")]
		public static extern bool ISteamGameServerUtils_BOverlayNeedsPresent();

		[PreserveSig]
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x954740", Offset = "0x954740", VA = "0x954740")]
		public static extern ulong ISteamGameServerUtils_CheckFileSignature(InteropHelp.UTF8StringHandle szFileName);

		[PreserveSig]
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x954808", Offset = "0x954808", VA = "0x954808")]
		public static extern bool ISteamGameServerUtils_ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText);

		[PreserveSig]
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x954948", Offset = "0x954948", VA = "0x954948")]
		public static extern uint ISteamGameServerUtils_GetEnteredGamepadTextLength();

		[PreserveSig]
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x9549BC", Offset = "0x9549BC", VA = "0x9549BC")]
		public static extern bool ISteamGameServerUtils_GetEnteredGamepadTextInput(IntPtr pchText, uint cchText);

		[PreserveSig]
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x954A54", Offset = "0x954A54", VA = "0x954A54")]
		public static extern IntPtr ISteamGameServerUtils_GetSteamUILanguage();

		[PreserveSig]
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x954AC8", Offset = "0x954AC8", VA = "0x954AC8")]
		public static extern bool ISteamGameServerUtils_IsSteamRunningInVR();

		[PreserveSig]
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x954B44", Offset = "0x954B44", VA = "0x954B44")]
		public static extern void ISteamGameServerUtils_SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset);
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC7A4", Offset = "0x7EC7A4")]
	public struct SteamAppInstalled_t
	{
		[Token(Token = "0x400009A")]
		public const int k_iCallback = 3901;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC7B8", Offset = "0x7EC7B8")]
	public struct SteamAppUninstalled_t
	{
		[Token(Token = "0x400009C")]
		public const int k_iCallback = 3902;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC7CC", Offset = "0x7EC7CC")]
	public struct DlcInstalled_t
	{
		[Token(Token = "0x400009E")]
		public const int k_iCallback = 1005;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC7E0", Offset = "0x7EC7E0")]
	public struct RegisterActivationCodeResponse_t
	{
		[Token(Token = "0x40000A0")]
		public const int k_iCallback = 1008;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ERegisterActivationCodeResult m_eResult;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unPackageRegistered;
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC7F4", Offset = "0x7EC7F4")]
	public struct AppProofOfPurchaseKeyResponse_t
	{
		[Token(Token = "0x40000A3")]
		public const int k_iCallback = 1013;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_nAppID;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchKey;
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC808", Offset = "0x7EC808")]
	public struct NewLaunchQueryParameters_t
	{
		[Token(Token = "0x40000A7")]
		public const int k_iCallback = 1014;
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC81C", Offset = "0x7EC81C")]
	public struct PersonaStateChange_t
	{
		[Token(Token = "0x40000A8")]
		public const int k_iCallback = 304;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamID;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EPersonaChange m_nChangeFlags;
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC830", Offset = "0x7EC830")]
	public struct GameOverlayActivated_t
	{
		[Token(Token = "0x40000AB")]
		public const int k_iCallback = 331;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bActive;
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC844", Offset = "0x7EC844")]
	public struct GameServerChangeRequested_t
	{
		[Token(Token = "0x40000AD")]
		public const int k_iCallback = 332;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_rgchServer;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchPassword;
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC858", Offset = "0x7EC858")]
	public struct GameLobbyJoinRequested_t
	{
		[Token(Token = "0x40000B0")]
		public const int k_iCallback = 333;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDLobby;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDFriend;
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC86C", Offset = "0x7EC86C")]
	public struct AvatarImageLoaded_t
	{
		[Token(Token = "0x40000B3")]
		public const int k_iCallback = 334;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamID;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_iImage;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_iWide;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_iTall;
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC880", Offset = "0x7EC880")]
	public struct ClanOfficerListResponse_t
	{
		[Token(Token = "0x40000B8")]
		public const int k_iCallback = 335;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClan;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_cOfficers;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte m_bSuccess;
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC894", Offset = "0x7EC894")]
	public struct FriendRichPresenceUpdate_t
	{
		[Token(Token = "0x40000BC")]
		public const int k_iCallback = 336;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDFriend;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC8A8", Offset = "0x7EC8A8")]
	public struct GameRichPresenceJoinRequested_t
	{
		[Token(Token = "0x40000BF")]
		public const int k_iCallback = 337;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDFriend;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchConnect;
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC8BC", Offset = "0x7EC8BC")]
	public struct GameConnectedClanChatMsg_t
	{
		[Token(Token = "0x40000C2")]
		public const int k_iCallback = 338;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_iMessageID;
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC8D0", Offset = "0x7EC8D0")]
	public struct GameConnectedChatJoin_t
	{
		[Token(Token = "0x40000C6")]
		public const int k_iCallback = 339;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC8E4", Offset = "0x7EC8E4")]
	public struct GameConnectedChatLeave_t
	{
		[Token(Token = "0x40000C9")]
		public const int k_iCallback = 340;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bKicked;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_bDropped;
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC8F8", Offset = "0x7EC8F8")]
	public struct DownloadClanActivityCountsResult_t
	{
		[Token(Token = "0x40000CE")]
		public const int k_iCallback = 341;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bSuccess;
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC90C", Offset = "0x7EC90C")]
	public struct JoinClanChatRoomCompletionResult_t
	{
		[Token(Token = "0x40000D0")]
		public const int k_iCallback = 342;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC920", Offset = "0x7EC920")]
	public struct GameConnectedFriendChatMsg_t
	{
		[Token(Token = "0x40000D3")]
		public const int k_iCallback = 343;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_iMessageID;
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC934", Offset = "0x7EC934")]
	public struct FriendsGetFollowerCount_t
	{
		[Token(Token = "0x40000D6")]
		public const int k_iCallback = 344;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nCount;
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC948", Offset = "0x7EC948")]
	public struct FriendsIsFollowing_t
	{
		[Token(Token = "0x40000DA")]
		public const int k_iCallback = 345;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bIsFollowing;
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC95C", Offset = "0x7EC95C")]
	public struct FriendsEnumerateFollowingList_t
	{
		[Token(Token = "0x40000DE")]
		public const int k_iCallback = 346;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID[] m_rgSteamID;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nResultsReturned;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nTotalResultCount;
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC970", Offset = "0x7EC970")]
	public struct SetPersonaNameResponse_t
	{
		[Token(Token = "0x40000E3")]
		public const int k_iCallback = 347;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bSuccess;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public bool m_bLocalSuccess;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_result;
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC984", Offset = "0x7EC984")]
	public struct GCMessageAvailable_t
	{
		[Token(Token = "0x40000E7")]
		public const int k_iCallback = 1701;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nMessageSize;
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC998", Offset = "0x7EC998")]
	public struct GCMessageFailed_t
	{
		[Token(Token = "0x40000E9")]
		public const int k_iCallback = 1702;
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC9AC", Offset = "0x7EC9AC")]
	public struct GSClientApprove_t
	{
		[Token(Token = "0x40000EA")]
		public const int k_iCallback = 201;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_OwnerSteamID;
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC9C0", Offset = "0x7EC9C0")]
	public struct GSClientDeny_t
	{
		[Token(Token = "0x40000ED")]
		public const int k_iCallback = 202;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EDenyReason m_eDenyReason;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_rgchOptionalText;
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC9D4", Offset = "0x7EC9D4")]
	public struct GSClientKick_t
	{
		[Token(Token = "0x40000F1")]
		public const int k_iCallback = 203;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EDenyReason m_eDenyReason;
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC9E8", Offset = "0x7EC9E8")]
	public struct GSClientAchievementStatus_t
	{
		[Token(Token = "0x40000F4")]
		public const int k_iCallback = 206;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamID;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_pchAchievement;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bUnlocked;
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7EC9FC", Offset = "0x7EC9FC")]
	public struct GSPolicyResponse_t
	{
		[Token(Token = "0x40000F8")]
		public const int k_iCallback = 115;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bSecure;
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECA10", Offset = "0x7ECA10")]
	public struct GSGameplayStats_t
	{
		[Token(Token = "0x40000FA")]
		public const int k_iCallback = 207;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nRank;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_unTotalConnects;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_unTotalMinutesPlayed;
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECA24", Offset = "0x7ECA24")]
	public struct GSClientGroupStatus_t
	{
		[Token(Token = "0x40000FF")]
		public const int k_iCallback = 208;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamIDUser;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_SteamIDGroup;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bMember;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_bOfficer;
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECA38", Offset = "0x7ECA38")]
	public struct GSReputation_t
	{
		[Token(Token = "0x4000104")]
		public const int k_iCallback = 209;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unReputationScore;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool m_bBanned;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_unBannedIP;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ushort m_usBannedPort;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ulong m_ulBannedGameID;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint m_unBanExpires;
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECA4C", Offset = "0x7ECA4C")]
	public struct AssociateWithClanResult_t
	{
		[Token(Token = "0x400010C")]
		public const int k_iCallback = 210;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECA60", Offset = "0x7ECA60")]
	public struct ComputeNewPlayerCompatibilityResult_t
	{
		[Token(Token = "0x400010E")]
		public const int k_iCallback = 211;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_cPlayersThatDontLikeCandidate;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_cPlayersThatCandidateDoesntLike;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_cClanPlayersThatDontLikeCandidate;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CSteamID m_SteamIDCandidate;
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECA74", Offset = "0x7ECA74")]
	public struct GSStatsReceived_t
	{
		[Token(Token = "0x4000114")]
		public const int k_iCallback = 1800;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECA88", Offset = "0x7ECA88")]
	public struct GSStatsStored_t
	{
		[Token(Token = "0x4000117")]
		public const int k_iCallback = 1801;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECA9C", Offset = "0x7ECA9C")]
	public struct GSStatsUnloaded_t
	{
		[Token(Token = "0x400011A")]
		public const int k_iCallback = 1108;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECAB0", Offset = "0x7ECAB0")]
	public struct HTML_BrowserReady_t
	{
		[Token(Token = "0x400011C")]
		public const int k_iCallback = 4501;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECAC4", Offset = "0x7ECAC4")]
	public struct HTML_NeedsPaint_t
	{
		[Token(Token = "0x400011E")]
		public const int k_iCallback = 4502;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pBGRA;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint unWide;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unTall;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint unUpdateX;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint unUpdateY;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint unUpdateWide;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint unUpdateTall;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint unScrollX;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint unScrollY;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float flPageScale;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public uint unPageSerial;
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECAD8", Offset = "0x7ECAD8")]
	public struct HTML_StartRequest_t
	{
		[Token(Token = "0x400012B")]
		public const int k_iCallback = 4503;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchTarget;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string pchPostData;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool bIsRedirect;
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECAEC", Offset = "0x7ECAEC")]
	public struct HTML_CloseBrowser_t
	{
		[Token(Token = "0x4000131")]
		public const int k_iCallback = 4504;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECB00", Offset = "0x7ECB00")]
	public struct HTML_URLChanged_t
	{
		[Token(Token = "0x4000133")]
		public const int k_iCallback = 4505;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchPostData;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool bIsRedirect;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string pchPageTitle;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool bNewNavigation;
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECB14", Offset = "0x7ECB14")]
	public struct HTML_FinishedRequest_t
	{
		[Token(Token = "0x400013A")]
		public const int k_iCallback = 4506;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchPageTitle;
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECB28", Offset = "0x7ECB28")]
	public struct HTML_OpenLinkInNewTab_t
	{
		[Token(Token = "0x400013E")]
		public const int k_iCallback = 4507;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECB3C", Offset = "0x7ECB3C")]
	public struct HTML_ChangedTitle_t
	{
		[Token(Token = "0x4000141")]
		public const int k_iCallback = 4508;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchTitle;
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECB50", Offset = "0x7ECB50")]
	public struct HTML_SearchResults_t
	{
		[Token(Token = "0x4000144")]
		public const int k_iCallback = 4509;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unResults;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unCurrentMatch;
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECB64", Offset = "0x7ECB64")]
	public struct HTML_CanGoBackAndForward_t
	{
		[Token(Token = "0x4000148")]
		public const int k_iCallback = 4510;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool bCanGoBack;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public bool bCanGoForward;
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECB78", Offset = "0x7ECB78")]
	public struct HTML_HorizontalScroll_t
	{
		[Token(Token = "0x400014C")]
		public const int k_iCallback = 4511;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unScrollMax;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unScrollCurrent;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float flPageScale;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool bVisible;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unPageSize;
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECB8C", Offset = "0x7ECB8C")]
	public struct HTML_VerticalScroll_t
	{
		[Token(Token = "0x4000153")]
		public const int k_iCallback = 4512;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unScrollMax;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unScrollCurrent;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float flPageScale;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool bVisible;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unPageSize;
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECBA0", Offset = "0x7ECBA0")]
	public struct HTML_LinkAtPosition_t
	{
		[Token(Token = "0x400015A")]
		public const int k_iCallback = 4513;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint x;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint y;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchURL;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool bInput;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool bLiveLink;
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECBB4", Offset = "0x7ECBB4")]
	public struct HTML_JSAlert_t
	{
		[Token(Token = "0x4000161")]
		public const int k_iCallback = 4514;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMessage;
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECBC8", Offset = "0x7ECBC8")]
	public struct HTML_JSConfirm_t
	{
		[Token(Token = "0x4000164")]
		public const int k_iCallback = 4515;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMessage;
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECBDC", Offset = "0x7ECBDC")]
	public struct HTML_FileOpenDialog_t
	{
		[Token(Token = "0x4000167")]
		public const int k_iCallback = 4516;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchTitle;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchInitialFile;
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECBF0", Offset = "0x7ECBF0")]
	public struct HTML_NewWindow_t
	{
		[Token(Token = "0x400016B")]
		public const int k_iCallback = 4521;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint unX;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unY;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint unWide;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint unTall;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HHTMLBrowser unNewWindow_BrowserHandle;
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECC04", Offset = "0x7ECC04")]
	public struct HTML_SetCursor_t
	{
		[Token(Token = "0x4000173")]
		public const int k_iCallback = 4522;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint eMouseCursor;
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECC18", Offset = "0x7ECC18")]
	public struct HTML_StatusText_t
	{
		[Token(Token = "0x4000176")]
		public const int k_iCallback = 4523;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECC2C", Offset = "0x7ECC2C")]
	public struct HTML_ShowToolTip_t
	{
		[Token(Token = "0x4000179")]
		public const int k_iCallback = 4524;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECC40", Offset = "0x7ECC40")]
	public struct HTML_UpdateToolTip_t
	{
		[Token(Token = "0x400017C")]
		public const int k_iCallback = 4525;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECC54", Offset = "0x7ECC54")]
	public struct HTML_HideToolTip_t
	{
		[Token(Token = "0x400017F")]
		public const int k_iCallback = 4526;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECC68", Offset = "0x7ECC68")]
	public struct HTTPRequestCompleted_t
	{
		[Token(Token = "0x4000181")]
		public const int k_iCallback = 2101;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulContextValue;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bRequestSuccessful;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public EHTTPStatusCode m_eStatusCode;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_unBodySize;
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECC7C", Offset = "0x7ECC7C")]
	public struct HTTPRequestHeadersReceived_t
	{
		[Token(Token = "0x4000187")]
		public const int k_iCallback = 2102;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulContextValue;
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECC90", Offset = "0x7ECC90")]
	public struct HTTPRequestDataReceived_t
	{
		[Token(Token = "0x400018A")]
		public const int k_iCallback = 2103;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulContextValue;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_cOffset;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_cBytesReceived;
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECCA4", Offset = "0x7ECCA4")]
	public struct SteamInventoryResultReady_t
	{
		[Token(Token = "0x400018F")]
		public const int k_iCallback = 4700;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamInventoryResult_t m_handle;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_result;
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECCB8", Offset = "0x7ECCB8")]
	public struct SteamInventoryFullUpdate_t
	{
		[Token(Token = "0x4000192")]
		public const int k_iCallback = 4701;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamInventoryResult_t m_handle;
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECCCC", Offset = "0x7ECCCC")]
	public struct SteamInventoryDefinitionUpdate_t
	{
		[Token(Token = "0x4000194")]
		public const int k_iCallback = 4702;
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECCE0", Offset = "0x7ECCE0")]
	public struct FavoritesListChanged_t
	{
		[Token(Token = "0x4000195")]
		public const int k_iCallback = 502;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nIP;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_nQueryPort;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_nConnPort;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nAppID;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_nFlags;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool m_bAdd;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AccountID_t m_unAccountId;
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECCF4", Offset = "0x7ECCF4")]
	public struct LobbyInvite_t
	{
		[Token(Token = "0x400019D")]
		public const int k_iCallback = 503;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDUser;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong m_ulGameID;
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECD08", Offset = "0x7ECD08")]
	public struct LobbyEnter_t
	{
		[Token(Token = "0x40001A1")]
		public const int k_iCallback = 504;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_rgfChatPermissions;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bLocked;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_EChatRoomEnterResponse;
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECD1C", Offset = "0x7ECD1C")]
	public struct LobbyDataUpdate_t
	{
		[Token(Token = "0x40001A6")]
		public const int k_iCallback = 505;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDMember;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_bSuccess;
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECD30", Offset = "0x7ECD30")]
	public struct LobbyChatUpdate_t
	{
		[Token(Token = "0x40001AA")]
		public const int k_iCallback = 506;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDUserChanged;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong m_ulSteamIDMakingChange;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_rgfChatMemberStateChange;
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECD44", Offset = "0x7ECD44")]
	public struct LobbyChatMsg_t
	{
		[Token(Token = "0x40001AF")]
		public const int k_iCallback = 507;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDUser;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_eChatEntryType;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_iChatID;
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECD58", Offset = "0x7ECD58")]
	public struct LobbyGameCreated_t
	{
		[Token(Token = "0x40001B4")]
		public const int k_iCallback = 509;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDGameServer;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_unIP;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ushort m_usPort;
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECD6C", Offset = "0x7ECD6C")]
	public struct LobbyMatchList_t
	{
		[Token(Token = "0x40001B9")]
		public const int k_iCallback = 510;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nLobbiesMatching;
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECD80", Offset = "0x7ECD80")]
	public struct LobbyKicked_t
	{
		[Token(Token = "0x40001BB")]
		public const int k_iCallback = 512;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDAdmin;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_bKickedDueToDisconnect;
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECD94", Offset = "0x7ECD94")]
	public struct LobbyCreated_t
	{
		[Token(Token = "0x40001BF")]
		public const int k_iCallback = 513;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDLobby;
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECDA8", Offset = "0x7ECDA8")]
	public struct FavoritesListAccountsUpdated_t
	{
		[Token(Token = "0x40001C2")]
		public const int k_iCallback = 516;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECDBC", Offset = "0x7ECDBC")]
	public struct PlaybackStatusHasChanged_t
	{
		[Token(Token = "0x40001C4")]
		public const int k_iCallback = 4001;
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECDD0", Offset = "0x7ECDD0")]
	public struct VolumeHasChanged_t
	{
		[Token(Token = "0x40001C5")]
		public const int k_iCallback = 4002;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_flNewVolume;
	}
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECDE4", Offset = "0x7ECDE4")]
	public struct MusicPlayerRemoteWillActivate_t
	{
		[Token(Token = "0x40001C7")]
		public const int k_iCallback = 4101;
	}
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECDF8", Offset = "0x7ECDF8")]
	public struct MusicPlayerRemoteWillDeactivate_t
	{
		[Token(Token = "0x40001C8")]
		public const int k_iCallback = 4102;
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECE0C", Offset = "0x7ECE0C")]
	public struct MusicPlayerRemoteToFront_t
	{
		[Token(Token = "0x40001C9")]
		public const int k_iCallback = 4103;
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECE20", Offset = "0x7ECE20")]
	public struct MusicPlayerWillQuit_t
	{
		[Token(Token = "0x40001CA")]
		public const int k_iCallback = 4104;
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECE34", Offset = "0x7ECE34")]
	public struct MusicPlayerWantsPlay_t
	{
		[Token(Token = "0x40001CB")]
		public const int k_iCallback = 4105;
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECE48", Offset = "0x7ECE48")]
	public struct MusicPlayerWantsPause_t
	{
		[Token(Token = "0x40001CC")]
		public const int k_iCallback = 4106;
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECE5C", Offset = "0x7ECE5C")]
	public struct MusicPlayerWantsPlayPrevious_t
	{
		[Token(Token = "0x40001CD")]
		public const int k_iCallback = 4107;
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECE70", Offset = "0x7ECE70")]
	public struct MusicPlayerWantsPlayNext_t
	{
		[Token(Token = "0x40001CE")]
		public const int k_iCallback = 4108;
	}
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECE84", Offset = "0x7ECE84")]
	public struct MusicPlayerWantsShuffled_t
	{
		[Token(Token = "0x40001CF")]
		public const int k_iCallback = 4109;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bShuffled;
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECE98", Offset = "0x7ECE98")]
	public struct MusicPlayerWantsLooped_t
	{
		[Token(Token = "0x40001D1")]
		public const int k_iCallback = 4110;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bLooped;
	}
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECEAC", Offset = "0x7ECEAC")]
	public struct MusicPlayerWantsVolume_t
	{
		[Token(Token = "0x40001D3")]
		public const int k_iCallback = 4011;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_flNewVolume;
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECEC0", Offset = "0x7ECEC0")]
	public struct MusicPlayerSelectsQueueEntry_t
	{
		[Token(Token = "0x40001D5")]
		public const int k_iCallback = 4012;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nID;
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECED4", Offset = "0x7ECED4")]
	public struct MusicPlayerSelectsPlaylistEntry_t
	{
		[Token(Token = "0x40001D7")]
		public const int k_iCallback = 4013;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nID;
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECEE8", Offset = "0x7ECEE8")]
	public struct MusicPlayerWantsPlayingRepeatStatus_t
	{
		[Token(Token = "0x40001D9")]
		public const int k_iCallback = 4114;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_nPlayingRepeatStatus;
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECEFC", Offset = "0x7ECEFC")]
	public struct P2PSessionRequest_t
	{
		[Token(Token = "0x40001DB")]
		public const int k_iCallback = 1202;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDRemote;
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECF10", Offset = "0x7ECF10")]
	public struct P2PSessionConnectFail_t
	{
		[Token(Token = "0x40001DD")]
		public const int k_iCallback = 1203;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDRemote;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte m_eP2PSessionError;
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECF24", Offset = "0x7ECF24")]
	public struct SocketStatusCallback_t
	{
		[Token(Token = "0x40001E0")]
		public const int k_iCallback = 1201;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SNetSocket_t m_hSocket;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SNetListenSocket_t m_hListenSocket;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDRemote;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_eSNetSocketState;
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECF38", Offset = "0x7ECF38")]
	public struct RemoteStorageAppSyncedClient_t
	{
		[Token(Token = "0x40001E5")]
		public const int k_iCallback = 1301;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_unNumDownloads;
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECF4C", Offset = "0x7ECF4C")]
	public struct RemoteStorageAppSyncedServer_t
	{
		[Token(Token = "0x40001E9")]
		public const int k_iCallback = 1302;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_unNumUploads;
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECF60", Offset = "0x7ECF60")]
	public struct RemoteStorageAppSyncProgress_t
	{
		[Token(Token = "0x40001ED")]
		public const int k_iCallback = 1303;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_rgchCurrentFile;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_uBytesTransferredThisChunk;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double m_dAppPercentComplete;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_bUploading;
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECF74", Offset = "0x7ECF74")]
	public struct RemoteStorageAppSyncStatusCheck_t
	{
		[Token(Token = "0x40001F3")]
		public const int k_iCallback = 1305;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECF88", Offset = "0x7ECF88")]
	public struct RemoteStorageConflictResolution_t
	{
		[Token(Token = "0x40001F6")]
		public const int k_iCallback = 1306;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECF9C", Offset = "0x7ECF9C")]
	public struct RemoteStorageFileShareResult_t
	{
		[Token(Token = "0x40001F9")]
		public const int k_iCallback = 1307;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_rgchFilename;
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECFB0", Offset = "0x7ECFB0")]
	public struct RemoteStoragePublishFileResult_t
	{
		[Token(Token = "0x40001FD")]
		public const int k_iCallback = 1309;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECFC4", Offset = "0x7ECFC4")]
	public struct RemoteStorageDeletePublishedFileResult_t
	{
		[Token(Token = "0x4000201")]
		public const int k_iCallback = 1311;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECFD8", Offset = "0x7ECFD8")]
	public struct RemoteStorageEnumerateUserPublishedFilesResult_t
	{
		[Token(Token = "0x4000204")]
		public const int k_iCallback = 1312;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ECFEC", Offset = "0x7ECFEC")]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		[Token(Token = "0x4000209")]
		public const int k_iCallback = 1313;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED000", Offset = "0x7ED000")]
	public struct RemoteStorageEnumerateUserSubscribedFilesResult_t
	{
		[Token(Token = "0x400020C")]
		public const int k_iCallback = 1314;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint[] m_rgRTimeSubscribed;
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED014", Offset = "0x7ED014")]
	public struct RemoteStorageUnsubscribePublishedFileResult_t
	{
		[Token(Token = "0x4000212")]
		public const int k_iCallback = 1315;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED028", Offset = "0x7ED028")]
	public struct RemoteStorageUpdatePublishedFileResult_t
	{
		[Token(Token = "0x4000215")]
		public const int k_iCallback = 1316;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED03C", Offset = "0x7ED03C")]
	public struct RemoteStorageDownloadUGCResult_t
	{
		[Token(Token = "0x4000219")]
		public const int k_iCallback = 1317;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AppId_t m_nAppID;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nSizeInBytes;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_pchFileName;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ulong m_ulSteamIDOwner;
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED050", Offset = "0x7ED050")]
	public struct RemoteStorageGetPublishedFileDetailsResult_t
	{
		[Token(Token = "0x4000220")]
		public const int k_iCallback = 1318;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AppId_t m_nCreatorAppID;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AppId_t m_nConsumerAppID;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_rgchTitle;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_rgchDescription;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UGCHandle_t m_hPreviewFile;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ulong m_ulSteamIDOwner;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public uint m_rtimeCreated;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint m_rtimeUpdated;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool m_bBanned;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string m_rgchTags;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool m_bTagsTruncated;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string m_pchFileName;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int m_nFileSize;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int m_nPreviewFileSize;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string m_rgchURL;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public EWorkshopFileType m_eFileType;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool m_bAcceptedForUse;
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED064", Offset = "0x7ED064")]
	public struct RemoteStorageEnumerateWorkshopFilesResult_t
	{
		[Token(Token = "0x4000236")]
		public const int k_iCallback = 1319;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] m_rgScore;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AppId_t m_nAppId;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint m_unStartIndex;
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED078", Offset = "0x7ED078")]
	public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
	{
		[Token(Token = "0x400023E")]
		public const int k_iCallback = 1320;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_unPublishedFileId;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nVotesFor;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nVotesAgainst;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nReports;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m_fScore;
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED08C", Offset = "0x7ED08C")]
	public struct RemoteStoragePublishedFileSubscribed_t
	{
		[Token(Token = "0x4000245")]
		public const int k_iCallback = 1321;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED0A0", Offset = "0x7ED0A0")]
	public struct RemoteStoragePublishedFileUnsubscribed_t
	{
		[Token(Token = "0x4000248")]
		public const int k_iCallback = 1322;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED0B4", Offset = "0x7ED0B4")]
	public struct RemoteStoragePublishedFileDeleted_t
	{
		[Token(Token = "0x400024B")]
		public const int k_iCallback = 1323;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED0C8", Offset = "0x7ED0C8")]
	public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
	{
		[Token(Token = "0x400024E")]
		public const int k_iCallback = 1324;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED0DC", Offset = "0x7ED0DC")]
	public struct RemoteStorageUserVoteDetails_t
	{
		[Token(Token = "0x4000251")]
		public const int k_iCallback = 1325;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EWorkshopVote m_eVote;
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED0F0", Offset = "0x7ED0F0")]
	public struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t
	{
		[Token(Token = "0x4000255")]
		public const int k_iCallback = 1326;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED104", Offset = "0x7ED104")]
	public struct RemoteStorageSetUserPublishedFileActionResult_t
	{
		[Token(Token = "0x400025A")]
		public const int k_iCallback = 1327;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EWorkshopFileAction m_eAction;
	}
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED118", Offset = "0x7ED118")]
	public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
	{
		[Token(Token = "0x400025E")]
		public const int k_iCallback = 1328;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EWorkshopFileAction m_eAction;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nResultsReturned;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nTotalResultCount;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint[] m_rgRTimeUpdated;
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED12C", Offset = "0x7ED12C")]
	public struct RemoteStoragePublishFileProgress_t
	{
		[Token(Token = "0x4000265")]
		public const int k_iCallback = 1329;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double m_dPercentFile;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool m_bPreview;
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED140", Offset = "0x7ED140")]
	public struct RemoteStoragePublishedFileUpdated_t
	{
		[Token(Token = "0x4000268")]
		public const int k_iCallback = 1330;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UGCHandle_t m_hFile;
	}
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED154", Offset = "0x7ED154")]
	public struct ScreenshotReady_t
	{
		[Token(Token = "0x400026C")]
		public const int k_iCallback = 2301;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ScreenshotHandle m_hLocal;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED168", Offset = "0x7ED168")]
	public struct ScreenshotRequested_t
	{
		[Token(Token = "0x400026F")]
		public const int k_iCallback = 2302;
	}
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED17C", Offset = "0x7ED17C")]
	public struct SteamUGCQueryCompleted_t
	{
		[Token(Token = "0x4000270")]
		public const int k_iCallback = 3401;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UGCQueryHandle_t m_handle;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_unNumResultsReturned;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_unTotalMatchingResults;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool m_bCachedData;
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED190", Offset = "0x7ED190")]
	public struct SteamUGCRequestUGCDetailsResult_t
	{
		[Token(Token = "0x4000276")]
		public const int k_iCallback = 3402;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamUGCDetails_t m_details;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool m_bCachedData;
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED1A4", Offset = "0x7ED1A4")]
	public struct CreateItemResult_t
	{
		[Token(Token = "0x4000279")]
		public const int k_iCallback = 3403;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED1B8", Offset = "0x7ED1B8")]
	public struct SubmitItemUpdateResult_t
	{
		[Token(Token = "0x400027D")]
		public const int k_iCallback = 3404;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED1CC", Offset = "0x7ED1CC")]
	public struct ItemInstalled_t
	{
		[Token(Token = "0x4000280")]
		public const int k_iCallback = 3405;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED1E0", Offset = "0x7ED1E0")]
	public struct DownloadItemResult_t
	{
		[Token(Token = "0x4000283")]
		public const int k_iCallback = 3406;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED1F4", Offset = "0x7ED1F4")]
	public struct UserFavoriteItemsListChanged_t
	{
		[Token(Token = "0x4000287")]
		public const int k_iCallback = 3407;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bWasAddRequest;
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED208", Offset = "0x7ED208")]
	public struct SetUserItemVoteResult_t
	{
		[Token(Token = "0x400028B")]
		public const int k_iCallback = 3408;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bVoteUp;
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED21C", Offset = "0x7ED21C")]
	public struct GetUserItemVoteResult_t
	{
		[Token(Token = "0x400028F")]
		public const int k_iCallback = 3409;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bVotedUp;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool m_bVotedDown;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool m_bVoteSkipped;
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED230", Offset = "0x7ED230")]
	public struct SteamUnifiedMessagesSendMethodResult_t
	{
		[Token(Token = "0x4000295")]
		public const int k_iCallback = 2501;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ClientUnifiedMessageHandle m_hHandle;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_unContext;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EResult m_eResult;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_unResponseSize;
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED244", Offset = "0x7ED244")]
	public struct SteamServersConnected_t
	{
		[Token(Token = "0x400029A")]
		public const int k_iCallback = 101;
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED258", Offset = "0x7ED258")]
	public struct SteamServerConnectFailure_t
	{
		[Token(Token = "0x400029B")]
		public const int k_iCallback = 102;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED26C", Offset = "0x7ED26C")]
	public struct SteamServersDisconnected_t
	{
		[Token(Token = "0x400029D")]
		public const int k_iCallback = 103;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000B4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED280", Offset = "0x7ED280")]
	public struct ClientGameServerDeny_t
	{
		[Token(Token = "0x400029F")]
		public const int k_iCallback = 113;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_uAppID;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unGameServerIP;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort m_usGameServerPort;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort m_bSecure;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_uReason;
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED294", Offset = "0x7ED294")]
	public struct IPCFailure_t
	{
		[Token(Token = "0x40002A5")]
		public const int k_iCallback = 117;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_eFailureType;
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED2A8", Offset = "0x7ED2A8")]
	public struct LicensesUpdated_t
	{
		[Token(Token = "0x40002A7")]
		public const int k_iCallback = 125;
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED2BC", Offset = "0x7ED2BC")]
	public struct ValidateAuthTicketResponse_t
	{
		[Token(Token = "0x40002A8")]
		public const int k_iCallback = 143;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EAuthSessionResponse m_eAuthSessionResponse;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CSteamID m_OwnerSteamID;
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED2D0", Offset = "0x7ED2D0")]
	public struct MicroTxnAuthorizationResponse_t
	{
		[Token(Token = "0x40002AC")]
		public const int k_iCallback = 152;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_unAppID;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulOrderID;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_bAuthorized;
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED2E4", Offset = "0x7ED2E4")]
	public struct EncryptedAppTicketResponse_t
	{
		[Token(Token = "0x40002B0")]
		public const int k_iCallback = 154;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED2F8", Offset = "0x7ED2F8")]
	public struct GetAuthSessionTicketResponse_t
	{
		[Token(Token = "0x40002B2")]
		public const int k_iCallback = 163;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HAuthTicket m_hAuthTicket;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED30C", Offset = "0x7ED30C")]
	public struct GameWebCallback_t
	{
		[Token(Token = "0x40002B5")]
		public const int k_iCallback = 164;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_szURL;
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED320", Offset = "0x7ED320")]
	public struct StoreAuthURLResponse_t
	{
		[Token(Token = "0x40002B7")]
		public const int k_iCallback = 165;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_szURL;
	}
	[StructLayout(2)]
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED334", Offset = "0x7ED334")]
	public struct UserStatsReceived_t
	{
		[Token(Token = "0x40002B9")]
		public const int k_iCallback = 1101;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED348", Offset = "0x7ED348")]
	public struct UserStatsStored_t
	{
		[Token(Token = "0x40002BD")]
		public const int k_iCallback = 1102;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED35C", Offset = "0x7ED35C")]
	public struct UserAchievementStored_t
	{
		[Token(Token = "0x40002C0")]
		public const int k_iCallback = 1103;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool m_bGroupAchievement;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_rgchAchievementName;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_nCurProgress;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint m_nMaxProgress;
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED370", Offset = "0x7ED370")]
	public struct LeaderboardFindResult_t
	{
		[Token(Token = "0x40002C6")]
		public const int k_iCallback = 1104;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte m_bLeaderboardFound;
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED384", Offset = "0x7ED384")]
	public struct LeaderboardScoresDownloaded_t
	{
		[Token(Token = "0x40002C9")]
		public const int k_iCallback = 1105;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_cEntryCount;
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED398", Offset = "0x7ED398")]
	public struct LeaderboardScoreUploaded_t
	{
		[Token(Token = "0x40002CD")]
		public const int k_iCallback = 1106;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bSuccess;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nScore;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public byte m_bScoreChanged;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nGlobalRankNew;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_nGlobalRankPrevious;
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED3AC", Offset = "0x7ED3AC")]
	public struct NumberOfCurrentPlayers_t
	{
		[Token(Token = "0x40002D4")]
		public const int k_iCallback = 1107;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bSuccess;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_cPlayers;
	}
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED3C0", Offset = "0x7ED3C0")]
	public struct UserStatsUnloaded_t
	{
		[Token(Token = "0x40002D7")]
		public const int k_iCallback = 1108;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED3D4", Offset = "0x7ED3D4")]
	public struct UserAchievementIconFetched_t
	{
		[Token(Token = "0x40002D9")]
		public const int k_iCallback = 1109;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CGameID m_nGameID;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchAchievementName;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bAchieved;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nIconHandle;
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED3E8", Offset = "0x7ED3E8")]
	public struct GlobalAchievementPercentagesReady_t
	{
		[Token(Token = "0x40002DE")]
		public const int k_iCallback = 1110;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED3FC", Offset = "0x7ED3FC")]
	public struct LeaderboardUGCSet_t
	{
		[Token(Token = "0x40002E1")]
		public const int k_iCallback = 1111;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamLeaderboard_t m_hSteamLeaderboard;
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED410", Offset = "0x7ED410")]
	public struct GlobalStatsReceived_t
	{
		[Token(Token = "0x40002E4")]
		public const int k_iCallback = 1112;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED424", Offset = "0x7ED424")]
	public struct IPCountry_t
	{
		[Token(Token = "0x40002E7")]
		public const int k_iCallback = 701;
	}
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED438", Offset = "0x7ED438")]
	public struct LowBatteryPower_t
	{
		[Token(Token = "0x40002E8")]
		public const int k_iCallback = 702;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_nMinutesBatteryLeft;
	}
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED44C", Offset = "0x7ED44C")]
	public struct SteamAPICallCompleted_t
	{
		[Token(Token = "0x40002EA")]
		public const int k_iCallback = 703;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamAPICall_t m_hAsyncCall;
	}
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED460", Offset = "0x7ED460")]
	public struct SteamShutdown_t
	{
		[Token(Token = "0x40002EC")]
		public const int k_iCallback = 704;
	}
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED474", Offset = "0x7ED474")]
	public struct CheckFileSignature_t
	{
		[Token(Token = "0x40002ED")]
		public const int k_iCallback = 705;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ECheckFileSignature m_eCheckFileSignature;
	}
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED488", Offset = "0x7ED488")]
	public struct GamepadTextInputDismissed_t
	{
		[Token(Token = "0x40002EF")]
		public const int k_iCallback = 714;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bSubmitted;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unSubmittedText;
	}
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED49C", Offset = "0x7ED49C")]
	public struct BroadcastUploadStart_t
	{
		[Token(Token = "0x40002F2")]
		public const int k_iCallback = 4604;
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED4B0", Offset = "0x7ED4B0")]
	public struct BroadcastUploadStop_t
	{
		[Token(Token = "0x40002F3")]
		public const int k_iCallback = 4605;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EBroadcastUploadResult m_eResult;
	}
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x7ED4C4", Offset = "0x7ED4C4")]
	public struct GetVideoURLResult_t
	{
		[Token(Token = "0x40002F5")]
		public const int k_iCallback = 4611;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public AppId_t m_unVideoAppID;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchURL;
	}
	[Token(Token = "0x20000D2")]
	public static class Constants
	{
		[Token(Token = "0x40002F9")]
		public const string STEAMAPPLIST_INTERFACE_VERSION = "STEAMAPPLIST_INTERFACE_VERSION001";

		[Token(Token = "0x40002FA")]
		public const string STEAMAPPS_INTERFACE_VERSION = "STEAMAPPS_INTERFACE_VERSION007";

		[Token(Token = "0x40002FB")]
		public const string STEAMAPPTICKET_INTERFACE_VERSION = "STEAMAPPTICKET_INTERFACE_VERSION001";

		[Token(Token = "0x40002FC")]
		public const string STEAMCLIENT_INTERFACE_VERSION = "SteamClient017";

		[Token(Token = "0x40002FD")]
		public const string STEAMCONTROLLER_INTERFACE_VERSION = "STEAMCONTROLLER_INTERFACE_VERSION";

		[Token(Token = "0x40002FE")]
		public const string STEAMFRIENDS_INTERFACE_VERSION = "SteamFriends015";

		[Token(Token = "0x40002FF")]
		public const string STEAMGAMECOORDINATOR_INTERFACE_VERSION = "SteamGameCoordinator001";

		[Token(Token = "0x4000300")]
		public const string STEAMGAMESERVER_INTERFACE_VERSION = "SteamGameServer012";

		[Token(Token = "0x4000301")]
		public const string STEAMGAMESERVERSTATS_INTERFACE_VERSION = "SteamGameServerStats001";

		[Token(Token = "0x4000302")]
		public const string STEAMHTMLSURFACE_INTERFACE_VERSION = "STEAMHTMLSURFACE_INTERFACE_VERSION_003";

		[Token(Token = "0x4000303")]
		public const string STEAMHTTP_INTERFACE_VERSION = "STEAMHTTP_INTERFACE_VERSION002";

		[Token(Token = "0x4000304")]
		public const string STEAMINVENTORY_INTERFACE_VERSION = "STEAMINVENTORY_INTERFACE_V001";

		[Token(Token = "0x4000305")]
		public const string STEAMMATCHMAKING_INTERFACE_VERSION = "SteamMatchMaking009";

		[Token(Token = "0x4000306")]
		public const string STEAMMATCHMAKINGSERVERS_INTERFACE_VERSION = "SteamMatchMakingServers002";

		[Token(Token = "0x4000307")]
		public const string STEAMMUSIC_INTERFACE_VERSION = "STEAMMUSIC_INTERFACE_VERSION001";

		[Token(Token = "0x4000308")]
		public const string STEAMMUSICREMOTE_INTERFACE_VERSION = "STEAMMUSICREMOTE_INTERFACE_VERSION001";

		[Token(Token = "0x4000309")]
		public const string STEAMNETWORKING_INTERFACE_VERSION = "SteamNetworking005";

		[Token(Token = "0x400030A")]
		public const string STEAMREMOTESTORAGE_INTERFACE_VERSION = "STEAMREMOTESTORAGE_INTERFACE_VERSION012";

		[Token(Token = "0x400030B")]
		public const string STEAMSCREENSHOTS_INTERFACE_VERSION = "STEAMSCREENSHOTS_INTERFACE_VERSION002";

		[Token(Token = "0x400030C")]
		public const string STEAMUGC_INTERFACE_VERSION = "STEAMUGC_INTERFACE_VERSION007";

		[Token(Token = "0x400030D")]
		public const string STEAMUNIFIEDMESSAGES_INTERFACE_VERSION = "STEAMUNIFIEDMESSAGES_INTERFACE_VERSION001";

		[Token(Token = "0x400030E")]
		public const string STEAMUSER_INTERFACE_VERSION = "SteamUser018";

		[Token(Token = "0x400030F")]
		public const string STEAMUSERSTATS_INTERFACE_VERSION = "STEAMUSERSTATS_INTERFACE_VERSION011";

		[Token(Token = "0x4000310")]
		public const string STEAMUTILS_INTERFACE_VERSION = "SteamUtils007";

		[Token(Token = "0x4000311")]
		public const string STEAMVIDEO_INTERFACE_VERSION = "STEAMVIDEO_INTERFACE_V001";

		[Token(Token = "0x4000312")]
		public const int k_cubAppProofOfPurchaseKeyMax = 64;

		[Token(Token = "0x4000313")]
		public const int k_iSteamUserCallbacks = 100;

		[Token(Token = "0x4000314")]
		public const int k_iSteamGameServerCallbacks = 200;

		[Token(Token = "0x4000315")]
		public const int k_iSteamFriendsCallbacks = 300;

		[Token(Token = "0x4000316")]
		public const int k_iSteamBillingCallbacks = 400;

		[Token(Token = "0x4000317")]
		public const int k_iSteamMatchmakingCallbacks = 500;

		[Token(Token = "0x4000318")]
		public const int k_iSteamContentServerCallbacks = 600;

		[Token(Token = "0x4000319")]
		public const int k_iSteamUtilsCallbacks = 700;

		[Token(Token = "0x400031A")]
		public const int k_iClientFriendsCallbacks = 800;

		[Token(Token = "0x400031B")]
		public const int k_iClientUserCallbacks = 900;

		[Token(Token = "0x400031C")]
		public const int k_iSteamAppsCallbacks = 1000;

		[Token(Token = "0x400031D")]
		public const int k_iSteamUserStatsCallbacks = 1100;

		[Token(Token = "0x400031E")]
		public const int k_iSteamNetworkingCallbacks = 1200;

		[Token(Token = "0x400031F")]
		public const int k_iClientRemoteStorageCallbacks = 1300;

		[Token(Token = "0x4000320")]
		public const int k_iClientDepotBuilderCallbacks = 1400;

		[Token(Token = "0x4000321")]
		public const int k_iSteamGameServerItemsCallbacks = 1500;

		[Token(Token = "0x4000322")]
		public const int k_iClientUtilsCallbacks = 1600;

		[Token(Token = "0x4000323")]
		public const int k_iSteamGameCoordinatorCallbacks = 1700;

		[Token(Token = "0x4000324")]
		public const int k_iSteamGameServerStatsCallbacks = 1800;

		[Token(Token = "0x4000325")]
		public const int k_iSteam2AsyncCallbacks = 1900;

		[Token(Token = "0x4000326")]
		public const int k_iSteamGameStatsCallbacks = 2000;

		[Token(Token = "0x4000327")]
		public const int k_iClientHTTPCallbacks = 2100;

		[Token(Token = "0x4000328")]
		public const int k_iClientScreenshotsCallbacks = 2200;

		[Token(Token = "0x4000329")]
		public const int k_iSteamScreenshotsCallbacks = 2300;

		[Token(Token = "0x400032A")]
		public const int k_iClientAudioCallbacks = 2400;

		[Token(Token = "0x400032B")]
		public const int k_iClientUnifiedMessagesCallbacks = 2500;

		[Token(Token = "0x400032C")]
		public const int k_iSteamStreamLauncherCallbacks = 2600;

		[Token(Token = "0x400032D")]
		public const int k_iClientControllerCallbacks = 2700;

		[Token(Token = "0x400032E")]
		public const int k_iSteamControllerCallbacks = 2800;

		[Token(Token = "0x400032F")]
		public const int k_iClientParentalSettingsCallbacks = 2900;

		[Token(Token = "0x4000330")]
		public const int k_iClientDeviceAuthCallbacks = 3000;

		[Token(Token = "0x4000331")]
		public const int k_iClientNetworkDeviceManagerCallbacks = 3100;

		[Token(Token = "0x4000332")]
		public const int k_iClientMusicCallbacks = 3200;

		[Token(Token = "0x4000333")]
		public const int k_iClientRemoteClientManagerCallbacks = 3300;

		[Token(Token = "0x4000334")]
		public const int k_iClientUGCCallbacks = 3400;

		[Token(Token = "0x4000335")]
		public const int k_iSteamStreamClientCallbacks = 3500;

		[Token(Token = "0x4000336")]
		public const int k_IClientProductBuilderCallbacks = 3600;

		[Token(Token = "0x4000337")]
		public const int k_iClientShortcutsCallbacks = 3700;

		[Token(Token = "0x4000338")]
		public const int k_iClientRemoteControlManagerCallbacks = 3800;

		[Token(Token = "0x4000339")]
		public const int k_iSteamAppListCallbacks = 3900;

		[Token(Token = "0x400033A")]
		public const int k_iSteamMusicCallbacks = 4000;

		[Token(Token = "0x400033B")]
		public const int k_iSteamMusicRemoteCallbacks = 4100;

		[Token(Token = "0x400033C")]
		public const int k_iClientVRCallbacks = 4200;

		[Token(Token = "0x400033D")]
		public const int k_iClientReservedCallbacks = 4300;

		[Token(Token = "0x400033E")]
		public const int k_iSteamReservedCallbacks = 4400;

		[Token(Token = "0x400033F")]
		public const int k_iSteamHTMLSurfaceCallbacks = 4500;

		[Token(Token = "0x4000340")]
		public const int k_iClientVideoCallbacks = 4600;

		[Token(Token = "0x4000341")]
		public const int k_iClientInventoryCallbacks = 4700;

		[Token(Token = "0x4000342")]
		public const int k_cchMaxFriendsGroupName = 64;

		[Token(Token = "0x4000343")]
		public const int k_cFriendsGroupLimit = 100;

		[Token(Token = "0x4000344")]
		public const int k_cEnumerateFollowersMax = 50;

		[Token(Token = "0x4000345")]
		public const int k_cchPersonaNameMax = 128;

		[Token(Token = "0x4000346")]
		public const int k_cwchPersonaNameMax = 32;

		[Token(Token = "0x4000347")]
		public const int k_cubChatMetadataMax = 8192;

		[Token(Token = "0x4000348")]
		public const int k_cchMaxRichPresenceKeys = 20;

		[Token(Token = "0x4000349")]
		public const int k_cchMaxRichPresenceKeyLength = 64;

		[Token(Token = "0x400034A")]
		public const int k_cchMaxRichPresenceValueLength = 256;

		[Token(Token = "0x400034B")]
		public const int k_unServerFlagNone = 0;

		[Token(Token = "0x400034C")]
		public const int k_unServerFlagActive = 1;

		[Token(Token = "0x400034D")]
		public const int k_unServerFlagSecure = 2;

		[Token(Token = "0x400034E")]
		public const int k_unServerFlagDedicated = 4;

		[Token(Token = "0x400034F")]
		public const int k_unServerFlagLinux = 8;

		[Token(Token = "0x4000350")]
		public const int k_unServerFlagPassworded = 16;

		[Token(Token = "0x4000351")]
		public const int k_unServerFlagPrivate = 32;

		[Token(Token = "0x4000352")]
		public const int k_unFavoriteFlagNone = 0;

		[Token(Token = "0x4000353")]
		public const int k_unFavoriteFlagFavorite = 1;

		[Token(Token = "0x4000354")]
		public const int k_unFavoriteFlagHistory = 2;

		[Token(Token = "0x4000355")]
		public const int k_unMaxCloudFileChunkSize = 104857600;

		[Token(Token = "0x4000356")]
		public const int k_cchPublishedDocumentTitleMax = 129;

		[Token(Token = "0x4000357")]
		public const int k_cchPublishedDocumentDescriptionMax = 8000;

		[Token(Token = "0x4000358")]
		public const int k_cchPublishedDocumentChangeDescriptionMax = 8000;

		[Token(Token = "0x4000359")]
		public const int k_unEnumeratePublishedFilesMaxResults = 50;

		[Token(Token = "0x400035A")]
		public const int k_cchTagListMax = 1025;

		[Token(Token = "0x400035B")]
		public const int k_cchFilenameMax = 260;

		[Token(Token = "0x400035C")]
		public const int k_cchPublishedFileURLMax = 256;

		[Token(Token = "0x400035D")]
		public const int k_nScreenshotMaxTaggedUsers = 32;

		[Token(Token = "0x400035E")]
		public const int k_nScreenshotMaxTaggedPublishedFiles = 32;

		[Token(Token = "0x400035F")]
		public const int k_cubUFSTagTypeMax = 255;

		[Token(Token = "0x4000360")]
		public const int k_cubUFSTagValueMax = 255;

		[Token(Token = "0x4000361")]
		public const int k_ScreenshotThumbWidth = 200;

		[Token(Token = "0x4000362")]
		public const int kNumUGCResultsPerPage = 50;

		[Token(Token = "0x4000363")]
		public const int k_cchDeveloperMetadataMax = 5000;

		[Token(Token = "0x4000364")]
		public const int k_cchStatNameMax = 128;

		[Token(Token = "0x4000365")]
		public const int k_cchLeaderboardNameMax = 128;

		[Token(Token = "0x4000366")]
		public const int k_cLeaderboardDetailsMax = 64;

		[Token(Token = "0x4000367")]
		public const int k_cbMaxGameServerGameDir = 32;

		[Token(Token = "0x4000368")]
		public const int k_cbMaxGameServerMapName = 32;

		[Token(Token = "0x4000369")]
		public const int k_cbMaxGameServerGameDescription = 64;

		[Token(Token = "0x400036A")]
		public const int k_cbMaxGameServerName = 64;

		[Token(Token = "0x400036B")]
		public const int k_cbMaxGameServerTags = 128;

		[Token(Token = "0x400036C")]
		public const int k_cbMaxGameServerGameData = 2048;

		[Token(Token = "0x400036D")]
		public const int k_unSteamAccountIDMask = -1;

		[Token(Token = "0x400036E")]
		public const int k_unSteamAccountInstanceMask = 1048575;

		[Token(Token = "0x400036F")]
		public const int k_unSteamUserDesktopInstance = 1;

		[Token(Token = "0x4000370")]
		public const int k_unSteamUserConsoleInstance = 2;

		[Token(Token = "0x4000371")]
		public const int k_unSteamUserWebInstance = 4;

		[Token(Token = "0x4000372")]
		public const int k_cchGameExtraInfoMax = 64;

		[Token(Token = "0x4000373")]
		public const int k_nSteamEncryptedAppTicketSymmetricKeyLen = 32;

		[Token(Token = "0x4000374")]
		public const int k_cubSaltSize = 8;

		[Token(Token = "0x4000375")]
		public const ulong k_GIDNil = ulong.MaxValue;

		[Token(Token = "0x4000376")]
		public const ulong k_TxnIDNil = ulong.MaxValue;

		[Token(Token = "0x4000377")]
		public const ulong k_TxnIDUnknown = 0uL;

		[Token(Token = "0x4000378")]
		public const int k_uPackageIdFreeSub = 0;

		[Token(Token = "0x4000379")]
		public const int k_uPackageIdInvalid = -1;

		[Token(Token = "0x400037A")]
		public const ulong k_ulAssetClassIdInvalid = 0uL;

		[Token(Token = "0x400037B")]
		public const int k_uPhysicalItemIdInvalid = 0;

		[Token(Token = "0x400037C")]
		public const int k_uCellIDInvalid = -1;

		[Token(Token = "0x400037D")]
		public const int k_uPartnerIdInvalid = 0;

		[Token(Token = "0x400037E")]
		public const int MAX_STEAM_CONTROLLERS = 16;

		[Token(Token = "0x400037F")]
		public const int STEAM_RIGHT_TRIGGER_MASK = 1;

		[Token(Token = "0x4000380")]
		public const int STEAM_LEFT_TRIGGER_MASK = 2;

		[Token(Token = "0x4000381")]
		public const int STEAM_RIGHT_BUMPER_MASK = 4;

		[Token(Token = "0x4000382")]
		public const int STEAM_LEFT_BUMPER_MASK = 8;

		[Token(Token = "0x4000383")]
		public const int STEAM_BUTTON_0_MASK = 16;

		[Token(Token = "0x4000384")]
		public const int STEAM_BUTTON_1_MASK = 32;

		[Token(Token = "0x4000385")]
		public const int STEAM_BUTTON_2_MASK = 64;

		[Token(Token = "0x4000386")]
		public const int STEAM_BUTTON_3_MASK = 128;

		[Token(Token = "0x4000387")]
		public const int STEAM_TOUCH_0_MASK = 256;

		[Token(Token = "0x4000388")]
		public const int STEAM_TOUCH_1_MASK = 512;

		[Token(Token = "0x4000389")]
		public const int STEAM_TOUCH_2_MASK = 1024;

		[Token(Token = "0x400038A")]
		public const int STEAM_TOUCH_3_MASK = 2048;

		[Token(Token = "0x400038B")]
		public const int STEAM_BUTTON_MENU_MASK = 4096;

		[Token(Token = "0x400038C")]
		public const int STEAM_BUTTON_STEAM_MASK = 8192;

		[Token(Token = "0x400038D")]
		public const int STEAM_BUTTON_ESCAPE_MASK = 16384;

		[Token(Token = "0x400038E")]
		public const int STEAM_BUTTON_BACK_LEFT_MASK = 32768;

		[Token(Token = "0x400038F")]
		public const int STEAM_BUTTON_BACK_RIGHT_MASK = 65536;

		[Token(Token = "0x4000390")]
		public const int STEAM_BUTTON_LEFTPAD_CLICKED_MASK = 131072;

		[Token(Token = "0x4000391")]
		public const int STEAM_BUTTON_RIGHTPAD_CLICKED_MASK = 262144;

		[Token(Token = "0x4000392")]
		public const int STEAM_LEFTPAD_FINGERDOWN_MASK = 524288;

		[Token(Token = "0x4000393")]
		public const int STEAM_RIGHTPAD_FINGERDOWN_MASK = 1048576;

		[Token(Token = "0x4000394")]
		public const int STEAM_JOYSTICK_BUTTON_MASK = 4194304;

		[Token(Token = "0x4000395")]
		public const short MASTERSERVERUPDATERPORT_USEGAMESOCKETSHARE = -1;

		[Token(Token = "0x4000396")]
		public const int INVALID_HTTPREQUEST_HANDLE = 0;

		[Token(Token = "0x4000397")]
		public const byte k_nMaxLobbyKeyLength = byte.MaxValue;

		[Token(Token = "0x4000398")]
		public const int k_SteamMusicNameMaxLength = 255;

		[Token(Token = "0x4000399")]
		public const int k_SteamMusicPNGMaxLength = 65535;

		[Token(Token = "0x400039A")]
		public const int QUERY_PORT_NOT_INITIALIZED = 65535;

		[Token(Token = "0x400039B")]
		public const int QUERY_PORT_ERROR = 65534;
	}
	[Token(Token = "0x20000D3")]
	public enum ERegisterActivationCodeResult
	{
		[Token(Token = "0x400039D")]
		k_ERegisterActivationCodeResultOK,
		[Token(Token = "0x400039E")]
		k_ERegisterActivationCodeResultFail,
		[Token(Token = "0x400039F")]
		k_ERegisterActivationCodeResultAlreadyRegistered,
		[Token(Token = "0x40003A0")]
		k_ERegisterActivationCodeResultTimeout,
		[Token(Token = "0x40003A1")]
		k_ERegisterActivationCodeAlreadyOwned
	}
	[Token(Token = "0x20000D4")]
	public enum ESteamControllerPad
	{
		[Token(Token = "0x40003A3")]
		k_ESteamControllerPad_Left,
		[Token(Token = "0x40003A4")]
		k_ESteamControllerPad_Right
	}
	[Token(Token = "0x20000D5")]
	public enum EFriendRelationship
	{
		[Token(Token = "0x40003A6")]
		k_EFriendRelationshipNone,
		[Token(Token = "0x40003A7")]
		k_EFriendRelationshipBlocked,
		[Token(Token = "0x40003A8")]
		k_EFriendRelationshipRequestRecipient,
		[Token(Token = "0x40003A9")]
		k_EFriendRelationshipFriend,
		[Token(Token = "0x40003AA")]
		k_EFriendRelationshipRequestInitiator,
		[Token(Token = "0x40003AB")]
		k_EFriendRelationshipIgnored,
		[Token(Token = "0x40003AC")]
		k_EFriendRelationshipIgnoredFriend,
		[Token(Token = "0x40003AD")]
		k_EFriendRelationshipSuggested,
		[Token(Token = "0x40003AE")]
		k_EFriendRelationshipMax
	}
	[Token(Token = "0x20000D6")]
	public enum EPersonaState
	{
		[Token(Token = "0x40003B0")]
		k_EPersonaStateOffline,
		[Token(Token = "0x40003B1")]
		k_EPersonaStateOnline,
		[Token(Token = "0x40003B2")]
		k_EPersonaStateBusy,
		[Token(Token = "0x40003B3")]
		k_EPersonaStateAway,
		[Token(Token = "0x40003B4")]
		k_EPersonaStateSnooze,
		[Token(Token = "0x40003B5")]
		k_EPersonaStateLookingToTrade,
		[Token(Token = "0x40003B6")]
		k_EPersonaStateLookingToPlay,
		[Token(Token = "0x40003B7")]
		k_EPersonaStateMax
	}
	[Token(Token = "0x20000D7")]
	[Flags]
	public enum EFriendFlags
	{
		[Token(Token = "0x40003B9")]
		k_EFriendFlagNone = 0,
		[Token(Token = "0x40003BA")]
		k_EFriendFlagBlocked = 1,
		[Token(Token = "0x40003BB")]
		k_EFriendFlagFriendshipRequested = 2,
		[Token(Token = "0x40003BC")]
		k_EFriendFlagImmediate = 4,
		[Token(Token = "0x40003BD")]
		k_EFriendFlagClanMember = 8,
		[Token(Token = "0x40003BE")]
		k_EFriendFlagOnGameServer = 0x10,
		[Token(Token = "0x40003BF")]
		k_EFriendFlagRequestingFriendship = 0x80,
		[Token(Token = "0x40003C0")]
		k_EFriendFlagRequestingInfo = 0x100,
		[Token(Token = "0x40003C1")]
		k_EFriendFlagIgnored = 0x200,
		[Token(Token = "0x40003C2")]
		k_EFriendFlagIgnoredFriend = 0x400,
		[Token(Token = "0x40003C3")]
		k_EFriendFlagSuggested = 0x800,
		[Token(Token = "0x40003C4")]
		k_EFriendFlagAll = 0xFFFF
	}
	[Token(Token = "0x20000D8")]
	public enum EUserRestriction
	{
		[Token(Token = "0x40003C6")]
		k_nUserRestrictionNone = 0,
		[Token(Token = "0x40003C7")]
		k_nUserRestrictionUnknown = 1,
		[Token(Token = "0x40003C8")]
		k_nUserRestrictionAnyChat = 2,
		[Token(Token = "0x40003C9")]
		k_nUserRestrictionVoiceChat = 4,
		[Token(Token = "0x40003CA")]
		k_nUserRestrictionGroupChat = 8,
		[Token(Token = "0x40003CB")]
		k_nUserRestrictionRating = 0x10,
		[Token(Token = "0x40003CC")]
		k_nUserRestrictionGameInvites = 0x20,
		[Token(Token = "0x40003CD")]
		k_nUserRestrictionTrading = 0x40
	}
	[Token(Token = "0x20000D9")]
	public enum EOverlayToStoreFlag
	{
		[Token(Token = "0x40003CF")]
		k_EOverlayToStoreFlag_None,
		[Token(Token = "0x40003D0")]
		k_EOverlayToStoreFlag_AddToCart,
		[Token(Token = "0x40003D1")]
		k_EOverlayToStoreFlag_AddToCartAndShow
	}
	[Token(Token = "0x20000DA")]
	[Flags]
	public enum EPersonaChange
	{
		[Token(Token = "0x40003D3")]
		k_EPersonaChangeName = 1,
		[Token(Token = "0x40003D4")]
		k_EPersonaChangeStatus = 2,
		[Token(Token = "0x40003D5")]
		k_EPersonaChangeComeOnline = 4,
		[Token(Token = "0x40003D6")]
		k_EPersonaChangeGoneOffline = 8,
		[Token(Token = "0x40003D7")]
		k_EPersonaChangeGamePlayed = 0x10,
		[Token(Token = "0x40003D8")]
		k_EPersonaChangeGameServer = 0x20,
		[Token(Token = "0x40003D9")]
		k_EPersonaChangeAvatar = 0x40,
		[Token(Token = "0x40003DA")]
		k_EPersonaChangeJoinedSource = 0x80,
		[Token(Token = "0x40003DB")]
		k_EPersonaChangeLeftSource = 0x100,
		[Token(Token = "0x40003DC")]
		k_EPersonaChangeRelationshipChanged = 0x200,
		[Token(Token = "0x40003DD")]
		k_EPersonaChangeNameFirstSet = 0x400,
		[Token(Token = "0x40003DE")]
		k_EPersonaChangeFacebookInfo = 0x800,
		[Token(Token = "0x40003DF")]
		k_EPersonaChangeNickname = 0x1000,
		[Token(Token = "0x40003E0")]
		k_EPersonaChangeSteamLevel = 0x2000
	}
	[Token(Token = "0x20000DB")]
	public enum EGCResults
	{
		[Token(Token = "0x40003E2")]
		k_EGCResultOK,
		[Token(Token = "0x40003E3")]
		k_EGCResultNoMessage,
		[Token(Token = "0x40003E4")]
		k_EGCResultBufferTooSmall,
		[Token(Token = "0x40003E5")]
		k_EGCResultNotLoggedOn,
		[Token(Token = "0x40003E6")]
		k_EGCResultInvalidMessage
	}
	[Token(Token = "0x20000DC")]
	public enum EHTMLMouseButton
	{
		[Token(Token = "0x40003E8")]
		eHTMLMouseButton_Left,
		[Token(Token = "0x40003E9")]
		eHTMLMouseButton_Right,
		[Token(Token = "0x40003EA")]
		eHTMLMouseButton_Middle
	}
	[Token(Token = "0x20000DD")]
	public enum EMouseCursor
	{
		[Token(Token = "0x40003EC")]
		dc_user,
		[Token(Token = "0x40003ED")]
		dc_none,
		[Token(Token = "0x40003EE")]
		dc_arrow,
		[Token(Token = "0x40003EF")]
		dc_ibeam,
		[Token(Token = "0x40003F0")]
		dc_hourglass,
		[Token(Token = "0x40003F1")]
		dc_waitarrow,
		[Token(Token = "0x40003F2")]
		dc_crosshair,
		[Token(Token = "0x40003F3")]
		dc_up,
		[Token(Token = "0x40003F4")]
		dc_sizenw,
		[Token(Token = "0x40003F5")]
		dc_sizese,
		[Token(Token = "0x40003F6")]
		dc_sizene,
		[Token(Token = "0x40003F7")]
		dc_sizesw,
		[Token(Token = "0x40003F8")]
		dc_sizew,
		[Token(Token = "0x40003F9")]
		dc_sizee,
		[Token(Token = "0x40003FA")]
		dc_sizen,
		[Token(Token = "0x40003FB")]
		dc_sizes,
		[Token(Token = "0x40003FC")]
		dc_sizewe,
		[Token(Token = "0x40003FD")]
		dc_sizens,
		[Token(Token = "0x40003FE")]
		dc_sizeall,
		[Token(Token = "0x40003FF")]
		dc_no,
		[Token(Token = "0x4000400")]
		dc_hand,
		[Token(Token = "0x4000401")]
		dc_blank,
		[Token(Token = "0x4000402")]
		dc_middle_pan,
		[Token(Token = "0x4000403")]
		dc_north_pan,
		[Token(Token = "0x4000404")]
		dc_north_east_pan,
		[Token(Token = "0x4000405")]
		dc_east_pan,
		[Token(Token = "0x4000406")]
		dc_south_east_pan,
		[Token(Token = "0x4000407")]
		dc_south_pan,
		[Token(Token = "0x4000408")]
		dc_south_west_pan,
		[Token(Token = "0x4000409")]
		dc_west_pan,
		[Token(Token = "0x400040A")]
		dc_north_west_pan,
		[Token(Token = "0x400040B")]
		dc_alias,
		[Token(Token = "0x400040C")]
		dc_cell,
		[Token(Token = "0x400040D")]
		dc_colresize,
		[Token(Token = "0x400040E")]
		dc_copycur,
		[Token(Token = "0x400040F")]
		dc_verticaltext,
		[Token(Token = "0x4000410")]
		dc_rowresize,
		[Token(Token = "0x4000411")]
		dc_zoomin,
		[Token(Token = "0x4000412")]
		dc_zoomout,
		[Token(Token = "0x4000413")]
		dc_help,
		[Token(Token = "0x4000414")]
		dc_custom,
		[Token(Token = "0x4000415")]
		dc_last
	}
	[Token(Token = "0x20000DE")]
	[Flags]
	public enum EHTMLKeyModifiers
	{
		[Token(Token = "0x4000417")]
		k_eHTMLKeyModifier_None = 0,
		[Token(Token = "0x4000418")]
		k_eHTMLKeyModifier_AltDown = 1,
		[Token(Token = "0x4000419")]
		k_eHTMLKeyModifier_CtrlDown = 2,
		[Token(Token = "0x400041A")]
		k_eHTMLKeyModifier_ShiftDown = 4
	}
	[Token(Token = "0x20000DF")]
	[Flags]
	public enum ESteamItemFlags
	{
		[Token(Token = "0x400041C")]
		k_ESteamItemNoTrade = 1,
		[Token(Token = "0x400041D")]
		k_ESteamItemRemoved = 0x100,
		[Token(Token = "0x400041E")]
		k_ESteamItemConsumed = 0x200
	}
	[Token(Token = "0x20000E0")]
	public enum ELobbyType
	{
		[Token(Token = "0x4000420")]
		k_ELobbyTypePrivate,
		[Token(Token = "0x4000421")]
		k_ELobbyTypeFriendsOnly,
		[Token(Token = "0x4000422")]
		k_ELobbyTypePublic,
		[Token(Token = "0x4000423")]
		k_ELobbyTypeInvisible
	}
	[Token(Token = "0x20000E1")]
	public enum ELobbyComparison
	{
		[Token(Token = "0x4000425")]
		k_ELobbyComparisonEqualToOrLessThan = -2,
		[Token(Token = "0x4000426")]
		k_ELobbyComparisonLessThan,
		[Token(Token = "0x4000427")]
		k_ELobbyComparisonEqual,
		[Token(Token = "0x4000428")]
		k_ELobbyComparisonGreaterThan,
		[Token(Token = "0x4000429")]
		k_ELobbyComparisonEqualToOrGreaterThan,
		[Token(Token = "0x400042A")]
		k_ELobbyComparisonNotEqual
	}
	[Token(Token = "0x20000E2")]
	public enum ELobbyDistanceFilter
	{
		[Token(Token = "0x400042C")]
		k_ELobbyDistanceFilterClose,
		[Token(Token = "0x400042D")]
		k_ELobbyDistanceFilterDefault,
		[Token(Token = "0x400042E")]
		k_ELobbyDistanceFilterFar,
		[Token(Token = "0x400042F")]
		k_ELobbyDistanceFilterWorldwide
	}
	[Token(Token = "0x20000E3")]
	[Flags]
	public enum EChatMemberStateChange
	{
		[Token(Token = "0x4000431")]
		k_EChatMemberStateChangeEntered = 1,
		[Token(Token = "0x4000432")]
		k_EChatMemberStateChangeLeft = 2,
		[Token(Token = "0x4000433")]
		k_EChatMemberStateChangeDisconnected = 4,
		[Token(Token = "0x4000434")]
		k_EChatMemberStateChangeKicked = 8,
		[Token(Token = "0x4000435")]
		k_EChatMemberStateChangeBanned = 0x10
	}
	[Token(Token = "0x20000E4")]
	public enum AudioPlayback_Status
	{
		[Token(Token = "0x4000437")]
		AudioPlayback_Undefined,
		[Token(Token = "0x4000438")]
		AudioPlayback_Playing,
		[Token(Token = "0x4000439")]
		AudioPlayback_Paused,
		[Token(Token = "0x400043A")]
		AudioPlayback_Idle
	}
	[Token(Token = "0x20000E5")]
	public enum EP2PSessionError
	{
		[Token(Token = "0x400043C")]
		k_EP2PSessionErrorNone,
		[Token(Token = "0x400043D")]
		k_EP2PSessionErrorNotRunningApp,
		[Token(Token = "0x400043E")]
		k_EP2PSessionErrorNoRightsToApp,
		[Token(Token = "0x400043F")]
		k_EP2PSessionErrorDestinationNotLoggedIn,
		[Token(Token = "0x4000440")]
		k_EP2PSessionErrorTimeout,
		[Token(Token = "0x4000441")]
		k_EP2PSessionErrorMax
	}
	[Token(Token = "0x20000E6")]
	public enum EP2PSend
	{
		[Token(Token = "0x4000443")]
		k_EP2PSendUnreliable,
		[Token(Token = "0x4000444")]
		k_EP2PSendUnreliableNoDelay,
		[Token(Token = "0x4000445")]
		k_EP2PSendReliable,
		[Token(Token = "0x4000446")]
		k_EP2PSendReliableWithBuffering
	}
	[Token(Token = "0x20000E7")]
	public enum ESNetSocketState
	{
		[Token(Token = "0x4000448")]
		k_ESNetSocketStateInvalid = 0,
		[Token(Token = "0x4000449")]
		k_ESNetSocketStateConnected = 1,
		[Token(Token = "0x400044A")]
		k_ESNetSocketStateInitiated = 10,
		[Token(Token = "0x400044B")]
		k_ESNetSocketStateLocalCandidatesFound = 11,
		[Token(Token = "0x400044C")]
		k_ESNetSocketStateReceivedRemoteCandidates = 12,
		[Token(Token = "0x400044D")]
		k_ESNetSocketStateChallengeHandshake = 15,
		[Token(Token = "0x400044E")]
		k_ESNetSocketStateDisconnecting = 21,
		[Token(Token = "0x400044F")]
		k_ESNetSocketStateLocalDisconnect = 22,
		[Token(Token = "0x4000450")]
		k_ESNetSocketStateTimeoutDuringConnect = 23,
		[Token(Token = "0x4000451")]
		k_ESNetSocketStateRemoteEndDisconnected = 24,
		[Token(Token = "0x4000452")]
		k_ESNetSocketStateConnectionBroken = 25
	}
	[Token(Token = "0x20000E8")]
	public enum ESNetSocketConnectionType
	{
		[Token(Token = "0x4000454")]
		k_ESNetSocketConnectionTypeNotConnected,
		[Token(Token = "0x4000455")]
		k_ESNetSocketConnectionTypeUDP,
		[Token(Token = "0x4000456")]
		k_ESNetSocketConnectionTypeUDPRelay
	}
	[Token(Token = "0x20000E9")]
	public enum EResolveConflict
	{
		[Token(Token = "0x4000458")]
		k_EResolveConflictKeepClient = 1,
		[Token(Token = "0x4000459")]
		k_EResolveConflictKeepServer
	}
	[Token(Token = "0x20000EA")]
	[Flags]
	public enum ERemoteStoragePlatform
	{
		[Token(Token = "0x400045B")]
		k_ERemoteStoragePlatformNone = 0,
		[Token(Token = "0x400045C")]
		k_ERemoteStoragePlatformWindows = 1,
		[Token(Token = "0x400045D")]
		k_ERemoteStoragePlatformOSX = 2,
		[Token(Token = "0x400045E")]
		k_ERemoteStoragePlatformPS3 = 4,
		[Token(Token = "0x400045F")]
		k_ERemoteStoragePlatformLinux = 8,
		[Token(Token = "0x4000460")]
		k_ERemoteStoragePlatformReserved2 = 0x10,
		[Token(Token = "0x4000461")]
		k_ERemoteStoragePlatformAll = -1
	}
	[Token(Token = "0x20000EB")]
	public enum ERemoteStoragePublishedFileVisibility
	{
		[Token(Token = "0x4000463")]
		k_ERemoteStoragePublishedFileVisibilityPublic,
		[Token(Token = "0x4000464")]
		k_ERemoteStoragePublishedFileVisibilityFriendsOnly,
		[Token(Token = "0x4000465")]
		k_ERemoteStoragePublishedFileVisibilityPrivate
	}
	[Token(Token = "0x20000EC")]
	public enum EWorkshopFileType
	{
		[Token(Token = "0x4000467")]
		k_EWorkshopFileTypeFirst = 0,
		[Token(Token = "0x4000468")]
		k_EWorkshopFileTypeCommunity = 0,
		[Token(Token = "0x4000469")]
		k_EWorkshopFileTypeMicrotransaction = 1,
		[Token(Token = "0x400046A")]
		k_EWorkshopFileTypeCollection = 2,
		[Token(Token = "0x400046B")]
		k_EWorkshopFileTypeArt = 3,
		[Token(Token = "0x400046C")]
		k_EWorkshopFileTypeVideo = 4,
		[Token(Token = "0x400046D")]
		k_EWorkshopFileTypeScreenshot = 5,
		[Token(Token = "0x400046E")]
		k_EWorkshopFileTypeGame = 6,
		[Token(Token = "0x400046F")]
		k_EWorkshopFileTypeSoftware = 7,
		[Token(Token = "0x4000470")]
		k_EWorkshopFileTypeConcept = 8,
		[Token(Token = "0x4000471")]
		k_EWorkshopFileTypeWebGuide = 9,
		[Token(Token = "0x4000472")]
		k_EWorkshopFileTypeIntegratedGuide = 10,
		[Token(Token = "0x4000473")]
		k_EWorkshopFileTypeMerch = 11,
		[Token(Token = "0x4000474")]
		k_EWorkshopFileTypeControllerBinding = 12,
		[Token(Token = "0x4000475")]
		k_EWorkshopFileTypeSteamworksAccessInvite = 13,
		[Token(Token = "0x4000476")]
		k_EWorkshopFileTypeSteamVideo = 14,
		[Token(Token = "0x4000477")]
		k_EWorkshopFileTypeGameManagedItem = 15,
		[Token(Token = "0x4000478")]
		k_EWorkshopFileTypeMax = 16
	}
	[Token(Token = "0x20000ED")]
	public enum EWorkshopVote
	{
		[Token(Token = "0x400047A")]
		k_EWorkshopVoteUnvoted,
		[Token(Token = "0x400047B")]
		k_EWorkshopVoteFor,
		[Token(Token = "0x400047C")]
		k_EWorkshopVoteAgainst,
		[Token(Token = "0x400047D")]
		k_EWorkshopVoteLater
	}
	[Token(Token = "0x20000EE")]
	public enum EWorkshopFileAction
	{
		[Token(Token = "0x400047F")]
		k_EWorkshopFileActionPlayed,
		[Token(Token = "0x4000480")]
		k_EWorkshopFileActionCompleted
	}
	[Token(Token = "0x20000EF")]
	public enum EWorkshopEnumerationType
	{
		[Token(Token = "0x4000482")]
		k_EWorkshopEnumerationTypeRankedByVote,
		[Token(Token = "0x4000483")]
		k_EWorkshopEnumerationTypeRecent,
		[Token(Token = "0x4000484")]
		k_EWorkshopEnumerationTypeTrending,
		[Token(Token = "0x4000485")]
		k_EWorkshopEnumerationTypeFavoritesOfFriends,
		[Token(Token = "0x4000486")]
		k_EWorkshopEnumerationTypeVotedByFriends,
		[Token(Token = "0x4000487")]
		k_EWorkshopEnumerationTypeContentByFriends,
		[Token(Token = "0x4000488")]
		k_EWorkshopEnumerationTypeRecentFromFollowedUsers
	}
	[Token(Token = "0x20000F0")]
	public enum EWorkshopVideoProvider
	{
		[Token(Token = "0x400048A")]
		k_EWorkshopVideoProviderNone,
		[Token(Token = "0x400048B")]
		k_EWorkshopVideoProviderYoutube
	}
	[Token(Token = "0x20000F1")]
	public enum EUGCReadAction
	{
		[Token(Token = "0x400048D")]
		k_EUGCRead_ContinueReadingUntilFinished,
		[Token(Token = "0x400048E")]
		k_EUGCRead_ContinueReading,
		[Token(Token = "0x400048F")]
		k_EUGCRead_Close
	}
	[Token(Token = "0x20000F2")]
	public enum EUGCMatchingUGCType
	{
		[Token(Token = "0x4000491")]
		k_EUGCMatchingUGCType_Items,
		[Token(Token = "0x4000492")]
		k_EUGCMatchingUGCType_Items_Mtx,
		[Token(Token = "0x4000493")]
		k_EUGCMatchingUGCType_Items_ReadyToUse,
		[Token(Token = "0x4000494")]
		k_EUGCMatchingUGCType_Collections,
		[Token(Token = "0x4000495")]
		k_EUGCMatchingUGCType_Artwork,
		[Token(Token = "0x4000496")]
		k_EUGCMatchingUGCType_Videos,
		[Token(Token = "0x4000497")]
		k_EUGCMatchingUGCType_Screenshots,
		[Token(Token = "0x4000498")]
		k_EUGCMatchingUGCType_AllGuides,
		[Token(Token = "0x4000499")]
		k_EUGCMatchingUGCType_WebGuides,
		[Token(Token = "0x400049A")]
		k_EUGCMatchingUGCType_IntegratedGuides,
		[Token(Token = "0x400049B")]
		k_EUGCMatchingUGCType_UsableInGame,
		[Token(Token = "0x400049C")]
		k_EUGCMatchingUGCType_ControllerBindings,
		[Token(Token = "0x400049D")]
		k_EUGCMatchingUGCType_GameManagedItems
	}
	[Token(Token = "0x20000F3")]
	public enum EUserUGCList
	{
		[Token(Token = "0x400049F")]
		k_EUserUGCList_Published,
		[Token(Token = "0x40004A0")]
		k_EUserUGCList_VotedOn,
		[Token(Token = "0x40004A1")]
		k_EUserUGCList_VotedUp,
		[Token(Token = "0x40004A2")]
		k_EUserUGCList_VotedDown,
		[Token(Token = "0x40004A3")]
		k_EUserUGCList_WillVoteLater,
		[Token(Token = "0x40004A4")]
		k_EUserUGCList_Favorited,
		[Token(Token = "0x40004A5")]
		k_EUserUGCList_Subscribed,
		[Token(Token = "0x40004A6")]
		k_EUserUGCList_UsedOrPlayed,
		[Token(Token = "0x40004A7")]
		k_EUserUGCList_Followed
	}
	[Token(Token = "0x20000F4")]
	public enum EUserUGCListSortOrder
	{
		[Token(Token = "0x40004A9")]
		k_EUserUGCListSortOrder_CreationOrderDesc,
		[Token(Token = "0x40004AA")]
		k_EUserUGCListSortOrder_CreationOrderAsc,
		[Token(Token = "0x40004AB")]
		k_EUserUGCListSortOrder_TitleAsc,
		[Token(Token = "0x40004AC")]
		k_EUserUGCListSortOrder_LastUpdatedDesc,
		[Token(Token = "0x40004AD")]
		k_EUserUGCListSortOrder_SubscriptionDateDesc,
		[Token(Token = "0x40004AE")]
		k_EUserUGCListSortOrder_VoteScoreDesc,
		[Token(Token = "0x40004AF")]
		k_EUserUGCListSortOrder_ForModeration
	}
	[Token(Token = "0x20000F5")]
	public enum EUGCQuery
	{
		[Token(Token = "0x40004B1")]
		k_EUGCQuery_RankedByVote,
		[Token(Token = "0x40004B2")]
		k_EUGCQuery_RankedByPublicationDate,
		[Token(Token = "0x40004B3")]
		k_EUGCQuery_AcceptedForGameRankedByAcceptanceDate,
		[Token(Token = "0x40004B4")]
		k_EUGCQuery_RankedByTrend,
		[Token(Token = "0x40004B5")]
		k_EUGCQuery_FavoritedByFriendsRankedByPublicationDate,
		[Token(Token = "0x40004B6")]
		k_EUGCQuery_CreatedByFriendsRankedByPublicationDate,
		[Token(Token = "0x40004B7")]
		k_EUGCQuery_RankedByNumTimesReported,
		[Token(Token = "0x40004B8")]
		k_EUGCQuery_CreatedByFollowedUsersRankedByPublicationDate,
		[Token(Token = "0x40004B9")]
		k_EUGCQuery_NotYetRated,
		[Token(Token = "0x40004BA")]
		k_EUGCQuery_RankedByTotalVotesAsc,
		[Token(Token = "0x40004BB")]
		k_EUGCQuery_RankedByVotesUp,
		[Token(Token = "0x40004BC")]
		k_EUGCQuery_RankedByTextSearch,
		[Token(Token = "0x40004BD")]
		k_EUGCQuery_RankedByTotalUniqueSubscriptions
	}
	[Token(Token = "0x20000F6")]
	public enum EItemUpdateStatus
	{
		[Token(Token = "0x40004BF")]
		k_EItemUpdateStatusInvalid,
		[Token(Token = "0x40004C0")]
		k_EItemUpdateStatusPreparingConfig,
		[Token(Token = "0x40004C1")]
		k_EItemUpdateStatusPreparingContent,
		[Token(Token = "0x40004C2")]
		k_EItemUpdateStatusUploadingContent,
		[Token(Token = "0x40004C3")]
		k_EItemUpdateStatusUploadingPreviewFile,
		[Token(Token = "0x40004C4")]
		k_EItemUpdateStatusCommittingChanges
	}
	[Token(Token = "0x20000F7")]
	[Flags]
	public enum EItemState
	{
		[Token(Token = "0x40004C6")]
		k_EItemStateNone = 0,
		[Token(Token = "0x40004C7")]
		k_EItemStateSubscribed = 1,
		[Token(Token = "0x40004C8")]
		k_EItemStateLegacyItem = 2,
		[Token(Token = "0x40004C9")]
		k_EItemStateInstalled = 4,
		[Token(Token = "0x40004CA")]
		k_EItemStateNeedsUpdate = 8,
		[Token(Token = "0x40004CB")]
		k_EItemStateDownloading = 0x10,
		[Token(Token = "0x40004CC")]
		k_EItemStateDownloadPending = 0x20
	}
	[Token(Token = "0x20000F8")]
	public enum EItemStatistic
	{
		[Token(Token = "0x40004CE")]
		k_EItemStatistic_NumSubscriptions,
		[Token(Token = "0x40004CF")]
		k_EItemStatistic_NumFavorites,
		[Token(Token = "0x40004D0")]
		k_EItemStatistic_NumFollowers,
		[Token(Token = "0x40004D1")]
		k_EItemStatistic_NumUniqueSubscriptions,
		[Token(Token = "0x40004D2")]
		k_EItemStatistic_NumUniqueFavorites,
		[Token(Token = "0x40004D3")]
		k_EItemStatistic_NumUniqueFollowers,
		[Token(Token = "0x40004D4")]
		k_EItemStatistic_NumUniqueWebsiteViews,
		[Token(Token = "0x40004D5")]
		k_EItemStatistic_ReportScore
	}
	[Token(Token = "0x20000F9")]
	public enum EFailureType
	{
		[Token(Token = "0x40004D7")]
		k_EFailureFlushedCallbackQueue,
		[Token(Token = "0x40004D8")]
		k_EFailurePipeFail
	}
	[Token(Token = "0x20000FA")]
	public enum ELeaderboardDataRequest
	{
		[Token(Token = "0x40004DA")]
		k_ELeaderboardDataRequestGlobal,
		[Token(Token = "0x40004DB")]
		k_ELeaderboardDataRequestGlobalAroundUser,
		[Token(Token = "0x40004DC")]
		k_ELeaderboardDataRequestFriends,
		[Token(Token = "0x40004DD")]
		k_ELeaderboardDataRequestUsers
	}
	[Token(Token = "0x20000FB")]
	public enum ELeaderboardSortMethod
	{
		[Token(Token = "0x40004DF")]
		k_ELeaderboardSortMethodNone,
		[Token(Token = "0x40004E0")]
		k_ELeaderboardSortMethodAscending,
		[Token(Token = "0x40004E1")]
		k_ELeaderboardSortMethodDescending
	}
	[Token(Token = "0x20000FC")]
	public enum ELeaderboardDisplayType
	{
		[Token(Token = "0x40004E3")]
		k_ELeaderboardDisplayTypeNone,
		[Token(Token = "0x40004E4")]
		k_ELeaderboardDisplayTypeNumeric,
		[Token(Token = "0x40004E5")]
		k_ELeaderboardDisplayTypeTimeSeconds,
		[Token(Token = "0x40004E6")]
		k_ELeaderboardDisplayTypeTimeMilliSeconds
	}
	[Token(Token = "0x20000FD")]
	public enum ELeaderboardUploadScoreMethod
	{
		[Token(Token = "0x40004E8")]
		k_ELeaderboardUploadScoreMethodNone,
		[Token(Token = "0x40004E9")]
		k_ELeaderboardUploadScoreMethodKeepBest,
		[Token(Token = "0x40004EA")]
		k_ELeaderboardUploadScoreMethodForceUpdate
	}
	[Token(Token = "0x20000FE")]
	public enum ESteamAPICallFailure
	{
		[Token(Token = "0x40004EC")]
		k_ESteamAPICallFailureNone = -1,
		[Token(Token = "0x40004ED")]
		k_ESteamAPICallFailureSteamGone,
		[Token(Token = "0x40004EE")]
		k_ESteamAPICallFailureNetworkFailure,
		[Token(Token = "0x40004EF")]
		k_ESteamAPICallFailureInvalidHandle,
		[Token(Token = "0x40004F0")]
		k_ESteamAPICallFailureMismatchedCallback
	}
	[Token(Token = "0x20000FF")]
	public enum EGamepadTextInputMode
	{
		[Token(Token = "0x40004F2")]
		k_EGamepadTextInputModeNormal,
		[Token(Token = "0x40004F3")]
		k_EGamepadTextInputModePassword
	}
	[Token(Token = "0x2000100")]
	public enum EGamepadTextInputLineMode
	{
		[Token(Token = "0x40004F5")]
		k_EGamepadTextInputLineModeSingleLine,
		[Token(Token = "0x40004F6")]
		k_EGamepadTextInputLineModeMultipleLines
	}
	[Token(Token = "0x2000101")]
	public enum ECheckFileSignature
	{
		[Token(Token = "0x40004F8")]
		k_ECheckFileSignatureInvalidSignature,
		[Token(Token = "0x40004F9")]
		k_ECheckFileSignatureValidSignature,
		[Token(Token = "0x40004FA")]
		k_ECheckFileSignatureFileNotFound,
		[Token(Token = "0x40004FB")]
		k_ECheckFileSignatureNoSignaturesFoundForThisApp,
		[Token(Token = "0x40004FC")]
		k_ECheckFileSignatureNoSignaturesFoundForThisFile
	}
	[Token(Token = "0x2000102")]
	public enum EMatchMakingServerResponse
	{
		[Token(Token = "0x40004FE")]
		eServerResponded,
		[Token(Token = "0x40004FF")]
		eServerFailedToRespond,
		[Token(Token = "0x4000500")]
		eNoServersListedOnMasterServer
	}
	[Token(Token = "0x2000103")]
	public enum EServerMode
	{
		[Token(Token = "0x4000502")]
		eServerModeInvalid,
		[Token(Token = "0x4000503")]
		eServerModeNoAuthentication,
		[Token(Token = "0x4000504")]
		eServerModeAuthentication,
		[Token(Token = "0x4000505")]
		eServerModeAuthenticationAndSecure
	}
	[Token(Token = "0x2000104")]
	public enum EResult
	{
		[Token(Token = "0x4000507")]
		k_EResultOK = 1,
		[Token(Token = "0x4000508")]
		k_EResultFail = 2,
		[Token(Token = "0x4000509")]
		k_EResultNoConnection = 3,
		[Token(Token = "0x400050A")]
		k_EResultInvalidPassword = 5,
		[Token(Token = "0x400050B")]
		k_EResultLoggedInElsewhere = 6,
		[Token(Token = "0x400050C")]
		k_EResultInvalidProtocolVer = 7,
		[Token(Token = "0x400050D")]
		k_EResultInvalidParam = 8,
		[Token(Token = "0x400050E")]
		k_EResultFileNotFound = 9,
		[Token(Token = "0x400050F")]
		k_EResultBusy = 10,
		[Token(Token = "0x4000510")]
		k_EResultInvalidState = 11,
		[Token(Token = "0x4000511")]
		k_EResultInvalidName = 12,
		[Token(Token = "0x4000512")]
		k_EResultInvalidEmail = 13,
		[Token(Token = "0x4000513")]
		k_EResultDuplicateName = 14,
		[Token(Token = "0x4000514")]
		k_EResultAccessDenied = 15,
		[Token(Token = "0x4000515")]
		k_EResultTimeout = 16,
		[Token(Token = "0x4000516")]
		k_EResultBanned = 17,
		[Token(Token = "0x4000517")]
		k_EResultAccountNotFound = 18,
		[Token(Token = "0x4000518")]
		k_EResultInvalidSteamID = 19,
		[Token(Token = "0x4000519")]
		k_EResultServiceUnavailable = 20,
		[Token(Token = "0x400051A")]
		k_EResultNotLoggedOn = 21,
		[Token(Token = "0x400051B")]
		k_EResultPending = 22,
		[Token(Token = "0x400051C")]
		k_EResultEncryptionFailure = 23,
		[Token(Token = "0x400051D")]
		k_EResultInsufficientPrivilege = 24,
		[Token(Token = "0x400051E")]
		k_EResultLimitExceeded = 25,
		[Token(Token = "0x400051F")]
		k_EResultRevoked = 26,
		[Token(Token = "0x4000520")]
		k_EResultExpired = 27,
		[Token(Token = "0x4000521")]
		k_EResultAlreadyRedeemed = 28,
		[Token(Token = "0x4000522")]
		k_EResultDuplicateRequest = 29,
		[Token(Token = "0x4000523")]
		k_EResultAlreadyOwned = 30,
		[Token(Token = "0x4000524")]
		k_EResultIPNotFound = 31,
		[Token(Token = "0x4000525")]
		k_EResultPersistFailed = 32,
		[Token(Token = "0x4000526")]
		k_EResultLockingFailed = 33,
		[Token(Token = "0x4000527")]
		k_EResultLogonSessionReplaced = 34,
		[Token(Token = "0x4000528")]
		k_EResultConnectFailed = 35,
		[Token(Token = "0x4000529")]
		k_EResultHandshakeFailed = 36,
		[Token(Token = "0x400052A")]
		k_EResultIOFailure = 37,
		[Token(Token = "0x400052B")]
		k_EResultRemoteDisconnect = 38,
		[Token(Token = "0x400052C")]
		k_EResultShoppingCartNotFound = 39,
		[Token(Token = "0x400052D")]
		k_EResultBlocked = 40,
		[Token(Token = "0x400052E")]
		k_EResultIgnored = 41,
		[Token(Token = "0x400052F")]
		k_EResultNoMatch = 42,
		[Token(Token = "0x4000530")]
		k_EResultAccountDisabled = 43,
		[Token(Token = "0x4000531")]
		k_EResultServiceReadOnly = 44,
		[Token(Token = "0x4000532")]
		k_EResultAccountNotFeatured = 45,
		[Token(Token = "0x4000533")]
		k_EResultAdministratorOK = 46,
		[Token(Token = "0x4000534")]
		k_EResultContentVersion = 47,
		[Token(Token = "0x4000535")]
		k_EResultTryAnotherCM = 48,
		[Token(Token = "0x4000536")]
		k_EResultPasswordRequiredToKickSession = 49,
		[Token(Token = "0x4000537")]
		k_EResultAlreadyLoggedInElsewhere = 50,
		[Token(Token = "0x4000538")]
		k_EResultSuspended = 51,
		[Token(Token = "0x4000539")]
		k_EResultCancelled = 52,
		[Token(Token = "0x400053A")]
		k_EResultDataCorruption = 53,
		[Token(Token = "0x400053B")]
		k_EResultDiskFull = 54,
		[Token(Token = "0x400053C")]
		k_EResultRemoteCallFailed = 55,
		[Token(Token = "0x400053D")]
		k_EResultPasswordUnset = 56,
		[Token(Token = "0x400053E")]
		k_EResultExternalAccountUnlinked = 57,
		[Token(Token = "0x400053F")]
		k_EResultPSNTicketInvalid = 58,
		[Token(Token = "0x4000540")]
		k_EResultExternalAccountAlreadyLinked = 59,
		[Token(Token = "0x4000541")]
		k_EResultRemoteFileConflict = 60,
		[Token(Token = "0x4000542")]
		k_EResultIllegalPassword = 61,
		[Token(Token = "0x4000543")]
		k_EResultSameAsPreviousValue = 62,
		[Token(Token = "0x4000544")]
		k_EResultAccountLogonDenied = 63,
		[Token(Token = "0x4000545")]
		k_EResultCannotUseOldPassword = 64,
		[Token(Token = "0x4000546")]
		k_EResultInvalidLoginAuthCode = 65,
		[Token(Token = "0x4000547")]
		k_EResultAccountLogonDeniedNoMail = 66,
		[Token(Token = "0x4000548")]
		k_EResultHardwareNotCapableOfIPT = 67,
		[Token(Token = "0x4000549")]
		k_EResultIPTInitError = 68,
		[Token(Token = "0x400054A")]
		k_EResultParentalControlRestricted = 69,
		[Token(Token = "0x400054B")]
		k_EResultFacebookQueryError = 70,
		[Token(Token = "0x400054C")]
		k_EResultExpiredLoginAuthCode = 71,
		[Token(Token = "0x400054D")]
		k_EResultIPLoginRestrictionFailed = 72,
		[Token(Token = "0x400054E")]
		k_EResultAccountLockedDown = 73,
		[Token(Token = "0x400054F")]
		k_EResultAccountLogonDeniedVerifiedEmailRequired = 74,
		[Token(Token = "0x4000550")]
		k_EResultNoMatchingURL = 75,
		[Token(Token = "0x4000551")]
		k_EResultBadResponse = 76,
		[Token(Token = "0x4000552")]
		k_EResultRequirePasswordReEntry = 77,
		[Token(Token = "0x4000553")]
		k_EResultValueOutOfRange = 78,
		[Token(Token = "0x4000554")]
		k_EResultUnexpectedError = 79,
		[Token(Token = "0x4000555")]
		k_EResultDisabled = 80,
		[Token(Token = "0x4000556")]
		k_EResultInvalidCEGSubmission = 81,
		[Token(Token = "0x4000557")]
		k_EResultRestrictedDevice = 82,
		[Token(Token = "0x4000558")]
		k_EResultRegionLocked = 83,
		[Token(Token = "0x4000559")]
		k_EResultRateLimitExceeded = 84,
		[Token(Token = "0x400055A")]
		k_EResultAccountLoginDeniedNeedTwoFactor = 85,
		[Token(Token = "0x400055B")]
		k_EResultItemDeleted = 86,
		[Token(Token = "0x400055C")]
		k_EResultAccountLoginDeniedThrottle = 87,
		[Token(Token = "0x400055D")]
		k_EResultTwoFactorCodeMismatch = 88,
		[Token(Token = "0x400055E")]
		k_EResultTwoFactorActivationCodeMismatch = 89,
		[Token(Token = "0x400055F")]
		k_EResultAccountAssociatedToMultiplePartners = 90,
		[Token(Token = "0x4000560")]
		k_EResultNotModified = 91,
		[Token(Token = "0x4000561")]
		k_EResultNoMobileDevice = 92,
		[Token(Token = "0x4000562")]
		k_EResultTimeNotSynced = 93,
		[Token(Token = "0x4000563")]
		k_EResultSmsCodeFailed = 94,
		[Token(Token = "0x4000564")]
		k_EResultAccountLimitExceeded = 95,
		[Token(Token = "0x4000565")]
		k_EResultAccountActivityLimitExceeded = 96,
		[Token(Token = "0x4000566")]
		k_EResultPhoneActivityLimitExceeded = 97,
		[Token(Token = "0x4000567")]
		k_EResultRefundToWallet = 98,
		[Token(Token = "0x4000568")]
		k_EResultEmailSendFailure = 99,
		[Token(Token = "0x4000569")]
		k_EResultNotSettled = 100
	}
	[Token(Token = "0x2000105")]
	public enum EVoiceResult
	{
		[Token(Token = "0x400056B")]
		k_EVoiceResultOK,
		[Token(Token = "0x400056C")]
		k_EVoiceResultNotInitialized,
		[Token(Token = "0x400056D")]
		k_EVoiceResultNotRecording,
		[Token(Token = "0x400056E")]
		k_EVoiceResultNoData,
		[Token(Token = "0x400056F")]
		k_EVoiceResultBufferTooSmall,
		[Token(Token = "0x4000570")]
		k_EVoiceResultDataCorrupted,
		[Token(Token = "0x4000571")]
		k_EVoiceResultRestricted,
		[Token(Token = "0x4000572")]
		k_EVoiceResultUnsupportedCodec,
		[Token(Token = "0x4000573")]
		k_EVoiceResultReceiverOutOfDate,
		[Token(Token = "0x4000574")]
		k_EVoiceResultReceiverDidNotAnswer
	}
	[Token(Token = "0x2000106")]
	public enum EDenyReason
	{
		[Token(Token = "0x4000576")]
		k_EDenyInvalid,
		[Token(Token = "0x4000577")]
		k_EDenyInvalidVersion,
		[Token(Token = "0x4000578")]
		k_EDenyGeneric,
		[Token(Token = "0x4000579")]
		k_EDenyNotLoggedOn,
		[Token(Token = "0x400057A")]
		k_EDenyNoLicense,
		[Token(Token = "0x400057B")]
		k_EDenyCheater,
		[Token(Token = "0x400057C")]
		k_EDenyLoggedInElseWhere,
		[Token(Token = "0x400057D")]
		k_EDenyUnknownText,
		[Token(Token = "0x400057E")]
		k_EDenyIncompatibleAnticheat,
		[Token(Token = "0x400057F")]
		k_EDenyMemoryCorruption,
		[Token(Token = "0x4000580")]
		k_EDenyIncompatibleSoftware,
		[Token(Token = "0x4000581")]
		k_EDenySteamConnectionLost,
		[Token(Token = "0x4000582")]
		k_EDenySteamConnectionError,
		[Token(Token = "0x4000583")]
		k_EDenySteamResponseTimedOut,
		[Token(Token = "0x4000584")]
		k_EDenySteamValidationStalled,
		[Token(Token = "0x4000585")]
		k_EDenySteamOwnerLeftGuestUser
	}
	[Token(Token = "0x2000107")]
	public enum EBeginAuthSessionResult
	{
		[Token(Token = "0x4000587")]
		k_EBeginAuthSessionResultOK,
		[Token(Token = "0x4000588")]
		k_EBeginAuthSessionResultInvalidTicket,
		[Token(Token = "0x4000589")]
		k_EBeginAuthSessionResultDuplicateRequest,
		[Token(Token = "0x400058A")]
		k_EBeginAuthSessionResultInvalidVersion,
		[Token(Token = "0x400058B")]
		k_EBeginAuthSessionResultGameMismatch,
		[Token(Token = "0x400058C")]
		k_EBeginAuthSessionResultExpiredTicket
	}
	[Token(Token = "0x2000108")]
	public enum EAuthSessionResponse
	{
		[Token(Token = "0x400058E")]
		k_EAuthSessionResponseOK,
		[Token(Token = "0x400058F")]
		k_EAuthSessionResponseUserNotConnectedToSteam,
		[Token(Token = "0x4000590")]
		k_EAuthSessionResponseNoLicenseOrExpired,
		[Token(Token = "0x4000591")]
		k_EAuthSessionResponseVACBanned,
		[Token(Token = "0x4000592")]
		k_EAuthSessionResponseLoggedInElseWhere,
		[Token(Token = "0x4000593")]
		k_EAuthSessionResponseVACCheckTimedOut,
		[Token(Token = "0x4000594")]
		k_EAuthSessionResponseAuthTicketCanceled,
		[Token(Token = "0x4000595")]
		k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed,
		[Token(Token = "0x4000596")]
		k_EAuthSessionResponseAuthTicketInvalid,
		[Token(Token = "0x4000597")]
		k_EAuthSessionResponsePublisherIssuedBan
	}
	[Token(Token = "0x2000109")]
	public enum EUserHasLicenseForAppResult
	{
		[Token(Token = "0x4000599")]
		k_EUserHasLicenseResultHasLicense,
		[Token(Token = "0x400059A")]
		k_EUserHasLicenseResultDoesNotHaveLicense,
		[Token(Token = "0x400059B")]
		k_EUserHasLicenseResultNoAuth
	}
	[Token(Token = "0x200010A")]
	public enum EAccountType
	{
		[Token(Token = "0x400059D")]
		k_EAccountTypeInvalid,
		[Token(Token = "0x400059E")]
		k_EAccountTypeIndividual,
		[Token(Token = "0x400059F")]
		k_EAccountTypeMultiseat,
		[Token(Token = "0x40005A0")]
		k_EAccountTypeGameServer,
		[Token(Token = "0x40005A1")]
		k_EAccountTypeAnonGameServer,
		[Token(Token = "0x40005A2")]
		k_EAccountTypePending,
		[Token(Token = "0x40005A3")]
		k_EAccountTypeContentServer,
		[Token(Token = "0x40005A4")]
		k_EAccountTypeClan,
		[Token(Token = "0x40005A5")]
		k_EAccountTypeChat,
		[Token(Token = "0x40005A6")]
		k_EAccountTypeConsoleUser,
		[Token(Token = "0x40005A7")]
		k_EAccountTypeAnonUser,
		[Token(Token = "0x40005A8")]
		k_EAccountTypeMax
	}
	[Token(Token = "0x200010B")]
	public enum EAppReleaseState
	{
		[Token(Token = "0x40005AA")]
		k_EAppReleaseState_Unknown,
		[Token(Token = "0x40005AB")]
		k_EAppReleaseState_Unavailable,
		[Token(Token = "0x40005AC")]
		k_EAppReleaseState_Prerelease,
		[Token(Token = "0x40005AD")]
		k_EAppReleaseState_PreloadOnly,
		[Token(Token = "0x40005AE")]
		k_EAppReleaseState_Released
	}
	[Token(Token = "0x200010C")]
	[Flags]
	public enum EAppOwnershipFlags
	{
		[Token(Token = "0x40005B0")]
		k_EAppOwnershipFlags_None = 0,
		[Token(Token = "0x40005B1")]
		k_EAppOwnershipFlags_OwnsLicense = 1,
		[Token(Token = "0x40005B2")]
		k_EAppOwnershipFlags_FreeLicense = 2,
		[Token(Token = "0x40005B3")]
		k_EAppOwnershipFlags_RegionRestricted = 4,
		[Token(Token = "0x40005B4")]
		k_EAppOwnershipFlags_LowViolence = 8,
		[Token(Token = "0x40005B5")]
		k_EAppOwnershipFlags_InvalidPlatform = 0x10,
		[Token(Token = "0x40005B6")]
		k_EAppOwnershipFlags_SharedLicense = 0x20,
		[Token(Token = "0x40005B7")]
		k_EAppOwnershipFlags_FreeWeekend = 0x40,
		[Token(Token = "0x40005B8")]
		k_EAppOwnershipFlags_RetailLicense = 0x80,
		[Token(Token = "0x40005B9")]
		k_EAppOwnershipFlags_LicenseLocked = 0x100,
		[Token(Token = "0x40005BA")]
		k_EAppOwnershipFlags_LicensePending = 0x200,
		[Token(Token = "0x40005BB")]
		k_EAppOwnershipFlags_LicenseExpired = 0x400,
		[Token(Token = "0x40005BC")]
		k_EAppOwnershipFlags_LicensePermanent = 0x800,
		[Token(Token = "0x40005BD")]
		k_EAppOwnershipFlags_LicenseRecurring = 0x1000,
		[Token(Token = "0x40005BE")]
		k_EAppOwnershipFlags_LicenseCanceled = 0x2000,
		[Token(Token = "0x40005BF")]
		k_EAppOwnershipFlags_AutoGrant = 0x4000
	}
	[Token(Token = "0x200010D")]
	[Flags]
	public enum EAppType
	{
		[Token(Token = "0x40005C1")]
		k_EAppType_Invalid = 0,
		[Token(Token = "0x40005C2")]
		k_EAppType_Game = 1,
		[Token(Token = "0x40005C3")]
		k_EAppType_Application = 2,
		[Token(Token = "0x40005C4")]
		k_EAppType_Tool = 4,
		[Token(Token = "0x40005C5")]
		k_EAppType_Demo = 8,
		[Token(Token = "0x40005C6")]
		k_EAppType_Media_DEPRECATED = 0x10,
		[Token(Token = "0x40005C7")]
		k_EAppType_DLC = 0x20,
		[Token(Token = "0x40005C8")]
		k_EAppType_Guide = 0x40,
		[Token(Token = "0x40005C9")]
		k_EAppType_Driver = 0x80,
		[Token(Token = "0x40005CA")]
		k_EAppType_Config = 0x100,
		[Token(Token = "0x40005CB")]
		k_EAppType_Hardware = 0x200,
		[Token(Token = "0x40005CC")]
		k_EAppType_Video = 0x800,
		[Token(Token = "0x40005CD")]
		k_EAppType_Plugin = 0x1000,
		[Token(Token = "0x40005CE")]
		k_EAppType_Music = 0x2000,
		[Token(Token = "0x40005CF")]
		k_EAppType_Shortcut = 0x40000000,
		[Token(Token = "0x40005D0")]
		k_EAppType_DepotOnly = -2147483647
	}
	[Token(Token = "0x200010E")]
	public enum ESteamUserStatType
	{
		[Token(Token = "0x40005D2")]
		k_ESteamUserStatTypeINVALID,
		[Token(Token = "0x40005D3")]
		k_ESteamUserStatTypeINT,
		[Token(Token = "0x40005D4")]
		k_ESteamUserStatTypeFLOAT,
		[Token(Token = "0x40005D5")]
		k_ESteamUserStatTypeAVGRATE,
		[Token(Token = "0x40005D6")]
		k_ESteamUserStatTypeACHIEVEMENTS,
		[Token(Token = "0x40005D7")]
		k_ESteamUserStatTypeGROUPACHIEVEMENTS,
		[Token(Token = "0x40005D8")]
		k_ESteamUserStatTypeMAX
	}
	[Token(Token = "0x200010F")]
	public enum EChatEntryType
	{
		[Token(Token = "0x40005DA")]
		k_EChatEntryTypeInvalid = 0,
		[Token(Token = "0x40005DB")]
		k_EChatEntryTypeChatMsg = 1,
		[Token(Token = "0x40005DC")]
		k_EChatEntryTypeTyping = 2,
		[Token(Token = "0x40005DD")]
		k_EChatEntryTypeInviteGame = 3,
		[Token(Token = "0x40005DE")]
		k_EChatEntryTypeEmote = 4,
		[Token(Token = "0x40005DF")]
		k_EChatEntryTypeLeftConversation = 6,
		[Token(Token = "0x40005E0")]
		k_EChatEntryTypeEntered = 7,
		[Token(Token = "0x40005E1")]
		k_EChatEntryTypeWasKicked = 8,
		[Token(Token = "0x40005E2")]
		k_EChatEntryTypeWasBanned = 9,
		[Token(Token = "0x40005E3")]
		k_EChatEntryTypeDisconnected = 10,
		[Token(Token = "0x40005E4")]
		k_EChatEntryTypeHistoricalChat = 11,
		[Token(Token = "0x40005E5")]
		k_EChatEntryTypeReserved1 = 12,
		[Token(Token = "0x40005E6")]
		k_EChatEntryTypeReserved2 = 13,
		[Token(Token = "0x40005E7")]
		k_EChatEntryTypeLinkBlocked = 14
	}
	[Token(Token = "0x2000110")]
	public enum EChatRoomEnterResponse
	{
		[Token(Token = "0x40005E9")]
		k_EChatRoomEnterResponseSuccess = 1,
		[Token(Token = "0x40005EA")]
		k_EChatRoomEnterResponseDoesntExist,
		[Token(Token = "0x40005EB")]
		k_EChatRoomEnterResponseNotAllowed,
		[Token(Token = "0x40005EC")]
		k_EChatRoomEnterResponseFull,
		[Token(Token = "0x40005ED")]
		k_EChatRoomEnterResponseError,
		[Token(Token = "0x40005EE")]
		k_EChatRoomEnterResponseBanned,
		[Token(Token = "0x40005EF")]
		k_EChatRoomEnterResponseLimited,
		[Token(Token = "0x40005F0")]
		k_EChatRoomEnterResponseClanDisabled,
		[Token(Token = "0x40005F1")]
		k_EChatRoomEnterResponseCommunityBan,
		[Token(Token = "0x40005F2")]
		k_EChatRoomEnterResponseMemberBlockedYou,
		[Token(Token = "0x40005F3")]
		k_EChatRoomEnterResponseYouBlockedMember
	}
	[Token(Token = "0x2000111")]
	[Flags]
	public enum EChatSteamIDInstanceFlags
	{
		[Token(Token = "0x40005F5")]
		k_EChatAccountInstanceMask = 0xFFF,
		[Token(Token = "0x40005F6")]
		k_EChatInstanceFlagClan = 0x80000,
		[Token(Token = "0x40005F7")]
		k_EChatInstanceFlagLobby = 0x40000,
		[Token(Token = "0x40005F8")]
		k_EChatInstanceFlagMMSLobby = 0x20000
	}
	[Token(Token = "0x2000112")]
	[Flags]
	public enum EMarketingMessageFlags
	{
		[Token(Token = "0x40005FA")]
		k_EMarketingMessageFlagsNone = 0,
		[Token(Token = "0x40005FB")]
		k_EMarketingMessageFlagsHighPriority = 1,
		[Token(Token = "0x40005FC")]
		k_EMarketingMessageFlagsPlatformWindows = 2,
		[Token(Token = "0x40005FD")]
		k_EMarketingMessageFlagsPlatformMac = 4,
		[Token(Token = "0x40005FE")]
		k_EMarketingMessageFlagsPlatformLinux = 8,
		[Token(Token = "0x40005FF")]
		k_EMarketingMessageFlagsPlatformRestrictions = 0xE
	}
	[Token(Token = "0x2000113")]
	public enum ENotificationPosition
	{
		[Token(Token = "0x4000601")]
		k_EPositionTopLeft,
		[Token(Token = "0x4000602")]
		k_EPositionTopRight,
		[Token(Token = "0x4000603")]
		k_EPositionBottomLeft,
		[Token(Token = "0x4000604")]
		k_EPositionBottomRight
	}
	[Token(Token = "0x2000114")]
	public enum EBroadcastUploadResult
	{
		[Token(Token = "0x4000606")]
		k_EBroadcastUploadResultNone,
		[Token(Token = "0x4000607")]
		k_EBroadcastUploadResultOK,
		[Token(Token = "0x4000608")]
		k_EBroadcastUploadResultInitFailed,
		[Token(Token = "0x4000609")]
		k_EBroadcastUploadResultFrameFailed,
		[Token(Token = "0x400060A")]
		k_EBroadcastUploadResultTimeout,
		[Token(Token = "0x400060B")]
		k_EBroadcastUploadResultBandwidthExceeded,
		[Token(Token = "0x400060C")]
		k_EBroadcastUploadResultLowFPS,
		[Token(Token = "0x400060D")]
		k_EBroadcastUploadResultMissingKeyFrames,
		[Token(Token = "0x400060E")]
		k_EBroadcastUploadResultNoConnection,
		[Token(Token = "0x400060F")]
		k_EBroadcastUploadResultRelayFailed,
		[Token(Token = "0x4000610")]
		k_EBroadcastUploadResultSettingsChanged,
		[Token(Token = "0x4000611")]
		k_EBroadcastUploadResultMissingAudio,
		[Token(Token = "0x4000612")]
		k_EBroadcastUploadResultTooFarBehind
	}
	[Token(Token = "0x2000115")]
	public enum EHTTPMethod
	{
		[Token(Token = "0x4000614")]
		k_EHTTPMethodInvalid,
		[Token(Token = "0x4000615")]
		k_EHTTPMethodGET,
		[Token(Token = "0x4000616")]
		k_EHTTPMethodHEAD,
		[Token(Token = "0x4000617")]
		k_EHTTPMethodPOST,
		[Token(Token = "0x4000618")]
		k_EHTTPMethodPUT,
		[Token(Token = "0x4000619")]
		k_EHTTPMethodDELETE,
		[Token(Token = "0x400061A")]
		k_EHTTPMethodOPTIONS
	}
	[Token(Token = "0x2000116")]
	public enum EHTTPStatusCode
	{
		[Token(Token = "0x400061C")]
		k_EHTTPStatusCodeInvalid = 0,
		[Token(Token = "0x400061D")]
		k_EHTTPStatusCode100Continue = 100,
		[Token(Token = "0x400061E")]
		k_EHTTPStatusCode101SwitchingProtocols = 101,
		[Token(Token = "0x400061F")]
		k_EHTTPStatusCode200OK = 200,
		[Token(Token = "0x4000620")]
		k_EHTTPStatusCode201Created = 201,
		[Token(Token = "0x4000621")]
		k_EHTTPStatusCode202Accepted = 202,
		[Token(Token = "0x4000622")]
		k_EHTTPStatusCode203NonAuthoritative = 203,
		[Token(Token = "0x4000623")]
		k_EHTTPStatusCode204NoContent = 204,
		[Token(Token = "0x4000624")]
		k_EHTTPStatusCode205ResetContent = 205,
		[Token(Token = "0x4000625")]
		k_EHTTPStatusCode206PartialContent = 206,
		[Token(Token = "0x4000626")]
		k_EHTTPStatusCode300MultipleChoices = 300,
		[Token(Token = "0x4000627")]
		k_EHTTPStatusCode301MovedPermanently = 301,
		[Token(Token = "0x4000628")]
		k_EHTTPStatusCode302Found = 302,
		[Token(Token = "0x4000629")]
		k_EHTTPStatusCode303SeeOther = 303,
		[Token(Token = "0x400062A")]
		k_EHTTPStatusCode304NotModified = 304,
		[Token(Token = "0x400062B")]
		k_EHTTPStatusCode305UseProxy = 305,
		[Token(Token = "0x400062C")]
		k_EHTTPStatusCode307TemporaryRedirect = 307,
		[Token(Token = "0x400062D")]
		k_EHTTPStatusCode400BadRequest = 400,
		[Token(Token = "0x400062E")]
		k_EHTTPStatusCode401Unauthorized = 401,
		[Token(Token = "0x400062F")]
		k_EHTTPStatusCode402PaymentRequired = 402,
		[Token(Token = "0x4000630")]
		k_EHTTPStatusCode403Forbidden = 403,
		[Token(Token = "0x4000631")]
		k_EHTTPStatusCode404NotFound = 404,
		[Token(Token = "0x4000632")]
		k_EHTTPStatusCode405MethodNotAllowed = 405,
		[Token(Token = "0x4000633")]
		k_EHTTPStatusCode406NotAcceptable = 406,
		[Token(Token = "0x4000634")]
		k_EHTTPStatusCode407ProxyAuthRequired = 407,
		[Token(Token = "0x4000635")]
		k_EHTTPStatusCode408RequestTimeout = 408,
		[Token(Token = "0x4000636")]
		k_EHTTPStatusCode409Conflict = 409,
		[Token(Token = "0x4000637")]
		k_EHTTPStatusCode410Gone = 410,
		[Token(Token = "0x4000638")]
		k_EHTTPStatusCode411LengthRequired = 411,
		[Token(Token = "0x4000639")]
		k_EHTTPStatusCode412PreconditionFailed = 412,
		[Token(Token = "0x400063A")]
		k_EHTTPStatusCode413RequestEntityTooLarge = 413,
		[Token(Token = "0x400063B")]
		k_EHTTPStatusCode414RequestURITooLong = 414,
		[Token(Token = "0x400063C")]
		k_EHTTPStatusCode415UnsupportedMediaType = 415,
		[Token(Token = "0x400063D")]
		k_EHTTPStatusCode416RequestedRangeNotSatisfiable = 416,
		[Token(Token = "0x400063E")]
		k_EHTTPStatusCode417ExpectationFailed = 417,
		[Token(Token = "0x400063F")]
		k_EHTTPStatusCode4xxUnknown = 418,
		[Token(Token = "0x4000640")]
		k_EHTTPStatusCode429TooManyRequests = 429,
		[Token(Token = "0x4000641")]
		k_EHTTPStatusCode500InternalServerError = 500,
		[Token(Token = "0x4000642")]
		k_EHTTPStatusCode501NotImplemented = 501,
		[Token(Token = "0x4000643")]
		k_EHTTPStatusCode502BadGateway = 502,
		[Token(Token = "0x4000644")]
		k_EHTTPStatusCode503ServiceUnavailable = 503,
		[Token(Token = "0x4000645")]
		k_EHTTPStatusCode504GatewayTimeout = 504,
		[Token(Token = "0x4000646")]
		k_EHTTPStatusCode505HTTPVersionNotSupported = 505,
		[Token(Token = "0x4000647")]
		k_EHTTPStatusCode5xxUnknown = 599
	}
	[Token(Token = "0x2000117")]
	public enum EUniverse
	{
		[Token(Token = "0x4000649")]
		k_EUniverseInvalid,
		[Token(Token = "0x400064A")]
		k_EUniversePublic,
		[Token(Token = "0x400064B")]
		k_EUniverseBeta,
		[Token(Token = "0x400064C")]
		k_EUniverseInternal,
		[Token(Token = "0x400064D")]
		k_EUniverseDev,
		[Token(Token = "0x400064E")]
		k_EUniverseMax
	}
	[Token(Token = "0x2000118")]
	public struct SteamControllerState_t
	{
		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint unPacketNum;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ulong ulButtons;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public short sLeftPadX;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public short sLeftPadY;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public short sRightPadX;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public short sRightPadY;
	}
	[Token(Token = "0x2000119")]
	public struct FriendGameInfo_t
	{
		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CGameID m_gameID;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_unGameIP;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ushort m_usGamePort;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public ushort m_usQueryPort;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CSteamID m_steamIDLobby;
	}
	[Token(Token = "0x200011A")]
	public struct FriendSessionStateInfo_t
	{
		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_uiOnlineSessionInstances;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte m_uiPublishedToFriendsSessionInstance;
	}
	[Token(Token = "0x200011B")]
	public struct SteamItemDetails_t
	{
		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamItemInstanceID_t m_itemId;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamItemDef_t m_iDefinition;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ushort m_unQuantity;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public ushort m_unFlags;
	}
	[Token(Token = "0x200011C")]
	public struct P2PSessionState_t
	{
		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bConnectionActive;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte m_bConnecting;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte m_eP2PSessionError;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte m_bUsingRelay;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nBytesQueuedForSend;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nPacketsQueuedForSend;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nRemoteIP;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ushort m_nRemotePort;
	}
	[Token(Token = "0x200011D")]
	public struct SteamParamStringArray_t
	{
		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_ppStrings;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nNumStrings;
	}
	[Token(Token = "0x200011E")]
	public struct SteamUGCDetails_t
	{
		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EWorkshopFileType m_eFileType;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AppId_t m_nCreatorAppID;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AppId_t m_nConsumerAppID;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_rgchTitle;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_rgchDescription;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ulong m_ulSteamIDOwner;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint m_rtimeCreated;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public uint m_rtimeUpdated;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_rtimeAddedToUserList;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool m_bBanned;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool m_bAcceptedForUse;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool m_bTagsTruncated;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_rgchTags;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UGCHandle_t m_hPreviewFile;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string m_pchFileName;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int m_nFileSize;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int m_nPreviewFileSize;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string m_rgchURL;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public uint m_unVotesUp;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public uint m_unVotesDown;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float m_flScore;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public uint m_unNumChildren;
	}
	[Token(Token = "0x200011F")]
	public struct CallbackMsg_t
	{
		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_hSteamUser;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_iCallback;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr m_pubParam;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_cubParam;
	}
	[Token(Token = "0x2000120")]
	public struct LeaderboardEntry_t
	{
		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nGlobalRank;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nScore;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_cDetails;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UGCHandle_t m_hUGC;
	}
	[Token(Token = "0x2000121")]
	public struct MatchMakingKeyValuePair_t
	{
		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_szKey;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_szValue;

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x934400", Offset = "0x934400", VA = "0x934400")]
		private MatchMakingKeyValuePair_t(string strKey, string strValue)
		{
		}
	}
	[Token(Token = "0x2000122")]
	public static class SteamAppList
	{
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xD491A0", Offset = "0xD491A0", VA = "0xD491A0")]
		public static uint GetNumInstalledApps()
		{
			return default(uint);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xD491BC", Offset = "0xD491BC", VA = "0xD491BC")]
		public static uint GetInstalledApps(AppId_t[] pvecAppID, uint unMaxAppIDs)
		{
			return default(uint);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xD491F0", Offset = "0xD491F0", VA = "0xD491F0")]
		public static int GetAppName(AppId_t nAppID, out string pchName, int cchNameMax)
		{
			return default(int);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xD492E0", Offset = "0xD492E0", VA = "0xD492E0")]
		public static int GetAppInstallDir(AppId_t nAppID, out string pchDirectory, int cchNameMax)
		{
			return default(int);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xD493D0", Offset = "0xD493D0", VA = "0xD493D0")]
		public static int GetAppBuildId(AppId_t nAppID)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000123")]
	public static class SteamApps
	{
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xD493FC", Offset = "0xD493FC", VA = "0xD493FC")]
		public static bool BIsSubscribed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xD49418", Offset = "0xD49418", VA = "0xD49418")]
		public static bool BIsLowViolence()
		{
			return default(bool);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xD49434", Offset = "0xD49434", VA = "0xD49434")]
		public static bool BIsCybercafe()
		{
			return default(bool);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xD49450", Offset = "0xD49450", VA = "0xD49450")]
		public static bool BIsVACBanned()
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xD4946C", Offset = "0xD4946C", VA = "0xD4946C")]
		public static string GetCurrentGameLanguage()
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xD49490", Offset = "0xD49490", VA = "0xD49490")]
		public static string GetAvailableGameLanguages()
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xD494B4", Offset = "0xD494B4", VA = "0xD494B4")]
		public static bool BIsSubscribedApp(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xD494E0", Offset = "0xD494E0", VA = "0xD494E0")]
		public static bool BIsDlcInstalled(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xD4950C", Offset = "0xD4950C", VA = "0xD4950C")]
		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
		{
			return default(uint);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xD49538", Offset = "0xD49538", VA = "0xD49538")]
		public static bool BIsSubscribedFromFreeWeekend()
		{
			return default(bool);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xD49554", Offset = "0xD49554", VA = "0xD49554")]
		public static int GetDLCCount()
		{
			return default(int);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xD49570", Offset = "0xD49570", VA = "0xD49570")]
		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xD49670", Offset = "0xD49670", VA = "0xD49670")]
		public static void InstallDLC(AppId_t nAppID)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xD4969C", Offset = "0xD4969C", VA = "0xD4969C")]
		public static void UninstallDLC(AppId_t nAppID)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xD496C8", Offset = "0xD496C8", VA = "0xD496C8")]
		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xD496F4", Offset = "0xD496F4", VA = "0xD496F4")]
		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xD497C8", Offset = "0xD497C8", VA = "0xD497C8")]
		public static bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xD497F4", Offset = "0xD497F4", VA = "0xD497F4")]
		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots)
		{
			return default(uint);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xD49838", Offset = "0xD49838", VA = "0xD49838")]
		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize)
		{
			return default(uint);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xD49924", Offset = "0xD49924", VA = "0xD49924")]
		public static bool BIsAppInstalled(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xD49950", Offset = "0xD49950", VA = "0xD49950")]
		public static CSteamID GetAppOwner()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xD499CC", Offset = "0xD499CC", VA = "0xD499CC")]
		public static string GetLaunchQueryParam(string pchKey)
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xD49B00", Offset = "0xD49B00", VA = "0xD49B00")]
		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xD49B44", Offset = "0xD49B44", VA = "0xD49B44")]
		public static int GetAppBuildId()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000124")]
	public static class SteamClient
	{
		[Token(Token = "0x6000417")]
		[Address(RVA = "0xD49B60", Offset = "0xD49B60", VA = "0xD49B60")]
		public static HSteamPipe CreateSteamPipe()
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xD49B8C", Offset = "0xD49B8C", VA = "0xD49B8C")]
		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xD49BB8", Offset = "0xD49BB8", VA = "0xD49BB8")]
		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xD49BF4", Offset = "0xD49BF4", VA = "0xD49BF4")]
		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xD49C38", Offset = "0xD49C38", VA = "0xD49C38")]
		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xD49C6C", Offset = "0xD49C6C", VA = "0xD49C6C")]
		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xD49DA4", Offset = "0xD49DA4", VA = "0xD49DA4")]
		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xD49EDC", Offset = "0xD49EDC", VA = "0xD49EDC")]
		public static void SetLocalIPBinding(uint unIP, ushort usPort)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xD49F10", Offset = "0xD49F10", VA = "0xD49F10")]
		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xD4A048", Offset = "0xD4A048", VA = "0xD4A048")]
		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xD4A178", Offset = "0xD4A178", VA = "0xD4A178")]
		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xD4A2B0", Offset = "0xD4A2B0", VA = "0xD4A2B0")]
		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xD4A3E8", Offset = "0xD4A3E8", VA = "0xD4A3E8")]
		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xD4A520", Offset = "0xD4A520", VA = "0xD4A520")]
		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xD4A658", Offset = "0xD4A658", VA = "0xD4A658")]
		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xD4A790", Offset = "0xD4A790", VA = "0xD4A790")]
		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xD4A8C8", Offset = "0xD4A8C8", VA = "0xD4A8C8")]
		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xD4AA00", Offset = "0xD4AA00", VA = "0xD4AA00")]
		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xD4AB38", Offset = "0xD4AB38", VA = "0xD4AB38")]
		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xD4AC70", Offset = "0xD4AC70", VA = "0xD4AC70")]
		public static void RunFrame()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xD4AC8C", Offset = "0xD4AC8C", VA = "0xD4AC8C")]
		public static uint GetIPCCallCount()
		{
			return default(uint);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xD4ACA8", Offset = "0xD4ACA8", VA = "0xD4ACA8")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xD4ACD4", Offset = "0xD4ACD4", VA = "0xD4ACD4")]
		public static bool BShutdownIfAllPipesClosed()
		{
			return default(bool);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xD4ACF0", Offset = "0xD4ACF0", VA = "0xD4ACF0")]
		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xD4AE28", Offset = "0xD4AE28", VA = "0xD4AE28")]
		public static IntPtr GetISteamUnifiedMessages(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xD4AF60", Offset = "0xD4AF60", VA = "0xD4AF60")]
		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xD4B098", Offset = "0xD4B098", VA = "0xD4B098")]
		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xD4B1D0", Offset = "0xD4B1D0", VA = "0xD4B1D0")]
		public static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xD4B308", Offset = "0xD4B308", VA = "0xD4B308")]
		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xD4B440", Offset = "0xD4B440", VA = "0xD4B440")]
		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xD4B578", Offset = "0xD4B578", VA = "0xD4B578")]
		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xD4B6B0", Offset = "0xD4B6B0", VA = "0xD4B6B0")]
		public static void Set_SteamAPI_CPostAPIResultInProcess(SteamAPI_PostAPIResultInProcess_t func)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xD4B6DC", Offset = "0xD4B6DC", VA = "0xD4B6DC")]
		public static void Remove_SteamAPI_CPostAPIResultInProcess(SteamAPI_PostAPIResultInProcess_t func)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xD4B708", Offset = "0xD4B708", VA = "0xD4B708")]
		public static void Set_SteamAPI_CCheckCallbackRegisteredInProcess(SteamAPI_CheckCallbackRegistered_t func)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xD4B734", Offset = "0xD4B734", VA = "0xD4B734")]
		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xD4B86C", Offset = "0xD4B86C", VA = "0xD4B86C")]
		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x2000125")]
	public static class SteamController
	{
		[Token(Token = "0x600043B")]
		[Address(RVA = "0xD4B9A4", Offset = "0xD4B9A4", VA = "0xD4B9A4")]
		public static bool Init(string pchAbsolutePathToControllerConfigVDF)
		{
			return default(bool);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xD4BACC", Offset = "0xD4BACC", VA = "0xD4BACC")]
		public static bool Shutdown()
		{
			return default(bool);
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xD4BAE8", Offset = "0xD4BAE8", VA = "0xD4BAE8")]
		public static void RunFrame()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xD4BB04", Offset = "0xD4BB04", VA = "0xD4BB04")]
		public static bool GetControllerState(uint unControllerIndex, out SteamControllerState_t pState)
		{
			return default(bool);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xD4BB38", Offset = "0xD4BB38", VA = "0xD4BB38")]
		public static void TriggerHapticPulse(uint unControllerIndex, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xD4BB7C", Offset = "0xD4BB7C", VA = "0xD4BB7C")]
		public static void SetOverrideMode(string pchMode)
		{
		}
	}
	[Token(Token = "0x2000126")]
	public static class SteamFriends
	{
		[Token(Token = "0x6000441")]
		[Address(RVA = "0xD4BF2C", Offset = "0xD4BF2C", VA = "0xD4BF2C")]
		public static string GetPersonaName()
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xD4BF50", Offset = "0xD4BF50", VA = "0xD4BF50")]
		public static SteamAPICall_t SetPersonaName(string pchPersonaName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xD4C098", Offset = "0xD4C098", VA = "0xD4C098")]
		public static EPersonaState GetPersonaState()
		{
			return default(EPersonaState);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xD4C0B4", Offset = "0xD4C0B4", VA = "0xD4C0B4")]
		public static int GetFriendCount(EFriendFlags iFriendFlags)
		{
			return default(int);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xD4C0E0", Offset = "0xD4C0E0", VA = "0xD4C0E0")]
		public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xD4C174", Offset = "0xD4C174", VA = "0xD4C174")]
		public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend)
		{
			return default(EFriendRelationship);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xD4C1A0", Offset = "0xD4C1A0", VA = "0xD4C1A0")]
		public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend)
		{
			return default(EPersonaState);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xD4C1CC", Offset = "0xD4C1CC", VA = "0xD4C1CC")]
		public static string GetFriendPersonaName(CSteamID steamIDFriend)
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xD4C200", Offset = "0xD4C200", VA = "0xD4C200")]
		public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xD4C234", Offset = "0xD4C234", VA = "0xD4C234")]
		public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName)
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xD4C270", Offset = "0xD4C270", VA = "0xD4C270")]
		public static int GetFriendSteamLevel(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xD4C29C", Offset = "0xD4C29C", VA = "0xD4C29C")]
		public static string GetPlayerNickname(CSteamID steamIDPlayer)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xD4C2D0", Offset = "0xD4C2D0", VA = "0xD4C2D0")]
		public static int GetFriendsGroupCount()
		{
			return default(int);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xD4C2EC", Offset = "0xD4C2EC", VA = "0xD4C2EC")]
		public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG)
		{
			return default(FriendsGroupID_t);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xD4C378", Offset = "0xD4C378", VA = "0xD4C378")]
		public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID)
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xD4C3AC", Offset = "0xD4C3AC", VA = "0xD4C3AC")]
		public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID)
		{
			return default(int);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xD4C3D8", Offset = "0xD4C3D8", VA = "0xD4C3D8")]
		public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xD4C41C", Offset = "0xD4C41C", VA = "0xD4C41C")]
		public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xD4C450", Offset = "0xD4C450", VA = "0xD4C450")]
		public static int GetClanCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xD4C46C", Offset = "0xD4C46C", VA = "0xD4C46C")]
		public static CSteamID GetClanByIndex(int iClan)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xD4C4F0", Offset = "0xD4C4F0", VA = "0xD4C4F0")]
		public static string GetClanName(CSteamID steamIDClan)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xD4C524", Offset = "0xD4C524", VA = "0xD4C524")]
		public static string GetClanTag(CSteamID steamIDClan)
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xD4C558", Offset = "0xD4C558", VA = "0xD4C558")]
		public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting)
		{
			return default(bool);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xD4C5A4", Offset = "0xD4C5A4", VA = "0xD4C5A4")]
		public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xD4C634", Offset = "0xD4C634", VA = "0xD4C634")]
		public static int GetFriendCountFromSource(CSteamID steamIDSource)
		{
			return default(int);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xD4C660", Offset = "0xD4C660", VA = "0xD4C660")]
		public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xD4C6F4", Offset = "0xD4C6F4", VA = "0xD4C6F4")]
		public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource)
		{
			return default(bool);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xD4C728", Offset = "0xD4C728", VA = "0xD4C728")]
		public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xD4C75C", Offset = "0xD4C75C", VA = "0xD4C75C")]
		public static void ActivateGameOverlay(string pchDialog)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xD4C870", Offset = "0xD4C870", VA = "0xD4C870")]
		public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xD4C994", Offset = "0xD4C994", VA = "0xD4C994")]
		public static void ActivateGameOverlayToWebPage(string pchURL)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xD4CAA8", Offset = "0xD4CAA8", VA = "0xD4CAA8")]
		public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xD4CADC", Offset = "0xD4CADC", VA = "0xD4CADC")]
		public static void SetPlayedWith(CSteamID steamIDUserPlayedWith)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xD4CB08", Offset = "0xD4CB08", VA = "0xD4CB08")]
		public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xD4CB34", Offset = "0xD4CB34", VA = "0xD4CB34")]
		public static int GetSmallFriendAvatar(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xD4CB60", Offset = "0xD4CB60", VA = "0xD4CB60")]
		public static int GetMediumFriendAvatar(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xD4CB8C", Offset = "0xD4CB8C", VA = "0xD4CB8C")]
		public static int GetLargeFriendAvatar(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xD4CBB8", Offset = "0xD4CBB8", VA = "0xD4CBB8")]
		public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xD4CBEC", Offset = "0xD4CBEC", VA = "0xD4CBEC")]
		public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xD4CC6C", Offset = "0xD4CC6C", VA = "0xD4CC6C")]
		public static CSteamID GetClanOwner(CSteamID steamIDClan)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xD4CCF0", Offset = "0xD4CCF0", VA = "0xD4CCF0")]
		public static int GetClanOfficerCount(CSteamID steamIDClan)
		{
			return default(int);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xD4CD1C", Offset = "0xD4CD1C", VA = "0xD4CD1C")]
		public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xD4CDB0", Offset = "0xD4CDB0", VA = "0xD4CDB0")]
		public static uint GetUserRestrictions()
		{
			return default(uint);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xD4CDCC", Offset = "0xD4CDCC", VA = "0xD4CDCC")]
		public static bool SetRichPresence(string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xD4CFCC", Offset = "0xD4CFCC", VA = "0xD4CFCC")]
		public static void ClearRichPresence()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xD4CFE8", Offset = "0xD4CFE8", VA = "0xD4CFE8")]
		public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xD4D124", Offset = "0xD4D124", VA = "0xD4D124")]
		public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xD4D150", Offset = "0xD4D150", VA = "0xD4D150")]
		public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey)
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xD4D18C", Offset = "0xD4D18C", VA = "0xD4D18C")]
		public static void RequestFriendRichPresence(CSteamID steamIDFriend)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xD4D1B8", Offset = "0xD4D1B8", VA = "0xD4D1B8")]
		public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString)
		{
			return default(bool);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xD4D2E8", Offset = "0xD4D2E8", VA = "0xD4D2E8")]
		public static int GetCoplayFriendCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xD4D304", Offset = "0xD4D304", VA = "0xD4D304")]
		public static CSteamID GetCoplayFriend(int iCoplayFriend)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xD4D388", Offset = "0xD4D388", VA = "0xD4D388")]
		public static int GetFriendCoplayTime(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xD4D3B4", Offset = "0xD4D3B4", VA = "0xD4D3B4")]
		public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend)
		{
			return default(AppId_t);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xD4D440", Offset = "0xD4D440", VA = "0xD4D440")]
		public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xD4D4C0", Offset = "0xD4D4C0", VA = "0xD4D4C0")]
		public static bool LeaveClanChatRoom(CSteamID steamIDClan)
		{
			return default(bool);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xD4D4EC", Offset = "0xD4D4EC", VA = "0xD4D4EC")]
		public static int GetClanChatMemberCount(CSteamID steamIDClan)
		{
			return default(int);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xD4D518", Offset = "0xD4D518", VA = "0xD4D518")]
		public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xD4D5AC", Offset = "0xD4D5AC", VA = "0xD4D5AC")]
		public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText)
		{
			return default(bool);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xD4D6DC", Offset = "0xD4D6DC", VA = "0xD4D6DC")]
		public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter)
		{
			return default(int);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xD4D7E8", Offset = "0xD4D7E8", VA = "0xD4D7E8")]
		public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser)
		{
			return default(bool);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xD4D81C", Offset = "0xD4D81C", VA = "0xD4D81C")]
		public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xD4D848", Offset = "0xD4D848", VA = "0xD4D848")]
		public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xD4D874", Offset = "0xD4D874", VA = "0xD4D874")]
		public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xD4D8A0", Offset = "0xD4D8A0", VA = "0xD4D8A0")]
		public static bool SetListenForFriendsMessages(bool bInterceptEnabled)
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xD4D8CC", Offset = "0xD4D8CC", VA = "0xD4D8CC")]
		public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend)
		{
			return default(bool);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xD4D9FC", Offset = "0xD4D9FC", VA = "0xD4D9FC")]
		public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			return default(int);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xD4DB00", Offset = "0xD4DB00", VA = "0xD4DB00")]
		public static SteamAPICall_t GetFollowerCount(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xD4DB80", Offset = "0xD4DB80", VA = "0xD4DB80")]
		public static SteamAPICall_t IsFollowing(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xD4DC00", Offset = "0xD4DC00", VA = "0xD4DC00")]
		public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000127")]
	public static class SteamGameServer
	{
		[Token(Token = "0x6000487")]
		[Address(RVA = "0xD4DC80", Offset = "0xD4DC80", VA = "0xD4DC80")]
		public static bool InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, string pchVersionString)
		{
			return default(bool);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xD4DDE0", Offset = "0xD4DDE0", VA = "0xD4DDE0")]
		public static void SetProduct(string pszProduct)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xD4DEF4", Offset = "0xD4DEF4", VA = "0xD4DEF4")]
		public static void SetGameDescription(string pszGameDescription)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xD4E008", Offset = "0xD4E008", VA = "0xD4E008")]
		public static void SetModDir(string pszModDir)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xD4E11C", Offset = "0xD4E11C", VA = "0xD4E11C")]
		public static void SetDedicatedServer(bool bDedicated)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xD4E148", Offset = "0xD4E148", VA = "0xD4E148")]
		public static void LogOn(string pszToken)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xD4E25C", Offset = "0xD4E25C", VA = "0xD4E25C")]
		public static void LogOnAnonymous()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xD4E278", Offset = "0xD4E278", VA = "0xD4E278")]
		public static void LogOff()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xD4E294", Offset = "0xD4E294", VA = "0xD4E294")]
		public static bool BLoggedOn()
		{
			return default(bool);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xD4E2B0", Offset = "0xD4E2B0", VA = "0xD4E2B0")]
		public static bool BSecure()
		{
			return default(bool);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xD4E2CC", Offset = "0xD4E2CC", VA = "0xD4E2CC")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xD4E348", Offset = "0xD4E348", VA = "0xD4E348")]
		public static bool WasRestartRequested()
		{
			return default(bool);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xD4E364", Offset = "0xD4E364", VA = "0xD4E364")]
		public static void SetMaxPlayerCount(int cPlayersMax)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xD4E390", Offset = "0xD4E390", VA = "0xD4E390")]
		public static void SetBotPlayerCount(int cBotplayers)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xD4E3BC", Offset = "0xD4E3BC", VA = "0xD4E3BC")]
		public static void SetServerName(string pszServerName)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xD4E4D0", Offset = "0xD4E4D0", VA = "0xD4E4D0")]
		public static void SetMapName(string pszMapName)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xD4E5E4", Offset = "0xD4E5E4", VA = "0xD4E5E4")]
		public static void SetPasswordProtected(bool bPasswordProtected)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xD4E610", Offset = "0xD4E610", VA = "0xD4E610")]
		public static void SetSpectatorPort(ushort unSpectatorPort)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xD4E63C", Offset = "0xD4E63C", VA = "0xD4E63C")]
		public static void SetSpectatorServerName(string pszSpectatorServerName)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xD4E750", Offset = "0xD4E750", VA = "0xD4E750")]
		public static void ClearAllKeyValues()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xD4E76C", Offset = "0xD4E76C", VA = "0xD4E76C")]
		public static void SetKeyValue(string pKey, string pValue)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xD4E94C", Offset = "0xD4E94C", VA = "0xD4E94C")]
		public static void SetGameTags(string pchGameTags)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xD4EA60", Offset = "0xD4EA60", VA = "0xD4EA60")]
		public static void SetGameData(string pchGameData)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xD4EB74", Offset = "0xD4EB74", VA = "0xD4EB74")]
		public static void SetRegion(string pszRegion)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xD4EC88", Offset = "0xD4EC88", VA = "0xD4EC88")]
		public static bool SendUserConnectAndAuthenticate(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xD4ECD4", Offset = "0xD4ECD4", VA = "0xD4ECD4")]
		public static CSteamID CreateUnauthenticatedUserConnection()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xD4ED50", Offset = "0xD4ED50", VA = "0xD4ED50")]
		public static void SendUserDisconnect(CSteamID steamIDUser)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xD4ED7C", Offset = "0xD4ED7C", VA = "0xD4ED7C")]
		public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xD4EEB4", Offset = "0xD4EEB4", VA = "0xD4EEB4")]
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(HAuthTicket);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xD4EF58", Offset = "0xD4EF58", VA = "0xD4EF58")]
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			return default(EBeginAuthSessionResult);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xD4EF9C", Offset = "0xD4EF9C", VA = "0xD4EF9C")]
		public static void EndAuthSession(CSteamID steamID)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xD4EFC8", Offset = "0xD4EFC8", VA = "0xD4EFC8")]
		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xD4EFF4", Offset = "0xD4EFF4", VA = "0xD4EFF4")]
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			return default(EUserHasLicenseForAppResult);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xD4F028", Offset = "0xD4F028", VA = "0xD4F028")]
		public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xD4F05C", Offset = "0xD4F05C", VA = "0xD4F05C")]
		public static void GetGameplayStats()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xD4F078", Offset = "0xD4F078", VA = "0xD4F078")]
		public static SteamAPICall_t GetServerReputation()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xD4F0F0", Offset = "0xD4F0F0", VA = "0xD4F0F0")]
		public static uint GetPublicIP()
		{
			return default(uint);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xD4F10C", Offset = "0xD4F10C", VA = "0xD4F10C")]
		public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xD4F158", Offset = "0xD4F158", VA = "0xD4F158")]
		public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort)
		{
			return default(int);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xD4F1A4", Offset = "0xD4F1A4", VA = "0xD4F1A4")]
		public static void EnableHeartbeats(bool bActive)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xD4F1D0", Offset = "0xD4F1D0", VA = "0xD4F1D0")]
		public static void SetHeartbeatInterval(int iHeartbeatInterval)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xD4F1FC", Offset = "0xD4F1FC", VA = "0xD4F1FC")]
		public static void ForceHeartbeat()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xD4F218", Offset = "0xD4F218", VA = "0xD4F218")]
		public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xD4F298", Offset = "0xD4F298", VA = "0xD4F298")]
		public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000128")]
	public static class SteamGameServerHTTP
	{
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xD4F318", Offset = "0xD4F318", VA = "0xD4F318")]
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			return default(HTTPRequestHandle);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xD4F47C", Offset = "0xD4F47C", VA = "0xD4F47C")]
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xD4F4B0", Offset = "0xD4F4B0", VA = "0xD4F4B0")]
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xD4F4E4", Offset = "0xD4F4E4", VA = "0xD4F4E4")]
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xD4F6F4", Offset = "0xD4F6F4", VA = "0xD4F6F4")]
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xD4F904", Offset = "0xD4F904", VA = "0xD4F904")]
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xD4F938", Offset = "0xD4F938", VA = "0xD4F938")]
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xD4F96C", Offset = "0xD4F96C", VA = "0xD4F96C")]
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xD4F998", Offset = "0xD4F998", VA = "0xD4F998")]
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xD4F9C4", Offset = "0xD4F9C4", VA = "0xD4F9C4")]
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xD4FAFC", Offset = "0xD4FAFC", VA = "0xD4FAFC")]
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xD4FC44", Offset = "0xD4FC44", VA = "0xD4FC44")]
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xD4FC78", Offset = "0xD4FC78", VA = "0xD4FC78")]
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xD4FCBC", Offset = "0xD4FCBC", VA = "0xD4FCBC")]
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xD4FD08", Offset = "0xD4FD08", VA = "0xD4FD08")]
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xD4FD34", Offset = "0xD4FD34", VA = "0xD4FD34")]
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xD4FD68", Offset = "0xD4FD68", VA = "0xD4FD68")]
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xD4FEB0", Offset = "0xD4FEB0", VA = "0xD4FEB0")]
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			return default(HTTPCookieContainerHandle);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xD4FF3C", Offset = "0xD4FF3C", VA = "0xD4FF3C")]
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xD4FF68", Offset = "0xD4FF68", VA = "0xD4FF68")]
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xD50250", Offset = "0xD50250", VA = "0xD50250")]
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xD50284", Offset = "0xD50284", VA = "0xD50284")]
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xD503B4", Offset = "0xD503B4", VA = "0xD503B4")]
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xD503E8", Offset = "0xD503E8", VA = "0xD503E8")]
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xD5041C", Offset = "0xD5041C", VA = "0xD5041C")]
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000129")]
	public static class SteamGameServerInventory
	{
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xD50450", Offset = "0xD50450", VA = "0xD50450")]
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			return default(EResult);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xD5047C", Offset = "0xD5047C", VA = "0xD5047C")]
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xD504C0", Offset = "0xD504C0", VA = "0xD504C0")]
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			return default(uint);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xD504EC", Offset = "0xD504EC", VA = "0xD504EC")]
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xD50520", Offset = "0xD50520", VA = "0xD50520")]
		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xD5054C", Offset = "0xD5054C", VA = "0xD5054C")]
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xD50578", Offset = "0xD50578", VA = "0xD50578")]
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xD505BC", Offset = "0xD505BC", VA = "0xD505BC")]
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xD50600", Offset = "0xD50600", VA = "0xD50600")]
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xD5064C", Offset = "0xD5064C", VA = "0xD5064C")]
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xD50698", Offset = "0xD50698", VA = "0xD50698")]
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xD506C4", Offset = "0xD506C4", VA = "0xD506C4")]
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xD506F8", Offset = "0xD506F8", VA = "0xD506F8")]
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xD5073C", Offset = "0xD5073C", VA = "0xD5073C")]
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xD50780", Offset = "0xD50780", VA = "0xD50780")]
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xD507F4", Offset = "0xD507F4", VA = "0xD507F4")]
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xD50840", Offset = "0xD50840", VA = "0xD50840")]
		public static void SendItemDropHeartbeat()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xD5085C", Offset = "0xD5085C", VA = "0xD5085C")]
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xD50890", Offset = "0xD50890", VA = "0xD50890")]
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xD5090C", Offset = "0xD5090C", VA = "0xD5090C")]
		public static bool LoadItemDefinitions()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xD50928", Offset = "0xD50928", VA = "0xD50928")]
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xD5095C", Offset = "0xD5095C", VA = "0xD5095C")]
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200012A")]
	public static class SteamGameServerNetworking
	{
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xD50B2C", Offset = "0xD50B2C", VA = "0xD50B2C")]
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xD50B88", Offset = "0xD50B88", VA = "0xD50B88")]
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xD50BBC", Offset = "0xD50BBC", VA = "0xD50BBC")]
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xD50C18", Offset = "0xD50C18", VA = "0xD50C18")]
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xD50C44", Offset = "0xD50C44", VA = "0xD50C44")]
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xD50C70", Offset = "0xD50C70", VA = "0xD50C70")]
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xD50CA4", Offset = "0xD50CA4", VA = "0xD50CA4")]
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xD50CD8", Offset = "0xD50CD8", VA = "0xD50CD8")]
		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xD50D04", Offset = "0xD50D04", VA = "0xD50D04")]
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			return default(SNetListenSocket_t);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xD50D58", Offset = "0xD50D58", VA = "0xD50D58")]
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xD50DAC", Offset = "0xD50DAC", VA = "0xD50DAC")]
		public static SNetSocket_t CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xD50DF8", Offset = "0xD50DF8", VA = "0xD50DF8")]
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xD50E2C", Offset = "0xD50E2C", VA = "0xD50E2C")]
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xD50E60", Offset = "0xD50E60", VA = "0xD50E60")]
		public static bool SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, bool bReliable)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xD50EAC", Offset = "0xD50EAC", VA = "0xD50EAC")]
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xD50EE0", Offset = "0xD50EE0", VA = "0xD50EE0")]
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xD50F2C", Offset = "0xD50F2C", VA = "0xD50F2C")]
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xD50F70", Offset = "0xD50F70", VA = "0xD50F70")]
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xD50FCC", Offset = "0xD50FCC", VA = "0xD50FCC")]
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xD51028", Offset = "0xD51028", VA = "0xD51028")]
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xD5106C", Offset = "0xD5106C", VA = "0xD5106C")]
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			return default(ESNetSocketConnectionType);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xD51098", Offset = "0xD51098", VA = "0xD51098")]
		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200012B")]
	public static class SteamGameServerStats
	{
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xD510C4", Offset = "0xD510C4", VA = "0xD510C4")]
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xD51144", Offset = "0xD51144", VA = "0xD51144")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xD5127C", Offset = "0xD5127C", VA = "0xD5127C")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xD513B4", Offset = "0xD513B4", VA = "0xD513B4")]
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xD514EC", Offset = "0xD514EC", VA = "0xD514EC")]
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xD51624", Offset = "0xD51624", VA = "0xD51624")]
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xD51764", Offset = "0xD51764", VA = "0xD51764")]
		public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xD518AC", Offset = "0xD518AC", VA = "0xD518AC")]
		public static bool SetUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xD519DC", Offset = "0xD519DC", VA = "0xD519DC")]
		public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xD51B0C", Offset = "0xD51B0C", VA = "0xD51B0C")]
		public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x200012C")]
	public static class SteamGameServerUGC
	{
		[Token(Token = "0x6000502")]
		[Address(RVA = "0xD51B8C", Offset = "0xD51B8C", VA = "0xD51B8C")]
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xD51C58", Offset = "0xD51C58", VA = "0xD51C58")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xD51D0C", Offset = "0xD51D0C", VA = "0xD51D0C")]
		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xD51DA0", Offset = "0xD51DA0", VA = "0xD51DA0")]
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xD51E20", Offset = "0xD51E20", VA = "0xD51E20")]
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xD51E64", Offset = "0xD51E64", VA = "0xD51E64")]
		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xD51F54", Offset = "0xD51F54", VA = "0xD51F54")]
		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xD52044", Offset = "0xD52044", VA = "0xD52044")]
		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xD52090", Offset = "0xD52090", VA = "0xD52090")]
		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out uint pStatValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xD520DC", Offset = "0xD520DC", VA = "0xD520DC")]
		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			return default(uint);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xD52110", Offset = "0xD52110", VA = "0xD52110")]
		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out bool pbIsImage)
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xD52218", Offset = "0xD52218", VA = "0xD52218")]
		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			return default(uint);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xD5224C", Offset = "0xD5224C", VA = "0xD5224C")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xD523B0", Offset = "0xD523B0", VA = "0xD523B0")]
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xD523DC", Offset = "0xD523DC", VA = "0xD523DC")]
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xD5250C", Offset = "0xD5250C", VA = "0xD5250C")]
		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xD5263C", Offset = "0xD5263C", VA = "0xD5263C")]
		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xD52670", Offset = "0xD52670", VA = "0xD52670")]
		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xD526A4", Offset = "0xD526A4", VA = "0xD526A4")]
		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xD526D8", Offset = "0xD526D8", VA = "0xD526D8")]
		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			return default(bool);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xD5270C", Offset = "0xD5270C", VA = "0xD5270C")]
		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			return default(bool);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xD52740", Offset = "0xD52740", VA = "0xD52740")]
		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xD52774", Offset = "0xD52774", VA = "0xD52774")]
		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xD528A4", Offset = "0xD528A4", VA = "0xD528A4")]
		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xD528D8", Offset = "0xD528D8", VA = "0xD528D8")]
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			return default(bool);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xD52A08", Offset = "0xD52A08", VA = "0xD52A08")]
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xD52A3C", Offset = "0xD52A3C", VA = "0xD52A3C")]
		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			return default(bool);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xD52B6C", Offset = "0xD52B6C", VA = "0xD52B6C")]
		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xD52BA0", Offset = "0xD52BA0", VA = "0xD52BA0")]
		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xD52DB0", Offset = "0xD52DB0", VA = "0xD52DB0")]
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xD52E40", Offset = "0xD52E40", VA = "0xD52E40")]
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xD52ED0", Offset = "0xD52ED0", VA = "0xD52ED0")]
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(UGCUpdateHandle_t);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xD52F64", Offset = "0xD52F64", VA = "0xD52F64")]
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xD53094", Offset = "0xD53094", VA = "0xD53094")]
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xD531C4", Offset = "0xD531C4", VA = "0xD531C4")]
		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xD532F4", Offset = "0xD532F4", VA = "0xD532F4")]
		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xD53424", Offset = "0xD53424", VA = "0xD53424")]
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xD53458", Offset = "0xD53458", VA = "0xD53458")]
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xD534E0", Offset = "0xD534E0", VA = "0xD534E0")]
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xD53610", Offset = "0xD53610", VA = "0xD53610")]
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xD53740", Offset = "0xD53740", VA = "0xD53740")]
		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xD53870", Offset = "0xD53870", VA = "0xD53870")]
		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xD53A80", Offset = "0xD53A80", VA = "0xD53A80")]
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xD53BD0", Offset = "0xD53BD0", VA = "0xD53BD0")]
		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			return default(EItemUpdateStatus);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xD53C14", Offset = "0xD53C14", VA = "0xD53C14")]
		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xD53CA4", Offset = "0xD53CA4", VA = "0xD53CA4")]
		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xD53D24", Offset = "0xD53D24", VA = "0xD53D24")]
		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xD53DB4", Offset = "0xD53DB4", VA = "0xD53DB4")]
		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xD53E44", Offset = "0xD53E44", VA = "0xD53E44")]
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xD53EC4", Offset = "0xD53EC4", VA = "0xD53EC4")]
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xD53F44", Offset = "0xD53F44", VA = "0xD53F44")]
		public static uint GetNumSubscribedItems()
		{
			return default(uint);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xD53F60", Offset = "0xD53F60", VA = "0xD53F60")]
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(uint);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xD53F94", Offset = "0xD53F94", VA = "0xD53F94")]
		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			return default(uint);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xD53FC0", Offset = "0xD53FC0", VA = "0xD53FC0")]
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xD540C0", Offset = "0xD540C0", VA = "0xD540C0")]
		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xD54104", Offset = "0xD54104", VA = "0xD54104")]
		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200012D")]
	public static class SteamGameServerUtils
	{
		[Token(Token = "0x600053A")]
		[Address(RVA = "0xD54138", Offset = "0xD54138", VA = "0xD54138")]
		public static uint GetSecondsSinceAppActive()
		{
			return default(uint);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xD54154", Offset = "0xD54154", VA = "0xD54154")]
		public static uint GetSecondsSinceComputerActive()
		{
			return default(uint);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xD54170", Offset = "0xD54170", VA = "0xD54170")]
		public static EUniverse GetConnectedUniverse()
		{
			return default(EUniverse);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xD5418C", Offset = "0xD5418C", VA = "0xD5418C")]
		public static uint GetServerRealTime()
		{
			return default(uint);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xD541A8", Offset = "0xD541A8", VA = "0xD541A8")]
		public static string GetIPCountry()
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xD541CC", Offset = "0xD541CC", VA = "0xD541CC")]
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			return default(bool);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xD54210", Offset = "0xD54210", VA = "0xD54210")]
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xD54254", Offset = "0xD54254", VA = "0xD54254")]
		public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
		{
			return default(bool);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xD54288", Offset = "0xD54288", VA = "0xD54288")]
		public static byte GetCurrentBatteryPower()
		{
			return default(byte);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xD542A4", Offset = "0xD542A4", VA = "0xD542A4")]
		public static AppId_t GetAppID()
		{
			return default(AppId_t);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xD54328", Offset = "0xD54328", VA = "0xD54328")]
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xD54354", Offset = "0xD54354", VA = "0xD54354")]
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xD54388", Offset = "0xD54388", VA = "0xD54388")]
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return default(ESteamAPICallFailure);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xD543B4", Offset = "0xD543B4", VA = "0xD543B4")]
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xD54410", Offset = "0xD54410", VA = "0xD54410")]
		public static void RunFrame()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xD5442C", Offset = "0xD5442C", VA = "0xD5442C")]
		public static uint GetIPCCallCount()
		{
			return default(uint);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xD54448", Offset = "0xD54448", VA = "0xD54448")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xD54474", Offset = "0xD54474", VA = "0xD54474")]
		public static bool IsOverlayEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xD54490", Offset = "0xD54490", VA = "0xD54490")]
		public static bool BOverlayNeedsPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xD544AC", Offset = "0xD544AC", VA = "0xD544AC")]
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xD545F4", Offset = "0xD545F4", VA = "0xD545F4")]
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return default(bool);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xD5481C", Offset = "0xD5481C", VA = "0xD5481C")]
		public static uint GetEnteredGamepadTextLength()
		{
			return default(uint);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xD54838", Offset = "0xD54838", VA = "0xD54838")]
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			return default(bool);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xD5490C", Offset = "0xD5490C", VA = "0xD5490C")]
		public static string GetSteamUILanguage()
		{
			return null;
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xD54930", Offset = "0xD54930", VA = "0xD54930")]
		public static bool IsSteamRunningInVR()
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xD5494C", Offset = "0xD5494C", VA = "0xD5494C")]
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
		}
	}
	[Token(Token = "0x200012E")]
	public static class SteamHTMLSurface
	{
		[Token(Token = "0x6000554")]
		[Address(RVA = "0xD54980", Offset = "0xD54980", VA = "0xD54980")]
		public static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xD5499C", Offset = "0xD5499C", VA = "0xD5499C")]
		public static bool Shutdown()
		{
			return default(bool);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xD549B8", Offset = "0xD549B8", VA = "0xD549B8")]
		public static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xD54BCC", Offset = "0xD54BCC", VA = "0xD54BCC")]
		public static void RemoveBrowser(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xD54BF8", Offset = "0xD54BF8", VA = "0xD54BF8")]
		public static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xD54DE8", Offset = "0xD54DE8", VA = "0xD54DE8")]
		public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xD54E2C", Offset = "0xD54E2C", VA = "0xD54E2C")]
		public static void StopLoad(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xD54E58", Offset = "0xD54E58", VA = "0xD54E58")]
		public static void Reload(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xD54E84", Offset = "0xD54E84", VA = "0xD54E84")]
		public static void GoBack(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xD54EB0", Offset = "0xD54EB0", VA = "0xD54EB0")]
		public static void GoForward(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xD54EDC", Offset = "0xD54EDC", VA = "0xD54EDC")]
		public static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xD550CC", Offset = "0xD550CC", VA = "0xD550CC")]
		public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xD551F0", Offset = "0xD551F0", VA = "0xD551F0")]
		public static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xD55224", Offset = "0xD55224", VA = "0xD55224")]
		public static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xD55258", Offset = "0xD55258", VA = "0xD55258")]
		public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xD5528C", Offset = "0xD5528C", VA = "0xD5528C")]
		public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xD552D0", Offset = "0xD552D0", VA = "0xD552D0")]
		public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xD55304", Offset = "0xD55304", VA = "0xD55304")]
		public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xD55348", Offset = "0xD55348", VA = "0xD55348")]
		public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xD5538C", Offset = "0xD5538C", VA = "0xD5538C")]
		public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xD553D0", Offset = "0xD553D0", VA = "0xD553D0")]
		public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xD55404", Offset = "0xD55404", VA = "0xD55404")]
		public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xD55438", Offset = "0xD55438", VA = "0xD55438")]
		public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xD5546C", Offset = "0xD5546C", VA = "0xD5546C")]
		public static void ViewSource(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xD55498", Offset = "0xD55498", VA = "0xD55498")]
		public static void CopyToClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xD554C4", Offset = "0xD554C4", VA = "0xD554C4")]
		public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xD554F0", Offset = "0xD554F0", VA = "0xD554F0")]
		public static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xD5562C", Offset = "0xD5562C", VA = "0xD5562C")]
		public static void StopFind(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xD55658", Offset = "0xD55658", VA = "0xD55658")]
		public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xD5569C", Offset = "0xD5569C", VA = "0xD5569C")]
		public static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0u, bool bSecure = false, bool bHTTPOnly = false)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xD55A34", Offset = "0xD55A34", VA = "0xD55A34")]
		public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xD55A88", Offset = "0xD55A88", VA = "0xD55A88")]
		public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xD55ABC", Offset = "0xD55ABC", VA = "0xD55ABC")]
		public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xD55AF0", Offset = "0xD55AF0", VA = "0xD55AF0")]
		public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xD55B24", Offset = "0xD55B24", VA = "0xD55B24")]
		public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles)
		{
		}
	}
	[Token(Token = "0x200012F")]
	public static class SteamHTTP
	{
		[Token(Token = "0x6000577")]
		[Address(RVA = "0xD55B58", Offset = "0xD55B58", VA = "0xD55B58")]
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			return default(HTTPRequestHandle);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xD55CBC", Offset = "0xD55CBC", VA = "0xD55CBC")]
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xD55CF0", Offset = "0xD55CF0", VA = "0xD55CF0")]
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xD55D24", Offset = "0xD55D24", VA = "0xD55D24")]
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xD55F34", Offset = "0xD55F34", VA = "0xD55F34")]
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xD56144", Offset = "0xD56144", VA = "0xD56144")]
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xD56178", Offset = "0xD56178", VA = "0xD56178")]
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xD561AC", Offset = "0xD561AC", VA = "0xD561AC")]
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xD561D8", Offset = "0xD561D8", VA = "0xD561D8")]
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xD56204", Offset = "0xD56204", VA = "0xD56204")]
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xD5633C", Offset = "0xD5633C", VA = "0xD5633C")]
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xD56484", Offset = "0xD56484", VA = "0xD56484")]
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xD564B8", Offset = "0xD564B8", VA = "0xD564B8")]
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xD564FC", Offset = "0xD564FC", VA = "0xD564FC")]
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xD56548", Offset = "0xD56548", VA = "0xD56548")]
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xD56574", Offset = "0xD56574", VA = "0xD56574")]
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xD565A8", Offset = "0xD565A8", VA = "0xD565A8")]
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xD566F0", Offset = "0xD566F0", VA = "0xD566F0")]
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			return default(HTTPCookieContainerHandle);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xD5677C", Offset = "0xD5677C", VA = "0xD5677C")]
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xD567A8", Offset = "0xD567A8", VA = "0xD567A8")]
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			return default(bool);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xD56A90", Offset = "0xD56A90", VA = "0xD56A90")]
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xD56AC4", Offset = "0xD56AC4", VA = "0xD56AC4")]
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xD56BF4", Offset = "0xD56BF4", VA = "0xD56BF4")]
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			return default(bool);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xD56C28", Offset = "0xD56C28", VA = "0xD56C28")]
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			return default(bool);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xD56C5C", Offset = "0xD56C5C", VA = "0xD56C5C")]
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000130")]
	public static class SteamInventory
	{
		[Token(Token = "0x6000590")]
		[Address(RVA = "0xD56C90", Offset = "0xD56C90", VA = "0xD56C90")]
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			return default(EResult);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xD56CBC", Offset = "0xD56CBC", VA = "0xD56CBC")]
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xD56D00", Offset = "0xD56D00", VA = "0xD56D00")]
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			return default(uint);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xD56D2C", Offset = "0xD56D2C", VA = "0xD56D2C")]
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			return default(bool);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xD56D60", Offset = "0xD56D60", VA = "0xD56D60")]
		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xD56D8C", Offset = "0xD56D8C", VA = "0xD56D8C")]
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xD56DB8", Offset = "0xD56DB8", VA = "0xD56DB8")]
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xD56DFC", Offset = "0xD56DFC", VA = "0xD56DFC")]
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xD56E40", Offset = "0xD56E40", VA = "0xD56E40")]
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xD56E8C", Offset = "0xD56E8C", VA = "0xD56E8C")]
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xD56ED8", Offset = "0xD56ED8", VA = "0xD56ED8")]
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xD56F04", Offset = "0xD56F04", VA = "0xD56F04")]
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			return default(bool);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xD56F38", Offset = "0xD56F38", VA = "0xD56F38")]
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xD56F7C", Offset = "0xD56F7C", VA = "0xD56F7C")]
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			return default(bool);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xD56FC0", Offset = "0xD56FC0", VA = "0xD56FC0")]
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			return default(bool);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xD57034", Offset = "0xD57034", VA = "0xD57034")]
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xD57080", Offset = "0xD57080", VA = "0xD57080")]
		public static void SendItemDropHeartbeat()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xD5709C", Offset = "0xD5709C", VA = "0xD5709C")]
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xD570D0", Offset = "0xD570D0", VA = "0xD570D0")]
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xD5714C", Offset = "0xD5714C", VA = "0xD5714C")]
		public static bool LoadItemDefinitions()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xD57168", Offset = "0xD57168", VA = "0xD57168")]
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xD5719C", Offset = "0xD5719C", VA = "0xD5719C")]
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000131")]
	public static class SteamMatchmaking
	{
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xD57994", Offset = "0xD57994", VA = "0xD57994")]
		public static int GetFavoriteGameCount()
		{
			return default(int);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xD579B0", Offset = "0xD579B0", VA = "0xD579B0")]
		public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xD57A24", Offset = "0xD57A24", VA = "0xD57A24")]
		public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
		{
			return default(int);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xD57A88", Offset = "0xD57A88", VA = "0xD57A88")]
		public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xD57AE4", Offset = "0xD57AE4", VA = "0xD57AE4")]
		public static SteamAPICall_t RequestLobbyList()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xD57B5C", Offset = "0xD57B5C", VA = "0xD57B5C")]
		public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xD57D4C", Offset = "0xD57D4C", VA = "0xD57D4C")]
		public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xD57E78", Offset = "0xD57E78", VA = "0xD57E78")]
		public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xD57F9C", Offset = "0xD57F9C", VA = "0xD57F9C")]
		public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xD57FC8", Offset = "0xD57FC8", VA = "0xD57FC8")]
		public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xD57FF4", Offset = "0xD57FF4", VA = "0xD57FF4")]
		public static void AddRequestLobbyListResultCountFilter(int cMaxResults)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xD58020", Offset = "0xD58020", VA = "0xD58020")]
		public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xD5804C", Offset = "0xD5804C", VA = "0xD5804C")]
		public static CSteamID GetLobbyByIndex(int iLobby)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xD580D0", Offset = "0xD580D0", VA = "0xD580D0")]
		public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xD58160", Offset = "0xD58160", VA = "0xD58160")]
		public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xD581E0", Offset = "0xD581E0", VA = "0xD581E0")]
		public static void LeaveLobby(CSteamID steamIDLobby)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xD5820C", Offset = "0xD5820C", VA = "0xD5820C")]
		public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xD58240", Offset = "0xD58240", VA = "0xD58240")]
		public static int GetNumLobbyMembers(CSteamID steamIDLobby)
		{
			return default(int);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xD5826C", Offset = "0xD5826C", VA = "0xD5826C")]
		public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xD58300", Offset = "0xD58300", VA = "0xD58300")]
		public static string GetLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xD5843C", Offset = "0xD5843C", VA = "0xD5843C")]
		public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xD5864C", Offset = "0xD5864C", VA = "0xD5864C")]
		public static int GetLobbyDataCount(CSteamID steamIDLobby)
		{
			return default(int);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xD58678", Offset = "0xD58678", VA = "0xD58678")]
		public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xD587D4", Offset = "0xD587D4", VA = "0xD587D4")]
		public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xD58904", Offset = "0xD58904", VA = "0xD58904")]
		public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xD58A48", Offset = "0xD58A48", VA = "0xD58A48")]
		public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xD58C38", Offset = "0xD58C38", VA = "0xD58C38")]
		public static bool SendLobbyChatMsg(CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xD58C7C", Offset = "0xD58C7C", VA = "0xD58C7C")]
		public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			return default(int);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xD58CE0", Offset = "0xD58CE0", VA = "0xD58CE0")]
		public static bool RequestLobbyData(CSteamID steamIDLobby)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xD58D0C", Offset = "0xD58D0C", VA = "0xD58D0C")]
		public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xD58D58", Offset = "0xD58D58", VA = "0xD58D58")]
		public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xD58DA4", Offset = "0xD58DA4", VA = "0xD58DA4")]
		public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xD58DD8", Offset = "0xD58DD8", VA = "0xD58DD8")]
		public static int GetLobbyMemberLimit(CSteamID steamIDLobby)
		{
			return default(int);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xD58E04", Offset = "0xD58E04", VA = "0xD58E04")]
		public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xD58E38", Offset = "0xD58E38", VA = "0xD58E38")]
		public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xD58E6C", Offset = "0xD58E6C", VA = "0xD58E6C")]
		public static CSteamID GetLobbyOwner(CSteamID steamIDLobby)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xD58EF0", Offset = "0xD58EF0", VA = "0xD58EF0")]
		public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xD58F24", Offset = "0xD58F24", VA = "0xD58F24")]
		public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000132")]
	public static class SteamMatchmakingServers
	{
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xD58F58", Offset = "0xD58F58", VA = "0xD58F58")]
		public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xD5903C", Offset = "0xD5903C", VA = "0xD5903C")]
		public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xD590DC", Offset = "0xD590DC", VA = "0xD590DC")]
		public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xD591C0", Offset = "0xD591C0", VA = "0xD591C0")]
		public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xD592A4", Offset = "0xD592A4", VA = "0xD592A4")]
		public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xD59388", Offset = "0xD59388", VA = "0xD59388")]
		public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xD5946C", Offset = "0xD5946C", VA = "0xD5946C")]
		public static void ReleaseRequest(HServerListRequest hServerListRequest)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xD59498", Offset = "0xD59498", VA = "0xD59498")]
		public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer)
		{
			return null;
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xD595B0", Offset = "0xD595B0", VA = "0xD595B0")]
		public static void CancelQuery(HServerListRequest hRequest)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xD595DC", Offset = "0xD595DC", VA = "0xD595DC")]
		public static void RefreshQuery(HServerListRequest hRequest)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xD59608", Offset = "0xD59608", VA = "0xD59608")]
		public static bool IsRefreshing(HServerListRequest hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xD59634", Offset = "0xD59634", VA = "0xD59634")]
		public static int GetServerCount(HServerListRequest hRequest)
		{
			return default(int);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xD59660", Offset = "0xD59660", VA = "0xD59660")]
		public static void RefreshServer(HServerListRequest hRequest, int iServer)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xD59694", Offset = "0xD59694", VA = "0xD59694")]
		public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xD59744", Offset = "0xD59744", VA = "0xD59744")]
		public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xD597F4", Offset = "0xD597F4", VA = "0xD597F4")]
		public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xD598A4", Offset = "0xD598A4", VA = "0xD598A4")]
		public static void CancelServerQuery(HServerQuery hServerQuery)
		{
		}
	}
	[Token(Token = "0x2000133")]
	public static class SteamMusic
	{
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xD598D0", Offset = "0xD598D0", VA = "0xD598D0")]
		public static bool BIsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xD598EC", Offset = "0xD598EC", VA = "0xD598EC")]
		public static bool BIsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xD59908", Offset = "0xD59908", VA = "0xD59908")]
		public static AudioPlayback_Status GetPlaybackStatus()
		{
			return default(AudioPlayback_Status);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xD59924", Offset = "0xD59924", VA = "0xD59924")]
		public static void Play()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xD59940", Offset = "0xD59940", VA = "0xD59940")]
		public static void Pause()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xD5995C", Offset = "0xD5995C", VA = "0xD5995C")]
		public static void PlayPrevious()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xD59978", Offset = "0xD59978", VA = "0xD59978")]
		public static void PlayNext()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xD59994", Offset = "0xD59994", VA = "0xD59994")]
		public static void SetVolume(float flVolume)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xD599C0", Offset = "0xD599C0", VA = "0xD599C0")]
		public static float GetVolume()
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000134")]
	public static class SteamMusicRemote
	{
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xD599DC", Offset = "0xD599DC", VA = "0xD599DC")]
		public static bool RegisterSteamMusicRemote(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xD59B04", Offset = "0xD59B04", VA = "0xD59B04")]
		public static bool DeregisterSteamMusicRemote()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xD59B20", Offset = "0xD59B20", VA = "0xD59B20")]
		public static bool BIsCurrentMusicRemote()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xD59B3C", Offset = "0xD59B3C", VA = "0xD59B3C")]
		public static bool BActivationSuccess(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xD59B68", Offset = "0xD59B68", VA = "0xD59B68")]
		public static bool SetDisplayName(string pchDisplayName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xD59C90", Offset = "0xD59C90", VA = "0xD59C90")]
		public static bool SetPNGIcon_64x64(byte[] pvBuffer, uint cbBufferLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xD59CC4", Offset = "0xD59CC4", VA = "0xD59CC4")]
		public static bool EnablePlayPrevious(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xD59CF0", Offset = "0xD59CF0", VA = "0xD59CF0")]
		public static bool EnablePlayNext(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xD59D1C", Offset = "0xD59D1C", VA = "0xD59D1C")]
		public static bool EnableShuffled(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xD59D48", Offset = "0xD59D48", VA = "0xD59D48")]
		public static bool EnableLooped(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xD59D74", Offset = "0xD59D74", VA = "0xD59D74")]
		public static bool EnableQueue(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xD59DA0", Offset = "0xD59DA0", VA = "0xD59DA0")]
		public static bool EnablePlaylists(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xD59DCC", Offset = "0xD59DCC", VA = "0xD59DCC")]
		public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xD59DF8", Offset = "0xD59DF8", VA = "0xD59DF8")]
		public static bool UpdateShuffled(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xD59E24", Offset = "0xD59E24", VA = "0xD59E24")]
		public static bool UpdateLooped(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xD59E50", Offset = "0xD59E50", VA = "0xD59E50")]
		public static bool UpdateVolume(float flValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xD59E7C", Offset = "0xD59E7C", VA = "0xD59E7C")]
		public static bool CurrentEntryWillChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xD59E98", Offset = "0xD59E98", VA = "0xD59E98")]
		public static bool CurrentEntryIsAvailable(bool bAvailable)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xD59EC4", Offset = "0xD59EC4", VA = "0xD59EC4")]
		public static bool UpdateCurrentEntryText(string pchText)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xD59FEC", Offset = "0xD59FEC", VA = "0xD59FEC")]
		public static bool UpdateCurrentEntryElapsedSeconds(int nValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xD5A018", Offset = "0xD5A018", VA = "0xD5A018")]
		public static bool UpdateCurrentEntryCoverArt(byte[] pvBuffer, uint cbBufferLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xD5A04C", Offset = "0xD5A04C", VA = "0xD5A04C")]
		public static bool CurrentEntryDidChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xD5A068", Offset = "0xD5A068", VA = "0xD5A068")]
		public static bool QueueWillChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xD5A084", Offset = "0xD5A084", VA = "0xD5A084")]
		public static bool ResetQueueEntries()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xD5A0A0", Offset = "0xD5A0A0", VA = "0xD5A0A0")]
		public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xD5A1D8", Offset = "0xD5A1D8", VA = "0xD5A1D8")]
		public static bool SetCurrentQueueEntry(int nID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xD5A204", Offset = "0xD5A204", VA = "0xD5A204")]
		public static bool QueueDidChange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xD5A220", Offset = "0xD5A220", VA = "0xD5A220")]
		public static bool PlaylistWillChange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xD5A23C", Offset = "0xD5A23C", VA = "0xD5A23C")]
		public static bool ResetPlaylistEntries()
		{
			return default(bool);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xD5A258", Offset = "0xD5A258", VA = "0xD5A258")]
		public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText)
		{
			return default(bool);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xD5A390", Offset = "0xD5A390", VA = "0xD5A390")]
		public static bool SetCurrentPlaylistEntry(int nID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xD5A3BC", Offset = "0xD5A3BC", VA = "0xD5A3BC")]
		public static bool PlaylistDidChange()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000135")]
	public static class SteamNetworking
	{
		[Token(Token = "0x6000606")]
		[Address(RVA = "0xD5A3D8", Offset = "0xD5A3D8", VA = "0xD5A3D8")]
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xD5A434", Offset = "0xD5A434", VA = "0xD5A434")]
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xD5A468", Offset = "0xD5A468", VA = "0xD5A468")]
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xD5A4C4", Offset = "0xD5A4C4", VA = "0xD5A4C4")]
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xD5A4F0", Offset = "0xD5A4F0", VA = "0xD5A4F0")]
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xD5A51C", Offset = "0xD5A51C", VA = "0xD5A51C")]
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			return default(bool);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xD5A550", Offset = "0xD5A550", VA = "0xD5A550")]
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			return default(bool);
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xD5A584", Offset = "0xD5A584", VA = "0xD5A584")]
		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			return default(bool);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xD5A5B0", Offset = "0xD5A5B0", VA = "0xD5A5B0")]
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			return default(SNetListenSocket_t);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xD5A604", Offset = "0xD5A604", VA = "0xD5A604")]
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xD5A658", Offset = "0xD5A658", VA = "0xD5A658")]
		public static SNetSocket_t CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xD5A6A4", Offset = "0xD5A6A4", VA = "0xD5A6A4")]
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xD5A6D8", Offset = "0xD5A6D8", VA = "0xD5A6D8")]
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xD5A70C", Offset = "0xD5A70C", VA = "0xD5A70C")]
		public static bool SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, bool bReliable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xD5A758", Offset = "0xD5A758", VA = "0xD5A758")]
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xD5A78C", Offset = "0xD5A78C", VA = "0xD5A78C")]
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xD5A7D8", Offset = "0xD5A7D8", VA = "0xD5A7D8")]
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xD5A81C", Offset = "0xD5A81C", VA = "0xD5A81C")]
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xD5A878", Offset = "0xD5A878", VA = "0xD5A878")]
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xD5A8D4", Offset = "0xD5A8D4", VA = "0xD5A8D4")]
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xD5A918", Offset = "0xD5A918", VA = "0xD5A918")]
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			return default(ESNetSocketConnectionType);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xD5A944", Offset = "0xD5A944", VA = "0xD5A944")]
		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000136")]
	public static class SteamRemoteStorage
	{
		[Token(Token = "0x600061C")]
		[Address(RVA = "0xDE45BC", Offset = "0xDE45BC", VA = "0xDE45BC")]
		public static bool FileWrite(string pchFile, byte[] pvData, int cubData)
		{
			return default(bool);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xDE46F4", Offset = "0xDE46F4", VA = "0xDE46F4")]
		public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead)
		{
			return default(int);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xDE482C", Offset = "0xDE482C", VA = "0xDE482C")]
		public static bool FileForget(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xDE4954", Offset = "0xDE4954", VA = "0xDE4954")]
		public static bool FileDelete(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xDE4A7C", Offset = "0xDE4A7C", VA = "0xDE4A7C")]
		public static SteamAPICall_t FileShare(string pchFile)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xDE4BD8", Offset = "0xDE4BD8", VA = "0xDE4BD8")]
		public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xDE4D08", Offset = "0xDE4D08", VA = "0xDE4D08")]
		public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xDE4E54", Offset = "0xDE4E54", VA = "0xDE4E54")]
		public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xDE4E98", Offset = "0xDE4E98", VA = "0xDE4E98")]
		public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xDE4EC4", Offset = "0xDE4EC4", VA = "0xDE4EC4")]
		public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xDE4EF0", Offset = "0xDE4EF0", VA = "0xDE4EF0")]
		public static bool FileExists(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xDE5018", Offset = "0xDE5018", VA = "0xDE5018")]
		public static bool FilePersisted(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xDE5140", Offset = "0xDE5140", VA = "0xDE5140")]
		public static int GetFileSize(string pchFile)
		{
			return default(int);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xDE5268", Offset = "0xDE5268", VA = "0xDE5268")]
		public static long GetFileTimestamp(string pchFile)
		{
			return default(long);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xDE5390", Offset = "0xDE5390", VA = "0xDE5390")]
		public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile)
		{
			return default(ERemoteStoragePlatform);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xDE54B8", Offset = "0xDE54B8", VA = "0xDE54B8")]
		public static int GetFileCount()
		{
			return default(int);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xDE54D4", Offset = "0xDE54D4", VA = "0xDE54D4")]
		public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes)
		{
			return null;
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xDE5510", Offset = "0xDE5510", VA = "0xDE5510")]
		public static bool GetQuota(out int pnTotalBytes, out int puAvailableBytes)
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xDE5544", Offset = "0xDE5544", VA = "0xDE5544")]
		public static bool IsCloudEnabledForAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xDE5560", Offset = "0xDE5560", VA = "0xDE5560")]
		public static bool IsCloudEnabledForApp()
		{
			return default(bool);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xDE557C", Offset = "0xDE557C", VA = "0xDE557C")]
		public static void SetCloudEnabledForApp(bool bEnabled)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xDE55A8", Offset = "0xDE55A8", VA = "0xDE55A8")]
		public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xDE563C", Offset = "0xDE563C", VA = "0xDE563C")]
		public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected)
		{
			return default(bool);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xDE5680", Offset = "0xDE5680", VA = "0xDE5680")]
		public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner)
		{
			return default(bool);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xDE5708", Offset = "0xDE5708", VA = "0xDE5708")]
		public static int UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction)
		{
			return default(int);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xDE5764", Offset = "0xDE5764", VA = "0xDE5764")]
		public static int GetCachedUGCCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xDE5780", Offset = "0xDE5780", VA = "0xDE5780")]
		public static UGCHandle_t GetCachedUGCHandle(int iCachedContent)
		{
			return default(UGCHandle_t);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xDE5804", Offset = "0xDE5804", VA = "0xDE5804")]
		public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xDE5C2C", Offset = "0xDE5C2C", VA = "0xDE5C2C")]
		public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xDE5CB0", Offset = "0xDE5CB0", VA = "0xDE5CB0")]
		public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xDE5DE0", Offset = "0xDE5DE0", VA = "0xDE5DE0")]
		public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xDE5F10", Offset = "0xDE5F10", VA = "0xDE5F10")]
		public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle)
		{
			return default(bool);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xDE6040", Offset = "0xDE6040", VA = "0xDE6040")]
		public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xDE6170", Offset = "0xDE6170", VA = "0xDE6170")]
		public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xDE61A4", Offset = "0xDE61A4", VA = "0xDE61A4")]
		public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xDE622C", Offset = "0xDE622C", VA = "0xDE622C")]
		public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xDE62B0", Offset = "0xDE62B0", VA = "0xDE62B0")]
		public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xDE6344", Offset = "0xDE6344", VA = "0xDE6344")]
		public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xDE63C8", Offset = "0xDE63C8", VA = "0xDE63C8")]
		public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xDE644C", Offset = "0xDE644C", VA = "0xDE644C")]
		public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xDE64D0", Offset = "0xDE64D0", VA = "0xDE64D0")]
		public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xDE6554", Offset = "0xDE6554", VA = "0xDE6554")]
		public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xDE65D8", Offset = "0xDE65D8", VA = "0xDE65D8")]
		public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xDE6708", Offset = "0xDE6708", VA = "0xDE6708")]
		public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xDE678C", Offset = "0xDE678C", VA = "0xDE678C")]
		public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xDE6820", Offset = "0xDE6820", VA = "0xDE6820")]
		public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xDE68A4", Offset = "0xDE68A4", VA = "0xDE68A4")]
		public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xDE6998", Offset = "0xDE6998", VA = "0xDE6998")]
		public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xDE6E84", Offset = "0xDE6E84", VA = "0xDE6E84")]
		public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xDE6F18", Offset = "0xDE6F18", VA = "0xDE6F18")]
		public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xDE6FAC", Offset = "0xDE6FAC", VA = "0xDE6FAC")]
		public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xDE70B8", Offset = "0xDE70B8", VA = "0xDE70B8")]
		public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000137")]
	public static class SteamScreenshots
	{
		[Token(Token = "0x6000650")]
		[Address(RVA = "0xDE7224", Offset = "0xDE7224", VA = "0xDE7224")]
		public static ScreenshotHandle WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xDE72D8", Offset = "0xDE72D8", VA = "0xDE72D8")]
		public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xDE7518", Offset = "0xDE7518", VA = "0xDE7518")]
		public static void TriggerScreenshot()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xDE7534", Offset = "0xDE7534", VA = "0xDE7534")]
		public static void HookScreenshots(bool bHook)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xDE7560", Offset = "0xDE7560", VA = "0xDE7560")]
		public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xDE7690", Offset = "0xDE7690", VA = "0xDE7690")]
		public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xDE76C4", Offset = "0xDE76C4", VA = "0xDE76C4")]
		public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000138")]
	public static class SteamUGC
	{
		[Token(Token = "0x6000657")]
		[Address(RVA = "0xDE76F8", Offset = "0xDE76F8", VA = "0xDE76F8")]
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xDE77C4", Offset = "0xDE77C4", VA = "0xDE77C4")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xDE7874", Offset = "0xDE7874", VA = "0xDE7874")]
		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xDE7904", Offset = "0xDE7904", VA = "0xDE7904")]
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xDE7988", Offset = "0xDE7988", VA = "0xDE7988")]
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			return default(bool);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xDE79CC", Offset = "0xDE79CC", VA = "0xDE79CC")]
		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xDE7ABC", Offset = "0xDE7ABC", VA = "0xDE7ABC")]
		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			return default(bool);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xDE7BAC", Offset = "0xDE7BAC", VA = "0xDE7BAC")]
		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(bool);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xDE7BF8", Offset = "0xDE7BF8", VA = "0xDE7BF8")]
		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out uint pStatValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xDE7C44", Offset = "0xDE7C44", VA = "0xDE7C44")]
		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			return default(uint);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xDE7C78", Offset = "0xDE7C78", VA = "0xDE7C78")]
		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out bool pbIsImage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xDE7D80", Offset = "0xDE7D80", VA = "0xDE7D80")]
		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			return default(uint);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xDE7DB4", Offset = "0xDE7DB4", VA = "0xDE7DB4")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xDE7F18", Offset = "0xDE7F18", VA = "0xDE7F18")]
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xDE7F44", Offset = "0xDE7F44", VA = "0xDE7F44")]
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xDE8074", Offset = "0xDE8074", VA = "0xDE8074")]
		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xDE81A4", Offset = "0xDE81A4", VA = "0xDE81A4")]
		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xDE81D8", Offset = "0xDE81D8", VA = "0xDE81D8")]
		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xDE820C", Offset = "0xDE820C", VA = "0xDE820C")]
		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			return default(bool);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xDE8240", Offset = "0xDE8240", VA = "0xDE8240")]
		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			return default(bool);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xDE8274", Offset = "0xDE8274", VA = "0xDE8274")]
		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			return default(bool);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xDE82A8", Offset = "0xDE82A8", VA = "0xDE82A8")]
		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xDE82DC", Offset = "0xDE82DC", VA = "0xDE82DC")]
		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xDE840C", Offset = "0xDE840C", VA = "0xDE840C")]
		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xDE8440", Offset = "0xDE8440", VA = "0xDE8440")]
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xDE8570", Offset = "0xDE8570", VA = "0xDE8570")]
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xDE85A4", Offset = "0xDE85A4", VA = "0xDE85A4")]
		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			return default(bool);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xDE86D4", Offset = "0xDE86D4", VA = "0xDE86D4")]
		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xDE8708", Offset = "0xDE8708", VA = "0xDE8708")]
		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xDE8918", Offset = "0xDE8918", VA = "0xDE8918")]
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xDE89AC", Offset = "0xDE89AC", VA = "0xDE89AC")]
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xDE8A40", Offset = "0xDE8A40", VA = "0xDE8A40")]
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(UGCUpdateHandle_t);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xDE8AD4", Offset = "0xDE8AD4", VA = "0xDE8AD4")]
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xDE8C04", Offset = "0xDE8C04", VA = "0xDE8C04")]
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xDE8D34", Offset = "0xDE8D34", VA = "0xDE8D34")]
		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xDE8E64", Offset = "0xDE8E64", VA = "0xDE8E64")]
		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			return default(bool);
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xDE8F94", Offset = "0xDE8F94", VA = "0xDE8F94")]
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xDE8FC8", Offset = "0xDE8FC8", VA = "0xDE8FC8")]
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xDE9050", Offset = "0xDE9050", VA = "0xDE9050")]
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			return default(bool);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xDE9180", Offset = "0xDE9180", VA = "0xDE9180")]
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xDE92B0", Offset = "0xDE92B0", VA = "0xDE92B0")]
		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xDE93E0", Offset = "0xDE93E0", VA = "0xDE93E0")]
		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xDE95F0", Offset = "0xDE95F0", VA = "0xDE95F0")]
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xDE9754", Offset = "0xDE9754", VA = "0xDE9754")]
		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			return default(EItemUpdateStatus);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xDE9798", Offset = "0xDE9798", VA = "0xDE9798")]
		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xDE982C", Offset = "0xDE982C", VA = "0xDE982C")]
		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xDE98B0", Offset = "0xDE98B0", VA = "0xDE98B0")]
		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xDE9944", Offset = "0xDE9944", VA = "0xDE9944")]
		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xDE99D8", Offset = "0xDE99D8", VA = "0xDE99D8")]
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xDE9A5C", Offset = "0xDE9A5C", VA = "0xDE9A5C")]
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xDE9AE0", Offset = "0xDE9AE0", VA = "0xDE9AE0")]
		public static uint GetNumSubscribedItems()
		{
			return default(uint);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xDE9AFC", Offset = "0xDE9AFC", VA = "0xDE9AFC")]
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(uint);
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xDE9B30", Offset = "0xDE9B30", VA = "0xDE9B30")]
		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			return default(uint);
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xDE9B5C", Offset = "0xDE9B5C", VA = "0xDE9B5C")]
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			return default(bool);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xDE9C5C", Offset = "0xDE9C5C", VA = "0xDE9C5C")]
		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xDE9CA0", Offset = "0xDE9CA0", VA = "0xDE9CA0")]
		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000139")]
	public static class SteamUnifiedMessages
	{
		[Token(Token = "0x600068F")]
		[Address(RVA = "0xDE9CD4", Offset = "0xDE9CD4", VA = "0xDE9CD4")]
		public static ClientUnifiedMessageHandle SendMethod(string pchServiceMethod, byte[] pRequestBuffer, uint unRequestBufferSize, ulong unContext)
		{
			return default(ClientUnifiedMessageHandle);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xDE9E50", Offset = "0xDE9E50", VA = "0xDE9E50")]
		public static bool GetMethodResponseInfo(ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult)
		{
			return default(bool);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xDE9E94", Offset = "0xDE9E94", VA = "0xDE9E94")]
		public static bool GetMethodResponseData(ClientUnifiedMessageHandle hHandle, byte[] pResponseBuffer, uint unResponseBufferSize, bool bAutoRelease)
		{
			return default(bool);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xDE9EE0", Offset = "0xDE9EE0", VA = "0xDE9EE0")]
		public static bool ReleaseMethod(ClientUnifiedMessageHandle hHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xDE9F0C", Offset = "0xDE9F0C", VA = "0xDE9F0C")]
		public static bool SendNotification(string pchServiceNotification, byte[] pNotificationBuffer, uint unNotificationBufferSize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200013A")]
	public static class SteamUser
	{
		[Token(Token = "0x6000694")]
		[Address(RVA = "0xDEA044", Offset = "0xDEA044", VA = "0xDEA044")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xDEA070", Offset = "0xDEA070", VA = "0xDEA070")]
		public static bool BLoggedOn()
		{
			return default(bool);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xDEA08C", Offset = "0xDEA08C", VA = "0xDEA08C")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xDEA108", Offset = "0xDEA108", VA = "0xDEA108")]
		public static int InitiateGameConnection(byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
		{
			return default(int);
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xDEA16C", Offset = "0xDEA16C", VA = "0xDEA16C")]
		public static void TerminateGameConnection(uint unIPServer, ushort usPortServer)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xDEA1A0", Offset = "0xDEA1A0", VA = "0xDEA1A0")]
		public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "")
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xDEA2CC", Offset = "0xDEA2CC", VA = "0xDEA2CC")]
		public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xDEA3A0", Offset = "0xDEA3A0", VA = "0xDEA3A0")]
		public static void StartVoiceRecording()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xDEA3BC", Offset = "0xDEA3BC", VA = "0xDEA3BC")]
		public static void StopVoiceRecording()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xDEA3D8", Offset = "0xDEA3D8", VA = "0xDEA3D8")]
		public static EVoiceResult GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed, uint nUncompressedVoiceDesiredSampleRate)
		{
			return default(EVoiceResult);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xDEA41C", Offset = "0xDEA41C", VA = "0xDEA41C")]
		public static EVoiceResult GetVoice(bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed, byte[] pUncompressedDestBuffer, uint cbUncompressedDestBufferSize, out uint nUncompressBytesWritten, uint nUncompressedVoiceDesiredSampleRate)
		{
			return default(EVoiceResult);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xDEA4A8", Offset = "0xDEA4A8", VA = "0xDEA4A8")]
		public static EVoiceResult DecompressVoice(byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate)
		{
			return default(EVoiceResult);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xDEA50C", Offset = "0xDEA50C", VA = "0xDEA50C")]
		public static uint GetVoiceOptimalSampleRate()
		{
			return default(uint);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xDEA528", Offset = "0xDEA528", VA = "0xDEA528")]
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(HAuthTicket);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xDEA5CC", Offset = "0xDEA5CC", VA = "0xDEA5CC")]
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			return default(EBeginAuthSessionResult);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xDEA610", Offset = "0xDEA610", VA = "0xDEA610")]
		public static void EndAuthSession(CSteamID steamID)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xDEA63C", Offset = "0xDEA63C", VA = "0xDEA63C")]
		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xDEA668", Offset = "0xDEA668", VA = "0xDEA668")]
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			return default(EUserHasLicenseForAppResult);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xDEA69C", Offset = "0xDEA69C", VA = "0xDEA69C")]
		public static bool BIsBehindNAT()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xDEA6B8", Offset = "0xDEA6B8", VA = "0xDEA6B8")]
		public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xDEA6FC", Offset = "0xDEA6FC", VA = "0xDEA6FC")]
		public static SteamAPICall_t RequestEncryptedAppTicket(byte[] pDataToInclude, int cbDataToInclude)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xDEA790", Offset = "0xDEA790", VA = "0xDEA790")]
		public static bool GetEncryptedAppTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xDEA7D4", Offset = "0xDEA7D4", VA = "0xDEA7D4")]
		public static int GetGameBadgeLevel(int nSeries, bool bFoil)
		{
			return default(int);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xDEA808", Offset = "0xDEA808", VA = "0xDEA808")]
		public static int GetPlayerSteamLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xDEA824", Offset = "0xDEA824", VA = "0xDEA824")]
		public static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x200013B")]
	public static class SteamUserStats
	{
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xDEA980", Offset = "0xDEA980", VA = "0xDEA980")]
		public static bool RequestCurrentStats()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xDEA99C", Offset = "0xDEA99C", VA = "0xDEA99C")]
		public static bool GetStat(string pchName, out int pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xDEAACC", Offset = "0xDEAACC", VA = "0xDEAACC")]
		public static bool GetStat(string pchName, out float pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xDEABFC", Offset = "0xDEABFC", VA = "0xDEABFC")]
		public static bool SetStat(string pchName, int nData)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xDEAD2C", Offset = "0xDEAD2C", VA = "0xDEAD2C")]
		public static bool SetStat(string pchName, float fData)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xDEAE64", Offset = "0xDEAE64", VA = "0xDEAE64")]
		public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xDEAFA4", Offset = "0xDEAFA4", VA = "0xDEAFA4")]
		public static bool GetAchievement(string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xDEB0D4", Offset = "0xDEB0D4", VA = "0xDEB0D4")]
		public static bool SetAchievement(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xDEB1FC", Offset = "0xDEB1FC", VA = "0xDEB1FC")]
		public static bool ClearAchievement(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xDEB324", Offset = "0xDEB324", VA = "0xDEB324")]
		public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xDEB45C", Offset = "0xDEB45C", VA = "0xDEB45C")]
		public static bool StoreStats()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xDEB478", Offset = "0xDEB478", VA = "0xDEB478")]
		public static int GetAchievementIcon(string pchName)
		{
			return default(int);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xDEB5A0", Offset = "0xDEB5A0", VA = "0xDEB5A0")]
		public static string GetAchievementDisplayAttribute(string pchName, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xDEB7A0", Offset = "0xDEB7A0", VA = "0xDEB7A0")]
		public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xDEB8D8", Offset = "0xDEB8D8", VA = "0xDEB8D8")]
		public static uint GetNumAchievements()
		{
			return default(uint);
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xDEB8F4", Offset = "0xDEB8F4", VA = "0xDEB8F4")]
		public static string GetAchievementName(uint iAchievement)
		{
			return null;
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xDEB928", Offset = "0xDEB928", VA = "0xDEB928")]
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xDEB9AC", Offset = "0xDEB9AC", VA = "0xDEB9AC")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xDEBAE4", Offset = "0xDEBAE4", VA = "0xDEBAE4")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xDEBC1C", Offset = "0xDEBC1C", VA = "0xDEBC1C")]
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xDEBD54", Offset = "0xDEBD54", VA = "0xDEBD54")]
		public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xDEBE9C", Offset = "0xDEBE9C", VA = "0xDEBE9C")]
		public static bool ResetAllStats(bool bAchievementsToo)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xDEBEC8", Offset = "0xDEBEC8", VA = "0xDEBEC8")]
		public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xDEC034", Offset = "0xDEC034", VA = "0xDEC034")]
		public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xDEC190", Offset = "0xDEC190", VA = "0xDEC190")]
		public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
		{
			return null;
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xDEC1C4", Offset = "0xDEC1C4", VA = "0xDEC1C4")]
		public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(int);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xDEC1F0", Offset = "0xDEC1F0", VA = "0xDEC1F0")]
		public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(ELeaderboardSortMethod);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xDEC21C", Offset = "0xDEC21C", VA = "0xDEC21C")]
		public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(ELeaderboardDisplayType);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xDEC248", Offset = "0xDEC248", VA = "0xDEC248")]
		public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xDEC2F4", Offset = "0xDEC2F4", VA = "0xDEC2F4")]
		public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xDEC390", Offset = "0xDEC390", VA = "0xDEC390")]
		public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xDEC3EC", Offset = "0xDEC3EC", VA = "0xDEC3EC")]
		public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xDEC4A0", Offset = "0xDEC4A0", VA = "0xDEC4A0")]
		public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xDEC534", Offset = "0xDEC534", VA = "0xDEC534")]
		public static SteamAPICall_t GetNumberOfCurrentPlayers()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xDEC5B0", Offset = "0xDEC5B0", VA = "0xDEC5B0")]
		public static SteamAPICall_t RequestGlobalAchievementPercentages()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xDEC62C", Offset = "0xDEC62C", VA = "0xDEC62C")]
		public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			return default(int);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xDEC720", Offset = "0xDEC720", VA = "0xDEC720")]
		public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			return default(int);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xDEC828", Offset = "0xDEC828", VA = "0xDEC828")]
		public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xDEC958", Offset = "0xDEC958", VA = "0xDEC958")]
		public static SteamAPICall_t RequestGlobalStats(int nHistoryDays)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xDEC9DC", Offset = "0xDEC9DC", VA = "0xDEC9DC")]
		public static bool GetGlobalStat(string pchStatName, out long pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xDECB0C", Offset = "0xDECB0C", VA = "0xDECB0C")]
		public static bool GetGlobalStat(string pchStatName, out double pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xDECC3C", Offset = "0xDECC3C", VA = "0xDECC3C")]
		public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData)
		{
			return default(int);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xDECD74", Offset = "0xDECD74", VA = "0xDECD74")]
		public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200013C")]
	public static class SteamUtils
	{
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xDECEAC", Offset = "0xDECEAC", VA = "0xDECEAC")]
		public static uint GetSecondsSinceAppActive()
		{
			return default(uint);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xDECEC8", Offset = "0xDECEC8", VA = "0xDECEC8")]
		public static uint GetSecondsSinceComputerActive()
		{
			return default(uint);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xDECEE4", Offset = "0xDECEE4", VA = "0xDECEE4")]
		public static EUniverse GetConnectedUniverse()
		{
			return default(EUniverse);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xDECF00", Offset = "0xDECF00", VA = "0xDECF00")]
		public static uint GetServerRealTime()
		{
			return default(uint);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xDECF1C", Offset = "0xDECF1C", VA = "0xDECF1C")]
		public static string GetIPCountry()
		{
			return null;
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xDECF40", Offset = "0xDECF40", VA = "0xDECF40")]
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xDECF84", Offset = "0xDECF84", VA = "0xDECF84")]
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xDECFC8", Offset = "0xDECFC8", VA = "0xDECFC8")]
		public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xDECFFC", Offset = "0xDECFFC", VA = "0xDECFFC")]
		public static byte GetCurrentBatteryPower()
		{
			return default(byte);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xDED018", Offset = "0xDED018", VA = "0xDED018")]
		public static AppId_t GetAppID()
		{
			return default(AppId_t);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xDED09C", Offset = "0xDED09C", VA = "0xDED09C")]
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xDED0C8", Offset = "0xDED0C8", VA = "0xDED0C8")]
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xDED0FC", Offset = "0xDED0FC", VA = "0xDED0FC")]
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return default(ESteamAPICallFailure);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xDED128", Offset = "0xDED128", VA = "0xDED128")]
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xDED184", Offset = "0xDED184", VA = "0xDED184")]
		public static void RunFrame()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xDED1A0", Offset = "0xDED1A0", VA = "0xDED1A0")]
		public static uint GetIPCCallCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xDED1BC", Offset = "0xDED1BC", VA = "0xDED1BC")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xDED1E8", Offset = "0xDED1E8", VA = "0xDED1E8")]
		public static bool IsOverlayEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xDED204", Offset = "0xDED204", VA = "0xDED204")]
		public static bool BOverlayNeedsPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xDED220", Offset = "0xDED220", VA = "0xDED220")]
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xDED37C", Offset = "0xDED37C", VA = "0xDED37C")]
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return default(bool);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xDED5A4", Offset = "0xDED5A4", VA = "0xDED5A4")]
		public static uint GetEnteredGamepadTextLength()
		{
			return default(uint);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xDED5C0", Offset = "0xDED5C0", VA = "0xDED5C0")]
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xDED694", Offset = "0xDED694", VA = "0xDED694")]
		public static string GetSteamUILanguage()
		{
			return null;
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xDED6B8", Offset = "0xDED6B8", VA = "0xDED6B8")]
		public static bool IsSteamRunningInVR()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xDED6D4", Offset = "0xDED6D4", VA = "0xDED6D4")]
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
		}
	}
	[Token(Token = "0x200013D")]
	public static class SteamVideo
	{
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xDED708", Offset = "0xDED708", VA = "0xDED708")]
		public static void GetVideoURL(AppId_t unVideoAppID)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xDED734", Offset = "0xDED734", VA = "0xDED734")]
		public static bool IsBroadcasting(out int pnNumViewers)
		{
			return default(bool);
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x200013E")]
	public class gameserveritem_t
	{
		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public servernetadr_t m_NetAdr;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nPing;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool m_bHadSuccessfulResponse;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool m_bDoNotRefresh;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[] m_szGameDir;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] m_szMap;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] m_szGameDescription;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_nAppID;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int m_nPlayers;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int m_nMaxPlayers;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int m_nBotPlayers;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool m_bPassword;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool m_bSecure;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public uint m_ulTimeLastPlayed;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int m_nServerVersion;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private byte[] m_szServerName;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private byte[] m_szGameTags;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public CSteamID m_steamID;

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xDEDE80", Offset = "0xDEDE80", VA = "0xDEDE80")]
		public string GetGameDir()
		{
			return null;
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xDEDF0C", Offset = "0xDEDF0C", VA = "0xDEDF0C")]
		public void SetGameDir(string dir)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xDEDFA0", Offset = "0xDEDFA0", VA = "0xDEDFA0")]
		public string GetMap()
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xDEE02C", Offset = "0xDEE02C", VA = "0xDEE02C")]
		public void SetMap(string map)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xDEE0C0", Offset = "0xDEE0C0", VA = "0xDEE0C0")]
		public string GetGameDescription()
		{
			return null;
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xDEE14C", Offset = "0xDEE14C", VA = "0xDEE14C")]
		public void SetGameDescription(string desc)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xDEE1E0", Offset = "0xDEE1E0", VA = "0xDEE1E0")]
		public string GetServerName()
		{
			return null;
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xDEE2B4", Offset = "0xDEE2B4", VA = "0xDEE2B4")]
		public void SetServerName(string name)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xDEE348", Offset = "0xDEE348", VA = "0xDEE348")]
		public string GetGameTags()
		{
			return null;
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xDEE3D4", Offset = "0xDEE3D4", VA = "0xDEE3D4")]
		public void SetGameTags(string tags)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xDEE468", Offset = "0xDEE468", VA = "0xDEE468")]
		public gameserveritem_t()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public struct servernetadr_t
	{
		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort m_usConnectionPort;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private ushort m_usQueryPort;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private uint m_unIP;

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xDEE470", Offset = "0xDEE470", VA = "0xDEE470")]
		public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xDEE480", Offset = "0xDEE480", VA = "0xDEE480")]
		public ushort GetQueryPort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xDEE488", Offset = "0xDEE488", VA = "0xDEE488")]
		public void SetQueryPort(ushort usPort)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xDEE490", Offset = "0xDEE490", VA = "0xDEE490")]
		public ushort GetConnectionPort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xDEE498", Offset = "0xDEE498", VA = "0xDEE498")]
		public void SetConnectionPort(ushort usPort)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xDEE4A0", Offset = "0xDEE4A0", VA = "0xDEE4A0")]
		public uint GetIP()
		{
			return default(uint);
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xDEE4A8", Offset = "0xDEE4A8", VA = "0xDEE4A8")]
		public void SetIP(uint unIP)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xDEE2A4", Offset = "0xDEE2A4", VA = "0xDEE2A4")]
		public string GetConnectionAddressString()
		{
			return null;
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xDEE6A4", Offset = "0xDEE6A4", VA = "0xDEE6A4")]
		public string GetQueryAddressString()
		{
			return null;
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xDEE4B0", Offset = "0xDEE4B0", VA = "0xDEE4B0")]
		public static string ToString(uint unIP, ushort usPort)
		{
			return null;
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xDEE6B4", Offset = "0xDEE6B4", VA = "0xDEE6B4")]
		public static bool operator <(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xDEE6E8", Offset = "0xDEE6E8", VA = "0xDEE6E8")]
		public static bool operator >(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xDEE71C", Offset = "0xDEE71C", VA = "0xDEE71C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xDEE7F8", Offset = "0xDEE7F8", VA = "0xDEE7F8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xDEE7C4", Offset = "0xDEE7C4", VA = "0xDEE7C4")]
		public static bool operator ==(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xDEE850", Offset = "0xDEE850", VA = "0xDEE850")]
		public static bool operator !=(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xDEE884", Offset = "0xDEE884", VA = "0xDEE884")]
		public bool Equals(servernetadr_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xDEE8B8", Offset = "0xDEE8B8", VA = "0xDEE8B8")]
		public int CompareTo(servernetadr_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000140")]
	public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
	{
		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_HSteamPipe;

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x92DB74", Offset = "0x92DB74", VA = "0x92DB74")]
		public HSteamPipe(int value)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x92DB7C", Offset = "0x92DB7C", VA = "0x92DB7C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x92DB84", Offset = "0x92DB84", VA = "0x92DB84", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x92DC18", Offset = "0x92DC18", VA = "0x92DC18", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x92DC0C", Offset = "0x92DC0C", VA = "0x92DC0C")]
		public static bool operator ==(HSteamPipe x, HSteamPipe y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x92DC20", Offset = "0x92DC20", VA = "0x92DC20")]
		public static bool operator !=(HSteamPipe x, HSteamPipe y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x92D3A8", Offset = "0x92D3A8", VA = "0x92D3A8")]
		public static explicit operator HSteamPipe(int value)
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x92DC2C", Offset = "0x92DC2C", VA = "0x92DC2C")]
		public static explicit operator int(HSteamPipe that)
		{
			return default(int);
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x92DC30", Offset = "0x92DC30", VA = "0x92DC30", Slot = "4")]
		public bool Equals(HSteamPipe other)
		{
			return default(bool);
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x92DC40", Offset = "0x92DC40", VA = "0x92DC40", Slot = "5")]
		public int CompareTo(HSteamPipe other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000141")]
	public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_HSteamUser;

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x92DC48", Offset = "0x92DC48", VA = "0x92DC48")]
		public HSteamUser(int value)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x92DC50", Offset = "0x92DC50", VA = "0x92DC50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x92DC58", Offset = "0x92DC58", VA = "0x92DC58", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x92DCEC", Offset = "0x92DCEC", VA = "0x92DCEC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x92DCE0", Offset = "0x92DCE0", VA = "0x92DCE0")]
		public static bool operator ==(HSteamUser x, HSteamUser y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x92DCF4", Offset = "0x92DCF4", VA = "0x92DCF4")]
		public static bool operator !=(HSteamUser x, HSteamUser y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x92D430", Offset = "0x92D430", VA = "0x92D430")]
		public static explicit operator HSteamUser(int value)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x92DD00", Offset = "0x92DD00", VA = "0x92DD00")]
		public static explicit operator int(HSteamUser that)
		{
			return default(int);
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x92DD04", Offset = "0x92DD04", VA = "0x92DD04", Slot = "4")]
		public bool Equals(HSteamUser other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x92DD14", Offset = "0x92DD14", VA = "0x92DD14", Slot = "5")]
		public int CompareTo(HSteamUser other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED588", Offset = "0x7ED588")]
	public delegate void SteamAPIWarningMessageHook_t(int nSeverity, StringBuilder pchDebugText);
	[Token(Token = "0x2000143")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED59C", Offset = "0x7ED59C")]
	public delegate void SteamAPI_CheckCallbackRegistered_t(int iCallbackNum);
	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x7ED5B0", Offset = "0x7ED5B0")]
	public delegate void SteamAPI_PostAPIResultInProcess_t(SteamAPICall_t callHandle, IntPtr pUnknown, uint unCallbackSize, int iCallbackNum);
	[Token(Token = "0x2000145")]
	public struct CGameID : IEquatable<CGameID>, IComparable<CGameID>
	{
		[Token(Token = "0x200018C")]
		public enum EGameIDType
		{
			[Token(Token = "0x400070D")]
			k_EGameIDTypeApp,
			[Token(Token = "0x400070E")]
			k_EGameIDTypeGameMod,
			[Token(Token = "0x400070F")]
			k_EGameIDTypeShortcut,
			[Token(Token = "0x4000710")]
			k_EGameIDTypeP2P
		}

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_GameID;

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x92BC84", Offset = "0x92BC84", VA = "0x92BC84")]
		public CGameID(ulong GameID)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x92BC8C", Offset = "0x92BC8C", VA = "0x92BC8C")]
		public CGameID(AppId_t nAppID)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x92BD10", Offset = "0x92BD10", VA = "0x92BD10")]
		public CGameID(AppId_t nAppID, uint nModID)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x92BD60", Offset = "0x92BD60", VA = "0x92BD60")]
		public bool IsSteamApp()
		{
			return default(bool);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x92BD78", Offset = "0x92BD78", VA = "0x92BD78")]
		public bool IsMod()
		{
			return default(bool);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x92BD90", Offset = "0x92BD90", VA = "0x92BD90")]
		public bool IsShortcut()
		{
			return default(bool);
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x92BDA8", Offset = "0x92BDA8", VA = "0x92BDA8")]
		public bool IsP2PFile()
		{
			return default(bool);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x92BDC0", Offset = "0x92BDC0", VA = "0x92BDC0")]
		public AppId_t AppID()
		{
			return default(AppId_t);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x92BD70", Offset = "0x92BD70", VA = "0x92BD70")]
		public EGameIDType Type()
		{
			return default(EGameIDType);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x92BDCC", Offset = "0x92BDCC", VA = "0x92BDCC")]
		public uint ModID()
		{
			return default(uint);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x92BDD4", Offset = "0x92BDD4", VA = "0x92BDD4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x92BF10", Offset = "0x92BF10", VA = "0x92BF10")]
		public void Reset()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x92BF18", Offset = "0x92BF18", VA = "0x92BF18")]
		public void Set(ulong GameID)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x92BC98", Offset = "0x92BC98", VA = "0x92BC98")]
		private void SetAppID(AppId_t other)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x92BD50", Offset = "0x92BD50", VA = "0x92BD50")]
		private void SetType(EGameIDType other)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x92BD58", Offset = "0x92BD58", VA = "0x92BD58")]
		private void SetModID(uint other)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x92BF20", Offset = "0x92BF20", VA = "0x92BF20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x92BF28", Offset = "0x92BF28", VA = "0x92BF28", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x92BFBC", Offset = "0x92BFBC", VA = "0x92BFBC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x92BFB0", Offset = "0x92BFB0", VA = "0x92BFB0")]
		public static bool operator ==(CGameID x, CGameID y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x92BFC4", Offset = "0x92BFC4", VA = "0x92BFC4")]
		public static bool operator !=(CGameID x, CGameID y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x92BFD0", Offset = "0x92BFD0", VA = "0x92BFD0")]
		public static explicit operator CGameID(ulong value)
		{
			return default(CGameID);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x92BFD4", Offset = "0x92BFD4", VA = "0x92BFD4")]
		public static explicit operator ulong(CGameID that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x92BFD8", Offset = "0x92BFD8", VA = "0x92BFD8", Slot = "4")]
		public bool Equals(CGameID other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x92BFE8", Offset = "0x92BFE8", VA = "0x92BFE8", Slot = "5")]
		public int CompareTo(CGameID other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000146")]
	public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
	{
		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CSteamID Nil;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly CSteamID OutofDateGS;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly CSteamID LanModeGS;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly CSteamID NotInitYetGS;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly CSteamID NonSteamGS;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamID;

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x92BFF0", Offset = "0x92BFF0", VA = "0x92BFF0")]
		public CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x92C054", Offset = "0x92C054", VA = "0x92C054")]
		public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x92C094", Offset = "0x92C094", VA = "0x92C094")]
		public CSteamID(ulong ulSteamID)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x92C01C", Offset = "0x92C01C", VA = "0x92C01C")]
		public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x92C074", Offset = "0x92C074", VA = "0x92C074")]
		public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x92C0D4", Offset = "0x92C0D4", VA = "0x92C0D4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x92C0DC", Offset = "0x92C0DC", VA = "0x92C0DC")]
		public void CreateBlankAnonLogon(EUniverse eUniverse)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x92C0EC", Offset = "0x92C0EC", VA = "0x92C0EC")]
		public void CreateBlankAnonUserLogon(EUniverse eUniverse)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x92C0FC", Offset = "0x92C0FC", VA = "0x92C0FC")]
		public bool BBlankAnonAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x92C160", Offset = "0x92C160", VA = "0x92C160")]
		public bool BGameServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x92C184", Offset = "0x92C184", VA = "0x92C184")]
		public bool BPersistentGameServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x92C19C", Offset = "0x92C19C", VA = "0x92C19C")]
		public bool BAnonGameServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x92C1B4", Offset = "0x92C1B4", VA = "0x92C1B4")]
		public bool BContentServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x92C1CC", Offset = "0x92C1CC", VA = "0x92C1CC")]
		public bool BClanAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x92C1E4", Offset = "0x92C1E4", VA = "0x92C1E4")]
		public bool BChatAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x92C1FC", Offset = "0x92C1FC", VA = "0x92C1FC")]
		public bool IsLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x92C218", Offset = "0x92C218", VA = "0x92C218")]
		public bool BIndividualAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x92C134", Offset = "0x92C134", VA = "0x92C134")]
		public bool BAnonAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x92C230", Offset = "0x92C230", VA = "0x92C230")]
		public bool BAnonUserAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x92C248", Offset = "0x92C248", VA = "0x92C248")]
		public bool BConsoleUserAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x92C09C", Offset = "0x92C09C", VA = "0x92C09C")]
		public void SetAccountID(AccountID_t other)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x92C0C0", Offset = "0x92C0C0", VA = "0x92C0C0")]
		public void SetAccountInstance(uint other)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x92C0AC", Offset = "0x92C0AC", VA = "0x92C0AC")]
		public void SetEAccountType(EAccountType other)
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x92C0A4", Offset = "0x92C0A4", VA = "0x92C0A4")]
		public void SetEUniverse(EUniverse other)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x92C260", Offset = "0x92C260", VA = "0x92C260")]
		public void ClearIndividualInstance()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x92C280", Offset = "0x92C280", VA = "0x92C280")]
		public bool HasNoIndividualInstance()
		{
			return default(bool);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x92C12C", Offset = "0x92C12C", VA = "0x92C12C")]
		public AccountID_t GetAccountID()
		{
			return default(AccountID_t);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x92C154", Offset = "0x92C154", VA = "0x92C154")]
		public uint GetUnAccountInstance()
		{
			return default(uint);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x92C178", Offset = "0x92C178", VA = "0x92C178")]
		public EAccountType GetEAccountType()
		{
			return default(EAccountType);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x92C2A4", Offset = "0x92C2A4", VA = "0x92C2A4")]
		public EUniverse GetEUniverse()
		{
			return default(EUniverse);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x92C2AC", Offset = "0x92C2AC", VA = "0x92C2AC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x92C32C", Offset = "0x92C32C", VA = "0x92C32C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x92C334", Offset = "0x92C334", VA = "0x92C334", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x92C400", Offset = "0x92C400", VA = "0x92C400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x92C3F4", Offset = "0x92C3F4", VA = "0x92C3F4")]
		public static bool operator ==(CSteamID x, CSteamID y)
		{
			return default(bool);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x92C408", Offset = "0x92C408", VA = "0x92C408")]
		public static bool operator !=(CSteamID x, CSteamID y)
		{
			return default(bool);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x92C47C", Offset = "0x92C47C", VA = "0x92C47C")]
		public static explicit operator CSteamID(ulong value)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x92C480", Offset = "0x92C480", VA = "0x92C480")]
		public static explicit operator ulong(CSteamID that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x92C484", Offset = "0x92C484", VA = "0x92C484", Slot = "4")]
		public bool Equals(CSteamID other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x92C494", Offset = "0x92C494", VA = "0x92C494", Slot = "5")]
		public int CompareTo(CSteamID other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000147")]
	public struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
	{
		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HAuthTicket Invalid;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HAuthTicket;

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x92D438", Offset = "0x92D438", VA = "0x92D438")]
		public HAuthTicket(uint value)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x92D440", Offset = "0x92D440", VA = "0x92D440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x92D448", Offset = "0x92D448", VA = "0x92D448", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x92D514", Offset = "0x92D514", VA = "0x92D514", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x92D508", Offset = "0x92D508", VA = "0x92D508")]
		public static bool operator ==(HAuthTicket x, HAuthTicket y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x92D51C", Offset = "0x92D51C", VA = "0x92D51C")]
		public static bool operator !=(HAuthTicket x, HAuthTicket y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x92D590", Offset = "0x92D590", VA = "0x92D590")]
		public static explicit operator HAuthTicket(uint value)
		{
			return default(HAuthTicket);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x92D598", Offset = "0x92D598", VA = "0x92D598")]
		public static explicit operator uint(HAuthTicket that)
		{
			return default(uint);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x92D59C", Offset = "0x92D59C", VA = "0x92D59C", Slot = "4")]
		public bool Equals(HAuthTicket other)
		{
			return default(bool);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x92D5AC", Offset = "0x92D5AC", VA = "0x92D5AC", Slot = "5")]
		public int CompareTo(HAuthTicket other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000148")]
	public struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly FriendsGroupID_t Invalid;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short m_FriendsGroupID;

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x92CC2C", Offset = "0x92CC2C", VA = "0x92CC2C")]
		public FriendsGroupID_t(short value)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x92CC34", Offset = "0x92CC34", VA = "0x92CC34", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x92CC3C", Offset = "0x92CC3C", VA = "0x92CC3C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x92CD0C", Offset = "0x92CD0C", VA = "0x92CD0C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x92CCFC", Offset = "0x92CCFC", VA = "0x92CCFC")]
		public static bool operator ==(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x92CD14", Offset = "0x92CD14", VA = "0x92CD14")]
		public static bool operator !=(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x92CD8C", Offset = "0x92CD8C", VA = "0x92CD8C")]
		public static explicit operator FriendsGroupID_t(short value)
		{
			return default(FriendsGroupID_t);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x92CD94", Offset = "0x92CD94", VA = "0x92CD94")]
		public static explicit operator short(FriendsGroupID_t that)
		{
			return default(short);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x92CD98", Offset = "0x92CD98", VA = "0x92CD98", Slot = "4")]
		public bool Equals(FriendsGroupID_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x92CDA8", Offset = "0x92CDA8", VA = "0x92CDA8", Slot = "5")]
		public int CompareTo(FriendsGroupID_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000149")]
	public struct HHTMLBrowser : IEquatable<HHTMLBrowser>, IComparable<HHTMLBrowser>
	{
		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HHTMLBrowser Invalid;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HHTMLBrowser;

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x92D604", Offset = "0x92D604", VA = "0x92D604")]
		public HHTMLBrowser(uint value)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x92D60C", Offset = "0x92D60C", VA = "0x92D60C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x92D614", Offset = "0x92D614", VA = "0x92D614", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x92D6E0", Offset = "0x92D6E0", VA = "0x92D6E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x92D6D4", Offset = "0x92D6D4", VA = "0x92D6D4")]
		public static bool operator ==(HHTMLBrowser x, HHTMLBrowser y)
		{
			return default(bool);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x92D6E8", Offset = "0x92D6E8", VA = "0x92D6E8")]
		public static bool operator !=(HHTMLBrowser x, HHTMLBrowser y)
		{
			return default(bool);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x92D75C", Offset = "0x92D75C", VA = "0x92D75C")]
		public static explicit operator HHTMLBrowser(uint value)
		{
			return default(HHTMLBrowser);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x92D764", Offset = "0x92D764", VA = "0x92D764")]
		public static explicit operator uint(HHTMLBrowser that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x92D768", Offset = "0x92D768", VA = "0x92D768", Slot = "4")]
		public bool Equals(HHTMLBrowser other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x92D778", Offset = "0x92D778", VA = "0x92D778", Slot = "5")]
		public int CompareTo(HHTMLBrowser other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200014A")]
	public struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
	{
		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HTTPCookieContainerHandle Invalid;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HTTPCookieContainerHandle;

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x92DD1C", Offset = "0x92DD1C", VA = "0x92DD1C")]
		public HTTPCookieContainerHandle(uint value)
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x92DD24", Offset = "0x92DD24", VA = "0x92DD24", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x92DD2C", Offset = "0x92DD2C", VA = "0x92DD2C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x92DDF8", Offset = "0x92DDF8", VA = "0x92DDF8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x92DDEC", Offset = "0x92DDEC", VA = "0x92DDEC")]
		public static bool operator ==(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x92DE00", Offset = "0x92DE00", VA = "0x92DE00")]
		public static bool operator !=(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x92DE74", Offset = "0x92DE74", VA = "0x92DE74")]
		public static explicit operator HTTPCookieContainerHandle(uint value)
		{
			return default(HTTPCookieContainerHandle);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x92DE7C", Offset = "0x92DE7C", VA = "0x92DE7C")]
		public static explicit operator uint(HTTPCookieContainerHandle that)
		{
			return default(uint);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x92DE80", Offset = "0x92DE80", VA = "0x92DE80", Slot = "4")]
		public bool Equals(HTTPCookieContainerHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x92DE90", Offset = "0x92DE90", VA = "0x92DE90", Slot = "5")]
		public int CompareTo(HTTPCookieContainerHandle other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200014B")]
	public struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
	{
		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HTTPRequestHandle Invalid;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HTTPRequestHandle;

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x92DEE8", Offset = "0x92DEE8", VA = "0x92DEE8")]
		public HTTPRequestHandle(uint value)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x92DEF0", Offset = "0x92DEF0", VA = "0x92DEF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x92DEF8", Offset = "0x92DEF8", VA = "0x92DEF8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x92DFC4", Offset = "0x92DFC4", VA = "0x92DFC4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x92DFB8", Offset = "0x92DFB8", VA = "0x92DFB8")]
		public static bool operator ==(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x92DFCC", Offset = "0x92DFCC", VA = "0x92DFCC")]
		public static bool operator !=(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x92E040", Offset = "0x92E040", VA = "0x92E040")]
		public static explicit operator HTTPRequestHandle(uint value)
		{
			return default(HTTPRequestHandle);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x92E048", Offset = "0x92E048", VA = "0x92E048")]
		public static explicit operator uint(HTTPRequestHandle that)
		{
			return default(uint);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x92E04C", Offset = "0x92E04C", VA = "0x92E04C", Slot = "4")]
		public bool Equals(HTTPRequestHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x92E05C", Offset = "0x92E05C", VA = "0x92E05C", Slot = "5")]
		public int CompareTo(HTTPRequestHandle other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200014C")]
	public struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SteamInventoryResult_t Invalid;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_SteamInventoryResult;

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xD5736C", Offset = "0xD5736C", VA = "0xD5736C")]
		public SteamInventoryResult_t(int value)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xD57374", Offset = "0xD57374", VA = "0xD57374", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xD5737C", Offset = "0xD5737C", VA = "0xD5737C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xD57448", Offset = "0xD57448", VA = "0xD57448", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xD5743C", Offset = "0xD5743C", VA = "0xD5743C")]
		public static bool operator ==(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xD57450", Offset = "0xD57450", VA = "0xD57450")]
		public static bool operator !=(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xD574C4", Offset = "0xD574C4", VA = "0xD574C4")]
		public static explicit operator SteamInventoryResult_t(int value)
		{
			return default(SteamInventoryResult_t);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xD574CC", Offset = "0xD574CC", VA = "0xD574CC")]
		public static explicit operator int(SteamInventoryResult_t that)
		{
			return default(int);
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xD574D0", Offset = "0xD574D0", VA = "0xD574D0", Slot = "4")]
		public bool Equals(SteamInventoryResult_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xD574E0", Offset = "0xD574E0", VA = "0xD574E0", Slot = "5")]
		public int CompareTo(SteamInventoryResult_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200014D")]
	public struct SteamItemDef_t : IEquatable<SteamItemDef_t>, IComparable<SteamItemDef_t>
	{
		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_SteamItemDef;

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xD5753C", Offset = "0xD5753C", VA = "0xD5753C")]
		public SteamItemDef_t(int value)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xD57544", Offset = "0xD57544", VA = "0xD57544", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xD5754C", Offset = "0xD5754C", VA = "0xD5754C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xD575E0", Offset = "0xD575E0", VA = "0xD575E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xD575D4", Offset = "0xD575D4", VA = "0xD575D4")]
		public static bool operator ==(SteamItemDef_t x, SteamItemDef_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xD575E8", Offset = "0xD575E8", VA = "0xD575E8")]
		public static bool operator !=(SteamItemDef_t x, SteamItemDef_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xD575F4", Offset = "0xD575F4", VA = "0xD575F4")]
		public static explicit operator SteamItemDef_t(int value)
		{
			return default(SteamItemDef_t);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xD575FC", Offset = "0xD575FC", VA = "0xD575FC")]
		public static explicit operator int(SteamItemDef_t that)
		{
			return default(int);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xD57600", Offset = "0xD57600", VA = "0xD57600", Slot = "4")]
		public bool Equals(SteamItemDef_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xD57610", Offset = "0xD57610", VA = "0xD57610", Slot = "5")]
		public int CompareTo(SteamItemDef_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200014E")]
	public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t>
	{
		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SteamItemInstanceID_t Invalid;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamItemInstanceID;

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xD57618", Offset = "0xD57618", VA = "0xD57618")]
		public SteamItemInstanceID_t(ulong value)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xD57620", Offset = "0xD57620", VA = "0xD57620", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xD57628", Offset = "0xD57628", VA = "0xD57628", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xD576F4", Offset = "0xD576F4", VA = "0xD576F4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xD576E8", Offset = "0xD576E8", VA = "0xD576E8")]
		public static bool operator ==(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xD576FC", Offset = "0xD576FC", VA = "0xD576FC")]
		public static bool operator !=(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xD57770", Offset = "0xD57770", VA = "0xD57770")]
		public static explicit operator SteamItemInstanceID_t(ulong value)
		{
			return default(SteamItemInstanceID_t);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xD57774", Offset = "0xD57774", VA = "0xD57774")]
		public static explicit operator ulong(SteamItemInstanceID_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xD57778", Offset = "0xD57778", VA = "0xD57778", Slot = "4")]
		public bool Equals(SteamItemInstanceID_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xD57788", Offset = "0xD57788", VA = "0xD57788", Slot = "5")]
		public int CompareTo(SteamItemInstanceID_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200014F")]
	public struct HServerListRequest : IEquatable<HServerListRequest>
	{
		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HServerListRequest Invalid;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_HServerListRequest;

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x92D7D0", Offset = "0x92D7D0", VA = "0x92D7D0")]
		public HServerListRequest(IntPtr value)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x92D7D8", Offset = "0x92D7D8", VA = "0x92D7D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x92D7E0", Offset = "0x92D7E0", VA = "0x92D7E0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x92D8B4", Offset = "0x92D8B4", VA = "0x92D8B4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x92D8AC", Offset = "0x92D8AC", VA = "0x92D8AC")]
		public static bool operator ==(HServerListRequest x, HServerListRequest y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x92D8BC", Offset = "0x92D8BC", VA = "0x92D8BC")]
		public static bool operator !=(HServerListRequest x, HServerListRequest y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x92D940", Offset = "0x92D940", VA = "0x92D940")]
		public static explicit operator HServerListRequest(IntPtr value)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x92D944", Offset = "0x92D944", VA = "0x92D944")]
		public static explicit operator IntPtr(HServerListRequest that)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x92D948", Offset = "0x92D948", VA = "0x92D948", Slot = "4")]
		public bool Equals(HServerListRequest other)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000150")]
	public struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
	{
		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HServerQuery Invalid;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_HServerQuery;

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x92D9A4", Offset = "0x92D9A4", VA = "0x92D9A4")]
		public HServerQuery(int value)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x92D9AC", Offset = "0x92D9AC", VA = "0x92D9AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x92D9B4", Offset = "0x92D9B4", VA = "0x92D9B4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x92DA80", Offset = "0x92DA80", VA = "0x92DA80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x92DA74", Offset = "0x92DA74", VA = "0x92DA74")]
		public static bool operator ==(HServerQuery x, HServerQuery y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x92DA88", Offset = "0x92DA88", VA = "0x92DA88")]
		public static bool operator !=(HServerQuery x, HServerQuery y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x92DAFC", Offset = "0x92DAFC", VA = "0x92DAFC")]
		public static explicit operator HServerQuery(int value)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x92DB04", Offset = "0x92DB04", VA = "0x92DB04")]
		public static explicit operator int(HServerQuery that)
		{
			return default(int);
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x92DB08", Offset = "0x92DB08", VA = "0x92DB08", Slot = "4")]
		public bool Equals(HServerQuery other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x92DB18", Offset = "0x92DB18", VA = "0x92DB18", Slot = "5")]
		public int CompareTo(HServerQuery other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000151")]
	public struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
	{
		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_SNetListenSocket;

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xD48124", Offset = "0xD48124", VA = "0xD48124")]
		public SNetListenSocket_t(uint value)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xD4812C", Offset = "0xD4812C", VA = "0xD4812C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xD48134", Offset = "0xD48134", VA = "0xD48134", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xD481C8", Offset = "0xD481C8", VA = "0xD481C8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xD481BC", Offset = "0xD481BC", VA = "0xD481BC")]
		public static bool operator ==(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xD481D0", Offset = "0xD481D0", VA = "0xD481D0")]
		public static bool operator !=(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xD481DC", Offset = "0xD481DC", VA = "0xD481DC")]
		public static explicit operator SNetListenSocket_t(uint value)
		{
			return default(SNetListenSocket_t);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xD481E4", Offset = "0xD481E4", VA = "0xD481E4")]
		public static explicit operator uint(SNetListenSocket_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xD481E8", Offset = "0xD481E8", VA = "0xD481E8", Slot = "4")]
		public bool Equals(SNetListenSocket_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xD481F8", Offset = "0xD481F8", VA = "0xD481F8", Slot = "5")]
		public int CompareTo(SNetListenSocket_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000152")]
	public struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
	{
		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_SNetSocket;

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xD48200", Offset = "0xD48200", VA = "0xD48200")]
		public SNetSocket_t(uint value)
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xD48208", Offset = "0xD48208", VA = "0xD48208", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xD48210", Offset = "0xD48210", VA = "0xD48210", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xD482A4", Offset = "0xD482A4", VA = "0xD482A4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xD48298", Offset = "0xD48298", VA = "0xD48298")]
		public static bool operator ==(SNetSocket_t x, SNetSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xD482AC", Offset = "0xD482AC", VA = "0xD482AC")]
		public static bool operator !=(SNetSocket_t x, SNetSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xD482B8", Offset = "0xD482B8", VA = "0xD482B8")]
		public static explicit operator SNetSocket_t(uint value)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xD482C0", Offset = "0xD482C0", VA = "0xD482C0")]
		public static explicit operator uint(SNetSocket_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xD482C4", Offset = "0xD482C4", VA = "0xD482C4", Slot = "4")]
		public bool Equals(SNetSocket_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xD482D4", Offset = "0xD482D4", VA = "0xD482D4", Slot = "5")]
		public int CompareTo(SNetSocket_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000153")]
	public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t>
	{
		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PublishedFileId_t Invalid;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_PublishedFileId;

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xD47D90", Offset = "0xD47D90", VA = "0xD47D90")]
		public PublishedFileId_t(ulong value)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xD47D98", Offset = "0xD47D98", VA = "0xD47D98", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xD47DA0", Offset = "0xD47DA0", VA = "0xD47DA0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xD47E6C", Offset = "0xD47E6C", VA = "0xD47E6C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xD47E60", Offset = "0xD47E60", VA = "0xD47E60")]
		public static bool operator ==(PublishedFileId_t x, PublishedFileId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xD47E74", Offset = "0xD47E74", VA = "0xD47E74")]
		public static bool operator !=(PublishedFileId_t x, PublishedFileId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xD47EE8", Offset = "0xD47EE8", VA = "0xD47EE8")]
		public static explicit operator PublishedFileId_t(ulong value)
		{
			return default(PublishedFileId_t);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xD47EEC", Offset = "0xD47EEC", VA = "0xD47EEC")]
		public static explicit operator ulong(PublishedFileId_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xD47EF0", Offset = "0xD47EF0", VA = "0xD47EF0", Slot = "4")]
		public bool Equals(PublishedFileId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xD47F00", Offset = "0xD47F00", VA = "0xD47F00", Slot = "5")]
		public int CompareTo(PublishedFileId_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000154")]
	public struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t>
	{
		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PublishedFileUpdateHandle_t Invalid;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_PublishedFileUpdateHandle;

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xD47F58", Offset = "0xD47F58", VA = "0xD47F58")]
		public PublishedFileUpdateHandle_t(ulong value)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xD47F60", Offset = "0xD47F60", VA = "0xD47F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xD47F68", Offset = "0xD47F68", VA = "0xD47F68", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xD48034", Offset = "0xD48034", VA = "0xD48034", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xD48028", Offset = "0xD48028", VA = "0xD48028")]
		public static bool operator ==(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xD4803C", Offset = "0xD4803C", VA = "0xD4803C")]
		public static bool operator !=(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xD480B0", Offset = "0xD480B0", VA = "0xD480B0")]
		public static explicit operator PublishedFileUpdateHandle_t(ulong value)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xD480B4", Offset = "0xD480B4", VA = "0xD480B4")]
		public static explicit operator ulong(PublishedFileUpdateHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xD480B8", Offset = "0xD480B8", VA = "0xD480B8", Slot = "4")]
		public bool Equals(PublishedFileUpdateHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xD480C8", Offset = "0xD480C8", VA = "0xD480C8", Slot = "5")]
		public int CompareTo(PublishedFileUpdateHandle_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000155")]
	public struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
	{
		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCFileWriteStreamHandle_t Invalid;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCFileWriteStreamHandle;

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xDED760", Offset = "0xDED760", VA = "0xDED760")]
		public UGCFileWriteStreamHandle_t(ulong value)
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xDED768", Offset = "0xDED768", VA = "0xDED768", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xDED770", Offset = "0xDED770", VA = "0xDED770", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xDED83C", Offset = "0xDED83C", VA = "0xDED83C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xDED830", Offset = "0xDED830", VA = "0xDED830")]
		public static bool operator ==(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xDED844", Offset = "0xDED844", VA = "0xDED844")]
		public static bool operator !=(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xDE4E50", Offset = "0xDE4E50", VA = "0xDE4E50")]
		public static explicit operator UGCFileWriteStreamHandle_t(ulong value)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xDED8B8", Offset = "0xDED8B8", VA = "0xDED8B8")]
		public static explicit operator ulong(UGCFileWriteStreamHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xDED8BC", Offset = "0xDED8BC", VA = "0xDED8BC", Slot = "4")]
		public bool Equals(UGCFileWriteStreamHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xDED8CC", Offset = "0xDED8CC", VA = "0xDED8CC", Slot = "5")]
		public int CompareTo(UGCFileWriteStreamHandle_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000156")]
	public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
	{
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCHandle_t Invalid;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCHandle;

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xDED928", Offset = "0xDED928", VA = "0xDED928")]
		public UGCHandle_t(ulong value)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xDED930", Offset = "0xDED930", VA = "0xDED930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xDED938", Offset = "0xDED938", VA = "0xDED938", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xDEDA04", Offset = "0xDEDA04", VA = "0xDEDA04", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xDED9F8", Offset = "0xDED9F8", VA = "0xDED9F8")]
		public static bool operator ==(UGCHandle_t x, UGCHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xDEDA0C", Offset = "0xDEDA0C", VA = "0xDEDA0C")]
		public static bool operator !=(UGCHandle_t x, UGCHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xDE5800", Offset = "0xDE5800", VA = "0xDE5800")]
		public static explicit operator UGCHandle_t(ulong value)
		{
			return default(UGCHandle_t);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xDEDA80", Offset = "0xDEDA80", VA = "0xDEDA80")]
		public static explicit operator ulong(UGCHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xDEDA84", Offset = "0xDEDA84", VA = "0xDEDA84", Slot = "4")]
		public bool Equals(UGCHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xDEDA94", Offset = "0xDEDA94", VA = "0xDEDA94", Slot = "5")]
		public int CompareTo(UGCHandle_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000157")]
	public struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ScreenshotHandle Invalid;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_ScreenshotHandle;

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xD482DC", Offset = "0xD482DC", VA = "0xD482DC")]
		public ScreenshotHandle(uint value)
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xD482E4", Offset = "0xD482E4", VA = "0xD482E4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xD482EC", Offset = "0xD482EC", VA = "0xD482EC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xD483B8", Offset = "0xD483B8", VA = "0xD483B8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xD483AC", Offset = "0xD483AC", VA = "0xD483AC")]
		public static bool operator ==(ScreenshotHandle x, ScreenshotHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xD483C0", Offset = "0xD483C0", VA = "0xD483C0")]
		public static bool operator !=(ScreenshotHandle x, ScreenshotHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xD48434", Offset = "0xD48434", VA = "0xD48434")]
		public static explicit operator ScreenshotHandle(uint value)
		{
			return default(ScreenshotHandle);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xD4843C", Offset = "0xD4843C", VA = "0xD4843C")]
		public static explicit operator uint(ScreenshotHandle that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xD48440", Offset = "0xD48440", VA = "0xD48440", Slot = "4")]
		public bool Equals(ScreenshotHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xD48450", Offset = "0xD48450", VA = "0xD48450", Slot = "5")]
		public int CompareTo(ScreenshotHandle other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000158")]
	public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
	{
		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_AccountID;

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x92AFB4", Offset = "0x92AFB4", VA = "0x92AFB4")]
		public AccountID_t(uint value)
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x92AFBC", Offset = "0x92AFBC", VA = "0x92AFBC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x92AFC4", Offset = "0x92AFC4", VA = "0x92AFC4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x92B058", Offset = "0x92B058", VA = "0x92B058", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x92B04C", Offset = "0x92B04C", VA = "0x92B04C")]
		public static bool operator ==(AccountID_t x, AccountID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x92B060", Offset = "0x92B060", VA = "0x92B060")]
		public static bool operator !=(AccountID_t x, AccountID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x92B06C", Offset = "0x92B06C", VA = "0x92B06C")]
		public static explicit operator AccountID_t(uint value)
		{
			return default(AccountID_t);
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x92B074", Offset = "0x92B074", VA = "0x92B074")]
		public static explicit operator uint(AccountID_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x92B078", Offset = "0x92B078", VA = "0x92B078", Slot = "4")]
		public bool Equals(AccountID_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x92B088", Offset = "0x92B088", VA = "0x92B088", Slot = "5")]
		public int CompareTo(AccountID_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000159")]
	public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t>
	{
		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly AppId_t Invalid;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_AppId;

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x92B090", Offset = "0x92B090", VA = "0x92B090")]
		public AppId_t(uint value)
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x92B098", Offset = "0x92B098", VA = "0x92B098", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x92B0A0", Offset = "0x92B0A0", VA = "0x92B0A0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x92B16C", Offset = "0x92B16C", VA = "0x92B16C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x92B160", Offset = "0x92B160", VA = "0x92B160")]
		public static bool operator ==(AppId_t x, AppId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x92B174", Offset = "0x92B174", VA = "0x92B174")]
		public static bool operator !=(AppId_t x, AppId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x92B1E8", Offset = "0x92B1E8", VA = "0x92B1E8")]
		public static explicit operator AppId_t(uint value)
		{
			return default(AppId_t);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x92B1F0", Offset = "0x92B1F0", VA = "0x92B1F0")]
		public static explicit operator uint(AppId_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x92B1F4", Offset = "0x92B1F4", VA = "0x92B1F4", Slot = "4")]
		public bool Equals(AppId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x92B204", Offset = "0x92B204", VA = "0x92B204", Slot = "5")]
		public int CompareTo(AppId_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200015A")]
	public struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
	{
		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DepotId_t Invalid;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_DepotId;

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x92C8F0", Offset = "0x92C8F0", VA = "0x92C8F0")]
		public DepotId_t(uint value)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x92C8F8", Offset = "0x92C8F8", VA = "0x92C8F8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x92C900", Offset = "0x92C900", VA = "0x92C900", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x92C9CC", Offset = "0x92C9CC", VA = "0x92C9CC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x92C9C0", Offset = "0x92C9C0", VA = "0x92C9C0")]
		public static bool operator ==(DepotId_t x, DepotId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x92C9D4", Offset = "0x92C9D4", VA = "0x92C9D4")]
		public static bool operator !=(DepotId_t x, DepotId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x92CA48", Offset = "0x92CA48", VA = "0x92CA48")]
		public static explicit operator DepotId_t(uint value)
		{
			return default(DepotId_t);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x92CA50", Offset = "0x92CA50", VA = "0x92CA50")]
		public static explicit operator uint(DepotId_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x92CA54", Offset = "0x92CA54", VA = "0x92CA54", Slot = "4")]
		public bool Equals(DepotId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x92CA64", Offset = "0x92CA64", VA = "0x92CA64", Slot = "5")]
		public int CompareTo(DepotId_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200015B")]
	public struct ManifestId_t : IEquatable<ManifestId_t>, IComparable<ManifestId_t>
	{
		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ManifestId_t Invalid;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ManifestId;

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x934238", Offset = "0x934238", VA = "0x934238")]
		public ManifestId_t(ulong value)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x934240", Offset = "0x934240", VA = "0x934240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x934248", Offset = "0x934248", VA = "0x934248", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x934314", Offset = "0x934314", VA = "0x934314", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x934308", Offset = "0x934308", VA = "0x934308")]
		public static bool operator ==(ManifestId_t x, ManifestId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x93431C", Offset = "0x93431C", VA = "0x93431C")]
		public static bool operator !=(ManifestId_t x, ManifestId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x934390", Offset = "0x934390", VA = "0x934390")]
		public static explicit operator ManifestId_t(ulong value)
		{
			return default(ManifestId_t);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x934394", Offset = "0x934394", VA = "0x934394")]
		public static explicit operator ulong(ManifestId_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x934398", Offset = "0x934398", VA = "0x934398", Slot = "4")]
		public bool Equals(ManifestId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x9343A8", Offset = "0x9343A8", VA = "0x9343A8", Slot = "5")]
		public int CompareTo(ManifestId_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200015C")]
	public struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
	{
		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SteamAPICall_t Invalid;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamAPICall;

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xD485E4", Offset = "0xD485E4", VA = "0xD485E4")]
		public SteamAPICall_t(ulong value)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xD485EC", Offset = "0xD485EC", VA = "0xD485EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xD485F4", Offset = "0xD485F4", VA = "0xD485F4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xD486C0", Offset = "0xD486C0", VA = "0xD486C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xD486B4", Offset = "0xD486B4", VA = "0xD486B4")]
		public static bool operator ==(SteamAPICall_t x, SteamAPICall_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xD486C8", Offset = "0xD486C8", VA = "0xD486C8")]
		public static bool operator !=(SteamAPICall_t x, SteamAPICall_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xD4873C", Offset = "0xD4873C", VA = "0xD4873C")]
		public static explicit operator SteamAPICall_t(ulong value)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xD48740", Offset = "0xD48740", VA = "0xD48740")]
		public static explicit operator ulong(SteamAPICall_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xD48744", Offset = "0xD48744", VA = "0xD48744", Slot = "4")]
		public bool Equals(SteamAPICall_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xD48754", Offset = "0xD48754", VA = "0xD48754", Slot = "5")]
		public int CompareTo(SteamAPICall_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200015D")]
	public struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
	{
		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCQueryHandle_t Invalid;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCQueryHandle;

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xDEDAF0", Offset = "0xDEDAF0", VA = "0xDEDAF0")]
		public UGCQueryHandle_t(ulong value)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xDEDAF8", Offset = "0xDEDAF8", VA = "0xDEDAF8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xDEDB00", Offset = "0xDEDB00", VA = "0xDEDB00", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xDEDBCC", Offset = "0xDEDBCC", VA = "0xDEDBCC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xDEDBC0", Offset = "0xDEDBC0", VA = "0xDEDBC0")]
		public static bool operator ==(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xDEDBD4", Offset = "0xDEDBD4", VA = "0xDEDBD4")]
		public static bool operator !=(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xDE77C0", Offset = "0xDE77C0", VA = "0xDE77C0")]
		public static explicit operator UGCQueryHandle_t(ulong value)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xDEDC48", Offset = "0xDEDC48", VA = "0xDEDC48")]
		public static explicit operator ulong(UGCQueryHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xDEDC4C", Offset = "0xDEDC4C", VA = "0xDEDC4C", Slot = "4")]
		public bool Equals(UGCQueryHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xDEDC5C", Offset = "0xDEDC5C", VA = "0xDEDC5C", Slot = "5")]
		public int CompareTo(UGCQueryHandle_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200015E")]
	public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
	{
		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCUpdateHandle_t Invalid;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCUpdateHandle;

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xDEDCB8", Offset = "0xDEDCB8", VA = "0xDEDCB8")]
		public UGCUpdateHandle_t(ulong value)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xDEDCC0", Offset = "0xDEDCC0", VA = "0xDEDCC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xDEDCC8", Offset = "0xDEDCC8", VA = "0xDEDCC8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xDEDD94", Offset = "0xDEDD94", VA = "0xDEDD94", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xDEDD88", Offset = "0xDEDD88", VA = "0xDEDD88")]
		public static bool operator ==(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xDEDD9C", Offset = "0xDEDD9C", VA = "0xDEDD9C")]
		public static bool operator !=(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xDE8AD0", Offset = "0xDE8AD0", VA = "0xDE8AD0")]
		public static explicit operator UGCUpdateHandle_t(ulong value)
		{
			return default(UGCUpdateHandle_t);
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xDEDE10", Offset = "0xDEDE10", VA = "0xDEDE10")]
		public static explicit operator ulong(UGCUpdateHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xDEDE14", Offset = "0xDEDE14", VA = "0xDEDE14", Slot = "4")]
		public bool Equals(UGCUpdateHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xDEDE24", Offset = "0xDEDE24", VA = "0xDEDE24", Slot = "5")]
		public int CompareTo(UGCUpdateHandle_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200015F")]
	public struct ClientUnifiedMessageHandle : IEquatable<ClientUnifiedMessageHandle>, IComparable<ClientUnifiedMessageHandle>
	{
		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ClientUnifiedMessageHandle Invalid;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ClientUnifiedMessageHandle;

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x92C728", Offset = "0x92C728", VA = "0x92C728")]
		public ClientUnifiedMessageHandle(ulong value)
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x92C730", Offset = "0x92C730", VA = "0x92C730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x92C738", Offset = "0x92C738", VA = "0x92C738", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x92C804", Offset = "0x92C804", VA = "0x92C804", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x92C7F8", Offset = "0x92C7F8", VA = "0x92C7F8")]
		public static bool operator ==(ClientUnifiedMessageHandle x, ClientUnifiedMessageHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x92C80C", Offset = "0x92C80C", VA = "0x92C80C")]
		public static bool operator !=(ClientUnifiedMessageHandle x, ClientUnifiedMessageHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x92C880", Offset = "0x92C880", VA = "0x92C880")]
		public static explicit operator ClientUnifiedMessageHandle(ulong value)
		{
			return default(ClientUnifiedMessageHandle);
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x92C884", Offset = "0x92C884", VA = "0x92C884")]
		public static explicit operator ulong(ClientUnifiedMessageHandle that)
		{
			return default(ulong);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x92C888", Offset = "0x92C888", VA = "0x92C888", Slot = "4")]
		public bool Equals(ClientUnifiedMessageHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x92C898", Offset = "0x92C898", VA = "0x92C898", Slot = "5")]
		public int CompareTo(ClientUnifiedMessageHandle other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000160")]
	public struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
	{
		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamLeaderboardEntries;

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xD577E4", Offset = "0xD577E4", VA = "0xD577E4")]
		public SteamLeaderboardEntries_t(ulong value)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xD577EC", Offset = "0xD577EC", VA = "0xD577EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xD577F4", Offset = "0xD577F4", VA = "0xD577F4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xD57888", Offset = "0xD57888", VA = "0xD57888", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xD5787C", Offset = "0xD5787C", VA = "0xD5787C")]
		public static bool operator ==(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xD57890", Offset = "0xD57890", VA = "0xD57890")]
		public static bool operator !=(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xD5789C", Offset = "0xD5789C", VA = "0xD5789C")]
		public static explicit operator SteamLeaderboardEntries_t(ulong value)
		{
			return default(SteamLeaderboardEntries_t);
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xD578A0", Offset = "0xD578A0", VA = "0xD578A0")]
		public static explicit operator ulong(SteamLeaderboardEntries_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xD578A4", Offset = "0xD578A4", VA = "0xD578A4", Slot = "4")]
		public bool Equals(SteamLeaderboardEntries_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xD578B4", Offset = "0xD578B4", VA = "0xD578B4", Slot = "5")]
		public int CompareTo(SteamLeaderboardEntries_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000161")]
	public struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
	{
		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamLeaderboard;

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xD578BC", Offset = "0xD578BC", VA = "0xD578BC")]
		public SteamLeaderboard_t(ulong value)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xD578C4", Offset = "0xD578C4", VA = "0xD578C4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xD578CC", Offset = "0xD578CC", VA = "0xD578CC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xD57960", Offset = "0xD57960", VA = "0xD57960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xD57954", Offset = "0xD57954", VA = "0xD57954")]
		public static bool operator ==(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xD57968", Offset = "0xD57968", VA = "0xD57968")]
		public static bool operator !=(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xD57974", Offset = "0xD57974", VA = "0xD57974")]
		public static explicit operator SteamLeaderboard_t(ulong value)
		{
			return default(SteamLeaderboard_t);
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xD57978", Offset = "0xD57978", VA = "0xD57978")]
		public static explicit operator ulong(SteamLeaderboard_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xD5797C", Offset = "0xD5797C", VA = "0xD5797C", Slot = "4")]
		public bool Equals(SteamLeaderboard_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xD5798C", Offset = "0xD5798C", VA = "0xD5798C", Slot = "5")]
		public int CompareTo(SteamLeaderboard_t other)
		{
			return default(int);
		}
	}
}
namespace Beebyte.Obfuscator
{
	[Token(Token = "0x2000162")]
	public enum MessageCode
	{
		[Token(Token = "0x40006DE")]
		UnityReflectionMethodNotFound
	}
	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x7ED5C4", Offset = "0x7ED5C4")]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x92A97C", Offset = "0x92A97C", VA = "0x92A97C")]
		public ObfuscateLiteralsAttribute()
		{
		}
	}
	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x7ED5D8", Offset = "0x7ED5D8")]
	public class SuppressLogAttribute : Attribute
	{
		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly MessageCode _messageCode;

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x92A984", Offset = "0x92A984", VA = "0x92A984")]
		private SuppressLogAttribute()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x92A98C", Offset = "0x92A98C", VA = "0x92A98C")]
		public SuppressLogAttribute(MessageCode messageCode)
		{
		}
	}
}
