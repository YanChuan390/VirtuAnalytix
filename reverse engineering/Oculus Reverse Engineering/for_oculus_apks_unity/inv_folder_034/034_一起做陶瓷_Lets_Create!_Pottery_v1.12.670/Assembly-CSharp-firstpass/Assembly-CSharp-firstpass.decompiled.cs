using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x201DD0", Offset = "0x201DD0")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0xC")]
		public float effectAngle;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x10")]
		public float effectWidth;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x14")]
		public float effectDistance;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x1C")]
		private Collider[] m_Cols;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0xD2E450", Offset = "0xD2E450", VA = "0xD2E450")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xD2E500", Offset = "0xD2E500", VA = "0xD2E500")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xD2EBE4", Offset = "0xD2EBE4", VA = "0xD2EBE4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xD2F3A8", Offset = "0xD2F3A8", VA = "0xD2F3A8")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000014")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x202098", Offset = "0x202098")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000042")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000043")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000044")]
			[FieldOffset(Offset = "0x10")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x4000045")]
			[FieldOffset(Offset = "0x14")]
			private float <multiplier>5__2;

			[Token(Token = "0x17000001")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000049")]
				[Address(RVA = "0xD2FE3C", Offset = "0xD2FE3C", VA = "0xD2FE3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000002")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600004B")]
				[Address(RVA = "0xD2FECC", Offset = "0xD2FECC", VA = "0xD2FECC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0xD2F45C", Offset = "0xD2F45C", VA = "0xD2F45C")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000047")]
			[Address(RVA = "0xD2F624", Offset = "0xD2F624", VA = "0xD2F624", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000048")]
			[Address(RVA = "0xD2F628", Offset = "0xD2F628", VA = "0xD2F628", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600004A")]
			[Address(RVA = "0xD2FE44", Offset = "0xD2FE44", VA = "0xD2FE44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0xC")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x10")]
		public Transform firePrefab;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x14")]
		public int numDebrisPieces;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x18")]
		public int numFires;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xD2F3D0", Offset = "0xD2F3D0", VA = "0xD2F3D0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x2020B8", Offset = "0x2020B8")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xD2F47C", Offset = "0xD2F47C", VA = "0xD2F47C")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xD2F61C", Offset = "0xD2F61C", VA = "0xD2F61C")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2020A8", Offset = "0x2020A8")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000046")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x10")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x17000003")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600004F")]
				[Address(RVA = "0xD30400", Offset = "0xD30400", VA = "0xD30400", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000051")]
				[Address(RVA = "0xD30490", Offset = "0xD30490", VA = "0xD30490", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600004C")]
			[Address(RVA = "0xD2FF60", Offset = "0xD2FF60", VA = "0xD2FF60")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0xD2FF94", Offset = "0xD2FF94", VA = "0xD2FF94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0xD2FF98", Offset = "0xD2FF98", VA = "0xD2FF98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0xD30408", Offset = "0xD30408", VA = "0xD30408", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0xC")]
		public float explosionForce;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xD2FED4", Offset = "0xD2FED4", VA = "0xD2FED4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x202130", Offset = "0x202130")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xD2FF80", Offset = "0xD2FF80", VA = "0xD2FF80")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0xC")]
		public float multiplier;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x10")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xD30498", Offset = "0xD30498", VA = "0xD30498")]
		private void Start()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xD30500", Offset = "0xD30500", VA = "0xD30500")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xD30598", Offset = "0xD30598", VA = "0xD30598")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0xC")]
		private float m_Rnd;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x10")]
		private bool m_Burning;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x14")]
		private Light m_Light;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xD305A8", Offset = "0xD305A8", VA = "0xD305A8")]
		private void Start()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xD3062C", Offset = "0xD3062C", VA = "0xD3062C")]
		private void Update()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xD30920", Offset = "0xD30920", VA = "0xD30920")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xD30958", Offset = "0xD30958", VA = "0xD30958")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0xC")]
		public float maxPower;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x10")]
		public float minPower;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x14")]
		public float changeSpeed;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x18")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x1C")]
		public Renderer systemRenderer;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x20")]
		private float m_Power;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xD30968", Offset = "0xD30968", VA = "0xD30968")]
		private void Update()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xD30BB0", Offset = "0xD30BB0", VA = "0xD30BB0")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0xC")]
		public float multiplier;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xD30BD4", Offset = "0xD30BD4", VA = "0xD30BD4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xD30DC4", Offset = "0xD30DC4", VA = "0xD30DC4")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0xC")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xD30DD4", Offset = "0xD30DD4", VA = "0xD30DD4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xD30F08", Offset = "0xD30F08", VA = "0xD30F08")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0xC")]
		public float force;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x10")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x14")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xD30F10", Offset = "0xD30F10", VA = "0xD30F10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xD30F78", Offset = "0xD30F78", VA = "0xD30F78")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xD3129C", Offset = "0xD3129C", VA = "0xD3129C")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x200000B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x201E48", Offset = "0x201E48")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0xD31330", Offset = "0xD31330", VA = "0xD31330")]
		public void Awake()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xD31358", Offset = "0xD31358", VA = "0xD31358")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xD313D0", Offset = "0xD313D0", VA = "0xD313D0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xD31448", Offset = "0xD31448", VA = "0xD31448")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x200000C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x201ED0", Offset = "0x201ED0")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xD31450", Offset = "0xD31450", VA = "0xD31450")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class MeshContainer
	{
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x8")]
		public Mesh mesh;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0xC")]
		public Vector3[] vertices;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x10")]
		public Vector3[] normals;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xD31458", Offset = "0xD31458", VA = "0xD31458")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xD314C4", Offset = "0xD314C4", VA = "0xD314C4")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x201F58", Offset = "0x201F58")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0xC")]
		public LayerMask reflectionMask;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x10")]
		public bool reflectSkybox;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x14")]
		public Color clearColor;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x24")]
		public string reflectionSampler;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x28")]
		public float clipPlaneOffset;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x38")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x3C")]
		private Material m_SharedMaterial;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xD31524", Offset = "0xD31524", VA = "0xD31524")]
		public void Start()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xD31688", Offset = "0xD31688", VA = "0xD31688")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xD31AF8", Offset = "0xD31AF8", VA = "0xD31AF8")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xD31BFC", Offset = "0xD31BFC", VA = "0xD31BFC")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xD31D50", Offset = "0xD31D50", VA = "0xD31D50")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xD32EBC", Offset = "0xD32EBC", VA = "0xD32EBC")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xD32F28", Offset = "0xD32F28", VA = "0xD32F28")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xD33060", Offset = "0xD33060", VA = "0xD33060")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xD330D8", Offset = "0xD330D8", VA = "0xD330D8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xD31F24", Offset = "0xD31F24", VA = "0xD31F24")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xD33150", Offset = "0xD33150", VA = "0xD33150")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xD337C4", Offset = "0xD337C4", VA = "0xD337C4")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xD3320C", Offset = "0xD3320C", VA = "0xD3320C")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xD33B94", Offset = "0xD33B94", VA = "0xD33B94")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xD33570", Offset = "0xD33570", VA = "0xD33570")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xD33BC8", Offset = "0xD33BC8", VA = "0xD33BC8")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x201FE0", Offset = "0x201FE0")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0xC")]
		public Transform specularLight;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x10")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xD33C68", Offset = "0xD33C68", VA = "0xD33C68")]
		public void Start()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xD33D84", Offset = "0xD33D84", VA = "0xD33D84")]
		public void Update()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xD3406C", Offset = "0xD3406C", VA = "0xD3406C")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000016")]
		public enum WaterMode
		{
			[Token(Token = "0x400004A")]
			Simple,
			[Token(Token = "0x400004B")]
			Reflective,
			[Token(Token = "0x400004C")]
			Refractive
		}

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0xC")]
		public WaterMode waterMode;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x10")]
		public bool disablePixelLights;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x14")]
		public int textureSize;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x18")]
		public float clipPlaneOffset;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x1C")]
		public LayerMask reflectLayers;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x20")]
		public LayerMask refractLayers;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x2C")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x34")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x38")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x3C")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xD34074", Offset = "0xD34074", VA = "0xD34074")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xD370A8", Offset = "0xD370A8", VA = "0xD370A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xD374EC", Offset = "0xD374EC", VA = "0xD374EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xD36778", Offset = "0xD36778", VA = "0xD36778")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xD35768", Offset = "0xD35768", VA = "0xD35768")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xD35750", Offset = "0xD35750", VA = "0xD35750")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xD355A4", Offset = "0xD355A4", VA = "0xD355A4")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xD36E54", Offset = "0xD36E54", VA = "0xD36E54")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xD36B80", Offset = "0xD36B80", VA = "0xD36B80")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xD378BC", Offset = "0xD378BC", VA = "0xD378BC")]
		public Water()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public enum WaterQuality
	{
		[Token(Token = "0x400003A")]
		High = 2,
		[Token(Token = "0x400003B")]
		Medium = 1,
		[Token(Token = "0x400003C")]
		Low = 0
	}
	[Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0xC")]
		public Material sharedMaterial;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x10")]
		public WaterQuality waterQuality;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x14")]
		public bool edgeBlend;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xD379A8", Offset = "0xD379A8", VA = "0xD379A8")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xD37BBC", Offset = "0xD37BBC", VA = "0xD37BBC")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xD37CA8", Offset = "0xD37CA8", VA = "0xD37CA8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xD37D40", Offset = "0xD37D40", VA = "0xD37D40")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0xC")]
		public PlanarReflection reflection;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x10")]
		public WaterBase waterBase;

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xD37D58", Offset = "0xD37D58", VA = "0xD37D58")]
		public void Start()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xD37D5C", Offset = "0xD37D5C", VA = "0xD37D5C")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xD37FD8", Offset = "0xD37FD8", VA = "0xD37FD8")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xD3811C", Offset = "0xD3811C", VA = "0xD3811C")]
		public WaterTile()
		{
		}
	}
}
