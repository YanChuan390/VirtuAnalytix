using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using VEAGames.LAM.Constants;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class PatchCulling : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public MeshRenderer[] DetailPatches;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x798204", Offset = "0x798204", VA = "0x798204")]
	public void DestroyPatch()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x798270", Offset = "0x798270", VA = "0x798270")]
	public void RendererEnabled(bool enabled = true)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x798364", Offset = "0x798364", VA = "0x798364")]
	public void ShadowCastingMode(ShadowCastingMode mode)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x798454", Offset = "0x798454", VA = "0x798454")]
	public PatchCulling()
	{
	}
}
[Token(Token = "0x2000003")]
public class FlyController : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	public MouseLook MouseLook;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x79845C", Offset = "0x79845C", VA = "0x79845C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x7984B8", Offset = "0x7984B8", VA = "0x7984B8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x7986BC", Offset = "0x7986BC", VA = "0x7986BC")]
	public FlyController()
	{
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000004")]
	[RequireComponent(typeof(SphereCollider))]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x798738", Offset = "0x798738", VA = "0x798738")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x798810", Offset = "0x798810", VA = "0x798810")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x798D7C", Offset = "0x798D7C", VA = "0x798D7C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x7992CC", Offset = "0x7992CC", VA = "0x7992CC")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000006")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x17000001")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000012")]
				[Address(RVA = "0x799A00", Offset = "0x799A00", VA = "0x799A00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000002")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000013")]
				[Address(RVA = "0x799A08", Offset = "0x799A08", VA = "0x799A08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600000F")]
			[Address(RVA = "0x799354", Offset = "0x799354", VA = "0x799354")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000010")]
			[Address(RVA = "0x7994D0", Offset = "0x7994D0", VA = "0x7994D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0x7994D4", Offset = "0x7994D4", VA = "0x7994D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x7992E0", Offset = "0x7992E0", VA = "0x7992E0")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x79937C", Offset = "0x79937C", VA = "0x79937C")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x7994C8", Offset = "0x7994C8", VA = "0x7994C8")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000008")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x17000003")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000019")]
				[Address(RVA = "0x799EA4", Offset = "0x799EA4", VA = "0x799EA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600001A")]
				[Address(RVA = "0x799EAC", Offset = "0x799EAC", VA = "0x799EAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000016")]
			[Address(RVA = "0x799A84", Offset = "0x799A84", VA = "0x799A84")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000017")]
			[Address(RVA = "0x799ABC", Offset = "0x799ABC", VA = "0x799ABC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000018")]
			[Address(RVA = "0x799AC0", Offset = "0x799AC0", VA = "0x799AC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x799A10", Offset = "0x799A10", VA = "0x799A10")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x799AAC", Offset = "0x799AAC", VA = "0x799AAC")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x799EB4", Offset = "0x799EB4", VA = "0x799EB4")]
		private void Start()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x799F0C", Offset = "0x799F0C", VA = "0x799F0C")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x799F84", Offset = "0x799F84", VA = "0x799F84")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x799F94", Offset = "0x799F94", VA = "0x799F94")]
		private void Start()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x79A004", Offset = "0x79A004", VA = "0x79A004")]
		private void Update()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x79A1EC", Offset = "0x79A1EC", VA = "0x79A1EC")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x79A214", Offset = "0x79A214", VA = "0x79A214")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x79A224", Offset = "0x79A224", VA = "0x79A224")]
		private void Update()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x79A36C", Offset = "0x79A36C", VA = "0x79A36C")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x79A388", Offset = "0x79A388", VA = "0x79A388")]
		private void Start()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x79A4B4", Offset = "0x79A4B4", VA = "0x79A4B4")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x79A4C4", Offset = "0x79A4C4", VA = "0x79A4C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x79A574", Offset = "0x79A574", VA = "0x79A574")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x79A57C", Offset = "0x79A57C", VA = "0x79A57C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x79A5D4", Offset = "0x79A5D4", VA = "0x79A5D4")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x79A8B4", Offset = "0x79A8B4", VA = "0x79A8B4")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x200000F")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x79A948", Offset = "0x79A948", VA = "0x79A948")]
		private void Update()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x79AB44", Offset = "0x79AB44", VA = "0x79AB44")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x79AB4C", Offset = "0x79AB4C", VA = "0x79AB4C")]
		public void Awake()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x79AB6C", Offset = "0x79AB6C", VA = "0x79AB6C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x79ABD0", Offset = "0x79ABD0", VA = "0x79ABD0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x79AC34", Offset = "0x79AC34", VA = "0x79AC34")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x79AC3C", Offset = "0x79AC3C", VA = "0x79AC3C")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x79AC44", Offset = "0x79AC44", VA = "0x79AC44")]
		public void Start()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x79AD40", Offset = "0x79AD40", VA = "0x79AD40")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x79B050", Offset = "0x79B050", VA = "0x79B050")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x79B104", Offset = "0x79B104", VA = "0x79B104")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x79B25C", Offset = "0x79B25C", VA = "0x79B25C")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x79BAD0", Offset = "0x79BAD0", VA = "0x79BAD0")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x79BB28", Offset = "0x79BB28", VA = "0x79BB28")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x79BC08", Offset = "0x79BC08", VA = "0x79BC08")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x79BC6C", Offset = "0x79BC6C", VA = "0x79BC6C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x79B418", Offset = "0x79B418", VA = "0x79B418")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x79BCD0", Offset = "0x79BCD0", VA = "0x79BCD0")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x79BF84", Offset = "0x79BF84", VA = "0x79BF84")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x79BD30", Offset = "0x79BD30", VA = "0x79BD30")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x79C0F0", Offset = "0x79C0F0", VA = "0x79C0F0")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x79BDD4", Offset = "0x79BDD4", VA = "0x79BDD4")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x79C110", Offset = "0x79C110", VA = "0x79C110")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x79C180", Offset = "0x79C180", VA = "0x79C180")]
		public void Start()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x79C2A8", Offset = "0x79C2A8", VA = "0x79C2A8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x79C4C0", Offset = "0x79C4C0", VA = "0x79C4C0")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000015")]
		public enum WaterMode
		{
			[Token(Token = "0x4000041")]
			Simple,
			[Token(Token = "0x4000042")]
			Reflective,
			[Token(Token = "0x4000043")]
			Refractive
		}

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x79C4C8", Offset = "0x79C4C8", VA = "0x79C4C8")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x79DE08", Offset = "0x79DE08", VA = "0x79DE08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x79E170", Offset = "0x79E170", VA = "0x79E170")]
		private void Update()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x79D988", Offset = "0x79D988", VA = "0x79D988")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x79D01C", Offset = "0x79D01C", VA = "0x79D01C")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x79D008", Offset = "0x79D008", VA = "0x79D008")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x79CE9C", Offset = "0x79CE9C", VA = "0x79CE9C")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x79DC58", Offset = "0x79DC58", VA = "0x79DC58")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x79DBC4", Offset = "0x79DBC4", VA = "0x79DBC4")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x79E41C", Offset = "0x79E41C", VA = "0x79E41C")]
		public Water()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public enum WaterQuality
	{
		[Token(Token = "0x4000045")]
		High = 2,
		[Token(Token = "0x4000046")]
		Medium = 1,
		[Token(Token = "0x4000047")]
		Low = 0
	}
	[Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x79E51C", Offset = "0x79E51C", VA = "0x79E51C")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x79E694", Offset = "0x79E694", VA = "0x79E694")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x79E738", Offset = "0x79E738", VA = "0x79E738")]
		public void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x79E7AC", Offset = "0x79E7AC", VA = "0x79E7AC")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x79E7C4", Offset = "0x79E7C4", VA = "0x79E7C4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x79E7C8", Offset = "0x79E7C8", VA = "0x79E7C8")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x79E988", Offset = "0x79E988", VA = "0x79E988")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x79EA6C", Offset = "0x79EA6C", VA = "0x79EA6C")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000019")]
	public enum AAMode
	{
		[Token(Token = "0x400004E")]
		FXAA2,
		[Token(Token = "0x400004F")]
		FXAA3Console,
		[Token(Token = "0x4000050")]
		FXAA1PresetA,
		[Token(Token = "0x4000051")]
		FXAA1PresetB,
		[Token(Token = "0x4000052")]
		NFAA,
		[Token(Token = "0x4000053")]
		SSAA,
		[Token(Token = "0x4000054")]
		DLAA
	}
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x79EA74", Offset = "0x79EA74", VA = "0x79EA74")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x79EADC", Offset = "0x79EADC", VA = "0x79EADC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x79EC4C", Offset = "0x79EC4C", VA = "0x79EC4C")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x79F110", Offset = "0x79F110", VA = "0x79F110")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x200001C")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x400008A")]
			Ghosting,
			[Token(Token = "0x400008B")]
			Anamorphic,
			[Token(Token = "0x400008C")]
			Combined
		}

		[Token(Token = "0x200001D")]
		public enum TweakMode
		{
			[Token(Token = "0x400008E")]
			Basic,
			[Token(Token = "0x400008F")]
			Complex
		}

		[Token(Token = "0x200001E")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x4000091")]
			Auto,
			[Token(Token = "0x4000092")]
			On,
			[Token(Token = "0x4000093")]
			Off
		}

		[Token(Token = "0x200001F")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x4000095")]
			Screen,
			[Token(Token = "0x4000096")]
			Add
		}

		[Token(Token = "0x2000020")]
		public enum BloomQuality
		{
			[Token(Token = "0x4000098")]
			Cheap,
			[Token(Token = "0x4000099")]
			High
		}

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x79F134", Offset = "0x79F134", VA = "0x79F134", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x79F220", Offset = "0x79F220", VA = "0x79F220")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x7A0390", Offset = "0x7A0390", VA = "0x7A0390")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x7A01F8", Offset = "0x7A01F8", VA = "0x7A01F8")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x79FF4C", Offset = "0x79FF4C", VA = "0x79FF4C")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x79FE78", Offset = "0x79FE78", VA = "0x79FE78")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x7A000C", Offset = "0x7A000C", VA = "0x7A000C")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x7A0454", Offset = "0x7A0454", VA = "0x7A0454")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x400009B")]
		Ghosting,
		[Token(Token = "0x400009C")]
		Anamorphic,
		[Token(Token = "0x400009D")]
		Combined
	}
	[Token(Token = "0x2000022")]
	public enum TweakMode34
	{
		[Token(Token = "0x400009F")]
		Basic,
		[Token(Token = "0x40000A0")]
		Complex
	}
	[Token(Token = "0x2000023")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x40000A2")]
		Auto,
		[Token(Token = "0x40000A3")]
		On,
		[Token(Token = "0x40000A4")]
		Off
	}
	[Token(Token = "0x2000024")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x40000A6")]
		Screen,
		[Token(Token = "0x40000A7")]
		Add
	}
	[Token(Token = "0x2000025")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x7A04E0", Offset = "0x7A04E0", VA = "0x7A04E0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x7A063C", Offset = "0x7A063C", VA = "0x7A063C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x7A13FC", Offset = "0x7A13FC", VA = "0x7A13FC")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x7A1274", Offset = "0x7A1274", VA = "0x7A1274")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x7A101C", Offset = "0x7A101C", VA = "0x7A101C")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x7A1124", Offset = "0x7A1124", VA = "0x7A1124")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x7A14AC", Offset = "0x7A14AC", VA = "0x7A14AC")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000027")]
		public enum Resolution
		{
			[Token(Token = "0x40000D3")]
			Low,
			[Token(Token = "0x40000D4")]
			High
		}

		[Token(Token = "0x2000028")]
		public enum BlurType
		{
			[Token(Token = "0x40000D6")]
			Standard,
			[Token(Token = "0x40000D7")]
			Sgx
		}

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x28")]
		public float threshold;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x30")]
		public float blurSize;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x38")]
		public int blurIterations;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x7A1520", Offset = "0x7A1520", VA = "0x7A1520", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x7A1594", Offset = "0x7A1594", VA = "0x7A1594")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x7A1620", Offset = "0x7A1620", VA = "0x7A1620")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x7A1990", Offset = "0x7A1990", VA = "0x7A1990")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x18")]
		public int iterations;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x1C")]
		public float blurSpread;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000005")]
		protected Material material
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x7A19B4", Offset = "0x7A19B4", VA = "0x7A19B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x7A1ABC", Offset = "0x7A1ABC", VA = "0x7A1ABC")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x7A1B68", Offset = "0x7A1B68", VA = "0x7A1B68")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x7A1C18", Offset = "0x7A1C18", VA = "0x7A1C18")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x7A1D28", Offset = "0x7A1D28", VA = "0x7A1D28")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x7A1E24", Offset = "0x7A1E24", VA = "0x7A1E24")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x7A1F80", Offset = "0x7A1F80", VA = "0x7A1F80")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x200002B")]
		public enum BlurType
		{
			[Token(Token = "0x40000E3")]
			StandardGauss,
			[Token(Token = "0x40000E4")]
			SgxGauss
		}

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x28")]
		public int downsample;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x2C")]
		public float blurSize;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x30")]
		public int blurIterations;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x7A1F98", Offset = "0x7A1F98", VA = "0x7A1F98", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x7A200C", Offset = "0x7A200C", VA = "0x7A200C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x7A2098", Offset = "0x7A2098", VA = "0x7A2098")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x7A23C0", Offset = "0x7A23C0", VA = "0x7A23C0")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x200002D")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x4000106")]
			CameraMotion,
			[Token(Token = "0x4000107")]
			LocalBlur,
			[Token(Token = "0x4000108")]
			Reconstruction,
			[Token(Token = "0x4000109")]
			ReconstructionDX11,
			[Token(Token = "0x400010A")]
			ReconstructionDisc
		}

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x168")]
		private Camera _camera;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x7A23DC", Offset = "0x7A23DC", VA = "0x7A23DC")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x7A263C", Offset = "0x7A263C", VA = "0x7A263C")]
		private new void Start()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x7A28CC", Offset = "0x7A28CC", VA = "0x7A28CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x7A298C", Offset = "0x7A298C", VA = "0x7A298C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x7A2AF0", Offset = "0x7A2AF0", VA = "0x7A2AF0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x7A2BA4", Offset = "0x7A2BA4", VA = "0x7A2BA4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x7A276C", Offset = "0x7A276C", VA = "0x7A276C")]
		private void Remember()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x7A46F8", Offset = "0x7A46F8", VA = "0x7A46F8")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x7A4674", Offset = "0x7A4674", VA = "0x7A4674")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x7A46E8", Offset = "0x7A46E8", VA = "0x7A46E8")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x7A4A8C", Offset = "0x7A4A8C", VA = "0x7A4A8C")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[ExecuteInEditMode]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x200002F")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x4000124")]
			Simple,
			[Token(Token = "0x4000125")]
			Advanced
		}

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x7A4C24", Offset = "0x7A4C24", VA = "0x7A4C24")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x7A4C44", Offset = "0x7A4C44", VA = "0x7A4C44", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x7A4F08", Offset = "0x7A4F08", VA = "0x7A4F08")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x7A51FC", Offset = "0x7A51FC", VA = "0x7A51FC")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x7A5200", Offset = "0x7A5200", VA = "0x7A5200")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x7A550C", Offset = "0x7A550C", VA = "0x7A550C")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[ExecuteInEditMode]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x7A5B98", Offset = "0x7A5B98", VA = "0x7A5B98", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x7A5C08", Offset = "0x7A5C08", VA = "0x7A5C08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x7A5CA4", Offset = "0x7A5CA4", VA = "0x7A5CA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x7A5D34", Offset = "0x7A5D34", VA = "0x7A5D34")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x7A5F30", Offset = "0x7A5F30", VA = "0x7A5F30")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x7A6030", Offset = "0x7A6030", VA = "0x7A6030")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x7A6378", Offset = "0x7A6378", VA = "0x7A6378")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x7A656C", Offset = "0x7A656C", VA = "0x7A656C")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[ExecuteInEditMode]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x7A65C4", Offset = "0x7A65C4", VA = "0x7A65C4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x7A6680", Offset = "0x7A6680", VA = "0x7A6680")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x2C")]
		public float threshold;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x40")]
		public float blurSpread;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x7A6688", Offset = "0x7A6688", VA = "0x7A6688", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x7A6724", Offset = "0x7A6724", VA = "0x7A6724")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x7A6A50", Offset = "0x7A6A50", VA = "0x7A6A50")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[ExecuteInEditMode]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x18")]
		public float adaptationSpeed;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x1C")]
		public float limitMinimum;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x20")]
		public float limitMaximum;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000006")]
		protected Material materialLum
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x7A6A68", Offset = "0x7A6A68", VA = "0x7A6A68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x7A6B3C", Offset = "0x7A6B3C", VA = "0x7A6B3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		protected Material materialAdapt
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x7A6C10", Offset = "0x7A6C10", VA = "0x7A6C10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		protected Material materialApply
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x7A6CE4", Offset = "0x7A6CE4", VA = "0x7A6CE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x7A6DB8", Offset = "0x7A6DB8", VA = "0x7A6DB8")]
		private void Start()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x7A6E3C", Offset = "0x7A6E3C", VA = "0x7A6E3C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x7A6F88", Offset = "0x7A6F88", VA = "0x7A6F88")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x7A7164", Offset = "0x7A7164", VA = "0x7A7164")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x7A73A4", Offset = "0x7A73A4", VA = "0x7A73A4")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x7A755C", Offset = "0x7A755C", VA = "0x7A755C")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x7A75D8", Offset = "0x7A75D8", VA = "0x7A75D8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x7A769C", Offset = "0x7A769C", VA = "0x7A769C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x7A7A14", Offset = "0x7A7A14", VA = "0x7A7A14")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x2000036")]
		public enum BlurType
		{
			[Token(Token = "0x4000162")]
			DiscBlur,
			[Token(Token = "0x4000163")]
			DX11
		}

		[Token(Token = "0x2000037")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x4000165")]
			Low,
			[Token(Token = "0x4000166")]
			Medium,
			[Token(Token = "0x4000167")]
			High
		}

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x7A7A30", Offset = "0x7A7A30", VA = "0x7A7A30", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x7A7C30", Offset = "0x7A7C30", VA = "0x7A7C30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x7A7CB0", Offset = "0x7A7CB0", VA = "0x7A7CB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x7A7DA8", Offset = "0x7A7DA8", VA = "0x7A7DA8")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x7A7AE8", Offset = "0x7A7AE8", VA = "0x7A7AE8")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x7A7E00", Offset = "0x7A7E00", VA = "0x7A7E00")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x7A7EEC", Offset = "0x7A7EEC", VA = "0x7A7EEC")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x7A81BC", Offset = "0x7A81BC", VA = "0x7A81BC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x7A94BC", Offset = "0x7A94BC", VA = "0x7A94BC")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x2000039")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x4000194")]
			OnlyBackground = 1,
			[Token(Token = "0x4000195")]
			BackgroundAndForeground
		}

		[Token(Token = "0x200003A")]
		public enum DofResolution
		{
			[Token(Token = "0x4000197")]
			High = 2,
			[Token(Token = "0x4000198")]
			Medium,
			[Token(Token = "0x4000199")]
			Low
		}

		[Token(Token = "0x200003B")]
		public enum DofBlurriness
		{
			[Token(Token = "0x400019B")]
			Low = 1,
			[Token(Token = "0x400019C")]
			High = 2,
			[Token(Token = "0x400019D")]
			VeryHigh = 4
		}

		[Token(Token = "0x200003C")]
		public enum BokehDestination
		{
			[Token(Token = "0x400019F")]
			Background = 1,
			[Token(Token = "0x40001A0")]
			Foreground,
			[Token(Token = "0x40001A1")]
			BackgroundAndForeground
		}

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x7A9514", Offset = "0x7A9514", VA = "0x7A9514")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x7A9A70", Offset = "0x7A9A70", VA = "0x7A9A70", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x7A9D48", Offset = "0x7A9D48", VA = "0x7A9D48")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x7A9EB0", Offset = "0x7A9EB0", VA = "0x7A9EB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x7A9F30", Offset = "0x7A9F30", VA = "0x7A9F30")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x7AA01C", Offset = "0x7AA01C", VA = "0x7AA01C")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x7AA040", Offset = "0x7AA040", VA = "0x7AA040")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x7AA064", Offset = "0x7AA064", VA = "0x7AA064")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x7AADD0", Offset = "0x7AADD0", VA = "0x7AADD0")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x7AB380", Offset = "0x7AB380", VA = "0x7AB380")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x7AB6F4", Offset = "0x7AB6F4", VA = "0x7AB6F4")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x7AACA8", Offset = "0x7AACA8", VA = "0x7AACA8")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x7AAFB0", Offset = "0x7AAFB0", VA = "0x7AAFB0")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x7AB58C", Offset = "0x7AB58C", VA = "0x7AB58C")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x7AA8F8", Offset = "0x7AA8F8", VA = "0x7AA8F8")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x7ABACC", Offset = "0x7ABACC", VA = "0x7ABACC")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x200003E")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40001AE")]
			TriangleDepthNormals,
			[Token(Token = "0x40001AF")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x40001B0")]
			SobelDepth,
			[Token(Token = "0x40001B1")]
			SobelDepthThin,
			[Token(Token = "0x40001B2")]
			TriangleLuminance
		}

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x7ABC24", Offset = "0x7ABC24", VA = "0x7ABC24", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x7ABD5C", Offset = "0x7ABD5C", VA = "0x7ABD5C")]
		private new void Start()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x7ABCAC", Offset = "0x7ABCAC", VA = "0x7ABCAC")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x7ABD68", Offset = "0x7ABD68", VA = "0x7ABD68")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x7ABD6C", Offset = "0x7ABD6C", VA = "0x7ABD6C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x7ABF40", Offset = "0x7ABF40", VA = "0x7ABF40")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x28")]
		public float strengthX;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x2C")]
		public float strengthY;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x7ABF6C", Offset = "0x7ABF6C", VA = "0x7ABF6C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x7ABFD4", Offset = "0x7ABFD4", VA = "0x7ABFD4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x7AC108", Offset = "0x7AC108", VA = "0x7AC108")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x28")]
		public bool distanceFog;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x29")]
		public bool excludeFarPixels;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x2A")]
		public bool useRadialDistance;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x2B")]
		public bool heightFog;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x2C")]
		public float height;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x30")]
		public float heightDensity;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x34")]
		public float startDistance;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x7AC11C", Offset = "0x7AC11C", VA = "0x7AC11C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x7AC184", Offset = "0x7AC184", VA = "0x7AC184")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x7AC714", Offset = "0x7AC714", VA = "0x7AC714")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[ExecuteInEditMode]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x30")]
		public float rampOffset;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x7AC734", Offset = "0x7AC734", VA = "0x7AC734")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x7AC8EC", Offset = "0x7AC8EC", VA = "0x7AC8EC")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[RequireComponent(typeof(Camera))]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x1700000A")]
		protected Material material
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x7AC818", Offset = "0x7AC818", VA = "0x7AC818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x7AC8FC", Offset = "0x7AC8FC", VA = "0x7AC8FC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x7AC99C", Offset = "0x7AC99C", VA = "0x7AC99C", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x7AC8F4", Offset = "0x7AC8F4", VA = "0x7AC8F4")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class ImageEffects
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x7ACA28", Offset = "0x7ACA28", VA = "0x7ACA28")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}
	}
	[Token(Token = "0x2000044")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x28")]
		public float blurAmount;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x7ACC98", Offset = "0x7ACC98", VA = "0x7ACC98", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x7ACC9C", Offset = "0x7ACC9C", VA = "0x7ACC9C", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x7ACD00", Offset = "0x7ACD00", VA = "0x7ACD00")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x7AD068", Offset = "0x7AD068", VA = "0x7AD068")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x7AD07C", Offset = "0x7AD07C", VA = "0x7AD07C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x7AD118", Offset = "0x7AD118", VA = "0x7AD118")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x7AD918", Offset = "0x7AD918", VA = "0x7AD918")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x7ADC58", Offset = "0x7ADC58", VA = "0x7ADC58")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x1C")]
		public float grainIntensityMin;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x20")]
		public float grainIntensityMax;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x24")]
		public float grainSize;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x28")]
		public float scratchIntensityMin;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x2C")]
		public float scratchIntensityMax;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x30")]
		public float scratchFPS;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x34")]
		public float scratchJitter;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x1700000B")]
		protected Material material
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x7ADE0C", Offset = "0x7ADE0C", VA = "0x7ADE0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x7ADCE0", Offset = "0x7ADCE0", VA = "0x7ADCE0")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x7ADF74", Offset = "0x7ADF74", VA = "0x7ADF74")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x7AE044", Offset = "0x7AE044", VA = "0x7AE044")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x7AE0E8", Offset = "0x7AE0E8", VA = "0x7AE0E8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x7AE410", Offset = "0x7AE410", VA = "0x7AE410")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x7A9614", Offset = "0x7A9614", VA = "0x7A9614")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x7AE464", Offset = "0x7AE464", VA = "0x7AE464")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x7AE69C", Offset = "0x7AE69C", VA = "0x7AE69C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x7AE6A8", Offset = "0x7AE6A8", VA = "0x7AE6A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x7AE6AC", Offset = "0x7AE6AC", VA = "0x7AE6AC")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x7AE78C", Offset = "0x7AE78C", VA = "0x7AE78C")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x7AE794", Offset = "0x7AE794", VA = "0x7AE794", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x7AE854", Offset = "0x7AE854", VA = "0x7AE854")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x7A9B98", Offset = "0x7A9B98", VA = "0x7A9B98")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x7AE860", Offset = "0x7AE860", VA = "0x7AE860")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x7AE8B8", Offset = "0x7AE8B8", VA = "0x7AE8B8")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x7A9C90", Offset = "0x7A9C90", VA = "0x7A9C90")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x7AE8C0", Offset = "0x7AE8C0", VA = "0x7AE8C0")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x7AE444", Offset = "0x7AE444", VA = "0x7AE444")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x7AEB44", Offset = "0x7AEB44", VA = "0x7AEB44")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x7ABB40", Offset = "0x7ABB40", VA = "0x7ABB40")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x7AEEBC", Offset = "0x7AEEBC", VA = "0x7AEEBC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x7AEF24", Offset = "0x7AEF24", VA = "0x7AEF24")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x7AF170", Offset = "0x7AF170", VA = "0x7AF170")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x7AF4E4", Offset = "0x7AF4E4", VA = "0x7AF4E4")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x7AF688", Offset = "0x7AF688", VA = "0x7AF688")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000049")]
	internal class Quads
	{
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x7AF690", Offset = "0x7AF690", VA = "0x7AF690")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x7A9D4C", Offset = "0x7A9D4C", VA = "0x7A9D4C")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x7AB894", Offset = "0x7AB894", VA = "0x7AB894")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x7AF760", Offset = "0x7AF760", VA = "0x7AF760")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}
	}
	[Token(Token = "0x200004A")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x200004B")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x40001F7")]
			Additive,
			[Token(Token = "0x40001F8")]
			ScreenBlend,
			[Token(Token = "0x40001F9")]
			Multiply,
			[Token(Token = "0x40001FA")]
			Overlay,
			[Token(Token = "0x40001FB")]
			AlphaBlend
		}

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x7AFAE4", Offset = "0x7AFAE4", VA = "0x7AFAE4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x7AFB4C", Offset = "0x7AFB4C", VA = "0x7AFB4C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x7AFC9C", Offset = "0x7AFC9C", VA = "0x7AFC9C")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x2C")]
		public float radius;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x30")]
		public int blurIterations;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x34")]
		public float blurFilterDistance;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x38")]
		public int downsample;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x7AFCAC", Offset = "0x7AFCAC", VA = "0x7AFCAC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x7AFD14", Offset = "0x7AFD14", VA = "0x7AFD14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x7AFDA4", Offset = "0x7AFDA4", VA = "0x7AFDA4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x7B0558", Offset = "0x7B0558", VA = "0x7B0558")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x200004E")]
		public enum SSAOSamples
		{
			[Token(Token = "0x4000210")]
			Low,
			[Token(Token = "0x4000211")]
			Medium,
			[Token(Token = "0x4000212")]
			High
		}

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x18")]
		public float m_Radius;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x20")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x24")]
		public int m_Blur;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x28")]
		public int m_Downsampling;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x2C")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x30")]
		public float m_MinZ;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x7B0574", Offset = "0x7B0574", VA = "0x7B0574")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x7B0620", Offset = "0x7B0620", VA = "0x7B0620")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x7B06A4", Offset = "0x7B06A4", VA = "0x7B06A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x7B06AC", Offset = "0x7B06AC", VA = "0x7B06AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x7B084C", Offset = "0x7B084C", VA = "0x7B084C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x7B0774", Offset = "0x7B0774", VA = "0x7B0774")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x7B08B8", Offset = "0x7B08B8", VA = "0x7B08B8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x7B0E8C", Offset = "0x7B0E8C", VA = "0x7B0E8C")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class ScreenSpaceReflection : PostEffectsBase
	{
		[Token(Token = "0x2000050")]
		public enum SSRDebugMode
		{
			[Token(Token = "0x4000222")]
			None,
			[Token(Token = "0x4000223")]
			IncomingRadiance,
			[Token(Token = "0x4000224")]
			SSRResult,
			[Token(Token = "0x4000225")]
			FinalGlossyTerm,
			[Token(Token = "0x4000226")]
			SSRMask,
			[Token(Token = "0x4000227")]
			Roughness,
			[Token(Token = "0x4000228")]
			BaseColor,
			[Token(Token = "0x4000229")]
			SpecColor,
			[Token(Token = "0x400022A")]
			Reflectivity,
			[Token(Token = "0x400022B")]
			ReflectionProbeOnly,
			[Token(Token = "0x400022C")]
			ReflectionProbeMinusSSR,
			[Token(Token = "0x400022D")]
			SSRMinusReflectionProbe,
			[Token(Token = "0x400022E")]
			NoGlossy,
			[Token(Token = "0x400022F")]
			NegativeNoGlossy,
			[Token(Token = "0x4000230")]
			MipLevel
		}

		[Token(Token = "0x2000051")]
		public enum SSRResolution
		{
			[Token(Token = "0x4000232")]
			FullResolution,
			[Token(Token = "0x4000233")]
			HalfTraceFullResolve,
			[Token(Token = "0x4000234")]
			HalfResolution
		}

		[Serializable]
		[Token(Token = "0x2000052")]
		public struct SSRSettings
		{
			[Token(Token = "0x4000235")]
			[FieldOffset(Offset = "0x0")]
			public float reflectionMultiplier;

			[Token(Token = "0x4000236")]
			[FieldOffset(Offset = "0x4")]
			public float maxDistance;

			[Token(Token = "0x4000237")]
			[FieldOffset(Offset = "0x8")]
			public float fadeDistance;

			[Token(Token = "0x4000238")]
			[FieldOffset(Offset = "0xC")]
			public float screenEdgeFading;

			[Token(Token = "0x4000239")]
			[FieldOffset(Offset = "0x10")]
			public bool enableHDR;

			[Token(Token = "0x400023A")]
			[FieldOffset(Offset = "0x11")]
			public bool additiveReflection;

			[Token(Token = "0x400023B")]
			[FieldOffset(Offset = "0x14")]
			public int maxSteps;

			[Token(Token = "0x400023C")]
			[FieldOffset(Offset = "0x18")]
			public int rayStepSize;

			[Token(Token = "0x400023D")]
			[FieldOffset(Offset = "0x1C")]
			public float widthModifier;

			[Token(Token = "0x400023E")]
			[FieldOffset(Offset = "0x20")]
			public float smoothFallbackThreshold;

			[Token(Token = "0x400023F")]
			[FieldOffset(Offset = "0x24")]
			public float smoothFallbackDistance;

			[Token(Token = "0x4000240")]
			[FieldOffset(Offset = "0x28")]
			public float fresnelFade;

			[Token(Token = "0x4000241")]
			[FieldOffset(Offset = "0x2C")]
			public float fresnelFadePower;

			[Token(Token = "0x4000242")]
			[FieldOffset(Offset = "0x30")]
			public float distanceBlur;

			[Token(Token = "0x4000243")]
			[FieldOffset(Offset = "0x34")]
			public float temporalFilterStrength;

			[Token(Token = "0x4000244")]
			[FieldOffset(Offset = "0x38")]
			public bool useTemporalConfidence;

			[Token(Token = "0x4000245")]
			[FieldOffset(Offset = "0x39")]
			public bool traceEverywhere;

			[Token(Token = "0x4000246")]
			[FieldOffset(Offset = "0x3A")]
			public bool treatBackfaceHitAsMiss;

			[Token(Token = "0x4000247")]
			[FieldOffset(Offset = "0x3B")]
			public bool suppressBackwardsRays;

			[Token(Token = "0x4000248")]
			[FieldOffset(Offset = "0x3C")]
			public bool improveCorners;

			[Token(Token = "0x4000249")]
			[FieldOffset(Offset = "0x40")]
			public SSRResolution resolution;

			[Token(Token = "0x400024A")]
			[FieldOffset(Offset = "0x44")]
			public bool bilateralUpsample;

			[Token(Token = "0x400024B")]
			[FieldOffset(Offset = "0x45")]
			public bool reduceBanding;

			[Token(Token = "0x400024C")]
			[FieldOffset(Offset = "0x46")]
			public bool highlightSuppression;

			[Token(Token = "0x400024D")]
			[FieldOffset(Offset = "0x48")]
			public SSRDebugMode debugMode;

			[Token(Token = "0x400024E")]
			[FieldOffset(Offset = "0x4C")]
			public bool enable;

			[Token(Token = "0x400024F")]
			[FieldOffset(Offset = "0x0")]
			private static readonly SSRSettings s_Performance;

			[Token(Token = "0x4000250")]
			[FieldOffset(Offset = "0x50")]
			private static readonly SSRSettings s_Default;

			[Token(Token = "0x4000251")]
			[FieldOffset(Offset = "0xA0")]
			private static readonly SSRSettings s_HighQuality;

			[Token(Token = "0x1700000C")]
			public static SSRSettings defaultSettings
			{
				[Token(Token = "0x600010E")]
				[Address(RVA = "0x7B2C44", Offset = "0x7B2C44", VA = "0x7B2C44")]
				get
				{
					return default(SSRSettings);
				}
			}
		}

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public SSRSettings settings;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x78")]
		private bool useEdgeDetector;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x7C")]
		private float mipBias;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x80")]
		private bool useOcclusion;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x81")]
		private bool fullResolutionFiltering;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x82")]
		private bool fallbackToSky;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x83")]
		private bool computeAverageRayDistance;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x84")]
		private bool m_HasInformationFromPreviousFrame;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x88")]
		private Matrix4x4 m_PreviousWorldToCameraMatrix;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0xC8")]
		private RenderTexture m_PreviousDepthBuffer;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0xD0")]
		private RenderTexture m_PreviousHitBuffer;

		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0xD8")]
		private RenderTexture m_PreviousReflectionBuffer;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0xE0")]
		public Shader ssrShader;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0xE8")]
		private Material ssrMaterial;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x7B0EC0", Offset = "0x7B0EC0", VA = "0x7B0EC0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x7B0F28", Offset = "0x7B0F28", VA = "0x7B0F28")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x7B10D0", Offset = "0x7B10D0", VA = "0x7B10D0")]
		private void PreparePreviousBuffers(int w, int h)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x7B12F4", Offset = "0x7B12F4", VA = "0x7B12F4")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x7B2BA0", Offset = "0x7B2BA0", VA = "0x7B2BA0")]
		public ScreenSpaceReflection()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[ExecuteInEditMode]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x7B2E04", Offset = "0x7B2E04", VA = "0x7B2E04")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x7B2E84", Offset = "0x7B2E84", VA = "0x7B2E84")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x2000055")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x4000261")]
			Low,
			[Token(Token = "0x4000262")]
			Normal,
			[Token(Token = "0x4000263")]
			High
		}

		[Token(Token = "0x2000056")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x4000265")]
			Screen,
			[Token(Token = "0x4000266")]
			Add
		}

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x7B2E8C", Offset = "0x7B2E8C", VA = "0x7B2E8C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x7B2F18", Offset = "0x7B2F18", VA = "0x7B2F18")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x7B35D4", Offset = "0x7B35D4", VA = "0x7B35D4")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[RequireComponent(typeof(Camera))]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x2000058")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x400026F")]
			TiltShiftMode,
			[Token(Token = "0x4000270")]
			IrisMode
		}

		[Token(Token = "0x2000059")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x4000272")]
			Preview,
			[Token(Token = "0x4000273")]
			Low,
			[Token(Token = "0x4000274")]
			Normal,
			[Token(Token = "0x4000275")]
			High
		}

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x30")]
		public float blurArea;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x34")]
		public float maxBlurSize;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x38")]
		public int downsample;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x7B3618", Offset = "0x7B3618", VA = "0x7B3618", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x7B3680", Offset = "0x7B3680", VA = "0x7B3680")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x7B3910", Offset = "0x7B3910", VA = "0x7B3910")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x200005B")]
		public enum TonemapperType
		{
			[Token(Token = "0x4000284")]
			SimpleReinhard,
			[Token(Token = "0x4000285")]
			UserCurve,
			[Token(Token = "0x4000286")]
			Hable,
			[Token(Token = "0x4000287")]
			Photographic,
			[Token(Token = "0x4000288")]
			OptimizedHejiDawson,
			[Token(Token = "0x4000289")]
			AdaptiveReinhard,
			[Token(Token = "0x400028A")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x200005C")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x400028C")]
			Square16 = 0x10,
			[Token(Token = "0x400028D")]
			Square32 = 0x20,
			[Token(Token = "0x400028E")]
			Square64 = 0x40,
			[Token(Token = "0x400028F")]
			Square128 = 0x80,
			[Token(Token = "0x4000290")]
			Square256 = 0x100,
			[Token(Token = "0x4000291")]
			Square512 = 0x200,
			[Token(Token = "0x4000292")]
			Square1024 = 0x400
		}

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x7B3928", Offset = "0x7B3928", VA = "0x7B3928", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x7B3A8C", Offset = "0x7B3A8C", VA = "0x7B3A8C")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x7B3D0C", Offset = "0x7B3D0C", VA = "0x7B3D0C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x7B3E64", Offset = "0x7B3E64", VA = "0x7B3E64")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x7B3F64", Offset = "0x7B3F64", VA = "0x7B3F64")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x7B4704", Offset = "0x7B4704", VA = "0x7B4704")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[ExecuteInEditMode]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x7B4730", Offset = "0x7B4730", VA = "0x7B4730")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x7B4768", Offset = "0x7B4768", VA = "0x7B4768")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x200005F")]
		public enum AberrationMode
		{
			[Token(Token = "0x40002A5")]
			Simple,
			[Token(Token = "0x40002A6")]
			Advanced
		}

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x7B4790", Offset = "0x7B4790", VA = "0x7B4790", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x7B4840", Offset = "0x7B4840", VA = "0x7B4840")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x7B4D94", Offset = "0x7B4D94", VA = "0x7B4D94")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[ExecuteInEditMode]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x7B4DC0", Offset = "0x7B4DC0", VA = "0x7B4DC0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x7B4DF8", Offset = "0x7B4DF8", VA = "0x7B4DF8")]
		public Vortex()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x2000061")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x2000062")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x7B5584", Offset = "0x7B5584", VA = "0x7B5584", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x600012B")]
			[Address(RVA = "0x7B4F84", Offset = "0x7B4F84", VA = "0x7B4F84")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x2C")]
		private bool <protecting>k__BackingField;

		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x1700000D")]
		public bool protecting
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x7B4E20", Offset = "0x7B4E20", VA = "0x7B4E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x7B4E28", Offset = "0x7B4E28", VA = "0x7B4E28")]
			private set
			{
			}
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x7B4E34", Offset = "0x7B4E34", VA = "0x7B4E34")]
		private void Start()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x7B4F8C", Offset = "0x7B4F8C", VA = "0x7B4F8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x7B550C", Offset = "0x7B550C", VA = "0x7B550C")]
		public ProtectCameraFromWallClip()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000063")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x7B5678", Offset = "0x7B5678", VA = "0x7B5678")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x7B5900", Offset = "0x7B5900", VA = "0x7B5900")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x7B5A84", Offset = "0x7B5A84", VA = "0x7B5A84")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x7B5AF4", Offset = "0x7B5AF4", VA = "0x7B5AF4", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x7B5BC0", Offset = "0x7B5BC0", VA = "0x7B5BC0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x7B5C24", Offset = "0x7B5C24", VA = "0x7B5C24")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x7B5C90", Offset = "0x7B5C90", VA = "0x7B5C90")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x7B5D58", Offset = "0x7B5D58", VA = "0x7B5D58")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x7B5E20", Offset = "0x7B5E20", VA = "0x7B5E20")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x7B5EE8", Offset = "0x7B5EE8", VA = "0x7B5EE8")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x7B5FB0", Offset = "0x7B5FB0", VA = "0x7B5FB0")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x7B6078", Offset = "0x7B6078", VA = "0x7B6078")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000066")]
		public class VirtualAxis
		{
			[Token(Token = "0x40002C3")]
			[FieldOffset(Offset = "0x10")]
			private string <name>k__BackingField;

			[Token(Token = "0x40002C4")]
			[FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x40002C5")]
			[FieldOffset(Offset = "0x1C")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x1700000E")]
			public string name
			{
				[Token(Token = "0x6000149")]
				[Address(RVA = "0x7B69E4", Offset = "0x7B69E4", VA = "0x7B69E4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600014A")]
				[Address(RVA = "0x7B69EC", Offset = "0x7B69EC", VA = "0x7B69EC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700000F")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600014B")]
				[Address(RVA = "0x7B69F4", Offset = "0x7B69F4", VA = "0x7B69F4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600014C")]
				[Address(RVA = "0x7B69FC", Offset = "0x7B69FC", VA = "0x7B69FC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000010")]
			public float GetValue
			{
				[Token(Token = "0x6000151")]
				[Address(RVA = "0x7B6A50", Offset = "0x7B6A50", VA = "0x7B6A50")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600014D")]
			[Address(RVA = "0x7B57F4", Offset = "0x7B57F4", VA = "0x7B57F4")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x600014E")]
			[Address(RVA = "0x7B6A08", Offset = "0x7B6A08", VA = "0x7B6A08")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600014F")]
			[Address(RVA = "0x7B5A9C", Offset = "0x7B5A9C", VA = "0x7B5A9C")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0x7B6A48", Offset = "0x7B6A48", VA = "0x7B6A48")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000067")]
		public class VirtualButton
		{
			[Token(Token = "0x40002C6")]
			[FieldOffset(Offset = "0x10")]
			private string <name>k__BackingField;

			[Token(Token = "0x40002C7")]
			[FieldOffset(Offset = "0x18")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x40002C8")]
			[FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x40002C9")]
			[FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x40002CA")]
			[FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x17000011")]
			public string name
			{
				[Token(Token = "0x6000152")]
				[Address(RVA = "0x7B6A58", Offset = "0x7B6A58", VA = "0x7B6A58")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000153")]
				[Address(RVA = "0x7B6A60", Offset = "0x7B6A60", VA = "0x7B6A60")]
				private set
				{
				}
			}

			[Token(Token = "0x17000012")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000154")]
				[Address(RVA = "0x7B6A68", Offset = "0x7B6A68", VA = "0x7B6A68")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000155")]
				[Address(RVA = "0x7B6A70", Offset = "0x7B6A70", VA = "0x7B6A70")]
				private set
				{
				}
			}

			[Token(Token = "0x6000156")]
			[Address(RVA = "0x7B6A7C", Offset = "0x7B6A7C", VA = "0x7B6A7C")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000157")]
			[Address(RVA = "0x7B6AC0", Offset = "0x7B6AC0", VA = "0x7B6AC0")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000158")]
			[Address(RVA = "0x7B6B08", Offset = "0x7B6B08", VA = "0x7B6B08")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000159")]
			[Address(RVA = "0x7B6B34", Offset = "0x7B6B34", VA = "0x7B6B34")]
			public void Released()
			{
			}
		}

		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x7B6080", Offset = "0x7B6080", VA = "0x7B6080")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x7B578C", Offset = "0x7B578C", VA = "0x7B578C")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x7B5830", Offset = "0x7B5830", VA = "0x7B5830")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x7B6348", Offset = "0x7B6348", VA = "0x7B6348")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x7B6548", Offset = "0x7B6548", VA = "0x7B6548")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x7B5898", Offset = "0x7B5898", VA = "0x7B5898")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x7B6724", Offset = "0x7B6724", VA = "0x7B6724")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x7B677C", Offset = "0x7B677C", VA = "0x7B677C")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x7B5CE8", Offset = "0x7B5CE8", VA = "0x7B5CE8")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x7B5DB0", Offset = "0x7B5DB0", VA = "0x7B5DB0")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x7B5E78", Offset = "0x7B5E78", VA = "0x7B5E78")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x7B6008", Offset = "0x7B6008", VA = "0x7B6008")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x7B5F40", Offset = "0x7B5F40", VA = "0x7B5F40")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x7B67FC", Offset = "0x7B67FC", VA = "0x7B67FC")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x7B687C", Offset = "0x7B687C", VA = "0x7B687C")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x7B68F4", Offset = "0x7B68F4", VA = "0x7B68F4")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x7B696C", Offset = "0x7B696C", VA = "0x7B696C")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x7B6B54", Offset = "0x7B6B54", VA = "0x7B6B54")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x7B6BC4", Offset = "0x7B6BC4", VA = "0x7B6BC4")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x200006A")]
		public enum AxisOption
		{
			[Token(Token = "0x40002D6")]
			Both,
			[Token(Token = "0x40002D7")]
			OnlyHorizontal,
			[Token(Token = "0x40002D8")]
			OnlyVertical
		}

		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x7B6BCC", Offset = "0x7B6BCC", VA = "0x7B6BCC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x7B6D30", Offset = "0x7B6D30", VA = "0x7B6D30")]
		private void Start()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x7B6D60", Offset = "0x7B6D60", VA = "0x7B6D60")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x7B6BD0", Offset = "0x7B6BD0", VA = "0x7B6BD0")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x7B6DC0", Offset = "0x7B6DC0", VA = "0x7B6DC0", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x7B6F0C", Offset = "0x7B6F0C", VA = "0x7B6F0C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x7B6F48", Offset = "0x7B6F48", VA = "0x7B6F48", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x7B6F4C", Offset = "0x7B6F4C", VA = "0x7B6F4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x7B6F8C", Offset = "0x7B6F8C", VA = "0x7B6F8C")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x7B7018", Offset = "0x7B7018", VA = "0x7B7018")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x7B7028", Offset = "0x7B7028", VA = "0x7B7028")]
		private void Start()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x7B7020", Offset = "0x7B7020", VA = "0x7B7020")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x7B7130", Offset = "0x7B7130", VA = "0x7B7130")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x7B7428", Offset = "0x7B7428", VA = "0x7B7428")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x200006D")]
		public enum AxisOptions
		{
			[Token(Token = "0x40002DF")]
			ForwardAxis,
			[Token(Token = "0x40002E0")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x200006E")]
		public class AxisMapping
		{
			[Token(Token = "0x200006F")]
			public enum MappingType
			{
				[Token(Token = "0x40002E4")]
				NamedAxis,
				[Token(Token = "0x40002E5")]
				MousePositionX,
				[Token(Token = "0x40002E6")]
				MousePositionY,
				[Token(Token = "0x40002E7")]
				MousePositionZ
			}

			[Token(Token = "0x40002E1")]
			[FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x40002E2")]
			[FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x600016E")]
			[Address(RVA = "0x7B7784", Offset = "0x7B7784", VA = "0x7B7784")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x7B7430", Offset = "0x7B7430", VA = "0x7B7430")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x7B750C", Offset = "0x7B750C", VA = "0x7B750C")]
		private void Update()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x7B775C", Offset = "0x7B775C", VA = "0x7B775C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x7B7774", Offset = "0x7B7774", VA = "0x7B7774")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000071")]
		public enum AxisOption
		{
			[Token(Token = "0x40002FB")]
			Both,
			[Token(Token = "0x40002FC")]
			OnlyHorizontal,
			[Token(Token = "0x40002FD")]
			OnlyVertical
		}

		[Token(Token = "0x2000072")]
		public enum ControlStyle
		{
			[Token(Token = "0x40002FF")]
			Absolute,
			[Token(Token = "0x4000300")]
			Relative,
			[Token(Token = "0x4000301")]
			Swipe
		}

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x7B778C", Offset = "0x7B778C", VA = "0x7B778C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x7B78F0", Offset = "0x7B78F0", VA = "0x7B78F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x7B7790", Offset = "0x7B7790", VA = "0x7B7790")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x7B7978", Offset = "0x7B7978", VA = "0x7B7978")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x7B7A78", Offset = "0x7B7A78", VA = "0x7B7A78", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x7B7AB0", Offset = "0x7B7AB0", VA = "0x7B7AB0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x7B7C88", Offset = "0x7B7C88", VA = "0x7B7C88", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x7B7CE8", Offset = "0x7B7CE8", VA = "0x7B7CE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x7B7DA8", Offset = "0x7B7DA8", VA = "0x7B7DA8")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x10")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000013")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x7B7E3C", Offset = "0x7B7E3C", VA = "0x7B7E3C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x7B7E48", Offset = "0x7B7E48", VA = "0x7B7E48")]
			private set
			{
			}
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x7B6158", Offset = "0x7B6158", VA = "0x7B6158")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x7B61B0", Offset = "0x7B61B0", VA = "0x7B61B0")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x7B63B0", Offset = "0x7B63B0", VA = "0x7B63B0")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x7B6600", Offset = "0x7B6600", VA = "0x7B6600")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x7B6690", Offset = "0x7B6690", VA = "0x7B6690")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x7B68EC", Offset = "0x7B68EC", VA = "0x7B68EC")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x7B6964", Offset = "0x7B6964", VA = "0x7B6964")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x7B69DC", Offset = "0x7B69DC", VA = "0x7B69DC")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000182")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000183")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000184")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000185")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000186")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000187")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000188")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x7B7E54", Offset = "0x7B7E54", VA = "0x7B7E54")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000074")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x7B7F7C", Offset = "0x7B7F7C", VA = "0x7B7F7C")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x7B8008", Offset = "0x7B8008", VA = "0x7B8008")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x7B8094", Offset = "0x7B8094", VA = "0x7B8094", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x7B812C", Offset = "0x7B812C", VA = "0x7B812C", Slot = "5")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x7B81C4", Offset = "0x7B81C4", VA = "0x7B81C4", Slot = "6")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x7B825C", Offset = "0x7B825C", VA = "0x7B825C", Slot = "7")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x7B82F8", Offset = "0x7B82F8", VA = "0x7B82F8", Slot = "8")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x7B8394", Offset = "0x7B8394", VA = "0x7B8394", Slot = "9")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x7B842C", Offset = "0x7B842C", VA = "0x7B842C", Slot = "10")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x7B84D0", Offset = "0x7B84D0", VA = "0x7B84D0")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x7B84D8", Offset = "0x7B84D8", VA = "0x7B84D8", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x7B84EC", Offset = "0x7B84EC", VA = "0x7B84EC", Slot = "5")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x7B853C", Offset = "0x7B853C", VA = "0x7B853C", Slot = "6")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x7B858C", Offset = "0x7B858C", VA = "0x7B858C", Slot = "7")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x7B85DC", Offset = "0x7B85DC", VA = "0x7B85DC", Slot = "8")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x7B862C", Offset = "0x7B862C", VA = "0x7B862C", Slot = "9")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x7B867C", Offset = "0x7B867C", VA = "0x7B867C", Slot = "10")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x7B86CC", Offset = "0x7B86CC", VA = "0x7B86CC")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Serializable]
	[Token(Token = "0x2000076")]
	public class MouseLook
	{
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x2C")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x7B86D4", Offset = "0x7B86D4", VA = "0x7B86D4")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x7B8724", Offset = "0x7B8724", VA = "0x7B8724")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x7B8A64", Offset = "0x7B8A64", VA = "0x7B8A64")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x7B8AC8", Offset = "0x7B8AC8", VA = "0x7B8AC8")]
		public MouseLook()
		{
		}
	}
}
namespace VEAGames.LAM
{
	[Token(Token = "0x2000077")]
	public class BatchUpdateJob
	{
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x10")]
		private readonly LAMBatchedFoliage m_Foliage;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x18")]
		private TerrainData m_TerrainData;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x20")]
		private Stopwatch m_Stopwatch;

		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x28")]
		private int m_PatchIndex;

		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x30")]
		private long m_Mask;

		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x38")]
		private int m_TypeIndex;

		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_TypeInProgress;

		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_Complete;

		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x40")]
		private int m_PlacesLeft;

		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x44")]
		private int m_XStart;

		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x48")]
		private int m_XEnd;

		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x4C")]
		private int m_YStart;

		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x50")]
		private int m_YEnd;

		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x54")]
		private int m_Stepx;

		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x58")]
		private int m_Stepy;

		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x5C")]
		private int m_XCell;

		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x60")]
		private int m_YCell;

		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x64")]
		private int m_PlacesToFill;

		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x68")]
		private Rect m_PatchRect;

		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x78")]
		private Matrix4x4 m_RotOffset;

		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject m_PatchRootObject;

		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0xC0")]
		private PatchType patchType;

		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0xC8")]
		private readonly MeshBuilder m_MeshBuilder;

		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0xD0")]
		private readonly PatchBuilder m_PatchBuilder;

		[Token(Token = "0x17000014")]
		public bool JobComplete
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x7B8F3C", Offset = "0x7B8F3C", VA = "0x7B8F3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x7B8AF4", Offset = "0x7B8AF4", VA = "0x7B8AF4")]
		public BatchUpdateJob(LAMBatchedFoliage foliage)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x7B8F44", Offset = "0x7B8F44", VA = "0x7B8F44")]
		public void Start(int patchIndex, long mask, PatchType type = PatchType.DynamicPatch)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x7B8F5C", Offset = "0x7B8F5C", VA = "0x7B8F5C")]
		public float Update(float maxMs)
		{
			return default(float);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x7B8FC0", Offset = "0x7B8FC0", VA = "0x7B8FC0")]
		private bool DoUpdate(float maxMs)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x7B9188", Offset = "0x7B9188", VA = "0x7B9188")]
		private void PrepareType(int typeIndex)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x7BA088", Offset = "0x7BA088", VA = "0x7BA088")]
		private void BuildSomeMeshes(float maxMs)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x7BC7E8", Offset = "0x7BC7E8", VA = "0x7BC7E8")]
		private GameObject InstantiatePrefab(Vector3 pos, Quaternion rotation, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x7BCDBC", Offset = "0x7BCDBC", VA = "0x7BCDBC")]
		public void CancelJob()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[ExecuteInEditMode]
	public class LAMBatchedFoliage : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000079")]
		public class FoliageType
		{
			[Token(Token = "0x4000340")]
			[FieldOffset(Offset = "0x10")]
			public LAMFoliageDefinition Definition;

			[Token(Token = "0x4000341")]
			[FieldOffset(Offset = "0x18")]
			private bool? _IsDefinitionCache;

			[Token(Token = "0x4000342")]
			[FieldOffset(Offset = "0x20")]
			public LAMBatchedFoliage_PatchesHolder PatchesHolder;

			[NonSerialized]
			[Token(Token = "0x4000343")]
			[FieldOffset(Offset = "0x28")]
			public bool ForceDisableShadows;

			[NonSerialized]
			[Token(Token = "0x4000344")]
			[FieldOffset(Offset = "0x2C")]
			public float DensityAdjustment;

			[NonSerialized]
			[Token(Token = "0x4000345")]
			[FieldOffset(Offset = "0x30")]
			public float OverrideCullDistance;

			[Token(Token = "0x17000015")]
			private bool IsDefinition
			{
				[Token(Token = "0x60001C6")]
				[Address(RVA = "0x7BF930", Offset = "0x7BF930", VA = "0x7BF930")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000016")]
			public string Name
			{
				[Token(Token = "0x60001C7")]
				[Address(RVA = "0x7BF4B4", Offset = "0x7BF4B4", VA = "0x7BF4B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000017")]
			public MeshFilter PatchPrefab
			{
				[Token(Token = "0x60001C8")]
				[Address(RVA = "0x7BBB40", Offset = "0x7BBB40", VA = "0x7BBB40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000018")]
			public GameObject InstancePrefab
			{
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0x7BC7B8", Offset = "0x7BC7B8", VA = "0x7BC7B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000019")]
			public float MinDistance
			{
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x7BB060", Offset = "0x7BB060", VA = "0x7BB060")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700001A")]
			public float RotateToNormal
			{
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0x7BBCA0", Offset = "0x7BBCA0", VA = "0x7BBCA0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700001B")]
			public bool RandomRotation
			{
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0x7BBCCC", Offset = "0x7BBCCC", VA = "0x7BBCCC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700001C")]
			public MinMax ScaleVariation
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0x7BBD04", Offset = "0x7BBD04", VA = "0x7BBD04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001D")]
			public Vector3 AdditionalRotation
			{
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0x7BB91C", Offset = "0x7BB91C", VA = "0x7BB91C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700001E")]
			public Vector3 AdditionalOffset
			{
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0x7BB8A4", Offset = "0x7BB8A4", VA = "0x7BB8A4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700001F")]
			public int MaxPerPatch
			{
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0x7BADD4", Offset = "0x7BADD4", VA = "0x7BADD4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000020")]
			public bool MergeGeometry
			{
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0x7BE14C", Offset = "0x7BE14C", VA = "0x7BE14C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000021")]
			public PatchType PatchType
			{
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x7B9158", Offset = "0x7B9158", VA = "0x7B9158")]
				get
				{
					return default(PatchType);
				}
			}

			[Token(Token = "0x17000022")]
			public bool UpdateAtRuntime
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x7BFA24", Offset = "0x7BFA24", VA = "0x7BFA24")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000023")]
			public bool RuntimeCulling
			{
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x7BFA5C", Offset = "0x7BFA5C", VA = "0x7BFA5C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000024")]
			public float ShadowCullDistance
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x7BFA94", Offset = "0x7BFA94", VA = "0x7BFA94")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000025")]
			public float CullDistance
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x7BFAC0", Offset = "0x7BFAC0", VA = "0x7BFAC0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000026")]
			public Mesh Mesh
			{
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x7BAE04", Offset = "0x7BAE04", VA = "0x7BAE04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x7BFB70", Offset = "0x7BFB70", VA = "0x7BFB70")]
			public FoliageType()
			{
			}
		}

		[Token(Token = "0x200007A")]
		private sealed class <UpdateTypesRoutine>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000346")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000347")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000348")]
			[FieldOffset(Offset = "0x20")]
			public LAMBatchedFoliage <>4__this;

			[Token(Token = "0x4000349")]
			[FieldOffset(Offset = "0x28")]
			public Rect uvRect;

			[Token(Token = "0x400034A")]
			[FieldOffset(Offset = "0x38")]
			public long typeMask;

			[Token(Token = "0x400034B")]
			[FieldOffset(Offset = "0x40")]
			public PatchType patchType;

			[Token(Token = "0x400034C")]
			[FieldOffset(Offset = "0x44")]
			private int <myVersion>5__2;

			[Token(Token = "0x400034D")]
			[FieldOffset(Offset = "0x48")]
			private int <xs>5__3;

			[Token(Token = "0x400034E")]
			[FieldOffset(Offset = "0x4C")]
			private int <ys>5__4;

			[Token(Token = "0x400034F")]
			[FieldOffset(Offset = "0x50")]
			private int <xe>5__5;

			[Token(Token = "0x4000350")]
			[FieldOffset(Offset = "0x54")]
			private int <ye>5__6;

			[Token(Token = "0x4000351")]
			[FieldOffset(Offset = "0x58")]
			private int <n>5__7;

			[Token(Token = "0x4000352")]
			[FieldOffset(Offset = "0x5C")]
			private int <ii>5__8;

			[Token(Token = "0x4000353")]
			[FieldOffset(Offset = "0x60")]
			private int <jj>5__9;

			[Token(Token = "0x17000027")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0x7BFF68", Offset = "0x7BFF68", VA = "0x7BFF68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000028")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x7BFF70", Offset = "0x7BFF70", VA = "0x7BFF70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x7BE124", Offset = "0x7BE124", VA = "0x7BE124")]
			[DebuggerHidden]
			public <UpdateTypesRoutine>d__35(int <>1__state)
			{
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x7BFB80", Offset = "0x7BFB80", VA = "0x7BFB80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x7BFB84", Offset = "0x7BFB84", VA = "0x7BFB84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200007B")]
		private sealed class <>c__DisplayClass49_0
		{
			[Token(Token = "0x4000354")]
			[FieldOffset(Offset = "0x10")]
			public LAMBatchedFoliage <>4__this;

			[Token(Token = "0x4000355")]
			[FieldOffset(Offset = "0x18")]
			public int index;

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x7BF754", Offset = "0x7BF754", VA = "0x7BF754")]
			public <>c__DisplayClass49_0()
			{
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x7BFF78", Offset = "0x7BFF78", VA = "0x7BFF78")]
			internal bool <Remove>b__0(FoliageType t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x18")]
		public int PatchesResolution;

		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x1C")]
		public int RandomSeed;

		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x20")]
		public float RuntimeFrameBudget;

		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x24")]
		public float GrassRebuildDistance;

		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x28")]
		public float RuntimeRebuildDistance;

		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x2C")]
		public float MeshScaleMultiplier;

		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x30")]
		public float RuntimeDensityMultiplier;

		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("Layers")]
		public FoliageType[] Types;

		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x40")]
		public LAMBatchedFoliage_TypeDataHolder DataHolder;

		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x48")]
		public int MaxDetailResolution;

		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x4C")]
		public float TerrainHeigth;

		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x50")]
		public float TerrainPatchesRatio;

		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x54")]
		public float PatchesMultiplier;

		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x58")]
		public float DefaultDetailResolution;

		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x5C")]
		public float DefaultPatchesResolution;

		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x60")]
		private LAMDetailsAutoPainter dap;

		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x68")]
		private Terrain m_Terrain;

		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x70")]
		private Camera m_Spectator;

		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x78")]
		private long[,] m_PatchesValidity;

		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x80")]
		private BatchUpdateJob m_Updater;

		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x88")]
		private GameObject m_GrassPatcher;

		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x90")]
		private int m_CurrentUpdateRoutineVersion;

		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x98")]
		private List<int> m_GrassListPatch;

		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0xA0")]
		private List<int> m_DynamicListPatch;

		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0xA8")]
		private bool isRebuild;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x7BCEBC", Offset = "0x7BCEBC", VA = "0x7BCEBC")]
		private GameObject GetPatchObject(int patchIndex, FoliageType type)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x7B9D30", Offset = "0x7B9D30", VA = "0x7B9D30")]
		public bool ClearPatch(int patchIndex, FoliageType type, bool alsoDestroyPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x7BCFC4", Offset = "0x7BCFC4", VA = "0x7BCFC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x7BD7F8", Offset = "0x7BD7F8", VA = "0x7BD7F8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x7BDB9C", Offset = "0x7BDB9C", VA = "0x7BDB9C")]
		public void CopyData(LAMBatchedFoliage_TypeDataHolder otherData)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x7BD2A4", Offset = "0x7BD2A4", VA = "0x7BD2A4")]
		private void RecreateDataArrays(bool fromValidate = false)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x7BD6C0", Offset = "0x7BD6C0", VA = "0x7BD6C0")]
		private void RecreatePatchesValidity(bool newResolution = false)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x7BDCA4", Offset = "0x7BDCA4", VA = "0x7BDCA4")]
		private void CheckUpdatesOverlap()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x7BDD68", Offset = "0x7BDD68", VA = "0x7BDD68")]
		public void UpdateTypesSync(long typeMask, Rect uvRect, PatchType type = PatchType.DynamicPatch)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x7BE070", Offset = "0x7BE070", VA = "0x7BE070")]
		public IEnumerator UpdateTypesRoutine(long typeMask, Rect uvRect, PatchType patchType = PatchType.DynamicPatch)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x7BB010", Offset = "0x7BB010", VA = "0x7BB010")]
		public Rect GetPatchRect(int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x7BB090", Offset = "0x7BB090", VA = "0x7BB090")]
		public GameObject ResetPatchObject(int patchIndex, int typeIndex)
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x7BE1EC", Offset = "0x7BE1EC", VA = "0x7BE1EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x7BE214", Offset = "0x7BE214", VA = "0x7BE214")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x7BEC5C", Offset = "0x7BEC5C", VA = "0x7BEC5C")]
		private bool TryBuildPatchCycle(int cx, int cy, ref float budget, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x7BEA94", Offset = "0x7BEA94", VA = "0x7BEA94")]
		private bool TryBuildPatchRuntime(int x, int y, ref float msLeft, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x7BE85C", Offset = "0x7BE85C", VA = "0x7BE85C")]
		private bool TryDestroyPatchCycle(int cx, int cy, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x7BEF2C", Offset = "0x7BEF2C", VA = "0x7BEF2C")]
		private bool TryDestroyListPatch(Rect buildRect, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x7BF0EC", Offset = "0x7BF0EC", VA = "0x7BF0EC")]
		private bool TryDestroyPatchRuntime(int patchIndex, Rect buildRect, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x7BB81C", Offset = "0x7BB81C", VA = "0x7BB81C")]
		public Vector3 UvToTerrain(Vector2 relativePos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x7BF2C8", Offset = "0x7BF2C8", VA = "0x7BF2C8")]
		public void SetTypeData(int x, int y, int typeIndex, bool value)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x7BF3A8", Offset = "0x7BF3A8", VA = "0x7BF3A8")]
		public void SetTypeDataRect(int xStart, int yStart, int detailIndex, int[,] data)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x7BAE34", Offset = "0x7BAE34", VA = "0x7BAE34")]
		public string GetTypeName(int index)
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x7BF520", Offset = "0x7BF520", VA = "0x7BF520")]
		public void Remove(int index)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x7BA018", Offset = "0x7BA018", VA = "0x7BA018")]
		public void MarkValidity(int patchIndex, int typeIndex, bool valid)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x7BF75C", Offset = "0x7BF75C", VA = "0x7BF75C")]
		public void ClearType(int typeIndex)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x7BDD58", Offset = "0x7BDD58", VA = "0x7BDD58")]
		public void CancelPendingRebuild()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x7BD804", Offset = "0x7BD804", VA = "0x7BD804")]
		public void RunDestroy(bool newResolution = false, bool destroyAll = false)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x7BF810", Offset = "0x7BF810", VA = "0x7BF810")]
		public LAMBatchedFoliage()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class LAMBatchedFoliage_FoliageHolder : MonoBehaviour
	{
		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x18")]
		public LAMBatchedFoliage_PatchesHolder PatchesHolder;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x7BFFBC", Offset = "0x7BFFBC", VA = "0x7BFFBC")]
		public LAMBatchedFoliage_FoliageHolder()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class LAMBatchedFoliage_PatchesHolder : MonoBehaviour
	{
		[Token(Token = "0x200007E")]
		private struct PatchCullData
		{
			[Token(Token = "0x4000362")]
			[FieldOffset(Offset = "0x0")]
			public MeshRenderer Renderer;
		}

		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x18")]
		public GameObject[] PatchObjects;

		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x20")]
		public bool MergeGeometry;

		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x28")]
		public GameObject FoliageHolder;

		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x30")]
		public List<PatchCulling> LAMPatches;

		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x38")]
		private PatchCullData[] m_PatchCull;

		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x40")]
		private CullingGroup m_Culling;

		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x48")]
		private LAMBatchedFoliage m_BatchedFoliage;

		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x50")]
		private int m_LayerIndex;

		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x54")]
		private int m_SpheresCount;

		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x58")]
		private bool m_Initialized;

		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x5C")]
		private ShadowCastingMode m_DefaultShadowMode;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x7BFFC4", Offset = "0x7BFFC4", VA = "0x7BFFC4")]
		private void Initialize(LAMBatchedFoliage foliage)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x7C02B8", Offset = "0x7C02B8", VA = "0x7C02B8")]
		private void SetupCullingGroup(float halfDistance, float maxDistance)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x7C0664", Offset = "0x7C0664", VA = "0x7C0664")]
		private void OnPatchCullingStateChanged(CullingGroupEvent evt)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x7C06AC", Offset = "0x7C06AC", VA = "0x7C06AC")]
		private void Cull(int objIndex, int distance)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x7C089C", Offset = "0x7C089C", VA = "0x7C089C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x7BE184", Offset = "0x7BE184", VA = "0x7BE184")]
		public void AddObject(int patchIndex, GameObject go)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x7BCBFC", Offset = "0x7BCBFC", VA = "0x7BCBFC")]
		public void AddLAMPatch(PatchCulling pc)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x7BCF6C", Offset = "0x7BCF6C", VA = "0x7BCF6C")]
		public void RemoveLAMPatch(PatchCulling pc)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x7BCCAC", Offset = "0x7BCCAC", VA = "0x7BCCAC")]
		public void PrepareCull(int patchIndex, LAMBatchedFoliage foliage)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x7C08D0", Offset = "0x7C08D0", VA = "0x7C08D0")]
		public void UpdateCullDistances(float halfDistance, float maxDistance)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x7C097C", Offset = "0x7C097C", VA = "0x7C097C")]
		public void DestroyPatches()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x7C0AA0", Offset = "0x7C0AA0", VA = "0x7C0AA0")]
		public LAMBatchedFoliage_PatchesHolder()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x7C0B28", Offset = "0x7C0B28", VA = "0x7C0B28")]
		private bool <Initialize>b__12_0(LAMBatchedFoliage.FoliageType l)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007F")]
	public class LAMBatchedFoliage_TypeDataHolder : ScriptableObject
	{
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x18")]
		public long[] Data;

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x7C0B94", Offset = "0x7C0B94", VA = "0x7C0B94")]
		public LAMBatchedFoliage_TypeDataHolder()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class LAMCopyTerrainMaterialProps : MonoBehaviour
	{
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x7C0B9C", Offset = "0x7C0B9C", VA = "0x7C0B9C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x7C0F7C", Offset = "0x7C0F7C", VA = "0x7C0F7C")]
		public LAMCopyTerrainMaterialProps()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[ExecuteInEditMode]
	public class LAMDetailsAutoPainter : MonoBehaviour
	{
		[Token(Token = "0x2000082")]
		public enum TextureChannelType
		{
			[Token(Token = "0x4000370")]
			Red,
			[Token(Token = "0x4000371")]
			Green,
			[Token(Token = "0x4000372")]
			Blue,
			[Token(Token = "0x4000373")]
			Alpha,
			[Token(Token = "0x4000374")]
			Black
		}

		[Serializable]
		[Token(Token = "0x2000083")]
		public class LayerDefinition
		{
			[Token(Token = "0x4000375")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x4000376")]
			[FieldOffset(Offset = "0x18")]
			public LAMMultiPaintLayer PaintLayer;

			[Token(Token = "0x4000377")]
			[FieldOffset(Offset = "0x20")]
			public float[] TextureLayerWeights;

			[Token(Token = "0x4000378")]
			[FieldOffset(Offset = "0x28")]
			public TrapezoidCurve SlopeCutoff;

			[Token(Token = "0x4000379")]
			[FieldOffset(Offset = "0x30")]
			public float Density;

			[Token(Token = "0x400037A")]
			[FieldOffset(Offset = "0x34")]
			public float RandomVariation;

			[Token(Token = "0x400037B")]
			[FieldOffset(Offset = "0x38")]
			public float MinWeight;

			[Token(Token = "0x400037C")]
			[FieldOffset(Offset = "0x40")]
			public Texture2D MaskTexture;

			[Token(Token = "0x400037D")]
			[FieldOffset(Offset = "0x48")]
			public float MaskTextureScale;

			[Token(Token = "0x400037E")]
			[FieldOffset(Offset = "0x4C")]
			public TextureChannelType MaskChannel;

			[Token(Token = "0x400037F")]
			[FieldOffset(Offset = "0x50")]
			public bool DodgeUpperLayers;

			[Token(Token = "0x4000380")]
			[FieldOffset(Offset = "0x51")]
			public bool SkipRepaint;

			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x7C2490", Offset = "0x7C2490", VA = "0x7C2490")]
			public LayerDefinition()
			{
			}
		}

		[Token(Token = "0x2000084")]
		private class TerrainSample
		{
			[Token(Token = "0x4000381")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 UV;

			[Token(Token = "0x4000382")]
			[FieldOffset(Offset = "0x18")]
			public float[] LayerWeights;

			[Token(Token = "0x4000383")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 Normal;

			[Token(Token = "0x4000384")]
			[FieldOffset(Offset = "0x2C")]
			public float Height;

			[Token(Token = "0x4000385")]
			[FieldOffset(Offset = "0x30")]
			public float SlopeAngle;

			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x7C2528", Offset = "0x7C2528", VA = "0x7C2528")]
			public TerrainSample()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000085")]
		private sealed class <>c
		{
			[Token(Token = "0x4000386")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000387")]
			[FieldOffset(Offset = "0x8")]
			public static Func<LayerDefinition, bool> <>9__18_0;

			[Token(Token = "0x4000388")]
			[FieldOffset(Offset = "0x10")]
			public static Func<LayerDefinition, LAMMultiPaintLayer> <>9__18_1;

			[Token(Token = "0x6000201")]
			[Address(RVA = "0x7C25A0", Offset = "0x7C25A0", VA = "0x7C25A0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000202")]
			[Address(RVA = "0x7C25A8", Offset = "0x7C25A8", VA = "0x7C25A8")]
			internal bool <Paint>b__18_0(LayerDefinition l)
			{
				return default(bool);
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x7C25C8", Offset = "0x7C25C8", VA = "0x7C25C8")]
			internal LAMMultiPaintLayer <Paint>b__18_1(LayerDefinition l)
			{
				return null;
			}
		}

		[Token(Token = "0x2000086")]
		private sealed class <Paint>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000389")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400038A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400038B")]
			[FieldOffset(Offset = "0x20")]
			public LAMDetailsAutoPainter <>4__this;

			[Token(Token = "0x400038C")]
			[FieldOffset(Offset = "0x28")]
			public Rect rect;

			[Token(Token = "0x400038D")]
			[FieldOffset(Offset = "0x38")]
			private TerrainData <td>5__2;

			[Token(Token = "0x400038E")]
			[FieldOffset(Offset = "0x40")]
			private int <xStart>5__3;

			[Token(Token = "0x400038F")]
			[FieldOffset(Offset = "0x44")]
			private int <yStart>5__4;

			[Token(Token = "0x4000390")]
			[FieldOffset(Offset = "0x48")]
			private int <w>5__5;

			[Token(Token = "0x4000391")]
			[FieldOffset(Offset = "0x4C")]
			private int <h>5__6;

			[Token(Token = "0x4000392")]
			[FieldOffset(Offset = "0x50")]
			private TerrainSample <sample>5__7;

			[Token(Token = "0x4000393")]
			[FieldOffset(Offset = "0x58")]
			private int <ii>5__8;

			[Token(Token = "0x4000394")]
			[FieldOffset(Offset = "0x5C")]
			private int <jj>5__9;

			[Token(Token = "0x17000029")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000207")]
				[Address(RVA = "0x7C3394", Offset = "0x7C3394", VA = "0x7C3394", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000208")]
				[Address(RVA = "0x7C339C", Offset = "0x7C339C", VA = "0x7C339C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0x7C1514", Offset = "0x7C1514", VA = "0x7C1514")]
			[DebuggerHidden]
			public <Paint>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x7C25E0", Offset = "0x7C25E0", VA = "0x7C25E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x7C25E4", Offset = "0x7C25E4", VA = "0x7C25E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000087")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000395")]
			[FieldOffset(Offset = "0x10")]
			public LayerDefinition layer;

			[Token(Token = "0x6000209")]
			[Address(RVA = "0x7C2474", Offset = "0x7C2474", VA = "0x7C2474")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x600020A")]
			[Address(RVA = "0x7C33A4", Offset = "0x7C33A4", VA = "0x7C33A4")]
			internal bool <ClearLayer>b__0(TreeInstance ti)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x18")]
		public int RandomSeed;

		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x1C")]
		public float SplatMaskScaleMultiplier;

		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x20")]
		public LayerDefinition[] Layers;

		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x28")]
		private LAMMultiPaintLayer[] m_PaintLayers;

		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x30")]
		public LAMDetailsAutoPainter_LayerDataHolder DataHolder;

		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x38")]
		public float GlobalDensityAdjust;

		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x40")]
		private Terrain m_Terrain;

		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x48")]
		private LAMTerrainTool m_TerrainTool;

		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x50")]
		private float[,,] m_AlphaMaps;

		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x58")]
		public LAMBatchedFoliage Batched;

		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x60")]
		private LatticeNoise m_Noise;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x7C0F84", Offset = "0x7C0F84", VA = "0x7C0F84")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x7C1068", Offset = "0x7C1068", VA = "0x7C1068")]
		public void UpdateMaps()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x7C1114", Offset = "0x7C1114", VA = "0x7C1114")]
		private void RecreateDataHolder()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x7C1374", Offset = "0x7C1374", VA = "0x7C1374")]
		public void CopyData(LAMDetailsAutoPainter_LayerDataHolder otherData)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x7C1478", Offset = "0x7C1478", VA = "0x7C1478")]
		public IEnumerator Paint(Rect rect)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x7C153C", Offset = "0x7C153C", VA = "0x7C153C")]
		private bool LayerIsValid(LayerDefinition layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x7C15F0", Offset = "0x7C15F0", VA = "0x7C15F0")]
		private int PaintSample(int layerIndex, int ii, int jj, TerrainSample sample, ref float sum)
		{
			return default(int);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x7C1984", Offset = "0x7C1984", VA = "0x7C1984")]
		private float GetChannel(Color color, TextureChannelType maskChannel)
		{
			return default(float);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x7C1AAC", Offset = "0x7C1AAC", VA = "0x7C1AAC")]
		private void SampleTerrainData(float x, float y, TerrainSample result)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x7C1EC8", Offset = "0x7C1EC8", VA = "0x7C1EC8")]
		private float SampleBilinear(int alphaIndex, Vector2 pos)
		{
			return default(float);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x7C1A28", Offset = "0x7C1A28", VA = "0x7C1A28")]
		private int ProbRound(float v, float rnd)
		{
			return default(int);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x7C2114", Offset = "0x7C2114", VA = "0x7C2114")]
		public void ClearLayer(int index)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x7C247C", Offset = "0x7C247C", VA = "0x7C247C")]
		public LAMDetailsAutoPainter()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class LAMDetailsAutoPainter_LayerDataHolder : ScriptableObject
	{
		[Token(Token = "0x4000396")]
		[FieldOffset(Offset = "0x18")]
		public byte[] Data;

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x7C33D4", Offset = "0x7C33D4", VA = "0x7C33D4")]
		public LAMDetailsAutoPainter_LayerDataHolder()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public sealed class LAMEditorSettings : ScriptableObject
	{
		[Token(Token = "0x4000397")]
		private const string GUID = "36ce4cc03e7f99943b402502e4164709";

		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x0")]
		private static LAMEditorSettings _Instance;

		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x18")]
		private bool _IsLoaded;

		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture2D _AutoLayerIcon;

		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture2D _MultiBrushIcon;

		[Token(Token = "0x1700002B")]
		public static LAMEditorSettings Instance
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x7C33F0", Offset = "0x7C33F0", VA = "0x7C33F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public static bool HasInstance
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x7C3478", Offset = "0x7C3478", VA = "0x7C3478")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002D")]
		public Texture2D AutoLayerIcon
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x7C3520", Offset = "0x7C3520", VA = "0x7C3520")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x7C3528", Offset = "0x7C3528", VA = "0x7C3528")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public Texture2D MultiBrushIcon
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x7C3530", Offset = "0x7C3530", VA = "0x7C3530")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x7C3538", Offset = "0x7C3538", VA = "0x7C3538")]
			set
			{
			}
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x7C33DC", Offset = "0x7C33DC", VA = "0x7C33DC")]
		private LAMEditorSettings()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x7C33E4", Offset = "0x7C33E4", VA = "0x7C33E4")]
		private void Awake()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class LAMFoliageDefinition : ScriptableObject
	{
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x18")]
		public MeshFilter PatchPrefab;

		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject InstancePrefab;

		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x28")]
		public float MinDistance;

		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x2C")]
		public float RotateToNormal;

		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x30")]
		public bool RandomRotation;

		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x38")]
		public MinMax ScaleVariation;

		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 AdditionalRotation;

		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 AdditionalOffset;

		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x58")]
		public int MaxPerPatch;

		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x5C")]
		public bool MergeGeometry;

		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x60")]
		public PatchType PatchType;

		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x64")]
		public bool UpdateAtRuntime;

		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x65")]
		public bool RuntimeCulling;

		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("HalfCullDistance")]
		public float ShadowCullDistance;

		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x6C")]
		public float CullDistance;

		[Token(Token = "0x1700002F")]
		public Mesh Mesh
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x7BFAEC", Offset = "0x7BFAEC", VA = "0x7BFAEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x7C3540", Offset = "0x7C3540", VA = "0x7C3540")]
		public LAMFoliageDefinition()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008B")]
	public class LAMMultiPaintLayer
	{
		[Token(Token = "0x200008C")]
		public enum LayerType
		{
			[Token(Token = "0x40003B2")]
			BuiltInDetail,
			[Token(Token = "0x40003B3")]
			BuiltInTree,
			[Token(Token = "0x40003B4")]
			BatchedFoliage
		}

		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x10")]
		public LayerType Type;

		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x14")]
		public int DetailIndex;

		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x18")]
		public Gradient TreeColorVariation;

		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x20")]
		public MinMax TreeScaleVariation;

		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x28")]
		public MinMax TreeHeightVariation;

		[NonSerialized]
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x30")]
		public int[,] Data;

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x7C310C", Offset = "0x7C310C", VA = "0x7C310C")]
		public static void ApplyLayers(LAMMultiPaintLayer[] layers, int xStart, int yStart, Terrain terrain, int treesSeed, out long batchedMask)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x7C3684", Offset = "0x7C3684", VA = "0x7C3684")]
		private static void SetDetailLayer(int xStart, int yStart, TerrainData td, LAMMultiPaintLayer layer)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x7C2FB0", Offset = "0x7C2FB0", VA = "0x7C2FB0")]
		public void InitData(int x, int y)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x7C30D0", Offset = "0x7C30D0", VA = "0x7C30D0")]
		public bool IsSameAs(LAMMultiPaintLayer other)
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x7C3EB4", Offset = "0x7C3EB4", VA = "0x7C3EB4")]
		public LAMMultiPaintLayer()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class LAMQualitySettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008E")]
		public class QualityLevelData
		{
			[Token(Token = "0x40003BC")]
			[FieldOffset(Offset = "0x10")]
			public int QualityLevel;

			[Token(Token = "0x40003BD")]
			[FieldOffset(Offset = "0x14")]
			public bool DisableGrassShadows;

			[Token(Token = "0x40003BE")]
			[FieldOffset(Offset = "0x18")]
			public float GrassDrawDistance;

			[Token(Token = "0x40003BF")]
			[FieldOffset(Offset = "0x1C")]
			public float GrassDensityMultiplier;

			[Token(Token = "0x40003C0")]
			[FieldOffset(Offset = "0x20")]
			public bool DisableTerrainTesselation;

			[Token(Token = "0x6000227")]
			[Address(RVA = "0x7C52D8", Offset = "0x7C52D8", VA = "0x7C52D8")]
			public QualityLevelData()
			{
			}
		}

		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0x18")]
		public QualityLevelData[] Levels;

		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x20")]
		private int <CurrentLevel>k__BackingField;

		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x24")]
		public LayerMask GrassLayers;

		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x0")]
		private static List<Material> m_GrassFadingMaterials;

		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x28")]
		public bool ShowGui;

		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x29")]
		private bool m_GuiVisible;

		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x30")]
		private float[] m_Times;

		[Token(Token = "0x17000030")]
		public int CurrentLevel
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x7C3F64", Offset = "0x7C3F64", VA = "0x7C3F64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x7C3F6C", Offset = "0x7C3F6C", VA = "0x7C3F6C")]
			private set
			{
			}
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x7C3F74", Offset = "0x7C3F74", VA = "0x7C3F74")]
		private void Start()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x7C3FC8", Offset = "0x7C3FC8", VA = "0x7C3FC8")]
		public int GetMatchingLevel(int unityQualityLevel)
		{
			return default(int);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x7C4604", Offset = "0x7C4604", VA = "0x7C4604")]
		public void SetLevel(int index)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x7C40BC", Offset = "0x7C40BC", VA = "0x7C40BC")]
		private void SetLevel(QualityLevelData levelData, bool force = false)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x7C465C", Offset = "0x7C465C", VA = "0x7C465C")]
		private void ApplyGrassSettings(LAMBatchedFoliage foliage, QualityLevelData levelData, bool force)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x7C4C20", Offset = "0x7C4C20", VA = "0x7C4C20")]
		private void Update()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x7C4C84", Offset = "0x7C4C84", VA = "0x7C4C84")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x7BE634", Offset = "0x7BE634", VA = "0x7BE634")]
		public static void RefreshGrassSettings(float GrassDrawDistance)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x7C51D4", Offset = "0x7C51D4", VA = "0x7C51D4")]
		public LAMQualitySettings()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[ExecuteInEditMode]
	public class LAMTerrainTool : MonoBehaviour
	{
		[Token(Token = "0x2000090")]
		public enum ShaderType
		{
			[Token(Token = "0x40003D0")]
			AdditiveWith3AutoLayers,
			[Token(Token = "0x40003D1")]
			DisplacementWith3Layers,
			[Token(Token = "0x40003D2")]
			DisplacementWith6Layers
		}

		[Token(Token = "0x2000091")]
		public class ShaderTypeMetaData
		{
			[Token(Token = "0x40003D3")]
			[FieldOffset(Offset = "0x10")]
			public string ShaderName;

			[Token(Token = "0x40003D4")]
			[FieldOffset(Offset = "0x18")]
			public string Description;

			[Token(Token = "0x40003D5")]
			[FieldOffset(Offset = "0x20")]
			public int MaxLayers;

			[Token(Token = "0x40003D6")]
			[FieldOffset(Offset = "0x24")]
			public bool HasAdditiveLayers;

			[Token(Token = "0x40003D7")]
			[FieldOffset(Offset = "0x25")]
			public bool HasTesselation;

			[Token(Token = "0x6000236")]
			[Address(RVA = "0x7C73A8", Offset = "0x7C73A8", VA = "0x7C73A8")]
			public ShaderTypeMetaData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000092")]
		public class LayerDefinition
		{
			[Token(Token = "0x40003D8")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x40003D9")]
			[FieldOffset(Offset = "0x18")]
			public Texture2D ColorTexture;

			[Token(Token = "0x40003DA")]
			[FieldOffset(Offset = "0x20")]
			public Texture2D NormalsTexture;

			[Token(Token = "0x40003DB")]
			[FieldOffset(Offset = "0x28")]
			public Texture2D SMOTexture;

			[Token(Token = "0x40003DC")]
			[FieldOffset(Offset = "0x30")]
			public float Scale;

			[Token(Token = "0x40003DD")]
			[FieldOffset(Offset = "0x34")]
			public float ScaleFar;

			[Token(Token = "0x40003DE")]
			[FieldOffset(Offset = "0x38")]
			public float ScaleMixStart;

			[Token(Token = "0x40003DF")]
			[FieldOffset(Offset = "0x3C")]
			public float ScaleMixEnd;

			[Token(Token = "0x40003E0")]
			[FieldOffset(Offset = "0x40")]
			public bool UseAuto;

			[Token(Token = "0x40003E1")]
			[FieldOffset(Offset = "0x48")]
			public TrapezoidCurve Angle;

			[Token(Token = "0x40003E2")]
			[FieldOffset(Offset = "0x50")]
			public TrapezoidCurve Height;

			[Token(Token = "0x40003E3")]
			[FieldOffset(Offset = "0x58")]
			public float TextureBleed;

			[Token(Token = "0x40003E4")]
			[FieldOffset(Offset = "0x5C")]
			public float DisplacementScale;

			[Token(Token = "0x40003E5")]
			[FieldOffset(Offset = "0x60")]
			public float Roughness;

			[Token(Token = "0x40003E6")]
			[FieldOffset(Offset = "0x64")]
			public Color Specular;

			[Token(Token = "0x40003E7")]
			[FieldOffset(Offset = "0x74")]
			public bool UseTriplanarProjection;

			[Token(Token = "0x40003E8")]
			[FieldOffset(Offset = "0x78")]
			[FormerlySerializedAs("NoiseAmount")]
			public float OverlayStrength;

			[Token(Token = "0x40003E9")]
			[FieldOffset(Offset = "0x7C")]
			[FormerlySerializedAs("NoiseScale")]
			public float OverlayScale;

			[Token(Token = "0x6000237")]
			[Address(RVA = "0x7C73B0", Offset = "0x7C73B0", VA = "0x7C73B0")]
			public LayerDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class TessData
		{
			[Token(Token = "0x40003EA")]
			[FieldOffset(Offset = "0x10")]
			public float RangeMin;

			[Token(Token = "0x40003EB")]
			[FieldOffset(Offset = "0x14")]
			public float RangeMax;

			[Token(Token = "0x40003EC")]
			[FieldOffset(Offset = "0x18")]
			public float Tesselation;

			[Token(Token = "0x40003ED")]
			[FieldOffset(Offset = "0x1C")]
			public float FalloffPower;

			[Token(Token = "0x40003EE")]
			[FieldOffset(Offset = "0x20")]
			public float GlobalScale;

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x7C70FC", Offset = "0x7C70FC", VA = "0x7C70FC")]
			public TessData()
			{
			}
		}

		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D IconAuto;

		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x20")]
		public ShaderType Shader;

		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x28")]
		public LayerDefinition[] Layers;

		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("Noise")]
		public Texture2D ColorOverlay;

		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("NoiseScaleMultiplier")]
		public float OverlayScaleMultiplier;

		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x40")]
		public TessData Displacement;

		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x48")]
		public Texture2D ColorPaintTexture;

		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x50")]
		public bool AutoDebugMode;

		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x54")]
		public float GlobalScale;

		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x58")]
		private Material m_MaterialInstance;

		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x60")]
		private Terrain m_Terrain;

		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x0")]
		private static Texture2D s_GrayTexture;

		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x68")]
		public SplatPrototype[] oldsp;

		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ShaderTypeMetaData[] MetaData;

		[Token(Token = "0x17000031")]
		private string CurrentShader
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x7C52E0", Offset = "0x7C52E0", VA = "0x7C52E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x7C5368", Offset = "0x7C5368", VA = "0x7C5368")]
		private void Start()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x7C59F4", Offset = "0x7C59F4", VA = "0x7C59F4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x7C53E8", Offset = "0x7C53E8", VA = "0x7C53E8")]
		private void EnsureInstance()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x7C5B54", Offset = "0x7C5B54", VA = "0x7C5B54")]
		public void EnsureLayerCount()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x7C605C", Offset = "0x7C605C", VA = "0x7C605C")]
		public bool SplatPrototypesEquals(SplatPrototype[] arrOne, SplatPrototype[] arrTwo)
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x7C5614", Offset = "0x7C5614", VA = "0x7C5614")]
		public void ApplyMaterialProperties()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x7C63B0", Offset = "0x7C63B0", VA = "0x7C63B0")]
		private void ApplyLayerDefinition(LayerDefinition layer, int index)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x7C6B8C", Offset = "0x7C6B8C", VA = "0x7C6B8C")]
		private void ClearLayerDefinition(int index, bool alsoTextures = true)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x7C20D8", Offset = "0x7C20D8", VA = "0x7C20D8")]
		public LayerDefinition GetLayer(int index)
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x7C0E20", Offset = "0x7C0E20", VA = "0x7C0E20")]
		public static Texture2D GetGrayTexture()
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x7C6EC8", Offset = "0x7C6EC8", VA = "0x7C6EC8")]
		public void SetGrassShaderPropertiesGlobal()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x7C7000", Offset = "0x7C7000", VA = "0x7C7000")]
		public LAMTerrainTool()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[ExecuteInEditMode]
	public class LAMWind : MonoBehaviour
	{
		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x18")]
		public float WindStrength;

		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x1C")]
		public float WaveStrength;

		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x20")]
		public float WaveFrequency;

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x7C7494", Offset = "0x7C7494", VA = "0x7C7494")]
		private void Update()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x7C755C", Offset = "0x7C755C", VA = "0x7C755C")]
		public LAMWind()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public struct LatticeNoise
	{
		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x0")]
		private readonly int m_Seed;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x7C7574", Offset = "0x7C7574", VA = "0x7C7574")]
		public LatticeNoise(int seed)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x7BBBCC", Offset = "0x7BBBCC", VA = "0x7BBBCC")]
		public float GetValue01(int x, int y)
		{
			return default(float);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x7BBC3C", Offset = "0x7BBC3C", VA = "0x7BBC3C")]
		public float GetValue(int x, int y)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000096")]
	public class MeshBuilder
	{
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Vector3> m_Vertices;

		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<Vector3> m_Normals;

		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<Vector4> m_Tangents;

		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<int> m_Indices;

		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<Vector2> m_UVs;

		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<Vector2> m_UV2s;

		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<Vector2> m_UV3s;

		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<Vector2> m_UV4s;

		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<Color> m_Colors;

		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x58")]
		private MeshTopology m_Topology;

		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x60")]
		private Mesh m_LastMesh;

		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x68")]
		private int m_InstanceIndex;

		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x70")]
		private Vector3[] m_LastVertices;

		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x78")]
		private Vector3[] m_LastNormals;

		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x80")]
		private Vector4[] m_LastTangents;

		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x88")]
		private int[] m_LastIndices;

		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x90")]
		private Vector2[] m_LastUVs;

		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x98")]
		private Vector2[] m_LastUV2s;

		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0xA0")]
		private Vector2[] m_LastUV3s;

		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0xA8")]
		private Vector2[] m_LastUV4s;

		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0xB0")]
		private Color[] m_LastColors;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x7C757C", Offset = "0x7C757C", VA = "0x7C757C")]
		public void Clear()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x7BBD94", Offset = "0x7BBD94", VA = "0x7BBD94")]
		public void AddMeshInstance(Matrix4x4 transform, Color colorModifier)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x7C76A0", Offset = "0x7C76A0", VA = "0x7C76A0")]
		private static bool HasData(Array array)
		{
			return default(bool);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x7BC918", Offset = "0x7BC918", VA = "0x7BC918")]
		public Mesh CreateMesh()
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x7BB994", Offset = "0x7BB994", VA = "0x7BB994")]
		public void Reset(Mesh mesh)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x7B8C44", Offset = "0x7B8C44", VA = "0x7B8C44")]
		public MeshBuilder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000097")]
	public class MinMax
	{
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x10")]
		public float Min;

		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x14")]
		public float Max;

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x7BBD80", Offset = "0x7BBD80", VA = "0x7BBD80")]
		public float Get(float t)
		{
			return default(float);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x7BFA1C", Offset = "0x7BFA1C", VA = "0x7BFA1C")]
		public MinMax()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class PatchBuilder
	{
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<MeshRenderer> m_Objects;

		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x18")]
		private Mesh m_LastMesh;

		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x20")]
		private Material[] m_LastMaterials;

		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_LastRoot;

		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x30")]
		private int m_InstanceIndex;

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x7C76C0", Offset = "0x7C76C0", VA = "0x7C76C0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x7BC570", Offset = "0x7BC570", VA = "0x7BC570")]
		public void AddPatchInstance(Vector3 patchPos, Quaternion patchRot, Vector3 patchScale)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x7BCBAC", Offset = "0x7BCBAC", VA = "0x7BCBAC")]
		public MeshRenderer[] CreatePatch()
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x7BBB70", Offset = "0x7BBB70", VA = "0x7BBB70")]
		public void Reset(Mesh mesh, Material[] mat, GameObject root)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x7B8EB4", Offset = "0x7B8EB4", VA = "0x7B8EB4")]
		public PatchBuilder()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[ExecuteInEditMode]
	public class SetLayerCullDistances : MonoBehaviour
	{
		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x18")]
		public bool ApplyToEditorCamera;

		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x20")]
		public float[] LayerDistances;

		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x28")]
		private Camera camera;

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x7C7734", Offset = "0x7C7734", VA = "0x7C7734")]
		private void Start()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x7C7814", Offset = "0x7C7814", VA = "0x7C7814")]
		public SetLayerCullDistances()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class TrapezoidCurve
	{
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x10")]
		public float From;

		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x14")]
		public float To;

		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x18")]
		public float Smoothing;

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x7C1944", Offset = "0x7C1944", VA = "0x7C1944")]
		public float GetValue(float x)
		{
			return default(float);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x7C2520", Offset = "0x7C2520", VA = "0x7C2520")]
		public TrapezoidCurve()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class TreePainter
	{
		[Token(Token = "0x200009C")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x400041A")]
			[FieldOffset(Offset = "0x10")]
			public int detailIndex;

			[Token(Token = "0x400041B")]
			[FieldOffset(Offset = "0x14")]
			public Rect uv;

			[Token(Token = "0x400041C")]
			[FieldOffset(Offset = "0x28")]
			public int[,] data;

			[Token(Token = "0x6000257")]
			[Address(RVA = "0x7C78A8", Offset = "0x7C78A8", VA = "0x7C78A8")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0x7C78B0", Offset = "0x7C78B0", VA = "0x7C78B0")]
			internal bool <SpawnTrees>b__0(TreeInstance ti)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x10")]
		private readonly Terrain m_Terrain;

		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<TreeInstance> m_Trees;

		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x20")]
		private MinMax <ScaleVariation>k__BackingField;

		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x28")]
		private MinMax <HeightVariation>k__BackingField;

		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x30")]
		private Gradient <ColorVariation>k__BackingField;

		[Token(Token = "0x17000032")]
		public MinMax ScaleVariation
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x7C7878", Offset = "0x7C7878", VA = "0x7C7878")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x7C7880", Offset = "0x7C7880", VA = "0x7C7880")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public MinMax HeightVariation
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x7C7888", Offset = "0x7C7888", VA = "0x7C7888")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x7C7890", Offset = "0x7C7890", VA = "0x7C7890")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public Gradient ColorVariation
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x7C7898", Offset = "0x7C7898", VA = "0x7C7898")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x7C78A0", Offset = "0x7C78A0", VA = "0x7C78A0")]
			set
			{
			}
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x7C35E0", Offset = "0x7C35E0", VA = "0x7C35E0")]
		public TreePainter(Terrain terrain)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x7C3800", Offset = "0x7C3800", VA = "0x7C3800")]
		public void SpawnTrees(int xStart, int yStart, int detailIndex, int[,] data, int seed)
		{
		}
	}
}
namespace VEAGames.LAM.Constants
{
	[Token(Token = "0x200009D")]
	public enum PatchType
	{
		[Token(Token = "0x400041E")]
		DynamicPatch,
		[Token(Token = "0x400041F")]
		GrassPatch,
		[Token(Token = "0x4000420")]
		StaticPatch,
		[Token(Token = "0x4000421")]
		All
	}
}
