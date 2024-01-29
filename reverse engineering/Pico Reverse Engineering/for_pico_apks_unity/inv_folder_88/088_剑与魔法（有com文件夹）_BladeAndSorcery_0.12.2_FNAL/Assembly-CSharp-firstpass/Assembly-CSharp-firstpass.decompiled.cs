using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dynamite3D.RealIvy;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class RandomMaterial : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Renderer targetRenderer;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material[] materials;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x12BB4C4", Offset = "0x12BB4C4", VA = "0x12BB4C4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x12BB4C8", Offset = "0x12BB4C8", VA = "0x12BB4C8")]
	public void ChangeMaterial()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x12BB520", Offset = "0x12BB520", VA = "0x12BB520")]
	public RandomMaterial()
	{
	}
}
[Token(Token = "0x2000003")]
public class UnluckDistanceDisabler : MonoBehaviour
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int _distanceDisable;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform _distanceFrom;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool _distanceFromMainCam;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float _disableCheckInterval;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float _enableCheckInterval;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool _disableOnStart;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x12BB528", Offset = "0x12BB528", VA = "0x12BB528")]
	public void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x12BB634", Offset = "0x12BB634", VA = "0x12BB634")]
	public void DisableOnStart()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x12BB668", Offset = "0x12BB668", VA = "0x12BB668")]
	public void CheckDisable()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x12BB734", Offset = "0x12BB734", VA = "0x12BB734")]
	public void CheckEnable()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x12BB800", Offset = "0x12BB800", VA = "0x12BB800")]
	public UnluckDistanceDisabler()
	{
	}
}
[Token(Token = "0x2000004")]
public class LookAtCamera : MonoBehaviour
{
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera lookAtCamera;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool lookOnlyOnAwake;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x12BB81C", Offset = "0x12BB81C", VA = "0x12BB81C")]
	public void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x12BB908", Offset = "0x12BB908", VA = "0x12BB908")]
	public void Update()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x12BB8C4", Offset = "0x12BB8C4", VA = "0x12BB8C4")]
	public void LookCam()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x12BB918", Offset = "0x12BB918", VA = "0x12BB918")]
	public LookAtCamera()
	{
	}
}
[Token(Token = "0x2000005")]
[AddComponentMenu("Camera-Control/Smooth Mouse Orbit - Unluck Software")]
public class SmoothCameraOrbit : MonoBehaviour
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 targetOffset;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float distance;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maxDistance;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float minDistance;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float xSpeed;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float ySpeed;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int yMinLimit;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int yMaxLimit;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int zoomRate;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float panSpeed;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float zoomDampening;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float autoRotate;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float autoRotateSpeed;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float xDeg;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float yDeg;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float currentDistance;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float desiredDistance;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Quaternion currentRotation;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Quaternion desiredRotation;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Quaternion rotation;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 position;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float idleTimer;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float idleSmooth;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x12BB920", Offset = "0x12BB920", VA = "0x12BB920")]
	private void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x12BBE1C", Offset = "0x12BBE1C", VA = "0x12BBE1C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x12BB924", Offset = "0x12BB924", VA = "0x12BB924")]
	public void Init()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x12BBE20", Offset = "0x12BBE20", VA = "0x12BBE20")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x12BC2F8", Offset = "0x12BC2F8", VA = "0x12BC2F8")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x12BC334", Offset = "0x12BC334", VA = "0x12BC334")]
	public SmoothCameraOrbit()
	{
	}
}
[Token(Token = "0x2000006")]
public class FlockChild : MonoBehaviour
{
	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public FlockController _spawner;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Vector3 _wayPoint;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float _speed;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public bool _dived;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public float _stuckCounter;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public float _damping;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public bool _soar;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	[HideInInspector]
	public bool _landing;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public float _targetSpeed;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public bool _move;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject _model;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform _modelT;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public float _avoidValue;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[HideInInspector]
	public float _avoidDistance;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float _soarTimer;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool _instantiated;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int _updateNextSeed;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _updateSeed;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[HideInInspector]
	public bool _avoid;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform _thisT;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3 _landingPosOffset;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x12BC370", Offset = "0x12BC370", VA = "0x12BC370")]
	public void Start()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x12BCAA8", Offset = "0x12BCAA8", VA = "0x12BCAA8")]
	public void Update()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x12BD134", Offset = "0x12BD134", VA = "0x12BD134")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x12BD168", Offset = "0x12BD168", VA = "0x12BD168")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x12BC454", Offset = "0x12BC454", VA = "0x12BC454")]
	public void FindRequiredComponents()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x12BC750", Offset = "0x12BC750", VA = "0x12BC750")]
	public void RandomizeStartAnimationFrame()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x12BCA54", Offset = "0x12BCA54", VA = "0x12BCA54")]
	public void InitAvoidanceValues()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x12BC654", Offset = "0x12BC654", VA = "0x12BC654")]
	public void SetRandomScale()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x12BCB04", Offset = "0x12BCB04", VA = "0x12BCB04")]
	public void SoarTimeLimit()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x12BCB5C", Offset = "0x12BCB5C", VA = "0x12BCB5C")]
	public void CheckForDistanceToWaypoint()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x12BCC6C", Offset = "0x12BCC6C", VA = "0x12BCC6C")]
	public void RotationBasedOnWaypointOrAvoidance()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x12BD458", Offset = "0x12BD458", VA = "0x12BD458")]
	public bool Avoidance()
	{
		return default(bool);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x12BCF40", Offset = "0x12BCF40", VA = "0x12BCF40")]
	public void LimitRotationOfModel()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x12BC5AC", Offset = "0x12BC5AC", VA = "0x12BC5AC")]
	public void Wander(float delay)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x12BD994", Offset = "0x12BD994", VA = "0x12BD994")]
	public void SetRandomMode()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x12BD214", Offset = "0x12BD214", VA = "0x12BD214")]
	public void Flap()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x12BC690", Offset = "0x12BC690", VA = "0x12BC690")]
	public Vector3 findWaypoint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x12BDA54", Offset = "0x12BDA54", VA = "0x12BDA54")]
	public void Soar()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x12BDAE4", Offset = "0x12BDAE4", VA = "0x12BDAE4")]
	public void Dive()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x12BDE80", Offset = "0x12BDE80", VA = "0x12BDE80")]
	public void animationSpeed()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x12BE1C4", Offset = "0x12BE1C4", VA = "0x12BE1C4")]
	public FlockChild()
	{
	}
}
[Token(Token = "0x2000007")]
[RequireComponent(typeof(AudioSource))]
public class FlockChildSound : MonoBehaviour
{
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip[] _idleSounds;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float _idleSoundRandomChance;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip[] _flightSounds;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float _flightSoundRandomChance;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioClip[] _scareSounds;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float _pitchMin;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float _pitchMax;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float _volumeMin;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float _volumeMax;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private FlockChild _flockChild;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AudioSource _audio;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool _hasLanded;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x12BE1E8", Offset = "0x12BE1E8", VA = "0x12BE1E8")]
	public void Start()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x12BE300", Offset = "0x12BE300", VA = "0x12BE300")]
	public void PlayRandomSound()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x12BE504", Offset = "0x12BE504", VA = "0x12BE504")]
	public void ScareSound()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x12BE600", Offset = "0x12BE600", VA = "0x12BE600")]
	public FlockChildSound()
	{
	}
}
[Token(Token = "0x2000008")]
public class FlockController : MonoBehaviour
{
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FlockChild _childPrefab;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int _childAmount;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool _slowSpawn;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float _spawnSphere;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float _spawnSphereHeight;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float _spawnSphereDepth;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float _minSpeed;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float _maxSpeed;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float _minScale;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float _maxScale;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float _soarFrequency;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string _soarAnimation;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string _flapAnimation;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string _idleAnimation;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float _diveValue;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float _diveFrequency;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float _minDamping;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float _maxDamping;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float _waypointDistance;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float _minAnimationSpeed;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float _maxAnimationSpeed;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float _randomPositionTimer;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float _positionSphere;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float _positionSphereHeight;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float _positionSphereDepth;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool _childTriggerPos;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
	public bool _forceChildWaypoints;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float _forcedRandomDelay;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool _flatFly;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool _flatSoar;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
	public bool _birdAvoid;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public int _birdAvoidHorizontalForce;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool _birdAvoidDown;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	public bool _birdAvoidUp;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public int _birdAvoidVerticalForce;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float _birdAvoidDistanceMax;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float _birdAvoidDistanceMin;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float _soarMaxTime;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public LayerMask _avoidanceMask;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<FlockChild> _roamers;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Vector3 _posBuffer;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public int _updateDivisor;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float _newDelta;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public int _updateCounter;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float _activeChildren;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public bool _groupChildToNewTransform;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform _groupTransform;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public string _groupName;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool _groupChildToFlock;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public Vector3 _startPosOffset;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Transform _thisT;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x12BE624", Offset = "0x12BE624", VA = "0x12BE624")]
	public void Start()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x12BE71C", Offset = "0x12BE71C", VA = "0x12BE71C")]
	public void AddChild(int amount)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x12BE9D0", Offset = "0x12BE9D0", VA = "0x12BE9D0")]
	public void AddChildToParent(Transform obj)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x12BEA20", Offset = "0x12BEA20", VA = "0x12BEA20")]
	public void RemoveChild(int amount)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x12BEB28", Offset = "0x12BEB28", VA = "0x12BEB28")]
	public void Update()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x12BE870", Offset = "0x12BE870", VA = "0x12BE870")]
	public void InstantiateGroup()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x12BEB8C", Offset = "0x12BEB8C", VA = "0x12BEB8C")]
	public void UpdateChildAmount()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x12BEC1C", Offset = "0x12BEC1C", VA = "0x12BEC1C")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x12BD2E8", Offset = "0x12BD2E8", VA = "0x12BD2E8")]
	public void SetFlockRandomPosition()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x12BEE04", Offset = "0x12BEE04", VA = "0x12BEE04")]
	public void destroyBirds()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x12BEF10", Offset = "0x12BEF10", VA = "0x12BEF10")]
	public FlockController()
	{
	}
}
[Token(Token = "0x2000009")]
public class FlockScare : MonoBehaviour
{
	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LandingSpotController[] landingSpotControllers;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float scareInterval;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float distanceToScare;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int checkEveryNthLandingSpot;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int InvokeAmounts;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int lsc;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int ls;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LandingSpotController currentController;

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x12BF074", Offset = "0x12BF074", VA = "0x12BF074")]
	private void CheckProximityToLandingSpots()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x12BF144", Offset = "0x12BF144", VA = "0x12BF144")]
	private void IterateLandingSpots()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x12BF1F8", Offset = "0x12BF1F8", VA = "0x12BF1F8")]
	private bool CheckDistanceToLandingSpot(LandingSpotController lc)
	{
		return default(bool);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x12BF33C", Offset = "0x12BF33C", VA = "0x12BF33C")]
	private void Invoker()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x12BF3C4", Offset = "0x12BF3C4", VA = "0x12BF3C4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x12BF438", Offset = "0x12BF438", VA = "0x12BF438")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x12BF484", Offset = "0x12BF484", VA = "0x12BF484")]
	public FlockScare()
	{
	}
}
[Token(Token = "0x200000A")]
public class FlockWaypointTrigger : MonoBehaviour
{
	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float _timer;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FlockChild _flockChild;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x12BF49C", Offset = "0x12BF49C", VA = "0x12BF49C")]
	public void Start()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x12BF594", Offset = "0x12BF594", VA = "0x12BF594")]
	public void Trigger()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x12BF5B0", Offset = "0x12BF5B0", VA = "0x12BF5B0")]
	public FlockWaypointTrigger()
	{
	}
}
[Token(Token = "0x200000B")]
public class LandingButtons : MonoBehaviour
{
	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LandingSpotController _landingSpotController;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FlockController _flockController;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float hSliderValue;

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x12BF5C0", Offset = "0x12BF5C0", VA = "0x12BF5C0")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x12BFB38", Offset = "0x12BFB38", VA = "0x12BFB38")]
	public LandingButtons()
	{
	}
}
[Token(Token = "0x200000C")]
public class LandingSpot : MonoBehaviour
{
	[Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class <GetFlockChild>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minDelay;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxDelay;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LandingSpot <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x12C1654", Offset = "0x12C1654", VA = "0x12C1654", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x12C169C", Offset = "0x12C169C", VA = "0x12C169C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x12C090C", Offset = "0x12C090C", VA = "0x12C090C")]
		[DebuggerHidden]
		public <GetFlockChild>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x12C0F20", Offset = "0x12C0F20", VA = "0x12C0F20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x12C0F24", Offset = "0x12C0F24", VA = "0x12C0F24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x12C165C", Offset = "0x12C165C", VA = "0x12C165C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public FlockChild landingChild;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public bool landing;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int lerpCounter;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public LandingSpotController _controller;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _idle;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform _thisT;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool _gotcha;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x12BFB48", Offset = "0x12BFB48", VA = "0x12BFB48")]
	public void Start()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x12BFD0C", Offset = "0x12BFD0C", VA = "0x12BFD0C")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x12C00FC", Offset = "0x12C00FC", VA = "0x12C00FC")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x12C08A0", Offset = "0x12C08A0", VA = "0x12C08A0")]
	public void StraightenBird()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x12C06DC", Offset = "0x12C06DC", VA = "0x12C06DC")]
	public void RotateBird()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x12BFC84", Offset = "0x12BFC84", VA = "0x12BFC84")]
	[IteratorStateMachine(typeof(<GetFlockChild>d__12))]
	public IEnumerator GetFlockChild(float minDelay, float maxDelay)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x12C0934", Offset = "0x12C0934", VA = "0x12C0934")]
	public void InstantLand()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x12C0C84", Offset = "0x12C0C84", VA = "0x12C0C84")]
	public void ReleaseFlockChild()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x12C0F18", Offset = "0x12C0F18", VA = "0x12C0F18")]
	public LandingSpot()
	{
	}
}
[Token(Token = "0x200000E")]
public class LandingSpotController : MonoBehaviour
{
	[Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class <InstantLandOnStart>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LandingSpotController <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x12C1CDC", Offset = "0x12C1CDC", VA = "0x12C1CDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x12C1D24", Offset = "0x12C1D24", VA = "0x12C1D24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x12C1AB8", Offset = "0x12C1AB8", VA = "0x12C1AB8")]
		[DebuggerHidden]
		public <InstantLandOnStart>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x12C1B58", Offset = "0x12C1B58", VA = "0x12C1B58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x12C1B5C", Offset = "0x12C1B5C", VA = "0x12C1B5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x12C1CE4", Offset = "0x12C1CE4", VA = "0x12C1CE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class <InstantLand>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LandingSpotController <>4__this;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x12C1EB0", Offset = "0x12C1EB0", VA = "0x12C1EB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x12C1EF8", Offset = "0x12C1EF8", VA = "0x12C1EF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x12C1AE0", Offset = "0x12C1AE0", VA = "0x12C1AE0")]
		[DebuggerHidden]
		public <InstantLand>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x12C1D2C", Offset = "0x12C1D2C", VA = "0x12C1D2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x12C1D30", Offset = "0x12C1D30", VA = "0x12C1D30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x12C1EB8", Offset = "0x12C1EB8", VA = "0x12C1EB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool _randomRotate;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector2 _autoCatchDelay;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector2 _autoDismountDelay;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float _maxBirdDistance;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float _minBirdDistance;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool _takeClosest;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public FlockController _flock;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool _landOnStart;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool _soarLand;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool _onlyBirdsAbove;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float _landingSpeedModifier;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float _landingTurnSpeedModifier;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform _featherPS;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform _thisT;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int _activeLandingSpots;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float _snapLandDistance;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float _landedRotateSpeed;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float _gizmoSize;

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x12C16A4", Offset = "0x12C16A4", VA = "0x12C16A4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x12BF330", Offset = "0x12BF330", VA = "0x12BF330")]
	public void ScareAll()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x12C1970", Offset = "0x12C1970", VA = "0x12C1970")]
	public void ScareAll(float minDelay, float maxDelay)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x12BF994", Offset = "0x12BF994", VA = "0x12BF994")]
	public void LandAll()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x12C18EC", Offset = "0x12C18EC", VA = "0x12C18EC")]
	[IteratorStateMachine(typeof(<InstantLandOnStart>d__22))]
	public IEnumerator InstantLandOnStart(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x12BFAB4", Offset = "0x12BFAB4", VA = "0x12BFAB4")]
	[IteratorStateMachine(typeof(<InstantLand>d__23))]
	public IEnumerator InstantLand(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x12C1B08", Offset = "0x12C1B08", VA = "0x12C1B08")]
	public LandingSpotController()
	{
	}
}
[Token(Token = "0x2000011")]
public class RotateSeeker : MonoBehaviour
{
	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Speed;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform trans;

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x12C1F00", Offset = "0x12C1F00", VA = "0x12C1F00")]
	private void Start()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x12C1F58", Offset = "0x12C1F58", VA = "0x12C1F58")]
	private void Update()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x12C1FA4", Offset = "0x12C1FA4", VA = "0x12C1FA4")]
	public RotateSeeker()
	{
	}
}
[Token(Token = "0x2000012")]
public class Fan : MonoBehaviour
{
	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float _speed;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform trans;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x12C1FB4", Offset = "0x12C1FB4", VA = "0x12C1FB4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x12C200C", Offset = "0x12C200C", VA = "0x12C200C")]
	private void Update()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x12C2050", Offset = "0x12C2050", VA = "0x12C2050")]
	public Fan()
	{
	}
}
[Token(Token = "0x2000013")]
public class ApplyProceduralTextureProperties : MonoBehaviour
{
	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(5f)]
	public Material m_Material;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Space(5f)]
	public ProceduralTexture2D proceduralTexAssetAlbedo;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ProceduralTexture2D proceduralTexAssetNormal;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ProceduralTexture2D proceduralTexAssetMask;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x12C2060", Offset = "0x12C2060", VA = "0x12C2060")]
	public void SyncMatWithProceduralTextureAsset()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x12C26FC", Offset = "0x12C26FC", VA = "0x12C26FC")]
	public ApplyProceduralTextureProperties()
	{
	}
}
[Serializable]
[Token(Token = "0x2000014")]
[CreateAssetMenu(fileName = "New Procedural Texture 2D", menuName = "", order = 1)]
public class ProceduralTexture2D : ScriptableObject
{
	[Token(Token = "0x2000015")]
	public enum TextureType
	{
		[Token(Token = "0x40000C9")]
		Color,
		[Token(Token = "0x40000CA")]
		Normal,
		[Token(Token = "0x40000CB")]
		Other
	}

	[Token(Token = "0x2000016")]
	public enum CompressionLevel
	{
		[Token(Token = "0x40000CD")]
		None = -1,
		[Token(Token = "0x40000CE")]
		LowQuality = 0,
		[Token(Token = "0x40000CF")]
		NormalQuality = 50,
		[Token(Token = "0x40000D0")]
		HighQuality = 100
	}

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D input;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextureType type;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool includeAlpha;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool generateMipMaps;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FilterMode filterMode;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int anisoLevel;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CompressionLevel compressionQuality;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D Tinput;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D invT;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 colorSpaceOrigin;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 colorSpaceVector1;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 colorSpaceVector2;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 colorSpaceVector3;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector4 compressionScalers;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public long memoryUsageBytes;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Texture2D currentInput;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextureType currentType;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool currentIncludeAlpha;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	public bool currentGenerateMipMaps;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public FilterMode currentFilterMode;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int currentAnisoLevel;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public CompressionLevel currentCompressionQuality;

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x12C2704", Offset = "0x12C2704", VA = "0x12C2704")]
	public ProceduralTexture2D()
	{
	}
}
[Token(Token = "0x2000017")]
public class MLPForceSaveProbes : MonoBehaviour
{
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x12C27F0", Offset = "0x12C27F0", VA = "0x12C27F0")]
	public MLPForceSaveProbes()
	{
	}
}
[Token(Token = "0x2000018")]
public class PlayerController : MonoBehaviour
{
	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IvyCaster ivyCaster;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform trIvy;

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x12C27F8", Offset = "0x12C27F8", VA = "0x12C27F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x12C28B0", Offset = "0x12C28B0", VA = "0x12C28B0")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x2000019")]
public class GizmoUtils
{
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x12C28B8", Offset = "0x12C28B8", VA = "0x12C28B8")]
	public static void ToggleGizmos(bool gizmosOn)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x12C28BC", Offset = "0x12C28BC", VA = "0x12C28BC")]
	public GizmoUtils()
	{
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x200001A")]
	[RequireComponent(typeof(Camera))]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x12C28C4", Offset = "0x12C28C4", VA = "0x12C28C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x12C2984", Offset = "0x12C2984", VA = "0x12C2984")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[RequireComponent(typeof(Collider), typeof(Rigidbody), typeof(MeshRenderer))]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x12C2994", Offset = "0x12C2994", VA = "0x12C2994")]
		private void Start()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x12C2A84", Offset = "0x12C2A84", VA = "0x12C2A84")]
		private void Update()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x12C2B38", Offset = "0x12C2B38", VA = "0x12C2B38")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x12C2B40", Offset = "0x12C2B40", VA = "0x12C2B40")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x12C2BFC", Offset = "0x12C2BFC", VA = "0x12C2BFC")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x12C2C04", Offset = "0x12C2C04", VA = "0x12C2C04")]
		private void Start()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x12C2C74", Offset = "0x12C2C74", VA = "0x12C2C74")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x17000007")]
		private bool useMouseView
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x12C2C7C", Offset = "0x12C2C7C", VA = "0x12C2C7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x12C2C84", Offset = "0x12C2C84", VA = "0x12C2C84")]
			set
			{
			}
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x12C2CB4", Offset = "0x12C2CB4", VA = "0x12C2CB4")]
		private void Start()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x12C2D44", Offset = "0x12C2D44", VA = "0x12C2D44")]
		private void Update()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x12C3320", Offset = "0x12C3320", VA = "0x12C3320")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Range(1f, 100f)]
		private int CountX;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Range(1f, 100f)]
		private int CountY;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x12C3344", Offset = "0x12C3344", VA = "0x12C3344")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x12C39B8", Offset = "0x12C39B8", VA = "0x12C39B8")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("m_EulerSpeed")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x12C39D4", Offset = "0x12C39D4", VA = "0x12C39D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x12C3AA4", Offset = "0x12C3AA4", VA = "0x12C3AA4")]
		public Rotater()
		{
		}
	}
}
namespace Technie.PhysicsCreator
{
	[Token(Token = "0x2000020")]
	public class HullData : ScriptableObject
	{
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x12C3B04", Offset = "0x12C3B04", VA = "0x12C3B04")]
		public HullData()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class HullMapping
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Hull sourceHull;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Collider generatedCollider;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HullPainterChild targetChild;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x12C3B0C", Offset = "0x12C3B0C", VA = "0x12C3B0C")]
		public HullMapping()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class HullPainter : MonoBehaviour
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PaintingData paintingData;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HullData hullData;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<HullMapping> hullMapping;

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x12C3B14", Offset = "0x12C3B14", VA = "0x12C3B14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x12C3B18", Offset = "0x12C3B18", VA = "0x12C3B18")]
		public void CreateColliderComponents()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x12C5BA4", Offset = "0x12C5BA4", VA = "0x12C5BA4")]
		public void RemoveAllColliders()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x12C5E48", Offset = "0x12C5E48", VA = "0x12C5E48")]
		public void RemoveAllGenerated()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x12C600C", Offset = "0x12C600C", VA = "0x12C600C")]
		private static bool IsDeletable(GameObject obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x12C5DC0", Offset = "0x12C5DC0", VA = "0x12C5DC0")]
		private static void DestroyImmediateWithUndo(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x12C3C58", Offset = "0x12C3C58", VA = "0x12C3C58")]
		private void CreateHullMapping()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x12C6880", Offset = "0x12C6880", VA = "0x12C6880")]
		private static bool Approximately(Vector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x12C6980", Offset = "0x12C6980", VA = "0x12C6980")]
		private static bool Approximately(float lhs, float rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		private void CreateCollider<T>(Hull sourceHull) where T : Collider
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x12C6CD8", Offset = "0x12C6CD8", VA = "0x12C6CD8")]
		private void RecreateChildCollider(HullMapping mapping)
		{
		}

		[Token(Token = "0x6000092")]
		private void RecreateChildCollider<T>(HullMapping mapping) where T : Collider
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x12C57F8", Offset = "0x12C57F8", VA = "0x12C57F8")]
		private void UpdateCollider(Hull hull)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x12C6D98", Offset = "0x12C6D98", VA = "0x12C6D98")]
		public void SetAllTypes(HullType newType)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x12C6ED8", Offset = "0x12C6ED8", VA = "0x12C6ED8")]
		public void SetAllMaterials(PhysicMaterial newMaterial)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x12C7034", Offset = "0x12C7034", VA = "0x12C7034")]
		public void SetAllAsChild(bool isChild)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x12C7188", Offset = "0x12C7188", VA = "0x12C7188")]
		public void SetAllAsTrigger(bool isTrigger)
		{
		}

		[Token(Token = "0x6000098")]
		private List<T> FindLocal<T>() where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x12C61A4", Offset = "0x12C61A4", VA = "0x12C61A4")]
		private bool IsMapped(Hull hull)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x12C6540", Offset = "0x12C6540", VA = "0x12C6540")]
		private bool IsMapped(Collider col)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x12C66E0", Offset = "0x12C66E0", VA = "0x12C66E0")]
		private bool IsMapped(HullPainterChild child)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x12C6A08", Offset = "0x12C6A08", VA = "0x12C6A08")]
		private void AddMapping(Hull hull, Collider col, HullPainterChild painterChild)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x12C646C", Offset = "0x12C646C", VA = "0x12C646C")]
		private void RemoveMapping(Hull hull)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x12C6B34", Offset = "0x12C6B34", VA = "0x12C6B34")]
		private HullMapping FindMapping(HullPainterChild child)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x12C72DC", Offset = "0x12C72DC", VA = "0x12C72DC")]
		public Hull FindSourceHull(HullPainterChild child)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x12C6304", Offset = "0x12C6304", VA = "0x12C6304")]
		private static Collider FindExistingCollider(List<HullMapping> mappings, Hull hull)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x12C7480", Offset = "0x12C7480", VA = "0x12C7480")]
		private static GameObject CreateGameObject(string goName)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		private static T AddComponent<T>(GameObject targetObj) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x12C74E4", Offset = "0x12C74E4", VA = "0x12C74E4")]
		public HullPainter()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class HullPainterChild : MonoBehaviour
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HullPainter parent;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x12C74EC", Offset = "0x12C74EC", VA = "0x12C74EC")]
		public HullPainterChild()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public enum HullType
	{
		[Token(Token = "0x40000EE")]
		Box,
		[Token(Token = "0x40000EF")]
		ConvexHull,
		[Token(Token = "0x40000F0")]
		Sphere,
		[Token(Token = "0x40000F1")]
		Face
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public class Hull
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isVisible;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public HullType type;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color colour;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PhysicMaterial material;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool enableInflation;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float inflationAmount;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isTrigger;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isChildCollider;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<int> selectedFaces;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Mesh collisionMesh;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Mesh faceCollisionMesh;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Bounds collisionBox;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Sphere collisionSphere;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool hasColliderError;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public int numColliderFaces;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x12C74F4", Offset = "0x12C74F4", VA = "0x12C74F4")]
		public void Destroy()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x12C74F8", Offset = "0x12C74F8", VA = "0x12C74F8")]
		public Hull()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class PaintingData : ScriptableObject
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly Color[] hullColours;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HullData hullData;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Mesh sourceMesh;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int activeHull;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float faceThickness;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Hull> hulls;

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x12C75D0", Offset = "0x12C75D0", VA = "0x12C75D0")]
		public void AddHull(HullType type, PhysicMaterial material, bool isChild, bool isTrigger)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x12C7848", Offset = "0x12C7848", VA = "0x12C7848")]
		public void RemoveHull(int index)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x12C78CC", Offset = "0x12C78CC", VA = "0x12C78CC")]
		public void RemoveAllHulls()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x12C7988", Offset = "0x12C7988", VA = "0x12C7988")]
		public bool HasActiveHull()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x12C79E8", Offset = "0x12C79E8", VA = "0x12C79E8")]
		public Hull GetActiveHull()
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x12C7A68", Offset = "0x12C7A68", VA = "0x12C7A68")]
		public void GenerateCollisionMesh(Hull hull, Vector3[] meshVertices, int[] meshIndices)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x12C8028", Offset = "0x12C8028", VA = "0x12C8028")]
		private bool CalculateBoundingSphere(Hull hull, Vector3[] meshVertices, int[] meshIndices, out Vector3 sphereCenter, out float sphereRadius)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x12C8390", Offset = "0x12C8390", VA = "0x12C8390")]
		private void GenerateConvexHull(Hull hull, Vector3[] meshVertices, int[] meshIndices, Mesh destMesh)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x12C8F00", Offset = "0x12C8F00", VA = "0x12C8F00")]
		private void GenerateFace(Hull hull, Vector3[] meshVertices, int[] meshIndices, float thickness)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x12C9618", Offset = "0x12C9618", VA = "0x12C9618")]
		public bool ContainsMesh(Mesh m)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x12C7FCC", Offset = "0x12C7FCC", VA = "0x12C7FCC")]
		private static void Inflate(Vector3 point, ref Vector3 min, ref Vector3 max)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x12C9804", Offset = "0x12C9804", VA = "0x12C9804")]
		public PaintingData()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class Sphere
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 center;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float radius;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x12C8380", Offset = "0x12C8380", VA = "0x12C8380")]
		public Sphere()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class SphereUtils
	{
		[Token(Token = "0x2000029")]
		public class Support
		{
			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int m_iQuantity;

			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int[] m_aiIndex;

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x12CC028", Offset = "0x12CC028", VA = "0x12CC028")]
			public bool Contains(int iIndex, List<Vector3> points)
			{
				return default(bool);
			}

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x12CBEA8", Offset = "0x12CBEA8", VA = "0x12CBEA8")]
			public Support()
			{
			}
		}

		[Token(Token = "0x400010A")]
		private const float kEpsilon = 0.001f;

		[Token(Token = "0x400010B")]
		private const float kOnePlusEpsilon = 1.001f;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x12C99D8", Offset = "0x12C99D8", VA = "0x12C99D8")]
		private static bool PointInsideSphere(Vector3 rkP, Sphere rkS)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x12C9A28", Offset = "0x12C9A28", VA = "0x12C9A28")]
		private static Sphere ExactSphere1(Vector3 rkP)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x12C9AB4", Offset = "0x12C9AB4", VA = "0x12C9AB4")]
		private static Sphere ExactSphere2(Vector3 rkP0, Vector3 rkP1)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x12C9B94", Offset = "0x12C9B94", VA = "0x12C9B94")]
		private static Sphere ExactSphere3(Vector3 rkP0, Vector3 rkP1, Vector3 rkP2)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x12C9D7C", Offset = "0x12C9D7C", VA = "0x12C9D7C")]
		private static Sphere ExactSphere4(Vector3 rkP0, Vector3 rkP1, Vector3 rkP2, Vector3 rkP3)
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x12CA494", Offset = "0x12CA494", VA = "0x12CA494")]
		private static Sphere UpdateSupport1(int i, List<Vector3> apkPerm, Support rkSupp)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x12CA57C", Offset = "0x12CA57C", VA = "0x12CA57C")]
		private static Sphere UpdateSupport2(int i, List<Vector3> apkPerm, Support rkSupp)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x12CA88C", Offset = "0x12CA88C", VA = "0x12CA88C")]
		private static Sphere UpdateSupport3(int i, List<Vector3> apkPerm, Support rkSupp)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x12CAFBC", Offset = "0x12CAFBC", VA = "0x12CAFBC")]
		public static Sphere UpdateSupport4(int i, List<Vector3> apkPerm, Support rkSupp)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x12CBE3C", Offset = "0x12CBE3C", VA = "0x12CBE3C")]
		private static Sphere Update(int funcIndex, int numPoints, List<Vector3> points, Support support)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x12C9438", Offset = "0x12C9438", VA = "0x12C9438")]
		public static Sphere MinSphere(List<Vector3> inputPoints)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x12CBF0C", Offset = "0x12CBF0C", VA = "0x12CBF0C")]
		public static void Shuffle(List<Vector3> list)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x12CC134", Offset = "0x12CC134", VA = "0x12CC134")]
		public SphereUtils()
		{
		}
	}
}
namespace Technie.PhysicsCreator.QHull
{
	[Token(Token = "0x200002A")]
	public class Face
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public HalfEdge he0;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3d normal;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double area;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Point3d centroid;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double planeOffset;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int index;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int numVerts;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Face next;

		[Token(Token = "0x4000116")]
		public const int VISIBLE = 1;

		[Token(Token = "0x4000117")]
		public const int NON_CONVEX = 2;

		[Token(Token = "0x4000118")]
		public const int DELETED = 3;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int mark;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vertex outside;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x12CC13C", Offset = "0x12CC13C", VA = "0x12CC13C")]
		public void computeCentroid(Point3d centroid)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x12CC1B4", Offset = "0x12CC1B4", VA = "0x12CC1B4")]
		public void computeNormal(Vector3d normal, double minArea)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x12CC320", Offset = "0x12CC320", VA = "0x12CC320")]
		public void computeNormal(Vector3d normal)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x12CC490", Offset = "0x12CC490", VA = "0x12CC490")]
		private void computeNormalAndCentroid()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x12CC78C", Offset = "0x12CC78C", VA = "0x12CC78C")]
		private void computeNormalAndCentroid(double minArea)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x12CC7CC", Offset = "0x12CC7CC", VA = "0x12CC7CC")]
		public static Face createTriangle(Vertex v0, Vertex v1, Vertex v2)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x12CC7D4", Offset = "0x12CC7D4", VA = "0x12CC7D4")]
		public static Face createTriangle(Vertex v0, Vertex v1, Vertex v2, double minArea)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x12CCA08", Offset = "0x12CCA08", VA = "0x12CCA08")]
		public static Face create(Vertex[] vtxArray, int[] indices)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x12CC944", Offset = "0x12CC944", VA = "0x12CC944")]
		public Face()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x12CCB78", Offset = "0x12CCB78", VA = "0x12CCB78")]
		public HalfEdge getEdge(int i)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x12CCBB8", Offset = "0x12CCBB8", VA = "0x12CCBB8")]
		public HalfEdge getFirstEdge()
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x12CCBC0", Offset = "0x12CCBC0", VA = "0x12CCBC0")]
		public HalfEdge findEdge(Vertex vt, Vertex vh)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x12CCC30", Offset = "0x12CCC30", VA = "0x12CCC30")]
		public double distanceToPlane(Point3d p)
		{
			return default(double);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x12CCC78", Offset = "0x12CCC78", VA = "0x12CCC78")]
		public Vector3d getNormal()
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x12CCC80", Offset = "0x12CCC80", VA = "0x12CCC80")]
		public Point3d getCentroid()
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x12CCC88", Offset = "0x12CCC88", VA = "0x12CCC88")]
		public int numVertices()
		{
			return default(int);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x12CC6CC", Offset = "0x12CC6CC", VA = "0x12CC6CC")]
		public string getVertexString()
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x12CCC90", Offset = "0x12CCC90", VA = "0x12CCC90")]
		public void getVertexIndices(int[] idxs)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x12CCCE8", Offset = "0x12CCCE8", VA = "0x12CCCE8")]
		private Face connectHalfEdges(HalfEdge hedgePrev, HalfEdge hedge)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x12CCE88", Offset = "0x12CCE88", VA = "0x12CCE88")]
		public void checkConsistency()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x12CD65C", Offset = "0x12CD65C", VA = "0x12CD65C")]
		public int mergeAdjacentFace(HalfEdge hedgeAdj, Face[] discarded)
		{
			return default(int);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x12CD868", Offset = "0x12CD868", VA = "0x12CD868")]
		private double areaSquared(HalfEdge hedge0, HalfEdge hedge1)
		{
			return default(double);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x12CD930", Offset = "0x12CD930", VA = "0x12CD930")]
		public void triangulate(FaceList newFaces, double minArea)
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class FaceList
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Face head;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Face tail;

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x12CDB20", Offset = "0x12CDB20", VA = "0x12CDB20")]
		public void clear()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x12CDB48", Offset = "0x12CDB48", VA = "0x12CDB48")]
		public void add(Face vtx)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x12CDBA8", Offset = "0x12CDBA8", VA = "0x12CDBA8")]
		public Face first()
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x12CDBB0", Offset = "0x12CDBB0", VA = "0x12CDBB0")]
		public bool isEmpty()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x12CDBC0", Offset = "0x12CDBC0", VA = "0x12CDBC0")]
		public FaceList()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class HalfEdge
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vertex vertex;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Face face;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HalfEdge next;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HalfEdge prev;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HalfEdge opposite;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x12CDBC8", Offset = "0x12CDBC8", VA = "0x12CDBC8")]
		public HalfEdge(Vertex v, Face f)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x12CDC0C", Offset = "0x12CDC0C", VA = "0x12CDC0C")]
		public HalfEdge()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x12CDC14", Offset = "0x12CDC14", VA = "0x12CDC14")]
		public void setNext(HalfEdge edge)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x12CDC1C", Offset = "0x12CDC1C", VA = "0x12CDC1C")]
		public HalfEdge getNext()
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x12CDC24", Offset = "0x12CDC24", VA = "0x12CDC24")]
		public void setPrev(HalfEdge edge)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x12CDC2C", Offset = "0x12CDC2C", VA = "0x12CDC2C")]
		public HalfEdge getPrev()
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x12CDC34", Offset = "0x12CDC34", VA = "0x12CDC34")]
		public Face getFace()
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x12CDC3C", Offset = "0x12CDC3C", VA = "0x12CDC3C")]
		public HalfEdge getOpposite()
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x12CDC44", Offset = "0x12CDC44", VA = "0x12CDC44")]
		public void setOpposite(HalfEdge edge)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x12CDC7C", Offset = "0x12CDC7C", VA = "0x12CDC7C")]
		public Vertex head()
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x12CDC84", Offset = "0x12CDC84", VA = "0x12CDC84")]
		public Vertex tail()
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x12CDC9C", Offset = "0x12CDC9C", VA = "0x12CDC9C")]
		public Face oppositeFace()
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x12CDCB4", Offset = "0x12CDCB4", VA = "0x12CDCB4")]
		public string getVertexString()
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x12CDD80", Offset = "0x12CDD80", VA = "0x12CDD80")]
		public double length()
		{
			return default(double);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x12CDE64", Offset = "0x12CDE64", VA = "0x12CDE64")]
		public double lengthSquared()
		{
			return default(double);
		}
	}
	[Token(Token = "0x200002D")]
	public class InternalErrorException : SystemException
	{
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x12CDEE4", Offset = "0x12CDEE4", VA = "0x12CDEE4")]
		public InternalErrorException(string msg)
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class Point3d : Vector3d
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x12CDEEC", Offset = "0x12CDEEC", VA = "0x12CDEEC")]
		public Point3d()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x12CDEFC", Offset = "0x12CDEFC", VA = "0x12CDEFC")]
		public Point3d(Vector3d v)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x12CDF5C", Offset = "0x12CDF5C", VA = "0x12CDF5C")]
		public Point3d(double x, double y, double z)
		{
		}
	}
	[Token(Token = "0x200002F")]
	internal class QhullTest
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x12CDFA4", Offset = "0x12CDFA4", VA = "0x12CDFA4")]
		public QhullTest()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class QuickHull3D
	{
		[Token(Token = "0x4000122")]
		public const int CLOCKWISE = 1;

		[Token(Token = "0x4000123")]
		public const int INDEXED_FROM_ONE = 2;

		[Token(Token = "0x4000124")]
		public const int INDEXED_FROM_ZERO = 4;

		[Token(Token = "0x4000125")]
		public const int POINT_RELATIVE = 8;

		[Token(Token = "0x4000126")]
		public const double AUTOMATIC_TOLERANCE = -1.0;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected int findIndex;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected double charLength;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool debug;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Vertex[] pointBuffer;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected int[] vertexPointIndices;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Face[] discardedFaces;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vertex[] maxVtxs;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vertex[] minVtxs;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected List<Face> faces;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected List<HalfEdge> horizon;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FaceList newFaces;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private VertexList unclaimed;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private VertexList claimed;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected int numVertices;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected int numFaces;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected int numPoints;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected double explicitTolerance;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected double tolerance;

		[Token(Token = "0x4000139")]
		private const double DOUBLE_PREC = 2.220446049250313E-16;

		[Token(Token = "0x400013A")]
		private const int NONCONVEX_WRT_LARGER_FACE = 1;

		[Token(Token = "0x400013B")]
		private const int NONCONVEX = 2;

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x12CDFAC", Offset = "0x12CDFAC", VA = "0x12CDFAC")]
		public bool getDebug()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x12CDFB4", Offset = "0x12CDFB4", VA = "0x12CDFB4")]
		public void setDebug(bool enable)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x12CDFC0", Offset = "0x12CDFC0", VA = "0x12CDFC0")]
		public double getDistanceTolerance()
		{
			return default(double);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x12CDFC8", Offset = "0x12CDFC8", VA = "0x12CDFC8")]
		public void setExplicitDistanceTolerance(double tol)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x12CDFD0", Offset = "0x12CDFD0", VA = "0x12CDFD0")]
		public double getExplicitDistanceTolerance()
		{
			return default(double);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x12CDFD8", Offset = "0x12CDFD8", VA = "0x12CDFD8")]
		private void addPointToFace(Vertex vtx, Face face)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x12CE13C", Offset = "0x12CE13C", VA = "0x12CE13C")]
		private void removePointFromFace(Vertex vtx, Face face)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x12CE200", Offset = "0x12CE200", VA = "0x12CE200")]
		private Vertex removeAllPointsFromFace(Face face)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x12CE2E4", Offset = "0x12CE2E4", VA = "0x12CE2E4")]
		public QuickHull3D()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x12CE554", Offset = "0x12CE554", VA = "0x12CE554")]
		public QuickHull3D(double[] coords)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x12CE8CC", Offset = "0x12CE8CC", VA = "0x12CE8CC")]
		public QuickHull3D(Point3d[] points)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x12CEC14", Offset = "0x12CEC14", VA = "0x12CEC14")]
		private HalfEdge findHalfEdge(Vertex tail, Vertex head)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x12CED90", Offset = "0x12CED90", VA = "0x12CED90")]
		protected void setHull(double[] coords, int nump, int[][] faceIndices, int numf)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x12CF684", Offset = "0x12CF684", VA = "0x12CF684")]
		public void build(double[] coords)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x12CE7EC", Offset = "0x12CE7EC", VA = "0x12CE7EC")]
		public void build(double[] coords, int nump)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x12CF6FC", Offset = "0x12CF6FC", VA = "0x12CF6FC")]
		public void build(Point3d[] points)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x12CEB4C", Offset = "0x12CEB4C", VA = "0x12CEB4C")]
		public void build(Point3d[] points, int nump)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x12CF79C", Offset = "0x12CF79C", VA = "0x12CF79C")]
		public void triangulate()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x12CEF14", Offset = "0x12CEF14", VA = "0x12CEF14")]
		protected void initBuffers(int nump)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x12CF164", Offset = "0x12CF164", VA = "0x12CF164")]
		protected void setPoints(double[] coords, int nump)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x12CF714", Offset = "0x12CF714", VA = "0x12CF714")]
		protected void setPoints(Point3d[] pnts, int nump)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x12CF20C", Offset = "0x12CF20C", VA = "0x12CF20C")]
		protected void computeMaxAndMin()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x12CFA8C", Offset = "0x12CFA8C", VA = "0x12CFA8C")]
		protected void createInitialSimplex()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x12D0908", Offset = "0x12D0908", VA = "0x12D0908")]
		public int getNumVertices()
		{
			return default(int);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x12D0910", Offset = "0x12D0910", VA = "0x12D0910")]
		public Point3d[] getVertices()
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x12D0A2C", Offset = "0x12D0A2C", VA = "0x12D0A2C")]
		public int getVertices(double[] coords)
		{
			return default(int);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x12D0AF8", Offset = "0x12D0AF8", VA = "0x12D0AF8")]
		public int[] getVertexPointIndices()
		{
			return null;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x12D0BA0", Offset = "0x12D0BA0", VA = "0x12D0BA0")]
		public int getNumFaces()
		{
			return default(int);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x12D0BE8", Offset = "0x12D0BE8", VA = "0x12D0BE8")]
		public int[][] getFaces()
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x12D0BF0", Offset = "0x12D0BF0", VA = "0x12D0BF0")]
		public int[][] getFaces(int indexFlags)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x12D0E44", Offset = "0x12D0E44", VA = "0x12D0E44")]
		private void getFaceIndices(int[] indices, Face face, int flags)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x12D0EDC", Offset = "0x12D0EDC", VA = "0x12D0EDC")]
		protected void resolveUnclaimedPoints(FaceList newFaces)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x12D0FA0", Offset = "0x12D0FA0", VA = "0x12D0FA0")]
		protected void deleteFacePoints(Face face, Face absorbingFace)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x12D10A8", Offset = "0x12D10A8", VA = "0x12D10A8")]
		protected double oppFaceDistance(HalfEdge he)
		{
			return default(double);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x12D10DC", Offset = "0x12D10DC", VA = "0x12D10DC")]
		private bool doAdjacentMerge(Face face, int mergeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x12D1250", Offset = "0x12D1250", VA = "0x12D1250")]
		protected void calculateHorizon(Point3d eyePnt, HalfEdge edge0, Face face, List<HalfEdge> horizon)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x12D13BC", Offset = "0x12D13BC", VA = "0x12D13BC")]
		private HalfEdge addAdjoiningFace(Vertex eyeVtx, HalfEdge he)
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x12D14D4", Offset = "0x12D14D4", VA = "0x12D14D4")]
		protected void addNewFaces(FaceList newFaces, Vertex eyeVtx, List<HalfEdge> horizon)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x12D16DC", Offset = "0x12D16DC", VA = "0x12D16DC")]
		protected Vertex nextPointToAdd()
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x12D1770", Offset = "0x12D1770", VA = "0x12D1770")]
		protected void addPointToHull(Vertex eyeVtx)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x12CF6B4", Offset = "0x12CF6B4", VA = "0x12CF6B4")]
		protected void buildHull()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x12D1A94", Offset = "0x12D1A94", VA = "0x12D1A94")]
		private void markFaceVertices(Face face, int mark)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x12D18E8", Offset = "0x12D18E8", VA = "0x12D18E8")]
		protected void reindexFacesAndVertices()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x12D1ACC", Offset = "0x12D1ACC", VA = "0x12D1ACC")]
		protected bool checkFaceConvexity(Face face, double tol)
		{
			return default(bool);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x12D1B70", Offset = "0x12D1B70", VA = "0x12D1B70")]
		protected bool checkFaces(double tol)
		{
			return default(bool);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x12D1CE4", Offset = "0x12D1CE4", VA = "0x12D1CE4")]
		public bool check()
		{
			return default(bool);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x12D1CEC", Offset = "0x12D1CEC", VA = "0x12D1CEC")]
		public bool check(double tol)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000031")]
	public class SimpleExample
	{
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x12D1EF4", Offset = "0x12D1EF4", VA = "0x12D1EF4")]
		public static void main(string[] args)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x12D21FC", Offset = "0x12D21FC", VA = "0x12D21FC")]
		public SimpleExample()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class Vector3d
	{
		[Token(Token = "0x400013C")]
		private const double DOUBLE_PREC = 2.220446049250313E-16;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double x;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double y;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double z;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x12CDEF4", Offset = "0x12CDEF4", VA = "0x12CDEF4")]
		public Vector3d()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x12D2204", Offset = "0x12D2204", VA = "0x12D2204")]
		public Vector3d(Vector3d v)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x12D2240", Offset = "0x12D2240", VA = "0x12D2240")]
		public Vector3d(double x, double y, double z)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x12D06C0", Offset = "0x12D06C0", VA = "0x12D06C0")]
		public double get(int i)
		{
			return default(double);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x12D227C", Offset = "0x12D227C", VA = "0x12D227C")]
		public void set(int i, double value)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x12CDF38", Offset = "0x12CDF38", VA = "0x12CDF38")]
		public void set(Vector3d v1)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x12D2324", Offset = "0x12D2324", VA = "0x12D2324")]
		public void add(Vector3d v1, Vector3d v2)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x12D235C", Offset = "0x12D235C", VA = "0x12D235C")]
		public void add(Vector3d v1)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x12D0768", Offset = "0x12D0768", VA = "0x12D0768")]
		public void sub(Vector3d v1, Vector3d v2)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x12D2390", Offset = "0x12D2390", VA = "0x12D2390")]
		public void sub(Vector3d v1)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x12D23C4", Offset = "0x12D23C4", VA = "0x12D23C4")]
		public void scale(double s)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x12D23E0", Offset = "0x12D23E0", VA = "0x12D23E0")]
		public void scale(double s, Vector3d v1)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x12D240C", Offset = "0x12D240C", VA = "0x12D240C")]
		public double norm()
		{
			return default(double);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x12D08B0", Offset = "0x12D08B0", VA = "0x12D08B0")]
		public double normSquared()
		{
			return default(double);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x12CDDC0", Offset = "0x12CDDC0", VA = "0x12CDDC0")]
		public double distance(Vector3d v)
		{
			return default(double);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x12CDEA4", Offset = "0x12CDEA4", VA = "0x12CDEA4")]
		public double distanceSquared(Vector3d v)
		{
			return default(double);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x12D08D0", Offset = "0x12D08D0", VA = "0x12D08D0")]
		public double dot(Vector3d v1)
		{
			return default(double);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x12D07A0", Offset = "0x12D07A0", VA = "0x12D07A0")]
		public void normalize()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x12D248C", Offset = "0x12D248C", VA = "0x12D248C")]
		public void setZero()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x12CDF98", Offset = "0x12CDF98", VA = "0x12CDF98")]
		public void set(double x, double y, double z)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x12D085C", Offset = "0x12D085C", VA = "0x12D085C")]
		public void cross(Vector3d v1, Vector3d v2)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x12D2498", Offset = "0x12D2498", VA = "0x12D2498")]
		protected void setRandom(double lower, double upper, System.Random generator)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x12D2520", Offset = "0x12D2520", VA = "0x12D2520")]
		public string toString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000033")]
	public class Vertex
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Point3d pnt;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vertex prev;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vertex next;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Face face;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x12CF9F0", Offset = "0x12CF9F0", VA = "0x12CF9F0")]
		public Vertex()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x12D2704", Offset = "0x12D2704", VA = "0x12D2704")]
		public Vertex(double x, double y, double z, int idx)
		{
		}
	}
	[Token(Token = "0x2000034")]
	internal class VertexList
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vertex head;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vertex tail;

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x12CFA64", Offset = "0x12CFA64", VA = "0x12CFA64")]
		public void clear()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x12CE048", Offset = "0x12CE048", VA = "0x12CE048")]
		public void add(Vertex vtx)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x12D1040", Offset = "0x12D1040", VA = "0x12D1040")]
		public void addAll(Vertex vtx)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x12CE1A8", Offset = "0x12CE1A8", VA = "0x12CE1A8")]
		public void delete(Vertex vtx)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x12CE274", Offset = "0x12CE274", VA = "0x12CE274")]
		public void delete(Vertex vtx1, Vertex vtx2)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x12CE0B8", Offset = "0x12CE0B8", VA = "0x12CE0B8")]
		public void insertBefore(Vertex vtx, Vertex next)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x12D27B0", Offset = "0x12D27B0", VA = "0x12D27B0")]
		public Vertex first()
		{
			return null;
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x12D1760", Offset = "0x12D1760", VA = "0x12D1760")]
		public bool isEmpty()
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x12CE54C", Offset = "0x12CE54C", VA = "0x12CE54C")]
		public VertexList()
		{
		}
	}
}
namespace UnityStandardAssets.SceneUtils
{
	[Token(Token = "0x2000035")]
	public class PlaceTargetWithMouse : MonoBehaviour
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float surfaceOffset;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject setTargetOn;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x12D27B8", Offset = "0x12D27B8", VA = "0x12D27B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x12D28E4", Offset = "0x12D28E4", VA = "0x12D28E4")]
		public PlaceTargetWithMouse()
		{
		}
	}
}
namespace Dynamite3D.RealIvy
{
	[Token(Token = "0x2000036")]
	public class IvyCaster : MonoBehaviour
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IvyPreset[] ivyPresets;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<IvyController> ivys;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IvyController prefabIvyController;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x12D28F4", Offset = "0x12D28F4", VA = "0x12D28F4")]
		public void CastIvyByPresetName(string presetName, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x12D2A04", Offset = "0x12D2A04", VA = "0x12D2A04")]
		public void CastIvy(IvyPreset ivyPreset, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x12D2D54", Offset = "0x12D2D54", VA = "0x12D2D54")]
		public void CastRandomIvy(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x12D2C94", Offset = "0x12D2C94", VA = "0x12D2C94")]
		private IvyController GetFreeIvy()
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x12D2968", Offset = "0x12D2968", VA = "0x12D2968")]
		private IvyPreset GetPresetByName(string presetName)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x12D2DFC", Offset = "0x12D2DFC", VA = "0x12D2DFC")]
		public IvyCaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class BranchContainer : ScriptableObject
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<BranchPoint> branchPoints;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 growDirection;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<LeafPoint> leaves;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float totalLenght;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float fallIteration;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool falling;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Quaternion rotationOnFallIteration;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int branchSense;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float heightParameter;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float randomizeHeight;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float heightVar;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float currentHeight;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float deltaHeight;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float newHeight;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public BranchPoint originPointOfThisBranch;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int branchNumber;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Dictionary<int, List<LeafPoint>> dictRTLeavesByInitSegment;

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x12D2E04", Offset = "0x12D2E04", VA = "0x12D2E04")]
		public int GetNumLeaves()
		{
			return default(int);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x12D2E4C", Offset = "0x12D2E4C", VA = "0x12D2E4C")]
		public void SetValues(Vector3 growDirection, float randomizeHeight, float currentHeight, float heightParameter, int branchSense, BranchPoint originPointOfThisBranch)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x12D2FE8", Offset = "0x12D2FE8", VA = "0x12D2FE8")]
		public void AddBranchPoint(BranchPoint branchPoint, float length, float stepSize)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x12D30AC", Offset = "0x12D30AC", VA = "0x12D30AC")]
		public void Init(int branchPointsSize, int numLeaves)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x12D3190", Offset = "0x12D3190", VA = "0x12D3190")]
		public void Init()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x12D319C", Offset = "0x12D319C", VA = "0x12D319C")]
		public void PrepareRTLeavesDict()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x12D343C", Offset = "0x12D343C", VA = "0x12D343C")]
		public void UpdateLeavesDictEntry(int initSegmentIdx, LeafPoint leaf)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x12D3624", Offset = "0x12D3624", VA = "0x12D3624")]
		public void AddBranchPoint(BranchPoint branchPoint)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x12D371C", Offset = "0x12D371C", VA = "0x12D371C")]
		public void AddBranchPoint(Vector3 point, Vector3 grabVector)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x12D3728", Offset = "0x12D3728", VA = "0x12D3728")]
		public void AddBranchPoint(Vector3 point, Vector3 grabVector, bool isNewBranch, int newBranchIndex)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x12D3990", Offset = "0x12D3990", VA = "0x12D3990")]
		public BranchPoint InsertBranchPoint(Vector3 point, Vector3 grabVector, int index)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x12D3C08", Offset = "0x12D3C08", VA = "0x12D3C08")]
		public void GetLeavesInSegmentRT(int initSegmentIdx, int endSegmentIdx, List<LeafPoint> res)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x12D3304", Offset = "0x12D3304", VA = "0x12D3304")]
		public void GetLeavesInSegment(BranchPoint initSegment, List<LeafPoint> res)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x12D3CE4", Offset = "0x12D3CE4", VA = "0x12D3CE4")]
		public List<LeafPoint> GetLeavesInSegment(BranchPoint initSegment)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x12D3D74", Offset = "0x12D3D74", VA = "0x12D3D74")]
		public LeafPoint AddRandomLeaf(Vector3 pointWS, BranchPoint initSegment, BranchPoint endSegment, int leafIndex, InfoPool infoPool)
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x12D4034", Offset = "0x12D4034", VA = "0x12D4034")]
		public void RepositionLeavesAfterAdd02(BranchPoint newPoint)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x12D466C", Offset = "0x12D466C", VA = "0x12D466C")]
		public void RepositionLeavesAfterRemove02(BranchPoint removedPoint)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x12D49A0", Offset = "0x12D49A0", VA = "0x12D49A0")]
		public void RemoveBranchPoint(int indexToRemove)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x12D4B7C", Offset = "0x12D4B7C", VA = "0x12D4B7C")]
		public void RemoveRange(int index, int count)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x12D4DF0", Offset = "0x12D4DF0", VA = "0x12D4DF0")]
		public BranchPoint GetNearestPointFrom(Vector3 from)
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x12D4EFC", Offset = "0x12D4EFC", VA = "0x12D4EFC")]
		public BranchPoint GetNearestPointWSFrom(Vector3 from)
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x12D5008", Offset = "0x12D5008", VA = "0x12D5008")]
		public BranchPoint GetNearestPointSSFrom(Vector2 from)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x12D50F8", Offset = "0x12D50F8", VA = "0x12D50F8")]
		public Vector3[] GetSegmentPoints(Vector3 worldPoint)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x12D534C", Offset = "0x12D534C", VA = "0x12D534C")]
		public BranchPoint GetLastBranchPoint()
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x12D53B0", Offset = "0x12D53B0", VA = "0x12D53B0")]
		public void AddLeaf(LeafPoint leafPoint)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x12D5460", Offset = "0x12D5460", VA = "0x12D5460")]
		public LeafPoint AddLeaf(Vector3 leafPoint, float lpLength, Vector3 lpForward, Vector3 lpUpward, int chosenLeave, BranchPoint initSegment, BranchPoint endSegment)
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x12D3F0C", Offset = "0x12D3F0C", VA = "0x12D3F0C")]
		public LeafPoint InsertLeaf(Vector3 leafPoint, float lpLength, Vector3 lpForward, Vector3 lpUpward, int chosenLeave, int leafIndex, BranchPoint initSegment, BranchPoint endSegment)
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x12D55D4", Offset = "0x12D55D4", VA = "0x12D55D4")]
		public void RemoveLeaves(List<LeafPoint> leaves)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x12D5698", Offset = "0x12D5698", VA = "0x12D5698")]
		public void DrawLeavesVectors(List<BranchPoint> branchPointsToFilter)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x12D5724", Offset = "0x12D5724", VA = "0x12D5724")]
		public void GetInitIdxEndIdxLeaves(int initIdxBranchPoint, float stepSize, out int initIdxLeaves, out int endIdxLeaves)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x12D5834", Offset = "0x12D5834", VA = "0x12D5834")]
		public void ReleasePoint(int indexPoint)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x12D58C8", Offset = "0x12D58C8", VA = "0x12D58C8")]
		public void GetInitIdxEndIdxLeaves(int initIdxBranchPoint, int endIdxBranchPoint, float stepSize, out int initIdxLeaves, out int endIdxLeaves)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x12D59E4", Offset = "0x12D59E4", VA = "0x12D59E4")]
		public BranchContainer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public class BranchPoint
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 originalPoint;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 point;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 grabVector;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 pointSS;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float length;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 initialGrowDir;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BranchContainer branchContainer;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int index;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool newBranch;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int newBranchNumber;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float radius;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float currentRadius;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Quaternion forwardRotation;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<RTVertexData> verticesLoop;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Vector3 firstVector;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Vector3 axis;

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x12D59EC", Offset = "0x12D59EC", VA = "0x12D59EC")]
		public void SetValues(Vector3 point, Vector3 grabVector, Vector2 pointSS, BranchContainer branchContainer, int index, bool blocked, bool newBranch, int newBranchNumber, float length)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x12D5BF0", Offset = "0x12D5BF0", VA = "0x12D5BF0")]
		public BranchPoint()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x12D5BF8", Offset = "0x12D5BF8", VA = "0x12D5BF8")]
		public void InitializeRuntime(IvyParameters ivyParameters)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x12D38A0", Offset = "0x12D38A0", VA = "0x12D38A0")]
		public BranchPoint(Vector3 point, Vector3 grabVector, int index, bool newBranch, int newBranchNumber, float length, BranchContainer branchContainer)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x12D3B28", Offset = "0x12D3B28", VA = "0x12D3B28")]
		public BranchPoint(Vector3 point, Vector3 grabVector, int index, float length, BranchContainer branchContainer)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x12D5C84", Offset = "0x12D5C84", VA = "0x12D5C84")]
		public BranchPoint(Vector3 point, int index, float length, BranchContainer branchContainer)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x12D5D48", Offset = "0x12D5D48", VA = "0x12D5D48")]
		public void SetOriginalPoint()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x12D45E0", Offset = "0x12D45E0", VA = "0x12D45E0")]
		public BranchPoint GetNextPoint()
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x12D456C", Offset = "0x12D456C", VA = "0x12D456C")]
		public BranchPoint GetPreviousPoint()
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x12D5D5C", Offset = "0x12D5D5C", VA = "0x12D5D5C")]
		public void Move(Vector3 newPosition)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x12D5D68", Offset = "0x12D5D68", VA = "0x12D5D68")]
		public void InitBranchInThisPoint(int branchNumber)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x12D58B8", Offset = "0x12D58B8", VA = "0x12D58B8")]
		public void ReleasePoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class BranchSegment
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<LeafPoint> leaves;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BranchPoint initSegment;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BranchPoint endSegment;

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x12D5D78", Offset = "0x12D5D78", VA = "0x12D5D78")]
		public BranchSegment()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public static class Constants
	{
		[Token(Token = "0x4000170")]
		public const string EXTENSION_PREFAB = "prefab";

		[Token(Token = "0x4000171")]
		public const string LABEL_IVY_PRESET = "IvyPreset";

		[Token(Token = "0x4000172")]
		public const int VERTEX_LIMIT_16 = 65535;

		[Token(Token = "0x4000173")]
		public const int VERTEX_LIMIT_32 = 4000000;

		[Token(Token = "0x4000174")]
		public const string IVY_MESH_NAME = "IvyMesh";

		[Token(Token = "0x4000175")]
		public const string NO_IVY_SELECTED_MESSAGE = "Select or create an editable ivy first.";

		[Token(Token = "0x4000176")]
		public const string CANNOT_EDIT_GROWING_IVY = "Can't edit a growing ivy.";

		[Token(Token = "0x4000177")]
		public const string CONFIRM_SAVE_IVY = "Saving the ivy means that editability will be lost. Are you sure?";

		[Token(Token = "0x4000178")]
		public const string LIGHTMAP_UVS_WARNING = "Lightmap UVs will be generated when you save the ivy either in a scene or as prefab.";

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static GUIContent TOOL_PAINT_GUICONTENT;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static GUIContent TOOL_MOVE_GUICONTENT;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static GUIContent TOOL_SMOOTH_GUICONTENT;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static GUIContent TOOL_REFINE_GUICONTENT;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static GUIContent TOOL_OPTIMIZE_GUICONTENT;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static GUIContent TOOL_CUT_GUICONTENT;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static GUIContent TOOL_DELETE_GUICONTENT;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static GUIContent TOOL_SHAVE_GUICONTENT;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static GUIContent TOOL_ADDLEAVE_GUICONTENT;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static GUIContent TOOL_TOGGLEPANEL_GUICONTENT;
	}
	[Token(Token = "0x200003B")]
	public class EditorIvyGrowth : GrowthBuilder
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEngine.Random.State randomstate;

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x12D5D80", Offset = "0x12D5D80", VA = "0x12D5D80")]
		public void Initialize(Vector3 firstPoint, Vector3 firstGrabVector)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x12D616C", Offset = "0x12D616C", VA = "0x12D616C")]
		private void CalculateNewHeight(BranchContainer branch)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x12D6250", Offset = "0x12D6250", VA = "0x12D6250")]
		private int ChooseBranchSense()
		{
			return default(int);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x12D6274", Offset = "0x12D6274", VA = "0x12D6274")]
		public void Step()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x12D6368", Offset = "0x12D6368", VA = "0x12D6368")]
		private void CalculateNewPoint(BranchContainer branch)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x12D63BC", Offset = "0x12D63BC", VA = "0x12D63BC")]
		private void CheckWall(BranchContainer branch)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x12D6864", Offset = "0x12D6864", VA = "0x12D6864")]
		private void CheckFloor(BranchContainer branch, BranchPoint potentialPoint, Vector3 oldSurfaceNormal)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x12D6F84", Offset = "0x12D6F84", VA = "0x12D6F84")]
		private void CheckCorner(BranchContainer branch, BranchPoint potentialPoint, Vector3 oldSurfaceNormal)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x12D6670", Offset = "0x12D6670", VA = "0x12D6670")]
		private void CheckFall(BranchContainer branch)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x12D756C", Offset = "0x12D756C", VA = "0x12D756C")]
		private void CheckGrabPoint(BranchContainer branch)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x12D6BAC", Offset = "0x12D6BAC", VA = "0x12D6BAC")]
		public void AddPoint(BranchContainer branch, Vector3 point, Vector3 normal)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x12D71CC", Offset = "0x12D71CC", VA = "0x12D71CC")]
		private void AddFallingPoint(BranchContainer branch)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x12D8064", Offset = "0x12D8064", VA = "0x12D8064")]
		private void AddLeave(BranchContainer branch)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x12D82F4", Offset = "0x12D82F4", VA = "0x12D82F4")]
		public void DeleteLastBranch()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x12D7DDC", Offset = "0x12D7DDC", VA = "0x12D7DDC")]
		public void AddBranch(BranchContainer branch, BranchPoint originBranchPoint, Vector3 point, Vector3 normal)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x12D6D48", Offset = "0x12D6D48", VA = "0x12D6D48")]
		private void NewGrowDirection(BranchContainer branch)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x12D6A20", Offset = "0x12D6A20", VA = "0x12D6A20")]
		private void NewGrowDirectionAfterWall(BranchContainer branch, Vector3 oldSurfaceNormal, Vector3 newSurfaceNormal)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x12D7820", Offset = "0x12D7820", VA = "0x12D7820")]
		private void NewGrowDirectionFalling(BranchContainer branch)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x12D7AB4", Offset = "0x12D7AB4", VA = "0x12D7AB4")]
		private void NewGrowDirectionAfterFall(BranchContainer branch, Vector3 newSurfaceNormal)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x12D7C58", Offset = "0x12D7C58", VA = "0x12D7C58")]
		private void NewGrowDirectionAfterGrab(BranchContainer branch, Vector3 newSurfaceNormal)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x12D73D4", Offset = "0x12D73D4", VA = "0x12D73D4")]
		private void NewGrowDirectionAfterCorner(BranchContainer branch, Vector3 oldSurfaceNormal, Vector3 newSurfaceNormal)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x12D8368", Offset = "0x12D8368", VA = "0x12D8368")]
		private void Refine(BranchContainer branch)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x12D8924", Offset = "0x12D8924", VA = "0x12D8924")]
		public void Optimize()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x12D8E28", Offset = "0x12D8E28", VA = "0x12D8E28")]
		public EditorIvyGrowth()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class EditorMeshBuilder : ScriptableObject
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InfoPool infoPool;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mesh ivyMesh;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<int, int[]> branchesLeavesIndices;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] verts;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] normals;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2[] uvs;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color[] vColor;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int[] trisBranches;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<List<int>> trisLeaves;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float angle;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<Material> leavesMaterials;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<List<int>> typesByMat;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Rect[] uv2Rects;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool leavesDataInitialized;

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x12D8E38", Offset = "0x12D8E38", VA = "0x12D8E38")]
		public void InitLeavesData()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x12D957C", Offset = "0x12D957C", VA = "0x12D957C")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x12D9BD4", Offset = "0x12D9BD4", VA = "0x12D9BD4")]
		private void BuildLeaves(int b, ref int vertCount)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x12DADD8", Offset = "0x12DADD8", VA = "0x12DADD8")]
		public void BuildGeometry()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x12DC0F8", Offset = "0x12DC0F8", VA = "0x12DC0F8")]
		private Vector3[] CalculateVectors(Vector3 branchPoint, int p, int b)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x12DC098", Offset = "0x12DC098", VA = "0x12DC098")]
		private float CalculateRadius(float lenght, float totalLenght)
		{
			return default(float);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x12DC864", Offset = "0x12DC864", VA = "0x12DC864")]
		private float GetTipInfluence(float lenght, float totalLenght)
		{
			return default(float);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x12DC8D0", Offset = "0x12DC8D0", VA = "0x12DC8D0")]
		private void TriangulateBranch(int b, ref int triCount, int vertCount, int lastVertCount)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x12DCB70", Offset = "0x12DCB70", VA = "0x12DCB70")]
		public EditorMeshBuilder()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class GrowthBuilder : ScriptableObject
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InfoPool infoPool;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 origin;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool growing;

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x12D8E30", Offset = "0x12D8E30", VA = "0x12D8E30")]
		public GrowthBuilder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public class InfoPool : ScriptableObject
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IvyContainer ivyContainer;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EditorMeshBuilder meshBuilder;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IvyParameters ivyParameters;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EditorIvyGrowth growth;

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x12DCC28", Offset = "0x12DCC28", VA = "0x12DCC28")]
		public InfoPool()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class IvyParameterInt : IvyParameter
	{
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x12DCC30", Offset = "0x12DCC30", VA = "0x12DCC30")]
		public IvyParameterInt(int value)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x12DCC64", Offset = "0x12DCC64", VA = "0x12DCC64", Slot = "4")]
		public override void UpdateValue(float value)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x12DCC8C", Offset = "0x12DCC8C", VA = "0x12DCC8C")]
		public static implicit operator int(IvyParameterInt intParameter)
		{
			return default(int);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x12DCCBC", Offset = "0x12DCCBC", VA = "0x12DCCBC")]
		public static implicit operator IvyParameterInt(int intValue)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class IvyParameterFloat : IvyParameter
	{
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x12DCD24", Offset = "0x12DCD24", VA = "0x12DCD24")]
		public IvyParameterFloat(float value)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x12DCD4C", Offset = "0x12DCD4C", VA = "0x12DCD4C", Slot = "4")]
		public override void UpdateValue(float value)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x12DCD54", Offset = "0x12DCD54", VA = "0x12DCD54")]
		public static implicit operator float(IvyParameterFloat floatParameter)
		{
			return default(float);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x12DCD6C", Offset = "0x12DCD6C", VA = "0x12DCD6C")]
		public static implicit operator IvyParameterFloat(float floatValue)
		{
			return null;
		}
	}
	[Token(Token = "0x2000041")]
	public abstract class IvyParameter
	{
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float value;

		[Token(Token = "0x60001A7")]
		public abstract void UpdateValue(float value);

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x12DCC5C", Offset = "0x12DCC5C", VA = "0x12DCC5C")]
		protected IvyParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class IvyParametersGUI : ScriptableObject
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IvyParameterFloat stepSize;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IvyParameterFloat branchProvability;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IvyParameterInt maxBranchs;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LayerMask layerMask;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IvyParameterFloat minDistanceToSurface;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IvyParameterFloat maxDistanceToSurface;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IvyParameterFloat DTSFrequency;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IvyParameterFloat DTSRandomness;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IvyParameterFloat directionFrequency;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public IvyParameterFloat directionAmplitude;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IvyParameterFloat directionRandomness;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IvyParameterFloat gravityX;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IvyParameterFloat gravityY;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IvyParameterFloat gravityZ;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IvyParameterFloat grabProvabilityOnFall;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IvyParameterFloat stiffness;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IvyParameterFloat optAngleBias;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IvyParameterInt leaveEvery;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IvyParameterInt randomLeaveEvery;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool buffer32Bits;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool halfgeom;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public IvyParameterInt sides;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public IvyParameterFloat minRadius;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IvyParameterFloat maxRadius;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public IvyParameterFloat radiusVarFreq;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public IvyParameterFloat radiusVarOffset;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public IvyParameterFloat tipInfluence;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public IvyParameterFloat uvScaleX;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public IvyParameterFloat uvScaleY;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public IvyParameterFloat uvOffsetX;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public IvyParameterFloat uvOffsetY;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public IvyParameterFloat minScale;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public IvyParameterFloat maxScale;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool globalOrientation;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public IvyParameterFloat globalRotationX;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public IvyParameterFloat globalRotationY;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public IvyParameterFloat globalRotationZ;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public IvyParameterFloat rotationX;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public IvyParameterFloat rotationY;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public IvyParameterFloat rotationZ;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public IvyParameterFloat randomRotationX;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public IvyParameterFloat randomRotationY;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public IvyParameterFloat randomRotationZ;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public IvyParameterFloat offsetX;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public IvyParameterFloat offsetY;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public IvyParameterFloat offsetZ;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public float LMUVPadding;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public Material branchesMaterial;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public List<GameObject> leavesPrefabs;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public List<float> leavesProb;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public bool generateBranches;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A1")]
		public bool generateLeaves;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A2")]
		public bool generateLightmapUVs;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x12DCDD8", Offset = "0x12DCDD8", VA = "0x12DCDD8")]
		public void CopyFrom(IvyPreset ivyPreset)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x12DCDF0", Offset = "0x12DCDF0", VA = "0x12DCDF0")]
		public void CopyFrom(IvyParameters copyFrom)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x12DD478", Offset = "0x12DD478", VA = "0x12DD478")]
		public IvyParametersGUI()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class IvyContainer : ScriptableObject
	{
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int lastNumberAssigned;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject ivyGO;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<BranchContainer> branches;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 firstVertexVector;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x12DD9AC", Offset = "0x12DD9AC", VA = "0x12DD9AC")]
		private IvyContainer()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x12DDA3C", Offset = "0x12DDA3C", VA = "0x12DDA3C")]
		public void Clear()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x12DDAB0", Offset = "0x12DDAB0", VA = "0x12DDAB0")]
		public void RemoveBranch(BranchContainer branchToDelete)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x12DDB24", Offset = "0x12DDB24", VA = "0x12DDB24")]
		public BranchContainer GetBranchContainerByBranchNumber(int branchNumber)
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x12DDBE8", Offset = "0x12DDBE8", VA = "0x12DDBE8")]
		public BranchPoint[] GetNearestSegmentSSBelowDistance(Vector2 pointSS, float distanceThreshold)
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x12DDE38", Offset = "0x12DDE38", VA = "0x12DDE38")]
		public BranchPoint[] GetNearestSegmentSS(Vector2 pointSS)
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x12D60A8", Offset = "0x12D60A8", VA = "0x12D60A8")]
		public void AddBranch(BranchContainer newBranchContainer)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x12DDE44", Offset = "0x12DDE44", VA = "0x12DDE44")]
		public BranchPoint GetNearestPointAllBranchesSSFrom(Vector2 pointSS)
		{
			return null;
		}
	}
	[Token(Token = "0x2000044")]
	public class IvyInfo : MonoBehaviour
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IvyPreset originalPreset;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InfoPool infoPool;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MeshFilter meshFilter;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MeshRenderer meshRenderer;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x12DDFCC", Offset = "0x12DDFCC", VA = "0x12DDFCC")]
		public void Setup(InfoPool infoPool, MeshFilter meshFilter, MeshRenderer meshRenderer, IvyPreset originalPreset)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x12DE02C", Offset = "0x12DE02C", VA = "0x12DE02C")]
		public IvyInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class IvyParameters
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float stepSize;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int randomSeed;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float branchProvability;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxBranchs;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask layerMask;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minDistanceToSurface;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float maxDistanceToSurface;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float DTSFrequency;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float DTSRandomness;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float directionFrequency;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float directionAmplitude;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float directionRandomness;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 gravity;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float grabProvabilityOnFall;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stiffness;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float optAngleBias;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int leaveEvery;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int randomLeaveEvery;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool buffer32Bits;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool halfgeom;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int sides;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float minRadius;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float maxRadius;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float radiusVarFreq;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float radiusVarOffset;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float tipInfluence;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector2 uvScale;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector2 uvOffset;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float minScale;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float maxScale;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool globalOrientation;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Vector3 globalRotation;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public Vector3 rotation;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Vector3 randomRotation;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Vector3 offset;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float LMUVPadding;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Material branchesMaterial;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public GameObject[] leavesPrefabs;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float[] leavesProb;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Dictionary<int, Vector2> UV2IslesSizes;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public bool generateBranches;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		public bool generateLeaves;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		public bool generateLightmapUVs;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x12DE034", Offset = "0x12DE034", VA = "0x12DE034")]
		public IvyParameters()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x12DE21C", Offset = "0x12DE21C", VA = "0x12DE21C")]
		public IvyParameters(IvyParameters copyFrom)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x12DE6D4", Offset = "0x12DE6D4", VA = "0x12DE6D4")]
		public void CopyFrom(IvyPreset ivyPreset)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x12DE6EC", Offset = "0x12DE6EC", VA = "0x12DE6EC")]
		public void CopyFrom(IvyParametersGUI copyFrom)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x12DE41C", Offset = "0x12DE41C", VA = "0x12DE41C")]
		public void CopyFrom(IvyParameters copyFrom)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x12DEC04", Offset = "0x12DEC04", VA = "0x12DEC04")]
		public bool IsEqualTo(IvyParameters compareTo)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class IvyPreset : ScriptableObject
	{
		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string presetName;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IvyParameters ivyParameters;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x12DF028", Offset = "0x12DF028", VA = "0x12DF028")]
		public void CopyFrom(IvyParametersGUI copyFrom)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x12DF044", Offset = "0x12DF044", VA = "0x12DF044")]
		public IvyPreset()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class LeafPoint
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 point;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 pointSS;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float lpLength;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 left;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 lpForward;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 lpUpward;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chosenLeave;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Quaternion forwarRot;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int initSegmentIdx;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int endSegmentIdx;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float displacementFromInitSegment;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Quaternion leafRotation;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float currentScale;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float dstScale;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leafCenter;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<RTVertexData> verticesLeaves;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float leafScale;

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x12DF04C", Offset = "0x12DF04C", VA = "0x12DF04C")]
		public void InitializeRuntime()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x12DF0CC", Offset = "0x12DF0CC", VA = "0x12DF0CC")]
		public LeafPoint()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x12DF0D4", Offset = "0x12DF0D4", VA = "0x12DF0D4")]
		public LeafPoint(Vector3 point, float lpLength, Vector3 lpForward, Vector3 lpUpward, int chosenLeave, BranchPoint initSegment, BranchPoint endSegment)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x12DF178", Offset = "0x12DF178", VA = "0x12DF178")]
		public void SetValues(Vector3 point, float lpLength, Vector3 lpForward, Vector3 lpUpward, int chosenLeave, BranchPoint initSegment, BranchPoint endSegment)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x12DF42C", Offset = "0x12DF42C", VA = "0x12DF42C")]
		public void DrawVectors()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x12DF578", Offset = "0x12DF578", VA = "0x12DF578")]
		public float GetLengthFactor(BranchContainer branchContainer, float correctionFactor)
		{
			return default(float);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x12DF5B4", Offset = "0x12DF5B4", VA = "0x12DF5B4")]
		public void CreateVertices(IvyParameters ivyParameters, RTMeshData leafMeshData, GameObject ivyGO)
		{
		}
	}
	[Token(Token = "0x2000048")]
	public static class RealIvyMathUtils
	{
		[Token(Token = "0x2000049")]
		public struct Segment
		{
			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 a;

			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector2 b;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x12DFFD0", Offset = "0x12DFFD0", VA = "0x12DFFD0")]
		public static float DistanceBetweenPointAndSegmentSS(Vector2 point, Vector2 a, Vector2 b)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200004A")]
	public class RTBakedMeshBuilder
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IvyParameters ivyParameters;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RTIvyContainer rtIvyContainer;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RTIvyContainer rtBakedIvyContainer;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject ivyGO;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MeshRenderer meshRenderer;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MeshFilter meshFilter;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool onOptimizedStretch;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MeshFilter leavesMeshFilter;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MeshRenderer leavesMeshRenderer;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer mrProcessedMesh;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Mesh processedMesh;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Mesh ivyMesh;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<RTBranchContainer> activeBranches;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public RTMeshData bakedMeshData;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public RTMeshData buildingMeshData;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public RTMeshData processedMeshData;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<List<int>> processedVerticesIndicesPerBranch;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<List<int>> processedBranchesVerticesIndicesPerBranch;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int[] vertCountsPerBranch;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int[] lastTriangleIndexPerBranch;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int[] vertCountLeavesPerBranch;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int lastPointCopied;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int vertCount;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastVertCount;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int triCount;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int lastVerticesCountProcessed;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int lastLeafVertProcessed;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int submeshCount;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int[] submeshByChoseLeaf;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int initIdxLeaves;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int endIdxLeaves;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int backtrackingPoints;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int[] fromTo;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3[] vectors;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RTMeshData[] leavesMeshesByChosenLeaf;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int lastVertexIndex;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private float angle;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public List<Material> leavesMaterials;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public List<List<int>> typesByMat;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Rect[] uv2Rects;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool leavesDataInitialized;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float growthSpeed;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float leafLengthCorrrectionFactor;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 ivyGoPosition;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Quaternion ivyGoRotation;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Quaternion ivyGoInverseRotation;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 zeroVector3;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector2 zeroVector2;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private Color blackColor;

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x12E0054", Offset = "0x12E0054", VA = "0x12E0054")]
		public void InitializeMeshBuilder(IvyParameters ivyParameters, RTIvyContainer ivyContainer, RTIvyContainer bakedIvyContainer, GameObject ivyGO, Mesh bakedMesh, MeshRenderer meshRenderer, MeshFilter meshFilter, int numBranches, Mesh processedMesh, float growSpeed, MeshRenderer mrProcessedMesh, int backtrackingPoints, int[] submeshByChoseLeaf, RTMeshData[] leavesMeshesByChosenLeaf, Material[] materials)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x12E081C", Offset = "0x12E081C", VA = "0x12E081C")]
		public void InitializeMeshesDataBaked(Mesh bakedMesh, int numBranches)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x12E0C60", Offset = "0x12E0C60", VA = "0x12E0C60")]
		public void InitializeMeshesDataProcedural(Mesh bakedMesh, int numBranches, float lifetime, float velocity)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x12E0864", Offset = "0x12E0864", VA = "0x12E0864")]
		public void CreateBuildingMeshData(Mesh bakedMesh, int numBranches)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x12E0A68", Offset = "0x12E0A68", VA = "0x12E0A68")]
		public void CreateBakedMeshData(Mesh bakedMesh)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x12E0CC0", Offset = "0x12E0CC0", VA = "0x12E0CC0")]
		public void CreateProcessedMeshDataProcedural(Mesh bakedMesh, float lifetime, float velocity)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x12E0ADC", Offset = "0x12E0ADC", VA = "0x12E0ADC")]
		public void CreateProcessedMeshData(Mesh bakedMesh)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x12E1238", Offset = "0x12E1238", VA = "0x12E1238")]
		public void SetLeafLengthCorrectionFactor(float leafLengthCorrrectionFactor)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x12E1240", Offset = "0x12E1240", VA = "0x12E1240")]
		public void ClearMesh()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x12E125C", Offset = "0x12E125C", VA = "0x12E125C")]
		public RTBakedMeshBuilder()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x12E12C0", Offset = "0x12E12C0", VA = "0x12E12C0")]
		public RTBakedMeshBuilder(RTIvyContainer ivyContainer, GameObject ivyGo)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x12E1354", Offset = "0x12E1354", VA = "0x12E1354")]
		private void ClearTipMesh()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x12E1448", Offset = "0x12E1448", VA = "0x12E1448")]
		public void CheckCopyMesh(int branchIndex, List<RTBranchContainer> bakedBranches)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x12E1C2C", Offset = "0x12E1C2C", VA = "0x12E1C2C")]
		public void BuildGeometry02(List<RTBranchContainer> activeBakedBranches, List<RTBranchContainer> activeBuildingBranches)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x12E2A44", Offset = "0x12E2A44", VA = "0x12E2A44")]
		private float CalculateRadius(BranchPoint branchPoint, BranchContainer buildingBranchContainer)
		{
			return default(float);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x12E2384", Offset = "0x12E2384", VA = "0x12E2384")]
		private void SetTriangles(RTBranchContainer branch, int vertCount, int initIndex, int branchIndex)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x12E25B4", Offset = "0x12E25B4", VA = "0x12E25B4")]
		private void BuildLeaves(int branchIndex, RTBranchContainer buildingBranchContainer, RTBranchContainer bakedBranchContainer)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x12E1510", Offset = "0x12E1510", VA = "0x12E1510")]
		public void CopyToFixedMesh(int branchIndex, int initSegmentIdx, int endSegmentIdx, RTBranchContainer branchContainer, RTBranchContainer bakedBranchContainer)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x12E2BC8", Offset = "0x12E2BC8", VA = "0x12E2BC8")]
		public void RefreshProcessedMesh()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x12E28D8", Offset = "0x12E28D8", VA = "0x12E28D8")]
		private void RefreshMesh()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public abstract class RTIvy : MonoBehaviour
	{
		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected IvyParameters ivyParameters;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected RTIvyContainer rtIvyContainer;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected RTIvyContainer rtBuildingIvyContainer;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MeshFilter meshFilter;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MeshRenderer meshRenderer;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MeshRenderer mrProcessedMesh;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MeshFilter mfProcessedMesh;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected List<RTBranchContainer> activeBakedBranches;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected List<RTBranchContainer> activeBuildingBranches;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected int lastIdxActiveBranch;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<float> srcTotalLengthPerBranch;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<float> dstTotalLengthPerBranch;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<float> growingFactorPerBranch;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<float> lengthPerBranch;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected List<int> lastCopiedIndexPerBranch;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected List<Vector3> srcPoints;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected List<Vector3> dstPoints;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected List<LeafPoint> leavesToCopyMesh;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public RTBakedMeshBuilder meshBuilder;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Mesh bakedMesh;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Mesh processedMesh;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool refreshProcessedMesh;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int backtrackingPoints;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected float currentLifetime;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		protected float currentSpeed;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected float currentGrowthSpeed;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		protected float leafLengthCorrrectionFactor;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected float currentTimer;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected RuntimeGrowthParameters growthParameters;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected List<Material> leavesMaterials;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected RTMeshData[] leavesMeshesByChosenLeaf;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected int[] submeshByChoseLeaf;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected int maxBranches;

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x12E2D24", Offset = "0x12E2D24", VA = "0x12E2D24")]
		public void AwakeInit()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x12E2D68", Offset = "0x12E2D68", VA = "0x12E2D68", Slot = "4")]
		protected virtual void Init(IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x12E3E3C", Offset = "0x12E3E3C", VA = "0x12E3E3C")]
		private void SetUpMaxBranches(IvyContainer ivyContainer)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x12E40F8", Offset = "0x12E40F8", VA = "0x12E40F8")]
		protected void InitMeshBuilder()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x12E4268", Offset = "0x12E4268", VA = "0x12E4268", Slot = "5")]
		protected virtual void AddFirstBranch()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x12E404C", Offset = "0x12E404C", VA = "0x12E404C")]
		private int GetBacktrackingPoints()
		{
			return default(int);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x12E4278", Offset = "0x12E4278", VA = "0x12E4278", Slot = "6")]
		public virtual void UpdateIvy(float deltaTime)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x12E43B8", Offset = "0x12E43B8", VA = "0x12E43B8", Slot = "7")]
		protected virtual void Growing(int branchIndex, float deltaTime)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x12E4820", Offset = "0x12E4820", VA = "0x12E4820", Slot = "8")]
		protected virtual void NextPoints(int branchIndex)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x12E46C8", Offset = "0x12E46C8", VA = "0x12E46C8")]
		private void CalculateFactors(Vector3 srcPoint, Vector3 dstPoint)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x12E4F00", Offset = "0x12E4F00", VA = "0x12E4F00", Slot = "9")]
		protected virtual void AddNextBranch(int branchNumber)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x12E4CAC", Offset = "0x12E4CAC", VA = "0x12E4CAC")]
		private void UpdateGrowingPoints(int branchIndex)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x12E4398", Offset = "0x12E4398", VA = "0x12E4398")]
		private void RefreshGeometry()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x12E4330", Offset = "0x12E4330", VA = "0x12E4330")]
		private void UpdateGrowthSpeed()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x12E4EBC", Offset = "0x12E4EBC", VA = "0x12E4EBC")]
		public bool IsVertexLimitReached()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x12E3EEC", Offset = "0x12E3EEC", VA = "0x12E3EEC")]
		private Vector3 CalculateFirstVertexVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x12E3794", Offset = "0x12E3794", VA = "0x12E3794")]
		private void CreateLeavesDict()
		{
		}

		[Token(Token = "0x60001EB")]
		protected abstract void InitializeMeshesData(Mesh bakedMesh, int numBranches);

		[Token(Token = "0x60001EC")]
		protected abstract float GetNormalizedLifeTime();

		[Token(Token = "0x60001ED")]
		protected abstract int GetMaxNumPoints();

		[Token(Token = "0x60001EE")]
		protected abstract int GetMaxNumLeaves();

		[Token(Token = "0x60001EF")]
		public abstract bool IsGrowingFinished();

		[Token(Token = "0x60001F0")]
		public abstract void InitIvy(RuntimeGrowthParameters growthParameters, IvyContainer ivyContainer, IvyParameters ivyParameters);

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x12E5298", Offset = "0x12E5298", VA = "0x12E5298")]
		protected RTIvy()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class RuntimeBakedIvy : RTIvy
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x12E52A0", Offset = "0x12E52A0", VA = "0x12E52A0", Slot = "14")]
		public override bool IsGrowingFinished()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x12E53D4", Offset = "0x12E53D4", VA = "0x12E53D4", Slot = "4")]
		protected override void Init(IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x12E53EC", Offset = "0x12E53EC", VA = "0x12E53EC")]
		private void CalculateLifetime()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x12E54A8", Offset = "0x12E54A8", VA = "0x12E54A8", Slot = "11")]
		protected override float GetNormalizedLifeTime()
		{
			return default(float);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x12E555C", Offset = "0x12E555C", VA = "0x12E555C", Slot = "10")]
		protected override void InitializeMeshesData(Mesh bakedMesh, int numBranches)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x12E5574", Offset = "0x12E5574", VA = "0x12E5574", Slot = "12")]
		protected override int GetMaxNumPoints()
		{
			return default(int);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x12E557C", Offset = "0x12E557C", VA = "0x12E557C", Slot = "13")]
		protected override int GetMaxNumLeaves()
		{
			return default(int);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x12E5584", Offset = "0x12E5584", VA = "0x12E5584", Slot = "15")]
		public override void InitIvy(RuntimeGrowthParameters growthParameters, IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x12E55D8", Offset = "0x12E55D8", VA = "0x12E55D8")]
		public void InitIvyEditor(RuntimeGrowthParameters growthParameters, IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x12E5614", Offset = "0x12E5614", VA = "0x12E5614")]
		public RuntimeBakedIvy()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class IvyController : MonoBehaviour
	{
		[Token(Token = "0x200004E")]
		public enum State
		{
			[Token(Token = "0x4000273")]
			GROWTH_NOT_STARTED,
			[Token(Token = "0x4000274")]
			WAITING_FOR_DELAY,
			[Token(Token = "0x4000275")]
			PAUSED,
			[Token(Token = "0x4000276")]
			GROWING,
			[Token(Token = "0x4000277")]
			GROWTH_FINISHED
		}

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float currentTimer;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RTIvy rtIvy;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IvyContainer ivyContainer;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IvyParameters ivyParameters;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RuntimeGrowthParameters growthParameters;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private State state;

		[Token(Token = "0x14000001")]
		public event Action OnGrowthStarted
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x12E561C", Offset = "0x12E561C", VA = "0x12E561C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x12E56B8", Offset = "0x12E56B8", VA = "0x12E56B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action OnGrowthPaused
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x12E5754", Offset = "0x12E5754", VA = "0x12E5754")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x12E57F0", Offset = "0x12E57F0", VA = "0x12E57F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action OnGrowthFinished
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x12E588C", Offset = "0x12E588C", VA = "0x12E588C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x12E5928", Offset = "0x12E5928", VA = "0x12E5928")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x12E59C4", Offset = "0x12E59C4", VA = "0x12E59C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x12E5A04", Offset = "0x12E5A04", VA = "0x12E5A04")]
		[ContextMenu("Start Growth")]
		public void StartGrowth()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x12E5A78", Offset = "0x12E5A78", VA = "0x12E5A78")]
		[ContextMenu("Pause Growth")]
		public void PauseGrowth()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x12E5AA8", Offset = "0x12E5AA8", VA = "0x12E5AA8")]
		[ContextMenu("Resume Growth")]
		public void ResumeGrowth()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x12E5AC4", Offset = "0x12E5AC4", VA = "0x12E5AC4")]
		public State GetState()
		{
			return default(State);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x12E5ACC", Offset = "0x12E5ACC", VA = "0x12E5ACC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x12E5B34", Offset = "0x12E5B34", VA = "0x12E5B34")]
		private void UpdateWaitingForDelayState(float deltaTime)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x12E5B70", Offset = "0x12E5B70", VA = "0x12E5B70")]
		private void UpdateGrowingState(float deltaTime)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x12E5C04", Offset = "0x12E5C04", VA = "0x12E5C04")]
		public IvyController()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class RuntimeIvyGrowth
	{
		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RTIvyContainer rtIvyContainer;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IvyParameters ivyParameters;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject ivyGO;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RTMeshData[] leavesMeshesByChosenLeaf;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RTBranchContainer[] branchesPool;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int branchesPoolIndex;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RTBranchPoint[] branchPointsPool;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int branchPointPoolIndex;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RTLeafPoint[] leavesPool;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int leavesPoolIndex;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int numPoints;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int numLeaves;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int maxNumVerticesPerLeaf;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UnityEngine.Random.State randomstate;

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x12E5C0C", Offset = "0x12E5C0C", VA = "0x12E5C0C")]
		public void Init(RTIvyContainer ivyContainer, IvyParameters ivyParameters, GameObject ivyGO, RTMeshData[] leavesMeshesByChosenLeaf, int numPoints, int numLeaves, int maxNumVerticesPerLeaf)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x12E6564", Offset = "0x12E6564", VA = "0x12E6564")]
		private void CalculateNewHeight(RTBranchContainer branch)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x12E6630", Offset = "0x12E6630", VA = "0x12E6630")]
		private int ChooseBranchSense()
		{
			return default(int);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x12E6654", Offset = "0x12E6654", VA = "0x12E6654")]
		public void Step()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x12E6738", Offset = "0x12E6738", VA = "0x12E6738")]
		private void CalculateNewPoint(RTBranchContainer branch)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x12E678C", Offset = "0x12E678C", VA = "0x12E678C")]
		private void CheckWall(RTBranchContainer branch)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x12E6BDC", Offset = "0x12E6BDC", VA = "0x12E6BDC")]
		private void CheckFloor(RTBranchContainer branch, RTBranchPoint potentialPoint, Vector3 oldSurfaceNormal)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x12E7310", Offset = "0x12E7310", VA = "0x12E7310")]
		private void CheckCorner(RTBranchContainer branch, RTBranchPoint potentialPoint, Vector3 oldSurfaceNormal)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x12E6A00", Offset = "0x12E6A00", VA = "0x12E6A00")]
		private void CheckFall(RTBranchContainer branch)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x12E7904", Offset = "0x12E7904", VA = "0x12E7904")]
		private void CheckGrabPoint(RTBranchContainer branch)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x12E6F0C", Offset = "0x12E6F0C", VA = "0x12E6F0C")]
		public void AddPoint(RTBranchContainer branch, Vector3 point, Vector3 normal)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x12E8600", Offset = "0x12E8600", VA = "0x12E8600")]
		private float CalculateRadius(float lenght)
		{
			return default(float);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x12E8658", Offset = "0x12E8658", VA = "0x12E8658")]
		private float CalculateLeafScale(BranchContainer branch, LeafPoint leafPoint)
		{
			return default(float);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x12E86F0", Offset = "0x12E86F0", VA = "0x12E86F0")]
		private Quaternion CalculateLeafRotation(LeafPoint leafPoint)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x12E7548", Offset = "0x12E7548", VA = "0x12E7548")]
		private void AddFallingPoint(RTBranchContainer branch)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x12E6440", Offset = "0x12E6440", VA = "0x12E6440")]
		private void CalculateVerticesLastPoint(RTBranchContainer rtBranchContainer)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x12E83B4", Offset = "0x12E83B4", VA = "0x12E83B4")]
		private void AddLeave(RTBranchContainer branch)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x12E9A64", Offset = "0x12E9A64", VA = "0x12E9A64")]
		public void DeleteLastBranch()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x12E815C", Offset = "0x12E815C", VA = "0x12E815C")]
		public void AddBranch(RTBranchContainer branch, RTBranchPoint originBranchPoint, Vector3 point, Vector3 normal)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x12E70E4", Offset = "0x12E70E4", VA = "0x12E70E4")]
		private void NewGrowDirection(RTBranchContainer branch)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x12E6D80", Offset = "0x12E6D80", VA = "0x12E6D80")]
		private void NewGrowDirectionAfterWall(RTBranchContainer branch, Vector3 oldSurfaceNormal, Vector3 newSurfaceNormal)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x12E7BA0", Offset = "0x12E7BA0", VA = "0x12E7BA0")]
		private void NewGrowDirectionFalling(RTBranchContainer branch)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x12E7E18", Offset = "0x12E7E18", VA = "0x12E7E18")]
		private void NewGrowDirectionAfterFall(RTBranchContainer branch, Vector3 newSurfaceNormal)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x12E7FBC", Offset = "0x12E7FBC", VA = "0x12E7FBC")]
		private void NewGrowDirectionAfterGrab(RTBranchContainer branch, Vector3 newSurfaceNormal)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x12E776C", Offset = "0x12E776C", VA = "0x12E776C")]
		private void NewGrowDirectionAfterCorner(RTBranchContainer branch, Vector3 oldSurfaceNormal, Vector3 newSurfaceNormal)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x12E8E2C", Offset = "0x12E8E2C", VA = "0x12E8E2C")]
		public Vector3 GetFirstVector(RTBranchPoint rtBranchPoint, RTBranchContainer rtBranchContainer, RTIvyContainer rtIvyContainer, IvyParameters ivyParameters, Vector3 axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x12E8C60", Offset = "0x12E8C60", VA = "0x12E8C60")]
		public Vector3 GetLoopAxis(RTBranchPoint rtBranchPoint, RTBranchContainer rtBranchContainer, RTIvyContainer rtIvyContainer, GameObject ivyGo)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x12E62D0", Offset = "0x12E62D0", VA = "0x12E62D0")]
		private RTBranchPoint GetNextFreeBranchPoint()
		{
			return null;
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x12E92D0", Offset = "0x12E92D0", VA = "0x12E92D0")]
		private RTLeafPoint GetNextLeafPoint()
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x12E6290", Offset = "0x12E6290", VA = "0x12E6290")]
		private RTBranchContainer GetNextBranchContainer()
		{
			return null;
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x12E9B40", Offset = "0x12E9B40", VA = "0x12E9B40")]
		public RuntimeIvyGrowth()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class RuntimeProceduralIvy : RTIvy
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RuntimeIvyGrowth rtIvyGrowth;

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x12E9B48", Offset = "0x12E9B48", VA = "0x12E9B48", Slot = "4")]
		protected override void Init(IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x12E9D08", Offset = "0x12E9D08", VA = "0x12E9D08", Slot = "8")]
		protected override void NextPoints(int branchIndex)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x12E9D28", Offset = "0x12E9D28", VA = "0x12E9D28", Slot = "14")]
		public override bool IsGrowingFinished()
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x12E9D3C", Offset = "0x12E9D3C", VA = "0x12E9D3C", Slot = "11")]
		protected override float GetNormalizedLifeTime()
		{
			return default(float);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x12E9D78", Offset = "0x12E9D78", VA = "0x12E9D78")]
		public void SetIvyParameters(IvyPreset ivyPreset)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x12E9D94", Offset = "0x12E9D94", VA = "0x12E9D94", Slot = "10")]
		protected override void InitializeMeshesData(Mesh bakedMesh, int numBranches)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x12E9DB8", Offset = "0x12E9DB8", VA = "0x12E9DB8", Slot = "12")]
		protected override int GetMaxNumPoints()
		{
			return default(int);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x12E9E28", Offset = "0x12E9E28", VA = "0x12E9E28", Slot = "13")]
		protected override int GetMaxNumLeaves()
		{
			return default(int);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x12E9E34", Offset = "0x12E9E34", VA = "0x12E9E34", Slot = "15")]
		public override void InitIvy(RuntimeGrowthParameters growthParameters, IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x12E9C90", Offset = "0x12E9C90", VA = "0x12E9C90")]
		private int GetMaxNumVerticesPerLeaf()
		{
			return default(int);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x12E9E84", Offset = "0x12E9E84", VA = "0x12E9E84")]
		public RuntimeProceduralIvy()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class RTBranchContainer
	{
		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<RTBranchPoint> branchPoints;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RTLeafPoint[][] leavesOrderedByInitSegment;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float totalLength;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 growDirection;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float randomizeHeight;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float heightVar;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float newHeight;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float heightParameter;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float deltaHeight;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float currentHeight;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int branchSense;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool falling;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Quaternion rotationOnFallIteration;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fallIteration;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int branchNumber;

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x12E9E8C", Offset = "0x12E9E8C", VA = "0x12E9E8C")]
		public RTBranchContainer(BranchContainer branchContainer, IvyParameters ivyParameters, RTIvyContainer rtIvyContainer, GameObject ivyGO, RTMeshData[] leavesMeshesByChosenLeaf)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x12E2350", Offset = "0x12E2350", VA = "0x12E2350")]
		public Vector2 GetLastUV(IvyParameters ivyParameters)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x12E40CC", Offset = "0x12E40CC", VA = "0x12E40CC")]
		public RTBranchContainer(int numPoints, int numLeaves)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x12EA848", Offset = "0x12EA848", VA = "0x12EA848")]
		private void Init(int numPoints, int numLeaves)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x12E4AE8", Offset = "0x12E4AE8", VA = "0x12E4AE8")]
		public void AddBranchPoint(RTBranchPoint rtBranchPoint, float deltaLength)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x12E47BC", Offset = "0x12E47BC", VA = "0x12E47BC")]
		public RTBranchPoint GetLastBranchPoint()
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x12E9904", Offset = "0x12E9904", VA = "0x12E9904")]
		public void AddLeaf(RTLeafPoint leafAdded)
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class RTBranchPoint
	{
		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 point;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 grabVector;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float length;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int index;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool newBranch;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int newBranchNumber;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float radius;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 firstVector;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 axis;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 centerLoop;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public RTBranchContainer branchContainer;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public RTVertexData[] verticesLoop;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 lastVectorNormal;

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x12E61B4", Offset = "0x12E61B4", VA = "0x12E61B4")]
		public RTBranchPoint()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x12EA33C", Offset = "0x12EA33C", VA = "0x12EA33C")]
		public RTBranchPoint(BranchPoint branchPoint, RTBranchContainer rtBranchContainer)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x12E61BC", Offset = "0x12E61BC", VA = "0x12E61BC")]
		public void PreInit(IvyParameters ivyParameters)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x12E8140", Offset = "0x12E8140", VA = "0x12E8140")]
		public void SetValues(Vector3 point, Vector3 grabVector)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x12E6424", Offset = "0x12E6424", VA = "0x12E6424")]
		public void SetValues(Vector3 point, Vector3 grabVector, bool newBranch, int newBranchNumber)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x12E9AD0", Offset = "0x12E9AD0", VA = "0x12E9AD0")]
		public void InitBranchInThisPoint(int branchNumber)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x12E92BC", Offset = "0x12E92BC", VA = "0x12E92BC")]
		public void CalculateVerticesLoop(IvyParameters ivyParameters, RTIvyContainer rtIvyContainer, GameObject ivyGO, Vector3 firstVector, Vector3 axis, float radius)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x12EA3E4", Offset = "0x12EA3E4", VA = "0x12EA3E4")]
		public void CalculateVerticesLoop(IvyParameters ivyParameters, RTIvyContainer rtIvyContainer, GameObject ivyGO)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x12E91D4", Offset = "0x12E91D4", VA = "0x12E91D4")]
		public void CalculateCenterLoop(GameObject ivyGO)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x12E9AE0", Offset = "0x12E9AE0", VA = "0x12E9AE0")]
		public RTBranchPoint GetNextPoint()
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x12E22F0", Offset = "0x12E22F0", VA = "0x12E22F0")]
		public RTBranchPoint GetPreviousPoint()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class RTIvyContainer
	{
		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int lastBranchNumberAssigned;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<RTBranchContainer> branches;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 firstVertexVector;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x12E3FA8", Offset = "0x12E3FA8", VA = "0x12E3FA8")]
		public void Initialize(Vector3 firstVertexVector)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x12E3BC4", Offset = "0x12E3BC4", VA = "0x12E3BC4")]
		public void Initialize(IvyContainer ivyContainer, IvyParameters ivyParameters, GameObject ivyGO, RTMeshData[] leavesMeshesByChosenLeaf, Vector3 firstVertexVector)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x12E3DC0", Offset = "0x12E3DC0", VA = "0x12E3DC0")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x12E51D0", Offset = "0x12E51D0", VA = "0x12E51D0")]
		public void AddBranch(RTBranchContainer rtBranch)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x12E4BE8", Offset = "0x12E4BE8", VA = "0x12E4BE8")]
		public RTBranchContainer GetBranchContainerByBranchNumber(int newBranchNumber)
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x12E378C", Offset = "0x12E378C", VA = "0x12E378C")]
		public RTIvyContainer()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class RTLeafPoint
	{
		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 point;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float lpLength;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 left;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 lpForward;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 lpUpward;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int initSegmentIdx;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int endSegmentIdx;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chosenLeave;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RTVertexData[] vertices;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 leafCenter;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion leafRotation;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float leafScale;

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x12EA9A4", Offset = "0x12EA9A4", VA = "0x12EA9A4")]
		public void InitializeRuntime()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x12E6224", Offset = "0x12E6224", VA = "0x12E6224")]
		public RTLeafPoint()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x12EA744", Offset = "0x12EA744", VA = "0x12EA744")]
		public RTLeafPoint(LeafPoint leafPoint, IvyParameters ivyParameters)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x12E622C", Offset = "0x12E622C", VA = "0x12E622C")]
		public void PreInit(int numVertices)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x12EAED8", Offset = "0x12EAED8", VA = "0x12EAED8")]
		public void PreInit(RTMeshData leafMeshData)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x12E9434", Offset = "0x12E9434", VA = "0x12E9434")]
		public void SetValues(Vector3 point, float lpLength, Vector3 lpForward, Vector3 lpUpward, int chosenLeave, RTBranchPoint initSegment, RTBranchPoint endSegment, float leafScale, IvyParameters ivyParameters)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x12EA9A8", Offset = "0x12EA9A8", VA = "0x12EA9A8")]
		private void CalculateLeafRotation(IvyParameters ivyParameters)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x12E9590", Offset = "0x12E9590", VA = "0x12E9590")]
		public void CreateVertices(IvyParameters ivyParameters, RTMeshData leafMeshData, GameObject ivyGO)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class RTMeshData
	{
		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int vertCount;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int vertexIndex;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2[] uv;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2[] uv2;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color[] colors;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int[] triangleIndices;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int[][] triangles;

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x12E0EB8", Offset = "0x12E0EB8", VA = "0x12E0EB8")]
		public RTMeshData(int numVertices, int numSubmeshes, List<int> numTrianglesPerSubmesh)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x12E10B0", Offset = "0x12E10B0", VA = "0x12E10B0")]
		public RTMeshData(Mesh mesh)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x12EAF44", Offset = "0x12EAF44", VA = "0x12EAF44")]
		private void SetValues(Vector3[] vertices, Vector3[] normals, Vector2[] uv, Color[] colors, int[][] triangles)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x12EB020", Offset = "0x12EB020", VA = "0x12EB020")]
		public void CopyDataFromIndex(int index, int lastTriCount, int numTris, RTMeshData copyFrom)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x12E2AB8", Offset = "0x12E2AB8", VA = "0x12E2AB8")]
		public void AddTriangle(int sumbesh, int value)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x12E21CC", Offset = "0x12E21CC", VA = "0x12E21CC")]
		public void AddVertex(Vector3 vertexValue, Vector3 normalValue, Vector2 uvValue, Color color)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x12EB104", Offset = "0x12EB104", VA = "0x12EB104")]
		private void Resize()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x12EB1C4", Offset = "0x12EB1C4", VA = "0x12EB1C4")]
		public int VertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x12E13F4", Offset = "0x12E13F4", VA = "0x12E13F4")]
		public void Clear()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public struct RTVertexData
	{
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 vertex;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 normal;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 uv;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 uv2;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color color;

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x12DFFAC", Offset = "0x12DFFAC", VA = "0x12DFFAC")]
		public RTVertexData(Vector3 vertex, Vector3 normal, Vector2 uv, Vector2 uv2, Color color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class RuntimeGrowthParameters
	{
		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float growthSpeed;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float lifetime;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool speedOverLifetimeEnabled;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve speedOverLifetimeCurve;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool startGrowthOnAwake;

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x12EB1CC", Offset = "0x12EB1CC", VA = "0x12EB1CC")]
		public RuntimeGrowthParameters()
		{
		}
	}
}
namespace MagicLightProbes
{
	[Token(Token = "0x2000058")]
	public class MLPDataSaver
	{
		[Token(Token = "0x6000260")]
		public static void SaveData<T>(T data, string fullFilePath, string consoleString = "")
		{
		}

		[Token(Token = "0x6000261")]
		public static T LoadData<T>(T dataRecipient, string fullFilePath, string consoleStringSuccess = "", string consoleStringFail = "")
		{
			return (T)null;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x12EB3D8", Offset = "0x12EB3D8", VA = "0x12EB3D8")]
		public MLPDataSaver()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public static class TransformExtensions
	{
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x12EB3E0", Offset = "0x12EB3E0", VA = "0x12EB3E0")]
		public static bool MLP_IsVisibleFrom(this Transform transform, Camera camera)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005A")]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/main-component")]
	[ExecuteInEditMode]
	public class MagicLightProbes : MonoBehaviour
	{
		[Token(Token = "0x200005B")]
		public struct VolumeParameters
		{
			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int volumeIndex;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3 position;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 demensions;

			[Token(Token = "0x6000269")]
			[Address(RVA = "0x12EC170", Offset = "0x12EC170", VA = "0x12EC170")]
			public VolumeParameters(int _volumeIndex, Vector3 _position, Vector3 _demensions)
			{
			}
		}

		[Token(Token = "0x200005C")]
		public enum FillingMode
		{
			[Token(Token = "0x4000373")]
			VerticalDublicating,
			[Token(Token = "0x4000374")]
			FullFilling,
			[Token(Token = "0x4000375")]
			SeparateFilling
		}

		[Token(Token = "0x200005D")]
		public enum Workflow
		{
			[Token(Token = "0x4000377")]
			Simple,
			[Token(Token = "0x4000378")]
			Advanced
		}

		[Token(Token = "0x200005E")]
		public enum BoundsDisplayMode
		{
			[Token(Token = "0x400037A")]
			Always,
			[Token(Token = "0x400037B")]
			OnSelection
		}

		[Token(Token = "0x200005F")]
		public enum DebugPasses
		{
			[Token(Token = "0x400037D")]
			MaximumHeight,
			[Token(Token = "0x400037E")]
			GeometryCollision,
			[Token(Token = "0x400037F")]
			GeometryIntersections,
			[Token(Token = "0x4000380")]
			NearGeometry,
			[Token(Token = "0x4000381")]
			OutOfRange,
			[Token(Token = "0x4000382")]
			OutOfRangeBorders,
			[Token(Token = "0x4000383")]
			ShadingBorders,
			[Token(Token = "0x4000384")]
			ContrastAreas,
			[Token(Token = "0x4000385")]
			NearLights,
			[Token(Token = "0x4000386")]
			LightIntensity,
			[Token(Token = "0x4000387")]
			UnlitProbes,
			[Token(Token = "0x4000388")]
			EqualProbes,
			[Token(Token = "0x4000389")]
			GeometryEdges,
			[Token(Token = "0x400038A")]
			EqualColor
		}

		[Token(Token = "0x2000060")]
		public enum DrawModes
		{
			[Token(Token = "0x400038C")]
			Accepted,
			[Token(Token = "0x400038D")]
			Culled,
			[Token(Token = "0x400038E")]
			Both
		}

		[Token(Token = "0x2000061")]
		public enum CalculationTarget
		{
			[Token(Token = "0x4000390")]
			GeometryEdges,
			[Token(Token = "0x4000391")]
			GeneralCalculation
		}

		[Serializable]
		[Token(Token = "0x2000062")]
		private struct TempPointData
		{
			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float xPos;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float yPos;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float zPos;

			[Token(Token = "0x600026A")]
			[Address(RVA = "0x12EC184", Offset = "0x12EC184", VA = "0x12EC184")]
			public TempPointData(Vector3 _position)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000063")]
		public class WorkPathFoundEvent : UnityEvent<string>
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x12EC190", Offset = "0x12EC190", VA = "0x12EC190")]
			public WorkPathFoundEvent()
			{
			}
		}

		[Token(Token = "0x40002C6")]
		private const string COMPUTE_SHADERS_FOLDER = "/Passes/Compute Shaders/";

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator colorThresholdRecalculationRoutine;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator lightProbesVolumeCalculatingRoutine;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator lightProbesVolumeCalculatingSubRoutine;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IEnumerator executingPassesRoutine;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IEnumerator volumeDivideingRoutine;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<string> groundAndFloorKeywords;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<string> storedGroundAndFloorKeywords;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject probesVolume;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool useDynamicDensity;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float volumeSpacing;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float volumeSpacingMin;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float volumeSpacingMax;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float cornersDetectionThreshold;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float cornersDetectionThresholdMin;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float cornersDetectionThresholdMax;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lastCornersDetectionThreshold;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float lastCornersDetectionThresholdMin;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float lastCornersDetectionThresholdMax;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int lastMaxProbesInVolume;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public int maxProbesInVolume;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int defaultMaxProbesCount;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float lastVolumeSpacing;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float lastVolumeSpacingMin;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float lastVolumeSpacingMax;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool volumeSpacingChanged;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool tooManySubVolumes;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public FillingMode fillingMode;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Workflow workflow;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float maxHeightAboveGeometry;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float lastMaxHeightAboveGeometry;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float maxHeightAboveTerrain;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool considerDistanceToLights;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float lightIntensityTreshold;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float colorTreshold;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float collisionDetectionRadius;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool saveProbesNearbyGeometry;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float cornerProbesSpacing;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float nearbyGeometryDetectionRadius;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float nearbyGeometryDetectionRadiusMin;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float nearbyGeometryDetectionRadiusMax;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float distanceFromNearbyGeometry;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool fillEquivalentVolume;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float equivalentVolumeFillingRate;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool fillUnlitVolume;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		public bool fillFreeVolume;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float unlitVolumeFillingRate;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float freeVolumeFillingRate;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public bool cullAcceptedVolume;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float acceptedVolumeFillingRate;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public float nearbyGeometryVolumeFillingRate;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float verticalDublicatingHeight;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public float verticalDublicatingStep;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public LayerMask raycastFilter;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public List<MLPLight> excludedLights;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public LayerMask layerMask;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public int firstCollisionLayer;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool useMultithreading;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public GameObject previousSelection;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool unloaded;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		public bool sceneChanging;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		public bool waitForPrevious;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public MagicLightProbes previousVolume;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool optimizeForMixedLighting;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		public bool lastOptimizeForMixedLightingValue;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
		public bool preventLeakageThroughWalls;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13B")]
		public bool useVolumeBottom;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public float lastColorThreshold;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public float lastLightIntensityThreshold;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public float lastEquivalentVolumeFillingRate;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public float lastUnlitVolumeFillingRate;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public float lastFreeVolumeFillingRate;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public float lastCornerProbesSpacing;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public float lastDistanceFromGeometry;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public bool debugMode;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float debugObjectScale;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public BoundsDisplayMode boundsDisplayMode;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public DebugPasses debugPass;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public DrawModes drawMode;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public bool debugShowLightIntensity;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		public bool showPreviewGrid;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16E")]
		public bool nextStep;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16F")]
		public bool cullByColor;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public bool forceSaveProbesOnShadingBorders;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public string dataPath;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public string workPath;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public bool workPathFound;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public List<Vector3> localFinishedPositions;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public ComputeShader calculateVolumeFilling;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public ComputeShader calculateProbeSpacing;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public ComputeShader calculateDistanceFromGeometry;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public MLPVolume currentVolume;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public MLPQuickEditing quickEditingComponent;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool recalculationRequired;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private List<Collider> lightColliders;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private List<Collider> objectColliders;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private List<MLPPointData> finalDebugAcceptedPoints;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private List<MLPPointData> finalDebugCulledPoints;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private List<GameObject> tempObjects;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private List<GameObject> temporarilyDisabledDynamicObjects;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private List<GameObject> staticObjectsWithoutCollider;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private GameObject combinedVolumeObject;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private VolumeParameters currentEditingVolume;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private Vector3 currentSelectedObjectLastPosition;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private GameObject lastSelectedObject;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public bool cancelCombination;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		public List<IEnumerator> passesToExecute;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public List<GameObject> staticObjects;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public List<MLPLight> lights;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		public List<MLPPointData> tmpSharedPointsArray;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		public List<MLPPointData> tmpOutOfRangePoints;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		public List<MLPPointData> tmpOutOfMaxHeightPoints;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		public List<MLPPointData> tmpGeometryCollisionPoints;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public List<MLPPointData> tmpContrastOnOutOfRangePoints;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		public List<MLPPointData> tmpContrastShadingBordersPoints;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public List<MLPPointData> tmpUnlitPoints;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		public List<MLPPointData> tmpFreePoints;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		public List<MLPPointData> tmpNearbyGeometryPoints;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		public List<MLPPointData> tmpPointsNearGeometryIntersections;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		public List<MLPPointData> tmpNearbyLightsPoints;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		public List<MLPPointData> tmpEqualPoints;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		public List<MLPPointData> debugCulledPoints;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		public List<MLPPointData> debugAcceptedPoints;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		public List<GameObject> subVolumesDivided;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		public List<Vector3> points;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		public List<VolumeParameters> innerVolumes;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		public List<VolumeParameters> subVolumesParameters;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		public List<MagicLightProbes> innerVolumesObjects;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		public List<LayerMask> layerMasks;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		public List<Vector3> transformedPoints;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		public string assetEditorPath;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		public MagicLightProbes parentVolume;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool operationalDataLost;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		public bool localOperationalDataLost;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x311")]
		public bool recombinationNeeded;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x312")]
		public bool isInBackground;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x313")]
		public bool realtimeEditing;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
		public bool calculated;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x315")]
		public bool calculatingError;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		public int xPointsCount;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
		public int yPointsCount;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		public int zPointsCount;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
		public float prevVolumeScaleX;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		public float prevVolumeScaleY;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		public float prevVolumeScaleZ;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		public int totalProbes;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x334")]
		public int totalProbesInSubVolume;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		public int totalProbesInVolume;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
		public bool calculatingVolume;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33D")]
		public bool calculatingVolumeSubPass;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		public string currentPass;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		public int currentPassProgressCounter;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
		public int currentPassProgressFrameSkipper;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		public float totalProgress;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x354")]
		public float currentPassProgress;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		public int selectedTab;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
		public bool showOptionsInManagerWindow;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35D")]
		public bool restored;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		public int currentVolumePart;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x364")]
		public float eta;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		public bool changed;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x369")]
		public bool redivideParts;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36A")]
		public bool combinedVolumeError;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36B")]
		private bool passesExecuting;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
		private int totalProgressCounter;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private int totalProgressFrameSkipper;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
		private float startTime;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private float endTime;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37C")]
		private bool scenePreparing;

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x12EB494", Offset = "0x12EB494", VA = "0x12EB494")]
		public void CheckForNearContrast(MLPPointData pointForCheck)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x12EB87C", Offset = "0x12EB87C", VA = "0x12EB87C")]
		public bool UpdateProgress(int count, int period = 100)
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x12EB8C4", Offset = "0x12EB8C4", VA = "0x12EB8C4")]
		private bool UpdateTotalProgress(int count, int period = 100)
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x12EB90C", Offset = "0x12EB90C", VA = "0x12EB90C")]
		public MagicLightProbes()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-combined-volume")]
	[ExecuteInEditMode]
	public class MLPCombinedVolume : MonoBehaviour
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x12EC1D8", Offset = "0x12EC1D8", VA = "0x12EC1D8")]
		public MLPCombinedVolume()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-light")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class MLPLight : MonoBehaviour
	{
		[Token(Token = "0x2000066")]
		public enum CalculationMode
		{
			[Token(Token = "0x40003BA")]
			AccurateShadows,
			[Token(Token = "0x40003BB")]
			LightIntensity
		}

		[Token(Token = "0x2000067")]
		public enum MLPLightType
		{
			[Token(Token = "0x40003BD")]
			Spot,
			[Token(Token = "0x40003BE")]
			Directional,
			[Token(Token = "0x40003BF")]
			Point,
			[Token(Token = "0x40003C0")]
			Area,
			[Token(Token = "0x40003C1")]
			Mesh
		}

		[Token(Token = "0x2000068")]
		public enum MLPLightTypeMA
		{
			[Token(Token = "0x40003C3")]
			Area = 3,
			[Token(Token = "0x40003C4")]
			Mesh
		}

		[Token(Token = "0x2000069")]
		public enum TracePointSettingMode
		{
			[Token(Token = "0x40003C6")]
			Auto,
			[Token(Token = "0x40003C7")]
			Custom
		}

		[Token(Token = "0x200006A")]
		public enum ShadowmaskMode
		{
			[Token(Token = "0x40003C9")]
			Shadowmask,
			[Token(Token = "0x40003CA")]
			DistanceShadowmask
		}

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MLPLightType lightType;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MLPLightType lastLightType;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MLPLightTypeMA lightTypeMA;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CalculationMode calculationMode;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TracePointSettingMode tracePointSettingMode;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LightmapBakeType lightMode;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ShadowmaskMode shadowmaskMode;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Light targetLight;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject parentGameObject;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 position;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 forward;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool saveNearbyProbes;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float saveRadius;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float range;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useSourceParameters;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool reverseDirection;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float angle;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool customTracePoints;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		public bool accurateTrace;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int accuracy;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int lastAccuracy;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool isDirectional;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float tracePointSize;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float lastTracePointSize;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public MeshFilter lastMesh;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<GameObject> tracePoints;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<MLPTracePoint> tracePointsData;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public MLPTracePoint mainTracePoint;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public MagicLightProbes parentVolume;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool showOptionsInManagerWindow;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float intensity;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool resetEditor;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public bool showLightOnScene;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		public bool saveOnOutOfRange;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC3")]
		public bool isHDRP;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector2 hdrpAreaSize;

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x12EC1E0", Offset = "0x12EC1E0", VA = "0x12EC1E0")]
		public MLPLight()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class MLPPointData
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float lightIntensity;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxIntencity;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 position;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int col;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int row;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int depth;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<float> distancesToLights;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Vector3> collisionPoints;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<MLPPointData> nearbyPoints;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<MLPPointData> nearbyPointsOptimaziable;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool removed;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool outOfRange;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool inSaveRange;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		public bool savedNearGeometry;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool contrastOnOutOfRangeArea;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool inRangeOfLight;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		public bool contrastOnShadingArea;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		public bool equalIntensity;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool equalColor;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool borderPoint;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool outOfMaxHeight;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float angleToLight;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 contactPoint;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool inCorner;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool lockForCull;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		public bool onGeometryEdge;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
		public bool lightLeakLocked;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 collisionNormal;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<MLPLight> inRangeForLights;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MLPLight> inShadowForLights;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject temporaryObject;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject collisionObject;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color averagedColor;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool xEndPoint;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool yEndPoint;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		public bool zEndPoint;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB3")]
		public bool xStartPoint;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool yStartPoint;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool zStartPoint;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int equivalent;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float avaragedColorValue;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool isUnlit;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x12EC2C4", Offset = "0x12EC2C4", VA = "0x12EC2C4")]
		public void SetPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x12EC2D0", Offset = "0x12EC2D0", VA = "0x12EC2D0")]
		public void SetOutOfRange(bool visibility)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x12EC2DC", Offset = "0x12EC2DC", VA = "0x12EC2DC")]
		public void SetLightIntensity(float intensity)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x12EC2E4", Offset = "0x12EC2E4", VA = "0x12EC2E4")]
		public void SetInSaveRange(bool value)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x12EC2F0", Offset = "0x12EC2F0", VA = "0x12EC2F0")]
		public void SetInContrastArea(bool value)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x12EC2FC", Offset = "0x12EC2FC", VA = "0x12EC2FC")]
		public MLPPointData()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[ExecuteInEditMode]
	public class MLPPortal : MonoBehaviour
	{
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float yStep;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float zStep;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int yCounter;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int zCounter;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool calculate;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x12EC4CC", Offset = "0x12EC4CC", VA = "0x12EC4CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x12EC4D0", Offset = "0x12EC4D0", VA = "0x12EC4D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x12EC53C", Offset = "0x12EC53C", VA = "0x12EC53C")]
		private void DrawRayX(Vector3 dir)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x12EC798", Offset = "0x12EC798", VA = "0x12EC798")]
		private void DrawRayZ(Vector3 dir)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x12EC9B8", Offset = "0x12EC9B8", VA = "0x12EC9B8")]
		public MLPPortal()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-quick-editing")]
	public class MLPQuickEditing : MonoBehaviour
	{
		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MagicLightProbes parent;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float gizmoScale;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float drawDistance;

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x12EC9C0", Offset = "0x12EC9C0", VA = "0x12EC9C0")]
		public MLPQuickEditing()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class MLPTracePoint
	{
		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 forward;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject pointGameObject;

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x12EC9D0", Offset = "0x12EC9D0", VA = "0x12EC9D0")]
		public MLPTracePoint()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[ExecuteInEditMode]
	public class MLPVolume : MonoBehaviour
	{
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public MagicLightProbes parentRootComponent;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public MeshRenderer selfRenderer;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool showGizmo;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool showGizmoSelected;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool isPartVolume;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool isSubdividedPart;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool isCalculated;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool isInProcess;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public bool skipped;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int id;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color colorOnSelection;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<MLPPointData> localAcceptedPoints;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<MLPPointData> localNearbyGeometryPoints;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<MLPPointData> localContrastPoints;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<MLPPointData> localCornerPoints;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<Vector3> localNearbyGeometryPointsPositions;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<Vector3> resultNearbyGeometryPointsPositions;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<Vector3> localCornerPointsPositions;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<Vector3> resultLocalCornerPointsPositions;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<Vector3> localEquivalentPointsPositions;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<Vector3> resultLocalEquivalentPointsPositions;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<Vector3> resultLocalFreePointsPositions;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<Vector3> localUnlitPointsPositions;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public List<Vector3> localFreePointsPositions;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public List<Vector3> resultLocalUnlitPointsPositions;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public List<Vector3> localDirections;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<Vector3> localAvaragedDirections;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<MLPPointData> localColorThresholdEditingPoints;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int objectsInside;

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x12EC9D8", Offset = "0x12EC9D8", VA = "0x12EC9D8")]
		public MLPVolume()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class CheckForLightLeakAreas
	{
		[Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x17000008")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000281")]
				[Address(RVA = "0x12ED414", Offset = "0x12ED414", VA = "0x12ED414", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000009")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000283")]
				[Address(RVA = "0x12ED45C", Offset = "0x12ED45C", VA = "0x12ED45C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600027E")]
			[Address(RVA = "0x12ECD8C", Offset = "0x12ECD8C", VA = "0x12ECD8C")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x600027F")]
			[Address(RVA = "0x12ECDBC", Offset = "0x12ECDBC", VA = "0x12ECDBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x12ECDC0", Offset = "0x12ECDC0", VA = "0x12ECDC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x12ED41C", Offset = "0x12ED41C", VA = "0x12ED41C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x12ECD18", Offset = "0x12ECD18", VA = "0x12ECD18")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x12ECDB4", Offset = "0x12ECDB4", VA = "0x12ECDB4")]
		public CheckForLightLeakAreas()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class DublicateVertical
	{
		[Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <steps>5__2;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<MLPPointData> <candidates>5__3;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<MLPPointData> <savedNearGeometry>5__4;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <i>5__5;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<MLPPointData>.Enumerator <>7__wrap5;

			[Token(Token = "0x1700000A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600028A")]
				[Address(RVA = "0x12EE108", Offset = "0x12EE108", VA = "0x12EE108", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600028C")]
				[Address(RVA = "0x12EE150", Offset = "0x12EE150", VA = "0x12EE150", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000286")]
			[Address(RVA = "0x12ED4D8", Offset = "0x12ED4D8", VA = "0x12ED4D8")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x12ED508", Offset = "0x12ED508", VA = "0x12ED508", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x12ED524", Offset = "0x12ED524", VA = "0x12ED524", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x12EE0B8", Offset = "0x12EE0B8", VA = "0x12EE0B8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x12EE110", Offset = "0x12EE110", VA = "0x12EE110", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x12ED464", Offset = "0x12ED464", VA = "0x12ED464")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent)
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x12ED500", Offset = "0x12ED500", VA = "0x12ED500")]
		public DublicateVertical()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public static class RandomGen
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random _global;

		[Token(Token = "0x400042B")]
		[ThreadStatic]
		private static System.Random _local;

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x12EE158", Offset = "0x12EE158", VA = "0x12EE158")]
		public static int Next(int min, int max)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000075")]
	public class EquivalentProbesOptimization
	{
		[Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MLPVolume currentVolume;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool realtimeEditing;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3[] <exit>5__2;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<MLPPointData> <tempList>5__3;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <i>5__4;

			[Token(Token = "0x1700000C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000294")]
				[Address(RVA = "0x12EEC3C", Offset = "0x12EEC3C", VA = "0x12EEC3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000296")]
				[Address(RVA = "0x12EEC84", Offset = "0x12EEC84", VA = "0x12EEC84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0x12EE478", Offset = "0x12EE478", VA = "0x12EE478")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000292")]
			[Address(RVA = "0x12EE4A8", Offset = "0x12EE4A8", VA = "0x12EE4A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x12EE4AC", Offset = "0x12EE4AC", VA = "0x12EE4AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x12EEC44", Offset = "0x12EEC44", VA = "0x12EEC44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x12EE3DC", Offset = "0x12EE3DC", VA = "0x12EE3DC")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent, [Optional] MLPVolume currentVolume, bool realtimeEditing = false)
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x12EE4A0", Offset = "0x12EE4A0", VA = "0x12EE4A0")]
		public EquivalentProbesOptimization()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class PartialVolumeFilling
	{
		[Token(Token = "0x2000078")]
		public enum TargetPoint
		{
			[Token(Token = "0x4000435")]
			Unlit,
			[Token(Token = "0x4000436")]
			Equivalent,
			[Token(Token = "0x4000437")]
			Free
		}

		[Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TargetPoint targetPoint;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MagicLightProbes parent;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MLPVolume currentVolume;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool realtimeEditing;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<MLPPointData> <tempList>5__2;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<Vector3> <realTimeEditingList>5__3;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private List<Vector3> <targetPoints>5__4;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private float <fillingRate>5__5;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3[] <exit>5__6;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int <i>5__7;

			[Token(Token = "0x1700000E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600029C")]
				[Address(RVA = "0x12EFD9C", Offset = "0x12EFD9C", VA = "0x12EFD9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600029E")]
				[Address(RVA = "0x12EFDE4", Offset = "0x12EFDE4", VA = "0x12EFDE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000299")]
			[Address(RVA = "0x12EED38", Offset = "0x12EED38", VA = "0x12EED38")]
			[DebuggerHidden]
			public <ExecutePass>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0x12EED68", Offset = "0x12EED68", VA = "0x12EED68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x12EED6C", Offset = "0x12EED6C", VA = "0x12EED6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x12EFDA4", Offset = "0x12EFDA4", VA = "0x12EFDA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x12EEC8C", Offset = "0x12EEC8C", VA = "0x12EEC8C")]
		[IteratorStateMachine(typeof(<ExecutePass>d__1))]
		public IEnumerator ExecutePass(MagicLightProbes parent, TargetPoint targetPoint, [Optional] MLPVolume currentVolume, bool realtimeEditing = false)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x12EED60", Offset = "0x12EED60", VA = "0x12EED60")]
		public PartialVolumeFilling()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class RemoveUnusedPoints
	{
		[Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<MLPPointData> <pointsToRemove>5__2;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <i>5__3;

			[Token(Token = "0x17000010")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002A4")]
				[Address(RVA = "0x12F0414", Offset = "0x12F0414", VA = "0x12F0414", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000011")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002A6")]
				[Address(RVA = "0x12F045C", Offset = "0x12F045C", VA = "0x12F045C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x12EFE60", Offset = "0x12EFE60", VA = "0x12EFE60")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x12EFE90", Offset = "0x12EFE90", VA = "0x12EFE90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x12EFE94", Offset = "0x12EFE94", VA = "0x12EFE94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x12F041C", Offset = "0x12F041C", VA = "0x12F041C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x12EFDEC", Offset = "0x12EFDEC", VA = "0x12EFDEC")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent)
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x12EFE88", Offset = "0x12EFE88", VA = "0x12EFE88")]
		public RemoveUnusedPoints()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class SetDistanceFromGeometry
	{
		[Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MLPVolume currentVolume;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MagicLightProbes parent;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[] <exit>5__2;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__3;

			[Token(Token = "0x17000012")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002AC")]
				[Address(RVA = "0x12F0AC8", Offset = "0x12F0AC8", VA = "0x12F0AC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000013")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002AE")]
				[Address(RVA = "0x12F0B10", Offset = "0x12F0B10", VA = "0x12F0B10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x12F04F4", Offset = "0x12F04F4", VA = "0x12F04F4")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x12F0524", Offset = "0x12F0524", VA = "0x12F0524", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x12F0528", Offset = "0x12F0528", VA = "0x12F0528", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x12F0AD0", Offset = "0x12F0AD0", VA = "0x12F0AD0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x12F0464", Offset = "0x12F0464", VA = "0x12F0464")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent, MLPVolume currentVolume)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x12F051C", Offset = "0x12F051C", VA = "0x12F051C")]
		public SetDistanceFromGeometry()
		{
		}
	}
}
namespace Lux_SRP_GrassDisplacement
{
	[Token(Token = "0x200007E")]
	public class RotateAndMove : MonoBehaviour
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Rotate;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool MoveUpDown;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float posy;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform trans;

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x12F0B18", Offset = "0x12F0B18", VA = "0x12F0B18")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x12F0B90", Offset = "0x12F0B90", VA = "0x12F0B90")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x12F0C5C", Offset = "0x12F0C5C", VA = "0x12F0C5C")]
		public RotateAndMove()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform targetTransform;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float smoothTime;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 velocity;

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x12F1C6C", Offset = "0x12F1C6C", VA = "0x12F1C6C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x12F1D50", Offset = "0x12F1D50", VA = "0x12F1D50")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[ExecuteInEditMode]
	public class ControlDisplacer : MonoBehaviour
	{
		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDistance;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fallOff;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Layer]
		public int layerMask;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Space(5f)]
		public bool DebugRay;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Renderer rend;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MaterialPropertyBlock mpb;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RaycastHit hit;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float alpha;

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x12F1DBC", Offset = "0x12F1DBC", VA = "0x12F1DBC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x12F1EB4", Offset = "0x12F1EB4", VA = "0x12F1EB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x12F1EE8", Offset = "0x12F1EE8", VA = "0x12F1EE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x12F2090", Offset = "0x12F2090", VA = "0x12F2090")]
		public ControlDisplacer()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[RequireComponent(typeof(ParticleSystem))]
	public class ControlDisplacerParticleSys : MonoBehaviour
	{
		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDistance;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fallOff;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Layer]
		public int layerMask;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Space(5f)]
		public bool DebugRay;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem ps;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ParticleSystem.MainModule main;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RaycastHit hit;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float alpha;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float min_alpha;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float max_alpha;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color min_StartColor;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Color max_StartColor;

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x12F20AC", Offset = "0x12F20AC", VA = "0x12F20AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x12F2208", Offset = "0x12F2208", VA = "0x12F2208")]
		private void Update()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x12F2414", Offset = "0x12F2414", VA = "0x12F2414")]
		public ControlDisplacerParticleSys()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class DebugGrassDisplacementTex : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000083")]
		public enum DebugSize
		{
			[Token(Token = "0x400046F")]
			_128 = 0x80,
			[Token(Token = "0x4000470")]
			_256 = 0x100,
			[Token(Token = "0x4000471")]
			_512 = 0x200,
			[Token(Token = "0x4000472")]
			_1024 = 0x400
		}

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_EnableDebug;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public DebugSize currentDebugSize;

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x12F2430", Offset = "0x12F2430", VA = "0x12F2430")]
		public DebugGrassDisplacementTex()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class GrassDisplacementRenderFeature : ScriptableRendererFeature
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		public enum RTDisplacementSize
		{
			[Token(Token = "0x4000476")]
			_128 = 0x80,
			[Token(Token = "0x4000477")]
			_256 = 0x100,
			[Token(Token = "0x4000478")]
			_512 = 0x200,
			[Token(Token = "0x4000479")]
			_1024 = 0x400
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public class GrassDisplacementSettings
		{
			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RTDisplacementSize Resolution;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float Size;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool ShiftRenderTex;

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x12F2748", Offset = "0x12F2748", VA = "0x12F2748")]
			public GrassDisplacementSettings()
			{
			}
		}

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GrassDisplacementSettings settings;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GrassDisplacementPass m_GrassDisplacementPass;

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x12F2448", Offset = "0x12F2448", VA = "0x12F2448", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x12F26A4", Offset = "0x12F26A4", VA = "0x12F26A4", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x12F26C8", Offset = "0x12F26C8", VA = "0x12F26C8")]
		public GrassDisplacementRenderFeature()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class GrassDisplacementPass : ScriptableRenderPass
	{
		[Token(Token = "0x400047D")]
		private const string ProfilerTag = "Render Lux Grass Displacement FX";

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ProfilingSampler m_ProfilingSampler;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ShaderTagId m_GrassDisplacementFXShaderTag;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private SinglePassStereoMode m_StereoRenderingMode;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Color m_ClearColor;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTargetHandle m_GrassDisplacementFX;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Matrix4x4 projectionMatrix;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Matrix4x4 worldToCameraMatrix;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public float m_Size;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public int m_Resolution;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public bool m_ShiftRenderTex;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private float stepSize;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float oneOverStepSize;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector4 posSize;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int DisplacementTexPosSizePID;

		[Token(Token = "0x17000014")]
		private FilteringSettings transparentFilterSettings
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x12F275C", Offset = "0x12F275C", VA = "0x12F275C")]
			[CompilerGenerated]
			get
			{
				return default(FilteringSettings);
			}
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x12F2774", Offset = "0x12F2774", VA = "0x12F2774")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x12F24E0", Offset = "0x12F24E0", VA = "0x12F24E0")]
		public GrassDisplacementPass()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x12F278C", Offset = "0x12F278C", VA = "0x12F278C", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x12F29BC", Offset = "0x12F29BC", VA = "0x12F29BC", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x12F2F18", Offset = "0x12F2F18", VA = "0x12F2F18", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeUsage(AttributeTargets.Field)]
	public class LayerAttribute : PropertyAttribute
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x12F3008", Offset = "0x12F3008", VA = "0x12F3008")]
		public LayerAttribute()
		{
		}
	}
}
namespace LuxURPEssentials
{
	[Token(Token = "0x2000089")]
	public class DecalManager : MonoBehaviour
	{
		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Gizmos;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DrawDecalGizmos;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x12F3010", Offset = "0x12F3010", VA = "0x12F3010")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x12F3070", Offset = "0x12F3070", VA = "0x12F3070")]
		public DecalManager()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[RequireComponent(typeof(MeshFilter))]
	public class LuxURP_BillboardBounds : MonoBehaviour
	{
		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Space(5f)]
		[LuxURP_HelpBtn("h.9i03ddhmnooa")]
		[Space(18f)]
		[SerializeField]
		[Tooltip("Scale of the tweaked bounding box.")]
		private Vector3 _Scale;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If checked Unity will instantiate the assigned mesh on Start().")]
		[SerializeField]
		private bool _createUniqueMesh;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		[Tooltip("Check this to preview the scaled bounding box.")]
		[Space(8f)]
		[SerializeField]
		private bool _drawBounds;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mesh _Mesh;

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x12F30CC", Offset = "0x12F30CC", VA = "0x12F30CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x12F30DC", Offset = "0x12F30DC", VA = "0x12F30DC")]
		private void SetBounds()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x12F32F8", Offset = "0x12F32F8", VA = "0x12F32F8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x12F3530", Offset = "0x12F3530", VA = "0x12F3530")]
		public LuxURP_BillboardBounds()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class LuxURP_HelpBtn : PropertyAttribute
	{
		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string URL;

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x12F3550", Offset = "0x12F3550", VA = "0x12F3550")]
		public LuxURP_HelpBtn(string URL)
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class LuxURP_LayerBasedCulling : MonoBehaviour
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Space(5f, order = 1)]
		[LuxURP_HelpBtn("h.2uxuzzrgrwpo", order = 0)]
		public LayerMask SmallDetailsLayer;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SmallDetailsDistance;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask MediumDetailsLayer;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float MediumDetailsDistance;

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x12F3580", Offset = "0x12F3580", VA = "0x12F3580")]
		private int GetLayerNumber(int LayerValue)
		{
			return default(int);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x12F35A0", Offset = "0x12F35A0", VA = "0x12F35A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x12F3734", Offset = "0x12F3734", VA = "0x12F3734")]
		public LuxURP_LayerBasedCulling()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[ExecuteAlways]
	public class LuxURP_SetupGlobals : MonoBehaviour
	{
		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D _BestFittingNormal;

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x12F374C", Offset = "0x12F374C", VA = "0x12F374C")]
		private void SetupGlobals()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x12F37E0", Offset = "0x12F37E0", VA = "0x12F37E0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x12F37E4", Offset = "0x12F37E4", VA = "0x12F37E4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x12F37E8", Offset = "0x12F37E8", VA = "0x12F37E8")]
		public LuxURP_SetupGlobals()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008E")]
	public enum RTSize
	{
		[Token(Token = "0x400049A")]
		_128 = 128,
		[Token(Token = "0x400049B")]
		_256 = 256,
		[Token(Token = "0x400049C")]
		_384 = 384,
		[Token(Token = "0x400049D")]
		_512 = 512,
		[Token(Token = "0x400049E")]
		_1024 = 1024
	}
	[Serializable]
	[Token(Token = "0x200008F")]
	public enum RTFormat
	{
		[Token(Token = "0x40004A0")]
		ARGB32,
		[Token(Token = "0x40004A1")]
		ARGBHalf
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public enum GustMixLayer
	{
		[Token(Token = "0x40004A3")]
		Layer_0,
		[Token(Token = "0x40004A4")]
		Layer_1,
		[Token(Token = "0x40004A5")]
		Layer_2
	}
	[Token(Token = "0x2000091")]
	[RequireComponent(typeof(WindZone))]
	[ExecuteAlways]
	public class LuxURP_Wind : MonoBehaviour
	{
		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Space(3f)]
		[Space(5f)]
		[LuxURP_HelpBtn("h.wnnhm4pxp610")]
		public bool UpdateInEditMode;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Header("Render Texture Settings")]
		[Space(4f)]
		[Tooltip("Smaller resoltions will speed up rendering but may result in some quantization regarding the final bending.")]
		public RTSize Resolution;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("ARGB32 needs less memory and bandwidth but creates a slightly more quantized results - while ARGBHalf needs more memory and bandwith but gives you smoother results.")]
		public RTFormat Format;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Expects an RGBA texture with diffirently scaled noise patterns. If left empty the script will grab the default one.")]
		public Texture WindBaseTex;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader WindCompositeShader;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Drives the frequency of the turbulence animation according to the main wind strength.")]
		[Range(0.1f, 1f)]
		[Space(4f)]
		[Header("Wind Frequency and Turbulence")]
		public float WindToFrequency;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Drives the strength of turbulence according to the main wind strength.")]
		public AnimationCurve WindToTurbulence;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Scales the final turbulence value used by the shaders.")]
		[Range(0f, 4f)]
		public float MaxTurbulence;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Base Wind Speed in km/h at Main = 1 (WindZone).")]
		[Space(4f)]
		[Header("Wind Speed and Size")]
		public float BaseWindSpeed;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Size of the Wind RenderTexture in World Space.")]
		public float SizeInWorldSpace;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Space(4f)]
		[Tooltip("Speed of Layer0 (red channel) relative to the Base Wind Speed.")]
		public float speedLayer0;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Speed of Layer1 (green channel) relative to the Base Wind Speed.")]
		public float speedLayer1;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Speed of Layer3 (blue channel) relative to the Base Wind Speed.")]
		public float speedLayer2;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Noise")]
		[Space(4f)]
		[Tooltip("Tiling of the gust layer (alpha channel) relative to Size In WorldSpace.")]
		public int GrassGustTiling;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Speed of the gust layer (alpha channel) relative to the Base Wind Speed.")]
		public float GrassGustSpeed;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Lets you choose a Wind Layer you want the dedicated Gust sample to be combined with.")]
		public GustMixLayer LayerToMixWith;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Header("Wind Multipliers")]
		[Space(4f)]
		public float Grass;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float Foliage;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RenderTexture WindRenderTexture;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material m_material;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector2 uvs;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector2 uvs1;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 uvs2;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector2 uvs3;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform trans;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private WindZone windZone;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float mainWind;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int WindRTPID;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int LuxURPWindDirSizePID;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int LuxURPWindStrengthMultipliersPID;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int LuxURPSinTimePID;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int LuxURPGustPID;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int LuxURPGustMixLayerPID;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int LuxURPBendFrequencyPID;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int LuxURPWindUVsPID;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int LuxURPWindUVs1PID;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int LuxURPWindUVs2PID;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int LuxURPWindUVs3PID;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int previousRTSize;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int previousRTFormat;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector4 WindDirectionSize;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float WindTurbulence;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Vector3[] MixLayers;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private double currentTime;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private double domainTime_Wind;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float temp_WindFrequency;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float freqSpeed;

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x12F37F0", Offset = "0x12F37F0", VA = "0x12F37F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x12F3B4C", Offset = "0x12F3B4C", VA = "0x12F3B4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x12F39D8", Offset = "0x12F39D8", VA = "0x12F39D8")]
		private void SetupRT()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x12F3C90", Offset = "0x12F3C90", VA = "0x12F3C90")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x12F3EC4", Offset = "0x12F3EC4", VA = "0x12F3EC4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x12F4288", Offset = "0x12F4288", VA = "0x12F4288")]
		public LuxURP_Wind()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[RequireComponent(typeof(Terrain))]
	public class GetTerrainHeightNormalMap : MonoBehaviour
	{
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TerrainData targetTerrainData;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string savePathTerrainHeightNormalMap;

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x12F4728", Offset = "0x12F4728", VA = "0x12F4728")]
		public void GetTerData()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x12F47F8", Offset = "0x12F47F8", VA = "0x12F47F8")]
		public GetTerrainHeightNormalMap()
		{
		}
	}
}
namespace LuxURPEssentials.Demo
{
	[Token(Token = "0x2000093")]
	public class AnimateSphere : MonoBehaviour
	{
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform trans;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float yPos;

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x12F4800", Offset = "0x12F4800", VA = "0x12F4800")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x12F4878", Offset = "0x12F4878", VA = "0x12F4878")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x12F48E4", Offset = "0x12F48E4", VA = "0x12F48E4")]
		public AnimateSphere()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class CheckSettings : MonoBehaviour
	{
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x12F48EC", Offset = "0x12F48EC", VA = "0x12F48EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x12F4A20", Offset = "0x12F4A20", VA = "0x12F4A20")]
		public CheckSettings()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class ExtendedFlycam : MonoBehaviour
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float climbSpeed;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float normalMoveSpeed;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoveFactor;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fastMoveFactor;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationX;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationY;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool isOrtho;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera cam;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isActive;

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x12F4A28", Offset = "0x12F4A28", VA = "0x12F4A28")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x12F4AFC", Offset = "0x12F4AFC", VA = "0x12F4AFC")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x12F5244", Offset = "0x12F5244", VA = "0x12F5244")]
		public ExtendedFlycam()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class MouseSelect : MonoBehaviour
	{
		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform selectedTransform;

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x12F5268", Offset = "0x12F5268", VA = "0x12F5268")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x12F54C4", Offset = "0x12F54C4", VA = "0x12F54C4")]
		public MouseSelect()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class ToggleOutlineSelection : MonoBehaviour
	{
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material SelectionMaterial;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material OutlineMaterial;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Renderer rend;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material[] BaseMatArray;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material[] SelectedMatArray;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool Selected;

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x12F54CC", Offset = "0x12F54CC", VA = "0x12F54CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x12F5470", Offset = "0x12F5470", VA = "0x12F5470")]
		public void Select()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x12F5610", Offset = "0x12F5610", VA = "0x12F5610")]
		public ToggleOutlineSelection()
		{
		}
	}
}
namespace Bhaptics.SDK2
{
	[Token(Token = "0x2000098")]
	public class PlayParamSample : MonoBehaviour
	{
		[Token(Token = "0x2000099")]
		[CompilerGenerated]
		private sealed class <OnClickPlayCor>d__54 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlayParamSample <>4__this;

			[Token(Token = "0x1700001A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000308")]
				[Address(RVA = "0x12F6810", Offset = "0x12F6810", VA = "0x12F6810", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600030A")]
				[Address(RVA = "0x12F6858", Offset = "0x12F6858", VA = "0x12F6858", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x12F62C4", Offset = "0x12F62C4", VA = "0x12F62C4")]
			[DebuggerHidden]
			public <OnClickPlayCor>d__54(int <>1__state)
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x12F6678", Offset = "0x12F6678", VA = "0x12F6678", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x12F667C", Offset = "0x12F667C", VA = "0x12F667C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x12F6818", Offset = "0x12F6818", VA = "0x12F6818", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string SampleAppID;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string SampleApiKey;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Canvas")]
		[SerializeField]
		private Canvas initCanvas;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Canvas mainCanvas;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Dropdown")]
		[SerializeField]
		private Dropdown eventsDropdown;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Slider")]
		[SerializeField]
		private Slider sliderIntensity;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Slider sliderDuration;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Slider sliderAngleX;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Slider sliderOffsetY;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Header("Text")]
		private Text intensityValueText;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text durationValueText;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text angleXValueText;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text offsetYValueText;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text playButtonText;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Header("Button")]
		private Button intensityResetButton;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button durationResetButton;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button angleXResetButton;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Button offsetYResetButton;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Header("Sample")]
		private BhapticsSettings sampleSettings;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int requestId;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string eventName;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private MappingMetaData[] events;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Coroutine onClickPlayCoroutine;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private BhapticsSettings currentSettings;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float intensity;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float duration;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float angleX;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float offsetY;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int selectedIndex;

		[Token(Token = "0x17000015")]
		public float Intensity
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x12F5690", Offset = "0x12F5690", VA = "0x12F5690")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x12F5698", Offset = "0x12F5698", VA = "0x12F5698")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public float Duration
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x12F57D8", Offset = "0x12F57D8", VA = "0x12F57D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x12F57E0", Offset = "0x12F57E0", VA = "0x12F57E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public float AngleX
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x12F5920", Offset = "0x12F5920", VA = "0x12F5920")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x12F5928", Offset = "0x12F5928", VA = "0x12F5928")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public float OffsetY
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x12F5A68", Offset = "0x12F5A68", VA = "0x12F5A68")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x12F5A70", Offset = "0x12F5A70", VA = "0x12F5A70")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public int SelectedIndex
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x12F5BB0", Offset = "0x12F5BB0", VA = "0x12F5BB0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x12F5BB8", Offset = "0x12F5BB8", VA = "0x12F5BB8")]
			set
			{
			}
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x12F5BC0", Offset = "0x12F5BC0", VA = "0x12F5BC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x12F5C94", Offset = "0x12F5C94", VA = "0x12F5C94")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x12F5CB8", Offset = "0x12F5CB8", VA = "0x12F5CB8")]
		public void OnClickPlay()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x12F5F44", Offset = "0x12F5F44", VA = "0x12F5F44")]
		public void SetOffsetY(string offsetYStr)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x12F5F84", Offset = "0x12F5F84", VA = "0x12F5F84")]
		public void OpenDeveloperPortal()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x12F5FC8", Offset = "0x12F5FC8", VA = "0x12F5FC8")]
		public void OpenGuideLink()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x12F600C", Offset = "0x12F600C", VA = "0x12F600C")]
		public void UseSampleSettings()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x12F60A4", Offset = "0x12F60A4", VA = "0x12F60A4")]
		private void PlayHaptic(string eventName, float intensity, float duration, float angleX, float offsetY)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x12F5DCC", Offset = "0x12F5DCC", VA = "0x12F5DCC")]
		private void StopHaptic()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x12F620C", Offset = "0x12F620C", VA = "0x12F620C")]
		private void ResetValues()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x12F5D58", Offset = "0x12F5D58", VA = "0x12F5D58")]
		[IteratorStateMachine(typeof(<OnClickPlayCor>d__54))]
		private IEnumerator OnClickPlayCor()
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x12F62EC", Offset = "0x12F62EC", VA = "0x12F62EC")]
		private void SetupApplicationData()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x12F5BEC", Offset = "0x12F5BEC", VA = "0x12F5BEC")]
		private void CheckApplicationSetting()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x12F65B4", Offset = "0x12F65B4", VA = "0x12F65B4")]
		public PlayParamSample()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class BhapticsEvent
	{
		[Token(Token = "0x400050A")]
		public const string PLAYERMELEEWOODFLESHBLUNTRIGHT_1_REFLECTED = "playermeleewoodfleshbluntright_1_reflected";

		[Token(Token = "0x400050B")]
		public const string DAMAGERIGHTARMSLASHBLADESMALL_2_REFLECTED = "damagerightarmslashbladesmall_2_reflected";

		[Token(Token = "0x400050C")]
		public const string PLAYERMELEESTONEFLESHBLUNTRIGHT_1_REFLECTED = "playermeleestonefleshbluntright_1_reflected";

		[Token(Token = "0x400050D")]
		public const string DAMAGERIGHTARMBLUNTICELARGE_2_REFLECTED = "damagerightarmblunticelarge_2_reflected";

		[Token(Token = "0x400050E")]
		public const string DAMAGERIGHTARMSLASHFIRESMALL_2_REFLECTED = "damagerightarmslashfiresmall_2_reflected";

		[Token(Token = "0x400050F")]
		public const string DAMAGERIGHTARMPIERCEFIRELARGE_1 = "damagerightarmpiercefirelarge_1";

		[Token(Token = "0x4000510")]
		public const string DAMAGEVESTGRAVITY_2 = "damagevestgravity_2";

		[Token(Token = "0x4000511")]
		public const string DAMAGERIGHTARMSLASHLIGHTNINGLARGE_2_REFLECTED = "damagerightarmslashlightninglarge_2_reflected";

		[Token(Token = "0x4000512")]
		public const string DAMAGERIGHTARMSLASHICESMALL_2 = "damagerightarmslashicesmall_2";

		[Token(Token = "0x4000513")]
		public const string DAMAGEVESTSLASHFIRELARGERLD_1 = "damagevestslashfirelargerld_1";

		[Token(Token = "0x4000514")]
		public const string HOLSTERRIGHTSHOULDER_1 = "holsterrightshoulder_1";

		[Token(Token = "0x4000515")]
		public const string DAMAGERIGHTARMSLASHLIGHTNINGLARGE_2 = "damagerightarmslashlightninglarge_2";

		[Token(Token = "0x4000516")]
		public const string DAMAGEVESTGRAVITY_1 = "damagevestgravity_1";

		[Token(Token = "0x4000517")]
		public const string PLAYERMELEEBLADEWOODSLASHRIGHT_1_REFLECTED = "playermeleebladewoodslashright_1_reflected";

		[Token(Token = "0x4000518")]
		public const string DAMAGERIGHTARMPIERCEBLADELARGE_1 = "damagerightarmpiercebladelarge_1";

		[Token(Token = "0x4000519")]
		public const string DAMAGEVESTICEARROW_1 = "damagevesticearrow_1";

		[Token(Token = "0x400051A")]
		public const string DAMAGEVESTBLUNTSTONESMALL_1 = "damagevestbluntstonesmall_1";

		[Token(Token = "0x400051B")]
		public const string PLAYERMELEEBLADESTONEBLUNTRIGHT_1 = "playermeleebladestonebluntright_1";

		[Token(Token = "0x400051C")]
		public const string DAMAGEVESTFIREARROW_1 = "damagevestfirearrow_1";

		[Token(Token = "0x400051D")]
		public const string DAMAGEVESTPIERCEFIRELARGE_1 = "damagevestpiercefirelarge_1";

		[Token(Token = "0x400051E")]
		public const string PLAYERTELEKINESISACTIVERIGHT_1_REFLECTED = "playertelekinesisactiveright_1_reflected";

		[Token(Token = "0x400051F")]
		public const string PLAYERMELEEBLADEMETALPIERCERIGHT_1 = "playermeleeblademetalpierceright_1";

		[Token(Token = "0x4000520")]
		public const string PLAYERPUNCHOTHERRIGHT_1_REFLECTED = "playerpunchotherright_1_reflected";

		[Token(Token = "0x4000521")]
		public const string DAMAGEVESTSLASHBLADELARGERLD_1 = "damagevestslashbladelargerld_1";

		[Token(Token = "0x4000522")]
		public const string DAMAGERIGHTARMBLUNTBLADESMALL_1_REFLECTED = "damagerightarmbluntbladesmall_1_reflected";

		[Token(Token = "0x4000523")]
		public const string DAMAGERIGHTARMGRAVITY_3_REFLECTED = "damagerightarmgravity_3_reflected";

		[Token(Token = "0x4000524")]
		public const string DAMAGERIGHTARMBLUNTFLESHLARGE_1_REFLECTED = "damagerightarmbluntfleshlarge_1_reflected";

		[Token(Token = "0x4000525")]
		public const string DAMAGEVESTARROW_1 = "damagevestarrow_1";

		[Token(Token = "0x4000526")]
		public const string DAMAGERIGHTARMGRAVITY_3 = "damagerightarmgravity_3";

		[Token(Token = "0x4000527")]
		public const string PLAYERPUNCHFLESHRIGHT_1 = "playerpunchfleshright_1";

		[Token(Token = "0x4000528")]
		public const string HOLSTERARROWRIGHTSHOULDER_1 = "holsterarrowrightshoulder_1";

		[Token(Token = "0x4000529")]
		public const string PLAYERPUNCHSTONERIGHT_1_REFLECTED = "playerpunchstoneright_1_reflected";

		[Token(Token = "0x400052A")]
		public const string PLAYERMELEEWOODSTONEBLUNTRIGHT_1_REFLECTED = "playermeleewoodstonebluntright_1_reflected";

		[Token(Token = "0x400052B")]
		public const string PLAYERMELEEBLADEWOODPIERCERIGHT_1_REFLECTED = "playermeleebladewoodpierceright_1_reflected";

		[Token(Token = "0x400052C")]
		public const string HEARTBEATFAST_1 = "heartbeatfast_1";

		[Token(Token = "0x400052D")]
		public const string PLAYERPUNCHFABRICRIGHT_1_REFLECTED = "playerpunchfabricright_1_reflected";

		[Token(Token = "0x400052E")]
		public const string DAMAGEVESTBLUNTFLESHLARGE_1 = "damagevestbluntfleshlarge_1";

		[Token(Token = "0x400052F")]
		public const string PLAYERMELEEBLADESTONEPIERCERIGHT_1 = "playermeleebladestonepierceright_1";

		[Token(Token = "0x4000530")]
		public const string PLAYERSPELLGRAVITYRIGHT_2 = "playerspellgravityright_2";

		[Token(Token = "0x4000531")]
		public const string DAMAGEVESTBLUNTFIRESMALL_1 = "damagevestbluntfiresmall_1";

		[Token(Token = "0x4000532")]
		public const string POISONDRINKING_1 = "poisondrinking_1";

		[Token(Token = "0x4000533")]
		public const string DAMAGERIGHTARMBLUNTFLESHSMALL_1_REFLECTED = "damagerightarmbluntfleshsmall_1_reflected";

		[Token(Token = "0x4000534")]
		public const string DAMAGERIGHTARMDRAIN_1_REFLECTED = "damagerightarmdrain_1_reflected";

		[Token(Token = "0x4000535")]
		public const string DAMAGERIGHTARMPIERCEICESMALL_1 = "damagerightarmpierceicesmall_1";

		[Token(Token = "0x4000536")]
		public const string DAMAGERIGHTARMENERGY_2 = "damagerightarmenergy_2";

		[Token(Token = "0x4000537")]
		public const string PLAYERSPELLFIRERIGHT_3 = "playerspellfireright_3";

		[Token(Token = "0x4000538")]
		public const string PLAYERMELEEBLADESTONEBLUNTRIGHT_1_REFLECTED = "playermeleebladestonebluntright_1_reflected";

		[Token(Token = "0x4000539")]
		public const string DAMAGEVESTPIERCEBLADELARGE_1 = "damagevestpiercebladelarge_1";

		[Token(Token = "0x400053A")]
		public const string PLAYERSPELLLIGHTNINGRIGHT_1 = "playerspelllightningright_1";

		[Token(Token = "0x400053B")]
		public const string DAMAGERIGHTARMBLUNTLIGHTNINGSMALL_1_REFLECTED = "damagerightarmbluntlightningsmall_1_reflected";

		[Token(Token = "0x400053C")]
		public const string PLAYERTHROWRIGHT_1 = "playerthrowright_1";

		[Token(Token = "0x400053D")]
		public const string DAMAGEVESTBLUNTFIRELARGE_1 = "damagevestbluntfirelarge_1";

		[Token(Token = "0x400053E")]
		public const string PLAYERPUNCHMETALRIGHT_1 = "playerpunchmetalright_1";

		[Token(Token = "0x400053F")]
		public const string DAMAGERIGHTARMBLUNTWOODSMALL_1 = "damagerightarmbluntwoodsmall_1";

		[Token(Token = "0x4000540")]
		public const string PLAYERMELEESTONEFABRICBLUNTRIGHT_1_REFLECTED = "playermeleestonefabricbluntright_1_reflected";

		[Token(Token = "0x4000541")]
		public const string DAMAGEVESTBLUNTICELARGE_2 = "damagevestblunticelarge_2";

		[Token(Token = "0x4000542")]
		public const string DAMAGERIGHTARMBLUNTFLESHLARGE_1 = "damagerightarmbluntfleshlarge_1";

		[Token(Token = "0x4000543")]
		public const string DAMAGERIGHTARMBLUNTLIGHTNINGSMALL_1 = "damagerightarmbluntlightningsmall_1";

		[Token(Token = "0x4000544")]
		public const string DAMAGERIGHTARMSLASHICESMALL_2_REFLECTED = "damagerightarmslashicesmall_2_reflected";

		[Token(Token = "0x4000545")]
		public const string DAMAGEVESTBLUNTFLESHSMALL_1 = "damagevestbluntfleshsmall_1";

		[Token(Token = "0x4000546")]
		public const string DAMAGERIGHTARMSLASHFIRELARGE_2 = "damagerightarmslashfirelarge_2";

		[Token(Token = "0x4000547")]
		public const string DAMAGERIGHTARMFIREARROW_1 = "damagerightarmfirearrow_1";

		[Token(Token = "0x4000548")]
		public const string PLAYERSPELLLIGHTNINGRIGHT_1_REFLECTED = "playerspelllightningright_1_reflected";

		[Token(Token = "0x4000549")]
		public const string DAMAGEVESTBLUNTSTONELARGE_1 = "damagevestbluntstonelarge_1";

		[Token(Token = "0x400054A")]
		public const string DAMAGERIGHTARMICEARROW_1_REFLECTED = "damagerightarmicearrow_1_reflected";

		[Token(Token = "0x400054B")]
		public const string EQUIPCHEST_1 = "equipchest_1";

		[Token(Token = "0x400054C")]
		public const string DAMAGERIGHTARMBLUNTBLADELARGE_1_REFLECTED = "damagerightarmbluntbladelarge_1_reflected";

		[Token(Token = "0x400054D")]
		public const string DAMAGERIGHTARMSLASHLIGHTNINGSMALL_2 = "damagerightarmslashlightningsmall_2";

		[Token(Token = "0x400054E")]
		public const string DAMAGERIGHTARMPIERCEBLADESMALL_2 = "damagerightarmpiercebladesmall_2";

		[Token(Token = "0x400054F")]
		public const string DAMAGERIGHTARMSLASHICELARGE_2 = "damagerightarmslashicelarge_2";

		[Token(Token = "0x4000550")]
		public const string PLAYERMELEEWOODSTONEBLUNTRIGHT_1 = "playermeleewoodstonebluntright_1";

		[Token(Token = "0x4000551")]
		public const string DAMAGEVESTICE_1 = "damagevestice_1";

		[Token(Token = "0x4000552")]
		public const string DAMAGERIGHTARMPIERCELIGHTNINGLARGE_1 = "damagerightarmpiercelightninglarge_1";

		[Token(Token = "0x4000553")]
		public const string PLAYERMELEEBLADEFABRICPIERCERIGHT_1 = "playermeleebladefabricpierceright_1";

		[Token(Token = "0x4000554")]
		public const string DAMAGEVESTSLASHBLADESMALLRLU_1 = "damagevestslashbladesmallrlu_1";

		[Token(Token = "0x4000555")]
		public const string DAMAGEVESTBLUNTLIGHTNINGLARGE_2 = "damagevestbluntlightninglarge_2";

		[Token(Token = "0x4000556")]
		public const string DAMAGERIGHTARMBLUNTWOODLARGE_1_REFLECTED = "damagerightarmbluntwoodlarge_1_reflected";

		[Token(Token = "0x4000557")]
		public const string DAMAGEVESTBLUNTBLADELARGE_1 = "damagevestbluntbladelarge_1";

		[Token(Token = "0x4000558")]
		public const string UNHOLSTERARROWRIGHTSHOULDER_1 = "unholsterarrowrightshoulder_1";

		[Token(Token = "0x4000559")]
		public const string HOLSTERLEFTSHOULDER_1 = "holsterleftshoulder_1";

		[Token(Token = "0x400055A")]
		public const string DAMAGEVESTBLUNTBLADESMALL_2 = "damagevestbluntbladesmall_2";

		[Token(Token = "0x400055B")]
		public const string DAMAGERIGHTARMPIERCEICELARGE_1_REFLECTED = "damagerightarmpierceicelarge_1_reflected";

		[Token(Token = "0x400055C")]
		public const string DAMAGERIGHTARMDRAIN_2_REFLECTED = "damagerightarmdrain_2_reflected";

		[Token(Token = "0x400055D")]
		public const string PLAYERMELEEBLADEFLESHBLUNTRIGHT_1_REFLECTED = "playermeleebladefleshbluntright_1_reflected";

		[Token(Token = "0x400055E")]
		public const string PLAYERSPELLFIRERIGHT_3_REFLECTED = "playerspellfireright_3_reflected";

		[Token(Token = "0x400055F")]
		public const string PLAYERMELEEBLADEFABRICBLUNTRIGHT_1 = "playermeleebladefabricbluntright_1";

		[Token(Token = "0x4000560")]
		public const string DAMAGEVESTSLASHLIGHTNINGSMALLRLU_1 = "damagevestslashlightningsmallrlu_1";

		[Token(Token = "0x4000561")]
		public const string DAMAGEVESTLIGHTNING_2 = "damagevestlightning_2";

		[Token(Token = "0x4000562")]
		public const string DAMAGERIGHTARMBLUNTFIRESMALL_1_REFLECTED = "damagerightarmbluntfiresmall_1_reflected";

		[Token(Token = "0x4000563")]
		public const string DAMAGEVESTSLASHLIGHTNINGSMALLRLD_1 = "damagevestslashlightningsmallrld_1";

		[Token(Token = "0x4000564")]
		public const string DAMAGERIGHTARMSLASHBLADELARGE_2_REFLECTED = "damagerightarmslashbladelarge_2_reflected";

		[Token(Token = "0x4000565")]
		public const string DAMAGERIGHTARMBLUNTICESMALL_2_REFLECTED = "damagerightarmblunticesmall_2_reflected";

		[Token(Token = "0x4000566")]
		public const string CLIMBINGRIGHT_1 = "climbingright_1";

		[Token(Token = "0x4000567")]
		public const string DAMAGEVESTSLASHLIGHTNINGSMALLLRD_1 = "damagevestslashlightningsmalllrd_1";

		[Token(Token = "0x4000568")]
		public const string DAMAGEVESTSLASHBLADELARGELRU_1 = "damagevestslashbladelargelru_1";

		[Token(Token = "0x4000569")]
		public const string DAMAGERIGHTARMICEARROW_1 = "damagerightarmicearrow_1";

		[Token(Token = "0x400056A")]
		public const string PLAYERPUNCHWOODRIGHT_1_REFLECTED = "playerpunchwoodright_1_reflected";

		[Token(Token = "0x400056B")]
		public const string PLAYERMELEEBLADEFABRICBLUNTRIGHT_1_REFLECTED = "playermeleebladefabricbluntright_1_reflected";

		[Token(Token = "0x400056C")]
		public const string DAMAGEVESTFIRE_3 = "damagevestfire_3";

		[Token(Token = "0x400056D")]
		public const string DAMAGERIGHTARMPIERCEFIRELARGE_1_REFLECTED = "damagerightarmpiercefirelarge_1_reflected";

		[Token(Token = "0x400056E")]
		public const string PLAYERMELEEWOODMETALBLUNTRIGHT_1 = "playermeleewoodmetalbluntright_1";

		[Token(Token = "0x400056F")]
		public const string DAMAGERIGHTARMSLASHBLADESMALL_2 = "damagerightarmslashbladesmall_2";

		[Token(Token = "0x4000570")]
		public const string DAMAGERIGHTARMPIERCEICELARGE_2_REFLECTED = "damagerightarmpierceicelarge_2_reflected";

		[Token(Token = "0x4000571")]
		public const string DAMAGERIGHTARMBLUNTFLESHSMALL_1 = "damagerightarmbluntfleshsmall_1";

		[Token(Token = "0x4000572")]
		public const string DAMAGERIGHTARMBLUNTLIGHTNINGLARGE_2 = "damagerightarmbluntlightninglarge_2";

		[Token(Token = "0x4000573")]
		public const string DAMAGEVESTDRAIN_2 = "damagevestdrain_2";

		[Token(Token = "0x4000574")]
		public const string DAMAGEVESTSLASHFIRESMALLLRD_1 = "damagevestslashfiresmalllrd_1";

		[Token(Token = "0x4000575")]
		public const string CLIMBINGRIGHT_1_REFLECTED = "climbingright_1_reflected";

		[Token(Token = "0x4000576")]
		public const string DAMAGERIGHTARMLIGHTNINGARROW_2_REFLECTED = "damagerightarmlightningarrow_2_reflected";

		[Token(Token = "0x4000577")]
		public const string EQUIPGAUNTLETSLEFT_1 = "equipgauntletsleft_1";

		[Token(Token = "0x4000578")]
		public const string DAMAGEVESTPIERCEBLADESMALL_1 = "damagevestpiercebladesmall_1";

		[Token(Token = "0x4000579")]
		public const string DAMAGEVESTBLUNTFIRELARGE_2 = "damagevestbluntfirelarge_2";

		[Token(Token = "0x400057A")]
		public const string PLAYERSPELLLIGHTNINGRIGHT_2 = "playerspelllightningright_2";

		[Token(Token = "0x400057B")]
		public const string UNEQUIPGAUNTLETSRIGHT_1_REFLECTED = "unequipgauntletsright_1_reflected";

		[Token(Token = "0x400057C")]
		public const string DAMAGERIGHTARMSLASHFIRESMALL_2 = "damagerightarmslashfiresmall_2";

		[Token(Token = "0x400057D")]
		public const string PLAYERMELEEBLADEFLESHSLASHRIGHT_1 = "playermeleebladefleshslashright_1";

		[Token(Token = "0x400057E")]
		public const string PLAYERMELEEBLADEFLESHPIERCERIGHT_1_REFLECTED = "playermeleebladefleshpierceright_1_reflected";

		[Token(Token = "0x400057F")]
		public const string PLAYERSPELLCRUSHRIGHT_1 = "playerspellcrushright_1";

		[Token(Token = "0x4000580")]
		public const string HEARTBEAT_1 = "heartbeat_1";

		[Token(Token = "0x4000581")]
		public const string DAMAGERIGHTARMBLUNTSTONESMALL_1 = "damagerightarmbluntstonesmall_1";

		[Token(Token = "0x4000582")]
		public const string DAMAGERIGHTARMBLUNTFIRELARGE_1 = "damagerightarmbluntfirelarge_1";

		[Token(Token = "0x4000583")]
		public const string PLAYERMELEEBLADEWOODBLUNTRIGHT_1 = "playermeleebladewoodbluntright_1";

		[Token(Token = "0x4000584")]
		public const string PLAYERMELEEBLADEFABRICPIERCERIGHT_1_REFLECTED = "playermeleebladefabricpierceright_1_reflected";

		[Token(Token = "0x4000585")]
		public const string DAMAGERIGHTARMGRAVITY_1 = "damagerightarmgravity_1";

		[Token(Token = "0x4000586")]
		public const string PLAYERTELEKINESISREPELRIGHT_1_REFLECTED = "playertelekinesisrepelright_1_reflected";

		[Token(Token = "0x4000587")]
		public const string PLAYERSPELLFIRERIGHT_2_REFLECTED = "playerspellfireright_2_reflected";

		[Token(Token = "0x4000588")]
		public const string DAMAGEVESTPIERCELIGHTNINGSMALL_1 = "damagevestpiercelightningsmall_1";

		[Token(Token = "0x4000589")]
		public const string PLAYERTELEKINESISPULLRIGHT_1 = "playertelekinesispullright_1";

		[Token(Token = "0x400058A")]
		public const string PLAYERPUNCHFABRICRIGHT_2_REFLECTED = "playerpunchfabricright_2_reflected";

		[Token(Token = "0x400058B")]
		public const string PLAYERMELEEWOODWOODBLUNTRIGHT_1 = "playermeleewoodwoodbluntright_1";

		[Token(Token = "0x400058C")]
		public const string PLAYERMELEEBLADEWOODPIERCERIGHT_1 = "playermeleebladewoodpierceright_1";

		[Token(Token = "0x400058D")]
		public const string DAMAGERIGHTARMBLUNTMETALLARGE_1 = "damagerightarmbluntmetallarge_1";

		[Token(Token = "0x400058E")]
		public const string PLAYERSPELLGRAVITYRIGHT_2_COPY_3 = "playerspellgravityright_2_copy_3";

		[Token(Token = "0x400058F")]
		public const string DAMAGEVESTLIGHTNINGARROW_1 = "damagevestlightningarrow_1";

		[Token(Token = "0x4000590")]
		public const string DAMAGEVESTSLASHFIRELARGELRU_1 = "damagevestslashfirelargelru_1";

		[Token(Token = "0x4000591")]
		public const string DAMAGERIGHTARMBLUNTLIGHTNINGLARGE_2_REFLECTED = "damagerightarmbluntlightninglarge_2_reflected";

		[Token(Token = "0x4000592")]
		public const string PLAYERMELEEBLADEFLESHBLUNTRIGHT_1 = "playermeleebladefleshbluntright_1";

		[Token(Token = "0x4000593")]
		public const string DAMAGERIGHTARMBLUNTFIRESMALL_2_REFLECTED = "damagerightarmbluntfiresmall_2_reflected";

		[Token(Token = "0x4000594")]
		public const string DAMAGEVESTFIRE_1 = "damagevestfire_1";

		[Token(Token = "0x4000595")]
		public const string DAMAGERIGHTARMLIGHTNINGARROW_1_REFLECTED = "damagerightarmlightningarrow_1_reflected";

		[Token(Token = "0x4000596")]
		public const string PLAYERPUNCHSTONERIGHT_1 = "playerpunchstoneright_1";

		[Token(Token = "0x4000597")]
		public const string DAMAGEVESTBLUNTMETALSMALL_1 = "damagevestbluntmetalsmall_1";

		[Token(Token = "0x4000598")]
		public const string DAMAGEVESTBLUNTLIGHTNINGSMALL_1 = "damagevestbluntlightningsmall_1";

		[Token(Token = "0x4000599")]
		public const string FALLDAMAGE_1 = "falldamage_1";

		[Token(Token = "0x400059A")]
		public const string DAMAGEVESTSLASHFIRELARGERLU_1 = "damagevestslashfirelargerlu_1";

		[Token(Token = "0x400059B")]
		public const string DAMAGEVESTSLASHBLADESMALLLRD_1 = "damagevestslashbladesmalllrd_1";

		[Token(Token = "0x400059C")]
		public const string DAMAGERIGHTARMPIERCELIGHTNINGSMALL_2_REFLECTED = "damagerightarmpiercelightningsmall_2_reflected";

		[Token(Token = "0x400059D")]
		public const string DAMAGERIGHTARMPIERCEICELARGE_1 = "damagerightarmpierceicelarge_1";

		[Token(Token = "0x400059E")]
		public const string DAMAGEVESTBLUNTBLADELARGE_2 = "damagevestbluntbladelarge_2";

		[Token(Token = "0x400059F")]
		public const string DAMAGEVESTLIGHTNINGARROW_2 = "damagevestlightningarrow_2";

		[Token(Token = "0x40005A0")]
		public const string DAMAGERIGHTARMBLUNTSTONELARGE_1 = "damagerightarmbluntstonelarge_1";

		[Token(Token = "0x40005A1")]
		public const string UNEQUIPGAUNTLETSRIGHT_1 = "unequipgauntletsright_1";

		[Token(Token = "0x40005A2")]
		public const string PLAYERMELEEBLADEFABRICSLASHRIGHT_1_REFLECTED = "playermeleebladefabricslashright_1_reflected";

		[Token(Token = "0x40005A3")]
		public const string DAMAGERIGHTARMPIERCELIGHTNINGLARGE_2_REFLECTED = "damagerightarmpiercelightninglarge_2_reflected";

		[Token(Token = "0x40005A4")]
		public const string DAMAGERIGHTARMSLASHBLADELARGE_2 = "damagerightarmslashbladelarge_2";

		[Token(Token = "0x40005A5")]
		public const string DAMAGEVESTSLASHBLADESMALLLRU_1 = "damagevestslashbladesmalllru_1";

		[Token(Token = "0x40005A6")]
		public const string POTIONDRINKING_1 = "potiondrinking_1";

		[Token(Token = "0x40005A7")]
		public const string PLAYERPUNCHOTHERRIGHT_1 = "playerpunchotherright_1";

		[Token(Token = "0x40005A8")]
		public const string DAMAGERIGHTARMARROW_1_REFLECTED = "damagerightarmarrow_1_reflected";

		[Token(Token = "0x40005A9")]
		public const string DAMAGERIGHTARMBLUNTBLADESMALL_2 = "damagerightarmbluntbladesmall_2";

		[Token(Token = "0x40005AA")]
		public const string DAMAGEVESTGRAVITY_3 = "damagevestgravity_3";

		[Token(Token = "0x40005AB")]
		public const string EQUIPGAUNTLETSRIGHT_1_REFLECTED = "equipgauntletsright_1_reflected";

		[Token(Token = "0x40005AC")]
		public const string PLAYERTELEKINESISACTIVERIGHT_1 = "playertelekinesisactiveright_1";

		[Token(Token = "0x40005AD")]
		public const string PLAYERMELEEBLADEFABRICSLASHRIGHT_1 = "playermeleebladefabricslashright_1";

		[Token(Token = "0x40005AE")]
		public const string PLAYERMELEEWOODFLESHBLUNTRIGHT_1 = "playermeleewoodfleshbluntright_1";

		[Token(Token = "0x40005AF")]
		public const string DAMAGEVESTICE_3 = "damagevestice_3";

		[Token(Token = "0x40005B0")]
		public const string PLAYERTELEKINESISCATCHRIGHT_1_REFLECTED = "playertelekinesiscatchright_1_reflected";

		[Token(Token = "0x40005B1")]
		public const string UNHOLSTERARROWLEFTSHOULDER_1 = "unholsterarrowleftshoulder_1";

		[Token(Token = "0x40005B2")]
		public const string DAMAGERIGHTARMBLUNTICESMALL_2 = "damagerightarmblunticesmall_2";

		[Token(Token = "0x40005B3")]
		public const string DAMAGERIGHTARMLIGHTNING_1 = "damagerightarmlightning_1";

		[Token(Token = "0x40005B4")]
		public const string PLAYERPUNCHFLESHRIGHT_1_REFLECTED = "playerpunchfleshright_1_reflected";

		[Token(Token = "0x40005B5")]
		public const string DAMAGERIGHTARMBLUNTWOODSMALL_1_REFLECTED = "damagerightarmbluntwoodsmall_1_reflected";

		[Token(Token = "0x40005B6")]
		public const string PLAYERSPELLDRAINRIGHT_1 = "playerspelldrainright_1";

		[Token(Token = "0x40005B7")]
		public const string DAMAGERIGHTARMPIERCELIGHTNINGLARGE_1_REFLECTED = "damagerightarmpiercelightninglarge_1_reflected";

		[Token(Token = "0x40005B8")]
		public const string PLAYERTELEKINESISCATCHRIGHT_1 = "playertelekinesiscatchright_1";

		[Token(Token = "0x40005B9")]
		public const string PLAYERMELEEBLADEMETALBLUNTRIGHT_1 = "playermeleeblademetalbluntright_1";

		[Token(Token = "0x40005BA")]
		public const string DAMAGERIGHTARMENERGY_2_REFLECTED = "damagerightarmenergy_2_reflected";

		[Token(Token = "0x40005BB")]
		public const string PLAYERMELEESTONEFLESHBLUNTRIGHT_1 = "playermeleestonefleshbluntright_1";

		[Token(Token = "0x40005BC")]
		public const string DAMAGEVESTSLASHFIRESMALLLRU_1 = "damagevestslashfiresmalllru_1";

		[Token(Token = "0x40005BD")]
		public const string PLAYERTHROWRIGHT_1_REFLECTED = "playerthrowright_1_reflected";

		[Token(Token = "0x40005BE")]
		public const string DAMAGEVESTPIERCEBLADESMALL_2 = "damagevestpiercebladesmall_2";

		[Token(Token = "0x40005BF")]
		public const string DAMAGERIGHTARMPIERCEBLADELARGE_2_REFLECTED = "damagerightarmpiercebladelarge_2_reflected";

		[Token(Token = "0x40005C0")]
		public const string PLAYERMELEESTONESTONEBLUNTRIGHT_1_REFLECTED = "playermeleestonestonebluntright_1_reflected";

		[Token(Token = "0x40005C1")]
		public const string DAMAGERIGHTARMPIERCEFIRELARGE_2_REFLECTED = "damagerightarmpiercefirelarge_2_reflected";

		[Token(Token = "0x40005C2")]
		public const string DAMAGERIGHTARMDRAIN_1 = "damagerightarmdrain_1";

		[Token(Token = "0x40005C3")]
		public const string PLAYERMELEEWOODFABRICBLUNTRIGHT_1 = "playermeleewoodfabricbluntright_1";

		[Token(Token = "0x40005C4")]
		public const string CONSUMABLEFOOD_1 = "consumablefood_1";

		[Token(Token = "0x40005C5")]
		public const string DAMAGEVESTBLUNTBLADESMALL_1 = "damagevestbluntbladesmall_1";

		[Token(Token = "0x40005C6")]
		public const string DAMAGEVESTBLUNTLIGHTNINGLARGE_1 = "damagevestbluntlightninglarge_1";

		[Token(Token = "0x40005C7")]
		public const string DAMAGEVESTSLASHFIRESMALLRLU_1 = "damagevestslashfiresmallrlu_1";

		[Token(Token = "0x40005C8")]
		public const string DAMAGERIGHTARMBLUNTLIGHTNINGLARGE_1_REFLECTED = "damagerightarmbluntlightninglarge_1_reflected";

		[Token(Token = "0x40005C9")]
		public const string DAMAGEVESTSLASHBLADELARGELRD_1 = "damagevestslashbladelargelrd_1";

		[Token(Token = "0x40005CA")]
		public const string DAMAGERIGHTARMBLUNTICELARGE_2 = "damagerightarmblunticelarge_2";

		[Token(Token = "0x40005CB")]
		public const string PLAYERSPELLFIRERIGHT_2 = "playerspellfireright_2";

		[Token(Token = "0x40005CC")]
		public const string DAMAGERIGHTARMPIERCEBLADESMALL_2_REFLECTED = "damagerightarmpiercebladesmall_2_reflected";

		[Token(Token = "0x40005CD")]
		public const string DAMAGERIGHTARMPIERCEBLADESMALL_1_REFLECTED = "damagerightarmpiercebladesmall_1_reflected";

		[Token(Token = "0x40005CE")]
		public const string PLAYERMELEEBLADESTONEPIERCERIGHT_1_REFLECTED = "playermeleebladestonepierceright_1_reflected";

		[Token(Token = "0x40005CF")]
		public const string PLAYERPUNCHMETALRIGHT_1_REFLECTED = "playerpunchmetalright_1_reflected";

		[Token(Token = "0x40005D0")]
		public const string DAMAGERIGHTARMSLASHICELARGE_2_REFLECTED = "damagerightarmslashicelarge_2_reflected";

		[Token(Token = "0x40005D1")]
		public const string PLAYERPUNCHFABRICRIGHT_2 = "playerpunchfabricright_2";

		[Token(Token = "0x40005D2")]
		public const string DAMAGEVESTFIRE_2 = "damagevestfire_2";

		[Token(Token = "0x40005D3")]
		public const string PLAYERSPELLLIGHTNINGRIGHT_2_REFLECTED = "playerspelllightningright_2_reflected";

		[Token(Token = "0x40005D4")]
		public const string DAMAGERIGHTARMDRAIN_3_REFLECTED = "damagerightarmdrain_3_reflected";

		[Token(Token = "0x40005D5")]
		public const string DAMAGERIGHTARMBLUNTMETALLARGE_1_REFLECTED = "damagerightarmbluntmetallarge_1_reflected";

		[Token(Token = "0x40005D6")]
		public const string DAMAGERIGHTARMSLASHLIGHTNINGSMALL_2_REFLECTED = "damagerightarmslashlightningsmall_2_reflected";

		[Token(Token = "0x40005D7")]
		public const string DAMAGERIGHTARMPIERCEFIRESMALL_1_REFLECTED = "damagerightarmpiercefiresmall_1_reflected";

		[Token(Token = "0x40005D8")]
		public const string DAMAGERIGHTARMBLUNTMETALSMALL_1 = "damagerightarmbluntmetalsmall_1";

		[Token(Token = "0x40005D9")]
		public const string DAMAGEVESTICE_2 = "damagevestice_2";

		[Token(Token = "0x40005DA")]
		public const string DAMAGEVESTBLUNTMETALLARGE_2 = "damagevestbluntmetallarge_2";

		[Token(Token = "0x40005DB")]
		public const string DAMAGERIGHTARMPIERCELIGHTNINGSMALL_1 = "damagerightarmpiercelightningsmall_1";

		[Token(Token = "0x40005DC")]
		public const string DAMAGEVESTSLASHFIRELARGELRD_1 = "damagevestslashfirelargelrd_1";

		[Token(Token = "0x40005DD")]
		public const string DAMAGERIGHTARMBLUNTBLADELARGE_1 = "damagerightarmbluntbladelarge_1";

		[Token(Token = "0x40005DE")]
		public const string PLAYERSPELLGRAVITYRIGHT_1 = "playerspellgravityright_1";

		[Token(Token = "0x40005DF")]
		public const string DAMAGEVESTBLUNTMETALLARGE_1 = "damagevestbluntmetallarge_1";

		[Token(Token = "0x40005E0")]
		public const string DAMAGERIGHTARMPIERCEFIRESMALL_1 = "damagerightarmpiercefiresmall_1";

		[Token(Token = "0x40005E1")]
		public const string DAMAGERIGHTARMBLUNTFIRELARGE_1_REFLECTED = "damagerightarmbluntfirelarge_1_reflected";

		[Token(Token = "0x40005E2")]
		public const string PLAYERMELEESTONEFABRICBLUNTRIGHT_1 = "playermeleestonefabricbluntright_1";

		[Token(Token = "0x40005E3")]
		public const string DAMAGERIGHTARMPIERCEFIRELARGE_2 = "damagerightarmpiercefirelarge_2";

		[Token(Token = "0x40005E4")]
		public const string HOLSTERARROWLEFTSHOULDER_1 = "holsterarrowleftshoulder_1";

		[Token(Token = "0x40005E5")]
		public const string DAMAGERIGHTARMPIERCEICESMALL_1_REFLECTED = "damagerightarmpierceicesmall_1_reflected";

		[Token(Token = "0x40005E6")]
		public const string DAMAGERIGHTARMBLUNTSTONESMALL_1_REFLECTED = "damagerightarmbluntstonesmall_1_reflected";

		[Token(Token = "0x40005E7")]
		public const string DAMAGERIGHTARMFIREARROW_1_REFLECTED = "damagerightarmfirearrow_1_reflected";

		[Token(Token = "0x40005E8")]
		public const string DAMAGEVESTSLASHBLADELARGERLU_1 = "damagevestslashbladelargerlu_1";

		[Token(Token = "0x40005E9")]
		public const string PLAYERSPELLCRUSHRIGHT_1_REFLECTED = "playerspellcrushright_1_reflected";

		[Token(Token = "0x40005EA")]
		public const string PLAYERMELEEWOODWOODBLUNTRIGHT_1_REFLECTED = "playermeleewoodwoodbluntright_1_reflected";

		[Token(Token = "0x40005EB")]
		public const string PLAYERSPELLDRAINRIGHT_1_REFLECTED = "playerspelldrainright_1_reflected";

		[Token(Token = "0x40005EC")]
		public const string DAMAGERIGHTARMBLUNTICESMALL_1_REFLECTED = "damagerightarmblunticesmall_1_reflected";

		[Token(Token = "0x40005ED")]
		public const string PLAYERMELEEBLADEMETALSLASHRIGHT_1_REFLECTED = "playermeleeblademetalslashright_1_reflected";

		[Token(Token = "0x40005EE")]
		public const string DAMAGERIGHTARMLIGHTNINGARROW_1 = "damagerightarmlightningarrow_1";

		[Token(Token = "0x40005EF")]
		public const string DAMAGERIGHTARMBLUNTFIRELARGE_2 = "damagerightarmbluntfirelarge_2";

		[Token(Token = "0x40005F0")]
		public const string PLAYERMELEESTONESTONEBLUNTRIGHT_1 = "playermeleestonestonebluntright_1";

		[Token(Token = "0x40005F1")]
		public const string DEFAULTDAMAGE_1 = "defaultdamage_1";

		[Token(Token = "0x40005F2")]
		public const string DAMAGERIGHTARMBLUNTSTONELARGE_1_REFLECTED = "damagerightarmbluntstonelarge_1_reflected";

		[Token(Token = "0x40005F3")]
		public const string DAMAGEVESTBLUNTLIGHTNINGSMALL_2 = "damagevestbluntlightningsmall_2";

		[Token(Token = "0x40005F4")]
		public const string DAMAGERIGHTARMBLUNTLIGHTNINGLARGE_1 = "damagerightarmbluntlightninglarge_1";

		[Token(Token = "0x40005F5")]
		public const string DAMAGERIGHTARMPIERCEBLADELARGE_2 = "damagerightarmpiercebladelarge_2";

		[Token(Token = "0x40005F6")]
		public const string PLAYERSPELLFIRERIGHT_1 = "playerspellfireright_1";

		[Token(Token = "0x40005F7")]
		public const string DAMAGEVESTSLASHLIGHTNINGLARGELRD_1 = "damagevestslashlightninglargelrd_1";

		[Token(Token = "0x40005F8")]
		public const string DAMAGERIGHTARMBLUNTBLADESMALL_1 = "damagerightarmbluntbladesmall_1";

		[Token(Token = "0x40005F9")]
		public const string DAMAGERIGHTARMDRAIN_2 = "damagerightarmdrain_2";

		[Token(Token = "0x40005FA")]
		public const string DAMAGERIGHTARMLIGHTNINGARROW_2 = "damagerightarmlightningarrow_2";

		[Token(Token = "0x40005FB")]
		public const string PLAYERSPELLLIGHTNINGRIGHT_3 = "playerspelllightningright_3";

		[Token(Token = "0x40005FC")]
		public const string PLAYERMELEEBLADEFLESHSLASHRIGHT_1_REFLECTED = "playermeleebladefleshslashright_1_reflected";

		[Token(Token = "0x40005FD")]
		public const string DAMAGERIGHTARMGRAVITY_2_REFLECTED = "damagerightarmgravity_2_reflected";

		[Token(Token = "0x40005FE")]
		public const string DAMAGERIGHTARMPIERCELIGHTNINGSMALL_2 = "damagerightarmpiercelightningsmall_2";

		[Token(Token = "0x40005FF")]
		public const string PLAYERSPELLLIGHTNINGRIGHT_3_REFLECTED = "playerspelllightningright_3_reflected";

		[Token(Token = "0x4000600")]
		public const string PLAYERMELEEBLADEMETALSLASHRIGHT_1 = "playermeleeblademetalslashright_1";

		[Token(Token = "0x4000601")]
		public const string PLAYERBOWPULLRIGHT_1 = "playerbowpullright_1";

		[Token(Token = "0x4000602")]
		public const string DAMAGERIGHTARMPIERCEBLADESMALL_1 = "damagerightarmpiercebladesmall_1";

		[Token(Token = "0x4000603")]
		public const string PLAYERMELEEBLADESTONESLASHRIGHT_1_REFLECTED = "playermeleebladestoneslashright_1_reflected";

		[Token(Token = "0x4000604")]
		public const string DAMAGERIGHTARMPIERCELIGHTSABER_1_REFLECTED = "damagerightarmpiercelightsaber_1_reflected";

		[Token(Token = "0x4000605")]
		public const string PLAYERMELEEBLADEWOODBLUNTRIGHT_1_REFLECTED = "playermeleebladewoodbluntright_1_reflected";

		[Token(Token = "0x4000606")]
		public const string SLOWMOTION_1 = "slowmotion_1";

		[Token(Token = "0x4000607")]
		public const string PLAYERMELEEWOODFABRICBLUNTRIGHT_1_REFLECTED = "playermeleewoodfabricbluntright_1_reflected";

		[Token(Token = "0x4000608")]
		public const string DAMAGERIGHTARMPIERCEICELARGE_2 = "damagerightarmpierceicelarge_2";

		[Token(Token = "0x4000609")]
		public const string DAMAGEVESTBLUNTWOODLARGE_1 = "damagevestbluntwoodlarge_1";

		[Token(Token = "0x400060A")]
		public const string PLAYERPUNCHFABRICRIGHT_1 = "playerpunchfabricright_1";

		[Token(Token = "0x400060B")]
		public const string DAMAGEVESTPIERCEFIRESMALL_1 = "damagevestpiercefiresmall_1";

		[Token(Token = "0x400060C")]
		public const string UNHOLSTERLEFTSHOULDER_1 = "unholsterleftshoulder_1";

		[Token(Token = "0x400060D")]
		public const string PLAYERSPELLGRAVITYRIGHT_1_REFLECTED = "playerspellgravityright_1_reflected";

		[Token(Token = "0x400060E")]
		public const string DAMAGERIGHTARMGRAVITY_2 = "damagerightarmgravity_2";

		[Token(Token = "0x400060F")]
		public const string DAMAGEVESTPIERCEBLADELARGE_2 = "damagevestpiercebladelarge_2";

		[Token(Token = "0x4000610")]
		public const string DAMAGERIGHTARMPIERCELIGHTSABER_1 = "damagerightarmpiercelightsaber_1";

		[Token(Token = "0x4000611")]
		public const string DAMAGEVESTSLASHFIRESMALLRLD_1 = "damagevestslashfiresmallrld_1";

		[Token(Token = "0x4000612")]
		public const string DAMAGERIGHTARMBLUNTFIRELARGE_2_REFLECTED = "damagerightarmbluntfirelarge_2_reflected";

		[Token(Token = "0x4000613")]
		public const string DAMAGEVESTBLUNTWOODSMALL_1 = "damagevestbluntwoodsmall_1";

		[Token(Token = "0x4000614")]
		public const string DAMAGERIGHTARMBLUNTBLADESMALL_2_REFLECTED = "damagerightarmbluntbladesmall_2_reflected";

		[Token(Token = "0x4000615")]
		public const string PLAYERMELEEBLADEWOODSLASHRIGHT_1 = "playermeleebladewoodslashright_1";

		[Token(Token = "0x4000616")]
		public const string DAMAGERIGHTARMBLUNTMETALSMALL_1_REFLECTED = "damagerightarmbluntmetalsmall_1_reflected";

		[Token(Token = "0x4000617")]
		public const string PLAYERMELEEBLADEFLESHPIERCERIGHT_1 = "playermeleebladefleshpierceright_1";

		[Token(Token = "0x4000618")]
		public const string DAMAGERIGHTARMBLUNTWOODLARGE_1 = "damagerightarmbluntwoodlarge_1";

		[Token(Token = "0x4000619")]
		public const string PLAYERSPELLFIRERIGHT_1_REFLECTED = "playerspellfireright_1_reflected";

		[Token(Token = "0x400061A")]
		public const string DAMAGERIGHTARMDRAIN_3 = "damagerightarmdrain_3";

		[Token(Token = "0x400061B")]
		public const string PLAYERSPELLDRAINRIGHT_2_REFLECTED = "playerspelldrainright_2_reflected";

		[Token(Token = "0x400061C")]
		public const string DAMAGEVESTSLASHBLADESMALLRLD_1 = "damagevestslashbladesmallrld_1";

		[Token(Token = "0x400061D")]
		public const string DAMAGERIGHTARMBLUNTLIGHTNINGSMALL_2 = "damagerightarmbluntlightningsmall_2";

		[Token(Token = "0x400061E")]
		public const string DAMAGEVESTSLASHLIGHTNINGLARGELRU_1 = "damagevestslashlightninglargelru_1";

		[Token(Token = "0x400061F")]
		public const string PLAYERTELEKINESISPULLRIGHT_1_REFLECTED = "playertelekinesispullright_1_reflected";

		[Token(Token = "0x4000620")]
		public const string PLAYERMELEEBLADEMETALPIERCERIGHT_1_REFLECTED = "playermeleeblademetalpierceright_1_reflected";

		[Token(Token = "0x4000621")]
		public const string DAMAGERIGHTARMPIERCELIGHTNINGLARGE_2 = "damagerightarmpiercelightninglarge_2";

		[Token(Token = "0x4000622")]
		public const string PLAYERSPELLDRAINRIGHT_2 = "playerspelldrainright_2";

		[Token(Token = "0x4000623")]
		public const string UNHOLSTERRIGHTSHOULDER_1 = "unholsterrightshoulder_1";

		[Token(Token = "0x4000624")]
		public const string PLAYERMELEEBLADESTONESLASHRIGHT_1 = "playermeleebladestoneslashright_1";

		[Token(Token = "0x4000625")]
		public const string DAMAGEVESTPIERCELIGHTNINGLARGE_1 = "damagevestpiercelightninglarge_1";

		[Token(Token = "0x4000626")]
		public const string DAMAGERIGHTARMSLASHFIRELARGE_2_REFLECTED = "damagerightarmslashfirelarge_2_reflected";

		[Token(Token = "0x4000627")]
		public const string PLAYERMELEEBLADEMETALBLUNTRIGHT_1_REFLECTED = "playermeleeblademetalbluntright_1_reflected";

		[Token(Token = "0x4000628")]
		public const string DAMAGERIGHTARMBLUNTFIRESMALL_1 = "damagerightarmbluntfiresmall_1";

		[Token(Token = "0x4000629")]
		public const string EQUIPGAUNTLETSRIGHT_1 = "equipgauntletsright_1";

		[Token(Token = "0x400062A")]
		public const string DAMAGERIGHTARMBLUNTICESMALL_1 = "damagerightarmblunticesmall_1";

		[Token(Token = "0x400062B")]
		public const string DAMAGEVESTSLASHLIGHTNINGSMALLLRU_1 = "damagevestslashlightningsmalllru_1";

		[Token(Token = "0x400062C")]
		public const string DAMAGERIGHTARMBLUNTLIGHTNINGSMALL_2_REFLECTED = "damagerightarmbluntlightningsmall_2_reflected";

		[Token(Token = "0x400062D")]
		public const string DAMAGEVESTLIGHTNING_1 = "damagevestlightning_1";

		[Token(Token = "0x400062E")]
		public const string DAMAGEVESTDRAIN_1 = "damagevestdrain_1";

		[Token(Token = "0x400062F")]
		public const string DAMAGEVESTDRAIN_3 = "damagevestdrain_3";

		[Token(Token = "0x4000630")]
		public const string DAMAGERIGHTARMARROW_1 = "damagerightarmarrow_1";

		[Token(Token = "0x4000631")]
		public const string DAMAGERIGHTARMPIERCEBLADELARGE_1_REFLECTED = "damagerightarmpiercebladelarge_1_reflected";

		[Token(Token = "0x4000632")]
		public const string DAMAGEVESTSLASHLIGHTNINGLARGERLD_1 = "damagevestslashlightninglargerld_1";

		[Token(Token = "0x4000633")]
		public const string PLAYERPUNCHWOODRIGHT_1 = "playerpunchwoodright_1";

		[Token(Token = "0x4000634")]
		public const string PLAYERTELEKINESISREPELRIGHT_1 = "playertelekinesisrepelright_1";

		[Token(Token = "0x4000635")]
		public const string DAMAGEVESTBLUNTFIRESMALL_2 = "damagevestbluntfiresmall_2";

		[Token(Token = "0x4000636")]
		public const string PLAYERBOWPULLRIGHT_1_REFLECTED = "playerbowpullright_1_reflected";

		[Token(Token = "0x4000637")]
		public const string DAMAGERIGHTARMBLUNTFIRESMALL_2 = "damagerightarmbluntfiresmall_2";

		[Token(Token = "0x4000638")]
		public const string PLAYERMELEEWOODMETALBLUNTRIGHT_1_REFLECTED = "playermeleewoodmetalbluntright_1_reflected";

		[Token(Token = "0x4000639")]
		public const string DAMAGERIGHTARMPIERCELIGHTNINGSMALL_1_REFLECTED = "damagerightarmpiercelightningsmall_1_reflected";

		[Token(Token = "0x400063A")]
		public const string DAMAGERIGHTARMGRAVITY_1_REFLECTED = "damagerightarmgravity_1_reflected";

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x12F6860", Offset = "0x12F6860", VA = "0x12F6860")]
		public BhapticsEvent()
		{
		}
	}
}
