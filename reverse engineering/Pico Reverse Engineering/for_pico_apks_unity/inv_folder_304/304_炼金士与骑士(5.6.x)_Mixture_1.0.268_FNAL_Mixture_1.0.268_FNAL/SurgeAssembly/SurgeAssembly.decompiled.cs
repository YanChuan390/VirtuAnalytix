using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pixelplacement;
using Pixelplacement.TweenSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class SplineControlledParticleSystem : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float startRadius;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float endRadius;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxTime;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Spline _spline;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float minRadiusValue;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float maxRadiusValue;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ParticleSystem _particleSystem;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ParticleSystem.Particle[] _particles;

	[Token(Token = "0x4000009")]
	private const float _previousDiff = 0.01f;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x280B6BC", Offset = "0x280B6BC", VA = "0x280B6BC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x280C1D8", Offset = "0x280C1D8", VA = "0x280C1D8")]
	public SplineControlledParticleSystem()
	{
	}
}
[Token(Token = "0x2000003")]
public class SplineFollower : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Spline spline;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool rotate;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool moveTowards;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distanceTravelled;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float currentDistance;

	[Token(Token = "0x17000001")]
	public float CurrentDistance
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x280C1F4", Offset = "0x280C1F4", VA = "0x280C1F4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x280C1FC", Offset = "0x280C1FC", VA = "0x280C1FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x280C208", Offset = "0x280C208", VA = "0x280C208")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x280C39C", Offset = "0x280C39C", VA = "0x280C39C")]
	public void ForceDistance(float distance)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x280C3B8", Offset = "0x280C3B8", VA = "0x280C3B8")]
	public void ForceMoveToDistance()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x280C494", Offset = "0x280C494", VA = "0x280C494")]
	public SplineFollower()
	{
	}
}
[Token(Token = "0x2000004")]
[ExecuteInEditMode]
public class SplineFollowerEditor : MonoBehaviour
{
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Spline spline;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform lookAtTarget;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 positionOffset;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool rotate;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(0f, 1f)]
	public int distanceTravelled;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x280C4B8", Offset = "0x280C4B8", VA = "0x280C4B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x280C5C4", Offset = "0x280C5C4", VA = "0x280C5C4")]
	public SplineFollowerEditor()
	{
	}
}
[Token(Token = "0x2000005")]
public class SplineTween : MonoBehaviour
{
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x280C5D4", Offset = "0x280C5D4", VA = "0x280C5D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x280C5D8", Offset = "0x280C5D8", VA = "0x280C5D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x280C5DC", Offset = "0x280C5DC", VA = "0x280C5DC")]
	public SplineTween()
	{
	}
}
namespace Pixelplacement
{
	[Token(Token = "0x2000006")]
	public class Chooser : MonoBehaviour
	{
		[Token(Token = "0x2000007")]
		public enum Method
		{
			[Token(Token = "0x4000037")]
			Raycast,
			[Token(Token = "0x4000038")]
			RaycastAll
		}

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObjectEvent OnSelected;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObjectEvent OnDeselected;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObjectEvent OnPressed;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObjectEvent OnReleased;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool _cursorPropertiesFolded;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool _unityEventsFolded;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform source;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastDistance;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LayerMask layermask;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public KeyCode[] pressedInput;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform cursor;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float surfaceOffset;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float idleDistance;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float stabilityDelta;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float snapDelta;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float stableSpeed;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float unstableSpeed;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool flipForward;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool matchSurfaceNormal;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public bool autoHide;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		public bool cursorHidden;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool flipCastDirection;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public LineRenderer lineRenderer;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Method _method;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _debugView;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _previousCursor;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<Transform> _current;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<Transform> _previous;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform _currentRaycast;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform _previousRaycast;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 _targetPosition;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool _hidden;

		[Token(Token = "0x17000002")]
		public Transform[] Current
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x280C5E4", Offset = "0x280C5E4", VA = "0x280C5E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public bool IsHitting
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x280C634", Offset = "0x280C634", VA = "0x280C634")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x280C63C", Offset = "0x280C63C", VA = "0x280C63C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x280C648", Offset = "0x280C648", VA = "0x280C648")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x280C6D8", Offset = "0x280C6D8", VA = "0x280C6D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x280C834", Offset = "0x280C834", VA = "0x280C834")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x280C904", Offset = "0x280C904", VA = "0x280C904")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x280CA78", Offset = "0x280CA78", VA = "0x280CA78")]
		public void Pressed()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x280CCC8", Offset = "0x280CCC8", VA = "0x280CCC8")]
		public void Released()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x280CF18", Offset = "0x280CF18", VA = "0x280CF18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x280E1E8", Offset = "0x280E1E8", VA = "0x280E1E8")]
		public Chooser()
		{
		}
	}
	[Token(Token = "0x2000008")]
	internal interface IChooser
	{
		[Token(Token = "0x6000019")]
		void Selected();

		[Token(Token = "0x600001A")]
		void Deselected();

		[Token(Token = "0x600001B")]
		void Pressed();

		[Token(Token = "0x600001C")]
		void Released();
	}
	[Token(Token = "0x2000009")]
	[RequireComponent(typeof(Initialization))]
	public class DisplayObject : MonoBehaviour
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _activated;

		[Token(Token = "0x17000004")]
		public bool ActiveSelf
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x280E2D4", Offset = "0x280E2D4", VA = "0x280E2D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x280E2F4", Offset = "0x280E2F4", VA = "0x280E2F4")]
			set
			{
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x280E32C", Offset = "0x280E32C", VA = "0x280E32C")]
		public void Register()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x280E2FC", Offset = "0x280E2FC", VA = "0x280E2FC")]
		public void SetActive(bool value)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x280E368", Offset = "0x280E368", VA = "0x280E368")]
		public void Solo()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x280E878", Offset = "0x280E878", VA = "0x280E878")]
		public void HideAll()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x280ECFC", Offset = "0x280ECFC", VA = "0x280ECFC")]
		public DisplayObject()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public class GameObjectEvent : UnityEvent<GameObject>
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x280ED04", Offset = "0x280ED04", VA = "0x280ED04")]
		public GameObjectEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class ColliderButtonEvent : UnityEvent
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x280ED4C", Offset = "0x280ED4C", VA = "0x280ED4C")]
		public ColliderButtonEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class BoolEvent : UnityEvent<bool>
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x280ED54", Offset = "0x280ED54", VA = "0x280ED54")]
		public BoolEvent()
		{
		}
	}
	[Token(Token = "0x200000D")]
	[RequireComponent(typeof(Initialization))]
	public abstract class Singleton<T> : MonoBehaviour
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _dontDestroyOnLoad;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x17000005")]
		public static T Instance
		{
			[Token(Token = "0x6000027")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x6000028")]
		protected virtual void OnRegistration()
		{
		}

		[Token(Token = "0x6000029")]
		public void RegisterSingleton(T instance)
		{
		}

		[Token(Token = "0x600002A")]
		protected void Initialize(T instance)
		{
		}

		[Token(Token = "0x600002B")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public static class BezierCurves
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x280ED9C", Offset = "0x280ED9C", VA = "0x280ED9C")]
		public static Vector3 GetPoint(Vector3 startPosition, Vector3 controlPoint, Vector3 endPosition, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x280EE10", Offset = "0x280EE10", VA = "0x280EE10")]
		public static Vector3 GetFirstDerivative(Vector3 startPoint, Vector3 controlPoint, Vector3 endPosition, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x280EE7C", Offset = "0x280EE7C", VA = "0x280EE7C")]
		public static Vector3 GetPoint(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float percentage, bool evenDistribution, int distributionSteps)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x280F298", Offset = "0x280F298", VA = "0x280F298")]
		public static Vector3 GetFirstDerivative(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x280F1EC", Offset = "0x280F1EC", VA = "0x280F1EC")]
		private static Vector3 Locate(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float percentage)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200000F")]
	public struct CurveDetail
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int currentCurve;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float currentCurvePercentage;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x280F348", Offset = "0x280F348", VA = "0x280F348")]
		public CurveDetail(int currentCurve, float currentCurvePercentage)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public enum SplineDirection
	{
		[Token(Token = "0x400003F")]
		Forward,
		[Token(Token = "0x4000040")]
		Backwards
	}
	[Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	public class Spline : MonoBehaviour
	{
		[Token(Token = "0x2000012")]
		private class SplineReparam
		{
			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float length;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float percentage;

			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2810700", Offset = "0x2810700", VA = "0x2810700")]
			public SplineReparam(float length, float percentage)
			{
			}
		}

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float toolScale;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public TangentMode defaultTangentMode;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SplineDirection direction;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool loop;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SplineFollower[] followers;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SplineAnchor[] _anchors;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _curveCount;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _previousAnchorCount;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _previousChildCount;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool _wasLooping;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool _previousLoopChoice;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool _anchorsChanged;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SplineDirection _previousDirection;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _curvePercentage;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _operatingCurve;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _currentCurve;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _previousLength;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int _slicesPerCurve;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<SplineReparam> _splineReparams;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _lengthDirty;

		[Token(Token = "0x17000006")]
		public float Length
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x280F48C", Offset = "0x280F48C", VA = "0x280F48C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x280F494", Offset = "0x280F494", VA = "0x280F494")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public SplineAnchor[] Anchors
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x280F49C", Offset = "0x280F49C", VA = "0x280F49C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public Color SecondaryColor
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x280F648", Offset = "0x280F648", VA = "0x280F648")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action OnSplineChanged
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x280F354", Offset = "0x280F354", VA = "0x280F354")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x280F3F0", Offset = "0x280F3F0", VA = "0x280F3F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x280F67C", Offset = "0x280F67C", VA = "0x280F67C")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x280FD94", Offset = "0x280FD94", VA = "0x280FD94")]
		private void Update()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2810290", Offset = "0x2810290", VA = "0x2810290")]
		private void HangleLengthChange()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x28102B4", Offset = "0x28102B4", VA = "0x28102B4")]
		private float Reparam(float percent)
		{
			return default(float);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2810438", Offset = "0x2810438", VA = "0x2810438")]
		public void CalculateLength()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x280BF80", Offset = "0x280BF80", VA = "0x280BF80")]
		public Vector3 Up(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x281072C", Offset = "0x281072C", VA = "0x281072C")]
		public Vector3 Right(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x28107B4", Offset = "0x28107B4", VA = "0x28107B4")]
		public Vector3 Forward(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x280BD40", Offset = "0x280BD40", VA = "0x280BD40")]
		public Vector3 GetDirection(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x280C008", Offset = "0x280C008", VA = "0x280C008")]
		public Vector3 GetPosition(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x281097C", Offset = "0x281097C", VA = "0x281097C")]
		public Vector3 GetPosition(float percentage, Vector3 relativeOffset, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2810B74", Offset = "0x2810B74", VA = "0x2810B74")]
		public float ClosestPoint(Vector3 point, int divisions = 100)
		{
			return default(float);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x280F6C8", Offset = "0x280F6C8", VA = "0x280F6C8")]
		public GameObject[] AddAnchors(int count)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x28107BC", Offset = "0x28107BC", VA = "0x28107BC")]
		public CurveDetail GetCurve(float percentage)
		{
			return default(CurveDetail);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2810C74", Offset = "0x2810C74", VA = "0x2810C74")]
		public Spline()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public enum TangentMode
	{
		[Token(Token = "0x400005B")]
		Mirrored,
		[Token(Token = "0x400005C")]
		Aligned,
		[Token(Token = "0x400005D")]
		Free
	}
	[Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	public class SplineAnchor : MonoBehaviour
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TangentMode tangentMode;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		private bool _initialized;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private Transform _masterTangent;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private Transform _slaveTangent;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TangentMode _previousTangentMode;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 _previousInPosition;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 _previousOutPosition;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 _previousAnchorPosition;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Bounds _skinnedBounds;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _anchor;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform _inTangent;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform _outTangent;

		[Token(Token = "0x17000009")]
		public bool RenderingChange
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x2810D24", Offset = "0x2810D24", VA = "0x2810D24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2810D2C", Offset = "0x2810D2C", VA = "0x2810D2C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public bool Changed
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2810D38", Offset = "0x2810D38", VA = "0x2810D38")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2810D40", Offset = "0x2810D40", VA = "0x2810D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Transform Anchor
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2810910", Offset = "0x2810910", VA = "0x2810910")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2811184", Offset = "0x2811184", VA = "0x2811184")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Transform InTangent
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2810958", Offset = "0x2810958", VA = "0x2810958")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x281118C", Offset = "0x281118C", VA = "0x281118C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Transform OutTangent
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2810934", Offset = "0x2810934", VA = "0x2810934")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2811194", Offset = "0x2811194", VA = "0x2811194")]
			private set
			{
			}
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x281119C", Offset = "0x281119C", VA = "0x281119C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x28111A0", Offset = "0x28111A0", VA = "0x28111A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x28114C8", Offset = "0x28114C8", VA = "0x28114C8")]
		private void TangentChanged()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2810D4C", Offset = "0x2810D4C", VA = "0x2810D4C")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2810210", Offset = "0x2810210", VA = "0x2810210")]
		public void SetTangentStatus(bool inStatus, bool outStatus)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x28117C0", Offset = "0x28117C0", VA = "0x28117C0")]
		public void Tilt(Vector3 angles)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x28118DC", Offset = "0x28118DC", VA = "0x28118DC")]
		public SplineAnchor()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	public class SplineFollower
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform target;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float percentage;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool faceDirection;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _previousPercentage;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _previousFaceDirection;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool _detached;

		[Token(Token = "0x1700000E")]
		public bool WasMoved
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x2810088", Offset = "0x2810088", VA = "0x2810088")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x28100C0", Offset = "0x28100C0", VA = "0x28100C0")]
		public void UpdateOrientation(Spline spline)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x28118E4", Offset = "0x28118E4", VA = "0x28118E4")]
		public SplineFollower()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[SelectionBase]
	public class SplineTangent : MonoBehaviour
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x28118F4", Offset = "0x28118F4", VA = "0x28118F4")]
		public SplineTangent()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(LineRenderer))]
	public class SplineRenderer : MonoBehaviour
	{
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int segmentsPerCurve;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float startPercentage;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float endPercentage;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Spline _spline;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _initialized;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _previousAnchorsLength;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _previousSegmentsPerCurve;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _vertexCount;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _previousStart;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _previousEnd;

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x28118FC", Offset = "0x28118FC", VA = "0x28118FC")]
		private void Reset()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x281195C", Offset = "0x281195C", VA = "0x281195C")]
		private void Update()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2811B64", Offset = "0x2811B64", VA = "0x2811B64")]
		private void UpdateLineRenderer()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2811AE4", Offset = "0x2811AE4", VA = "0x2811AE4")]
		private void ConfigureLineRenderer()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2811C20", Offset = "0x2811C20", VA = "0x2811C20")]
		public SplineRenderer()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class State : MonoBehaviour
	{
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StateMachine _stateMachine;

		[Token(Token = "0x1700000F")]
		public bool IsFirst
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x2811C38", Offset = "0x2811C38", VA = "0x2811C38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public bool IsLast
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x2811C64", Offset = "0x2811C64", VA = "0x2811C64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		public StateMachine StateMachine
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x2811CC8", Offset = "0x2811CC8", VA = "0x2811CC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2811E00", Offset = "0x2811E00", VA = "0x2811E00")]
		public void ChangeState(int childIndex)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2811F18", Offset = "0x2811F18", VA = "0x2811F18")]
		public void ChangeState(GameObject state)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x28121F0", Offset = "0x28121F0", VA = "0x28121F0")]
		public void ChangeState(string state)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2812210", Offset = "0x2812210", VA = "0x2812210")]
		public GameObject Next(bool exitIfLast = false)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2812328", Offset = "0x2812328", VA = "0x2812328")]
		public GameObject Previous(bool exitIfFirst = false)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x281241C", Offset = "0x281241C", VA = "0x281241C")]
		public void Exit()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x28125D8", Offset = "0x28125D8", VA = "0x28125D8")]
		protected Coroutine StartCoroutineIfActive(IEnumerator coroutine)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x281262C", Offset = "0x281262C", VA = "0x281262C")]
		public State()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[RequireComponent(typeof(Initialization))]
	public class StateMachine : MonoBehaviour
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject defaultState;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject currentState;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool _unityEventsFolded;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("Should log messages be thrown during usage?")]
		public bool verbose;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[Tooltip("Can States within this StateMachine be reentered?")]
		public bool allowReentry;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[Tooltip("Return to default state on disable?")]
		public bool returnToDefaultOnDisable;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObjectEvent OnStateExited;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObjectEvent OnStateEntered;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent OnFirstStateEntered;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent OnFirstStateExited;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent OnLastStateEntered;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnLastStateExited;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _initialized;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool _atFirst;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool _atLast;

		[Token(Token = "0x17000012")]
		public bool CleanSetup
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x2812634", Offset = "0x2812634", VA = "0x2812634")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x281263C", Offset = "0x281263C", VA = "0x281263C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool AtFirst
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x2812648", Offset = "0x2812648", VA = "0x2812648")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x2812650", Offset = "0x2812650", VA = "0x2812650")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool AtLast
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x2812684", Offset = "0x2812684", VA = "0x2812684")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x281268C", Offset = "0x281268C", VA = "0x281268C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2812230", Offset = "0x2812230", VA = "0x2812230")]
		public GameObject Next(bool exitIfLast = false)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2812348", Offset = "0x2812348", VA = "0x2812348")]
		public GameObject Previous(bool exitIfFirst = false)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2812434", Offset = "0x2812434", VA = "0x2812434")]
		public void Exit()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2811E20", Offset = "0x2811E20", VA = "0x2811E20")]
		public GameObject ChangeState(int childIndex)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2812748", Offset = "0x2812748", VA = "0x2812748")]
		public GameObject ChangeState(GameObject state)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2811F58", Offset = "0x2811F58", VA = "0x2811F58")]
		public GameObject ChangeState(string state)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2812D0C", Offset = "0x2812D0C", VA = "0x2812D0C")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2812D94", Offset = "0x2812D94", VA = "0x2812D94")]
		public void StartMachine()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2812BAC", Offset = "0x2812BAC", VA = "0x2812BAC")]
		private void Enter(GameObject state)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x28126C0", Offset = "0x28126C0", VA = "0x28126C0")]
		private void Log(string message)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2812E30", Offset = "0x2812E30", VA = "0x2812E30")]
		public StateMachine()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Tween
	{
		[Token(Token = "0x200001B")]
		public enum TweenType
		{
			[Token(Token = "0x400009D")]
			Position,
			[Token(Token = "0x400009E")]
			Rotation,
			[Token(Token = "0x400009F")]
			LocalScale,
			[Token(Token = "0x40000A0")]
			LightColor,
			[Token(Token = "0x40000A1")]
			CameraBackgroundColor,
			[Token(Token = "0x40000A2")]
			LightIntensity,
			[Token(Token = "0x40000A3")]
			LightRange,
			[Token(Token = "0x40000A4")]
			FieldOfView,
			[Token(Token = "0x40000A5")]
			SpriteRendererColor,
			[Token(Token = "0x40000A6")]
			GraphicColor,
			[Token(Token = "0x40000A7")]
			AnchoredPosition,
			[Token(Token = "0x40000A8")]
			Size,
			[Token(Token = "0x40000A9")]
			Volume,
			[Token(Token = "0x40000AA")]
			Pitch,
			[Token(Token = "0x40000AB")]
			PanStereo,
			[Token(Token = "0x40000AC")]
			ShaderFloat,
			[Token(Token = "0x40000AD")]
			ShaderColor,
			[Token(Token = "0x40000AE")]
			ShaderInt,
			[Token(Token = "0x40000AF")]
			ShaderVector,
			[Token(Token = "0x40000B0")]
			Value,
			[Token(Token = "0x40000B1")]
			CanvasGroupAlpha,
			[Token(Token = "0x40000B2")]
			Spline,
			[Token(Token = "0x40000B3")]
			TextColor,
			[Token(Token = "0x40000B4")]
			ImageColor,
			[Token(Token = "0x40000B5")]
			RawImageColor,
			[Token(Token = "0x40000B6")]
			TextMeshColor
		}

		[Token(Token = "0x200001C")]
		public enum LoopType
		{
			[Token(Token = "0x40000B8")]
			None,
			[Token(Token = "0x40000B9")]
			Loop,
			[Token(Token = "0x40000BA")]
			PingPong
		}

		[Token(Token = "0x200001D")]
		public enum TweenStatus
		{
			[Token(Token = "0x40000BC")]
			Delayed,
			[Token(Token = "0x40000BD")]
			Running,
			[Token(Token = "0x40000BE")]
			Canceled,
			[Token(Token = "0x40000BF")]
			Stopped,
			[Token(Token = "0x40000C0")]
			Finished
		}

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<TweenBase> activeTweens;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static TweenEngine _instance;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static AnimationCurve _easeIn;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static AnimationCurve _easeInStrong;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static AnimationCurve _easeOut;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static AnimationCurve _easeOutStrong;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static AnimationCurve _easeInOut;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static AnimationCurve _easeInOutStrong;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static AnimationCurve _easeInBack;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static AnimationCurve _easeOutBack;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static AnimationCurve _easeInOutBack;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static AnimationCurve _easeSpring;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static AnimationCurve _easeBounce;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static AnimationCurve _easeWobble;

		[Token(Token = "0x17000015")]
		public static TweenEngine Instance
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x2812E40", Offset = "0x2812E40", VA = "0x2812E40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public static AnimationCurve EaseLinear
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x28131A8", Offset = "0x28131A8", VA = "0x28131A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public static AnimationCurve EaseIn
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x2819B64", Offset = "0x2819B64", VA = "0x2819B64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public static AnimationCurve EaseInStrong
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x2819D0C", Offset = "0x2819D0C", VA = "0x2819D0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public static AnimationCurve EaseOut
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x281A050", Offset = "0x281A050", VA = "0x281A050")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public static AnimationCurve EaseOutStrong
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x281A1F8", Offset = "0x281A1F8", VA = "0x281A1F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public static AnimationCurve EaseInOut
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x281A534", Offset = "0x281A534", VA = "0x281A534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public static AnimationCurve EaseInOutStrong
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x281A5F0", Offset = "0x281A5F0", VA = "0x281A5F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public static AnimationCurve EaseInBack
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x281A804", Offset = "0x281A804", VA = "0x281A804")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public static AnimationCurve EaseOutBack
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x281A9B0", Offset = "0x281A9B0", VA = "0x281A9B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public static AnimationCurve EaseInOutBack
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x281AB5C", Offset = "0x281AB5C", VA = "0x281AB5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public static AnimationCurve EaseSpring
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x281AD14", Offset = "0x281AD14", VA = "0x281AD14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public static AnimationCurve EaseBounce
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x281AFE8", Offset = "0x281AFE8", VA = "0x281AFE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public static AnimationCurve EaseWobble
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x281B440", Offset = "0x281B440", VA = "0x281B440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2813084", Offset = "0x2813084", VA = "0x2813084")]
		public static TweenBase Shake(Transform target, Vector3 initialPosition, Vector3 intensity, float duration, float delay, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2813358", Offset = "0x2813358", VA = "0x2813358")]
		public static TweenBase Spline(Spline spline, Transform target, float startPercentage, float endPercentage, bool faceDirection, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x28135A4", Offset = "0x28135A4", VA = "0x28135A4")]
		public static TweenBase CanvasGroupAlpha(CanvasGroup target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x281375C", Offset = "0x281375C", VA = "0x281375C")]
		public static TweenBase CanvasGroupAlpha(CanvasGroup target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x281382C", Offset = "0x281382C", VA = "0x281382C")]
		public static TweenBase Value(Rect startValue, Rect endValue, Action<Rect> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2813A60", Offset = "0x2813A60", VA = "0x2813A60")]
		public static TweenBase Value(Vector4 startValue, Vector4 endValue, Action<Vector4> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2813C94", Offset = "0x2813C94", VA = "0x2813C94")]
		public static TweenBase Value(Vector3 startValue, Vector3 endValue, Action<Vector3> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2813EA0", Offset = "0x2813EA0", VA = "0x2813EA0")]
		public static TweenBase Value(Vector2 startValue, Vector2 endValue, Action<Vector2> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x281407C", Offset = "0x281407C", VA = "0x281407C")]
		public static TweenBase Value(Color startValue, Color endValue, Action<Color> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x28142B0", Offset = "0x28142B0", VA = "0x28142B0")]
		public static TweenBase Value(int startValue, int endValue, Action<int> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2814474", Offset = "0x2814474", VA = "0x2814474")]
		public static TweenBase Value(float startValue, float endValue, Action<float> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2814628", Offset = "0x2814628", VA = "0x2814628")]
		public static TweenBase ShaderVector(Material target, string propertyName, Vector4 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2814844", Offset = "0x2814844", VA = "0x2814844")]
		public static TweenBase ShaderVector(Material target, string propertyName, Vector4 startValue, Vector4 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2814960", Offset = "0x2814960", VA = "0x2814960")]
		public static TweenBase ShaderInt(Material target, string propertyName, int endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2814B3C", Offset = "0x2814B3C", VA = "0x2814B3C")]
		public static TweenBase ShaderInt(Material target, string propertyName, int startValue, int endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2814C20", Offset = "0x2814C20", VA = "0x2814C20")]
		public static TweenBase ShaderColor(Material target, string propertyName, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2814E3C", Offset = "0x2814E3C", VA = "0x2814E3C")]
		public static TweenBase ShaderColor(Material target, string propertyName, Color startValue, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2814F58", Offset = "0x2814F58", VA = "0x2814F58")]
		public static TweenBase ShaderFloat(Material target, string propertyName, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x281513C", Offset = "0x281513C", VA = "0x281513C")]
		public static TweenBase ShaderFloat(Material target, string propertyName, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2815220", Offset = "0x2815220", VA = "0x2815220")]
		public static TweenBase Pitch(AudioSource target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x28153D8", Offset = "0x28153D8", VA = "0x28153D8")]
		public static TweenBase Pitch(AudioSource target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x28154A8", Offset = "0x28154A8", VA = "0x28154A8")]
		public static TweenBase PanStereo(AudioSource target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2815660", Offset = "0x2815660", VA = "0x2815660")]
		public static TweenBase PanStereo(AudioSource target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2815730", Offset = "0x2815730", VA = "0x2815730")]
		public static TweenBase Volume(AudioSource target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x28158E8", Offset = "0x28158E8", VA = "0x28158E8")]
		public static TweenBase Volume(AudioSource target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x28159B8", Offset = "0x28159B8", VA = "0x28159B8")]
		public static TweenBase Size(RectTransform target, Vector2 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2815B7C", Offset = "0x2815B7C", VA = "0x2815B7C")]
		public static TweenBase Size(RectTransform target, Vector2 startValue, Vector2 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2815C64", Offset = "0x2815C64", VA = "0x2815C64")]
		public static TweenBase FieldOfView(Camera target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2815E1C", Offset = "0x2815E1C", VA = "0x2815E1C")]
		public static TweenBase FieldOfView(Camera target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2815EEC", Offset = "0x2815EEC", VA = "0x2815EEC")]
		public static TweenBase LightRange(Light target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x28160A4", Offset = "0x28160A4", VA = "0x28160A4")]
		public static TweenBase LightRange(Light target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2816174", Offset = "0x2816174", VA = "0x2816174")]
		public static TweenBase LightIntensity(Light target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x281632C", Offset = "0x281632C", VA = "0x281632C")]
		public static TweenBase LightIntensity(Light target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x28163FC", Offset = "0x28163FC", VA = "0x28163FC")]
		public static TweenBase LocalScale(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x28165E0", Offset = "0x28165E0", VA = "0x28165E0")]
		public static TweenBase LocalScale(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x28166E0", Offset = "0x28166E0", VA = "0x28166E0")]
		public static TweenBase Color(Graphic target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x28168D0", Offset = "0x28168D0", VA = "0x28168D0")]
		public static TweenBase Color(Graphic target, Color startValue, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x28169E8", Offset = "0x28169E8", VA = "0x28169E8")]
		public static TweenBase Color(Light target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2816BD8", Offset = "0x2816BD8", VA = "0x2816BD8")]
		public static TweenBase Color(Light target, Color startValue, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2816CE8", Offset = "0x2816CE8", VA = "0x2816CE8")]
		public static TweenBase Color(Material target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2816E20", Offset = "0x2816E20", VA = "0x2816E20")]
		public static TweenBase Color(Material target, Color startColor, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2816F30", Offset = "0x2816F30", VA = "0x2816F30")]
		public static TweenBase Color(Renderer target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2817020", Offset = "0x2817020", VA = "0x2817020")]
		public static TweenBase Color(Renderer target, Color startColor, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2817138", Offset = "0x2817138", VA = "0x2817138")]
		public static TweenBase Color(SpriteRenderer target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2817328", Offset = "0x2817328", VA = "0x2817328")]
		public static TweenBase Color(SpriteRenderer target, Color startColor, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2817438", Offset = "0x2817438", VA = "0x2817438")]
		public static TweenBase Color(Camera target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2817628", Offset = "0x2817628", VA = "0x2817628")]
		public static TweenBase Color(Camera target, Color startColor, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2817738", Offset = "0x2817738", VA = "0x2817738")]
		public static TweenBase Position(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x281791C", Offset = "0x281791C", VA = "0x281791C")]
		public static TweenBase Position(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2817A1C", Offset = "0x2817A1C", VA = "0x2817A1C")]
		public static TweenBase AnchoredPosition(RectTransform target, Vector2 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2817BE0", Offset = "0x2817BE0", VA = "0x2817BE0")]
		public static TweenBase AnchoredPosition(RectTransform target, Vector2 startValue, Vector2 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2817CC8", Offset = "0x2817CC8", VA = "0x2817CC8")]
		public static TweenBase LocalPosition(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2817EAC", Offset = "0x2817EAC", VA = "0x2817EAC")]
		public static TweenBase LocalPosition(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2817FAC", Offset = "0x2817FAC", VA = "0x2817FAC")]
		public static TweenBase Rotate(Transform target, Vector3 amount, Space space, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x28181B0", Offset = "0x28181B0", VA = "0x28181B0")]
		public static TweenBase Rotation(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x28183E0", Offset = "0x28183E0", VA = "0x28183E0")]
		public static TweenBase Rotation(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2818570", Offset = "0x2818570", VA = "0x2818570")]
		public static TweenBase Rotation(Transform target, Quaternion endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x28186C4", Offset = "0x28186C4", VA = "0x28186C4")]
		public static TweenBase Rotation(Transform target, Quaternion startValue, Quaternion endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x28187D4", Offset = "0x28187D4", VA = "0x28187D4")]
		public static TweenBase LocalRotation(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2818A04", Offset = "0x2818A04", VA = "0x2818A04")]
		public static TweenBase LocalRotation(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2818B94", Offset = "0x2818B94", VA = "0x2818B94")]
		public static TweenBase LocalRotation(Transform target, Quaternion endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2818CE8", Offset = "0x2818CE8", VA = "0x2818CE8")]
		public static TweenBase LocalRotation(Transform target, Quaternion startValue, Quaternion endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2818DF8", Offset = "0x2818DF8", VA = "0x2818DF8")]
		public static TweenBase LookAt(Transform target, Transform targetToLookAt, Vector3 up, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2818F3C", Offset = "0x2818F3C", VA = "0x2818F3C")]
		public static TweenBase LookAt(Transform target, Vector3 positionToLookAt, Vector3 up, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2819064", Offset = "0x2819064", VA = "0x2819064")]
		public static void Stop(int targetInstanceID, TweenType tweenType)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2819214", Offset = "0x2819214", VA = "0x2819214")]
		public static void Stop(int targetInstanceID)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2819384", Offset = "0x2819384", VA = "0x2819384")]
		public static void StopAll()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x28194FC", Offset = "0x28194FC", VA = "0x28194FC")]
		public static void FinishAll()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2819680", Offset = "0x2819680", VA = "0x2819680")]
		public static void Finish(int targetInstanceID)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2819830", Offset = "0x2819830", VA = "0x2819830")]
		public static void Cancel(int targetInstanceID)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x28199E0", Offset = "0x28199E0", VA = "0x28199E0")]
		public static void CancelAll()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2819268", Offset = "0x2819268", VA = "0x2819268")]
		private static void StopInstanceTarget(int id)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x281B7C0", Offset = "0x281B7C0", VA = "0x281B7C0")]
		private static void StopInstanceTargetType(int id, TweenType type)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x28196D4", Offset = "0x28196D4", VA = "0x28196D4")]
		private static void FinishInstanceTarget(int id)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2819884", Offset = "0x2819884", VA = "0x2819884")]
		private static void CancelInstanceTarget(int id)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x281329C", Offset = "0x281329C", VA = "0x281329C")]
		private static void SendTweenForProcessing(TweenBase tween, bool interrupt = false)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x281BA04", Offset = "0x281BA04", VA = "0x281BA04")]
		public Tween()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class Initialization : MonoBehaviour
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StateMachine _stateMachine;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DisplayObject _displayObject;

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x281BAA4", Offset = "0x281BAA4", VA = "0x281BAA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x281BDC4", Offset = "0x281BDC4", VA = "0x281BDC4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x281BE44", Offset = "0x281BE44", VA = "0x281BE44")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x281BBD0", Offset = "0x281BBD0", VA = "0x281BBD0")]
		private void InitializeSingleton()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x281BF6C", Offset = "0x281BF6C", VA = "0x281BF6C")]
		public Initialization()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class LayerMaskHelper
	{
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x281BF74", Offset = "0x281BF74", VA = "0x281BF74")]
		public static int OnlyIncluding(params int[] layers)
		{
			return default(int);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x281BFE0", Offset = "0x281BFE0", VA = "0x281BFE0")]
		public static int Everything()
		{
			return default(int);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x281BFE8", Offset = "0x281BFE8", VA = "0x281BFE8")]
		public static int Default()
		{
			return default(int);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x281BFF0", Offset = "0x281BFF0", VA = "0x281BFF0")]
		public static int Nothing()
		{
			return default(int);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x281BFF8", Offset = "0x281BFF8", VA = "0x281BFF8")]
		public static int EverythingBut(params int[] layers)
		{
			return default(int);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x281C00C", Offset = "0x281C00C", VA = "0x281C00C")]
		public static bool ContainsLayer(LayerMask layerMask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x281BF78", Offset = "0x281BF78", VA = "0x281BF78")]
		private static int MakeMask(params int[] layers)
		{
			return default(int);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x281C044", Offset = "0x281C044", VA = "0x281C044")]
		public LayerMaskHelper()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public static class CoreMath
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x281C04C", Offset = "0x281C04C", VA = "0x281C04C")]
		public static float LinearInterpolate(float from, float to, float percentage)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x281C05C", Offset = "0x281C05C", VA = "0x281C05C")]
		public static Vector2 LinearInterpolate(Vector2 from, Vector2 to, float percentage)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x281C078", Offset = "0x281C078", VA = "0x281C078")]
		public static Vector3 LinearInterpolate(Vector3 from, Vector3 to, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x281C0A0", Offset = "0x281C0A0", VA = "0x281C0A0")]
		public static Vector4 LinearInterpolate(Vector4 from, Vector4 to, float percentage)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x281C0D8", Offset = "0x281C0D8", VA = "0x281C0D8")]
		public static Rect LinearInterpolate(Rect from, Rect to, float percentage)
		{
			return default(Rect);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x281C1DC", Offset = "0x281C1DC", VA = "0x281C1DC")]
		public static Color LinearInterpolate(Color from, Color to, float percentage)
		{
			return default(Color);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x281C214", Offset = "0x281C214", VA = "0x281C214")]
		public static float EvaluateCurve(AnimationCurve curve, float percentage)
		{
			return default(float);
		}
	}
}
namespace Pixelplacement.TweenSystem
{
	[Token(Token = "0x2000021")]
	public abstract class TweenBase
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int targetInstanceID;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Tween.TweenType tweenType;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected float elapsedTime;

		[Token(Token = "0x17000023")]
		public Tween.TweenStatus Status
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x281C294", Offset = "0x281C294", VA = "0x281C294")]
			[CompilerGenerated]
			get
			{
				return default(Tween.TweenStatus);
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x281C29C", Offset = "0x281C29C", VA = "0x281C29C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public float Duration
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x281C2A4", Offset = "0x281C2A4", VA = "0x281C2A4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x281C2AC", Offset = "0x281C2AC", VA = "0x281C2AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public AnimationCurve Curve
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x281C2B4", Offset = "0x281C2B4", VA = "0x281C2B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x281C2BC", Offset = "0x281C2BC", VA = "0x281C2BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Keyframe[] CurveKeys
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x281C2C4", Offset = "0x281C2C4", VA = "0x281C2C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x281C2CC", Offset = "0x281C2CC", VA = "0x281C2CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public bool ObeyTimescale
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x281C2D4", Offset = "0x281C2D4", VA = "0x281C2D4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x281C2DC", Offset = "0x281C2DC", VA = "0x281C2DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Action StartCallback
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x281C2E8", Offset = "0x281C2E8", VA = "0x281C2E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x281C2F0", Offset = "0x281C2F0", VA = "0x281C2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public Action CompleteCallback
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x281C2F8", Offset = "0x281C2F8", VA = "0x281C2F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x281C300", Offset = "0x281C300", VA = "0x281C300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float Delay
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x281C308", Offset = "0x281C308", VA = "0x281C308")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x281C310", Offset = "0x281C310", VA = "0x281C310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Tween.LoopType LoopType
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x281C318", Offset = "0x281C318", VA = "0x281C318")]
			[CompilerGenerated]
			get
			{
				return default(Tween.LoopType);
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x281C320", Offset = "0x281C320", VA = "0x281C320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public float Percentage
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x281C328", Offset = "0x281C328", VA = "0x281C328")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x281C330", Offset = "0x281C330", VA = "0x281C330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2819208", Offset = "0x2819208", VA = "0x2819208")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x281C5E8", Offset = "0x281C5E8", VA = "0x281C5E8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x281C684", Offset = "0x281C684", VA = "0x281C684")]
		public void Resume()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x281C704", Offset = "0x281C704", VA = "0x281C704")]
		public void Rewind()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2819B58", Offset = "0x2819B58", VA = "0x2819B58")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2819674", Offset = "0x2819674", VA = "0x2819674")]
		public void Finish()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x281C338", Offset = "0x281C338", VA = "0x281C338")]
		public void Tick()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x281C730", Offset = "0x281C730", VA = "0x281C730")]
		private void CleanUp()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x281C880", Offset = "0x281C880", VA = "0x281C880")]
		protected void ResetStartTime()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x281C890", Offset = "0x281C890", VA = "0x281C890")]
		protected void SetEssentials(Tween.TweenType tweenType, int targetInstanceID, float duration, float delay, bool obeyTimeScale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600010C")]
		protected abstract bool SetStartValue();

		[Token(Token = "0x600010D")]
		protected abstract void Operation(float percentage);

		[Token(Token = "0x600010E")]
		public abstract void Loop();

		[Token(Token = "0x600010F")]
		public abstract void PingPong();

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x281C954", Offset = "0x281C954", VA = "0x281C954")]
		protected TweenBase()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class TweenEngine : MonoBehaviour
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x281B92C", Offset = "0x281B92C", VA = "0x281B92C")]
		public void ExecuteTween(TweenBase tween)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x281C95C", Offset = "0x281C95C", VA = "0x281C95C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x281CA1C", Offset = "0x281CA1C", VA = "0x281CA1C")]
		public TweenEngine()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class TweenUtilities : MonoBehaviour
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x281CA24", Offset = "0x281CA24", VA = "0x281CA24")]
		public static void GenerateAnimationCurvePropertyCode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x281CF30", Offset = "0x281CF30", VA = "0x281CF30")]
		public static float LinearInterpolate(float from, float to, float percentage)
		{
			return default(float);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x281CF40", Offset = "0x281CF40", VA = "0x281CF40")]
		public static Vector2 LinearInterpolate(Vector2 from, Vector2 to, float percentage)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x281CF5C", Offset = "0x281CF5C", VA = "0x281CF5C")]
		public static Vector3 LinearInterpolate(Vector3 from, Vector3 to, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x281CF84", Offset = "0x281CF84", VA = "0x281CF84")]
		public static Vector3 LinearInterpolateRotational(Vector3 from, Vector3 to, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x281D104", Offset = "0x281D104", VA = "0x281D104")]
		public static Vector4 LinearInterpolate(Vector4 from, Vector4 to, float percentage)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x281D13C", Offset = "0x281D13C", VA = "0x281D13C")]
		public static Rect LinearInterpolate(Rect from, Rect to, float percentage)
		{
			return default(Rect);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x281D240", Offset = "0x281D240", VA = "0x281D240")]
		public static Color LinearInterpolate(Color from, Color to, float percentage)
		{
			return default(Color);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x281C800", Offset = "0x281C800", VA = "0x281C800")]
		public static float EvaluateCurve(AnimationCurve curve, float percentage)
		{
			return default(float);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x281D0A0", Offset = "0x281D0A0", VA = "0x281D0A0")]
		private static float CylindricalLerp(float from, float to, float percentage)
		{
			return default(float);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x281D278", Offset = "0x281D278", VA = "0x281D278")]
		public TweenUtilities()
		{
		}
	}
	[Token(Token = "0x2000024")]
	internal class AnchoredPosition : TweenBase
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _target;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector2 _start;

		[Token(Token = "0x1700002D")]
		public Vector2 EndValue
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x281D280", Offset = "0x281D280", VA = "0x281D280")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x281D288", Offset = "0x281D288", VA = "0x281D288")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2817B1C", Offset = "0x2817B1C", VA = "0x2817B1C")]
		public AnchoredPosition(RectTransform target, Vector2 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x281D290", Offset = "0x281D290", VA = "0x281D290", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x281D31C", Offset = "0x281D31C", VA = "0x281D31C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x281D354", Offset = "0x281D354", VA = "0x281D354", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x281D384", Offset = "0x281D384", VA = "0x281D384", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000025")]
	internal class CameraBackgroundColor : TweenBase
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Camera _target;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x1700002E")]
		public Color EndValue
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x281D3D0", Offset = "0x281D3D0", VA = "0x281D3D0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x281D3DC", Offset = "0x281D3DC", VA = "0x281D3DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2817550", Offset = "0x2817550", VA = "0x2817550")]
		public CameraBackgroundColor(Camera target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x281D3E8", Offset = "0x281D3E8", VA = "0x281D3E8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x281D478", Offset = "0x281D478", VA = "0x281D478", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x281D4B8", Offset = "0x281D4B8", VA = "0x281D4B8", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x281D4EC", Offset = "0x281D4EC", VA = "0x281D4EC", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000026")]
	internal class CanvasGroupAlpha : TweenBase
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CanvasGroup _target;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x1700002F")]
		public float EndValue
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x281D544", Offset = "0x281D544", VA = "0x281D544")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x281D54C", Offset = "0x281D54C", VA = "0x281D54C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x281369C", Offset = "0x281369C", VA = "0x281369C")]
		public CanvasGroupAlpha(CanvasGroup target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x281D554", Offset = "0x281D554", VA = "0x281D554", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x281D5E0", Offset = "0x281D5E0", VA = "0x281D5E0", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x281D614", Offset = "0x281D614", VA = "0x281D614", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x281D644", Offset = "0x281D644", VA = "0x281D644", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000027")]
	internal class FieldOfView : TweenBase
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Camera _target;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x17000030")]
		public float EndValue
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x281D694", Offset = "0x281D694", VA = "0x281D694")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x281D69C", Offset = "0x281D69C", VA = "0x281D69C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2815D5C", Offset = "0x2815D5C", VA = "0x2815D5C")]
		public FieldOfView(Camera target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x281D6A4", Offset = "0x281D6A4", VA = "0x281D6A4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x281D730", Offset = "0x281D730", VA = "0x281D730", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x281D764", Offset = "0x281D764", VA = "0x281D764", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x281D794", Offset = "0x281D794", VA = "0x281D794", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000028")]
	internal class GraphicColor : TweenBase
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Graphic _target;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x17000031")]
		public Color EndValue
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x281D7E4", Offset = "0x281D7E4", VA = "0x281D7E4")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x281D7F0", Offset = "0x281D7F0", VA = "0x281D7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x28167F8", Offset = "0x28167F8", VA = "0x28167F8")]
		public GraphicColor(Graphic target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x281D7FC", Offset = "0x281D7FC", VA = "0x281D7FC", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x281D894", Offset = "0x281D894", VA = "0x281D894", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x281D8DC", Offset = "0x281D8DC", VA = "0x281D8DC", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x281D918", Offset = "0x281D918", VA = "0x281D918", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000029")]
	internal class ImageColor : TweenBase
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _target;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x17000032")]
		public Color EndValue
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x281D980", Offset = "0x281D980", VA = "0x281D980")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x281D98C", Offset = "0x281D98C", VA = "0x281D98C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x281D998", Offset = "0x281D998", VA = "0x281D998")]
		public ImageColor(Image target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x281DA70", Offset = "0x281DA70", VA = "0x281DA70", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x281DB08", Offset = "0x281DB08", VA = "0x281DB08", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x281DB50", Offset = "0x281DB50", VA = "0x281DB50", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x281DB8C", Offset = "0x281DB8C", VA = "0x281DB8C", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x200002A")]
	internal class LightColor : TweenBase
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Light _target;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x17000033")]
		public Color EndValue
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x281DBF4", Offset = "0x281DBF4", VA = "0x281DBF4")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x281DC00", Offset = "0x281DC00", VA = "0x281DC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2816B00", Offset = "0x2816B00", VA = "0x2816B00")]
		public LightColor(Light target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x281DC0C", Offset = "0x281DC0C", VA = "0x281DC0C", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x281DC9C", Offset = "0x281DC9C", VA = "0x281DC9C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x281DCDC", Offset = "0x281DCDC", VA = "0x281DCDC", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x281DD10", Offset = "0x281DD10", VA = "0x281DD10", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x200002B")]
	internal class LightIntensity : TweenBase
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light _target;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x17000034")]
		public float EndValue
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x281DD68", Offset = "0x281DD68", VA = "0x281DD68")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x281DD70", Offset = "0x281DD70", VA = "0x281DD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x281626C", Offset = "0x281626C", VA = "0x281626C")]
		public LightIntensity(Light target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x281DD78", Offset = "0x281DD78", VA = "0x281DD78", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x281DE04", Offset = "0x281DE04", VA = "0x281DE04", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x281DE38", Offset = "0x281DE38", VA = "0x281DE38", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x281DE68", Offset = "0x281DE68", VA = "0x281DE68", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x200002C")]
	internal class LightRange : TweenBase
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light _target;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x17000035")]
		public float EndValue
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x281DEB8", Offset = "0x281DEB8", VA = "0x281DEB8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x281DEC0", Offset = "0x281DEC0", VA = "0x281DEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2815FE4", Offset = "0x2815FE4", VA = "0x2815FE4")]
		public LightRange(Light target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x281DEC8", Offset = "0x281DEC8", VA = "0x281DEC8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x281DF54", Offset = "0x281DF54", VA = "0x281DF54", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x281DF88", Offset = "0x281DF88", VA = "0x281DF88", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x281DFB8", Offset = "0x281DFB8", VA = "0x281DFB8", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x200002D")]
	internal class LocalPosition : TweenBase
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x17000036")]
		public Vector3 EndValue
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x281E008", Offset = "0x281E008", VA = "0x281E008")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x281E014", Offset = "0x281E014", VA = "0x281E014")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2817DD8", Offset = "0x2817DD8", VA = "0x2817DD8")]
		public LocalPosition(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x281E020", Offset = "0x281E020", VA = "0x281E020", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x281E0B0", Offset = "0x281E0B0", VA = "0x281E0B0", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x281E0FC", Offset = "0x281E0FC", VA = "0x281E0FC", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x281E130", Offset = "0x281E130", VA = "0x281E130", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x200002E")]
	internal class LocalRotation : TweenBase
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x17000037")]
		public Vector3 EndValue
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x281E18C", Offset = "0x281E18C", VA = "0x281E18C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x281E198", Offset = "0x281E198", VA = "0x281E198")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2818930", Offset = "0x2818930", VA = "0x2818930")]
		public LocalRotation(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x281E1A4", Offset = "0x281E1A4", VA = "0x281E1A4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x281E234", Offset = "0x281E234", VA = "0x281E234", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x281E290", Offset = "0x281E290", VA = "0x281E290", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x281E2C4", Offset = "0x281E2C4", VA = "0x281E2C4", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x200002F")]
	internal class LocalScale : TweenBase
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x17000038")]
		public Vector3 EndValue
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x281E320", Offset = "0x281E320", VA = "0x281E320")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x281E32C", Offset = "0x281E32C", VA = "0x281E32C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x281650C", Offset = "0x281650C", VA = "0x281650C")]
		public LocalScale(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x281E338", Offset = "0x281E338", VA = "0x281E338", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x281E3C8", Offset = "0x281E3C8", VA = "0x281E3C8", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x281E414", Offset = "0x281E414", VA = "0x281E414", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x281E448", Offset = "0x281E448", VA = "0x281E448", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000030")]
	internal class PanStereo : TweenBase
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource _target;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x17000039")]
		public float EndValue
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x281E4A4", Offset = "0x281E4A4", VA = "0x281E4A4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x281E4AC", Offset = "0x281E4AC", VA = "0x281E4AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x28155A0", Offset = "0x28155A0", VA = "0x28155A0")]
		public PanStereo(AudioSource target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x281E4B4", Offset = "0x281E4B4", VA = "0x281E4B4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x281E540", Offset = "0x281E540", VA = "0x281E540", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x281E574", Offset = "0x281E574", VA = "0x281E574", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x281E5A4", Offset = "0x281E5A4", VA = "0x281E5A4", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000031")]
	internal class Pitch : TweenBase
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource _target;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x1700003A")]
		public float EndValue
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x281E5F4", Offset = "0x281E5F4", VA = "0x281E5F4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x281E5FC", Offset = "0x281E5FC", VA = "0x281E5FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2815318", Offset = "0x2815318", VA = "0x2815318")]
		public Pitch(AudioSource target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x281E604", Offset = "0x281E604", VA = "0x281E604", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x281E690", Offset = "0x281E690", VA = "0x281E690", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x281E6C4", Offset = "0x281E6C4", VA = "0x281E6C4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x281E6F4", Offset = "0x281E6F4", VA = "0x281E6F4", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000032")]
	internal class Position : TweenBase
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x1700003B")]
		public Vector3 EndValue
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x281E744", Offset = "0x281E744", VA = "0x281E744")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x281E750", Offset = "0x281E750", VA = "0x281E750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2817848", Offset = "0x2817848", VA = "0x2817848")]
		public Position(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x281E75C", Offset = "0x281E75C", VA = "0x281E75C", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x281E7EC", Offset = "0x281E7EC", VA = "0x281E7EC", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x281E838", Offset = "0x281E838", VA = "0x281E838", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x281E86C", Offset = "0x281E86C", VA = "0x281E86C", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000033")]
	internal class RawImageColor : TweenBase
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RawImage _target;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x1700003C")]
		public Color EndValue
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x281E8C8", Offset = "0x281E8C8", VA = "0x281E8C8")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x281E8D4", Offset = "0x281E8D4", VA = "0x281E8D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x281E8E0", Offset = "0x281E8E0", VA = "0x281E8E0")]
		public RawImageColor(RawImage target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x281E9B8", Offset = "0x281E9B8", VA = "0x281E9B8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x281EA50", Offset = "0x281EA50", VA = "0x281EA50", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x281EA98", Offset = "0x281EA98", VA = "0x281EA98", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x281EAD4", Offset = "0x281EAD4", VA = "0x281EAD4", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000034")]
	internal class Rotate : TweenBase
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Space _space;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 _previous;

		[Token(Token = "0x1700003D")]
		public Vector3 EndValue
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x281EB3C", Offset = "0x281EB3C", VA = "0x281EB3C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x281EB48", Offset = "0x281EB48", VA = "0x281EB48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x28180CC", Offset = "0x28180CC", VA = "0x28180CC")]
		public Rotate(Transform target, Vector3 endValue, Space space, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x281EB54", Offset = "0x281EB54", VA = "0x281EB54", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x281EBE4", Offset = "0x281EBE4", VA = "0x281EBE4", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x281ECC0", Offset = "0x281ECC0", VA = "0x281ECC0", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x281ED24", Offset = "0x281ED24", VA = "0x281ED24", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000035")]
	internal class Rotation : TweenBase
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x1700003E")]
		public Vector3 EndValue
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x281EDA0", Offset = "0x281EDA0", VA = "0x281EDA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x281EDAC", Offset = "0x281EDAC", VA = "0x281EDAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x281830C", Offset = "0x281830C", VA = "0x281830C")]
		public Rotation(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x281EDB8", Offset = "0x281EDB8", VA = "0x281EDB8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x281EE48", Offset = "0x281EE48", VA = "0x281EE48", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x281EEA4", Offset = "0x281EEA4", VA = "0x281EEA4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x281EED8", Offset = "0x281EED8", VA = "0x281EED8", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000036")]
	internal class ShaderColor : TweenBase
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material _target;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string _propertyName;

		[Token(Token = "0x1700003F")]
		public Color EndValue
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x281EF34", Offset = "0x281EF34", VA = "0x281EF34")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x281EF40", Offset = "0x281EF40", VA = "0x281EF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2814D48", Offset = "0x2814D48", VA = "0x2814D48")]
		public ShaderColor(Material target, string propertyName, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x281EF4C", Offset = "0x281EF4C", VA = "0x281EF4C", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x281EFD8", Offset = "0x281EFD8", VA = "0x281EFD8", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x281F01C", Offset = "0x281F01C", VA = "0x281F01C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x281F054", Offset = "0x281F054", VA = "0x281F054", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000037")]
	internal class ShaderFloat : TweenBase
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material _target;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _propertyName;

		[Token(Token = "0x17000040")]
		public float EndValue
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x281F0B4", Offset = "0x281F0B4", VA = "0x281F0B4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x281F0BC", Offset = "0x281F0BC", VA = "0x281F0BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2815060", Offset = "0x2815060", VA = "0x2815060")]
		public ShaderFloat(Material target, string propertyName, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x281F0C4", Offset = "0x281F0C4", VA = "0x281F0C4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x281F14C", Offset = "0x281F14C", VA = "0x281F14C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x281F184", Offset = "0x281F184", VA = "0x281F184", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x281F1B8", Offset = "0x281F1B8", VA = "0x281F1B8", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000038")]
	internal class ShaderInt : TweenBase
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material _target;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _start;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _propertyName;

		[Token(Token = "0x17000041")]
		public int EndValue
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x281F210", Offset = "0x281F210", VA = "0x281F210")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x281F218", Offset = "0x281F218", VA = "0x281F218")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2814A68", Offset = "0x2814A68", VA = "0x2814A68")]
		public ShaderInt(Material target, string propertyName, int endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x281F220", Offset = "0x281F220", VA = "0x281F220", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x281F2A8", Offset = "0x281F2A8", VA = "0x281F2A8", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x281F300", Offset = "0x281F300", VA = "0x281F300", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x281F334", Offset = "0x281F334", VA = "0x281F334", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000039")]
	internal class ShaderVector : TweenBase
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material _target;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector4 _start;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string _propertyName;

		[Token(Token = "0x17000042")]
		public Vector4 EndValue
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x281F38C", Offset = "0x281F38C", VA = "0x281F38C")]
			[CompilerGenerated]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x281F398", Offset = "0x281F398", VA = "0x281F398")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2814750", Offset = "0x2814750", VA = "0x2814750")]
		public ShaderVector(Material target, string propertyName, Vector4 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x281F3A4", Offset = "0x281F3A4", VA = "0x281F3A4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x281F438", Offset = "0x281F438", VA = "0x281F438", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x281F47C", Offset = "0x281F47C", VA = "0x281F47C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x281F4B4", Offset = "0x281F4B4", VA = "0x281F4B4", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x200003A")]
	internal class ShakePosition : TweenBase
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _initialPosition;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 _intensity;

		[Token(Token = "0x17000043")]
		public Vector3 EndValue
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x281F514", Offset = "0x281F514", VA = "0x281F514")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x281F520", Offset = "0x281F520", VA = "0x281F520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x28131B0", Offset = "0x28131B0", VA = "0x28131B0")]
		public ShakePosition(Transform target, Vector3 initialPosition, Vector3 intensity, float duration, float delay, AnimationCurve curve, Action startCallback, Action completeCallback, Tween.LoopType loop, bool obeyTimescale)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x281F52C", Offset = "0x281F52C", VA = "0x281F52C", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x281F598", Offset = "0x281F598", VA = "0x281F598", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x281F65C", Offset = "0x281F65C", VA = "0x281F65C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x281F690", Offset = "0x281F690", VA = "0x281F690", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x200003B")]
	internal class Size : TweenBase
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _target;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector2 _start;

		[Token(Token = "0x17000044")]
		public Vector2 EndValue
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x281F694", Offset = "0x281F694", VA = "0x281F694")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x281F69C", Offset = "0x281F69C", VA = "0x281F69C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2815AB8", Offset = "0x2815AB8", VA = "0x2815AB8")]
		public Size(RectTransform target, Vector2 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x281F6A4", Offset = "0x281F6A4", VA = "0x281F6A4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x281F730", Offset = "0x281F730", VA = "0x281F730", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x281F768", Offset = "0x281F768", VA = "0x281F768", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x281F798", Offset = "0x281F798", VA = "0x281F798", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x200003C")]
	internal class SplinePercentage : TweenBase
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform _target;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Spline _spline;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _startPercentage;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool _faceDirection;

		[Token(Token = "0x17000045")]
		public float EndValue
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x281F7E4", Offset = "0x281F7E4", VA = "0x281F7E4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x281F7EC", Offset = "0x281F7EC", VA = "0x281F7EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2813478", Offset = "0x2813478", VA = "0x2813478")]
		public SplinePercentage(Spline spline, Transform target, float startPercentage, float endPercentage, bool faceDirection, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x281F7F4", Offset = "0x281F7F4", VA = "0x281F7F4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x281F860", Offset = "0x281F860", VA = "0x281F860", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x281F94C", Offset = "0x281F94C", VA = "0x281F94C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x281F990", Offset = "0x281F990", VA = "0x281F990", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x200003D")]
	internal class SpriteRendererColor : TweenBase
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SpriteRenderer _target;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x17000046")]
		public Color EndValue
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x281F9B0", Offset = "0x281F9B0", VA = "0x281F9B0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x281F9BC", Offset = "0x281F9BC", VA = "0x281F9BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2817250", Offset = "0x2817250", VA = "0x2817250")]
		public SpriteRendererColor(SpriteRenderer target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x281F9C8", Offset = "0x281F9C8", VA = "0x281F9C8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x281FA58", Offset = "0x281FA58", VA = "0x281FA58", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x281FA98", Offset = "0x281FA98", VA = "0x281FA98", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x281FACC", Offset = "0x281FACC", VA = "0x281FACC", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x200003E")]
	internal class TextColor : TweenBase
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Text _target;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x17000047")]
		public Color EndValue
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x281FB24", Offset = "0x281FB24", VA = "0x281FB24")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x281FB30", Offset = "0x281FB30", VA = "0x281FB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x281FB3C", Offset = "0x281FB3C", VA = "0x281FB3C")]
		public TextColor(Text target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x281FC14", Offset = "0x281FC14", VA = "0x281FC14", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x281FCAC", Offset = "0x281FCAC", VA = "0x281FCAC", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x281FCF4", Offset = "0x281FCF4", VA = "0x281FCF4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x281FD30", Offset = "0x281FD30", VA = "0x281FD30", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x200003F")]
	internal class TextMeshColor : TweenBase
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMesh _target;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x17000048")]
		public Color EndValue
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x281FD98", Offset = "0x281FD98", VA = "0x281FD98")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x281FDA4", Offset = "0x281FDA4", VA = "0x281FDA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x281FDB0", Offset = "0x281FDB0", VA = "0x281FDB0")]
		public TextMeshColor(TextMesh target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x281FE88", Offset = "0x281FE88", VA = "0x281FE88", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x281FF18", Offset = "0x281FF18", VA = "0x281FF18", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x281FF58", Offset = "0x281FF58", VA = "0x281FF58", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x281FF8C", Offset = "0x281FF8C", VA = "0x281FF8C", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000040")]
	internal class ValueColor : TweenBase
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<Color> _valueUpdatedCallback;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x17000049")]
		public Color EndValue
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x281FFE4", Offset = "0x281FFE4", VA = "0x281FFE4")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x281FFF0", Offset = "0x281FFF0", VA = "0x281FFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x28141C4", Offset = "0x28141C4", VA = "0x28141C4")]
		public ValueColor(Color startValue, Color endValue, Action<Color> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x281FFFC", Offset = "0x281FFFC", VA = "0x281FFFC", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2820004", Offset = "0x2820004", VA = "0x2820004", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2820048", Offset = "0x2820048", VA = "0x2820048", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2820058", Offset = "0x2820058", VA = "0x2820058", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000041")]
	internal class ValueFloat : TweenBase
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action<float> _valueUpdatedCallback;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x1700004A")]
		public float EndValue
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x2820078", Offset = "0x2820078", VA = "0x2820078")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x2820080", Offset = "0x2820080", VA = "0x2820080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2814574", Offset = "0x2814574", VA = "0x2814574")]
		public ValueFloat(float startValue, float endValue, Action<float> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2820088", Offset = "0x2820088", VA = "0x2820088", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2820090", Offset = "0x2820090", VA = "0x2820090", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x28200C8", Offset = "0x28200C8", VA = "0x28200C8", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x28200D8", Offset = "0x28200D8", VA = "0x28200D8", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000042")]
	internal class ValueInt : TweenBase
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action<int> _valueUpdatedCallback;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x1700004B")]
		public float EndValue
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x28200F8", Offset = "0x28200F8", VA = "0x28200F8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x2820100", Offset = "0x2820100", VA = "0x2820100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x28143B8", Offset = "0x28143B8", VA = "0x28143B8")]
		public ValueInt(int startValue, int endValue, Action<int> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2820108", Offset = "0x2820108", VA = "0x2820108", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2820110", Offset = "0x2820110", VA = "0x2820110", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2820160", Offset = "0x2820160", VA = "0x2820160", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2820170", Offset = "0x2820170", VA = "0x2820170", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000043")]
	internal class ValueRect : TweenBase
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<Rect> _valueUpdatedCallback;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rect _start;

		[Token(Token = "0x1700004C")]
		public Rect EndValue
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x2820190", Offset = "0x2820190", VA = "0x2820190")]
			[CompilerGenerated]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x282019C", Offset = "0x282019C", VA = "0x282019C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2813974", Offset = "0x2813974", VA = "0x2813974")]
		public ValueRect(Rect startValue, Rect endValue, Action<Rect> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x28201A8", Offset = "0x28201A8", VA = "0x28201A8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x28201B0", Offset = "0x28201B0", VA = "0x28201B0", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x28201FC", Offset = "0x28201FC", VA = "0x28201FC", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x282020C", Offset = "0x282020C", VA = "0x282020C", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000044")]
	internal class ValueVector2 : TweenBase
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action<Vector2> _valueUpdatedCallback;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector2 _start;

		[Token(Token = "0x1700004D")]
		public Vector2 EndValue
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x282022C", Offset = "0x282022C", VA = "0x282022C")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x2820234", Offset = "0x2820234", VA = "0x2820234")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2813FB8", Offset = "0x2813FB8", VA = "0x2813FB8")]
		public ValueVector2(Vector2 startValue, Vector2 endValue, Action<Vector2> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x282023C", Offset = "0x282023C", VA = "0x282023C", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2820244", Offset = "0x2820244", VA = "0x2820244", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2820280", Offset = "0x2820280", VA = "0x2820280", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2820290", Offset = "0x2820290", VA = "0x2820290", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000045")]
	internal class ValueVector3 : TweenBase
	{
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<Vector3> _valueUpdatedCallback;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x1700004E")]
		public Vector3 EndValue
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x28202B0", Offset = "0x28202B0", VA = "0x28202B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x28202BC", Offset = "0x28202BC", VA = "0x28202BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2813DC4", Offset = "0x2813DC4", VA = "0x2813DC4")]
		public ValueVector3(Vector3 startValue, Vector3 endValue, Action<Vector3> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x28202C8", Offset = "0x28202C8", VA = "0x28202C8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x28202D0", Offset = "0x28202D0", VA = "0x28202D0", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2820320", Offset = "0x2820320", VA = "0x2820320", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2820330", Offset = "0x2820330", VA = "0x2820330", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000046")]
	internal class ValueVector4 : TweenBase
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<Vector4> _valueUpdatedCallback;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector4 _start;

		[Token(Token = "0x1700004F")]
		public Vector4 EndValue
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x2820360", Offset = "0x2820360", VA = "0x2820360")]
			[CompilerGenerated]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x282036C", Offset = "0x282036C", VA = "0x282036C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2813BA8", Offset = "0x2813BA8", VA = "0x2813BA8")]
		public ValueVector4(Vector4 startValue, Vector4 endValue, Action<Vector4> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2820378", Offset = "0x2820378", VA = "0x2820378", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2820380", Offset = "0x2820380", VA = "0x2820380", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x28203C4", Offset = "0x28203C4", VA = "0x28203C4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x28203D4", Offset = "0x28203D4", VA = "0x28203D4", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x2000047")]
	internal class Volume : TweenBase
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource _target;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x17000050")]
		public float EndValue
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x28203F4", Offset = "0x28203F4", VA = "0x28203F4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x28203FC", Offset = "0x28203FC", VA = "0x28203FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2815828", Offset = "0x2815828", VA = "0x2815828")]
		public Volume(AudioSource target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2820404", Offset = "0x2820404", VA = "0x2820404", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2820490", Offset = "0x2820490", VA = "0x2820490", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x28204C4", Offset = "0x28204C4", VA = "0x28204C4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x28204F4", Offset = "0x28204F4", VA = "0x28204F4", Slot = "7")]
		public override void PingPong()
		{
		}
	}
}
