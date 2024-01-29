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
	[Address(RVA = "0x2B6F778", Offset = "0x2B6F778", VA = "0x2B6F778")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2B70294", Offset = "0x2B70294", VA = "0x2B70294")]
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
		[Address(RVA = "0x2B702B0", Offset = "0x2B702B0", VA = "0x2B702B0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2B702B8", Offset = "0x2B702B8", VA = "0x2B702B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2B702C4", Offset = "0x2B702C4", VA = "0x2B702C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2B70458", Offset = "0x2B70458", VA = "0x2B70458")]
	public void ForceDistance(float distance)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2B70474", Offset = "0x2B70474", VA = "0x2B70474")]
	public void ForceMoveToDistance()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2B70550", Offset = "0x2B70550", VA = "0x2B70550")]
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
	[Address(RVA = "0x2B70574", Offset = "0x2B70574", VA = "0x2B70574")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2B70680", Offset = "0x2B70680", VA = "0x2B70680")]
	public SplineFollowerEditor()
	{
	}
}
[Token(Token = "0x2000005")]
public class SplineTween : MonoBehaviour
{
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2B70690", Offset = "0x2B70690", VA = "0x2B70690")]
	private void Start()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2B70694", Offset = "0x2B70694", VA = "0x2B70694")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2B70698", Offset = "0x2B70698", VA = "0x2B70698")]
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
			[Address(RVA = "0x2B706A0", Offset = "0x2B706A0", VA = "0x2B706A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public bool IsHitting
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2B706F0", Offset = "0x2B706F0", VA = "0x2B706F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2B706F8", Offset = "0x2B706F8", VA = "0x2B706F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2B70704", Offset = "0x2B70704", VA = "0x2B70704")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2B70794", Offset = "0x2B70794", VA = "0x2B70794")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2B708F0", Offset = "0x2B708F0", VA = "0x2B708F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2B709C0", Offset = "0x2B709C0", VA = "0x2B709C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2B70B34", Offset = "0x2B70B34", VA = "0x2B70B34")]
		public void Pressed()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2B70D84", Offset = "0x2B70D84", VA = "0x2B70D84")]
		public void Released()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2B70FD4", Offset = "0x2B70FD4", VA = "0x2B70FD4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2B722A4", Offset = "0x2B722A4", VA = "0x2B722A4")]
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
			[Address(RVA = "0x2B72390", Offset = "0x2B72390", VA = "0x2B72390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2B723B0", Offset = "0x2B723B0", VA = "0x2B723B0")]
			set
			{
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2B723E8", Offset = "0x2B723E8", VA = "0x2B723E8")]
		public void Register()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2B723B8", Offset = "0x2B723B8", VA = "0x2B723B8")]
		public void SetActive(bool value)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2B72424", Offset = "0x2B72424", VA = "0x2B72424")]
		public void Solo()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2B72934", Offset = "0x2B72934", VA = "0x2B72934")]
		public void HideAll()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2B72DB8", Offset = "0x2B72DB8", VA = "0x2B72DB8")]
		public DisplayObject()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public class GameObjectEvent : UnityEvent<GameObject>
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2B72DC0", Offset = "0x2B72DC0", VA = "0x2B72DC0")]
		public GameObjectEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class ColliderButtonEvent : UnityEvent
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2B72E08", Offset = "0x2B72E08", VA = "0x2B72E08")]
		public ColliderButtonEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class BoolEvent : UnityEvent<bool>
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2B72E10", Offset = "0x2B72E10", VA = "0x2B72E10")]
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
		[Address(RVA = "0x2B72E58", Offset = "0x2B72E58", VA = "0x2B72E58")]
		public static Vector3 GetPoint(Vector3 startPosition, Vector3 controlPoint, Vector3 endPosition, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2B72ECC", Offset = "0x2B72ECC", VA = "0x2B72ECC")]
		public static Vector3 GetFirstDerivative(Vector3 startPoint, Vector3 controlPoint, Vector3 endPosition, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2B72F38", Offset = "0x2B72F38", VA = "0x2B72F38")]
		public static Vector3 GetPoint(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float percentage, bool evenDistribution, int distributionSteps)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2B73354", Offset = "0x2B73354", VA = "0x2B73354")]
		public static Vector3 GetFirstDerivative(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2B732A8", Offset = "0x2B732A8", VA = "0x2B732A8")]
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
		[Address(RVA = "0x2B73404", Offset = "0x2B73404", VA = "0x2B73404")]
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
			[Address(RVA = "0x2B747BC", Offset = "0x2B747BC", VA = "0x2B747BC")]
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
			[Address(RVA = "0x2B73548", Offset = "0x2B73548", VA = "0x2B73548")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2B73550", Offset = "0x2B73550", VA = "0x2B73550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public SplineAnchor[] Anchors
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2B73558", Offset = "0x2B73558", VA = "0x2B73558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public Color SecondaryColor
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2B73704", Offset = "0x2B73704", VA = "0x2B73704")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action OnSplineChanged
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2B73410", Offset = "0x2B73410", VA = "0x2B73410")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2B734AC", Offset = "0x2B734AC", VA = "0x2B734AC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2B73738", Offset = "0x2B73738", VA = "0x2B73738")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2B73E50", Offset = "0x2B73E50", VA = "0x2B73E50")]
		private void Update()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2B7434C", Offset = "0x2B7434C", VA = "0x2B7434C")]
		private void HangleLengthChange()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2B74370", Offset = "0x2B74370", VA = "0x2B74370")]
		private float Reparam(float percent)
		{
			return default(float);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2B744F4", Offset = "0x2B744F4", VA = "0x2B744F4")]
		public void CalculateLength()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2B7003C", Offset = "0x2B7003C", VA = "0x2B7003C")]
		public Vector3 Up(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2B747E8", Offset = "0x2B747E8", VA = "0x2B747E8")]
		public Vector3 Right(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2B74870", Offset = "0x2B74870", VA = "0x2B74870")]
		public Vector3 Forward(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2B6FDFC", Offset = "0x2B6FDFC", VA = "0x2B6FDFC")]
		public Vector3 GetDirection(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2B700C4", Offset = "0x2B700C4", VA = "0x2B700C4")]
		public Vector3 GetPosition(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2B74A38", Offset = "0x2B74A38", VA = "0x2B74A38")]
		public Vector3 GetPosition(float percentage, Vector3 relativeOffset, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2B74C30", Offset = "0x2B74C30", VA = "0x2B74C30")]
		public float ClosestPoint(Vector3 point, int divisions = 100)
		{
			return default(float);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2B73784", Offset = "0x2B73784", VA = "0x2B73784")]
		public GameObject[] AddAnchors(int count)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2B74878", Offset = "0x2B74878", VA = "0x2B74878")]
		public CurveDetail GetCurve(float percentage)
		{
			return default(CurveDetail);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2B74D30", Offset = "0x2B74D30", VA = "0x2B74D30")]
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
			[Address(RVA = "0x2B74DE0", Offset = "0x2B74DE0", VA = "0x2B74DE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2B74DE8", Offset = "0x2B74DE8", VA = "0x2B74DE8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public bool Changed
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2B74DF4", Offset = "0x2B74DF4", VA = "0x2B74DF4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2B74DFC", Offset = "0x2B74DFC", VA = "0x2B74DFC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Transform Anchor
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2B749CC", Offset = "0x2B749CC", VA = "0x2B749CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2B75240", Offset = "0x2B75240", VA = "0x2B75240")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Transform InTangent
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2B74A14", Offset = "0x2B74A14", VA = "0x2B74A14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2B75248", Offset = "0x2B75248", VA = "0x2B75248")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Transform OutTangent
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2B749F0", Offset = "0x2B749F0", VA = "0x2B749F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2B75250", Offset = "0x2B75250", VA = "0x2B75250")]
			private set
			{
			}
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2B75258", Offset = "0x2B75258", VA = "0x2B75258")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2B7525C", Offset = "0x2B7525C", VA = "0x2B7525C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2B75584", Offset = "0x2B75584", VA = "0x2B75584")]
		private void TangentChanged()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2B74E08", Offset = "0x2B74E08", VA = "0x2B74E08")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2B742CC", Offset = "0x2B742CC", VA = "0x2B742CC")]
		public void SetTangentStatus(bool inStatus, bool outStatus)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2B7587C", Offset = "0x2B7587C", VA = "0x2B7587C")]
		public void Tilt(Vector3 angles)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2B75998", Offset = "0x2B75998", VA = "0x2B75998")]
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
			[Address(RVA = "0x2B74144", Offset = "0x2B74144", VA = "0x2B74144")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2B7417C", Offset = "0x2B7417C", VA = "0x2B7417C")]
		public void UpdateOrientation(Spline spline)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2B759A0", Offset = "0x2B759A0", VA = "0x2B759A0")]
		public SplineFollower()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[SelectionBase]
	public class SplineTangent : MonoBehaviour
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2B759B0", Offset = "0x2B759B0", VA = "0x2B759B0")]
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
		[Address(RVA = "0x2B759B8", Offset = "0x2B759B8", VA = "0x2B759B8")]
		private void Reset()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2B75A18", Offset = "0x2B75A18", VA = "0x2B75A18")]
		private void Update()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2B75C20", Offset = "0x2B75C20", VA = "0x2B75C20")]
		private void UpdateLineRenderer()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2B75BA0", Offset = "0x2B75BA0", VA = "0x2B75BA0")]
		private void ConfigureLineRenderer()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2B75CDC", Offset = "0x2B75CDC", VA = "0x2B75CDC")]
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
			[Address(RVA = "0x2B75CF4", Offset = "0x2B75CF4", VA = "0x2B75CF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public bool IsLast
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x2B75D20", Offset = "0x2B75D20", VA = "0x2B75D20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		public StateMachine StateMachine
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x2B75D84", Offset = "0x2B75D84", VA = "0x2B75D84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2B75EBC", Offset = "0x2B75EBC", VA = "0x2B75EBC")]
		public void ChangeState(int childIndex)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2B75FD4", Offset = "0x2B75FD4", VA = "0x2B75FD4")]
		public void ChangeState(GameObject state)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2B762AC", Offset = "0x2B762AC", VA = "0x2B762AC")]
		public void ChangeState(string state)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2B762CC", Offset = "0x2B762CC", VA = "0x2B762CC")]
		public GameObject Next(bool exitIfLast = false)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2B763E4", Offset = "0x2B763E4", VA = "0x2B763E4")]
		public GameObject Previous(bool exitIfFirst = false)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2B764D8", Offset = "0x2B764D8", VA = "0x2B764D8")]
		public void Exit()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2B76694", Offset = "0x2B76694", VA = "0x2B76694")]
		protected Coroutine StartCoroutineIfActive(IEnumerator coroutine)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2B766E8", Offset = "0x2B766E8", VA = "0x2B766E8")]
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
			[Address(RVA = "0x2B766F0", Offset = "0x2B766F0", VA = "0x2B766F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x2B766F8", Offset = "0x2B766F8", VA = "0x2B766F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool AtFirst
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x2B76704", Offset = "0x2B76704", VA = "0x2B76704")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x2B7670C", Offset = "0x2B7670C", VA = "0x2B7670C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool AtLast
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x2B76740", Offset = "0x2B76740", VA = "0x2B76740")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2B76748", Offset = "0x2B76748", VA = "0x2B76748")]
			private set
			{
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2B762EC", Offset = "0x2B762EC", VA = "0x2B762EC")]
		public GameObject Next(bool exitIfLast = false)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2B76404", Offset = "0x2B76404", VA = "0x2B76404")]
		public GameObject Previous(bool exitIfFirst = false)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2B764F0", Offset = "0x2B764F0", VA = "0x2B764F0")]
		public void Exit()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2B75EDC", Offset = "0x2B75EDC", VA = "0x2B75EDC")]
		public GameObject ChangeState(int childIndex)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2B76804", Offset = "0x2B76804", VA = "0x2B76804")]
		public GameObject ChangeState(GameObject state)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2B76014", Offset = "0x2B76014", VA = "0x2B76014")]
		public GameObject ChangeState(string state)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2B76DC8", Offset = "0x2B76DC8", VA = "0x2B76DC8")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2B76E50", Offset = "0x2B76E50", VA = "0x2B76E50")]
		public void StartMachine()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2B76C68", Offset = "0x2B76C68", VA = "0x2B76C68")]
		private void Enter(GameObject state)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2B7677C", Offset = "0x2B7677C", VA = "0x2B7677C")]
		private void Log(string message)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2B76EEC", Offset = "0x2B76EEC", VA = "0x2B76EEC")]
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
			[Address(RVA = "0x2B76EFC", Offset = "0x2B76EFC", VA = "0x2B76EFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public static AnimationCurve EaseLinear
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x2B77264", Offset = "0x2B77264", VA = "0x2B77264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public static AnimationCurve EaseIn
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x2B7DC20", Offset = "0x2B7DC20", VA = "0x2B7DC20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public static AnimationCurve EaseInStrong
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x2B7DDC8", Offset = "0x2B7DDC8", VA = "0x2B7DDC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public static AnimationCurve EaseOut
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x2B7E10C", Offset = "0x2B7E10C", VA = "0x2B7E10C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public static AnimationCurve EaseOutStrong
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x2B7E2B4", Offset = "0x2B7E2B4", VA = "0x2B7E2B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public static AnimationCurve EaseInOut
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x2B7E5F0", Offset = "0x2B7E5F0", VA = "0x2B7E5F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public static AnimationCurve EaseInOutStrong
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x2B7E6AC", Offset = "0x2B7E6AC", VA = "0x2B7E6AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public static AnimationCurve EaseInBack
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x2B7E8C0", Offset = "0x2B7E8C0", VA = "0x2B7E8C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public static AnimationCurve EaseOutBack
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x2B7EA6C", Offset = "0x2B7EA6C", VA = "0x2B7EA6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public static AnimationCurve EaseInOutBack
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x2B7EC18", Offset = "0x2B7EC18", VA = "0x2B7EC18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public static AnimationCurve EaseSpring
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x2B7EDD0", Offset = "0x2B7EDD0", VA = "0x2B7EDD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public static AnimationCurve EaseBounce
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x2B7F0A4", Offset = "0x2B7F0A4", VA = "0x2B7F0A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public static AnimationCurve EaseWobble
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x2B7F4FC", Offset = "0x2B7F4FC", VA = "0x2B7F4FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2B77140", Offset = "0x2B77140", VA = "0x2B77140")]
		public static TweenBase Shake(Transform target, Vector3 initialPosition, Vector3 intensity, float duration, float delay, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2B77414", Offset = "0x2B77414", VA = "0x2B77414")]
		public static TweenBase Spline(Spline spline, Transform target, float startPercentage, float endPercentage, bool faceDirection, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2B77660", Offset = "0x2B77660", VA = "0x2B77660")]
		public static TweenBase CanvasGroupAlpha(CanvasGroup target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2B77818", Offset = "0x2B77818", VA = "0x2B77818")]
		public static TweenBase CanvasGroupAlpha(CanvasGroup target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2B778E8", Offset = "0x2B778E8", VA = "0x2B778E8")]
		public static TweenBase Value(Rect startValue, Rect endValue, Action<Rect> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2B77B1C", Offset = "0x2B77B1C", VA = "0x2B77B1C")]
		public static TweenBase Value(Vector4 startValue, Vector4 endValue, Action<Vector4> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2B77D50", Offset = "0x2B77D50", VA = "0x2B77D50")]
		public static TweenBase Value(Vector3 startValue, Vector3 endValue, Action<Vector3> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2B77F5C", Offset = "0x2B77F5C", VA = "0x2B77F5C")]
		public static TweenBase Value(Vector2 startValue, Vector2 endValue, Action<Vector2> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2B78138", Offset = "0x2B78138", VA = "0x2B78138")]
		public static TweenBase Value(Color startValue, Color endValue, Action<Color> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2B7836C", Offset = "0x2B7836C", VA = "0x2B7836C")]
		public static TweenBase Value(int startValue, int endValue, Action<int> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2B78530", Offset = "0x2B78530", VA = "0x2B78530")]
		public static TweenBase Value(float startValue, float endValue, Action<float> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2B786E4", Offset = "0x2B786E4", VA = "0x2B786E4")]
		public static TweenBase ShaderVector(Material target, string propertyName, Vector4 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2B78900", Offset = "0x2B78900", VA = "0x2B78900")]
		public static TweenBase ShaderVector(Material target, string propertyName, Vector4 startValue, Vector4 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2B78A1C", Offset = "0x2B78A1C", VA = "0x2B78A1C")]
		public static TweenBase ShaderInt(Material target, string propertyName, int endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2B78BF8", Offset = "0x2B78BF8", VA = "0x2B78BF8")]
		public static TweenBase ShaderInt(Material target, string propertyName, int startValue, int endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2B78CDC", Offset = "0x2B78CDC", VA = "0x2B78CDC")]
		public static TweenBase ShaderColor(Material target, string propertyName, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2B78EF8", Offset = "0x2B78EF8", VA = "0x2B78EF8")]
		public static TweenBase ShaderColor(Material target, string propertyName, Color startValue, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2B79014", Offset = "0x2B79014", VA = "0x2B79014")]
		public static TweenBase ShaderFloat(Material target, string propertyName, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2B791F8", Offset = "0x2B791F8", VA = "0x2B791F8")]
		public static TweenBase ShaderFloat(Material target, string propertyName, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2B792DC", Offset = "0x2B792DC", VA = "0x2B792DC")]
		public static TweenBase Pitch(AudioSource target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2B79494", Offset = "0x2B79494", VA = "0x2B79494")]
		public static TweenBase Pitch(AudioSource target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2B79564", Offset = "0x2B79564", VA = "0x2B79564")]
		public static TweenBase PanStereo(AudioSource target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2B7971C", Offset = "0x2B7971C", VA = "0x2B7971C")]
		public static TweenBase PanStereo(AudioSource target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2B797EC", Offset = "0x2B797EC", VA = "0x2B797EC")]
		public static TweenBase Volume(AudioSource target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2B799A4", Offset = "0x2B799A4", VA = "0x2B799A4")]
		public static TweenBase Volume(AudioSource target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2B79A74", Offset = "0x2B79A74", VA = "0x2B79A74")]
		public static TweenBase Size(RectTransform target, Vector2 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2B79C38", Offset = "0x2B79C38", VA = "0x2B79C38")]
		public static TweenBase Size(RectTransform target, Vector2 startValue, Vector2 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2B79D20", Offset = "0x2B79D20", VA = "0x2B79D20")]
		public static TweenBase FieldOfView(Camera target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2B79ED8", Offset = "0x2B79ED8", VA = "0x2B79ED8")]
		public static TweenBase FieldOfView(Camera target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2B79FA8", Offset = "0x2B79FA8", VA = "0x2B79FA8")]
		public static TweenBase LightRange(Light target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2B7A160", Offset = "0x2B7A160", VA = "0x2B7A160")]
		public static TweenBase LightRange(Light target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2B7A230", Offset = "0x2B7A230", VA = "0x2B7A230")]
		public static TweenBase LightIntensity(Light target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2B7A3E8", Offset = "0x2B7A3E8", VA = "0x2B7A3E8")]
		public static TweenBase LightIntensity(Light target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2B7A4B8", Offset = "0x2B7A4B8", VA = "0x2B7A4B8")]
		public static TweenBase LocalScale(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2B7A69C", Offset = "0x2B7A69C", VA = "0x2B7A69C")]
		public static TweenBase LocalScale(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2B7A79C", Offset = "0x2B7A79C", VA = "0x2B7A79C")]
		public static TweenBase Color(Graphic target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2B7A98C", Offset = "0x2B7A98C", VA = "0x2B7A98C")]
		public static TweenBase Color(Graphic target, Color startValue, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2B7AAA4", Offset = "0x2B7AAA4", VA = "0x2B7AAA4")]
		public static TweenBase Color(Light target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2B7AC94", Offset = "0x2B7AC94", VA = "0x2B7AC94")]
		public static TweenBase Color(Light target, Color startValue, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2B7ADA4", Offset = "0x2B7ADA4", VA = "0x2B7ADA4")]
		public static TweenBase Color(Material target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2B7AEDC", Offset = "0x2B7AEDC", VA = "0x2B7AEDC")]
		public static TweenBase Color(Material target, Color startColor, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2B7AFEC", Offset = "0x2B7AFEC", VA = "0x2B7AFEC")]
		public static TweenBase Color(Renderer target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2B7B0DC", Offset = "0x2B7B0DC", VA = "0x2B7B0DC")]
		public static TweenBase Color(Renderer target, Color startColor, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2B7B1F4", Offset = "0x2B7B1F4", VA = "0x2B7B1F4")]
		public static TweenBase Color(SpriteRenderer target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2B7B3E4", Offset = "0x2B7B3E4", VA = "0x2B7B3E4")]
		public static TweenBase Color(SpriteRenderer target, Color startColor, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2B7B4F4", Offset = "0x2B7B4F4", VA = "0x2B7B4F4")]
		public static TweenBase Color(Camera target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2B7B6E4", Offset = "0x2B7B6E4", VA = "0x2B7B6E4")]
		public static TweenBase Color(Camera target, Color startColor, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2B7B7F4", Offset = "0x2B7B7F4", VA = "0x2B7B7F4")]
		public static TweenBase Position(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2B7B9D8", Offset = "0x2B7B9D8", VA = "0x2B7B9D8")]
		public static TweenBase Position(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2B7BAD8", Offset = "0x2B7BAD8", VA = "0x2B7BAD8")]
		public static TweenBase AnchoredPosition(RectTransform target, Vector2 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2B7BC9C", Offset = "0x2B7BC9C", VA = "0x2B7BC9C")]
		public static TweenBase AnchoredPosition(RectTransform target, Vector2 startValue, Vector2 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2B7BD84", Offset = "0x2B7BD84", VA = "0x2B7BD84")]
		public static TweenBase LocalPosition(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2B7BF68", Offset = "0x2B7BF68", VA = "0x2B7BF68")]
		public static TweenBase LocalPosition(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2B7C068", Offset = "0x2B7C068", VA = "0x2B7C068")]
		public static TweenBase Rotate(Transform target, Vector3 amount, Space space, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2B7C26C", Offset = "0x2B7C26C", VA = "0x2B7C26C")]
		public static TweenBase Rotation(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2B7C49C", Offset = "0x2B7C49C", VA = "0x2B7C49C")]
		public static TweenBase Rotation(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2B7C62C", Offset = "0x2B7C62C", VA = "0x2B7C62C")]
		public static TweenBase Rotation(Transform target, Quaternion endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2B7C780", Offset = "0x2B7C780", VA = "0x2B7C780")]
		public static TweenBase Rotation(Transform target, Quaternion startValue, Quaternion endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2B7C890", Offset = "0x2B7C890", VA = "0x2B7C890")]
		public static TweenBase LocalRotation(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2B7CAC0", Offset = "0x2B7CAC0", VA = "0x2B7CAC0")]
		public static TweenBase LocalRotation(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2B7CC50", Offset = "0x2B7CC50", VA = "0x2B7CC50")]
		public static TweenBase LocalRotation(Transform target, Quaternion endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2B7CDA4", Offset = "0x2B7CDA4", VA = "0x2B7CDA4")]
		public static TweenBase LocalRotation(Transform target, Quaternion startValue, Quaternion endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2B7CEB4", Offset = "0x2B7CEB4", VA = "0x2B7CEB4")]
		public static TweenBase LookAt(Transform target, Transform targetToLookAt, Vector3 up, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2B7CFF8", Offset = "0x2B7CFF8", VA = "0x2B7CFF8")]
		public static TweenBase LookAt(Transform target, Vector3 positionToLookAt, Vector3 up, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2B7D120", Offset = "0x2B7D120", VA = "0x2B7D120")]
		public static void Stop(int targetInstanceID, TweenType tweenType)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2B7D2D0", Offset = "0x2B7D2D0", VA = "0x2B7D2D0")]
		public static void Stop(int targetInstanceID)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2B7D440", Offset = "0x2B7D440", VA = "0x2B7D440")]
		public static void StopAll()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2B7D5B8", Offset = "0x2B7D5B8", VA = "0x2B7D5B8")]
		public static void FinishAll()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2B7D73C", Offset = "0x2B7D73C", VA = "0x2B7D73C")]
		public static void Finish(int targetInstanceID)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2B7D8EC", Offset = "0x2B7D8EC", VA = "0x2B7D8EC")]
		public static void Cancel(int targetInstanceID)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2B7DA9C", Offset = "0x2B7DA9C", VA = "0x2B7DA9C")]
		public static void CancelAll()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2B7D324", Offset = "0x2B7D324", VA = "0x2B7D324")]
		private static void StopInstanceTarget(int id)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2B7F87C", Offset = "0x2B7F87C", VA = "0x2B7F87C")]
		private static void StopInstanceTargetType(int id, TweenType type)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2B7D790", Offset = "0x2B7D790", VA = "0x2B7D790")]
		private static void FinishInstanceTarget(int id)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2B7D940", Offset = "0x2B7D940", VA = "0x2B7D940")]
		private static void CancelInstanceTarget(int id)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2B77358", Offset = "0x2B77358", VA = "0x2B77358")]
		private static void SendTweenForProcessing(TweenBase tween, bool interrupt = false)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2B7FAC0", Offset = "0x2B7FAC0", VA = "0x2B7FAC0")]
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
		[Address(RVA = "0x2B7FB60", Offset = "0x2B7FB60", VA = "0x2B7FB60")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2B7FE80", Offset = "0x2B7FE80", VA = "0x2B7FE80")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2B7FF00", Offset = "0x2B7FF00", VA = "0x2B7FF00")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2B7FC8C", Offset = "0x2B7FC8C", VA = "0x2B7FC8C")]
		private void InitializeSingleton()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2B80028", Offset = "0x2B80028", VA = "0x2B80028")]
		public Initialization()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class LayerMaskHelper
	{
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2B80030", Offset = "0x2B80030", VA = "0x2B80030")]
		public static int OnlyIncluding(params int[] layers)
		{
			return default(int);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2B8009C", Offset = "0x2B8009C", VA = "0x2B8009C")]
		public static int Everything()
		{
			return default(int);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2B800A4", Offset = "0x2B800A4", VA = "0x2B800A4")]
		public static int Default()
		{
			return default(int);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2B800AC", Offset = "0x2B800AC", VA = "0x2B800AC")]
		public static int Nothing()
		{
			return default(int);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2B800B4", Offset = "0x2B800B4", VA = "0x2B800B4")]
		public static int EverythingBut(params int[] layers)
		{
			return default(int);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2B800C8", Offset = "0x2B800C8", VA = "0x2B800C8")]
		public static bool ContainsLayer(LayerMask layerMask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2B80034", Offset = "0x2B80034", VA = "0x2B80034")]
		private static int MakeMask(params int[] layers)
		{
			return default(int);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2B80100", Offset = "0x2B80100", VA = "0x2B80100")]
		public LayerMaskHelper()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public static class CoreMath
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2B80108", Offset = "0x2B80108", VA = "0x2B80108")]
		public static float LinearInterpolate(float from, float to, float percentage)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2B80118", Offset = "0x2B80118", VA = "0x2B80118")]
		public static Vector2 LinearInterpolate(Vector2 from, Vector2 to, float percentage)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2B80134", Offset = "0x2B80134", VA = "0x2B80134")]
		public static Vector3 LinearInterpolate(Vector3 from, Vector3 to, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2B8015C", Offset = "0x2B8015C", VA = "0x2B8015C")]
		public static Vector4 LinearInterpolate(Vector4 from, Vector4 to, float percentage)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2B80194", Offset = "0x2B80194", VA = "0x2B80194")]
		public static Rect LinearInterpolate(Rect from, Rect to, float percentage)
		{
			return default(Rect);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2B80298", Offset = "0x2B80298", VA = "0x2B80298")]
		public static Color LinearInterpolate(Color from, Color to, float percentage)
		{
			return default(Color);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2B802D0", Offset = "0x2B802D0", VA = "0x2B802D0")]
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
			[Address(RVA = "0x2B80350", Offset = "0x2B80350", VA = "0x2B80350")]
			[CompilerGenerated]
			get
			{
				return default(Tween.TweenStatus);
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x2B80358", Offset = "0x2B80358", VA = "0x2B80358")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public float Duration
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x2B80360", Offset = "0x2B80360", VA = "0x2B80360")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x2B80368", Offset = "0x2B80368", VA = "0x2B80368")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public AnimationCurve Curve
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x2B80370", Offset = "0x2B80370", VA = "0x2B80370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x2B80378", Offset = "0x2B80378", VA = "0x2B80378")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Keyframe[] CurveKeys
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x2B80380", Offset = "0x2B80380", VA = "0x2B80380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x2B80388", Offset = "0x2B80388", VA = "0x2B80388")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public bool ObeyTimescale
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x2B80390", Offset = "0x2B80390", VA = "0x2B80390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x2B80398", Offset = "0x2B80398", VA = "0x2B80398")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Action StartCallback
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x2B803A4", Offset = "0x2B803A4", VA = "0x2B803A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x2B803AC", Offset = "0x2B803AC", VA = "0x2B803AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public Action CompleteCallback
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x2B803B4", Offset = "0x2B803B4", VA = "0x2B803B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x2B803BC", Offset = "0x2B803BC", VA = "0x2B803BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float Delay
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x2B803C4", Offset = "0x2B803C4", VA = "0x2B803C4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2B803CC", Offset = "0x2B803CC", VA = "0x2B803CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Tween.LoopType LoopType
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2B803D4", Offset = "0x2B803D4", VA = "0x2B803D4")]
			[CompilerGenerated]
			get
			{
				return default(Tween.LoopType);
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x2B803DC", Offset = "0x2B803DC", VA = "0x2B803DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public float Percentage
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x2B803E4", Offset = "0x2B803E4", VA = "0x2B803E4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x2B803EC", Offset = "0x2B803EC", VA = "0x2B803EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2B7D2C4", Offset = "0x2B7D2C4", VA = "0x2B7D2C4")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2B806A4", Offset = "0x2B806A4", VA = "0x2B806A4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2B80740", Offset = "0x2B80740", VA = "0x2B80740")]
		public void Resume()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2B807C0", Offset = "0x2B807C0", VA = "0x2B807C0")]
		public void Rewind()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2B7DC14", Offset = "0x2B7DC14", VA = "0x2B7DC14")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2B7D730", Offset = "0x2B7D730", VA = "0x2B7D730")]
		public void Finish()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2B803F4", Offset = "0x2B803F4", VA = "0x2B803F4")]
		public void Tick()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2B807EC", Offset = "0x2B807EC", VA = "0x2B807EC")]
		private void CleanUp()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2B8093C", Offset = "0x2B8093C", VA = "0x2B8093C")]
		protected void ResetStartTime()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2B8094C", Offset = "0x2B8094C", VA = "0x2B8094C")]
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
		[Address(RVA = "0x2B80A10", Offset = "0x2B80A10", VA = "0x2B80A10")]
		protected TweenBase()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class TweenEngine : MonoBehaviour
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2B7F9E8", Offset = "0x2B7F9E8", VA = "0x2B7F9E8")]
		public void ExecuteTween(TweenBase tween)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2B80A18", Offset = "0x2B80A18", VA = "0x2B80A18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2B80AD8", Offset = "0x2B80AD8", VA = "0x2B80AD8")]
		public TweenEngine()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class TweenUtilities : MonoBehaviour
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2B80AE0", Offset = "0x2B80AE0", VA = "0x2B80AE0")]
		public static void GenerateAnimationCurvePropertyCode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2B80FEC", Offset = "0x2B80FEC", VA = "0x2B80FEC")]
		public static float LinearInterpolate(float from, float to, float percentage)
		{
			return default(float);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2B80FFC", Offset = "0x2B80FFC", VA = "0x2B80FFC")]
		public static Vector2 LinearInterpolate(Vector2 from, Vector2 to, float percentage)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2B81018", Offset = "0x2B81018", VA = "0x2B81018")]
		public static Vector3 LinearInterpolate(Vector3 from, Vector3 to, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2B81040", Offset = "0x2B81040", VA = "0x2B81040")]
		public static Vector3 LinearInterpolateRotational(Vector3 from, Vector3 to, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2B811C0", Offset = "0x2B811C0", VA = "0x2B811C0")]
		public static Vector4 LinearInterpolate(Vector4 from, Vector4 to, float percentage)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2B811F8", Offset = "0x2B811F8", VA = "0x2B811F8")]
		public static Rect LinearInterpolate(Rect from, Rect to, float percentage)
		{
			return default(Rect);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2B812FC", Offset = "0x2B812FC", VA = "0x2B812FC")]
		public static Color LinearInterpolate(Color from, Color to, float percentage)
		{
			return default(Color);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2B808BC", Offset = "0x2B808BC", VA = "0x2B808BC")]
		public static float EvaluateCurve(AnimationCurve curve, float percentage)
		{
			return default(float);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2B8115C", Offset = "0x2B8115C", VA = "0x2B8115C")]
		private static float CylindricalLerp(float from, float to, float percentage)
		{
			return default(float);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2B81334", Offset = "0x2B81334", VA = "0x2B81334")]
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
			[Address(RVA = "0x2B8133C", Offset = "0x2B8133C", VA = "0x2B8133C")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x2B81344", Offset = "0x2B81344", VA = "0x2B81344")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2B7BBD8", Offset = "0x2B7BBD8", VA = "0x2B7BBD8")]
		public AnchoredPosition(RectTransform target, Vector2 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2B8134C", Offset = "0x2B8134C", VA = "0x2B8134C", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2B813D8", Offset = "0x2B813D8", VA = "0x2B813D8", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2B81410", Offset = "0x2B81410", VA = "0x2B81410", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2B81440", Offset = "0x2B81440", VA = "0x2B81440", Slot = "7")]
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
			[Address(RVA = "0x2B8148C", Offset = "0x2B8148C", VA = "0x2B8148C")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x2B81498", Offset = "0x2B81498", VA = "0x2B81498")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2B7B60C", Offset = "0x2B7B60C", VA = "0x2B7B60C")]
		public CameraBackgroundColor(Camera target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2B814A4", Offset = "0x2B814A4", VA = "0x2B814A4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2B81534", Offset = "0x2B81534", VA = "0x2B81534", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2B81574", Offset = "0x2B81574", VA = "0x2B81574", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2B815A8", Offset = "0x2B815A8", VA = "0x2B815A8", Slot = "7")]
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
			[Address(RVA = "0x2B81600", Offset = "0x2B81600", VA = "0x2B81600")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x2B81608", Offset = "0x2B81608", VA = "0x2B81608")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2B77758", Offset = "0x2B77758", VA = "0x2B77758")]
		public CanvasGroupAlpha(CanvasGroup target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2B81610", Offset = "0x2B81610", VA = "0x2B81610", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2B8169C", Offset = "0x2B8169C", VA = "0x2B8169C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2B816D0", Offset = "0x2B816D0", VA = "0x2B816D0", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2B81700", Offset = "0x2B81700", VA = "0x2B81700", Slot = "7")]
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
			[Address(RVA = "0x2B81750", Offset = "0x2B81750", VA = "0x2B81750")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x2B81758", Offset = "0x2B81758", VA = "0x2B81758")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2B79E18", Offset = "0x2B79E18", VA = "0x2B79E18")]
		public FieldOfView(Camera target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2B81760", Offset = "0x2B81760", VA = "0x2B81760", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2B817EC", Offset = "0x2B817EC", VA = "0x2B817EC", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2B81820", Offset = "0x2B81820", VA = "0x2B81820", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2B81850", Offset = "0x2B81850", VA = "0x2B81850", Slot = "7")]
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
			[Address(RVA = "0x2B818A0", Offset = "0x2B818A0", VA = "0x2B818A0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x2B818AC", Offset = "0x2B818AC", VA = "0x2B818AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2B7A8B4", Offset = "0x2B7A8B4", VA = "0x2B7A8B4")]
		public GraphicColor(Graphic target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2B818B8", Offset = "0x2B818B8", VA = "0x2B818B8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2B81950", Offset = "0x2B81950", VA = "0x2B81950", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2B81998", Offset = "0x2B81998", VA = "0x2B81998", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2B819D4", Offset = "0x2B819D4", VA = "0x2B819D4", Slot = "7")]
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
			[Address(RVA = "0x2B81A3C", Offset = "0x2B81A3C", VA = "0x2B81A3C")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x2B81A48", Offset = "0x2B81A48", VA = "0x2B81A48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2B81A54", Offset = "0x2B81A54", VA = "0x2B81A54")]
		public ImageColor(Image target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2B81B2C", Offset = "0x2B81B2C", VA = "0x2B81B2C", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2B81BC4", Offset = "0x2B81BC4", VA = "0x2B81BC4", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2B81C0C", Offset = "0x2B81C0C", VA = "0x2B81C0C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2B81C48", Offset = "0x2B81C48", VA = "0x2B81C48", Slot = "7")]
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
			[Address(RVA = "0x2B81CB0", Offset = "0x2B81CB0", VA = "0x2B81CB0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2B81CBC", Offset = "0x2B81CBC", VA = "0x2B81CBC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2B7ABBC", Offset = "0x2B7ABBC", VA = "0x2B7ABBC")]
		public LightColor(Light target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2B81CC8", Offset = "0x2B81CC8", VA = "0x2B81CC8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2B81D58", Offset = "0x2B81D58", VA = "0x2B81D58", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2B81D98", Offset = "0x2B81D98", VA = "0x2B81D98", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2B81DCC", Offset = "0x2B81DCC", VA = "0x2B81DCC", Slot = "7")]
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
			[Address(RVA = "0x2B81E24", Offset = "0x2B81E24", VA = "0x2B81E24")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2B81E2C", Offset = "0x2B81E2C", VA = "0x2B81E2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2B7A328", Offset = "0x2B7A328", VA = "0x2B7A328")]
		public LightIntensity(Light target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2B81E34", Offset = "0x2B81E34", VA = "0x2B81E34", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2B81EC0", Offset = "0x2B81EC0", VA = "0x2B81EC0", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2B81EF4", Offset = "0x2B81EF4", VA = "0x2B81EF4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2B81F24", Offset = "0x2B81F24", VA = "0x2B81F24", Slot = "7")]
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
			[Address(RVA = "0x2B81F74", Offset = "0x2B81F74", VA = "0x2B81F74")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x2B81F7C", Offset = "0x2B81F7C", VA = "0x2B81F7C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2B7A0A0", Offset = "0x2B7A0A0", VA = "0x2B7A0A0")]
		public LightRange(Light target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2B81F84", Offset = "0x2B81F84", VA = "0x2B81F84", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2B82010", Offset = "0x2B82010", VA = "0x2B82010", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2B82044", Offset = "0x2B82044", VA = "0x2B82044", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2B82074", Offset = "0x2B82074", VA = "0x2B82074", Slot = "7")]
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
			[Address(RVA = "0x2B820C4", Offset = "0x2B820C4", VA = "0x2B820C4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2B820D0", Offset = "0x2B820D0", VA = "0x2B820D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2B7BE94", Offset = "0x2B7BE94", VA = "0x2B7BE94")]
		public LocalPosition(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2B820DC", Offset = "0x2B820DC", VA = "0x2B820DC", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2B8216C", Offset = "0x2B8216C", VA = "0x2B8216C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2B821B8", Offset = "0x2B821B8", VA = "0x2B821B8", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2B821EC", Offset = "0x2B821EC", VA = "0x2B821EC", Slot = "7")]
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
			[Address(RVA = "0x2B82248", Offset = "0x2B82248", VA = "0x2B82248")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2B82254", Offset = "0x2B82254", VA = "0x2B82254")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2B7C9EC", Offset = "0x2B7C9EC", VA = "0x2B7C9EC")]
		public LocalRotation(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2B82260", Offset = "0x2B82260", VA = "0x2B82260", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2B822F0", Offset = "0x2B822F0", VA = "0x2B822F0", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2B8234C", Offset = "0x2B8234C", VA = "0x2B8234C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2B82380", Offset = "0x2B82380", VA = "0x2B82380", Slot = "7")]
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
			[Address(RVA = "0x2B823DC", Offset = "0x2B823DC", VA = "0x2B823DC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x2B823E8", Offset = "0x2B823E8", VA = "0x2B823E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2B7A5C8", Offset = "0x2B7A5C8", VA = "0x2B7A5C8")]
		public LocalScale(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2B823F4", Offset = "0x2B823F4", VA = "0x2B823F4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2B82484", Offset = "0x2B82484", VA = "0x2B82484", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2B824D0", Offset = "0x2B824D0", VA = "0x2B824D0", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2B82504", Offset = "0x2B82504", VA = "0x2B82504", Slot = "7")]
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
			[Address(RVA = "0x2B82560", Offset = "0x2B82560", VA = "0x2B82560")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x2B82568", Offset = "0x2B82568", VA = "0x2B82568")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2B7965C", Offset = "0x2B7965C", VA = "0x2B7965C")]
		public PanStereo(AudioSource target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2B82570", Offset = "0x2B82570", VA = "0x2B82570", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2B825FC", Offset = "0x2B825FC", VA = "0x2B825FC", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2B82630", Offset = "0x2B82630", VA = "0x2B82630", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2B82660", Offset = "0x2B82660", VA = "0x2B82660", Slot = "7")]
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
			[Address(RVA = "0x2B826B0", Offset = "0x2B826B0", VA = "0x2B826B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x2B826B8", Offset = "0x2B826B8", VA = "0x2B826B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2B793D4", Offset = "0x2B793D4", VA = "0x2B793D4")]
		public Pitch(AudioSource target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2B826C0", Offset = "0x2B826C0", VA = "0x2B826C0", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2B8274C", Offset = "0x2B8274C", VA = "0x2B8274C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2B82780", Offset = "0x2B82780", VA = "0x2B82780", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2B827B0", Offset = "0x2B827B0", VA = "0x2B827B0", Slot = "7")]
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
			[Address(RVA = "0x2B82800", Offset = "0x2B82800", VA = "0x2B82800")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2B8280C", Offset = "0x2B8280C", VA = "0x2B8280C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2B7B904", Offset = "0x2B7B904", VA = "0x2B7B904")]
		public Position(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2B82818", Offset = "0x2B82818", VA = "0x2B82818", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2B828A8", Offset = "0x2B828A8", VA = "0x2B828A8", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2B828F4", Offset = "0x2B828F4", VA = "0x2B828F4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2B82928", Offset = "0x2B82928", VA = "0x2B82928", Slot = "7")]
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
			[Address(RVA = "0x2B82984", Offset = "0x2B82984", VA = "0x2B82984")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x2B82990", Offset = "0x2B82990", VA = "0x2B82990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2B8299C", Offset = "0x2B8299C", VA = "0x2B8299C")]
		public RawImageColor(RawImage target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2B82A74", Offset = "0x2B82A74", VA = "0x2B82A74", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2B82B0C", Offset = "0x2B82B0C", VA = "0x2B82B0C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2B82B54", Offset = "0x2B82B54", VA = "0x2B82B54", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2B82B90", Offset = "0x2B82B90", VA = "0x2B82B90", Slot = "7")]
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
			[Address(RVA = "0x2B82BF8", Offset = "0x2B82BF8", VA = "0x2B82BF8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x2B82C04", Offset = "0x2B82C04", VA = "0x2B82C04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2B7C188", Offset = "0x2B7C188", VA = "0x2B7C188")]
		public Rotate(Transform target, Vector3 endValue, Space space, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2B82C10", Offset = "0x2B82C10", VA = "0x2B82C10", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2B82CA0", Offset = "0x2B82CA0", VA = "0x2B82CA0", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2B82D7C", Offset = "0x2B82D7C", VA = "0x2B82D7C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2B82DE0", Offset = "0x2B82DE0", VA = "0x2B82DE0", Slot = "7")]
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
			[Address(RVA = "0x2B82E5C", Offset = "0x2B82E5C", VA = "0x2B82E5C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x2B82E68", Offset = "0x2B82E68", VA = "0x2B82E68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2B7C3C8", Offset = "0x2B7C3C8", VA = "0x2B7C3C8")]
		public Rotation(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2B82E74", Offset = "0x2B82E74", VA = "0x2B82E74", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2B82F04", Offset = "0x2B82F04", VA = "0x2B82F04", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2B82F60", Offset = "0x2B82F60", VA = "0x2B82F60", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2B82F94", Offset = "0x2B82F94", VA = "0x2B82F94", Slot = "7")]
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
			[Address(RVA = "0x2B82FF0", Offset = "0x2B82FF0", VA = "0x2B82FF0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x2B82FFC", Offset = "0x2B82FFC", VA = "0x2B82FFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2B78E04", Offset = "0x2B78E04", VA = "0x2B78E04")]
		public ShaderColor(Material target, string propertyName, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2B83008", Offset = "0x2B83008", VA = "0x2B83008", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2B83094", Offset = "0x2B83094", VA = "0x2B83094", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2B830D8", Offset = "0x2B830D8", VA = "0x2B830D8", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2B83110", Offset = "0x2B83110", VA = "0x2B83110", Slot = "7")]
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
			[Address(RVA = "0x2B83170", Offset = "0x2B83170", VA = "0x2B83170")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x2B83178", Offset = "0x2B83178", VA = "0x2B83178")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2B7911C", Offset = "0x2B7911C", VA = "0x2B7911C")]
		public ShaderFloat(Material target, string propertyName, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2B83180", Offset = "0x2B83180", VA = "0x2B83180", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2B83208", Offset = "0x2B83208", VA = "0x2B83208", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2B83240", Offset = "0x2B83240", VA = "0x2B83240", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2B83274", Offset = "0x2B83274", VA = "0x2B83274", Slot = "7")]
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
			[Address(RVA = "0x2B832CC", Offset = "0x2B832CC", VA = "0x2B832CC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x2B832D4", Offset = "0x2B832D4", VA = "0x2B832D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2B78B24", Offset = "0x2B78B24", VA = "0x2B78B24")]
		public ShaderInt(Material target, string propertyName, int endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2B832DC", Offset = "0x2B832DC", VA = "0x2B832DC", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2B83364", Offset = "0x2B83364", VA = "0x2B83364", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2B833BC", Offset = "0x2B833BC", VA = "0x2B833BC", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2B833F0", Offset = "0x2B833F0", VA = "0x2B833F0", Slot = "7")]
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
			[Address(RVA = "0x2B83448", Offset = "0x2B83448", VA = "0x2B83448")]
			[CompilerGenerated]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x2B83454", Offset = "0x2B83454", VA = "0x2B83454")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2B7880C", Offset = "0x2B7880C", VA = "0x2B7880C")]
		public ShaderVector(Material target, string propertyName, Vector4 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2B83460", Offset = "0x2B83460", VA = "0x2B83460", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2B834F4", Offset = "0x2B834F4", VA = "0x2B834F4", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2B83538", Offset = "0x2B83538", VA = "0x2B83538", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2B83570", Offset = "0x2B83570", VA = "0x2B83570", Slot = "7")]
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
			[Address(RVA = "0x2B835D0", Offset = "0x2B835D0", VA = "0x2B835D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x2B835DC", Offset = "0x2B835DC", VA = "0x2B835DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2B7726C", Offset = "0x2B7726C", VA = "0x2B7726C")]
		public ShakePosition(Transform target, Vector3 initialPosition, Vector3 intensity, float duration, float delay, AnimationCurve curve, Action startCallback, Action completeCallback, Tween.LoopType loop, bool obeyTimescale)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2B835E8", Offset = "0x2B835E8", VA = "0x2B835E8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2B83654", Offset = "0x2B83654", VA = "0x2B83654", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2B83718", Offset = "0x2B83718", VA = "0x2B83718", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2B8374C", Offset = "0x2B8374C", VA = "0x2B8374C", Slot = "7")]
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
			[Address(RVA = "0x2B83750", Offset = "0x2B83750", VA = "0x2B83750")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x2B83758", Offset = "0x2B83758", VA = "0x2B83758")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2B79B74", Offset = "0x2B79B74", VA = "0x2B79B74")]
		public Size(RectTransform target, Vector2 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2B83760", Offset = "0x2B83760", VA = "0x2B83760", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2B837EC", Offset = "0x2B837EC", VA = "0x2B837EC", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2B83824", Offset = "0x2B83824", VA = "0x2B83824", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2B83854", Offset = "0x2B83854", VA = "0x2B83854", Slot = "7")]
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
			[Address(RVA = "0x2B838A0", Offset = "0x2B838A0", VA = "0x2B838A0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x2B838A8", Offset = "0x2B838A8", VA = "0x2B838A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2B77534", Offset = "0x2B77534", VA = "0x2B77534")]
		public SplinePercentage(Spline spline, Transform target, float startPercentage, float endPercentage, bool faceDirection, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2B838B0", Offset = "0x2B838B0", VA = "0x2B838B0", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2B8391C", Offset = "0x2B8391C", VA = "0x2B8391C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2B83A08", Offset = "0x2B83A08", VA = "0x2B83A08", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2B83A4C", Offset = "0x2B83A4C", VA = "0x2B83A4C", Slot = "7")]
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
			[Address(RVA = "0x2B83A6C", Offset = "0x2B83A6C", VA = "0x2B83A6C")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x2B83A78", Offset = "0x2B83A78", VA = "0x2B83A78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2B7B30C", Offset = "0x2B7B30C", VA = "0x2B7B30C")]
		public SpriteRendererColor(SpriteRenderer target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2B83A84", Offset = "0x2B83A84", VA = "0x2B83A84", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2B83B14", Offset = "0x2B83B14", VA = "0x2B83B14", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2B83B54", Offset = "0x2B83B54", VA = "0x2B83B54", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2B83B88", Offset = "0x2B83B88", VA = "0x2B83B88", Slot = "7")]
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
			[Address(RVA = "0x2B83BE0", Offset = "0x2B83BE0", VA = "0x2B83BE0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x2B83BEC", Offset = "0x2B83BEC", VA = "0x2B83BEC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2B83BF8", Offset = "0x2B83BF8", VA = "0x2B83BF8")]
		public TextColor(Text target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2B83CD0", Offset = "0x2B83CD0", VA = "0x2B83CD0", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2B83D68", Offset = "0x2B83D68", VA = "0x2B83D68", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2B83DB0", Offset = "0x2B83DB0", VA = "0x2B83DB0", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2B83DEC", Offset = "0x2B83DEC", VA = "0x2B83DEC", Slot = "7")]
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
			[Address(RVA = "0x2B83E54", Offset = "0x2B83E54", VA = "0x2B83E54")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x2B83E60", Offset = "0x2B83E60", VA = "0x2B83E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2B83E6C", Offset = "0x2B83E6C", VA = "0x2B83E6C")]
		public TextMeshColor(TextMesh target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2B83F44", Offset = "0x2B83F44", VA = "0x2B83F44", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2B83FD4", Offset = "0x2B83FD4", VA = "0x2B83FD4", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2B84014", Offset = "0x2B84014", VA = "0x2B84014", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2B84048", Offset = "0x2B84048", VA = "0x2B84048", Slot = "7")]
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
			[Address(RVA = "0x2B840A0", Offset = "0x2B840A0", VA = "0x2B840A0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x2B840AC", Offset = "0x2B840AC", VA = "0x2B840AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2B78280", Offset = "0x2B78280", VA = "0x2B78280")]
		public ValueColor(Color startValue, Color endValue, Action<Color> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2B840B8", Offset = "0x2B840B8", VA = "0x2B840B8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2B840C0", Offset = "0x2B840C0", VA = "0x2B840C0", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2B84104", Offset = "0x2B84104", VA = "0x2B84104", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2B84114", Offset = "0x2B84114", VA = "0x2B84114", Slot = "7")]
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
			[Address(RVA = "0x2B84134", Offset = "0x2B84134", VA = "0x2B84134")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x2B8413C", Offset = "0x2B8413C", VA = "0x2B8413C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2B78630", Offset = "0x2B78630", VA = "0x2B78630")]
		public ValueFloat(float startValue, float endValue, Action<float> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2B84144", Offset = "0x2B84144", VA = "0x2B84144", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2B8414C", Offset = "0x2B8414C", VA = "0x2B8414C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2B84184", Offset = "0x2B84184", VA = "0x2B84184", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2B84194", Offset = "0x2B84194", VA = "0x2B84194", Slot = "7")]
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
			[Address(RVA = "0x2B841B4", Offset = "0x2B841B4", VA = "0x2B841B4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x2B841BC", Offset = "0x2B841BC", VA = "0x2B841BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2B78474", Offset = "0x2B78474", VA = "0x2B78474")]
		public ValueInt(int startValue, int endValue, Action<int> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2B841C4", Offset = "0x2B841C4", VA = "0x2B841C4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2B841CC", Offset = "0x2B841CC", VA = "0x2B841CC", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2B8421C", Offset = "0x2B8421C", VA = "0x2B8421C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2B8422C", Offset = "0x2B8422C", VA = "0x2B8422C", Slot = "7")]
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
			[Address(RVA = "0x2B8424C", Offset = "0x2B8424C", VA = "0x2B8424C")]
			[CompilerGenerated]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x2B84258", Offset = "0x2B84258", VA = "0x2B84258")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2B77A30", Offset = "0x2B77A30", VA = "0x2B77A30")]
		public ValueRect(Rect startValue, Rect endValue, Action<Rect> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2B84264", Offset = "0x2B84264", VA = "0x2B84264", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2B8426C", Offset = "0x2B8426C", VA = "0x2B8426C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2B842B8", Offset = "0x2B842B8", VA = "0x2B842B8", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2B842C8", Offset = "0x2B842C8", VA = "0x2B842C8", Slot = "7")]
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
			[Address(RVA = "0x2B842E8", Offset = "0x2B842E8", VA = "0x2B842E8")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x2B842F0", Offset = "0x2B842F0", VA = "0x2B842F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2B78074", Offset = "0x2B78074", VA = "0x2B78074")]
		public ValueVector2(Vector2 startValue, Vector2 endValue, Action<Vector2> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2B842F8", Offset = "0x2B842F8", VA = "0x2B842F8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2B84300", Offset = "0x2B84300", VA = "0x2B84300", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2B8433C", Offset = "0x2B8433C", VA = "0x2B8433C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2B8434C", Offset = "0x2B8434C", VA = "0x2B8434C", Slot = "7")]
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
			[Address(RVA = "0x2B8436C", Offset = "0x2B8436C", VA = "0x2B8436C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x2B84378", Offset = "0x2B84378", VA = "0x2B84378")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2B77E80", Offset = "0x2B77E80", VA = "0x2B77E80")]
		public ValueVector3(Vector3 startValue, Vector3 endValue, Action<Vector3> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2B84384", Offset = "0x2B84384", VA = "0x2B84384", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2B8438C", Offset = "0x2B8438C", VA = "0x2B8438C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2B843DC", Offset = "0x2B843DC", VA = "0x2B843DC", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2B843EC", Offset = "0x2B843EC", VA = "0x2B843EC", Slot = "7")]
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
			[Address(RVA = "0x2B8441C", Offset = "0x2B8441C", VA = "0x2B8441C")]
			[CompilerGenerated]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x2B84428", Offset = "0x2B84428", VA = "0x2B84428")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2B77C64", Offset = "0x2B77C64", VA = "0x2B77C64")]
		public ValueVector4(Vector4 startValue, Vector4 endValue, Action<Vector4> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2B84434", Offset = "0x2B84434", VA = "0x2B84434", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2B8443C", Offset = "0x2B8443C", VA = "0x2B8443C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2B84480", Offset = "0x2B84480", VA = "0x2B84480", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2B84490", Offset = "0x2B84490", VA = "0x2B84490", Slot = "7")]
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
			[Address(RVA = "0x2B844B0", Offset = "0x2B844B0", VA = "0x2B844B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x2B844B8", Offset = "0x2B844B8", VA = "0x2B844B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2B798E4", Offset = "0x2B798E4", VA = "0x2B798E4")]
		public Volume(AudioSource target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2B844C0", Offset = "0x2B844C0", VA = "0x2B844C0", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2B8454C", Offset = "0x2B8454C", VA = "0x2B8454C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2B84580", Offset = "0x2B84580", VA = "0x2B84580", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2B845B0", Offset = "0x2B845B0", VA = "0x2B845B0", Slot = "7")]
		public override void PingPong()
		{
		}
	}
}
