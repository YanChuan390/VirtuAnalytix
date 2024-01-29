using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class MouseLook : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	public enum RotationAxes
	{
		[Token(Token = "0x400000A")]
		MouseXAndY,
		[Token(Token = "0x400000B")]
		MouseX,
		[Token(Token = "0x400000C")]
		MouseY
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public RotationAxes axes;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x1C")]
	public float sensitivityX;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	public float sensitivityY;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x24")]
	public float minimumX;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x28")]
	public float maximumX;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x2C")]
	public float minimumY;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x30")]
	public float maximumY;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x34")]
	private float rotationY;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xA3D024", Offset = "0xA3D024", VA = "0xA3D024")]
	private void Update()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xA3D1F0", Offset = "0xA3D1F0", VA = "0xA3D1F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xA3D2AC", Offset = "0xA3D2AC", VA = "0xA3D2AC")]
	public MouseLook()
	{
	}
}
[Token(Token = "0x2000004")]
public class SmoothCameraOrbit : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 targetOffset;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x2C")]
	public float distance;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x30")]
	public float maxDistance;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x34")]
	public float minDistance;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x38")]
	public float xSpeed;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x3C")]
	public float ySpeed;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x40")]
	public int yMinLimit;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x44")]
	public int yMaxLimit;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x48")]
	public int zoomRate;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x4C")]
	public float panSpeed;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x50")]
	public float zoomDampening;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x54")]
	public float autoRotate;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x58")]
	private float xDeg;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x5C")]
	private float yDeg;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x60")]
	private float currentDistance;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x64")]
	private float desiredDistance;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x68")]
	private Quaternion currentRotation;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x78")]
	private Quaternion desiredRotation;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x88")]
	private Quaternion rotation;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 position;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0xA4")]
	private float idleTimer;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0xA8")]
	private float idleSmooth;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xA3D2CC", Offset = "0xA3D2CC", VA = "0xA3D2CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xA3D7C8", Offset = "0xA3D7C8", VA = "0xA3D7C8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xA3D2D0", Offset = "0xA3D2D0", VA = "0xA3D2D0")]
	public void Init()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xA3D7CC", Offset = "0xA3D7CC", VA = "0xA3D7CC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xA3DC98", Offset = "0xA3DC98", VA = "0xA3DC98")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xA3DCD4", Offset = "0xA3DCD4", VA = "0xA3DCD4")]
	public SmoothCameraOrbit()
	{
	}
}
[Token(Token = "0x2000005")]
public class SciFiBeamStatic : MonoBehaviour
{
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x18")]
	public GameObject beamLineRendererPrefab;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x20")]
	public GameObject beamStartPrefab;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x28")]
	public GameObject beamEndPrefab;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x30")]
	private GameObject beamStart;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x38")]
	private GameObject beamEnd;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x40")]
	private GameObject beam;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x48")]
	private LineRenderer line;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x50")]
	public bool alwaysOn;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x51")]
	public bool beamCollides;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x54")]
	public float beamLength;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x58")]
	public float beamEndOffset;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x5C")]
	public float textureScrollSpeed;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x60")]
	public float textureLengthScale;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xA3DD18", Offset = "0xA3DD18", VA = "0xA3DD18")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xA3DFF8", Offset = "0xA3DFF8", VA = "0xA3DFF8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xA3E110", Offset = "0xA3E110", VA = "0xA3E110")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xA3DD28", Offset = "0xA3DD28", VA = "0xA3DD28")]
	public void SpawnBeam()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xA3DFFC", Offset = "0xA3DFFC", VA = "0xA3DFFC")]
	public void RemoveBeam()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xA3E514", Offset = "0xA3E514", VA = "0xA3E514")]
	public SciFiBeamStatic()
	{
	}
}
[Token(Token = "0x2000006")]
public class SciFiLightFlicker : MonoBehaviour
{
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x18")]
	public string waveFunction;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x20")]
	public float startValue;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x24")]
	public float amplitude;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x28")]
	public float phase;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x2C")]
	public float frequency;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x30")]
	private Color originalColor;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xA3E534", Offset = "0xA3E534", VA = "0xA3E534")]
	private void Start()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xA3E598", Offset = "0xA3E598", VA = "0xA3E598")]
	private void Update()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xA3E62C", Offset = "0xA3E62C", VA = "0xA3E62C")]
	private float EvalWave()
	{
		return default(float);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xA3E7F8", Offset = "0xA3E7F8", VA = "0xA3E7F8")]
	public SciFiLightFlicker()
	{
	}
}
namespace SciFiArsenal;

[Token(Token = "0x2000007")]
public class SciFiLightFade : MonoBehaviour
{
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x18")]
	public float life;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x1C")]
	public bool killAfterLife;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x20")]
	private Light li;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x28")]
	private float initIntensity;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xA3E860", Offset = "0xA3E860", VA = "0xA3E860")]
	private void Start()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xA3E97C", Offset = "0xA3E97C", VA = "0xA3E97C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xA3EAB8", Offset = "0xA3EAB8", VA = "0xA3EAB8")]
	public SciFiLightFade()
	{
	}
}
[Token(Token = "0x2000008")]
public class SciFiPitchRandomizer : MonoBehaviour
{
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x18")]
	public float randomPercent;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xA3EAD4", Offset = "0xA3EAD4", VA = "0xA3EAD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xA3EB84", Offset = "0xA3EB84", VA = "0xA3EB84")]
	public SciFiPitchRandomizer()
	{
	}
}
[Token(Token = "0x2000009")]
public class SciFiRotation : MonoBehaviour
{
	[Token(Token = "0x200000A")]
	public enum spaceEnum
	{
		[Token(Token = "0x400003F")]
		Local,
		[Token(Token = "0x4000040")]
		World
	}

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 rotateVector;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x24")]
	public spaceEnum rotateSpace;

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xA3EB94", Offset = "0xA3EB94", VA = "0xA3EB94")]
	private void Update()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xA3EC68", Offset = "0xA3EC68", VA = "0xA3EC68")]
	public SciFiRotation()
	{
	}
}
