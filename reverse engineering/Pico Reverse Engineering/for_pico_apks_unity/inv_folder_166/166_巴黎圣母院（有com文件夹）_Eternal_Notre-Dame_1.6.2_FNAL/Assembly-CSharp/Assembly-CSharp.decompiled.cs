using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Cinemachine;
using CrazyMinnow.SALSA;
using CrazyMinnow.SALSA.TextSync;
using Dreamteck.Splines;
using Emissive;
using Emissive.Extensions;
using Emissive.Tools.VRPointer;
using Facebook.WitAi;
using Facebook.WitAi.Lib;
using HTC.UnityPlugin.ColliderEvent;
using Il2CppDummyDll;
using Malee.List;
using MemoriesQuarry;
using Oculus.Platform;
using Oculus.Platform.Models;
using StepRoom;
using TMPro;
using Unity.Collections;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.ParticleSystemJobs;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

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
	[Address(RVA = "0xFF0D98", Offset = "0xFF0D98", VA = "0xFF0D98")]
	public void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xFF0D9C", Offset = "0xFF0D9C", VA = "0xFF0D9C")]
	public void ChangeMaterial()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xFF0E00", Offset = "0xFF0E00", VA = "0xFF0E00")]
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
	[Address(RVA = "0x1DAF218", Offset = "0x1DAF218", VA = "0x1DAF218")]
	public void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1DAF320", Offset = "0x1DAF320", VA = "0x1DAF320")]
	public void DisableOnStart()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1DAF358", Offset = "0x1DAF358", VA = "0x1DAF358")]
	public void CheckDisable()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1DAF434", Offset = "0x1DAF434", VA = "0x1DAF434")]
	public void CheckEnable()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1DAF510", Offset = "0x1DAF510", VA = "0x1DAF510")]
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
	[Address(RVA = "0x1E6EA88", Offset = "0x1E6EA88", VA = "0x1E6EA88")]
	public void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1E6EB8C", Offset = "0x1E6EB8C", VA = "0x1E6EB8C")]
	public void Update()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1E6EB3C", Offset = "0x1E6EB3C", VA = "0x1E6EB3C")]
	public void LookCam()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1E6EB9C", Offset = "0x1E6EB9C", VA = "0x1E6EB9C")]
	public LookAtCamera()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FEFD4", Offset = "0x9FEFD4")]
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
	[Address(RVA = "0xE319A0", Offset = "0xE319A0", VA = "0xE319A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE31CE0", Offset = "0xE31CE0", VA = "0xE31CE0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xE319A4", Offset = "0xE319A4", VA = "0xE319A4")]
	public void Init()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xE31CE4", Offset = "0xE31CE4", VA = "0xE31CE4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE3216C", Offset = "0xE3216C", VA = "0xE3216C")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE3219C", Offset = "0xE3219C", VA = "0xE3219C")]
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
	[Address(RVA = "0x1D23BC0", Offset = "0x1D23BC0", VA = "0x1D23BC0")]
	public void Start()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1D24330", Offset = "0x1D24330", VA = "0x1D24330")]
	public void Update()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1D2486C", Offset = "0x1D2486C", VA = "0x1D2486C")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1D248AC", Offset = "0x1D248AC", VA = "0x1D248AC")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1D23CE8", Offset = "0x1D23CE8", VA = "0x1D23CE8")]
	public void FindRequiredComponents()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1D24008", Offset = "0x1D24008", VA = "0x1D24008")]
	public void RandomizeStartAnimationFrame()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1D242D0", Offset = "0x1D242D0", VA = "0x1D242D0")]
	public void InitAvoidanceValues()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1D23F14", Offset = "0x1D23F14", VA = "0x1D23F14")]
	public void SetRandomScale()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1D2439C", Offset = "0x1D2439C", VA = "0x1D2439C")]
	public void SoarTimeLimit()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1D24400", Offset = "0x1D24400", VA = "0x1D24400")]
	public void CheckForDistanceToWaypoint()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1D244C4", Offset = "0x1D244C4", VA = "0x1D244C4")]
	public void RotationBasedOnWaypointOrAvoidance()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1D24B98", Offset = "0x1D24B98", VA = "0x1D24B98")]
	public bool Avoidance()
	{
		return default(bool);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1D24700", Offset = "0x1D24700", VA = "0x1D24700")]
	public void LimitRotationOfModel()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1D23E68", Offset = "0x1D23E68", VA = "0x1D23E68")]
	public void Wander(float delay)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1D25094", Offset = "0x1D25094", VA = "0x1D25094")]
	public void SetRandomMode()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1D24958", Offset = "0x1D24958", VA = "0x1D24958")]
	public void Flap()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1D23F5C", Offset = "0x1D23F5C", VA = "0x1D23F5C")]
	public Vector3 findWaypoint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1D25158", Offset = "0x1D25158", VA = "0x1D25158")]
	public void Soar()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1D251EC", Offset = "0x1D251EC", VA = "0x1D251EC")]
	public void Dive()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1D25534", Offset = "0x1D25534", VA = "0x1D25534")]
	public void animationSpeed()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1D2583C", Offset = "0x1D2583C", VA = "0x1D2583C")]
	public FlockChild()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9FF00C", Offset = "0x9FF00C")]
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

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1D25864", Offset = "0x1D25864", VA = "0x1D25864")]
	public void Start()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1D25974", Offset = "0x1D25974", VA = "0x1D25974")]
	public void PlayRandomSound()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1D25B90", Offset = "0x1D25B90", VA = "0x1D25B90")]
	public void ScareSound()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1D25CA0", Offset = "0x1D25CA0", VA = "0x1D25CA0")]
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

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1D25CC4", Offset = "0x1D25CC4", VA = "0x1D25CC4")]
	public void Start()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1D25DC0", Offset = "0x1D25DC0", VA = "0x1D25DC0")]
	public void AddChild(int amount)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1D26048", Offset = "0x1D26048", VA = "0x1D26048")]
	public void AddChildToParent(Transform obj)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1D260A8", Offset = "0x1D260A8", VA = "0x1D260A8")]
	public void RemoveChild(int amount)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1D261E4", Offset = "0x1D261E4", VA = "0x1D261E4")]
	public void Update()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1D25EDC", Offset = "0x1D25EDC", VA = "0x1D25EDC")]
	public void InstantiateGroup()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1D26254", Offset = "0x1D26254", VA = "0x1D26254")]
	public void UpdateChildAmount()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1D262E8", Offset = "0x1D262E8", VA = "0x1D262E8")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1D24A38", Offset = "0x1D24A38", VA = "0x1D24A38")]
	public void SetFlockRandomPosition()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1D264C4", Offset = "0x1D264C4", VA = "0x1D264C4")]
	public void destroyBirds()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1D265C4", Offset = "0x1D265C4", VA = "0x1D265C4")]
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

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1D2671C", Offset = "0x1D2671C", VA = "0x1D2671C")]
	private void CheckProximityToLandingSpots()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1D267F4", Offset = "0x1D267F4", VA = "0x1D267F4")]
	private void IterateLandingSpots()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1D268B4", Offset = "0x1D268B4", VA = "0x1D268B4")]
	private bool CheckDistanceToLandingSpot(LandingSpotController lc)
	{
		return default(bool);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1D26A10", Offset = "0x1D26A10", VA = "0x1D26A10")]
	private void Invoker()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1D26AA4", Offset = "0x1D26AA4", VA = "0x1D26AA4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1D26B1C", Offset = "0x1D26B1C", VA = "0x1D26B1C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1D26B6C", Offset = "0x1D26B6C", VA = "0x1D26B6C")]
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

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1D26B84", Offset = "0x1D26B84", VA = "0x1D26B84")]
	public void Start()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1D26C88", Offset = "0x1D26C88", VA = "0x1D26C88")]
	public void Trigger()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1D26CA4", Offset = "0x1D26CA4", VA = "0x1D26CA4")]
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

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1E68A54", Offset = "0x1E68A54", VA = "0x1E68A54")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1E69000", Offset = "0x1E69000", VA = "0x1E69000")]
	public LandingButtons()
	{
	}
}
[Token(Token = "0x200000C")]
public class LandingSpot : MonoBehaviour
{
	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF06C", Offset = "0x9FF06C")]
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
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1DBD3C4", Offset = "0x1DBD3C4", VA = "0x1DBD3C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x1DBD40C", Offset = "0x1DBD40C", VA = "0x1DBD40C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1DBCD84", Offset = "0x1DBCD84", VA = "0x1DBCD84")]
		[DebuggerHidden]
		public <GetFlockChild>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1DBCDB0", Offset = "0x1DBCDB0", VA = "0x1DBCDB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1DBCDB4", Offset = "0x1DBCDB4", VA = "0x1DBCDB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1DBD3CC", Offset = "0x1DBD3CC", VA = "0x1DBD3CC", Slot = "8")]
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

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1E69010", Offset = "0x1E69010", VA = "0x1E69010")]
	public void Start()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1E691F8", Offset = "0x1E691F8", VA = "0x1E691F8")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1E695C4", Offset = "0x1E695C4", VA = "0x1E695C4")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1E69D08", Offset = "0x1E69D08", VA = "0x1E69D08")]
	public void StraightenBird()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1E69BAC", Offset = "0x1E69BAC", VA = "0x1E69BAC")]
	public void RotateBird()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1E6916C", Offset = "0x1E6916C", VA = "0x1E6916C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA03D08", Offset = "0xA03D08")]
	public IEnumerator GetFlockChild(float minDelay, float maxDelay)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1E69D84", Offset = "0x1E69D84", VA = "0x1E69D84")]
	public void InstantLand()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1E6A0C4", Offset = "0x1E6A0C4", VA = "0x1E6A0C4")]
	public void ReleaseFlockChild()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1E6A3A4", Offset = "0x1E6A3A4", VA = "0x1E6A3A4")]
	public LandingSpot()
	{
	}
}
[Token(Token = "0x200000E")]
public class LandingSpotController : MonoBehaviour
{
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF07C", Offset = "0x9FF07C")]
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
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x14C0158", Offset = "0x14C0158", VA = "0x14C0158", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x14C01A0", Offset = "0x14C01A0", VA = "0x14C01A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x14BFF94", Offset = "0x14BFF94", VA = "0x14BFF94")]
		[DebuggerHidden]
		public <InstantLandOnStart>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x14BFFC0", Offset = "0x14BFFC0", VA = "0x14BFFC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x14BFFC4", Offset = "0x14BFFC4", VA = "0x14BFFC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x14C0160", Offset = "0x14C0160", VA = "0x14C0160", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF08C", Offset = "0x9FF08C")]
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
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x14BFF44", Offset = "0x14BFF44", VA = "0x14BFF44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x14BFF8C", Offset = "0x14BFF8C", VA = "0x14BFF8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x14BFD80", Offset = "0x14BFD80", VA = "0x14BFD80")]
		[DebuggerHidden]
		public <InstantLand>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x14BFDAC", Offset = "0x14BFDAC", VA = "0x14BFDAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x14BFDB0", Offset = "0x14BFDB0", VA = "0x14BFDB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x14BFF4C", Offset = "0x14BFF4C", VA = "0x14BFF4C", Slot = "8")]
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

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1E6A3AC", Offset = "0x1E6A3AC", VA = "0x1E6A3AC")]
	public void Start()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1E68E38", Offset = "0x1E68E38", VA = "0x1E68E38")]
	public void ScareAll()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1E6A684", Offset = "0x1E6A684", VA = "0x1E6A684")]
	public void ScareAll(float minDelay, float maxDelay)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1E68E44", Offset = "0x1E68E44", VA = "0x1E68E44")]
	public void LandAll()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1E6A5FC", Offset = "0x1E6A5FC", VA = "0x1E6A5FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA03DB8", Offset = "0xA03DB8")]
	public IEnumerator InstantLandOnStart(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1E68F78", Offset = "0x1E68F78", VA = "0x1E68F78")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA03E18", Offset = "0xA03E18")]
	public IEnumerator InstantLand(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1E6A7D8", Offset = "0x1E6A7D8", VA = "0x1E6A7D8")]
	public LandingSpotController()
	{
	}
}
[Token(Token = "0x2000011")]
public class Audio_Anims : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF09C", Offset = "0x9FF09C")]
	private sealed class <>c
	{
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<AudioClip, float> <>9__15_0;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1DB862C", Offset = "0x1DB862C", VA = "0x1DB862C")]
		public <>c()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1DB8634", Offset = "0x1DB8634", VA = "0x1DB8634")]
		internal float <GetRandomSourceClip>b__15_0(AudioClip item)
		{
			return default(float);
		}
	}

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00384", Offset = "0xA00384")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00384", Offset = "0xA00384")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00384", Offset = "0xA00384")]
	[SerializeField]
	public bool Ignore;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA003F8", Offset = "0xA003F8")]
	public float VolumeOscillationPourcentage;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA00414", Offset = "0xA00414")]
	public float PitchOscillationPourcentage;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00430", Offset = "0xA00430")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00430", Offset = "0xA00430")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00430", Offset = "0xA00430")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00430", Offset = "0xA00430")]
	public List<AudioClip> sourceAudioClip;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA004B4", Offset = "0xA004B4")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA004B4", Offset = "0xA004B4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA004B4", Offset = "0xA004B4")]
	public List<AudioClip> sourceAudioClip2;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00518", Offset = "0xA00518")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00518", Offset = "0xA00518")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00518", Offset = "0xA00518")]
	public List<AudioClip> sourceAudioClip3;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA0057C", Offset = "0xA0057C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0057C", Offset = "0xA0057C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA0057C", Offset = "0xA0057C")]
	public List<AudioClip> sourceAudioClip4;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA005E0", Offset = "0xA005E0")]
	public AudioSource objectAudioSource;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<List<AudioClip>> sourceAudioShuffled;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int[] sourceClipIndex;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float pitchMin;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float pitchMax;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float volMin;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float volMax;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private AudioSource source;

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1CAACF0", Offset = "0x1CAACF0", VA = "0x1CAACF0")]
	public AudioClip GetRandomSourceClip(List<AudioClip> iList, int iIndex)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1CAB02C", Offset = "0x1CAB02C", VA = "0x1CAB02C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1CAB244", Offset = "0x1CAB244", VA = "0x1CAB244")]
	private void Oscillation()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1CAB2C4", Offset = "0x1CAB2C4", VA = "0x1CAB2C4")]
	public void PlaySound(int FunctionIndex)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1CAB424", Offset = "0x1CAB424", VA = "0x1CAB424")]
	public Audio_Anims()
	{
	}
}
[Token(Token = "0x2000013")]
public class Audio_Fade : MonoBehaviour
{
	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource oSource;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA005F4", Offset = "0xA005F4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA005F4", Offset = "0xA005F4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA005F4", Offset = "0xA005F4")]
	public float duration;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float targetVolume;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float targetVolumeOff;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1CAB4D8", Offset = "0x1CAB4D8", VA = "0x1CAB4D8")]
	public void FadeIn()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1CAB5F0", Offset = "0x1CAB5F0", VA = "0x1CAB5F0")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1CAB670", Offset = "0x1CAB670", VA = "0x1CAB670")]
	public Audio_Fade()
	{
	}
}
[Token(Token = "0x2000014")]
public static class FadeMixerGroup
{
	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF0AC", Offset = "0x9FF0AC")]
	private sealed class <StartFade>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioMixer audioMixer;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string exposedParam;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float targetVolume;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float duration;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <currentTime>5__2;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <currentVol>5__3;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <targetValue>5__4;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x1DBAFAC", Offset = "0x1DBAFAC", VA = "0x1DBAFAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x1DBAFF4", Offset = "0x1DBAFF4", VA = "0x1DBAFF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1DBAE5C", Offset = "0x1DBAE5C", VA = "0x1DBAE5C")]
		[DebuggerHidden]
		public <StartFade>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1DBAE88", Offset = "0x1DBAE88", VA = "0x1DBAE88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1DBAE8C", Offset = "0x1DBAE8C", VA = "0x1DBAE8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1DBAFB4", Offset = "0x1DBAFB4", VA = "0x1DBAFB4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1D21A00", Offset = "0x1D21A00", VA = "0x1D21A00")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA03F18", Offset = "0xA03F18")]
	public static IEnumerator StartFade(AudioMixer audioMixer, string exposedParam, float duration, float targetVolume)
	{
		return null;
	}
}
[Token(Token = "0x2000016")]
public class Audio_Footsteps : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF0BC", Offset = "0x9FF0BC")]
	private sealed class <>c
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<AudioClip, float> <>9__15_0;

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1DB86A0", Offset = "0x1DB86A0", VA = "0x1DB86A0")]
		public <>c()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1DB86A8", Offset = "0x1DB86A8", VA = "0x1DB86A8")]
		internal float <GetRandomSourceClip>b__15_0(AudioClip item)
		{
			return default(float);
		}
	}

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00664", Offset = "0xA00664")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00664", Offset = "0xA00664")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00664", Offset = "0xA00664")]
	private bool Ignore;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA006D8", Offset = "0xA006D8")]
	public float VolumeOscillationPourcentage;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA006F4", Offset = "0xA006F4")]
	public float PitchOscillationPourcentage;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<AudioClip> sourceAudioClip;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00710", Offset = "0xA00710")]
	public bool hasLayer;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00724", Offset = "0xA00724")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00724", Offset = "0xA00724")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00724", Offset = "0xA00724")]
	public List<AudioClip> sourceLayerClip;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00788", Offset = "0xA00788")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00788", Offset = "0xA00788")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00788", Offset = "0xA00788")]
	public List<AudioClip> sourceHandClip;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA007EC", Offset = "0xA007EC")]
	public AudioSource objectAudioSource;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<List<AudioClip>> sourceAudioShuffled;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int[] sourceClipIndex;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float pitchMin;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float pitchMax;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float volMin;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float volMax;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private AudioSource source;

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1CAB678", Offset = "0x1CAB678", VA = "0x1CAB678")]
	public AudioClip GetRandomSourceClip(List<AudioClip> iList, int iIndex)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1CAB9B4", Offset = "0x1CAB9B4", VA = "0x1CAB9B4")]
	private void Start()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1CABBA0", Offset = "0x1CABBA0", VA = "0x1CABBA0")]
	private void Oscillation()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1CABC20", Offset = "0x1CABC20", VA = "0x1CABC20")]
	private void PlayFoot()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1CABD50", Offset = "0x1CABD50", VA = "0x1CABD50")]
	private void PlayHand()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1CABDD0", Offset = "0x1CABDD0", VA = "0x1CABDD0")]
	public Audio_Footsteps()
	{
	}
}
[Token(Token = "0x2000018")]
public class Audio_MixLevels : MonoBehaviour
{
	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioMixer masterMixer;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string parameter;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float duration;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float tVolume;

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1CABE84", Offset = "0x1CABE84", VA = "0x1CABE84")]
	public void SetImpairScene(float busImpairSceneVol)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1CABEEC", Offset = "0x1CABEEC", VA = "0x1CABEEC")]
	public void SetImpairEnv(float busImpairEnvVol)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1CABF54", Offset = "0x1CABF54", VA = "0x1CABF54")]
	public void SetPairScene(float busPairSceneVol)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1CABFBC", Offset = "0x1CABFBC", VA = "0x1CABFBC")]
	public void SetPairEnv(float busPairEnvVol)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1CAC024", Offset = "0x1CAC024", VA = "0x1CAC024")]
	public void SetMusic(float busMusicVol)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1CAC08C", Offset = "0x1CAC08C", VA = "0x1CAC08C")]
	public void MixerFaderParameter(string exposedParameter)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1CAC094", Offset = "0x1CAC094", VA = "0x1CAC094")]
	public void MixerFaderDuration(float durationFade)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1CAC09C", Offset = "0x1CAC09C", VA = "0x1CAC09C")]
	public void MixerFaderTarget(float targetVolume)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1CAC0A4", Offset = "0x1CAC0A4", VA = "0x1CAC0A4")]
	public void MixerFaderControl()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1CAC0E0", Offset = "0x1CAC0E0", VA = "0x1CAC0E0")]
	public Audio_MixLevels()
	{
	}
}
[Serializable]
[Token(Token = "0x2000019")]
public class Audio_Randomizer : MonoBehaviour
{
	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip[] audioClipArray;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource source;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int audioClipIndex;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int[] previousArray;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int previousArrayIndex;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject[] sourceClipArray;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int sourceClipIndex;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject location;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float nextActionTime;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float period;

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1CAC0E8", Offset = "0x1CAC0E8", VA = "0x1CAC0E8")]
	private void Start()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1CAC118", Offset = "0x1CAC118", VA = "0x1CAC118")]
	public GameObject GetRandomSource()
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1CAC198", Offset = "0x1CAC198", VA = "0x1CAC198")]
	public AudioClip GetRandomAudioClip()
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1CAC208", Offset = "0x1CAC208", VA = "0x1CAC208")]
	private bool PreviousArrayContainsSourceClipIndex()
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1CAC274", Offset = "0x1CAC274", VA = "0x1CAC274")]
	private bool PreviousArrayContainsAudioClipIndex()
	{
		return default(bool);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1CAC2E0", Offset = "0x1CAC2E0", VA = "0x1CAC2E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1CAC510", Offset = "0x1CAC510", VA = "0x1CAC510")]
	public Audio_Randomizer()
	{
	}
}
[Token(Token = "0x200001A")]
public class Audio_Snaps : MonoBehaviour
{
	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioMixerSnapshot SnapPair;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioMixerSnapshot SnapImpair;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioMixerSnapshot SnapSub01;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioMixerSnapshot SnapSub02;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioMixerSnapshot SnapSub03;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioMixerSnapshot SnapSub04;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioMixerSnapshot SnapAutoStart;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float AutoSnapTime;

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1CAC520", Offset = "0x1CAC520", VA = "0x1CAC520")]
	public void TransitionToPair(float timeToReach)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1CAC564", Offset = "0x1CAC564", VA = "0x1CAC564")]
	public void TransitionToImpPair(float timeToReach)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1CAC5A8", Offset = "0x1CAC5A8", VA = "0x1CAC5A8")]
	public void TransitionToSub01(float timeToReach)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1CAC5EC", Offset = "0x1CAC5EC", VA = "0x1CAC5EC")]
	public void TransitionToSub02(float timeToReach)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1CAC630", Offset = "0x1CAC630", VA = "0x1CAC630")]
	public void TransitionToSub03(float timeToReach)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1CAC674", Offset = "0x1CAC674", VA = "0x1CAC674")]
	public void TransitionToSub04(float timeToReach)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1CAC6B8", Offset = "0x1CAC6B8", VA = "0x1CAC6B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1CAC75C", Offset = "0x1CAC75C", VA = "0x1CAC75C")]
	public Audio_Snaps()
	{
	}
}
[Token(Token = "0x200001B")]
public static class Audio_Source_Fader
{
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF0CC", Offset = "0x9FF0CC")]
	private sealed class <StartFade>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource audioSource;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float targetVolume;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float duration;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <currentTime>5__2;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <start>5__3;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x1DB87AC", Offset = "0x1DB87AC", VA = "0x1DB87AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x1DB87F4", Offset = "0x1DB87F4", VA = "0x1DB87F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1DB86B0", Offset = "0x1DB86B0", VA = "0x1DB86B0")]
		[DebuggerHidden]
		public <StartFade>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1DB86DC", Offset = "0x1DB86DC", VA = "0x1DB86DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1DB86E0", Offset = "0x1DB86E0", VA = "0x1DB86E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1DB87B4", Offset = "0x1DB87B4", VA = "0x1DB87B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1CAB564", Offset = "0x1CAB564", VA = "0x1CAB564")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA03FC8", Offset = "0xA03FC8")]
	public static IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
	{
		return null;
	}
}
[Token(Token = "0x200001D")]
public class Audio_Trigger_Volume : MonoBehaviour
{
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00800", Offset = "0xA00800")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00800", Offset = "0xA00800")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00800", Offset = "0xA00800")]
	public bool triggerExitsClips;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool triggerEntriesClips;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00864", Offset = "0xA00864")]
	public AudioClip[] onEnterAudioClips;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip[] onExitAudioClips;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource source;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00878", Offset = "0xA00878")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00878", Offset = "0xA00878")]
	public bool triggerExitsSnaps;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool triggerEntriesSnaps;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float SnapTime;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA008C8", Offset = "0xA008C8")]
	public AudioMixerSnapshot SnapshotOnEnter;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioMixerSnapshot SnapshotOnExit;

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1CAC764", Offset = "0x1CAC764", VA = "0x1CAC764")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1CAC8E0", Offset = "0x1CAC8E0", VA = "0x1CAC8E0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1CACA5C", Offset = "0x1CACA5C", VA = "0x1CACA5C")]
	public Audio_Trigger_Volume()
	{
	}
}
[Token(Token = "0x200001E")]
public class CrowdScript : MonoBehaviour
{
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1D17498", Offset = "0x1D17498", VA = "0x1D17498")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1D1749C", Offset = "0x1D1749C", VA = "0x1D1749C")]
	public void SwitchIdle()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1D17554", Offset = "0x1D17554", VA = "0x1D17554")]
	public CrowdScript()
	{
	}
}
[Token(Token = "0x200001F")]
public class DialogAnimator_GD : MonoBehaviour
{
	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string Message;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float PausePerLetter;

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1D1B210", Offset = "0x1D1B210", VA = "0x1D1B210")]
	public void AddDialog(Dialog dialog)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1D1B288", Offset = "0x1D1B288", VA = "0x1D1B288")]
	public DialogAnimator_GD()
	{
	}
}
[Token(Token = "0x2000020")]
public class DialogMarker_GD : Marker, INotification, INotificationOptionProvider
{
	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string message;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float pausePerLetter;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA008FC", Offset = "0xA008FC")]
	private bool retroactive;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	[SerializeField]
	private bool emitOnce;

	[Token(Token = "0x1700000B")]
	public PropertyName id
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1D1B2F0", Offset = "0x1D1B2F0", VA = "0x1D1B2F0", Slot = "9")]
		get
		{
			return default(PropertyName);
		}
	}

	[Token(Token = "0x1700000C")]
	public string Message
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1D1B2F8", Offset = "0x1D1B2F8", VA = "0x1D1B2F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000D")]
	public float PausePerLetter
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1D1B300", Offset = "0x1D1B300", VA = "0x1D1B300")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700000E")]
	public NotificationFlags flags
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1D1B308", Offset = "0x1D1B308", VA = "0x1D1B308", Slot = "10")]
		get
		{
			return default(NotificationFlags);
		}
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1D1B330", Offset = "0x1D1B330", VA = "0x1D1B330")]
	public DialogMarker_GD()
	{
	}
}
[Serializable]
[Token(Token = "0x2000021")]
public class Dialog
{
	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string message;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float pausePerLetter;

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1D1B1C8", Offset = "0x1D1B1C8", VA = "0x1D1B1C8")]
	public Dialog(string _message, float _pausePerLetter)
	{
	}
}
[Token(Token = "0x2000022")]
public class DialogReceiver_GD : MonoBehaviour, INotificationReceiver
{
	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private DialogAnimator_GD dialogAnimator;

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1D1B398", Offset = "0x1D1B398", VA = "0x1D1B398", Slot = "4")]
	public void OnNotify(Playable origin, INotification notification, object context)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1D1B4C8", Offset = "0x1D1B4C8", VA = "0x1D1B4C8")]
	public DialogReceiver_GD()
	{
	}
}
[Token(Token = "0x2000023")]
public class LookAtGroup_Manager : MonoBehaviour
{
	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static LookAtGroup_Manager instance;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Character_LookAtTarget[] m_Characters;

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1E6EBA4", Offset = "0x1E6EBA4", VA = "0x1E6EBA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1E6EBF8", Offset = "0x1E6EBF8", VA = "0x1E6EBF8")]
	public void LookAllNextTarget()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1E6EC44", Offset = "0x1E6EC44", VA = "0x1E6EC44")]
	public void ResetAllTarget()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1E6ECB0", Offset = "0x1E6ECB0", VA = "0x1E6ECB0")]
	public void LookThisTarget(List<Character_LookAtTarget> perso_LookAtTimelines, GameObject target)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1E6EDD8", Offset = "0x1E6EDD8", VA = "0x1E6EDD8")]
	public void SetAllCharacterTarget(GameObject target)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1E6EE54", Offset = "0x1E6EE54", VA = "0x1E6EE54")]
	public LookAtGroup_Manager()
	{
	}
}
[Token(Token = "0x2000024")]
public class Navigation_Manager : MonoBehaviour
{
	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Perso_Navigation[] perso_Navigations;

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1241238", Offset = "0x1241238", VA = "0x1241238")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x12412BC", Offset = "0x12412BC", VA = "0x12412BC")]
	public void GoNextTarget()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1241328", Offset = "0x1241328", VA = "0x1241328")]
	public void StopAllNavigation()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1241394", Offset = "0x1241394", VA = "0x1241394")]
	public Navigation_Manager()
	{
	}
}
[Token(Token = "0x2000025")]
public class Perso_LookAtTimeline : MonoBehaviour
{
	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float RotationTime;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject NewTarget;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject LookAtTargetsParent;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] m_LookAtTargets;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int targetindex;

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xFEF418", Offset = "0xFEF418", VA = "0xFEF418")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xFEF570", Offset = "0xFEF570", VA = "0xFEF570")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xFEF578", Offset = "0xFEF578", VA = "0xFEF578")]
	public void LooktAtGameobject(GameObject obj)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xFEF724", Offset = "0xFEF724", VA = "0xFEF724")]
	public void LookNextTarget()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xFEF848", Offset = "0xFEF848", VA = "0xFEF848")]
	public void LookTarget(GameObject target)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xFEF94C", Offset = "0xFEF94C", VA = "0xFEF94C")]
	public void ResetTarget()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xFEF958", Offset = "0xFEF958", VA = "0xFEF958")]
	public Perso_LookAtTimeline()
	{
	}
}
[Token(Token = "0x2000026")]
public class Perso_Navigation : MonoBehaviour
{
	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public NavMeshAgent agent;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator anim;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject NavTargetsParent;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] m_navTargets;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int wavepointindex;

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xFEF960", Offset = "0xFEF960", VA = "0xFEF960")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xFEFAE0", Offset = "0xFEFAE0", VA = "0xFEFAE0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xFEFBA4", Offset = "0xFEFBA4", VA = "0xFEFBA4")]
	public void DefNavTarget()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xFEFCFC", Offset = "0xFEFCFC", VA = "0xFEFCFC")]
	public void StopNavigation()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xFEFD1C", Offset = "0xFEFD1C", VA = "0xFEFD1C")]
	public Perso_Navigation()
	{
	}
}
[Token(Token = "0x2000027")]
public class TimeOnText : MonoBehaviour
{
	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text myTimeText;

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xE3FE78", Offset = "0xE3FE78", VA = "0xE3FE78")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xE3FF14", Offset = "0xE3FF14", VA = "0xE3FF14")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xE3FF68", Offset = "0xE3FF68", VA = "0xE3FF68")]
	public TimeOnText()
	{
	}
}
[Token(Token = "0x2000028")]
public class TimeSpeed_Manager : MonoBehaviour
{
	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float ActualTimeScale;

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xE3FF70", Offset = "0xE3FF70", VA = "0xE3FF70")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xE3FF98", Offset = "0xE3FF98", VA = "0xE3FF98")]
	public void TheTimeScale(float myTimeScale)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xE3FFA0", Offset = "0xE3FFA0", VA = "0xE3FFA0")]
	public TimeSpeed_Manager()
	{
	}
}
[Token(Token = "0x2000029")]
public class Vcams_ForcePriority : MonoBehaviour
{
	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1DAF898", Offset = "0x1DAF898", VA = "0x1DAF898")]
	public Vcams_ForcePriority()
	{
	}
}
[Token(Token = "0x200002A")]
public class Vcams_Manager : MonoBehaviour
{
	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Vcams_Manager instance;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] m_Vcams;

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1DAF8A0", Offset = "0x1DAF8A0", VA = "0x1DAF8A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1DAFA18", Offset = "0x1DAFA18", VA = "0x1DAFA18")]
	public Vcams_Manager()
	{
	}
}
[Token(Token = "0x200002B")]
public class Vcams_PriorityTimeline : MonoBehaviour
{
	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int camIndex;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int myPriority;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vcams_ForcePriority[] vcams_ForcePriorities;

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1DAFA20", Offset = "0x1DAFA20", VA = "0x1DAFA20")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1DAFAAC", Offset = "0x1DAFAAC", VA = "0x1DAFAAC")]
	public void ForceCamPriority()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1DAFC6C", Offset = "0x1DAFC6C", VA = "0x1DAFC6C")]
	public Vcams_PriorityTimeline()
	{
	}
}
[Token(Token = "0x200002C")]
public class Vcams_PriorityTrigger : MonoBehaviour
{
	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject myVcam;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int myPriority;

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1DAFC74", Offset = "0x1DAFC74", VA = "0x1DAFC74")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1DAFC78", Offset = "0x1DAFC78", VA = "0x1DAFC78")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1DAFC7C", Offset = "0x1DAFC7C", VA = "0x1DAFC7C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1DAFD74", Offset = "0x1DAFD74", VA = "0x1DAFD74")]
	public Vcams_PriorityTrigger()
	{
	}
}
[Token(Token = "0x200002D")]
public class BlockDissolve : MonoBehaviour
{
	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool dissolving;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material m;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float t;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float speed;

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1CADDDC", Offset = "0x1CADDDC", VA = "0x1CADDDC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1CADE48", Offset = "0x1CADE48", VA = "0x1CADE48")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1CADF4C", Offset = "0x1CADF4C", VA = "0x1CADF4C")]
	public void Dissolve()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1CADF58", Offset = "0x1CADF58", VA = "0x1CADF58")]
	public BlockDissolve()
	{
	}
}
[Token(Token = "0x200002E")]
public class ChapelSolScript : MonoBehaviour
{
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1CB94A0", Offset = "0x1CB94A0", VA = "0x1CB94A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1CB94A4", Offset = "0x1CB94A4", VA = "0x1CB94A4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1CB94A8", Offset = "0x1CB94A8", VA = "0x1CB94A8")]
	public ChapelSolScript()
	{
	}
}
[Token(Token = "0x200002F")]
public class Chapel_AnimManager : MonoBehaviour
{
	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Wall1;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Joints;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Sol;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject Echafaudages;

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1CB94B0", Offset = "0x1CB94B0", VA = "0x1CB94B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1CB9540", Offset = "0x1CB9540", VA = "0x1CB9540")]
	public void AnimJoints()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1CB95B8", Offset = "0x1CB95B8", VA = "0x1CB95B8")]
	public void DestroyWall1()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1CB9768", Offset = "0x1CB9768", VA = "0x1CB9768")]
	public void GroundUp()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x1CB97E0", Offset = "0x1CB97E0", VA = "0x1CB97E0")]
	public void ActivateEchafaudages()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1CB9858", Offset = "0x1CB9858", VA = "0x1CB9858")]
	public void DeactivateEchafaudages()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1CB98D0", Offset = "0x1CB98D0", VA = "0x1CB98D0")]
	public Chapel_AnimManager()
	{
	}
}
[Token(Token = "0x2000030")]
public class Chapel_Mur1_script : MonoBehaviour
{
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF0DC", Offset = "0x9FF0DC")]
	private sealed class <DissolveBlock>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MeshRenderer mr;

		[Token(Token = "0x1700000F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1DB9BDC", Offset = "0x1DB9BDC", VA = "0x1DB9BDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x1DB9C24", Offset = "0x1DB9C24", VA = "0x1DB9C24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1DB9A44", Offset = "0x1DB9A44", VA = "0x1DB9A44")]
		[DebuggerHidden]
		public <DissolveBlock>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1DB9A70", Offset = "0x1DB9A70", VA = "0x1DB9A70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1DB9A74", Offset = "0x1DB9A74", VA = "0x1DB9A74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1DB9BE4", Offset = "0x1DB9BE4", VA = "0x1DB9BE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer[] BricksBlocks;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float modularTimer;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float Delay;

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1CB965C", Offset = "0x1CB965C", VA = "0x1CB965C")]
	public void DestroyWall1()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1CB98D8", Offset = "0x1CB98D8", VA = "0x1CB98D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05078", Offset = "0xA05078")]
	private IEnumerator DissolveBlock(MeshRenderer mr, float delay)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1CB9960", Offset = "0x1CB9960", VA = "0x1CB9960")]
	public Chapel_Mur1_script()
	{
	}
}
[Token(Token = "0x2000032")]
public class MurFenetreBrickSolve : MonoBehaviour
{
	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool solving;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool finished;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material m;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float t;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float speed;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material StandardMaterial;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MeshRenderer renderer;

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1240254", Offset = "0x1240254", VA = "0x1240254")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1240338", Offset = "0x1240338", VA = "0x1240338")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1240488", Offset = "0x1240488", VA = "0x1240488")]
	public MurFenetreBrickSolve()
	{
	}
}
[Token(Token = "0x2000033")]
public class ParticleBurstCtrl : MonoBehaviour
{
	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem Particles;

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xFECC38", Offset = "0xFECC38", VA = "0xFECC38")]
	public void PlayParticles()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xFECC74", Offset = "0xFECC74", VA = "0xFECC74")]
	public ParticleBurstCtrl()
	{
	}
}
[Token(Token = "0x2000034")]
public class ObjectCleaner : MonoBehaviour
{
	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] goToDestroy;

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x1243F84", Offset = "0x1243F84", VA = "0x1243F84")]
	public void DestroyList()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1244048", Offset = "0x1244048", VA = "0x1244048")]
	public ObjectCleaner()
	{
	}
}
[Token(Token = "0x2000035")]
public class TestingRosesAnimations : MonoBehaviour
{
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF0EC", Offset = "0x9FF0EC")]
	private sealed class <LaunchNextStep>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TestingRosesAnimations <>4__this;

		[Token(Token = "0x17000011")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x14C7DC8", Offset = "0x14C7DC8", VA = "0x14C7DC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x14C7E10", Offset = "0x14C7E10", VA = "0x14C7E10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x14C7BB8", Offset = "0x14C7BB8", VA = "0x14C7BB8")]
		[DebuggerHidden]
		public <LaunchNextStep>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x14C7BE4", Offset = "0x14C7BE4", VA = "0x14C7BE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x14C7BE8", Offset = "0x14C7BE8", VA = "0x14C7BE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x14C7DD0", Offset = "0x14C7DD0", VA = "0x14C7DD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator N;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator S;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Animator O;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int currentStep;

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xE3F360", Offset = "0xE3F360", VA = "0xE3F360")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xE3F3EC", Offset = "0xE3F3EC", VA = "0xE3F3EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05128", Offset = "0xA05128")]
	public IEnumerator LaunchNextStep()
	{
		return null;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xE3F464", Offset = "0xE3F464", VA = "0xE3F464")]
	public TestingRosesAnimations()
	{
	}
}
[Token(Token = "0x2000037")]
public class TeleportFX : MonoBehaviour
{
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF0FC", Offset = "0x9FF0FC")]
	private sealed class <FadeLight>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportFX <>4__this;

		[Token(Token = "0x17000013")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x14C7020", Offset = "0x14C7020", VA = "0x14C7020", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x14C7068", Offset = "0x14C7068", VA = "0x14C7068", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x14C6EF0", Offset = "0x14C6EF0", VA = "0x14C6EF0")]
		[DebuggerHidden]
		public <FadeLight>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x14C6F1C", Offset = "0x14C6F1C", VA = "0x14C6F1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x14C6F20", Offset = "0x14C6F20", VA = "0x14C6F20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x14C7028", Offset = "0x14C7028", VA = "0x14C7028", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem TeleportVideoParticles;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem SmokeParticles;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ParticleSystem SparkParticles;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Light TeleportLight;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioSource TeleportAudio;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float fadeStart;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float fadeEnd;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float fadeTime;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float t;

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xE3C870", Offset = "0xE3C870", VA = "0xE3C870")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xE3C874", Offset = "0xE3C874", VA = "0xE3C874")]
	public void Activate()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xE3C908", Offset = "0xE3C908", VA = "0xE3C908")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA051D8", Offset = "0xA051D8")]
	private IEnumerator FadeLight()
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xE3C980", Offset = "0xE3C980", VA = "0xE3C980")]
	public TeleportFX()
	{
	}
}
[Token(Token = "0x2000039")]
public class Teleport_Fast : MonoBehaviour
{
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF10C", Offset = "0x9FF10C")]
	private sealed class <FadeLight>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Teleport_Fast <>4__this;

		[Token(Token = "0x17000015")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x14C7B68", Offset = "0x14C7B68", VA = "0x14C7B68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x14C7BB0", Offset = "0x14C7BB0", VA = "0x14C7BB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x14C7A38", Offset = "0x14C7A38", VA = "0x14C7A38")]
		[DebuggerHidden]
		public <FadeLight>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x14C7A64", Offset = "0x14C7A64", VA = "0x14C7A64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x14C7A68", Offset = "0x14C7A68", VA = "0x14C7A68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x14C7B70", Offset = "0x14C7B70", VA = "0x14C7B70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem TeleportVideoParticles;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem SmokeParticles;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ParticleSystem SparkParticles;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Light TeleportLight;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioSource TeleportAudio;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float fadeStart;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float fadeEnd;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float fadeTime;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float t;

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xE3EF24", Offset = "0xE3EF24", VA = "0xE3EF24")]
	private void Update()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xE3EFE8", Offset = "0xE3EFE8", VA = "0xE3EFE8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05288", Offset = "0xA05288")]
	private IEnumerator FadeLight()
	{
		return null;
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xE3F060", Offset = "0xE3F060", VA = "0xE3F060")]
	public Teleport_Fast()
	{
	}
}
[Token(Token = "0x200003B")]
public class SetDisolveSphere : MonoBehaviour
{
	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool useMainCameraAsCenter;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform sphereCenter;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float radius;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool instanciateMaterial;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector4 sphere;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material[] disolveMat;

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xE2E2E4", Offset = "0xE2E2E4", VA = "0xE2E2E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xE2E454", Offset = "0xE2E454", VA = "0xE2E454")]
	public SetDisolveSphere()
	{
	}
}
[Token(Token = "0x200003C")]
[ExecuteInEditMode]
public class HideWireframe : MonoBehaviour
{
	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool Hide;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1E65780", Offset = "0x1E65780", VA = "0x1E65780")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1E65784", Offset = "0x1E65784", VA = "0x1E65784")]
	public HideWireframe()
	{
	}
}
[Token(Token = "0x200003D")]
[ExecuteInEditMode]
public class MaterialSwitch : MonoBehaviour
{
	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material[] MaterialList;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int LastMaterial;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int CurrentMaterial;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] ObjectList;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string MaterialName;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool ShowGUI;

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1E700AC", Offset = "0x1E700AC", VA = "0x1E700AC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1E700E4", Offset = "0x1E700E4", VA = "0x1E700E4")]
	private void SwitchMaterialNow()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1E70204", Offset = "0x1E70204", VA = "0x1E70204")]
	private void Update()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1E70270", Offset = "0x1E70270", VA = "0x1E70270")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1E7042C", Offset = "0x1E7042C", VA = "0x1E7042C")]
	public MaterialSwitch()
	{
	}
}
[Token(Token = "0x200003E")]
public class Rotate : MonoBehaviour
{
	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float rotationY;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float rotationX;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float rotationZ;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float time;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float Speed;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool rotate;

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xFF4E1C", Offset = "0xFF4E1C", VA = "0xFF4E1C")]
	private void Start()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xFF4E8C", Offset = "0xFF4E8C", VA = "0xFF4E8C")]
	private void Update()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xFF4F08", Offset = "0xFF4F08", VA = "0xFF4F08")]
	public Rotate()
	{
	}
}
[Token(Token = "0x200003F")]
public class SASOrbitCamera : MonoBehaviour
{
	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform Target;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Distance;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float xSpeed;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float ySpeed;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float yMinLimit;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float yMaxLimit;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float ZoomSpeed;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float x;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float y;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xFF5B54", Offset = "0xFF5B54", VA = "0xFF5B54")]
	private void Awake()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xFF5B8C", Offset = "0xFF5B8C", VA = "0xFF5B8C")]
	public bool MouseScreenCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xFF5C2C", Offset = "0xFF5C2C", VA = "0xFF5C2C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xFF5F34", Offset = "0xFF5F34", VA = "0xFF5F34")]
	private float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xFF5F64", Offset = "0xFF5F64", VA = "0xFF5F64")]
	public SASOrbitCamera()
	{
	}
}
[Token(Token = "0x2000040")]
public class ShowcaseAxis : MonoBehaviour
{
	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float rotationY;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float rotationX;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool RotateSky;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float SkyRotationSpeed;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int Elements;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material SkyMat;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int Step;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float currentRotation;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int smoothing;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float SkyDegrees;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float startupSkyRotation;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool HideCursor;

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xE305B0", Offset = "0xE305B0", VA = "0xE305B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xE306D0", Offset = "0xE306D0", VA = "0xE306D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xE3086C", Offset = "0xE3086C", VA = "0xE3086C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xE308C8", Offset = "0xE308C8", VA = "0xE308C8")]
	public ShowcaseAxis()
	{
	}
}
[Token(Token = "0x2000041")]
public class PigeonTuto : MonoBehaviour
{
	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SplinePositioner splinePositioner;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve curve;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material mat;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float startDisparition;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float startApparition;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float splineSpeed;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float splineLength;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float currentDistance;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float ellapsedTime;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float tempoPoutre;

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xFF0020", Offset = "0xFF0020", VA = "0xFF0020")]
	private void Start()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xFF005C", Offset = "0xFF005C", VA = "0xFF005C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xFF02C0", Offset = "0xFF02C0", VA = "0xFF02C0")]
	public PigeonTuto()
	{
	}
}
[Token(Token = "0x2000042")]
public class AutoBlinkBlendshape : MonoBehaviour
{
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF13C", Offset = "0x9FF13C")]
	private sealed class <Blink>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AutoBlinkBlendshape <>4__this;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1DB8920", Offset = "0x1DB8920", VA = "0x1DB8920", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1DB8968", Offset = "0x1DB8968", VA = "0x1DB8968", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1DB87FC", Offset = "0x1DB87FC", VA = "0x1DB87FC")]
		[DebuggerHidden]
		public <Blink>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1DB8828", Offset = "0x1DB8828", VA = "0x1DB8828", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1DB882C", Offset = "0x1DB882C", VA = "0x1DB882C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1DB8928", Offset = "0x1DB8928", VA = "0x1DB8928", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int blinkID;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool blinking;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	private bool unblink;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float targetValue;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float speed;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector2 Range;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SkinnedMeshRenderer smr;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Coroutine blinkCorountine;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float t;

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1CACDEC", Offset = "0x1CACDEC", VA = "0x1CACDEC")]
	private void Start()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x1CACF68", Offset = "0x1CACF68", VA = "0x1CACF68")]
	private void Update()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1CACEF0", Offset = "0x1CACEF0", VA = "0x1CACEF0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05338", Offset = "0xA05338")]
	private IEnumerator Blink()
	{
		return null;
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1CAD0B0", Offset = "0x1CAD0B0", VA = "0x1CAD0B0")]
	public AutoBlinkBlendshape()
	{
	}
}
[Token(Token = "0x2000044")]
[ExecuteInEditMode]
public class Billboarding : MonoBehaviour
{
	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool RotateYOnly;

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1CAD3C4", Offset = "0x1CAD3C4", VA = "0x1CAD3C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1CAD530", Offset = "0x1CAD530", VA = "0x1CAD530")]
	public Billboarding()
	{
	}
}
[Token(Token = "0x2000045")]
public class CarManager : MonoBehaviour
{
	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] carPrefabs;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Transform> carPositions;

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1CB80C4", Offset = "0x1CB80C4", VA = "0x1CB80C4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1CB8404", Offset = "0x1CB8404", VA = "0x1CB8404")]
	private void Update()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1CB8408", Offset = "0x1CB8408", VA = "0x1CB8408")]
	public CarManager()
	{
	}
}
[Token(Token = "0x2000046")]
public class CloudAnimator : MonoBehaviour
{
	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Material m;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float MoveSpeed;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float TresholdSpeed;

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1CBC144", Offset = "0x1CBC144", VA = "0x1CBC144")]
	[ExecuteInEditMode]
	private void Start()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1CBC1B0", Offset = "0x1CBC1B0", VA = "0x1CBC1B0")]
	private void Update()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1CBC21C", Offset = "0x1CBC21C", VA = "0x1CBC21C")]
	public CloudAnimator()
	{
	}
}
[Token(Token = "0x2000047")]
public class CristalRandomStart : MonoBehaviour
{
	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1D151D0", Offset = "0x1D151D0", VA = "0x1D151D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1D15268", Offset = "0x1D15268", VA = "0x1D15268")]
	public CristalRandomStart()
	{
	}
}
[Token(Token = "0x2000048")]
public class CrossSection2Planes : MonoBehaviour
{
	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject plane2;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] ObjectsHolder;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Renderer> Meshes;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Material> Materials;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool dontSwitchShader;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string[] ExcludedMaterials;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool ExcludeThisMaterial;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string shaderPath;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string shaderPathOpaque;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string shaderPathOpaqueSmooth;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float cutWidth;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float cutSharpness;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Color ForceColor;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Texture2D NoiseTex;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float noiseTiling;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool InverseMask;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int renderQueue;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Shader shaderDissolve;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Shader shaderDissolveOpaque;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Shader shaderDissolveOpaqueSmooth;

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x1D15270", Offset = "0x1D15270", VA = "0x1D15270")]
	private void Start()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1D158B8", Offset = "0x1D158B8", VA = "0x1D158B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1D15B74", Offset = "0x1D15B74", VA = "0x1D15B74")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x1D15BC8", Offset = "0x1D15BC8", VA = "0x1D15BC8")]
	public CrossSection2Planes()
	{
	}
}
[Token(Token = "0x2000049")]
public class CrossSectionGlass : MonoBehaviour
{
	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] ObjectsHolder;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Renderer> Meshes;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Material> Materials;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float cutWidth;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D NoiseTex;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float noiseTiling;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool InverseMask;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 previouspos;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Shader shaderDissolve;

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1D15C7C", Offset = "0x1D15C7C", VA = "0x1D15C7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1D1605C", Offset = "0x1D1605C", VA = "0x1D1605C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x1D1628C", Offset = "0x1D1628C", VA = "0x1D1628C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1D162E0", Offset = "0x1D162E0", VA = "0x1D162E0")]
	public CrossSectionGlass()
	{
	}
}
[Token(Token = "0x200004A")]
public class CrossSectionPlane : MonoBehaviour
{
	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool DontChangeMat;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool Optimize;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] ObjectsHolder;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Renderer> Meshes;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Material> Materials;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float cutWidth;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D NoiseTex;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float noiseTiling;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool InverseMask;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float LineWidth;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xA00958", Offset = "0xA00958")]
	public Color LineColor;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Shader shaderDissolve;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 previousTransform;

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1D162F0", Offset = "0x1D162F0", VA = "0x1D162F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1D16950", Offset = "0x1D16950", VA = "0x1D16950")]
	private void Update()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x1D16D40", Offset = "0x1D16D40", VA = "0x1D16D40")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1D16D94", Offset = "0x1D16D94", VA = "0x1D16D94")]
	public CrossSectionPlane()
	{
	}
}
[Token(Token = "0x200004B")]
public class CrossSectionWalls : MonoBehaviour
{
	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] ObjectsHolder;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Renderer> Meshes;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Material> Materials;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float cutWidth;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D NoiseTex;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float noiseTiling;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float albPow;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Shader shaderDissolve;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 previousPos;

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1D16E0C", Offset = "0x1D16E0C", VA = "0x1D16E0C")]
	private void Start()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1D171D8", Offset = "0x1D171D8", VA = "0x1D171D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x1D17430", Offset = "0x1D17430", VA = "0x1D17430")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x1D17484", Offset = "0x1D17484", VA = "0x1D17484")]
	public CrossSectionWalls()
	{
	}
}
[Token(Token = "0x200004C")]
public class DelayedAnimationStart : MonoBehaviour
{
	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string animationName;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float delay;

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x1D1AC34", Offset = "0x1D1AC34", VA = "0x1D1AC34")]
	private void Start()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1D1AC9C", Offset = "0x1D1AC9C", VA = "0x1D1AC9C")]
	public DelayedAnimationStart()
	{
	}
}
[Token(Token = "0x200004D")]
public class ExposureController : MonoBehaviour
{
	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float value;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Volume targetVolume;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ColorAdjustments Ca;

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1D1F62C", Offset = "0x1D1F62C", VA = "0x1D1F62C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1D1F6B8", Offset = "0x1D1F6B8", VA = "0x1D1F6B8")]
	public ExposureController()
	{
	}
}
[Token(Token = "0x200004E")]
public class FakeCharacterShadow : MonoBehaviour
{
	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float height;

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x1D21AA8", Offset = "0x1D21AA8", VA = "0x1D21AA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x1D21AE0", Offset = "0x1D21AE0", VA = "0x1D21AE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x1D21B54", Offset = "0x1D21B54", VA = "0x1D21B54")]
	public FakeCharacterShadow()
	{
	}
}
[Token(Token = "0x200004F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9FF15C", Offset = "0x9FF15C")]
public class FlameIntensity : MonoBehaviour
{
	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float minIntensity;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxIntensity;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Light l;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float random;

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x1D2260C", Offset = "0x1D2260C", VA = "0x1D2260C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1D22684", Offset = "0x1D22684", VA = "0x1D22684")]
	private void Update()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1D226F4", Offset = "0x1D226F4", VA = "0x1D226F4")]
	public FlameIntensity()
	{
	}
}
[Token(Token = "0x2000050")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9FF1BC", Offset = "0x9FF1BC")]
public class FlameProgressiveActivation : MonoBehaviour
{
	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Light l;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float TargetIntensity;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float t;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool isOn;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool isFire;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fireSpeed;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float variationRangePercent;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float variationRange;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool ping;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float random;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float minIntensity;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float maxIntensity;

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1D22710", Offset = "0x1D22710", VA = "0x1D22710")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1D227BC", Offset = "0x1D227BC", VA = "0x1D227BC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1D228D8", Offset = "0x1D228D8", VA = "0x1D228D8")]
	public FlameProgressiveActivation()
	{
	}
}
[Token(Token = "0x2000051")]
public class GenericAnimOffset : MonoBehaviour
{
	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA00970", Offset = "0xA00970")]
	public float timeOffset;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA00988", Offset = "0xA00988")]
	public float speed;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool MakeItRandom;

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1D273D4", Offset = "0x1D273D4", VA = "0x1D273D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1D276D8", Offset = "0x1D276D8", VA = "0x1D276D8")]
	public GenericAnimOffset()
	{
	}
}
[Token(Token = "0x2000052")]
public class Hair_cutdistance : MonoBehaviour
{
	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Material m;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform TargetPlane;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float dissolveOffset;

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1E5EBF8", Offset = "0x1E5EBF8", VA = "0x1E5EBF8")]
	private void Start()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1E5EC64", Offset = "0x1E5EC64", VA = "0x1E5EC64")]
	private void Update()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1E5ED70", Offset = "0x1E5ED70", VA = "0x1E5ED70")]
	public Hair_cutdistance()
	{
	}
}
[Token(Token = "0x2000053")]
public class LegacyAnimationRandStart : MonoBehaviour
{
	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA009A0", Offset = "0xA009A0")]
	public float animOffset;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animation anim;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AnimationClip aclip;

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1E6B308", Offset = "0x1E6B308", VA = "0x1E6B308")]
	private void Start()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1E6B3C4", Offset = "0x1E6B3C4", VA = "0x1E6B3C4")]
	public LegacyAnimationRandStart()
	{
	}
}
[Token(Token = "0x2000054")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9FF21C", Offset = "0x9FF21C")]
public class LightProgressiveActivation : MonoBehaviour
{
	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Light l;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float TargetIntensity;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float t;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool isOn;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool isFire;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fireSpeed;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float variationRangePercent;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float variationRange;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool ping;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float random;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float minIntensity;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float maxIntensity;

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1E6B3CC", Offset = "0x1E6B3CC", VA = "0x1E6B3CC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1E6B48C", Offset = "0x1E6B48C", VA = "0x1E6B48C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1E6B624", Offset = "0x1E6B624", VA = "0x1E6B624")]
	public LightProgressiveActivation()
	{
	}
}
[Token(Token = "0x2000055")]
public class LinearRotation : MonoBehaviour
{
	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 rotationSpeed;

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1E6B64C", Offset = "0x1E6B64C", VA = "0x1E6B64C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1E6B6D8", Offset = "0x1E6B6D8", VA = "0x1E6B6D8")]
	public LinearRotation()
	{
	}
}
[Token(Token = "0x2000056")]
public class MedievalChoirCandleTransition : MonoBehaviour
{
	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform transitionPlane;

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x123C644", Offset = "0x123C644", VA = "0x123C644")]
	private void Update()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x123C70C", Offset = "0x123C70C", VA = "0x123C70C")]
	public MedievalChoirCandleTransition()
	{
	}
}
[Token(Token = "0x2000057")]
public class ParticleEvents : MonoBehaviour
{
	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem[] PartSys;

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xFECC7C", Offset = "0xFECC7C", VA = "0xFECC7C")]
	public void ParticlePlay(int i)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xFECCCC", Offset = "0xFECCCC", VA = "0xFECCCC")]
	public void ParticleStop(int i)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xFECD1C", Offset = "0xFECD1C", VA = "0xFECD1C")]
	public ParticleEvents()
	{
	}
}
[Token(Token = "0x2000058")]
public class ParticleStopOnCollision : MonoBehaviour
{
	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem part;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ParticleCollisionEvent> collisionEvents;

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xFED30C", Offset = "0xFED30C", VA = "0xFED30C")]
	private void Start()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xFED3B4", Offset = "0xFED3B4", VA = "0xFED3B4")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xFED588", Offset = "0xFED588", VA = "0xFED588")]
	public ParticleStopOnCollision()
	{
	}
}
[Token(Token = "0x2000059")]
public class RopeTiling : MonoBehaviour
{
	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Material m;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float defaultTiling;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float offsetMultiplier;

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xFF4CE4", Offset = "0xFF4CE4", VA = "0xFF4CE4")]
	private void Start()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xFF4D7C", Offset = "0xFF4D7C", VA = "0xFF4D7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xFF4E14", Offset = "0xFF4E14", VA = "0xFF4E14")]
	public RopeTiling()
	{
	}
}
[Token(Token = "0x200005A")]
public class SetLmExposure : MonoBehaviour
{
	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] meshesParents;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Renderer> meshes;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Material> materials;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA009B8", Offset = "0xA009B8")]
	public float lmExposure;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Color lmTint;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool isAnimating;

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xE2E46C", Offset = "0xE2E46C", VA = "0xE2E46C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xE2E80C", Offset = "0xE2E80C", VA = "0xE2E80C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xE2E984", Offset = "0xE2E984", VA = "0xE2E984")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xE2E9D8", Offset = "0xE2E9D8", VA = "0xE2E9D8")]
	public void AnimateDayLight()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xE2E9E4", Offset = "0xE2E9E4", VA = "0xE2E9E4")]
	public SetLmExposure()
	{
	}
}
[Token(Token = "0x200005B")]
public class SteepleCutoutSync : MonoBehaviour
{
	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float CutoutValue;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ScaleValue;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] addGo;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float prevValue;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Material> mats;

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xE392BC", Offset = "0xE392BC", VA = "0xE392BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xE39494", Offset = "0xE39494", VA = "0xE39494")]
	private void Update()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xE39608", Offset = "0xE39608", VA = "0xE39608")]
	public SteepleCutoutSync()
	{
	}
}
[Token(Token = "0x200005C")]
public class _CameraRotate_Moth : MonoBehaviour
{
	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform targetObject;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 targetOffset;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float averageDistance;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maxDistance;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float minDistance;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float xSpeed;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float ySpeed;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int yMinLimit;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int yMaxLimit;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int zoomSpeed;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float panSpeed;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float zoomDampening;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float rotateOnOff;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float xDeg;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float yDeg;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float currentDistance;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float desiredDistance;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Quaternion currentRotation;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion desiredRotation;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Quaternion rotation;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3 position;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float idleTimer;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float idleSmooth;

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1DB39D4", Offset = "0x1DB39D4", VA = "0x1DB39D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1DB3D14", Offset = "0x1DB3D14", VA = "0x1DB3D14")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1DB39D8", Offset = "0x1DB39D8", VA = "0x1DB39D8")]
	public void Init()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1DB3D18", Offset = "0x1DB3D18", VA = "0x1DB3D18")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1DB4198", Offset = "0x1DB4198", VA = "0x1DB4198")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1DB41C8", Offset = "0x1DB41C8", VA = "0x1DB41C8")]
	public _CameraRotate_Moth()
	{
	}
}
[Token(Token = "0x200005D")]
public class GuideTransformScript : MonoBehaviour
{
	[Token(Token = "0x200005E")]
	public enum StartState
	{
		[Token(Token = "0x4000233")]
		MT,
		[Token(Token = "0x4000234")]
		XIII,
		[Token(Token = "0x4000235")]
		XIX,
		[Token(Token = "0x4000236")]
		XXI
	}

	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF27C", Offset = "0x9FF27C")]
	private sealed class <DestroyParticleSystem>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject go;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x1DBC06C", Offset = "0x1DBC06C", VA = "0x1DBC06C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x1DBC0B4", Offset = "0x1DBC0B4", VA = "0x1DBC0B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1DBBF58", Offset = "0x1DBBF58", VA = "0x1DBBF58")]
		[DebuggerHidden]
		public <DestroyParticleSystem>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1DBBF84", Offset = "0x1DBBF84", VA = "0x1DBBF84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1DBBF88", Offset = "0x1DBBF88", VA = "0x1DBBF88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1DBC074", Offset = "0x1DBC074", VA = "0x1DBC074", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public StartState StartDisplay;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject VFXBurst;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject VFXBurstFinal;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject VFXTeleport;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject BodyToEmit;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem[] Vfxs;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float TransformBurstDelay;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float TransformBurstFinalDelay;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float TeleportDelay;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float TransformBurstEditorDelay;

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1E5E508", Offset = "0x1E5E508", VA = "0x1E5E508")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1E5E684", Offset = "0x1E5E684", VA = "0x1E5E684")]
	public void TransformBurst()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1E5E838", Offset = "0x1E5E838", VA = "0x1E5E838")]
	public void TransformBurstFinal()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1E5E964", Offset = "0x1E5E964", VA = "0x1E5E964")]
	public void Teleport()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1E5EA90", Offset = "0x1E5EA90", VA = "0x1E5EA90")]
	public void StopGuideParticles()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1E5E618", Offset = "0x1E5E618", VA = "0x1E5E618")]
	public void StartGuideParticles()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1E5E7B0", Offset = "0x1E5E7B0", VA = "0x1E5E7B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA053F8", Offset = "0xA053F8")]
	private IEnumerator DestroyParticleSystem(GameObject go, float delay)
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1E5EAFC", Offset = "0x1E5EAFC", VA = "0x1E5EAFC")]
	public void XXI_to_MT()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1E5EB70", Offset = "0x1E5EB70", VA = "0x1E5EB70")]
	public void MT_to_Nothing()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1E5EBE4", Offset = "0x1E5EBE4", VA = "0x1E5EBE4")]
	public GuideTransformScript()
	{
	}
}
[Token(Token = "0x2000060")]
public class CanvasTextFade : ColorUpdater
{
	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI text;

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1CB7F6C", Offset = "0x1CB7F6C", VA = "0x1CB7F6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1CB7FC8", Offset = "0x1CB7FC8", VA = "0x1CB7FC8", Slot = "4")]
	public override void UpdateColor(Color color)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1CB80BC", Offset = "0x1CB80BC", VA = "0x1CB80BC")]
	public CanvasTextFade()
	{
	}
}
[Token(Token = "0x2000061")]
public class CharacterMTdissolver : MonoBehaviour
{
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF28C", Offset = "0x9FF28C")]
	private sealed class <DestroyVFX>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CharacterMTdissolver <>4__this;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x1DB9D4C", Offset = "0x1DB9D4C", VA = "0x1DB9D4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x1DB9D94", Offset = "0x1DB9D94", VA = "0x1DB9D94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1DB9C2C", Offset = "0x1DB9C2C", VA = "0x1DB9C2C")]
		[DebuggerHidden]
		public <DestroyVFX>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1DB9C58", Offset = "0x1DB9C58", VA = "0x1DB9C58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1DB9C5C", Offset = "0x1DB9C5C", VA = "0x1DB9C5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1DB9D54", Offset = "0x1DB9D54", VA = "0x1DB9D54", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA009D0", Offset = "0xA009D0")]
	public float TresholdCut;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xA00A08", Offset = "0xA00A08")]
	public Color Emission;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture NoiseTexture;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture EmissionTexture;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00A30", Offset = "0xA00A30")]
	public GameObject[] HairMeshes;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject VFX;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector2 ParticleTextScale;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Renderer> meshes;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Shader shaderDissolve;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string shaderPath;

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1CBAFA8", Offset = "0x1CBAFA8", VA = "0x1CBAFA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1CBB298", Offset = "0x1CBB298", VA = "0x1CBB298")]
	private void Update()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1CBB4EC", Offset = "0x1CBB4EC", VA = "0x1CBB4EC")]
	public void MeshBurst()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1CBB5A0", Offset = "0x1CBB5A0", VA = "0x1CBB5A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA054A8", Offset = "0xA054A8")]
	private IEnumerator DestroyVFX(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1CBB618", Offset = "0x1CBB618", VA = "0x1CBB618")]
	public CharacterMTdissolver()
	{
	}
}
[Token(Token = "0x2000063")]
public class MTSequencer : MonoBehaviour
{
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF29C", Offset = "0x9FF29C")]
	private sealed class <EndCharacter>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MTSequencer <>4__this;

		[Token(Token = "0x1700001D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x14C0FB8", Offset = "0x14C0FB8", VA = "0x14C0FB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x14C1000", Offset = "0x14C1000", VA = "0x14C1000", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x14C0D8C", Offset = "0x14C0D8C", VA = "0x14C0D8C")]
		[DebuggerHidden]
		public <EndCharacter>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x14C0DB8", Offset = "0x14C0DB8", VA = "0x14C0DB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x14C0DBC", Offset = "0x14C0DBC", VA = "0x14C0DBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x14C0FC0", Offset = "0x14C0FC0", VA = "0x14C0FC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isVisibleAtStart;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool DestroyAfterDisapear;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] Accesories;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Light pLight;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SkinnedMeshRenderer Bodymesh;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ParticleSystem BodyVFX;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem[] WaveVFX;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject ActivateVFX;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject DisableVFX;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject StepVFX;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform MainPosition;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform RightFootPos;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform LeftFootPos;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Material MainMat;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool isVisible;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float lightTarget;

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1E6F268", Offset = "0x1E6F268", VA = "0x1E6F268")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1E6F5CC", Offset = "0x1E6F5CC", VA = "0x1E6F5CC")]
	private void Update()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1E6FBD8", Offset = "0x1E6FBD8", VA = "0x1E6FBD8")]
	public void FootStepR()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1E6FD28", Offset = "0x1E6FD28", VA = "0x1E6FD28")]
	public void FootStepL()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x1E6FBEC", Offset = "0x1E6FBEC", VA = "0x1E6FBEC")]
	private void FootStep(bool isRight)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1E6F620", Offset = "0x1E6F620", VA = "0x1E6F620")]
	public void Activate()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1E6F968", Offset = "0x1E6F968", VA = "0x1E6F968")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1E6FD3C", Offset = "0x1E6FD3C", VA = "0x1E6FD3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05558", Offset = "0xA05558")]
	private IEnumerator EndCharacter()
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1E6FDB4", Offset = "0x1E6FDB4", VA = "0x1E6FDB4")]
	public MTSequencer()
	{
	}
}
[Token(Token = "0x2000065")]
public class MTendDissolve : MonoBehaviour
{
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF2AC", Offset = "0x9FF2AC")]
	private sealed class <DestroyVFX>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MTendDissolve <>4__this;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x14C1128", Offset = "0x14C1128", VA = "0x14C1128", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x14C1170", Offset = "0x14C1170", VA = "0x14C1170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x14C1008", Offset = "0x14C1008", VA = "0x14C1008")]
		[DebuggerHidden]
		public <DestroyVFX>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x14C1034", Offset = "0x14C1034", VA = "0x14C1034", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x14C1038", Offset = "0x14C1038", VA = "0x14C1038", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x14C1130", Offset = "0x14C1130", VA = "0x14C1130", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float FresnelValue;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float OpacityMul;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject VFX;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material mat;

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1E6FDCC", Offset = "0x1E6FDCC", VA = "0x1E6FDCC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1E6FE38", Offset = "0x1E6FE38", VA = "0x1E6FE38")]
	private void Update()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x1E6FEC0", Offset = "0x1E6FEC0", VA = "0x1E6FEC0")]
	public void MeshBurst()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1E6FF74", Offset = "0x1E6FF74", VA = "0x1E6FF74")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05608", Offset = "0xA05608")]
	private IEnumerator DestroyVFX(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1E6FFEC", Offset = "0x1E6FFEC", VA = "0x1E6FFEC")]
	public void StopParticles()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1E700A4", Offset = "0x1E700A4", VA = "0x1E700A4")]
	public MTendDissolve()
	{
	}
}
[Token(Token = "0x2000067")]
public class VFXAutoDestroy : MonoBehaviour
{
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF2BC", Offset = "0x9FF2BC")]
	private sealed class <AutoDestroy>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VFXAutoDestroy <>4__this;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x14C86E8", Offset = "0x14C86E8", VA = "0x14C86E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x14C8730", Offset = "0x14C8730", VA = "0x14C8730", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x14C85B8", Offset = "0x14C85B8", VA = "0x14C85B8")]
		[DebuggerHidden]
		public <AutoDestroy>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x14C85E4", Offset = "0x14C85E4", VA = "0x14C85E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x14C85E8", Offset = "0x14C85E8", VA = "0x14C85E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x14C86F0", Offset = "0x14C86F0", VA = "0x14C86F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float delay;

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1DAF52C", Offset = "0x1DAF52C", VA = "0x1DAF52C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1DAF558", Offset = "0x1DAF558", VA = "0x1DAF558")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA056B8", Offset = "0xA056B8")]
	private IEnumerator AutoDestroy()
	{
		return null;
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x1DAF5D0", Offset = "0x1DAF5D0", VA = "0x1DAF5D0")]
	public VFXAutoDestroy()
	{
	}
}
[Token(Token = "0x2000069")]
public class SALSA_Template_EventControllerSubscriber : MonoBehaviour
{
	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string componentEventName;

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xFF4F90", Offset = "0xFF4F90", VA = "0xFF4F90")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xFF50DC", Offset = "0xFF50DC", VA = "0xFF50DC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xFF5228", Offset = "0xFF5228", VA = "0xFF5228")]
	private void OnAnimationStarting(object sender, EventController.EventControllerNotificationArgs e)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xFF52F0", Offset = "0xFF52F0", VA = "0xFF52F0")]
	private void OnAnimationON(object sender, EventController.EventControllerNotificationArgs e)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xFF53B8", Offset = "0xFF53B8", VA = "0xFF53B8")]
	private void OnAnimationEnding(object sender, EventController.EventControllerNotificationArgs e)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xFF5480", Offset = "0xFF5480", VA = "0xFF5480")]
	private void OnAnimationOFF(object sender, EventController.EventControllerNotificationArgs e)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xFF5548", Offset = "0xFF5548", VA = "0xFF5548")]
	public SALSA_Template_EventControllerSubscriber()
	{
	}
}
[Token(Token = "0x200006A")]
public class SALSA_Template_SalsaEventSubscriber : MonoBehaviour
{
	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Salsa salsa;

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xFF5550", Offset = "0xFF5550", VA = "0xFF5550")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xFF5624", Offset = "0xFF5624", VA = "0xFF5624")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xFF56F8", Offset = "0xFF56F8", VA = "0xFF56F8")]
	private void OnStoppedSalsaing(object sender, Salsa.SalsaNotificationArgs e)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xFF5808", Offset = "0xFF5808", VA = "0xFF5808")]
	private void OnStartedSalsaing(object sender, Salsa.SalsaNotificationArgs e)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xFF5918", Offset = "0xFF5918", VA = "0xFF5918")]
	public SALSA_Template_SalsaEventSubscriber()
	{
	}
}
[Token(Token = "0x200006B")]
public class SALSA_Template_SalsaVisemeTriggerEventSubscriber : MonoBehaviour
{
	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Salsa salsaInstance;

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xFF5920", Offset = "0xFF5920", VA = "0xFF5920")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xFF59B0", Offset = "0xFF59B0", VA = "0xFF59B0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xFF5A40", Offset = "0xFF5A40", VA = "0xFF5A40")]
	private void SalsaOnVisemeTriggered(object sender, Salsa.SalsaNotificationArgs e)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xFF5B4C", Offset = "0xFF5B4C", VA = "0xFF5B4C")]
	public SALSA_Template_SalsaVisemeTriggerEventSubscriber()
	{
	}
}
[Token(Token = "0x200006C")]
public class SalsaTextSync_ExampleTextSyncTester : MonoBehaviour
{
	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SalsaTextSync salsaTextSync;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string dialogue;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool sendMessage;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool sendEvent;

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xE2C304", Offset = "0xE2C304", VA = "0xE2C304")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xE2C3BC", Offset = "0xE2C3BC", VA = "0xE2C3BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xE2C454", Offset = "0xE2C454", VA = "0xE2C454")]
	public SalsaTextSync_ExampleTextSyncTester()
	{
	}
}
[Token(Token = "0x200006D")]
public class CustomNote : MonoBehaviour
{
	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0xA00A68", Offset = "0xA00A68")]
	public string myNote;

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x1D17BB8", Offset = "0x1D17BB8", VA = "0x1D17BB8")]
	public CustomNote()
	{
	}
}
[Token(Token = "0x200006E")]
public class InactiveInBuild : MonoBehaviour
{
	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x1E65C68", Offset = "0x1E65C68", VA = "0x1E65C68")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x1E65D3C", Offset = "0x1E65D3C", VA = "0x1E65D3C")]
	public InactiveInBuild()
	{
	}
}
[Token(Token = "0x200006F")]
public class LaunchScene : MonoBehaviour
{
	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> nextSceneList;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int currentSceneIndex;

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x1E6B060", Offset = "0x1E6B060", VA = "0x1E6B060")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x1E6B258", Offset = "0x1E6B258", VA = "0x1E6B258")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x1E6B124", Offset = "0x1E6B124", VA = "0x1E6B124")]
	public void Next()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1E6B294", Offset = "0x1E6B294", VA = "0x1E6B294")]
	private void OnSceneFinishedLoading(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1E6B300", Offset = "0x1E6B300", VA = "0x1E6B300")]
	public LaunchScene()
	{
	}
}
[Token(Token = "0x2000070")]
public class ParticlesGround : MonoBehaviour
{
	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem _system;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] _particles;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Matrix4x4> _particlesGround;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform ground;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Mesh OnGroundMesh;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material OnGroundMaterial;

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xFED590", Offset = "0xFED590", VA = "0xFED590")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xFED99C", Offset = "0xFED99C", VA = "0xFED99C")]
	public ParticlesGround()
	{
	}
}
[Token(Token = "0x2000071")]
public class RustineNavMeshBroken : MonoBehaviour
{
	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool hasBeenDone;

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xFF4F18", Offset = "0xFF4F18", VA = "0xFF4F18")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xFF4F88", Offset = "0xFF4F88", VA = "0xFF4F88")]
	public RustineNavMeshBroken()
	{
	}
}
[Token(Token = "0x2000072")]
[ExecuteInEditMode]
public class AmbientAnimator : MonoBehaviour
{
	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material skybox;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light sun;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color subtractiveShadowColor;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00A80", Offset = "0xA00A80")]
	public AmbientMode ambientMode;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xA00AB8", Offset = "0xA00AB8")]
	public Color skyColor;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xA00AD0", Offset = "0xA00AD0")]
	public Color equatorColor;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xA00AE8", Offset = "0xA00AE8")]
	public Color groundColor;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00B00", Offset = "0xA00B00")]
	public Color skyboxTint;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float skyboxExposure;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00B38", Offset = "0xA00B38")]
	public bool fogEnable;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Color fogColor;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public FogMode fogMode;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float fogDensity;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float fogStartDistance;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float fogEndDistance;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00B70", Offset = "0xA00B70")]
	public Material[] matsToUpdate;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Color colorToSet;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public bool getCurrentValue;

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x1CA4908", Offset = "0x1CA4908", VA = "0x1CA4908")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x1CA491C", Offset = "0x1CA491C", VA = "0x1CA491C")]
	public void GetRenderSettings()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x1CA4AC8", Offset = "0x1CA4AC8", VA = "0x1CA4AC8")]
	public void SetRenderSettings()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x1CA4CD0", Offset = "0x1CA4CD0", VA = "0x1CA4CD0")]
	public AmbientAnimator()
	{
	}
}
[Token(Token = "0x2000073")]
public class AmbientAnimatorLerp : MonoBehaviour
{
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF2DC", Offset = "0x9FF2DC")]
	private sealed class <LerpAmbientRoutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AmbientAnimator iTarget;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AmbientAnimatorLerp <>4__this;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float lerpTime;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject <go>5__2;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AmbientAnimator <aa>5__3;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <ellapsedTime>5__4;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool <needFogModeTransition>5__5;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool <transitionHasBeenMade>5__6;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x1DB6FD4", Offset = "0x1DB6FD4", VA = "0x1DB6FD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x1DB701C", Offset = "0x1DB701C", VA = "0x1DB701C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1DB67EC", Offset = "0x1DB67EC", VA = "0x1DB67EC")]
		[DebuggerHidden]
		public <LerpAmbientRoutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1DB6818", Offset = "0x1DB6818", VA = "0x1DB6818", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1DB681C", Offset = "0x1DB681C", VA = "0x1DB681C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1DB6FDC", Offset = "0x1DB6FDC", VA = "0x1DB6FDC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Coroutine lerpCoroutine;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve lerpCurve;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float switchTime;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00BA8", Offset = "0xA00BA8")]
	public AmbientAnimator target;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool lerp;

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x1CA4CD8", Offset = "0x1CA4CD8", VA = "0x1CA4CD8")]
	public void Update()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x1CA4CF4", Offset = "0x1CA4CF4", VA = "0x1CA4CF4")]
	public void LerpAmbient(AmbientAnimator iTarget, float lerpTime = 3f)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x1CA4D80", Offset = "0x1CA4D80", VA = "0x1CA4D80")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05768", Offset = "0xA05768")]
	public IEnumerator LerpAmbientRoutine(AmbientAnimator iTarget, float lerpTime)
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x1CA4E24", Offset = "0x1CA4E24", VA = "0x1CA4E24")]
	public AmbientAnimatorLerp()
	{
	}
}
[Token(Token = "0x2000075")]
public class BlackScreenFade : MonoBehaviour
{
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF2EC", Offset = "0x9FF2EC")]
	private sealed class <ShowCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BlackScreenFade <>4__this;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x1DB8C24", Offset = "0x1DB8C24", VA = "0x1DB8C24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x1DB8C6C", Offset = "0x1DB8C6C", VA = "0x1DB8C6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1DB8AF4", Offset = "0x1DB8AF4", VA = "0x1DB8AF4")]
		[DebuggerHidden]
		public <ShowCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1DB8B20", Offset = "0x1DB8B20", VA = "0x1DB8B20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1DB8B24", Offset = "0x1DB8B24", VA = "0x1DB8B24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1DB8C2C", Offset = "0x1DB8C2C", VA = "0x1DB8C2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF2FC", Offset = "0x9FF2FC")]
	private sealed class <HideCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BlackScreenFade <>4__this;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x1DB8AA4", Offset = "0x1DB8AA4", VA = "0x1DB8AA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x1DB8AEC", Offset = "0x1DB8AEC", VA = "0x1DB8AEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1DB8970", Offset = "0x1DB8970", VA = "0x1DB8970")]
		[DebuggerHidden]
		public <HideCoroutine>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1DB899C", Offset = "0x1DB899C", VA = "0x1DB899C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1DB89A0", Offset = "0x1DB89A0", VA = "0x1DB89A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1DB8AAC", Offset = "0x1DB8AAC", VA = "0x1DB8AAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static BlackScreenFade instance;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00BE0", Offset = "0xA00BE0")]
	private CanvasGroup m_CanvasGroup;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00C2C", Offset = "0xA00C2C")]
	[SerializeField]
	private float m_TimeToFade;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool isProcessFading;

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x1CADC4C", Offset = "0x1CADC4C", VA = "0x1CADC4C")]
	public void SetFadeLevel(float fade)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x1CADC68", Offset = "0x1CADC68", VA = "0x1CADC68")]
	public float GetFadeLevel()
	{
		return default(float);
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x1CADC84", Offset = "0x1CADC84", VA = "0x1CADC84")]
	public void FadeIn()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x1CADCB0", Offset = "0x1CADCB0", VA = "0x1CADCB0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05818", Offset = "0xA05818")]
	private IEnumerator ShowCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1CADD28", Offset = "0x1CADD28", VA = "0x1CADD28")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x1CADD54", Offset = "0x1CADD54", VA = "0x1CADD54")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05878", Offset = "0xA05878")]
	private IEnumerator HideCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1CADDCC", Offset = "0x1CADDCC", VA = "0x1CADDCC")]
	public BlackScreenFade()
	{
	}
}
[Token(Token = "0x2000078")]
public class CameraCinePriority : MonoBehaviour
{
	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CameraCinePriority instance;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CinemachineVirtualCamera[] m_CinemachineVirtualCameras;

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x1CB7A00", Offset = "0x1CB7A00", VA = "0x1CB7A00")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x1CB7B04", Offset = "0x1CB7B04", VA = "0x1CB7B04")]
	public void ForceCamPriority(CinemachineVirtualCamera camera)
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x1CB7B74", Offset = "0x1CB7B74", VA = "0x1CB7B74")]
	public CameraCinePriority()
	{
	}
}
[Serializable]
[Token(Token = "0x2000079")]
public class CameraCinePriority_Behaviour : PlayableBehaviour
{
	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RTO_GameObject m_CinemachineVirtualCamera;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CameraCinePriority m_CamCinePriority;

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x1CB7B7C", Offset = "0x1CB7B7C", VA = "0x1CB7B7C", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1CB7D0C", Offset = "0x1CB7D0C", VA = "0x1CB7D0C", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1CB7D44", Offset = "0x1CB7D44", VA = "0x1CB7D44")]
	public CameraCinePriority_Behaviour()
	{
	}
}
[Token(Token = "0x200007A")]
public class CameraCinePriority_Clip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CameraCinePriority_Behaviour template;

	[Token(Token = "0x17000029")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1CB7D4C", Offset = "0x1CB7D4C", VA = "0x1CB7D4C", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1CB7D54", Offset = "0x1CB7D54", VA = "0x1CB7D54", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x1CB7E08", Offset = "0x1CB7E08", VA = "0x1CB7E08")]
	public CameraCinePriority_Clip()
	{
	}
}
[Token(Token = "0x200007B")]
public class CameraLayerDebug : MonoBehaviour
{
	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera mainCamera;

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x1CB7EDC", Offset = "0x1CB7EDC", VA = "0x1CB7EDC")]
	public void Start()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x1CB7EE0", Offset = "0x1CB7EE0", VA = "0x1CB7EE0")]
	public void ToggleStepRoom()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x1CB7F64", Offset = "0x1CB7F64", VA = "0x1CB7F64")]
	public CameraLayerDebug()
	{
	}
}
[Token(Token = "0x200007C")]
public class CharacterNav_WaypointCircuit : MonoBehaviour
{
	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Character_Navigation m_CharacterNavigation;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00C98", Offset = "0xA00C98")]
	[SerializeField]
	private WaypointCircuit m_CurrentCircuit;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00CE4", Offset = "0xA00CE4")]
	[SerializeField]
	private bool m_Clockwise;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00D30", Offset = "0xA00D30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00D30", Offset = "0xA00D30")]
	[SerializeField]
	private Waypoint m_CurrentWaypoint;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool m_IsWaiting;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_TimeRemaining;

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1CBB67C", Offset = "0x1CBB67C", VA = "0x1CBB67C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x1CBB710", Offset = "0x1CBB710", VA = "0x1CBB710")]
	private void Update()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x1CBB8A0", Offset = "0x1CBB8A0", VA = "0x1CBB8A0")]
	public CharacterNav_WaypointCircuit()
	{
	}
}
[Serializable]
[Token(Token = "0x200007D")]
public class CharacterNavigation_Behaviour : PlayableBehaviour
{
	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RTO_GameObject m_DestinationTarget;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Character_Navigation m_CharacterNav;

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x1CBB8B0", Offset = "0x1CBB8B0", VA = "0x1CBB8B0", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x1CBBA2C", Offset = "0x1CBBA2C", VA = "0x1CBBA2C", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x1CBBB20", Offset = "0x1CBBB20", VA = "0x1CBBB20")]
	public CharacterNavigation_Behaviour()
	{
	}
}
[Token(Token = "0x200007E")]
public class CharacterNavigation_Clip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CharacterNavigation_Behaviour template;

	[Token(Token = "0x1700002A")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1CBBB28", Offset = "0x1CBBB28", VA = "0x1CBBB28", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1CBBB30", Offset = "0x1CBBB30", VA = "0x1CBBB30", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x1CBBBE4", Offset = "0x1CBBBE4", VA = "0x1CBBBE4")]
	public CharacterNavigation_Clip()
	{
	}
}
[Token(Token = "0x200007F")]
public class Character_LookAtTarget : MonoBehaviour
{
	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float m_RotationValue;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject m_CurrentTarget;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Animator m_Animator;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string m_Vertical;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string m_Horizontal;

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x1CBBCB8", Offset = "0x1CBBCB8", VA = "0x1CBBCB8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x1CBBD14", Offset = "0x1CBBD14", VA = "0x1CBBD14")]
	private void Update()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x1CBBD1C", Offset = "0x1CBBD1C", VA = "0x1CBBD1C")]
	public void LooktAtGameobject(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x1CBBF50", Offset = "0x1CBBF50", VA = "0x1CBBF50")]
	public void LookTarget(GameObject target)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x1CBBF58", Offset = "0x1CBBF58", VA = "0x1CBBF58")]
	public void ResetTarget()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x1CBBF64", Offset = "0x1CBBF64", VA = "0x1CBBF64")]
	public Character_LookAtTarget()
	{
	}
}
[Token(Token = "0x2000080")]
public class Character_Navigation : MonoBehaviour
{
	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00DB0", Offset = "0xA00DB0")]
	private Animator anim;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private NavMeshAgent m_Agent;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00E0C", Offset = "0xA00E0C")]
	private GameObject m_CurrentTarget;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public bool m_ReachedDestination;

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x1CBBFEC", Offset = "0x1CBBFEC", VA = "0x1CBBFEC")]
	private void Update()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x1CBB7F8", Offset = "0x1CBB7F8", VA = "0x1CBB7F8")]
	public void GoToNavTarget(GameObject destinationTarget)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x1CBBB00", Offset = "0x1CBBB00", VA = "0x1CBBB00")]
	public void StopNavigation()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x1CBC13C", Offset = "0x1CBC13C", VA = "0x1CBC13C")]
	public Character_Navigation()
	{
	}
}
[Token(Token = "0x2000081")]
public class PigeonBehaviour : MonoBehaviour
{
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF30C", Offset = "0x9FF30C")]
	private sealed class <StartRandomIdle>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PigeonBehaviour <>4__this;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x14C3C04", Offset = "0x14C3C04", VA = "0x14C3C04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x14C3C4C", Offset = "0x14C3C4C", VA = "0x14C3C4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x14C3A88", Offset = "0x14C3A88", VA = "0x14C3A88")]
		[DebuggerHidden]
		public <StartRandomIdle>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x14C3AB4", Offset = "0x14C3AB4", VA = "0x14C3AB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x14C3AB8", Offset = "0x14C3AB8", VA = "0x14C3AB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x14C3C0C", Offset = "0x14C3C0C", VA = "0x14C3C0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string[] RandomAnimations;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animator anim;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool flying;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SplineFollower sf;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float maxspeed;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float acceleration;

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xFEFD24", Offset = "0xFEFD24", VA = "0xFEFD24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xFEFE60", Offset = "0xFEFE60", VA = "0xFEFE60")]
	private void Update()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xFEFED0", Offset = "0xFEFED0", VA = "0xFEFED0")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xFEFDE8", Offset = "0xFEFDE8", VA = "0xFEFDE8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05978", Offset = "0xA05978")]
	private IEnumerator StartRandomIdle()
	{
		return null;
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xFEFF94", Offset = "0xFEFF94", VA = "0xFEFF94")]
	public void DestroyThis()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xFF000C", Offset = "0xFF000C", VA = "0xFF000C")]
	public PigeonBehaviour()
	{
	}
}
[Token(Token = "0x2000083")]
public class RatSystem : MonoBehaviour
{
	[Token(Token = "0x2000084")]
	public enum DefaulltStand
	{
		[Token(Token = "0x40002D2")]
		Standing,
		[Token(Token = "0x40002D3")]
		Lying,
		[Token(Token = "0x40002D4")]
		Sit
	}

	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF31C", Offset = "0x9FF31C")]
	private sealed class <RandomIdle>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RatSystem <>4__this;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x14C3DEC", Offset = "0x14C3DEC", VA = "0x14C3DEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x14C3E34", Offset = "0x14C3E34", VA = "0x14C3E34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x14C3C54", Offset = "0x14C3C54", VA = "0x14C3C54")]
		[DebuggerHidden]
		public <RandomIdle>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x14C3C80", Offset = "0x14C3C80", VA = "0x14C3C80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x14C3C84", Offset = "0x14C3C84", VA = "0x14C3C84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x14C3DF4", Offset = "0x14C3DF4", VA = "0x14C3DF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public DefaulltStand Standing;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform TargetToReach;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Animator Anim;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float randIdleTarget;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool isRunning;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private bool isRandIdle;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private NavMeshAgent Agent;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector2 smoothDeltaPosition;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector2 velocity;

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xFF0E08", Offset = "0xFF0E08", VA = "0xFF0E08")]
	private void Start()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xFF0FB8", Offset = "0xFF0FB8", VA = "0xFF0FB8")]
	private void Update()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xFF1260", Offset = "0xFF1260", VA = "0xFF1260")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xFF0F40", Offset = "0xFF0F40", VA = "0xFF0F40")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05A28", Offset = "0xA05A28")]
	private IEnumerator RandomIdle()
	{
		return null;
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xFF13C4", Offset = "0xFF13C4", VA = "0xFF13C4")]
	public RatSystem()
	{
	}
}
[Token(Token = "0x2000086")]
public class CustomGizmo : MonoBehaviour
{
	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Mesh mesh;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color color;

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x1D17A64", Offset = "0x1D17A64", VA = "0x1D17A64")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x1D17B54", Offset = "0x1D17B54", VA = "0x1D17B54")]
	public CustomGizmo()
	{
	}
}
[Serializable]
[Token(Token = "0x2000087")]
public class GroupLookAtTarget_Behaviour : PlayableBehaviour
{
	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RTO_GameObject m_Target;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<RTO_GameObject> m_Characters_LookAt;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Character_LookAtTarget> m_Characters;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Group_LookAtTarget m_GroupLookAtTarget;

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x1D27A10", Offset = "0x1D27A10", VA = "0x1D27A10", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x1D27A64", Offset = "0x1D27A64", VA = "0x1D27A64", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x1D27D80", Offset = "0x1D27D80", VA = "0x1D27D80", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x1D28004", Offset = "0x1D28004", VA = "0x1D28004")]
	public GroupLookAtTarget_Behaviour()
	{
	}
}
[Token(Token = "0x2000088")]
public class GroupLookAtTarget_Clip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GroupLookAtTarget_Behaviour template;

	[Token(Token = "0x1700002F")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1D2808C", Offset = "0x1D2808C", VA = "0x1D2808C", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x1D28094", Offset = "0x1D28094", VA = "0x1D28094", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x1D28148", Offset = "0x1D28148", VA = "0x1D28148")]
	public GroupLookAtTarget_Clip()
	{
	}
}
[Token(Token = "0x2000089")]
public class GroupMoveToTarget : MonoBehaviour
{
	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MoveToTarget[] m_MoveToTarget;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform[] m_Targets;

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x1D28218", Offset = "0x1D28218", VA = "0x1D28218")]
	public void SetAll(MoveToTarget[] moveToTargets)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x1D28220", Offset = "0x1D28220", VA = "0x1D28220")]
	public void GoToDestinationTargets(Transform[] targets, bool isTeleporting = true)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x1D282C8", Offset = "0x1D282C8", VA = "0x1D282C8")]
	public GroupMoveToTarget()
	{
	}
}
[Serializable]
[Token(Token = "0x200008A")]
public class GroupMoveToTarget_Behaviour : PlayableBehaviour
{
	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00EA8", Offset = "0xA00EA8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA00EA8", Offset = "0xA00EA8")]
	public bool m_IsTeleporting;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA00F08", Offset = "0xA00F08")]
	public float m_SpeedTranslation;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA00F40", Offset = "0xA00F40")]
	public List<RTO_GameObject> m_MoveToTargets;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<RTO_GameObject> m_DestinationTargets;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<MoveToTarget> m_MoveToTargetsTrue;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Transform> m_DestinationTargetsTrue;

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x1D282D0", Offset = "0x1D282D0", VA = "0x1D282D0", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x1D28324", Offset = "0x1D28324", VA = "0x1D28324", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x1D28628", Offset = "0x1D28628", VA = "0x1D28628")]
	public GroupMoveToTarget_Behaviour()
	{
	}
}
[Token(Token = "0x200008B")]
public class GroupMoveToTarget_Clip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GroupMoveToTarget_Behaviour template;

	[Token(Token = "0x17000030")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1D28710", Offset = "0x1D28710", VA = "0x1D28710", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x1D28718", Offset = "0x1D28718", VA = "0x1D28718", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x1D287CC", Offset = "0x1D287CC", VA = "0x1D287CC")]
	public GroupMoveToTarget_Clip()
	{
	}
}
[Token(Token = "0x200008C")]
public class GroupNavigation : MonoBehaviour
{
	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Character_Navigation[] m_CharactersNavigation;

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x1D2889C", Offset = "0x1D2889C", VA = "0x1D2889C")]
	public void SetAllCharactersFollowing(Character_Navigation[] characters)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x1D288A4", Offset = "0x1D288A4", VA = "0x1D288A4")]
	public void GoToDestinationTarget(GameObject destinationTarget)
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x1D28920", Offset = "0x1D28920", VA = "0x1D28920")]
	public void StopAllNavigation()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x1D2898C", Offset = "0x1D2898C", VA = "0x1D2898C")]
	public GroupNavigation()
	{
	}
}
[Serializable]
[Token(Token = "0x200008D")]
public class GroupNavigation_Behaviour : PlayableBehaviour
{
	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<RTO_GameObject> m_CharactersNavigation;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RTO_GameObject m_DestinationTarget;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Character_Navigation> m_CharactersNav;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GroupNavigation m_GroupNav;

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x1D28994", Offset = "0x1D28994", VA = "0x1D28994", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x1D289E8", Offset = "0x1D289E8", VA = "0x1D289E8", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x1D28D28", Offset = "0x1D28D28", VA = "0x1D28D28", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x1D28FCC", Offset = "0x1D28FCC", VA = "0x1D28FCC")]
	public GroupNavigation_Behaviour()
	{
	}
}
[Token(Token = "0x200008E")]
public class GroupNavigation_Clip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GroupNavigation_Behaviour template;

	[Token(Token = "0x17000031")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1D29054", Offset = "0x1D29054", VA = "0x1D29054", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x1D2905C", Offset = "0x1D2905C", VA = "0x1D2905C", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x1D29110", Offset = "0x1D29110", VA = "0x1D29110")]
	public GroupNavigation_Clip()
	{
	}
}
[Token(Token = "0x200008F")]
public class GroupParenting : MonoBehaviour
{
	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject m_Parent;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> m_Children;

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x1D291E0", Offset = "0x1D291E0", VA = "0x1D291E0")]
	public void SetChildrenParent(GameObject parent, List<GameObject> children, bool activeNavMesh = false)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x1D2942C", Offset = "0x1D2942C", VA = "0x1D2942C")]
	public GroupParenting()
	{
	}
}
[Serializable]
[Token(Token = "0x2000090")]
public class GroupParenting_Behaviour : PlayableBehaviour
{
	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<RTO_GameObject> m_ChildrenToParent;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RTO_GameObject m_Parent;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<GameObject> m_ChildrenParentGO;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Transform> m_OriginParents;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GroupParenting m_GroupParenting;

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x1E5D740", Offset = "0x1E5D740", VA = "0x1E5D740", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x1E5D868", Offset = "0x1E5D868", VA = "0x1E5D868", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x1E5DC00", Offset = "0x1E5DC00", VA = "0x1E5DC00", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x1E5DEA8", Offset = "0x1E5DEA8", VA = "0x1E5DEA8")]
	public GroupParenting_Behaviour()
	{
	}
}
[Token(Token = "0x2000091")]
public class GroupParenting_Clip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GroupParenting_Behaviour template;

	[Token(Token = "0x17000032")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1E5DF78", Offset = "0x1E5DF78", VA = "0x1E5DF78", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x1E5DF80", Offset = "0x1E5DF80", VA = "0x1E5DF80", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x1E5E034", Offset = "0x1E5E034", VA = "0x1E5E034")]
	public GroupParenting_Clip()
	{
	}
}
[Token(Token = "0x2000092")]
public class Group_LookAtTarget : MonoBehaviour
{
	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Character_LookAtTarget> m_Characters;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject m_CurrentTarget;

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x1E5E104", Offset = "0x1E5E104", VA = "0x1E5E104")]
	public void SetCharacters(List<Character_LookAtTarget> characters)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x1E5E10C", Offset = "0x1E5E10C", VA = "0x1E5E10C")]
	public void ResetAllTarget()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x1E5E224", Offset = "0x1E5E224", VA = "0x1E5E224")]
	public void LookThisTarget(List<Character_LookAtTarget> perso_LookAtTimelines, GameObject target)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x1E5E34C", Offset = "0x1E5E34C", VA = "0x1E5E34C")]
	public void AllLookThisTarget(GameObject target)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x1E5E484", Offset = "0x1E5E484", VA = "0x1E5E484")]
	public Group_LookAtTarget()
	{
	}
}
[Token(Token = "0x2000093")]
public class StartLookAt : MonoBehaviour
{
	[Token(Token = "0x6000262")]
	[Address(RVA = "0xE38D7C", Offset = "0xE38D7C", VA = "0xE38D7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xE38DD8", Offset = "0xE38DD8", VA = "0xE38DD8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xE38DDC", Offset = "0xE38DDC", VA = "0xE38DDC")]
	public StartLookAt()
	{
	}
}
[Serializable]
[Token(Token = "0x2000094")]
public class LookAtTarget_Behaviour : PlayableBehaviour
{
	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RTO_GameObject m_Target;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Character_LookAtTarget m_Character;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x1E6EE5C", Offset = "0x1E6EE5C", VA = "0x1E6EE5C", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x1E6EFF4", Offset = "0x1E6EFF4", VA = "0x1E6EFF4", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x1E6F0D0", Offset = "0x1E6F0D0", VA = "0x1E6F0D0")]
	public LookAtTarget_Behaviour()
	{
	}
}
[Token(Token = "0x2000095")]
public class LookAtTarget_Clip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LookAtTarget_Behaviour template;

	[Token(Token = "0x17000033")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1E6F0D8", Offset = "0x1E6F0D8", VA = "0x1E6F0D8", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1E6F0E0", Offset = "0x1E6F0E0", VA = "0x1E6F0E0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x1E6F194", Offset = "0x1E6F194", VA = "0x1E6F194")]
	public LookAtTarget_Clip()
	{
	}
}
[Token(Token = "0x2000096")]
public class MoveToTarget : MonoBehaviour
{
	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA00FC4", Offset = "0xA00FC4")]
	private Transform m_Target;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool m_IsTeleporting;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float m_TimeToTarget;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01030", Offset = "0xA01030")]
	[SerializeField]
	private float m_CurrentTime;

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x123D054", Offset = "0x123D054", VA = "0x123D054")]
	public void SetTarget(Transform target, bool isTeleporting = false)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x123D088", Offset = "0x123D088", VA = "0x123D088")]
	public void SetTimeToGoTarget(float time)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x123D090", Offset = "0x123D090", VA = "0x123D090")]
	private void Update()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x123D094", Offset = "0x123D094", VA = "0x123D094")]
	public void MoveOnTarget()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x123D2C0", Offset = "0x123D2C0", VA = "0x123D2C0")]
	public MoveToTarget()
	{
	}
}
[Serializable]
[Token(Token = "0x2000097")]
public class MoveToTarget_Behaviour : PlayableBehaviour
{
	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RTO_GameObject m_DestinationTarget;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_IsTeleporting;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0107C", Offset = "0xA0107C")]
	public float m_TimeToGoTarget;

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x123D2D8", Offset = "0x123D2D8", VA = "0x123D2D8", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x123D440", Offset = "0x123D440", VA = "0x123D440")]
	public MoveToTarget_Behaviour()
	{
	}
}
[Token(Token = "0x2000098")]
public class MoveToTarget_Clip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MoveToTarget_Behaviour template;

	[Token(Token = "0x17000034")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x123D450", Offset = "0x123D450", VA = "0x123D450", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x123D458", Offset = "0x123D458", VA = "0x123D458", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x123D50C", Offset = "0x123D50C", VA = "0x123D50C")]
	public MoveToTarget_Clip()
	{
	}
}
[Token(Token = "0x2000099")]
public class ChanoineStateBase : StateMachineBehaviour
{
	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ChanoineController agentController;

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x1CB8E28", Offset = "0x1CB8E28", VA = "0x1CB8E28")]
	public ChanoineController GetAgentController(Animator animator)
	{
		return null;
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x1CB8EEC", Offset = "0x1CB8EEC", VA = "0x1CB8EEC")]
	public ChanoineStateBase()
	{
	}
}
[Token(Token = "0x200009A")]
public class ChanoineSitDownState : ChanoineStateBase
{
	[Token(Token = "0x6000277")]
	[Address(RVA = "0x1CB8C94", Offset = "0x1CB8C94", VA = "0x1CB8C94", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x1CB8D08", Offset = "0x1CB8D08", VA = "0x1CB8D08", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x1CB8EE4", Offset = "0x1CB8EE4", VA = "0x1CB8EE4")]
	public ChanoineSitDownState()
	{
	}
}
[Token(Token = "0x200009B")]
public class ChanoineWaitState : ChanoineStateBase
{
	[Token(Token = "0x600027A")]
	[Address(RVA = "0x1CB8EF4", Offset = "0x1CB8EF4", VA = "0x1CB8EF4", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x1CB9018", Offset = "0x1CB9018", VA = "0x1CB9018")]
	public ChanoineWaitState()
	{
	}
}
[Token(Token = "0x200009C")]
public class ChanoineWalkStairState : ChanoineStateBase
{
	[Token(Token = "0x600027C")]
	[Address(RVA = "0x1CB9020", Offset = "0x1CB9020", VA = "0x1CB9020", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x1CB9024", Offset = "0x1CB9024", VA = "0x1CB9024", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x1CB915C", Offset = "0x1CB915C", VA = "0x1CB915C")]
	public ChanoineWalkStairState()
	{
	}
}
[Token(Token = "0x200009D")]
public class ChanoineWalkState : ChanoineStateBase
{
	[Token(Token = "0x600027F")]
	[Address(RVA = "0x1CB9164", Offset = "0x1CB9164", VA = "0x1CB9164", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x1CB91D8", Offset = "0x1CB91D8", VA = "0x1CB91D8", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x1CB9424", Offset = "0x1CB9424", VA = "0x1CB9424", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x1CB9498", Offset = "0x1CB9498", VA = "0x1CB9498")]
	public ChanoineWalkState()
	{
	}
}
[Token(Token = "0x200009E")]
public class ChanoineController : MonoBehaviour
{
	[Token(Token = "0x200009F")]
	public enum TransitionParameter
	{
		[Token(Token = "0x4000310")]
		StartSequence,
		[Token(Token = "0x4000311")]
		Walk,
		[Token(Token = "0x4000312")]
		SitDown,
		[Token(Token = "0x4000313")]
		WalkStair
	}

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string entryState;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA010C4", Offset = "0xA010C4")]
	public float offset;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public float Speed;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Animator animator;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public NavMeshAgent agent;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public bool beenWalkStair;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Transform> destinationList;

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x1CB88CC", Offset = "0x1CB88CC", VA = "0x1CB88CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x1CB8A08", Offset = "0x1CB8A08", VA = "0x1CB8A08")]
	private void Update()
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x1CB8A44", Offset = "0x1CB8A44", VA = "0x1CB8A44")]
	public void StartChanoineSequence()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x1CB8A48", Offset = "0x1CB8A48", VA = "0x1CB8A48")]
	public void SetNextNavMeshDestination()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x1CB8B14", Offset = "0x1CB8B14", VA = "0x1CB8B14")]
	public void StopNavigation()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x1CB8B34", Offset = "0x1CB8B34", VA = "0x1CB8B34")]
	public void SnapParentTransformToChild()
	{
	}

	[Token(Token = "0x6000289")]
	public Transform RemoveAndReturnFirst<Transform>(List<Transform> list)
	{
		return (Transform)null;
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x1CB8C8C", Offset = "0x1CB8C8C", VA = "0x1CB8C8C")]
	public ChanoineController()
	{
	}
}
[Token(Token = "0x20000A0")]
public class AgentAnimatorController : MonoBehaviour
{
	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public NavMeshAgent agent;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string TriggerParam;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string LoopParam;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int MinTimeTrigger;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int MaxTimeTrigger;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int MinTimeStartLoop;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int MaxTimeStartLoop;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int MinTimeStopLoop;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int MaxTimeStopLoop;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float _timerWait;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float _timerLoop;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int triggerTimer;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int loopTimer;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int loopEndTimer;

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x1CA43BC", Offset = "0x1CA43BC", VA = "0x1CA43BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x1CA43E8", Offset = "0x1CA43E8", VA = "0x1CA43E8")]
	private void CheckMoveState()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x1CA4554", Offset = "0x1CA4554", VA = "0x1CA4554")]
	private void CheckWaitState()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x1CA46F4", Offset = "0x1CA46F4", VA = "0x1CA46F4")]
	private void CheckLoopState()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x1CA47E4", Offset = "0x1CA47E4", VA = "0x1CA47E4")]
	private void GenerateWaitingStateTimer()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x1CA48E8", Offset = "0x1CA48E8", VA = "0x1CA48E8")]
	public AgentAnimatorController()
	{
	}
}
[Token(Token = "0x20000A1")]
public class NavigationMesh_Agent_Controller : MonoBehaviour
{
	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private NavMeshAgent agent;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform destination;

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x1241120", Offset = "0x1241120", VA = "0x1241120")]
	private void Start()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x124117C", Offset = "0x124117C", VA = "0x124117C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x1241230", Offset = "0x1241230", VA = "0x1241230")]
	public NavigationMesh_Agent_Controller()
	{
	}
}
[Token(Token = "0x20000A2")]
public class NPC_Beffroi : MonoBehaviour
{
	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] Destinations;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 currentDestination;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int i;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private NavMeshAgent Agent;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float Distance;

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x1240498", Offset = "0x1240498", VA = "0x1240498")]
	private void Start()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x12404FC", Offset = "0x12404FC", VA = "0x12404FC")]
	public void GoToNextDestination()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x1240588", Offset = "0x1240588", VA = "0x1240588")]
	private void Update()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x12405EC", Offset = "0x12405EC", VA = "0x12405EC")]
	public NPC_Beffroi()
	{
	}
}
[Token(Token = "0x20000A3")]
public class OnScenarioStartEvent : MonoBehaviour
{
	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent actions;

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x12462C4", Offset = "0x12462C4", VA = "0x12462C4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x1246374", Offset = "0x1246374", VA = "0x1246374")]
	private void OnScenarioStart(bool iBeginning)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x1246390", Offset = "0x1246390", VA = "0x1246390")]
	public OnScenarioStartEvent()
	{
	}
}
[Token(Token = "0x20000A4")]
public class PointInTime
{
	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public double timeRef;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 position;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Quaternion rotation;

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xFF09C0", Offset = "0xFF09C0", VA = "0xFF09C0")]
	public PointInTime(Vector3 _position, Quaternion _rotation, double _timeRef = 0.0)
	{
	}
}
[Token(Token = "0x20000A5")]
public class SetClippingPlanes : MonoBehaviour
{
	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0xA0111C", Offset = "0xA0111C")]
	[SerializeField]
	private float nearClip;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0xA0115C", Offset = "0xA0115C")]
	[SerializeField]
	private float farClip;

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xE2E214", Offset = "0xE2E214", VA = "0xE2E214")]
	private void Start()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xE2E2B0", Offset = "0xE2E2B0", VA = "0xE2E2B0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xE2E2D0", Offset = "0xE2E2D0", VA = "0xE2E2D0")]
	public SetClippingPlanes()
	{
	}
}
[Token(Token = "0x20000A6")]
public class StartXP : MonoBehaviour
{
	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "DropdownAttribute", RVA = "0xA0119C", Offset = "0xA0119C")]
	public string ScenarioAsset;

	[Token(Token = "0x17000035")]
	private List<string> GetScenarios
	{
		[Token(Token = "0x600029F")]
		[Address(RVA = "0xE39118", Offset = "0xE39118", VA = "0xE39118")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xE39184", Offset = "0xE39184", VA = "0xE39184")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xE391C0", Offset = "0xE391C0", VA = "0xE391C0")]
	public void LaunchScenario()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xE392B4", Offset = "0xE392B4", VA = "0xE392B4")]
	public StartXP()
	{
	}
}
[Serializable]
[Token(Token = "0x20000A7")]
public class AudioLoading
{
	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int m_StepToLoad;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool m_IsActive;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA011D4", Offset = "0xA011D4")]
	public float m_Volume;

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x1CAACD8", Offset = "0x1CAACD8", VA = "0x1CAACD8")]
	public AudioLoading()
	{
	}
}
[Serializable]
[Token(Token = "0x20000A8")]
public class StepArray : ReorderableArray<Step>
{
	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xE39618", Offset = "0xE39618", VA = "0xE39618")]
	public StepArray()
	{
	}
}
[Serializable]
[Token(Token = "0x20000A9")]
public class Step
{
	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA011EC", Offset = "0xA011EC")]
	[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA011EC", Offset = "0xA011EC")]
	public SceneListObj sceneToLoads;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA01248", Offset = "0xA01248")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA01248", Offset = "0xA01248")]
	public SceneListObj sceneToUnloads;

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xE39610", Offset = "0xE39610", VA = "0xE39610")]
	public Step()
	{
	}
}
[Serializable]
[Token(Token = "0x20000AA")]
public class SceneListObj : ReorderableArray<UnityEngine.Object>
{
	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xE2C6B0", Offset = "0xE2C6B0", VA = "0xE2C6B0")]
	public SceneListObj()
	{
	}
}
[Token(Token = "0x20000AB")]
public class StepSceneLoader : MonoBehaviour
{
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF32C", Offset = "0x9FF32C")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StepSceneLoader <>4__this;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AsyncOperation async;

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x14C4EA0", Offset = "0x14C4EA0", VA = "0x14C4EA0")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x14C4EA8", Offset = "0x14C4EA8", VA = "0x14C4EA8")]
		internal bool <LoadLevelAsyncCoroutine>b__0()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x14C4EF0", Offset = "0x14C4EF0", VA = "0x14C4EF0")]
		internal bool <LoadLevelAsyncCoroutine>b__1()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF33C", Offset = "0x9FF33C")]
	private sealed class <LoadLevelAsyncCoroutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StepSceneLoader <>4__this;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int index;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass27_0 <>8__1;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Scene <sceneSelected>5__2;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x14C58E0", Offset = "0x14C58E0", VA = "0x14C58E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x14C5928", Offset = "0x14C5928", VA = "0x14C5928", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x14C5024", Offset = "0x14C5024", VA = "0x14C5024")]
		[DebuggerHidden]
		public <LoadLevelAsyncCoroutine>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x14C5050", Offset = "0x14C5050", VA = "0x14C5050", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x14C5054", Offset = "0x14C5054", VA = "0x14C5054", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x14C58E8", Offset = "0x14C58E8", VA = "0x14C58E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF34C", Offset = "0x9FF34C")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StepSceneLoader <>4__this;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int totalScenesLoaded;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<Scene, string> onSceneLoaded;

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x14C4F0C", Offset = "0x14C4F0C", VA = "0x14C4F0C")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x14C4F14", Offset = "0x14C4F14", VA = "0x14C4F14")]
		internal bool <LoadStepScenesAsyncCoroutine>b__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF35C", Offset = "0x9FF35C")]
	private sealed class <>c__DisplayClass28_1
	{
		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int sceneLoadIndex;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string sceneLoadName;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public <>c__DisplayClass28_0 CS$<>8__locals1;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x14C4F5C", Offset = "0x14C4F5C", VA = "0x14C4F5C")]
		public <>c__DisplayClass28_1()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x14C4F64", Offset = "0x14C4F64", VA = "0x14C4F64")]
		internal void <LoadStepScenesAsyncCoroutine>b__1(AsyncOperation s)
		{
		}
	}

	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF36C", Offset = "0x9FF36C")]
	private sealed class <LoadStepScenesAsyncCoroutine>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StepSceneLoader <>4__this;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<Scene, string> onSceneLoaded;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int stepIndex;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private <>c__DisplayClass28_0 <>8__1;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool activateDirectly;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action<float> progress;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int <totalScenes>5__2;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AsyncOperation[] <sceneLoadOperations>5__3;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float <activeProgress>5__4;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float <targetProgress>5__5;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private WaitForSeconds <waitForSeconds>5__6;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x14C6534", Offset = "0x14C6534", VA = "0x14C6534", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x14C657C", Offset = "0x14C657C", VA = "0x14C657C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x14C5930", Offset = "0x14C5930", VA = "0x14C5930")]
		[DebuggerHidden]
		public <LoadStepScenesAsyncCoroutine>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x14C595C", Offset = "0x14C595C", VA = "0x14C595C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x14C5960", Offset = "0x14C5960", VA = "0x14C5960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x14C653C", Offset = "0x14C653C", VA = "0x14C653C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF37C", Offset = "0x9FF37C")]
	private sealed class <OnAllScenesLoaded>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StepSceneLoader <>4__this;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x14C698C", Offset = "0x14C698C", VA = "0x14C698C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x14C69D4", Offset = "0x14C69D4", VA = "0x14C69D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x14C6584", Offset = "0x14C6584", VA = "0x14C6584")]
		[DebuggerHidden]
		public <OnAllScenesLoaded>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x14C65B0", Offset = "0x14C65B0", VA = "0x14C65B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x14C65B4", Offset = "0x14C65B4", VA = "0x14C65B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x14C6994", Offset = "0x14C6994", VA = "0x14C6994", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static StepSceneLoader instance;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string BASE_SCENE_NAME;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA012A0", Offset = "0xA012A0")]
	private List<StepArray> m_Scenarios;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Dictionary<int, List<int>> m_StepPlayed;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA01304", Offset = "0xA01304")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01304", Offset = "0xA01304")]
	public Camera m_MainCamera;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public BlackScreenFade m_Fade;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01384", Offset = "0xA01384")]
	private float m_AudioFadeSpeed;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private string m_AudioMixerNameToFadeOutInTransition;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string m_AudioMixerNameToFadeInTransition;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AudioClip m_AudioToPlayInTransition;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<AudioLoading> m_AudioLoadings;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01410", Offset = "0xA01410")]
	private int m_ScenarioIndex;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private int m_CurrentStepIndex;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private int m_LastStepIndex;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private int m_LastScenarioIndex;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int m_SceneLoadedCount;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private PlayableDirector m_CurrentStepPlayableDirector;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Coroutine m_Corout_LoadLevel;

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xE3966C", Offset = "0xE3966C", VA = "0xE3966C")]
	public void InitPlayableDirector(PlayableDirector playableDirector)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xE396A4", Offset = "0xE396A4", VA = "0xE396A4")]
	public void SetScenarioIndex(int index)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xE396B4", Offset = "0xE396B4", VA = "0xE396B4")]
	public int GetScenarioIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xE396BC", Offset = "0xE396BC", VA = "0xE396BC")]
	public int GetCurrentStepIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xE396C4", Offset = "0xE396C4", VA = "0xE396C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xE3978C", Offset = "0xE3978C", VA = "0xE3978C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xE397EC", Offset = "0xE397EC", VA = "0xE397EC")]
	public void UnloadAllSceneExceptMain()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xE397DC", Offset = "0xE397DC", VA = "0xE397DC")]
	public void LaunchNextStep()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xE39978", Offset = "0xE39978", VA = "0xE39978")]
	public void LaunchStep(int stepIndex, int scenarioIndex = -1)
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xE39B64", Offset = "0xE39B64", VA = "0xE39B64")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05AD8", Offset = "0xA05AD8")]
	private IEnumerator LoadLevelAsyncCoroutine(int index)
	{
		return null;
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xE39AA0", Offset = "0xE39AA0", VA = "0xE39AA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05B38", Offset = "0xA05B38")]
	private IEnumerator LoadStepScenesAsyncCoroutine(int stepIndex, Action<float> progress, Action<Scene, string> onSceneLoaded, bool activateDirectly = false)
	{
		return null;
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xE39BEC", Offset = "0xE39BEC", VA = "0xE39BEC")]
	private void OnSceneLoaded(Scene scene, string sceneName)
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xE39CE4", Offset = "0xE39CE4", VA = "0xE39CE4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05B98", Offset = "0xA05B98")]
	private IEnumerator OnAllScenesLoaded()
	{
		return null;
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xE39D5C", Offset = "0xE39D5C", VA = "0xE39D5C")]
	private void SetStepPlayed(int scenarioID, int stepID)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xE39F50", Offset = "0xE39F50", VA = "0xE39F50")]
	public bool CheckIfFinishedScenario(int scenarioIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xE39FB4", Offset = "0xE39FB4", VA = "0xE39FB4")]
	public void DesactiveAllCameraExceptPlayer()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xE39FB8", Offset = "0xE39FB8", VA = "0xE39FB8")]
	public void ExecuteCustomAppCode(bool active)
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xE39FBC", Offset = "0xE39FBC", VA = "0xE39FBC")]
	public void PlayAudioTransition(int stepIndex)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xE3A168", Offset = "0xE3A168", VA = "0xE3A168")]
	public StepSceneLoader()
	{
	}
}
[Token(Token = "0x20000B2")]
public class TimeBody : MonoBehaviour
{
	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA014AC", Offset = "0xA014AC")]
	[SerializeField]
	private PlayableDirector m_PlayableDirector;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA014F8", Offset = "0xA014F8")]
	public float recordTime;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool isRewinding;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private double lastDirectorTime;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<PointInTime> pointsInTime;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private double timespaceBetweenSave;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private double timeLoop;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float factorTimeRewind;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float timeRewindCurrent;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Rigidbody rb;

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xE3F5C0", Offset = "0xE3F5C0", VA = "0xE3F5C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xE3F644", Offset = "0xE3F644", VA = "0xE3F644")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xE3F6EC", Offset = "0xE3F6EC", VA = "0xE3F6EC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xE3FCD4", Offset = "0xE3FCD4", VA = "0xE3FCD4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xE3FCD8", Offset = "0xE3FCD8", VA = "0xE3FCD8")]
	private PointInTime PickNearestPointInTime(float timeRef)
	{
		return null;
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xE3F974", Offset = "0xE3F974", VA = "0xE3F974")]
	private void Rewind()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xE3FDF0", Offset = "0xE3FDF0", VA = "0xE3FDF0")]
	private void RewindTo(PointInTime pointInTime)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xE3FAD0", Offset = "0xE3FAD0", VA = "0xE3FAD0")]
	private void Record()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xE3F7A8", Offset = "0xE3F7A8", VA = "0xE3F7A8")]
	public void StartRewind()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xE3F890", Offset = "0xE3F890", VA = "0xE3F890")]
	public void StopRewind()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xE3FE50", Offset = "0xE3FE50", VA = "0xE3FE50")]
	public TimeBody()
	{
	}
}
[Token(Token = "0x20000B3")]
[ExecuteInEditMode]
public class TransformDifferenceDetector : MonoBehaviour
{
	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string TRANSFORM_DIFFERENCE;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01540", Offset = "0xA01540")]
	private bool m_IsEnable;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0158C", Offset = "0xA0158C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA0158C", Offset = "0xA0158C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA0158C", Offset = "0xA0158C")]
	public Vector3 m_LastPlayedPosition;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Vector3 m_LastPlayedRotation;

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x1DAD3F8", Offset = "0x1DAD3F8", VA = "0x1DAD3F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x1DAD7D0", Offset = "0x1DAD7D0", VA = "0x1DAD7D0")]
	private void Reset()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x1DAD49C", Offset = "0x1DAD49C", VA = "0x1DAD49C")]
	public void SnapshotTransform(bool saveInPref = false)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x1DAD7FC", Offset = "0x1DAD7FC", VA = "0x1DAD7FC")]
	public void SetTransformToLast(bool loadFromPref = false)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x1DADAD4", Offset = "0x1DADAD4", VA = "0x1DADAD4")]
	public bool CheckTransformDifference()
	{
		return default(bool);
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x1DADDC8", Offset = "0x1DADDC8", VA = "0x1DADDC8")]
	public TransformDifferenceDetector()
	{
	}
}
[Token(Token = "0x20000B4")]
public class TransformDifferenceDetectorManager : MonoBehaviour
{
	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<TransformDifferenceDetector> m_TransformList;

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x1DADE24", Offset = "0x1DADE24", VA = "0x1DADE24")]
	public void SetTransformsToTheirOrigins()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x1DADFE4", Offset = "0x1DADFE4", VA = "0x1DADFE4")]
	public TransformDifferenceDetectorManager()
	{
	}
}
[Token(Token = "0x20000B5")]
public class TransformRepoManager : MonoBehaviour
{
	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<TransformReposition> m_TransformList;

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x1DADFEC", Offset = "0x1DADFEC", VA = "0x1DADFEC")]
	public void SetTransformsToTheirOrigins()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x1DAE534", Offset = "0x1DAE534", VA = "0x1DAE534")]
	public TransformRepoManager()
	{
	}
}
[Serializable]
[Token(Token = "0x20000B6")]
public class TransformData
{
	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string ID;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 position;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 rotation;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 scale;

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x1DAD39C", Offset = "0x1DAD39C", VA = "0x1DAD39C")]
	public TransformData()
	{
	}
}
[Token(Token = "0x20000B7")]
[ExecuteInEditMode]
public class TransformReposition : MonoBehaviour
{
	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string TRANSFORM_REPOSITION;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01610", Offset = "0xA01610")]
	private bool m_IsEnable;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA01648", Offset = "0xA01648")]
	private bool m_IsErasingOrigin;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0165C", Offset = "0xA0165C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA0165C", Offset = "0xA0165C")]
	public Vector3 m_OriginPosition;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Vector3 m_OriginRotation;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool m_IsFirstInitFrame;

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x1DAE53C", Offset = "0x1DAE53C", VA = "0x1DAE53C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x1DAE574", Offset = "0x1DAE574", VA = "0x1DAE574")]
	private void Update()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x1DAE9C8", Offset = "0x1DAE9C8", VA = "0x1DAE9C8")]
	private void Reset()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x1DAE694", Offset = "0x1DAE694", VA = "0x1DAE694")]
	public void SnapshotOrigin(bool saveInPref = false)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x1DAE1AC", Offset = "0x1DAE1AC", VA = "0x1DAE1AC")]
	public void SetTransformToOrigin(bool loadFromPref = false)
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x1DAE9F8", Offset = "0x1DAE9F8", VA = "0x1DAE9F8")]
	public bool CheckTransformDifference()
	{
		return default(bool);
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x1DAEA90", Offset = "0x1DAEA90", VA = "0x1DAEA90")]
	public TransformReposition()
	{
	}
}
[Token(Token = "0x20000B8")]
public class ActivateOnPanel : MonoBehaviour
{
	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AndroidMenu.Panel panelToShow;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject objToShow;

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x1CA42B8", Offset = "0x1CA42B8", VA = "0x1CA42B8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x1CA43B4", Offset = "0x1CA43B4", VA = "0x1CA43B4")]
	public ActivateOnPanel()
	{
	}
}
[Token(Token = "0x20000B9")]
public class ChangeTextureOnMat : MonoBehaviour
{
	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject frenchText;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject englishText;

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x1CB8810", Offset = "0x1CB8810", VA = "0x1CB8810")]
	public void Update()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x1CB88C4", Offset = "0x1CB88C4", VA = "0x1CB88C4")]
	public ChangeTextureOnMat()
	{
	}
}
[Token(Token = "0x20000BA")]
public class HorizontalScrollView : MonoBehaviour
{
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF3AC", Offset = "0x9FF3AC")]
	private sealed class <Lerp>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HorizontalScrollView <>4__this;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <ellapsedTime>5__2;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector2 <previousPos>5__3;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector2 <scrollPos>5__4;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x1DBC780", Offset = "0x1DBC780", VA = "0x1DBC780", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x1DBC7C8", Offset = "0x1DBC7C8", VA = "0x1DBC7C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1DBC604", Offset = "0x1DBC604", VA = "0x1DBC604")]
		[DebuggerHidden]
		public <Lerp>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1DBC630", Offset = "0x1DBC630", VA = "0x1DBC630", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1DBC634", Offset = "0x1DBC634", VA = "0x1DBC634", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1DBC788", Offset = "0x1DBC788", VA = "0x1DBC788", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform chaptersHolder;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float scrollViewSize;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int nbItemDisplay;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Selectable[] chapters;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Selectable nextBtn;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Selectable prevBtn;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int currentScrollIndex;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int maxScrollIndex;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Coroutine lerpCoroutine;

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x1E65794", Offset = "0x1E65794", VA = "0x1E65794")]
	public void Start()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x1E659B8", Offset = "0x1E659B8", VA = "0x1E659B8")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x1E65A14", Offset = "0x1E65A14", VA = "0x1E65A14")]
	public void Next()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x1E65B40", Offset = "0x1E65B40", VA = "0x1E65B40")]
	public void Previous()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x1E6583C", Offset = "0x1E6583C", VA = "0x1E6583C")]
	private void DeactivateCollider(bool iAll = false)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x1E65AC8", Offset = "0x1E65AC8", VA = "0x1E65AC8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05CE8", Offset = "0xA05CE8")]
	private IEnumerator Lerp()
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x1E659BC", Offset = "0x1E659BC", VA = "0x1E659BC")]
	private void SetAtPosition()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x1E65BF4", Offset = "0x1E65BF4", VA = "0x1E65BF4")]
	public HorizontalScrollView()
	{
	}
}
[Token(Token = "0x20000BC")]
public class TextPrettier : MonoBehaviour
{
	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI text;

	[Token(Token = "0x6000303")]
	[Address(RVA = "0xE3F46C", Offset = "0xE3F46C", VA = "0xE3F46C")]
	public void SetText(string iText)
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xE3F5B8", Offset = "0xE3F5B8", VA = "0xE3F5B8")]
	public TextPrettier()
	{
	}
}
[Token(Token = "0x20000BD")]
public class DeactivateLoadingAnim : MonoBehaviour
{
	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer parent;

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x1D17BC0", Offset = "0x1D17BC0", VA = "0x1D17BC0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x1D17C2C", Offset = "0x1D17C2C", VA = "0x1D17C2C")]
	public DeactivateLoadingAnim()
	{
	}
}
[Token(Token = "0x20000BE")]
public class DeleteAtStart : MonoBehaviour
{
	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool keepInEditor;

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x1D1ACA4", Offset = "0x1D1ACA4", VA = "0x1D1ACA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x1D1AD20", Offset = "0x1D1AD20", VA = "0x1D1AD20")]
	public DeleteAtStart()
	{
	}
}
[Token(Token = "0x20000BF")]
[ExecuteInEditMode]
public class EditorAudioListener : MonoBehaviour
{
	[Token(Token = "0x6000309")]
	[Address(RVA = "0x1D1D5A0", Offset = "0x1D1D5A0", VA = "0x1D1D5A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x1D1D720", Offset = "0x1D1D720", VA = "0x1D1D720")]
	public void MimicCamera()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x1D1D8E0", Offset = "0x1D1D8E0", VA = "0x1D1D8E0")]
	public EditorAudioListener()
	{
	}
}
[Serializable]
[Token(Token = "0x20000C0")]
public class StepRef
{
	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int m_ScenarioToActivate;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int m_StepToActivate;

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xE39664", Offset = "0xE39664", VA = "0xE39664")]
	public StepRef()
	{
	}
}
[Serializable]
[Token(Token = "0x20000C1")]
public class EquipableItem
{
	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject m_ItemToActivate;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<StepRef> m_Steps;

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x1D1F350", Offset = "0x1D1F350", VA = "0x1D1F350")]
	public EquipableItem()
	{
	}
}
[Token(Token = "0x20000C2")]
public class EquipItem : MonoBehaviour
{
	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private EquipableItem m_Default;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<EquipableItem> m_EquipableItems;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA016EC", Offset = "0xA016EC")]
	[SerializeField]
	public bool m_IsStick;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private PositionConstraint m_PositionConstraint;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RotationConstraint m_RotationConstraint;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Rigidbody m_Rigidbody;

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x1D1ECB8", Offset = "0x1D1ECB8", VA = "0x1D1ECB8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x1D1ED74", Offset = "0x1D1ED74", VA = "0x1D1ED74")]
	public void RefreshSkin()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x1D1F210", Offset = "0x1D1F210", VA = "0x1D1F210")]
	public void StayToPosition(Vector3 position)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x1D1F294", Offset = "0x1D1F294", VA = "0x1D1F294")]
	public void SynchroWithControllerEnable()
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x1D1F2CC", Offset = "0x1D1F2CC", VA = "0x1D1F2CC")]
	public EquipItem()
	{
	}
}
[Token(Token = "0x20000C3")]
public class GizmoHelper : MonoBehaviour
{
	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color color;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float size;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 offset;

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x1D276E8", Offset = "0x1D276E8", VA = "0x1D276E8")]
	public GizmoHelper()
	{
	}
}
[Token(Token = "0x20000C4")]
public class LoadSceneAtStart : MonoBehaviour
{
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF3CC", Offset = "0x9FF3CC")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LoadSceneAtStart <>4__this;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string iSceneName;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<AsyncOperationHandle<SceneInstance>, string> iAction;

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x14C01A8", Offset = "0x14C01A8", VA = "0x14C01A8")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x14C01B0", Offset = "0x14C01B0", VA = "0x14C01B0")]
		internal void <UnloadScene>b__0(AsyncOperationHandle<SceneInstance> op)
		{
		}
	}

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> ScenarioAssetToRemove;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<string> ScenarioAssetToKeep;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string ActiveScene;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<string, AsyncOperationHandle<SceneInstance>> sceneOperationMap;

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x1E6B6E0", Offset = "0x1E6B6E0", VA = "0x1E6B6E0")]
	public void Start()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x1E6BBC4", Offset = "0x1E6BBC4", VA = "0x1E6BBC4")]
	private void OnFinishedLoading(AsyncOperationHandle<SceneInstance> obj)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x1E6BC60", Offset = "0x1E6BC60", VA = "0x1E6BC60")]
	private void OnSceneFinishedLoading(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x1E6BDA0", Offset = "0x1E6BDA0", VA = "0x1E6BDA0")]
	private void UnloadScene(bool iBeginning)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x1E6BA64", Offset = "0x1E6BA64", VA = "0x1E6BA64")]
	public void LoadScene(string iSceneName, Action<AsyncOperationHandle<SceneInstance>> iAction)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x1E6BF58", Offset = "0x1E6BF58", VA = "0x1E6BF58")]
	public void UnloadScene(string iSceneName, Action<AsyncOperationHandle<SceneInstance>, string> iAction)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x1E6C140", Offset = "0x1E6C140", VA = "0x1E6C140")]
	public LoadSceneAtStart()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x1E6C23C", Offset = "0x1E6C23C", VA = "0x1E6C23C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA05D98", Offset = "0xA05D98")]
	private void <LoadScene>b__8_0(AsyncOperationHandle<SceneInstance> op)
	{
	}
}
[Token(Token = "0x20000C6")]
public class SoundManager : MonoBehaviour
{
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF3DC", Offset = "0x9FF3DC")]
	private sealed class <FadeOut>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundManager <>4__this;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string groupAudio;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float speedFactor;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <audioMixVol>5__2;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x14C470C", Offset = "0x14C470C", VA = "0x14C470C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x14C4754", Offset = "0x14C4754", VA = "0x14C4754", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x14C45BC", Offset = "0x14C45BC", VA = "0x14C45BC")]
		[DebuggerHidden]
		public <FadeOut>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x14C45E8", Offset = "0x14C45E8", VA = "0x14C45E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x14C45EC", Offset = "0x14C45EC", VA = "0x14C45EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x14C4714", Offset = "0x14C4714", VA = "0x14C4714", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF3EC", Offset = "0x9FF3EC")]
	private sealed class <FadeIn>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundManager <>4__this;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string groupAudio;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float speedFactor;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <audioMixVol>5__2;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x14C456C", Offset = "0x14C456C", VA = "0x14C456C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x14C45B4", Offset = "0x14C45B4", VA = "0x14C45B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x14C441C", Offset = "0x14C441C", VA = "0x14C441C")]
		[DebuggerHidden]
		public <FadeIn>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x14C4448", Offset = "0x14C4448", VA = "0x14C4448", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x14C444C", Offset = "0x14C444C", VA = "0x14C444C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x14C4574", Offset = "0x14C4574", VA = "0x14C4574", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static SoundManager instance;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioMixer m_AudioMixer;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource m_AudioSource;

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xE35494", Offset = "0xE35494", VA = "0xE35494")]
	private void Awake()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xE35518", Offset = "0xE35518", VA = "0xE35518")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05DA8", Offset = "0xA05DA8")]
	public IEnumerator FadeOut(string groupAudio, float speedFactor = 1f)
	{
		return null;
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xE355BC", Offset = "0xE355BC", VA = "0xE355BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05E08", Offset = "0xA05E08")]
	public IEnumerator FadeIn(string groupAudio, float speedFactor = 1f)
	{
		return null;
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xE35660", Offset = "0xE35660", VA = "0xE35660")]
	public void PlaySound(AudioClip audioClip, bool loop = true)
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xE356D4", Offset = "0xE356D4", VA = "0xE356D4")]
	public void SetVolume(float volume)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xE356F0", Offset = "0xE356F0", VA = "0xE356F0")]
	public SoundManager()
	{
	}
}
[Token(Token = "0x20000C9")]
public class StartChapterSound : MonoBehaviour
{
	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string chapter;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource[] audioSourcesToPlay;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Audio_Fade[] audioFadeToFadeIn;

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xE38BFC", Offset = "0xE38BFC", VA = "0xE38BFC")]
	public void Init()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xE38CB8", Offset = "0xE38CB8", VA = "0xE38CB8")]
	public StartChapterSound()
	{
	}
}
[Token(Token = "0x20000CA")]
public class TeleportationArea : MonoBehaviour
{
	[Token(Token = "0x6000332")]
	[Address(RVA = "0xE3F07C", Offset = "0xE3F07C", VA = "0xE3F07C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xE3F080", Offset = "0xE3F080", VA = "0xE3F080")]
	private void Update()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xE3F084", Offset = "0xE3F084", VA = "0xE3F084")]
	public TeleportationArea()
	{
	}
}
[Token(Token = "0x20000CB")]
public class VR_Player : MonoBehaviour
{
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF3FC", Offset = "0x9FF3FC")]
	private sealed class <Init>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VR_Player <>4__this;

		[Token(Token = "0x17000042")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x14C881C", Offset = "0x14C881C", VA = "0x14C881C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x14C8864", Offset = "0x14C8864", VA = "0x14C8864", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x14C8738", Offset = "0x14C8738", VA = "0x14C8738")]
		[DebuggerHidden]
		public <Init>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x14C8764", Offset = "0x14C8764", VA = "0x14C8764", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x14C8768", Offset = "0x14C8768", VA = "0x14C8768", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x14C8824", Offset = "0x14C8824", VA = "0x14C8824", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01748", Offset = "0xA01748")]
	[SerializeField]
	private GameObject m_RigPlayer;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01794", Offset = "0xA01794")]
	private bool m_IsEnable;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA017E0", Offset = "0xA017E0")]
	[SerializeField]
	private VR_StartScenePosition m_VR_Current_StartScene;

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x1DAF5E0", Offset = "0x1DAF5E0", VA = "0x1DAF5E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x1DAF5E8", Offset = "0x1DAF5E8", VA = "0x1DAF5E8")]
	public void SetActive(bool active)
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x1DAF7C8", Offset = "0x1DAF7C8", VA = "0x1DAF7C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x1DAF810", Offset = "0x1DAF810", VA = "0x1DAF810")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA05F08", Offset = "0xA05F08")]
	private IEnumerator Init()
	{
		return null;
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x1DAF888", Offset = "0x1DAF888", VA = "0x1DAF888")]
	public VR_Player()
	{
	}
}
[Token(Token = "0x20000CD")]
public class VR_StartScenePosition : MonoBehaviour
{
	[Token(Token = "0x6000340")]
	[Address(RVA = "0x1DAF890", Offset = "0x1DAF890", VA = "0x1DAF890")]
	public VR_StartScenePosition()
	{
	}
}
[Token(Token = "0x20000CE")]
public class AndroidMenu : MonoBehaviour
{
	[Token(Token = "0x20000CF")]
	public enum Panel
	{
		[Token(Token = "0x40003FF")]
		Experience,
		[Token(Token = "0x4000400")]
		Instruction,
		[Token(Token = "0x4000401")]
		Transition,
		[Token(Token = "0x4000402")]
		Loading,
		[Token(Token = "0x4000403")]
		Credits,
		[Token(Token = "0x4000404")]
		Pause
	}

	[Token(Token = "0x20000D0")]
	public enum ExperienceAction
	{
		[Token(Token = "0x4000406")]
		Start,
		[Token(Token = "0x4000407")]
		Language,
		[Token(Token = "0x4000408")]
		Chapter,
		[Token(Token = "0x4000409")]
		NextChap,
		[Token(Token = "0x400040A")]
		PrevChap,
		[Token(Token = "0x400040B")]
		More,
		[Token(Token = "0x400040C")]
		Quit,
		[Token(Token = "0x400040D")]
		Resume,
		[Token(Token = "0x400040E")]
		Menu,
		[Token(Token = "0x400040F")]
		Accept,
		[Token(Token = "0x4000410")]
		Refuse
	}

	[Token(Token = "0x20000D1")]
	public enum SelectableType
	{
		[Token(Token = "0x4000412")]
		Language,
		[Token(Token = "0x4000413")]
		Experience,
		[Token(Token = "0x4000414")]
		Chapter,
		[Token(Token = "0x4000415")]
		Pause
	}

	[Serializable]
	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF40C", Offset = "0x9FF40C")]
	private sealed class <>c
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Selectable, bool> <>9__74_0;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<Selectable, bool> <>9__74_3;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<Selectable, bool> <>9__74_4;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<Selectable, bool> <>9__74_1;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<Selectable, bool> <>9__74_2;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Func<Selectable, bool> <>9__76_0;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Func<Selectable, bool> <>9__76_1;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Func<Selectable, bool> <>9__77_0;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1DB72E0", Offset = "0x1DB72E0", VA = "0x1DB72E0")]
		public <>c()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1DB72E8", Offset = "0x1DB72E8", VA = "0x1DB72E8")]
		internal bool <ValidateInput>b__74_0(Selectable e)
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1DB7300", Offset = "0x1DB7300", VA = "0x1DB7300")]
		internal bool <ValidateInput>b__74_3(Selectable e)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1DB7318", Offset = "0x1DB7318", VA = "0x1DB7318")]
		internal bool <ValidateInput>b__74_4(Selectable e)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1DB7330", Offset = "0x1DB7330", VA = "0x1DB7330")]
		internal bool <ValidateInput>b__74_1(Selectable e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1DB7348", Offset = "0x1DB7348", VA = "0x1DB7348")]
		internal bool <ValidateInput>b__74_2(Selectable e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1DB7360", Offset = "0x1DB7360", VA = "0x1DB7360")]
		internal bool <SelectRightSelectableExperience>b__76_0(Selectable e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1DB7380", Offset = "0x1DB7380", VA = "0x1DB7380")]
		internal bool <SelectRightSelectableExperience>b__76_1(Selectable e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1DB73A0", Offset = "0x1DB73A0", VA = "0x1DB73A0")]
		internal bool <SelectRightSelectablePause>b__77_0(Selectable e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF41C", Offset = "0x9FF41C")]
	private sealed class <StartScenarioAfterInstruction>d__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AndroidMenu <>4__this;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <savePosition>5__2;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion <saveRotation>5__3;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject <temp>5__4;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CrossingArgs <args>5__5;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ActivateOnPanel <panel>5__6;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1DB8578", Offset = "0x1DB8578", VA = "0x1DB8578", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x1DB85C0", Offset = "0x1DB85C0", VA = "0x1DB85C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1DB7A74", Offset = "0x1DB7A74", VA = "0x1DB7A74")]
		[DebuggerHidden]
		public <StartScenarioAfterInstruction>d__78(int <>1__state)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1DB7AA0", Offset = "0x1DB7AA0", VA = "0x1DB7AA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1DB7AA4", Offset = "0x1DB7AA4", VA = "0x1DB7AA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1DB8580", Offset = "0x1DB8580", VA = "0x1DB8580", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF42C", Offset = "0x9FF42C")]
	private sealed class <LoadChapter>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AndroidMenu <>4__this;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string iChapter;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x1DB7A24", Offset = "0x1DB7A24", VA = "0x1DB7A24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x1DB7A6C", Offset = "0x1DB7A6C", VA = "0x1DB7A6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1DB76F4", Offset = "0x1DB76F4", VA = "0x1DB76F4")]
		[DebuggerHidden]
		public <LoadChapter>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1DB7720", Offset = "0x1DB7720", VA = "0x1DB7720", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1DB7724", Offset = "0x1DB7724", VA = "0x1DB7724", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1DB7A2C", Offset = "0x1DB7A2C", VA = "0x1DB7A2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF43C", Offset = "0x9FF43C")]
	private sealed class <FadeCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AndroidMenu <>4__this;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color color;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float speed;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int startPoint;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int endPoint;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <blendColor>5__2;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x1DB7510", Offset = "0x1DB7510", VA = "0x1DB7510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x1DB7558", Offset = "0x1DB7558", VA = "0x1DB7558", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1DB73C0", Offset = "0x1DB73C0", VA = "0x1DB73C0")]
		[DebuggerHidden]
		public <FadeCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1DB73EC", Offset = "0x1DB73EC", VA = "0x1DB73EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1DB73F0", Offset = "0x1DB73F0", VA = "0x1DB73F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1DB7518", Offset = "0x1DB7518", VA = "0x1DB7518", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF44C", Offset = "0x9FF44C")]
	private sealed class <GoBackToMainMenu>d__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AndroidMenu <>4__this;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x1DB76A4", Offset = "0x1DB76A4", VA = "0x1DB76A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x1DB76EC", Offset = "0x1DB76EC", VA = "0x1DB76EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1DB7560", Offset = "0x1DB7560", VA = "0x1DB7560")]
		[DebuggerHidden]
		public <GoBackToMainMenu>d__85(int <>1__state)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1DB758C", Offset = "0x1DB758C", VA = "0x1DB758C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1DB7590", Offset = "0x1DB7590", VA = "0x1DB7590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1DB76AC", Offset = "0x1DB76AC", VA = "0x1DB76AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0182C", Offset = "0xA0182C")]
	private static AndroidMenu <Instance>k__BackingField;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0183C", Offset = "0xA0183C")]
	private static bool <IsInMenu>k__BackingField;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0184C", Offset = "0xA0184C")]
	private static bool <CanTP>k__BackingField;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string currentLanguageSet;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject languageSelectionPanel;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Selectable[] dispoLanguage;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject experienceSelectionPanel;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Selectable[] selectableExperiences;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Selectable[] selectableChapters;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Selectable[] selectableInGameChapters;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Selectable acceptTuto;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Selectable refuseTuto;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject chapitreSelectionPanel;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Selectable nextBtn;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Selectable prevBtn;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public HorizontalScrollView chapScrollView;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject morePanel;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject instructionPanelOcukus;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject instructionPanelWave;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject instructionPanelPico;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject leftInstructionPanelOcukus;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject leftInstructionPanelWave;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject leftInstructionPanelPico;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject transitionPanel;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject askTuto;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject loadingPanel;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject pausePanel;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Selectable[] selectablePause;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject chapitreInGameSelectionPanel;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Selectable nextBtnInGame;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Selectable prevBtnInGame;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public HorizontalScrollView chapitreInGameScrollView;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public CameraFade fade;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public MenuPosition menuPosition;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0185C", Offset = "0xA0185C")]
	public GameObject tpToolTips;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public GameObject leftTpToolTips;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public GameObject tpCanvasText;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01894", Offset = "0xA01894")]
	public GameObject rotToolTips;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public GameObject leftRotToolTips;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public GameObject rotCanvasText;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA018CC", Offset = "0xA018CC")]
	public GameObject pauseToolTips;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public GameObject leftPauseToolTips;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public GameObject pauseCanvasText;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01904", Offset = "0xA01904")]
	public GameObject playToolTips;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public GameObject leftPlayToolTips;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public GameObject playCanvasText;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0193C", Offset = "0xA0193C")]
	public GameObject menuToolTips;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public GameObject leftMenuToolTips;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public GameObject menuCanvasText;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public GameObject loadingAnimation;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[HideInInspector]
	public List<string> scenarioList;

	[Token(Token = "0x40003F5")]
	public const string globalScenarioName = "GlobalScenarioOnboarding";

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static Panel currentPanelDisplay;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private bool chapterDisplayed;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x191")]
	private bool langDisplayed;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private string chapterToload;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private int instructionStep;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private float startTime;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private float currentDist;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	private float distFraction;

	[Token(Token = "0x17000044")]
	public static AndroidMenu Instance
	{
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1CA7018", Offset = "0x1CA7018", VA = "0x1CA7018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA05FB8", Offset = "0xA05FB8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1CA707C", Offset = "0x1CA707C", VA = "0x1CA707C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA05FC8", Offset = "0xA05FC8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public static bool IsInMenu
	{
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1CA70E8", Offset = "0x1CA70E8", VA = "0x1CA70E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA05FD8", Offset = "0xA05FD8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1CA714C", Offset = "0x1CA714C", VA = "0x1CA714C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA05FE8", Offset = "0xA05FE8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public static bool CanTP
	{
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1CA71B8", Offset = "0x1CA71B8", VA = "0x1CA71B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA05FF8", Offset = "0xA05FF8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1CA721C", Offset = "0x1CA721C", VA = "0x1CA721C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06008", Offset = "0xA06008")]
		private set
		{
		}
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x1CA7288", Offset = "0x1CA7288", VA = "0x1CA7288")]
	[AttributeAttribute(Name = "ButtonAttribute", RVA = "0xA06018", Offset = "0xA06018")]
	private void GetScenarios()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x1CA7328", Offset = "0x1CA7328", VA = "0x1CA7328")]
	public void Start()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x1CA7FA8", Offset = "0x1CA7FA8", VA = "0x1CA7FA8")]
	public void Update()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x1CA7B64", Offset = "0x1CA7B64", VA = "0x1CA7B64")]
	public void SelectNewLanguage(string iNewLanguage)
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x1CA7DDC", Offset = "0x1CA7DDC", VA = "0x1CA7DDC")]
	public void SetPanelDisplay(Panel iNextPanel)
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x1CA82F8", Offset = "0x1CA82F8", VA = "0x1CA82F8")]
	public void ValidateInput()
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x1CA9294", Offset = "0x1CA9294", VA = "0x1CA9294")]
	public void Select(Selectable selectable)
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x1CA942C", Offset = "0x1CA942C", VA = "0x1CA942C")]
	private void SelectRightSelectableExperience(Selectable selectable)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x1CA985C", Offset = "0x1CA985C", VA = "0x1CA985C")]
	private void SelectRightSelectablePause(Selectable selectable)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x1CA9110", Offset = "0x1CA9110", VA = "0x1CA9110")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06054", Offset = "0xA06054")]
	private IEnumerator StartScenarioAfterInstruction()
	{
		return null;
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x1CA819C", Offset = "0x1CA819C", VA = "0x1CA819C")]
	private void ClearTutoInfo()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x1CA9188", Offset = "0x1CA9188", VA = "0x1CA9188")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA060B4", Offset = "0xA060B4")]
	private IEnumerator LoadChapter(string iChapter)
	{
		return null;
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x1CA9B10", Offset = "0x1CA9B10", VA = "0x1CA9B10")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06114", Offset = "0xA06114")]
	public IEnumerator FadeCoroutine(int startPoint, int endPoint, float speed, Color color)
	{
		return null;
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x1CA921C", Offset = "0x1CA921C", VA = "0x1CA921C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06174", Offset = "0xA06174")]
	private IEnumerator GoBackToMainMenu()
	{
		return null;
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x1CA9BD4", Offset = "0x1CA9BD4", VA = "0x1CA9BD4")]
	public void HideMenu()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x1CA9CB8", Offset = "0x1CA9CB8", VA = "0x1CA9CB8")]
	public void ShowMenu()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x1CA9D9C", Offset = "0x1CA9D9C", VA = "0x1CA9D9C")]
	public void SetInGame()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x1CA9E08", Offset = "0x1CA9E08", VA = "0x1CA9E08")]
	public AndroidMenu()
	{
	}
}
[Token(Token = "0x20000D7")]
public class AnimateColor : MonoBehaviour
{
	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color start;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color end;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float pingPongDuration;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve curve;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float ellapsedTime;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool pingPong;

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x1CA9F24", Offset = "0x1CA9F24", VA = "0x1CA9F24")]
	private void Update()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x1CAA084", Offset = "0x1CAA084", VA = "0x1CAA084")]
	public AnimateColor()
	{
	}
}
[Token(Token = "0x20000D8")]
public class ArrowUpDown : MonoBehaviour
{
	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 direction;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float pingPongDuration;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve curve;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 initial;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float ellapsedTime;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool pingPong;

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x1CAABA0", Offset = "0x1CAABA0", VA = "0x1CAABA0")]
	public void Awake()
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x1CAABDC", Offset = "0x1CAABDC", VA = "0x1CAABDC")]
	public void Update()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x1CAACD0", Offset = "0x1CAACD0", VA = "0x1CAACD0")]
	public ArrowUpDown()
	{
	}
}
[Token(Token = "0x20000D9")]
public class ChangeChapter : MonoBehaviour
{
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF45C", Offset = "0x9FF45C")]
	private sealed class <LoadChapter>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ChangeChapter <>4__this;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <op>5__2;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x1DB99F4", Offset = "0x1DB99F4", VA = "0x1DB99F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x1DB9A3C", Offset = "0x1DB9A3C", VA = "0x1DB9A3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1DB9430", Offset = "0x1DB9430", VA = "0x1DB9430")]
		[DebuggerHidden]
		public <LoadChapter>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1DB945C", Offset = "0x1DB945C", VA = "0x1DB945C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1DB9460", Offset = "0x1DB9460", VA = "0x1DB9460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1DB99FC", Offset = "0x1DB99FC", VA = "0x1DB99FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool isLoadingChapter;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string scenarioToLoad;

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x1CB8410", Offset = "0x1CB8410", VA = "0x1CB8410")]
	public void GoToChapter(string iChapter)
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x1CB8564", Offset = "0x1CB8564", VA = "0x1CB8564")]
	private void Instance_OnScenarioStopped()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x1CB84EC", Offset = "0x1CB84EC", VA = "0x1CB84EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06314", Offset = "0xA06314")]
	public IEnumerator LoadChapter()
	{
		return null;
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x1CB8568", Offset = "0x1CB8568", VA = "0x1CB8568")]
	public ChangeChapter()
	{
	}
}
[Token(Token = "0x20000DB")]
public class FPSCounter : MonoBehaviour
{
	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF46C", Offset = "0x9FF46C")]
	private sealed class <DrawGraph>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FPSCounter <>4__this;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x1DBAE0C", Offset = "0x1DBAE0C", VA = "0x1DBAE0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x1DBAE54", Offset = "0x1DBAE54", VA = "0x1DBAE54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1DBA9C4", Offset = "0x1DBA9C4", VA = "0x1DBA9C4")]
		[DebuggerHidden]
		public <DrawGraph>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1DBA9F0", Offset = "0x1DBA9F0", VA = "0x1DBA9F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1DBA9F4", Offset = "0x1DBA9F4", VA = "0x1DBA9F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1DBAE14", Offset = "0x1DBAE14", VA = "0x1DBAE14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01984", Offset = "0xA01984")]
	public float timeUpdate;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int highestPossibleFPS;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color graphColor;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool logWrite;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool SwitchVisibility;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject counter;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject graph;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform graphTr;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3Int allFps;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private TextMeshProUGUI counterText;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float ofsetX;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int lineCount;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static WaitForSeconds stGraphUpdate;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GameObject[] stLines;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int stNumLines;

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x1D20E18", Offset = "0x1D20E18", VA = "0x1D20E18")]
	private void Awake()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x1D21424", Offset = "0x1D21424", VA = "0x1D21424")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x1D214C8", Offset = "0x1D214C8", VA = "0x1D214C8")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x1D2153C", Offset = "0x1D2153C", VA = "0x1D2153C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x1D21450", Offset = "0x1D21450", VA = "0x1D21450")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA063C4", Offset = "0xA063C4")]
	private IEnumerator DrawGraph()
	{
		return null;
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x1D20E44", Offset = "0x1D20E44", VA = "0x1D20E44")]
	private void CreateCounter()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x1D218B4", Offset = "0x1D218B4", VA = "0x1D218B4")]
	private static GameObject GiveLine()
	{
		return null;
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x1D21994", Offset = "0x1D21994", VA = "0x1D21994")]
	public FPSCounter()
	{
	}
}
[Token(Token = "0x20000DD")]
public static class StFPS
{
	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<float> fpsBuffer;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static float fpsB;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static float timeCounter;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Vector3Int fps;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static List<Vector3Int> logWrite;

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xE38218", Offset = "0xE38218", VA = "0xE38218")]
	public static Vector3Int Counter(float timeUpdate)
	{
		return default(Vector3Int);
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xE38630", Offset = "0xE38630", VA = "0xE38630")]
	public static void LogWrite()
	{
	}
}
[Token(Token = "0x20000DE")]
public class SimpleCounter : MonoBehaviour
{
	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro tmp;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int current;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int moy;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int echan;

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xE317E0", Offset = "0xE317E0", VA = "0xE317E0")]
	public void Update()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xE31884", Offset = "0xE31884", VA = "0xE31884")]
	public SimpleCounter()
	{
	}
}
[Token(Token = "0x20000DF")]
public class MenuPosition : MonoBehaviour
{
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF47C", Offset = "0x9FF47C")]
	private sealed class <Start>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MenuPosition <>4__this;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject <go>5__2;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x14C151C", Offset = "0x14C151C", VA = "0x14C151C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x14C1564", Offset = "0x14C1564", VA = "0x14C1564", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x14C1178", Offset = "0x14C1178", VA = "0x14C1178")]
		[DebuggerHidden]
		public <Start>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x14C11A4", Offset = "0x14C11A4", VA = "0x14C11A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x14C11A8", Offset = "0x14C11A8", VA = "0x14C11A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x14C1524", Offset = "0x14C1524", VA = "0x14C1524", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform userHead;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool shouldActivateSteproom;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform menuAxisRotation;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform menuPosition;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public VirtualStepRoom lobby;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float ellapsedTime;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float tracker;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float lerpValue;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion targetRotation;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float heightModificationTimer;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool locked;

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x123C714", Offset = "0x123C714", VA = "0x123C714")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06474", Offset = "0xA06474")]
	public IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x123C78C", Offset = "0x123C78C", VA = "0x123C78C")]
	public void Update()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x123CB3C", Offset = "0x123CB3C", VA = "0x123CB3C")]
	public void ResetAndLockPosition()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x123CB48", Offset = "0x123CB48", VA = "0x123CB48")]
	public void RemoveLock()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x123CB54", Offset = "0x123CB54", VA = "0x123CB54")]
	public MenuPosition()
	{
	}
}
[Token(Token = "0x20000E1")]
public class OculusCheck : MonoBehaviour
{
	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x1246020", Offset = "0x1246020", VA = "0x1246020")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x12461E4", Offset = "0x12461E4", VA = "0x12461E4")]
	private void EntitlementCallback(Message msg)
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x12462BC", Offset = "0x12462BC", VA = "0x12462BC")]
	public OculusCheck()
	{
	}
}
[Token(Token = "0x20000E2")]
public class ReplaceOnNearClip : MonoBehaviour
{
	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera mainCamera;

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xFF3A88", Offset = "0xFF3A88", VA = "0xFF3A88")]
	private void Update()
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xFF3B0C", Offset = "0xFF3B0C", VA = "0xFF3B0C")]
	public ReplaceOnNearClip()
	{
	}
}
[Token(Token = "0x20000E3")]
public class Selectable : MonoBehaviour
{
	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA019CC", Offset = "0xA019CC")]
	private bool <IsSelected>k__BackingField;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public AndroidMenu.SelectableType selectableType;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xA019DC", Offset = "0xA019DC")]
	public string language;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xA01A14", Offset = "0xA01A14")]
	public AndroidMenu.ExperienceAction experienceAction;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xA01A4C", Offset = "0xA01A4C")]
	public float upPosition;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xA01A84", Offset = "0xA01A84")]
	public bool toggleUp;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xA01ABC", Offset = "0xA01ABC")]
	public string chapter;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Image image;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI text;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xA01AF4", Offset = "0xA01AF4")]
	public TextMeshProUGUI secondaryText;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Color selectedColor;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Color deselectedColor;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Sprite selectedSprite;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Sprite deselectedSprite;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Sprite hoverSprite;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject selectedShadow;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Color selectedTextColor;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Color deselectedTextColor;

	[Token(Token = "0x17000055")]
	public bool IsSelected
	{
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xE2CE98", Offset = "0xE2CE98", VA = "0xE2CE98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06524", Offset = "0xA06524")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xE2CEA0", Offset = "0xE2CEA0", VA = "0xE2CEA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06534", Offset = "0xA06534")]
		private set
		{
		}
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0xE2CEAC", Offset = "0xE2CEAC", VA = "0xE2CEAC")]
	public bool IsLanguage()
	{
		return default(bool);
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0xE2CEBC", Offset = "0xE2CEBC", VA = "0xE2CEBC")]
	public bool IsExperience()
	{
		return default(bool);
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0xE2CED0", Offset = "0xE2CED0", VA = "0xE2CED0")]
	public bool IsChapter()
	{
		return default(bool);
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0xE2CEE0", Offset = "0xE2CEE0", VA = "0xE2CEE0")]
	public void Select()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xE2D0FC", Offset = "0xE2D0FC", VA = "0xE2D0FC")]
	public void Lock()
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xE2D3B0", Offset = "0xE2D3B0", VA = "0xE2D3B0")]
	public void Deselect()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xE2D678", Offset = "0xE2D678", VA = "0xE2D678")]
	public Selectable()
	{
	}
}
[Token(Token = "0x20000E4")]
public class ShowCGU : MonoBehaviour
{
	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA01B2C", Offset = "0xA01B2C")]
	private static ShowCGU <Instance>k__BackingField;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool showCGU;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] cguText;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Canvas menu;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Selectable accept;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Selectable refuse;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Selectable next;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Selectable previous;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<SystemLanguage> languages;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<InputDevice> rightHandDevices;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool previousRightTriggerState;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int currentDisplay;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool loading;

	[Token(Token = "0x17000056")]
	public static ShowCGU Instance
	{
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xE2F934", Offset = "0xE2F934", VA = "0xE2F934")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06544", Offset = "0xA06544")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xE2F980", Offset = "0xE2F980", VA = "0xE2F980")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06554", Offset = "0xA06554")]
		private set
		{
		}
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xE2F9D4", Offset = "0xE2F9D4", VA = "0xE2F9D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xE2FC08", Offset = "0xE2FC08", VA = "0xE2FC08")]
	private void Update()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xE2FE7C", Offset = "0xE2FE7C", VA = "0xE2FE7C")]
	private void ValidateInput()
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xE30054", Offset = "0xE30054", VA = "0xE30054")]
	public void Select(Selectable selectable)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0xE301DC", Offset = "0xE301DC", VA = "0xE301DC")]
	public ShowCGU()
	{
	}
}
[Token(Token = "0x20000E5")]
public class SplashScreen : MonoBehaviour
{
	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF48C", Offset = "0x9FF48C")]
	private sealed class <ShowSplashScreen>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplashScreen <>4__this;

		[Token(Token = "0x17000057")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x14C4E24", Offset = "0x14C4E24", VA = "0x14C4E24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x14C4E6C", Offset = "0x14C4E6C", VA = "0x14C4E6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x14C49A4", Offset = "0x14C49A4", VA = "0x14C49A4")]
		[DebuggerHidden]
		public <ShowSplashScreen>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x14C49D0", Offset = "0x14C49D0", VA = "0x14C49D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x14C49D4", Offset = "0x14C49D4", VA = "0x14C49D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x14C4E2C", Offset = "0x14C4E2C", VA = "0x14C4E2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform userHead;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CanvasGroup canvas;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float CameraDistance;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float smoothTime;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] splashs;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float delay;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 velocity;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float ellapsedTime;

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xE37EB8", Offset = "0xE37EB8", VA = "0xE37EB8")]
	public void Awake()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xE38114", Offset = "0xE38114", VA = "0xE38114")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06564", Offset = "0xA06564")]
	private IEnumerator ShowSplashScreen()
	{
		return null;
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xE37F9C", Offset = "0xE37F9C", VA = "0xE37F9C")]
	public void Stop(bool showMenu = true)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xE3818C", Offset = "0xE3818C", VA = "0xE3818C")]
	public SplashScreen()
	{
	}
}
[Token(Token = "0x20000E7")]
public class TPUserHere : MonoBehaviour
{
	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VirtualStepRoom correspondingVirtualStepRoom;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject pointOfView;

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0xE3B650", Offset = "0xE3B650", VA = "0xE3B650")]
	public void Awake()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0xE3B714", Offset = "0xE3B714", VA = "0xE3B714")]
	public void Start()
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0xE3B7DC", Offset = "0xE3B7DC", VA = "0xE3B7DC")]
	private void Instance_OnScenarioTeleportation()
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0xE3BA40", Offset = "0xE3BA40", VA = "0xE3BA40")]
	public TPUserHere()
	{
	}
}
[Token(Token = "0x20000E8")]
public class TeleportationZoneTarget : MonoBehaviour
{
	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<TeleportationZoneTarget> allZones;

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0xE3F08C", Offset = "0xE3F08C", VA = "0xE3F08C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0xE3F168", Offset = "0xE3F168", VA = "0xE3F168")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0xE3F230", Offset = "0xE3F230", VA = "0xE3F230")]
	public void DisplayZone()
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xE3F2C4", Offset = "0xE3F2C4", VA = "0xE3F2C4")]
	public void HideZone()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xE3F358", Offset = "0xE3F358", VA = "0xE3F358")]
	public TeleportationZoneTarget()
	{
	}
}
[Token(Token = "0x20000E9")]
public class UIPointer : MonoBehaviour
{
	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LineRenderer lineRenderer;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LayerMask layerMask;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool isJoypadPointer;

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x1DAEAEC", Offset = "0x1DAEAEC", VA = "0x1DAEAEC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x1DAF210", Offset = "0x1DAF210", VA = "0x1DAF210")]
	public UIPointer()
	{
	}
}
[Token(Token = "0x20000EA")]
public class WandUtils : MonoBehaviour
{
	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static WandUtils instance;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA01B3C", Offset = "0xA01B3C")]
	private int <currentMainWand>k__BackingField;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public XROrigin XROrigin;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public VRCurvedPointer curvedPointer;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CameraTransition cameraTransition;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject LobbyMenu;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject InGameMenu;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UIPointer pointer;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject hitGO;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public FPSCounter fpsCounter;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject[] waveControllerModel;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject[] oculusControllerModel;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject[] picoControllerModel;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public XRController rightHand;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public XRController leftHand;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool previousLeftPrimaryState;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	private bool previousLeftSecondaryState;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
	private bool previousLeftTriggerState;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
	private bool previousRightTriggerState;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool previousRightPrimaryButtonState;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
	private bool previousRightSecondaryButtonState;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2 previousRightAxisState;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector2 previousLeftJoypadAxisState;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool gamePause;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Vector3 positionOutsideMenu;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool isInGame;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
	private bool showInGameMenu;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private VirtualStepRoom currentVirtualStepRoom;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool androidMenuOpen;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private InputDevice headDevice;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private List<InputDevice> leftHandDevices;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private List<InputDevice> rightHandDevices;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool resetJoypadAngle;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
	private bool isTriggerDown;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
	private bool isMenuDown;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
	private bool isPauseDown;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private bool isTpDown;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
	private bool isRotateDown;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Vector2 joypadState;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool scenariOStartedFromChapter;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public List<string> volumesName;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private List<PlayableDirector> paused;

	[Token(Token = "0x17000059")]
	public int currentMainWand
	{
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1DB0404", Offset = "0x1DB0404", VA = "0x1DB0404")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06614", Offset = "0xA06614")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1DB040C", Offset = "0x1DB040C", VA = "0x1DB040C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06624", Offset = "0xA06624")]
		private set
		{
		}
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x1DB0414", Offset = "0x1DB0414", VA = "0x1DB0414")]
	public void Start()
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x1DB086C", Offset = "0x1DB086C", VA = "0x1DB086C")]
	private void Instance_OnScenarioEndHeavyOperation()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x1DB0A80", Offset = "0x1DB0A80", VA = "0x1DB0A80")]
	private Vector3 GetClosestPointOnFiniteLine(Vector3 point, Vector3 line_start, Vector3 line_end)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x1DB0B60", Offset = "0x1DB0B60", VA = "0x1DB0B60")]
	private void Instance_OnScenarioStart(bool fromTheBeginning)
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x1DB0B70", Offset = "0x1DB0B70", VA = "0x1DB0B70")]
	private void Instance_OnScenarioTeleportation()
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x1DB0CD8", Offset = "0x1DB0CD8", VA = "0x1DB0CD8")]
	private void Instance_OnScenarioFinished()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x1DB0DE4", Offset = "0x1DB0DE4", VA = "0x1DB0DE4")]
	private void SceneManager_sceneUnloaded(Scene arg0)
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x1DB0DEC", Offset = "0x1DB0DEC", VA = "0x1DB0DEC")]
	public void Update()
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x1DB296C", Offset = "0x1DB296C", VA = "0x1DB296C")]
	public void SendImpulse()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x1DB29E8", Offset = "0x1DB29E8", VA = "0x1DB29E8")]
	public bool IsMenuButtonToggle()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x1DB2438", Offset = "0x1DB2438", VA = "0x1DB2438")]
	private void RotateTracking(Vector2 iRightJoypadAxisState)
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x1DB281C", Offset = "0x1DB281C", VA = "0x1DB281C")]
	public void TogglePauseMenu()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x1DB2480", Offset = "0x1DB2480", VA = "0x1DB2480")]
	private void Teleportation(bool iTeleportAction)
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x1DB2148", Offset = "0x1DB2148", VA = "0x1DB2148")]
	public void PauseGame()
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x1DB22E0", Offset = "0x1DB22E0", VA = "0x1DB22E0")]
	public void ResumeGame()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x1DB2B50", Offset = "0x1DB2B50", VA = "0x1DB2B50")]
	public void SetOriginPosition(Vector3 iPosition)
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x1DB2A04", Offset = "0x1DB2A04", VA = "0x1DB2A04")]
	public void SetOriginRotation(float iRotation)
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x1DB2BD8", Offset = "0x1DB2BD8", VA = "0x1DB2BD8")]
	public WandUtils()
	{
	}
}
[Token(Token = "0x20000EB")]
public class Waypoint : MonoBehaviour
{
	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float m_TimeToWaitHere;

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x1DB2CCC", Offset = "0x1DB2CCC", VA = "0x1DB2CCC")]
	public float GetTimeToWait()
	{
		return default(float);
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x1DB2CD4", Offset = "0x1DB2CD4", VA = "0x1DB2CD4")]
	public Waypoint()
	{
	}
}
[Token(Token = "0x20000EC")]
public class WaypointCircuit : MonoBehaviour
{
	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Waypoint> m_Waypoints;

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x1DB2CDC", Offset = "0x1DB2CDC", VA = "0x1DB2CDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x1DB2D88", Offset = "0x1DB2D88", VA = "0x1DB2D88")]
	public Waypoint GetNextWaypoint(Waypoint waypoint, bool clockwise = true)
	{
		return null;
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x1DB2EF8", Offset = "0x1DB2EF8", VA = "0x1DB2EF8")]
	public Waypoint GetNearestWaypoint(Transform fromPosition)
	{
		return null;
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x1DB30B0", Offset = "0x1DB30B0", VA = "0x1DB30B0")]
	public WaypointCircuit()
	{
	}
}
[Token(Token = "0x20000ED")]
public class StickyParticles : MonoBehaviour
{
	[Token(Token = "0x20000EE")]
	public class FakeParticle
	{
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 scale;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float remainingLifetime;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform model;

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x14C69DC", Offset = "0x14C69DC", VA = "0x14C69DC")]
		public FakeParticle()
		{
		}
	}

	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "BurstCompatibleAttribute", RVA = "0x9FF49C", Offset = "0x9FF49C")]
	private struct UpdateParticlesJob : IJobParticleSystemParallelForBatch
	{
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Unity.Collections.ReadOnly]
		public Plane collisionPlane;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Unity.Collections.ReadOnly]
		public float offsetOnPlane;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Unity.Collections.ReadOnly]
		public Vector3 particleUpVector;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x14C69E4", Offset = "0x14C69E4", VA = "0x14C69E4", Slot = "4")]
		public void Execute(ParticleSystemJobData particles, int startIndex, int count)
		{
		}
	}

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Stack<FakeParticle> _pooledParticles;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<FakeParticle> _onGround;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem _system;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ParticleSystemRenderer _systemRenderer;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ParticleSystem.Particle[] _particles;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector4> _previousParticulePosition;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<Vector4> _previousParticuleRotation;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int ParticlesToProcessByFrame;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "InfoBoxAttribute", RVA = "0xA01B6C", Offset = "0xA01B6C")]
	[AttributeAttribute(Name = "InfoBoxAttribute", RVA = "0xA01B6C", Offset = "0xA01B6C")]
	public Transform StickPlane;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float OffsetOnPlane;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 ParticleUpVector;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Mesh OnGroundMesh;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Material OnGroundMaterial;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private UpdateParticlesJob job;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool useJobSystem;

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xE3A300", Offset = "0xE3A300", VA = "0xE3A300")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xE3A44C", Offset = "0xE3A44C", VA = "0xE3A44C")]
	private void OnParticleUpdateJobScheduled()
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xE3A4C4", Offset = "0xE3A4C4", VA = "0xE3A4C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xE3AB28", Offset = "0xE3AB28", VA = "0xE3AB28")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0xE3AB38", Offset = "0xE3AB38", VA = "0xE3AB38")]
	private void UpdateParticles()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0xE3B4F4", Offset = "0xE3B4F4", VA = "0xE3B4F4")]
	public StickyParticles()
	{
	}
}
[Token(Token = "0x20000F0")]
public class DirectionPointer : MonoBehaviour
{
	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x1D1B4D8", Offset = "0x1D1B4D8", VA = "0x1D1B4D8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x1D1B5B8", Offset = "0x1D1B5B8", VA = "0x1D1B5B8")]
	public DirectionPointer()
	{
	}
}
[Token(Token = "0x20000F1")]
[ExecuteInEditMode]
public class Generator : MonoBehaviour
{
	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2Int castRows;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float shaftSpacing;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool meshCast;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Mesh castMesh;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject lightShaftPrefab;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string savePath;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool shaftSettings;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material shaftMat;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xA01C04", Offset = "0xA01C04")]
	public Color pointer_shaftColor;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float pointer_shaftIntensity;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector2 pointer_noiseDirection;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float pointer_noiseScale;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float pointer_noiseUpdateSpeed;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float pointer_maxLength;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public LayerMask pointer_layerMask;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float pointer_shaftWidth;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Vector2 pointer_shaftWidthMinMax;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Texture pointer_shaftTexture;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Transform pointer_shaftDirection;

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x1D27320", Offset = "0x1D27320", VA = "0x1D27320")]
	public Generator()
	{
	}
}
[Serializable]
[Token(Token = "0x20000F2")]
public class SaveVariables
{
	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float pointer_shaftIntensity;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float pointer_shaftColorR;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float pointer_shaftColorG;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float pointer_shaftColorB;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float pointer_shaftColorA;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float pointer_noiseDirectionX;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float pointer_noiseDirectionY;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float pointer_noiseScale;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float pointer_noiseUpdateSpeed;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float pointer_maxLength;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float pointer_shaftWidth;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float pointer_shaftWidthMinMaxX;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float pointer_shaftWidthMinMaxY;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float pointer_shaftDirectionX;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float pointer_shaftDirectionY;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float pointer_shaftDirectionZ;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int castRowsX;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int castRowsY;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float shaftSpacing;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool meshCast;

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0xE2C6A8", Offset = "0xE2C6A8", VA = "0xE2C6A8")]
	public SaveVariables()
	{
	}
}
[Token(Token = "0x20000F3")]
public class Shaft_Behavior : MonoBehaviour
{
	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color shaftColor;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float shaftIntensity;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector2 noiseDirection;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float noiseScale;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float noiseUpdateSpeed;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float maxLength;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LayerMask layerMask;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector2 shaftWidthMinMax;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float shaftAdjustY;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture shaftTexture;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform shaftDirection;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material shaftMat;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float randomRotZ;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float randomWidth;

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0xE2EA48", Offset = "0xE2EA48", VA = "0xE2EA48")]
	private void Start()
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0xE2F124", Offset = "0xE2F124", VA = "0xE2F124")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0xE2EE78", Offset = "0xE2EE78", VA = "0xE2EE78")]
	private void ShaftLength_and_Width()
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0xE2F014", Offset = "0xE2F014", VA = "0xE2F014")]
	private void Shaft_Color_Intensity_TexOffset()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0xE2ED3C", Offset = "0xE2ED3C", VA = "0xE2ED3C")]
	private void OrientShaft()
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0xE2EBE4", Offset = "0xE2EBE4", VA = "0xE2EBE4")]
	private void SyncVariables()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0xE2F158", Offset = "0xE2F158", VA = "0xE2F158")]
	public Shaft_Behavior()
	{
	}
}
[Token(Token = "0x20000F4")]
public class ExitScene : MonoBehaviour
{
	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float deltaTime;

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x1D1F3D4", Offset = "0x1D1F3D4", VA = "0x1D1F3D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x1D1F444", Offset = "0x1D1F444", VA = "0x1D1F444")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x1D1F624", Offset = "0x1D1F624", VA = "0x1D1F624")]
	public ExitScene()
	{
	}
}
[Token(Token = "0x20000F5")]
public class ExtendedFlycam : MonoBehaviour
{
	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float cameraSensitivity;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float climbSpeed;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float normalMoveSpeed;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float slowMoveFactor;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fastMoveFactor;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float rotationX;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float rotationY;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool locked;

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x1D1F6C0", Offset = "0x1D1F6C0", VA = "0x1D1F6C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x1D1F6CC", Offset = "0x1D1F6CC", VA = "0x1D1F6CC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x1D1FD6C", Offset = "0x1D1FD6C", VA = "0x1D1FD6C")]
	public ExtendedFlycam()
	{
	}
}
[Token(Token = "0x20000F6")]
public class SimpleMove : MonoBehaviour
{
	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeSpeed;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform posA;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform posB;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float oldTime;

	[Token(Token = "0x6000407")]
	[Address(RVA = "0xE31894", Offset = "0xE31894", VA = "0xE31894")]
	private void Update()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0xE31990", Offset = "0xE31990", VA = "0xE31990")]
	public SimpleMove()
	{
	}
}
[Token(Token = "0x20000F7")]
public class OvrAvatarTestDriver : OvrAvatarDriver
{
	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 headPos;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion headRot;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xFEA640", Offset = "0xFEA640", VA = "0xFEA640")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xFEA7A4", Offset = "0xFEA7A4", VA = "0xFEA7A4")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xFEAB40", Offset = "0xFEAB40", VA = "0xFEAB40")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0xFEACE4", Offset = "0xFEACE4", VA = "0xFEACE4", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0xFEAD14", Offset = "0xFEAD14", VA = "0xFEAD14")]
	public OvrAvatarTestDriver()
	{
	}
}
[Token(Token = "0x20000F8")]
public class PoseEditHelper : MonoBehaviour
{
	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform poseRoot;

	[Token(Token = "0x600040E")]
	[Address(RVA = "0xFF0AEC", Offset = "0xFF0AEC", VA = "0xFF0AEC")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0xFF0B74", Offset = "0xFF0B74", VA = "0xFF0B74")]
	private void DrawJoints(Transform joint)
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0xFF0CE8", Offset = "0xFF0CE8", VA = "0xFF0CE8")]
	public PoseEditHelper()
	{
	}
}
[Token(Token = "0x20000F9")]
public class GazeTargetSpawner : MonoBehaviour
{
	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject GazeTargetPrefab;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int NumberOfDummyTargets;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int RadiusMultiplier;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isVisible;

	[Token(Token = "0x1700005A")]
	public bool IsVisible
	{
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1D26FF8", Offset = "0x1D26FF8", VA = "0x1D26FF8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1D27000", Offset = "0x1D27000", VA = "0x1D27000")]
		set
		{
		}
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x1D2713C", Offset = "0x1D2713C", VA = "0x1D2713C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x1D27304", Offset = "0x1D27304", VA = "0x1D27304")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x1D2730C", Offset = "0x1D2730C", VA = "0x1D2730C")]
	public GazeTargetSpawner()
	{
	}
}
[Token(Token = "0x20000FA")]
public class RemoteLoopbackManager : MonoBehaviour
{
	[Token(Token = "0x20000FB")]
	private class PacketLatencyPair
	{
		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] PacketData;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FakeLatency;

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x14C3E44", Offset = "0x14C3E44", VA = "0x14C3E44")]
		public PacketLatencyPair()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000FC")]
	public class SimulatedLatencySettings
	{
		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA01C2C", Offset = "0xA01C2C")]
		public float FakeLatencyMax;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA01C44", Offset = "0xA01C44")]
		public float FakeLatencyMin;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA01C5C", Offset = "0xA01C5C")]
		public float LatencyWeight;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA01C74", Offset = "0xA01C74")]
		public int MaxSamples;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float AverageWindow;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float LatencySum;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal LinkedList<float> LatencyValues;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x14C3E4C", Offset = "0x14C3E4C", VA = "0x14C3E4C")]
		public float NextValue()
		{
			return default(float);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x14C3F84", Offset = "0x14C3F84", VA = "0x14C3F84")]
		public SimulatedLatencySettings()
		{
		}
	}

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OvrAvatar LocalAvatar;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar LoopbackAvatar;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimulatedLatencySettings LatencySettings;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int PacketSequence;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LinkedList<PacketLatencyPair> packetQueue;

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xFF2E80", Offset = "0xFF2E80", VA = "0xFF2E80")]
	private void Start()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xFF2FD8", Offset = "0xFF2FD8", VA = "0xFF2FD8")]
	private void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xFF33B8", Offset = "0xFF33B8", VA = "0xFF33B8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xFF3304", Offset = "0xFF3304", VA = "0xFF3304")]
	private void SendPacketData(byte[] data)
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xFF36E8", Offset = "0xFF36E8", VA = "0xFF36E8")]
	private void ReceivePacketData(byte[] data)
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0xFF39C4", Offset = "0xFF39C4", VA = "0xFF39C4")]
	public RemoteLoopbackManager()
	{
	}
}
[Token(Token = "0x20000FD")]
public class P2PManager
{
	[Token(Token = "0x20000FE")]
	private enum MessageType : byte
	{
		[Token(Token = "0x4000540")]
		Update = 1
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0xFEB888", Offset = "0xFEB888", VA = "0xFEB888")]
	public P2PManager()
	{
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0xFEB968", Offset = "0xFEB968", VA = "0xFEB968")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0xFEBA4C", Offset = "0xFEBA4C", VA = "0xFEBA4C")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0xFEBACC", Offset = "0xFEBACC", VA = "0xFEBACC")]
	private void PeerConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0xFEBC3C", Offset = "0xFEBC3C", VA = "0xFEBC3C")]
	private void ConnectionStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0xFEBE7C", Offset = "0xFEBE7C", VA = "0xFEBE7C")]
	public void SendAvatarUpdate(ulong userID, Transform rootTransform, uint sequence, byte[] avatarPacket)
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0xFEC26C", Offset = "0xFEC26C", VA = "0xFEC26C")]
	public void GetRemotePackets()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0xFEC528", Offset = "0xFEC528", VA = "0xFEC528")]
	public void processAvatarPacket(RemotePlayer remote, ref byte[] packet, ref int offset)
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0xFEC048", Offset = "0xFEC048", VA = "0xFEC048")]
	private void PackByte(byte b, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0xFEC45C", Offset = "0xFEC45C", VA = "0xFEC45C")]
	private byte ReadByte(byte[] buf, ref int offset)
	{
		return default(byte);
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0xFEC12C", Offset = "0xFEC12C", VA = "0xFEC12C")]
	private void PackFloat(float f, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0xFEC760", Offset = "0xFEC760", VA = "0xFEC760")]
	private float ReadFloat(byte[] buf, ref int offset)
	{
		return default(float);
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0xFEC090", Offset = "0xFEC090", VA = "0xFEC090")]
	private void PackULong(ulong u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0xFEC4A0", Offset = "0xFEC4A0", VA = "0xFEC4A0")]
	private ulong ReadULong(byte[] buf, ref int offset)
	{
		return default(ulong);
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0xFEC1D0", Offset = "0xFEC1D0", VA = "0xFEC1D0")]
	private void PackUInt32(uint u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0xFEC7E8", Offset = "0xFEC7E8", VA = "0xFEC7E8")]
	private uint ReadUInt32(byte[] buf, ref int offset)
	{
		return default(uint);
	}
}
[Token(Token = "0x20000FF")]
public class PlayerController : SocialPlatformManager
{
	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Camera spyCamera;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject cameraRig;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool showUI;

	[Token(Token = "0x600042F")]
	[Address(RVA = "0xFF0640", Offset = "0xFF0640", VA = "0xFF0640", Slot = "5")]
	public override void Awake()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0xFF0684", Offset = "0xFF0684", VA = "0xFF0684", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0xFF06BC", Offset = "0xFF06BC", VA = "0xFF06BC", Slot = "4")]
	public override void Update()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0xFF06E4", Offset = "0xFF06E4", VA = "0xFF06E4")]
	private void checkInput()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0xFF0880", Offset = "0xFF0880", VA = "0xFF0880")]
	private void ToggleCamera()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0xFF0900", Offset = "0xFF0900", VA = "0xFF0900")]
	private void ToggleUI()
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0xFF0954", Offset = "0xFF0954", VA = "0xFF0954")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x2000100")]
public class RemotePlayer
{
	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong remoteUserID;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool stillInRoom;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public PeerConnectionState p2pConnectionState;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PeerConnectionState voipConnectionState;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar RemoteAvatar;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 receivedRootPosition;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 receivedRootPositionPrior;

	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion receivedRootRotation;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Quaternion receivedRootRotationPrior;

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public VoipAudioSourceHiLevel voipSource;

	[Token(Token = "0x6000436")]
	[Address(RVA = "0xFF3A80", Offset = "0xFF3A80", VA = "0xFF3A80")]
	public RemotePlayer()
	{
	}
}
[Token(Token = "0x2000101")]
public class RoomManager
{
	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong roomID;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong invitedRoomID;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool amIServer;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool startupDone;

	[Token(Token = "0x6000437")]
	[Address(RVA = "0xFF3B14", Offset = "0xFF3B14", VA = "0xFF3B14")]
	public RoomManager()
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0xFF3C18", Offset = "0xFF3C18", VA = "0xFF3C18")]
	private void AcceptingInviteCallback(Message<string> msg)
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0xFF3D98", Offset = "0xFF3D98", VA = "0xFF3D98")]
	public bool CheckForInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0xFF3ED4", Offset = "0xFF3ED4", VA = "0xFF3ED4")]
	public void CreateRoom()
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0xFF3FA8", Offset = "0xFF3FA8", VA = "0xFF3FA8")]
	private void CreateAndJoinPrivateRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0xFF40E4", Offset = "0xFF40E4", VA = "0xFF40E4")]
	private void OnLaunchInviteWorkflowComplete(Message msg)
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0xFF3DC8", Offset = "0xFF3DC8", VA = "0xFF3DC8")]
	public void JoinExistingRoom(ulong roomID)
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0xFF416C", Offset = "0xFF416C", VA = "0xFF416C")]
	private void JoinRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0xFF4918", Offset = "0xFF4918", VA = "0xFF4918")]
	private void RoomUpdateCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0xFF4C6C", Offset = "0xFF4C6C", VA = "0xFF4C6C")]
	public void LeaveCurrentRoom()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0xFF44A0", Offset = "0xFF44A0", VA = "0xFF44A0")]
	private void ProcessRoomData(Message<Room> msg)
	{
	}
}
[Token(Token = "0x2000102")]
public class SocialPlatformManager : MonoBehaviour
{
	[Token(Token = "0x2000103")]
	public enum State
	{
		[Token(Token = "0x4000578")]
		INITIALIZING,
		[Token(Token = "0x4000579")]
		CHECKING_LAUNCH_STATE,
		[Token(Token = "0x400057A")]
		CREATING_A_ROOM,
		[Token(Token = "0x400057B")]
		WAITING_IN_A_ROOM,
		[Token(Token = "0x400057C")]
		JOINING_A_ROOM,
		[Token(Token = "0x400057D")]
		CONNECTED_IN_A_ROOM,
		[Token(Token = "0x400057E")]
		LEAVING_A_ROOM,
		[Token(Token = "0x400057F")]
		SHUTDOWN
	}

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 START_ROTATION_ONE;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly Vector3 START_POSITION_ONE;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 START_ROTATION_TWO;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly Vector3 START_POSITION_TWO;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Vector3 START_ROTATION_THREE;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly Vector3 START_POSITION_THREE;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly Vector3 START_ROTATION_FOUR;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static readonly Vector3 START_POSITION_FOUR;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly Color BLACK;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly Color WHITE;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly Color CYAN;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static readonly Color BLUE;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static readonly Color GREEN;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float voiceCurrent;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private uint packetSequence;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar localAvatarPrefab;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar remoteAvatarPrefab;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject helpPanel;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected MeshRenderer helpMesh;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material riftMaterial;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material gearMaterial;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected OvrAvatar localAvatar;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected GameObject localTrackingSpace;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject localPlayerHead;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Dictionary<ulong, RemotePlayer> remoteUsers;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject roomSphere;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected MeshRenderer sphereMesh;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject roomFloor;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected MeshRenderer floorMesh;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected State currentState;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected static SocialPlatformManager s_instance;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected RoomManager roomManager;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected P2PManager p2pManager;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected VoipManager voipManager;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected ulong myID;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected string myOculusID;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static readonly float VOIP_SCALE;

	[Token(Token = "0x1700005B")]
	public static State CurrentState
	{
		[Token(Token = "0x600044E")]
		[Address(RVA = "0xE34100", Offset = "0xE34100", VA = "0xE34100")]
		get
		{
			return default(State);
		}
	}

	[Token(Token = "0x1700005C")]
	public static ulong MyID
	{
		[Token(Token = "0x600044F")]
		[Address(RVA = "0xE34170", Offset = "0xE34170", VA = "0xE34170")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700005D")]
	public static string MyOculusID
	{
		[Token(Token = "0x6000450")]
		[Address(RVA = "0xE34250", Offset = "0xE34250", VA = "0xE34250")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0xE3225C", Offset = "0xE3225C", VA = "0xE3225C", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0xE32600", Offset = "0xE32600", VA = "0xE32600", Slot = "5")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0xE32D70", Offset = "0xE32D70", VA = "0xE32D70")]
	private void InitCallback(Message<PlatformInitialize> msg)
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0xE33090", Offset = "0xE33090", VA = "0xE33090", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0xE33094", Offset = "0xE33094", VA = "0xE33094")]
	private void IsEntitledCallback(Message msg)
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0xE331B4", Offset = "0xE331B4", VA = "0xE331B4")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0xE33908", Offset = "0xE33908", VA = "0xE33908")]
	private void GetLoggedInUserFriendsAndRoomsCallback(Message<UserAndRoomList> msg)
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0xE33CFC", Offset = "0xE33CFC", VA = "0xE33CFC")]
	public void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0xE33F0C", Offset = "0xE33F0C", VA = "0xE33F0C")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0xE34094", Offset = "0xE34094", VA = "0xE34094")]
	public void AddUser(ulong userID, ref RemotePlayer remoteUser)
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0xE329FC", Offset = "0xE329FC", VA = "0xE329FC")]
	public void LogOutputLine(string line)
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0xE32F18", Offset = "0xE32F18", VA = "0xE32F18")]
	public static void TerminateWithError(Message msg)
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0xE32AB0", Offset = "0xE32AB0", VA = "0xE32AB0")]
	public static void TransitionToState(State newState)
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0xE34378", Offset = "0xE34378", VA = "0xE34378")]
	private static void SetSphereColorForState()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0xE344F4", Offset = "0xE344F4", VA = "0xE344F4")]
	public static void SetFloorColorForState(bool host)
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0xE345D8", Offset = "0xE345D8", VA = "0xE345D8")]
	public static void MarkAllRemoteUsersAsNotInRoom()
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0xE34734", Offset = "0xE34734", VA = "0xE34734")]
	public static void MarkRemoteUserInRoom(ulong userID)
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0xE34818", Offset = "0xE34818", VA = "0xE34818")]
	public static void ForgetRemoteUsersNotInRoom()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0xE32FD0", Offset = "0xE32FD0", VA = "0xE32FD0")]
	public static void LogOutput(string line)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0xE34D60", Offset = "0xE34D60", VA = "0xE34D60")]
	public static bool IsUserInRoom(ulong userID)
	{
		return default(bool);
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0xE34DF4", Offset = "0xE34DF4", VA = "0xE34DF4")]
	public static void AddRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0xE34B4C", Offset = "0xE34B4C", VA = "0xE34B4C")]
	public static void RemoveRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0xE35000", Offset = "0xE35000", VA = "0xE35000")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0xE321D8", Offset = "0xE321D8", VA = "0xE321D8")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA06634", Offset = "0xA06634")]
	public static void MicFilter(short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels)
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0xE35144", Offset = "0xE35144", VA = "0xE35144")]
	public static RemotePlayer GetRemoteUser(ulong userID)
	{
		return null;
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0xE35220", Offset = "0xE35220", VA = "0xE35220")]
	public SocialPlatformManager()
	{
	}
}
[Token(Token = "0x2000104")]
public class VoipManager
{
	[Token(Token = "0x6000460")]
	[Address(RVA = "0x1DAFE10", Offset = "0x1DAFE10", VA = "0x1DAFE10")]
	public VoipManager()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x1DAFEF0", Offset = "0x1DAFEF0", VA = "0x1DAFEF0")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x1DAFFD4", Offset = "0x1DAFFD4", VA = "0x1DAFFD4")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x1DB0054", Offset = "0x1DB0054", VA = "0x1DB0054")]
	private void VoipConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x1DB01C4", Offset = "0x1DB01C4", VA = "0x1DB01C4")]
	private void VoipStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}
}
[Token(Token = "0x2000105")]
public class GazeTarget : MonoBehaviour
{
	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarGazeTargetType Type;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ovrAvatarGazeTargets RuntimeTargetList;

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x1D26CB4", Offset = "0x1D26CB4", VA = "0x1D26CB4")]
	static GazeTarget()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x1D26D3C", Offset = "0x1D26D3C", VA = "0x1D26D3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x1D26EB0", Offset = "0x1D26EB0", VA = "0x1D26EB0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x1D26F14", Offset = "0x1D26F14", VA = "0x1D26F14")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x1D26D78", Offset = "0x1D26D78", VA = "0x1D26D78")]
	private void UpdateGazeTarget()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x1D26FD8", Offset = "0x1D26FD8", VA = "0x1D26FD8")]
	private ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x1D26FF0", Offset = "0x1D26FF0", VA = "0x1D26FF0")]
	public GazeTarget()
	{
	}
}
[Serializable]
[Token(Token = "0x2000106")]
public class AvatarLayer
{
	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int layerIndex;

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x1CAD0CC", Offset = "0x1CAD0CC", VA = "0x1CAD0CC")]
	public AvatarLayer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000107")]
public class PacketRecordSettings
{
	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal bool RecordingFrames;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float UpdateRate;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal float AccumulatedTime;

	[Token(Token = "0x600046D")]
	[Address(RVA = "0xFEC870", Offset = "0xFEC870", VA = "0xFEC870")]
	public PacketRecordSettings()
	{
	}
}
[Token(Token = "0x2000108")]
public class OvrAvatar : MonoBehaviour
{
	[Token(Token = "0x2000109")]
	public class PacketEventArgs : EventArgs
	{
		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly OvrAvatarPacket Packet;

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x14C2074", Offset = "0x14C2074", VA = "0x14C2074")]
		public PacketEventArgs(OvrAvatarPacket packet)
		{
		}
	}

	[Token(Token = "0x200010A")]
	public enum HandType
	{
		[Token(Token = "0x40005E1")]
		Right,
		[Token(Token = "0x40005E2")]
		Left,
		[Token(Token = "0x40005E3")]
		Max
	}

	[Token(Token = "0x200010B")]
	public enum HandJoint
	{
		[Token(Token = "0x40005E5")]
		HandBase,
		[Token(Token = "0x40005E6")]
		IndexBase,
		[Token(Token = "0x40005E7")]
		IndexTip,
		[Token(Token = "0x40005E8")]
		ThumbBase,
		[Token(Token = "0x40005E9")]
		ThumbTip,
		[Token(Token = "0x40005EA")]
		Max
	}

	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF4BC", Offset = "0x9FF4BC")]
	private sealed class <WaitForMouthAudioSource>d__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatar <>4__this;

		[Token(Token = "0x1700005E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x14C2024", Offset = "0x14C2024", VA = "0x14C2024", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x14C206C", Offset = "0x14C206C", VA = "0x14C206C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x14C1E48", Offset = "0x14C1E48", VA = "0x14C1E48")]
		[DebuggerHidden]
		public <WaitForMouthAudioSource>d__137(int <>1__state)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x14C1E74", Offset = "0x14C1E74", VA = "0x14C1E74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x14C1E78", Offset = "0x14C1E78", VA = "0x14C1E78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x14C202C", Offset = "0x14C202C", VA = "0x14C202C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01C8C", Offset = "0xA01C8C")]
	public IntPtr sdkAvatar;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string oculusUserID;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatarDriver Driver;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01CC4", Offset = "0xA01CC4")]
	public bool EnableBody;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool EnableHands;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool EnableBase;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool EnableExpressive;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01CFC", Offset = "0xA01CFC")]
	public bool RecordPackets;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool UseSDKPackets;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PacketRecordSettings PacketSettings;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01D34", Offset = "0xA01D34")]
	public bool StartWithControllers;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AvatarLayer FirstPersonLayer;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AvatarLayer ThirdPersonLayer;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool ShowFirstPerson;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool ShowThirdPerson;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	internal ovrAvatarCapabilities Capabilities;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA01D6C", Offset = "0xA01D6C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01D6C", Offset = "0xA01D6C")]
	internal ovrAvatarAssetLevelOfDetail LevelOfDetail;

	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA01DDC", Offset = "0xA01DDC")]
	private bool CombineMeshes;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA01E14", Offset = "0xA01E14")]
	public bool UseTransparentRenderQueue;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01E4C", Offset = "0xA01E4C")]
	public Shader Monochrome_SurfaceShader;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Shader Monochrome_SurfaceShader_SelfOccluding;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Shader Monochrome_SurfaceShader_PBS;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Shader Skinshaded_SurfaceShader_SingleComponent;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Shader Skinshaded_VertFrag_SingleComponent;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Shader Skinshaded_VertFrag_CombinedMesh;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Shader Skinshaded_Expressive_SurfaceShader_SingleComponent;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Shader Skinshaded_Expressive_VertFrag_SingleComponent;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Shader Skinshaded_Expressive_VertFrag_CombinedMesh;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Shader Loader_VertFrag_CombinedMesh;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Shader EyeLens;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Shader ControllerShader;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA01E84", Offset = "0xA01E84")]
	public bool CanOwnMicrophone;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA01EBC", Offset = "0xA01EBC")]
	public bool EnableLaughter;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject MouthAnchor;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform LeftHandCustomPose;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform RightHandCustomPose;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private HashSet<ulong> assetLoadingIds;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool assetsFinishedLoading;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private OvrAvatarMaterialManager materialManager;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool waitingForCombinedMesh;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool doneExpressiveGlobalInit;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector4 clothingAlphaOffset;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ulong clothingAlphaTexture;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private OVRLipSyncMicInput micInput;

	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private OVRLipSyncContext lipsyncContext;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private OVRLipSync.Frame currentFrame;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float[] visemes;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private AudioSource audioSource;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ONSPAudioSource spatializedSource;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<float[]> voiceUpdates;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ovrAvatarVisemes RuntimeVisemes;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Transform cachedLeftHandCustomPose;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Transform[] cachedCustomLeftHandJoints;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private ovrAvatarTransform[] cachedLeftHandTransforms;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Transform cachedRightHandCustomPose;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Transform[] cachedCustomRightHandJoints;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ovrAvatarTransform[] cachedRightHandTransforms;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool showLeftController;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
	private bool showRightController;

	[Token(Token = "0x40005C1")]
	private const bool USE_MOBILE_TEXTURE_FORMAT = true;

	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 MOUTH_HEAD_OFFSET;

	[Token(Token = "0x40005C3")]
	private const string MOUTH_HELPER_NAME = "MouthAnchor";

	[Token(Token = "0x40005C4")]
	private const int VISEME_COUNT = 16;

	[Token(Token = "0x40005C5")]
	private const float ACTION_UNIT_ONSET_SPEED = 30f;

	[Token(Token = "0x40005C6")]
	private const float ACTION_UNIT_FALLOFF_SPEED = 20f;

	[Token(Token = "0x40005C7")]
	private const float VISEME_LEVEL_MULTIPLIER = 1.5f;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	internal ulong oculusUserIDInternal;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	internal OvrAvatarBase Base;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	internal OvrAvatarTouchController ControllerLeft;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	internal OvrAvatarTouchController ControllerRight;

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	internal OvrAvatarBody Body;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	internal OvrAvatarHand HandLeft;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal OvrAvatarHand HandRight;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	internal ovrAvatarLookAndFeelVersion LookAndFeelVersion;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	internal ovrAvatarLookAndFeelVersion FallbackLookAndFeelVersion;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private OvrAvatarPacket CurrentUnityPacket;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public EventHandler<PacketEventArgs> PacketRecorded;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string[,] HandJoints;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Vector3 MOUTH_POSITION_OFFSET;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static string VOICE_PROPERTY;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string MOUTH_POSITION_PROPERTY;

	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static string MOUTH_DIRECTION_PROPERTY;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static string MOUTH_SCALE_PROPERTY;

	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static float MOUTH_SCALE_GLOBAL;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static float MOUTH_MAX_GLOBAL;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static string NECK_JONT;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float VoiceAmplitude;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public bool EnableMouthVertexAnimation;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static ovrAvatarLights ovrLights;

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x1246600", Offset = "0x1246600", VA = "0x1246600")]
	static OvrAvatar()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x1246AA0", Offset = "0x1246AA0", VA = "0x1246AA0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x1246B34", Offset = "0x1246B34", VA = "0x1246B34")]
	public void AssetLoadedCallback(OvrAvatarAsset asset)
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x1246B9C", Offset = "0x1246B9C", VA = "0x1246B9C")]
	public void CombinedMeshLoadedCallback(IntPtr assetPtr)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x1246CCC", Offset = "0x1246CCC", VA = "0x1246CCC")]
	private OvrAvatarSkinnedMeshRenderComponent AddSkinnedMeshRenderComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender)
	{
		return null;
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x1246DAC", Offset = "0x1246DAC", VA = "0x1246DAC")]
	private OvrAvatarSkinnedMeshRenderPBSComponent AddSkinnedMeshRenderPBSComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS)
	{
		return null;
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x1246E88", Offset = "0x1246E88", VA = "0x1246E88")]
	private OvrAvatarSkinnedMeshPBSV2RenderComponent AddSkinnedMeshRenderPBSV2Component(IntPtr renderPart, GameObject go, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRenderPBSV2, bool isBodyPartZero, bool isControllerModel)
	{
		return null;
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x124706C", Offset = "0x124706C", VA = "0x124706C")]
	public static IntPtr GetRenderPart(ovrAvatarComponent component, uint renderPartIndex)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x1247148", Offset = "0x1247148", VA = "0x1247148")]
	private static string GetRenderPartName(ovrAvatarComponent component, uint renderPartIndex)
	{
		return null;
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x12471C0", Offset = "0x12471C0", VA = "0x12471C0")]
	internal static void ConvertTransform(float[] transform, ref ovrAvatarTransform target)
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x12472A8", Offset = "0x12472A8", VA = "0x12472A8")]
	internal static void ConvertTransform(ovrAvatarTransform transform, Transform target)
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x1247334", Offset = "0x1247334", VA = "0x1247334")]
	public static ovrAvatarTransform CreateOvrAvatarTransform(Vector3 position, Quaternion orientation)
	{
		return default(ovrAvatarTransform);
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x12473BC", Offset = "0x12473BC", VA = "0x12473BC")]
	private static ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x12473D4", Offset = "0x12473D4", VA = "0x12473D4")]
	private void BuildRenderComponents()
	{
	}

	[Token(Token = "0x600047C")]
	private void AddAvatarComponent<T>(ref T root, ovrAvatarComponent nativeComponent) where T : OvrAvatarComponent
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x1247884", Offset = "0x1247884", VA = "0x1247884")]
	private void UpdateCustomPoses()
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x1247C04", Offset = "0x1247C04", VA = "0x1247C04")]
	private static bool UpdatePoseRoot(Transform poseRoot, ref Transform cachedPoseRoot, ref Transform[] cachedPoseJoints, ref ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x1247DF0", Offset = "0x1247DF0", VA = "0x1247DF0")]
	private static bool UpdateTransforms(Transform[] joints, ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x124803C", Offset = "0x124803C", VA = "0x124803C")]
	private static void OrderJoints(Transform transform, List<Transform> joints)
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x1248130", Offset = "0x1248130", VA = "0x1248130")]
	private void AvatarSpecificationCallback(IntPtr avatarSpecification)
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x124879C", Offset = "0x124879C", VA = "0x124879C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x1248AD4", Offset = "0x1248AD4", VA = "0x1248AD4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x124950C", Offset = "0x124950C", VA = "0x124950C")]
	public static ovrAvatarHandInputState CreateInputState(ovrAvatarTransform transform, OvrAvatarDriver.ControllerPose pose)
	{
		return default(ovrAvatarHandInputState);
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x1249560", Offset = "0x1249560", VA = "0x1249560")]
	public void ShowControllers(bool show)
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x12483EC", Offset = "0x12483EC", VA = "0x12483EC")]
	public void ShowLeftController(bool show)
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x1248490", Offset = "0x1248490", VA = "0x1248490")]
	public void ShowRightController(bool show)
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x1249590", Offset = "0x1249590", VA = "0x1249590")]
	public void UpdateVoiceVisualization(float[] voiceSamples)
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x1248EAC", Offset = "0x1248EAC", VA = "0x1248EAC")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x1249804", Offset = "0x1249804", VA = "0x1249804")]
	private void RecordUnityFrame()
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x12495F4", Offset = "0x12495F4", VA = "0x12495F4")]
	private void RecordSDKFrame()
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x1249AD8", Offset = "0x1249AD8", VA = "0x1249AD8")]
	private void AddRenderParts(OvrAvatarComponent ovrComponent, ovrAvatarComponent component, Transform parent)
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x1249F54", Offset = "0x1249F54", VA = "0x1249F54")]
	public void RefreshBodyParts()
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x124A358", Offset = "0x124A358", VA = "0x124A358")]
	public ovrAvatarBodyComponent? GetBodyComponent()
	{
		return null;
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x124A4AC", Offset = "0x124A4AC", VA = "0x124A4AC")]
	public Transform GetHandTransform(HandType hand, HandJoint joint)
	{
		return null;
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x124A690", Offset = "0x124A690", VA = "0x124A690")]
	public void GetPointingDirection(HandType hand, ref Vector3 forward, ref Vector3 up)
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x124908C", Offset = "0x124908C", VA = "0x124908C")]
	private void UpdateVoiceBehavior()
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x124A764", Offset = "0x124A764", VA = "0x124A764")]
	private bool IsValidMic()
	{
		return default(bool);
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x1248EBC", Offset = "0x1248EBC", VA = "0x1248EBC")]
	private void InitPostLoad()
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x124A854", Offset = "0x124A854", VA = "0x124A854")]
	private static void ExpressiveGlobalInit()
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x124AF08", Offset = "0x124AF08", VA = "0x124AF08")]
	private static void InitializeLights()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x124B3EC", Offset = "0x124B3EC", VA = "0x124B3EC")]
	private static ovrAvatarLight CreateLightDirectional(uint id, Vector3 direction, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x124B414", Offset = "0x124B414", VA = "0x124B414")]
	private static ovrAvatarLight CreateLightPoint(uint id, Vector3 position, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x124B43C", Offset = "0x124B43C", VA = "0x124B43C")]
	private static ovrAvatarLight CreateLightSpot(uint id, Vector3 position, Vector3 direction, float spotAngleDeg, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x1249398", Offset = "0x1249398", VA = "0x1249398")]
	private void UpdateExpressive()
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x124A924", Offset = "0x124A924", VA = "0x124A924")]
	private void ConfigureHelpers()
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x124B86C", Offset = "0x124B86C", VA = "0x124B86C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06694", Offset = "0xA06694")]
	private IEnumerator WaitForMouthAudioSource()
	{
		return null;
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x124B8E4", Offset = "0x124B8E4", VA = "0x124B8E4")]
	public void DestroyHelperObjects()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x124B72C", Offset = "0x124B72C", VA = "0x124B72C")]
	public GameObject CreateHelperObject(Transform parent, Vector3 localPositionOffset, string helperName, string helperTag = "")
	{
		return null;
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x124B9A8", Offset = "0x124B9A8", VA = "0x124B9A8")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x124BA90", Offset = "0x124BA90", VA = "0x124BA90")]
	public void UpdateVoiceData(float[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x124B478", Offset = "0x124B478", VA = "0x124B478")]
	private void UpdateFacewave()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x124BB78", Offset = "0x124BB78", VA = "0x124BB78")]
	public OvrAvatar()
	{
	}
}
[Token(Token = "0x200010D")]
public class OvrAvatarAsset
{
	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong assetID;

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x124BD74", Offset = "0x124BD74", VA = "0x124BD74")]
	public OvrAvatarAsset()
	{
	}
}
[Token(Token = "0x200010E")]
public class OvrAvatarAssetMesh : OvrAvatarAsset
{
	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh mesh;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAvatarSkinnedMeshPose skinnedBindPose;

	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string[] jointNames;

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x124BE44", Offset = "0x124BE44", VA = "0x124BE44")]
	public OvrAvatarAssetMesh(ulong _assetId, IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x124D0FC", Offset = "0x124D0FC", VA = "0x124D0FC")]
	private void LoadSubmeshes(IntPtr asset, IntPtr indexBufferPtr, ulong indexCount)
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x124CCD0", Offset = "0x124CCD0", VA = "0x124CCD0")]
	private void LoadBlendShapes(IntPtr asset, long vertexCount)
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x124CA54", Offset = "0x124CA54", VA = "0x124CA54")]
	private void SetSkinnedBindPose(IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x124CB3C", Offset = "0x124CB3C", VA = "0x124CB3C")]
	private void GetVertexAndIndexData(IntPtr asset, ovrAvatarAssetType meshType, out long vertexCount, out IntPtr vertexBuffer, out uint indexCount, out IntPtr indexBuffer)
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x124D38C", Offset = "0x124D38C", VA = "0x124D38C")]
	public SkinnedMeshRenderer CreateSkinnedMeshRendererOnObject(GameObject target)
	{
		return null;
	}
}
[Token(Token = "0x200010F")]
public class OvrAvatarAssetTexture : OvrAvatarAsset
{
	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D texture;

	[Token(Token = "0x40005F3")]
	private const int ASTCHeaderSize = 16;

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x124D954", Offset = "0x124D954", VA = "0x124D954")]
	public OvrAvatarAssetTexture(ulong _assetId, IntPtr asset)
	{
	}
}
[Token(Token = "0x2000110")]
public class OvrAvatarBase : OvrAvatarComponent
{
	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ovrAvatarBaseComponent component;

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x124DBD0", Offset = "0x124DBD0", VA = "0x124DBD0")]
	private void Update()
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x124E030", Offset = "0x124E030", VA = "0x124E030")]
	public OvrAvatarBase()
	{
	}
}
[Token(Token = "0x2000111")]
public class OvrAvatarBody : OvrAvatarComponent
{
	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ovrAvatarBodyComponent component;

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x124A1E8", Offset = "0x124A1E8", VA = "0x124A1E8")]
	public ovrAvatarComponent? GetNativeAvatarComponent()
	{
		return null;
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x124E160", Offset = "0x124E160", VA = "0x124E160")]
	private void Update()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x124E290", Offset = "0x124E290", VA = "0x124E290")]
	public OvrAvatarBody()
	{
	}
}
[Token(Token = "0x2000112")]
public class OvrAvatarComponent : MonoBehaviour
{
	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] LayerKeywords;

	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string[] LayerSampleModeParameters;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string[] LayerBlendModeParameters;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string[] LayerMaskTypeParameters;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string[] LayerColorParameters;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string[] LayerSurfaceParameters;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string[] LayerSampleParametersParameters;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string[] LayerMaskParametersParameters;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string[] LayerMaskAxisParameters;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Material, ovrAvatarMaterialState> materialStates;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<OvrAvatarRenderComponent> RenderParts;

	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected OvrAvatar owner;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected ovrAvatarComponent nativeAvatarComponent;

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x124E2F0", Offset = "0x124E2F0", VA = "0x124E2F0")]
	public void SetOvrAvatarOwner(OvrAvatar ovrAvatarOwner)
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x124DD00", Offset = "0x124DD00", VA = "0x124DD00")]
	public void UpdateAvatar(IntPtr nativeComponent)
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x124E2F8", Offset = "0x124E2F8", VA = "0x124E2F8")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x124E358", Offset = "0x124E358", VA = "0x124E358")]
	public void UpdateAvatarMaterial(Material mat, ovrAvatarMaterialState matState)
	{
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x124EB0C", Offset = "0x124EB0C", VA = "0x124EB0C")]
	public static Texture2D GetLoadedTexture(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x124E090", Offset = "0x124E090", VA = "0x124E090")]
	public OvrAvatarComponent()
	{
	}
}
[Token(Token = "0x2000113")]
public abstract class OvrAvatarDriver : MonoBehaviour
{
	[Token(Token = "0x2000114")]
	public enum PacketMode
	{
		[Token(Token = "0x4000607")]
		SDK,
		[Token(Token = "0x4000608")]
		Unity
	}

	[Token(Token = "0x2000115")]
	public struct ControllerPose
	{
		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarButton buttons;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ovrAvatarTouch touches;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 joystickPosition;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float indexTrigger;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float handTrigger;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isActive;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x14C20F4", Offset = "0x14C20F4", VA = "0x14C20F4")]
		public static ControllerPose Interpolate(ControllerPose a, ControllerPose b, float t)
		{
			return default(ControllerPose);
		}
	}

	[Token(Token = "0x2000116")]
	public struct PoseFrame
	{
		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 headPosition;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion headRotation;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 handLeftPosition;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Quaternion handLeftRotation;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 handRightPosition;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Quaternion handRightRotation;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float voiceAmplitude;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ControllerPose controllerLeftPose;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public ControllerPose controllerRightPose;

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x14C21D0", Offset = "0x14C21D0", VA = "0x14C21D0")]
		public static PoseFrame Interpolate(PoseFrame a, PoseFrame b, float t)
		{
			return default(PoseFrame);
		}
	}

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PacketMode Mode;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected PoseFrame CurrentPose;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private ovrAvatarControllerType ControllerType;

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x1250444", Offset = "0x1250444", VA = "0x1250444")]
	public PoseFrame GetCurrentPose()
	{
		return default(PoseFrame);
	}

	[Token(Token = "0x60004BE")]
	public abstract void UpdateTransforms(IntPtr sdkAvatar);

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x1250454", Offset = "0x1250454", VA = "0x1250454")]
	private void Start()
	{
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x1248534", Offset = "0x1248534", VA = "0x1248534")]
	public void UpdateTransformsFromPose(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x12504DC", Offset = "0x12504DC", VA = "0x12504DC")]
	public static bool GetIsTrackedRemote()
	{
		return default(bool);
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x12504E4", Offset = "0x12504E4", VA = "0x12504E4")]
	protected OvrAvatarDriver()
	{
	}
}
[Token(Token = "0x2000117")]
public class OvrAvatarHand : OvrAvatarComponent
{
	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarHandComponent component;

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x12504F4", Offset = "0x12504F4", VA = "0x12504F4")]
	private void Update()
	{
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x1250664", Offset = "0x1250664", VA = "0x1250664")]
	public OvrAvatarHand()
	{
	}
}
[Token(Token = "0x2000118")]
public class OvrAvatarLocalDriver : OvrAvatarDriver
{
	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 centerEyePosition;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion centerEyeRotation;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x12506CC", Offset = "0x12506CC", VA = "0x12506CC")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x1250830", Offset = "0x1250830", VA = "0x1250830")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x1250BCC", Offset = "0x1250BCC", VA = "0x1250BCC")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x1250DF0", Offset = "0x1250DF0", VA = "0x1250DF0", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x1250E1C", Offset = "0x1250E1C", VA = "0x1250E1C")]
	public OvrAvatarLocalDriver()
	{
	}
}
[Token(Token = "0x2000119")]
public class OvrAvatarMaterialManager : MonoBehaviour
{
	[Token(Token = "0x200011A")]
	public enum TextureType
	{
		[Token(Token = "0x400063E")]
		DiffuseTextures,
		[Token(Token = "0x400063F")]
		NormalMaps,
		[Token(Token = "0x4000640")]
		RoughnessMaps,
		[Token(Token = "0x4000641")]
		Count
	}

	[Token(Token = "0x200011B")]
	public struct AvatarComponentMaterialProperties
	{
		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarBodyPartType TypeIndex;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Color Color;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D[] Textures;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DiffuseIntensity;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RimIntensity;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ReflectionIntensity;
	}

	[Token(Token = "0x200011C")]
	public struct AvatarTextureArrayProperties
	{
		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D[] Textures;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2DArray TextureArray;
	}

	[Token(Token = "0x200011D")]
	public struct AvatarMaterialPropertyBlock
	{
		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4[] Colors;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] DiffuseIntensities;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] RimIntensities;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] ReflectionIntensities;
	}

	[Serializable]
	[Token(Token = "0x200011E")]
	public class AvatarMaterialConfig
	{
		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AvatarComponentMaterialProperties[] ComponentMaterialProperties;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AvatarMaterialPropertyBlock MaterialPropertyBlock;

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x14C2C14", Offset = "0x14C2C14", VA = "0x14C2C14")]
		public AvatarMaterialConfig()
		{
		}
	}

	[Token(Token = "0x200011F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF4CC", Offset = "0x9FF4CC")]
	private sealed class <RunLoadingAnimation>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatarMaterialManager <>4__this;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callBack;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <srcBlend>5__2;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <dstBlend>5__3;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <lightModeTag>5__4;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <renderTypeTag>5__5;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <renderQueueTag>5__6;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <ignoreProjectorTag>5__7;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <renderQueue>5__8;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool <transparentQueue>5__9;

		[Token(Token = "0x17000060")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x14C2BC4", Offset = "0x14C2BC4", VA = "0x14C2BC4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x14C2C0C", Offset = "0x14C2C0C", VA = "0x14C2C0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x14C24D4", Offset = "0x14C24D4", VA = "0x14C24D4")]
		[DebuggerHidden]
		public <RunLoadingAnimation>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x14C2500", Offset = "0x14C2500", VA = "0x14C2500", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x14C2504", Offset = "0x14C2504", VA = "0x14C2504", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x14C2BCC", Offset = "0x14C2BCC", VA = "0x14C2BCC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer TargetRenderer;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AvatarTextureArrayProperties[] TextureArrays;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string[] TextureTypeToShaderProperties;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AvatarMaterialConfig LocalAvatarConfig;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ReflectionProbeBlendInfo> ReflectionProbes;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader CombinedShader;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string AVATAR_SHADER_LOADER;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string AVATAR_SHADER_MAINTEX;

	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string AVATAR_SHADER_NORMALMAP;

	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string AVATAR_SHADER_ROUGHNESSMAP;

	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string AVATAR_SHADER_COLOR;

	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string AVATAR_SHADER_DIFFUSEINTENSITY;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string AVATAR_SHADER_RIMINTENSITY;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string AVATAR_SHADER_REFLECTIONINTENSITY;

	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string AVATAR_SHADER_CUBEMAP;

	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string AVATAR_SHADER_ALPHA;

	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static string AVATAR_SHADER_LOADING_DIMMER;

	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string AVATAR_SHADER_IRIS_COLOR;

	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string AVATAR_SHADER_LIP_COLOR;

	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static string AVATAR_SHADER_BROW_COLOR;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static string AVATAR_SHADER_LASH_COLOR;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static string AVATAR_SHADER_SCLERA_COLOR;

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static string AVATAR_SHADER_GUM_COLOR;

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static string AVATAR_SHADER_TEETH_COLOR;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static string AVATAR_SHADER_LIP_SMOOTHNESS;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static float[] DiffuseIntensities;

	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static float[] RimIntensities;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static float[] ReflectionIntensities;

	[Token(Token = "0x4000639")]
	private const float LOADING_ANIMATION_AMPLITUDE = 0.5f;

	[Token(Token = "0x400063A")]
	private const float LOADING_ANIMATION_PERIOD = 0.35f;

	[Token(Token = "0x400063B")]
	private const float LOADING_ANIMATION_CURVE_SCALE = 0.25f;

	[Token(Token = "0x400063C")]
	private const float LOADING_ANIMATION_DIMMER_MIN = 0.3f;

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0xFE2700", Offset = "0xFE2700", VA = "0xFE2700")]
	public void CreateTextureArrays()
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0xFE28E0", Offset = "0xFE28E0", VA = "0xFE28E0")]
	public void SetRenderer(Renderer renderer)
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0xFE2920", Offset = "0xFE2920", VA = "0xFE2920")]
	public void OnCombinedMeshReady()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0xFE30B4", Offset = "0xFE30B4", VA = "0xFE30B4")]
	public void AddTextureIDToTextureManager(ulong assetID, bool isSingleComponent)
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0xFE3594", Offset = "0xFE3594", VA = "0xFE3594")]
	private void DeleteTextureSet()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0xFE29BC", Offset = "0xFE29BC", VA = "0xFE29BC")]
	public void InitTextureArrays()
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0xFE3680", Offset = "0xFE3680", VA = "0xFE3680")]
	private void ProcessTexturesWithMips(Texture2D[] textures, int texArrayResolution, Texture2DArray texArray)
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0xFE2E10", Offset = "0xFE2E10", VA = "0xFE2E10")]
	private void SetMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0xFE3910", Offset = "0xFE3910", VA = "0xFE3910")]
	private void ApplyMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0xFE3BB4", Offset = "0xFE3BB4", VA = "0xFE3BB4")]
	public static ovrAvatarBodyPartType GetComponentType(string objectName)
	{
		return default(ovrAvatarBodyPartType);
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0xFE3CDC", Offset = "0xFE3CDC", VA = "0xFE3CDC")]
	private ulong GetTextureIDForType(ovrAvatarPBSMaterialState materialState, TextureType type)
	{
		return default(ulong);
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0xFE3D14", Offset = "0xFE3D14", VA = "0xFE3D14")]
	public void ValidateTextures(ovrAvatarPBSMaterialState[] materialStates)
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0xFE3020", Offset = "0xFE3020", VA = "0xFE3020")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06744", Offset = "0xA06744")]
	private IEnumerator RunLoadingAnimation(Action callBack)
	{
		return null;
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0xFE4C7C", Offset = "0xFE4C7C", VA = "0xFE4C7C")]
	public OvrAvatarMaterialManager()
	{
	}
}
[Token(Token = "0x2000120")]
public class OvrAvatarPacket
{
	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr ovrNativePacket;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<float> frameTimes;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<OvrAvatarDriver.PoseFrame> frames;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<byte[]> encodedAudioPackets;

	[Token(Token = "0x17000062")]
	public float Duration
	{
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xFE52B8", Offset = "0xFE52B8", VA = "0xFE52B8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000063")]
	public OvrAvatarDriver.PoseFrame FinalFrame
	{
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xFE532C", Offset = "0xFE532C", VA = "0xFE532C")]
		get
		{
			return default(OvrAvatarDriver.PoseFrame);
		}
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0xFE53BC", Offset = "0xFE53BC", VA = "0xFE53BC")]
	public OvrAvatarPacket()
	{
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0xFE54E8", Offset = "0xFE54E8", VA = "0xFE54E8")]
	public OvrAvatarPacket(OvrAvatarDriver.PoseFrame initialPose)
	{
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0xFE56B4", Offset = "0xFE56B4", VA = "0xFE56B4")]
	private OvrAvatarPacket(List<float> frameTimes, List<OvrAvatarDriver.PoseFrame> frames, List<byte[]> audioPackets)
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0xFE5820", Offset = "0xFE5820", VA = "0xFE5820")]
	public void AddFrame(OvrAvatarDriver.PoseFrame frame, float deltaSeconds)
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0xFE58F8", Offset = "0xFE58F8", VA = "0xFE58F8")]
	public OvrAvatarDriver.PoseFrame GetPoseFrame(float seconds)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0xFE5B28", Offset = "0xFE5B28", VA = "0xFE5B28")]
	public static OvrAvatarPacket Read(Stream stream)
	{
		return null;
	}

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0xFE5E04", Offset = "0xFE5E04", VA = "0xFE5E04")]
	public void Write(Stream stream)
	{
	}
}
[Token(Token = "0x2000121")]
internal static class BinaryWriterExtensions
{
	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x1CAD938", Offset = "0x1CAD938", VA = "0x1CAD938")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.PoseFrame frame)
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x1CADA4C", Offset = "0x1CADA4C", VA = "0x1CADA4C")]
	public static void Write(this BinaryWriter writer, Vector3 vec3)
	{
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x1CADBF8", Offset = "0x1CADBF8", VA = "0x1CADBF8")]
	public static void Write(this BinaryWriter writer, Vector2 vec2)
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x1CADABC", Offset = "0x1CADABC", VA = "0x1CADABC")]
	public static void Write(this BinaryWriter writer, Quaternion quat)
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x1CADB50", Offset = "0x1CADB50", VA = "0x1CADB50")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.ControllerPose pose)
	{
	}
}
[Token(Token = "0x2000122")]
internal static class BinaryReaderExtensions
{
	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x1CAD538", Offset = "0x1CAD538", VA = "0x1CAD538")]
	public static OvrAvatarDriver.PoseFrame ReadPoseFrame(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x1CAD8DC", Offset = "0x1CAD8DC", VA = "0x1CAD8DC")]
	public static Vector2 ReadVector2(this BinaryReader reader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x1CAD6D8", Offset = "0x1CAD6D8", VA = "0x1CAD6D8")]
	public static Vector3 ReadVector3(this BinaryReader reader)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x1CAD750", Offset = "0x1CAD750", VA = "0x1CAD750")]
	public static Quaternion ReadQuaternion(this BinaryReader reader)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x1CAD7EC", Offset = "0x1CAD7EC", VA = "0x1CAD7EC")]
	public static OvrAvatarDriver.ControllerPose ReadControllerPose(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.ControllerPose);
	}
}
[Token(Token = "0x2000123")]
public class OvrAvatarRemoteDriver : OvrAvatarDriver
{
	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Queue<OvrAvatarPacket> packetQueue;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private IntPtr CurrentSDKPacket;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float CurrentPacketTime;

	[Token(Token = "0x4000663")]
	private const int MinPacketQueue = 1;

	[Token(Token = "0x4000664")]
	private const int MaxPacketQueue = 4;

	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int CurrentSequence;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isStreaming;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private OvrAvatarPacket currentPacket;

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0xFE602C", Offset = "0xFE602C", VA = "0xFE602C")]
	public void QueuePacket(int sequence, OvrAvatarPacket packet)
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0xFE60B4", Offset = "0xFE60B4", VA = "0xFE60B4", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0xFE60D0", Offset = "0xFE60D0", VA = "0xFE60D0")]
	private void UpdateFromSDKPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0xFE6274", Offset = "0xFE6274", VA = "0xFE6274")]
	private void UpdateFromUnityPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0xFE6464", Offset = "0xFE6464", VA = "0xFE6464")]
	public OvrAvatarRemoteDriver()
	{
	}
}
[Token(Token = "0x2000124")]
public class OvrAvatarRenderComponent : MonoBehaviour
{
	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool firstSkinnedUpdate;

	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SkinnedMeshRenderer mesh;

	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] bones;

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isBodyComponent;

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0xFE6500", Offset = "0xFE6500", VA = "0xFE6500")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0xFE65E4", Offset = "0xFE65E4", VA = "0xFE65E4")]
	protected SkinnedMeshRenderer CreateSkinnedMesh(ulong assetID, ovrAvatarVisibilityFlags visibilityMask, int thirdPersonLayer, int firstPersonLayer)
	{
		return null;
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0xFE6858", Offset = "0xFE6858", VA = "0xFE6858")]
	protected void UpdateSkinnedMesh(OvrAvatar avatar, Transform[] bones, ovrAvatarTransform localTransform, ovrAvatarVisibilityFlags visibilityMask, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0xFE6C18", Offset = "0xFE6C18", VA = "0xFE6C18")]
	protected Material CreateAvatarMaterial(string name, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0xFE6D24", Offset = "0xFE6D24", VA = "0xFE6D24")]
	public OvrAvatarRenderComponent()
	{
	}
}
[Token(Token = "0x2000125")]
[Flags]
public enum ovrAvatarCapabilities
{
	[Token(Token = "0x400066D")]
	Body = 1,
	[Token(Token = "0x400066E")]
	Hands = 2,
	[Token(Token = "0x400066F")]
	Base = 4,
	[Token(Token = "0x4000670")]
	BodyTilt = 0x10,
	[Token(Token = "0x4000671")]
	Expressive = 0x20,
	[Token(Token = "0x4000672")]
	All = -1
}
[Token(Token = "0x2000126")]
public enum ovrAvatarMessageType
{
	[Token(Token = "0x4000674")]
	AvatarSpecification,
	[Token(Token = "0x4000675")]
	AssetLoaded,
	[Token(Token = "0x4000676")]
	Count
}
[Token(Token = "0x2000127")]
public struct ovrAvatarMessage_AvatarSpecification
{
	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public IntPtr avatarSpec;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ulong oculusUserID;
}
[Token(Token = "0x2000128")]
public struct ovrAvatarMessage_AssetLoaded
{
	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ulong assetID;

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr asset;
}
[Token(Token = "0x2000129")]
public enum ovrAvatarAssetType
{
	[Token(Token = "0x400067C")]
	Mesh,
	[Token(Token = "0x400067D")]
	Texture,
	[Token(Token = "0x400067E")]
	Pose,
	[Token(Token = "0x400067F")]
	Material,
	[Token(Token = "0x4000680")]
	CombinedMesh,
	[Token(Token = "0x4000681")]
	PBSMaterial,
	[Token(Token = "0x4000682")]
	FailedLoad,
	[Token(Token = "0x4000683")]
	Count
}
[Token(Token = "0x200012A")]
public struct ovrAvatarMeshVertex
{
	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x400068B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public byte[] blendIndices;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] blendWeights;
}
[Token(Token = "0x200012B")]
public struct ovrAvatarMeshVertexV2
{
	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float r;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float g;

	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float b;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float a;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public byte[] blendIndices;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float[] blendWeights;
}
[Token(Token = "0x200012C")]
public struct ovrAvatarBlendVertex
{
	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;
}
[Token(Token = "0x200012D")]
public struct ovrAvatarMeshAssetData
{
	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x200012E")]
public struct ovrAvatarMeshAssetDataV2
{
	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x40006B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x200012F")]
public enum ovrAvatarTextureFormat
{
	[Token(Token = "0x40006B8")]
	RGB24,
	[Token(Token = "0x40006B9")]
	DXT1,
	[Token(Token = "0x40006BA")]
	DXT5,
	[Token(Token = "0x40006BB")]
	ASTC_RGB_6x6,
	[Token(Token = "0x40006BC")]
	ASTC_RGB_6x6_MIPMAPS,
	[Token(Token = "0x40006BD")]
	Count
}
[Token(Token = "0x2000130")]
public struct ovrAvatarTextureAssetData
{
	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTextureFormat format;

	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint sizeX;

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public uint sizeY;

	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public uint mipCount;

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong textureDataSize;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr textureData;
}
[Token(Token = "0x2000131")]
public enum ovrAvatarRenderPartType
{
	[Token(Token = "0x40006C5")]
	SkinnedMeshRender,
	[Token(Token = "0x40006C6")]
	SkinnedMeshRenderPBS,
	[Token(Token = "0x40006C7")]
	ProjectorRender,
	[Token(Token = "0x40006C8")]
	SkinnedMeshRenderPBS_V2,
	[Token(Token = "0x40006C9")]
	Count
}
[Token(Token = "0x2000132")]
public enum ovrAvatarLogLevel
{
	[Token(Token = "0x40006CB")]
	Unknown,
	[Token(Token = "0x40006CC")]
	Default,
	[Token(Token = "0x40006CD")]
	Verbose,
	[Token(Token = "0x40006CE")]
	Debug,
	[Token(Token = "0x40006CF")]
	Info,
	[Token(Token = "0x40006D0")]
	Warn,
	[Token(Token = "0x40006D1")]
	Error,
	[Token(Token = "0x40006D2")]
	Fatal,
	[Token(Token = "0x40006D3")]
	Silent
}
[Token(Token = "0x2000133")]
public struct ovrAvatarTransform
{
	[Token(Token = "0x40006D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Quaternion orientation;

	[Token(Token = "0x40006D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 scale;
}
[Token(Token = "0x2000134")]
[Flags]
public enum ovrAvatarButton
{
	[Token(Token = "0x40006D8")]
	One = 1,
	[Token(Token = "0x40006D9")]
	Two = 2,
	[Token(Token = "0x40006DA")]
	Three = 4,
	[Token(Token = "0x40006DB")]
	Joystick = 8
}
[Token(Token = "0x2000135")]
[Flags]
public enum ovrAvatarTouch
{
	[Token(Token = "0x40006DD")]
	One = 1,
	[Token(Token = "0x40006DE")]
	Two = 2,
	[Token(Token = "0x40006DF")]
	Joystick = 4,
	[Token(Token = "0x40006E0")]
	ThumbRest = 8,
	[Token(Token = "0x40006E1")]
	Index = 0x10,
	[Token(Token = "0x40006E2")]
	Pointing = 0x40,
	[Token(Token = "0x40006E3")]
	ThumbUp = 0x80
}
[Token(Token = "0x2000136")]
public struct ovrAvatarHandInputState
{
	[Token(Token = "0x40006E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40006E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarButton buttonMask;

	[Token(Token = "0x40006E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public ovrAvatarTouch touchMask;

	[Token(Token = "0x40006E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float joystickX;

	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float joystickY;

	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float indexTrigger;

	[Token(Token = "0x40006EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float handTrigger;

	[Token(Token = "0x40006EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isActive;
}
[Token(Token = "0x2000137")]
public struct ovrAvatarComponent
{
	[Token(Token = "0x40006EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40006ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint renderPartCount;

	[Token(Token = "0x40006EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr renderParts;

	[Token(Token = "0x40006EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string name;
}
[Token(Token = "0x2000138")]
internal struct ovrAvatarComponent_Offsets
{
	[Token(Token = "0x40006F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long transform;

	[Token(Token = "0x40006F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int renderPartCount;

	[Token(Token = "0x40006F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int renderParts;

	[Token(Token = "0x40006F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int name;
}
[Token(Token = "0x2000139")]
public struct ovrAvatarBaseComponent
{
	[Token(Token = "0x40006F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 basePosition;

	[Token(Token = "0x40006F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200013A")]
public struct ovrAvatarBodyComponent
{
	[Token(Token = "0x40006F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform leftEyeTransform;

	[Token(Token = "0x40006F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarTransform rightEyeTransform;

	[Token(Token = "0x40006F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ovrAvatarTransform centerEyeTransform;

	[Token(Token = "0x40006F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200013B")]
public struct ovrAvatarBodyComponent_Offsets
{
	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long leftEyeTransform;

	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long rightEyeTransform;

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long centerEyeTransform;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long renderComponent;
}
[Token(Token = "0x200013C")]
public struct ovrAvatarControllerComponent
{
	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200013D")]
public struct ovrAvatarHandComponent
{
	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200013E")]
public enum ovrAvatarMaterialLayerBlendMode
{
	[Token(Token = "0x4000703")]
	Add,
	[Token(Token = "0x4000704")]
	Multiply,
	[Token(Token = "0x4000705")]
	Count
}
[Token(Token = "0x200013F")]
public enum ovrAvatarMaterialLayerSampleMode
{
	[Token(Token = "0x4000707")]
	Color,
	[Token(Token = "0x4000708")]
	Texture,
	[Token(Token = "0x4000709")]
	TextureSingleChannel,
	[Token(Token = "0x400070A")]
	Parallax,
	[Token(Token = "0x400070B")]
	Count
}
[Token(Token = "0x2000140")]
public enum ovrAvatarMaterialMaskType
{
	[Token(Token = "0x400070D")]
	None,
	[Token(Token = "0x400070E")]
	Positional,
	[Token(Token = "0x400070F")]
	ViewReflection,
	[Token(Token = "0x4000710")]
	Fresnel,
	[Token(Token = "0x4000711")]
	Pulse,
	[Token(Token = "0x4000712")]
	Count
}
[Token(Token = "0x2000141")]
public enum ovrAvatarControllerType
{
	[Token(Token = "0x4000714")]
	Touch,
	[Token(Token = "0x4000715")]
	Malibu,
	[Token(Token = "0x4000716")]
	Go,
	[Token(Token = "0x4000717")]
	Quest,
	[Token(Token = "0x4000718")]
	Count
}
[Token(Token = "0x2000142")]
public enum ovrAvatarAssetLevelOfDetail
{
	[Token(Token = "0x400071A")]
	Lowest = 1,
	[Token(Token = "0x400071B")]
	Medium = 3,
	[Token(Token = "0x400071C")]
	Highest = 5
}
[Token(Token = "0x2000143")]
public enum ovrAvatarLookAndFeelVersion
{
	[Token(Token = "0x400071E")]
	Unknown = -1,
	[Token(Token = "0x400071F")]
	One,
	[Token(Token = "0x4000720")]
	Two
}
[Token(Token = "0x2000144")]
public struct ovrAvatarMaterialLayerState
{
	[Token(Token = "0x4000721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarMaterialLayerBlendMode blendMode;

	[Token(Token = "0x4000722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x4000723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarMaterialMaskType maskType;

	[Token(Token = "0x4000724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector4 layerColor;

	[Token(Token = "0x4000725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector4 sampleParameters;

	[Token(Token = "0x4000726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong sampleTexture;

	[Token(Token = "0x4000727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector4 sampleScaleOffset;

	[Token(Token = "0x4000728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector4 maskParameters;

	[Token(Token = "0x4000729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 maskAxis;

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x1DB5810", Offset = "0x1DB5810", VA = "0x1DB5810")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x1DB5840", Offset = "0x1DB5840", VA = "0x1DB5840", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x1DB5A5C", Offset = "0x1DB5A5C", VA = "0x1DB5A5C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000145")]
public struct ovrAvatarMaterialState
{
	[Token(Token = "0x400072A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x400072B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarMaterialMaskType baseMaskType;

	[Token(Token = "0x400072C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector4 baseMaskParameters;

	[Token(Token = "0x400072D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector4 baseMaskAxis;

	[Token(Token = "0x400072E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x400072F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong alphaMaskTextureID;

	[Token(Token = "0x4000730")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 alphaMaskScaleOffset;

	[Token(Token = "0x4000731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong normalMapTextureID;

	[Token(Token = "0x4000732")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 normalMapScaleOffset;

	[Token(Token = "0x4000733")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong parallaxMapTextureID;

	[Token(Token = "0x4000734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector4 parallaxMapScaleOffset;

	[Token(Token = "0x4000735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ulong roughnessMapTextureID;

	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector4 roughnessMapScaleOffset;

	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public uint layerCount;

	[Token(Token = "0x4000738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ovrAvatarMaterialLayerState[] layers;

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x1DB5B40", Offset = "0x1DB5B40", VA = "0x1DB5B40")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x1DB5B70", Offset = "0x1DB5B70", VA = "0x1DB5B70", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x1DB5F0C", Offset = "0x1DB5F0C", VA = "0x1DB5F0C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000146")]
public struct ovrAvatarExpressiveParameters
{
	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 irisColor;

	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector4 scleraColor;

	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector4 lashColor;

	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector4 browColor;

	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 lipColor;

	[Token(Token = "0x400073E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4 teethColor;

	[Token(Token = "0x400073F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector4 gumColor;

	[Token(Token = "0x4000740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float browLashIntensity;

	[Token(Token = "0x4000741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float lipSmoothness;

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x1DB4DA0", Offset = "0x1DB4DA0", VA = "0x1DB4DA0")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x1DB4DD0", Offset = "0x1DB4DD0", VA = "0x1DB4DD0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x1DB5060", Offset = "0x1DB5060", VA = "0x1DB5060", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000147")]
public struct ovrAvatarPBSMaterialState
{
	[Token(Token = "0x4000742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x4000743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong albedoTextureID;

	[Token(Token = "0x4000744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector4 albedoMultiplier;

	[Token(Token = "0x4000745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong metallicnessTextureID;

	[Token(Token = "0x4000746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float glossinessScale;

	[Token(Token = "0x4000747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong normalTextureID;

	[Token(Token = "0x4000748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong heightTextureID;

	[Token(Token = "0x4000749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ulong occlusionTextureID;

	[Token(Token = "0x400074A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong emissionTextureID;

	[Token(Token = "0x400074B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 emissionMultiplier;

	[Token(Token = "0x400074C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong detailMaskTextureID;

	[Token(Token = "0x400074D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ulong detailAlbedoTextureID;

	[Token(Token = "0x400074E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ulong detailNormalTextureID;

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x1DB6074", Offset = "0x1DB6074", VA = "0x1DB6074")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x1DB60A4", Offset = "0x1DB60A4", VA = "0x1DB60A4", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x1DB6294", Offset = "0x1DB6294", VA = "0x1DB6294", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000148")]
public class OvrAvatarAssetMaterial : OvrAvatarAsset
{
	[Token(Token = "0x400074F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarMaterialState material;

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x124BD7C", Offset = "0x124BD7C", VA = "0x124BD7C")]
	public OvrAvatarAssetMaterial(ulong id, IntPtr mat)
	{
	}
}
[Token(Token = "0x2000149")]
public struct ovrAvatarSkinnedMeshPose
{
	[Token(Token = "0x4000750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint jointCount;

	[Token(Token = "0x4000751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarTransform[] jointTransform;

	[Token(Token = "0x4000752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int[] jointParents;

	[Token(Token = "0x4000753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr[] jointNames;
}
[Token(Token = "0x200014A")]
[Flags]
public enum ovrAvatarVisibilityFlags
{
	[Token(Token = "0x4000755")]
	FirstPerson = 1,
	[Token(Token = "0x4000756")]
	ThirdPerson = 2,
	[Token(Token = "0x4000757")]
	SelfOccluding = 4
}
[Token(Token = "0x200014B")]
public struct ovrAvatarRenderPart_SkinnedMeshRender
{
	[Token(Token = "0x4000758")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000759")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x400075A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x400075B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarMaterialState materialState;

	[Token(Token = "0x400075C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x200014C")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS
{
	[Token(Token = "0x400075D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x400075E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x400075F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x4000760")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong albedoTextureAssetID;

	[Token(Token = "0x4000761")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong surfaceTextureAssetID;

	[Token(Token = "0x4000762")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x200014D")]
public struct ovrAvatarRenderPart_ProjectorRender
{
	[Token(Token = "0x4000763")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000764")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint componentIndex;

	[Token(Token = "0x4000765")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public uint renderPartIndex;

	[Token(Token = "0x4000766")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ovrAvatarMaterialState materialState;
}
[Token(Token = "0x200014E")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2
{
	[Token(Token = "0x4000767")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000768")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x4000769")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x400076A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarPBSMaterialState materialState;

	[Token(Token = "0x400076B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x200014F")]
public enum ovrAvatarHandGesture
{
	[Token(Token = "0x400076D")]
	Default,
	[Token(Token = "0x400076E")]
	GripSphere,
	[Token(Token = "0x400076F")]
	GripCube,
	[Token(Token = "0x4000770")]
	Count
}
[Token(Token = "0x2000150")]
public enum ovrAvatarBodyPartType
{
	[Token(Token = "0x4000772")]
	Body,
	[Token(Token = "0x4000773")]
	Clothing,
	[Token(Token = "0x4000774")]
	Eyewear,
	[Token(Token = "0x4000775")]
	Hair,
	[Token(Token = "0x4000776")]
	Beard,
	[Token(Token = "0x4000777")]
	Count
}
[Token(Token = "0x2000151")]
public struct ovrAvatarBlendShapeParams
{
	[Token(Token = "0x4000778")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint blendShapeParamCount;

	[Token(Token = "0x4000779")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] blendShapeParams;
}
[Token(Token = "0x2000152")]
internal struct ovrAvatarBlendShapeParams_Offsets
{
	[Token(Token = "0x400077A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int blendShapeParamCount;

	[Token(Token = "0x400077B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long blendShapeParams;
}
[Token(Token = "0x2000153")]
public struct ovrAvatarVisemes
{
	[Token(Token = "0x400077C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint visemeParamCount;

	[Token(Token = "0x400077D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] visemeParams;
}
[Token(Token = "0x2000154")]
internal struct ovrAvatarVisemes_Offsets
{
	[Token(Token = "0x400077E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int visemeParamCount;

	[Token(Token = "0x400077F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long visemeParams;
}
[Token(Token = "0x2000155")]
public enum ovrAvatarGazeTargetType
{
	[Token(Token = "0x4000781")]
	AvatarHead,
	[Token(Token = "0x4000782")]
	AvatarHand,
	[Token(Token = "0x4000783")]
	Object,
	[Token(Token = "0x4000784")]
	ObjectStatic,
	[Token(Token = "0x4000785")]
	Count
}
[Token(Token = "0x2000156")]
public struct ovrAvatarGazeTarget
{
	[Token(Token = "0x4000786")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x4000787")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 worldPosition;

	[Token(Token = "0x4000788")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarGazeTargetType type;
}
[Token(Token = "0x2000157")]
internal struct ovrAvatarGazeTarget_Offsets
{
	[Token(Token = "0x4000789")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int id;

	[Token(Token = "0x400078A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int worldPosition;

	[Token(Token = "0x400078B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int type;
}
[Token(Token = "0x2000158")]
public struct ovrAvatarGazeTargets
{
	[Token(Token = "0x400078C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint targetCount;

	[Token(Token = "0x400078D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarGazeTarget[] targets;
}
[Token(Token = "0x2000159")]
internal struct ovrAvatarGazeTargets_Offsets
{
	[Token(Token = "0x400078E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int targetCount;

	[Token(Token = "0x400078F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long targets;
}
[Token(Token = "0x200015A")]
public enum ovrAvatarLightType
{
	[Token(Token = "0x4000791")]
	Point,
	[Token(Token = "0x4000792")]
	Direction,
	[Token(Token = "0x4000793")]
	Spot,
	[Token(Token = "0x4000794")]
	Count
}
[Token(Token = "0x200015B")]
public struct ovrAvatarLight
{
	[Token(Token = "0x4000795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x4000796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarLightType type;

	[Token(Token = "0x4000797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float intensity;

	[Token(Token = "0x4000798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 worldDirection;

	[Token(Token = "0x4000799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 worldPosition;

	[Token(Token = "0x400079A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x400079B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float spotAngleDeg;
}
[Token(Token = "0x200015C")]
internal struct ovrAvatarLight_Offsets
{
	[Token(Token = "0x400079C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long id;

	[Token(Token = "0x400079D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long type;

	[Token(Token = "0x400079E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long intensity;

	[Token(Token = "0x400079F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long worldDirection;

	[Token(Token = "0x40007A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static long worldPosition;

	[Token(Token = "0x40007A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static long range;

	[Token(Token = "0x40007A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static long spotAngleDeg;
}
[Token(Token = "0x200015D")]
public struct ovrAvatarLights
{
	[Token(Token = "0x40007A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float ambientIntensity;

	[Token(Token = "0x40007A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint lightCount;

	[Token(Token = "0x40007A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarLight[] lights;
}
[Token(Token = "0x200015E")]
internal struct ovrAvatarLights_Offsets
{
	[Token(Token = "0x40007A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long ambientIntensity;

	[Token(Token = "0x40007A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long lightCount;

	[Token(Token = "0x40007A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long lights;
}
[Token(Token = "0x200015F")]
[Flags]
public enum ovrAvatarDebugContext : uint
{
	[Token(Token = "0x40007AA")]
	None = 0u,
	[Token(Token = "0x40007AB")]
	GazeTarget = 1u,
	[Token(Token = "0x40007AC")]
	Any = uint.MaxValue
}
[Token(Token = "0x2000160")]
public struct ovrAvatarDebugLine
{
	[Token(Token = "0x40007AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 startPoint;

	[Token(Token = "0x40007AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 endPoint;

	[Token(Token = "0x40007AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 color;

	[Token(Token = "0x40007B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x40007B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public IntPtr text;
}
[Token(Token = "0x2000161")]
public struct ovrAvatarDebugTransform
{
	[Token(Token = "0x40007B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40007B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x40007B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr text;
}
[Token(Token = "0x2000162")]
public delegate void specificationCallback(IntPtr specification);
[Token(Token = "0x2000163")]
public delegate void assetLoadedCallback(OvrAvatarAsset asset);
[Token(Token = "0x2000164")]
public delegate void combinedMeshLoadedCallback(IntPtr asset);
[Token(Token = "0x2000165")]
public class OvrAvatarSDKManager : MonoBehaviour
{
	[Token(Token = "0x2000166")]
	public struct AvatarSpecRequestParams
	{
		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong _userId;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public specificationCallback _callback;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool _useCombinedMesh;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ovrAvatarAssetLevelOfDetail _lod;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool _forceMobileTextureFormat;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ovrAvatarLookAndFeelVersion _lookVersion;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ovrAvatarLookAndFeelVersion _fallbackVersion;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool _enableExpressive;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x14C2C1C", Offset = "0x14C2C1C", VA = "0x14C2C1C")]
		public AvatarSpecRequestParams(ulong userId, specificationCallback callback, bool useCombinedMesh, ovrAvatarAssetLevelOfDetail lod, bool forceMobileTextureFormat, ovrAvatarLookAndFeelVersion lookVersion, ovrAvatarLookAndFeelVersion fallbackVersion, bool enableExpressive)
		{
		}
	}

	[Token(Token = "0x40007B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSDKManager _instance;

	[Token(Token = "0x40007B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initialized;

	[Token(Token = "0x40007B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, HashSet<specificationCallback>> specificationCallbacks;

	[Token(Token = "0x40007B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, HashSet<assetLoadedCallback>> assetLoadedCallbacks;

	[Token(Token = "0x40007B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<IntPtr, combinedMeshLoadedCallback> combinedMeshLoadedCallbacks;

	[Token(Token = "0x40007BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<ulong, OvrAvatarAsset> assetCache;

	[Token(Token = "0x40007BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OvrAvatarTextureCopyManager textureCopyManager;

	[Token(Token = "0x40007BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarLogLevel LoggingLevel;

	[Token(Token = "0x40007BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Queue<AvatarSpecRequestParams> avatarSpecificationQueue;

	[Token(Token = "0x40007BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> loadingAvatars;

	[Token(Token = "0x40007BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool avatarSpecRequestAvailable;

	[Token(Token = "0x40007C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float lastDispatchedAvatarSpecRequestTime;

	[Token(Token = "0x40007C1")]
	private const float AVATAR_SPEC_REQUEST_TIMEOUT = 5f;

	[Token(Token = "0x17000064")]
	public static OvrAvatarSDKManager Instance
	{
		[Token(Token = "0x6000520")]
		[Address(RVA = "0xFE3114", Offset = "0xFE3114", VA = "0xFE3114")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0xFE6D34", Offset = "0xFE6D34", VA = "0xFE6D34")]
	private bool Initialize()
	{
		return default(bool);
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0xFE7084", Offset = "0xFE7084", VA = "0xFE7084")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0xFE70F4", Offset = "0xFE70F4", VA = "0xFE70F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0xFE7AD4", Offset = "0xFE7AD4", VA = "0xFE7AD4")]
	public bool IsAvatarSpecWaiting()
	{
		return default(bool);
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0xFE7B28", Offset = "0xFE7B28", VA = "0xFE7B28")]
	public bool IsAvatarLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0xFE7B7C", Offset = "0xFE7B7C", VA = "0xFE7B7C")]
	public void AddLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0xFE7BE0", Offset = "0xFE7BE0", VA = "0xFE7BE0")]
	public void RemoveLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0xFE7C44", Offset = "0xFE7C44", VA = "0xFE7C44")]
	public void RequestAvatarSpecification(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0xFE78D4", Offset = "0xFE78D4", VA = "0xFE78D4")]
	private void DispatchAvatarSpecificationRequest(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0xFE7D20", Offset = "0xFE7D20", VA = "0xFE7D20")]
	public void BeginLoadingAsset(ulong assetId, ovrAvatarAssetLevelOfDetail lod, assetLoadedCallback callback)
	{
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0xFE7E74", Offset = "0xFE7E74", VA = "0xFE7E74")]
	public void RegisterCombinedMeshCallback(IntPtr sdkAvatar, combinedMeshLoadedCallback callback)
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0xFE67DC", Offset = "0xFE67DC", VA = "0xFE67DC")]
	public OvrAvatarAsset GetAsset(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0xFE7F68", Offset = "0xFE7F68", VA = "0xFE7F68")]
	public void DeleteAssetFromCache(ulong assetId)
	{
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0xFE7038", Offset = "0xFE7038", VA = "0xFE7038")]
	public string GetAppId()
	{
		return null;
	}

	[Token(Token = "0x600052F")]
	[Address(RVA = "0xFE330C", Offset = "0xFE330C", VA = "0xFE330C")]
	public OvrAvatarTextureCopyManager GetTextureCopyManager()
	{
		return null;
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0xFE8048", Offset = "0xFE8048", VA = "0xFE8048")]
	public OvrAvatarSDKManager()
	{
	}
}
[Token(Token = "0x2000167")]
public sealed class OvrAvatarSettings : ScriptableObject
{
	[Token(Token = "0x40007CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSettings instance;

	[Token(Token = "0x40007CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string ovrAppID;

	[Token(Token = "0x40007CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string ovrGearAppID;

	[Token(Token = "0x17000065")]
	public static string AppID
	{
		[Token(Token = "0x6000532")]
		[Address(RVA = "0xFE8008", Offset = "0xFE8008", VA = "0xFE8008")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000533")]
		[Address(RVA = "0xFE81B8", Offset = "0xFE81B8", VA = "0xFE81B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000066")]
	public static string MobileAppID
	{
		[Token(Token = "0x6000534")]
		[Address(RVA = "0xFE8028", Offset = "0xFE8028", VA = "0xFE8028")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000535")]
		[Address(RVA = "0xFE81E8", Offset = "0xFE81E8", VA = "0xFE81E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000067")]
	public static OvrAvatarSettings Instance
	{
		[Token(Token = "0x6000536")]
		[Address(RVA = "0xFE8060", Offset = "0xFE8060", VA = "0xFE8060")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000537")]
		[Address(RVA = "0xFE8218", Offset = "0xFE8218", VA = "0xFE8218")]
		set
		{
		}
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0xFE826C", Offset = "0xFE826C", VA = "0xFE826C")]
	public OvrAvatarSettings()
	{
	}
}
[Token(Token = "0x2000168")]
public class OvrAvatarSkinnedMeshRenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40007CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Shader surface;

	[Token(Token = "0x40007CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader surfaceSelfOccluding;

	[Token(Token = "0x40007CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool previouslyActive;

	[Token(Token = "0x6000539")]
	[Address(RVA = "0xFE9DB8", Offset = "0xFE9DB8", VA = "0xFE9DB8")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender, Shader surface, Shader surfaceSelfOccluding, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0xFEA0AC", Offset = "0xFEA0AC", VA = "0xFEA0AC")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0xFE9F44", Offset = "0xFE9F44", VA = "0xFE9F44")]
	private void UpdateMeshMaterial(ovrAvatarVisibilityFlags visibilityMask, SkinnedMeshRenderer rootMesh)
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0xFEA2EC", Offset = "0xFEA2EC", VA = "0xFEA2EC")]
	public OvrAvatarSkinnedMeshRenderComponent()
	{
	}
}
[Token(Token = "0x2000169")]
public class OvrAvatarSkinnedMeshRenderPBSComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40007D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isMaterialInitilized;

	[Token(Token = "0x600053D")]
	[Address(RVA = "0xFEA2FC", Offset = "0xFEA2FC", VA = "0xFEA2FC")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS, Shader shader, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0xFEA458", Offset = "0xFEA458", VA = "0xFEA458")]
	internal void UpdateSkinnedMeshRenderPBS(OvrAvatar avatar, IntPtr renderPart, Material mat)
	{
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0xFEA630", Offset = "0xFEA630", VA = "0xFEA630")]
	public OvrAvatarSkinnedMeshRenderPBSComponent()
	{
	}
}
[Token(Token = "0x200016A")]
public class OvrAvatarSkinnedMeshPBSV2RenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40007D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OvrAvatarMaterialManager avatarMaterialManager;

	[Token(Token = "0x40007D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool previouslyActive;

	[Token(Token = "0x40007D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool isCombinedMaterial;

	[Token(Token = "0x40007D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private ovrAvatarExpressiveParameters ExpressiveParameters;

	[Token(Token = "0x40007D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool EnableExpressive;

	[Token(Token = "0x40007D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int blendShapeCount;

	[Token(Token = "0x40007D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ovrAvatarBlendShapeParams blendShapeParams;

	[Token(Token = "0x40007D8")]
	private const string MAIN_MATERIAL_NAME = "main_material";

	[Token(Token = "0x40007D9")]
	private const string EYE_MATERIAL_NAME = "eye_material";

	[Token(Token = "0x40007DA")]
	private const string DEFAULT_MATERIAL_NAME = "_material";

	[Token(Token = "0x6000540")]
	[Address(RVA = "0xFE82D8", Offset = "0xFE82D8", VA = "0xFE82D8")]
	internal void Initialize(IntPtr renderPart, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRender, OvrAvatarMaterialManager materialManager, int thirdPersonLayer, int firstPersonLayer, bool combinedMesh, ovrAvatarAssetLevelOfDetail lod, bool assignExpressiveParams, OvrAvatar avatar, bool isControllerModel)
	{
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0xFE92F4", Offset = "0xFE92F4", VA = "0xFE92F4")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0xFE9530", Offset = "0xFE9530", VA = "0xFE9530")]
	private void InitializeSingleComponentMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0xFE8A08", Offset = "0xFE8A08", VA = "0xFE8A08")]
	private void InitializeCombinedMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0xFE872C", Offset = "0xFE872C", VA = "0xFE872C")]
	private void SetMaterialTransparent(Material mat)
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0xFE8890", Offset = "0xFE8890", VA = "0xFE8890")]
	private void SetMaterialOpaque(Material mat)
	{
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0xFE9DA8", Offset = "0xFE9DA8", VA = "0xFE9DA8")]
	public OvrAvatarSkinnedMeshPBSV2RenderComponent()
	{
	}
}
[Token(Token = "0x200016B")]
public class OvrAvatarTextureCopyManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200016C")]
	public struct FallbackTextureSet
	{
		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool Initialized;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D DiffuseRoughness;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D Normal;
	}

	[Token(Token = "0x200016D")]
	private struct CopyTextureParams
	{
		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture Src;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture Dst;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Mip;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int SrcSize;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int DstElement;

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x14C3318", Offset = "0x14C3318", VA = "0x14C3318")]
		public CopyTextureParams(Texture src, Texture dst, int mip, int srcSize, int dstElement)
		{
		}
	}

	[Token(Token = "0x200016E")]
	public struct TextureSet
	{
		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<ulong, bool> TextureIDSingleMeshPair;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool IsProcessed;

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x14C3374", Offset = "0x14C3374", VA = "0x14C3374")]
		public TextureSet(Dictionary<ulong, bool> textureIDSingleMeshPair, bool isProcessed)
		{
		}
	}

	[Token(Token = "0x200016F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF54C", Offset = "0x9FF54C")]
	private sealed class <DeleteTextureSetCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextureSet textureSetToDelete;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OvrAvatarTextureCopyManager <>4__this;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int gameobjectID;

		[Token(Token = "0x17000068")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x14C32C8", Offset = "0x14C32C8", VA = "0x14C32C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x14C3310", Offset = "0x14C3310", VA = "0x14C3310", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x14C2C98", Offset = "0x14C2C98", VA = "0x14C2C98")]
		[DebuggerHidden]
		public <DeleteTextureSetCoroutine>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x14C2CC4", Offset = "0x14C2CC4", VA = "0x14C2CC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x14C2CC8", Offset = "0x14C2CC8", VA = "0x14C2CC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x14C32D0", Offset = "0x14C32D0", VA = "0x14C32D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FallbackTextureSet[] FallbackTextureSets;

	[Token(Token = "0x40007DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Queue<CopyTextureParams> texturesToCopy;

	[Token(Token = "0x40007DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, TextureSet> textureSets;

	[Token(Token = "0x40007DE")]
	private const int TEXTURES_TO_COPY_QUEUE_CAPACITY = 256;

	[Token(Token = "0x40007DF")]
	private const int COPIES_PER_FRAME = 8;

	[Token(Token = "0x40007E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_DIFFUSE_ROUGHNESS;

	[Token(Token = "0x40007E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_NORMAL;

	[Token(Token = "0x40007E2")]
	private const string PATH_HIGHEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_2048";

	[Token(Token = "0x40007E3")]
	private const string PATH_MEDIUM_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_1024";

	[Token(Token = "0x40007E4")]
	private const string PATH_LOWEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_256";

	[Token(Token = "0x40007E5")]
	private const string PATH_HIGHEST_NORMAL = "FallbackTextures/fallback_normal_2048";

	[Token(Token = "0x40007E6")]
	private const string PATH_MEDIUM_NORMAL = "FallbackTextures/fallback_normal_1024";

	[Token(Token = "0x40007E7")]
	private const string PATH_LOWEST_NORMAL = "FallbackTextures/fallback_normal_256";

	[Token(Token = "0x40007E8")]
	private const int GPU_TEXTURE_COPY_WAIT_TIME = 10;

	[Token(Token = "0x6000547")]
	[Address(RVA = "0xFEAD58", Offset = "0xFEAD58", VA = "0xFEAD58")]
	public OvrAvatarTextureCopyManager()
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0xFEB238", Offset = "0xFEB238", VA = "0xFEB238")]
	public void Update()
	{
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0xFEB438", Offset = "0xFEB438", VA = "0xFEB438")]
	public int GetTextureCount()
	{
		return default(int);
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0xFE3764", Offset = "0xFE3764", VA = "0xFE3764")]
	public void CopyTexture(Texture src, Texture dst, int mipLevel, int mipSize, int dstElement, bool useQueue = true)
	{
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0xFEB3AC", Offset = "0xFEB3AC", VA = "0xFEB3AC")]
	private void CopyTexture(CopyTextureParams copyTextureParams)
	{
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0xFE338C", Offset = "0xFE338C", VA = "0xFE338C")]
	public void AddTextureIDToTextureSet(int gameobjectID, ulong textureID, bool isSingleMesh)
	{
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0xFE35DC", Offset = "0xFE35DC", VA = "0xFE35DC")]
	public void DeleteTextureSet(int gameobjectID)
	{
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0xFEB484", Offset = "0xFEB484", VA = "0xFEB484")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06894", Offset = "0xA06894")]
	private IEnumerator DeleteTextureSetCoroutine(TextureSet textureSetToDelete, int gameobjectID)
	{
		return null;
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0xFE7CD4", Offset = "0xFE7CD4", VA = "0xFE7CD4")]
	public void CheckFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0xFEB530", Offset = "0xFEB530", VA = "0xFEB530")]
	private void InitFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}
}
[Token(Token = "0x2000170")]
public class OvrAvatarTouchController : OvrAvatarComponent
{
	[Token(Token = "0x40007F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarControllerComponent component;

	[Token(Token = "0x6000559")]
	[Address(RVA = "0xFEB6A8", Offset = "0xFEB6A8", VA = "0xFEB6A8")]
	private void Update()
	{
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0xFEB81C", Offset = "0xFEB81C", VA = "0xFEB81C")]
	public OvrAvatarTouchController()
	{
	}
}
[Token(Token = "0x2000171")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x2000172")]
	public delegate void OnClick();

	[Token(Token = "0x2000173")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x2000174")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x2000175")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x2000176")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF55C", Offset = "0x9FF55C")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnClick handler;

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1DB9D9C", Offset = "0x1DB9D9C", VA = "0x1DB9D9C")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1DB9DA4", Offset = "0x1DB9DA4", VA = "0x1DB9DA4")]
		internal void <AddButton>b__0()
		{
		}
	}

	[Token(Token = "0x2000177")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF56C", Offset = "0x9FF56C")]
	private sealed class <>c__DisplayClass43_0
	{
		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnSlider onValueChanged;

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1DB9FC8", Offset = "0x1DB9FC8", VA = "0x1DB9FC8")]
		public <>c__DisplayClass43_0()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1DB9FD0", Offset = "0x1DB9FD0", VA = "0x1DB9FD0")]
		internal void <AddSlider>b__0(float f)
		{
		}
	}

	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF57C", Offset = "0x9FF57C")]
	private sealed class <>c__DisplayClass45_0
	{
		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1DBA21C", Offset = "0x1DBA21C", VA = "0x1DBA21C")]
		public <>c__DisplayClass45_0()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1DBA224", Offset = "0x1DBA224", VA = "0x1DBA224")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x2000179")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF58C", Offset = "0x9FF58C")]
	private sealed class <>c__DisplayClass46_0
	{
		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1DBA5B8", Offset = "0x1DBA5B8", VA = "0x1DBA5B8")]
		public <>c__DisplayClass46_0()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1DBA5C0", Offset = "0x1DBA5C0", VA = "0x1DBA5C0")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x200017A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF59C", Offset = "0x9FF59C")]
	private sealed class <>c__DisplayClass47_0
	{
		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange handler;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle tb;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1DBA5E0", Offset = "0x1DBA5E0", VA = "0x1DBA5E0")]
		public <>c__DisplayClass47_0()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1DBA5E8", Offset = "0x1DBA5E8", VA = "0x1DBA5E8")]
		internal void <AddRadio>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x40007FA")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x40007FB")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x40007FC")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x4000801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x4000807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x4000809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x400080A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x400080B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float elementSpacing;

	[Token(Token = "0x400080C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float marginH;

	[Token(Token = "0x400080D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float marginV;

	[Token(Token = "0x400080E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2[] insertPositions;

	[Token(Token = "0x400080F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x4000810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 menuOffset;

	[Token(Token = "0x4000811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private OVRCameraRig rig;

	[Token(Token = "0x4000812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x4000813")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private LaserPointer lp;

	[Token(Token = "0x4000814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private LineRenderer lr;

	[Token(Token = "0x4000815")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x4000816")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool isHorizontal;

	[Token(Token = "0x4000817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool usePanelCentricRelayout;

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x1D17C34", Offset = "0x1D17C34", VA = "0x1D17C34")]
	public void Awake()
	{
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x1D18168", Offset = "0x1D18168", VA = "0x1D18168")]
	public void Show()
	{
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x1D18530", Offset = "0x1D18530", VA = "0x1D18530")]
	public void Hide()
	{
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x1D186EC", Offset = "0x1D186EC", VA = "0x1D186EC")]
	private void StackedRelayout()
	{
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x1D1892C", Offset = "0x1D1892C", VA = "0x1D1892C")]
	private void PanelCentricRelayout()
	{
	}

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x1D18520", Offset = "0x1D18520", VA = "0x1D18520")]
	private void Relayout()
	{
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x1D18C5C", Offset = "0x1D18C5C", VA = "0x1D18C5C")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x1D18F7C", Offset = "0x1D18F7C", VA = "0x1D18F7C")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x1D19344", Offset = "0x1D19344", VA = "0x1D19344")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x1D19448", Offset = "0x1D19448", VA = "0x1D19448")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x1D1962C", Offset = "0x1D1962C", VA = "0x1D1962C")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x1D196D0", Offset = "0x1D196D0", VA = "0x1D196D0")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x1D198C0", Offset = "0x1D198C0", VA = "0x1D198C0")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x1D19AC8", Offset = "0x1D19AC8", VA = "0x1D19AC8")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000569")]
	[Address(RVA = "0x1D19DCC", Offset = "0x1D19DCC", VA = "0x1D19DCC")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0x1D19EC8", Offset = "0x1D19EC8", VA = "0x1D19EC8")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x1D19F74", Offset = "0x1D19F74", VA = "0x1D19F74")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x200017B")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x4000820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x4000821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x1E63FB8", Offset = "0x1E63FB8", VA = "0x1E63FB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x1E64068", Offset = "0x1E64068", VA = "0x1E64068")]
	private void Update()
	{
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x1E64128", Offset = "0x1E64128", VA = "0x1E64128")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x1E64164", Offset = "0x1E64164", VA = "0x1E64164")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x200017C")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x200017D")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x400082C")]
		On,
		[Token(Token = "0x400082D")]
		Off,
		[Token(Token = "0x400082E")]
		OnWhenHitTarget
	}

	[Token(Token = "0x4000822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x4000823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x4000824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x4000825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x4000826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x4000827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000829")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x400082A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x1700006A")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1E6A86C", Offset = "0x1E6A86C", VA = "0x1E6A86C")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1E6A828", Offset = "0x1E6A828", VA = "0x1E6A828")]
		set
		{
		}
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x1E6A874", Offset = "0x1E6A874", VA = "0x1E6A874")]
	private void Awake()
	{
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x1E6A8D0", Offset = "0x1E6A8D0", VA = "0x1E6A8D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x1E6AA14", Offset = "0x1E6AA14", VA = "0x1E6AA14", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x1E6AA30", Offset = "0x1E6AA30", VA = "0x1E6AA30", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x1E6AA84", Offset = "0x1E6AA84", VA = "0x1E6AA84")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x1E6AC40", Offset = "0x1E6AC40", VA = "0x1E6AC40")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x1E6AD54", Offset = "0x1E6AD54", VA = "0x1E6AD54")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x1E6ADE4", Offset = "0x1E6ADE4", VA = "0x1E6ADE4")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x1E6AEB0", Offset = "0x1E6AEB0", VA = "0x1E6AEB0")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x1E6AF64", Offset = "0x1E6AF64", VA = "0x1E6AF64")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x1E6B050", Offset = "0x1E6B050", VA = "0x1E6B050")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x200017E")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x400082F")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x4000830")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x4000831")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x4000832")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA01FD4", Offset = "0xA01FD4")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000833")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0200C", Offset = "0xA0200C")]
	public LayerMask CollideLayers;

	[Token(Token = "0x4000834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02044", Offset = "0xA02044")]
	public float HeightOffset;

	[Token(Token = "0x4000835")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0207C", Offset = "0xA0207C")]
	public float MinimumHeight;

	[Token(Token = "0x4000836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA020B4", Offset = "0xA020B4")]
	public float MaximumHeight;

	[Token(Token = "0x4000837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x4000838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x1CB9974", Offset = "0x1CB9974", VA = "0x1CB9974")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x1CB997C", Offset = "0x1CB997C", VA = "0x1CB997C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x1CB9A08", Offset = "0x1CB9A08", VA = "0x1CB9A08")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x1CB9A9C", Offset = "0x1CB9A9C", VA = "0x1CB9A9C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x1CB9B30", Offset = "0x1CB9B30", VA = "0x1CB9B30")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x1CB9E5C", Offset = "0x1CB9E5C", VA = "0x1CB9E5C")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x1CBA08C", Offset = "0x1CBA08C", VA = "0x1CBA08C")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x200017F")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x4000839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400083A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x400083B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x1E6C320", Offset = "0x1E6C320", VA = "0x1E6C320")]
	private void Start()
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x1E6C3EC", Offset = "0x1E6C3EC", VA = "0x1E6C3EC")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x2000180")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x2000181")]
	public enum States
	{
		[Token(Token = "0x400085F")]
		Ready,
		[Token(Token = "0x4000860")]
		Aim,
		[Token(Token = "0x4000861")]
		CancelAim,
		[Token(Token = "0x4000862")]
		PreTeleport,
		[Token(Token = "0x4000863")]
		CancelTeleport,
		[Token(Token = "0x4000864")]
		Teleporting,
		[Token(Token = "0x4000865")]
		PostTeleport
	}

	[Token(Token = "0x2000182")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x4000867")]
		None,
		[Token(Token = "0x4000868")]
		Aim,
		[Token(Token = "0x4000869")]
		PreTeleport,
		[Token(Token = "0x400086A")]
		Teleport
	}

	[Token(Token = "0x2000183")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x400086C")]
		Point,
		[Token(Token = "0x400086D")]
		Sphere,
		[Token(Token = "0x400086E")]
		Capsule
	}

	[Token(Token = "0x2000184")]
	public class AimData
	{
		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA024CC", Offset = "0xA024CC")]
		private List<Vector3> <Points>k__BackingField;

		[Token(Token = "0x1700006E")]
		public List<Vector3> Points
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x14C0D1C", Offset = "0x14C0D1C", VA = "0x14C0D1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06DBC", Offset = "0xA06DBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x14C0D24", Offset = "0x14C0D24", VA = "0x14C0D24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06DCC", Offset = "0xA06DCC")]
			private set
			{
			}
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x14C0C98", Offset = "0x14C0C98", VA = "0x14C0C98")]
		public AimData()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x14C0D2C", Offset = "0x14C0D2C", VA = "0x14C0D2C")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000185")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF5AC", Offset = "0x9FF5AC")]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700006F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x14C0AE4", Offset = "0x14C0AE4", VA = "0x14C0AE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x14C0B2C", Offset = "0x14C0B2C", VA = "0x14C0B2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x14C09A8", Offset = "0x14C09A8", VA = "0x14C09A8")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x14C09D4", Offset = "0x14C09D4", VA = "0x14C09D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x14C09D8", Offset = "0x14C09D8", VA = "0x14C09D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x14C0AEC", Offset = "0x14C0AEC", VA = "0x14C0AEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000186")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF5BC", Offset = "0x9FF5BC")]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000071")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x14C0414", Offset = "0x14C0414", VA = "0x14C0414", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x14C045C", Offset = "0x14C045C", VA = "0x14C045C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x14C028C", Offset = "0x14C028C", VA = "0x14C028C")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x14C02B8", Offset = "0x14C02B8", VA = "0x14C02B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x14C02BC", Offset = "0x14C02BC", VA = "0x14C02BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x14C041C", Offset = "0x14C041C", VA = "0x14C041C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000187")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF5CC", Offset = "0x9FF5CC")]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000073")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x14C0540", Offset = "0x14C0540", VA = "0x14C0540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x14C0588", Offset = "0x14C0588", VA = "0x14C0588", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x14C0464", Offset = "0x14C0464", VA = "0x14C0464")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x14C0490", Offset = "0x14C0490", VA = "0x14C0490", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x14C0494", Offset = "0x14C0494", VA = "0x14C0494", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x14C0548", Offset = "0x14C0548", VA = "0x14C0548", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000188")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF5DC", Offset = "0x9FF5DC")]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000075")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x14C0958", Offset = "0x14C0958", VA = "0x14C0958", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x14C09A0", Offset = "0x14C09A0", VA = "0x14C09A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x14C083C", Offset = "0x14C083C", VA = "0x14C083C")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x14C0868", Offset = "0x14C0868", VA = "0x14C0868", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x14C086C", Offset = "0x14C086C", VA = "0x14C086C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x14C0960", Offset = "0x14C0960", VA = "0x14C0960", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000189")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF5EC", Offset = "0x9FF5EC")]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000077")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x14C066C", Offset = "0x14C066C", VA = "0x14C066C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x14C06B4", Offset = "0x14C06B4", VA = "0x14C06B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x14C0590", Offset = "0x14C0590", VA = "0x14C0590")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x14C05BC", Offset = "0x14C05BC", VA = "0x14C05BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x14C05C0", Offset = "0x14C05C0", VA = "0x14C05C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x14C0674", Offset = "0x14C0674", VA = "0x14C0674", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200018A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF5FC", Offset = "0x9FF5FC")]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000079")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x14C0C48", Offset = "0x14C0C48", VA = "0x14C0C48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x14C0C90", Offset = "0x14C0C90", VA = "0x14C0C90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x14C0B34", Offset = "0x14C0B34", VA = "0x14C0B34")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x14C0B60", Offset = "0x14C0B60", VA = "0x14C0B60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x14C0B64", Offset = "0x14C0B64", VA = "0x14C0B64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x14C0C50", Offset = "0x14C0C50", VA = "0x14C0C50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200018B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF60C", Offset = "0x9FF60C")]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700007B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x14C07EC", Offset = "0x14C07EC", VA = "0x14C07EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x14C0834", Offset = "0x14C0834", VA = "0x14C0834", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x14C06BC", Offset = "0x14C06BC", VA = "0x14C06BC")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x14C06E8", Offset = "0x14C06E8", VA = "0x14C06E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x14C06EC", Offset = "0x14C06EC", VA = "0x14C06EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x14C07F4", Offset = "0x14C07F4", VA = "0x14C07F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400083C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA020EC", Offset = "0xA020EC")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x400083D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02124", Offset = "0xA02124")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x400083E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0215C", Offset = "0xA0215C")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x400083F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02194", Offset = "0xA02194")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x4000840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA021CC", Offset = "0xA021CC")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x4000841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02204", Offset = "0xA02204")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x4000842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0223C", Offset = "0xA0223C")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x4000843")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02274", Offset = "0xA02274")]
	public bool EnableRotationDuringPostTeleport;

	[Token(Token = "0x4000844")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA022AC", Offset = "0xA022AC")]
	private States <CurrentState>k__BackingField;

	[NonSerialized]
	[Token(Token = "0x4000845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x4000846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA022BC", Offset = "0xA022BC")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x4000847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA022F4", Offset = "0xA022F4")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x4000849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x400084A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x400084B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x400084C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x400084D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x400084E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x400084F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0233C", Offset = "0xA0233C")]
	private LocomotionController <LocomotionController>k__BackingField;

	[Token(Token = "0x4000850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0234C", Offset = "0xA0234C")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x4000851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02384", Offset = "0xA02384")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x4000852")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA023BC", Offset = "0xA023BC")]
	public float AimCollisionRadius;

	[Token(Token = "0x4000853")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA023F4", Offset = "0xA023F4")]
	public float AimCollisionHeight;

	[Token(Token = "0x1700006B")]
	public States CurrentState
	{
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1E6CEE8", Offset = "0x1E6CEE8", VA = "0x1E6CEE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06944", Offset = "0xA06944")]
		get
		{
			return default(States);
		}
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1E6CEF0", Offset = "0x1E6CEF0", VA = "0x1E6CEF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06954", Offset = "0xA06954")]
		private set
		{
		}
	}

	[Token(Token = "0x1700006C")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1E6D114", Offset = "0x1E6D114", VA = "0x1E6D114")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x1700006D")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1E6D13C", Offset = "0x1E6D13C", VA = "0x1E6D13C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06984", Offset = "0xA06984")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1E6D144", Offset = "0x1E6D144", VA = "0x1E6D144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06994", Offset = "0xA06994")]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1E6CEF8", Offset = "0x1E6CEF8", VA = "0x1E6CEF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06964", Offset = "0xA06964")]
		add
		{
		}
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1E6CF98", Offset = "0x1E6CF98", VA = "0x1E6CF98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06974", Offset = "0xA06974")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1E6D784", Offset = "0x1E6D784", VA = "0x1E6D784")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA069DC", Offset = "0xA069DC")]
		add
		{
		}
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1E6D824", Offset = "0x1E6D824", VA = "0x1E6D824")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA069EC", Offset = "0xA069EC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1E6D8C4", Offset = "0x1E6D8C4", VA = "0x1E6D8C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06A5C", Offset = "0xA06A5C")]
		add
		{
		}
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1E6D964", Offset = "0x1E6D964", VA = "0x1E6D964")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06A6C", Offset = "0xA06A6C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1E6DA04", Offset = "0x1E6DA04", VA = "0x1E6DA04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06A7C", Offset = "0xA06A7C")]
		add
		{
		}
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1E6DAA4", Offset = "0x1E6DAA4", VA = "0x1E6DAA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06A8C", Offset = "0xA06A8C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1E6DBB4", Offset = "0x1E6DBB4", VA = "0x1E6DBB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06A9C", Offset = "0xA06A9C")]
		add
		{
		}
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1E6DC54", Offset = "0x1E6DC54", VA = "0x1E6DC54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06AAC", Offset = "0xA06AAC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1E6DD6C", Offset = "0x1E6DD6C", VA = "0x1E6DD6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06B1C", Offset = "0xA06B1C")]
		add
		{
		}
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1E6DE0C", Offset = "0x1E6DE0C", VA = "0x1E6DE0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06B2C", Offset = "0xA06B2C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1E6DF24", Offset = "0x1E6DF24", VA = "0x1E6DF24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06B9C", Offset = "0xA06B9C")]
		add
		{
		}
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1E6DFC4", Offset = "0x1E6DFC4", VA = "0x1E6DFC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06BAC", Offset = "0xA06BAC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1E6E0DC", Offset = "0x1E6E0DC", VA = "0x1E6E0DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06C1C", Offset = "0xA06C1C")]
		add
		{
		}
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1E6E17C", Offset = "0x1E6E17C", VA = "0x1E6E17C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06C2C", Offset = "0xA06C2C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1E6E294", Offset = "0x1E6E294", VA = "0x1E6E294")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06C9C", Offset = "0xA06C9C")]
		add
		{
		}
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1E6E334", Offset = "0x1E6E334", VA = "0x1E6E334")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06CAC", Offset = "0xA06CAC")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1E6E44C", Offset = "0x1E6E44C", VA = "0x1E6E44C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06D1C", Offset = "0xA06D1C")]
		add
		{
		}
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1E6E4EC", Offset = "0x1E6E4EC", VA = "0x1E6E4EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06D2C", Offset = "0xA06D2C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1E6E604", Offset = "0x1E6E604", VA = "0x1E6E604")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06D9C", Offset = "0xA06D9C")]
		add
		{
		}
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1E6E6A4", Offset = "0x1E6E6A4", VA = "0x1E6E6A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA06DAC", Offset = "0xA06DAC")]
		remove
		{
		}
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x1E6CB94", Offset = "0x1E6CB94", VA = "0x1E6CB94")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x1E6CBB8", Offset = "0x1E6CBB8", VA = "0x1E6CBB8")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x1E6D038", Offset = "0x1E6D038", VA = "0x1E6D038")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x1E6D14C", Offset = "0x1E6D14C", VA = "0x1E6D14C")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x1E6D398", Offset = "0x1E6D398", VA = "0x1E6D398")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA069A4", Offset = "0xA069A4")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x1E6D44C", Offset = "0x1E6D44C", VA = "0x1E6D44C")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x1E6D54C", Offset = "0x1E6D54C", VA = "0x1E6D54C")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x1E6D568", Offset = "0x1E6D568", VA = "0x1E6D568")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x1E6D62C", Offset = "0x1E6D62C", VA = "0x1E6D62C")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x1E6D670", Offset = "0x1E6D670", VA = "0x1E6D670")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x1E6D6D4", Offset = "0x1E6D6D4", VA = "0x1E6D6D4", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x1E6D77C", Offset = "0x1E6D77C", VA = "0x1E6D77C", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x1E6D704", Offset = "0x1E6D704", VA = "0x1E6D704")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA069FC", Offset = "0xA069FC")]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x1E6DB44", Offset = "0x1E6DB44", VA = "0x1E6DB44")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x1E6DCF4", Offset = "0x1E6DCF4", VA = "0x1E6DCF4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06ABC", Offset = "0xA06ABC")]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x1E6DEAC", Offset = "0x1E6DEAC", VA = "0x1E6DEAC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06B3C", Offset = "0xA06B3C")]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x1E6E064", Offset = "0x1E6E064", VA = "0x1E6E064")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06BBC", Offset = "0xA06BBC")]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x1E6E21C", Offset = "0x1E6E21C", VA = "0x1E6E21C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06C3C", Offset = "0xA06C3C")]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x1E6E3D4", Offset = "0x1E6E3D4", VA = "0x1E6E3D4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06CBC", Offset = "0xA06CBC")]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x1E6E58C", Offset = "0x1E6E58C", VA = "0x1E6E58C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA06D3C", Offset = "0xA06D3C")]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x1E6E744", Offset = "0x1E6E744", VA = "0x1E6E744")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x1E6E884", Offset = "0x1E6E884", VA = "0x1E6E884")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x1E6E8B8", Offset = "0x1E6E8B8", VA = "0x1E6E8B8")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x1E6E980", Offset = "0x1E6E980", VA = "0x1E6E980")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x1E6EA78", Offset = "0x1E6EA78", VA = "0x1E6EA78")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x200018C")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x4000889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x400088A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x400088B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x400088C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x400088D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x400088E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x400088F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x4000891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000C")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x6000602")]
		[Address(RVA = "0xE30EC8", Offset = "0xE30EC8", VA = "0xE30EC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0700C", Offset = "0xA0700C")]
		add
		{
		}
		[Token(Token = "0x6000603")]
		[Address(RVA = "0xE30F68", Offset = "0xE30F68", VA = "0xE30F68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0701C", Offset = "0xA0701C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x6000604")]
		[Address(RVA = "0xE31008", Offset = "0xE31008", VA = "0xE31008")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0702C", Offset = "0xA0702C")]
		add
		{
		}
		[Token(Token = "0x6000605")]
		[Address(RVA = "0xE310A8", Offset = "0xE310A8", VA = "0xE310A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0703C", Offset = "0xA0703C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0xE31148", Offset = "0xE31148", VA = "0xE31148")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000607")]
	[Address(RVA = "0xE31234", Offset = "0xE31234", VA = "0xE31234")]
	private void Start()
	{
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0xE31238", Offset = "0xE31238", VA = "0xE31238")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0xE312AC", Offset = "0xE312AC", VA = "0xE312AC")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0xE313D0", Offset = "0xE313D0", VA = "0xE313D0")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x600060B")]
	[Address(RVA = "0xE315B8", Offset = "0xE315B8", VA = "0xE315B8")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x600060C")]
	[Address(RVA = "0xE317C0", Offset = "0xE317C0", VA = "0xE317C0")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x200018D")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x600060D")]
	[Address(RVA = "0xE3BA48", Offset = "0xE3BA48", VA = "0xE3BA48", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0xE3BAE8", Offset = "0xE3BAE8", VA = "0xE3BAE8", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600060F")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x6000610")]
	[Address(RVA = "0xE3BBD8", Offset = "0xE3BBD8", VA = "0xE3BBD8")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x200018E")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x4000894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA024FC", Offset = "0xA024FC")]
	public float Range;

	[Token(Token = "0x6000611")]
	[Address(RVA = "0xE3BBE8", Offset = "0xE3BBE8", VA = "0xE3BBE8", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0xE3BCE4", Offset = "0xE3BCE4", VA = "0xE3BCE4")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x200018F")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x4000895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02534", Offset = "0xA02534")]
	public float Range;

	[Token(Token = "0x4000896")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0256C", Offset = "0xA0256C")]
	public float MinimumElevation;

	[Token(Token = "0x4000897")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA025A4", Offset = "0xA025A4")]
	public float Gravity;

	[Token(Token = "0x4000898")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA025DC", Offset = "0xA025DC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA025DC", Offset = "0xA025DC")]
	public float AimVelocity;

	[Token(Token = "0x4000899")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA02638", Offset = "0xA02638")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02638", Offset = "0xA02638")]
	public float AimStep;

	[Token(Token = "0x6000613")]
	[Address(RVA = "0xE3BCF4", Offset = "0xE3BCF4", VA = "0xE3BCF4", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0xE3BE84", Offset = "0xE3BE84", VA = "0xE3BE84")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x2000190")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x400089A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02690", Offset = "0xA02690")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x400089B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x400089C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x400089D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x400089E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x400089F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x6000615")]
	[Address(RVA = "0xE3BE98", Offset = "0xE3BE98", VA = "0xE3BE98")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0xE3BFD4", Offset = "0xE3BFD4", VA = "0xE3BFD4")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0xE3C004", Offset = "0xE3C004", VA = "0xE3C004")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0xE3C034", Offset = "0xE3C034", VA = "0xE3C034")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0xE3C0E4", Offset = "0xE3C0E4", VA = "0xE3C0E4", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0xE3C150", Offset = "0xE3C150", VA = "0xE3C150", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0xE3C1B8", Offset = "0xE3C1B8", VA = "0xE3C1B8")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x2000191")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x40008A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA026C8", Offset = "0xA026C8")]
	private bool <IsValidDestination>k__BackingField;

	[Token(Token = "0x40008A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA026D8", Offset = "0xA026D8")]
	public Transform PositionIndicator;

	[Token(Token = "0x40008A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02710", Offset = "0xA02710")]
	public Transform OrientationIndicator;

	[Token(Token = "0x40008A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02748", Offset = "0xA02748")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x40008A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x40008A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x40008A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x40008A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x1700007D")]
	public bool IsValidDestination
	{
		[Token(Token = "0x600061C")]
		[Address(RVA = "0xE3C2DC", Offset = "0xE3C2DC", VA = "0xE3C2DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0704C", Offset = "0xA0704C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600061D")]
		[Address(RVA = "0xE3C2E4", Offset = "0xE3C2E4", VA = "0xE3C2E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0705C", Offset = "0xA0705C")]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x6000622")]
		[Address(RVA = "0xE3C4A0", Offset = "0xE3C4A0", VA = "0xE3C4A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0706C", Offset = "0xA0706C")]
		add
		{
		}
		[Token(Token = "0x6000623")]
		[Address(RVA = "0xE3C540", Offset = "0xE3C540", VA = "0xE3C540")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0707C", Offset = "0xA0707C")]
		remove
		{
		}
	}

	[Token(Token = "0x600061E")]
	[Address(RVA = "0xE3C2F0", Offset = "0xE3C2F0", VA = "0xE3C2F0")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x600061F")]
	[Address(RVA = "0xE3C388", Offset = "0xE3C388", VA = "0xE3C388")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000620")]
	[Address(RVA = "0xE3C45C", Offset = "0xE3C45C", VA = "0xE3C45C")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x6000621")]
	[Address(RVA = "0xE3C49C", Offset = "0xE3C49C", VA = "0xE3C49C")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0xE3C5E0", Offset = "0xE3C5E0", VA = "0xE3C5E0")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0xE3C644", Offset = "0xE3C644", VA = "0xE3C644")]
	public void Recycle()
	{
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0xE3C664", Offset = "0xE3C664", VA = "0xE3C664", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x2000192")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x2000193")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF61C", Offset = "0x9FF61C")]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700007E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x14C7254", Offset = "0x14C7254", VA = "0x14C7254", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x14C729C", Offset = "0x14C729C", VA = "0x14C729C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x14C718C", Offset = "0x14C718C", VA = "0x14C718C")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x14C71B8", Offset = "0x14C71B8", VA = "0x14C71B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x14C71BC", Offset = "0x14C71BC", VA = "0x14C71BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x14C725C", Offset = "0x14C725C", VA = "0x14C725C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000194")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF62C", Offset = "0x9FF62C")]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000080")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x14C713C", Offset = "0x14C713C", VA = "0x14C713C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x14C7184", Offset = "0x14C7184", VA = "0x14C7184", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x14C7070", Offset = "0x14C7070", VA = "0x14C7070")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x14C709C", Offset = "0x14C709C", VA = "0x14C709C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x14C70A0", Offset = "0x14C70A0", VA = "0x14C70A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x14C7144", Offset = "0x14C7144", VA = "0x14C7144", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x40008AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x6000627")]
	[Address(RVA = "0xE3C99C", Offset = "0xE3C99C", VA = "0xE3C99C")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0xE3CA70", Offset = "0xE3CA70", VA = "0xE3CA70", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0xE3CAD0", Offset = "0xE3CAD0", VA = "0xE3CAD0", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0xE3CB90", Offset = "0xE3CB90", VA = "0xE3CB90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0708C", Offset = "0xA0708C")]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0xE3CC08", Offset = "0xE3CC08", VA = "0xE3CC08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA070EC", Offset = "0xA070EC")]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600062C")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x600062D")]
	public abstract void GetAimData(out Ray aimRay);

	[Token(Token = "0x600062E")]
	[Address(RVA = "0xE3CC80", Offset = "0xE3CC80", VA = "0xE3CC80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0714C", Offset = "0xA0714C")]
	private void <.ctor>b__2_0()
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0xE3CCAC", Offset = "0xE3CCAC", VA = "0xE3CCAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0715C", Offset = "0xA0715C")]
	private void <.ctor>b__2_1()
	{
	}
}
[Token(Token = "0x2000195")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x40008B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA02790", Offset = "0xA02790")]
	private Transform <Pointer>k__BackingField;

	[Token(Token = "0x40008B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA027A0", Offset = "0xA027A0")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x40008B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA027D8", Offset = "0xA027D8")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x40008B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02810", Offset = "0xA02810")]
	public bool FastTeleport;

	[Token(Token = "0x17000082")]
	public Transform Pointer
	{
		[Token(Token = "0x600063C")]
		[Address(RVA = "0xE3CCD8", Offset = "0xE3CCD8", VA = "0xE3CCD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0720C", Offset = "0xA0720C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600063D")]
		[Address(RVA = "0xE3CCE0", Offset = "0xE3CCE0", VA = "0xE3CCE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0721C", Offset = "0xA0721C")]
		private set
		{
		}
	}

	[Token(Token = "0x600063E")]
	[Address(RVA = "0xE3CCE8", Offset = "0xE3CCE8", VA = "0xE3CCE8", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x600063F")]
	[Address(RVA = "0xE3CE40", Offset = "0xE3CE40", VA = "0xE3CE40", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0xE3CEF8", Offset = "0xE3CEF8", VA = "0xE3CEF8")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x2000196")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x2000197")]
	public enum InputModes
	{
		[Token(Token = "0x40008BF")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x40008C0")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x40008C1")]
		ThumbstickTeleport,
		[Token(Token = "0x40008C2")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x2000198")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x40008C4")]
		A,
		[Token(Token = "0x40008C5")]
		B,
		[Token(Token = "0x40008C6")]
		LeftTrigger,
		[Token(Token = "0x40008C7")]
		LeftThumbstick,
		[Token(Token = "0x40008C8")]
		RightTrigger,
		[Token(Token = "0x40008C9")]
		RightThumbstick,
		[Token(Token = "0x40008CA")]
		X,
		[Token(Token = "0x40008CB")]
		Y
	}

	[Token(Token = "0x40008B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x40008B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x40008B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02848", Offset = "0xA02848")]
	public InputModes InputMode;

	[Token(Token = "0x40008B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x40008B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x40008BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02880", Offset = "0xA02880")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x40008BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x40008BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA028B8", Offset = "0xA028B8")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x40008BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA028F0", Offset = "0xA028F0")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x6000641")]
	[Address(RVA = "0xE3CEFC", Offset = "0xE3CEFC", VA = "0xE3CEFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0xE3CF00", Offset = "0xE3CF00", VA = "0xE3CF00", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0xE3D2E8", Offset = "0xE3D2E8", VA = "0xE3D2E8", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0xE3D3A8", Offset = "0xE3D3A8", VA = "0xE3D3A8")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x2000199")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x200019A")]
	public enum OrientationModes
	{
		[Token(Token = "0x40008D0")]
		HeadRelative,
		[Token(Token = "0x40008D1")]
		ForwardFacing
	}

	[Token(Token = "0x200019B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF63C", Offset = "0x9FF63C")]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x17000083")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x14C7384", Offset = "0x14C7384", VA = "0x14C7384", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x14C73CC", Offset = "0x14C73CC", VA = "0x14C73CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x14C72A4", Offset = "0x14C72A4", VA = "0x14C72A4")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x14C72D0", Offset = "0x14C72D0", VA = "0x14C72D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x14C72D4", Offset = "0x14C72D4", VA = "0x14C72D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x14C738C", Offset = "0x14C738C", VA = "0x14C738C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x40008CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40008CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x6000645")]
	[Address(RVA = "0xE3D48C", Offset = "0xE3D48C", VA = "0xE3D48C")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0xE3D580", Offset = "0xE3D580", VA = "0xE3D580")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0xE3D588", Offset = "0xE3D588", VA = "0xE3D588", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0xE3D5D4", Offset = "0xE3D5D4", VA = "0xE3D5D4", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0xE3D61C", Offset = "0xE3D61C", VA = "0xE3D61C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0722C", Offset = "0xA0722C")]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600064A")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x600064B")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x600064C")]
	[Address(RVA = "0xE3D694", Offset = "0xE3D694", VA = "0xE3D694")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0xE3D750", Offset = "0xE3D750", VA = "0xE3D750")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0728C", Offset = "0xA0728C")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x200019C")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x6000654")]
	[Address(RVA = "0xE3D77C", Offset = "0xE3D77C", VA = "0xE3D77C", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0xE3D780", Offset = "0xE3D780", VA = "0xE3D780", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0xE3D7FC", Offset = "0xE3D7FC", VA = "0xE3D7FC")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x200019D")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x40008D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02928", Offset = "0xA02928")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40008D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02960", Offset = "0xA02960")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x40008D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02998", Offset = "0xA02998")]
	public float AimDistanceThreshold;

	[Token(Token = "0x40008D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA029D0", Offset = "0xA029D0")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x40008D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x6000657")]
	[Address(RVA = "0xE3D800", Offset = "0xE3D800", VA = "0xE3D800", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0xE3D82C", Offset = "0xE3D82C", VA = "0xE3D82C", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0xE3DBDC", Offset = "0xE3DBDC", VA = "0xE3DBDC")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x200019E")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x40008DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02A08", Offset = "0xA02A08")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40008DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02A40", Offset = "0xA02A40")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x40008DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02A78", Offset = "0xA02A78")]
	public float RotateStickThreshold;

	[Token(Token = "0x40008DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x40008DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x40008DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x600065A")]
	[Address(RVA = "0xE3DBE0", Offset = "0xE3DBE0", VA = "0xE3DBE0", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600065B")]
	[Address(RVA = "0xE3DC24", Offset = "0xE3DC24", VA = "0xE3DC24", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0xE3DFCC", Offset = "0xE3DFCC", VA = "0xE3DFCC")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x200019F")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x40008E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x40008E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x40008E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x40008E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x40008E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x600065D")]
	[Address(RVA = "0xE3DFDC", Offset = "0xE3DFDC", VA = "0xE3DFDC")]
	private void Start()
	{
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0xE3DFE0", Offset = "0xE3DFE0", VA = "0xE3DFE0")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0xE3DFE8", Offset = "0xE3DFE8", VA = "0xE3DFE8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000660")]
	[Address(RVA = "0xE3E0A4", Offset = "0xE3E0A4", VA = "0xE3E0A4")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0xE3E0CC", Offset = "0xE3E0CC", VA = "0xE3E0CC")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x20001A0")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x40008E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA02AB0", Offset = "0xA02AB0")]
	private LocomotionTeleport <LocomotionTeleport>k__BackingField;

	[Token(Token = "0x40008E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000085")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x6000662")]
		[Address(RVA = "0xE3E0E4", Offset = "0xE3E0E4", VA = "0xE3E0E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA072EC", Offset = "0xA072EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000663")]
		[Address(RVA = "0xE3E0EC", Offset = "0xE3E0EC", VA = "0xE3E0EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA072FC", Offset = "0xA072FC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0xE3BA7C", Offset = "0xE3BA7C", VA = "0xE3BA7C", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0xE3BBA4", Offset = "0xE3BBA4", VA = "0xE3BBA4", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0xE3E0F4", Offset = "0xE3E0F4", VA = "0xE3E0F4")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA0730C", Offset = "0xA0730C")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0xE3C144", Offset = "0xE3C144", VA = "0xE3C144", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0xE3C1B0", Offset = "0xE3C1B0", VA = "0xE3C1B0", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0xE3BBE0", Offset = "0xE3BBE0", VA = "0xE3BBE0")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x20001A1")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x20001A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF64C", Offset = "0x9FF64C")]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x17000086")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x14C76A4", Offset = "0x14C76A4", VA = "0x14C76A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x14C76EC", Offset = "0x14C76EC", VA = "0x14C76EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x14C73D4", Offset = "0x14C73D4", VA = "0x14C73D4")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x14C7400", Offset = "0x14C7400", VA = "0x14C7400", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x14C7404", Offset = "0x14C7404", VA = "0x14C7404", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x14C76AC", Offset = "0x14C76AC", VA = "0x14C76AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02AC0", Offset = "0xA02AC0")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x40008E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x40008E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x40008EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x40008EB")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x600066A")]
	[Address(RVA = "0xE3E1D0", Offset = "0xE3E1D0", VA = "0xE3E1D0")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0xE3E2E0", Offset = "0xE3E2E0", VA = "0xE3E2E0", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0xE3E30C", Offset = "0xE3E30C", VA = "0xE3E30C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0xE3E334", Offset = "0xE3E334", VA = "0xE3E334")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA07344", Offset = "0xA07344")]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0xE3E3AC", Offset = "0xE3E3AC", VA = "0xE3E3AC", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x600066F")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x6000670")]
	[Address(RVA = "0xE3E3C8", Offset = "0xE3E3C8", VA = "0xE3E3C8", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0xE3E4E8", Offset = "0xE3E4E8", VA = "0xE3E4E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA073A4", Offset = "0xA073A4")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20001A3")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x40008EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x40008F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x6000678")]
	[Address(RVA = "0xE3E514", Offset = "0xE3E514", VA = "0xE3E514")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0xE3E578", Offset = "0xE3E578", VA = "0xE3E578", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0xE3E670", Offset = "0xE3E670", VA = "0xE3E670", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0xE3E768", Offset = "0xE3E768", VA = "0xE3E768")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA07404", Offset = "0xA07404")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0xE3E76C", Offset = "0xE3E76C", VA = "0xE3E76C")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x20001A4")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x40008F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02AF8", Offset = "0xA02AF8")]
	public float LOSOffset;

	[Token(Token = "0x40008F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02B30", Offset = "0xA02B30")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x600067D")]
	[Address(RVA = "0xE3E778", Offset = "0xE3E778", VA = "0xE3E778", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0xE3E984", Offset = "0xE3E984", VA = "0xE3E984")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x20001A5")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x600067F")]
	[Address(RVA = "0xE3E990", Offset = "0xE3E990", VA = "0xE3E990", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0xE3EA88", Offset = "0xE3EA88", VA = "0xE3EA88")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x20001A6")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x6000681")]
	[Address(RVA = "0xE3EA8C", Offset = "0xE3EA8C", VA = "0xE3EA8C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0xE3EB20", Offset = "0xE3EB20", VA = "0xE3EB20", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000683")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x6000684")]
	[Address(RVA = "0xE3EBB0", Offset = "0xE3EBB0", VA = "0xE3EBB0")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x20001A7")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x20001A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF65C", Offset = "0x9FF65C")]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x17000088")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x14C782C", Offset = "0x14C782C", VA = "0x14C782C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x14C7874", Offset = "0x14C7874", VA = "0x14C7874", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x14C76F4", Offset = "0x14C76F4", VA = "0x14C76F4")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x14C7720", Offset = "0x14C7720", VA = "0x14C7720", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x14C7724", Offset = "0x14C7724", VA = "0x14C7724", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x14C7834", Offset = "0x14C7834", VA = "0x14C7834", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02B68", Offset = "0xA02B68")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA02B68", Offset = "0xA02B68")]
	public float TransitionDuration;

	[Token(Token = "0x40008F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA02BC0", Offset = "0xA02BC0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02BC0", Offset = "0xA02BC0")]
	public float TeleportDelay;

	[Token(Token = "0x40008F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02C14", Offset = "0xA02C14")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x6000685")]
	[Address(RVA = "0xE3EBB8", Offset = "0xE3EBB8", VA = "0xE3EBB8", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0xE3EBE4", Offset = "0xE3EBE4", VA = "0xE3EBE4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0743C", Offset = "0xA0743C")]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0xE3EC5C", Offset = "0xE3EC5C", VA = "0xE3EC5C")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x20001A9")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x600068E")]
	[Address(RVA = "0xE3EE08", Offset = "0xE3EE08", VA = "0xE3EE08", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x600068F")]
	[Address(RVA = "0xE3EE24", Offset = "0xE3EE24", VA = "0xE3EE24")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x20001AA")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x20001AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF66C", Offset = "0x9FF66C")]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x1700008A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x14C79E8", Offset = "0x14C79E8", VA = "0x14C79E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x14C7A30", Offset = "0x14C7A30", VA = "0x14C7A30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x14C787C", Offset = "0x14C787C", VA = "0x14C787C")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x14C78A8", Offset = "0x14C78A8", VA = "0x14C78A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x14C78AC", Offset = "0x14C78AC", VA = "0x14C78AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x14C79F0", Offset = "0x14C79F0", VA = "0x14C79F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA02C4C", Offset = "0xA02C4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02C4C", Offset = "0xA02C4C")]
	public float TransitionDuration;

	[Token(Token = "0x40008FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x6000690")]
	[Address(RVA = "0xE3EE2C", Offset = "0xE3EE2C", VA = "0xE3EE2C", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000691")]
	[Address(RVA = "0xE3EE58", Offset = "0xE3EE58", VA = "0xE3EE58")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA074EC", Offset = "0xA074EC")]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0xE3EED0", Offset = "0xE3EED0", VA = "0xE3EED0")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x20001AC")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x20001AD")]
	public enum PlabackState
	{
		[Token(Token = "0x400091B")]
		Idle = 1,
		[Token(Token = "0x400091C")]
		Preparing,
		[Token(Token = "0x400091D")]
		Buffering,
		[Token(Token = "0x400091E")]
		Ready,
		[Token(Token = "0x400091F")]
		Ended
	}

	[Token(Token = "0x20001AE")]
	public enum StereoMode
	{
		[Token(Token = "0x4000921")]
		Unknown = -1,
		[Token(Token = "0x4000922")]
		Mono,
		[Token(Token = "0x4000923")]
		TopBottom,
		[Token(Token = "0x4000924")]
		LeftRight,
		[Token(Token = "0x4000925")]
		Mesh
	}

	[Token(Token = "0x4000903")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x4000904")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x4000905")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x4000906")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x4000907")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x4000908")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x4000909")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x400090A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x400090B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x400090C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x400090D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x400090E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x400090F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x4000910")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x4000911")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x4000912")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x4000913")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x4000914")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x4000915")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x4000916")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x4000917")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x4000918")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x4000919")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x1700008C")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x12405F4", Offset = "0x12405F4", VA = "0x12405F4")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700008D")]
	private static IntPtr Activity
	{
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1240924", Offset = "0x1240924", VA = "0x1240924")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700008E")]
	public static bool IsAvailable
	{
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x123D8C4", Offset = "0x123D8C4", VA = "0x123D8C4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700008F")]
	public static bool IsPlaying
	{
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x123F070", Offset = "0x123F070", VA = "0x123F070")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000090")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1240BF4", Offset = "0x1240BF4", VA = "0x1240BF4")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x17000091")]
	public static long Duration
	{
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x123F294", Offset = "0x123F294", VA = "0x123F294")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000092")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x123DEEC", Offset = "0x123DEEC", VA = "0x123DEEC")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x17000093")]
	public static int VideoWidth
	{
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x123DCC4", Offset = "0x123DCC4", VA = "0x123DCC4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000094")]
	public static int VideoHeight
	{
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x123DDD8", Offset = "0x123DDD8", VA = "0x123DDD8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000095")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x123F180", Offset = "0x123F180", VA = "0x123F180")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x123E7A4", Offset = "0x123E7A4", VA = "0x123E7A4")]
		set
		{
		}
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x1240D08", Offset = "0x1240D08", VA = "0x1240D08")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x123F664", Offset = "0x123F664", VA = "0x123F664")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x123E3F0", Offset = "0x123E3F0", VA = "0x123E3F0")]
	public static void Play()
	{
	}

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x123E590", Offset = "0x123E590", VA = "0x123E590")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x123F45C", Offset = "0x123F45C", VA = "0x123F45C")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x1240F34", Offset = "0x1240F34", VA = "0x1240F34")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x123EE80", Offset = "0x123EE80", VA = "0x123EE80")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x20001AF")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400000F")]
	public event Action onButtonDown
	{
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1CAF8E0", Offset = "0x1CAF8E0", VA = "0x1CAF8E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0759C", Offset = "0xA0759C")]
		add
		{
		}
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1CAF980", Offset = "0x1CAF980", VA = "0x1CAF980")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA075AC", Offset = "0xA075AC")]
		remove
		{
		}
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x1CAFA20", Offset = "0x1CAFA20", VA = "0x1CAFA20", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x1CAFA34", Offset = "0x1CAFA34", VA = "0x1CAFA34")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x20001B0")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x20001B1")]
	public enum ButtonType
	{
		[Token(Token = "0x4000929")]
		Play,
		[Token(Token = "0x400092A")]
		Pause,
		[Token(Token = "0x400092B")]
		FastForward,
		[Token(Token = "0x400092C")]
		Rewind,
		[Token(Token = "0x400092D")]
		SkipForward,
		[Token(Token = "0x400092E")]
		SkipBack,
		[Token(Token = "0x400092F")]
		Stop
	}

	[Token(Token = "0x4000927")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x17000096")]
	public ButtonType buttonType
	{
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1E70494", Offset = "0x1E70494", VA = "0x1E70494")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1E7049C", Offset = "0x1E7049C", VA = "0x1E7049C")]
		set
		{
		}
	}

	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x1E704C0", Offset = "0x1E704C0", VA = "0x1E704C0", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x1E71958", Offset = "0x1E71958", VA = "0x1E71958")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x20001B2")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x20001B3")]
	public enum VideoShape
	{
		[Token(Token = "0x4000944")]
		_360,
		[Token(Token = "0x4000945")]
		_180,
		[Token(Token = "0x4000946")]
		Quad
	}

	[Token(Token = "0x20001B4")]
	public enum VideoStereo
	{
		[Token(Token = "0x4000948")]
		Mono,
		[Token(Token = "0x4000949")]
		TopBottom,
		[Token(Token = "0x400094A")]
		LeftRight,
		[Token(Token = "0x400094B")]
		BottomTop
	}

	[Token(Token = "0x20001B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF67C", Offset = "0x9FF67C")]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x1700009A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x14C1858", Offset = "0x14C1858", VA = "0x14C1858", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x14C18A0", Offset = "0x14C18A0", VA = "0x14C18A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x14C1664", Offset = "0x14C1664", VA = "0x14C1664")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x14C1690", Offset = "0x14C1690", VA = "0x14C1690", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x14C1694", Offset = "0x14C1694", VA = "0x14C1694", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x14C1860", Offset = "0x14C1860", VA = "0x14C1860", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF68C", Offset = "0x9FF68C")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string moviePath;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string drmLicencesUrl;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x14C156C", Offset = "0x14C156C", VA = "0x14C156C")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x14C1574", Offset = "0x14C1574", VA = "0x14C1574")]
		internal void <Play>b__0()
		{
		}
	}

	[Token(Token = "0x4000930")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x4000931")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x4000932")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x4000933")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x4000934")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA02CD4", Offset = "0xA02CD4")]
	private bool <IsPlaying>k__BackingField;

	[Token(Token = "0x4000935")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA02CE4", Offset = "0xA02CE4")]
	private long <Duration>k__BackingField;

	[Token(Token = "0x4000936")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA02CF4", Offset = "0xA02CF4")]
	private long <PlaybackPosition>k__BackingField;

	[Token(Token = "0x4000937")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x4000938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x4000939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x400093A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x400093B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x400093C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x400093D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x400093E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x400093F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x4000940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x4000941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x4000942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x17000097")]
	public bool IsPlaying
	{
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x123D5E8", Offset = "0x123D5E8", VA = "0x123D5E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA075BC", Offset = "0xA075BC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x123D5F0", Offset = "0x123D5F0", VA = "0x123D5F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA075CC", Offset = "0xA075CC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000098")]
	public long Duration
	{
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x123D5FC", Offset = "0x123D5FC", VA = "0x123D5FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA075DC", Offset = "0xA075DC")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x123D604", Offset = "0x123D604", VA = "0x123D604")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA075EC", Offset = "0xA075EC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000099")]
	public long PlaybackPosition
	{
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x123D60C", Offset = "0x123D60C", VA = "0x123D60C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA075FC", Offset = "0xA075FC")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x123D614", Offset = "0x123D614", VA = "0x123D614")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0760C", Offset = "0xA0760C")]
		private set
		{
		}
	}

	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x123D61C", Offset = "0x123D61C", VA = "0x123D61C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x123D934", Offset = "0x123D934", VA = "0x123D934")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x123D998", Offset = "0x123D998", VA = "0x123D998")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x123E000", Offset = "0x123E000", VA = "0x123E000")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0761C", Offset = "0xA0761C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x123E078", Offset = "0x123E078", VA = "0x123E078")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x123E360", Offset = "0x123E360", VA = "0x123E360")]
	public void Play()
	{
	}

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x123E504", Offset = "0x123E504", VA = "0x123E504")]
	public void Pause()
	{
	}

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x123E6A4", Offset = "0x123E6A4", VA = "0x123E6A4")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x123E918", Offset = "0x123E918", VA = "0x123E918")]
	private void Update()
	{
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x123F3A8", Offset = "0x123F3A8", VA = "0x123F3A8")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x123F5D8", Offset = "0x123F5D8", VA = "0x123F5D8")]
	public void Stop()
	{
	}

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x123F778", Offset = "0x123F778", VA = "0x123F778")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x123F864", Offset = "0x123F864", VA = "0x123F864")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x20001B7")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x20001B8")]
	private enum PlaybackState
	{
		[Token(Token = "0x4000968")]
		Playing,
		[Token(Token = "0x4000969")]
		Paused,
		[Token(Token = "0x400096A")]
		Rewinding,
		[Token(Token = "0x400096B")]
		FastForwarding
	}

	[Token(Token = "0x4000952")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x4000953")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x4000954")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x4000955")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x4000956")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x4000957")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x4000958")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x4000959")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x400095A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x400095B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x400095C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x400095D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x400095E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x400095F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x4000960")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x4000961")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x4000962")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x4000963")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x4000964")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x4000965")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x4000966")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x123F874", Offset = "0x123F874", VA = "0x123F874")]
	private void Start()
	{
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x123FB80", Offset = "0x123FB80", VA = "0x123FB80")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x123FCAC", Offset = "0x123FCAC", VA = "0x123FCAC")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x123FDB8", Offset = "0x123FDB8", VA = "0x123FDB8")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x123FE98", Offset = "0x123FE98", VA = "0x123FE98")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x123FD8C", Offset = "0x123FD8C", VA = "0x123FD8C")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x123FEE0", Offset = "0x123FEE0", VA = "0x123FEE0")]
	private void Update()
	{
	}

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x123FA6C", Offset = "0x123FA6C", VA = "0x123FA6C")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x1240244", Offset = "0x1240244", VA = "0x1240244")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x20001B9")]
public static class VectorUtil
{
	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x1DAFD7C", Offset = "0x1DAFD7C", VA = "0x1DAFD7C")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x20001BA")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x400096C")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x400096D")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x400096E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x400096F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x4000970")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x4000971")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x4000972")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x4000973")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x1CAA08C", Offset = "0x1CAA08C", VA = "0x1CAA08C")]
	private void Start()
	{
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x1CAA4A0", Offset = "0x1CAA4A0", VA = "0x1CAA4A0")]
	private void Update()
	{
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x1CAA72C", Offset = "0x1CAA72C", VA = "0x1CAA72C")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x1CAA894", Offset = "0x1CAA894", VA = "0x1CAA894")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x1CAAA00", Offset = "0x1CAAA00", VA = "0x1CAAA00")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x1CAAB90", Offset = "0x1CAAB90", VA = "0x1CAAB90")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x20001BB")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x4000974")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000975")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x4000976")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x1D1755C", Offset = "0x1D1755C", VA = "0x1D1755C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x1D175B0", Offset = "0x1D175B0", VA = "0x1D175B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x1D175B4", Offset = "0x1D175B4", VA = "0x1D175B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x1D175B8", Offset = "0x1D175B8", VA = "0x1D175B8")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x1D1782C", Offset = "0x1D1782C", VA = "0x1D1782C")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x1D17A5C", Offset = "0x1D17A5C", VA = "0x1D17A5C")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x20001BC")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x4000977")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x4000978")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x1D1A008", Offset = "0x1D1A008", VA = "0x1D1A008")]
	private void Start()
	{
	}

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x1D1A524", Offset = "0x1D1A524", VA = "0x1D1A524")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x1D1A5E4", Offset = "0x1D1A5E4", VA = "0x1D1A5E4")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x1D1A864", Offset = "0x1D1A864", VA = "0x1D1A864")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x1D1A944", Offset = "0x1D1A944", VA = "0x1D1A944")]
	private void Update()
	{
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x1D1AA28", Offset = "0x1D1AA28", VA = "0x1D1AA28")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x1D1AA9C", Offset = "0x1D1AA9C", VA = "0x1D1AA9C")]
	public DebugUISample()
	{
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x1D1AAA4", Offset = "0x1D1AAA4", VA = "0x1D1AAA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA076DC", Offset = "0xA076DC")]
	private void <Start>b__2_0(Toggle t)
	{
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x1D1AB08", Offset = "0x1D1AB08", VA = "0x1D1AB08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA076EC", Offset = "0xA076EC")]
	private void <Start>b__2_1(Toggle t)
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x1D1AB6C", Offset = "0x1D1AB6C", VA = "0x1D1AB6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA076FC", Offset = "0xA076FC")]
	private void <Start>b__2_2(Toggle t)
	{
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x1D1ABD0", Offset = "0x1D1ABD0", VA = "0x1D1ABD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0770C", Offset = "0xA0770C")]
	private void <Start>b__2_3(Toggle t)
	{
	}
}
[Token(Token = "0x20001BD")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x1CA4E34", Offset = "0x1CA4E34", VA = "0x1CA4E34")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x20001BE")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x4000979")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x400097A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x400097B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x400097C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0xE2C4B0", Offset = "0xE2C4B0", VA = "0xE2C4B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0xE2C554", Offset = "0xE2C554", VA = "0xE2C554")]
	private void Update()
	{
	}

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0xE2C640", Offset = "0xE2C640", VA = "0xE2C640")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0xE2C6A0", Offset = "0xE2C6A0", VA = "0xE2C6A0")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x20001BF")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x60006F5")]
	[Address(RVA = "0xE38D74", Offset = "0xE38D74", VA = "0xE38D74")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x20001C0")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x20001C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF6AC", Offset = "0x9FF6AC")]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x1700009C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x1DBC2D0", Offset = "0x1DBC2D0", VA = "0x1DBC2D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x1DBC318", Offset = "0x1DBC318", VA = "0x1DBC318", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1DBC154", Offset = "0x1DBC154", VA = "0x1DBC154")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1DBC180", Offset = "0x1DBC180", VA = "0x1DBC180", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1DBC184", Offset = "0x1DBC184", VA = "0x1DBC184", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1DBC2D8", Offset = "0x1DBC2D8", VA = "0x1DBC2D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400097D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x400097E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x400097F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x4000980")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x1E6416C", Offset = "0x1E6416C", VA = "0x1E6416C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x1E64288", Offset = "0x1E64288", VA = "0x1E64288")]
	private void Update()
	{
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x1E64210", Offset = "0x1E64210", VA = "0x1E64210")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0771C", Offset = "0xA0771C")]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x1E64434", Offset = "0x1E64434", VA = "0x1E64434")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x20001C2")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x4000984")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x4000985")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x4000986")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x4000987")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x4000988")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA02D24", Offset = "0xA02D24")]
	public int SubdivisionsU;

	[Token(Token = "0x4000989")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA02D40", Offset = "0xA02D40")]
	public int SubdivisionsV;

	[Token(Token = "0x400098A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x400098B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x400098C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x400098D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x6000700")]
	[Address(RVA = "0x1CBA558", Offset = "0x1CBA558", VA = "0x1CBA558")]
	private void Update()
	{
	}

	[Token(Token = "0x6000701")]
	[Address(RVA = "0x1CBAFA0", Offset = "0x1CBAFA0", VA = "0x1CBAFA0")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x20001C3")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x400098E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x400098F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x1700009E")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1E6C3F4", Offset = "0x1E6C3F4", VA = "0x1E6C3F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000703")]
	[Address(RVA = "0x1E6C448", Offset = "0x1E6C448", VA = "0x1E6C448")]
	public void Start()
	{
	}

	[Token(Token = "0x6000704")]
	[Address(RVA = "0x1E6C870", Offset = "0x1E6C870", VA = "0x1E6C870")]
	public void Update()
	{
	}

	[Token(Token = "0x6000705")]
	[Address(RVA = "0x1E6C95C", Offset = "0x1E6C95C", VA = "0x1E6C95C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA077CC", Offset = "0xA077CC")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x6000706")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000707")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x6000708")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x6000709")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x600070A")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x600070B")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x600070C")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x600070D")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600070E")]
	[Address(RVA = "0x1E6C9C0", Offset = "0x1E6C9C0", VA = "0x1E6C9C0")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0x1E6C9FC", Offset = "0x1E6C9FC", VA = "0x1E6C9FC")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0x1E6CA6C", Offset = "0x1E6CA6C", VA = "0x1E6CA6C")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0x1E6CBDC", Offset = "0x1E6CBDC", VA = "0x1E6CBDC")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0x1E6CCB8", Offset = "0x1E6CCB8", VA = "0x1E6CCB8")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0x1E6C768", Offset = "0x1E6C768", VA = "0x1E6C768")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x6000714")]
	[Address(RVA = "0x1E6CD80", Offset = "0x1E6CD80", VA = "0x1E6CD80")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x6000715")]
	[Address(RVA = "0x1E6CDE8", Offset = "0x1E6CDE8", VA = "0x1E6CDE8")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x6000716")]
	[Address(RVA = "0x1E6CEE0", Offset = "0x1E6CEE0", VA = "0x1E6CEE0")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x20001C4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9FF6CC", Offset = "0x9FF6CC")]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x20001C5")]
	public enum DrawMode
	{
		[Token(Token = "0x40009A5")]
		Opaque,
		[Token(Token = "0x40009A6")]
		OpaqueWithClip,
		[Token(Token = "0x40009A7")]
		TransparentDefaultAlpha,
		[Token(Token = "0x40009A8")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x4000990")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[HideInInspector]
	private Shader _transparentShader;

	[Token(Token = "0x4000991")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private Shader _opaqueShader;

	[Token(Token = "0x4000992")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x4000993")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x4000994")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x4000995")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x4000996")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x4000997")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x4000998")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x4000999")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x400099A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x400099B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x400099C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x400099D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x400099E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x400099F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x40009A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x40009A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x40009A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x40009A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x1700009F")]
	public bool overlayEnabled
	{
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1242920", Offset = "0x1242920", VA = "0x1242920")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x12429B0", Offset = "0x12429B0", VA = "0x12429B0")]
		set
		{
		}
	}

	[Token(Token = "0x6000717")]
	[Address(RVA = "0x124139C", Offset = "0x124139C", VA = "0x124139C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0x1241F8C", Offset = "0x1241F8C", VA = "0x1241F8C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0x124200C", Offset = "0x124200C", VA = "0x124200C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600071A")]
	[Address(RVA = "0x12420FC", Offset = "0x12420FC", VA = "0x12420FC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0x12421EC", Offset = "0x12421EC", VA = "0x12421EC", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x600071C")]
	[Address(RVA = "0x12423F8", Offset = "0x12423F8", VA = "0x12423F8")]
	private void Update()
	{
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0x1242A7C", Offset = "0x1242A7C", VA = "0x1242A7C")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x20001C6")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x40009A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x40009AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x40009AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x6000721")]
	[Address(RVA = "0x1CACA64", Offset = "0x1CACA64", VA = "0x1CACA64")]
	private void Start()
	{
	}

	[Token(Token = "0x6000722")]
	[Address(RVA = "0x1CACC4C", Offset = "0x1CACC4C", VA = "0x1CACC4C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0x1CACDD4", Offset = "0x1CACDD4", VA = "0x1CACDD4")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0x1CACDDC", Offset = "0x1CACDDC", VA = "0x1CACDDC")]
	public void Release()
	{
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0x1CACDC4", Offset = "0x1CACDC4", VA = "0x1CACDC4")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x6000726")]
	[Address(RVA = "0x1CACDE4", Offset = "0x1CACDE4", VA = "0x1CACDE4")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x20001C7")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x20001C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF72C", Offset = "0x9FF72C")]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x170000A0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x1DB8DA4", Offset = "0x1DB8DA4", VA = "0x1DB8DA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x1DB8DEC", Offset = "0x1DB8DEC", VA = "0x1DB8DEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1DB8C74", Offset = "0x1DB8C74", VA = "0x1DB8C74")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1DB8CA0", Offset = "0x1DB8CA0", VA = "0x1DB8CA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1DB8CA4", Offset = "0x1DB8CA4", VA = "0x1DB8CA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x1DB8DAC", Offset = "0x1DB8DAC", VA = "0x1DB8DAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001C9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF73C", Offset = "0x9FF73C")]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x170000A2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x1DB8FAC", Offset = "0x1DB8FAC", VA = "0x1DB8FAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x1DB8FF4", Offset = "0x1DB8FF4", VA = "0x1DB8FF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1DB8DF4", Offset = "0x1DB8DF4", VA = "0x1DB8DF4")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1DB8E20", Offset = "0x1DB8E20", VA = "0x1DB8E20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x1DB8E24", Offset = "0x1DB8E24", VA = "0x1DB8E24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1DB8FB4", Offset = "0x1DB8FB4", VA = "0x1DB8FB4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40009AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x40009AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x40009AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x40009AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x6000727")]
	[Address(RVA = "0x1CAE600", Offset = "0x1CAE600", VA = "0x1CAE600")]
	private void Start()
	{
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0x1CAE8D4", Offset = "0x1CAE8D4", VA = "0x1CAE8D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0x1CAE930", Offset = "0x1CAE930", VA = "0x1CAE930")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0x1CAEAB0", Offset = "0x1CAEAB0", VA = "0x1CAEAB0")]
	public void Release()
	{
	}

	[Token(Token = "0x600072B")]
	[Address(RVA = "0x1CAEB84", Offset = "0x1CAEB84", VA = "0x1CAEB84")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA07804", Offset = "0xA07804")]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0x1CAE9EC", Offset = "0x1CAE9EC", VA = "0x1CAE9EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA07864", Offset = "0xA07864")]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x600072D")]
	[Address(RVA = "0x1CAEC20", Offset = "0x1CAEC20", VA = "0x1CAEC20")]
	public BrushController()
	{
	}
}
[Token(Token = "0x20001CA")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x600073A")]
	[Address(RVA = "0x1D1EC50", Offset = "0x1D1EC50", VA = "0x1D1EC50")]
	private void Start()
	{
	}

	[Token(Token = "0x600073B")]
	[Address(RVA = "0x1D1ECB0", Offset = "0x1D1ECB0", VA = "0x1D1ECB0")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x20001CB")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x40009BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x40009BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x40009C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x600073C")]
	[Address(RVA = "0x1D22900", Offset = "0x1D22900", VA = "0x1D22900")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0x1D22A34", Offset = "0x1D22A34", VA = "0x1D22A34")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x600073E")]
	[Address(RVA = "0x1D22AC8", Offset = "0x1D22AC8", VA = "0x1D22AC8")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x600073F")]
	[Address(RVA = "0x1D22B30", Offset = "0x1D22B30", VA = "0x1D22B30")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x20001CC")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x20001CD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF74C", Offset = "0x9FF74C")]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x170000A4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x1DBB68C", Offset = "0x1DBB68C", VA = "0x1DBB68C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x1DBB6D4", Offset = "0x1DBB6D4", VA = "0x1DBB6D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x1DBB480", Offset = "0x1DBB480", VA = "0x1DBB480")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1DBB4AC", Offset = "0x1DBB4AC", VA = "0x1DBB4AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1DBB4B0", Offset = "0x1DBB4B0", VA = "0x1DBB4B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1DBB694", Offset = "0x1DBB694", VA = "0x1DBB694", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40009C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x40009C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x40009C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x40009C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x40009C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x40009C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x40009C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x40009C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x40009C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x40009CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x6000740")]
	[Address(RVA = "0x1D22B38", Offset = "0x1D22B38", VA = "0x1D22B38")]
	private void Start()
	{
	}

	[Token(Token = "0x6000741")]
	[Address(RVA = "0x1D22E1C", Offset = "0x1D22E1C", VA = "0x1D22E1C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x1D2316C", Offset = "0x1D2316C", VA = "0x1D2316C")]
	private void FindHands()
	{
	}

	[Token(Token = "0x6000743")]
	[Address(RVA = "0x1D234C8", Offset = "0x1D234C8", VA = "0x1D234C8")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0x1D237CC", Offset = "0x1D237CC", VA = "0x1D237CC")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0x1D238C0", Offset = "0x1D238C0", VA = "0x1D238C0")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0x1D23A8C", Offset = "0x1D23A8C", VA = "0x1D23A8C")]
	public void Release()
	{
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0x1D239D8", Offset = "0x1D239D8", VA = "0x1D239D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA07964", Offset = "0xA07964")]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0x1D23B74", Offset = "0x1D23B74", VA = "0x1D23B74")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x20001CE")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x20001CF")]
	public enum ManipulationType
	{
		[Token(Token = "0x40009DD")]
		Default,
		[Token(Token = "0x40009DE")]
		ForcedHand,
		[Token(Token = "0x40009DF")]
		DollyHand,
		[Token(Token = "0x40009E0")]
		DollyAttached,
		[Token(Token = "0x40009E1")]
		HorizontalScaled,
		[Token(Token = "0x40009E2")]
		VerticalScaled,
		[Token(Token = "0x40009E3")]
		Menu
	}

	[Token(Token = "0x20001D0")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x20001D1")]
	public delegate void ReleasedObject();

	[Token(Token = "0x20001D2")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x40009D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0xA02DCC", Offset = "0xA02DCC")]
	public string ObjectName;

	[Token(Token = "0x40009D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0xA02DDC", Offset = "0xA02DDC")]
	public string ObjectInstructions;

	[Token(Token = "0x40009D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x40009D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x40009D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion grabbedRotation;

	[Token(Token = "0x40009D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x40009DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x40009DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x600074F")]
	[Address(RVA = "0x1D2789C", Offset = "0x1D2789C", VA = "0x1D2789C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0x1D278F8", Offset = "0x1D278F8", VA = "0x1D278F8")]
	public void Release()
	{
	}

	[Token(Token = "0x6000751")]
	[Address(RVA = "0x1D2790C", Offset = "0x1D2790C", VA = "0x1D2790C")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0x1D27920", Offset = "0x1D27920", VA = "0x1D27920")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x20001D3")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x40009E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x40009E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x40009E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02DFC", Offset = "0xA02DFC")]
	public int radialDivisions;

	[Token(Token = "0x40009E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02E34", Offset = "0xA02E34")]
	public float borderSize;

	[Token(Token = "0x40009E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02E6C", Offset = "0xA02E6C")]
	public float fingerTaper;

	[Token(Token = "0x40009E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02EA4", Offset = "0xA02EA4")]
	public float fingerTipLength;

	[Token(Token = "0x40009EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA02EDC", Offset = "0xA02EDC")]
	public float webOffset;

	[Token(Token = "0x40009EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x40009EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x40009ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x40009EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x40009EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x40009F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x40009F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x40009F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x40009F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x1E5FB6C", Offset = "0x1E5FB6C", VA = "0x1E5FB6C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x1E5FD6C", Offset = "0x1E5FD6C", VA = "0x1E5FD6C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0x1E5FF78", Offset = "0x1E5FF78", VA = "0x1E5FF78")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x1E605FC", Offset = "0x1E605FC", VA = "0x1E605FC")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x1E60C2C", Offset = "0x1E60C2C", VA = "0x1E60C2C")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x1E632A8", Offset = "0x1E632A8", VA = "0x1E632A8")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x1E63364", Offset = "0x1E63364", VA = "0x1E63364")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x20001D4")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x40009F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x40009F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x40009F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x40009F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x40009F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x40009F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x40009FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x40009FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x1E63388", Offset = "0x1E63388", VA = "0x1E63388")]
	private void Start()
	{
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x1E636A8", Offset = "0x1E636A8", VA = "0x1E636A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000768")]
	[Address(RVA = "0x1E63430", Offset = "0x1E63430", VA = "0x1E63430")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x6000769")]
	[Address(RVA = "0x1E63A98", Offset = "0x1E63A98", VA = "0x1E63A98")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0x1E63F88", Offset = "0x1E63F88", VA = "0x1E63F88")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x20001D5")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x20001D6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF75C", Offset = "0x9FF75C")]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x170000A6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x14C1DF8", Offset = "0x14C1DF8", VA = "0x14C1DF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x14C1E40", Offset = "0x14C1E40", VA = "0x14C1E40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x14C1B28", Offset = "0x14C1B28", VA = "0x14C1B28")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x14C1B54", Offset = "0x14C1B54", VA = "0x14C1B54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x14C1B58", Offset = "0x14C1B58", VA = "0x14C1B58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x14C1E00", Offset = "0x14C1E00", VA = "0x14C1E00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40009FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x40009FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x40009FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x40009FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x4000A00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x4000A01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x4000A02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x4000A03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x4000A04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x4000A05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x4000A06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000A07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x4000A08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x4000A09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x4000A0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x4000A0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x4000A0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x4000A0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x4000A0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x600076B")]
	[Address(RVA = "0x1244050", Offset = "0x1244050", VA = "0x1244050")]
	private void Start()
	{
	}

	[Token(Token = "0x600076C")]
	[Address(RVA = "0x1244288", Offset = "0x1244288", VA = "0x1244288")]
	private void Update()
	{
	}

	[Token(Token = "0x600076D")]
	[Address(RVA = "0x1244ED8", Offset = "0x1244ED8", VA = "0x1244ED8")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0x1245AE0", Offset = "0x1245AE0", VA = "0x1245AE0")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x600076F")]
	[Address(RVA = "0x1244210", Offset = "0x1244210", VA = "0x1244210")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA07A14", Offset = "0xA07A14")]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x6000770")]
	[Address(RVA = "0x12444F4", Offset = "0x12444F4", VA = "0x12444F4")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000771")]
	[Address(RVA = "0x124519C", Offset = "0x124519C", VA = "0x124519C")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000772")]
	[Address(RVA = "0x1245DA4", Offset = "0x1245DA4", VA = "0x1245DA4")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x6000773")]
	[Address(RVA = "0x1245E30", Offset = "0x1245E30", VA = "0x1245E30")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000774")]
	[Address(RVA = "0x1245E60", Offset = "0x1245E60", VA = "0x1245E60")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x6000775")]
	[Address(RVA = "0x1245C6C", Offset = "0x1245C6C", VA = "0x1245C6C")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x6000776")]
	[Address(RVA = "0x1245F84", Offset = "0x1245F84", VA = "0x1245F84")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x20001D7")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x4000A14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x600077D")]
	[Address(RVA = "0x1246398", Offset = "0x1246398", VA = "0x1246398")]
	private void Start()
	{
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0x1246530", Offset = "0x1246530", VA = "0x1246530")]
	private void Update()
	{
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0x12465F8", Offset = "0x12465F8", VA = "0x12465F8")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x20001D8")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x20001D9")]
	public enum BrushState
	{
		[Token(Token = "0x4000A20")]
		Idle,
		[Token(Token = "0x4000A21")]
		Inking
	}

	[Token(Token = "0x4000A15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000A16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x4000A17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x4000A18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x4000A19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x4000A1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x4000A1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x4000A1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x4000A1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x4000A1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x6000780")]
	[Address(RVA = "0xFED9A4", Offset = "0xFED9A4", VA = "0xFED9A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0xFED9AC", Offset = "0xFED9AC", VA = "0xFED9AC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000782")]
	[Address(RVA = "0xFEDC94", Offset = "0xFEDC94", VA = "0xFEDC94")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0xFEDE8C", Offset = "0xFEDE8C", VA = "0xFEDE8C")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000784")]
	[Address(RVA = "0xFEE034", Offset = "0xFEE034", VA = "0xFEE034")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x6000785")]
	[Address(RVA = "0xFEDBA0", Offset = "0xFEDBA0", VA = "0xFEDBA0")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x6000786")]
	[Address(RVA = "0xFEE110", Offset = "0xFEE110", VA = "0xFEE110")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x20001DA")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x4000A22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x6000787")]
	[Address(RVA = "0xFEE1A8", Offset = "0xFEE1A8", VA = "0xFEE1A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000788")]
	[Address(RVA = "0xFEE340", Offset = "0xFEE340", VA = "0xFEE340")]
	private void Update()
	{
	}

	[Token(Token = "0x6000789")]
	[Address(RVA = "0xFEE4A4", Offset = "0xFEE4A4", VA = "0xFEE4A4")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x20001DB")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x4000A23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000A24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000A25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x600078A")]
	[Address(RVA = "0xFEE4AC", Offset = "0xFEE4AC", VA = "0xFEE4AC")]
	private void Start()
	{
	}

	[Token(Token = "0x600078B")]
	[Address(RVA = "0xFEE6C0", Offset = "0xFEE6C0", VA = "0xFEE6C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600078C")]
	[Address(RVA = "0xFEE890", Offset = "0xFEE890", VA = "0xFEE890")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x20001DC")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x20001DD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF76C", Offset = "0x9FF76C")]
	private sealed class <FadeToCurrentStyle>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <posterize>5__5;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Color <edgeCol>5__6;

		[Token(Token = "0x170000A8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600079F")]
			[Address(RVA = "0x14C37C4", Offset = "0x14C37C4", VA = "0x14C37C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x14C380C", Offset = "0x14C380C", VA = "0x14C380C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x14C35E0", Offset = "0x14C35E0", VA = "0x14C35E0")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x14C360C", Offset = "0x14C360C", VA = "0x14C360C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x14C3610", Offset = "0x14C3610", VA = "0x14C3610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x14C37CC", Offset = "0x14C37CC", VA = "0x14C37CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001DE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF77C", Offset = "0x9FF77C")]
	private sealed class <FadeToDefaultPassthrough>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <posterize>5__5;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Color <edgeCol>5__6;

		[Token(Token = "0x170000AA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x14C3A38", Offset = "0x14C3A38", VA = "0x14C3A38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x14C3A80", Offset = "0x14C3A80", VA = "0x14C3A80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x14C3814", Offset = "0x14C3814", VA = "0x14C3814")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x14C3840", Offset = "0x14C3840", VA = "0x14C3840", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x14C3844", Offset = "0x14C3844", VA = "0x14C3844", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x14C3A40", Offset = "0x14C3A40", VA = "0x14C3A40", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000A26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000A27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000A28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator fadeIn;

	[Token(Token = "0x4000A29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator fadeOut;

	[Token(Token = "0x4000A2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform[] menuOptions;

	[Token(Token = "0x4000A2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform colorWheel;

	[Token(Token = "0x4000A2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D colorTexture;

	[Token(Token = "0x4000A2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000A2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool settingColor;

	[Token(Token = "0x4000A2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color savedColor;

	[Token(Token = "0x4000A30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float savedBrightness;

	[Token(Token = "0x4000A31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float savedContrast;

	[Token(Token = "0x4000A32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float savedPosterize;

	[Token(Token = "0x4000A33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public CanvasGroup mainCanvas;

	[Token(Token = "0x4000A34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject[] compactObjects;

	[Token(Token = "0x600078D")]
	[Address(RVA = "0xFEE898", Offset = "0xFEE898", VA = "0xFEE898")]
	private void Start()
	{
	}

	[Token(Token = "0x600078E")]
	[Address(RVA = "0xFEEBD0", Offset = "0xFEEBD0", VA = "0xFEEBD0")]
	private void Update()
	{
	}

	[Token(Token = "0x600078F")]
	[Address(RVA = "0xFEEE28", Offset = "0xFEEE28", VA = "0xFEEE28")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000790")]
	[Address(RVA = "0xFEEFAC", Offset = "0xFEEFAC", VA = "0xFEEFAC")]
	public void Release()
	{
	}

	[Token(Token = "0x6000791")]
	[Address(RVA = "0xFEEF24", Offset = "0xFEEF24", VA = "0xFEEF24")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA07AC4", Offset = "0xA07AC4")]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000792")]
	[Address(RVA = "0xFEF09C", Offset = "0xFEF09C", VA = "0xFEF09C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA07B24", Offset = "0xA07B24")]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000793")]
	[Address(RVA = "0xFEF124", Offset = "0xFEF124", VA = "0xFEF124")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x6000794")]
	[Address(RVA = "0xFEF144", Offset = "0xFEF144", VA = "0xFEF144")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x6000795")]
	[Address(RVA = "0xFEF164", Offset = "0xFEF164", VA = "0xFEF164")]
	public void OnPosterizeChanged(float newValue)
	{
	}

	[Token(Token = "0x6000796")]
	[Address(RVA = "0xFEF184", Offset = "0xFEF184", VA = "0xFEF184")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x6000797")]
	[Address(RVA = "0xFEEB54", Offset = "0xFEEB54", VA = "0xFEEB54")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x6000798")]
	[Address(RVA = "0xFEF1E8", Offset = "0xFEF1E8", VA = "0xFEF1E8")]
	public void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x6000799")]
	[Address(RVA = "0xFEF1F4", Offset = "0xFEF1F4", VA = "0xFEF1F4")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x600079A")]
	[Address(RVA = "0xFEEBE8", Offset = "0xFEEBE8", VA = "0xFEEBE8")]
	public void GetColorFromWheel()
	{
	}

	[Token(Token = "0x600079B")]
	[Address(RVA = "0xFEF200", Offset = "0xFEF200", VA = "0xFEF200")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x20001DF")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x4000A47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000A48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x60007A8")]
	[Address(RVA = "0xFEF244", Offset = "0xFEF244", VA = "0xFEF244")]
	private void Start()
	{
	}

	[Token(Token = "0x60007A9")]
	[Address(RVA = "0xFEF304", Offset = "0xFEF304", VA = "0xFEF304")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x20001E0")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x4000A49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000A4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000A4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x60007AA")]
	[Address(RVA = "0xFF5F84", Offset = "0xFF5F84", VA = "0xFF5F84")]
	private void Start()
	{
	}

	[Token(Token = "0x60007AB")]
	[Address(RVA = "0xFF61C8", Offset = "0xFF61C8", VA = "0xFF61C8")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60007AC")]
	[Address(RVA = "0xFF6220", Offset = "0xFF6220", VA = "0xFF6220")]
	public void Release()
	{
	}

	[Token(Token = "0x60007AD")]
	[Address(RVA = "0xFF626C", Offset = "0xFF626C", VA = "0xFF626C")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x20001E1")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x4000A4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x4000A4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x60007AE")]
	[Address(RVA = "0xE2C6FC", Offset = "0xE2C6FC", VA = "0xE2C6FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007AF")]
	[Address(RVA = "0xE2C774", Offset = "0xE2C774", VA = "0xE2C774")]
	private void Update()
	{
	}

	[Token(Token = "0x60007B0")]
	[Address(RVA = "0xE2CA98", Offset = "0xE2CA98", VA = "0xE2CA98")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x20001E2")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x4000A4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x4000A4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x60007B1")]
	[Address(RVA = "0xE2DC24", Offset = "0xE2DC24", VA = "0xE2DC24")]
	private void Update()
	{
	}

	[Token(Token = "0x60007B2")]
	[Address(RVA = "0xE2E0AC", Offset = "0xE2E0AC", VA = "0xE2E0AC")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x20001E3")]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x4000A50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong anchorHandle_;

	[Token(Token = "0x4000A51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Canvas canvas_;

	[Token(Token = "0x4000A52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform pivot_;

	[Token(Token = "0x4000A53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject anchorMenu_;

	[Token(Token = "0x4000A54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isSelected_;

	[Token(Token = "0x4000A55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool isHovered_;

	[Token(Token = "0x4000A56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TextMeshProUGUI anchorName_;

	[Token(Token = "0x4000A57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject saveIcon_;

	[Token(Token = "0x4000A58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image labelImage_;

	[Token(Token = "0x4000A59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Color labelBaseColor_;

	[Token(Token = "0x4000A5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Color labelHighlightColor_;

	[Token(Token = "0x4000A5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Color labelSelectedColor_;

	[Token(Token = "0x4000A5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private AnchorUIManager uiManager_;

	[Token(Token = "0x4000A5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private MeshRenderer[] renderers_;

	[Token(Token = "0x4000A5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int menuIndex_;

	[Token(Token = "0x4000A5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private List<Button> buttonList_;

	[Token(Token = "0x4000A60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Button selectedButton_;

	[Token(Token = "0x170000AC")]
	public ulong anchorHandle
	{
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x1CA4E3C", Offset = "0x1CA4E3C", VA = "0x1CA4E3C")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x1CA4E44", Offset = "0x1CA4E44", VA = "0x1CA4E44")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x1CA4F2C", Offset = "0x1CA4F2C", VA = "0x1CA4F2C")]
	private void Update()
	{
	}

	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x1CA5194", Offset = "0x1CA5194", VA = "0x1CA5194")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x1CA51FC", Offset = "0x1CA51FC", VA = "0x1CA51FC")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x1CA5260", Offset = "0x1CA5260", VA = "0x1CA5260")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x1CA52C4", Offset = "0x1CA52C4", VA = "0x1CA52C4")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x1CA53CC", Offset = "0x1CA53CC", VA = "0x1CA53CC")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x1CA54EC", Offset = "0x1CA54EC", VA = "0x1CA54EC")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x1CA5620", Offset = "0x1CA5620", VA = "0x1CA5620")]
	public void SetAnchorHandle(ulong handle)
	{
	}

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x1CA56B4", Offset = "0x1CA56B4", VA = "0x1CA56B4")]
	public void ShowSaveIcon()
	{
	}

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x1CA4F70", Offset = "0x1CA4F70", VA = "0x1CA4F70")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x1CA5084", Offset = "0x1CA5084", VA = "0x1CA5084")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x1CA56D4", Offset = "0x1CA56D4", VA = "0x1CA56D4")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x1CA57EC", Offset = "0x1CA57EC", VA = "0x1CA57EC")]
	public Anchor()
	{
	}
}
[Token(Token = "0x20001E4")]
public class AnchorHelpers
{
	[Token(Token = "0x4000A61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Camera camera;

	[Token(Token = "0x170000AD")]
	private static Camera MainCamera
	{
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1CA57F4", Offset = "0x1CA57F4", VA = "0x1CA57F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x1CA58AC", Offset = "0x1CA58AC", VA = "0x1CA58AC")]
	public static OVRPose getTransformUnityWorldFromDevice()
	{
		return default(OVRPose);
	}

	[Token(Token = "0x60007C4")]
	public static T ByteArrayToStruct<T>(byte[] bytes) where T : struct
	{
		return (T)null;
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x1CA5904", Offset = "0x1CA5904", VA = "0x1CA5904")]
	public static string UuidToString(byte[] encodedMessage)
	{
		return null;
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x1CA5BA8", Offset = "0x1CA5BA8", VA = "0x1CA5BA8")]
	public static byte[] StringToUuid(string str)
	{
		return null;
	}

	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x1CA5D20", Offset = "0x1CA5D20", VA = "0x1CA5D20")]
	private static int GetHexVal(char hex)
	{
		return default(int);
	}

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x1CA5DE4", Offset = "0x1CA5DE4", VA = "0x1CA5DE4")]
	public AnchorHelpers()
	{
	}
}
[Token(Token = "0x20001E5")]
public abstract class AnchorSession : MonoBehaviour
{
	[Token(Token = "0x20001E6")]
	public enum StorageLocation
	{
		[Token(Token = "0x4000A69")]
		LOCAL
	}

	[Token(Token = "0x4000A62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorSession Instance;

	[Token(Token = "0x4000A63")]
	public const ulong kInvalidHandle = ulong.MaxValue;

	[Token(Token = "0x4000A64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<ulong, Anchor> handleToAnchor;

	[Token(Token = "0x4000A65")]
	protected const int maxEvents = 5;

	[Token(Token = "0x4000A66")]
	protected const float eventPollingRate = 0.1f;

	[Token(Token = "0x4000A67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected GameObject anchorPrefab_;

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x1CA5DEC", Offset = "0x1CA5DEC", VA = "0x1CA5DEC", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x1CA5B18", Offset = "0x1CA5B18", VA = "0x1CA5B18")]
	public static void Log(string message)
	{
	}

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x1CA5EF4", Offset = "0x1CA5EF4", VA = "0x1CA5EF4")]
	protected static bool isFlagSet(uint bitset, uint flag)
	{
		return default(bool);
	}

	[Token(Token = "0x60007CC")]
	public abstract ulong CreateSpatialAnchor(Transform T_UnityWorld_Anchor);

	[Token(Token = "0x60007CD")]
	public abstract void DestroyAnchor(ulong anchorHandle);

	[Token(Token = "0x60007CE")]
	public abstract void SaveAnchor(ulong anchorHandle, StorageLocation location);

	[Token(Token = "0x60007CF")]
	public abstract void EraseAnchor(ulong anchorHandle);

	[Token(Token = "0x60007D0")]
	public abstract void QueryAllLocalAnchors();

	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x1CA5F00", Offset = "0x1CA5F00", VA = "0x1CA5F00")]
	protected AnchorSession()
	{
	}
}
[Token(Token = "0x20001E7")]
public class AnchorSpawner : MonoBehaviour
{
	[Token(Token = "0x4000A6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorSpawner Instance;

	[Token(Token = "0x4000A6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject anchorPrefab_;

	[Token(Token = "0x170000AE")]
	public GameObject AnchorPrefab
	{
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1CA5F84", Offset = "0x1CA5F84", VA = "0x1CA5F84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x1CA5F8C", Offset = "0x1CA5F8C", VA = "0x1CA5F8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x1CA608C", Offset = "0x1CA608C", VA = "0x1CA608C")]
	public void PlaceAnchorAtTransform(Transform transform)
	{
	}

	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x1CA62C0", Offset = "0x1CA62C0", VA = "0x1CA62C0")]
	public AnchorSpawner()
	{
	}
}
[Token(Token = "0x20001E8")]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x20001E9")]
	public enum AnchorMode
	{
		[Token(Token = "0x4000A7F")]
		Create,
		[Token(Token = "0x4000A80")]
		Select
	}

	[Token(Token = "0x20001EA")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x4000A6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x4000A6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject mainMenu_;

	[Token(Token = "0x4000A6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject createModeButton_;

	[Token(Token = "0x4000A6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject selectModeButton_;

	[Token(Token = "0x4000A70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform trackedDevice_;

	[Token(Token = "0x4000A71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform raycastOrigin_;

	[Token(Token = "0x4000A72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool drawRaycast_;

	[Token(Token = "0x4000A73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LineRenderer lineRenderer_;

	[Token(Token = "0x4000A74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor hoveredAnchor_;

	[Token(Token = "0x4000A75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Anchor selectedAnchor_;

	[Token(Token = "0x4000A76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AnchorMode mode_;

	[Token(Token = "0x4000A77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<Button> buttonList_;

	[Token(Token = "0x4000A78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int menuIndex_;

	[Token(Token = "0x4000A79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Button selectedButton_;

	[Token(Token = "0x4000A7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject placementPreview_;

	[Token(Token = "0x4000A7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform anchorPlacementTransform_;

	[Token(Token = "0x4000A7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate primaryPressDelegate_;

	[Token(Token = "0x4000A7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool isFocused_;

	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x1CA62C8", Offset = "0x1CA62C8", VA = "0x1CA62C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x1CA63A0", Offset = "0x1CA63A0", VA = "0x1CA63A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x1CA650C", Offset = "0x1CA650C", VA = "0x1CA650C")]
	private void Update()
	{
	}

	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x1CA6960", Offset = "0x1CA6960", VA = "0x1CA6960")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x1CA69D0", Offset = "0x1CA69D0", VA = "0x1CA69D0")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x60007DB")]
	[Address(RVA = "0x1CA6494", Offset = "0x1CA6494", VA = "0x1CA6494")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x1CA6A58", Offset = "0x1CA6A58", VA = "0x1CA6A58")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x1CA6AE0", Offset = "0x1CA6AE0", VA = "0x1CA6AE0")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x1CA6B0C", Offset = "0x1CA6B0C", VA = "0x1CA6B0C")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x60007DF")]
	[Address(RVA = "0x1CA6A2C", Offset = "0x1CA6A2C", VA = "0x1CA6A2C")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x1CA6850", Offset = "0x1CA6850", VA = "0x1CA6850")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x1CA6C48", Offset = "0x1CA6C48", VA = "0x1CA6C48")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x60007E2")]
	[Address(RVA = "0x1CA6B94", Offset = "0x1CA6B94", VA = "0x1CA6B94")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x1CA6BB4", Offset = "0x1CA6BB4", VA = "0x1CA6BB4")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x1CA6D60", Offset = "0x1CA6D60", VA = "0x1CA6D60")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x60007E5")]
	[Address(RVA = "0x1CA6BD4", Offset = "0x1CA6BD4", VA = "0x1CA6BD4")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x1CA6C10", Offset = "0x1CA6C10", VA = "0x1CA6C10")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x1CA6618", Offset = "0x1CA6618", VA = "0x1CA6618")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x1CA6DBC", Offset = "0x1CA6DBC", VA = "0x1CA6DBC")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x1CA6DF0", Offset = "0x1CA6DF0", VA = "0x1CA6DF0")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x1CA6E8C", Offset = "0x1CA6E8C", VA = "0x1CA6E8C")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x1CA7008", Offset = "0x1CA7008", VA = "0x1CA7008")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x20001EB")]
public class SpatialAnchorSession : AnchorSession
{
	[Token(Token = "0x4000A81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Dictionary<ulong, ulong> locateAnchorRequest;

	[Token(Token = "0x4000A82")]
	private const string numUuids = "numUuids";

	[Token(Token = "0x60007F0")]
	[Address(RVA = "0xE356F8", Offset = "0xE356F8", VA = "0xE356F8")]
	private void Start()
	{
	}

	[Token(Token = "0x60007F1")]
	[Address(RVA = "0xE35944", Offset = "0xE35944", VA = "0xE35944")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60007F2")]
	[Address(RVA = "0xE35B90", Offset = "0xE35B90", VA = "0xE35B90")]
	private void SpatialEntitySetComponentEnabled(ulong requestId, bool result, OVRPlugin.SpatialEntityComponentType componentType, ulong space)
	{
	}

	[Token(Token = "0x60007F3")]
	[Address(RVA = "0xE35DA0", Offset = "0xE35DA0", VA = "0xE35DA0")]
	private void SpatialAnchorSaved(ulong requestId, ulong space, bool result, OVRPlugin.SpatialEntityUuid uuid)
	{
	}

	[Token(Token = "0x60007F4")]
	[Address(RVA = "0xE36290", Offset = "0xE36290", VA = "0xE36290")]
	private void SpatialEntityStorageErase(ulong requestId, bool result, OVRPlugin.SpatialEntityUuid uuid, OVRPlugin.SpatialEntityStorageLocation location)
	{
	}

	[Token(Token = "0x60007F5")]
	[Address(RVA = "0xE365C0", Offset = "0xE365C0", VA = "0xE365C0")]
	private void SpatialEntityQueryResults(ulong requestId, int numResults, OVRPlugin.SpatialEntityQueryResult[] results)
	{
	}

	[Token(Token = "0x60007F6")]
	[Address(RVA = "0xE36CE4", Offset = "0xE36CE4", VA = "0xE36CE4")]
	private void SpatialEntityQueryComplete(ulong requestId, bool result, int numFound)
	{
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0xE361B4", Offset = "0xE361B4", VA = "0xE361B4")]
	private string GetUuidString(OVRPlugin.SpatialEntityUuid uuid)
	{
		return null;
	}

	[Token(Token = "0x60007F8")]
	[Address(RVA = "0xE368A8", Offset = "0xE368A8", VA = "0xE368A8")]
	private void tryEnableComponent(ulong anchorHandle, OVRPlugin.SpatialEntityComponentType type)
	{
	}

	[Token(Token = "0x60007F9")]
	[Address(RVA = "0xE35C80", Offset = "0xE35C80", VA = "0xE35C80")]
	private void CreateAnchorGameobject(ulong anchorHandle)
	{
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0xE36F38", Offset = "0xE36F38", VA = "0xE36F38")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0xE371E8", Offset = "0xE371E8", VA = "0xE371E8", Slot = "5")]
	public override ulong CreateSpatialAnchor(Transform T_UnityWorld_Anchor)
	{
		return default(ulong);
	}

	[Token(Token = "0x60007FC")]
	[Address(RVA = "0xE37388", Offset = "0xE37388", VA = "0xE37388", Slot = "6")]
	public override void DestroyAnchor(ulong anchorHandle)
	{
	}

	[Token(Token = "0x60007FD")]
	[Address(RVA = "0xE37544", Offset = "0xE37544", VA = "0xE37544", Slot = "8")]
	public override void EraseAnchor(ulong anchorHandle)
	{
	}

	[Token(Token = "0x60007FE")]
	[Address(RVA = "0xE37710", Offset = "0xE37710", VA = "0xE37710")]
	public void QueryAnchorByUuid()
	{
	}

	[Token(Token = "0x60007FF")]
	[Address(RVA = "0xE37A08", Offset = "0xE37A08", VA = "0xE37A08", Slot = "9")]
	public override void QueryAllLocalAnchors()
	{
	}

	[Token(Token = "0x6000800")]
	[Address(RVA = "0xE37AF8", Offset = "0xE37AF8", VA = "0xE37AF8", Slot = "7")]
	public override void SaveAnchor(ulong anchorHandle, StorageLocation location)
	{
	}

	[Token(Token = "0x6000801")]
	[Address(RVA = "0xE37C68", Offset = "0xE37C68", VA = "0xE37C68")]
	public SpatialAnchorSession()
	{
	}
}
[Token(Token = "0x20001EC")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x20001ED")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF78C", Offset = "0x9FF78C")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000A86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int sceneIndex;

		[Token(Token = "0x4000A87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StartMenu <>4__this;

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x14C4E74", Offset = "0x14C4E74", VA = "0x14C4E74")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x14C4E7C", Offset = "0x14C4E7C", VA = "0x14C4E7C")]
		internal void <Start>b__0()
		{
		}
	}

	[Token(Token = "0x4000A83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x4000A84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x4000A85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x6000802")]
	[Address(RVA = "0xE38DE4", Offset = "0xE38DE4", VA = "0xE38DE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000803")]
	[Address(RVA = "0xE39000", Offset = "0xE39000", VA = "0xE39000")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x6000804")]
	[Address(RVA = "0xE39110", Offset = "0xE39110", VA = "0xE39110")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x20001EE")]
public class Readme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20001EF")]
	public class Section
	{
		[Token(Token = "0x4000A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x4000A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x4000A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x14C3E3C", Offset = "0x14C3E3C", VA = "0x14C3E3C")]
		public Section()
		{
		}
	}

	[Token(Token = "0x4000A88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x4000A89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x4000A8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Section[] sections;

	[Token(Token = "0x4000A8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool loadedLayout;

	[Token(Token = "0x6000807")]
	[Address(RVA = "0xFF2E78", Offset = "0xFF2E78", VA = "0xFF2E78")]
	public Readme()
	{
	}
}
[Token(Token = "0x20001F0")]
public class ParticleFreezer : MonoBehaviour
{
	[Token(Token = "0x4000A90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem pS;

	[Token(Token = "0x4000A91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<ParticleSystem.Particle> enter;

	[Token(Token = "0x4000A92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject particleToFreeze;

	[Token(Token = "0x4000A93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Collider freezeZone;

	[Token(Token = "0x4000A94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA03084", Offset = "0xA03084")]
	[SerializeField]
	private int maxParticles;

	[Token(Token = "0x4000A95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private int frozenParticles;

	[Token(Token = "0x6000809")]
	[Address(RVA = "0xFECD24", Offset = "0xFECD24", VA = "0xFECD24")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600080A")]
	[Address(RVA = "0xFECF98", Offset = "0xFECF98", VA = "0xFECF98")]
	private void OnParticleTrigger()
	{
	}

	[Token(Token = "0x600080B")]
	[Address(RVA = "0xFED280", Offset = "0xFED280", VA = "0xFED280")]
	public ParticleFreezer()
	{
	}
}
[Token(Token = "0x20001F1")]
public class ChangeMaterialToButtonsColor : MonoBehaviour
{
	[Token(Token = "0x4000A96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Material m_mat;

	[Token(Token = "0x600080C")]
	[Address(RVA = "0x1CB85D0", Offset = "0x1CB85D0", VA = "0x1CB85D0")]
	public void ChangeColor(Button btn)
	{
	}

	[Token(Token = "0x600080D")]
	[Address(RVA = "0x1CB8808", Offset = "0x1CB8808", VA = "0x1CB8808")]
	public ChangeMaterialToButtonsColor()
	{
	}
}
[Token(Token = "0x20001F2")]
public class ShowMenuOnClick : MonoBehaviour, IColliderEventClickHandler, IEventSystemHandler, IColliderEventPressEnterHandler, IColliderEventPressExitHandler
{
	[Token(Token = "0x4000A97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject effectMenu;

	[Token(Token = "0x4000A98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ControllerManagerSample controllerManager;

	[Token(Token = "0x4000A99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ColliderButtonEventData.InputButton m_activeButton;

	[Token(Token = "0x4000A9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform buttonObject;

	[Token(Token = "0x4000A9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 buttonDownDisplacement;

	[Token(Token = "0x4000A9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 buttonOriginPosition;

	[Token(Token = "0x4000A9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool menuVisible;

	[Token(Token = "0x4000A9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private HashSet<ColliderButtonEventData> pressingEvents;

	[Token(Token = "0x170000AF")]
	public ColliderButtonEventData.InputButton activeButton
	{
		[Token(Token = "0x600080E")]
		[Address(RVA = "0xE301E4", Offset = "0xE301E4", VA = "0xE301E4")]
		get
		{
			return default(ColliderButtonEventData.InputButton);
		}
		[Token(Token = "0x600080F")]
		[Address(RVA = "0xE301EC", Offset = "0xE301EC", VA = "0xE301EC")]
		set
		{
		}
	}

	[Token(Token = "0x6000810")]
	[Address(RVA = "0xE301F4", Offset = "0xE301F4", VA = "0xE301F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000811")]
	[Address(RVA = "0xE30234", Offset = "0xE30234", VA = "0xE30234")]
	public void SetMenuVisible(bool value)
	{
	}

	[Token(Token = "0x6000812")]
	[Address(RVA = "0xE302C0", Offset = "0xE302C0", VA = "0xE302C0", Slot = "4")]
	public void OnColliderEventClick(ColliderButtonEventData eventData)
	{
	}

	[Token(Token = "0x6000813")]
	[Address(RVA = "0xE3036C", Offset = "0xE3036C", VA = "0xE3036C", Slot = "5")]
	public void OnColliderEventPressEnter(ColliderButtonEventData eventData)
	{
	}

	[Token(Token = "0x6000814")]
	[Address(RVA = "0xE30480", Offset = "0xE30480", VA = "0xE30480", Slot = "6")]
	public void OnColliderEventPressExit(ColliderButtonEventData eventData)
	{
	}

	[Token(Token = "0x6000815")]
	[Address(RVA = "0xE3052C", Offset = "0xE3052C", VA = "0xE3052C")]
	public ShowMenuOnClick()
	{
	}
}
[Token(Token = "0x20001F3")]
public class SpawnObjectOnTriggerExit : MonoBehaviour
{
	[Token(Token = "0x20001F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF79C", Offset = "0x9FF79C")]
	private sealed class <CopyTarget>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpawnObjectOnTriggerExit <>4__this;

		[Token(Token = "0x170000B0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x14C4954", Offset = "0x14C4954", VA = "0x14C4954", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x14C499C", Offset = "0x14C499C", VA = "0x14C499C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x14C475C", Offset = "0x14C475C", VA = "0x14C475C")]
		[DebuggerHidden]
		public <CopyTarget>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x14C4788", Offset = "0x14C4788", VA = "0x14C4788", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x14C478C", Offset = "0x14C478C", VA = "0x14C478C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x14C495C", Offset = "0x14C495C", VA = "0x14C495C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000A9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject effectTarget;

	[Token(Token = "0x4000AA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float delay;

	[Token(Token = "0x4000AA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 originPosition;

	[Token(Token = "0x4000AA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Quaternion originRotation;

	[Token(Token = "0x4000AA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject clonedTarget;

	[Token(Token = "0x6000816")]
	[Address(RVA = "0xE37CEC", Offset = "0xE37CEC", VA = "0xE37CEC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000817")]
	[Address(RVA = "0xE37D64", Offset = "0xE37D64", VA = "0xE37D64")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000818")]
	[Address(RVA = "0xE37E30", Offset = "0xE37E30", VA = "0xE37E30")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA07C24", Offset = "0xA07C24")]
	private IEnumerator CopyTarget()
	{
		return null;
	}

	[Token(Token = "0x6000819")]
	[Address(RVA = "0xE37EA8", Offset = "0xE37EA8", VA = "0xE37EA8")]
	public SpawnObjectOnTriggerExit()
	{
	}
}
[Token(Token = "0x20001F5")]
public class ShortcutCameraTeaserBelfry : MonoBehaviour
{
	[Token(Token = "0x4000AA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject _cameraRig;

	[Token(Token = "0x4000AA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject _cameraJoypad;

	[Token(Token = "0x4000AA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject _plateform;

	[Token(Token = "0x4000AAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public PlayableDirector playable;

	[Token(Token = "0x6000820")]
	[Address(RVA = "0xE2F1F0", Offset = "0xE2F1F0", VA = "0xE2F1F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000821")]
	[Address(RVA = "0xE2F2C4", Offset = "0xE2F2C4", VA = "0xE2F2C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000822")]
	[Address(RVA = "0xE2F43C", Offset = "0xE2F43C", VA = "0xE2F43C")]
	private void _SetParent(GameObject child, GameObject parent)
	{
	}

	[Token(Token = "0x6000823")]
	[Address(RVA = "0xE2F53C", Offset = "0xE2F53C", VA = "0xE2F53C")]
	public ShortcutCameraTeaserBelfry()
	{
	}
}
[Token(Token = "0x20001F6")]
public class ShortcutCameraTeaserChoir : MonoBehaviour
{
	[Token(Token = "0x4000AAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject _cameraRig;

	[Token(Token = "0x4000AAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject _cameraJoypad;

	[Token(Token = "0x4000AAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject _cameraAutoAnimated;

	[Token(Token = "0x4000AAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject _oculus;

	[Token(Token = "0x4000AAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PlayableDirector playable;

	[Token(Token = "0x6000824")]
	[Address(RVA = "0xE2F544", Offset = "0xE2F544", VA = "0xE2F544")]
	private void Start()
	{
	}

	[Token(Token = "0x6000825")]
	[Address(RVA = "0xE2F638", Offset = "0xE2F638", VA = "0xE2F638")]
	private void Update()
	{
	}

	[Token(Token = "0x6000826")]
	[Address(RVA = "0xE2F82C", Offset = "0xE2F82C", VA = "0xE2F82C")]
	private void _SetParent(GameObject child, GameObject parent)
	{
	}

	[Token(Token = "0x6000827")]
	[Address(RVA = "0xE2F92C", Offset = "0xE2F92C", VA = "0xE2F92C")]
	public ShortcutCameraTeaserChoir()
	{
	}
}
[Token(Token = "0x20001F7")]
public class SetActiveCamera : MonoBehaviour
{
	[Token(Token = "0x4000AB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera captureCamera;

	[Token(Token = "0x4000AB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera backupCamera;

	[Token(Token = "0x6000828")]
	[Address(RVA = "0xE2E0B4", Offset = "0xE2E0B4", VA = "0xE2E0B4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000829")]
	[Address(RVA = "0xE2E20C", Offset = "0xE2E20C", VA = "0xE2E20C")]
	public SetActiveCamera()
	{
	}
}
namespace HTC.UnityPlugin.Vive.VIUExample
{
	[Token(Token = "0x20001F8")]
	public class ModeManager : MonoBehaviour
	{
		[Token(Token = "0x20001F9")]
		public enum Mode
		{
			[Token(Token = "0x4000ABA")]
			Default,
			[Token(Token = "0x4000ABB")]
			Teleport,
			[Token(Token = "0x4000ABC")]
			Menu
		}

		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode initMode;

		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DefaultTooltipRenderer tooltipRenderer;

		[Token(Token = "0x4000AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DefaultTooltipRenderDataAsset teleportTooltip;

		[Token(Token = "0x4000AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DefaultTooltipRenderDataAsset menuTooltip;

		[Token(Token = "0x4000AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject teleportPointers;

		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject selectColorUI;

		[Token(Token = "0x4000AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Mode currentMode;

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x123CB98", Offset = "0x123CB98", VA = "0x123CB98")]
		private void Awake()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x123CBBC", Offset = "0x123CBBC", VA = "0x123CBBC")]
		public void SwitchToTeleportMode()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x123CC08", Offset = "0x123CC08", VA = "0x123CC08")]
		public void SwitchToMenuMode()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x123CBC4", Offset = "0x123CBC4", VA = "0x123CBC4")]
		private void SwitchMode(Mode mode)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x123CBA0", Offset = "0x123CBA0", VA = "0x123CBA0")]
		private void EnterMode(Mode mode)
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x123CC10", Offset = "0x123CC10", VA = "0x123CC10")]
		private void ExitMode(Mode mode)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x123CC2C", Offset = "0x123CC2C", VA = "0x123CC2C")]
		private void EnterTeleportMode()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x123CE3C", Offset = "0x123CE3C", VA = "0x123CE3C")]
		private void ExitTeleportMode()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x123CD34", Offset = "0x123CD34", VA = "0x123CD34")]
		private void EnterMenuMode()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x123CF40", Offset = "0x123CF40", VA = "0x123CF40")]
		private void ExitMenuMode()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x123D044", Offset = "0x123D044", VA = "0x123D044")]
		public ModeManager()
		{
		}
	}
	[Token(Token = "0x20001FA")]
	public class SelectColorUIController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001FB")]
		public class UnityEventColor : UnityEvent<Color>
		{
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x14C41B0", Offset = "0x14C41B0", VA = "0x14C41B0")]
			public UnityEventColor()
			{
			}
		}

		[Token(Token = "0x20001FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF7AC", Offset = "0x9FF7AC")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000AC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SelectColorUIController <>4__this;

			[Token(Token = "0x4000AC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Toggle toggle;

			[Token(Token = "0x600083B")]
			[Address(RVA = "0x14C417C", Offset = "0x14C417C", VA = "0x14C417C")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600083C")]
			[Address(RVA = "0x14C4184", Offset = "0x14C4184", VA = "0x14C4184")]
			internal void <CreateAction>b__0(bool isOn)
			{
			}
		}

		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle[] colorToggles;

		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEventColor onColorSelected;

		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityAction<bool>[] toggleCallbacks;

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xE2CAA0", Offset = "0xE2CAA0", VA = "0xE2CAA0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xE2CC44", Offset = "0xE2CC44", VA = "0xE2CC44")]
		private UnityAction<bool> CreateAction(Toggle toggle)
		{
			return null;
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xE2CD2C", Offset = "0xE2CD2C", VA = "0xE2CD2C")]
		private void OnToggleValueChanged(Toggle toggle, bool isOn)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xE2CDC4", Offset = "0xE2CDC4", VA = "0xE2CDC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xE2CE90", Offset = "0xE2CE90", VA = "0xE2CE90")]
		public SelectColorUIController()
		{
		}
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x20001FD")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x170000B2")]
		public bool Highlight
		{
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x1CBC528", Offset = "0x1CBC528", VA = "0x1CBC528")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x1CBC530", Offset = "0x1CBC530", VA = "0x1CBC530")]
			set
			{
			}
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x1CBC53C", Offset = "0x1CBC53C", VA = "0x1CBC53C")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x1CBC704", Offset = "0x1CBC704", VA = "0x1CBC704", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x1CBC72C", Offset = "0x1CBC72C", VA = "0x1CBC72C", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x1CBC754", Offset = "0x1CBC754", VA = "0x1CBC754")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x1CBC604", Offset = "0x1CBC604", VA = "0x1CBC604")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1CBCA28", Offset = "0x1CBCA28", VA = "0x1CBCA28")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x20001FE")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x170000B3")]
		public bool InRange
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x1D1B5C0", Offset = "0x1D1B5C0", VA = "0x1D1B5C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x1D1B5C8", Offset = "0x1D1B5C8", VA = "0x1D1B5C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public bool Targeted
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x1D1B740", Offset = "0x1D1B740", VA = "0x1D1B740")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x1D1B748", Offset = "0x1D1B748", VA = "0x1D1B748")]
			set
			{
			}
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x1D1B754", Offset = "0x1D1B754", VA = "0x1D1B754", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x1D1B5D4", Offset = "0x1D1B5D4", VA = "0x1D1B5D4")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x1D1B95C", Offset = "0x1D1B95C", VA = "0x1D1B95C")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x20001FF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9FF7BC", Offset = "0x9FF7BC")]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x4000ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x4000ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x4000AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x4000AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x4000AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x4000AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x4000AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x4000AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x4000AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x4000AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x4000ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x170000B5")]
		public bool UseSpherecast
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x1D1B964", Offset = "0x1D1B964", VA = "0x1D1B964")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x1D1B96C", Offset = "0x1D1B96C", VA = "0x1D1B96C")]
			set
			{
			}
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x1D1B988", Offset = "0x1D1B988", VA = "0x1D1B988", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x1D1BBC8", Offset = "0x1D1BBC8", VA = "0x1D1BBC8", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x1D1C4E0", Offset = "0x1D1C4E0", VA = "0x1D1C4E0", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1D1C974", Offset = "0x1D1C974", VA = "0x1D1C974", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x1D1CC34", Offset = "0x1D1CC34", VA = "0x1D1CC34")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x1D1BE3C", Offset = "0x1D1BE3C", VA = "0x1D1BE3C")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x1D1CD24", Offset = "0x1D1CD24", VA = "0x1D1CD24")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x1D1D180", Offset = "0x1D1D180", VA = "0x1D1D180", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x1D1D198", Offset = "0x1D1D198", VA = "0x1D1D198", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x1D1D1A0", Offset = "0x1D1D1A0", VA = "0x1D1D1A0")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x2000200")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x4000ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x4000ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x4000ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x4000ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x1D27728", Offset = "0x1D27728", VA = "0x1D27728")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x1D277E0", Offset = "0x1D277E0", VA = "0x1D277E0")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x1D27894", Offset = "0x1D27894", VA = "0x1D27894")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x2000201")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x2000202")]
		public enum CrosshairState
		{
			[Token(Token = "0x4000AE4")]
			Disabled,
			[Token(Token = "0x4000AE5")]
			Enabled,
			[Token(Token = "0x4000AE6")]
			Targeted
		}

		[Token(Token = "0x4000ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x4000AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x4000AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x4000AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x1D27954", Offset = "0x1D27954", VA = "0x1D27954")]
		private void Start()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x1D1B8C0", Offset = "0x1D1B8C0", VA = "0x1D1B8C0")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x1D279C0", Offset = "0x1D279C0", VA = "0x1D279C0")]
		private void Update()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x1D27A08", Offset = "0x1D27A08", VA = "0x1D27A08")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x2000203")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x6000860")]
		[Address(RVA = "0xFEF30C", Offset = "0xFEF30C", VA = "0xFEF30C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xFEF3F8", Offset = "0xFEF3F8", VA = "0xFEF3F8")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xFEF404", Offset = "0xFEF404", VA = "0xFEF404")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xFEF410", Offset = "0xFEF410", VA = "0xFEF410")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x2000204")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x4000AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x4000AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x4000AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x1CADF68", Offset = "0x1CADF68", VA = "0x1CADF68")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x1CADFBC", Offset = "0x1CADFBC", VA = "0x1CADFBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x1CAE328", Offset = "0x1CAE328", VA = "0x1CAE328")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x1CAE42C", Offset = "0x1CAE42C", VA = "0x1CAE42C")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x1CADFC0", Offset = "0x1CADFC0", VA = "0x1CADFC0")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x1CAE530", Offset = "0x1CAE530", VA = "0x1CAE530")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x2000205")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x2000206")]
		public enum ContactTest
		{
			[Token(Token = "0x4000AF9")]
			PerpenTest,
			[Token(Token = "0x4000AFA")]
			BackwardsPress
		}

		[Token(Token = "0x4000AEA")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x4000AEB")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x4000AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x4000AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x4000AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x4000AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x4000AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x4000AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x4000AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x4000AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x4000AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x4000AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x4000AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA03218", Offset = "0xA03218")]
		private InteractableState <CurrentButtonState>k__BackingField;

		[Token(Token = "0x4000AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x170000B6")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x1CAEC28", Offset = "0x1CAEC28", VA = "0x1CAEC28", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B7")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x1CAEC30", Offset = "0x1CAEC30", VA = "0x1CAEC30")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B8")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x1CAEC3C", Offset = "0x1CAEC3C", VA = "0x1CAEC3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07CD4", Offset = "0xA07CD4")]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x1CAEC44", Offset = "0x1CAEC44", VA = "0x1CAEC44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07CE4", Offset = "0xA07CE4")]
			private set
			{
			}
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x1CAEC4C", Offset = "0x1CAEC4C", VA = "0x1CAEC4C", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x1CAED60", Offset = "0x1CAED60", VA = "0x1CAED60")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x1CAEF78", Offset = "0x1CAEF78", VA = "0x1CAEF78", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x1CAF52C", Offset = "0x1CAF52C", VA = "0x1CAF52C")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x1CAF5D8", Offset = "0x1CAF5D8", VA = "0x1CAF5D8")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x1CAF444", Offset = "0x1CAF444", VA = "0x1CAF444")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x1CAF6E0", Offset = "0x1CAF6E0", VA = "0x1CAF6E0")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x1CAF764", Offset = "0x1CAF764", VA = "0x1CAF764")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x1CAF7F0", Offset = "0x1CAF7F0", VA = "0x1CAF7F0")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x2000207")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x4000AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x4000AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA03238", Offset = "0xA03238")]
		private Collider <Collider>k__BackingField;

		[Token(Token = "0x4000AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA03248", Offset = "0xA03248")]
		private Interactable <ParentInteractable>k__BackingField;

		[Token(Token = "0x170000B9")]
		public Collider Collider
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x1CAFA3C", Offset = "0x1CAFA3C", VA = "0x1CAFA3C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07CF4", Offset = "0xA07CF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x1CAFA44", Offset = "0x1CAFA44", VA = "0x1CAFA44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07D04", Offset = "0xA07D04")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x1CAFA4C", Offset = "0x1CAFA4C", VA = "0x1CAFA4C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07D14", Offset = "0xA07D14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x1CAFA54", Offset = "0x1CAFA54", VA = "0x1CAFA54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07D24", Offset = "0xA07D24")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x600087B")]
			[Address(RVA = "0x1CAFA5C", Offset = "0x1CAFA5C", VA = "0x1CAFA5C", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x1CAFAAC", Offset = "0x1CAFAAC", VA = "0x1CAFAAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x1CAFB40", Offset = "0x1CAFB40", VA = "0x1CAFB40")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x2000208")]
	public interface ColliderZone
	{
		[Token(Token = "0x170000BC")]
		Collider Collider
		{
			[Token(Token = "0x600087E")]
			get;
		}

		[Token(Token = "0x170000BD")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x600087F")]
			get;
		}

		[Token(Token = "0x170000BE")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000880")]
			get;
		}
	}
	[Token(Token = "0x2000209")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x4000AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x4000B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x4000B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x1CAEEC0", Offset = "0x1CAEEC0", VA = "0x1CAEEC0")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x200020A")]
	public enum InteractionType
	{
		[Token(Token = "0x4000B03")]
		Enter,
		[Token(Token = "0x4000B04")]
		Stay,
		[Token(Token = "0x4000B05")]
		Exit
	}
	[Token(Token = "0x200020B")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x200020C")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x4000B17")]
			Mesh,
			[Token(Token = "0x4000B18")]
			Skeleton,
			[Token(Token = "0x4000B19")]
			Both
		}

		[Token(Token = "0x200020D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF81C", Offset = "0x9FF81C")]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x170000CA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A3")]
				[Address(RVA = "0x1DBC5B4", Offset = "0x1DBC5B4", VA = "0x1DBC5B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A5")]
				[Address(RVA = "0x1DBC5FC", Offset = "0x1DBC5FC", VA = "0x1DBC5FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x1DBC320", Offset = "0x1DBC320", VA = "0x1DBC320")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x1DBC34C", Offset = "0x1DBC34C", VA = "0x1DBC34C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x1DBC350", Offset = "0x1DBC350", VA = "0x1DBC350", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x1DBC5BC", Offset = "0x1DBC5BC", VA = "0x1DBC5BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B06")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x4000B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x4000B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x4000B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x4000B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x4000B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x4000B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x4000B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x4000B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x4000B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x4000B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x4000B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x4000B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x4000B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x4000B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x4000B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA03278", Offset = "0xA03278")]
		private static HandsManager <Instance>k__BackingField;

		[Token(Token = "0x170000BF")]
		public OVRHand RightHand
		{
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x1E6443C", Offset = "0x1E6443C", VA = "0x1E6443C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x1E64474", Offset = "0x1E64474", VA = "0x1E64474")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x1E644E4", Offset = "0x1E644E4", VA = "0x1E644E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x1E6451C", Offset = "0x1E6451C", VA = "0x1E6451C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x1E6458C", Offset = "0x1E6458C", VA = "0x1E6458C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x1E645C4", Offset = "0x1E645C4", VA = "0x1E645C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x1E64634", Offset = "0x1E64634", VA = "0x1E64634")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x1E6466C", Offset = "0x1E6466C", VA = "0x1E6466C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x1E646DC", Offset = "0x1E646DC", VA = "0x1E646DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x1E64714", Offset = "0x1E64714", VA = "0x1E64714")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x1E64784", Offset = "0x1E64784", VA = "0x1E64784")]
			get
			{
				return null;
			}
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x1E647B8", Offset = "0x1E647B8", VA = "0x1E647B8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x1E64824", Offset = "0x1E64824", VA = "0x1E64824")]
			get
			{
				return null;
			}
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x1E64858", Offset = "0x1E64858", VA = "0x1E64858")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x1E648C4", Offset = "0x1E648C4", VA = "0x1E648C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x1E648F8", Offset = "0x1E648F8", VA = "0x1E648F8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x1E64964", Offset = "0x1E64964", VA = "0x1E64964")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000893")]
			[Address(RVA = "0x1E64998", Offset = "0x1E64998", VA = "0x1E64998")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x1E64A04", Offset = "0x1E64A04", VA = "0x1E64A04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x1E64A38", Offset = "0x1E64A38", VA = "0x1E64A38")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public static HandsManager Instance
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x1E64AA4", Offset = "0x1E64AA4", VA = "0x1E64AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07D34", Offset = "0xA07D34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x1E64AF0", Offset = "0x1E64AF0", VA = "0x1E64AF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07D44", Offset = "0xA07D44")]
			private set
			{
			}
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x1E64B44", Offset = "0x1E64B44", VA = "0x1E64B44")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x1E64F18", Offset = "0x1E64F18", VA = "0x1E64F18")]
		private void Update()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x1E64EA0", Offset = "0x1E64EA0", VA = "0x1E64EA0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA07D54", Offset = "0xA07D54")]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x1E64FA0", Offset = "0x1E64FA0", VA = "0x1E64FA0")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x1E65084", Offset = "0x1E65084", VA = "0x1E65084")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x1E65264", Offset = "0x1E65264", VA = "0x1E65264")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x1E654A0", Offset = "0x1E654A0", VA = "0x1E654A0")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x1E6562C", Offset = "0x1E6562C", VA = "0x1E6562C")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x200020E")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200020F")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x1DBC7D0", Offset = "0x1DBC7D0", VA = "0x1DBC7D0")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x4000B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x170000CC")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x1E660C0", Offset = "0x1E660C0", VA = "0x1E660C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x1E660C8", Offset = "0x1E660C8", VA = "0x1E660C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x1E660D0", Offset = "0x1E660D0", VA = "0x1E660D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x1E660D8", Offset = "0x1E660D8", VA = "0x1E660D8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x1E660E0", Offset = "0x1E660E0", VA = "0x1E660E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07E04", Offset = "0xA07E04")]
			add
			{
			}
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x1E66180", Offset = "0x1E66180", VA = "0x1E66180")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07E14", Offset = "0xA07E14")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x1E66290", Offset = "0x1E66290", VA = "0x1E66290")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07E24", Offset = "0xA07E24")]
			add
			{
			}
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x1E66330", Offset = "0x1E66330", VA = "0x1E66330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07E34", Offset = "0xA07E34")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x1E66440", Offset = "0x1E66440", VA = "0x1E66440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07E44", Offset = "0xA07E44")]
			add
			{
			}
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x1E664E0", Offset = "0x1E664E0", VA = "0x1E664E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07E54", Offset = "0xA07E54")]
			remove
			{
			}
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x1E66220", Offset = "0x1E66220", VA = "0x1E66220", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x1E663D0", Offset = "0x1E663D0", VA = "0x1E663D0", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x1E66580", Offset = "0x1E66580", VA = "0x1E66580", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60008B3")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1E665F0", Offset = "0x1E665F0", VA = "0x1E665F0", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1E6671C", Offset = "0x1E6671C", VA = "0x1E6671C", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x1E66848", Offset = "0x1E66848", VA = "0x1E66848")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x2000210")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x4000B25")]
		None,
		[Token(Token = "0x4000B26")]
		Proximity,
		[Token(Token = "0x4000B27")]
		Contact,
		[Token(Token = "0x4000B28")]
		Action
	}
	[Token(Token = "0x2000211")]
	public enum InteractableState
	{
		[Token(Token = "0x4000B2A")]
		Default,
		[Token(Token = "0x4000B2B")]
		ProximityState,
		[Token(Token = "0x4000B2C")]
		ContactState,
		[Token(Token = "0x4000B2D")]
		ActionState
	}
	[Token(Token = "0x2000212")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x4000B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x4000B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x4000B30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x4000B31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x4000B32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x1E669A0", Offset = "0x1E669A0", VA = "0x1E669A0")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x2000213")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x4000B33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x170000D0")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x1E668A8", Offset = "0x1E668A8", VA = "0x1E668A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x1E66650", Offset = "0x1E66650", VA = "0x1E66650")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x1E6677C", Offset = "0x1E6677C", VA = "0x1E6677C")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x1E6690C", Offset = "0x1E6690C", VA = "0x1E6690C")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x2000214")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x2000215")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF82C", Offset = "0x9FF82C")]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x4000B39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x4000B3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x4000B3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x4000B3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000B3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x4000B3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x170000D1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008C6")]
				[Address(RVA = "0x1DBCD34", Offset = "0x1DBCD34", VA = "0x1DBCD34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008C8")]
				[Address(RVA = "0x1DBCD7C", Offset = "0x1DBCD7C", VA = "0x1DBCD7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x1DBC81C", Offset = "0x1DBC81C", VA = "0x1DBC81C")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x1DBC848", Offset = "0x1DBC848", VA = "0x1DBC848", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x1DBC8B8", Offset = "0x1DBC8B8", VA = "0x1DBC8B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x1DBC864", Offset = "0x1DBC864", VA = "0x1DBC864")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x1DBCD3C", Offset = "0x1DBCD3C", VA = "0x1DBCD3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x4000B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x1E67724", Offset = "0x1E67724", VA = "0x1E67724")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x1E677A0", Offset = "0x1E677A0", VA = "0x1E677A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA07E64", Offset = "0xA07E64")]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x1E67840", Offset = "0x1E67840", VA = "0x1E67840")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x1E67928", Offset = "0x1E67928", VA = "0x1E67928")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x2000216")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x4000B3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x4000B40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x4000B41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x4000B42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x4000B43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x4000B44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x4000B45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x170000D3")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x1E67930", Offset = "0x1E67930", VA = "0x1E67930")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x1E67AB0", Offset = "0x1E67AB0", VA = "0x1E67AB0")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x1E67B58", Offset = "0x1E67B58", VA = "0x1E67B58")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1E67C00", Offset = "0x1E67C00", VA = "0x1E67C00")]
		private void Update()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1E67EAC", Offset = "0x1E67EAC", VA = "0x1E67EAC")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x1E67EF4", Offset = "0x1E67EF4", VA = "0x1E67EF4")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x1E681A4", Offset = "0x1E681A4", VA = "0x1E681A4")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x1E682F0", Offset = "0x1E682F0", VA = "0x1E682F0")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x2000217")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x2000218")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF83C", Offset = "0x9FF83C")]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x170000D8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008E2")]
				[Address(RVA = "0x1DBB430", Offset = "0x1DBB430", VA = "0x1DBB430", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008E4")]
				[Address(RVA = "0x1DBB478", Offset = "0x1DBB478", VA = "0x1DBB478", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x1DBAFFC", Offset = "0x1DBAFFC", VA = "0x1DBAFFC")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x1DBB028", Offset = "0x1DBB028", VA = "0x1DBB028", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x1DBB02C", Offset = "0x1DBB02C", VA = "0x1DBB02C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x1DBB438", Offset = "0x1DBB438", VA = "0x1DBB438", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B46")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x4000B47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x4000B48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x4000B49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x4000B4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x4000B4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x4000B4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x4000B4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x4000B4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x4000B4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x4000B50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x170000D4")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x1D21B5C", Offset = "0x1D21B5C", VA = "0x1D21B5C", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000D5")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x1D21B64", Offset = "0x1D21B64", VA = "0x1D21B64", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000D6")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x1D21B6C", Offset = "0x1D21B6C", VA = "0x1D21B6C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D7")]
		public override bool EnableState
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x1D21B74", Offset = "0x1D21B74", VA = "0x1D21B74", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x1D21BA0", Offset = "0x1D21BA0", VA = "0x1D21BA0", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x1D21BDC", Offset = "0x1D21BDC", VA = "0x1D21BDC", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x1D21C94", Offset = "0x1D21C94", VA = "0x1D21C94")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA07F14", Offset = "0xA07F14")]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x1D21D0C", Offset = "0x1D21D0C", VA = "0x1D21D0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x1D21FAC", Offset = "0x1D21FAC", VA = "0x1D21FAC")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x1D22138", Offset = "0x1D22138", VA = "0x1D22138")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x1D22230", Offset = "0x1D22230", VA = "0x1D22230", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x1D22528", Offset = "0x1D22528", VA = "0x1D22528", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x1D2252C", Offset = "0x1D2252C", VA = "0x1D2252C", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x1D22530", Offset = "0x1D22530", VA = "0x1D22530")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x2000219")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000B54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x4000B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA03308", Offset = "0xA03308")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x4000B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA03318", Offset = "0xA03318")]
		private bool <ToolActivateState>k__BackingField;

		[Token(Token = "0x4000B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA03328", Offset = "0xA03328")]
		private float <SphereRadius>k__BackingField;

		[Token(Token = "0x170000DA")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x1D22548", Offset = "0x1D22548", VA = "0x1D22548", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07FC4", Offset = "0xA07FC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x1D22550", Offset = "0x1D22550", VA = "0x1D22550")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07FD4", Offset = "0xA07FD4")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public bool EnableState
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x1D22558", Offset = "0x1D22558", VA = "0x1D22558", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x1D22574", Offset = "0x1D22574", VA = "0x1D22574", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x1D22594", Offset = "0x1D22594", VA = "0x1D22594", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07FE4", Offset = "0xA07FE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x1D2259C", Offset = "0x1D2259C", VA = "0x1D2259C", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA07FF4", Offset = "0xA07FF4")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public float SphereRadius
		{
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x1D225A8", Offset = "0x1D225A8", VA = "0x1D225A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08004", Offset = "0xA08004")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x1D225B0", Offset = "0x1D225B0", VA = "0x1D225B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08014", Offset = "0xA08014")]
			private set
			{
			}
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x1D225B8", Offset = "0x1D225B8", VA = "0x1D225B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x1D22600", Offset = "0x1D22600", VA = "0x1D22600", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x1D22604", Offset = "0x1D22604", VA = "0x1D22604")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x200021A")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x4000B59")]
		None = 0,
		[Token(Token = "0x4000B5A")]
		Ray = 1,
		[Token(Token = "0x4000B5B")]
		Poke = 4,
		[Token(Token = "0x4000B5C")]
		All = -1
	}
	[Token(Token = "0x200021B")]
	public enum ToolInputState
	{
		[Token(Token = "0x4000B5E")]
		Inactive,
		[Token(Token = "0x4000B5F")]
		PrimaryInputDown,
		[Token(Token = "0x4000B60")]
		PrimaryInputDownStay,
		[Token(Token = "0x4000B61")]
		PrimaryInputUp
	}
	[Token(Token = "0x200021C")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x4000B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x4000B63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x4000B64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x1E66850", Offset = "0x1E66850", VA = "0x1E66850")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x200021D")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x4000B65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA03338", Offset = "0xA03338")]
		private bool <IsRightHandedTool>k__BackingField;

		[Token(Token = "0x4000B66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA03348", Offset = "0xA03348")]
		private Vector3 <Velocity>k__BackingField;

		[Token(Token = "0x4000B67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA03358", Offset = "0xA03358")]
		private Vector3 <InteractionPosition>k__BackingField;

		[Token(Token = "0x4000B68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x4000B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x4000B6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x4000B6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x4000B6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x4000B6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x170000DE")]
		public Transform ToolTransform
		{
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x1E66A64", Offset = "0x1E66A64", VA = "0x1E66A64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DF")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x1E66A6C", Offset = "0x1E66A6C", VA = "0x1E66A6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08024", Offset = "0xA08024")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1E66A74", Offset = "0x1E66A74", VA = "0x1E66A74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08034", Offset = "0xA08034")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x60008F4")]
			get;
		}

		[Token(Token = "0x170000E1")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x60008F5")]
			get;
		}

		[Token(Token = "0x170000E2")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x60008F6")]
			get;
		}

		[Token(Token = "0x170000E3")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x1E66A80", Offset = "0x1E66A80", VA = "0x1E66A80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08044", Offset = "0xA08044")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x1E66A8C", Offset = "0x1E66A8C", VA = "0x1E66A8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08054", Offset = "0xA08054")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x1E66A98", Offset = "0x1E66A98", VA = "0x1E66A98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08064", Offset = "0xA08064")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x1E66AA4", Offset = "0x1E66AA4", VA = "0x1E66AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08074", Offset = "0xA08074")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public abstract bool EnableState
		{
			[Token(Token = "0x60008FF")]
			get;
			[Token(Token = "0x6000900")]
			set;
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x1E66AB0", Offset = "0x1E66AB0", VA = "0x1E66AB0")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60008FC")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x60008FD")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x60008FE")]
		public abstract void DeFocus();

		[Token(Token = "0x6000901")]
		public abstract void Initialize();

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x1E66AB8", Offset = "0x1E66AB8", VA = "0x1E66AB8")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x1E66B04", Offset = "0x1E66B04", VA = "0x1E66B04")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x1E66B58", Offset = "0x1E66B58", VA = "0x1E66B58", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x1E66E08", Offset = "0x1E66E08", VA = "0x1E66E08", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x1E67594", Offset = "0x1E67594", VA = "0x1E67594")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x200021E")]
	public interface InteractableToolView
	{
		[Token(Token = "0x170000E6")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x6000907")]
			get;
		}

		[Token(Token = "0x170000E7")]
		bool EnableState
		{
			[Token(Token = "0x6000909")]
			get;
			[Token(Token = "0x600090A")]
			set;
		}

		[Token(Token = "0x170000E8")]
		bool ToolActivateState
		{
			[Token(Token = "0x600090B")]
			get;
			[Token(Token = "0x600090C")]
			set;
		}

		[Token(Token = "0x6000908")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x200021F")]
	public class PinchStateModule
	{
		[Token(Token = "0x2000220")]
		private enum PinchState
		{
			[Token(Token = "0x4000B72")]
			None,
			[Token(Token = "0x4000B73")]
			PinchDown,
			[Token(Token = "0x4000B74")]
			PinchStay,
			[Token(Token = "0x4000B75")]
			PinchUp
		}

		[Token(Token = "0x4000B6E")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x4000B6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x4000B70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x170000E9")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0xFF02E0", Offset = "0xFF02E0", VA = "0xFF02E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EA")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0xFF0368", Offset = "0xFF0368", VA = "0xFF0368")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EB")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x600090F")]
			[Address(RVA = "0xFF03F0", Offset = "0xFF03F0", VA = "0xFF03F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xFF0478", Offset = "0xFF0478", VA = "0xFF0478")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xFF04AC", Offset = "0xFF04AC", VA = "0xFF04AC")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x2000221")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x4000B76")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x4000B77")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x4000B78")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x4000B79")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x4000B7A")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x4000B7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x4000B7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA03378", Offset = "0xA03378")]
		private float _coneAngleDegrees;

		[Token(Token = "0x4000B7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x4000B7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x4000B7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x4000B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x4000B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x4000B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x4000B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x4000B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x4000B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x170000EC")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000912")]
			[Address(RVA = "0xFF13F4", Offset = "0xFF13F4", VA = "0xFF13F4", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000ED")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000913")]
			[Address(RVA = "0xFF13FC", Offset = "0xFF13FC", VA = "0xFF13FC", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000EE")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0xFF1464", Offset = "0xFF1464", VA = "0xFF1464", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EF")]
		public override bool EnableState
		{
			[Token(Token = "0x6000915")]
			[Address(RVA = "0xFF146C", Offset = "0xFF146C", VA = "0xFF146C", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000916")]
			[Address(RVA = "0xFF14B0", Offset = "0xFF14B0", VA = "0xFF14B0", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xFF1524", Offset = "0xFF1524", VA = "0xFF1524", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xFF158C", Offset = "0xFF158C", VA = "0xFF158C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xFF1630", Offset = "0xFF1630", VA = "0xFF1630")]
		private void Update()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xFF18E8", Offset = "0xFF18E8", VA = "0xFF18E8")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xFF1970", Offset = "0xFF1970", VA = "0xFF1970", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xFF1D40", Offset = "0xFF1D40", VA = "0xFF1D40")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xFF1E50", Offset = "0xFF1E50", VA = "0xFF1E50")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xFF1F74", Offset = "0xFF1F74", VA = "0xFF1F74")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xFF2278", Offset = "0xFF2278", VA = "0xFF2278")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xFF260C", Offset = "0xFF260C", VA = "0xFF260C", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xFF26F4", Offset = "0xFF26F4", VA = "0xFF26F4", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xFF2730", Offset = "0xFF2730", VA = "0xFF2730")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x2000222")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000B86")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x4000B87")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x4000B88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x4000B89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x4000B8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x4000B8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x4000B8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x4000B8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x4000B8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x4000B8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA033EC", Offset = "0xA033EC")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x170000F0")]
		public bool EnableState
		{
			[Token(Token = "0x6000923")]
			[Address(RVA = "0xFF1494", Offset = "0xFF1494", VA = "0xFF1494", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000924")]
			[Address(RVA = "0xFF14CC", Offset = "0xFF14CC", VA = "0xFF14CC", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000925")]
			[Address(RVA = "0xFF283C", Offset = "0xFF283C", VA = "0xFF283C", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000926")]
			[Address(RVA = "0xFF18AC", Offset = "0xFF18AC", VA = "0xFF18AC", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0xFF2A9C", Offset = "0xFF2A9C", VA = "0xFF2A9C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08084", Offset = "0xA08084")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000929")]
			[Address(RVA = "0xFF2AA4", Offset = "0xFF2AA4", VA = "0xFF2AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08094", Offset = "0xA08094")]
			set
			{
			}
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xFF2844", Offset = "0xFF2844", VA = "0xFF2844")]
		private void Awake()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xFF2648", Offset = "0xFF2648", VA = "0xFF2648", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xFF2AAC", Offset = "0xFF2AAC", VA = "0xFF2AAC")]
		private void Update()
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xFF2D20", Offset = "0xFF2D20", VA = "0xFF2D20")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xFF2E10", Offset = "0xFF2E10", VA = "0xFF2E10")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x2000223")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x4000B90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x4000B91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x4000B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x170000F3")]
		public bool UseSpherecast
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x1D1D1C0", Offset = "0x1D1D1C0", VA = "0x1D1D1C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x1D1D1C8", Offset = "0x1D1D1C8", VA = "0x1D1D1C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x1D1D250", Offset = "0x1D1D250", VA = "0x1D1D250")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x1D1D258", Offset = "0x1D1D258", VA = "0x1D1D258")]
			set
			{
			}
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x1D1D2C4", Offset = "0x1D1D2C4", VA = "0x1D1D2C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x1D1D578", Offset = "0x1D1D578", VA = "0x1D1D578")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x1D1D588", Offset = "0x1D1D588", VA = "0x1D1D588")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x1D1D598", Offset = "0x1D1D598", VA = "0x1D1D598")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x2000224")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x4000B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x4000B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x1D14F44", Offset = "0x1D14F44", VA = "0x1D14F44")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x1D14F48", Offset = "0x1D14F48", VA = "0x1D14F48")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x1D14F80", Offset = "0x1D14F80", VA = "0x1D14F80")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x1D14FB8", Offset = "0x1D14FB8", VA = "0x1D14FB8")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x1D14FF0", Offset = "0x1D14FF0", VA = "0x1D14FF0")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x1D15028", Offset = "0x1D15028", VA = "0x1D15028")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x1D15060", Offset = "0x1D15060", VA = "0x1D15060")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x1D15098", Offset = "0x1D15098", VA = "0x1D15098")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x1D1510C", Offset = "0x1D1510C", VA = "0x1D1510C")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x1D1517C", Offset = "0x1D1517C", VA = "0x1D1517C")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x2000225")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x4000B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x4000B96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x1D15184", Offset = "0x1D15184", VA = "0x1D15184")]
		private void Start()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x1D15188", Offset = "0x1D15188", VA = "0x1D15188")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x1D15140", Offset = "0x1D15140", VA = "0x1D15140")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x1D151C8", Offset = "0x1D151C8", VA = "0x1D151C8")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x2000226")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x2000227")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF85C", Offset = "0x9FF85C")]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x4000BA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x4000BA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x4000BA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x170000F5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600094C")]
				[Address(RVA = "0x14C3590", Offset = "0x14C3590", VA = "0x14C3590", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600094E")]
				[Address(RVA = "0x14C35D8", Offset = "0x14C35D8", VA = "0x14C35D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000949")]
			[Address(RVA = "0x14C33A4", Offset = "0x14C33A4", VA = "0x14C33A4")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600094A")]
			[Address(RVA = "0x14C33D0", Offset = "0x14C33D0", VA = "0x14C33D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600094B")]
			[Address(RVA = "0x14C33D4", Offset = "0x14C33D4", VA = "0x14C33D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600094D")]
			[Address(RVA = "0x14C3598", Offset = "0x14C3598", VA = "0x14C3598", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000B97")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x4000B98")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x4000B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x4000B9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x4000B9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x4000B9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x4000B9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x4000B9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x4000B9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x4000BA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xFEC884", Offset = "0xFEC884", VA = "0xFEC884")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xFEC930", Offset = "0xFEC930", VA = "0xFEC930")]
		private void Update()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xFECB80", Offset = "0xFECB80", VA = "0xFECB80")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xFECB08", Offset = "0xFECB08", VA = "0xFECB08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA080A4", Offset = "0xA080A4")]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xFECBCC", Offset = "0xFECBCC", VA = "0xFECBCC")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x2000228")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x2000229")]
		public enum SelectionState
		{
			[Token(Token = "0x4000BAE")]
			Off,
			[Token(Token = "0x4000BAF")]
			Selected,
			[Token(Token = "0x4000BB0")]
			Highlighted
		}

		[Token(Token = "0x4000BA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x4000BA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x4000BA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x4000BAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x4000BAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x4000BAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x170000F7")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0xE2D734", Offset = "0xE2D734", VA = "0xE2D734")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x6000950")]
			[Address(RVA = "0xE2D73C", Offset = "0xE2D73C", VA = "0xE2D73C")]
			set
			{
			}
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xE2D8C0", Offset = "0xE2D8C0", VA = "0xE2D8C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xE2DAC4", Offset = "0xE2DAC4", VA = "0xE2DAC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xE2D7C4", Offset = "0xE2D7C4", VA = "0xE2D7C4")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0xE2DBB0", Offset = "0xE2DBB0", VA = "0xE2DBB0")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x200022A")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x200022B")]
		public enum SegmentType
		{
			[Token(Token = "0x4000BBF")]
			Straight,
			[Token(Token = "0x4000BC0")]
			LeftTurn,
			[Token(Token = "0x4000BC1")]
			RightTurn,
			[Token(Token = "0x4000BC2")]
			Switch
		}

		[Token(Token = "0x4000BB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x4000BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x4000BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x4000BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x4000BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x4000BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x4000BB7")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x4000BB8")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x4000BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x4000BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA034CC", Offset = "0xA034CC")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x4000BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x4000BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x4000BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x170000F8")]
		public float StartDistance
		{
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x1DAA274", Offset = "0x1DAA274", VA = "0x1DAA274")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08154", Offset = "0xA08154")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x1DAA27C", Offset = "0x1DAA27C", VA = "0x1DAA27C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08164", Offset = "0xA08164")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public float GridSize
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x1DAA284", Offset = "0x1DAA284", VA = "0x1DAA284")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x1DAA28C", Offset = "0x1DAA28C", VA = "0x1DAA28C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public int SubDivCount
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x1DAA294", Offset = "0x1DAA294", VA = "0x1DAA294")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x1DAA29C", Offset = "0x1DAA29C", VA = "0x1DAA29C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public SegmentType Type
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x1DAA2A4", Offset = "0x1DAA2A4", VA = "0x1DAA2A4")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x170000FC")]
		public Pose EndPose
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x1DAA2AC", Offset = "0x1DAA2AC", VA = "0x1DAA2AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FD")]
		public float Radius
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x1DAA608", Offset = "0x1DAA608", VA = "0x1DAA608")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000FE")]
		public float SegmentLength
		{
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x1DAA314", Offset = "0x1DAA314", VA = "0x1DAA314")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x1DAA618", Offset = "0x1DAA618", VA = "0x1DAA618")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x1DAA630", Offset = "0x1DAA630", VA = "0x1DAA630")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x1DAA354", Offset = "0x1DAA354", VA = "0x1DAA354")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x1DAA634", Offset = "0x1DAA634", VA = "0x1DAA634")]
		private void Update()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x1DAA638", Offset = "0x1DAA638", VA = "0x1DAA638")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x1DAA6A0", Offset = "0x1DAA6A0", VA = "0x1DAA6A0")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x1DAAF68", Offset = "0x1DAAF68", VA = "0x1DAAF68")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x1DAB214", Offset = "0x1DAB214", VA = "0x1DAB214")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x200022C")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x200022D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF86C", Offset = "0x9FF86C")]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x4000BD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x4000BD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x170000FF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000976")]
				[Address(RVA = "0x14C7FBC", Offset = "0x14C7FBC", VA = "0x14C7FBC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000100")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000978")]
				[Address(RVA = "0x14C8004", Offset = "0x14C8004", VA = "0x14C8004", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0x14C7E18", Offset = "0x14C7E18", VA = "0x14C7E18")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0x14C7E44", Offset = "0x14C7E44", VA = "0x14C7E44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0x14C7E48", Offset = "0x14C7E48", VA = "0x14C7E48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0x14C7FC4", Offset = "0x14C7FC4", VA = "0x14C7FC4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000BC3")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x4000BC4")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x4000BC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x4000BC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x4000BC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x4000BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x4000BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x4000BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000BCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x4000BCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x4000BCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x4000BCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x4000BCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x4000BD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x4000BD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x4000BD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x4000BD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x1DAB2E4", Offset = "0x1DAB2E4", VA = "0x1DAB2E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x1DAB3A0", Offset = "0x1DAB3A0", VA = "0x1DAB3A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x1DAB450", Offset = "0x1DAB450", VA = "0x1DAB450")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x1DAB5C8", Offset = "0x1DAB5C8", VA = "0x1DAB5C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x1DAB790", Offset = "0x1DAB790", VA = "0x1DAB790")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x1DAB878", Offset = "0x1DAB878", VA = "0x1DAB878")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x1DABA8C", Offset = "0x1DABA8C", VA = "0x1DABA8C")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x1DAB98C", Offset = "0x1DAB98C", VA = "0x1DAB98C")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x1DAB9A0", Offset = "0x1DAB9A0", VA = "0x1DAB9A0")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x1DABAE4", Offset = "0x1DABAE4", VA = "0x1DABAE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA08174", Offset = "0xA08174")]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x1DABB5C", Offset = "0x1DABB5C", VA = "0x1DABB5C")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x200022E")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x4000BD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x4000BDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x17000101")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x1DABC0C", Offset = "0x1DABC0C", VA = "0x1DABC0C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x1DABC1C", Offset = "0x1DABC1C", VA = "0x1DABC1C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x1DABC24", Offset = "0x1DABC24", VA = "0x1DABC24", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x1DABF68", Offset = "0x1DABF68", VA = "0x1DABF68")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x200022F")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x4000BDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x4000BDC")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x4000BDD")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x4000BDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000BDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x4000BE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x4000BE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x4000BE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA035CC", Offset = "0xA035CC")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x4000BE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x4000BE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x4000BE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x17000102")]
		public float Distance
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x1DAC078", Offset = "0x1DAC078", VA = "0x1DAC078")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08224", Offset = "0xA08224")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x1DAC080", Offset = "0x1DAC080", VA = "0x1DAC080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08234", Offset = "0xA08234")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public float Scale
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x1DAC088", Offset = "0x1DAC088", VA = "0x1DAC088")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000980")]
			[Address(RVA = "0x1DAC090", Offset = "0x1DAC090", VA = "0x1DAC090")]
			set
			{
			}
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x1DABC20", Offset = "0x1DABC20", VA = "0x1DABC20", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x1DAC098", Offset = "0x1DAC098", VA = "0x1DAC098")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x1DABC6C", Offset = "0x1DABC6C", VA = "0x1DABC6C")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x1DABE90", Offset = "0x1DABE90", VA = "0x1DABE90")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x6000985")]
		public abstract void UpdatePosition();

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x1DABFD4", Offset = "0x1DABFD4", VA = "0x1DABFD4")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x2000230")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x2000231")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF87C", Offset = "0x9FF87C")]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x4000BF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x4000BF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x4000BF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x4000BF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x4000BF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x4000BF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x4000BF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x4000BFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x4000BFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x17000104")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000994")]
				[Address(RVA = "0x14C82A4", Offset = "0x14C82A4", VA = "0x14C82A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000105")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000996")]
				[Address(RVA = "0x14C82EC", Offset = "0x14C82EC", VA = "0x14C82EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x14C800C", Offset = "0x14C800C", VA = "0x14C800C")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x14C8038", Offset = "0x14C8038", VA = "0x14C8038", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x14C803C", Offset = "0x14C803C", VA = "0x14C803C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x14C82AC", Offset = "0x14C82AC", VA = "0x14C82AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000BE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000BE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x4000BE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x4000BE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x4000BEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000BEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x4000BEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x4000BED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x4000BEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x4000BEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x1DAC238", Offset = "0x1DAC238", VA = "0x1DAC238")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x1DAC298", Offset = "0x1DAC298", VA = "0x1DAC298")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x1DAC3A0", Offset = "0x1DAC3A0", VA = "0x1DAC3A0")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x1DAC4F8", Offset = "0x1DAC4F8", VA = "0x1DAC4F8")]
		private void Update()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x1DAC400", Offset = "0x1DAC400", VA = "0x1DAC400")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x1DAC5D4", Offset = "0x1DAC5D4", VA = "0x1DAC5D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA08244", Offset = "0xA08244")]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x1DAC65C", Offset = "0x1DAC65C", VA = "0x1DAC65C")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x1DAC708", Offset = "0x1DAC708", VA = "0x1DAC708")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x1DAC768", Offset = "0x1DAC768", VA = "0x1DAC768")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x2000232")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x2000233")]
		private enum EngineSoundState
		{
			[Token(Token = "0x4000C1A")]
			Start,
			[Token(Token = "0x4000C1B")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x4000C1C")]
			Stop
		}

		[Token(Token = "0x2000234")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF88C", Offset = "0x9FF88C")]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000C20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x4000C21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x4000C22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x4000C23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x4000C24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x4000C25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x17000106")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009A9")]
				[Address(RVA = "0x14C8568", Offset = "0x14C8568", VA = "0x14C8568", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000107")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009AB")]
				[Address(RVA = "0x14C85B0", Offset = "0x14C85B0", VA = "0x14C85B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x14C82F4", Offset = "0x14C82F4", VA = "0x14C82F4")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x14C8320", Offset = "0x14C8320", VA = "0x14C8320", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x14C8324", Offset = "0x14C8324", VA = "0x14C8324", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x14C8570", Offset = "0x14C8570", VA = "0x14C8570", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000BFC")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x4000BFD")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x4000BFE")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x4000BFF")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x4000C00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0362C", Offset = "0xA0362C")]
		protected float _initialSpeed;

		[Token(Token = "0x4000C01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000C02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x4000C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x4000C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x4000C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x4000C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x4000C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x4000C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x4000C09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x4000C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x4000C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x4000C0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x4000C0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x4000C0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x4000C0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x4000C10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x4000C11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x4000C12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x4000C13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x4000C14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x4000C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x4000C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x4000C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x4000C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x1DAC7C4", Offset = "0x1DAC7C4", VA = "0x1DAC7C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x1DAC930", Offset = "0x1DAC930", VA = "0x1DAC930")]
		private void Update()
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x1DAC93C", Offset = "0x1DAC93C", VA = "0x1DAC93C", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x1DACA8C", Offset = "0x1DACA8C", VA = "0x1DACA8C")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x1DAC8A4", Offset = "0x1DAC8A4", VA = "0x1DAC8A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA082F4", Offset = "0xA082F4")]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x1DACAEC", Offset = "0x1DACAEC", VA = "0x1DACAEC")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x1DACA28", Offset = "0x1DACA28", VA = "0x1DACA28")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x1DACCF0", Offset = "0x1DACCF0", VA = "0x1DACCF0")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x1DACE14", Offset = "0x1DACE14", VA = "0x1DACE14")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x1DACD5C", Offset = "0x1DACD5C", VA = "0x1DACD5C")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x1DACE80", Offset = "0x1DACE80", VA = "0x1DACE80")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x1DACEA0", Offset = "0x1DACEA0", VA = "0x1DACEA0")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x1DACF2C", Offset = "0x1DACF2C", VA = "0x1DACF2C")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x1DACFE4", Offset = "0x1DACFE4", VA = "0x1DACFE4")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x1DACFF4", Offset = "0x1DACFF4", VA = "0x1DACFF4")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x2000235")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x4000C26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x4000C27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x4000C28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x4000C29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x4000C2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x4000C2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x4000C2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x17000108")]
		public float TrackLength
		{
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x1DAD05C", Offset = "0x1DAD05C", VA = "0x1DAD05C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x1DAD064", Offset = "0x1DAD064", VA = "0x1DAD064")]
			private set
			{
			}
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x1DAD06C", Offset = "0x1DAD06C", VA = "0x1DAD06C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x1DAC118", Offset = "0x1DAC118", VA = "0x1DAC118")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x1DAD070", Offset = "0x1DAD070", VA = "0x1DAD070")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x1DAD284", Offset = "0x1DAD284", VA = "0x1DAD284")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x1DAD380", Offset = "0x1DAD380", VA = "0x1DAD380")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x2000236")]
	public class Pose
	{
		[Token(Token = "0x4000C2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000C2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xFF0A38", Offset = "0xFF0A38", VA = "0xFF0A38")]
		public Pose()
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xFF0A7C", Offset = "0xFF0A7C", VA = "0xFF0A7C")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000237")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x2000238")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF89C", Offset = "0x9FF89C")]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000C3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x4000C3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x4000C3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x1700010A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C1")]
				[Address(RVA = "0x14C8A3C", Offset = "0x14C8A3C", VA = "0x14C8A3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C3")]
				[Address(RVA = "0x14C8A84", Offset = "0x14C8A84", VA = "0x14C8A84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x14C886C", Offset = "0x14C886C", VA = "0x14C886C")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x14C8898", Offset = "0x14C8898", VA = "0x14C8898", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x14C889C", Offset = "0x14C889C", VA = "0x14C889C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x14C8A44", Offset = "0x14C8A44", VA = "0x14C8A44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000239")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF8AC", Offset = "0x9FF8AC")]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000C43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x4000C44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x4000C45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x1700010C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C7")]
				[Address(RVA = "0x14C8B94", Offset = "0x14C8B94", VA = "0x14C8B94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C9")]
				[Address(RVA = "0x14C8BDC", Offset = "0x14C8BDC", VA = "0x14C8BDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x14C8A8C", Offset = "0x14C8A8C", VA = "0x14C8A8C")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x14C8AB8", Offset = "0x14C8AB8", VA = "0x14C8AB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x14C8ABC", Offset = "0x14C8ABC", VA = "0x14C8ABC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x14C8B9C", Offset = "0x14C8B9C", VA = "0x14C8B9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C2F")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x4000C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x4000C32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x4000C33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x4000C34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA03814", Offset = "0xA03814")]
		private bool <IsMoving>k__BackingField;

		[Token(Token = "0x4000C35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x4000C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x4000C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x4000C38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x4000C39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x17000109")]
		public bool IsMoving
		{
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x1DB30B8", Offset = "0x1DB30B8", VA = "0x1DB30B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA083A4", Offset = "0xA083A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x1DB30C0", Offset = "0x1DB30C0", VA = "0x1DB30C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA083B4", Offset = "0xA083B4")]
			private set
			{
			}
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x1DB30CC", Offset = "0x1DB30CC", VA = "0x1DB30CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x1DB3108", Offset = "0x1DB3108", VA = "0x1DB3108")]
		private void Update()
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x1DB31EC", Offset = "0x1DB31EC", VA = "0x1DB31EC")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x1DB3260", Offset = "0x1DB3260", VA = "0x1DB3260")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA083C4", Offset = "0xA083C4")]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x1DB32E8", Offset = "0x1DB32E8", VA = "0x1DB32E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA08424", Offset = "0xA08424")]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x1DB33A0", Offset = "0x1DB33A0", VA = "0x1DB33A0")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x1DB340C", Offset = "0x1DB340C", VA = "0x1DB340C")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x200023A")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x4000C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x4000C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x4000C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x1DB3414", Offset = "0x1DB3414", VA = "0x1DB3414")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x1DB3488", Offset = "0x1DB3488", VA = "0x1DB3488")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x1DB356C", Offset = "0x1DB356C", VA = "0x1DB356C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x1DB36A4", Offset = "0x1DB36A4", VA = "0x1DB36A4")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x1DB3724", Offset = "0x1DB3724", VA = "0x1DB3724")]
		private void Update()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x1DB3800", Offset = "0x1DB3800", VA = "0x1DB3800")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x200023B")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x4000C4C")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x4000C4D")]
		EUDT_OverlayQuad,
		[Token(Token = "0x4000C4E")]
		EUDT_None,
		[Token(Token = "0x4000C4F")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x200023C")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x200023D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF8BC", Offset = "0x9FF8BC")]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000C6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x1700010E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009E3")]
				[Address(RVA = "0x14C1AD8", Offset = "0x14C1AD8", VA = "0x14C1AD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009E5")]
				[Address(RVA = "0x14C1B20", Offset = "0x14C1B20", VA = "0x14C1B20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x14C18A8", Offset = "0x14C18A8", VA = "0x14C18A8")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x14C18D4", Offset = "0x14C18D4", VA = "0x14C18D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x14C18D8", Offset = "0x14C18D8", VA = "0x14C18D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x14C1AE0", Offset = "0x14C1AE0", VA = "0x14C1AE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x4000C51")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x4000C52")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x4000C53")]
		private const string noneID = "NoneID";

		[Token(Token = "0x4000C54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x4000C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x4000C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA03854", Offset = "0xA03854")]
		public GameObject mainCamera;

		[Token(Token = "0x4000C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x4000C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x4000C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x4000C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x4000C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x4000C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x4000C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x4000C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0388C", Offset = "0xA0388C")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x4000C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x4000C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x4000C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x4000C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x4000C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x4000C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x4000C65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x4000C66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x4000C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x1242B44", Offset = "0x1242B44", VA = "0x1242B44")]
		private void Start()
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x1243378", Offset = "0x1243378", VA = "0x1243378")]
		private void Update()
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x12434C0", Offset = "0x12434C0", VA = "0x12434C0")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x12435FC", Offset = "0x12435FC", VA = "0x12435FC")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x1243738", Offset = "0x1243738", VA = "0x1243738")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x1243494", Offset = "0x1243494", VA = "0x1243494")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x1243818", Offset = "0x1243818", VA = "0x1243818")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA08524", Offset = "0xA08524")]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x1243890", Offset = "0x1243890", VA = "0x1243890")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x1242FAC", Offset = "0x1242FAC", VA = "0x1242FAC")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x12439E4", Offset = "0x12439E4", VA = "0x12439E4")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x12438C4", Offset = "0x12438C4", VA = "0x12438C4")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x1243CFC", Offset = "0x1243CFC", VA = "0x1243CFC")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x1243DEC", Offset = "0x1243DEC", VA = "0x1243DEC")]
		public OVROverlaySample()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x1243E7C", Offset = "0x1243E7C", VA = "0x1243E7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08584", Offset = "0xA08584")]
		private void <Start>b__24_0(Toggle t)
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x1243ED4", Offset = "0x1243ED4", VA = "0x1243ED4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08594", Offset = "0xA08594")]
		private void <Start>b__24_1(Toggle t)
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x1243F2C", Offset = "0x1243F2C", VA = "0x1243F2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA085A4", Offset = "0xA085A4")]
		private void <Start>b__24_2(Toggle t)
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x200023E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9FF8CC", Offset = "0x9FF8CC")]
	public class Hand : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200023F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FF92C", Offset = "0x9FF92C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000C88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Collider, bool> <>9__28_0;

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x1DBC120", Offset = "0x1DBC120", VA = "0x1DBC120")]
			public <>c()
			{
			}

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x1DBC128", Offset = "0x1DBC128", VA = "0x1DBC128")]
			internal bool <Start>b__28_0(Collider childCollider)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000C6B")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x4000C6C")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x4000C6D")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x4000C6E")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x4000C6F")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x4000C70")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x4000C71")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x4000C72")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x4000C73")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x4000C74")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x4000C75")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x4000C76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000C78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x4000C79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x4000C7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x4000C7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x4000C7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x4000C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x4000C7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x4000C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x4000C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x4000C81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x4000C82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x4000C83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x4000C84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x4000C85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x4000C86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x1E5ED78", Offset = "0x1E5ED78", VA = "0x1E5ED78")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x1E5EDD4", Offset = "0x1E5EDD4", VA = "0x1E5EDD4")]
		private void Start()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x1E5F268", Offset = "0x1E5F268", VA = "0x1E5F268")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x1E5F354", Offset = "0x1E5F354", VA = "0x1E5F354")]
		private void Update()
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x1E5F4B8", Offset = "0x1E5F4B8", VA = "0x1E5F4B8")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x1E5F7C0", Offset = "0x1E5F7C0", VA = "0x1E5F7C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x1E5F8B8", Offset = "0x1E5F8B8", VA = "0x1E5F8B8")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x1E5FA18", Offset = "0x1E5FA18", VA = "0x1E5FA18")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x1E5F550", Offset = "0x1E5F550", VA = "0x1E5F550")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x1E5F5A4", Offset = "0x1E5F5A4", VA = "0x1E5F5A4")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x1E5F10C", Offset = "0x1E5F10C", VA = "0x1E5F10C")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x1E5FB54", Offset = "0x1E5FB54", VA = "0x1E5FB54")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x2000240")]
	public enum HandPoseId
	{
		[Token(Token = "0x4000C8A")]
		Default,
		[Token(Token = "0x4000C8B")]
		Generic,
		[Token(Token = "0x4000C8C")]
		PingPongBall,
		[Token(Token = "0x4000C8D")]
		Controller
	}
	[Token(Token = "0x2000241")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x4000C8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x4000C8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x4000C90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x17000110")]
		public bool AllowPointing
		{
			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x1E63F98", Offset = "0x1E63F98", VA = "0x1E63F98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000111")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x1E63FA0", Offset = "0x1E63FA0", VA = "0x1E63FA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000112")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x1E63FA8", Offset = "0x1E63FA8", VA = "0x1E63FA8")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x1E63FB0", Offset = "0x1E63FB0", VA = "0x1E63FB0")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x2000242")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x4000C91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000C93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x1DA9EE4", Offset = "0x1DA9EE4", VA = "0x1DA9EE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x1DAA1CC", Offset = "0x1DAA1CC", VA = "0x1DAA1CC")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x1DAA228", Offset = "0x1DAA228", VA = "0x1DAA228")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x1DAA26C", Offset = "0x1DAA26C", VA = "0x1DAA26C")]
		public TouchController()
		{
		}
	}
}
namespace Oculus.Voice.Demo.UIShapesDemo
{
	[Token(Token = "0x2000243")]
	public class InteractionHandler : MonoBehaviour
	{
		[Token(Token = "0x4000C94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA03944", Offset = "0xA03944")]
		[Multiline]
		[SerializeField]
		private string freshStateText;

		[Token(Token = "0x4000C95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA039A0", Offset = "0xA039A0")]
		private Text textArea;

		[Token(Token = "0x4000C96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool showJson;

		[Token(Token = "0x4000C97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA039FC", Offset = "0xA039FC")]
		[SerializeField]
		private AppVoiceExperience appVoiceExperience;

		[Token(Token = "0x4000C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string pendingText;

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x1E683E8", Offset = "0x1E683E8", VA = "0x1E683E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x1E684B4", Offset = "0x1E684B4", VA = "0x1E684B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x1E68580", Offset = "0x1E68580", VA = "0x1E68580")]
		private void OnRequestStarted(WitRequest r)
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x1E68640", Offset = "0x1E68640", VA = "0x1E68640")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x1E68698", Offset = "0x1E68698", VA = "0x1E68698")]
		public void OnResponse(WitResponseNode response)
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x1E68788", Offset = "0x1E68788", VA = "0x1E68788")]
		public void OnError(string error, string message)
		{
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x1E68990", Offset = "0x1E68990", VA = "0x1E68990")]
		public void ToggleActivation()
		{
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x1E689F0", Offset = "0x1E689F0", VA = "0x1E689F0")]
		public InteractionHandler()
		{
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x1E68A4C", Offset = "0x1E68A4C", VA = "0x1E68A4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08604", Offset = "0xA08604")]
		private void <OnRequestStarted>b__7_0(string response)
		{
		}
	}
	[Token(Token = "0x2000244")]
	public class ColorChanger : MonoBehaviour
	{
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x1CBC224", Offset = "0x1CBC224", VA = "0x1CBC224")]
		private void SetColor(Transform trans, Color color)
		{
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x1CBC2C0", Offset = "0x1CBC2C0", VA = "0x1CBC2C0")]
		public void UpdateColor(WitResponseNode commandResult)
		{
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x1CBC4E4", Offset = "0x1CBC4E4", VA = "0x1CBC4E4")]
		public void UpdateColor(string[] results)
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x1CBC354", Offset = "0x1CBC354", VA = "0x1CBC354")]
		public void UpdateColor(string colorName, string shape)
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x1CBC520", Offset = "0x1CBC520", VA = "0x1CBC520")]
		public ColorChanger()
		{
		}
	}
	[Token(Token = "0x2000245")]
	[ExecuteAlways]
	public class Instructions : MonoBehaviour
	{
		[Token(Token = "0x2000246")]
		internal enum Step
		{
			[Token(Token = "0x4000C9D")]
			SetupWit,
			[Token(Token = "0x4000C9E")]
			MissingServerToken,
			[Token(Token = "0x4000C9F")]
			MissingClientToken,
			[Token(Token = "0x4000CA0")]
			AddConfig,
			[Token(Token = "0x4000CA1")]
			AddVoiceExperiences,
			[Token(Token = "0x4000CA2")]
			SetConfig,
			[Token(Token = "0x4000CA3")]
			Ready
		}

		[Token(Token = "0x4000C99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] steps;

		[Token(Token = "0x4000C9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text instructionText;

		[Token(Token = "0x4000C9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Step currentStep;

		[Token(Token = "0x17000113")]
		internal Step CurrentStep
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x1E65D44", Offset = "0x1E65D44", VA = "0x1E65D44")]
			get
			{
				return default(Step);
			}
		}

		[Token(Token = "0x17000114")]
		internal string CurrentStepText
		{
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x1E65D4C", Offset = "0x1E65D4C", VA = "0x1E65D4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x1E65DE0", Offset = "0x1E65DE0", VA = "0x1E65DE0")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x1E65DE8", Offset = "0x1E65DE8", VA = "0x1E65DE8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x1E65DEC", Offset = "0x1E65DEC", VA = "0x1E65DEC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x1E65DE4", Offset = "0x1E65DE4", VA = "0x1E65DE4")]
		private void UpdateStep()
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x1E65DF0", Offset = "0x1E65DF0", VA = "0x1E65DF0")]
		public Instructions()
		{
		}
	}
}
namespace Oculus.Voice.Demo.BuiltInDemo
{
	[Token(Token = "0x2000247")]
	public class TimerController : MonoBehaviour
	{
		[Token(Token = "0x4000CA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _time;

		[Token(Token = "0x4000CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _timerExist;

		[Token(Token = "0x4000CA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool _timerRunning;

		[Token(Token = "0x4000CA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA03A58", Offset = "0xA03A58")]
		public Text logText;

		[Token(Token = "0x4000CA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA03A90", Offset = "0xA03A90")]
		public AudioClip buzzSound;

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xE3FFB0", Offset = "0xE3FFB0", VA = "0xE3FFB0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xE40080", Offset = "0xE40080", VA = "0xE40080")]
		private void Log(string msg)
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xE40014", Offset = "0xE40014", VA = "0xE40014")]
		private void OnElapsedTime()
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xE40110", Offset = "0xE40110", VA = "0xE40110")]
		public void DeleteTimer()
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xE40184", Offset = "0xE40184", VA = "0xE40184")]
		public void CreateTimer(string[] entityValues)
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xE40558", Offset = "0xE40558", VA = "0xE40558")]
		public void GetTimerIntent()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xE40608", Offset = "0xE40608", VA = "0xE40608")]
		public void PauseTimer()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xE40658", Offset = "0xE40658", VA = "0xE40658")]
		public void ResumeTimer()
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xE406AC", Offset = "0xE406AC", VA = "0xE406AC")]
		public void SubtractTimeTimer(string[] entityValues)
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xE407C4", Offset = "0xE407C4", VA = "0xE407C4")]
		public void AddTimeToTimer(string[] entityValues)
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xE408D0", Offset = "0xE408D0", VA = "0xE408D0")]
		public float GetRemainingTime()
		{
			return default(float);
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xE40580", Offset = "0xE40580", VA = "0xE40580")]
		public string GetFormattedTimeFromSeconds()
		{
			return null;
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xE403E4", Offset = "0xE403E4", VA = "0xE403E4")]
		private bool ParseTime(string[] entityValues, out float time)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0xE408D8", Offset = "0xE408D8", VA = "0xE408D8")]
		public TimerController()
		{
		}
	}
	[Token(Token = "0x2000248")]
	public class TimerDisplay : MonoBehaviour
	{
		[Token(Token = "0x4000CA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TimerController timer;

		[Token(Token = "0x4000CAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text _uiText;

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x1DA9E34", Offset = "0x1DA9E34", VA = "0x1DA9E34")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x1DA9E90", Offset = "0x1DA9E90", VA = "0x1DA9E90")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x1DA9EDC", Offset = "0x1DA9EDC", VA = "0x1DA9EDC")]
		public TimerDisplay()
		{
		}
	}
	[Token(Token = "0x2000249")]
	public class WitActivation : MonoBehaviour
	{
		[Token(Token = "0x4000CAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppVoiceExperience voiceExperience;

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x1DB3810", Offset = "0x1DB3810", VA = "0x1DB3810")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x1DB38C8", Offset = "0x1DB38C8", VA = "0x1DB38C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x1DB3924", Offset = "0x1DB3924", VA = "0x1DB3924")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x1DB39A8", Offset = "0x1DB39A8", VA = "0x1DB39A8")]
		public void ActivateWit()
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x1DB39CC", Offset = "0x1DB39CC", VA = "0x1DB39CC")]
		public WitActivation()
		{
		}
	}
}
namespace Oculus.Avatar
{
	[Token(Token = "0x200024A")]
	public static class AvatarLogger
	{
		[Token(Token = "0x4000CAC")]
		public const string LogAvatar = "[Avatars] - ";

		[Token(Token = "0x4000CAD")]
		public const string Tab = "    ";

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x1CAD0D4", Offset = "0x1CAD0D4", VA = "0x1CAD0D4")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA08614", Offset = "0xA08614")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA08614", Offset = "0xA08614")]
		public static void Log(string logMsg)
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x1CAD164", Offset = "0x1CAD164", VA = "0x1CAD164")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA08674", Offset = "0xA08674")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA08674", Offset = "0xA08674")]
		public static void Log(string logMsg, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x1CAD204", Offset = "0x1CAD204", VA = "0x1CAD204")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA086D4", Offset = "0xA086D4")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA086D4", Offset = "0xA086D4")]
		public static void LogWarning(string logMsg)
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x1CAD294", Offset = "0x1CAD294", VA = "0x1CAD294")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA08734", Offset = "0xA08734")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA08734", Offset = "0xA08734")]
		public static void LogError(string logMsg)
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x1CAD324", Offset = "0x1CAD324", VA = "0x1CAD324")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA08794", Offset = "0xA08794")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA08794", Offset = "0xA08794")]
		public static void LogError(string logMsg, UnityEngine.Object context)
		{
		}
	}
	[Token(Token = "0x200024B")]
	public class CAPI
	{
		[Token(Token = "0x200024C")]
		public delegate void LoggingDelegate(IntPtr str);

		[Token(Token = "0x200024D")]
		public enum Result
		{
			[Token(Token = "0x4000CB9")]
			Success = 0,
			[Token(Token = "0x4000CBA")]
			Failure = -1000,
			[Token(Token = "0x4000CBB")]
			Failure_InvalidParameter = -1001,
			[Token(Token = "0x4000CBC")]
			Failure_NotInitialized = -1002,
			[Token(Token = "0x4000CBD")]
			Failure_InvalidOperation = -1003,
			[Token(Token = "0x4000CBE")]
			Failure_Unsupported = -1004,
			[Token(Token = "0x4000CBF")]
			Failure_NotYetImplemented = -1005,
			[Token(Token = "0x4000CC0")]
			Failure_OperationFailed = -1006,
			[Token(Token = "0x4000CC1")]
			Failure_InsufficientSize = -1007
		}

		[Token(Token = "0x200024E")]
		private static class OVRP_1_30_0
		{
			[Token(Token = "0x4000CC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Version version;

			[PreserveSig]
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x1DB92D0", Offset = "0x1DB92D0", VA = "0x1DB92D0")]
			public static extern Result ovrp_SendEvent2(string name, string param, string source);
		}

		[Token(Token = "0x4000CAE")]
		private const string LibFile = "ovravatarloader";

		[Token(Token = "0x4000CAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IntPtr nativeVisemeData;

		[Token(Token = "0x4000CB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IntPtr nativeGazeTargetsData;

		[Token(Token = "0x4000CB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IntPtr nativeAvatarLightsData;

		[Token(Token = "0x4000CB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IntPtr DebugLineCountData;

		[Token(Token = "0x4000CB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float[] scratchBufferFloat;

		[Token(Token = "0x4000CB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject debugLineGo;

		[Token(Token = "0x4000CB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string SDKRuntimePrefix;

		[Token(Token = "0x4000CB6")]
		private const string ovrPluginDLL = "OVRPlugin";

		[Token(Token = "0x4000CB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Version ovrPluginVersion;

		[PreserveSig]
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x1CAFBAC", Offset = "0x1CAFBAC", VA = "0x1CAFBAC")]
		public static extern void ovrAvatar_InitializeAndroidUnity(string appID);

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x1CAFC3C", Offset = "0x1CAFC3C", VA = "0x1CAFC3C")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x1CAFE60", Offset = "0x1CAFE60", VA = "0x1CAFE60")]
		public static void Shutdown()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x1CAFF4C", Offset = "0x1CAFF4C", VA = "0x1CAFF4C")]
		public static extern void ovrAvatar_Shutdown();

		[PreserveSig]
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x1CAFFBC", Offset = "0x1CAFFBC", VA = "0x1CAFFBC")]
		public static extern IntPtr ovrAvatarMessage_Pop();

		[PreserveSig]
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x1CB0030", Offset = "0x1CB0030", VA = "0x1CB0030")]
		public static extern ovrAvatarMessageType ovrAvatarMessage_GetType(IntPtr msg);

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x1CB00B0", Offset = "0x1CB00B0", VA = "0x1CB00B0")]
		public static ovrAvatarMessage_AvatarSpecification ovrAvatarMessage_GetAvatarSpecification(IntPtr msg)
		{
			return default(ovrAvatarMessage_AvatarSpecification);
		}

		[PreserveSig]
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x1CB01F4", Offset = "0x1CB01F4", VA = "0x1CB01F4")]
		private static extern IntPtr ovrAvatarMessage_GetAvatarSpecification_Native(IntPtr msg);

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x1CB0274", Offset = "0x1CB0274", VA = "0x1CB0274")]
		public static ovrAvatarMessage_AssetLoaded ovrAvatarMessage_GetAssetLoaded(IntPtr msg)
		{
			return default(ovrAvatarMessage_AssetLoaded);
		}

		[PreserveSig]
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x1CB03B8", Offset = "0x1CB03B8", VA = "0x1CB03B8")]
		private static extern IntPtr ovrAvatarMessage_GetAssetLoaded_Native(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x1CB0438", Offset = "0x1CB0438", VA = "0x1CB0438")]
		public static extern void ovrAvatarMessage_Free(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x1CB04B8", Offset = "0x1CB04B8", VA = "0x1CB04B8")]
		public static extern IntPtr ovrAvatarSpecificationRequest_Create(ulong userID);

		[PreserveSig]
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x1CB0538", Offset = "0x1CB0538", VA = "0x1CB0538")]
		public static extern void ovrAvatarSpecificationRequest_Destroy(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x1CB05B8", Offset = "0x1CB05B8", VA = "0x1CB05B8")]
		public static extern void ovrAvatarSpecificationRequest_SetCombineMeshes(IntPtr specificationRequest, bool useCombinedMesh);

		[PreserveSig]
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x1CB0648", Offset = "0x1CB0648", VA = "0x1CB0648")]
		public static extern void ovrAvatarSpecificationRequest_SetLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x1CB06D8", Offset = "0x1CB06D8", VA = "0x1CB06D8")]
		public static extern void ovrAvatarSpecificationRequest_SetLevelOfDetail(IntPtr specificationRequest, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x1CB0768", Offset = "0x1CB0768", VA = "0x1CB0768")]
		public static extern void ovrAvatar_RequestAvatarSpecification(ulong userID);

		[PreserveSig]
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x1CB07E8", Offset = "0x1CB07E8", VA = "0x1CB07E8")]
		public static extern void ovrAvatar_RequestAvatarSpecificationFromSpecRequest(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x1CB0868", Offset = "0x1CB0868", VA = "0x1CB0868")]
		public static extern void ovrAvatarSpecificationRequest_SetFallbackLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x1CB08F8", Offset = "0x1CB08F8", VA = "0x1CB08F8")]
		public static extern void ovrAvatarSpecificationRequest_SetExpressiveFlag(IntPtr specificationRequest, bool enable);

		[PreserveSig]
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x1CB0988", Offset = "0x1CB0988", VA = "0x1CB0988")]
		public static extern IntPtr ovrAvatar_Create(IntPtr avatarSpecification, ovrAvatarCapabilities capabilities);

		[PreserveSig]
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x1CB0A18", Offset = "0x1CB0A18", VA = "0x1CB0A18")]
		public static extern void ovrAvatar_Destroy(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x1CB0A98", Offset = "0x1CB0A98", VA = "0x1CB0A98")]
		public static extern void ovrAvatarPose_UpdateBody(IntPtr avatar, ovrAvatarTransform headPose);

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x1CB0B38", Offset = "0x1CB0B38", VA = "0x1CB0B38")]
		public static void ovrAvatarPose_UpdateVoiceVisualization(IntPtr avatar, float[] pcmData)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x1CB0BB4", Offset = "0x1CB0BB4", VA = "0x1CB0BB4")]
		private static extern void ovrAvatarPose_UpdateVoiceVisualization_Native(IntPtr avatar, uint pcmDataSize, [In] float[] pcmData);

		[PreserveSig]
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x1CB0C54", Offset = "0x1CB0C54", VA = "0x1CB0C54")]
		public static extern void ovrAvatarPose_UpdateHands(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight);

		[PreserveSig]
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x1CB0D14", Offset = "0x1CB0D14", VA = "0x1CB0D14")]
		public static extern void ovrAvatarPose_UpdateHandsWithType(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight, ovrAvatarControllerType type);

		[PreserveSig]
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x1CB0DE4", Offset = "0x1CB0DE4", VA = "0x1CB0DE4")]
		public static extern void ovrAvatarPose_Finalize(IntPtr avatar, float elapsedSeconds);

		[PreserveSig]
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x1CB0E74", Offset = "0x1CB0E74", VA = "0x1CB0E74")]
		public static extern void ovrAvatar_SetLeftControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x1CB0F04", Offset = "0x1CB0F04", VA = "0x1CB0F04")]
		public static extern void ovrAvatar_SetRightControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x1CB0F94", Offset = "0x1CB0F94", VA = "0x1CB0F94")]
		public static extern void ovrAvatar_SetLeftHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x1CB1024", Offset = "0x1CB1024", VA = "0x1CB1024")]
		public static extern void ovrAvatar_SetRightHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x1CB10B4", Offset = "0x1CB10B4", VA = "0x1CB10B4")]
		public static extern uint ovrAvatarComponent_Count(IntPtr avatar);

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x1CB1134", Offset = "0x1CB1134", VA = "0x1CB1134")]
		public static void ovrAvatarComponent_Get(IntPtr avatar, uint index, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x1CB1250", Offset = "0x1CB1250", VA = "0x1CB1250")]
		public static void ovrAvatarComponent_Get(IntPtr componentPtr, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x1CB11C0", Offset = "0x1CB11C0", VA = "0x1CB11C0")]
		public static extern IntPtr ovrAvatarComponent_Get_Native(IntPtr avatar, uint index);

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x1CB1470", Offset = "0x1CB1470", VA = "0x1CB1470")]
		public static bool ovrAvatarPose_GetBaseComponent(IntPtr avatar, ref ovrAvatarBaseComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x1CB15E0", Offset = "0x1CB15E0", VA = "0x1CB15E0")]
		private static extern IntPtr ovrAvatarPose_GetBaseComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000A54")]
		public static IntPtr MarshalRenderComponent<T>(IntPtr ptr) where T : struct
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x1CB1660", Offset = "0x1CB1660", VA = "0x1CB1660")]
		public static bool ovrAvatarPose_GetBodyComponent(IntPtr avatar, ref ovrAvatarBodyComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x1CB1908", Offset = "0x1CB1908", VA = "0x1CB1908")]
		private static extern IntPtr ovrAvatarPose_GetBodyComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x1CB1988", Offset = "0x1CB1988", VA = "0x1CB1988")]
		public static bool ovrAvatarPose_GetLeftControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x1CB1AF8", Offset = "0x1CB1AF8", VA = "0x1CB1AF8")]
		private static extern IntPtr ovrAvatarPose_GetLeftControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x1CB1B78", Offset = "0x1CB1B78", VA = "0x1CB1B78")]
		public static bool ovrAvatarPose_GetRightControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x1CB1CE8", Offset = "0x1CB1CE8", VA = "0x1CB1CE8")]
		private static extern IntPtr ovrAvatarPose_GetRightControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x1CB1D68", Offset = "0x1CB1D68", VA = "0x1CB1D68")]
		public static bool ovrAvatarPose_GetLeftHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x1CB1ED8", Offset = "0x1CB1ED8", VA = "0x1CB1ED8")]
		private static extern IntPtr ovrAvatarPose_GetLeftHandComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x1CB1F58", Offset = "0x1CB1F58", VA = "0x1CB1F58")]
		public static bool ovrAvatarPose_GetRightHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x1CB20C8", Offset = "0x1CB20C8", VA = "0x1CB20C8")]
		private static extern IntPtr ovrAvatarPose_GetRightHandComponent_Native(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x1CB2148", Offset = "0x1CB2148", VA = "0x1CB2148")]
		public static extern void ovrAvatarAsset_BeginLoading(ulong assetID);

		[PreserveSig]
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x1CB21C8", Offset = "0x1CB21C8", VA = "0x1CB21C8")]
		public static extern bool ovrAvatarAsset_BeginLoadingLOD(ulong assetId, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x1CB2260", Offset = "0x1CB2260", VA = "0x1CB2260")]
		public static extern ovrAvatarAssetType ovrAvatarAsset_GetType(IntPtr assetHandle);

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x1CB22E0", Offset = "0x1CB22E0", VA = "0x1CB22E0")]
		public static ovrAvatarMeshAssetData ovrAvatarAsset_GetMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetData);
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x1CB24B8", Offset = "0x1CB24B8", VA = "0x1CB24B8")]
		public static ovrAvatarMeshAssetDataV2 ovrAvatarAsset_GetCombinedMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetDataV2);
		}

		[PreserveSig]
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x1CB2610", Offset = "0x1CB2610", VA = "0x1CB2610")]
		private static extern IntPtr ovrAvatarAsset_GetCombinedMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x1CB2438", Offset = "0x1CB2438", VA = "0x1CB2438")]
		private static extern IntPtr ovrAvatarAsset_GetMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x1CB2690", Offset = "0x1CB2690", VA = "0x1CB2690")]
		public static extern uint ovrAvatarAsset_GetMeshBlendShapeCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x1CB2710", Offset = "0x1CB2710", VA = "0x1CB2710")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeName(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x1CB27A0", Offset = "0x1CB27A0", VA = "0x1CB27A0")]
		public static extern uint ovrAvatarAsset_GetSubmeshCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x1CB2820", Offset = "0x1CB2820", VA = "0x1CB2820")]
		public static extern uint ovrAvatarAsset_GetSubmeshLastIndex(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x1CB28B0", Offset = "0x1CB28B0", VA = "0x1CB28B0")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeVertices(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x1CB2930", Offset = "0x1CB2930", VA = "0x1CB2930")]
		public static extern IntPtr ovrAvatarAsset_GetAvatar(IntPtr assetHandle);

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x1CB29B0", Offset = "0x1CB29B0", VA = "0x1CB29B0")]
		public static ulong[] ovrAvatarAsset_GetCombinedMeshIDs(IntPtr assetHandle)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x1CB2C3C", Offset = "0x1CB2C3C", VA = "0x1CB2C3C")]
		public static extern IntPtr ovrAvatarAsset_GetCombinedMeshIDs_Native(IntPtr assetHandle, IntPtr count);

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x1CB2CCC", Offset = "0x1CB2CCC", VA = "0x1CB2CCC")]
		public static void ovrAvatar_GetCombinedMeshAlphaData(IntPtr avatar, ref ulong textureID, ref Vector4 offset)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x1CB2EFC", Offset = "0x1CB2EFC", VA = "0x1CB2EFC")]
		public static extern IntPtr ovrAvatar_GetCombinedMeshAlphaData_Native(IntPtr avatar, IntPtr textureIDPtr, IntPtr offsetPtr);

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x1CB2F94", Offset = "0x1CB2F94", VA = "0x1CB2F94")]
		public static ovrAvatarTextureAssetData ovrAvatarAsset_GetTextureData(IntPtr assetPtr)
		{
			return default(ovrAvatarTextureAssetData);
		}

		[PreserveSig]
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x1CB30E4", Offset = "0x1CB30E4", VA = "0x1CB30E4")]
		private static extern IntPtr ovrAvatarAsset_GetTextureData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x1CB3164", Offset = "0x1CB3164", VA = "0x1CB3164")]
		private static extern IntPtr ovrAvatarAsset_GetMaterialData_Native(IntPtr assetPtr);

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x1CB31E4", Offset = "0x1CB31E4", VA = "0x1CB31E4")]
		public static ovrAvatarMaterialState ovrAvatarAsset_GetMaterialState(IntPtr assetPtr)
		{
			return default(ovrAvatarMaterialState);
		}

		[PreserveSig]
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x1CB3338", Offset = "0x1CB3338", VA = "0x1CB3338")]
		public static extern ovrAvatarRenderPartType ovrAvatarRenderPart_GetType(IntPtr renderPart);

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x1CB33B8", Offset = "0x1CB33B8", VA = "0x1CB33B8")]
		public static ovrAvatarRenderPart_SkinnedMeshRender ovrAvatarRenderPart_GetSkinnedMeshRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRender);
		}

		[PreserveSig]
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x1CB350C", Offset = "0x1CB350C", VA = "0x1CB350C")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x1CB358C", Offset = "0x1CB358C", VA = "0x1CB358C")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x1CB361C", Offset = "0x1CB361C", VA = "0x1CB361C")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x1CB36AC", Offset = "0x1CB36AC", VA = "0x1CB36AC")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x1CB373C", Offset = "0x1CB373C", VA = "0x1CB373C")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRender_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x1CB37BC", Offset = "0x1CB37BC", VA = "0x1CB37BC")]
		public static extern bool ovrAvatarSkinnedMeshRender_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x1CB3844", Offset = "0x1CB3844", VA = "0x1CB3844")]
		public static extern bool ovrAvatarSkinnedMeshRenderPBSV2_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x1CB38CC", Offset = "0x1CB38CC", VA = "0x1CB38CC")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBS_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x1CB394C", Offset = "0x1CB394C", VA = "0x1CB394C")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBSV2_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x1CB39CC", Offset = "0x1CB39CC", VA = "0x1CB39CC")]
		public static extern ovrAvatarMaterialState ovrAvatarSkinnedMeshRender_GetMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x1CB3A80", Offset = "0x1CB3A80", VA = "0x1CB3A80")]
		public static extern ovrAvatarPBSMaterialState ovrAvatarSkinnedMeshRenderPBSV2_GetPBSMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x1CB3B10", Offset = "0x1CB3B10", VA = "0x1CB3B10")]
		public static extern ovrAvatarExpressiveParameters ovrAvatar_GetExpressiveParameters(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x1CB3BA0", Offset = "0x1CB3BA0", VA = "0x1CB3BA0")]
		public static extern ulong ovrAvatarSkinnedMeshRender_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x1CB3C20", Offset = "0x1CB3C20", VA = "0x1CB3C20")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x1CB3CA0", Offset = "0x1CB3CA0", VA = "0x1CB3CA0")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBSV2_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x1CB3D20", Offset = "0x1CB3D20", VA = "0x1CB3D20")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x1CB3DB8", Offset = "0x1CB3DB8", VA = "0x1CB3DB8")]
		public static extern void ovrAvatar_SetActionUnitOnsetSpeed(IntPtr avatar, float onsetSpeed);

		[PreserveSig]
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x1CB3E48", Offset = "0x1CB3E48", VA = "0x1CB3E48")]
		public static extern void ovrAvatar_SetActionUnitFalloffSpeed(IntPtr avatar, float falloffSpeed);

		[PreserveSig]
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x1CB3ED8", Offset = "0x1CB3ED8", VA = "0x1CB3ED8")]
		public static extern void ovrAvatar_SetVisemeMultiplier(IntPtr avatar, float visemeMultiplier);

		[PreserveSig]
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x1CB3F68", Offset = "0x1CB3F68", VA = "0x1CB3F68")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x1CB4000", Offset = "0x1CB4000", VA = "0x1CB4000")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x1CB4098", Offset = "0x1CB4098", VA = "0x1CB4098")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x1CB4118", Offset = "0x1CB4118", VA = "0x1CB4118")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(IntPtr renderPart);

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x1CB4198", Offset = "0x1CB4198", VA = "0x1CB4198")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS ovrAvatarRenderPart_GetSkinnedMeshRenderPBS(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS);
		}

		[PreserveSig]
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x1CB42EC", Offset = "0x1CB42EC", VA = "0x1CB42EC")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBS_Native(IntPtr renderPart);

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x1CB436C", Offset = "0x1CB436C", VA = "0x1CB436C")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2);
		}

		[PreserveSig]
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x1CB44C0", Offset = "0x1CB44C0", VA = "0x1CB44C0")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2_Native(IntPtr renderPart);

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x1CB4540", Offset = "0x1CB4540", VA = "0x1CB4540")]
		public static void ovrAvatarSkinnedMeshRender_GetBlendShapeParams(IntPtr renderPart, ref ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x1CB467C", Offset = "0x1CB467C", VA = "0x1CB467C")]
		private static extern IntPtr ovrAvatarSkinnedMeshRender_GetBlendShapeParams_Native(IntPtr renderPart);

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x1CB46FC", Offset = "0x1CB46FC", VA = "0x1CB46FC")]
		public static ovrAvatarRenderPart_ProjectorRender ovrAvatarRenderPart_GetProjectorRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_ProjectorRender);
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x1CB48D0", Offset = "0x1CB48D0", VA = "0x1CB48D0")]
		public static ovrAvatarPBSMaterialState[] ovrAvatar_GetBodyPBSMaterialStates(IntPtr renderPart)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x1CB4BB0", Offset = "0x1CB4BB0", VA = "0x1CB4BB0")]
		private static extern IntPtr ovrAvatar_GetBodyPBSMaterialStates_Native(IntPtr avatar, IntPtr count);

		[PreserveSig]
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x1CB4850", Offset = "0x1CB4850", VA = "0x1CB4850")]
		private static extern IntPtr ovrAvatarRenderPart_GetProjectorRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x1CB4C40", Offset = "0x1CB4C40", VA = "0x1CB4C40")]
		public static extern uint ovrAvatar_GetReferencedAssetCount(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x1CB4CC0", Offset = "0x1CB4CC0", VA = "0x1CB4CC0")]
		public static extern ulong ovrAvatar_GetReferencedAsset(IntPtr avatar, uint index);

		[PreserveSig]
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x1CB4D50", Offset = "0x1CB4D50", VA = "0x1CB4D50")]
		public static extern void ovrAvatar_SetLeftHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x1CB4DE0", Offset = "0x1CB4DE0", VA = "0x1CB4DE0")]
		public static extern void ovrAvatar_SetRightHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x1CB4E70", Offset = "0x1CB4E70", VA = "0x1CB4E70")]
		public static extern void ovrAvatar_SetLeftHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x1CB4F10", Offset = "0x1CB4F10", VA = "0x1CB4F10")]
		public static extern void ovrAvatar_SetRightHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x1CB4FB0", Offset = "0x1CB4FB0", VA = "0x1CB4FB0")]
		public static extern void ovrAvatar_UpdatePoseFromPacket(IntPtr avatar, IntPtr packet, float secondsFromStart);

		[PreserveSig]
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x1CB5050", Offset = "0x1CB5050", VA = "0x1CB5050")]
		public static extern void ovrAvatarPacket_BeginRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x1CB50D0", Offset = "0x1CB50D0", VA = "0x1CB50D0")]
		public static extern IntPtr ovrAvatarPacket_EndRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x1CB5150", Offset = "0x1CB5150", VA = "0x1CB5150")]
		public static extern uint ovrAvatarPacket_GetSize(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x1CB51D0", Offset = "0x1CB51D0", VA = "0x1CB51D0")]
		public static extern float ovrAvatarPacket_GetDurationSeconds(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x1CB5250", Offset = "0x1CB5250", VA = "0x1CB5250")]
		public static extern void ovrAvatarPacket_Free(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x1CB52D0", Offset = "0x1CB52D0", VA = "0x1CB52D0")]
		public static extern bool ovrAvatarPacket_Write(IntPtr packet, uint bufferSize, [Out] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x1CB53F8", Offset = "0x1CB53F8", VA = "0x1CB53F8")]
		public static extern IntPtr ovrAvatarPacket_Read(uint bufferSize, [In] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x1CB5490", Offset = "0x1CB5490", VA = "0x1CB5490")]
		private static extern void ovrAvatar_SetInternalForceASTCTextures(bool value);

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x1CB5510", Offset = "0x1CB5510", VA = "0x1CB5510")]
		public static void ovrAvatar_SetForceASTCTextures(bool value)
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x1CB5570", Offset = "0x1CB5570", VA = "0x1CB5570")]
		public static void ovrAvatar_OverrideExpressiveLogic(IntPtr avatar, ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x1CB56B8", Offset = "0x1CB56B8", VA = "0x1CB56B8")]
		private static extern void ovrAvatar_OverrideExpressiveLogic_Native(IntPtr avatar, IntPtr state);

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x1CB5748", Offset = "0x1CB5748", VA = "0x1CB5748")]
		public static void ovrAvatar_SetVisemes(IntPtr avatar, ovrAvatarVisemes visemes)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x1CB58A0", Offset = "0x1CB58A0", VA = "0x1CB58A0")]
		private static extern void ovrAvatar_SetVisemes_Native(IntPtr avatar, IntPtr visemes);

		[PreserveSig]
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x1CB5930", Offset = "0x1CB5930", VA = "0x1CB5930")]
		public static extern void ovrAvatar_UpdateWorldTransform(IntPtr avatar, ovrAvatarTransform transform);

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x1CB59D0", Offset = "0x1CB59D0", VA = "0x1CB59D0")]
		public static void ovrAvatar_UpdateGazeTargets(ovrAvatarGazeTargets targets)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x1CB5DA0", Offset = "0x1CB5DA0", VA = "0x1CB5DA0")]
		private static extern void ovrAvatar_UpdateGazeTargets_Native(IntPtr targets);

		[PreserveSig]
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x1CB5E20", Offset = "0x1CB5E20", VA = "0x1CB5E20")]
		public static extern void ovrAvatar_RemoveGazeTargets(uint targetCount, uint[] ids);

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x1CB5EB8", Offset = "0x1CB5EB8", VA = "0x1CB5EB8")]
		public static void ovrAvatar_UpdateLights(ovrAvatarLights lights)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x1CB6718", Offset = "0x1CB6718", VA = "0x1CB6718")]
		private static extern void ovrAvatar_UpdateLights_Native(IntPtr lights);

		[PreserveSig]
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x1CB6798", Offset = "0x1CB6798", VA = "0x1CB6798")]
		public static extern void ovrAvatar_RemoveLights(uint lightCount, uint[] ids);

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x1CAFB48", Offset = "0x1CAFB48", VA = "0x1CAFB48")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA087F4", Offset = "0xA087F4")]
		public static void LoggingCallback(IntPtr str)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x1CB6830", Offset = "0x1CB6830", VA = "0x1CB6830")]
		public static extern void ovrAvatar_RegisterLoggingCallback(LoggingDelegate callback);

		[PreserveSig]
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x1CB68B4", Offset = "0x1CB68B4", VA = "0x1CB68B4")]
		public static extern void ovrAvatar_SetLoggingLevel(ovrAvatarLogLevel level);

		[PreserveSig]
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x1CB6934", Offset = "0x1CB6934", VA = "0x1CB6934")]
		public static extern IntPtr ovrAvatar_GetDebugTransforms_Native(IntPtr count);

		[PreserveSig]
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x1CB69B4", Offset = "0x1CB69B4", VA = "0x1CB69B4")]
		public static extern IntPtr ovrAvatar_GetDebugLines_Native(IntPtr count);

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x1CB6A34", Offset = "0x1CB6A34", VA = "0x1CB6A34")]
		public static void ovrAvatar_DrawDebugLines()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x1CB73F8", Offset = "0x1CB73F8", VA = "0x1CB73F8")]
		public static extern void ovrAvatar_SetDebugDrawContext(uint context);

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x1CB7478", Offset = "0x1CB7478", VA = "0x1CB7478")]
		public static bool SendEvent(string name, string param = "", string source = "")
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x1CB78B4", Offset = "0x1CB78B4", VA = "0x1CB78B4")]
		private static extern IntPtr _ovrp_GetVersion();

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x1CB781C", Offset = "0x1CB781C", VA = "0x1CB781C")]
		public static string ovrp_GetVersion()
		{
			return null;
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x1CB7928", Offset = "0x1CB7928", VA = "0x1CB7928")]
		public CAPI()
		{
		}
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x200024F")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x2000250")]
		private class CameraState
		{
			[Token(Token = "0x4000CCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000CCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000CCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000CCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000CCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000CCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x14C41FC", Offset = "0x14C41FC", VA = "0x14C41FC")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x14C4284", Offset = "0x14C4284", VA = "0x14C4284")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x14C4300", Offset = "0x14C4300", VA = "0x14C4300")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x14C43C8", Offset = "0x14C43C8", VA = "0x14C43C8")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x14C4414", Offset = "0x14C4414", VA = "0x14C4414")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x4000CC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x4000CC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x4000CC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA03AD8", Offset = "0xA03AD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA03AD8", Offset = "0xA03AD8")]
		public float boost;

		[Token(Token = "0x4000CC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA03B38", Offset = "0xA03B38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA03B38", Offset = "0xA03B38")]
		public float positionLerpTime;

		[Token(Token = "0x4000CC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA03B90", Offset = "0xA03B90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA03B90", Offset = "0xA03B90")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000CC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA03BF0", Offset = "0xA03BF0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA03BF0", Offset = "0xA03BF0")]
		public float rotationLerpTime;

		[Token(Token = "0x4000CC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA03C48", Offset = "0xA03C48")]
		public bool invertY;

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0xE308F4", Offset = "0xE308F4", VA = "0xE308F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0xE30954", Offset = "0xE30954", VA = "0xE30954")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0xE30A68", Offset = "0xE30A68", VA = "0xE30A68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0xE30CEC", Offset = "0xE30CEC", VA = "0xE30CEC")]
		public SimpleCameraController()
		{
		}
	}
}
namespace CrazyMinnow.SALSA.Timeline
{
	[Serializable]
	[Token(Token = "0x2000251")]
	public class EmoterControl : PlayableAsset, ITimelineClipAsset
	{
		[Token(Token = "0x4000CD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EmoterControlBehavior template;

		[Token(Token = "0x17000115")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x1D1D99C", Offset = "0x1D1D99C", VA = "0x1D1D99C", Slot = "9")]
			get
			{
				return default(ClipCaps);
			}
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x1D1D8E8", Offset = "0x1D1D8E8", VA = "0x1D1D8E8", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x1D1D9A4", Offset = "0x1D1D9A4", VA = "0x1D1D9A4")]
		public EmoterControl()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000252")]
	public class EmoterControlBehavior : PlayableBehaviour
	{
		[Token(Token = "0x4000CD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string emoteName;

		[Token(Token = "0x4000CD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isAnimatingOn;

		[Token(Token = "0x4000CD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ExpressionComponent.ExpressionHandler handler;

		[Token(Token = "0x4000CD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool dynamics;

		[Token(Token = "0x4000CD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA03C80", Offset = "0xA03C80")]
		public float dynamicsAmount;

		[Token(Token = "0x4000CD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA03C98", Offset = "0xA03C98")]
		public float dynamicsTiming;

		[Token(Token = "0x4000CD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Emoter trackBinding;

		[Token(Token = "0x4000CD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isTrackBindingCached;

		[Token(Token = "0x4000CD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool settingsHaveBeenCaptured;

		[Token(Token = "0x4000CDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool resetAtClipEnd;

		[Token(Token = "0x4000CDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Playable rootPlayable;

		[Token(Token = "0x4000CDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isDebug;

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x1D1DA88", Offset = "0x1D1DA88", VA = "0x1D1DA88", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x1D1DB20", Offset = "0x1D1DB20", VA = "0x1D1DB20", Slot = "20")]
		public override void ProcessFrame(Playable playableHandle, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x1D1DDE0", Offset = "0x1D1DDE0", VA = "0x1D1DDE0", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x1D1E01C", Offset = "0x1D1E01C", VA = "0x1D1E01C", Slot = "18")]
		public override void OnBehaviourPause(Playable playableHandle, FrameData info)
		{
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x1D1DF40", Offset = "0x1D1DF40", VA = "0x1D1DF40")]
		private void ClipStarted(Playable playableHandle)
		{
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x1D1DD54", Offset = "0x1D1DD54", VA = "0x1D1DD54")]
		private void ClipPlaying(Playable playableHandle)
		{
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x1D1DCC8", Offset = "0x1D1DCC8", VA = "0x1D1DCC8")]
		private void ClipStopped()
		{
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x1D1DEB4", Offset = "0x1D1DEB4", VA = "0x1D1DEB4")]
		private void CaptureOriginalSettings()
		{
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x1D1E0D4", Offset = "0x1D1E0D4", VA = "0x1D1E0D4")]
		private void ResetSettings()
		{
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x1D1DA10", Offset = "0x1D1DA10", VA = "0x1D1DA10")]
		public EmoterControlBehavior()
		{
		}
	}
	[Token(Token = "0x2000253")]
	public class EmoterControlMixer : PlayableBehaviour
	{
		[Token(Token = "0x4000CDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float timecheck;

		[Token(Token = "0x4000CDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<EmoterControlBehavior> behaviors;

		[Token(Token = "0x4000CDF")]
		private const float NO_DURATION = 0f;

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x1D1E168", Offset = "0x1D1E168", VA = "0x1D1E168", Slot = "20")]
		public override void ProcessFrame(Playable playableHandle, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x1D1E6BC", Offset = "0x1D1E6BC", VA = "0x1D1E6BC")]
		public EmoterControlMixer()
		{
		}
	}
	[Token(Token = "0x2000254")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x9FF94C", Offset = "0x9FF94C")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x9FF94C", Offset = "0x9FF94C")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x9FF94C", Offset = "0x9FF94C")]
	public class EmoterControlTrack : TrackAsset
	{
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x1D1E740", Offset = "0x1D1E740", VA = "0x1D1E740", Slot = "24")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x1D1EBEC", Offset = "0x1D1EBEC", VA = "0x1D1EBEC")]
		public EmoterControlTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000255")]
	public class EyesControl : PlayableAsset, ITimelineClipAsset
	{
		[Token(Token = "0x4000CE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EyesControlBehavior template;

		[Token(Token = "0x17000116")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0x1D1FE44", Offset = "0x1D1FE44", VA = "0x1D1FE44", Slot = "9")]
			get
			{
				return default(ClipCaps);
			}
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x1D1FD90", Offset = "0x1D1FD90", VA = "0x1D1FD90", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x1D1FE4C", Offset = "0x1D1FE4C", VA = "0x1D1FE4C")]
		public EyesControl()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000256")]
	public class EyesControlBehavior : PlayableBehaviour
	{
		[Token(Token = "0x4000CE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string clipName;

		[Token(Token = "0x4000CE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool manualBlink;

		[Token(Token = "0x4000CE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool blinkCustomTiming;

		[Token(Token = "0x4000CE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blinkON;

		[Token(Token = "0x4000CE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float blinkHOLD;

		[Token(Token = "0x4000CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float blinkOFF;

		[Token(Token = "0x4000CE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool enableHead;

		[Token(Token = "0x4000CE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool enableEyes;

		[Token(Token = "0x4000CE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool enableBlink;

		[Token(Token = "0x4000CEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool enableTrack;

		[Token(Token = "0x4000CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool filterEnableHead;

		[Token(Token = "0x4000CEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool filterEnableEyes;

		[Token(Token = "0x4000CED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public bool filterEnableBlink;

		[Token(Token = "0x4000CEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
		public bool filterEnableTrack;

		[Token(Token = "0x4000CEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookTarget;

		[Token(Token = "0x4000CF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool filterLookTarget;

		[Token(Token = "0x4000CF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool useAffinity;

		[Token(Token = "0x4000CF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool filterUseAffinity;

		[Token(Token = "0x4000CF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float percentage;

		[Token(Token = "0x4000CF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float timerMin;

		[Token(Token = "0x4000CF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float timerMax;

		[Token(Token = "0x4000CF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool setHeadRandom;

		[Token(Token = "0x4000CF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool setEyesRandom;

		[Token(Token = "0x4000CF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool setBlinkRandom;

		[Token(Token = "0x4000CF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		public bool filterSetHeadRandom;

		[Token(Token = "0x4000CFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool filterSetEyesRandom;

		[Token(Token = "0x4000CFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool filterSetBlinkRandom;

		[Token(Token = "0x4000CFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		private bool origEnableHead;

		[Token(Token = "0x4000CFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		private bool origEnableEyes;

		[Token(Token = "0x4000CFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool origEnableBlink;

		[Token(Token = "0x4000CFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool origEnableTrack;

		[Token(Token = "0x4000D00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform origLookTarget;

		[Token(Token = "0x4000D01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool origUseAffinity;

		[Token(Token = "0x4000D02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float origPercentage;

		[Token(Token = "0x4000D03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float origTimerMin;

		[Token(Token = "0x4000D04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float origTimerMax;

		[Token(Token = "0x4000D05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool origHeadRand;

		[Token(Token = "0x4000D06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool origEyesRand;

		[Token(Token = "0x4000D07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		private bool origBlinkRand;

		[Token(Token = "0x4000D08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Eyes trackBinding;

		[Token(Token = "0x4000D09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool isTrackBindingCached;

		[Token(Token = "0x4000D0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool settingsHaveBeenCaptured;

		[Token(Token = "0x4000D0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		public bool resetAtClipEnd;

		[Token(Token = "0x4000D0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Playable rootPlayable;

		[Token(Token = "0x4000D0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isDebug;

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x1D1FF58", Offset = "0x1D1FF58", VA = "0x1D1FF58", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x1D1FFF0", Offset = "0x1D1FFF0", VA = "0x1D1FFF0", Slot = "20")]
		public override void ProcessFrame(Playable playableHandle, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x1D202B0", Offset = "0x1D202B0", VA = "0x1D202B0", Slot = "17")]
		public override void OnBehaviourPlay(Playable playableHandle, FrameData info)
		{
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x1D206E8", Offset = "0x1D206E8", VA = "0x1D206E8", Slot = "18")]
		public override void OnBehaviourPause(Playable playableHandle, FrameData info)
		{
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x1D20468", Offset = "0x1D20468", VA = "0x1D20468")]
		private void ClipStarted(Playable playableHandle)
		{
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x1D20224", Offset = "0x1D20224", VA = "0x1D20224")]
		private void ClipPlaying(Playable playableHandle)
		{
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x1D20198", Offset = "0x1D20198", VA = "0x1D20198")]
		private void ClipStopped()
		{
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x1D20368", Offset = "0x1D20368", VA = "0x1D20368")]
		private void CaptureOriginalSettings()
		{
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x1D207A0", Offset = "0x1D207A0", VA = "0x1D207A0")]
		private void ResetSettings()
		{
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x1D1FEB8", Offset = "0x1D1FEB8", VA = "0x1D1FEB8")]
		public EyesControlBehavior()
		{
		}
	}
	[Token(Token = "0x2000257")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x9FFA08", Offset = "0x9FFA08")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x9FFA08", Offset = "0x9FFA08")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x9FFA08", Offset = "0x9FFA08")]
	public class EyesControlTrack : TrackAsset
	{
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x1D20908", Offset = "0x1D20908", VA = "0x1D20908", Slot = "24")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x1D20DB4", Offset = "0x1D20DB4", VA = "0x1D20DB4")]
		public EyesControlTrack()
		{
		}
	}
	[Token(Token = "0x2000258")]
	public class EyesControlMixer : PlayableBehaviour
	{
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x1D20900", Offset = "0x1D20900", VA = "0x1D20900")]
		public EyesControlMixer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000259")]
	public class SalsaControl : PlayableAsset, ITimelineClipAsset
	{
		[Token(Token = "0x4000D0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SalsaControlBehavior template;

		[Token(Token = "0x17000117")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0xFF6328", Offset = "0xFF6328", VA = "0xFF6328", Slot = "9")]
			get
			{
				return default(ClipCaps);
			}
		}

		[Token(Token = "0x17000118")]
		public override double duration
		{
			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0xFF6330", Offset = "0xFF6330", VA = "0xFF6330", Slot = "7")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0xFF6274", Offset = "0xFF6274", VA = "0xFF6274", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0xFF6404", Offset = "0xFF6404", VA = "0xFF6404")]
		public SalsaControl()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200025A")]
	public class SalsaControlBehavior : PlayableBehaviour
	{
		[Token(Token = "0x4000D0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LocalizedAudioClip audioI18NClip;

		[Token(Token = "0x4000D10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip audioClip;

		[Token(Token = "0x4000D11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool overrideDynamics;

		[Token(Token = "0x4000D12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA03CB0", Offset = "0xA03CB0")]
		public float advDynamicsBias;

		[Token(Token = "0x4000D13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA03CC8", Offset = "0xA03CC8")]
		public float globalDynamics;

		[Token(Token = "0x4000D14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float origAdvDynamicsBias;

		[Token(Token = "0x4000D15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float origGlobalDynamics;

		[Token(Token = "0x4000D16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Salsa trackBinding;

		[Token(Token = "0x4000D17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isTrackBindingCached;

		[Token(Token = "0x4000D18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool settingsHaveBeenCaptured;

		[Token(Token = "0x4000D19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool resetAtClipEnd;

		[Token(Token = "0x4000D1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Playable rootPlayable;

		[Token(Token = "0x4000D1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isDebug;

		[Token(Token = "0x4000D1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float scrubbingThreshold;

		[Token(Token = "0x4000D1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private LocalizedAudio audioLoc;

		[Token(Token = "0x4000D1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UnityAction<SystemLanguage> action;

		[Token(Token = "0x4000D1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AudioSource source;

		[Token(Token = "0x4000D20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA03CE0", Offset = "0xA03CE0")]
		private bool <IsRunning>k__BackingField;

		[Token(Token = "0x4000D21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		private bool IsRealSource;

		[Token(Token = "0x17000119")]
		public bool IsRunning
		{
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0xFF6530", Offset = "0xFF6530", VA = "0xFF6530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08854", Offset = "0xA08854")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0xFF6538", Offset = "0xFF6538", VA = "0xFF6538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08864", Offset = "0xA08864")]
			private set
			{
			}
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0xFF6470", Offset = "0xFF6470", VA = "0xFF6470")]
		public SalsaControlBehavior()
		{
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0xFF6544", Offset = "0xFF6544", VA = "0xFF6544")]
		public void UpdateAddressableReference()
		{
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0xFF6794", Offset = "0xFF6794", VA = "0xFF6794")]
		public void UpdateClipReference(AudioClip iClip)
		{
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0xFF6848", Offset = "0xFF6848", VA = "0xFF6848")]
		private void StartClip(float time)
		{
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0xFF6B20", Offset = "0xFF6B20", VA = "0xFF6B20")]
		private void PlayClip(float time)
		{
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0xFF6C64", Offset = "0xFF6C64", VA = "0xFF6C64")]
		private void StopClip()
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0xFF6D38", Offset = "0xFF6D38", VA = "0xFF6D38", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0xFF6DD0", Offset = "0xFF6DD0", VA = "0xFF6DD0", Slot = "20")]
		public override void ProcessFrame(Playable playableHandle, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0xFF7248", Offset = "0xFF7248", VA = "0xFF7248", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0xFF7560", Offset = "0xFF7560", VA = "0xFF7560", Slot = "18")]
		public override void OnBehaviourPause(Playable playableHandle, FrameData info)
		{
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0xFF73F0", Offset = "0xFF73F0", VA = "0xFF73F0")]
		private void ClipStarted(Playable playableHandle)
		{
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0xFF7108", Offset = "0xFF7108", VA = "0xFF7108")]
		private void ClipPlaying(Playable playableHandle)
		{
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0xFF7080", Offset = "0xFF7080", VA = "0xFF7080")]
		private void ClipStopped()
		{
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0xFF7348", Offset = "0xFF7348", VA = "0xFF7348")]
		private void CaptureOriginalSettings()
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0xFF7628", Offset = "0xFF7628", VA = "0xFF7628")]
		private void ResetSettings()
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0xFF6C04", Offset = "0xFF6C04", VA = "0xFF6C04")]
		private bool IsScrubbingActiveClip(float iTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0xFF76D8", Offset = "0xFF76D8", VA = "0xFF76D8")]
		private void PlayAudio(Playable playableHandle)
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0xFF78A4", Offset = "0xFF78A4", VA = "0xFF78A4")]
		private void PauseAudio()
		{
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0xFF7980", Offset = "0xFF7980", VA = "0xFF7980")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA08874", Offset = "0xA08874")]
		private void <.ctor>b__22_0(SystemLanguage e)
		{
		}
	}
	[Token(Token = "0x200025B")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x9FFAC4", Offset = "0x9FFAC4")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x9FFAC4", Offset = "0x9FFAC4")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x9FFAC4", Offset = "0x9FFAC4")]
	public class SalsaControlTrack : TrackAsset
	{
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0xFF798C", Offset = "0xFF798C", VA = "0xFF798C", Slot = "24")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0xFF7E38", Offset = "0xFF7E38", VA = "0xFF7E38")]
		public SalsaControlTrack()
		{
		}
	}
	[Token(Token = "0x200025C")]
	public class SalsaControlMixer : PlayableBehaviour
	{
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0xFF7984", Offset = "0xFF7984", VA = "0xFF7984")]
		public SalsaControlMixer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200025D")]
	public class SalsaTextSyncBehavior : PlayableBehaviour
	{
		[Token(Token = "0x4000D22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string textSyncText;

		[Token(Token = "0x4000D23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SalsaTextSync salsaTextSync;

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0xE2B668", Offset = "0xE2B668", VA = "0xE2B668")]
		public SalsaTextSyncBehavior()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200025E")]
	public class SalsaTextSyncClip : PlayableAsset, ITimelineClipAsset
	{
		[Token(Token = "0x4000D24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SalsaTextSyncBehavior template;

		[Token(Token = "0x1700011A")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0xE2B778", Offset = "0xE2B778", VA = "0xE2B778", Slot = "9")]
			get
			{
				return default(ClipCaps);
			}
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0xE2B6C4", Offset = "0xE2B6C4", VA = "0xE2B6C4", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0xE2B780", Offset = "0xE2B780", VA = "0xE2B780")]
		public SalsaTextSyncClip()
		{
		}
	}
	[Token(Token = "0x200025F")]
	public class SalsaTextSyncMixer : PlayableBehaviour
	{
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0xE2B7EC", Offset = "0xE2B7EC", VA = "0xE2B7EC", Slot = "20")]
		public override void ProcessFrame(Playable playableHandle, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0xE2BA80", Offset = "0xE2BA80", VA = "0xE2BA80")]
		public SalsaTextSyncMixer()
		{
		}
	}
	[Token(Token = "0x2000260")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x9FFB80", Offset = "0x9FFB80")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x9FFB80", Offset = "0x9FFB80")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x9FFB80", Offset = "0x9FFB80")]
	public class SalsaTextSyncTrack : TrackAsset
	{
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0xE2BA88", Offset = "0xE2BA88", VA = "0xE2BA88", Slot = "24")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0xE2BFC0", Offset = "0xE2BFC0", VA = "0xE2BFC0")]
		public SalsaTextSyncTrack()
		{
		}
	}
}
namespace CrazyMinnow.SALSA.TextSync
{
	[Token(Token = "0x2000261")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9FFC3C", Offset = "0x9FFC3C")]
	public class SalsaTextSync : MonoBehaviour
	{
		[Token(Token = "0x2000262")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9FFC74", Offset = "0x9FFC74")]
		private sealed class <TalkTime>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000D36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000D37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000D38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SalsaTextSync <>4__this;

			[Token(Token = "0x4000D39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x1700011B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B1E")]
				[Address(RVA = "0x14C412C", Offset = "0x14C412C", VA = "0x14C412C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B20")]
				[Address(RVA = "0x14C4174", Offset = "0x14C4174", VA = "0x14C4174", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x14C4020", Offset = "0x14C4020", VA = "0x14C4020")]
			[DebuggerHidden]
			public <TalkTime>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x14C404C", Offset = "0x14C404C", VA = "0x14C404C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x14C4050", Offset = "0x14C4050", VA = "0x14C4050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x14C4134", Offset = "0x14C4134", VA = "0x14C4134", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000D25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Salsa salsa;

		[Token(Token = "0x4000D26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float wordsPerMinute;

		[Token(Token = "0x4000D27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string text;

		[Token(Token = "0x4000D28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool textSyncIsTalking;

		[Token(Token = "0x4000D29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool usePreferredSalsaSettings;

		[Token(Token = "0x4000D2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float updateTimeCheck;

		[Token(Token = "0x4000D2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IEnumerator coroutine;

		[Token(Token = "0x4000D2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudioSource salsaAudSrc;

		[Token(Token = "0x4000D2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<float> salsaTriggers;

		[Token(Token = "0x4000D2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool salsaAdvDyn;

		[Token(Token = "0x4000D2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float salsaAdvDynBias;

		[Token(Token = "0x4000D30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool salsaUseAdvDynJitter;

		[Token(Token = "0x4000D31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float salsaLoCutoff;

		[Token(Token = "0x4000D32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float salsaHiCutoff;

		[Token(Token = "0x4000D33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool salsaUseExternalAnalysis;

		[Token(Token = "0x4000D34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float salsaUpdateDelay;

		[Token(Token = "0x4000D35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool settingsHaveBeenCollectedAtLeastOnce;

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0xFF7E9C", Offset = "0xFF7E9C", VA = "0xFF7E9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0xFF7FD0", Offset = "0xFF7FD0", VA = "0xFF7FD0")]
		public void SetPreferredSalsaSettings()
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0xFF8074", Offset = "0xFF8074", VA = "0xFF8074")]
		private void CollectSalsaSettings()
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0xFF82E0", Offset = "0xFF82E0", VA = "0xFF82E0")]
		public void ResetSalsaSettings()
		{
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0xFF8544", Offset = "0xFF8544", VA = "0xFF8544")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0xFF861C", Offset = "0xFF861C", VA = "0xFF861C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA08884", Offset = "0xA08884")]
		private IEnumerator TalkTime(float duration)
		{
			return null;
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0xFF86A4", Offset = "0xFF86A4", VA = "0xFF86A4")]
		public void Say(string text)
		{
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0xFF8864", Offset = "0xFF8864", VA = "0xFF8864")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0xFF88A8", Offset = "0xFF88A8", VA = "0xFF88A8")]
		public SalsaTextSync()
		{
		}
	}
	[Token(Token = "0x2000263")]
	public class SalsaTextSync_ExampleBasicGUI : MonoBehaviour
	{
		[Token(Token = "0x4000D3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA03CF0", Offset = "0xA03CF0")]
		public float fillPercentage;

		[Token(Token = "0x4000D3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string text;

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0xE2C024", Offset = "0xE2C024", VA = "0xE2C024")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0xE2C2A0", Offset = "0xE2C2A0", VA = "0xE2C2A0")]
		public SalsaTextSync_ExampleBasicGUI()
		{
		}
	}
}
namespace WFShaderDemo
{
	[Token(Token = "0x2000264")]
	public class DemoFreeFlyCamera : MonoBehaviour
	{
		[Token(Token = "0x4000D3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool lockCursor;

		[Token(Token = "0x4000D3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float cameraSensitivity;

		[Token(Token = "0x4000D3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float normalMoveSpeed;

		[Token(Token = "0x4000D3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float smoothTime;

		[Token(Token = "0x4000D40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Camera cam;

		[Token(Token = "0x4000D41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationX;

		[Token(Token = "0x4000D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float rotationY;

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x1D1AD28", Offset = "0x1D1AD28", VA = "0x1D1AD28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x1D1AD58", Offset = "0x1D1AD58", VA = "0x1D1AD58")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x1D1B1AC", Offset = "0x1D1B1AC", VA = "0x1D1B1AC")]
		public DemoFreeFlyCamera()
		{
		}
	}
	[Token(Token = "0x2000265")]
	public class ProjectorMovement : MonoBehaviour
	{
		[Token(Token = "0x4000D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0xFF0CF0", Offset = "0xFF0CF0", VA = "0xFF0CF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0xFF0CF4", Offset = "0xFF0CF4", VA = "0xFF0CF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0xFF0D90", Offset = "0xFF0D90", VA = "0xFF0D90")]
		public ProjectorMovement()
		{
		}
	}
}
namespace Emissive
{
	[Token(Token = "0x2000266")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x9FFC84", Offset = "0x9FFC84")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x9FFC84", Offset = "0x9FFC84")]
	public class DialogTrack_GD : MarkerTrack
	{
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x1D1B4D0", Offset = "0x1D1B4D0", VA = "0x1D1B4D0")]
		public DialogTrack_GD()
		{
		}
	}
	[Token(Token = "0x2000267")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x9FFD04", Offset = "0x9FFD04")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x9FFD04", Offset = "0x9FFD04")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x9FFD04", Offset = "0x9FFD04")]
	public class CameraCinePriority_Track : TrackAsset
	{
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x1CB7E78", Offset = "0x1CB7E78", VA = "0x1CB7E78")]
		public CameraCinePriority_Track()
		{
		}
	}
	[Token(Token = "0x2000268")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x9FFDB4", Offset = "0x9FFDB4")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x9FFDB4", Offset = "0x9FFDB4")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x9FFDB4", Offset = "0x9FFDB4")]
	public class CharacterNavigation_Track : TrackAsset
	{
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x1CBBC54", Offset = "0x1CBBC54", VA = "0x1CBBC54")]
		public CharacterNavigation_Track()
		{
		}
	}
	[Token(Token = "0x2000269")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x9FFE64", Offset = "0x9FFE64")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x9FFE64", Offset = "0x9FFE64")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x9FFE64", Offset = "0x9FFE64")]
	public class GroupLookAtTarget_Track : TrackAsset
	{
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x1D281B4", Offset = "0x1D281B4", VA = "0x1D281B4")]
		public GroupLookAtTarget_Track()
		{
		}
	}
	[Token(Token = "0x200026A")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x9FFF14", Offset = "0x9FFF14")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x9FFF14", Offset = "0x9FFF14")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x9FFF14", Offset = "0x9FFF14")]
	public class GroupMoveToTarget_Track : TrackAsset
	{
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x1D28838", Offset = "0x1D28838", VA = "0x1D28838")]
		public GroupMoveToTarget_Track()
		{
		}
	}
	[Token(Token = "0x200026B")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x9FFFC4", Offset = "0x9FFFC4")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x9FFFC4", Offset = "0x9FFFC4")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x9FFFC4", Offset = "0x9FFFC4")]
	public class GroupNavigation_Track : TrackAsset
	{
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x1D2917C", Offset = "0x1D2917C", VA = "0x1D2917C")]
		public GroupNavigation_Track()
		{
		}
	}
	[Token(Token = "0x200026C")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xA00074", Offset = "0xA00074")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xA00074", Offset = "0xA00074")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xA00074", Offset = "0xA00074")]
	public class GroupParenting_Track : TrackAsset
	{
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x1E5E0A0", Offset = "0x1E5E0A0", VA = "0x1E5E0A0")]
		public GroupParenting_Track()
		{
		}
	}
	[Token(Token = "0x200026D")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xA00124", Offset = "0xA00124")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xA00124", Offset = "0xA00124")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xA00124", Offset = "0xA00124")]
	public class LookAtTarget_Track : TrackAsset
	{
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x1E6F204", Offset = "0x1E6F204", VA = "0x1E6F204")]
		public LookAtTarget_Track()
		{
		}
	}
	[Token(Token = "0x200026E")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xA001D4", Offset = "0xA001D4")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xA001D4", Offset = "0xA001D4")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xA001D4", Offset = "0xA001D4")]
	public class MoveToTarget_Track : TrackAsset
	{
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x123D584", Offset = "0x123D584", VA = "0x123D584")]
		public MoveToTarget_Track()
		{
		}
	}
}
