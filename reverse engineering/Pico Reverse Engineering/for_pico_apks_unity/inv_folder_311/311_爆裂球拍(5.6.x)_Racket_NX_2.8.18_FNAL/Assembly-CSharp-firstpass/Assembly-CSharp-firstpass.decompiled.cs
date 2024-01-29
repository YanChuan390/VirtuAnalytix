using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using Il2CppDummyDll;
using MP3Sharp.Decoding;
using MP3Sharp.Decoding.Decoders;
using MP3Sharp.Decoding.Decoders.LayerIII;
using OneHumus;
using OneHumus.Crates;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

[assembly: AssemblyVersion("1.0.0.0")]
[Serializable]
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class BezierCurve : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool showCurveInSceneView;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int resolution;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _dirty;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color drawColor;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool _close;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float _length;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private BezierPoint[] points;

	[Token(Token = "0x17000001")]
	public bool dirty
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xAA67EC", Offset = "0xAA67EC", VA = "0xAA67EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xAA67F4", Offset = "0xAA67F4", VA = "0xAA67F4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public bool close
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0xAA6954", Offset = "0xAA6954", VA = "0xAA6954")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0xAA695C", Offset = "0xAA695C", VA = "0xAA695C")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public BezierPoint this[int index]
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0xAA6994", Offset = "0xAA6994", VA = "0xAA6994")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public int pointCount
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0xAA69C4", Offset = "0xAA69C4", VA = "0xAA69C4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000005")]
	public float length
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xAA69E0", Offset = "0xAA69E0", VA = "0xAA69E0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x14000001")]
	public event Action onUpdated
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xAA681C", Offset = "0xAA681C", VA = "0xAA681C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xAA68B8", Offset = "0xAA68B8", VA = "0xAA68B8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xAA6BE8", Offset = "0xAA6BE8", VA = "0xAA6BE8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xAA6DA4", Offset = "0xAA6DA4", VA = "0xAA6DA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xAA6DC8", Offset = "0xAA6DC8", VA = "0xAA6DC8")]
	public void AddPoint(BezierPoint point)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xAA6F2C", Offset = "0xAA6F2C", VA = "0xAA6F2C")]
	public BezierPoint AddPointAt(Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xAA7124", Offset = "0xAA7124", VA = "0xAA7124")]
	public void RemovePoint(BezierPoint point)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xAA720C", Offset = "0xAA720C", VA = "0xAA720C")]
	public BezierPoint[] GetAnchorPoints()
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xAA7284", Offset = "0xAA7284", VA = "0xAA7284")]
	public Vector3 GetPointAt(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xAA75C0", Offset = "0xAA75C0", VA = "0xAA75C0")]
	public int GetPointIndex(BezierPoint point)
	{
		return default(int);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xAA7674", Offset = "0xAA7674", VA = "0xAA7674")]
	public void SetDirty()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xAA6CC0", Offset = "0xAA6CC0", VA = "0xAA6CC0")]
	public static void DrawCurve(BezierPoint p1, BezierPoint p2, int resolution)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xAA74A4", Offset = "0xAA74A4", VA = "0xAA74A4")]
	public static Vector3 GetPoint(BezierPoint p1, BezierPoint p2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xAA7698", Offset = "0xAA7698", VA = "0xAA7698")]
	public static Vector3 GetCubicCurvePoint(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xAA774C", Offset = "0xAA774C", VA = "0xAA774C")]
	public static Vector3 GetQuadraticCurvePoint(Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xAA77CC", Offset = "0xAA77CC", VA = "0xAA77CC")]
	public static Vector3 GetLinearPoint(Vector3 p1, Vector3 p2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xAA77F4", Offset = "0xAA77F4", VA = "0xAA77F4")]
	public static Vector3 GetPoint(float t, params Vector3[] points)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xAA6AC4", Offset = "0xAA6AC4", VA = "0xAA6AC4")]
	public static float ApproximateLength(BezierPoint p1, BezierPoint p2, int resolution = 10)
	{
		return default(float);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xAA7968", Offset = "0xAA7968", VA = "0xAA7968")]
	private static int BinomialCoefficient(int i, int n)
	{
		return default(int);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xAA79FC", Offset = "0xAA79FC", VA = "0xAA79FC")]
	private static int Factoral(int i)
	{
		return default(int);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xAA7A2C", Offset = "0xAA7A2C", VA = "0xAA7A2C")]
	public void updateNow()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xAA7B2C", Offset = "0xAA7B2C", VA = "0xAA7B2C")]
	public BezierCurve()
	{
	}
}
[Serializable]
[Token(Token = "0x2000003")]
public class BezierPoint : MonoBehaviour
{
	[Token(Token = "0x2000004")]
	public enum HandleStyle
	{
		[Token(Token = "0x4000014")]
		Connected,
		[Token(Token = "0x4000015")]
		Broken,
		[Token(Token = "0x4000016")]
		None
	}

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private BezierCurve _curve;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public HandleStyle handleStyle;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _transform;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 _position;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float _handle1sqrMag;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 _handle1;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector3 _globalHandle1;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float _handle2sqrMag;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 _handle2;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3 _globalHandle2;

	[Token(Token = "0x17000006")]
	public BezierCurve curve
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xAA7BA0", Offset = "0xAA7BA0", VA = "0xAA7BA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0xAA7080", Offset = "0xAA7080", VA = "0xAA7080")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public Vector3 position
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0xAA7BA8", Offset = "0xAA7BA8", VA = "0xAA7BA8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0xAA7C54", Offset = "0xAA7C54", VA = "0xAA7C54")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public Vector3 handle1
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0xAA7C70", Offset = "0xAA7C70", VA = "0xAA7C70")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public Vector3 globalHandle1
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0xAA7DA8", Offset = "0xAA7DA8", VA = "0xAA7DA8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000024")]
		[Address(RVA = "0xAA7DDC", Offset = "0xAA7DDC", VA = "0xAA7DDC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Vector3 handle2
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0xAA7E04", Offset = "0xAA7E04", VA = "0xAA7E04")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public Vector3 globalHandle2
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0xAA7F3C", Offset = "0xAA7F3C", VA = "0xAA7F3C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0xAA7F70", Offset = "0xAA7F70", VA = "0xAA7F70")]
		set
		{
		}
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xAA7A94", Offset = "0xAA7A94", VA = "0xAA7A94")]
	public void updateNow()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xAA7F98", Offset = "0xAA7F98", VA = "0xAA7F98")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xAA8024", Offset = "0xAA8024", VA = "0xAA8024")]
	private void Update()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xAA806C", Offset = "0xAA806C", VA = "0xAA806C")]
	public BezierPoint()
	{
	}
}
[Token(Token = "0x2000005")]
public class TestPermissions : MonoBehaviour
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text text;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isGranted;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string WRITE_EXTERNAL_STORAGE;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xAA8074", Offset = "0xAA8074", VA = "0xAA8074")]
	private void Start()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xAA8078", Offset = "0xAA8078", VA = "0xAA8078")]
	private void Update()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xAA8124", Offset = "0xAA8124", VA = "0xAA8124")]
	public void CheckPerm()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xAA8190", Offset = "0xAA8190", VA = "0xAA8190")]
	public void GrantPerm()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xAA8244", Offset = "0xAA8244", VA = "0xAA8244")]
	public void PermissionGrantedCallback(bool isGranted)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xAA8250", Offset = "0xAA8250", VA = "0xAA8250")]
	public TestPermissions()
	{
	}
}
[Token(Token = "0x2000006")]
public static class MECExtensionMethods
{
	[Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class <CancelWith>d__0 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x1700000C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xAA8734", Offset = "0xAA8734", VA = "0xAA8734", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0xAA877C", Offset = "0xAA877C", VA = "0xAA877C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xAA8354", Offset = "0xAA8354", VA = "0xAA8354")]
		[DebuggerHidden]
		public <CancelWith>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xAA8530", Offset = "0xAA8530", VA = "0xAA8530", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xAA8534", Offset = "0xAA8534", VA = "0xAA8534", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xAA873C", Offset = "0xAA873C", VA = "0xAA873C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class <CancelWith>d__1 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x1700000E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xAA8A14", Offset = "0xAA8A14", VA = "0xAA8A14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xAA8A5C", Offset = "0xAA8A5C", VA = "0xAA8A5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xAA8420", Offset = "0xAA8420", VA = "0xAA8420")]
		[DebuggerHidden]
		public <CancelWith>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xAA87D8", Offset = "0xAA87D8", VA = "0xAA87D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xAA87DC", Offset = "0xAA87DC", VA = "0xAA87DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xAA8A1C", Offset = "0xAA8A1C", VA = "0xAA8A1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class <CancelWith>d__2 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject gameObject3;

		[Token(Token = "0x17000010")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0xAA8D2C", Offset = "0xAA8D2C", VA = "0xAA8D2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0xAA8D74", Offset = "0xAA8D74", VA = "0xAA8D74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xAA8508", Offset = "0xAA8508", VA = "0xAA8508")]
		[DebuggerHidden]
		public <CancelWith>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xAA8AB8", Offset = "0xAA8AB8", VA = "0xAA8AB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xAA8ABC", Offset = "0xAA8ABC", VA = "0xAA8ABC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xAA8D34", Offset = "0xAA8D34", VA = "0xAA8D34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xAA82C4", Offset = "0xAA82C4", VA = "0xAA82C4")]
	[IteratorStateMachine(typeof(<CancelWith>d__0))]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xAA837C", Offset = "0xAA837C", VA = "0xAA837C")]
	[IteratorStateMachine(typeof(<CancelWith>d__1))]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xAA8448", Offset = "0xAA8448", VA = "0xAA8448")]
	[IteratorStateMachine(typeof(<CancelWith>d__2))]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2, GameObject gameObject3)
	{
		return null;
	}
}
namespace MEC
{
	[Token(Token = "0x200000A")]
	public class Timing : MonoBehaviour
	{
		[Token(Token = "0x200000B")]
		private struct ProcessIndex : IEquatable<ProcessIndex>
		{
			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Segment seg;

			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int i;

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xAB32B8", Offset = "0xAB32B8", VA = "0xAB32B8", Slot = "4")]
			public bool Equals(ProcessIndex other)
			{
				return default(bool);
			}

			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xAB32E0", Offset = "0xAB32E0", VA = "0xAB32E0", Slot = "0")]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xAB3368", Offset = "0xAB3368", VA = "0xAB3368")]
			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xAB3388", Offset = "0xAB3388", VA = "0xAB3388")]
			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xAB33A8", Offset = "0xAB33A8", VA = "0xAB33A8", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class <_InjectDelay>d__124 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delayTime;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x17000018")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60000CC")]
				[Address(RVA = "0xAB3508", Offset = "0xAB3508", VA = "0xAB3508", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000019")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000CE")]
				[Address(RVA = "0xAB3550", Offset = "0xAB3550", VA = "0xAB3550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xAB12B0", Offset = "0xAB12B0", VA = "0xAB12B0")]
			[DebuggerHidden]
			public <_InjectDelay>d__124(int <>1__state)
			{
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xAB33C8", Offset = "0xAB33C8", VA = "0xAB33C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xAB33CC", Offset = "0xAB33CC", VA = "0xAB33CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xAB3510", Offset = "0xAB3510", VA = "0xAB3510", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class <_StartWhenDone>d__132 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CoroutineHandle handle;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x1700001A")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60000D3")]
				[Address(RVA = "0xAB3950", Offset = "0xAB3950", VA = "0xAB3950", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000D5")]
				[Address(RVA = "0xAB3998", Offset = "0xAB3998", VA = "0xAB3998", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xAB1DF0", Offset = "0xAB1DF0", VA = "0xAB1DF0")]
			[DebuggerHidden]
			public <_StartWhenDone>d__132(int <>1__state)
			{
			}

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xAB35AC", Offset = "0xAB35AC", VA = "0xAB35AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xAB35D8", Offset = "0xAB35D8", VA = "0xAB35D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xAB3928", Offset = "0xAB3928", VA = "0xAB3928")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xAB3958", Offset = "0xAB3958", VA = "0xAB3958", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class <_StartWhenDone>d__138 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncOperation operation;

			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x1700001C")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60000D9")]
				[Address(RVA = "0xAB3B30", Offset = "0xAB3B30", VA = "0xAB3B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700001D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000DB")]
				[Address(RVA = "0xAB3B78", Offset = "0xAB3B78", VA = "0xAB3B78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xAB21A4", Offset = "0xAB21A4", VA = "0xAB21A4")]
			[DebuggerHidden]
			public <_StartWhenDone>d__138(int <>1__state)
			{
			}

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xAB39F4", Offset = "0xAB39F4", VA = "0xAB39F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xAB39F8", Offset = "0xAB39F8", VA = "0xAB39F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xAB3B38", Offset = "0xAB3B38", VA = "0xAB3B38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class <_StartWhenDone>d__140 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomYieldInstruction operation;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x1700001E")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60000DF")]
				[Address(RVA = "0xAB3D14", Offset = "0xAB3D14", VA = "0xAB3D14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700001F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000E1")]
				[Address(RVA = "0xAB3D5C", Offset = "0xAB3D5C", VA = "0xAB3D5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xAB2404", Offset = "0xAB2404", VA = "0xAB2404")]
			[DebuggerHidden]
			public <_StartWhenDone>d__140(int <>1__state)
			{
			}

			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xAB3BD4", Offset = "0xAB3BD4", VA = "0xAB3BD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xAB3BD8", Offset = "0xAB3BD8", VA = "0xAB3BD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xAB3D1C", Offset = "0xAB3D1C", VA = "0xAB3D1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class <_DelayedCall>d__147 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject cancelWith;

			[Token(Token = "0x400007E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action action;

			[Token(Token = "0x17000020")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60000E5")]
				[Address(RVA = "0xAB3E88", Offset = "0xAB3E88", VA = "0xAB3E88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000021")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000E7")]
				[Address(RVA = "0xAB3ED0", Offset = "0xAB3ED0", VA = "0xAB3ED0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xAB29B4", Offset = "0xAB29B4", VA = "0xAB29B4")]
			[DebuggerHidden]
			public <_DelayedCall>d__147(int <>1__state)
			{
			}

			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xAB3DB8", Offset = "0xAB3DB8", VA = "0xAB3DB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xAB3DBC", Offset = "0xAB3DBC", VA = "0xAB3DBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xAB3E90", Offset = "0xAB3E90", VA = "0xAB3E90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class <_CallContinuously>d__156 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float period;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action action;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeframe;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action onDone;

			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private double <startTime>5__2;

			[Token(Token = "0x17000022")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60000EB")]
				[Address(RVA = "0xAB3FF8", Offset = "0xAB3FF8", VA = "0xAB3FF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000023")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000ED")]
				[Address(RVA = "0xAB4040", Offset = "0xAB4040", VA = "0xAB4040", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xAB2E10", Offset = "0xAB2E10", VA = "0xAB2E10")]
			[DebuggerHidden]
			public <_CallContinuously>d__156(int <>1__state)
			{
			}

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xAB3F2C", Offset = "0xAB3F2C", VA = "0xAB3F2C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xAB3F30", Offset = "0xAB3F30", VA = "0xAB3F30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xAB4000", Offset = "0xAB4000", VA = "0xAB4000", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class <_CallContinuously>d__165<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <>2__current;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Timing <>4__this;

			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float period;

			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> action;

			[Token(Token = "0x400008C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x400008D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float timeframe;

			[Token(Token = "0x400008E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onDone;

			[Token(Token = "0x400008F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private double <startTime>5__2;

			[Token(Token = "0x17000024")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60000F1")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000025")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F3")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000EE")]
			[DebuggerHidden]
			public <_CallContinuously>d__165(int <>1__state)
			{
			}

			[Token(Token = "0x60000EF")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000F0")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000F2")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("How quickly the SlowUpdate segment ticks.")]
		public float TimeBetweenSlowUpdateCalls;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("How much data should be sent to the profiler window when it's open.")]
		public DebugInfoType ProfilerDebugAmount;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Space(12f)]
		[Tooltip("A count of the number of Update coroutines that are currently running.")]
		public int UpdateCoroutines;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("A count of the number of FixedUpdate coroutines that are currently running.")]
		public int FixedUpdateCoroutines;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("A count of the number of LateUpdate coroutines that are currently running.")]
		public int LateUpdateCoroutines;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("A count of the number of SlowUpdate coroutines that are currently running.")]
		public int SlowUpdateCoroutines;

		[NonSerialized]
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float localTime;

		[NonSerialized]
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float deltaTime;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<IEnumerator<float>, CoroutineHandle, IEnumerator<float>> ReplacementFunction;

		[Token(Token = "0x4000033")]
		public const float WaitForOneFrame = float.NegativeInfinity;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CoroutineHandle _currentCoroutine;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static object _tmpRef;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool _tmpBool;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static CoroutineHandle _tmpHandle;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _currentUpdateFrame;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _currentLateUpdateFrame;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _currentSlowUpdateFrame;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _nextUpdateProcessSlot;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _nextLateUpdateProcessSlot;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _nextFixedUpdateProcessSlot;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _nextSlowUpdateProcessSlot;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _lastUpdateProcessSlot;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _lastLateUpdateProcessSlot;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _lastFixedUpdateProcessSlot;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _lastSlowUpdateProcessSlot;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _lastUpdateTime;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _lastLateUpdateTime;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _lastFixedUpdateTime;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _lastSlowUpdateTime;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _lastSlowUpdateDeltaTime;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private ushort _framesSinceUpdate;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		private ushort _expansions;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[HideInInspector]
		private byte _instanceID;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly HashSet<CoroutineHandle> _allWaiting;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Dictionary<CoroutineHandle, string> _processTags;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private IEnumerator<float>[] UpdateProcesses;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private IEnumerator<float>[] LateUpdateProcesses;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private IEnumerator<float>[] FixedUpdateProcesses;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private IEnumerator<float>[] SlowUpdateProcesses;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool[] UpdatePaused;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool[] LateUpdatePaused;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool[] FixedUpdatePaused;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool[] SlowUpdatePaused;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool[] UpdateHeld;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool[] LateUpdateHeld;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool[] FixedUpdateHeld;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool[] SlowUpdateHeld;

		[Token(Token = "0x400005E")]
		private const ushort FramesUntilMaintenance = 64;

		[Token(Token = "0x400005F")]
		private const int ProcessArrayChunkSize = 64;

		[Token(Token = "0x4000060")]
		private const int InitialBufferSizeLarge = 256;

		[Token(Token = "0x4000061")]
		private const int InitialBufferSizeMedium = 64;

		[Token(Token = "0x4000062")]
		private const int InitialBufferSizeSmall = 8;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Timing[] ActiveInstances;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Timing _instance;

		[Token(Token = "0x17000012")]
		public static float LocalTime
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0xAA8DD0", Offset = "0xAA8DD0", VA = "0xAA8DD0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000013")]
		public static float DeltaTime
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xAA9064", Offset = "0xAA9064", VA = "0xAA9064")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000014")]
		public static Thread MainThread
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0xAA9278", Offset = "0xAA9278", VA = "0xAA9278")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0xAA92D0", Offset = "0xAA92D0", VA = "0xAA92D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public static CoroutineHandle CurrentCoroutine
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0xAA9330", Offset = "0xAA9330", VA = "0xAA9330")]
			get
			{
				return default(CoroutineHandle);
			}
		}

		[Token(Token = "0x17000016")]
		public CoroutineHandle currentCoroutine
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0xAA9484", Offset = "0xAA9484", VA = "0xAA9484")]
			get
			{
				return default(CoroutineHandle);
			}
		}

		[Token(Token = "0x17000017")]
		public static Timing Instance
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0xAA8E2C", Offset = "0xAA8E2C", VA = "0xAA8E2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0xAA96CC", Offset = "0xAA96CC", VA = "0xAA96CC")]
			set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event Action OnPreExecute
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xAA90C0", Offset = "0xAA90C0", VA = "0xAA90C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xAA919C", Offset = "0xAA919C", VA = "0xAA919C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xAA972C", Offset = "0xAA972C", VA = "0xAA972C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xAA98CC", Offset = "0xAA98CC", VA = "0xAA98CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xAA9990", Offset = "0xAA9990", VA = "0xAA9990")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xAA9A54", Offset = "0xAA9A54", VA = "0xAA9A54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xAA9A58", Offset = "0xAA9A58", VA = "0xAA9A58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xAA948C", Offset = "0xAA948C", VA = "0xAA948C")]
		private void InitializeInstanceID()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xAA9B14", Offset = "0xAA9B14", VA = "0xAA9B14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xAAB9F4", Offset = "0xAAB9F4", VA = "0xAAB9F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xAAC108", Offset = "0xAAC108", VA = "0xAAC108")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xAAAAF8", Offset = "0xAAAAF8", VA = "0xAAAAF8")]
		private void RemoveUnused()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xAACC14", Offset = "0xAACC14", VA = "0xAACC14")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xAAE3EC", Offset = "0xAAE3EC", VA = "0xAAE3EC")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xAAE49C", Offset = "0xAAE49C", VA = "0xAAE49C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xAAE54C", Offset = "0xAAE54C", VA = "0xAAE54C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xAAE600", Offset = "0xAAE600", VA = "0xAAE600")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xAAE658", Offset = "0xAAE658", VA = "0xAAE658")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xAAE6BC", Offset = "0xAAE6BC", VA = "0xAAE6BC")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xAAE720", Offset = "0xAAE720", VA = "0xAAE720")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xAACD68", Offset = "0xAACD68", VA = "0xAACD68")]
		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, string tag, CoroutineHandle handle, bool prewarm)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xAAE8F8", Offset = "0xAAE8F8", VA = "0xAAE8F8")]
		public static int KillCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xAAE9C0", Offset = "0xAAE9C0", VA = "0xAAE9C0")]
		public int KillCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xAAEC74", Offset = "0xAAEC74", VA = "0xAAEC74")]
		public static int KillCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xAAAA08", Offset = "0xAAAA08", VA = "0xAAAA08")]
		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xAAEE98", Offset = "0xAAEE98", VA = "0xAAEE98")]
		public static int KillCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xAAEF68", Offset = "0xAAEF68", VA = "0xAAEF68")]
		public int KillCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xAAF244", Offset = "0xAAF244", VA = "0xAAF244")]
		public static int PauseCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xAAF30C", Offset = "0xAAF30C", VA = "0xAAF30C")]
		public int PauseCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xAAFB9C", Offset = "0xAAFB9C", VA = "0xAAFB9C")]
		public static int PauseCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xAAFC90", Offset = "0xAAFC90", VA = "0xAAFC90")]
		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xAB035C", Offset = "0xAB035C", VA = "0xAB035C")]
		public static int PauseCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xAB042C", Offset = "0xAB042C", VA = "0xAB042C")]
		public int PauseCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xAB05AC", Offset = "0xAB05AC", VA = "0xAB05AC")]
		public static int ResumeCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xAB0674", Offset = "0xAB0674", VA = "0xAB0674")]
		public int ResumeCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xAB0828", Offset = "0xAB0828", VA = "0xAB0828")]
		public static int ResumeCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xAB091C", Offset = "0xAB091C", VA = "0xAB091C")]
		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xAB09E8", Offset = "0xAB09E8", VA = "0xAB09E8")]
		public static int ResumeCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xAB0AB8", Offset = "0xAB0AB8", VA = "0xAB0AB8")]
		public int ResumeCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xAAA878", Offset = "0xAAA878", VA = "0xAAA878")]
		private bool UpdateTimeValues(Segment segment)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xAAFA4C", Offset = "0xAAFA4C", VA = "0xAAFA4C")]
		private float GetSegmentTime(Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xAAED74", Offset = "0xAAED74", VA = "0xAAED74")]
		public static Timing GetInstance(byte ID)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xAAE788", Offset = "0xAAE788", VA = "0xAAE788")]
		private void AddTag(string tag, CoroutineHandle coindex)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xAACA80", Offset = "0xAACA80", VA = "0xAACA80")]
		private void RemoveTag(CoroutineHandle coindex)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xAAF1AC", Offset = "0xAAF1AC", VA = "0xAAF1AC")]
		private bool Nullify(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xAAEE04", Offset = "0xAAEE04", VA = "0xAAEE04")]
		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xAB0C34", Offset = "0xAB0C34", VA = "0xAB0C34")]
		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xAAC818", Offset = "0xAAC818", VA = "0xAAC818")]
		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xAAFD60", Offset = "0xAAFD60", VA = "0xAAFD60")]
		private bool SetPause(ProcessIndex coindex, bool newPausedState)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xAB0CB4", Offset = "0xAB0CB4", VA = "0xAB0CB4")]
		private bool SetHeld(ProcessIndex coindex, bool newHeldState)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xAAFAFC", Offset = "0xAAFAFC", VA = "0xAAFAFC")]
		[IteratorStateMachine(typeof(<_InjectDelay>d__124))]
		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float delayTime)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xAB12D8", Offset = "0xAB12D8", VA = "0xAB12D8")]
		private bool CoindexIsPaused(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xAB1364", Offset = "0xAB1364", VA = "0xAB1364")]
		private bool CoindexIsHeld(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xAB13F0", Offset = "0xAB13F0", VA = "0xAB13F0")]
		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xAB14B0", Offset = "0xAB14B0", VA = "0xAB14B0")]
		public static float WaitForSeconds(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xAB1558", Offset = "0xAB1558", VA = "0xAB1558")]
		public float WaitForSecondsOnInstance(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xAB15D4", Offset = "0xAB15D4", VA = "0xAB15D4")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xAB162C", Offset = "0xAB162C", VA = "0xAB162C")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			return default(float);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xAB1950", Offset = "0xAB1950", VA = "0xAB1950")]
		[IteratorStateMachine(typeof(<_StartWhenDone>d__132))]
		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xAB19F4", Offset = "0xAB19F4", VA = "0xAB19F4")]
		private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xAAC8A4", Offset = "0xAAC8A4", VA = "0xAAC8A4")]
		private void CloseWaitingProcess(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xAB1E18", Offset = "0xAB1E18", VA = "0xAB1E18")]
		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xAB1F00", Offset = "0xAB1F00", VA = "0xAB1F00")]
		private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xAB1F70", Offset = "0xAB1F70", VA = "0xAB1F70")]
		public static float WaitUntilDone(AsyncOperation operation)
		{
			return default(float);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xAB2114", Offset = "0xAB2114", VA = "0xAB2114")]
		[IteratorStateMachine(typeof(<_StartWhenDone>d__138))]
		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xAB21CC", Offset = "0xAB21CC", VA = "0xAB21CC")]
		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			return default(float);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xAB2374", Offset = "0xAB2374", VA = "0xAB2374")]
		[IteratorStateMachine(typeof(<_StartWhenDone>d__140))]
		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xAB242C", Offset = "0xAB242C", VA = "0xAB242C")]
		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xAB2600", Offset = "0xAB2600", VA = "0xAB2600")]
		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xAB2780", Offset = "0xAB2780", VA = "0xAB2780")]
		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xAB28C0", Offset = "0xAB28C0", VA = "0xAB28C0")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xAB28F4", Offset = "0xAB28F4", VA = "0xAB28F4")]
		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject cancelWith)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xAB2984", Offset = "0xAB2984", VA = "0xAB2984")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject cancelWith)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xAB280C", Offset = "0xAB280C", VA = "0xAB280C")]
		[IteratorStateMachine(typeof(<_DelayedCall>d__147))]
		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xAB29DC", Offset = "0xAB29DC", VA = "0xAB29DC")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xAB2B34", Offset = "0xAB2B34", VA = "0xAB2B34")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xAB2B68", Offset = "0xAB2B68", VA = "0xAB2B68")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment segment, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xAB2C10", Offset = "0xAB2C10", VA = "0xAB2C10")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment segment, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xAB2C54", Offset = "0xAB2C54", VA = "0xAB2C54")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xAB2CEC", Offset = "0xAB2CEC", VA = "0xAB2CEC")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xAB2D24", Offset = "0xAB2D24", VA = "0xAB2D24")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xAB2DC8", Offset = "0xAB2DC8", VA = "0xAB2DC8")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xAB2A78", Offset = "0xAB2A78", VA = "0xAB2A78")]
		[IteratorStateMachine(typeof(<_CallContinuously>d__156))]
		private IEnumerator<float> _CallContinuously(float timeframe, float period, Action action, Action onDone)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A4")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A5")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A6")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A7")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A8")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A9")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000AA")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000AB")]
		[IteratorStateMachine(typeof(<_CallContinuously>d__165<>))]
		private IEnumerator<float> _CallContinuously<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xAB2E38", Offset = "0xAB2E38", VA = "0xAB2E38")]
		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xAB2E40", Offset = "0xAB2E40", VA = "0xAB2E40")]
		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xAB2E48", Offset = "0xAB2E48", VA = "0xAB2E48")]
		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xAB2E50", Offset = "0xAB2E50", VA = "0xAB2E50")]
		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xAB2E58", Offset = "0xAB2E58", VA = "0xAB2E58")]
		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopCoroutine(string methodName)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xAB2E5C", Offset = "0xAB2E5C", VA = "0xAB2E5C")]
		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xAB2E60", Offset = "0xAB2E60", VA = "0xAB2E60")]
		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xAB2E64", Offset = "0xAB2E64", VA = "0xAB2E64")]
		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopAllCoroutines()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xAB2E68", Offset = "0xAB2E68", VA = "0xAB2E68")]
		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xAB2E6C", Offset = "0xAB2E6C", VA = "0xAB2E6C")]
		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xAB2E70", Offset = "0xAB2E70", VA = "0xAB2E70")]
		[Obsolete("Use your own GameObject for this.", true)]
		public static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xAB2E74", Offset = "0xAB2E74", VA = "0xAB2E74")]
		[Obsolete("Use your own GameObject for this.", true)]
		public static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xAB2E78", Offset = "0xAB2E78", VA = "0xAB2E78")]
		[Obsolete("Use your own GameObject for this.", true)]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xAB2E7C", Offset = "0xAB2E7C", VA = "0xAB2E7C")]
		[Obsolete("Use your own GameObject for this.", true)]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xAB2E80", Offset = "0xAB2E80", VA = "0xAB2E80")]
		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Instantiate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xAB2E84", Offset = "0xAB2E84", VA = "0xAB2E84")]
		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60000BC")]
		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Instantiate<T>(T original) where T : UnityEngine.Object
		{
		}

		[Token(Token = "0x60000BD")]
		[Obsolete("Just.. no.", true)]
		public new static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xAB2E88", Offset = "0xAB2E88", VA = "0xAB2E88")]
		[Obsolete("Just.. no.", true)]
		public new static UnityEngine.Object FindObjectOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Obsolete("Just.. no.", true)]
		public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xAB2E90", Offset = "0xAB2E90", VA = "0xAB2E90")]
		[Obsolete("Just.. no.", true)]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xAB2E98", Offset = "0xAB2E98", VA = "0xAB2E98")]
		[Obsolete("Just.. no.", true)]
		public new static void print(object message)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xAB2E9C", Offset = "0xAB2E9C", VA = "0xAB2E9C")]
		public Timing()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public enum Segment
	{
		[Token(Token = "0x4000091")]
		Invalid = -1,
		[Token(Token = "0x4000092")]
		Update,
		[Token(Token = "0x4000093")]
		FixedUpdate,
		[Token(Token = "0x4000094")]
		LateUpdate,
		[Token(Token = "0x4000095")]
		SlowUpdate
	}
	[Token(Token = "0x2000014")]
	public enum DebugInfoType
	{
		[Token(Token = "0x4000097")]
		None,
		[Token(Token = "0x4000098")]
		SeperateCoroutines,
		[Token(Token = "0x4000099")]
		SeperateTags
	}
	[Token(Token = "0x2000015")]
	public struct CoroutineHandle : IEquatable<CoroutineHandle>
	{
		[Token(Token = "0x400009A")]
		private const byte ReservedSpace = 15;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] NextIndex;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int _id;

		[Token(Token = "0x17000026")]
		public byte Key
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xAAED68", Offset = "0xAAED68", VA = "0xAAED68")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000027")]
		public bool IsValid
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xAA9474", Offset = "0xAA9474", VA = "0xAA9474")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xAACCB8", Offset = "0xAACCB8", VA = "0xAACCB8")]
		public CoroutineHandle(byte ind)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xAB409C", Offset = "0xAB409C", VA = "0xAB409C", Slot = "4")]
		public bool Equals(CoroutineHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xAB40AC", Offset = "0xAB40AC", VA = "0xAB40AC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xAB19E8", Offset = "0xAB19E8", VA = "0xAB19E8")]
		public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xAB4124", Offset = "0xAB4124", VA = "0xAB4124")]
		public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xAB4130", Offset = "0xAB4130", VA = "0xAB4130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace RnxPlatform
{
	[Token(Token = "0x2000016")]
	[RequireComponent(typeof(RNXPlatformClientAPI))]
	public class CustomSets : MonoBehaviour
	{
		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RNXPlatformClientAPI rnxAPI;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CustomSets instance;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool init;

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xAB41C8", Offset = "0xAB41C8", VA = "0xAB41C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xAB4258", Offset = "0xAB4258", VA = "0xAB4258")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xAB425C", Offset = "0xAB425C", VA = "0xAB425C")]
		public void Init()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xAB42C4", Offset = "0xAB42C4", VA = "0xAB42C4")]
		public void GetNumSets(Action<bool, int> onResponse)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xAB46AC", Offset = "0xAB46AC", VA = "0xAB46AC")]
		public void GetSetMeta(int setNum, Action<bool, CustomSet> onResponse)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xAB4848", Offset = "0xAB4848", VA = "0xAB4848")]
		public void DownloadSetContent(string setContentUrl, string setContentMD5, string password, Action<bool, DownloadedCrate> onResponse)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xAB4998", Offset = "0xAB4998", VA = "0xAB4998")]
		public void UploadNewSet(byte[] content, Action<bool, CustomSet> onResponse)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xAB4C08", Offset = "0xAB4C08", VA = "0xAB4C08")]
		public void UploadExistingSet(int setNum, byte[] content, Action<bool, CustomSet> onResponse)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xAB4E98", Offset = "0xAB4E98", VA = "0xAB4E98")]
		private void _UploadContentToS3(int setNum, int version, string authorRnxId, byte[] content, string contentMD5, string uploadUrl, Action<bool, CustomSet> onResponse)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xAB5128", Offset = "0xAB5128", VA = "0xAB5128")]
		public void VoteSetForMC(int setNum, bool vote, Action<bool, bool> onResponse)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xAB5348", Offset = "0xAB5348", VA = "0xAB5348")]
		public void GetMySetVoteForMC(int setNum, Action<bool, bool> onResponse)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xAB5538", Offset = "0xAB5538", VA = "0xAB5538")]
		public CustomSets()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[RequireComponent(typeof(RNXPlatformClientAPI))]
	public class Leaderboard : MonoBehaviour
	{
		[Token(Token = "0x2000020")]
		public enum Type
		{
			[Token(Token = "0x40000BA")]
			Undefined,
			[Token(Token = "0x40000BB")]
			Normal,
			[Token(Token = "0x40000BC")]
			CoOp
		}

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RNXPlatformClientAPI rnxAPI;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Leaderboard instance;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool init;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xAB61EC", Offset = "0xAB61EC", VA = "0xAB61EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xAB6288", Offset = "0xAB6288", VA = "0xAB6288")]
		private void Start()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xAB628C", Offset = "0xAB628C", VA = "0xAB628C")]
		public void Init()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xAB62F4", Offset = "0xAB62F4", VA = "0xAB62F4")]
		public void FindOrCreateLeaderboard(Type type, string leaderboardName, LeaderboardSortMethod sortOrder, Action<bool> onResponse)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xAB6534", Offset = "0xAB6534", VA = "0xAB6534")]
		public void UpdateUserEntry(Type type, string leaderboardName, int value, LeaderboardEntryData entryData, string rnxId, string rnxId2, LeaderboardUpdateMethod updateMethod, Action<bool, LeaderboardEntry, LeaderboardEntry> onResponse)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xAB6788", Offset = "0xAB6788", VA = "0xAB6788")]
		public void GetEntries(Type type, string leaderboardName, string rnxId, string rnxId2, int start, int count, Action<bool, List<LeaderboardEntry>> onResponse)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xAB69AC", Offset = "0xAB69AC", VA = "0xAB69AC")]
		private static string min(string rnxId1, string rnxId2)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xAB69FC", Offset = "0xAB69FC", VA = "0xAB69FC")]
		private static string max(string rnxId1, string rnxId2)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xAB6A28", Offset = "0xAB6A28", VA = "0xAB6A28")]
		public Leaderboard()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[RequireComponent(typeof(Leaderboard))]
	public class LeaderboardTests : MonoBehaviour
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Leaderboard leaderboard;

		[Token(Token = "0x40000C1")]
		private const Leaderboard.Type leaderboardType = Leaderboard.Type.Normal;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xAB7660", Offset = "0xAB7660", VA = "0xAB7660")]
		private void Start()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xAB76C0", Offset = "0xAB76C0", VA = "0xAB76C0")]
		private void LeaderboardFlowTest()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xAB7824", Offset = "0xAB7824", VA = "0xAB7824")]
		public LeaderboardTests()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class CustomSet
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int num;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string authorRnxId;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string authorName;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int version;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string url;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string md5;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xAB5864", Offset = "0xAB5864", VA = "0xAB5864")]
		public CustomSet()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class LeaderboardEntry
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int row;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int value;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string rnxId;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string rnxId2;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LeaderboardEntryData entryData;

		[Token(Token = "0x17000028")]
		public int rank
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0xAB7DF0", Offset = "0xAB7DF0", VA = "0xAB7DF0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		public bool hasUser2
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0xAB7DFC", Offset = "0xAB7DFC", VA = "0xAB7DFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xAB6EDC", Offset = "0xAB6EDC", VA = "0xAB6EDC")]
		public LeaderboardEntry()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class LeaderboardEntryData
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string data;

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xAB6EE4", Offset = "0xAB6EE4", VA = "0xAB6EE4")]
		public LeaderboardEntryData(string data)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public enum LeaderboardSortMethod
	{
		[Token(Token = "0x40000D6")]
		Ascending,
		[Token(Token = "0x40000D7")]
		Descending
	}
	[Token(Token = "0x200002B")]
	public static class LeaderboardSortMethodMethods
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0xAB64C4", Offset = "0xAB64C4", VA = "0xAB64C4")]
		public static string toCharKey(LeaderboardSortMethod sortOrder)
		{
			return null;
		}
	}
	[Token(Token = "0x200002C")]
	public enum LeaderboardUpdateMethod
	{
		[Token(Token = "0x40000D9")]
		keepBest,
		[Token(Token = "0x40000DA")]
		forceUpdate
	}
	[Token(Token = "0x200002D")]
	public enum Platform
	{
		[Token(Token = "0x40000DC")]
		Unknown,
		[Token(Token = "0x40000DD")]
		Steam,
		[Token(Token = "0x40000DE")]
		OculusHome,
		[Token(Token = "0x40000DF")]
		Windows,
		[Token(Token = "0x40000E0")]
		Viveport,
		[Token(Token = "0x40000E1")]
		Pico,
		[Token(Token = "0x40000E2")]
		NetVios,
		[Token(Token = "0x40000E3")]
		WeChat,
		[Token(Token = "0x40000E4")]
		PlayStation,
		[Token(Token = "0x40000E5")]
		iQIYI,
		[Token(Token = "0x40000E6")]
		YVR,
		[Token(Token = "0x40000E7")]
		GSXR
	}
	[Token(Token = "0x200002E")]
	public enum StatsName
	{
		[Token(Token = "0x40000E9")]
		Profile2,
		[Token(Token = "0x40000EA")]
		Analytics2
	}
	[Token(Token = "0x200002F")]
	public enum Status
	{
		[Token(Token = "0x40000EC")]
		Offline,
		[Token(Token = "0x40000ED")]
		NotInRacket_Online,
		[Token(Token = "0x40000EE")]
		NotInRacket_Away,
		[Token(Token = "0x40000EF")]
		NotInRacket_Busy,
		[Token(Token = "0x40000F0")]
		InMenus,
		[Token(Token = "0x40000F1")]
		PlayingSolo,
		[Token(Token = "0x40000F2")]
		PlayingArcade,
		[Token(Token = "0x40000F3")]
		PlayingMultiplayer,
		[Token(Token = "0x40000F4")]
		PlayingCustomSet,
		[Token(Token = "0x40000F5")]
		EditingCustomSet,
		[Token(Token = "0x40000F6")]
		Last
	}
	[Token(Token = "0x2000030")]
	public static class StatusMethods
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0xAB7E1C", Offset = "0xAB7E1C", VA = "0xAB7E1C")]
		public static Status FromString(string statusString)
		{
			return default(Status);
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class User
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string rnxId;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string userName;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Platform platformName;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string platformUserId;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D avatarImage;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string avatarUrl;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Sprite _sprite;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Texture2D _spriteTex;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Status status;

		[Token(Token = "0x1700002A")]
		public Sprite sprite
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0xAB7F1C", Offset = "0xAB7F1C", VA = "0xAB7F1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public bool playingRacket
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xAB8084", Offset = "0xAB8084", VA = "0xAB8084")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xAB8094", Offset = "0xAB8094", VA = "0xAB8094")]
		public User()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xAB809C", Offset = "0xAB809C", VA = "0xAB809C")]
		public User(User copyFrom)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public enum RequestMethod
	{
		[Token(Token = "0x4000101")]
		NONE,
		[Token(Token = "0x4000102")]
		GET,
		[Token(Token = "0x4000103")]
		POST,
		[Token(Token = "0x4000104")]
		PUT
	}
	[Token(Token = "0x2000033")]
	public abstract class BaseRequest
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private StringBuilder _builder;

		[Token(Token = "0x6000147")]
		public abstract string getAPIEndpoint();

		[Token(Token = "0x6000148")]
		public abstract RequestMethod GetMethod();

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xAB8144", Offset = "0xAB8144", VA = "0xAB8144", Slot = "6")]
		public virtual string GetBodyParams()
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xAB8184", Offset = "0xAB8184", VA = "0xAB8184", Slot = "7")]
		public virtual Dictionary<string, string> GetQueryParams()
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xAB81F4", Offset = "0xAB81F4", VA = "0xAB81F4")]
		protected Dictionary<string, string> ArrayToDictionary(string key, string[] array)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xAB8344", Offset = "0xAB8344", VA = "0xAB8344")]
		protected BaseRequest()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class CustomSetsGetSetRequest : BaseRequest
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _setNum;

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xAB4824", Offset = "0xAB4824", VA = "0xAB4824")]
		public CustomSetsGetSetRequest(int setNum)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xAB83B8", Offset = "0xAB83B8", VA = "0xAB83B8", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xAB843C", Offset = "0xAB843C", VA = "0xAB843C", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}
	}
	[Token(Token = "0x2000035")]
	public class CustomSetsGetSetsRequest : BaseRequest
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xAB8444", Offset = "0xAB8444", VA = "0xAB8444", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xAB8484", Offset = "0xAB8484", VA = "0xAB8484", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xAB442C", Offset = "0xAB442C", VA = "0xAB442C")]
		public CustomSetsGetSetsRequest()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class CustomSetsGetVoteForMCRequest : BaseRequest
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _setNum;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _rnxId;

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xAB5504", Offset = "0xAB5504", VA = "0xAB5504")]
		public CustomSetsGetVoteForMCRequest(int setNum, string voterRnxId)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xAB848C", Offset = "0xAB848C", VA = "0xAB848C", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xAB8510", Offset = "0xAB8510", VA = "0xAB8510", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xAB8518", Offset = "0xAB8518", VA = "0xAB8518", Slot = "7")]
		public override Dictionary<string, string> GetQueryParams()
		{
			return null;
		}
	}
	[Token(Token = "0x2000037")]
	public class CustomSetsUploadExistingRequest : BaseRequest
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _setNum;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string rnxId;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string md5;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xAB4E48", Offset = "0xAB4E48", VA = "0xAB4E48")]
		public CustomSetsUploadExistingRequest(int setNum, string rnxId, string setContentMD5)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xAB85D0", Offset = "0xAB85D0", VA = "0xAB85D0", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xAB8654", Offset = "0xAB8654", VA = "0xAB8654", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xAB865C", Offset = "0xAB865C", VA = "0xAB865C", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}
	}
	[Token(Token = "0x2000038")]
	public class CustomSetsUploadNewRequest : BaseRequest
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string rnxId;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string md5;

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xAB4BC8", Offset = "0xAB4BC8", VA = "0xAB4BC8")]
		public CustomSetsUploadNewRequest(string rnxId, string setContentMD5)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xAB8664", Offset = "0xAB8664", VA = "0xAB8664", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xAB86A4", Offset = "0xAB86A4", VA = "0xAB86A4", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xAB86AC", Offset = "0xAB86AC", VA = "0xAB86AC", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}
	}
	[Token(Token = "0x2000039")]
	public class CustomSetsVoteForMCRequest : BaseRequest
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _setNum;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string rnxId;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool vote;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xAB5300", Offset = "0xAB5300", VA = "0xAB5300")]
		public CustomSetsVoteForMCRequest(int setNum, string voterRnxId, bool vote)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xAB86B4", Offset = "0xAB86B4", VA = "0xAB86B4", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xAB8738", Offset = "0xAB8738", VA = "0xAB8738", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xAB8740", Offset = "0xAB8740", VA = "0xAB8740", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}
	}
	[Token(Token = "0x200003A")]
	public abstract class LeaderboardBaseRequest : BaseRequest
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Leaderboard.Type _leaderboardType;

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xAB8748", Offset = "0xAB8748", VA = "0xAB8748")]
		public LeaderboardBaseRequest(Leaderboard.Type leaderboardType)
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class LeaderboardCreateRequest : LeaderboardBaseRequest
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string leaderboardName;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sortOrder;

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xAB64A0", Offset = "0xAB64A0", VA = "0xAB64A0")]
		public LeaderboardCreateRequest(Leaderboard.Type leaderboardType)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xAB876C", Offset = "0xAB876C", VA = "0xAB876C", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xAB8860", Offset = "0xAB8860", VA = "0xAB8860", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xAB8868", Offset = "0xAB8868", VA = "0xAB8868", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}
	}
	[Token(Token = "0x200003C")]
	public class LeaderboardGetEntriesRequest : LeaderboardBaseRequest
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string leaderboardName;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string rnxId;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string rnxId2;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int start;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int count;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xAB69D8", Offset = "0xAB69D8", VA = "0xAB69D8")]
		public LeaderboardGetEntriesRequest(Leaderboard.Type leaderboardType)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xAB8870", Offset = "0xAB8870", VA = "0xAB8870", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xAB8964", Offset = "0xAB8964", VA = "0xAB8964", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xAB896C", Offset = "0xAB896C", VA = "0xAB896C", Slot = "7")]
		public override Dictionary<string, string> GetQueryParams()
		{
			return null;
		}
	}
	[Token(Token = "0x200003D")]
	public class LeaderboardUpdateUserEntryRequest : LeaderboardBaseRequest
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string leaderboardName;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int value;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string data;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string updateMethod;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string rnxId;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string rnxId2;

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xAB6764", Offset = "0xAB6764", VA = "0xAB6764")]
		public LeaderboardUpdateUserEntryRequest(Leaderboard.Type leaderboardType)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xAB8AF4", Offset = "0xAB8AF4", VA = "0xAB8AF4", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xAB8BE8", Offset = "0xAB8BE8", VA = "0xAB8BE8", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xAB8BF0", Offset = "0xAB8BF0", VA = "0xAB8BF0", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}
	}
	[Token(Token = "0x200003E")]
	public class StatsData
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string data;

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xAB8C7C", Offset = "0xAB8C7C", VA = "0xAB8C7C")]
		public StatsData(string data)
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class StatsGetRequest : BaseRequest
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] rnxId;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string statsName;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xAB8CAC", Offset = "0xAB8CAC", VA = "0xAB8CAC", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xAB8CEC", Offset = "0xAB8CEC", VA = "0xAB8CEC", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xAB8CF4", Offset = "0xAB8CF4", VA = "0xAB8CF4", Slot = "7")]
		public override Dictionary<string, string> GetQueryParams()
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xAB8EFC", Offset = "0xAB8EFC", VA = "0xAB8EFC")]
		public StatsGetRequest()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class StatsUpdateRequest : BaseRequest
	{
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string statsName;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string rnxId;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string data;

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xAB8F00", Offset = "0xAB8F00", VA = "0xAB8F00", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xAB8F40", Offset = "0xAB8F40", VA = "0xAB8F40", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xAB8F48", Offset = "0xAB8F48", VA = "0xAB8F48", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xAB8F50", Offset = "0xAB8F50", VA = "0xAB8F50")]
		public StatsUpdateRequest()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class UserGetDetailsRequest : BaseRequest
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] rnxId;

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xAB8F54", Offset = "0xAB8F54", VA = "0xAB8F54", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xAB8F94", Offset = "0xAB8F94", VA = "0xAB8F94", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xAB8F9C", Offset = "0xAB8F9C", VA = "0xAB8F9C", Slot = "7")]
		public override Dictionary<string, string> GetQueryParams()
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xAB8FE8", Offset = "0xAB8FE8", VA = "0xAB8FE8")]
		public UserGetDetailsRequest()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class UserGetStatusRequest : BaseRequest
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] rnxId;

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xAB8FEC", Offset = "0xAB8FEC", VA = "0xAB8FEC", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xAB902C", Offset = "0xAB902C", VA = "0xAB902C", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xAB9034", Offset = "0xAB9034", VA = "0xAB9034", Slot = "7")]
		public override Dictionary<string, string> GetQueryParams()
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xAB9080", Offset = "0xAB9080", VA = "0xAB9080")]
		public UserGetStatusRequest()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class UserSetStatusRequest : BaseRequest
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string rnxId;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string status;

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xAB9084", Offset = "0xAB9084", VA = "0xAB9084", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xAB90C4", Offset = "0xAB90C4", VA = "0xAB90C4", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xAB90CC", Offset = "0xAB90CC", VA = "0xAB90CC", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xAB90D4", Offset = "0xAB90D4", VA = "0xAB90D4")]
		public UserSetStatusRequest()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class UserSignInRequest : BaseRequest
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string userName;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string platformName;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string platformUserId;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string avatarMD5;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string deviceModel;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string status;

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xAB90D8", Offset = "0xAB90D8", VA = "0xAB90D8", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xAB9118", Offset = "0xAB9118", VA = "0xAB9118", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xAB9120", Offset = "0xAB9120", VA = "0xAB9120", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xAB9128", Offset = "0xAB9128", VA = "0xAB9128")]
		public UserSignInRequest()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class UserSignOutRequest : BaseRequest
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string rnxId;

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xAB912C", Offset = "0xAB912C", VA = "0xAB912C", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xAB916C", Offset = "0xAB916C", VA = "0xAB916C", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xAB9174", Offset = "0xAB9174", VA = "0xAB9174", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xAB917C", Offset = "0xAB917C", VA = "0xAB917C")]
		public UserSignOutRequest()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class UserTranslateIDRequest : BaseRequest
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string platformName;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] platformUserId;

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xAB9180", Offset = "0xAB9180", VA = "0xAB9180", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xAB91C0", Offset = "0xAB91C0", VA = "0xAB91C0", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xAB91C8", Offset = "0xAB91C8", VA = "0xAB91C8", Slot = "7")]
		public override Dictionary<string, string> GetQueryParams()
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xAB93D0", Offset = "0xAB93D0", VA = "0xAB93D0")]
		public UserTranslateIDRequest()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class UserUpdateAvatarRequest : BaseRequest
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string rnxId;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string avatarUrl;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string avatarMD5;

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xAB93D4", Offset = "0xAB93D4", VA = "0xAB93D4", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xAB9414", Offset = "0xAB9414", VA = "0xAB9414", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xAB941C", Offset = "0xAB941C", VA = "0xAB941C", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xAB9424", Offset = "0xAB9424", VA = "0xAB9424")]
		public UserUpdateAvatarRequest()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class RNXPlatformClientAPI : MonoBehaviour
	{
		[Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class <PerformUploadRequest>d__8 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string uploadUrl;

			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte[] content;

			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string contentType;

			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> onError;

			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<string> onSuccess;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x1700002D")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60001B0")]
				[Address(RVA = "0xABB750", Offset = "0xABB750", VA = "0xABB750", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001B2")]
				[Address(RVA = "0xABB798", Offset = "0xABB798", VA = "0xABB798", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xAB9BF0", Offset = "0xAB9BF0", VA = "0xAB9BF0")]
			[DebuggerHidden]
			public <PerformUploadRequest>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xABB2C8", Offset = "0xABB2C8", VA = "0xABB2C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xABB2E4", Offset = "0xABB2E4", VA = "0xABB2E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xABB6A0", Offset = "0xABB6A0", VA = "0xABB6A0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xABB758", Offset = "0xABB758", VA = "0xABB758", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class <PerformDownloadRequest>d__9 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400014B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string url;

			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<string> onError;

			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Texture2D texture;

			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> onSuccess;

			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private WWW <www>5__2;

			[Token(Token = "0x1700002F")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60001B6")]
				[Address(RVA = "0xABBA5C", Offset = "0xABBA5C", VA = "0xABBA5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000030")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001B8")]
				[Address(RVA = "0xABBAA4", Offset = "0xABBAA4", VA = "0xABBAA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xAB9C18", Offset = "0xAB9C18", VA = "0xAB9C18")]
			[DebuggerHidden]
			public <PerformDownloadRequest>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xABB7F4", Offset = "0xABB7F4", VA = "0xABB7F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xABB7F8", Offset = "0xABB7F8", VA = "0xABB7F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xABBA64", Offset = "0xABBA64", VA = "0xABBA64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class <PerformPutRequest>d__11 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RNXPlatformClientAPI <>4__this;

			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BaseRequest request;

			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<string> onError;

			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<JSONNode> onSuccess;

			[Token(Token = "0x4000157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x17000031")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60001BD")]
				[Address(RVA = "0xABBEB4", Offset = "0xABBEB4", VA = "0xABBEB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000032")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001BF")]
				[Address(RVA = "0xABBEFC", Offset = "0xABBEFC", VA = "0xABBEFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xAB9CC4", Offset = "0xAB9CC4", VA = "0xAB9CC4")]
			[DebuggerHidden]
			public <PerformPutRequest>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xABBB00", Offset = "0xABBB00", VA = "0xABBB00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xABBB1C", Offset = "0xABBB1C", VA = "0xABBB1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xABBE04", Offset = "0xABBE04", VA = "0xABBE04")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xABBEBC", Offset = "0xABBEBC", VA = "0xABBEBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class <PerformPostRequest>d__12 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RNXPlatformClientAPI <>4__this;

			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BaseRequest request;

			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<string> onError;

			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<JSONNode> onSuccess;

			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x17000033")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60001C4")]
				[Address(RVA = "0xABD310", Offset = "0xABD310", VA = "0xABD310", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000034")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001C6")]
				[Address(RVA = "0xABD358", Offset = "0xABD358", VA = "0xABD358", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xABCF58", Offset = "0xABCF58", VA = "0xABCF58")]
			[DebuggerHidden]
			public <PerformPostRequest>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xABCF80", Offset = "0xABCF80", VA = "0xABCF80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0xABCF9C", Offset = "0xABCF9C", VA = "0xABCF9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xABD260", Offset = "0xABD260", VA = "0xABD260")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0xABD318", Offset = "0xABD318", VA = "0xABD318", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class <PerformGetRequest>d__16 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RNXPlatformClientAPI <>4__this;

			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BaseRequest request;

			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<string> onError;

			[Token(Token = "0x4000164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<JSONNode> onSuccess;

			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x17000035")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0xABD738", Offset = "0xABD738", VA = "0xABD738", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000036")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0xABD780", Offset = "0xABD780", VA = "0xABD780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xABD3B4", Offset = "0xABD3B4", VA = "0xABD3B4")]
			[DebuggerHidden]
			public <PerformGetRequest>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xABD3DC", Offset = "0xABD3DC", VA = "0xABD3DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xABD3F8", Offset = "0xABD3F8", VA = "0xABD3F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xABD688", Offset = "0xABD688", VA = "0xABD688")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xABD740", Offset = "0xABD740", VA = "0xABD740", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RNXPlatformClientAPI _instance;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string baseURL;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private StringBuilder _builder;

		[Token(Token = "0x1700002C")]
		public static RNXPlatformClientAPI Instance
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xAB94C8", Offset = "0xAB94C8", VA = "0xAB94C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xAB9428", Offset = "0xAB9428", VA = "0xAB9428")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xAB4430", Offset = "0xAB4430", VA = "0xAB4430")]
		public void SendRequest(BaseRequest request, Action<JSONNode> onSuccess, Action<string> onError)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xAB9758", Offset = "0xAB9758", VA = "0xAB9758")]
		public void DownloadMultipleUrlsRequest(HashSet<string> urls, Action<bool, Dictionary<string, Texture2D>> onResponse)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xAB5054", Offset = "0xAB5054", VA = "0xAB5054")]
		[IteratorStateMachine(typeof(<PerformUploadRequest>d__8))]
		public IEnumerator<float> PerformUploadRequest(string uploadUrl, byte[] content, string contentType, Action<string> onSuccess, Action<string> onError)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xAB9B30", Offset = "0xAB9B30", VA = "0xAB9B30")]
		[IteratorStateMachine(typeof(<PerformDownloadRequest>d__9))]
		private IEnumerator<float> PerformDownloadRequest(string url, Texture2D texture, Action<string> onSuccess, Action<string> onError)
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xAB9C40", Offset = "0xAB9C40", VA = "0xAB9C40")]
		private string BuildPutOrPostUrl(BaseRequest request)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xAB95D8", Offset = "0xAB95D8", VA = "0xAB95D8")]
		[IteratorStateMachine(typeof(<PerformPutRequest>d__11))]
		private IEnumerator<float> PerformPutRequest(BaseRequest request, Action<JSONNode> onSuccess, Action<string> onError)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xAB9698", Offset = "0xAB9698", VA = "0xAB9698")]
		[IteratorStateMachine(typeof(<PerformPostRequest>d__12))]
		private IEnumerator<float> PerformPostRequest(BaseRequest request, Action<JSONNode> onSuccess, Action<string> onError)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xAB9CEC", Offset = "0xAB9CEC", VA = "0xAB9CEC")]
		private string BuildGetUrl(BaseRequest request)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xABA008", Offset = "0xABA008", VA = "0xABA008")]
		private string BuildGetUrlParams(BaseRequest request)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xAB9D7C", Offset = "0xAB9D7C", VA = "0xAB9D7C")]
		private void AppendQueryParams(BaseRequest request)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xAB9518", Offset = "0xAB9518", VA = "0xAB9518")]
		[IteratorStateMachine(typeof(<PerformGetRequest>d__16))]
		private IEnumerator<float> PerformGetRequest(BaseRequest request, Action<JSONNode> onSuccess, Action<string> onError)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xABA058", Offset = "0xABA058", VA = "0xABA058")]
		private static void ValidateResponse(UnityWebRequest www, Action<JSONNode> onSuccess, Action<string> onError)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xABA2C0", Offset = "0xABA2C0", VA = "0xABA2C0")]
		private static string StringifyServerError(JSONNode response)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xABA71C", Offset = "0xABA71C", VA = "0xABA71C")]
		public RNXPlatformClientAPI()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[RequireComponent(typeof(RNXPlatformClientAPI))]
	public class Stats : MonoBehaviour, ISingleton
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RNXPlatformClientAPI rnxAPI;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Stats instance;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool init;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<StatsName, StatsData> myStatsCache;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool cacheEnabled;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xABD7DC", Offset = "0xABD7DC", VA = "0xABD7DC", Slot = "4")]
		private void OneHumus.ISingleton.InitSingleton()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xABD834", Offset = "0xABD834", VA = "0xABD834")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xABD898", Offset = "0xABD898", VA = "0xABD898")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xABD89C", Offset = "0xABD89C", VA = "0xABD89C")]
		public void Init()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xABD904", Offset = "0xABD904", VA = "0xABD904")]
		public void getStats(string[] rnxId, StatsName statsName, Action<bool, Dictionary<string, StatsData>> onResponse)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xABDB4C", Offset = "0xABDB4C", VA = "0xABDB4C")]
		public void getMyStats(string rnxId, StatsName statsName, Action<bool, StatsData> onResponse)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xABDD5C", Offset = "0xABDD5C", VA = "0xABDD5C")]
		public void updateMyStats(string rnxId, StatsName statsName, StatsData statsData, Action<bool> onResponse)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xABDFE4", Offset = "0xABDFE4", VA = "0xABDFE4")]
		public Stats()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[RequireComponent(typeof(Stats))]
	public class StatsTests : MonoBehaviour
	{
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Stats stats;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xABE8F4", Offset = "0xABE8F4", VA = "0xABE8F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xABE954", Offset = "0xABE954", VA = "0xABE954")]
		private void StatsFlowTest()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xABEAC8", Offset = "0xABEAC8", VA = "0xABEAC8")]
		public StatsTests()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class TestDriver : MonoBehaviour
	{
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xABF018", Offset = "0xABF018", VA = "0xABF018")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xABF2AC", Offset = "0xABF2AC", VA = "0xABF2AC")]
		private void TestSignInFlow()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xABF554", Offset = "0xABF554", VA = "0xABF554")]
		private void TestTranslate()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xABF864", Offset = "0xABF864", VA = "0xABF864")]
		private void TestStatsFlow()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xABF044", Offset = "0xABF044", VA = "0xABF044")]
		private void TestLeaderboardFlow()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xABFAD8", Offset = "0xABFAD8", VA = "0xABFAD8")]
		public TestDriver()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[RequireComponent(typeof(RNXPlatformClientAPI))]
	public class Users : MonoBehaviour
	{
		[Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class <KeepAliveCo>d__16 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Users <>4__this;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float <countDown>5__2;

			[Token(Token = "0x1700003B")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600021C")]
				[Address(RVA = "0xAC2E34", Offset = "0xAC2E34", VA = "0xAC2E34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700003C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600021E")]
				[Address(RVA = "0xAC2E7C", Offset = "0xAC2E7C", VA = "0xAC2E7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0xAC0A90", Offset = "0xAC0A90", VA = "0xAC0A90")]
			[DebuggerHidden]
			public <KeepAliveCo>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0xAC2D74", Offset = "0xAC2D74", VA = "0xAC2D74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0xAC2D78", Offset = "0xAC2D78", VA = "0xAC2D78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0xAC2E3C", Offset = "0xAC2E3C", VA = "0xAC2E3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float keepAliveIntervalInSeconds;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool keepAlive;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public User unknownUser;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Status signInStatus;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RNXPlatformClientAPI rnxAPI;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool init;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string myRealRnxId;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private User me;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private User lastMe;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TimeSpan _clockOffset;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Users instance;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, string> _steamTranslateCache;

		[Token(Token = "0x17000037")]
		public TimeSpan ClockOffset
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xAC0910", Offset = "0xAC0910", VA = "0xAC0910")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x17000038")]
		public User Me
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xAC0AB8", Offset = "0xAC0AB8", VA = "0xAC0AB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public User LastMe
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xAC0AC0", Offset = "0xAC0AC0", VA = "0xAC0AC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public bool isSignedIn
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0xAC0AC8", Offset = "0xAC0AC8", VA = "0xAC0AC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000003")]
		public static event Action<Status> onMyStatusChanged
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0xAC138C", Offset = "0xAC138C", VA = "0xAC138C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0xAC145C", Offset = "0xAC145C", VA = "0xAC145C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xAC0918", Offset = "0xAC0918", VA = "0xAC0918")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xAC09B4", Offset = "0xAC09B4", VA = "0xAC09B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xAC0A1C", Offset = "0xAC0A1C", VA = "0xAC0A1C")]
		[IteratorStateMachine(typeof(<KeepAliveCo>d__16))]
		private IEnumerator<float> KeepAliveCo()
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xAC0AD8", Offset = "0xAC0AD8", VA = "0xAC0AD8")]
		public void SignIn(string userName, Platform platformName, string platformUserId, Texture2D avatarImage, string deviceModel, bool useFakeRnxID, string fakeRnxID, Action<bool, User> onResponse)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xAC0FC4", Offset = "0xAC0FC4", VA = "0xAC0FC4")]
		private void CalcClockOffset(string epochTime)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xAC1188", Offset = "0xAC1188", VA = "0xAC1188")]
		public void SignOut()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xAC152C", Offset = "0xAC152C", VA = "0xAC152C")]
		public void SetMyStatus(Status status)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xAC17F8", Offset = "0xAC17F8", VA = "0xAC17F8")]
		public void GetUsersStatus(List<string> rnxIds, Action<bool, Dictionary<string, Status>> onResponse)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xAC1A10", Offset = "0xAC1A10", VA = "0xAC1A10")]
		public void KeepAlive()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xAC1A24", Offset = "0xAC1A24", VA = "0xAC1A24")]
		public void GetUserDetails(string rnxId, Action<bool, User> onResponse)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xAC1BC0", Offset = "0xAC1BC0", VA = "0xAC1BC0")]
		public void GetUsersDetails(List<string> rnxIds, Action<bool, Dictionary<string, User>> onResponse)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xAC2030", Offset = "0xAC2030", VA = "0xAC2030")]
		public void TranslatePlatformIds(List<string> platformUserIds, Platform platformName, Action<bool, Dictionary<string, string>> onResponse)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xAC250C", Offset = "0xAC250C", VA = "0xAC250C")]
		private void UploadAvatarImage(string uploadUrl, byte[] avatarByteArray, string avatarMD5)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xAC2704", Offset = "0xAC2704", VA = "0xAC2704")]
		private void UpdateServerAvatar(string avatarUrl, string avatarMD5)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xAC2900", Offset = "0xAC2900", VA = "0xAC2900")]
		private void downloadAvatarImages(List<User> users, Action<bool> onResponse)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xAC2BE8", Offset = "0xAC2BE8", VA = "0xAC2BE8")]
		public Platform parsePlatform(string platformName)
		{
			return default(Platform);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xAC2CD8", Offset = "0xAC2CD8", VA = "0xAC2CD8")]
		public Users()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[RequireComponent(typeof(Users))]
	public class UsersTests : MonoBehaviour
	{
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Users users;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Texture2D texture;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SpriteRenderer spriteRenderer;

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xAC4E7C", Offset = "0xAC4E7C", VA = "0xAC4E7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xAC4E80", Offset = "0xAC4E80", VA = "0xAC4E80")]
		private void Start()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xAC5208", Offset = "0xAC5208", VA = "0xAC5208")]
		private void UserSignInTest()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xAC53A8", Offset = "0xAC53A8", VA = "0xAC53A8")]
		private void KeepAliveTest()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xAC53D4", Offset = "0xAC53D4", VA = "0xAC53D4")]
		private void SetMyStatusTest()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xAC53F0", Offset = "0xAC53F0", VA = "0xAC53F0")]
		private void GetStatusTest()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xAC55F8", Offset = "0xAC55F8", VA = "0xAC55F8")]
		private void TranslatePlatformIdsTest()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xAC579C", Offset = "0xAC579C", VA = "0xAC579C")]
		private void TranslatePlatformIdsCacheTest()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xAC4FB8", Offset = "0xAC4FB8", VA = "0xAC4FB8")]
		private void GetUserDetailsTest()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xAC4EF4", Offset = "0xAC4EF4", VA = "0xAC4EF4")]
		private Texture2D dummyTexture()
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xAC5970", Offset = "0xAC5970", VA = "0xAC5970")]
		public UsersTests()
		{
		}
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x200006E")]
	public enum JSONNodeType
	{
		[Token(Token = "0x40001D0")]
		Array = 1,
		[Token(Token = "0x40001D1")]
		Object,
		[Token(Token = "0x40001D2")]
		String,
		[Token(Token = "0x40001D3")]
		Number,
		[Token(Token = "0x40001D4")]
		NullValue,
		[Token(Token = "0x40001D5")]
		Boolean,
		[Token(Token = "0x40001D6")]
		None
	}
	[Token(Token = "0x200006F")]
	public enum JSONTextMode
	{
		[Token(Token = "0x40001D8")]
		Compact,
		[Token(Token = "0x40001D9")]
		Indent
	}
	[Token(Token = "0x2000070")]
	public abstract class JSONNode
	{
		[Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class <get_Children>d__29 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x17000050")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000299")]
				[Address(RVA = "0xAC8AB4", Offset = "0xAC8AB4", VA = "0xAC8AB4", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000051")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600029B")]
				[Address(RVA = "0xAC8AFC", Offset = "0xAC8AFC", VA = "0xAC8AFC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0xAC6594", Offset = "0xAC6594", VA = "0xAC6594")]
			[DebuggerHidden]
			public <get_Children>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x6000297")]
			[Address(RVA = "0xAC8A98", Offset = "0xAC8A98", VA = "0xAC8A98", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000298")]
			[Address(RVA = "0xAC8A9C", Offset = "0xAC8A9C", VA = "0xAC8A9C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0xAC8ABC", Offset = "0xAC8ABC", VA = "0xAC8ABC", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0xAC8B04", Offset = "0xAC8B04", VA = "0xAC8B04", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0xAC8B9C", Offset = "0xAC8B9C", VA = "0xAC8B9C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class <get_DeepChildren>d__31 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x17000052")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60002A3")]
				[Address(RVA = "0xAC9208", Offset = "0xAC9208", VA = "0xAC9208", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000053")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002A5")]
				[Address(RVA = "0xAC9250", Offset = "0xAC9250", VA = "0xAC9250", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0xAC664C", Offset = "0xAC664C", VA = "0xAC664C")]
			[DebuggerHidden]
			public <get_DeepChildren>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0xAC8BA0", Offset = "0xAC8BA0", VA = "0xAC8BA0", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002A0")]
			[Address(RVA = "0xAC8C58", Offset = "0xAC8C58", VA = "0xAC8C58", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0xAC9158", Offset = "0xAC9158", VA = "0xAC9158")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002A2")]
			[Address(RVA = "0xAC90A8", Offset = "0xAC90A8", VA = "0xAC90A8")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60002A4")]
			[Address(RVA = "0xAC9210", Offset = "0xAC9210", VA = "0xAC9210", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0xAC9258", Offset = "0xAC9258", VA = "0xAC9258", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0xAC9304", Offset = "0xAC9304", VA = "0xAC9304", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static StringBuilder m_EscapeBuilder;

		[Token(Token = "0x1700003D")]
		public virtual JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0xAC6410", Offset = "0xAC6410", VA = "0xAC6410", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000254")]
			[Address(RVA = "0xAC6418", Offset = "0xAC6418", VA = "0xAC6418", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public virtual JSONNode this[string aKey]
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0xAC641C", Offset = "0xAC641C", VA = "0xAC641C", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000256")]
			[Address(RVA = "0xAC6424", Offset = "0xAC6424", VA = "0xAC6424", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public virtual string Value
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0xAC6428", Offset = "0xAC6428", VA = "0xAC6428", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xAC6468", Offset = "0xAC6468", VA = "0xAC6468", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public virtual int Count
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0xAC646C", Offset = "0xAC646C", VA = "0xAC646C", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000041")]
		public virtual bool IsNumber
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0xAC6474", Offset = "0xAC6474", VA = "0xAC6474", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		public virtual bool IsString
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0xAC647C", Offset = "0xAC647C", VA = "0xAC647C", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		public virtual bool IsBoolean
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0xAC6484", Offset = "0xAC6484", VA = "0xAC6484", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		public virtual bool IsNull
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0xAC648C", Offset = "0xAC648C", VA = "0xAC648C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public virtual bool IsArray
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xAC6494", Offset = "0xAC6494", VA = "0xAC6494", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public virtual bool IsObject
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xAC649C", Offset = "0xAC649C", VA = "0xAC649C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public virtual IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xAC6524", Offset = "0xAC6524", VA = "0xAC6524", Slot = "22")]
			[IteratorStateMachine(typeof(<get_Children>d__29))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IEnumerable<JSONNode> DeepChildren
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xAC65C8", Offset = "0xAC65C8", VA = "0xAC65C8")]
			[IteratorStateMachine(typeof(<get_DeepChildren>d__31))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public abstract JSONNodeType Tag
		{
			[Token(Token = "0x600026A")]
			get;
		}

		[Token(Token = "0x1700004A")]
		public virtual double AsDouble
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0xAC67A4", Offset = "0xAC67A4", VA = "0xAC67A4", Slot = "26")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0xAC67DC", Offset = "0xAC67DC", VA = "0xAC67DC", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public virtual int AsInt
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0xAC6818", Offset = "0xAC6818", VA = "0xAC6818", Slot = "28")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xAC684C", Offset = "0xAC684C", VA = "0xAC684C", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public virtual float AsFloat
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xAC6864", Offset = "0xAC6864", VA = "0xAC6864", Slot = "30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xAC6884", Offset = "0xAC6884", VA = "0xAC6884", Slot = "31")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xAC6898", Offset = "0xAC6898", VA = "0xAC6898", Slot = "32")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xAC6950", Offset = "0xAC6950", VA = "0xAC6950", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xAC69C8", Offset = "0xAC69C8", VA = "0xAC69C8", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public virtual JSONObject AsObject
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0xAC6A40", Offset = "0xAC6A40", VA = "0xAC6A40", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xAC64A4", Offset = "0xAC64A4", VA = "0xAC64A4", Slot = "17")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xAC64A8", Offset = "0xAC64A8", VA = "0xAC64A8", Slot = "18")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xAC650C", Offset = "0xAC650C", VA = "0xAC650C", Slot = "19")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xAC6514", Offset = "0xAC6514", VA = "0xAC6514", Slot = "20")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xAC651C", Offset = "0xAC651C", VA = "0xAC651C", Slot = "21")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xAC6680", Offset = "0xAC6680", VA = "0xAC6680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xAC670C", Offset = "0xAC670C", VA = "0xAC670C", Slot = "23")]
		public virtual string ToString(int aIndent)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xAC6AB8", Offset = "0xAC6AB8", VA = "0xAC6AB8")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xABE514", Offset = "0xABE514", VA = "0xABE514")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xAC6D00", Offset = "0xAC6D00", VA = "0xAC6D00")]
		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xAC6DD4", Offset = "0xAC6DD4", VA = "0xAC6DD4")]
		public static implicit operator double(JSONNode d)
		{
			return default(double);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xAC6E5C", Offset = "0xAC6E5C", VA = "0xAC6E5C")]
		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xAC6EC4", Offset = "0xAC6EC4", VA = "0xAC6EC4")]
		public static implicit operator float(JSONNode d)
		{
			return default(float);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xAC6F4C", Offset = "0xAC6F4C", VA = "0xAC6F4C")]
		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xAC6FAC", Offset = "0xAC6FAC", VA = "0xAC6FAC")]
		public static implicit operator int(JSONNode d)
		{
			return default(int);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xAC7034", Offset = "0xAC7034", VA = "0xAC7034")]
		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xAC7100", Offset = "0xAC7100", VA = "0xAC7100")]
		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xAC6B8C", Offset = "0xAC6B8C", VA = "0xAC6B8C")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xAC7188", Offset = "0xAC7188", VA = "0xAC7188")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xAC71F8", Offset = "0xAC71F8", VA = "0xAC71F8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xAC7204", Offset = "0xAC7204", VA = "0xAC7204", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xAC720C", Offset = "0xAC720C", VA = "0xAC720C")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xAC75C0", Offset = "0xAC75C0", VA = "0xAC75C0")]
		private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xAC777C", Offset = "0xAC777C", VA = "0xAC777C")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xAC7EC8", Offset = "0xAC7EC8", VA = "0xAC7EC8", Slot = "36")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xAC7ECC", Offset = "0xAC7ECC", VA = "0xAC7ECC")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xAC7F4C", Offset = "0xAC7F4C", VA = "0xAC7F4C")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xAC7F9C", Offset = "0xAC7F9C", VA = "0xAC7F9C")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xAC7FEC", Offset = "0xAC7FEC", VA = "0xAC7FEC")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xAC803C", Offset = "0xAC803C", VA = "0xAC803C")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xAC808C", Offset = "0xAC808C", VA = "0xAC808C")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xAC828C", Offset = "0xAC828C", VA = "0xAC828C")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xAC8638", Offset = "0xAC8638", VA = "0xAC8638")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xAC8688", Offset = "0xAC8688", VA = "0xAC8688")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xAC86D8", Offset = "0xAC86D8", VA = "0xAC86D8")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xAC8728", Offset = "0xAC8728", VA = "0xAC8728")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xAC88E4", Offset = "0xAC88E4", VA = "0xAC88E4")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xAC8934", Offset = "0xAC8934", VA = "0xAC8934")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xAC8A0C", Offset = "0xAC8A0C", VA = "0xAC8A0C")]
		protected JSONNode()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class <get_Children>d__18 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40001E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40001E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x40001EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700005A")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60002BB")]
				[Address(RVA = "0xAC9F50", Offset = "0xAC9F50", VA = "0xAC9F50", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002BD")]
				[Address(RVA = "0xAC9F98", Offset = "0xAC9F98", VA = "0xAC9F98", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0xAC9A28", Offset = "0xAC9A28", VA = "0xAC9A28")]
			[DebuggerHidden]
			public <get_Children>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xAC9D3C", Offset = "0xAC9D3C", VA = "0xAC9D3C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xAC9D58", Offset = "0xAC9D58", VA = "0xAC9D58", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0xAC9F00", Offset = "0xAC9F00", VA = "0xAC9F00")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xAC9F58", Offset = "0xAC9F58", VA = "0xAC9F58", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xAC9FA0", Offset = "0xAC9FA0", VA = "0xAC9FA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xACA04C", Offset = "0xACA04C", VA = "0xACA04C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONArray <>4__this;

			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700005C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0xACA264", Offset = "0xACA264", VA = "0xACA264", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002C6")]
				[Address(RVA = "0xACA2AC", Offset = "0xACA2AC", VA = "0xACA2AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xAC9AD0", Offset = "0xAC9AD0", VA = "0xAC9AD0")]
			[DebuggerHidden]
			public <GetEnumerator>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xACA050", Offset = "0xACA050", VA = "0xACA050", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xACA06C", Offset = "0xACA06C", VA = "0xACA06C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xACA214", Offset = "0xACA214", VA = "0xACA214")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xACA26C", Offset = "0xACA26C", VA = "0xACA26C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool inline;

		[Token(Token = "0x17000054")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0xAC9308", Offset = "0xAC9308", VA = "0xAC9308", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000055")]
		public override bool IsArray
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0xAC9310", Offset = "0xAC9310", VA = "0xAC9310", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xAC9318", Offset = "0xAC9318", VA = "0xAC9318", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0xAC944C", Offset = "0xAC944C", VA = "0xAC944C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xAC95B8", Offset = "0xAC95B8", VA = "0xAC95B8", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xAC9618", Offset = "0xAC9618", VA = "0xAC9618", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public override int Count
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xAC9730", Offset = "0xAC9730", VA = "0xAC9730", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000059")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0xAC99A4", Offset = "0xAC99A4", VA = "0xAC99A4", Slot = "22")]
			[IteratorStateMachine(typeof(<get_Children>d__18))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xAC9778", Offset = "0xAC9778", VA = "0xAC9778", Slot = "17")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xAC9890", Offset = "0xAC9890", VA = "0xAC9890", Slot = "20")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xAC9944", Offset = "0xAC9944", VA = "0xAC9944", Slot = "21")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xAC9A5C", Offset = "0xAC9A5C", VA = "0xAC9A5C", Slot = "37")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__19))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xAC9AF8", Offset = "0xAC9AF8", VA = "0xAC9AF8", Slot = "36")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xAC9BD4", Offset = "0xAC9BD4", VA = "0xAC9BD4", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xAC7E1C", Offset = "0xAC7E1C", VA = "0xAC7E1C")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class JSONObject : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class <get_Children>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000064")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60002DD")]
				[Address(RVA = "0xACB598", Offset = "0xACB598", VA = "0xACB598", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002DF")]
				[Address(RVA = "0xACB5E0", Offset = "0xACB5E0", VA = "0xACB5E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0xACACCC", Offset = "0xACACCC", VA = "0xACACCC")]
			[DebuggerHidden]
			public <get_Children>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xACB370", Offset = "0xACB370", VA = "0xACB370", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xACB38C", Offset = "0xACB38C", VA = "0xACB38C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xACB548", Offset = "0xACB548", VA = "0xACB548")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xACB5A0", Offset = "0xACB5A0", VA = "0xACB5A0", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xACB5E8", Offset = "0xACB5E8", VA = "0xACB5E8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xACB694", Offset = "0xACB694", VA = "0xACB694", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONObject <>4__this;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000066")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002E6")]
				[Address(RVA = "0xACB8E8", Offset = "0xACB8E8", VA = "0xACB8E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002E8")]
				[Address(RVA = "0xACB930", Offset = "0xACB930", VA = "0xACB930", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xACAD74", Offset = "0xACAD74", VA = "0xACAD74")]
			[DebuggerHidden]
			public <GetEnumerator>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xACB698", Offset = "0xACB698", VA = "0xACB698", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xACB6B4", Offset = "0xACB6B4", VA = "0xACB6B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xACB898", Offset = "0xACB898", VA = "0xACB898")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xACB8F0", Offset = "0xACB8F0", VA = "0xACB8F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool inline;

		[Token(Token = "0x1700005E")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0xACA2B4", Offset = "0xACA2B4", VA = "0xACA2B4", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700005F")]
		public override bool IsObject
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0xACA2BC", Offset = "0xACA2BC", VA = "0xACA2BC", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xACA2C4", Offset = "0xACA2C4", VA = "0xACA2C4", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xACA410", Offset = "0xACA410", VA = "0xACA410", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0xACA538", Offset = "0xACA538", VA = "0xACA538", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0xACA5D8", Offset = "0xACA5D8", VA = "0xACA5D8", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public override int Count
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0xACA710", Offset = "0xACA710", VA = "0xACA710", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000063")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xACAC48", Offset = "0xACAC48", VA = "0xACAC48", Slot = "22")]
			[IteratorStateMachine(typeof(<get_Children>d__19))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xACA760", Offset = "0xACA760", VA = "0xACA760", Slot = "17")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xACA8D0", Offset = "0xACA8D0", VA = "0xACA8D0", Slot = "19")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xACA994", Offset = "0xACA994", VA = "0xACA994", Slot = "20")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xACAA70", Offset = "0xACAA70", VA = "0xACAA70", Slot = "21")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xACAD00", Offset = "0xACAD00", VA = "0xACAD00", Slot = "37")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__20))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xACAD9C", Offset = "0xACAD9C", VA = "0xACAD9C", Slot = "36")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xACAFBC", Offset = "0xACAFBC", VA = "0xACAFBC", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xAC7D70", Offset = "0xAC7D70", VA = "0xAC7D70")]
		public JSONObject()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class JSONString : JSONNode
	{
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x17000068")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xACB938", Offset = "0xACB938", VA = "0xACB938", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000069")]
		public override bool IsString
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xACB940", Offset = "0xACB940", VA = "0xACB940", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		public override string Value
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xACB948", Offset = "0xACB948", VA = "0xACB948", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xACB950", Offset = "0xACB950", VA = "0xACB950", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xAC6B18", Offset = "0xAC6B18", VA = "0xAC6B18")]
		public JSONString(string aData)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xACB958", Offset = "0xACB958", VA = "0xACB958", Slot = "36")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xACB9A4", Offset = "0xACB9A4", VA = "0xACB9A4", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xACBA44", Offset = "0xACBA44", VA = "0xACBA44", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xACBB54", Offset = "0xACBB54", VA = "0xACBB54", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200007B")]
	public class JSONNumber : JSONNode
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double m_Data;

		[Token(Token = "0x1700006B")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xACBB74", Offset = "0xACBB74", VA = "0xACBB74", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700006C")]
		public override bool IsNumber
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xACBB7C", Offset = "0xACBB7C", VA = "0xACBB7C", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public override string Value
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xACBB84", Offset = "0xACBB84", VA = "0xACBB84", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xACBB90", Offset = "0xACBB90", VA = "0xACBB90", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public override double AsDouble
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xACBBCC", Offset = "0xACBBCC", VA = "0xACBBCC", Slot = "26")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xACBBD4", Offset = "0xACBBD4", VA = "0xACBBD4", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xAC6D68", Offset = "0xAC6D68", VA = "0xAC6D68")]
		public JSONNumber(double aData)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xACBBDC", Offset = "0xACBBDC", VA = "0xACBBDC")]
		public JSONNumber(string aData)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xACBC54", Offset = "0xACBC54", VA = "0xACBC54", Slot = "36")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xACBCA0", Offset = "0xACBCA0", VA = "0xACBCA0", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xACBCC0", Offset = "0xACBCC0", VA = "0xACBCC0")]
		private static bool IsNumeric(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xACBE60", Offset = "0xACBE60", VA = "0xACBE60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xACBF84", Offset = "0xACBF84", VA = "0xACBF84", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200007C")]
	public class JSONBool : JSONNode
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_Data;

		[Token(Token = "0x1700006F")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0xACBFF4", Offset = "0xACBFF4", VA = "0xACBFF4", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000070")]
		public override bool IsBoolean
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0xACBFFC", Offset = "0xACBFFC", VA = "0xACBFFC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public override string Value
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0xACC004", Offset = "0xACC004", VA = "0xACC004", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0xACC010", Offset = "0xACC010", VA = "0xACC010", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public override bool AsBool
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0xACC08C", Offset = "0xACC08C", VA = "0xACC08C", Slot = "32")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0xACC094", Offset = "0xACC094", VA = "0xACC094", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xAC7094", Offset = "0xAC7094", VA = "0xAC7094")]
		public JSONBool(bool aData)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xACC0A0", Offset = "0xACC0A0", VA = "0xACC0A0")]
		public JSONBool(string aData)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xACC118", Offset = "0xACC118", VA = "0xACC118", Slot = "36")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xACC160", Offset = "0xACC160", VA = "0xACC160", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xACC1D8", Offset = "0xACC1D8", VA = "0xACC1D8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xACC250", Offset = "0xACC250", VA = "0xACC250", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200007D")]
	public class JSONNull : JSONNode
	{
		[Token(Token = "0x17000073")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0xACC25C", Offset = "0xACC25C", VA = "0xACC25C", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000074")]
		public override bool IsNull
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xACC264", Offset = "0xACC264", VA = "0xACC264", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		public override string Value
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0xACC26C", Offset = "0xACC26C", VA = "0xACC26C", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030E")]
			[Address(RVA = "0xACC2AC", Offset = "0xACC2AC", VA = "0xACC2AC", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public override bool AsBool
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0xACC2B0", Offset = "0xACC2B0", VA = "0xACC2B0", Slot = "32")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000310")]
			[Address(RVA = "0xACC2B8", Offset = "0xACC2B8", VA = "0xACC2B8", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xACC2BC", Offset = "0xACC2BC", VA = "0xACC2BC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xACC348", Offset = "0xACC348", VA = "0xACC348", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xACC350", Offset = "0xACC350", VA = "0xACC350", Slot = "36")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xACC374", Offset = "0xACC374", VA = "0xACC374", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xAC85E0", Offset = "0xAC85E0", VA = "0xAC85E0")]
		public JSONNull()
		{
		}
	}
	[Token(Token = "0x200007E")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x17000077")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0xACC3C8", Offset = "0xACC3C8", VA = "0xACC3C8", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000078")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0xACC438", Offset = "0xACC438", VA = "0xACC438", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031B")]
			[Address(RVA = "0xACC498", Offset = "0xACC498", VA = "0xACC498", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0xACC51C", Offset = "0xACC51C", VA = "0xACC51C", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0xACC58C", Offset = "0xACC58C", VA = "0xACC58C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public override int AsInt
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0xACC778", Offset = "0xACC778", VA = "0xACC778", Slot = "28")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000325")]
			[Address(RVA = "0xACC7E4", Offset = "0xACC7E4", VA = "0xACC7E4", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public override float AsFloat
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0xACC854", Offset = "0xACC854", VA = "0xACC854", Slot = "30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000327")]
			[Address(RVA = "0xACC8C0", Offset = "0xACC8C0", VA = "0xACC8C0", Slot = "31")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public override double AsDouble
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0xACC930", Offset = "0xACC930", VA = "0xACC930", Slot = "26")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000329")]
			[Address(RVA = "0xACC99C", Offset = "0xACC99C", VA = "0xACC99C", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public override bool AsBool
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0xACCA0C", Offset = "0xACCA0C", VA = "0xACCA0C", Slot = "32")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600032B")]
			[Address(RVA = "0xACCA78", Offset = "0xACCA78", VA = "0xACCA78", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0xACCAE8", Offset = "0xACCAE8", VA = "0xACCAE8", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public override JSONObject AsObject
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0xACCB50", Offset = "0xACCB50", VA = "0xACCB50", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xAC93C8", Offset = "0xAC93C8", VA = "0xAC93C8")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xACA388", Offset = "0xACA388", VA = "0xACA388")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xACC3D0", Offset = "0xACC3D0", VA = "0xACC3D0")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xACC618", Offset = "0xACC618", VA = "0xACC618", Slot = "18")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xACC69C", Offset = "0xACC69C", VA = "0xACC69C", Slot = "17")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xACC728", Offset = "0xACC728", VA = "0xACC728")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xACC740", Offset = "0xACC740", VA = "0xACC740")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xACC758", Offset = "0xACC758", VA = "0xACC758", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xACC770", Offset = "0xACC770", VA = "0xACC770", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xACCBB8", Offset = "0xACCBB8", VA = "0xACCBB8", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}
	}
	[Token(Token = "0x200007F")]
	public static class JSON
	{
		[Token(Token = "0x600032F")]
		[Address(RVA = "0xACCC0C", Offset = "0xACCC0C", VA = "0xACCC0C")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
namespace PartaGames.Android
{
	[Token(Token = "0x2000080")]
	public class PermissionGranterUnity : MonoBehaviour
	{
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<bool> PermissionRequestCallback;

		[Token(Token = "0x4000201")]
		private const string PERMISSION_GRANTER_GAMEOBJECT_NAME = "PermissionGranterUnity";

		[Token(Token = "0x4000202")]
		private const string PERMISSION_GRANTED = "PERMISSION_GRANTED";

		[Token(Token = "0x4000203")]
		private const string PERMISSION_DENIED = "PERMISSION_DENIED";

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static PermissionGranterUnity instance;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool initialized;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static AndroidJavaObject currentActivity;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static AndroidJavaObject permissionGranter;

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xACCC60", Offset = "0xACCC60", VA = "0xACCC60")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xACCD4C", Offset = "0xACCD4C", VA = "0xACCD4C")]
		private static void initialize()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xACCFB4", Offset = "0xACCFB4", VA = "0xACCFB4")]
		public static bool IsPermissionGranted(string permission)
		{
			return default(bool);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xACD128", Offset = "0xACD128", VA = "0xACD128")]
		public static void GrantPermission(string permission, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xACD2E4", Offset = "0xACD2E4", VA = "0xACD2E4")]
		private void permissionRequestCallbackInternal(string message)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xACD384", Offset = "0xACD384", VA = "0xACD384")]
		public PermissionGranterUnity()
		{
		}
	}
}
namespace MP3Sharp
{
	[Token(Token = "0x2000081")]
	internal class Buffer16BitStereo : ABuffer
	{
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int CHANNELS;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly byte[] m_Buffer;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int[] m_Bufferp;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_End;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int m_Offset;

		[Token(Token = "0x17000080")]
		public int BytesLeft
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0xACD440", Offset = "0xACD440", VA = "0xACD440")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xACD38C", Offset = "0xACD38C", VA = "0xACD38C")]
		public Buffer16BitStereo()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xACD44C", Offset = "0xACD44C", VA = "0xACD44C")]
		public int Read(byte[] bufferOut, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xACD59C", Offset = "0xACD59C", VA = "0xACD59C", Slot = "4")]
		public override void Append(int channel, short sampleValue)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xACD6B0", Offset = "0xACD6B0", VA = "0xACD6B0", Slot = "5")]
		public override void AppendSamples(int channel, float[] samples)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xACD8C8", Offset = "0xACD8C8", VA = "0xACD8C8", Slot = "8")]
		public sealed override void ClearBuffer()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xACD970", Offset = "0xACD970", VA = "0xACD970", Slot = "9")]
		public override void SetStopFlag()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xACD974", Offset = "0xACD974", VA = "0xACD974", Slot = "6")]
		public override void WriteBuffer(int val)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xACD9A4", Offset = "0xACD9A4", VA = "0xACD9A4", Slot = "7")]
		public override void Close()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class MP3SharpException : Exception
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0xACD9F4", Offset = "0xACD9F4", VA = "0xACD9F4")]
		public MP3SharpException()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xACDA4C", Offset = "0xACDA4C", VA = "0xACDA4C")]
		public MP3SharpException(string message)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xACDAB4", Offset = "0xACDAB4", VA = "0xACDAB4")]
		public MP3SharpException(string message, Exception inner)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xACDB24", Offset = "0xACDB24", VA = "0xACDB24")]
		protected MP3SharpException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xACDBA4", Offset = "0xACDBA4", VA = "0xACDBA4")]
		public void PrintStackTrace()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xACDC80", Offset = "0xACDC80", VA = "0xACDC80")]
		public void PrintStackTrace(StreamWriter ps)
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class MP3Stream : Stream
	{
		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Bitstream m_BitStream;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly MP3Sharp.Decoding.Decoder m_Decoder;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Buffer16BitStereo m_Buffer;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Stream m_SourceStream;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly int m_BackStreamByteCountRep;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private short m_ChannelCountRep;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected SoundFormat FormatRep;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_FrequencyRep;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _errorCounter;

		[Token(Token = "0x4000216")]
		private const int MAX_ERRORS = 20;

		[Token(Token = "0x17000081")]
		public bool IsEOF
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0xACDD28", Offset = "0xACDD28", VA = "0xACDD28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0xACDD30", Offset = "0xACDD30", VA = "0xACDD30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public int ChunkSize
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0xACE574", Offset = "0xACE574", VA = "0xACE574")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000083")]
		public override bool CanRead
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0xACE57C", Offset = "0xACE57C", VA = "0xACE57C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public override bool CanSeek
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0xACE59C", Offset = "0xACE59C", VA = "0xACE59C", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public override bool CanWrite
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0xACE5BC", Offset = "0xACE5BC", VA = "0xACE5BC", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000086")]
		public override long Length
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0xACE5DC", Offset = "0xACE5DC", VA = "0xACE5DC", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000087")]
		public override long Position
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0xACE5FC", Offset = "0xACE5FC", VA = "0xACE5FC", Slot = "12")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000352")]
			[Address(RVA = "0xACE61C", Offset = "0xACE61C", VA = "0xACE61C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public int Frequency
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0xACE640", Offset = "0xACE640", VA = "0xACE640")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000089")]
		public short ChannelCount
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0xACE648", Offset = "0xACE648", VA = "0xACE648")]
			get
			{
				return default(short);
			}
		}

		[Token(Token = "0x1700008A")]
		public SoundFormat Format
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0xACE650", Offset = "0xACE650", VA = "0xACE650")]
			get
			{
				return default(SoundFormat);
			}
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xACDD3C", Offset = "0xACDD3C", VA = "0xACDD3C")]
		public MP3Stream(string fileName)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xACDDC4", Offset = "0xACDDC4", VA = "0xACDDC4")]
		public MP3Stream(string fileName, int chunkSize)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xACDDBC", Offset = "0xACDDBC", VA = "0xACDDBC")]
		public MP3Stream(Stream sourceStream)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xACDE48", Offset = "0xACDE48", VA = "0xACDE48")]
		public MP3Stream(Stream sourceStream, int chunkSize)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xACE658", Offset = "0xACE658", VA = "0xACE658", Slot = "21")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xACE67C", Offset = "0xACE67C", VA = "0xACE67C", Slot = "30")]
		public override long Seek(long pos, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xACE6A0", Offset = "0xACE6A0", VA = "0xACE6A0", Slot = "31")]
		public override void SetLength(long len)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xACE6E0", Offset = "0xACE6E0", VA = "0xACE6E0", Slot = "35")]
		public override void Write(byte[] buf, int ofs, int count)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xACE720", Offset = "0xACE720", VA = "0xACE720")]
		public int DecodeFrames(int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xACE770", Offset = "0xACE770", VA = "0xACE770", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xACE80C", Offset = "0xACE80C", VA = "0xACE80C", Slot = "19")]
		public override void Close()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xACE2B0", Offset = "0xACE2B0", VA = "0xACE2B0")]
		private bool ReadFrame()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000084")]
	public enum SoundFormat
	{
		[Token(Token = "0x4000219")]
		Pcm16BitMono,
		[Token(Token = "0x400021A")]
		Pcm16BitStereo
	}
}
namespace MP3Sharp.Support
{
	[Token(Token = "0x2000085")]
	internal class SupportClass
	{
		[Token(Token = "0x600035E")]
		[Address(RVA = "0xACEAC0", Offset = "0xACEAC0", VA = "0xACEAC0")]
		public static int URShift(int number, int bits)
		{
			return default(int);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xACEAE8", Offset = "0xACEAE8", VA = "0xACEAE8")]
		public static int URShift(int number, long bits)
		{
			return default(int);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xACEB10", Offset = "0xACEB10", VA = "0xACEB10")]
		public static long URShift(long number, int bits)
		{
			return default(long);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xACEB38", Offset = "0xACEB38", VA = "0xACEB38")]
		public static long URShift(long number, long bits)
		{
			return default(long);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xACDC34", Offset = "0xACDC34", VA = "0xACDC34")]
		public static void WriteStackTrace(Exception throwable, TextWriter stream)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xACEB60", Offset = "0xACEB60", VA = "0xACEB60")]
		public static long Identity(long literal)
		{
			return default(long);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xACEB64", Offset = "0xACEB64", VA = "0xACEB64")]
		public static ulong Identity(ulong literal)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xACEB68", Offset = "0xACEB68", VA = "0xACEB68")]
		public static float Identity(float literal)
		{
			return default(float);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xACEB6C", Offset = "0xACEB6C", VA = "0xACEB6C")]
		public static double Identity(double literal)
		{
			return default(double);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xACEB70", Offset = "0xACEB70", VA = "0xACEB70")]
		public static int ReadInput(Stream sourceStream, ref sbyte[] target, int start, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xACEC5C", Offset = "0xACEC5C", VA = "0xACEC5C")]
		public static byte[] ToByteArray(sbyte[] sbyteArray)
		{
			return null;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xACED00", Offset = "0xACED00", VA = "0xACED00")]
		public static byte[] ToByteArray(string sourceString)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xACEDB0", Offset = "0xACEDB0", VA = "0xACEDB0")]
		public static void GetSBytesFromString(string sourceString, int sourceStart, int sourceEnd, ref sbyte[] destinationArray, int destinationStart)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xACEE38", Offset = "0xACEE38", VA = "0xACEE38")]
		public SupportClass()
		{
		}
	}
}
namespace MP3Sharp.IO
{
	[Token(Token = "0x2000086")]
	internal class RandomAccessFileStream
	{
		[Token(Token = "0x600036C")]
		[Address(RVA = "0xACEE40", Offset = "0xACEE40", VA = "0xACEE40")]
		public static FileStream CreateRandomAccessFile(string fileName, string mode)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xACEF60", Offset = "0xACEF60", VA = "0xACEF60")]
		public RandomAccessFileStream()
		{
		}
	}
	[Token(Token = "0x2000087")]
	internal class RiffFile
	{
		[Token(Token = "0x2000088")]
		internal class RiffChunkHeader
		{
			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int CkId;

			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int CkSize;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RiffFile m_EnclosingInstance;

			[Token(Token = "0x1700008B")]
			public RiffFile EnclosingInstance
			{
				[Token(Token = "0x6000381")]
				[Address(RVA = "0xAD0C70", Offset = "0xAD0C70", VA = "0xAD0C70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0xACF03C", Offset = "0xACF03C", VA = "0xACF03C")]
			public RiffChunkHeader(RiffFile enclosingInstance)
			{
			}

			[Token(Token = "0x6000382")]
			[Address(RVA = "0xAD0C78", Offset = "0xAD0C78", VA = "0xAD0C78")]
			private void InitBlock(RiffFile enclosingInstance)
			{
			}
		}

		[Token(Token = "0x400021B")]
		protected const int DDC_SUCCESS = 0;

		[Token(Token = "0x400021C")]
		protected const int DDC_FAILURE = 1;

		[Token(Token = "0x400021D")]
		protected const int DDC_OUT_OF_MEMORY = 2;

		[Token(Token = "0x400021E")]
		protected const int DDC_FILE_ERROR = 3;

		[Token(Token = "0x400021F")]
		protected const int DDC_INVALID_CALL = 4;

		[Token(Token = "0x4000220")]
		protected const int DDC_USER_ABORT = 5;

		[Token(Token = "0x4000221")]
		protected const int DDC_INVALID_FILE = 6;

		[Token(Token = "0x4000222")]
		protected const int RFM_UNKNOWN = 0;

		[Token(Token = "0x4000223")]
		protected const int RFM_WRITE = 1;

		[Token(Token = "0x4000224")]
		protected const int RFM_READ = 2;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly RiffChunkHeader m_RiffHeader;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int Fmode;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Stream m_File;

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xACEF68", Offset = "0xACEF68", VA = "0xACEF68")]
		public RiffFile()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xACF14C", Offset = "0xACF14C", VA = "0xACF14C", Slot = "4")]
		public virtual int CurrentFileMode()
		{
			return default(int);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xACF154", Offset = "0xACF154", VA = "0xACF154", Slot = "5")]
		public virtual int Open(string filename, int newMode)
		{
			return default(int);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xACF714", Offset = "0xACF714", VA = "0xACF714", Slot = "6")]
		public virtual int Open(Stream stream, int newMode)
		{
			return default(int);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xACFC94", Offset = "0xACFC94", VA = "0xACFC94", Slot = "7")]
		public virtual int Write(sbyte[] data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xACFD94", Offset = "0xACFD94", VA = "0xACFD94", Slot = "8")]
		public virtual int Write(short[] data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xACFF4C", Offset = "0xACFF4C", VA = "0xACFF4C", Slot = "9")]
		public virtual int Write(RiffChunkHeader riffHeader, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xAD011C", Offset = "0xAD011C", VA = "0xAD011C", Slot = "10")]
		public virtual int Write(short data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xAD025C", Offset = "0xAD025C", VA = "0xAD025C", Slot = "11")]
		public virtual int Write(int data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xAD039C", Offset = "0xAD039C", VA = "0xAD039C", Slot = "12")]
		public virtual int Read(sbyte[] data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xAD0440", Offset = "0xAD0440", VA = "0xAD0440", Slot = "13")]
		public virtual int Expect(string data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xAD0544", Offset = "0xAD0544", VA = "0xAD0544", Slot = "14")]
		public virtual int Close()
		{
			return default(int);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xAD08D4", Offset = "0xAD08D4", VA = "0xAD08D4", Slot = "15")]
		public virtual long CurrentFilePosition()
		{
			return default(long);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xAD0970", Offset = "0xAD0970", VA = "0xAD0970", Slot = "16")]
		public virtual int Backpatch(long fileOffset, RiffChunkHeader data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xAD0A44", Offset = "0xAD0A44", VA = "0xAD0A44", Slot = "17")]
		public virtual int Backpatch(long fileOffset, sbyte[] data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xAD0B18", Offset = "0xAD0B18", VA = "0xAD0B18", Slot = "18")]
		protected internal virtual int Seek(long offset)
		{
			return default(int);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xAD0BC0", Offset = "0xAD0BC0", VA = "0xAD0BC0")]
		private string DDCRET_String(int retcode)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xACF06C", Offset = "0xACF06C", VA = "0xACF06C")]
		public static int FourCC(string chunkName)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000089")]
	internal class WaveFile : RiffFile
	{
		[Token(Token = "0x200008A")]
		internal sealed class WaveFormatChunkData
		{
			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private WaveFile m_EnclosingInstance;

			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int NumAvgBytesPerSec;

			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public short NumBitsPerSample;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
			public short NumBlockAlign;

			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public short NumChannels;

			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int NumSamplesPerSec;

			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public short FormatTag;

			[Token(Token = "0x1700008C")]
			public WaveFile EnclosingInstance
			{
				[Token(Token = "0x600038E")]
				[Address(RVA = "0xAD1424", Offset = "0xAD1424", VA = "0xAD1424")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0xAD13C8", Offset = "0xAD13C8", VA = "0xAD13C8")]
			public WaveFormatChunkData(WaveFile enclosingInstance)
			{
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0xAD142C", Offset = "0xAD142C", VA = "0xAD142C")]
			private void InitBlock(WaveFile enclosingInstance)
			{
			}

			[Token(Token = "0x6000390")]
			[Address(RVA = "0xAD11B8", Offset = "0xAD11B8", VA = "0xAD11B8")]
			public void Config(int newSamplingRate, short newBitsPerSample, short newNumChannels)
			{
			}
		}

		[Token(Token = "0x200008B")]
		internal class WaveFormatChunk
		{
			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaveFormatChunkData Data;

			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private WaveFile m_EnclosingInstance;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RiffChunkHeader Header;

			[Token(Token = "0x1700008D")]
			public WaveFile EnclosingInstance
			{
				[Token(Token = "0x6000392")]
				[Address(RVA = "0xAD1434", Offset = "0xAD1434", VA = "0xAD1434")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0xAD0D88", Offset = "0xAD0D88", VA = "0xAD0D88")]
			public WaveFormatChunk(WaveFile enclosingInstance)
			{
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0xAD143C", Offset = "0xAD143C", VA = "0xAD143C")]
			private void InitBlock(WaveFile enclosingInstance)
			{
			}

			[Token(Token = "0x6000394")]
			[Address(RVA = "0xAD1444", Offset = "0xAD1444", VA = "0xAD1444", Slot = "4")]
			public virtual int VerifyValidity()
			{
				return default(int);
			}
		}

		[Token(Token = "0x200008C")]
		internal class WaveFileSample
		{
			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public short[] Chan;

			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private WaveFile m_EnclosingInstance;

			[Token(Token = "0x1700008E")]
			public WaveFile EnclosingInstance
			{
				[Token(Token = "0x6000396")]
				[Address(RVA = "0xAD1584", Offset = "0xAD1584", VA = "0xAD1584")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0xAD1504", Offset = "0xAD1504", VA = "0xAD1504")]
			public WaveFileSample(WaveFile enclosingInstance)
			{
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0xAD158C", Offset = "0xAD158C", VA = "0xAD158C")]
			private void InitBlock(WaveFile enclosingInstance)
			{
			}
		}

		[Token(Token = "0x400022B")]
		public const int MAX_WAVE_CHANNELS = 2;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly int m_NumSamples;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly RiffChunkHeader m_PcmData;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly WaveFormatChunk m_WaveFormat;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_JustWriteLengthBytes;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long m_PcmDataOffset;

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xAD0C80", Offset = "0xAD0C80", VA = "0xAD0C80")]
		public WaveFile()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xAD0EDC", Offset = "0xAD0EDC", VA = "0xAD0EDC", Slot = "19")]
		public virtual int OpenForWrite(string filename, Stream stream, int samplingRate, short bitsPerSample, short numChannels)
		{
			return default(int);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xAD1200", Offset = "0xAD1200", VA = "0xAD1200", Slot = "20")]
		public virtual int WriteData(short[] data, int numData)
		{
			return default(int);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xAD1230", Offset = "0xAD1230", VA = "0xAD1230", Slot = "14")]
		public override int Close()
		{
			return default(int);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xAD1290", Offset = "0xAD1290", VA = "0xAD1290")]
		public int Close(bool justWriteLengthBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xAD12BC", Offset = "0xAD12BC", VA = "0xAD12BC", Slot = "21")]
		public virtual int SamplingRate()
		{
			return default(int);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xAD12E0", Offset = "0xAD12E0", VA = "0xAD12E0", Slot = "22")]
		public virtual short BitsPerSample()
		{
			return default(short);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xAD1304", Offset = "0xAD1304", VA = "0xAD1304", Slot = "23")]
		public virtual short NumChannels()
		{
			return default(short);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xAD1328", Offset = "0xAD1328", VA = "0xAD1328", Slot = "24")]
		public virtual int NumSamples()
		{
			return default(int);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xAD1330", Offset = "0xAD1330", VA = "0xAD1330", Slot = "25")]
		public virtual int OpenForWrite(string filename, WaveFile otherWave)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200008D")]
	internal class WaveFileBuffer : ABuffer
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly short[] m_Buffer;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly short[] m_Bufferp;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly int m_Channels;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly WaveFile m_OutWave;

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xAD1594", Offset = "0xAD1594", VA = "0xAD1594")]
		public WaveFileBuffer(int numberOfChannels, int freq, string fileName)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xAD1728", Offset = "0xAD1728", VA = "0xAD1728")]
		public WaveFileBuffer(int numberOfChannels, int freq, Stream stream)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xAD1874", Offset = "0xAD1874", VA = "0xAD1874", Slot = "4")]
		public override void Append(int channel, short valueRenamed)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xAD18D8", Offset = "0xAD18D8", VA = "0xAD18D8", Slot = "6")]
		public override void WriteBuffer(int val)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xAD1958", Offset = "0xAD1958", VA = "0xAD1958")]
		public void close(bool justWriteLengthBytes)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xAD1990", Offset = "0xAD1990", VA = "0xAD1990", Slot = "7")]
		public override void Close()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xAD19B4", Offset = "0xAD19B4", VA = "0xAD19B4", Slot = "8")]
		public override void ClearBuffer()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xAD19B8", Offset = "0xAD19B8", VA = "0xAD19B8", Slot = "9")]
		public override void SetStopFlag()
		{
		}
	}
}
namespace MP3Sharp.Decoding
{
	[Token(Token = "0x200008E")]
	internal abstract class ABuffer
	{
		[Token(Token = "0x4000241")]
		public const int OBUFFERSIZE = 2304;

		[Token(Token = "0x4000242")]
		public const int MAXCHANNELS = 2;

		[Token(Token = "0x60003A0")]
		public abstract void Append(int channel, short valueRenamed);

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xAD19BC", Offset = "0xAD19BC", VA = "0xAD19BC", Slot = "5")]
		public virtual void AppendSamples(int channel, float[] f)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xAD1A7C", Offset = "0xAD1A7C", VA = "0xAD1A7C")]
		private static short Clip(float sample)
		{
			return default(short);
		}

		[Token(Token = "0x60003A3")]
		public abstract void WriteBuffer(int val);

		[Token(Token = "0x60003A4")]
		public abstract void Close();

		[Token(Token = "0x60003A5")]
		public abstract void ClearBuffer();

		[Token(Token = "0x60003A6")]
		public abstract void SetStopFlag();

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xACD438", Offset = "0xACD438", VA = "0xACD438")]
		protected ABuffer()
		{
		}
	}
	[Token(Token = "0x200008F")]
	internal sealed class BitReserve
	{
		[Token(Token = "0x4000243")]
		private const int BUFSIZE = 32768;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int BUFSIZE_MASK;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int[] buf;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int offset;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int totbit;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int buf_byte_idx;

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xAD1AC4", Offset = "0xAD1AC4", VA = "0xAD1AC4")]
		internal BitReserve()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xAD1AEC", Offset = "0xAD1AEC", VA = "0xAD1AEC")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xAD1B44", Offset = "0xAD1B44", VA = "0xAD1B44")]
		public int hsstell()
		{
			return default(int);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xAD1B4C", Offset = "0xAD1B4C", VA = "0xAD1B4C")]
		public int ReadBits(int N)
		{
			return default(int);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xAD1C84", Offset = "0xAD1C84", VA = "0xAD1C84")]
		public int ReadOneBit()
		{
			return default(int);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xAD1D2C", Offset = "0xAD1D2C", VA = "0xAD1D2C")]
		public void hputbuf(int val)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xAD1E1C", Offset = "0xAD1E1C", VA = "0xAD1E1C")]
		public void RewindStreamBits(int bitCount)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xAD1E40", Offset = "0xAD1E40", VA = "0xAD1E40")]
		public void RewindStreamBytes(int byteCount)
		{
		}
	}
	[Token(Token = "0x2000090")]
	internal sealed class Bitstream
	{
		[Token(Token = "0x4000249")]
		private const int BUFFER_INT_SIZE = 433;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static sbyte INITIAL_SYNC;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		internal static sbyte STRICT_SYNC;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly int[] bitmask;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly PushbackStream m_SourceStream;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_BitIndex;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Crc16[] m_CRC;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private sbyte[] m_FrameBytes;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int[] m_FrameBuffer;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_FrameSize;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Header m_Header;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool single_ch_mode;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private sbyte[] m_SyncBuffer;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_SyncWord;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_WordPointer;

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xACE1A0", Offset = "0xACE1A0", VA = "0xACE1A0")]
		internal Bitstream(PushbackStream stream)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xAD1EB0", Offset = "0xAD1EB0", VA = "0xAD1EB0")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xACE824", Offset = "0xACE824", VA = "0xACE824")]
		public void close()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xACE904", Offset = "0xACE904", VA = "0xACE904")]
		internal Header readFrame()
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xAD208C", Offset = "0xAD208C", VA = "0xAD208C")]
		private Header readNextFrame()
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xAD2474", Offset = "0xAD2474", VA = "0xAD2474")]
		public void unreadFrame()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xAD1FE4", Offset = "0xAD1FE4", VA = "0xAD1FE4")]
		public void CloseFrame()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xAD25CC", Offset = "0xAD25CC", VA = "0xAD25CC")]
		public bool IsSyncCurrentPosition(int syncmode)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xAD293C", Offset = "0xAD293C", VA = "0xAD293C")]
		public int readBits(int n)
		{
			return default(int);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xAD2A54", Offset = "0xAD2A54", VA = "0xAD2A54")]
		public int readCheckedBits(int n)
		{
			return default(int);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xAD2568", Offset = "0xAD2568", VA = "0xAD2568")]
		internal BitstreamException newBitstreamException(int errorcode)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xAD201C", Offset = "0xAD201C", VA = "0xAD201C")]
		internal BitstreamException newBitstreamException(int errorcode, Exception throwable)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xAD2AA4", Offset = "0xAD2AA4", VA = "0xAD2AA4")]
		internal int syncHeader(sbyte syncmode)
		{
			return default(int);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xAD2868", Offset = "0xAD2868", VA = "0xAD2868")]
		public bool isSyncMark(int headerstring, int syncmode, int word)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xAD2BD8", Offset = "0xAD2BD8", VA = "0xAD2BD8")]
		internal void read_frame_data(int bytesize)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xAD2D80", Offset = "0xAD2D80", VA = "0xAD2D80")]
		internal void ParseFrame()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xAD2940", Offset = "0xAD2940", VA = "0xAD2940")]
		public int GetBitsFromBuffer(int countBits)
		{
			return default(int);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xAD2E74", Offset = "0xAD2E74", VA = "0xAD2E74")]
		internal void SetSyncWord(int syncword0)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xAD2C18", Offset = "0xAD2C18", VA = "0xAD2C18")]
		private void readFully(sbyte[] b, int offs, int len)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xAD2728", Offset = "0xAD2728", VA = "0xAD2728")]
		private int readBytes(sbyte[] b, int offs, int len)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000091")]
	internal struct BitstreamErrors
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int UNKNOWN_ERROR;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int UNKNOWN_SAMPLE_RATE;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int STREAM_ERROR;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int UNEXPECTED_EOF;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int STREAM_EOF;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int BITSTREAM_LAST;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int BITSTREAM_ERROR;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int DECODER_ERROR;
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class BitstreamException : MP3SharpException
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int m_Errorcode;

		[Token(Token = "0x1700008F")]
		public virtual int ErrorCode
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0xAD30D0", Offset = "0xAD30D0", VA = "0xAD30D0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xAD2F50", Offset = "0xAD2F50", VA = "0xAD2F50")]
		public BitstreamException(string message, Exception inner)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xAD2A58", Offset = "0xAD2A58", VA = "0xAD2A58")]
		public BitstreamException(int errorcode, Exception inner)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xAD304C", Offset = "0xAD304C", VA = "0xAD304C")]
		protected BitstreamException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xAD30D8", Offset = "0xAD30D8", VA = "0xAD30D8", Slot = "10")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xAD2F68", Offset = "0xAD2F68", VA = "0xAD2F68")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xAD2FC8", Offset = "0xAD2FC8", VA = "0xAD2FC8")]
		public static string GetErrorString(int errorcode)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	internal class CircularByteBuffer
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private byte[] m_DataArray;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_Index;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_Length;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_NumValid;

		[Token(Token = "0x17000090")]
		public int BufferSize
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xAD33B4", Offset = "0xAD33B4", VA = "0xAD33B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0xAD33BC", Offset = "0xAD33BC", VA = "0xAD33BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public byte this[int index]
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xAD34F0", Offset = "0xAD34F0", VA = "0xAD34F0")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0xAD34F8", Offset = "0xAD34F8", VA = "0xAD34F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public int NumValid
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xAD3548", Offset = "0xAD3548", VA = "0xAD3548")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xAD3550", Offset = "0xAD3550", VA = "0xAD3550")]
			set
			{
			}
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xAD31A4", Offset = "0xAD31A4", VA = "0xAD31A4")]
		public CircularByteBuffer(int size)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xAD321C", Offset = "0xAD321C", VA = "0xAD321C")]
		public CircularByteBuffer(CircularByteBuffer cdb)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xAD361C", Offset = "0xAD361C", VA = "0xAD361C")]
		public CircularByteBuffer Copy()
		{
			return null;
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xAD367C", Offset = "0xAD367C", VA = "0xAD367C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xAD3688", Offset = "0xAD3688", VA = "0xAD3688")]
		public byte Push(byte newValue)
		{
			return default(byte);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xAD37AC", Offset = "0xAD37AC", VA = "0xAD37AC")]
		public byte Pop()
		{
			return default(byte);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xAD38D8", Offset = "0xAD38D8", VA = "0xAD38D8")]
		public byte Peek()
		{
			return default(byte);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xAD34A8", Offset = "0xAD34A8", VA = "0xAD34A8")]
		private byte InternalGet(int offset)
		{
			return default(byte);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xAD3500", Offset = "0xAD3500", VA = "0xAD3500")]
		private void InternalSet(int offset, byte valueToSet)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xAD39A0", Offset = "0xAD39A0", VA = "0xAD39A0")]
		public byte[] GetRange(int str, int stp)
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xAD3A5C", Offset = "0xAD3A5C", VA = "0xAD3A5C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000094")]
	internal sealed class Crc16
	{
		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly short Polynomial;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private short m_Crc;

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xAD3CE4", Offset = "0xAD3CE4", VA = "0xAD3CE4")]
		static Crc16()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xAD3D30", Offset = "0xAD3D30", VA = "0xAD3D30")]
		public Crc16()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xAD3D50", Offset = "0xAD3D50", VA = "0xAD3D50")]
		public void add_bits(int bitstring, int length)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xAD3E08", Offset = "0xAD3E08", VA = "0xAD3E08")]
		public short Checksum()
		{
			return default(short);
		}
	}
	[Token(Token = "0x2000095")]
	internal class Decoder
	{
		[Token(Token = "0x2000096")]
		internal class Params : ICloneable
		{
			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Equalizer m_Equalizer;

			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private OutputChannels m_OutputChannels;

			[Token(Token = "0x17000099")]
			public virtual OutputChannels OutputChannels
			{
				[Token(Token = "0x60003F2")]
				[Address(RVA = "0xAD4714", Offset = "0xAD4714", VA = "0xAD4714", Slot = "5")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003F3")]
				[Address(RVA = "0xAD471C", Offset = "0xAD471C", VA = "0xAD471C", Slot = "6")]
				set
				{
				}
			}

			[Token(Token = "0x1700009A")]
			public virtual Equalizer InitialEqualizerSettings
			{
				[Token(Token = "0x60003F4")]
				[Address(RVA = "0xAD477C", Offset = "0xAD477C", VA = "0xAD477C", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xAD3EA8", Offset = "0xAD3EA8", VA = "0xAD3EA8", Slot = "4")]
			public object Clone()
			{
				return null;
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xAD470C", Offset = "0xAD470C", VA = "0xAD470C")]
			public Params()
			{
			}
		}

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Params DEFAULT_PARAMS;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Params params_Renamed;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Equalizer m_Equalizer;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SynthesisFilter m_LeftChannelFilter;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SynthesisFilter m_RightChannelFilter;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_IsInitialized;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private LayerIDecoder m_L1Decoder;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private LayerIIDecoder m_L2Decoder;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LayerIIIDecoder m_L3Decoder;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ABuffer m_Output;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_OutputChannels;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_OutputFrequency;

		[Token(Token = "0x17000093")]
		public static Params DefaultParams
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0xACE02C", Offset = "0xACE02C", VA = "0xACE02C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public virtual Equalizer Equalizer
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xAD3FE4", Offset = "0xAD3FE4", VA = "0xAD3FE4", Slot = "4")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public virtual ABuffer OutputBuffer
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xAD40B0", Offset = "0xAD40B0", VA = "0xAD40B0", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public virtual int OutputFrequency
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xAD40B8", Offset = "0xAD40B8", VA = "0xAD40B8", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000097")]
		public virtual int OutputChannels
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xAD40C0", Offset = "0xAD40C0", VA = "0xAD40C0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000098")]
		public virtual int OutputBlockSize
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xAD40C8", Offset = "0xAD40C8", VA = "0xAD40C8", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xAD3E1C", Offset = "0xAD3E1C", VA = "0xAD3E1C")]
		public Decoder()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xACE0D8", Offset = "0xACE0D8", VA = "0xACE0D8")]
		public Decoder(Params params0)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xAD3E38", Offset = "0xAD3E38", VA = "0xAD3E38")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xAD40EC", Offset = "0xAD40EC", VA = "0xAD40EC", Slot = "9")]
		public virtual ABuffer DecodeFrame(Header header, Bitstream stream)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xAD4388", Offset = "0xAD4388", VA = "0xAD4388", Slot = "10")]
		protected internal virtual DecoderException NewDecoderException(int errorcode)
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xAD4438", Offset = "0xAD4438", VA = "0xAD4438", Slot = "11")]
		protected internal virtual DecoderException NewDecoderException(int errorcode, Exception throwable)
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xAD44A8", Offset = "0xAD44A8", VA = "0xAD44A8", Slot = "12")]
		protected internal virtual IFrameDecoder RetrieveDecoder(Header header, Bitstream stream, int layer)
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xAD4208", Offset = "0xAD4208", VA = "0xAD4208")]
		private void Initialize(Header header)
		{
		}
	}
	[Token(Token = "0x2000097")]
	internal struct DecoderErrors
	{
		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int UNKNOWN_ERROR;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int UNSUPPORTED_LAYER;
	}
	[Serializable]
	[Token(Token = "0x2000098")]
	internal class DecoderException : MP3SharpException
	{
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int m_ErrorCode;

		[Token(Token = "0x1700009B")]
		public virtual int ErrorCode
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0xAD4980", Offset = "0xAD4980", VA = "0xAD4980", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xAD4800", Offset = "0xAD4800", VA = "0xAD4800")]
		public DecoderException(string message, Exception inner)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xAD43EC", Offset = "0xAD43EC", VA = "0xAD43EC")]
		public DecoderException(int errorcode, Exception inner)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xAD48FC", Offset = "0xAD48FC", VA = "0xAD48FC")]
		protected DecoderException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xAD4988", Offset = "0xAD4988", VA = "0xAD4988", Slot = "10")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xAD4818", Offset = "0xAD4818", VA = "0xAD4818")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xAD4878", Offset = "0xAD4878", VA = "0xAD4878")]
		public static string GetErrorString(int errorcode)
		{
			return null;
		}
	}
	[Token(Token = "0x2000099")]
	internal class Equalizer
	{
		[Token(Token = "0x200009A")]
		internal abstract class EQFunction
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xAD4F5C", Offset = "0xAD4F5C", VA = "0xAD4F5C", Slot = "4")]
			public virtual float getBand(int band)
			{
				return default(float);
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0xAD4F64", Offset = "0xAD4F64", VA = "0xAD4F64")]
			protected EQFunction()
			{
			}
		}

		[Token(Token = "0x4000278")]
		private const int BANDS = 32;

		[Token(Token = "0x4000279")]
		public const float BAND_NOT_PRESENT = float.NegativeInfinity;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Equalizer PASS_THRU_EQ;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float[] settings;

		[Token(Token = "0x1700009C")]
		public float[] FromFloatArray
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xAD4AE0", Offset = "0xAD4AE0", VA = "0xAD4AE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public virtual Equalizer FromEqualizer
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xAD4CD8", Offset = "0xAD4CD8", VA = "0xAD4CD8", Slot = "4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public EQFunction FromEQFunction
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xAD4BC4", Offset = "0xAD4BC4", VA = "0xAD4BC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public virtual int BandCount
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xAD4D00", Offset = "0xAD4D00", VA = "0xAD4D00", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A0")]
		internal virtual float[] BandFactors
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xAD4D1C", Offset = "0xAD4D1C", VA = "0xAD4D1C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xAD40D0", Offset = "0xAD40D0", VA = "0xAD40D0")]
		public Equalizer()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xAD4AAC", Offset = "0xAD4AAC", VA = "0xAD4AAC")]
		public Equalizer(float[] settings)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xAD4B90", Offset = "0xAD4B90", VA = "0xAD4B90")]
		public Equalizer(EQFunction eq)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xAD4A54", Offset = "0xAD4A54", VA = "0xAD4A54")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xAD4C68", Offset = "0xAD4C68", VA = "0xAD4C68")]
		public void reset()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xAD4E40", Offset = "0xAD4E40", VA = "0xAD4E40")]
		public float setBand(int band, float neweq)
		{
			return default(float);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xAD4EA8", Offset = "0xAD4EA8", VA = "0xAD4EA8")]
		public float getBand(int band)
		{
			return default(float);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xAD4CA8", Offset = "0xAD4CA8", VA = "0xAD4CA8")]
		private float limit(float eq)
		{
			return default(float);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xAD4DC8", Offset = "0xAD4DC8", VA = "0xAD4DC8")]
		internal float getBandFactor(float eq)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200009B")]
	internal class Header
	{
		[Token(Token = "0x400027C")]
		public const int MPEG2_LSF = 0;

		[Token(Token = "0x400027D")]
		public const int MPEG25_LSF = 2;

		[Token(Token = "0x400027E")]
		public const int MPEG1 = 1;

		[Token(Token = "0x400027F")]
		public const int STEREO = 0;

		[Token(Token = "0x4000280")]
		public const int JOINT_STEREO = 1;

		[Token(Token = "0x4000281")]
		public const int DUAL_CHANNEL = 2;

		[Token(Token = "0x4000282")]
		public const int SINGLE_CHANNEL = 3;

		[Token(Token = "0x4000283")]
		public const int FOURTYFOUR_POINT_ONE = 0;

		[Token(Token = "0x4000284")]
		public const int FOURTYEIGHT = 1;

		[Token(Token = "0x4000285")]
		public const int THIRTYTWO = 2;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int[][] frequencies;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int[][][] bitrates;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly string[][][] bitrate_str;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _headerstring;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public short checksum;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Crc16 crc;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int framesize;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool h_copyright;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool h_original;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int h_layer;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int h_protection_bit;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int h_bitrate_index;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int h_padding_bit;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int h_mode_extension;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int h_mode;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int h_number_of_subbands;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int h_intensity_stereo_bound;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int h_sample_frequency;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int h_version;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int nSlots;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private sbyte syncmode;

		[Token(Token = "0x170000A1")]
		public virtual int SyncHeader
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0xAD4FCC", Offset = "0xAD4FCC", VA = "0xAD4FCC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xAD1FF8", Offset = "0xAD1FF8", VA = "0xAD1FF8")]
		internal Header()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xAD4F6C", Offset = "0xAD4F6C", VA = "0xAD4F6C")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xAD4FD4", Offset = "0xAD4FD4", VA = "0xAD4FD4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xAD20C4", Offset = "0xAD20C4", VA = "0xAD20C4")]
		internal void read_header(Bitstream stream, Crc16[] crcp)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xAD57C8", Offset = "0xAD57C8", VA = "0xAD57C8")]
		public int version()
		{
			return default(int);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xAD57D0", Offset = "0xAD57D0", VA = "0xAD57D0")]
		public int layer()
		{
			return default(int);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xAD57D8", Offset = "0xAD57D8", VA = "0xAD57D8")]
		public int bitrate_index()
		{
			return default(int);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xAD57E0", Offset = "0xAD57E0", VA = "0xAD57E0")]
		public int sample_frequency()
		{
			return default(int);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xACEA24", Offset = "0xACEA24", VA = "0xACEA24")]
		public int frequency()
		{
			return default(int);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xAD57E8", Offset = "0xAD57E8", VA = "0xAD57E8")]
		public int mode()
		{
			return default(int);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xAD537C", Offset = "0xAD537C", VA = "0xAD537C")]
		public bool IsProtection()
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xAD57F0", Offset = "0xAD57F0", VA = "0xAD57F0")]
		public bool IsCopyright()
		{
			return default(bool);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xAD57F8", Offset = "0xAD57F8", VA = "0xAD57F8")]
		public bool IsOriginal()
		{
			return default(bool);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xAD5800", Offset = "0xAD5800", VA = "0xAD5800")]
		public bool IsChecksumOK()
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xAD5830", Offset = "0xAD5830", VA = "0xAD5830")]
		public bool IsPadding()
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xAD5840", Offset = "0xAD5840", VA = "0xAD5840")]
		public int slots()
		{
			return default(int);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xAD5848", Offset = "0xAD5848", VA = "0xAD5848")]
		public int mode_extension()
		{
			return default(int);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xAD559C", Offset = "0xAD559C", VA = "0xAD559C")]
		public int calculate_framesize()
		{
			return default(int);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xAD5850", Offset = "0xAD5850", VA = "0xAD5850")]
		public int max_number_of_frames(int streamsize)
		{
			return default(int);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xAD5874", Offset = "0xAD5874", VA = "0xAD5874")]
		public int min_number_of_frames(int streamsize)
		{
			return default(int);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xAD5898", Offset = "0xAD5898", VA = "0xAD5898")]
		public float ms_per_frame()
		{
			return default(float);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xAD5A70", Offset = "0xAD5A70", VA = "0xAD5A70")]
		public float total_ms(int streamsize)
		{
			return default(float);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xAD5198", Offset = "0xAD5198", VA = "0xAD5198")]
		public string layer_string()
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xAD54E0", Offset = "0xAD54E0", VA = "0xAD54E0")]
		public string bitrate_string()
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xAD538C", Offset = "0xAD538C", VA = "0xAD538C")]
		public string sample_frequency_string()
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xAD5230", Offset = "0xAD5230", VA = "0xAD5230")]
		public string mode_string()
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xAD52E8", Offset = "0xAD52E8", VA = "0xAD52E8")]
		public string version_string()
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xAD5AB0", Offset = "0xAD5AB0", VA = "0xAD5AB0")]
		public int number_of_subbands()
		{
			return default(int);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xAD5AB8", Offset = "0xAD5AB8", VA = "0xAD5AB8")]
		public int intensity_stereo_bound()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200009C")]
	internal sealed class Huffman
	{
		[Token(Token = "0x400029B")]
		private const int MXOFF = 250;

		[Token(Token = "0x400029C")]
		private const int HTN = 34;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[][] ValTab0;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[][] ValTab1;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int[][] ValTab2;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int[][] ValTab3;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int[][] ValTab4;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int[][] ValTab5;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly int[][] ValTab6;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly int[][] ValTab7;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly int[][] ValTab8;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly int[][] ValTab9;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly int[][] ValTab10;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly int[][] ValTab11;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly int[][] ValTab12;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly int[][] ValTab13;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly int[][] ValTab14;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly int[][] ValTab15;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static readonly int[][] ValTab16;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static readonly int[][] ValTab24;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static readonly int[][] ValTab32;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static readonly int[][] ValTab33;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static Huffman[] ht;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly int linbits;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly char tablename0;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		private readonly char tablename1;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int treelen;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly int[][] val;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly int xlen;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private readonly int ylen;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int[] hlen;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int linmax;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int ref_Renamed;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int[] table;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private char tablename2;

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xAD93AC", Offset = "0xAD93AC", VA = "0xAD93AC")]
		static Huffman()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xB19C78", Offset = "0xB19C78", VA = "0xB19C78")]
		private Huffman(string S, int XLEN, int YLEN, int LINBITS, int LINMAX, int REF, int[] TABLE, int[] HLEN, int[][] VAL, int TREELEN)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xB19D70", Offset = "0xB19D70", VA = "0xB19D70")]
		public static int Decode(Huffman h, int[] x, int[] y, int[] v, int[] w, BitReserve br)
		{
			return default(int);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xB1A17C", Offset = "0xB1A17C", VA = "0xB1A17C")]
		public static void Initialize()
		{
		}
	}
	[Token(Token = "0x200009D")]
	internal class OutputChannels
	{
		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int BOTH_CHANNELS;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int LEFT_CHANNEL;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int RIGHT_CHANNEL;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int DOWNMIX_CHANNELS;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly OutputChannels LEFT;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly OutputChannels RIGHT;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly OutputChannels BOTH;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly OutputChannels DOWNMIX;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly int outputChannels;

		[Token(Token = "0x170000A2")]
		public virtual int ChannelsOutputCode
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0xB1B5E0", Offset = "0xB1B5E0", VA = "0xB1B5E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A3")]
		public virtual int ChannelCount
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0xB1B5E8", Offset = "0xB1B5E8", VA = "0xB1B5E8", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xB1B564", Offset = "0xB1B564", VA = "0xB1B564")]
		private OutputChannels(int channels)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xB1B654", Offset = "0xB1B654", VA = "0xB1B654")]
		public static OutputChannels fromInt(int code)
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xB1B79C", Offset = "0xB1B79C", VA = "0xB1B79C", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xB1B828", Offset = "0xB1B828", VA = "0xB1B828", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200009E")]
	internal enum OutputChannelsEnum
	{
		[Token(Token = "0x40002C8")]
		BOTH_CHANNELS,
		[Token(Token = "0x40002C9")]
		LEFT_CHANNEL,
		[Token(Token = "0x40002CA")]
		RIGHT_CHANNEL,
		[Token(Token = "0x40002CB")]
		DOWNMIX_CHANNELS
	}
	[Token(Token = "0x200009F")]
	internal class PushbackStream
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly int m_BackBufferSize;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly CircularByteBuffer m_CircularByteBuffer;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Stream m_Stream;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly byte[] m_TemporaryBuffer;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_NumForwardBytesInBuffer;

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xB1B944", Offset = "0xB1B944", VA = "0xB1B944")]
		public PushbackStream(Stream s, int backBufferSize)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xB1BA1C", Offset = "0xB1BA1C", VA = "0xB1BA1C")]
		public int Read(sbyte[] toRead, int offset, int length)
		{
			return default(int);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xB1BBAC", Offset = "0xB1BBAC", VA = "0xB1BBAC")]
		public void UnRead(int length)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xB1BC1C", Offset = "0xB1BC1C", VA = "0xB1BC1C")]
		public void Close()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	internal class SampleBuffer : ABuffer
	{
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly short[] buffer;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int[] bufferp;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly int channels;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly int frequency;

		[Token(Token = "0x170000A4")]
		public virtual int ChannelCount
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0xB1BD40", Offset = "0xB1BD40", VA = "0xB1BD40", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A5")]
		public virtual int SampleFrequency
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0xB1BD48", Offset = "0xB1BD48", VA = "0xB1BD48", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A6")]
		public virtual short[] Buffer
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0xB1BD50", Offset = "0xB1BD50", VA = "0xB1BD50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public virtual int BufferLength
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0xB1BD58", Offset = "0xB1BD58", VA = "0xB1BD58", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xB1BC40", Offset = "0xB1BC40", VA = "0xB1BC40")]
		public SampleBuffer(int sample_frequency, int number_of_channels)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xB1BD80", Offset = "0xB1BD80", VA = "0xB1BD80", Slot = "4")]
		public override void Append(int channel, short valueRenamed)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xB1BDD8", Offset = "0xB1BDD8", VA = "0xB1BDD8", Slot = "5")]
		public override void AppendSamples(int channel, float[] f)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xB1BE98", Offset = "0xB1BE98", VA = "0xB1BE98", Slot = "6")]
		public override void WriteBuffer(int val)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xB1BE9C", Offset = "0xB1BE9C", VA = "0xB1BE9C", Slot = "7")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xB1BEA0", Offset = "0xB1BEA0", VA = "0xB1BEA0", Slot = "8")]
		public override void ClearBuffer()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xB1BEFC", Offset = "0xB1BEFC", VA = "0xB1BEFC", Slot = "9")]
		public override void SetStopFlag()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	internal class SynthesisFilter
	{
		[Token(Token = "0x40002D5")]
		private const double MY_PI = Math.PI;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float cos1_64;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly float cos3_64;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly float cos5_64;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly float cos7_64;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly float cos9_64;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly float cos11_64;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly float cos13_64;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly float cos15_64;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly float cos17_64;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly float cos19_64;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly float cos21_64;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static readonly float cos23_64;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly float cos25_64;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static readonly float cos27_64;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly float cos29_64;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static readonly float cos31_64;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly float cos1_32;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static readonly float cos3_32;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly float cos5_32;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private static readonly float cos7_32;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly float cos9_32;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static readonly float cos11_32;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly float cos13_32;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private static readonly float cos15_32;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly float cos1_16;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private static readonly float cos3_16;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly float cos5_16;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private static readonly float cos7_16;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly float cos1_8;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private static readonly float cos3_8;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly float cos1_4;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static float[] d;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static float[][] d16;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static readonly float[] d_data;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly int m_ChannelIndex;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float[] m_SubbandSamples;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly float scalefactor;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly float[] v1;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly float[] v2;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] _tmpOut;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] actual_v;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int actual_write_pos;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] eq;

		[Token(Token = "0x170000A8")]
		public float[] EQ
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0xB1C1EC", Offset = "0xB1C1EC", VA = "0xB1C1EC")]
			set
			{
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xB1BF00", Offset = "0xB1BF00", VA = "0xB1BF00")]
		public SynthesisFilter(int channelIndex, float factor, float[] eq0)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xB1C05C", Offset = "0xB1C05C", VA = "0xB1C05C")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xB1C2F4", Offset = "0xB1C2F4", VA = "0xB1C2F4")]
		public void reset()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xB1C394", Offset = "0xB1C394", VA = "0xB1C394")]
		public void WriteSample(float sample, int subbandIndex)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xB1C3E8", Offset = "0xB1C3E8", VA = "0xB1C3E8")]
		public void WriteAllSamples(float[] s)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xB1C458", Offset = "0xB1C458", VA = "0xB1C458")]
		private void compute_new_v()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xB1D554", Offset = "0xB1D554", VA = "0xB1D554")]
		private void compute_new_v_old()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xB1E9B4", Offset = "0xB1E9B4", VA = "0xB1E9B4")]
		private void compute_pcm_samples0(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xB1EC14", Offset = "0xB1EC14", VA = "0xB1EC14")]
		private void compute_pcm_samples1(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xB1EE80", Offset = "0xB1EE80", VA = "0xB1EE80")]
		private void compute_pcm_samples2(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xB1F0EC", Offset = "0xB1F0EC", VA = "0xB1F0EC")]
		private void compute_pcm_samples3(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xB1F354", Offset = "0xB1F354", VA = "0xB1F354")]
		private void compute_pcm_samples4(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xB1F5C4", Offset = "0xB1F5C4", VA = "0xB1F5C4")]
		private void compute_pcm_samples5(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xB1F830", Offset = "0xB1F830", VA = "0xB1F830")]
		private void compute_pcm_samples6(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xB1FAA0", Offset = "0xB1FAA0", VA = "0xB1FAA0")]
		private void compute_pcm_samples7(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xB1FD0C", Offset = "0xB1FD0C", VA = "0xB1FD0C")]
		private void compute_pcm_samples8(ABuffer buffer)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xB1FF7C", Offset = "0xB1FF7C", VA = "0xB1FF7C")]
		private void compute_pcm_samples9(ABuffer buffer)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xB201E8", Offset = "0xB201E8", VA = "0xB201E8")]
		private void compute_pcm_samples10(ABuffer buffer)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xB20458", Offset = "0xB20458", VA = "0xB20458")]
		private void compute_pcm_samples11(ABuffer buffer)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xB206C4", Offset = "0xB206C4", VA = "0xB206C4")]
		private void compute_pcm_samples12(ABuffer buffer)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xB20934", Offset = "0xB20934", VA = "0xB20934")]
		private void compute_pcm_samples13(ABuffer buffer)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xB20BA0", Offset = "0xB20BA0", VA = "0xB20BA0")]
		private void compute_pcm_samples14(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xB20E10", Offset = "0xB20E10", VA = "0xB20E10")]
		private void compute_pcm_samples15(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xB2107C", Offset = "0xB2107C", VA = "0xB2107C")]
		private void compute_pcm_samples(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xB211D4", Offset = "0xB211D4", VA = "0xB211D4")]
		public void calculate_pcm_samples(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xB21270", Offset = "0xB21270", VA = "0xB21270")]
		private static float[] load_d()
		{
			return null;
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xB1C0B4", Offset = "0xB1C0B4", VA = "0xB1C0B4")]
		private static float[][] splitArray(float[] array, int blockSize)
		{
			return null;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xB21278", Offset = "0xB21278", VA = "0xB21278")]
		private static float[] subArray(float[] array, int offs, int len)
		{
			return null;
		}
	}
}
namespace MP3Sharp.Decoding.Decoders
{
	[Token(Token = "0x20000A2")]
	internal abstract class ASubband
	{
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float[] ScaleFactors;

		[Token(Token = "0x6000467")]
		public abstract void ReadBitAllocation(Bitstream stream, Header header, Crc16 crc);

		[Token(Token = "0x6000468")]
		public abstract void ReadScaleFactor(Bitstream stream, Header header);

		[Token(Token = "0x6000469")]
		public abstract bool ReadSampleData(Bitstream stream);

		[Token(Token = "0x600046A")]
		public abstract bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2);

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xB2146C", Offset = "0xB2146C", VA = "0xB2146C")]
		protected ASubband()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	internal interface IFrameDecoder
	{
		[Token(Token = "0x600046D")]
		void DecodeFrame();
	}
	[Token(Token = "0x20000A4")]
	internal class LayerIDecoder : IFrameDecoder
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected internal ABuffer buffer;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected internal Crc16 crc;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected internal SynthesisFilter filter1;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected internal SynthesisFilter filter2;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected internal Header header;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected internal int mode;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected internal int num_subbands;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected internal Bitstream stream;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected internal ASubband[] subbands;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected internal int which_channels;

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xB21514", Offset = "0xB21514", VA = "0xB21514")]
		public LayerIDecoder()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xB21588", Offset = "0xB21588", VA = "0xB21588", Slot = "5")]
		public virtual void DecodeFrame()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xB21680", Offset = "0xB21680", VA = "0xB21680", Slot = "6")]
		public virtual void Create(Bitstream stream0, Header header0, SynthesisFilter filtera, SynthesisFilter filterb, ABuffer buffer0, int whichCh0)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xB21708", Offset = "0xB21708", VA = "0xB21708", Slot = "7")]
		protected internal virtual void CreateSubbands()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xB219A4", Offset = "0xB219A4", VA = "0xB219A4", Slot = "8")]
		protected internal virtual void ReadAllocation()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xB21A1C", Offset = "0xB21A1C", VA = "0xB21A1C", Slot = "9")]
		protected internal virtual void ReadScaleFactorSelection()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xB21A20", Offset = "0xB21A20", VA = "0xB21A20", Slot = "10")]
		protected internal virtual void ReadScaleFactors()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xB21A94", Offset = "0xB21A94", VA = "0xB21A94", Slot = "11")]
		protected internal virtual void ReadSampleData()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	internal class LayerIIDecoder : LayerIDecoder, IFrameDecoder
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0xB21C14", Offset = "0xB21C14", VA = "0xB21C14", Slot = "7")]
		protected internal override void CreateSubbands()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xB21EB0", Offset = "0xB21EB0", VA = "0xB21EB0", Slot = "9")]
		protected internal override void ReadScaleFactorSelection()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xB21FA0", Offset = "0xB21FA0", VA = "0xB21FA0")]
		public LayerIIDecoder()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	internal sealed class LayerIIIDecoder : IFrameDecoder
	{
		[Token(Token = "0x400030C")]
		private const int SSLIMIT = 18;

		[Token(Token = "0x400030D")]
		private const int SBLIMIT = 32;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[][] slen;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int[] pretab;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly float[] two_to_negative_half_pow;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly float[] t_43;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly float[][] io;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly float[] TAN12;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static int[][] reorder_table;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly float[] cs;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly float[] ca;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly float[][] win;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int[][][] nr_of_sfb_block;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ABuffer buffer;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int channels;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly SynthesisFilter filter1;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly SynthesisFilter filter2;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly int first_channel;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Header header;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly ScaleFactorData[] III_scalefac_t;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly int[] is_1d;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly float[][] k;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly int last_channel;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly float[][][] lr;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly int max_gr;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly int[] nonzero;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly float[] out_1d;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly float[][] prevblck;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly float[][][] ro;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly ScaleFactorData[] scalefac;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly SBI[] sfBandIndex;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly int sfreq;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Layer3SideInfo m_SideInfo;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly Bitstream stream;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly int which_channels;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private BitReserve m_BitReserve;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int CheckSumHuff;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int counter;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int frame_start;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal int[] is_pos;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal float[] is_ratio;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] new_slen;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int part2_start;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal float[] rawout;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float[] samples1;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float[] samples2;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int[] scalefac_buffer;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScaleFactorTable sftable;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal float[] tsOutCopy;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal int[] v;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal int[] w;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal int[] x;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal int[] y;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xB21FA4", Offset = "0xB21FA4", VA = "0xB21FA4")]
		static LayerIIIDecoder()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xB22F18", Offset = "0xB22F18", VA = "0xB22F18")]
		public LayerIIIDecoder(Bitstream stream0, Header header0, SynthesisFilter filtera, SynthesisFilter filterb, ABuffer buffer0, int whichCh0)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xB24114", Offset = "0xB24114", VA = "0xB24114", Slot = "4")]
		public void DecodeFrame()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xB23F08", Offset = "0xB23F08", VA = "0xB23F08")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xB24594", Offset = "0xB24594", VA = "0xB24594")]
		public void seek_notify()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xB24118", Offset = "0xB24118", VA = "0xB24118")]
		public void Decode()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xB2465C", Offset = "0xB2465C", VA = "0xB2465C")]
		private bool ReadSideInfo()
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xB25858", Offset = "0xB25858", VA = "0xB25858")]
		private void ReadScaleFactors(int ch, int gr)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xB2A678", Offset = "0xB2A678", VA = "0xB2A678")]
		private void get_LSF_scale_data(int ch, int gr)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xB271BC", Offset = "0xB271BC", VA = "0xB271BC")]
		private void get_LSF_scale_factors(int ch, int gr)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xB274C4", Offset = "0xB274C4", VA = "0xB274C4")]
		private void HuffmanDecode(int ch, int gr)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xB2ADA8", Offset = "0xB2ADA8", VA = "0xB2ADA8")]
		private void i_stereo_k_values(int is_pos, int io_type, int i)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xB27B78", Offset = "0xB27B78", VA = "0xB27B78")]
		private void dequantize_sample(float[][] xr, int ch, int gr)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xB29A48", Offset = "0xB29A48", VA = "0xB29A48")]
		private void Reorder(float[][] xr, int ch, int gr)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xB284D0", Offset = "0xB284D0", VA = "0xB284D0")]
		private void stereo(int gr)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xB29EAC", Offset = "0xB29EAC", VA = "0xB29EAC")]
		private void Antialias(int ch, int gr)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xB2A0B8", Offset = "0xB2A0B8", VA = "0xB2A0B8")]
		private void Hybrid(int ch, int gr)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xB29920", Offset = "0xB29920", VA = "0xB29920")]
		private void doDownMix()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xB2AFD0", Offset = "0xB2AFD0", VA = "0xB2AFD0")]
		public void InverseMDCT(float[] inValues, float[] outValues, int blockType)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xB22E48", Offset = "0xB22E48", VA = "0xB22E48")]
		private static float[] create_t_43()
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xB24024", Offset = "0xB24024", VA = "0xB24024")]
		internal static int[] Reorder(int[] scalefac_band)
		{
			return null;
		}
	}
}
namespace MP3Sharp.Decoding.Decoders.LayerIII
{
	[Token(Token = "0x20000A7")]
	internal class ChannelData
	{
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GranuleInfo[] Granules;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] ScaleFactorBits;

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xB2BD3C", Offset = "0xB2BD3C", VA = "0xB2BD3C")]
		public ChannelData()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	internal class GranuleInfo
	{
		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int BigValues;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int BlockType;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Count1TableSelect;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int GlobalGain;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int MixedBlockFlag;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Part23Length;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int Preflag;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int Region0Count;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int Region1Count;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int ScaleFacCompress;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int ScaleFacScale;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int[] SubblockGain;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int[] TableSelect;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int WindowSwitchingFlag;

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xB2BE94", Offset = "0xB2BE94", VA = "0xB2BE94")]
		public GranuleInfo()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	internal class Layer3SideInfo
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ChannelData[] Channels;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MainDataBegin;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int PrivateBits;

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xB2BF14", Offset = "0xB2BF14", VA = "0xB2BF14")]
		public Layer3SideInfo()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	internal class SBI
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int[] l;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] s;

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xB2C03C", Offset = "0xB2C03C", VA = "0xB2C03C")]
		public SBI()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xB2C0BC", Offset = "0xB2C0BC", VA = "0xB2C0BC")]
		public SBI(int[] thel, int[] thes)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	internal class ScaleFactorData
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int[] l;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[][] s;

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xB2C100", Offset = "0xB2C100", VA = "0xB2C100")]
		public ScaleFactorData()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	internal class ScaleFactorTable
	{
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LayerIIIDecoder enclosingInstance;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] l;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] s;

		[Token(Token = "0x170000A9")]
		public LayerIIIDecoder Enclosing_Instance
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0xB2C31C", Offset = "0xB2C31C", VA = "0xB2C31C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xB2C220", Offset = "0xB2C220", VA = "0xB2C220")]
		public ScaleFactorTable(LayerIIIDecoder enclosingInstance)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xB2C2BC", Offset = "0xB2C2BC", VA = "0xB2C2BC")]
		public ScaleFactorTable(LayerIIIDecoder enclosingInstance, int[] thel, int[] thes)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xB2C324", Offset = "0xB2C324", VA = "0xB2C324")]
		private void InitBlock(LayerIIIDecoder enclosingInstance)
		{
		}
	}
}
namespace MP3Sharp.Decoding.Decoders.LayerII
{
	[Token(Token = "0x20000AD")]
	internal class SubbandLayer2 : ASubband
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float[] grouping_5bits;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly float[] grouping_7bits;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly float[] grouping_10bits;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int[] table_ab1_codelength;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly float[][] table_ab1_groupingtables;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly float[] table_ab1_factor;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly float[] table_ab1_c;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly float[] table_ab1_d;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly float[][] table_ab234_groupingtables;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int[] table_ab2_codelength;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly float[] table_ab2_factor;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly float[] table_ab2_c;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly float[] table_ab2_d;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly int[] table_ab3_codelength;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly float[] table_ab3_factor;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static readonly float[] table_ab3_c;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly float[] table_ab3_d;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static readonly int[] table_ab4_codelength;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static readonly float[] table_ab4_factor;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static readonly float[] table_ab4_c;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static readonly float[] table_ab4_d;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static readonly int[] table_cd_codelength;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static readonly float[][] table_cd_groupingtables;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static readonly float[] table_cd_factor;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static readonly float[] table_cd_c;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static readonly float[] table_cd_d;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected internal int allocation;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected internal float[] c;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected internal int[] codelength;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected internal float[] d;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected internal float[] factor;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected internal float[][] groupingtable;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected internal int groupnumber;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected internal int samplenumber;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected internal float[] samples;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected internal float scalefactor1;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected internal float scalefactor2;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected internal float scalefactor3;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected internal int scfsi;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected internal int subbandnumber;

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xB2C32C", Offset = "0xB2C32C", VA = "0xB2C32C")]
		public SubbandLayer2(int subbandnumber)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xB2C488", Offset = "0xB2C488", VA = "0xB2C488")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xB2C518", Offset = "0xB2C518", VA = "0xB2C518", Slot = "8")]
		protected internal virtual int get_allocationlength(Header header)
		{
			return default(int);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xB2C5A4", Offset = "0xB2C5A4", VA = "0xB2C5A4", Slot = "9")]
		protected internal virtual void prepare_sample_reading(Header header, int allocation, int channel, float[] factor, int[] codelength, float[] c, float[] d)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xB2CB44", Offset = "0xB2CB44", VA = "0xB2CB44", Slot = "4")]
		public override void ReadBitAllocation(Bitstream stream, Header header, Crc16 crc)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xB2CBC4", Offset = "0xB2CBC4", VA = "0xB2CBC4", Slot = "10")]
		public virtual void read_scalefactor_selection(Bitstream stream, Crc16 crc)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xB2CC24", Offset = "0xB2CC24", VA = "0xB2CC24", Slot = "5")]
		public override void ReadScaleFactor(Bitstream stream, Header header)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xB2CEC0", Offset = "0xB2CEC0", VA = "0xB2CEC0", Slot = "6")]
		public override bool ReadSampleData(Bitstream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xB2D0E4", Offset = "0xB2D0E4", VA = "0xB2D0E4", Slot = "7")]
		public override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000AE")]
	internal class SubbandLayer2IntensityStereo : SubbandLayer2
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected internal float channel2_scalefactor1;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected internal float channel2_scalefactor2;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected internal float channel2_scalefactor3;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected internal int channel2_scfsi;

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xB2DB38", Offset = "0xB2DB38", VA = "0xB2DB38")]
		public SubbandLayer2IntensityStereo(int subbandnumber)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xB2DB9C", Offset = "0xB2DB9C", VA = "0xB2DB9C", Slot = "4")]
		public override void ReadBitAllocation(Bitstream stream, Header header, Crc16 crc)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xB2DBA0", Offset = "0xB2DBA0", VA = "0xB2DBA0", Slot = "10")]
		public override void read_scalefactor_selection(Bitstream stream, Crc16 crc)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xB2DC2C", Offset = "0xB2DC2C", VA = "0xB2DC2C", Slot = "5")]
		public override void ReadScaleFactor(Bitstream stream, Header header)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xB2DEA8", Offset = "0xB2DEA8", VA = "0xB2DEA8", Slot = "6")]
		public override bool ReadSampleData(Bitstream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xB2DEAC", Offset = "0xB2DEAC", VA = "0xB2DEAC", Slot = "7")]
		public override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000AF")]
	internal class SubbandLayer2Stereo : SubbandLayer2
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected internal int channel2_allocation;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected internal float[] channel2_c;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected internal int[] channel2_codelength;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected internal float[] channel2_d;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected internal float[] channel2_factor;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected internal float[] channel2_samples;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected internal float channel2_scalefactor1;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		protected internal float channel2_scalefactor2;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected internal float channel2_scalefactor3;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		protected internal int channel2_scfsi;

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xB2E0C4", Offset = "0xB2E0C4", VA = "0xB2E0C4")]
		public SubbandLayer2Stereo(int subbandnumber)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xB2E1E4", Offset = "0xB2E1E4", VA = "0xB2E1E4", Slot = "4")]
		public override void ReadBitAllocation(Bitstream stream, Header header, Crc16 crc)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xB2E28C", Offset = "0xB2E28C", VA = "0xB2E28C", Slot = "10")]
		public override void read_scalefactor_selection(Bitstream stream, Crc16 crc)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xB2E328", Offset = "0xB2E328", VA = "0xB2E328", Slot = "5")]
		public override void ReadScaleFactor(Bitstream stream, Header header)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xB2E5D4", Offset = "0xB2E5D4", VA = "0xB2E5D4", Slot = "6")]
		public override bool ReadSampleData(Bitstream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xB2E804", Offset = "0xB2E804", VA = "0xB2E804", Slot = "7")]
		public override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2)
		{
			return default(bool);
		}
	}
}
namespace MP3Sharp.Decoding.Decoders.LayerI
{
	[Token(Token = "0x20000B0")]
	internal class SubbandLayer1 : ASubband
	{
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float[] TableFactor;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly float[] TableOffset;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected int allocation;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected float factor;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected float offset;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected float sample;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected int samplelength;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		protected int samplenumber;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float scalefactor;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		protected int subbandnumber;

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xB2E9AC", Offset = "0xB2E9AC", VA = "0xB2E9AC")]
		public SubbandLayer1(int subbandnumber)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xB2EA1C", Offset = "0xB2EA1C", VA = "0xB2EA1C", Slot = "4")]
		public override void ReadBitAllocation(Bitstream stream, Header header, Crc16 crc)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xB2EB14", Offset = "0xB2EB14", VA = "0xB2EB14", Slot = "5")]
		public override void ReadScaleFactor(Bitstream stream, Header header)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xB2EBB4", Offset = "0xB2EBB4", VA = "0xB2EBB4", Slot = "6")]
		public override bool ReadSampleData(Bitstream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xB2EC08", Offset = "0xB2EC08", VA = "0xB2EC08", Slot = "7")]
		public override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B1")]
	internal class SubbandLayer1IntensityStereo : SubbandLayer1
	{
		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected internal float channel2_scalefactor;

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xB2ED9C", Offset = "0xB2ED9C", VA = "0xB2ED9C")]
		public SubbandLayer1IntensityStereo(int subbandnumber)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xB2EE00", Offset = "0xB2EE00", VA = "0xB2EE00", Slot = "4")]
		public override void ReadBitAllocation(Bitstream stream, Header header, Crc16 crc)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xB2EE04", Offset = "0xB2EE04", VA = "0xB2EE04", Slot = "5")]
		public override void ReadScaleFactor(Bitstream stream, Header header)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xB2EEE4", Offset = "0xB2EEE4", VA = "0xB2EEE4", Slot = "6")]
		public override bool ReadSampleData(Bitstream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xB2EEE8", Offset = "0xB2EEE8", VA = "0xB2EEE8", Slot = "7")]
		public override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B2")]
	internal class SubbandLayer1Stereo : SubbandLayer1
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected internal int channel2_allocation;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected internal float channel2_factor;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected internal float channel2_offset;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected internal float channel2_sample;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected internal int channel2_samplelength;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected internal float channel2_scalefactor;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xB2F010", Offset = "0xB2F010", VA = "0xB2F010")]
		public SubbandLayer1Stereo(int subbandnumber)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xB2F074", Offset = "0xB2F074", VA = "0xB2F074", Slot = "4")]
		public override void ReadBitAllocation(Bitstream stream, Header header, Crc16 crc)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xB2F204", Offset = "0xB2F204", VA = "0xB2F204", Slot = "5")]
		public override void ReadScaleFactor(Bitstream stream, Header header)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xB2F300", Offset = "0xB2F300", VA = "0xB2F300", Slot = "6")]
		public override bool ReadSampleData(Bitstream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xB2F360", Offset = "0xB2F360", VA = "0xB2F360", Slot = "7")]
		public override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2)
		{
			return default(bool);
		}
	}
}
