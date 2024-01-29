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
		[Address(RVA = "0xB88664", Offset = "0xB88664", VA = "0xB88664")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xB8866C", Offset = "0xB8866C", VA = "0xB8866C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public bool close
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0xB887CC", Offset = "0xB887CC", VA = "0xB887CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0xB887D4", Offset = "0xB887D4", VA = "0xB887D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public BezierPoint this[int index]
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0xB8880C", Offset = "0xB8880C", VA = "0xB8880C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public int pointCount
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0xB8883C", Offset = "0xB8883C", VA = "0xB8883C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000005")]
	public float length
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xB88858", Offset = "0xB88858", VA = "0xB88858")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x14000001")]
	public event Action onUpdated
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xB88694", Offset = "0xB88694", VA = "0xB88694")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xB88730", Offset = "0xB88730", VA = "0xB88730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xB88A60", Offset = "0xB88A60", VA = "0xB88A60")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xB88C1C", Offset = "0xB88C1C", VA = "0xB88C1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xB88C40", Offset = "0xB88C40", VA = "0xB88C40")]
	public void AddPoint(BezierPoint point)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xB88DA4", Offset = "0xB88DA4", VA = "0xB88DA4")]
	public BezierPoint AddPointAt(Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xB88F9C", Offset = "0xB88F9C", VA = "0xB88F9C")]
	public void RemovePoint(BezierPoint point)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xB89084", Offset = "0xB89084", VA = "0xB89084")]
	public BezierPoint[] GetAnchorPoints()
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xB890FC", Offset = "0xB890FC", VA = "0xB890FC")]
	public Vector3 GetPointAt(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xB89438", Offset = "0xB89438", VA = "0xB89438")]
	public int GetPointIndex(BezierPoint point)
	{
		return default(int);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xB894EC", Offset = "0xB894EC", VA = "0xB894EC")]
	public void SetDirty()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xB88B38", Offset = "0xB88B38", VA = "0xB88B38")]
	public static void DrawCurve(BezierPoint p1, BezierPoint p2, int resolution)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xB8931C", Offset = "0xB8931C", VA = "0xB8931C")]
	public static Vector3 GetPoint(BezierPoint p1, BezierPoint p2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xB89510", Offset = "0xB89510", VA = "0xB89510")]
	public static Vector3 GetCubicCurvePoint(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xB895C4", Offset = "0xB895C4", VA = "0xB895C4")]
	public static Vector3 GetQuadraticCurvePoint(Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xB89644", Offset = "0xB89644", VA = "0xB89644")]
	public static Vector3 GetLinearPoint(Vector3 p1, Vector3 p2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xB8966C", Offset = "0xB8966C", VA = "0xB8966C")]
	public static Vector3 GetPoint(float t, params Vector3[] points)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xB8893C", Offset = "0xB8893C", VA = "0xB8893C")]
	public static float ApproximateLength(BezierPoint p1, BezierPoint p2, int resolution = 10)
	{
		return default(float);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xB897E0", Offset = "0xB897E0", VA = "0xB897E0")]
	private static int BinomialCoefficient(int i, int n)
	{
		return default(int);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xB89874", Offset = "0xB89874", VA = "0xB89874")]
	private static int Factoral(int i)
	{
		return default(int);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xB898A4", Offset = "0xB898A4", VA = "0xB898A4")]
	public void updateNow()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xB899A4", Offset = "0xB899A4", VA = "0xB899A4")]
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
		[Address(RVA = "0xB89A18", Offset = "0xB89A18", VA = "0xB89A18")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0xB88EF8", Offset = "0xB88EF8", VA = "0xB88EF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public Vector3 position
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0xB89A20", Offset = "0xB89A20", VA = "0xB89A20")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0xB89ACC", Offset = "0xB89ACC", VA = "0xB89ACC")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public Vector3 handle1
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0xB89AE8", Offset = "0xB89AE8", VA = "0xB89AE8")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public Vector3 globalHandle1
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0xB89C20", Offset = "0xB89C20", VA = "0xB89C20")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000024")]
		[Address(RVA = "0xB89C54", Offset = "0xB89C54", VA = "0xB89C54")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Vector3 handle2
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0xB89C7C", Offset = "0xB89C7C", VA = "0xB89C7C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public Vector3 globalHandle2
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0xB89DB4", Offset = "0xB89DB4", VA = "0xB89DB4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0xB89DE8", Offset = "0xB89DE8", VA = "0xB89DE8")]
		set
		{
		}
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xB8990C", Offset = "0xB8990C", VA = "0xB8990C")]
	public void updateNow()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xB89E10", Offset = "0xB89E10", VA = "0xB89E10")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xB89E9C", Offset = "0xB89E9C", VA = "0xB89E9C")]
	private void Update()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xB89EE4", Offset = "0xB89EE4", VA = "0xB89EE4")]
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
	[Address(RVA = "0xB89EEC", Offset = "0xB89EEC", VA = "0xB89EEC")]
	private void Start()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xB89EF0", Offset = "0xB89EF0", VA = "0xB89EF0")]
	private void Update()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xB89F9C", Offset = "0xB89F9C", VA = "0xB89F9C")]
	public void CheckPerm()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xB8A008", Offset = "0xB8A008", VA = "0xB8A008")]
	public void GrantPerm()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xB8A0BC", Offset = "0xB8A0BC", VA = "0xB8A0BC")]
	public void PermissionGrantedCallback(bool isGranted)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xB8A0C8", Offset = "0xB8A0C8", VA = "0xB8A0C8")]
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
			[Address(RVA = "0xB8A5AC", Offset = "0xB8A5AC", VA = "0xB8A5AC", Slot = "4")]
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
			[Address(RVA = "0xB8A5F4", Offset = "0xB8A5F4", VA = "0xB8A5F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xB8A1CC", Offset = "0xB8A1CC", VA = "0xB8A1CC")]
		[DebuggerHidden]
		public <CancelWith>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xB8A3A8", Offset = "0xB8A3A8", VA = "0xB8A3A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xB8A3AC", Offset = "0xB8A3AC", VA = "0xB8A3AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xB8A5B4", Offset = "0xB8A5B4", VA = "0xB8A5B4", Slot = "8")]
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
			[Address(RVA = "0xB8A88C", Offset = "0xB8A88C", VA = "0xB8A88C", Slot = "4")]
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
			[Address(RVA = "0xB8A8D4", Offset = "0xB8A8D4", VA = "0xB8A8D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xB8A298", Offset = "0xB8A298", VA = "0xB8A298")]
		[DebuggerHidden]
		public <CancelWith>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xB8A650", Offset = "0xB8A650", VA = "0xB8A650", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xB8A654", Offset = "0xB8A654", VA = "0xB8A654", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xB8A894", Offset = "0xB8A894", VA = "0xB8A894", Slot = "8")]
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
			[Address(RVA = "0xB8ABA4", Offset = "0xB8ABA4", VA = "0xB8ABA4", Slot = "4")]
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
			[Address(RVA = "0xB8ABEC", Offset = "0xB8ABEC", VA = "0xB8ABEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xB8A380", Offset = "0xB8A380", VA = "0xB8A380")]
		[DebuggerHidden]
		public <CancelWith>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xB8A930", Offset = "0xB8A930", VA = "0xB8A930", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xB8A934", Offset = "0xB8A934", VA = "0xB8A934", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xB8ABAC", Offset = "0xB8ABAC", VA = "0xB8ABAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xB8A13C", Offset = "0xB8A13C", VA = "0xB8A13C")]
	[IteratorStateMachine(typeof(<CancelWith>d__0))]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xB8A1F4", Offset = "0xB8A1F4", VA = "0xB8A1F4")]
	[IteratorStateMachine(typeof(<CancelWith>d__1))]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xB8A2C0", Offset = "0xB8A2C0", VA = "0xB8A2C0")]
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
			[Address(RVA = "0xB95130", Offset = "0xB95130", VA = "0xB95130", Slot = "4")]
			public bool Equals(ProcessIndex other)
			{
				return default(bool);
			}

			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xB95158", Offset = "0xB95158", VA = "0xB95158", Slot = "0")]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xB951E0", Offset = "0xB951E0", VA = "0xB951E0")]
			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xB95200", Offset = "0xB95200", VA = "0xB95200")]
			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xB95220", Offset = "0xB95220", VA = "0xB95220", Slot = "2")]
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
				[Address(RVA = "0xB95380", Offset = "0xB95380", VA = "0xB95380", Slot = "4")]
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
				[Address(RVA = "0xB953C8", Offset = "0xB953C8", VA = "0xB953C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xB93128", Offset = "0xB93128", VA = "0xB93128")]
			[DebuggerHidden]
			public <_InjectDelay>d__124(int <>1__state)
			{
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xB95240", Offset = "0xB95240", VA = "0xB95240", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xB95244", Offset = "0xB95244", VA = "0xB95244", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xB95388", Offset = "0xB95388", VA = "0xB95388", Slot = "8")]
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
				[Address(RVA = "0xB957C8", Offset = "0xB957C8", VA = "0xB957C8", Slot = "4")]
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
				[Address(RVA = "0xB95810", Offset = "0xB95810", VA = "0xB95810", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xB93C68", Offset = "0xB93C68", VA = "0xB93C68")]
			[DebuggerHidden]
			public <_StartWhenDone>d__132(int <>1__state)
			{
			}

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xB95424", Offset = "0xB95424", VA = "0xB95424", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xB95450", Offset = "0xB95450", VA = "0xB95450", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xB957A0", Offset = "0xB957A0", VA = "0xB957A0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xB957D0", Offset = "0xB957D0", VA = "0xB957D0", Slot = "8")]
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
				[Address(RVA = "0xB959A8", Offset = "0xB959A8", VA = "0xB959A8", Slot = "4")]
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
				[Address(RVA = "0xB959F0", Offset = "0xB959F0", VA = "0xB959F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xB9401C", Offset = "0xB9401C", VA = "0xB9401C")]
			[DebuggerHidden]
			public <_StartWhenDone>d__138(int <>1__state)
			{
			}

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xB9586C", Offset = "0xB9586C", VA = "0xB9586C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xB95870", Offset = "0xB95870", VA = "0xB95870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xB959B0", Offset = "0xB959B0", VA = "0xB959B0", Slot = "8")]
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
				[Address(RVA = "0xB95B8C", Offset = "0xB95B8C", VA = "0xB95B8C", Slot = "4")]
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
				[Address(RVA = "0xB95BD4", Offset = "0xB95BD4", VA = "0xB95BD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xB9427C", Offset = "0xB9427C", VA = "0xB9427C")]
			[DebuggerHidden]
			public <_StartWhenDone>d__140(int <>1__state)
			{
			}

			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xB95A4C", Offset = "0xB95A4C", VA = "0xB95A4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xB95A50", Offset = "0xB95A50", VA = "0xB95A50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xB95B94", Offset = "0xB95B94", VA = "0xB95B94", Slot = "8")]
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
				[Address(RVA = "0xB95D00", Offset = "0xB95D00", VA = "0xB95D00", Slot = "4")]
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
				[Address(RVA = "0xB95D48", Offset = "0xB95D48", VA = "0xB95D48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xB9482C", Offset = "0xB9482C", VA = "0xB9482C")]
			[DebuggerHidden]
			public <_DelayedCall>d__147(int <>1__state)
			{
			}

			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xB95C30", Offset = "0xB95C30", VA = "0xB95C30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xB95C34", Offset = "0xB95C34", VA = "0xB95C34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xB95D08", Offset = "0xB95D08", VA = "0xB95D08", Slot = "8")]
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
				[Address(RVA = "0xB95E70", Offset = "0xB95E70", VA = "0xB95E70", Slot = "4")]
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
				[Address(RVA = "0xB95EB8", Offset = "0xB95EB8", VA = "0xB95EB8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xB94C88", Offset = "0xB94C88", VA = "0xB94C88")]
			[DebuggerHidden]
			public <_CallContinuously>d__156(int <>1__state)
			{
			}

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xB95DA4", Offset = "0xB95DA4", VA = "0xB95DA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xB95DA8", Offset = "0xB95DA8", VA = "0xB95DA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xB95E78", Offset = "0xB95E78", VA = "0xB95E78", Slot = "8")]
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
			[Address(RVA = "0xB8AC48", Offset = "0xB8AC48", VA = "0xB8AC48")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000013")]
		public static float DeltaTime
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xB8AEDC", Offset = "0xB8AEDC", VA = "0xB8AEDC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000014")]
		public static Thread MainThread
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0xB8B0F0", Offset = "0xB8B0F0", VA = "0xB8B0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0xB8B148", Offset = "0xB8B148", VA = "0xB8B148")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public static CoroutineHandle CurrentCoroutine
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0xB8B1A8", Offset = "0xB8B1A8", VA = "0xB8B1A8")]
			get
			{
				return default(CoroutineHandle);
			}
		}

		[Token(Token = "0x17000016")]
		public CoroutineHandle currentCoroutine
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0xB8B2FC", Offset = "0xB8B2FC", VA = "0xB8B2FC")]
			get
			{
				return default(CoroutineHandle);
			}
		}

		[Token(Token = "0x17000017")]
		public static Timing Instance
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0xB8ACA4", Offset = "0xB8ACA4", VA = "0xB8ACA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0xB8B544", Offset = "0xB8B544", VA = "0xB8B544")]
			set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event Action OnPreExecute
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xB8AF38", Offset = "0xB8AF38", VA = "0xB8AF38")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xB8B014", Offset = "0xB8B014", VA = "0xB8B014")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xB8B5A4", Offset = "0xB8B5A4", VA = "0xB8B5A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xB8B744", Offset = "0xB8B744", VA = "0xB8B744")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xB8B808", Offset = "0xB8B808", VA = "0xB8B808")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xB8B8CC", Offset = "0xB8B8CC", VA = "0xB8B8CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xB8B8D0", Offset = "0xB8B8D0", VA = "0xB8B8D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xB8B304", Offset = "0xB8B304", VA = "0xB8B304")]
		private void InitializeInstanceID()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xB8B98C", Offset = "0xB8B98C", VA = "0xB8B98C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xB8D86C", Offset = "0xB8D86C", VA = "0xB8D86C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xB8DF80", Offset = "0xB8DF80", VA = "0xB8DF80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xB8C970", Offset = "0xB8C970", VA = "0xB8C970")]
		private void RemoveUnused()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xB8EA8C", Offset = "0xB8EA8C", VA = "0xB8EA8C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xB90264", Offset = "0xB90264", VA = "0xB90264")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xB90314", Offset = "0xB90314", VA = "0xB90314")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xB903C4", Offset = "0xB903C4", VA = "0xB903C4")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xB90478", Offset = "0xB90478", VA = "0xB90478")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xB904D0", Offset = "0xB904D0", VA = "0xB904D0")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xB90534", Offset = "0xB90534", VA = "0xB90534")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xB90598", Offset = "0xB90598", VA = "0xB90598")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xB8EBE0", Offset = "0xB8EBE0", VA = "0xB8EBE0")]
		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, string tag, CoroutineHandle handle, bool prewarm)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xB90770", Offset = "0xB90770", VA = "0xB90770")]
		public static int KillCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xB90838", Offset = "0xB90838", VA = "0xB90838")]
		public int KillCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xB90AEC", Offset = "0xB90AEC", VA = "0xB90AEC")]
		public static int KillCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xB8C880", Offset = "0xB8C880", VA = "0xB8C880")]
		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xB90D10", Offset = "0xB90D10", VA = "0xB90D10")]
		public static int KillCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xB90DE0", Offset = "0xB90DE0", VA = "0xB90DE0")]
		public int KillCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xB910BC", Offset = "0xB910BC", VA = "0xB910BC")]
		public static int PauseCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xB91184", Offset = "0xB91184", VA = "0xB91184")]
		public int PauseCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xB91A14", Offset = "0xB91A14", VA = "0xB91A14")]
		public static int PauseCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xB91B08", Offset = "0xB91B08", VA = "0xB91B08")]
		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xB921D4", Offset = "0xB921D4", VA = "0xB921D4")]
		public static int PauseCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xB922A4", Offset = "0xB922A4", VA = "0xB922A4")]
		public int PauseCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xB92424", Offset = "0xB92424", VA = "0xB92424")]
		public static int ResumeCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xB924EC", Offset = "0xB924EC", VA = "0xB924EC")]
		public int ResumeCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xB926A0", Offset = "0xB926A0", VA = "0xB926A0")]
		public static int ResumeCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xB92794", Offset = "0xB92794", VA = "0xB92794")]
		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xB92860", Offset = "0xB92860", VA = "0xB92860")]
		public static int ResumeCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xB92930", Offset = "0xB92930", VA = "0xB92930")]
		public int ResumeCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xB8C6F0", Offset = "0xB8C6F0", VA = "0xB8C6F0")]
		private bool UpdateTimeValues(Segment segment)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xB918C4", Offset = "0xB918C4", VA = "0xB918C4")]
		private float GetSegmentTime(Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xB90BEC", Offset = "0xB90BEC", VA = "0xB90BEC")]
		public static Timing GetInstance(byte ID)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xB90600", Offset = "0xB90600", VA = "0xB90600")]
		private void AddTag(string tag, CoroutineHandle coindex)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xB8E8F8", Offset = "0xB8E8F8", VA = "0xB8E8F8")]
		private void RemoveTag(CoroutineHandle coindex)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xB91024", Offset = "0xB91024", VA = "0xB91024")]
		private bool Nullify(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xB90C7C", Offset = "0xB90C7C", VA = "0xB90C7C")]
		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xB92AAC", Offset = "0xB92AAC", VA = "0xB92AAC")]
		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xB8E690", Offset = "0xB8E690", VA = "0xB8E690")]
		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xB91BD8", Offset = "0xB91BD8", VA = "0xB91BD8")]
		private bool SetPause(ProcessIndex coindex, bool newPausedState)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xB92B2C", Offset = "0xB92B2C", VA = "0xB92B2C")]
		private bool SetHeld(ProcessIndex coindex, bool newHeldState)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xB91974", Offset = "0xB91974", VA = "0xB91974")]
		[IteratorStateMachine(typeof(<_InjectDelay>d__124))]
		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float delayTime)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xB93150", Offset = "0xB93150", VA = "0xB93150")]
		private bool CoindexIsPaused(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xB931DC", Offset = "0xB931DC", VA = "0xB931DC")]
		private bool CoindexIsHeld(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xB93268", Offset = "0xB93268", VA = "0xB93268")]
		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xB93328", Offset = "0xB93328", VA = "0xB93328")]
		public static float WaitForSeconds(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xB933D0", Offset = "0xB933D0", VA = "0xB933D0")]
		public float WaitForSecondsOnInstance(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xB9344C", Offset = "0xB9344C", VA = "0xB9344C")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xB934A4", Offset = "0xB934A4", VA = "0xB934A4")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			return default(float);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xB937C8", Offset = "0xB937C8", VA = "0xB937C8")]
		[IteratorStateMachine(typeof(<_StartWhenDone>d__132))]
		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xB9386C", Offset = "0xB9386C", VA = "0xB9386C")]
		private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xB8E71C", Offset = "0xB8E71C", VA = "0xB8E71C")]
		private void CloseWaitingProcess(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xB93C90", Offset = "0xB93C90", VA = "0xB93C90")]
		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xB93D78", Offset = "0xB93D78", VA = "0xB93D78")]
		private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xB93DE8", Offset = "0xB93DE8", VA = "0xB93DE8")]
		public static float WaitUntilDone(AsyncOperation operation)
		{
			return default(float);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xB93F8C", Offset = "0xB93F8C", VA = "0xB93F8C")]
		[IteratorStateMachine(typeof(<_StartWhenDone>d__138))]
		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xB94044", Offset = "0xB94044", VA = "0xB94044")]
		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			return default(float);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xB941EC", Offset = "0xB941EC", VA = "0xB941EC")]
		[IteratorStateMachine(typeof(<_StartWhenDone>d__140))]
		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xB942A4", Offset = "0xB942A4", VA = "0xB942A4")]
		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xB94478", Offset = "0xB94478", VA = "0xB94478")]
		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xB945F8", Offset = "0xB945F8", VA = "0xB945F8")]
		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xB94738", Offset = "0xB94738", VA = "0xB94738")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xB9476C", Offset = "0xB9476C", VA = "0xB9476C")]
		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject cancelWith)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xB947FC", Offset = "0xB947FC", VA = "0xB947FC")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject cancelWith)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xB94684", Offset = "0xB94684", VA = "0xB94684")]
		[IteratorStateMachine(typeof(<_DelayedCall>d__147))]
		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xB94854", Offset = "0xB94854", VA = "0xB94854")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xB949AC", Offset = "0xB949AC", VA = "0xB949AC")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xB949E0", Offset = "0xB949E0", VA = "0xB949E0")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment segment, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xB94A88", Offset = "0xB94A88", VA = "0xB94A88")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment segment, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xB94ACC", Offset = "0xB94ACC", VA = "0xB94ACC")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xB94B64", Offset = "0xB94B64", VA = "0xB94B64")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xB94B9C", Offset = "0xB94B9C", VA = "0xB94B9C")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xB94C40", Offset = "0xB94C40", VA = "0xB94C40")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xB948F0", Offset = "0xB948F0", VA = "0xB948F0")]
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
		[Address(RVA = "0xB94CB0", Offset = "0xB94CB0", VA = "0xB94CB0")]
		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xB94CB8", Offset = "0xB94CB8", VA = "0xB94CB8")]
		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xB94CC0", Offset = "0xB94CC0", VA = "0xB94CC0")]
		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xB94CC8", Offset = "0xB94CC8", VA = "0xB94CC8")]
		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xB94CD0", Offset = "0xB94CD0", VA = "0xB94CD0")]
		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopCoroutine(string methodName)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xB94CD4", Offset = "0xB94CD4", VA = "0xB94CD4")]
		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xB94CD8", Offset = "0xB94CD8", VA = "0xB94CD8")]
		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xB94CDC", Offset = "0xB94CDC", VA = "0xB94CDC")]
		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopAllCoroutines()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xB94CE0", Offset = "0xB94CE0", VA = "0xB94CE0")]
		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xB94CE4", Offset = "0xB94CE4", VA = "0xB94CE4")]
		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xB94CE8", Offset = "0xB94CE8", VA = "0xB94CE8")]
		[Obsolete("Use your own GameObject for this.", true)]
		public static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xB94CEC", Offset = "0xB94CEC", VA = "0xB94CEC")]
		[Obsolete("Use your own GameObject for this.", true)]
		public static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xB94CF0", Offset = "0xB94CF0", VA = "0xB94CF0")]
		[Obsolete("Use your own GameObject for this.", true)]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xB94CF4", Offset = "0xB94CF4", VA = "0xB94CF4")]
		[Obsolete("Use your own GameObject for this.", true)]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xB94CF8", Offset = "0xB94CF8", VA = "0xB94CF8")]
		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Instantiate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xB94CFC", Offset = "0xB94CFC", VA = "0xB94CFC")]
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
		[Address(RVA = "0xB94D00", Offset = "0xB94D00", VA = "0xB94D00")]
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
		[Address(RVA = "0xB94D08", Offset = "0xB94D08", VA = "0xB94D08")]
		[Obsolete("Just.. no.", true)]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xB94D10", Offset = "0xB94D10", VA = "0xB94D10")]
		[Obsolete("Just.. no.", true)]
		public new static void print(object message)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xB94D14", Offset = "0xB94D14", VA = "0xB94D14")]
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
			[Address(RVA = "0xB90BE0", Offset = "0xB90BE0", VA = "0xB90BE0")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000027")]
		public bool IsValid
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xB8B2EC", Offset = "0xB8B2EC", VA = "0xB8B2EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xB8EB30", Offset = "0xB8EB30", VA = "0xB8EB30")]
		public CoroutineHandle(byte ind)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xB95F14", Offset = "0xB95F14", VA = "0xB95F14", Slot = "4")]
		public bool Equals(CoroutineHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xB95F24", Offset = "0xB95F24", VA = "0xB95F24", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xB93860", Offset = "0xB93860", VA = "0xB93860")]
		public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xB95F9C", Offset = "0xB95F9C", VA = "0xB95F9C")]
		public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xB95FA8", Offset = "0xB95FA8", VA = "0xB95FA8", Slot = "2")]
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
		[Address(RVA = "0xB96040", Offset = "0xB96040", VA = "0xB96040")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xB960D0", Offset = "0xB960D0", VA = "0xB960D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xB960D4", Offset = "0xB960D4", VA = "0xB960D4")]
		public void Init()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xB9613C", Offset = "0xB9613C", VA = "0xB9613C")]
		public void GetNumSets(Action<bool, int> onResponse)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xB96524", Offset = "0xB96524", VA = "0xB96524")]
		public void GetSetMeta(int setNum, Action<bool, CustomSet> onResponse)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xB966C0", Offset = "0xB966C0", VA = "0xB966C0")]
		public void DownloadSetContent(string setContentUrl, string setContentMD5, string password, Action<bool, DownloadedCrate> onResponse)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xB96810", Offset = "0xB96810", VA = "0xB96810")]
		public void UploadNewSet(byte[] content, Action<bool, CustomSet> onResponse)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xB96A80", Offset = "0xB96A80", VA = "0xB96A80")]
		public void UploadExistingSet(int setNum, byte[] content, Action<bool, CustomSet> onResponse)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xB96D10", Offset = "0xB96D10", VA = "0xB96D10")]
		private void _UploadContentToS3(int setNum, int version, string authorRnxId, byte[] content, string contentMD5, string uploadUrl, Action<bool, CustomSet> onResponse)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xB96FA0", Offset = "0xB96FA0", VA = "0xB96FA0")]
		public void VoteSetForMC(int setNum, bool vote, Action<bool, bool> onResponse)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xB971C0", Offset = "0xB971C0", VA = "0xB971C0")]
		public void GetMySetVoteForMC(int setNum, Action<bool, bool> onResponse)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xB973B0", Offset = "0xB973B0", VA = "0xB973B0")]
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
		[Address(RVA = "0xB98064", Offset = "0xB98064", VA = "0xB98064")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xB98100", Offset = "0xB98100", VA = "0xB98100")]
		private void Start()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xB98104", Offset = "0xB98104", VA = "0xB98104")]
		public void Init()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xB9816C", Offset = "0xB9816C", VA = "0xB9816C")]
		public void FindOrCreateLeaderboard(Type type, string leaderboardName, LeaderboardSortMethod sortOrder, Action<bool> onResponse)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xB983AC", Offset = "0xB983AC", VA = "0xB983AC")]
		public void UpdateUserEntry(Type type, string leaderboardName, int value, LeaderboardEntryData entryData, string rnxId, string rnxId2, LeaderboardUpdateMethod updateMethod, Action<bool, LeaderboardEntry, LeaderboardEntry> onResponse)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xB98600", Offset = "0xB98600", VA = "0xB98600")]
		public void GetEntries(Type type, string leaderboardName, string rnxId, string rnxId2, int start, int count, Action<bool, List<LeaderboardEntry>> onResponse)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xB98824", Offset = "0xB98824", VA = "0xB98824")]
		private static string min(string rnxId1, string rnxId2)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xB98874", Offset = "0xB98874", VA = "0xB98874")]
		private static string max(string rnxId1, string rnxId2)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xB988A0", Offset = "0xB988A0", VA = "0xB988A0")]
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
		[Address(RVA = "0xB994D8", Offset = "0xB994D8", VA = "0xB994D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xB99538", Offset = "0xB99538", VA = "0xB99538")]
		private void LeaderboardFlowTest()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xB9969C", Offset = "0xB9969C", VA = "0xB9969C")]
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
		[Address(RVA = "0xB976DC", Offset = "0xB976DC", VA = "0xB976DC")]
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
			[Address(RVA = "0xB99C68", Offset = "0xB99C68", VA = "0xB99C68")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		public bool hasUser2
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0xB99C74", Offset = "0xB99C74", VA = "0xB99C74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xB98D54", Offset = "0xB98D54", VA = "0xB98D54")]
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
		[Address(RVA = "0xB98D5C", Offset = "0xB98D5C", VA = "0xB98D5C")]
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
		[Address(RVA = "0xB9833C", Offset = "0xB9833C", VA = "0xB9833C")]
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
		ChinaMobile
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
		[Address(RVA = "0xB99C94", Offset = "0xB99C94", VA = "0xB99C94")]
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
			[Address(RVA = "0xB99D94", Offset = "0xB99D94", VA = "0xB99D94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public bool playingRacket
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xB99EFC", Offset = "0xB99EFC", VA = "0xB99EFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xB99F0C", Offset = "0xB99F0C", VA = "0xB99F0C")]
		public User()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xB99F14", Offset = "0xB99F14", VA = "0xB99F14")]
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
		[Address(RVA = "0xB99FBC", Offset = "0xB99FBC", VA = "0xB99FBC", Slot = "6")]
		public virtual string GetBodyParams()
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xB99FFC", Offset = "0xB99FFC", VA = "0xB99FFC", Slot = "7")]
		public virtual Dictionary<string, string> GetQueryParams()
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xB9A06C", Offset = "0xB9A06C", VA = "0xB9A06C")]
		protected Dictionary<string, string> ArrayToDictionary(string key, string[] array)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xB9A1BC", Offset = "0xB9A1BC", VA = "0xB9A1BC")]
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
		[Address(RVA = "0xB9669C", Offset = "0xB9669C", VA = "0xB9669C")]
		public CustomSetsGetSetRequest(int setNum)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xB9A230", Offset = "0xB9A230", VA = "0xB9A230", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xB9A2B4", Offset = "0xB9A2B4", VA = "0xB9A2B4", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}
	}
	[Token(Token = "0x2000035")]
	public class CustomSetsGetSetsRequest : BaseRequest
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xB9A2BC", Offset = "0xB9A2BC", VA = "0xB9A2BC", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xB9A2FC", Offset = "0xB9A2FC", VA = "0xB9A2FC", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xB962A4", Offset = "0xB962A4", VA = "0xB962A4")]
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
		[Address(RVA = "0xB9737C", Offset = "0xB9737C", VA = "0xB9737C")]
		public CustomSetsGetVoteForMCRequest(int setNum, string voterRnxId)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xB9A304", Offset = "0xB9A304", VA = "0xB9A304", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xB9A388", Offset = "0xB9A388", VA = "0xB9A388", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xB9A390", Offset = "0xB9A390", VA = "0xB9A390", Slot = "7")]
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
		[Address(RVA = "0xB96CC0", Offset = "0xB96CC0", VA = "0xB96CC0")]
		public CustomSetsUploadExistingRequest(int setNum, string rnxId, string setContentMD5)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xB9A448", Offset = "0xB9A448", VA = "0xB9A448", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xB9A4CC", Offset = "0xB9A4CC", VA = "0xB9A4CC", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xB9A4D4", Offset = "0xB9A4D4", VA = "0xB9A4D4", Slot = "6")]
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
		[Address(RVA = "0xB96A40", Offset = "0xB96A40", VA = "0xB96A40")]
		public CustomSetsUploadNewRequest(string rnxId, string setContentMD5)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xB9A4DC", Offset = "0xB9A4DC", VA = "0xB9A4DC", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xB9A51C", Offset = "0xB9A51C", VA = "0xB9A51C", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xB9A524", Offset = "0xB9A524", VA = "0xB9A524", Slot = "6")]
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
		[Address(RVA = "0xB97178", Offset = "0xB97178", VA = "0xB97178")]
		public CustomSetsVoteForMCRequest(int setNum, string voterRnxId, bool vote)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xB9A52C", Offset = "0xB9A52C", VA = "0xB9A52C", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xB9A5B0", Offset = "0xB9A5B0", VA = "0xB9A5B0", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xB9A5B8", Offset = "0xB9A5B8", VA = "0xB9A5B8", Slot = "6")]
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
		[Address(RVA = "0xB9A5C0", Offset = "0xB9A5C0", VA = "0xB9A5C0")]
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
		[Address(RVA = "0xB98318", Offset = "0xB98318", VA = "0xB98318")]
		public LeaderboardCreateRequest(Leaderboard.Type leaderboardType)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xB9A5E4", Offset = "0xB9A5E4", VA = "0xB9A5E4", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xB9A6D8", Offset = "0xB9A6D8", VA = "0xB9A6D8", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xB9A6E0", Offset = "0xB9A6E0", VA = "0xB9A6E0", Slot = "6")]
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
		[Address(RVA = "0xB98850", Offset = "0xB98850", VA = "0xB98850")]
		public LeaderboardGetEntriesRequest(Leaderboard.Type leaderboardType)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xB9A6E8", Offset = "0xB9A6E8", VA = "0xB9A6E8", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xB9A7DC", Offset = "0xB9A7DC", VA = "0xB9A7DC", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xB9A7E4", Offset = "0xB9A7E4", VA = "0xB9A7E4", Slot = "7")]
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
		[Address(RVA = "0xB985DC", Offset = "0xB985DC", VA = "0xB985DC")]
		public LeaderboardUpdateUserEntryRequest(Leaderboard.Type leaderboardType)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xB9A96C", Offset = "0xB9A96C", VA = "0xB9A96C", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xB9AA60", Offset = "0xB9AA60", VA = "0xB9AA60", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xB9AA68", Offset = "0xB9AA68", VA = "0xB9AA68", Slot = "6")]
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
		[Address(RVA = "0xB9AAF4", Offset = "0xB9AAF4", VA = "0xB9AAF4")]
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
		[Address(RVA = "0xB9AB24", Offset = "0xB9AB24", VA = "0xB9AB24", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xB9AB64", Offset = "0xB9AB64", VA = "0xB9AB64", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xB9AB6C", Offset = "0xB9AB6C", VA = "0xB9AB6C", Slot = "7")]
		public override Dictionary<string, string> GetQueryParams()
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xB9AD74", Offset = "0xB9AD74", VA = "0xB9AD74")]
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
		[Address(RVA = "0xB9AD78", Offset = "0xB9AD78", VA = "0xB9AD78", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xB9ADB8", Offset = "0xB9ADB8", VA = "0xB9ADB8", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xB9ADC0", Offset = "0xB9ADC0", VA = "0xB9ADC0", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xB9ADC8", Offset = "0xB9ADC8", VA = "0xB9ADC8")]
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
		[Address(RVA = "0xB9ADCC", Offset = "0xB9ADCC", VA = "0xB9ADCC", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xB9AE0C", Offset = "0xB9AE0C", VA = "0xB9AE0C", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xB9AE14", Offset = "0xB9AE14", VA = "0xB9AE14", Slot = "7")]
		public override Dictionary<string, string> GetQueryParams()
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xB9AE60", Offset = "0xB9AE60", VA = "0xB9AE60")]
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
		[Address(RVA = "0xB9AE64", Offset = "0xB9AE64", VA = "0xB9AE64", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xB9AEA4", Offset = "0xB9AEA4", VA = "0xB9AEA4", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xB9AEAC", Offset = "0xB9AEAC", VA = "0xB9AEAC", Slot = "7")]
		public override Dictionary<string, string> GetQueryParams()
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xB9AEF8", Offset = "0xB9AEF8", VA = "0xB9AEF8")]
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
		[Address(RVA = "0xB9AEFC", Offset = "0xB9AEFC", VA = "0xB9AEFC", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xB9AF3C", Offset = "0xB9AF3C", VA = "0xB9AF3C", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xB9AF44", Offset = "0xB9AF44", VA = "0xB9AF44", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xB9AF4C", Offset = "0xB9AF4C", VA = "0xB9AF4C")]
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
		[Address(RVA = "0xB9AF50", Offset = "0xB9AF50", VA = "0xB9AF50", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xB9AF90", Offset = "0xB9AF90", VA = "0xB9AF90", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xB9AF98", Offset = "0xB9AF98", VA = "0xB9AF98", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xB9AFA0", Offset = "0xB9AFA0", VA = "0xB9AFA0")]
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
		[Address(RVA = "0xB9AFA4", Offset = "0xB9AFA4", VA = "0xB9AFA4", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xB9AFE4", Offset = "0xB9AFE4", VA = "0xB9AFE4", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xB9AFEC", Offset = "0xB9AFEC", VA = "0xB9AFEC", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xB9AFF4", Offset = "0xB9AFF4", VA = "0xB9AFF4")]
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
		[Address(RVA = "0xB9AFF8", Offset = "0xB9AFF8", VA = "0xB9AFF8", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xB9B038", Offset = "0xB9B038", VA = "0xB9B038", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xB9B040", Offset = "0xB9B040", VA = "0xB9B040", Slot = "7")]
		public override Dictionary<string, string> GetQueryParams()
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xB9B248", Offset = "0xB9B248", VA = "0xB9B248")]
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
		[Address(RVA = "0xB9B24C", Offset = "0xB9B24C", VA = "0xB9B24C", Slot = "4")]
		public override string getAPIEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xB9B28C", Offset = "0xB9B28C", VA = "0xB9B28C", Slot = "5")]
		public override RequestMethod GetMethod()
		{
			return default(RequestMethod);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xB9B294", Offset = "0xB9B294", VA = "0xB9B294", Slot = "6")]
		public override string GetBodyParams()
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xB9B29C", Offset = "0xB9B29C", VA = "0xB9B29C")]
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
				[Address(RVA = "0xB9D5C8", Offset = "0xB9D5C8", VA = "0xB9D5C8", Slot = "4")]
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
				[Address(RVA = "0xB9D610", Offset = "0xB9D610", VA = "0xB9D610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xB9BA68", Offset = "0xB9BA68", VA = "0xB9BA68")]
			[DebuggerHidden]
			public <PerformUploadRequest>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xB9D140", Offset = "0xB9D140", VA = "0xB9D140", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xB9D15C", Offset = "0xB9D15C", VA = "0xB9D15C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xB9D518", Offset = "0xB9D518", VA = "0xB9D518")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xB9D5D0", Offset = "0xB9D5D0", VA = "0xB9D5D0", Slot = "8")]
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
				[Address(RVA = "0xB9D8D4", Offset = "0xB9D8D4", VA = "0xB9D8D4", Slot = "4")]
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
				[Address(RVA = "0xB9D91C", Offset = "0xB9D91C", VA = "0xB9D91C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xB9BA90", Offset = "0xB9BA90", VA = "0xB9BA90")]
			[DebuggerHidden]
			public <PerformDownloadRequest>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xB9D66C", Offset = "0xB9D66C", VA = "0xB9D66C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xB9D670", Offset = "0xB9D670", VA = "0xB9D670", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xB9D8DC", Offset = "0xB9D8DC", VA = "0xB9D8DC", Slot = "8")]
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
				[Address(RVA = "0xB9DD2C", Offset = "0xB9DD2C", VA = "0xB9DD2C", Slot = "4")]
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
				[Address(RVA = "0xB9DD74", Offset = "0xB9DD74", VA = "0xB9DD74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xB9BB3C", Offset = "0xB9BB3C", VA = "0xB9BB3C")]
			[DebuggerHidden]
			public <PerformPutRequest>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xB9D978", Offset = "0xB9D978", VA = "0xB9D978", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xB9D994", Offset = "0xB9D994", VA = "0xB9D994", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xB9DC7C", Offset = "0xB9DC7C", VA = "0xB9DC7C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xB9DD34", Offset = "0xB9DD34", VA = "0xB9DD34", Slot = "8")]
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
				[Address(RVA = "0xB9E188", Offset = "0xB9E188", VA = "0xB9E188", Slot = "4")]
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
				[Address(RVA = "0xB9E1D0", Offset = "0xB9E1D0", VA = "0xB9E1D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xB9DDD0", Offset = "0xB9DDD0", VA = "0xB9DDD0")]
			[DebuggerHidden]
			public <PerformPostRequest>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xB9DDF8", Offset = "0xB9DDF8", VA = "0xB9DDF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0xB9DE14", Offset = "0xB9DE14", VA = "0xB9DE14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xB9E0D8", Offset = "0xB9E0D8", VA = "0xB9E0D8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0xB9E190", Offset = "0xB9E190", VA = "0xB9E190", Slot = "8")]
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
				[Address(RVA = "0xB9E5B0", Offset = "0xB9E5B0", VA = "0xB9E5B0", Slot = "4")]
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
				[Address(RVA = "0xB9E5F8", Offset = "0xB9E5F8", VA = "0xB9E5F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xB9E22C", Offset = "0xB9E22C", VA = "0xB9E22C")]
			[DebuggerHidden]
			public <PerformGetRequest>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xB9E254", Offset = "0xB9E254", VA = "0xB9E254", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xB9E270", Offset = "0xB9E270", VA = "0xB9E270", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xB9E500", Offset = "0xB9E500", VA = "0xB9E500")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xB9E5B8", Offset = "0xB9E5B8", VA = "0xB9E5B8", Slot = "8")]
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
			[Address(RVA = "0xB9B340", Offset = "0xB9B340", VA = "0xB9B340")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xB9B2A0", Offset = "0xB9B2A0", VA = "0xB9B2A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xB962A8", Offset = "0xB962A8", VA = "0xB962A8")]
		public void SendRequest(BaseRequest request, Action<JSONNode> onSuccess, Action<string> onError)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xB9B5D0", Offset = "0xB9B5D0", VA = "0xB9B5D0")]
		public void DownloadMultipleUrlsRequest(HashSet<string> urls, Action<bool, Dictionary<string, Texture2D>> onResponse)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xB96ECC", Offset = "0xB96ECC", VA = "0xB96ECC")]
		[IteratorStateMachine(typeof(<PerformUploadRequest>d__8))]
		public IEnumerator<float> PerformUploadRequest(string uploadUrl, byte[] content, string contentType, Action<string> onSuccess, Action<string> onError)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xB9B9A8", Offset = "0xB9B9A8", VA = "0xB9B9A8")]
		[IteratorStateMachine(typeof(<PerformDownloadRequest>d__9))]
		private IEnumerator<float> PerformDownloadRequest(string url, Texture2D texture, Action<string> onSuccess, Action<string> onError)
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xB9BAB8", Offset = "0xB9BAB8", VA = "0xB9BAB8")]
		private string BuildPutOrPostUrl(BaseRequest request)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xB9B450", Offset = "0xB9B450", VA = "0xB9B450")]
		[IteratorStateMachine(typeof(<PerformPutRequest>d__11))]
		private IEnumerator<float> PerformPutRequest(BaseRequest request, Action<JSONNode> onSuccess, Action<string> onError)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xB9B510", Offset = "0xB9B510", VA = "0xB9B510")]
		[IteratorStateMachine(typeof(<PerformPostRequest>d__12))]
		private IEnumerator<float> PerformPostRequest(BaseRequest request, Action<JSONNode> onSuccess, Action<string> onError)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xB9BB64", Offset = "0xB9BB64", VA = "0xB9BB64")]
		private string BuildGetUrl(BaseRequest request)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xB9BE80", Offset = "0xB9BE80", VA = "0xB9BE80")]
		private string BuildGetUrlParams(BaseRequest request)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xB9BBF4", Offset = "0xB9BBF4", VA = "0xB9BBF4")]
		private void AppendQueryParams(BaseRequest request)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xB9B390", Offset = "0xB9B390", VA = "0xB9B390")]
		[IteratorStateMachine(typeof(<PerformGetRequest>d__16))]
		private IEnumerator<float> PerformGetRequest(BaseRequest request, Action<JSONNode> onSuccess, Action<string> onError)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xB9BED0", Offset = "0xB9BED0", VA = "0xB9BED0")]
		private static void ValidateResponse(UnityWebRequest www, Action<JSONNode> onSuccess, Action<string> onError)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xB9C138", Offset = "0xB9C138", VA = "0xB9C138")]
		private static string StringifyServerError(JSONNode response)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xB9C594", Offset = "0xB9C594", VA = "0xB9C594")]
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
		[Address(RVA = "0xB9E654", Offset = "0xB9E654", VA = "0xB9E654", Slot = "4")]
		private void OneHumus.ISingleton.InitSingleton()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xB9E6AC", Offset = "0xB9E6AC", VA = "0xB9E6AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xB9E710", Offset = "0xB9E710", VA = "0xB9E710")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xB9E714", Offset = "0xB9E714", VA = "0xB9E714")]
		public void Init()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xB9E77C", Offset = "0xB9E77C", VA = "0xB9E77C")]
		public void getStats(string[] rnxId, StatsName statsName, Action<bool, Dictionary<string, StatsData>> onResponse)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xB9E9C4", Offset = "0xB9E9C4", VA = "0xB9E9C4")]
		public void getMyStats(string rnxId, StatsName statsName, Action<bool, StatsData> onResponse)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xB9EBD4", Offset = "0xB9EBD4", VA = "0xB9EBD4")]
		public void updateMyStats(string rnxId, StatsName statsName, StatsData statsData, Action<bool> onResponse)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xB9EE5C", Offset = "0xB9EE5C", VA = "0xB9EE5C")]
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
		[Address(RVA = "0xB9F76C", Offset = "0xB9F76C", VA = "0xB9F76C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xB9F7CC", Offset = "0xB9F7CC", VA = "0xB9F7CC")]
		private void StatsFlowTest()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xB9F940", Offset = "0xB9F940", VA = "0xB9F940")]
		public StatsTests()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class TestDriver : MonoBehaviour
	{
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xB9FE90", Offset = "0xB9FE90", VA = "0xB9FE90")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xBA0124", Offset = "0xBA0124", VA = "0xBA0124")]
		private void TestSignInFlow()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xBA03CC", Offset = "0xBA03CC", VA = "0xBA03CC")]
		private void TestTranslate()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xBA06DC", Offset = "0xBA06DC", VA = "0xBA06DC")]
		private void TestStatsFlow()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xB9FEBC", Offset = "0xB9FEBC", VA = "0xB9FEBC")]
		private void TestLeaderboardFlow()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xBA0950", Offset = "0xBA0950", VA = "0xBA0950")]
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
				[Address(RVA = "0xBA3CAC", Offset = "0xBA3CAC", VA = "0xBA3CAC", Slot = "4")]
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
				[Address(RVA = "0xBA3CF4", Offset = "0xBA3CF4", VA = "0xBA3CF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0xBA1908", Offset = "0xBA1908", VA = "0xBA1908")]
			[DebuggerHidden]
			public <KeepAliveCo>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0xBA3BEC", Offset = "0xBA3BEC", VA = "0xBA3BEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0xBA3BF0", Offset = "0xBA3BF0", VA = "0xBA3BF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0xBA3CB4", Offset = "0xBA3CB4", VA = "0xBA3CB4", Slot = "8")]
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
			[Address(RVA = "0xBA1788", Offset = "0xBA1788", VA = "0xBA1788")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x17000038")]
		public User Me
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xBA1930", Offset = "0xBA1930", VA = "0xBA1930")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public User LastMe
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xBA1938", Offset = "0xBA1938", VA = "0xBA1938")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public bool isSignedIn
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0xBA1940", Offset = "0xBA1940", VA = "0xBA1940")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000003")]
		public static event Action<Status> onMyStatusChanged
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0xBA2204", Offset = "0xBA2204", VA = "0xBA2204")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0xBA22D4", Offset = "0xBA22D4", VA = "0xBA22D4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xBA1790", Offset = "0xBA1790", VA = "0xBA1790")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xBA182C", Offset = "0xBA182C", VA = "0xBA182C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xBA1894", Offset = "0xBA1894", VA = "0xBA1894")]
		[IteratorStateMachine(typeof(<KeepAliveCo>d__16))]
		private IEnumerator<float> KeepAliveCo()
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xBA1950", Offset = "0xBA1950", VA = "0xBA1950")]
		public void SignIn(string userName, Platform platformName, string platformUserId, Texture2D avatarImage, string deviceModel, bool useFakeRnxID, string fakeRnxID, Action<bool, User> onResponse)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xBA1E3C", Offset = "0xBA1E3C", VA = "0xBA1E3C")]
		private void CalcClockOffset(string epochTime)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xBA2000", Offset = "0xBA2000", VA = "0xBA2000")]
		public void SignOut()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xBA23A4", Offset = "0xBA23A4", VA = "0xBA23A4")]
		public void SetMyStatus(Status status)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xBA2670", Offset = "0xBA2670", VA = "0xBA2670")]
		public void GetUsersStatus(List<string> rnxIds, Action<bool, Dictionary<string, Status>> onResponse)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xBA2888", Offset = "0xBA2888", VA = "0xBA2888")]
		public void KeepAlive()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xBA289C", Offset = "0xBA289C", VA = "0xBA289C")]
		public void GetUserDetails(string rnxId, Action<bool, User> onResponse)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xBA2A38", Offset = "0xBA2A38", VA = "0xBA2A38")]
		public void GetUsersDetails(List<string> rnxIds, Action<bool, Dictionary<string, User>> onResponse)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xBA2EA8", Offset = "0xBA2EA8", VA = "0xBA2EA8")]
		public void TranslatePlatformIds(List<string> platformUserIds, Platform platformName, Action<bool, Dictionary<string, string>> onResponse)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xBA3384", Offset = "0xBA3384", VA = "0xBA3384")]
		private void UploadAvatarImage(string uploadUrl, byte[] avatarByteArray, string avatarMD5)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xBA357C", Offset = "0xBA357C", VA = "0xBA357C")]
		private void UpdateServerAvatar(string avatarUrl, string avatarMD5)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xBA3778", Offset = "0xBA3778", VA = "0xBA3778")]
		private void downloadAvatarImages(List<User> users, Action<bool> onResponse)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xBA3A60", Offset = "0xBA3A60", VA = "0xBA3A60")]
		public Platform parsePlatform(string platformName)
		{
			return default(Platform);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xBA3B50", Offset = "0xBA3B50", VA = "0xBA3B50")]
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
		[Address(RVA = "0xBA5CF4", Offset = "0xBA5CF4", VA = "0xBA5CF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xBA5CF8", Offset = "0xBA5CF8", VA = "0xBA5CF8")]
		private void Start()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xBA6080", Offset = "0xBA6080", VA = "0xBA6080")]
		private void UserSignInTest()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xBA6220", Offset = "0xBA6220", VA = "0xBA6220")]
		private void KeepAliveTest()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xBA624C", Offset = "0xBA624C", VA = "0xBA624C")]
		private void SetMyStatusTest()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xBA6268", Offset = "0xBA6268", VA = "0xBA6268")]
		private void GetStatusTest()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xBA6470", Offset = "0xBA6470", VA = "0xBA6470")]
		private void TranslatePlatformIdsTest()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xBA6614", Offset = "0xBA6614", VA = "0xBA6614")]
		private void TranslatePlatformIdsCacheTest()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xBA5E30", Offset = "0xBA5E30", VA = "0xBA5E30")]
		private void GetUserDetailsTest()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xBA5D6C", Offset = "0xBA5D6C", VA = "0xBA5D6C")]
		private Texture2D dummyTexture()
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xBA67E8", Offset = "0xBA67E8", VA = "0xBA67E8")]
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
				[Address(RVA = "0xBA992C", Offset = "0xBA992C", VA = "0xBA992C", Slot = "6")]
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
				[Address(RVA = "0xBA9974", Offset = "0xBA9974", VA = "0xBA9974", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0xBA740C", Offset = "0xBA740C", VA = "0xBA740C")]
			[DebuggerHidden]
			public <get_Children>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x6000297")]
			[Address(RVA = "0xBA9910", Offset = "0xBA9910", VA = "0xBA9910", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000298")]
			[Address(RVA = "0xBA9914", Offset = "0xBA9914", VA = "0xBA9914", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0xBA9934", Offset = "0xBA9934", VA = "0xBA9934", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0xBA997C", Offset = "0xBA997C", VA = "0xBA997C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0xBA9A14", Offset = "0xBA9A14", VA = "0xBA9A14", Slot = "5")]
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
				[Address(RVA = "0xBAA080", Offset = "0xBAA080", VA = "0xBAA080", Slot = "6")]
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
				[Address(RVA = "0xBAA0C8", Offset = "0xBAA0C8", VA = "0xBAA0C8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0xBA74C4", Offset = "0xBA74C4", VA = "0xBA74C4")]
			[DebuggerHidden]
			public <get_DeepChildren>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0xBA9A18", Offset = "0xBA9A18", VA = "0xBA9A18", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002A0")]
			[Address(RVA = "0xBA9AD0", Offset = "0xBA9AD0", VA = "0xBA9AD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0xBA9FD0", Offset = "0xBA9FD0", VA = "0xBA9FD0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002A2")]
			[Address(RVA = "0xBA9F20", Offset = "0xBA9F20", VA = "0xBA9F20")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60002A4")]
			[Address(RVA = "0xBAA088", Offset = "0xBAA088", VA = "0xBAA088", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0xBAA0D0", Offset = "0xBAA0D0", VA = "0xBAA0D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0xBAA17C", Offset = "0xBAA17C", VA = "0xBAA17C", Slot = "5")]
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
			[Address(RVA = "0xBA7288", Offset = "0xBA7288", VA = "0xBA7288", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000254")]
			[Address(RVA = "0xBA7290", Offset = "0xBA7290", VA = "0xBA7290", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public virtual JSONNode this[string aKey]
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0xBA7294", Offset = "0xBA7294", VA = "0xBA7294", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000256")]
			[Address(RVA = "0xBA729C", Offset = "0xBA729C", VA = "0xBA729C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public virtual string Value
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0xBA72A0", Offset = "0xBA72A0", VA = "0xBA72A0", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xBA72E0", Offset = "0xBA72E0", VA = "0xBA72E0", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public virtual int Count
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0xBA72E4", Offset = "0xBA72E4", VA = "0xBA72E4", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000041")]
		public virtual bool IsNumber
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0xBA72EC", Offset = "0xBA72EC", VA = "0xBA72EC", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		public virtual bool IsString
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0xBA72F4", Offset = "0xBA72F4", VA = "0xBA72F4", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		public virtual bool IsBoolean
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0xBA72FC", Offset = "0xBA72FC", VA = "0xBA72FC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		public virtual bool IsNull
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0xBA7304", Offset = "0xBA7304", VA = "0xBA7304", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public virtual bool IsArray
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xBA730C", Offset = "0xBA730C", VA = "0xBA730C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public virtual bool IsObject
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xBA7314", Offset = "0xBA7314", VA = "0xBA7314", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public virtual IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xBA739C", Offset = "0xBA739C", VA = "0xBA739C", Slot = "22")]
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
			[Address(RVA = "0xBA7440", Offset = "0xBA7440", VA = "0xBA7440")]
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
			[Address(RVA = "0xBA761C", Offset = "0xBA761C", VA = "0xBA761C", Slot = "26")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0xBA7654", Offset = "0xBA7654", VA = "0xBA7654", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public virtual int AsInt
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0xBA7690", Offset = "0xBA7690", VA = "0xBA7690", Slot = "28")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xBA76C4", Offset = "0xBA76C4", VA = "0xBA76C4", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public virtual float AsFloat
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xBA76DC", Offset = "0xBA76DC", VA = "0xBA76DC", Slot = "30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xBA76FC", Offset = "0xBA76FC", VA = "0xBA76FC", Slot = "31")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xBA7710", Offset = "0xBA7710", VA = "0xBA7710", Slot = "32")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xBA77C8", Offset = "0xBA77C8", VA = "0xBA77C8", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xBA7840", Offset = "0xBA7840", VA = "0xBA7840", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public virtual JSONObject AsObject
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0xBA78B8", Offset = "0xBA78B8", VA = "0xBA78B8", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xBA731C", Offset = "0xBA731C", VA = "0xBA731C", Slot = "17")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xBA7320", Offset = "0xBA7320", VA = "0xBA7320", Slot = "18")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xBA7384", Offset = "0xBA7384", VA = "0xBA7384", Slot = "19")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xBA738C", Offset = "0xBA738C", VA = "0xBA738C", Slot = "20")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xBA7394", Offset = "0xBA7394", VA = "0xBA7394", Slot = "21")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xBA74F8", Offset = "0xBA74F8", VA = "0xBA74F8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xBA7584", Offset = "0xBA7584", VA = "0xBA7584", Slot = "23")]
		public virtual string ToString(int aIndent)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xBA7930", Offset = "0xBA7930", VA = "0xBA7930")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xB9F38C", Offset = "0xB9F38C", VA = "0xB9F38C")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xBA7B78", Offset = "0xBA7B78", VA = "0xBA7B78")]
		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xBA7C4C", Offset = "0xBA7C4C", VA = "0xBA7C4C")]
		public static implicit operator double(JSONNode d)
		{
			return default(double);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xBA7CD4", Offset = "0xBA7CD4", VA = "0xBA7CD4")]
		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xBA7D3C", Offset = "0xBA7D3C", VA = "0xBA7D3C")]
		public static implicit operator float(JSONNode d)
		{
			return default(float);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xBA7DC4", Offset = "0xBA7DC4", VA = "0xBA7DC4")]
		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xBA7E24", Offset = "0xBA7E24", VA = "0xBA7E24")]
		public static implicit operator int(JSONNode d)
		{
			return default(int);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xBA7EAC", Offset = "0xBA7EAC", VA = "0xBA7EAC")]
		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xBA7F78", Offset = "0xBA7F78", VA = "0xBA7F78")]
		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xBA7A04", Offset = "0xBA7A04", VA = "0xBA7A04")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xBA8000", Offset = "0xBA8000", VA = "0xBA8000")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xBA8070", Offset = "0xBA8070", VA = "0xBA8070", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xBA807C", Offset = "0xBA807C", VA = "0xBA807C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xBA8084", Offset = "0xBA8084", VA = "0xBA8084")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xBA8438", Offset = "0xBA8438", VA = "0xBA8438")]
		private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xBA85F4", Offset = "0xBA85F4", VA = "0xBA85F4")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xBA8D40", Offset = "0xBA8D40", VA = "0xBA8D40", Slot = "36")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xBA8D44", Offset = "0xBA8D44", VA = "0xBA8D44")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xBA8DC4", Offset = "0xBA8DC4", VA = "0xBA8DC4")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xBA8E14", Offset = "0xBA8E14", VA = "0xBA8E14")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xBA8E64", Offset = "0xBA8E64", VA = "0xBA8E64")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xBA8EB4", Offset = "0xBA8EB4", VA = "0xBA8EB4")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xBA8F04", Offset = "0xBA8F04", VA = "0xBA8F04")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xBA9104", Offset = "0xBA9104", VA = "0xBA9104")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xBA94B0", Offset = "0xBA94B0", VA = "0xBA94B0")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xBA9500", Offset = "0xBA9500", VA = "0xBA9500")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xBA9550", Offset = "0xBA9550", VA = "0xBA9550")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xBA95A0", Offset = "0xBA95A0", VA = "0xBA95A0")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xBA975C", Offset = "0xBA975C", VA = "0xBA975C")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xBA97AC", Offset = "0xBA97AC", VA = "0xBA97AC")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xBA9884", Offset = "0xBA9884", VA = "0xBA9884")]
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
				[Address(RVA = "0xBAADC8", Offset = "0xBAADC8", VA = "0xBAADC8", Slot = "6")]
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
				[Address(RVA = "0xBAAE10", Offset = "0xBAAE10", VA = "0xBAAE10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0xBAA8A0", Offset = "0xBAA8A0", VA = "0xBAA8A0")]
			[DebuggerHidden]
			public <get_Children>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xBAABB4", Offset = "0xBAABB4", VA = "0xBAABB4", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xBAABD0", Offset = "0xBAABD0", VA = "0xBAABD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0xBAAD78", Offset = "0xBAAD78", VA = "0xBAAD78")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xBAADD0", Offset = "0xBAADD0", VA = "0xBAADD0", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xBAAE18", Offset = "0xBAAE18", VA = "0xBAAE18", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xBAAEC4", Offset = "0xBAAEC4", VA = "0xBAAEC4", Slot = "5")]
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
				[Address(RVA = "0xBAB0DC", Offset = "0xBAB0DC", VA = "0xBAB0DC", Slot = "4")]
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
				[Address(RVA = "0xBAB124", Offset = "0xBAB124", VA = "0xBAB124", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xBAA948", Offset = "0xBAA948", VA = "0xBAA948")]
			[DebuggerHidden]
			public <GetEnumerator>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xBAAEC8", Offset = "0xBAAEC8", VA = "0xBAAEC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xBAAEE4", Offset = "0xBAAEE4", VA = "0xBAAEE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xBAB08C", Offset = "0xBAB08C", VA = "0xBAB08C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xBAB0E4", Offset = "0xBAB0E4", VA = "0xBAB0E4", Slot = "8")]
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
			[Address(RVA = "0xBAA180", Offset = "0xBAA180", VA = "0xBAA180", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000055")]
		public override bool IsArray
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0xBAA188", Offset = "0xBAA188", VA = "0xBAA188", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xBAA190", Offset = "0xBAA190", VA = "0xBAA190", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0xBAA2C4", Offset = "0xBAA2C4", VA = "0xBAA2C4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xBAA430", Offset = "0xBAA430", VA = "0xBAA430", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xBAA490", Offset = "0xBAA490", VA = "0xBAA490", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public override int Count
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xBAA5A8", Offset = "0xBAA5A8", VA = "0xBAA5A8", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000059")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0xBAA81C", Offset = "0xBAA81C", VA = "0xBAA81C", Slot = "22")]
			[IteratorStateMachine(typeof(<get_Children>d__18))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xBAA5F0", Offset = "0xBAA5F0", VA = "0xBAA5F0", Slot = "17")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xBAA708", Offset = "0xBAA708", VA = "0xBAA708", Slot = "20")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xBAA7BC", Offset = "0xBAA7BC", VA = "0xBAA7BC", Slot = "21")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xBAA8D4", Offset = "0xBAA8D4", VA = "0xBAA8D4", Slot = "37")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__19))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xBAA970", Offset = "0xBAA970", VA = "0xBAA970", Slot = "36")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xBAAA4C", Offset = "0xBAAA4C", VA = "0xBAAA4C", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xBA8C94", Offset = "0xBA8C94", VA = "0xBA8C94")]
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
				[Address(RVA = "0xBAC410", Offset = "0xBAC410", VA = "0xBAC410", Slot = "6")]
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
				[Address(RVA = "0xBAC458", Offset = "0xBAC458", VA = "0xBAC458", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0xBABB44", Offset = "0xBABB44", VA = "0xBABB44")]
			[DebuggerHidden]
			public <get_Children>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xBAC1E8", Offset = "0xBAC1E8", VA = "0xBAC1E8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xBAC204", Offset = "0xBAC204", VA = "0xBAC204", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xBAC3C0", Offset = "0xBAC3C0", VA = "0xBAC3C0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xBAC418", Offset = "0xBAC418", VA = "0xBAC418", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xBAC460", Offset = "0xBAC460", VA = "0xBAC460", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xBAC50C", Offset = "0xBAC50C", VA = "0xBAC50C", Slot = "5")]
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
				[Address(RVA = "0xBAC760", Offset = "0xBAC760", VA = "0xBAC760", Slot = "4")]
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
				[Address(RVA = "0xBAC7A8", Offset = "0xBAC7A8", VA = "0xBAC7A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xBABBEC", Offset = "0xBABBEC", VA = "0xBABBEC")]
			[DebuggerHidden]
			public <GetEnumerator>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xBAC510", Offset = "0xBAC510", VA = "0xBAC510", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xBAC52C", Offset = "0xBAC52C", VA = "0xBAC52C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xBAC710", Offset = "0xBAC710", VA = "0xBAC710")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xBAC768", Offset = "0xBAC768", VA = "0xBAC768", Slot = "8")]
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
			[Address(RVA = "0xBAB12C", Offset = "0xBAB12C", VA = "0xBAB12C", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700005F")]
		public override bool IsObject
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0xBAB134", Offset = "0xBAB134", VA = "0xBAB134", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xBAB13C", Offset = "0xBAB13C", VA = "0xBAB13C", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xBAB288", Offset = "0xBAB288", VA = "0xBAB288", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0xBAB3B0", Offset = "0xBAB3B0", VA = "0xBAB3B0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0xBAB450", Offset = "0xBAB450", VA = "0xBAB450", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public override int Count
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0xBAB588", Offset = "0xBAB588", VA = "0xBAB588", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000063")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xBABAC0", Offset = "0xBABAC0", VA = "0xBABAC0", Slot = "22")]
			[IteratorStateMachine(typeof(<get_Children>d__19))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xBAB5D8", Offset = "0xBAB5D8", VA = "0xBAB5D8", Slot = "17")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xBAB748", Offset = "0xBAB748", VA = "0xBAB748", Slot = "19")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xBAB80C", Offset = "0xBAB80C", VA = "0xBAB80C", Slot = "20")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xBAB8E8", Offset = "0xBAB8E8", VA = "0xBAB8E8", Slot = "21")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xBABB78", Offset = "0xBABB78", VA = "0xBABB78", Slot = "37")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__20))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xBABC14", Offset = "0xBABC14", VA = "0xBABC14", Slot = "36")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xBABE34", Offset = "0xBABE34", VA = "0xBABE34", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xBA8BE8", Offset = "0xBA8BE8", VA = "0xBA8BE8")]
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
			[Address(RVA = "0xBAC7B0", Offset = "0xBAC7B0", VA = "0xBAC7B0", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000069")]
		public override bool IsString
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xBAC7B8", Offset = "0xBAC7B8", VA = "0xBAC7B8", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		public override string Value
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xBAC7C0", Offset = "0xBAC7C0", VA = "0xBAC7C0", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xBAC7C8", Offset = "0xBAC7C8", VA = "0xBAC7C8", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xBA7990", Offset = "0xBA7990", VA = "0xBA7990")]
		public JSONString(string aData)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xBAC7D0", Offset = "0xBAC7D0", VA = "0xBAC7D0", Slot = "36")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xBAC81C", Offset = "0xBAC81C", VA = "0xBAC81C", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xBAC8BC", Offset = "0xBAC8BC", VA = "0xBAC8BC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xBAC9CC", Offset = "0xBAC9CC", VA = "0xBAC9CC", Slot = "2")]
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
			[Address(RVA = "0xBAC9EC", Offset = "0xBAC9EC", VA = "0xBAC9EC", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700006C")]
		public override bool IsNumber
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xBAC9F4", Offset = "0xBAC9F4", VA = "0xBAC9F4", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public override string Value
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xBAC9FC", Offset = "0xBAC9FC", VA = "0xBAC9FC", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xBACA08", Offset = "0xBACA08", VA = "0xBACA08", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public override double AsDouble
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xBACA44", Offset = "0xBACA44", VA = "0xBACA44", Slot = "26")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xBACA4C", Offset = "0xBACA4C", VA = "0xBACA4C", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xBA7BE0", Offset = "0xBA7BE0", VA = "0xBA7BE0")]
		public JSONNumber(double aData)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xBACA54", Offset = "0xBACA54", VA = "0xBACA54")]
		public JSONNumber(string aData)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xBACACC", Offset = "0xBACACC", VA = "0xBACACC", Slot = "36")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xBACB18", Offset = "0xBACB18", VA = "0xBACB18", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xBACB38", Offset = "0xBACB38", VA = "0xBACB38")]
		private static bool IsNumeric(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xBACCD8", Offset = "0xBACCD8", VA = "0xBACCD8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xBACDFC", Offset = "0xBACDFC", VA = "0xBACDFC", Slot = "2")]
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
			[Address(RVA = "0xBACE6C", Offset = "0xBACE6C", VA = "0xBACE6C", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000070")]
		public override bool IsBoolean
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0xBACE74", Offset = "0xBACE74", VA = "0xBACE74", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public override string Value
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0xBACE7C", Offset = "0xBACE7C", VA = "0xBACE7C", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0xBACE88", Offset = "0xBACE88", VA = "0xBACE88", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public override bool AsBool
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0xBACF04", Offset = "0xBACF04", VA = "0xBACF04", Slot = "32")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0xBACF0C", Offset = "0xBACF0C", VA = "0xBACF0C", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xBA7F0C", Offset = "0xBA7F0C", VA = "0xBA7F0C")]
		public JSONBool(bool aData)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xBACF18", Offset = "0xBACF18", VA = "0xBACF18")]
		public JSONBool(string aData)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xBACF90", Offset = "0xBACF90", VA = "0xBACF90", Slot = "36")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xBACFD8", Offset = "0xBACFD8", VA = "0xBACFD8", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xBAD050", Offset = "0xBAD050", VA = "0xBAD050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xBAD0C8", Offset = "0xBAD0C8", VA = "0xBAD0C8", Slot = "2")]
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
			[Address(RVA = "0xBAD0D4", Offset = "0xBAD0D4", VA = "0xBAD0D4", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000074")]
		public override bool IsNull
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xBAD0DC", Offset = "0xBAD0DC", VA = "0xBAD0DC", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		public override string Value
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0xBAD0E4", Offset = "0xBAD0E4", VA = "0xBAD0E4", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030E")]
			[Address(RVA = "0xBAD124", Offset = "0xBAD124", VA = "0xBAD124", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public override bool AsBool
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0xBAD128", Offset = "0xBAD128", VA = "0xBAD128", Slot = "32")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000310")]
			[Address(RVA = "0xBAD130", Offset = "0xBAD130", VA = "0xBAD130", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xBAD134", Offset = "0xBAD134", VA = "0xBAD134", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xBAD1C0", Offset = "0xBAD1C0", VA = "0xBAD1C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xBAD1C8", Offset = "0xBAD1C8", VA = "0xBAD1C8", Slot = "36")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xBAD1EC", Offset = "0xBAD1EC", VA = "0xBAD1EC", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xBA9458", Offset = "0xBA9458", VA = "0xBA9458")]
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
			[Address(RVA = "0xBAD240", Offset = "0xBAD240", VA = "0xBAD240", Slot = "25")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000078")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0xBAD2B0", Offset = "0xBAD2B0", VA = "0xBAD2B0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031B")]
			[Address(RVA = "0xBAD310", Offset = "0xBAD310", VA = "0xBAD310", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0xBAD394", Offset = "0xBAD394", VA = "0xBAD394", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0xBAD404", Offset = "0xBAD404", VA = "0xBAD404", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public override int AsInt
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0xBAD5F0", Offset = "0xBAD5F0", VA = "0xBAD5F0", Slot = "28")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000325")]
			[Address(RVA = "0xBAD65C", Offset = "0xBAD65C", VA = "0xBAD65C", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public override float AsFloat
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0xBAD6CC", Offset = "0xBAD6CC", VA = "0xBAD6CC", Slot = "30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000327")]
			[Address(RVA = "0xBAD738", Offset = "0xBAD738", VA = "0xBAD738", Slot = "31")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public override double AsDouble
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0xBAD7A8", Offset = "0xBAD7A8", VA = "0xBAD7A8", Slot = "26")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000329")]
			[Address(RVA = "0xBAD814", Offset = "0xBAD814", VA = "0xBAD814", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public override bool AsBool
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0xBAD884", Offset = "0xBAD884", VA = "0xBAD884", Slot = "32")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600032B")]
			[Address(RVA = "0xBAD8F0", Offset = "0xBAD8F0", VA = "0xBAD8F0", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0xBAD960", Offset = "0xBAD960", VA = "0xBAD960", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public override JSONObject AsObject
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0xBAD9C8", Offset = "0xBAD9C8", VA = "0xBAD9C8", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xBAA240", Offset = "0xBAA240", VA = "0xBAA240")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xBAB200", Offset = "0xBAB200", VA = "0xBAB200")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xBAD248", Offset = "0xBAD248", VA = "0xBAD248")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xBAD490", Offset = "0xBAD490", VA = "0xBAD490", Slot = "18")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xBAD514", Offset = "0xBAD514", VA = "0xBAD514", Slot = "17")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xBAD5A0", Offset = "0xBAD5A0", VA = "0xBAD5A0")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xBAD5B8", Offset = "0xBAD5B8", VA = "0xBAD5B8")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xBAD5D0", Offset = "0xBAD5D0", VA = "0xBAD5D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xBAD5E8", Offset = "0xBAD5E8", VA = "0xBAD5E8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xBADA30", Offset = "0xBADA30", VA = "0xBADA30", Slot = "24")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}
	}
	[Token(Token = "0x200007F")]
	public static class JSON
	{
		[Token(Token = "0x600032F")]
		[Address(RVA = "0xBADA84", Offset = "0xBADA84", VA = "0xBADA84")]
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
		[Address(RVA = "0xBADAD8", Offset = "0xBADAD8", VA = "0xBADAD8")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xBADBC4", Offset = "0xBADBC4", VA = "0xBADBC4")]
		private static void initialize()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xBADE2C", Offset = "0xBADE2C", VA = "0xBADE2C")]
		public static bool IsPermissionGranted(string permission)
		{
			return default(bool);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xBADFA0", Offset = "0xBADFA0", VA = "0xBADFA0")]
		public static void GrantPermission(string permission, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xBAE15C", Offset = "0xBAE15C", VA = "0xBAE15C")]
		private void permissionRequestCallbackInternal(string message)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xBAE1FC", Offset = "0xBAE1FC", VA = "0xBAE1FC")]
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
			[Address(RVA = "0xBAE2B8", Offset = "0xBAE2B8", VA = "0xBAE2B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xBAE204", Offset = "0xBAE204", VA = "0xBAE204")]
		public Buffer16BitStereo()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xBAE2C4", Offset = "0xBAE2C4", VA = "0xBAE2C4")]
		public int Read(byte[] bufferOut, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xBAE414", Offset = "0xBAE414", VA = "0xBAE414", Slot = "4")]
		public override void Append(int channel, short sampleValue)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xBAE528", Offset = "0xBAE528", VA = "0xBAE528", Slot = "5")]
		public override void AppendSamples(int channel, float[] samples)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xBAE740", Offset = "0xBAE740", VA = "0xBAE740", Slot = "8")]
		public sealed override void ClearBuffer()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xBAE7E8", Offset = "0xBAE7E8", VA = "0xBAE7E8", Slot = "9")]
		public override void SetStopFlag()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xBAE7EC", Offset = "0xBAE7EC", VA = "0xBAE7EC", Slot = "6")]
		public override void WriteBuffer(int val)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xBAE81C", Offset = "0xBAE81C", VA = "0xBAE81C", Slot = "7")]
		public override void Close()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class MP3SharpException : Exception
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0xBAE86C", Offset = "0xBAE86C", VA = "0xBAE86C")]
		public MP3SharpException()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xBAE8C4", Offset = "0xBAE8C4", VA = "0xBAE8C4")]
		public MP3SharpException(string message)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xBAE92C", Offset = "0xBAE92C", VA = "0xBAE92C")]
		public MP3SharpException(string message, Exception inner)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xBAE99C", Offset = "0xBAE99C", VA = "0xBAE99C")]
		protected MP3SharpException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xBAEA1C", Offset = "0xBAEA1C", VA = "0xBAEA1C")]
		public void PrintStackTrace()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xBAEAF8", Offset = "0xBAEAF8", VA = "0xBAEAF8")]
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
			[Address(RVA = "0xBAEBA0", Offset = "0xBAEBA0", VA = "0xBAEBA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0xBAEBA8", Offset = "0xBAEBA8", VA = "0xBAEBA8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public int ChunkSize
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0xBAF3EC", Offset = "0xBAF3EC", VA = "0xBAF3EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000083")]
		public override bool CanRead
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0xBAF3F4", Offset = "0xBAF3F4", VA = "0xBAF3F4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public override bool CanSeek
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0xBAF414", Offset = "0xBAF414", VA = "0xBAF414", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public override bool CanWrite
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0xBAF434", Offset = "0xBAF434", VA = "0xBAF434", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000086")]
		public override long Length
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0xBAF454", Offset = "0xBAF454", VA = "0xBAF454", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000087")]
		public override long Position
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0xBAF474", Offset = "0xBAF474", VA = "0xBAF474", Slot = "12")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000352")]
			[Address(RVA = "0xBAF494", Offset = "0xBAF494", VA = "0xBAF494", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public int Frequency
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0xBAF4B8", Offset = "0xBAF4B8", VA = "0xBAF4B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000089")]
		public short ChannelCount
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0xBAF4C0", Offset = "0xBAF4C0", VA = "0xBAF4C0")]
			get
			{
				return default(short);
			}
		}

		[Token(Token = "0x1700008A")]
		public SoundFormat Format
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0xBAF4C8", Offset = "0xBAF4C8", VA = "0xBAF4C8")]
			get
			{
				return default(SoundFormat);
			}
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xBAEBB4", Offset = "0xBAEBB4", VA = "0xBAEBB4")]
		public MP3Stream(string fileName)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xBAEC3C", Offset = "0xBAEC3C", VA = "0xBAEC3C")]
		public MP3Stream(string fileName, int chunkSize)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xBAEC34", Offset = "0xBAEC34", VA = "0xBAEC34")]
		public MP3Stream(Stream sourceStream)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xBAECC0", Offset = "0xBAECC0", VA = "0xBAECC0")]
		public MP3Stream(Stream sourceStream, int chunkSize)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xBAF4D0", Offset = "0xBAF4D0", VA = "0xBAF4D0", Slot = "21")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xBAF4F4", Offset = "0xBAF4F4", VA = "0xBAF4F4", Slot = "30")]
		public override long Seek(long pos, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xBAF518", Offset = "0xBAF518", VA = "0xBAF518", Slot = "31")]
		public override void SetLength(long len)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xBAF558", Offset = "0xBAF558", VA = "0xBAF558", Slot = "35")]
		public override void Write(byte[] buf, int ofs, int count)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xBAF598", Offset = "0xBAF598", VA = "0xBAF598")]
		public int DecodeFrames(int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xBAF5E8", Offset = "0xBAF5E8", VA = "0xBAF5E8", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xBAF684", Offset = "0xBAF684", VA = "0xBAF684", Slot = "19")]
		public override void Close()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xBAF128", Offset = "0xBAF128", VA = "0xBAF128")]
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
		[Address(RVA = "0xBAF938", Offset = "0xBAF938", VA = "0xBAF938")]
		public static int URShift(int number, int bits)
		{
			return default(int);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xBAF960", Offset = "0xBAF960", VA = "0xBAF960")]
		public static int URShift(int number, long bits)
		{
			return default(int);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xBAF988", Offset = "0xBAF988", VA = "0xBAF988")]
		public static long URShift(long number, int bits)
		{
			return default(long);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xBAF9B0", Offset = "0xBAF9B0", VA = "0xBAF9B0")]
		public static long URShift(long number, long bits)
		{
			return default(long);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xBAEAAC", Offset = "0xBAEAAC", VA = "0xBAEAAC")]
		public static void WriteStackTrace(Exception throwable, TextWriter stream)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xBAF9D8", Offset = "0xBAF9D8", VA = "0xBAF9D8")]
		public static long Identity(long literal)
		{
			return default(long);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xBAF9DC", Offset = "0xBAF9DC", VA = "0xBAF9DC")]
		public static ulong Identity(ulong literal)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xBAF9E0", Offset = "0xBAF9E0", VA = "0xBAF9E0")]
		public static float Identity(float literal)
		{
			return default(float);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xBAF9E4", Offset = "0xBAF9E4", VA = "0xBAF9E4")]
		public static double Identity(double literal)
		{
			return default(double);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xBAF9E8", Offset = "0xBAF9E8", VA = "0xBAF9E8")]
		public static int ReadInput(Stream sourceStream, ref sbyte[] target, int start, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xBAFAD4", Offset = "0xBAFAD4", VA = "0xBAFAD4")]
		public static byte[] ToByteArray(sbyte[] sbyteArray)
		{
			return null;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xBAFB78", Offset = "0xBAFB78", VA = "0xBAFB78")]
		public static byte[] ToByteArray(string sourceString)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xBAFC28", Offset = "0xBAFC28", VA = "0xBAFC28")]
		public static void GetSBytesFromString(string sourceString, int sourceStart, int sourceEnd, ref sbyte[] destinationArray, int destinationStart)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xBAFCB0", Offset = "0xBAFCB0", VA = "0xBAFCB0")]
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
		[Address(RVA = "0xBAFCB8", Offset = "0xBAFCB8", VA = "0xBAFCB8")]
		public static FileStream CreateRandomAccessFile(string fileName, string mode)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xBAFDD8", Offset = "0xBAFDD8", VA = "0xBAFDD8")]
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
				[Address(RVA = "0xBB1AE8", Offset = "0xBB1AE8", VA = "0xBB1AE8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0xBAFEB4", Offset = "0xBAFEB4", VA = "0xBAFEB4")]
			public RiffChunkHeader(RiffFile enclosingInstance)
			{
			}

			[Token(Token = "0x6000382")]
			[Address(RVA = "0xBB1AF0", Offset = "0xBB1AF0", VA = "0xBB1AF0")]
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
		[Address(RVA = "0xBAFDE0", Offset = "0xBAFDE0", VA = "0xBAFDE0")]
		public RiffFile()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xBAFFC4", Offset = "0xBAFFC4", VA = "0xBAFFC4", Slot = "4")]
		public virtual int CurrentFileMode()
		{
			return default(int);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xBAFFCC", Offset = "0xBAFFCC", VA = "0xBAFFCC", Slot = "5")]
		public virtual int Open(string filename, int newMode)
		{
			return default(int);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xBB058C", Offset = "0xBB058C", VA = "0xBB058C", Slot = "6")]
		public virtual int Open(Stream stream, int newMode)
		{
			return default(int);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xBB0B0C", Offset = "0xBB0B0C", VA = "0xBB0B0C", Slot = "7")]
		public virtual int Write(sbyte[] data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xBB0C0C", Offset = "0xBB0C0C", VA = "0xBB0C0C", Slot = "8")]
		public virtual int Write(short[] data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xBB0DC4", Offset = "0xBB0DC4", VA = "0xBB0DC4", Slot = "9")]
		public virtual int Write(RiffChunkHeader riffHeader, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xBB0F94", Offset = "0xBB0F94", VA = "0xBB0F94", Slot = "10")]
		public virtual int Write(short data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xBB10D4", Offset = "0xBB10D4", VA = "0xBB10D4", Slot = "11")]
		public virtual int Write(int data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xBB1214", Offset = "0xBB1214", VA = "0xBB1214", Slot = "12")]
		public virtual int Read(sbyte[] data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xBB12B8", Offset = "0xBB12B8", VA = "0xBB12B8", Slot = "13")]
		public virtual int Expect(string data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xBB13BC", Offset = "0xBB13BC", VA = "0xBB13BC", Slot = "14")]
		public virtual int Close()
		{
			return default(int);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xBB174C", Offset = "0xBB174C", VA = "0xBB174C", Slot = "15")]
		public virtual long CurrentFilePosition()
		{
			return default(long);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xBB17E8", Offset = "0xBB17E8", VA = "0xBB17E8", Slot = "16")]
		public virtual int Backpatch(long fileOffset, RiffChunkHeader data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xBB18BC", Offset = "0xBB18BC", VA = "0xBB18BC", Slot = "17")]
		public virtual int Backpatch(long fileOffset, sbyte[] data, int numBytes)
		{
			return default(int);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xBB1990", Offset = "0xBB1990", VA = "0xBB1990", Slot = "18")]
		protected internal virtual int Seek(long offset)
		{
			return default(int);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xBB1A38", Offset = "0xBB1A38", VA = "0xBB1A38")]
		private string DDCRET_String(int retcode)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xBAFEE4", Offset = "0xBAFEE4", VA = "0xBAFEE4")]
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
				[Address(RVA = "0xBB229C", Offset = "0xBB229C", VA = "0xBB229C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0xBB2240", Offset = "0xBB2240", VA = "0xBB2240")]
			public WaveFormatChunkData(WaveFile enclosingInstance)
			{
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0xBB22A4", Offset = "0xBB22A4", VA = "0xBB22A4")]
			private void InitBlock(WaveFile enclosingInstance)
			{
			}

			[Token(Token = "0x6000390")]
			[Address(RVA = "0xBB2030", Offset = "0xBB2030", VA = "0xBB2030")]
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
				[Address(RVA = "0xBB22AC", Offset = "0xBB22AC", VA = "0xBB22AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0xBB1C00", Offset = "0xBB1C00", VA = "0xBB1C00")]
			public WaveFormatChunk(WaveFile enclosingInstance)
			{
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0xBB22B4", Offset = "0xBB22B4", VA = "0xBB22B4")]
			private void InitBlock(WaveFile enclosingInstance)
			{
			}

			[Token(Token = "0x6000394")]
			[Address(RVA = "0xBB22BC", Offset = "0xBB22BC", VA = "0xBB22BC", Slot = "4")]
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
				[Address(RVA = "0xBB23FC", Offset = "0xBB23FC", VA = "0xBB23FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0xBB237C", Offset = "0xBB237C", VA = "0xBB237C")]
			public WaveFileSample(WaveFile enclosingInstance)
			{
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0xBB2404", Offset = "0xBB2404", VA = "0xBB2404")]
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
		[Address(RVA = "0xBB1AF8", Offset = "0xBB1AF8", VA = "0xBB1AF8")]
		public WaveFile()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xBB1D54", Offset = "0xBB1D54", VA = "0xBB1D54", Slot = "19")]
		public virtual int OpenForWrite(string filename, Stream stream, int samplingRate, short bitsPerSample, short numChannels)
		{
			return default(int);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xBB2078", Offset = "0xBB2078", VA = "0xBB2078", Slot = "20")]
		public virtual int WriteData(short[] data, int numData)
		{
			return default(int);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xBB20A8", Offset = "0xBB20A8", VA = "0xBB20A8", Slot = "14")]
		public override int Close()
		{
			return default(int);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xBB2108", Offset = "0xBB2108", VA = "0xBB2108")]
		public int Close(bool justWriteLengthBytes)
		{
			return default(int);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xBB2134", Offset = "0xBB2134", VA = "0xBB2134", Slot = "21")]
		public virtual int SamplingRate()
		{
			return default(int);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xBB2158", Offset = "0xBB2158", VA = "0xBB2158", Slot = "22")]
		public virtual short BitsPerSample()
		{
			return default(short);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xBB217C", Offset = "0xBB217C", VA = "0xBB217C", Slot = "23")]
		public virtual short NumChannels()
		{
			return default(short);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xBB21A0", Offset = "0xBB21A0", VA = "0xBB21A0", Slot = "24")]
		public virtual int NumSamples()
		{
			return default(int);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xBB21A8", Offset = "0xBB21A8", VA = "0xBB21A8", Slot = "25")]
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
		[Address(RVA = "0xBB240C", Offset = "0xBB240C", VA = "0xBB240C")]
		public WaveFileBuffer(int numberOfChannels, int freq, string fileName)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xBB25A0", Offset = "0xBB25A0", VA = "0xBB25A0")]
		public WaveFileBuffer(int numberOfChannels, int freq, Stream stream)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xBB26EC", Offset = "0xBB26EC", VA = "0xBB26EC", Slot = "4")]
		public override void Append(int channel, short valueRenamed)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xBB2750", Offset = "0xBB2750", VA = "0xBB2750", Slot = "6")]
		public override void WriteBuffer(int val)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xBB27D0", Offset = "0xBB27D0", VA = "0xBB27D0")]
		public void close(bool justWriteLengthBytes)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xBB2808", Offset = "0xBB2808", VA = "0xBB2808", Slot = "7")]
		public override void Close()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xBB282C", Offset = "0xBB282C", VA = "0xBB282C", Slot = "8")]
		public override void ClearBuffer()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xBB2830", Offset = "0xBB2830", VA = "0xBB2830", Slot = "9")]
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
		[Address(RVA = "0xBB2834", Offset = "0xBB2834", VA = "0xBB2834", Slot = "5")]
		public virtual void AppendSamples(int channel, float[] f)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xBB28F4", Offset = "0xBB28F4", VA = "0xBB28F4")]
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
		[Address(RVA = "0xBAE2B0", Offset = "0xBAE2B0", VA = "0xBAE2B0")]
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
		[Address(RVA = "0xBB293C", Offset = "0xBB293C", VA = "0xBB293C")]
		internal BitReserve()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xBB2964", Offset = "0xBB2964", VA = "0xBB2964")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xBB29BC", Offset = "0xBB29BC", VA = "0xBB29BC")]
		public int hsstell()
		{
			return default(int);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xBB29C4", Offset = "0xBB29C4", VA = "0xBB29C4")]
		public int ReadBits(int N)
		{
			return default(int);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xBB2AFC", Offset = "0xBB2AFC", VA = "0xBB2AFC")]
		public int ReadOneBit()
		{
			return default(int);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xBB2BA4", Offset = "0xBB2BA4", VA = "0xBB2BA4")]
		public void hputbuf(int val)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xBB2C94", Offset = "0xBB2C94", VA = "0xBB2C94")]
		public void RewindStreamBits(int bitCount)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xBB2CB8", Offset = "0xBB2CB8", VA = "0xBB2CB8")]
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
		[Address(RVA = "0xBAF018", Offset = "0xBAF018", VA = "0xBAF018")]
		internal Bitstream(PushbackStream stream)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xBB2D28", Offset = "0xBB2D28", VA = "0xBB2D28")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xBAF69C", Offset = "0xBAF69C", VA = "0xBAF69C")]
		public void close()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xBAF77C", Offset = "0xBAF77C", VA = "0xBAF77C")]
		internal Header readFrame()
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xBB2F04", Offset = "0xBB2F04", VA = "0xBB2F04")]
		private Header readNextFrame()
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xBB32EC", Offset = "0xBB32EC", VA = "0xBB32EC")]
		public void unreadFrame()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xBB2E5C", Offset = "0xBB2E5C", VA = "0xBB2E5C")]
		public void CloseFrame()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xBB3444", Offset = "0xBB3444", VA = "0xBB3444")]
		public bool IsSyncCurrentPosition(int syncmode)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xBB37B4", Offset = "0xBB37B4", VA = "0xBB37B4")]
		public int readBits(int n)
		{
			return default(int);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xBB38CC", Offset = "0xBB38CC", VA = "0xBB38CC")]
		public int readCheckedBits(int n)
		{
			return default(int);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xBB33E0", Offset = "0xBB33E0", VA = "0xBB33E0")]
		internal BitstreamException newBitstreamException(int errorcode)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xBB2E94", Offset = "0xBB2E94", VA = "0xBB2E94")]
		internal BitstreamException newBitstreamException(int errorcode, Exception throwable)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xBB391C", Offset = "0xBB391C", VA = "0xBB391C")]
		internal int syncHeader(sbyte syncmode)
		{
			return default(int);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xBB36E0", Offset = "0xBB36E0", VA = "0xBB36E0")]
		public bool isSyncMark(int headerstring, int syncmode, int word)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xBB3A50", Offset = "0xBB3A50", VA = "0xBB3A50")]
		internal void read_frame_data(int bytesize)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xBB3BF8", Offset = "0xBB3BF8", VA = "0xBB3BF8")]
		internal void ParseFrame()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xBB37B8", Offset = "0xBB37B8", VA = "0xBB37B8")]
		public int GetBitsFromBuffer(int countBits)
		{
			return default(int);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xBB3CEC", Offset = "0xBB3CEC", VA = "0xBB3CEC")]
		internal void SetSyncWord(int syncword0)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xBB3A90", Offset = "0xBB3A90", VA = "0xBB3A90")]
		private void readFully(sbyte[] b, int offs, int len)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xBB35A0", Offset = "0xBB35A0", VA = "0xBB35A0")]
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
			[Address(RVA = "0xBB3F48", Offset = "0xBB3F48", VA = "0xBB3F48", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xBB3DC8", Offset = "0xBB3DC8", VA = "0xBB3DC8")]
		public BitstreamException(string message, Exception inner)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xBB38D0", Offset = "0xBB38D0", VA = "0xBB38D0")]
		public BitstreamException(int errorcode, Exception inner)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xBB3EC4", Offset = "0xBB3EC4", VA = "0xBB3EC4")]
		protected BitstreamException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xBB3F50", Offset = "0xBB3F50", VA = "0xBB3F50", Slot = "10")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xBB3DE0", Offset = "0xBB3DE0", VA = "0xBB3DE0")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xBB3E40", Offset = "0xBB3E40", VA = "0xBB3E40")]
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
			[Address(RVA = "0xBB422C", Offset = "0xBB422C", VA = "0xBB422C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0xBB4234", Offset = "0xBB4234", VA = "0xBB4234")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public byte this[int index]
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xBB4368", Offset = "0xBB4368", VA = "0xBB4368")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0xBB4370", Offset = "0xBB4370", VA = "0xBB4370")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public int NumValid
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xBB43C0", Offset = "0xBB43C0", VA = "0xBB43C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xBB43C8", Offset = "0xBB43C8", VA = "0xBB43C8")]
			set
			{
			}
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xBB401C", Offset = "0xBB401C", VA = "0xBB401C")]
		public CircularByteBuffer(int size)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xBB4094", Offset = "0xBB4094", VA = "0xBB4094")]
		public CircularByteBuffer(CircularByteBuffer cdb)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xBB4494", Offset = "0xBB4494", VA = "0xBB4494")]
		public CircularByteBuffer Copy()
		{
			return null;
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xBB44F4", Offset = "0xBB44F4", VA = "0xBB44F4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xBB4500", Offset = "0xBB4500", VA = "0xBB4500")]
		public byte Push(byte newValue)
		{
			return default(byte);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xBB4624", Offset = "0xBB4624", VA = "0xBB4624")]
		public byte Pop()
		{
			return default(byte);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xBB4750", Offset = "0xBB4750", VA = "0xBB4750")]
		public byte Peek()
		{
			return default(byte);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xBB4320", Offset = "0xBB4320", VA = "0xBB4320")]
		private byte InternalGet(int offset)
		{
			return default(byte);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xBB4378", Offset = "0xBB4378", VA = "0xBB4378")]
		private void InternalSet(int offset, byte valueToSet)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xBB4818", Offset = "0xBB4818", VA = "0xBB4818")]
		public byte[] GetRange(int str, int stp)
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xBB48D4", Offset = "0xBB48D4", VA = "0xBB48D4", Slot = "3")]
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
		[Address(RVA = "0xBB4B5C", Offset = "0xBB4B5C", VA = "0xBB4B5C")]
		static Crc16()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xBB4BA8", Offset = "0xBB4BA8", VA = "0xBB4BA8")]
		public Crc16()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xBB4BC8", Offset = "0xBB4BC8", VA = "0xBB4BC8")]
		public void add_bits(int bitstring, int length)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xBB4C80", Offset = "0xBB4C80", VA = "0xBB4C80")]
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
				[Address(RVA = "0xBB558C", Offset = "0xBB558C", VA = "0xBB558C", Slot = "5")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003F3")]
				[Address(RVA = "0xBB5594", Offset = "0xBB5594", VA = "0xBB5594", Slot = "6")]
				set
				{
				}
			}

			[Token(Token = "0x1700009A")]
			public virtual Equalizer InitialEqualizerSettings
			{
				[Token(Token = "0x60003F4")]
				[Address(RVA = "0xBB55F4", Offset = "0xBB55F4", VA = "0xBB55F4", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xBB4D20", Offset = "0xBB4D20", VA = "0xBB4D20", Slot = "4")]
			public object Clone()
			{
				return null;
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xBB5584", Offset = "0xBB5584", VA = "0xBB5584")]
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
			[Address(RVA = "0xBAEEA4", Offset = "0xBAEEA4", VA = "0xBAEEA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public virtual Equalizer Equalizer
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xBB4E5C", Offset = "0xBB4E5C", VA = "0xBB4E5C", Slot = "4")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public virtual ABuffer OutputBuffer
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xBB4F28", Offset = "0xBB4F28", VA = "0xBB4F28", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public virtual int OutputFrequency
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xBB4F30", Offset = "0xBB4F30", VA = "0xBB4F30", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000097")]
		public virtual int OutputChannels
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xBB4F38", Offset = "0xBB4F38", VA = "0xBB4F38", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000098")]
		public virtual int OutputBlockSize
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xBB4F40", Offset = "0xBB4F40", VA = "0xBB4F40", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xBB4C94", Offset = "0xBB4C94", VA = "0xBB4C94")]
		public Decoder()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xBAEF50", Offset = "0xBAEF50", VA = "0xBAEF50")]
		public Decoder(Params params0)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xBB4CB0", Offset = "0xBB4CB0", VA = "0xBB4CB0")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xBB4F64", Offset = "0xBB4F64", VA = "0xBB4F64", Slot = "9")]
		public virtual ABuffer DecodeFrame(Header header, Bitstream stream)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xBB5200", Offset = "0xBB5200", VA = "0xBB5200", Slot = "10")]
		protected internal virtual DecoderException NewDecoderException(int errorcode)
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xBB52B0", Offset = "0xBB52B0", VA = "0xBB52B0", Slot = "11")]
		protected internal virtual DecoderException NewDecoderException(int errorcode, Exception throwable)
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xBB5320", Offset = "0xBB5320", VA = "0xBB5320", Slot = "12")]
		protected internal virtual IFrameDecoder RetrieveDecoder(Header header, Bitstream stream, int layer)
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xBB5080", Offset = "0xBB5080", VA = "0xBB5080")]
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
			[Address(RVA = "0xBB57F8", Offset = "0xBB57F8", VA = "0xBB57F8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xBB5678", Offset = "0xBB5678", VA = "0xBB5678")]
		public DecoderException(string message, Exception inner)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xBB5264", Offset = "0xBB5264", VA = "0xBB5264")]
		public DecoderException(int errorcode, Exception inner)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xBB5774", Offset = "0xBB5774", VA = "0xBB5774")]
		protected DecoderException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xBB5800", Offset = "0xBB5800", VA = "0xBB5800", Slot = "10")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xBB5690", Offset = "0xBB5690", VA = "0xBB5690")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xBB56F0", Offset = "0xBB56F0", VA = "0xBB56F0")]
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
			[Address(RVA = "0xBB5DD4", Offset = "0xBB5DD4", VA = "0xBB5DD4", Slot = "4")]
			public virtual float getBand(int band)
			{
				return default(float);
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0xBB5DDC", Offset = "0xBB5DDC", VA = "0xBB5DDC")]
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
			[Address(RVA = "0xBB5958", Offset = "0xBB5958", VA = "0xBB5958")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public virtual Equalizer FromEqualizer
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xBB5B50", Offset = "0xBB5B50", VA = "0xBB5B50", Slot = "4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public EQFunction FromEQFunction
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xBB5A3C", Offset = "0xBB5A3C", VA = "0xBB5A3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public virtual int BandCount
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xBB5B78", Offset = "0xBB5B78", VA = "0xBB5B78", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A0")]
		internal virtual float[] BandFactors
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xBB5B94", Offset = "0xBB5B94", VA = "0xBB5B94", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xBB4F48", Offset = "0xBB4F48", VA = "0xBB4F48")]
		public Equalizer()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xBB5924", Offset = "0xBB5924", VA = "0xBB5924")]
		public Equalizer(float[] settings)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xBB5A08", Offset = "0xBB5A08", VA = "0xBB5A08")]
		public Equalizer(EQFunction eq)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xBB58CC", Offset = "0xBB58CC", VA = "0xBB58CC")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xBB5AE0", Offset = "0xBB5AE0", VA = "0xBB5AE0")]
		public void reset()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xBB5CB8", Offset = "0xBB5CB8", VA = "0xBB5CB8")]
		public float setBand(int band, float neweq)
		{
			return default(float);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xBB5D20", Offset = "0xBB5D20", VA = "0xBB5D20")]
		public float getBand(int band)
		{
			return default(float);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xBB5B20", Offset = "0xBB5B20", VA = "0xBB5B20")]
		private float limit(float eq)
		{
			return default(float);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xBB5C40", Offset = "0xBB5C40", VA = "0xBB5C40")]
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
			[Address(RVA = "0xBB5E44", Offset = "0xBB5E44", VA = "0xBB5E44", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xBB2E70", Offset = "0xBB2E70", VA = "0xBB2E70")]
		internal Header()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xBB5DE4", Offset = "0xBB5DE4", VA = "0xBB5DE4")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xBB5E4C", Offset = "0xBB5E4C", VA = "0xBB5E4C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xBB2F3C", Offset = "0xBB2F3C", VA = "0xBB2F3C")]
		internal void read_header(Bitstream stream, Crc16[] crcp)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xBB6640", Offset = "0xBB6640", VA = "0xBB6640")]
		public int version()
		{
			return default(int);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xBB6648", Offset = "0xBB6648", VA = "0xBB6648")]
		public int layer()
		{
			return default(int);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xBB6650", Offset = "0xBB6650", VA = "0xBB6650")]
		public int bitrate_index()
		{
			return default(int);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xBB6658", Offset = "0xBB6658", VA = "0xBB6658")]
		public int sample_frequency()
		{
			return default(int);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xBAF89C", Offset = "0xBAF89C", VA = "0xBAF89C")]
		public int frequency()
		{
			return default(int);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xBB6660", Offset = "0xBB6660", VA = "0xBB6660")]
		public int mode()
		{
			return default(int);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xBB61F4", Offset = "0xBB61F4", VA = "0xBB61F4")]
		public bool IsProtection()
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xBB6668", Offset = "0xBB6668", VA = "0xBB6668")]
		public bool IsCopyright()
		{
			return default(bool);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xBB6670", Offset = "0xBB6670", VA = "0xBB6670")]
		public bool IsOriginal()
		{
			return default(bool);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xBB6678", Offset = "0xBB6678", VA = "0xBB6678")]
		public bool IsChecksumOK()
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xBB66A8", Offset = "0xBB66A8", VA = "0xBB66A8")]
		public bool IsPadding()
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xBB66B8", Offset = "0xBB66B8", VA = "0xBB66B8")]
		public int slots()
		{
			return default(int);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xBB66C0", Offset = "0xBB66C0", VA = "0xBB66C0")]
		public int mode_extension()
		{
			return default(int);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xBB6414", Offset = "0xBB6414", VA = "0xBB6414")]
		public int calculate_framesize()
		{
			return default(int);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xBB66C8", Offset = "0xBB66C8", VA = "0xBB66C8")]
		public int max_number_of_frames(int streamsize)
		{
			return default(int);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xBB66EC", Offset = "0xBB66EC", VA = "0xBB66EC")]
		public int min_number_of_frames(int streamsize)
		{
			return default(int);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xBB6710", Offset = "0xBB6710", VA = "0xBB6710")]
		public float ms_per_frame()
		{
			return default(float);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xBB68E8", Offset = "0xBB68E8", VA = "0xBB68E8")]
		public float total_ms(int streamsize)
		{
			return default(float);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xBB6010", Offset = "0xBB6010", VA = "0xBB6010")]
		public string layer_string()
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xBB6358", Offset = "0xBB6358", VA = "0xBB6358")]
		public string bitrate_string()
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xBB6204", Offset = "0xBB6204", VA = "0xBB6204")]
		public string sample_frequency_string()
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xBB60A8", Offset = "0xBB60A8", VA = "0xBB60A8")]
		public string mode_string()
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xBB6160", Offset = "0xBB6160", VA = "0xBB6160")]
		public string version_string()
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xBB6928", Offset = "0xBB6928", VA = "0xBB6928")]
		public int number_of_subbands()
		{
			return default(int);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xBB6930", Offset = "0xBB6930", VA = "0xBB6930")]
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
		[Address(RVA = "0xBBA224", Offset = "0xBBA224", VA = "0xBBA224")]
		static Huffman()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xBFAAF0", Offset = "0xBFAAF0", VA = "0xBFAAF0")]
		private Huffman(string S, int XLEN, int YLEN, int LINBITS, int LINMAX, int REF, int[] TABLE, int[] HLEN, int[][] VAL, int TREELEN)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xBFABE8", Offset = "0xBFABE8", VA = "0xBFABE8")]
		public static int Decode(Huffman h, int[] x, int[] y, int[] v, int[] w, BitReserve br)
		{
			return default(int);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xBFAFF4", Offset = "0xBFAFF4", VA = "0xBFAFF4")]
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
			[Address(RVA = "0xBFC458", Offset = "0xBFC458", VA = "0xBFC458", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A3")]
		public virtual int ChannelCount
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0xBFC460", Offset = "0xBFC460", VA = "0xBFC460", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xBFC3DC", Offset = "0xBFC3DC", VA = "0xBFC3DC")]
		private OutputChannels(int channels)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xBFC4CC", Offset = "0xBFC4CC", VA = "0xBFC4CC")]
		public static OutputChannels fromInt(int code)
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xBFC614", Offset = "0xBFC614", VA = "0xBFC614", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xBFC6A0", Offset = "0xBFC6A0", VA = "0xBFC6A0", Slot = "2")]
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
		[Address(RVA = "0xBFC7BC", Offset = "0xBFC7BC", VA = "0xBFC7BC")]
		public PushbackStream(Stream s, int backBufferSize)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xBFC894", Offset = "0xBFC894", VA = "0xBFC894")]
		public int Read(sbyte[] toRead, int offset, int length)
		{
			return default(int);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xBFCA24", Offset = "0xBFCA24", VA = "0xBFCA24")]
		public void UnRead(int length)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xBFCA94", Offset = "0xBFCA94", VA = "0xBFCA94")]
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
			[Address(RVA = "0xBFCBB8", Offset = "0xBFCBB8", VA = "0xBFCBB8", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A5")]
		public virtual int SampleFrequency
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0xBFCBC0", Offset = "0xBFCBC0", VA = "0xBFCBC0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A6")]
		public virtual short[] Buffer
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0xBFCBC8", Offset = "0xBFCBC8", VA = "0xBFCBC8", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public virtual int BufferLength
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0xBFCBD0", Offset = "0xBFCBD0", VA = "0xBFCBD0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xBFCAB8", Offset = "0xBFCAB8", VA = "0xBFCAB8")]
		public SampleBuffer(int sample_frequency, int number_of_channels)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xBFCBF8", Offset = "0xBFCBF8", VA = "0xBFCBF8", Slot = "4")]
		public override void Append(int channel, short valueRenamed)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xBFCC50", Offset = "0xBFCC50", VA = "0xBFCC50", Slot = "5")]
		public override void AppendSamples(int channel, float[] f)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xBFCD10", Offset = "0xBFCD10", VA = "0xBFCD10", Slot = "6")]
		public override void WriteBuffer(int val)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xBFCD14", Offset = "0xBFCD14", VA = "0xBFCD14", Slot = "7")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xBFCD18", Offset = "0xBFCD18", VA = "0xBFCD18", Slot = "8")]
		public override void ClearBuffer()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xBFCD74", Offset = "0xBFCD74", VA = "0xBFCD74", Slot = "9")]
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
			[Address(RVA = "0xBFD064", Offset = "0xBFD064", VA = "0xBFD064")]
			set
			{
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xBFCD78", Offset = "0xBFCD78", VA = "0xBFCD78")]
		public SynthesisFilter(int channelIndex, float factor, float[] eq0)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xBFCED4", Offset = "0xBFCED4", VA = "0xBFCED4")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xBFD16C", Offset = "0xBFD16C", VA = "0xBFD16C")]
		public void reset()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xBFD20C", Offset = "0xBFD20C", VA = "0xBFD20C")]
		public void WriteSample(float sample, int subbandIndex)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xBFD260", Offset = "0xBFD260", VA = "0xBFD260")]
		public void WriteAllSamples(float[] s)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xBFD2D0", Offset = "0xBFD2D0", VA = "0xBFD2D0")]
		private void compute_new_v()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xBFE3CC", Offset = "0xBFE3CC", VA = "0xBFE3CC")]
		private void compute_new_v_old()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xBFF82C", Offset = "0xBFF82C", VA = "0xBFF82C")]
		private void compute_pcm_samples0(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xBFFA8C", Offset = "0xBFFA8C", VA = "0xBFFA8C")]
		private void compute_pcm_samples1(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xBFFCF8", Offset = "0xBFFCF8", VA = "0xBFFCF8")]
		private void compute_pcm_samples2(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xBFFF64", Offset = "0xBFFF64", VA = "0xBFFF64")]
		private void compute_pcm_samples3(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xC001CC", Offset = "0xC001CC", VA = "0xC001CC")]
		private void compute_pcm_samples4(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xC0043C", Offset = "0xC0043C", VA = "0xC0043C")]
		private void compute_pcm_samples5(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xC006A8", Offset = "0xC006A8", VA = "0xC006A8")]
		private void compute_pcm_samples6(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xC00918", Offset = "0xC00918", VA = "0xC00918")]
		private void compute_pcm_samples7(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xC00B84", Offset = "0xC00B84", VA = "0xC00B84")]
		private void compute_pcm_samples8(ABuffer buffer)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xC00DF4", Offset = "0xC00DF4", VA = "0xC00DF4")]
		private void compute_pcm_samples9(ABuffer buffer)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xC01060", Offset = "0xC01060", VA = "0xC01060")]
		private void compute_pcm_samples10(ABuffer buffer)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xC012D0", Offset = "0xC012D0", VA = "0xC012D0")]
		private void compute_pcm_samples11(ABuffer buffer)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xC0153C", Offset = "0xC0153C", VA = "0xC0153C")]
		private void compute_pcm_samples12(ABuffer buffer)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xC017AC", Offset = "0xC017AC", VA = "0xC017AC")]
		private void compute_pcm_samples13(ABuffer buffer)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xC01A18", Offset = "0xC01A18", VA = "0xC01A18")]
		private void compute_pcm_samples14(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xC01C88", Offset = "0xC01C88", VA = "0xC01C88")]
		private void compute_pcm_samples15(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xC01EF4", Offset = "0xC01EF4", VA = "0xC01EF4")]
		private void compute_pcm_samples(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xC0204C", Offset = "0xC0204C", VA = "0xC0204C")]
		public void calculate_pcm_samples(ABuffer buffer)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xC020E8", Offset = "0xC020E8", VA = "0xC020E8")]
		private static float[] load_d()
		{
			return null;
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xBFCF2C", Offset = "0xBFCF2C", VA = "0xBFCF2C")]
		private static float[][] splitArray(float[] array, int blockSize)
		{
			return null;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xC020F0", Offset = "0xC020F0", VA = "0xC020F0")]
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
		[Address(RVA = "0xC022E4", Offset = "0xC022E4", VA = "0xC022E4")]
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
		[Address(RVA = "0xC0238C", Offset = "0xC0238C", VA = "0xC0238C")]
		public LayerIDecoder()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xC02400", Offset = "0xC02400", VA = "0xC02400", Slot = "5")]
		public virtual void DecodeFrame()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xC024F8", Offset = "0xC024F8", VA = "0xC024F8", Slot = "6")]
		public virtual void Create(Bitstream stream0, Header header0, SynthesisFilter filtera, SynthesisFilter filterb, ABuffer buffer0, int whichCh0)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xC02580", Offset = "0xC02580", VA = "0xC02580", Slot = "7")]
		protected internal virtual void CreateSubbands()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xC0281C", Offset = "0xC0281C", VA = "0xC0281C", Slot = "8")]
		protected internal virtual void ReadAllocation()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xC02894", Offset = "0xC02894", VA = "0xC02894", Slot = "9")]
		protected internal virtual void ReadScaleFactorSelection()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xC02898", Offset = "0xC02898", VA = "0xC02898", Slot = "10")]
		protected internal virtual void ReadScaleFactors()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xC0290C", Offset = "0xC0290C", VA = "0xC0290C", Slot = "11")]
		protected internal virtual void ReadSampleData()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	internal class LayerIIDecoder : LayerIDecoder, IFrameDecoder
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0xC02A8C", Offset = "0xC02A8C", VA = "0xC02A8C", Slot = "7")]
		protected internal override void CreateSubbands()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xC02D28", Offset = "0xC02D28", VA = "0xC02D28", Slot = "9")]
		protected internal override void ReadScaleFactorSelection()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xC02E18", Offset = "0xC02E18", VA = "0xC02E18")]
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
		[Address(RVA = "0xC02E1C", Offset = "0xC02E1C", VA = "0xC02E1C")]
		static LayerIIIDecoder()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xC03D90", Offset = "0xC03D90", VA = "0xC03D90")]
		public LayerIIIDecoder(Bitstream stream0, Header header0, SynthesisFilter filtera, SynthesisFilter filterb, ABuffer buffer0, int whichCh0)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xC04F8C", Offset = "0xC04F8C", VA = "0xC04F8C", Slot = "4")]
		public void DecodeFrame()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xC04D80", Offset = "0xC04D80", VA = "0xC04D80")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xC0540C", Offset = "0xC0540C", VA = "0xC0540C")]
		public void seek_notify()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xC04F90", Offset = "0xC04F90", VA = "0xC04F90")]
		public void Decode()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xC054D4", Offset = "0xC054D4", VA = "0xC054D4")]
		private bool ReadSideInfo()
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xC066D0", Offset = "0xC066D0", VA = "0xC066D0")]
		private void ReadScaleFactors(int ch, int gr)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xC0B4F0", Offset = "0xC0B4F0", VA = "0xC0B4F0")]
		private void get_LSF_scale_data(int ch, int gr)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xC08034", Offset = "0xC08034", VA = "0xC08034")]
		private void get_LSF_scale_factors(int ch, int gr)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xC0833C", Offset = "0xC0833C", VA = "0xC0833C")]
		private void HuffmanDecode(int ch, int gr)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xC0BC20", Offset = "0xC0BC20", VA = "0xC0BC20")]
		private void i_stereo_k_values(int is_pos, int io_type, int i)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xC089F0", Offset = "0xC089F0", VA = "0xC089F0")]
		private void dequantize_sample(float[][] xr, int ch, int gr)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xC0A8C0", Offset = "0xC0A8C0", VA = "0xC0A8C0")]
		private void Reorder(float[][] xr, int ch, int gr)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xC09348", Offset = "0xC09348", VA = "0xC09348")]
		private void stereo(int gr)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xC0AD24", Offset = "0xC0AD24", VA = "0xC0AD24")]
		private void Antialias(int ch, int gr)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xC0AF30", Offset = "0xC0AF30", VA = "0xC0AF30")]
		private void Hybrid(int ch, int gr)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xC0A798", Offset = "0xC0A798", VA = "0xC0A798")]
		private void doDownMix()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xC0BE48", Offset = "0xC0BE48", VA = "0xC0BE48")]
		public void InverseMDCT(float[] inValues, float[] outValues, int blockType)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xC03CC0", Offset = "0xC03CC0", VA = "0xC03CC0")]
		private static float[] create_t_43()
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xC04E9C", Offset = "0xC04E9C", VA = "0xC04E9C")]
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
		[Address(RVA = "0xC0CBB4", Offset = "0xC0CBB4", VA = "0xC0CBB4")]
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
		[Address(RVA = "0xC0CD0C", Offset = "0xC0CD0C", VA = "0xC0CD0C")]
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
		[Address(RVA = "0xC0CD8C", Offset = "0xC0CD8C", VA = "0xC0CD8C")]
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
		[Address(RVA = "0xC0CEB4", Offset = "0xC0CEB4", VA = "0xC0CEB4")]
		public SBI()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xC0CF34", Offset = "0xC0CF34", VA = "0xC0CF34")]
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
		[Address(RVA = "0xC0CF78", Offset = "0xC0CF78", VA = "0xC0CF78")]
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
			[Address(RVA = "0xC0D194", Offset = "0xC0D194", VA = "0xC0D194")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xC0D098", Offset = "0xC0D098", VA = "0xC0D098")]
		public ScaleFactorTable(LayerIIIDecoder enclosingInstance)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xC0D134", Offset = "0xC0D134", VA = "0xC0D134")]
		public ScaleFactorTable(LayerIIIDecoder enclosingInstance, int[] thel, int[] thes)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xC0D19C", Offset = "0xC0D19C", VA = "0xC0D19C")]
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
		[Address(RVA = "0xC0D1A4", Offset = "0xC0D1A4", VA = "0xC0D1A4")]
		public SubbandLayer2(int subbandnumber)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xC0D300", Offset = "0xC0D300", VA = "0xC0D300")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xC0D390", Offset = "0xC0D390", VA = "0xC0D390", Slot = "8")]
		protected internal virtual int get_allocationlength(Header header)
		{
			return default(int);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xC0D41C", Offset = "0xC0D41C", VA = "0xC0D41C", Slot = "9")]
		protected internal virtual void prepare_sample_reading(Header header, int allocation, int channel, float[] factor, int[] codelength, float[] c, float[] d)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xC0D9BC", Offset = "0xC0D9BC", VA = "0xC0D9BC", Slot = "4")]
		public override void ReadBitAllocation(Bitstream stream, Header header, Crc16 crc)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xC0DA3C", Offset = "0xC0DA3C", VA = "0xC0DA3C", Slot = "10")]
		public virtual void read_scalefactor_selection(Bitstream stream, Crc16 crc)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xC0DA9C", Offset = "0xC0DA9C", VA = "0xC0DA9C", Slot = "5")]
		public override void ReadScaleFactor(Bitstream stream, Header header)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xC0DD38", Offset = "0xC0DD38", VA = "0xC0DD38", Slot = "6")]
		public override bool ReadSampleData(Bitstream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xC0DF5C", Offset = "0xC0DF5C", VA = "0xC0DF5C", Slot = "7")]
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
		[Address(RVA = "0xC0E9B0", Offset = "0xC0E9B0", VA = "0xC0E9B0")]
		public SubbandLayer2IntensityStereo(int subbandnumber)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xC0EA14", Offset = "0xC0EA14", VA = "0xC0EA14", Slot = "4")]
		public override void ReadBitAllocation(Bitstream stream, Header header, Crc16 crc)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xC0EA18", Offset = "0xC0EA18", VA = "0xC0EA18", Slot = "10")]
		public override void read_scalefactor_selection(Bitstream stream, Crc16 crc)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xC0EAA4", Offset = "0xC0EAA4", VA = "0xC0EAA4", Slot = "5")]
		public override void ReadScaleFactor(Bitstream stream, Header header)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xC0ED20", Offset = "0xC0ED20", VA = "0xC0ED20", Slot = "6")]
		public override bool ReadSampleData(Bitstream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xC0ED24", Offset = "0xC0ED24", VA = "0xC0ED24", Slot = "7")]
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
		[Address(RVA = "0xC0EF3C", Offset = "0xC0EF3C", VA = "0xC0EF3C")]
		public SubbandLayer2Stereo(int subbandnumber)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xC0F05C", Offset = "0xC0F05C", VA = "0xC0F05C", Slot = "4")]
		public override void ReadBitAllocation(Bitstream stream, Header header, Crc16 crc)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xC0F104", Offset = "0xC0F104", VA = "0xC0F104", Slot = "10")]
		public override void read_scalefactor_selection(Bitstream stream, Crc16 crc)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xC0F1A0", Offset = "0xC0F1A0", VA = "0xC0F1A0", Slot = "5")]
		public override void ReadScaleFactor(Bitstream stream, Header header)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xC0F44C", Offset = "0xC0F44C", VA = "0xC0F44C", Slot = "6")]
		public override bool ReadSampleData(Bitstream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xC0F67C", Offset = "0xC0F67C", VA = "0xC0F67C", Slot = "7")]
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
		[Address(RVA = "0xC0F824", Offset = "0xC0F824", VA = "0xC0F824")]
		public SubbandLayer1(int subbandnumber)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xC0F894", Offset = "0xC0F894", VA = "0xC0F894", Slot = "4")]
		public override void ReadBitAllocation(Bitstream stream, Header header, Crc16 crc)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xC0F98C", Offset = "0xC0F98C", VA = "0xC0F98C", Slot = "5")]
		public override void ReadScaleFactor(Bitstream stream, Header header)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xC0FA2C", Offset = "0xC0FA2C", VA = "0xC0FA2C", Slot = "6")]
		public override bool ReadSampleData(Bitstream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xC0FA80", Offset = "0xC0FA80", VA = "0xC0FA80", Slot = "7")]
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
		[Address(RVA = "0xC0FC14", Offset = "0xC0FC14", VA = "0xC0FC14")]
		public SubbandLayer1IntensityStereo(int subbandnumber)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xC0FC78", Offset = "0xC0FC78", VA = "0xC0FC78", Slot = "4")]
		public override void ReadBitAllocation(Bitstream stream, Header header, Crc16 crc)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xC0FC7C", Offset = "0xC0FC7C", VA = "0xC0FC7C", Slot = "5")]
		public override void ReadScaleFactor(Bitstream stream, Header header)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xC0FD5C", Offset = "0xC0FD5C", VA = "0xC0FD5C", Slot = "6")]
		public override bool ReadSampleData(Bitstream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xC0FD60", Offset = "0xC0FD60", VA = "0xC0FD60", Slot = "7")]
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
		[Address(RVA = "0xC0FE88", Offset = "0xC0FE88", VA = "0xC0FE88")]
		public SubbandLayer1Stereo(int subbandnumber)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xC0FEEC", Offset = "0xC0FEEC", VA = "0xC0FEEC", Slot = "4")]
		public override void ReadBitAllocation(Bitstream stream, Header header, Crc16 crc)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xC1007C", Offset = "0xC1007C", VA = "0xC1007C", Slot = "5")]
		public override void ReadScaleFactor(Bitstream stream, Header header)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xC10178", Offset = "0xC10178", VA = "0xC10178", Slot = "6")]
		public override bool ReadSampleData(Bitstream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xC101D8", Offset = "0xC101D8", VA = "0xC101D8", Slot = "7")]
		public override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2)
		{
			return default(bool);
		}
	}
}
