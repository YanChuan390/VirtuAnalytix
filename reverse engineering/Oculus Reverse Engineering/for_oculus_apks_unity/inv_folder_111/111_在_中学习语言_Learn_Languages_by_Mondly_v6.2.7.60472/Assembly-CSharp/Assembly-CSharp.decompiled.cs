using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ATiStudios.Foundation;
using ATiStudios.MondlyVR.Storyline;
using CrazyMinnow.SALSA;
using FlyingWormConsole3.LiteNetLib.Layers;
using FlyingWormConsole3.LiteNetLib.Utils;
using Il2CppDummyDll;
using JetBrains.Annotations;
using RootMotion.FinalIK;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Banknote : MonoBehaviour, IStorylineActor
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator _animator;

	[Token(Token = "0x17000001")]
	public string ActorName
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xD5F7A0", Offset = "0xD5F7A0", VA = "0xD5F7A0", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xD5F7A8", Offset = "0xD5F7A8", VA = "0xD5F7A8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xD5F748", Offset = "0xD5F748", VA = "0xD5F748")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xD5F7B0", Offset = "0xD5F7B0", VA = "0xD5F7B0")]
	public void Continue()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xD5F7F0", Offset = "0xD5F7F0", VA = "0xD5F7F0")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xD5F830", Offset = "0xD5F830", VA = "0xD5F830")]
	public void PlayAnimation(string animationName)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xD5F84C", Offset = "0xD5F84C", VA = "0xD5F84C")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xD5F88C", Offset = "0xD5F88C", VA = "0xD5F88C")]
	public void StartActor()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xD5F8CC", Offset = "0xD5F8CC", VA = "0xD5F8CC")]
	public void Stop()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xD5F90C", Offset = "0xD5F90C", VA = "0xD5F90C")]
	public Banknote()
	{
	}
}
[Token(Token = "0x2000003")]
public class WaterSprayEffectController : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem _particles;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xD5F914", Offset = "0xD5F914", VA = "0xD5F914")]
	public void StartEffect()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xD5F950", Offset = "0xD5F950", VA = "0xD5F950")]
	public void StopEffect()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xD5F98C", Offset = "0xD5F98C", VA = "0xD5F98C")]
	public WaterSprayEffectController()
	{
	}
}
[Token(Token = "0x2000004")]
public class EarthRotate : MonoBehaviour
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float EarthSpeed;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xD5F994", Offset = "0xD5F994", VA = "0xD5F994")]
	private void Start()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xD5F998", Offset = "0xD5F998", VA = "0xD5F998")]
	private void Update()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xD5FA58", Offset = "0xD5FA58", VA = "0xD5FA58")]
	public EarthRotate()
	{
	}
}
[Token(Token = "0x2000005")]
public class BeltSpawner : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Spawner Settings")]
	public GameObject[] asteroidPrefabs;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int asteroidDensity;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int seed;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float innerRadius;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float outerRadius;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float height;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool rotatingClockwise;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject rockParent;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 rockOffsetPosition;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Elipse path;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("Asteroid Settings")]
	public float minRotationSpeed;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float maxRotationSpeed;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 localPosition;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 worldPosition;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 asteroidScale;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float randomRadius;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float randomRadian;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float x;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float y;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float z;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float randomScale;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float minScale;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float maxScale;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD5FA6C", Offset = "0xD5FA6C", VA = "0xD5FA6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xD600C0", Offset = "0xD600C0", VA = "0xD600C0")]
	public BeltSpawner()
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public class Elipse
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float xAxis;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float yAxis;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xD60124", Offset = "0xD60124", VA = "0xD60124")]
	public Elipse(float xAxis, float yAxis)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xD60150", Offset = "0xD60150", VA = "0xD60150")]
	public Vector2 Evaluate(float t)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xD60190", Offset = "0xD60190", VA = "0xD60190")]
	public float GetPerimeter()
	{
		return default(float);
	}
}
[Token(Token = "0x2000007")]
[RequireComponent(typeof(LineRenderer))]
public class ElipseRenderer : MonoBehaviour
{
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(3f, 200f)]
	public int segments;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Elipse elipse;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xD601CC", Offset = "0xD601CC", VA = "0xD601CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xD6022C", Offset = "0xD6022C", VA = "0xD6022C")]
	private void CalculateElipse()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xD60388", Offset = "0xD60388", VA = "0xD60388")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xD6040C", Offset = "0xD6040C", VA = "0xD6040C")]
	public ElipseRenderer()
	{
	}
}
[Token(Token = "0x2000008")]
public class OrbitMotion : BaseMonoBehaviour
{
	[Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class <AnimateOrbit>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OrbitMotion <>4__this;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <progressPerSecond>5__2;

		[Token(Token = "0x17000002")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0xD608A8", Offset = "0xD608A8", VA = "0xD608A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0xD608F0", Offset = "0xD608F0", VA = "0xD608F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xD6063C", Offset = "0xD6063C", VA = "0xD6063C")]
		[DebuggerHidden]
		public <AnimateOrbit>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xD607B4", Offset = "0xD607B4", VA = "0xD607B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xD607B8", Offset = "0xD607B8", VA = "0xD607B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xD608B0", Offset = "0xD608B0", VA = "0xD608B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class <MoveToPosition>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OrbitMotion <>4__this;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float timeToReach;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <remainingProgress>5__2;

		[Token(Token = "0x17000004")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0xD60AB0", Offset = "0xD60AB0", VA = "0xD60AB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0xD60AF8", Offset = "0xD60AF8", VA = "0xD60AF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xD606E8", Offset = "0xD606E8", VA = "0xD606E8")]
		[DebuggerHidden]
		public <MoveToPosition>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xD608F8", Offset = "0xD608F8", VA = "0xD608F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xD608FC", Offset = "0xD608FC", VA = "0xD608FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xD60AB8", Offset = "0xD60AB8", VA = "0xD60AB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform orbitingObject;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Elipse path;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float progress;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float period;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool orbitActive;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float yPos;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool isDone;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int _enableCount;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Coroutine _routineAnimateOrbit;

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xD6041C", Offset = "0xD6041C", VA = "0xD6041C", Slot = "10")]
	protected override void EnableComponent()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xD604E8", Offset = "0xD604E8", VA = "0xD604E8", Slot = "12")]
	protected override void StartComponent()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xD6060C", Offset = "0xD6060C", VA = "0xD6060C", Slot = "15")]
	protected override void DisableComponent()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xD5FFE8", Offset = "0xD5FFE8", VA = "0xD5FFE8")]
	public void SetupOrbitMotion(float xAxis, float yAxis, Transform orbitingObject, float yPos)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xD60598", Offset = "0xD60598", VA = "0xD60598")]
	public void SetObjectPosition()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xD60474", Offset = "0xD60474", VA = "0xD60474")]
	[IteratorStateMachine(typeof(<AnimateOrbit>d__14))]
	public IEnumerator AnimateOrbit()
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xD60664", Offset = "0xD60664", VA = "0xD60664")]
	[IteratorStateMachine(typeof(<MoveToPosition>d__15))]
	public IEnumerator MoveToPosition(float timeToReach)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xD60710", Offset = "0xD60710", VA = "0xD60710")]
	private static bool RoughlyEqual(float a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xD60728", Offset = "0xD60728", VA = "0xD60728")]
	public OrbitMotion()
	{
	}
}
[Token(Token = "0x200000B")]
public class RotateScript : MonoBehaviour
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float planetSpeedRotation;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xD60B00", Offset = "0xD60B00", VA = "0xD60B00")]
	public void SetupRotateScript(float planetSpeedRotation)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xD60B08", Offset = "0xD60B08", VA = "0xD60B08")]
	private void Update()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xD60BA8", Offset = "0xD60BA8", VA = "0xD60BA8")]
	public RotateScript()
	{
	}
}
[Token(Token = "0x200000C")]
public class SatelliteRotation : MonoBehaviour
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject motherPlanet;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float orbitDistance;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float orbitDegreesPerSec;

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xD60BB8", Offset = "0xD60BB8", VA = "0xD60BB8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xD60E10", Offset = "0xD60E10", VA = "0xD60E10")]
	public SatelliteRotation()
	{
	}
}
[Token(Token = "0x200000D")]
public class SolarExplosionTap : MonoBehaviour
{
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem[] particles;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.ShapeModule[] shapes;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isClicked;

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xD60E24", Offset = "0xD60E24", VA = "0xD60E24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xD60EFC", Offset = "0xD60EFC", VA = "0xD60EFC")]
	public void SolarExplosion()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xD60F8C", Offset = "0xD60F8C", VA = "0xD60F8C")]
	public SolarExplosionTap()
	{
	}
}
[Token(Token = "0x200000E")]
public class SolarSystemTap : MonoBehaviour
{
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OrbitMotion[] motionScripts;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool isClicked;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float timeToReach;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int numberOfPlanets;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[CanBeNull]
	private Coroutine _routineMoveInLine;

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xD61028", Offset = "0xD61028", VA = "0xD61028")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xD61080", Offset = "0xD61080", VA = "0xD61080")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xD610D8", Offset = "0xD610D8", VA = "0xD610D8")]
	public void AllignPlanets()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xD611C8", Offset = "0xD611C8", VA = "0xD611C8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xD61238", Offset = "0xD61238", VA = "0xD61238")]
	public SolarSystemTap()
	{
	}
}
[Token(Token = "0x200000F")]
public class HoldCart : MonoBehaviour
{
	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FullBodyBipedIK ik;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform rightHandTarget;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform leftHandTarget;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xD6129C", Offset = "0xD6129C", VA = "0xD6129C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xD614B0", Offset = "0xD614B0", VA = "0xD614B0")]
	public void ChangeRightHandTarget(Transform target)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xD614B8", Offset = "0xD614B8", VA = "0xD614B8")]
	public void ChangeLeftHandTarget(Transform target)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xD614C0", Offset = "0xD614C0", VA = "0xD614C0")]
	public HoldCart()
	{
	}
}
[Token(Token = "0x2000010")]
public class HoldStearingWheel : MonoBehaviour
{
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FullBodyBipedIK ik;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform rightHandTarget;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform leftHandTarget;

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xD614C8", Offset = "0xD614C8", VA = "0xD614C8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xD61664", Offset = "0xD61664", VA = "0xD61664")]
	public HoldStearingWheel()
	{
	}
}
[Token(Token = "0x2000011")]
public class SALSA_Template_EventControllerSubscriber : MonoBehaviour
{
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string componentEventName;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xD6166C", Offset = "0xD6166C", VA = "0xD6166C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xD617AC", Offset = "0xD617AC", VA = "0xD617AC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xD618EC", Offset = "0xD618EC", VA = "0xD618EC")]
	private void OnAnimationStarting(object sender, EventController.EventControllerNotificationArgs e)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xD6199C", Offset = "0xD6199C", VA = "0xD6199C")]
	private void OnAnimationON(object sender, EventController.EventControllerNotificationArgs e)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xD61A4C", Offset = "0xD61A4C", VA = "0xD61A4C")]
	private void OnAnimationEnding(object sender, EventController.EventControllerNotificationArgs e)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xD61AFC", Offset = "0xD61AFC", VA = "0xD61AFC")]
	private void OnAnimationOFF(object sender, EventController.EventControllerNotificationArgs e)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xD61BAC", Offset = "0xD61BAC", VA = "0xD61BAC")]
	public SALSA_Template_EventControllerSubscriber()
	{
	}
}
[Token(Token = "0x2000012")]
public class SALSA_Template_SalsaEventSubscriber : MonoBehaviour
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Salsa salsa;

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xD61BB4", Offset = "0xD61BB4", VA = "0xD61BB4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xD61C74", Offset = "0xD61C74", VA = "0xD61C74")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xD61D34", Offset = "0xD61D34", VA = "0xD61D34")]
	private void OnStoppedSalsaing(object sender, Salsa.SalsaNotificationArgs e)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xD61E24", Offset = "0xD61E24", VA = "0xD61E24")]
	private void OnStartedSalsaing(object sender, Salsa.SalsaNotificationArgs e)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xD61F14", Offset = "0xD61F14", VA = "0xD61F14")]
	public SALSA_Template_SalsaEventSubscriber()
	{
	}
}
[Token(Token = "0x2000013")]
public class SALSA_Template_SalsaVisemeTriggerEventSubscriber : MonoBehaviour
{
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Salsa salsaInstance;

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xD61F1C", Offset = "0xD61F1C", VA = "0xD61F1C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xD61F9C", Offset = "0xD61F9C", VA = "0xD61F9C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xD6201C", Offset = "0xD6201C", VA = "0xD6201C")]
	private void SalsaOnVisemeTriggered(object sender, Salsa.SalsaNotificationArgs e)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xD62108", Offset = "0xD62108", VA = "0xD62108")]
	public SALSA_Template_SalsaVisemeTriggerEventSubscriber()
	{
	}
}
[Token(Token = "0x2000014")]
public class ObjectRotator : BaseMonoBehaviour
{
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float _speedMultiplier;

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xD62110", Offset = "0xD62110", VA = "0xD62110")]
	private void Update()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xD621B0", Offset = "0xD621B0", VA = "0xD621B0")]
	public ObjectRotator()
	{
	}
}
[Token(Token = "0x2000015")]
public class Clock : MonoBehaviour
{
	[Token(Token = "0x2000016")]
	public enum TimeRegion
	{
		[Token(Token = "0x4000053")]
		LocalTime,
		[Token(Token = "0x4000054")]
		LondonTime,
		[Token(Token = "0x4000055")]
		ParisTime,
		[Token(Token = "0x4000056")]
		NewYorkTime
	}

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Debug")]
	public int minutes;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int hour;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int second;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Header("Clock time zone")]
	public TimeRegion timeRegion;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("Clock components")]
	public GameObject pointerSeconds;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject pointerMinutes;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject pointerHours;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("Tweaks")]
	[Tooltip("1.0f = realtime, < 1.0f = slower, > 1.0f = faster")]
	public float clockSpeed;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int seconds;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float msecs;

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xD621C0", Offset = "0xD621C0", VA = "0xD621C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xD623CC", Offset = "0xD623CC", VA = "0xD623CC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xD62514", Offset = "0xD62514", VA = "0xD62514")]
	public Clock()
	{
	}
}
[Token(Token = "0x2000017")]
[RequireComponent(typeof(Light))]
public class SoftFlicker : MonoBehaviour
{
	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float minIntensity;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxIntensity;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_Random;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Light m_Light;

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xD62524", Offset = "0xD62524", VA = "0xD62524")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xD6257C", Offset = "0xD6257C", VA = "0xD6257C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xD625E4", Offset = "0xD625E4", VA = "0xD625E4")]
	private void Update()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xD62650", Offset = "0xD62650", VA = "0xD62650")]
	public SoftFlicker()
	{
	}
}
[Token(Token = "0x2000018")]
public class tazo_UVScroller : MonoBehaviour
{
	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int targetMaterialSlot;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer myrender;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speedY;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speedX;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float timeWentX;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float timeWentY;

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xD62664", Offset = "0xD62664", VA = "0xD62664")]
	private void Start()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xD626BC", Offset = "0xD626BC", VA = "0xD626BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xD62760", Offset = "0xD62760", VA = "0xD62760")]
	public tazo_UVScroller()
	{
	}
}
[Token(Token = "0x2000019")]
public class Key : MonoBehaviour, IStorylineActor
{
	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator _animator;

	[Token(Token = "0x17000006")]
	public string ActorName
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0xD627C8", Offset = "0xD627C8", VA = "0xD627C8", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000060")]
		[Address(RVA = "0xD627D0", Offset = "0xD627D0", VA = "0xD627D0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xD62770", Offset = "0xD62770", VA = "0xD62770")]
	private void Start()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xD627D8", Offset = "0xD627D8", VA = "0xD627D8")]
	public void Continue()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xD62818", Offset = "0xD62818", VA = "0xD62818")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xD62858", Offset = "0xD62858", VA = "0xD62858")]
	public void PlayAnimation(string animationName)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xD62874", Offset = "0xD62874", VA = "0xD62874")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xD628B4", Offset = "0xD628B4", VA = "0xD628B4")]
	public void StartActor()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xD628F4", Offset = "0xD628F4", VA = "0xD628F4")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xD62934", Offset = "0xD62934", VA = "0xD62934")]
	public Key()
	{
	}
}
[Token(Token = "0x200001A")]
public class Map : MonoBehaviour, IStorylineActor
{
	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator _animator;

	[Token(Token = "0x17000007")]
	public string ActorName
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0xD62994", Offset = "0xD62994", VA = "0xD62994", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600006A")]
		[Address(RVA = "0xD6299C", Offset = "0xD6299C", VA = "0xD6299C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xD6293C", Offset = "0xD6293C", VA = "0xD6293C")]
	private void Start()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xD629A4", Offset = "0xD629A4", VA = "0xD629A4")]
	public void Continue()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xD629E4", Offset = "0xD629E4", VA = "0xD629E4")]
	public void Pause()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xD62A24", Offset = "0xD62A24", VA = "0xD62A24")]
	public void PlayAnimation(string animationName)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xD62A40", Offset = "0xD62A40", VA = "0xD62A40")]
	public void Resume()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xD62A80", Offset = "0xD62A80", VA = "0xD62A80")]
	public void StartActor()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xD62AC0", Offset = "0xD62AC0", VA = "0xD62AC0")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xD62B00", Offset = "0xD62B00", VA = "0xD62B00")]
	public Map()
	{
	}
}
[Token(Token = "0x200001B")]
public class Ticket : MonoBehaviour, IStorylineActor
{
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator _animator;

	[Token(Token = "0x17000008")]
	public string ActorName
	{
		[Token(Token = "0x6000073")]
		[Address(RVA = "0xD62B60", Offset = "0xD62B60", VA = "0xD62B60", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000074")]
		[Address(RVA = "0xD62B68", Offset = "0xD62B68", VA = "0xD62B68", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xD62B08", Offset = "0xD62B08", VA = "0xD62B08")]
	private void Start()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xD62B70", Offset = "0xD62B70", VA = "0xD62B70")]
	public void Continue()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xD62BB0", Offset = "0xD62BB0", VA = "0xD62BB0")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xD62BF0", Offset = "0xD62BF0", VA = "0xD62BF0")]
	public void PlayAnimation(string animationName)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xD62C0C", Offset = "0xD62C0C", VA = "0xD62C0C")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xD62C4C", Offset = "0xD62C4C", VA = "0xD62C4C")]
	public void StartActor()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xD62C8C", Offset = "0xD62C8C", VA = "0xD62C8C")]
	public void Stop()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xD62CCC", Offset = "0xD62CCC", VA = "0xD62CCC")]
	public Ticket()
	{
	}
}
[Token(Token = "0x200001C")]
public static class ConsoleProDebug
{
	[Token(Token = "0x600007C")]
	[Address(RVA = "0xD62CD4", Offset = "0xD62CD4", VA = "0xD62CD4")]
	public static void Clear()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xD62CD8", Offset = "0xD62CD8", VA = "0xD62CD8")]
	public static void LogToFilter(string inLog, string inFilterName, [Optional] UnityEngine.Object inContext)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xD62D94", Offset = "0xD62D94", VA = "0xD62D94")]
	public static void LogAsType(string inLog, string inTypeName, [Optional] UnityEngine.Object inContext)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xD62E50", Offset = "0xD62E50", VA = "0xD62E50")]
	public static void Watch(string inName, string inValue)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xD630B0", Offset = "0xD630B0", VA = "0xD630B0")]
	public static void Search(string inText)
	{
	}
}
[Token(Token = "0x200001D")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x200001E")]
	public delegate void OnClick();

	[Token(Token = "0x200001F")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x2000020")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x2000021")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x4000064")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x4000065")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x4000066")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float elementSpacing;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float marginH;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float marginV;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2[] insertPositions;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 menuOffset;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private OVRCameraRig rig;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private LaserPointer lp;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private LineRenderer lr;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool isHorizontal;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool usePanelCentricRelayout;

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xD63154", Offset = "0xD63154", VA = "0xD63154")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xD636C0", Offset = "0xD636C0", VA = "0xD636C0")]
	public void Show()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xD63A3C", Offset = "0xD63A3C", VA = "0xD63A3C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xD63BB8", Offset = "0xD63BB8", VA = "0xD63BB8")]
	private void StackedRelayout()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xD63DD0", Offset = "0xD63DD0", VA = "0xD63DD0")]
	private void PanelCentricRelayout()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xD63A2C", Offset = "0xD63A2C", VA = "0xD63A2C")]
	private void Relayout()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xD640C4", Offset = "0xD640C4", VA = "0xD640C4")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xD64440", Offset = "0xD64440", VA = "0xD64440")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xD647F0", Offset = "0xD647F0", VA = "0xD647F0")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xD648E8", Offset = "0xD648E8", VA = "0xD648E8")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xD64AB8", Offset = "0xD64AB8", VA = "0xD64AB8")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xD64B50", Offset = "0xD64B50", VA = "0xD64B50")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xD64D2C", Offset = "0xD64D2C", VA = "0xD64D2C")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xD64F28", Offset = "0xD64F28", VA = "0xD64F28")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xD65220", Offset = "0xD65220", VA = "0xD65220")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xD65310", Offset = "0xD65310", VA = "0xD65310")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xD653A4", Offset = "0xD653A4", VA = "0xD653A4")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x2000027")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xD65A24", Offset = "0xD65A24", VA = "0xD65A24")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xD65AC8", Offset = "0xD65AC8", VA = "0xD65AC8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xD65B64", Offset = "0xD65B64", VA = "0xD65B64")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xD65B9C", Offset = "0xD65B9C", VA = "0xD65B9C")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x2000028")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x2000029")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x4000096")]
		On,
		[Token(Token = "0x4000097")]
		Off,
		[Token(Token = "0x4000098")]
		OnWhenHitTarget
	}

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x17000009")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xD65BA4", Offset = "0xD65BA4", VA = "0xD65BA4")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xD63680", Offset = "0xD63680", VA = "0xD63680")]
		set
		{
		}
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xD65BAC", Offset = "0xD65BAC", VA = "0xD65BAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xD65C04", Offset = "0xD65C04", VA = "0xD65C04")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xD65D3C", Offset = "0xD65D3C", VA = "0xD65D3C", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xD65D58", Offset = "0xD65D58", VA = "0xD65D58", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xD65DA8", Offset = "0xD65DA8", VA = "0xD65DA8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xD65F48", Offset = "0xD65F48", VA = "0xD65F48")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xD66058", Offset = "0xD66058", VA = "0xD66058")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xD660DC", Offset = "0xD660DC", VA = "0xD660DC")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xD6619C", Offset = "0xD6619C", VA = "0xD6619C")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xD66244", Offset = "0xD66244", VA = "0xD66244")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xD66330", Offset = "0xD66330", VA = "0xD66330")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x200002A")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x4000099")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x400009A")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x400009B")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("This should be a reference to the OVRCameraRig that is usually a child of the PlayerController.")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Collision layers to be used for the purposes of fading out the screen when the HMD is inside world geometry and adjusting the capsule height.")]
	public LayerMask CollideLayers;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Offset is added to camera's real world height, effectively treating it as though the player was taller/standing higher.")]
	public float HeightOffset;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Minimum height that the character capsule can shrink to.  To disable, set to capsule's height.")]
	public float MinimumHeight;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("Maximum height that the character capsule can grow to.  To disable, set to capsule's height.")]
	public float MaximumHeight;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xD66340", Offset = "0xD66340", VA = "0xD66340")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xD66348", Offset = "0xD66348", VA = "0xD66348")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xD663D8", Offset = "0xD663D8", VA = "0xD663D8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xD664FC", Offset = "0xD664FC", VA = "0xD664FC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xD66620", Offset = "0xD66620", VA = "0xD66620")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xD66940", Offset = "0xD66940", VA = "0xD66940")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xD66BA0", Offset = "0xD66BA0", VA = "0xD66BA0")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x200002B")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xD672F8", Offset = "0xD672F8", VA = "0xD672F8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xD673A4", Offset = "0xD673A4", VA = "0xD673A4")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x200002C")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	public enum States
	{
		[Token(Token = "0x40000C9")]
		Ready,
		[Token(Token = "0x40000CA")]
		Aim,
		[Token(Token = "0x40000CB")]
		CancelAim,
		[Token(Token = "0x40000CC")]
		PreTeleport,
		[Token(Token = "0x40000CD")]
		CancelTeleport,
		[Token(Token = "0x40000CE")]
		Teleporting,
		[Token(Token = "0x40000CF")]
		PostTeleport
	}

	[Token(Token = "0x200002E")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x40000D1")]
		None,
		[Token(Token = "0x40000D2")]
		Aim,
		[Token(Token = "0x40000D3")]
		PreTeleport,
		[Token(Token = "0x40000D4")]
		Teleport
	}

	[Token(Token = "0x200002F")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x40000D6")]
		Point,
		[Token(Token = "0x40000D7")]
		Sphere,
		[Token(Token = "0x40000D8")]
		Capsule
	}

	[Token(Token = "0x2000030")]
	public class AimData
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x1700000D")]
		public List<Vector3> Points
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xD690E4", Offset = "0xD690E4", VA = "0xD690E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0xD690EC", Offset = "0xD690EC", VA = "0xD690EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xD6905C", Offset = "0xD6905C", VA = "0xD6905C")]
		public AimData()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xD690F4", Offset = "0xD690F4", VA = "0xD690F4")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700000E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0xD6925C", Offset = "0xD6925C", VA = "0xD6925C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0xD692A4", Offset = "0xD692A4", VA = "0xD692A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xD67DB0", Offset = "0xD67DB0", VA = "0xD67DB0")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xD6914C", Offset = "0xD6914C", VA = "0xD6914C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xD69150", Offset = "0xD69150", VA = "0xD69150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xD69264", Offset = "0xD69264", VA = "0xD69264", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000010")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0xD69408", Offset = "0xD69408", VA = "0xD69408", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0xD69450", Offset = "0xD69450", VA = "0xD69450", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xD68238", Offset = "0xD68238", VA = "0xD68238")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xD692AC", Offset = "0xD692AC", VA = "0xD692AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xD692B0", Offset = "0xD692B0", VA = "0xD692B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xD69410", Offset = "0xD69410", VA = "0xD69410", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000012")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xD69508", Offset = "0xD69508", VA = "0xD69508", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0xD69550", Offset = "0xD69550", VA = "0xD69550", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xD6840C", Offset = "0xD6840C", VA = "0xD6840C")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xD69458", Offset = "0xD69458", VA = "0xD69458", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xD6945C", Offset = "0xD6945C", VA = "0xD6945C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xD69510", Offset = "0xD69510", VA = "0xD69510", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000014")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0xD69640", Offset = "0xD69640", VA = "0xD69640", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0xD69688", Offset = "0xD69688", VA = "0xD69688", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xD685E0", Offset = "0xD685E0", VA = "0xD685E0")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xD69558", Offset = "0xD69558", VA = "0xD69558", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xD6955C", Offset = "0xD6955C", VA = "0xD6955C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xD69648", Offset = "0xD69648", VA = "0xD69648", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0xD69740", Offset = "0xD69740", VA = "0xD69740", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0xD69788", Offset = "0xD69788", VA = "0xD69788", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xD687B4", Offset = "0xD687B4", VA = "0xD687B4")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xD69690", Offset = "0xD69690", VA = "0xD69690", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xD69694", Offset = "0xD69694", VA = "0xD69694", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xD69748", Offset = "0xD69748", VA = "0xD69748", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xD69874", Offset = "0xD69874", VA = "0xD69874", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0xD698BC", Offset = "0xD698BC", VA = "0xD698BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xD68988", Offset = "0xD68988", VA = "0xD68988")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xD69790", Offset = "0xD69790", VA = "0xD69790", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xD69794", Offset = "0xD69794", VA = "0xD69794", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xD6987C", Offset = "0xD6987C", VA = "0xD6987C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0xD699C4", Offset = "0xD699C4", VA = "0xD699C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0xD69A0C", Offset = "0xD69A0C", VA = "0xD69A0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xD68B5C", Offset = "0xD68B5C", VA = "0xD68B5C")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xD698C4", Offset = "0xD698C4", VA = "0xD698C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xD698C8", Offset = "0xD698C8", VA = "0xD698C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xD699CC", Offset = "0xD699CC", VA = "0xD699CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Allow linear movement prior to the teleport system being activated.")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Tooltip("Allow linear movement while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Tooltip("Allow linear movement while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[Tooltip("Allow linear movement after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("Allow rotation prior to the teleport system being activated.")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[Tooltip("Allow rotation while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[Tooltip("Allow rotation while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[Tooltip("Allow rotation after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableRotationDuringPostTeleport;

	[NonSerialized]
	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("This prefab will be instantiated as needed and updated to match the current aim target.")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("TeleportDestinationPrefab will be instantiated into this layer.")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("When aiming at possible destinations, the aim collision type determines which shape to use for collision tests.")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Tooltip("Use the character collision radius/height/skinwidth for sphere/capsule collision tests.")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("Radius of the sphere or capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionRadius;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Tooltip("Height of the capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionHeight;

	[Token(Token = "0x1700000A")]
	public States CurrentState
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xD673F4", Offset = "0xD673F4", VA = "0xD673F4")]
		[CompilerGenerated]
		get
		{
			return default(States);
		}
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xD673FC", Offset = "0xD673FC", VA = "0xD673FC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xD675CC", Offset = "0xD675CC", VA = "0xD675CC")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x1700000C")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xD675F0", Offset = "0xD675F0", VA = "0xD675F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xD675F8", Offset = "0xD675F8", VA = "0xD675F8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xD67404", Offset = "0xD67404", VA = "0xD67404")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xD674B4", Offset = "0xD674B4", VA = "0xD674B4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xD67C78", Offset = "0xD67C78", VA = "0xD67C78")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xD67D14", Offset = "0xD67D14", VA = "0xD67D14")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xD67DD8", Offset = "0xD67DD8", VA = "0xD67DD8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xD67E74", Offset = "0xD67E74", VA = "0xD67E74")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xD67F10", Offset = "0xD67F10", VA = "0xD67F10")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xD67FC0", Offset = "0xD67FC0", VA = "0xD67FC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xD6808C", Offset = "0xD6808C", VA = "0xD6808C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xD68128", Offset = "0xD68128", VA = "0xD68128")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xD68260", Offset = "0xD68260", VA = "0xD68260")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xD682FC", Offset = "0xD682FC", VA = "0xD682FC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xD68434", Offset = "0xD68434", VA = "0xD68434")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xD684D0", Offset = "0xD684D0", VA = "0xD684D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xD68608", Offset = "0xD68608", VA = "0xD68608")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xD686A4", Offset = "0xD686A4", VA = "0xD686A4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xD687DC", Offset = "0xD687DC", VA = "0xD687DC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xD68878", Offset = "0xD68878", VA = "0xD68878")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xD689B0", Offset = "0xD689B0", VA = "0xD689B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xD68A4C", Offset = "0xD68A4C", VA = "0xD68A4C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xD68B84", Offset = "0xD68B84", VA = "0xD68B84")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xD68C34", Offset = "0xD68C34", VA = "0xD68C34")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xD673AC", Offset = "0xD673AC", VA = "0xD673AC")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xD673D0", Offset = "0xD673D0", VA = "0xD673D0")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xD67564", Offset = "0xD67564", VA = "0xD67564")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xD67600", Offset = "0xD67600", VA = "0xD67600")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xD678C8", Offset = "0xD678C8", VA = "0xD678C8")]
	[Conditional("DEBUG_TELEPORT_STATES")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xD67970", Offset = "0xD67970", VA = "0xD67970")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xD67A5C", Offset = "0xD67A5C", VA = "0xD67A5C")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xD67A98", Offset = "0xD67A98", VA = "0xD67A98")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xD67B48", Offset = "0xD67B48", VA = "0xD67B48")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xD67B78", Offset = "0xD67B78", VA = "0xD67B78")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xD67BD8", Offset = "0xD67BD8", VA = "0xD67BD8", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xD67C70", Offset = "0xD67C70", VA = "0xD67C70", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xD67BFC", Offset = "0xD67BFC", VA = "0xD67BFC")]
	[IteratorStateMachine(typeof(<ReadyStateCoroutine>d__52))]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xD68070", Offset = "0xD68070", VA = "0xD68070")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xD681C4", Offset = "0xD681C4", VA = "0xD681C4")]
	[IteratorStateMachine(typeof(<AimStateCoroutine>d__64))]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xD68398", Offset = "0xD68398", VA = "0xD68398")]
	[IteratorStateMachine(typeof(<CancelAimStateCoroutine>d__68))]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xD6856C", Offset = "0xD6856C", VA = "0xD6856C")]
	[IteratorStateMachine(typeof(<PreTeleportStateCoroutine>d__72))]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xD68740", Offset = "0xD68740", VA = "0xD68740")]
	[IteratorStateMachine(typeof(<CancelTeleportStateCoroutine>d__76))]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xD68914", Offset = "0xD68914", VA = "0xD68914")]
	[IteratorStateMachine(typeof(<TeleportingStateCoroutine>d__80))]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xD68AE8", Offset = "0xD68AE8", VA = "0xD68AE8")]
	[IteratorStateMachine(typeof(<PostTeleportStateCoroutine>d__84))]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xD68CE4", Offset = "0xD68CE4", VA = "0xD68CE4")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xD68DF8", Offset = "0xD68DF8", VA = "0xD68DF8")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xD68E28", Offset = "0xD68E28", VA = "0xD68E28")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xD68F64", Offset = "0xD68F64", VA = "0xD68F64")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xD6904C", Offset = "0xD6904C", VA = "0xD6904C")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x2000038")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000C")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0xD66460", Offset = "0xD66460", VA = "0xD66460")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000129")]
		[Address(RVA = "0xD66584", Offset = "0xD66584", VA = "0xD66584")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x600012A")]
		[Address(RVA = "0xD69A14", Offset = "0xD69A14", VA = "0xD69A14")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600012B")]
		[Address(RVA = "0xD69AB0", Offset = "0xD69AB0", VA = "0xD69AB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xD69B4C", Offset = "0xD69B4C", VA = "0xD69B4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xD69C2C", Offset = "0xD69C2C", VA = "0xD69C2C")]
	private void Start()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xD69C30", Offset = "0xD69C30", VA = "0xD69C30")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xD69CA4", Offset = "0xD69CA4", VA = "0xD69CA4")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xD69DC8", Offset = "0xD69DC8", VA = "0xD69DC8")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xD6A040", Offset = "0xD6A040", VA = "0xD6A040")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xD6A260", Offset = "0xD6A260", VA = "0xD6A260")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x2000039")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x6000133")]
	[Address(RVA = "0xD6A280", Offset = "0xD6A280", VA = "0xD6A280", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xD6A310", Offset = "0xD6A310", VA = "0xD6A310", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000135")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xD6A3E0", Offset = "0xD6A3E0", VA = "0xD6A3E0")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x200003A")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xD6A3F0", Offset = "0xD6A3F0", VA = "0xD6A3F0", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xD6A580", Offset = "0xD6A580", VA = "0xD6A580")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x200003B")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The MinimumElevation is relative to the AimPosition.")]
	public float MinimumElevation;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The Gravity is used in conjunction with AimVelocity and the aim direction to simulate a projectile.")]
	public float Gravity;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(0.001f, 50f)]
	[Tooltip("The AimVelocity is the initial speed of the faked projectile.")]
	public float AimVelocity;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0.001f, 1f)]
	[Tooltip("The AimStep is the how much to subdivide the iteration.")]
	public float AimStep;

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xD6A590", Offset = "0xD6A590", VA = "0xD6A590", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xD6A764", Offset = "0xD6A764", VA = "0xD6A764")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x200003C")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This prefab will be instantiated when the aim visual is awakened, and will be set active when the user is aiming, and deactivated when they are done aiming.")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xD6A778", Offset = "0xD6A778", VA = "0xD6A778")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xD6A8A4", Offset = "0xD6A8A4", VA = "0xD6A8A4")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xD6A8D0", Offset = "0xD6A8D0", VA = "0xD6A8D0")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xD6A8FC", Offset = "0xD6A8FC", VA = "0xD6A8FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xD6A9A0", Offset = "0xD6A9A0", VA = "0xD6A9A0", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xD6A9F4", Offset = "0xD6A9F4", VA = "0xD6A9F4", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xD6AA44", Offset = "0xD6AA44", VA = "0xD6AA44")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x200003D")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("If the target handler provides a target position, this transform will be moved to that position and it's game object enabled. A target position being provided does not mean the position is valid, only that the aim handler found something to test as a destination.")]
	public Transform PositionIndicator;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This transform will be rotated to match the rotation of the aiming target. Simple teleport destinations should assign this to the object containing this component. More complex teleport destinations might assign this to a sub-object that is used to indicate the landing orientation independently from the rest of the destination indicator, such as when world space effects are required. This will typically be a child of the PositionIndicator.")]
	public Transform OrientationIndicator;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("After the player teleports, the character controller will have it's rotation set to this value. It is different from the OrientationIndicator transform.rotation in order to support both head-relative and forward-facing teleport modes (See TeleportOrientationHandlerThumbstick.cs).")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x1700001C")]
	public bool IsValidDestination
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0xD6AB40", Offset = "0xD6AB40", VA = "0xD6AB40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000143")]
		[Address(RVA = "0xD6AB48", Offset = "0xD6AB48", VA = "0xD6AB48")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0xD6ACD0", Offset = "0xD6ACD0", VA = "0xD6ACD0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000149")]
		[Address(RVA = "0xD6AD80", Offset = "0xD6AD80", VA = "0xD6AD80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xD6AB54", Offset = "0xD6AB54", VA = "0xD6AB54")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xD6ABD8", Offset = "0xD6ABD8", VA = "0xD6ABD8")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xD6AC9C", Offset = "0xD6AC9C", VA = "0xD6AC9C")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xD6ACCC", Offset = "0xD6ACCC", VA = "0xD6ACCC")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xD67A74", Offset = "0xD67A74", VA = "0xD67A74")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xD6AE30", Offset = "0xD6AE30", VA = "0xD6AE30")]
	public void Recycle()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xD6AE4C", Offset = "0xD6AE4C", VA = "0xD6AE4C", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x200003E")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700001D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xD6B414", Offset = "0xD6B414", VA = "0xD6B414", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xD6B45C", Offset = "0xD6B45C", VA = "0xD6B45C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xD6B280", Offset = "0xD6B280", VA = "0xD6B280")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xD6B384", Offset = "0xD6B384", VA = "0xD6B384", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xD6B388", Offset = "0xD6B388", VA = "0xD6B388", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xD6B41C", Offset = "0xD6B41C", VA = "0xD6B41C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0xD6B500", Offset = "0xD6B500", VA = "0xD6B500", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0xD6B548", Offset = "0xD6B548", VA = "0xD6B548", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xD6B31C", Offset = "0xD6B31C", VA = "0xD6B31C")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xD6B464", Offset = "0xD6B464", VA = "0xD6B464", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xD6B468", Offset = "0xD6B468", VA = "0xD6B468", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xD6B508", Offset = "0xD6B508", VA = "0xD6B508", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xD6B040", Offset = "0xD6B040", VA = "0xD6B040")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xD6B114", Offset = "0xD6B114", VA = "0xD6B114", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xD6B160", Offset = "0xD6B160", VA = "0xD6B160", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xD6B20C", Offset = "0xD6B20C", VA = "0xD6B20C")]
	[IteratorStateMachine(typeof(<TeleportReadyCoroutine>d__5))]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xD6B2A8", Offset = "0xD6B2A8", VA = "0xD6B2A8")]
	[IteratorStateMachine(typeof(<TeleportAimCoroutine>d__6))]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x6000153")]
	public abstract void GetAimData(out Ray aimRay);
}
[Token(Token = "0x2000041")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("The button used to begin aiming for a teleport.")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("The button used to trigger the teleport after aiming. It can be the same button as the AimButton, however you cannot abort a teleport if it is.")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("When true, the system will not use the PreTeleport intention which will allow a teleport to occur on a button downpress. When false, the button downpress will trigger the PreTeleport intention and the Teleport intention when the button is released.")]
	public bool FastTeleport;

	[Token(Token = "0x17000021")]
	public Transform Pointer
	{
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xD6B550", Offset = "0xD6B550", VA = "0xD6B550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000163")]
		[Address(RVA = "0xD6B558", Offset = "0xD6B558", VA = "0xD6B558")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xD6B560", Offset = "0xD6B560", VA = "0xD6B560", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xD6B68C", Offset = "0xD6B68C", VA = "0xD6B68C", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xD6B740", Offset = "0xD6B740", VA = "0xD6B740")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x2000042")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x2000043")]
	public enum InputModes
	{
		[Token(Token = "0x4000129")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x400012A")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x400012B")]
		ThumbstickTeleport,
		[Token(Token = "0x400012C")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x2000044")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x400012E")]
		A,
		[Token(Token = "0x400012F")]
		B,
		[Token(Token = "0x4000130")]
		LeftTrigger,
		[Token(Token = "0x4000131")]
		LeftThumbstick,
		[Token(Token = "0x4000132")]
		RightTrigger,
		[Token(Token = "0x4000133")]
		RightThumbstick,
		[Token(Token = "0x4000134")]
		X,
		[Token(Token = "0x4000135")]
		Y
	}

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("CapacitiveButtonForAimAndTeleport=Activate aiming via cap touch detection, press the same button to teleport.\nSeparateButtonsForAimAndTeleport=Use one button to begin aiming, and another to trigger the teleport.\nThumbstickTeleport=Push a thumbstick to begin aiming, release to teleport.")]
	public InputModes InputMode;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("Select the controller to be used for aiming. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("Select the button to use for triggering aim and teleport when InputMode==CapacitiveButtonForAimAndTeleport")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Tooltip("The thumbstick magnitude required to trigger aiming and teleports when InputMode==InputModes.ThumbstickTeleport")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xD6B744", Offset = "0xD6B744", VA = "0xD6B744")]
	private void Start()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xD6B748", Offset = "0xD6B748", VA = "0xD6B748", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xD6BB7C", Offset = "0xD6BB7C", VA = "0xD6BB7C", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xD6BC38", Offset = "0xD6BC38", VA = "0xD6BC38")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x2000045")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x2000046")]
	public enum OrientationModes
	{
		[Token(Token = "0x400013A")]
		HeadRelative,
		[Token(Token = "0x400013B")]
		ForwardFacing
	}

	[Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xD6C0E8", Offset = "0xD6C0E8", VA = "0xD6C0E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0xD6C130", Offset = "0xD6C130", VA = "0xD6C130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xD6BEF8", Offset = "0xD6BEF8", VA = "0xD6BEF8")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xD6C038", Offset = "0xD6C038", VA = "0xD6C038", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xD6C03C", Offset = "0xD6C03C", VA = "0xD6C03C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xD6C0F0", Offset = "0xD6C0F0", VA = "0xD6C0F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xD6BD28", Offset = "0xD6BD28", VA = "0xD6BD28")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xD6BE10", Offset = "0xD6BE10", VA = "0xD6BE10")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xD6BE18", Offset = "0xD6BE18", VA = "0xD6BE18", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xD6BE50", Offset = "0xD6BE50", VA = "0xD6BE50", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xD6BE84", Offset = "0xD6BE84", VA = "0xD6BE84")]
	[IteratorStateMachine(typeof(<UpdateOrientationCoroutine>d__7))]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x6000171")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xD6BF20", Offset = "0xD6BF20", VA = "0xD6BF20")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}
}
[Token(Token = "0x2000048")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x600017A")]
	[Address(RVA = "0xD6C138", Offset = "0xD6C138", VA = "0xD6C138", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xD6C13C", Offset = "0xD6C13C", VA = "0xD6C13C", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xD6C1E4", Offset = "0xD6C1E4", VA = "0xD6C1E4")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x2000049")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Should the destination orientation be updated during the aim state in addition to the PreTeleport state?")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("How far from the destination must the HMD be pointing before using it for orientation")]
	public float AimDistanceThreshold;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Tooltip("How far from the destination must the HMD be pointing before rejecting the teleport")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xD6C1E8", Offset = "0xD6C1E8", VA = "0xD6C1E8", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xD6C238", Offset = "0xD6C238", VA = "0xD6C238", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xD6C6FC", Offset = "0xD6C6FC", VA = "0xD6C6FC")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x200004A")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Which thumbstick is to be used for adjusting the teleport orientation. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("The orientation will only change if the thumbstick magnitude is above this value. This will usually be larger than the TeleportInputHandlerTouch.ThumbstickTeleportThreshold.")]
	public float RotateStickThreshold;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xD6C700", Offset = "0xD6C700", VA = "0xD6C700", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xD6C734", Offset = "0xD6C734", VA = "0xD6C734", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xD6CC30", Offset = "0xD6CC30", VA = "0xD6CC30")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x200004B")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xD6CC40", Offset = "0xD6CC40", VA = "0xD6CC40")]
	private void Start()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xD6CC44", Offset = "0xD6CC44", VA = "0xD6CC44")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xD6CC4C", Offset = "0xD6CC4C", VA = "0xD6CC4C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xD6CD38", Offset = "0xD6CD38", VA = "0xD6CD38")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xD6CD54", Offset = "0xD6CD54", VA = "0xD6CD54")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x200004C")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000024")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x6000188")]
		[Address(RVA = "0xD6CD6C", Offset = "0xD6CD6C", VA = "0xD6CD6C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000189")]
		[Address(RVA = "0xD6CD74", Offset = "0xD6CD74", VA = "0xD6CD74")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xD6A2A8", Offset = "0xD6A2A8", VA = "0xD6A2A8", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xD6A3B8", Offset = "0xD6A3B8", VA = "0xD6A3B8", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xD6CD7C", Offset = "0xD6CD7C", VA = "0xD6CD7C")]
	[Conditional("DEBUG_TELEPORT_EVENT_HANDLERS")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xD6A9E8", Offset = "0xD6A9E8", VA = "0xD6A9E8", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xD6AA3C", Offset = "0xD6AA3C", VA = "0xD6AA3C", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xD6A3E8", Offset = "0xD6A3E8", VA = "0xD6A3E8")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x200004D")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xD6D46C", Offset = "0xD6D46C", VA = "0xD6D46C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0xD6D4B4", Offset = "0xD6D4B4", VA = "0xD6D4B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xD6D024", Offset = "0xD6D024", VA = "0xD6D024")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xD6D1A0", Offset = "0xD6D1A0", VA = "0xD6D1A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xD6D1A4", Offset = "0xD6D1A4", VA = "0xD6D1A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xD6D474", Offset = "0xD6D474", VA = "0xD6D474", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("This bitmask controls which game object layers will be included in the targeting collision tests.")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x4000155")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xD6CE4C", Offset = "0xD6CE4C", VA = "0xD6CE4C")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xD6CF64", Offset = "0xD6CF64", VA = "0xD6CF64", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xD6CF8C", Offset = "0xD6CF8C", VA = "0xD6CF8C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xD6CFB0", Offset = "0xD6CFB0", VA = "0xD6CFB0")]
	[IteratorStateMachine(typeof(<TargetAimCoroutine>d__7))]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xD6D04C", Offset = "0xD6D04C", VA = "0xD6D04C", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x6000195")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xD6D064", Offset = "0xD6D064", VA = "0xD6D064", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}
}
[Token(Token = "0x200004F")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xD6D4BC", Offset = "0xD6D4BC", VA = "0xD6D4BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xD6D524", Offset = "0xD6D524", VA = "0xD6D524", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xD6D68C", Offset = "0xD6D68C", VA = "0xD6D68C", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xD6D778", Offset = "0xD6D778", VA = "0xD6D778")]
	[Conditional("SHOW_PATH_RESULT")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xD6D77C", Offset = "0xD6D77C", VA = "0xD6D77C")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x2000050")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("When checking line of sight to the destination, add this value to the vertical offset for targeting collision checks.")]
	public float LOSOffset;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Teleport logic will only work with TeleportPoint components that exist in the layers specified by this mask.")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xD6D788", Offset = "0xD6D788", VA = "0xD6D788", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xD6D980", Offset = "0xD6D980", VA = "0xD6D980")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x2000051")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xD6D98C", Offset = "0xD6D98C", VA = "0xD6D98C", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xD6DAF4", Offset = "0xD6DAF4", VA = "0xD6DAF4")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x2000052")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xD6DAF8", Offset = "0xD6DAF8", VA = "0xD6DAF8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xD6DB7C", Offset = "0xD6DB7C", VA = "0xD6DB7C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60001A9")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xD6DBFC", Offset = "0xD6DBFC", VA = "0xD6DBFC")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x2000053")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xD6DF60", Offset = "0xD6DF60", VA = "0xD6DF60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xD6DFA8", Offset = "0xD6DFA8", VA = "0xD6DFA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xD6DC98", Offset = "0xD6DC98", VA = "0xD6DC98")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xD6DE5C", Offset = "0xD6DE5C", VA = "0xD6DE5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xD6DE60", Offset = "0xD6DE60", VA = "0xD6DE60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xD6DF68", Offset = "0xD6DF68", VA = "0xD6DF68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 2f)]
	[Tooltip("How long the transition takes. Usually this is greater than Teleport Delay.")]
	public float TransitionDuration;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	[Tooltip("At what percentage of the elapsed transition time does the teleport occur?")]
	public float TeleportDelay;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Fade to black over the duration of the transition")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xD6DC04", Offset = "0xD6DC04", VA = "0xD6DC04", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xD6DC24", Offset = "0xD6DC24", VA = "0xD6DC24")]
	[IteratorStateMachine(typeof(<BlinkCoroutine>d__4))]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xD6DCC0", Offset = "0xD6DCC0", VA = "0xD6DCC0")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x2000055")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xD6DFB0", Offset = "0xD6DFB0", VA = "0xD6DFB0", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xD6DFC8", Offset = "0xD6DFC8", VA = "0xD6DFC8")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x2000056")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xD6E1EC", Offset = "0xD6E1EC", VA = "0xD6E1EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xD6E234", Offset = "0xD6E234", VA = "0xD6E234", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xD6E064", Offset = "0xD6E064", VA = "0xD6E064")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xD6E0D4", Offset = "0xD6E0D4", VA = "0xD6E0D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xD6E0D8", Offset = "0xD6E0D8", VA = "0xD6E0D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xD6E1F4", Offset = "0xD6E1F4", VA = "0xD6E1F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("How much time the warp transition takes to complete.")]
	[Range(0.01f, 1f)]
	public float TransitionDuration;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xD6DFD0", Offset = "0xD6DFD0", VA = "0xD6DFD0", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xD6DFF0", Offset = "0xD6DFF0", VA = "0xD6DFF0")]
	[IteratorStateMachine(typeof(<DoWarp>d__3))]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xD6E08C", Offset = "0xD6E08C", VA = "0xD6E08C")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x2000058")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x2000059")]
	public enum PlabackState
	{
		[Token(Token = "0x4000185")]
		Idle = 1,
		[Token(Token = "0x4000186")]
		Preparing,
		[Token(Token = "0x4000187")]
		Buffering,
		[Token(Token = "0x4000188")]
		Ready,
		[Token(Token = "0x4000189")]
		Ended
	}

	[Token(Token = "0x200005A")]
	public enum StereoMode
	{
		[Token(Token = "0x400018B")]
		Unknown = -1,
		[Token(Token = "0x400018C")]
		Mono,
		[Token(Token = "0x400018D")]
		TopBottom,
		[Token(Token = "0x400018E")]
		LeftRight,
		[Token(Token = "0x400018F")]
		Mesh
	}

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x1700002B")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xD6E23C", Offset = "0xD6E23C", VA = "0xD6E23C")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700002C")]
	private static IntPtr Activity
	{
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xD6E52C", Offset = "0xD6E52C", VA = "0xD6E52C")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700002D")]
	public static bool IsAvailable
	{
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xD6E7AC", Offset = "0xD6E7AC", VA = "0xD6E7AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002E")]
	public static bool IsPlaying
	{
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xD6E820", Offset = "0xD6E820", VA = "0xD6E820")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002F")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xD6E924", Offset = "0xD6E924", VA = "0xD6E924")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x17000030")]
	public static long Duration
	{
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xD6EA2C", Offset = "0xD6EA2C", VA = "0xD6EA2C")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000031")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xD6EB34", Offset = "0xD6EB34", VA = "0xD6EB34")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x17000032")]
	public static int VideoWidth
	{
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xD6EC3C", Offset = "0xD6EC3C", VA = "0xD6EC3C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000033")]
	public static int VideoHeight
	{
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xD6ED44", Offset = "0xD6ED44", VA = "0xD6ED44")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000034")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xD6EE4C", Offset = "0xD6EE4C", VA = "0xD6EE4C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xD6EF54", Offset = "0xD6EF54", VA = "0xD6EF54")]
		set
		{
		}
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xD6F0BC", Offset = "0xD6F0BC", VA = "0xD6F0BC")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xD6F2D4", Offset = "0xD6F2D4", VA = "0xD6F2D4")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xD6F3DC", Offset = "0xD6F3DC", VA = "0xD6F3DC")]
	public static void Play()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xD6F4E4", Offset = "0xD6F4E4", VA = "0xD6F4E4")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xD6F5EC", Offset = "0xD6F5EC", VA = "0xD6F5EC")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xD6F75C", Offset = "0xD6F75C", VA = "0xD6F75C")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xD6F8C8", Offset = "0xD6F8C8", VA = "0xD6F8C8")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x200005B")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400000F")]
	public event Action onButtonDown
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xD6FB1C", Offset = "0xD6FB1C", VA = "0xD6FB1C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xD6FBB8", Offset = "0xD6FBB8", VA = "0xD6FBB8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xD6FC54", Offset = "0xD6FC54", VA = "0xD6FC54", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xD6FC70", Offset = "0xD6FC70", VA = "0xD6FC70")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x200005C")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x200005D")]
	public enum ButtonType
	{
		[Token(Token = "0x4000193")]
		Play,
		[Token(Token = "0x4000194")]
		Pause,
		[Token(Token = "0x4000195")]
		FastForward,
		[Token(Token = "0x4000196")]
		Rewind,
		[Token(Token = "0x4000197")]
		SkipForward,
		[Token(Token = "0x4000198")]
		SkipBack,
		[Token(Token = "0x4000199")]
		Stop
	}

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x17000035")]
	public ButtonType buttonType
	{
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xD6FC78", Offset = "0xD6FC78", VA = "0xD6FC78")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xD6FC80", Offset = "0xD6FC80", VA = "0xD6FC80")]
		set
		{
		}
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xD6FCA4", Offset = "0xD6FCA4", VA = "0xD6FCA4", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xD70AF8", Offset = "0xD70AF8", VA = "0xD70AF8")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x200005E")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x200005F")]
	public enum VideoShape
	{
		[Token(Token = "0x40001AE")]
		_360,
		[Token(Token = "0x40001AF")]
		_180,
		[Token(Token = "0x40001B0")]
		Quad
	}

	[Token(Token = "0x2000060")]
	public enum VideoStereo
	{
		[Token(Token = "0x40001B2")]
		Mono,
		[Token(Token = "0x40001B3")]
		TopBottom,
		[Token(Token = "0x40001B4")]
		LeftRight,
		[Token(Token = "0x40001B5")]
		BottomTop
	}

	[Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x17000039")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xD72FB4", Offset = "0xD72FB4", VA = "0xD72FB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xD72FFC", Offset = "0xD72FFC", VA = "0xD72FFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xD72DD4", Offset = "0xD72DD4", VA = "0xD72DD4")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xD72DFC", Offset = "0xD72DFC", VA = "0xD72DFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xD72E00", Offset = "0xD72E00", VA = "0xD72E00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xD72FBC", Offset = "0xD72FBC", VA = "0xD72FBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x17000036")]
	public bool IsPlaying
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xD70B50", Offset = "0xD70B50", VA = "0xD70B50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xD70B58", Offset = "0xD70B58", VA = "0xD70B58")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public long Duration
	{
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xD70B64", Offset = "0xD70B64", VA = "0xD70B64")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xD70B6C", Offset = "0xD70B6C", VA = "0xD70B6C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public long PlaybackPosition
	{
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xD70B74", Offset = "0xD70B74", VA = "0xD70B74")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xD70B7C", Offset = "0xD70B7C", VA = "0xD70B7C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xD70B84", Offset = "0xD70B84", VA = "0xD70B84")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xD70E08", Offset = "0xD70E08", VA = "0xD70E08")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xD70E68", Offset = "0xD70E68", VA = "0xD70E68")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xD71168", Offset = "0xD71168", VA = "0xD71168")]
	[IteratorStateMachine(typeof(<Start>d__33))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xD711DC", Offset = "0xD711DC", VA = "0xD711DC")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xD714AC", Offset = "0xD714AC", VA = "0xD714AC")]
	public void Play()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xD71530", Offset = "0xD71530", VA = "0xD71530")]
	public void Pause()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xD715B0", Offset = "0xD715B0", VA = "0xD715B0")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xD7169C", Offset = "0xD7169C", VA = "0xD7169C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xD71BC8", Offset = "0xD71BC8", VA = "0xD71BC8")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xD71C64", Offset = "0xD71C64", VA = "0xD71C64")]
	public void Stop()
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xD71CE4", Offset = "0xD71CE4", VA = "0xD71CE4")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xD71DC4", Offset = "0xD71DC4", VA = "0xD71DC4")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x2000063")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x2000064")]
	private enum PlaybackState
	{
		[Token(Token = "0x40001D2")]
		Playing,
		[Token(Token = "0x40001D3")]
		Paused,
		[Token(Token = "0x40001D4")]
		Rewinding,
		[Token(Token = "0x40001D5")]
		FastForwarding
	}

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xD730E8", Offset = "0xD730E8", VA = "0xD730E8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xD733D8", Offset = "0xD733D8", VA = "0xD733D8")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xD73508", Offset = "0xD73508", VA = "0xD73508")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xD73618", Offset = "0xD73618", VA = "0xD73618")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xD736F8", Offset = "0xD736F8", VA = "0xD736F8")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xD735E8", Offset = "0xD735E8", VA = "0xD735E8")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xD73758", Offset = "0xD73758", VA = "0xD73758")]
	private void Update()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xD732D8", Offset = "0xD732D8", VA = "0xD732D8")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xD73A88", Offset = "0xD73A88", VA = "0xD73A88")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x2000065")]
public static class VectorUtil
{
	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xD73A98", Offset = "0xD73A98", VA = "0xD73A98")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x2000066")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x40001D6")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x40001D7")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xD73B10", Offset = "0xD73B10", VA = "0xD73B10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xD74164", Offset = "0xD74164", VA = "0xD74164")]
	private void Update()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xD743C0", Offset = "0xD743C0", VA = "0xD743C0")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xD74524", Offset = "0xD74524", VA = "0xD74524")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xD7468C", Offset = "0xD7468C", VA = "0xD7468C")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xD74810", Offset = "0xD74810", VA = "0xD74810")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x2000067")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x40001E0")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xD74820", Offset = "0xD74820", VA = "0xD74820")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xD74878", Offset = "0xD74878", VA = "0xD74878")]
	private void Start()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xD7487C", Offset = "0xD7487C", VA = "0xD7487C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xD73F0C", Offset = "0xD73F0C", VA = "0xD73F0C")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xD74880", Offset = "0xD74880", VA = "0xD74880")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xD74A9C", Offset = "0xD74A9C", VA = "0xD74A9C")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x2000068")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xD74AA4", Offset = "0xD74AA4", VA = "0xD74AA4")]
	private void Start()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xD75004", Offset = "0xD75004", VA = "0xD75004")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xD750B0", Offset = "0xD750B0", VA = "0xD750B0")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xD75340", Offset = "0xD75340", VA = "0xD75340")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xD75414", Offset = "0xD75414", VA = "0xD75414")]
	private void Update()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xD754EC", Offset = "0xD754EC", VA = "0xD754EC")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xD75554", Offset = "0xD75554", VA = "0xD75554")]
	public DebugUISample()
	{
	}
}
[Token(Token = "0x2000069")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x6000216")]
	[Address(RVA = "0xD756FC", Offset = "0xD756FC", VA = "0xD756FC")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x200006A")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xD75704", Offset = "0xD75704", VA = "0xD75704")]
	private void Start()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xD7579C", Offset = "0xD7579C", VA = "0xD7579C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xD75874", Offset = "0xD75874", VA = "0xD75874")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xD758D0", Offset = "0xD758D0", VA = "0xD758D0")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x200006B")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x600021B")]
	[Address(RVA = "0xD758D8", Offset = "0xD758D8", VA = "0xD758D8")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x200006C")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x1700003B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0xD75CE8", Offset = "0xD75CE8", VA = "0xD75CE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0xD75D30", Offset = "0xD75D30", VA = "0xD75D30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xD75B84", Offset = "0xD75B84", VA = "0xD75B84")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xD75BB4", Offset = "0xD75BB4", VA = "0xD75BB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xD75BB8", Offset = "0xD75BB8", VA = "0xD75BB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xD75CF0", Offset = "0xD75CF0", VA = "0xD75CF0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xD758E0", Offset = "0xD758E0", VA = "0xD758E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xD759EC", Offset = "0xD759EC", VA = "0xD759EC")]
	private void Update()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xD75978", Offset = "0xD75978", VA = "0xD75978")]
	[IteratorStateMachine(typeof(<GetCenterEye>d__6))]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xD75BAC", Offset = "0xD75BAC", VA = "0xD75BAC")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x200006E")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(4f, 32f)]
	public int SubdivisionsU;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(4f, 32f)]
	public int SubdivisionsV;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xD75D38", Offset = "0xD75D38", VA = "0xD75D38")]
	private void Update()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xD776E0", Offset = "0xD776E0", VA = "0xD776E0")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x200006F")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x1700003D")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x6000228")]
		[Address(RVA = "0xD776E8", Offset = "0xD776E8", VA = "0xD776E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xD77738", Offset = "0xD77738", VA = "0xD77738")]
	public void Start()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xD77B70", Offset = "0xD77B70", VA = "0xD77B70")]
	public void Update()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xD77C48", Offset = "0xD77C48", VA = "0xD77C48")]
	[Conditional("DEBUG_LOCOMOTION_PANEL")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x600022C")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600022D")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x600022E")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x600022F")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x6000230")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x6000231")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x6000232")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x6000233")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xD77CA0", Offset = "0xD77CA0", VA = "0xD77CA0")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xD77CE0", Offset = "0xD77CE0", VA = "0xD77CE0")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xD77D4C", Offset = "0xD77D4C", VA = "0xD77D4C")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xD77E98", Offset = "0xD77E98", VA = "0xD77E98")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xD77F68", Offset = "0xD77F68", VA = "0xD77F68")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xD77A4C", Offset = "0xD77A4C", VA = "0xD77A4C")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xD78038", Offset = "0xD78038", VA = "0xD78038")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xD78084", Offset = "0xD78084", VA = "0xD78084")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xD78194", Offset = "0xD78194", VA = "0xD78194")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x2000070")]
[RequireComponent(typeof(Canvas))]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x2000071")]
	public enum DrawMode
	{
		[Token(Token = "0x400020F")]
		Opaque,
		[Token(Token = "0x4000210")]
		OpaqueWithClip,
		[Token(Token = "0x4000211")]
		TransparentDefaultAlpha,
		[Token(Token = "0x4000212")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private Shader _transparentShader;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private Shader _opaqueShader;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x1700003E")]
	public bool overlayEnabled
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0xD797D8", Offset = "0xD797D8", VA = "0xD797D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000244")]
		[Address(RVA = "0xD7985C", Offset = "0xD7985C", VA = "0xD7985C")]
		set
		{
		}
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xD7819C", Offset = "0xD7819C", VA = "0xD7819C")]
	private void Start()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xD78E60", Offset = "0xD78E60", VA = "0xD78E60")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xD78ED4", Offset = "0xD78ED4", VA = "0xD78ED4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xD78FA4", Offset = "0xD78FA4", VA = "0xD78FA4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xD79074", Offset = "0xD79074", VA = "0xD79074", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xD79278", Offset = "0xD79278", VA = "0xD79278")]
	private void Update()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xD79918", Offset = "0xD79918", VA = "0xD79918")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x2000072")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xD799D4", Offset = "0xD799D4", VA = "0xD799D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xD79D74", Offset = "0xD79D74", VA = "0xD79D74")]
	private void Update()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xD79F08", Offset = "0xD79F08", VA = "0xD79F08")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xD79F10", Offset = "0xD79F10", VA = "0xD79F10")]
	public void Release()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0xD79EF8", Offset = "0xD79EF8", VA = "0xD79EF8")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xD79F18", Offset = "0xD79F18", VA = "0xD79F18")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x2000073")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0xD7A660", Offset = "0xD7A660", VA = "0xD7A660", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0xD7A6A8", Offset = "0xD7A6A8", VA = "0xD7A6A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xD7A504", Offset = "0xD7A504", VA = "0xD7A504")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xD7A55C", Offset = "0xD7A55C", VA = "0xD7A55C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xD7A560", Offset = "0xD7A560", VA = "0xD7A560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xD7A668", Offset = "0xD7A668", VA = "0xD7A668", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0xD7A82C", Offset = "0xD7A82C", VA = "0xD7A82C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xD7A874", Offset = "0xD7A874", VA = "0xD7A874", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xD7A52C", Offset = "0xD7A52C", VA = "0xD7A52C")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xD7A6B0", Offset = "0xD7A6B0", VA = "0xD7A6B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xD7A6B4", Offset = "0xD7A6B4", VA = "0xD7A6B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xD7A834", Offset = "0xD7A834", VA = "0xD7A834", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xD79F20", Offset = "0xD79F20", VA = "0xD79F20")]
	private void Start()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xD7A200", Offset = "0xD7A200", VA = "0xD7A200")]
	private void Update()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xD7A250", Offset = "0xD7A250", VA = "0xD7A250")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xD7A3C8", Offset = "0xD7A3C8", VA = "0xD7A3C8")]
	public void Release()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xD7A46C", Offset = "0xD7A46C", VA = "0xD7A46C")]
	[IteratorStateMachine(typeof(<FadeCameraClearColor>d__8))]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xD7A308", Offset = "0xD7A308", VA = "0xD7A308")]
	[IteratorStateMachine(typeof(<FadeSphere>d__9))]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xD7A554", Offset = "0xD7A554", VA = "0xD7A554")]
	public BrushController()
	{
	}
}
[Token(Token = "0x2000076")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x6000260")]
	[Address(RVA = "0xD7A87C", Offset = "0xD7A87C", VA = "0xD7A87C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xD7A8D0", Offset = "0xD7A8D0", VA = "0xD7A8D0")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x2000077")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xD7A8D8", Offset = "0xD7A8D8", VA = "0xD7A8D8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xD7AAAC", Offset = "0xD7AAAC", VA = "0xD7AAAC")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xD7AB3C", Offset = "0xD7AB3C", VA = "0xD7AB3C")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xD7AB98", Offset = "0xD7AB98", VA = "0xD7AB98")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x2000078")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xD7BD70", Offset = "0xD7BD70", VA = "0xD7BD70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0xD7BDB8", Offset = "0xD7BDB8", VA = "0xD7BDB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xD7BAD8", Offset = "0xD7BAD8", VA = "0xD7BAD8")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xD7BBA0", Offset = "0xD7BBA0", VA = "0xD7BBA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xD7BBA4", Offset = "0xD7BBA4", VA = "0xD7BBA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xD7BD78", Offset = "0xD7BD78", VA = "0xD7BD78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xD7ABA0", Offset = "0xD7ABA0", VA = "0xD7ABA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xD7AE88", Offset = "0xD7AE88", VA = "0xD7AE88")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xD7B174", Offset = "0xD7B174", VA = "0xD7B174")]
	private void FindHands()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xD7B49C", Offset = "0xD7B49C", VA = "0xD7B49C")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xD7B774", Offset = "0xD7B774", VA = "0xD7B774")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xD7B85C", Offset = "0xD7B85C", VA = "0xD7B85C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xD7B9F4", Offset = "0xD7B9F4", VA = "0xD7B9F4")]
	public void Release()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xD7B944", Offset = "0xD7B944", VA = "0xD7B944")]
	[IteratorStateMachine(typeof(<FadeLighting>d__17))]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xD7BB00", Offset = "0xD7BB00", VA = "0xD7BB00")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x200007A")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x200007B")]
	public enum ManipulationType
	{
		[Token(Token = "0x4000247")]
		Default,
		[Token(Token = "0x4000248")]
		ForcedHand,
		[Token(Token = "0x4000249")]
		DollyHand,
		[Token(Token = "0x400024A")]
		DollyAttached,
		[Token(Token = "0x400024B")]
		HorizontalScaled,
		[Token(Token = "0x400024C")]
		VerticalScaled,
		[Token(Token = "0x400024D")]
		Menu
	}

	[Token(Token = "0x200007C")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x200007D")]
	public delegate void ReleasedObject();

	[Token(Token = "0x200007E")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[TextArea]
	public string ObjectName;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[TextArea]
	public string ObjectInstructions;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion grabbedRotation;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x6000275")]
	[Address(RVA = "0xD7BDC0", Offset = "0xD7BDC0", VA = "0xD7BDC0")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0xD7BE20", Offset = "0xD7BE20", VA = "0xD7BE20")]
	public void Release()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xD7BE3C", Offset = "0xD7BE3C", VA = "0xD7BE3C")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xD7BE58", Offset = "0xD7BE58", VA = "0xD7BE58")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x200007F")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The segments around the tip of a finger")]
	public int radialDivisions;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The fade range (finger width is 2x this)")]
	public float borderSize;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Along the fingers, each knuckle scales down by this amount.  Default is zero for uniform width along entire finger.")]
	public float fingerTaper;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("Shorten the last bone of each finger; need this to account for bone structure (end bone is at finger tip instead of center). Default is 1.")]
	public float fingerTipLength;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Move the base of the 4 main fingers towards the tips, to avoid a visible mesh crack between finger webbing. Default is 0.")]
	public float webOffset;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xD7C110", Offset = "0xD7C110", VA = "0xD7C110")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xD7C370", Offset = "0xD7C370", VA = "0xD7C370")]
	private void Update()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xD7C538", Offset = "0xD7C538", VA = "0xD7C538")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xD7CB8C", Offset = "0xD7CB8C", VA = "0xD7CB8C")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xD7D124", Offset = "0xD7D124", VA = "0xD7D124")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xD7F42C", Offset = "0xD7F42C", VA = "0xD7F42C")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xD7F7A0", Offset = "0xD7F7A0", VA = "0xD7F7A0")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x2000080")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xD7F7C4", Offset = "0xD7F7C4", VA = "0xD7F7C4")]
	private void Start()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xD7FB2C", Offset = "0xD7FB2C", VA = "0xD7FB2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xD7F860", Offset = "0xD7F860", VA = "0xD7F860")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xD7FF94", Offset = "0xD7FF94", VA = "0xD7FF94")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xD80504", Offset = "0xD80504", VA = "0xD80504")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x2000081")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x17000045")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0xD82DAC", Offset = "0xD82DAC", VA = "0xD82DAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0xD82DF4", Offset = "0xD82DF4", VA = "0xD82DF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xD826EC", Offset = "0xD826EC", VA = "0xD826EC")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xD82AD4", Offset = "0xD82AD4", VA = "0xD82AD4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xD82AD8", Offset = "0xD82AD8", VA = "0xD82AD8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xD82DB4", Offset = "0xD82DB4", VA = "0xD82DB4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xD80514", Offset = "0xD80514", VA = "0xD80514")]
	private void Start()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xD80710", Offset = "0xD80710", VA = "0xD80710")]
	private void Update()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xD8164C", Offset = "0xD8164C", VA = "0xD8164C")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xD823E0", Offset = "0xD823E0", VA = "0xD823E0")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xD8069C", Offset = "0xD8069C", VA = "0xD8069C")]
	[IteratorStateMachine(typeof(<StartDemo>d__23))]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xD80960", Offset = "0xD80960", VA = "0xD80960")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xD81940", Offset = "0xD81940", VA = "0xD81940")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xD82714", Offset = "0xD82714", VA = "0xD82714")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xD827C8", Offset = "0xD827C8", VA = "0xD827C8")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xD827F8", Offset = "0xD827F8", VA = "0xD827F8")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xD825D0", Offset = "0xD825D0", VA = "0xD825D0")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xD828E8", Offset = "0xD828E8", VA = "0xD828E8")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x2000083")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xD82DFC", Offset = "0xD82DFC", VA = "0xD82DFC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xD82F68", Offset = "0xD82F68", VA = "0xD82F68")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xD8301C", Offset = "0xD8301C", VA = "0xD8301C")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x2000084")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x2000085")]
	public enum BrushState
	{
		[Token(Token = "0x400028A")]
		Idle,
		[Token(Token = "0x400028B")]
		Inking
	}

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xD83024", Offset = "0xD83024", VA = "0xD83024")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xD8302C", Offset = "0xD8302C", VA = "0xD8302C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xD832DC", Offset = "0xD832DC", VA = "0xD832DC")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xD83510", Offset = "0xD83510", VA = "0xD83510")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xD83750", Offset = "0xD83750", VA = "0xD83750")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xD831F4", Offset = "0xD831F4", VA = "0xD831F4")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xD83820", Offset = "0xD83820", VA = "0xD83820")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x2000086")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xD838BC", Offset = "0xD838BC", VA = "0xD838BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xD83A28", Offset = "0xD83A28", VA = "0xD83A28")]
	private void Update()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xD83C14", Offset = "0xD83C14", VA = "0xD83C14")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x2000087")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xD83C1C", Offset = "0xD83C1C", VA = "0xD83C1C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xD83E04", Offset = "0xD83E04", VA = "0xD83E04")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xD83FA4", Offset = "0xD83FA4", VA = "0xD83FA4")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x2000088")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class <FadeToCurrentStyle>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xD84BFC", Offset = "0xD84BFC", VA = "0xD84BFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0xD84C44", Offset = "0xD84C44", VA = "0xD84C44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xD84964", Offset = "0xD84964", VA = "0xD84964")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xD84AA8", Offset = "0xD84AA8", VA = "0xD84AA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xD84AAC", Offset = "0xD84AAC", VA = "0xD84AAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xD84C04", Offset = "0xD84C04", VA = "0xD84C04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class <FadeToDefaultPassthrough>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xD84DB8", Offset = "0xD84DB8", VA = "0xD84DB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0xD84E00", Offset = "0xD84E00", VA = "0xD84E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xD8498C", Offset = "0xD8498C", VA = "0xD8498C")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xD84C4C", Offset = "0xD84C4C", VA = "0xD84C4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xD84C50", Offset = "0xD84C50", VA = "0xD84C50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xD84DC0", Offset = "0xD84DC0", VA = "0xD84DC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator fadeIn;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator fadeOut;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform[] menuOptions;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform colorWheel;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D colorTexture;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool settingColor;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color savedColor;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float savedBrightness;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float savedContrast;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public CanvasGroup mainCanvas;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] compactObjects;

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xD83FAC", Offset = "0xD83FAC", VA = "0xD83FAC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xD842E8", Offset = "0xD842E8", VA = "0xD842E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xD84688", Offset = "0xD84688", VA = "0xD84688")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xD847FC", Offset = "0xD847FC", VA = "0xD847FC")]
	public void Release()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xD84778", Offset = "0xD84778", VA = "0xD84778")]
	[IteratorStateMachine(typeof(<FadeToCurrentStyle>d__18))]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xD848E0", Offset = "0xD848E0", VA = "0xD848E0")]
	[IteratorStateMachine(typeof(<FadeToDefaultPassthrough>d__19))]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xD849B4", Offset = "0xD849B4", VA = "0xD849B4")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xD849D4", Offset = "0xD849D4", VA = "0xD849D4")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xD849F4", Offset = "0xD849F4", VA = "0xD849F4")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xD84280", Offset = "0xD84280", VA = "0xD84280")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xD84A28", Offset = "0xD84A28", VA = "0xD84A28")]
	public void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xD84A34", Offset = "0xD84A34", VA = "0xD84A34")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xD84300", Offset = "0xD84300", VA = "0xD84300")]
	public void GetColorFromWheel()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xD84A40", Offset = "0xD84A40", VA = "0xD84A40")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x200008B")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xD84E08", Offset = "0xD84E08", VA = "0xD84E08")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xD84EBC", Offset = "0xD84EBC", VA = "0xD84EBC")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x200008C")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xD84EC4", Offset = "0xD84EC4", VA = "0xD84EC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xD84F30", Offset = "0xD84F30", VA = "0xD84F30")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xD85224", Offset = "0xD85224", VA = "0xD85224")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x200008D")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xD8522C", Offset = "0xD8522C", VA = "0xD8522C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xD85680", Offset = "0xD85680", VA = "0xD85680")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x200008E")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xD85688", Offset = "0xD85688", VA = "0xD85688")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xD858E8", Offset = "0xD858E8", VA = "0xD858E8")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xD85934", Offset = "0xD85934", VA = "0xD85934")]
	public void Release()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xD85974", Offset = "0xD85974", VA = "0xD85974")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x200008F")]
public class BouncingBallLogic : MonoBehaviour
{
	[Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class <PlayPopCallback>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float clipLength;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BouncingBallLogic <>4__this;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xD87090", Offset = "0xD87090", VA = "0xD87090", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xD870D8", Offset = "0xD870D8", VA = "0xD870D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xD86F70", Offset = "0xD86F70", VA = "0xD86F70")]
		[DebuggerHidden]
		public <PlayPopCallback>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xD86F98", Offset = "0xD86F98", VA = "0xD86F98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xD86F9C", Offset = "0xD86F9C", VA = "0xD86F9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xD87098", Offset = "0xD87098", VA = "0xD87098", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float TTL;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip pop;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip bounce;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip loadball;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material visibleMat;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material hiddenMat;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource audioSource;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform centerEyeCamera;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isVisible;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timer;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isReleased;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool isReadyForDestroy;

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xD8597C", Offset = "0xD8597C", VA = "0xD8597C")]
	private void OnCollisionEnter()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xD859A0", Offset = "0xD859A0", VA = "0xD859A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xD85AA8", Offset = "0xD85AA8", VA = "0xD85AA8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xD85B4C", Offset = "0xD85B4C", VA = "0xD85B4C")]
	private void UpdateVisibility()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xD85DA0", Offset = "0xD85DA0", VA = "0xD85DA0")]
	private void SetVisible(bool setVisible)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xD85E44", Offset = "0xD85E44", VA = "0xD85E44")]
	public void Release(Vector3 pos, Vector3 vel, Vector3 angVel)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xD85D1C", Offset = "0xD85D1C", VA = "0xD85D1C")]
	[IteratorStateMachine(typeof(<PlayPopCallback>d__18))]
	private IEnumerator PlayPopCallback(float clipLength)
	{
		return null;
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xD85F58", Offset = "0xD85F58", VA = "0xD85F58")]
	public BouncingBallLogic()
	{
	}
}
[Token(Token = "0x2000091")]
public class BouncingBallMgr : MonoBehaviour
{
	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform trackingspace;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject rightControllerPivot;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OVRInput.RawButton actionBtn;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject ball;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject currentBall;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool ballGrabbed;

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xD870E0", Offset = "0xD870E0", VA = "0xD870E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xD873F4", Offset = "0xD873F4", VA = "0xD873F4")]
	public BouncingBallMgr()
	{
	}
}
[Token(Token = "0x2000092")]
[DefaultExecutionOrder(30)]
[RequireComponent(typeof(OVRSceneAnchor))]
public class FurnitureSpawner : MonoBehaviour
{
	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Add a point at ceiling.")]
	public GameObject RoomLightPrefab;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Spawnable> SpawnablePrefabs;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRSceneAnchor _sceneAnchor;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private OVRSemanticClassification _classification;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject _roomLightRef;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _frameCounter;

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xD873FC", Offset = "0xD873FC", VA = "0xD873FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xD87614", Offset = "0xD87614", VA = "0xD87614")]
	private void SpawnSpawnable()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xD87A84", Offset = "0xD87A84", VA = "0xD87A84")]
	private bool FindValidSpawnable(out Spawnable currentSpawnable)
	{
		return default(bool);
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xD8749C", Offset = "0xD8749C", VA = "0xD8749C")]
	private void AddRoomLight()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xD87CA4", Offset = "0xD87CA4", VA = "0xD87CA4")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xD88190", Offset = "0xD88190", VA = "0xD88190")]
	public FurnitureSpawner()
	{
	}
}
[Token(Token = "0x2000093")]
public class MyCustomSceneModelLoader : OVRSceneModelLoader
{
	[Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class <DelayedLoad>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MyCustomSceneModelLoader <>4__this;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xD883C4", Offset = "0xD883C4", VA = "0xD883C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xD8840C", Offset = "0xD8840C", VA = "0xD8840C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xD8820C", Offset = "0xD8820C", VA = "0xD8820C")]
		[DebuggerHidden]
		public <DelayedLoad>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xD882C4", Offset = "0xD882C4", VA = "0xD882C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xD882C8", Offset = "0xD882C8", VA = "0xD882C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xD883CC", Offset = "0xD883CC", VA = "0xD883CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xD88198", Offset = "0xD88198", VA = "0xD88198")]
	[IteratorStateMachine(typeof(<DelayedLoad>d__0))]
	private IEnumerator DelayedLoad()
	{
		return null;
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xD88234", Offset = "0xD88234", VA = "0xD88234", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xD88254", Offset = "0xD88254", VA = "0xD88254", Slot = "6")]
	protected override void OnNoSceneModelToLoad()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xD882BC", Offset = "0xD882BC", VA = "0xD882BC")]
	public MyCustomSceneModelLoader()
	{
	}
}
[Token(Token = "0x2000095")]
[RequireComponent(typeof(OVRManager))]
public class PassthroughPlayInEditor : MonoBehaviour
{
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xD88414", Offset = "0xD88414", VA = "0xD88414")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xD88418", Offset = "0xD88418", VA = "0xD88418")]
	public PassthroughPlayInEditor()
	{
	}
}
[Token(Token = "0x2000096")]
public class RequestCaptureFlow : MonoBehaviour
{
	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Button RequestCaptureBtn;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRSceneManager _sceneManager;

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xD88420", Offset = "0xD88420", VA = "0xD88420")]
	private void Start()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xD88498", Offset = "0xD88498", VA = "0xD88498")]
	private void Update()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xD8851C", Offset = "0xD8851C", VA = "0xD8851C")]
	public RequestCaptureFlow()
	{
	}
}
[Token(Token = "0x2000097")]
[ExecuteInEditMode]
public class SimpleResizable : MonoBehaviour
{
	[Token(Token = "0x2000098")]
	public enum Method
	{
		[Token(Token = "0x40002E7")]
		Adapt,
		[Token(Token = "0x40002E8")]
		AdaptWithAsymmetricalPadding,
		[Token(Token = "0x40002E9")]
		Scale,
		[Token(Token = "0x40002EA")]
		None
	}

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(15f)]
	public Method ScalingX;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 0.5f)]
	public float PaddingX;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(-0.5f, 0f)]
	public float PaddingXMax;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(15f)]
	public Method ScalingY;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 0.5f)]
	public float PaddingY;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(-0.5f, 0f)]
	public float PaddingYMax;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(15f)]
	public Method ScalingZ;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0f, 0.5f)]
	public float PaddingZ;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(-0.5f, 0f)]
	public float PaddingZMax;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Bounds _bounds;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _pivotTransform;

	[Token(Token = "0x1700004F")]
	public Vector3 PivotPosition
	{
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xD8852C", Offset = "0xD8852C", VA = "0xD8852C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000050")]
	public Vector3 NewSize
	{
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xD88548", Offset = "0xD88548", VA = "0xD88548")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xD88554", Offset = "0xD88554", VA = "0xD88554")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000051")]
	public Vector3 DefaultSize
	{
		[Token(Token = "0x6000300")]
		[Address(RVA = "0xD88560", Offset = "0xD88560", VA = "0xD88560")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000301")]
		[Address(RVA = "0xD8856C", Offset = "0xD8856C", VA = "0xD8856C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public Mesh Mesh
	{
		[Token(Token = "0x6000302")]
		[Address(RVA = "0xD88578", Offset = "0xD88578", VA = "0xD88578")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000303")]
		[Address(RVA = "0xD88580", Offset = "0xD88580", VA = "0xD88580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xD88588", Offset = "0xD88588", VA = "0xD88588")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xD886C4", Offset = "0xD886C4", VA = "0xD886C4")]
	public SimpleResizable()
	{
	}
}
[Token(Token = "0x2000099")]
public class SimpleResizer
{
	[Token(Token = "0x6000306")]
	[Address(RVA = "0xD87DFC", Offset = "0xD87DFC", VA = "0xD87DFC")]
	public void CreateResizedObject(Vector3 newSize, GameObject parent, SimpleResizable sourcePrefab)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xD886CC", Offset = "0xD886CC", VA = "0xD886CC")]
	private Mesh ProcessVertices(SimpleResizable resizable, Vector3 newSize)
	{
		return null;
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xD88950", Offset = "0xD88950", VA = "0xD88950")]
	private float CalculateNewVertexPosition(SimpleResizable.Method resizeMethod, float currentPosition, float currentSize, float newSize, float padding, float paddingMax, float pivot)
	{
		return default(float);
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0xD87DF4", Offset = "0xD87DF4", VA = "0xD87DF4")]
	public SimpleResizer()
	{
	}
}
[Serializable]
[Token(Token = "0x200009A")]
public class Spawnable : ISerializationCallbackReceiver
{
	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SimpleResizable ResizablePrefab;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ClassificationLabel;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _editorClassificationIndex;

	[Token(Token = "0x600030A")]
	[Address(RVA = "0xD889F8", Offset = "0xD889F8", VA = "0xD889F8", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0xD889FC", Offset = "0xD889FC", VA = "0xD889FC", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xD88E64", Offset = "0xD88E64", VA = "0xD88E64")]
	public Spawnable()
	{
	}
}
[Token(Token = "0x200009B")]
[RequireComponent(typeof(OVRSceneAnchor))]
public class VolumeAndPlaneSwitcher : MonoBehaviour
{
	[Token(Token = "0x200009C")]
	public enum GeometryType
	{
		[Token(Token = "0x40002F2")]
		Plane,
		[Token(Token = "0x40002F3")]
		Volume
	}

	[Serializable]
	[Token(Token = "0x200009D")]
	public struct LabelGeometryPair
	{
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string label;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GeometryType desiredGeometryType;
	}

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSceneAnchor planePrefab;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRSceneAnchor volumePrefab;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<LabelGeometryPair> desiredSwitches;

	[Token(Token = "0x600030E")]
	[Address(RVA = "0xD88EBC", Offset = "0xD88EBC", VA = "0xD88EBC")]
	private void ReplaceAnchor(OVRSceneAnchor prefab, Vector3 position, Quaternion rotation, Vector3 localScale)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0xD892E8", Offset = "0xD892E8", VA = "0xD892E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0xD89C20", Offset = "0xD89C20", VA = "0xD89C20")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xD89AF8", Offset = "0xD89AF8", VA = "0xD89AF8")]
	private void GetTopPlaneFromVolume(Transform volume, Vector3 dimensions, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xD89CA0", Offset = "0xD89CA0", VA = "0xD89CA0")]
	public VolumeAndPlaneSwitcher()
	{
	}
}
[Token(Token = "0x200009E")]
[RequireComponent(typeof(OVRSpatialAnchor))]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class <Start>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Anchor <>4__this;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0xD8AA68", Offset = "0xD8AA68", VA = "0xD8AA68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0xD8AAB0", Offset = "0xD8AAB0", VA = "0xD8AAB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xD89E9C", Offset = "0xD89E9C", VA = "0xD89E9C")]
		[DebuggerHidden]
		public <Start>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xD8A8EC", Offset = "0xD8A8EC", VA = "0xD8A8EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xD8A8F0", Offset = "0xD8A8F0", VA = "0xD8A8F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xD8AA70", Offset = "0xD8AA70", VA = "0xD8AA70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002F6")]
	public const string NumUuidsPlayerPref = "numUuids";

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("canvas_")]
	private Canvas _canvas;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("pivot_")]
	private Transform _pivot;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("anchorMenu_")]
	private GameObject _anchorMenu;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _isSelected;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool _isHovered;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("anchorName_")]
	private TextMeshProUGUI _anchorName;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("saveIcon_")]
	private GameObject _saveIcon;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("labelImage_")]
	[SerializeField]
	private Image _labelImage;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[FormerlySerializedAs("labelBaseColor_")]
	private Color _labelBaseColor;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[FormerlySerializedAs("labelHighlightColor_")]
	private Color _labelHighlightColor;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	[FormerlySerializedAs("labelSelectedColor_")]
	private Color _labelSelectedColor;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	[FormerlySerializedAs("uiManager_")]
	private AnchorUIManager _uiManager;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[FormerlySerializedAs("renderers_")]
	private MeshRenderer[] _renderers;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _menuIndex;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[FormerlySerializedAs("buttonList_")]
	private List<Button> _buttonList;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Button _selectedButton;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private OVRSpatialAnchor _spatialAnchor;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject _icon;

	[Token(Token = "0x17000053")]
	public bool ShowSaveIcon
	{
		[Token(Token = "0x6000319")]
		[Address(RVA = "0xD8A348", Offset = "0xD8A348", VA = "0xD8A348")]
		set
		{
		}
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xD89CA8", Offset = "0xD89CA8", VA = "0xD89CA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xD89E28", Offset = "0xD89E28", VA = "0xD89E28")]
	[IteratorStateMachine(typeof(<Start>d__20))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xD89EC4", Offset = "0xD89EC4", VA = "0xD89EC4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xD8A13C", Offset = "0xD8A13C", VA = "0xD8A13C")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xD8A20C", Offset = "0xD8A20C", VA = "0xD8A20C")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xD8A278", Offset = "0xD8A278", VA = "0xD8A278")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xD8A368", Offset = "0xD8A368", VA = "0xD8A368")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xD8A484", Offset = "0xD8A484", VA = "0xD8A484")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xD8A58C", Offset = "0xD8A58C", VA = "0xD8A58C")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xD89F14", Offset = "0xD89F14", VA = "0xD89F14")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xD8A048", Offset = "0xD8A048", VA = "0xD8A048")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xD8A65C", Offset = "0xD8A65C", VA = "0xD8A65C")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xD8A794", Offset = "0xD8A794", VA = "0xD8A794")]
	public Anchor()
	{
	}
}
[Token(Token = "0x20000A0")]
[RequireComponent(typeof(SpatialAnchorLoader))]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x20000A1")]
	public enum AnchorMode
	{
		[Token(Token = "0x400031F")]
		Create,
		[Token(Token = "0x4000320")]
		Select
	}

	[Token(Token = "0x20000A2")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[FormerlySerializedAs("createModeButton_")]
	private GameObject _createModeButton;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("selectModeButton_")]
	private GameObject _selectModeButton;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("trackedDevice_")]
	private Transform _trackedDevice;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _raycastOrigin;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _drawRaycast;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("lineRenderer_")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Anchor _hoveredAnchor;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor _selectedAnchor;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnchorMode _mode;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[FormerlySerializedAs("buttonList_")]
	[SerializeField]
	private List<Button> _buttonList;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _menuIndex;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Button _selectedButton;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Anchor _anchorPrefab;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("placementPreview_")]
	[SerializeField]
	private GameObject _placementPreview;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("anchorPlacementTransform_")]
	[SerializeField]
	private Transform _anchorPlacementTransform;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate _primaryPressDelegate;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool _isFocused;

	[Token(Token = "0x17000056")]
	public Anchor AnchorPrefab
	{
		[Token(Token = "0x6000329")]
		[Address(RVA = "0xD8AAB8", Offset = "0xD8AAB8", VA = "0xD8AAB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xD8AAC0", Offset = "0xD8AAC0", VA = "0xD8AAC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xD8AB8C", Offset = "0xD8AB8C", VA = "0xD8AB8C")]
	private void Start()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xD8ACDC", Offset = "0xD8ACDC", VA = "0xD8ACDC")]
	private void Update()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0xD8B14C", Offset = "0xD8B14C", VA = "0xD8B14C")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0xD8B1B8", Offset = "0xD8B1B8", VA = "0xD8B1B8")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xD8AC74", Offset = "0xD8AC74", VA = "0xD8AC74")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xD8B438", Offset = "0xD8B438", VA = "0xD8B438")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xD8B4C0", Offset = "0xD8B4C0", VA = "0xD8B4C0")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0xD8B4E0", Offset = "0xD8B4E0", VA = "0xD8B4E0")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xD8B418", Offset = "0xD8B418", VA = "0xD8B418")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xD8B058", Offset = "0xD8B058", VA = "0xD8B058")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xD8B6E0", Offset = "0xD8B6E0", VA = "0xD8B6E0")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xD8B568", Offset = "0xD8B568", VA = "0xD8B568")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xD8B654", Offset = "0xD8B654", VA = "0xD8B654")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xD8B7E0", Offset = "0xD8B7E0", VA = "0xD8B7E0")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xD8B674", Offset = "0xD8B674", VA = "0xD8B674")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xD8B6AC", Offset = "0xD8B6AC", VA = "0xD8B6AC")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xD8ADDC", Offset = "0xD8ADDC", VA = "0xD8ADDC")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xD8B8CC", Offset = "0xD8B8CC", VA = "0xD8B8CC")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xD8B8F4", Offset = "0xD8B8F4", VA = "0xD8B8F4")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xD8B984", Offset = "0xD8B984", VA = "0xD8B984")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xD8BACC", Offset = "0xD8BACC", VA = "0xD8BACC")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x20000A3")]
public class SpatialAnchorLoader : MonoBehaviour
{
	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRSpatialAnchor _anchorPrefab;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action<OVRSpatialAnchor.UnboundAnchor, bool> _onLoadAnchor;

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xD8B20C", Offset = "0xD8B20C", VA = "0xD8B20C")]
	public void LoadAnchorsByUuid()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xD8BC88", Offset = "0xD8BC88", VA = "0xD8BC88")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xD8BBA8", Offset = "0xD8BBA8", VA = "0xD8BBA8")]
	private void Load(OVRSpatialAnchor.LoadOptions options)
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xD8BD0C", Offset = "0xD8BD0C", VA = "0xD8BD0C")]
	private void OnLocalized(OVRSpatialAnchor.UnboundAnchor unboundAnchor, bool success)
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xD8BB1C", Offset = "0xD8BB1C", VA = "0xD8BB1C")]
	private static void Log(string message)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xD8BEBC", Offset = "0xD8BEBC", VA = "0xD8BEBC")]
	public SpatialAnchorLoader()
	{
	}
}
[Token(Token = "0x20000A4")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xD8BFF4", Offset = "0xD8BFF4", VA = "0xD8BFF4")]
	private void Start()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xD8C208", Offset = "0xD8C208", VA = "0xD8C208")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xD8C30C", Offset = "0xD8C30C", VA = "0xD8C30C")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x20000A6")]
public class LocalizedHaptics : MonoBehaviour
{
	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	[SerializeField]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xD8C330", Offset = "0xD8C330", VA = "0xD8C330")]
	private void Start()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xD8C358", Offset = "0xD8C358", VA = "0xD8C358")]
	private void Update()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xD8C494", Offset = "0xD8C494", VA = "0xD8C494")]
	public LocalizedHaptics()
	{
	}
}
[Token(Token = "0x20000A7")]
public class SceneSettings : MonoBehaviour
{
	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Time")]
	[SerializeField]
	private float m_fixedTimeStep;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Header("Physics")]
	[SerializeField]
	private float m_gravityScalar;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_defaultContactOffset;

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xD8C4A4", Offset = "0xD8C4A4", VA = "0xD8C4A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xD8C53C", Offset = "0xD8C53C", VA = "0xD8C53C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xD8C544", Offset = "0xD8C544", VA = "0xD8C544")]
	private static void CollidersSetContactOffset(float contactOffset)
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0xD8C608", Offset = "0xD8C608", VA = "0xD8C608")]
	public SceneSettings()
	{
	}
}
[Token(Token = "0x20000A8")]
public class StylusTip : MonoBehaviour
{
	[Token(Token = "0x400032D")]
	private const int MaxBreadCrumbs = 60;

	[Token(Token = "0x400032E")]
	private const float BreadCrumbMinSize = 0.005f;

	[Token(Token = "0x400032F")]
	private const float BreadCrumbMaxSize = 0.02f;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("External")]
	[SerializeField]
	private Transform m_trackingSpace;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("Settings")]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_breadCrumbPf;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject m_breadCrumbContainer;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject[] m_breadCrumbs;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_breadCrumbIndexPrev;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int m_breadCrumbIndexCurr;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xD8C628", Offset = "0xD8C628", VA = "0xD8C628")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0xD8C8A8", Offset = "0xD8C8A8", VA = "0xD8C8A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0xD8CCD8", Offset = "0xD8CCD8", VA = "0xD8CCD8")]
	private static Pose GetT_Device_StylusTip(OVRInput.Controller controller)
	{
		return default(Pose);
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xD8CE04", Offset = "0xD8CE04", VA = "0xD8CE04")]
	public StylusTip()
	{
	}
}
[Token(Token = "0x20000A9")]
public class UiAxis1dInspector : MonoBehaviour
{
	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	[SerializeField]
	private float m_minExtent;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_maxExtent;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Components")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Slider m_slider;

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xD8CE1C", Offset = "0xD8CE1C", VA = "0xD8CE1C")]
	public void SetExtents(float minExtent, float maxExtent)
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xD8CE24", Offset = "0xD8CE24", VA = "0xD8CE24")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xD8CE48", Offset = "0xD8CE48", VA = "0xD8CE48")]
	public void SetValue(float value)
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xD8CF4C", Offset = "0xD8CF4C", VA = "0xD8CF4C")]
	public UiAxis1dInspector()
	{
	}
}
[Token(Token = "0x20000AA")]
public class UiAxis2dInspector : MonoBehaviour
{
	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	[SerializeField]
	private Vector2 m_xExtent;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 m_yExtent;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Header("Components")]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image m_handle;

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xD8CF5C", Offset = "0xD8CF5C", VA = "0xD8CF5C")]
	public void SetExtents(Vector2 xExtent, Vector2 yExtent)
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xD8CF68", Offset = "0xD8CF68", VA = "0xD8CF68")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xD8CF8C", Offset = "0xD8CF8C", VA = "0xD8CF8C")]
	public void SetValue(bool isTouching, Vector2 value)
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xD8D354", Offset = "0xD8D354", VA = "0xD8D354")]
	public UiAxis2dInspector()
	{
	}
}
[Token(Token = "0x20000AB")]
public class UiBoolInspector : MonoBehaviour
{
	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Components")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Toggle m_toggle;

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xD8D368", Offset = "0xD8D368", VA = "0xD8D368")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xD8D38C", Offset = "0xD8D38C", VA = "0xD8D38C")]
	public void SetValue(bool value)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xD8D3AC", Offset = "0xD8D3AC", VA = "0xD8D3AC")]
	public UiBoolInspector()
	{
	}
}
[Token(Token = "0x20000AC")]
public class UiDeviceInspector : MonoBehaviour
{
	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	[SerializeField]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("Left Column Components")]
	private TextMeshProUGUI m_title;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_status;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UiBoolInspector m_thumbRestTouch;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UiAxis1dInspector m_thumbRestForce;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UiAxis1dInspector m_indexTrigger;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UiAxis1dInspector m_gripTrigger;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UiAxis1dInspector m_stylusTipForce;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UiAxis1dInspector m_indexCurl1d;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UiAxis1dInspector m_indexSlider1d;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("Right Column Components")]
	[SerializeField]
	private UiBoolInspector m_ax;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UiBoolInspector m_axTouch;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UiBoolInspector m_by;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UiBoolInspector m_byTouch;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UiBoolInspector m_indexTouch;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UiAxis2dInspector m_thumbstick;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xD8D3B4", Offset = "0xD8D3B4", VA = "0xD8D3B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xD8D3DC", Offset = "0xD8D3DC", VA = "0xD8D3DC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0xD8D964", Offset = "0xD8D964", VA = "0xD8D964")]
	private static string ToDeviceModel()
	{
		return null;
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0xD8D9A4", Offset = "0xD8D9A4", VA = "0xD8D9A4")]
	private static string ToHandednessString(OVRInput.Handedness handedness)
	{
		return null;
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xD8DA28", Offset = "0xD8DA28", VA = "0xD8DA28")]
	public UiDeviceInspector()
	{
	}
}
[Token(Token = "0x20000AD")]
public class UiSceneMenu : MonoBehaviour
{
	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Settings")]
	[SerializeField]
	private VerticalLayoutGroup m_layoutGroup;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_labelPf;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector2 s_lastThumbstickL;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Vector2 s_lastThumbstickR;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Scene m_activeScene;

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xD8DA38", Offset = "0xD8DA38", VA = "0xD8DA38")]
	private void Awake()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xD8DD04", Offset = "0xD8DD04", VA = "0xD8DD04")]
	private void Update()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xD8DE1C", Offset = "0xD8DE1C", VA = "0xD8DE1C")]
	private bool InputPrevScene()
	{
		return default(bool);
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xD8DEB8", Offset = "0xD8DEB8", VA = "0xD8DEB8")]
	private bool InputNextScene()
	{
		return default(bool);
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xD8DEFC", Offset = "0xD8DEFC", VA = "0xD8DEFC")]
	private bool KeyboardPrevScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0xD8DF98", Offset = "0xD8DF98", VA = "0xD8DF98")]
	private bool KeyboardNextScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0xD8DF08", Offset = "0xD8DF08", VA = "0xD8DF08")]
	private bool ThumbstickPrevScene(OVRInput.Controller controller)
	{
		return default(bool);
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0xD8DFA4", Offset = "0xD8DFA4", VA = "0xD8DFA4")]
	private bool ThumbstickNextScene(OVRInput.Controller controller)
	{
		return default(bool);
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xD8E034", Offset = "0xD8E034", VA = "0xD8E034")]
	private Vector2 GetLastThumbstickValue(OVRInput.Controller controller)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xD8DE60", Offset = "0xD8DE60", VA = "0xD8DE60")]
	private void ChangeScene(int nextScene)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xD8DADC", Offset = "0xD8DADC", VA = "0xD8DADC")]
	private void CreateLabel(int sceneIndex, string scenePath)
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xD8E09C", Offset = "0xD8E09C", VA = "0xD8E09C")]
	public UiSceneMenu()
	{
	}
}
[Token(Token = "0x20000AE")]
public class UiVectorInspector : MonoBehaviour
{
	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Components")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xD8E0A4", Offset = "0xD8E0A4", VA = "0xD8E0A4")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xD8E0C8", Offset = "0xD8E0C8", VA = "0xD8E0C8")]
	public void SetValue(bool value)
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xD8E178", Offset = "0xD8E178", VA = "0xD8E178")]
	public UiVectorInspector()
	{
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x20000AF")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x17000057")]
		public bool Highlight
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0xD8E180", Offset = "0xD8E180", VA = "0xD8E180")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600037B")]
			[Address(RVA = "0xD8E188", Offset = "0xD8E188", VA = "0xD8E188")]
			set
			{
			}
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xD8E194", Offset = "0xD8E194", VA = "0xD8E194")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xD8E334", Offset = "0xD8E334", VA = "0xD8E334", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xD8E350", Offset = "0xD8E350", VA = "0xD8E350", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xD8E36C", Offset = "0xD8E36C", VA = "0xD8E36C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xD8E240", Offset = "0xD8E240", VA = "0xD8E240")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xD8E620", Offset = "0xD8E620", VA = "0xD8E620")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x17000058")]
		public bool InRange
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0xD8E698", Offset = "0xD8E698", VA = "0xD8E698")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000384")]
			[Address(RVA = "0xD8E6A0", Offset = "0xD8E6A0", VA = "0xD8E6A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public bool Targeted
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0xD8E80C", Offset = "0xD8E80C", VA = "0xD8E80C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000386")]
			[Address(RVA = "0xD8E814", Offset = "0xD8E814", VA = "0xD8E814")]
			set
			{
			}
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xD8E820", Offset = "0xD8E820", VA = "0xD8E820", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xD8E6AC", Offset = "0xD8E6AC", VA = "0xD8E6AC")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xD8EA10", Offset = "0xD8EA10", VA = "0xD8EA10")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[RequireComponent(typeof(Rigidbody))]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x1700005A")]
		public bool UseSpherecast
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0xD8EA18", Offset = "0xD8EA18", VA = "0xD8EA18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0xD8EA20", Offset = "0xD8EA20", VA = "0xD8EA20")]
			set
			{
			}
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xD8EA3C", Offset = "0xD8EA3C", VA = "0xD8EA3C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xD8EC48", Offset = "0xD8EC48", VA = "0xD8EC48", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xD8F534", Offset = "0xD8F534", VA = "0xD8F534", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xD8FA9C", Offset = "0xD8FA9C", VA = "0xD8FA9C", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xD8FEAC", Offset = "0xD8FEAC", VA = "0xD8FEAC")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xD8EE70", Offset = "0xD8EE70", VA = "0xD8EE70")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xD8FF98", Offset = "0xD8FF98", VA = "0xD8FF98")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xD90398", Offset = "0xD90398", VA = "0xD90398", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xD903B0", Offset = "0xD903B0", VA = "0xD903B0", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xD903B8", Offset = "0xD903B8", VA = "0xD903B8")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x20000B3")]
		public enum CrosshairState
		{
			[Token(Token = "0x400037A")]
			Disabled,
			[Token(Token = "0x400037B")]
			Enabled,
			[Token(Token = "0x400037C")]
			Targeted
		}

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xD903D8", Offset = "0xD903D8", VA = "0xD903D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xD8E984", Offset = "0xD8E984", VA = "0xD8E984")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xD90440", Offset = "0xD90440", VA = "0xD90440")]
		private void Update()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xD90478", Offset = "0xD90478", VA = "0xD90478")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xD90480", Offset = "0xD90480", VA = "0xD90480")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xD9052C", Offset = "0xD9052C", VA = "0xD9052C")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xD905D4", Offset = "0xD905D4", VA = "0xD905D4")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x600039D")]
		[Address(RVA = "0xD905DC", Offset = "0xD905DC", VA = "0xD905DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xD906C8", Offset = "0xD906C8", VA = "0xD906C8")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xD906D4", Offset = "0xD906D4", VA = "0xD906D4")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xD906E0", Offset = "0xD906E0", VA = "0xD906E0")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xD906E8", Offset = "0xD906E8", VA = "0xD906E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xD90738", Offset = "0xD90738", VA = "0xD90738")]
		private void Update()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xD90B10", Offset = "0xD90B10", VA = "0xD90B10")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xD90BFC", Offset = "0xD90BFC", VA = "0xD90BFC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xD9073C", Offset = "0xD9073C", VA = "0xD9073C")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xD90CE8", Offset = "0xD90CE8", VA = "0xD90CE8")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x20000B8")]
		public enum ContactTest
		{
			[Token(Token = "0x4000393")]
			PerpenTest,
			[Token(Token = "0x4000394")]
			BackwardsPress
		}

		[Token(Token = "0x4000384")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x4000385")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x1700005B")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0xD90DC0", Offset = "0xD90DC0", VA = "0xD90DC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005C")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xD90DC8", Offset = "0xD90DC8", VA = "0xD90DC8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700005D")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xD90DD4", Offset = "0xD90DD4", VA = "0xD90DD4")]
			[CompilerGenerated]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xD90DDC", Offset = "0xD90DDC", VA = "0xD90DDC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xD90DE4", Offset = "0xD90DE4", VA = "0xD90DE4", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xD90F34", Offset = "0xD90F34", VA = "0xD90F34")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xD9113C", Offset = "0xD9113C", VA = "0xD9113C", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xD91700", Offset = "0xD91700", VA = "0xD91700")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xD91868", Offset = "0xD91868", VA = "0xD91868")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xD91624", Offset = "0xD91624", VA = "0xD91624")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xD91974", Offset = "0xD91974", VA = "0xD91974")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xD91A80", Offset = "0xD91A80", VA = "0xD91A80")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xD91B08", Offset = "0xD91B08", VA = "0xD91B08")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x1700005E")]
		public Collider Collider
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xD91C2C", Offset = "0xD91C2C", VA = "0xD91C2C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0xD91C34", Offset = "0xD91C34", VA = "0xD91C34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0xD91C3C", Offset = "0xD91C3C", VA = "0xD91C3C", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0xD91C44", Offset = "0xD91C44", VA = "0xD91C44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0xD91C4C", Offset = "0xD91C4C", VA = "0xD91C4C", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xD91C9C", Offset = "0xD91C9C", VA = "0xD91C9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xD91D30", Offset = "0xD91D30", VA = "0xD91D30")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public interface ColliderZone
	{
		[Token(Token = "0x17000061")]
		Collider Collider
		{
			[Token(Token = "0x60003BB")]
			get;
		}

		[Token(Token = "0x17000062")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x60003BC")]
			get;
		}

		[Token(Token = "0x17000063")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x60003BD")]
			get;
		}
	}
	[Token(Token = "0x20000BB")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xD91090", Offset = "0xD91090", VA = "0xD91090")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public enum InteractionType
	{
		[Token(Token = "0x400039D")]
		Enter,
		[Token(Token = "0x400039E")]
		Stay,
		[Token(Token = "0x400039F")]
		Exit
	}
	[Token(Token = "0x20000BD")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x20000BE")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x40003B1")]
			Mesh,
			[Token(Token = "0x40003B2")]
			Skeleton,
			[Token(Token = "0x40003B3")]
			Both
		}

		[Token(Token = "0x20000BF")]
		[CompilerGenerated]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x1700006F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003E0")]
				[Address(RVA = "0xD93190", Offset = "0xD93190", VA = "0xD93190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003E2")]
				[Address(RVA = "0xD931D8", Offset = "0xD931D8", VA = "0xD931D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003DD")]
			[Address(RVA = "0xD92788", Offset = "0xD92788", VA = "0xD92788")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xD92F70", Offset = "0xD92F70", VA = "0xD92F70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0xD92F74", Offset = "0xD92F74", VA = "0xD92F74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xD93198", Offset = "0xD93198", VA = "0xD93198", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A0")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x17000064")]
		public OVRHand RightHand
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0xD91D38", Offset = "0xD91D38", VA = "0xD91D38")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0xD91D64", Offset = "0xD91D64", VA = "0xD91D64")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0xD91DC8", Offset = "0xD91DC8", VA = "0xD91DC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xD91DF4", Offset = "0xD91DF4", VA = "0xD91DF4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0xD91E58", Offset = "0xD91E58", VA = "0xD91E58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xD91E84", Offset = "0xD91E84", VA = "0xD91E84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xD91EE8", Offset = "0xD91EE8", VA = "0xD91EE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0xD91F14", Offset = "0xD91F14", VA = "0xD91F14")]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xD91F78", Offset = "0xD91F78", VA = "0xD91F78")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0xD91FA4", Offset = "0xD91FA4", VA = "0xD91FA4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0xD92008", Offset = "0xD92008", VA = "0xD92008")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0xD92030", Offset = "0xD92030", VA = "0xD92030")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0xD92090", Offset = "0xD92090", VA = "0xD92090")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0xD920B8", Offset = "0xD920B8", VA = "0xD920B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0xD92118", Offset = "0xD92118", VA = "0xD92118")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xD92140", Offset = "0xD92140", VA = "0xD92140")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0xD921A0", Offset = "0xD921A0", VA = "0xD921A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xD921C8", Offset = "0xD921C8", VA = "0xD921C8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0xD92228", Offset = "0xD92228", VA = "0xD92228")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xD92250", Offset = "0xD92250", VA = "0xD92250")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public static HandsManager Instance
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0xD922B0", Offset = "0xD922B0", VA = "0xD922B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xD922F8", Offset = "0xD922F8", VA = "0xD922F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xD92350", Offset = "0xD92350", VA = "0xD92350")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xD9270C", Offset = "0xD9270C", VA = "0xD9270C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xD92698", Offset = "0xD92698", VA = "0xD92698")]
		[IteratorStateMachine(typeof(<FindSkeletonVisualGameObjects>d__52))]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xD927B0", Offset = "0xD927B0", VA = "0xD927B0")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xD92874", Offset = "0xD92874", VA = "0xD92874")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xD92A44", Offset = "0xD92A44", VA = "0xD92A44")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xD92CA8", Offset = "0xD92CA8", VA = "0xD92CA8")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xD92E08", Offset = "0xD92E08", VA = "0xD92E08")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0xD93828", Offset = "0xD93828", VA = "0xD93828")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x17000071")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xD931E0", Offset = "0xD931E0", VA = "0xD931E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xD931E8", Offset = "0xD931E8", VA = "0xD931E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0xD931F0", Offset = "0xD931F0", VA = "0xD931F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xD931F8", Offset = "0xD931F8", VA = "0xD931F8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xD93200", Offset = "0xD93200", VA = "0xD93200")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xD932B0", Offset = "0xD932B0", VA = "0xD932B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xD9337C", Offset = "0xD9337C", VA = "0xD9337C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xD9342C", Offset = "0xD9342C", VA = "0xD9342C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0xD934F8", Offset = "0xD934F8", VA = "0xD934F8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0xD935A8", Offset = "0xD935A8", VA = "0xD935A8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xD93360", Offset = "0xD93360", VA = "0xD93360", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xD934DC", Offset = "0xD934DC", VA = "0xD934DC", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xD93658", Offset = "0xD93658", VA = "0xD93658", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60003F0")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xD90EE0", Offset = "0xD90EE0", VA = "0xD90EE0", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xD93724", Offset = "0xD93724", VA = "0xD93724", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xD91C24", Offset = "0xD91C24", VA = "0xD91C24")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x40003BF")]
		None,
		[Token(Token = "0x40003C0")]
		Proximity,
		[Token(Token = "0x40003C1")]
		Contact,
		[Token(Token = "0x40003C2")]
		Action
	}
	[Token(Token = "0x20000C3")]
	public enum InteractableState
	{
		[Token(Token = "0x40003C4")]
		Default,
		[Token(Token = "0x40003C5")]
		ProximityState,
		[Token(Token = "0x40003C6")]
		ContactState,
		[Token(Token = "0x40003C7")]
		ActionState
	}
	[Token(Token = "0x20000C4")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xD917B0", Offset = "0xD917B0", VA = "0xD917B0")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x17000075")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xD93870", Offset = "0xD93870", VA = "0xD93870")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xD93674", Offset = "0xD93674", VA = "0xD93674")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xD93778", Offset = "0xD93778", VA = "0xD93778")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xD938C8", Offset = "0xD938C8", VA = "0xD938C8")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x20000C7")]
		[CompilerGenerated]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x17000076")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000403")]
				[Address(RVA = "0xD94088", Offset = "0xD94088", VA = "0xD94088", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000077")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000405")]
				[Address(RVA = "0xD940D0", Offset = "0xD940D0", VA = "0xD940D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xD93A70", Offset = "0xD93A70", VA = "0xD93A70")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0xD93BAC", Offset = "0xD93BAC", VA = "0xD93BAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0xD93BC8", Offset = "0xD93BC8", VA = "0xD93BC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000402")]
			[Address(RVA = "0xD94038", Offset = "0xD94038", VA = "0xD94038")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000404")]
			[Address(RVA = "0xD94090", Offset = "0xD94090", VA = "0xD94090", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xD93968", Offset = "0xD93968", VA = "0xD93968")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xD939D4", Offset = "0xD939D4", VA = "0xD939D4")]
		[IteratorStateMachine(typeof(<AttachToolsToHands>d__3))]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xD93A98", Offset = "0xD93A98", VA = "0xD93A98")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xD93BA4", Offset = "0xD93BA4", VA = "0xD93BA4")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x17000078")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xD940D8", Offset = "0xD940D8", VA = "0xD940D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xD94234", Offset = "0xD94234", VA = "0xD94234")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xD942D0", Offset = "0xD942D0", VA = "0xD942D0")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xD9436C", Offset = "0xD9436C", VA = "0xD9436C")]
		private void Update()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xD94608", Offset = "0xD94608", VA = "0xD94608")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xD94644", Offset = "0xD94644", VA = "0xD94644")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xD9491C", Offset = "0xD9491C", VA = "0xD9491C")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xD94B24", Offset = "0xD94B24", VA = "0xD94B24")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x20000CA")]
		[CompilerGenerated]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x1700007D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600041F")]
				[Address(RVA = "0xD95CF4", Offset = "0xD95CF4", VA = "0xD95CF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000421")]
				[Address(RVA = "0xD95D3C", Offset = "0xD95D3C", VA = "0xD95D3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041C")]
			[Address(RVA = "0xD94DC0", Offset = "0xD94DC0", VA = "0xD94DC0")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0xD95864", Offset = "0xD95864", VA = "0xD95864", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0xD95868", Offset = "0xD95868", VA = "0xD95868", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0xD95CFC", Offset = "0xD95CFC", VA = "0xD95CFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003E0")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x17000079")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xD94C2C", Offset = "0xD94C2C", VA = "0xD94C2C", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x1700007A")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xD94C34", Offset = "0xD94C34", VA = "0xD94C34", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x1700007B")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0xD94C3C", Offset = "0xD94C3C", VA = "0xD94C3C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public override bool EnableState
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0xD94C44", Offset = "0xD94C44", VA = "0xD94C44", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000412")]
			[Address(RVA = "0xD94C6C", Offset = "0xD94C6C", VA = "0xD94C6C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xD94C9C", Offset = "0xD94C9C", VA = "0xD94C9C", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xD94D4C", Offset = "0xD94D4C", VA = "0xD94D4C")]
		[IteratorStateMachine(typeof(<AttachTriggerLogic>d__21))]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xD94DE8", Offset = "0xD94DE8", VA = "0xD94DE8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xD95068", Offset = "0xD95068", VA = "0xD95068")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xD95224", Offset = "0xD95224", VA = "0xD95224")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xD9530C", Offset = "0xD9530C", VA = "0xD9530C", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xD956A0", Offset = "0xD956A0", VA = "0xD956A0", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xD956A4", Offset = "0xD956A4", VA = "0xD956A4", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xD956A8", Offset = "0xD956A8", VA = "0xD956A8")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x1700007F")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xD95D44", Offset = "0xD95D44", VA = "0xD95D44", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000423")]
			[Address(RVA = "0xD95D4C", Offset = "0xD95D4C", VA = "0xD95D4C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public bool EnableState
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0xD95D54", Offset = "0xD95D54", VA = "0xD95D54", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xD95D70", Offset = "0xD95D70", VA = "0xD95D70", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0xD95D90", Offset = "0xD95D90", VA = "0xD95D90", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000427")]
			[Address(RVA = "0xD95D98", Offset = "0xD95D98", VA = "0xD95D98", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public float SphereRadius
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0xD95DA4", Offset = "0xD95DA4", VA = "0xD95DA4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000429")]
			[Address(RVA = "0xD95DAC", Offset = "0xD95DAC", VA = "0xD95DAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xD95DB4", Offset = "0xD95DB4", VA = "0xD95DB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xD95DF0", Offset = "0xD95DF0", VA = "0xD95DF0", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xD95DF4", Offset = "0xD95DF4", VA = "0xD95DF4")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x40003F3")]
		None = 0,
		[Token(Token = "0x40003F4")]
		Ray = 1,
		[Token(Token = "0x40003F5")]
		Poke = 4,
		[Token(Token = "0x40003F6")]
		All = -1
	}
	[Token(Token = "0x20000CD")]
	public enum ToolInputState
	{
		[Token(Token = "0x40003F8")]
		Inactive,
		[Token(Token = "0x40003F9")]
		PrimaryInputDown,
		[Token(Token = "0x40003FA")]
		PrimaryInputDownStay,
		[Token(Token = "0x40003FB")]
		PrimaryInputUp
	}
	[Token(Token = "0x20000CE")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xD9564C", Offset = "0xD9564C", VA = "0xD9564C")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x17000083")]
		public Transform ToolTransform
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0xD91B00", Offset = "0xD91B00", VA = "0xD91B00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0xD95DFC", Offset = "0xD95DFC", VA = "0xD95DFC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000430")]
			[Address(RVA = "0xD95E04", Offset = "0xD95E04", VA = "0xD95E04")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000431")]
			get;
		}

		[Token(Token = "0x17000086")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x6000432")]
			get;
		}

		[Token(Token = "0x17000087")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x6000433")]
			get;
		}

		[Token(Token = "0x17000088")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0xD95E10", Offset = "0xD95E10", VA = "0xD95E10")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000435")]
			[Address(RVA = "0xD95E1C", Offset = "0xD95E1C", VA = "0xD95E1C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0xD95E28", Offset = "0xD95E28", VA = "0xD95E28")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0xD95E34", Offset = "0xD95E34", VA = "0xD95E34")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public abstract bool EnableState
		{
			[Token(Token = "0x600043C")]
			get;
			[Token(Token = "0x600043D")]
			set;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xD95E40", Offset = "0xD95E40", VA = "0xD95E40")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x600043A")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x600043B")]
		public abstract void DeFocus();

		[Token(Token = "0x600043E")]
		public abstract void Initialize();

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xD94A8C", Offset = "0xD94A8C", VA = "0xD94A8C")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xD94AD4", Offset = "0xD94AD4", VA = "0xD94AD4")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xD95E48", Offset = "0xD95E48", VA = "0xD95E48", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xD96110", Offset = "0xD96110", VA = "0xD96110", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xD956BC", Offset = "0xD956BC", VA = "0xD956BC")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public interface InteractableToolView
	{
		[Token(Token = "0x1700008B")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x6000444")]
			get;
		}

		[Token(Token = "0x1700008C")]
		bool EnableState
		{
			[Token(Token = "0x6000446")]
			get;
			[Token(Token = "0x6000447")]
			set;
		}

		[Token(Token = "0x1700008D")]
		bool ToolActivateState
		{
			[Token(Token = "0x6000448")]
			get;
			[Token(Token = "0x6000449")]
			set;
		}

		[Token(Token = "0x6000445")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x20000D1")]
	public class PinchStateModule
	{
		[Token(Token = "0x20000D2")]
		private enum PinchState
		{
			[Token(Token = "0x400040C")]
			None,
			[Token(Token = "0x400040D")]
			PinchDown,
			[Token(Token = "0x400040E")]
			PinchStay,
			[Token(Token = "0x400040F")]
			PinchUp
		}

		[Token(Token = "0x4000408")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x1700008E")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0xD969AC", Offset = "0xD969AC", VA = "0xD969AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008F")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0xD96A28", Offset = "0xD96A28", VA = "0xD96A28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0xD96AA4", Offset = "0xD96AA4", VA = "0xD96AA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xD96B20", Offset = "0xD96B20", VA = "0xD96B20")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xD96B48", Offset = "0xD96B48", VA = "0xD96B48")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x4000410")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x4000411")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x4000412")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x4000413")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x4000414")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 45f)]
		[SerializeField]
		private float _coneAngleDegrees;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x17000091")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0xD96CC0", Offset = "0xD96CC0", VA = "0xD96CC0", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x17000092")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0xD96CC8", Offset = "0xD96CC8", VA = "0xD96CC8", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x17000093")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0xD96D24", Offset = "0xD96D24", VA = "0xD96D24", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		public override bool EnableState
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0xD96D2C", Offset = "0xD96D2C", VA = "0xD96D2C", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0xD96D6C", Offset = "0xD96D6C", VA = "0xD96D6C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xD96DDC", Offset = "0xD96DDC", VA = "0xD96DDC", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xD96E30", Offset = "0xD96E30", VA = "0xD96E30")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xD96EBC", Offset = "0xD96EBC", VA = "0xD96EBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xD97160", Offset = "0xD97160", VA = "0xD97160")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xD971DC", Offset = "0xD971DC", VA = "0xD971DC", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xD975D0", Offset = "0xD975D0", VA = "0xD975D0")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xD9776C", Offset = "0xD9776C", VA = "0xD9776C")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xD97884", Offset = "0xD97884", VA = "0xD97884")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xD97BA8", Offset = "0xD97BA8", VA = "0xD97BA8")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xD97F24", Offset = "0xD97F24", VA = "0xD97F24", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xD97FFC", Offset = "0xD97FFC", VA = "0xD97FFC", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xD9802C", Offset = "0xD9802C", VA = "0xD9802C")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000420")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x4000421")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x17000095")]
		public bool EnableState
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0xD96D50", Offset = "0xD96D50", VA = "0xD96D50", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000461")]
			[Address(RVA = "0xD96D88", Offset = "0xD96D88", VA = "0xD96D88", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0xD98140", Offset = "0xD98140", VA = "0xD98140", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000463")]
			[Address(RVA = "0xD97124", Offset = "0xD97124", VA = "0xD97124", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0xD98368", Offset = "0xD98368", VA = "0xD98368", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000466")]
			[Address(RVA = "0xD98370", Offset = "0xD98370", VA = "0xD98370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xD98148", Offset = "0xD98148", VA = "0xD98148")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xD97F5C", Offset = "0xD97F5C", VA = "0xD97F5C", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xD98378", Offset = "0xD98378", VA = "0xD98378")]
		private void Update()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xD98624", Offset = "0xD98624", VA = "0xD98624")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xD986CC", Offset = "0xD986CC", VA = "0xD986CC")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x17000098")]
		public bool UseSpherecast
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0xD98730", Offset = "0xD98730", VA = "0xD98730")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046C")]
			[Address(RVA = "0xD98738", Offset = "0xD98738", VA = "0xD98738")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0xD987B4", Offset = "0xD987B4", VA = "0xD987B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046E")]
			[Address(RVA = "0xD987BC", Offset = "0xD987BC", VA = "0xD987BC")]
			set
			{
			}
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xD98818", Offset = "0xD98818", VA = "0xD98818")]
		private void Start()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xD98AB8", Offset = "0xD98AB8", VA = "0xD98AB8")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xD98AC8", Offset = "0xD98AC8", VA = "0xD98AC8")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xD98AD8", Offset = "0xD98AD8", VA = "0xD98AD8")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xD98AE0", Offset = "0xD98AE0", VA = "0xD98AE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xD98AE4", Offset = "0xD98AE4", VA = "0xD98AE4")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xD98B18", Offset = "0xD98B18", VA = "0xD98B18")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xD98B4C", Offset = "0xD98B4C", VA = "0xD98B4C")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xD98B80", Offset = "0xD98B80", VA = "0xD98B80")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xD98BB4", Offset = "0xD98BB4", VA = "0xD98BB4")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xD98BE8", Offset = "0xD98BE8", VA = "0xD98BE8")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xD98C1C", Offset = "0xD98C1C", VA = "0xD98C1C")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xD98C7C", Offset = "0xD98C7C", VA = "0xD98C7C")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xD98CDC", Offset = "0xD98CDC", VA = "0xD98CDC")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xD98CE4", Offset = "0xD98CE4", VA = "0xD98CE4")]
		private void Start()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xD98CE8", Offset = "0xD98CE8", VA = "0xD98CE8")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xD98CAC", Offset = "0xD98CAC", VA = "0xD98CAC")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xD98D1C", Offset = "0xD98D1C", VA = "0xD98D1C")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x20000D9")]
		[CompilerGenerated]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x1700009A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000489")]
				[Address(RVA = "0xD9939C", Offset = "0xD9939C", VA = "0xD9939C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600048B")]
				[Address(RVA = "0xD993E4", Offset = "0xD993E4", VA = "0xD993E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0xD99114", Offset = "0xD99114", VA = "0xD99114")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0xD991DC", Offset = "0xD991DC", VA = "0xD991DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0xD991E0", Offset = "0xD991E0", VA = "0xD991E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0xD993A4", Offset = "0xD993A4", VA = "0xD993A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000431")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x4000432")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xD98D24", Offset = "0xD98D24", VA = "0xD98D24")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xD98DC4", Offset = "0xD98DC4", VA = "0xD98DC4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xD990D4", Offset = "0xD990D4", VA = "0xD990D4")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xD99060", Offset = "0xD99060", VA = "0xD99060")]
		[IteratorStateMachine(typeof(<LerpToHMD>d__13))]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xD9913C", Offset = "0xD9913C", VA = "0xD9913C")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x20000DB")]
		public enum SelectionState
		{
			[Token(Token = "0x4000448")]
			Off,
			[Token(Token = "0x4000449")]
			Selected,
			[Token(Token = "0x400044A")]
			Highlighted
		}

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x1700009C")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0xD993EC", Offset = "0xD993EC", VA = "0xD993EC")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0xD993F4", Offset = "0xD993F4", VA = "0xD993F4")]
			set
			{
			}
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xD99548", Offset = "0xD99548", VA = "0xD99548")]
		private void Awake()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xD9970C", Offset = "0xD9970C", VA = "0xD9970C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xD99468", Offset = "0xD99468", VA = "0xD99468")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xD997D4", Offset = "0xD997D4", VA = "0xD997D4")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x20000DD")]
		public enum SegmentType
		{
			[Token(Token = "0x4000459")]
			Straight,
			[Token(Token = "0x400045A")]
			LeftTurn,
			[Token(Token = "0x400045B")]
			RightTurn,
			[Token(Token = "0x400045C")]
			Switch
		}

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x4000451")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x4000452")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x1700009D")]
		public float StartDistance
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0xD99844", Offset = "0xD99844", VA = "0xD99844")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000494")]
			[Address(RVA = "0xD9984C", Offset = "0xD9984C", VA = "0xD9984C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public float GridSize
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0xD99854", Offset = "0xD99854", VA = "0xD99854")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000496")]
			[Address(RVA = "0xD9985C", Offset = "0xD9985C", VA = "0xD9985C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public int SubDivCount
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0xD99864", Offset = "0xD99864", VA = "0xD99864")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000498")]
			[Address(RVA = "0xD9986C", Offset = "0xD9986C", VA = "0xD9986C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public SegmentType Type
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xD99874", Offset = "0xD99874", VA = "0xD99874")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x170000A1")]
		public Pose EndPose
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0xD9987C", Offset = "0xD9987C", VA = "0xD9987C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		public float Radius
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0xD99C50", Offset = "0xD99C50", VA = "0xD99C50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A3")]
		public float SegmentLength
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0xD998D8", Offset = "0xD998D8", VA = "0xD998D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xD99C60", Offset = "0xD99C60", VA = "0xD99C60")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xD99C78", Offset = "0xD99C78", VA = "0xD99C78")]
		private void Awake()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xD99918", Offset = "0xD99918", VA = "0xD99918")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xD99C7C", Offset = "0xD99C7C", VA = "0xD99C7C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xD99C80", Offset = "0xD99C80", VA = "0xD99C80")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xD99CDC", Offset = "0xD99CDC", VA = "0xD99CDC")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xD9A610", Offset = "0xD9A610", VA = "0xD9A610")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xD9A894", Offset = "0xD9A894", VA = "0xD9A894")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x170000A4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004B3")]
				[Address(RVA = "0xD9B32C", Offset = "0xD9B32C", VA = "0xD9B32C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004B5")]
				[Address(RVA = "0xD9B374", Offset = "0xD9B374", VA = "0xD9B374", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xD9B160", Offset = "0xD9B160", VA = "0xD9B160")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0xD9B1B0", Offset = "0xD9B1B0", VA = "0xD9B1B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0xD9B1B4", Offset = "0xD9B1B4", VA = "0xD9B1B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0xD9B334", Offset = "0xD9B334", VA = "0xD9B334", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400045D")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x400045E")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xD9A968", Offset = "0xD9A968", VA = "0xD9A968")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xD9AA20", Offset = "0xD9AA20", VA = "0xD9AA20")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xD9AAB0", Offset = "0xD9AAB0", VA = "0xD9AAB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xD9ABF8", Offset = "0xD9ABF8", VA = "0xD9ABF8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xD9AD84", Offset = "0xD9AD84", VA = "0xD9AD84")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xD9AE94", Offset = "0xD9AE94", VA = "0xD9AE94")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xD9B098", Offset = "0xD9B098", VA = "0xD9B098")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xD9AFA4", Offset = "0xD9AFA4", VA = "0xD9AFA4")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xD9AFB8", Offset = "0xD9AFB8", VA = "0xD9AFB8")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xD9B0EC", Offset = "0xD9B0EC", VA = "0xD9B0EC")]
		[IteratorStateMachine(typeof(<ResetPosition>d__26))]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xD9B188", Offset = "0xD9B188", VA = "0xD9B188")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x170000A6")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xD9B37C", Offset = "0xD9B37C", VA = "0xD9B37C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xD9B38C", Offset = "0xD9B38C", VA = "0xD9B38C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xD9B394", Offset = "0xD9B394", VA = "0xD9B394", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xD9B6C4", Offset = "0xD9B6C4", VA = "0xD9B6C4")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x4000476")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x4000477")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x170000A7")]
		public float Distance
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0xD9B7C8", Offset = "0xD9B7C8", VA = "0xD9B7C8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xD9B7D0", Offset = "0xD9B7D0", VA = "0xD9B7D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public float Scale
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xD9B7D8", Offset = "0xD9B7D8", VA = "0xD9B7D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0xD9B7E0", Offset = "0xD9B7E0", VA = "0xD9B7E0")]
			set
			{
			}
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xD9B390", Offset = "0xD9B390", VA = "0xD9B390", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xD9B7E8", Offset = "0xD9B7E8", VA = "0xD9B7E8")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xD9B3D0", Offset = "0xD9B3D0", VA = "0xD9B3D0")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xD9B5E0", Offset = "0xD9B5E0", VA = "0xD9B5E0")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x60004C2")]
		public abstract void UpdatePosition();

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xD9B724", Offset = "0xD9B724", VA = "0xD9B724")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004D1")]
				[Address(RVA = "0xD9C010", Offset = "0xD9C010", VA = "0xD9C010", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004D3")]
				[Address(RVA = "0xD9C058", Offset = "0xD9C058", VA = "0xD9C058", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0xD9BDC8", Offset = "0xD9BDC8", VA = "0xD9BDC8")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0xD9BDF0", Offset = "0xD9BDF0", VA = "0xD9BDF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0xD9BDF4", Offset = "0xD9BDF4", VA = "0xD9BDF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0xD9C018", Offset = "0xD9C018", VA = "0xD9C018", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xD9B8A8", Offset = "0xD9B8A8", VA = "0xD9B8A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xD9B904", Offset = "0xD9B904", VA = "0xD9B904")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xD9B9DC", Offset = "0xD9B9DC", VA = "0xD9B9DC")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xD9BB30", Offset = "0xD9BB30", VA = "0xD9BB30")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xD9BA38", Offset = "0xD9BA38", VA = "0xD9BA38")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xD9BBF8", Offset = "0xD9BBF8", VA = "0xD9BBF8")]
		[IteratorStateMachine(typeof(<AnimateCrossing>d__15))]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xD9BC7C", Offset = "0xD9BC7C", VA = "0xD9BC7C")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xD9BD14", Offset = "0xD9BD14", VA = "0xD9BD14")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xD9BD70", Offset = "0xD9BD70", VA = "0xD9BD70")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x20000E5")]
		private enum EngineSoundState
		{
			[Token(Token = "0x40004B4")]
			Start,
			[Token(Token = "0x40004B5")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x40004B6")]
			Stop
		}

		[Token(Token = "0x20000E6")]
		[CompilerGenerated]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x170000AB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004E6")]
				[Address(RVA = "0xD9CB54", Offset = "0xD9CB54", VA = "0xD9CB54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004E8")]
				[Address(RVA = "0xD9CB9C", Offset = "0xD9CB9C", VA = "0xD9CB9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0xD9C368", Offset = "0xD9C368", VA = "0xD9C368")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xD9C92C", Offset = "0xD9C92C", VA = "0xD9C92C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xD9C930", Offset = "0xD9C930", VA = "0xD9C930", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0xD9CB5C", Offset = "0xD9CB5C", VA = "0xD9CB5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000496")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x4000497")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x4000498")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x4000499")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0.2f, 2.7f)]
		[SerializeField]
		protected float _initialSpeed;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xD9C060", Offset = "0xD9C060", VA = "0xD9C060")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xD9C1C0", Offset = "0xD9C1C0", VA = "0xD9C1C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xD9C1CC", Offset = "0xD9C1CC", VA = "0xD9C1CC", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xD9C30C", Offset = "0xD9C30C", VA = "0xD9C30C")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xD9C138", Offset = "0xD9C138", VA = "0xD9C138")]
		[IteratorStateMachine(typeof(<StartStopTrain>d__34))]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xD9C390", Offset = "0xD9C390", VA = "0xD9C390")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xD9C2AC", Offset = "0xD9C2AC", VA = "0xD9C2AC")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xD9C5A4", Offset = "0xD9C5A4", VA = "0xD9C5A4")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xD9C6F8", Offset = "0xD9C6F8", VA = "0xD9C6F8")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xD9C604", Offset = "0xD9C604", VA = "0xD9C604")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xD9C758", Offset = "0xD9C758", VA = "0xD9C758")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xD9C794", Offset = "0xD9C794", VA = "0xD9C794")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xD9C810", Offset = "0xD9C810", VA = "0xD9C810")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xD9C8BC", Offset = "0xD9C8BC", VA = "0xD9C8BC")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xD9C8CC", Offset = "0xD9C8CC", VA = "0xD9C8CC")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x170000AD")]
		public float TrackLength
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0xD9CBA4", Offset = "0xD9CBA4", VA = "0xD9CBA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0xD9CBAC", Offset = "0xD9CBAC", VA = "0xD9CBAC")]
			private set
			{
			}
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xD9CBB4", Offset = "0xD9CBB4", VA = "0xD9CBB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xD9CD84", Offset = "0xD9CD84", VA = "0xD9CD84")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xD9CBB8", Offset = "0xD9CBB8", VA = "0xD9CBB8")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xD9CE38", Offset = "0xD9CE38", VA = "0xD9CE38")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xD9CF18", Offset = "0xD9CF18", VA = "0xD9CF18")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class Pose
	{
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xD9CF34", Offset = "0xD9CF34", VA = "0xD9CF34")]
		public Pose()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xD9CFCC", Offset = "0xD9CFCC", VA = "0xD9CFCC")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x170000AF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004FE")]
				[Address(RVA = "0xD9D5C0", Offset = "0xD9D5C0", VA = "0xD9D5C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000500")]
				[Address(RVA = "0xD9D608", Offset = "0xD9D608", VA = "0xD9D608", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004FB")]
			[Address(RVA = "0xD9D2A8", Offset = "0xD9D2A8", VA = "0xD9D2A8")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60004FC")]
			[Address(RVA = "0xD9D41C", Offset = "0xD9D41C", VA = "0xD9D41C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004FD")]
			[Address(RVA = "0xD9D420", Offset = "0xD9D420", VA = "0xD9D420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004FF")]
			[Address(RVA = "0xD9D5C8", Offset = "0xD9D5C8", VA = "0xD9D5C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000EB")]
		[CompilerGenerated]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x170000B1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000504")]
				[Address(RVA = "0xD9D6E4", Offset = "0xD9D6E4", VA = "0xD9D6E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000506")]
				[Address(RVA = "0xD9D72C", Offset = "0xD9D72C", VA = "0xD9D72C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000501")]
			[Address(RVA = "0xD9D384", Offset = "0xD9D384", VA = "0xD9D384")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0xD9D610", Offset = "0xD9D610", VA = "0xD9D610", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0xD9D614", Offset = "0xD9D614", VA = "0xD9D614", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0xD9D6EC", Offset = "0xD9D6EC", VA = "0xD9D6EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004C9")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x170000AE")]
		public bool IsMoving
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xD9D030", Offset = "0xD9D030", VA = "0xD9D030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xD9D038", Offset = "0xD9D038", VA = "0xD9D038")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xD9D044", Offset = "0xD9D044", VA = "0xD9D044")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xD9D074", Offset = "0xD9D074", VA = "0xD9D074")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xD9D1B4", Offset = "0xD9D1B4", VA = "0xD9D1B4")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xD9D224", Offset = "0xD9D224", VA = "0xD9D224")]
		[IteratorStateMachine(typeof(<LerpToSpeed>d__17))]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xD9D2D0", Offset = "0xD9D2D0", VA = "0xD9D2D0")]
		[IteratorStateMachine(typeof(<PlaySoundDelayed>d__18))]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xD9D3AC", Offset = "0xD9D3AC", VA = "0xD9D3AC")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xD9D414", Offset = "0xD9D414", VA = "0xD9D414")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xD9D734", Offset = "0xD9D734", VA = "0xD9D734")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xD9D7A8", Offset = "0xD9D7A8", VA = "0xD9D7A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xD9D870", Offset = "0xD9D870", VA = "0xD9D870")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xD9D980", Offset = "0xD9D980", VA = "0xD9D980")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xD9D9FC", Offset = "0xD9D9FC", VA = "0xD9D9FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xD9DAC8", Offset = "0xD9DAC8", VA = "0xD9DAC8")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x40004E6")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x40004E7")]
		EUDT_OverlayQuad,
		[Token(Token = "0x40004E8")]
		EUDT_None,
		[Token(Token = "0x40004E9")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x20000EE")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x170000B3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000520")]
				[Address(RVA = "0xD9F158", Offset = "0xD9F158", VA = "0xD9F158", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000522")]
				[Address(RVA = "0xD9F1A0", Offset = "0xD9F1A0", VA = "0xD9F1A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600051D")]
			[Address(RVA = "0xD9E7E8", Offset = "0xD9E7E8", VA = "0xD9E7E8")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x600051E")]
			[Address(RVA = "0xD9EF5C", Offset = "0xD9EF5C", VA = "0xD9EF5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600051F")]
			[Address(RVA = "0xD9EF60", Offset = "0xD9EF60", VA = "0xD9EF60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0xD9F160", Offset = "0xD9F160", VA = "0xD9F160", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x40004EB")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x40004EC")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x40004ED")]
		private const string noneID = "NoneID";

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("App vs Compositor Comparison Settings")]
		public GameObject mainCamera;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Level Loading Sim Settings")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xD9DAD8", Offset = "0xD9DAD8", VA = "0xD9DAD8")]
		private void Start()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xD9E318", Offset = "0xD9E318", VA = "0xD9E318")]
		private void Update()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xD9E440", Offset = "0xD9E440", VA = "0xD9E440")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xD9E570", Offset = "0xD9E570", VA = "0xD9E570")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xD9E6A0", Offset = "0xD9E6A0", VA = "0xD9E6A0")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xD9E420", Offset = "0xD9E420", VA = "0xD9E420")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xD9E774", Offset = "0xD9E774", VA = "0xD9E774")]
		[IteratorStateMachine(typeof(<WaitforOVROverlay>d__30))]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xD9E810", Offset = "0xD9E810", VA = "0xD9E810")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xD9DF48", Offset = "0xD9DF48", VA = "0xD9DF48")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xD9E958", Offset = "0xD9E958", VA = "0xD9E958")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xD9E838", Offset = "0xD9E838", VA = "0xD9E838")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xD9ECE0", Offset = "0xD9ECE0", VA = "0xD9ECE0")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xD9EDCC", Offset = "0xD9EDCC", VA = "0xD9EDCC")]
		public OVROverlaySample()
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x20000F0")]
	[RequireComponent(typeof(OVRGrabber))]
	public class Hand : MonoBehaviour
	{
		[Token(Token = "0x4000505")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x4000506")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x4000507")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x4000508")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x4000509")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x400050A")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x400050B")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x400050C")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x400050D")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x400050E")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x400050F")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xD9F1A8", Offset = "0xD9F1A8", VA = "0xD9F1A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xD9F200", Offset = "0xD9F200", VA = "0xD9F200")]
		private void Start()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xD9F650", Offset = "0xD9F650", VA = "0xD9F650")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xD9F73C", Offset = "0xD9F73C", VA = "0xD9F73C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xD9F8A0", Offset = "0xD9F8A0", VA = "0xD9F8A0")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xD9FB70", Offset = "0xD9FB70", VA = "0xD9FB70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xD9FC54", Offset = "0xD9FC54", VA = "0xD9FC54")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xD9FE04", Offset = "0xD9FE04", VA = "0xD9FE04")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xD9F92C", Offset = "0xD9F92C", VA = "0xD9F92C")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xD9F980", Offset = "0xD9F980", VA = "0xD9F980")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xD9F510", Offset = "0xD9F510", VA = "0xD9F510")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xD9FF28", Offset = "0xD9FF28", VA = "0xD9FF28")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public enum HandPoseId
	{
		[Token(Token = "0x4000524")]
		Default,
		[Token(Token = "0x4000525")]
		Generic,
		[Token(Token = "0x4000526")]
		PingPongBall,
		[Token(Token = "0x4000527")]
		Controller
	}
	[Token(Token = "0x20000F3")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x170000B5")]
		public bool AllowPointing
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0xD9FFE0", Offset = "0xD9FFE0", VA = "0xD9FFE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B6")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0xD9FFE8", Offset = "0xD9FFE8", VA = "0xD9FFE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B7")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0xD9FFF0", Offset = "0xD9FFF0", VA = "0xD9FFF0")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xD9FFF8", Offset = "0xD9FFF8", VA = "0xD9FFF8")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xDA0000", Offset = "0xDA0000", VA = "0xDA0000")]
		private void Update()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xDA02CC", Offset = "0xDA02CC", VA = "0xDA02CC")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xDA031C", Offset = "0xDA031C", VA = "0xDA031C")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xDA0354", Offset = "0xDA0354", VA = "0xDA0354")]
		public TouchController()
		{
		}
	}
}
namespace FlyingWormConsole3
{
	[Token(Token = "0x20000F5")]
	public class ConsoleProRemoteServer : MonoBehaviour
	{
		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool useNATPunch;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int port;

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xDA035C", Offset = "0xDA035C", VA = "0xDA035C")]
		public void Awake()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xDA03C4", Offset = "0xDA03C4", VA = "0xDA03C4")]
		public ConsoleProRemoteServer()
		{
		}
	}
}
namespace FlyingWormConsole3.LiteNetLib
{
	[Token(Token = "0x20000F6")]
	internal abstract class BaseChannel
	{
		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly NetPeer Peer;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly Queue<NetPacket> OutgoingQueue;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _isAddedToPeerChannelSendQueue;

		[Token(Token = "0x170000B8")]
		public int PacketsInQueue
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0xDA03D4", Offset = "0xDA03D4", VA = "0xDA03D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xDA041C", Offset = "0xDA041C", VA = "0xDA041C")]
		protected BaseChannel(NetPeer peer)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xDA04C4", Offset = "0xDA04C4", VA = "0xDA04C4")]
		public void AddToQueue(NetPacket packet)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xDA05C8", Offset = "0xDA05C8", VA = "0xDA05C8")]
		protected void AddToPeerChannelSendQueue()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xDA0704", Offset = "0xDA0704", VA = "0xDA0704")]
		public bool SendAndCheckQueue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000541")]
		protected abstract bool SendNextPackets();

		[Token(Token = "0x6000542")]
		public abstract bool ProcessPacket(NetPacket packet);
	}
	[Token(Token = "0x20000F7")]
	internal enum ConnectionRequestResult
	{
		[Token(Token = "0x4000534")]
		None,
		[Token(Token = "0x4000535")]
		Accept,
		[Token(Token = "0x4000536")]
		Reject,
		[Token(Token = "0x4000537")]
		RejectForce
	}
	[Token(Token = "0x20000F8")]
	public class ConnectionRequest
	{
		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly NetManager _listener;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _used;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly NetDataReader Data;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal long ConnectionTime;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal byte ConnectionNumber;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly IPEndPoint RemoteEndPoint;

		[Token(Token = "0x170000B9")]
		internal ConnectionRequestResult Result
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0xDA0744", Offset = "0xDA0744", VA = "0xDA0744")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Token(Token = "0x6000544")]
			[Address(RVA = "0xDA074C", Offset = "0xDA074C", VA = "0xDA074C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xDA0754", Offset = "0xDA0754", VA = "0xDA0754")]
		private bool TryActivate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xDA077C", Offset = "0xDA077C", VA = "0xDA077C")]
		internal void UpdateRequest(NetConnectRequestPacket connRequest)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xDA07AC", Offset = "0xDA07AC", VA = "0xDA07AC")]
		internal ConnectionRequest(long connectionId, byte connectionNumber, NetDataReader netDataReader, IPEndPoint endPoint, NetManager listener)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xDA0824", Offset = "0xDA0824", VA = "0xDA0824")]
		public NetPeer AcceptIfKey(string key)
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xDA0E38", Offset = "0xDA0E38", VA = "0xDA0E38")]
		public NetPeer Accept()
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xDA0E9C", Offset = "0xDA0E9C", VA = "0xDA0E9C")]
		public void Reject(byte[] rejectData, int start, int length, bool force)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xDA0F24", Offset = "0xDA0F24", VA = "0xDA0F24")]
		public void Reject(byte[] rejectData, int start, int length)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xDA0F2C", Offset = "0xDA0F2C", VA = "0xDA0F2C")]
		public void RejectForce(byte[] rejectData, int start, int length)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xDA0F34", Offset = "0xDA0F34", VA = "0xDA0F34")]
		public void RejectForce()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xDA0F48", Offset = "0xDA0F48", VA = "0xDA0F48")]
		public void RejectForce(byte[] rejectData)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xDA0F68", Offset = "0xDA0F68", VA = "0xDA0F68")]
		public void RejectForce(NetDataWriter rejectData)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xDA0F90", Offset = "0xDA0F90", VA = "0xDA0F90")]
		public void Reject()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xDA0FA4", Offset = "0xDA0FA4", VA = "0xDA0FA4")]
		public void Reject(byte[] rejectData)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xDA0FC4", Offset = "0xDA0FC4", VA = "0xDA0FC4")]
		public void Reject(NetDataWriter rejectData)
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public enum UnconnectedMessageType
	{
		[Token(Token = "0x4000540")]
		BasicMessage,
		[Token(Token = "0x4000541")]
		Broadcast
	}
	[Token(Token = "0x20000FA")]
	public enum DisconnectReason
	{
		[Token(Token = "0x4000543")]
		ConnectionFailed,
		[Token(Token = "0x4000544")]
		Timeout,
		[Token(Token = "0x4000545")]
		HostUnreachable,
		[Token(Token = "0x4000546")]
		NetworkUnreachable,
		[Token(Token = "0x4000547")]
		RemoteConnectionClose,
		[Token(Token = "0x4000548")]
		DisconnectPeerCalled,
		[Token(Token = "0x4000549")]
		ConnectionRejected,
		[Token(Token = "0x400054A")]
		InvalidProtocol,
		[Token(Token = "0x400054B")]
		UnknownHost,
		[Token(Token = "0x400054C")]
		Reconnect,
		[Token(Token = "0x400054D")]
		PeerToPeerConnection
	}
	[Token(Token = "0x20000FB")]
	public struct DisconnectInfo
	{
		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DisconnectReason Reason;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SocketError SocketErrorCode;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public NetPacketReader AdditionalData;
	}
	[Token(Token = "0x20000FC")]
	public interface INetEventListener
	{
		[Token(Token = "0x6000553")]
		void OnPeerConnected(NetPeer peer);

		[Token(Token = "0x6000554")]
		void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo);

		[Token(Token = "0x6000555")]
		void OnNetworkError(IPEndPoint endPoint, SocketError socketError);

		[Token(Token = "0x6000556")]
		void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod);

		[Token(Token = "0x6000557")]
		void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType);

		[Token(Token = "0x6000558")]
		void OnNetworkLatencyUpdate(NetPeer peer, int latency);

		[Token(Token = "0x6000559")]
		void OnConnectionRequest(ConnectionRequest request);
	}
	[Token(Token = "0x20000FD")]
	public interface IDeliveryEventListener
	{
		[Token(Token = "0x600055A")]
		void OnMessageDelivered(NetPeer peer, object userData);
	}
	[Token(Token = "0x20000FE")]
	public interface INtpEventListener
	{
		[Token(Token = "0x600055B")]
		void OnNtpResponse(NtpPacket packet);
	}
	[Token(Token = "0x20000FF")]
	public class EventBasedNetListener : INetEventListener, IDeliveryEventListener, INtpEventListener
	{
		[Token(Token = "0x2000100")]
		public delegate void OnPeerConnected(NetPeer peer);

		[Token(Token = "0x2000101")]
		public delegate void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo);

		[Token(Token = "0x2000102")]
		public delegate void OnNetworkError(IPEndPoint endPoint, SocketError socketError);

		[Token(Token = "0x2000103")]
		public delegate void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod);

		[Token(Token = "0x2000104")]
		public delegate void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType);

		[Token(Token = "0x2000105")]
		public delegate void OnNetworkLatencyUpdate(NetPeer peer, int latency);

		[Token(Token = "0x2000106")]
		public delegate void OnConnectionRequest(ConnectionRequest request);

		[Token(Token = "0x2000107")]
		public delegate void OnDeliveryEvent(NetPeer peer, object userData);

		[Token(Token = "0x2000108")]
		public delegate void OnNtpResponseEvent(NtpPacket packet);

		[Token(Token = "0x14000013")]
		public event OnPeerConnected PeerConnectedEvent
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0xDA0FEC", Offset = "0xDA0FEC", VA = "0xDA0FEC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600055D")]
			[Address(RVA = "0xDA1088", Offset = "0xDA1088", VA = "0xDA1088")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event OnPeerDisconnected PeerDisconnectedEvent
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xDA1124", Offset = "0xDA1124", VA = "0xDA1124")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600055F")]
			[Address(RVA = "0xDA11C0", Offset = "0xDA11C0", VA = "0xDA11C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event OnNetworkError NetworkErrorEvent
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xDA125C", Offset = "0xDA125C", VA = "0xDA125C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000561")]
			[Address(RVA = "0xDA12F8", Offset = "0xDA12F8", VA = "0xDA12F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event OnNetworkReceive NetworkReceiveEvent
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0xDA1394", Offset = "0xDA1394", VA = "0xDA1394")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xDA1430", Offset = "0xDA1430", VA = "0xDA1430")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event OnNetworkReceiveUnconnected NetworkReceiveUnconnectedEvent
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xDA14CC", Offset = "0xDA14CC", VA = "0xDA14CC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xDA1568", Offset = "0xDA1568", VA = "0xDA1568")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event OnNetworkLatencyUpdate NetworkLatencyUpdateEvent
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0xDA1604", Offset = "0xDA1604", VA = "0xDA1604")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000567")]
			[Address(RVA = "0xDA16A0", Offset = "0xDA16A0", VA = "0xDA16A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public event OnConnectionRequest ConnectionRequestEvent
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xDA173C", Offset = "0xDA173C", VA = "0xDA173C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000569")]
			[Address(RVA = "0xDA17D8", Offset = "0xDA17D8", VA = "0xDA17D8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public event OnDeliveryEvent DeliveryEvent
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0xDA1874", Offset = "0xDA1874", VA = "0xDA1874")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600056B")]
			[Address(RVA = "0xDA1910", Offset = "0xDA1910", VA = "0xDA1910")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001B")]
		public event OnNtpResponseEvent NtpResponseEvent
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0xDA19AC", Offset = "0xDA19AC", VA = "0xDA19AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600056D")]
			[Address(RVA = "0xDA1A48", Offset = "0xDA1A48", VA = "0xDA1A48")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xDA1AE4", Offset = "0xDA1AE4", VA = "0xDA1AE4")]
		public void ClearPeerConnectedEvent()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xDA1AF0", Offset = "0xDA1AF0", VA = "0xDA1AF0")]
		public void ClearPeerDisconnectedEvent()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xDA1AFC", Offset = "0xDA1AFC", VA = "0xDA1AFC")]
		public void ClearNetworkErrorEvent()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xDA1B08", Offset = "0xDA1B08", VA = "0xDA1B08")]
		public void ClearNetworkReceiveEvent()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xDA1B14", Offset = "0xDA1B14", VA = "0xDA1B14")]
		public void ClearNetworkReceiveUnconnectedEvent()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xDA1B20", Offset = "0xDA1B20", VA = "0xDA1B20")]
		public void ClearNetworkLatencyUpdateEvent()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xDA1B2C", Offset = "0xDA1B2C", VA = "0xDA1B2C")]
		public void ClearConnectionRequestEvent()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xDA1B38", Offset = "0xDA1B38", VA = "0xDA1B38")]
		public void ClearDeliveryEvent()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xDA1B44", Offset = "0xDA1B44", VA = "0xDA1B44")]
		public void ClearNtpResponseEvent()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xDA1B50", Offset = "0xDA1B50", VA = "0xDA1B50", Slot = "4")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnPeerConnected(NetPeer peer)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xDA1B6C", Offset = "0xDA1B6C", VA = "0xDA1B6C", Slot = "5")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xDA1B88", Offset = "0xDA1B88", VA = "0xDA1B88", Slot = "6")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnNetworkError(IPEndPoint endPoint, SocketError socketErrorCode)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xDA1BA4", Offset = "0xDA1BA4", VA = "0xDA1BA4", Slot = "7")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xDA1BC0", Offset = "0xDA1BC0", VA = "0xDA1BC0", Slot = "8")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xDA1BDC", Offset = "0xDA1BDC", VA = "0xDA1BDC", Slot = "9")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnNetworkLatencyUpdate(NetPeer peer, int latency)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xDA1BF8", Offset = "0xDA1BF8", VA = "0xDA1BF8", Slot = "10")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnConnectionRequest(ConnectionRequest request)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xDA1C14", Offset = "0xDA1C14", VA = "0xDA1C14", Slot = "11")]
		private void FlyingWormConsole3.LiteNetLib.IDeliveryEventListener.OnMessageDelivered(NetPeer peer, object userData)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xDA1C30", Offset = "0xDA1C30", VA = "0xDA1C30", Slot = "12")]
		private void FlyingWormConsole3.LiteNetLib.INtpEventListener.OnNtpResponse(NtpPacket packet)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xDA1C4C", Offset = "0xDA1C4C", VA = "0xDA1C4C")]
		public EventBasedNetListener()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public enum NatAddressType
	{
		[Token(Token = "0x400055B")]
		Internal,
		[Token(Token = "0x400055C")]
		External
	}
	[Token(Token = "0x200010A")]
	public interface INatPunchListener
	{
		[Token(Token = "0x60005A5")]
		void OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token);

		[Token(Token = "0x60005A6")]
		void OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token);
	}
	[Token(Token = "0x200010B")]
	public class EventBasedNatPunchListener : INatPunchListener
	{
		[Token(Token = "0x200010C")]
		public delegate void OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token);

		[Token(Token = "0x200010D")]
		public delegate void OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token);

		[Token(Token = "0x1400001C")]
		public event OnNatIntroductionRequest NatIntroductionRequest
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xDA2C1C", Offset = "0xDA2C1C", VA = "0xDA2C1C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xDA2CB8", Offset = "0xDA2CB8", VA = "0xDA2CB8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001D")]
		public event OnNatIntroductionSuccess NatIntroductionSuccess
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xDA2D54", Offset = "0xDA2D54", VA = "0xDA2D54")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xDA2DF0", Offset = "0xDA2DF0", VA = "0xDA2DF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xDA2E8C", Offset = "0xDA2E8C", VA = "0xDA2E8C", Slot = "4")]
		private void FlyingWormConsole3.LiteNetLib.INatPunchListener.OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xDA2EA8", Offset = "0xDA2EA8", VA = "0xDA2EA8", Slot = "5")]
		private void FlyingWormConsole3.LiteNetLib.INatPunchListener.OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xDA2EC4", Offset = "0xDA2EC4", VA = "0xDA2EC4")]
		public EventBasedNatPunchListener()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public sealed class NatPunchModule
	{
		[Token(Token = "0x200010F")]
		private struct RequestEventData
		{
			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IPEndPoint LocalEndPoint;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public IPEndPoint RemoteEndPoint;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Token;
		}

		[Token(Token = "0x2000110")]
		private struct SuccessEventData
		{
			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IPEndPoint TargetEndPoint;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public NatAddressType Type;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Token;
		}

		[Token(Token = "0x2000111")]
		private class NatIntroduceRequestPacket
		{
			[Token(Token = "0x170000BA")]
			public IPEndPoint Internal
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0xDA44C4", Offset = "0xDA44C4", VA = "0xDA44C4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60005C2")]
				[Address(RVA = "0xDA44CC", Offset = "0xDA44CC", VA = "0xDA44CC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000BB")]
			public string Token
			{
				[Token(Token = "0x60005C3")]
				[Address(RVA = "0xDA44D4", Offset = "0xDA44D4", VA = "0xDA44D4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60005C4")]
				[Address(RVA = "0xDA44DC", Offset = "0xDA44DC", VA = "0xDA44DC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xDA3CC8", Offset = "0xDA3CC8", VA = "0xDA3CC8")]
			public NatIntroduceRequestPacket()
			{
			}
		}

		[Token(Token = "0x2000112")]
		private class NatIntroduceResponsePacket
		{
			[Token(Token = "0x170000BC")]
			public IPEndPoint Internal
			{
				[Token(Token = "0x60005C6")]
				[Address(RVA = "0xDA44E4", Offset = "0xDA44E4", VA = "0xDA44E4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60005C7")]
				[Address(RVA = "0xDA44EC", Offset = "0xDA44EC", VA = "0xDA44EC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000BD")]
			public IPEndPoint External
			{
				[Token(Token = "0x60005C8")]
				[Address(RVA = "0xDA44F4", Offset = "0xDA44F4", VA = "0xDA44F4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60005C9")]
				[Address(RVA = "0xDA44FC", Offset = "0xDA44FC", VA = "0xDA44FC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000BE")]
			public string Token
			{
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0xDA4504", Offset = "0xDA4504", VA = "0xDA4504")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60005CB")]
				[Address(RVA = "0xDA450C", Offset = "0xDA450C", VA = "0xDA450C")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0xDA3788", Offset = "0xDA3788", VA = "0xDA3788")]
			public NatIntroduceResponsePacket()
			{
			}
		}

		[Token(Token = "0x2000113")]
		private class NatPunchPacket
		{
			[Token(Token = "0x170000BF")]
			public string Token
			{
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0xDA4514", Offset = "0xDA4514", VA = "0xDA4514")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60005CE")]
				[Address(RVA = "0xDA451C", Offset = "0xDA451C", VA = "0xDA451C")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			public bool IsExternal
			{
				[Token(Token = "0x60005CF")]
				[Address(RVA = "0xDA4524", Offset = "0xDA4524", VA = "0xDA4524")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005D0")]
				[Address(RVA = "0xDA452C", Offset = "0xDA452C", VA = "0xDA452C")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xDA3FA4", Offset = "0xDA3FA4", VA = "0xDA3FA4")]
			public NatPunchPacket()
			{
			}
		}

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly NetSocket _socket;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Queue<RequestEventData> _requestEvents;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Queue<SuccessEventData> _successEvents;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly NetDataReader _cacheReader;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly NetDataWriter _cacheWriter;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly NetPacketProcessor _netPacketProcessor;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private INatPunchListener _natPunchListener;

		[Token(Token = "0x4000566")]
		public const int MaxTokenLength = 256;

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xDA3250", Offset = "0xDA3250", VA = "0xDA3250")]
		internal NatPunchModule(NetSocket socket)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xDA355C", Offset = "0xDA355C", VA = "0xDA355C")]
		internal void ProcessMessage(IPEndPoint senderEndPoint, NetPacket packet)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xDA3668", Offset = "0xDA3668", VA = "0xDA3668")]
		public void Init(INatPunchListener listener)
		{
		}

		[Token(Token = "0x60005B9")]
		private void Send<T>(T packet, IPEndPoint target) where T : class, new()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xDA3670", Offset = "0xDA3670", VA = "0xDA3670")]
		public void NatIntroduce(IPEndPoint hostInternal, IPEndPoint hostExternal, IPEndPoint clientInternal, IPEndPoint clientExternal, string additionalInfo)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xDA3790", Offset = "0xDA3790", VA = "0xDA3790")]
		public void PollEvents()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xDA3AFC", Offset = "0xDA3AFC", VA = "0xDA3AFC")]
		public void SendNatIntroduceRequest(string host, int port, string additionalInfo)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xDA3B84", Offset = "0xDA3B84", VA = "0xDA3B84")]
		public void SendNatIntroduceRequest(IPEndPoint masterServerEndPoint, string additionalInfo)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xDA3CD0", Offset = "0xDA3CD0", VA = "0xDA3CD0")]
		private void OnNatIntroductionRequest(NatIntroduceRequestPacket req, IPEndPoint senderEndPoint)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xDA3E5C", Offset = "0xDA3E5C", VA = "0xDA3E5C")]
		private void OnNatIntroductionResponse(NatIntroduceResponsePacket req)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xDA434C", Offset = "0xDA434C", VA = "0xDA434C")]
		private void OnNatPunch(NatPunchPacket req, IPEndPoint senderEndPoint)
		{
		}
	}
	[Token(Token = "0x2000114")]
	public enum DeliveryMethod : byte
	{
		[Token(Token = "0x4000575")]
		Unreliable = 4,
		[Token(Token = "0x4000576")]
		ReliableUnordered = 0,
		[Token(Token = "0x4000577")]
		Sequenced = 1,
		[Token(Token = "0x4000578")]
		ReliableOrdered = 2,
		[Token(Token = "0x4000579")]
		ReliableSequenced = 3
	}
	[Token(Token = "0x2000115")]
	public static class NetConstants
	{
		[Token(Token = "0x400057A")]
		public const int DefaultWindowSize = 64;

		[Token(Token = "0x400057B")]
		public const int SocketBufferSize = 1048576;

		[Token(Token = "0x400057C")]
		public const int SocketTTL = 255;

		[Token(Token = "0x400057D")]
		public const int HeaderSize = 1;

		[Token(Token = "0x400057E")]
		public const int ChanneledHeaderSize = 4;

		[Token(Token = "0x400057F")]
		public const int FragmentHeaderSize = 6;

		[Token(Token = "0x4000580")]
		public const int FragmentedHeaderTotalSize = 10;

		[Token(Token = "0x4000581")]
		public const ushort MaxSequence = 32768;

		[Token(Token = "0x4000582")]
		public const ushort HalfMaxSequence = 16384;

		[Token(Token = "0x4000583")]
		internal const int ProtocolId = 11;

		[Token(Token = "0x4000584")]
		internal const int MaxUdpHeaderSize = 68;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly int[] PossibleMtu;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly int MaxPacketSize;

		[Token(Token = "0x4000587")]
		public const byte MaxConnectionNumber = 4;

		[Token(Token = "0x4000588")]
		public const int PacketPoolSize = 1000;
	}
	[Token(Token = "0x2000116")]
	public class InvalidPacketException : ArgumentException
	{
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xDA4610", Offset = "0xDA4610", VA = "0xDA4610")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xDA4618", Offset = "0xDA4618", VA = "0xDA4618")]
		public TooBigPacketException(string message)
		{
		}
	}
	[Token(Token = "0x2000118")]
	public enum NetLogLevel
	{
		[Token(Token = "0x400058A")]
		Warning,
		[Token(Token = "0x400058B")]
		Error,
		[Token(Token = "0x400058C")]
		Trace,
		[Token(Token = "0x400058D")]
		Info
	}
	[Token(Token = "0x2000119")]
	public interface INetLogger
	{
		[Token(Token = "0x60005D5")]
		void WriteNet(NetLogLevel level, string str, params object[] args);
	}
	[Token(Token = "0x200011A")]
	public static class NetDebug
	{
		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static INetLogger Logger;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly object DebugLogLock;

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xDA4620", Offset = "0xDA4620", VA = "0xDA4620")]
		private static void WriteLogic(NetLogLevel logLevel, string str, params object[] args)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xDA4840", Offset = "0xDA4840", VA = "0xDA4840")]
		[Conditional("DEBUG_MESSAGES")]
		internal static void Write(string str, params object[] args)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xDA48A8", Offset = "0xDA48A8", VA = "0xDA48A8")]
		[Conditional("DEBUG_MESSAGES")]
		internal static void Write(NetLogLevel level, string str, params object[] args)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xDA4914", Offset = "0xDA4914", VA = "0xDA4914")]
		[Conditional("DEBUG_MESSAGES")]
		[Conditional("DEBUG")]
		internal static void WriteForce(string str, params object[] args)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xDA497C", Offset = "0xDA497C", VA = "0xDA497C")]
		[Conditional("DEBUG_MESSAGES")]
		[Conditional("DEBUG")]
		internal static void WriteForce(NetLogLevel level, string str, params object[] args)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xDA09D0", Offset = "0xDA09D0", VA = "0xDA09D0")]
		internal static void WriteError(string str, params object[] args)
		{
		}
	}
	[Token(Token = "0x200011B")]
	public enum IPv6Mode
	{
		[Token(Token = "0x4000591")]
		Disabled,
		[Token(Token = "0x4000592")]
		SeparateSocket,
		[Token(Token = "0x4000593")]
		DualMode
	}
	[Token(Token = "0x200011C")]
	public sealed class NetPacketReader : NetDataReader
	{
		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private NetPacket _packet;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly NetManager _manager;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly NetEvent _evt;

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xDA4A80", Offset = "0xDA4A80", VA = "0xDA4A80")]
		internal NetPacketReader(NetManager manager, NetEvent evt)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xDA4AC4", Offset = "0xDA4AC4", VA = "0xDA4AC4")]
		internal void SetSource(NetPacket packet, int headerSize)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xDA4B08", Offset = "0xDA4B08", VA = "0xDA4B08")]
		internal void RecycleInternal()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xDA4DFC", Offset = "0xDA4DFC", VA = "0xDA4DFC")]
		public void Recycle()
		{
		}
	}
	[Token(Token = "0x200011D")]
	internal sealed class NetEvent
	{
		[Token(Token = "0x200011E")]
		public enum EType
		{
			[Token(Token = "0x40005A3")]
			Connect,
			[Token(Token = "0x40005A4")]
			Disconnect,
			[Token(Token = "0x40005A5")]
			Receive,
			[Token(Token = "0x40005A6")]
			ReceiveUnconnected,
			[Token(Token = "0x40005A7")]
			Error,
			[Token(Token = "0x40005A8")]
			ConnectionLatencyUpdated,
			[Token(Token = "0x40005A9")]
			Broadcast,
			[Token(Token = "0x40005AA")]
			ConnectionRequest,
			[Token(Token = "0x40005AB")]
			MessageDelivered
		}

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NetEvent Next;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EType Type;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NetPeer Peer;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IPEndPoint RemoteEndPoint;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public object UserData;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int Latency;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public SocketError ErrorCode;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DisconnectReason DisconnectReason;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ConnectionRequest ConnectionRequest;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DeliveryMethod DeliveryMethod;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly NetPacketReader DataReader;

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xDA4E68", Offset = "0xDA4E68", VA = "0xDA4E68")]
		public NetEvent(NetManager manager)
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class NetManager : IEnumerable<NetPeer>, IEnumerable
	{
		[Token(Token = "0x2000120")]
		private class IPEndPointComparer : IEqualityComparer<IPEndPoint>
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0xDAC2C4", Offset = "0xDAC2C4", VA = "0xDAC2C4", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0xDAC320", Offset = "0xDAC320", VA = "0xDAC320", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0xDA5BCC", Offset = "0xDA5BCC", VA = "0xDA5BCC")]
			public IPEndPointComparer()
			{
			}
		}

		[Token(Token = "0x2000121")]
		public struct NetPeerEnumerator : IEnumerator<NetPeer>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly NetPeer _initialPeer;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private NetPeer _p;

			[Token(Token = "0x170000C8")]
			public NetPeer Current
			{
				[Token(Token = "0x600063C")]
				[Address(RVA = "0xDAC3D0", Offset = "0xDAC3D0", VA = "0xDAC3D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600063D")]
				[Address(RVA = "0xDAC3D8", Offset = "0xDAC3D8", VA = "0xDAC3D8", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0xDAC188", Offset = "0xDAC188", VA = "0xDAC188")]
			public NetPeerEnumerator(NetPeer p)
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0xDAC340", Offset = "0xDAC340", VA = "0xDAC340", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0xDAC344", Offset = "0xDAC344", VA = "0xDAC344", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0xDAC390", Offset = "0xDAC390", VA = "0xDAC390", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly NetSocket _socket;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Thread _logicThread;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _manualMode;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly AutoResetEvent _updateTriggerEvent;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Queue<NetEvent> _netEventsQueue;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private NetEvent _netEventPoolHead;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly INetEventListener _netEventListener;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly IDeliveryEventListener _deliveryEventListener;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly INtpEventListener _ntpEventListener;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Dictionary<IPEndPoint, NetPeer> _peersDict;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly Dictionary<IPEndPoint, ConnectionRequest> _requestsDict;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly Dictionary<IPEndPoint, NtpRequest> _ntpRequests;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly ReaderWriterLockSlim _peersLock;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private NetPeer _headPeer;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _connectedPeersCount;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<NetPeer> _connectedPeerListCache;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NetPeer[] _peersArray;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly PacketLayerBase _extraPacketLayer;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastPeerId;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Queue<int> _peerIds;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private byte _channelsCount;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly object _eventLock;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal readonly NetPacketPool NetPacketPool;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool UnconnectedMessagesEnabled;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool NatPunchEnabled;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public int UpdateTime;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int PingInterval;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int DisconnectTimeout;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool SimulatePacketLoss;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		public bool SimulateLatency;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public int SimulationPacketLossChance;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public int SimulationMinLatency;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public int SimulationMaxLatency;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public bool UnsyncedEvents;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		public bool UnsyncedReceiveEvent;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		public bool UnsyncedDeliveryEvent;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
		public bool BroadcastReceiveEnabled;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public int ReconnectDelay;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int MaxConnectAttempts;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool ReuseAddress;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public readonly NetStatistics Statistics;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public bool EnableStatistics;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public readonly NatPunchModule NatPunchModule;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool AutoRecycle;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public IPv6Mode IPv6Enabled;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int MtuOverride;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public bool UseSafeMtu;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
		public bool DisconnectOnUnreachable;

		[Token(Token = "0x170000C1")]
		public bool IsRunning
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0xDA4EEC", Offset = "0xDA4EEC", VA = "0xDA4EEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		public int LocalPort
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0xDA4F10", Offset = "0xDA4F10", VA = "0xDA4F10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C3")]
		public NetPeer FirstPeer
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0xDA4F2C", Offset = "0xDA4F2C", VA = "0xDA4F2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public byte ChannelsCount
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xDA4F44", Offset = "0xDA4F44", VA = "0xDA4F44")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xDA4F4C", Offset = "0xDA4F4C", VA = "0xDA4F4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public List<NetPeer> ConnectedPeerList
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xDA4FB8", Offset = "0xDA4FB8", VA = "0xDA4FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public int ConnectedPeersCount
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xDA5130", Offset = "0xDA5130", VA = "0xDA5130")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C7")]
		public int ExtraPacketSizeForLayer
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xDA5148", Offset = "0xDA5148", VA = "0xDA5148")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xDA5100", Offset = "0xDA5100", VA = "0xDA5100")]
		public NetPeer GetPeerById(int id)
		{
			return null;
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xDA5160", Offset = "0xDA5160", VA = "0xDA5160")]
		private bool TryGetPeer(IPEndPoint endPoint, out NetPeer peer)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xDA51F8", Offset = "0xDA51F8", VA = "0xDA51F8")]
		private void AddPeer(NetPeer peer)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xDA5374", Offset = "0xDA5374", VA = "0xDA5374")]
		private void RemovePeer(NetPeer peer)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xDA53BC", Offset = "0xDA53BC", VA = "0xDA53BC")]
		private void RemovePeerInternal(NetPeer peer)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xDA55B4", Offset = "0xDA55B4", VA = "0xDA55B4")]
		public NetManager(INetEventListener listener, [Optional] PacketLayerBase extraPacketLayer)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xDA5BD4", Offset = "0xDA5BD4", VA = "0xDA5BD4")]
		internal void ConnectionLatencyUpdated(NetPeer fromPeer, int latency)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xDA5F48", Offset = "0xDA5F48", VA = "0xDA5F48")]
		internal void MessageDelivered(NetPeer fromPeer, object userData)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xDA5F94", Offset = "0xDA5F94", VA = "0xDA5F94")]
		internal int SendRawAndRecycle(NetPacket packet, IPEndPoint remoteEndPoint)
		{
			return default(int);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xDA6214", Offset = "0xDA6214", VA = "0xDA6214")]
		internal int SendRaw(NetPacket packet, IPEndPoint remoteEndPoint)
		{
			return default(int);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xDA5FE8", Offset = "0xDA5FE8", VA = "0xDA5FE8")]
		internal int SendRaw(byte[] message, int start, int length, IPEndPoint remoteEndPoint)
		{
			return default(int);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xDA6464", Offset = "0xDA6464", VA = "0xDA6464")]
		internal void DisconnectPeerForce(NetPeer peer, DisconnectReason reason, SocketError socketErrorCode, NetPacket eventData)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xDA64AC", Offset = "0xDA64AC", VA = "0xDA64AC")]
		private void DisconnectPeer(NetPeer peer, DisconnectReason reason, SocketError socketErrorCode, bool force, byte[] data, int start, int count, NetPacket eventData)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xDA5C14", Offset = "0xDA5C14", VA = "0xDA5C14")]
		private void CreateEvent(NetEvent.EType type, [Optional] NetPeer peer, [Optional] IPEndPoint remoteEndPoint, SocketError errorCode = SocketError.Success, int latency = 0, DisconnectReason disconnectReason = DisconnectReason.ConnectionFailed, [Optional] ConnectionRequest connectionRequest, DeliveryMethod deliveryMethod = DeliveryMethod.Unreliable, [Optional] NetPacket readerSource, [Optional] object userData)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xDA68D8", Offset = "0xDA68D8", VA = "0xDA68D8")]
		private void ProcessEvent(NetEvent evt)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xDA4CDC", Offset = "0xDA4CDC", VA = "0xDA4CDC")]
		internal void RecycleEvent(NetEvent evt)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xDA6DDC", Offset = "0xDA6DDC", VA = "0xDA6DDC")]
		private void UpdateLogic()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xDA79B0", Offset = "0xDA79B0", VA = "0xDA79B0")]
		[Conditional("DEBUG")]
		private void ProcessDelayedPackets()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xDA75F0", Offset = "0xDA75F0", VA = "0xDA75F0")]
		private void ProcessNtpRequests(int elapsedMilliseconds)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xDA79B4", Offset = "0xDA79B4", VA = "0xDA79B4")]
		public void ManualUpdate(int elapsedMilliseconds)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xDA7A38", Offset = "0xDA7A38", VA = "0xDA7A38")]
		public void ManualReceive()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xDA7AA0", Offset = "0xDA7AA0", VA = "0xDA7AA0")]
		internal void OnMessageReceived(NetPacket packet, SocketError errorCode, IPEndPoint remoteEndPoint)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xDA0A38", Offset = "0xDA0A38", VA = "0xDA0A38")]
		internal NetPeer OnConnectionSolved(ConnectionRequest request, byte[] rejectData, int start, int length)
		{
			return null;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xDA8590", Offset = "0xDA8590", VA = "0xDA8590")]
		private int GetNextPeerId()
		{
			return default(int);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xDA8B5C", Offset = "0xDA8B5C", VA = "0xDA8B5C")]
		private void ProcessConnectRequest(IPEndPoint remoteEndPoint, NetPeer netPeer, NetConnectRequestPacket connRequest)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xDA7D48", Offset = "0xDA7D48", VA = "0xDA7D48")]
		private void DataReceived(NetPacket packet, IPEndPoint remoteEndPoint)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xDA9B18", Offset = "0xDA9B18", VA = "0xDA9B18")]
		internal void CreateReceiveEvent(NetPacket packet, DeliveryMethod method, int headerSize, NetPeer fromPeer)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xDA9D98", Offset = "0xDA9D98", VA = "0xDA9D98")]
		public void SendToAll(NetDataWriter writer, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xDA9DD0", Offset = "0xDA9DD0", VA = "0xDA9DD0")]
		public void SendToAll(byte[] data, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xDA9DC4", Offset = "0xDA9DC4", VA = "0xDA9DC4")]
		public void SendToAll(byte[] data, int start, int length, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xDA9F04", Offset = "0xDA9F04", VA = "0xDA9F04")]
		public void SendToAll(NetDataWriter writer, byte channelNumber, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xDA9F30", Offset = "0xDA9F30", VA = "0xDA9F30")]
		public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xDA9DF4", Offset = "0xDA9DF4", VA = "0xDA9DF4")]
		public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xDA9F5C", Offset = "0xDA9F5C", VA = "0xDA9F5C")]
		public void SendToAll(NetDataWriter writer, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xDAA0B0", Offset = "0xDAA0B0", VA = "0xDAA0B0")]
		public void SendToAll(byte[] data, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xDAA0D8", Offset = "0xDAA0D8", VA = "0xDAA0D8")]
		public void SendToAll(byte[] data, int start, int length, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xDAA0E8", Offset = "0xDAA0E8", VA = "0xDAA0E8")]
		public void SendToAll(NetDataWriter writer, byte channelNumber, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xDAA118", Offset = "0xDAA118", VA = "0xDAA118")]
		public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xDA9F8C", Offset = "0xDA9F8C", VA = "0xDA9F8C")]
		public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xDAA140", Offset = "0xDAA140", VA = "0xDAA140")]
		public bool Start()
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xDAA1BC", Offset = "0xDAA1BC", VA = "0xDAA1BC")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xDAA890", Offset = "0xDAA890", VA = "0xDAA890")]
		public bool Start(string addressIPv4, string addressIPv6, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xDAA148", Offset = "0xDAA148", VA = "0xDAA148")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xDAA928", Offset = "0xDAA928", VA = "0xDAA928")]
		public bool StartInManualMode(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xDAA958", Offset = "0xDAA958", VA = "0xDAA958")]
		public bool StartInManualMode(string addressIPv4, string addressIPv6, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xDAA9F0", Offset = "0xDAA9F0", VA = "0xDAA9F0")]
		public bool StartInManualMode(int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xDAAA64", Offset = "0xDAAA64", VA = "0xDAAA64")]
		public bool SendUnconnectedMessage(byte[] message, IPEndPoint remoteEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xDAAAD8", Offset = "0xDAAAD8", VA = "0xDAAAD8")]
		public bool SendUnconnectedMessage(NetDataWriter writer, IPEndPoint remoteEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xDAAA84", Offset = "0xDAAA84", VA = "0xDAAA84")]
		public bool SendUnconnectedMessage(byte[] message, int start, int length, IPEndPoint remoteEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xDAABBC", Offset = "0xDAABBC", VA = "0xDAABBC")]
		public bool SendBroadcast(NetDataWriter writer, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xDAAD58", Offset = "0xDAAD58", VA = "0xDAAD58")]
		public bool SendBroadcast(byte[] data, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xDAABE4", Offset = "0xDAABE4", VA = "0xDAABE4")]
		public bool SendBroadcast(byte[] data, int start, int length, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xDAB134", Offset = "0xDAB134", VA = "0xDAB134")]
		public void TriggerUpdate()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xDAB150", Offset = "0xDAB150", VA = "0xDAB150")]
		public void PollEvents()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xDAB364", Offset = "0xDAB364", VA = "0xDAB364")]
		public NetPeer Connect(string address, int port, string key)
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xDAB3A0", Offset = "0xDAB3A0", VA = "0xDAB3A0")]
		public NetPeer Connect(string address, int port, NetDataWriter connectionData)
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xDAB778", Offset = "0xDAB778", VA = "0xDAB778")]
		public NetPeer Connect(IPEndPoint target, string key)
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xDAB4EC", Offset = "0xDAB4EC", VA = "0xDAB4EC")]
		public NetPeer Connect(IPEndPoint target, NetDataWriter connectionData)
		{
			return null;
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xDAB8CC", Offset = "0xDAB8CC", VA = "0xDAB8CC")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xDAB8D4", Offset = "0xDAB8D4", VA = "0xDAB8D4")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xDABCCC", Offset = "0xDABCCC", VA = "0xDABCCC")]
		public int GetPeersCount(ConnectionState peerState)
		{
			return default(int);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xDA4FD8", Offset = "0xDA4FD8", VA = "0xDA4FD8")]
		public void GetPeersNonAlloc(List<NetPeer> peers, ConnectionState peerState)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xDABD40", Offset = "0xDABD40", VA = "0xDABD40")]
		public void DisconnectAll()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xDABD50", Offset = "0xDABD50", VA = "0xDABD50")]
		public void DisconnectAll(byte[] data, int start, int count)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xDABDE0", Offset = "0xDABDE0", VA = "0xDABDE0")]
		public void DisconnectPeerForce(NetPeer peer)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xDABE14", Offset = "0xDABE14", VA = "0xDABE14")]
		public void DisconnectPeer(NetPeer peer)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xDABE7C", Offset = "0xDABE7C", VA = "0xDABE7C")]
		public void DisconnectPeer(NetPeer peer, byte[] data)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xDABEB8", Offset = "0xDABEB8", VA = "0xDABEB8")]
		public void DisconnectPeer(NetPeer peer, NetDataWriter writer)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xDABE48", Offset = "0xDABE48", VA = "0xDABE48")]
		public void DisconnectPeer(NetPeer peer, byte[] data, int start, int count)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xDABEF4", Offset = "0xDABEF4", VA = "0xDABEF4")]
		public void CreateNtpRequest(IPEndPoint endPoint)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xDABF8C", Offset = "0xDABF8C", VA = "0xDABF8C")]
		public void CreateNtpRequest(string ntpServerAddress, int port)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xDAC064", Offset = "0xDAC064", VA = "0xDAC064")]
		public void CreateNtpRequest(string ntpServerAddress)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xDAC138", Offset = "0xDAC138", VA = "0xDAC138")]
		public NetPeerEnumerator GetEnumerator()
		{
			return default(NetPeerEnumerator);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xDAC1AC", Offset = "0xDAC1AC", VA = "0xDAC1AC", Slot = "4")]
		private IEnumerator<NetPeer> System.Collections.Generic.IEnumerable<FlyingWormConsole3.LiteNetLib.NetPeer>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xDAC238", Offset = "0xDAC238", VA = "0xDAC238", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000122")]
	internal enum PacketProperty : byte
	{
		[Token(Token = "0x40005DF")]
		Unreliable,
		[Token(Token = "0x40005E0")]
		Channeled,
		[Token(Token = "0x40005E1")]
		Ack,
		[Token(Token = "0x40005E2")]
		Ping,
		[Token(Token = "0x40005E3")]
		Pong,
		[Token(Token = "0x40005E4")]
		ConnectRequest,
		[Token(Token = "0x40005E5")]
		ConnectAccept,
		[Token(Token = "0x40005E6")]
		Disconnect,
		[Token(Token = "0x40005E7")]
		UnconnectedMessage,
		[Token(Token = "0x40005E8")]
		MtuCheck,
		[Token(Token = "0x40005E9")]
		MtuOk,
		[Token(Token = "0x40005EA")]
		Broadcast,
		[Token(Token = "0x40005EB")]
		Merged,
		[Token(Token = "0x40005EC")]
		ShutdownOk,
		[Token(Token = "0x40005ED")]
		PeerNotFound,
		[Token(Token = "0x40005EE")]
		InvalidProtocol,
		[Token(Token = "0x40005EF")]
		NatMessage,
		[Token(Token = "0x40005F0")]
		Empty
	}
	[Token(Token = "0x2000123")]
	internal sealed class NetPacket
	{
		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int LastProperty;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] HeaderSizes;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] RawData;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Size;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public object UserData;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NetPacket Next;

		[Token(Token = "0x170000CA")]
		public PacketProperty Property
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0xDA9078", Offset = "0xDA9078", VA = "0xDA9078")]
			get
			{
				return default(PacketProperty);
			}
			[Token(Token = "0x6000640")]
			[Address(RVA = "0xDAADF4", Offset = "0xDAADF4", VA = "0xDAADF4")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public byte ConnectionNumber
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0xDAC5B8", Offset = "0xDAC5B8", VA = "0xDAC5B8")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6000642")]
			[Address(RVA = "0xDA855C", Offset = "0xDA855C", VA = "0xDA855C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public ushort Sequence
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0xDAC5E4", Offset = "0xDAC5E4", VA = "0xDAC5E4")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x6000644")]
			[Address(RVA = "0xDAC644", Offset = "0xDAC644", VA = "0xDAC644")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public bool IsFragmented
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0xDAC658", Offset = "0xDAC658", VA = "0xDAC658")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		public byte ChannelId
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0xDAC6B8", Offset = "0xDAC6B8", VA = "0xDAC6B8")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6000648")]
			[Address(RVA = "0xDAC6E4", Offset = "0xDAC6E4", VA = "0xDAC6E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public ushort FragmentId
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0xDAC710", Offset = "0xDAC710", VA = "0xDAC710")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x600064A")]
			[Address(RVA = "0xDAC770", Offset = "0xDAC770", VA = "0xDAC770")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public ushort FragmentPart
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0xDAC784", Offset = "0xDAC784", VA = "0xDAC784")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x600064C")]
			[Address(RVA = "0xDAC7E4", Offset = "0xDAC7E4", VA = "0xDAC7E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public ushort FragmentsTotal
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0xDAC7F8", Offset = "0xDAC7F8", VA = "0xDAC7F8")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0xDAC858", Offset = "0xDAC858", VA = "0xDAC858")]
			set
			{
			}
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xDAC3E0", Offset = "0xDAC3E0", VA = "0xDAC3E0")]
		static NetPacket()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xDAC688", Offset = "0xDAC688", VA = "0xDAC688")]
		public void MarkFragmented()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xDAC86C", Offset = "0xDAC86C", VA = "0xDAC86C")]
		public NetPacket(int size)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xDAC8E4", Offset = "0xDAC8E4", VA = "0xDAC8E4")]
		public NetPacket(PacketProperty property, int size)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xDAAD78", Offset = "0xDAAD78", VA = "0xDAAD78")]
		public static int GetHeaderSize(PacketProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xDA6844", Offset = "0xDA6844", VA = "0xDA6844")]
		public int GetHeaderSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xDA8F84", Offset = "0xDA8F84", VA = "0xDA8F84")]
		public bool Verify()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000124")]
	internal sealed class NetConnectRequestPacket
	{
		[Token(Token = "0x40005F7")]
		public const int HeaderSize = 14;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly long ConnectionTime;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly byte ConnectionNumber;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly byte[] TargetAddress;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly NetDataReader Data;

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xDAC9A0", Offset = "0xDAC9A0", VA = "0xDAC9A0")]
		private NetConnectRequestPacket(long connectionTime, byte connectionNumber, byte[] targetAddress, NetDataReader data)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xDA90A4", Offset = "0xDA90A4", VA = "0xDA90A4")]
		public static int GetProtocolId(NetPacket packet)
		{
			return default(int);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xDA9194", Offset = "0xDA9194", VA = "0xDA9194")]
		public static NetConnectRequestPacket FromData(NetPacket packet)
		{
			return null;
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xDAC9FC", Offset = "0xDAC9FC", VA = "0xDAC9FC")]
		public static NetPacket Make(NetDataWriter connectData, SocketAddress addressBytes, long connectId)
		{
			return null;
		}
	}
	[Token(Token = "0x2000125")]
	internal sealed class NetConnectAcceptPacket
	{
		[Token(Token = "0x40005FC")]
		public const int Size = 11;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly long ConnectionId;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly byte ConnectionNumber;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public readonly bool IsReusedPeer;

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xDACB48", Offset = "0xDACB48", VA = "0xDACB48")]
		private NetConnectAcceptPacket(long connectionId, byte connectionNumber, bool isReusedPeer)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xDA940C", Offset = "0xDA940C", VA = "0xDA940C")]
		public static NetConnectAcceptPacket FromData(NetPacket packet)
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xDACB88", Offset = "0xDACB88", VA = "0xDACB88")]
		public static NetPacket Make(long connectId, byte connectNum, bool reusedPeer)
		{
			return null;
		}
	}
	[Token(Token = "0x2000126")]
	internal sealed class NetPacketPool
	{
		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NetPacket _head;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _count;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly object _lock;

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xDAAB00", Offset = "0xDAAB00", VA = "0xDAAB00")]
		public NetPacket GetWithData(PacketProperty property, byte[] data, int start, int length)
		{
			return null;
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xDA84D0", Offset = "0xDA84D0", VA = "0xDA84D0")]
		public NetPacket GetWithProperty(PacketProperty property, int size)
		{
			return null;
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xDA910C", Offset = "0xDA910C", VA = "0xDA910C")]
		public NetPacket GetWithProperty(PacketProperty property)
		{
			return null;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xDA623C", Offset = "0xDA623C", VA = "0xDA623C")]
		public NetPacket GetPacket(int size)
		{
			return null;
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xDA4B68", Offset = "0xDA4B68", VA = "0xDA4B68")]
		public void Recycle(NetPacket packet)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xDA5B50", Offset = "0xDA5B50", VA = "0xDA5B50")]
		public NetPacketPool()
		{
		}
	}
	[Token(Token = "0x2000127")]
	[Flags]
	public enum ConnectionState : byte
	{
		[Token(Token = "0x4000604")]
		Outgoing = 2,
		[Token(Token = "0x4000605")]
		Connected = 4,
		[Token(Token = "0x4000606")]
		ShutdownRequested = 8,
		[Token(Token = "0x4000607")]
		Disconnected = 0x10,
		[Token(Token = "0x4000608")]
		Any = 0xE
	}
	[Token(Token = "0x2000128")]
	internal enum ConnectRequestResult
	{
		[Token(Token = "0x400060A")]
		None,
		[Token(Token = "0x400060B")]
		P2PLose,
		[Token(Token = "0x400060C")]
		Reconnection,
		[Token(Token = "0x400060D")]
		NewConnection
	}
	[Token(Token = "0x2000129")]
	internal enum DisconnectResult
	{
		[Token(Token = "0x400060F")]
		None,
		[Token(Token = "0x4000610")]
		Reject,
		[Token(Token = "0x4000611")]
		Disconnect
	}
	[Token(Token = "0x200012A")]
	internal enum ShutdownResult
	{
		[Token(Token = "0x4000613")]
		None,
		[Token(Token = "0x4000614")]
		Success,
		[Token(Token = "0x4000615")]
		WasConnected
	}
	[Token(Token = "0x200012B")]
	public class NetPeer
	{
		[Token(Token = "0x200012C")]
		private class IncomingFragments
		{
			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NetPacket[] Fragments;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int ReceivedCount;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int TotalSize;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte ChannelId;

			[Token(Token = "0x6000690")]
			[Address(RVA = "0xDADD94", Offset = "0xDADD94", VA = "0xDADD94")]
			public IncomingFragments()
			{
			}
		}

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _rtt;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _avgRtt;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _rttCount;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private double _resendDelay;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _pingSendTimer;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _rttResetTimer;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Stopwatch _pingTimer;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _timeSinceLastPacket;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private long _remoteDelta;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly NetPacketPool _packetPool;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly object _shutdownLock;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal NetPeer NextPeer;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal NetPeer PrevPeer;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly Queue<NetPacket> _unreliableChannel;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly Queue<BaseChannel> _channelSendQueue;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly BaseChannel[] _channels;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _mtu;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int _mtuIdx;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool _finishMtu;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _mtuCheckTimer;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _mtuCheckAttempts;

		[Token(Token = "0x400062B")]
		private const int MtuCheckDelay = 1000;

		[Token(Token = "0x400062C")]
		private const int MaxMtuCheckAttempts = 4;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly object _mtuMutex;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _fragmentId;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Dictionary<ushort, IncomingFragments> _holdedFragments;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly Dictionary<ushort, ushort> _deliveredFragments;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly NetPacket _mergeData;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int _mergePos;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _mergeCount;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int _connectAttempts;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _connectTimer;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private long _connectTime;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private byte _connectNum;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private ConnectionState _connectionState;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NetPacket _shutdownPacket;

		[Token(Token = "0x400063A")]
		private const int ShutdownDelay = 300;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int _shutdownTimer;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly NetPacket _pingPacket;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly NetPacket _pongPacket;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly NetPacket _connectRequestPacket;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly NetPacket _connectAcceptPacket;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public readonly IPEndPoint EndPoint;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public readonly NetManager NetManager;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public readonly int Id;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public object Tag;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public readonly NetStatistics Statistics;

		[Token(Token = "0x170000D2")]
		internal byte ConnectionNum
		{
			[Token(Token = "0x6000661")]
			[Address(RVA = "0xDACC48", Offset = "0xDACC48", VA = "0xDACC48")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6000662")]
			[Address(RVA = "0xDACC50", Offset = "0xDACC50", VA = "0xDACC50")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public ConnectionState ConnectionState
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0xDACC9C", Offset = "0xDACC9C", VA = "0xDACC9C")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Token(Token = "0x170000D4")]
		internal long ConnectTime
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0xDACCA4", Offset = "0xDACCA4", VA = "0xDACCA4")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000D5")]
		public int Ping
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0xDACCAC", Offset = "0xDACCAC", VA = "0xDACCAC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D6")]
		public int Mtu
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0xDACCC0", Offset = "0xDACCC0", VA = "0xDACCC0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D7")]
		public long RemoteTimeDelta
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0xDACCC8", Offset = "0xDACCC8", VA = "0xDACCC8")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000D8")]
		public DateTime RemoteUtcTime
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0xDACCD0", Offset = "0xDACCD0", VA = "0xDACCD0")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x170000D9")]
		public int TimeSinceLastPacket
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0xDACD60", Offset = "0xDACD60", VA = "0xDACD60")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DA")]
		internal double ResendDelay
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0xDACD68", Offset = "0xDACD68", VA = "0xDACD68")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xDA86C0", Offset = "0xDA86C0", VA = "0xDA86C0")]
		internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xDACD80", Offset = "0xDACD80", VA = "0xDACD80")]
		private void SetMtu(int mtuIdx)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xDACD70", Offset = "0xDACD70", VA = "0xDACD70")]
		private void OverrideMtu(int mtuValue)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xDACE28", Offset = "0xDACE28", VA = "0xDACE28")]
		public int GetPacketsCountInReliableQueue(byte channelNumber, bool ordered)
		{
			return default(int);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xDACED8", Offset = "0xDACED8", VA = "0xDACED8")]
		private BaseChannel CreateChannel(byte idx)
		{
			return null;
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xDAB7AC", Offset = "0xDAB7AC", VA = "0xDAB7AC")]
		internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id, byte connectNum, NetDataWriter connectData)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xDA8AF0", Offset = "0xDA8AF0", VA = "0xDA8AF0")]
		internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id, long connectId, byte connectNum)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xDA8AD4", Offset = "0xDA8AD4", VA = "0xDA8AD4")]
		internal void Reject(long connectionId, byte connectionNumber, byte[] data, int start, int length)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xDA9514", Offset = "0xDA9514", VA = "0xDA9514")]
		internal bool ProcessConnectAccept(NetConnectAcceptPacket packet)
		{
			return default(bool);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xDAD038", Offset = "0xDAD038", VA = "0xDAD038")]
		public int GetMaxSinglePacketSize(DeliveryMethod options)
		{
			return default(int);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xDAD0B0", Offset = "0xDAD0B0", VA = "0xDAD0B0")]
		public void SendWithDeliveryEvent(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xDAD56C", Offset = "0xDAD56C", VA = "0xDAD56C")]
		public void SendWithDeliveryEvent(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xDAD5D0", Offset = "0xDAD5D0", VA = "0xDAD5D0")]
		public void SendWithDeliveryEvent(NetDataWriter dataWriter, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xDAD65C", Offset = "0xDAD65C", VA = "0xDAD65C")]
		public void Send(byte[] data, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xDAD684", Offset = "0xDAD684", VA = "0xDAD684")]
		public void Send(NetDataWriter dataWriter, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xDAD6B4", Offset = "0xDAD6B4", VA = "0xDAD6B4")]
		public void Send(byte[] data, int start, int length, DeliveryMethod options)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xDAD6C4", Offset = "0xDAD6C4", VA = "0xDAD6C4")]
		public void Send(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xDAD6EC", Offset = "0xDAD6EC", VA = "0xDAD6EC")]
		public void Send(NetDataWriter dataWriter, byte channelNumber, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xDA9F54", Offset = "0xDA9F54", VA = "0xDA9F54")]
		public void Send(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xDAD134", Offset = "0xDAD134", VA = "0xDAD134")]
		private void SendInternal(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xDAD71C", Offset = "0xDAD71C", VA = "0xDAD71C")]
		public void Disconnect(byte[] data)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xDAD740", Offset = "0xDAD740", VA = "0xDAD740")]
		public void Disconnect(NetDataWriter writer)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xDAD764", Offset = "0xDAD764", VA = "0xDAD764")]
		public void Disconnect(byte[] data, int start, int count)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xDAD7AC", Offset = "0xDAD7AC", VA = "0xDAD7AC")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xDA9344", Offset = "0xDA9344", VA = "0xDA9344")]
		internal DisconnectResult ProcessDisconnect(NetPacket packet)
		{
			return default(DisconnectResult);
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xDA0608", Offset = "0xDA0608", VA = "0xDA0608")]
		internal void AddToReliableChannelSendQueue(BaseChannel channel)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xDA6564", Offset = "0xDA6564", VA = "0xDA6564")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xDAD7F0", Offset = "0xDAD7F0", VA = "0xDAD7F0")]
		private void UpdateRoundTripTime(int roundTripTime)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xDAD82C", Offset = "0xDAD82C", VA = "0xDAD82C")]
		internal void AddReliablePacket(DeliveryMethod method, NetPacket p)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xDADD9C", Offset = "0xDADD9C", VA = "0xDADD9C")]
		private void ProcessMtuPacket(NetPacket packet)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xDAE1A4", Offset = "0xDAE1A4", VA = "0xDAE1A4")]
		private void UpdateMtuLogic(int deltaTime)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xDA8E40", Offset = "0xDA8E40", VA = "0xDA8E40")]
		internal ConnectRequestResult ProcessConnectRequest(NetConnectRequestPacket connRequest)
		{
			return default(ConnectRequestResult);
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xDA9578", Offset = "0xDA9578", VA = "0xDA9578")]
		internal void ProcessPacket(NetPacket packet)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xDAE410", Offset = "0xDAE410", VA = "0xDAE410")]
		private void SendMerged()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xDAE4B0", Offset = "0xDAE4B0", VA = "0xDAE4B0")]
		internal void SendUserData(NetPacket packet)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xDA708C", Offset = "0xDA708C", VA = "0xDA708C")]
		internal void Update(int deltaTime)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xDAE5D0", Offset = "0xDAE5D0", VA = "0xDAE5D0")]
		internal void RecycleAndDeliver(NetPacket packet)
		{
		}
	}
	[Token(Token = "0x200012D")]
	internal sealed class NetSocket
	{
		[Token(Token = "0x4000649")]
		public const int ReceivePollingTime = 500000;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Socket _udpSocketv4;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Socket _udpSocketv6;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Thread _threadv4;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Thread _threadv6;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IPEndPoint _bufferEndPointv4;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IPEndPoint _bufferEndPointv6;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly NetManager _listener;

		[Token(Token = "0x4000651")]
		private const int SioUdpConnreset = -1744830452;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IPAddress MulticastAddressV6;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly bool IPv6Support;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool IsRunning;

		[Token(Token = "0x170000DB")]
		public int LocalPort
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0xDAE740", Offset = "0xDAE740", VA = "0xDAE740")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0xDAE748", Offset = "0xDAE748", VA = "0xDAE748")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public short Ttl
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0xDAE750", Offset = "0xDAE750", VA = "0xDAE750")]
			get
			{
				return default(short);
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0xDA3FAC", Offset = "0xDA3FAC", VA = "0xDA3FAC")]
			set
			{
			}
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xDAE7F0", Offset = "0xDAE7F0", VA = "0xDAE7F0")]
		static NetSocket()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xDA5B20", Offset = "0xDA5B20", VA = "0xDA5B20")]
		public NetSocket(NetManager listener)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xDAE8C8", Offset = "0xDAE8C8", VA = "0xDAE8C8")]
		private bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xDAE8E0", Offset = "0xDAE8E0", VA = "0xDAE8E0")]
		private bool ProcessError(SocketException ex, EndPoint bufferEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xDA7A60", Offset = "0xDA7A60", VA = "0xDA7A60")]
		public void ManualReceive()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xDAEB3C", Offset = "0xDAEB3C", VA = "0xDAEB3C")]
		private bool ManualReceive(Socket socket, EndPoint bufferEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xDAED78", Offset = "0xDAED78", VA = "0xDAED78")]
		private void ReceiveLogic(object state)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xDAA304", Offset = "0xDAA304", VA = "0xDAA304")]
		public bool Bind(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool reuseAddress, IPv6Mode ipv6Mode, bool manualMode)
		{
			return default(bool);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xDAF07C", Offset = "0xDAF07C", VA = "0xDAF07C")]
		private bool BindSocket(Socket socket, IPEndPoint ep, bool reuseAddress, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xDAAE28", Offset = "0xDAAE28", VA = "0xDAAE28")]
		public bool SendBroadcast(byte[] data, int offset, int size, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xDA3FEC", Offset = "0xDA3FEC", VA = "0xDA3FEC")]
		public int SendTo(byte[] data, int offset, int size, IPEndPoint remoteEndPoint, ref SocketError errorCode)
		{
			return default(int);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xDABBCC", Offset = "0xDABBCC", VA = "0xDABBCC")]
		public void Close(bool suspend)
		{
		}
	}
	[Token(Token = "0x200012E")]
	public sealed class NetStatistics
	{
		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private long _packetsSent;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long _packetsReceived;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private long _bytesSent;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long _bytesReceived;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long _packetLoss;

		[Token(Token = "0x170000DD")]
		public long PacketsSent
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xDAF970", Offset = "0xDAF970", VA = "0xDAF970")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000DE")]
		public long PacketsReceived
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xDAF97C", Offset = "0xDAF97C", VA = "0xDAF97C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000DF")]
		public long BytesSent
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xDAF988", Offset = "0xDAF988", VA = "0xDAF988")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000E0")]
		public long BytesReceived
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xDAF994", Offset = "0xDAF994", VA = "0xDAF994")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000E1")]
		public long PacketLoss
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xDAF9A0", Offset = "0xDAF9A0", VA = "0xDAF9A0")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000E2")]
		public long PacketLossPercent
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xDAF9AC", Offset = "0xDAF9AC", VA = "0xDAF9AC")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xDAF9F8", Offset = "0xDAF9F8", VA = "0xDAF9F8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xDA6494", Offset = "0xDA6494", VA = "0xDA6494")]
		public void IncrementPacketsSent()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xDA8F6C", Offset = "0xDA8F6C", VA = "0xDA8F6C")]
		public void IncrementPacketsReceived()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xDA64A0", Offset = "0xDA64A0", VA = "0xDA64A0")]
		public void AddBytesSent(long bytesSent)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xDA8F78", Offset = "0xDA8F78", VA = "0xDA8F78")]
		public void AddBytesReceived(long bytesReceived)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xDAFA54", Offset = "0xDAFA54", VA = "0xDAFA54")]
		public void IncrementPacketLoss()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xDAFA60", Offset = "0xDAFA60", VA = "0xDAFA60")]
		public void AddPacketLoss(long packetLoss)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xDAFA6C", Offset = "0xDAFA6C", VA = "0xDAFA6C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xDA5BC4", Offset = "0xDA5BC4", VA = "0xDA5BC4")]
		public NetStatistics()
		{
		}
	}
	[Token(Token = "0x200012F")]
	[Flags]
	public enum LocalAddrType
	{
		[Token(Token = "0x400065C")]
		IPv4 = 1,
		[Token(Token = "0x400065D")]
		IPv6 = 2,
		[Token(Token = "0x400065E")]
		All = 3
	}
	[Token(Token = "0x2000130")]
	public static class NetUtils
	{
		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<string> IpList;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xDAFD24", Offset = "0xDAFD24", VA = "0xDAFD24")]
		public static IPEndPoint MakeEndPoint(string hostStr, int port)
		{
			return null;
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xDAFDCC", Offset = "0xDAFDCC", VA = "0xDAFDCC")]
		public static IPAddress ResolveAddress(string hostStr)
		{
			return null;
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xDAFF84", Offset = "0xDAFF84", VA = "0xDAFF84")]
		public static IPAddress ResolveAddress(string hostStr, AddressFamily addressFamily)
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xDB0010", Offset = "0xDB0010", VA = "0xDB0010")]
		public static List<string> GetLocalIpList(LocalAddrType addrType)
		{
			return null;
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xDB00B4", Offset = "0xDB00B4", VA = "0xDB00B4")]
		public static void GetLocalIpList(IList<string> targetList, LocalAddrType addrType)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xDB08D0", Offset = "0xDB08D0", VA = "0xDB08D0")]
		public static string GetLocalIp(LocalAddrType addrType)
		{
			return null;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xDB0AEC", Offset = "0xDB0AEC", VA = "0xDB0AEC")]
		internal static void PrintInterfaceInfos()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xDB0F08", Offset = "0xDB0F08", VA = "0xDB0F08")]
		internal static int RelativeSequenceNumber(int number, int expected)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000131")]
	internal sealed class ReliableChannel : BaseChannel
	{
		[Token(Token = "0x2000132")]
		private struct PendingPacket
		{
			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NetPacket _packet;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private long _timeStamp;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool _isSent;

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xDB2000", Offset = "0xDB2000", VA = "0xDB2000", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xDB1A34", Offset = "0xDB1A34", VA = "0xDB1A34")]
			public void Init(NetPacket packet)
			{
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0xDB1A50", Offset = "0xDB1A50", VA = "0xDB1A50")]
			public void TrySend(long currentTime, NetPeer peer, out bool hasPacket)
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0xDB14DC", Offset = "0xDB14DC", VA = "0xDB14DC")]
			public bool Clear(NetPeer peer)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly NetPacket _outgoingAcks;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly PendingPacket[] _pendingPackets;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly NetPacket[] _receivedPackets;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly bool[] _earlyReceived;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _localSeqence;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _remoteSequence;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _localWindowStart;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _remoteWindowStart;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _mustSendAcks;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private readonly DeliveryMethod _deliveryMethod;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private readonly bool _ordered;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private readonly int _windowSize;

		[Token(Token = "0x400066C")]
		private const int BitsInByte = 8;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly byte _id;

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xDB0FCC", Offset = "0xDB0FCC", VA = "0xDB0FCC")]
		public ReliableChannel(NetPeer peer, bool ordered, byte id)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xDB1190", Offset = "0xDB1190", VA = "0xDB1190")]
		private void ProcessAck(NetPacket packet)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xDB1528", Offset = "0xDB1528", VA = "0xDB1528", Slot = "4")]
		protected override bool SendNextPackets()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xDB1AD4", Offset = "0xDB1AD4", VA = "0xDB1AD4", Slot = "5")]
		public override bool ProcessPacket(NetPacket packet)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000133")]
	internal sealed class SequencedChannel : BaseChannel
	{
		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _localSequence;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ushort _remoteSequence;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private readonly bool _reliable;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NetPacket _lastPacket;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly NetPacket _ackPacket;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _mustSendAck;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private readonly byte _id;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long _lastPacketSendTime;

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xDB206C", Offset = "0xDB206C", VA = "0xDB206C")]
		public SequencedChannel(NetPeer peer, bool reliable, byte id)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xDB213C", Offset = "0xDB213C", VA = "0xDB213C", Slot = "4")]
		protected override bool SendNextPackets()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xDB2494", Offset = "0xDB2494", VA = "0xDB2494", Slot = "5")]
		public override bool ProcessPacket(NetPacket packet)
		{
			return default(bool);
		}
	}
}
namespace FlyingWormConsole3.LiteNetLib.Utils
{
	[Token(Token = "0x2000134")]
	public static class CRC32C
	{
		[Token(Token = "0x4000679")]
		public const int ChecksumSize = 4;

		[Token(Token = "0x400067A")]
		private const uint Poly = 2197175160u;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly uint[] Table;

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xDB269C", Offset = "0xDB269C", VA = "0xDB269C")]
		static CRC32C()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xDB279C", Offset = "0xDB279C", VA = "0xDB279C")]
		public static uint Compute(byte[] input, int offset, int length)
		{
			return default(uint);
		}
	}
	[Token(Token = "0x2000135")]
	public static class FastBitConverter
	{
		[StructLayout(2)]
		[Token(Token = "0x2000136")]
		private struct ConverterHelperDouble
		{
			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong Along;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double Adouble;
		}

		[StructLayout(2)]
		[Token(Token = "0x2000137")]
		private struct ConverterHelperFloat
		{
			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Aint;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float Afloat;
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xDB2BAC", Offset = "0xDB2BAC", VA = "0xDB2BAC")]
		private static void WriteLittleEndian(byte[] buffer, int offset, ulong data)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xDB2C9C", Offset = "0xDB2C9C", VA = "0xDB2C9C")]
		private static void WriteLittleEndian(byte[] buffer, int offset, int data)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xDB2D1C", Offset = "0xDB2D1C", VA = "0xDB2D1C")]
		public static void WriteLittleEndian(byte[] buffer, int offset, short data)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xDB2D64", Offset = "0xDB2D64", VA = "0xDB2D64")]
		public static void GetBytes(byte[] bytes, int startIndex, double value)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xDB2D6C", Offset = "0xDB2D6C", VA = "0xDB2D6C")]
		public static void GetBytes(byte[] bytes, int startIndex, float value)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xDB2D74", Offset = "0xDB2D74", VA = "0xDB2D74")]
		public static void GetBytes(byte[] bytes, int startIndex, short value)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xDB2D78", Offset = "0xDB2D78", VA = "0xDB2D78")]
		public static void GetBytes(byte[] bytes, int startIndex, ushort value)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xDB2D7C", Offset = "0xDB2D7C", VA = "0xDB2D7C")]
		public static void GetBytes(byte[] bytes, int startIndex, int value)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xDB2D80", Offset = "0xDB2D80", VA = "0xDB2D80")]
		public static void GetBytes(byte[] bytes, int startIndex, uint value)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xDB2D84", Offset = "0xDB2D84", VA = "0xDB2D84")]
		public static void GetBytes(byte[] bytes, int startIndex, long value)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xDB2D88", Offset = "0xDB2D88", VA = "0xDB2D88")]
		public static void GetBytes(byte[] bytes, int startIndex, ulong value)
		{
		}
	}
	[Token(Token = "0x2000138")]
	public interface INetSerializable
	{
		[Token(Token = "0x60006D1")]
		void Serialize(NetDataWriter writer);

		[Token(Token = "0x60006D2")]
		void Deserialize(NetDataReader reader);
	}
	[Token(Token = "0x2000139")]
	public class NetDataReader
	{
		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected byte[] _data;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int _position;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected int _dataSize;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _offset;

		[Token(Token = "0x170000E3")]
		public byte[] RawData
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0xDB2D8C", Offset = "0xDB2D8C", VA = "0xDB2D8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		public int RawDataSize
		{
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0xDB2D94", Offset = "0xDB2D94", VA = "0xDB2D94")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E5")]
		public int UserDataOffset
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0xDB2D9C", Offset = "0xDB2D9C", VA = "0xDB2D9C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E6")]
		public int UserDataSize
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xDB2DA4", Offset = "0xDB2DA4", VA = "0xDB2DA4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E7")]
		public bool IsNull
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xDB2DB0", Offset = "0xDB2DB0", VA = "0xDB2DB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E8")]
		public int Position
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xDB2DC0", Offset = "0xDB2DC0", VA = "0xDB2DC0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E9")]
		public bool EndOfData
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0xDB2DC8", Offset = "0xDB2DC8", VA = "0xDB2DC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EA")]
		public int AvailableBytes
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0xDB2DD8", Offset = "0xDB2DD8", VA = "0xDB2DD8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xDB2DE4", Offset = "0xDB2DE4", VA = "0xDB2DE4")]
		public void SkipBytes(int count)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xDB2DF4", Offset = "0xDB2DF4", VA = "0xDB2DF4")]
		public void SetSource(NetDataWriter dataWriter)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xDB2E38", Offset = "0xDB2E38", VA = "0xDB2E38")]
		public void SetSource(byte[] source)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xDB2E7C", Offset = "0xDB2E7C", VA = "0xDB2E7C")]
		public void SetSource(byte[] source, int offset)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xDB2ECC", Offset = "0xDB2ECC", VA = "0xDB2ECC")]
		public void SetSource(byte[] source, int offset, int maxSize)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xDB2F00", Offset = "0xDB2F00", VA = "0xDB2F00")]
		public NetDataReader()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xDB2F08", Offset = "0xDB2F08", VA = "0xDB2F08")]
		public NetDataReader(NetDataWriter writer)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xDB2F34", Offset = "0xDB2F34", VA = "0xDB2F34")]
		public NetDataReader(byte[] source)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xDB2F60", Offset = "0xDB2F60", VA = "0xDB2F60")]
		public NetDataReader(byte[] source, int offset)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xDB2F94", Offset = "0xDB2F94", VA = "0xDB2F94")]
		public NetDataReader(byte[] source, int offset, int maxSize)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xDB2FE0", Offset = "0xDB2FE0", VA = "0xDB2FE0")]
		public IPEndPoint GetNetEndPoint()
		{
			return null;
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xDB31B0", Offset = "0xDB31B0", VA = "0xDB31B0")]
		public byte GetByte()
		{
			return default(byte);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xDB31F0", Offset = "0xDB31F0", VA = "0xDB31F0")]
		public sbyte GetSByte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xDB3230", Offset = "0xDB3230", VA = "0xDB3230")]
		public bool[] GetBoolArray()
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xDB330C", Offset = "0xDB330C", VA = "0xDB330C")]
		public ushort[] GetUShortArray()
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xDB33E4", Offset = "0xDB33E4", VA = "0xDB33E4")]
		public short[] GetShortArray()
		{
			return null;
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xDB34BC", Offset = "0xDB34BC", VA = "0xDB34BC")]
		public long[] GetLongArray()
		{
			return null;
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xDB3594", Offset = "0xDB3594", VA = "0xDB3594")]
		public ulong[] GetULongArray()
		{
			return null;
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xDB366C", Offset = "0xDB366C", VA = "0xDB366C")]
		public int[] GetIntArray()
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xDB3744", Offset = "0xDB3744", VA = "0xDB3744")]
		public uint[] GetUIntArray()
		{
			return null;
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xDB381C", Offset = "0xDB381C", VA = "0xDB381C")]
		public float[] GetFloatArray()
		{
			return null;
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xDB38F4", Offset = "0xDB38F4", VA = "0xDB38F4")]
		public double[] GetDoubleArray()
		{
			return null;
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xDB39CC", Offset = "0xDB39CC", VA = "0xDB39CC")]
		public string[] GetStringArray()
		{
			return null;
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xDB3B9C", Offset = "0xDB3B9C", VA = "0xDB3B9C")]
		public string[] GetStringArray(int maxStringLength)
		{
			return null;
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xDB3CE0", Offset = "0xDB3CE0", VA = "0xDB3CE0")]
		public bool GetBool()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xDB3D28", Offset = "0xDB3D28", VA = "0xDB3D28")]
		public char GetChar()
		{
			return default(char);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xDB3D9C", Offset = "0xDB3D9C", VA = "0xDB3D9C")]
		public ushort GetUShort()
		{
			return default(ushort);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xDB3E10", Offset = "0xDB3E10", VA = "0xDB3E10")]
		public short GetShort()
		{
			return default(short);
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xDB3E84", Offset = "0xDB3E84", VA = "0xDB3E84")]
		public long GetLong()
		{
			return default(long);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xDB3EF8", Offset = "0xDB3EF8", VA = "0xDB3EF8")]
		public ulong GetULong()
		{
			return default(ulong);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xDB313C", Offset = "0xDB313C", VA = "0xDB313C")]
		public int GetInt()
		{
			return default(int);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xDB3F6C", Offset = "0xDB3F6C", VA = "0xDB3F6C")]
		public uint GetUInt()
		{
			return default(uint);
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xDB3FE0", Offset = "0xDB3FE0", VA = "0xDB3FE0")]
		public float GetFloat()
		{
			return default(float);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xDB4054", Offset = "0xDB4054", VA = "0xDB4054")]
		public double GetDouble()
		{
			return default(double);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xDB3058", Offset = "0xDB3058", VA = "0xDB3058")]
		public string GetString(int maxLength)
		{
			return null;
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xDB3B00", Offset = "0xDB3B00", VA = "0xDB3B00")]
		public string GetString()
		{
			return null;
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xDB40C8", Offset = "0xDB40C8", VA = "0xDB40C8")]
		public ArraySegment<byte> GetRemainingBytesSegment()
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x6000700")]
		public T Get<T>() where T : INetSerializable, new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xDB4144", Offset = "0xDB4144", VA = "0xDB4144")]
		public byte[] GetRemainingBytes()
		{
			return null;
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xDB41CC", Offset = "0xDB41CC", VA = "0xDB41CC")]
		public void GetBytes(byte[] destination, int start, int count)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xDB4214", Offset = "0xDB4214", VA = "0xDB4214")]
		public void GetBytes(byte[] destination, int count)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xDB425C", Offset = "0xDB425C", VA = "0xDB425C")]
		public sbyte[] GetSBytesWithLength()
		{
			return null;
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xDB42EC", Offset = "0xDB42EC", VA = "0xDB42EC")]
		public byte[] GetBytesWithLength()
		{
			return null;
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xDB437C", Offset = "0xDB437C", VA = "0xDB437C")]
		public byte PeekByte()
		{
			return default(byte);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xDB43B0", Offset = "0xDB43B0", VA = "0xDB43B0")]
		public sbyte PeekSByte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xDB43E4", Offset = "0xDB43E4", VA = "0xDB43E4")]
		public bool PeekBool()
		{
			return default(bool);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xDB4420", Offset = "0xDB4420", VA = "0xDB4420")]
		public char PeekChar()
		{
			return default(char);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xDB4484", Offset = "0xDB4484", VA = "0xDB4484")]
		public ushort PeekUShort()
		{
			return default(ushort);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xDB44E8", Offset = "0xDB44E8", VA = "0xDB44E8")]
		public short PeekShort()
		{
			return default(short);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xDB454C", Offset = "0xDB454C", VA = "0xDB454C")]
		public long PeekLong()
		{
			return default(long);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xDB45B0", Offset = "0xDB45B0", VA = "0xDB45B0")]
		public ulong PeekULong()
		{
			return default(ulong);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xDB4614", Offset = "0xDB4614", VA = "0xDB4614")]
		public int PeekInt()
		{
			return default(int);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xDB4678", Offset = "0xDB4678", VA = "0xDB4678")]
		public uint PeekUInt()
		{
			return default(uint);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xDB46DC", Offset = "0xDB46DC", VA = "0xDB46DC")]
		public float PeekFloat()
		{
			return default(float);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xDB4740", Offset = "0xDB4740", VA = "0xDB4740")]
		public double PeekDouble()
		{
			return default(double);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xDB47A4", Offset = "0xDB47A4", VA = "0xDB47A4")]
		public string PeekString(int maxLength)
		{
			return null;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xDB48C0", Offset = "0xDB48C0", VA = "0xDB48C0")]
		public string PeekString()
		{
			return null;
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xDB498C", Offset = "0xDB498C", VA = "0xDB498C")]
		public bool TryGetByte(out byte result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xDB49C8", Offset = "0xDB49C8", VA = "0xDB49C8")]
		public bool TryGetSByte(out sbyte result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xDB4A04", Offset = "0xDB4A04", VA = "0xDB4A04")]
		public bool TryGetBool(out bool result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xDB4A40", Offset = "0xDB4A40", VA = "0xDB4A40")]
		public bool TryGetChar(out char result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xDB4A7C", Offset = "0xDB4A7C", VA = "0xDB4A7C")]
		public bool TryGetShort(out short result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xDB4AB8", Offset = "0xDB4AB8", VA = "0xDB4AB8")]
		public bool TryGetUShort(out ushort result)
		{
			return default(bool);
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xDB4AF4", Offset = "0xDB4AF4", VA = "0xDB4AF4")]
		public bool TryGetInt(out int result)
		{
			return default(bool);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xDB4B30", Offset = "0xDB4B30", VA = "0xDB4B30")]
		public bool TryGetUInt(out uint result)
		{
			return default(bool);
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xDB4B6C", Offset = "0xDB4B6C", VA = "0xDB4B6C")]
		public bool TryGetLong(out long result)
		{
			return default(bool);
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xDB4BA8", Offset = "0xDB4BA8", VA = "0xDB4BA8")]
		public bool TryGetULong(out ulong result)
		{
			return default(bool);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xDB4BE4", Offset = "0xDB4BE4", VA = "0xDB4BE4")]
		public bool TryGetFloat(out float result)
		{
			return default(bool);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xDB4C1C", Offset = "0xDB4C1C", VA = "0xDB4C1C")]
		public bool TryGetDouble(out double result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xDB4C54", Offset = "0xDB4C54", VA = "0xDB4C54")]
		public bool TryGetString(out string result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xDB4CCC", Offset = "0xDB4CCC", VA = "0xDB4CCC")]
		public bool TryGetStringArray(out string[] result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xDB4DC0", Offset = "0xDB4DC0", VA = "0xDB4DC0")]
		public bool TryGetBytesWithLength(out byte[] result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xDB4E3C", Offset = "0xDB4E3C", VA = "0xDB4E3C")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class NetDataWriter
	{
		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected byte[] _data;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int _position;

		[Token(Token = "0x4000686")]
		private const int InitialSize = 64;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly bool _autoResize;

		[Token(Token = "0x170000EB")]
		public int Capacity
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0xDB4E4C", Offset = "0xDB4E4C", VA = "0xDB4E4C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000EC")]
		public byte[] Data
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0xDB5370", Offset = "0xDB5370", VA = "0xDB5370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		public int Length
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0xDB5378", Offset = "0xDB5378", VA = "0xDB5378")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xDB4E68", Offset = "0xDB4E68", VA = "0xDB4E68")]
		public NetDataWriter()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xDB4EF0", Offset = "0xDB4EF0", VA = "0xDB4EF0")]
		public NetDataWriter(bool autoResize)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xDB4E74", Offset = "0xDB4E74", VA = "0xDB4E74")]
		public NetDataWriter(bool autoResize, int initialSize)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xDB4EFC", Offset = "0xDB4EFC", VA = "0xDB4EFC")]
		public static NetDataWriter FromBytes(byte[] bytes, bool copy)
		{
			return null;
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xDB5028", Offset = "0xDB5028", VA = "0xDB5028")]
		public static NetDataWriter FromBytes(byte[] bytes, int offset, int length)
		{
			return null;
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xDB5120", Offset = "0xDB5120", VA = "0xDB5120")]
		public static NetDataWriter FromString(string value)
		{
			return null;
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xDB525C", Offset = "0xDB525C", VA = "0xDB525C")]
		public void ResizeIfNeed(int newSize)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xDB52DC", Offset = "0xDB52DC", VA = "0xDB52DC")]
		public void Reset(int size)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xDB52F4", Offset = "0xDB52F4", VA = "0xDB52F4")]
		public void Reset()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xDB52FC", Offset = "0xDB52FC", VA = "0xDB52FC")]
		public byte[] CopyData()
		{
			return null;
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xDB5380", Offset = "0xDB5380", VA = "0xDB5380")]
		public int SetPosition(int position)
		{
			return default(int);
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xDB5390", Offset = "0xDB5390", VA = "0xDB5390")]
		public void Put(float value)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xDB53E0", Offset = "0xDB53E0", VA = "0xDB53E0")]
		public void Put(double value)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xDB5430", Offset = "0xDB5430", VA = "0xDB5430")]
		public void Put(long value)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xDB5480", Offset = "0xDB5480", VA = "0xDB5480")]
		public void Put(ulong value)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xDB54D0", Offset = "0xDB54D0", VA = "0xDB54D0")]
		public void Put(int value)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xDB5520", Offset = "0xDB5520", VA = "0xDB5520")]
		public void Put(uint value)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xDB5570", Offset = "0xDB5570", VA = "0xDB5570")]
		public void Put(char value)
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xDB55C0", Offset = "0xDB55C0", VA = "0xDB55C0")]
		public void Put(ushort value)
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xDB5610", Offset = "0xDB5610", VA = "0xDB5610")]
		public void Put(short value)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xDB5660", Offset = "0xDB5660", VA = "0xDB5660")]
		public void Put(sbyte value)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xDB56C8", Offset = "0xDB56C8", VA = "0xDB56C8")]
		public void Put(byte value)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xDB50B4", Offset = "0xDB50B4", VA = "0xDB50B4")]
		public void Put(byte[] data, int offset, int length)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xDB4FB4", Offset = "0xDB4FB4", VA = "0xDB4FB4")]
		public void Put(byte[] data)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xDB5730", Offset = "0xDB5730", VA = "0xDB5730")]
		public void PutSBytesWithLength(sbyte[] data, int offset, int length)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xDB57BC", Offset = "0xDB57BC", VA = "0xDB57BC")]
		public void PutSBytesWithLength(sbyte[] data)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xDB584C", Offset = "0xDB584C", VA = "0xDB584C")]
		public void PutBytesWithLength(byte[] data, int offset, int length)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xDB58D8", Offset = "0xDB58D8", VA = "0xDB58D8")]
		public void PutBytesWithLength(byte[] data)
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xDB5968", Offset = "0xDB5968", VA = "0xDB5968")]
		public void Put(bool value)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xDB59D4", Offset = "0xDB59D4", VA = "0xDB59D4")]
		private void PutArray(Array arr, int sz)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xDB5A80", Offset = "0xDB5A80", VA = "0xDB5A80")]
		public void PutArray(float[] value)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xDB5A88", Offset = "0xDB5A88", VA = "0xDB5A88")]
		public void PutArray(double[] value)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xDB5A90", Offset = "0xDB5A90", VA = "0xDB5A90")]
		public void PutArray(long[] value)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xDB5A98", Offset = "0xDB5A98", VA = "0xDB5A98")]
		public void PutArray(ulong[] value)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xDB5AA0", Offset = "0xDB5AA0", VA = "0xDB5AA0")]
		public void PutArray(int[] value)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xDB5AA8", Offset = "0xDB5AA8", VA = "0xDB5AA8")]
		public void PutArray(uint[] value)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xDB5AB0", Offset = "0xDB5AB0", VA = "0xDB5AB0")]
		public void PutArray(ushort[] value)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xDB5AB8", Offset = "0xDB5AB8", VA = "0xDB5AB8")]
		public void PutArray(short[] value)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xDB5AC0", Offset = "0xDB5AC0", VA = "0xDB5AC0")]
		public void PutArray(bool[] value)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xDB5AC8", Offset = "0xDB5AC8", VA = "0xDB5AC8")]
		public void PutArray(string[] value)
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xDB5B50", Offset = "0xDB5B50", VA = "0xDB5B50")]
		public void PutArray(string[] value, int maxLength)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xDB5CD4", Offset = "0xDB5CD4", VA = "0xDB5CD4")]
		public void Put(IPEndPoint endPoint)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xDB5190", Offset = "0xDB5190", VA = "0xDB5190")]
		public void Put(string value)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xDB5BEC", Offset = "0xDB5BEC", VA = "0xDB5BEC")]
		public void Put(string value, int maxLength)
		{
		}

		[Token(Token = "0x6000753")]
		public void Put<T>(T obj) where T : INetSerializable
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class NetPacketProcessor
	{
		[Token(Token = "0x200013C")]
		private static class HashCache<T>
		{
			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ulong Id;

			[Token(Token = "0x6000771")]
			static HashCache()
			{
			}
		}

		[Token(Token = "0x200013D")]
		protected delegate void SubscribeDelegate(NetDataReader reader, object userData);

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly NetSerializer _netSerializer;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<ulong, SubscribeDelegate> _callbacks;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly NetDataWriter _netDataWriter;

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xDB5D20", Offset = "0xDB5D20", VA = "0xDB5D20")]
		public NetPacketProcessor()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xDB5E2C", Offset = "0xDB5E2C", VA = "0xDB5E2C")]
		public NetPacketProcessor(int maxStringLength)
		{
		}

		[Token(Token = "0x6000756")]
		protected virtual ulong GetHash<T>()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xDB5FD8", Offset = "0xDB5FD8", VA = "0xDB5FD8", Slot = "5")]
		protected virtual SubscribeDelegate GetCallbackFromData(NetDataReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000758")]
		protected virtual void WriteHash<T>(NetDataWriter writer)
		{
		}

		[Token(Token = "0x6000759")]
		public void RegisterNestedType<T>() where T : struct, INetSerializable
		{
		}

		[Token(Token = "0x600075A")]
		public void RegisterNestedType<T>(Action<NetDataWriter, T> writeDelegate, Func<NetDataReader, T> readDelegate)
		{
		}

		[Token(Token = "0x600075B")]
		public void RegisterNestedType<T>(Func<T> constructor) where T : class, INetSerializable
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xDB610C", Offset = "0xDB610C", VA = "0xDB610C")]
		public void ReadAllPackets(NetDataReader reader)
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xDB6168", Offset = "0xDB6168", VA = "0xDB6168")]
		public void ReadAllPackets(NetDataReader reader, object userData)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xDB6160", Offset = "0xDB6160", VA = "0xDB6160")]
		public void ReadPacket(NetDataReader reader)
		{
		}

		[Token(Token = "0x600075F")]
		public void Send<T>(NetPeer peer, T packet, DeliveryMethod options) where T : class, new()
		{
		}

		[Token(Token = "0x6000760")]
		public void SendNetSerializable<T>(NetPeer peer, T packet, DeliveryMethod options) where T : INetSerializable
		{
		}

		[Token(Token = "0x6000761")]
		public void Send<T>(NetManager manager, T packet, DeliveryMethod options) where T : class, new()
		{
		}

		[Token(Token = "0x6000762")]
		public void SendNetSerializable<T>(NetManager manager, T packet, DeliveryMethod options) where T : INetSerializable
		{
		}

		[Token(Token = "0x6000763")]
		public void Write<T>(NetDataWriter writer, T packet) where T : class, new()
		{
		}

		[Token(Token = "0x6000764")]
		public void WriteNetSerializable<T>(NetDataWriter writer, T packet) where T : INetSerializable
		{
		}

		[Token(Token = "0x6000765")]
		public byte[] Write<T>(T packet) where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x6000766")]
		public byte[] WriteNetSerializable<T>(T packet) where T : INetSerializable
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xDB61C0", Offset = "0xDB61C0", VA = "0xDB61C0")]
		public void ReadPacket(NetDataReader reader, object userData)
		{
		}

		[Token(Token = "0x6000768")]
		public void Subscribe<T>(Action<T> onReceive, Func<T> packetConstructor) where T : class, new()
		{
		}

		[Token(Token = "0x6000769")]
		public void Subscribe<T, TUserData>(Action<T, TUserData> onReceive, Func<T> packetConstructor) where T : class, new()
		{
		}

		[Token(Token = "0x600076A")]
		public void SubscribeReusable<T>(Action<T> onReceive) where T : class, new()
		{
		}

		[Token(Token = "0x600076B")]
		public void SubscribeReusable<T, TUserData>(Action<T, TUserData> onReceive) where T : class, new()
		{
		}

		[Token(Token = "0x600076C")]
		public void SubscribeNetSerializable<T, TUserData>(Action<T, TUserData> onReceive, Func<T> packetConstructor) where T : INetSerializable
		{
		}

		[Token(Token = "0x600076D")]
		public void SubscribeNetSerializable<T>(Action<T> onReceive, Func<T> packetConstructor) where T : INetSerializable
		{
		}

		[Token(Token = "0x600076E")]
		public void SubscribeNetSerializable<T, TUserData>(Action<T, TUserData> onReceive) where T : INetSerializable, new()
		{
		}

		[Token(Token = "0x600076F")]
		public void SubscribeNetSerializable<T>(Action<T> onReceive) where T : INetSerializable, new()
		{
		}

		[Token(Token = "0x6000770")]
		public bool RemoveSubscription<T>()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000146")]
	public class InvalidTypeException : ArgumentException
	{
		[Token(Token = "0x6000786")]
		[Address(RVA = "0xDB6390", Offset = "0xDB6390", VA = "0xDB6390")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class ParseException : Exception
	{
		[Token(Token = "0x6000787")]
		[Address(RVA = "0xDB60A4", Offset = "0xDB60A4", VA = "0xDB60A4")]
		public ParseException(string message)
		{
		}
	}
	[Token(Token = "0x2000148")]
	public class NetSerializer
	{
		[Token(Token = "0x2000149")]
		private enum CallType
		{
			[Token(Token = "0x40006A4")]
			Basic,
			[Token(Token = "0x40006A5")]
			Array,
			[Token(Token = "0x40006A6")]
			List
		}

		[Token(Token = "0x200014A")]
		private abstract class FastCall<T>
		{
			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallType Type;

			[Token(Token = "0x6000793")]
			public virtual void Init(MethodInfo getMethod, MethodInfo setMethod, CallType type)
			{
			}

			[Token(Token = "0x6000794")]
			public abstract void Read(T inf, NetDataReader r);

			[Token(Token = "0x6000795")]
			public abstract void Write(T inf, NetDataWriter w);

			[Token(Token = "0x6000796")]
			public abstract void ReadArray(T inf, NetDataReader r);

			[Token(Token = "0x6000797")]
			public abstract void WriteArray(T inf, NetDataWriter w);

			[Token(Token = "0x6000798")]
			public abstract void ReadList(T inf, NetDataReader r);

			[Token(Token = "0x6000799")]
			public abstract void WriteList(T inf, NetDataWriter w);

			[Token(Token = "0x600079A")]
			protected FastCall()
			{
			}
		}

		[Token(Token = "0x200014B")]
		private abstract class FastCallSpecific<TClass, TProperty> : FastCall<TClass>
		{
			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Func<TClass, TProperty> Getter;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Action<TClass, TProperty> Setter;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Func<TClass, TProperty[]> GetterArr;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Action<TClass, TProperty[]> SetterArr;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Func<TClass, List<TProperty>> GetterList;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Action<TClass, List<TProperty>> SetterList;

			[Token(Token = "0x600079B")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600079C")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600079D")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600079E")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600079F")]
			protected TProperty[] ReadArrayHelper(TClass inf, NetDataReader r)
			{
				return null;
			}

			[Token(Token = "0x60007A0")]
			protected TProperty[] WriteArrayHelper(TClass inf, NetDataWriter w)
			{
				return null;
			}

			[Token(Token = "0x60007A1")]
			protected List<TProperty> ReadListHelper(TClass inf, NetDataReader r, out int len)
			{
				return null;
			}

			[Token(Token = "0x60007A2")]
			protected List<TProperty> WriteListHelper(TClass inf, NetDataWriter w, out int len)
			{
				return null;
			}

			[Token(Token = "0x60007A3")]
			public override void Init(MethodInfo getMethod, MethodInfo setMethod, CallType type)
			{
			}

			[Token(Token = "0x60007A4")]
			protected FastCallSpecific()
			{
			}
		}

		[Token(Token = "0x200014C")]
		private abstract class FastCallSpecificAuto<TClass, TProperty> : FastCallSpecific<TClass, TProperty>
		{
			[Token(Token = "0x60007A5")]
			protected abstract void ElementRead(NetDataReader r, out TProperty prop);

			[Token(Token = "0x60007A6")]
			protected abstract void ElementWrite(NetDataWriter w, ref TProperty prop);

			[Token(Token = "0x60007A7")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007A8")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007A9")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007AA")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007AB")]
			protected FastCallSpecificAuto()
			{
			}
		}

		[Token(Token = "0x200014D")]
		private sealed class FastCallStatic<TClass, TProperty> : FastCallSpecific<TClass, TProperty>
		{
			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Action<NetDataWriter, TProperty> _writer;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<NetDataReader, TProperty> _reader;

			[Token(Token = "0x60007AC")]
			public FastCallStatic(Action<NetDataWriter, TProperty> write, Func<NetDataReader, TProperty> read)
			{
			}

			[Token(Token = "0x60007AD")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007AE")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007AF")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007B0")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007B1")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007B2")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x200014E")]
		private sealed class FastCallStruct<TClass, TProperty> : FastCallSpecific<TClass, TProperty> where TProperty : struct, INetSerializable
		{
			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TProperty _p;

			[Token(Token = "0x60007B3")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007B4")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007B5")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007B6")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007B7")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007B8")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007B9")]
			public FastCallStruct()
			{
			}
		}

		[Token(Token = "0x200014F")]
		private sealed class FastCallClass<TClass, TProperty> : FastCallSpecific<TClass, TProperty> where TProperty : class, INetSerializable
		{
			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<TProperty> _constructor;

			[Token(Token = "0x60007BA")]
			public FastCallClass(Func<TProperty> constructor)
			{
			}

			[Token(Token = "0x60007BB")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007BC")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007BD")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007BE")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007BF")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007C0")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x2000150")]
		private class IntSerializer<T> : FastCallSpecific<T, int>
		{
			[Token(Token = "0x60007C1")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007C2")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007C3")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007C4")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007C5")]
			public IntSerializer()
			{
			}
		}

		[Token(Token = "0x2000151")]
		private class UIntSerializer<T> : FastCallSpecific<T, uint>
		{
			[Token(Token = "0x60007C6")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007C7")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007C8")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007C9")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007CA")]
			public UIntSerializer()
			{
			}
		}

		[Token(Token = "0x2000152")]
		private class ShortSerializer<T> : FastCallSpecific<T, short>
		{
			[Token(Token = "0x60007CB")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007CC")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007CD")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007CE")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007CF")]
			public ShortSerializer()
			{
			}
		}

		[Token(Token = "0x2000153")]
		private class UShortSerializer<T> : FastCallSpecific<T, ushort>
		{
			[Token(Token = "0x60007D0")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007D1")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007D2")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007D3")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007D4")]
			public UShortSerializer()
			{
			}
		}

		[Token(Token = "0x2000154")]
		private class LongSerializer<T> : FastCallSpecific<T, long>
		{
			[Token(Token = "0x60007D5")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007D6")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007D7")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007D8")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007D9")]
			public LongSerializer()
			{
			}
		}

		[Token(Token = "0x2000155")]
		private class ULongSerializer<T> : FastCallSpecific<T, ulong>
		{
			[Token(Token = "0x60007DA")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007DB")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007DC")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007DD")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007DE")]
			public ULongSerializer()
			{
			}
		}

		[Token(Token = "0x2000156")]
		private class ByteSerializer<T> : FastCallSpecific<T, byte>
		{
			[Token(Token = "0x60007DF")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007E0")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007E1")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007E2")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007E3")]
			public ByteSerializer()
			{
			}
		}

		[Token(Token = "0x2000157")]
		private class SByteSerializer<T> : FastCallSpecific<T, sbyte>
		{
			[Token(Token = "0x60007E4")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007E5")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007E6")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007E7")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007E8")]
			public SByteSerializer()
			{
			}
		}

		[Token(Token = "0x2000158")]
		private class FloatSerializer<T> : FastCallSpecific<T, float>
		{
			[Token(Token = "0x60007E9")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007EA")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007EB")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007EC")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007ED")]
			public FloatSerializer()
			{
			}
		}

		[Token(Token = "0x2000159")]
		private class DoubleSerializer<T> : FastCallSpecific<T, double>
		{
			[Token(Token = "0x60007EE")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007EF")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007F0")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007F1")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007F2")]
			public DoubleSerializer()
			{
			}
		}

		[Token(Token = "0x200015A")]
		private class BoolSerializer<T> : FastCallSpecific<T, bool>
		{
			[Token(Token = "0x60007F3")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007F4")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007F5")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x60007F6")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x60007F7")]
			public BoolSerializer()
			{
			}
		}

		[Token(Token = "0x200015B")]
		private class CharSerializer<T> : FastCallSpecificAuto<T, char>
		{
			[Token(Token = "0x60007F8")]
			protected override void ElementWrite(NetDataWriter w, ref char prop)
			{
			}

			[Token(Token = "0x60007F9")]
			protected override void ElementRead(NetDataReader r, out char prop)
			{
			}

			[Token(Token = "0x60007FA")]
			public CharSerializer()
			{
			}
		}

		[Token(Token = "0x200015C")]
		private class IPEndPointSerializer<T> : FastCallSpecificAuto<T, IPEndPoint>
		{
			[Token(Token = "0x60007FB")]
			protected override void ElementWrite(NetDataWriter w, ref IPEndPoint prop)
			{
			}

			[Token(Token = "0x60007FC")]
			protected override void ElementRead(NetDataReader r, out IPEndPoint prop)
			{
			}

			[Token(Token = "0x60007FD")]
			public IPEndPointSerializer()
			{
			}
		}

		[Token(Token = "0x200015D")]
		private class StringSerializer<T> : FastCallSpecific<T, string>
		{
			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int _maxLength;

			[Token(Token = "0x60007FE")]
			public StringSerializer(int maxLength)
			{
			}

			[Token(Token = "0x60007FF")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000800")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000801")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000802")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x200015E")]
		private class EnumByteSerializer<T> : FastCall<T>
		{
			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected readonly PropertyInfo Property;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected readonly Type PropertyType;

			[Token(Token = "0x6000803")]
			public EnumByteSerializer(PropertyInfo property, Type propertyType)
			{
			}

			[Token(Token = "0x6000804")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000805")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000806")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000807")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000808")]
			public override void ReadList(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000809")]
			public override void WriteList(T inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x200015F")]
		private class EnumIntSerializer<T> : EnumByteSerializer<T>
		{
			[Token(Token = "0x600080A")]
			public EnumIntSerializer(PropertyInfo property, Type propertyType)
			{
			}

			[Token(Token = "0x600080B")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600080C")]
			public override void Write(T inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x2000160")]
		private sealed class ClassInfo<T>
		{
			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static ClassInfo<T> Instance;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly FastCall<T>[] _serializers;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int _membersCount;

			[Token(Token = "0x600080D")]
			public ClassInfo(List<FastCall<T>> serializers)
			{
			}

			[Token(Token = "0x600080E")]
			public void Write(T obj, NetDataWriter writer)
			{
			}

			[Token(Token = "0x600080F")]
			public void Read(T obj, NetDataReader reader)
			{
			}
		}

		[Token(Token = "0x2000161")]
		private abstract class CustomType
		{
			[Token(Token = "0x6000810")]
			public abstract FastCall<T> Get<T>();

			[Token(Token = "0x6000811")]
			[Address(RVA = "0xDB6398", Offset = "0xDB6398", VA = "0xDB6398")]
			protected CustomType()
			{
			}
		}

		[Token(Token = "0x2000162")]
		private sealed class CustomTypeStruct<TProperty> : CustomType where TProperty : struct, INetSerializable
		{
			[Token(Token = "0x6000812")]
			public override FastCall<T> Get<T>()
			{
				return null;
			}

			[Token(Token = "0x6000813")]
			public CustomTypeStruct()
			{
			}
		}

		[Token(Token = "0x2000163")]
		private sealed class CustomTypeClass<TProperty> : CustomType where TProperty : class, INetSerializable
		{
			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<TProperty> _constructor;

			[Token(Token = "0x6000814")]
			public CustomTypeClass(Func<TProperty> constructor)
			{
			}

			[Token(Token = "0x6000815")]
			public override FastCall<T> Get<T>()
			{
				return null;
			}
		}

		[Token(Token = "0x2000164")]
		private sealed class CustomTypeStatic<TProperty> : CustomType
		{
			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Action<NetDataWriter, TProperty> _writer;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<NetDataReader, TProperty> _reader;

			[Token(Token = "0x6000816")]
			public CustomTypeStatic(Action<NetDataWriter, TProperty> writer, Func<NetDataReader, TProperty> reader)
			{
			}

			[Token(Token = "0x6000817")]
			public override FastCall<T> Get<T>()
			{
				return null;
			}
		}

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NetDataWriter _writer;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int _maxStringLength;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<Type, CustomType> _registeredTypes;

		[Token(Token = "0x6000788")]
		public void RegisterNestedType<T>() where T : struct, INetSerializable
		{
		}

		[Token(Token = "0x6000789")]
		public void RegisterNestedType<T>(Func<T> constructor) where T : class, INetSerializable
		{
		}

		[Token(Token = "0x600078A")]
		public void RegisterNestedType<T>(Action<NetDataWriter, T> writer, Func<NetDataReader, T> reader)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xDB5E24", Offset = "0xDB5E24", VA = "0xDB5E24")]
		public NetSerializer()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xDB5F3C", Offset = "0xDB5F3C", VA = "0xDB5F3C")]
		public NetSerializer(int maxStringLength)
		{
		}

		[Token(Token = "0x600078D")]
		private ClassInfo<T> RegisterInternal<T>()
		{
			return null;
		}

		[Token(Token = "0x600078E")]
		public void Register<T>()
		{
		}

		[Token(Token = "0x600078F")]
		public T Deserialize<T>(NetDataReader reader) where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x6000790")]
		public bool Deserialize<T>(NetDataReader reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Token(Token = "0x6000791")]
		public void Serialize<T>(NetDataWriter writer, T obj) where T : class, new()
		{
		}

		[Token(Token = "0x6000792")]
		public byte[] Serialize<T>(T obj) where T : class, new()
		{
			return null;
		}
	}
	[Token(Token = "0x2000165")]
	public class NtpPacket
	{
		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DateTime Epoch;

		[Token(Token = "0x170000EE")]
		public byte[] Bytes
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0xDB63A0", Offset = "0xDB63A0", VA = "0xDB63A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000819")]
			[Address(RVA = "0xDB63A8", Offset = "0xDB63A8", VA = "0xDB63A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public NtpLeapIndicator LeapIndicator
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0xDB63B0", Offset = "0xDB63B0", VA = "0xDB63B0")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Token(Token = "0x170000F0")]
		public int VersionNumber
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0xDB63DC", Offset = "0xDB63DC", VA = "0xDB63DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600081C")]
			[Address(RVA = "0xDB6408", Offset = "0xDB6408", VA = "0xDB6408")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public NtpMode Mode
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0xDB643C", Offset = "0xDB643C", VA = "0xDB643C")]
			get
			{
				return default(NtpMode);
			}
			[Token(Token = "0x600081E")]
			[Address(RVA = "0xDB6468", Offset = "0xDB6468", VA = "0xDB6468")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public int Stratum
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0xDB649C", Offset = "0xDB649C", VA = "0xDB649C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F3")]
		public int Poll
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0xDB64C8", Offset = "0xDB64C8", VA = "0xDB64C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F4")]
		public int Precision
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0xDB64F4", Offset = "0xDB64F4", VA = "0xDB64F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F5")]
		public TimeSpan RootDelay
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0xDB6520", Offset = "0xDB6520", VA = "0xDB6520")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x170000F6")]
		public TimeSpan RootDispersion
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0xDB65AC", Offset = "0xDB65AC", VA = "0xDB65AC")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x170000F7")]
		public uint ReferenceId
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0xDB65B4", Offset = "0xDB65B4", VA = "0xDB65B4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x170000F8")]
		public DateTime? ReferenceTimestamp
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0xDB665C", Offset = "0xDB665C", VA = "0xDB665C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F9")]
		public DateTime? OriginTimestamp
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0xDB6770", Offset = "0xDB6770", VA = "0xDB6770")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		public DateTime? ReceiveTimestamp
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0xDB6778", Offset = "0xDB6778", VA = "0xDB6778")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		public DateTime? TransmitTimestamp
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0xDB6780", Offset = "0xDB6780", VA = "0xDB6780")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000829")]
			[Address(RVA = "0xDB6788", Offset = "0xDB6788", VA = "0xDB6788")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public DateTime? DestinationTimestamp
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0xDB68CC", Offset = "0xDB68CC", VA = "0xDB68CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600082B")]
			[Address(RVA = "0xDB68D8", Offset = "0xDB68D8", VA = "0xDB68D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public TimeSpan RoundTripTime
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0xDB68E0", Offset = "0xDB68E0", VA = "0xDB68E0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x170000FE")]
		public TimeSpan CorrectionOffset
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0xDB6B74", Offset = "0xDB6B74", VA = "0xDB6B74")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xDB6CE8", Offset = "0xDB6CE8", VA = "0xDB6CE8")]
		public NtpPacket()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xDB6DCC", Offset = "0xDB6DCC", VA = "0xDB6DCC")]
		internal NtpPacket(byte[] bytes)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xDB6E70", Offset = "0xDB6E70", VA = "0xDB6E70")]
		public static NtpPacket FromServerResponse(byte[] bytes, DateTime destinationTimestamp)
		{
			return null;
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xDB6F14", Offset = "0xDB6F14", VA = "0xDB6F14")]
		internal void ValidateRequest()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xDB7010", Offset = "0xDB7010", VA = "0xDB7010")]
		internal void ValidateReply()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xDB6A40", Offset = "0xDB6A40", VA = "0xDB6A40")]
		private void CheckTimestamps()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xDB6664", Offset = "0xDB6664", VA = "0xDB6664")]
		private DateTime? GetDateTime64(int offset)
		{
			return null;
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xDB6798", Offset = "0xDB6798", VA = "0xDB6798")]
		private void SetDateTime64(int offset, DateTime? value)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xDB6528", Offset = "0xDB6528", VA = "0xDB6528")]
		private TimeSpan GetTimeSpan32(int offset)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xDB7174", Offset = "0xDB7174", VA = "0xDB7174")]
		private ulong GetUInt64BE(int offset)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xDB7214", Offset = "0xDB7214", VA = "0xDB7214")]
		private void SetUInt64BE(int offset, ulong value)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xDB728C", Offset = "0xDB728C", VA = "0xDB728C")]
		private int GetInt32BE(int offset)
		{
			return default(int);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xDB65BC", Offset = "0xDB65BC", VA = "0xDB65BC")]
		private uint GetUInt32BE(int offset)
		{
			return default(uint);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xDB72F0", Offset = "0xDB72F0", VA = "0xDB72F0")]
		private static uint SwapEndianness(uint x)
		{
			return default(uint);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xDB7290", Offset = "0xDB7290", VA = "0xDB7290")]
		private static ulong SwapEndianness(ulong x)
		{
			return default(ulong);
		}
	}
	[Token(Token = "0x2000166")]
	public enum NtpLeapIndicator
	{
		[Token(Token = "0x40006BF")]
		NoWarning,
		[Token(Token = "0x40006C0")]
		LastMinuteHas61Seconds,
		[Token(Token = "0x40006C1")]
		LastMinuteHas59Seconds,
		[Token(Token = "0x40006C2")]
		AlarmCondition
	}
	[Token(Token = "0x2000167")]
	public enum NtpMode
	{
		[Token(Token = "0x40006C4")]
		Client = 3,
		[Token(Token = "0x40006C5")]
		Server
	}
	[Token(Token = "0x2000168")]
	internal sealed class NtpRequest
	{
		[Token(Token = "0x40006C6")]
		private const int ResendTimer = 1000;

		[Token(Token = "0x40006C7")]
		private const int KillTimer = 10000;

		[Token(Token = "0x40006C8")]
		public const int DefaultPort = 123;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IPEndPoint _ntpEndPoint;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _resendTime;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _killTime;

		[Token(Token = "0x170000FF")]
		public bool NeedToKill
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0xDB7398", Offset = "0xDB7398", VA = "0xDB7398")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xDB7360", Offset = "0xDB7360", VA = "0xDB7360")]
		public NtpRequest(IPEndPoint endPoint)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xDB73AC", Offset = "0xDB73AC", VA = "0xDB73AC")]
		public bool Send(NetSocket socket, int time)
		{
			return default(bool);
		}
	}
}
namespace FlyingWormConsole3.LiteNetLib.Layers
{
	[Token(Token = "0x2000169")]
	public sealed class Crc32cLayer : PacketLayerBase
	{
		[Token(Token = "0x6000841")]
		[Address(RVA = "0xDB7488", Offset = "0xDB7488", VA = "0xDB7488")]
		public Crc32cLayer()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xDB74D0", Offset = "0xDB74D0", VA = "0xDB74D0", Slot = "4")]
		public override void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xDB7658", Offset = "0xDB7658", VA = "0xDB7658", Slot = "5")]
		public override void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}
	}
	[Token(Token = "0x200016A")]
	public abstract class PacketLayerBase
	{
		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int ExtraPacketSizeForLayer;

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xDB74A8", Offset = "0xDB74A8", VA = "0xDB74A8")]
		protected PacketLayerBase(int extraPacketSizeForLayer)
		{
		}

		[Token(Token = "0x6000845")]
		public abstract void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length);

		[Token(Token = "0x6000846")]
		public abstract void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length);
	}
	[Token(Token = "0x200016B")]
	public class XorEncryptLayer : PacketLayerBase
	{
		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private byte[] _byteKey;

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xDB76F0", Offset = "0xDB76F0", VA = "0xDB76F0")]
		public XorEncryptLayer()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xDB770C", Offset = "0xDB770C", VA = "0xDB770C")]
		public XorEncryptLayer(byte[] key)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xDB77DC", Offset = "0xDB77DC", VA = "0xDB77DC")]
		public XorEncryptLayer(string key)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xDB780C", Offset = "0xDB780C", VA = "0xDB780C")]
		public void SetKey(string key)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xDB773C", Offset = "0xDB773C", VA = "0xDB773C")]
		public void SetKey(byte[] key)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xDB7858", Offset = "0xDB7858", VA = "0xDB7858", Slot = "4")]
		public override void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xDB78E4", Offset = "0xDB78E4", VA = "0xDB78E4", Slot = "5")]
		public override void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}
	}
}
namespace EscalatorPro
{
	[Token(Token = "0x200016C")]
	public class EscalatorPro : MonoBehaviour
	{
		[Token(Token = "0x200016D")]
		public enum Destination
		{
			[Token(Token = "0x40006DD")]
			ToSlopeStartPoint,
			[Token(Token = "0x40006DE")]
			ToSlopeEndPoint,
			[Token(Token = "0x40006DF")]
			ToEndPoint,
			[Token(Token = "0x40006E0")]
			ToEndPointDown,
			[Token(Token = "0x40006E1")]
			ToSlopeEndPointReturn,
			[Token(Token = "0x40006E2")]
			ToSlopeStartPointReturn,
			[Token(Token = "0x40006E3")]
			ToStartPointDown,
			[Token(Token = "0x40006E4")]
			ToSartPoint
		}

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Config")]
		public GameObject stairPrefab;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float stairOffsetX;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float stairOffsetY;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int step;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int stepBefore;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int stepAfter;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Header("Animation")]
		[Range(0f, 1f)]
		public float speed;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool stopped;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool reversed;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		[Header("Visibility")]
		public bool disableCollider;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		public bool disableMesh;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public Vector3[] destPoints;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public float stairSpacing;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Stair[] allStair;

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xDB7970", Offset = "0xDB7970", VA = "0xDB7970")]
		public Vector3 GetTargetPointFromDestination(Destination dest)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xDB79AC", Offset = "0xDB79AC", VA = "0xDB79AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xDB7A0C", Offset = "0xDB7A0C", VA = "0xDB7A0C")]
		private void UpdateConnectedStair()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xDB7B4C", Offset = "0xDB7B4C", VA = "0xDB7B4C")]
		public void SetReversed(bool reversed)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xDB7BD4", Offset = "0xDB7BD4", VA = "0xDB7BD4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xDB7C18", Offset = "0xDB7C18", VA = "0xDB7C18")]
		public EscalatorPro()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class Stair : MonoBehaviour
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Rigidbody body;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Stair connectedStair;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public EscalatorPro.Destination nextDestination;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private EscalatorPro escalator;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MeshRenderer mesh;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Collider col;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 targetPos;

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xDB7CA4", Offset = "0xDB7CA4", VA = "0xDB7CA4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xDB7E10", Offset = "0xDB7E10", VA = "0xDB7E10")]
		private void HandleVisibility()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xDB8048", Offset = "0xDB8048", VA = "0xDB8048")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xDB7DE4", Offset = "0xDB7DE4", VA = "0xDB7DE4")]
		private void BeginTween()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xDB7BB8", Offset = "0xDB7BB8", VA = "0xDB7BB8")]
		public void ReverseDirection()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xDB82D0", Offset = "0xDB82D0", VA = "0xDB82D0")]
		public Stair()
		{
		}
	}
}
namespace Categories.Space.Sun
{
	[Token(Token = "0x200016F")]
	internal class AnimateSunTexture : BaseMonoBehaviour
	{
		[Token(Token = "0x2000170")]
		[CompilerGenerated]
		private sealed class <UpdateTiling>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnimateSunTexture <>4__this;

			[Token(Token = "0x17000100")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000862")]
				[Address(RVA = "0xDB8660", Offset = "0xDB8660", VA = "0xDB8660", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000101")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000864")]
				[Address(RVA = "0xDB86A8", Offset = "0xDB86A8", VA = "0xDB86A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0xDB84C4", Offset = "0xDB84C4", VA = "0xDB84C4")]
			[DebuggerHidden]
			public <UpdateTiling>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0xDB8508", Offset = "0xDB8508", VA = "0xDB8508", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0xDB850C", Offset = "0xDB850C", VA = "0xDB850C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000863")]
			[Address(RVA = "0xDB8668", Offset = "0xDB8668", VA = "0xDB8668", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int _columns;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _rows;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _rotationSpeed;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _framesPerSecond;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int index;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Coroutine _routineUpdateTilling;

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xDB82D8", Offset = "0xDB82D8", VA = "0xDB82D8", Slot = "10")]
		protected override void EnableComponent()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xDB8418", Offset = "0xDB8418", VA = "0xDB8418", Slot = "14")]
		protected override void UpdateComponent()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xDB84A0", Offset = "0xDB84A0", VA = "0xDB84A0", Slot = "15")]
		protected override void DisableComponent()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xDB83A4", Offset = "0xDB83A4", VA = "0xDB83A4")]
		[IteratorStateMachine(typeof(<UpdateTiling>d__9))]
		private IEnumerator UpdateTiling()
		{
			return null;
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xDB84EC", Offset = "0xDB84EC", VA = "0xDB84EC")]
		public AnimateSunTexture()
		{
		}
	}
	[Token(Token = "0x2000171")]
	public class SunFlares : BaseMonoBehaviour
	{
		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 _currentScale;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _glow;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform _flares;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform _flaresBig;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _saturationOld;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _contrastOld;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _brightnessOld;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float _edgeBrightnessOld;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _hueOld;

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xDB86B0", Offset = "0xDB86B0", VA = "0xDB86B0", Slot = "11")]
		protected override void AwakeComponent()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xDB88B4", Offset = "0xDB88B4", VA = "0xDB88B4")]
		public SunFlares()
		{
		}
	}
}
