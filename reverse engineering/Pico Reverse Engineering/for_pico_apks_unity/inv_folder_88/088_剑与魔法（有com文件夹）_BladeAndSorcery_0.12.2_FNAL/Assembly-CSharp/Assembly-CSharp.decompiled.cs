using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RainyReignGames.MeshDismemberment;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.VFX;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class GuiDemo : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject rootObject;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform boneToRip;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float threshold;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material sliceFill;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dismemberment ripper;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Button button;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Stopwatch timer;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Text timingText;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x12F6868", Offset = "0x12F6868", VA = "0x12F6868")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x12F6B78", Offset = "0x12F6B78", VA = "0x12F6B78")]
	private void CompletedSplitInfo(object sender, Dismemberment.CompletedEventArgs args)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x12F6D7C", Offset = "0x12F6D7C", VA = "0x12F6D7C")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x12F6DD8", Offset = "0x12F6DD8", VA = "0x12F6DD8")]
	public GuiDemo()
	{
	}
}
[Token(Token = "0x2000003")]
public class MeshDebug : MonoBehaviour
{
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool drawNormals;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool drawTangents;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int subMesh;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mesh _mesh;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Vector3> _vertices;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Vector3> _normals;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Vector4> _tangents;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private HashSet<int> trisToDraw;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x12F6DE0", Offset = "0x12F6DE0", VA = "0x12F6DE0")]
	private void ProcessMesh()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x12F72E4", Offset = "0x12F72E4", VA = "0x12F72E4")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x12F72E8", Offset = "0x12F72E8", VA = "0x12F72E8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x12F7684", Offset = "0x12F7684", VA = "0x12F7684")]
	public MeshDebug()
	{
	}
}
[Token(Token = "0x2000004")]
public class AudioDelay : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource audioSource;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip[] audioClipArray;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float timeBetweenShots;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float timer;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x12F7694", Offset = "0x12F7694", VA = "0x12F7694")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x12F76FC", Offset = "0x12F76FC", VA = "0x12F76FC")]
	private AudioClip RandomClip()
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x12F7740", Offset = "0x12F7740", VA = "0x12F7740")]
	public AudioDelay()
	{
	}
}
[Token(Token = "0x2000005")]
public class EggSplash : MonoBehaviour
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject particles;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource audio;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x12F7750", Offset = "0x12F7750", VA = "0x12F7750")]
	private void OnCollisionEnter()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x12F78A8", Offset = "0x12F78A8", VA = "0x12F78A8")]
	public EggSplash()
	{
	}
}
[Token(Token = "0x2000006")]
public class CollisionPoints : MonoBehaviour
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<ContactPoint> contactPoints;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Vector3> points;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maxTargetDistance;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x12F78B0", Offset = "0x12F78B0", VA = "0x12F78B0")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x12F7988", Offset = "0x12F7988", VA = "0x12F7988")]
	private void Update()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x12F7A44", Offset = "0x12F7A44", VA = "0x12F7A44")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x12F7AAC", Offset = "0x12F7AAC", VA = "0x12F7AAC")]
	public CollisionPoints()
	{
	}
}
[Token(Token = "0x2000007")]
public sealed class MeshFilterBaker : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MeshFilter _meshfilter;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RenderTexture _positionMap;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ComputeShader _compute;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private VisualEffect vfx;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Mesh _mesh;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Matrix4x4 _previousTransform;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int[] _dimensions;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<Vector3> _positionList;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<Vector3> _normalList;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private ComputeBuffer _positionBuffer1;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private ComputeBuffer _positionBuffer2;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private ComputeBuffer _normalBuffer;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private RenderTexture _tempPositionMap;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private RenderTexture _tempVelocityMap;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private RenderTexture _tempNormalMap;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Vector3 transPos;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private bool _warned;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x12F7B90", Offset = "0x12F7B90", VA = "0x12F7B90")]
	private void Start()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x12F7CB0", Offset = "0x12F7CB0", VA = "0x12F7CB0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x12F7F00", Offset = "0x12F7F00", VA = "0x12F7F00")]
	private void Update()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x12F8334", Offset = "0x12F8334", VA = "0x12F8334")]
	private void TransferData()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x12F81FC", Offset = "0x12F81FC", VA = "0x12F81FC")]
	private bool CheckConsistency()
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x12F7E78", Offset = "0x12F7E78", VA = "0x12F7E78")]
	private void TryDestroy(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x12F8AFC", Offset = "0x12F8AFC", VA = "0x12F8AFC")]
	private void SwapBuffer(ref ComputeBuffer b1, ref ComputeBuffer b2)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x12F8B34", Offset = "0x12F8B34", VA = "0x12F8B34")]
	private RenderTexture CreateRenderTexture(RenderTexture source)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x12F7DD4", Offset = "0x12F7DD4", VA = "0x12F7DD4")]
	private void TryDispose(IDisposable obj)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x12F8C08", Offset = "0x12F8C08", VA = "0x12F8C08")]
	public MeshFilterBaker()
	{
	}
}
[Token(Token = "0x2000008")]
[RequireComponent(typeof(ParticleSystem))]
public class particleAttractorLinear : MonoBehaviour
{
	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int numParticlesAlive;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x12F8D30", Offset = "0x12F8D30", VA = "0x12F8D30")]
	private void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x12F8E08", Offset = "0x12F8E08", VA = "0x12F8E08")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x12F8F98", Offset = "0x12F8F98", VA = "0x12F8F98")]
	public particleAttractorLinear()
	{
	}
}
[Token(Token = "0x2000009")]
[RequireComponent(typeof(ParticleSystem))]
public class particleAttractorMove : MonoBehaviour
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int numParticlesAlive;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x12F8FA8", Offset = "0x12F8FA8", VA = "0x12F8FA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x12F9080", Offset = "0x12F9080", VA = "0x12F9080")]
	private void Update()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x12F92E8", Offset = "0x12F92E8", VA = "0x12F92E8")]
	public particleAttractorMove()
	{
	}
}
[Token(Token = "0x200000A")]
[RequireComponent(typeof(ParticleSystem))]
public class particleAttractorSelf : MonoBehaviour
{
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int numParticlesAlive;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x12F92F8", Offset = "0x12F92F8", VA = "0x12F92F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x12F93D0", Offset = "0x12F93D0", VA = "0x12F93D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x12F957C", Offset = "0x12F957C", VA = "0x12F957C")]
	public particleAttractorSelf()
	{
	}
}
[Token(Token = "0x200000B")]
[RequireComponent(typeof(ParticleSystem))]
public class particleAttractorSpherical : MonoBehaviour
{
	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int numParticlesAlive;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x12F958C", Offset = "0x12F958C", VA = "0x12F958C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x12F9664", Offset = "0x12F9664", VA = "0x12F9664")]
	private void Update()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x12F97F4", Offset = "0x12F97F4", VA = "0x12F97F4")]
	public particleAttractorSpherical()
	{
	}
}
[Token(Token = "0x200000C")]
public class rotation : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float xRotation;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float yRotation;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float zRotation;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x12F9804", Offset = "0x12F9804", VA = "0x12F9804")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x12F985C", Offset = "0x12F985C", VA = "0x12F985C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x12F9864", Offset = "0x12F9864", VA = "0x12F9864")]
	public void clickOn()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x12F98BC", Offset = "0x12F98BC", VA = "0x12F98BC")]
	public void clickOff()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x12F98C4", Offset = "0x12F98C4", VA = "0x12F98C4")]
	private void rotate()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x12F9914", Offset = "0x12F9914", VA = "0x12F9914")]
	public rotation()
	{
	}
}
[Token(Token = "0x200000D")]
public class ItemSelector : MonoBehaviour
{
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int nbSubItem;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int deepness;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isSelected;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float degresPosition;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 targetPosition;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SpellWheelManager swm;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isGenerated;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool subMenuIsOpen;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x12F991C", Offset = "0x12F991C", VA = "0x12F991C")]
	private void Start()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x12F9994", Offset = "0x12F9994", VA = "0x12F9994")]
	private void OnMouseEnter()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x12F9A34", Offset = "0x12F9A34", VA = "0x12F9A34")]
	private void OnMouseExit()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x12F9AC0", Offset = "0x12F9AC0", VA = "0x12F9AC0")]
	private void OnMouseOver()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x12F9CE0", Offset = "0x12F9CE0", VA = "0x12F9CE0")]
	public void deploySubItems()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x12F9BBC", Offset = "0x12F9BBC", VA = "0x12F9BBC")]
	public void closeSubItems(bool closeRecursively)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x12FAD04", Offset = "0x12FAD04", VA = "0x12FAD04")]
	public ItemSelector()
	{
	}
}
[Token(Token = "0x200000E")]
public enum MenuAnimState
{
	[Token(Token = "0x400004B")]
	minimized,
	[Token(Token = "0x400004C")]
	maximized,
	[Token(Token = "0x400004D")]
	minizing,
	[Token(Token = "0x400004E")]
	maximizing
}
[Token(Token = "0x200000F")]
public class MenuAnimation : MonoBehaviour
{
	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MenuAnimState animmState;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float animSpeed;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform[] items;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3[] targetPositions;

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x12FAD18", Offset = "0x12FAD18", VA = "0x12FAD18")]
	private void Start()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x12FAD1C", Offset = "0x12FAD1C", VA = "0x12FAD1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x12FB3BC", Offset = "0x12FB3BC", VA = "0x12FB3BC")]
	public void minimize([Optional] Transform exepteThis)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x12FBF58", Offset = "0x12FBF58", VA = "0x12FBF58")]
	public void maximize()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x12FAD3C", Offset = "0x12FAD3C", VA = "0x12FAD3C")]
	public void minimizing()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x12FAFFC", Offset = "0x12FAFFC", VA = "0x12FAFFC")]
	public void maximizing()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x12FB590", Offset = "0x12FB590", VA = "0x12FB590")]
	private void getAllItems()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x12FB948", Offset = "0x12FB948", VA = "0x12FB948")]
	private void getOtherItems(Transform t)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x12FC084", Offset = "0x12FC084", VA = "0x12FC084")]
	private void getItemsTargetPositions()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x12FC31C", Offset = "0x12FC31C", VA = "0x12FC31C")]
	public MenuAnimation()
	{
	}
}
[Token(Token = "0x2000010")]
public class MenuSelector : MonoBehaviour
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isSelected;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color defaultColor;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color overColor;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Color SelectedColor;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UnityEvent onClick;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private SpellWheelManager swm;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x12FC32C", Offset = "0x12FC32C", VA = "0x12FC32C")]
	private void OnMouseEnter()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x12FC43C", Offset = "0x12FC43C", VA = "0x12FC43C")]
	private void OnMouseExit()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x12FC4C0", Offset = "0x12FC4C0", VA = "0x12FC4C0")]
	private void OnMouseOver()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x12FC594", Offset = "0x12FC594", VA = "0x12FC594")]
	public MenuSelector()
	{
	}
}
[Token(Token = "0x2000011")]
public class SpellMenuSelector : MonoBehaviour
{
	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SpellWheelManager swm;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x12FC59C", Offset = "0x12FC59C", VA = "0x12FC59C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x12FC64C", Offset = "0x12FC64C", VA = "0x12FC64C")]
	private void OnMouseOver()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x12FC734", Offset = "0x12FC734", VA = "0x12FC734")]
	private void deployMenu()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x12FC7D4", Offset = "0x12FC7D4", VA = "0x12FC7D4")]
	public SpellMenuSelector()
	{
	}
}
[Token(Token = "0x2000012")]
public class SpellWheelManager : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject utilButtonPrefab;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject itemPrefab;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float startAngle;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float angleRange;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int nbItems;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int nbUtilsItems;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int maxItems;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int minItems;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float minSize;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float maxSize;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float scaleFactor;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float scale;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float angleOffset;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float radius;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float radiusStart;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float radiusModifier;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float radiusFactor;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject debugCurrentCenter;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<GameObject> items;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<GameObject> utilsItems;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 itemPosition;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float radiant;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject spellsMenuButton;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public GameObject utilsMenuButton;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public GameObject selectedItem;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Transform currentCenter;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float subItemsSpacing;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float minSubItems;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float maxSubItems;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float minSizeSubItem;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float maxSizeSubItem;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public bool useUnifySubItemSysteme;

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x12FC7DC", Offset = "0x12FC7DC", VA = "0x12FC7DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x12FC7E0", Offset = "0x12FC7E0", VA = "0x12FC7E0")]
	public void initSpellWheel()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x12FD754", Offset = "0x12FD754", VA = "0x12FD754")]
	private void Update()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x12FCBA0", Offset = "0x12FCBA0", VA = "0x12FCBA0")]
	private void CreateSpellWheel(float yOffset, int nbWheelItems)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x12FD1F0", Offset = "0x12FD1F0", VA = "0x12FD1F0")]
	private void CreateUtilsWheel(Transform center, int nbWheelItems, float _startAngle)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x12FD81C", Offset = "0x12FD81C", VA = "0x12FD81C")]
	public void CreateSubItemWheel(Transform center, int nbWheelItems)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x12FD800", Offset = "0x12FD800", VA = "0x12FD800")]
	private float map(float value, float min1, float max1, float min2, float max2)
	{
		return default(float);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x12FA3EC", Offset = "0x12FA3EC", VA = "0x12FA3EC")]
	public void createSubItems(GameObject item, float nbSubItem, int deepness)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x12F9D78", Offset = "0x12F9D78", VA = "0x12F9D78")]
	public void closAllOtherSubItems(GameObject item)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x12FA85C", Offset = "0x12FA85C", VA = "0x12FA85C")]
	public void closeSubItems(GameObject item)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x12FA104", Offset = "0x12FA104", VA = "0x12FA104")]
	public void openSubItems(GameObject item)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x12FDC80", Offset = "0x12FDC80", VA = "0x12FDC80")]
	public void deployUtilsMenu()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x12FC74C", Offset = "0x12FC74C", VA = "0x12FC74C")]
	public void deploySpellsMenu()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x12FE1E4", Offset = "0x12FE1E4", VA = "0x12FE1E4")]
	public void deployWheelMenu(GameObject menu)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x12FD5FC", Offset = "0x12FD5FC", VA = "0x12FD5FC")]
	public void minimizeMenu(GameObject menu)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x12FE008", Offset = "0x12FE008", VA = "0x12FE008")]
	public void minimizeMenuAnimtion(GameObject menu)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x12FE064", Offset = "0x12FE064", VA = "0x12FE064")]
	public void maximizeMenu(GameObject menu)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x12FDD08", Offset = "0x12FDD08", VA = "0x12FDD08")]
	public void closeSubItemsOfMenu(GameObject menu)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x12FE8EC", Offset = "0x12FE8EC", VA = "0x12FE8EC")]
	public SpellWheelManager()
	{
	}
}
[Token(Token = "0x2000013")]
public static class SpellWheelUtils
{
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x12FA8E8", Offset = "0x12FA8E8", VA = "0x12FA8E8")]
	public static Transform[] getChildsOf(Transform t, bool deepSearch = false, bool includeInactive = false)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x12FDC44", Offset = "0x12FDC44", VA = "0x12FDC44")]
	public static Vector2 cartesianToPolar(float x, float y)
	{
		return default(Vector2);
	}
}
[Token(Token = "0x2000014")]
public class WheelItem : MonoBehaviour
{
	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isSelected;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float degresPosition;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 targetPosition;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SpellWheelManager swm;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool isMaximized;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x12FE9C0", Offset = "0x12FE9C0", VA = "0x12FE9C0")]
	private void Start()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x12FEA18", Offset = "0x12FEA18", VA = "0x12FEA18")]
	private void OnMouseEnter()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x12FEAB8", Offset = "0x12FEAB8", VA = "0x12FEAB8")]
	private void OnMouseExit()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x12FEB44", Offset = "0x12FEB44", VA = "0x12FEB44")]
	private void OnMouseOver()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x12FEB78", Offset = "0x12FEB78", VA = "0x12FEB78")]
	public void open()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x12FEBB8", Offset = "0x12FEBB8", VA = "0x12FEBB8")]
	public WheelItem()
	{
	}
}
[Token(Token = "0x2000015")]
[RequireComponent(typeof(ParticleSystem))]
public class ParticleAudio : MonoBehaviour
{
	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<ParticleCollisionEvent> collisionEvents;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem _particleSystem;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource audio1;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject audioPrefab;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x12FEBC0", Offset = "0x12FEBC0", VA = "0x12FEBC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x12FECE8", Offset = "0x12FECE8", VA = "0x12FECE8")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x12FEF4C", Offset = "0x12FEF4C", VA = "0x12FEF4C")]
	public ParticleAudio()
	{
	}
}
[Token(Token = "0x2000016")]
public class ReflectionProbeRenderTexture : MonoBehaviour
{
	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ReflectionProbe reflectionProbe;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RenderTexture targetTexture;

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x12FEFD4", Offset = "0x12FEFD4", VA = "0x12FEFD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x12FEFD8", Offset = "0x12FEFD8", VA = "0x12FEFD8")]
	[ContextMenu("AssignTexture")]
	public void AssignTexture()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x12FEFFC", Offset = "0x12FEFFC", VA = "0x12FEFFC")]
	public ReflectionProbeRenderTexture()
	{
	}
}
[Token(Token = "0x2000017")]
public class BloodPoolControl : MonoBehaviour
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer rend;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Initial Size")]
	public float size;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Sizing rate")]
	public float spreadRate;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Sizing decay rate (slow down)")]
	public float spreadDecay;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("Fade and Destory?")]
	public bool fadeAndDestory;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Fade rate")]
	public float fadeSpeed;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float fadeAmount;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float depth1;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float depth2;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float DepthFXAmount;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Depth FX fade rate to slow down ripple")]
	public float DepthFXFadeRate;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x12FF004", Offset = "0x12FF004", VA = "0x12FF004")]
	private void Start()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x12FF148", Offset = "0x12FF148", VA = "0x12FF148")]
	private void Update()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x12FF354", Offset = "0x12FF354", VA = "0x12FF354")]
	public BloodPoolControl()
	{
	}
}
[Token(Token = "0x2000018")]
public class WallDripper : MonoBehaviour
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer rend;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float bloodDryAmount;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("How fast does it dry?")]
	public float autoDrySpeed;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("How fast does it move?.")]
	public float dripSpeed;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("For these values, go to the material and alter the YOffset slider then copy your start and end values in here.")]
	public float yOffsetStartValue;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float yOffsetEndValue;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("Smaller amount, longer the fade, object parent destoryed when fully faded.")]
	public float fadeSpeed;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool makeBloodDry;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float speedArc;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float fadeAmount;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x12FF388", Offset = "0x12FF388", VA = "0x12FF388")]
	private void Start()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x12FF40C", Offset = "0x12FF40C", VA = "0x12FF40C")]
	private void Update()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x12FF670", Offset = "0x12FF670", VA = "0x12FF670")]
	public WallDripper()
	{
	}
}
[Token(Token = "0x2000019")]
public class MakeBloodDry : MonoBehaviour
{
	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer rend;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float bloodDryAmount;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool autoDry;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float autoDrySpeed;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool fadeAndDestory;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fadeSpeed;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float fadeAmount;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x12FF690", Offset = "0x12FF690", VA = "0x12FF690")]
	private void Start()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x12FF72C", Offset = "0x12FF72C", VA = "0x12FF72C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x12FF89C", Offset = "0x12FF89C", VA = "0x12FF89C")]
	public MakeBloodDry()
	{
	}
}
[Token(Token = "0x200001A")]
public class ME_DemoGUI : MonoBehaviour
{
	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Character;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Model;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int Current;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] Prefabs;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Light Sun;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ReflectionProbe ReflectionProbe;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Light[] NightLights;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture HUETexture;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool UseMobileVersion;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject MobileCharacter;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject Target;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Color guiColor;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int currentNomber;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject characterInstance;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject modelInstance;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GUIStyle guiStyleHeader;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GUIStyle guiStyleHeaderMobile;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float dpiScale;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool isDay;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float colorHUE;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float startSunIntensity;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Quaternion startSunRotation;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Color startAmbientLight;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float startAmbientIntencity;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float startReflectionIntencity;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private LightShadows startLightShadows;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private bool isButtonPressed;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private GameObject instanceShieldProjectile;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x12FF8C8", Offset = "0x12FF8C8", VA = "0x12FF8C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x12FFD58", Offset = "0x12FFD58", VA = "0x12FFD58")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x12FFA38", Offset = "0x12FFA38", VA = "0x12FFA38")]
	private void ChangeCurrent(int delta)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x13004EC", Offset = "0x13004EC", VA = "0x13004EC")]
	private void RemoveClones()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1300734", Offset = "0x1300734", VA = "0x1300734")]
	private void ReactivateEffect()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1300794", Offset = "0x1300794", VA = "0x1300794")]
	public ME_DemoGUI()
	{
	}
}
[Token(Token = "0x200001B")]
public class ME_MouseOrbit : MonoBehaviour
{
	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float distance;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float xSpeed;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float ySpeed;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float yMinLimit;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float yMaxLimit;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float x;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float y;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float prevDistance;

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1300878", Offset = "0x1300878", VA = "0x1300878")]
	private void Start()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x13008A4", Offset = "0x13008A4", VA = "0x13008A4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1300CFC", Offset = "0x1300CFC", VA = "0x1300CFC")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1300D38", Offset = "0x1300D38", VA = "0x1300D38")]
	public ME_MouseOrbit()
	{
	}
}
[Token(Token = "0x200001C")]
public class ME_RealtimeReflection : MonoBehaviour
{
	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ReflectionProbe probe;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform camT;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool CanUpdate;

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1300D54", Offset = "0x1300D54", VA = "0x1300D54")]
	private void Awake()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1300DD4", Offset = "0x1300DD4", VA = "0x1300DD4")]
	private void Update()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1300E60", Offset = "0x1300E60", VA = "0x1300E60")]
	public ME_RealtimeReflection()
	{
	}
}
[Token(Token = "0x200001D")]
public class ME_MobileBloom : MonoBehaviour
{
	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Camera render texture resolution")]
	[Range(0.2f, 1f)]
	public float RenderTextureResolutoinFactor;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0.05f, 2f)]
	[Tooltip("Blend factor of the result image.")]
	public float Intensity;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float Threshold;

	[Token(Token = "0x40000CC")]
	private const string shaderName = "Hidden/KriptoFX/PostEffects/ME_Bloom";

	[Token(Token = "0x40000CD")]
	private const int kMaxIterations = 16;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly RenderTexture[] m_blurBuffer1;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly RenderTexture[] m_blurBuffer2;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture Source;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material _bloomMaterial;

	[Token(Token = "0x17000001")]
	private Material bloomMaterial
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1300E70", Offset = "0x1300E70", VA = "0x1300E70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1300FB8", Offset = "0x1300FB8", VA = "0x1300FB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1300FBC", Offset = "0x1300FBC", VA = "0x1300FBC")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1301074", Offset = "0x1301074", VA = "0x1301074")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x130104C", Offset = "0x130104C", VA = "0x130104C")]
	private RenderTextureFormat SupportedHdrFormat()
	{
		return default(RenderTextureFormat);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x13010B8", Offset = "0x13010B8", VA = "0x13010B8")]
	private void UpdateBloom(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x13017F8", Offset = "0x13017F8", VA = "0x13017F8")]
	public ME_MobileBloom()
	{
	}
}
[Token(Token = "0x200001E")]
public class ME_AnimatorEvents : MonoBehaviour
{
	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject EffectPrefab;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject SwordPrefab;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform SwordPosition;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform StartSwordPosition;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject EffectInstance;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject SwordInstance;

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x13018D0", Offset = "0x13018D0", VA = "0x13018D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1301A5C", Offset = "0x1301A5C", VA = "0x1301A5C")]
	public void ActivateEffect()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1301C88", Offset = "0x1301C88", VA = "0x1301C88")]
	public void ActivateSword()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1301D4C", Offset = "0x1301D4C", VA = "0x1301D4C")]
	public void UpdateColor(float HUE)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1302244", Offset = "0x1302244", VA = "0x1302244")]
	public ME_AnimatorEvents()
	{
	}
}
[Token(Token = "0x200001F")]
public static class ME_ColorHelper
{
	[Token(Token = "0x2000020")]
	public struct HSBColor
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float H;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float S;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float B;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float A;

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x130224C", Offset = "0x130224C", VA = "0x130224C")]
		public HSBColor(float h, float s, float b, float a)
		{
		}
	}

	[Token(Token = "0x40000D8")]
	private const float TOLERANCE = 0.0001f;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string[] colorProperties;

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1301EA0", Offset = "0x1301EA0", VA = "0x1301EA0")]
	public static HSBColor ColorToHSV(Color color)
	{
		return default(HSBColor);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1302010", Offset = "0x1302010", VA = "0x1302010")]
	public static Color HSVToColor(HSBColor hsbColor)
	{
		return default(Color);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1302258", Offset = "0x1302258", VA = "0x1302258")]
	public static Color ConvertRGBColorByHUE(Color rgbColor, float hue)
	{
		return default(Color);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1302344", Offset = "0x1302344", VA = "0x1302344")]
	public static void ChangeObjectColorByHUE(GameObject go, float hue)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1302EEC", Offset = "0x1302EEC", VA = "0x1302EEC")]
	private static Material setMatHUEColor(Material mat, string name, float hueColor)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1302FB0", Offset = "0x1302FB0", VA = "0x1302FB0")]
	private static Material setMatAlphaColor(Material mat, string name, float alpha)
	{
		return null;
	}
}
[Token(Token = "0x2000021")]
public class ME_EffectSettingColor : MonoBehaviour
{
	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color Color;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Color previousColor;

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1303424", Offset = "0x1303424", VA = "0x1303424")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1303428", Offset = "0x1303428", VA = "0x1303428")]
	private void Update()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1303468", Offset = "0x1303468", VA = "0x1303468")]
	private void UpdateColor()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1303504", Offset = "0x1303504", VA = "0x1303504")]
	public ME_EffectSettingColor()
	{
	}
}
[Token(Token = "0x2000022")]
[ExecuteInEditMode]
public class ME_CustomLight : MonoBehaviour
{
	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int MaxLightsCount;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Texture2D PointLightAttenuation;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Light> sceneLights;

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1303518", Offset = "0x1303518", VA = "0x1303518")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x13038FC", Offset = "0x13038FC", VA = "0x13038FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1304A58", Offset = "0x1304A58", VA = "0x1304A58")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1303ADC", Offset = "0x1303ADC", VA = "0x1303ADC")]
	private List<Light> GetAllLights()
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1303D54", Offset = "0x1303D54", VA = "0x1303D54")]
	private int FillDirectionalLights(List<Light> lights, List<Vector4> lightPositions, List<Vector4> lightColors)
	{
		return default(int);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x13042F0", Offset = "0x13042F0", VA = "0x13042F0")]
	private int FillPointLights(List<Light> lights, List<Vector4> lightPositions, List<Vector4> lightColors)
	{
		return default(int);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x13036AC", Offset = "0x13036AC", VA = "0x13036AC")]
	private Vector4[] ListToArrayWithMaxCount(List<Vector4> list, int count)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1303FAC", Offset = "0x1303FAC", VA = "0x1303FAC")]
	private List<Light> SortPointLightsByDistance(List<Light> lights)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x130457C", Offset = "0x130457C", VA = "0x130457C")]
	public Color SampleLightProbesUp(Vector3 pos, float grayScaleFactor)
	{
		return default(Color);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x13037E8", Offset = "0x13037E8", VA = "0x13037E8")]
	private Texture2D GeneratePointAttenuationTexture()
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1304BD8", Offset = "0x1304BD8", VA = "0x1304BD8")]
	public ME_CustomLight()
	{
	}
}
[Token(Token = "0x2000023")]
public class ME_FixParticlesAligment : MonoBehaviour
{
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1304C2C", Offset = "0x1304C2C", VA = "0x1304C2C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1304CA8", Offset = "0x1304CA8", VA = "0x1304CA8")]
	public ME_FixParticlesAligment()
	{
	}
}
[Token(Token = "0x2000024")]
public class ME_LightCurves : MonoBehaviour
{
	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve LightCurve;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float GraphTimeMultiplier;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float GraphIntensityMultiplier;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool IsLoop;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool canUpdate;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float startTime;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Light lightSource;

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1304CB0", Offset = "0x1304CB0", VA = "0x1304CB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1304D34", Offset = "0x1304D34", VA = "0x1304D34")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1304D58", Offset = "0x1304D58", VA = "0x1304D58")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1304DE4", Offset = "0x1304DE4", VA = "0x1304DE4")]
	public ME_LightCurves()
	{
	}
}
[Token(Token = "0x2000025")]
public class ME_MeshMaterialEffect : MonoBehaviour
{
	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material Material;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool IsFirstMaterial;

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1304E2C", Offset = "0x1304E2C", VA = "0x1304E2C")]
	public ME_MeshMaterialEffect()
	{
	}
}
[Token(Token = "0x2000026")]
[ExecuteInEditMode]
public class ME_ParticleCollisionDecal : MonoBehaviour
{
	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem DecalParticles;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool IsBilboard;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool InstantiateWhenZeroSpeed;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float MaxGroundAngleDeviation;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float MinDistanceBetweenDecals;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float MinDistanceBetweenSurface;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<ParticleCollisionEvent> collisionEvents;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ParticleSystem initiatorPS;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<GameObject> collidedGameObjects;

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1304E34", Offset = "0x1304E34", VA = "0x1304E34")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1304F84", Offset = "0x1304F84", VA = "0x1304F84")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1304FE4", Offset = "0x1304FE4", VA = "0x1304FE4")]
	private void CollisionDetect()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1305148", Offset = "0x1305148", VA = "0x1305148")]
	private void OnParticleCollisionManual(GameObject other, int aliveParticles = -1)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1305690", Offset = "0x1305690", VA = "0x1305690")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1305798", Offset = "0x1305798", VA = "0x1305798")]
	public ME_ParticleCollisionDecal()
	{
	}
}
[Token(Token = "0x2000027")]
[ExecuteInEditMode]
public class ME_ParticleGravityPoint : MonoBehaviour
{
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Force;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool DistanceRelative;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem ps;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ParticleSystem.MainModule mainModule;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 prevPos;

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1305888", Offset = "0x1305888", VA = "0x1305888")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1305908", Offset = "0x1305908", VA = "0x1305908")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1305D2C", Offset = "0x1305D2C", VA = "0x1305D2C")]
	public ME_ParticleGravityPoint()
	{
	}
}
[Token(Token = "0x2000028")]
public class ME_ParticleTrails : MonoBehaviour
{
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject TrailPrefab;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem ps;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<uint, GameObject> hashTrails;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<uint, GameObject> newHashTrails;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<GameObject> currentGO;

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1305D3C", Offset = "0x1305D3C", VA = "0x1305D3C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1305E00", Offset = "0x1305E00", VA = "0x1305E00")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1305E54", Offset = "0x1305E54", VA = "0x1305E54")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1305EA8", Offset = "0x1305EA8", VA = "0x1305EA8")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1306040", Offset = "0x1306040", VA = "0x1306040")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1306044", Offset = "0x1306044", VA = "0x1306044")]
	private void UpdateTrail()
	{
	}

	[Token(Token = "0x60000B9")]
	public void AddRange<T, S>(Dictionary<T, S> source, Dictionary<T, S> collection)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1306858", Offset = "0x1306858", VA = "0x1306858")]
	private void ClearEmptyHashes()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1306AD8", Offset = "0x1306AD8", VA = "0x1306AD8")]
	public ME_ParticleTrails()
	{
	}
}
[Token(Token = "0x200002A")]
public class ME_Reflection : MonoBehaviour
{
	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RenderTexture tex;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ReflectionProbe reflectionProbe;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Light> dirLight;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<float> lightIntencity;

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1306D38", Offset = "0x1306D38", VA = "0x1306D38")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x13070C4", Offset = "0x13070C4", VA = "0x13070C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1307260", Offset = "0x1307260", VA = "0x1307260")]
	public ME_Reflection()
	{
	}
}
[Token(Token = "0x200002B")]
public class ME_TrailRendererNoise : MonoBehaviour
{
	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0.01f, 10f)]
	public float MinVertexDistance;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float VertexTime;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float TotalLifeTime;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool SmoothCurves;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool IsRibbon;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool IsActive;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0.001f, 10f)]
	public float Frequency;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(0.001f, 10f)]
	public float TimeScale;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(0.001f, 10f)]
	public float Amplitude;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float Gravity;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float TurbulenceStrength;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool AutodestructWhenNotActive;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform t;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 prevPos;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<Vector3> points;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<float> lifeTimes;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<Vector3> velocities;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float randomOffset;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<Vector3> controlPoints;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int curveCount;

	[Token(Token = "0x4000120")]
	private const float MinimumSqrDistance = 0.01f;

	[Token(Token = "0x4000121")]
	private const float DivisionThreshold = -0.99f;

	[Token(Token = "0x4000122")]
	private const float SmoothCurvesScale = 0.5f;

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1307268", Offset = "0x1307268", VA = "0x1307268")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1307400", Offset = "0x1307400", VA = "0x1307400")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1307484", Offset = "0x1307484", VA = "0x1307484")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x130758C", Offset = "0x130758C", VA = "0x130758C")]
	private void AddNewPoints()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x130781C", Offset = "0x130781C", VA = "0x130781C")]
	private void UpdatetPoints()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x13079E0", Offset = "0x13079E0", VA = "0x13079E0")]
	private void UpdateLineRendererBezier()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1307AAC", Offset = "0x1307AAC", VA = "0x1307AAC")]
	private void UpdateLineRenderer()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1307B44", Offset = "0x1307B44", VA = "0x1307B44")]
	private void CalculateTurbuelence(Vector3 position, float speed, float scale, float height, float gravity, int index)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1307CFC", Offset = "0x1307CFC", VA = "0x1307CFC")]
	public void InterpolateBezier(List<Vector3> segmentPoints, float scale)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x130834C", Offset = "0x130834C", VA = "0x130834C")]
	public List<Vector3> GetDrawingPoints()
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1308450", Offset = "0x1308450", VA = "0x1308450")]
	private List<Vector3> FindDrawingPoints(int curveIndex)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1308734", Offset = "0x1308734", VA = "0x1308734")]
	private int FindDrawingPoints(int curveIndex, float t0, float t1, List<Vector3> pointList, int insertionIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1308620", Offset = "0x1308620", VA = "0x1308620")]
	public Vector3 CalculateBezierPoint(int curveIndex, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1308A8C", Offset = "0x1308A8C", VA = "0x1308A8C")]
	private Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1308B20", Offset = "0x1308B20", VA = "0x1308B20")]
	public ME_TrailRendererNoise()
	{
	}
}
[Token(Token = "0x200002C")]
[ExecuteInEditMode]
public class PSMeshRendererUpdater : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	private class ParticleStartInfo
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ParticleSystem.MinMaxCurve StartSize;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ParticleSystem.MinMaxCurve StartSpeed;

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x130B820", Offset = "0x130B820", VA = "0x130B820")]
		public ParticleStartInfo()
		{
		}
	}

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject MeshObject;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float StartScaleMultiplier;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color Color;

	[Token(Token = "0x4000126")]
	private const string materialName = "MeshEffect";

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Material[]> rendererMaterials;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Material[]> skinnedMaterials;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool IsActive;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float FadeTime;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool currentActiveStatus;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool needUpdateAlpha;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Color oldColor;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float currentAlphaTime;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string[] colorProperties;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float alpha;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float prevAlpha;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Dictionary<string, float> startAlphaColors;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool previousActiveStatus;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool needUpdate;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
	private bool needLastUpdate;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Dictionary<ParticleSystem, ParticleStartInfo> startParticleParameters;

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1308CA0", Offset = "0x1308CA0", VA = "0x1308CA0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1308CB0", Offset = "0x1308CB0", VA = "0x1308CB0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1308E5C", Offset = "0x1308E5C", VA = "0x1308E5C")]
	private void InitStartAlphaColors()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1309E7C", Offset = "0x1309E7C", VA = "0x1309E7C")]
	private void InitStartParticleParameters()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x13094D0", Offset = "0x13094D0", VA = "0x13094D0")]
	private void UpdateVisibleStatus()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x130A054", Offset = "0x130A054", VA = "0x130A054")]
	private void UpdateAlphaByProperties(string rendName, int materialNumber, Material mat, float alpha)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1309CE0", Offset = "0x1309CE0", VA = "0x1309CE0")]
	private void GetStartAlphaByProperties(string rendName, int materialNumber, Material mat)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1309C08", Offset = "0x1309C08", VA = "0x1309C08")]
	public void UpdateColor(Color color)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1300438", Offset = "0x1300438", VA = "0x1300438")]
	public void UpdateColor(float HUE)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x130A1A0", Offset = "0x130A1A0", VA = "0x130A1A0")]
	public void UpdateMeshEffect()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x130AC8C", Offset = "0x130AC8C", VA = "0x130AC8C")]
	private void CheckScaleIncludedParticles()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x13005F0", Offset = "0x13005F0", VA = "0x13005F0")]
	public void UpdateMeshEffect(GameObject go)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x130A310", Offset = "0x130A310", VA = "0x130A310")]
	private void UpdatePSMesh(GameObject go)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x130AC90", Offset = "0x130AC90", VA = "0x130AC90")]
	private ParticleSystem.MinMaxCurve UpdateParticleParam(ParticleSystem.MinMaxCurve startParam, ParticleSystem.MinMaxCurve currentParam, float scale)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x130A9F4", Offset = "0x130A9F4", VA = "0x130A9F4")]
	private void AddMaterialToMesh(GameObject go)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x130AD40", Offset = "0x130AD40", VA = "0x130AD40")]
	private Material[] AddToSharedMaterial(Material[] sharedMaterials, ME_MeshMaterialEffect meshMatEffect)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x130AF6C", Offset = "0x130AF6C", VA = "0x130AF6C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x130B3B4", Offset = "0x130B3B4", VA = "0x130B3B4")]
	public PSMeshRendererUpdater()
	{
	}
}
[Token(Token = "0x200002E")]
public class ME_LegacyRenderDistortion : MonoBehaviour
{
	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool IsActive;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CommandBuffer buf;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Camera cam;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool bufferIsAdded;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x130B828", Offset = "0x130B828", VA = "0x130B828")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x130B888", Offset = "0x130B888", VA = "0x130B888")]
	private void CreateBuffer()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x130BADC", Offset = "0x130BADC", VA = "0x130BADC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x130BB14", Offset = "0x130BB14", VA = "0x130BB14")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x130BAE0", Offset = "0x130BAE0", VA = "0x130BAE0")]
	private void AddBuffer()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x130BB18", Offset = "0x130BB18", VA = "0x130BB18")]
	private void RemoveBuffer()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x130BB48", Offset = "0x130BB48", VA = "0x130BB48")]
	private void Update()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x130BB68", Offset = "0x130BB68", VA = "0x130BB68")]
	private bool IsSupportedHdr()
	{
		return default(bool);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x130BB88", Offset = "0x130BB88", VA = "0x130BB88")]
	public ME_LegacyRenderDistortion()
	{
	}
}
[Token(Token = "0x200002F")]
public class ME_PerPlatformSettings : MonoBehaviour
{
	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool DisableOnMobiles;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool RenderMobileDistortion;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0.1f, 1f)]
	public float ParticleBudgetForMobiles;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isMobile;

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x130BB98", Offset = "0x130BB98", VA = "0x130BB98")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x130BC08", Offset = "0x130BC08", VA = "0x130BC08")]
	private bool IsMobilePlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x130BC10", Offset = "0x130BC10", VA = "0x130BC10")]
	private void ChangeParticlesBudget(float particlesMul)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x130BFE4", Offset = "0x130BFE4", VA = "0x130BFE4")]
	public ME_PerPlatformSettings()
	{
	}
}
[Token(Token = "0x2000030")]
public class RFX4_AudioCurves : MonoBehaviour
{
	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve AudioCurve;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float GraphTimeMultiplier;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool IsLoop;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	private bool canUpdate;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float startTime;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource audioSource;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float startVolume;

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x130BFF4", Offset = "0x130BFF4", VA = "0x130BFF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x130C090", Offset = "0x130C090", VA = "0x130C090")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x130C0B4", Offset = "0x130C0B4", VA = "0x130C0B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x130C140", Offset = "0x130C140", VA = "0x130C140")]
	public RFX4_AudioCurves()
	{
	}
}
[Token(Token = "0x2000031")]
public class RFX4_LightCurves : MonoBehaviour
{
	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve LightCurve;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float GraphTimeMultiplier;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float GraphIntensityMultiplier;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool IsLoop;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool UseShadowsIfPossible;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	[HideInInspector]
	public bool canUpdate;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float startTime;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Light lightSource;

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x130C188", Offset = "0x130C188", VA = "0x130C188")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x130C20C", Offset = "0x130C20C", VA = "0x130C20C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x130C230", Offset = "0x130C230", VA = "0x130C230")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x130C2D4", Offset = "0x130C2D4", VA = "0x130C2D4")]
	public RFX4_LightCurves()
	{
	}
}
[Token(Token = "0x2000032")]
public class RFX4_PhysicsForceCurves : MonoBehaviour
{
	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float ForceRadius;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ForceMultiplier;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve ForceCurve;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ForceMode ForceMode;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float GraphTimeMultiplier;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float GraphIntensityMultiplier;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool IsLoop;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float DestoryDistance;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool UseDistanceScale;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve DistanceScaleCurve;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool UseUPVector;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve DragCurve;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float DragGraphTimeMultiplier;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float DragGraphIntensityMultiplier;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string AffectedName;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public float forceAdditionalMultiplier;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool canUpdate;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float startTime;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Transform t;

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x130C31C", Offset = "0x130C31C", VA = "0x130C31C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x130C340", Offset = "0x130C340", VA = "0x130C340")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x130C36C", Offset = "0x130C36C", VA = "0x130C36C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x130C94C", Offset = "0x130C94C", VA = "0x130C94C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x130C9A0", Offset = "0x130C9A0", VA = "0x130C9A0")]
	public RFX4_PhysicsForceCurves()
	{
	}
}
[Token(Token = "0x2000033")]
public class RFX4_ScaleCurves : MonoBehaviour
{
	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve FloatCurve;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float GraphTimeMultiplier;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float GraphIntensityMultiplier;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool IsLoop;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool canUpdate;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float startTime;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform t;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int nameId;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Projector proj;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 startScale;

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x130CA68", Offset = "0x130CA68", VA = "0x130CA68")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x130CB5C", Offset = "0x130CB5C", VA = "0x130CB5C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x130CBD0", Offset = "0x130CBD0", VA = "0x130CBD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x130CCDC", Offset = "0x130CCDC", VA = "0x130CCDC")]
	public RFX4_ScaleCurves()
	{
	}
}
[Token(Token = "0x2000034")]
public class RFX4_ShaderColorGradient : MonoBehaviour
{
	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RFX4_ShaderProperties ShaderColorProperty;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Gradient Color;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float TimeMultiplier;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool IsLoop;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public float HUE;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public bool canUpdate;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int propertyID;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float startTime;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Color startColor;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isInitialized;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string shaderProperty;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private MaterialPropertyBlock props;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Renderer rend;

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x130CD24", Offset = "0x130CD24", VA = "0x130CD24")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x130CEA0", Offset = "0x130CEA0", VA = "0x130CEA0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x130CF7C", Offset = "0x130CF7C", VA = "0x130CF7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x130D1E4", Offset = "0x130D1E4", VA = "0x130D1E4")]
	public RFX4_ShaderColorGradient()
	{
	}
}
[Token(Token = "0x2000035")]
public class RFX4_ShaderFloatCurve : MonoBehaviour
{
	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RFX4_ShaderProperties ShaderFloatProperty;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve FloatCurve;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float GraphTimeMultiplier;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float GraphIntensityMultiplier;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool IsLoop;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool canUpdate;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float startTime;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int propertyID;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string shaderProperty;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isInitialized;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MaterialPropertyBlock props;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Renderer rend;

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x130D268", Offset = "0x130D268", VA = "0x130D268")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x130D3B4", Offset = "0x130D3B4", VA = "0x130D3B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x130D430", Offset = "0x130D430", VA = "0x130D430")]
	private void Update()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x130D4E4", Offset = "0x130D4E4", VA = "0x130D4E4")]
	public RFX4_ShaderFloatCurve()
	{
	}
}
[Token(Token = "0x2000036")]
public enum RFX4_ShaderProperties
{
	[Token(Token = "0x4000187")]
	_TintColor,
	[Token(Token = "0x4000188")]
	_Cutoff,
	[Token(Token = "0x4000189")]
	_Color,
	[Token(Token = "0x400018A")]
	_EmissionColor,
	[Token(Token = "0x400018B")]
	_MaskPow,
	[Token(Token = "0x400018C")]
	_Cutout,
	[Token(Token = "0x400018D")]
	_Speed,
	[Token(Token = "0x400018E")]
	_BumpAmt,
	[Token(Token = "0x400018F")]
	_MainColor,
	[Token(Token = "0x4000190")]
	_Distortion,
	[Token(Token = "0x4000191")]
	_FresnelColor
}
[Token(Token = "0x2000037")]
public class RFX4_WindCurves : MonoBehaviour
{
	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve WindCurve;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float GraphTimeMultiplier;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float GraphIntensityMultiplier;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool IsLoop;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool canUpdate;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float startTime;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private WindZone windZone;

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x130D534", Offset = "0x130D534", VA = "0x130D534")]
	private void Awake()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x130D5E8", Offset = "0x130D5E8", VA = "0x130D5E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x130D60C", Offset = "0x130D60C", VA = "0x130D60C")]
	private void Update()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x130D698", Offset = "0x130D698", VA = "0x130D698")]
	public RFX4_WindCurves()
	{
	}
}
[Token(Token = "0x2000038")]
public class RFX4_EffectSettings : MonoBehaviour
{
	[Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class <Fadeout>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFX4_EffectSettings <>4__this;

		[Token(Token = "0x17000002")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x130F2BC", Offset = "0x130F2BC", VA = "0x130F2BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x130F304", Offset = "0x130F304", VA = "0x130F304", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x130EBFC", Offset = "0x130EBFC", VA = "0x130EBFC")]
		[DebuggerHidden]
		public <Fadeout>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x130F1CC", Offset = "0x130F1CC", VA = "0x130F1CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x130F1D0", Offset = "0x130F1D0", VA = "0x130F1D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x130F2C4", Offset = "0x130F2C4", VA = "0x130F2C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0.1f, 1f)]
	public float ParticlesBudget;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool UseLightShadows;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool UseFastFlatDecalsForMobiles;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool UseCustomColor;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color EffectColor;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool IsVisible;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float FadeoutTime;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool UseCollisionDetection;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool LimitMaxDistance;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float MaxDistnace;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float Mass;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float Speed;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float AirDrag;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool UseGravity;

	[Token(Token = "0x40001A7")]
	private const string distortionNamePC = "KriptoFX/RFX4/Distortion";

	[Token(Token = "0x40001A8")]
	private const string distortionNameMobile = "KriptoFX/RFX4/DistortionMobile";

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	private bool isCheckedDistortion;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	private bool prevIsVisible;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float currentFadeoutTime;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Renderer[] renderers;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Renderer[] skinRenderers;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Light[] lights;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ParticleSystem[] particleSystems;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private AudioSource[] audioSources;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string[] colorProperties;

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x130D6E0", Offset = "0x130D6E0", VA = "0x130D6E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x130D824", Offset = "0x130D824", VA = "0x130D824")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x130DE90", Offset = "0x130DE90", VA = "0x130DE90")]
	private void Update()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x130D890", Offset = "0x130D890", VA = "0x130D890")]
	private void ChangeParticlesBudget(float particlesMul)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x130DAF8", Offset = "0x130DAF8", VA = "0x130DAF8")]
	public void ChangeParticleColor()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x130DC98", Offset = "0x130DC98", VA = "0x130DC98")]
	public void SetFlatDecals()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x130DD20", Offset = "0x130DD20", VA = "0x130DD20")]
	public void DisableShadows()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x130DD18", Offset = "0x130DD18", VA = "0x130DD18")]
	private bool IsMobilePlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x130DEE0", Offset = "0x130DEE0", VA = "0x130DEE0")]
	[IteratorStateMachine(typeof(<Fadeout>d__32))]
	private IEnumerator Fadeout()
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x130EC24", Offset = "0x130EC24", VA = "0x130EC24")]
	private void UpdateAlphaByProperties(Material mat, float overrideAlpha = -1f)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x130ED08", Offset = "0x130ED08", VA = "0x130ED08")]
	private void ChangeAlphaFade()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x130D6EC", Offset = "0x130D6EC", VA = "0x130D6EC")]
	private void CacheRenderers()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x130DF54", Offset = "0x130DF54", VA = "0x130DF54")]
	private void Fadein()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x130F000", Offset = "0x130F000", VA = "0x130F000")]
	public RFX4_EffectSettings()
	{
	}
}
[Token(Token = "0x200003A")]
public class RFX4_CollisionPropertyDeactiavtion : MonoBehaviour
{
	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float DeactivateTimeDelay;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float startTime;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private WindZone windZone;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem ps;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ParticleSystem.CollisionModule collisionModule;

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x130F30C", Offset = "0x130F30C", VA = "0x130F30C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x130F38C", Offset = "0x130F38C", VA = "0x130F38C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x130F3B4", Offset = "0x130F3B4", VA = "0x130F3B4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x130F3F0", Offset = "0x130F3F0", VA = "0x130F3F0")]
	public RFX4_CollisionPropertyDeactiavtion()
	{
	}
}
[Token(Token = "0x200003B")]
public class RFX4_ParticleGravityDelay : MonoBehaviour
{
	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve GravityByTime;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float TimeMultiplier;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space]
	public float GravityMultiplierMin;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float GravityMultiplierMax;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ParticleSystem.MainModule main;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float startTime;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float startMinGrav;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float startMaxGrav;

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x130F400", Offset = "0x130F400", VA = "0x130F400")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x130F4CC", Offset = "0x130F4CC", VA = "0x130F4CC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x130F554", Offset = "0x130F554", VA = "0x130F554")]
	private void Update()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x130F61C", Offset = "0x130F61C", VA = "0x130F61C")]
	public RFX4_ParticleGravityDelay()
	{
	}
}
[Token(Token = "0x200003C")]
[RequireComponent(typeof(ParticleSystem))]
[ExecuteInEditMode]
public class RFX4_ParticleLight : MonoBehaviour
{
	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float LightIntencityMultiplayer;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool UseShadows;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int LightsLimit;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem ps;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Light[] lights;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isLocalSpace;

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x130F670", Offset = "0x130F670", VA = "0x130F670")]
	private void Start()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x130F9C0", Offset = "0x130F9C0", VA = "0x130F9C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x130FD80", Offset = "0x130FD80", VA = "0x130FD80")]
	public RFX4_ParticleLight()
	{
	}
}
[Token(Token = "0x200003D")]
[RequireComponent(typeof(ParticleSystem))]
public class RFX4_ParticleTrail : MonoBehaviour
{
	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Target;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 DefaultSizeMultiplayer;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float VertexLifeTime;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float TrailLifeTime;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool UseShaderMaterial;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material TrailMaterial;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool UseColorOverLifeTime;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Gradient ColorOverLifeTime;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFX4_ShaderProperties colorShaderProperty;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float ColorLifeTime;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool UseUvAnimation;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int TilesX;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int TilesY;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int FPS;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool IsLoop;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Range(0.001f, 1f)]
	public float MinVertexDistance;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool GetVelocityFromParticleSystem;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float Gravity;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3 Force;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float InheritVelocity;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float Drag;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[Range(0.001f, 10f)]
	public float Frequency;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[Range(0.001f, 10f)]
	public float OffsetSpeed;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool RandomTurbulenceOffset;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Range(0.001f, 10f)]
	public float Amplitude;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float TurbulenceStrength;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public AnimationCurve VelocityByDistance;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float AproximatedFlyDistance;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public bool SmoothCurves;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Dictionary<int, LineRenderer> dict;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private ParticleSystem ps;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private TrailRenderer[] trails;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Color psColor;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Transform targetT;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int layer;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private bool isLocalSpace;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Transform t;

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x130FD98", Offset = "0x130FD98", VA = "0x130FD98")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1310758", Offset = "0x1310758", VA = "0x1310758")]
	private void ClearTrails()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x130FFB4", Offset = "0x130FFB4", VA = "0x130FFB4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x1310978", Offset = "0x1310978", VA = "0x1310978")]
	private void InitTrailRenderer(GameObject go)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1310850", Offset = "0x1310850", VA = "0x1310850")]
	private void RemoveEmptyTrails()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1310A50", Offset = "0x1310A50", VA = "0x1310A50")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1310C50", Offset = "0x1310C50", VA = "0x1310C50")]
	public RFX4_ParticleTrail()
	{
	}
}
[Token(Token = "0x200003E")]
[ExecuteInEditMode]
[RequireComponent(typeof(ParticleSystem))]
public class RFX4_Turbulence : MonoBehaviour
{
	[Token(Token = "0x200003F")]
	public enum MoveMethodEnum
	{
		[Token(Token = "0x400020D")]
		Position,
		[Token(Token = "0x400020E")]
		Velocity,
		[Token(Token = "0x400020F")]
		RelativePosition
	}

	[Token(Token = "0x2000040")]
	public enum PerfomanceEnum
	{
		[Token(Token = "0x4000211")]
		High,
		[Token(Token = "0x4000212")]
		Low
	}

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float TurbulenceStrenght;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool TurbulenceByTime;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float TimeDelay;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve TurbulenceStrengthByTime;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 Frequency;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 OffsetSpeed;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 Amplitude;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 GlobalForce;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool UseGlobalOffset;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public MoveMethodEnum MoveMethod;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public PerfomanceEnum Perfomance;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float ThreshholdSpeed;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AnimationCurve VelocityByDistance;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float AproximatedFlyDistance;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float lastStopTime;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 currentOffset;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float deltaTime;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float deltaTimeLastUpdateOffset;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private ParticleSystem.Particle[] particleArray;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private ParticleSystem particleSys;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float time;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private int currentSplit;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float fpsTime;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private int FPS;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int splitUpdate;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private PerfomanceEnum perfomanceOldSettings;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool skipFrame;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Transform t;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float currentDelay;

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1310DF0", Offset = "0x1310DF0", VA = "0x1310DF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1310FA8", Offset = "0x1310FA8", VA = "0x1310FA8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1310FB0", Offset = "0x1310FB0", VA = "0x1310FB0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1310F58", Offset = "0x1310F58", VA = "0x1310F58")]
	private void UpdatePerfomanceSettings()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x13111BC", Offset = "0x13111BC", VA = "0x13111BC")]
	private void UpdateTurbulence()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1311898", Offset = "0x1311898", VA = "0x1311898")]
	public RFX4_Turbulence()
	{
	}
}
[Token(Token = "0x2000041")]
public class RFX4_MobileDistortion : MonoBehaviour
{
	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool IsActive;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CommandBuffer buf;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Camera cam;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool bufferIsAdded;

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1311948", Offset = "0x1311948", VA = "0x1311948")]
	private void Awake()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x13119A8", Offset = "0x13119A8", VA = "0x13119A8")]
	private void CreateBuffer()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1311BFC", Offset = "0x1311BFC", VA = "0x1311BFC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1311C34", Offset = "0x1311C34", VA = "0x1311C34")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x1311C00", Offset = "0x1311C00", VA = "0x1311C00")]
	private void AddBuffer()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1311C38", Offset = "0x1311C38", VA = "0x1311C38")]
	private void RemoveBuffer()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1311C68", Offset = "0x1311C68", VA = "0x1311C68")]
	private void Update()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x1311C88", Offset = "0x1311C88", VA = "0x1311C88")]
	private bool IsSupportedHdr()
	{
		return default(bool);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1311CA8", Offset = "0x1311CA8", VA = "0x1311CA8")]
	public RFX4_MobileDistortion()
	{
	}
}
[Token(Token = "0x2000042")]
public class RFX4_PerPlatformSettings : MonoBehaviour
{
	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool DisableOnMobiles;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool RenderMobileDistortion;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0.1f, 1f)]
	public float ParticleBudgetForMobiles;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isMobile;

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1311CB8", Offset = "0x1311CB8", VA = "0x1311CB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1311CBC", Offset = "0x1311CBC", VA = "0x1311CBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x13120F8", Offset = "0x13120F8", VA = "0x13120F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1312210", Offset = "0x1312210", VA = "0x1312210")]
	private void Update()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x131220C", Offset = "0x131220C", VA = "0x131220C")]
	private void LWRP_Rendering()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1312214", Offset = "0x1312214", VA = "0x1312214")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x1311D1C", Offset = "0x1311D1C", VA = "0x1311D1C")]
	private bool IsMobilePlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x1311D24", Offset = "0x1311D24", VA = "0x1311D24")]
	private void ChangeParticlesBudget(float particlesMul)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x1312318", Offset = "0x1312318", VA = "0x1312318")]
	public RFX4_PerPlatformSettings()
	{
	}
}
[Token(Token = "0x2000043")]
public class RFX4_CameraShake : MonoBehaviour
{
	[Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class <Shake>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFX4_CameraShake <>4__this;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsed>5__2;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform <camT>5__3;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 <originalCamRotation>5__4;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 <direction>5__5;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float <time>5__6;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <randomStart>5__7;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float <distanceDamper>5__8;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 <oldRotation>5__9;

		[Token(Token = "0x17000004")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1312B84", Offset = "0x1312B84", VA = "0x1312B84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1312BCC", Offset = "0x1312BCC", VA = "0x1312BCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1312504", Offset = "0x1312504", VA = "0x1312504")]
		[DebuggerHidden]
		public <Shake>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1312588", Offset = "0x1312588", VA = "0x1312588", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x131258C", Offset = "0x131258C", VA = "0x131258C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1312B8C", Offset = "0x1312B8C", VA = "0x1312B8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve ShakeCurve;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Duration;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float Speed;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float Magnitude;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float DistanceForce;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float RotationDamper;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool IsEnabled;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private bool isPlaying;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	[HideInInspector]
	public bool canUpdate;

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1312328", Offset = "0x1312328", VA = "0x1312328")]
	private void PlayShake()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x13123C8", Offset = "0x13123C8", VA = "0x13123C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x13123E4", Offset = "0x13123E4", VA = "0x13123E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x1312354", Offset = "0x1312354", VA = "0x1312354")]
	[IteratorStateMachine(typeof(<Shake>d__12))]
	private IEnumerator Shake()
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x131252C", Offset = "0x131252C", VA = "0x131252C")]
	public RFX4_CameraShake()
	{
	}
}
[Token(Token = "0x2000045")]
public static class RFX4_ColorHelper
{
	[Token(Token = "0x2000046")]
	public struct HSBColor
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float H;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float S;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float B;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float A;

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1312BD4", Offset = "0x1312BD4", VA = "0x1312BD4")]
		public HSBColor(float h, float s, float b, float a)
		{
		}
	}

	[Token(Token = "0x400022F")]
	private const float TOLERANCE = 0.0001f;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string[] colorProperties;

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x130E188", Offset = "0x130E188", VA = "0x130E188")]
	public static HSBColor ColorToHSV(Color color)
	{
		return default(HSBColor);
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1312BE0", Offset = "0x1312BE0", VA = "0x1312BE0")]
	public static Color HSVToColor(HSBColor hsbColor)
	{
		return default(Color);
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x130D0F8", Offset = "0x130D0F8", VA = "0x130D0F8")]
	public static Color ConvertRGBColorByHUE(Color rgbColor, float hue)
	{
		return default(Color);
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x130E2F8", Offset = "0x130E2F8", VA = "0x130E2F8")]
	public static void ChangeObjectColorByHUE(GameObject go, float hue)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1312E14", Offset = "0x1312E14", VA = "0x1312E14")]
	private static Material setMatHUEColor(Material mat, string name, float hueColor)
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1312ED8", Offset = "0x1312ED8", VA = "0x1312ED8")]
	private static Material setMatAlphaColor(Material mat, string name, float alpha)
	{
		return null;
	}
}
[Token(Token = "0x2000047")]
public class RFX4_CopyPosition : MonoBehaviour
{
	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform CopiedTransform;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform t;

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1313294", Offset = "0x1313294", VA = "0x1313294")]
	private void Start()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x13132B8", Offset = "0x13132B8", VA = "0x13132B8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x13132EC", Offset = "0x13132EC", VA = "0x13132EC")]
	public RFX4_CopyPosition()
	{
	}
}
[Token(Token = "0x2000048")]
[ExecuteInEditMode]
public class RFX4_CustomLight : MonoBehaviour
{
	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int MaxLightsCount;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Texture2D PointLightAttenuation;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Light> sceneLights;

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x13132F4", Offset = "0x13132F4", VA = "0x13132F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x13134DC", Offset = "0x13134DC", VA = "0x13134DC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1314774", Offset = "0x1314774", VA = "0x1314774")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x13136BC", Offset = "0x13136BC", VA = "0x13136BC")]
	private List<Light> GetAllLights()
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1313934", Offset = "0x1313934", VA = "0x1313934")]
	private int FillDirectionalLights(List<Light> lights, List<Vector4> lightPositions, List<Vector4> lightColors)
	{
		return default(int);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1313ED0", Offset = "0x1313ED0", VA = "0x1313ED0")]
	private int FillPointLights(List<Light> lights, List<Vector4> lightPositions, List<Vector4> lightColors)
	{
		return default(int);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x131415C", Offset = "0x131415C", VA = "0x131415C")]
	private Vector4[] ListToArrayWithMaxCount(List<Vector4> list, int count)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1313B8C", Offset = "0x1313B8C", VA = "0x1313B8C")]
	private List<Light> SortPointLightsByDistance(List<Light> lights)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1314298", Offset = "0x1314298", VA = "0x1314298")]
	public Color SampleLightProbesUp(Vector3 pos, float grayScaleFactor)
	{
		return default(Color);
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x13133C8", Offset = "0x13133C8", VA = "0x13133C8")]
	private Texture2D GeneratePointAttenuationTexture()
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x13148F4", Offset = "0x13148F4", VA = "0x13148F4")]
	public RFX4_CustomLight()
	{
	}
}
[Token(Token = "0x2000049")]
public class RFX4_DeactivateByTime : MonoBehaviour
{
	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject DeactivatedGameObject;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float DeactivateTime;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool isActiveState;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float currentTime;

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1314948", Offset = "0x1314948", VA = "0x1314948")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1314958", Offset = "0x1314958", VA = "0x1314958")]
	private void Update()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x13149BC", Offset = "0x13149BC", VA = "0x13149BC")]
	public RFX4_DeactivateByTime()
	{
	}
}
[Token(Token = "0x200004A")]
public class RFX4_DeactivateRigidbodyByTime : MonoBehaviour
{
	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float TimeDelayToDeactivate;

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x13149CC", Offset = "0x13149CC", VA = "0x13149CC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1314A64", Offset = "0x1314A64", VA = "0x1314A64")]
	private void Deactivate()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1314AD4", Offset = "0x1314AD4", VA = "0x1314AD4")]
	public RFX4_DeactivateRigidbodyByTime()
	{
	}
}
[Token(Token = "0x200004B")]
[ExecuteInEditMode]
public class RFX4_Decal : MonoBehaviour
{
	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool IsScreenSpace;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem ps;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem.MainModule psMain;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MaterialPropertyBlock props;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MeshRenderer rend;

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1314AE4", Offset = "0x1314AE4", VA = "0x1314AE4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1314D5C", Offset = "0x1314D5C", VA = "0x1314D5C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1314F44", Offset = "0x1314F44", VA = "0x1314F44")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1315108", Offset = "0x1315108", VA = "0x1315108")]
	public RFX4_Decal()
	{
	}
}
[Token(Token = "0x200004C")]
public class RFX4_DemoReactivation : MonoBehaviour
{
	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float ReactivationTime;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Effect;

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1315118", Offset = "0x1315118", VA = "0x1315118")]
	private void Start()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x131516C", Offset = "0x131516C", VA = "0x131516C")]
	private void Reactivate()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x13151A4", Offset = "0x13151A4", VA = "0x13151A4")]
	public RFX4_DemoReactivation()
	{
	}
}
[Token(Token = "0x200004D")]
public class RFX4_EffectEvent : MonoBehaviour
{
	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject CharacterEffect;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform CharacterAttachPoint;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float CharacterEffect_DestroyTime;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space]
	public GameObject CharacterEffect2;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform CharacterAttachPoint2;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float CharacterEffect2_DestroyTime;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Space]
	public GameObject MainEffect;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform AttachPoint;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float Effect_DestroyTime;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Space]
	public GameObject AdditionalEffect;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform AdditionalEffectAttachPoint;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float AdditionalEffect_DestroyTime;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[HideInInspector]
	public bool IsMobile;

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x13151B4", Offset = "0x13151B4", VA = "0x13151B4")]
	public void ActivateEffect()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x13153D4", Offset = "0x13153D4", VA = "0x13153D4")]
	public void ActivateAdditionalEffect()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x13155C0", Offset = "0x13155C0", VA = "0x13155C0")]
	public void ActivateCharacterEffect()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1315770", Offset = "0x1315770", VA = "0x1315770")]
	public void ActivateCharacterEffect2()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1315348", Offset = "0x1315348", VA = "0x1315348")]
	private void UpdateEffectForMobileIsNeed(GameObject instance)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x131590C", Offset = "0x131590C", VA = "0x131590C")]
	public RFX4_EffectEvent()
	{
	}
}
[Token(Token = "0x200004E")]
[ExecuteInEditMode]
[RequireComponent(typeof(Renderer))]
public class RFX4_MaterialQueue : MonoBehaviour
{
	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Background=1000, Geometry=2000, AlphaTest=2450, Transparent=3000, Overlay=4000")]
	public int queue;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int[] queues;

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1315928", Offset = "0x1315928", VA = "0x1315928")]
	private void Start()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1315AA8", Offset = "0x1315AA8", VA = "0x1315AA8")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1315AAC", Offset = "0x1315AAC", VA = "0x1315AAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1315AD4", Offset = "0x1315AD4", VA = "0x1315AD4")]
	public RFX4_MaterialQueue()
	{
	}
}
[Token(Token = "0x200004F")]
public class RFX4_OnEnableResetTransform : MonoBehaviour
{
	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform t;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 startPosition;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Quaternion startRotation;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 startScale;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isInitialized;

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1315AE4", Offset = "0x1315AE4", VA = "0x1315AE4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1315BC8", Offset = "0x1315BC8", VA = "0x1315BC8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1315CAC", Offset = "0x1315CAC", VA = "0x1315CAC")]
	public RFX4_OnEnableResetTransform()
	{
	}
}
[Token(Token = "0x2000050")]
public class RFX4_ParticleCollisionGameObject : MonoBehaviour
{
	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject InstancedGO;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float DestroyDelay;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject RotationParent;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<ParticleCollisionEvent> collisionEvents;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ParticleSystem initiatorPS;

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1315CB4", Offset = "0x1315CB4", VA = "0x1315CB4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1315D30", Offset = "0x1315D30", VA = "0x1315D30")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1315F88", Offset = "0x1315F88", VA = "0x1315F88")]
	public RFX4_ParticleCollisionGameObject()
	{
	}
}
[Token(Token = "0x2000051")]
[ExecuteInEditMode]
public class RFX4_ParticleGravityPoint : MonoBehaviour
{
	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Force;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float StopDistance;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem ps;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ParticleSystem.MainModule mainModule;

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1316018", Offset = "0x1316018", VA = "0x1316018")]
	private void Start()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1316098", Offset = "0x1316098", VA = "0x1316098")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x13164C4", Offset = "0x13164C4", VA = "0x13164C4")]
	public RFX4_ParticleGravityPoint()
	{
	}
}
[Token(Token = "0x2000052")]
public class RFX4_PhysicsMotion : MonoBehaviour
{
	[Token(Token = "0x2000053")]
	public class RFX4_CollisionInfo : EventArgs
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 HitPoint;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Collider HitCollider;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject HitGameObject;

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1317008", Offset = "0x1317008", VA = "0x1317008")]
		public RFX4_CollisionInfo()
		{
		}
	}

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool UseCollisionDetect;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float MaxDistnace;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Mass;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float Speed;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float RandomSpeedOffset;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float AirDrag;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool UseGravity;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ForceMode ForceMode;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 AddRealtimeForce;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float MinSpeed;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float ColliderRadius;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool FreezeRotation;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool UseTargetPositionAfterCollision;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject EffectOnCollision;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool CollisionEffectInWorldSpace;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool LookAtNormal;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float CollisionEffectDestroyAfter;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject[] DeactivateObjectsAfterCollision;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public float HUE;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Rigidbody rigid;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private SphereCollider collid;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private ContactPoint lastContactPoint;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Collider lastCollider;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Vector3 offsetColliderPoint;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private bool isCollided;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject targetAnchor;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool isInitializedForce;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private float currentSpeedOffset;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private RFX4_EffectSettings effectSettings;

	[Token(Token = "0x14000001")]
	public event EventHandler<RFX4_CollisionInfo> CollisionEnter
	{
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x13164D8", Offset = "0x13164D8", VA = "0x13164D8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1316588", Offset = "0x1316588", VA = "0x1316588")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1316638", Offset = "0x1316638", VA = "0x1316638")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x13167D4", Offset = "0x13167D4", VA = "0x13167D4")]
	private void InitializeRigid()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x131686C", Offset = "0x131686C", VA = "0x131686C")]
	private void InitializeForce()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x13169CC", Offset = "0x13169CC", VA = "0x13169CC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1317060", Offset = "0x1317060", VA = "0x1317060")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x131745C", Offset = "0x131745C", VA = "0x131745C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1317380", Offset = "0x1317380", VA = "0x1317380")]
	private void RemoveRigidbody()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x13174F8", Offset = "0x13174F8", VA = "0x13174F8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1317618", Offset = "0x1317618", VA = "0x1317618")]
	public RFX4_PhysicsMotion()
	{
	}
}
[Token(Token = "0x2000054")]
public class RFX4_PhysXSetImpulse : MonoBehaviour
{
	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Force;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public ForceMode ForceMode;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Rigidbody rig;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform t;

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x13176C8", Offset = "0x13176C8", VA = "0x13176C8")]
	private void Start()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x131773C", Offset = "0x131773C", VA = "0x131773C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x13177E8", Offset = "0x13177E8", VA = "0x13177E8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x13178A8", Offset = "0x13178A8", VA = "0x13178A8")]
	public RFX4_PhysXSetImpulse()
	{
	}
}
[Token(Token = "0x2000055")]
public class RFX4_RaycastCollision : MonoBehaviour
{
	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float RaycastDistance;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] Effects;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float Offset;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float EnableTimeDelay;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float DestroyTime;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool UsePivotPosition;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool UseNormalRotation;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	public bool IsWorldSpace;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
	public bool RealTimeUpdateRaycast;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool DestroyAfterDisabling;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public float HUE;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public List<GameObject> CollidedInstances;

	[Token(Token = "0x4000296")]
	private const string particlesAdditionalName = "Distance";

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ParticleSystem[] distanceParticles;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool canUpdate;

	[Token(Token = "0x14000002")]
	public event EventHandler<RFX4_PhysicsMotion.RFX4_CollisionInfo> CollisionEnter
	{
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x13178B8", Offset = "0x13178B8", VA = "0x13178B8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1317968", Offset = "0x1317968", VA = "0x1317968")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1317A18", Offset = "0x1317A18", VA = "0x1317A18")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1317A8C", Offset = "0x1317A8C", VA = "0x1317A8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x13183A4", Offset = "0x13183A4", VA = "0x13183A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x131850C", Offset = "0x131850C", VA = "0x131850C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1317B3C", Offset = "0x1317B3C", VA = "0x1317B3C")]
	private void UpdateRaycast()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x131851C", Offset = "0x131851C", VA = "0x131851C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x13185EC", Offset = "0x13185EC", VA = "0x13185EC")]
	public RFX4_RaycastCollision()
	{
	}
}
[Token(Token = "0x2000056")]
public class RFX4_ReplaceModelOnCollision : MonoBehaviour
{
	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject PhysicsObjects;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isCollided;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform t;

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1318694", Offset = "0x1318694", VA = "0x1318694")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x13187A8", Offset = "0x13187A8", VA = "0x13187A8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x13188A4", Offset = "0x13188A4", VA = "0x13188A4")]
	public RFX4_ReplaceModelOnCollision()
	{
	}
}
[Token(Token = "0x2000057")]
public class RFX4_RotateAround : MonoBehaviour
{
	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 Offset;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 RotateVector;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float LifeTime;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform t;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float currentTime;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Quaternion rotation;

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x13188AC", Offset = "0x13188AC", VA = "0x13188AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x13188FC", Offset = "0x13188FC", VA = "0x13188FC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x131898C", Offset = "0x131898C", VA = "0x131898C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1318A2C", Offset = "0x1318A2C", VA = "0x1318A2C")]
	public RFX4_RotateAround()
	{
	}
}
[Token(Token = "0x2000058")]
public class RFX4_StartDelay : MonoBehaviour
{
	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ActivatedGameObject;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Delay;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float currentTime;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isEnabled;

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1318AA4", Offset = "0x1318AA4", VA = "0x1318AA4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1318AD4", Offset = "0x1318AD4", VA = "0x1318AD4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1318B3C", Offset = "0x1318B3C", VA = "0x1318B3C")]
	public RFX4_StartDelay()
	{
	}
}
[Token(Token = "0x2000059")]
public enum RFX4_TextureShaderProperties
{
	[Token(Token = "0x40002A8")]
	_MainTex,
	[Token(Token = "0x40002A9")]
	_DistortTex,
	[Token(Token = "0x40002AA")]
	_Mask,
	[Token(Token = "0x40002AB")]
	_Cutout,
	[Token(Token = "0x40002AC")]
	_CutoutTex,
	[Token(Token = "0x40002AD")]
	_Bump,
	[Token(Token = "0x40002AE")]
	_BumpTex,
	[Token(Token = "0x40002AF")]
	_EmissionTex
}
[Token(Token = "0x200005A")]
public class RFX4_TornadoParticles : MonoBehaviour
{
	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material TornadoMaterial;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] particleArray;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem particleSys;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Light myLight;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector4 _twistScale;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int materialID;

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1318B4C", Offset = "0x1318B4C", VA = "0x1318B4C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1318D54", Offset = "0x1318D54", VA = "0x1318D54")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x1319024", Offset = "0x1319024", VA = "0x1319024")]
	public RFX4_TornadoParticles()
	{
	}
}
[Token(Token = "0x200005B")]
[RequireComponent(typeof(LineRenderer))]
public class RFX4_TrailRenderer : MonoBehaviour
{
	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float VertexLifeTime;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float TrailLifeTime;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0.001f, 1f)]
	public float MinVertexDistance;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float Gravity;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 Force;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float InheritVelocity;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float Drag;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Range(0.001f, 10f)]
	public float Frequency;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Range(0.001f, 10f)]
	public float OffsetSpeed;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool RandomTurbulenceOffset;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Range(0.001f, 10f)]
	public float Amplitude;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float TurbulenceStrength;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve VelocityByDistance;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float AproximatedFlyDistance;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool SmoothCurves;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<Vector3> positions;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<float> currentTimes;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<Vector3> velocities;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public float currentLifeTime;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform t;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 prevPosition;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 startPosition;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<Vector3> controlPoints;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int curveCount;

	[Token(Token = "0x40002CF")]
	private const float MinimumSqrDistance = 0.01f;

	[Token(Token = "0x40002D0")]
	private const float DivisionThreshold = -0.99f;

	[Token(Token = "0x40002D1")]
	private const float SmoothCurvesScale = 0.5f;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float currentVelocity;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float turbulenceRandomOffset;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool isInitialized;

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1319034", Offset = "0x1319034", VA = "0x1319034")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x13193C8", Offset = "0x13193C8", VA = "0x13193C8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1319050", Offset = "0x1319050", VA = "0x1319050")]
	private void Init()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x13193D8", Offset = "0x13193D8", VA = "0x13193D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x131A0AC", Offset = "0x131A0AC", VA = "0x131A0AC")]
	private int GetLastDeletedIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x131951C", Offset = "0x131951C", VA = "0x131951C")]
	private void UpdatePositionsCount()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x131AA28", Offset = "0x131AA28", VA = "0x131AA28")]
	private void AddInterpolatedPositions(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x131A1B8", Offset = "0x131A1B8", VA = "0x131A1B8")]
	private void RemovePositionsBeforeIndex(int lastDeletedIndex)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x1319704", Offset = "0x1319704", VA = "0x1319704")]
	private void UpdateForce()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x1319B80", Offset = "0x1319B80", VA = "0x1319B80")]
	private void UpdateImpulse()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1319E18", Offset = "0x1319E18", VA = "0x1319E18")]
	private void UpdateVelocity()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x131A2D4", Offset = "0x131A2D4", VA = "0x131A2D4")]
	public void InterpolateBezier(List<Vector3> segmentPoints, float scale)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x131A924", Offset = "0x131A924", VA = "0x131A924")]
	public List<Vector3> GetDrawingPoints()
	{
		return null;
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x131AD5C", Offset = "0x131AD5C", VA = "0x131AD5C")]
	private List<Vector3> FindDrawingPoints(int curveIndex)
	{
		return null;
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x131B040", Offset = "0x131B040", VA = "0x131B040")]
	private int FindDrawingPoints(int curveIndex, float t0, float t1, List<Vector3> pointList, int insertionIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x131AF2C", Offset = "0x131AF2C", VA = "0x131AF2C")]
	public Vector3 CalculateBezierPoint(int curveIndex, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x131B398", Offset = "0x131B398", VA = "0x131B398")]
	private Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x131B42C", Offset = "0x131B42C", VA = "0x131B42C")]
	public RFX4_TrailRenderer()
	{
	}
}
[Token(Token = "0x200005C")]
[ExecuteInEditMode]
public class RFX4_UVAnimation : MonoBehaviour
{
	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int TilesX;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int TilesY;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(1f, 360f)]
	public int FPS;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int StartFrameOffset;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool IsLoop;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool IsReverse;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool IsInterpolateFrames;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFX4_TextureShaderProperties[] TextureNames;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int count;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Renderer currentRenderer;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Projector projector;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material instanceMaterial;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float animationStartTime;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool canUpdate;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int previousIndex;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int totalFrames;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float currentInterpolatedTime;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int currentIndex;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector2 size;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isInitialized;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float prevRealTime;

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x131B51C", Offset = "0x131B51C", VA = "0x131B51C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x131B758", Offset = "0x131B758", VA = "0x131B758")]
	private void Start()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x131B774", Offset = "0x131B774", VA = "0x131B774")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x131B7D4", Offset = "0x131B7D4", VA = "0x131B7D4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x131B52C", Offset = "0x131B52C", VA = "0x131B52C")]
	private void InitDefaultVariables()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x131B79C", Offset = "0x131B79C", VA = "0x131B79C")]
	private void ManualUpdate()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x131B7FC", Offset = "0x131B7FC", VA = "0x131B7FC")]
	private void UpdateMaterial()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x131B8FC", Offset = "0x131B8FC", VA = "0x131B8FC")]
	private void SetSpriteAnimation()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x131BC94", Offset = "0x131BC94", VA = "0x131BC94")]
	public float DeltaTime()
	{
		return default(float);
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x131BB24", Offset = "0x131BB24", VA = "0x131BB24")]
	private void SetSpriteAnimationIterpolated()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x131BCEC", Offset = "0x131BCEC", VA = "0x131BCEC")]
	public RFX4_UVAnimation()
	{
	}
}
[Token(Token = "0x200005D")]
public class RFX4_UVScroll : MonoBehaviour
{
	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2 UvScrollMultiplier;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFX4_TextureShaderProperties TextureName;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector2 uvOffset;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material mat;

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x131BD6C", Offset = "0x131BD6C", VA = "0x131BD6C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x131BF6C", Offset = "0x131BF6C", VA = "0x131BF6C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x131C054", Offset = "0x131C054", VA = "0x131C054")]
	public RFX4_UVScroll()
	{
	}
}
[Token(Token = "0x200005E")]
public class RFX4_MobileBloom : MonoBehaviour
{
	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Camera render texture resolution")]
	[Range(0.2f, 1f)]
	public float RenderTextureResolutoinFactor;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0.05f, 2f)]
	[Tooltip("Blend factor of the result image.")]
	public float Intensity;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float Threshold;

	[Token(Token = "0x40002F1")]
	private const string shaderName = "Hidden/KriptoFX/PostEffects/RFX4_Bloom";

	[Token(Token = "0x40002F2")]
	private const int kMaxIterations = 16;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly RenderTexture[] m_blurBuffer1;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly RenderTexture[] m_blurBuffer2;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture Source;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material _bloomMaterial;

	[Token(Token = "0x17000006")]
	private Material bloomMaterial
	{
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x131C0B8", Offset = "0x131C0B8", VA = "0x131C0B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x131C200", Offset = "0x131C200", VA = "0x131C200")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x131C204", Offset = "0x131C204", VA = "0x131C204")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x131C2BC", Offset = "0x131C2BC", VA = "0x131C2BC")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x131C294", Offset = "0x131C294", VA = "0x131C294")]
	private RenderTextureFormat SupportedHdrFormat()
	{
		return default(RenderTextureFormat);
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x131C300", Offset = "0x131C300", VA = "0x131C300")]
	private void UpdateBloom(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x131CA40", Offset = "0x131CA40", VA = "0x131CA40")]
	public RFX4_MobileBloom()
	{
	}
}
[Token(Token = "0x200005F")]
public class FPS : MonoBehaviour
{
	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float UpdateInterval;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text text;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int frames;

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x131CB18", Offset = "0x131CB18", VA = "0x131CB18")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x131CBB0", Offset = "0x131CBB0", VA = "0x131CBB0")]
	private void UpdateFPS()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x131CCD4", Offset = "0x131CCD4", VA = "0x131CCD4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x131CCE4", Offset = "0x131CCE4", VA = "0x131CCE4")]
	public FPS()
	{
	}
}
[Token(Token = "0x2000060")]
public class RFX4_Debug : MonoBehaviour
{
	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x131CCF4", Offset = "0x131CCF4", VA = "0x131CCF4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x131CE88", Offset = "0x131CE88", VA = "0x131CE88")]
	private void CollisionEnter(object sender, RFX4_PhysicsMotion.RFX4_CollisionInfo e)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x131CF5C", Offset = "0x131CF5C", VA = "0x131CF5C")]
	public RFX4_Debug()
	{
	}
}
[Token(Token = "0x2000061")]
public class RFX4_DemoGUI : MonoBehaviour
{
	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] Prefabs;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float[] ReactivationTimes;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Light Sun;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ReflectionProbe ReflectionProbe;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Light[] NightLights;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture HUETexture;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isDay;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int currentNomber;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject currentInstance;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GUIStyle guiStyleHeader;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GUIStyle guiStyleHeaderMobile;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float dpiScale;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float colorHUE;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float startSunIntensity;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Quaternion startSunRotation;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Color startAmbientLight;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float startAmbientIntencity;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float startReflectionIntencity;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private LightShadows startLightShadows;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool isButtonPressed;

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x131CF64", Offset = "0x131CF64", VA = "0x131CF64")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x131D4CC", Offset = "0x131D4CC", VA = "0x131D4CC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x131D280", Offset = "0x131D280", VA = "0x131D280")]
	private void ChangeDayNight()
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x131D0B8", Offset = "0x131D0B8", VA = "0x131D0B8")]
	private void ChangeCurrent(int delta)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x131D87C", Offset = "0x131D87C", VA = "0x131D87C")]
	private void RemoveClones()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x131D980", Offset = "0x131D980", VA = "0x131D980")]
	private void Reactivate()
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x131D9B8", Offset = "0x131D9B8", VA = "0x131D9B8")]
	public RFX4_DemoGUI()
	{
	}
}
[Token(Token = "0x2000062")]
public class RFX4_FPS : MonoBehaviour
{
	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly GUIStyle guiStyleHeader;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float timeleft;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float fps;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int frames;

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x131DA8C", Offset = "0x131DA8C", VA = "0x131DA8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x131DADC", Offset = "0x131DADC", VA = "0x131DADC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x131DBD4", Offset = "0x131DBD4", VA = "0x131DBD4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x131DC28", Offset = "0x131DC28", VA = "0x131DC28")]
	public RFX4_FPS()
	{
	}
}
[Token(Token = "0x2000063")]
public class RFX4_MouseOrbit : MonoBehaviour
{
	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float distance;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float xSpeed;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float ySpeed;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float yMinLimit;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float yMaxLimit;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float x;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float y;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float prevDistance;

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x131DC9C", Offset = "0x131DC9C", VA = "0x131DC9C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x131DCC8", Offset = "0x131DCC8", VA = "0x131DCC8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x131E120", Offset = "0x131E120", VA = "0x131E120")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x131E15C", Offset = "0x131E15C", VA = "0x131E15C")]
	public RFX4_MouseOrbit()
	{
	}
}
[Token(Token = "0x2000064")]
public class RFX4_RealtimeReflection : MonoBehaviour
{
	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ReflectionProbe probe;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform camT;

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x131E178", Offset = "0x131E178", VA = "0x131E178")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x131E1F8", Offset = "0x131E1F8", VA = "0x131E1F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x131E26C", Offset = "0x131E26C", VA = "0x131E26C")]
	public RFX4_RealtimeReflection()
	{
	}
}
[Token(Token = "0x2000065")]
[ExecuteAlways]
public class MeshToSDF : MonoBehaviour
{
	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool executeInEditMode;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool executeInUpdate;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ComputeShader JFAImplementation;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ComputeShader MtVImplementation;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RenderTexture outputRenderTexture;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Mesh to convert to SDF. One of Mesh or Skinned Mesh Renderer must be set")]
	public Mesh staticMesh;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("Skinned mesh renderer to bake mesh from before converting to SDF.")]
	public SkinnedMeshRenderer skinnedMeshRenderer;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("Material whose property to set with the output SDF texture")]
	public Material materialOutput;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string materialProperty;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Tooltip("Visual effect whose property to set with the output SDF texture")]
	public VisualEffect vfxOutput;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string vfxProperty;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public bool fieldsChanged;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Tooltip("Signed distance field resoluton")]
	public int sdfResolution;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("Offset the mesh before voxelization")]
	public Vector3 offset;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[Tooltip("Scale the mesh before voxelization")]
	public float scaleBy;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("Number of points to sample on each triangle when voxeling")]
	public uint samplesPerTriangle;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Tooltip("Thicken the signed distance field by this amount")]
	public float postProcessThickness;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Mesh prevMesh;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int JFA;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int Preprocess;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int Postprocess;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int DebugSphere;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int MtV;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private int Zero;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private ComputeBuffer[] cachedBuffers;

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x131E274", Offset = "0x131E274", VA = "0x131E274")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x131E4E8", Offset = "0x131E4E8", VA = "0x131E4E8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x131E904", Offset = "0x131E904", VA = "0x131E904")]
	private void Update()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x131E5DC", Offset = "0x131E5DC", VA = "0x131E5DC")]
	public void UpdateMesh()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x131F1D0", Offset = "0x131F1D0", VA = "0x131F1D0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x131EE94", Offset = "0x131EE94", VA = "0x131EE94")]
	public void FloodFillToSDF(RenderTexture voxels)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x131F240", Offset = "0x131F240", VA = "0x131F240")]
	private ComputeBuffer cachedComputeBuffer(int count, int stride, int cacheSlot)
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x131F370", Offset = "0x131F370", VA = "0x131F370")]
	private Vector3 Div(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x131E944", Offset = "0x131E944", VA = "0x131E944")]
	public RenderTexture MeshToVoxel(int voxelResolution, Mesh mesh, Vector3 offset, float scaleMeshBy, uint numSamplesPerTriangle, [Optional] RenderTexture voxels)
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x131F380", Offset = "0x131F380", VA = "0x131F380")]
	private RenderTexture MakeDebugTexture()
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x131F230", Offset = "0x131F230", VA = "0x131F230")]
	private int numGroups(int totalThreads, int groupSize)
	{
		return default(int);
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x131F544", Offset = "0x131F544", VA = "0x131F544")]
	public MeshToSDF()
	{
	}
}
[Token(Token = "0x2000066")]
public class Big_Splash : MonoBehaviour
{
	[Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class <TriggerSplash>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Big_Splash <>4__this;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x131F85C", Offset = "0x131F85C", VA = "0x131F85C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x131F8A4", Offset = "0x131F8A4", VA = "0x131F8A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x131F73C", Offset = "0x131F73C", VA = "0x131F73C")]
		[DebuggerHidden]
		public <TriggerSplash>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x131F76C", Offset = "0x131F76C", VA = "0x131F76C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x131F770", Offset = "0x131F770", VA = "0x131F770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x131F864", Offset = "0x131F864", VA = "0x131F864", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject BigSplash;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float splashFlag;

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x131F620", Offset = "0x131F620", VA = "0x131F620")]
	private void Start()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x131F640", Offset = "0x131F640", VA = "0x131F640")]
	private void Update()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x131F6C8", Offset = "0x131F6C8", VA = "0x131F6C8")]
	[IteratorStateMachine(typeof(<TriggerSplash>d__4))]
	private IEnumerator TriggerSplash()
	{
		return null;
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x131F764", Offset = "0x131F764", VA = "0x131F764")]
	public Big_Splash()
	{
	}
}
[Token(Token = "0x2000068")]
public class Small_Splash : MonoBehaviour
{
	[Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class <TriggerSplash>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Small_Splash <>4__this;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x131FAEC", Offset = "0x131FAEC", VA = "0x131FAEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x131FB34", Offset = "0x131FB34", VA = "0x131FB34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x131F9C8", Offset = "0x131F9C8", VA = "0x131F9C8")]
		[DebuggerHidden]
		public <TriggerSplash>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x131F9F8", Offset = "0x131F9F8", VA = "0x131F9F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x131F9FC", Offset = "0x131F9FC", VA = "0x131F9FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x131FAF4", Offset = "0x131FAF4", VA = "0x131FAF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject SmallSplash;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float splashFlag;

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x131F8AC", Offset = "0x131F8AC", VA = "0x131F8AC")]
	private void Start()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x131F8CC", Offset = "0x131F8CC", VA = "0x131F8CC")]
	private void Update()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x131F954", Offset = "0x131F954", VA = "0x131F954")]
	[IteratorStateMachine(typeof(<TriggerSplash>d__4))]
	private IEnumerator TriggerSplash()
	{
		return null;
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x131F9F0", Offset = "0x131F9F0", VA = "0x131F9F0")]
	public Small_Splash()
	{
	}
}
namespace MagicalFX
{
	[Token(Token = "0x200006A")]
	[RequireComponent(typeof(Rigidbody))]
	public class FX_AddForceForward : MonoBehaviour
	{
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Force;

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x131FB3C", Offset = "0x131FB3C", VA = "0x131FB3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x131FC14", Offset = "0x131FC14", VA = "0x131FC14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x131FC18", Offset = "0x131FC18", VA = "0x131FC18")]
		public FX_AddForceForward()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class FX_Camera : MonoBehaviour
	{
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 positionTemp;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 forcePower;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x131FC28", Offset = "0x131FC28", VA = "0x131FC28")]
		private void Start()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x131FCA8", Offset = "0x131FCA8", VA = "0x131FCA8")]
		public void Shake(Vector3 power)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x131FCC0", Offset = "0x131FCC0", VA = "0x131FCC0")]
		private void Update()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x131FE1C", Offset = "0x131FE1C", VA = "0x131FE1C")]
		public FX_Camera()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public static class CameraEffect
	{
		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static FX_Camera CameraFX;

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x131FE24", Offset = "0x131FE24", VA = "0x131FE24")]
		public static void Shake(Vector3 power)
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class FX_HitSpawner : MonoBehaviour
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject FXSpawn;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool DestoyOnHit;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool FixRotation;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float LifeTimeAfterHit;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float LifeTime;

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x131FEE8", Offset = "0x131FEE8", VA = "0x131FEE8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x131FEEC", Offset = "0x131FEEC", VA = "0x131FEEC")]
		private void Spawn()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1320140", Offset = "0x1320140", VA = "0x1320140")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1320144", Offset = "0x1320144", VA = "0x1320144")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1320148", Offset = "0x1320148", VA = "0x1320148")]
		public FX_HitSpawner()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class FX_LifeTime : MonoBehaviour
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float LifeTime;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject SpawnAfterDead;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float timeTemp;

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1320158", Offset = "0x1320158", VA = "0x1320158")]
		private void Start()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1320218", Offset = "0x1320218", VA = "0x1320218")]
		private void Update()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1320380", Offset = "0x1320380", VA = "0x1320380")]
		public FX_LifeTime()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[RequireComponent(typeof(Rigidbody))]
	public class FX_Mover : MonoBehaviour
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Speed;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 Noise;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Damping;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion direction;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1320390", Offset = "0x1320390", VA = "0x1320390")]
		private void Start()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x132044C", Offset = "0x132044C", VA = "0x132044C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x132054C", Offset = "0x132054C", VA = "0x132054C")]
		public FX_Mover()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class FX_MoverRandom : MonoBehaviour
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Speed;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 Noise;

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x13205BC", Offset = "0x13205BC", VA = "0x13205BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x13205C0", Offset = "0x13205C0", VA = "0x13205C0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x13206F8", Offset = "0x13206F8", VA = "0x13206F8")]
		public FX_MoverRandom()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class FX_ParticlePreview : MonoBehaviour
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] Particles;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float RotationSpeed;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Index;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D logo;

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1320760", Offset = "0x1320760", VA = "0x1320760")]
		private void Start()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1320764", Offset = "0x1320764", VA = "0x1320764")]
		public void AddParticle(Vector3 position)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1320914", Offset = "0x1320914", VA = "0x1320914")]
		private void Update()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1320ACC", Offset = "0x1320ACC", VA = "0x1320ACC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1320E20", Offset = "0x1320E20", VA = "0x1320E20")]
		public FX_ParticlePreview()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class FX_Position : MonoBehaviour
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Offset;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool Normal;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SpawnMode Mode;

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1320E30", Offset = "0x1320E30", VA = "0x1320E30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1320E34", Offset = "0x1320E34", VA = "0x1320E34")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1320E70", Offset = "0x1320E70", VA = "0x1320E70")]
		public void PlaceNormal(Vector3 position)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1320FBC", Offset = "0x1320FBC", VA = "0x1320FBC")]
		public FX_Position()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public enum SpawnMode
	{
		[Token(Token = "0x400035A")]
		Static,
		[Token(Token = "0x400035B")]
		OnDirection
	}
	[Token(Token = "0x2000074")]
	public class FX_RandomRotation : MonoBehaviour
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Rotation;

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1320FD4", Offset = "0x1320FD4", VA = "0x1320FD4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1321054", Offset = "0x1321054", VA = "0x1321054")]
		public FX_RandomRotation()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class FX_RandomScale : MonoBehaviour
	{
		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float ScaleMin;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float ScaleMax;

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x132105C", Offset = "0x132105C", VA = "0x132105C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x13210D0", Offset = "0x13210D0", VA = "0x13210D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x13210D4", Offset = "0x13210D4", VA = "0x13210D4")]
		public FX_RandomScale()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class FX_Rotation : MonoBehaviour
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Speed;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x13210E4", Offset = "0x13210E4", VA = "0x13210E4")]
		private void Start()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x13210E8", Offset = "0x13210E8", VA = "0x13210E8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1321114", Offset = "0x1321114", VA = "0x1321114")]
		public FX_Rotation()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class FX_ShakeCamera : MonoBehaviour
	{
		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Power;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1321174", Offset = "0x1321174", VA = "0x1321174")]
		private void Start()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1321180", Offset = "0x1321180", VA = "0x1321180")]
		public FX_ShakeCamera()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class FX_SpawnDirection : MonoBehaviour
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Number;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Frequency;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool FixRotation;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Normal;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject FXSpawn;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float LifeTime;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float TimeSpawn;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float timeTemp;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool UseObjectForward;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 Direction;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int counter;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x13211E0", Offset = "0x13211E0", VA = "0x13211E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1321504", Offset = "0x1321504", VA = "0x1321504")]
		private void Update()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x132131C", Offset = "0x132131C", VA = "0x132131C")]
		private void Spawn(Vector3 position)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1321644", Offset = "0x1321644", VA = "0x1321644")]
		public FX_SpawnDirection()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class FX_Spawner : MonoBehaviour
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool FixRotation;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool Normal;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject FXSpawn;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float LifeTime;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float TimeSpawn;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timeTemp;

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x13216B4", Offset = "0x13216B4", VA = "0x13216B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x13218CC", Offset = "0x13218CC", VA = "0x13218CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1321B24", Offset = "0x1321B24", VA = "0x1321B24")]
		public FX_Spawner()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class RainFall : MonoBehaviour
	{
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Skill;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float AreaSize;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int MaxSpawn;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Duration;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float DropRate;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timeTemp;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float timeTempDuration;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int count;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isRaining;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1321B2C", Offset = "0x1321B2C", VA = "0x1321B2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1321B48", Offset = "0x1321B48", VA = "0x1321B48")]
		private void Spawn(Vector3 position)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1321C74", Offset = "0x1321C74", VA = "0x1321C74")]
		public void StartRain()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1321C98", Offset = "0x1321C98", VA = "0x1321C98")]
		private void Update()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1321D94", Offset = "0x1321D94", VA = "0x1321D94")]
		public RainFall()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class RaisingWall : MonoBehaviour
	{
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Skill;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Offset;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Distance;

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1321DB0", Offset = "0x1321DB0", VA = "0x1321DB0")]
		private void Start()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1321EA8", Offset = "0x1321EA8", VA = "0x1321EA8")]
		private void Raising()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x13220C8", Offset = "0x13220C8", VA = "0x13220C8")]
		public RaisingWall()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class Wizard : MonoBehaviour
	{
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] Skills;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 positionLook;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int Index;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool Showtime;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Delay;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float RandomSize;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool RandomSkill;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float timeTemp;

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x13220DC", Offset = "0x13220DC", VA = "0x13220DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x13220F8", Offset = "0x13220F8", VA = "0x13220F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x132245C", Offset = "0x132245C", VA = "0x132245C")]
		private void Deploy()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x13225C0", Offset = "0x13225C0", VA = "0x13225C0")]
		private void Aim()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1322AB0", Offset = "0x1322AB0", VA = "0x1322AB0")]
		private void Shoot(GameObject skill)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1322810", Offset = "0x1322810", VA = "0x1322810")]
		private void Place(GameObject skill)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x13228F4", Offset = "0x13228F4", VA = "0x13228F4")]
		private void PlaceDirection(GameObject skill)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1322D44", Offset = "0x1322D44", VA = "0x1322D44")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1322FEC", Offset = "0x1322FEC", VA = "0x1322FEC")]
		public Wizard()
		{
		}
	}
}
namespace ThunderRoad
{
	[Token(Token = "0x200007D")]
	public class SkillTreeAlignWithCameraDirection : MonoBehaviour
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera playerHeadCam;

		[Token(Token = "0x1700000B")]
		public Camera PlayerHeadCam
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x1323000", Offset = "0x1323000", VA = "0x1323000")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1323148", Offset = "0x1323148", VA = "0x1323148")]
		private void Update()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1323204", Offset = "0x1323204", VA = "0x1323204")]
		public SkillTreeAlignWithCameraDirection()
		{
		}
	}
}
namespace ShieldHit
{
	[Token(Token = "0x200007E")]
	public class ShieldHit : MonoBehaviour
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0.1f, 5f)]
		[SerializeField]
		private float timeToDie;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0.002f, 0.1f)]
		[SerializeField]
		private float hitAmplitude;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0.05f, 0.5f)]
		[SerializeField]
		private float hitRadius;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MeshRenderer meshRenderer;

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x132320C", Offset = "0x132320C", VA = "0x132320C")]
		private void Start()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1323264", Offset = "0x1323264", VA = "0x1323264")]
		public void EnableHit(bool state = false)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x13232F4", Offset = "0x13232F4", VA = "0x13232F4")]
		public void ApplyImpact(Vector3 hitPoint, Vector3 rippleDirection)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x13234A8", Offset = "0x13234A8", VA = "0x13234A8")]
		private void Dampen()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x13235C0", Offset = "0x13235C0", VA = "0x13235C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x13235C4", Offset = "0x13235C4", VA = "0x13235C4")]
		public ShieldHit()
		{
		}
	}
}
