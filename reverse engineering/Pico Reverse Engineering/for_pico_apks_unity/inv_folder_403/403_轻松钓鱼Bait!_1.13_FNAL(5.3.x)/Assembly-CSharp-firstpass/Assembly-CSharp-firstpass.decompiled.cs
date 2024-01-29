using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using DarkTonic.MasterAudio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class AudioLoaderOptimizer
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x5028C0", Offset = "0x5028C0", VA = "0x5028C0")]
	public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x502AF4", Offset = "0x502AF4", VA = "0x502AF4")]
	public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x502CE4", Offset = "0x502CE4", VA = "0x502CE4")]
	public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x3F4C30", Offset = "0x3F4C30")]
public class ListenerFollower : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _transToFollow;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SphereCollider _collider;

	[Token(Token = "0x17000001")]
	public SphereCollider Trigger
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x717E48", Offset = "0x717E48", VA = "0x717E48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public GameObject GameObj
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x718284", Offset = "0x718284", VA = "0x718284")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public Transform Trans
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x7181F4", Offset = "0x7181F4", VA = "0x7181F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x717DCC", Offset = "0x717DCC", VA = "0x717DCC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x717F0C", Offset = "0x717F0C", VA = "0x717F0C")]
	public void StartFollowing(Transform transToFollow, string soundType, float trigRadius)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x717F78", Offset = "0x717F78", VA = "0x717F78")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x71807C", Offset = "0x71807C", VA = "0x71807C")]
	private void BatchOcclusionRaycasts()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x718314", Offset = "0x718314", VA = "0x718314")]
	public ListenerFollower()
	{
	}
}
[Token(Token = "0x2000004")]
public static class ResonanceAudioHelper
{
	[Token(Token = "0x17000004")]
	public static bool ResonanceAudioOptionExists
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x717C40", Offset = "0x717C40", VA = "0x717C40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x718334", Offset = "0x718334", VA = "0x718334")]
	public static bool AddResonanceAudioSourceToAllVariations()
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x71833C", Offset = "0x71833C", VA = "0x71833C")]
	public static bool RemoveResonanceAudioSourceFromAllVariations()
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x718344", Offset = "0x718344", VA = "0x718344")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x718348", Offset = "0x718348", VA = "0x718348")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x71834C", Offset = "0x71834C", VA = "0x71834C")]
	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000005")]
public class TransformFollower : MonoBehaviour
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F52FC", Offset = "0x3F52FC")]
	public Transform RuntimeFollowingTransform;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SphereCollider _collider;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _soundType;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool _willFollowSource;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool _isInsideTrigger;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	private bool _hasPlayedSound;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
	private bool _groupLoadFailed;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MasterAudioGroup _groupToPlay;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _positionAtClosestColliderPoint;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly List<Collider> _actorColliders;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly List<Collider2D> _actorColliders2D;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 _lastListenerPos;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly Dictionary<Collider, Vector3> _lastPositionByCollider;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly Dictionary<Collider2D, Vector3> _lastPositionByCollider2D;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PlaySoundResult playingVariation;

	[Token(Token = "0x17000005")]
	public SphereCollider Trigger
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x71849C", Offset = "0x71849C", VA = "0x71849C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public GameObject GameObj
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x718CBC", Offset = "0x718CBC", VA = "0x718CBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	public Transform Trans
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x719610", Offset = "0x719610", VA = "0x719610")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x718350", Offset = "0x718350", VA = "0x718350")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x718560", Offset = "0x718560", VA = "0x718560")]
	private void Start()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x7185D8", Offset = "0x7185D8", VA = "0x7185D8")]
	public void StartFollowing(Transform transToFollow, string soundType, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x718C40", Offset = "0x718C40", VA = "0x718C40")]
	private void StopFollowing()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x718D4C", Offset = "0x718D4C", VA = "0x718D4C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x7190E4", Offset = "0x7190E4", VA = "0x7190E4")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x71926C", Offset = "0x71926C", VA = "0x71926C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x7196A0", Offset = "0x7196A0", VA = "0x7196A0")]
	public bool RecalcClosestColliderPosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x71A008", Offset = "0x71A008", VA = "0x71A008")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x71A128", Offset = "0x71A128", VA = "0x71A128")]
	public TransformFollower()
	{
	}
}
[Token(Token = "0x2000006")]
public class EnumFlagAttribute : PropertyAttribute
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string enumName;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x717D98", Offset = "0x717D98", VA = "0x717D98")]
	public EnumFlagAttribute()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x717DA0", Offset = "0x717DA0", VA = "0x717DA0")]
	public EnumFlagAttribute(string name)
	{
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000007")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3F4C44", Offset = "0x3F4C44")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x71A250", Offset = "0x71A250", VA = "0x71A250")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x71A274", Offset = "0x71A274", VA = "0x71A274")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x71A2D4", Offset = "0x71A2D4", VA = "0x71A2D4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x71A334", Offset = "0x71A334", VA = "0x71A334")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000008")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3F4CB8", Offset = "0x3F4CB8")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x71A33C", Offset = "0x71A33C", VA = "0x71A33C")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class MeshContainer
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x71A344", Offset = "0x71A344", VA = "0x71A344")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x71A3B8", Offset = "0x71A3B8", VA = "0x71A3B8")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3F4D2C", Offset = "0x3F4D2C")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x71A41C", Offset = "0x71A41C", VA = "0x71A41C")]
		public void Start()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x71A5CC", Offset = "0x71A5CC", VA = "0x71A5CC")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x71A98C", Offset = "0x71A98C", VA = "0x71A98C")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x71AAB0", Offset = "0x71AAB0", VA = "0x71AAB0")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x71ABD0", Offset = "0x71ABD0", VA = "0x71ABD0")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x71B824", Offset = "0x71B824", VA = "0x71B824")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x71B884", Offset = "0x71B884", VA = "0x71B884")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x71B98C", Offset = "0x71B98C", VA = "0x71B98C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x71B9EC", Offset = "0x71B9EC", VA = "0x71B9EC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x71AD60", Offset = "0x71AD60", VA = "0x71AD60")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x71BA4C", Offset = "0x71BA4C", VA = "0x71BA4C")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x71BFDC", Offset = "0x71BFDC", VA = "0x71BFDC")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x71BB30", Offset = "0x71BB30", VA = "0x71BB30")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x71C224", Offset = "0x71C224", VA = "0x71C224")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x71BDF4", Offset = "0x71BDF4", VA = "0x71BDF4")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x71C244", Offset = "0x71C244", VA = "0x71C244")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3F4DA0", Offset = "0x3F4DA0")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x71C2B8", Offset = "0x71C2B8", VA = "0x71C2B8")]
		public void Start()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x71C3F0", Offset = "0x71C3F0", VA = "0x71C3F0")]
		public void Update()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x71C6A8", Offset = "0x71C6A8", VA = "0x71C6A8")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x200000C")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000054")]
		public enum WaterMode
		{
			[Token(Token = "0x4000414")]
			Simple,
			[Token(Token = "0x4000415")]
			Reflective,
			[Token(Token = "0x4000416")]
			Refractive
		}

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xD25EC8", Offset = "0xD25EC8", VA = "0xD25EC8")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xD28208", Offset = "0xD28208", VA = "0xD28208")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xD285B4", Offset = "0xD285B4", VA = "0xD285B4")]
		private void Update()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xD279A8", Offset = "0xD279A8", VA = "0xD279A8")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xD26C24", Offset = "0xD26C24", VA = "0xD26C24")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xD26C10", Offset = "0xD26C10", VA = "0xD26C10")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xD26AB8", Offset = "0xD26AB8", VA = "0xD26AB8")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xD28020", Offset = "0xD28020", VA = "0xD28020")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xD27D7C", Offset = "0xD27D7C", VA = "0xD27D7C")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xD28894", Offset = "0xD28894", VA = "0xD28894")]
		public Water()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public enum WaterQuality
	{
		[Token(Token = "0x4000037")]
		High = 2,
		[Token(Token = "0x4000038")]
		Medium = 1,
		[Token(Token = "0x4000039")]
		Low = 0
	}
	[Token(Token = "0x200000E")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject mainCamera;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Camera[] cameras;

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xD28970", Offset = "0xD28970", VA = "0xD28970")]
		private void Start()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xD28A28", Offset = "0xD28A28", VA = "0xD28A28")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xD28C18", Offset = "0xD28C18", VA = "0xD28C18")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xD28CF0", Offset = "0xD28CF0", VA = "0xD28CF0")]
		public void Update()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xD28D74", Offset = "0xD28D74", VA = "0xD28D74")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xD28D8C", Offset = "0xD28D8C", VA = "0xD28D8C")]
		public void Start()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xD28D90", Offset = "0xD28D90", VA = "0xD28D90")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xD28F88", Offset = "0xD28F88", VA = "0xD28F88")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xD290BC", Offset = "0xD290BC", VA = "0xD290BC")]
		public WaterTile()
		{
		}
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x3F4E44", Offset = "0x3F4E44")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x71831C", Offset = "0x71831C", VA = "0x71831C")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x3F4E58", Offset = "0x3F4E58")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x718324", Offset = "0x718324", VA = "0x718324")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x3F4E6C", Offset = "0x3F4E6C")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x71832C", Offset = "0x71832C", VA = "0x71832C")]
		public RelatingAttribute()
		{
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3F4E80", Offset = "0x3F4E80")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x3F4E80", Offset = "0x3F4E80")]
	public class AmbientSound : MonoBehaviour
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SoundGroup]
		public string AmbientSoundGroup;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5344", Offset = "0x3F5344")]
		public bool FollowCaller;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F537C", Offset = "0x3F537C")]
		public bool UseClosestColliderPosition;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool UseTopCollider;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool IncludeChildColliders;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F53B4", Offset = "0x3F53B4")]
		public Transform RuntimeFollower;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _trans;

		[Token(Token = "0x17000008")]
		public bool IsValidSoundGroup
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x50332C", Offset = "0x50332C", VA = "0x50332C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public Transform Trans
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x503594", Offset = "0x503594", VA = "0x503594")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x502E78", Offset = "0x502E78", VA = "0x502E78")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x5031B4", Offset = "0x5031B4", VA = "0x5031B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x502E7C", Offset = "0x502E7C", VA = "0x502E7C")]
		private void StartTrackers()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x503ED0", Offset = "0x503ED0", VA = "0x503ED0")]
		public AmbientSound()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3F4ED0", Offset = "0x3F4ED0")]
	public class ButtonClicker : MonoBehaviour
	{
		[Token(Token = "0x4000048")]
		public const float SmallSizeMultiplier = 0.9f;

		[Token(Token = "0x4000049")]
		public const float LargeSizeMultiplier = 1.1f;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool resizeOnClick;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool resizeClickAllSiblings;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool resizeOnHover;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool resizeHoverAllSiblings;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseDownSound;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mouseUpSound;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mouseClickSound;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mouseOverSound;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mouseOutSound;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalSize;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _smallerSize;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _largerSize;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _trans;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x50CD3C", Offset = "0x50CD3C", VA = "0x50CD3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x50D090", Offset = "0x50D090", VA = "0x50D090")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x50D63C", Offset = "0x50D63C", VA = "0x50D63C")]
		private void OnClick()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x50D6D8", Offset = "0x50D6D8", VA = "0x50D6D8")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x50DAAC", Offset = "0x50DAAC", VA = "0x50DAAC")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x3F4F08", Offset = "0x3F4F08")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3F4F08", Offset = "0x3F4F08")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x2000055")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x4000418")]
			Legacy,
			[Token(Token = "0x4000419")]
			uGUI
		}

		[Token(Token = "0x2000056")]
		public enum EventType
		{
			[Token(Token = "0x400041B")]
			OnStart,
			[Token(Token = "0x400041C")]
			OnVisible,
			[Token(Token = "0x400041D")]
			OnInvisible,
			[Token(Token = "0x400041E")]
			OnCollision,
			[Token(Token = "0x400041F")]
			OnTriggerEnter,
			[Token(Token = "0x4000420")]
			OnTriggerExit,
			[Token(Token = "0x4000421")]
			OnMouseEnter,
			[Token(Token = "0x4000422")]
			OnMouseClick,
			[Token(Token = "0x4000423")]
			OnSpawned,
			[Token(Token = "0x4000424")]
			OnDespawned,
			[Token(Token = "0x4000425")]
			OnEnable,
			[Token(Token = "0x4000426")]
			OnDisable,
			[Token(Token = "0x4000427")]
			OnCollision2D,
			[Token(Token = "0x4000428")]
			OnTriggerEnter2D,
			[Token(Token = "0x4000429")]
			OnTriggerExit2D,
			[Token(Token = "0x400042A")]
			OnParticleCollision,
			[Token(Token = "0x400042B")]
			UserDefinedEvent,
			[Token(Token = "0x400042C")]
			OnCollisionExit,
			[Token(Token = "0x400042D")]
			OnCollisionExit2D,
			[Token(Token = "0x400042E")]
			OnMouseUp,
			[Token(Token = "0x400042F")]
			OnMouseExit,
			[Token(Token = "0x4000430")]
			OnMouseDrag,
			[Token(Token = "0x4000431")]
			NGUIOnClick,
			[Token(Token = "0x4000432")]
			NGUIMouseDown,
			[Token(Token = "0x4000433")]
			NGUIMouseUp,
			[Token(Token = "0x4000434")]
			NGUIMouseEnter,
			[Token(Token = "0x4000435")]
			NGUIMouseExit,
			[Token(Token = "0x4000436")]
			MechanimStateChanged,
			[Token(Token = "0x4000437")]
			UnitySliderChanged,
			[Token(Token = "0x4000438")]
			UnityButtonClicked,
			[Token(Token = "0x4000439")]
			UnityPointerDown,
			[Token(Token = "0x400043A")]
			UnityPointerUp,
			[Token(Token = "0x400043B")]
			UnityPointerEnter,
			[Token(Token = "0x400043C")]
			UnityPointerExit,
			[Token(Token = "0x400043D")]
			UnityDrag,
			[Token(Token = "0x400043E")]
			UnityDrop,
			[Token(Token = "0x400043F")]
			UnityScroll,
			[Token(Token = "0x4000440")]
			UnityUpdateSelected,
			[Token(Token = "0x4000441")]
			UnitySelect,
			[Token(Token = "0x4000442")]
			UnityDeselect,
			[Token(Token = "0x4000443")]
			UnityMove,
			[Token(Token = "0x4000444")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x4000445")]
			UnityBeginDrag,
			[Token(Token = "0x4000446")]
			UnityEndDrag,
			[Token(Token = "0x4000447")]
			UnitySubmit,
			[Token(Token = "0x4000448")]
			UnityCancel,
			[Token(Token = "0x4000449")]
			UnityToggle,
			[Token(Token = "0x400044A")]
			OnTriggerStay,
			[Token(Token = "0x400044B")]
			OnTriggerStay2D
		}

		[Token(Token = "0x2000057")]
		public enum GlidePitchType
		{
			[Token(Token = "0x400044D")]
			None,
			[Token(Token = "0x400044E")]
			RaisePitch,
			[Token(Token = "0x400044F")]
			LowerPitch
		}

		[Token(Token = "0x2000058")]
		public enum VariationType
		{
			[Token(Token = "0x4000451")]
			PlaySpecific,
			[Token(Token = "0x4000452")]
			PlayRandom
		}

		[Token(Token = "0x2000059")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x4000454")]
			None,
			[Token(Token = "0x4000455")]
			Stop,
			[Token(Token = "0x4000456")]
			FadeOut
		}

		[Token(Token = "0x200005A")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x4000458")]
			None,
			[Token(Token = "0x4000459")]
			FrameBased,
			[Token(Token = "0x400045A")]
			TimeBased
		}

		[Token(Token = "0x200005B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F50FC", Offset = "0x3F50FC")]
		private sealed class <CoUpdate>d__123 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x170000AD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003B3")]
				[Address(RVA = "0x522B34", Offset = "0x522B34", VA = "0x522B34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B5")]
				[Address(RVA = "0x522BA4", Offset = "0x522BA4", VA = "0x522BA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x513B4C", Offset = "0x513B4C", VA = "0x513B4C")]
			[DebuggerHidden]
			public <CoUpdate>d__123(int <>1__state)
			{
			}

			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x52295C", Offset = "0x52295C", VA = "0x52295C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x522960", Offset = "0x522960", VA = "0x522960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x522B3C", Offset = "0x522B3C", VA = "0x522B3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F510C", Offset = "0x3F510C")]
		private sealed class <>c__DisplayClass172_0
		{
			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string stateName;

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x5160F4", Offset = "0x5160F4", VA = "0x5160F4")]
			public <>c__DisplayClass172_0()
			{
			}

			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x522924", Offset = "0x522924", VA = "0x522924")]
			internal bool <GetMechanimAudioEventGroup>b__0(AudioEventGroup grp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool showGizmo;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableSounds;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool showPoolManager;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool showNGUI;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public UnityUIVersion unityUIMode;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool logMissingEvents;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LayerTagFilterEvents;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEventGroup startSound;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioEventGroup visibleSound;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEventGroup invisibleSound;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioEventGroup collisionSound;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioEventGroup collisionExitSound;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioEventGroup triggerSound;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioEventGroup triggerExitSound;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioEventGroup triggerStaySound;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioEventGroup mouseEnterSound;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioEventGroup mouseExitSound;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioEventGroup mouseClickSound;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioEventGroup mouseUpSound;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioEventGroup mouseDragSound;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioEventGroup spawnedSound;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AudioEventGroup despawnedSound;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioEventGroup enableSound;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEventGroup disableSound;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AudioEventGroup collision2dSound;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AudioEventGroup collisionExit2dSound;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public AudioEventGroup triggerEnter2dSound;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AudioEventGroup triggerStay2dSound;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AudioEventGroup triggerExit2dSound;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioEventGroup particleCollisionSound;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioEventGroup nguiOnClickSound;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioEventGroup nguiMouseDownSound;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioEventGroup nguiMouseUpSound;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public AudioEventGroup nguiMouseEnterSound;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioEventGroup nguiMouseExitSound;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioEventGroup unitySliderChangedSound;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioEventGroup unityButtonClickedSound;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public AudioEventGroup unityPointerDownSound;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioEventGroup unityDragSound;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEventGroup unityPointerUpSound;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioEventGroup unityPointerEnterSound;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioEventGroup unityPointerExitSound;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEventGroup unityDropSound;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public AudioEventGroup unityScrollSound;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioEventGroup unityUpdateSelectedSound;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioEventGroup unitySelectSound;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioEventGroup unityDeselectSound;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public AudioEventGroup unityMoveSound;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public AudioEventGroup unityInitializePotentialDragSound;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public AudioEventGroup unityBeginDragSound;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public AudioEventGroup unityEndDragSound;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AudioEventGroup unitySubmitSound;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AudioEventGroup unityCancelSound;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public AudioEventGroup unityToggleSound;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public List<AudioEventGroup> userDefinedSounds;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<AudioEventGroup> mechanimStateChangedSounds;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public bool useStartSound;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		public bool useVisibleSound;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		public bool useInvisibleSound;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		public bool useCollisionSound;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public bool useCollisionExitSound;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		public bool useTriggerEnterSound;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		public bool useTriggerExitSound;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		public bool useTriggerStaySound;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool useMouseEnterSound;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
		public bool useMouseExitSound;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C2")]
		public bool useMouseClickSound;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C3")]
		public bool useMouseUpSound;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public bool useMouseDragSound;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C5")]
		public bool useSpawnedSound;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C6")]
		public bool useDespawnedSound;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C7")]
		public bool useEnableSound;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useDisableSound;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useCollision2dSound;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool useCollisionExit2dSound;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool useTriggerEnter2dSound;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool useTriggerStay2dSound;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool useTriggerExit2dSound;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool useParticleCollisionSound;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool useNguiOnClickSound;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool useNguiMouseDownSound;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool useNguiMouseUpSound;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool useNguiMouseEnterSound;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool useNguiMouseExitSound;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool useUnitySliderChangedSound;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		public bool useUnityButtonClickedSound;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6")]
		public bool useUnityPointerDownSound;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7")]
		public bool useUnityDragSound;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool useUnityPointerUpSound;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
		public bool useUnityPointerEnterSound;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DA")]
		public bool useUnityPointerExitSound;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DB")]
		public bool useUnityDropSound;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public bool useUnityScrollSound;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
		public bool useUnityUpdateSelectedSound;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
		public bool useUnitySelectSound;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
		public bool useUnityDeselectSound;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool useUnityMoveSound;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		public bool useUnityInitializePotentialDragSound;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		public bool useUnityBeginDragSound;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		public bool useUnityEndDragSound;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public bool useUnitySubmitSound;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		public bool useUnityCancelSound;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E6")]
		public bool useUnityToggleSound;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Slider _slider;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Toggle _toggle;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Button _button;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private bool _isVisible;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x201")]
		private bool _needsCoroutine;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private float? _triggerEnterTime;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private float? _triggerEnter2dTime;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Transform _trans;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Animator _anim;

		[Token(Token = "0x1700000A")]
		private bool IsSetToUGUI
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x513794", Offset = "0x513794", VA = "0x513794")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x515F14", Offset = "0x515F14", VA = "0x515F14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x5136C8", Offset = "0x5136C8", VA = "0x5136C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x513960", Offset = "0x513960", VA = "0x513960", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x513AD8", Offset = "0x513AD8", VA = "0x513AD8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3F5E68", Offset = "0x3F5E68")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x513B78", Offset = "0x513B78", VA = "0x513B78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x5141FC", Offset = "0x5141FC", VA = "0x5141FC")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x514224", Offset = "0x514224", VA = "0x514224")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x514240", Offset = "0x514240", VA = "0x514240")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x5144D4", Offset = "0x5144D4", VA = "0x5144D4")]
		private void RestorePersistentSliders()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x5148D0", Offset = "0x5148D0", VA = "0x5148D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x514C70", Offset = "0x514C70", VA = "0x514C70")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x514E18", Offset = "0x514E18", VA = "0x514E18")]
		private void OnTriggerStay2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x514F2C", Offset = "0x514F2C", VA = "0x514F2C")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x5150B4", Offset = "0x5150B4", VA = "0x5150B4")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x515234", Offset = "0x515234", VA = "0x515234")]
		private void OnCollisionExit2D(Collision2D collision)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x5153B4", Offset = "0x5153B4", VA = "0x5153B4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x515534", Offset = "0x515534", VA = "0x515534")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x5156B4", Offset = "0x5156B4", VA = "0x5156B4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x51585C", Offset = "0x51585C", VA = "0x51585C")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x515970", Offset = "0x515970", VA = "0x515970")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x515AF8", Offset = "0x515AF8", VA = "0x515AF8")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x515C78", Offset = "0x515C78", VA = "0x515C78")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x515C98", Offset = "0x515C98", VA = "0x515C98")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x515CB8", Offset = "0x515CB8", VA = "0x515CB8")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x515CD8", Offset = "0x515CD8", VA = "0x515CD8")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x515CF8", Offset = "0x515CF8", VA = "0x515CF8")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x515CFC", Offset = "0x515CFC", VA = "0x515CFC")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x515D1C", Offset = "0x515D1C", VA = "0x515D1C")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x515D20", Offset = "0x515D20", VA = "0x515D20")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x515D40", Offset = "0x515D40", VA = "0x515D40")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x515D60", Offset = "0x515D60", VA = "0x515D60")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x515D80", Offset = "0x515D80", VA = "0x515D80")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x515D84", Offset = "0x515D84", VA = "0x515D84")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x515DA4", Offset = "0x515DA4", VA = "0x515DA4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x515DC4", Offset = "0x515DC4", VA = "0x515DC4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x515DE4", Offset = "0x515DE4", VA = "0x515DE4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x515E04", Offset = "0x515E04", VA = "0x515E04")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x515E24", Offset = "0x515E24", VA = "0x515E24")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x515E44", Offset = "0x515E44", VA = "0x515E44")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x515E64", Offset = "0x515E64", VA = "0x515E64")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x515E84", Offset = "0x515E84", VA = "0x515E84")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x515EE4", Offset = "0x515EE4", VA = "0x515EE4")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x515EFC", Offset = "0x515EFC", VA = "0x515EFC")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x515F24", Offset = "0x515F24", VA = "0x515F24")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x515F5C", Offset = "0x515F5C", VA = "0x515F5C")]
		private void OnClick()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x515F7C", Offset = "0x515F7C", VA = "0x515F7C")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x515FB4", Offset = "0x515FB4", VA = "0x515FB4")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x516004", Offset = "0x516004", VA = "0x516004")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x516024", Offset = "0x516024", VA = "0x516024")]
		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x513FE4", Offset = "0x513FE4", VA = "0x513FE4")]
		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x518C48", Offset = "0x518C48", VA = "0x518C48")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x5160FC", Offset = "0x5160FC", VA = "0x5160FC")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x51626C", Offset = "0x51626C", VA = "0x51626C")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x5211FC", Offset = "0x5211FC", VA = "0x5211FC")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x513BB8", Offset = "0x513BB8", VA = "0x513BB8", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x521694", Offset = "0x521694", VA = "0x521694", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x5217A8", Offset = "0x5217A8", VA = "0x5217A8", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x51482C", Offset = "0x51482C", VA = "0x51482C", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x514BD4", Offset = "0x514BD4", VA = "0x514BD4", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x522188", Offset = "0x522188", VA = "0x522188", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x5137A4", Offset = "0x5137A4", VA = "0x5137A4")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x600009B")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x5221E8", Offset = "0x5221E8", VA = "0x5221E8")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F53EC", Offset = "0x3F53EC")]
		private EventSounds <eventSounds>k__BackingField;

		[Token(Token = "0x1700000C")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x522C5C", Offset = "0x522C5C", VA = "0x522C5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5ECC", Offset = "0x3F5ECC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x523684", Offset = "0x523684", VA = "0x523684")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5EDC", Offset = "0x3F5EDC")]
			set
			{
			}
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x522C6C", Offset = "0x522C6C", VA = "0x522C6C")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x523234", Offset = "0x523234", VA = "0x523234", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x5232E4", Offset = "0x5232E4", VA = "0x5232E4")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x5232EC", Offset = "0x5232EC", VA = "0x5232EC", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x52339C", Offset = "0x52339C", VA = "0x52339C")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x52317C", Offset = "0x52317C", VA = "0x52317C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x52322C", Offset = "0x52322C", VA = "0x52322C")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x5233A4", Offset = "0x5233A4", VA = "0x5233A4", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x523454", Offset = "0x523454", VA = "0x523454")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x522DE4", Offset = "0x522DE4", VA = "0x522DE4", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x522E94", Offset = "0x522E94", VA = "0x522E94")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x522E9C", Offset = "0x522E9C", VA = "0x522E9C", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x522F4C", Offset = "0x522F4C", VA = "0x522F4C")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x52345C", Offset = "0x52345C", VA = "0x52345C", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x52350C", Offset = "0x52350C", VA = "0x52350C")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x52368C", Offset = "0x52368C", VA = "0x52368C", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x52373C", Offset = "0x52373C", VA = "0x52373C")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x523514", Offset = "0x523514", VA = "0x523514", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x5235C4", Offset = "0x5235C4", VA = "0x5235C4")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x522D2C", Offset = "0x522D2C", VA = "0x522D2C", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x522DDC", Offset = "0x522DDC", VA = "0x522DDC")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x5230C4", Offset = "0x5230C4", VA = "0x5230C4", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x523174", Offset = "0x523174", VA = "0x523174")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x52300C", Offset = "0x52300C", VA = "0x52300C", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x5230BC", Offset = "0x5230BC", VA = "0x5230BC")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x522BAC", Offset = "0x522BAC", VA = "0x522BAC", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x522C64", Offset = "0x522C64", VA = "0x522C64")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x522F54", Offset = "0x522F54", VA = "0x522F54", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x523004", Offset = "0x523004", VA = "0x523004")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x5235CC", Offset = "0x5235CC", VA = "0x5235CC", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x52367C", Offset = "0x52367C", VA = "0x52367C")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x522C74", Offset = "0x522C74", VA = "0x522C74", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x522D24", Offset = "0x522D24", VA = "0x522D24")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3F4F58", Offset = "0x3F4F58")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x200005D")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x4000460")]
			None,
			[Token(Token = "0x4000461")]
			OnCollision,
			[Token(Token = "0x4000462")]
			OnTriggerEnter,
			[Token(Token = "0x4000463")]
			OnCollision2D,
			[Token(Token = "0x4000464")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x1700000D")]
		private Transform Trans
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x526008", Offset = "0x526008", VA = "0x526008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x525AD8", Offset = "0x525AD8", VA = "0x525AD8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x525E70", Offset = "0x525E70", VA = "0x525E70")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x525EC8", Offset = "0x525EC8", VA = "0x525EC8")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x525F20", Offset = "0x525F20", VA = "0x525F20")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x525F78", Offset = "0x525F78", VA = "0x525F78")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x525B30", Offset = "0x525B30", VA = "0x525B30")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x526098", Offset = "0x526098", VA = "0x526098")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F53FC", Offset = "0x3F53FC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3F53FC", Offset = "0x3F53FC")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F545C", Offset = "0x3F545C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3F545C", Offset = "0x3F545C")]
		public bool fireEnterEvent;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F54CC", Offset = "0x3F54CC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3F54CC", Offset = "0x3F54CC")]
		public bool fireExitEvent;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F553C", Offset = "0x3F553C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3F553C", Offset = "0x3F553C")]
		public bool fireAnimTimeEvent;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F559C", Offset = "0x3F559C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F559C", Offset = "0x3F559C")]
		public float whenToFireEvent;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[MasterCustomEvent]
		public string timedCustomEvent;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5600", Offset = "0x3F5600")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3F5600", Offset = "0x3F5600")]
		public bool fireMultiAnimTimeEvent;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F5660", Offset = "0x3F5660")]
		public int numOfMultiEventsToFire;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5678", Offset = "0x3F5678")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F5678", Offset = "0x3F5678")]
		public float whenToFireMultiEvent1;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F56CC", Offset = "0x3F56CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F56CC", Offset = "0x3F56CC")]
		public float whenToFireMultiEvent2;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5720", Offset = "0x3F5720")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F5720", Offset = "0x3F5720")]
		public float whenToFireMultiEvent3;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5774", Offset = "0x3F5774")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F5774", Offset = "0x3F5774")]
		public float whenToFireMultiEvent4;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[MasterCustomEvent]
		public string MultiTimedEvent;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _playMultiEvent1;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _playMultiEvent2;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _playMultiEvent3;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _playMultiEvent4;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fireTimedEvent;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _actorTrans;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _lastRepetition;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x7037D4", Offset = "0x7037D4", VA = "0x7037D4", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x703958", Offset = "0x703958", VA = "0x703958", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x703C6C", Offset = "0x703C6C", VA = "0x703C6C", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x7038B0", Offset = "0x7038B0", VA = "0x7038B0")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x703D44", Offset = "0x703D44", VA = "0x703D44")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3F57D8", Offset = "0x3F57D8")]
		public bool SoundFollowsObject;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5810", Offset = "0x3F5810")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3F5810", Offset = "0x3F5810")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5870", Offset = "0x3F5870")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3F5870", Offset = "0x3F5870")]
		public bool playEnterSound;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool stopEnterSoundOnExit;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F58E0", Offset = "0x3F58E0")]
		public string enterVariationName;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool wasEnterSoundPlayed;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5918", Offset = "0x3F5918")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3F5918", Offset = "0x3F5918")]
		public bool playExitSound;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5988", Offset = "0x3F5988")]
		public string exitVariationName;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F59C0", Offset = "0x3F59C0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3F59C0", Offset = "0x3F59C0")]
		public bool playAnimTimeSound;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool stopAnimTimeSoundOnExit;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5A20", Offset = "0x3F5A20")]
		public bool useStopTime;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5A58", Offset = "0x3F5A58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F5A58", Offset = "0x3F5A58")]
		public float whenToStartSound;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5AAC", Offset = "0x3F5AAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F5AAC", Offset = "0x3F5AAC")]
		public float whenToStopSound;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SoundGroup]
		public string TimedSoundGroup;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5B10", Offset = "0x3F5B10")]
		public string timedVariationName;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playSoundStart;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool playSoundStop;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5B48", Offset = "0x3F5B48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3F5B48", Offset = "0x3F5B48")]
		public bool playMultiAnimTimeSounds;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool StopMultiAnimTimeSoundsOnExit;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F5BA8", Offset = "0x3F5BA8")]
		public int numOfMultiSoundsToPlay;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5BC0", Offset = "0x3F5BC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F5BC0", Offset = "0x3F5BC0")]
		public float whenToStartMultiSound1;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5C14", Offset = "0x3F5C14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F5C14", Offset = "0x3F5C14")]
		public float whenToStartMultiSound2;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5C68", Offset = "0x3F5C68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F5C68", Offset = "0x3F5C68")]
		public float whenToStartMultiSound3;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5CBC", Offset = "0x3F5CBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F5CBC", Offset = "0x3F5CBC")]
		public float whenToStartMultiSound4;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SoundGroup]
		public string MultiSoundsTimedGroup;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x3F5D20", Offset = "0x3F5D20")]
		public string multiTimedVariationName;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool playMultiSound1;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool playMultiSound2;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool playMultiSound3;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		private bool playMultiSound4;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _actorTrans;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastRepetition;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x703DC0", Offset = "0x703DC0", VA = "0x703DC0", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x704044", Offset = "0x704044", VA = "0x704044", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x7047D0", Offset = "0x7047D0", VA = "0x7047D0", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x703F40", Offset = "0x703F40", VA = "0x703F40")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x703FE8", Offset = "0x703FE8", VA = "0x703FE8")]
		private static string GetVariationName(string varName)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x704A1C", Offset = "0x704A1C", VA = "0x704A1C")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5D58", Offset = "0x3F5D58")]
		private bool <SoundPlayed>k__BackingField;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5D68", Offset = "0x3F5D68")]
		private bool <SoundScheduled>k__BackingField;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5D78", Offset = "0x3F5D78")]
		private SoundGroupVariation <ActingVariation>k__BackingField;

		[Token(Token = "0x1700000E")]
		public bool SoundPlayed
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x705D50", Offset = "0x705D50", VA = "0x705D50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5EEC", Offset = "0x3F5EEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x705D30", Offset = "0x705D30", VA = "0x705D30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5EFC", Offset = "0x3F5EFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public bool SoundScheduled
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x705D58", Offset = "0x705D58", VA = "0x705D58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5F0C", Offset = "0x3F5F0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x705D3C", Offset = "0x705D3C", VA = "0x705D3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5F1C", Offset = "0x3F5F1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x701EF8", Offset = "0x701EF8", VA = "0x701EF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5F2C", Offset = "0x3F5F2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x705D48", Offset = "0x705D48", VA = "0x705D48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5F3C", Offset = "0x3F5F3C")]
			set
			{
			}
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x705D04", Offset = "0x705D04", VA = "0x705D04")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class AudioEvent
	{
		[Token(Token = "0x200005E")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x4000466")]
			UseSliderValue,
			[Token(Token = "0x4000467")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x200005F")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x505440", Offset = "0x505440", VA = "0x505440")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EventSounds.GlidePitchType glidePitchType;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float targetGlidePitch;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchGlideTime;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float delaySound;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float snapshotTransitionTime;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string playlistName;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string playlistControllerName;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool startPlaylist;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fadeVolume;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float fadeTime;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool stopAfterFade;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		public bool restoreVolumeAfterFade;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string clipName;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string variationName;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public string theCustomEventName;

		[Token(Token = "0x17000011")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x505270", Offset = "0x505270", VA = "0x505270")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x5052DC", Offset = "0x5052DC", VA = "0x5052DC")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class AudioEventGroup
	{
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool allPlayersShouldHear;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useLayerFilter;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool useTagFilter;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float triggerStayForTime;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool doesTriggerStayRepeat;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float sliderValue;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x50547C", Offset = "0x50547C", VA = "0x50547C")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x509A64", Offset = "0x509A64", VA = "0x509A64")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class BusFadeInfo
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x50CD1C", Offset = "0x50CD1C", VA = "0x50CD1C")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class BusPitchGlideInfo
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float CompletionTime;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IsActive;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action completionAction;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x50CD2C", Offset = "0x50CD2C", VA = "0x50CD2C")]
		public BusPitchGlideInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class CustomEvent
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsEditing;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool eventExpanded;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int filterModeQty;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isTemporary;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int frameLastFired;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string categoryName;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x50DD78", Offset = "0x50DD78", VA = "0x50DD78")]
		public CustomEvent(string eventName)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class CustomEventCategory
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string CatName;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsExpanded;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsEditing;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool IsTemporary;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x50DE00", Offset = "0x50DE00", VA = "0x50DE00")]
		public CustomEventCategory()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000032")]
	public class CustomEventToFireInfo
	{
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string eventName;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform eventOrigin;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x50DE64", Offset = "0x50DE64", VA = "0x50DE64")]
		public CustomEventToFireInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000033")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTemporary;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x50E384", Offset = "0x50E384", VA = "0x50E384")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F5D88", Offset = "0x3F5D88")]
		public int probabilityToPlay;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool useLocalization;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool useRandomPitch;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float randomPitchMin;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMax;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useRandomVolume;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float randomVolumeMin;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMax;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int weight;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string internetFileUrl;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isExpanded;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool isChecked;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool useFades;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeInTime;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fadeOutTime;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useCustomLooping;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int minCustomLoops;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int maxCustomLoops;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useIntroSilence;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float introSilenceMin;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float introSilenceMax;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool useRandomStartTime;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomStartMinPercent;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float randomStartMaxPercent;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float randomEndPercent;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Transform _trans;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioSource _aud;

		[Token(Token = "0x17000012")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x50E3EC", Offset = "0x50E3EC", VA = "0x50E3EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x50E484", Offset = "0x50E484", VA = "0x50E484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x50E51C", Offset = "0x50E51C", VA = "0x50E51C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x50E5B4", Offset = "0x50E5B4", VA = "0x50E5B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x50E64C", Offset = "0x50E64C", VA = "0x50E64C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x50E6E4", Offset = "0x50E6E4", VA = "0x50E6E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x50E77C", Offset = "0x50E77C", VA = "0x50E77C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public Transform Trans
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x50E8E4", Offset = "0x50E8E4", VA = "0x50E8E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x50E974", Offset = "0x50E974", VA = "0x50E974")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x50EC10", Offset = "0x50EC10", VA = "0x50EC10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x50ECA8", Offset = "0x50ECA8", VA = "0x50ECA8")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool logSound;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int busIndex;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float spatialBlend;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string busName;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool isExistingBus;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int limitPerXFrames;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float minimumTimeBetween;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool limitPolyphony;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int voiceLimitCount;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float despawnFadeTime;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool copySettingsExpanded;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int selectedVariationIndex;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool expandLinkedGroups;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<string> childSoundGroups;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x50ECDC", Offset = "0x50ECDC", VA = "0x50ECDC")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public class FootstepGroup
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x5259AC", Offset = "0x5259AC", VA = "0x5259AC")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class GroupBus
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool stopOldest;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExisting;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isTemporary;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool forceTo2D;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _originalVolume;

		[Token(Token = "0x1700001C")]
		public int ActiveVoices
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x52623C", Offset = "0x52623C", VA = "0x52623C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001D")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x52629C", Offset = "0x52629C", VA = "0x52629C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public float OriginalVolume
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x526320", Offset = "0x526320", VA = "0x526320")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x511460", Offset = "0x511460", VA = "0x511460")]
			set
			{
			}
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x526120", Offset = "0x526120", VA = "0x526120")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x5261CC", Offset = "0x5261CC", VA = "0x5261CC")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x526328", Offset = "0x526328", VA = "0x526328")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public class GroupFadeInfo
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x5263B8", Offset = "0x5263B8", VA = "0x5263B8")]
		public GroupFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class GroupPitchGlideInfo
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CompletionTime;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool IsActive;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x5263C8", Offset = "0x5263C8", VA = "0x5263C8")]
		public GroupPitchGlideInfo()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x60000FB")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x60000FC")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x60000FD")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x60000FE")]
		void RegisterReceiver();

		[Token(Token = "0x60000FF")]
		void UnregisterReceiver();

		[Token(Token = "0x6000100")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x200003B")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x2000060")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x400046B")]
			None,
			[Token(Token = "0x400046C")]
			Stop,
			[Token(Token = "0x400046D")]
			FadeOut
		}

		[Token(Token = "0x2000061")]
		public enum VariationSequence
		{
			[Token(Token = "0x400046F")]
			Randomized,
			[Token(Token = "0x4000470")]
			TopToBottom
		}

		[Token(Token = "0x2000062")]
		public enum VariationMode
		{
			[Token(Token = "0x4000472")]
			Normal,
			[Token(Token = "0x4000473")]
			LoopedChain,
			[Token(Token = "0x4000474")]
			Dialog
		}

		[Token(Token = "0x2000063")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x4000476")]
			Endless,
			[Token(Token = "0x4000477")]
			NumberOfLoops
		}

		[Token(Token = "0x2000064")]
		public enum LimitMode
		{
			[Token(Token = "0x4000479")]
			None,
			[Token(Token = "0x400047A")]
			FrameBased,
			[Token(Token = "0x400047B")]
			TimeBased
		}

		[Token(Token = "0x40001F3")]
		public const float UseCurveSpatialBlend = -99f;

		[Token(Token = "0x40001F4")]
		public const string NoBus = "[NO BUS]";

		[Token(Token = "0x40001F5")]
		public const int MinNoRepeatVariations = 3;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int busIndex;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spatialBlend;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isSelected;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExpanded;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float groupMasterVolume;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int retriggerPercentage;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VariationMode curVariationMode;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float chainLoopDelayMin;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float chainLoopDelayMax;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int chainLoopNumLoops;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool useDialogFadeOut;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float dialogFadeOutTime;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool logSound;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		public bool copySettingsExpanded;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int selectedVariationIndex;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool expandLinkedGroups;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<string> childSoundGroups;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LimitMode limitMode;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int limitPerXFrames;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float minimumTimeBetween;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		public bool limitPolyphony;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public int voiceLimitCount;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float despawnFadeTime;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool isUsingOcclusion;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool isSoloed;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public bool isMuted;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool willCleanUpDelegatesAfterStop;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public int frames;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string _objectName;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Transform _trans;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float _originalVolume;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5DB0", Offset = "0x3F5DB0")]
		private int <ChainLoopCount>k__BackingField;

		[Token(Token = "0x1700001F")]
		public MasterAudio.InternetFileLoadStatus GroupLoadStatus
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x702A88", Offset = "0x702A88", VA = "0x702A88")]
			get
			{
				return default(MasterAudio.InternetFileLoadStatus);
			}
		}

		[Token(Token = "0x17000020")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x703384", Offset = "0x703384", VA = "0x703384")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public int ActiveVoices
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x703488", Offset = "0x703488", VA = "0x703488")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000022")]
		public int TotalVoices
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x7034EC", Offset = "0x7034EC", VA = "0x7034EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000023")]
		public bool WillCleanUpDelegatesAfterStop
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x703520", Offset = "0x703520", VA = "0x703520")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x7031F8", Offset = "0x7031F8", VA = "0x7031F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public float OriginalVolume
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x70352C", Offset = "0x70352C", VA = "0x70352C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x703534", Offset = "0x703534", VA = "0x703534")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public bool LoggingEnabledForGroup
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x70353C", Offset = "0x70353C", VA = "0x70353C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public int ChainLoopCount
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x7035DC", Offset = "0x7035DC", VA = "0x7035DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5F6C", Offset = "0x3F5F6C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x7035E4", Offset = "0x7035E4", VA = "0x7035E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5F7C", Offset = "0x3F5F7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public string GameObjectName
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x702F9C", Offset = "0x702F9C", VA = "0x702F9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x7035EC", Offset = "0x7035EC", VA = "0x7035EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		private Transform Trans
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x702B8C", Offset = "0x702B8C", VA = "0x702B8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x702EF4", Offset = "0x702EF4", VA = "0x702EF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action LastVariationFinishedPlay
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x7028B0", Offset = "0x7028B0", VA = "0x7028B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5F4C", Offset = "0x3F5F4C")]
			add
			{
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x70299C", Offset = "0x70299C", VA = "0x70299C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5F5C", Offset = "0x3F5F5C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x702C1C", Offset = "0x702C1C", VA = "0x702C1C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x702FE0", Offset = "0x702FE0", VA = "0x702FE0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x70312C", Offset = "0x70312C", VA = "0x70312C")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x7032E8", Offset = "0x7032E8", VA = "0x7032E8")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x7035B8", Offset = "0x7035B8", VA = "0x7035B8")]
		public void FireLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x7035CC", Offset = "0x7035CC", VA = "0x7035CC")]
		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x7035D4", Offset = "0x7035D4", VA = "0x7035D4")]
		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x703674", Offset = "0x703674", VA = "0x703674")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x7037CC", Offset = "0x7037CC", VA = "0x7037CC")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003D")]
	public class MusicSetting
	{
		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float customStartTime;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float customStartTimeMax;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int lastKnownTimePoint;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool wasLastKnownTimePointSet;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int songIndex;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string songStartedCustomEvent;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string songChangedCustomEvent;

		[Token(Token = "0x1700002C")]
		public float SongStartTime
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x704B3C", Offset = "0x704B3C", VA = "0x704B3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x704A98", Offset = "0x704A98", VA = "0x704A98")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x704B68", Offset = "0x704B68", VA = "0x704B68")]
		public static MusicSetting Clone(MusicSetting mus)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public class OcclusionFreqChangeInfo
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundGroupVariation ActingVariation;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StartFrequency;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TargetFrequency;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartTime;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float CompletionTime;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x704D50", Offset = "0x704D50", VA = "0x704D50")]
		public OcclusionFreqChangeInfo()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x70F02C", Offset = "0x70F02C", VA = "0x70F02C")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x3F4FA0", Offset = "0x3F4FA0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3F4FA0", Offset = "0x3F4FA0")]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x2000065")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x2000066")]
		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		[Token(Token = "0x2000067")]
		public class PlaySoundParams
		{
			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double? TimeToSchedulePlay;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform SourceTrans;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool AttachToSource;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float DelaySoundTime;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool IsChainLoop;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float GroupCalcVolume;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool IsPlaying;

			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x714E28", Offset = "0x714E28", VA = "0x714E28")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x2000068")]
		public enum PitchMode
		{
			[Token(Token = "0x4000488")]
			None,
			[Token(Token = "0x4000489")]
			Gliding
		}

		[Token(Token = "0x2000069")]
		public enum FadeMode
		{
			[Token(Token = "0x400048B")]
			None,
			[Token(Token = "0x400048C")]
			FadeInOut,
			[Token(Token = "0x400048D")]
			FadeOutEarly,
			[Token(Token = "0x400048E")]
			GradualFade
		}

		[Token(Token = "0x200006A")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x4000490")]
			AddToClipPitch,
			[Token(Token = "0x4000491")]
			IgnoreClipPitch
		}

		[Token(Token = "0x200006B")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x4000493")]
			AddToClipVolume,
			[Token(Token = "0x4000494")]
			IgnoreClipVolume
		}

		[Token(Token = "0x200006C")]
		public enum DetectEndMode
		{
			[Token(Token = "0x4000496")]
			None,
			[Token(Token = "0x4000497")]
			DetectEnd
		}

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3F5DC0", Offset = "0x3F5DC0")]
		public int probabilityToPlay;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useLocalization;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useRandomPitch;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMin;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMax;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useRandomVolume;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMin;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMax;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string internetFileUrl;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.InternetFileLoadStatus internetFileLoadStatus;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float original_pitch;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float original_volume;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool isExpanded;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool isChecked;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		public bool useFades;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float fadeInTime;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float fadeOutTime;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useCustomLooping;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int minCustomLoops;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int maxCustomLoops;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool useRandomStartTime;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomStartMinPercent;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float randomStartMaxPercent;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float randomEndPercent;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool useIntroSilence;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float introSilenceMin;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float introSilenceMax;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float fadeMaxVolume;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public FadeMode curFadeMode;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public PitchMode curPitchMode;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int frames;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioSource _audioSource;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _maxVol;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _instanceId;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool? _audioLoops;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private int _maxLoops;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _soundGroupName;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Transform _trans;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private GameObject _go;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool _attachToSource;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private string _resFileName;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool _hasStartedEndLinkedGroups;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5DF8", Offset = "0x3F5DF8")]
		private float <LastTimePlayed>k__BackingField;

		[Token(Token = "0x1700002D")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x713F64", Offset = "0x713F64", VA = "0x713F64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x713FFC", Offset = "0x713FFC", VA = "0x713FFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x714094", Offset = "0x714094", VA = "0x714094")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x71412C", Offset = "0x71412C", VA = "0x71412C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x710684", Offset = "0x710684", VA = "0x710684")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x7141C4", Offset = "0x7141C4", VA = "0x7141C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x7141CC", Offset = "0x7141CC", VA = "0x7141CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x711CAC", Offset = "0x711CAC", VA = "0x711CAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x714264", Offset = "0x714264", VA = "0x714264")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x713E44", Offset = "0x713E44", VA = "0x713E44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x7143AC", Offset = "0x7143AC", VA = "0x7143AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x7143B4", Offset = "0x7143B4", VA = "0x7143B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x70FA64", Offset = "0x70FA64", VA = "0x70FA64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public float OriginalPitch
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x711378", Offset = "0x711378", VA = "0x711378")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000038")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x714640", Offset = "0x714640", VA = "0x714640")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000039")]
		public string SoundGroupName
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x71468C", Offset = "0x71468C", VA = "0x71468C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x7146D0", Offset = "0x7146D0", VA = "0x7146D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public float LastTimePlayed
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x714784", Offset = "0x714784", VA = "0x714784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5FCC", Offset = "0x3F5FCC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x71478C", Offset = "0x71478C", VA = "0x71478C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5FDC", Offset = "0x3F5FDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public bool IsPlaying
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x710C54", Offset = "0x710C54", VA = "0x710C54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		public int InstanceId
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x711C78", Offset = "0x711C78", VA = "0x711C78")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003E")]
		public Transform Trans
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x713048", Offset = "0x713048", VA = "0x713048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public GameObject GameObj
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x70F9D4", Offset = "0x70F9D4", VA = "0x70F9D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x70F93C", Offset = "0x70F93C", VA = "0x70F93C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public bool AudioLoops
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x711BB8", Offset = "0x711BB8", VA = "0x711BB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		public string ResFileName
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x711798", Offset = "0x711798", VA = "0x711798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x71041C", Offset = "0x71041C", VA = "0x71041C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x714794", Offset = "0x714794", VA = "0x714794")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public float SetGroupVolume
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x71479C", Offset = "0x71479C", VA = "0x71479C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x7147C8", Offset = "0x7147C8", VA = "0x7147C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public int MaxLoops
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x714800", Offset = "0x714800", VA = "0x714800")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000047")]
		private bool Is2D
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x714808", Offset = "0x714808", VA = "0x714808")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		private bool ShouldLoadAsync
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x7112D4", Offset = "0x7112D4", VA = "0x7112D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x7105AC", Offset = "0x7105AC", VA = "0x7105AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000002")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x701F10", Offset = "0x701F10", VA = "0x701F10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5F8C", Offset = "0x3F5F8C")]
			add
			{
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x70F2C0", Offset = "0x70F2C0", VA = "0x70F2C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5F9C", Offset = "0x3F5F9C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event SoundLoopedEventHandler SoundLooped
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x70F3B0", Offset = "0x70F3B0", VA = "0x70F3B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5FAC", Offset = "0x3F5FAC")]
			add
			{
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x70F4A0", Offset = "0x70F4A0", VA = "0x70F4A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5FBC", Offset = "0x3F5FBC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x70F590", Offset = "0x70F590", VA = "0x70F590")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x70FC28", Offset = "0x70FC28", VA = "0x70FC28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x70FED4", Offset = "0x70FED4", VA = "0x70FED4")]
		public void SetMixerGroup()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x70FF50", Offset = "0x70FF50", VA = "0x70FF50")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x70FDF4", Offset = "0x70FDF4", VA = "0x70FDF4")]
		public void LoadInternetFile()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x71014C", Offset = "0x71014C", VA = "0x71014C")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x710090", Offset = "0x710090", VA = "0x710090")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x71068C", Offset = "0x71068C", VA = "0x71068C")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x71073C", Offset = "0x71073C", VA = "0x71073C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x7107C4", Offset = "0x7107C4", VA = "0x7107C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x710740", Offset = "0x710740", VA = "0x710740")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x710B7C", Offset = "0x710B7C", VA = "0x710B7C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x710C80", Offset = "0x710C80", VA = "0x710C80")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x711144", Offset = "0x711144", VA = "0x711144")]
		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x711838", Offset = "0x711838", VA = "0x711838")]
		private void InternetFileFailedToLoad()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x71110C", Offset = "0x71110C", VA = "0x71110C")]
		private void MaybeCleanupFinishedDelegate()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x71184C", Offset = "0x71184C", VA = "0x71184C")]
		private void InternetFileLoaded()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x71190C", Offset = "0x71190C", VA = "0x71190C")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x7113C4", Offset = "0x7113C4", VA = "0x7113C4")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x711D84", Offset = "0x711D84", VA = "0x711D84")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x711DF4", Offset = "0x711DF4", VA = "0x711DF4")]
		public void GlideByPitch(float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x71212C", Offset = "0x71212C", VA = "0x71212C")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x7122F0", Offset = "0x7122F0", VA = "0x7122F0")]
		public void Pause()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x712464", Offset = "0x712464", VA = "0x712464")]
		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x7128F0", Offset = "0x7128F0", VA = "0x7128F0")]
		public void PlayEndLinkedGroups([Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x711918", Offset = "0x711918", VA = "0x711918")]
		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x712F94", Offset = "0x712F94", VA = "0x712F94")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x712BC0", Offset = "0x712BC0", VA = "0x712BC0")]
		private void PlayEndLinkedGroup(string sType, [Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x7107C8", Offset = "0x7107C8", VA = "0x7107C8")]
		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x713564", Offset = "0x713564", VA = "0x713564")]
		public void FadeToVolume(float newVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x7139AC", Offset = "0x7139AC", VA = "0x7139AC")]
		public void FadeOutNow()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x713C84", Offset = "0x713C84", VA = "0x713C84")]
		public void FadeOutNow(float fadeTime)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x713D84", Offset = "0x713D84", VA = "0x713D84")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x713E4C", Offset = "0x713E4C", VA = "0x713E4C")]
		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x71426C", Offset = "0x71426C", VA = "0x71426C")]
		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x7148AC", Offset = "0x7148AC", VA = "0x7148AC")]
		public void SoundLoopStarted(int numberOfLoops)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x711844", Offset = "0x711844", VA = "0x711844")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x714CFC", Offset = "0x714CFC", VA = "0x714CFC")]
		public SoundGroupVariation()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x3F5018", Offset = "0x3F5018")]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x200006D")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x4000499")]
			None,
			[Token(Token = "0x400049A")]
			Play,
			[Token(Token = "0x400049B")]
			WaitForEnd,
			[Token(Token = "0x400049C")]
			StopOrRepeat
		}

		[Token(Token = "0x4000286")]
		private const float TimeEarlyToScheduleNextClip = 0.1f;

		[Token(Token = "0x4000287")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _useClipAgePriority;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource _varAudio;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _trans;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _frameNum;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _inited;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _fadeOutStartTime;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool _fadeOutStarted;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastFrameClipTime;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isPlayingBackward;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _pitchGlideToTargetTotalFrames;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _pitchGlideToTargetFramePitchChange;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int _pitchGlideToTargetFrameNumber;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _glideToTargetPitch;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _glideToTargetOrigPitch;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action _glideToPitchCompletionCallback;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		private bool _isWaitingForQueuedOcclusionRay;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _framesPlayed;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float? _clipStartPosition;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float? _clipEndPosition;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private double? _clipSchedEndTime;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool _hasScheduledNextClip;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool _hasScheduledEndLinkedGroups;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _lastFrameClipPosition;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _timesLooped;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool _isPaused;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private double _pauseTime;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x1700004A")]
		public float ClipStartPosition
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x716AC8", Offset = "0x716AC8", VA = "0x716AC8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004B")]
		public float ClipEndPosition
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x715100", Offset = "0x715100", VA = "0x715100")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004C")]
		public int FramesPlayed
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x712BB8", Offset = "0x712BB8", VA = "0x712BB8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004D")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x714844", Offset = "0x714844", VA = "0x714844")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public float MaxOcclusionFreq
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x717928", Offset = "0x717928", VA = "0x717928")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004F")]
		public float MinOcclusionFreq
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x717A00", Offset = "0x717A00", VA = "0x717A00")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000050")]
		private Transform Trans
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x7158F0", Offset = "0x7158F0", VA = "0x7158F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x715060", Offset = "0x715060", VA = "0x715060")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x715990", Offset = "0x715990", VA = "0x715990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x714FC8", Offset = "0x714FC8", VA = "0x714FC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private float RayCastOriginOffset
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x7169F0", Offset = "0x7169F0", VA = "0x7169F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000055")]
		private bool IsOcclusionMeasuringPaused
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x715C48", Offset = "0x715C48", VA = "0x715C48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		private bool HasEndLinkedGroups
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x717894", Offset = "0x717894", VA = "0x717894")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x712060", Offset = "0x712060", VA = "0x712060")]
		public void GlidePitch(float targetPitch, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x7137F8", Offset = "0x7137F8", VA = "0x7137F8")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x713AB4", Offset = "0x713AB4", VA = "0x713AB4")]
		public void FadeOutEarly(float fadeTime)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x712ED8", Offset = "0x712ED8", VA = "0x712ED8")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x711A40", Offset = "0x711A40", VA = "0x711A40")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x711CB4", Offset = "0x711CB4", VA = "0x711CB4")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x712F10", Offset = "0x712F10", VA = "0x712F10")]
		public void WaitForSoundFinish()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x71311C", Offset = "0x71311C", VA = "0x71311C")]
		public void StopPitchGliding()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x7130E8", Offset = "0x7130E8", VA = "0x7130E8")]
		public void StopFading()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x7128B8", Offset = "0x7128B8", VA = "0x7128B8")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x7130D8", Offset = "0x7130D8", VA = "0x7130D8")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x71585C", Offset = "0x71585C", VA = "0x71585C")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x71526C", Offset = "0x71526C", VA = "0x71526C")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x715A30", Offset = "0x715A30", VA = "0x715A30")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x715AE4", Offset = "0x715AE4", VA = "0x715AE4")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x715CD8", Offset = "0x715CD8", VA = "0x715CD8")]
		private void DoneWithOcclusion()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x715D54", Offset = "0x715D54", VA = "0x715D54")]
		public bool RayCastForOcclusion()
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x715424", Offset = "0x715424", VA = "0x715424")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x716C30", Offset = "0x716C30", VA = "0x716C30")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x712434", Offset = "0x712434", VA = "0x712434")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x716CFC", Offset = "0x716CFC", VA = "0x716CFC")]
		public void Unpause()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x71253C", Offset = "0x71253C", VA = "0x71253C")]
		public void MaybeChain()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x716E24", Offset = "0x716E24", VA = "0x716E24")]
		private void UpdatePitch()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x716F2C", Offset = "0x716F2C", VA = "0x716F2C")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x7172CC", Offset = "0x7172CC", VA = "0x7172CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x717358", Offset = "0x717358", VA = "0x717358")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x7104B4", Offset = "0x7104B4", VA = "0x7104B4")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x7173FC", Offset = "0x7173FC", VA = "0x7173FC")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x717AD8", Offset = "0x717AD8", VA = "0x717AD8")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x40002BA")]
		private const int MaxPriority = 0;

		[Token(Token = "0x40002BB")]
		private const int HighestPriority = 16;

		[Token(Token = "0x40002BC")]
		private const int LowestPriority = 128;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x5055D4", Offset = "0x5055D4", VA = "0x5055D4")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x505604", Offset = "0x505604", VA = "0x505604")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x505634", Offset = "0x505634", VA = "0x505634")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x505664", Offset = "0x505664", VA = "0x505664")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x2000043")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x200006E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F511C", Offset = "0x3F511C")]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string songResourceName;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string playlistName;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlaylistController controller;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x170000AF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003C5")]
				[Address(RVA = "0x508828", Offset = "0x508828", VA = "0x508828", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003C7")]
				[Address(RVA = "0x508898", Offset = "0x508898", VA = "0x508898", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x506EB0", Offset = "0x506EB0", VA = "0x506EB0")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x508224", Offset = "0x508224", VA = "0x508224", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x508228", Offset = "0x508228", VA = "0x508228", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x508830", Offset = "0x508830", VA = "0x508830", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F512C", Offset = "0x3F512C")]
		private sealed class <PopulateSourceWithInternetFile>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string fileUrl;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SoundGroupVariation variation;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action failureAction;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private WWW <fileRequest>5__2;

			[Token(Token = "0x170000B1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003CC")]
				[Address(RVA = "0x5092F4", Offset = "0x5092F4", VA = "0x5092F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003CE")]
				[Address(RVA = "0x509364", Offset = "0x509364", VA = "0x509364", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x506FA8", Offset = "0x506FA8", VA = "0x506FA8")]
			[DebuggerHidden]
			public <PopulateSourceWithInternetFile>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x5088A0", Offset = "0x5088A0", VA = "0x5088A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x50897C", Offset = "0x50897C", VA = "0x50897C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x5088BC", Offset = "0x5088BC", VA = "0x5088BC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x5092FC", Offset = "0x5092FC", VA = "0x5092FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000070")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F513C", Offset = "0x3F513C")]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action failureAction;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public SoundGroupVariation variation;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x170000B3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003D2")]
				[Address(RVA = "0x5099EC", Offset = "0x5099EC", VA = "0x5099EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003D4")]
				[Address(RVA = "0x509A5C", Offset = "0x509A5C", VA = "0x509A5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x5073E0", Offset = "0x5073E0", VA = "0x5073E0")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x50936C", Offset = "0x50936C", VA = "0x50936C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x509370", Offset = "0x509370", VA = "0x509370", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x5099F4", Offset = "0x5099F4", VA = "0x5099F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly List<string> InternetFilesStartedLoading;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x505C28", Offset = "0x505C28", VA = "0x505C28")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x505CD8", Offset = "0x505CD8", VA = "0x505CD8")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x505E38", Offset = "0x505E38", VA = "0x505E38")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x5061D4", Offset = "0x5061D4", VA = "0x5061D4")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x505ED4", Offset = "0x505ED4", VA = "0x505ED4")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x506680", Offset = "0x506680", VA = "0x506680")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x5066FC", Offset = "0x5066FC", VA = "0x5066FC")]
		public static AudioClip PopulateResourceSongToPlaylistController(string controllerName, string songResourceName, string playlistName)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x506C5C", Offset = "0x506C5C", VA = "0x506C5C")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x506DE4", Offset = "0x506DE4", VA = "0x506DE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3F5FEC", Offset = "0x3F5FEC")]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x506EDC", Offset = "0x506EDC", VA = "0x506EDC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3F6050", Offset = "0x3F6050")]
		public static IEnumerator PopulateSourceWithInternetFile(string fileUrl, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x506FD4", Offset = "0x506FD4", VA = "0x506FD4")]
		public static void RemoveLoadedInternetClip(string fileUrl)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x507314", Offset = "0x507314", VA = "0x507314")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3F60B4", Offset = "0x3F60B4")]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x50740C", Offset = "0x50740C", VA = "0x50740C")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x5075C4", Offset = "0x5075C4", VA = "0x5075C4")]
		public static bool PopulateSourcesWithResourceClip(string clipName, SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x507B80", Offset = "0x507B80", VA = "0x507B80")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x507D7C", Offset = "0x507D7C", VA = "0x507D7C")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x3F502C", Offset = "0x3F502C")]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x2000071")]
		public enum VariationFollowerType
		{
			[Token(Token = "0x40004B3")]
			LateUpdate,
			[Token(Token = "0x40004B4")]
			FixedUpdate
		}

		[Token(Token = "0x2000072")]
		public enum LinkedGroupSelectionType
		{
			[Token(Token = "0x40004B6")]
			All,
			[Token(Token = "0x40004B7")]
			OneAtRandom
		}

		[Token(Token = "0x2000073")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x40004B9")]
			AllGroups,
			[Token(Token = "0x40004BA")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x2000074")]
		public enum RaycastMode
		{
			[Token(Token = "0x40004BC")]
			Physics3D,
			[Token(Token = "0x40004BD")]
			Physics2D
		}

		[Token(Token = "0x2000075")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x40004BF")]
			ForceAllTo2D,
			[Token(Token = "0x40004C0")]
			ForceAllTo3D,
			[Token(Token = "0x40004C1")]
			ForceAllToCustom,
			[Token(Token = "0x40004C2")]
			AllowDifferentPerController
		}

		[Token(Token = "0x2000076")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x40004C4")]
			ForceAllTo2D,
			[Token(Token = "0x40004C5")]
			ForceAllTo3D,
			[Token(Token = "0x40004C6")]
			ForceAllToCustom,
			[Token(Token = "0x40004C7")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x2000077")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x40004C9")]
			ForceTo2D,
			[Token(Token = "0x40004CA")]
			ForceTo3D,
			[Token(Token = "0x40004CB")]
			ForceToCustom,
			[Token(Token = "0x40004CC")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x2000078")]
		public enum InternetFileLoadStatus
		{
			[Token(Token = "0x40004CE")]
			Loading,
			[Token(Token = "0x40004CF")]
			Loaded,
			[Token(Token = "0x40004D0")]
			Failed
		}

		[Token(Token = "0x2000079")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x40004D2")]
			Narrow,
			[Token(Token = "0x40004D3")]
			Normal,
			[Token(Token = "0x40004D4")]
			Wide
		}

		[Token(Token = "0x200007A")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x40004D6")]
			Always,
			[Token(Token = "0x40004D7")]
			WhenDistanceLessThan,
			[Token(Token = "0x40004D8")]
			WhenDistanceMoreThan,
			[Token(Token = "0x40004D9")]
			Never,
			[Token(Token = "0x40004DA")]
			OnSameGameObject,
			[Token(Token = "0x40004DB")]
			OnChildGameObject,
			[Token(Token = "0x40004DC")]
			OnParentGameObject,
			[Token(Token = "0x40004DD")]
			OnSameOrChildGameObject,
			[Token(Token = "0x40004DE")]
			OnSameOrParentGameObject
		}

		[Token(Token = "0x200007B")]
		public enum EventReceiveFilter
		{
			[Token(Token = "0x40004E0")]
			All,
			[Token(Token = "0x40004E1")]
			Closest,
			[Token(Token = "0x40004E2")]
			Random
		}

		[Token(Token = "0x200007C")]
		public enum AudioLocation
		{
			[Token(Token = "0x40004E4")]
			Clip,
			[Token(Token = "0x40004E5")]
			ResourceFile,
			[Token(Token = "0x40004E6")]
			FileOnInternet
		}

		[Token(Token = "0x200007D")]
		public enum CustomSongStartTimeMode
		{
			[Token(Token = "0x40004E8")]
			Beginning,
			[Token(Token = "0x40004E9")]
			SpecificTime,
			[Token(Token = "0x40004EA")]
			RandomTime
		}

		[Token(Token = "0x200007E")]
		public enum BusCommand
		{
			[Token(Token = "0x40004EC")]
			None,
			[Token(Token = "0x40004ED")]
			FadeToVolume,
			[Token(Token = "0x40004EE")]
			Mute,
			[Token(Token = "0x40004EF")]
			Pause,
			[Token(Token = "0x40004F0")]
			Solo,
			[Token(Token = "0x40004F1")]
			Unmute,
			[Token(Token = "0x40004F2")]
			Unpause,
			[Token(Token = "0x40004F3")]
			Unsolo,
			[Token(Token = "0x40004F4")]
			Stop,
			[Token(Token = "0x40004F5")]
			ChangePitch,
			[Token(Token = "0x40004F6")]
			ToggleMute,
			[Token(Token = "0x40004F7")]
			StopBusOfTransform,
			[Token(Token = "0x40004F8")]
			PauseBusOfTransform,
			[Token(Token = "0x40004F9")]
			UnpauseBusOfTransform,
			[Token(Token = "0x40004FA")]
			GlideByPitch
		}

		[Token(Token = "0x200007F")]
		public enum DragGroupMode
		{
			[Token(Token = "0x40004FC")]
			OneGroupPerClip,
			[Token(Token = "0x40004FD")]
			OneGroupWithVariations
		}

		[Token(Token = "0x2000080")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x40004FF")]
			PlaySound,
			[Token(Token = "0x4000500")]
			GroupControl,
			[Token(Token = "0x4000501")]
			BusControl,
			[Token(Token = "0x4000502")]
			PlaylistControl,
			[Token(Token = "0x4000503")]
			CustomEventControl,
			[Token(Token = "0x4000504")]
			GlobalControl,
			[Token(Token = "0x4000505")]
			UnityMixerControl,
			[Token(Token = "0x4000506")]
			PersistentSettingsControl
		}

		[Token(Token = "0x2000081")]
		public enum LanguageMode
		{
			[Token(Token = "0x4000508")]
			UseDeviceSetting,
			[Token(Token = "0x4000509")]
			SpecificLanguage,
			[Token(Token = "0x400050A")]
			DynamicallySet
		}

		[Token(Token = "0x2000082")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x400050C")]
			None,
			[Token(Token = "0x400050D")]
			TransitionToSnapshot,
			[Token(Token = "0x400050E")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x2000083")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x4000510")]
			None,
			[Token(Token = "0x4000511")]
			ChangePlaylist,
			[Token(Token = "0x4000512")]
			FadeToVolume,
			[Token(Token = "0x4000513")]
			PlaySong,
			[Token(Token = "0x4000514")]
			PlayRandomSong,
			[Token(Token = "0x4000515")]
			PlayNextSong,
			[Token(Token = "0x4000516")]
			Pause,
			[Token(Token = "0x4000517")]
			Resume,
			[Token(Token = "0x4000518")]
			Stop,
			[Token(Token = "0x4000519")]
			Mute,
			[Token(Token = "0x400051A")]
			Unmute,
			[Token(Token = "0x400051B")]
			ToggleMute,
			[Token(Token = "0x400051C")]
			Restart,
			[Token(Token = "0x400051D")]
			Start,
			[Token(Token = "0x400051E")]
			StopLoopingCurrentSong,
			[Token(Token = "0x400051F")]
			StopPlaylistAfterCurrentSong,
			[Token(Token = "0x4000520")]
			AddSongToQueue
		}

		[Token(Token = "0x2000084")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x4000522")]
			None,
			[Token(Token = "0x4000523")]
			FireEvent
		}

		[Token(Token = "0x2000085")]
		public enum GlobalCommand
		{
			[Token(Token = "0x4000525")]
			None,
			[Token(Token = "0x4000526")]
			PauseMixer,
			[Token(Token = "0x4000527")]
			UnpauseMixer,
			[Token(Token = "0x4000528")]
			StopMixer,
			[Token(Token = "0x4000529")]
			StopEverything,
			[Token(Token = "0x400052A")]
			PauseEverything,
			[Token(Token = "0x400052B")]
			UnpauseEverything,
			[Token(Token = "0x400052C")]
			MuteEverything,
			[Token(Token = "0x400052D")]
			UnmuteEverything,
			[Token(Token = "0x400052E")]
			SetMasterMixerVolume,
			[Token(Token = "0x400052F")]
			SetMasterPlaylistVolume
		}

		[Token(Token = "0x2000086")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x4000531")]
			None,
			[Token(Token = "0x4000532")]
			FadeToVolume,
			[Token(Token = "0x4000533")]
			FadeOutAllOfSound,
			[Token(Token = "0x4000534")]
			Mute,
			[Token(Token = "0x4000535")]
			Pause,
			[Token(Token = "0x4000536")]
			Solo,
			[Token(Token = "0x4000537")]
			StopAllOfSound,
			[Token(Token = "0x4000538")]
			Unmute,
			[Token(Token = "0x4000539")]
			Unpause,
			[Token(Token = "0x400053A")]
			Unsolo,
			[Token(Token = "0x400053B")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x400053C")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x400053D")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x400053E")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x400053F")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x4000540")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x4000541")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x4000542")]
			RefillSoundGroupPool,
			[Token(Token = "0x4000543")]
			RouteToBus,
			[Token(Token = "0x4000544")]
			GlideByPitch,
			[Token(Token = "0x4000545")]
			ToggleSoundGroup,
			[Token(Token = "0x4000546")]
			ToggleSoundGroupOfTransform,
			[Token(Token = "0x4000547")]
			FadeOutAllSoundsOfTransform
		}

		[Token(Token = "0x2000087")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x4000549")]
			None,
			[Token(Token = "0x400054A")]
			SetBusVolume,
			[Token(Token = "0x400054B")]
			SetGroupVolume,
			[Token(Token = "0x400054C")]
			SetMixerVolume,
			[Token(Token = "0x400054D")]
			SetMusicVolume,
			[Token(Token = "0x400054E")]
			MixerMuteToggle,
			[Token(Token = "0x400054F")]
			MusicMuteToggle
		}

		[Token(Token = "0x2000088")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x4000551")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x4000552")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x4000553")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x2000089")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x4000555")]
			MasterAudioLocation,
			[Token(Token = "0x4000556")]
			CallerLocation,
			[Token(Token = "0x4000557")]
			AttachToCaller
		}

		[Token(Token = "0x200008A")]
		public enum VariationCommand
		{
			[Token(Token = "0x4000559")]
			None,
			[Token(Token = "0x400055A")]
			Stop,
			[Token(Token = "0x400055B")]
			Pause,
			[Token(Token = "0x400055C")]
			Unpause
		}

		[Token(Token = "0x200008B")]
		public struct CustomEventCandidate
		{
			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float DistanceAway;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ICustomEventReceiver Receiver;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Trans;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RandomId;

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x44A520", Offset = "0x44A520", VA = "0x44A520")]
			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x70272C", Offset = "0x70272C", VA = "0x70272C")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008D")]
		public class AudioInfo
		{
			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x702778", Offset = "0x702778", VA = "0x702778")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008E")]
		public class Playlist
		{
			[Token(Token = "0x20000B7")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x40005DC")]
				UseMasterSetting,
				[Token(Token = "0x40005DD")]
				Override
			}

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool resourceClipsAllLoadAsync;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
			public bool isTemporary;

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x7027DC", Offset = "0x7027DC", VA = "0x7027DC")]
			public Playlist()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008F")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x702878", Offset = "0x702878", VA = "0x702878")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F514C", Offset = "0x3F514C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<OcclusionFreqChangeInfo> <>9__207_0;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<BusFadeInfo> <>9__208_0;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<GroupFadeInfo> <>9__209_0;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Predicate<GroupPitchGlideInfo> <>9__210_0;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Predicate<BusPitchGlideInfo> <>9__211_0;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Comparison<CustomEventCandidate> <>9__405_0;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Comparison<CustomEventCandidate> <>9__405_1;

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x7015EC", Offset = "0x7015EC", VA = "0x7015EC")]
			public <>c()
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x7015F4", Offset = "0x7015F4", VA = "0x7015F4")]
			internal bool <PerformOcclusionFrequencyChanges>b__207_0(OcclusionFreqChangeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x701628", Offset = "0x701628", VA = "0x701628")]
			internal bool <PerformBusFades>b__208_0(BusFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x70165C", Offset = "0x70165C", VA = "0x70165C")]
			internal bool <PerformGroupFades>b__209_0(GroupFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x701690", Offset = "0x701690", VA = "0x701690")]
			internal bool <PerformGroupPitchGlides>b__210_0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x7016C4", Offset = "0x7016C4", VA = "0x7016C4")]
			internal bool <PerformBusPitchGlides>b__211_0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x7016F8", Offset = "0x7016F8", VA = "0x7016F8")]
			internal int <FireCustomEvent>b__405_0(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x701708", Offset = "0x701708", VA = "0x701708")]
			internal int <FireCustomEvent>b__405_1(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F515C", Offset = "0x3F515C")]
		private sealed class <>c__DisplayClass221_0
		{
			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x70171C", Offset = "0x70171C", VA = "0x70171C")]
			public <>c__DisplayClass221_0()
			{
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x701724", Offset = "0x701724", VA = "0x701724")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F516C", Offset = "0x3F516C")]
		private sealed class <PlaySoundAndWaitUntilFinished>d__221 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass221_0 <>8__1;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action completedAction;

			[Token(Token = "0x170000B5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003E8")]
				[Address(RVA = "0x7026B4", Offset = "0x7026B4", VA = "0x7026B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003EA")]
				[Address(RVA = "0x702724", Offset = "0x702724", VA = "0x702724", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x7023E0", Offset = "0x7023E0", VA = "0x7023E0")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__221(int <>1__state)
			{
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x70240C", Offset = "0x70240C", VA = "0x70240C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x702410", Offset = "0x702410", VA = "0x702410", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x7026BC", Offset = "0x7026BC", VA = "0x7026BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F517C", Offset = "0x3F517C")]
		private sealed class <>c__DisplayClass222_0
		{
			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x701730", Offset = "0x701730", VA = "0x701730")]
			public <>c__DisplayClass222_0()
			{
			}

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x701738", Offset = "0x701738", VA = "0x701738")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F518C", Offset = "0x3F518C")]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__222 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass222_0 <>8__1;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x170000B7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003F0")]
				[Address(RVA = "0x702000", Offset = "0x702000", VA = "0x702000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003F2")]
				[Address(RVA = "0x702070", Offset = "0x702070", VA = "0x702070", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x701C08", Offset = "0x701C08", VA = "0x701C08")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__222(int <>1__state)
			{
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x701C34", Offset = "0x701C34", VA = "0x701C34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x701C38", Offset = "0x701C38", VA = "0x701C38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x702008", Offset = "0x702008", VA = "0x702008", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F519C", Offset = "0x3F519C")]
		private sealed class <>c__DisplayClass223_0
		{
			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x701744", Offset = "0x701744", VA = "0x701744")]
			public <>c__DisplayClass223_0()
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x70174C", Offset = "0x70174C", VA = "0x70174C")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F51AC", Offset = "0x3F51AC")]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__223 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass223_0 <>8__1;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003F8")]
				[Address(RVA = "0x702368", Offset = "0x702368", VA = "0x702368", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003FA")]
				[Address(RVA = "0x7023D8", Offset = "0x7023D8", VA = "0x7023D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x702078", Offset = "0x702078", VA = "0x702078")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__223(int <>1__state)
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x7020A4", Offset = "0x7020A4", VA = "0x7020A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x7020A8", Offset = "0x7020A8", VA = "0x7020A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x702370", Offset = "0x702370", VA = "0x702370", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F51BC", Offset = "0x3F51BC")]
		private sealed class <>c__DisplayClass256_0
		{
			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x701758", Offset = "0x701758", VA = "0x701758")]
			public <>c__DisplayClass256_0()
			{
			}

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x701760", Offset = "0x701760", VA = "0x701760")]
			internal bool <RouteGroupToBus>b__1(GroupBus x)
			{
				return default(bool);
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x701798", Offset = "0x701798", VA = "0x701798")]
			internal bool <RouteGroupToBus>b__0(GroupBus x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F51CC", Offset = "0x3F51CC")]
		private sealed class <>c__DisplayClass264_0
		{
			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x7017D0", Offset = "0x7017D0", VA = "0x7017D0")]
			public <>c__DisplayClass264_0()
			{
			}

			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x7017D8", Offset = "0x7017D8", VA = "0x7017D8")]
			internal bool <FadeSoundGroupToVolume>b__0(GroupFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F51DC", Offset = "0x3F51DC")]
		private sealed class <>c__DisplayClass265_0
		{
			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x6000400")]
			[Address(RVA = "0x701810", Offset = "0x701810", VA = "0x701810")]
			public <>c__DisplayClass265_0()
			{
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0x701818", Offset = "0x701818", VA = "0x701818")]
			internal bool <GlideSoundGroupByPitch>b__0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F51EC", Offset = "0x3F51EC")]
		private sealed class <>c__DisplayClass317_0
		{
			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x701850", Offset = "0x701850", VA = "0x701850")]
			public <>c__DisplayClass317_0()
			{
			}

			[Token(Token = "0x6000403")]
			[Address(RVA = "0x701858", Offset = "0x701858", VA = "0x701858")]
			internal bool <CreateBus>b__0(GroupBus obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F51FC", Offset = "0x3F51FC")]
		private sealed class <>c__DisplayClass321_0
		{
			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x6000404")]
			[Address(RVA = "0x701890", Offset = "0x701890", VA = "0x701890")]
			public <>c__DisplayClass321_0()
			{
			}

			[Token(Token = "0x6000405")]
			[Address(RVA = "0x701898", Offset = "0x701898", VA = "0x701898")]
			internal bool <FadeBusToVolume>b__0(BusFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F520C", Offset = "0x3F520C")]
		private sealed class <>c__DisplayClass322_0
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x6000406")]
			[Address(RVA = "0x7018D0", Offset = "0x7018D0", VA = "0x7018D0")]
			public <>c__DisplayClass322_0()
			{
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0x7018D8", Offset = "0x7018D8", VA = "0x7018D8")]
			internal bool <GlideBusByPitch>b__0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F521C", Offset = "0x3F521C")]
		private sealed class <>c__DisplayClass401_0
		{
			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string categoryName;

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x701910", Offset = "0x701910", VA = "0x701910")]
			public <>c__DisplayClass401_0()
			{
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0x701918", Offset = "0x701918", VA = "0x701918")]
			internal bool <CreateCustomEventCategoryIfNotThere>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F522C", Offset = "0x3F522C")]
		private sealed class <>c__DisplayClass402_0
		{
			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x701950", Offset = "0x701950", VA = "0x701950")]
			public <>c__DisplayClass402_0()
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x701958", Offset = "0x701958", VA = "0x701958")]
			internal bool <CreateCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F523C", Offset = "0x3F523C")]
		private sealed class <>c__DisplayClass403_0
		{
			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x701990", Offset = "0x701990", VA = "0x701990")]
			public <>c__DisplayClass403_0()
			{
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x701998", Offset = "0x701998", VA = "0x701998")]
			internal bool <DeleteCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F524C", Offset = "0x3F524C")]
		private sealed class <>c__DisplayClass404_0
		{
			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x7019D0", Offset = "0x7019D0", VA = "0x7019D0")]
			public <>c__DisplayClass404_0()
			{
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x7019D8", Offset = "0x7019D8", VA = "0x7019D8")]
			internal bool <GetCustomEventByName>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F525C", Offset = "0x3F525C")]
		private sealed class <>c__DisplayClass406_0
		{
			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x701A10", Offset = "0x701A10", VA = "0x701A10")]
			public <>c__DisplayClass406_0()
			{
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x701A18", Offset = "0x701A18", VA = "0x701A18")]
			internal bool <CustomEventExists>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F526C", Offset = "0x3F526C")]
		private sealed class <>c__DisplayClass407_0
		{
			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x701A50", Offset = "0x701A50", VA = "0x701A50")]
			public <>c__DisplayClass407_0()
			{
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x701A58", Offset = "0x701A58", VA = "0x701A58")]
			internal bool <GetChildReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F527C", Offset = "0x3F527C")]
		private sealed class <>c__DisplayClass408_0
		{
			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x701B2C", Offset = "0x701B2C", VA = "0x701B2C")]
			public <>c__DisplayClass408_0()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x701B34", Offset = "0x701B34", VA = "0x701B34")]
			internal bool <GetParentReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002C2")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x40002C3")]
		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		[Token(Token = "0x40002C4")]
		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		[Token(Token = "0x40002C5")]
		public const string LoopDisabledCustomStartEnd = "Loop Clip is always OFF when using Custom Start/End Position";

		[Token(Token = "0x40002C6")]
		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		[Token(Token = "0x40002C7")]
		public const string NoCategory = "[Uncategorized]";

		[Token(Token = "0x40002C8")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x40002C9")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x40002CA")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x40002CB")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x40002CC")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x40002CD")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly List<string> ExemptChildNames;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x40002D1")]
		public const string GizmoFileName = "MasterAudio/MasterAudio Icon.png";

		[Token(Token = "0x40002D2")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x40002D3")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x40002D4")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x40002D5")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x40002D6")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x40002D7")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x40002D8")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x40002D9")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x40002DA")]
		private const int MaxComponents = 20;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool shouldLogDestroys;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool areGroupsExpanded;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool showGizmos;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showAdvancedSettings;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool showLocalization;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool playListExpanded;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		public bool playlistsExpanded;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float musicSpatialBlend;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float mixerSpatialBlend;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float _masterAudioVolume;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool vrSettingsExpanded;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
		public bool useSpatializer;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD6")]
		public bool useSpatializerPostFX;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD7")]
		public bool ignoreTimeScale;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool useOcclusion;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public float occlusionFreqChangeSeconds;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public int occlusionMaxRayCastsPerFrame;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		public bool occlusionShowCategories;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		public bool occlusionRaycastsHitTriggers;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		public bool ambientAdvancedExpanded;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int ambientMaxRecalcsPerFrame;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x115")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x116")]
		public bool listenerAdvancedExpanded;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x117")]
		public bool listenerFollowerHasRigidBody;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public VariationFollowerType variationFollowerType;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public bool showFadingSettings;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11E")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11F")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float stopOldestBusFadeTime;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
		public bool logOutOfVoices;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x127")]
		public bool LogSounds;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool logCustomEvents;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		public bool disableLogging;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		public bool showMusicDucking;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12B")]
		public bool enableMusicDucking;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public float defaultRiseVolStart;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public float defaultUnduckTime;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public float crossFadeTime;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public bool showGroupSelect;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public string newEventName;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public bool showCustomEvents;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public int frames;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly PlaySoundResult AndForgetSuccessResult;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Dictionary<string, List<int>> _randomizerOrigin;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private readonly List<CustomEventCandidate> ValidReceivers;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly List<GroupPitchGlideInfo> GroupPitchGlides;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly List<BusPitchGlideInfo> BusPitchGlides;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private bool _isStoppingMultiple;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
		private float _repriTime;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private List<string> _groupsToRemove;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private bool _mustRescanGroups;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private Transform _trans;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private bool _soundsLoaded;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x281")]
		private bool _warming;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static MasterAudio _instance;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Transform _listenerTrans;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5E08", Offset = "0x3F5E08")]
		private static bool <AppIsShuttingDown>k__BackingField;

		[Token(Token = "0x17000057")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x5366A4", Offset = "0x5366A4", VA = "0x5366A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x520890", Offset = "0x520890", VA = "0x520890")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x5375FC", Offset = "0x5375FC", VA = "0x5375FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x53766C", Offset = "0x53766C", VA = "0x53766C")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public static bool LogOutOfVoices
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x52C844", Offset = "0x52C844", VA = "0x52C844")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x5376E4", Offset = "0x5376E4", VA = "0x5376E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x5389E4", Offset = "0x5389E4", VA = "0x5389E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x504438", Offset = "0x504438", VA = "0x504438")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x538B78", Offset = "0x538B78", VA = "0x538B78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public static bool IsWarming
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x516194", Offset = "0x516194", VA = "0x516194")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		public static bool MixerMuted
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x538C40", Offset = "0x538C40", VA = "0x538C40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x533FF8", Offset = "0x533FF8", VA = "0x533FF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x538CB0", Offset = "0x538CB0", VA = "0x538CB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x53547C", Offset = "0x53547C", VA = "0x53547C")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x52DA6C", Offset = "0x52DA6C", VA = "0x52DA6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x538D20", Offset = "0x538D20", VA = "0x538D20")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x538D2C", Offset = "0x538D2C", VA = "0x538D2C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000062")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x535038", Offset = "0x535038", VA = "0x535038")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x531258", Offset = "0x531258", VA = "0x531258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x51AEAC", Offset = "0x51AEAC", VA = "0x51AEAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x51D8FC", Offset = "0x51D8FC", VA = "0x51D8FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x5033C0", Offset = "0x5033C0", VA = "0x5033C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x504D2C", Offset = "0x504D2C", VA = "0x504D2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x538D34", Offset = "0x538D34", VA = "0x538D34")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public static bool SoundsReady
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x50F4D8", Offset = "0x50F4D8", VA = "0x50F4D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x5032C4", Offset = "0x5032C4", VA = "0x5032C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F6244", Offset = "0x3F6244")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x52A814", Offset = "0x52A814", VA = "0x52A814")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F6254", Offset = "0x3F6254")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public List<string> GroupNames
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x538D9C", Offset = "0x538D9C", VA = "0x538D9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public static List<string> SoundGroupHardCodedNames
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x503DF4", Offset = "0x503DF4", VA = "0x503DF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public List<string> BusNames
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x539170", Offset = "0x539170", VA = "0x539170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x5392F4", Offset = "0x5392F4", VA = "0x5392F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public List<string> PlaylistNamesOnly
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x539478", Offset = "0x539478", VA = "0x539478")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public Transform Trans
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x504F58", Offset = "0x504F58", VA = "0x504F58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x5395B4", Offset = "0x5395B4", VA = "0x5395B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x5395BC", Offset = "0x5395BC", VA = "0x5395BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public List<string> CustomEventNamesOnly
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x5397B8", Offset = "0x5397B8", VA = "0x5397B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public static List<string> CustomEventHardCodedNames
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x5396DC", Offset = "0x5396DC", VA = "0x5396DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x539920", Offset = "0x539920", VA = "0x539920")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x5206C4", Offset = "0x5206C4", VA = "0x5206C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x52A884", Offset = "0x52A884", VA = "0x52A884")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000076")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x50E29C", Offset = "0x50E29C", VA = "0x50E29C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x506508", Offset = "0x506508", VA = "0x506508")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x539990", Offset = "0x539990", VA = "0x539990")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x539A64", Offset = "0x539A64", VA = "0x539A64")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000079")]
		public static bool ShouldRescanGroups
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x539BE0", Offset = "0x539BE0", VA = "0x539BE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007A")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x539CB8", Offset = "0x539CB8", VA = "0x539CB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x539D20", Offset = "0x539D20", VA = "0x539D20")]
			set
			{
			}
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x5263D8", Offset = "0x5263D8", VA = "0x5263D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x528260", Offset = "0x528260", VA = "0x528260")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x528468", Offset = "0x528468", VA = "0x528468")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x52871C", Offset = "0x52871C", VA = "0x52871C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x529DD8", Offset = "0x529DD8", VA = "0x529DD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x529FD8", Offset = "0x529FD8", VA = "0x529FD8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x529FEC", Offset = "0x529FEC", VA = "0x529FEC")]
		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x52A0EC", Offset = "0x52A0EC", VA = "0x52A0EC")]
		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x529DE8", Offset = "0x529DE8", VA = "0x529DE8")]
		private void UpdateActiveVariations()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x52A180", Offset = "0x52A180", VA = "0x52A180")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x529A70", Offset = "0x529A70", VA = "0x529A70")]
		private static void RecalcClosestColliderPositions()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x529954", Offset = "0x529954", VA = "0x529954")]
		private static void FireCustomEventsWaiting()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x5295B0", Offset = "0x5295B0", VA = "0x5295B0")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x5287B4", Offset = "0x5287B4", VA = "0x5287B4")]
		private static void PerformOcclusionFrequencyChanges()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x528AEC", Offset = "0x528AEC", VA = "0x528AEC")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x529018", Offset = "0x529018", VA = "0x529018")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x5293C0", Offset = "0x5293C0", VA = "0x5293C0")]
		private void PerformGroupPitchGlides()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x528E2C", Offset = "0x528E2C", VA = "0x528E2C")]
		private void PerformBusPitchGlides()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x52A7B4", Offset = "0x52A7B4", VA = "0x52A7B4")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x50D464", Offset = "0x50D464", VA = "0x50D464")]
		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x518CD4", Offset = "0x518CD4", VA = "0x518CD4")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x52C1F4", Offset = "0x52C1F4", VA = "0x52C1F4")]
		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x52C3A4", Offset = "0x52C3A4", VA = "0x52C3A4")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x50A17C", Offset = "0x50A17C", VA = "0x50A17C")]
		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x50A424", Offset = "0x50A424", VA = "0x50A424")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x50A6B0", Offset = "0x50A6B0", VA = "0x50A6B0")]
		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x50A958", Offset = "0x50A958", VA = "0x50A958")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x52C538", Offset = "0x52C538", VA = "0x52C538")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3F6118", Offset = "0x3F6118")]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x50ABFC", Offset = "0x50ABFC", VA = "0x50ABFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3F617C", Offset = "0x3F617C")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x50AE00", Offset = "0x50AE00", VA = "0x50AE00")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3F61E0", Offset = "0x3F61E0")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x52C1AC", Offset = "0x52C1AC", VA = "0x52C1AC")]
		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x52A918", Offset = "0x52A918", VA = "0x52A918")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x52CEF8", Offset = "0x52CEF8", VA = "0x52CEF8")]
		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x52C7D4", Offset = "0x52C7D4", VA = "0x52C7D4")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x52CC38", Offset = "0x52CC38", VA = "0x52CC38")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x52CF70", Offset = "0x52CF70", VA = "0x52CF70")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x52D808", Offset = "0x52D808", VA = "0x52D808")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x52DA74", Offset = "0x52DA74", VA = "0x52DA74")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x50B67C", Offset = "0x50B67C", VA = "0x50B67C")]
		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x503624", Offset = "0x503624", VA = "0x503624")]
		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x50AFA4", Offset = "0x50AFA4", VA = "0x50AFA4")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x50B474", Offset = "0x50B474", VA = "0x50B474")]
		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x50BCB0", Offset = "0x50BCB0", VA = "0x50BCB0")]
		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x50C180", Offset = "0x50C180", VA = "0x50C180")]
		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x51C9C4", Offset = "0x51C9C4", VA = "0x51C9C4")]
		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x509B14", Offset = "0x509B14", VA = "0x509B14")]
		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x51C1A0", Offset = "0x51C1A0", VA = "0x51C1A0")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x51B094", Offset = "0x51B094", VA = "0x51B094")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x52DDD8", Offset = "0x52DDD8", VA = "0x52DDD8")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x509DC4", Offset = "0x509DC4", VA = "0x509DC4")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x52E0BC", Offset = "0x52E0BC", VA = "0x52E0BC")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x52E46C", Offset = "0x52E46C", VA = "0x52E46C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x52E6C8", Offset = "0x52E6C8", VA = "0x52E6C8")]
		public static void DeleteGroupVariation(string sType, string variationName)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x52F7EC", Offset = "0x52F7EC", VA = "0x52F7EC")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x52FFD0", Offset = "0x52FFD0", VA = "0x52FFD0")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x5303BC", Offset = "0x5303BC", VA = "0x5303BC")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x530720", Offset = "0x530720", VA = "0x530720")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x5308D0", Offset = "0x5308D0", VA = "0x5308D0")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x530C00", Offset = "0x530C00", VA = "0x530C00")]
		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x530F64", Offset = "0x530F64", VA = "0x530F64")]
		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x51AFA4", Offset = "0x51AFA4", VA = "0x51AFA4")]
		public static bool IsSoundGroupPlaying(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x50C398", Offset = "0x50C398", VA = "0x50C398")]
		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x51CBA4", Offset = "0x51CBA4", VA = "0x51CBA4")]
		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x53154C", Offset = "0x53154C", VA = "0x53154C")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x51B314", Offset = "0x51B314", VA = "0x51B314")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x531F9C", Offset = "0x531F9C", VA = "0x531F9C")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x51BE90", Offset = "0x51BE90", VA = "0x51BE90")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x53203C", Offset = "0x53203C", VA = "0x53203C")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x5321D4", Offset = "0x5321D4", VA = "0x5321D4")]
		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x51C5FC", Offset = "0x51C5FC", VA = "0x51C5FC")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x51B950", Offset = "0x51B950", VA = "0x51B950")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x51D2C4", Offset = "0x51D2C4", VA = "0x51D2C4")]
		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x510518", Offset = "0x510518", VA = "0x510518")]
		public static void DeleteSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x511470", Offset = "0x511470", VA = "0x511470")]
		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x532638", Offset = "0x532638", VA = "0x532638")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x52A334", Offset = "0x52A334", VA = "0x52A334")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x51BD34", Offset = "0x51BD34", VA = "0x51BD34")]
		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x51C4F4", Offset = "0x51C4F4", VA = "0x51C4F4")]
		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x527F94", Offset = "0x527F94", VA = "0x527F94")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x532A00", Offset = "0x532A00", VA = "0x532A00")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x532854", Offset = "0x532854", VA = "0x532854")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x5284F8", Offset = "0x5284F8", VA = "0x5284F8")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x532398", Offset = "0x532398", VA = "0x532398")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x532AB0", Offset = "0x532AB0", VA = "0x532AB0")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x5326F4", Offset = "0x5326F4", VA = "0x5326F4")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x51C028", Offset = "0x51C028", VA = "0x51C028")]
		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x510D28", Offset = "0x510D28", VA = "0x510D28")]
		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x532E94", Offset = "0x532E94", VA = "0x532E94")]
		private static void UnsilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x533068", Offset = "0x533068", VA = "0x533068")]
		private static void UnsilenceGroup(string sType)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x532CA4", Offset = "0x532CA4", VA = "0x532CA4")]
		private static void SilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x533200", Offset = "0x533200", VA = "0x533200")]
		private static void SilenceGroup(string sType)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x51C884", Offset = "0x51C884", VA = "0x51C884")]
		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x504A40", Offset = "0x504A40", VA = "0x504A40")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x533398", Offset = "0x533398", VA = "0x533398")]
		public static int VoicesForGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x5334CC", Offset = "0x5334CC", VA = "0x5334CC")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x533700", Offset = "0x533700", VA = "0x533700")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x53386C", Offset = "0x53386C", VA = "0x53386C")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x533968", Offset = "0x533968", VA = "0x533968")]
		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x533AEC", Offset = "0x533AEC", VA = "0x533AEC")]
		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x533C14", Offset = "0x533C14", VA = "0x533C14")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x520998", Offset = "0x520998", VA = "0x520998")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x520B94", Offset = "0x520B94", VA = "0x520B94")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x520D90", Offset = "0x520D90", VA = "0x520D90")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x533D6C", Offset = "0x533D6C", VA = "0x533D6C")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x52119C", Offset = "0x52119C", VA = "0x52119C")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x5210DC", Offset = "0x5210DC", VA = "0x5210DC")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x52113C", Offset = "0x52113C", VA = "0x52113C")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x521014", Offset = "0x521014", VA = "0x521014")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x521078", Offset = "0x521078", VA = "0x521078")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x5343F8", Offset = "0x5343F8", VA = "0x5343F8")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x52A624", Offset = "0x52A624", VA = "0x52A624")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x5312C8", Offset = "0x5312C8", VA = "0x5312C8")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x51F550", Offset = "0x51F550", VA = "0x51F550")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x51EBE8", Offset = "0x51EBE8", VA = "0x51EBE8")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x51EE30", Offset = "0x51EE30", VA = "0x51EE30")]
		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x51F01C", Offset = "0x51F01C", VA = "0x51F01C")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x51E664", Offset = "0x51E664", VA = "0x51E664")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x51F11C", Offset = "0x51F11C", VA = "0x51F11C")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x51F364", Offset = "0x51F364", VA = "0x51F364")]
		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x534718", Offset = "0x534718", VA = "0x534718")]
		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x52C8B4", Offset = "0x52C8B4", VA = "0x52C8B4")]
		private static void StopOldestSoundOnBus(GroupBus bus)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x51E828", Offset = "0x51E828", VA = "0x51E828")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x51EA44", Offset = "0x51EA44", VA = "0x51EA44")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x5111D4", Offset = "0x5111D4", VA = "0x5111D4")]
		public static bool CreateBus(string busName, bool errorOnExisting = true, bool isTemporary = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x51034C", Offset = "0x51034C", VA = "0x51034C")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x5348D8", Offset = "0x5348D8", VA = "0x5348D8")]
		public static void DeleteBusByIndex(int busIndex)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x52D74C", Offset = "0x52D74C", VA = "0x52D74C")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x51DA78", Offset = "0x51DA78", VA = "0x51DA78")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x51DE54", Offset = "0x51DE54", VA = "0x51DE54")]
		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x528154", Offset = "0x528154", VA = "0x528154")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x534C30", Offset = "0x534C30", VA = "0x534C30")]
		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x531360", Offset = "0x531360", VA = "0x531360")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x5110C4", Offset = "0x5110C4", VA = "0x5110C4")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x50B22C", Offset = "0x50B22C", VA = "0x50B22C")]
		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x50BF38", Offset = "0x50BF38", VA = "0x50BF38")]
		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x50B98C", Offset = "0x50B98C", VA = "0x50B98C")]
		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x512950", Offset = "0x512950", VA = "0x512950")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x5103EC", Offset = "0x5103EC", VA = "0x5103EC")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x534EA0", Offset = "0x534EA0", VA = "0x534EA0")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x5350A8", Offset = "0x5350A8", VA = "0x5350A8")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x5351F8", Offset = "0x5351F8", VA = "0x5351F8")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x519B74", Offset = "0x519B74", VA = "0x519B74")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x519B04", Offset = "0x519B04", VA = "0x519B04")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x535350", Offset = "0x535350", VA = "0x535350")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x535598", Offset = "0x535598", VA = "0x535598")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x519D88", Offset = "0x519D88", VA = "0x519D88")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x519D18", Offset = "0x519D18", VA = "0x519D18")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x535600", Offset = "0x535600", VA = "0x535600")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x53572C", Offset = "0x53572C", VA = "0x53572C")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x519F9C", Offset = "0x519F9C", VA = "0x519F9C")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x519F2C", Offset = "0x519F2C", VA = "0x519F2C")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x535794", Offset = "0x535794", VA = "0x535794")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x535854", Offset = "0x535854", VA = "0x535854")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x51A8E0", Offset = "0x51A8E0", VA = "0x51A8E0")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x51A870", Offset = "0x51A870", VA = "0x51A870")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x5358BC", Offset = "0x5358BC", VA = "0x5358BC")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x53597C", Offset = "0x53597C", VA = "0x53597C")]
		public static void UnpausePlaylist()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x51AD08", Offset = "0x51AD08", VA = "0x51AD08")]
		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x51AC98", Offset = "0x51AC98", VA = "0x51AC98")]
		public static void UnpauseAllPlaylists()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x5359E4", Offset = "0x5359E4", VA = "0x5359E4")]
		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x535AA4", Offset = "0x535AA4", VA = "0x535AA4")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x51AAF4", Offset = "0x51AAF4", VA = "0x51AAF4")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x51AA84", Offset = "0x51AA84", VA = "0x51AA84")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x535B0C", Offset = "0x535B0C", VA = "0x535B0C")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x535BD0", Offset = "0x535BD0", VA = "0x535BD0")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x51A6CC", Offset = "0x51A6CC", VA = "0x51A6CC")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x51A65C", Offset = "0x51A65C", VA = "0x51A65C")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x535C38", Offset = "0x535C38", VA = "0x535C38")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x535CF8", Offset = "0x535CF8", VA = "0x535CF8")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x51A4B8", Offset = "0x51A4B8", VA = "0x51A4B8")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x51A448", Offset = "0x51A448", VA = "0x51A448")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x535D60", Offset = "0x535D60", VA = "0x535D60")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x535E20", Offset = "0x535E20", VA = "0x535E20")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x518F18", Offset = "0x518F18", VA = "0x518F18")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x518EA8", Offset = "0x518EA8", VA = "0x518EA8")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x535E88", Offset = "0x535E88", VA = "0x535E88")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x535F48", Offset = "0x535F48", VA = "0x535F48")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x5190DC", Offset = "0x5190DC", VA = "0x5190DC")]
		public static void StartPlaylist(string playlistControllerName, string playlistName)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x519454", Offset = "0x519454", VA = "0x519454")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x536078", Offset = "0x536078", VA = "0x536078")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x5194C4", Offset = "0x5194C4", VA = "0x5194C4")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x535FB8", Offset = "0x535FB8", VA = "0x535FB8")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x519688", Offset = "0x519688", VA = "0x519688")]
		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x5361A0", Offset = "0x5361A0", VA = "0x5361A0")]
		public static void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x5196F8", Offset = "0x5196F8", VA = "0x5196F8")]
		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x5360E0", Offset = "0x5360E0", VA = "0x5360E0")]
		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x536208", Offset = "0x536208", VA = "0x536208")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x51A2C4", Offset = "0x51A2C4", VA = "0x51A2C4")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x536278", Offset = "0x536278", VA = "0x536278")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x51A140", Offset = "0x51A140", VA = "0x51A140")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x5362E8", Offset = "0x5362E8", VA = "0x5362E8")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x5192CC", Offset = "0x5192CC", VA = "0x5192CC")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x536368", Offset = "0x536368", VA = "0x536368")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x519944", Offset = "0x519944", VA = "0x519944")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x5198BC", Offset = "0x5198BC", VA = "0x5198BC")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x5363E8", Offset = "0x5363E8", VA = "0x5363E8")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x513070", Offset = "0x513070", VA = "0x513070")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x510B48", Offset = "0x510B48", VA = "0x510B48")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x536550", Offset = "0x536550", VA = "0x536550")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x536714", Offset = "0x536714", VA = "0x536714")]
		public static void ReDownloadAllInternetFiles()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x513220", Offset = "0x513220", VA = "0x513220")]
		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x5218B0", Offset = "0x5218B0", VA = "0x5218B0")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x521CF0", Offset = "0x521CF0", VA = "0x521CF0")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x536C14", Offset = "0x536C14", VA = "0x536C14")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x512AF4", Offset = "0x512AF4", VA = "0x512AF4")]
		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, bool isTemporary)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x512D08", Offset = "0x512D08", VA = "0x512D08")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x5109BC", Offset = "0x5109BC", VA = "0x5109BC")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x536F00", Offset = "0x536F00", VA = "0x536F00")]
		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x51F728", Offset = "0x51F728", VA = "0x51F728")]
		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x521544", Offset = "0x521544", VA = "0x521544")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x537054", Offset = "0x537054", VA = "0x537054")]
		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x5371AC", Offset = "0x5371AC", VA = "0x5371AC")]
		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x537304", Offset = "0x537304", VA = "0x537304")]
		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x52C638", Offset = "0x52C638", VA = "0x52C638")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x52C764", Offset = "0x52C764", VA = "0x52C764")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x503954", Offset = "0x503954", VA = "0x503954")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x507AD4", Offset = "0x507AD4", VA = "0x507AD4")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x53775C", Offset = "0x53775C", VA = "0x53775C")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x535260", Offset = "0x535260", VA = "0x535260")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x537988", Offset = "0x537988", VA = "0x537988")]
		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x537BB8", Offset = "0x537BB8", VA = "0x537BB8")]
		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x537DE8", Offset = "0x537DE8", VA = "0x537DE8")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x538018", Offset = "0x538018", VA = "0x538018")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x5383FC", Offset = "0x5383FC", VA = "0x5383FC")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x538590", Offset = "0x538590", VA = "0x538590")]
		public static bool HasQueuedOcclusionRays()
		{
			return default(bool);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x538628", Offset = "0x538628", VA = "0x538628")]
		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x530E08", Offset = "0x530E08", VA = "0x530E08")]
		public static bool IsOcclusionFreqencyTransitioning(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x52F634", Offset = "0x52F634", VA = "0x52F634")]
		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x538268", Offset = "0x538268", VA = "0x538268")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x538718", Offset = "0x538718", VA = "0x538718")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x52DCF8", Offset = "0x52DCF8", VA = "0x52DCF8")]
		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x538A54", Offset = "0x538A54", VA = "0x538A54")]
		public static int RemainingClipsInGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x539B68", Offset = "0x539B68", VA = "0x539B68")]
		public static bool HasAsyncResourceLoaderFeature()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x5325C4", Offset = "0x5325C4", VA = "0x5325C4")]
		public static void RescanGroupsNow()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x539B70", Offset = "0x539B70", VA = "0x539B70")]
		public static void DoneRescanningGroups()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x539D8C", Offset = "0x539D8C", VA = "0x539D8C")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x539F04", Offset = "0x539F04", VA = "0x539F04")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x53A07C", Offset = "0x53A07C", VA = "0x53A07C")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x53A1F4", Offset = "0x53A1F4", VA = "0x53A1F4")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x53A36C", Offset = "0x53A36C", VA = "0x53A36C")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x4000366")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x4000367")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x4000368")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x4000369")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x400036A")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x400036B")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x400036C")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x400036D")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x400036E")]
		public const string Separator = ";";

		[Token(Token = "0x1700007B")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x704F44", Offset = "0x704F44", VA = "0x704F44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x704FB8", Offset = "0x704FB8", VA = "0x704FB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x7050F4", Offset = "0x7050F4", VA = "0x7050F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x705168", Offset = "0x705168", VA = "0x705168")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x705414", Offset = "0x705414", VA = "0x705414")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x7054A4", Offset = "0x7054A4", VA = "0x7054A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public static float? MixerVolume
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x7055D8", Offset = "0x7055D8", VA = "0x7055D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x705660", Offset = "0x705660", VA = "0x705660")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x70578C", Offset = "0x70578C", VA = "0x70578C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x70581C", Offset = "0x70581C", VA = "0x70581C")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public static float? MusicVolume
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x705950", Offset = "0x705950", VA = "0x705950")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x7059D8", Offset = "0x7059D8", VA = "0x7059D8")]
			set
			{
			}
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x704D60", Offset = "0x704D60", VA = "0x704D60")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x704EF0", Offset = "0x704EF0", VA = "0x704EF0")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x70500C", Offset = "0x70500C", VA = "0x70500C")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x7050A0", Offset = "0x7050A0", VA = "0x7050A0")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x7051BC", Offset = "0x7051BC", VA = "0x7051BC")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x705380", Offset = "0x705380", VA = "0x705380")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x705B04", Offset = "0x705B04", VA = "0x705B04")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x20000A4")]
		public class CustomEventSelection
		{
			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x6000416")]
			[Address(RVA = "0x70F240", Offset = "0x70F240", VA = "0x70F240")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000A5")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x70F280", Offset = "0x70F280", VA = "0x70F280")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000A6")]
		public enum MAItemType
		{
			[Token(Token = "0x40005B4")]
			SoundGroups,
			[Token(Token = "0x40005B5")]
			CustomEvents
		}

		[Token(Token = "0x20000A7")]
		public enum TransferMode
		{
			[Token(Token = "0x40005B7")]
			None,
			[Token(Token = "0x40005B8")]
			Import,
			[Token(Token = "0x40005B9")]
			Export
		}

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string newEventName;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x70F034", Offset = "0x70F034", VA = "0x70F034")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x70F0A0", Offset = "0x70F0A0", VA = "0x70F0A0")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public static class AmbientUtil
	{
		[Token(Token = "0x4000385")]
		public const string FollowerHolderName = "_Followers";

		[Token(Token = "0x4000386")]
		public const string ListenerFollowerName = "~ListenerFollower~";

		[Token(Token = "0x4000387")]
		public const float ListenerFollowerTrigRadius = 0.01f;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _followerHolder;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ListenerFollower _listenerFollower;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Rigidbody _listenerFollowerRB;

		[Token(Token = "0x17000081")]
		public static ListenerFollower ListenerFollower
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x504674", Offset = "0x504674", VA = "0x504674")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public static Transform FollowerHolder
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x503FBC", Offset = "0x503FBC", VA = "0x503FBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public static bool HasListenerFollower
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x504FF0", Offset = "0x504FF0", VA = "0x504FF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public static bool HasListenerFolowerRigidBody
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x5038D8", Offset = "0x5038D8", VA = "0x5038D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x503F30", Offset = "0x503F30", VA = "0x503F30")]
		public static void InitFollowerHolder()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x5037C8", Offset = "0x5037C8", VA = "0x5037C8")]
		public static bool InitListenerFollower()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x503A00", Offset = "0x503A00", VA = "0x503A00")]
		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders)
		{
			return null;
		}
	}
	[Token(Token = "0x2000048")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x50506C", Offset = "0x50506C", VA = "0x50506C")]
		public static void SortIntArray(ref List<int> list)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x5051E4", Offset = "0x5051E4", VA = "0x5051E4")]
		public static bool IsExcludedChildName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000049")]
	public static class AudioTransformExtensions
	{
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x509A90", Offset = "0x509A90", VA = "0x509A90")]
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x509D60", Offset = "0x509D60", VA = "0x509D60")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x50A0D0", Offset = "0x50A0D0", VA = "0x50A0D0")]
		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x50A364", Offset = "0x50A364", VA = "0x50A364")]
		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x50A604", Offset = "0x50A604", VA = "0x50A604")]
		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x50A898", Offset = "0x50A898", VA = "0x50A898")]
		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x50AB38", Offset = "0x50AB38", VA = "0x50AB38")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x50AD3C", Offset = "0x50AD3C", VA = "0x50AD3C")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x50AF40", Offset = "0x50AF40", VA = "0x50AF40")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x50B1B8", Offset = "0x50B1B8", VA = "0x50B1B8")]
		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x50B400", Offset = "0x50B400", VA = "0x50B400")]
		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x50B618", Offset = "0x50B618", VA = "0x50B618")]
		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x50B918", Offset = "0x50B918", VA = "0x50B918")]
		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x50BBD8", Offset = "0x50BBD8", VA = "0x50BBD8")]
		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x50BC4C", Offset = "0x50BC4C", VA = "0x50BC4C")]
		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x50BEC4", Offset = "0x50BEC4", VA = "0x50BEC4")]
		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x50C10C", Offset = "0x50C10C", VA = "0x50C10C")]
		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x50C324", Offset = "0x50C324", VA = "0x50C324")]
		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004A")]
	public class AudioTransformTracker : MonoBehaviour
	{
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int _frames;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x17000085")]
		public Transform Trans
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x50C5B0", Offset = "0x50C5B0", VA = "0x50C5B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x50C640", Offset = "0x50C640", VA = "0x50C640")]
		private void Update()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x50C650", Offset = "0x50C650", VA = "0x50C650")]
		public AudioTransformTracker()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public static class AudioUtil
	{
		[Token(Token = "0x400038D")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x400038E")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x400038F")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x17000086")]
		public static float FixedDeltaTime
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x50C718", Offset = "0x50C718", VA = "0x50C718")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000087")]
		public static float FrameTime
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x50C720", Offset = "0x50C720", VA = "0x50C720")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000088")]
		public static float Time
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x50C728", Offset = "0x50C728", VA = "0x50C728")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000089")]
		public static int FrameCount
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x50C730", Offset = "0x50C730", VA = "0x50C730")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x50C658", Offset = "0x50C658", VA = "0x50C658")]
		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x50C6C0", Offset = "0x50C6C0", VA = "0x50C6C0")]
		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x50C6EC", Offset = "0x50C6EC", VA = "0x50C6EC")]
		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x50C738", Offset = "0x50C738", VA = "0x50C738")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x50C788", Offset = "0x50C788", VA = "0x50C788")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x50C84C", Offset = "0x50C84C", VA = "0x50C84C")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x50C900", Offset = "0x50C900", VA = "0x50C900")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x50C978", Offset = "0x50C978", VA = "0x50C978")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x505AF8", Offset = "0x505AF8", VA = "0x505AF8")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x50C9EC", Offset = "0x50C9EC", VA = "0x50C9EC")]
		public static bool IsAudioPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x50CA38", Offset = "0x50CA38", VA = "0x50CA38")]
		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x50CAC8", Offset = "0x50CAC8", VA = "0x50CAC8")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x506BC4", Offset = "0x506BC4", VA = "0x506BC4")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x50CBB0", Offset = "0x50CBB0", VA = "0x50CBB0")]
		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x50CC4C", Offset = "0x50CC4C", VA = "0x50CC4C")]
		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x50CC88", Offset = "0x50CC88", VA = "0x50CC88")]
		private static float GetPositiveUsablePitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x50CC98", Offset = "0x50CC98", VA = "0x50CC98")]
		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x50CCE4", Offset = "0x50CCE4", VA = "0x50CCE4")]
		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x50CCF8", Offset = "0x50CCF8", VA = "0x50CCF8")]
		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200004C")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F528C", Offset = "0x3F528C")]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__2;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600041B")]
				[Address(RVA = "0x50DD00", Offset = "0x50DD00", VA = "0x50DD00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600041D")]
				[Address(RVA = "0x50DD70", Offset = "0x50DD70", VA = "0x50DD70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0x50DC08", Offset = "0x50DC08", VA = "0x50DC08")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x50DC34", Offset = "0x50DC34", VA = "0x50DC34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600041A")]
			[Address(RVA = "0x50DC38", Offset = "0x50DC38", VA = "0x50DC38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600041C")]
			[Address(RVA = "0x50DD08", Offset = "0x50DD08", VA = "0x50DD08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x50DB8C", Offset = "0x50DB8C", VA = "0x50DB8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3F6384", Offset = "0x3F6384")]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x200004D")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F529C", Offset = "0x3F529C")]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x170000BD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000421")]
				[Address(RVA = "0x50E30C", Offset = "0x50E30C", VA = "0x50E30C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000423")]
				[Address(RVA = "0x50E37C", Offset = "0x50E37C", VA = "0x50E37C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0x50E0AC", Offset = "0x50E0AC", VA = "0x50E0AC")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x50E13C", Offset = "0x50E13C", VA = "0x50E13C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x50E140", Offset = "0x50E140", VA = "0x50E140", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x50E314", Offset = "0x50E314", VA = "0x50E314", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x50DECC", Offset = "0x50DECC", VA = "0x50DECC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x50DF70", Offset = "0x50DF70", VA = "0x50DF70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x50E000", Offset = "0x50E000", VA = "0x50E000")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x50E038", Offset = "0x50E038", VA = "0x50E038")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3F63E8", Offset = "0x3F63E8")]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x50E0D8", Offset = "0x50E0D8", VA = "0x50E0D8")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x504CF8", Offset = "0x504CF8", VA = "0x504CF8")]
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x50DE6C", Offset = "0x50DE6C", VA = "0x50DE6C")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x50DE98", Offset = "0x50DE98", VA = "0x50DE98")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x504250", Offset = "0x504250", VA = "0x504250")]
		public static void DestroyAllChildren(this Transform tran)
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x3F5070", Offset = "0x3F5070")]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x20000AA")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x40005C2")]
			FirstEnableOnly,
			[Token(Token = "0x40005C3")]
			EveryEnable
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F52AC", Offset = "0x3F52AC")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEventCategory aCat;

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x510B40", Offset = "0x510B40", VA = "0x510B40")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x513658", Offset = "0x513658", VA = "0x513658")]
			internal bool <RemoveItems>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000394")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string newEventName;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool showMusicDucking;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool playListExpanded;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool playlistEditorExp;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string audioSourceTemplateName;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool groupByBus;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _hasCreated;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x1700008A")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x511468", Offset = "0x511468", VA = "0x511468")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008B")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x513408", Offset = "0x513408", VA = "0x513408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x513410", Offset = "0x513410", VA = "0x513410")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x50EE20", Offset = "0x50EE20", VA = "0x50EE20")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x50EEF0", Offset = "0x50EEF0", VA = "0x50EEF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x50EFE0", Offset = "0x50EFE0", VA = "0x50EFE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x50EFE4", Offset = "0x50EFE4", VA = "0x50EFE4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x50EEF4", Offset = "0x50EEF4", VA = "0x50EEF4")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x50F0BC", Offset = "0x50F0BC", VA = "0x50F0BC")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x50F5B0", Offset = "0x50F5B0", VA = "0x50F5B0")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x5131B0", Offset = "0x5131B0", VA = "0x5131B0")]
		private void FireEvents()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x510DFC", Offset = "0x510DFC", VA = "0x510DFC")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x513418", Offset = "0x513418", VA = "0x513418")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public static class FilePlayerPrefs
	{
		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Hashtable PlayerPrefsHashtable;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _hashTableChanged;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _serializedOutput;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string SerializedInput;

		[Token(Token = "0x40003B9")]
		private const string ParametersSeperator = ";";

		[Token(Token = "0x40003BA")]
		private const string KeyValueSeperator = ":";

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string FileName;

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x523744", Offset = "0x523744", VA = "0x523744")]
		static FilePlayerPrefs()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x523BE0", Offset = "0x523BE0", VA = "0x523BE0")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x523C6C", Offset = "0x523C6C", VA = "0x523C6C")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x523DC0", Offset = "0x523DC0", VA = "0x523DC0")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x523F54", Offset = "0x523F54", VA = "0x523F54")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x5240E8", Offset = "0x5240E8", VA = "0x5240E8")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x524280", Offset = "0x524280", VA = "0x524280")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x524390", Offset = "0x524390", VA = "0x524390")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x524500", Offset = "0x524500", VA = "0x524500")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x5246C4", Offset = "0x5246C4", VA = "0x5246C4")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x524848", Offset = "0x524848", VA = "0x524848")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x524A04", Offset = "0x524A04", VA = "0x524A04")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x524B88", Offset = "0x524B88", VA = "0x524B88")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x524C90", Offset = "0x524C90", VA = "0x524C90")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x524E20", Offset = "0x524E20", VA = "0x524E20")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x524EAC", Offset = "0x524EAC", VA = "0x524EAC")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x524F30", Offset = "0x524F30", VA = "0x524F30")]
		public static void Flush()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x5250C0", Offset = "0x5250C0", VA = "0x5250C0")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x523894", Offset = "0x523894", VA = "0x523894")]
		private static void Deserialize()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x525684", Offset = "0x525684", VA = "0x525684")]
		private static string EscapeNonSeperators(string inputToEscape)
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x525720", Offset = "0x525720", VA = "0x525720")]
		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x5257BC", Offset = "0x5257BC", VA = "0x5257BC")]
		public static object GetTypeValue(string typeName, string value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x3F5084", Offset = "0x3F5084")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3F5084", Offset = "0x3F5084")]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x20000AC")]
		public enum AudioPlayType
		{
			[Token(Token = "0x40005C6")]
			PlayNow,
			[Token(Token = "0x40005C7")]
			Schedule,
			[Token(Token = "0x40005C8")]
			AlreadyScheduled
		}

		[Token(Token = "0x20000AD")]
		public enum PlaylistStates
		{
			[Token(Token = "0x40005CA")]
			NotInScene,
			[Token(Token = "0x40005CB")]
			Stopped,
			[Token(Token = "0x40005CC")]
			Playing,
			[Token(Token = "0x40005CD")]
			Paused,
			[Token(Token = "0x40005CE")]
			Crossfading
		}

		[Token(Token = "0x20000AE")]
		public enum FadeMode
		{
			[Token(Token = "0x40005D0")]
			None,
			[Token(Token = "0x40005D1")]
			GradualFade
		}

		[Token(Token = "0x20000AF")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x40005D3")]
			NotDucking,
			[Token(Token = "0x40005D4")]
			SetToDuck,
			[Token(Token = "0x40005D5")]
			Ducked
		}

		[Token(Token = "0x20000B0")]
		public delegate void SongChangedEventHandler(string newSongName);

		[Token(Token = "0x20000B1")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x20000B2")]
		public delegate void SongLoopedEventHandler(string songName);

		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F52BC", Offset = "0x3F52BC")]
		private sealed class <>c__DisplayClass107_0
		{
			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string playlistControllerName;

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x7092D8", Offset = "0x7092D8", VA = "0x7092D8")]
			public <>c__DisplayClass107_0()
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x70EC40", Offset = "0x70EC40", VA = "0x70EC40")]
			internal bool <InstanceByName>b__0(PlaylistController obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F52CC", Offset = "0x3F52CC")]
		private sealed class <>c__DisplayClass126_0
		{
			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x70BB2C", Offset = "0x70BB2C", VA = "0x70BB2C")]
			public <>c__DisplayClass126_0()
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x70ECF0", Offset = "0x70ECF0", VA = "0x70ECF0")]
			internal bool <QueuePlaylistClip>b__0(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F52DC", Offset = "0x3F52DC")]
		private sealed class <>c__DisplayClass127_0
		{
			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x70BF2C", Offset = "0x70BF2C", VA = "0x70BF2C")]
			public <>c__DisplayClass127_0()
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x70EDDC", Offset = "0x70EDDC", VA = "0x70EDDC")]
			internal bool <TriggerPlaylistClip>b__0(MusicSetting obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x70EE14", Offset = "0x70EE14", VA = "0x70EE14")]
			internal bool <TriggerPlaylistClip>b__1(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F52EC", Offset = "0x3F52EC")]
		private sealed class <>c__DisplayClass137_0
		{
			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlaylistController <>4__this;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volumeBeforeFade;

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x70C598", Offset = "0x70C598", VA = "0x70C598")]
			public <>c__DisplayClass137_0()
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x70EF1C", Offset = "0x70EF1C", VA = "0x70EF1C")]
			internal void <FadeOutPlaylist>b__0()
			{
			}
		}

		[Token(Token = "0x40003BC")]
		public const float ScheduledSongMinBadOffset = 0.5f;

		[Token(Token = "0x40003BD")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x40003BE")]
		public const int FramesEarlyToBeSyncable = 10;

		[Token(Token = "0x40003BF")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x40003C0")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x40003C1")]
		private const float SlowestFrameTimeForCalc = 0.3f;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool initializedEventExpanded;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string initializedCustomEvent;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool crossfadeStartedExpanded;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string crossfadeStartedCustomEvent;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string songChangedCustomEvent;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string songEndedCustomEvent;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool songLoopedEventExpanded;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string songLoopedCustomEvent;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool playlistStartedEventExpanded;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string playlistStartedCustomEvent;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool playlistEndedEventExpanded;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string playlistEndedCustomEvent;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioSource _activeAudio;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _crossFadeStartTime;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _timeToStartUnducking;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _originalMusicVolume;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _initialDuckVolume;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _duckRange;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private MusicSetting _currentSong;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _go;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _name;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float _slowFadeStartTime;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float _slowFadeCompletionTime;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float _slowFadeStartVolume;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool _lostFocus;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		private bool _autoStartedPlaylist;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private AudioSource _audioClip;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private AudioSource _transClip;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _nextSongRequested;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x171")]
		private bool _nextSongScheduled;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float _currentDuckVolCut;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int? _lastSongPosition;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private double? _currentSchedSongDspStartTime;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private double? _currentSchedSongDspEndTime;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int _lastFrameSongPosition;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public int _frames;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private int _songsPlayedFromPlaylist;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private AudioSource _audio1;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private AudioSource _audio2;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Transform _trans;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private bool _willPersist;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private double? _songPauseTime;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private int framesOfSongPlayed;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5E48", Offset = "0x3F5E48")]
		private bool <ControllerIsReady>k__BackingField;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F5E58", Offset = "0x3F5E58")]
		private bool <IsCrossFading>k__BackingField;

		[Token(Token = "0x1700008D")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x70E624", Offset = "0x70E624", VA = "0x70E624")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008E")]
		private bool ShouldLoadAsync
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x70C64C", Offset = "0x70C64C", VA = "0x70C64C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008F")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x7068D8", Offset = "0x7068D8", VA = "0x7068D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F64CC", Offset = "0x3F64CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x7068E0", Offset = "0x7068E0", VA = "0x7068E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F64DC", Offset = "0x3F64DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x7086E8", Offset = "0x7086E8", VA = "0x7086E8")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x17000091")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x7077A4", Offset = "0x7077A4", VA = "0x7077A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x7092E0", Offset = "0x7092E0", VA = "0x7092E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x70E680", Offset = "0x70E680", VA = "0x70E680")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x70E6D4", Offset = "0x70E6D4", VA = "0x70E6D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x70E6DC", Offset = "0x70E6DC", VA = "0x70E6DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x70E6E4", Offset = "0x70E6E4", VA = "0x70E6E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x70E784", Offset = "0x70E784", VA = "0x70E784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x70E82C", Offset = "0x70E82C", VA = "0x70E82C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public bool IsCrossFading
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x708028", Offset = "0x708028", VA = "0x708028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F64EC", Offset = "0x3F64EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x70836C", Offset = "0x70836C", VA = "0x70836C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F64FC", Offset = "0x3F64FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool IsFading
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x70E844", Offset = "0x70E844", VA = "0x70E844")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009A")]
		public float PlaylistVolume
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x70C0E0", Offset = "0x70C0E0", VA = "0x70C0E0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x70E864", Offset = "0x70E864", VA = "0x70E864")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x70C6F0", Offset = "0x70C6F0", VA = "0x70C6F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public bool HasPlaylist
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x7095DC", Offset = "0x7095DC", VA = "0x7095DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		public string PlaylistName
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x70E8D0", Offset = "0x70E8D0", VA = "0x70E8D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		private bool IsMuted
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x706F14", Offset = "0x706F14", VA = "0x706F14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009F")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x709744", Offset = "0x709744", VA = "0x709744")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		private float CrossFadeTime
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x708500", Offset = "0x708500", VA = "0x708500")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A1")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x70859C", Offset = "0x70859C", VA = "0x70859C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A2")]
		public GameObject GameObj
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x70A014", Offset = "0x70A014", VA = "0x70A014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		public string ControllerName
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x7068EC", Offset = "0x7068EC", VA = "0x7068EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public bool CanSchedule
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x708378", Offset = "0x708378", VA = "0x708378")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A5")]
		private bool IsFrameFastEnough
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x706F24", Offset = "0x706F24", VA = "0x706F24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A6")]
		private bool ShouldNotSwitchEarly
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x7086AC", Offset = "0x7086AC", VA = "0x7086AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A7")]
		private Transform Trans
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x706E24", Offset = "0x706E24", VA = "0x706E24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x70E94C", Offset = "0x70E94C", VA = "0x70E94C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000004")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x705D60", Offset = "0x705D60", VA = "0x705D60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F646C", Offset = "0x3F646C")]
			add
			{
			}
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x705E50", Offset = "0x705E50", VA = "0x705E50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F647C", Offset = "0x3F647C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x705F40", Offset = "0x705F40", VA = "0x705F40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F648C", Offset = "0x3F648C")]
			add
			{
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x706030", Offset = "0x706030", VA = "0x706030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F649C", Offset = "0x3F649C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SongLoopedEventHandler SongLooped
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x706120", Offset = "0x706120", VA = "0x706120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F64AC", Offset = "0x3F64AC")]
			add
			{
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x706210", Offset = "0x706210", VA = "0x706210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F64BC", Offset = "0x3F64BC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x706300", Offset = "0x706300", VA = "0x706300")]
		private void Awake()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x706934", Offset = "0x706934", VA = "0x706934")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x706B6C", Offset = "0x706B6C", VA = "0x706B6C")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x706AA4", Offset = "0x706AA4", VA = "0x706AA4")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x706C10", Offset = "0x706C10", VA = "0x706C10")]
		private void Start()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x706EB4", Offset = "0x706EB4", VA = "0x706EB4")]
		private void AutoStartPlaylist()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x70700C", Offset = "0x70700C", VA = "0x70700C")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x707484", Offset = "0x707484", VA = "0x707484")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x707574", Offset = "0x707574", VA = "0x707574")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x707884", Offset = "0x707884", VA = "0x707884")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x707890", Offset = "0x707890", VA = "0x707890")]
		private void Update()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x709154", Offset = "0x709154", VA = "0x709154")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x70949C", Offset = "0x70949C", VA = "0x70949C")]
		public bool IsSongPlaying(string songName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x7095EC", Offset = "0x7095EC", VA = "0x7095EC")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x709690", Offset = "0x709690", VA = "0x709690")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x706F1C", Offset = "0x706F1C", VA = "0x706F1C")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x70973C", Offset = "0x70973C", VA = "0x70973C")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x7098D4", Offset = "0x7098D4", VA = "0x7098D4")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x709AF0", Offset = "0x709AF0", VA = "0x709AF0")]
		public bool UnpausePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x707394", Offset = "0x707394", VA = "0x707394")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x70A200", Offset = "0x70A200", VA = "0x70A200")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x70A328", Offset = "0x70A328", VA = "0x70A328")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x70A3B4", Offset = "0x70A3B4", VA = "0x70A3B4")]
		public void PlayARandomSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x70A5B8", Offset = "0x70A5B8", VA = "0x70A5B8")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x70AEE4", Offset = "0x70AEE4", VA = "0x70AEE4")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x70B03C", Offset = "0x70B03C", VA = "0x70B03C")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x70B0C8", Offset = "0x70B0C8", VA = "0x70B0C8")]
		public void PlayTheNextSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x70B27C", Offset = "0x70B27C", VA = "0x70B27C")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x70B318", Offset = "0x70B318", VA = "0x70B318")]
		public void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x70B528", Offset = "0x70B528", VA = "0x70B528")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x70B6D0", Offset = "0x70B6D0", VA = "0x70B6D0")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x70BB34", Offset = "0x70BB34", VA = "0x70BB34")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x70BF34", Offset = "0x70BF34", VA = "0x70BF34")]
		public void DuckMusicForTime(float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x70C0A4", Offset = "0x70C0A4", VA = "0x70C0A4")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x70724C", Offset = "0x70724C", VA = "0x70724C")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x70C150", Offset = "0x70C150", VA = "0x70C150")]
		public void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x70C2AC", Offset = "0x70C2AC", VA = "0x70C2AC")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x709F4C", Offset = "0x709F4C", VA = "0x709F4C")]
		private void FinishPlaylistInit(bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x70C220", Offset = "0x70C220", VA = "0x70C220")]
		public void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x70C3D8", Offset = "0x70C3D8", VA = "0x70C3D8")]
		private void CheckIfPlaylistStarted()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x70C4BC", Offset = "0x70C4BC", VA = "0x70C4BC")]
		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x708808", Offset = "0x708808", VA = "0x708808")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x706DF0", Offset = "0x706DF0", VA = "0x706DF0")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x706F4C", Offset = "0x706F4C", VA = "0x706F4C")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x7085D4", Offset = "0x7085D4", VA = "0x7085D4")]
		private void FirePlaylistEndedEventIfAny()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x70ACCC", Offset = "0x70ACCC", VA = "0x70ACCC")]
		private void FillClips()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x70A670", Offset = "0x70A670", VA = "0x70A670")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x70D39C", Offset = "0x70D39C", VA = "0x70D39C")]
		public double? ScheduledGaplessNextSongStartTime()
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x70C798", Offset = "0x70C798", VA = "0x70C798")]
		public void FinishLoadingNewSong(AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x70D588", Offset = "0x70D588", VA = "0x70D588")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x70B6C8", Offset = "0x70B6C8", VA = "0x70B6C8")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x7088F4", Offset = "0x7088F4", VA = "0x7088F4")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x70D634", Offset = "0x70D634", VA = "0x70D634")]
		private double CalculateNextTrackStartTimeOffset()
		{
			return default(double);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x70DE50", Offset = "0x70DE50", VA = "0x70DE50")]
		private double GetClipDuration(AudioSource src)
		{
			return default(double);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x70A0A4", Offset = "0x70A0A4", VA = "0x70A0A4")]
		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x70D46C", Offset = "0x70D46C", VA = "0x70D46C")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x708030", Offset = "0x708030", VA = "0x708030")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x708414", Offset = "0x708414", VA = "0x708414")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x709030", Offset = "0x709030", VA = "0x709030")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x70C5A0", Offset = "0x70C5A0", VA = "0x70C5A0")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x70E86C", Offset = "0x70E86C", VA = "0x70E86C")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x70E9AC", Offset = "0x70E9AC", VA = "0x70E9AC")]
		public PlaylistController()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x70EB28", Offset = "0x70EB28", VA = "0x70EB28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F650C", Offset = "0x3F650C")]
		private bool <FindOtherControllerInSameSyncGroup>b__136_0(PlaylistController obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x70EC30", Offset = "0x70EC30", VA = "0x70EC30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F651C", Offset = "0x3F651C")]
		private bool <FinishLoadingNewSong>b__144_0(MusicSetting obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000052")]
	public static class SpatializerHelper
	{
		[Token(Token = "0x4000411")]
		private const string OculusSpatializer = "OculusSpatializer";

		[Token(Token = "0x4000412")]
		private const string ResonanceAudioSpatializer = "Resonance Audio";

		[Token(Token = "0x170000A9")]
		public static bool IsSupportedSpatializer
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x717B58", Offset = "0x717B58", VA = "0x717B58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AA")]
		public static bool IsResonanceAudioSpatializer
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x717BE4", Offset = "0x717BE4", VA = "0x717BE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AB")]
		public static string SelectedSpatializer
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x717BDC", Offset = "0x717BDC", VA = "0x717BDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		public static bool SpatializerOptionExists
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x717C38", Offset = "0x717C38", VA = "0x717C38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x7102C4", Offset = "0x7102C4", VA = "0x7102C4")]
		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
		}
	}
	[Token(Token = "0x2000053")]
	public static class UtilStrings
	{
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x717C48", Offset = "0x717C48", VA = "0x717C48")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x717CCC", Offset = "0x717CCC", VA = "0x717CCC")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
}
